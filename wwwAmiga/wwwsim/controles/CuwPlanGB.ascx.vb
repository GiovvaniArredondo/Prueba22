Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Partial Class CuwPlanGB
    Inherits ucWBase
    Dim DataPlain As New DataSet
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clasep As New SIM.BL.class1

    Private _URLCodigo As String
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
        'If Not IsPostBack Then
        'End If
        'Me.CargarPlan(Me.txtcCodCta.Text.Trim)
        Me.btnplan.Visible = False
    End Sub

    Public Sub CargarPlan(ByVal CodigoCredito As String)
        Dim dsp As New DataSet
        Dim ecremcre As New cCremcre
        Dim entidadcremcre As New cremcre


        Dim nElem As Integer
        Me.txtcCodCta.Text = CodigoCredito
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        Dim lccodsol As String = ""
        Dim ldfecha As Date

        entidadcremcre.ccodcta = CodigoCredito
        ecremcre.ObtenerCremcre(entidadcremcre)
        lccodsol = entidadcremcre.ccodsol
        ldfecha = entidadcremcre.dfecvig

        txtcCodsol.Text = lccodsol

        dsp = eCredtpl.PlanGrupalTeorico(lccodsol, ldfecha)
        
        If dsp Is Nothing Then
            Exit Sub
        End If


        'entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        'dsp = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)
        nElem = dsp.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Dim ecredppg As New cCredppg
            dsp = ecredppg.PlanGrupalTeorico(lccodsol, ldfecha)
            nElem = dsp.Tables(0).Rows.Count()
            If nElem = 0 Then
                Exit Sub
            End If
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
        lCampos1 = "Fecha, Operacion, N_Cuota, nMcuota, Capital, Interes, Saldo, Gastos, nSegDeu,"
        lTipos1 = "S,S,S,D,D,D,D,D,D,"
        DT = clasep.creadatasetdesconec(lCampos1, lTipos1, "PlanTeo")
        nElem = 0
        Dim i As Integer
        Dim fila As DataRow
        Dim dFecCon As Date
        DR = DT.NewRow
        Dim lnSaldo As Double = 0
        For Each fila In dsp.Tables(0).Rows
            DR = DT.NewRow
            dFecCon = dsp.Tables(0).Rows(nElem)("dFecVen")
            DR("Fecha") = dFecCon.ToString.Substring(0, 10)
            DR("Operacion") = dsp.Tables(0).Rows(nElem)("cTipOpe")
            DR("N_Cuota") = dsp.Tables(0).Rows(nElem)("cNroCuo")
            DR("nMcuota") = fila("nCapita") + fila("nIntere") + fila("nGastos") + fila("nSegDeu")
            DR("Capital") = dsp.Tables(0).Rows(nElem)("nCapita")
            DR("Interes") = dsp.Tables(0).Rows(nElem)("nIntere")
            DR("Gastos") = dsp.Tables(0).Rows(nElem)("nGastos")
            DR("nSegDeu") = dsp.Tables(0).Rows(nElem)("nSegDeu")

            If dsp.Tables(0).Rows(nElem)("cTipOpe") = "D" Then
                lnSaldo = lnSaldo + dsp.Tables(0).Rows(nElem)("nCapita")
            Else
                lnSaldo = lnSaldo - dsp.Tables(0).Rows(nElem)("nCapita")
            End If
            DR("Saldo") = utilNumeros.Redondear(lnSaldo, 2)
            'DataPlain.Tables(0).Rows.Add(DR)
            DT.Rows.Add(DR)
            nElem = nElem + 1
        Next
        DataPlain.Tables.Add(DT)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        'Me.DataGrid1.DataSource = DataPlain.Tables(0) 'dsp.Tables(0)
        'Me.DataGrid1.DataBind()
        Me.Grid_Plan.DataSource = DataPlain.Tables(0)
        Me.Grid_Plan.DataBind()
    End Sub
    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
        Dim c As String
        c = Session("CodigoCre")
        CargarPlan(c)
    End Sub

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
        Dim lccodsol As String = ""
        Dim ldfecha As Date

        Dim lcnomcli As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = Me.txtcCodCta.Text.Trim
        ecreditos.Obtenercreditos(entidad3)
        'entidad3.ccodsol

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


        lccodsol = entidad3.ccodsol
        ldfecha = entidad3.dfecvig


        Dim ecremsol As New cCremsol
        lcnomcli = ecremsol.ObtenerNombre(entidad3.ccodsol)
        'lcnomcli = entidad3.cnomcli


        Dim dsPlanPago As New DataSet
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        'entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        'dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)

        dsPlanPago = eCredtpl.PlanGrupalTeorico(lccodsol, ldfecha)
        If dsPlanPago.Tables(0).Rows.Count = 0 Then
            Dim ecredppg As New cCredppg
            dsPlanPago = ecredppg.PlanGrupalTeorico(lccodsol, ldfecha)
        End If

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
                fila("ngastos") = 0
            Else
                lnsalint = lnsalint - dsPlanPago.Tables(0).Rows(nelem)("nintere")
                'lniva = Math.Round(dsPlanPago.Tables(0).Rows(nelem)("nGastos") * lntasaiva / 100, 2)
                'dsPlanPago.Tables(0).Rows(nelem)("nGastos") = (dsPlanPago.Tables(0).Rows(nelem)("nGastos") + lniva)

                If dsPlanPago.Tables(0).Rows(nelem)("cnrocuo") = "001" Then
                    ldfecpri = dsPlanPago.Tables(0).Rows(nelem)("dfecven")
                    lnsegdeu = dsPlanPago.Tables(0).Rows(nelem)("nsegdeu")
                    lnmanejo = dsPlanPago.Tables(0).Rows(nelem)("ngastos")
                End If


            End If
            dsPlanPago.Tables(0).Rows(nelem)("salint") = lnsalint
            nelem = nelem + 1
        Next
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
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


        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))

        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pcnota", lcnota)

        crRpt.SetParameterValue("cnomana", ("Asesor: " & lcnomana))
        crRpt.SetParameterValue("ccodcta", ("Grupo Nº: " & lccodsol))
        crRpt.SetParameterValue("cdeslin", ("Linea: " & lcdeslin))
        crRpt.SetParameterValue("cnomofi", ("Oficina: " & lcnomofi))
        'crRpt.Refresh()

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
        Response.Flush()
        Response.Close()

    End Sub

    Private Sub btnplan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplan.ServerClick
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandepagos2.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        Dim lcnomcli As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        Dim ecremsol As New cCremsol
        Dim lcnomgru As String

        entidad3.ccodcta = Me.txtcCodCta.Text.Trim
        ecreditos.Obtenercreditos(entidad3)
        lcnomcli = entidad3.cnomcli
        Dim lncuocap As Double = 0
        Dim lncuoint As Double = 0

        lcnomgru = ecremsol.ObtenerNombre(entidad3.ccodsol)

        Dim dsPlanPago As New DataSet
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        Dim lncuoaho As Double = 0
        If Me.txtcCodCta.Text.Trim.Substring(6, 2) = "02" Then
            lncuoaho = eCredtpl.CuoAhorro(entidad3.nmonapr)
        Else
            lncuoaho = 0
        End If
        entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
        dsPlanPago = eCredtpl.ObtenerDataSetPorID(Me.txtcCodCta.Text.Trim)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim fila As DataRow
        Dim nelem As Integer
        Dim lnSaldo As Double = 0
        Dim lctipope As String
        Dim lnsalint As Double = 0
        Dim lcnrocuo As String
        Dim lnmonsug As Double = 0
        For Each fila In dsPlanPago.Tables(0).Rows
            lctipope = dsPlanPago.Tables(0).Rows(nelem)("cTipOpe")
            lcnrocuo = dsPlanPago.Tables(0).Rows(nelem)("cnrocuo")
            If lctipope = "D" Then
                lnSaldo = lnSaldo + dsPlanPago.Tables(0).Rows(nelem)("nCapita")
                lnmonsug = dsPlanPago.Tables(0).Rows(nelem)("nCapita")
            Else
                lnSaldo = lnSaldo - dsPlanPago.Tables(0).Rows(nelem)("nCapita")
            End If
            lnsalint = lnsalint + dsPlanPago.Tables(0).Rows(nelem)("nIntere")
            dsPlanPago.Tables(0).Rows(nelem)("saldo") = lnSaldo
            If lctipope = "N" Or lcnrocuo = "001" Then
                lncuocap = dsPlanPago.Tables(0).Rows(nelem)("ncapita")
                lncuoint = dsPlanPago.Tables(0).Rows(nelem)("nintere")
            End If
            nelem = nelem + 1
        Next
        nelem = 0
        For Each fila In dsPlanPago.Tables(0).Rows
            lctipope = dsPlanPago.Tables(0).Rows(nelem)("cTipOpe")
            If lctipope = "D" Then
            Else
                lnsalint = lnsalint - dsPlanPago.Tables(0).Rows(nelem)("nintere")
            End If
            dsPlanPago.Tables(0).Rows(nelem)("salint") = lnsalint
            nelem = nelem + 1
        Next
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))

        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pncuocap", lncuocap)
        crRpt.SetParameterValue("pncuoint", lncuoint)
        crRpt.SetParameterValue("pncuoaho", lncuoaho)
        crRpt.SetParameterValue("pncuotamin", (lncuoaho + lncuocap + lncuoint))
        crRpt.SetParameterValue("pcnomgru", lcnomgru)
        crRpt.SetParameterValue("pnmonsug", lnmonsug)
        'crRpt.Refresh()

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "plan2.pdf"
        'reportes &= ".pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandepagosG.rpt", OpenReportMethod.OpenReportByDefault)

            Dim lcnomcli As String
            Dim ldfecvig As Date
            Dim entidad3 As New SIM.EL.creditos
            Dim ecreditos As New SIM.BL.ccreditos
            entidad3.ccodcta = Me.txtcCodCta.Text.Trim
            ecreditos.Obtenercreditos(entidad3)
            lcnomcli = entidad3.cnomcli
            ldfecvig = entidad3.dfecvig

            Dim dsPlanPago As New DataSet
            Dim entidadCredtpl As New SIM.EL.credtpl
            Dim eCredtpl As New SIM.BL.cCredtpl
            entidadCredtpl.ccodcta = Me.txtcCodCta.Text.Trim
            dsPlanPago = eCredtpl.PlanesdePagosGrupos(Me.txtcCodsol.Text.Trim, ldfecvig)

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Dim fila As DataRow
            Dim nelem As Integer = 0
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

            Dim lccodcta As String = ""

            For Each fila In dsPlanPago.Tables(0).Rows
                If nelem = 0 Then
                    lccodcta = fila("ccodcta")
                End If
                If fila("ccodcta") = lccodcta Then
                Else
                    lnSaldo = 0
                End If

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
                lccodcta = fila("ccodcta")
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
                lcnota = ""
            End If

            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            ' Setear los registros recuperados, diciendole el Table respectivo
            crRpt.SetDataSource(dsPlanPago.Tables(0))

            crRpt.SetParameterValue("pcnomcli", lcnomcli)
            crRpt.SetParameterValue("pcnota", lcnota)
            'crRpt.Refresh()

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
        Catch ex As Exception
            Return
        End Try
    End Sub

    
End Class


