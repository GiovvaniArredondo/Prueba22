Imports System.IO
Public Class WbActivoCont
    Inherits System.Web.UI.UserControl
    'Inherits ucWBase
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Dim varcomp As Integer

    'Variable que sirve para busqueda de 
    'clasificacion de activo
    Dim clac As String

    Private cClsAdCli As New SIM.BL.clsActivo
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
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private cls2 As New SIM.BL.cActivoIT    'Agregado por Kevin.
    Private clase As New SIM.BL.class1
    Private classActivo As New clsActivo
    Private classActivoM As New clsActivoM
    Private classActivoIt As New clsActivoTI
    Dim eactivof As New cActivoF
    Dim eactivom As New cActivoM
    Dim eactivoit As New cActivoIT


    Private pcCodCta As String
    'Private lNuevo As Boolean
    Private vCnn As Boolean
    Private Transacc As String
    Private ds As New DataSet
    Private ds_R As New DataSet
    Private lnindice_R As Integer
    Private lnindice_R1 As Integer
    Private lncodigo_R As String
    Private lnVal_R As String
    Private llBan_R As Boolean = False
    Private x As Integer
    Private y As Integer
    Private lnusu_R As String
    Private lnapl_R As String


    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    '--------------------------------  
    Private pcTipCre As String
    Private pcNrolin As String
    'Private gcCodUsu As String
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            CargarDatos()
            CargaMarcas()
            CargaLinea()
            CargaUbicacion()
            CargaUnidad()
            limpiar()
            CargaUsuarios()
        End If
    End Sub

    Private Sub CargaProveedores()
        'oficinas
        Dim clscntaemp As New SIM.BL.cCntaemp
        Dim mListacntaemp As New listacntaemp
        mListacntaemp = clscntaemp.ObtenerLista()
    End Sub

    Private Sub CargaUsuarios()
        'usuarios
        Dim clsusu As New SIM.BL.cusuarios
        Dim mListaUsu As New DataSet
        mListaUsu = clsusu.ObtenerUsuarios2
        cmbUsuarios.DataTextField = "Nombre"
        cmbUsuarios.DataValueField = "Usuario"
        cmbUsuarios.DataSource = mListaUsu
        cmbUsuarios.DataBind()
    End Sub

#Region " Metodos "
    Private Sub CargarDatos()
        'Estado del Bien
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1311'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If

        Me.DropDownList1.DataTextField = "cDescri"
        Me.DropDownList1.DataValueField = "cCodigo"
        Me.DropDownList1.DataSource = ds.Tables("Resultado")
        Me.DropDownList1.DataBind()
        ds.Tables("Resultado").Clear()

        'Fuente de Fondos
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        Dim lcfondos As String
        lcfondos = Session("gcfondo")

        mListaTabttab = clstabttab.ObtenerListaPorIDxcodigo("033", "1", lcfondos)

        Me.cmbFondos.DataTextField = "cdescri"
        Me.cmbFondos.DataValueField = "ccodigo"
        Me.cmbFondos.DataSource = mListaTabttab
        Me.cmbFondos.DataBind()

        'Origen de la Adquisicion
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1301'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.DropDownList2.DataTextField = "cDescri"
        Me.DropDownList2.DataValueField = "cCodigo"
        Me.DropDownList2.DataSource = ds.Tables("Resultado")
        Me.DropDownList2.DataBind()
        ds.Tables("Resultado").Clear()

        'Activo Fijo
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1291'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist4.DataTextField = "cDescri"
        Me.Dropdownlist4.DataValueField = "cCodigo"
        Me.Dropdownlist4.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist4.DataBind()
        ds.Tables("Resultado").Clear()

        'Clasificacion del activo Fijo
        lnparametro1_R = "cDescri , ctipact, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTACT"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodact = '10'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist5.DataTextField = "cDescri"
        Me.Dropdownlist5.DataValueField = "ctipact"
        Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist5.DataBind()
        ds.Tables("Resultado").Clear()

        'Oficina
        lnparametro1_R = "cnomofi , cCodofi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = ""
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist6.DataTextField = "cnomofi"
        Me.Dropdownlist6.DataValueField = "cCodofi"
        Me.Dropdownlist6.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist6.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub

