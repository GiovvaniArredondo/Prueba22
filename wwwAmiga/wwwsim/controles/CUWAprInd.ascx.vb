Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class CUWAprInd
    Inherits System.Web.UI.UserControl
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private cls_Sim As New SIM.bl.ClsSolicitud
    Private pcCodCta As String

#Region "Variables"
    Private clsConvert As New SIM.BL.ConversionLetras
    'Private pcCodCta As String
    'Private lNuevo As Boolean
    Private vCnn As Boolean
    Private Transacc As String
    Private ds As New DataSet
    Private ds_R As New DataSet
    Private lnindice_R As Integer
    Private lnindice_R1 As Integer
    Private lncodigo_R As String
    Private lnVal_R As String
    Private llBan_R As Boolean = False
    Private x As Integer
    Private y As Integer
    Private lnusu_R As String
    Private lnapl_R As String
    Private lndiasug As Integer
    Private lctipper As String
    Private lnmeses As Integer


    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    '--------------------------------  
    Private pcTipCre As String
    Private pcNrolin As String
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
#End Region
#Region " Metodos "
    Private Sub CargarDatos()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        ds = etabtofi.ObtenerDataSetPorNivel(Session("gnNivel"), Session("gcCodOfi"))

        'lnparametro1_R = "cNomOfi , cCodOfi, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTOFI"
        'lnparametro5_R = "S"
        'lnparametro6_R = " "
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxcodofi.DataTextField = "cNomOfi"
        Me.cbxcodofi.DataValueField = "cCodOfi"
        Me.cbxcodofi.DataSource = ds.Tables(0)
        Me.cbxcodofi.DataBind()
        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Institucion
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0541'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxCodIns.DataTextField = "cDescri"
        Me.cbxCodIns.DataValueField = "cCodigo"
        Me.cbxCodIns.DataSource = ds.Tables("Resultado")
        Me.cbxCodIns.DataBind()

        ds.Tables("Resultado").Clear()

        'cbxLineas
        Dim entidad2 As New SIM.EL.cretlin
        Dim clscretlin As New SIM.BL.cCretlin

        Dim mListacretlin As New listacretlin
        mListacretlin = clscretlin.ObtenerLista()
        '        ecretlin.ObtenerLista()

        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = mListacretlin
        Me.cbxLineas.DataBind()
        Me.txtFecDes.Text = Today()
        Me.txtfecpri.Text = Today.AddMonths(1)
        Me.txtgarantias.Text = 0

        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = " order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxgrupos.DataTextField = "cNomgru"
        Me.cbxgrupos.DataValueField = "cCodsol"
        Me.cbxgrupos.DataSource = ds.Tables("Resultado")
        Me.cbxgrupos.DataBind()

        Me.cbxgrupos.Visible = False
        Me.Label13.Visible = False
        Me.cbxgrupos.Disabled = True

        ds.Tables("Resultado").Clear()


        '----------------------------
        'Causas de rechazo
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0421'   order by cdescri"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.cbxrechazo.DataTextField = "cdescri"
        Me.cbxrechazo.DataValueField = "cCodigo"
        Me.cbxrechazo.DataSource = ds.Tables("Resultado")
        Me.cbxrechazo.DataBind()
        ds.Tables("Resultado").Clear()

        Label15.Visible = False
        cbxrechazo.Visible = False
        txtbandera.Text = "0"

        Me.btnGrabar.Disabled = True
        Me.Button1.Disabled = True

        'Button1.Visible = False
    End Sub
    Private Sub CargarDatosCredito()

        Label15.Visible = False
        cbxrechazo.Visible = False


        Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta
        ecreditos.Obtenercreditos(entidad3)
        If entidad3.cestado <> "D" And entidad3.cestado <> "E" Then
            Me.btnGrabar.Disabled = True
            Me.Button1.Disabled = True
            Me.btnPlan.Disabled = True
            Response.Write("<script language='javascript'>alert('Estado Errado')</script>")
            Return
        Else
            Me.btnPlan.Disabled = False
        End If
        cbxcodofi.SelectedValue = pcCodCta.Trim.Substring(3, 3)

        Me.txtcCodCli.Text = entidad3.ccodcli
        Me.txtcNomcli.Text = entidad3.cnomcli
        Me.txtMonSol.Text = entidad3.nmonsol
        Me.txtNomAna.Text = entidad3.cNomUsu
        Me.txtmonSug.Text = entidad3.nmonsug
        Me.pnCuoSug.Text = entidad3.ncuosug
        Me.txtnMonApr.Text = entidad3.nmonsug
        Me.txtcTipPer.Text = entidad3.ctipper
        Me.txtcTipCuo.Text = entidad3.ctipcuo
        Me.txtnperdia.Text = entidad3.ndiasug
        Me.txtndiaGra.Text = entidad3.ndiagra

        Dim ecretlin As New ccretlin
        Me.TextBox1.text = ecretlin.ObtenerFuentedeFondos(entidad3.cnrolin)

        Me.txtcontrato.Text = entidad3.ctipcon
        Me.txtcflat.Text = IIf(IsDBNull(entidad3.cflat), "", entidad3.cflat)

        Me.txtFecDes.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)
        
        Dim entidadcredtpl As New cCredtpl
        Me.txtfecpri.Text = entidadcredtpl.Obtenerprimeracuota(pcCodCta)
        'verifica numero de creditos

        Dim lnciclo As Integer
        lnciclo = ecreditos.ciclo(Me.txtcCodCli.Text.Trim, pcCodCta)
        Dim lcletras As String
        lcletras = clsConvert.ConversionEnteros(lnciclo)
        If lnciclo > 1 Then
            viewstate("pctippre") = lcletras + " CREDITOS "
        Else
            viewstate("pctippre") = "NUEVO"
        End If

        '        viewstate("pctippre") = IIf(entidad3.ctipcre = "N", "NUEVO", "RECURRENTE")
        lndiasug = entidad3.ndiasug
        lctipper = entidad3.ctipper

        Me.txtcfreccap.Text = entidad3.cfreccap
        Me.txtcfrecint.Text = entidad3.cfrecint


        Me.txtgarantias.Text = clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        Session("nGrav") = Me.txtgarantias.Text
        pcCodAct = entidad3.ccodact
        Session.Add("pcCodcli", Me.txtcCodCli.Text)
        '
        If IsDBNull(entidad3.cnrolin) Then
        Else
            Me.cbxLineas.SelectedValue = entidad3.cnrolin
        End If

        If entidad3.ccodsol = "" Or entidad3.ccodsol.Trim = "" Then
            Me.cbxgrupos.Visible = False
            Me.Label13.Visible = False
            Me.txtccodsol.Text = ""
        Else
            Me.cbxgrupos.Value = entidad3.ccodsol
            Me.cbxgrupos.Visible = True
            Me.Label13.Visible = True
            Me.txtccodsol.Text = entidad3.ccodsol
        End If

        Dim entidad4 As New SIM.EL.clidfin
        Dim clsclidfin As New SIM.BL.cClidfin

        Dim mListaclidfin As New listaclidfin
        mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)

    End Sub

