Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class CUWPreAprLote
    Inherits System.Web.UI.UserControl
    
#Region "Variables"
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clase As New SIM.BL.class1
    Private cls_Sim As New SIM.BL.ClsSolicitud
    Private pcCodCta As String
    Private clsConvert As New SIM.BL.ConversionLetras
    'Private pcCodCta As String
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
    Private lndiasug As Integer
    Private lctipper As String
    Private lnmeses As Integer


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
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
    Private codigoJs As String
#End Region

#Region " Metodos "
    Private Sub CargarDatos()

        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        ds = etabtofi.ObtenerDataSetPorNivel(Session("gnNivel"), Session("gcCodOfi"))

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
            'MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No Existen Oficinas, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Exit Sub
        End If
        Me.cbxcodofi.DataTextField = "cNomOfi"
        Me.cbxcodofi.DataValueField = "cCodOfi"
        Me.cbxcodofi.DataSource = ds.Tables(0)
        Me.cbxcodofi.DataBind()
        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Institucion
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,3) as ccodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0541'"
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

        Me.cbxCodIns.DataTextField = "cDescri"
        Me.cbxCodIns.DataValueField = "cCodigo"
        Me.cbxCodIns.DataSource = ds.Tables("Resultado")
        Me.cbxCodIns.DataBind()

        ds.Tables("Resultado").Clear()

        Try
            Dim lccodins As String
            lccodins = etabtofi.ObtenerRegiondeOficina(Session("gccodofi"))
            cbxCodIns.SelectedValue = lccodins
        Catch ex As Exception

        End Try


        CargarOficina()

        'cbxLineas
        Dim entidad2 As New SIM.EL.cretlin
        Dim clscretlin As New SIM.BL.cCretlin

        Dim mListacretlin As New listacretlin
        mListacretlin = clscretlin.ObtenerLista()
        '        ecretlin.ObtenerLista()


        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = mListacretlin
        Me.cbxLineas.DataBind()
        Me.txtFecDes.Text = Today()
        Me.txtfecpri.Text = Today.AddMonths(1)
        Me.txtgarantias.Text = 0
        '--------
        'Llenado cbxLienas
        '--------
        ''Me.cbxLineas.Items.Add("Selecione una linea")


        '----------------------------
        'Llenando Grupos
        '----------------------------
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

        Me.cbxgrupos.Visible = False
        Me.Label13.Visible = False
        Me.cbxgrupos.Disabled = True

        ds.Tables("Resultado").Clear()

        '----------------------------
        'Causas de rechazo
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0421'   order by cdescri"
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


        Me.cbxrechazo.DataTextField = "cdescri"
        Me.cbxrechazo.DataValueField = "cCodigo"
        Me.cbxrechazo.DataSource = ds.Tables("Resultado")
        Me.cbxrechazo.DataBind()
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
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
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
        ds.Tables("Resultado").Clear()


        Label15.Visible = False
        cbxrechazo.Visible = False
        txtbandera.Text = "0"

        Me.btnGrabar.Disabled = True
        Me.Button1.Disabled = True

        CargaTasas()

        Me.CbxUsuario_Comite1.Recuperar(Session("gnIdusuario"))
        'Cambio realizado para vlidar CbxLineas
        cbxLineas.Enabled = False

    End Sub
    Private Sub CargaGrid()
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        ds = ecreditos.ListadoCreditosxGrupoPreAprobar(pcCodCta)

        Datagrid1.DataSource = ds
        Datagrid1.DataBind()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnsumsol As Double = 0
        Dim lnmonsol As Double = 0
        Dim lnsumsug As Double = 0
        Dim lnmonsug As Double = 0


        For Each fila In ds.Tables(0).Rows
            lnmonsol = ds.Tables(0).Rows(i)("nmonsol")
            lnsumsol = lnsumsol + lnmonsol

            lnmonsug = ds.Tables(0).Rows(i)("nmonapr")
            lnsumsug = lnsumsug + lnmonsug


            i += 1
        Next
        Me.txtMonSol.Text = lnsumsol
        Me.txtmonSug.Text = lnsumsug
        Me.txtnMonApr.Text = lnsumsug



        If pcCodCta.Trim.Substring(6, 2) = "02" Then
            Label13.Text = "Banco Comunal"
        Else
            Label13.Text = "Grupo Solidario"
        End If
        'Revision de seguros
        buscarSeguros(ds)
        '--
        'Valida que los montos sugeridos sean correctos
        ValidaMontos(pcCodCta)

    End Sub
    'Procesos de revision de seguros
    Public Sub buscarSeguros(ByVal ds_ As DataSet)
        Dim monto_prodcuto As Integer
        monto_prodcuto = buscaSeguroProducto(ds_)

        Dim eClimgar As New SIM.BL.cClimgar
        Dim buscarCreditos As String
        Dim obtieneSeguro As Integer = 0
        Dim contadorClientesFaltaSeguros As Integer = 0
        Dim obtineCreditosSegurosFalatantes As String

        For Each rows As DataRow In ds_.Tables(0).Rows
            buscarCreditos = eClimgar.obtnerCreditos(rows("ccodcta"))
            obtieneSeguro = eClimgar.obtenerSeguros(buscarCreditos)

            If obtieneSeguro = monto_prodcuto Then
            Else
                contadorClientesFaltaSeguros += 1
                obtineCreditosSegurosFalatantes = obtineCreditosSegurosFalatantes & "\n" & buscarCreditos & "\n"
            End If
        Next

        If contadorClientesFaltaSeguros > 0 Then

            codigoJs = "<script language='javascript'>alert('ATENCION\nRevisar Seguros de los creditos siguientes. \n\n" & _
                         obtineCreditosSegurosFalatantes & "\nAdvertencia SIM.NET ');location.href='WbPreAprLote.aspx'; </script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If

    End Sub
    'Realiza la busqueda del codigo de producto para obtener el monto de seguro
    Public Function buscaSeguroProducto(ByVal ds As DataSet) As Integer
        Dim obtiene_cnrolin As String
        Dim obtieneseguro As Integer
        Dim eClimgar As New SIM.BL.cClimgar

        For Each rows As DataRow In ds.Tables(0).Rows
            obtiene_cnrolin = eClimgar.obtenerSeguro(rows("ccodcta"))
        Next
        obtieneseguro = eClimgar.Buscarmonto(obtiene_cnrolin)

        Return obtieneseguro
    End Function
    'Validando datos en montos + comision 
    Private Sub ValidaMontos(ByVal pcCodCta As String)
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        ds = ecreditos.ValidadorMontosMasComison(cbxLineas.SelectedValue, pcCodCta)

        'Validar montos solictados segun la comison
        Dim DatosComsion As DataTable = ds.Tables(0).Copy

        Dim montSug As Double 'captura el valor de cada fila
        Dim ComS As Double 'captura el valor de total_desc
        Dim MontSol As Double 'mantiene el valor para recibir otro valor y almacenarlos
        Dim nombrecli As String
        Dim almacen_Nomb As String
        Dim identMOnto As Integer = 0
        'Recorrer las columna de capital desembolsado
        For Each rowsDa As DataRow In DatosComsion.Rows
            ComS = rowsDa("nmonpor") 'Comision del producto
            montSug = rowsDa("nmonsug") 'sugerencia 
            nombrecli = rowsDa("cnomcli") 'extrae nombre cliente
            MontSol = ValidaConFormula(ComS, montSug) 'enviar a fucnion de restado la comision a sug
            'valida datos si es diferente es advertencia
            If MontSol Mod 500 <> 0 Then

                almacen_Nomb = almacen_Nomb & "Cliente: " & nombrecli & "  Monto Sugerido: " & montSug & "\n"
                identMOnto = identMOnto + 1
            End If

        Next

        If identMOnto > 0 Then

            codigoJs = "<script language='javascript'>alert('ATENCION\n-------------------------------------------------\nREVISAR COMISION FRACCIONADA:\n-------------------------------------------------\n" & almacen_Nomb & "\n  " & _
                     "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        End If
    End Sub
    'Formula de validacion para montos
    Private Function ValidaConFormula(ByVal com As Decimal, ByVal nmontSug As Decimal) As Decimal
        Dim resta As Decimal
        resta = (1 + (com / 100))
        nmontSug = nmontSug / resta
        Return nmontSug
    End Function
    Private Sub CargarDatosCredito()
        'pccodcta <Codigo del grupo>

        Me.CargaGrid()
        pcCodCta = Me.Datagrid1.Items(0).Cells(0).Text
        Me.txtCredito.Text = pcCodCta
        Try
            cbxCodIns.SelectedValue = pcCodCta.Trim.Substring(0, 3)
            CargarOficina()
            Me.cbxcodofi.SelectedValue = pcCodCta.Trim.Substring(3, 3)
        Catch ex As Exception

        End Try
        'Label15.Visible = False
        'cbxrechazo.Visible = False

        'Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta

        ecreditos.Obtenercreditos(entidad3)
        If entidad3.cestado <> "C" And entidad3.cestado <> "E" Then
            Me.btnGrabar.Disabled = True
            Me.Button1.Disabled = True
            Me.btnPlan.Disabled = True
            'Response.Write("<script language='javascript'>alert('Estado Errado')</script>")
            codigoJs = "<script language='javascript'>alert('Estado del Crédito Errado, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        Else
            Me.btnPlan.Disabled = False
        End If
        'Me.txtcCodCli.Text = entidad3.ccodcli
        'Me.txtcNomcli.Text = entidad3.cnomcli
        'Me.txtMonSol.Text = entidad3.nmonsol
        Me.txtNomAna.Text = entidad3.cNomUsu
        'Me.txtmonSug.Text = entidad3.nmonsug
        Me.pnCuoSug.Text = entidad3.ncuosug
        'Me.txtnMonApr.Text = entidad3.nmonsug
        Me.txtcTipPer.Text = entidad3.ctipper
        Me.txtcTipCuo.Text = entidad3.ctipcuo
        Me.txtnperdia.Text = entidad3.ndiasug
        Me.txtndiaGra.Text = entidad3.ndiagra
        Me.txtcontrato.Text = entidad3.ctipcon
        Me.txtcflat.Text = IIf(IsDBNull(entidad3.cflat), "", entidad3.cflat)
        txtacta.Text = entidad3.cacta
        txtresolucion.Text = entidad3.cresolucion

        Me.txttipocuota.Text = IIf(txtcflat.Text.Trim = "F", "FLAT", "DECRECIENTE")

        Me.txtFecDes.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)
        Me.txtFecDes0.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)

        Dim entidadcredtpl As New cCredtpl
        txtdFecVen.Text = entidadcredtpl.ObtenerUltimacuota(pcCodCta)
        Me.txtfecpri.Text = entidadcredtpl.Obtenerprimeracuota(pcCodCta)
        Me.txtfecpri0.Text = entidadcredtpl.Obtenerprimeracuota(pcCodCta)
        ''verifica numero de creditos

        'Dim lnciclo As Integer
        'lnciclo = ecreditos.ciclo(Me.txtcCodCli.Text.Trim, pcCodCta)
        'Dim lcletras As String
        'lcletras = clsConvert.ConversionEnteros(lnciclo)
        'If lnciclo > 1 Then
        '    ViewState("pctippre") = lcletras + " CREDITOS "
        'Else
        '    ViewState("pctippre") = "NUEVO"
        'End If

        ''        viewstate("pctippre") = IIf(entidad3.ctipcre = "N", "NUEVO", "RECURRENTE")
        'lndiasug = entidad3.ndiasug
        'lctipper = entidad3.ctipper

        'Me.txtgarantias.Text = clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        'Session("nGrav") = Me.txtgarantias.Text
        'pcCodAct = entidad3.ccodact
        'Session.Add("pcCodcli", Me.txtcCodCli.Text)
        ''
        Me.cbxgrupos.Value = entidad3.ccodsol
        Me.cbxgrupos.Visible = True
        Me.Label13.Visible = True
        Me.txtccodsol.Text = entidad3.ccodsol

        Me.cbxprograma.SelectedValue = entidad3.ccodfue
        Me.CargaLineasxFondos(entidad3.ccodfue)

        If IsDBNull(entidad3.cnrolin) Then
        Else
            Try
                Dim entidadcretlin As New cretlin
                Dim mcretlin As New cCretlin

                Me.cbxLineas.SelectedValue = entidad3.cnrolin
                entidadcretlin.cnrolin = Me.cbxLineas.SelectedValue.Trim
                mcretlin.ObtenerCretlin(entidadcretlin)

                Me.txtnmoncuo.Text = entidadcretlin.nmoncuo
            Catch ex As Exception

            End Try

        End If

        'If entidad3.ccodsol = "" Or entidad3.ccodsol.Trim = "" Then
        '    Me.cbxgrupos.Visible = False
        '    Me.Label13.Visible = False
        '    Me.txtccodsol.Text = ""
        'Else
        'End If

        Me.txtcfreccap.Text = entidad3.cfreccap
        Me.txtcfrecint.Text = entidad3.cfrecint

        txttasa.Text = entidad3.ntasint
        'Dim entidad4 As New SIM.EL.clidfin
        'Dim clsclidfin As New SIM.BL.cClidfin

        'Dim mListaclidfin As New listaclidfin
        'mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)

        'Dim ecretlin As New cCretlin
        Session("CodigoCre") = pcCodCta

        Dim lverificaPlan As Boolean
        lverificaPlan = clase.VerificaExistePlanTeorico(pcCodCta)
        If lverificaPlan = True Then
            btnPlan.Disabled = True
            btnGrabar.Disabled = False
        Else
            btnPlan.Disabled = False
            btnGrabar.Disabled = True
        End If
        'Iguala Valores del plan de pagos
        HiddenField5.Value = cbxLineas.SelectedValue.Trim
        HiddenField6.Value = Double.Parse(txttasa.Text)
        HiddenField7.Value = Integer.Parse(pnCuoSug.Text)
        HiddenField8.Value = Double.Parse(txtmonSug.Text)


    End Sub
    'Realiza grabacion
    Private Sub GrabaAprobacionComite()

        Dim reportes As String = "AprobacionGrupal.pdf"
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        Dim lnmeses As Integer = 0
        Dim lndias As Integer = 0
        Dim lcFrecuencia As String = ""
        Dim omtabttab As New cTabttab

        'Modificado en Prueba 2014
        lndias = DateDiff(DateInterval.Day, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))
        lnmeses = Math.Ceiling(lndias / 30)
        'lnmeses = DateDiff(DateInterval.Month, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))
        'ds = ecreditos.ListadoCreditosxGrupoSugerencia(cbxgrupos.Value.Trim)

        ds = ecreditos.Extrae_Resolucion_Usuario(cbxgrupos.Value.Trim)

        For Each fila As DataRow In ds.Tables(0).Rows
            lcFrecuencia = omtabttab.Describe(fila("cfrecint"), "060")
        Next

        Dim lnmiembros As Integer = 0
        lnmiembros = ds.Tables(0).Rows.Count

        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If ds.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        crRpt1.Load(Server.MapPath("reportes") + "\crAprGrupal.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt1.SetDataSource(ds.Tables(0))

        crRpt1.Refresh()
        crRpt1.SetParameterValue("pcmeses", lnmeses.ToString)
        crRpt1.SetParameterValue("pcfrecuencia", lcFrecuencia)
        crRpt1.SetParameterValue("pctasa", ViewState("pctasa"))
        crRpt1.SetParameterValue("pcComite", Me.CbxUsuario_Comite1.SelectedItem.Text.Trim)
        rptStream1 = CType(crRpt1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True

        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

    End Sub

#End Region

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'No deja selecionar la linea de credito
        cbxLineas.Enabled = False
        'Introducir aquí el código de usuario para inicializar la página

        If Not IsPostBack Then
            Me.CargaVariables()
            Me.CargarDatos()
            Me.Label11.Visible = False
            Me.Label11.Text = ""
        Else
            Me.txtgarantias.Text = Session("nGrav")
        End If

    End Sub

    Private Sub IgualaDatos()

        pcCodCta = Me.txtCredito.Text
        Dim dsCre As New DataSet
        Dim eCremcre As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab
        Dim lcdestino As String

        dsCre = eCremcre.Resumen(Me.txtCredito.Text.Trim)
        If dsCre.Tables(0).Rows.Count = 0 Then
            lcdestino = "CAPITAL DE TRABAJO"
        Else
            lcdestino = etabttab.Describe(dsCre.Tables(0).Rows(0)("cdescre"), "005")

        End If

        Dim lnTasa As Double
        Dim ds As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        Dim lccodlin As String
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        'lnTasa = entidadCretlin.ntasint
        lnTasa = Double.Parse(txttasa.Text)
        ViewState("pctasmor") = entidadCretlin.ntasmor.ToString
        ViewState("pctasa") = Math.Round(lnTasa, 2).ToString
        ViewState("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        ViewState("pnmonsug") = Me.txtmonSug.Text

        If Me.txtmonSug.Text <= 5000 Then
            ViewState("pccomite1") = "X"
            ViewState("pccomite2") = ""
        Else
            ViewState("pccomite2") = "X"
            ViewState("pccomite1") = ""
        End If
        '>>>>>>>>>>>>>>>>>>>>>>
        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.txtcCodCli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clase.lsegvid = eclimide.lsegvida

        Dim entidadcreditos As New creditos
        entidadcreditos.ccodcta = Me.txtCredito.Text.Trim
        eCremcre.Obtenercreditos(entidadcreditos)
        clase.nMeses = clase.PlazoMeses(IIf(IsDBNull(entidadcreditos.dfecvig), Session("gdfecsis"), entidadcreditos.dfecvig), _
                                        IIf(IsDBNull(entidadcreditos.dfecven), Session("gdfecsis"), entidadcreditos.dfecven))
        'localiza fuente de fondos en base a cCodlin
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        lccodlin = entidadCretlin.ccodlin
        Dim clstabttab As New cTabttab
        Dim ds033 As New DataSet
        Dim lcfondos As String
        Dim nelemf As Integer
        lcfondos = lccodlin.ToString.Substring(2, 2).Trim
        ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos)
        nelemf = ds033.Tables(0).Rows.Count
        If nelemf = 0 Then
            ViewState("pcfuente") = ""
        Else
            ViewState("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        ViewState("pcnomchq") = entidadCredchq.cnomchq
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState("pdfecha") = Date.Parse(Me.txtFecDes.Text)
        '        Me.txtfecpri.Text = Today.AddMonths(1)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)

        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtnMonApr.Text 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        'clase.cCodFor = lnTipCuo
        ' clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        'clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        'clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = Me.txtcflat.Text.Trim

        If txtbandera.Text.Trim = "1" Then
            clase.cCodRec = cbxrechazo.Value.Trim
        End If


        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = pcCodCta
        clase.cCodFor = Me.txtcTipPer.Text
        clase.cTipCuo = Me.txtcTipCuo.Text
        clase.nPerDia = Me.txtnperdia.Text
        clase.nDiaGra = Me.txtndiaGra.Text
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        If clase.cCodFor = "2" Then
            clase.nPerDia = Day(clase.dFecDes)
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        ViewState("pcnomcli") = Me.txtcNomcli.Text
        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        ViewState("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        ViewState("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        ViewState("pccanlet") = clsConvert.ConversionEnteros(Double.Parse(Me.txtmonSug.Text.Trim))
        lnDecimal = clsConvert.ExtraeDecimales(Me.txtmonSug.Text.Trim)
        ViewState("pccanlet") = ViewState("pccanlet") & " " & lnDecimal.ToString & "/100" & " QUETZALES"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dstipo As New DataSet
        Dim nelemgar As Integer
        Dim mcrepgar As New cCrepgar
        'dstipo = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        dstipo = clase.Garantizados(Me.txtcCodCli.Text.Trim)
        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            ViewState("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            ViewState("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            ViewState("pctipo") = "MIXTA"
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsclimgar As New cClimgar
        Dim dsgar As New DataSet
        Dim nelemg As Integer = 0
        Dim pcgar As String = ""
        Dim garant As String = ""

        dsgar = clsclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        nelemg = dsgar.Tables(0).Rows.Count
        If nelemg = 0 Then
            ViewState("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            ViewState("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim ds077 As New DataSet
        Dim lcdocu As String
        Dim nelemf1 As Integer
        lcdocu = Me.txtcontrato.Text
        ds077 = clstabttab.ObtenerDataSetPorID2("077", "1", lcdocu)
        nelemf = ds077.Tables(0).Rows.Count
        If nelemf1 = 0 Then
            ViewState("pccontrato") = ""
        Else
            ViewState("pccontrato") = ds077.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Me.Cargar_Gastos()
        Me.Meses()
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        'Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        'Me.txtCredito.Text = codigoCliente.Trim
        pcCodCta = codigoCliente
        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
    End Sub
    Public Sub CargarPlan(ByVal codigoCliente As String)
        Me.btnPlan_ServerClick(Me, New EventArgs)
    End Sub

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("WfBusLin.aspx")
        Me.txtMonSol.Text = ViewState("vnMonSol")
    End Sub

    Private Sub txtNomAna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomAna.TextChanged

    End Sub
    ''''Validando imprtante para el cambio de tasa interes del producto
    'Private Sub cbxLineas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLineas.SelectedIndexChanged
    '    CargaTasas()
    'End Sub
    Private Sub Imprimir()
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CRAprSol.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsPlanPago As New DataSet
        Dim entidadCremcre As New SIM.EL.cremcre
        Dim eCremcre As New SIM.BL.cCremcre
        entidadCremcre.ccodcta = Me.txtCredito.Text.Trim
        dsPlanPago = eCremcre.ObtenerDataSetPorIDAC(Me.txtCredito.Text.Trim)
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        CargarDatosCredito()
    End Sub

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
       
        Dim lverifica As Boolean
        Dim ecremcre As New cCremcre
        
        lverifica = ecremcre.VerificaConsistencias(cbxgrupos.Value.Trim)
        If lverifica = False Then
            'Response.Write("<script language='javascript'>alert('Inconsistencia Encontrada')</script>")
            codigoJs = "<script language='javascript'>alert('Inconsistencia Encontrada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        If txtacta.Text.Trim = "" Or txtresolucion.Text.Trim = "" Then
            'Response.Write("<script language='javascript'>alert('Verificar Nº Acta y/o Resolución')</script>")
            codigoJs = "<script language='javascript'>alert('Verificar Nº Acta y/o Resolución, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        GrabaDatosMiembro()
        GrabaAprobacionComite()
        'Dictamen()
    End Sub

    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick

        Dim llvalida As Boolean
        Dim mcremcre As New cCremcre
        Dim lnRetorno As Integer = 0
        Dim omtabttab As New cTabttab
        Dim ds_niveles As New DataSet
        Dim llvalida_comite As Boolean


        If Me.CbxUsuario_Comite1.Items.Count = 0 Then
            'codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
            '                                        "Advertencia SIM.NET ')</script>"
            'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, Advertencia SIM.NET')</script>")
            codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub

        End If


        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0
        Dim lcmonsug As String
        Dim lcnomcli As String
        Dim nmonto As TextBox
        Dim lnsumapr As Double = 0
        Dim lnmonto_apr As Double = 0
        Dim nliminf As Double = 0
        Dim nlimsup As Double = 0
        'Dim lnvalida_comite As Integer

        'Actualiza nivel de comite aunque no tenga autorizacion

        Dim dsCretlin As DataSet
        Dim cClimide As New cClimide
        Dim lineaCredito As String

        lineaCredito = Me.cbxLineas.SelectedItem.Text.ToString()



        For xy = 0 To Me.Datagrid1.Items.Count - 1
            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcnomcli = Me.Datagrid1.Items(xy).Cells(1).Text

            lcmonsug = Me.Datagrid1.Items(xy).Cells(6).Text
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            lnmonsug = Double.Parse(nmonto.Text)
            lnsumapr += lnmonsug

            'Cesar Alejandro Torres 16/04/2016
            '*************Validar que los montos solicitados esten dentro del  rango del producto ****************
            dsCretlin = cClimide.ValidarRangoProducto(lccodcta, lnmonsug)
            nliminf = dsCretlin.Tables(0).Rows(0)("nliminf")
            nlimsup = dsCretlin.Tables(0).Rows(0)("nlimsup")

            If lnmonsug >= nliminf And lnmonsug <= nlimsup Then
                lnRetorno = mcremcre.Actualiza_Usuario_Nivel_Comite(Me.CbxUsuario_Comite1.SelectedValue.Trim, _
                                                        Session("gnIdusuario"), lccodcta)
            Else
                codigoJs = "<script language='javascript'>alert('El monto solicitado para: " & lcnomcli & _
                           "\nEstá fuera del rango de la linea de crédito: " & lineaCredito & " \nMonto solicitado: " & lnmonsug & _
                           "\nRango: Entre " & nliminf & "  y  " & nlimsup & "')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.btnGrabar.Disabled = True
                Exit Sub
            End If

            '*************Validar que los montos solicitados esten dentro del  rango del producto ****************



            

            If lnRetorno = 0 Then
                'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Advertencia SIM.NET')</script>")
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                       "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

        Next

        For xy = 0 To Me.Datagrid1.Items.Count - 1
            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcnomcli = Me.Datagrid1.Items(xy).Cells(1).Text

            lcmonsug = Me.Datagrid1.Items(xy).Cells(6).Text
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            lnmonsug = Double.Parse(nmonto.Text)
            lnsumapr += lnmonsug

            llvalida = clase.Valida_Monto_Comite(Me.CbxUsuario_Comite1.SelectedValue.Trim, lnmonsug)


            If Not llvalida Then
                Me.btnGrabar.Disabled = True
                'codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
                '                                        "Advertencia SIM.NET ')</script>"
                'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


                'Response.Write("<script language='javascript'>alert('El Usuario no tiene Autorizacion, Pedir Autorización, Advertencia SIM.NET')</script>")
                codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion, Pedir Autorización, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Exit Sub
            End If


            'Verifica que todos los niveles de comite esten cubiertos
            llvalida_comite = omtabttab.Valida_Niveles_Aprobacion(lnmonsug, lccodcta)
            If Not llvalida_comite Then
                'Response.Write("<script language='javascript'>alert('No se completaron todos los niveles de Firmas, Verifique, Advertencia SIM.NET')</script>")
                codigoJs = "<script language='javascript'>alert('No se completaron todos los niveles de Firmas, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

            'Me.IgualaDatosaGrabar(lccodcta, lnmonsug)
            'Me.GeneraPlandepagos(lccodcta, lnmonsug)

            If GeneraPlandepagos(lccodcta, lnmonsug) = 0 Then
                codigoJs = "<script language='javascript'>alert('Producto Mal Generado, Capital Negativo, Verifique " & _
                            "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.btnGrabar.Disabled = True
                Exit Sub
            End If
        Next
        Me.txtnMonApr.Text = lnsumapr



        'llvalida = clase.Valida_Monto_Comite(Me.CbxUsuario_Comite1.SelectedValue.Trim, lnsumapr)

        'If Not llvalida Then
        '    Me.btnGrabar.Disabled = True
        '    'codigoJs = "<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, " & _
        '    '                                        "Advertencia SIM.NET ')</script>"
        '    'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Response.Write("<script language='javascript'>alert('El Usuario no tiene Autorizacion para Aprobar este Monto, Advertencia SIM.NET')</script>")
        '    Exit Sub
        'End If

        ViewState("pncuota") = utilNumeros.Redondear(clase.pnmonCuo, 2)
        Session.Item("CodigoCre") = pcCodCta
        Me.txtnMonApr.Enabled = False
        Me.txtFecDes.Enabled = False
        txttasa.Enabled = False
        Me.txtfecpri.Enabled = False
        Me.btnGrabar.Disabled = False
        Me.Button1.Disabled = False
        Me.btnPlan.Disabled = True
        Me.FormaPago()

        'Dim lcvalida As String
        'lcvalida = Me.validalinea()
        'If lcvalida = "0" Then
        '    Me.btnGrabar.Disabled = True
        '    Response.Write("<script language='javascript'>alert('Linea Iválida')</script>")
        '    Return
        'Else
        '    Me.btnGrabar.Disabled = False
        'End If

    End Sub

    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick

        'Validando si esta la liena en Selecione un Linea..
        'If cbxLineas.SelectedIndex = 0 Then
        '    'Response.Write("<script language='javascript'>alert('Fecha de Desembolso  no puede ser menor a fecha de sistema')</script>")
        '    codigoJs = "<script language='javascript'>alert(' Debe Seleccionar una Linea de Credito Valida " & _
        '               "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Exit Sub
        'End If


        Me.txtnMonApr.Enabled = True
        Me.txtFecDes.Enabled = True
        'txttasa.Enabled = True

        Me.txtfecpri.Enabled = True
        'If Me.txtcCodCli.Text.Trim = "" Then
        '    Me.btnPlan.Disabled = True
        'Else
        Me.btnPlan.Disabled = False
        btnGrabar.Disabled = True

        Dim lccodcta As String
        Dim lcnomcli As String
        Dim lnmonsug As Double

        Dim cClimide As New cClimide
        Dim nliminf As Double
        Dim nlimsup As Double
        Dim lineaCredito As String
        Dim dsCretlin As DataSet


        lineaCredito = Me.cbxLineas.SelectedItem.Text.ToString()

        Dim nmonto As TextBox
        For xy = 0 To Me.Datagrid1.Items.Count - 1
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)


            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcnomcli = Me.Datagrid1.Items(xy).Cells(1).Text
            ' nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)
            lnmonsug = Double.Parse(nmonto.Text) 'Double.Parse(lcmonsug.Replace("Q", ""))

            'Cesar Alejandro Torres 16/04/2016
            '*************Validar que los montos solicitados esten dentro del  rango del producto ****************
            dsCretlin = cClimide.ValidarRangoProducto(lccodcta, lnmonsug)
            nliminf = dsCretlin.Tables(0).Rows(0)("nliminf")
            nlimsup = dsCretlin.Tables(0).Rows(0)("nlimsup")

            If lnmonsug >= nliminf And lnmonsug <= nlimsup Then
                nmonto.Enabled = True
            Else
                codigoJs = "<script language='javascript'>alert('El monto solicitado para: " & lcnomcli & _
                           "\nEstá fuera del rango de la linea de crédito: " & lineaCredito & " \nMonto solicitado: " & lnmonsug & _
                           "\nRango: Entre " & nliminf & "  y  " & nlimsup & "')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.btnGrabar.Disabled = True
                Exit Sub
            End If

            '*************Validar que los montos solicitados esten dentro del  rango del producto ****************

        Next

        'End If
    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        txtbandera.Text = "1"
        Label15.Visible = True
        cbxrechazo.Visible = True
    End Sub
    Private Sub CargaVariables()
        ViewState.Add("pcnomcli", "") 'nombre de cliente
        ViewState.Add("pcdestino", "") 'destino
        ViewState.Add("pcdeslin", "") 'nombre de linea
        ViewState.Add("pctippre", "") ' tipo de credito
        ViewState.Add("pcfuente", "") 'fuente de fondos
        ViewState.Add("pctasa", "") 'tasa de interes
        ViewState.Add("pcagencia", "") 'agencia
        ViewState.Add("pnmonsug", 0) 'monto sugerido
        ViewState.Add("pctasmor", "") ' tasa moratoria
        ViewState.Add("pcmeses", "") 'meses
        ViewState.Add("pcnomchq", "") ' Cheque a nombre de 
        ViewState.Add("pdfecha", Today()) ' fecha de desembolso
        ViewState.Add("pcgarantia", "") 'Garantias
        ViewState.Add("pccanLet", "") ' cantidad en letras
        ViewState.Add("pncuota", 0) 'cuota sugerida
        ViewState.Add("pctipo", "") 'tipo de garantia
        ViewState.Add("pcforpag", "") ' forma de pago
        ViewState.Add("pcnomana", "") ' nombre de analista
        ViewState.Add("pccontrato", "") 'tipo de contrato
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState.Add("pcComite1", "") 'comite de credito nivel 1
        ViewState.Add("pcComite2", "") 'comite de credito nivel 2
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ' comisiones '
        ViewState.Add("pncom1", 0)
        ViewState.Add("pccom1", "")

        ViewState.Add("pncom2", 0)
        ViewState.Add("pccom2", "")

        ViewState.Add("pncom3", 0)
        ViewState.Add("pccom3", "")

        ViewState.Add("pncom4", 0)
        ViewState.Add("pccom4", "")

        ViewState.Add("pncom5", 0)
        ViewState.Add("pccom5", "")

        ViewState.Add("pncom6", 0)
        ViewState.Add("pccom6", "")
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState.Add("pndeuda", 0) 'valor a refinanciar
        ViewState.Add("pccreref", "") 'credito a ser refinanciado
    End Sub
    Private Sub ImprimirIA()
        Dim dsgarantias As New DataSet
        Dim mclimgar As New cClimgar
        Try

            dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        Catch ex As Exception

        End Try

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim reportes As String
        reportes = "CrPreIA.pdf"

        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRptIA.Load(Server.MapPath("reportes") + "\CrPreAprobado.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRptIA.SetDataSource(dsgarantias.Tables(0))
        crRptIA.Refresh()

        Dim pccodcta1 As String
        Dim pccodcli1 As String
        Dim pcnomana1 As String

        pccodcta1 = pcCodCta
        pccodcli1 = Me.txtcCodCli.Text.Trim
        pcnomana1 = Me.txtNomAna.Text.Trim

        crRptIA.SetParameterValue("lcnomcli", ViewState("pcnomcli"))
        crRptIA.SetParameterValue("lcdestino", ViewState("pcdestino"))
        crRptIA.SetParameterValue("lcdeslin", ViewState("pcdeslin"))
        crRptIA.SetParameterValue("lctippre", ViewState("pctippre"))
        crRptIA.SetParameterValue("lcfondos", ViewState("pcfuente"))
        crRptIA.SetParameterValue("lctasa", ViewState("pctasa"))
        crRptIA.SetParameterValue("lcagencia", ViewState("pcagencia"))
        crRptIA.SetParameterValue("lnmonsug", ViewState("pnmonsug"))
        crRptIA.SetParameterValue("lctasmor", ViewState("pctasmor"))
        crRptIA.SetParameterValue("lcmeses", lnmeses.ToString)
        crRptIA.SetParameterValue("lcnomchq", ViewState("pcnomchq"))
        crRptIA.SetParameterValue("ldfecha", ViewState("pdfecha"))
        crRptIA.SetParameterValue("lcgarantia", "") 'poner suma de garantias
        crRptIA.SetParameterValue("lccanlet", ViewState("pccanlet"))
        crRptIA.SetParameterValue("lncuosug", ViewState("pncuota"))
        crRptIA.SetParameterValue("lctipo", ViewState("pctipo"))
        crRptIA.SetParameterValue("lcforpag", ViewState("pcforpag"))
        crRptIA.SetParameterValue("lccodcta", pccodcta1)
        crRptIA.SetParameterValue("lccodcli", pccodcli1)
        crRptIA.SetParameterValue("lcnomana", pcnomana1)
        crRptIA.SetParameterValue("lccontrato", ViewState("pccontrato"))
        crRptIA.SetParameterValue("lccomite1", ViewState("pccomite1"))
        crRptIA.SetParameterValue("lccomite2", ViewState("pccomite2"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRptIA.SetParameterValue("lncom1", ViewState("pncom1"))
        crRptIA.SetParameterValue("lccom1", ViewState("pccom1"))

        crRptIA.SetParameterValue("lncom2", ViewState("pncom2"))
        crRptIA.SetParameterValue("lccom2", ViewState("pccom2"))

        crRptIA.SetParameterValue("lncom3", ViewState("pncom3"))
        crRptIA.SetParameterValue("lccom3", ViewState("pccom3"))

        crRptIA.SetParameterValue("lncom4", ViewState("pncom4"))
        crRptIA.SetParameterValue("lccom4", ViewState("pccom4"))

        crRptIA.SetParameterValue("lncom5", ViewState("pncom5"))
        crRptIA.SetParameterValue("lccom5", ViewState("pccom5"))

        crRptIA.SetParameterValue("lncom6", ViewState("pncom6"))
        crRptIA.SetParameterValue("lccom6", ViewState("pccom6"))

        crRptIA.SetParameterValue("lndeuda", ViewState("pndeuda"))
        crRptIA.SetParameterValue("lccreref", ViewState("pccreref"))

        rptStreamIA = CType(crRptIA.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStreamIA.ToArray())
        'Response.End()
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStreamIA.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    End Sub
    Private Sub Cargar_Gastos()
        Dim xy As Integer
        Dim xydata As New DataSet
        Dim clscredgas As New cCredgas
        Dim lctipgas As String
        Dim lngasto As Double
        xydata = clscredgas.ObtenerDataSetPorID2(pcCodCta, "D")
        xy = xydata.Tables(0).Rows.Count
        If xy = 0 Then

        Else
            xy = 0
            Dim Filaxy As DataRow
            For Each Filaxy In xydata.Tables(0).Rows
                lctipgas = xydata.Tables(0).Rows(xy)("ctipgas")
                lngasto = xydata.Tables(0).Rows(xy)("nmongas")
                If lctipgas = "01" And lngasto <> 0 Then
                    ViewState("pncom1") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom1") = "X"
                ElseIf lctipgas = "03" And lngasto <> 0 Then
                    ViewState("pncom2") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom2") = "X"
                ElseIf lctipgas = "04" And lngasto <> 0 Then
                    ViewState("pncom3") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom3") = "X"
                ElseIf lctipgas = "PR" And lngasto <> 0 Then
                    ViewState("pncom4") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom4") = "X"
                ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
                    ViewState("pncom5") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom5") = "X"
                ElseIf lctipgas = "02" And lngasto <> 0 Then
                    ViewState("pncom6") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom6") = "X"
                End If
                xy += 1
            Next
        End If
        refina()
    End Sub
    Private Sub refina()
        Dim dscancela As New DataSet
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela
        dscancela = ecancela.ObtenerDataSetPorCuenta(pcCodCta)

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim e As Double
        Dim deuda As Double
        Dim deuda1 As Double
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim pcref1 As String
        Dim pcref As String
        If dscancela.Tables(0).Rows.Count = 0 Then
            ViewState("pndeuda") = 0
            ViewState("pccreref") = ""
        Else
            For Each fila In dscancela.Tables(0).Rows
                a = dscancela.Tables(0).Rows(nelem)("nsalcap")
                b = dscancela.Tables(0).Rows(nelem)("nsalint")
                c = dscancela.Tables(0).Rows(nelem)("nsalmor")
                d = dscancela.Tables(0).Rows(nelem)("nmanejo")
                e = dscancela.Tables(0).Rows(nelem)("nseguro")
                deuda1 = a + b + c + d + e
                deuda = deuda + deuda1
                pcref1 = dscancela.Tables(0).Rows(nelem)("ccodcta")
                pcref = pcref + IIf(nelem = 0, "", ", ") + pcref1
                nelem += 1
            Next
            ViewState("pndeuda") = deuda
            ViewState("pccreref") = pcref
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


    End Sub
    Private Sub FormaPago()
        Dim lcforma As String
        If lctipper = "2" Then  'Fecha Fija
            lcforma = "MENSUALES"
        Else 'Periodo Fijo
            If lndiasug = 1 Then
                lcforma = "DIARIAS"
            ElseIf lndiasug = 7 Or lndiasug = 8 Then
                lcforma = "SEMANALES"
            ElseIf lndiasug = 14 Or lndiasug = 15 Then
                lcforma = "QUINCENALES"
            ElseIf lndiasug >= 28 And lndiasug <= 31 Then
                lcforma = "MENSUALES"
            ElseIf lndiasug = 60 Then
                lcforma = "BIMENSUALES"
            ElseIf lndiasug = 90 Then
                lcforma = "TRIMESTRALES"
            ElseIf lndiasug = 120 Then
                lcforma = "CADA CUATRO MESES"
            ElseIf lndiasug = 180 Then
                lcforma = "SEMESTRALES"
            ElseIf lndiasug >= 360 And lndiasug <= 365 Then
                lcforma = "ANUALES"
            Else
                lcforma = "NO DEFINIDO"
            End If
        End If

        ViewState("pcforpag") = Me.pnCuoSug.Text.ToString & " CUOTAS " & lcforma & " de $" & clase.pnmonCuo.ToString & " c/u. que comprende capital, intereses , seguro de deuda y comisiones por administración"
        If lndiasug = 1 Then
            ViewState("pcforpag") = "una cuota al vencimientode $ " & clase.pnmonCuo.ToString & " c/u. que comprende capital, intereses , seguro de deuda y comisiones por administración"
        End If
    End Sub
    Private Sub Meses()
        If lctipper = "1" Then 'Periodo Fijo
            Select Case lndiasug
                Case lndiasug = 7
                    lnmeses = CInt(Me.pnCuoSug.Text / 4)
                Case lndiasug = 14
                    lnmeses = CInt(Me.pnCuoSug.Text / 2)
                Case lndiasug = 15
                    lnmeses = CInt(Me.pnCuoSug.Text / 2)
                Case lndiasug = 30
                    lnmeses = CInt(Me.pnCuoSug.Text)
                Case lndiasug = 31
                    lnmeses = CInt(Me.pnCuoSug.Text)
                Case lndiasug = 60
                    lnmeses = CInt(Me.pnCuoSug.Text * 2)
                Case lndiasug = 90
                    lnmeses = CInt(Me.pnCuoSug.Text * 3)
                Case lndiasug = 120
                    lnmeses = CInt(Me.pnCuoSug.Text * 4)
                Case lndiasug = 360
                    lnmeses = CInt(Me.pnCuoSug.Text * 12)
                Case lndiasug = 365
                    lnmeses = CInt(Me.pnCuoSug.Text * 12)
                Case Else
                    lnmeses = Me.pnCuoSug.Text
            End Select
        Else 'Fecha Fija
            lnmeses = Me.pnCuoSug.Text
        End If
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub GrabaDatosMiembro()
        Dim lvalida As Boolean = True

        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0
        Dim lcmonsug As String


        Dim chkCptoAsig As CheckBox
        Dim lopcion As Boolean
        Dim nmonto As TextBox

        For xy = 0 To Me.Datagrid1.Items.Count - 1
            'chkCptoAsig = CType(Me.Datagrid1.Items(xy).FindControl("CheckBox2"), CheckBox)
            'lopcion = chkCptoAsig.Checked

            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcmonsug = Me.Datagrid1.Items(xy).Cells(3).Text
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            lnmonsug = Double.Parse(nmonto.Text)
            Me.IgualaDatosaGrabar(lccodcta, lnmonsug)

            lvalida = clase.ValidaLinea(Me.cbxLineas.SelectedValue, lnmonsug, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))
            If lvalida = False Then
                Exit For
            Else
                'Me.GeneraPlandepagos(lccodcta, lnmonsug)
                GrabarClick()

            End If

        Next
        If lvalida = False Then
            'Response.Write("<script language='javascript'>alert('Linea Invalida, Verificar Plazo y/o Monto')</script>")
            codigoJs = "<script language='javascript'>alert('Linea Invalida, Verificar Plazo y/o Monto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        Else
            'Response.Write("<script language='javascript'>alert('Aprobación Grabada')</script>")
            codigoJs = "<script language='javascript'>alert('Aprobación Grabada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If

    End Sub
    Private Sub IgualaDatosaGrabar(ByVal lccodcta As String, ByVal lnmonsug As Double)
        pcCodCta = lccodcta
        Dim dsCre As New DataSet
        Dim eCremcre As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab
        Dim lcdestino As String

        dsCre = eCremcre.Resumen(Me.txtCredito.Text.Trim)
        If dsCre.Tables(0).Rows.Count = 0 Then
            lcdestino = "CAPITAL DE TRABAJO"
        Else
            lcdestino = etabttab.Describe(dsCre.Tables(0).Rows(0)("cdescre"), "005")

        End If

        Dim lnTasa As Double
        Dim ds As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        Dim lccodlin As String
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        'lnTasa = entidadCretlin.ntasint
        lnTasa = Double.Parse(txttasa.Text)
        ViewState("pctasmor") = entidadCretlin.ntasmor.ToString
        ViewState("pctasa") = Math.Round(lnTasa, 2).ToString
        ViewState("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        ViewState("pnmonsug") = lnmonsug
        clase.lliva = entidadCretlin.lliva
        If lnmonsug <= 5000 Then
            ViewState("pccomite1") = "X"
            ViewState("pccomite2") = ""
        Else
            ViewState("pccomite2") = "X"
            ViewState("pccomite1") = ""
        End If
        '>>>>>>>>>>>>>>>>>>>>>>
        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.txtcCodCli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clase.lsegvid = eclimide.lsegvida

        Dim entidadcreditos As New creditos
        entidadcreditos.ccodcta = Me.txtCredito.Text.Trim
        eCremcre.Obtenercreditos(entidadcreditos)
        clase.nMeses = clase.PlazoMeses(IIf(IsDBNull(entidadcreditos.dfecvig), Session("gdfecsis"), entidadcreditos.dfecvig), _
                                        IIf(IsDBNull(entidadcreditos.dfecven), Session("gdfecsis"), entidadcreditos.dfecven))
        'localiza fuente de fondos en base a cCodlin
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        lccodlin = entidadCretlin.ccodlin
        Dim clstabttab As New cTabttab
        Dim ds033 As New DataSet
        Dim lcfondos As String
        Dim nelemf As Integer
        lcfondos = lccodlin.ToString.Substring(2, 2).Trim
        ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos)
        nelemf = ds033.Tables(0).Rows.Count
        If nelemf = 0 Then
            ViewState("pcfuente") = ""
        Else
            ViewState("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        ViewState("pcnomchq") = entidadCredchq.cnomchq
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState("pdfecha") = Date.Parse(Me.txtFecDes.Text)
        '        Me.txtfecpri.Text = Today.AddMonths(1)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)

        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = lnmonsug 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        'clase.cCodFor = lnTipCuo
        ' clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        'clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        'clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = Me.txtcflat.Text.Trim

        If txtbandera.Text.Trim = "1" Then
            clase.cCodRec = cbxrechazo.Value.Trim
        End If

        clase.cCodfue = Me.cbxprograma.SelectedValue.Trim

        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = pcCodCta
        clase.cCodFor = Me.txtcTipPer.Text
        clase.cTipCuo = Me.txtcTipCuo.Text
        'clase.nPerDia = Me.txtnperdia.Text
        clase.nPerDia = clase.periodo(Me.txtcfrecint.Text.Trim)
        clase.nDiaGra = Me.txtndiaGra.Text
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        If clase.cCodFor = "2" Then
            clase.nPerDia = Day(clase.dFecDes)
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        ViewState("pcnomcli") = Me.txtcNomcli.Text
        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        ViewState("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        ViewState("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        ViewState("pccanlet") = clsConvert.ConversionEnteros(lnmonsug)
        lnDecimal = clsConvert.ExtraeDecimales(lnmonsug)
        ViewState("pccanlet") = ViewState("pccanlet") & " " & lnDecimal.ToString & "/100" & " QUETZALES"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dstipo As New DataSet
        Dim nelemgar As Integer
        Dim mcrepgar As New cCrepgar
        'dstipo = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        dstipo = clase.Garantizados(Me.txtcCodCli.Text.Trim)
        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            ViewState("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            ViewState("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            ViewState("pctipo") = "MIXTA"
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsclimgar As New cClimgar
        Dim dsgar As New DataSet
        Dim nelemg As Integer = 0
        Dim pcgar As String = ""
        Dim garant As String = ""

        dsgar = clsclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        nelemg = dsgar.Tables(0).Rows.Count
        If nelemg = 0 Then
            ViewState("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            ViewState("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim ds077 As New DataSet
        Dim lcdocu As String
        Dim nelemf1 As Integer
        lcdocu = Me.txtcontrato.Text
        ds077 = clstabttab.ObtenerDataSetPorID2("077", "1", lcdocu)
        nelemf = ds077.Tables(0).Rows.Count
        If nelemf1 = 0 Then
            ViewState("pccontrato") = ""
        Else
            ViewState("pccontrato") = ds077.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        clase.cacta = txtacta.Text.Trim
        clase.cresolucion = txtresolucion.Text.Trim

        Me.Cargar_Gastos()
        Me.Meses()
    End Sub

    Private Sub GrabarClick()
        Dim eclimgar As New cClimgar
        Dim lnvalidapref As Integer
        lnvalidapref = eclimgar.ValidaGarantiaPref(Me.txtcCodCli.Text.Trim)

        Me.txtgarantias.Text = Session("nGrav") 'clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        'Validaciones
        'If lnvalidapref = 1 Then

        'Else
        '    If Double.Parse(Me.txtnMonApr.Text) > Double.Parse(Me.txtgarantias.Text) And Me.txtccodsol.Text.Trim = "" Then
        '        Me.Label11.Visible = True
        '        Me.Label11.Text = "Monto Aprobado es mayor que garantía"
        '        Exit Sub
        '    Else
        '        Me.Label11.Visible = False
        '        Me.Label11.Text = ""
        '    End If
        'End If

        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)
        clase.dFecApr = Session("gdFecSis")
        clase.pcCodUsu = Session("gccodusu")
        clase.gnmoncuo = ViewState("pncuota")
        clase.lsegvid = 0
        clase.nNroCuo0 = 0
        clase.codigo_nivel_aprobacion = Me.CbxUsuario_Comite1.SelectedValue.Trim
        clase.usuario_aprobacion = Session("gnIdusuario")

        'Dim lcaux As String = ""
        'lcaux = clase.ObtenerCodigoGarantia(Me.txtCredito.Text.Trim)

        clase.Graba_Aprobacion("E")

        Label15.Visible = False
        cbxrechazo.Visible = False
        If txtbandera.Text.Trim = "1" Then
            'Response.Write("<script language='javascript'>alert('Solicitud Rechazada')</script>")
            codigoJs = "<script language='javascript'>alert('Solicitud Rechazada, " & _
             "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        Else
            'ImprimirIA()
            'Response.Write("<script language='javascript'>alert('PRE-Aprobación Grabada')</script>")
        End If

    End Sub

    Private Function GeneraPlandepagos(ByVal p_ccodcta As String, ByVal p_nmonsug As Double) As Integer
        Dim dsplain As New DataSet
        Dim lnRetorno As Integer = 1

        IgualaDatosaGrabar(p_ccodcta, p_nmonsug)
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        clase.pcCodUsu = Session("gcCodUsu")
        clase.dFecsis = Session("gdFecSis")

        clase.cfreccap = Me.txtcfreccap.Text.Trim
        clase.cfrecint = Me.txtcfrecint.Text.Trim
        clase.pniva = Session("gnIVA")

        clase.ngastos1 = 0
        clase.nNroCuo0 = 0

        'dsplain = clase.fxCreatePlain(-1, 0)
        dsplain = clase.fxCreatePlain(-1, Double.Parse(Me.txtnmoncuo.Text))

        'Valida que el plan no venga negativo, si no se hizo un buen analisis de la cuota - monto - plazo - tasa, especial MEXICO
        If Double.Parse(Me.txtnmoncuo.Text) > 0 Then
            For Each fila As DataRow In dsplain.Tables(0).Rows
                If fila("nCapita") < 0 Then
                    lnRetorno = 0
                    Exit Function
                End If
            Next
        End If

        Dim nCanti3 As Integer
        nCanti3 = dsplain.Tables(0).Rows.Count()
        clase.PlanTeorico(dsplain.Tables(0), pcCodCta)
        Me.txtdFecVen.Text = clase.dFecVen.ToString
        clase.pcTabGasx.Clear()
        clase.pcTabGasx.Tables.Clear()
        'Me.txtdFecVen.Text = clase.dFecVen.ToString
        'ViewState("pncuota") = utilNumeros.Redondear(clase.pnmonCuo, 2)
        'Session.Item("CodigoCre") = pcCodCta

        'Me.FormaPago()

        Return lnRetorno
    End Function

    Protected Sub cbxprograma_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxprograma.SelectedIndexChanged
        CargaLineasxFondos(Me.cbxprograma.SelectedValue)
    End Sub
    Private Sub CargaLineasxFondos(ByVal cCodfue As String)
        Dim ds As New DataSet
        Dim clscretlin As New cCretlin

        ds = clscretlin.RecuperarporFuente(cCodfue, Me.txtCredito.Text.Trim.Substring(6, 2))

        If ds.Tables(0).Rows.Count = 0 Then
            Me.cbxLineas.Enabled = False
            Me.btnPlan.Disabled = True
            Return
        Else
            ''''
            '08072015
            '*Cambio a false estaba en true
            Me.cbxLineas.Enabled = False
            Me.btnPlan.Disabled = False
        End If

        'Dim fila2 As Data.DataRow
        'fila2 = ds.Tables("table").NewRow
        'fila2("cdeslin") = "Seleccione una linea..."
        ''Me.ds.Tables("table").Rows.Add(fila)
        'ds.Tables(0).Rows.InsertAt(fila2, 0)


        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()


    End Sub

    Private Sub Dictamen()
        Dim lccodcli As String = ""
        Dim lcnomcli As String = ""
        Dim lcdirdom As String = ""
        Dim lccapacidad As String = ""
        Dim lcanalisis As String = ""
        Dim lcdepartamento As String = ""
        Dim lcmunicipio As String = ""
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon
        Dim lccoddom As String = ""
        Dim lcsexo As String = ""
        Dim lcsexo1 As String = ""
        Dim lcactividad As String = ""
        Dim lccodact As String = ""
        Dim lcsector As String = ""
        Dim lnmeses As Integer = 0

        Dim i As Integer = 0
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab
        Dim reportes As String = ""
        Dim ecremsol As New cCremsol
        Dim lnmonsol As Double = 0

        Dim ds As New DataSet
        ds = ecreditos.ListadoCreditosxGrupoAprobar(cbxgrupos.Value.Trim)

        Dim ds1 As New DataSet
        Dim lnmiembros As Integer = 0
        lnmiembros = ds.Tables(0).Rows.Count

        Dim lccodcta As String = ""
        Dim eclimgar As New cClimgar

        Dim lctipogar As String = ""
        Dim lnmontas As Double = 0
        Dim lnmongra As Double = 0


        Dim fila As DataRow
        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("ccodcta")
            lccodcli = fila("ccodcli")
            lnmonsol = lnmonsol + fila("nmonapr")

            'obtener garantias
            ds1 = eclimgar.ObtenerDataSetGravamen(lccodcli, lccodcta)
            If ds1.Tables(0).Rows.Count = 0 Then
            Else
                If IsDBNull(ds1.Tables(0).Rows(0)("ctipdes")) Then
                Else
                    fila("ctipogar") = etabttab.Describe(ds1.Tables(0).Rows(0)("ctipdes"), "044")
                End If
                fila("nmontas") = ds1.Tables(0).Rows(0)("nmontas")
                fila("nmongra") = ds1.Tables(0).Rows(0)("nmongra")
                fila("cnotario") = ds1.Tables(0).Rows(0)("cnotario")
            End If
        Next

        entidad3.ccodcta = lccodcta
        i = ecreditos.Obtenercreditos(entidad3)

        lccodcli = lccodcli
        lcnomcli = ecremsol.ObtenerNombre(Me.cbxgrupos.Value.Trim)



        lccapacidad = IIf(IsDBNull(entidad3.ccapacidad), "", entidad3.ccapacidad.Trim)
        lcanalisis = IIf(IsDBNull(entidad3.canalisis), "", entidad3.canalisis.Trim)
        lcsexo = IIf(entidad3.csexo.Trim = "M", "X", "")
        lcsexo1 = IIf(entidad3.csexo.Trim = "M", " ", "X")

        lnmeses = entidad3.nmeses

        Dim entidadcremsol As New cremsol
        entidadcremsol.cCodsol = cbxgrupos.Value.Trim
        ecremsol.ObtenerCremsol(entidadcremsol)

        Dim eciiu As New cTabtciu
        Dim lcdestino As String

        lcsector = etabttab.Describe(entidad3.csececo, "021")
        If IsDBNull(entidad3.cdescre) Then
            entidad3.cdescre = ""
        End If
        lcdestino = etabttab.Describe(entidad3.cdescre, "005")
        lccodact = entidad3.ccodact
        lcactividad = eciiu.CIIU(lccodact)


        lccoddom = entidadcremsol.cCodzon
        lcdirdom = entidadcremsol.cdirdom.Trim




        'obtiene municipio y departamento
        If lccoddom.Trim = "" Then
        Else
            etabtzon.ccodzon = lccoddom.Substring(0, 4)
            etabtzon.ctipzon = "2"
            mtabtzon.ObtenerTabtzon(etabtzon)
            lcmunicipio = etabtzon.cdeszon.Trim
            lcmunicipio = lcmunicipio.ToUpper
            'departamento
            etabtzon.ccodzon = lccoddom.Substring(0, 2)
            etabtzon.ctipzon = "1"
            mtabtzon.ObtenerTabtzon(etabtzon)
            lcdepartamento = etabtzon.cdeszon.Trim
            lcdepartamento = lcdepartamento.ToUpper
        End If
        Dim lcfreccap As String = ""
        Dim lcopcion1, lcopcion2, lcopcion3, lcopcion4 As String


        lcfreccap = entidad3.cfreccap.Trim

        If lcfreccap = "M" Then 'mensual
            lcopcion1 = "X"
            lcopcion2 = ""
            lcopcion3 = ""
            lcopcion4 = ""
        ElseIf lcfreccap = "I" Then 'bimensual
            lcopcion1 = ""
            lcopcion2 = "X"
            lcopcion3 = ""
            lcopcion4 = ""

        ElseIf lcfreccap = "T" Then 'trimestral
            lcopcion1 = ""
            lcopcion2 = ""
            lcopcion3 = "X"
            lcopcion4 = ""
        Else
            lcopcion4 = "X"
            If lcfreccap = "C" Then
                lcopcion4 = "Cuatrimestral"
            ElseIf lcfreccap = "A" Then
                lcopcion4 = "Vencimiento"
            ElseIf lcfreccap = "E" Then
                lcopcion4 = "Semestral"
            End If
            lcopcion1 = ""
            lcopcion2 = ""
            lcopcion3 = ""

        End If

        Dim ldfecha As Date
        Dim lnmes As Integer
        Dim lcmes As String
        Dim lndia As Integer
        Dim lcdias As String
        Dim lnano As Integer
        Dim lcanio As String


        ldfecha = Session("gdfecsis")
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcanio = lnano.ToString.Trim
        lcmes = clase.MES(lnmes)
        lcdias = lndia.ToString.Trim

        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If i = 0 Then
            Exit Sub


        End If
        reportes = "crAutorizag.doc"
        crRpt1.Load(Server.MapPath("reportes") + "\crAutorizag.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt1.SetDataSource(ds.Tables(0))

        crRpt1.Refresh()
        crRpt1.SetParameterValue("cnomcli", lcnomcli)
        crRpt1.SetParameterValue("cdirdom", lcdirdom)
        'crRpt1.SetParameterValue("ccapacidad", lccapacidad)
        'crRpt1.SetParameterValue("canalisis", lcanalisis)
        crRpt1.SetParameterValue("cdepartamento", lcdepartamento)
        crRpt1.SetParameterValue("cmunicipio", lcmunicipio)
        crRpt1.SetParameterValue("csexo", lcsexo)
        crRpt1.SetParameterValue("csexo1", lcsexo1)
        crRpt1.SetParameterValue("cactividad", lcsector.Trim & ", " & lcactividad)
        crRpt1.SetParameterValue("cdestino", lcdestino)
        crRpt1.SetParameterValue("cusuarios", lnmiembros)
        crRpt1.SetParameterValue("nmonsol", lnmonsol)
        crRpt1.SetParameterValue("pcopcion1", lcopcion1)
        crRpt1.SetParameterValue("pcopcion2", lcopcion2)
        crRpt1.SetParameterValue("pcopcion3", lcopcion3)
        crRpt1.SetParameterValue("pcopcion4", lcopcion4)
        crRpt1.SetParameterValue("ctasa", ViewState("pctasa"))
        crRpt1.SetParameterValue("cdia", lcdias)
        crRpt1.SetParameterValue("cmes", lcmes)
        crRpt1.SetParameterValue("canio", lcanio)
        crRpt1.SetParameterValue("cfondos", ViewState("pcfuente"))
        crRpt1.SetParameterValue("cmeses", ((lnmeses).ToString.Trim & " meses"))

        ' crRpt1.SetParameterValue("cnomana", Me.txtNomAna.Text.Trim)


        rptStream1 = CType(crRpt1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True

        ' Establece el tipo de documento
        Response.ContentType = "application/msword"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub
    Private Sub CargaTasas()
        Dim ecretlin As New cCretlin
        txttasa.Text = ecretlin.ObtenerTasaEstandar(cbxLineas.SelectedValue.Trim)
        HiddenField2.Value = ecretlin.ObtenerTasaMinima(cbxLineas.SelectedValue.Trim)
        HiddenField3.Value = ecretlin.ObtenerTasaMaxima(cbxLineas.SelectedValue.Trim)
        HiddenField4.Value = txttasa.Text
    End Sub

    Private Sub CargarOficina()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        Dim ds As New DataSet
        ds = etabtofi.ObtenerOficinasdeRegion(cbxCodIns.SelectedValue.Trim, Session("gccodofi"), Session("gnNivel"))
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            btnGrabar.Disabled = True
            Exit Sub
        Else
            btnGrabar.Disabled = False
        End If

        Me.cbxcodofi.DataTextField = "cNomOfi"
        Me.cbxcodofi.DataValueField = "cCodOfi"
        Me.cbxcodofi.DataSource = ds.Tables(0)
        Me.cbxcodofi.DataBind()


        ds.Tables(0).Clear()
    End Sub

    Protected Sub CbxUsuario_Comite1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxUsuario_Comite1.SelectedIndexChanged
    End Sub
End Class
