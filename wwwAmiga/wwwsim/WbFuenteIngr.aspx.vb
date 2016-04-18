

Partial Class WbFuenteIngr
    Inherits System.Web.UI.Page

    '  Protected WithEvents Wbusbalance2 As WbUsBalance

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IN", 3)
            Me.WbFind1.Visible = True
            Me.WbUsFueFam1.Visible = False
            Me.WbUsFueDep1.Visible = False
            Me.WbUsFueInd1.Visible = False
            WbUsFueAgro1.Visible = False
            '            Me.WbUsBalance1.Visible = False
        End If
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then 'Busqueda
            Me.WbFind1.Visible = True
            Me.WbUsFueFam1.Visible = False
            Me.WbUsFueDep1.Visible = False
            Me.WbUsFueInd1.Visible = False
            WbUsFueAgro1.Visible = False
            '           Me.WbUsBalance1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then 'Fuente Familiar
            Me.WbFind1.Visible = False
            Me.WbUsFueFam1.Visible = False
            Me.WbUsFueDep1.Visible = False
            Me.WbUsFueInd1.Visible = True
            '          Me.WbUsBalance1.Visible = False
            WbUsFueAgro1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then 'Fuente Dependiente
            Me.WbFind1.Visible = False
            Me.WbUsFueFam1.Visible = False
            Me.WbUsFueDep1.Visible = True
            Me.WbUsFueInd1.Visible = False
            '         Me.WbUsBalance1.Visible = False
            WbUsFueAgro1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 3 Then 'Fuente Independiente
            WbUsFueAgro1.Visible = False
            Me.WbFind1.Visible = False
            Me.WbUsFueFam1.Visible = True
            Me.WbUsFueDep1.Visible = False
            Me.WbUsFueInd1.Visible = False
            '        Me.WbUsBalance1.Visible = False

        End If
        If TabStrip1.SelectedIndex = 4 Then 'Balance
            Me.WbFind1.Visible = False
            Me.WbUsFueFam1.Visible = False
            Me.WbUsFueDep1.Visible = False
            Me.WbUsFueInd1.Visible = False
            '       Me.WbUsBalance1.Visible = True
            WbUsFueAgro1.Visible = True
        End If
      
    End Sub


    Private Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado
        TabStrip1.SelectedIndex = 1
        TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
        Me.WbUsFueFam1.CargarPorCliente(codigoCliente) 'Familiares
        Me.WbUsFueFam1.FuentesFamiliares(codigoCliente) 'Grid familiar
        Me.WbUsFueDep1.CargarPorCliente(codigoCliente) 'Dependientes
        Me.WbUsFueDep1.FuentesDepen(codigoCliente)     'Grid Dependientes
        Me.WbUsFueInd1.CargarPorCliente(codigoCliente) 'Independientes
        Me.WbUsFueInd1.FuentesInDepen(codigoCliente)   'Grid Independientes
        WbUsFueAgro1.CargarPorCliente(codigoCliente)
        WbUsFueAgro1.FuentesInDepen(codigoCliente)
    End Sub

End Class


