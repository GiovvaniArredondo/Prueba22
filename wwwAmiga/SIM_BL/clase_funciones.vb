Imports System.Math
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.IO
Imports System.IO.StreamReader
Imports System.IO.StreamWriter
Imports System.Globalization.CultureInfoF
Imports System.Globalization
Imports System.Net

Public Class clase_funciones

    Public Function dia_ultimo_mes(ByVal fecha As Date) As String
        Dim mes As String = Month(fecha).ToString, diafin As String, ano As Integer = Year(fecha)
        If mes.Length = 1 Then
            mes = "0" & mes
        End If
        If mes = "01" Or mes = "03" Or mes = "05" Or mes = "07" Or mes = "08" Or mes = "10" Or mes = "12" Then
            diafin = "31"
        Else
            diafin = "30"
        End If
        If mes = "02" Then
            diafin = ano_bisiesto(ano).ToString
        End If

        Return diafin

    End Function

    Public Function calcular_mora_aportaciones_fecha(ByVal con As SqlConnection, ByVal ccodcli As String, ByVal fecha_tope As Date) As Decimal
        Dim error100 As Integer = 0
        Dim saldo_hay As Decimal = 0, condonado As Decimal = 0, deberia As Decimal = 0, mora As Decimal = 0
        Dim fec_ini As Date, ccodaho As String = ""
        Dim str_select As String
        Dim tabla As New DataTable
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        str_select = "set language spanish; select ccodaho, dfecapr, nsaldoaho " & _
                            "from ahomcta where substring(ccodaho,7,2) = '06' and cnudotr = " & miclase1.ToString(ccodcli)
        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)

        Dim ds As New DataSet()

        'para saber el saldo actual
        Try
            adapter.Fill(ds, "tabla")
        Catch ex As Exception
            error100 = -100
        End Try

        'saldo de lo que tiene
        tabla = ds.Tables("tabla")
        Dim fila As DataRow
        For Each fila In tabla.Rows
            saldo_hay = fila("nsaldoaho")
            fec_ini = fila("dfecapr")
            ccodaho = fila("ccodaho")
        Next

        'lo condonado
        str_select = "select sum(mora) from condonacion_mora where ccodcli = " & miclase1.ToString(ccodcli)
        condonado = Decimal.Parse(miclase.devolver_scalar1(con, str_select))

        'trae todos los movimientos menores a la fecha tope
        str_select = "select dfecope, nsaldoaho from ahommov where ccodaho = " & miclase1.ToString(ccodaho) & " order by dfecope"
        Dim adapter1 As New SqlClient.SqlDataAdapter(str_select, con)
        ds.Clear()
        tabla.Clear()

        'para saber todos los moviemtos
        Try
            adapter1.Fill(ds, "tabla")
        Catch ex As Exception
            error100 = -100
        End Try
        tabla = ds.Tables("tabla")

        Dim cuantos = tabla.Rows.Count()

        Dim inicio As Integer = 0
        Dim fecha_prox As Date
        For Each fila In tabla.Rows
            If inicio = 0 Then
                fec_ini = fila("dfecope")
            End If
            inicio = 1
            fecha_prox = fila("dfecope")

            If fecha_prox > fecha_tope Then
                Exit For
            End If
            saldo_hay = fila("nsaldoaho")
        Next

        'recorre mensualmente para saber lo que deberia tener en teoria
        While fec_ini < fecha_tope

            'ojo mm-dd-yyyy
            If fec_ini >= #12/20/1971# And fec_ini <= #3/31/1992# Then
                deberia = deberia + 1.14
            End If
            If fec_ini >= #4/1/1992# And fec_ini <= #2/28/2002# Then
                deberia = deberia + 2.29
            End If
            If fec_ini >= #3/1/2002# And fec_ini <= #4/30/2009# Then
                deberia = deberia + 2.86
            End If
            If fec_ini >= #5/1/2009# Then
                deberia = deberia + 4.0
            End If

            fec_ini = DateAdd(DateInterval.Month, 1, fec_ini)

        End While

        mora = (saldo_hay + condonado) - deberia
        If mora < 0 Then
            mora = Abs(mora)
        Else
            mora = 0
        End If

        adapter.Dispose()
        adapter1.Dispose()

        mora = 0
        Return mora

    End Function

    Public Overloads Function fxStevo(ByVal fecha As Date) As String
        Dim clase As New crefunc
        Dim lcnumcom As String = ""
        lcnumcom = clase.fxStevo(fecha)

        Return lcnumcom
        'Dim miclase As New clase_especial
        'Dim miclase1 As New clase_funciones
        'Dim ds As New DataSet
        'Dim dt As New DataTable
        'Dim mes = CStr(DatePart(DateInterval.Month, fecha))

        'If mes.Length = 1 Then
        '    mes = "0" & mes
        'End If
        'Dim cnumcom As String = ""
        'Dim con As New SqlConnection
        'Dim stringconnection As String = miclase.conexion()
        'con.ConnectionString = stringconnection
        'con.Open()

        'Dim str_select As String = "select numes, cnumcom from cnumes where numes = " & miclase1.ToString(mes)
        'ds = miclase.devolver_dataset(con, str_select)
        'dt = ds.Tables("tabla")
        'Dim fila As DataRow
        'For Each fila In dt.Rows
        '    cnumcom = CStr(Int32.Parse(fila("cnumcom")) + 1)
        'Next
        'If cnumcom.Length = 7 Then
        '    cnumcom = "0" & cnumcom
        'End If
        'str_select = "update cnumes set cnumcom=" & miclase1.ToString(cnumcom) & " where numes = " & miclase1.ToString(mes)
        'miclase.nonquery_sin_parametros(con, str_select)
        'If con Is Nothing Then
        '    con.Close()
        'End If
        'Return cnumcom
    End Function
    Public Overloads Function fxStevo(ByVal fecha As Date, ByVal con As SqlConnection) As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim dt As DataTable
        Dim mes = CStr(DatePart(DateInterval.Month, fecha))

        If mes.Length = 1 Then
            mes = "0" & mes
        End If
        Dim cnumcom As String = ""

        Dim str_select As String = "select numes, cnumcom from cnumes where numes = " & miclase1.ToString(mes)
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        Dim fila As DataRow
        For Each fila In dt.Rows
            cnumcom = CStr(Int32.Parse(fila("cnumcom")) + 1)
        Next
        If cnumcom.Length = 7 Then
            cnumcom = "0" & cnumcom
        End If
        str_select = "update cnumes set cnumcom=" & miclase1.ToString(cnumcom) & " where numes =" & miclase1.ToString(mes)
        miclase.nonquery_sin_parametros(con, str_select)
        Return cnumcom
    End Function

    'recibe dd/mm/yyyy y devuelve yyyy/mm/dd
    Public Function transformar_fecha(ByVal fecha As Date) As String
        Dim fec As String = Left(fecha.ToString, 10)
        Return fec
    End Function

    'recibe dd/mm/yyyy y devuelve mm/dd/yyyy
    Public Function transformar_fecha_dmy_to_mdy(ByVal fecha As Date) As Date
        Return fecha
    End Function
    'recibe mm/dd/yyyy y devuelve dd/mm/yyyy
    Public Function transformar_fecha_mdy_to_dmy(ByVal fecha As String) As String
        Return fecha
    End Function
    Public Function tipo_cuenta_ahorro(ByVal cuenta As String) As String
        Dim con As New SqlConnection
        Dim miclase As New clase_especial
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection
        Dim str_select As String = ""
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        con.Open()

        Dim tipo As String = ""
        If cuenta.Trim = "" Then
        Else
            tipo = cuenta.Substring(6, 2)
        End If

        Dim tipo_cuenta As String = ""

        str_select = "select cnomtrs from ahomtrs where ccodtrs = " & tipo
        ds = miclase.devolver_dataset(con, str_select)
        con.Close()
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            tipo_cuenta = fila("cnomtrs")
        Next

        Return tipo_cuenta

    End Function
    Public Function codigo_parentesco(ByVal parentesco As String) As String
        Dim con As New SqlConnection
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection
        Dim str_select As String = ""
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        con.Open()

        parentesco = miclase1.ToString(parentesco.Trim)
        Dim cparent As String = ""

        str_select = "select cparent from parent where cdescri = " & parentesco
        ds = miclase.devolver_dataset(con, str_select)
        con.Close()
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            cparent = fila("cparent")
        Next

        Return cparent

    End Function

    Public Function ano_bisiesto(ByVal ano As Integer) As Integer
        If ((ano Mod 4) = 0) And ((ano Mod 100) <> 0 Or (ano Mod 400) = 0) Then
            Return 29
        Else
            Return 28
        End If
    End Function
    Public Function ConversionEnteros(ByVal nnumero As Double) As String

        Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
        Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
        Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                    "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
        Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
        Dim num2, letra, auxlinea, ls_decimal As String

        Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer
        Dim dec As String
        Dim temp() As String

        If nnumero = 0 Then
            letra = "CERO "
            Return letra
        End If

        num2 = CStr(Math.Round(nnumero, 2))


        'Modificacion para obtener los decimales daba problemas cuando era cantidad exacta --Alex 19-01-2012
        If nnumero.ToString.Contains(".") Then
            temp = nnumero.ToString.Split(".")
            dec = temp(1)
            'Para rellenar los digitos en caso de que sea 0.5 por ejemplo
            If dec.Length = 1 Then dec = dec + "0"
        Else
            'Si la cantidad es exacta rellenamos con 00 los decimales
            dec = "00"
        End If


        n100000000 = Int(nnumero / 100000000)
        nnumero = nnumero - n100000000 * 100000000
        n10000000 = Int(nnumero / 10000000)
        nnumero = nnumero - n10000000 * 10000000
        n1000000 = Int(nnumero / 1000000)
        nnumero = nnumero - n1000000 * 1000000
        n100000 = Int(nnumero / 100000)
        nnumero = nnumero - n100000 * 100000
        n10000 = Int(nnumero / 10000)
        nnumero = nnumero - n10000 * 10000
        n1000 = Int(nnumero / 1000)
        nnumero = nnumero - n1000 * 1000
        n100 = Int(nnumero / 100)
        nnumero = nnumero - n100 * 100
        n10 = Int(nnumero / 10)
        nnumero = nnumero - n10 * 10
        n = Int(nnumero)

        'real en pb???

        n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
        n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
        n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
        n100000 = CDbl(CStr(Math.Round(n100000, 2)))
        n10000 = CDbl(CStr(Math.Round(n10000, 2)))
        n1000 = CDbl(CStr(Math.Round(n1000, 2)))
        n100 = CDbl(CStr(Math.Round(n100, 2)))
        n10 = CDbl(CStr(Math.Round(n10, 2)))
        n = CDbl(CStr(Math.Round(n, 2)))

        num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))





        nnumero = CDbl(Right(num2, 2))
        '  MILLONES
        If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
            letra = "CIEN "
        Else
            If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
            Else
                letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                If n1000000 <> 0 And n10000000 <> 0 Then
                    letra = letra + "Y "
                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n1000000 + 1)
            End If
        End If
        If letra Is Nothing Or n1000000 <> 0 Then
            If n1000000 = 1 Then
                letra = letra + "MILLON "
            Else
                letra = letra + "MILLONES "
            End If
        End If

        'MILES
        If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
            letra = letra + "CIEN "
        Else
            If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
            Else
                letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                If n1000 <> 0 And n10000 <> 0 Then
                    letra = letra + "Y "
                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n1000 + 1)
            End If
        End If
        If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
            If letra.Trim = "UNO" Then
                letra = "UN MIL "
            Else
                letra = letra + "MIL "
            End If

        End If
        If n100 = 1 And n10 = 0 And n = 0 Then
            letra = letra + "CIEN "
        Else
            If n10 = 1 And n > 0 And n <= 5 Then
                letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
            Else
                letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                If n <> 0 And n10 <> 0 Then
                    Select Case n10
                        Case 1
                            Select Case n
                                Case 6, 7, 8, 9
                                    letra = Left(letra, Len(letra) - 2)
                                    letra = letra + "CI"
                            End Select
                        Case 2
                            letra = Left(letra, Len(letra) - 2)
                            letra = letra + "I"
                        Case Else
                            letra = letra + "Y "
                    End Select

                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n + 1)
                If n = 1 And (n10 = 1 Or n10 = 2) Then
                    letra = Left(letra, Len(letra) - 1)
                    letra = letra
                End If

            End If
        End If


        Dim mynumero As String = (nnumero / 0.01).ToString.Trim
        letra = letra.Trim & " " & dec.Trim & "/100 QUETZALES"


        Return letra
    End Function
    'con_sin = 0- sin aportaciones 1-con aportaciones
    Public Function suma_haberes_reformado(ByVal con As SqlConnection, ByVal cli As String, ByVal con_sin As Integer, ByVal fechita As Date) As Decimal
        'Este calculo es en base a un mes completo, del 1 al ultimo de mes anterior
        If cli = "" Then
            Return 0
        End If

        Dim miclase1 As New clase_funciones

        Dim miclase As New clase_especial
        Dim str_select As String = ""

        Dim fec0 As Date = DateAdd(DateInterval.Month, -1, fechita)
        Dim mes As String = DatePart(DateInterval.Month, fec0).ToString
        Dim ano As Integer = DatePart(DateInterval.Year, fec0)
        Dim diafin As String = ""
        If Len(mes) = 1 Then
            mes = "0" & mes.Trim
        End If

        Dim d_fec1 As Date = DateAdd(DateInterval.Month, -1, fechita)
        Dim s_fec11 As String = d_fec1


        diafin = miclase1.dia_ultimo_mes(fec0)

        Dim s_fec_ini As String = "01/" & mes & "/" & DatePart(DateInterval.Year, fec0).ToString
        Dim s_fec_fin As String = diafin & "/" & mes & "/" & DatePart(DateInterval.Year, fec0).ToString

        Dim d_fec_ini As Date = miclase1.transformar_fecha_dmy_to_mdy(s_fec_ini)
        Dim d_fec_fin As Date = miclase1.transformar_fecha_dmy_to_mdy(s_fec_fin)

        Dim f1 As Date, f2 As Date
        Dim ccodaho As String = ""

        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim dt_cuentas_ahorros As New DataTable
        Dim dt_cuentas_mov As New DataTable
        Dim dt_certificados As New DataTable
        Dim fila_cuenta_ahorros As DataRow = Nothing
        Dim fila_cuenta_mov As DataRow = Nothing
        Dim fila_certificados As DataRow = Nothing

        Dim saldo_ini As Decimal = 0
        Dim saldo_fin As Decimal = 0
        Dim saldo_cert As Decimal = 0
        Dim saldo_certificado As Decimal = 0

        If con_sin = 1 Then
            str_select = "SET LANGUAGE spanish; select ccodaho, cnudotr from ahomcta where cnudotr = " & miclase1.ToString(cli) & " order by ccodaho"
        Else
            str_select = "SET LANGUAGE spanish; select ccodaho, cnudotr from ahomcta where substring(ccodaho,7,2) <> '06' and cnudotr = " & miclase1.ToString(cli) & " order by ccodaho"
        End If
        ds = miclase.devolver_dataset(con, str_select)
        dt_cuentas_ahorros = ds.Tables("tabla")
        '**********************************************************************************************************
        Dim x1 As Integer = dt_cuentas_ahorros.Rows.Count()
        'cuentas de ahorros
        If dt_cuentas_ahorros.Rows.Count > 0 Then

            For Each fila_cuenta_ahorros In dt_cuentas_ahorros.Rows
                ccodaho = fila_cuenta_ahorros("ccodaho")
                If ccodaho = "" Then
                    Continue For
                End If
                ds1.Clear()
                dt_cuentas_mov.Clear()
                str_select = "select ccodaho, dfecope, nnum, nsaldoaho from ahommov where ccodaho = " & miclase1.ToString(ccodaho) & " and " & _
                             "dfecope >=" & miclase1.ToString(s_fec_ini) & " and dfecope <= " & miclase1.ToString(s_fec_fin) & " order by dfecope, nnum"
                ds1 = miclase.devolver_dataset(con, str_select)
                dt_cuentas_mov = ds1.Tables("tabla")

                saldo_ini = 0
                'movimientos de ahorro
                If dt_cuentas_mov.Rows.Count > 0 Then
                    For Each fila_cuenta_mov In dt_cuentas_mov.Rows
                        If fila_cuenta_mov("dfecope") < d_fec_ini Then  'obtiene saldo_inicial
                            saldo_ini = fila_cuenta_mov("nsaldoaho")
                        Else
                            saldo_ini = saldo_ini + fila_cuenta_mov("nsaldoaho") 'acumula saldo del mes
                        End If
                    Next
                End If

                saldo_fin = saldo_fin + saldo_ini  'acumula todos los saldos de todas las cuentas

            Next
        End If

        ds.Clear()
        str_select = "select ccodcrt, cnudotr, dfecori, dfecapr, dultpro, dfecven, cliq, cestado, nmonapr from ahomcrt where cnudotr = " & miclase1.ToString(cli)
        ds = miclase.devolver_dataset(con, str_select)


        dt_certificados = ds.Tables("tabla")
        '**********************************************************************************************************
        'certificados a plazo
        saldo_certificado = 0
        If dt_certificados.Rows.Count > 0 Then
            For Each fila_certificados In dt_certificados.Rows
                If fila_certificados("dultpro") < d_fec_ini Then  'cancelado antes de la fecha inicio analizado
                    Continue For
                End If
                If fila_certificados("dfecori") > d_fec_fin Then  'aperturado despues de la fecha ultima de mes analizado
                    Continue For
                End If

                f1 = d_fec_ini
                If fila_certificados("dultpro") > d_fec_fin Then  'tiene prov. mas alla del ult de mes
                    f2 = d_fec_fin
                Else
                    f2 = fila_certificados("dultpro")  ' se cancelo antes de la fecha ult. de mes
                End If

                saldo_cert = 0
                While f1 <= f2
                    saldo_cert = saldo_cert + fila_certificados("nmonapr")
                    f1 = DateAdd(DateInterval.Day, 1, f1)
                End While

                saldo_certificado = saldo_certificado + saldo_cert

            Next
        End If

        saldo_certificado = Round(saldo_certificado / Integer.Parse(diafin), 2)  'promedios de certificados
        saldo_fin = Round(saldo_fin / Integer.Parse(diafin), 2) 'promedios de ahorros


        Return (saldo_certificado + saldo_fin)  ' suma de promedios

    End Function

    Public Function reforma_fiscal(ByVal con As SqlConnection, ByVal cli As String, ByVal ctaaho As String, _
                                   ByVal no_cert As String, ByVal interes As Decimal, ByVal tothaber As Decimal, _
                                   ByVal ccodusu As String, ByVal dfecsis As Date) As Integer

        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim str_select As String = ""


        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim error100 As Integer = 0

        '******** retira de los ahorros el 10% de interes devengado segun ley 2010
        str_select = "set language spanish; select aho.nnum, cli.cnomcli, aho.nsaldoaho from ahomcta as aho, climide as cli " & _
                     "where aho.ccodaho = " & miclase1.ToString(ctaaho) & " and aho.cnudotr = cli.ccodcli"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        Dim saldo As Decimal, nnum As Integer, nombre As String = ""

        For Each fila In dt.Rows
            saldo = fila("nsaldoaho")
            nnum = fila("nnum")
            nombre = fila("cnomcli")
        Next

        Dim diez As Decimal = Round(interes * 0.1, 2)
        Dim nmonto As Decimal = diez
        Dim no_recibo As String = "FISCAL"
        Dim cnumcom As String = ""
        Dim concepto As String = ""
        Dim socio As String = cli
        Dim num As Integer = 0
        Dim ndebe As Decimal, nhaber As Decimal
        Dim cclase As Char, cta_cajero As String
        cta_cajero = miclase1.cuenta_contable_cajero(ccodusu)
        Dim cta_contable_ahorro As String = cuenta_contable_ahorro(ctaaho) 'llama la funcion 


        nnum = nnum + 1
        If nnum > 65 Then
            nnum = 1
        End If


        '** retira el 10% del interes devengado segun reforma fiscal 2010
        'actualiza la cta de ahorro movimiento ahommov
        Dim cuenta_ahorro As String = ctaaho
        Dim gdfecsis As String = miclase1.transformar_fecha_mdy_to_dmy(dfecsis)
        Dim tipo_cta As String = ctaaho.Substring(6, 2).ToString
        saldo = saldo - diez
        'inserta el movimiento en en la cta de ahorro
        str_select = "SET LANGUAGE spanish; insert into ahommov " & _
                     "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                     "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                     "('" & cuenta_ahorro & "', '" & gdfecsis & "', 'R', '" & no_recibo.ToString & "', 'E', 'RETIRO', 0, ' ', ' ', " & _
                     "'" & gdfecsis & " ', '" & gdfecsis & "', 0, '" & nmonto & "', 0, 'N', " & _
                     nnum & ", '" & gdfecsis & "', '" & ccodusu & "', " & nnum & ", ' ', " & saldo & ", " & saldo & ", 'RT', " & _
                     "'" & tipo_cta & "', ' ', 0, ' ', 0)"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        'actualiza la cabecera de ahorros
        str_select = " update ahomcta set nsaldoaho=" & saldo & ", nsaldnind=" & saldo & _
              ", nnum=" & nnum & ", dfecmod='" & gdfecsis & "', dfecult = '" & gdfecsis & "' where ccodaho ='" & cuenta_ahorro & "'"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        'primera partida
        'partida de diario
        cnumcom = fxStevo(gdfecsis, con)

        concepto = "RETIRO DE 10% DE INTERES DEVENGADO POR REFORMA FISCAL 2010 " & nombre.ToUpper.Trim & " " & socio.ToString & " POR " & nmonto.ToString
        str_select = " insert into diario " & _
         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
         "('" & cnumcom & "', " & "'001', '012', '1', '" & concepto & "', '" & no_recibo.ToString.Trim & "', ' ', ' ', '" & gdfecsis & "', '" & gdfecsis & "', '" & gdfecsis & "', '" & ccodusu & "', 0, " & _
         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        num = 1
        'cta de cajero
        cclase = Left(cta_cajero, 1)
        ndebe = 0.0
        nhaber = nmonto
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & ctaaho & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If
        'cta de ahorro contable
        num = num + 1
        cclase = Left(cta_contable_ahorro, 1)
        ndebe = nmonto
        nhaber = 0.0
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & ctaaho & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"


        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If
        '**************************************************************************************************************************
        'esta partida es para pasar el 10% de retiro a una cta. bolson a ser reportada al fisco
        'segunda partida
        'partida de diario
        cnumcom = fxStevo(gdfecsis, con)

        concepto = "10% DE INTERES DEVENGADO POR REFORMA FISCAL 2010  " & nombre.ToUpper.Trim & " " & socio.ToString & " " & ctaaho
        str_select = "insert into diario " & _
         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
         "('" & cnumcom & "', " & "'001', '012', '1', '" & concepto & "', '" & no_recibo.ToString.Trim & "', ' ', ' ', '" & gdfecsis & "', '" & gdfecsis & "', '" & gdfecsis & "', '" & ccodusu & "', 0, " & _
         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        num = 1
        'cta de cajero
        cclase = Left(cta_cajero, 1)
        ndebe = nmonto
        nhaber = 0.0
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & ctaaho & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If
        'cta bolson para reportar a hacienda
        cta_contable_ahorro = "221107010106"

        num = num + 1
        cclase = Left(cta_contable_ahorro, 1)
        ndebe = 0.0
        nhaber = nmonto
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & ctaaho & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"


        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        'inserta en la tabla reforma_fiscal el movimiento
        str_select = "insert into reforma_fiscal " & _
                     "(ccodcli, fecha, cuenta, certifica, monto_prom, int_ganado, retenido) values " & _
                     "('" & cli & "', '" & gdfecsis & "', '" & ctaaho & "', '" & no_cert & "', " & tothaber & ", " & interes & ", " & diez & ")"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        Return 0

    End Function
    Public Function cuenta_contable_cajero(ByVal ccodusu As String) As String
        Dim con As New SqlConnection
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection

        Dim str_select As String
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim cta_contable As String = ""
        con.Open()
        str_select = "select cdescri, ccodcta from tabttab where ccodtab = '187' and ctipreg = '1' and ccodana = " & miclase1.ToString(ccodusu)
        ds = miclase.devolver_dataset(con, str_select)

        dt = ds.Tables(0)
        Dim fila As DataRow
        For Each fila In dt.Rows
            cta_contable = fila("ccodcta").ToString.Trim  'cta contable
        Next
        con.Close()
        Return cta_contable
    End Function

    Public Function nombre_cajero(ByVal ccodusu As String) As String
        Dim con As New SqlConnection
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection

        Dim str_select As String
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim nombre_cajero1 As String = ""
        con.Open()
        str_select = "select cdescri, ccodcta from tabttab where ccodtab = '187' and ctipreg = '1' and ccodana =" & miclase1.ToString(ccodusu)
        ds = miclase.devolver_dataset(con, str_select)

        dt = ds.Tables("tabla")
        Dim fila As DataRow
        For Each fila In dt.Rows
            nombre_cajero1 = fila("cdescri").ToString.Trim  'nombre de cajero
        Next
        con.Close()
        Return nombre_cajero1
    End Function

    Public Function cuenta_contable_ahorro(ByVal cta_ahorro As String) As String
        Dim con As New SqlConnection
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection

        Dim str_select As String
        Dim ds As New DataSet

        Dim dt As New DataTable
        Dim tipo As String = cta_ahorro.Substring(6, 2)
        Dim cta_contable As String = ""
        con.Open()
        str_select = "select ccta1 from ahomtrs where ccodtrs = " & miclase1.ToString(tipo)
        ds = miclase.devolver_dataset(con, str_select)
        ' guarda en la tabla las ctas contables de los diferentes tipos de ahorro
        dt = ds.Tables("tabla")
        Dim fila As DataRow
        For Each fila In dt.Rows
            cta_contable = fila("ccta1").ToString.Trim  'cta contable
        Next
        con.Close()
        Return cta_contable
    End Function
    'para trasladar la suma de int a plazo del dia a otra cta de ahorro(un solo valor)
    Public Function caso_machon(ByVal ccodusu As String, ByVal gdfecsis As Date) As Boolean
        Dim con As New SqlConnection
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection
        Dim str_select As String = ""

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim ds1 As New DataSet
        Dim dt1 As New DataTable
        Dim fila1 As DataRow

        Dim error100 As Integer = 0

        con.Open()

        'cta_apor='00100106002530'  &&aportaciones

        Dim nombre As String = "EDUARDO ANTONIO MACHON LOPEZ"
        Dim socio As String = "001000001870"
        Dim fecha As String = gdfecsis
        Dim dep As Decimal = 0, ret As Decimal = 0, cta_contable_ahorro As String
        Dim cnumcom As String, nnum As Integer, num As Integer, cta_ahorro As String = "", cta_cajero As String, cta_contable As String = ""
        cta_cajero = miclase1.cuenta_contable_cajero(ccodusu)
        Dim nmonto As Decimal, no_recibo As String, concepto As String, cclase As String, ndebe As Decimal, nhaber As Decimal
        Dim ccodpres As String, saldo As Decimal, cuenta_ahorro As String, tipo_cta As String

        str_select = "SET LANGUAGE spanish; select sum(nmonto) as dep from ahommov where ccodaho = '00100102015770' and cnumdoc = 'TRAS/INT' and dfecope = " & miclase1.ToString(fecha)
        dep = miclase.devolver_scalar1(con, str_select)

        If dep = 0 Then 'no hay nada este dia
            con.Close()
            Return True
        End If

        str_select = "select sum(nmonto) as dep from ahommov where ccodaho = '00100102015770' and cnumdoc = 'FISCAL' and dfecope = " & miclase1.ToString(fecha)
        ret = miclase.devolver_scalar1(con, str_select)

        nmonto = dep - ret

        str_select = "begin tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If

        '**************************************************************************************************************
        'primera partida de retiro de cta de fuente
        no_recibo = "102030"

        cnumcom = fxStevo(gdfecsis, con)

        concepto = "RETIRO AHORRO A LA VISTA " & socio.ToString & " " & nombre.ToUpper.Trim
        str_select = "insert into diario " & _
                     "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
                     "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
                     "('" & cnumcom & "', " & "'001', '012', '1', '" & concepto & "', '102030', ' ', ' ', '" & fecha & "', '" & fecha & "', '" & fecha & "', '" & ccodusu & "', 0, " & _
                     "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If
        num = 1
        'cta de cajero
        cclase = Left(cta_cajero, 1)
        ndebe = 0.0
        nhaber = nmonto
        ccodpres = "00100102015770"
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & fecha & "', '" & ccodpres & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & fecha & "')"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If
        'cta de ahorro contable
        cta_contable_ahorro = cuenta_contable_ahorro(ccodpres) 'cta de ahorro fuente

        num = num + 1
        cclase = Left(cta_contable_ahorro, 1)
        ndebe = nmonto
        nhaber = 0.0

        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & fecha & "', '" & ccodpres & "' , ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & fecha & "')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If

        '**************************************************************************************************************
        'segunda partida de deposito de cta destino
        no_recibo = "102030"

        cnumcom = fxStevo(gdfecsis, con)

        concepto = "DEPOSITO AHORRO A LA VISTA " & socio.ToString & " " & nombre.ToUpper.Trim
        str_select = "insert into diario " & _
                     "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
                     "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
                     "('" & cnumcom & "', " & "'001', '012', '1', '" & concepto & "', '102030', ' ', ' ', '" & fecha & "', '" & fecha & "', '" & fecha & "', '" & ccodusu & "', 0, " & _
                     "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If
        num = 1
        'cta de cajero
        cclase = Left(cta_cajero, 1)
        ndebe = nmonto
        nhaber = 0.0
        ccodpres = "00100102015771"
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & fecha & "', '" & ccodpres & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & fecha & "')"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If
        'cta de ahorro contable
        cta_contable_ahorro = cuenta_contable_ahorro(ccodpres) 'cta de ahorro fuente

        num = num + 1
        cclase = Left(cta_contable_ahorro, 1)
        ndebe = 0.0
        nhaber = nmonto

        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & fecha & "', '" & ccodpres & "', ' ', '12', '001', ' ', ' ', '" & socio & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & fecha & "')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If

        '*************************************************************************************************************
        'retira y deposita en la ahommov
        'va a ver el saldo de esta cta de ahorro
        'RETITO
        str_select = "select ccodaho, nnum, nsaldoaho from ahomcta where ccodaho = '00100102015770'"
        ds1 = miclase.devolver_dataset(con, str_select)
        dt1 = ds1.Tables("tabla")
        For Each fila1 In dt1.Rows
            nnum = fila1("nnum")
            saldo = fila1("nsaldoaho")
        Next

        saldo = saldo - nmonto
        cuenta_ahorro = "00100102015770"
        tipo_cta = cuenta_ahorro.Substring(6, 2)
        'inserta el movimiento en en la cta de ahorro
        nnum = nnum + 1
        If nnum > 65 Then
            nnum = 1
        End If
        str_select = "insert into ahommov " & _
                     "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                     "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                     "('" & cuenta_ahorro & "', '" & fecha & "', 'R', '" & no_recibo.ToString & "', 'E', 'RETIRO', 0, ' ', ' ', " & _
                     "'" & fecha & " ', '" & fecha & "', 0, '" & nmonto & "', 0, 'N', " & _
                     nnum & ", '" & fecha & "', '" & ccodusu & "', " & nnum & ", ' ', " & saldo & ", " & saldo & ", 'RT', " & _
                     "'" & tipo_cta & "', ' ', 0, ' ', 0)"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If
        'actualiza la cabecera de ahorros
        str_select = "update ahomcta set nsaldoaho=" & saldo & ", nsaldnind=" & saldo & _
              ", nnum=" & nnum & ", dfecmod='" & fecha & "', dfecult = '" & fecha & "' where ccodaho ='" & cuenta_ahorro & "'"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If

        'DEPOSITO
        ds1.Clear()
        dt1.Clear()
        str_select = "select ccodaho, nnum, nsaldoaho from ahomcta where ccodaho = '00100102015771' "
        ds1 = miclase.devolver_dataset(con, str_select)
        dt1 = ds1.Tables("tabla")
        For Each fila1 In dt1.Rows
            nnum = fila1("nnum")
            saldo = fila1("nsaldoaho")
        Next

        saldo = saldo + nmonto
        cuenta_ahorro = "00100102015771"
        tipo_cta = cuenta_ahorro.Substring(6, 2)
        'inserta el movimiento en en la cta de ahorro
        nnum = nnum + 1
        If nnum > 65 Then
            nnum = 1
        End If
        str_select = "insert into ahommov " & _
                     "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                     "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                     "('" & cuenta_ahorro & "', '" & fecha & "', 'D', '" & no_recibo.ToString & "', 'E', 'DEPOSITO', 0, ' ', ' ', " & _
                     "'" & fecha & " ', '" & fecha & "', 0, '" & nmonto & "', 0, 'N', " & _
                     nnum & ", '" & fecha & "', '" & ccodusu & "', " & nnum & ", ' ', " & saldo & ", " & saldo & ", 'DP', " & _
                     "'" & tipo_cta & "', ' ', 0, ' ', 0)"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If
        'actualiza la cabecera de ahorros
        str_select = "update ahomcta set nsaldoaho=" & saldo & ", nsaldnind=" & saldo & _
              ", nnum=" & nnum & ", dfecmod='" & fecha & "', dfecult = '" & fecha & "' where ccodaho =" & miclase1.ToString(cuenta_ahorro)
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If

        str_select = "commit tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If

        con.Close()

        Return True
    End Function

    Public Function foto_firma(ByVal ccodcli As String, ByVal cual As Integer) As String
        Dim cola As String = ""
        Dim clii As String = ""
        If ccodcli.Length > 12 Then
            cola = Right(ccodcli, 2)
        End If

        clii = ccodcli.Substring(3, 9)
        'Dim clii As String = Right(ccodcli, 9)
        Dim num As Integer = Integer.Parse(clii)
        Dim foto As String = num.ToString

        'cuando mas de uno puede retirar
        'If cola.Length > 0 Then
        '    foto = foto & cola
        'End If

        Dim foto1 As String = ""
        Dim literal As String = "foto"
        'Dim huella1 As String = "~/fotos/"
        'Dim huella1 As String = "c:\\wwwsihua\\wwwsim\\fotos\\"
        'Dim huella As String = "c:/wwwsihua/wwwsim/fotos/"
        'Dim huella1 As String = "c:/inetpub/wwwroot/wwwsim/fotos/"
        Dim fisico As String = "c:/inetpub/wwwroot/wwwsim/fotos/"
        Dim relativo As String = "~/fotos/"
        ' para sel server Dim huella As String = "c://inetpub/wwwroot/wwwsim/fotos/"
        If cual = 1 Then
            foto1 = fisico & foto & literal & cola & ".jpg"
            If My.Computer.FileSystem.FileExists(foto1) Then

                foto1 = relativo & foto & literal & cola & ".jpg"
            Else
                foto1 = fisico & foto & literal & cola & ".png"
                If My.Computer.FileSystem.FileExists(foto1) Then
                    foto1 = relativo & foto & literal & cola & ".png"

                Else
                    foto1 = fisico & foto & literal & cola & ".bmp"
                    If My.Computer.FileSystem.FileExists(foto1) Then
                        foto1 = relativo & foto & literal & cola & ".bmp"
                    Else
                        foto1 = fisico & foto & literal & cola & ".gif"
                        If My.Computer.FileSystem.FileExists(foto1) Then
                            foto1 = relativo & foto & literal & cola & ".gif"
                        Else
                            foto1 = relativo & "sinfoto.jpg" '"basura"
                        End If
                    End If
                End If
            End If
        End If

        literal = "firma"
        If cual = 2 Then
            foto1 = fisico & foto & literal & cola & ".jpg"
            If My.Computer.FileSystem.FileExists(foto1) Then

                foto1 = relativo & foto & literal & cola & ".jpg"
            Else
                foto1 = fisico & foto & literal & cola & ".png"
                If My.Computer.FileSystem.FileExists(foto1) Then
                    foto1 = relativo & foto & literal & cola & ".png"

                Else
                    foto1 = fisico & foto & literal & cola & ".bmp"
                    If My.Computer.FileSystem.FileExists(foto1) Then
                        foto1 = relativo & foto & literal & cola & ".bmp"
                    Else
                        foto1 = fisico & foto & literal & cola & ".gif"
                        If My.Computer.FileSystem.FileExists(foto1) Then
                            foto1 = relativo & foto & literal & cola & ".gif"
                        Else
                            foto1 = relativo & "sinfirma.jpg" '"basura"
                        End If
                    End If
                End If
            End If
        End If


        Return foto1
    End Function


    Public Function meses_letras(ByVal fecha As Date) As String
        Dim mes As Integer = DatePart(DateInterval.Month, fecha)
        Dim letras As String = ""
        If mes = 1 Then
            letras = "ENERO"
        End If
        If mes = 2 Then
            letras = "FEBRERO"
        End If
        If mes = 3 Then
            letras = "MARZO"
        End If
        If mes = 4 Then
            letras = "ABRIL"
        End If
        If mes = 5 Then
            letras = "MAYO"
        End If
        If mes = 6 Then
            letras = "JUNIO"
        End If
        If mes = 7 Then
            letras = "JULIO"
        End If
        If mes = 8 Then
            letras = "AGOSTO"
        End If
        If mes = 9 Then
            letras = "SEPTIEMBRE"
        End If
        If mes = 10 Then
            letras = "OCTUBRE"
        End If
        If mes = 11 Then
            letras = "NOVIEMBRE"
        End If
        If mes = 12 Then
            letras = "DICIEMBRE"
        End If
        Return letras

    End Function
    Public Function mascara_numerica(ByVal numero As Decimal) As String

        Dim mask As String = Format(numero, "###,###,##0.00")
        Dim ori As Integer = mask.Length
        mask = mask.PadLeft(40, " ")

        If ori = 4 Then
            mask = Right(mask, 17)
        End If
        If ori = 5 Then
            mask = Right(mask, 16)
        End If

        If ori = 6 Then
            mask = Right(mask, 15)
        End If
        'If ori = 7 Then
        '    mask = Right(mask, 14)  ' no existe esta posicion
        'End If

        If ori = 8 Then
            mask = Right(mask, 14)
        End If
        If ori = 9 Then
            mask = Right(mask, 13)
        End If
        If ori = 10 Then
            mask = Right(mask, 12)
        End If
        If ori = 12 Then
            mask = Right(mask, 11)
        End If


        Return mask
    End Function
    'devolver campos para sentencias sql en cuots ' '
    Public Overloads Function tostring(ByVal campo As String) As String
        Return "'" & campo & "'"
    End Function
    ' quien llama debera tener el begin tran y el commit
    Public Function capitalizar_cuenta(ByVal con As SqlConnection, _
                                       ByVal ccodcli As String, _
                                       ByVal ccodaho As String, _
                                       ByVal nombre As String, _
                                       ByVal cta_debe As String, _
                                       ByVal cta_haber As String, _
                                       ByVal interes As Decimal, _
                                       ByVal nsaldoaho As Decimal, _
                                       ByVal nnum As Integer, _
                                       ByVal ccodusu As String, _
                                       ByVal fec_capitalizacion As Date, _
                                       ByVal tipo_capitalizacion As String, _
                                       ByVal oficina As String) As Boolean


        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones

        Dim str_select As String = ""



        Dim resp As Boolean = False
        Dim error100 As Integer = -100

        Dim cnumcom As String, num As Integer, cta_ahorro As String, cta_cajero As String, cta_contable As String = ""
        cta_cajero = miclase1.cuenta_contable_cajero(ccodusu)
        Dim nmonto As Decimal, no_recibo As String, concepto As String, cclase As String, ndebe As Decimal, nhaber As Decimal
        Dim ccodpres As String = "", saldo As Decimal, cuenta_ahorro As String = "", tipo_cta As String
        Dim cta_contable_ahorro As String, socio As String, cta_fuente As String, cod As String
        Dim tot_haberes As Decimal

        Dim gdfecsis As String = miclase1.ToString(fec_capitalizacion)


        cod = ccodaho.Substring(6, 2)
        cta_ahorro = ccodaho


        Dim cnudotr As String = ccodcli
        Dim cuantos As Integer = 0


        If interes = 0 Then
            Return True
        End If

        cuantos = cuantos + 1

        socio = cnudotr
        saldo = nsaldoaho + interes
        nnum = nnum + 1
        If nnum > 65 Then
            nnum = 1
        End If

        'actualiza la cabecera de ahorros
        str_select = "update ahomcta set nsaldoaho=" & saldo & ", nsaldnind=" & saldo & _
              ", nnum=" & nnum & ", dfecmod=" & gdfecsis & ", dfecult =" & _
              gdfecsis & ", dfeccap=" & gdfecsis & _
              " where ccodaho = " & miclase1.ToString(cta_ahorro)
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If

        tipo_cta = "IN"
        nmonto = interes
        no_recibo = "CAPITALI"

        'inserta el movimiento en  la cta de ahorro
        str_select = "insert into ahommov " & _
                     "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                     "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                     "(" & miclase1.ToString(cta_ahorro) & "," & gdfecsis & ", 'D', " & miclase1.ToString(no_recibo.ToString) & ", 'E', 'DEPOSITO', 0, ' ', ' ', " & _
                      gdfecsis & "," & gdfecsis & ", 0, " & nmonto & ", 0, 'N', " & _
                     nnum & ", " & gdfecsis & ", " & miclase1.ToString(ccodusu) & "," & nnum & ", ' ', " & saldo & ", " & saldo & ", 'CA', " & _
                      miclase1.ToString(tipo_cta) & ", ' ', 0, ' ', 0)"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If


        'solo para ctas individuales
        If tipo_capitalizacion = "INDIVIDUAL" Then

            'primera cta.
            'cta de ahorro contable
            cta_contable_ahorro = cta_debe
            cta_fuente = cta_ahorro

            cnumcom = fxStevo(fec_capitalizacion, con)
            no_recibo = "CAP/INT"
            num = 1
            cclase = Left(cta_contable_ahorro, 1)
            ndebe = nmonto
            nhaber = 0.0

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
                        gdfecsis & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', " & miclase1.ToString(oficina) & ", ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
                        " ' ', ' ', 0, 0," & gdfecsis & ")"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

            'segunda cta.
            'cta de ahorro contable
            cta_contable_ahorro = cta_haber
            cta_fuente = cta_ahorro


            num = num + 1
            cclase = Left(cta_contable_ahorro, 1)
            ndebe = 0.0
            nhaber = nmonto

            str_select = "insert into cntamov " & _
        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
        "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
        gdfecsis & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', " & miclase1.ToString(oficina) & ", ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
        " ' ', ' ', 0, 0, " & gdfecsis & ")"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If
        End If
        ' fin de solo ctas individuales


        'solo para ctas individuales
        If tipo_capitalizacion = "INDIVIDUAL" And cuantos > 0 Then

            concepto = miclase1.ToString("CAPITALIZACION DE INTERESES DE CTA " & ccodaho & " " & nombre.ToUpper.Trim & " " & socio.ToString)
            str_select = "insert into diario " & _
             "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
             "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
             "(" & miclase1.ToString(cnumcom) & "," & miclase1.ToString(oficina) & ", '012', '1', " & concepto & ", " & miclase1.ToString(no_recibo.ToString.Trim) & ", ' ', ' ', " & gdfecsis & ", " & gdfecsis & ", " & gdfecsis & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
             "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If
        End If

        If cuantos > 0 Then
            ' aumentado por jaime dic/2009 para implementar la reforma fiscal 2010
            If Year(fec_capitalizacion) >= 2010 Then
                tot_haberes = suma_haberes_reformado(con, socio, 0, fec_capitalizacion) ' excluir las aportaciones

                If tot_haberes >= 25000.0 Then
                    error100 = reforma_fiscal(con, socio, ccodaho, " ", interes, tot_haberes, ccodusu, fec_capitalizacion)
                    If error100 = -100 Then
                        Return False
                    End If
                End If
            End If
        End If

        If cuantos = 0 Then
            Return False
        End If

        Return True
    End Function
    ' quien llama debera tener el begin tran y el commit
    Public Function capitalizacion_global(ByVal con As SqlConnection, ByVal fec_capitalizacion As Date, ByVal ccodusu As String, ByVal oficina As String) As Boolean
        Dim miclase1 As New clase_funciones
        Dim miclase As New clase_especial

        Dim mes As Integer = DatePart(DateInterval.Month, fec_capitalizacion)
        Dim dia As Integer = DatePart(DateInterval.Day, fec_capitalizacion)
        Dim dia1 As Integer = miclase1.dia_ultimo_mes(fec_capitalizacion)

        'verifica si hay capitalizacion
        If (mes = 3 Or mes = 6 Or mes = 9 Or mes = 12) And dia = dia1 Then
            'hay cap
        Else
            Return True
        End If

        Dim str_select As String

        Dim ds As DataSet
        Dim fila As DataRow

        Dim resp As Boolean = False
        Dim error100 As Integer = -100

        Dim gdfecsis As String = fec_capitalizacion
        gdfecsis = miclase1.ToString(gdfecsis)
        Dim concepto As String, no_recibo As String = "CAP/INT"

        Dim fec_ini As String, fec_fin As String

        If mes >= 1 And mes <= 3 Then
            fec_ini = "01/01/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
            fec_fin = DatePart(DateInterval.Day, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Month, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
        End If
        If mes >= 4 And mes <= 6 Then
            fec_ini = "01/04/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
            fec_fin = DatePart(DateInterval.Day, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Month, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
        End If
        If mes >= 7 And mes <= 9 Then
            fec_ini = "01/07/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
            fec_fin = DatePart(DateInterval.Day, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Month, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
        End If
        If mes >= 10 And mes <= 12 Then
            fec_ini = "01/10/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
            fec_fin = DatePart(DateInterval.Day, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Month, fec_capitalizacion).ToString & "/" & DatePart(DateInterval.Year, fec_capitalizacion).ToString
        End If

        fec_ini = miclase1.ToString(fec_ini)
        fec_fin = miclase1.ToString(fec_fin)

        str_select = "set language spanish; select int.ccodcli, int.ccodaho, cta.nnum, cta.nsaldoaho, cli.cnomcli as nombre, " & _
                     "trs.ccta5 as cta_debe, trs.ccta6 as cta_haber, round(sum(int.interes),2) as interes " & _
                     "from interes_diario as int, climide as cli, ahomtrs as trs, ahomcta as cta " & _
                     "where int.fecha >= " & fec_ini & " and int.fecha <= " & fec_fin & " and " & _
                     "int.ccodcli = cli.ccodcli and cli.lactivado = 1  and " & _
                     "SUBSTRING(Int.ccodaho, 7, 2) = trs.ccodtrs And Int.ccodaho = cta.ccodaho " & _
                     "group by int.ccodaho, int.ccodcli, trs.ccta5, trs.ccta6, cli.cnomcli, cta.nnum, cta.nsaldoaho " & _
                     "having (Round(sum(Int.interes), 2) > 0) " & _
                     "order by int.ccodcli  "



        ds = miclase.devolver_dataset(con, str_select)

        'dio error de timeout
        If ds Is Nothing Then
            con.Close()
            Return False
        End If

        Dim procesados As Integer = 0
        Dim proceso As Integer = 0
        proceso = ds.Tables(0).Rows.Count()

        'capitaliza cta por cta
        For Each fila In ds.Tables(0).Rows
            procesados = procesados + 1
            str_select = "select " & miclase1.ToString(procesados.ToString) & " as procesando, " & miclase1.ToString(proceso.ToString) & " as Total_Procesar"
            error100 = miclase.nonquery_sin_parametros(con, str_select)

            error100 = miclase1.capitalizar_cuenta(con, _
                                                   fila("ccodcli"), _
                                                   fila("ccodaho"), _
                                                   fila("nombre"), _
                                                   fila("cta_debe"), _
                                                   fila("cta_haber"), _
                                                   fila("interes"), _
                                                   fila("nsaldoaho"), _
                                                   fila("nnum"), _
                                                   ccodusu, _
                                                   fec_capitalizacion, _
                                                   "GLOBAL", oficina)
            If error100 = -100 Then
                Return False
            End If
        Next


        'hace 2 partidas una por agencia
        Dim cnumcom As String
        Dim part_metapan As String
        Dim part_staana As String

        part_staana = miclase1.fxStevo(fec_capitalizacion, con)
        part_metapan = miclase1.fxStevo(fec_capitalizacion, con)

        Dim ds1 As DataSet
        str_select = "select trs.cnomtrs, cli.ccodofi, trs.ccta1, trs.ccta4, sum(mov.nmonto) as interes " & _
                    "from ahomcta as cta, ahommov as mov, ahomtrs as trs, climide as cli " & _
                    "where mov.dfecope = " & gdfecsis & _
                    " and mov.cnumdoc = 'CAPITALI' and mov.ccodaho = cta.ccodaho and " & _
                    "substring(cta.ccodaho, 7, 2) = trs.ccodtrs And cta.cnudotr = cli.ccodcli " & _
                    "group by trs.cnomtrs, trs.ccta1, trs.ccta4, cli.ccodofi " & _
                    "order by cli.ccodofi, trs.cnomtrs  "

        ds1 = miclase.devolver_dataset(con, str_select)
        Dim fila1 As DataRow


        oficina = "001"
        cnumcom = part_staana
        concepto = miclase1.ToString("CAPITALIZACION TRIMESTRAL DE INTERESES " & fec_capitalizacion.ToString & " AGENCIA SANTA ANA")
        str_select = "insert into diario " & _
         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
         "(" & miclase1.ToString(cnumcom) & "," & miclase1.ToString(oficina) & ", '012', '1', " & concepto & ", " & miclase1.ToString(no_recibo.ToString.Trim) & ", ' ', ' ', " & gdfecsis & ", " & gdfecsis & ", " & gdfecsis & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If


        oficina = "002"
        cnumcom = part_metapan
        concepto = miclase1.ToString("CAPITALIZACION TRIMESTRAL DE INTERESES " & fec_capitalizacion.ToString & " AGENCIA METAPAN")
        str_select = "insert into diario " & _
         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
         "(" & miclase1.ToString(cnumcom) & "," & miclase1.ToString(oficina) & ", '012', '1', " & concepto & ", " & miclase1.ToString(no_recibo.ToString.Trim) & ", ' ', ' ', " & gdfecsis & ", " & gdfecsis & ", " & gdfecsis & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If



        Dim nhaber As Decimal = 0, ndebe As Decimal = 0, vista As Decimal, programado As Decimal = 0
        Dim num As Integer = 0, cclase As String, cta_contable_ahorro As String, cta_fuente As String, socio As String

        cta_fuente = ""
        socio = ""

        'contabiliza partida de capitalizacion resumuda por cartera
        'contabiliza dependiendo de la oficina para repartir a las agencias
        For Each fila1 In ds1.Tables(0).Rows

            If fila1("ccodofi") = "001" Then
                cnumcom = part_staana
                oficina = "001"
            Else
                cnumcom = part_metapan
                oficina = "002"
            End If


            num = num + 1
            cta_contable_ahorro = fila1("ccta1")
            cclase = Left(fila1("ccta1"), 1)
            ndebe = 0.0
            nhaber = fila1("interes")


            str_select = "insert into cntamov " & _
        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
        "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
        gdfecsis & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', " & miclase1.ToString(oficina) & ", ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
        " ' ', ' ', 0, 0, " & gdfecsis & ")"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If
            '----------------------------------------------
            num = num + 1
            cta_contable_ahorro = fila1("ccta4")
            cclase = Left(fila1("ccta4"), 1)
            ndebe = fila1("interes")
            nhaber = 0.0


            str_select = "insert into cntamov " & _
        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
        "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
        gdfecsis & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', " & miclase1.ToString(oficina) & ", ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
        " ' ', ' ', 0, 0, " & gdfecsis & ")"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

        Next


        Return True
    End Function
    ' quien llama debera tener el begin tran y el commit
    Public Function provision_diaria_certificados(ByVal con As SqlConnection, ByVal fecha_cierre As Date, ByVal per_base As Integer, ByVal ccodusu As String) As Boolean
        'ojo fecha_cierre deberia tener la del sig. dia
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow, fila1 As DataRow
        Dim ds As New DataSet, ds1 As New DataSet
        Dim error100 As Integer
        Dim pdultpro As Date
        Dim gdfecsis As String = fecha_cierre
        Dim num As Integer, cclase As String, ndebe As Decimal, nhaber As Decimal, cta_contable_ahorro As String
        Dim cta_fuente As String = "", socio As String = "", tipo_cta As String = ""

        str_select = "delete ahomint where dfecpro = " & miclase1.ToString(gdfecsis)
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "set language spanish; select max(dultpro) from ahompro2"
        pdultpro = Date.Parse(miclase.devolver_scalar1(con, str_select))

        str_select = "select * from ahomcrt where cliq <> 'S' and nmonapr > 0 order by ccodcrt"
        ds = miclase.devolver_dataset(con, str_select)

        Dim concepto As String, cnumcom As String, no_recibo As String = "INT/CERT"
        Dim dias As Integer, lnintere As Decimal, f As Date
        Dim lnintereses As Decimal, lntotint As Decimal, dmenpro1 As Date
        Dim nombre As String
        Dim cert As String, provision As Date, fec_calc As Date

        Dim tot_haberes As Decimal = 0
        Dim dfecapr As String, dfecven As String, dfecprv As String, dfecori As String

        Dim int1 As Decimal = 0.0, int2 As Decimal = 0.0, int3 As Decimal = 0.0, int4 As Decimal = 0.0, int5 As Decimal = 0.0
        Dim int6 As Decimal = 0.0, int7 As Decimal = 0.0, int8 As Decimal = 0.0, int9 As Decimal = 0.0, int10 As Decimal = 0.0

        For Each fila In ds.Tables(0).Rows


            'dias = DateDiff(DateInterval.Day, fila("dultpro"), fecha_cierre)
            ' de todas maneras calcula 1 dia
            dias = 1
            lnintere = Round(((fila("nmonapr") * dias) * ((fila("ntasint") / 100))) / per_base, 4)
            nombre = fila("nombre").ToString.Substring(0, 39)


            If fila("nplazo") <= 30 Then
                int2 = int2 + lnintere
            ElseIf fila("nplazo") >= 31 And fila("nplazo") <= 60 Then
                int3 = int3 + lnintere
            ElseIf fila("nplazo") >= 61 And fila("nplazo") <= 90 Then
                int4 = int4 + lnintere
            ElseIf fila("nplazo") >= 91 And fila("nplazo") <= 120 Then
                int5 = int5 + lnintere
            ElseIf fila("nplazo") >= 121 And fila("nplazo") <= 150 Then
                int6 = int6 + lnintere
            ElseIf fila("nplazo") >= 151 And fila("nplazo") <= 180 Then
                int7 = int7 + lnintere
            ElseIf fila("nplazo") >= 181 And fila("nplazo") <= 359 Then
                int8 = int8 + lnintere
            ElseIf fila("nplazo") = 360 Then
                int9 = int9 + lnintere
            ElseIf fila("nplazo") >= 361 Then
                int10 = int10 + lnintere
            End If


            cert = fila("ccodcrt").ToString.Trim
            provision = fila("dmenpro")
            fec_calc = fila("dfecapr")

            ' las convierte a dd/mm/yyyy
            dfecapr = fila("dfecapr")
            dfecven = fila("dfecven")
            dfecprv = fila("dfecprv")
            dfecori = fila("dfecori")

            'If cert = "3006" Then
            '    cert = "3006"
            'End If


            'insertar la provision de intereses del certificado
            str_select = "insert into ahomint (ccodcrt,cnrolin,nombre,cnudotr,ccodaho,nmonapr,nplazo,nintere,dfecapr,dfecven,dfecprv,dfecori,dfecliq,ndiagra,ccalint,cprvint,ccodbco, " & _
                             "cctacte,ccapita,cpignor,ccodcta,dfecmod,ccodusu,cprovis,cliq,nsaldoaho,nmonotr,dfeccap,ccodcli,cpig,producto,cestado,cflag,dfecpro,dfecmod2,ntasint) values " & _
                             "(" & miclase1.ToString(fila("ccodcrt").ToString.Trim) & "," & miclase1.ToString(fila("cnrolin")) & "," & miclase1.ToString(nombre) & "," & miclase1.ToString(fila("cnudotr")) & "," & miclase1.ToString(fila("ccodaho")) & "," & fila("nmonapr") & "," & fila("nplazo") & "," & lnintere & "," & miclase1.ToString(dfecapr) & "," & miclase1.ToString(dfecven) & "," & miclase1.ToString(dfecprv) & "," & miclase1.ToString(dfecori) & "," & miclase1.ToString(gdfecsis) & "," & fila("ndiagra") & ", ' ', ' ', ' ', " & _
                             " ' ',' ', ' ',' '," & miclase1.ToString(gdfecsis) & ", ' ', ' ',' ',0,0," & miclase1.ToString(gdfecsis) & ", ' ', ' ', " & miclase1.ToString(fila("producto")) & ", ' ', ' ', " & miclase1.ToString(gdfecsis) & "," & miclase1.ToString(gdfecsis) & ",0)"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

            lnintereses = lnintereses + lnintere

            str_select = "update ahomcrt " & _
                              "set dultpro=" & miclase1.ToString(gdfecsis) & " where ccodcrt = " & miclase1.ToString(fila("ccodcrt"))

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If


            If Year(fila("dmenpro")) < 1900 Then
                fila("dmenpro") = fila("dfecapr")
            End If

            dmenpro1 = DateAdd(DateInterval.Day, 30, fila("dmenpro"))

            ' si entra aqui es porque hay que pagar interes y depositarlo a la cta de ahorros

            If dmenpro1 = fecha_cierre Then

                str_select = "update ahomcrt " & _
                              "set dmenpro=" & miclase1.ToString(gdfecsis) & " where ccodcrt = " & miclase1.ToString(fila("ccodcrt"))
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If

                str_select = "select sum(nintere) from ahomint where ccodcrt = " & miclase1.ToString(fila("ccodcrt")) & _
                                  " and dfecpro <= " & miclase1.ToString(gdfecsis) & " and cflag = ' '  "

                lntotint = 0
                lntotint = Round(miclase.devolver_scalar1(con, str_select), 2)
                'lntotint = Round(((fila("nmonapr") * 30) * ((fila("ntasint") / 100))) / per_base, 4)

                'actualiza para que ya no pague mas lo pagado
                str_select = "update ahomint set cflag= 'X'  " & _
                                 "where ccodcrt = " & miclase1.ToString(fila("ccodcrt")) & " and dfecpro <= " & miclase1.ToString(gdfecsis)
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If

                str_select = "select nnum, nsaldoaho from ahomcta where ccodaho = " & miclase1.ToString(fila("ccodaho"))
                ds1 = miclase.devolver_dataset(con, str_select)

                'para acualizar la ahomcta y ahommov
                For Each fila1 In ds1.Tables(0).Rows
                    fila1("nnum") = fila1("nnum") + 1
                    If fila1("nnum") > 65 Then
                        fila1("nnum") = 1
                    End If

                    fila1("nsaldoaho") = fila1("nsaldoaho") + lntotint
                    'actualiza la ahomcta
                    str_select = "update ahomcta set nnum = " & fila1("nnum") & ", nsaldoaho = " & fila1("nsaldoaho") & _
                                     "  where ccodaho = " & miclase1.ToString(fila("ccodaho"))

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return False
                    End If

                    tipo_cta = fila("ccodaho").substring(6, 2)

                    'inserta el movimiento en en la cta de ahorro
                    str_select = "insert into ahommov " & _
                                 "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                 "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                                 "('" & fila("ccodaho") & "', '" & gdfecsis & "', 'D', '" & no_recibo.ToString & "', 'E', 'DEPOSITO', 0, ' ', ' ', " & _
                                 "'" & gdfecsis & " ', '" & gdfecsis & "', 0, " & lntotint & ", 0, 'N', " & _
                                 fila1("nnum") & ", '" & gdfecsis & "', '" & ccodusu & "', " & fila1("nnum") & ", ' ', " & fila1("nsaldoaho") & ", " & fila1("nsaldoaho") & ", 'IN', " & _
                                 "'" & tipo_cta & "', ' ', 0, ' ', 0)"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return False
                    End If

                    'inserta en los vencidos
                    str_select = "insert into vencidos " & _
                                     "(ccodcrt,cnrolin,nombre,cnudotr,ccodaho,nmonapr,ntasint,nplazo,nintere,dfecapr,dfecven,dfecprv,dfecori,dfecliq,ndiagra,ccalint,cprvint,ccodbco,cctacte, " & _
                                     "ccapita,cpignor,ccodcta,dfecmod,ccodusu,cprovis,cliq,nsaldoaho,dfeccap,ccodcli,cestado,producto,dmenpro,dultpro,dfecpro)" & _
                                     " values " & _
                                     "(" & miclase1.ToString(fila("ccodcrt")) & "," & miclase1.ToString(fila("cnrolin")) & "," & miclase1.ToString(fila("nombre")) & "," & miclase1.ToString(fila("cnudotr")) & "," & miclase1.ToString(fila("ccodaho")) & "," & fila("nmonapr") & "," & fila("ntasint") & "," & fila("nplazo") & "," & lntotint & "," & miclase1.ToString(dfecapr) & "," & miclase1.ToString(dfecven) & ", '01/01/1900', '01/01/1900', '01/01/1900', 0, ' ', ' ', ' ', ' ', " & _
                                     " ' ', ' ', ' ', '01-01-1990', ' ', ' ', ' ', 0," & miclase1.ToString(gdfecsis) & ", ' ', ' ', ' ', '01-01-1990','01-01-1990', " & miclase1.ToString(gdfecsis) & ")"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return False
                    End If

                    'contabilizacion de partida
                    cnumcom = miclase1.fxStevo(gdfecsis, con)
                    no_recibo = "TRAS/INT"

                    concepto = miclase1.ToString("APLICACION DE INTERESES DE 1 MES POR CERTIFICADO A PLAZO # " & fila("ccodcrt"))
                    str_select = "insert into diario " & _
                     "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
                     "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
                     "(" & miclase1.ToString(cnumcom) & ",'001', '012', '1', " & concepto & ", " & miclase1.ToString(no_recibo.ToString.Trim) & ", ' ', ' ', " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
                     "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return False
                    End If

                    'primera cta
                    num = 1
                    cta_contable_ahorro = ""
                    'cta_contable_ahorro = "2111019501"   'plazo
                    'solo intres

                    If fila("nplazo") <= 30 Then
                        cta_contable_ahorro = "2111029501"
                    ElseIf fila("nplazo") >= 31 And fila("nplazo") <= 60 Then
                        cta_contable_ahorro = "2111039501"
                    ElseIf fila("nplazo") >= 61 And fila("nplazo") <= 90 Then
                        cta_contable_ahorro = "2111049501"
                    ElseIf fila("nplazo") >= 91 And fila("nplazo") <= 120 Then
                        cta_contable_ahorro = "2111059501"
                    ElseIf fila("nplazo") >= 121 And fila("nplazo") <= 150 Then
                        cta_contable_ahorro = "2111069501"
                    ElseIf fila("nplazo") >= 151 And fila("nplazo") <= 180 Then
                        cta_contable_ahorro = "2111079501"
                    ElseIf fila("nplazo") >= 181 And fila("nplazo") <= 359 Then
                        cta_contable_ahorro = "2111089501"
                    ElseIf fila("nplazo") = 360 Then
                        cta_contable_ahorro = "2111099501"
                    ElseIf fila("nplazo") >= 361 Then
                        cta_contable_ahorro = "2112019501"
                    End If

                    cclase = Left(cta_contable_ahorro, 1)
                    ndebe = lntotint
                    nhaber = 0.0
                    cta_fuente = fila("ccodaho")
                    socio = fila("cnudotr")

                    str_select = "insert into cntamov " & _
                "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
                miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
                " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return False
                    End If

                    'segunda cta
                    num = num + 1

                    cta_contable_ahorro = miclase1.cuenta_contable_ahorro(fila("ccodaho"))
                    cclase = Left(cta_contable_ahorro, 1)
                    ndebe = 0.0
                    nhaber = lntotint

                    str_select = "insert into cntamov " & _
                "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
                miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
                " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return False
                    End If



                    ' aumentado por jaime dic/2009 para implementar la reforma fiscal 2010
                    If Year(gdfecsis) >= 2010 Then
                        tot_haberes = suma_haberes_reformado(con, socio, 0, fecha_cierre) ' excluir las aportaciones

                        If tot_haberes >= 25000.0 Then
                            error100 = reforma_fiscal(con, socio, fila("ccodaho"), " ", lntotint, tot_haberes, ccodusu, fecha_cierre)
                            If error100 = -100 Then
                                Return False
                            End If
                        End If
                    End If





                Next  ' fin de fila1
            End If
        Next  ' fin de fila

        '************************************************************
        '************************************************************
        '************************************************************


        'insertar la ahompro2 la nueva fecha provisionada
        str_select = "insert into ahompro2 (dultpro) values (" & miclase1.ToString(gdfecsis) & ")"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If


        '*******************************************
        ' al final hay que generar las partidas de lo provisionado
        If lnintereses > 0 Then

            cnumcom = miclase1.fxStevo(gdfecsis, con)
            no_recibo = "INT/CERT"

            concepto = miclase1.ToString("PROVISION DIARIA DE INTERESES POR CERTIFICADOS A PLAZO FECHA " & gdfecsis.ToString)
            str_select = "insert into diario " & _
             "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
             "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
             "(" & miclase1.ToString(cnumcom) & ", '001', '012', '1', " & concepto & ", " & miclase1.ToString(no_recibo.ToString.Trim) & ", ' ', ' ', " & gdfecsis & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
             "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

            'primera cta
            num = 1
            cta_contable_ahorro = "5110010201"  'plazo

            'para que sean iguales ya que da un centavo de dif
            lnintereses = int2 + int3 + int4 + int5 + int6 + int7 + int8 + int9 + int10

            cclase = Left(cta_contable_ahorro, 1)
            ndebe = lnintereses
            nhaber = 0.0
            cta_fuente = ""
            socio = ""


            str_select = "insert into cntamov " & _
        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
        "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
        miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
        " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

            'segunda cta
            num = num + 1
            'solo intres
            ' se agregaran separadamente segun rubro

            'cta_contable_ahorro = "2111019501"   'plazo
            cta_contable_ahorro = ""
            cclase = Left(cta_contable_ahorro, 1)
            ndebe = 0.0
            nhaber = lnintereses

            If int2 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111029501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int2

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int3 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111039501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int3

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int4 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111049501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int4

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int5 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111059501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int5

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int6 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111069501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int6

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int7 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111079501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int7

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int8 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111089501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int8

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int9 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2111099501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int9

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

            If int10 > 0 Then
                num = num + 1
                cta_contable_ahorro = "2112019501"   'plazo
                cclase = Left(cta_contable_ahorro, 1)
                ndebe = 0.0
                nhaber = int10

                str_select = "insert into cntamov " & _
            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
            "(' ', '01', " & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(cta_contable_ahorro) & "," & miclase1.ToString(cclase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(no_recibo.ToString.Trim) & ", " & _
            miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(cta_fuente) & ", ' ', '12', '001', ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
            " ' ', ' ', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If

        End If

        Return True
    End Function
    Public Function renovacion_certificados(ByVal con As SqlConnection, ByVal fec_cierre As Date) As Boolean
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow
        Dim ds As New DataSet
        Dim dt_vencidos As New DataTable
        Dim error100 As Integer
        Dim pdultpro As Date
        Dim fec_ult_pro As String
        Dim nueva_fecha As Date

        str_select = "set language spanish; select max(dultpro) from ahompro2"
        pdultpro = miclase.devolver_scalar1(con, str_select)

        fec_ult_pro = miclase1.transformar_fecha_mdy_to_dmy(pdultpro)
        If error100 = -100 Then
            Return False
        End If

        str_select = "select ccodcrt, dfecapr, dfecven, nplazo from vencidos " & _
                         "where dfecpro = " & miclase1.ToString(fec_ult_pro)
        ds = miclase.devolver_dataset(con, str_select)

        dt_vencidos = ds.Tables("tabla")

        For Each fila In dt_vencidos.Rows
            nueva_fecha = DateAdd(DateInterval.Day, fila("nplazo"), fila("dfecven"))

            If fila("dfecven") = fec_cierre Then
                str_select = "update ahomcrt " & _
                                 "set dfecapr = " & miclase1.ToString(miclase1.transformar_fecha_mdy_to_dmy(fila("dfecven"))) & ", " & _
                                 "dfecven = " & miclase1.ToString(miclase1.transformar_fecha_mdy_to_dmy(nueva_fecha)) & ", " & _
                                 "cestado = 'R' where ccodcrt = " & miclase1.ToString(fila("ccodcrt"))
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If
            End If
        Next

        Return True

    End Function

    Public Function provision_mensual_ahorros(ByVal con As SqlConnection, ByVal per_base As Integer, ByVal fec_cierre As Date) As Boolean

        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow
        Dim ds As New DataSet
        Dim dt_provision As New DataTable
        Dim error100 As Integer
        Dim gdfecsis As String = miclase1.transformar_fecha_mdy_to_dmy(fec_cierre)
        Dim fec_ini As Date = Date.Parse("01/" & Month(fec_cierre).ToString & "/" & Year(fec_cierre).ToString)
        Dim saldo_ini As Decimal = 0

        str_select = "set language spanish; delete ahomaho where dfeccap = " & miclase1.ToString(gdfecsis)
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If

        str_select = "select cta.ccodaho, mov.dfecope, cta.cnudotr, lin.ntasint, lin.ccodlin, lin.cdeslin, " & _
                         "cli.cnomcli, mov.nsaldoaho as saldoant " & _
                         "from ahomcta as cta, ahotlin as lin, climide as cli, ahommov as mov " & _
                         "where left(cli.ccodcli,3) = '001' and cli.lactivado = 1 and " & _
                         "cli.ccodcli = cta.cnudotr and substring(cta.ccodaho,7,2) <>  '06'  and " & _
                         "cta.cnrolin = lin.cnrolin and cta.ccodaho = mov.ccodaho and mov.dfecope <= " & miclase1.ToString(gdfecsis) & _
                         " order by mov.ccodaho, mov.dfecope, mov.nnum"

        ds = miclase.devolver_dataset(con, str_select)
        If error100 = -100 Then
            Return False
        End If

        dt_provision = ds.Tables("tabla")

        Dim cod As String = ""
        Dim interes As Decimal = 0, dias As Integer = 0, saldo As Decimal, tasa As Decimal
        Dim first_time As Boolean = True
        Dim fec_ant As Date
        Dim cnudotr As String = "", ccodlin As String = "", cdeslin As String = "", cnomcli As String = ""

        Dim cuantos As Integer = 0
        For Each fila In dt_provision.Rows

            tasa = fila("ntasint")
            If first_time = True Then
                cod = fila("ccodaho")
                fec_ant = fila("dfecope")
                saldo = fila("saldoant")
                saldo_ini = fila("saldoant")
                first_time = False
            End If

            If fila("ccodaho") <> cod Then

                dias = DateDiff(DateInterval.Day, fec_ant, fec_cierre)
                interes = interes + ((tasa / 100) * saldo * dias / per_base)

                str_select = "insert into ahomaho " & _
                                 "(ccodaho,cnudotr,dfeccap,ntasint,nsaldoaho,ccodlin,cdeslin,producto,nintere,cnomcli,nsaldoant) " & _
                                 " values " & _
                                 "(" & miclase1.ToString(cod) & "," & miclase1.ToString(cnudotr) & "," & miclase1.ToString(gdfecsis) & _
                                 "," & tasa & "," & saldo & "," & miclase1.ToString(ccodlin) & "," & miclase1.ToString(cdeslin) & ", ' ', " & _
                                 interes & "," & miclase1.ToString(cnomcli) & "," & saldo & ")"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return False
                End If

                saldo = 0
                interes = 0
                saldo = fila("saldoant")
                fec_ant = fila("dfecope")
                cod = fila("ccodaho")
                tasa = fila("ntasint")
            End If

            'para saber el ultimo saldo
            If fila("dfecope") < fec_ini Then
                saldo = fila("saldoant")
                fec_ant = fila("dfecope")
                saldo_ini = fila("saldoant")
            End If

            'solo fechas del mes del 1 al ultimo de mes en cuestion
            If fila("dfecope") >= fec_ini And fila("dfecope") <= fec_cierre Then
                dias = DateDiff(DateInterval.Day, fec_ant, fila("dfecope"))
                interes = interes + Round(((tasa / 100) * saldo * dias / per_base), 2)
                saldo = fila("saldoant")
                fec_ant = fila("dfecope")
            End If

            cnudotr = fila("cnudotr")
            ccodlin = fila("ccodlin")
            cdeslin = fila("cdeslin")
            cnomcli = fila("cnomcli")

        Next

        ' el ultimo grupo
        dias = DateDiff(DateInterval.Day, fec_ant, fec_cierre)
        interes = interes + Round(((tasa / 100) * saldo * dias / per_base), 2)

        str_select = "insert into ahomaho " & _
                         "(ccodaho,cnudotr,dfeccap,ntasint,nsaldoaho,ccodlin,cdeslin,producto,nintere,cnomcli,nsaldoant) " & _
                         " values " & _
                         "(" & miclase1.ToString(cod) & "," & miclase1.ToString(cnudotr) & "," & miclase1.ToString(gdfecsis) & _
                         "," & tasa & "," & saldo_ini & "," & miclase1.ToString(ccodlin) & "," & miclase1.ToString(cdeslin) & ", ' ', " & _
                         interes & "," & miclase1.ToString(cnomcli) & "," & saldo & ")"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return False
        End If


        Return True
    End Function
    Public Function provision_diaria_ahorros(ByVal per_base As Integer, ByVal fec_cierre As Date, ByVal ccodusu As String) As Boolean
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow
        Dim error100 As Integer = 0

        Dim ds As New DataSet
        Dim ds1 As New DataSet

        Dim gdfecsis As String = fec_cierre
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()


        Dim interes As Double = 0
        'sta ana
        Dim tot_sim As Double = 0
        Dim tot_vis As Double = 0
        Dim tot_nav As Double = 0
        Dim tot_edu As Double = 0
        Dim tot_men As Double = 0

        'metapan
        Dim tot_sim2 As Double = 0
        Dim tot_vis2 As Double = 0
        Dim tot_nav2 As Double = 0
        Dim tot_edu2 As Double = 0
        Dim tot_men2 As Double = 0


        con.ConnectionString = stringconnection
        con.Open()
        str_select = "set language spanish; delete interes_diario where fecha = " & miclase1.ToString(gdfecsis)
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "select cli.ccodcli, cli.cnomcli, cli.ccodofi, lin.ntasint / 100 as ntasint, cta.ccodaho, cta.nsaldoaho " & _
                     "from ahomcta as cta, climide as cli, ahotlin as lin " & _
                     "where cta.nsaldoaho > 0 and substring(cta.ccodaho,7,2) <> '06' " & _
                     "and cta.cnudotr = cli.ccodcli and cta.cnrolin = lin.cnrolin "
        ds = miclase.devolver_dataset(con, str_select)

        Dim cuenta As String
        Dim tipo As String
        Dim c As Integer = 0

        For Each fila In ds.Tables(0).Rows
            c = c + 1
            cuenta = fila("ccodaho")
            tipo = cuenta.Substring(6, 2)

            interes = Round(fila("nsaldoaho") * fila("ntasint") * 1 / per_base, 4)

            'sta ana
            If fila("ccodofi") = "001" Then
                'simultaneo
                If tipo = "01" Then
                    tot_sim = tot_sim + interes
                End If
                'vista
                If tipo = "02" Then
                    tot_vis = tot_vis + interes
                End If
                'navideño
                If tipo = "03" Then
                    tot_nav = tot_nav + interes
                End If
                'educativo
                If tipo = "04" Then
                    tot_edu = tot_edu + interes
                End If
                'menores
                If tipo = "05" Then
                    tot_men = tot_men + interes
                End If
            End If

            ''sta metapan
            If fila("ccodofi") = "002" Then
                'simultaneo
                If tipo = "01" Then
                    tot_sim2 = tot_sim2 + interes
                End If
                'vista
                If tipo = "02" Then
                    tot_vis2 = tot_vis2 + interes
                End If
                'navideño
                If tipo = "03" Then
                    tot_nav2 = tot_nav2 + interes
                End If
                'educativo
                If tipo = "04" Then
                    tot_edu2 = tot_edu2 + interes
                End If
                'menores
                If tipo = "05" Then
                    tot_men2 = tot_men2 + interes
                End If
            End If



            If c = 1 Then
                str_select = "begin tran"
                miclase.nonquery_sin_parametros(con, str_select)
            End If

            str_select = "insert into interes_diario " & _
                         "(ccodaho, ccodcli, nombre, fecha, saldo, interes) values " & _
                         "(" & miclase1.ToString(fila("ccodaho")) & "," & miclase1.ToString(fila("ccodcli")) & "," & _
                         miclase1.ToString(Left(fila("cnomcli").ToString.Trim, 50)) & "," & miclase1.ToString(gdfecsis) & "," & fila("nsaldoaho") & "," & _
                         interes & ")"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If
        Next





        Dim ctadebe As String, ctahaber As String
        Dim cnumcom As String = ""
        Dim num As Integer = 0
        Dim recibo As String = "PRV/AHO"
        Dim ndebe As Decimal = 0
        Dim nhaber As Decimal = 0
        Dim clase As String = ""
        Dim concepto As String = ""

        'sta ana
        num = 0


        cnumcom = miclase1.fxStevo(gdfecsis, con)


        concepto = miclase1.ToString("PROVISION DIARIA DE INTERESES CTAS. DE AHORRO A LA FECHA " & gdfecsis.ToString & " AGENCIA STA. ANA")
        str_select = "insert into diario " & _
         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
         "(" & miclase1.ToString(cnumcom) & "," & " '001', '012', '1', " & concepto & ", " & miclase1.ToString(recibo.ToString.Trim) & ", ' ', ' ', " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If


        ' simultaneo
        If tot_sim > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '01' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_sim
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If

            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_sim
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If
        ' vista
        If tot_vis > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '02' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_vis
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_vis
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If
        ' navideño
        If tot_nav > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '03' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_nav
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If

            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_nav
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If
        ' educativo
        If tot_edu > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '04' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_edu
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_edu
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If

        ' menores
        If tot_men > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '05' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_men
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_men
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "001")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If


        ''metapan
        num = 0
        cnumcom = miclase1.fxStevo(gdfecsis, con)


        concepto = miclase1.ToString("PROVISION DIARIA DE INTERESES CTAS. DE AHORRO A LA FECHA " & gdfecsis.ToString & " AGENCIA METAPAN")
        str_select = "insert into diario " & _
         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
         "(" & miclase1.ToString(cnumcom) & "," & " '002', '012', '1', " & concepto & ", " & miclase1.ToString(recibo.ToString.Trim) & ", ' ', ' ', " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(ccodusu) & ", 0, " & _
         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return False
        End If


        ' simultaneo
        If tot_sim2 > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '01' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_sim2
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If

            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_sim2
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If
        ' vista
        If tot_vis2 > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '02' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_vis2
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_vis2
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If
        ' navideño
        If tot_nav2 > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '03' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_nav2
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If

            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_nav2
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If
        ' educativo
        If tot_edu2 > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '04' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_edu2
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_edu2
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If

        ' menores
        If tot_men2 > 0 Then
            ds1.Clear()
            str_select = "select ccta3, ccta4 from ahomtrs where ccodtrs = '05' "
            ds1 = miclase.devolver_dataset(con, str_select)
            For Each fila In ds1.Tables(0).Rows
                ctadebe = fila("ccta3")
                ctahaber = fila("ccta4")
            Next
            num = num + 1
            clase = Left(ctadebe, 1)
            ndebe = tot_men2
            nhaber = 0
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctadebe, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


            num = num + 1
            clase = Left(ctahaber, 1)
            ndebe = 0
            nhaber = tot_men2
            error100 = miclase1.insertar_cntamov(con, cnumcom, num, ctahaber, clase, ndebe, nhaber, gdfecsis, " ", " ", ccodusu, recibo, "002")
            If error100 = 1 Then
                str_select = "rollback tran"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        End If


        str_select = "commit tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)

        con.Close()
        Return True
    End Function

    Public Function mensaje(ByVal msj1 As String) As String
        Dim miclase1 As New clase_funciones
        Dim caja As String
        caja = "<script language='javascript'>" & _
                  "alert(" & miclase1.ToString(msj1) & ");" & _
                  "</script>"

        Return caja
    End Function
    Public Function statusbar(ByVal msj1 As String) As String
        Dim miclase1 As New clase_funciones
        Dim caja As String
        caja = "<script language='javascript'>" & _
                  "windows.defaultstatus=" & miclase1.ToString(msj1) & _
                  "</script>"
        Return caja
    End Function

    ' reclasifica los manejos de cta de que van inmersos del mes que se esta cerrando
    Public Function incobrables(ByVal con As SqlConnection, ByVal mes As Integer, ByVal ano As Integer, ByVal fecha As Date, ByVal gccodusu As String) As Boolean
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim suma As Decimal = 0, num As Integer, cclase As String, ndebe As Decimal = 0, nhaber As Decimal = 0, nmonto As Decimal = 0
        Dim cnumcom As String = "", concepto As String = "", asociado As String = "", cta_contable_ahorro As String = "", cta_cajero As String = ""
        Dim gdfecsis As String = fecha
        Dim error100 As Integer


        str_select = "select  sum(kar.nmonto) as suma " & _
                     "from cremcre as cre, credkar as kar " & _
                     "WHERE cre.cnrolin = '0080300' AND cre.ccodcta = kar.ccodcta and " & _
                     "kar.cconcep = '03' and month(kar.dfecsis) = " & mes & " AND year(kar.dfecsis) = " & ano & " AND kar.cestado <> 'X'"

        suma = miclase.devolver_scalar1(con, str_select)

        If suma > 0 Then
            nmonto = Round(suma * 0.47, 2)

            'primera partida de retiro de cta de ahorro
            cnumcom = miclase1.fxStevo(fecha, con)


            concepto = "Reclasificacion de Manejo de Cuenta a Cta. Incobrables para linea SIHUA-PREMIUM II CONSUMO 14.50%"
            str_select = "insert into diario " & _
                         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
                         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
                         "('" & cnumcom & "', " & "'001', '012', '1', '" & concepto & "', '102030', ' ', ' ', '" & gdfecsis & "', '" & gdfecsis & "', '" & gdfecsis & "', '" & gccodusu & "', 0, " & _
                         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

            num = 1

            'cta de ahorro
            cta_contable_ahorro = "5110030101"
            cclase = Left(cta_contable_ahorro, 1)
            ndebe = nmonto
            nhaber = 0.0
            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '102030', " & _
                        "'" & gdfecsis & "', ' ', ' ', '12', '001', ' ', ' ', '" & asociado & "', '" & gccodusu & "', " & _
                        "' ', ' ', 0, 0, '" & gdfecsis & "')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If

            'cta de cajero
            cta_cajero = "1139010401"
            num = num + 1
            cclase = Left(cta_cajero, 1)
            ndebe = 0.0
            nhaber = nmonto
            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '102030', " & _
                        "'" & gdfecsis & "', ' ', ' ', '12', '001', ' ', ' ', '" & asociado & "', '" & gccodusu & "', " & _
                        "' ', ' ', 0, 0, '" & gdfecsis & "')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return False
            End If


        End If

        Return True

    End Function

    Public Function devolver_dataset_lineas_libreta_imprimir(ByVal con As SqlConnection, ByVal ccodaho As String) As DataSet


        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow
        Dim ds As New DataSet

        Dim saldo_pagina As Boolean = habra_cambio_pagina(con, ccodaho)

        'str_select = "set language spanish; drop table t1" & ccodaho & ";" & _
        '             "create table t1" & ccodaho & "  (clinea  varchar(1), nnum integer, ctipope varchar(1), dfecope  date,  retiros  decimal(8,2), depositos  decimal(8,2), saldo decimal(8,2));"
        str_select = "set language spanish; " & _
                     "create table #t1" & ccodaho & "  (clinea  varchar(1), nnum integer, ctipope varchar(1), dfecope  date,  retiros  decimal(8,2), depositos  decimal(8,2), saldo decimal(8,2));"
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "insert into #t1" & ccodaho & " select  clinea, nnum, ctipope, dfecope, nmonto, nmonto, nsaldoaho from ahommov " & _
                     "where ccodaho = " & miclase1.ToString(ccodaho) & " and clinea = 'N' order by dfecope, nnum; "
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "update #t1" & ccodaho & " set retiros = 0 where ctipope = 'D'; update t1" & ccodaho & " set depositos  = 0 where ctipope = 'R'; "
        miclase.nonquery_sin_parametros(con, str_select)

        ' separa las lineas de impresion
        ds = separar_lineas_impresion(con, ccodaho)

        'str_select = "select * from tabla1 order by dfecope, nnum"
        'ds = miclase.devolver_dataset(con, str_select)

        Dim c As Integer = 0
        Dim conta As Integer = 0
        Dim salto_pagina As Boolean = False
        Dim tot_lineas As Integer = ds.Tables(0).Rows.Count
        'recorre para saber si hay que saltar de pagina
        For Each fila In ds.Tables(0).Rows
            c = c + 1
            If c = 1 Then
                conta = fila("nnum")
            End If

            If fila("nnum") = 65 Then
                If tot_lineas > c Then
                    salto_pagina = True
                    Continue For
                End If
            End If
            If salto_pagina = True Then
                fila("nnum") = 99
            End If

        Next

        'inserta rows vacias al inicio
        If conta >= 1 Then
            'str_select = "drop table t2" & ccodaho & "J;" & "  create table t2" & ccodaho & "J" & "  (clinea  varchar(1), nnum integer, ctipope varchar(1), dfecope  date,  retiros  decimal(8,2), depositos  decimal(8,2), saldo decimal(8,2));"
            str_select = "create table #t2" & ccodaho & "J" & "  (clinea  varchar(1), nnum integer, ctipope varchar(1), dfecope  date,  retiros  decimal(8,2), depositos  decimal(8,2), saldo decimal(8,2));"
            miclase.nonquery_sin_parametros(con, str_select)
            str_select = "insert into #t2" & ccodaho & "J" & "  (clinea, nnum, ctipope, dfecope, retiros, depositos, saldo) values " & _
                         "(' ', 0, 'D', '01/01/1962',0.00,0.00, 0.00)"

            'inserta 5 vacios para margen superior
            For k As Integer = 1 To 9
                miclase.nonquery_sin_parametros(con, str_select)
            Next

            'inserta los vacios segun linea calculada
            For k As Integer = 1 To conta - 1
                miclase.nonquery_sin_parametros(con, str_select)
            Next

            'inserta los del dataset
            For Each fila In ds.Tables(0).Rows
                If fila("nnum") <> 99 Then
                    str_select = "insert into #t2" & ccodaho & "J" & _
                                 " (clinea, nnum, ctipope, dfecope, retiros, depositos, saldo) values " & _
                                 "(" & miclase1.ToString(fila("clinea")) & "," & fila("nnum") & "," & miclase1.ToString(fila("ctipope")) & "," & _
                                 miclase1.ToString(fila("dfecope")) & "," & fila("retiros") & "," & fila("depositos") & "," & fila("saldo") & ")"

                    miclase.nonquery_sin_parametros(con, str_select)

                End If
            Next

            str_select = "set language spanish; select case " & _
                         "when convert(varchar(2),nnum) = 0 then ' ' " & _
                         "else convert(varchar(2),nnum) end as cnum, " & _
                         "clinea, nnum ,ctipope, convert (varchar(10),dfecope,103) as dfecope, dfecope as fecha, " & _
                         "ctipope, convert(varchar(15),retiros) as retiros, convert(varchar(15),depositos) as depositos, convert(varchar(15),saldo) as saldo " & _
                         "from #t2" & ccodaho & "J" & " order by fecha, nnum"
            ds.Clear()
            ds = miclase.devolver_dataset(con, str_select)
            Dim dep As Decimal = 0, ret As Decimal = 0, sal As Decimal = 0, nmonto As Decimal = 0, dfecope As String, ctipope As String
            Dim nnum As Integer = 0
            For Each fila In ds.Tables(0).Rows
                If fila("ctipope") = "R" Then
                    ret = Decimal.Parse(fila("retiros"))
                    dep = 0
                Else
                    dep = Decimal.Parse(fila("depositos"))
                    ret = 0
                End If


                sal = Decimal.Parse(fila("saldo"))
                dfecope = fila("dfecope")
                nnum = fila("nnum")

                If ret > 0 Then
                    nmonto = ret
                    ctipope = "R"
                Else
                    nmonto = dep
                    ctipope = "D"
                End If

                If fila("nnum") = 0 Then
                    fila("dfecope") = ""
                    fila("retiros") = ""
                    fila("depositos") = ""
                    fila("saldo") = ""
                Else
                    If ret = 0 Then
                        fila("retiros") = ""
                    Else
                        fila("retiros") = Format(ret, "****" & "#,###,##0.00")
                    End If
                    If dep = 0 Then
                        fila("depositos") = ""
                    Else
                        fila("depositos") = Format(dep, "****" & "#,###,##0.00")
                    End If


                    fila("saldo") = Format(sal, "****" & "#,###,##0.00")


                    'actualiza las lineas impresas en la tabla ahommov
                    str_select = "update ahommov set clinea = 'S' where ccodaho = " & miclase1.ToString(ccodaho) & " and " & _
                                 "dfecope = " & miclase1.ToString(dfecope) & " and ctipope = " & miclase1.ToString(ctipope) & " and " & _
                                 "nmonto = " & nmonto & " and nnum = " & nnum
                    miclase.nonquery_sin_parametros(con, str_select)
                End If
            Next
        End If

        str_select = "drop table #t1" & ccodaho & "; drop table #t2" & ccodaho & "J" & ";"
        miclase.nonquery_sin_parametros(con, str_select)

        Return ds

    End Function
    Public Function habra_cambio_pagina(ByVal con As SqlConnection, ByVal ccodaho As String) As Boolean
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow
        Dim ds As New DataSet

        str_select = "set language spanish; " & _
                     "create table #t1" & ccodaho & " (clinea  varchar(1), nnum integer, ctipope varchar(1), dfecope  date,  retiros  decimal(8,2), depositos  decimal(8,2));"
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "insert into #t1" & ccodaho & "  select  clinea, nnum, ctipope, dfecope, nmonto, nmonto from ahommov " & _
                     "where ccodaho = " & miclase1.ToString(ccodaho) & " and clinea = 'N' order by dfecope, nnum; "
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "update #t1" & ccodaho & " set retiros = 0 where ctipope = 'D'; update #t1" & ccodaho & " set depositos  = 0 where ctipope = 'R'; "
        miclase.nonquery_sin_parametros(con, str_select)

        str_select = "select * from #t1" & ccodaho & " order by dfecope, nnum"
        ds = miclase.devolver_dataset(con, str_select)

        Dim c As Integer = 0
        Dim salto_pagina As Boolean = False
        Dim tot_lineas As Integer = ds.Tables(0).Rows.Count
        'recorre para saber si hay que saltar de pagina
        For Each fila In ds.Tables(0).Rows
            c = c + 1

            If fila("nnum") = 1 Or fila("nnum") = 65 Then
                salto_pagina = True
                Exit For
            End If


        Next

        str_select = "drop table #t1" & ccodaho
        miclase.nonquery_sin_parametros(con, str_select)

        Return salto_pagina

    End Function

    Public Function foto_firma_impresa(ByVal ccodcli As String, ByVal cual As Integer) As String
        Dim clii As String = Right(ccodcli, 9)
        Dim num As Integer = Integer.Parse(clii)
        Dim foto As String = num.ToString
        Dim foto1 As String = ""
        'Dim fisico As String = "c:/inetpub/wwwroot/wwwsim/fotos/"
        'Dim relativo As String = "~/fotos/"
        Dim huella1 As String = "c:/inetpub/wwwroot/wwwsim/fotos/"
        Dim huella As String = "c:/inetpub/wwwroot/wwwsim/fotos/"
        ' para sel server Dim huella As String = "c://inetpub/wwwroot/wwwsim/fotos/"
        If cual = 1 Then
            foto1 = huella & foto & "FOTO.jpg"
            If My.Computer.FileSystem.FileExists(foto1) Then

                foto1 = huella1 & foto & "foto.jpg"
            Else
                foto1 = huella & foto & "FOTO.png"
                If My.Computer.FileSystem.FileExists(foto1) Then
                    foto1 = huella1 & foto & "foto.png"

                Else
                    foto1 = huella & foto & "FOTO.bmp"
                    If My.Computer.FileSystem.FileExists(foto1) Then
                        foto1 = huella1 & foto & "foto.bmp"
                    Else
                        foto1 = huella & foto & "FOTO.gif"
                        If My.Computer.FileSystem.FileExists(foto1) Then
                            foto1 = huella1 & foto & "foto.gif"
                        Else
                            foto1 = huella1 & "cantinflas.jpg" '"basura"
                        End If
                    End If
                End If
            End If
        End If

        If cual = 2 Then
            foto1 = huella & foto & "FIRMA.jpg"
            If My.Computer.FileSystem.FileExists(foto) Then
                foto1 = huella1 & foto & "firma.jpg"
            Else
                foto1 = huella & foto & "FIRMA.png"
                If My.Computer.FileSystem.FileExists(foto) Then
                    foto1 = huella1 & foto & "firma.png"

                Else
                    foto1 = huella & foto & "FIRMA.bmp"
                    If My.Computer.FileSystem.FileExists(foto) Then
                        foto1 = huella1 & foto & "firma.bmp"
                    Else
                        foto1 = huella & foto & "FIRMA.gif"
                        If My.Computer.FileSystem.FileExists(foto) Then
                            foto1 = huella1 & foto & "firma.gif"
                        Else
                            foto1 = "basura"
                        End If
                    End If
                End If
            End If
        End If


        Return foto1
    End Function

    Public Function separar_lineas_impresion(ByVal con As SqlConnection, ByVal ccodaho As String) As DataSet
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim fila As DataRow
        Dim ds As New DataSet

        str_select = "select * from #t1" & ccodaho & " order by nnum"
        ds = miclase.devolver_dataset(con, str_select)

        Dim contador As Integer = 0
        Dim eliminar As Integer = 0
        Dim c As Integer = 1
        Dim c1 As Integer = 1
        Dim noborrar As Boolean = True

        Dim cuantas As Integer = ds.Tables(0).Rows.Count
        For Each fila In ds.Tables(0).Rows

            'para que tome el primero que trae
            If c = 1 Then
                contador = fila("nnum")
                eliminar = contador
                c = 0
            End If

            'If fila("nnum") = 1 Then
            '    If c1 = 1 Then
            '        noborrar = False
            '        c1 = 0
            '    End If

            'End If

            If contador <> fila("nnum") Then
                noborrar = True
                Exit For
            Else
                noborrar = False
            End If
            contador = contador + 1

        Next
        'If contador > 1 Then
        '    contador = contador - 1
        'End If

        If noborrar = True And cuantas > 1 Then
            'limpia la tabla, solo envia las lineas mayores  a imprimir
            str_select = "delete from #t1" & ccodaho & " where nnum <= " & contador
            miclase.nonquery_sin_parametros(con, str_select)
        End If

        ds.Clear()
        str_select = "select * from #t1" & ccodaho & " order by nnum"
        ds = miclase.devolver_dataset(con, str_select)


        Return ds
    End Function

    Public Function insertar_cntamov(ByVal con As SqlConnection, ByVal cnumcom As String, ByVal num As Integer, ByVal ccodcta As String, _
                                     ByVal clase As String, ByVal ndebe As Decimal, ByVal nhaber As Decimal, ByVal gdfecsis As String, _
                                     ByVal credito As String, ByVal socio As String, ByVal ccodusu As String, ByVal recibo As String, ByVal oficina As String) As Integer
        Dim str_select = ""
        Dim miclase1 As New clase_funciones
        Dim miclase As New clase_especial
        Dim error100 As Integer = 0

        str_select = "insert into cntamov " & _
        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
        "(' ', '01'," & miclase1.ToString(cnumcom) & "," & num & "," & miclase1.ToString(ccodcta) & "," & miclase1.ToString(clase) & "," & ndebe & ", " & nhaber & ", ' ', 0, " & miclase1.ToString(recibo.ToString.Trim) & ", " & _
        miclase1.ToString(gdfecsis) & ", " & miclase1.ToString(credito) & ", ' ', '12', " & miclase1.ToString(oficina) & ", ' ', ' ', " & miclase1.ToString(socio) & "," & miclase1.ToString(ccodusu) & "," & _
        " ' ', '1', 0, 0, " & miclase1.ToString(gdfecsis) & ")"

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return 1
        End If

        Return 0
    End Function
    Public Function sumario_carteras(ByVal fecha_cierre As String) As Boolean
        Dim str_select As String
        Dim miclase As New clase_especial()
        Dim miclase1 As New clase_funciones
        Dim ds_creditos As DataSet
        Dim fila_creditos As DataRow
        Dim ds As DataSet
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim cestado As String = ""
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection
        Dim error100 As Integer = 0

        con.Open()
        str_select = "set language spanish; delete sumario where dfecoper = " & miclase1.ToString(fecha_cierre)
        miclase.nonquery_sin_parametros(con, str_select)

        'esta es la forma nueva version jaime
        str_select = "SELECT CREMCRE.cCodCta, " & _
         "(select sum (nmonto) from  credkar  where ccodcta = cremcre.ccodcta and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto > 0) as ncapdes," & _
         "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from  credkar  where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto < 0) as ncappag," & _
         "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from  credkar  where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'KP' and nmonto > 0) as ncappag1 " & _
         " FROM CREMCRE " & _
         " WHERE cremcre.cestado = 'F'  "

        ds_creditos = miclase.devolver_dataset(con, str_select)

        str_select = "begin tran"
        miclase.nonquery_sin_parametros(con, str_select)
        Dim suma As Decimal = 0

        For Each fila_creditos In ds_creditos.Tables(0).Rows
            suma = fila_creditos("ncappag") + fila_creditos("ncappag1")

            str_select = "update cremcre set ncapdes = " & fila_creditos("ncapdes") & ", ncappag=" & suma & _
                         " where ccodcta = " & miclase1.ToString(fila_creditos("ccodcta"))
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback tran"
                miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False

            End If
        Next

        ' creditos corto plazo
        str_select = "set language spanish; select count(*) as casos, sum(cre.ncapdes-cre.ncappag) as saldo,  " & _
                     "tab.cDescri, LEFT(cre.cproducto,1) as linea " & _
                     "from  cremcre as cre,  tabttab as tab " & _
                     "where cre.cestado = 'F' and cre.ncuoapr <= 12 and " & _
                     "tab.ccodtab = '086' and  tab.ctipreg = '1' and " & _
                     "tab.ccodigo = left(cre.cproducto,1)  " & _
                     " group by tab.cdescri,LEFT(cre.cproducto,1) "

        ds = miclase.devolver_dataset(con, str_select)

        For Each fila In ds.Tables(0).Rows
            str_select = "insert into sumario " & _
                         "(casos, saldo, cdescri, linea, grupo, plazo, dfecoper) values " & _
                         "(" & fila("casos") & "," & fila("saldo") & "," & miclase1.ToString(fila("cdescri")) & "," & _
                         miclase1.ToString(fila("linea")) & ",'A','C'," & miclase1.ToString(fecha_cierre) & ")"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback tran"
                miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If
        Next

        ds.Clear()
        ' creditos largo plazo
        str_select = "set language spanish; select count(*) as casos, sum(cre.ncapdes-cre.ncappag) as saldo,  " & _
                     "tab.cDescri, LEFT(cre.cproducto,1) as linea " & _
                     "from  cremcre as cre,  tabttab as tab " & _
                     "where cre.cestado = 'F' and cre.ncuoapr >= 13 and " & _
                     "tab.ccodtab = '086' and  tab.ctipreg = '1' and " & _
                     "tab.ccodigo = left(cre.cproducto,1)  " & _
                     " group by tab.cdescri,LEFT(cre.cproducto,1) "

        ds = miclase.devolver_dataset(con, str_select)

        For Each fila In ds.Tables(0).Rows
            str_select = "insert into sumario " & _
                         "(casos, saldo, cdescri, linea, grupo, plazo, dfecoper) values " & _
                         "(" & fila("casos") & "," & fila("saldo") & "," & miclase1.ToString(fila("cdescri")) & "," & _
                         miclase1.ToString(fila("linea")) & ",'A','L'," & miclase1.ToString(fecha_cierre) & ")"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback tran"
                miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If
        Next

        ds.Clear()
        'ahorros
        str_select = "select sum(cta.nsaldoaho) as saldo, count(cta.ccodaho) as casos, tab.cdescri, " & _
                     "substring(lin.ccodlin,5,1) as linea " & _
                     "from ahomcta as cta, ahotlin as lin, tabttab as tab " & _
                     "where substring(cta.ccodaho,7,2) = substring(lin.cnrolin,4,2) and " & _
                     "tab.ccodtab = '186' and  tab.ctipreg = '1' and " & _
                     "tab.ccodigo = substring(lin.ccodlin,4,2) and " & _
                     "cta.nsaldoaho > 0 AND tab.ccodigo <> '07' " & _
                     "group by tab.cdescri, substring(lin.ccodlin,5,1)"

        ds = miclase.devolver_dataset(con, str_select)
        For Each fila In ds.Tables(0).Rows
            str_select = "insert into sumario " & _
                         "(casos, saldo, cdescri, linea, grupo, plazo, dfecoper) values " & _
                         "(" & fila("casos") & "," & fila("saldo") & "," & miclase1.ToString(fila("cdescri")) & "," & _
                          miclase1.ToString(fila("linea")) & "," & _
                         "'B','C'," & miclase1.ToString(fecha_cierre) & ")"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback tran"
                miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If

        Next

        ds.Clear()

        'depositos a plazo
        str_select = "select sum(nmonapr) as saldo, count(ccodcrt) as casos " & _
                     "from  ahomcrt " & _
                     "where  cliq <> 'S' and nmonapr > 0 "
        ds = miclase.devolver_dataset(con, str_select)
        For Each fila In ds.Tables(0).Rows
            str_select = "insert into sumario " & _
                         "(casos, saldo, cdescri, linea, grupo, plazo, dfecoper) values " & _
                         "(" & fila("casos") & "," & fila("saldo") & ",'AHORRO A PLAZO','7','B','C'," & _
                          miclase1.ToString(fecha_cierre) & ")"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback tran"
                miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return False
            End If


        Next
        str_select = "commit tran"
        miclase.nonquery_sin_parametros(con, str_select)
        con.Close()

        Return True

    End Function
    'certificado acceso al server
    Public Function certificado_jaime() As Boolean
        Dim resp As Boolean = True

        Dim clsRequest As System.Net.FtpWebRequest = _
            DirectCast(System.Net.WebRequest.Create("ftp://190.86.174.221/licencia.txt"), System.Net.FtpWebRequest)
        clsRequest.Credentials = New System.Net.NetworkCredential("administrador", "BlackBird$")
        clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile
        Try
            ' read in file...
            Dim bFile() As Byte = System.IO.File.ReadAllBytes("c:\windows\licencia.txt")

            ' upload file...

            'Dim clsStream As System.IO.Stream = _
            'clsRequest.GetRequestStream()
            'clsStream.Write(bFile, 0, bFile.Length)
            'clsStream.Close()
            'clsStream.Dispose()
        Catch ex As Exception
            resp = False
        End Try

        Return resp

    End Function
    'calcula el saldo de capital de una cta, desde la credkar, desde una db especifica
    'datase espera "bk01012012.dbo."
    Public Function calcular_saldo_capital(ByVal con As SqlConnection, ByVal database As String, ByVal ccodcta As String) As Decimal

        Dim str_select As String
        Dim saldo_cap As Decimal
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim credkar As String = database & "credkar"

        str_select = "select (select sum (nmonto) from " & credkar & " where ccodcta = " & miclase1.ToString(ccodcta) & " and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto > 0) " & _
                     " - ((select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END   from " & credkar & " where ccodcta = '001001011003383669' and cestado <> 'X' and cdescob <> 'D' and cconcep = 'KP' and nmonto > 0) + " & _
                    "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END   from " & credkar & " where ccodcta = " & miclase1.ToString(ccodcta) & "  and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto < 0))"

        saldo_cap = miclase.devolver_scalar1(con, str_select)

        Return saldo_cap
        'devuelve el saldo de capital

    End Function
    'clacula el desembolso, el capital pagado y la primera cuota pagada en desembolso
    Public Function cartera_completa_cuenta(ByVal con As SqlConnection, ByVal database As String, ByVal ccodcta As String) As DataSet
        'datase espera "bk01012012.dbo."
        Dim str_select As String
        Dim saldo_cap As Decimal
        Dim miclase As New clase_especial
        Dim ds As DataSet
        Dim fila As DataRow
        Dim cremcre As String = database & "cremcre"
        Dim credkar As String = database & "credkar"

        str_select = "select ccodcta, cproducto, " & _
        "(select sum (nmonto) from " & credkar & " where ccodcta = " & tostring(ccodcta) & " and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto > 0) as desembolso," & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = " & tostring(ccodcta) & " and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto < 0) as prma_cuota," & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = " & tostring(ccodcta) & " and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto > 0) as pagado, " & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'IN' and nmonto > 0) as Int_pagado, " & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'MO' and nmonto > 0) as Int_moratorio "



        ds = miclase.devolver_dataset(con, str_select)
        For Each fila In ds.Tables(0).Rows
            fila("prma_cuota") = IIf(IsDBNull(fila("prma_cuota")), 0, fila("prma_cuota"))
            fila("pagado") = IIf(IsDBNull(fila("pagado")), 0, fila("pagado"))
            fila("int_pagado") = IIf(IsDBNull(fila("int_pagado")), 0, fila("int_pagado"))
            fila("int_moratorio") = IIf(IsDBNull(fila("int_moratorio")), 0, fila("int_moratorio"))
            fila("pagado") = fila("desembolso") - fila("prma_cuota")
        Next

        Return ds  ' 1 solo registro
        ' devuelve 3 campos   desembolso, prma_cuota, pagado(el desembolso, la primera cuota pagada en desembolso y el cap pagado
        'para poder sacar el saldo de capital

    End Function
    'actualiza toda la cartera, ncapdes y ncappag
    Public Function update_cartera_completa(ByVal con As SqlConnection, ByVal database As String, _
                                            ByVal gdfecsis As Date, ByVal gnComTra As Decimal, ByVal gnSegVm As Decimal, _
                                            ByVal gnperbas As Integer) As Integer

        'datase espera "bk01012012.dbo."
        Dim cremcre As String = database & "cremcre"
        Dim credkar As String = database & "credkar"
        Dim str_select As String
        Dim saldo_cap As Decimal
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim fila As DataRow
        Dim actualizado As Decimal

        'gdfecsis = DateAdd(DateInterval.Day, 1, gdfecsis)

        'el campo ntipcam es utilizado en los backup para saber si esta actualizada la info pra no volver a recalcularlo
        '1=actualizado 0=no actualizado
        str_select = "select top 1 max(ntipcam) from " & cremcre & " where cestado = 'F' "
        actualizado = miclase.devolver_scalar1(con, str_select)

        'campo actualizado sirve para no volver a recalcular
        If actualizado = 1 Then
            Return 0
        End If


        'Dim lcampos1 As String
        'Dim ltipos1 As String
        'Dim lcmora As DataTable


        'lcampos1 = "ccodcta, cnomcli, ncapdes, dfecvig, dfecven, ncapmora, nsalcap, nsalint, nsalmor, ndiaatr, nsalintmor,cdirdom, dultpag, nseguros, nsegdeu, ncomision, ncuota, ccalifica, ccalificades, cfiador,cteldom, npagar30, npagar60, ccodsol, cnomgru, ccodcen, cnomcen, npar30num, npar30sal, npar30mor,cflag,cproducto,cdespro,ncalif1,ncalif2,ncalif3,ncalif4,ncalif5,ncalif6,ncalif7,ncalif8,npar60num, npar60sal, npar60mor,npar90num, npar90sal, npar90mor, ccodana, cnomana,"
        'ltipos1 = "S,S,D,F,F,D,D,D,D,D,D,S,F,D,D,D,D,S,S,S,S,D,D,S,S,S,S,D,D,D,S,S,S,D,D,D,D,D,D,D,D,D,D,D,D,D,D,S,S,"
        'lcMORA = clsprin.creadatasetdesconec(lcampos1, ltipos1, "MORA")


        Dim ecredppg As New cCredppg
        Dim clsaplica As New SIM.BL.payment
        Dim clsppal As New class1
        Dim claseaditivo As New cClsAditivos
        Dim lnsalteo As Decimal
        Dim lnintereteo As Decimal

        Dim interes_normal As Decimal
        Dim interes_moratorio As Decimal
        Dim capital_mora As Decimal
        Dim dias_atraso As Integer

        str_select = "select ccodcta, ccodcli, cproducto, ndiaatr, ccalif, dfecvig, dfecven, dultpag, ccondic," & _
        "nintcal, nintpag, nintpen, nintmor, nmorpag, npagcta, nmorak," & _
        "(select sum (nmonto) from " & credkar & " where ccodcta = cremcre.ccodcta and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto > 0) as ncapdes," & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto < 0) as primera_cuota," & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'KP' and nmonto > 0) as capital_pagado, " & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'IN' and nmonto > 0) as Int_pagado, " & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'MO' and nmonto > 0) as Int_moratorio " & _
        "from " & cremcre & " where cestado = 'F' "

        ds = miclase.devolver_dataset(con, str_select)
        Dim dia As Integer

        For Each fila In ds.Tables(0).Rows

            clsaplica.pccodcta = fila("ccodcta")
            clsaplica.pdfecval = gdfecsis
            clsaplica.gdfecsis = gdfecsis
            clsaplica.gnperbas = gnperbas
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"

            clsppal.gnperbas = gnperbas
            clsppal.pnComtra = gnComTra
            clsppal.pnSegVm = gnSegVm

            'clsaplica.omcalcinterest("T")

            interes_normal = utilNumeros.Redondear(clsaplica.pnsalint, 2)
            interes_moratorio = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
            capital_mora = utilNumeros.Redondear(clsaplica.pndeucap, 2)
            dias_atraso = utilNumeros.Redondear(clsaplica.pndiaatr, 0)

            '"ndiaatr=" & dias_atraso & "," & _
            '"nmorak=" & capital_mora & "," & _
            '"nintcal=" & interes_normal & "," & _
            '"nintmor=" & interes_moratorio & "," & _


            str_select = "update " & cremcre & " set " & _
                         "ncapdes=" & fila("ncapdes") & "," & _
                         "ncappag=" & fila("primera_cuota") + fila("capital_pagado") & "," & _
                         "ntipcam=1" & _
                         " where ccodcta = " & miclase1.ToString(fila("ccodcta"))

            miclase.nonquery_sin_parametros(con, str_select)
        Next

        Return 0

    End Function
    'calcula interes normal, basado en la ultima fecha que toco capital
    'datase espera "bk01012012.dbo."
    Public Function calcular_interes_normal(ByVal con As SqlConnection, ByVal database As String, ByVal ccodcta As String, _
                                            ByVal gdfecsis As Date, ByVal gnperbas As Integer) As Decimal
        Dim credkar As String = database & "credkar"
        Dim cremcre As String = database & "cremcre"
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim fila As DataRow
        Dim dias As Integer
        Dim interes As Decimal
        Dim fecha As Date
        Dim saldo As Decimal = 0
        Dim tasa As Decimal = 0

        'calcula el saldo de cap
        saldo = calcular_saldo_capital(con, database, ccodcta)

        'trae la tasa de interes
        str_select = "select max(ntasint) from " & cremcre & " where ccodcta = " & miclase1.ToString(ccodcta)
        tasa = miclase.devolver_scalar1(con, str_select)


        'ultima fecha que toco capital
        str_select = "select MAX(dfecpro) from " & credkar & " where ccodcta = " & miclase1.ToString(ccodcta) & " and cconcep = 'KP' and cestado <> 'X'  "
        fecha = miclase.devolver_scalar1(con, str_select)

        If IsDBNull(fecha) Then
            interes = 0.0
        Else
            dias = DateDiff(DateInterval.Day, fecha, gdfecsis)
            interes = Round(saldo * dias * tasa / 100 / gnperbas, 2)
        End If

        Return interes

    End Function
    'calcula el capital en mora
    'database espera "bk01012012.dbo."
    Public Function calcular_capital_mora(ByVal con As SqlConnection, ByVal database As String, ByVal ccodcta As String, ByVal gdfecsis As Date) As Decimal
        Dim credppg As String = database & "credppg"
        Dim credkar As String = database & "credkar"
        Dim cremcre As String = database & "cremcre"
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim fila As DataRow
        Dim fecha As String = gdfecsis
        Dim capital_teorico As Decimal = 0
        Dim cap_mora As Decimal = 0
        Dim saldo_capital As Decimal = 0
        Dim saldo_capital_teorico As Decimal = 0
        Dim desembolso As Decimal = 0

        'para saber si es ampliado o no y obtener el saldo de capital
        str_select = "select dultres, nmonres, " & _
        "(select sum (nmonto) from " & credkar & " where ccodcta = cremcre.ccodcta and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto > 0) as ncapdes," & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'D' and cconcep = 'KP' and nmonto < 0 and dfecpro <= " & miclase1.ToString(fecha) & ") as primera_cuota," & _
        "(select CASE IsNull(sum (abs(nmonto)),0) WHEN 0 THEN 0 ELSE sum (abs(nmonto)) END  from " & credkar & " where ccodcta = Cremcre.ccodcta and cestado <> 'X' and cdescob = 'C' and cconcep = 'KP' and nmonto > 0 and dfecpro <= " & miclase1.ToString(fecha) & ") as capital_pagado " & _
        " from " & cremcre & " where ccodcta = " & miclase1.ToString(ccodcta)
        ds = miclase.devolver_dataset(con, str_select)
        For Each fila In ds.Tables(0).Rows
            saldo_capital = fila("ncapdes") - (fila("primera_cuota") + fila("capital_pagado"))
            desembolso = fila("ncapdes")
        Next

        'para saber el capital pagado teorico
        str_select = "select sum(ncapita) from " & credppg & " where dfecven <= " & miclase1.ToString(fecha) & _
                     " and ccodcta = " & miclase1.ToString(ccodcta) & " and ctipope <> 'D'"
        capital_teorico = miclase.devolver_scalar1(con, str_select)
        capital_teorico = IIf(IsDBNull(capital_teorico), 0, capital_teorico)

        saldo_capital_teorico = desembolso - capital_teorico

        cap_mora = saldo_capital - saldo_capital_teorico

        If cap_mora <= 0 Then
            cap_mora = 0
        End If

        Return cap_mora

    End Function
    'calcula los dias de atraso
    'database espera "bk01012012.dbo."
    Public Function calcular_dias_atraso(ByVal con As SqlConnection, ByVal database As String, ByVal ccodcta As String, ByVal gdfecsis As Date) As Integer
        Dim credppg As String = database & "credppg"
        Dim credkar As String = database & "credkar"
        Dim cremcre As String = database & "cremcre"
        Dim str_select As String
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim fila As DataRow
        Dim fecha As String = gdfecsis
        Dim dias As Integer = 0
        Dim ampliado As Decimal = 0
        Dim fec_ampliado As String = ""
        Dim capital_pagado As Decimal = 0
        Dim cap_cubierto As Decimal = 0
        Dim fec_cubre As Date

        str_select = "select nmonres, dultres from " & cremcre & " where ccodcta = " & miclase1.ToString(ccodcta)

        ds = miclase.devolver_dataset(con, str_select)
        For Each fila In ds.Tables(0).Rows
            ampliado = IIf(IsDBNull(fila("nmonres")), 0, fila("nmonres"))
            fec_ampliado = IIf(IsDBNull(fila("dultres")), "01-01-1970", fila("dultres"))
        Next

        If ampliado = 0 Then  'normal o ampliada en sim.net
            str_select = "select sum(abs(nmonto)) from " & credkar & " where ccodcta = " & miclase1.ToString(ccodcta) & _
                         " and cestado <> 'X' and ((cconcep = 'KP' and cdescob <> 'D' and nmonto > 0) or (cconcep = 'KP' and cdescob = 'D' and nmonto < 0)) " & _
                         " and dfecpro <= " & miclase1.ToString(fecha)
        Else   'ampliada con el sim en fox
            str_select = "select sum(abs(nmonto)) from " & credkar & " where ccodcta = " & miclase1.ToString(ccodcta) & _
                         " and cestado <> 'X' and ((cconcep = 'KP' and cdescob <> 'D' and nmonto > 0) or (cconcep = 'KP' and cdescob = 'D' and nmonto < 0)) and dfecpro >= " & miclase1.ToString(fec_ampliado) & _
                         " and dfecpro <= " & miclase1.ToString(fecha)
        End If

        capital_pagado = miclase.devolver_scalar1(con, str_select)

        ds.Clear()

        str_select = "select dfecven, ncapita from " & credppg & " where ccodcta = " & miclase1.ToString(ccodcta) & _
                     " and ctipope <> 'D' order by dfecven"

        ds = miclase.devolver_dataset(con, str_select)

        For Each fila In ds.Tables(0).Rows

            If capital_pagado >= 0 Then
                fec_cubre = fila("dfecven")
                capital_pagado = capital_pagado - fila("ncapita")
            End If
            If capital_pagado <= 0 Then
                Exit For
            End If
        Next

        dias = DateDiff(DateInterval.Day, fec_cubre, gdfecsis)

        Return dias

    End Function


    Public Function nombre_server() As String
        Dim str_select As String
        Dim saldo_cap As Decimal
        Dim miclase As New clase_especial
        Dim ds As DataSet
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim cestado As String = ""
        Dim stringconnection As String = miclase.conexion()
        Dim nombre As String
        con.ConnectionString = stringconnection

        str_select = "select @@SERVERNAME as nombre"

        con.Open()
        ds = miclase.devolver_dataset(con, str_select)
        For Each fila In ds.Tables(0).Rows
            nombre = fila("nombre")
        Next
        If nombre = "SERVER" Then
            nombre = "PRODUCCION-ESA"
        ElseIf nombre = "SRVSIHUACOOP" Then
            nombre = "LA NUBE(MIAMI)"
        Else
            nombre = "DESARROLLO"
        End If

        con.Close()

        Return nombre

    End Function
    Public Function PDF_Bytes(ByVal Path As String) As Byte()
        Dim sPath As String
        sPath = Path
        Dim Ruta As New FileStream(sPath, FileMode.Open, FileAccess.Read)
        Dim Binario(Integer.Parse(Ruta.Length)) As Byte
        Ruta.Read(Binario, 0, Integer.Parse(Ruta.Length))
        Ruta.Close()
        Return Binario
    End Function

    Public Sub PDFtoByte(ByVal path As String, ByVal filename As String, ByVal fecha As Date)
        Dim miclase As New clase_especial
        Dim sqlTran As SqlTransaction
        Dim comando As SqlCommand
        Dim strSQL As New StringBuilder

        If filename.Trim = "" Then
            Return
        End If

        Dim pdfb As Byte()
        'Se convierte el archivo a una matriz de BYtes
        pdfb = PDF_Bytes(path + filename + ".pdf")

        strSQL.Append("insert into Reportes(ccodrep,datos,dfecha)")
        strSQL.Append(" values(@ccodrep, @pdf, @dfecant)")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@pdf", SqlDbType.Binary)
        args(0).Value = pdfb
        args(1) = New SqlParameter("@dfecant", SqlDbType.DateTime)
        args(1).Value = fecha
        args(2) = New SqlParameter("@ccodrep", SqlDbType.VarChar)
        args(2).Value = filename

        Using con As New SqlConnection(miclase.conexion)
            con.Open()
            sqlTran = con.BeginTransaction
            comando = con.CreateCommand
            comando.Transaction = sqlTran

            Try
                comando.CommandText = strSQL.ToString
                comando.CommandType = CommandType.Text
                comando.Parameters.AddRange(args)

                comando.ExecuteNonQuery()

                sqlTran.Commit()

                con.Close()
            Catch ex As Exception
                sqlTran.Rollback()
            Finally
                If (con.State = ConnectionState.Open) Then
                    con.Close()
                End If
            End Try
        End Using
    End Sub

    'La ruta debe venir con formato c:\txt\carpeta\
    'y el nombre del archivo con formato reporte+fecha
    Public Sub ByteToPDF(ByVal path As String, ByVal filename As String)

        Dim miclase As New clase_especial
        Dim clase As New clase_funciones

        path = path + filename + ".pdf"

        If File.Exists(path) Then
            File.Delete(path)
        End If

        Try
            Dim aBytDocumento() As Byte = Nothing
            Dim oFileStream As FileStream
            Dim lsQuery As String = "Select * From Reportes Where ccodrep =" + clase.ToString(filename)
            Using loConexion As New SqlConnection(miclase.conexion())
                Using loComando As New SqlCommand(lsQuery, loConexion)
                    loConexion.Open()
                    Using drDocumentos As SqlDataReader = loComando.ExecuteReader(CommandBehavior.SingleRow)
                        If drDocumentos.Read() Then
                            aBytDocumento = TryCast(drDocumentos("Datos"), Byte())
                        End If
                    End Using
                End Using
                oFileStream = New FileStream(path, FileMode.CreateNew, FileAccess.Write)
                oFileStream.Write(aBytDocumento, 0, aBytDocumento.Length)
                oFileStream.Close()
            End Using

            'Esto solo funcionaria en el Server por ser un proceso
            'Dim loPSI As New ProcessStartInfo
            'Dim loProceso As New Process
            'loPSI.FileName = path
            'loProceso = Process.Start(loPSI)

        Catch Exp As Exception

        End Try
    End Sub

    Public Function VerificarExisteReporte(ByVal reporte As String) As Integer
        Dim miclase As New clase_especial
        Dim clase As New clase_funciones
        Dim con As New SqlConnection(miclase.conexion)
        Dim resultado As Integer

        Dim strSelect As New StringBuilder("select COUNT(*) from Reportes where ccodrep =" + clase.ToString(reporte))

        con.Open()
        resultado = miclase.devolver_scalar1(con, strSelect.ToString)
        con.Close()

        Return resultado
    End Function
End Class
