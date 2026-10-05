Imports System.IO
Imports System.Text
Imports Npgsql
Imports NpgsqlTypes

' Usa la clase ItemTicket del módulo Impresion.vb
Module RegistroVentas

    ' =====================================================================
    '  GUARDAR UNA VENTA (cabecera + detalle en una sola transacción)
    '  Devuelve el id de la venta, o 0 si hubo un error (no se guarda nada).
    ' =====================================================================
    Public Function GuardarVenta(items As List(Of ItemTicket),
                                 nombre As String,
                                 ruc As String,
                                 total As Decimal,
                                 recibido As Decimal,
                                 vuelto As Decimal) As Integer

        If items Is Nothing OrElse items.Count = 0 Then Return 0

        Dim subtotal As Decimal = items.Sum(Function(i) i.Subtotal)
        Dim iva10 As Decimal = Math.Round(total / 11D, 0)
        Dim nombreFinal As String = If(String.IsNullOrWhiteSpace(nombre), "SIN NOMBRE", nombre.Trim())
        Dim rucFinal As String = If(String.IsNullOrWhiteSpace(ruc), "---", ruc.Trim())

        Try
            Using cnn As New NpgsqlConnection(cadena)
                cnn.Open()
                Using tx As NpgsqlTransaction = cnn.BeginTransaction()
                    Dim idVenta As Integer

                    Using cmd As New NpgsqlCommand(
                        "INSERT INTO ventas (cliente_nombre, cliente_ruc, subtotal, iva10, total, monto_recibido, vuelto, id_usuario) " &
                        "VALUES (@nombre, @ruc, @subtotal, @iva, @total, @recibido, @vuelto, @usuario) " &
                        "RETURNING id_venta", cnn, tx)
                        cmd.Parameters.AddWithValue("@nombre", nombreFinal)
                        cmd.Parameters.AddWithValue("@ruc", rucFinal)
                        cmd.Parameters.AddWithValue("@subtotal", subtotal)
                        cmd.Parameters.AddWithValue("@iva", iva10)
                        cmd.Parameters.AddWithValue("@total", total)
                        cmd.Parameters.AddWithValue("@recibido", recibido)
                        cmd.Parameters.AddWithValue("@vuelto", vuelto)
                        cmd.Parameters.AddWithValue("@usuario", co_usuario) ' variable del módulo Conexión
                        idVenta = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    For Each it As ItemTicket In items
                        Using cmdDet As New NpgsqlCommand(
                            "INSERT INTO ventas_detalle (id_venta, codigo, producto, precio, cantidad, subtotal) " &
                            "VALUES (@id, @codigo, @producto, @precio, @cantidad, @subtotal)", cnn, tx)
                            cmdDet.Parameters.AddWithValue("@id", idVenta)
                            cmdDet.Parameters.AddWithValue("@codigo", If(it.Codigo, ""))
                            cmdDet.Parameters.AddWithValue("@producto", it.Producto)
                            cmdDet.Parameters.AddWithValue("@precio", it.Precio)
                            cmdDet.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(it.Cantidad))
                            cmdDet.Parameters.AddWithValue("@subtotal", it.Subtotal)
                            cmdDet.ExecuteNonQuery()
                        End Using
                    Next

                    tx.Commit()
                    Return idVenta
                End Using
            End Using
        Catch ex As Exception
            MsgBox("No se pudo guardar la venta: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    ' =====================================================================
    '  TOTALES RÁPIDOS (para mostrar en etiquetas)
    ' =====================================================================
    Public Function TotalHoy() As Decimal
        Return TotalVendido(Date.Today, Date.Today.AddDays(1))
    End Function

    Public Function TotalSemana() As Decimal
        Dim ini As Date = InicioSemana(Date.Today)
        Return TotalVendido(ini, ini.AddDays(7))
    End Function

    Public Function TotalMes() As Decimal
        Dim ini As Date = InicioMes(Date.Today)
        Return TotalVendido(ini, ini.AddMonths(1))
    End Function

    ' Suma el total vendido en el rango [desde, hastaExclusivo)
    Public Function TotalVendido(desde As Date, hastaExclusivo As Date) As Decimal
        Dim dt As DataTable = ConsultaConParametros(
            "SELECT COALESCE(SUM(total), 0) FROM ventas WHERE fecha >= @desde AND fecha < @hasta",
            ParamFecha("@desde", desde), ParamFecha("@hasta", hastaExclusivo))
        Return Convert.ToDecimal(dt.Rows(0)(0))
    End Function

    ' =====================================================================
    '  REPORTES (devuelven DataTable para mostrar en un DataGridView)
    ' =====================================================================

    ' Resumen: cantidad de ventas, total y ticket promedio del rango
    Public Function ResumenVentas(desde As Date, hastaExclusivo As Date) As DataTable
        Return ConsultaConParametros(
            "SELECT COUNT(*) AS cantidad_ventas, " &
            "COALESCE(SUM(total), 0) AS total_vendido, " &
            "COALESCE(AVG(total), 0) AS ticket_promedio " &
            "FROM ventas WHERE fecha >= @desde AND fecha < @hasta",
            ParamFecha("@desde", desde), ParamFecha("@hasta", hastaExclusivo))
    End Function

    ' Total por cada día del rango (sirve para ver la semana o el mes día por día)
    Public Function VentasPorDia(desde As Date, hastaExclusivo As Date) As DataTable
        Return ConsultaConParametros(
            "SELECT fecha::date AS dia, COUNT(*) AS cantidad_ventas, SUM(total) AS total_vendido " &
            "FROM ventas WHERE fecha >= @desde AND fecha < @hasta " &
            "GROUP BY fecha::date ORDER BY dia",
            ParamFecha("@desde", desde), ParamFecha("@hasta", hastaExclusivo))
    End Function

    ' Listado completo de ventas del rango con todos sus datos
    Public Function ListadoVentas(desde As Date, hastaExclusivo As Date) As DataTable
        Return ConsultaConParametros(
            "SELECT id_venta, fecha, cliente_nombre, cliente_ruc, subtotal, iva10, total, " &
            "monto_recibido, vuelto, id_usuario " &
            "FROM ventas WHERE fecha >= @desde AND fecha < @hasta ORDER BY fecha",
            ParamFecha("@desde", desde), ParamFecha("@hasta", hastaExclusivo))
    End Function

    ' Productos de una venta puntual
    Public Function DetalleDeVenta(idVenta As Integer) As DataTable
        Return ConsultaConParametros(
            "SELECT codigo, producto, precio, cantidad, subtotal FROM ventas_detalle WHERE id_venta = @id ORDER BY id_detalle",
            New NpgsqlParameter("@id", NpgsqlDbType.Integer) With {.Value = idVenta})
    End Function

    ' =====================================================================
    '  FECHAS
    ' =====================================================================
    Public Function InicioSemana(d As Date) As Date   ' lunes de esa semana
        Dim diff As Integer = (7 + CInt(d.DayOfWeek) - CInt(DayOfWeek.Monday)) Mod 7
        Return d.Date.AddDays(-diff)
    End Function

    Public Function InicioMes(d As Date) As Date
        Return New Date(d.Year, d.Month, 1)
    End Function

    ' =====================================================================
    '  EXPORTAR A EXCEL (CSV con ; que Excel abre directamente)
    ' =====================================================================
    Public Sub ExportarCsv(dt As DataTable, ruta As String)
        Using sw As New StreamWriter(ruta, False, New UTF8Encoding(True))
            sw.WriteLine(String.Join(";", dt.Columns.Cast(Of DataColumn)().Select(Function(c) c.ColumnName)))
            For Each r As DataRow In dt.Rows
                sw.WriteLine(String.Join(";", r.ItemArray.Select(Function(v) CampoCsv(v))))
            Next
        End Using
    End Sub

    Private Function CampoCsv(v As Object) As String
        If v Is Nothing OrElse IsDBNull(v) Then Return ""
        Dim s As String = Convert.ToString(v, Globalization.CultureInfo.CurrentCulture)
        If s.Contains(";") OrElse s.Contains("""") OrElse s.Contains(vbCr) OrElse s.Contains(vbLf) Then
            s = """" & s.Replace("""", """""") & """"
        End If
        Return s
    End Function

    ' =====================================================================
    '  AYUDANTES INTERNOS
    ' =====================================================================
    Private Function ParamFecha(nombre As String, valor As Date) As NpgsqlParameter
        Return New NpgsqlParameter(nombre, NpgsqlDbType.Date) With {.Value = valor}
    End Function

    Private Function ConsultaConParametros(sql As String, ParamArray parametros As NpgsqlParameter()) As DataTable
        Dim dt As New DataTable()
        Using cnn As New NpgsqlConnection(cadena)
            Using cmd As New NpgsqlCommand(sql, cnn)
                cmd.Parameters.AddRange(parametros)
                Using da As New NpgsqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Module
