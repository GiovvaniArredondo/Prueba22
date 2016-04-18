Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web




Partial Class wucChangePlan
    Inherits ucWBase
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private cls_Sim As New SIM.bl.ClsSolicitud
    Private pcCodCta As String
    Private clasep As New SIM.BL.class1

#Region "Variables"

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
        lnparametro1_R = "cNomOfi , cCodOfi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = " "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxcodofi.DataTextField = "cNomOfi"
        Me.cbxcodofi.DataValueField = "cCodOfi"
        Me.cbxcodofi.DataSource = ds.Tables("Resultado")
        Me.cbxcodofi.DataBind()
        ds.Tables("Resultado").Clear()
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


        Dim dst As New DataSet
        Dim ctabttab As New cTabttab
        dst = ctabttab.ObtenerDataSetPorID("060", "1")
        Me.cbxCapital.DataTextField = "cDescri"
        Me.cbxCapital.DataValueField = "cCodigo"
        Me.cbxCapital.DataSource = dst.Tables(0)
        Me.cbxCapital.DataBind()

        Dim etabttab As New cTabttab
        dst.Clear()
        dst = etabttab.ObtenerFrecuencia("A")

        Me.cbxInteres.DataTextField = "cDescri"
        Me.cbxInteres.DataValueField = "cCodigo"
        Me.cbxInteres.DataSource = dst.Tables(0)
        Me.cbxInteres.DataBind()

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

        '*************tipo de cartera*****************
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab  ='075' and cTipReg = '1' order by cdescri "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'Response.Write("<script language='javascript'>alert('No existen operaciones')</script>")
            Exit Sub
        End If

        Me.ddlcartera.DataTextField = "cDescri"
        Me.ddlcartera.DataValueField = "cCodigo"
        Me.ddlcartera.DataSource = ds.Tables("resultado")
        Me.ddlcartera.DataBind()

        ds.Tables("Resultado").Clear()

        Me.Desactivos()

    End Sub
    Private Sub Desactivos()
        btnGrabar.Disabled = True
        btnImprimir.Disabled = True
        '        btnplan0.Disabled = True
        btnPlan.Disabled = False
    End Sub
    Private Sub Activos()
        btnGrabar.Disabled = False
        btnImprimir.Disabled = True
        'btnplan0.Disabled = True
        btnPlan.Disabled = False
    End Sub
    Private Sub Activos2()
        btnGrabar.Disabled = True
        btnImprimir.Disabled = False
        'btnplan0.Disabled = False
        btnPlan.Disabled = False
    End Sub


    Private Sub CargarDatosCredito()

        Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = txtcCodCta.Text.Trim
        ecreditos.Obtenercreditos(entidad3)
        Me.txtcCodCli.Text = entidad3.ccodcli
        Me.txtcNomcli.Text = entidad3.cnomcli
        Me.txtnMonApr.Text = entidad3.ncapdes
        Me.pnCuoSug.Text = entidad3.ncuoapr
        Me.txtnMonApr.Text = entidad3.ncapdes
        Me.txtFecDes.Text = entidad3.dfecvig
        If IsDBNull(entidad3.ccodfue) Then
            HiddenField1.Value = ""
        Else
            HiddenField1.Value = entidad3.ccodfue
        End If

        Me.txtctipper.Text = entidad3.ctipper
        Me.txtctipcuo.Text = entidad3.ctipcuo
        Me.txtnperdia.Text = entidad3.ndiaapr
        Me.txtndiagra.Text = entidad3.ndiagra
        Me.pnPerGra.Text = entidad3.ndiagra
        Me.pnDiaSug.Text = entidad3.ndiasug

        If IsDBNull(entidad3.cnrolin) Then
        Else
            'Dim i As Integer
            'Dim k As Integer
            'Dim valor As String
            'Dim lnvalida As Integer = 0
            'i = Me.cbxLineas.Items.Count - 1
            'For k = 0 To i
            '    valor = Me.cbxLineas.Items(k).Value.Trim
            '    If valor = entidad3.cnrolin.Trim Then
            '        lnvalida = 1
            '    End If
            'Next
            'If lnvalida = 1 Then
            '    Me.cbxLineas.SelectedValue = entidad3.cnrolin
            'End If
            Dim ecretlin As New cCretlin
            TextBox1.Text = ecretlin.ObtieneLinea(entidad3.cnrolin)
            CargaTasas(entidad3.cnrolin)
            txtTasa.Text = entidad3.ntasint
            'Me.cbxLineas.SelectedValue = entidad3.cnrolin
            Me.cbxprograma.SelectedValue = ecretlin.ObtenerFuentedeFondosCodigo(entidad3.cnrolin)
            CargaLineasxFondos(Me.cbxprograma.SelectedValue)
            'Verifica  si esta activada la linea
            Dim lverifica As Boolean
            lverifica = ecretlin.VericasiestaActivada(entidad3.cnrolin)
            If lverifica = True Then
                cbxLineas.SelectedValue = entidad3.cnrolin
                cbxLineas.Enabled = True
            Else
                cbxLineas.Enabled = False
            End If


        End If



        Dim ecredppg As New cCredppg
        Dim ldfecpri As Date
        ldfecpri = ecredppg.Obtenerprimeracuota(txtcCodCta.Text.Trim)
        Me.txtfecpri.Text = ldfecpri


        Dim lctipcuo As String
        Dim lcTipPer As String

        lctipcuo = entidad3.ctipcuo
        lcTipPer = entidad3.ctipper

        Me.cbxCapital.SelectedValue = IIf(IsDBNull(entidad3.cfreccap), "M", entidad3.cfreccap)
        cargacombointeres()
        Me.cbxInteres.SelectedValue = IIf(IsDBNull(entidad3.cfrecint), "M", entidad3.cfrecint)

        'tipo de cuota
        If entidad3.ctipcuo = "1" Then
            Me.RadioButton1.Checked = True
        ElseIf entidad3.ctipcuo = "3" Then
            Me.RadioButton2.Checked = True
        ElseIf entidad3.ctipcuo = "4" Then
            Me.RadioButton3.Checked = True
        ElseIf entidad3.ctipcuo = "5" Then
            Me.RadioButton5.Checked = True
        ElseIf entidad3.ctipcuo = "6" Then
            Me.RadioButton4.Checked = True
        End If



        clase.nMeses = entidad3.nmeses

        pcCodAct = entidad3.ccodact
        Session.Add("pcCodcli", Me.txtcCodCli.Text)
        '
        Dim entidad4 As New SIM.EL.clidfin
        Dim clsclidfin As New SIM.BL.cClidfin

        Dim mListaclidfin As New listaclidfin
        mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)


    End Sub

