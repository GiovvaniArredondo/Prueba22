

Partial Class DetaMantCremcre
    Inherits System.Web.UI.Page
    Private mComponente As New cCremcre

 
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            Me.BarraNavegacion1.Navegacion = False
            Me.BarraNavegacion1.PermitirAgregar = False
            Me.BarraNavegacion1.PermitirEditar = True
            Me.BarraNavegacion1.HabilitarEdicion(True)
            Dim lId As String = Request.QueryString("id")
            Me.VistaDetalleCremcre1.Enabled = True
            Me.VistaDetalleCremcre1.ccodcta = lId
        End If
    End Sub
 
    Private Sub BarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraNavegacion1.Cancelar
        Response.Redirect("MantCremcre.aspx")
    End Sub
 
    Private Sub BarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.VistaDetalleCremcre1.Actualizar()
        If sError <> "" Then
            'Mostrar mensaje de error contenido en sError
            Return
        End If
        Response.Redirect("MantCremcre.aspx")
    End Sub
 
    Private Sub VistaDetalleCremcre1_ErrorEvent(ByVal errorMessage As String) Handles VistaDetalleCremcre1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
    End Sub
End Class


