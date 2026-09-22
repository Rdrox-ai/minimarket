Public Class Eliminar_productos
    Private Sub cargar_grilla()
        If Txtcodigo.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim query As String = "select * from productos where codigo =" & Txtcodigo.Text & ""
            Dim tablas As DataTable = Conexión.consulta(query)
            DataGridView1.DataSource = tablas
        End If
        If Txtprod.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim query As String = "SELECT * FROM productos WHERE producto ILIKE '%" & Txtprod.Text.Trim() & "%'"
            Dim tablas As DataTable = Conexión.consulta(query)
            DataGridView1.DataSource = tablas
        End If
    End Sub

    Private Sub Txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles Txtcodigo.TextChanged
        cargar_grilla()
    End Sub
    Private Sub Eliminar_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cargar_grilla()
    End Sub

    Private Sub LIMPIARTXT()
        Txtcodigo.Text = ""
        Txtprod.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Txtcodigo.Focus()
        If Txtcodigo.Text <> "" Then
            If MsgBox("Estas seguro de que desea eliminar el registro?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                'Elimina en la tabla de clientes
                Dim query As String = "DELETE FROM productos
                WHERE codigo =" & Txtcodigo.Text & ""
                If Conexión.executarsql(query) Then
                    cargar_grilla()
                    MsgBox("Registro eliminado con exito")
                    LIMPIARTXT() 'limpiamos los espacios 
                Else
                    MsgBox("Error al eliminar")
                End If
            End If
        Else
            MsgBox("Seleccione una opcion", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        Me.Close()
    End Sub

    Private Sub Txtprod_TextChanged(sender As Object, e As EventArgs) Handles Txtprod.TextChanged
        cargar_grilla()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class