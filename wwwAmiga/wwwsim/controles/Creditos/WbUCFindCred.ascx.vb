
Partial Class controles_Creditos_WbUCFindCred
    Inherits ucWBase

#Region "Privadas"
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private ds As New System.Data.DataSet
    Private lbsim As New SIM.BL.ClsMantenimiento
    Private lbsim1 As New SIM.BL.class1
    Private Transacc As String
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Private codigoJs As String
#End Region


    Public Event Seleccionado(ByVal codigoCliente As String)


    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            '    Me.Cargardatos()
        End If
        Me._ClienteSeleccionado = Me.ViewState("ClienteSeleccionado")
    End Sub
    Protected Sub GoPage(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
                GridViewDatos.PageIndex = iNumPag - 1
            Else
                GridViewDatos.PageIndex = 0
            End If
        End If
        Call CargaGridView()
    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        'Me.dgClientes.CurrentPageIndex = 0
        'Cargagrid()
        Call CargaGridView()
    End Sub

#Region " Metodos de la Pagina "
    Private Sub Cargardatos()
        lnparametro1_R = "ccodcli as Codigo,cnomcli,"
        lnparametro4_R = "Climide"
        lnparametro5_R = "S"


        lnparametro6_R = " "

        ' Transacc = lbsim.Transac(lnparametro1_R, " ", " ", lnparametro4_R, lnparametro5_R, lnparametro6_R)
        Transacc = "Select CREMCRE.cCodCta As Codigo, CLIMIDE.cNomCli, climide.cnudoci FROM CREMCRE, CLIMIDE "
        Transacc = Transacc + " WHERE CLIMIDE.cCodCli = CREMCRE.cCodCli"
        'and CREMCRE.cEstado = 'A'

        ds = lbsim.ResulSelect(Transacc)

        'Me.dgClientes.DataSource = ds.Tables("Resultado")
        'Me.dgClientes.DataBind()

        ds.Tables.Clear()

    End Sub

#End Region

    Private Sub DtGriduser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("WbSugInd.aspx?id=0")

    End Sub


    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged
        Me.Button1_ServerClick(sender, e)
    End Sub

    Private Sub busquedaindividual()
    End Sub

    Private Sub CargaGridView()
        Try
            Dim oDataSet As New DataSet
            oDataSet = CargaDatos()

            GridViewDatos.DataSource = oDataSet
            GridViewDatos.DataBind()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Function CargaDatos() As DataSet
        Dim nombre As String
        Dim ds As DataSet
        Dim clsfind As New ccreditos
        Dim lcestado As String
        Dim lctipo As String
        Dim lcbusq As String
        Dim lcmetodologia As String
        Dim filacre As DataRow
        Dim i As Integer
        nombre = Me.TxtNombre.Text.Trim
        lcestado = " "
        lctipo = Me.rdbbusqueda.SelectedValue
        lcbusq = Me.rdbbusqueda2.SelectedValue
        lcmetodologia = Me.rdbbusqueda3.SelectedValue

        If lctipo = "Por Nombre" Then
            lctipo = "1"
        ElseIf lctipo = "Por Código" Then
            lctipo = "2"
        Else
            lctipo = "3"
        End If

        If lcbusq = "Proceso de Solicitud" Then
            lcbusq = "1"
        ElseIf lcbusq = "Proceso de Sugerencia" Then
            lcbusq = "2"
        ElseIf lcbusq = "Proceso de Autorización" Then
            lcbusq = "3"
        ElseIf lcbusq = "Vigentes" Then
            lcbusq = "4"
        ElseIf lcbusq = "Todos" Then
            lcbusq = "5"
        ElseIf lcbusq = "Proceso de Pre-Autorizado" Then
            lcbusq = "6"
        ElseIf lcbusq = "Cancelados" Then
            lcbusq = "7"
        End If

        If lcmetodologia = "Cliente" Then
            lcmetodologia = "1"
        End If

        ds = clsfind.ObtenerbusquedacreditoAmbos_(nombre, lcestado, lctipo, lcbusq, lcmetodologia, "01", Session("gcCodofi"))


        i = 0
        Dim lccodrec As String

        For Each filacre In ds.Tables(0).Rows
            lccodrec = IIf(IsDBNull(filacre("ccodrec")), "", filacre("ccodrec"))
            If lccodrec.Trim = "" Then
                If filacre("cestado") = "F" Then
                    ds.Tables(0).Rows(i)("cestado") = "VIGENTE"
                ElseIf filacre("cestado") = "A" Then
                    ds.Tables(0).Rows(i)("cestado") = "Solicitud"
                ElseIf filacre("cestado") = "C" Then
                    ds.Tables(0).Rows(i)("cestado") = "Sugerido"
                ElseIf filacre("cestado") = "D" Then
                    ds.Tables(0).Rows(i)("cestado") = "Pre-Autorizado"
                ElseIf filacre("cestado") = "E" Then
                    ds.Tables(0).Rows(i)("cestado") = "Autorizado"
                ElseIf filacre("cestado") = "G" Then
                    ds.Tables(0).Rows(i)("cestado") = "Cancelado"
                Else
                    ds.Tables(0).Rows(i)("cestado") = "Otro"
                End If

            Else
                ds.Tables(0).Rows(i)("cestado") = "Rechazado"
            End If
            i = i + 1
        Next
        Return ds
    End Function
    Protected Sub GridViewDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridViewDatos.PageIndexChanging
        GridViewDatos.PageIndex = e.NewPageIndex
        Call CargaGridView()
    End Sub
    Protected Sub GridViewDatos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridViewDatos.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridViewDatos.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridViewDatos.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridViewDatos.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridViewDatos.PageIndex + 1
        End If
    End Sub
    Protected Sub GridViewDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewDatos.SelectedIndexChanged
        Dim asociado As String = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado
        Dim ecreditos As New ccreditos
        Dim lcestatus As String
        lcestatus = ecreditos.StatusCredito(asociado)
        If lcestatus.Trim = "" Then
        Else
            '            Response.Write("<script language='javascript'>alert('Crédito Rechazado')</script>")
            codigoJs = "<script language='javascript'>alert('Documento de Identificación ya Registrado, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        RaiseEvent Seleccionado(asociado)
    End Sub

End Class
