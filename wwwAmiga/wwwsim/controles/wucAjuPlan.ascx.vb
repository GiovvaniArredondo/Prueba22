Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web




Partial Class wucAjuPlan
    Inherits ucWBase
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private cls_Sim As New SIM.bl.ClsSolicitud
    Private pcCodCta As String

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
    Private Sub Deshabilitar()
        Me.cbxprograma.Enabled = False
        Me.cbxLineas.Enabled = False
        txtnMonApr.Enabled = False
        txtFecDes.Enabled = False
        txtfecpri.Enabled = False
        txtvencimiento.Enabled = False
        cbxCapital.Enabled = False
        cbxInteres.Enabled = False
        pnCuoSug.Enabled = False
        RadioButton1.Enabled = False
        RadioButton5.Enabled = False
    End Sub
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

        Me.cbxCapital0.DataTextField = "cDescri"
        Me.cbxCapital0.DataValueField = "cCodigo"
        Me.cbxCapital0.DataSource = dst.Tables(0)
        Me.cbxCapital0.DataBind()


        Dim etabttab As New cTabttab
        dst.Clear()
        dst = etabttab.ObtenerFrecuencia("A")

        Me.cbxInteres.DataTextField = "cDescri"
        Me.cbxInteres.DataValueField = "cCodigo"
        Me.cbxInteres.DataSource = dst.Tables(0)
        Me.cbxInteres.DataBind()

        Me.cbxInteres0.DataTextField = "cDescri"
        Me.cbxInteres0.DataValueField = "cCodigo"
        Me.cbxInteres0.DataSource = dst.Tables(0)
        Me.cbxInteres0.DataBind()

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

        Me.Deshabilitar()
    End Sub
    Private Sub CargarDatosCredito()

        Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta
        ecreditos.Obtenercreditos(entidad3)
        Me.txtcCodCli.Text = entidad3.ccodcli
        Me.txtcNomcli.Text = entidad3.cnomcli
        Me.txtnMonApr.Text = entidad3.ncapdes
        Me.pnCuoSug.Text = entidad3.ncuoapr
        Me.pnCuoSug0.Text = entidad3.ncuoapr
        Me.txtcondicion.Text = entidad3.ccondic



        Me.cbxcodofi.SelectedValue = entidad3.coficina

        Me.txtnMonApr.Text = entidad3.ncapdes
        Me.txtFecDes.Text = entidad3.dfecvig

        Me.txtcTipPer.Text = entidad3.ctipper
        Me.txtcTipCuo.Text = entidad3.ctipcuo
        Me.txtnperdia.Text = entidad3.ndiaapr
        Me.txtndiaGra.Text = entidad3.ndiagra
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
            'Me.cbxLineas.SelectedValue = entidad3.cnrolin
            Me.cbxprograma.SelectedValue = ecretlin.ObtenerFuentedeFondosCodigo(entidad3.cnrolin)
            CargaLineasxFondos(Me.cbxprograma.SelectedValue)

        End If



        Dim ecredppg As New cCredppg
        Dim ldfecpri As Date
        ldfecpri = ecredppg.Obtenerprimeracuota(pcCodCta)
        Me.txtfecpri.Text = ldfecpri


        Dim lctipcuo As String
        Dim lcTipPer As String

        lctipcuo = entidad3.ctipcuo
        lcTipPer = entidad3.ctipper

        Me.cbxCapital.SelectedValue = IIf(IsDBNull(entidad3.cfreccap), "M", entidad3.cfreccap)
        Me.cbxCapital0.SelectedValue = IIf(IsDBNull(entidad3.cfreccap), "M", entidad3.cfreccap)
        cargacombointeres()
        cargacombointeres0()
        Me.cbxInteres.SelectedValue = IIf(IsDBNull(entidad3.cfrecint), "M", entidad3.cfrecint)
        Me.cbxInteres0.SelectedValue = IIf(IsDBNull(entidad3.cfrecint), "M", entidad3.cfrecint)



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

        Me.RadioButton1.Checked = IIf(entidad3.cflat = "F", False, True)
        Me.RadioButton5.Checked = IIf(entidad3.cflat = "F", True, False)


        clase.nMeses = entidad3.nmeses

        pcCodAct = entidad3.ccodact
        Session.Add("pcCodcli", Me.txtcCodCli.Text)
        '
        Dim entidad4 As New SIM.EL.clidfin
        Dim clsclidfin As New SIM.BL.cClidfin

        Dim mListaclidfin As New listaclidfin
        mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)


        'Obtener Saldo Actual
        Dim dscredito As New DataSet
        dscredito = ecreditos.SaldoxCuenta(pcCodCta, Session("gdfecsis"))
        Dim lnsaldo As Double = 0
        If dscredito.Tables(0).Rows.Count = 0 Then
        Else
            lnsaldo = dscredito.Tables(0).Rows(0)("ncapdes") - dscredito.Tables(0).Rows(0)("ncappag")
        End If
        Me.txtnMonApr0.Text = Math.Round(lnsaldo, 2)

        'Obtiene ultima cuota venciada
        Dim ldfecvig As Date
        ldfecvig = ecredppg.UltimaCuotaVencida(pcCodCta, Session("gdfecsis"))
        Me.txtFecDes0.Text = ldfecvig.Date
        Me.txtfecpri0.Text = ldfecvig.Date.AddMonths(1)
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
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
        lnTasa = entidadCretlin.ntasint
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
        clase.pcCodCre = pcCodCta
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
        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
        'Me.btnPlan_ServerClick(Me, New System.EventArgs)
        cargagrid()
    End Sub
    Public Sub CargarPlan(ByVal codigoCliente As String)
        Me.btnPlan_ServerClick(Me, New EventArgs)
    End Sub
    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarDatosCredito()
    End Sub
    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick
        'If Integer.Parse(Me.pnCuoSug.Text) < Integer.Parse(Me.pnCuoSug0.Text) Then
        '    Response.Write("<script language='javascript'>alert('Verificar Nº de Cuotas'   )</script>")
        '    Exit Sub
        'End If

        cargagrid0()
    End Sub
    Public Function GeneraPlan() As DataTable
        DataPlain.Tables.Clear()
        IgualaDatos()
        'dsPlain = clase.fxCreatePlain()
        Dim ecredppg As New cCredppg
        dsPlain = ecredppg.ObtenerDataSetPorID2(Me.txtCredito.Text.Trim)
        '        Me.dgPlan.DataSource = dsPlain.Tables(0) 'dsp.Tables(0)
        '       Me.dgPlan.DataBind()
        Dim nElem As Integer
        nElem = dsPlain.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Return clase.Plan_Print(dsPlain)
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Function

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable

        ds = clase.CreaEstructuraPlan()
        Dim x As Integer = 0
        Dim lncapita As Double = 0
        Dim lnintere As Double = 0
        Dim lncappag As Double = 0
        Dim lctipope As String = ""
        Dim ldfecven As Date = Today
        Dim lcnrocuo As String = "001"
        Dim lccodcta As String = txtCredito.Text.Trim
        lncappag = Double.Parse(Me.txtnMonApr.Text) - Double.Parse(Me.txtnMonApr0.Text)
        Dim lncapt As Double = lncappag
        Dim lnsaldo As Double = 0
        Dim i As Integer = 0
        For x = 0 To Me.dgPlan.Items.Count - 1
            ldfecven = Me.dgPlan.Items(x).Cells(0).Text
            lctipope = Me.dgPlan.Items(x).Cells(1).Text
            lcnrocuo = Me.dgPlan.Items(x).Cells(2).Text
            lncapita = Me.dgPlan.Items(x).Cells(3).Text
            lnintere = Me.dgPlan.Items(x).Cells(4).Text
            If lncapt <= 0 And lctipope <> "D" Then
                Exit For
            End If

            If lctipope = "D" Then 'Desembolso
                lnsaldo = lnsaldo + Double.Parse(Me.txtnMonApr.Text)
                dr = ds.Tables(0).NewRow
                dr("dfecpro") = ldfecven
                dr("dfecdes") = ldfecven
                dr("nTasaIn") = 0
                dr("nMCuota") = Double.Parse(Me.txtnMonApr.Text)
                dr("cTipOpe") = "D"
                dr("nSalCap") = Double.Parse(Me.txtnMonApr.Text)
                dr("nTipOpe") = Asc("D")
                dr("nCapita") = Double.Parse(Me.txtnMonApr.Text)
                dr("nIntere") = 0
                dr("cNroCuo") = lcnrocuo
                dr("nGastos") = 0
                dr("nSegDeu") = 0
                dr("nflag") = 1
                ds.Tables(0).Rows.Add(dr)
            Else
                If Math.Round(lncapt, 2) >= Math.Round(lncapita, 2) Then ' Cuota pagada
                    lncapt = lncapt - lncapita
                Else
                    lncapita = lncapt
                    lncapt = 0
                End If
                i += 1
                lnsaldo = lnsaldo - lncapita
                dr = ds.Tables(0).NewRow
                dr("dfecpro") = ldfecven
                dr("dfecdes") = ldfecven
                dr("nTasaIn") = 0
                dr("nMCuota") = lncapita + lnintere
                dr("cTipOpe") = "N"
                dr("nSalCap") = lnsaldo
                dr("nTipOpe") = Asc("N")
                dr("nCapita") = lncapita
                dr("nIntere") = lnintere
                dr("cNroCuo") = clase.fxStrZero(i, 3)
                dr("nGastos") = 0
                dr("nSegDeu") = 0
                dr("nflag") = 1
                ds.Tables(0).Rows.Add(dr)

            End If
        Next

        'Complementa con el nuevo plan de pagos

        lnsaldo = Double.Parse(Me.txtnMonApr0.Text)
        Dim y As Integer = 0
        For y = 0 To Me.dgPlan0.Items.Count - 1
            ldfecven = Me.dgPlan0.Items(y).Cells(0).Text
            lctipope = Me.dgPlan0.Items(y).Cells(1).Text
            lcnrocuo = Me.dgPlan0.Items(y).Cells(2).Text
            lncapita = Me.dgPlan0.Items(y).Cells(3).Text
            lnintere = Me.dgPlan0.Items(y).Cells(4).Text
            If lctipope = "D" Then
            Else
                i += 1
                lnsaldo = lnsaldo - lncapita
                dr = ds.Tables(0).NewRow
                dr("dfecpro") = ldfecven
                dr("dfecdes") = ldfecven
                dr("nTasaIn") = 0
                dr("nMCuota") = lncapita + lnintere
                dr("cTipOpe") = "N"
                dr("nSalCap") = lnsaldo
                dr("nTipOpe") = Asc("N")
                dr("nCapita") = lncapita
                dr("nIntere") = lnintere
                dr("cNroCuo") = clase.fxStrZero(i, 3)
                dr("nGastos") = 0
                dr("nSegDeu") = 0
                dr("nflag") = 1
                ds.Tables(0).Rows.Add(dr)

            End If
        Next

        clase.PlanTeoricoppg(ds, txtCredito.Text.Trim)

        Dim ecredppg As New cCredppg
        Dim ldvenplazo As Date
        Dim ldfeclim As Date
        ldvenplazo = ecredppg.UltimaCuotadePlan(Me.txtCredito.Text.Trim)
        ldfeclim = DateAdd(DateInterval.Day, 7, ldvenplazo)
        Dim lccondicN As String = ""

        If ldfeclim < Session("gdfecsis") Then 'Clasificado para Reestructuracion
            lccondicN = "R"
        Else 'Clasificado para Prorrogado
            lccondicN = "R"
        End If


        '        Me.ReclasificacionCarteraIndividual(lccondicN)

        'Actualiza datos en la cremcre
        Dim ecremcre As New cCremcre
        ecremcre.ActualizaCremcreRees(Me.txtCredito.Text.Trim, ldvenplazo, i, lccondicN, cbxCapital0.SelectedValue.Trim, cbxInteres0.SelectedValue.Trim, 0)
        ecremcre.ActualizaSuspensiondeCredito(Me.txtCredito.Text.Trim, Session("gdfecsis"), "A", 0)


        Me.btnImprimir.Disabled = False
        Response.Write("<script language='javascript'>alert('Plan de Pagos Ajustado')</script>")
    End Sub

    Private Sub btnImprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.ServerClick
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandep.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsPlanPago As New DataSet
        '   Dim entidadCredtpl As New SIM.EL.credtpl
        '  Dim eCredtpl As New SIM.BL.cCredtpl
        ' entidadCredtpl.ccodcta = Me.txtCredito.Text 'Me.txtcCodCta.Text.Trim
        'dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtCredito.Text)

        Dim entidadCredppg As New SIM.EL.credppg
        Dim eCredppg As New SIM.BL.cCredppg
        entidadCredppg.ccodcta = Me.txtCredito.Text.Trim
        dsPlanPago = eCredppg.ObtenerDataSetPorID2(Me.txtCredito.Text.Trim)

        Dim lnsaldo As Double = 0
        Dim fila As DataRow
        Dim z As Integer = 0
        For Each fila In dsPlanPago.Tables(0).Rows
            If Trim(dsPlanPago.Tables(0).Rows(z)("cTipope")) = "D" Then
                lnsaldo = lnsaldo + dsPlanPago.Tables(0).Rows(z)("nCapita")
            Else
                lnsaldo = lnsaldo - dsPlanPago.Tables(0).Rows(z)("nCapita")
            End If
            dsPlanPago.Tables(0).Rows(z)("Saldo") = lnsaldo
            z += 1
        Next

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True

        Dim reportes As String
        reportes = "plan.pdf"

        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
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
    Private Sub cargacombointeres0()
        Dim lcfrecuencia As String
        lcfrecuencia = Me.cbxCapital0.SelectedValue.Trim
        Dim ds As New DataSet
        Dim etabttab As New cTabttab
        ds = etabttab.ObtenerFrecuencia(lcfrecuencia)
        Me.cbxInteres0.DataTextField = "cDescri"
        Me.cbxInteres0.DataValueField = "cCodigo"
        Me.cbxInteres0.DataSource = ds.Tables(0)
        Me.cbxInteres0.DataBind()

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
            Me.cbxLineas.Enabled = False
            Me.btnPlan.Disabled = False
        End If


        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()


    End Sub
    Private Sub dgplan_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgPlan.PageIndexChanged

        If Me.IsPostBack Then

            Me.dgPlan.CurrentPageIndex = 0

            Me.dgPlan.CurrentPageIndex = e.NewPageIndex

            Me.Cargagrid()
            'este sería el procedimiento que se encarga de llenar tu datagrid.

        End If



    End Sub

    Private Sub cargagrid()
        'Valida Frecuencia de pagos
        Dim lvalida As Boolean
        Dim ecredppg As New cCredppg
        lvalida = ecredppg.ValidaFrecuencia(Me.cbxCapital.SelectedValue.Trim, Me.cbxInteres.SelectedValue.Trim, Integer.Parse(Me.pnCuoSug.Text))
        If lvalida = False Then
            Response.Write("<script language='javascript'>alert('Verifique Condiciones de Forma de Pago')</script>")
            Return
        End If

        Me.dgPlan.DataSource = GeneraPlan() 'DataPlain.Tables("PlanTeo") 'dsp.Tables(0)
        Me.dgPlan.DataBind()

        Me.btnImprimir.Disabled = True

    End Sub

    Protected Sub cbxCapital0_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCapital0.SelectedIndexChanged
        cargacombointeres0()
    End Sub
    Private Sub IgualaDatos0()
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
        lnTasa = entidadCretlin.ntasint
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

        clase.dFecDes = Date.Parse(Me.txtFecDes0.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri0.Text)
        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtnMonApr0.Text 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        clase.cCodFor = lnTipCuo
        clase.nPerDia = Integer.Parse(Me.txtnperdia.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug0.Text)
        clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = IIf(RadioButton5.Checked = True, "F", "") 'lcFlat
        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = pcCodCta
        'clase.cCodFor = Me.txtcTipPer.Text
        'clase.cTipCuo = Me.txtctipcuo.Text
        clase.nPerDia = Me.txtnperdia.Text
        clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm")
        clase.pcCodUsu = Session("gccodusu")
        clase.dFecsis = Session("gdfecsis")

        clase.cfreccap = Me.cbxCapital0.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres0.SelectedValue.Trim

        clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)

    End Sub
    Public Function GeneraPlan0() As DataTable
        DataPlain.Tables.Clear()
        IgualaDatos0()
        dsPlain = clase.fxCreatePlain(1, 0)
        '        Me.dgPlan.DataSource = dsPlain.Tables(0) 'dsp.Tables(0)
        '       Me.dgPlan.DataBind()
        Dim nElem As Integer
        nElem = dsPlain.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Return clase.Plan_Print(dsPlain)
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Function
    Private Sub cargagrid0()
        'Valida Frecuencia de pagos
        Dim lvalida As Boolean
        Dim ecredppg As New cCredppg
        lvalida = ecredppg.ValidaFrecuencia(Me.cbxCapital.SelectedValue.Trim, Me.cbxInteres.SelectedValue.Trim, Integer.Parse(Me.pnCuoSug.Text))
        If lvalida = False Then
            Response.Write("<script language='javascript'>alert('Verifique Condiciones de Forma de Pago')</script>")
            Return
        End If

        Me.dgPlan0.DataSource = GeneraPlan0() 'DataPlain.Tables("PlanTeo") 'dsp.Tables(0)
        Me.dgPlan0.DataBind()

        Me.btnImprimir.Disabled = True

    End Sub
    Private Sub dgplan0_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles dgPlan0.PageIndexChanged

        If Me.IsPostBack Then

            Me.dgPlan0.CurrentPageIndex = 0

            Me.dgPlan0.CurrentPageIndex = e.NewPageIndex

            Me.cargagrid0()
            'este sería el procedimiento que se encarga de llenar tu datagrid.

        End If



    End Sub


    Public Sub ReclasificacionCarteraIndividual(ByVal cCondic As String)
        Dim cClsAdP As New ClsAdPart
        Dim clsdes As New clsDesembolsa
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak

        Dim oki As Integer = 0
        Dim ldfecha As Date = Session("gdfecsis")
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim etabttab As New cTabttab
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim cplanti As String = ""
        Dim lccodlin As String = ""
        Dim lccodcta As String = ""
        Dim lccodigo As String = Me.cbxprograma.SelectedValue
        Dim lcmetodo As String
        Dim clsppal As New class1
        Dim lcaux As String
        lcaux = clsppal.ObtenerCodigoGarantia(Me.txtCredito.Text.Trim)

        'Actualiza Status del credito
        Dim k As Integer = 0

        k = ecremcre.ActualizaCondicion(Me.txtCredito.Text.Trim, cCondic)

        cCondic = "R"

        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        lccodlin = entidadCretlin.ccodlin

        lcmetodo = lccodlin.Substring(4, 2)

        'Graba Partida contable
        cClsAdP._dfecmod = Session("gdfecsis")
        cClsAdP._ccodusu = Session("gcCodusu")
        cClsAdP._ccodofi = Me.cbxcodofi.SelectedValue.Trim
        cClsAdP._ffondos = clsdes.ConvertidorFondos(lccodigo.Trim)
        cClsAdP._cconcepto = "PARTIDA DIARIA DE RECLASIFICACION POR REESTRUCTURACION"
        cClsAdP._dfeccnt = ldfecha
        cClsAdP._cpoliza = " "
        cClsAdP._nCuenta = 1
        cClsAdP._cnumdoc = "R"
        cClsAdP._llbandera = True
        cClsAdP._ccodpres = Me.txtCredito.Text.Trim

        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0

        'Carga la cuenta de reestructuracion

        lndebe = Double.Parse(Me.txtnMonApr0.Text)
        lnhaber = 0
        lcctactb = clase.CuentaContable(lcmetodo, cCondic, lcaux)

        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
        cClsAdP._ccodcta = lcctactb
        cClsAdP._ndebe = lndebe
        cClsAdP._nhaber = 0
        cClsAdP._cclase = Left(lcctactb, 1)
        cClsAdP._cpoliza = "AR"
        oki = cClsAdP.AdPartida()

        If oki = "0" Then 'Ocurrio un Error
            Exit Sub
        End If
        cClsAdP._nCuenta += 1

        'Abona la cuenta de la condicion Anterior
        Dim lccondic As String
        lccondic = Me.txtcondicion.Text.Trim
        lcctactb = clase.CuentaContable(lcmetodo, lccondic, lcaux)


        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
        cClsAdP._ccodcta = lcctactb
        cClsAdP._ndebe = 0
        cClsAdP._nhaber = lndebe
        cClsAdP._cclase = Left(lcctactb, 1)
        cClsAdP._cpoliza = "AR"


        oki = cClsAdP.AdPartida()

        If oki = "0" Then 'Ocurrio un Error
            Exit Sub
        End If




    End Sub

    
End Class


