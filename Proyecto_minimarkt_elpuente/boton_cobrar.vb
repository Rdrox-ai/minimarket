Public Class boton_cobrar

    Private total As Decimal

    ' Constructor que recibe un valor
    Public Sub New(texto As Decimal)
        InitializeComponent()
        total = texto
    End Sub
    Private Sub boton_cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarFondo(Me)
        PictureBox1.SendToBack()
        ComboBox1.SelectedIndex = 0
        txttotal.Text = total.ToString("N2")

    End Sub

    Public Property OperacionCompletada As Boolean = False
    Private Sub Buttonfinalizar_Click(sender As Object, e As EventArgs) Handles Buttonfinalizar.Click
        OperacionCompletada = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtmonto_recibido.Text &= 1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtmonto_recibido.Text &= 2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtmonto_recibido.Text &= 3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtmonto_recibido.Text &= 4
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtmonto_recibido.Text &= 5
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtmonto_recibido.Text &= 6
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtmonto_recibido.Text &= 7
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtmonto_recibido.Text &= 8
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtmonto_recibido.Text &= 9
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        txtmonto_recibido.Text &= 0
    End Sub
    Private Sub Button50k_Click(sender As Object, e As EventArgs) Handles Button50k.Click
        txtmonto_recibido.Text = 50000
    End Sub
    Private Sub Button100k_Click(sender As Object, e As EventArgs) Handles Button100k.Click
        txtmonto_recibido.Text = 100000
    End Sub
    Private Sub txtmonto_recibido_TextChanged(sender As Object, e As EventArgs) Handles txtmonto_recibido.TextChanged
        If txtmonto_recibido.Text IsNot "" Then
            Dim id As Decimal
            If Not Decimal.TryParse(txtmonto_recibido.Text.Trim(), id) Then
                MsgBox("Debes ingresar únicamente variables numericas en el campo.", MsgBoxStyle.Critical)
                txtmonto_recibido.Clear()
                Exit Sub
            End If
            Dim monto_recibido As Decimal
            Dim vuelto As Decimal
            monto_recibido = Convert.ToDecimal(txtmonto_recibido.Text)
            vuelto = monto_recibido - total
            txtvuelto.Text = vuelto
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txtmonto_recibido.Clear()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub txtfactura_Click(sender As Object, e As EventArgs) Handles txtfactura.Click
        Dim ventanacliente As New cliente()
        ventanacliente.ShowDialog()
        clienteagregado()
    End Sub

    Private Sub clienteagregado()
        ' Validación: si hay RUC seleccionado en el formulario cliente
        If Not String.IsNullOrEmpty(Conexión.RucGlobal) Then
            Txtnombre.Text = ObtenerNombrePorRuc(Conexión.RucGlobal)
            txtruc.Text = Conexión.RucGlobal
        End If
    End Sub

    Public ReadOnly Property NombreCliente As String
        Get
            Return Txtnombre.Text
        End Get
    End Property

    Public ReadOnly Property RucCliente As String
        Get
            Return txtruc.Text
        End Get
    End Property

    Public ReadOnly Property MontoRecibido As Decimal
        Get
            Dim valor As Decimal = 0
            Decimal.TryParse(txtmonto_recibido.Text, valor)
            Return valor
        End Get
    End Property

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtnombre_Click(sender As Object, e As EventArgs) Handles txtnombre.Click

    End Sub
End Class