Imports Npgsql
Imports System.Security.Cryptography 'libreria de criptografia
Imports System.Text

Module Conexión
    'cadena de conexion con la base de datos son los parametros a utilizar
    Public cadena As String = "User ID=postgres;password=root;Host=localHost;Port=5432;database=MINIMARKET"

    'se crea una funcion para consultar a la base de datos
    Public co_usuario As Integer
    Public perfil As String
    Public Function consulta(ByVal coma As String) As DataTable
        Dim cnn As NpgsqlConnection = New NpgsqlConnection(cadena)
        cnn.Open()
        Dim dt = New DataTable
        Dim ds As New DataSet
        Dim da As NpgsqlDataAdapter = New NpgsqlDataAdapter(coma, cnn)
        da.Fill(dt)
        cnn.Close()
        Return (dt)
    End Function
    'funcion para ejecutar el insert , update, delete ala base de datos
    Function executarsql(ByVal coman As String) As Boolean
        Try
            Dim cnn As NpgsqlConnection = New NpgsqlConnection(cadena)
            cnn.Open()
            Dim ejecute As NpgsqlCommand = New NpgsqlCommand(coman, cnn)
            If ejecute.ExecuteNonQuery = 0 Then
                cnn.Close()
                Return False
            Else
                cnn.Close()

                Return True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return True
        End Try
    End Function
    'esta funcion se encarga de encriptar los datos de la base de datos, 
    Public Function encryptar(ByVal password As String) As String
        Dim a As Encoding = Encoding.UTF8
        'inicialize the keyed hash object'
        Dim hmac As New HMACSHA256(a.GetBytes("secret"))
        Dim b As Byte() = hmac.ComputeHash(a.GetBytes(password))
        Dim s As New StringBuilder()
        For i As Integer = 0 To b.Length - 1
            s.Append(b(i).ToString("x2"))
        Next
        ' Console WriteLine("outup:{0}",s.ToString())
        Return s.ToString()
    End Function

End Module

