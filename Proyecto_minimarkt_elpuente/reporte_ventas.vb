Public Class reporte_ventas

    Private Sub reporte_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        For Each g In {dgvVentas, dgvDetalle}
            g.ReadOnly = True
            g.AllowUserToAddRows = False
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Next
        ActualizarTotales()
        MostrarRango(Date.Today, Date.Today.AddDays(1))
    End Sub

    ' Muestra las ventas del rango [desde, hastaExclusivo) y su resumen
    Private Sub MostrarRango(desde As Date, hastaExclusivo As Date)
        dgvVentas.DataSource = RegistroVentas.ListadoVentas(desde, hastaExclusivo)
        dgvDetalle.DataSource = Nothing

        Dim r As DataRow = RegistroVentas.ResumenVentas(desde, hastaExclusivo).Rows(0)
        lblResumen.Text = "Ventas: " & r("cantidad_ventas").ToString() &
                          "   |   Total: " & Convert.ToDecimal(r("total_vendido")).ToString("N0") &
                          "   |   Promedio: " & Convert.ToDecimal(r("ticket_promedio")).ToString("N0")
    End Sub

    Private Sub ActualizarTotales()
        lblHoy.Text = "Hoy: " & RegistroVentas.TotalHoy().ToString("N0")
        lblSemana.Text = "Semana: " & RegistroVentas.TotalSemana().ToString("N0")
        lblMes.Text = "Mes: " & RegistroVentas.TotalMes().ToString("N0")
    End Sub

    Private Sub btnHoy_Click(sender As Object, e As EventArgs) Handles btnHoy.Click
        MostrarRango(Date.Today, Date.Today.AddDays(1))
    End Sub

    Private Sub btnSemana_Click(sender As Object, e As EventArgs) Handles btnSemana.Click
        Dim ini As Date = RegistroVentas.InicioSemana(Date.Today)
        MostrarRango(ini, ini.AddDays(7))
    End Sub

    Private Sub btnMes_Click(sender As Object, e As EventArgs) Handles btnMes.Click
        Dim ini As Date = RegistroVentas.InicioMes(Date.Today)
        MostrarRango(ini, ini.AddMonths(1))
    End Sub

    ' Rango personalizado con los dos DateTimePicker (incluye el día "hasta" completo)
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If dtpDesde.Value.Date > dtpHasta.Value.Date Then
            MsgBox("La fecha 'desde' no puede ser mayor que 'hasta'.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        MostrarRango(dtpDesde.Value.Date, dtpHasta.Value.Date.AddDays(1))
    End Sub

    ' Al hacer clic en una venta, muestra sus productos
    Private Sub dgvVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        If e.RowIndex >= 0 Then
            Dim idVenta As Integer = Convert.ToInt32(dgvVentas.Rows(e.RowIndex).Cells("id_venta").Value)
            dgvDetalle.DataSource = RegistroVentas.DetalleDeVenta(idVenta)
        End If
    End Sub

    ' Exporta lo que se ve en la grilla a un archivo para Excel
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim dt As DataTable = TryCast(dgvVentas.DataSource, DataTable)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MsgBox("No hay datos para exportar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Using dlg As New SaveFileDialog()
            dlg.Filter = "Archivo para Excel (*.csv)|*.csv"
            dlg.FileName = "ventas_" & Date.Today.ToString("yyyy-MM-dd") & ".csv"
            If dlg.ShowDialog() = DialogResult.OK Then
                RegistroVentas.ExportarCsv(dt, dlg.FileName)
                MsgBox("Archivo guardado.", MsgBoxStyle.Information)
            End If
        End Using
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class