

Partial Class WbSugLote
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim ngrav As Double
            Session("CodigoCre") = ""
            Session.Add(ngrav, 0)

            Me.WFindCreGB2.Visible = True
            Me.CUWSugLote3.Visible = False
            Me.CuwPlanGB2.Visible = False
            WUCGarantiasG2.Visible = False
            CuwComg2.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.CUWSugLote3.Visible = False
            Me.WFindCreGB2.Visible = True
            Me.CuwPlanGB2.Visible = False
            WUCGarantiasG2.Visible = False
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.CUWSugLote3.Visible = True
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = False
            WUCGarantiasG2.Visible = False
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.CUWSugLote3.Visible = False
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = True
            WUCGarantiasG2.Visible = False
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.CUWSugLote3.Visible = False
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = False
            WUCGarantiasG2.Visible = True
            CuwComg2.Visible = False
        End If
        If TabStrip1.SelectedIndex = 4 Then
            Me.CUWSugLote3.Visible = False
            Me.WFindCreGB2.Visible = False
            Me.CuwPlanGB2.Visible = False
            WUCGarantiasG2.Visible = False
            CuwComg2.Visible = True
        End If

    End Sub

    Private Sub WFindCreGB1_Seleccionado(ByVal codigoCliente As String) Handles WFindCreGB2.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWSugLote3.CargarPorCliente(codigoCliente)
        'WUCGarantiasG2.CargarPorCliente(codigoCliente)
        CuwComg2.CargarPorCliente(codigoCliente)
    End Sub
    '**************************************
    '20 - 07 - 2015 
    'Utiliza como intermedio para activar evento Cargar Datos en la otra Tap
    Public Sub WUCGarantiasG2_ccodsol(ByVal caputuradoCcli As String) Handles CUWSugLote3.caputurado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        WUCGarantiasG2.CargarPorCliente2(caputuradoCcli)
    End Sub
    'Calse evento intermedio
    Public Sub cambiar_taptrips(ByVal evento As String) Handles WUCGarantiasG2.cambiotabtrips
        TabStrip1.SelectedIndex = 3
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        CUWSugLote3.Cambio_tap(evento)
    End Sub

End Class


