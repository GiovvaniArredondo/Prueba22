Public Class CbxCtaAho
    Inherits System.Web.UI.WebControls.DropDownList

    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista(ByVal cnudotr As String)
        Dim miComponente As New cAhomcta
        Dim ds As New DataSet

        ds = miComponente.Extraer_ctas_Ahorro_Socio_(cnudotr)

        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If

        Me.DataTextField = "cdescri"
        Me.DataValueField = "ccodaho"
        Me.DataSource = ds.Tables(0)
        Me.DataBind()

    End Sub

    Public Sub Recuperar(ByVal cnudotr As String)
        RecuperarLista(cnudotr)
    End Sub
End Class
