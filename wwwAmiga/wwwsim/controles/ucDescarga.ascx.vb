
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

Partial Class ucDescarga
    Inherits ucWBase


#Region "Privadas"
    Private codigoJs As String
#End Region

#Region "Metodos"
    Private cls1 As New pagdesver
    Private clsConvert As New ConversionLetras
    Private clsaplica As New payment
    Private pncomper As Double = 0
    Private pnsegdeu As Double = 0
    Private dsnopagos As New DataSet
    Private clsppal As New class1
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IN", 24)
            Dim ldfecsis As Date
            ldfecsis = Session("gdfecsis")
            Me.txtfecbar.Text = ldfecsis
            'Me.btnimprimir.Visible = True
            txtnombar.Text = Generanombre()
            CargaBancos()
            '            Me.archivodetexto.Attributes.Add("onclick", "funcionclick")
        End If

    End Sub
    Function Generanombre() As String
        'CE_reficom_cdro_23112011
        Dim lcnombre As String
        Dim lcfecha As String
        lcfecha = Left(Date.Parse(txtfecbar.Text).ToString, 2) & Date.Parse(txtfecbar.Text).ToString.Substring(3, 2) & Date.Parse(txtfecbar.Text).ToString.Substring(6, 4)

        lcnombre = "fundea" & lcfecha

        Return lcnombre

    End Function
    Private Sub CargaBancos()
        Dim dsb As New DataSet
        Dim clsbancos As New cTabtbco
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "RE")
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()
        cmbbanco.SelectedValue = "27"
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

        'ESTA VALIDACION


    End Sub

    Shared Function ExportarDataTableAExcel(ByVal Tabla As DataTable) As Boolean
        Try
            'Creamos las variables
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim filaTabla As System.Data.DataRow

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Tabla.Columns.Count
            Dim NRow As Integer = Tabla.Rows.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(3, i) = Tabla.Columns(i - 1).Caption
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                filaTabla = Tabla.Rows(Fila)
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 4, Col + 1) = filaTabla(Col)
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(3).Font.Bold = 1
            exHoja.Rows.Item(3).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            ExportarDataTableAExcel = True
        Catch ex As Exception
            MsgBox(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador")
            ExportarDataTableAExcel = False
        End Try
    End Function







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
        imprimeRecibos()
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
            fila("cnomusu") = Session("gccodusu")
            pnpago = dspagosATM.Tables(0).Rows(nelem)("npago")
            pccantlet1 = clsConvert.ConversionEnteros(pnpago)
            lnDecimal = clsConvert.ExtraeDecimales(pnpago)
            pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " DOLARES"
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


    Protected Sub txtfecbar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtfecbar.TextChanged
        txtnombar.Text = Generanombre()
    End Sub


    Protected Sub btnprocesar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprocesar.Click
        btnprocesar.Enabled = False
        'crea el dataset donde depositara los pagos ya transformados
        'CE_reficom_cdro_23112011
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "Gr", 24)



        Dim prueba As Double = Session("GNCORRELA")
        Dim dstmp As New DataSet
        Dim drpagos As DataRow
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcpagos As New DataTable
        Dim clsprin As New class1
        'Dim lcnrodoc As String
        'Dim lncuenta2 As Integer

        Dim ldfecpag As Date
        'Dim lccodofi As String
        Dim lnmonto As Double
        'Dim lncasa As String

        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        Dim lccodcli As String = ""
        'Dim lccasa As String
        'Dim lntam As Integer
        Dim i As Integer
        Dim dsclientes As New DataSet
        Dim lcnomcli As String = ""
        Dim lccodcta As String = ""
        Dim lcnombar As String
        Dim ldfecbar As Date
        Dim clspagdes As New cpagosauto 'pagdesver

        Dim lccomprobante As String
        'Dim ldfecval As Date
        'Dim ldfecsis As Date
        'Dim gnperbas As Double
        'Dim lncosind As Double
        'Dim gnmora As Double
        'Dim ldultpag As DateTime
        'Dim lnpropseg As Double
        'Dim lnpropman As Double
        'Dim lnperbas As Double
        'Dim lnporsegdeu As Double
        'Dim lnporsegdan As Double
        'Dim lnporres As Double
        'Dim lnportalona As Double
        'Dim gdfecmor As Double
        Dim mclimide As New cClimide
        Dim eclimide As New climide
        'Dim respuesta As Integer
        Dim eautopag As New autopag
        Dim mautopag As New cAutopag
        Dim filaauto As DataRow
        Dim mcredkar As New cCredkar
        Dim input As String
        ' Dim lcfecha As String
        Dim lcfecha1 As String
        'Dim lcmonto1 As String
        Dim lcmonto As String
        'Dim lntammon As Integer
        'Dim lcmonto2 As String
        Dim lcflat As String
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim dsnop As New DataSet
        'Dim lncorrela As Integer

        Dim lcoficina As String = ""

        Dim etabtvar As New tabtvar
        Dim mtabtvar As New cTabtvar
        Dim dscancela As New DataSet

        'revisara si ya fueron aplicados los pagos en dicha fecha
        ldfecha1 = Date.Parse(Me.txtfecbar.Text)
        ldfecha2 = Date.Parse(Me.txtfecbar.Text)

        lcampos1 = "ccodcta, ccodcli, cnomcli, dfecpag, nmonto, ccodofi, cflag, cmotivo, cflat,cnuming,cnuming0, "
        ltipos1 = "S,S,S,F,D,S,S,S,S,S,S,"
        lcpagos = clsprin.creadatasetdesconec(lcampos1, ltipos1, "KARDEX1")

        lcnombar = Generanombre() & ".txt" 'Me.txtnombar.Text.Trim
        ldfecbar = Date.Parse(Me.txtfecbar.Text)

        ' Nuevo Metodo para halar el archivo plano
        Dim fileOK As Boolean = False
        If FileUpload1.HasFile Then

            'Dim FileName As New Object
            Dim FileName As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
            Dim Extension As String = Path.GetExtension(FileUpload1.PostedFile.FileName)
            Dim FolderPath As String = ConfigurationManager.AppSettings("FolderPath")

            Dim FilePath As String = Server.MapPath(FolderPath + FileName)


            Dim allowedExtensions As String() = _
                {".txt"}
            For j As Integer = 0 To allowedExtensions.Length - 1
                If Extension = allowedExtensions(i) Then
                    fileOK = True
                End If
            Next
            If fileOK Then
                Try
                    'Finaliza la carga del Archivo
                    FileUpload1.SaveAs(FilePath)

                    'Import_To_Grid(FilePath, Extension, rbHDR.SelectedItem.Text)
                    'Import_to_grid(FilePath, Extension, "")


                    lcnombar = FilePath 'Me.txtnombar.Text.Trim & ".txt"
                    ldfecbar = Date.Parse(Me.txtfecbar.Text)


                    'lee un archivo de texto
                    Dim FILE_NAME As String = FilePath '"c:/txt/" & lcnombar

                    If Not File.Exists(FILE_NAME) Then
                        'Me.AsignarMensaje("No existe archivo: " + lcnombar, True)

                        codigoJs = "<script language='javascript'>alert('No Existe el Archivo: " & lcnombar & _
                                   " Advertencia SIM.NET ')</script>"

                        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

                        Return
                    End If

                    'Valida si el Archivo Existe
                    If mcreditos.Valida_Archivo_Txt(FileName) = 1 Then
                        codigoJs = "<script language='javascript'>alert('El Archivo: " & FileName & " ya fue procesado, verifique " & _
                                   "Advertencia SIM.NET ')</script>"

                        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

                        Return
                    End If



                    If Date.Parse(txtfecbar.Text) > Session("gdfecsis") Then
                        '                Response.Write("<script language='javascript'>alert('Fecha Debe ser Menor o Igual a Fecha de Sistema')</script>")
                        codigoJs = "<script language='javascript'>alert('Fecha Debe ser Menor o Igual a Fecha de Sistema, " & _
                                   "Advertencia SIM.NET ')</script>"

                        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                        Return
                    End If

                    Dim sr As StreamReader = File.OpenText(FILE_NAME)

                    input = sr.ReadLine()

                    Dim lnnumlin As Integer = 0
                    Dim strLineaARegistrar() As String
                    Dim intSegmentoMonto As String

                    While Not input Is Nothing
                        'input = sr.ReadLine()
                        If input = Nothing Then
                            Exit While
                        End If
                        lnnumlin += 1

                        If cmbtipArch.Text = "1" Then           'Banamex 

                            'Cesar Torres Agregar una validacion de acuerdo a la cadena, debe incluir una referencia de 20 digitos
                            strLineaARegistrar = Split(input, "|")
                            intSegmentoMonto = strLineaARegistrar(8)
                            If intSegmentoMonto > 0 Then ' valida qeu la referencia de credito tenga la logitud correcta

                                'If input.Length >= 39 Then 'Prueba de Longitud por Error de Envio en el Banco Mexico 09/02/2015
                                'BARRA
                                Dim lclinea As String
                                Dim longlinea As Integer
                                Dim lccadena As String = ""
                                Dim lccadind As String
                                Dim lccampotx1 As String = ""
                                Dim lccampotx2 As String = ""
                                Dim lccampotx3 As String = ""
                                Dim lccampotx4 As String = ""
                                Dim lccampotx5 As String = ""
                                Dim lccampotx6 As String = ""
                                Dim lccampotx7 As String = ""
                                Dim lccampotx8 As String = ""
                                Dim lccampotx9 As String = ""
                                Dim lccampotx10 As String = ""
                                Dim lccampotx11 As String = ""
                                Dim lccampotx12 As String = ""
                                Dim lccampotx13 As String = ""

                                Dim lccode As String
                                Dim lctipopag As String
                                Dim contador As Integer = 1
                                Dim lcMotivo As String = ""

                                lclinea = input.Trim
                                longlinea = lclinea.Length - 1
                                For i = 0 To longlinea
                                    lccadind = lclinea.Substring(i, 1)
                                    If lccadind = "|" Then
                                        Select Case contador
                                            Case 1 : lccampotx1 = lccadena      'Indicador de Registro de Inicio
                                            Case 2 : lccampotx2 = lccadena      'Fecha de Pago
                                            Case 3 : lccampotx3 = lccadena      '
                                            Case 4 : lccampotx4 = lccadena      '
                                            Case 5 : lccampotx5 = lccadena      '
                                            Case 6 : lccampotx6 = lccadena      '
                                            Case 7 : lccampotx7 = lccadena      '
                                            Case 8 : lccampotx8 = lccadena      'Numero de Prestamo    
                                            Case 9 : lccampotx9 = lccadena      'Monto a Pagar
                                            Case 10 : lccampotx10 = lccadena
                                            Case 11 : lccampotx11 = lccadena
                                                'Case 12 : lccampotx12 = lccadena
                                                'Case 13 : lccampotx13 = lccadena
                                        End Select
                                        lccadena = ""
                                        contador = contador + 1
                                    Else
                                        lccadena = lccadena & lclinea.Substring(i, 1)
                                    End If
                                Next
                                'lccampotx8 = lccadena 'Numero de Prestamo    
                                lcfecha1 = lccampotx2
                                ldfecpag = Date.Parse(lcfecha1)

                                lcmonto = lccampotx9 'input.Substring(20, 14).Trim
                                lnmonto = Double.Parse(lcmonto)



                                If ldfecpag > Session("gdfecsis") Then
                                    codigoJs = "<script language='javascript'>alert('La Fecha del Pago es Mayor a la Fecha del Sistema, No se pueden procesar los pagos," & _
                                               "Advertencia SIM.NET ')</script>"
                                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                                    Exit Sub
                                End If

                                'busca cuenta del sit
                                lccode = lccampotx6.Trim
                                lccodcta = Left(lccampotx8.Trim, 18) 'lccode.Substring(5, 18)
                                lctipopag = "" 'lccampotx4.Trim

                                'arma el codigo de cliente y credito si existe

                                'Si el Pago es mayor a cero entrar hacer una busqueda del Prestamo, por Eror de Banamex 09/02/2015
                                If lnmonto > 0 Then
                                    dsclientes = mcreditos.ObtenerDataSetPorcredito11(lccodcta)
                                    If dsclientes.Tables(0).Rows.Count <= 0 Then
                                        lcnomcli = " "
                                        lcoficina = ""
                                        lccodcli = ""
                                    End If

                                    If dsclientes.Tables(0).Rows.Count = 1 Then
                                        If dsclientes.Tables(0).Rows(0)("cestado") = "F" Then
                                            lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                                            lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                                            lcoficina = dsclientes.Tables(0).Rows(0)("coficina")
                                            lcflat = dsclientes.Tables(0).Rows(0)("cflat")

                                            drpagos = lcpagos.NewRow()
                                            drpagos("ccodcta") = lccodcta
                                            drpagos("ccodcli") = lccodcli
                                            drpagos("cnomcli") = lcnomcli
                                            drpagos("dfecpag") = ldfecpag
                                            drpagos("nmonto") = lnmonto
                                            drpagos("ccodofi") = lcoficina
                                            drpagos("cflat") = lcflat
                                            drpagos("cnuming") = ""
                                            drpagos("cnuming0") = "ATM"
                                            lcMotivo = ""
                                        Else
                                            'no se aplicaran los pagos, ya que tiene credito cancelado

                                            lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                                            lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                                            lcoficina = dsclientes.Tables(0).Rows(0)("coficina")
                                            lcflat = dsclientes.Tables(0).Rows(0)("cflat")

                                            'Si el credito esta cancelado verificara si tiene otro credito vigente y lo aplicara
                                            dscancela = mcreditos.Credito_Vigente_por_Cliente(lccodcli)

                                            If dscancela.Tables(0).Rows.Count > 0 Then
                                                For Each lin As DataRow In dscancela.Tables(0).Rows
                                                    lccodcta = lin("ccodcta")
                                                Next

                                                drpagos = lcpagos.NewRow()
                                                drpagos("ccodcta") = lccodcta
                                                drpagos("ccodcli") = lccodcli
                                                drpagos("cnomcli") = lcnomcli
                                                drpagos("dfecpag") = ldfecpag
                                                drpagos("nmonto") = lnmonto
                                                drpagos("ccodofi") = lcoficina
                                                drpagos("cflat") = lcflat
                                                drpagos("cnuming") = ""
                                                drpagos("cnuming0") = "ATM"
                                                lcMotivo = ""
                                            Else



                                                Dim mdeposito As New pagdesver
                                                Dim okpago As Integer
                                                Dim error100 As Integer
                                                Dim miclase As New clase_jaime
                                                Dim miclase1 As New clase_funciones
                                                Dim con As New SqlConnection
                                                Dim stringconnection As String = miclase.conexion()
                                                Dim str_select As String = ""
                                                con.ConnectionString = stringconnection

                                                con.Open()


                                                str_select = "SET LANGUAGE spanish; begin tran"
                                                error100 = miclase.nonquery_sin_parametros(con, str_select)

                                                If error100 = -100 Then
                                                    str_select = "rollback tran"
                                                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                                                    con.Close()

                                                    codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK, " & _
                                                                     "Advertencia SIM.NET ')</script>"


                                                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                                                    Exit Sub
                                                End If


                                                error100 = mdeposito.Deposito_Concentradora_Transac(con, lccodcli, lnmonto)

                                                If error100 = -100 Then
                                                    okpago = 0
                                                    str_select = "rollback tran"
                                                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                                                    con.Close()

                                                    codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                                                                   "Advertencia SIM.NET ')</script>"

                                                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                                                    Exit Sub
                                                End If

                                                str_select = "commit tran"
                                                error100 = miclase.nonquery_sin_parametros(con, str_select)

                                                If error100 = -100 Then
                                                    okpago = 0
                                                    str_select = "rollback tran"
                                                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                                                    con.Close()

                                                    codigoJs = "<script language='javascript'>alert(''Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                                                                   "Advertencia SIM.NET ')</script>"

                                                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                                                    Exit Sub
                                                End If

                                                con.Close()

                                                If okpago = 2 Then

                                                    drpagos = lcpagos.NewRow()
                                                    drpagos("ccodcta") = ""
                                                    drpagos("ccodcli") = lccodcli
                                                    drpagos("cnomcli") = lcnomcli
                                                    drpagos("dfecpag") = ldfecpag
                                                    drpagos("nmonto") = lnmonto
                                                    drpagos("ccodofi") = lcoficina
                                                    drpagos("cflag") = "X"
                                                    drpagos("cmotivo") = "Crédito Cancelado"
                                                    drpagos("cflat") = ""
                                                    drpagos("cnuming") = ""
                                                    drpagos("cnuming0") = ""

                                                Else

                                                    drpagos = lcpagos.NewRow()
                                                    drpagos("ccodcta") = ""
                                                    drpagos("ccodcli") = lccodcli
                                                    drpagos("cnomcli") = lcnomcli
                                                    drpagos("dfecpag") = ldfecpag
                                                    drpagos("nmonto") = lnmonto
                                                    drpagos("ccodofi") = lcoficina
                                                    drpagos("cflag") = "X"
                                                    drpagos("cmotivo") = "Depositado en cta. concetradora"
                                                    drpagos("cflat") = ""
                                                    drpagos("cnuming") = ""
                                                    drpagos("cnuming0") = ""
                                                End If



                                            End If

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
                                        drpagos("ccodofi") = lcoficina
                                        drpagos("cflag") = "X"
                                        drpagos("cflat") = ""
                                        drpagos("cnuming") = ""
                                        drpagos("cnuming0") = ""

                                        'If dsclientes.Tables(0).Rows.Count > 1 Then
                                        '    drpagos("cmotivo") = "Posee mas de un crédito,"
                                        'ElseIf dsclientes.Tables(0).Rows.Count < 1 Then
                                        '    drpagos("cmotivo") = "No se encontró Crédito"
                                        'End If
                                        lcMotivo = ""
                                        If dsclientes.Tables(0).Rows.Count < 1 Then
                                            drpagos("cmotivo") = "No se encontró Crédito"
                                            lcMotivo = "No se encontró Crédito"
                                        End If

                                    End If

                                    ''Inserta en nueva tabla de control de pagos automaticos
                                    'mcredkar.Actualiza_Maestra_Pagos_Automaticos(lccampotx1, Session("gdfecsis"), ldfecpag, lccampotx3, _
                                    '                                             lccampotx8, lnmonto, lccampotx10, Session("gccodusu"), _
                                    '                                             lcMotivo)
                                    lcpagos.Rows.Add(drpagos)
                                End If


                            End If

                        ElseIf cmbtipArch.SelectedValue = "3" Then                 'Telecom


                            If input.Length = 99 Then

                                Dim lclinea As String
                                Dim longlinea As Integer
                                Dim lccadena As String = ""
                                Dim lccadind As String
                                Dim lccampotx1 As String = ""
                                Dim lccampotx2 As String = ""
                                Dim lccampotx3 As String = ""
                                Dim lccampotx4 As String = ""
                                Dim lccampotx5 As String = ""
                                Dim lccampotx6 As String = ""
                                Dim lccampotx7 As String = ""
                                Dim lccampotx8 As String = ""
                                Dim lccampotx9 As String = ""
                                Dim lccampotx10 As String = ""
                                Dim lccampotx11 As String = ""
                                Dim lccampotx12 As String = ""
                                Dim lccampotx13 As String = ""

                                Dim lccode As String
                                Dim lctipopag As String
                                Dim contador As Integer = 1
                                Dim lcMotivo As String = ""

                                lclinea = input.Trim
                                longlinea = lclinea.Length - 1
                                For i = 0 To longlinea
                                    lccadind = lclinea.Substring(i, 1)
                                    If lccadind = "|" Then
                                        Select Case contador
                                            Case 1 : lccampotx1 = lccadena      'Correlativo de Linea
                                            Case 2 : lccampotx2 = lccadena      'Identificador
                                            Case 3 : lccampotx3 = lccadena      'Fecha
                                            Case 4 : lccampotx4 = lccadena      'Oficina
                                            Case 5 : lccampotx5 = lccadena      'Numero de Folio
                                            Case 6 : lccampotx6 = lccadena      'Monto Pago
                                            Case 7 : lccampotx7 = lccadena      'Comision
                                            Case 8 : lccampotx8 = lccadena      'Iva
                                            Case 9 : lccampotx9 = lccadena      'Importe Total
                                            Case 10 : lccampotx10 = lccadena    'Hora
                                                ' Case 11 : lccampotx11 = lccadena
                                                'Case 12 : lccampotx12 = lccadena
                                                'Case 13 : lccampotx13 = lccadena
                                        End Select
                                        lccadena = ""
                                        contador = contador + 1
                                    Else
                                        lccadena = lccadena & lclinea.Substring(i, 1)
                                    End If
                                Next
                                lcfecha1 = "20" + lccampotx3.Trim.Substring(4, 2) + "-" + lccampotx3.Trim.Substring(2, 2) + "-" + Left(lccampotx3, 2)
                                ldfecpag = Date.Parse(lcfecha1)

                                'lcmonto = lccampotx9
                                '0000078021
                                lcmonto = Left(lccampotx9, 8) + "." + lccampotx9.Trim.Substring(8, 2)
                                lnmonto = Double.Parse(lcmonto)
                                'If ldfecpag > Session("gdfecsis") Then
                                '    codigoJs = "<script language='javascript'>alert('La Fecha del Pago es Mayor a la Fecha del Sistema, No se pueden procesar los pagos," & _
                                '               "Advertencia SIM.NET ')</script>"
                                '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                                '    Exit Sub
                                'End If


                                lccodcta = lccampotx2.Trim.Substring(5, 18)
                                lctipopag = "" 'lccampotx4.Trim

                                dsclientes = mcreditos.ObtenerDataSetPorcredito11(lccodcta)
                                If dsclientes.Tables(0).Rows.Count <= 0 Then
                                    lcnomcli = " "
                                    lcoficina = ""
                                    lccodcli = ""
                                End If

                                If dsclientes.Tables(0).Rows.Count = 1 Then
                                    If dsclientes.Tables(0).Rows(0)("cestado") = "F" Then
                                        lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                                        lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                                        lcoficina = dsclientes.Tables(0).Rows(0)("coficina")
                                        lcflat = dsclientes.Tables(0).Rows(0)("cflat")

                                        drpagos = lcpagos.NewRow()
                                        drpagos("ccodcta") = lccodcta
                                        drpagos("ccodcli") = lccodcli
                                        drpagos("cnomcli") = lcnomcli
                                        drpagos("dfecpag") = ldfecpag
                                        drpagos("nmonto") = lnmonto
                                        drpagos("ccodofi") = lcoficina
                                        drpagos("cflag") = ""
                                        drpagos("cflat") = lcflat
                                        drpagos("cnuming") = ""
                                        drpagos("cnuming0") = "ATM"
                                    Else
                                        drpagos = lcpagos.NewRow()
                                        drpagos("ccodcta") = lccodcta
                                        drpagos("ccodcli") = lccodcli
                                        drpagos("cnomcli") = lcnomcli
                                        drpagos("dfecpag") = ldfecpag
                                        drpagos("nmonto") = lnmonto
                                        drpagos("ccodofi") = lcoficina
                                        drpagos("cflag") = "X"
                                        drpagos("cmotivo") = "Crédito Cancelado"
                                        drpagos("cflat") = ""
                                        drpagos("cnuming") = ""
                                        drpagos("cnuming0") = ""
                                    End If

                                Else
                                    drpagos = lcpagos.NewRow()
                                    drpagos("ccodcta") = lccodcta
                                    drpagos("ccodcli") = lccodcli
                                    drpagos("cnomcli") = lcnomcli
                                    drpagos("dfecpag") = ldfecpag
                                    drpagos("nmonto") = lnmonto
                                    drpagos("ccodofi") = lcoficina
                                    drpagos("cflag") = "X"
                                    drpagos("cflat") = ""
                                    drpagos("cnuming") = ""
                                    drpagos("cnuming0") = ""
                                    drpagos("cmotivo") = "No se encontró Crédito"
                                End If

                                lcpagos.Rows.Add(drpagos)

                            End If

                        ElseIf cmbtipArch.Text = "2" Or cmbtipArch.Text = "4" Then 'Paynet

                            If input.Length >= 93 Then
                                'BARRA
                                Dim lclinea As String
                                Dim longlinea As Integer
                                Dim lccadena As String = ""
                                Dim lccadind As String
                                Dim lccampotx1 As String = ""
                                Dim lccampotx2 As String = ""
                                Dim lccampotx3 As String = ""
                                Dim lccampotx4 As String = ""
                                Dim lccampotx5 As String = ""
                                Dim lccampotx6 As String = ""
                                Dim lccampotx7 As String = ""
                                Dim lccampotx8 As String = ""
                                Dim lccampotx9 As String = ""
                                Dim lccampotx10 As String = ""
                                Dim lccampotx11 As String = ""
                                Dim lccampotx12 As String = ""
                                Dim lccampotx13 As String = ""

                                Dim lccode As String
                                Dim lctipopag As String
                                Dim contador As Integer = 1

                                lclinea = input.Trim
                                longlinea = lclinea.Length - 1
                                For i = 0 To longlinea
                                    lccadind = lclinea.Substring(i, 1)
                                    If lccadind = "|" Then
                                        Select Case contador
                                            Case 1 : lccampotx1 = lccadena      'Indicador de Registro de Inicio
                                            Case 2 : lccampotx2 = lccadena      'Contador Secuencial de Registros
                                            Case 3 : lccampotx3 = lccadena      'Fecha de Pago
                                            Case 4 : lccampotx4 = lccadena      'Hora del Pago
                                            Case 5 : lccampotx5 = lccadena      'Número de Autorización
                                            Case 6 : lccampotx6 = lccadena      'Monto de Pago con Decimales
                                            Case 7 : lccampotx7 = lccadena      'Referencia de Pago Proveedor
                                                'Case 8 : lccampotx8 = lccadena      'Numero de Prestamo    
                                                'Case 9 : lccampotx9 = lccadena
                                                'Case 10 : lccampotx10 = lccadena
                                                'Case 11 : lccampotx11 = lccadena
                                                'Case 12 : lccampotx12 = lccadena
                                                'Case 13 : lccampotx13 = lccadena
                                        End Select
                                        lccadena = ""
                                        contador = contador + 1
                                    Else
                                        lccadena = lccadena & lclinea.Substring(i, 1)
                                    End If
                                Next
                                lccampotx8 = lccadena 'Numero de Prestamo    
                                lcfecha1 = lccampotx3
                                ldfecpag = Date.Parse(lcfecha1)

                                lcmonto = lccampotx6 'input.Substring(20, 14).Trim
                                lnmonto = Double.Parse(lcmonto)



                                If ldfecpag > Session("gdfecsis") Then
                                    codigoJs = "<script language='javascript'>alert('La Fecha del Pago es Mayor a la Fecha del Sistema, No se pueden procesar los pagos," & _
                                               "Advertencia SIM.NET ')</script>"
                                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                                    Exit Sub
                                End If

                                'busca cuenta del sit
                                lccode = lccampotx6.Trim
                                lccodcta = lccampotx8.Trim 'lccode.Substring(5, 18)
                                lctipopag = "" 'lccampotx4.Trim

                                'arma el codigo de cliente y credito si existe

                                dsclientes = mcreditos.ObtenerDataSetPorcredito11(lccodcta)
                                If dsclientes.Tables(0).Rows.Count <= 0 Then
                                    lcnomcli = " "
                                    lcoficina = ""
                                    lccodcli = ""
                                End If

                                If dsclientes.Tables(0).Rows.Count = 1 Then
                                    If dsclientes.Tables(0).Rows(0)("cestado") = "F" Then
                                        lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                                        lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                                        lcoficina = dsclientes.Tables(0).Rows(0)("coficina")
                                        lcflat = dsclientes.Tables(0).Rows(0)("cflat")

                                        drpagos = lcpagos.NewRow()
                                        drpagos("ccodcta") = lccodcta
                                        drpagos("ccodcli") = lccodcli
                                        drpagos("cnomcli") = lcnomcli
                                        drpagos("dfecpag") = ldfecpag
                                        drpagos("nmonto") = lnmonto
                                        drpagos("ccodofi") = lcoficina
                                        drpagos("cflat") = lcflat
                                        drpagos("cnuming") = ""
                                        drpagos("cnuming0") = "ATM"
                                    Else
                                        'no se aplicaran los pagos, ya que tiene credito cancelado

                                        lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")


                                        lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                                        lcoficina = dsclientes.Tables(0).Rows(0)("coficina")
                                        lcflat = dsclientes.Tables(0).Rows(0)("cflat")

                                        lccodcta = ""

                                        'Si el credito esta cancelado verificara si tiene otro credito vigente y lo aplicara
                                        dscancela = mcreditos.Credito_Vigente_por_Cliente(lccodcli)

                                        If dscancela.Tables(0).Rows.Count > 0 Then
                                            For Each lin As DataRow In dscancela.Tables(0).Rows
                                                lccodcta = lin("ccodcta")
                                            Next

                                            drpagos = lcpagos.NewRow()
                                            drpagos("ccodcta") = lccodcta
                                            drpagos("ccodcli") = lccodcli
                                            drpagos("cnomcli") = lcnomcli
                                            drpagos("dfecpag") = ldfecpag
                                            drpagos("nmonto") = lnmonto
                                            drpagos("ccodofi") = lcoficina
                                            drpagos("cflat") = lcflat
                                            drpagos("cnuming") = ""
                                            drpagos("cnuming0") = "ATM"

                                        Else

                                            Dim mdeposito As New pagdesver
                                            Dim okpago As Integer
                                            Dim error100 As Integer
                                            Dim miclase As New clase_jaime
                                            Dim miclase1 As New clase_funciones
                                            Dim con As New SqlConnection
                                            Dim stringconnection As String = miclase.conexion()
                                            Dim str_select As String = ""
                                            con.ConnectionString = stringconnection

                                            con.Open()


                                            str_select = "SET LANGUAGE spanish; begin tran"
                                            error100 = miclase.nonquery_sin_parametros(con, str_select)

                                            If error100 = -100 Then
                                                str_select = "rollback tran"
                                                error100 = miclase.nonquery_sin_parametros(con, str_select)
                                                con.Close()

                                                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK, " & _
                                                                 "Advertencia SIM.NET ')</script>"


                                                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                                                Exit Sub
                                            End If


                                            error100 = mdeposito.Deposito_Concentradora_Transac(con, lccodcli, lnmonto)

                                            If error100 = -100 Then
                                                okpago = 0
                                                str_select = "rollback tran"
                                                error100 = miclase.nonquery_sin_parametros(con, str_select)
                                                con.Close()

                                                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                                                               "Advertencia SIM.NET ')</script>"

                                                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                                                Exit Sub
                                            End If

                                            str_select = "commit tran"
                                            error100 = miclase.nonquery_sin_parametros(con, str_select)

                                            If error100 = -100 Then
                                                okpago = 0
                                                str_select = "rollback tran"
                                                error100 = miclase.nonquery_sin_parametros(con, str_select)
                                                con.Close()

                                                codigoJs = "<script language='javascript'>alert(''Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                                                               "Advertencia SIM.NET ')</script>"

                                                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                                                Exit Sub
                                            End If

                                            con.Close()

                                            'If error100 <> -100 Then
                                            '    okpago = 1
                                            'End If


                                            If okpago = 2 Then

                                                drpagos = lcpagos.NewRow()
                                                drpagos("ccodcta") = ""
                                                drpagos("ccodcli") = lccodcli
                                                drpagos("cnomcli") = lcnomcli
                                                drpagos("dfecpag") = ldfecpag
                                                drpagos("nmonto") = lnmonto
                                                drpagos("ccodofi") = lcoficina
                                                drpagos("cflag") = "X"
                                                drpagos("cmotivo") = "Crédito Cancelado"
                                                drpagos("cflat") = ""
                                                drpagos("cnuming") = ""
                                                drpagos("cnuming0") = ""

                                            Else

                                                drpagos = lcpagos.NewRow()
                                                drpagos("ccodcta") = ""
                                                drpagos("ccodcli") = lccodcli
                                                drpagos("cnomcli") = lcnomcli
                                                drpagos("dfecpag") = ldfecpag
                                                drpagos("nmonto") = lnmonto
                                                drpagos("ccodofi") = lcoficina
                                                drpagos("cflag") = "X"
                                                drpagos("cmotivo") = "Depositado en cta. concetradora"
                                                drpagos("cflat") = ""
                                                drpagos("cnuming") = ""
                                                drpagos("cnuming0") = ""
                                            End If



                                        End If

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
                                    drpagos("ccodofi") = lcoficina
                                    drpagos("cflag") = "X"
                                    drpagos("cflat") = ""
                                    drpagos("cnuming") = ""
                                    drpagos("cnuming0") = ""

                                    'If dsclientes.Tables(0).Rows.Count > 1 Then
                                    '    drpagos("cmotivo") = "Posee mas de un crédito,"
                                    'ElseIf dsclientes.Tables(0).Rows.Count < 1 Then
                                    '    drpagos("cmotivo") = "No se encontró Crédito"
                                    'End If

                                    If dsclientes.Tables(0).Rows.Count < 1 Then
                                        drpagos("cmotivo") = "No se encontró Crédito"
                                    End If

                                End If
                                lcpagos.Rows.Add(drpagos)
                            End If

                        End If

                        input = sr.ReadLine()

                    End While

                    sr.Close()
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
                    'clspagdes.gncorrela = Session("gncorrela")
                    clspagdes.gniva = Session("gniva")

                    'el correlativo tomara el que esta en tabtvar

                    etabtvar.cnomvar = "gncorrela"
                    etabtvar.ccodapl = "CRE"
                    mtabtvar.ObtenerTabtvar(etabtvar)
                    clspagdes.gncorrela = etabtvar.cconvar
                    clspagdes.gdfecsis = Session("gdfecsis")

                    clspagdes.pctippag = "C"
                    clspagdes.pcbanco = cmbbanco.SelectedValue.Trim
                    clspagdes.gcpuente = Session("gncuentap")
                    clspagdes.pccolector = Me.cmbtipArch.SelectedValue.Trim   ' 1 Banamex, 2 Paynet


                    Dim etabtofi As New cTabtofi
                    lccomprobante = "" 'etabtofi.ObtieneCorrelativo(Session("gcCodofi"))

                    If dstmp.Tables(0).Rows.Count > 0 Then
                        If cmbtipArch.SelectedValue = "3" Then                 'Telecom
                            Dim omcredkar As New cCredkar
                            lcpagos.Columns.Remove("Column1")

                            omcredkar.Pagos_Automaticos(lcpagos, Session("gdfecsis"), Session("gccodusu"), FileName)
                        Else
                            clspagdes.fxpagosautomaticos(lcnombar, ldfecbar, dstmp, False, 0, lccomprobante, Session("GNDIAGRACIA"))
                        End If

                    End If


                    If mcreditos.Actualiza_Datos_Archivo_Txt(FileName, ldfecbar, Session("gccodusu")) = 0 Then
                        'codigoJs = "<script language='javascript'>alert('Ocurrio un Error al Insertar el Nombre del Archivo," & _
                        '           "Advertencia SIM.NET ')</script>"
                        'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                    End If

                    'actulaiza ultimo correlativo
                    ' lncorrela = clspagdes.gncorrela + 1
                    ' Dim etabtvar As New tabtvar
                    ' Dim mtabtvar As New cTabtvar

                    'etabtvar.ccodapl = "CRE"
                    'etabtvar.cnomvar = "GNNUMLIN"
                    ' etabtvar.lcarini = "1"
                    ' mtabtvar.ObtenerTabtvar(etabtvar)
                    ' etabtvar.cconvar = lncorrela.ToString.Trim
                    ' mtabtvar.ActualizarTabtvar(etabtvar)

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

                        If cmbtipArch.SelectedValue = "3" Then                 'Telecom
                        Else
                            mautopag.Agregar(eautopag)
                        End If

                    Next

                    imprime_recibo()


                    LabelError.Text = "File uploaded!"
                Catch ex As Exception
                    MsgBox("An exception occurred:" & vbCrLf & ex.Message)
                    LabelError.Text = "File could not be uploaded."
                End Try
            Else
                LabelError.Text = "Cannot accept files of this type."
            End If
        End If





    End Sub
End Class


