Public Class validacion
    Private Sub validacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Focus()
    End Sub

    Private Sub txtusuario_Keydown(sender As Object, e As KeyEventArgs) Handles txtusuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcontra.Focus()
        End If

    End Sub
    Private Sub txtcontra_Keydown(sender As Object, e As KeyEventArgs) Handles txtcontra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If

    End Sub

End Class