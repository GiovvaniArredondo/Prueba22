

Partial Class WbUsFueAgro
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


        cargaNuevo()

    End Sub

    Public Sub FuentesInDepen(ByVal codigocliente As String)

        Me.Datagrid1.DataSource = ""
        Me.Datagrid1.DataBind()

        Dim entidadClidfin As New SIM.EL.clidfin
        Dim eClidfin As New SIM.BL.cClidfin

        Dim ds As New DataSet
        Dim ncanti As Integer


        ds = eClidfin.ObtenerDataSetEspc(Me.txtComodin.Text.Trim, "A")

        ncanti = ds.Tables(0).Rows.Count()


        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If

        Me.Datagrid1.DataSource = ds
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
    End Sub


    Public Sub Habilita()
        Me.TxtdFecha.Enabled = True
        Me.Txtdirec.Enabled = True
        Me.TxtNoEmp.Enabled = True
        Me.TxtNroDoc.Enabled = True
        
        Me.cmbDep.Enabled = True
        Me.cmbMun.Enabled = True
        Me.cmbCant.Enabled = True
        Me.cmbTipneg.Enabled = True
        
        Me.cmbNdoc.Enabled = True

        txtfammes.Enabled = True
        txtfamtra.Enabled = True

        txtnofammes.Enabled = True
        txtnofamtra.Enabled = True

        cmbpara.Enabled = True
        txtpropietario.Enabled = True
        Txtdireccion.Enabled = True
        txtcuerdasmts.Enabled = True
        txtcuerdasvaras.Enabled = True
        cmbmedida.Enabled = True
        cmbmedida0.Enabled = True
        txtcantidad.Enabled = True
        txtfammes0.Enabled = True
        txtfamtra0.Enabled = True
        txtnofammes0.Enabled = True
        txtnofamtra0.Enabled = True
    End Sub


    Public Sub deshabilita()
        Me.TxtdFecha.Enabled = False
        Me.Txtdirec.Enabled = False
        Me.TxtNoEmp.Enabled = False
        Me.TxtNroDoc.Enabled = False
        
        Me.cmbDep.Enabled = False
        Me.cmbMun.Enabled = False
        Me.cmbCant.Enabled = False
        Me.cmbTipneg.Enabled = False
        
        Me.cmbNdoc.Enabled = False

        txtfammes.Enabled = False
        txtfamtra.Enabled = False

        txtnofammes.Enabled = False
        txtnofamtra.Enabled = False


        cmbpara.Enabled = False
        txtpropietario.Enabled = False
        Txtdireccion.Enabled = False
        txtcuerdasmts.Enabled = False
        txtcuerdasvaras.Enabled = False
        cmbmedida.Enabled = False
        cmbmedida0.Enabled = False
        txtcantidad.Enabled = False
        txtfammes0.Enabled = False
        txtfamtra0.Enabled = False
        txtnofammes0.Enabled = False
        txtnofamtra0.Enabled = False
    End Sub

    Public Sub limpia()
        Me.TxtdFecha.Text = Session("gdFecSis")

        Me.TxtDirec.Text = ""
        Me.TxtNoEmp.Text = "0"
        Me.TxtNroDoc.Text = ""


        Me.TxtBandera.Text = ""

        txtfammes.Text = 0
        txtfamtra.Text = 0
        txtfamtot.Text = 0

        txtnofammes.Text = 0
        txtnofamtra.Text = 0
        txtnofamtot.Text = 0


        txtpropietario.Text = ""
        Txtdireccion.Text = ""
        txtcuerdasmts.Text = 0
        txtcuerdasvaras.Text = 0
        txtcantidad.Text = 0
        txtfammes0.Text = 0
        txtfamtra0.Text = 0
        txtnofammes0.Text = 0
        txtnofamtra0.Text = 0

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


        '        Me.cmbMun.Items.Clear()

    End Sub

    Public Sub BuscaCantones()

        Me.cmbcant.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.cmbMun.SelectedItem.Value.Trim, "3")
        Me.cmbcant.DataTextField = "cDesZon"
        Me.cmbcant.DataValueField = "cCodzon"
        Me.cmbcant.DataSource = mTabtZon
        Me.cmbcant.DataBind()


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
        'Me.cmbcant.DataTextField = "cDesZon"
        'Me.cmbcant.DataValueField = "cCodzon"
        'Me.cmbcant.DataSource = mTabtZon
        'Me.cmbcant.DataBind()


        'Codicion

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("035", "1")

        Me.cmbNdoc.DataTextField = "cdescri"
        Me.cmbNdoc.DataValueField = "ccodigo"
        Me.cmbNdoc.DataSource = mListaTabttab
        Me.cmbNdoc.DataBind()

        

        'Tipo de Negocio

        mListaTabttab = clstabttab.ObtenerLista("094", "1")

        Me.cmbTipneg.DataTextField = "cdescri"
        Me.cmbTipneg.DataValueField = "ccodigo"
        Me.cmbTipneg.DataSource = mListaTabttab
        Me.cmbTipneg.DataBind()


        'uso del terreno
        mListaTabttab = clstabttab.ObtenerLista("095", "1")

        Me.cmbpara.DataTextField = "cdescri"
        Me.cmbpara.DataValueField = "ccodigo"
        Me.cmbpara.DataSource = mListaTabttab
        Me.cmbpara.DataBind()


        
        mListaTabttab = clstabttab.ObtenerLista("097", "1")

        Me.cmbmedida.DataTextField = "cdescri"
        Me.cmbmedida.DataValueField = "ccodigo"
        Me.cmbmedida.DataSource = mListaTabttab
        Me.cmbmedida.DataBind()

        mListaTabttab = clstabttab.ObtenerLista("115", "1")

        Me.cmbmedida0.DataTextField = "cdescri"
        Me.cmbmedida0.DataValueField = "ccodigo"
        Me.cmbmedida0.DataSource = mListaTabttab
        Me.cmbmedida0.DataBind()

    End Sub


