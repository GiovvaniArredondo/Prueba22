Public Class WbSolcredbc
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
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private cls_Sim As New SIM.bl.ClsSolicitud

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
    Private gcCodUsu As String = ""
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
#End Region
    

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Dim lId As String = Request.QueryString("id")
            'Me.txtcodcli.Value = lId
            Me.CargarDatos()
        End If

    End Sub

#Region " Metodos "
    Private Sub CargarDatos()
        gcCodUsu = Session("gccodusu")
        '----------------------------
        'Llenando destino del Credito
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,1) as cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0051'"
        'cls1.Cnn = vConexion
        'Transacc = LibSim.ClsMantenimiento(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            '   MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        'Dim fila1 As DataRow
        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.cbxdescre.Items.Add(fila1("cCodigo") & "   --" & " " & fila1("cDescri"))
        'Next
        'Me.cbxdescre.SelectedIndex = 0

        Me.cbxdescre.DataTextField = "cDescri"
        Me.cbxdescre.DataValueField = "cCodigo"
        Me.cbxdescre.DataSource = ds.Tables("Resultado")
        Me.cbxdescre.DataBind()


        'Me.cbxdescre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        '----------------------------
        'Llenando Sector Económico
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,1) as ccodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0211'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.cbxsececo.Items.Add(fila1("cCodigo") & "   --" & " " & fila1("cDescri"))
        'Next
        'Me.cbxsececo.SelectedIndex = 0

        Me.cbxsececo.DataTextField = "cDescri"
        Me.cbxsececo.DataValueField = "cCodigo"
        Me.cbxsececo.DataSource = ds.Tables("Resultado")
        Me.cbxsececo.DataBind()


        'Me.cbxsececo.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        '----------------------------
        'Llenando Programa
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0331'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.cbxprograma.Items.Add(fila1("cCodigo") & "   --" & " " & fila1("cDescri"))
        'Next
        'Me.cbxprograma.SelectedIndex = 0


        Me.cbxprograma.DataTextField = "cDescri"
        Me.cbxprograma.DataValueField = "cCodigo"
        Me.cbxprograma.DataSource = ds.Tables("Resultado")
        Me.cbxprograma.DataBind()


        'Me.cbxprograma.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        '----------------------------
        'Llenando Analistas
        '----------------------------
        lnparametro1_R = "cNomUsu , cCodUsu, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTUSU"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCatego ='ANA' and cEstado = 'A' "
        If Session("gcCodofi") = "001" Then
        Else
            lnparametro6_R = lnparametro6_R & " and cCodofi =  " & Session("gcCodofi")
        End If

        lnparametro6_R = lnparametro6_R & " order by CNOMUSU "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxanacre.DataTextField = "cNomUsu"
        Me.cbxanacre.DataValueField = "cCodUsu"
        Me.cbxanacre.DataSource = ds.Tables("Resultado")
        Me.cbxanacre.DataBind()

        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        ds = etabtofi.ObtenerDataSetPorNivel2(Session("gnNivel"), Session("gcCodOfi"))

        'lnparametro1_R = "cNomOfi , cCodOfi, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTOFI"
        'lnparametro5_R = "S"
        'lnparametro6_R = " "
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.CbxCodOFi.DataTextField = "cNomOfi"
        Me.CbxCodOFi.DataValueField = "cCodOfi"
        Me.CbxCodOFi.DataSource = ds.Tables(0)
        Me.CbxCodOFi.DataBind()


        'Me.CbxCodOFi.DropDownWidth = 300
        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Institucion
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0541'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.cbxCodins.Items.Add(fila1("cCodigo") & "   --" & " " & fila1("cDescri"))
        'Next
        'Me.cbxCodins.SelectedIndex = 0
        Me.cbxCodins.DataTextField = "cDescri"
        Me.cbxCodins.DataValueField = "cCodigo"
        Me.cbxCodins.DataSource = ds.Tables("Resultado")
        Me.cbxCodins.DataBind()


        'Me.ComboBox1.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        ''-------------------------------

        'Actividad
        Dim clsTabtciu As New SIM.BL.cTabtciu
        Dim mTabtciu As New listatabtciu

        mTabtciu = clsTabtciu.ObtenerLista()


        Me.cmbactividad.DataTextField = "cdescri"
        Me.cmbactividad.DataValueField = "ccodigo"
        Me.cmbactividad.DataSource = mTabtciu
        Me.cmbactividad.DataBind()
        Me.cmbactividad.Enabled = True

        '' Carga Lineas de Credito      '
        ''-------------------------------
        'lnparametro1_R = "cNrolin , cCodlin, cDeslin, "
        'lnparametro2_R = "S,S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "CRETLIN"
        'lnparametro5_R = "S"
        'lnparametro6_R = " "
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    MsgBox("No existen Líneas de Crédito", MsgBoxStyle.Information, "Aviso")
        '    Exit Sub
        'Else
        '    pcNrolin = ds.Tables("Resultado").Rows(0)("cNrolin")
        'End If
        ds.Tables("Resultado").Rows.Clear()
        ds.Tables("Resultado").Columns.Clear()
        Me.txtfecasi.Value = Session("gdFecSis")



        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Institucion
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as ccodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0841'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        'For Each fila1 In ds.Tables("Resultado").Rows
        '    Me.cbxCodins.Items.Add(fila1("cCodigo") & "   --" & " " & fila1("cDescri"))
        'Next
        'Me.cbxCodins.SelectedIndex = 0
        Me.cbxCargo.DataTextField = "cDescri"
        Me.cbxCargo.DataValueField = "cCodigo"
        Me.cbxCargo.DataSource = ds.Tables("Resultado")
        Me.cbxCargo.DataBind()


        'Me.ComboBox1.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        ''-------------------------------
        '----------------------------
        'Llenando Centros
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CENTROS"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1' order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxcentros.DataTextField = "cNomgru"
        Me.cbxcentros.DataValueField = "cCodsol"
        Me.cbxcentros.DataSource = ds.Tables("Resultado")
        Me.cbxcentros.DataBind()

        Me.cbxcentros.Visible = False
        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        cargaGrupos()
    End Sub
    Private Sub BuscaCredito()
        Me.btnGuardar.Disabled = False
        Me.Habilita()

        '----------------------------
        'Carga Datos de Solicitud
        '----------------------------
        pcCodCta = Me.cbxCodins.Value.Substring(0, 3) & Me.CbxCodOFi.Value.Substring(0, 3) & Me.txtNroCta.Value.Trim
        Dim fila2 As Integer
        lnparametro1_R = "cCodCta, cEstado, cCodCli, cCodFue, cTipCre, cDesCre, cNorRef, dFecAsi,dFecSol, nMonSol,cNroLin, cCondic, cCodAna, cMoneda, cCodPrd, cClaCre, cCodUsu, dFecMod, csececo, nciclo, cTipGar, cCodAct, ccargo, ccodsol, "
        lnparametro2_R = "S,S,S,S,S,S,S,F,F,D,S,S,S,S,S,S,S,F,S,I,S,S,S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMCRE"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodCta =" & "'" & pcCodCta & "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds.Tables("Resultado").Rows.Clear()
        ds.Tables("Resultado").Columns.Clear()
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            '            MsgBox("Crédito No Existe", MsgBoxStyle.Information, "Aviso")
            Response.Write("<script language='javascript'>alert('Crédito No Existe')</script>")
            '            InitVar()
            Me.lblMostrar.Text = "NUEVO"
            Exit Sub
        Else
            'Me.Label11.Text = "MODIFICACION"
            Me.lblMostrar.Text = "MODIFICACION"

            'Fuente de Ingreso
            Me.cbxfueing.Value = Trim(ds.Tables("Resultado").Rows(0)("cCodFue"))

            'Destino del Credito
            Me.cbxdescre.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("cDesCre"))

            'Sector Economico
            Me.cbxsececo.Value = Trim(ds.Tables("Resultado").Rows(0)("cSecEco"))

            'Programa
            Me.cbxprograma.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("ccodfue"))

            'Monto Solicitado
            Me.txtmonsol.Value = ds.Tables("Resultado").Rows(0)("nMonSol")
            'Fecha de Solicitud
            'Me.DateTimePicker1.Value = ds.Tables("Resultado").Rows(0)("dFecAsi")
            Me.txtfecasi.Value = ds.Tables("Resultado").Rows(0)("dFecAsi")
            'Analista

            Me.cbxanacre.Value = Trim(ds.Tables("Resultado").Rows(0)("cCodAna"))
            Me.cmbactividad.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("cCodAct"))

            Me.cbxCargo.Value = Trim(IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("cCargo")), "03", ds.Tables("Resultado").Rows(0)("cCargo")))

            'Buscar Centro
            Dim lccodcen As String
            Dim lccodsol As String
            Dim egrupos As New cgrupos
            'lccodcen = egrupos.ObtenerIDCentro(Trim(IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("cCodsol")), "001001000000", ds.Tables("Resultado").Rows(0)("cCodsol"))))
            lccodsol = Trim(IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("cCodsol")), "001001000000", ds.Tables("Resultado").Rows(0)("cCodsol")))
            'Me.cbxcentros.SelectedValue = Trim(IIf(IsDBNull(lccodcen), "001001000000", lccodcen))
            'cargaGrupos()

            Me.cbxgrupos.SelectedValue = lccodsol.Trim


        End If
        ds.Tables("Resultado").Rows.Clear()
        ds.Tables("Resultado").Columns.Clear()

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcodcli.Value = codigoCliente
        Dim ecremcre As New cCremcre
        Dim lvalida As Boolean
        lvalida = ecremcre.ValidaSolicitudPendiente(codigoCliente)
        If lvalida = True Then 'tiene solicitudes pendientes
            Response.Write("<script language='javascript'>alert('Cliente tiene Solicitud Pendiente ')</script>")
            Return
        End If

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.txtcodcli.Value.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim
        Dim lccodsol As String
        lccodsol = IIf(IsDBNull(entidadClimide.ccodsol) Or entidadClimide.ccodsol = Nothing, "", entidadClimide.ccodsol)
        If lccodsol.Trim = "" Then
        Else
            Me.cbxgrupos.SelectedValue = lccodsol
        End If

        Me.btnAplica_ServerClick(Me, New System.EventArgs)
    End Sub

    Private Sub Deshabilitar()
        Me.cbxfueing.Items.Clear()
        Me.txtmonsol.Value = " "
        Me.txtNroCta.Value = " "
        'Me.txtnomcli.Value = " "
        Me.txtcodcli.Value = " "
        Me.txtfecasi.Value = Session("gdfecsis")
        Me.btnGuardar.Disabled = True
        Me.lblMostrar.Text = " "
        Me.cbxdescre.Enabled = False
        Me.cbxanacre.Disabled = True
        'Me.cbxCodins.Disabled = False
        Me.cbxfueing.Disabled = True
        Me.cbxfueing.Disabled = True
        Me.cbxprograma.Enabled = False
        Me.cbxsececo.Disabled = True
        Me.txtfecasi.Disabled = True
        Me.txtmonsol.Disabled = True
        Me.txtccodtmp.Enabled = False
        Me.cmbactividad.Enabled = False
    End Sub


    Private Sub Habilita()
        Me.cbxdescre.Enabled = True
        Me.cbxanacre.Disabled = False
        'Me.cbxCodins.Disabled = False
        Me.cbxfueing.Disabled = False
        Me.cbxfueing.Disabled = False
        Me.cbxprograma.Enabled = True
        Me.cbxsececo.Disabled = False
        Me.txtfecasi.Disabled = False
        Me.txtmonsol.Disabled = False
        Me.cmbactividad.Enabled = True
        If Me.lblMostrar.Text = "NUEVO" Then
            Me.txtccodtmp.Enabled = True
            Me.validacodigo()
        End If
    End Sub
    Private Sub validacodigo()
        Me.txtccodtmp.Text = Me.cbxCodins.Value.Trim & Me.CbxCodOFi.Value.Trim & "01" & "1"
    End Sub
