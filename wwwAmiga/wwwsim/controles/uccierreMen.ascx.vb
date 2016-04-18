Public Class uccierreMen
    Inherits System.Web.UI.UserControl
    Dim clsppal As New class1
    Dim clssconta As New clsConta
#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
   

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim entidadCntaprm As New SIM.EL.cntaprm
            Dim eCntaprm As New SIM.BL.cCntaprm
            Dim ds As New DataSet
            Dim ncanti As Integer
            Dim lcmesvig As String
            Dim lccadena As String
            Dim lcyears As String


            lcmesvig = Session("gcyears")
            lcyears = Left(lcmesvig, 4)
            lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

            ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
            ncanti = ds.Tables(0).Rows.Count()
            If ncanti = 0 Then  'En caso que no devuelva nada se sale
                Exit Sub
            End If
            'Me.txtfecha1.Text = ds.Tables(0).Rows(0)("dFecimes")
            'Me.txtfecha2.Text = ds.Tables(0).Rows(0)("dFecfmes")

            'Obtiene el primer mes abierto
            Dim lcmes As String
            lcmes = clssconta.ObtieneMesaCerrar()

            Dim lcfecha1 As String
            Dim ldfecha1 As Date
            Dim ldfecha2 As Date

            lcfecha1 = "#1/" & Integer.Parse(lcmes) & "/" & lcyears & "#"
            ldfecha1 = Date.Parse(lcfecha1)
            ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)

            Me.txtfecha1.Text = ldfecha1
            Me.txtfecha2.Text = ldfecha2

            If lcmes.Trim = "12" Then
                Button1.Enabled = False
                Response.Write("<script language='javascript'>alert('Ejecute Cierre Anual')</script>")
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Bloquea el mes que se esta cerrando
        Dim lcmes As String
        Dim lnretorno As Integer
        lcmes = clssconta.ObtieneMesaCerrar()

        lnretorno = clssconta.ActualizarMesCerrado(lcmes.Trim)

        If lnretorno = 0 Then
            Response.Write("<script language='javascript'>alert('Problema de Cierre')</script>")
        Else
            Button1.Enabled = False
            Response.Write("<script language='javascript'>alert('Mes Cerrado')</script>")
        End If

    End Sub
    Private Sub CerrarSesion()
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
        entidadusuarios.ctrs = "40"
        Try
            eusuarios.RegistraAuditoria(entidadusuarios)
        Catch ex As Exception

        End Try


        Session.Abandon()
        Response.Redirect("wflogin.aspx")

    End Sub
End Class