#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "INA", 3)
            Me.CargarCombos()
            Session.Add("codigo", "")
            Session.Add("fuente", "")
        End If
    End Sub

    Private Sub cmbactividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbDep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDep.SelectedIndexChanged
        Me.BuscaMunicipios()
        Me.BuscaCantones()
    End Sub

    Private Sub cmbMun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMun.SelectedIndexChanged
        Me.BuscaCantones()

    End Sub

    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text

        Dim entidadclidfin As New SIM.El.clidfin
        Dim eClidfin As New SIM.BL.cClidfin

        entidadclidfin.ccodcli = Me.txtComodin.Text.Trim
        entidadclidfin.ccodfue = ClienteSeleccionado
        entidadclidfin.ctiprel = "A"

        eClidfin.ObtenerClidfin(entidadclidfin)


        Me.TxtNroDoc.Text = entidadclidfin.cnudofu
        Me.TxtdFecha.Text = entidadclidfin.dinifue
        Me.TxtNoEmp.Text = entidadclidfin.nemplea


        Me.Txtdireccion.Text = entidadclidfin.cdirfue
        'agrega actualizacion de combos

        Me.cmbDep.SelectedValue = entidadclidfin.cubifue.Substring(0, 2)
        Me.cmbMun.SelectedValue = entidadclidfin.cubifue.Substring(0, 5)
        Me.cmbcant.SelectedValue = entidadclidfin.cubifue.Substring(0, 9)

        Me.TxtBandera.Text = ClienteSeleccionado

        txtfammes.Text = entidadclidfin.nfahope
        txtfamtra.Text = entidadclidfin.nfahote
        txtnofammes.Text = entidadclidfin.nnfhope
        txtnofamtra.Text = entidadclidfin.nnfhote

        txtpropietario.Text = entidadclidfin.cnomfue
        cmbTipneg.SelectedValue = entidadclidfin.ctipneg.Trim
        cmbpara.SelectedValue = entidadclidfin.cpara.Trim
        cmbmedida0.SelectedValue = Left(entidadclidfin.nmetros.ToString.Trim, 1)
        txtcuerdasvaras.Text = entidadclidfin.nvaras
        cmbmedida.SelectedValue = entidadclidfin.cmedida
        txtcantidad.Text = entidadclidfin.ncantidad
        txtfammes0.Text = entidadclidfin.nfamupe
        txtfamtra0.Text = entidadclidfin.nfamute
        txtnofammes0.Text = entidadclidfin.nnfmupe
        txtnofamtra0.Text = entidadclidfin.nnfmute
        TxtDirec.Text = entidadclidfin.cdirterreno

        Me.Habilita()
        Me.btgrabar.Enabled = True
        Me.bteliminar.Enabled = True
        Me.btnuevo.Enabled = False

        Me.btbalance.Enabled = True

    End Sub

    Private Sub cmbcant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcant.SelectedIndexChanged

    End Sub



    Private Sub cargaNuevo()
        Me.Habilita()
        Me.limpia()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True
        Dim eclimide As New cClimide
        Me.TxtDirec.Text = eclimide.RecuperarDireccion(Me.txtComodin.Text.Trim)

    End Sub

    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        Me.Habilita()
        Me.limpia()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True
        Dim eclimide As New cClimide
        Me.TxtDirec.Text = eclimide.RecuperarDireccion(Me.txtComodin.Text.Trim)

    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        If Me.txtpropietario.Text.Trim = "" Then
            ' Response.Write("<script language='javascript'>alert('Propietario en Blanco')</script>")
            codigoJs = "<script language='javascript'>alert('Propietario en Blanco, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Dim cls As New SIM.BL.ClsFuentes
        Dim eclidfin As New SIM.BL.cClidfin
        Dim lnretorno As Integer

        If Me.TxtNoEmp.Text.Trim = Nothing Then
            Me.TxtNoEmp.Text = "0"
        End If
        cls._ccodcli = Me.txtComodin.Text.Trim
        cls._cTiprel = "A"
        cls._cTidofu = Me.cmbNdoc.SelectedValue
        'cls._cNudofu = Me.TxtNroDoc.Text.Trim
        cls._dIniFue = Date.Parse(Me.TxtdFecha.Text)
        cls._cNomfue = Me.txtpropietario.Text.Trim

        cls._cUbiFue = Me.cmbcant.SelectedValue
        cls._cDirFue = Me.Txtdireccion.Text.Trim
        cls._cTipNeg = Me.cmbTipneg.SelectedValue
        cls._cAnoUbi = Session("gdfecsis")
        cls._cCodusu = Session("gcCodUsu")

        cls._cmanfon = "N"
        cls._cpuesto = ""
        cls._cjefe = ""
        cls._cpuestojefe = ""

        cls._cconcpa = "1"
        cls._cconvta = "1"

        cls._nfahope = Integer.Parse(txtfammes.Text)
        cls._nfahote = Integer.Parse(txtfamtra.Text)
        cls._nnfhope = Integer.Parse(txtnofammes.Text)
        cls._nnfhote = Integer.Parse(txtnofamtra.Text)
        cls._nEmplea = Integer.Parse(txtfammes.Text) + Integer.Parse(txtfamtra.Text) + Integer.Parse(txtnofammes.Text) + Integer.Parse(txtnofamtra.Text)

        cls._cpara = cmbpara.SelectedValue.Trim
        cls._nmetros = cmbmedida0.SelectedValue 'Double.Parse(txtcuerdasmts.Text)
        cls._nvaras = Double.Parse(txtcuerdasvaras.Text)
        cls._cmedida = cmbmedida.SelectedValue.Trim
        cls._ncantidad = Double.Parse(txtcantidad.Text)
        cls._nfamupe = Integer.Parse(txtfammes0.Text)
        cls._nfamute = Integer.Parse(txtfamtra0.Text)
        cls._nnfmupe = Integer.Parse(txtnofammes0.Text)
        cls._nnfmute = Integer.Parse(txtnofamtra0.Text)
        cls._cdirterreno = Me.TxtDirec.Text


        cls._dfechaA = Date.Parse(TxtdFecha.Text)
        If Me.TxtBandera.Text.Trim = "" _
            Or Me.TxtBandera.Text.Trim = Nothing Then
            cls._cCodfue = eclidfin.ObtenercCoduni(cls._ccodcli, cls._cTiprel)
            cls._llBandera = True                  'Modifica
        Else
            cls._llBandera = False
            cls._cCodfue = Me.TxtBandera.Text.Trim
        End If
        Me.txtfuente.Text = cls._cCodfue
        cls._cSecEco = "A"

        lnretorno = cls.ActualizaClidfinInDep()

        Dim clsppal As New class1
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "GrA", 3)

        If lnretorno = 0 Then
            Exit Sub
        End If

        Me.deshabilita()
        Me.btgrabar.Enabled = False
        Me.btnuevo.Enabled = True
        Me.limpia()
        Me.FuentesInDepen(Me.txtComodin.Text.Trim)

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
        cls._cTiprel = "I"
        cls._cCodfue = Me.TxtBandera.Text.Trim

        lnretorno = cls.EliminaClidfinDep()

        If lnretorno = 0 Then
            Exit Sub
        End If

        Me.deshabilita()
        Me.btgrabar.Enabled = False
        Me.btnuevo.Enabled = True
        Me.limpia()
        Me.FuentesInDepen(Me.txtComodin.Text.Trim)

    End Sub

    Protected Sub btbalance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btbalance.Click

        If Me.txtpropietario.Text.Trim = "" Then
            '            Response.Write("<script language='javascript'>alert('Propietario en Blanco')</script>")
            codigoJs = "<script language='javascript'>alert('Propietario en Blanco, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Me.btgrabar_Click(sender, e)

        Session("gdfecha") = Date.Parse(TxtdFecha.Text)
        Session("codigo") = Me.txtComodin.Text.Trim
        Session("fuente") = Me.txtfuente.Text.Trim  'Me.TxtBandera.Text.Trim

        'Response.Write("<script>window.open('wfAgricola.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=650')</script>")

        codigoJs = "<script>window.open('wfAgricola.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=650')</script>"

        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
    End Sub

  
End Class


