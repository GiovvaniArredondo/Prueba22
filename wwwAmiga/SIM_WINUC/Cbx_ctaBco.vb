Public Class Cbx_ctaBco
    Inherits System.Web.UI.WebControls.DropDownList

    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista(ByVal pcCodbco As String)
        Dim miComponente As New cTabtbco
        Dim ds As New DataSet

        ds = miComponente.Extrae_Ctas_Bancarias(pcCodbco)
        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If

        Me.DataTextField = "cnombco1"
        Me.DataValueField = "ccodbco"
        Me.DataSource = ds.Tables(0)
        Me.DataBind()

    End Sub

    Public Sub Recuperar(ByVal pcCodbco As String)
        RecuperarLista(pcCodbco)
    End Sub
End Class
