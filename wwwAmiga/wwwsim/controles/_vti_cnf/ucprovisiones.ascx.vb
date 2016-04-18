Public Class ucprovisiones
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents btnsalir As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btncertificados As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btnaportaciones As System.Web.UI.HtmlControls.HtmlInputButton

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Private Sub btnaportaciones_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaportaciones.ServerClick
        Response.Redirect("ucprovaporta.ascx")
    End Sub

    Private Sub btncertificados_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncertificados.ServerClick
        Response.Redirect("ucprovpla.asx")
        Response.Redirect("ucprovpla.ascx")

    End Sub
End Class
