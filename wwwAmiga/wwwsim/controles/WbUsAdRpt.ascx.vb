Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web







Partial Class WbUsAdRpt
    Inherits ucWBase
    Protected WithEvents CrystalReportViewer1 As CrystalDecisions.Web.CrystalReportViewer

#Region " Variables "
    Private clsreportes As New SIM.BL.ClsAdRpt
    Private _dfecha1 As DateTime
    Private _dfecha2 As DateTime
    Private ds As New DataSet
    Dim dsfiltro As New DataSet

#End Region

#Region "Propiedades"
    Public Property dfecha1() As DateTime
        Get
            Return _dfecha1
        End Get
        Set(ByVal Value As DateTime)
            _dfecha1 = Value
        End Set
    End Property
    Public Property dfecha2() As DateTime
        Get
            Return _dfecha2
        End Get
        Set(ByVal Value As DateTime)
            _dfecha2 = Value
        End Set
    End Property
#End Region

#Region " Metodos "

    Public Sub Inicio()
        Dim gdfecsis As DateTime
        gdfecsis = Session("gdfecsis")

        Me.TxtDate1.Text = gdfecsis
        Me.TxtDate2.Text = gdfecsis

    End Sub

    Public Sub Listas()
        '---------------------------
        'Zona
        '---------------------------
        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista("2")
        Me.ListZonas.DataTextField = "cDesZon"
        Me.ListZonas.DataValueField = "cCodzon"
        Me.ListZonas.DataSource = mTabtZon
        Me.ListZonas.DataBind()

        '---------------------------
        'Fuente de Fondos
        '---------------------------
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("033", "1")

        Me.ListFondos.DataTextField = "cdescri"
        Me.ListFondos.DataValueField = "ccodigo"
        Me.ListFondos.DataSource = mListaTabttab
        Me.ListFondos.DataBind()

        '---------------------------
        'Actividad Economica
        '---------------------------
        Dim clsTabtciu As New SIM.BL.cTabtciu
        Dim mTabtciu As New listatabtciu

        mTabtciu = clsTabtciu.ObtenerLista()

        Me.ListActividad.DataTextField = "cdescri"
        Me.ListActividad.DataValueField = "ccodigo"
        Me.ListActividad.DataSource = mTabtciu
        Me.ListActividad.DataBind()

        '---------------------------
        'Genero
        '---------------------------
        mListaTabttab = clstabttab.ObtenerLista("003", "1")

        Me.ListSexo.DataTextField = "cdescri"
        Me.ListSexo.DataValueField = "ccodigo"
        Me.ListSexo.DataSource = mListaTabttab
        Me.ListSexo.DataBind()


        '---------------------------
        'Tipo de Cartera
        '---------------------------
        mListaTabttab = clstabttab.ObtenerLista("046", "1")

        Me.ListTipo.DataTextField = "cdescri"
        Me.ListTipo.DataValueField = "ccodigo"
        Me.ListTipo.DataSource = mListaTabttab
        Me.ListTipo.DataBind()


        '---------------------------
        'Analista
        '---------------------------
        Dim clsTabtusu As New SIM.BL.cTabtusu
        Dim mListaTabtUsu As New listatabtusu


        mListaTabtUsu = clsTabtusu.ObtenerLista("ANA", Session("gcCodofi"))

        Me.ListAna.DataTextField = "cNomusu"
        Me.ListAna.DataValueField = "cCodUsu"
        Me.ListAna.DataSource = mListaTabtUsu
        Me.ListAna.DataBind()


    End Sub


    Public Sub Imprime(ByVal reportes As String)
        Dim ldfecha As Date
        ldfecha = Date.Parse(Me.TxtDate2.Text)


        Try
            If dsfiltro Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsfiltro.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(dsfiltro.Tables(0))

        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()


    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.rbtIngresos.Checked = True
            Me.Listas()
            Me.Inicio()
        End If
    End Sub
    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Private Sub BtnProcesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesa.Click

        'PRIMERO CALCULARA LA MORA EN LAS TABLAS MAESTRAS DE CREDITOS A LA FECHA INDICADA

        Dim clscalculo As New ccalculomora
        clscalculo.pdfecval = Date.Parse(Me.TxtDate2.Text)
        clscalculo.pccodcta = ""
        clscalculo.gnperbas = Session("gnperbas")
        clscalculo.omcalcinterest()

        'finaliza actualizacion de la mora



        'declara generalidades de dataset desconectados a ocupar
        Dim lnresul As Integer
        Dim cls1 As New class1 'clsprincipal
        Dim AHO As New DataSet

        Dim lcampos As String
        Dim lctipos As String
        Dim lcnomtab As String
        Dim dtzonas As DataTable
        Dim dtfondos As DataTable
        Dim dtactividad As DataTable
        Dim dtsexo As DataTable
        Dim dtcartera As DataTable
        Dim dtanalista As DataTable
        Dim dsbase As New DataSet

        Dim dr As DataRow

        Dim lncuenta As Integer
        Dim i As Integer

        Dim lcitem As String
        Dim indice As Integer
        Dim lcseleccion As String
        Dim lccodigo As String

        Dim pcampos As String
        Dim ptipos As String
        Dim pnomtab As String
        Dim drfiltro As DataRow
        Dim sientro As Boolean
        Dim lncue As Integer


        pcampos = "ccodcta, ccodcli, cnomcli, dfecvig, dfecven, ntasint, ncapdes, nsaldo, nmeses, nsalint, nsalmor, nmorak, ccodana,ccoddom, zona,ccodlin, ccodact, cnomact, csexo,ccondic,cdesfon,sexo,cartera,analista,ncapita,nintere,nmora,notros,cconcep,npago,"
        ptipos = "S,S,S,F,F,D,D,D,D,D,D,D,S,S,S,S,S,S,S,S,S,S,S,S,D,D,D,D,S,D,"
        pnomtab = "ZONAS"
        dtzonas = cls1.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "FONDOS"
        dtfondos = cls1.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "ACTIVIDAD"
        dtactividad = cls1.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "SEXO"
        dtsexo = cls1.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "CARTERA"
        dtcartera = cls1.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "ANALISTA"
        dtanalista = cls1.creadatasetdesconec(pcampos, ptipos, pnomtab)

        '***

        Me._dfecha1 = Date.Parse(Me.TxtDate1.Text.Trim)
        Me._dfecha2 = Date.Parse(Me.TxtDate2.Text.Trim)

        ' chequea los diferentes filtros
        If Me.rbtIngresos.Checked = True Then      'Pagos 
            dsbase = Me.clsreportes.Ingresos(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rbtDesem.Checked = True Then     'Desembolsos
            dsbase = Me.clsreportes.Desembolsos(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rbtDetalle.Checked = True Then 'detalle de cartera con ingresos
            dsbase = Me.clsreportes.cartera_Ingresos_depositos(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rbtCartera.Checked = True Then   'Cartera Vigente
            dsbase = Me.clsreportes.CartVigente(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rbtMora.Checked = True Then      'Mora General 
            dsbase = Me.clsreportes.Cartera_mora(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rbtProyec.Checked = True Then    'Proyeccion de Mora
            dsbase = Me.clsreportes.Proyeccion_mora(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rdbsumario.Checked = True Then    'sumarios
            dsbase = Me.clsreportes.Cartera_mora(Me._dfecha1, Me._dfecha2)
        ElseIf Me.rbtDesem.Checked = False Or Me.rbtCartera.Checked = False Or _
               Me.rbtDetalle.Checked = False Or Me.rbtIngresos.Checked = False Or _
               Me.rbtMora.Checked = False Or Me.rbtProyec.Checked = False Then
        End If

        '****** el dataset es pasado por los diferentes filtros para ser filtrado  *************

        'filtra base con zonas geobraficas
        lncuenta = Me.ListZonas.Items.Count
        Dim lccoddom As String

        Dim lcdescri As String

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.ListZonas.Items(i).Selected Then
                lccodigo = Me.ListZonas.Items.Item(i).Value.Trim
                lcdescri = Me.ListZonas.Items.Item(i).Text
                For Each drfiltro In dsbase.Tables(0).Rows
                    lccoddom = drfiltro("ccoddom").trim
                    lccoddom = lccoddom.Substring(0, 4)
                    If lccoddom = lccodigo Then
                        dr = dtzonas.NewRow()
                        dr("ccodcta") = drfiltro("ccodcta")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("dfecvig") = drfiltro("dfecvig")
                        dr("dfecven") = drfiltro("dfecven")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ncapdes") = drfiltro("ncapdes")
                        dr("nsaldo") = drfiltro("nsaldo")
                        dr("nmeses") = drfiltro("nmeses")
                        dr("nsalint") = drfiltro("nsalint")
                        dr("nsalmor") = drfiltro("nsalmor")
                        dr("nmorak") = drfiltro("nmorak")
                        dr("ccodana") = drfiltro("ccodana")
                        dr("ccoddom") = drfiltro("ccoddom")
                        dr("zona") = lcdescri
                        dr("ccodact") = drfiltro("ccodact")
                        dr("cnomact") = drfiltro("cnomact")
                        dr("csexo") = drfiltro("csexo") 'pendiente 
                        dr("ccondic") = drfiltro("ccondic") 'pendiente 
                        dr("ccodlin") = drfiltro("ccodlin") 'pendiente 
                        dr("cdesfon") = drfiltro("cdesfon")
                        dr("sexo") = drfiltro("sexo")
                        dr("cartera") = drfiltro("cartera")
                        dr("analista") = drfiltro("analista")
                        'pagos
                        dr("ncapita") = drfiltro("ncapita")
                        dr("nintere") = drfiltro("nintere")
                        dr("nmora") = drfiltro("nmora")
                        dr("notros") = drfiltro("notros")
                        dr("cconcep") = drfiltro("cconcep")
                        dr("npago") = drfiltro("npago")

                        dtzonas.Rows.Add(dr)
                    End If
                Next
            End If
        Next


        'filtra base con fondos
        lncuenta = Me.ListFondos.Items.Count
        Dim lcfondo As String

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.ListFondos.Items(i).Selected Then
                lccodigo = Me.ListFondos.Items.Item(i).Value.Trim
                lcdescri = Me.ListFondos.Items.Item(i).Text

                For Each drfiltro In dtzonas.Rows
                    lcfondo = Mid(drfiltro("ccodlin"), 3, 2)
                    If lcfondo = lccodigo Then
                        dr = dtfondos.NewRow()
                        dr("ccodcta") = drfiltro("ccodcta")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("dfecvig") = drfiltro("dfecvig")
                        dr("dfecven") = drfiltro("dfecven")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ncapdes") = drfiltro("ncapdes")
                        dr("nsaldo") = drfiltro("nsaldo")
                        dr("nmeses") = drfiltro("nmeses")
                        dr("nsalint") = drfiltro("nsalint")
                        dr("nsalmor") = drfiltro("nsalmor")
                        dr("nmorak") = drfiltro("nmorak")
                        dr("ccodana") = drfiltro("ccodana")
                        dr("ccoddom") = drfiltro("ccoddom")
                        dr("zona") = drfiltro("zona")
                        dr("ccodact") = drfiltro("ccodact") 'pendiente 
                        dr("cnomact") = drfiltro("cnomact") 'pendiente 
                        dr("ccondic") = drfiltro("ccondic") 'pendiente 
                        dr("ccodlin") = drfiltro("ccodlin") 'pendiente 
                        dr("cdesfon") = lcdescri
                        dr("csexo") = drfiltro("csexo") 'pendiente 
                        dr("sexo") = drfiltro("sexo")
                        dr("cartera") = drfiltro("cartera")
                        dr("analista") = drfiltro("analista")
                        'pagos
                        dr("ncapita") = drfiltro("ncapita")
                        dr("nintere") = drfiltro("nintere")
                        dr("nmora") = drfiltro("nmora")
                        dr("notros") = drfiltro("notros")
                        dr("cconcep") = drfiltro("cconcep")
                        dr("npago") = drfiltro("npago")

                        dtfondos.Rows.Add(dr)

                    End If
                Next
            End If
        Next


        'filtra actividades


        lncuenta = Me.ListActividad.Items.Count

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.ListActividad.Items(i).Selected Then
                lccodigo = Me.ListActividad.Items.Item(i).Value.Trim
                lcdescri = Me.ListActividad.Items.Item(i).Text

                For Each drfiltro In dtfondos.Rows
                    If drfiltro("ccodact") = lccodigo Then
                        dr = dtactividad.NewRow()
                        dr("ccodcta") = drfiltro("ccodcta")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("dfecvig") = drfiltro("dfecvig")
                        dr("dfecven") = drfiltro("dfecven")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ncapdes") = drfiltro("ncapdes")
                        dr("nsaldo") = drfiltro("nsaldo")
                        dr("nmeses") = drfiltro("nmeses")
                        dr("nsalint") = drfiltro("nsalint")
                        dr("nsalmor") = drfiltro("nsalmor")
                        dr("nmorak") = drfiltro("nmorak")
                        dr("ccodana") = drfiltro("ccodana")
                        dr("ccoddom") = drfiltro("ccoddom")
                        dr("zona") = drfiltro("zona")
                        dr("ccodact") = drfiltro("ccodact") 'pendiente 
                        dr("csexo") = drfiltro("csexo") 'pendiente 
                        dr("cnomact") = lcdescri
                        dr("ccondic") = drfiltro("ccondic") 'pendiente 
                        dr("ccodlin") = drfiltro("ccodlin") 'pendiente 
                        dr("cdesfon") = drfiltro("cdesfon")
                        dr("sexo") = drfiltro("sexo")
                        dr("cartera") = drfiltro("cartera")
                        dr("analista") = drfiltro("analista")
                        'pagos
                        dr("ncapita") = drfiltro("ncapita")
                        dr("nintere") = drfiltro("nintere")
                        dr("nmora") = drfiltro("nmora")
                        dr("notros") = drfiltro("notros")
                        dr("cconcep") = drfiltro("cconcep")
                        dr("npago") = drfiltro("npago")

                        dtactividad.Rows.Add(dr)
                    End If
                Next
            End If
        Next


        'filtra sexo


        lncuenta = Me.ListSexo.Items.Count

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.ListSexo.Items(i).Selected Then
                lccodigo = Me.ListSexo.Items.Item(i).Value.Trim
                lcdescri = Me.ListSexo.Items.Item(i).Text

                For Each drfiltro In dtactividad.Rows
                    If drfiltro("csexo").trim = lccodigo Then
                        dr = dtsexo.NewRow()
                        dr("ccodcta") = drfiltro("ccodcta")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("dfecvig") = drfiltro("dfecvig")
                        dr("dfecven") = drfiltro("dfecven")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ncapdes") = drfiltro("ncapdes")
                        dr("nsaldo") = drfiltro("nsaldo")
                        dr("nmeses") = drfiltro("nmeses")
                        dr("nsalint") = drfiltro("nsalint")
                        dr("nsalmor") = drfiltro("nsalmor")
                        dr("nmorak") = drfiltro("nmorak")
                        dr("ccodana") = drfiltro("ccodana")
                        dr("ccoddom") = drfiltro("ccoddom")
                        dr("zona") = drfiltro("zona")
                        dr("ccodact") = drfiltro("ccodact")
                        dr("cnomact") = drfiltro("cnomact")
                        dr("csexo") = drfiltro("csexo")
                        dr("ccondic") = drfiltro("ccondic") 'pendiente 
                        dr("ccodlin") = drfiltro("ccodlin")
                        dr("cdesfon") = drfiltro("cdesfon")
                        dr("sexo") = lcdescri
                        dr("cartera") = drfiltro("cartera")
                        dr("analista") = drfiltro("analista")

                        'pagos
                        dr("ncapita") = drfiltro("ncapita")
                        dr("nintere") = drfiltro("nintere")
                        dr("nmora") = drfiltro("nmora")
                        dr("notros") = drfiltro("notros")
                        dr("cconcep") = drfiltro("cconcep")
                        dr("npago") = drfiltro("npago")

                        dtsexo.Rows.Add(dr)
                    End If
                Next
            End If
        Next


        'filtra tipo de cartera


        lncuenta = Me.ListTipo.Items.Count

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.ListTipo.Items(i).Selected Then
                lccodigo = Me.ListTipo.Items.Item(i).Value.Trim
                lcdescri = Me.ListTipo.Items.Item(i).Text

                For Each drfiltro In dtsexo.Rows
                    If drfiltro("ccondic").trim = lccodigo Then
                        dr = dtcartera.NewRow()
                        dr("ccodcta") = drfiltro("ccodcta")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("dfecvig") = drfiltro("dfecvig")
                        dr("dfecven") = drfiltro("dfecven")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ncapdes") = drfiltro("ncapdes")
                        dr("nsaldo") = drfiltro("nsaldo")
                        dr("nmeses") = drfiltro("nmeses")
                        dr("nsalint") = drfiltro("nsalint")
                        dr("nsalmor") = drfiltro("nsalmor")
                        dr("nmorak") = drfiltro("nmorak")
                        dr("ccodana") = drfiltro("ccodana")
                        dr("ccoddom") = drfiltro("ccoddom")
                        dr("zona") = drfiltro("zona")
                        dr("ccodact") = drfiltro("ccodact")
                        dr("cnomact") = drfiltro("cnomact")
                        dr("csexo") = drfiltro("csexo") 'pendiente 
                        dr("ccondic") = drfiltro("ccondic") 'pendiente 
                        dr("ccodlin") = drfiltro("ccodlin") 'pendiente 
                        dr("cdesfon") = drfiltro("cdesfon")
                        dr("sexo") = drfiltro("sexo")
                        dr("cartera") = lcdescri
                        dr("analista") = drfiltro("analista")

                        'pagos
                        dr("ncapita") = drfiltro("ncapita")
                        dr("nintere") = drfiltro("nintere")
                        dr("nmora") = drfiltro("nmora")
                        dr("notros") = drfiltro("notros")
                        dr("cconcep") = drfiltro("cconcep")
                        dr("npago") = drfiltro("npago")

                        dtcartera.Rows.Add(dr)
                    End If
                Next
            End If
        Next



        'filtra por analista


        lncuenta = Me.ListAna.Items.Count

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.ListAna.Items(i).Selected Then
                lccodigo = Me.ListAna.Items.Item(i).Value.Trim
                lcdescri = Me.ListAna.Items.Item(i).Text

                For Each drfiltro In dtcartera.Rows
                    If drfiltro("ccodana").trim = lccodigo Then
                        dr = dtanalista.NewRow()
                        dr("ccodcta") = drfiltro("ccodcta")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("dfecvig") = drfiltro("dfecvig")
                        dr("dfecven") = drfiltro("dfecven")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ncapdes") = drfiltro("ncapdes")
                        dr("nsaldo") = drfiltro("nsaldo")
                        dr("nmeses") = drfiltro("nmeses")
                        dr("nsalint") = drfiltro("nsalint")
                        dr("nsalmor") = drfiltro("nsalmor")
                        dr("nmorak") = drfiltro("nmorak")
                        dr("ccodana") = drfiltro("ccodana")
                        dr("ccoddom") = drfiltro("ccoddom")
                        dr("zona") = drfiltro("zona")
                        dr("ccodact") = drfiltro("ccodact")
                        dr("cnomact") = drfiltro("cnomact")
                        dr("csexo") = drfiltro("csexo")
                        dr("ccondic") = drfiltro("ccondic")
                        dr("ccodlin") = drfiltro("ccodlin") 'pendiente 
                        dr("cdesfon") = drfiltro("cdesfon")
                        dr("sexo") = drfiltro("sexo")
                        dr("cartera") = drfiltro("cartera")
                        dr("analista") = lcdescri

                        'pagos
                        dr("ncapita") = drfiltro("ncapita")
                        dr("nintere") = drfiltro("nintere")
                        dr("nmora") = drfiltro("nmora")
                        dr("notros") = drfiltro("notros")
                        dr("cconcep") = drfiltro("cconcep")

                        dr("npago") = drfiltro("npago")

                        dtanalista.Rows.Add(dr)
                    End If
                Next
            End If
        Next

        dsfiltro.Tables.Add(dtanalista)


        '*******************llama al reporte respectivo ***************

        If Me.rbtIngresos.Checked = True Then      'Pagos 
            Me.Imprime("cringresosfil.rpt")

        ElseIf Me.rbtDesem.Checked = True Then     'Desembolsos
            Me.Imprime("crdesembol.rpt")
            '    Me.Imprime("crdesembol3.rpt")

        ElseIf Me.rbtDetalle.Checked = True Then
            Me.Imprime("crdetalle.rpt")

        ElseIf Me.rbtCartera.Checked = True Then   'Cartera Vigente
            '            Me.Imprime("RptCartVig.rpt", ds)
            Me.Imprime("crdetcar.rpt")

        ElseIf Me.rbtMora.Checked = True Then      'Mora General 
            Me.Imprime("crdetmor.rpt")

        ElseIf Me.rbtProyec.Checked = True Then    'Proyeccion de Mora
            Me.Imprime("crpromor.rpt")

        ElseIf Me.rdbsumario.Checked = True Then    'sumarios
            Me.Imprime("crdetmor.rpt") 'pendiente

        ElseIf Me.rbtDesem.Checked = False Or Me.rbtCartera.Checked = False Or _
               Me.rbtDetalle.Checked = False Or Me.rbtIngresos.Checked = False Or _
               Me.rbtMora.Checked = False Or Me.rbtProyec.Checked = False Then
            Response.Write("<script language='javascript'>alert('No se selecciono ningun Reporte')</script>")
        End If
    End Sub

    Private Sub rbtIngresos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtIngresos.CheckedChanged
        Me.rbtDesem.Checked = False
        Me.rbtCartera.Checked = False
        Me.rbtDetalle.Checked = False
        Me.rbtMora.Checked = False
        Me.rbtProyec.Checked = False
    End Sub

    Private Sub rbtDesem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDesem.CheckedChanged
        Me.rbtCartera.Checked = False
        Me.rbtDetalle.Checked = False
        Me.rbtIngresos.Checked = False
        Me.rbtMora.Checked = False
        Me.rbtProyec.Checked = False
    End Sub

    Private Sub rbtCartera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCartera.CheckedChanged
        Me.rbtDesem.Checked = False
        Me.rbtDetalle.Checked = False
        Me.rbtIngresos.Checked = False
        Me.rbtMora.Checked = False
        Me.rbtProyec.Checked = False
    End Sub

    Private Sub rbtDetalle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDetalle.CheckedChanged
        Me.rbtDesem.Checked = False
        Me.rbtCartera.Checked = False
        Me.rbtIngresos.Checked = False
        Me.rbtMora.Checked = False
        Me.rbtProyec.Checked = False
    End Sub

    Private Sub rbtMora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMora.CheckedChanged
        Me.rbtDesem.Checked = False
        Me.rbtCartera.Checked = False
        Me.rbtDetalle.Checked = False
        Me.rbtIngresos.Checked = False
        Me.rbtProyec.Checked = False
    End Sub

    Private Sub rbtProyec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtProyec.CheckedChanged
        Me.rbtDesem.Checked = False
        Me.rbtCartera.Checked = False
        Me.rbtDetalle.Checked = False
        Me.rbtIngresos.Checked = False
        Me.rbtMora.Checked = False
    End Sub

    Private Sub chqzonas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqzonas.CheckedChanged
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListZonas.Items.Count

        Me.ListZonas.Enabled = True

        If Me.chqzonas.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListZonas.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListZonas.Items(i).Selected = False
            Next
        End If

    End Sub

    Private Sub chqfondos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqfondos.CheckedChanged
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListFondos.Items.Count

        Me.ListFondos.Enabled = True

        If Me.chqfondos.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListFondos.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListFondos.Items(i).Selected = False
            Next
        End If

    End Sub

    Private Sub chqactividad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqactividad.CheckedChanged
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListActividad.Items.Count

        Me.ListActividad.Enabled = True

        If Me.chqactividad.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListActividad.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListActividad.Items(i).Selected = False
            Next
        End If


    End Sub

    Private Sub chqsexo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqsexo.CheckedChanged
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListSexo.Items.Count

        Me.ListSexo.Enabled = True

        If Me.chqsexo.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListSexo.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListSexo.Items(i).Selected = False
            Next
        End If

    End Sub

    Private Sub chqcartera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqcartera.CheckedChanged
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListTipo.Items.Count

        Me.ListTipo.Enabled = True

        If Me.chqcartera.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListTipo.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListTipo.Items(i).Selected = False
            Next
        End If


    End Sub

    Private Sub chqanalista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqanalista.CheckedChanged
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListAna.Items.Count

        Me.ListAna.Enabled = True

        If Me.chqanalista.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListAna.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListAna.Items(i).Selected = False
            Next
        End If


    End Sub
End Class


