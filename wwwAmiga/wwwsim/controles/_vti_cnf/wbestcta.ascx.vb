Public Class wbestcta
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents btnBuscar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents Button1 As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents TabStrip1 As Microsoft.Web.UI.WebControls.TabStrip
    Protected WithEvents txtCodCta As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtCodCli As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Protected WithEvents DgCreditos1 As dgCreditos
    Protected WithEvents DgHistorialCreditos1 As dgHistorialCreditos
    Protected WithEvents DgKardex1 As dgKardex
    Private ccodcta As String

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        ccodcta = ViewState("ccodcta")
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.DgCreditos1.Visible = True
            Me.DgHistorialCreditos1.Visible = False
            Me.DgKardex1.Visible = False
            Return
        End If
        If Me.ccodcta = "" And TabStrip1.SelectedIndex > 0 Then
            TabStrip1.SelectedIndex = 0
            Return
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.DgCreditos1.Visible = False
            Me.DgHistorialCreditos1.Visible = True
            Me.DgKardex1.Visible = False
            Me.DgHistorialCreditos1.CargarDatosPorCuenta(Me.ccodcta)
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.DgCreditos1.Visible = False
            Me.DgHistorialCreditos1.Visible = False
            Me.DgKardex1.Visible = True
            Me.DgKardex1.CargarDatosPorCuenta(Me.ccodcta)
        End If

    End Sub

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.ServerClick
        If Me.txtCodCta.Text <> "" Then
            Me.DgCreditos1.CargarDatosPorCuenta(Me.txtCodCta.Text)
            Return
        End If
        If Me.txtCodCli.Text <> "" Then
            Me.DgCreditos1.CargarDatosPorCliente(Me.txtCodCli.Text)
            Return
        End If
    End Sub

    Private Sub DgCreditos1_SeleccionarCuenta(ByVal codcta As String) Handles DgCreditos1.SeleccionarCuenta
        If ViewState("ccodcta") Is Nothing Then
            ViewState.Add("ccodcta", codcta)
        Else
            ViewState("ccodcta") = codcta
        End If
        '        Me.txtcliente.Text = viewstate("ccodcta")
    End Sub
End Class
