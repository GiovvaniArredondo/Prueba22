Imports System.ComponentModel
Imports System.Web.UI
 
<DefaultProperty("ccodigo"), ToolboxData("<{0}:ddlTabtciu runat=server></{0}:ddlTabtciu>")> _
Public Class ddlTabtciu
    Inherits System.Web.UI.WebControls.DropDownList
 
    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler
 
    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Private Sub RecuperarLista()
        Dim miComponente As New cTabtciu
        Dim Lista As New listaTabtciu
 
        Lista = miComponente.ObtenerLista()
        If Not Lista.Count > 0 Then
            Return
        End If
 
        Me.DataSource = Lista
        Me.DataTextField = "cdescri"
        Me.DataValueField = "ccodigo"
 
        Me.DataBind()
    End Sub
 
    Public Sub Recuperar()
        RecuperarLista()
    End Sub
 
    Protected Overrides Sub OnInit(ByVal e As System.EventArgs)
        Me.RecuperarLista()
        MyBase.OnInit(e)
    End Sub
End Class
