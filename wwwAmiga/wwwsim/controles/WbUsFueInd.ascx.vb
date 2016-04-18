

Partial Class WbUsFueInd
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
        GridViewFuente.Visible = False

        cargaNuevo()

    End Sub

    Public Sub FuentesInDepen(ByVal codigocliente As String)

        Dim entidadClidfin As New SIM.EL.clidfin
        Dim eClidfin As New SIM.BL.cClidfin

        Dim ds As New DataSet
        Dim ncanti As Integer
        'Dim lndate As Date

        ds = eClidfin.ObtenerDataSetEspc(Me.txtComodin.Text.Trim, "I")

        ncanti = ds.Tables(0).Rows.Count()


        'If ncanti = 0 Then  'En caso que no devuelva nada se sale
        '    Exit Sub
        'End If


        GridViewFuente.DataSource = ds
        Me.GridViewFuente.DataBind()
        GridViewFuente.Visible = True

    End Sub


    Public Sub Habilita()
        'Me.TxtdFecha.Enabled = True
        Me.Txtdirec.Enabled = True
        Me.TxtNoEmp.Enabled = True
        Me.TxtNroDoc.Enabled = True
        Me.TxtRazon.Enabled = True
        Me.TxtcGiro.Enabled = True
        Me.txtTel.Enabled = True
        Me.cmbDep.Enabled = True
        Me.cmbMun.Enabled = True
        Me.cmbCant.Enabled = True
        Me.cmbTipneg.Enabled = True
        Me.cmbactividad.Enabled = True
        Me.cmbsector.Enabled = True
        Me.cmbNdoc.Enabled = True

        txtfammes.Enabled = True
        txtfamtra.Enabled = True

        txtnofammes.Enabled = True
        txtnofamtra.Enabled = True
        Txtnit.Enabled = True
        cmbconcpa.Enabled = True
        cmbconvta.Enabled = True
        TxtdFechaA.Enabled = True
    End Sub


    Public Sub deshabilita()
        Me.TxtdFecha.Enabled = False
        Me.Txtdirec.Enabled = False
        Me.TxtNoEmp.Enabled = False
        Me.TxtNroDoc.Enabled = False
        Me.TxtRazon.Enabled = False
        Me.TxtcGiro.Enabled = False
        Me.txtTel.Enabled = False
        Me.cmbDep.Enabled = False
        Me.cmbMun.Enabled = False
        Me.cmbCant.Enabled = False
        Me.cmbTipneg.Enabled = False
        Me.cmbactividad.Enabled = False
        Me.cmbsector.Enabled = False
        Me.cmbNdoc.Enabled = False

        txtfammes.Enabled = False
        txtfamtra.Enabled = False

        txtnofammes.Enabled = False
        txtnofamtra.Enabled = False

        Txtnit.Enabled = False
        cmbconcpa.Enabled = False
        cmbconvta.Enabled = False
        TxtdFechaA.Enabled = False
    End Sub

    Public Sub limpia()
        Me.TxtdFecha.Text = Session("gdFecSis")
        TxtdFechaA.Text = Session("gdfecsis")
        Me.TxtDirec.Text = ""
        Me.TxtNoEmp.Text = "0"
        Me.TxtNroDoc.Text = ""
        Me.TxtRazon.Text = ""
        Me.TxtcGiro.Text = ""

        Me.txtTel.Text = ""
        Me.TxtBandera.Text = ""

        txtfammes.Text = 0
        txtfamtra.Text = 0
        txtfamtot.Text = 0

        txtnofammes.Text = 0
        txtnofamtra.Text = 0
        txtnofamtot.Text = 0

        Txtnit.Text = ""
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

        'Sector

        mListaTabttab = clstabttab.ObtenerLista("021", "1")

        Me.cmbsector.DataTextField = "cdescri"
        Me.cmbsector.DataValueField = "ccodigo"
        Me.cmbsector.DataSource = mListaTabttab
        Me.cmbsector.DataBind()


        'Tipo de Negocio

        mListaTabttab = clstabttab.ObtenerLista("088", "1")

        Me.cmbTipneg.DataTextField = "cdescri"
        Me.cmbTipneg.DataValueField = "ccodigo"
        Me.cmbTipneg.DataSource = mListaTabttab
        Me.cmbTipneg.DataBind()



        'Actividad
        Dim clsTabtciu As New SIM.BL.cTabtciu
        Dim mTabtciu As New listatabtciu

        mTabtciu = clsTabtciu.ObtenerLista()


        Me.cmbactividad.DataTextField = "cdescri"
        Me.cmbactividad.DataValueField = "ccodigo"
        Me.cmbactividad.DataSource = mTabtciu
        Me.cmbactividad.DataBind()

        mListaTabttab = clstabttab.ObtenerLista("090", "1")

        Me.cmbconcpa.DataTextField = "cdescri"
        Me.cmbconcpa.DataValueField = "ccodigo"
        Me.cmbconcpa.DataSource = mListaTabttab
        Me.cmbconcpa.DataBind()

        Me.cmbconvta.DataTextField = "cdescri"
        Me.cmbconvta.DataValueField = "ccodigo"
        Me.cmbconvta.DataSource = mListaTabttab
        Me.cmbconvta.DataBind()

        Session.Add("latitud", 0)
        Session.Add("longitud", 0)
        Session.Add("Zona", "")
    End Sub


