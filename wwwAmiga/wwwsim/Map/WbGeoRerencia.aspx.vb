
Partial Class Map_WbGeoRerencia
    Inherits System.Web.UI.Page

#Region "Privadas"
    Dim codigoJs As String
#End Region

    Private Sub wucGeoReferencia_Seleccionado(ByVal lat As String, ByVal Lng As String) Handles wucGeoReferencia1.Seleccionado
        codigoJs = "<script language='JavaScript'>" & _
                   " var str1 = '" & lat & "';" & _
                   " var str2 = '" & Lng & "';" & _
                   " var str3 = '';" & _
                   " var str4 = '';" & _
                   " var str5 = '';" & _
                   " var str6 = '';" & _
                   " var ArgumentosAEnviar = new Array(str1, str2, str3, str4, str5, str6);" & _
                   " window.returnValue = ArgumentosAEnviar;" & _
                   " window.close();" & _
                   "close();</script>"


        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Devolver", codigoJs, False)

    End Sub

End Class
