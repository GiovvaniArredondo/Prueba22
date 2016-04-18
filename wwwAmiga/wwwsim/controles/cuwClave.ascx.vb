
Partial Class controles_cuwClave
    Inherits System.Web.UI.UserControl
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)


    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Dim eusuarios As New cusuarios

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim miLogin As New cLogin

        Dim sys As New System.Security.Cryptography.SHA1CryptoServiceProvider


        If miLogin.ValidarUsuario(Session("Usuario"), Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.txtClave2.Text.ToUpper)))) Then
            'Clave Valida
            'verifica claves
            If Me.txtClave0.Text.Trim <> Me.txtClave1.Text.Trim Then
                Response.Write("<script language='javascript'>alert('Claves no coinciden')</script>")
                Return
            Else
                If txtClave2.Text.Trim = txtClave0.Text.Trim Then
                    Response.Write("<script language='javascript'>alert('Clave no puede ser igual a Anterior')</script>")
                    Return

                End If

                '
                Dim ldfecven As Date
                Dim ldfecsis As Date
                Dim lndiasven As Integer
                ldfecsis = Session("gdfecsis")
                lndiasven = Session("gndiasven")
                ldfecven = DateAdd(DateInterval.Day, lndiasven, ldfecsis)
                Dim i As Integer
                i = eusuarios.ActualizaClave(Session("Usuario").Trim, Convert.ToBase64String(sys.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Me.txtClave0.Text.ToUpper))), ldfecven)
                eusuarios.GrabarIntentos(Session("Usuario").Trim, 0)
                Response.Write("<script language='javascript'>alert('Clave Actualizada')</script>")

                ClienteSeleccionado = "0"
                RaiseEvent Seleccionado(ClienteSeleccionado)
            End If
        Else
            Response.Write("<script language='javascript'>alert('Clave Iválida')</script>")
            Return
        End If

    End Sub


End Class
