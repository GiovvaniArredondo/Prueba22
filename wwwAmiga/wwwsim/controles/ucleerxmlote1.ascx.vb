

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

Partial Class ucleerxmlote1
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
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then

            Dim ldfecsis As Date
            ldfecsis = Session("gdfecsis")
            Me.txtfecbar.Text = ldfecsis
            Me.cargarcombos()
            Me.comprobante()
            Me.Deshabilitar()

            '            Me.archivodetexto.Attributes.Add("onclick", "funcionclick")
        End If

    End Sub
    Private Sub comprobante()
        Dim etabtvar As New tabtvar
        Dim mtabtvar As New cTabtvar
        Dim lncomprobante As Integer
        etabtvar.cnomvar = "GNCORRELA"
        etabtvar.ccodapl = "CRE"
        mtabtvar.ObtenerTabtvar(etabtvar)

        lncomprobante = Double.Parse(etabtvar.cconvar) + 1
        Me.txtcompro.Text = lncomprobante.ToString.Trim

    End Sub
    Private Sub Deshabilitar()
    

    End Sub
    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        clsbancos.ObtenerDatasetporid(dsb, Session("gcCodofi"))
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()

        Dim clstabttab As New SIM.BL.cTabttab
        Dim dsp As New DataSet
        clstabttab.ObtenerDatasetporid(dsp)
        Me.cmbtippag.DataTextField = "cdescri"
        Me.cmbtippag.DataValueField = "ccodigo"
        Me.cmbtippag.DataSource = dsp.Tables(0)
        Me.cmbtippag.DataBind()

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Me.txtcCodsol.Text = codigoCliente.Trim
        Dim lcnomgru As String
        lcnomgru = ecremsol.ObtenerNombrecentro(codigoCliente.Trim)
        Me.txtcentro.Text = lcnomgru

        ecremcre.EliminaTablaPagos(Me.txtcCodsol.Text.Trim)

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
        Dim ecreditos As New ccreditos
        Dim dscredito As New DataSet
        Dim ldfecha As Date

        ldfecha = Date.Parse(Me.txtfecbar.Text.Trim)

        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lncuota As Double = 0
        Dim lnaaplicar As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnsaldo As Double = 0
        Dim lndeuda As Double = 0
        ds = ecremcre.ObtenerSociasporCentro(Me.txtcCodsol.Text.Trim)
        Me.txtsocias.Text = ds.Tables(0).Rows.Count
        For Each fila In ds.Tables(0).Rows
            'dscredito = ecreditos.SaldoxCuenta(ds.Tables(0).Rows(i)("ccodigo"), ldfecha)
            'lncapdes = Math.Round(dscredito.Tables(0).Rows(0)("ncapdes"), 2)
            'lncappag = Math.Round(dscredito.Tables(0).Rows(0)("ncappag"), 2)
            'lnsaldo = lncapdes - lncappag
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i)("codigo"))
            '            lnsalteo = ecredppg.ObtenerSaldoTeorico(ds.Tables(0).Rows(i)("codigo"), ldfecha, lncapdes)
            lndeuda = DeudaAldia(ds.Tables(0).Rows(i)("codigo"))
            ds.Tables(0).Rows(i)("ncuota") = lncuota
            ds.Tables(0).Rows(i)("npago") = lncuota
            ds.Tables(0).Rows(i)("lsolidario") = False
            ds.Tables(0).Rows(i)("ndeuda") = lndeuda
            lnaaplicar = lnaaplicar + lncuota

            ecremcre.InsertaTablaPagos(ds.Tables(0).Rows(i)("codigo"), ds.Tables(0).Rows(i)("cnomcli"), lncuota, lncuota, False, lndeuda, Me.txtcCodsol.Text.Trim)
            i += 1
        Next

        Me.datagrid1.DataSource = ds.Tables(0)
        Me.datagrid1.Columns(7).Visible = False

        Me.datagrid1.DataBind()
        Me.txtaaplicar.Text = lnaaplicar
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
        crRpt.SetParameterValue("cnomofi", Session("gcnomofi"))
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
        Response.Flush()
        Response.Close()


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

    Private Sub Imprime_Recibo_Grupal()
        Dim dsrecibo As New DataSet
        dsrecibo = ecremsol.ReciboGrupal2(Me.txtcCodsol.Text.Trim)

        Dim lccodins As String
        Dim lccodofi As String
        Dim lccodcta As String
        Dim ldfecha As Date
        Dim lccomprobante As String
        Dim lctipo As String = ""
        Dim clskardex As New ckardex

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim dsprint As New DataSet
        dsprint = dsnopagos
        lctipo = ""
        lccomprobante = Me.txtcompro.Text.Trim
        ldfecha = Date.Parse(Me.txtfecbar.Text) 'Session("gdfecsis")
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

        Dim xy As Integer = 0
        For xy = 0 To Me.datagrid1.Items.Count - 1
            lccodcta = Me.datagrid1.Items(xy).Cells(7).Text.Trim 'dsprint.Tables(0).Rows(i)("cCodcta")
            lccodins = lccodcta.Substring(0, 3)
            lccodofi = lccodcta.Substring(3, 3)
            dsimprimepagos = clskardex.ObtenerDataSetPorID2(lccodcta, ldfecha, "C", lccomprobante, " ")

            nCanti = 0

            For Each fila1 In dsimprimepagos.Tables(0).Rows
                pcconcep = dsimprimepagos.Tables(0).Rows(nCanti)("cconcep")
                pnmonto = utilNumeros.Redondear(dsimprimepagos.Tables(0).Rows(nCanti)("nmonto"), 2)
                If pcconcep = "KP" Then
                    pnkp1 = pnkp1 + pnmonto
                ElseIf pcconcep = "IN" Then
                    pnin1 = pnin1 + pnmonto
                ElseIf pcconcep = "MO" Then
                    pnmo1 = pnmo1 + pnmonto
                ElseIf pcconcep = "CO" Then
                    pnop1 = pnop1 + pnmonto
                ElseIf pcconcep = "SD" Then
                    pn041 = pn041 + pnmonto
                ElseIf pcconcep = "CJ" Then
                    pntotal1 = pntotal1 + pnmonto
                Else
                    pnotro1 = pnotro1 + pnmonto
                End If
                nCanti = nCanti + 1
            Next
            i += 1
        Next


        '----Descargamos data set en variables----'
        Dim lnDecimal As Double
        Dim pccantlet1 As String

        pccantlet1 = ConversionLetras.ConversionEnteros(pntotal1)
        lnDecimal = clsConvert.ExtraeDecimales(pntotal1)
        pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " QUETZALES"

        Dim lcnomofi As String
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
        ds = ecremcre.ObtenerSociasporCentro(Me.txtcCodsol.Text.Trim)
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
        For Each fila2 In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i2)("codigo")
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





        lnsaldo1 = lncapdes - lncappag

        saldoant = lncapdes - lncappag + pnkp1


        Dim lcnomcen As String = ""
        lcnomcen = Me.txtcentro.Text.Trim




        lcnomofi = Session("gcnomofi")
        ldfecsis = Session("gdfecsis")
        '-----------------------------------------'
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crpagoscentros.rpt", OpenReportMethod.OpenReportByDefault)
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

        Dim reportes As String
        'reportes = "crpagos.rpt"
        reportes = "crpagoscentros.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
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
    Private Sub btnrecibo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.ServerClick
        Me.Imprime_Recibo_Grupal()
    End Sub

    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lnsocias As Integer = 0
        Dim lnvalor As Double = 0
        Dim lndistribuir As Double = 0
        lnsocias = Integer.Parse(Me.txtsocias.Text)
        lnsocias = IIf(lnsocias = 0, 1, lnsocias)
        lndistribuir = Double.Parse(Me.txtaaplicar0.Text.Trim)
        lnvalor = Math.Round(lndistribuir / lnsocias, 2)
        Dim lccodcta As String = ""
        Dim lncuota As Double = 0
        Dim lnpago As Double = 0
        Dim xy As Integer = 0
        Dim lnvaloraplica As Double = 0
        Dim lndifer As Double = 0

        If Me.RadioButton1.Checked = True Then 'Excedente

            For xy = 0 To Me.datagrid1.Items.Count - 1
                lccodcta = Me.datagrid1.Items(xy).Cells(6).Text.Trim
                lncuota = Me.datagrid1.Items(xy).Cells(4).Text.Trim
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
                lccodcta = Me.datagrid1.Items(xy).Cells(6).Text.Trim
                lncuota = Me.datagrid1.Items(xy).Cells(4).Text.Trim
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
        Return lndeuda

    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
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
        Dim lcnuming As String = ""
        lcnuming = Me.txtcompro.Text.Trim


        'revisara si ya fueron aplicados los pagos en dicha fecha
        ldfecha1 = Date.Parse(Me.txtfecbar.Text)
        ldfecha2 = Date.Parse(Me.txtfecbar.Text)

        lcampos1 = "ccodcta, ccodcli, cnomcli, dfecpag, nmonto, ccodofi, cflag, cmotivo, cflat, lsol,cnuming,"
        ltipos1 = "S,S,S,F,D,S,S,S,S,B,S,"
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

        For Each fila In ds.Tables(0).Rows

            lccodcta = ds.Tables(0).Rows(x)("codigo")
            ldfecpag = Date.Parse(Me.txtfecbar.Text)
            lccodofi = lccodcta.Substring(3, 3)
            lnmonto = ds.Tables(0).Rows(x)("npago")
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

        clspagdes.fxpagosautomaticos(lcnombar, ldfecbar, dstmp, False, Session("gnporint"), _
                                     txtcompro.Text.Trim, Session("GNDIAGRACIA"))


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

        imprime_recibo()

    End Sub
End Class