#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "INI", 2)
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

    Private Sub cmbcant_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcant.SelectedIndexChanged

    End Sub
    Private Sub cargaNuevo()
        Me.Habilita()
        Me.limpia()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True
        Dim eclimide As New cClimide
        Dim lccoddom As String
        Me.TxtDirec.Text = eclimide.RecuperarDireccion(Me.txtComodin.Text.Trim)
        lccoddom = eclimide.RecuperarZona(Me.txtComodin.Text.Trim)
        Try
            cmbDep.SelectedValue = Left(lccoddom, 2)
            BuscaMunicipios()
            cmbMun.SelectedValue = Left(lccoddom, 4)
            BuscaCantones()
            cmbcant.SelectedValue = Left(lccoddom, 6)
        Catch ex As Exception

        End Try



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
        If Me.TxtRazon.Text.Trim = "" Then
            '            Response.Write("<script language='javascript'>alert('Razón Social en Blanco')</script>")
            codigoJs = "<script language='javascript'>alert('Razón Social en Blanco')</script>"
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

        If Me.TxtNoEmp.Text.Trim = Nothing Then
            Me.TxtNoEmp.Text = "0"
        End If
        cls._ccodcli = Me.txtComodin.Text.Trim
        cls._cTiprel = "I"
        cls._cNomfue = Me.TxtRazon.Text.Trim
        cls._cTidofu = Me.cmbNdoc.SelectedValue
        'cls._cNudofu = Me.TxtNroDoc.Text.Trim
        cls._dIniFue = Date.Parse(Me.TxtdFecha.Text)

        cls._cUbiFue = Me.cmbcant.SelectedValue
        cls._cDirFue = Me.TxtDirec.Text.Trim
        cls._cTipNeg = Me.cmbTipneg.SelectedValue
        cls._cSecEco = Me.cmbsector.SelectedValue
        cls._cCodAct = Me.cmbactividad.SelectedValue
        cls._cAnoUbi = Session("gdfecsis")
        cls._cCodusu = Session("gcCodUsu")
        cls._cTelFue = Me.txtTel.Text.Trim

        cls._cmanfon = "N"
        cls._cpuesto = ""
        cls._cjefe = ""
        cls._cpuestojefe = ""

        cls._cNudofu = Txtnit.Text.Trim
        cls._dfechaA = Date.Parse(TxtdFechaA.Text)
        cls._cconcpa = cmbconcpa.SelectedValue.Trim
        cls._cconvta = cmbconvta.SelectedValue.Trim
        cls._nfahope = Integer.Parse(txtfammes.Text)
        cls._nfahote = Integer.Parse(txtfamtra.Text)
        cls._nnfhope = Integer.Parse(txtnofammes.Text)
        cls._nnfhote = Integer.Parse(txtnofamtra.Text)
        cls._nEmplea = Integer.Parse(txtfammes.Text) + Integer.Parse(txtfamtra.Text) + Integer.Parse(txtnofammes.Text) + Integer.Parse(txtnofamtra.Text)

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
        'Me.txtfuente.Text = cls._cCodfue
        cls._cgiro = Me.TxtcGiro.Text.Trim

        lnretorno = cls.ActualizaClidfinInDep()

        'Extrae Valor de Fuente Ingreso para poder ejecutar un Balance sin seleccionar y lo coloca en valor de fuente
        Me.txtfuente.Text = eclidfin.Extrae_Ultima_Fuente_de_Ingreso(Me.txtComodin.Text.Trim)


        Dim clsppal As New class1
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "GrI", 2)

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
        'cls._cCodfue = Me.TxtBandera.Text.Trim
        cls._cCodfue = Me.txtfuente.Text.trim


        lnretorno = cls.EliminaClidfinDep()

        If lnretorno = 0 Then
            Exit Sub
        End If

        Me.FuentesInDepen(Me.txtComodin.Text.Trim)

        Me.deshabilita()
        Me.btgrabar.Enabled = False
        Me.btnuevo.Enabled = True
        Me.limpia()


    End Sub

    Protected Sub btbalance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btbalance.Click

        If Me.txtfuente.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Razón Social en Blanco, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'If Me.TxtRazon.Text.Trim = "" Then
        '    '            Response.Write("<script language='javascript'>alert('Razón Social en Blanco')</script>")

        '    codigoJs = "<script language='javascript'>alert('Razón Social en Blanco, " & _
        '                                        "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Exit Sub
        'End If

        Session("codigo") = Me.txtComodin.Text.Trim
        Session("fuente") = Me.txtfuente.Text.Trim  'Me.TxtBandera.Text.Trim
        'Response.Redirect("Wbbalance.aspx")
        'Response.Write("<script>window.open('wfEstFin.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=700')</script>")

        codigoJs = "<script>window.open('wfEstFin.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=700')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        'scrollbars=1,

    End Sub

    Protected Sub GridViewFuente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewFuente.SelectedIndexChanged
        Me.txtfuente.Text = GridViewFuente.SelectedRow.Cells(1).Text.ToString 'Fuente Seleccionada


        Dim entidadclidfin As New SIM.EL.clidfin
        Dim eClidfin As New SIM.BL.cClidfin

        entidadclidfin.ccodcli = Me.txtComodin.Text.Trim
        entidadclidfin.ccodfue = Me.txtfuente.Text.Trim 'ClienteSeleccionado
        entidadclidfin.ctiprel = "I"

        eClidfin.ObtenerClidfin(entidadclidfin)

        Me.TxtRazon.Text = entidadclidfin.cnomfue
        Me.TxtcGiro.Text = entidadclidfin.cgiro

        'Me.cmbNdoc.SelectedValue = entidadclidfin.ctidofu
        Me.TxtNroDoc.Text = entidadclidfin.cnudofu
        Me.TxtdFecha.Text = entidadclidfin.dinifue
        Me.TxtNoEmp.Text = entidadclidfin.nemplea


        Me.TxtDirec.Text = entidadclidfin.cdirfue

        'agrega actualizacion de combos

        Me.cmbDep.SelectedValue = entidadclidfin.cubifue.Substring(0, 2)
        Me.BuscaMunicipios()
        Me.cmbMun.SelectedValue = entidadclidfin.cubifue.Substring(0, 5)
        Me.BuscaCantones()
        Me.cmbcant.SelectedValue = entidadclidfin.cubifue.Substring(0, 9)
        Me.cmbsector.SelectedValue = entidadclidfin.csececo.Trim
        Me.cmbactividad.SelectedValue = entidadclidfin.ccodact.Trim



        Me.txtTel.Text = entidadclidfin.ctelfue


        Me.TxtBandera.Text = ClienteSeleccionado

        Txtnit.Text = entidadclidfin.cnudofu
        TxtdFechaA.Text = entidadclidfin.dfechaA
        cmbconcpa.SelectedValue = entidadclidfin.cconcpa.Trim
        cmbconvta.SelectedValue = entidadclidfin.cconvta.Trim
        txtfammes.Text = entidadclidfin.nfahope
        txtfamtra.Text = entidadclidfin.nfahote
        txtnofammes.Text = entidadclidfin.nnfhope
        txtnofamtra.Text = entidadclidfin.nnfhote

        Me.TxtLng.Text = entidadclidfin.longitud
        Me.TxtLat.Text = entidadclidfin.latitud

        Session("latitud") = entidadclidfin.latitud
        Session("longitud") = entidadclidfin.longitud
        Session("Zona") = entidadclidfin.cdirfue


        Me.Habilita()
        Me.btgrabar.Enabled = True
        Me.bteliminar.Enabled = True
        Me.btnuevo.Enabled = False

        Me.btbalance.Enabled = True
    End Sub
End Class


