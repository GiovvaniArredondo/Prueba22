Public Class WbUsFindPart
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
            cargayears()
        End If
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
        lcyears = Left(cbxanos.SelectedValue.Trim, 4) 'Left(lcmesvig.Trim, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))
        Session("gcmesvig") = cbxanos.SelectedValue.Trim

        If Me.RdBFind1.Checked = True Then
            ds = cClsPart.BuscaPartidaNo(Me.Txtdescri.Text.Trim, Session("gcfondo"), lccadena, lccodofi)  'No de Partida
        ElseIf Me.RdBFind2.Checked = True Then
            ds = cClsPart.BuscaPartidaDes(Me.Txtdescri.Text.Trim, Session("gcfondo"), lccadena, lccodofi) 'Descripcion
        Else
            ds = cClsPart.BuscaPartidaFechas(Date.Parse(Me.txtdfecini.Text), Date.Parse(Me.txtdfecfin.Text), Session("gcfondo"), lccadena, lccodofi) 'Descripcion
        End If

        'Si no encontro movimiento, lo buscara en  bases historicas



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



        Me.DgPartidas.DataSource = ds
        Me.DgPartidas.DataBind()

    End Sub

    Protected Sub Txtdescri_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtdescri.TextChanged
        Me.cargadatos()
    End Sub

    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.cargadatos()
    End Sub

    Private Sub cargayears()
        Dim clscntaprm As New SIM.BL.cCntaprm
        Dim mlistacntaprm As New listacntaprm

        Dim lcfondo As String

        lcfondo = "99"
        clscntaprm.cfondo = lcfondo
        mlistacntaprm = clscntaprm.ObtenerListaPorIDyear()

        Me.cbxanos.DataTextField = "año"
        Me.cbxanos.DataValueField = "cmesvig"
        Me.cbxanos.DataSource = mlistacntaprm
        Me.cbxanos.DataBind()
    End Sub

End Class
