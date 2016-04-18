Imports System.Data.SqlClient

Partial Class ImageVB
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Request.QueryString("ImageID") IsNot Nothing Then
            Dim strQuery As String = "select foto from climide where ccodcli=@ccodcli"
            Dim cmd As SqlCommand = New SqlCommand(strQuery)
            cmd.Parameters.Add("@ccodcli", SqlDbType.Int).Value = Convert.ToInt32(Request.QueryString("ImageID"))

            Dim dt As DataTable = cmd.ExecuteScalar()
            If dt IsNot Nothing Then
                Dim bytes() As Byte = CType(dt.Rows(0)("foto"), Byte())
                Response.Buffer = True
                Response.Charset = ""
                Response.Cache.SetCacheability(HttpCacheability.NoCache)
                Response.ContentType = "image/jpg"
                Response.AddHeader("content-disposition", "attachment;filename=" + "fotomujer.jpg")
                Response.BinaryWrite(bytes)
                Response.Flush()
                Response.End()
            End If
        End If

    End Sub
   
End Class
