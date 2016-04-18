

Partial Class wbmovimientos
    Inherits System.Web.UI.Page


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WbUCFindCred1.Visible = True
            Me.ucestadocta11.Visible = False
            Me.DgHistorialCreditos1.Visible = False
            wbsaldo1.Visible = False
        End If
    End Sub
    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.WbUCFindCred1.Visible = True
            Me.ucestadocta11.Visible = False
            Me.DgHistorialCreditos1.Visible = False
            wbsaldo1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.WbUCFindCred1.Visible = False
            Me.ucestadocta11.Visible = True
            Me.DgHistorialCreditos1.Visible = False
            wbsaldo1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.WbUCFindCred1.Visible = False
            Me.ucestadocta11.Visible = False
            Me.DgHistorialCreditos1.Visible = True
            wbsaldo1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.WbUCFindCred1.Visible = False
            Me.ucestadocta11.Visible = False
            Me.DgHistorialCreditos1.Visible = False
            wbsaldo1.Visible = True
        End If


    End Sub

    Private Sub WbUCFindCred1_Seleccionado(ByVal codigoCliente As String) Handles WbUCFindCred1.Seleccionado
        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            ucestadocta11.CargarDatosPorCuenta(codigoCliente)
            wbsaldo1.CargarPorCliente(codigoCliente)
        End If
        If TabStrip1.SelectedIndex = 1 Then
            'TabStrip1.SelectedIndex = 2
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            dgHistorialCreditos1.CargarDatosPorCuenta(codigoCliente)
        End If


    End Sub
End Class


