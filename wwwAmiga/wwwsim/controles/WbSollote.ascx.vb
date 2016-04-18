Public Class WbSollote
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
    Private codigoJs As String = ""
#End Region
    

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
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
        lnparametro6_R = "Where cCatego ='ANA' and cEstado = 'A' AND ccodusu IN (SELECT usuario from usuarios where cargo = 'ANA'" & _
        " AND lactivo = 1)"
        If Session("gcCodofi") = "001" Then
        Else
            lnparametro6_R = lnparametro6_R & " and cCodofi =  " & Session("gcCodofi")
        End If

        lnparametro6_R = lnparametro6_R & " order by CNOMUSU "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        Me.cbxanacre.DataTextField = "cNomUsu"
        Me.cbxanacre.DataValueField = "cCodUsu"
        Me.cbxanacre.DataSource = ds.Tables("Resultado")
        Me.cbxanacre.DataBind()


        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        
        Dim etabtofi As New cTabtofi
        '----------------------------
        'Llenando Institucion
        '----------------------------
        Dim lccodins As String
        lccodins = etabtofi.ObtenerRegiondeUsuario(Session("gccodusu"))

        Dim etabttab As New cTabttab
        ds = etabttab.ObtenerDatasetTabla("054", lccodins)


        Me.cbxcodins.DataTextField = "cDescri"
        Me.cbxcodins.DataValueField = "cCodigo"
        Me.cbxcodins.DataSource = ds.Tables(0)
        Me.cbxcodins.DataBind()

        ds.Tables(0).Clear()

        CargarOficina()

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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        Me.cbxcentros.DataTextField = "cNomgru"
        Me.cbxcentros.DataValueField = "cCodsol"
        Me.cbxcentros.DataSource = ds.Tables("Resultado")
        Me.cbxcentros.DataBind()

        Me.cbxcentros.Visible = False
        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()
        'cargaGrupos()
    End Sub
    Private Sub BuscaCredito()
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet


        Dim xy As Integer = 0
        Dim cliente As String
        Dim lnmonto As Double = 0
        Dim nmonto As TextBox
        'Dim pccuenta As String


        For xy = 0 To Me.Datagrid1.Items.Count - 1
            Dim ddl As DropDownList
            Dim dt2 As DataTable = LlenarSector()


            cliente = Me.Datagrid1.Items(xy).Cells(0).Text.Trim
            ds = ecreditos.ListadoCreditosxGrupoSolicitud2(cliente)

            If ds.Tables(0).Rows.Count = 0 Then
                Me.lblMostrar.Text = "NUEVO"
            Else
                'pccuenta = ds.Tables(0).Rows(0)("ccodcta")
                'txtNroCta.Value = Right(pccuenta, 12)
                Me.lblMostrar.Text = "MODIFICACION"
                CargaGridCredito(ds.Tables(0).Rows(0)("cCodcta"))
                Me.txtfecasi.Value = ds.Tables(0).Rows(0)("dFecAsi")
                Me.cbxanacre.Value = Trim(ds.Tables(0).Rows(0)("cCodAna"))
                'Programa
                If IsDBNull(ds.Tables(0).Rows(0)("ccodfue")) Then
                Else
                    Me.cbxprograma.SelectedValue = Trim(ds.Tables(0).Rows(0)("ccodfue"))
                End If


                Dim gvrow As DataGridItem

                gvrow = CType(Me.Datagrid1.Items(xy).Cells(3).NamingContainer, DataGridItem)
                nmonto = CType(gvrow.FindControl("TextBox5"), TextBox)

                nmonto.Text = (ds.Tables(0).Rows(0)("nmonsol"))

                gvrow = CType(Me.Datagrid1.Items(xy).Cells(4).NamingContainer, DataGridItem)
                ddl = CType(gvrow.FindControl("DropDownList1"), DropDownList)

                ddl.ClearSelection()

                If ddl IsNot DBNull.Value Then

                    'ddl.DataSource = dt2
                    'ddl.DataTextField = "cdescri"
                    'ddl.DataValueField = "ccodigo"
                    'ddl.DataBind() 'Lleno el combo

                    ddl.SelectedValue = Trim(ds.Tables(0).Rows(0)("cSecEco"))

                End If

                dt2.Clear()

                '--------------------------------------------------------------
                dt2 = LlenarDestino()
                ddl = CType(gvrow.FindControl("cbxdescre"), DropDownList)

                ddl.ClearSelection()

                If ddl IsNot DBNull.Value Then

                    'ddl.DataSource = dt2
                    'ddl.DataTextField = "cdescri"
                    'ddl.DataValueField = "ccodigo"
                    'ddl.DataBind() 'Lleno el combo

                    ddl.SelectedValue = Trim(ds.Tables(0).Rows(0)("cDesCre"))
                End If

                dt2.Clear()
                '---------------------------------------------------------------

                dt2 = LlenarActividad()
                ddl = CType(gvrow.FindControl("cmbactividad"), DropDownList)

                ddl.ClearSelection()

                If ddl IsNot DBNull.Value Then

                    'ddl.DataSource = dt2
                    'ddl.DataTextField = "cdescri"
                    'ddl.DataValueField = "ccodigo"
                    'ddl.DataBind() 'Lleno el combo

                    ddl.SelectedValue = Trim(ds.Tables(0).Rows(0)("cCodAct"))
                End If

                dt2.Clear()

                '---------------------------------------------------------------


                'dt2 = LlenarFuenteIngreso(cliente)
                'ddl = CType(gvrow.FindControl("cbxfueing0"), DropDownList)

                'ddl.ClearSelection()

                'If ddl IsNot DBNull.Value Then

                '    ddl.DataSource = dt2
                '    ddl.DataTextField = "cnomfue"
                '    ddl.DataValueField = "ccodfue"
                '    ddl.DataBind() 'Lleno el combo


                'End If

                'dt2.Clear()


            End If
        Next


    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcodcli.Value = codigoCliente
        Dim ecremcre As New cCremcre
        Dim lvalida As Boolean
        Dim lvalidaFuentesIngreso As Boolean


        'lvalidaFuentesIngreso = ecremcre.ValidaFuentesIngresoBcGs(codigoCliente)

        'valida fuentes de ingreso de grupos y bancos comunales

        'If lvalidaFuentesIngreso = False Then
        '    Response.Write("<script language='javascript'>alert('una o mas fuentes de ingreso no estan ingresadas ')</script>")
        '    'Return
        'End If

        lvalida = ecremcre.ValidaSolicitudPendienteGrupal(codigoCliente)


        If lvalida = True Then 'tiene solicitudes pendientes
            'Response.Write("<script language='javascript'>alert('Clientes del Grupo tiene Solicitud Pendiente ')</script>")
            codigoJs = "<script language='javascript'>alert('Clientes del Grupo tiene Solicitud Pendiente, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            btnGuardar.Disabled = True
            Return
        End If
        'Valida si tiene otros creditos!
        '------
        Dim almacena_nombres As String
        Dim nombre As String
        Dim recibeEstatus As String
        Dim codigoRecibe As String
        Dim validaCreditos As New DataSet
        validaCreditos = ecremcre.BuscaCreditos(codigoCliente)
        Dim contador_entradasclientes As Integer = 0

        For Each ccodcli As DataRow In validaCreditos.Tables(0).Rows
            nombre = ccodcli("cnomcli")
            codigoRecibe = ccodcli("ccodcli")
            recibeEstatus = ecremcre.Buscar_Creditos_codigos(codigoRecibe)

            If recibeEstatus = "F" Or recibeEstatus = "E" Or recibeEstatus = "C" Then
                almacena_nombres = almacena_nombres & nombre & "\n\n"
                contador_entradasclientes += 1


            End If


        Next
        If contador_entradasclientes > 0 Then


            codigoJs = "<script language='javascript'>alert('Clientes del Grupo tienen credito en vigencia: \n\n" & _
                              "-" & almacena_nombres & " \n\n Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

            btnGuardar.Disabled = True
            Return

        End If
        'Validar por cliente historicos de grupos
        Dim dsccodcli As New DataSet
        Dim varccodcli As String
        Dim varnombre As String
        Dim dsobtenerGruposClientes As New DataSet
        Dim dsValidaCuentasxGrupoEstatus As New DataSet
        Dim NombreGrupal, ccodsol_ As String
        Dim i As Integer = 0
        Dim gruposInvaldos As String

        'grilla de clientes codigo y nombre
        dsccodcli = ecremcre.obtenerGrupos(codigoCliente)

        For Each rows As DataRow In dsccodcli.Tables(0).Rows

            varnombre = rows("cnomcli")
            varccodcli = rows("ccodcli")
            'Obtener grilla de ccodsol nombres  x clientes
            dsobtenerGruposClientes = ecremcre.obtenerCcodsolxClientes(varccodcli)

            For Each row2 As DataRow In dsobtenerGruposClientes.Tables(0).Rows
                NombreGrupal = row2("cnomgru")
                ccodsol_ = row2("ccodsol")
                'grilla con estatus de cada integrante del grupo
                dsValidaCuentasxGrupoEstatus = ecremcre.obtenercuentasEstatus(ccodsol_)

                For Each estatus As DataRow In dsValidaCuentasxGrupoEstatus.Tables(0).Rows

                    If estatus("cestado") = "F" Then
                        i += 1

                        gruposInvaldos = "Nombre grupal: " & NombreGrupal & " Codigo: " & ccodsol_

                    End If
                Next
            Next
        Next
        'Valida si hubo algun credito vigente en otros grupos
        If i >= 1 Then
            Dim GS As Integer

            GS = ecremcre.validarReglasProductos(codigoCliente)

            If GS = 1 Then
                codigoJs = "<script language='javascript'>alert('Clientes del Grupo tienen creditos en el grupo : \n\n" & _
                                             "-" & gruposInvaldos & " \n\n Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                btnGuardar.Disabled = True
                Return
            End If

        End If


        '------
        'Verifica si grupo existe
        Dim ecremsol As New cCremsol
        Dim lverifica As Boolean
        lverifica = ecremsol.VerificaGrupoActivo(codigoCliente, Session("gcCodofi"))
        Dim lcgruban As String = ""
        If codigoCliente.Substring(6, 2) = "03" Then
            RadioButton2.Text = "Grupo Solidario:"
            If lverifica = False Then
                Me.Datagrid1.DataSource = ""
                Me.Datagrid1.DataBind()
                Me.btnAplica.Disabled = True
                Me.btnGuardar.Disabled = True
                'Response.Write("<script language='javascript'>alert('GRUPO INACTIVO ')</script>")
                codigoJs = "<script language='javascript'>alert('GRUPO INACTIVO, " & _
                           "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                Exit Sub
            End If
        Else
            RadioButton2.Text = "Banco Comunal:"
            If lverifica = False Then
                Me.Datagrid1.DataSource = ""
                Me.Datagrid1.DataBind()
                Me.btnAplica.Disabled = True
                Me.btnGuardar.Disabled = True
                'Response.Write("<script language='javascript'>alert('BANCO INACTIVO ')</script>")
                codigoJs = "<script language='javascript'>alert('BANCO INACTIVO, " & _
                           "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                Exit Sub
            End If
        End If

        '
        cargaGrupos()
        ''Nombre del grupo
        cbxgrupos.SelectedValue = codigoCliente



        'Dim entidadClimide As New SIM.EL.climide
        'Dim eClimide As New SIM.BL.cClimide

        'entidadClimide.ccodcli = Me.txtcodcli.Value.Trim
        'eClimide.ObtenerClimide(entidadClimide)
        'Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim
        'Me.cbxgrupos.SelectedValue = entidadClimide.ccodsol.Trim
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
        'Me.txtfecasi.Disabled = False
        Me.txtmonsol.Disabled = False
        Me.cmbactividad.Enabled = True
        If Me.lblMostrar.Text = "NUEVO" Then
            Me.txtccodtmp.Enabled = True
            Me.validacodigo()
        End If
    End Sub
    Private Sub validacodigo()
        Me.txtccodtmp.Text = Me.cbxcodins.SelectedValue.Trim.Trim & Me.CbxCodOFi.Value.Trim & "01" & "1"
    End Sub
