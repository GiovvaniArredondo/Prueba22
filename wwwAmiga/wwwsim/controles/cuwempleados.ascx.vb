Public Class cuwempleados
    Inherits System.Web.UI.UserControl
    Private clsppal As New class1
#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    
    Protected WithEvents txtdfecpre As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtnnumpre As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtdfecins As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtnnumins As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcobservar As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcnomcli As System.Web.UI.WebControls.TextBox
    

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
#Region " Variables "
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
#End Region
#Region "Propiedades "
    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

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
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.txtdfecha.Text = Session("gdfecsis")
            Cargardatos()
        End If
    End Sub
    Public Sub Cargardatos()
        Dim dsempl As New DataSet

        Dim eempleados As New cEmpleados
        dsempl = eempleados.ObtenerDataSetPorID()

        Dim fila As DataRow
        Dim elemento As Integer = 0
        Dim nsalario As Double
        Dim ncomision As Double
        Dim notros As Double
        Dim ncelular As Double
        Dim nboni As Double

        For Each fila In dsempl.Tables(0).Rows
            nsalario = IIf(IsDBNull(dsempl.Tables(0).Rows(elemento)("nsalario")), 0, dsempl.Tables(0).Rows(elemento)("nsalario"))
            ncomision = IIf(IsDBNull(dsempl.Tables(0).Rows(elemento)("ncomision")), 0, dsempl.Tables(0).Rows(elemento)("ncomision"))
            notros = IIf(IsDBNull(dsempl.Tables(0).Rows(elemento)("notros")), 0, dsempl.Tables(0).Rows(elemento)("notros"))
            ncelular = IIf(IsDBNull(dsempl.Tables(0).Rows(elemento)("ncelular")), 0, dsempl.Tables(0).Rows(elemento)("ncelular"))
            nboni = IIf(IsDBNull(dsempl.Tables(0).Rows(elemento)("nboni")), 0, dsempl.Tables(0).Rows(elemento)("nboni"))
            dsempl.Tables(0).Rows(elemento)("ntotal") = nsalario + ncomision + nboni
            elemento += 1
        Next
        Me.Datagrid1.DataSource = dsempl
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtdfecpre.Text = ""
        Me.txtdfecins.Text = ""
        Me.txtnnumpre.Text = ""
        Me.txtnnumins.Text = ""
        Me.txtcobservar.Text = ""

        Dim eclimgar As New cClimgar
        Dim dship As New DataSet
        Dim ncanti As Integer
        dship = eclimgar.ClimHip(codigoCliente)
        ncanti = dship.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.txtccodcta.Text = codigoCliente
        Me.TxtCodigo.Text = dship.Tables(0).Rows(0)("ccodcli")
        Me.Datagrid1.DataSource = dship
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
        dship.Tables.Clear()
        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.TxtCodigo.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim
    End Sub


    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        Dim ds As New DataSet
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        Me.TxtComodin.Text = Me.ClienteSeleccionado

        '-----------------------------------------------------
        'Trae toda la informacion de la Garantia
        '-----------------------------------------------------
        ds = Me.BuscaEmpleado(Me.TxtComodin.Text.Trim)

        Dim ncanti As Integer

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub        'Hubo un error Depurar
        End If

        
        Me.txtcnomemp.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("cnomemp")), "", ds.Tables(0).Rows(0)("cnomemp"))
        Me.txtncomision.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("ncomision")), 0, ds.Tables(0).Rows(0)("ncomision"))
        Me.txtnotros.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("notros")), 0, ds.Tables(0).Rows(0)("notros"))
        Me.txtntelefono.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("ncelular")), 0, ds.Tables(0).Rows(0)("ncelular"))
        Me.txtnboni.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nboni")), 0, ds.Tables(0).Rows(0)("nboni"))

        Me.btngraba.Disabled = False
        'Me.Habilita()
    End Sub

    Public Function BuscaEmpleado(ByVal cCodigo As String) As DataSet
        Dim ds As New DataSet

        'Nombre del Cliente
        Dim entidadempleados As New SIM.EL.empleados
        Dim eempleados As New SIM.BL.cEmpleados

        ds = eempleados.ObtenerDataSetPorID1(cCodigo)

        Return ds
    End Function

    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick

        'Verifica si existe tabla
        Dim lcnombre As String
        Dim lcdia As String
        Dim lcmes As String
        Dim lcaño As String
        Dim lnverifica As Integer
        Dim eempleados As New cEmpleados


        lcdia = Me.txtdfecha.Text.Trim.Substring(0, 2)
        lcmes = Me.txtdfecha.Text.Trim.Substring(3, 2)
        lcaño = Me.txtdfecha.Text.Trim.Substring(6, 4)
        lcnombre = "Emp" & lcdia & lcmes & lcaño

        lnverifica = eempleados.VerificaHistorico(lcnombre)
        If lnverifica = 0 Then 'Agrega
            eempleados.CreaTablaHistorica(lcnombre)
        End If

        'Realiza Calculos
        Dim fila As DataRow
        Dim ele As Integer
        Dim ds As New DataSet
        ds = eempleados.ObtenerDataSetPorID()

        'variables 
        Dim pid As Integer
        Dim pncomision As Double
        Dim pnsueldo As Double
        Dim pnisss As Double
        Dim pnafp As Double
        Dim pnisr As Double
        Dim pnissspat As Double
        Dim pnafppat As Double
        Dim pnotros As Double
        Dim pnboni As Double

        Dim pncelular As Double

        Dim lntotal As Double

        Dim etabttab As New cTabttab
        Dim dstmp As New DataSet

        Dim lnporafp As String
        For Each fila In ds.Tables(0).Rows
            pid = ds.Tables(0).Rows(ele)("Id")
            pnsueldo = IIf(IsDBNull(ds.Tables(0).Rows(ele)("nsalario")), 0, ds.Tables(0).Rows(ele)("nsalario"))
            pncomision = IIf(IsDBNull(ds.Tables(0).Rows(ele)("ncomision")), 0, ds.Tables(0).Rows(ele)("ncomision"))
            pnotros = IIf(IsDBNull(ds.Tables(0).Rows(ele)("notros")), 0, ds.Tables(0).Rows(ele)("notros"))
            pncelular = IIf(IsDBNull(ds.Tables(0).Rows(ele)("ncelular")), 0, ds.Tables(0).Rows(ele)("ncelular"))
            pnboni = IIf(IsDBNull(ds.Tables(0).Rows(ele)("nboni")), 0, ds.Tables(0).Rows(ele)("nboni"))

            lntotal = pnsueldo + pncomision + pnboni

            dstmp = etabttab.ObtenerDataSetPorID2("081", "1", ds.Tables(0).Rows(ele)("cafp"))
            If dstmp.Tables(0).Rows.Count = 0 Then
                lnporafp = 0
            Else
                lnporafp = dstmp.Tables(0).Rows(0)("nnumtab")
            End If
            pnafp = utilNumeros.Redondear(lntotal * lnporafp / 100, 2)
            pnisss = utilNumeros.Redondear(lntotal * 3 / 100, 2)
            If pnisss > 20.57 Then
                pnisss = 20.57
            End If
            pnisr = clsppal.Renta(lntotal - pnafp)

            pnissspat = utilNumeros.Redondear(lntotal * 7.5 / 100, 2)
            If pnissspat > 51.43 Then
                pnissspat = 51.43
            End If

            pnafppat = utilNumeros.Redondear(lntotal * 6.75 / 100, 2)

            eempleados.InsertaTablaHistorica(lcnombre, pid, pncomision, pnsueldo, pnisss, pnafp, pnisr, pnissspat, pnafppat, lntotal, lnverifica, pnotros, pncelular, pnboni)
            ele += 1
        Next
        Response.Write("<script language='javascript'>alert('Planilla Almacenada')</script>")
        Me.btngraba.Disabled = True

    End Sub
    Sub RefrescaGrid()
        CargarPorCliente(Me.txtccodcta.Text.Trim)
    End Sub

    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Me.txtcnomemp.Text = ""
        Me.txtncomision.Text = ""
        Me.txtnboni.Text = ""
        Me.txtntelefono.Text = ""

    End Sub

    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        Dim dsempl As New DataSet
        Dim eempleados As New cEmpleados
        Dim entidadempleados As New empleados

        entidadempleados.id = Me.TxtComodin.Text.Trim
        entidadempleados.ncomision = Double.Parse(Me.txtncomision.Text)
        entidadempleados.notros = Double.Parse(Me.txtnotros.Text)
        entidadempleados.ncelular = Double.Parse(Me.txtntelefono.Text)
        entidadempleados.nbonificacion = Double.Parse(Me.txtnboni.Text)

        eempleados.Actualizar(entidadempleados)

        Me.Cargardatos()

        Me.txtcnomemp.Text = ""
        Me.txtncomision.Text = ""
        Me.txtnotros.Text = ""
        Me.txtnboni.Text = ""

    End Sub

End Class
