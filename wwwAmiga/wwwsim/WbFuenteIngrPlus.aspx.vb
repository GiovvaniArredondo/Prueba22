
Partial Class WbFuenteIngrPlus
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        'If Not IsPostBack Then
        '    Me.TabContainer1.ActiveTabIndex = 0
        'Else
        '    Me.TabContainer1.ActiveTabIndex = TabContainer1.TabIndex
        'End If

        ' problem with TabPanel not setting to current TabPanel after a PostBack
        ' http://forums.asp.net/t/1106477.aspx?View=Flat
        If Not Request.Params("__EVENTTARGET") Is Nothing Then

            Dim control As String = Request.Params("__EVENTTARGET")

            Dim i As Integer
            For i = 0 To TabContainer1.Tabs.Count - 1 Step i + 1
                If (control.Contains(TabContainer1.Tabs(i).UniqueID + "$")) Then
                    TabContainer1.ActiveTabIndex = i
                End If
            Next

        End If

    End Sub

    Protected Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado        
        Me.WbUsFueFam1.CargarPorCliente(codigoCliente) 'Familiares
        Me.WbUsFueFam1.FuentesFamiliares(codigoCliente) 'Grid familiar
        Me.WbUsFueDep1.CargarPorCliente(codigoCliente) 'Dependientes
        Me.WbUsFueDep1.FuentesDepen(codigoCliente)     'Grid Dependientes
        Me.WbUsFueInd1.CargarPorCliente(codigoCliente) 'Independientes
        Me.WbUsFueInd1.FuentesInDepen(codigoCliente)   'Grid Independientes
        Me.TabContainer1.ActiveTabIndex = 1


    End Sub


    Protected Sub WbUsFueInd1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles WbUsFueInd1.Load        
    End Sub

End Class
