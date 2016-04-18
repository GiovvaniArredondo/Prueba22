Public Class CbxLinAho
    Inherits System.Web.UI.WebControls.DropDownList


    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista()
        Dim miComponente As New cAhotlin
        Dim Lista As New listaahotlin

        Lista = miComponente.ObtenerLista_Depo()
        If Not Lista.Count > 0 Then
            Return
        End If

        Me.DataTextField = "cdeslin"
        Me.DataValueField = "cnrolin"
        Me.DataSource = Lista
        Me.DataBind()

    End Sub

    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
