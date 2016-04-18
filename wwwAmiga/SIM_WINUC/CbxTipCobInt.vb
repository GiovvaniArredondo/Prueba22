Public Class CbxTipCobInt
    Inherits System.Web.UI.WebControls.DropDownList


    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista()
        Dim miComponente As New cTabttab
        Dim Lista As New listatabttab

        Lista = miComponente.ObtenerLista("231", "1")
        If Not Lista.Count > 0 Then
            Return
        End If

        Me.DataTextField = "cdescri"
        Me.DataValueField = "ccodigo"
        Me.DataSource = Lista
        Me.DataBind()

    End Sub

    Public Sub Recuperar()
        RecuperarLista()
    End Sub
End Class


