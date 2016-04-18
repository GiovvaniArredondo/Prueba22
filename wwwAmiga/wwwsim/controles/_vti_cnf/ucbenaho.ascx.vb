Public Class ucbenaho
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtnomcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgClientes As System.Web.UI.WebControls.DataGrid
    Protected WithEvents txtcodaho As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtcodcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtbeneficiario As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlparentesco As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents txtfecnac As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents txtdirben As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents txtporcen As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcorrela As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnaplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btnadicionar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btncancela As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btncancelar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents RangeValidator6 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator5 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator

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
            cargardatos()
        End If
    End Sub

    'carga combos
    Sub cargardatos()
        Dim clscparent As New cParent
        Dim mlistaparent As New listaparent
        mlistaparent = clscparent.ObtenerLista()

        Me.ddlparentesco.DataTextField = "cdescri"
        Me.ddlparentesco.DataValueField = "cparent"
        Me.ddlparentesco.DataSource = mlistaparent
        Me.ddlparentesco.DataBind()

    End Sub

    Private Sub txtporcen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

    Public Sub CargarPorcuentahorro(ByVal ccodaho As String)
        Me.txtcodaho.Text = ccodaho
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcodcli.Text = codigoCliente.Trim

        Dim mclientes As New cClimide
        Dim eclientes As New climide
        eclientes.ccodcli = Me.txtcodcli.Text.Trim
        mclientes.ObtenerClimide(eclientes)
        Me.txtnomcli.Text = eclientes.cnomcli

    End Sub

   
    Private Sub dgClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgClientes.SelectedIndexChanged

    End Sub

    Private Sub dgClientes_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgClientes.ItemCommand
        Dim lncorrela As Integer
        If e.CommandName = "Select" Then
            lncorrela = e.Item.Cells(1).Text
            Me.txtbeneficiario.Text = e.Item.Cells(2).Text
            Me.txtcorrela.Text = lncorrela
            Me.txtdirben.Text = e.Item.Cells(3).Text
            Me.txtfecnac.Text = e.Item.Cells(4).Text
            Me.txtporcen.Text = e.Item.Cells(5).Text
            '            RaiseEvent SeleccionarCuenta(e.Item.Cells(1).Text)
        End If
    End Sub

    
    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        'procesa los certificados
        Dim eahomben As New AHOMBEN
        Dim mahomben As New cAHOMBEN
        Dim lccodaho As String
        Dim lccodcli As String
        Dim listabeneficiarios As listaAHOMBEN

        eahomben.ccodaho = Me.txtcodaho.Text.Trim
        mahomben.ObtenerAHOMBEN(eahomben)
        lccodaho = Me.txtcodaho.Text.Trim
        listabeneficiarios = mahomben.ObtenerLista(lccodaho)

        'obtiene el nombre del socio
        Dim mahomcta As New cAhomcta
        Dim eahomcta As New ahomcta
        eahomcta.ccodaho = lccodaho
        mahomcta.ObtenerAhomcta(eahomcta)
        lccodcli = eahomcta.ccodcli
        Me.txtcodcli.Text = lccodcli

        Dim mclimide As New cClimide
        Dim eclimide As New climide
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)

        Me.txtnomcli.Text = eclimide.cnomcli

        Me.dgClientes.DataSource = listabeneficiarios
        Me.dgClientes.DataBind()
        Me.txtcorrela.Text = listabeneficiarios.Count
    End Sub

    Private Sub btnadicionar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadicionar.ServerClick
        Dim eahomben As New AHOMBEN
        Dim mahomben As New cAHOMBEN

        Dim lcnombre As String
        Dim ldfecnac As Date
        Dim lnporcen As Double
        Dim lcparentesco As String
        Dim lcdirben As String
        Dim lncorrela As Integer
        Dim lccodcli As String
        lccodcli = Me.txtcodcli.Text.Trim

        Me.btnaplicar_ServerClick(sender, e)

        If Me.txtbeneficiario.Text <> Nothing And Me.txtcodaho.Text.Trim <> Nothing Then
            lncorrela = Double.Parse(Me.txtcorrela.Text.Trim) + 1
            Me.txtcorrela.Text = lncorrela.ToString
            lcnombre = Me.txtbeneficiario.Text.Trim
            ldfecnac = Date.Parse(Me.txtfecnac.Text)
            lnporcen = Double.Parse(Me.txtporcen.Text)
            lcparentesco = Me.ddlparentesco.SelectedValue
            lcdirben = Me.txtdirben.Text.Trim

            eahomben.ccodaho = Me.txtcodaho.Text.Trim
            eahomben.ncorrel = lncorrela
            eahomben.cnomben = lcnombre
            eahomben.cparent = lcparentesco
            eahomben.dfecnac = ldfecnac
            eahomben.nporcen = lnporcen
            eahomben.ccodcli = lccodcli

            eahomben.cdirben = " "
            mahomben.agregar(eahomben)

            Me.btnaplicar_ServerClick(sender, e)
            btncancelar_ServerClick(sender, e)

        End If
    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Dim Eahomben As New AHOMBEN
        Dim mahomben As New cAHOMBEN

        Eahomben.ccodaho = Me.txtcodaho.Text.Trim
        Eahomben.ncorrel = Integer.Parse(Me.txtcorrela.Text)
        Eahomben.cnomben = Me.txtbeneficiario.Text.Trim
        Eahomben.cparent = Me.ddlparentesco.SelectedValue
        Eahomben.dfecnac = Date.Parse(Me.txtfecnac.Text)
        Eahomben.nporcen = Double.Parse(Me.txtporcen.Text)
        mahomben.EliminarAHOMBEN(Eahomben)
        Me.btnaplicar_ServerClick(sender, e)
    End Sub

    Private Sub btncancelar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.ServerClick
        Me.txtbeneficiario.Text = " "
        Me.txtcorrela.Text = 0
        Me.txtdirben.Text = " "
        Me.txtfecnac.Text = " /  /"
        Me.txtporcen.Text = 0
    End Sub
End Class