#End Region

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
            Me.CargaVariables()
            Me.CargarDatos()
            Me.Label11.Visible = False
            Me.Label11.Text = ""
        Else
            Me.txtgarantias.Text = Session("nGrav")
        End If
    End Sub


    Private Sub IgualaDatos()
        pcCodCta = Me.txtCredito.Text
        Dim dsCre As New DataSet
        Dim eCremcre As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab
        Dim lcdestino As String

        dsCre = eCremcre.Resumen(Me.txtCredito.Text.Trim)
        If dsCre.Tables(0).Rows.Count = 0 Then
            lcdestino = "CAPITAL DE TRABAJO"
        Else
            lcdestino = etabttab.Describe(dsCre.Tables(0).Rows(0)("cdescre"), "005")

        End If

        Dim lnTasa As Double
        Dim ds As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        Dim lccodlin As Integer
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        lnTasa = entidadCretlin.ntasint
        viewstate("pctasmor") = entidadCretlin.ntasmor.ToString
        viewstate("pctasa") = entidadCretlin.ntasint.ToString
        viewstate("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        viewstate("pnmonsug") = Me.txtmonSug.Text

        If Me.txtmonSug.Text <= 5000 Then
            viewstate("pccomite1") = "X"
            viewstate("pccomite2") = ""
        Else
            viewstate("pccomite2") = "X"
            viewstate("pccomite1") = ""
        End If
        '>>>>>>>>>>>>>>>>>>>>>>
        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.txtcCodCli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clase.lsegvid = eclimide.lsegvida

        Dim entidadcreditos As New creditos
        entidadcreditos.ccodcta = Me.txtCredito.Text.Trim
        eCremcre.Obtenercreditos(entidadcreditos)
        clase.nMeses = clase.PlazoMeses(IIf(IsDBNull(entidadcreditos.dfecvig), Session("gdfecsis"), entidadcreditos.dfecvig), _
                                        IIf(IsDBNull(entidadcreditos.dfecven), Session("gdfecsis"), entidadcreditos.dfecven))
        'localiza fuente de fondos en base a cCodlin
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        lccodlin = entidadCretlin.ccodlin
        Dim clstabttab As New cTabttab
        Dim ds033 As New DataSet
        Dim lcfondos As String
        Dim nelemf As Integer
        lcfondos = lccodlin.ToString.Substring(2, 2).Trim
        ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos)
        nelemf = ds033.Tables(0).Rows.Count
        If nelemf = 0 Then
            viewstate("pcfuente") = ""
        Else
            viewstate("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        viewstate("pcnomchq") = entidadCredchq.cnomchq
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate("pdfecha") = Date.Parse(Me.txtFecDes.Text)
        '        Me.txtfecpri.Text = Today.AddMonths(1)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)

        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtnMonApr.Text 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        'clase.cCodFor = lnTipCuo
        ' clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        'clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        'clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = Me.txtcflat.Text.Trim
        clase.cCodfue = lcfondos
        clase.gntasaiva = Session("gnIVA")
        If txtbandera.Text.Trim = "1" Then
            clase.cCodRec = cbxrechazo.Value.Trim
        End If

        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = pcCodCta
        clase.cCodFor = Me.txtcTipPer.Text
        clase.cTipCuo = Me.txtcTipCuo.Text
        clase.nPerDia = Me.txtnperdia.Text
        clase.nDiaGra = Me.txtndiaGra.Text
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        If clase.cCodFor = "2" Then
            clase.nPerDia = Day(clase.dFecDes)
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        viewstate("pcnomcli") = Me.txtcNomcli.Text
        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        viewstate("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        viewstate("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        viewstate("pccanlet") = clsConvert.ConversionEnteros(Double.Parse(Me.txtmonSug.Text.Trim))
        lnDecimal = clsConvert.ExtraeDecimales(Me.txtmonSug.Text.Trim)
        ViewState("pccanlet") = ViewState("pccanlet") & " " & lnDecimal.ToString & "/100" & " QUETZALES"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dstipo As New DataSet
        Dim nelemgar As Integer
        Dim mcrepgar As New cCrepgar
        'dstipo = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        dstipo = clase.Garantizados(Me.txtcCodCli.Text.Trim)
        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            viewstate("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            viewstate("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            viewstate("pctipo") = "MIXTA"
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsclimgar As New cClimgar
        Dim dsgar As New DataSet
        Dim nelemg As Integer = 0
        Dim pcgar As String = ""
        Dim garant As String = ""

        dsgar = clsclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        nelemg = dsgar.Tables(0).Rows.Count
        If nelemg = 0 Then
            viewstate("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            viewstate("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim ds077 As New DataSet
        Dim lcdocu As String
        Dim nelemf1 As Integer
        lcdocu = Me.txtcontrato.Text
        ds077 = clstabttab.ObtenerDataSetPorID2("077", "1", lcdocu)
        nelemf = ds077.Tables(0).Rows.Count
        If nelemf1 = 0 Then
            viewstate("pccontrato") = ""
        Else
            viewstate("pccontrato") = ds077.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Me.Cargar_Gastos()
        Me.Meses()
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        Me.txtCredito.Text = codigoCliente.Trim
        pcCodCta = codigoCliente
        Aplicar()
    End Sub
    Public Sub CargarPlan(ByVal codigoCliente As String)
        Me.btnPlan_ServerClick(Me, New EventArgs)
    End Sub
    

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("WfBusLin.aspx")
        Me.txtMonSol.Text = viewstate("vnMonSol")
    End Sub

    Private Sub txtNomAna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomAna.TextChanged

    End Sub

    Private Sub cbxLineas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLineas.SelectedIndexChanged

    End Sub
    Private Sub Imprimir()
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CRAprSol.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsPlanPago As New DataSet
        Dim entidadCremcre As New SIM.EL.cremcre
        Dim eCremcre As New SIM.BL.cCremcre
        entidadCremcre.ccodcta = Me.txtCredito.Text.Trim
        dsPlanPago = eCremcre.ObtenerDataSetPorIDAC(Me.txtCredito.Text.Trim)
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Private Sub Aplicar()
        CargarDatosCredito()
    End Sub


    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
        'Verifica filtro de requisitos

        Dim laprobar As Boolean
        Dim laprobar1 As Boolean

        laprobar = clase.RequisitosChequeados(Me.cbxgrupos.Value.Trim.Substring(6, 2), Me.txtCredito.Text.Trim)
        'If laprobar = False Then
        '    laprobar1 = clase.RequisitosChequeados(Me.cbxgrupos.Value.Trim.Substring(6, 2), Me.cbxgrupos.Value.Trim)
        '    If laprobar1 = False Then
        '        Response.Write("<script language='javascript'>alert('Faltan Requisitos')</script>")
        '        Return
        '    End If
        'End If

        IgualaDatos()
        Dim eclimgar As New cClimgar
        Dim lnvalidapref As Integer
        lnvalidapref = eclimgar.ValidaGarantiaPref(Me.txtcCodCli.Text.Trim)

        Me.txtgarantias.Text = Session("nGrav") 'clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        'Validaciones
        If lnvalidapref = 1 Then

        Else
            If Double.Parse(Me.txtnMonApr.Text) > Double.Parse(Me.txtgarantias.Text) And Me.txtccodsol.Text.Trim = "" Then
                Me.Label11.Visible = True
                Me.Label11.Text = "Monto Aprobado es mayor que garantía"
                Exit Sub
            Else
                Me.Label11.Visible = False
                Me.Label11.Text = ""
            End If
        End If

        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)
        clase.dFecApr = Session("gdFecSis")
        clase.pcCodUsu = Session("gccodusu")
        clase.gnmoncuo = ViewState("pncuota")
        clase.Graba_Aprobacion("E")
        Label15.Visible = False
        cbxrechazo.Visible = False
        If txtbandera.Text.Trim = "1" Then
            Response.Write("<script language='javascript'>alert('Solicitud Rechazada')</script>")
        Else
            ImprimirIA()
            Response.Write("<script language='javascript'>alert('Aprobación Grabada')</script>")
        End If


        'Imprimir()


    End Sub

    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick
        IgualaDatos()
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        clase.pcCodUsu = Session("gcCodUsu")
        clase.dFecsis = Session("gdFecSis")

        clase.cfreccap = Me.txtcfreccap.Text.Trim
        clase.cfrecint = Me.txtcfrecint.Text.Trim

        
        ds = clase.fxCreatePlain(1, 0)
        Dim nCanti3 As Integer
        nCanti3 = ds.Tables(0).Rows.Count()
        clase.PlanTeorico(ds.Tables(0), pcCodCta)
        Me.txtdFecVen.Text = clase.dFecVen.ToString
        viewstate("pncuota") = utilNumeros.Redondear(clase.pnmonCuo, 2)
        Session.Item("CodigoCre") = pcCodCta
        Me.txtnMonApr.Enabled = False
        Me.txtFecDes.Enabled = False
        Me.txtfecpri.Enabled = False
        Me.btnGrabar.Disabled = False
        Me.Button1.Disabled = False
        Me.btnPlan.Disabled = True
        Me.FormaPago(Me.txtcfreccap.Text.Trim, Me.txtcfrecint.Text.Trim)
    End Sub

    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
        Me.txtnMonApr.Enabled = False
        Me.txtFecDes.Enabled = False
        Me.txtfecpri.Enabled = False
        If Me.txtcCodCli.Text.Trim = "" Then
            Me.btnPlan.Disabled = True
        Else
            Me.btnPlan.Disabled = False
        End If

    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        'Response.Redirect("wfCausas.aspx")
        txtbandera.Text = "1"
        Label15.Visible = True
        cbxrechazo.Visible = True
    End Sub
    Private Sub CargaVariables()
        viewstate.Add("pcnomcli", "") 'nombre de cliente
        viewstate.Add("pcdestino", "") 'destino
        viewstate.Add("pcdeslin", "") 'nombre de linea
        viewstate.Add("pctippre", "") ' tipo de credito
        viewstate.Add("pcfuente", "") 'fuente de fondos
        viewstate.Add("pctasa", "") 'tasa de interes
        viewstate.Add("pcagencia", "") 'agencia
        viewstate.Add("pnmonsug", 0) 'monto sugerido
        viewstate.Add("pctasmor", "") ' tasa moratoria
        viewstate.Add("pcmeses", "") 'meses
        viewstate.Add("pcnomchq", "") ' Cheque a nombre de 
        viewstate.Add("pdfecha", Today()) ' fecha de desembolso
        viewstate.Add("pcgarantia", "") 'Garantias
        viewstate.Add("pccanLet", "") ' cantidad en letras
        viewstate.Add("pncuota", 0) 'cuota sugerida
        viewstate.Add("pctipo", "") 'tipo de garantia
        viewstate.Add("pcforpag", "") ' forma de pago
        viewstate.Add("pcnomana", "") ' nombre de analista
        viewstate.Add("pccontrato", "") 'tipo de contrato
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate.Add("pcComite1", "") 'comite de credito nivel 1
        viewstate.Add("pcComite2", "") 'comite de credito nivel 2
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ' comisiones '
        viewstate.Add("pncom1", 0)
        viewstate.Add("pccom1", "")

        viewstate.Add("pncom2", 0)
        viewstate.Add("pccom2", "")

        viewstate.Add("pncom3", 0)
        viewstate.Add("pccom3", "")

        viewstate.Add("pncom4", 0)
        viewstate.Add("pccom4", "")

        viewstate.Add("pncom5", 0)
        viewstate.Add("pccom5", "")

        viewstate.Add("pncom6", 0)
        viewstate.Add("pccom6", "")
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate.Add("pndeuda", 0) 'valor a refinanciar
        ViewState.Add("pccreref", "") 'credito a ser refinanciado
        txtbandera.Text = "0"
    End Sub
    Private Sub ImprimirIA()
        Dim dsgarantias As New DataSet
        Dim mclimgar As New cClimgar
        Try

            dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        Catch ex As Exception

        End Try

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim reportes As String
        reportes = "CrIA.pdf"

        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRptIA.Load(Server.MapPath("reportes") + "\crIA.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRptIA.SetDataSource(dsgarantias.Tables(0))
        crRptIA.Refresh()

        Dim pccodcta1 As String
        Dim pccodcli1 As String
        Dim pcnomana1 As String

        pccodcta1 = pcCodCta
        pccodcli1 = Me.txtcCodCli.Text.Trim
        pcnomana1 = Me.txtNomAna.Text.Trim

        crRptIA.SetParameterValue("lcnomcli", viewstate("pcnomcli"))
        crRptIA.SetParameterValue("lcdestino", viewstate("pcdestino"))
        crRptIA.SetParameterValue("lcdeslin", viewstate("pcdeslin"))
        crRptIA.SetParameterValue("lctippre", viewstate("pctippre"))
        crRptIA.SetParameterValue("lcfondos", viewstate("pcfuente"))
        crRptIA.SetParameterValue("lctasa", viewstate("pctasa"))
        crRptIA.SetParameterValue("lcagencia", viewstate("pcagencia"))
        crRptIA.SetParameterValue("lnmonsug", viewstate("pnmonsug"))
        crRptIA.SetParameterValue("lctasmor", viewstate("pctasmor"))
        crRptIA.SetParameterValue("lcmeses", lnmeses.ToString)
        crRptIA.SetParameterValue("lcnomchq", viewstate("pcnomchq"))
        crRptIA.SetParameterValue("ldfecha", viewstate("pdfecha"))
        crRptIA.SetParameterValue("lcgarantia", "") 'poner suma de garantias
        crRptIA.SetParameterValue("lccanlet", viewstate("pccanlet"))
        crRptIA.SetParameterValue("lncuosug", viewstate("pncuota"))
        crRptIA.SetParameterValue("lctipo", viewstate("pctipo"))
        crRptIA.SetParameterValue("lcforpag", viewstate("pcforpag"))
        crRptIA.SetParameterValue("lccodcta", pccodcta1)
        crRptIA.SetParameterValue("lccodcli", pccodcli1)
        crRptIA.SetParameterValue("lcnomana", pcnomana1)
        crRptIA.SetParameterValue("lccontrato", viewstate("pccontrato"))
        crRptIA.SetParameterValue("lccomite1", viewstate("pccomite1"))
        crRptIA.SetParameterValue("lccomite2", viewstate("pccomite2"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRptIA.SetParameterValue("lncom1", viewstate("pncom1"))
        crRptIA.SetParameterValue("lccom1", viewstate("pccom1"))

        crRptIA.SetParameterValue("lncom2", viewstate("pncom2"))
        crRptIA.SetParameterValue("lccom2", viewstate("pccom2"))

        crRptIA.SetParameterValue("lncom3", viewstate("pncom3"))
        crRptIA.SetParameterValue("lccom3", viewstate("pccom3"))

        crRptIA.SetParameterValue("lncom4", viewstate("pncom4"))
        crRptIA.SetParameterValue("lccom4", viewstate("pccom4"))

        crRptIA.SetParameterValue("lncom5", viewstate("pncom5"))
        crRptIA.SetParameterValue("lccom5", viewstate("pccom5"))

        crRptIA.SetParameterValue("lncom6", viewstate("pncom6"))
        crRptIA.SetParameterValue("lccom6", viewstate("pccom6"))

        crRptIA.SetParameterValue("lndeuda", viewstate("pndeuda"))
        crRptIA.SetParameterValue("lccreref", viewstate("pccreref"))

        rptStreamIA = CType(crRptIA.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStreamIA.ToArray())
        'Response.End()
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStreamIA.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    End Sub
    Private Sub Cargar_Gastos()
        Dim xy As Integer
        Dim xydata As New DataSet
        Dim clscredgas As New cCredgas
        Dim lctipgas As String
        Dim lngasto As Double
        xydata = clscredgas.ObtenerDataSetPorID2(pcCodCta, "D")
        xy = xydata.Tables(0).Rows.Count
        If xy = 0 Then

        Else
            xy = 0
            Dim Filaxy As DataRow
            For Each Filaxy In xydata.Tables(0).Rows
                lctipgas = xydata.Tables(0).Rows(xy)("ctipgas")
                lngasto = xydata.Tables(0).Rows(xy)("nmongas")
                If lctipgas = "01" And lngasto <> 0 Then
                    viewstate("pncom1") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom1") = "X"
                ElseIf lctipgas = "03" And lngasto <> 0 Then
                    viewstate("pncom2") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom2") = "X"
                ElseIf lctipgas = "04" And lngasto <> 0 Then
                    viewstate("pncom3") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom3") = "X"
                ElseIf lctipgas = "PR" And lngasto <> 0 Then
                    viewstate("pncom4") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom4") = "X"
                ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
                    viewstate("pncom5") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom5") = "X"
                ElseIf lctipgas = "02" And lngasto <> 0 Then
                    ViewState("pncom6") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom6") = "X"
                End If
                xy += 1
            Next
        End If
        refina()
    End Sub
    Private Sub refina()
        Dim dscancela As New DataSet
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela
        dscancela = ecancela.ObtenerDataSetPorCuenta(pcCodCta)

        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        Dim e As Double = 0
        Dim f As Double = 0
        Dim deuda As Double
        Dim deuda1 As Double
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim pcref1 As String
        Dim pcref As String
        If dscancela.Tables(0).Rows.Count = 0 Then
            viewstate("pndeuda") = 0
            viewstate("pccreref") = ""
        Else
            For Each fila In dscancela.Tables(0).Rows
                a = dscancela.Tables(0).Rows(nelem)("nsalcap")
                b = dscancela.Tables(0).Rows(nelem)("nsalint")
                c = dscancela.Tables(0).Rows(nelem)("nsalmor")
                d = dscancela.Tables(0).Rows(nelem)("nmanejo")
                e = dscancela.Tables(0).Rows(nelem)("nseguro")
                f = dscancela.Tables(0).Rows(nelem)("niva")
                deuda1 = a + b + c + d + e + f
                deuda = deuda + deuda1
                pcref1 = dscancela.Tables(0).Rows(nelem)("ccodcta")
                pcref = pcref + IIf(nelem = 0, "", ", ") + pcref1
                nelem += 1
            Next
            viewstate("pndeuda") = deuda
            viewstate("pccreref") = pcref
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
       

    End Sub
    Private Sub FormaPago(ByVal ccapital As String, ByVal cinteres As String)

        Dim lcforma As String
        Dim lcformapago1 As String = ""
        Dim lcformapago2 As String = ""
        Dim etabttab As New cTabttab

        lcformapago1 = IIf(IsDBNull(ccapital), "", etabttab.Describe(ccapital, "060"))
        lcformapago2 = IIf(IsDBNull(cinteres), "", etabttab.Describe(cinteres, "060"))

        lcforma = "Capital " + lcformapago1 + " Interes " + lcformapago2
        ViewState("pcforpag") = Me.pnCuoSug.Text.ToString & " CUOTAS " & lcforma & " de Q" & clase.pnmonCuo.ToString & " c/u."
        If lndiasug = 1 Then
            ViewState("pcforpag") = "una cuota al vencimientode Q " & clase.pnmonCuo.ToString & " c/u."
        End If
    End Sub
    Private Sub Meses()
        If lctipper = "1" Then 'Periodo Fijo
            Select Case lndiasug
                Case lndiasug = 7
                    lnmeses = CInt(Me.pnCuoSug.Text / 4)
                Case lndiasug = 14
                    lnmeses = CInt(Me.pnCuoSug.Text / 2)
                Case lndiasug = 15
                    lnmeses = CInt(Me.pnCuoSug.Text / 2)
                Case lndiasug = 30
                    lnmeses = CInt(Me.pnCuoSug.Text)
                Case lndiasug = 31
                    lnmeses = CInt(Me.pnCuoSug.Text)
                Case lndiasug = 60
                    lnmeses = CInt(Me.pnCuoSug.Text * 2)
                Case lndiasug = 90
                    lnmeses = CInt(Me.pnCuoSug.Text * 3)
                Case lndiasug = 120
                    lnmeses = CInt(Me.pnCuoSug.Text * 4)
                Case lndiasug = 360
                    lnmeses = CInt(Me.pnCuoSug.Text * 12)
                Case lndiasug = 365
                    lnmeses = CInt(Me.pnCuoSug.Text * 12)
                Case Else
                    lnmeses = Me.pnCuoSug.Text
            End Select
        Else 'Fecha Fija
            lnmeses = Me.pnCuoSug.Text
        End If
    End Sub
End Class
