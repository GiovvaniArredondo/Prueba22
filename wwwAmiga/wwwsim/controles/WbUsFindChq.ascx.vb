Public Class WbUsFindChq
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

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
    Private cClsPart As New SIM.BL.ClsBusCatal
    Private ds As New DataSet
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event CargarPartida(ByVal codigoCliente As String)

#End Region

#Region " Propiedades "

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

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            CargarInicio()
        End If
    End Sub
    Sub CargarInicio()
        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm
        Dim ds As New DataSet
        Dim ncanti As Integer
        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.txtdfecini.Text = ds.Tables(0).Rows(0)("dFecimes")
        Me.txtdfecfin.Text = ds.Tables(0).Rows(0)("dFecfmes")

        Dim dsb As New DataSet
        Dim dsc As New DataSet


        'Informacion del Combo
        Dim clsbancos As New cTabtbco
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "*")


        Me.cmbBancos.DataTextField = "cnombco"
        Me.cmbBancos.DataValueField = "ccodbco"
        Me.cmbBancos.DataSource = dsb.Tables(0)
        Me.cmbBancos.DataBind()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RdBFind1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBFind1.CheckedChanged
        If Me.RdBFind1.Checked = True Then
            Me.RdBFind2.Checked = False
        End If
    End Sub

    Private Sub RdBFind2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBFind2.CheckedChanged
        If Me.RdBFind2.Checked = True Then
            Me.RdBFind1.Checked = False
        End If
    End Sub


    Private Sub DgPartidas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgPartidas.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.DgPartidas.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent CargarPartida(ClienteSeleccionado)
    End Sub
    Private Sub dgPartidas_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DgPartidas.PageIndexChanged
        If Me.IsPostBack Then
            Me.DgPartidas.CurrentPageIndex = 0
            Me.DgPartidas.CurrentPageIndex = e.NewPageIndex
            Me.cargadatos()
        End If
    End Sub

  

    Private Sub cargadatos()
        Dim clssconta As New clsConta
        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        Dim lccodofi As String = Session("gcCodofi")
        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig.Trim, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        Dim ldfecini As Date
        Dim ldfecfin As Date


        Dim lcbanco As String = ""
        Dim lcnrochq As String = ""

        lcbanco = IIf(CheckBox1.Checked = True, "00", cmbBancos.SelectedValue.Trim)
        lcnrochq = IIf(CheckBox2.Checked = True, "00", TextBox1.Text.Trim)

        If CheckBox3.Checked = True Then 'Buscara por fecha
            ldfecini = Date.Parse(Me.txtdfecini.Text)
            ldfecfin = Date.Parse(Me.txtdfecfin.Text)
        Else
            ldfecini = #1/1/1900#
            ldfecfin = #12/31/2020#
        End If

        If Me.RdBFind1.Checked = True Then
            ds = cClsPart.ObtenerBusquedaCheque(Session("gcfondo"), lccadena, lcbanco, lcnrochq, ldfecini, ldfecfin, 1, Me.Txtdescri.Text.Trim)
        ElseIf Me.RdBFind2.Checked = True Then
            ds = cClsPart.ObtenerBusquedaCheque(Session("gcfondo"), lccadena, lcbanco, lcnrochq, ldfecini, ldfecfin, 2, Me.Txtdescri.Text.Trim)
        ElseIf CheckBox3.Checked = True And (RdBFind1.Checked = False And RdBFind2.Checked = False And RdBFind4.Checked = False) Then
            ds = cClsPart.BuscaPartidaFechas(Date.Parse(Me.txtdfecini.Text), Date.Parse(Me.txtdfecfin.Text), Session("gcfondo"), lccadena, lccodofi)
        ElseIf Me.RdBFind4.Checked = True Then
            ds = cClsPart.ObtenerBusquedaCheque(Session("gcfondo"), lccadena, lcbanco, lcnrochq, ldfecini, ldfecfin, 3, Me.Txtdescri.Text.Trim)
        End If


        Dim fila As DataRow
        Dim i As Integer = 0
        Dim ndifer As Double = 0
        Dim ncargo As Double = 0
        Dim nabono As Double = 0
        For Each fila In ds.Tables(0).Rows
            nabono = ds.Tables(0).Rows(i)("nabono")
            ncargo = ds.Tables(0).Rows(i)("ncargo")
            ndifer = Math.Round(nabono - ncargo, 2)
            ds.Tables(0).Rows(i)("ndifer") = ndifer

            i += 1
        Next


        'Me.RdBFind1.Checked = False
        'Me.RdBFind2.Checked = False
        'Me.Txtdescri.Text = " "

        Me.DgPartidas.DataSource = ds
        Me.DgPartidas.DataBind()

    End Sub

    Protected Sub Txtdescri_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdescri.TextChanged
        Me.cargadatos()
    End Sub

    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.cargadatos()
    End Sub
End Class
