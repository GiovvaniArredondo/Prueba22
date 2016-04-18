Public Class WbEmpleados
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
  

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
        If Not IsPostBack Then
            Me.cuwempleados1.Visible = True
            Me.cuwplanillas1.Visible = False
            Me.cuwplanictb1.Visible = False
        End If
    End Sub
    '
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.cuwempleados1.Visible = True
            Me.cuwplanillas1.Visible = False
            Me.cuwplanictb1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.cuwempleados1.Visible = False
            Me.cuwplanillas1.Visible = True
            Me.cuwplanictb1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.cuwempleados1.Visible = False
            Me.cuwplanillas1.Visible = False
            Me.cuwplanictb1.Visible = True
        End If

    End Sub
End Class
