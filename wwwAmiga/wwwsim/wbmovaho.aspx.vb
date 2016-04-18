

Partial Class wbmovaho
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Me.Cuwbusaho1.Visible = True
            'Me.Ucdepaho1.Visible = False
            'Me.Uchisaho1.Visible = False
        End If
    End Sub
    'Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
    '    If TabStrip1.SelectedIndex = 0 Then
    '        Me.Cuwbusaho1.Visible = True
    '        Me.ucdepaho1.Visible = False
    '        Me.Uchisaho1.Visible = False

    '    End If
    '    If TabStrip1.SelectedIndex = 1 Then
    '        Me.Cuwbusaho1.Visible = False
    '        Me.ucdepaho1.Visible = True
    '        Me.Uchisaho1.Visible = False

    '    End If
    '    If TabStrip1.SelectedIndex = 2 Then
    '        Me.Cuwbusaho1.Visible = False
    '        Me.Ucdepaho1.Visible = False
    '        Me.Uchisaho1.Visible = True

    '    End If

    'End Sub

    Private Sub Cuwbusaho1_Seleccionado(ByVal codigoCliente As String) Handles Cuwbusaho1.Seleccionado
        ucdepaho1.CargarDatosPorCuenta(codigoCliente)
        Me.TabContainer1.ActiveTabIndex = 1
    End Sub
End Class


