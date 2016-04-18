Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class ucColectorMulti
    Inherits ucWBase
    Private clsppal As New class1

#Region " Variables "
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private cls_Sim As New SIM.bl.ClsSolicitud
    Private claseppal As New class1
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub
#Region " Metodos "
    Private Sub CargarDatos()
        Me.txtFecini.Text = Today()
        Me.txtfecfin.Text = Today.AddMonths(1)
        '----------------------------
        'Llenando Analistas
        '----------------------------
        lnparametro1_R = "cNomUsu , cCodUsu, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTUSU"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCatego ='ANA' ORDER BY cNomUsu"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Analistas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxanacre.DataTextField = "cNomUsu"
        Me.cbxanacre.DataValueField = "cCodUsu"
        Me.cbxanacre.DataSource = ds.Tables("Resultado")
        Me.cbxanacre.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub

#End Region

    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        Dim dscolector As New DataSet
        Dim ecreditos As New ccreditos

        dscolector = ecreditos.Multicolector(Me.cbxanacre.Value.Trim, Me.txtFecini.Text, Me.txtfecfin.Text)
        Dim fila As DataRow
        Dim nCanti As Integer = 0
        Dim pccodcta As String
        Dim pcnrolin As String
        Dim pcbarra As String
        Dim lcbarra As String
        Dim lncuota As Double
        Dim pccodlin As String
        If dscolector.Tables(0).Rows.Count = 0 Then
        Else
            For Each fila In dscolector.Tables(0).Rows
                pccodlin = fila("ccodlin")
                pccodcta = Trim(dscolector.Tables(0).Rows(nCanti)("ccodcta")) & pccodlin.Substring(2, 2)
                pcnrolin = dscolector.Tables(0).Rows(nCanti)("cnrolin")

                clsppal.gnperbas = Session("gnperbas")
                clsppal.pnComtra = Session("gnComTra")
                If dscolector.Tables(0).Rows(nCanti)("dfecvig") >= #7/11/2008# Then
                    clsppal.pnSegVm = Session("gnSegVm1")
                Else
                    clsppal.pnSegVm = Session("gnSegVm")
                End If

                clsppal.cNrolin = pcnrolin
                lncuota = fila("nmoncuo") 'clsppal.ValorCuota(pccodcta)
                If lncuota = 0 Then
                    dscolector.Tables(0).Rows(nCanti).Delete()
                    dscolector.Tables(0).GetChanges(DataRowState.Deleted)
                Else

                    lcbarra = "41500000000042398020" & pccodcta
                    pcbarra = claseppal._StrTo128C(lcbarra)
                    dscolector.Tables(0).Rows(nCanti)("cbarra") = pcbarra
                    dscolector.Tables(0).Rows(nCanti)("nmoncuo") = lncuota
                    fila("ccodcta") = pccodcta
                End If


                nCanti += 1
            Next
            dscolector.Tables(0).AcceptChanges()

            Dim crRpt1 As New ReportDocument
            Dim rptStream1 As New System.IO.MemoryStream
            'Try
            crRpt1.Load(Server.MapPath("reportes") + "\crMultiColector.rpt", OpenReportMethod.OpenReportByDefault)
            'Catch ex As Exception
            '   Return
            '  End Try
            crRpt1.SetDataSource(dscolector.Tables(0))
            crRpt1.Refresh()
            rptStream1 = CType(crRpt1.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
            Response.Clear()
            Response.Buffer = True
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(rptStream1.ToArray())
            Response.End()
        End If

    End Sub
End Class


