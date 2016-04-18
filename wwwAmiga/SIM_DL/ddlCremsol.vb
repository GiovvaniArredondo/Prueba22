Imports System.ComponentModel
Imports System.Web.UI
 
<DefaultProperty("cCodsol"), ToolboxData("<{0}:ddlCremsol runat=server></{0}:ddlCremsol>")> _
Public Class ddlCremsol
    Inherits System.Web.UI.WebControls.DropDownList
 
    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler
 
    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Private Sub RecuperarLista()
        Dim miComponente As New cCremsol
        Dim Lista As New listaCremsol
 
        Lista = miComponente.ObtenerLista()
        If Not Lista.Count > 0 Then
            Return
        End If
 
        Me.DataSource = Lista
        Me.DataTextField = "cnomgru"
        Me.DataValueField = "cCodsol"
 
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
