Public Class buscar_por_nombre
    Private Sub cargar_grilla()
        If Txtprod.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim query As String = "SELECT codigo, producto, precio FROM productos WHERE producto ILIKE '%" & Txtprod.Text.Trim() & "%'"

            DataGridView1.DataSource = Nothing
            DataGridView1.Columns.Clear()
            Dim tablas As DataTable = Conexión.consulta(query)
            DataGridView1.DataSource = tablas
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim codigo As String = fila.Cells("codigo").Value.ToString()
            Dim nombre As String = fila.Cells("producto").Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(fila.Cells("precio").Value)

            ' Si usás un TextBox para cantidad:
            Dim cantidad As Double
            If Double.TryParse(Txtcantidad.Text, cantidad) = False Then
                cantidad = 1
            End If

            ' Llamamos al form principal
            Dim frmPrincipal As sumar_productos = CType(Application.OpenForms("sumar_productos"), sumar_productos)
            frmPrincipal.AgregarDesdeBusqueda(codigo, nombre, precio, cantidad)

            Me.Close()
        Else
            MsgBox("Seleccione un producto de la lista", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub Txtprod_TextChanged(sender As Object, e As EventArgs) Handles Txtprod.TextChanged
        cargar_grilla()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub buscar_por_nombre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class