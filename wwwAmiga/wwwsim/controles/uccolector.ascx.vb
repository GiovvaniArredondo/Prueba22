Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Collections.Generic
Imports Zen.Barcode
Imports System.Drawing

Partial Class uccolector
    Inherits ucWBase


#Region "Private"
    Private clsppal As New class1
    Private codigoJs As String
    Private clsConvert As New ConversionLetras
    Private mTabtbco As New cTabtbco
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub


    Public Sub CargarPorCliente(ByVal codigocuenta As String)
        Me.txtcredito.Text = codigocuenta
        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        Dim lcnrolin As String
        Dim lcbarra As String
        Dim lncuota As Decimal 'debe permanecer en decimal
        Dim ecredppg As New cCredppg

        ecreditos.ccodcta = codigocuenta
        mcreditos.Obtenercreditos(ecreditos)
        Me.txtnombre.Text = ecreditos.cnomcli.Trim
        lcnrolin = ecreditos.cnrolin
        'lncuota = ecreditos.nmoncuo 'clsppal.ValorCuota(codigocuenta)
        lncuota = ecredppg.CapitalInteres(codigocuenta)
        HiddenField1.Value = ecreditos.ccodcli
        HiddenField2.Value = ecreditos.ccodlin.Substring(2, 2)

        clsppal.gnperbas = Session("gnperbas")
        clsppal.pnComtra = Session("gnComTra")
        If ecreditos.dfecvig >= #7/11/2008# Then
            clsppal.pnSegVm = Session("gnSegVm1")
        Else
            clsppal.pnSegVm = Session("gnSegVm")
        End If

        clsppal.cNrolin = lcnrolin


        Me.txtcuota.Text = lncuota
        Me.txtdfecvig.Text = ecreditos.dfecvig
        btnImprime.Enabled = True
        '  Me.BarcodeProfessional1.Code = lcbarra



    End Sub


    '  funcion que traduce el codigo de barra
    Function _StrTo128C(ByVal tcString) As String

        Dim lcStart, lcStop, lcCheck, lcCar, lnI, lnCheckSum, lnAsc, Fn1, pares, valorMod
        Dim lnLong As Long
        Dim lnresiduo As Long
        Dim lnnumero As Long
        Dim lcRet As String

        lcStart = Chr(105 + 32)
        Fn1 = Chr(102 + 32)
        lcStop = Chr(106 + 32)
        lnCheckSum = 207
        pares = 2

        lcRet = tcString.trim
        lnLong = Len(lcRet)


        '*--- La longitud debe ser par
        lnnumero = Math.DivRem(lnLong, 2, lnresiduo)
        '     IF MOD(lnLong,2) # 0
        If lnresiduo <> 0 Then
            lcRet = "0" + lcRet
            lnLong = Len(lcRet)
        End If

        '	*--- Convierto los pares a caracteres

        lcCar = ""
        For lnI = 0 To lnLong - 1 Step 2
            'lcCar = lcCar + Chr(Val(SUBS(lcRet, lnI, 2)) + 32)
            lcCar = lcCar + Chr(Val((lcRet.Substring(lnI, 2))) + 32)
            lcCar = lcCar
            lnCheckSum = lnCheckSum + (Int(Val((lcRet.Substring(lnI, 2)))) * pares)
            pares = pares + 1
        Next lnI

        lcRet = lcCar
        lnnumero = Math.DivRem(lnCheckSum, 103, lnresiduo)

        valorMod = lnresiduo 'MOD(lnCheckSum,103)
        If valorMod < 95 And valorMod > 0 Then
            lcCheck = Chr(valorMod + 32)
        Else
            If valorMod > 94 Then
                lcCheck = Chr(valorMod + 100)
            Else
                If valorMod = 0 Then
                    lcCheck = Chr(232)
                End If
            End If
        End If

        lcRet = lcStart + Fn1 + lcRet + lcCheck + lcStop
        lnLong = Len(lcRet)


        lcRet = lcRet.Replace(Chr(32), Chr(232))
        lcRet = lcRet.Replace(Chr(127), Chr(192))
        lcRet = lcRet.Replace(Chr(128), Chr(193))

        Return lcRet

    End Function


    Private Function Genera_Codigo_Verificador(ByVal ccodigo As String) As String

        Dim lcCodigo As String = ""


        Return lcCodigo
    End Function
    Public Shared Function ImageTable(ByVal ImageFile As String) As DataTable
        Dim data As New DataTable
        Dim row As DataRow
        data.TableName = "Images"
        data.Columns.Add("imagenes", System.Type.GetType("System.Byte[]"))


        Dim _Buffer() As Byte = Nothing

        Try
            ' Open file for reading
            Dim _FileStream As New System.IO.FileStream(ImageFile, System.IO.FileMode.Open, System.IO.FileAccess.Read)

            ' attach filestream to binary reader
            Dim _BinaryReader As New System.IO.BinaryReader(_FileStream)

            ' get total byte length of the file
            Dim _TotalBytes As Long = New System.IO.FileInfo(ImageFile).Length

            ' read entire file into buffer
            _Buffer = _BinaryReader.ReadBytes(CInt(Fix(_TotalBytes)))

            ' close file reader
            _FileStream.Close()
            _FileStream.Dispose()
            _BinaryReader.Close()
            row = data.NewRow()
            row("imagenes") = _Buffer
            data.Rows.Add(row)

        Catch _Exception As Exception

            Console.WriteLine("Error al procesar la imagen del barcode: {0}", _Exception.ToString())
        End Try

        Return data

    End Function


    Protected Sub btnImprime_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprime.Click

        Dim Cad_Credito, ccodpart1, ccodpart2, ccodpart3, ccodpart4, ccodpart5 As String
        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

        Catch ex As Exception
            Return
        End Try

        Dim reportes As String
        reportes = "Carnet.pdf"

        Dim lccodcta As String
        Dim lcnomcli As String
        Dim lncuota As Double
        Dim lcbarra As String
        Dim lcbarra2 As String
        Dim ldfecvig As String
        Dim lccodcli As String
        Dim lccuota As String
        Dim lnEntero As Integer
        Dim lcdecimal As String
        Dim pcMonto_Total As String = ""
        Dim lntamano As Integer
        Dim lndecimal As Integer
        Dim img As Image = Nothing
        Dim n As Integer
        Dim lncuota2 As Double = 0
        Dim lncomision As Integer = 0
        Dim lcCodbco As String = ""
        Dim lcreferencia_Bco As String = ""
        Dim lcBarraClon As String = ""
        Dim strg_lncouta As String = Me.txtcuota.Text



        lncomision = Session("GNCOMISION")


        If Not IsNumeric(lncomision) Then
            codigoJs = "<script language='javascript'>alert('Valor de Comisión Invalida, Inicie session de nuevo, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Exit Sub
        End If

        ldfecvig = Date.Parse(Me.txtdfecvig.Text.Trim)
        lcnomcli = Me.txtnombre.Text.Trim
        lncuota = Double.Parse(Me.txtcuota.Text)


        lncuota2 = lncuota + lncomision

        lccodcta = Me.txtcredito.Text.Trim
        '        lcbarra = "*41500000000042808020" & lccodcta & "*"



        '''''''''''''Fernando Abrego 06/02/2015 divide en subcadenas el codigo de credito ''''''''''''''''''''''''
        ccodpart1 = Microsoft.VisualBasic.Left(lccodcta, 5)
        ccodpart2 = lccodcta.Substring(5, 5)
        ccodpart3 = lccodcta.Substring(10, 5)
        ccodpart4 = lccodcta.Substring(15, 3)
        ccodpart5 = lccodcta.Substring(15, 3) & "00"
        '''''''''''''''''''Fernando Abrego 06/02/2015 ''''''''''''''''''''

        lcreferencia_Bco = clsppal.zeros_Derecha(lccodcta, 20)

        lnEntero = Math.Truncate(lncuota)
        'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

        lndecimal = clsConvert.ExtraeDecimales(lncuota.ToString.Trim)

        'Convertira a 2 digitos los decimales
        lcdecimal = lndecimal.ToString.Trim
        lntamano = lcdecimal.Length
        'For n = 1 To 2 - lntamano
        '    lcdecimal = "0" + lcdecimal
        'Next n

        lcdecimal = clsppal.zeros_Derecha(lcdecimal, 2)

        'Dim re_contador As Integer
        'Dim revision As String
        'Dim result As String
        'Dim caracteres_inval As String = "."
        'Dim almacenador As String

        ''Convertira a 2 digitos los decimales

        ''-- =============================================
        ''-- Author:         <FERNANDO ABREGO RDZ>
        ''-- Create date: <28/04/2015>
        ''-- Description:  <Convertira a 2 digitos los decimales>
        ''-- Eventos:        <.....>
        ''-- Fuciones:      <NO RECUERDO>
        ''-- Procesos:      <.....>
        ''-- =============================================
        'lcdecimal = lndecimal.ToString.Trim
        'lntamano = lcdecimal.Length
        'For n = 1 To 2 - lntamano
        '    lcdecimal = "0" + lcdecimal 'obtiene los decimales y le agrega cero
        '    result = lncuota 'Toma el valor de la cuota
        '    For re_contador = 1 To Len(result) 'lee cadena segun el contador
        '        revision = (Mid(result, re_contador, 1))
        '        If caracteres_inval.Contains(revision) Then
        '            Exit For
        '        Else
        '            almacenador = almacenador + revision 'almacena los valores validos hasta el punto
        '        End If
        '    Next
        '    almacenador = almacenador & "." & lcdecimal
        '    lncuota = almacenador 'pasa valor a lncouta que es la que se muestra en el carnet
        'Next n

        lccuota = lnEntero.ToString.Trim + lcdecimal

        lccuota = clsppal.fxStrZero(lccuota.Trim, 6)

        ''-- =============================================
        ''-- Author:         <FERNANDO ABREGO RDZ>
        ''-- Create date: <02/06/2015>
        ''-- Description:  <Obtiene valor original de la base de datos>
        ''-- Eventos:        <.....>
        ''-- Fuciones:      <NO RECUERDO>
        ''-- Procesos:      <.....>
        ''-- =============================================

        Dim str_replazo As String = strg_lncouta.Replace(".", "")
        str_replazo = "0" & str_replazo

        'Adiciona Valor para cobro Paynet
        'lcbarra = Digito_Verificador("00003M", lccodcta, lccuota)
        lcbarra = Digito_Verificador("000123", lccodcta, lccuota)
        lcBarraClon = lcbarra

        '        lcbarra2 = "*41500000000042808020" & lccodcta & "*"
        lccodcli = HiddenField1.Value.Trim

        lcCodbco = mTabtbco.ObtenerCuenta_Oficina(Session("gccodofi"), "PA")

        lcbarra2 = _StrTo128C(lcBarraClon)

        Dim sPath As String = "C:\barcodes\" & lccodcta & ".jpg"


        img = GetBarcodeImage(lcbarra)
        img.Save(sPath)

        'partir en bloques la linea de captura para facilitar lectura
        Dim lcbarraEspaciada As String
        lcbarraEspaciada = ""

        For n = 0 To Len(lcbarra) - 1
            If n Mod 5 = 0 And n > 1 Then
                lcbarraEspaciada += lcbarra.Chars(n) & " "
            Else
                lcbarraEspaciada += lcbarra.Chars(n)

            End If
        Next n
        lcbarra = lcbarraEspaciada



        'cambio en lugar de variable Me.txtcuota.Text
        Try
            Dim dt As DataTable
            dt = Nothing
            dt = ImageTable(sPath)

            crRptIA.Load(Server.MapPath("reportes") + "\crcolector.rpt")
            crRptIA.Database.Tables.Item("Images").SetDataSource(dt)
            crRptIA.SetParameterValue("lccodcta", (lccodcta.Trim & HiddenField2.Value.Trim))
            crRptIA.SetParameterValue("lcbarra", lcbarra)
            crRptIA.SetParameterValue("lncuota", Convert.ToDecimal(Me.txtcuota.Text))
            crRptIA.SetParameterValue("lncuota2", Convert.ToDecimal(Me.txtcuota.Text))
            crRptIA.SetParameterValue("lcnomcli", lcnomcli)
            crRptIA.SetParameterValue("lcbarra2", lcbarra2)
            crRptIA.SetParameterValue("ldfecvig", ldfecvig)
            crRptIA.SetParameterValue("pccodcli", lccodcli)
            crRptIA.SetParameterValue("pccodbco", lcCodbco)
            crRptIA.SetParameterValue("pcRefencia", lcreferencia_Bco)
            crRptIA.SetParameterValue("part1", ccodpart1)
            crRptIA.SetParameterValue("part2", ccodpart2)
            crRptIA.SetParameterValue("part3", ccodpart3)
            crRptIA.SetParameterValue("part4", ccodpart4)
            crRptIA.SetParameterValue("part5", ccodpart5)

            rptStreamIA = CType(crRptIA.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
            Response.Clear()
            Response.Buffer = True
            ' Establece el tipo de documento
            Response.ContentType = "application/pdf"
            Response.BinaryWrite(rptStreamIA.ToArray())
            Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)

        Catch ex As Exception
            MsgBox("Error al generar carnet de pagos", , "Ha ocurrido un error, Reporte a Sistemas")

        End Try



    End Sub


    Private Function Digito_Verificador(ByVal issuer As String, ByVal pcCodcta As String, _
                                        ByVal pcMonto As String) As String

        Dim generador As RUgen.RUGenerator = New RUgen.RUGenerator
        Dim params As List(Of RUgen.Parameter) = New List(Of RUgen.Parameter)
        Dim CodigoPaynet As String = ""


        params.Add(New RUgen.Parameter With {.Name = "NOCREDITO", .Value = ""})
        params.Add(New RUgen.Parameter With {.Name = "MONTO", .Value = ""})

        params.Item(0).Value = pcCodcta
        params.Item(1).Value = pcMonto

        CodigoPaynet = generador.CreateRU(issuer, params.ToArray)

        Return CodigoPaynet


    End Function


    'Convierte el Texto en Barras
    Private Function GetBarcodeImage(ByVal text As String) As Image

        If String.IsNullOrEmpty(text) Then
            Throw New ArgumentException("Must have text to render as barcode.")
        End If

        Dim drawObject As BarcodeDraw = BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128)

        Return drawObject.Draw(text, New BarcodeMetrics() With {.MinWidth = 1, _
                                                                .MinHeight = 10, _
                                                                .MaxHeight = 40, _
                                                                .MaxWidth = 10, _
                                                                .InterGlyphSpacing = 0.5})
    End Function


End Class


