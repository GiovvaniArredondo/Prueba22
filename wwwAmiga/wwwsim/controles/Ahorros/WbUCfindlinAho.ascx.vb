
Partial Class controles_WbUCfindlinAho
    Inherits System.Web.UI.UserControl

    Public Event Seleccionado(ByVal codigoCliente As String)

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            Me.Cargardatos()
        End If
    End Sub

    'carga elementos necesarios para la linea
    Private Sub Cargardatos()
        Dim mControl As New cAhotlin
        Dim mLista As New listaahotlin
        Dim mEntidad As New cretlin
        mLista = mControl.ObtenerLista()
        'Me.dgClientes.DataSource = mLista
        'Me.dgClientes.DataBind()
        Grid_Lineas.DataSource = mLista
        Grid_Lineas.DataBind()
    End Sub


    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
        Dim mControl As New cAhotlin
        Dim ds As New DataSet
        Dim linea As String
        linea = Me.TxtNombre.Text.Trim
        ds = mControl.ObtieneLineaAhorro_ID(Me.TxtNombre.Text.Trim)
        'Me.dgClientes.DataSource = mLista
        'Me.dgClientes.DataBind()
        Grid_Lineas.DataSource = ds.Tables(0)
        Grid_Lineas.DataBind()

    End Sub


    Protected Sub Grid_Lineas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Lineas.SelectedIndexChanged
        RaiseEvent Seleccionado(Grid_Lineas.SelectedRow.Cells(1).Text.ToString)
    End Sub

    Protected Sub Grid_Lineas_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Grid_Lineas.PageIndexChanging
        Grid_Lineas.PageIndex = e.NewPageIndex
        Call Cargardatos()
    End Sub

    Protected Sub Grid_Lineas_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Grid_Lineas.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not Grid_Lineas.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = Grid_Lineas.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(Grid_Lineas.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = Grid_Lineas.PageIndex + 1
        End If
    End Sub

    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Grid_Lineas.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Grid_Lineas.PageCount Then
                Grid_Lineas.PageIndex = iNumPag - 1
            Else
                Grid_Lineas.PageIndex = 0
            End If
        End If
        Call Cargardatos()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub


End Class
