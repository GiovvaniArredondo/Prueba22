Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Partial Class CuwPlan
    Inherits ucWBase


#Region "Privadas"
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clasep As New SIM.BL.class1
    Private _URLCodigo As String
    Private codigoJs As String
#End Region


    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            UpdatePanel1.Visible = False
            HiddenField3.Value = 0
            HiddenField2.Value = 0
            HiddenField1.Value = 0
        Else
            Me.CargarPlan(Me.txtcCodCta.Text.Trim)
        End If
        
    End Sub

    Public Sub CargarPlan(ByVal CodigoCredito As String)

        'If CodigoCredito.Trim = "" Then
        '    Return
        'End If
        UpdatePanel1.Visible = True

        Dim dsp As New DataSet
        Dim DataPlain As New DataSet
        Dim nElem As Integer
        Me.txtcCodCta.Text = CodigoCredito
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        dsp = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)
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
        lCampos1 = "dfecpro, ctipope, cNroCuo, ncapita, nintere, nSalCap, Gastos, nSegDeu,nMCuota,nGastos,nTasaIn,"
        lTipos1 = "F,S,S,D,D,D,D,D,D,D,D,"
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
        Dim lngasdes As Decimal = 0
        Dim ecredgas As New cCredgas
        Dim ecredkar As New cCredkar

        Dim lcnrocuo As String = ""
        lcnrocuo = ecredkar.obtenercnrodoc(txtcCodCta.Text.Trim)
        lngasdes = ecredgas.ObtenerGastoDesembolso(txtcCodCta.Text.Trim, lcnrocuo)

        For Each fila In dsp.Tables(0).Rows
            DR = DT.NewRow
            dFecCon = dsp.Tables(0).Rows(nElem)("dFecVen")
            DR("dfecpro") = dFecCon.ToString.Substring(0, 10)

            DR("ctipope") = dsp.Tables(0).Rows(nElem)("cTipOpe")
            DR("cNroCuo") = dsp.Tables(0).Rows(nElem)("cNroCuo")
            DR("ncapita") = dsp.Tables(0).Rows(nElem)("nCapita")
            'DR("nintere") = Math.Round((dsp.Tables(0).Rows(nElem)("nIntere") + Math.Round((dsp.Tables(0).Rows(nElem)("nIntere") * lntasaiva / 100), 2)), 2)
            DR("nintere") = Math.Round((dsp.Tables(0).Rows(nElem)("nIntere")), 2)
            DR("nSegDeu") = dsp.Tables(0).Rows(nElem)("nSegDeu")
            DR("Gastos") = (dsp.Tables(0).Rows(nElem)("nGastos"))
            If dsp.Tables(0).Rows(nElem)("cTipOpe") = "D" Then
                lnSaldo = lnSaldo + dsp.Tables(0).Rows(nElem)("nCapita")
                lncapdes = dsp.Tables(0).Rows(nElem)("nCapita")
                dsp.Tables(0).Rows(nElem)("nCapita") = 0
                DR("Gastos") = lngasdes
                DR("nMCuota") = 0
            Else
                lnSaldo = lnSaldo - dsp.Tables(0).Rows(nElem)("nCapita")
                lniva = 0 'Math.Round(dsp.Tables(0).Rows(nElem)("nGastos") * lntasaiva / 100, 2)
                DR("nMCuota") = Math.Round(DR("ncapita") + DR("nintere") + DR("nSegDeu") + DR("Gastos"), 2)
            End If

            DR("nSalCap") = utilNumeros.Redondear(lnSaldo, 2)

            'DR("nGastos") = (dsp.Tables(0).Rows(nElem)("nGastos") + lniva)
            DT.Rows.Add(DR)
            nElem = nElem + 1
        Next
        DataPlain.Tables.Add(DT)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        Me.datagrid1.DataSource = DataPlain.Tables(0)
        Me.datagrid1.DataBind()
    End Sub
    'Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
    '    Dim c As String
    '    c = Session("CodigoCre")
    '    CargarPlan(c)
    'End Sub

    Private Sub btnImprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.ServerClick
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
        dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)

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
                dsPlanPago.Tables(0).Rows(nelem)("nGastos") = (dsPlanPago.Tables(0).Rows(nelem)("nGastos") + lniva)

                If dsPlanPago.Tables(0).Rows(nelem)("cnrocuo") = "001" Then
                    ldfecpri = dsPlanPago.Tables(0).Rows(nelem)("dfecven")
                    lnsegdeu = dsPlanPago.Tables(0).Rows(nelem)("nsegdeu")
                    lnmanejo = dsPlanPago.Tables(0).Rows(nelem)("ngastos")
                End If

            End If
            dsPlanPago.Tables(0).Rows(nelem)("salint") = lnsalint
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

        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pcnota", lcnota)
        'crRpt.Refresh()

        crRpt.SetParameterValue("cnomana", ("Asesor: " & lcnomana))
        crRpt.SetParameterValue("ccodcta", ("Nº Credito: " & lccodcta))
        crRpt.SetParameterValue("cdeslin", ("Linea: " & lcdeslin))
        crRpt.SetParameterValue("cnomofi", ("Oficina: " & lcnomofi))
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "plan.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de document
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub

    Protected Sub dgclientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagrid1.SelectedIndexChanged
        Dim ctipope As String = datagrid1.SelectedRow.Cells(2).Text.ToString
        Dim cnrocuo As String = datagrid1.SelectedRow.Cells(3).Text.ToString
        If ctipope.Trim = "D" Then
            '            Response.Write("<script language='javascript'>alert('Desembolso No se puede Modificar')</script>")
            codigoJs = "<script language='javascript'>alert('Desembolso No se puede Modificar, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        txtfecha.Text = Date.Parse(datagrid1.SelectedRow.Cells(1).Text)
        txtmonto.Text = Math.Round(Double.Parse(datagrid1.SelectedRow.Cells(4).Text), 2)
        txtnrocuo.Text = cnrocuo.Trim
        HiddenField3.Value = 2
    End Sub
    Private Function CargaPlanOriginal(ByVal cnrocuo As String) As DataTable
        Dim clase As New class1
        Dim dsp As New DataSet

        Dim nElem As Integer
        'Me.txtcCodCta.Text = CodigoCredito
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        dsp = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)
        nElem = dsp.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
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
        For Each fila In dsp.Tables(0).Rows

            If HiddenField1.Value = 1 Then
                If cnrocuo.Trim > fila("cnrocuo") Then
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
                        DR("nMCuota") = 0
                    Else
                        lnSaldo = lnSaldo - fila("nCapita")
                        lniva = 0 'Math.Round(fila("nGastos") * lntasaiva / 100, 2)
                    End If
                    DR("Gastos") = (fila("nGastos") + lniva)
                    DR("nSalCap") = utilNumeros.Redondear(lnSaldo, 2)
                    DR("nMCuota") = Math.Round(DR("ncapita") + DR("nintere") + DR("nSegDeu") + DR("Gastos"), 2)
                    DT.Rows.Add(DR)
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
                    DR("Gastos") = (fila("nGastos") + lniva)
                    DR("nSalCap") = utilNumeros.Redondear(lnSaldo, 2)
                    DR("nMCuota") = 0 'Math.Round(DR("ncapita") + DR("nintere") + DR("nSegDeu") + DR("Gastos"), 2)
                    DT.Rows.Add(DR)
                End If
            End If

            nElem = nElem + 1
        Next
        DataPlain.Tables.Add(DT)
        Return DataPlain.Tables(0)
    End Function

    Protected Sub btnadelante_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadelante.Click
        'Session("CodigoCre") = ""

        'Verifica monto
        If Me.txtmonto.Text.Trim = "" Or txtmonto.Text = Nothing Then
            '            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            codigoJs = "<script language='javascript'>alert('Monto Invalido, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If HiddenField3.Value = 1 Then
            'Response.Write("<script language='javascript'>alert('Presione Boton Aplicar')</script>")
            codigoJs = "<script language='javascript'>alert('Presione Boton Aplicar, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        'Verifica monto
        If Me.txtmonto.Text.Trim = "" Or txtmonto.Text = Nothing Then
            'Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            codigoJs = "<script language='javascript'>alert('Monto Invalido, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        HiddenField1.Value = 1
        HiddenField2.Value = txtnrocuo.Text.Trim
        Aplicar()
        Genera()
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
        clase.cCodFor = entidadcremcre.ctipcuo
        clase.cFlat = entidadcremcre.cflat
        clase.cfreccap = entidadcremcre.cfreccap
        clase.cfrecint = entidadcremcre.cfrecint
        clase.cNrocuo = i
        clase.nNroCuo = i
        clase.omCalPago(ldfecDes, ldfecUlt, i, entidadcremcre.ntasint, Session("gnperbas"), lnmonDes, "N", _
                 entidadcremcre.ctipper, entidadcremcre.ctipcuo, entidadcremcre.cflat, ds, 0)


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


        clase.PlanTeorico(dt, txtcCodCta.Text.Trim)

        HiddenField3.Value = 0
        'Session("CodigoCre") = ""
    End Sub

    Protected Sub btnaplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        'Session("CodigoCre") = ""
        Dim lverifica As Boolean

        'Verifica monto
        If Me.txtmonto.Text.Trim = "" Or txtmonto.Text = Nothing Then
            '            Response.Write("<script language='javascript'>alert('Monto Invalido')</script>")
            codigoJs = "<script language='javascript'>alert('Monto Invalido, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        lverifica = VerificaFecha(Date.Parse(txtfecha.Text))
        If lverifica = True And HiddenField3.Value <> 2 Then
            'Response.Write("<script language='javascript'>alert('Fecha Repetida y/o Errada')</script>")
            codigoJs = "<script language='javascript'>alert('Fecha Repetida y/o Errada, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
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
    '--------------------------------Parshe
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

End Class