#End Region

    Private Function CodigoGenerado() As String
        'Dim precod As String
        Dim ccodigo As String

        Dim i As String
        'Busca codigo para asignar correlativo
        i = eactivof.BuscaCodigo()
        ccodigo = i
        Return ccodigo
    End Function

    Private Sub limpiar()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = "0"
        Me.TextBox4.Text = Session("GDFECCTB")
        Me.txtFechaBja.Text = Session("GDFECCTB")
        Me.txtOperador.Text = Session("gcCodusu")
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = "0"
        Me.TextBox7.Text = ""
        Me.Textbox8.Text = "0"
        Me.txtFactura.Text = ""
        Me.txtNIt.Text = ""
        Me.txtNroChq.Text = ""
        Me.txtPartida.Text = ""
        Me.txtProvee.Text = ""
        Me.txtSeri.Text = ""
        Me.txtModelo.Text = ""
        Me.txtLicencia.Text = ""
        Me.txtUsLog.Text = ""
        Me.txtPassLog.Text = ""
        Me.txtPassInter.Text = ""
        Me.txtDetalle.Text = ""
        Me.txtEmpleado.Text = ""
        Me.cmbFondos.SelectedIndex = 0
        Me.cmbUsuarios.SelectedIndex = 0
        Me.DropDownList1.SelectedIndex = 0
        Me.DropDownList2.SelectedIndex = 0
        Me.DropDownList3.SelectedIndex = 0
        Me.Dropdownlist4.SelectedIndex = 0
        Me.Dropdownlist5.SelectedIndex = 0
        Me.Dropdownlist6.SelectedIndex = 0
        Me.Dropdownlist7.SelectedIndex = 0
        Me.cmbMarca.SelectedIndex = 0
        Me.cmbLinea.SelectedIndex = 0
    End Sub

    Private Sub HabilitaRH()
        'Contabilidad
        Me.TextBox2.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        'Me.TextBox5.Enabled = True
        'Me.TextBox6.Enabled = True
        Me.TextBox7.Enabled = True
        'Me.Textbox8.Enabled = True
        Me.txtNIt.Enabled = True
        Me.txtFechaBja.Enabled = True
        Me.txtNroChq.Enabled = True
        Me.txtPartida.Enabled = True
        Me.txtFactura.Enabled = True
        Me.CheckBox1.Enabled = True
        Me.cmbFondos.Enabled = True
        Me.cmbUsuarios.Enabled = True
        Me.DropDownList1.Enabled = True
        Me.DropDownList2.Enabled = True
        Me.Dropdownlist4.Enabled = True
        Me.Dropdownlist5.Enabled = True
        Me.Dropdownlist6.Enabled = True
        btnBuscaProv.Enabled = True
        btnProvee.Enabled = True
       
        ''admon
        Me.CargaUnidad()
        Me.CargaUbicacion()
        Me.CargaUsuarios()
        Me.cmbUsuarios.Enabled = True
        Me.btnAsignar.Enabled = True
        Me.DropDownList3.Enabled = True
        Me.Dropdownlist7.Enabled = True

        ''sistemas
        Panel1.Enabled = True
        Me.btnNuevo.Enabled = True
        Me.btnGraba.Enabled = False
        Me.btnModificar.Enabled = False
    End Sub

    Private Sub DeshabilitaRH()
        ' contabilidad
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox6.Enabled = False
        Me.TextBox7.Enabled = False
        Me.Textbox8.Enabled = False
        Me.txtFactura.Enabled = False
        Me.txtFechaBja.Enabled = False
        Me.txtNIt.Enabled = False
        Me.txtNroChq.Enabled = False
        Me.txtPartida.Enabled = False
        Me.txtProvee.Enabled = False
        Me.CheckBox1.Enabled = False
        Me.cmbFondos.Enabled = False
        Me.DropDownList1.Enabled = False
        Me.DropDownList2.Enabled = False
        Me.DropDownList3.Enabled = False
        Me.Dropdownlist4.Enabled = False
        Me.Dropdownlist5.Enabled = False
        Me.Dropdownlist6.Enabled = False
        Me.Dropdownlist7.Enabled = False
        Me.cmbUsuarios.Enabled = False

        btnProvee.Enabled = False
        btnBuscaProv.Enabled = False
        btnGraba.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = False

        'recursos humanos
        Me.cmbUsuarios.Enabled = False
        Me.btnAsignar.Enabled = False
        Me.DropDownList3.Enabled = False
        Me.Dropdownlist7.Enabled = False

        ' sistemas
        Panel1.Enabled = False
    End Sub

    Private Sub HabilitaSistemas()
        Panel1.Enabled = True
        Me.CargaMarcas()
        Me.CargaLinea()
    End Sub

    Private Sub DeshabilitarSistemas()
        Panel1.Enabled = False
    End Sub

    Private Sub HabilitaConta()
        Me.TextBox2.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        'Me.TextBox5.Enabled = True
        'Me.TextBox6.Enabled = True
        Me.TextBox7.Enabled = True
        'Me.Textbox8.Enabled = True
        Me.txtNIt.Enabled = True
        Me.txtFechaBja.Enabled = True
        Me.txtNroChq.Enabled = True
        Me.txtPartida.Enabled = True
        Me.txtFactura.Enabled = True
        Me.CheckBox1.Enabled = True
        Me.cmbFondos.Enabled = True
        Me.DropDownList1.Enabled = True
        Me.DropDownList2.Enabled = True
        Me.Dropdownlist4.Enabled = True
        Me.Dropdownlist5.Enabled = True
        Me.Dropdownlist6.Enabled = True

        btnBuscaProv.Enabled = True
        btnProvee.Enabled = True
    End Sub

    Private Sub DeshabilitarConta()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox6.Enabled = False
        Me.TextBox7.Enabled = False
        Me.Textbox8.Enabled = False
        Me.txtFactura.Enabled = False
        Me.txtFechaBja.Enabled = False
        Me.txtNIt.Enabled = False
        Me.txtNroChq.Enabled = False
        Me.txtPartida.Enabled = False
        Me.txtProvee.Enabled = False
        Me.CheckBox1.Enabled = False
        Me.cmbFondos.Enabled = False
        Me.DropDownList1.Enabled = False
        Me.DropDownList2.Enabled = False
        Me.DropDownList3.Enabled = False
        Me.Dropdownlist4.Enabled = False
        Me.Dropdownlist5.Enabled = False
        Me.Dropdownlist6.Enabled = False
        Me.Dropdownlist7.Enabled = False
        Me.cmbUsuarios.Enabled = False

        btnProvee.Enabled = False
        btnBuscaProv.Enabled = False
        btnGraba.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub ActivaControlesDescriCompu()
        Dim val As Boolean

        If varcomp = 1 Then
            val = True
        ElseIf varcomp = 2 Then
            val = False
        End If
    End Sub

    Private Sub Dropdownlist4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist4.SelectedIndexChanged
        Dim xz As String
        xz = Dropdownlist4.SelectedValue.Trim

        'Clasificacion del activo Fijo
        Dim lcactfij As String
        lcactfij = Me.Dropdownlist4.SelectedValue.Trim
        lnparametro1_R = "cDescri , ctipact, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTACT"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodact = " + "'" + lcactfij + "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)

        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If

        Me.Dropdownlist5.DataTextField = "cDescri"
        Me.Dropdownlist5.DataValueField = "ctipact"
        Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist5.DataBind()
        ds.Tables("Resultado").Clear()

        If lcactfij = "10" Then    'Mobiliario de oficina
            TextBox5.Text = "5"
        ElseIf lcactfij = "20" Then 'Equipo de oficina
            TextBox5.Text = "5"
        ElseIf lcactfij = "30" Then 'Equipo de computo
            TextBox5.Text = "3"
        ElseIf lcactfij = "40" Then 'Vehiculos
            TextBox5.Text = "5"
        End If
    End Sub

    Private Sub BuscaClasificacionActivo()
        Dim lcactfij As String
        lcactfij = clac
        lnparametro1_R = "cDescri , ctipact, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTACT"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodact = " + "'" + lcactfij + "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist5.DataTextField = "cDescri"
        Me.Dropdownlist5.DataValueField = "ctipact"
        Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist5.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub

    Protected Sub btnProvee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProvee.Click
        Response.Write("<script>window.open('wbProveeActi.aspx','cal', 'location=1, toolbar = no, status=1,width=650,height=650')</script>")
    End Sub

    Private Sub CargaMarcas()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaMarcas As New listatabttab

        mListaMarcas = clstabttab.ObtenerLista("228", "1")

        cmbMarca.DataValueField = "ccodigo"
        cmbMarca.DataTextField = "cdescri"
        cmbMarca.DataSource = mListaMarcas
        cmbMarca.DataBind()
    End Sub

    Private Sub CargaLinea()
        Dim clsLinea As New SIM.BL.cTabttab
        Dim mListaLinea As New listatabttab

        mListaLinea = clsLinea.ObtenerLista("229", "1")

        cmbLinea.DataValueField = "ccodigo"
        cmbLinea.DataTextField = "cdescri"
        cmbLinea.DataSource = mListaLinea
        cmbLinea.DataBind()
    End Sub

    Private Sub CargaUnidad()
        Dim clsLinea As New SIM.BL.cTabttab
        Dim mListaLinea As New listatabttab
        'Unidad
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1601'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist7.DataTextField = "cDescri"
        Me.Dropdownlist7.DataValueField = "cCodigo"
        Me.Dropdownlist7.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist7.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub

    Private Sub CargaUbicacion()
        Dim clsLinea As New SIM.BL.cTabttab
        Dim mListaLinea As New listatabttab

        'Ubicacion Fisica
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1611'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.DropDownList3.DataTextField = "cDescri"
        Me.DropDownList3.DataValueField = "cCodigo"
        Me.DropDownList3.DataSource = ds.Tables("Resultado")
        Me.DropDownList3.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub

    Public Sub CargarActivoDetalle(ByVal codigoCliente As String)
        Dim x As String
        Dim lcEmpleado As String

        TextBox1.Text = codigoCliente

        'Trae la informacion del activo
        Dim entidadActivoF As New SIM.EL.ActivoF
        Dim entidadActivoMov As New SIM.EL.ActivoM
        Dim EntidadActivoIT As New SIM.EL.ActivoIT
        Dim eActivoF As New SIM.BL.cActivoF
        Dim eActivoIT As New SIM.BL.cActivoIT
        Dim eActivoMov As New SIM.BL.cActivoM

        entidadActivoF.ccodinv = Me.TextBox1.Text.Trim
        eActivoF.ObtenerActivoF(entidadActivoF)

        Me.txtNroChq.Text = entidadActivoF.cnrochq.Trim
        Me.Dropdownlist6.SelectedValue = entidadActivoF.ccodofi
        Me.cmbFondos.SelectedValue = entidadActivoF.ffondos.Trim
        Me.txtNroChq.Text = entidadActivoF.cnrochq.Trim
        Me.txtPartida.Text = entidadActivoF.cnumcom.Trim
        Me.txtNIt.Text = entidadActivoF.ccodpro.Trim
        Me.txtFactura.Text = entidadActivoF.cnumdoc.Trim
        Me.TextBox4.Text = entidadActivoF.dfecadq
        Me.txtFechaBja.Text = entidadActivoF.dfecbja
        If entidadActivoF.nactdep = 1 Then
            Me.CheckBox1.Checked = True
        Else
            Me.CheckBox1.Checked = False
        End If

        Me.Dropdownlist4.SelectedValue = entidadActivoF.ccodact.Trim & Space(6)
        clac = entidadActivoF.ccodact.Trim

        'Busca la clasificacion del activo
        BuscaClasificacionActivo()
        CargaUbicacion()

        Me.Dropdownlist5.SelectedValue = entidadActivoF.ctipact
        Me.TextBox2.Text = entidadActivoF.cdesbien
        Me.TextBox5.Text = entidadActivoF.nviduti
        Me.TextBox3.Text = entidadActivoF.nvalcpa
        Me.TextBox6.Text = entidadActivoF.nvalres
        Me.Textbox8.Text = entidadActivoF.nvalno

        Me.DropDownList2.SelectedValue = entidadActivoF.ccodadq & Space(6)
        Me.DropDownList1.SelectedValue = entidadActivoF.cestbien & Space(6)
        Me.Dropdownlist7.SelectedValue = entidadActivoF.cunidad.Trim & Space(4)
        Me.DropDownList3.SelectedValue = entidadActivoF.ccodubi & Space(6)
        Me.txtcodEmp.Text = entidadActivoF.ccodemp.Trim

        BuscaEmpleado()
        BuscaNombreProveedor()

        'Carga Parte de TI
        Dim ds As New DataSet
        Dim xx, y As String
        entidadActivoIT.ccodinv = Me.TextBox1.Text.Trim
        eActivoIT.ObtenerActivoIT(entidadActivoIT)

        txtSeri.Text = entidadActivoIT.cnserie
        txtModelo.Text = entidadActivoIT.cmodelo

        xx = EntidadActivoIT.ccodmar
        If xx = Nothing Then
        Else
            cmbMarca.SelectedValue = EntidadActivoIT.ccodmar.Trim
        End If

        y = entidadActivoIT.ccodlin
        If y = Nothing Then
        Else
            cmbMarca.SelectedValue = entidadActivoIT.ccodmar.Trim
        End If
        txtLicencia.Text = entidadActivoIT.cnlicen
        txtUsLog.Text = entidadActivoIT.cusulog
        txtPassLog.Text = entidadActivoIT.cpaslog
        txtPassInter.Text = entidadActivoIT.cpasint
        txtDetalle.Text = EntidadActivoIT.cdetall
        '' Fin de TI

        btnModificar.Enabled = True
        btnNuevo.Enabled = False
        btnGraba.Enabled = False
    End Sub

    Public Sub CargarDetalleActivoIT(ByVal ccodigoCliente As String)
        Dim entidadActivoIT As New SIM.EL.ActivoIT
        Dim eActivoIT As New SIM.BL.cActivoIT
        Dim ds As New DataSet
        Dim x, y As String
        entidadActivoIT.ccodinv = Me.TextBox1.Text.Trim
        eActivoIT.ObtenerActivoIT(entidadActivoIT)

        txtSeri.Text = entidadActivoIT.cnserie
        txtModelo.Text = entidadActivoIT.cmodelo

        x = entidadActivoIT.ccodmar
        If x = Nothing Then
        Else
            cmbMarca.SelectedValue = entidadActivoIT.ccodmar.Trim
        End If

        y = entidadActivoIT.ccodlin
        If y = Nothing Then
        Else
            cmbMarca.SelectedValue = entidadActivoIT.ccodmar.Trim
        End If
        txtLicencia.Text = entidadActivoIT.cnlicen
        txtUsLog.Text = entidadActivoIT.cusulog
        txtPassLog.Text = entidadActivoIT.cpaslog
        txtPassInter.Text = entidadActivoIT.cpasint
        txtDetalle.Text = entidadActivoIT.cdetall
    End Sub

    Private Sub BuscaNombreProveedor()
        Dim entidadCntaEmp As New SIM.EL.cntaemp
        Dim eCntaEmp As New SIM.BL.cCntaemp
        Dim ccodemp As String

        ccodemp = txtNIt.Text.Trim.ToUpper
        entidadCntaEmp.ccodemp = ccodemp.Trim
        eCntaEmp.ObtenerCntaemp(entidadCntaEmp)

        txtNIt.Text = ccodemp
        txtProvee.Text = entidadCntaEmp.cdescri
    End Sub

    Private Sub BuscaEmpleado()
        Dim entidadEmp As New SIM.EL.usuarios
        Dim eEmp As New SIM.BL.cusuarios
        Dim cnombre As String

        cnombre = eEmp.ObtenerNombreUsuario(txtcodEmp.Text.Trim)
        txtEmpleado.Text = cnombre
    End Sub

    Protected Sub btnBuscaProv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscaProv.Click
        BuscaNombreProveedor()
    End Sub

    Protected Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        HabilitaConta()
        HabilitaRH()
        HabilitaSistemas()
        limpiar()
        VarX.Value = 1
        btnModificar.Enabled = False
        btnGraba.Enabled = True
        btnNuevo.Enabled = False
        TextBox5.Text = "5"
    End Sub

    Protected Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim lngrupos As String
        lngrupos = eusuariogrupo.RetornaGrupo(Session("gccodusu"))

        'Comandos IF Deshabilitados por Guillermo
        '----------------------------------------
        'If lngrupos = "6" Or lngrupos = "4" Then

        'ElseIf lngrupos = "35" Then
        '    HabilitaRH()
        'ElseIf lngrupos = "7" Then
        DeshabilitaRH()
        Me.DropDownList3.Enabled = True
        Me.Dropdownlist7.Enabled = True
        'End If
        VarX.Value = 2 'graba modificaciones registro
        btnModificar.Enabled = False
        btnGraba.Enabled = True
    End Sub

    Private Sub GrabaActivo()
        Dim g As Integer
        'Genera codigo
        Dim pccodigo As String
        Dim corigen As String
        Dim ccodofi As String
        Dim etabttab As New cTabttab
        Dim etabtofi As New cTabtofi
        Dim cunidad As String
        Dim ccodact As String
        Dim ctipact As String
        Dim ccodinv As String
        Dim cactdep As Integer
        Dim p As Integer
        Dim ccodusu As String
        Dim unidad As String
        Dim ubicacion As String
        Dim dfectra As DateTime
        Dim lfechadep As DateTime
        Dim entidadActivoF As New SIM.EL.ActivoF
        Dim eActivoF As New SIM.BL.cActivoF

        corigen = Me.DropDownList2.SelectedValue.Trim
        ccodofi = "000"
        cunidad = Me.Dropdownlist7.SelectedValue.Trim   'area responsable
        ccodact = Me.Dropdownlist4.SelectedValue.Trim   'activo 
        ctipact = Me.Dropdownlist5.SelectedValue.Trim   'tipo activo
        unidad = Me.Dropdownlist7.SelectedValue.Trim
        ubicacion = Me.DropDownList3.SelectedValue.Trim

        pccodigo = Me.CodigoGenerado()
        hfinventario.Value = pccodigo
        ccodinv = pccodigo.Trim
        Me.TextBox1.Text = ccodinv

        If CheckBox1.Checked = True Then
            cactdep = 1 'depreciable
        ElseIf CheckBox1.Checked = False Then
            cactdep = 0 'no depreciable
        End If

        Dim lfecadq As DateTime
        Dim ldia As Integer
        Dim lmes As Integer
        Dim lano As Integer

        'aqui valido la fecha de adquisicion
        'ya que de esta dependera la fecha de 
        'depreciación
        lfecadq = Me.TextBox4.Text.Trim

        'ldia = Day(Date.Parse(Me.TextBox4.Text.Trim).AddDays(1))
        'lmes = Month(Date.Parse(Me.TextBox4.Text.Trim).AddDays(1))
        'lano = Year(Date.Parse(Me.TextBox4.Text.Trim).AddDays(1))

        ldia = lfecadq.Day
        lmes = lfecadq.Month
        lano = lfecadq.Year

        If ldia = 1 Then
            lfechadep = lfecadq
        ElseIf ldia > 1 Then
            ldia = 1
            If lmes < 12 Then
                lmes = lmes + 1
            Else
                lmes = 1
                lano = lano + 1
            End If
            If ldia < 10 Then
                ldia = "0" & ldia
            End If
            If lmes < 10 Then
                lmes = "0" & lmes
            End If
            lfechadep = ldia & "/" & lmes & "/" & lano
        End If

        classActivo.cCodinv = pccodigo
        classActivo.ccodofi = Me.Dropdownlist6.SelectedValue.Trim
        classActivo.ffondos = Me.cmbFondos.SelectedValue.Trim
        classActivo.cnrochq = Me.txtNroChq.Text.Trim
        classActivo.cnumcom = Me.txtPartida.Text.Trim
        classActivo.ccodpro = Me.txtNIt.Text.Trim.ToUpper
        classActivo.cnumdoc = Me.txtFactura.Text.Trim.ToUpper
        classActivo.dfecadq = Me.TextBox4.Text.Trim
        classActivo.dfecbja = Me.txtFechaBja.Text.Trim
        classActivo.cunidad = Me.Dropdownlist7.SelectedValue.Trim
        classActivo.ccodubi = Me.DropDownList3.SelectedValue.Trim
        classActivo.ccodemp = Me.cmbUsuarios.SelectedValue.Trim
        classActivo.ccodusu = Me.txtOperador.Text.Trim
        classActivo.nactdep = Integer.Parse(cactdep)
        classActivo.ccodact = Me.Dropdownlist4.SelectedValue.Trim
        classActivo.ctipact = Me.Dropdownlist5.SelectedValue.Trim
        classActivo.cdesbien = Me.TextBox2.Text.Trim

        If TextBox5.Text.Trim <> "" Then
            classActivo.nviduti = Integer.Parse(Me.TextBox5.Text.Trim)
        Else
            classActivo.nviduti = 0
        End If

        If TextBox3.Text.Trim <> "" Then
            classActivo.nvalcpa = Double.Parse(Me.TextBox3.Text.Trim)
        Else
            classActivo.nvalcpa = 0
        End If

        If TextBox6.Text.Trim <> "" Then
            classActivo.nvalres = Double.Parse(Me.TextBox6.Text.Trim)
        Else
            classActivo.nvalres = 0
        End If

        If Textbox8.Text.Trim <> "" Then
            classActivo.nvalno = Double.Parse(Me.Textbox8.Text.Trim)
        Else
            classActivo.nvalno = 0
        End If

        classActivo.ccodadq = Me.DropDownList2.SelectedValue.Trim
        classActivo.cestbien = Me.DropDownList1.SelectedValue.Trim
        classActivo.ccodsec = "001" 'Me.Dropdownlist7.SelectedValue.Trim
        classActivo.cnumser = Me.TextBox7.Text.Trim
        classActivo.dfecdep = lfechadep

        g = classActivo.GrabarActivo()

        Me.TextBox1.Text = ccodinv

        '**** Graba en la tabla activomov
        ccodinv = Me.TextBox1.Text
        ccodusu = Me.txtOperador.Text.Trim
        dfectra = Session("gdfecsis") 'Session("GDFECCTB")
        classActivoM.cCodinv = ccodinv
        classActivoM.ccodusu = ccodusu
        classActivoM.ccodofi = Me.Dropdownlist6.SelectedValue.Trim
        classActivoM.dfectra = dfectra
        classActivoM.cestado = "1"
        p = classActivoM.GrabarMovimiento

        '*****PARTE DE SISTEMAS
        'Solo graba en la tabla ACTIVOIT si el 
        'activo como mismo pertence a computo

        If ccodact = 30 Then
            Dim dfecmod As DateTime
            Dim entidadActivoIT As New SIM.EL.ActivoIT
            Dim eActivoIT As New SIM.BL.cActivoIT

            ccodinv = Me.TextBox1.Text
            ccodusu = Session("gccodusu")
            ccodofi = Me.Dropdownlist6.SelectedValue
            dfecmod = Session("GDFECCTB")
            'Graba en la tabla que lleva el control de movimientos activosIT
            classActivoIt.cCodinv = ccodinv
            classActivoIt.cnSerie = txtSeri.Text
            classActivoIt.cModelo = txtModelo.Text
            classActivoIt.cCodMar = cmbMarca.SelectedValue
            classActivoIt.cCodLin = cmbLinea.SelectedValue
            classActivoIt.cnlicen = txtLicencia.Text
            classActivoIt.cUsuLog = txtUsLog.Text
            classActivoIt.cPaslog = txtPassLog.Text
            classActivoIt.cPasint = txtPassInter.Text
            classActivoIt.cdetalle = txtDetalle.Text
            classActivoIt.dfecmod = dfecmod
            classActivoIt.ccodusu = ccodusu
            classActivoIt.GrabarMovimientoTI()
        End If

        Me.btnGraba.Enabled = True
        Me.btnNuevo.Enabled = True
    End Sub

    Protected Sub btnGraba_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGraba.Click
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim lngrupos As String
        lngrupos = eusuariogrupo.RetornaGrupo(Session("gccodusu"))

        If VarX.Value = 1 Then     'Si es registro nuevo trae Valor 1
            If lngrupos = "6" Or lngrupos = "4" Or lngrupos = "7" Then    'Valida si el perfil es de la conta
                'If lngrupos = "35" Or lngrupos = "7" Then    'Valida si el perfil es de la conta
                'valida datos
                If Me.TextBox2.Text.Trim = "" Then
                    Response.Write("<script language='javascript'>alert('Descripción del Bien Vacía')</script>")
                    Exit Sub
                ElseIf Me.TextBox3.Text.Trim = "" Or Double.Parse(Me.TextBox3.Text.Trim) = 0 Then
                    Response.Write("<script language='javascript'>alert('Valor de Compra del Bien Vacío')</script>")
                    Exit Sub
                ElseIf Me.TextBox5.Text.Trim = "" Or Double.Parse(Me.TextBox5.Text.Trim) = 0 Then
                    Response.Write("<script language='javascript'>alert('Vida Util vacía')</script>")
                    Exit Sub
                ElseIf Me.Textbox8.Text.Trim = "" Then
                    Me.Textbox8.Text = 0
                End If
                GrabaActivo()   'Graba el activo como registro nuevo.
                'GrabaMovimientos()
            End If
        ElseIf VarX.Value = 2 Then
            If lngrupos = "6" Or lngrupos = "4" Then    'Valida si el perfil es de la conta
                'Graba modificaciones hechos por contabilidad
            ElseIf lngrupos = "7" Then
                'Graba datos Informatica
                ActualizaActivo()
            ElseIf lngrupos = "35" Then
                'Graba datos Recursos Humanos
                ActualizaActivo()
            End If
        End If

        DeshabilitaRH()
        DeshabilitarSistemas()
        DeshabilitarConta()
    End Sub

    Protected Sub btnAsignar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
        AsignaEmpleado()
    End Sub

    Private Sub AsignaEmpleado()
        Dim entidadActivoF As New SIM.EL.ActivoF
        Dim eActivoF As New SIM.BL.cActivoF
        Dim ccodusu As String
        Dim ccodinv As String

        ccodinv = TextBox1.Text.Trim
        ccodusu = cmbUsuarios.SelectedValue
        limpiar()
        DeshabilitarConta()
        DeshabilitaRH()
        btnNuevo.Enabled = True
        btnGraba.Enabled = False
    End Sub

    Private Sub GrabaMovimientos()
        Dim g As Integer
        Dim ccodusu As String
        Dim ccodinv As String
        Dim ccodofi As String
        Dim dfectra As DateTime

        ccodinv = hfinventario.Value
        ccodusu = cmbUsuarios.SelectedValue
        ccodofi = Me.Dropdownlist6.SelectedValue
        dfectra = Session("GDFECCTB")
        'Graba en la tabla que lleva el control de movimientos activosMov
        classActivoM.cCodinv = ccodinv
        classActivoM.ccodusu = ccodusu
        classActivoM.ccodofi = Me.Dropdownlist6.SelectedValue
        classActivoM.dfectra = dfectra
        g = classActivoM.GrabarMovimiento
        Me.btnModificar.Enabled = True
    End Sub

    Private Sub GrabaMovimientosRH()
        Dim g As Integer
        Dim ccodusu As String
        Dim ccodinv As String
        Dim ccodofi As String
        Dim unidad As String
        Dim ubicacion As String
        Dim dfectra As DateTime
        Dim entidadActivoF As New SIM.EL.ActivoF
        Dim eActivoF As New SIM.BL.cActivoF

        ccodinv = Me.TextBox1.Text
        ccodusu = cmbUsuarios.SelectedValue
        ccodofi = Me.Dropdownlist6.SelectedValue
        dfectra = Session("GDFECCTB")
        'Graba en la tabla que lleva el control de movimientos activosMov
        classActivoM.cCodinv = ccodinv
        classActivoM.ccodusu = ccodusu
        classActivoM.ccodofi = Me.Dropdownlist6.SelectedValue
        classActivoM.dfectra = dfectra
        classActivo.cunidad = Me.Dropdownlist7.SelectedValue.Trim
        classActivo.ccodubi = Me.DropDownList3.SelectedValue.Trim
        ' Graba en la tabla de activof
        unidad = Me.Dropdownlist7.SelectedValue.Trim
        ubicacion = Me.DropDownList3.SelectedValue.Trim
        eActivoF.AsignarEmpleado(ccodinv, ccodusu, unidad, ubicacion)
        g = classActivoM.UpdateMovimiento
        Me.btnGraba.Enabled = False
        Me.btnNuevo.Enabled = True
    End Sub
    Private Sub GrabaMovimientosTI()
        Dim g As Integer
        Dim ccodusu As String
        Dim ccodinv As String
        Dim ccodofi As String
        Dim dfecmod As DateTime
        Dim entidadActivoIT As New SIM.EL.ActivoIT
        Dim eActivoIT As New SIM.BL.cActivoIT

        ccodinv = Me.TextBox1.Text
        ccodusu = Session("gccodusu")
        ccodofi = Me.Dropdownlist6.SelectedValue
        dfecmod = Session("GDFECCTB")
        'Graba en la tabla que lleva el control de movimientos activosIT
        classActivoIT.cCodinv = ccodinv
        classActivoIt.cnserie = txtSeri.Text
        classActivoIt.cmodelo = txtModelo.Text
        classActivoIt.ccodmar = cmbMarca.SelectedValue
        classActivoIt.ccodlin = cmbLinea.SelectedValue
        classActivoIT.cnlicen = txtLicencia.Text
        classActivoIt.cusulog = txtUsLog.Text
        classActivoIt.cPaslog = txtPassLog.Text
        classActivoIt.cPasint = txtPassInter.Text
        classActivoIt.cdetalle = txtDetalle.Text
        classActivoIt.dfecmod = dfecmod
        classActivoIt.ccodusu = ccodusu
        classActivoIt.GrabarMovimientoTI()
        Me.btnGraba.Enabled = False
        Me.btnNuevo.Enabled = True
    End Sub
    Private Sub UpdateMovimientosTI()
        Dim ccodusu As String
        Dim ccodinv As String
        Dim ccodofi As String
        Dim dfecmod As DateTime
        Dim entidadActivoIT As New SIM.EL.ActivoIT
        Dim eActivoIT As New SIM.BL.cActivoIT

        ccodinv = Me.TextBox1.Text
        ccodusu = Session("gccodusu")
        ccodofi = Me.Dropdownlist6.SelectedValue
        dfecmod = Session("GDFECCTB")
        'Graba en la tabla que lleva el control de movimientos activosIT
        classActivoIt.cCodinv = ccodinv
        classActivoIt.cnSerie = txtSeri.Text
        classActivoIt.cModelo = txtModelo.Text
        classActivoIt.cCodMar = cmbMarca.SelectedValue
        classActivoIt.cCodLin = cmbLinea.SelectedValue
        classActivoIt.cnlicen = txtLicencia.Text
        classActivoIt.cUsuLog = txtUsLog.Text
        classActivoIt.cPaslog = txtPassLog.Text
        classActivoIt.cPasint = txtPassInter.Text
        classActivoIt.cdetalle = txtDetalle.Text
        classActivoIt.dfecmod = dfecmod
        classActivoIt.ccodusu = ccodusu
        classActivoIt.GrabarMovimientoTI()
        Me.btnGraba.Enabled = False
        Me.btnNuevo.Enabled = True
    End Sub
    Private Sub ActualizaActivo()
        Dim g As Integer
        Dim p As Integer
        Dim ccodusu As String
        Dim corigen As String
        Dim ccodofi As String
        Dim etabttab As New cTabttab
        Dim etabtofi As New cTabtofi
        Dim cunidad As String
        Dim ccodact As String
        Dim ctipact As String
        Dim ccodinv As String
        Dim cactdep As Integer
        Dim dfectra As DateTime
        Dim entidadActivoF As New SIM.EL.ActivoF
        Dim eActivoF As New SIM.BL.cActivoF

        corigen = Me.DropDownList2.SelectedValue.Trim
        ccodofi = "000"
        cunidad = Me.Dropdownlist7.SelectedValue.Trim   'area responsable
        ccodact = Me.Dropdownlist4.SelectedValue.Trim   'activo 
        ctipact = Me.Dropdownlist5.SelectedValue.Trim   'tipo activo

        ccodinv = Me.TextBox1.Text

        If CheckBox1.Checked = True Then
            cactdep = 1
        ElseIf CheckBox1.Checked = False Then
            cactdep = 0
        End If

        classActivo.cCodinv = Me.TextBox1.Text
        classActivo.ccodofi = Me.Dropdownlist6.SelectedValue.Trim
        classActivo.ffondos = Me.cmbFondos.SelectedValue.Trim
        classActivo.cnrochq = Me.txtNroChq.Text.Trim
        classActivo.cnumcom = Me.txtPartida.Text.Trim
        classActivo.ccodpro = Me.txtNIt.Text.Trim.ToUpper
        classActivo.cnumdoc = Me.txtFactura.Text.Trim.ToUpper
        classActivo.dfecadq = Me.TextBox4.Text.Trim
        classActivo.dfecbja = Me.txtFechaBja.Text.Trim
        classActivo.ccodemp = Me.cmbUsuarios.SelectedValue.Trim
        classActivo.ccodusu = Me.txtOperador.Text.Trim
        classActivo.nactdep = Integer.Parse(cactdep)
        classActivo.ccodact = Me.Dropdownlist4.SelectedValue.Trim
        classActivo.ctipact = Me.Dropdownlist5.SelectedValue.Trim
        classActivo.cdesbien = Me.TextBox2.Text.Trim
        classActivo.nviduti = Integer.Parse(Me.TextBox5.Text.Trim)
        classActivo.nvalcpa = Double.Parse(Me.TextBox3.Text.Trim)
        classActivo.nvalres = Double.Parse(Me.TextBox6.Text.Trim)
        classActivo.nvalno = Double.Parse(Me.Textbox8.Text.Trim)
        classActivo.ccodadq = Me.DropDownList2.SelectedValue.Trim
        classActivo.cestbien = Me.DropDownList1.SelectedValue.Trim
        classActivo.ccodsec = "001"
        classActivo.ccodubi = Me.DropDownList3.SelectedValue.Trim
        classActivo.cnumser = Me.TextBox7.Text.Trim
        classActivo.cunidad = Me.Dropdownlist7.SelectedValue.Trim
        g = classActivo.UpdateActivo()
        'Me.TextBox1.Text = ccodinv

        '**** PARTE DE ADMON
        ccodinv = Me.TextBox1.Text
        ccodusu = Me.txtOperador.Text.Trim
        dfectra = Session("GDFECCTB")

        'Graba en la tabla que lleva el control de movimientos activosMov
        classActivoM.cCodinv = ccodinv
        classActivoM.ccodusu = ccodusu
        classActivoM.ccodofi = Me.Dropdownlist6.SelectedValue.Trim
        classActivoM.dfectra = dfectra
  
        ' Graba en la tabla de activof
        p = classActivoM.UpdateMovimiento

        '*****PARTE DE SISTEMAS
        Dim dfecmod As DateTime
        Dim entidadActivoIT As New SIM.EL.ActivoIT
        Dim eActivoIT As New SIM.BL.cActivoIT

        ccodinv = Me.TextBox1.Text
        ccodusu = Session("gccodusu")
        ccodofi = Me.Dropdownlist6.SelectedValue
        dfecmod = Session("GDFECCTB")
        'Graba en la tabla que lleva el control de movimientos activosIT
        classActivoIt.cCodinv = ccodinv
        classActivoIt.cnSerie = txtSeri.Text
        classActivoIt.cModelo = txtModelo.Text
        classActivoIt.cCodMar = cmbMarca.SelectedValue
        classActivoIt.cCodLin = cmbLinea.SelectedValue
        classActivoIt.cnlicen = txtLicencia.Text
        classActivoIt.cUsuLog = txtUsLog.Text
        classActivoIt.cPaslog = txtPassLog.Text
        classActivoIt.cPasint = txtPassInter.Text
        classActivoIt.cdetalle = txtDetalle.Text
        classActivoIt.dfecmod = dfecmod
        classActivoIt.ccodusu = ccodusu
        classActivoIt.UpdateMovimientoTI()
        Me.btnGraba.Enabled = True
        Me.btnNuevo.Enabled = False
        Me.btnModificar.Enabled = False
    End Sub

    Protected Sub cmbUsuarios_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUsuarios.SelectedIndexChanged
        'Me.txtEmpleado.Text = Me.cmbUsuarios.SelectedValue.Trim
    End Sub

End Class