Public Class menu_principal


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_cargar.Click
        Dim nuevaventana As New Cargar_Productos()
        nuevaventana.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_escanear.Click
        Dim nuevaventana As New Scan_productos()
        nuevaventana.ShowDialog()
    End Sub
    Private Sub Buttonedit_precios_Click(sender As Object, e As EventArgs) Handles Button_editar.Click
        Dim nuevaventana As New editar_precios()
        nuevaventana.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_eliminar.Click
        Dim nuevaventana As New Eliminar_productos()
        nuevaventana.ShowDialog()
    End Sub

    Private Sub menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_escanear.Focus()
        If ArrowDirection.Down Then
            Button_cargar.Focus()
        End If
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button_volver_Click(sender As Object, e As EventArgs) Handles Button_volver.Click
        Dim r As DialogResult = MsgBox("¿Estás seguro de que desea salir del sistema?", MsgBoxStyle.YesNo +
         MsgBoxStyle.Question, "Confirmar salida")
        If r = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Sumar_productos_Click(sender As Object, e As EventArgs) Handles Sumar_productos.Click
        Dim nuevaventana As New sumar_productos()
        nuevaventana.ShowDialog()
    End Sub

    Private Sub Button_escanear_KeyDown(sender As Object, e As KeyEventArgs) Handles Button_escanear.KeyDown

    End Sub

    Private Sub Btnreporte_Click(sender As Object, e As EventArgs) Handles Btnreporte.Click
        Dim f As New reporte_ventas()
        f.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class