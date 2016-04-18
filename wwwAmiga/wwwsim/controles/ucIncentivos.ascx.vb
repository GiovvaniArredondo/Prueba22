Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports Microsoft.Office.Interop
Partial Class ucIncentivos
    Inherits ucWBase
    Dim clsppal As New class1
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    CargaCombo()
        'End If
    End Sub
    'Private Sub CargaCombo()
    '    txtanual.Text = Year(Session("gdfecsis"))
    '    cmbmes.SelectedValue = Month(Session("gdfecsis"))
    '    UpdatePanel1.Visible = False
    'End Sub
   
  
    'Protected Sub btnimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
    '    Dim ldhoy As Date = Session("gdfecsis")
    '    Dim lcfecha As String
    '    Dim ldfecha As Date
    '    lcfecha = "#" & "1/" & cmbmes.SelectedValue.ToString & "/" & txtanual.Text & "#"
    '    ldfecha = Date.Parse(lcfecha)
    '    Dim ldfecha1 As Date
    '    Dim ldfecha2 As Date

    '    ldfecha1 = clsppal.PrimerDiaMes(ldfecha)
    '    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)

    '    Dim M1 As New ccreditos
    '    Dim dsbase1 As New DataSet
    '    Dim lmora As Boolean
    '    Dim cancela As String

    '    Me.txtdesde.Text = ldfecha1
    '    Me.txthasta.Text = ldfecha2


    '    M1.cartera = "*"
    '    M1.tipo = "A"
    '    cancela = "0"
    '    lmora = False

    '    dsbase1 = Me.Informe(ldfecha1, ldfecha2, "*", "*", "*", "*", lmora, cancela, "*", "*", ldhoy)
    '    'Me.Imprime("crIncentivo_Ana.rpt", dsbase1, "PDF")

    '    CargarArchivoExcel(dsbase1)



    'End Sub
    'Private Function Informe(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal dfechoy As Date) As DataSet
    '    Dim ecreditos As New ccreditos
    '    Dim eusuarios As New cusuarios
    '    Dim lnsolant As Integer = 0
    '    Dim lnsolper As Integer = 0
    '    Dim lnsolapr As Integer = 0
    '    Dim lnsolden As Integer = 0
    '    Dim lncrecol As Integer = 0
    '    Dim lnmoncol As Double = 0

    '    Dim lnnumana As Integer = 0
    '    Dim lntiepro As Integer = 3
    '    Dim TotalCreditosOtorgados As Decimal = 0
    '    Dim MontoOtorgado As Decimal = 0
    '    Dim Promedio As Decimal = 0
    '    Dim dsdata As New DataSet
    '    Dim dssaldos As New DataSet
    '    Dim dsrecuperaCas As New DataSet

    '    dsdata = ecreditos.SelectIncentivos(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona)
    '    dssaldos = ecreditos.CarteraCalculadaSaldosCapital(dfecha1, dfecha2, "*", "*", "*", "*", lmora, cancela, lccartera, lczona, "*")
    '    dsrecuperaCas = ecreditos.SelectIncentivosRecuperacion(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona)

    '    lnnumana = eusuarios.ObtenerNAnalistas()
    '    Dim ds As New DataSet
    '    Dim fila As DataRow

    '    Dim lccodana As String
    '    ds = eusuarios.analistas()
    '    Dim dscartera As New DataSet

    '    Dim lnsaldo As Decimal = 0
    '    Dim lnsaldoR As Decimal = 0
    '    Dim lnindnue As Integer = 0, lnindre As Integer = 0, lngrunue As Integer = 0, lngrure As Integer = 0
    '    Dim lnrecsan As Decimal = 0
    '    Dim lnsalconI As Decimal = 0, lnsalconG As Decimal = 0
    '    Dim lnsalcas As Decimal = 0
    '    Dim lnfactor As Decimal = 0
    '    Dim lnsalcon As Decimal = 0
    '    Dim etabttab As New cTabttab
    '    Dim lnpenala As Decimal = 0, lnpenalb As Decimal = 0
    '    Dim lnfacCar As Decimal = 0, lnpenal2 As Decimal = 0
    '    For Each fila In ds.Tables(0).Rows
    '        lccodana = fila("usuario")
    '        'If lccodana = "AFCM" Then
    '        '    lccodana = "AFCM"
    '        'End If

    '        lnindnue = ecreditos.ObtieneDatos(dsdata, "nciclo=1 and ctipmet='01' and ccodana='" & lccodana.Trim & "'", 1)
    '        lnindre = ecreditos.ObtieneDatos(dsdata, "nciclo>1 and ctipmet='01' and ccodana='" & lccodana.Trim & "'", 1)

    '        lngrunue = ecreditos.ObtieneDatos(dsdata, "nciclo=1 and ctipmet<>'01' and ccodana='" & lccodana.Trim & "'", 1)
    '        lngrure = ecreditos.ObtieneDatos(dsdata, "nciclo>1 and ctipmet<>'01' and ccodana='" & lccodana.Trim & "'", 1)
    '        lnsaldo = ecreditos.ObtieneDatos(dssaldos, "ccondic <>'S' and ccodana='" & lccodana.Trim & "'", 2)
    '        lnsaldoR = ecreditos.ObtieneDatos(dssaldos, "ccontra <>'N' and ccondic <> 'S' and ccodana='" & lccodana.Trim & "'", 2)

    '        lnrecsan = ecreditos.ObtieneDatos(dsrecuperaCas, "ccondic ='S' and ccodana='" & lccodana.Trim & "'", 3)

    '        lnsalconI = ecreditos.ObtieneDatos(dssaldos, "ccondic <> 'S' and ctipmet = '01' and ccodana='" & lccodana.ToString & "'", 4)
    '        lnsalconG = ecreditos.ObtieneDatos(dssaldos, "ccondic <> 'S' and ctipmet <> '01' and ccodana='" & lccodana.ToString & "'", 4)
    '        lnsalcon = lnsalconI + lnsalconG 'ecreditos.ObtieneDatos(dssaldos, "ccondic<>'S'  and ccodana='" & lccodana.ToString & "'", 4)

    '        lnsalcas = ecreditos.ObtieneDatos(dssaldos, "ccondic ='S' and ccodana='" & lccodana.Trim & "'", 2)

    '        fila("nindnue") = lnindnue
    '        fila("nindre") = lnindre
    '        fila("ngrunue") = lngrunue
    '        fila("ngrure") = lngrure
    '        fila("nsaldo") = lnsaldo
    '        fila("nsaldoR") = lnsaldoR
    '        fila("nrecsan") = lnrecsan

    '        fila("nsalconI") = lnsalconI
    '        fila("nsalconG") = lnsalconG
    '        fila("nsalcas") = lnsalcas
    '        fila("nsalcon") = lnsalcon

    '        'Nuevos Créditos p/Cliente Individual (Q) 
    '        If cmbtipo.SelectedValue.Trim = 1 Or cmbtipo.SelectedValue.Trim = 2 Then 'Para Asesor
    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "01")
    '            fila("incentivo1") = Math.Round(lnindnue * lnfactor, 2)
    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "02")
    '            fila("incentivo2") = Math.Round(lnindre * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "03")
    '            fila("incentivo3") = Math.Round(lngrunue * lnfactor, 2)
    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "04")
    '            fila("incentivo4") = Math.Round(lngrure * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "05")
    '            fila("incentivo5") = Math.Round(Math.Round((lnsaldo - lnsaldoR) / 1000, 0) * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "07")
    '            lnpenala = Math.Round(Math.Round(lnsalconI / 1000, 0) * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("162", "08")
    '            lnpenalb = Math.Round(Math.Round(lnsalconG / 1000, 0) * lnfactor, 2)

    '            fila("penal1") = lnpenala + lnpenalb

    '            If lnsaldo + lnsalcas = 0 Then
    '                lnfacCar = 0
    '            Else
    '                lnfacCar = Math.Round(lnsalcas / (lnsaldo + lnsalcas) * 100, 2)
    '            End If
    '            lnpenal2 = clsppal.Porcentaje_Rango(lnfacCar)
    '            fila("porcas") = lnpenal2



    '            If cmbtipo.SelectedValue.Trim = 2 Then
    '                fila("porsecre") = etabttab.ObtenerFactor("163", "01")
    '            End If
    '        Else 'jefes de agencia
    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "01")
    '            fila("incentivo1") = Math.Round(lnindnue * lnfactor, 2)
    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "02")
    '            fila("incentivo2") = Math.Round(lnindre * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "03")
    '            fila("incentivo3") = Math.Round(lngrunue * lnfactor, 2)
    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "04")
    '            fila("incentivo4") = Math.Round(lngrure * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "05")
    '            fila("incentivo5") = Math.Round(Math.Round((lnsaldo - lnsaldoR) / 1000, 0) * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "07")
    '            lnpenala = Math.Round(Math.Round(lnsalconI / 1000, 0) * lnfactor, 2)

    '            lnfactor = 0
    '            lnfactor = etabttab.ObtenerFactor("165", "08")
    '            lnpenalb = Math.Round(Math.Round(lnsalconG / 1000, 0) * lnfactor, 2)

    '            fila("penal1") = lnpenala + lnpenalb

    '            If lnsaldo + lnsalcas = 0 Then
    '                lnfacCar = 0
    '            Else
    '                lnfacCar = Math.Round(lnsalcas / (lnsaldo + lnsalcas) * 100, 2)
    '            End If
    '            lnpenal2 = clsppal.Porcentaje_Rango(lnfacCar)
    '            fila("porcas") = lnpenal2

    '            If cmbtipo.SelectedValue.Trim = 3 Then
    '                fila("porsupreg") = etabttab.ObtenerFactor("164", "01")
    '            End If
    '        End If


    '    Next
    'Dim dsinfo As New DataSet
    'Dim dt As New DataTable
    '    dt = clsppal.FiltraTabla(ds.Tables(0), "nindnue<>0 or nindre <> 0 or ngrunue <> 0 or ngrure <> 0 or nsaldo<>0 or nsalcas<>0 ")
    '    dsinfo.Tables.Add(dt)

    '    Return dsinfo
    'End Function
    'Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
    '    Try
    '        If dsbase Is Nothing Then
    '            Me.AsignarMensaje("Error al obtener informacion del reporte", True)
    '            Return
    '        Else
    '            If dsbase.Tables(0).Rows.Count = 0 Then
    '                Me.AsignarMensaje("No se encontro información a ser desplegada")
    '            Return
    '        End If
    '    End If
    'Catch ex As Exception
    '    Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
    '    Return
    'End Try

    'Dim crRpt As New ReportDocument
    'Dim rptStream As New System.IO.MemoryStream

    'Try
    '    'Cargar Definicion del Reporte
    '    crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

    'Catch ex As Exception
    '    Return
    'End Try
    'crRpt.SetDataSource(dsbase.Tables(0))
    ''Nombre de la Institución
    'Dim lcNomofi As String = "FUNDEA"
    'Dim ldfecha1 As Date
    'Dim ldfecha2 As Date
    'ldfecha1 = Date.Parse(Me.txtdesde.Text.Trim)
    'ldfecha2 = Date.Parse(Me.txthasta.Text.Trim)


    'crRpt.SetDataSource(dsbase.Tables(0))

    'crRpt.SetParameterValue("dfecha1", ldfecha1)
    'crRpt.SetParameterValue("dfecha2", ldfecha2)
    'crRpt.SetParameterValue("cNomOfi", lcNomofi)

    'Dim tipo As String
    ''If lcexportar = "XLS2" Then
    ''    Me.ExportToExcel(dsbase.Tables(0))
    ''Else

    'tipo = "application/pdf"
    'reportes &= ".pdf"
    'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
    'Response.Clear()
    'Response.Buffer = True
    'Response.ContentType = tipo


    ''Automaticamente se descarga el archivo
    'Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

    'Response.BinaryWrite(rptStream.ToArray())
    'Response.End()

    'End Sub
    'Private Sub CargarArchivoExcel(ByVal ds As DataSet)

    '    Dim oExcel As Object
    '    Dim oBook As Object
    '    Dim oSheet As Object

    '    'Iniciar un nuevo libro en Excel. 
    '    oExcel = CreateObject("Excel.Application")
    '    oBook = oExcel.Workbooks.Add

    '    'Agregar datos a las celdas de la primera hoja de cálculo del libro nuevo.
    '    oSheet = oBook.Worksheets(1)
    '    oSheet.cells(3, 1).value = "Orden"
    '    oSheet.cells(3, 2).value = "Nombre/Empleado"
    '    ' oSheet.Range("A1:B1").Font.Bold = True
    '    oSheet.cells(3, 3).value = "Puesto"
    '    oSheet.cells(3, 4).value = "Agencia"

    '    oSheet.cells(1, 5).value = "Clientes"
    '    oSheet.cells(2, 5).value = "Nuevos Créditos Ind."
    '    oSheet.cells(3, 5).value = "Cumplimiento"
    '    oSheet.cells(3, 6).value = "Total"

    '    oSheet.cells(1, 7).value = "Clientes"
    '    oSheet.cells(2, 7).value = "Re-Créditos Ind."
    '    oSheet.cells(3, 7).value = "Cumplimiento"
    '    oSheet.cells(3, 8).value = "Total"

    '    oSheet.cells(1, 9).value = "Clientes"
    '    oSheet.cells(2, 9).value = "Nuevos Créditos Gru."
    '    oSheet.cells(3, 9).value = "Cumplimiento"
    '    oSheet.cells(3, 10).value = "Total"

    '    oSheet.cells(1, 11).value = "Clientes"
    '    oSheet.cells(2, 11).value = "Re-Créditos Gru."
    '    oSheet.cells(3, 11).value = "Cumplimiento"
    '    oSheet.cells(3, 12).value = "Total"

    '    oSheet.cells(3, 13).value = "Saldo de Cartera"
    '    oSheet.cells(3, 14).value = "Cartera Reestructurada"
    '    oSheet.cells(3, 15).value = "Cumplimiento"

    '    oSheet.cells(2, 18).value = "Incentivo sin Penalización"
    '    oSheet.cells(3, 18).value = "(TOTAL)"

    '    oSheet.cells(2, 19).value = "Cartera en Riesgo"
    '    oSheet.cells(3, 19).value = "Saldo Contaminado"
    '    oSheet.cells(3, 20).value = "Penalización"

    '    oSheet.cells(2, 21).value = "Incentivos (SUB-TOTAL)"

    '    oSheet.cells(2, 22).value = "Cartera Castigada"
    '    oSheet.cells(3, 22).value = "Monto Cartera Castigada"
    '    oSheet.cells(3, 23).value = "% del Castigo"
    '    oSheet.cells(3, 24).value = "Penalización"

    '    oSheet.cells(2, 26).value = "Incentivos con Penalización"
    '    oSheet.cells(3, 26).value = "(GRAN-TOTAL)"

    '    If cmbtipo.SelectedValue.Trim = 2 Then
    '        oSheet.cells(2, 28).value = "Incentivo"
    '        oSheet.cells(3, 28).value = "Secretaria"
    '    End If

    '    If cmbtipo.SelectedValue.Trim = 3 Then
    '        oSheet.cells(2, 28).value = "Incentivo"
    '        oSheet.cells(3, 28).value = "Supervisores Regionales"
    '    End If

    '    oSheet.Range("A1:X3").Font.Bold = True

    '    '  oSheet.Range("B2").Value = "Juan"
    '    Dim i As Integer = 0
    '    Dim lnfila As Integer = 4
    '    Dim lnpenal2 As Decimal = 0
    '    Dim etabtofi As New cTabtofi
    '    For Each fila As DataRow In ds.Tables(0).Rows
    '        i += 1
    '        oSheet.cells(lnfila, 1).value = i
    '        oSheet.cells(lnfila, 2).value = fila("nombre")
    '        oSheet.cells(lnfila, 3).value = fila("ccatego")
    '        oSheet.cells(lnfila, 4).value = "'" & etabtofi.ObtenerRegiondeOficina(fila("ccodofi"))

    '        oSheet.cells(lnfila, 5).value = fila("nindnue")
    '        oSheet.cells(lnfila, 6).value = fila("incentivo1")
    '        oSheet.cells(lnfila, 7).value = fila("nindre")
    '        oSheet.cells(lnfila, 8).value = fila("incentivo2")

    '        oSheet.cells(lnfila, 9).value = fila("ngrunue")
    '        oSheet.cells(lnfila, 10).value = fila("incentivo3")
    '        oSheet.cells(lnfila, 11).value = fila("ngrure")
    '        oSheet.cells(lnfila, 12).value = fila("incentivo4")

    '        oSheet.cells(lnfila, 13).value = fila("nsaldo")
    '        oSheet.cells(lnfila, 14).value = fila("nsaldoR")
    '        oSheet.cells(lnfila, 15).value = fila("incentivo5")

    '        oSheet.cells(lnfila, 18).value = (fila("incentivo1") + fila("incentivo2") + fila("incentivo3") + fila("incentivo4") + fila("incentivo5"))

    '        oSheet.cells(lnfila, 19).value = fila("nsalcon")
    '        oSheet.cells(lnfila, 20).value = fila("penal1")

    '        oSheet.cells(lnfila, 21).value = (fila("incentivo1") + fila("incentivo2") + fila("incentivo3") + fila("incentivo4") + fila("incentivo5") - fila("penal1"))

    '        oSheet.cells(lnfila, 22).value = fila("nsalcas")
    '        oSheet.cells(lnfila, 23).value = fila("porcas")
    '        lnpenal2 = Math.Round(fila("nsalcas") * fila("porcas") / 100, 2)
    '        oSheet.cells(lnfila, 24).value = lnpenal2

    '        oSheet.cells(lnfila, 26).value = (fila("incentivo1") + fila("incentivo2") + fila("incentivo3") + fila("incentivo4") + fila("incentivo5") - fila("penal1") - lnpenal2)

    '        If cmbtipo.SelectedValue.Trim = 2 Then
    '            oSheet.cells(lnfila, 28).value = Math.Round((fila("incentivo1") + fila("incentivo2") + fila("incentivo3") + fila("incentivo4") + fila("incentivo5") - fila("penal1") - lnpenal2) * fila("porsecre") / 100, 2)
    '        End If
    '        If cmbtipo.SelectedValue.Trim = 3 Then
    '            oSheet.cells(lnfila, 28).value = Math.Round((fila("incentivo1") + fila("incentivo2") + fila("incentivo3") + fila("incentivo4") + fila("incentivo5") - fila("penal1") - lnpenal2) * fila("porsupreg") / 100, 2)
    '        End If
    '        lnfila += 1
    '    Next

    '    Try
    '        'Guardar el libro y cerrar Excel. 
    '        oBook.SaveAs("C:\txt\Excel\Incentivos.xls")
    '        oSheet = Nothing
    '        oBook = Nothing
    '        oExcel.Quit()
    '        oExcel = Nothing
    '        GC.Collect()
    '    Catch ex As Exception
    '        Response.Write("<script language='javascript'>alert('Problema al Generar Archivo')</script>")
    '    End Try


    '    Try
    '        Dim FilePath As String = "C:\txt\Excel\Incentivos.xls"
    '        Dim lcnombre As String
    '        lcnombre = "Incentivos.xls"
    '        Me.DownloadFile(FilePath, lcnombre.Trim)
    '    Catch ex As Exception
    '        Response.Write("<script language='javascript'>alert('Problema al Abrir Archivo')</script>")
    '    End Try



    'End Sub
    'Private Sub DownloadFile(ByVal filepath As String, ByVal name As String)
    '    Dim XL As New Excel.Application 'Crea el objeto excel
    '    XL.Workbooks.Open(filepath, , True) 'El true es para abrir el archivo en modo Solo lectura (False si lo quieres de otro modo)
    '    XL.Visible = True

    'End Sub


End Class


