

Partial Class WbUsFueDep
    Inherits ucWBase


#Region " Variables "
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Private codigoJs As String
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

#Region "Metodos"
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Dim gdfecsis As Date = Session("gdfecsis")

        Me.txtComodin.Text = codigoCliente

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.txtComodin.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim
        carganuevo()
    End Sub
    Private Sub carganuevo()
        Me.Habilita()
        Me.limpia()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True
    End Sub
    Public Sub FuentesDepen(ByVal codigocliente As String)

        Dim entidadClidfin As New SIM.EL.clidfin
        Dim eClidfin As New SIM.BL.cClidfin

        Dim ds As New DataSet
        Dim ncanti As Integer
        'Dim lndate As Date

        ds = eClidfin.ObtenerDataSetEspc(Me.txtComodin.Text.Trim, "D")

        ncanti = ds.Tables(0).Rows.Count()


        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If

        Me.Datagrid1.DataSource = ds
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
    End Sub

    Public Sub Habilita()
        Me.TxtAno.Enabled = True
        'Me.TxtdFecha.Enabled = True
        Me.Txtdirec.Enabled = True

        Me.TxtNroDoc.Enabled = True
        Me.TxtRazon.Enabled = True
        Me.TxtSueldo.Enabled = True
        Me.TxtTel.Enabled = True
        Me.cmbDep.Enabled = True
        Me.cmbMun.Enabled = True
        Me.cmbCant.Enabled = True
        Me.cmbcondicion.Enabled = True
        Me.cmbactividad.Enabled = True
        Me.cmbsector.Enabled = True
        Me.cmbNdoc.Enabled = True

        txtpuesto.Enabled = True
        txtjefe.Enabled = True
        txtpuestojefe.Enabled = True
        cmbManejaFon.Enabled = True
    End Sub


    Public Sub deshabilita()
        Me.TxtAno.Enabled = False
        Me.TxtdFecha.Enabled = False
        Me.Txtdirec.Enabled = False

        Me.TxtNroDoc.Enabled = False
        Me.TxtRazon.Enabled = False
        Me.TxtSueldo.Enabled = False
        Me.TxtTel.Enabled = False
        Me.cmbDep.Enabled = False
        Me.cmbMun.Enabled = False
        Me.cmbCant.Enabled = False
        Me.cmbcondicion.Enabled = False
        Me.cmbactividad.Enabled = False
        Me.cmbsector.Enabled = False
        Me.cmbNdoc.Enabled = False

        txtpuesto.Enabled = False
        txtjefe.Enabled = False
        txtpuestojefe.Enabled = False
        cmbManejaFon.Enabled = False
    End Sub

    Public Sub limpia()
        Me.TxtAno.Text = Session("gdfecsis")
        Me.TxtdFecha.Text = Session("gdFecSis")
        Me.Txtdirec.Text = ""

        Me.TxtNroDoc.Text = ""
        Me.TxtRazon.Text = ""
        Me.TxtSueldo.Text = 0
        Me.TxtTel.Text = ""
        Me.TxtBandera.Text = ""

        txtpuesto.Text = ""
        txtjefe.Text = ""
        txtpuestojefe.Text = ""
        Me.TxtLat.Text = ""
        Me.TxtLng.Text = ""
    End Sub


    Public Sub BuscaMunicipios()

        Me.cmbMun.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.cmbDep.SelectedItem.Value.Trim, "2")
        Me.cmbMun.DataTextField = "cDesZon"
        Me.cmbMun.DataValueField = "cCodzon"
        Me.cmbMun.DataSource = mTabtZon
        Me.cmbMun.DataBind()


    End Sub

    Public Sub BuscaCantones()

        Me.cmbCant.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.cmbMun.SelectedItem.Value.Trim, "3")
        Me.cmbCant.DataTextField = "cDesZon"
        Me.cmbCant.DataValueField = "cCodzon"
        Me.cmbCant.DataSource = mTabtZon
        Me.cmbCant.DataBind()

    End Sub

    Public Sub CargarCombos()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Departamento
        mTabtZon = clsTabtZon.ObtenerLista("1")
        Me.cmbDep.DataTextField = "cDesZon"
        Me.cmbDep.DataValueField = "cCodzon"
        Me.cmbDep.DataSource = mTabtZon
        Me.cmbDep.DataBind()

        If Not Session("gcZona") = Nothing Or Session("gcZona") = "" Then
            Me.cmbDep.SelectedValue = Session("gcZona").ToString.Trim
        End If

        Me.BuscaMunicipios()
        Me.BuscaCantones()

        ''Municipio
        'mTabtZon = clsTabtZon.ObtenerLista("2")
        'Me.cmbMun.DataTextField = "cDesZon"
        'Me.cmbMun.DataValueField = "cCodzon"
        'Me.cmbMun.DataSource = mTabtZon
        'Me.cmbMun.DataBind()

        ''Canton
        'mTabtZon = clsTabtZon.ObtenerLista("3")
        'Me.cmbCant.DataTextField = "cDesZon"
        'Me.cmbCant.DataValueField = "cCodzon"
        'Me.cmbCant.DataSource = mTabtZon
        'Me.cmbCant.DataBind()


        'Codicion

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("035", "1")

        Me.cmbNdoc.DataTextField = "cdescri"
        Me.cmbNdoc.DataValueField = "ccodigo"
        Me.cmbNdoc.DataSource = mListaTabttab
        Me.cmbNdoc.DataBind()



        'Documento


        mListaTabttab = clstabttab.ObtenerLista("017", "1")

        Me.cmbcondicion.DataTextField = "cdescri"
        Me.cmbcondicion.DataValueField = "ccodigo"
        Me.cmbcondicion.DataSource = mListaTabttab
        Me.cmbcondicion.DataBind()

        'Sector

        mListaTabttab = clstabttab.ObtenerLista("021", "1")

        Me.cmbsector.DataTextField = "cdescri"
        Me.cmbsector.DataValueField = "ccodigo"
        Me.cmbsector.DataSource = mListaTabttab
        Me.cmbsector.DataBind()

        'Actividad
        Dim clsTabtciu As New SIM.BL.cTabtciu
        Dim mTabtciu As New listatabtciu

        mTabtciu = clsTabtciu.ObtenerLista()

        Me.cmbactividad.DataTextField = "cdescri"
        Me.cmbactividad.DataValueField = "ccodigo"
        Me.cmbactividad.DataSource = mTabtciu
        Me.cmbactividad.DataBind()


        mListaTabttab = clstabttab.ObtenerLista("085", "1")

        Me.cmbManejaFon.DataTextField = "cdescri"
        Me.cmbManejaFon.DataValueField = "ccodigo"
        Me.cmbManejaFon.DataSource = mListaTabttab
        Me.cmbManejaFon.DataBind()


        Session.Add("latitud", 0)
        Session.Add("longitud", 0)
        Session.Add("Zona", "")
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IND", 3)
            Me.CargarCombos()
        End If
    End Sub

    Private Sub cmbMun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BuscaCantones()
    End Sub

    Private Sub cmbDep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDep.SelectedIndexChanged
        Me.BuscaMunicipios()
        Me.BuscaCantones()
    End Sub

    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged

        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text

        Dim entidadclidfin As New SIM.El.clidfin
        Dim eClidfin As New SIM.BL.cClidfin
        Dim retorno As Integer
        entidadclidfin.ccodcli = Me.txtComodin.Text.Trim
        entidadclidfin.ccodfue = ClienteSeleccionado
        entidadclidfin.ctiprel = "D"

        retorno = eClidfin.ObtenerClidfin(entidadclidfin)
        If retorno = 0 Then
            Return
        End If
        Me.TxtRazon.Text = entidadclidfin.cnomfue
        'Me.cmbNdoc.SelectedValue = entidadclidfin.ctidofu
        Me.TxtNroDoc.Text = entidadclidfin.cnudofu
        Me.TxtdFecha.Text = entidadclidfin.dinifue


        'Me.cmbDep.SelectedValue = entidadclidfin.cubifue.Substring(0, 2)
        'Me.cmbMun.SelectedValue = entidadclidfin.cubifue.Substring(0, 4)
        'Me.cmbCant.SelectedValue = entidadclidfin.cubifue

        Me.Txtdirec.Text = entidadclidfin.cdirfue
        'Me.cmbcondicion.SelectedValue = entidadclidfin.cconfue
        'Me.cmbsector.SelectedValue = entidadclidfin.csececo
        'Me.cmbactividad.SelectedValue = entidadclidfin.ccodact
        Me.TxtAno.Text = entidadclidfin.canoubi
        Me.TxtSueldo.Text = entidadclidfin.nsueldo
        Me.TxtTel.Text = entidadclidfin.ctelfue
        '----------------------
        Me.cmbsector.SelectedValue = entidadclidfin.csececo.Trim
        Me.cmbactividad.SelectedValue = entidadclidfin.ccodact.Trim
        If entidadclidfin.cconfue = Nothing Or IsDBNull(entidadclidfin.cconfue) Then
        Else
            Me.cmbcondicion.SelectedValue = entidadclidfin.cconfue.Trim
        End If
        Me.cmbDep.SelectedValue = entidadclidfin.cubifue.Substring(0, 2)
        BuscaMunicipios()
        Me.cmbMun.SelectedValue = entidadclidfin.cubifue.Substring(0, 5)
        BuscaCantones()
        Me.cmbCant.SelectedValue = entidadclidfin.cubifue.Substring(0, 9)

        '-----------------------
        txtpuesto.Text = entidadclidfin.cpuesto
        txtjefe.Text = entidadclidfin.cjefe
        txtpuestojefe.Text = entidadclidfin.cpuestojefe

        Session("latitud") = entidadclidfin.latitud
        Session("longitud") = entidadclidfin.longitud
        Session("Zona") = entidadclidfin.cdirfue


        Me.TxtBandera.Text = ClienteSeleccionado

        Me.Habilita()
        Me.btgrabar.Enabled = True
        Me.bteliminar.Enabled = True
        Me.btnuevo.Enabled = False
    End Sub






    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        Me.Habilita()
        Me.limpia()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True

    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        If Me.TxtRazon.Text.Trim = "" Then
            '            Response.Write("<script language='javascript'>alert('Razón Social en Blanco')</script>")
            codigoJs = "<script language='javascript'>alert('Razón Social en Blanco, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub

        End If


        If Me.TxtLng.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Geolocalizacion no Realizada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        If Me.TxtLat.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Geolocalizacion no Realizada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If



        Dim cls As New SIM.BL.ClsFuentes
        Dim eclidfin As New SIM.BL.cClidfin
        Dim lnretorno As Integer

        cls._ccodcli = Me.txtComodin.Text.Trim
        cls._cTiprel = "D"
        cls._cNomfue = Me.TxtRazon.Text.Trim
        cls._cTidofu = Me.cmbNdoc.SelectedValue
        cls._cNudofu = Me.TxtNroDoc.Text.Trim
        cls._dIniFue = Date.Parse(Me.TxtdFecha.Text)
        cls._nEmplea = 0
        cls._cUbiFue = Me.cmbCant.SelectedValue
        cls._cDirFue = Me.Txtdirec.Text.Trim
        cls._cConFue = Me.cmbcondicion.SelectedValue
        cls._cSecEco = Me.cmbsector.SelectedValue
        cls._cCodAct = Me.cmbactividad.SelectedValue
        cls._cAnoUbi = Date.Parse(Me.TxtAno.Text.Trim)
        cls._cCodusu = Session("gcCodUsu")
        cls._nSueldo = Double.Parse(Me.TxtSueldo.Text.Trim)
        cls._cTelFue = Me.TxtTel.Text.Trim

        cls._cmanfon = cmbManejaFon.SelectedValue.Trim
        cls._cpuesto = txtpuesto.Text.Trim
        cls._cjefe = txtjefe.Text.Trim
        cls._cpuestojefe = txtpuestojefe.Text.Trim


        cls._dfechaA = Session("gdfecsis")
        cls._cconcpa = "1"
        cls._cconvta = "1"
        cls._nfahope = 0
        cls._nfahote = 0
        cls._nnfhope = 0
        cls._nnfhote = 0
        cls._nEmplea = 0

        cls._cpara = "03"
        cls._nmetros = 0
        cls._nvaras = 0
        cls._cmedida = "01"
        cls._ncantidad = 0
        cls._nfamupe = 0
        cls._nfamute = 0
        cls._nnfmupe = 0
        cls._nnfmute = 0
        cls._cdirterreno = ""
        cls._cTipNeg = "01"
        cls.Longitud = Me.TxtLng.Text.Trim
        cls.Latitud = Me.TxtLat.Text.Trim

        If Me.TxtBandera.Text.Trim = "" _
            Or Me.TxtBandera.Text.Trim = Nothing Then
            cls._cCodfue = eclidfin.ObtenercCoduni(cls._ccodcli, cls._cTiprel)
            cls._llBandera = True                  'Modifica
        Else
            cls._llBandera = False
            cls._cCodfue = Me.TxtBandera.Text.Trim
        End If

        lnretorno = cls.ActualizaClidifaDep()

        Dim clsppal As New class1
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "GrD", 3)

        If lnretorno = 0 Then
            Exit Sub
        End If

        Me.deshabilita()
        Me.btgrabar.Enabled = False
        Me.btnuevo.Enabled = True
        Me.limpia()
        Me.FuentesDepen(Me.txtComodin.Text.Trim)

    End Sub

    Protected Sub btini_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btini.Click
        Me.bteliminar.Enabled = False
        Me.btgrabar.Enabled = False
        Me.deshabilita()
        Me.limpia()
        Me.btnuevo.Enabled = True

    End Sub

    Protected Sub bteliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bteliminar.Click
        Dim cls As New SIM.BL.ClsFuentes
        Dim lnretorno As Integer

        cls._ccodcli = Me.txtComodin.Text.Trim
        cls._cTiprel = "D"
        cls._cCodfue = Me.TxtBandera.Text.Trim

        lnretorno = cls.EliminaClidfinDep()

        If lnretorno = 0 Then
            Exit Sub
        End If

        Me.deshabilita()
        Me.btgrabar.Enabled = False
        Me.btnuevo.Enabled = True
        Me.limpia()
        Me.FuentesDepen(Me.txtComodin.Text.Trim)

    End Sub

    Protected Sub cmbMun_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMun.SelectedIndexChanged
        Me.BuscaCantones()
    End Sub
End Class


