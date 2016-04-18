

Partial Class Wbctaaho
    Inherits System.Web.UI.Page
  
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.WbFind1.Visible = True
            Me.Ucctaaho1.Visible = False
            Me.Ucbenaho1.Visible = False
            Me.Cuwbusaho1.Visible = False
            Me.CuwFirmas1.Visible = False
            '    Me.WbContratoAho1.Visible = False
            Session("codigo") = ""
        End If
    End Sub

    Private Sub TabStrip1_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStrip1.SelectedIndexChange
        If TabStrip1.SelectedIndex = 0 Then
            Me.wbfind1.Visible = True
            Me.ucctaaho1.Visible = False
            Me.ucbenaho1.Visible = False
            Me.Cuwbusaho1.Visible = False
            Me.CuwFirmas1.Visible = False
            '   Me.WbContratoAho1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 1 Then
            Me.wbfind1.Visible = False
            Me.ucctaaho1.Visible = True
            Me.ucbenaho1.Visible = False
            Me.Cuwbusaho1.Visible = False
            Me.CuwFirmas1.Visible = False
            '  Me.WbContratoAho1.Visible = False
        End If
        If TabStrip1.SelectedIndex = 2 Then
            Me.wbfind1.Visible = False
            Me.ucctaaho1.Visible = False
            Me.ucbenaho1.Visible = True
            Me.Cuwbusaho1.Visible = False
            Me.CuwFirmas1.Visible = False
            ' Me.WbContratoAho1.Visible = False
            Ucbenaho1.CargarPorcuentahorro(Session("codigo"))

        End If
        If TabStrip1.SelectedIndex = 3 Then
            Me.WbFind1.Visible = False
            Me.Ucctaaho1.Visible = False
            Me.Ucbenaho1.Visible = False
            Me.Cuwbusaho1.Visible = False
            Me.CuwFirmas1.Visible = True
            'Me.WbContratoAho1.Visible = False
            CuwFirmas1.CargarPorcuentahorro(Session("codigo"))

        End If
        'If TabStrip1.SelectedIndex = 4 Then
        '    Me.WbFind1.Visible = False
        '    Me.Ucctaaho1.Visible = False
        '    Me.Ucbenaho1.Visible = False
        '    Me.Cuwbusaho1.Visible = False
        '    Me.CuwFirmas1.Visible = False
        '    'Me.WbContratoAho1.Visible = True
        '    'WbContratoAho1.CargarPorcuentahorro(Session("codigo"))

        'End If

        If TabStrip1.SelectedIndex = 4 Then
            Me.WbFind1.Visible = False
            Me.Ucctaaho1.Visible = False
            Me.Ucbenaho1.Visible = False
            Me.Cuwbusaho1.Visible = True
            Me.CuwFirmas1.Visible = False
            ' Me.WbContratoAho1.Visible = False
        End If

    End Sub

    Private Sub wbfind1_Seleccionado(ByVal codigoCliente As String) Handles wbfind1.Seleccionado
        If TabStrip1.SelectedIndex = 1 Then
            TabStrip1.SelectedIndex = 2
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            ucbenaho1.CargarPorCliente(codigoCliente)
        End If

        If TabStrip1.SelectedIndex = 0 Then
            TabStrip1.SelectedIndex = 1
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            ucctaaho1.CargarPorcliente(codigoCliente)
        End If

    End Sub

    Private Sub Cuwbusaho1_Seleccionado(ByVal cuentadeahorro As String) Handles Cuwbusaho1.Seleccionado
        If TabStrip1.SelectedIndex = 4 Then
            TabStrip1.SelectedIndex = 2
            TabStrip1_SelectedIndexChange(TabStrip1, New System.EventArgs)
            Ucbenaho1.CargarPorcuentahorro(Session("codigo"))
            CuwFirmas1.CargarPorcuentahorro(Session("codigo"))
            'WbContratoAho1.CargarPorcuentahorro(Session("codigo"))
        End If
    End Sub

End Class


