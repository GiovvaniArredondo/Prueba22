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

Partial Class controles_Creditos_WbUCPagosAuto
    Inherits ucWBase


#Region "Privadas"
    Private codigoJs As String
    Private cls1 As New pagdesver
    Private clsConvert As New ConversionLetras
    Private clsaplica As New payment
    Private pncomper As Double = 0
    Private pnsegdeu As Double = 0
    Private dsnopagos As New DataSet
    Private clsppal As New class1
#End Region

#Region "Metodos"

    Public Sub Inicio()
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IN", 24)
        Dim ldfecsis As Date
        ldfecsis = Session("gdfecsis")
        Me.txtfecbar.Text = ldfecsis
        'Me.btnimprimir.Visible = True
        txtnombar.Text = Generanombre()
        CargaBancos()
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

#End Region


    Protected Sub btnprocesar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprocesar.Click
        btnprocesar.Enabled = False

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
                        codigoJs = "<script language='javascript'>alert('Fecha Debe ser Menor o Igual a Fecha de Sistema, " & _
                                   "Advertencia SIM.NET ')</script>"

                        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                        Return
                    End If

                    Dim sr As StreamReader = File.OpenText(FILE_NAME)

                    input = sr.ReadLine()

                    Dim lnnumlin As Integer = 0
                    
                    While Not input Is Nothing
                        'input = sr.ReadLine()
                        If input = Nothing Then
                            Exit While
                        End If
                        lnnumlin += 1

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

                            ' Dim lccode As String
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
                            'lcmonto = Left(lccampotx9, 8) + "." + lccampotx9.Trim.Substring(8, 2)
                            lcmonto = Left(lccampotx6, 8) + "." + lccampotx6.Trim.Substring(8, 2)
                            lnmonto = Double.Parse(lcmonto)
                            If ldfecpag > Session("gdfecsis") Then
                                codigoJs = "<script language='javascript'>alert('La Fecha del Pago es Mayor a la Fecha del Sistema, No se pueden procesar los pagos," & _
                                           "Advertencia SIM.NET ')</script>"
                                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                                Exit Sub
                            End If


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
                                    'drpagos("cflag") = "X"
                                    drpagos("cflag") = ""
                                    'drpagos("cmotivo") = "Crédito Cancelado"
                                    drpagos("cmotivo") = ""
                                    drpagos("cflat") = "G"
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


                        input = sr.ReadLine()

                    End While

                    sr.Close()
                    'dstmp.Tables.Add(lcpagos)

                    'carga las variables de cesion necesarias para los pagos

                    'clspagdes.gncorrela = Session("GNCORRELA")
                    'clspagdes.gnperbas = Session("gnperbas")
                    'clspagdes.gncosind = Session("gncosind")
                    'clspagdes.gnmora = Session("gnmora")


                    'clspagdes.gnsegdeu = Session("gnSegVm")
                    'clspagdes.gnsegdeu1 = Session("gnSegVm1")

                    'clspagdes.gnmanejo = Session("gncomtra")
                    'clspagdes.gnporseg = Session("gnporseg")
                    'clspagdes.gnsegdan = Session("gnsegdan")
                    'clspagdes.gnporres = Session("gnporres")
                    'clspagdes.gntalona = Session("gntalona")
                    'clspagdes.gdfecmor = Session("gdfecmor")
                    'clspagdes.gccodusu = Session("gccodusu")
                    ''clspagdes.gncorrela = Session("gncorrela")
                    'clspagdes.gniva = Session("gniva")

                    ''el correlativo tomara el que esta en tabtvar

                    'etabtvar.cnomvar = "gncorrela"
                    'etabtvar.ccodapl = "CRE"
                    'mtabtvar.ObtenerTabtvar(etabtvar)
                    'clspagdes.gncorrela = etabtvar.cconvar
                    'clspagdes.gdfecsis = Session("gdfecsis")

                    'clspagdes.pctippag = "C"
                    'clspagdes.pcbanco = cmbbanco.SelectedValue.Trim
                    'clspagdes.gcpuente = Session("gncuentap")
                    'clspagdes.pccolector = Me.cmbtipArch.SelectedValue.Trim   ' 1 Banamex, 2 Paynet


                    Dim etabtofi As New cTabtofi
                    lccomprobante = "" 'etabtofi.ObtieneCorrelativo(Session("gcCodofi"))

                    If lcpagos.Rows.Count > 0 Then
                        Dim omcredkar As New cCredkar
                        lcpagos.Columns.Remove("Column1")

                        dsnopagos = omcredkar.Pagos_Automaticos(lcpagos, Session("gdfecsis"), Session("gccodusu"), FileName)
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

                    '  dsnopagos = dstmp

                    
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
