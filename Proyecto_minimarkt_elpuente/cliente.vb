Public Class cliente
    Private Sub cargar_grilla()
        Dim init = New DataTable()
        Dim tablainit As DataTable = Conexión.consulta("select * from clientes ORDER BY ruc asc")
        DataGridView1.DataSource = tablainit
        If Txtbuscar.Text IsNot "" Then
            Dim dt = New DataTable()
            Dim query As String = "SELECT * FROM clientes WHERE ruc ILIKE '%" & Txtbuscar.Text & "%' ORDER BY ruc ASC"


            Dim tablas As DataTable = Conexión.consulta(query)
            DataGridView1.DataSource = tablas
        End If

    End Sub

    Private Sub Scan_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cargar_grilla()
        Txtbuscar.Focus()
    End Sub

    Private Sub Txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles Txtbuscar.TextChanged
        If Txtbuscar.Text IsNot "" Then
            cargar_grilla()
        End If
    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        Me.Close()
    End Sub

    Private Sub buttonagregar_Click(sender As Object, e As EventArgs) Handles buttonagregar.Click
        If Txtnombre.Text = "" Then
            MsgBox("Cargue el nombre")
        ElseIf Txtruc.Text = "" Then
            MsgBox("Cargue el ruc")
        ElseIf Txtnombre.Text IsNot "" And Txtruc.Text IsNot "" And Txttelefono.Text IsNot "" Then
            Dim query As String = "INSERT INTO clientes (nombre, ruc, telefono)" &
        "VALUES ('" & Txtnombre.Text & "','" & Txtruc.Text & "','" & Txttelefono.Text & "');"
            If Conexión.executarsql(query) Then
                MsgBox("registro guardado con exito", MsgBoxStyle.Information)
                cargar_grilla()
            Else
                MsgBox("registro no guardado", MsgBoxStyle.Information)
            End If
        ElseIf Txtnombre.Text IsNot "" And Txtruc.Text IsNot "" Then
            Dim query As String = "INSERT INTO clientes (nombre, ruc)" &
        "VALUES ('" & Txtnombre.Text & "','" & Txtruc.Text & "');"
            If Conexión.executarsql(query) Then
                MsgBox("registro guardado con exito", MsgBoxStyle.Information)
                cargar_grilla()
            Else
                MsgBox("registro no guardado", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Txtnombre_TextChanged(sender As Object, e As EventArgs) Handles Txtnombre.TextChanged

    End Sub



    ' Evento cuando seleccionas una fila
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim rucSeleccionado As String = fila.Cells("ruc").Value.ToString()

            ' Guardar el RUC en la variable global del módulo Conexión
            Conexión.RucGlobal = rucSeleccionado
        End If
    End Sub



    Private Sub Buttonaceptar_Click(sender As Object, e As EventArgs) Handles Buttonaceptar.Click
        Me.Close()
    End Sub
End Class