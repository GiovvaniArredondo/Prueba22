
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

  
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("gccodusu") = Nothing Then
                Response.Redirect("Wflogin.aspx")
                Exit Sub
            End If
        End If
    End Sub
End Class

