Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class CUWPreAprInd
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
    Private codigoJs As String
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

        '----------------------------
        'Llenando Programa
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0331'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.cbxprograma.Items.Add(fila1("cCodigo") & "   --" & " " & fila1("cDescri"))
        'Next
        'Me.cbxprograma.SelectedIndex = 0


        Me.cbxprograma.DataTextField = "cDescri"
        Me.cbxprograma.DataValueField = "cCodigo"
        Me.cbxprograma.DataSource = ds.Tables("Resultado")
        Me.cbxprograma.DataBind()
        ds.Tables("Resultado").Clear()

        '>>>>>>>>>>>>>>>>>>>>>>>>
        lnparametro1_R = "cDescri , left(cCodigo,1) as ccodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0771'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Datos a Eligir", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxContrato.DataTextField = "cDescri"
        Me.cbxContrato.DataValueField = "cCodigo"
        Me.cbxContrato.DataSource = ds.Tables("Resultado")
        Me.cbxContrato.DataBind()
        ds.Tables("Resultado").Clear()

        Label15.Visible = False
        cbxrechazo.Visible = False
        txtbandera.Text = "0"

        Me.Txtncomis.Text = "0.0"
        Me.btnGrabar.Disabled = True
        Me.ImageButton1.Enabled = False

        HiddenField9.Value = ""

        Me.CbxUsuario_Comite1.Recuperar(Session("gnIdusuario"))
    End Sub
    Private Sub CargarDatosCredito()
        Label15.Visible = False
        cbxrechazo.Visible = False

        Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta
        ecreditos.Obtenercreditos(entidad3)
        If entidad3.cestado <> "E" And entidad3.cestado <> "C" Then
            Me.btnGrabar.Disabled = True
            Me.ImageButton1.Enabled = False
            Me.btnPlan.Disabled = True
            '            Response.Write("<script language='javascript'>alert('Estado Errado')</script>")
            codigoJs = "<script language='javascript'>alert('Estado Errado, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        Else
            Me.btnPlan.Disabled = False
        End If
        cbxcodofi.SelectedValue = entidad3.coficina 'pcCodCta.Trim.Substring(3, 3)
        Me.txtcCodCli.Text = entidad3.ccodcli
        Me.txtcNomcli.Text = entidad3.cnomcli
        Me.txtMonSol.Text = entidad3.nmonsol
        Me.txtNomAna.Text = entidad3.cNomUsu
        Me.txtmonSug.Text = entidad3.nmonsug
        Me.pnCuoSug.Text = entidad3.ncuosug
        Me.pnCuoSug0.Text = IIf(entidad3.ncuosug0 = 0, 0, entidad3.ncuosug0)
        Me.txtnMonApr.Text = entidad3.nmonsug
        Me.txtcTipPer.Text = entidad3.ctipper
        Me.txtcTipCuo.Text = entidad3.ctipcuo
        Me.txtnperdia.Text = entidad3.ndiasug
        Me.txtndiaGra.Text = entidad3.ndiagra
        Me.Chkseguro.Checked = entidad3.lsegvid
        txttasa.Text = entidad3.ntasint
        Me.txtcontrato.Text = entidad3.ctipcon
        cbxContrato.SelectedValue = entidad3.ctipcon
        Me.txtcflat.Text = IIf(IsDBNull(entidad3.cflat), "", entidad3.cflat)
        txtacta.Text = entidad3.cacta
        txtresolucion.Text = entidad3.cresolucion

        Me.txttipocuota.Text = IIf(txtcflat.Text.Trim = "F", "FLAT", IIf(entidad3.ctipcuo = "1", "NIVELADA", "DECRECIENTE"))
        HiddenField9.Value = entidad3.cfueing

        Me.txtFecDes.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)
        Me.txtFecDes0.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)

        Dim entidadcredtpl As New cCredtpl
        Me.txtfecpri.Text = entidadcredtpl.Obtenerprimeracuota(pcCodCta)
        Me.txtfecpri0.Text = entidadcredtpl.Obtenerprimeracuota(pcCodCta)

        txtdFecVen.Text = entidadcredtpl.ObtenerUltimacuota(pcCodCta)
        ViewState("pncuota") = entidad3.nmoncuo


        Session.Add("gcNomChq", Me.txtcNomcli.Text.Trim)
        Session.Add("gnMonto", Double.Parse(Me.txtnMonApr.Text))

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

        Me.txtgarantias.Text = clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        Session("nGrav") = Me.txtgarantias.Text
        pcCodAct = entidad3.ccodact
        Session.Add("pcCodcli", Me.txtcCodCli.Text)
        '

        If IsDBNull(entidad3.ccodfue) Then
        Else
            CargaLineasxFondos(entidad3.ccodfue)
        End If

        If IsDBNull(entidad3.cnrolin) Then
        Else
            Try
                Me.cbxLineas.SelectedValue = entidad3.cnrolin
                'Cesar Torres 19/01/2016
                'Crear una funciona para validar que el credito sea de conavi
                SiEsConavi(entidad3.cnrolin)
                Dim entidadcretlin As New cretlin
                Dim mcretlin As New cCretlin

                entidadcretlin.cnrolin = Me.cbxLineas.SelectedValue.Trim
                mcretlin.ObtenerCretlin(entidadcretlin)
                Me.txtnmoncuo.text = entidadcretlin.nmoncuo
            Catch ex As Exception

            End Try


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

        Me.txtcfreccap.Text = entidad3.cfreccap
        Me.txtcfrecint.Text = entidad3.cfrecint


        Dim entidad4 As New SIM.EL.clidfin
        Dim clsclidfin As New SIM.BL.cClidfin

        Dim mListaclidfin As New listaclidfin
        mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)


        Dim ecretlin As New cCretlin
        Me.cbxprograma.SelectedValue = entidad3.ccodfue

        'Cargamos aditivos
        Dim ecredtpl As New cCredtpl
        Txtncomis.Text = ecredtpl.CargarAditivos(pcCodCta)

        Dim lverificaPlan As Boolean
        lverificaPlan = clase.VerificaExistePlanTeorico(pcCodCta)
        If lverificaPlan = True Then
            btnPlan.Disabled = True
            btnGrabar.Disabled = False
        Else
            btnPlan.Disabled = False
            btnGrabar.Disabled = True
        End If
        'Iguala Valores del plan de pagos
        HiddenField5.Value = cbxLineas.SelectedValue.Trim
        HiddenField6.Value = Double.Parse(txttasa.Text)
        HiddenField7.Value = Integer.Parse(pnCuoSug.Text)
        HiddenField8.Value = Double.Parse(txtmonSug.Text)
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
        Dim lccodlin As String
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        'lnTasa = entidadCretlin.ntasint
        lnTasa = Double.Parse(txttasa.Text)

        ViewState("pctasmor") = entidadCretlin.ntasmor.ToString
        ViewState("pctasa") = lnTasa.ToString
        ViewState("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        ViewState("pnmonsug") = Me.txtnMonApr.Text
        clase.lliva = entidadCretlin.lliva

        If Me.txtnMonApr.Text <= 5000 Then
            ViewState("pccomite1") = "X"
            ViewState("pccomite2") = ""
        Else
            ViewState("pccomite2") = "X"
            ViewState("pccomite1") = ""
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
        clase.cCodfue = Me.cbxprograma.SelectedValue.Trim
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
            ViewState("pcfuente") = ""
        Else
            ViewState("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        ViewState("pcnomchq") = entidadCredchq.cnomchq

        'Recuperamos el data set de los cheques
        Dim dscheques As New DataSet
        dscheques = ecredchq.ObtieneCheques(pcCodCta)
        If dscheques.Tables(0).Rows.Count = 0 Then
        Else
            Dim filach As DataRow
            Dim ich As Integer = 0
            For Each filach In dscheques.Tables(0).Rows
                If ich = 0 Then
                    ViewState("pcnomchq") = dscheques.Tables(0).Rows(ich)("cnomchq")
                    ViewState("pnmonto") = dscheques.Tables(0).Rows(ich)("nmonto")
                ElseIf ich = 1 Then
                    ViewState("pcnomchq2") = dscheques.Tables(0).Rows(ich)("cnomchq")
                    ViewState("pnmonto2") = dscheques.Tables(0).Rows(ich)("nmonto")
                ElseIf ich = 2 Then
                    ViewState("pcnomchq3") = dscheques.Tables(0).Rows(ich)("cnomchq")
                    ViewState("pnmonto3") = dscheques.Tables(0).Rows(ich)("nmonto")
                ElseIf ich = 3 Then
                    ViewState("pcnomchq4") = dscheques.Tables(0).Rows(ich)("cnomchq")
                    ViewState("pnmonto4") = dscheques.Tables(0).Rows(ich)("nmonto")
                End If
                ich += 1
            Next

        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState("pdfecha") = Date.Parse(Me.txtFecDes.Text)
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
        clase.nNroCuo0 = Integer.Parse(Me.pnCuoSug0.Text)

        'clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        'clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = Me.txtcflat.Text.Trim
        clase.gntasaiva = Session("gnIVA")
        clase.pniva = Session("gnIVA")

        If txtbandera.Text.Trim = "1" Then
            clase.cCodRec = cbxrechazo.SelectedValue.Trim
        End If
        clase.ngastos1 = Double.Parse(Txtncomis.Text)

        clase.pctipcon = Me.cbxContrato.SelectedItem.Value.Trim
        txtcontrato.Text = Me.cbxContrato.SelectedItem.Value.Trim
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
        ViewState("pcnomcli") = Me.txtcNomcli.Text
        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        ViewState("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        ViewState("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        ViewState("pccanlet") = clsConvert.ConversionEnteros(Double.Parse(Me.txtmonSug.Text.Trim))
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
            ViewState("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            ViewState("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            ViewState("pctipo") = "MIXTA"
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
            ViewState("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            ViewState("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim ds077 As New DataSet
        Dim lcdocu As String
        Dim nelemf1 As Integer
        lcdocu = Me.txtcontrato.Text
        ds077 = clstabttab.ObtenerDataSetPorID2("077", "1", lcdocu)
        nelemf = ds077.Tables(0).Rows.Count
        If nelemf1 = 0 Then
            ViewState("pccontrato") = ""
        Else
            ViewState("pccontrato") = ds077.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        clase.cacta = txtacta.Text.Trim
        clase.cresolucion = txtresolucion.Text.Trim

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
        Me.txtMonSol.Text = ViewState("vnMonSol")
    End Sub

    Private Sub txtNomAna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomAna.TextChanged

    End Sub

    Private Sub cbxLineas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLineas.SelectedIndexChanged
        CargaTasas()
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

        Dim ecredchq As New cCredchq
        Dim lnmonchq As Decimal = 0
        Dim omtabttab As New cTabttab
        Dim llvalida_comite As Boolean

        lnmonchq = ecredchq.MontodeCheques(Me.txtCredito.Text.Trim)

        Dim llvalida As Boolean


        If Me.CbxUsuario_Comite1.Items.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        llvalida = clase.Valida_Monto_Comite(Me.CbxUsuario_Comite1.SelectedValue.Trim, Double.Parse(Me.txtnMonApr.Text))

        If Not llvalida Then
            Me.btnGrabar.Disabled = True
            '            Response.Write("<script language='javascript'>alert('Linea Iválida')</script>")
            codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub

        End If


        'Verifica que todos los niveles de comite esten cubiertos
        llvalida_comite = omtabttab.Valida_Niveles_Aprobacion(Double.Parse(Me.txtnMonApr.Text), Me.txtCredito.Text.Trim)
        If Not llvalida_comite Then
            Response.Write("<script language='javascript'>alert('No se completaron todos los niveles de Firmas, Verifique, Advertencia SIM.NET')</script>")
            Exit Sub
        End If

        'If Double.Parse(txtnMonApr.Text) <> lnmonchq Then
        '    Response.Write("<script language='javascript'>alert('Monto de Prestamo y Monto de Cheques difieren')</script>")
        '    Exit Sub
        'End If
        'Verifica si existieron cambios para obligar a generar otra vez el plan de pagos
        Dim lverifica As Boolean
        lverifica = ValidaCambios()
        If lverifica = False Then
            'Response.Write("<script language='javascript'>alert('Cambio Datos, Genera Plan de Pagos')</script>")
            codigoJs = "<script language='javascript'>alert('Cambio Datos, Genera Plan de Pagos, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If txtacta.Text.Trim = "" Or txtresolucion.Text.Trim = "" Then
            'Response.Write("<script language='javascript'>alert('Verificar Nº Acta y/o Resolución')</script>")
            codigoJs = "<script language='javascript'>alert('Verificar Nº Acta y/o Resolución, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        IgualaDatos()
        Dim eclimgar As New cClimgar
        Dim lnvalidapref As Integer
        lnvalidapref = eclimgar.ValidaGarantiaPref(Me.txtcCodCli.Text.Trim)

        Me.txtgarantias.Text = Session("nGrav") 'clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        'Validaciones
        If Double.Parse(Me.txtnMonApr.Text) > Double.Parse(Me.txtgarantias.Text) Then
            Me.Label11.Visible = False
            'Response.Write("<script language='javascript'>alert('Monto Aprobado es mayor que garantía')</script>")
            codigoJs = "<script language='javascript'>alert('Monto Aprobado es mayor que garantía, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Me.Label11.Text = "Monto Aprobado es mayor que garantía"
            Exit Sub
        Else
            Me.Label11.Visible = False
            Me.Label11.Text = ""
        End If

        If ViewState("causa") = "SI" Then
            clase.cCodRec = Me.cbxrechazo.SelectedValue.Trim
        Else
            clase.cCodRec = ""
        End If
        Dim lncuota As Decimal = 0
        lncuota = clase.ObtenerCuotaOficial(txtCredito.Text.Trim)
        ViewState("pncuota") = lncuota


        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)
        clase.dFecApr = Session("gdFecSis")
        clase.pcCodUsu = Session("gccodusu")
        clase.gnmoncuo = ViewState("pncuota")
        clase.lsegvid = Chkseguro.Checked
        clase.codigo_nivel_aprobacion = Me.CbxUsuario_Comite1.SelectedValue.Trim
        clase.usuario_aprobacion = Session("gnIdusuario")

        'Dim lcaux As String = ""
        'lcaux = clase.ObtenerCodigoGarantia(Me.txtCredito.Text.Trim)

        clase.Graba_Aprobacion("E")
        'Cesar Torres 19/01/2016 Informacion adicional Conavi
        Dim txtInfoConavi = txtInfoAdicionalVivienda.Text


        clase.grabaInfoConavi(txtCredito.Text.Trim, txtInfoConavi)

        'Actualiza Tipo de Garantia

        Me.Label15.Visible = False
        Me.cbxrechazo.Visible = False

        If ViewState("causa") = "SI" Then
            Resolucion(" ", cbxrechazo.SelectedItem.Text.Trim)
            'Response.Write("<script language='javascript'>alert('Solicitud Rechazada')</script>")
            codigoJs = "<script language='javascript'>alert('Solicitud Rechazada, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        Else
            Resolucion("X", "")
            'Response.Write("<script language='javascript'>alert('Aprobación Grabada')</script>")
            codigoJs = "<script language='javascript'>alert('Aprobación Grabada, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If

        '---------------------------------------

        'ImprimirIA_Firmas()




    End Sub

    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick
        Dim llvalida As Boolean
        Dim lnRetorno As Integer
        Dim mcremcre As New cCremcre
        Dim llvalida_comite As Boolean
        Dim omtabttab As New cTabttab

        If Me.CbxUsuario_Comite1.Items.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Actualiza nivel de Comite aunque no aplique

        lnRetorno = mcremcre.Actualiza_Usuario_Nivel_Comite(Me.CbxUsuario_Comite1.SelectedValue.Trim, _
                                                      Session("gnIdusuario"), Me.txtCredito.Text.Trim)

        If lnRetorno = 0 Then
            Response.Write("<script language='javascript'>alert('Ocurrio un Error, Advertencia SIM.NET')</script>")
            Exit Sub
        End If

        llvalida = clase.Valida_Monto_Comite(Me.CbxUsuario_Comite1.SelectedValue.Trim, Double.Parse(Me.txtnMonApr.Text))

        If Not llvalida Then
            Me.btnGrabar.Disabled = True
            '            Response.Write("<script language='javascript'>alert('Linea Iválida')</script>")
            codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Verifica que todos los niveles de comite esten cubiertos
        llvalida_comite = omtabttab.Valida_Niveles_Aprobacion(Double.Parse(Me.txtnMonApr.Text), Me.txtCredito.Text.Trim)
        If Not llvalida_comite Then
            Response.Write("<script language='javascript'>alert('No se completaron todos los niveles de Firmas, Verifique, Advertencia SIM.NET')</script>")
            Exit Sub
        End If

        IgualaDatos()

        clase.cfreccap = Me.txtcfreccap.Text.Trim
        clase.cfrecint = Me.txtcfrecint.Text.Trim

        Session("gnMonto") = Double.Parse(Me.txtnMonApr.Text)

        clase.dFecsis = Session("gdfecsis")
        clase.pcCodUsu = Session("gccodusu")

        ds = clase.fxCreatePlain(-1, Double.Parse(Me.txtnmoncuo.Text))
        Dim nCanti3 As Integer
        nCanti3 = ds.Tables(0).Rows.Count()
        clase.PlanTeorico(ds.Tables(0), pcCodCta)
        Me.txtdFecVen.Text = clase.dFecVen.ToString
        ViewState("pncuota") = utilNumeros.Redondear(clase.pnmonCuo, 2)
        Session.Item("CodigoCre") = pcCodCta
        Me.txtnMonApr.Enabled = False
        txtacta.Enabled = False
        txtresolucion.Enabled = False
        Me.txtFecDes.Enabled = False
        Me.txtfecpri.Enabled = False
        Me.btnGrabar.Disabled = False
        Me.ImageButton1.Enabled = True
        Me.btnPlan.Disabled = True
        Me.FormaPago(Me.txtcfreccap.Text.Trim, Me.txtcfrecint.Text.Trim)

        Dim lcvalida As String
        lcvalida = Me.validalinea()
        If lcvalida = "0" Then
            Me.btnGrabar.Disabled = True
            '            Response.Write("<script language='javascript'>alert('Linea Iválida')</script>")
            codigoJs = "<script language='javascript'>alert('Linea Iválida, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        Else
            Me.btnGrabar.Disabled = False
            btnPlan.Disabled = True
        End If

        'Iguala Valores del plan de pagos
        HiddenField5.Value = cbxLineas.SelectedValue.Trim
        HiddenField6.Value = Double.Parse(txttasa.Text)
        HiddenField7.Value = Integer.Parse(pnCuoSug.Text)
        HiddenField8.Value = Double.Parse(txtmonSug.Text)
    End Sub

    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
        Me.txtnMonApr.Enabled = True
        Me.txtFecDes.Enabled = True
        Me.txtfecpri.Enabled = True
        SiEsConavi(cbxLineas.SelectedValue.Trim())
        'pnCuoSug.Enabled = True
        txtacta.Enabled = True
        txtresolucion.Enabled = True
        If Me.txtcCodCli.Text.Trim = "" Then
            Me.btnPlan.Disabled = True
        Else
            Me.btnPlan.Disabled = False
            btnGrabar.Disabled = True
        End If


    End Sub

    'Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
    '    txtbandera.Text = "1"
    '    Label15.Visible = True
    '    cbxrechazo.Visible = True
    'End Sub
    Private Sub CargaVariables()
        ViewState.Add("pcnomcli", "") 'nombre de cliente
        ViewState.Add("pcdestino", "") 'destino
        ViewState.Add("pcdeslin", "") 'nombre de linea
        ViewState.Add("pctippre", "") ' tipo de credito
        ViewState.Add("pcfuente", "") 'fuente de fondos
        ViewState.Add("pctasa", "") 'tasa de interes
        ViewState.Add("pcagencia", "") 'agencia
        ViewState.Add("pnmonsug", 0) 'monto sugerido
        ViewState.Add("pctasmor", "") ' tasa moratoria
        ViewState.Add("pcmeses", "") 'meses
        ViewState.Add("pcnomchq", "") ' Cheque a nombre de 
        ViewState.Add("pdfecha", Today()) ' fecha de desembolso
        ViewState.Add("pcgarantia", "") 'Garantias
        ViewState.Add("pccanLet", "") ' cantidad en letras
        ViewState.Add("pncuota", 0) 'cuota sugerida
        ViewState.Add("pctipo", "") 'tipo de garantia
        ViewState.Add("pcforpag", "") ' forma de pago
        ViewState.Add("pcnomana", "") ' nombre de analista
        ViewState.Add("pccontrato", "") 'tipo de contrato
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState.Add("pcComite1", "") 'comite de credito nivel 1
        ViewState.Add("pcComite2", "") 'comite de credito nivel 2
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ' comisiones '
        ViewState.Add("pncom1", 0)
        ViewState.Add("pccom1", "")

        ViewState.Add("pncom2", 0)
        ViewState.Add("pccom2", "")

        ViewState.Add("pncom3", 0)
        ViewState.Add("pccom3", "")

        ViewState.Add("pncom4", 0)
        ViewState.Add("pccom4", "")

        ViewState.Add("pncom5", 0)
        ViewState.Add("pccom5", "")

        ViewState.Add("pncom6", 0)
        ViewState.Add("pccom6", "")
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState.Add("pndeuda", 0) 'valor a refinanciar
        ViewState.Add("pccreref", "") 'credito a ser refinanciado

        ViewState.Add("pcnomchq", "") ' Cheque a nombre de 
        ViewState.Add("pcnomchq2", "") ' Cheque a nombre de 
        ViewState.Add("pcnomchq3", "") ' Cheque a nombre de 
        ViewState.Add("pcnomchq4", "") ' Cheque a nombre de 

        ViewState.Add("pnmonto", 0) ' Monto del Cheque 
        ViewState.Add("pnmonto2", 0) ' Monto del Cheque 
        ViewState.Add("pnmonto3", 0) ' Monto del Cheque 
        ViewState.Add("pnmonto4", 0) ' Monto del Cheque 


    End Sub
    Private Sub ImprimirIA()
        Dim dsgarantias As New DataSet
        Dim mclimgar As New cClimgar
        Try

            dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        Catch ex As Exception

        End Try


        '---------------------------------------------------------------------
        Dim ecredgas As New cCredgas
        Dim dt As New DataTable
        Dim fila As DataRow
        ViewState("pccom1") = ""
        ViewState("pccom2") = ""
        ViewState("pccom3") = ""
        ViewState("pccom4") = ""
        ViewState("pccom5") = ""
        ViewState("pccom6") = ""

        ViewState("pncom1") = 0
        ViewState("pncom2") = 0
        ViewState("pncom3") = 0
        ViewState("pncom4") = 0
        ViewState("pncom5") = 0
        ViewState("pncom6") = 0


        dt = ecredgas.CargaComisiones(Me.txtCredito.Text.Trim, "D")
        For Each fila In dt.Rows
            If fila("ccodigo") = "01" Then
                ViewState("pccom1") = "X"
                ViewState("pncom1") = fila("nmongas")
            ElseIf fila("ccodigo") = "02" Then
                ViewState("pccom6") = "X"
                ViewState("pncom6") = fila("nmongas")
            ElseIf fila("ccodigo") = "03" Then
                ViewState("pccom2") = "X"
                ViewState("pncom2") = fila("nmongas")
            ElseIf fila("ccodigo") = "04" Then
                ViewState("pccom3") = "X"
                ViewState("pncom3") = fila("nmongas")
            ElseIf fila("ccodigo") = "05" Then

            ElseIf fila("ccodigo") = "06" Then

            ElseIf fila("ccodigo") = "08" Then
                ViewState("pccom5") = "X"
                ViewState("pncom5") = fila("nmongas")
            End If

        Next


        '----------------------------------------------------------------------


        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim reportes As String
        reportes = "CrPreIA.pdf"

        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            'crRptIA.Load(Server.MapPath("reportes") + "\CrPreAprobado.rpt", OpenReportMethod.OpenReportByDefault)
            crRptIA.Load(Server.MapPath("reportes") + "\CrIA_Firmas.rpt", OpenReportMethod.OpenReportByDefault)
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

        crRptIA.SetParameterValue("lcnomcli", ViewState("pcnomcli"))
        crRptIA.SetParameterValue("lcdestino", ViewState("pcdestino"))
        crRptIA.SetParameterValue("lcdeslin", ViewState("pcdeslin"))
        crRptIA.SetParameterValue("lctippre", ViewState("pctippre"))
        crRptIA.SetParameterValue("lcfondos", ViewState("pcfuente"))
        crRptIA.SetParameterValue("lctasa", ViewState("pctasa"))
        crRptIA.SetParameterValue("lcagencia", ViewState("pcagencia"))
        crRptIA.SetParameterValue("lnmonsug", ViewState("pnmonsug"))
        crRptIA.SetParameterValue("lctasmor", ViewState("pctasmor"))
        crRptIA.SetParameterValue("lcmeses", lnmeses.ToString)
        crRptIA.SetParameterValue("lcnomchq", ViewState("pcnomchq"))
        crRptIA.SetParameterValue("ldfecha", ViewState("pdfecha"))
        crRptIA.SetParameterValue("lcgarantia", "") 'poner suma de garantias
        crRptIA.SetParameterValue("lccanlet", ViewState("pccanlet"))
        crRptIA.SetParameterValue("lncuosug", ViewState("pncuota"))
        crRptIA.SetParameterValue("lctipo", ViewState("pctipo"))
        crRptIA.SetParameterValue("lcforpag", ViewState("pcforpag"))
        crRptIA.SetParameterValue("lccodcta", pccodcta1)
        crRptIA.SetParameterValue("lccodcli", pccodcli1)
        crRptIA.SetParameterValue("lcnomana", pcnomana1)
        crRptIA.SetParameterValue("lccontrato", ViewState("pccontrato"))
        crRptIA.SetParameterValue("lccomite1", ViewState("pccomite1"))
        crRptIA.SetParameterValue("lccomite2", ViewState("pccomite2"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRptIA.SetParameterValue("lncom1", ViewState("pncom1"))
        crRptIA.SetParameterValue("lccom1", ViewState("pccom1"))

        crRptIA.SetParameterValue("lncom2", ViewState("pncom2"))
        crRptIA.SetParameterValue("lccom2", ViewState("pccom2"))

        crRptIA.SetParameterValue("lncom3", ViewState("pncom3"))
        crRptIA.SetParameterValue("lccom3", ViewState("pccom3"))

        crRptIA.SetParameterValue("lncom4", ViewState("pncom4"))
        crRptIA.SetParameterValue("lccom4", ViewState("pccom4"))

        crRptIA.SetParameterValue("lncom5", ViewState("pncom5"))
        crRptIA.SetParameterValue("lccom5", ViewState("pccom5"))

        crRptIA.SetParameterValue("lncom6", ViewState("pncom6"))
        crRptIA.SetParameterValue("lccom6", ViewState("pccom6"))

        crRptIA.SetParameterValue("lndeuda", ViewState("pndeuda"))
        crRptIA.SetParameterValue("lccreref", ViewState("pccreref"))

        crRptIA.SetParameterValue("lcnomchq", ViewState("pcnomchq"))
        crRptIA.SetParameterValue("lcnomchq2", ViewState("pcnomchq2"))
        crRptIA.SetParameterValue("lcnomchq3", ViewState("pcnomchq3"))
        crRptIA.SetParameterValue("lcnomchq4", ViewState("pcnomchq4"))

        crRptIA.SetParameterValue("lnmonto", ViewState("pnmonto"))
        crRptIA.SetParameterValue("lnmonto2", ViewState("pnmonto2"))
        crRptIA.SetParameterValue("lnmonto3", ViewState("pnmonto3"))
        crRptIA.SetParameterValue("lnmonto4", ViewState("pnmonto4"))

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

    Private Sub ImprimirIA_Firmas()
        Dim dsgarantias As New DataSet
        Dim mclimgar As New cClimgar
        Dim ds_usu As New DataSet
        Dim musuarios As New cusuarios
        'Try

        '    dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        'Catch ex As Exception

        'End Try


        ds_usu = musuarios.Extrae_Datos_Usuario(Session("gnIdusuario"))

        '---------------------------------------------------------------------
        Dim ecredgas As New cCredgas
        Dim dt As New DataTable
        Dim fila As DataRow
        ViewState("pccom1") = ""
        ViewState("pccom2") = ""
        ViewState("pccom3") = ""
        ViewState("pccom4") = ""
        ViewState("pccom5") = ""
        ViewState("pccom6") = ""

        ViewState("pncom1") = 0
        ViewState("pncom2") = 0
        ViewState("pncom3") = 0
        ViewState("pncom4") = 0
        ViewState("pncom5") = 0
        ViewState("pncom6") = 0


        dt = ecredgas.CargaComisiones(Me.txtCredito.Text.Trim, "D")
        For Each fila In dt.Rows
            If fila("ccodigo") = "01" Then
                ViewState("pccom1") = "X"
                ViewState("pncom1") = fila("nmongas")
            ElseIf fila("ccodigo") = "02" Then
                ViewState("pccom6") = "X"
                ViewState("pncom6") = fila("nmongas")
            ElseIf fila("ccodigo") = "03" Then
                ViewState("pccom2") = "X"
                ViewState("pncom2") = fila("nmongas")
            ElseIf fila("ccodigo") = "04" Then
                ViewState("pccom3") = "X"
                ViewState("pncom3") = fila("nmongas")
            ElseIf fila("ccodigo") = "05" Then

            ElseIf fila("ccodigo") = "06" Then

            ElseIf fila("ccodigo") = "08" Then
                ViewState("pccom5") = "X"
                ViewState("pncom5") = fila("nmongas")
            End If

        Next


        '----------------------------------------------------------------------


        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim reportes As String
        reportes = "CrPreIA.pdf"

        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            'crRptIA.Load(Server.MapPath("reportes") + "\CrPreAprobado.rpt", OpenReportMethod.OpenReportByDefault)
            crRptIA.Load(Server.MapPath("reportes") + "\CrIA_Firmas.rpt", OpenReportMethod.OpenReportByDefault)
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

        crRptIA.SetParameterValue("lcnomcli", ViewState("pcnomcli"))
        crRptIA.SetParameterValue("lcdestino", ViewState("pcdestino"))
        crRptIA.SetParameterValue("lcdeslin", ViewState("pcdeslin"))
        crRptIA.SetParameterValue("lctippre", ViewState("pctippre"))
        crRptIA.SetParameterValue("lcfondos", ViewState("pcfuente"))
        crRptIA.SetParameterValue("lctasa", ViewState("pctasa"))
        crRptIA.SetParameterValue("lcagencia", ViewState("pcagencia"))
        crRptIA.SetParameterValue("lnmonsug", ViewState("pnmonsug"))
        crRptIA.SetParameterValue("lctasmor", ViewState("pctasmor"))
        crRptIA.SetParameterValue("lcmeses", lnmeses.ToString)
        crRptIA.SetParameterValue("lcnomchq", ViewState("pcnomchq"))
        crRptIA.SetParameterValue("ldfecha", ViewState("pdfecha"))
        crRptIA.SetParameterValue("lcgarantia", "") 'poner suma de garantias
        crRptIA.SetParameterValue("lccanlet", ViewState("pccanlet"))
        crRptIA.SetParameterValue("lncuosug", ViewState("pncuota"))
        crRptIA.SetParameterValue("lctipo", ViewState("pctipo"))
        crRptIA.SetParameterValue("lcforpag", ViewState("pcforpag"))
        crRptIA.SetParameterValue("lccodcta", pccodcta1)
        crRptIA.SetParameterValue("lccodcli", pccodcli1)
        crRptIA.SetParameterValue("lcnomana", pcnomana1)
        crRptIA.SetParameterValue("lccontrato", ViewState("pccontrato"))
        crRptIA.SetParameterValue("lccomite1", ViewState("pccomite1"))
        crRptIA.SetParameterValue("lccomite2", ViewState("pccomite2"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRptIA.SetParameterValue("lncom1", ViewState("pncom1"))
        crRptIA.SetParameterValue("lccom1", ViewState("pccom1"))

        crRptIA.SetParameterValue("lncom2", ViewState("pncom2"))
        crRptIA.SetParameterValue("lccom2", ViewState("pccom2"))

        crRptIA.SetParameterValue("lncom3", ViewState("pncom3"))
        crRptIA.SetParameterValue("lccom3", ViewState("pccom3"))

        crRptIA.SetParameterValue("lncom4", ViewState("pncom4"))
        crRptIA.SetParameterValue("lccom4", ViewState("pccom4"))

        crRptIA.SetParameterValue("lncom5", ViewState("pncom5"))
        crRptIA.SetParameterValue("lccom5", ViewState("pccom5"))

        crRptIA.SetParameterValue("lncom6", ViewState("pncom6"))
        crRptIA.SetParameterValue("lccom6", ViewState("pccom6"))

        crRptIA.SetParameterValue("lndeuda", ViewState("pndeuda"))
        crRptIA.SetParameterValue("lccreref", ViewState("pccreref"))

        crRptIA.SetParameterValue("lcnomchq", ViewState("pcnomchq"))
        crRptIA.SetParameterValue("lcnomchq2", ViewState("pcnomchq2"))
        crRptIA.SetParameterValue("lcnomchq3", ViewState("pcnomchq3"))
        crRptIA.SetParameterValue("lcnomchq4", ViewState("pcnomchq4"))

        crRptIA.SetParameterValue("lnmonto", ViewState("pnmonto"))
        crRptIA.SetParameterValue("lnmonto2", ViewState("pnmonto2"))
        crRptIA.SetParameterValue("lnmonto3", ViewState("pnmonto3"))
        crRptIA.SetParameterValue("lnmonto4", ViewState("pnmonto4"))
        crRptIA.SetParameterValue("pcComite", Me.CbxUsuario_Comite1.SelectedItem.Text.Trim)


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
                    ViewState("pncom1") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom1") = "X"
                ElseIf lctipgas = "03" And lngasto <> 0 Then
                    ViewState("pncom2") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom2") = "X"
                ElseIf lctipgas = "04" And lngasto <> 0 Then
                    ViewState("pncom3") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom3") = "X"
                ElseIf lctipgas = "PR" And lngasto <> 0 Then
                    ViewState("pncom4") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom4") = "X"
                ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
                    ViewState("pncom5") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom5") = "X"
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
            ViewState("pndeuda") = 0
            ViewState("pccreref") = ""
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
            ViewState("pndeuda") = deuda
            ViewState("pccreref") = pcref
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


        ViewState("pcforpag") = Me.pnCuoSug.Text.ToString & " CUOTAS " & lcforma & " de Q" & clase.pnmonCuo.ToString & " c/u.  "
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

    Private Sub CargaLineasxFondos(ByVal cCodfue As String)
        Dim ds As New DataSet
        Dim clscretlin As New cCretlin

        ds = clscretlin.RecuperarporFuente(cCodfue, Me.txtCredito.Text.Trim.Substring(6, 2))

        If ds.Tables(0).Rows.Count = 0 Then
            Me.cbxLineas.Enabled = False
            Me.btnPlan.Disabled = True
            Return
        Else
            Me.cbxLineas.Enabled = True
            Me.btnPlan.Disabled = False
        End If


        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()


    End Sub


    Protected Sub cbxprograma_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxprograma.SelectedIndexChanged
        CargaLineasxFondos(Me.cbxprograma.SelectedValue)
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label15.Visible = True
        Me.cbxrechazo.Visible = True
        ViewState("causa") = "SI"
    End Sub
    Private Sub Autorizacion()
        Dim lccodcli As String = ""
        Dim lcnomcli As String = ""
        Dim lnmonsug As Double = 0
        Dim lcfreccap As String = ""
        Dim lcopcion1, lcopcion2, lcopcion3, lcopcion4 As String

        Dim i As Integer = 0
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab

        Dim ecrepgar As New cCrepgar
        Dim ds As New DataSet
        ds = ecrepgar.ObtenerDataSetPorGravamen(txtCredito.Text.Trim, txtcCodCli.Text.Trim)

        Dim lnmontas As Double = 0
        Dim lnmongra As Double = 0


        Dim fila As DataRow
        For Each fila In ds.Tables(0).Rows
            lnmontas = lnmontas + fila("nmontas")
            lnmongra = lnmongra + fila("nmongra")
        Next


        Dim ldfecha As Date
        Dim lnmes As Integer
        Dim lcmes As String
        Dim lndia As Integer
        Dim lcdias As String
        Dim lnano As Integer
        Dim lcanio As String


        ldfecha = Session("gdfecsis")
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcanio = lnano.ToString.Trim
        lcmes = clase.MES(lnmes)
        lcdias = lndia.ToString.Trim

        Dim lcdirdom As String = ""
        Dim lccoddom As String = ""
        Dim lcsexo As String = ""
        Dim lcsexo1 As String = ""
        Dim lcsector As String = ""
        Dim lccodact As String = ""
        Dim lcactividad As String
        Dim lnmeses As Integer
        Dim reportes As String = ""

        entidad3.ccodcta = Me.txtCredito.Text.Trim
        i = ecreditos.Obtenercreditos(entidad3)

        lccodcli = Me.txtcCodCli.Text.Trim
        lcnomcli = Me.txtcNomcli.Text.Trim
        lnmonsug = entidad3.nmonapr
        lcfreccap = entidad3.cfreccap.Trim

        lcdirdom = entidad3.cdirdom.Trim
        lccoddom = entidad3.ccoddom
        lcsexo = IIf(entidad3.csexo.Trim = "M", "X", "")
        lcsexo1 = IIf(entidad3.csexo.Trim = "M", " ", "X")
        lnmeses = entidad3.nmeses

        Dim eciiu As New cTabtciu
        Dim lcdestino As String

        lcsector = etabttab.Describe(entidad3.csececo, "021")
        If IsDBNull(entidad3.cdescre) Then
            entidad3.cdescre = ""
        End If
        lcdestino = etabttab.Describe(entidad3.cdescre, "005")
        lccodact = entidad3.ccodact
        lcactividad = eciiu.CIIU(lccodact)


        If lcfreccap = "M" Then 'mensual
            lcopcion1 = "X"
            lcopcion2 = ""
            lcopcion3 = ""
            lcopcion4 = ""
        ElseIf lcfreccap = "I" Then 'bimensual
            lcopcion1 = ""
            lcopcion2 = "X"
            lcopcion3 = ""
            lcopcion4 = ""

        ElseIf lcfreccap = "T" Then 'trimestral
            lcopcion1 = ""
            lcopcion2 = ""
            lcopcion3 = "X"
            lcopcion4 = ""
        Else
            lcopcion1 = ""
            lcopcion2 = ""
            lcopcion3 = ""
            lcopcion4 = "X"
        End If

        Dim lcdepartamento As String = ""
        Dim lcmunicipio As String = ""
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon

        'obtiene municipio y departamento
        If lccoddom.Trim = "" Then
        Else
            etabtzon.ccodzon = lccoddom.Substring(0, 4)
            etabtzon.ctipzon = "2"
            mtabtzon.ObtenerTabtzon(etabtzon)
            lcmunicipio = etabtzon.cdeszon.Trim
            lcmunicipio = lcmunicipio.ToUpper
            'departamento
            etabtzon.ccodzon = lccoddom.Substring(0, 2)
            etabtzon.ctipzon = "1"
            mtabtzon.ObtenerTabtzon(etabtzon)
            lcdepartamento = etabtzon.cdeszon.Trim
            lcdepartamento = lcdepartamento.ToUpper
        End If

        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If i = 0 Then
            Exit Sub


        End If
        reportes = "crAutoriza.doc"
        crRpt1.Load(Server.MapPath("reportes") + "\crAutorizai.rpt", OpenReportMethod.OpenReportByDefault)
        'crRpt1.SetDataSource(dsh.Tables(0))

        crRpt1.Refresh()
        crRpt1.SetParameterValue("nmonsug", lnmonsug)
        crRpt1.SetParameterValue("cmeses", (lnmeses.ToString.Trim & " meses"))
        crRpt1.SetParameterValue("pcopcion1", lcopcion1)
        crRpt1.SetParameterValue("pcopcion2", lcopcion2)
        crRpt1.SetParameterValue("pcopcion3", lcopcion3)
        crRpt1.SetParameterValue("pcopcion4", lcopcion4)
        crRpt1.SetParameterValue("ctasa", ViewState("pctasa"))

        crRpt1.SetParameterValue("nmontas", lnmontas)
        crRpt1.SetParameterValue("nmongra", lnmongra)

        crRpt1.SetParameterValue("cdia", lcdias)
        crRpt1.SetParameterValue("cmes", lcmes)
        crRpt1.SetParameterValue("canio", lcanio)

        crRpt1.SetParameterValue("cgarantia", ViewState("pcgarantia"))
        crRpt1.SetParameterValue("cnomana", Me.txtNomAna.Text.Trim)

        crRpt1.SetParameterValue("cnomcli", lcnomcli)
        crRpt1.SetParameterValue("cdirdom", lcdirdom)
        crRpt1.SetParameterValue("cdepartamento", lcdepartamento)
        crRpt1.SetParameterValue("cmunicipio", lcmunicipio)
        crRpt1.SetParameterValue("csexo", lcsexo)
        crRpt1.SetParameterValue("csexo1", lcsexo1)
        crRpt1.SetParameterValue("cactividad", lcsector.Trim & ", " & lcactividad)
        crRpt1.SetParameterValue("cdestino", lcdestino)
        crRpt1.SetParameterValue("cfondos", ViewState("pcfuente"))

        rptStream1 = CType(crRpt1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True

        ' Establece el tipo de documento
        Response.ContentType = "application/msword"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub

    Private Sub Resolucion(ByVal Resolucion As String, ByVal causa As String)
        Dim epropuesta As New cPROPUESTA
        Dim dspropuestas As New DataSet

        Dim lccanlet As String = ""


        Try

            'dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
            'dspropuestas = epropuesta.ObtieneResolucion(txtCredito.Text.Trim)
            dspropuestas = epropuesta.Extrae_Resolucion_Usuario(Session("gnIdusuario"), txtCredito.Text.Trim)
            If dspropuestas.Tables(0).Rows.Count = 0 Then
            Else
                Dim lnmondes As Decimal = 0
                'lnmondes = Math.Round(dspropuestas.Tables(0).Rows(0)("nmonsug") - (dspropuestas.Tables(0).Rows(0)("ntipgas01") + dspropuestas.Tables(0).Rows(0)("ntipgas02") + _
                '                                                                   dspropuestas.Tables(0).Rows(0)("ntipgas03") + dspropuestas.Tables(0).Rows(0)("ntipgas04") + dspropuestas.Tables(0).Rows(0)("ntipgas05") + _
                '                                                                   dspropuestas.Tables(0).Rows(0)("ntipgas06") + dspropuestas.Tables(0).Rows(0)("notros")), 2)
                lnmondes = Math.Round(dspropuestas.Tables(0).Rows(0)("nmonsug"), 2)
                Dim lnDecimal As Double
                lccanlet = clsConvert.ConversionEnteros(lnmondes)
                lnDecimal = clsConvert.ExtraeDecimales(lnmondes)
                lccanlet = lccanlet & " " & lnDecimal.ToString & "/100" & " PESOS"

            End If

        Catch ex As Exception
            Return
        End Try

        '----------------------------------------------------------------------
        Dim ldevalua As Date
        Dim lccodunimax As String
        Dim eclidifa As New CLIDFAMI
        Dim mclidifa As New cCLIDFAMI
        Dim indica As Integer
        Dim lningfam, lngasfam As Decimal
        Dim lccodfue As String
        Dim lccodcli As String = Me.txtcCodCli.Text.Trim
        Dim mclidbal As New cClidbal
        'Obtenemos la ultima fecha de evaluacion
        ldevalua = mclidifa.ObtenerFechaUlt(txtcCodCli.Text.Trim)

        lccodunimax = mclidifa.ObtenercCoduni2(txtcCodCli.Text.Trim)
        eclidifa.ccodcli = txtcCodCli.Text.Trim
        eclidifa.dEvalua = ldevalua
        eclidifa.cCodUni = lccodunimax

        indica = mclidifa.ObtenerCLIDFAMI(eclidifa)
        If indica = 0 Then
            lningfam = 0
            lngasfam = 0
        Else
            lngasfam = eclidifa.nGasCasa + eclidifa.nGasEduc + eclidifa.nGasRopa + eclidifa.nGasSalu + eclidifa.ngasTran + eclidifa.nGasAlim + eclidifa.nGasAlte + eclidifa.nGasPres  ' es clidfami
            lningfam = eclidifa.nIngCony + eclidifa.nIngFami + eclidifa.nIngReme + eclidifa.nIngSSPC + eclidifa.nIngVari
        End If
        lccodfue = HiddenField9.Value.Trim
        'Verifica si Fuente es independiente y tiene balance
        Dim lndisfam As Decimal = 0
        If Left(lccodfue.Trim, 1) = "I" Then
            Dim dsbalance As New DataSet
            dsbalance = mclidbal.ObtenerDataSetPorIDMultiple(lccodcli, Right(lccodfue.Trim, 2), lningfam, lngasfam, ldevalua)

            Dim i As Integer = dsbalance.Tables(0).Rows.Count - 1
            If dsbalance.Tables(0).Rows.Count > 0 Then
                lndisfam = IIf(IsDBNull(dsbalance.Tables(0).Rows(i)("ndisfam")), 0, dsbalance.Tables(0).Rows(i)("ndisfam"))
            End If
        Else
            lndisfam = lningfam - lngasfam
        End If

        Dim lctipgar As String
        Dim lcdesgar As String
        Dim clsppal As New class1
        Dim etabttab As New cTabttab
        lctipgar = clsppal.ObtenerCodigoGarantia(txtCredito.Text.Trim)
        lcdesgar = etabttab.Describe(lctipgar, "074")

        Dim lncuota As Decimal
        lncuota = clsppal.ObtenerCuotaOficial(txtCredito.Text.Trim)
        '------------------------------------------------------------------------------------

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream
        Dim reportes As String


        Try
            'Cargar Definicion del Reporte
            crRptIA.Load(Server.MapPath("reportes") + "\crResolucion.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRptIA.SetDataSource(dspropuestas.Tables(0))
        crRptIA.Refresh()

        Dim pccodcta1 As String
        Dim pccodcli1 As String
        Dim pcnomana1 As String


        pccodcta1 = Me.txtCredito.Text.Trim 'pcCodCta
        pccodcli1 = Me.txtcCodCli.Text.Trim
        pcnomana1 = Me.txtNomAna.Text.Trim

        crRptIA.SetParameterValue("pccanlet", lccanlet)
        crRptIA.SetParameterValue("pcaprobado", Resolucion)
        crRptIA.SetParameterValue("pcrechazo", causa)
        crRptIA.SetParameterValue("pndisfam", lndisfam)
        crRptIA.SetParameterValue("pcdesgar", lcdesgar.Trim)
        crRptIA.SetParameterValue("pccontrato", cbxContrato.SelectedItem.Text.Trim)
        crRptIA.SetParameterValue("pcoficina", cbxcodofi.SelectedItem.Text.Trim)

        crRptIA.SetParameterValue("pcacta", txtacta.Text.Trim)
        crRptIA.SetParameterValue("pcresolucion", txtresolucion.Text.Trim)
        crRptIA.SetParameterValue("pcComite", Me.CbxUsuario_Comite1.SelectedItem.Text.Trim)

        reportes = "crResolucion.pdf"

        rptStreamIA = CType(crRptIA.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStreamIA.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.End()


    End Sub
    'Cesar Torres 19/01/2016

    Private Function SiEsConavi(ByVal txtCnrolin As String)
        If txtCnrolin = "0002300" Then
            txtInfoAdicionalVivienda.Enabled = True

            Label42.Visible = True

        End If

    End Function



    Private Function ValidaCambios() As Boolean
        If cbxLineas.SelectedValue.Trim <> HiddenField5.Value.Trim Then
            Return False
        End If
        If Double.Parse(txttasa.Text) <> Double.Parse(HiddenField6.Value) Then
            Return False
        End If
        If Integer.Parse(pnCuoSug.Text) <> Integer.Parse(HiddenField7.Value) Then
            Return False
        End If
        If Double.Parse(txtmonSug.Text) <> Double.Parse(HiddenField8.Value) Then
            Return False
        End If
        Return True
    End Function
    Private Sub CargaTasas()
        Dim ecretlin As New cCretlin
        txttasa.Text = ecretlin.ObtenerTasaEstandar(cbxLineas.SelectedValue.Trim)
        HiddenField2.Value = ecretlin.ObtenerTasaMinima(cbxLineas.SelectedValue.Trim)
        HiddenField3.Value = ecretlin.ObtenerTasaMaxima(cbxLineas.SelectedValue.Trim)
        HiddenField4.Value = txttasa.Text
    End Sub
    Private Function validalinea() As String
        Dim lnmontosug As Double
        lnmontosug = Decimal.Parse(Me.txtnMonApr.Text)
        Dim clsppal As New class1
        Dim lvalida As Boolean
        lvalida = clsppal.ValidaLinea(cbxLineas.SelectedValue.Trim, lnmontosug, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))

        If lvalida = True Then
            Return "1"
        Else
            Return "0"
        End If
    End Function

End Class
