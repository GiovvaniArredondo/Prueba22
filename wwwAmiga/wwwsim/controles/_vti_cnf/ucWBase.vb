Public Class ucWBase
    Inherits System.Web.UI.UserControl

    Public Overridable Function Inicializar()

    End Function

    Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal EsError As Boolean = False, Optional ByVal MensajeJava As Boolean = False)
        Dim myLabel As Label

        myLabel = Page.FindControl("Encabezado1").FindControl("Label_Mensaje")

        If myLabel Is Nothing Then Return

        If EsError Then
            myLabel.CssClass = "MensajeError"
        Else
            myLabel.CssClass = "MensajeInformativo"
        End If

        myLabel.Text = asMensaje

        If MensajeJava Then
            If EsError Then
                Response.Write("<script language='javascript'>alert('" & asMensaje & " Por Favor contactar a Soporte Tecnico.')</script>")
            Else
                Response.Write("<script language='javascript'>alert('" & asMensaje & "')</script>")
            End If
        End If
    End Sub

    Public Function ObtenerUsuario() As String
        Return "usuario"
    End Function

    Public Sub LimpiarControles()
        Dim liCntrl As Integer
        Dim Cntrl As System.Web.UI.WebControls.TextBox
        Dim DDL As System.Web.UI.WebControls.DropDownList

        For liCntrl = 0 To Me.Controls.Count - 1
            Select Case Me.Controls(liCntrl).GetType().ToString
                Case "System.Web.UI.WebControls.TextBox"
                    Cntrl = CType(Me.Controls(liCntrl), TextBox)
                    If Cntrl.Visible Then Cntrl.Text = ""
                Case "System.Web.UI.WebControls.DropDownList"
                    Dim li As System.Web.UI.WebControls.ListItem
                    ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                    DDL = CType(Me.Controls(liCntrl), DropDownList)
                    li = DDL.Items.FindByValue("0")

                    If Not li Is Nothing Then DDL.SelectedValue = "0"
            End Select

            If InStr(Me.Controls(liCntrl).GetType().ToString, "ucDDL") > 0 Then
                Dim li As System.Web.UI.WebControls.ListItem
                ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                DDL = CType(Me.Controls(liCntrl), DropDownList)
                li = DDL.Items.FindByValue("0")

                If Not li Is Nothing Then DDL.SelectedValue = "0"
            End If
        Next
    End Sub

    Public Function ObtenerIdOng() As Double
        Return CDbl(HttpContext.Current.Items("idOng"))
    End Function
End Class
