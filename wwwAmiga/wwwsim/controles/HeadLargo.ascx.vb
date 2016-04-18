

Partial Class HeadLargo
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            'Introducir aquí el código de usuario para inicializar la página
            Dim a As Date
            Dim etabtofi As New cTabtofi
            Dim lcnomofi As String = ""
            lcnomofi = etabtofi.NombreAgencia(Session("gcCodofi"))

            'Dim etabtusu As New cTabtusu
            'Dim usuario As String
            'usuario = etabtusu.usuario(Session("gcCodusu"))
            a = Session("gdFecSis")
            Me.Label1.Text = ("Fecha del Sistema: " & a.ToString).Substring(0, 29) & " | Agencia: " & lcnomofi.Trim & " | USUARIO: " & Session("gcCodusu") & " " & _
               " | Usuarios en línea: " & Application("UsuariosVivos")
            '"  Usuario :" & usuario 
            'Me.Label2.Text = "Empresa: " & Session("gcnomfon")
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Auditoria'
        Dim ip As Net.Dns
        Dim nombre_Host As String = ip.GetHostName
        Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)
        Dim direccion_Ip As String = este_Host.AddressList(0).ToString
        Dim entidadusuarios As New usuarios
        Dim milogin As New cLogin
        Dim eusuarios As New cusuarios
        entidadusuarios.cip = direccion_Ip
        entidadusuarios.dfecha = Today
        entidadusuarios.chora = TimeOfDay.ToString.Substring(11, 12)
        entidadusuarios.idUsuario = milogin.IdUsuario(Session("gcCodusu"))
        entidadusuarios.gdfecsis = Session("gdfecsis")
        entidadusuarios.ctrs = "OUT"
        entidadusuarios.idopcion = 0
        Try
            eusuarios.RegistraAuditoria(entidadusuarios)
        Catch ex As Exception

        End Try

        Session.Abandon()
        Response.Redirect("wflogin.aspx")
    End Sub
End Class


