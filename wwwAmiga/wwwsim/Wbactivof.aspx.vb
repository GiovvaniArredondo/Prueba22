Public Class Wbactivof
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
            WbActivoCont1.Visible = True
            WbFindActivoF1.Visible = False
            Me.WbActivoRp1.Visible = False
            WbActivoTraslados1.Visible = False
            WbDeprecia2.Visible = False
            WbActivoTarjetas2.Visible = False
            Session.Add("codigocli", "")
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            WbActivoCont1.Visible = True
            WbFindActivoF1.Visible = False
            Me.WbActivoRp1.Visible = False
            WbActivoTraslados1.Visible = False
            WbDeprecia2.Visible = False
            WbActivoTarjetas2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            WbActivoCont1.Visible = False
            Me.WbActivoRp1.Visible = True
            WbFindActivoF1.Visible = False
            WbActivoTraslados1.Visible = False
            WbDeprecia2.Visible = False
            WbActivoTarjetas2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            WbActivoCont1.Visible = False
            Me.WbActivoRp1.Visible = False
            WbFindActivoF1.Visible = True
            WbActivoTraslados1.Visible = False
            WbDeprecia2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            WbActivoTraslados1.Visible = True
            WbActivoCont1.Visible = False
            Me.WbActivoRp1.Visible = False
            WbFindActivoF1.Visible = False
            WbDeprecia2.Visible = False
            WbActivoTarjetas2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 4 Then
            WbActivoTraslados1.Visible = False
            WbActivoCont1.Visible = False
            Me.WbActivoRp1.Visible = False
            WbFindActivoF1.Visible = False
            WbActivoTarjetas2.Visible = False
            WbDeprecia2.Visible = True
        End If
        If TabStrip1.SelectedIndex = 5 Then
            WbActivoTarjetas2.Visible = True
            WbActivoTraslados1.Visible = False
            WbActivoCont1.Visible = False
            Me.WbActivoRp1.Visible = False
            WbFindActivoF1.Visible = False
            WbDeprecia2.Visible = False
        End If
    End Sub

    Private Sub WbFindActivoF1_Seleccionado(ByVal codigoCliente As String) Handles WbFindActivoF1.Seleccionado
        TabStrip1.SelectedIndex = 0
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WbActivoCont1.CargarActivoDetalle(codigoCliente)
        WbActivoCont1.CargarDetalleActivoIT(codigoCliente)
    End Sub
End Class

