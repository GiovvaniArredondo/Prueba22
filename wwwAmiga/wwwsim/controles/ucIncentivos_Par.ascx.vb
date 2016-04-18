Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class ucIncentivos_Par
    Inherits ucWBase
    Dim clsppal As New class1
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargaCombo(1)
        End If
    End Sub
    Private Sub CargaCombo(ByVal opcion As Integer)

        Dim etabttab As New cTabttab
        Dim ds As New DataSet
        GridView1.DataSource = ""

      
        If opcion = 1 Then
            ds = etabttab.ObtenerCondicionadoscFlag("162")
        ElseIf opcion = 2 Then
            ds = etabttab.ObtenerCondicionadoscFlag("163")
        ElseIf opcion = 3 Then
            ds = etabttab.ObtenerCondicionadoscFlag("164")
        ElseIf opcion = 4 Then
            ds = etabttab.ObtenerCondicionadoscFlag("165")
        End If



        If ds.Tables(0).Rows.Count = 0 Then
        Else
            GridView1.DataSource = ds.Tables(0)
            GridView1.DataBind()
        End If
    End Sub
   
  
   
    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim lctipo As String = cmbtipo.SelectedValue.Trim
        Dim lccodtab As String = ""
        If lctipo = 1 Then
            lccodtab = "162"
        ElseIf lctipo = 2 Then
            lccodtab = "163"
        ElseIf lctipo = 3 Then
            lccodtab = "164"
        ElseIf lctipo = 4 Then
            lccodtab = "165"
        End If

        Dim etabttab As New cTabttab
        Dim nmonto As TextBox
        Dim xy As Integer = 0
        Dim lccodigo As String = ""
        Dim lnmonto As Decimal = 0
        For xy = 0 To GridView1.Rows.Count - 1
            nmonto = CType(Me.GridView1.Rows(xy).FindControl("Textbox2"), TextBox)
            lnmonto = Double.Parse(nmonto.Text)
            lccodigo = GridView1.Rows(xy).Cells(0).Text.Trim

            etabttab.GrabarTabttabNumerico(lccodtab, lccodigo, lnmonto)
        Next

        CargaCombo(lctipo)
    End Sub

    Protected Sub cmbtipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtipo.SelectedIndexChanged
        CargaCombo(cmbtipo.SelectedValue.Trim)
    End Sub
End Class


