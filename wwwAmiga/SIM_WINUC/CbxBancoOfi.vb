Public Class CbxBancoOfi
    Inherits System.Web.UI.WebControls.DropDownList

    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista()
        Dim miComponente As New cTabtbco
        Dim ds As New DataSet

        ds = miComponente.Extrae_Bancos_Oficinas()

        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If

        Me.DataTextField = "cdesbco"
        Me.DataValueField = "ccodbco"
        Me.DataSource = ds.Tables(0)
        Me.DataBind()

    End Sub

    Public Sub Recuperar()
        RecuperarLista()
    End Sub

End Class
