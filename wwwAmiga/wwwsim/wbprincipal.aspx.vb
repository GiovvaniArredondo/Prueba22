

Partial Class wbprincipal
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'carga variables globales
        Dim clsvariables As New SIM.BL.cTabtvar
        Dim dst As New DataSet
        Dim filavariables As DataRow
        Dim lcnomvar As String
        Dim lcconvar As String
        dst = clsvariables.ObtenerDataSetPorID()
        If dst.Tables(0).Rows.Count > 0 Then
            For Each filavariables In dst.Tables(0).Rows
                If filavariables("lcarini") = True Then
                    lcnomvar = filavariables("cnomvar")
                    lcnomvar = lcnomvar.Trim
                    lcconvar = filavariables("cconvar")
                    lcconvar = lcconvar.Trim
                    Select Case filavariables("ctipvar") ' Evaluate Number.
                        Case "D"
                            Session.Add(lcnomvar, Date.Parse(lcconvar))
                        Case "N"
                            Session.Add(lcnomvar, Integer.Parse(lcconvar))
                        Case "C"
                            Session.Add(lcnomvar, lcconvar.ToString)
                        Case Else   ' Other values.
                            Session.Add(lcnomvar, lcconvar.ToString)
                    End Select
                End If
            Next
        End If
    End Sub

End Class


