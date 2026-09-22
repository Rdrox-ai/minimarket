Public Class editar_precios
    Private Sub cargar_grilla()
        If Txtcodigo.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim tablas As DataTable = Conexión.consulta("select * from productos where codigo =" & Txtcodigo.Text & "")
            DataGridView1.DataSource = tablas
        End If
        If Txtprod.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim query As String = "SELECT * FROM productos WHERE producto ILIKE '%" & Txtprod.Text.Trim() & "%'"
            Dim tablas As DataTable = Conexión.consulta(query)
            DataGridView1.DataSource = tablas
        End If

    End Sub

    Private Sub Txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles Txtcodigo.TextChanged, Txtprod.TextChanged
        cargar_grilla()
    End Sub
    Private Sub editar_precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cargar_grilla()
    End Sub

    Private Sub LIMPIARTXT()
        Txtcodigo.Text = ""
        Txtprod.Text = ""
        Txtprecio.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttoneditar.Click
        Txtcodigo.Focus()
        If Txtcodigo.Text <> "" Then
            If MsgBox("Estas seguro de que desea cambiar el precio?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                'Elimina en la tabla de clientes
                Dim query As String = "UPDATE productos
                SET precio = " & Txtprecio.Text & "
                WHERE codigo =" & Txtcodigo.Text & ""
                If Conexión.executarsql(query) Then
                    cargar_grilla()
                    MsgBox("Registro cambiado con exito")
                    LIMPIARTXT() 'limpiamos los espacios 
                Else
                    MsgBox("Error al cambiar")
                End If
            End If
        ElseIf Txtprod.Text <> "" Then
            If MsgBox("Estas seguro de que desea cambiar el precio?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                'Elimina en la tabla de clientes
                Dim query As String = "UPDATE productos
                SET precio = " & Txtprecio.Text & "
                WHERE producto ILIKE '%" & Txtprod.Text.Trim() & "%'"
                If Conexión.executarsql(query) Then
                    cargar_grilla()
                    MsgBox("Registro cambiado con exito")
                    LIMPIARTXT() 'limpiamos los espacios 
                Else
                    MsgBox("Error al cambiar")
                End If
            End If
        Else
            MsgBox("Seleccione una opcion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Txtprecio_TextChanged(sender As Object, e As EventArgs) Handles Txtprecio.TextChanged

    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        Me.Close()
    End Sub
End Class