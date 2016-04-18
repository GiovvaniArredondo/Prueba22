
Partial Class Map_Geocoding
    Inherits System.Web.UI.Page

#Region "Privadas"
    Dim codigoJs As String = ""
#End Region


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'Establecer_Coordenadas(Session("latitud"), Session("longitud"))
            'Establecer_Coordenadas("13.6929403", "-89.21819110000001")
        End If
    End Sub


#Region "Metodos"
 
#End Region

    

    Protected Sub btnsalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        'Dim devuelveFecha As String = "<script language='JavaScript'>" & _
        '                              " var str1 = document.getElementById('<%= Lat.ClientID  %>').value;" & _
        '                              " var str2 = document.getElementById('<%= Lng.ClientID  %>').value;" & _
        '                              " var str3 = '';" & _
        '                              " var str4 = '';" & _
        '                              " var str5 = '';" & _
        '                              " var str6 = '';" & _
        '                              " var ArgumentosAEnviar = new Array(str1, str2, str3, str4, str5, str6);" & _
        '                              " window.returnValue = ArgumentosAEnviar;" & _
        '                              " window.close();" & _
        '                              "close();</script>"
        'ClientScript.RegisterStartupScript(Me.GetType(), "Devolver", devuelveFecha)

        codigoJs = "<script language='JavaScript'>" & _
                                      " var str1 = document.getElementById(document.getElementById('Lat').value;" & _
                                      " var str2 = document.getElementById(document.getElementById('Lng').value;" & _
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