#End Region

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Response.Redirect("WbBusCli.aspx")
        '   Me.btnAplica_ServerClick(sender, e)

    End Sub

    Private Sub btnAplica_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplica.ServerClick
        '---------------------------
        'Busca el Sector Economico
        '---------------------------
        Dim lcsececo As String
        Dim eclidfin As New cClidfin
        lcsececo = eclidfin.BuscarSectorEconomico(Me.txtcodcli.Value.Trim)

        Me.cbxsececo.Value = lcsececo.Trim
        Me.cmbactividad.SelectedValue = eclidfin.BuscarActividad(Me.txtcodcli.Value.Trim)

        '---------------------------
        'Busca el Cliente
        '---------------------------
        Dim pcCodcli As String
        Dim fila1 As DataRow
        pcCodcli = Me.txtcodcli.Value
        lnparametro1_R = "cCodFue, cNomFue, cCodAct, "
        lnparametro2_R = "S,S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CLIDFIN"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodcli =" & "'" & pcCodcli & "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'MsgBox("No Tiene Fuente de Ingresos", MsgBoxStyle.Information, "Aviso")
            'Response.Write("<script language='javascript'>alert('No Tiene Fuente de Ingresos')</script>")
            'Exit Sub
        Else
            Me.cbxfueing.DataTextField = "cNomfue"
            Me.cbxfueing.DataValueField = "cCodfue"
            Me.cbxfueing.DataSource = ds.Tables("Resultado")
            Me.cbxfueing.DataBind()

            ds.Tables("Resultado").Clear()
        End If

        '----------------------------------------
        'Verifica estado de prestamos del Cliente
        '---------------------------------------
        lnparametro1_R = "cCodCta , cEstado, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMCRE"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodcli =" & "'" & pcCodcli & "'" & " and cestado = 'A' "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'lNuevo = True
            'Me.lNuevo = True
            pcTipCre = "N"
            Me.TxtTipcre.Text = "N"
            pnCiclo = 1
            'Revar()
            Me.lblMostrar.Text = "NUEVO"
            Me.btnGuardar.Disabled = False
            Me.Habilita()

        Else
            ' Me.lNuevo = False
            Dim pestado As String
            For Each fila1 In ds.Tables("Resultado").Rows
                pestado = fila1("cEstado")
                'Grabar R Solo si ya tuvo credito
                pcTipCre = "R"
                Me.TxtTipcre.Text = "N"
                pnCiclo = ds.Tables("Resultado").Rows.Count + 1
                Select Case pestado
                    Case "A"
                        pcCodCta = fila1("cCodCta")
                        Me.txtNroCta.Value = pcCodCta.Substring(6, 12)

                        'Institución                        
                        Me.cbxCodins.Value = pcCodCta.Substring(0, 3)

                        'Oficina                        
                        Me.CbxCodOFi.Value = pcCodCta.Substring(3, 3)

                        'llamas todos los Datos del credito
                        '                    Me.btnAplica_ServerClick(sender, e)
                        Me.BuscaCredito()


                    Case "C" Or "E"

                    Case "F"

                    Case "G"


                End Select
                Exit For
            Next
            ds.Tables("Resultado").Clear()

        End If

        'Verifica Tipo de Garantia
        lnparametro1_R = "cTipGar, cCodcli, "
        lnparametro2_R = "S, S, "
        lnparametro3_R = " "
        lnparametro4_R = "CLIMGAR"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodcli =" & "'" & pcCodcli & "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)

        If ds.Tables("Resultado").Rows.Count <= 0 Then
            pcTipGar = "01"
            Me.TxtTipgar.Text = "01"
        Else
            For Each fila1 In ds.Tables("Resultado").Rows
                pcTipGar = fila1("cTipGar")
                Me.TxtTipgar.Text = fila1("cTipGar")
                Dim lctipgar As String
                lctipgar = Left(Me.TxtTipgar.Text.Trim, 2)
                Me.TxtTipgar.Text = lctipgar
            Next
            ds.Tables("Resultado").Clear()
        End If
        '-------------------------


        Me.cbxCodins.Disabled = False
        Me.CbxCodOFi.Disabled = False
        Me.txtNroCta.Disabled = True
    End Sub

   

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.Deshabilitar()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.cbxgrupos.Visible = True
        Me.cbxCargo.Visible = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.cbxgrupos.Visible = False
        Me.cbxCargo.Visible = False
    End Sub

    Protected Sub btnGuardar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.ServerClick
        Me.RangeValidator1.Validate()
        If Me.RangeValidator1.IsValid = False Then
            Exit Sub
        End If
        '------------------------------------------------------------
        'Cambio para utilizarlo todo desde la Clase
        '------------------------------------------------------------
        Dim Valor As String
        cls_Sim.Fuente = IIf(Me.cbxfueing.Value.Trim = "", "01", Me.cbxfueing.Value)
        'cls_Sim.Fuente = Me.cbxfueing.Value                 'Fuente de Ingreso
        cls_Sim.Destino = Me.cbxdescre.SelectedValue.Trim           'Destino del Credito
        cls_Sim.dFecAsig = Me.txtfecasi.Value.Trim          'Fecha de Asignacion
        cls_Sim.Monto = Me.txtmonsol.Value.Trim             'Monto Solicitado
        cls_Sim.Sector = Me.cbxsececo.Value.Trim            'Sector Economico
        cls_Sim.Programa = Me.cbxprograma.SelectedValue.Trim        'Programa
        cls_Sim.Analista = Me.cbxanacre.Value.Trim          'Analista
        cls_Sim.Codigo = Me.txtcodcli.Value.Trim            'Codigo del cliente
        cls_Sim.Institucion = Me.cbxCodins.Value            'Institucion
        cls_Sim.Oficina = Me.CbxCodOFi.Value                'Oficina
        cls_Sim.Tipo = Me.lblMostrar.Text.Trim
        cls_Sim.Cuenta = Me.txtNroCta.Value.Trim
        cls_Sim.pnCiclo = pnCiclo
        cls_Sim.pnTipcre = Me.TxtTipcre.Text
        cls_Sim.pnTipgar = Me.TxtTipgar.Text
        cls_Sim.cCodAct = Me.cmbactividad.SelectedValue
        cls_Sim.ctipgar = " "

        cls_Sim._gcCodusu = Session("gcCodusu")
        cls_Sim._ctipomet = IIf(Me.RadioButton1.Checked = True, "01", "02")
        cls_Sim._ccodsol = IIf(Me.RadioButton1.Checked = True, "001001000000", Me.cbxgrupos.SelectedValue.Trim)
        cls_Sim._ccargo = IIf(Me.RadioButton1.Checked = True, "03", Me.cbxCargo.Value.Trim)
        Valor = cls_Sim.Graba_Solicitud

        If Valor = "0" Then
            Exit Sub
        Else
            If Valor = "9" Then
                Response.Write("<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas ')</script>")
                Exit Sub
            Else
                If Valor <> "" Then
                    Response.Write("<script language='javascript'>alert('El Cuenta Generado es  " & Valor & " ')</script>")
                Else
                    Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")
                End If
            End If
        End If

        Me.Deshabilitar()
        Me.cbxfueing.Items.Clear()
    End Sub

    Protected Sub cbxcentros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcentros.SelectedIndexChanged
        cargaGrupos()
    End Sub

    Private Sub cargaGrupos()
        Dim lccodcen As String
        lccodcen = Me.cbxcentros.SelectedValue.Trim
        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , left(cCodsol,12) as cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1' and cCodcen = " & "'" & lccodcen & "'" & "  order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxgrupos.DataTextField = "cNomgru"
        Me.cbxgrupos.DataValueField = "cCodsol"
        Me.cbxgrupos.DataSource = ds.Tables("Resultado")
        Me.cbxgrupos.DataBind()

        Me.cbxgrupos.Visible = True
        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
    End Sub
    Private Sub cargatodosGrupos()
        
        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1'  order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxgrupos.DataTextField = "cNomgru"
        Me.cbxgrupos.DataValueField = "cCodsol"
        Me.cbxgrupos.DataSource = ds.Tables("Resultado")
        Me.cbxgrupos.DataBind()

        Me.cbxgrupos.Visible = True
        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
    End Sub
End Class
