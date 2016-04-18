

Partial Class WbFind
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
    Private clsCli As New SIM.BL.ClsFindCli
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
            '******************************************
            '21-07-2015
            'Recibe datos el nombre del cliente desde Sugerencia de credito en Grupales
            Dim valor As String = Request.QueryString("Valor")
            TxtcEvalua.Text = valor
            ViewState.Add("pagina", 1)
        End If
        Me._ClienteSeleccionado = Me.ViewState("ClienteSeleccionado")
    End Sub



#Region " Metodos de la Pagina "
    Private Sub Cargardatos()
        Dim i As Integer
        ds = clsCli.BuscaCliente(Me.TxtcEvalua.Text.Trim, Session("gnNivel"), Session("gcCodOfi"))
        i = ds.Tables(0).Rows.Count()
        If i >= 1 Then
            dgclientes.Visible = True
            Me.dgclientes.DataSource = ds.Tables(0)
            Me.dgclientes.DataBind()
        Else
            dgclientes.Visible = False
            'Response.Write("<script language='javascript'>alert('EL Cliente no Existe')</script>")
            codigoJs = "<script language='javascript'>alert('EL Cliente no Existe, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


        End If

    End Sub

#End Region



    Protected Sub dgclientes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgclientes.SelectedIndexChanged
        Dim asociado As String = dgclientes.SelectedRow.Cells(1).Text.ToString 'asociado
        'obtener la pagina desde la que es esta llamando el evento 
        RaiseEvent Seleccionado(asociado)
    End Sub
    Protected Sub dgclientes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles dgclientes.PageIndexChanging
        If Me.IsPostBack Then
            Me.dgclientes.PageIndex = 0
            Me.dgclientes.PageIndex = e.NewPageIndex
            Me.Cargardatos() 'este sería el procedimiento que se encarga de llenar tu datagrid.
        End If

    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.dgclientes.PageIndex = 0
        Cargardatos()
    End Sub


End Class





