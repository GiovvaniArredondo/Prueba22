Public Class WbSolind
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
    Private codigoJs As String


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
    

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Dim lId As String = Request.QueryString("id")
            'Me.txtcodcli.Value = lId
            Me.CargarDatos()
            CargaGrid()
        End If

    End Sub

#Region " Metodos "
    Private Sub CargarDatos()
        gcCodUsu = Session("gccodusu")
        '----------------------------
        'Llenando destino del Credito
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as cCodigo, "
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
        lnparametro6_R = "Where cCatego ='ANA' and cEstado = 'A' and cCodUsu IN (SELECT usuario from usuarios where " & _
        " lactivo = 1 )"
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

        'Obtener Region de Usuario
        '        Session("gnNivel")
        Dim lccodins As String
        Dim etabtofi As New cTabtofi
        lccodins = etabtofi.ObtenerRegiondeUsuario(Session("gccodusu"))
        '----------------------------
        'Llenando Institucion
        '----------------------------
        Dim etabttab As New cTabttab
        ds = etabttab.ObtenerDatasetTabla("054", lccodins)

        
        Me.cbxCodins.DataTextField = "cDescri"
        Me.cbxCodins.DataValueField = "cCodigo"
        Me.cbxcodins.DataSource = ds.Tables(0)
        Me.cbxCodins.DataBind()

        ds.Tables(0).Clear()

        CargarOficina()
        'Me.ComboBox1.DropDownWidth = 300

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
        Me.txtfecasi.Value = Session("gdFecSis")

        ds.Tables(0).Clear()
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

        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Programa
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as ccodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1001'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cmbprograma.DataTextField = "cDescri"
        Me.cmbprograma.DataValueField = "cCodigo"
        Me.cmbprograma.DataSource = ds.Tables("Resultado")
        Me.cmbprograma.DataBind()
        'Me.cmbprograma.Enabled = True

        Me.CbxClasifCred1.Recuperar()
        CbxClasifCred1.Selectedvalue = "N"
        cargaGrupos()
        Deshabilitar()
    End Sub
    Private Sub BuscaCredito()
        Me.btnGuardar.Disabled = False
        Me.Habilita()

        '----------------------------
        'Carga Datos de Solicitud
        '----------------------------
        pcCodCta = Me.cbxcodins.SelectedValue.Trim.Substring(0, 3) & Me.CbxCodOFi.Value.Substring(0, 3) & Me.txtNroCta.Value.Trim
        Dim fila2 As Integer
        lnparametro1_R = "cCodCta, cEstado, cCodCli, cCodFue, cTipCre, cDesCre, cNorRef, dFecAsi,dFecSol, nMonSol,cNroLin, cCondic, cCodAna, cMoneda, cCodPrd, cClaCre, cCodUsu, dFecMod, csececo, nciclo, cTipGar, cCodAct, ccargo, ccodsol, lsegvid,cprograma,cfueing, digitaliza_foto,"
        lnparametro2_R = "S,S,S,S,S,S,S,F,F,D,S,S,S,S,S,S,S,F,S,I,S,S,S,S,B, S,S,S,"
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
            '            Response.Write("<script language='javascript'>alert('Crédito No Existe')</script>")
            codigoJs = "<script language='javascript'>alert('Crédito No Existe, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            '            InitVar()
            Me.lblMostrar.Text = "NUEVO"
            Exit Sub
        Else
            'Me.Label11.Text = "MODIFICACION"
            Me.lblMostrar.Text = "MODIFICACION"

            'Fuente de Ingreso
            Try

                If IsDBNull(ds.Tables("Resultado").Rows(0)("cfueing")) Then
                Else
                    Me.cbxfueing.Value = Trim(ds.Tables("Resultado").Rows(0)("cfueing"))
                End If

                'Destino del Credito
                If IsDBNull(ds.Tables("Resultado").Rows(0)("cDesCre")) Then
                Else
                    Me.cbxdescre.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("cDesCre"))
                End If
                'Sector Economico
                If IsDBNull(ds.Tables("Resultado").Rows(0)("cSecEco")) Then
                Else
                    Me.cbxsececo.Value = Trim(ds.Tables("Resultado").Rows(0)("cSecEco"))
                End If

                'Monto Solicitado
                Me.txtmonsol.Value = ds.Tables("Resultado").Rows(0)("nMonSol")
                'Fecha de Solicitud
                'Me.DateTimePicker1.Value = ds.Tables("Resultado").Rows(0)("dFecAsi")
                Me.txtfecasi.Value = ds.Tables("Resultado").Rows(0)("dFecAsi")
                'Analista

                Me.cbxanacre.Value = Trim(ds.Tables("Resultado").Rows(0)("cCodAna"))
                Me.cmbactividad.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("cCodAct"))
                Me.CbxClasifCred1.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("ctipcre"))
                Me.cbxCargo.Value = Trim(IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("cCargo")), "03", ds.Tables("Resultado").Rows(0)("cCargo")))

                'Programa
                If IsDBNull(ds.Tables("Resultado").Rows(0)("cprograma")) Then
                Else
                    Me.cmbprograma.SelectedValue = Trim(ds.Tables("Resultado").Rows(0)("cprograma"))
                End If
            Catch ex As Exception

            End Try
            'Buscar Centro
            Dim lccodcen As String
            Dim lccodsol As String
            Dim egrupos As New cgrupos
            lccodcen = egrupos.ObtenerIDCentro(Trim(IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("cCodsol")), "001001000000", ds.Tables("Resultado").Rows(0)("cCodsol"))))
            lccodsol = Trim(IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("cCodsol")), "001001000000", ds.Tables("Resultado").Rows(0)("cCodsol")))
            Me.cbxcentros.SelectedValue = Trim(IIf(IsDBNull(lccodcen), "001001000000", lccodcen))
            Chkseguro.Checked = IIf(IsDBNull(ds.Tables("Resultado").Rows(0)("lsegvid")), False, ds.Tables("Resultado").Rows(0)("lsegvid"))
            cargaGrupos()

            Me.cbxgrupos.SelectedValue = lccodsol.Trim
            CargaGridCredito(pcCodCta)

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
            '            Response.Write("<script language='javascript'>alert('Cliente tiene Solicitud Pendiente ')</script>")
            codigoJs = "<script language='javascript'>alert('Cliente tiene Solicitud Pendiente, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Deshabilitar()
            Return
        End If

        'Valida si puede ingresar 
        Dim Valida_Creditos As String = ""
        Valida_Creditos = ecremcre.Buscar_Creditos_codigos(codigoCliente)

        If Valida_Creditos = "F" Or Valida_Creditos = "C" Or Valida_Creditos = "E" Then 'Tiene Credito actual
            '            Response.Write("<script language='javascript'>alert('Cliente tiene Solicitud Pendiente ')</script>")
            codigoJs = "<script language='javascript'>alert('Cliente tiene Solicitud Pendiente, " & _
                                                    "Advertencia SIM.NET '); location.href='WbSolicind.aspx'; </script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Deshabilitar()
            Return
        End If


        'codigoJs = "<script language='javascript'>alert('El estatus del Grupo no es SOLICITUD O SUGERIDO " & _
        '                           "Advertencia SIM.NET '); location.href='WBSUGLOTE.ASPX'; </script>"
        'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        'Verifica que no tenga credito vigente, segun politica de Mexico no es permitido, comentariado por Refinanciados, y creditos de oportunidad
        If ecremcre.Valida_Creditos_Vigentes_porCliente(Me.txtcodcli.Value.Trim) Then
            codigoJs = "<script language='javascript'>alert('Cliente tiene creditos activos, Imposible continuar, " & _
                        "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Deshabilitar()
            Exit Sub
        End If


        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.txtcodcli.Value.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim


        Me.btnAplica_ServerClick(Me, New System.EventArgs)
    End Sub

    Private Sub Deshabilitar()
        Me.cbxfueing.Items.Clear()
        'Me.txtmonsol.Value = 0.0
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
        Me.CbxClasifCred1.Enabled = False
        cbxprograma.Enabled = False
    End Sub


    Private Sub Habilita()
        Me.cbxdescre.Enabled = True
        Me.cbxanacre.Disabled = False
        'Me.cbxCodins.Disabled = False
        Me.cbxfueing.Disabled = False
        Me.cbxfueing.Disabled = False
        Me.cbxprograma.Enabled = True
        Me.cbxsececo.Disabled = False
        'Me.txtfecasi.Disabled = False
        Me.txtmonsol.Disabled = False
        Me.cmbactividad.Enabled = True
        Me.CbxClasifCred1.Enabled = True
        cmbprograma.Enabled = True

        If Me.lblMostrar.Text = "NUEVO" Then
            txtmonsol.Value = 0.0
            Me.txtccodtmp.Enabled = True
            Me.validacodigo()
        End If
    End Sub
    Private Sub validacodigo()
        Me.txtccodtmp.Text = Me.cbxcodins.SelectedValue.Trim & Me.CbxCodOFi.Value.Trim & "01" & "1"
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
        lnparametro1_R = "(ctiprel+ccodfue) as cCodFue, cNomFue, cCodAct, "
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
                        Me.cbxcodins.SelectedValue = pcCodCta.Substring(0, 3)
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

        '        txtmonsol.Value = 0.0
        Me.cbxcodins.Enabled = True
        Me.CbxCodOFi.Disabled = False
        Me.txtNroCta.Disabled = True
    End Sub

   

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.Deshabilitar()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.cbxgrupos.Visible = False
        Me.cbxCargo.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.cbxgrupos.Visible = False
        Me.cbxCargo.Visible = False
    End Sub

    Protected Sub btnGuardar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.ServerClick
        Dim omcreditos As New cCremcre

        Me.RangeValidator1.Validate()
        If Me.RangeValidator1.IsValid = False Then
            Exit Sub
        End If



        'Si es refinanciamiento, valida politica
        If CbxClasifCred1.SelectedValue = "R" Then
            If Not omcreditos.Valida_Porcentaje_Refina(Me.txtcodcli.Value.Trim, Session("gnporRefi")) Then
                codigoJs = "<script language='javascript'>alert('El porcentaje Pagado no es suficiente para realizar un refinanciamiento, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End If
        End If

        '------------------------------------------------------------
        'Cambio para utilizarlo todo desde la Clase
        '------------------------------------------------------------
        Dim Valor As String

        cls_Sim.Fuente = IIf(Me.cbxfueing.Value.Trim = "", "I01", Me.cbxfueing.Value.Trim)  'Fuente de Ingreso
        cls_Sim.Destino = Me.cbxdescre.SelectedValue.Trim           'Destino del Credito
        cls_Sim.dFecAsig = Me.txtfecasi.Value.Trim          'Fecha de Asignacion
        cls_Sim.Monto = Me.txtmonsol.Value.Trim             'Monto Solicitado
        cls_Sim.Sector = Me.cbxsececo.Value.Trim            'Sector Economico
        cls_Sim.Programa = Me.cbxprograma.SelectedValue.Trim        'Programa
        cls_Sim._cprocre = cmbprograma.SelectedValue.Trim
        cls_Sim.Analista = Me.cbxanacre.Value.Trim          'Analista
        cls_Sim.Codigo = Me.txtcodcli.Value.Trim            'Codigo del cliente
        cls_Sim.Institucion = Me.cbxcodins.SelectedValue.Trim            'Institucion
        cls_Sim.Oficina = Me.CbxCodOFi.Value                'Oficina
        cls_Sim.Tipo = Me.lblMostrar.Text.Trim
        cls_Sim.Cuenta = Me.txtNroCta.Value.Trim
        cls_Sim.pnCiclo = pnCiclo
        cls_Sim.pnTipcre = Me.CbxClasifCred1.SelectedValue 'Me.TxtTipcre.Text
        cls_Sim.pnTipgar = Me.TxtTipgar.Text
        cls_Sim.cCodAct = Me.cmbactividad.SelectedValue
        cls_Sim.ctipgar = " "
        cls_Sim._gcCodusu = Session("gcCodusu")
        cls_Sim._ctipomet = IIf(Me.RadioButton1.Checked = True, "01", "02")
        cls_Sim._ccodsol = IIf(Me.RadioButton1.Checked = True, "001001000000", Me.cbxgrupos.SelectedValue.Trim)
        cls_Sim._ccargo = IIf(Me.RadioButton1.Checked = True, "03", Me.cbxCargo.Value.Trim)
        cls_Sim._lsegvid = Chkseguro.Checked

        Valor = cls_Sim.Graba_Solicitud

        If Valor = "0" Then
            Exit Sub
        Else
            If Valor = "9" Then
                '                Response.Write("<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas ')</script>")
                codigoJs = "<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas, " & _
                                                    "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
                If Valor <> "" Then
                    'Response.Write("<script language='javascript'>alert('El Nº de Prestamo Generado es  " & Valor & " ')</script>")
                    codigoJs = "<script language='javascript'>alert('El Nº de Prestamo Generado es  " & Valor & ", Aviso SIM.NET ')</script>"

                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Else
                    '    Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")
                    codigoJs = "<script language='javascript'>alert('Proceso Correcto, " & _
                                                    "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                End If
            End If
        End If
        HiddenField1.Value = Valor
        'GrabaGravamen() 'agrega automaticamente a la crepgar
        GrabarGastos()

        Dim clsppal As New class1
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "Gr", 56)

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

        Me.cbxgrupos.Visible = False
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
    Private Sub GrabaGravamen()
        Dim ds As New DataSet
        Dim eclimgar As New cClimgar
        Dim cls As New ClsGarant
        ds = eclimgar.ObtenerDataSetEspc1(txtcodcli.Value.Trim)
        Dim fila As DataRow
        Dim entidadCrepgar As New SIM.EL.crepgar
        Dim eCrepgar As New SIM.BL.cCrepgar
        Dim lnreturn As Integer
        Dim lncentinela1 As Integer


        Dim entidadcrepgarg As New SIM.EL.crepgar
        Dim eCrepgarg As New SIM.BL.cCrepgar

        For Each fila In ds.Tables(0).Rows
            entidadCrepgar.ccodcli = fila("ccodcli")
            entidadCrepgar.ccodgar = fila("ccodgar")
            entidadCrepgar.ccodcta = HiddenField1.Value.Trim
            lnreturn = eCrepgar.ObtenerCrepgar(entidadCrepgar)

            cls._ccodgar = fila("ccodgar")
            cls._ccodcli = fila("ccodcli")
            cls._nmongra = fila("nmongra")

            entidadcrepgarg.ccodcta = HiddenField1.Value.Trim
            entidadcrepgarg.ccodcli = fila("ccodcli")
            entidadcrepgarg.ccodgar = fila("ccodgar")
            entidadcrepgarg.cmoneda = "1"
            entidadcrepgarg.nmongra = fila("nmongra")
            entidadcrepgarg.cestado = ""
            entidadcrepgarg.cnumins = ""
            entidadcrepgarg.dfecval = Session("gdfecsis")
            entidadcrepgarg.ccodusu = Session("gcCodusu")
            entidadcrepgarg.dfecmod = Today()
            entidadcrepgarg.cflag = ""
            entidadcrepgarg.ctipgar = fila("ctipgar")

            If lnreturn = 0 Then 'Inserta
                lncentinela1 = eCrepgarg.AgregarCrepgar(entidadcrepgarg)
            Else 'Actualiza
                lncentinela1 = eCrepgar.Actualizar1(entidadcrepgarg)
            End If

            If lncentinela1 = 1 Then 'Proceso Correcto
            Else                    'Genero Error
            End If

        Next

    End Sub
    Private Sub CargaGrid()
        Dim etabttab As New cTabttab
        Dim ds As New DataSet
        ds = etabttab.CargaListadoChkGastos()
        Me.dgGastos.DataSource = ds.Tables(0)
        Me.dgGastos.DataBind()
        'Me.dgGastos.Columns(4).Visible = False
        'Me.dgGastos.Columns(3).Visible = False
    End Sub
    Private Sub GrabarGastos()
        Dim ecredgas As New cCredgas
        Dim entidadcredgas As New credgas
        ecredgas.Eliminarporcuenta(HiddenField1.Value.Trim)
        Dim chkCptoAsig As CheckBox
        Dim lopcion As Boolean
        Dim nElem As Integer = 0
        For xy = 0 To Me.dgGastos.Rows.Count - 1
            chkCptoAsig = CType(Me.dgGastos.Rows(xy).FindControl("CheckBox2"), CheckBox)
            lopcion = chkCptoAsig.Checked
            'Pone bandera al gasto
            entidadcredgas.ccodcta = HiddenField1.Value.Trim
            entidadcredgas.ccodusu = Session("gccodusu")
            entidadcredgas.cdescob = "D"
            entidadcredgas.cestado = ""
            If lopcion = True Then
                entidadcredgas.cflag = "1"
            Else
                entidadcredgas.cflag = "0"
            End If
            entidadcredgas.cnrocuo = "001"
            entidadcredgas.ctipgas = Me.dgGastos.Rows(xy).Cells(0).Text
            entidadcredgas.cusugen = Session("gccodusu")
            entidadcredgas.dfecgen = Session("gdfecsis")
            entidadcredgas.dfecmod = Now
            entidadcredgas.dfecpag = Now
            entidadcredgas.nmongas = 0
            entidadcredgas.nmonpag = 0

            ecredgas.Agregar(entidadcredgas)
            nElem = nElem + 1
        Next
    End Sub
    Private Sub CargaGridCredito(ByVal cCodcta As String)
        Dim ecredgas As New cCredgas
        Dim ds As New DataSet
        ds = ecredgas.CargaListadoChkGastosCredito(cCodcta)
        If ds.Tables(0).Rows.Count = 0 Then
            Me.CargaGrid()
            Return
        End If
        Me.dgGastos.DataSource = ds.Tables(0)
        Me.dgGastos.DataBind()

    End Sub
    Private Sub CargarOficina()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        Dim ds As New DataSet
        ds = etabtofi.ObtenerOficinasdeRegion(cbxcodins.SelectedValue.Trim, Session("gccodofi"), Session("gnNivel"))
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            btnGuardar.Disabled = True
            Exit Sub
        Else
            btnGuardar.Disabled = False
        End If


        Me.CbxCodOFi.DataTextField = "cNomOfi"
        Me.CbxCodOFi.DataValueField = "cCodOfi"
        Me.CbxCodOFi.DataSource = ds.Tables(0)
        Me.CbxCodOFi.DataBind()

        
        ds.Tables(0).Clear()
    End Sub

    Protected Sub cbxcodins_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcodins.SelectedIndexChanged
        CargarOficina()
    End Sub
End Class
