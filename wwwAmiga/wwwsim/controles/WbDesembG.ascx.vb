Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Public Class WbDesembG1
    Inherits System.Web.UI.UserControl
    Dim clsbancos As New SIM.BL.cTabtbco
    Private cls1 As New SIM.BL.ClsMantenimiento
    Dim clsppal As New class1
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

    'Private cClase As New SIM.BL.crefunc


#Region " Variables "
    Private cClsDes As New SIM.BL.clsDesembolsa
    Private vDetalle As New DataSet
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Private clsConvert As New SIM.BL.ConversionLetras
    Public Event Refinanciamiento(ByVal codigoCliente As String)
    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private Transacc As String
    Private codigoJs As String = ""

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


#Region " Metodos "
    

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Dim gdfecsis As Date
        Me.cbxgrupos.Value = codigoCliente.Trim
        Cargar_Gastos()
        Me.Aplica()
        gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar
        CargarDatos(codigoCliente)
    End Sub

    Private Sub Genera_PlanP(ByVal ds_grupo As DataSet)
        Dim ldfecproy As Date
        'Actualiza el Plan de Pagos si es diferente a la fecha del sistema
        For Each fila As DataRow In ds_grupo.Tables(0).Rows
            '   ldfecproy = fechaproy()
            '  If ldfecproy <> Session("gdfecsis") Then
            GeneraPlanPagos(fila("ccodcta"), fila("nmonapr"))
            'End If
        Next

    End Sub



    Public Sub Aplica()
        Dim lcdescri As Exception
        Dim ds As New DataSet
        Dim mclimgar As New cClimgar
        'Sacando los datos necesarios para el Desembolso
        Dim lcestado As String
        Dim lndescuento As Double
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.ccreditos
        Dim entidadcretlin As New cretlin
        Dim mcretlin As New cCretlin
        cmbBancos.Enabled = True
        Txtnrochq.Enabled = True
        Txtfactura.Enabled = True
        txtcnomchq.Text = ""
        Me.txtbandera.Text = 1
        Dim comdin As DateTime

        Try

            ds = ecreditos.ListadoCreditosxGrupoDesembolso(Me.cbxgrupos.Value.Trim)

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If ds.Tables(0).Rows.Count = 0 Then
                'Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                           "Advertencia SIM.NET '); location.href='WbDesLote.aspx'</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
            End If


            'Valida que todos los creditos tenga activada su garantia liquida
            For Each fila As DataRow In ds.Tables(0).Rows
                If Not mclimgar.Valida_Existencia_Garantia_Liquida_Activa(fila("ccodcli")) Then
                    'Response.Write("<script language='javascript'>alert('Las Garantías no se han registrado en Otros Ingresos')</script>")
                    codigoJs = "<script language='javascript'>alert('Las Garantías no se han registrado , " & _
                               "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    ImageButton1.Enabled = False
                    Exit Sub
                End If
                If Not mclimgar.Valida_Existencia_Tipo_Ingreso(fila("ccodcta"), "03", comdin) Then
                    codigoJs = "<script language='javascript'>alert('Los Seguros no se han registrado en Otros Ingresos, " & _
                                  "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    ImageButton1.Enabled = False
                    Exit Sub

                End If
            Next

            

            For Each fila In ds.Tables(0).Rows
                entidadcretlin.cnrolin = fila("cnrolin")
                mcretlin.ObtenerCretlin(entidadcretlin)
                Me.txtnmoncuo.Text = entidadcretlin.nmoncuo
            Next

            'Genera el plan de pagos con fecha actual
            Genera_PlanP(ds)

            'Carga Gastos Iniciales
            Me.CargaGrid(ds)


            
            Dim ecremsol As New cCremsol
            Dim lnciclo As Integer

            lnciclo = ecremsol.ObtenerCicloGrupo(Me.cbxgrupos.Value.Trim, Session("gdfecsis"))
            Me.cGlosa.Text = "DESEMB.CREDITO GRUPAL No: " & lnciclo.ToString & ", NOMBRE: " & ecremsol.ObtenerNombre(Me.cbxgrupos.Value).Trim
            HiddenField1.Value = "DESEMB.CREDITO GRUPAL No: " & lnciclo.ToString & ", NOMBRE: " & ecremsol.ObtenerNombre(Me.cbxgrupos.Value).Trim

            ImageButton1.Enabled = True


        Catch ex As Exception
            'Throw ex
        End Try

    End Sub

    Public Sub CargarCombos()
        Dim lcnivel As String
        lcnivel = Session("gnNivel")

        If lcnivel >= "9" Then
            RadioButton2.Enabled = True
        Else
            RadioButton2.Enabled = False
        End If

        Dim dsb As New DataSet
        Dim dsc As New DataSet

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        'tipo de desembolso

        mListaTabttab = clstabttab.ObtenerLista("146", "1")
        Me.cmbtippag.DataTextField = "cdescri"
        Me.cmbtippag.DataValueField = "ccodigo"
        Me.cmbtippag.DataSource = mListaTabttab
        Me.cmbtippag.DataBind()
        Me.cmbtippag.SelectedValue = "D"

        Me.cmbtippag.Items.RemoveAt(Me.cmbtippag.Items.IndexOf(Me.cmbtippag.Items.FindByValue("I")))

        Dim objTabtOfi As New cTabtofi

        Dim tieneEfectivo As Boolean

        tieneEfectivo = False

        If tieneEfectivo = True Then
            Me.cmbtippag.Enabled = True
        Else
            Me.cmbtippag.Enabled = False
        End If

        'Informacion del Combo
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "DE")

        Me.cmbBancos.DataTextField = "cnombco"
        Me.cmbBancos.DataValueField = "ccodbco"
        Me.cmbBancos.DataSource = dsb.Tables(0)
        Me.cmbBancos.DataBind()
        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)

        Me.ImageButton1.Enabled = True

      
        '----------------------------
        'Llenando Grupos
        '----------------------------
        Dim ds As New DataSet
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = " order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


            Exit Sub
        End If

        Me.cbxgrupos.DataTextField = "cNomgru"
        Me.cbxgrupos.DataValueField = "cCodsol"
        Me.cbxgrupos.DataSource = ds.Tables("Resultado")
        Me.cbxgrupos.DataBind()

        Me.cbxgrupos.Disabled = True

        ds.Tables("Resultado").Clear()

        Label33.Visible = False
        cbxclientes.Visible = False
    End Sub

    Public Sub Limpiar()
        ' Me.Txtnrochq.Text = " "
        Me.cGlosa.Text = " "
        Txtfactura.Text = ""
        txtIVA.Text = 0
        Me.txtnmoncuo.Text = "0.00"
        Me.ImageButton1.Enabled = True
        Me.btnimprimir.Disabled = True
    End Sub

    Public Sub Imprime()
        Dim lncapita As Double = 0
        lncapita = Double.Parse(TxtCapita.Text)

        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrRptDesemG.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim eKardex As New SIM.BL.ckardex
        Dim nCanti As Integer
        Dim ldfecha As Date = Session("gdfecsis")


        ldfecha = Date.Parse(Me.txtdfecvig.Text)
        '        ldfecha = Date.Parse(Me.txtfecvig.Text.Trim)
        'Crear aqui el dataset
        Dim ecredppg As New cCredppg
        Dim lntotcuo As Decimal = 0
        lntotcuo = ecredppg.CuotaGrupal(Me.cbxgrupos.Value.Trim, ldfecha)

        dsDes = eKardex.ObtenerDataSetPorcuenta3(Me.cbxgrupos.Value.Trim, ldfecha, Me.Txtnrochq.Text.Trim) 'Me.TxtDocumento.Text.Trim
        nCanti = dsDes.Tables(0).Rows.Count

        If nCanti <> 0 Then
            lncapita = dsDes.Tables(0).Rows(0)("ncapdes")
            For Each fila As DataRow In dsDes.Tables(0).Rows
                fila("nmoncuo") = lntotcuo
            Next
        End If
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRpt.SetParameterValue("lncom1", viewstate("pncom1"))
        crRpt.SetParameterValue("lncom2", viewstate("pncom2"))
        crRpt.SetParameterValue("lncom3", viewstate("pncom3"))
        crRpt.SetParameterValue("lncom4", viewstate("pncom4"))
        crRpt.SetParameterValue("lncom5", viewstate("pncom5"))
        crRpt.SetParameterValue("lncom6", ViewState("pncom6"))
        crRpt.SetParameterValue("lncom7", ViewState("pncom7"))
        crRpt.SetParameterValue("lndeuda", viewstate("pndeuda"))
        crRpt.SetParameterValue("lccreref", viewstate("pccreref"))
        crRpt.SetParameterValue("pncapita", lncapita)

        Dim reportes As String
        reportes = "CrRptDesem.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.End()
        'Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Public Sub Imprimefactura()
 
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Dim lId As String = Request.QueryString("id")
            'Me.txtcodcli.Value = lId

            Me.CargarCombos()
            Me.Limpiar()

        End If
    End Sub

    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged

    End Sub

    Private Sub btnAplica_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplica.ServerClick
        Me.Aplica()
    End Sub
    '---------------------------------------------------'
    'Nuevos procesos de carga enviamos parametro de entrada
    Private Sub CargarDatos(ByVal ccodcli As String)
        ' vpcCodCli = Me.txtcCodcli.Text.Trim    '"001000000001"      'Session("pcCodcli") 'entidadg.ccodcli
        'Me.txtcCodcli.Text = vpcCodCli

        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar
        Dim ds As New DataSet
        Dim ncanti As Integer
        'llenado de Grid Nuevo
        Dim ds_ As New DataSet

        ds_ = eClimgar.Proce_LlenadoGrid(ccodcli)

        'Parse para columna de faltante
        Dim Faltante As Double
        Dim montoSol As Decimal = 0
        Dim saldoLiquida As Decimal
        Dim NomCliente As String
        Dim exCliente As String
        Dim idcliente As Integer = 0
        Dim MontSol As Double
        Dim ComS As Double
        Dim porce As Decimal = 0
        Dim total As Double = 0

        'Agregados
        ds_.Tables(0).Columns.Add("Diferencia")
        ds_.Tables(0).Columns.Add("MontoSugerido")
        For Each fila In ds_.Tables(0).Rows
            porce = fila("porcentaje_Garantias")
            ComS = fila("nmonpor")
            NomCliente = fila("cnomcli")
            montoSol = fila("MontoSol") 'cantidad segun el porcentaje 
            saldoLiquida = fila("nsaldnind")
            porce = porce / 100
            MontSol = ValidaConFormula(ComS, montoSol)
            'MontSol / porce
            total = (MontSol * porce)

            Faltante = saldoLiquida - total

            If saldoLiquida < total Then
                exCliente = exCliente & "Cliente: " & NomCliente & "  Monto Faltante: " & FormatNumber(Faltante, 2) & "\n"
                idcliente = idcliente + 1
            End If

            fila("Diferencia") = FormatNumber(Faltante, 2)
            fila("MontoSugerido") = FormatNumber(total, 2)
        Next
        'Diferencia A los cliente
        If idcliente > 0 Then

            codigoJs = "<script language='javascript'>alert('ATENCION\n\n Revisar Garantias: \n\n" & exCliente & "\n\n  " & _
                     "Advertencia SIM.NET ');</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Ejecuta Evento Si hay clientes con garantias Pendientes
            '////RaiseEvent cambiotabtrips(3)

        End If
        Me.dgGarantias.DataSource = ds_
        Me.dgGarantias.DataBind()
        ''Valida Grid Seleccionar
        Dim Dif As Double
        Dim icon As Integer = 0 'contador de filar || enre columns de ds
        Dim e As Object
        Dim NumeroFilas As Integer
        For Each row As DataRow In ds_.Tables(0).Rows
            'NumeroFilas = ds.Tables(0).Rows(icon)("Nro")
            Dif = ds_.Tables(0).Rows(icon)("Diferencia")
            NumeroFilas = icon
            If Dif >= 0 Then

                Me.dgGarantias.Items(NumeroFilas).Enabled = True
                'Me.dgGarantias.Items(NumeroFilas).BackColor = Color.Yellow
                'desabilita el boton 
            Else
                Me.dgGarantias.Items(NumeroFilas).Enabled = True
                'Me.dgGarantias.ItemStyle.BackColor = Color.Yellow
                Me.dgGarantias.Items(NumeroFilas).BackColor = Color.Yellow
                'Valida si graba e imprime
                'Me.ImageButton1.Enabled = False
                ''Me.btnimprimir.Disabled = False

                'Me.btnimprimir.Disabled = True


            End If

            icon += 1
        Next

    End Sub
    Private Function ValidaConFormula(ByVal com As Decimal, ByVal nmontSug As Decimal) As Decimal
        Dim resta As Decimal
        resta = (1 + (com / 100))
        nmontSug = nmontSug / resta
        Return nmontSug
    End Function
    '-----------------------------------------------------'
    Private Sub GrabaDatosMiembro()
        Dim lcnumpar As String
        Dim cClase As New SIM.BL.crefunc
        Dim ldfecproy As Date
        Dim lnmonchq As Double = 0
        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0
        Dim lcmonsug As String

        'Validar que Variable de Sesion de Usuario no vaya vacio

        Dim lccodusu As String
        lccodusu = Session("gccodusu")
        Dim lnretorno As Integer = 0
        lnretorno = clsppal.VerificaConexion(lccodusu)
        If lnretorno = 0 Then
            'Response.Write("<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo')</script>")
            codigoJs = "<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo', " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Return
        End If


        For xy = 0 To Me.Datagrid1.Items.Count - 1
            lcnumpar = cClase.fxStevo(Session("gdfecsis"))
            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            Me.TxtNomcli.Text = Me.Datagrid1.Items(xy).Cells(1).Text
            Me.txtCodigo.Text = lccodcta.Trim
            lcmonsug = Me.Datagrid1.Items(xy).Cells(3).Text
            lnmonsug = Double.Parse(lcmonsug.Replace("$", ""))
            Me.Aplicar(lcnumpar)
            lnmonchq = Double.Parse(Me.TxtDesembolso.Text)

            Me.Grabar(lcnumpar, "0")

            Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)
        Next
        'Response.Write("<script language='javascript'>alert(Desembolsos Grabada')</script>")
    End Sub

    Private Sub GeneraPlanPagos(ByVal pcCodcta As String, ByVal pnMonapr As Double)
        Dim ecredppg As New cCredppg
        Dim i As Integer = 0
        Dim omcretgas As New cCretgas
        Dim entidadcretgas As New cretgas
        Dim omcremcre As New cCremcre
        Dim entidadcremcre As New cremcre
        Dim ldfecpri As Date

        entidadcremcre.ccodcta = pcCodcta 'Me.txtCodigo.Text.Trim
        omcremcre.ObtenerCremcre(entidadcremcre)

        IgualaDatos(pcCodcta, pnMonapr)

        Dim entidadtabttab As New tabttab
        Dim omtabttab As New cTabttab

        entidadtabttab.ccodtab = "060"
        entidadtabttab.ctipreg = "1"
        entidadtabttab.ccodigo = entidadcremcre.cfrecint

        omtabttab.ObtenerTabttab(entidadtabttab)

        ldfecpri = Session("gdfecsis") 'Date.Parse(Me.txtFecDes.Text)
        ldfecpri = ldfecpri.AddDays(entidadtabttab.nnumtab)

        clsppal.dfecpri = ldfecpri

        clsppal.pnComtra = Session("gnComTra")
        clsppal.pnSegVm = Session("gnSegVm1")
        'clsppal.gniva = Session("gnIVA")
        clsppal.pniva = Session("gnIVA")

        'entidadcretgas.cnrolin = entidadcremcre.cnrolin
        'entidadcretgas.ctipgas = "03"

        'omcretgas.ObtenerCretgas(entidadcretgas)

        'clsppal.ntasseg = entidadcretgas.nmonpor


        Dim ds As New DataSet

        Try

            If ds.Tables.Count > 0 Then
                ds.Tables.Clear()
            End If


            ds = clsppal.fxCreatePlain(1, Double.Parse(Me.txtnmoncuo.Text))

            'Dim nCanti3 As Integer
            'nCanti3 = ds.Tables(0).Rows.Count()
            clsppal.PlanTeorico(ds.Tables(0), pcCodcta)

            'i = 1

            'Me.txtcuota.Text = clsppal.pnmonCuo
            'If CheckBox5.Checked = True Then
            '    Me.TextBox19.Text = clsppal.pnmonCuo
            'Else

            'End If


        Catch ex As Exception
            i = 0
        End Try

    End Sub


    Private Sub IgualaDatos(ByVal pcCodcta As String, ByVal pnMonapr As Double)
        Dim lccodcta As String = pcCodcta
        Dim mcretlin As New cCretlin
        Dim ecretlin As New cretlin
        Dim lcnrolin As String
        Dim lntasa As Double = 0

        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre

        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)

        lcnrolin = ecremcre.cnrolin


        ecretlin.cnrolin = lcnrolin
        mcretlin.ObtenerCretlin(ecretlin)
        lntasa = ecretlin.ntasint


        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.TxtCodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clsppal.lsegvid = eclimide.lsegvida

        clsppal.dFecDes = Session("gdfecSis")

        Dim entidadcredtpl As New cCredtpl
        'clsppal.dfecpri = entidadcredtpl.Obtenerprimeracuota(lccodcta)
        'clsppal.dfecpri0 = entidadcredtpl.ObtenerprimeracuotaCapital(lccodcta)


        clsppal.gnperbas = Session("gnperbas")
        clsppal.nMonDes = pnMonapr 'Double.Parse(TxtCapita.Text)
        'clsppal.nmons = Double.Parse(TxtCapita.Text)
        clsppal.nTasInt = Double.Parse(lntasa)
        clsppal.cCodFor = ecremcre.ctipper
        clsppal.nPerDia = ecremcre.ndiasug
        clsppal.nNroCuo = ecremcre.ncuoapr
        clsppal.cTipCuo = ecremcre.ctipcuo
        clsppal.cTipEst = "N"
        clsppal.nDiaGra = ecremcre.ndiagra
        clsppal.nTipPer = 1
        clsppal.cTipCal = "F"
        clsppal.lFlat = False
        clsppal.lRedo = False
        clsppal.cFlat = ecremcre.cflat
        clsppal.nMeses = ecremcre.nmeses
        clsppal.cNrolin = lcnrolin
        clsppal.pcCodCre = lccodcta
        clsppal.pcCodUsu = Session("gcCodUsu")
        clsppal.dFecsis = Session("gdFecSis")
        clsppal.pctipcon = ecremcre.ctipcon

        clsppal.gnmoncuo = ViewState("pncuota")

        clsppal.cfreccap = ecremcre.cfreccap
        clsppal.cfrecint = ecremcre.cfrecint

        clsppal.pcCodCre = pcCodcta

        clsppal.nPerDia = clsppal.periodo(ecremcre.cfrecint)


    End Sub

    Private Sub Grabar(ByVal cnumpar As String, ByVal ctipmet As String)
        Dim filarefina As DataRow
        Me.txtbandera.Text = 0
        Dim nNum As Integer
        Dim x As Integer
        Dim lcString As String
        Dim ok As Integer

        If Me.Txtnrochq.Text.Trim = "" _
            Or Me.Txtnrochq.Text.Trim = Nothing Then
            Exit Sub
        End If

        Dim etabtbco As New cTabtbco
        Dim lcctacte As String
        lcctacte = etabtbco.CuentadeBanco1(Me.cmbBancos.SelectedValue.Trim)


        '------------------------------------------------
        'Realizando el refinanciamiento si lo hubiese
        '------------------------------------------------
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date
        ldfecDes = Me.fechaproy()
        'Me.txtfecvig.Text = ldfecDes
        cClsDes._nflag = 1
        '-----------------------------------------------
        cClsDes._gdfecsis = ldfecDes 'Session("gdfecsis")

        Dim lccodusu As String
        lccodusu = Session("gccodusu")
        Dim lnretorno As Integer = 0
        lnretorno = clsppal.VerificaConexion(lccodusu)
        If lnretorno = 0 Then
            'Response.Write("<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo')</script>")
            codigoJs = "<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo', " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        cClsDes._gcCodUsu = lccodusu
        cClsDes._cOficina = Me.txtCodigo.Text.Trim.Substring(3, 3)
        cClsDes.cnumrec = Txtfactura.Text.Trim

        'Asigna gastos a propiedades
        Dim ecredgas As New cCredgas
        Dim dt As New DataTable
        Dim lndescuento As Double = 0

        If RadioButton1.Checked = True Then
            dt = ecredgas.CargaComisiones(Me.txtCodigo.Text.Trim, "D")
        Else
            dt = ecredgas.CargaComisionesGrupal(Me.cbxgrupos.Value.Trim, "D")
        End If

        If dt.Rows.Count = 0 Then
            cClsDes._nComOtorg = 0
            cClsDes._nSegDeu = 0
            cClsDes._nHono = 0
            cClsDes._nComEsc = 0
            cClsDes._nDerIns = 0
            cClsDes._nIVA = 0
            lndescuento = 0
        Else
            For Each fila In dt.Rows
                If fila("ccodigo") = "01" Then 'Comision por Otorgamiento
                    cClsDes._nComOtorg = fila("nmongas")
                ElseIf fila("ccodigo") = "02" Then ' Seguro de vida

                ElseIf fila("ccodigo") = "03" Then ' Seguro de deuda
                    cClsDes._nSegDeu = fila("nmongas")
                ElseIf fila("ccodigo") = "04" Then ' Gastos notariales
                    cClsDes._nHono = fila("nmongas")
                ElseIf fila("ccodigo") = "05" Then ' Manejo de cuenta
                    cClsDes._nComEsc = fila("nmongas")
                ElseIf fila("ccodigo") = "06" Then 'Supervision
                    cClsDes._nDerIns = fila("nmongas") 'Derechos de Inscripcion
                ElseIf fila("ccodigo") = "08" Then 'IVA
                    cClsDes._nIVA = fila("nmongas")
                End If
                lndescuento += fila("nmongas")

            Next

        End If

        Me.TxtDesembolso.Text = utilNumeros.Redondear((Double.Parse(TxtCapita.Text) - lndescuento), 2)


        cClsDes._cCuenta = Me.txtCodigo.Text.Trim
        cClsDes._nCapita = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCapita1 = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nDescuento = Double.Parse(Me.TxtDescuento.Text)
        cClsDes._nDesembolso = Double.Parse(Me.TxtDesembolso.Text)

        cClsDes._nKP = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCJ = Double.Parse(Me.TxtDesembolso.Text)
        'cClsDes._cTipdes = "C"
        'cClsDes._cTippag = "C"
        cClsDes._cTipdes = Me.cmbtippag.SelectedItem.Value.Trim
        cClsDes._cTippag = Me.cmbtippag.SelectedItem.Value.Trim
        cClsDes._cBanco = Me.cmbBancos.SelectedValue.Trim
        cClsDes._cCotacte = lcctacte
        cClsDes._cGlosa = Me.cGlosa.Text.Trim
        cClsDes._cNomcli = Me.TxtNomcli.Text.Trim
        cClsDes._cNrochq = Me.Txtnrochq.Text.Trim
        cClsDes._cReg = Me.txtCodigo.Text.Trim.Substring(0, 3)
        cClsDes._cNrodoc = Me.TxtDocumento.Text.Trim
        cClsDes._ccodsol = Me.cbxgrupos.Value.Trim
        cClsDes.gniva = Session("gnIVA")

        Dim lnValida As Integer

        Try
            If Me.RadioButton1.Checked = True Then
                lnValida = cClsDes.Desembolso(cnumpar, ctipmet, 0, 0)
            Else
                lnValida = cClsDes.DesembolsoSoloCheque(cnumpar, ctipmet)
            End If
        Catch ex As Exception

        End Try
        

        If lnValida = 0 Then   'Ocurrio un Error se va al Log de Errores
            Exit Sub
        Else
        End If
        clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.Txtnrochq.Text.Trim)
        'Me.Cargar_Gastos()
        Me.ImageButton1.Enabled = False
        Me.btnimprimir.Disabled = False

    End Sub
    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Me.Limpiar()
    End Sub
    Private Sub Cargar_Gastos()
        'Dim xy As Integer
        'Dim xydata As New DataSet
        'Dim clscredgas As New cCredgas
        'Dim lctipgas As String
        'Dim lngasto As Double
        ViewState("pncom1") = 0
        ViewState("pncom2") = 0
        ViewState("pncom3") = 0
        ViewState("pncom4") = 0
        ViewState("pncom5") = 0
        ViewState("pncom6") = 0
        ViewState("pncom7") = 0
        ViewState("pndeuda") = 0
        ViewState("pccreref") = ""
        'xydata = clscredgas.ObtenerDataSetPorID2(Me.txtCodigo.Text.Trim, "D")
        'xy = xydata.Tables(0).Rows.Count
        'If xy = 0 Then

        'Else
        '    xy = 0
        '    Dim Filaxy As DataRow
        '    For Each Filaxy In xydata.Tables(0).Rows
        '        lctipgas = xydata.Tables(0).Rows(xy)("ctipgas")
        '        lngasto = xydata.Tables(0).Rows(xy)("nmongas")
        '        If lctipgas = "01" And lngasto <> 0 Then
        '            ViewState("pncom1") = ViewState("pncom1") + xydata.Tables(0).Rows(xy)("nmongas")
        '        ElseIf lctipgas = "03" And lngasto <> 0 Then
        '            ViewState("pncom2") = ViewState("pncom2") + xydata.Tables(0).Rows(xy)("nmongas")
        '        ElseIf lctipgas = "04" And lngasto <> 0 Then
        '            ViewState("pncom3") = ViewState("pncom3") + xydata.Tables(0).Rows(xy)("nmongas")
        '        ElseIf lctipgas = "PR" And lngasto <> 0 Then
        '            ViewState("pncom4") = ViewState("pncom4") + xydata.Tables(0).Rows(xy)("nmongas")
        '        ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
        '            ViewState("pncom5") = ViewState("pncom5") + xydata.Tables(0).Rows(xy)("nmongas")
        '        ElseIf lctipgas = "02" And lngasto <> 0 Then
        '            ViewState("pncom6") = ViewState("pncom6") + xydata.Tables(0).Rows(xy)("nmongas")
        '        End If
        '        xy += 1
        '    Next
        'End If

    End Sub
    Private Sub refina()

    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        Me.Imprime()
        Me.Limpiar()
    End Sub

    Private Sub btnfactura_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfactura.ServerClick
        Me.Imprimefactura()
    End Sub
    Private Function fechaproy() As Date
       
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date = Session("gdfecsis")
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl

        entidadCredtpl.ccodcta = Me.txtCodigo.Text.Trim
        entidadCredtpl.ctipope = "D"
        entidadCredtpl.cnrocuo = "001"
        eCredtpl.ObtenerCredtpl(entidadCredtpl)
        ldfecDes = entidadCredtpl.dfecven
        Return ldfecDes
    End Function

    Private Sub CargaGrid(ByVal ds As DataSet)
        Dim ecreditos As New ccreditos

        ds = ecreditos.ListadoCreditosxGrupoDesembolso(Me.cbxgrupos.Value)

        Datagrid1.DataSource = ds
        Datagrid1.DataBind()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnsumsol As Double = 0
        Dim lnmonsol As Double = 0
        Dim lnsumsug As Double = 0
        Dim lnmonsug As Double = 0
        Dim ldfecvig As Date = Session("gdfecsis")

        Dim dt1 As New DataTable
        Dim ecredgas As New cCredgas
        Dim entidad3 As New credgas

        Dim entidadcretlin As New cretlin
        Dim mcretlin As New cCretlin


        For Each fila In ds.Tables(0).Rows
            lnmonsug = ds.Tables(0).Rows(i)("nmonapr")
            lnsumsug = lnsumsug + lnmonsug

            'ldfecvig = ds.Tables(0).Rows(i)("dfecvig") Comentariado para no permitir desembolsos proyectados
            '----------------------Graba gastos-------------
            'dt1 = ecreditos.Comisiones(fila("nmonapr"), fila("ccodlin").Substring(8, 2), fila("lsegvid"))
            'ecredgas.Eliminarporcuenta(fila("ccodcta"))


            '-----------------------------------------------
            entidadcretlin.cnrolin = fila("cnrolin")
            mcretlin.ObtenerCretlin(entidadcretlin)
            Me.txtnmoncuo.Text = entidadcretlin.nmoncuo

            i += 1
        Next
        Me.txtnMonApr.Text = lnsumsug

        Me.txtdfecvig.Text = ldfecvig

        If Me.cbxgrupos.Value.Trim.Substring(6, 2) = "02" Then
            Label13.Text = "Banco Comunal"
        Else
            Label13.Text = "Grupo Solidario"
        End If

        Me.cbxclientes.DataTextField = "cNomcli"
        Me.cbxclientes.DataValueField = "cCodcta"
        Me.cbxclientes.DataSource = ds.Tables(0)
        Me.cbxclientes.DataBind()



        Dim dt As New DataTable
        Dim lndescuento As Double = 0
        Dim lndes As Double = 0
        dt = ecredgas.CargaComisionesGrupal(Me.cbxgrupos.Value.Trim, "D") 'ecreditos.ComisionesGrupal(ds)


        Datagrid2.DataSource = dt
        Datagrid2.DataBind()




        For Each fila In dt.Rows
            lndes = lndes + fila("nmongas")

            If fila("ccodigo") = "01" Then
                ViewState("pncom1") = fila("nmongas")
            ElseIf fila("ccodigo") = "02" Then
                ViewState("pncom2") = fila("nmongas")
            ElseIf fila("ccodigo") = "03" Then
                ViewState("pncom3") = fila("nmongas")
            ElseIf fila("ccodigo") = "04" Then
                ViewState("pncom4") = fila("nmongas")
            ElseIf fila("ccodigo") = "05" Then
                ViewState("pncom5") = fila("nmongas")
            ElseIf fila("ccodigo") = "06" Then
                ViewState("pncom6") = fila("nmongas")
            Else
                ViewState("pncom7") = fila("nmongas")
            End If

        Next

        lndescuento = lndes


    End Sub

    Protected Sub cmbBancos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedIndexChanged
        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)
    End Sub
    Private Sub Aplicar(ByVal cnumpar As String)
        Dim lcdescri As Exception
        Dim ds As New DataSet
        'Sacando los datos necesarios para el Desembolso
        Dim lcestado As String
        Dim lndescuento As Double
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre

        Me.txtbandera.Text = 1

        Try

            entidad1.ccodcta = Me.txtCodigo.Text

            ecreditos.ObtenerCremcre(entidad1)

            lcestado = entidad1.cestado


            If lcestado <> "E" Then
                Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                Exit Sub
            End If


            Me.TxtCodcli.Text = entidad1.ccodcli
            Me.TxtCapita.Text = utilNumeros.Redondear(entidad1.nmonapr, 2)

            Dim ldfecvig As Date = entidad1.dfecvig
            Dim ldfecven As Date = entidad1.dfecven

            Dim lndias As Integer
            lndias = DateDiff(DateInterval.Day, ldfecvig, ldfecven)


            'Datos del Cliente
            Dim entidad2 As New SIM.EL.climide
            Dim eClimide As New SIM.BL.cClimide

            entidad2.ccodcli = Me.TxtCodcli.Text


            eClimide.ObtenerClimide(entidad2)
            Dim lcnomcli As String

            Me.TxtNomcli.Text = entidad2.cnomcli

            'Numero de Documento para desembolso
            Dim entidadKardex As New SIM.EL.credkar
            Dim eKardex As New SIM.BL.cCredkar
            Dim lcnrodoc As String

            entidadKardex.ccodcta = Me.txtCodigo.Text.Trim

            Me.TxtDocumento.Text = eKardex.obtenercnrodoc(Me.txtCodigo.Text.Trim)


            '-------------------------------------
            'Sacando los gastos
            '-------------------------------------

            'Comision por Otorgamiento
            Dim entidad3 As New SIM.EL.credgas
            Dim ecredgas As New SIM.BL.cCredgas

           
            Dim dt As New DataTable
            Dim lndes As Double = 0
            dt = ecredgas.CargaComisiones(txtCodigo.Text.Trim, "D")


            Dim fila As DataRow
            For Each fila In dt.Rows
                lndes = lndes + fila("nmongas")
            Next

            lndescuento = lndes

            Me.TxtDescuento.Text = utilNumeros.Redondear(lndescuento, 2)

            Me.TxtDesembolso.Text = utilNumeros.Redondear((Double.Parse(Me.TxtCapita.Text) - lndescuento), 2)

            'Total a Desembolsar
            Dim lndesembolso As Double = 0
            lndesembolso = utilNumeros.Redondear((Double.Parse(Me.TxtCapita.Text) - lndescuento), 2)
            Me.TxtDesembolso.Text = lndesembolso
            'Concepto        
            Dim ecremsol As New cCremsol
            Me.cGlosa.Text = HiddenField1.Value.Trim 'ecremsol.ObtenerNombre(Me.cbxgrupos.Value.Trim).Trim & " " & Me.TxtNomcli.Text.Trim & " Plazo: " & lndias.ToString & " días" & " Partida Nº " & cnumpar

        Catch ex As Exception
            'Throw ex
        End Try

    End Sub


    Private Sub GrabaDatosConsolidados()
        Dim lcnumpar As String
        Dim cClase As New SIM.BL.crefunc
        Dim ecremcre As New cCremcre

        Dim lnmonchq1 As Double = 0
        Dim lnmonapr1 As Double = 0
        Dim lncomision1 As Double = 0
        Dim lncomesc1 As Double = 0
        Dim lnsegdeu1 As Double = 0
        Dim lnhonserv1 As Double = 0
        Dim lnderechos1 As Double = 0
        Dim lniva1 As Double = 0
        Dim lndescuento1 As Double = 0
        Dim lndesembolso1 As Double = 0

        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0
        Dim lcmonsug As String

        lcnumpar = cClase.fxStevo(Session("gdfecsis"))
        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)

        For xy = 0 To Me.Datagrid1.Items.Count - 1

            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            Me.TxtNomcli.Text = Me.Datagrid1.Items(xy).Cells(1).Text
            Me.txtCodigo.Text = lccodcta.Trim
            lcmonsug = Me.Datagrid1.Items(xy).Cells(3).Text
            lnmonsug = Double.Parse(lcmonsug.Replace("$", ""))

            Me.Aplicar(lcnumpar)

            lnmonchq1 = lnmonchq1 + Double.Parse(Me.TxtDesembolso.Text)
            lnmonapr1 = lnmonapr1 + Double.Parse(Me.TxtCapita.Text)

            CargarGastosporCliente(lccodcta.Trim)

            'lncomision1 = lncomision1 + Double.Parse(Me.TextBox5.Text)
            'lnsegdeu1 = lnsegdeu1 + Double.Parse(Me.TextBox7.Text)
            'lnhonserv1 = lnhonserv1 + Double.Parse(Me.TextBox9.Text)
            'lnderechos1 = lnderechos1 + Double.Parse(Me.TextBox10.Text)
            'lniva1 = lniva1 + 0

            lndescuento1 = lndescuento1 + Double.Parse(Me.TxtDescuento.Text)
            lndesembolso1 = lndesembolso1 + Double.Parse(Me.TxtDesembolso.Text)

            Me.GrabarCadaCliente(lcnumpar, "0")
        Next

        Me.TxtDesembolso.Text = lndesembolso1
        Me.TxtCapita.Text = lnmonapr1
        'Me.TextBox5.Text = lncomision1
        'Me.TextBox6.Text = lncomesc1
        'Me.TextBox7.Text = lnsegdeu1
        'Me.TextBox9.Text = lnhonserv1
        'Me.TextBox10.Text = lnderechos1
        'Me.txtIVA.Text = lniva1
        Me.TxtDescuento.Text = lndescuento1

        If CheckBox1.Checked = True Then
            If txtcnomchq.Text.Trim = "" Then
                Me.TxtNomcli.Text = ecremcre.ObtenerNombrexCuenta(Me.cbxclientes.Value.Trim)
            Else
                TxtNomcli.Text = txtcnomchq.Text.Trim.ToUpper
            End If

        Else
            Me.TxtNomcli.Text = ecremcre.ObtenerNombrexCuenta(Me.cbxclientes.Value.Trim)
        End If

        Me.Grabar(lcnumpar, "0")

        'Response.Write("<script language='javascript'>alert(Desembolsos Grabada')</script>")
    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If cmbBancos.Items.Count = 0 Then
            cmbBancos.Enabled = False
            ImageButton1.Enabled = False
            'Response.Write("<script language='javascript'>alert('Necesita Asignar Bancos a Oficina')</script>")
            codigoJs = "<script language='javascript'>alert('Necesita Asignar Bancos a Oficina, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Return
        Else
            ImageButton1.Enabled = True
            cmbBancos.Enabled = True
        End If

        If RadioButton1.Checked = True Then
            GrabaDatosMiembro()
        Else
            GrabaDatosConsolidados()
        End If

        cmbBancos.Enabled = False
        Txtnrochq.Enabled = False
        Txtfactura.Enabled = False
        ImageButton1.Enabled = False
        'Response.Write("<script language='javascript'>alert('Desembolso Generado, Imprima Comprobante')</script>")
        codigoJs = "<script language='javascript'>alert('Desembolso Generado, Imprima Comprobante, " & _
                     "Advertencia SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
    End Sub
    
    Protected Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label33.Visible = True
        cbxclientes.Visible = True
    End Sub

    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label33.Visible = False
        cbxclientes.Visible = False
    End Sub

    Private Sub GrabarCadaCliente(ByVal cnumpar As String, ByVal ctipmet As String)
        Dim filarefina As DataRow
        Me.txtbandera.Text = 0
        Dim nNum As Integer
        Dim x As Integer
        Dim lcString As String
        Dim ok As Integer

        If Me.Txtnrochq.Text.Trim = "" _
            Or Me.Txtnrochq.Text.Trim = Nothing Then
            Exit Sub
        End If

        Dim etabtbco As New cTabtbco
        Dim lcctacte As String
        lcctacte = etabtbco.CuentadeBanco1(Me.cmbBancos.SelectedValue.Trim)


        '------------------------------------------------
        'Realizando el refinanciamiento si lo hubiese
        '------------------------------------------------
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date
        ldfecDes = Me.fechaproy()
        'Me.txtfecvig.Text = ldfecDes
        cClsDes._nflag = 1
        '-----------------------------------------------
        cClsDes._gdfecsis = ldfecDes 'Session("gdfecsis")
        cClsDes._gcCodUsu = Session("gcCodusu")
        cClsDes._cOficina = Me.txtCodigo.Text.Trim.Substring(3, 3)
        cClsDes.cnumrec = Txtfactura.Text.Trim

        cClsDes._cCuenta = Me.txtCodigo.Text.Trim
        cClsDes._nCapita = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nDescuento = Double.Parse(Me.TxtDescuento.Text)
        cClsDes._nDesembolso = Double.Parse(Me.TxtDesembolso.Text)

        'Asigna gastos a propiedades
        'Dim ecredgas As New cCredgas
        'Dim dt As New DataTable
        'dt = ecredgas.CargaComisiones(Me.txtCodigo.Text.Trim, "D")
        'If dt.Rows.Count = 0 Then
        '    cClsDes._nComOtorg = 0
        '    cClsDes._nSegDeu = 0
        '    cClsDes._nHono = 0
        '    cClsDes._nComEsc = 0
        '    cClsDes._nDerIns = 0
        '    cClsDes._nIVA = 0

        'Else
        'For Each fila In dt.Rows
        '    If fila("ccodigo") = "01" Then 'Comision por Otorgamiento
        '        cClsDes._nComOtorg = fila("nmongas")
        '    ElseIf fila("ccodigo") = "02" Then ' Seguro de vida

        '    ElseIf fila("ccodigo") = "03" Then ' Seguro de deuda
        '        cClsDes._nSegDeu = fila("nmongas")
        '    ElseIf fila("ccodigo") = "04" Then ' Gastos notariales
        '        cClsDes._nHono = fila("nmongas")
        '    ElseIf fila("ccodigo") = "05" Then ' Manejo de cuenta
        '        cClsDes._nComEsc = fila("nmongas")
        '    ElseIf fila("ccodigo") = "06" Then 'Supervision
        '        cClsDes._nDerIns = fila("nmongas") 'Derechos de Inscripcion
        '    ElseIf fila("ccodigo") = "08" Then 'IVA
        '        cClsDes._nIVA = fila("nmongas")
        '    End If

        'Next

        'End If


        'cClsDes._nComOtorg = Double.Parse(Me.TextBox5.Text) 'Comision por Otorgamiento
        'cClsDes._nIVA = Double.Parse(Me.txtIVA.Text)
        'cClsDes._nComEsc = Double.Parse(Me.TextBox6.Text)
        'cClsDes._nSegDeu = Double.Parse(Me.TextBox7.Text)  'Seguro de Deuda
        'cClsDes._nHono = Double.Parse(Me.TextBox9.Text)  'Honorarios por Servicios
        'cClsDes._nDerIns = Double.Parse(Me.TextBox10.Text) 'Derechos de Inscripcion


        cClsDes._nKP = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCJ = Double.Parse(Me.TxtDesembolso.Text)
        cClsDes._cTipdes = "C"
        cClsDes._cTippag = "C"
        cClsDes._cBanco = Me.cmbBancos.SelectedValue.Trim
        cClsDes._cCotacte = lcctacte
        cClsDes._cGlosa = Me.cGlosa.Text.Trim
        cClsDes._cNomcli = Me.TxtNomcli.Text.Trim
        cClsDes._cNrochq = Me.Txtnrochq.Text.Trim
        cClsDes._cReg = Me.txtCodigo.Text.Trim.Substring(0, 3)
        cClsDes._cNrodoc = Me.TxtDocumento.Text.Trim

        Dim lnValida As Integer


        lnValida = cClsDes.DesembolsoSinCheque(cnumpar, ctipmet)
        If lnValida = 0 Then   'Ocurrio un Error se va al Log de Errores
            Exit Sub
        Else
        End If
        '        clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.Txtnrochq.Text.Trim)
        'Me.Cargar_Gastos()
        Me.ImageButton1.Enabled = False
        Me.btnimprimir.Disabled = False

    End Sub

    Protected Sub cmbtippag_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtippag.SelectedIndexChanged
        Dim indice As Integer
        Dim cadena As String = ""
        Dim bandera As Boolean = 0
        Dim codBanco As Integer = 0

        For indice = 0 To cmbBancos.Items.Count - 1

            Select Case cmbtippag.SelectedItem.Text.Trim
                Case "EFECTIVO"
                    cadena = cmbBancos.Items(indice).Text.ToUpper.Trim
                    'If InStr(cadena, "EFECTIVO") = 0 Then
                    ' bandera = 0
                    ' Else
                    If InStr(cadena, "EFECTIVO") <> 0 Then
                        cmbBancos.SelectedValue = cmbBancos.Items(indice).Value
                        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)
                    End If
                Case "NOTA DE ABONO"
                    cadena = cmbBancos.Items(indice).Text.ToUpper.Trim
                    If InStr(cadena, "EFECTIVO") = 0 Then
                        cmbBancos.SelectedValue = cmbBancos.Items(indice).Value
                        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)
                    End If
            End Select
        Next

    End Sub


    Private Sub CargarGastosporCliente(ByVal ccodcta As String)
        'Asigna gastos a propiedades
        Dim ecredgas As New cCredgas
        Dim dt As New DataTable
        Dim lndescuento As Double = 0

        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox9.Text = 0
        TextBox10.Text = 0


        dt = ecredgas.CargaComisiones(ccodcta, "D")
        
        For Each fila In dt.Rows
            lndescuento += fila("nmongas")
        Next
     
    End Sub

    Protected Sub dgGarantias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGarantias.SelectedIndexChanged
        Dim cadenaselccion As String

        cadenaselccion = dgGarantias.SelectedItem.Cells(1).Text.ToString()

        'Envia datos a WBGARANT
        'Generamos instancia para extaer valor de link
        Dim LinkFoto As New cCredgas

        Dim valor = LinkFoto.Extrae__cadenas(cadenaselccion)

        If valor = "0" Or valor = "" Then

            codigoJs = "<script language='javascript'>alert('No existe ticket de garantia, " & _
                     "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        Else
            Response.Write("<script>window.open(" + "'Imgen_Ticket_Cl.aspx?Valor=" + valor + "','blank');</script>")
            ' Response.Redirect("Imgen_Ticket_Cl.aspx?Valor=" + valor)
        End If

    End Sub
End Class
