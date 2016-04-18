Public Class CbxLinAhoProd
    Inherits System.Web.UI.WebControls.DropDownList

    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista(ByVal producto As String)
        Dim miComponente As New cAhotlin
        Dim ds As New DataSet

        ds = miComponente.Extraer_Lineas_Producto(producto)

        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If
        Me.DataTextField = "cdeslin"
        Me.DataValueField = "cnrolin"
        Me.DataSource = ds.Tables(0)
        Me.DataBind()

    End Sub

    Public Sub Recuperar(ByVal producto As String)
        RecuperarLista(producto)
    End Sub
End Class
