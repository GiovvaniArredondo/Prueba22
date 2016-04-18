Public Class WbSugInd
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents TabStrip1 As Microsoft.Web.UI.WebControls.TabStrip
    Protected WithEvents TD1 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD2 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD3 As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TD4 As System.Web.UI.HtmlControls.HtmlTableCell

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
    Protected WithEvents WUCFindCre1 As WUCFindCre
    Protected WithEvents CUWSugInd1 As CUWSugInd
    Protected WithEvents CuwPlan1 As CuwPlan
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WUCFindCre1.Visible = True
            Me.CUWSugInd1.Visible = False
            Me.CuwPlan1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.CUWSugInd1.Visible = False
            Me.WUCFindCre1.Visible = True
            Me.CuwPlan1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.CUWSugInd1.Visible = True
            Me.WUCFindCre1.Visible = False
            Me.CuwPlan1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.CUWSugInd1.Visible = False
            Me.WUCFindCre1.Visible = False
            Me.CuwPlan1.Visible = True
        End If

    End Sub

    Private Sub WUCFindCre1_Seleccionado(ByVal codigoCliente As String) Handles WUCFindCre1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWSugInd1.CargarPorCliente(codigoCliente)
    End Sub

End Class
