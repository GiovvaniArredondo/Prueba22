

Partial Class wbretaho
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
     
    End Sub

    Private Sub Cuwbusaho1_Seleccionado(ByVal codigoCliente As String) Handles Cuwbusaho1.Seleccionado
        ucretiroaho1.CargarDatosPorCuenta(codigoCliente)
        Me.TabContainer1.ActiveTabIndex = 1
    End Sub
End Class


