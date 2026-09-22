Public Class Cargar_Productos

    Private Sub Cargar_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cargar_grilla()
    End Sub
    Private Sub cargar_grilla()
        Txtcodigo.Focus()
        Dim dt = New DataTable()
        Dim tabalas As DataTable = Conexión.consulta("select * from productos")
        DataGridView1.DataSource = tabalas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_nuevo.Click
        HABILITARTXT()
        LIMPIARTXT()
        Txtcodigo.Focus()

    End Sub
    Sub HABILITARTXT()
        Txtcodigo.Enabled = True
        Txtproducto.Enabled = True
        Txtprecio.Enabled = True
    End Sub
    Sub DESABILITARTXT()
        Txtcodigo.Enabled = False
        Txtproducto.Enabled = False
        Txtprecio.Enabled = False
    End Sub
    Sub LIMPIARTXT()
        Txtcodigo.Text = ""
        Txtproducto.Text = ""
        Txtprecio.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Txtcodigo.Text = "" Then
            MsgBox("Cargue el codigo")
        ElseIf Txtproducto.Text = "" Then
            MsgBox("Cargue el nombre del producto")
        ElseIf Txtprecio.Text = "" Then
            MsgBox("Cargue el precio")

        Else
            Dim query As String = "INSERT INTO productos (codigo, producto, precio)" &
        "VALUES ('" & Txtcodigo.Text & "','" & Txtproducto.Text & "','" & Txtprecio.Text & "');"
            If Conexión.executarsql(query) Then
                MsgBox("registro guardado con exito", MsgBoxStyle.Information)
                cargar_grilla()
                Button_nuevo.Focus()
            Else
                MsgBox("registro no guardado", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Txtcodigo_keydown(sender As Object, e As KeyEventArgs) Handles Txtcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Txtproducto.Focus()
        End If
    End Sub
    Private Sub Txtproducto_keydown(sender As Object, e As KeyEventArgs) Handles Txtproducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Txtprecio.Focus()
        End If
    End Sub
    Private Sub Txtprecio_keydown(sender As Object, e As KeyEventArgs) Handles Txtprecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button2.Focus()
        End If
    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        Me.Close()
    End Sub
End Class