#End Region

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Response.Redirect("WbBusCli.aspx")
        '   Me.btnAplica_ServerClick(sender, e)


    End Sub

    Private Sub btnAplica_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplica.ServerClick
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet


        Me.cbxanacre.Disabled = False
        'Me.txtfecasi.Disabled = False
        Me.cbxprograma.Enabled = True

        Me.cbxcodins.Enabled = True
        Me.CbxCodOFi.Disabled = False
        Me.txtNroCta.Disabled = False
        'obtiene dataset de creditos en estado de solicitud para verificar si es nuevo o modificar
        Me.CargaGrid(Me.cbxgrupos.SelectedValue.Trim)

        Dim ecremcre As New cCremcre
        ds = ecremcre.ObtieneSolicitudPendienteGrupal(Me.cbxgrupos.SelectedValue.Trim)
        If ds.Tables(0).Rows.Count <= 0 Then
            Me.lblMostrar.Text = "NUEVO"
            txtNroCta.Value = ""
            Me.TxtTipcre.Text = "N"
            'pnCiclo = 1
        Else
            Me.lblMostrar.Text = "MODIFICACION"
            Me.TxtTipcre.Text = "N"
            'CargaDatos
            BuscaCredito()
        End If

        Me.btnGuardar.Disabled = False
        Me.btnAplica.Disabled = True

    End Sub

    Private Sub aplica()
        '---------------------------
        'Busca el Cliente
        '---------------------------
        Dim pcCodcli As String
        Dim fila1 As DataRow
        pcCodcli = Me.txtcodcli.Value

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
        Dim Valor As String = ""

        Dim xy As Integer = 0
        Dim cliente As String
        Dim ddl As DropDownList
        Dim gvrow As DataGridItem

        Dim lnmonto As Double = 0
        Dim nmonto As TextBox
        Dim ecreditos As New ccreditos
        Dim lccodcta As String = ""
        Dim validaconyugue As Boolean
        Dim ccremcre As New cCremcre
        Dim eclimide As New climide
        Dim cclimide As New cClimide


        For xy = 0 To Me.Datagrid1.Items.Count - 1
            cliente = Me.Datagrid1.Items(xy).Cells(0).Text.Trim

            eclimide.ccodcli = cliente
            cclimide.ObtenerClimide(eclimide)

            'validaconyugue = ccremcre.ValidaCreditoConyugue(eclimide.cDuiCony, eclimide.ccodofi)

            'If validaconyugue = False Or eclimide.cDuiCony.Trim = "" Then


            gvrow = CType(Me.Datagrid1.Items(xy).Cells(7).NamingContainer, DataGridItem)
            ddl = CType(gvrow.FindControl("cbxfueing0"), DropDownList)

            cls_Sim.Fuente = IIf(ddl.SelectedValue = "", "01", ddl.SelectedValue)

            gvrow = CType(Me.Datagrid1.Items(xy).Cells(5).NamingContainer, DataGridItem)
            ddl = CType(gvrow.FindControl("cbxdescre"), DropDownList)

            cls_Sim.Destino = ddl.SelectedValue.Trim           'Destino del Credito
            cls_Sim.dFecAsig = Me.txtfecasi.Value.Trim          'Fecha de Asignacion

            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("TextBox5"), TextBox)
            lnmonto = Double.Parse(nmonto.Text)
            cls_Sim.Monto = lnmonto             'Monto Solicitado

            gvrow = CType(Me.Datagrid1.Items(xy).Cells(4).NamingContainer, DataGridItem)
            ddl = CType(gvrow.FindControl("DropDownList1"), DropDownList)

            cls_Sim.Sector = ddl.SelectedValue            'Sector Economico

            cls_Sim.Programa = Me.cbxprograma.SelectedValue.Trim        'Programa
            cls_Sim.Analista = Me.cbxanacre.Value.Trim          'Analista
            cls_Sim.Codigo = cliente.Trim            'Codigo del cliente
            cls_Sim.Institucion = Me.cbxcodins.SelectedValue.Trim            'Institucion
            cls_Sim.Oficina = Me.CbxCodOFi.Value                'Oficina
            cls_Sim.Tipo = Me.lblMostrar.Text.Trim

            'Obtiene codigo si existe por cliente y grupo
            lccodcta = ecreditos.ClientexGrupoSolicitud(Me.cbxgrupos.SelectedValue.Trim, cliente)
            Me.txtNroCta.Value = Right(lccodcta, 12)

            cls_Sim.Cuenta = Me.txtNroCta.Value.Trim

            gvrow = CType(Me.Datagrid1.Items(xy).Cells(6).NamingContainer, DataGridItem)
            ddl = CType(gvrow.FindControl("cmbactividad"), DropDownList)

            cls_Sim.cCodAct = ddl.SelectedValue

            pnCiclo = ecreditos.ObtieneCiclo(cliente)
            cls_Sim.pnCiclo = pnCiclo

            cls_Sim.pnTipcre = Me.TxtTipcre.Text
            cls_Sim.pnTipgar = "01" 'Me.TxtTipgar.Text
            cls_Sim.ctipgar = " "
            cls_Sim._gcCodusu = Session("gcCodusu")
            cls_Sim._ctipomet = IIf(cbxgrupos.SelectedValue.Trim.Substring(6, 2) = "00", "03", cbxgrupos.SelectedValue.Trim.Substring(6, 2))
            cls_Sim._ccodsol = Me.cbxgrupos.SelectedValue.Trim
            cls_Sim._ccargo = "03" 'IIf(Me.RadioButton1.Checked = True, "03", Me.cbxCargo.Value.Trim)


            Valor = cls_Sim.Graba_Solicitud


            If Valor = "0" Then
                Exit Sub
            Else
                If xy = 0 Then
                    If Valor = "9" Then
                        Exit For
                    Else

                    End If
                End If
            End If
            HiddenField1.Value = Valor
            'GrabaGravamen(cliente, Valor)
            GrabarGastos()
            'Graba en la cremcre el ciclo del grupo no del cliente, para controlarlo  en el proceso
            'Dim lnciclo As Integer
            'Dim ecremsol As New cCremsol
            'lnciclo = ecremsol.ObtenerCicloGrupo(Me.txtcodcli.Value.Trim, Session("gdfecsis"))


            'Else
            'Response.Write("<script language='javascript'>alert('una o mas solicitudes no fueron grabadas pq el conyugue tiene credito vigente')</script>")
            'Exit Sub
            'End If 'if de la valacion de conyugue

            'xy += 1
        Next
        If Valor = "0" Then
            'Response.Write("<script language='javascript'>alert('No se grabo Solicitud ')</script>")
            codigoJs = "<script language='javascript'>alert('No se grabo Solicitud, " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        ElseIf Valor = "9" Then
            'Response.Write("<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas ')</script>")
            codigoJs = "<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas, " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        Else
            If Valor <> "" Then
                'Response.Write("<script language='javascript'>alert('El Cuenta Generado es  " & Valor & " ')</script>")
                'Response.Write("<script language='javascript'>alert('Solicitud Grupal Grabada')</script>")
                codigoJs = "<script language='javascript'>alert('Solicitud Grupal Grabada, " & _
                           "Aviso SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                'Exit Sub
            Else
                'Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")
                codigoJs = "<script language='javascript'>alert('Proceso Correcto, " & _
                           "Aviso SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            End If

        End If

        Me.Deshabilitar()
    End Sub

    Protected Sub cbxcentros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcentros.SelectedIndexChanged
        cargaGrupos()
    End Sub

    Private Sub cargaGrupos()
        Dim lccodcen As String
        lccodcen = Session("gcCodofi")
        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , left(cCodsol,12) as cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1'  "
        If lccodcen.Trim = "001" Then

        Else
            'lnparametro6_R = lnparametro6_R & " and substring(cCodsol,4,3) = " & "'" & lccodcen.Trim & "'"
            lnparametro6_R = lnparametro6_R & " and ccodsol='" & Me.txtcodcli.Value.Trim & "'"
            lnparametro6_R = lnparametro6_R & " and ccodofi='" & lccodcen.Trim & "'"
        End If

        'lnparametro6_R = lnparametro6_R & "  order by CNOMgru "

        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
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


    Private Function LlenarSector() As DataTable
        Dim ds As New DataSet
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
        Return ds.Tables(0)
    End Function
    Public Function LlenarDestino() As DataTable
        Dim ds As New DataSet
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

        Return ds.Tables(0)

    End Function
    Public Function LlenarActividad() As DataTable
        Dim ds As New DataSet
        Dim etabtciu As New cTabtciu
        ds = etabtciu.ObtenerDataSetPorID()

        Return ds.Tables(0)
    End Function

    Private Sub CargaGrid(ByVal ccodsol As String)
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet


        ds = ecreditos.ListadoCreditosxGrupoSolicitud(ccodsol)

        Me.Datagrid1.DataSource = ds
        Me.Datagrid1.DataBind()

        Dim xy As Integer = 0
        Dim cliente As String

        Dim lcsececo As String
        Dim lcactividad As String
        Dim eclidfin As New cClidfin

        For xy = 0 To Me.Datagrid1.Items.Count - 1
            Dim ddl As DropDownList
            Dim dt2 As DataTable = LlenarSector()


            cliente = Me.Datagrid1.Items(xy).Cells(0).Text.Trim

            '---------------------------
            'Busca el Sector Economico
            '---------------------------
            lcsececo = eclidfin.BuscarSectorEconomico(cliente)
            lcactividad = eclidfin.BuscarActividad(cliente)


            Dim gvrow As DataGridItem
            gvrow = CType(Me.Datagrid1.Items(xy).Cells(4).NamingContainer, DataGridItem)
            ddl = CType(gvrow.FindControl("DropDownList1"), DropDownList)

            ddl.ClearSelection()

            If ddl IsNot DBNull.Value Then

                ddl.DataSource = dt2
                ddl.DataTextField = "cdescri"
                ddl.DataValueField = "ccodigo"
                ddl.DataBind() 'Lleno el combo

                ddl.SelectedValue = lcsececo.Trim

            End If

            dt2.Clear()

            '--------------------------------------------------------------
            dt2 = LlenarDestino()
            ddl = CType(gvrow.FindControl("cbxdescre"), DropDownList)

            ddl.ClearSelection()

            If ddl IsNot DBNull.Value Then

                ddl.DataSource = dt2
                ddl.DataTextField = "cdescri"
                ddl.DataValueField = "ccodigo"
                ddl.DataBind() 'Lleno el combo

                ddl.SelectedValue = "0"
            End If

            dt2.Clear()
            '---------------------------------------------------------------

            dt2 = LlenarActividad()
            ddl = CType(gvrow.FindControl("cmbactividad"), DropDownList)

            ddl.ClearSelection()

            If ddl IsNot DBNull.Value Then

                ddl.DataSource = dt2
                ddl.DataTextField = "cdescri"
                ddl.DataValueField = "ccodigo"
                ddl.DataBind() 'Lleno el combo

                ddl.SelectedValue = lcactividad.Trim
            End If

            dt2.Clear()

            '---------------------------------------------------------------

            dt2 = LlenarFuenteIngreso(cliente)
            ddl = CType(gvrow.FindControl("cbxfueing0"), DropDownList)

            ddl.ClearSelection()

            If ddl IsNot DBNull.Value Then

                ddl.DataSource = dt2
                ddl.DataTextField = "cnomfue"
                ddl.DataValueField = "ccodfue"
                ddl.DataBind() 'Lleno el combo


            End If

            dt2.Clear()

        Next

        btnGuardar.Disabled = False
    End Sub

    Private Function LlenarFuenteIngreso(ByVal ccodcli As String) As DataTable
        '---------------------------
        'Busca el Cliente
        '---------------------------
        Dim ds As New DataSet
        Dim pcCodcli As String
        pcCodcli = ccodcli
        lnparametro1_R = "ccodfue, cNomFue, cCodAct, "
        lnparametro2_R = "S,S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CLIDFIN"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodcli =" & "'" & pcCodcli & "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    'MsgBox("No Tiene Fuente de Ingresos", MsgBoxStyle.Information, "Aviso")
        '    'Response.Write("<script language='javascript'>alert('No Tiene Fuente de Ingresos')</script>")
        '    'Exit Sub
        'Else
        '    Me.cbxfueing.DataTextField = "cNomfue"
        '    Me.cbxfueing.DataValueField = "cCodfue"
        '    Me.cbxfueing.DataSource = ds.Tables("Resultado")
        '    Me.cbxfueing.DataBind()
        'End If

        Return ds.Tables("Resultado")
    End Function

    Private Sub Grabar(ByVal ccodcli As String)
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
        cls_Sim.Institucion = Me.cbxcodins.SelectedValue.Trim            'Institucion
        cls_Sim.Oficina = Me.CbxCodOFi.Value                'Oficina
        cls_Sim.Tipo = Me.lblMostrar.Text.Trim
        cls_Sim.Cuenta = Me.txtNroCta.Value.Trim
        cls_Sim.pnCiclo = pnCiclo
        cls_Sim.pnTipcre = Me.TxtTipcre.Text
        cls_Sim.pnTipgar = Me.TxtTipgar.Text
        cls_Sim.cCodAct = Me.cmbactividad.SelectedValue
        cls_Sim.ctipgar = " "
        cls_Sim._gcCodusu = Session("gcCodusu")
        cls_Sim._ctipomet = "03"
        cls_Sim._ccodsol = IIf(Me.RadioButton1.Checked = True, "001001000000", Me.cbxgrupos.SelectedValue.Trim)
        cls_Sim._ccargo = IIf(Me.RadioButton1.Checked = True, "03", Me.cbxCargo.Value.Trim)
        Valor = cls_Sim.Graba_Solicitud

        If Valor = "0" Then
            Exit Sub
        Else
            If Valor = "9" Then
                'Response.Write("<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas ')</script>")
                codigoJs = "<script language='javascript'>alert('Fondo NO Posee Líneas Asignadas, " & _
                           "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                Exit Sub
            Else
                If Valor <> "" Then
                    '  Response.Write("<script language='javascript'>alert('El Cuenta Generado es  " & Valor & " ')</script>")
                    codigoJs = "<script language='javascript'>alert(El Cuenta Generado es  " & Valor & " ', " & _
                               "Advertencia SIM.NET ')</script>"

                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                Else
                    'Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")
                    codigoJs = "<script language='javascript'>alert('Proceso Correcto, " & _
                               "Advertencia SIM.NET ')</script>"

                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                End If
            End If
        End If

        Me.Deshabilitar()
        Me.cbxfueing.Items.Clear()


    End Sub

    Private Sub GrabaGravamen(ByVal ccodcli As String, ByVal ccodcta As String)
        Dim ds As New DataSet
        Dim eclimgar As New cClimgar
        Dim cls As New ClsGarant
        ds = eclimgar.ObtenerDataSetEspc1(ccodcli.Trim)
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
            entidadCrepgar.ccodcta = ccodcta
            lnreturn = eCrepgar.ObtenerCrepgar(entidadCrepgar)

            cls._ccodgar = fila("ccodgar")
            cls._ccodcli = fila("ccodcli")
            cls._nmongra = fila("nmongra")

            entidadcrepgarg.ccodcta = ccodcta
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

    Protected Sub cbxcodins_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcodins.SelectedIndexChanged
        CargarOficina()
    End Sub
    Private Sub CargarOficina()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        Dim ds As New DataSet
        ds = etabtofi.ObtenerOficinasdeRegion(cbxcodins.SelectedValue.Trim, Session("gccodofi"), Session("gnNivel"))
        If ds.Tables(0).Rows.Count <= 0 Then
            'MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Oficinas, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
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

End Class
