
Partial Class controles_SubirArchivo
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    'Protected Sub AsyncFileUpload1_UploadedComplete(ByVal sender As Object, _
    '          ByVal e As AjaxControlToolkit.AsyncFileUploadEventArgs) _
    '          Handles AsyncFileUpload1.UploadedComplete

    '    Dim myScript = "top.$get('" & msgServerSide.ClientID & _
    '   "').innerHTML = 'Estatus: Satisfactorio <br/>  Archivo: " & e.filename & _
    '   "<br/> Tamaño: " & AsyncFileUpload1.FileBytes.Length.ToString() & "';"
    '    ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "size", myScript, True)

    '    'AsyncFU.SaveAs("AQUI VA LA RUTA PARA GRABAR EL ARCHIVO")

    'End Sub

    'Protected Sub AsyncFileUpload1_UploadedFileError(ByVal sender As Object, _
    '              ByVal e As AjaxControlToolkit.AsyncFileUploadEventArgs) _
    '              Handles AsyncFileUpload1.UploadedFileError

    '    Dim myScript = "top.$get('" & msgServerSide.ClientID & _
    '    "').innerHTML = 'Error: " & e.statusMessage & "';"
    '    ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "error", myScript, True)

    'End Sub
End Class
