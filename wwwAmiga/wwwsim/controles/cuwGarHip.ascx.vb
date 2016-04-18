

Partial Class cuwGarHip
    Inherits ucWBase


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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then

        End If
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
        Me.txtccodcta.text = codigoCliente
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
        ds = Me.BuscaGarantia(Me.TxtCodigo.Text.Trim, Me.TxtComodin.Text.Trim)

        Dim ncanti As Integer

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub        'Hubo un error Depurar
        End If

        Me.txtdfecpre.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("dpresent")), "", ds.Tables(0).Rows(0)("dpresent"))
        Me.txtdfecins.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("dinscrip")), "", ds.Tables(0).Rows(0)("dinscrip"))
        Me.txtnnumpre.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("cnumpres")), "", ds.Tables(0).Rows(0)("cnumpres"))
        Me.txtnnumins.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("cnumins")), "", ds.Tables(0).Rows(0)("cnumins"))
        Me.txtcobservar.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("cobser")), "", ds.Tables(0).Rows(0)("cobser"))


        Me.btngraba.Disabled = False
        'Me.Habilita()
    End Sub

    Public Function BuscaGarantia(ByVal cCodigo As String, ByVal cCodgar As String) As DataSet
        Dim ds As New DataSet

        'Nombre del Cliente
        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar

        ds = eClimgar.ObtenerDataSetporcCodgar(cCodigo, cCodgar)

        Return ds
    End Function

    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        Dim lcCodgar As String
        Dim cls As New SIM.BL.ClsGarant
        Dim lncentinela As Integer
        
        cls._ccodgar = Me.TxtComodin.Text.Trim
        cls._ccodcli = Me.TxtCodigo.Text.Trim
        If Me.txtdfecpre.Text = "" Or Me.txtdfecpre.Text = Nothing Then
            cls._dpresent = DateTime.Parse("01/01/1900")
        Else
            cls._dpresent = DateTime.Parse(Me.txtdfecpre.Text)
        End If

        If Me.txtdfecins.Text = "" Or Me.txtdfecins.Text = Nothing Then
            cls._dinscrip = DateTime.Parse("01/01/1900")
        Else
            cls._dinscrip = DateTime.Parse(Me.txtdfecins.Text)
        End If



        cls._cnumins = Me.txtnnumins.Text
        cls._cnumpres = Me.txtnnumpre.Text
        cls._cobser = Me.txtcobservar.Text.Trim


        lncentinela = cls.GrabaGarantiaHipo()

        If lncentinela = 1 Then 'Proceso Correcto
            Me.RefrescaGrid()
            '            Me.Label2.Text = "Proceso generado con exito"
            '           Me.Label2.Visible = True
        Else                    'Genero Error
            '          Me.Label1.Text = "A ocurrido un error, contactar al proveedor"
            '         Me.Label1.Visible = True
        End If

        Me.btngraba.Disabled = True
        
    End Sub
    Sub RefrescaGrid()
        CargarPorCliente(Me.txtccodcta.Text.Trim)
    End Sub

    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Me.txtdfecpre.Text = ""
        Me.txtdfecins.Text = ""
        Me.txtnnumpre.Text = ""
        Me.txtnnumins.Text = ""
        Me.txtcobservar.Text = ""
    End Sub
End Class


