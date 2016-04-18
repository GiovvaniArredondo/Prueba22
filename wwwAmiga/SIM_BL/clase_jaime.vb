Imports System.Math
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Web.Configuration


Public Class clase_jaime
    'Inherits dbBase
    '
    ' la string para la conexion
    Public Function conexion() As String
        'Return (WebConfigurationManager.ConnectionStrings("sihuaConnectionString").ConnectionString)
        Dim ecreditos As New ccreditos
        Return ecreditos.CadenaActual
    End Function
    ' para leer ctas del catalogo para el cuadre
    Public Function leer_catalogo_cuadre(ByVal ccodcta1 As String, ByVal ccodcta2 As String) As Decimal
        Dim reader As SqlDataReader = Nothing
        Dim con As New SqlConnection
        Dim miclase As New clase_jaime
        Dim stringconnection As String = conexion()
        con.ConnectionString = stringconnection
        Dim str_select As String = ""
        Dim respuesta As Decimal = 0
        str_select = "select sum(nsalini) from ctbmcta where ccodcta >= @ccodcta1 and ccodcta <= @ccodcta2"

        con.Open()
        Dim comando As New SqlCommand(str_select, con)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@ccodcta1", ccodcta1)
        comando.Parameters.AddWithValue("@ccodcta2", ccodcta2)

        Try
            respuesta = comando.ExecuteScalar()
        Catch ex As Exception
            respuesta = 0
        End Try

        con.Close()
        Return respuesta

    End Function
    ' para leer movimientos para cuadre
    Public Function leer_movimiento_cuadre(ByVal ccodcta1 As String, ByVal ccodcta2 As String, ByVal dfeccnt As Date, ByVal tipo As Char) As Decimal
        Dim reader As SqlDataReader = Nothing
        Dim con As New SqlConnection
        Dim miclase As New clase_jaime
        Dim stringconnection As String = conexion()
        con.ConnectionString = stringconnection
        Dim str_select As String = ""
        Dim respuesta As Decimal = 0
        If tipo = "D" Then
            str_select = "SET LANGUAGE spanish; select  sum(ndebe) from cntamov where ccodcta >= @ccodcta1 and ccodcta <= @ccodcta2 and dfeccnt <= @dfeccnt"
        Else
            str_select = "SET LANGUAGE spanish; select  sum(nhaber) from cntamov where ccodcta >= @ccodcta1 and ccodcta <= @ccodcta2 and dfeccnt <= @dfeccnt"
        End If

        con.Open()
        Dim comando As New SqlCommand(str_select, con)
        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@ccodcta1", ccodcta1)
        comando.Parameters.AddWithValue("@ccodcta2", ccodcta2)
        comando.Parameters.AddWithValue("@dfeccnt", dfeccnt)

        Try
            respuesta = Decimal.Round(comando.ExecuteScalar(), 2)
        Catch ex As Exception
            respuesta = 0
        End Try

        con.Close()
        Return respuesta

    End Function
    ' lee ctas de ahorro
    Public Function leer_ctas_ahorro(ByVal con As SqlConnection, ByVal str_select As String) As DataTable
        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet("ahomcta")
        adapter.Fill(ds, "ahomcta")
        Dim tabla As DataTable
        tabla = ds.Tables("ahomcta")

        Return tabla
    End Function
    ' para leer movimientos de las ctas de ahorro
    Public Function leer_mov_ahorro(ByVal con As Object, ByVal ccodaho As String, ByVal fec_desde As Date, ByVal fec_hasta As Date) As SqlDataReader

        Dim reader As SqlDataReader
        Dim str_select As String

        str_select = "SET LANGUAGE spanish; select dfecope, nsaldoaho from ahommov where ccodaho = @ccodaho and dfecope >= @fec_desde and dfecope <= @fec_hasta order by dfecope"

        Dim comando As New SqlCommand(str_select, con)

        comando.CommandType = CommandType.Text
        comando.Parameters.AddWithValue("@ccodaho", ccodaho)
        comando.Parameters.AddWithValue("@fec_desde", fec_desde)
        comando.Parameters.AddWithValue("@fec_hasta", fec_hasta)

        reader = Nothing

        Try
            reader = comando.ExecuteReader()
        Catch ex As Exception
            reader = Nothing
        End Try
        Return reader
    End Function
    ' para devolver los creditos para DICOM
    Public Function leer_dicom(ByVal con As SqlConnection, ByVal fecha_ori As String) As DataTable
        Dim miclase1 As New clase_funciones
        Dim fecha_lim As String
        fecha_lim = fecha_ori
        Dim str_select As String

        str_select = "SET LANGUAGE spanish; select cli.ccodcli, cli.cnudotr, cli.cnomcli, cli.dnacimi, cli.cnudoci, cli.cdirdom, cre.ccodcta, cre.ncapdes, cre.ncappag, cre.dfecvig, cre.dfecven, " & _
                 "cre.cestado, cre.ndiaatr, cre.nmonapr, cre.nmoncuo, cre.ncuosug, cre.nmorak from cremcre as cre, climide as cli " & _
                 "where ((cre.cestado = 'F' AND cre.dfecvig <= '" & fecha_lim & "') or (cre.cestado = 'G' AND cre.ncapdes = cre.ncappag)) AND cre.ccodcli = cli.ccodcli"

        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "cremcre")
        Dim tabla As DataTable
        tabla = ds.Tables("cremcre")

        Return tabla
    End Function
    ' para devolver las fechas de pago 
    Public Function leer_pagos(ByVal con As SqlConnection, ByVal ccodcta As String, ByVal mes As Integer, ByVal ano As Integer) As DataTable
        Dim str_select As String

        str_select = "SET LANGUAGE spanish; select dfecsis from credkar " & _
                "where ccodcta = '" & ccodcta & "'" & " and Month(dfecsis) = " & mes & " and Year(dfecsis) = " & _
                ano

        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "credkar")
        Dim tabla As DataTable
        tabla = ds.Tables("credkar")

        Return tabla
    End Function
    ' para devolver los dividendos de un periodo de un asociado
    Public Function leer_dividendos(ByVal con As SqlConnection, ByVal periodo As Integer) As DataTable

        Dim error100 As Integer

        Dim str_select As String

        str_select = "SET LANGUAGE spanish; select aho.ccodaho, cli.ccodcli, cli.cnomcli as nombre, cli.cnudotr as nit, aho.dfecope as fecha,  aho.nmonto as utilidad, " & _
                         "aho.ncomple as complemento, aho.nsaldoaho as acciones from ahompro as aho, climide as cli where year(aho.dfecope) = " & periodo & _
                         " and aho.ccodcli = cli.ccodcli"

        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()
        Try
            adapter.Fill(ds, "ahompro")
        Catch ex As Exception
            error100 = -100
        End Try

        Dim tabla As DataTable
        tabla = ds.Tables("ahompro")

        Return tabla
    End Function
    ' para buscar asociados por nombre o no de asociado
    Public Function buscar_asociado(ByVal con As SqlConnection, ByVal asociado As String) As DataSet
        If asociado.Length = 0 Then
            asociado = "001000110757"
        End If

        Dim error100 As Integer
        Dim str_select As String
        Dim letra As Char = Left(asociado, 1)

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            str_select = "select ccodcli as asociado, cnomcli as nombre, cnudoci as dui, cnudotr as nit, cbenef1 as colegio, cteldom, cdirdom " & _
                             " from climide where ccodcli like " & "'%" & asociado.Trim & "%' order by ccodcli"
        Else
            str_select = "select ccodcli as asociado, cnomcli as nombre, cnudoci as dui, cnudotr as nit,  cbenef1 as colegio, cteldom, cdirdom  " & _
                             " from climide where cnomcli like " & "'%" & asociado.Trim & "%' order by cnomcli"
        End If


        'and  substring(ccodcli,1,3) = '001' 
        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds, "climide")
        Catch ex As Exception
            error100 = -100
        End Try

        Return ds
    End Function

    ' para buscar asociados por nombre o no de asociado
    Public Function buscar_asociado1(ByVal con As SqlConnection, ByVal asociado As String) As DataSet
        If asociado.Length = 0 Then
            asociado = "001000110757"
        End If

        Dim error100 As Integer
        Dim str_select As String
        Dim letra As Char = Left(asociado, 1)

        'substring(ccodcli,1,3) = '001' and 
        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            str_select = "select ccodcli, cnomcli, cnudoci, cnudotr as nit, space(1) as colegio " & _
                         " from climide where  ccodcli like " & "'%" & asociado.Trim & "%' order by ccodcli"
        Else
            str_select = "select ccodcli, cnomcli, cnudoci, cnudotr as nit, space(1) as colegio " & _
                         " from climide where  cnomcli like " & "'%" & asociado.Trim & "%' order by cnomcli"
        End If
        'substring(ccodcli,1,3) = '001' and 

        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds, "climide")
        Catch ex As Exception
            error100 = -100
        End Try

        Return ds
    End Function

    Public Function buscar_asociado_porstatus(ByVal con As SqlConnection, ByVal asociado As String, ByVal cstatus As String) As DataSet
        Dim error100 As Integer
        Dim str_select As String
        Dim letra As Char = Left(asociado, 1)
        If asociado.Trim = "" Then
            str_select = "select climide.ccodcli as asociado, climide.cnomcli as nombre, climide.cnudoci as dui, climide.cnudotr as nit, climide.pin, climide.cbenef1 as colegio " & _
                             " from climide, cremcre where climide.ccodcli = cremcre.ccodcli and substring(climide.ccodcli,1,3) = '001'   "

        Else
            If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
                str_select = "select climide.ccodcli as asociado, climide.cnomcli as nombre, climide.cnudoci as dui, climide.cnudotr as nit, climide.pin, climide.cbenef1 as colegio " & _
                                 " from climide, cremcre where climide.ccodcli = cremcre.ccodcli and substring(climide.ccodcli,1,3) = '001' and climide.ccodcli like " & "'%" & asociado.Trim & "%'  "
            Else
                str_select = "select climide.ccodcli as asociado, climide.cnomcli as nombre, climide.cnudoci as dui, climide.cnudotr as nit, climide.pin, climide.cbenef1 as colegio " & _
                                 " from climide, cremcre where climide.ccodcli = cremcre.ccodcli and substring(climide.ccodcli,1,3) = '001' and climide.cnomcli like " & "'%" & asociado.Trim & "%'  "
            End If

        End If


        If cstatus = "1" Then
            str_select = str_select & " and cremcre.cestado ='F' "
        ElseIf cstatus = "2" Then
            str_select = str_select & " and cremcre.cestado ='G' "
        ElseIf cstatus = "3" Then
            str_select = str_select & " and cremcre.cestado ='A' "
        ElseIf cstatus = "4" Then
            str_select = str_select & " and cremcre.cestado ='C' "
        ElseIf cstatus = "5" Then
            str_select = str_select & " and cremcre.cestado ='E' "
        ElseIf cstatus = "6" Then
            str_select = str_select & " and cremcre.ccodrec <> ' ' "
        Else

            str_select = str_select & " order by climide.cnomcli"
        End If
        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds, "climide")
        Catch ex As Exception
            error100 = -100
        End Try

        Return ds
    End Function
    ' para devolver las ctas de ahorro de un asociado
    Public Function buscar_ctas_ahorro(ByVal con As SqlConnection, ByVal asociado As String, ByVal caso As Integer) As DataSet
        Dim error100 As Integer
        Dim str_select As String = ""

        'nota la variable caso ya no es necesaria

        str_select = "Select   aho.ccodaho as cuenta, isnull(aho.ccodaho_ant,'') as ccodaho_ant, " & _
                     " 'tipo_cta'= case substring(aho.ccodaho,7,2) " & _
                     "when '01' then 'CTA. CONCENTRADORA' " & _
                     "when '02' then 'CTA. GARANTIA LIQUIDA' " & _
                     "when '03' then 'SUBSIDIO FEDERAL' " & _
                     "when '04' then 'PAGO IN' " & _
                     "when '05' then 'VISIONARIO' " & _
                     "when '06' then 'APORTACIONES'  end, " & _
                     " Case aho.cestado" & _
                     " WHEN 'A' THEN 'ACTIVO'" & _
                     " WHEN 'I' THEN 'INACTIVO'" & _
                     " WHEN 'P' THEN 'BLOQUEADA'" & _
                     " WHEN 'C' THEN 'CANCELADA'" & _
                     " WHEN 'E' THEN 'EMBARGADA'" & _
                     " WHEN 'U' THEN 'ANULADA'" & _
                     " ELSE 'OTROS' end as cestado," & _
                     "aho.nsaldoaho as saldo, aho.notas, aho.nlibreta, (case when aho.apellido is null then '' else aho.apellido end) as apellido, aho.nmonres, aho.cbloqueo, aho.llave, aho.producto " & _
                     " from climide  as cli, ahomcta as aho " & _
                     "where cli.ccodcli = '" & asociado & "'" & " and cli.ccodcli = aho.cnudotr order by aho.ccodaho"



        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds, "climide")
        Catch ex As Exception
            error100 = -100
        End Try

        Return ds
    End Function
    ' para devolver todos los creditos vivos de un asociado
    Public Function buscar_creditos(ByVal con As SqlConnection, ByVal asociado As String) As DataSet
        Dim error100 As Integer
        Dim str_select As String

        str_select = "SET LANGUAGE spanish; select ccodcta as cuenta, dfecvig as vigencia, ncapdes as desembolso, nmoncuo as cuota, ncapdes - ncappag as saldo " & _
                         "from cremcre where ccodcli = '" & asociado & "' and cestado = 'F'  order by dfecvig"

        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds, "cremcre")
        Catch ex As Exception
            error100 = -100
        End Try

        Return ds
    End Function
    ' para devolver dataset
    Public Function devolver_dataset(ByVal con As SqlConnection, ByVal str_select As String) As DataSet
        Dim miclase1 As New clase_funciones
        Dim extra As String
        Dim str_select1 As String = ""
        Dim basura As String = str_select
        Dim error100 As Integer = 0
        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)

        Dim ds As New DataSet()
        Try
            adapter.SelectCommand.CommandTimeout = 0
            adapter.Fill(ds, "tabla")
        Catch ex As Exception
            extra = ex.ToString
            error100 = -100
            basura = basura & " " & extra
            basura = basura.Replace("'", " ")
            str_select1 = "insert into errores (error) values (" & miclase1.ToString(basura) & ")"
            nonquery_sin_parametros_especial(con, str_select1)
            Return Nothing

        End Try

        Return ds
    End Function
    ' para  devolver valores como sum(), max(), min(), avg()
    Public Function devolver_scalar1(ByVal con As SqlConnection, ByVal str_select As String) As Object
        Dim error100 As Integer

        Dim devolver As Object = Nothing
        Dim comando As New SqlCommand(str_select, con)
        comando.CommandType = CommandType.Text
        Try
            devolver = comando.ExecuteScalar()
            If IsDBNull(devolver) Then
                devolver = 0
            End If
        Catch ex As Exception
            error100 = -100
            devolver = -100
        End Try

        Return devolver
    End Function

    ' para los insert, delete, update
    Public Function nonquery_sin_parametros(ByVal con As SqlConnection, ByVal str_select As String) As Integer
        Dim error100 As Integer = 0
        Dim miclase1 As New clase_funciones

        Dim extra As String = ""
        Dim basura As String = str_select

        Dim str_select1 As String = ""
        Dim comando As New SqlCommand(str_select, con)
        comando.CommandType = CommandType.Text
        Try
            error100 = comando.ExecuteNonQuery()
        Catch ex As Exception
            extra = ex.ToString
            error100 = -100
            basura = basura & " " & extra
            basura = basura.Replace("'", " ")
            str_select1 = "insert into errores (error) values (" & miclase1.ToString(basura) & ")"
            nonquery_sin_parametros_especial(con, str_select1)
        End Try
        Return error100
    End Function
    Public Function nonquery_sin_parametros_especial(ByVal con As SqlConnection, ByVal str_select As String) As Integer

        Dim error100 As Integer = 0
        Dim miclase1 As New clase_funciones
        Dim comando As New SqlCommand(str_select, con)
        comando.CommandType = CommandType.Text
        Try
            error100 = comando.ExecuteNonQuery()
        Catch ex As Exception
            error100 = -100
        End Try
        Return error100
    End Function


    Public Function crear_datatable_manual(ByVal pcampos As String, ByVal ptipos As String, ByVal pnomtab As String) As DataTable
        '*******ejempo de sintaxis de funcion creadatasetdesconec *****
        '        lcampos = "cnrolin, ccodlin, cdeslin,"
        '       ltipos = "S,I,F"
        '       lnomtab = "Datos"
        '      dstmp = ws.creadatasetdesconec(lcampos, ltipos,lnomtab)
        '     Me.dglineas.DataSource = dstmp.Tables("Datos")
        '********finaliza sintaxis de la clase **************

        'sintaxis de la clase
        Dim lcampos As String
        Dim ltipos As String


        Dim x As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String

        Dim dsnew As New DataSet
        Dim dt As New DataTable(pnomtab)
        Dim dc As New DataColumn
        '*************************************************
        'evalua datos y tipos de datos enviados

        i = 0

        '--------------------------------------------------------
        'Proceso que parte cada uno de los parametros enviados
        '--------------------------------------------------------

        'Halla numero de parametros

        For x = 0 To pcampos.Length - 1
            If pcampos.Substring(x, 1) = "," Then
                i += 1
            End If
        Next

        'Declara arreglo segun cantidad de parametros
        Dim campos(i) As String 'campos
        Dim TipoD(i) As String  'tipos
        Dim conte(i) As String  'contenidos

        '----------------------------------
        'Sacando los campos
        '----------------------------------

        i = 0
        j = 0
        k = 1

        For x = 0 To pcampos.Length - 1
            If pcampos.Substring(x, 1) = "," Then
                campos(k) = pcampos.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        campo1 = campos(1)
        campo2 = campos(2)

        '----------------------------------
        'Sacando los Tipos
        '----------------------------------
        i = 0
        j = 0
        k = 1

        For x = 0 To ptipos.Length - 1
            If ptipos.Substring(x, 1) = "," Then
                TipoD(k) = ptipos.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next


        'inicia proceso de la funcion
        Dim tipo As String
        Dim camp As String
        dt.Columns.Add(dc)

        For i = 1 To TipoD.Length - 1
            tipo = TipoD(i)
            camp = campos(i).Trim
            If tipo = "S" Then
                dt.Columns.Add(camp, Type.GetType("System.String")) 'string
            ElseIf tipo = "I" Then
                dt.Columns.Add(camp, Type.GetType("System.Int32")) 'entero
            ElseIf tipo = "F" Then
                dt.Columns.Add(camp, Type.GetType("System.DateTime")) 'fecha
            ElseIf tipo = "B" Then
                dt.Columns.Add(camp, Type.GetType("System.Boolean")) 'boolena
            ElseIf tipo = "D" Then
                dt.Columns.Add(camp, Type.GetType("System.Double")) 'double
            End If
        Next
        '  dsnew.Tables.Add(dt)
        ' Return dsnew.Tables(pnomtab)
        Return dt

        '***************************************************

    End Function
    Public Function buscar_asociado_todos(ByVal con As SqlConnection, ByVal asociado As String) As DataSet
        Dim error100 As Integer
        Dim str_select As String
        Dim letra As Char = Left(asociado, 1)

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            str_select = " Select ccodcli as asociado, cnomcli as nombre, cnudoci as dui, cnudotr as nit, pin, cbenef1 as colegio, isnull(ccodant,space(1)) as ccodant, " & _
                         " cestado = case lactivado " & _
                         " when 1 then 'ACTIVO' " & _
                         " Else 'INACTIVO' end " & _
                         " from climide where  NOT LEFT(CCODCLI,3) = '099' and ccodcli like " & "'%" & asociado.Trim & "%' order by ccodcli"
        Else
            str_select = " Select ccodcli as asociado, cnomcli as nombre, cnudoci as dui, cnudotr as nit, pin, cbenef1 as colegio, isnull(ccodant,space(1)) as ccodant, " & _
                         " cestado = case lactivado " & _
                         " when 1 then 'ACTIVO' " & _
                         " Else 'INACTIVO' end " & _
                         " from climide where NOT LEFT(CCODCLI,3) = '099' and cnomcli like " & "'%" & asociado.Trim & "%' order by cnomcli"
        End If


                     

        Dim adapter As New SqlClient.SqlDataAdapter(str_select, con)
        Dim ds As New DataSet()

        Try
            adapter.Fill(ds, "climide")
        Catch ex As Exception
            error100 = -100
        End Try

        Return ds
    End Function

    Public Function Retorna_Mes(ByVal pdfecsis As Date) As String
        Dim lnMes As Integer = pdfecsis.Month
        Dim lcMes As String = ""


        Select Case lnMes
            Case 1
                lcMes = "Enero"
            Case 2
                lcMes = "Febrero"
            Case 3
                lcMes = "Marzo"
            Case 4
                lcMes = "Abril"
            Case 5
                lcMes = "Mayo"
            Case 6
                lcMes = "Junio"
            Case 7
                lcMes = "Julio"
            Case 8
                lcMes = "Agosto"
            Case 9
                lcMes = "Septiembre"
            Case 10
                lcMes = "Octubre"
            Case 11
                lcMes = "Noviembre"
            Case Else
                lcMes = "Diciembre"
        End Select


        Return lcMes


    End Function
End Class
