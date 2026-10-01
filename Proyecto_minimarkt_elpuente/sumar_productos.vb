Imports Npgsql

Public Class sumar_productos
    Public Shared total As Decimal = 0
    Private Sub Txtcodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim id As Double
            If Not Double.TryParse(Txtcodigo.Text.Trim(), id) Then
                MsgBox("Debes ingresar únicamente números válidos en el campo ID.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim codigo As String = Txtcodigo.Text.Trim()

            If Not String.IsNullOrEmpty(codigo) Then
                AgregarProducto(codigo)
                Txtcodigo.Clear()
                Txtcodigo.Focus()
            End If

            ' Evita el pitido al presionar Enter
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub AgregarProducto(codigo As String)
        Try
            ' 1. Usamos TU función consulta del módulo
            ' Ajusta los nombres de las columnas ('nombre', 'precio') según tu tabla en MINIMARKET
            Dim sql As String = "SELECT producto, precio FROM productos WHERE codigo = '" & codigo & "'"
            Dim dt As DataTable = consulta(sql)

            ' 2. Verificar si devolvió algún resultado
            If dt.Rows.Count > 0 Then
                Dim nombre As String = dt.Rows(0)("producto").ToString()
                Dim precio As Decimal = Convert.ToDecimal(dt.Rows(0)("precio"))

                ' 3. Comprobar si el producto ya está en el DataGridView para solo aumentar la cantidad
                Dim existe As Boolean = False

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("Codigo").Value IsNot Nothing AndAlso row.Cells("Codigo").Value.ToString() = codigo Then
                        Dim cantidadActual As Double = Convert.ToDouble(row.Cells("Cantidad").Value) + 1
                        row.Cells("Cantidad").Value = cantidadActual
                        row.Cells("Subtotal").Value = cantidadActual * precio
                        existe = True
                        Exit For
                    End If
                Next

                ' 4. Si no existe en el DataGridView, agregarlo como nuevo registro
                If Not existe Then
                    DataGridView1.Rows.Add(codigo, nombre, precio, 1, precio)
                End If

                ' 5. Recalcular el total
                CalcularTotal()

            Else
                MsgBox("Producto no encontrado en el sistema.", MsgBoxStyle.Exclamation, "Aviso")
            End If

        Catch ex As Exception
            MsgBox("Error al consultar el producto: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CalcularTotal()
        total = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Subtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("Subtotal").Value)
            End If
        Next

        ' Muestra el total acumulado
        Textotal.Text = "Total: " & total.ToString("N0") ' "N0" para guarani/formato sin decimales o "C2" con moneda
    End Sub

    Private Sub buttoncobrar_Click(sender As Object, e As EventArgs) Handles buttoncobrar.Click
        DataGridView1.Rows.Clear()
        total = 0
        Textotal.Text = ""
    End Sub
    Private Sub Eliminar_producto_Click(sender As Object, e As EventArgs) Handles Eliminar_producto.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Tomamos la primera fila seleccionada
            Dim fila As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Restamos el subtotal de esa fila al total
            If fila.Cells("Subtotal").Value IsNot Nothing Then
                total -= Convert.ToDecimal(fila.Cells("Subtotal").Value)
            End If

            ' Eliminamos la fila
            DataGridView1.Rows.Remove(fila)

            ' Actualizamos el texto del total
            Textotal.Text = "Total: " & total.ToString("N0")
        Else
            MsgBox("Seleccione un producto para eliminar", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub sumar_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Txtcodigo.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nuevaventana As New buscar_por_nombre()
        nuevaventana.ShowDialog()
    End Sub
    Public Sub AgregarDesdeBusqueda(codigo As String, nombre As String, precio As Decimal, cantidad As Double)
        Dim existe As Boolean = False

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Codigo").Value IsNot Nothing AndAlso row.Cells("Codigo").Value.ToString() = codigo Then
                Dim cantidadActual As Double = Convert.ToDouble(row.Cells("Cantidad").Value) + cantidad
                row.Cells("Cantidad").Value = cantidadActual
                row.Cells("Subtotal").Value = cantidadActual * precio
                existe = True
                Exit For
            End If
        Next

        If Not existe Then
            DataGridView1.Rows.Add(codigo, nombre, precio, cantidad, cantidad * precio)
        End If

        CalcularTotal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Textotal_TextChanged(sender As Object, e As EventArgs) Handles Textotal.TextChanged

    End Sub

    Private Sub Txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles Txtcodigo.TextChanged

    End Sub
End Class