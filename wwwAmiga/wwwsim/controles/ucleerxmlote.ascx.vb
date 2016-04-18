

Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports System.Environment
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System

Partial Class ucleerxmlote
    Inherits ucWBase
   
#Region " Variables "
    Dim cls1 As New SIM.BL.pagdesver
    Private cls2 As New SIM.BL.ClsMantenimiento
    Private clsConvert As New SIM.BL.ConversionLetras
    Dim clsaplica As New SIM.BL.payment
    Dim ecremcre As New cCremcre
    Dim pncomper As Double = 0
    Dim pnsegdeu As Double = 0
    Dim dsnopagos As New DataSet
    Dim ecremsol As New cCremsol

    Private clase As New SIM.BL.class1
    Private cls_Sim As New SIM.BL.ClsSolicitud


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
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
    Private codigoJs As String
    Dim dsimprimepagos As New DataSet

#End Region


    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)

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
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.txtflat.Text = ""
            Dim ldfecsis As Date
            ldfecsis = Session("gdfecsis")
            Me.txtfecbar.Text = ldfecsis
            Me.comprobante()
            Me.cargarcombos()
            Me.Deshabilitar()


            '            Me.archivodetexto.Attributes.Add("onclick", "funcionclick")
        End If

    End Sub
    Private Sub comprobante()
        'Dim etabtvar As New tabtvar
        'Dim mtabtvar As New cTabtvar
        Dim lccomprobante As String
        Dim etabtofi As New cTabtofi
        lccomprobante = etabtofi.ObtieneCorrelativo(Session("gcCodofi"))
        Label45.Text = Session("gccodofi")
        'etabtvar.cnomvar = "GNCORRELA"
        'etabtvar.ccodapl = "CRE"
        'mtabtvar.ObtenerTabtvar(etabtvar)
        'lncomprobante = Double.Parse(etabtvar.cconvar) + 1

        'Me.txtcompro.Text = lncomprobante.ToString.Trim
        Me.txtcompro0.Text = lccomprobante 'lncomprobante.ToString.Trim
    End Sub
    Private Sub Deshabilitar()


    End Sub
    Private Sub cargarcombos()
        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1' order by CNOMgru "
        Transacc = cls2.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls2.ResulSelect(Transacc)
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


        ds.Tables(0).Clear()
        ' carga combo bancos
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        clsbancos.ObtenerDatasetporid(dsb, Session("gcCodofi"))
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()

        'carga combo tipo de pago
        Dim clstabttab As New SIM.BL.cTabttab
        Dim dsp As New DataSet
        clstabttab.ObtenerDataSetPorID(dsp)
        Me.cmbtippag.DataTextField = "cdescri"
        Me.cmbtippag.DataValueField = "ccodigo"
        Me.cmbtippag.DataSource = dsp.Tables(0)
        Me.cmbtippag.DataBind()
        Me.cmbtippag.SelectedValue = "E"
        Me.cmbtippag.Items.RemoveAt(Me.cmbtippag.Items.IndexOf(Me.cmbtippag.Items.FindByValue("I")))

        Dim objTabtOfi As New cTabtofi

        Dim tieneEfectivo As Boolean

        tieneEfectivo = True 'objTabtOfi.ObtenerPagoEfectivo(Session("gcCodofi"))

        If tieneEfectivo = True Then
            Me.cmbtippag.Enabled = True
        Else
            Me.cmbtippag.Enabled = False
        End If



        Me.txtInteres.Text = 0
        Me.txtmora.Text = 0

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Me.txtcCodsol.Text = codigoCliente.Trim
        Dim lcnomgru As String
        lcnomgru = ecremsol.ObtenerNombre(codigoCliente.Trim)
        Me.cbxgrupos.Value = codigoCliente.Trim

        'Me.sumatotales()


        ecremcre.EliminaTablaPagos(Me.txtcCodsol.Text.Trim)
        txtcnumrec.Text = ""

        Dim ecredkar As New cCredkar
        Dim lprocede As Boolean
        Dim eusuario As New cusuarios
        'lngrupo = eusuariogrupo.RetornaGrupo(Session("gccodusu"))

        'If lngrupo = 2 Then
        lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "A")
        If lprocede = True Then
            Response.Write("<script language='javascript'>alert('Verifique no hay caja abierta')</script>")
            Return
        End If
        'End If
        lprocede = eusuario.ValidaCuentaCajero(Session("gccodusu"))
        If lprocede = False Then
            Response.Write("<script language='javascript'>alert('Asignar Cuenta Contable al Cajero')</script>")
            Return
        End If

        Dim etabtofi As New cTabtofi
        Dim lccomprobante0 As String
        lccomprobante0 = etabtofi.ObtieneCorrelativo(Session("gcCodofi"))
        txtcompro.Text = lccomprobante0

        Me.CargaSocias()
    End Sub
    Sub cmEdit(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        Datagrid1.EditItemIndex = CInt(e.Item.ItemIndex)
        Datagrid1.DataSource = Me.Datos
        Datagrid1.DataBind()
    End Sub
    Sub cmUpdate(ByVal sender As Object, ByVal e As DataGridCommandEventArgs)
        'Datagrid1.EditItemIndex = -1
        'Dim indice As Integer
        'Dim ds As New DataSet
        'Dim dsupdate As New DataSet
        'Dim fila As DataRow
        'Dim i As Integer = 0
        'ds = Me.Datos
        'indice = e.Item.DataSetIndex
        ''Dim id As Integer
        ''id = Datagrid1.DataKeys(CInt(e.Item.ItemIndex))

        'Dim CurrentTextBox As TextBox
        'CurrentTextBox = e.Item.FindControl("textbox4")

        'Dim ColValue As String = CurrentTextBox.Text




        ''For Each fila In ds.Tables(0).Rows
        'ds.Tables(0).Rows(indice)("npago") = Me.Datagrid1.Items(indice).Cells(4).Text

        ''i += 1
        ''Next


        'Datagrid1.DataSource = ds
        'Datagrid1.EditItemIndex = -1
        Datagrid1.DataBind()
    End Sub
    Private Function Datos() As DataSet
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim ecredppg As New cCredppg
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lncuota As Double = 0
        ds = ecremcre.ObtenerSocia(Me.txtccomodin.Text.Trim)
        For Each fila In ds.Tables(0).Rows
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i)("codigo"))
            ds.Tables(0).Rows(i)("ncuota") = lncuota
            ds.Tables(0).Rows(i)("npago") = lncuota
            ds.Tables(0).Rows(i)("lsolidario") = False
            i += 1
        Next
        Return ds
    End Function
    Private Sub CargaSocias()
        Dim ecremcre As New cCremcre
        Dim ecredppg As New cCredppg
        Dim ecredkar As New cCredkar

        Me.txtmora.Text = 0
        Me.txtInteres.Text = 0

        Me.txtfecult.Text = ecredkar.UltimafechaProcesoGrupal(Me.txtcCodsol.Text.Trim)


        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lncuota As Double = 0
        Dim lndeuda As Double = 0
        ds = ecremcre.ObtenerSocias(Me.txtcCodsol.Text.Trim)
        Me.txtsocias.Text = ds.Tables(0).Rows.Count
        Dim lnaaplicar As Double = 0
        Dim lcflat As String = ""
        For Each fila In ds.Tables(0).Rows
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i)("codigo"))
            lcflat = ds.Tables(0).Rows(i)("cflat")
            If Me.CheckBox2.Checked = True Then
                lndeuda = DeudaAldiaCancelacion(ds.Tables(0).Rows(i)("codigo"))
                ds.Tables(0).Rows(i)("npago") = lndeuda
                lnaaplicar = lnaaplicar + lndeuda
            Else
                lndeuda = DeudaAldia(ds.Tables(0).Rows(i)("codigo"))
                ds.Tables(0).Rows(i)("npago") = lncuota
                lnaaplicar = lnaaplicar + lncuota
            End If

            ds.Tables(0).Rows(i)("ncuota") = lncuota

            ds.Tables(0).Rows(i)("lsolidario") = False
            ds.Tables(0).Rows(i)("ndeuda") = lndeuda

            ecremcre.InsertaTablaPagos(ds.Tables(0).Rows(i)("codigo"), ds.Tables(0).Rows(i)("cnomcli"), lncuota, ds.Tables(0).Rows(i)("npago"), False, lndeuda, Me.txtcCodsol.Text.Trim)
            i += 1
        Next
        Me.txtaaplicar.Text = lnaaplicar
        Me.datagrid1.DataSource = ds.Tables(0)
        Me.datagrid1.Columns(0).Visible = False
        Me.datagrid1.Columns(6).Visible = False
        Me.datagrid1.Columns(7).Visible = False

        Me.datagrid1.DataBind()

        If lcflat.Trim = "F" Then
            Me.txtflat.Text = "F"
        Else
            Me.txtflat.Text = ""
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dsClientes As New DataSet
        '        Dim lcnombre As String
        '        lcnombre = "../wwwsim/xml/people.xml"
        '        dsClientes.ReadXml(Server.MapPath(lcnombre))
        '        Me.DataGrid1.DataSource = dsClientes.Tables(0)
        '        Me.DataGrid1.DataBind()

        '        Dim dsEmpleados As New DataSet
        '        dsEmpleados.ReadXml(Server.MapPath(lcnombre), XmlReadMode.InferSchema)
        '        Me.DataGrid2.DataSource = dsEmpleados.Tables(0)
        '        Me.DataGrid2.DataBind()

        '        Dim dsPeople As New DataSet
        '        dsPeople.ReadXml(Server.MapPath(lcnombre))
        '        Me.DataGrid3.DataSource = dsPeople.Tables(0)
        '        Me.DataGrid3.DataBind()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '        Dim dsdatos As New DataSet
        '        Dim lcnombre As String
        '        lcnombre = "\xml\people.XML"
        '        dsdatos.ReadXmlSchema(GetFolderPath(SpecialFolder.Personal) & lcnombre)

        '       dsdatos.ReadXml(GetFolderPath(SpecialFolder.Personal) & lcnombre)
        '       Dim xmlData As New XmlDataDocument(dsdatos)
        '       dgDatos.DataSource = xmlData.DataSet.Tables(0)
        '       dgDatos.DataBind()

        'Productos
        '        Dim vRel As String = dsdatos.Relations(0).RelationName
        '        Dim vPrimero As String = dgDatos.Items.Item(0).Cells(0).Text
        '        Dim mitabla As DataTable = dsdatos.Tables(1)
        '        Dim mifiltro As String = "Categoryid = '" & vPrimero & "'"
        '        Dim miorden As String = "ProductId ASC"
        '        'Crear la Vista
        '        Dim dvVista As New DataView(mitabla, mifiltro, miorden, DataViewRowState.CurrentRows)

        '        dgProductos.DataSource = dvVista 'dsdatos.Tables(0).Rows(0).GetChildRows(vRel) 'xmlData.DataSet.Tables(1)
        '        dgProductos.DataBind()

    End Sub

    Private Sub imprime_recibo()

        Try
            If dsnopagos Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsnopagos.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        crRpt.Load(Server.MapPath("reportes") + "\crnopagos.rpt", OpenReportMethod.OpenReportByDefault)

        crRpt.SetDataSource(dsnopagos.Tables(0))
        '        crRpt.SetParameterValue("parametroPrueba", "PRUEBA")

        Dim lcnomgru As String = ""
        Dim ecremsol As New cCremsol
        lcnomgru = ecremsol.ObtenerNombre(cbxgrupos.Value.Trim)

        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        ldfecha1 = Date.Parse(Me.txtfecbar.Text)
        ldfecha2 = Date.Parse(Me.txtfecbar.Text)

        crRpt.SetDataSource(dsnopagos.Tables(0))
        crRpt.SetParameterValue("oficina", "Todas las oficinas")
        crRpt.SetParameterValue("analista", "Todos los analistas")
        crRpt.SetParameterValue("estrato", "Todas las carteras")
        crRpt.SetParameterValue("linea", "Todas las líneas")
        crRpt.SetParameterValue("dfecha1", ldfecha1)
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("cnomofi", lcnomgru.Trim) 'Session("gcnomofi")
        'crRpt.SetParameterValue("cproductos", "")
        Dim reportes As String
        reportes = "crnopagos.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.End()



    End Sub


    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Private Sub archivodetexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Public Function evaluar()
        Dim respuesta As Integer
        respuesta = MsgBox("Seguro continuar", MsgBoxStyle.YesNo, "Aviso")
    End Function


    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        ecremcre.ActualizaTablaPagos(Me.txtccomodin.Text.Trim, Double.Parse(Me.txtnpago.Text), Me.CheckBox1.Checked, Me.txtcCodsol.Text.Trim)
        Me.txtnpago.Text = 0
        Me.CheckBox1.Checked = False
        Dim ds As New DataSet
        ds = ecremcre.ObtenerTablaPagos(Me.txtcCodsol.Text.Trim)
        Me.datagrid1.DataSource = ds
        Me.datagrid1.DataBind()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnaaplicar As Double = 0
        For Each fila In ds.Tables(0).Rows
            lnaaplicar = lnaaplicar + ds.Tables(0).Rows(i)("npago")
            i += 1
        Next
        Me.txtaaplicar.Text = lnaaplicar
    End Sub
    Private Sub imprimeRecibos()
        Dim dspagosATM As New DataSet
        Dim eautopag As New cAutopag
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim ecreditos As New ccreditos
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lccodcta As String
        Dim ldfecpag As Date
        Dim lcnomcli As String
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ldfecha1 = Date.Parse(Me.txtfecbar.Text)
        ldfecha2 = Date.Parse(Me.txtfecbar.Text)
        dspagosATM = eautopag.RecibosATM(ldfecha1, ldfecha2)
        If dspagosATM.Tables(0).Rows.Count = 0 Then
            Return
        End If
        Dim pccanlet As String
        Dim pnpago As Double
        Dim lnDecimal As Double
        Dim pccantlet1 As String
        Dim pccodcta As String
        Dim pdultpag As Date
        Dim ldfecval As Date
        Dim pccodlin As String
        Dim entidadcretlin As New cretlin
        Dim ecretlin As New cCretlin
        Dim etabttab As New cTabttab
        Dim ecredkar As New cCredkar
        Dim pcprograma As String
        Dim pncapdes As Double
        Dim pnsaldoant As Double
        Dim pnsaldo As Double
        Dim pncappag As Double = 0
        Dim pncapita As Double = 0
        Dim pncuota As Double = 0

        For Each fila In dspagosATM.Tables(0).Rows
            pnpago = dspagosATM.Tables(0).Rows(nelem)("npago")
            pccantlet1 = clsConvert.ConversionEnteros(pnpago)
            lnDecimal = clsConvert.ExtraeDecimales(pnpago)
            pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " QUETZALES"
            dspagosATM.Tables(0).Rows(nelem)("ccanlet") = pccantlet1
            dspagosATM.Tables(0).Rows(nelem)("cnomofi") = Session("gcnomofi")
            pccodcta = dspagosATM.Tables(0).Rows(nelem)("ccodcta")
            pdultpag = ecreditos.Ultimopago(pccodcta, ldfecha1)
            dspagosATM.Tables(0).Rows(nelem)("dultpag") = pdultpag
            ldfecval = dspagosATM.Tables(0).Rows(nelem)("dfecpro")
            dspagosATM.Tables(0).Rows(nelem)("dfecha") = ldfecha1
            dspagosATM.Tables(0).Rows(nelem)("dfecha") = ldfecval

            entidadcretlin.cnrolin = dspagosATM.Tables(0).Rows(nelem)("cnrolin")
            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
            pccodlin = entidadcretlin.ccodlin

            pcprograma = etabttab.Describe(pccodlin.Substring(2, 2), "033").Trim
            dspagosATM.Tables(0).Rows(nelem)("cprograma") = pcprograma

            pncappag = ecredkar.CapitalPagado(pccodcta, ldfecha1)
            pncapdes = dspagosATM.Tables(0).Rows(nelem)("ncapdes")
            pncapita = dspagosATM.Tables(0).Rows(nelem)("ncapita")
            pnsaldoant = pncapdes - pncappag
            pnsaldo = pncapdes - pncappag - pncapita

            dspagosATM.Tables(0).Rows(nelem)("nsalant") = pncapdes - pncappag
            dspagosATM.Tables(0).Rows(nelem)("nsaldo") = pnsaldo
            pncuota = MontoCuota(pccodcta, dspagosATM, nelem)
            dspagosATM.Tables(0).Rows(nelem)("nmoncuo") = pncuota
            nelem += 1
        Next

        Try
            If dspagosATM Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dspagosATM.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        crRpt.Load(Server.MapPath("reportes") + "\crpagosATM.rpt", OpenReportMethod.OpenReportByDefault)

        crRpt.SetDataSource(dspagosATM.Tables(0))
        Dim reportes As String
        reportes = "crpagosATM.pdf"


        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

        'Response.End()

    End Sub
    Private Function MontoCuota(ByVal ccodcta As String, ByVal dskar As DataSet, ByVal i As Integer) As Double
        Dim clase As New class1
        Dim pncuota As Double
        clase.cNrolin = dskar.Tables(0).Rows(i)("cnrolin")
        clase.nMonDes = dskar.Tables(0).Rows(i)("ncapdes")
        clase.cCodFor = dskar.Tables(0).Rows(i)("ctipper")
        clase.nPerDia = dskar.Tables(0).Rows(i)("ndiaapr")
        clase.gnperbas = Session("gnPerbas")
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm")
        clase.OtrosGastos()
        pncomper = utilNumeros.Redondear(clase.pnComPer, 2)
        pnsegdeu = utilNumeros.Redondear(clase.pnSegDeu, 2)

        Dim entidadcredppg As New credppg
        Dim ecredppg As New cCredppg


        entidadcredppg.ccodcta = dskar.Tables(0).Rows(i)("ccodcta")
        entidadcredppg.ctipope = "N"
        entidadcredppg.cnrocuo = "001"

        ecredppg.Recuperar(entidadcredppg)
        Dim pncapita As Double = 0
        Dim pnintere As Double = 0
        pncapita = utilNumeros.Redondear(entidadcredppg.ncapita, 2)
        pnintere = utilNumeros.Redondear(entidadcredppg.nintere, 2)
        pncuota = pncapita + pnintere + pncomper + pnsegdeu
        Return pncuota
    End Function


    Private Sub Imprime_Recibo_Grupal()
        Dim dsrecibo As New DataSet
        Dim ecremsol As New cCremsol
        dsrecibo = ecremsol.ReciboGrupal(Me.txtcCodsol.Text.Trim)

        Dim lccodins As String
        Dim lccodofi As String
        Dim lccodcta As String = ""
        Dim ldfecha As Date
        Dim lccomprobante As String
        Dim lccomprobante0 As String
        Dim lctipo As String = ""
        Dim clskardex As New ckardex
        Dim lcnumrec As String = Me.txtcompro0.Text.Trim


        Dim fila As DataRow
        Dim i As Integer = 0
        Dim dsprint As New DataSet
        dsprint = dsnopagos
        lctipo = ""
        lccomprobante = Me.txtcompro.Text.Trim

        If reimpresion.Checked = True Then
            lccomprobante0 = Session("gccodofi") & Me.txtcnumrec.Text.Trim
        Else
            lccomprobante0 = Session("gccodofi") & Me.txtcompro.Text.Trim
        End If


        'If Me.cmbtippag.SelectedItem.Value.Trim = "E" Then
        '    lccomprobante = lccomprobante0
        'End If

        ldfecha = Date.Parse(Me.txtfecbar.Text)
        Dim fila1 As DataRow
        Dim pnkp1 As Double = 0
        Dim pnin1 As Double = 0
        Dim pnmo1 As Double = 0
        Dim pnop1 As Double = 0
        Dim pn041 As Double = 0
        Dim pnotro1 As Double = 0
        Dim pntotal1 As Double = 0
        Dim pcconcep As String = "  "
        Dim pnmonto As Double = 0
        Dim nCanti As Integer = 0
        Dim pniva1 As Double = 0

        Dim lctippag As String = ""
        Dim lcformapago As String = ""
        Dim lnflag As Integer
        Dim etabttab As New cTabttab

        Dim xy As Integer = 0
        For xy = 0 To Me.datagrid1.Items.Count - 1
            lccodcta = Me.datagrid1.Items(xy).Cells(7).Text.Trim 'dsprint.Tables(0).Rows(i)("cCodcta")
            lccodins = lccodcta.Substring(0, 3)
            lccodofi = lccodcta.Substring(3, 3)
            'dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante, " ", lccomprobante0)
            dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante0, " ")
            nCanti = 0

            For Each fila1 In dsimprimepagos.Tables(0).Rows
                lctippag = dsimprimepagos.Tables(0).Rows(nCanti)("ctippag")
                If lctippag.Trim <> "D" And lnflag = 0 Then 'No aplica cuando es tipo de pago con documento
                    lcformapago = etabttab.Describe(lctippag.Trim, "146").Trim
                    lnflag = 1
                End If

                pcconcep = dsimprimepagos.Tables(0).Rows(nCanti)("cconcep")
                pnmonto = utilNumeros.Redondear(dsimprimepagos.Tables(0).Rows(nCanti)("nmonto"), 2)
                lcnumrec = dsimprimepagos.Tables(0).Rows(nCanti)("cnumrec")
                If pcconcep = "KP" Then
                    pnkp1 = pnkp1 + pnmonto
                ElseIf pcconcep = "IN" Then
                    pnin1 = pnin1 + pnmonto
                ElseIf pcconcep = "MO" Then
                    pnmo1 = pnmo1 + pnmonto
                ElseIf pcconcep = "05" Then
                    pnop1 = pnop1 + pnmonto
                ElseIf pcconcep = "03" Then
                    pn041 = pn041 + pnmonto
                ElseIf pcconcep = "08" Then
                    pniva1 = pniva1 + pnmonto
                ElseIf pcconcep = "CJ" Then
                    pntotal1 = pntotal1 + pnmonto

                Else
                    pnotro1 = pnotro1 + pnmonto
                End If
                nCanti = nCanti + 1
            Next
            i += 1
        Next
        
        Dim pntotal2 As Double = 0
        Dim lnretencion As Double = 0

        'If lretencion = True Then
        '    lnretencion = Math.Round(((pnin1 + pnmo1) * Session("gnRetencion") / 100), 2)
        'Else
        '    lnretencion = 0
        'End If
        pntotal2 = pntotal1 - lnretencion

        '----Descargamos data set en variables----'
        Dim lnDecimal As Double
        Dim pccantlet1 As String

        pccantlet1 = ConversionLetras.ConversionEnteros(pntotal1)
        lnDecimal = clsConvert.ExtraeDecimales(pntotal1)
        pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " QUETZALES"

        Dim lcnomofi As String = ""
        Dim ldfecsis As Date
        Dim lnsaldo1 As Double = 0
        Dim saldoant As Double = 0
        Dim lnsaldo2 As Double = 0

        '>>>>>>>>>>>>>>>>CARGA DATOS DE GRUPO PARA RECIBO<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim ecremcre As New cCremcre
        Dim ecredppg As New cCredppg

        Dim ds As New DataSet
        Dim fila2 As DataRow
        Dim i2 As Integer = 0
        Dim lncuota As Double = 0
        ds = ecremcre.ObtenerSocias(Me.txtcCodsol.Text.Trim)
        Dim lnaaplicar As Double = 0
        Dim ldfecvig As Date = Session("gdfecsis")
        Dim ldfecven As Date = Session("gdfecsis")
        Dim lcnomana As String = ""


        Dim dssaldo As New DataSet
        Dim ecreditos As New ccreditos
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        Dim lndes As Double = 0
        Dim lnpag As Double = 0
        Dim lccodlin As String = ""
        Dim etabtofi As New cTabtofi
        For Each fila2 In ds.Tables(0).Rows

            lccodcta = ds.Tables(0).Rows(i2)("codigo")

            lccodlin = ds.Tables(0).Rows(i2)("cCodlin")
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i2)("codigo"))
            ds.Tables(0).Rows(i2)("ncuota") = lncuota
            ds.Tables(0).Rows(i2)("lsolidario") = False
            ldfecvig = ds.Tables(0).Rows(i2)("dfecvig")
            ldfecven = ds.Tables(0).Rows(i2)("dfecven")
            lcnomana = ds.Tables(0).Rows(i2)("cnomusu")
            lnaaplicar = lnaaplicar + lncuota

            dssaldo = ecreditos.SaldoxCuenta(lccodcta, Session("gdfecsis"))
            If dssaldo.Tables(0).Rows.Count = 0 Then
                lndes = 0
                lnpag = 0
            Else
                lndes = dssaldo.Tables(0).Rows(0)("nCapdes")
                lnpag = dssaldo.Tables(0).Rows(0)("ncappag")
            End If
            lncapdes = lncapdes + lndes
            lncappag = lncappag + lnpag

            i2 += 1
        Next

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        Dim lcfuente As String = ""
        If lccodlin.Trim = "" Then
        Else
            lcfuente = etabttab.Describe(lccodlin.Substring(2, 2), "033").Trim
        End If

        If lccodcta.Trim = "" Then
        Else

            Dim entidadcremcre As New cremcre
            Dim lcoficina As String

            entidadcremcre.ccodcta = lccodcta.Trim
            ecremcre.ObtenerCremcre(entidadcremcre)
            lcoficina = entidadcremcre.coficina
            lcnomofi = etabtofi.NombreAgencia(lcoficina)
        End If

        lnsaldo1 = lncapdes - lncappag

        saldoant = lncapdes - lncappag + pnkp1

        'Dim ecremsol As New cCremsol
        Dim lcnomcen As String = ""
        lcnomcen = ecremsol.ObtenerNombre(Me.txtcCodsol.Text.Trim)




        'lcnomofi = Session("gcnomofi")
        ldfecsis = Session("gdfecsis")
        '-----------------------------------------'
        Dim saldoanti As Double = 0
        Dim lnsaldoi1 As Double = 0

        Dim saldoantm As Double = 0
        Dim lnsaldom1 As Double = 0

        saldoanti = Double.Parse(Me.txtInteres.Text)
        lnsaldoi1 = saldoanti - pnin1
        If lnsaldoi1 < 0 Or lnsaldo1 <= 0 Then
            lnsaldoi1 = 0
        End If

        saldoantm = Double.Parse(Me.txtmora.Text)
        lnsaldom1 = saldoantm - pnmo1
        If lnsaldom1 < 0 Or lnsaldo1 <= 0 Then
            lnsaldom1 = 0
        End If

        Dim etabtusu As New cTabtusu
        Dim lcnomusu As String = ""
        'lcnomusu = etabtusu.usuario(Session("gcCodusu"))
        lcnomusu = Session("gcCodusu")
        '--------------------------------------------------------
        Dim elcremsol As New cremsol
        Dim mcremsol As New cCremsol
        Dim lccodcli As String = Me.cbxgrupos.Value
        Dim lccodzon As String = ""
        Dim lcaldea As String = ""

        elcremsol.cCodsol = lccodcli
        mcremsol.ObtenerCremsol(elcremsol)

        lccodzon = IIf(IsDBNull(elcremsol.cCodzon), "", elcremsol.cCodzon)

        Dim etabtzon As New cTabtzon


        lcaldea = etabtzon.Zona(lccodzon)

        Dim lcbanco As String = Me.cmbbanco.SelectedItem.Text
        Dim lcnuming As String
        'Dim lcnuming As String = Me.txtcompro.Text.Trim
        If Me.cmbtippag.SelectedItem.Value.Trim = "E" Then
            lcnuming = Me.txtcompro0.Text.Trim
        Else
            lcnuming = Me.txtcompro.Text.Trim
        End If


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crpagosGrupal.rpt", OpenReportMethod.OpenReportByDefault)
            '            crRpt.Load(Server.MapPath("reportes") + "\crpaggruold.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsrecibo.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("pnkp", pnkp1)
        crRpt.SetParameterValue("pnin", pnin1)
        crRpt.SetParameterValue("pnmo", pnmo1)
        crRpt.SetParameterValue("pnop", pnop1)
        crRpt.SetParameterValue("pn04", pn041)
        crRpt.SetParameterValue("pnotro", pnotro1)
        crRpt.SetParameterValue("pntotal", pntotal1)
        crRpt.SetParameterValue("pclugnac", lcnomofi)
        crRpt.SetParameterValue("pdfecsis", ldfecsis)
        crRpt.SetParameterValue("pccantlet", pccantlet1)

        crRpt.SetParameterValue("pcnomcen", lcnomcen)

        crRpt.SetParameterValue("pnmonotor", lncapdes)
        crRpt.SetParameterValue("pnsaldoant", saldoant)


        crRpt.SetParameterValue("pnmoncuo", lnaaplicar)
        crRpt.SetParameterValue("pdfecval", Date.Parse(Me.txtfecbar.Text))

        crRpt.SetParameterValue("pdfecoto", ldfecvig)
        crRpt.SetParameterValue("pdfecven", ldfecven)

        crRpt.SetParameterValue("pnsaldo", lnsaldo1)
        crRpt.SetParameterValue("pcnomana", lcnomana)
        crRpt.SetParameterValue("pctipo", lctipo.Trim)
        crRpt.SetParameterValue("pcprograma", lcfuente)

        crRpt.SetParameterValue("saldoanti", saldoanti)
        crRpt.SetParameterValue("saldoantm", saldoantm)

        crRpt.SetParameterValue("lnsaldoi1", lnsaldoi1)
        crRpt.SetParameterValue("lnsaldom1", lnsaldom1)

        crRpt.SetParameterValue("cnomusu", lcnomusu)
        crRpt.SetParameterValue("caldea", lcaldea)
        crRpt.SetParameterValue("cbanco", lcbanco)
        'crRpt.SetParameterValue("pcnumrec", lcnumrec)
        'crRpt.SetParameterValue("pcnuming", lcnuming)

        crRpt.SetParameterValue("pniva", pniva1)
        crRpt.SetParameterValue("ctelefono", "")
        crRpt.SetParameterValue("cnit", "")
        crRpt.SetParameterValue("nretencion", lnretencion)
        crRpt.SetParameterValue("pntotal2", pntotal2)
        crRpt.SetParameterValue("pcformapago", lcformapago)
        crRpt.SetParameterValue("pnmoracap", 0)
        crRpt.SetParameterValue("pcnumrec", lccomprobante0.Trim)

        Dim reportes As String
        'reportes = "crpagos.rpt"
        reportes = "crpagosgrupal.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.End()
    End Sub

    <System.Web.Services.WebMethodAttribute()> <System.Web.Script.Services.ScriptMethodAttribute()> Public Shared Function GetDynamicContent(ByVal contextKey As System.String) As System.String

    End Function

    Protected Sub datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagrid1.SelectedIndexChanged
        Dim ds As New DataSet
        ClienteSeleccionado = CType(Me.datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        Me.txtccomodin.Text = Me.ClienteSeleccionado
        ds = Datos()
        Me.txtnpago.Text = ds.Tables(0).Rows(0)("npago")
        Me.CheckBox1.Checked = ds.Tables(0).Rows(0)("lsolidario")
    End Sub
    Private Sub btnrecibo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.ServerClick
        Me.Imprime_Recibo_Grupal()
    End Sub
    
    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lnsocias As Integer = 0
        Dim lnvalor As Double = 0
        Dim lndistribuir As Double = 0
        lndistribuir = Double.Parse(Me.txtaaplicar0.Text.Trim)
        lnsocias = Integer.Parse(Me.txtsocias.Text)
        lnsocias = IIf(lnsocias = 0, 1, lnsocias)
        lnvalor = Math.Round(lndistribuir / lnsocias, 2)
        Dim lccodcta As String = ""
        Dim lncuota As Double = 0
        Dim lnpago As Double = 0
        Dim xy As Integer = 0
        Dim lnvaloraplica As Double = 0
        Dim lndifer As Double = 0


        Dim nmonto As TextBox


        If Me.RadioButton1.Checked = True Then 'Excedente

            For xy = 0 To Me.datagrid1.Items.Count - 1
                lccodcta = Me.datagrid1.Items(xy).Cells(7).Text.Trim
                nmonto = CType(Me.datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

                lncuota = Double.Parse(nmonto.Text)  'Me.datagrid1.Items(xy).Cells(4).Text.Trim
                lnpago = lncuota + lnvalor
                ecremcre.ActualizaTablaPagos(lccodcta, lnpago, False, Me.txtcCodsol.Text.Trim)
                lnvaloraplica = lnvaloraplica + lnvalor
            Next
            lndifer = Math.Round(lndistribuir - lnvaloraplica, 2)
            If lndifer <> 0 Then
                ecremcre.ActualizaTablaPagos(lccodcta, (lnpago + lndifer), False, Me.txtcCodsol.Text.Trim)
            End If



        Else
            For xy = 0 To Me.datagrid1.Items.Count - 1
                lccodcta = Me.datagrid1.Items(xy).Cells(7).Text.Trim
                nmonto = CType(Me.datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

                lncuota = Double.Parse(nmonto.Text) 'Me.datagrid1.Items(xy).Cells(4).Text.Trim
                lnpago = lncuota - lnvalor
                lnpago = IIf(lnpago < 0, 0, lnpago)
                ecremcre.ActualizaTablaPagos(lccodcta, lnpago, False, Me.txtcCodsol.Text.Trim)
                lnvaloraplica = lnvaloraplica + lnvalor
            Next
            lndifer = Math.Round(Double.Parse(Me.txtaaplicar0.Text.Trim)) - Math.Round(lnvaloraplica, 2)
            If lndifer <> 0 Then
                ecremcre.ActualizaTablaPagos(lccodcta, (lnpago - lndifer), False, Me.txtcCodsol.Text.Trim)
            End If

        End If


        Me.txtnpago.Text = 0
        Me.txtaaplicar0.Text = 0
        Me.CheckBox1.Checked = False
        Dim ds As New DataSet
        ds = ecremcre.ObtenerTablaPagos(Me.txtcCodsol.Text.Trim)
        Me.datagrid1.DataSource = ds
        Me.datagrid1.DataBind()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnaaplicar As Double = 0
        For Each fila In ds.Tables(0).Rows
            lnaaplicar = lnaaplicar + ds.Tables(0).Rows(i)("npago")
            i += 1
        Next
        Me.txtaaplicar.Text = lnaaplicar
    End Sub
    Private Function DeudaAldia(ByVal pccodcta As String) As Double
        Dim ldfecval As Date
        Dim ok As Integer
        Dim lndeuda As Double = 0
        Dim lndeucap As Double = 0
        Dim lnsalint As Double = 0
        Dim lnsalmor As Double = 0

        ldfecval = Date.Parse(Me.txtfecbar.Text.Trim)

        clsaplica.pccodcta = pccodcta
        clsaplica.pdfecval = ldfecval
        clsaplica.gdfecsis = ldfecval
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.gdultpag = #2/1/1970#
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.pcestado = "F"


        ok = clsaplica.omcalcinterest("T", ldfecval)


        'VALIDA SI EL CREDITO ES SANEADO NO DEBERIA DE COBRAR INTERESES NI MORA
        Dim eCremcre As New cremcre
        Dim objCremcre As New cCremcre
        eCremcre.ccodcta = clsaplica.pccodcta
        objCremcre.ObtenerCremcre(eCremcre)

        If eCremcre.ccondic = "S" Then
            'COLOCAR A CERO TODO MENOS EL CAPITAL
            clsaplica.pnsalint = 0
            clsaplica.pnsalmor = 0
            Me.CheckBox2.Enabled = False
        End If

        If eCremcre.cfreccap = "A" And eCremcre.cfrecint = "A" Then
            Me.CheckBox2.Enabled = False
        Else
            Me.CheckBox2.Enabled = True
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        If ok = 9 Then
            ok = 9
        Else
            If ok = 1 Then
                lndeucap = Math.Round(clsaplica.pndeucap, 2)
                lnsalint = Math.Round(clsaplica.pnsalint, 2)
                lnsalmor = Math.Round(clsaplica.pnsalmor, 2)

            End If

        End If

        lndeuda = Math.Round(lndeucap + lnsalint + lnsalmor, 2)

        Me.txtInteres.Text = lnsalint + Double.Parse(Me.txtInteres.Text)
        Me.txtmora.Text = lnsalmor + Double.Parse(Me.txtmora.Text)


        Return lndeuda

    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        If Date.Parse(txtfecbar.Text) > Session("gdfecsis") Then
            '            Response.Write("<script language='javascript'>alert('Fecha Valor no puede ser mayor a Fecha de Sistema')</script>")
            codigoJs = "<script language='javascript'>alert('Fecha Valor no puede ser mayor a Fecha de Sistema, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Exit Sub
        End If

        'verifica boleta de deposito
        Dim ecredkar As New cCredkar
        Dim lverifica As Boolean
        Dim ecntamov As New cCntamov
        Dim etabtbco As New cTabtbco

        'If Me.cmbtippag.SelectedItem.Value.Trim = "C" Then
        If Me.txtcompro.Text.Trim = "" Then
            '            Response.Write("<script language='javascript'>alert('Nº de Recibo Vacio')</script>")
            codigoJs = "<script language='javascript'>alert('Nº de Recibo Vacio, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        'End If

        If Date.Parse(Me.txtfecbar.Text) < Date.Parse(Me.txtfecult.Text) Then
            'Response.Write("<script language='javascript'>alert('Existe fecha posterior de pago')</script>")
            codigoJs = "<script language='javascript'>alert('Existe fecha posterior de pago, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If
        'lverifica = ecredkar.VerificaBoleta(Me.cmbbanco.SelectedValue.Trim, Me.txtcompro.Text.Trim)
        Dim lcctactb As String = ""
        'Dim eboletas As New cBOLETAS
        'lcctactb = etabtbco.CuentaContableBanco(Me.cmbbanco.SelectedValue.Trim)
        'lverifica = ecntamov.ValidaNumeroRemesa(lcctactb, Me.txtcompro.Text.Trim)
        'If Me.cmbtippag.SelectedItem.Value.Trim = "C" Then
        '    lverifica = eboletas.ValidaBoleta(Me.txtcompro.Text.Trim)

        '    If lverifica = False Then

        '        Response.Write("<script language='javascript'>alert('Boleta de Déposito ya Operada')</script>")
        '        Return
        '    End If

        'End If

        'crea el dataset donde depositara los pagos ya transformados
        Dim dstmp As New DataSet
        Dim drpagos As DataRow
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcpagos As New DataTable
        Dim clsprin As New class1
        Dim ldfecpag As Date
        Dim lccodofi As String
        Dim lnmonto As Double
        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        Dim lccodcli As String
        Dim dsclientes As New DataSet
        Dim lcnomcli As String
        Dim lccodcta As String
        Dim lcnombar As String
        Dim ldfecbar As Date
        Dim clspagdes As New cpagosauto 'pagdesver

        Dim mclimide As New cClimide
        Dim eclimide As New climide
        Dim eautopag As New autopag
        Dim mautopag As New cAutopag
        Dim filaauto As DataRow

        Dim lcflat As String
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim dsnop As New DataSet


        Dim etabtvar As New tabtvar
        Dim mtabtvar As New cTabtvar

        'revisara si ya fueron aplicados los pagos en dicha fecha
        ldfecha1 = Date.Parse(Me.txtfecbar.Text)
        ldfecha2 = Date.Parse(Me.txtfecbar.Text)

        Dim lcnuming As String = ""
        Dim lcnuming0 As String = ""
        lcnuming = Me.txtcompro0.Text.Trim 'Numero de deposito
        lcnuming0 = Me.txtcompro.Text.Trim 'Numero de recibo

        lcampos1 = "ccodcta, ccodcli, cnomcli, dfecpag, nmonto, ccodofi, cflag, cmotivo, cflat, lsol, cnuming, cnuming0,"
        ltipos1 = "S,S,S,F,D,S,S,S,S,B,S,S,"
        lcpagos = clsprin.creadatasetdesconec(lcampos1, ltipos1, "KARDEX1")

        lcnombar = Me.txtaaplicar.Text.Trim & ".txt"
        ldfecbar = Me.txtfecbar.Text.Trim


        Dim ds As New DataSet
        ds = ecremcre.ObtenerTablaPagos(Me.txtcCodsol.Text.Trim)
        Dim fila As DataRow
        Dim x As Integer = 0

        Dim lccadena As String = ""
        Dim lctipopag As String
        Dim contador As Integer = 1
        Dim llsol As Boolean

        Dim nmonto As TextBox

        For Each fila In ds.Tables(0).Rows
            nmonto = CType(Me.datagrid1.Items(x).FindControl("Textbox2"), TextBox)

            lccodcta = ds.Tables(0).Rows(x)("codigo")
            ldfecpag = Date.Parse(Me.txtfecbar.Text)
            lccodofi = lccodcta.Substring(3, 3)
            lnmonto = Double.Parse(nmonto.Text) 'ds.Tables(0).Rows(x)("npago")
            llsol = ds.Tables(0).Rows(x)("lsolidario")
            lctipopag = "C"

            'arma el codigo de cliente y credito si existe

            dsclientes = mcreditos.ObtenerDataSetPorcredito11(lccodcta)
            If dsclientes.Tables(0).Rows.Count <= 0 Then
                lcnomcli = " "
            End If

            If dsclientes.Tables(0).Rows.Count = 1 Then
                If dsclientes.Tables(0).Rows(0)("cestado") = "F" Then
                    lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                    lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                    lcflat = dsclientes.Tables(0).Rows(0)("cflat")

                    drpagos = lcpagos.NewRow()
                    drpagos("ccodcta") = lccodcta
                    drpagos("ccodcli") = lccodcli
                    drpagos("cnomcli") = lcnomcli
                    drpagos("dfecpag") = ldfecpag
                    drpagos("nmonto") = lnmonto
                    drpagos("ccodofi") = lccodofi
                    drpagos("cflat") = lcflat
                    drpagos("lsol") = llsol
                    drpagos("cnuming") = lcnuming
                    drpagos("cnuming0") = lcnuming0
                Else
                    'no se aplicaran los pagos, ya que tiene credito cancelado

                    lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                    lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")

                    lccodcta = ""
                    drpagos = lcpagos.NewRow()
                    drpagos("ccodcta") = ""
                    drpagos("ccodcli") = lccodcli
                    drpagos("cnomcli") = lcnomcli
                    drpagos("dfecpag") = ldfecpag
                    drpagos("nmonto") = lnmonto
                    drpagos("ccodofi") = lccodofi
                    drpagos("cflag") = "X"
                    drpagos("cmotivo") = "Crédito Cancelado"
                    drpagos("cflat") = ""
                    drpagos("lsol") = llsol
                    drpagos("cnuming") = lcnuming
                    drpagos("cnuming0") = lcnuming0
                End If

            Else
                'no se aplicaran los pagos, ya que tiene mas de un credito o esta cancelado
                lccodcta = ""

                drpagos = lcpagos.NewRow()
                drpagos("ccodcta") = ""
                drpagos("ccodcli") = lccodcli
                drpagos("cnomcli") = lcnomcli
                drpagos("dfecpag") = ldfecpag
                drpagos("nmonto") = lnmonto
                drpagos("ccodofi") = lccodofi
                drpagos("cflag") = "X"
                drpagos("cflat") = ""
                drpagos("lsol") = llsol
                drpagos("cnuming") = lcnuming
                drpagos("cnuming0") = lcnuming0

                If dsclientes.Tables(0).Rows.Count > 1 Then
                    drpagos("cmotivo") = "Posee mas de un crédito,"
                ElseIf dsclientes.Tables(0).Rows.Count < 1 Then
                    drpagos("cmotivo") = "No se encontró Crédito"
                End If

            End If
            lcpagos.Rows.Add(drpagos)
            ' End If

            'input = sr.ReadLine()
            'End While
            x += 1
        Next
        'sr.Close()
        dstmp.Tables.Add(lcpagos)

        'carga las variables de cesion necesarias para los pagos

        clspagdes.gncorrela = Session("GNCORRELA")
        clspagdes.gnperbas = Session("gnperbas")
        clspagdes.gncosind = Session("gncosind")
        clspagdes.gnmora = Session("gnmora")


        clspagdes.gnsegdeu = Session("gnSegVm")
        clspagdes.gnsegdeu1 = Session("gnSegVm1")

        clspagdes.gnmanejo = Session("gncomtra")
        clspagdes.gnporseg = Session("gnporseg")
        clspagdes.gnsegdan = Session("gnsegdan")
        clspagdes.gnporres = Session("gnporres")
        clspagdes.gntalona = Session("gntalona")
        clspagdes.gdfecmor = Session("gdfecmor")
        clspagdes.gccodusu = Session("gccodusu")
        clspagdes.gncorrela = Session("gncorrela")

        'el correlativo tomara el que esta en tabtvar

        etabtvar.cnomvar = "gncorrela"
        etabtvar.ccodapl = "CRE"
        mtabtvar.ObtenerTabtvar(etabtvar)
        clspagdes.gncorrela = etabtvar.cconvar
        clspagdes.gdfecsis = Session("gdfecsis")
        clspagdes.pcbanco = Me.cmbbanco.SelectedValue.Trim
        clspagdes.pctippag = Me.cmbtippag.SelectedValue.Trim

        clspagdes.gnpergra = Session("gnpergra")
        clspagdes.gcCodofi = Session("gcCodofi")
        clspagdes.pnporiva = Session("gnIVA")

        Dim lcancela As Boolean = Me.CheckBox2.Checked
        Dim etabtofi As New cTabtofi
        Dim lccomprobante0 As String
        lccomprobante0 = etabtofi.ObtieneCorrelativo(Session("gcCodofi"))
        Me.txtcompro0.Text = lccomprobante0.Trim


        clspagdes.gcpuente = Session("gncuentap")
        clspagdes.pccolector = "1"   ' 1 Banamex, 2 Paynet



        clspagdes.fxpagosautomaticos(lcnombar, ldfecbar, dstmp, lcancela, Session("gnporint"), _
                                     txtcompro.Text.Trim, Session("GNDIAGRACIA"))


        If Me.cmbtippag.SelectedValue.Trim = "C" Then
            'Graba Boleta
            'clsprin.GrabarBoletas(Me.cmbbanco.SelectedValue.Trim, Me.txtcompro.Text.Trim, " ", Session("gdfecsis"), ldfecha1, Double.Parse(txtaaplicar.Text))
        End If

        dsnopagos = dstmp

        For Each filaauto In dsnopagos.Tables(0).Rows
            If IsDBNull(filaauto("ccodcli")) Then
                eautopag.ccodcli = " "
            Else
                eautopag.ccodcli = filaauto("ccodcli")
            End If
            If IsDBNull(filaauto("ccodcta")) Then
                eautopag.ccodcta = " "
            Else
                eautopag.ccodcta = filaauto("ccodcta")
            End If

            If IsDBNull(filaauto("cnomcli")) Then
                eautopag.cnomcli = " "
            Else
                eautopag.cnomcli = filaauto("cnomcli")
            End If

            If IsDBNull(filaauto("dfecpag")) Then
                eautopag.dfecpag = Date.Today
            Else
                eautopag.dfecpag = filaauto("dfecpag")
            End If

            If IsDBNull(filaauto("nmonto")) Then
                eautopag.nmonto = 0
            Else
                eautopag.nmonto = filaauto("nmonto")
            End If
            If IsDBNull(filaauto("ccodofi")) Then
                eautopag.ccodofi = " "
            Else
                eautopag.ccodofi = filaauto("ccodofi")
            End If
            If IsDBNull(filaauto("cflag")) Then
                eautopag.cflag = " "
            Else
                eautopag.cflag = filaauto("cflag")
            End If
            If IsDBNull(filaauto("cmotivo")) Then
                eautopag.cmotivo = " "
            Else
                eautopag.cmotivo = filaauto("cmotivo")
            End If
            If IsDBNull(filaauto("cflat")) Then
                eautopag.cflat = " "
            Else
                eautopag.cflat = filaauto("cflat")
            End If
            mautopag.Agregar(eautopag)
        Next

        etabtofi.ActualizaCorrelativo(Session("gcCodofi"), txtcompro.Text.Trim)

        ImageButton1.Enabled = False
        imprime_recibo()

    End Sub

    Protected Sub txtfecbar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfecbar.TextChanged
        CargarPorCliente(Me.txtcCodsol.Text.Trim)
        If Date.Parse(Me.txtfecbar.Text) < Date.Parse(Me.txtfecult.Text) Then
            'Response.Write("<script language='javascript'>alert('Existe fecha posterior de pago')</script>")
            codigoJs = "<script language='javascript'>alert('Existe fecha posterior de pago, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If
    End Sub

    Protected Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CargarPorCliente(Me.txtcCodsol.Text.Trim)
        If CheckBox2.Checked = True Then
            Me.datagrid1.Enabled = False
        Else
            Me.datagrid1.Enabled = True
        End If
    End Sub

    Private Function DeudaAldiaCancelacion(ByVal pccodcta As String) As Double
        Dim ldfecval As Date
        Dim ok As Integer
        Dim lndeuda As Double = 0
        Dim lndeucap As Double = 0
        Dim lnsalint As Double = 0
        Dim lnsalmor As Double = 0

        Dim lnintere As Double = 0
        Dim lncapita As Double = 0
        Dim lnsaldo As Double = 0
        Dim lnmonpag As Double = 0
        Dim lnmora As Double = 0


        ldfecval = Date.Parse(Me.txtfecbar.Text.Trim)

        clsaplica.pccodcta = pccodcta
        clsaplica.pdfecval = ldfecval
        clsaplica.gdfecsis = ldfecval
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.gdultpag = #2/1/1970#
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.pcestado = "F"


        ok = clsaplica.omcalcinterest("T", ldfecval)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        If ok = 9 Then
            ok = 9
        Else
            If ok = 1 Then
                lndeucap = Math.Round(clsaplica.pndeucap, 2)
                lnsalint = Math.Round(clsaplica.pnsalint, 2)
                lnsalmor = Math.Round(clsaplica.pnsalmor, 2)
                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
            End If

        End If

        lndeuda = Math.Round(lndeucap + lnsalint + lnsalmor, 2)

        If Me.txtflat.Text.Trim = "F" Then
            If Me.CheckBox2.Checked = True Then
                clsaplica.porinteres = Session("gnporint")
                lnintere = clsaplica.interesCancelacion(pccodcta, ldfecval)
                lncapita = lnsaldo
                lnmonpag = Math.Round(lncapita + lnintere + lnsalmor, 2)
                lndeuda = lnmonpag
            Else
                'lnintere = clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
                lnintere = lnsalint
                lncapita = lndeucap
            End If
        Else 'sobre saldo
            If Me.CheckBox2.Checked = True Then
                '                clsaplica.porinteres = Session("gnporint")
                '               lnintere = clsaplica.interesCancelacion(pccodcta, ldfecval)
                lncapita = lnsaldo
                lnmonpag = Math.Round(lnsaldo + lnsalint + lnsalmor, 2)
                lndeuda = lnmonpag
            Else
                'lnintere = clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
                lnintere = lnsalint
                lncapita = lndeucap
            End If

        End If

        Return lndeuda

    End Function

    Protected Sub Button2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ecremcre As New cCremcre
        ecremcre.EliminaTablaPagos(Me.txtcCodsol.Text.Trim)
        Dim ecredppg As New cCredppg
        Dim ecredkar As New cCredkar

        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lncuota As Double = 0
        Dim lndeuda As Double = 0
        ds = ecremcre.ObtenerSocias(Me.txtcCodsol.Text.Trim)
        Me.txtsocias.Text = ds.Tables(0).Rows.Count
        Dim lnaaplicar As Double = 0
        Dim lcflat As String = ""
        For Each fila In ds.Tables(0).Rows
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i)("codigo"))
            lcflat = ds.Tables(0).Rows(i)("cflat")
            If Me.CheckBox2.Checked = True Then
                lndeuda = DeudaAldiaCancelacion(ds.Tables(0).Rows(i)("codigo"))
            Else
                lndeuda = DeudaAldia(ds.Tables(0).Rows(i)("codigo"))
            End If
            ds.Tables(0).Rows(i)("npago") = 0
            lnaaplicar = 0
            ds.Tables(0).Rows(i)("ncuota") = lncuota

            ds.Tables(0).Rows(i)("lsolidario") = False
            ds.Tables(0).Rows(i)("ndeuda") = lndeuda

            ecremcre.InsertaTablaPagos(ds.Tables(0).Rows(i)("codigo"), ds.Tables(0).Rows(i)("cnomcli"), lncuota, ds.Tables(0).Rows(i)("npago"), False, lndeuda, Me.txtcCodsol.Text.Trim)
            i += 1
        Next
        Me.txtaaplicar.Text = lnaaplicar
        Me.datagrid1.DataSource = ds.Tables(0)
        Me.datagrid1.Columns(0).Visible = False
        Me.datagrid1.Columns(6).Visible = False
        Me.datagrid1.Columns(7).Visible = False

        Me.datagrid1.DataBind()

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim xy As Integer = 0
        Dim lnaplicar As Double = 0
        Dim lnpago As Double = 0
        Dim nmonto As TextBox


        For xy = 0 To Me.datagrid1.Items.Count - 1
            nmonto = CType(Me.datagrid1.Items(xy).FindControl("Textbox2"), TextBox)
            lnpago = Double.Parse(nmonto.Text) 'Double.Parse(lcmonsug.Replace("Q", ""))


            lnaplicar = lnaplicar + lnpago
        Next
        Me.txtaaplicar.Text = lnaplicar
    End Sub

    Protected Sub cmbtippag_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtippag.SelectedIndexChanged
        Dim indice As Integer
        Dim cadena As String = ""
        Dim bandera As Boolean = 0
        Dim codBanco As Integer = 0

        If cmbtippag.SelectedItem.Value.Trim = "I" Then
            'Dim lnlimcond As Double
            'lnlimcond = Math.Round(Double.Parse(Me.txtintere2.Text) + Double.Parse(Me.txtcomision.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtsegdeu.Text), 2)
            'Me.txtmonpag.Text = lnlimcond
        End If

        If cmbtippag.SelectedItem.Value.Trim = "C" Then
            Label41.Visible = True
            cmbbanco.Visible = True
            Me.txtcompro.Visible = True
            Me.Label42.Visible = True
            Me.txtcompro.Text = "0"
            cmbbanco.Enabled = True
        Else
            'Label41.Visible = False
            'cmbbanco.Visible = False
            Me.txtcompro.Visible = False
            Me.Label42.Visible = False
            Me.txtcompro.Text = Me.txtcompro0.Text
            cmbbanco.Enabled = False
        End If


        'For indice = 0 To cmbbanco.Items.Count - 1

        '    Select Case cmbtippag.SelectedItem.Text.Trim
        '        Case "EFECTIVO"
        '            cadena = cmbbanco.Items(indice).Text.ToUpper.Trim
        '            'If InStr(cadena, "EFECTIVO") = 0 Then
        '            ' bandera = 0
        '            ' Else
        '            If InStr(cadena, "EFECTIVO") <> 0 Then
        '                cmbbanco.SelectedValue = cmbbanco.Items(indice).Value
        '                'Me.Txtnrochq.Text = clsbanco.RetornaCheque(Me.cmbbanco.SelectedValue)
        '            End If
        '        Case "NOTA DE ABONO"
        '            cadena = cmbbanco.Items(indice).Text.ToUpper.Trim
        '            If InStr(cadena, "EFECTIVO") = 0 Then
        '                cmbbanco.SelectedValue = cmbbanco.Items(indice).Value
        '                'Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbbanco.SelectedValue)
        '            End If
        '        Case "CHEQUE"
        '            cadena = cmbbanco.Items(indice).Text.ToUpper.Trim
        '            If InStr(cadena, "EFECTIVO") = 0 Then
        '                cmbbanco.SelectedValue = cmbbanco.Items(indice).Value
        '                'Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbbanco.SelectedValue)
        '            End If

        '    End Select
        'Next

    End Sub
End Class


