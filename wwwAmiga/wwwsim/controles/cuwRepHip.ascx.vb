Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class cuwRepHip
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.rbt3.Checked = True
            Me.CheckBox2.Checked = True
            Me.Cargainit()
        End If
    End Sub
    Private Sub Cargainit()
        Me.txtdfecdesde.Text = Today()
        Me.txtdfechasta.Text = Today()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick
        Dim ldfecini As Date
        Dim ldfecfin As Date
        Dim lcfec, lcestados As String
        Dim lcopcion As Integer
        ldfecini = Date.Parse(Me.txtdfecdesde.Text)
        ldfecfin = Date.Parse(Me.txtdfechasta.Text)

        If Me.CheckBox1.Checked = True Then
            lcfec = "*"
        Else
            lcfec = ""
        End If

        If Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False Then
            Return
        ElseIf Me.CheckBox2.Checked = True And Me.CheckBox3.Checked = True And Me.CheckBox4.Checked = True Then
            lcestados = "111"
        ElseIf Me.CheckBox2.Checked = True And Me.CheckBox3.Checked = True And Me.CheckBox4.Checked = False Then
            lcestados = "110"
        ElseIf Me.CheckBox2.Checked = True And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False Then
            lcestados = "100"
        ElseIf Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = True And Me.CheckBox4.Checked = False Then
            lcestados = "010"
        ElseIf Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = True Then
            lcestados = "001"
        End If

        If Me.rbt3.Checked = True Then 'Todas
            lcopcion = 1
        ElseIf Me.rbt2.Checked = True Then 'Inscritas y Presentadas
            lcopcion = 2
        Else
            lcopcion = 3
        End If
        Dim dship As New DataSet
        Dim eclimgar As New cClimgar
        dship = eclimgar.RepgHip(ldfecini, ldfecfin, lcfec, lcestados, lcopcion)

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes\crgarhip.rpt"), OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "HENCORP"

        Dim a As String
        a = dship.Tables(0).TableName

        crRpt.SetDataSource(dship.Tables(a))
        'crRpt.SetParameterValue("oficina", lcoficina)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        '        .
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

        dship.Tables(0).Clear()
        dship.Clear()

    End Sub
End Class


