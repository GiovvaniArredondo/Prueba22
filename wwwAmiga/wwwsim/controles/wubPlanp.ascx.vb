Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Partial Class wubPlanp
    Inherits ucWBase
    Private cls1 As New SIM.bl.ClsMantenimiento
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Private clasep As New SIM.BL.class1

    '**************
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
            cargaCombos()
            InitVar()
            HiddenField3.Value = 0
            HiddenField2.Value = 0
            HiddenField1.Value = 0
            'Me.btnplan_Click(sender, e)
            Me.btnImprimir0.Disabled = False
            datagrid1.DataSource = GeneraPlan()
            Me.datagrid1.DataBind()
        End If

    End Sub
    Private Sub cargaCombos()
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

        Me.cbxCapital.SelectedValue = "M"
        Me.cbxInteres.SelectedValue = "M"

    End Sub
    Private Sub InitVar()
        Dim clase As New SIM.BL.class1
        Me.txtTasa.Text = 36.0
        Me.txtMonto.Text = 1000
        Me.txtFecha.Text = Today()
        Me.txtfecpri.Text = Today.AddMonths(1)
        Me.txtCuotas.Text = 6
        Me.txtPlazo.Text = Day(Today())
        Me.txtgracia.Text = 0
        Me.btnPlan.Disabled = False
        Me.btnImprimir0.Disabled = True
        clase.cNrolin = "1039900"
        txtnperdia.Text = 1
        txtnperdia.Visible = False
    End Sub

    Public Function GeneraPlan() As DataTable
        Dim clase As New SIM.BL.class1
        Dim omTabttab As New cTabttab


        DataPlain.Tables.Clear()
        lnTasa = Me.txtTasa.Text
        If Me.RadioButton1.Checked = True Then
            lcTipPer = "1"
            lcFlat = ""
        ElseIf Me.RadioButton2.Checked = True Then
            lcTipPer = "3"
            lcFlat = ""
        ElseIf Me.RadioButton3.Checked = True Then
            lcTipPer = "4"
            lcFlat = ""
            Me.txtCuotas.Text = 1
        ElseIf Me.Radiobutton4.Checked = True Then
            lcTipPer = "3"
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
        clase.cNrolin = "1039900"
        clase.gntasaiva = Session("gnIVA")
        clase.dFecDes = Date.Parse(Me.txtFecha.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)
        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtMonto.Text 'Integer.Parse(Me.txtmonSug.Text)
        clase.nTasInt = Double.Parse(lnTasa)



        If Me.cbxCapital.SelectedValue.Trim = "Q" Or Me.cbxCapital.SelectedValue.Trim = "S" Then
            clase.cCodFor = 1
            clase.nPerDia = omTabttab.ObtenerFactor("060", Me.cbxCapital.SelectedValue.Trim)
        Else
            clase.cCodFor = IIf(cbxCapital.SelectedValue.Trim = "X", 1, lnTipCuo)
            clase.nPerDia = IIf(cbxCapital.SelectedValue.Trim = "X", Integer.Parse(txtnperdia.Text), Integer.Parse(Me.txtPlazo.Text))
        End If


        clase.nNroCuo = Integer.Parse(Me.txtCuotas.Text)
        clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        clase.nDiaGra = Integer.Parse(Me.txtgracia.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = lcFlat
        clase.nMeses = 0
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm")
        clase.cfreccap = Me.cbxCapital.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres.SelectedValue.Trim
        clase.pcCodCre = "000000000000000000"
        clase.pcCodUsu = Session("gccodusu")
        clase.dFecsis = Session("gdfecsis")
        clase.pniva = Session("gnIVA")
        clase.lliva = Me.lliva.Checked

        dsPlain = clase.fxCreatePlain(-1, 0)
        '        Me.dgPlan.DataSource = dsPlain.Tables(0) 'dsp.Tables(0)
        '       Me.dgPlan.DataBind()
        Dim nElem As Integer
        nElem = dsPlain.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            '  Exit Function
        End If
        Dim fila As DataRow
        Dim lctipope As String = ""
        Dim lnsalint As Decimal = 0
        'Dim lntasaiva As Decimal = Session("gnIVA")
        'Dim lniva As Decimal = 0

        'nElem = 0
        'Dim lnsaldo As Decimal = 0
        'lnsaldo = Double.Parse(txtMonto.Text)


        'For Each fila In dsPlain.Tables(0).Rows
        '    lctipope = dsPlain.Tables(0).Rows(nElem)("cTipOpe")
        '    If lctipope = "D" Then
        '        fila("ncapita") = lnsaldo
        '        fila("saldo") = lnsaldo
        '    Else
        '        lnsalint = lnsalint - fila("nintere")
        '        lniva = Math.Round(fila("nGastos") * lntasaiva / 100, 2)
        '        fila("nGastos") = (fila("nGastos") + lniva)
        '        lnsaldo = lnsaldo - fila("nCapita")
        '    End If
        '    fila("Saldo") = lnsaldo
        '    '    dsPlain.Tables(0).Rows(nElem)("salint") = lnsalint
        '    nElem = nElem + 1
        'Next




        Return clase.Plan_Print(dsPlain)
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Function


    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick
        Me.btnImprimir0.Disabled = False
        Me.datagrid1.DataSource = GeneraPlan() 'DataPlain.Tables("PlanTeo") 'dsp.Tables(0)
        Me.datagrid1.DataBind()
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

        If lcfrecuencia.Trim = "X" Then
            txtnperdia.Visible = True
        Else
            txtnperdia.Visible = False
        End If
    End Sub
    Private Sub btnImprimir0_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir0.ServerClick
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
        entidad3.ccodcta = Me.txtcCodCta.Text.Trim
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
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        'dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)
        Dim dt As New DataTable
        dt = GeneraPlanGrid()
        dsPlanPago.Tables.Add(dt)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim fila As DataRow
        Dim nelem As Integer
        Dim lnSaldo As Double = 0
        Dim lctipope As String
        Dim lnsalint As Double = 0

        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Decimal = 0
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
            dsPlanPago.Tables(0).Rows(nelem)("Saldo") = lnSaldo
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
                lniva = 0 'Math.Round(dsPlanPago.Tables(0).Rows(nelem)("nGastos") * lntasaiva / 100, 2)
                'dsPlanPago.Tables(0).Rows(nelem)("nGastos") = (dsPlanPago.Tables(0).Rows(nelem)("nGastos") + lniva)

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

        lcmes = DateDiff(DateInterval.Month, ldfecdes, ldfecpri)

        lcmes = lcmes - 1
        If lcmes < 0 Then
            lcmes = 0
        End If
        lntotal = Math.Round((lnsegdeu + lnmanejo) * lcmes, 2)
        If lcmes > 0 Then
            lcnota = "Para el pago de la primera cuota, traer adicional al valor de esta " & lntotal.ToString.Trim & " en concepto de Seguro de Deuda y Manejo de Cuenta  "
        End If

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))

        crRpt.SetParameterValue("pcnomcli", "")
        crRpt.SetParameterValue("pcnota", "")
        'crRpt.Refresh()

        crRpt.SetParameterValue("cnomana", "")
        crRpt.SetParameterValue("ccodcta", "")
        crRpt.SetParameterValue("cdeslin", "")
        crRpt.SetParameterValue("cnomofi", "")
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "plan.pdf"
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
        'imprimir()
    End Sub
    Protected Sub dgclientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagrid1.SelectedIndexChanged
        Dim ctipope As String = datagrid1.SelectedRow.Cells(2).Text.ToString
        Dim cnrocuo As String = datagrid1.SelectedRow.Cells(3).Text.ToString
        If ctipope.Trim = "D" Then
            Response.Write("<script language='javascript'>alert('Desembolso No se puede Modificar')</script>")
            Exit Sub
        End If
        txtfecha0.Text = Date.Parse(datagrid1.SelectedRow.Cells(1).Text)
        txtmonto0.Text = Math.Round(Double.Parse(datagrid1.SelectedRow.Cells(4).Text), 2)
        txtnrocuo.Text = cnrocuo.Trim
        HiddenField3.Value = 2
    End Sub

    Protected Sub btnaplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        Dim lverifica As Boolean

        'Verifica monto
        If Me.txtmonto0.Text.Trim = "" Or txtmonto0.Text = Nothing Then
            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            Exit Sub
        End If

        lverifica = VerificaFecha(Date.Parse(txtfecha0.Text))
        If lverifica = True And HiddenField3.Value <> 2 Then
            Response.Write("<script language='javascript'>alert('Fecha Repetida y/o Errada')</script>")
            Exit Sub
        End If
        'If lverifica = True And HiddenField3.Value <> 2 And HiddenField3.Value <> 1 Then
        '    Response.Write("<script language='javascript'>alert('Fecha Repetida y/o Errada')</script>")
        '    Exit Sub
        'End If

        HiddenField1.Value = 0
        HiddenField2.Value = txtnrocuo.Text.Trim
        Aplicar()
        Genera()

        Session("cflag") = "X"
        'Al modificar el plan de pagos sera Irregular
        'Session()
    End Sub

    Protected Sub btnadelante_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadelante.Click

        'Verifica monto
        If Me.txtmonto0.Text.Trim = "" Or txtmonto0.Text = Nothing Then
            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            Exit Sub
        End If

        If HiddenField3.Value = 1 Then
            Response.Write("<script language='javascript'>alert('Presione Boton Aplicar')</script>")
            Exit Sub
        End If
        'Verifica monto
        If Me.txtmonto0.Text.Trim = "" Or txtmonto0.Text = Nothing Then
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
        txtfecha0.Text = Session("gdfecsis")
        txtmonto0.Text = 0
        HiddenField3.Value = 1
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
                    datagrid1.Rows(xy).Cells(4).Text = Double.Parse(Me.txtmonto0.Text)
                    datagrid1.Rows(xy).Cells(1).Text = Date.Parse(txtfecha0.Text)
                    i = datagrid1.SelectedIndex
                End If
            End If
        Next


    End Sub
    Private Sub Genera()
        'Carga plan 
        Dim clase As New class1
        Dim dt As New DataTable 'este plan quedara intacto

        dt = CargaPlanOriginal(HiddenField2.Value.Trim)
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
            dr("dfecpro") = Date.Parse(txtfecha0.Text)
            dr("ctipope") = "M"
            dr("cNroCuo") = clase.fxStrZero(i, 3)
            dr("ncapita") = 0
            dr("nintere") = 0
            dr("nSegDeu") = 0
            dr("Gastos") = 0
            dr("nSalCap") = 0
            dr("nMCuota") = Double.Parse(txtmonto0.Text)
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

        Dim lntasaint As Double = Double.Parse(txtTasa.Text) 'entidadcremcre.ntasint
        If Me.RadioButton1.Checked = True Then
            lcTipPer = "1"
            lcFlat = ""
        ElseIf Me.RadioButton2.Checked = True Then
            lcTipPer = "3"
            lcFlat = ""
        ElseIf Me.RadioButton3.Checked = True Then
            lcTipPer = "4"
            lcFlat = ""
            Me.txtCuotas.Text = 1
        ElseIf Me.Radiobutton4.Checked = True Then
            lcTipPer = "3"
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

        clase.nPerDia = Day(Date.Parse(Me.txtfecpri.Text))
        clase.cCodFor = lnTipCuo
        clase.cFlat = lcFlat
        clase.omCalPago(ldfecDes, ldfecUlt, i, lntasaint, Session("gnperbas"), lnmonDes, "N", _
               entidadcremcre.ctipper, entidadcremcre.ctipcuo, lcFlat, ds, 0)


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


        'clase.PlanTeorico(dt, txtcCodCta.Text.Trim)

        HiddenField3.Value = 0
        'Session("CodigoCre") = ""
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
    Private Function CargaPlanOriginal(ByVal cnrocuo As String) As DataTable
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

    Private Function VerificaM(ByVal cnrocuo As String) As Boolean
        'Barrer el grid 
        'Dim i As Integer
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            If datagrid1.Rows(xy).Cells(3).Text.Trim = cnrocuo.Trim Then
                If datagrid1.Rows(xy).Cells(2).Text = "M" Then
                    Return True
                Else
                    Return False
                End If

            End If

            'If datagrid1.Rows(xy).Cells(3).Text.Trim = txtnrocuo.Text.Trim Then 'Le pone marca al modificado
            '    If HiddenField1.Value = 2 Then
            '    Else
            '        datagrid1.Rows(xy).Cells(2).Text = "M"
            '    End If
            '    datagrid1.Rows(xy).Cells(4).Text = Double.Parse(Me.txtmonto0.Text)
            '    datagrid1.Rows(xy).Cells(1).Text = Date.Parse(txtfecha0.Text)
            '    i = datagrid1.SelectedIndex
            'End If
        Next
    End Function
    Private Function DevuelveMonto(ByVal cnrocuo As String) As Decimal
        'Barrer el grid 
        'Dim i As Integer
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            If datagrid1.Rows(xy).Cells(3).Text.Trim = cnrocuo.Trim Then
                Return Decimal.Parse(datagrid1.Rows(xy).Cells(4).Text)
            End If

            'If datagrid1.Rows(xy).Cells(3).Text.Trim = txtnrocuo.Text.Trim Then 'Le pone marca al modificado
            '    If HiddenField1.Value = 2 Then
            '    Else
            '        datagrid1.Rows(xy).Cells(2).Text = "M"
            '    End If
            '    datagrid1.Rows(xy).Cells(4).Text = Double.Parse(Me.txtmonto0.Text)
            '    datagrid1.Rows(xy).Cells(1).Text = Date.Parse(txtfecha0.Text)
            '    i = datagrid1.SelectedIndex
            'End If
        Next

    End Function
    Private Function GeneraPlanGrid() As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DT As New DataTable
        Dim DataPlain As New DataSet

        DataPlain.Clear()
        lCampos1 = "saldo,dfecven, ctipope, cNroCuo, ncapita, nintere, nSalCap, Gastos, nSegDeu,nMCuota,nDifdia,nTasaef,nTasain,nFlag,nTasaIn,nGastos,"
        lTipos1 = "D,F,S,S,D,D,D,D,D,D,D,D,D,S,D,D,"
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
            DR("nGastos") = datagrid1.Rows(xy).Cells(7).Text
            DR("nSalCap") = datagrid1.Rows(xy).Cells(9).Text
            DR("saldo") = datagrid1.Rows(xy).Cells(9).Text
            DR("nMCuota") = datagrid1.Rows(xy).Cells(4).Text
            DR("nflag") = "1"
            DT.Rows.Add(DR)
        Next

        Return DT

    End Function
    Private Sub imprimir()
        Dim clase As New SIM.BL.class1
        Dim dsreporte As New DataTable
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        clase.cNrolin = "0000400"
        dsreporte = GeneraPlan()
        'Dim frmReporte As New Reportes
        'frmReporte.pDataSet = dsreporte
        'Response.Redirect("wfReportes.aspx")
        '---
        Dim nelem As Integer
        nelem = 0
        Dim i As Integer
        Dim fila As DataRow
        'For Each fila In dsreporte.Rows
        '    dsreporte.Rows(nelem)("Gastos") = dsreporte.Rows(nelem)("Gastos")
        '    dsreporte.Rows(nelem)("nsegdeu") = 
        '    nelem += 1
        'Next
        '-------
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crPlan.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsreporte)
        crRpt.Refresh()
        crRpt.SetParameterValue("tasa", Me.txtTasa.Text)

        Dim reportes As String
        reportes = "crplan.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   
        'Me.btnImprimir.Disabled = True

    End Sub
End Class


