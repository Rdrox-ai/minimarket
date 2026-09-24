Public Class Scan_productos
    Private Sub cargar_grilla()
        Dim init = New DataTable()
        Dim tablainit As DataTable = Conexión.consulta("select * from productos ORDER BY codigo asc")
        DataGridView1.DataSource = tablainit
        If Txtcodigo.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim query As String = "select * from productos where codigo =" & Txtcodigo.Text & " ORDER BY codigo asc"
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

    Private Sub Scan_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cargar_grilla()
        Txtcodigo.Focus()
    End Sub

    Private Sub Txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles Txtcodigo.TextChanged
        Dim id As Double
        If Double.TryParse(Txtcodigo.Text.Trim(), id) Then
            cargar_grilla()
        End If
    End Sub

    Private Sub Txtcodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtcodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim id As Double
            If Not Double.TryParse(Txtcodigo.Text.Trim(), id) Then
                MsgBox("Debes ingresar únicamente números válidos en el campo ID.", MsgBoxStyle.Critical)
                Exit Sub
            Else
                e.SuppressKeyPress = True
                cargar_grilla()
                Txtcodigo.SelectAll()
            End If
        End If
    End Sub
    Private Sub Txtprod_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtprod.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cargar_grilla()
            Txtprod.SelectAll()
        End If
    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        Me.Close()
    End Sub

    Private Sub Txtprod_TextChanged(sender As Object, e As EventArgs) Handles Txtprod.TextChanged
        cargar_grilla()
    End Sub
End Class