#End Region

    Dim lCampos1 As String
    Dim lTipos1 As String
    Dim DataPlain As New DataSet
    Dim DR As DataRow
    Dim DC As DataColumn
    Dim DT As DataTable
    Dim lnTasa As Double
    Dim dsPlain As New DataSet
    Dim lcTipPer, lcFlat As String
    Dim lnTipCuo As Integer
    Dim dsp As New DataSet

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub
    Private Sub IgualaDatos()
        Dim lvalida As Boolean

        pcCodCta = Me.txtCredito.Text
        Dim lnTasa As Double
        Dim ds As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        lnTasa = Decimal.Parse(txtTasa.Text) 'entidadCretlin.ntasint
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        If Me.RadioButton1.Checked = True Then
            lcTipPer = "1"
            lcFlat = ""
        ElseIf Me.RadioButton2.Checked = True Then
            lcTipPer = "3"
            lcFlat = ""
        ElseIf Me.RadioButton3.Checked = True Then
            lcTipPer = "4"
            lcFlat = ""
            Me.pnCuoSug.Text = 1
        ElseIf Me.RadioButton4.Checked = True Then
            lcTipPer = "6"
            lcFlat = ""
        ElseIf Me.RadioButton5.Checked = True Then
            lcTipPer = "5"
            lcFlat = "F"
        End If
        If Me.RadioButton6.Checked = True Then
            lnTipCuo = "1"
        Else
            lnTipCuo = "2"
        End If
        clase.gntasaiva = Session("gnIVA")
        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)
        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtnMonApr.Text 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        clase.cCodFor = lnTipCuo
        clase.nPerDia = Integer.Parse(Me.txtnperdia.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = lcFlat
        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = txtcCodCta.Text.Trim
        'clase.cCodFor = Me.txtcTipPer.Text
        clase.cTipCuo = Me.txtctipcuo.Text
        clase.nPerDia = Me.txtnperdia.Text
        clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm")
        clase.pcCodUsu = Session("gccodusu")
        clase.dFecsis = Session("gdfecsis")

        clase.cfreccap = Me.cbxCapital.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres.SelectedValue.Trim

        clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        Me.txtCredito.Text = codigoCliente.Trim
        pcCodCta = codigoCliente
        txtcCodCta.Text = pcCodCta
        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
        'Me.btnPlan_ServerClick(Me, New System.EventArgs)
        CargarPlan(codigoCliente)
    End Sub
    'Public Sub CargarPlan(ByVal codigoCliente As String)
    '    Me.btnPlan_ServerClick(Me, New EventArgs)
    'End Sub
    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarDatosCredito()
    End Sub
    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick
        cargagrid()
        Activos()
    End Sub
    Public Function GeneraPlan() As DataTable
        DataPlain.Tables.Clear()
        IgualaDatos()
        dsPlain = clase.fxCreatePlain(-1, 0)
        '        Me.dgPlan.DataSource = dsPlain.Tables(0) 'dsp.Tables(0)
        '       Me.dgPlan.DataBind()
        Dim nElem As Integer
        nElem = dsPlain.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If

        Dim fila As DataRow
        Dim lctipope As String = ""
        Dim lnsalint As Decimal = 0
        Dim lntasaiva As Decimal = Session("gnIVA")
        Dim lniva As Decimal = 0

        nElem = 0
        Dim lnsaldo As Decimal = 0
        lnsaldo = Double.Parse(txtnMonApr.Text)


        For Each fila In dsPlain.Tables(0).Rows
            lctipope = dsPlain.Tables(0).Rows(nElem)("cTipOpe")
            If lctipope = "D" Then
                dsPlain.Tables(0).Rows(nElem)("ncapita") = lnsaldo
                'lnsaldo = lnsaldo + dsPlain.Tables(0).Rows(nElem)("nCapita")
            Else
                lnsalint = lnsalint - dsPlain.Tables(0).Rows(nElem)("nintere")
                lniva = Math.Round(dsPlain.Tables(0).Rows(nElem)("nGastos") * lntasaiva / 100, 2)
                dsPlain.Tables(0).Rows(nElem)("nGastos") = (dsPlain.Tables(0).Rows(nElem)("nGastos") + lniva)
                lnsaldo = lnsaldo - dsPlain.Tables(0).Rows(nElem)("nCapita")

            End If
            dsPlain.Tables(0).Rows(nElem)("Saldo") = lnsaldo
            '    dsPlain.Tables(0).Rows(nElem)("salint") = lnsalint
            nElem = nElem + 1
        Next

        clase.PlanTeorico(dsPlain.Tables(0), txtcCodCta.Text.Trim)



        Return clase.Plan_Print(dsPlain)
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Function

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
        Dim ecredtpl As New cCredtpl


        IgualaDatos()
        ' ds = clase.fxCreatePlain(-1)



        ds = ecredtpl.ObtenerDataSetPorID(txtcCodCta.Text.Trim)
        GrabarPlanTeorico(ds)

        For Each fila As DataRow In ds.Tables(0).Rows
            clase.dFecVen = fila("dfecven")
        Next

        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim

        Dim nCanti3 As Integer
        nCanti3 = ds.Tables(0).Rows.Count()

        ' clase.PlanTeoricoppg(ds, txtcCodCta.Text.Trim)
        Me.txtdfecven.Text = clase.dFecVen.ToString
        clase.pcCodUsu = Session("gcCodusu")

        clase.Graba_CambioCremcrePlan()
        'Me.btnImprimir.Disabled = False
        Activos2()
        Response.Write("<script language='javascript'>alert('Cambio de Plan Grabado')</script>")
    End Sub

    Private Sub btnImprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.ServerClick
        ''Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        'Dim crRpt As New ReportDocument
        'Dim rptStream As New System.IO.MemoryStream

        'Try
        '    'Cargar Definicion del Reporte
        '    crRpt.Load(Server.MapPath("reportes") + "\plandep.rpt", OpenReportMethod.OpenReportByDefault)
        'Catch ex As Exception
        '    Return
        'End Try

        'Dim dsPlanPago As New DataSet
        ''   Dim entidadCredtpl As New SIM.EL.credtpl
        ''  Dim eCredtpl As New SIM.BL.cCredtpl
        '' entidadCredtpl.ccodcta = Me.txtCredito.Text 'Me.txtcCodCta.Text.Trim
        ''dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtCredito.Text)

        'Dim entidadCredppg As New SIM.EL.credppg
        'Dim eCredppg As New SIM.BL.cCredppg
        'entidadCredppg.ccodcta = Me.txtCredito.Text.Trim
        'dsPlanPago = eCredppg.ObtenerDataSetPorID2(Me.txtCredito.Text.Trim)


        'Dim lnsaldo As Double = 0
        'Dim fila As DataRow
        'Dim z As Integer = 0
        'For Each fila In dsPlanPago.Tables(0).Rows
        '    If Trim(dsPlanPago.Tables(0).Rows(z)("cTipope")) = "D" Then
        '        lnsaldo = lnsaldo + dsPlanPago.Tables(0).Rows(z)("nCapita")
        '    Else
        '        lnsaldo = lnsaldo - dsPlanPago.Tables(0).Rows(z)("nCapita")
        '    End If
        '    dsPlanPago.Tables(0).Rows(z)("Saldo") = lnsaldo
        '    z += 1
        'Next


        '' Setear los registros recuperados, diciendole el Table respectivo
        'crRpt.SetDataSource(dsPlanPago.Tables(0))
        'crRpt.Refresh()

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        'Response.Clear()
        'Response.Buffer = True

        'Dim reportes As String
        'reportes = "plan.pdf"

        '' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        ''Automaticamente se descarga el archivo
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        ''<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandepagos.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        Dim lcnomcli As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = Me.txtCredito.Text.Trim
        ecreditos.Obtenercreditos(entidad3)
        lcnomcli = entidad3.cnomcli

        '--------------------<<<<<>>>>>----------------
        Dim lcnomana As String = ""
        Dim lccodcta As String = ""
        Dim lcoficina As String = ""

        lcnomana = entidad3.cNomUsu
        lccodcta = entidad3.ccodcta
        lcoficina = entidad3.coficina

        Dim etabtofi As New cTabtofi
        Dim lcnomofi As String
        lcnomofi = etabtofi.NombreAgencia(lcoficina)

        Dim lcnrolin As String = ""
        Dim lcdeslin As String = ""
        lcnrolin = entidad3.cnrolin

        Dim entidadcretlin As New cretlin
        Dim ecretlin As New cCretlin

        entidadcretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadcretlin)

        lcdeslin = entidadcretlin.cdeslin


        '--------------------<<<<<>>>>>-----------------


        Dim dsPlanPago As New DataSet
        Dim entidadCredppg As New SIM.EL.credppg
        Dim eCredppg As New SIM.BL.cCredppg
        entidadCredppg.ccodcta = Me.txtCredito.Text.Trim
        dsPlanPago = eCredppg.ObtenerDataSetPorID2(Me.txtCredito.Text.Trim)

        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Decimal = 0
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim fila As DataRow
        Dim nelem As Integer
        Dim lnSaldo As Double = 0
        Dim lctipope As String
        Dim lnsalint As Double = 0

        Dim ldfecdes As Date = Session("gdfecsis")
        Dim ldfecpri As Date = Session("gdfecsis")
        Dim lcmes As Integer = 0
        Dim lcnota As String = ""
        Dim lnsegdeu As Decimal = 0
        Dim lnmanejo As Decimal = 0

        For Each fila In dsPlanPago.Tables(0).Rows
            lctipope = dsPlanPago.Tables(0).Rows(nelem)("cTipOpe")
            If lctipope = "D" Then
                lnSaldo = lnSaldo + dsPlanPago.Tables(0).Rows(nelem)("nCapita")

            Else

                lnSaldo = lnSaldo - dsPlanPago.Tables(0).Rows(nelem)("nCapita")
                ' lniva = Math.Round(dsPlanPago.Tables(0).Rows(nelem)("nintere") * lntasaiva / 100, 2)
                'dsPlanPago.Tables(0).Rows(nelem)("nintere") = (dsPlanPago.Tables(0).Rows(nelem)("nintere") + lniva)
            End If
            lnsalint = lnsalint + dsPlanPago.Tables(0).Rows(nelem)("nIntere")
            dsPlanPago.Tables(0).Rows(nelem)("saldo") = lnSaldo
            nelem = nelem + 1
        Next




        nelem = 0
        For Each fila In dsPlanPago.Tables(0).Rows
            lctipope = dsPlanPago.Tables(0).Rows(nelem)("cTipOpe")
            If lctipope = "D" Then
                dsPlanPago.Tables(0).Rows(nelem)("ncapita") = 0
                ldfecdes = dsPlanPago.Tables(0).Rows(nelem)("dfecven")
            Else
                lnsalint = lnsalint - dsPlanPago.Tables(0).Rows(nelem)("nintere")
                lniva = Math.Round(dsPlanPago.Tables(0).Rows(nelem)("nGastos") * lntasaiva / 100, 2)
                dsPlanPago.Tables(0).Rows(nelem)("nGastos") = (dsPlanPago.Tables(0).Rows(nelem)("nGastos") + lniva)

                If dsPlanPago.Tables(0).Rows(nelem)("cnrocuo") = "001" Then
                    ldfecpri = dsPlanPago.Tables(0).Rows(nelem)("dfecven")
                    lnsegdeu = dsPlanPago.Tables(0).Rows(nelem)("nsegdeu")
                    lnmanejo = dsPlanPago.Tables(0).Rows(nelem)("ngastos")
                End If

            End If
            'dsPlanPago.Tables(0).Rows(nelem)("salint") = lnsalint
            nelem = nelem + 1
        Next

        Dim lntotal As Decimal = 0
        lntotal = Math.Round(lnsegdeu + lnmanejo, 2)
        lcmes = DateDiff(DateInterval.Month, ldfecdes, ldfecpri)
        If lcmes > 1 Then
            lcnota = "Para el pago de la primera cuota, traer adicional al valor de esta " & lntotal.ToString.Trim & " en concepto de Seguro de Deuda y Manejo de Cuenta"
        End If

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))

        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pcnota", lcnota)
        'crRpt.Refresh()



        crRpt.SetParameterValue("cnomana", ("Asesor: " & lcnomana))
        crRpt.SetParameterValue("ccodcta", ("Crédito Nº: " & lccodcta))
        crRpt.SetParameterValue("cdeslin", ("Linea: " & lcdeslin))
        crRpt.SetParameterValue("cnomofi", ("Oficina: " & lcnomofi))

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        'Response.Clear()
        'Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "plan.pdf"
        'reportes &= ".pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

    End Sub

    Protected Sub cbxCapital_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCapital.SelectedIndexChanged
        cargacombointeres()
    End Sub
    Private Sub cargacombointeres()
        Dim lcfrecuencia As String
        lcfrecuencia = Me.cbxCapital.SelectedValue.Trim
        Dim ds As New DataSet
        Dim etabttab As New cTabttab
        ds = etabttab.ObtenerFrecuencia(lcfrecuencia)
        Me.cbxInteres.DataTextField = "cDescri"
        Me.cbxInteres.DataValueField = "cCodigo"
        Me.cbxInteres.DataSource = ds.Tables(0)
        Me.cbxInteres.DataBind()

    End Sub

    Protected Sub cbxprograma_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxprograma.SelectedIndexChanged
        CargaLineasxFondos(Me.cbxprograma.SelectedValue)
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
    'Private Sub dgplan_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgPlan.PageIndexChanged

    '    If Me.IsPostBack Then

    '        Me.dgPlan.CurrentPageIndex = 0

    '        Me.dgPlan.CurrentPageIndex = e.NewPageIndex

    '        Me.Cargagrid()
    '        'este sería el procedimiento que se encarga de llenar tu datagrid.

    '    End If



    'End Sub

    Private Sub cargagrid()
        'Valida Frecuencia de pagos
        Dim lvalida As Boolean
        Dim ecredppg As New cCredppg
        lvalida = ecredppg.ValidaFrecuencia(Me.cbxCapital.SelectedValue.Trim, Me.cbxInteres.SelectedValue.Trim, Integer.Parse(Me.pnCuoSug.Text))
        If lvalida = False Then
            Response.Write("<script language='javascript'>alert('Verifique Condiciones de Forma de Pago')</script>")
            Return
        End If

        Me.datagrid1.DataSource = GeneraPlan() 'DataPlain.Tables("PlanTeo") 'dsp.Tables(0)
        Me.datagrid1.DataBind()


        Me.btnImprimir.Disabled = True

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim ds As New DataSet
        'Dim clscretlin As New cCretlin

        'ds = clscretlin.RecuperarporCartera(ddlcartera.SelectedValue.Trim, "01", HiddenField1.Value.Trim)

        'Me.cbxLineas.DataTextField = "cdeslin"
        'Me.cbxLineas.DataValueField = "cNrolin"
        'Me.cbxLineas.DataSource = ds
        'Me.cbxLineas.DataBind()
        Dim ds As New DataSet
        Dim clscretlin As New cCretlin

        ds = clscretlin.RecuperarporCartera(ddlcartera.SelectedValue.Trim, "01", cbxprograma.SelectedValue.Trim) ' Me.HiddenField1.Value.Trim

        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()

        CargaTasas(cbxLineas.SelectedValue.Trim)

    End Sub

    Public Sub CargarPlan(ByVal CodigoCredito As String)
        Dim dsp As New DataSet

        Dim nElem As Integer
        Dim entidadCredppg As New SIM.EL.credppg
        Dim eCredppg As New SIM.BL.cCredppg
        entidadCredppg.ccodcta = Me.txtCredito.Text
        dsp = eCredppg.ObtenerDataSetPorID2(Me.txtCredito.Text.Trim)
        nElem = dsp.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        '**************
        Dim lCampos1 As String
        Dim lTipos1 As String
        '        Dim DataPlain As New DataSet
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable
        DataPlain.Clear()
        lCampos1 = "ncapita,nintere,nsalcap,nMcuota,cnrocuo,ctipope,dfecpro,Fecha, Operacion, N_Cuota, Capital, Interes, Saldo, Gastos, nSegDeu,"
        lTipos1 = "D,D,D,D,S,S,F,S,S,S,D,D,D,D,D,"
        DT = clase.creadatasetdesconec(lCampos1, lTipos1, "PlanTeo")
        nElem = 0
        Dim i As Integer
        Dim fila As DataRow
        Dim dFecCon As Date
        DR = DT.NewRow
        Dim lnSaldo As Double = 0
        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Double = 0
        Dim lncapdes As Double = 0
        For Each fila In dsp.Tables(0).Rows
            DR = DT.NewRow
            dFecCon = dsp.Tables(0).Rows(nElem)("dFecVen")
            DR("Fecha") = dFecCon.ToString.Substring(0, 10)
            DR("dfecpro") = dsp.Tables(0).Rows(nElem)("dFecVen")
            DR("Operacion") = dsp.Tables(0).Rows(nElem)("cTipOpe")
            DR("ctipope") = dsp.Tables(0).Rows(nElem)("cTipOpe")
            DR("N_Cuota") = dsp.Tables(0).Rows(nElem)("cNroCuo")
            DR("cnrocuo") = dsp.Tables(0).Rows(nElem)("cNroCuo")
            DR("Capital") = dsp.Tables(0).Rows(nElem)("nCapita")
            DR("ncapita") = fila("ncapita")

            DR("Interes") = Math.Round((dsp.Tables(0).Rows(nElem)("nIntere")), 2)
            DR("nintere") = Math.Round(fila("nintere"), 2)
            DR("nSegDeu") = IIf(IsDBNull(fila("nSegDeu")), 0, fila("nsegdeu"))

            DR("Gastos") = (dsp.Tables(0).Rows(nElem)("nGastos"))
            If dsp.Tables(0).Rows(nElem)("cTipOpe") = "D" Then
                lnSaldo = lnSaldo + dsp.Tables(0).Rows(nElem)("nCapita")
                lncapdes = dsp.Tables(0).Rows(nElem)("nCapita")
                dsp.Tables(0).Rows(nElem)("nCapita") = 0
                DR("nMcuota") = 0
            Else
                lnSaldo = lnSaldo - dsp.Tables(0).Rows(nElem)("nCapita")
                lniva = 0 'Math.Round(dsp.Tables(0).Rows(nElem)("nGastos") * lntasaiva / 100, 2)
                DR("nMcuota") = DR("capital") + DR("interes") + DR("nsegdeu") + DR("gastos")
            End If

            DR("Saldo") = utilNumeros.Redondear(lnSaldo, 2)
            DR("nsalcap") = utilNumeros.Redondear(lnSaldo, 2)
            'DataPlain.Tables(0).Rows.Add(DR)
            txtvencimiento.Text = dFecCon.ToString.Substring(0, 10)
            DT.Rows.Add(DR)

            nElem = nElem + 1

        Next
        DataPlain.Tables.Add(DT)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        'Me.dgplan.DataSource = DataPlain.Tables(0) 'dsp.Tables(0)
        'Me.dgplan.DataBind()

        datagrid1.DataSource = DataPlain.Tables(0) 'GeneraPlan()
        datagrid1.DataBind()
    End Sub
    Private Sub CargaTasas(ByVal cnrolin As String)
        Dim ecretlin As New cCretlin
        txttasa.Text = ecretlin.ObtenerTasaEstandar(cnrolin)
        HiddenField2.Value = ecretlin.ObtenerTasaMinima(cnrolin)
        HiddenField3.Value = ecretlin.ObtenerTasaMaxima(cnrolin)
        HiddenField4.Value = txttasa.Text
    End Sub

   
    Protected Sub cbxLineas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxLineas.SelectedIndexChanged
        CargaTasas(cbxLineas.SelectedValue.Trim)
        btnGrabar.Disabled = True
        btnPlan.Disabled = False
    End Sub

   
    Protected Sub datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagrid1.SelectedIndexChanged
        Dim ctipope As String = datagrid1.SelectedRow.Cells(2).Text.ToString
        Dim cnrocuo As String = datagrid1.SelectedRow.Cells(3).Text.ToString
        If ctipope.Trim = "D" Then
            Response.Write("<script language='javascript'>alert('Desembolso No se puede Modificar')</script>")
            Exit Sub
        End If
        txtfecha.Text = Date.Parse(datagrid1.SelectedRow.Cells(1).Text)
        txtmonto.Text = Math.Round(Double.Parse(datagrid1.SelectedRow.Cells(4).Text), 2)
        txtnrocuo.Text = cnrocuo.Trim
        HiddenField3.Value = 2
    End Sub

    Protected Sub btnaplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        'Session("CodigoCre") = ""
        Dim lverifica As Boolean

        'Verifica monto
        If Me.txtmonto.Text.Trim = "" Or txtmonto.Text = Nothing Then
            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            Exit Sub
        End If

        lverifica = VerificaFecha(Date.Parse(txtfecha.Text))
        If lverifica = True And HiddenField3.Value <> 2 Then
            Response.Write("<script language='javascript'>alert('Fecha Repetida y/o Errada')</script>")
            Exit Sub
        End If

        HiddenField1.Value = 0
        HiddenField2.Value = txtnrocuo.Text.Trim
        Aplicar()
        Genera()

        Session("cflag") = "X"
        'Al modificar el plan de pagos sera Irregular
        'Session()
    End Sub
    Private Sub Aplicar()
        'Barrer el grid 
        Dim i As Integer
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            If datagrid1.Rows(xy).Cells(2).Text.Trim <> "D" Then
                If datagrid1.Rows(xy).Cells(3).Text.Trim = txtnrocuo.Text.Trim Then 'Le pone marca al modificado
                    If HiddenField1.Value = 2 Then
                    Else
                        datagrid1.Rows(xy).Cells(2).Text = "M"
                    End If
                    datagrid1.Rows(xy).Cells(4).Text = Double.Parse(Me.txtmonto.Text)
                    datagrid1.Rows(xy).Cells(1).Text = Date.Parse(txtfecha.Text)
                    i = datagrid1.SelectedIndex
                End If
            End If
        Next


    End Sub
    Private Sub Genera()
        'Carga plan 
        Dim clase As New class1
        Dim dt As New DataTable 'este plan quedara intacto

        'dt = CargaPlanOriginal(HiddenField2.Value.Trim)
        dt = CargaPlanOriginalTemp(HiddenField2.Value.Trim)


        Dim dtmod As New DataTable
        dtmod = dt.Clone()

        'Agregamos las cuotas a modificar
        'Barrer el grid 
        Dim lnnrocuo As Integer
        If txtnrocuo.Text.Trim = "" Then
            lnnrocuo = 0
        Else
            lnnrocuo = Integer.Parse(txtnrocuo.Text) - 1
        End If

        Dim dr As DataRow
        Dim ldfecDes As Date = Session("gdfecsis")
        Dim ldfecUlt As Date = Session("gdfecsis")
        Dim i As Integer = 1
        Dim lnmonDes As Double = 0
        Dim nflag As Integer = 0
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            If HiddenField1.Value = 1 Then 'Adelante
                If Integer.Parse(datagrid1.Rows(xy).Cells(3).Text.Trim) >= lnnrocuo Then 'Le pone marca al modificado
                    If Integer.Parse(datagrid1.Rows(xy).Cells(3).Text.Trim) = lnnrocuo Then
                        dr = dtmod.NewRow
                        dr("dfecpro") = datagrid1.Rows(xy).Cells(1).Text
                        dr("ctipope") = "D"
                        ldfecDes = datagrid1.Rows(xy).Cells(1).Text
                        dr("cNroCuo") = datagrid1.Rows(xy).Cells(3).Text.Trim
                        dr("ncapita") = datagrid1.Rows(xy).Cells(5).Text
                        dr("nintere") = datagrid1.Rows(xy).Cells(6).Text
                        dr("nSegDeu") = datagrid1.Rows(xy).Cells(8).Text
                        dr("Gastos") = datagrid1.Rows(xy).Cells(7).Text
                        dr("nSalCap") = datagrid1.Rows(xy).Cells(9).Text
                        dr("nMCuota") = datagrid1.Rows(xy).Cells(4).Text
                        dr("nflag") = "1"
                        lnmonDes = datagrid1.Rows(xy).Cells(9).Text
                        dtmod.Rows.Add(dr)
                    Else
                        dr = dtmod.NewRow
                        dr("dfecpro") = datagrid1.Rows(xy).Cells(1).Text
                        dr("ctipope") = datagrid1.Rows(xy).Cells(2).Text.Trim
                        dr("cNroCuo") = datagrid1.Rows(xy).Cells(3).Text.Trim
                        dr("ncapita") = 0
                        dr("nintere") = 0
                        dr("nSegDeu") = datagrid1.Rows(xy).Cells(8).Text
                        dr("Gastos") = datagrid1.Rows(xy).Cells(7).Text
                        dr("nSalCap") = datagrid1.Rows(xy).Cells(9).Text
                        dr("nMCuota") = datagrid1.Rows(xy).Cells(4).Text
                        dr("nflag") = "1"
                        If dr("ctipope") = "D" Then
                            lnmonDes = datagrid1.Rows(xy).Cells(9).Text
                        End If

                        dtmod.Rows.Add(dr)
                        i += 1
                    End If
                End If
            Else 'Aplica 
                If HiddenField1.Value = 0 Then 'aplica
                    dr = dtmod.NewRow
                    dr("dfecpro") = datagrid1.Rows(xy).Cells(1).Text
                    dr("ctipope") = datagrid1.Rows(xy).Cells(2).Text.Trim
                    dr("cNroCuo") = datagrid1.Rows(xy).Cells(3).Text.Trim
                    dr("ncapita") = 0
                    dr("nintere") = 0
                    dr("nSegDeu") = datagrid1.Rows(xy).Cells(8).Text
                    dr("Gastos") = datagrid1.Rows(xy).Cells(7).Text
                    dr("nSalCap") = datagrid1.Rows(xy).Cells(9).Text
                    dr("nMCuota") = datagrid1.Rows(xy).Cells(4).Text
                    dr("nflag") = "1"
                    If dr("ctipope") = "D" Then
                        lnmonDes = datagrid1.Rows(xy).Cells(9).Text
                    End If
                    dtmod.Rows.Add(dr)
                    i += 1
                ElseIf HiddenField1.Value = 2 Then 'elimina cuota
                    If Integer.Parse(datagrid1.Rows(xy).Cells(3).Text.Trim) = Integer.Parse(txtnrocuo.Text) And datagrid1.Rows(xy).Cells(2).Text.Trim <> "D" Then
                    Else
                        dr = dtmod.NewRow
                        dr("dfecpro") = datagrid1.Rows(xy).Cells(1).Text
                        dr("ctipope") = datagrid1.Rows(xy).Cells(2).Text.Trim
                        dr("cNroCuo") = datagrid1.Rows(xy).Cells(3).Text.Trim
                        dr("ncapita") = 0
                        dr("nintere") = 0
                        dr("nSegDeu") = datagrid1.Rows(xy).Cells(8).Text
                        dr("Gastos") = datagrid1.Rows(xy).Cells(7).Text
                        dr("nSalCap") = datagrid1.Rows(xy).Cells(9).Text
                        dr("nMCuota") = datagrid1.Rows(xy).Cells(4).Text
                        dr("nflag") = "1"
                        If dr("ctipope") = "D" Then
                            lnmonDes = datagrid1.Rows(xy).Cells(9).Text
                        End If
                        dtmod.Rows.Add(dr)
                        i += 1
                    End If

                End If

            End If
        Next
        'Agregara linea si es nuevo
        If HiddenField3.Value = 1 Then
            dr = dtmod.NewRow
            dr("dfecpro") = Date.Parse(txtfecha.Text)
            dr("ctipope") = "M"
            dr("cNroCuo") = clase.fxStrZero(i, 3)
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nSegDeu") = 0
            dr("Gastos") = 0
            dr("nSalCap") = 0
            dr("nMCuota") = Double.Parse(txtmonto.Text)
            dr("nflag") = "1"
            dtmod.Rows.Add(dr)
            i += 1
        End If

        Dim rows() As DataRow = Nothing
        Dim sortOrder As String = "dfecpro ASC"
        Dim expression As String = ""
        Dim dtNew As DataTable = dtmod.Clone()

        rows = dtmod.Select(expression, sortOrder)
        'Insertara el datarow filtrado en un el dataset
        i = 0
        For Each fila As DataRow In rows
            dtNew.ImportRow(fila)
            ldfecUlt = fila("dfecpro")
            If fila("ctipope") <> "D" Then
                i += 1
            End If

        Next

        Dim ecredppg As New cCredppg

        Dim ds As New DataSet
        'ds.Tables.Add(dtmod)
        ds.Tables.Add(dtNew)

        Dim ecremcre As New cCremcre
        Dim entidadcremcre As New cremcre
        entidadcremcre.ccodcta = txtcCodCta.Text.Trim
        ecremcre.ObtenerCremcre(entidadcremcre)

        Dim lntasaint As Double = entidadcremcre.ntasint

        clase.nPerDia = entidadcremcre.ndiasug
        ' clase.cCodFor = entidadcremcre.ctipcuo
        ' clase.cFlat = entidadcremcre.cflat

        'deberia tomar los parametros actuales
        If Me.RadioButton1.Checked = True Then
            lcTipPer = "1"
            lcFlat = ""
        ElseIf Me.RadioButton2.Checked = True Then
            lcTipPer = "3"
            lcFlat = ""
        ElseIf Me.RadioButton3.Checked = True Then
            lcTipPer = "4"
            lcFlat = ""
            Me.pnCuoSug.Text = 1
        ElseIf Me.RadioButton4.Checked = True Then
            lcTipPer = "6"
            lcFlat = ""
        ElseIf Me.RadioButton5.Checked = True Then
            lcTipPer = "5"
            lcFlat = "F"
        End If

        If Me.RadioButton6.Checked = True Then
            lnTipCuo = "1"
        Else
            lnTipCuo = "2"
        End If
        clase.cCodFor = lnTipCuo
        clase.cTipCuo = lcTipPer
        clase.cFlat = lcFlat

        clase.cfrecint = cbxInteres.SelectedValue.Trim
        clase.cfreccap = cbxCapital.SelectedValue.Trim
        clase.nNroCuo = i
        clase.nNroCuo0 = 0 'Integer.Parse(Me.pnCuoSug0.Text)

        '---------------------------------------------------------------------------------------------------------
        'clase.omCalPago(ldfecDes, ldfecUlt, i, entidadcremcre.ntasint, Session("gnperbas"), lnmonDes, "N", _
        '       entidadcremcre.ctipper, entidadcremcre.ctipcuo, entidadcremcre.cflat, ds)

        clase.omCalPago(ldfecDes, ldfecUlt, i, entidadcremcre.ntasint, Session("gnperbas"), lnmonDes, "N", _
               lnTipCuo, lcTipPer, lcFlat, ds, 0)


        For Each fila In ds.Tables(0).Rows
            If fila("ctipope") = "D" Then
            Else
                dr = dt.NewRow
                dr("dfecpro") = fila("dfecpro")
                dr("ctipope") = fila("ctipope")
                dr("cNroCuo") = fila("cnrocuo")
                dr("ncapita") = Math.Round(fila("ncapita"), 2)
                dr("nintere") = Math.Round(fila("nintere"), 2)
                dr("nSegDeu") = Math.Round(fila("nsegdeu"), 2)
                dr("nGastos") = Math.Round(fila("Gastos"), 2)
                dr("Gastos") = Math.Round(fila("Gastos"), 2)
                dr("nSalCap") = Math.Round(fila("nsalcap"), 2)
                dr("nMCuota") = Math.Round(fila("nMcuota"), 2)
                dr("nflag") = "1"
                dt.Rows.Add(dr)
            End If

        Next


        Dim lnsalcap As Double = 0
        i = 1
        Dim lcnrocuo As String
        For Each fila In dt.Rows
            If fila("ctipope") = "D" Then
                lnsalcap = fila("nSalCap")
                fila("nTasaIn") = lntasaint
                fila("nMCuota") = Math.Round(fila("nsalcap"), 2)
            Else
                lnsalcap = lnsalcap + fila("ncapita")
                lcnrocuo = clase.fxStrZero(i, 3)
                fila("cNroCuo") = lcnrocuo
                fila("nTasaIn") = lntasaint
                fila("Gastos") = fila("Gastos")
                fila("nGastos") = fila("Gastos")
                i += 1
            End If

        Next

        Me.datagrid1.DataSource = dt
        Me.datagrid1.DataBind()


        clase.PlanTeorico(dt, txtcCodCta.Text.Trim)

        HiddenField3.Value = 0

    End Sub
    Private Function VerificaFecha(ByVal dfecha As Date) As Boolean
        Dim xy As Integer
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            If datagrid1.Rows(xy).Cells(2).Text.Trim = "D" Then
                If dfecha <= Date.Parse(datagrid1.Rows(xy).Cells(1).Text) Then
                    Return True
                End If
            End If
            If Date.Parse(datagrid1.Rows(xy).Cells(1).Text) >= dfecha And Date.Parse(datagrid1.Rows(xy).Cells(1).Text) <= dfecha Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function CargaPlanOriginalTemp(ByVal cnrocuo As String) As DataTable
        Dim clase As New class1
        Dim dsp As New DataTable

        Dim nElem As Integer
        dsp = GeneraPlanGrid() 'GeneraPlan()

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        '**************
        Dim lCampos1 As String
        Dim lTipos1 As String
        '        Dim DataPlain As New 
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As New DataTable
        Dim DataPlain As New DataSet

        DataPlain.Clear()
        lCampos1 = "dfecpro, ctipope, cNroCuo, ncapita, nintere, nSalCap, Gastos, nSegDeu,nMCuota,nDifdia,nTasaef,nTasain,nFlag,nTasaIn,nGastos,"
        lTipos1 = "F,S,S,D,D,D,D,D,D,D,D,D,S,D,D,"
        DT = clasep.creadatasetdesconec(lCampos1, lTipos1, "PlanTeo")
        nElem = 0
        Dim i As Integer
        Dim fila As DataRow
        Dim dFecCon As Date
        DR = DT.NewRow
        Dim lnSaldo As Double = 0
        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Double = 0
        Dim lncapdes As Double = 0
        Dim nflag As Integer = 0
        Dim lverifica As Boolean
        Dim lnmontoM As Decimal = 0
        For Each fila In dsp.Rows

            If HiddenField1.Value = 1 Then
                If fila("ctipope") = "D" Then
                    DR = DT.NewRow
                    dFecCon = fila("dFecVen")
                    lnSaldo = fila("nCapita")
                    DR("dfecpro") = dFecCon.ToString.Substring(0, 10)
                    DR("ctipope") = fila("cTipOpe")
                    DR("cNroCuo") = fila("cNroCuo")
                    DR("ncapita") = fila("nCapita")
                    DR("nintere") = Math.Round((fila("nIntere")), 2)
                    DR("nSegDeu") = fila("nSegDeu")
                    lncapdes = fila("nCapita")
                    fila("nCapita") = 0
                    DR("Gastos") = (fila("Gastos") + lniva)
                    DR("nSalCap") = utilNumeros.Redondear(lnSaldo, 2)
                    DR("nMCuota") = 0 'Math.Round(DR("ncapita") + DR("nintere") + DR("nSegDeu") + DR("Gastos"), 2)
                    DT.Rows.Add(DR)
                Else
                    If cnrocuo.Trim > fila("cnrocuo") Then
                        ''-----------------------------------------------------------------------Verifica si es cuota modificada para no afectarla
                        'lverifica = VerificaM(fila("cnrocuo"))
                        'If lverifica = True Then
                        '    lnmontoM = DevuelveMonto(fila("cnrocuo"))
                        'End If
                        ''-----------------------------------------------------------------------

                        DR = DT.NewRow
                        dFecCon = fila("dFecVen")
                        DR("dfecpro") = dFecCon.ToString.Substring(0, 10)
                        DR("ctipope") = fila("cTipOpe")
                        DR("cNroCuo") = fila("cNroCuo")
                        DR("ncapita") = fila("nCapita")
                        DR("nintere") = Math.Round((fila("nIntere")), 2)
                        DR("nSegDeu") = fila("nSegDeu")
                        If fila("cTipOpe") = "D" Then
                            lnSaldo = lnSaldo + fila("nCapita")
                            lncapdes = fila("nCapita")
                            fila("nCapita") = 0
                        Else
                            lnSaldo = lnSaldo - fila("nCapita")
                            lniva = 0 'Math.Round(fila("Gastos") * lntasaiva / 100, 2)
                        End If
                        DR("Gastos") = (fila("Gastos") + lniva)
                        DR("nSalCap") = utilNumeros.Redondear(lnSaldo, 2)

                        'If lverifica Then
                        '    DR("nMCuota") = lnmontoM
                        'Else
                        DR("nMCuota") = Math.Round(DR("ncapita") + DR("nintere") + DR("nSegDeu") + DR("Gastos"), 2)
                        'End If


                        DT.Rows.Add(DR)
                    End If

                End If

            Else
                If fila("ctipope") = "D" Then
                    DR = DT.NewRow
                    dFecCon = fila("dFecVen")
                    lnSaldo = fila("nCapita")
                    DR("dfecpro") = dFecCon.ToString.Substring(0, 10)
                    DR("ctipope") = fila("cTipOpe")
                    DR("cNroCuo") = fila("cNroCuo")
                    DR("ncapita") = fila("nCapita")
                    DR("nintere") = Math.Round((fila("nIntere")), 2)
                    DR("nSegDeu") = fila("nSegDeu")
                    'lnSaldo = lnSaldo + fila("nCapita")
                    lncapdes = fila("nCapita")
                    fila("nCapita") = 0
                    DR("Gastos") = (fila("Gastos") + lniva)
                    DR("nSalCap") = utilNumeros.Redondear(lnSaldo, 2)
                    DR("nMCuota") = Math.Round(DR("ncapita") + DR("nintere") + DR("nSegDeu") + DR("Gastos"), 2)
                    DT.Rows.Add(DR)
                End If
            End If

            nElem = nElem + 1
        Next
        DataPlain.Tables.Add(DT)
        Return DataPlain.Tables(0)
    End Function
    Private Function GeneraPlanGrid() As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DT As New DataTable
        Dim DataPlain As New DataSet

        DataPlain.Clear()
        lCampos1 = "dfecven, ctipope, cNroCuo, ncapita, nintere, nSalCap, Gastos, nSegDeu,nMCuota,nDifdia,nTasaef,nTasain,nFlag,nTasaIn,nGastos,"
        lTipos1 = "F,S,S,D,D,D,D,D,D,D,D,D,S,D,D,"
        DT = clasep.creadatasetdesconec(lCampos1, lTipos1, "PlanTeorico")

        For xy = 0 To Me.datagrid1.Rows.Count - 1
            DR = DT.NewRow
            DR("dfecven") = datagrid1.Rows(xy).Cells(1).Text
            DR("ctipope") = datagrid1.Rows(xy).Cells(2).Text
            DR("cNroCuo") = datagrid1.Rows(xy).Cells(3).Text.Trim
            DR("ncapita") = datagrid1.Rows(xy).Cells(5).Text
            DR("nintere") = datagrid1.Rows(xy).Cells(6).Text
            DR("nSegDeu") = datagrid1.Rows(xy).Cells(8).Text
            DR("Gastos") = datagrid1.Rows(xy).Cells(7).Text
            DR("nSalCap") = datagrid1.Rows(xy).Cells(9).Text
            DR("nMCuota") = datagrid1.Rows(xy).Cells(4).Text 'cambio tenia 9
            DR("nflag") = "1"
            DT.Rows.Add(DR)
        Next

        Return DT

    End Function

    Protected Sub btnadelante_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadelante.Click
        'Session("CodigoCre") = ""

        'Verifica monto
        If Me.txtmonto.Text.Trim = "" Or txtmonto.Text = Nothing Then
            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            Exit Sub
        End If

        If HiddenField3.Value = 1 Then
            Response.Write("<script language='javascript'>alert('Presione Boton Aplicar')</script>")
            Exit Sub
        End If
        'Verifica monto
        If Me.txtmonto.Text.Trim = "" Or txtmonto.Text = Nothing Then
            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            Exit Sub
        End If

        HiddenField1.Value = 1
        HiddenField2.Value = txtnrocuo.Text.Trim
        Aplicar()
        Genera()
    End Sub

    Protected Sub btneliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        'Session("CodigoCre") = ""
        HiddenField1.Value = 2
        HiddenField2.Value = txtnrocuo.Text.Trim
        Aplicar()
        Genera()
    End Sub

    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        'Session("CodigoCre") = ""
        txtnrocuo.Text = ""
        txtfecha.Text = Session("gdfecsis")
        txtmonto.Text = 0
        HiddenField3.Value = 1
    End Sub
    Private Sub GrabarPlanTeorico(ByVal ds As DataSet)

        Dim ecredppg As New cCredppg
        Dim entidadCredppg As New credppg
        Dim ncanti As Integer
        ncanti = ds.Tables(0).Rows.Count()

        ecredppg.EliminarCredppg(txtcCodCta.Text)

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If


        Dim Fila As DataRow
        ncanti = 0

        For Each Fila In ds.Tables(0).Rows
            entidadCredppg.ccodcta = Fila("ccodcta")
            entidadCredppg.dfecven = Fila("dfecven")
            entidadCredppg.ctipope = Fila("ctipope")
            entidadCredppg.cnrocuo = Fila("cnrocuo")
            entidadCredppg.ncapita = Fila("ncapita")
            entidadCredppg.nintere = Fila("nIntere")
            entidadCredppg.nsegdeu = Fila("nsegdeu")
            entidadCredppg.ngastos = Fila("ngastos")
            entidadCredppg.cflag = " "
            If ncanti = 0 Then
                entidadCredppg.cestado = "E"
            Else
                entidadCredppg.cestado = "N"
            End If
            entidadCredppg.dfecpag = Session("gdfecsis") 'Hay que suplantarla por una fecha vacia

            entidadCredppg.dfecmod = Session("gdfecsis")
            entidadCredppg.ccodusu = Session("gcCodUsu")
            entidadCredppg.ncappag = 0
            entidadCredppg.nintpag = 0
            entidadCredppg.nmorpag = 0
            entidadCredppg.notrpag = 0

            ecredppg.Agregar(entidadCredppg)
            ncanti = ncanti + 1
        Next

    End Sub
End Class


