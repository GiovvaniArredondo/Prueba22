Public Class uccierre
    Inherits System.Web.UI.UserControl

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'ldfecha = Session("gdfecsis")
            'Me.txtfecha1.Text = "01/01/" & ldfecha.Year.ToString.Trim
            'Me.txtfecha2.Text = "31/12/" & ldfecha.Year.ToString.Trim
            Dim entidadCntaprm As New SIM.EL.cntaprm
            Dim eCntaprm As New SIM.BL.cCntaprm
            Dim ds As New DataSet
            Dim ncanti As Integer
            Dim lcmesvig As String
            Dim lccadena As String
            Dim lcyears As String
            Dim clssconta As New clsConta

            lcmesvig = Session("gcyears")
            lcyears = Left(lcmesvig, 4)
            lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

            ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
            ncanti = ds.Tables(0).Rows.Count()
            If ncanti = 0 Then  'En caso que no devuelva nada se sale
                Exit Sub
            End If
            Me.txtfecha1.Text = ds.Tables(0).Rows(0)("dFecimes")
            Me.txtfecha2.Text = ds.Tables(0).Rows(0)("dFecfmes")


        End If
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim classconta As New clsConta
        Dim clsprin As New class1
        Dim dscierre As New DataSet
        Dim dscntamov As New DataSet
        Dim mcntamov As New cCntamov
        Dim ecntamov As New cntamov
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim ok1 As Integer
        Dim okcierre As Integer
        Dim ostra As Integer
        Dim lcnomser As String
        Dim okcreardb As Integer
        Dim oktras As Integer
        lcnomser = Session("gcnomser").trim
        ldfecha1 = Date.Parse(Me.txtfecha1.Text)
        ldfecha2 = Date.Parse(Me.txtfecha2.Text)
        clsprin.pcCodUsu = Session("gccodusu")

        Dim lcmesvig As String
        Dim lcyears As String
        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        clsprin.pcyears = Left(lcyears, 4)
        clsprin.pcnomser = Session("gcnomser")

        Dim okbancario As Integer = 0
        'Cierre bancario
        okbancario = clsprin.CierreBancario(ldfecha1, ldfecha2)
        If okbancario = 1 Then


            okcierre = clsprin.cierre_crea_partidas_cierre(ldfecha1, ldfecha2, lcnomser, Session("gcCtaLiq"))
            If okcierre = 1 Then

                'creara base de datos


                okcreardb = clsprin.crear_base_datos_cierre(ldfecha2, lcnomser)
                oktras = clsprin.cierres_contabilidad_traslado(ldfecha1, ldfecha2, lcnomser) 'traslada los movimientos al siguiente año
                If okcreardb = 1 Then
                    'Cierre contable
                    clsprin.TrasladaSaldosBancarios()
                    If oktras = 1 Then
                        ok1 = 1 'clsprin.llama_sp_cierre_contable(ldfecha1, ldfecha2, lcnomser)
                        If ok1 = 1 Then
                            'crea las partidas con los movimientos
                            'If okcierre = 1 Then
                            ostra = clsprin.cierre_crea_partidas_iniciales(ldfecha1, ldfecha2, lcnomser)
                            ' clsprin.inicializa_numeros_de_partidas()
                            Response.Write("<script language='javascript'>alert('ok. Traslado correcto')</script>")
                            CerrarSesion()

                            'Else
                            '    Response.Write("<script language='javascript'>alert('Problemas de cierre. Traslado correcto')</script>")
                            'End If
                        Else
                            Response.Write("<script language='javascript'>alert('Problemas en conección')</script>")
                        End If
                    Else
                        Response.Write("<script language='javascript'>alert('Bases no se trasladaron a nuevo backup')</script>")
                    End If
                Else
                    Response.Write("<script language='javascript'>alert('Ya existe cierre')</script>")
                End If

            Else
                Response.Write("<script language='javascript'>alert('Problemas en Cierre')</script>")

            End If
        Else
            Response.Write("<script language='javascript'>alert('Problemas en Cierre Bancario')</script>")
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
