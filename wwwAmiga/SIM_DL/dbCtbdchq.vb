Imports System.Text
Public Class dbCtbdchq
    Inherits dbBase
    Public Overridable Function ExecuteDataSet(ByVal connectionString As String, _
                           ByVal commandType As CommandType, _
                           ByVal commandText As String, _
                           ByVal params As SqlParameter(), _
                           ByVal commandTimeout As Integer) As DataSet
        Dim adapter As New SqlDataAdapter(commandText, connectionString)

        With adapter.SelectCommand
            .CommandType = commandType
            .CommandTimeout = commandTimeout
            .Parameters.AddRange(params)
        End With

        Dim data As New DataSet

        adapter.Fill(data)
        adapter.SelectCommand.Dispose()

        Return data
    End Function

    Public Function ActualizarCtbdchq(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbdchq
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnumcom = "" _
            Or lEntidad.cnumcom = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnumcom = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbdchq ")
        strSQL.Append(" SET cFlc = @cFlc, ")
        strSQL.Append(" cnomchq = @cnomchq ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(0).Value = lEntidad.cflc
        args(1) = New SqlParameter("@cnomchq", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomchq
        args(2) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
       
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbdchq
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnumcom = "" _
            Or lEntidad.cnumcom = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnumcom = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbdchq ")
        strSQL.Append(" SET ccodbco = @ccodbco, ")
        strSQL.Append(" cctacte = @cctacte, ")
        strSQL.Append(" cnrochq = @cnrochq, ")
        strSQL.Append(" cnomchq = @cnomchq, ")
        strSQL.Append(" cmonchq = @cmonchq, ")
        strSQL.Append(" cflc = @cflc, ")
        strSQL.Append(" cnomcta = @cnomcta, ")
        strSQL.Append(" ccodhab = @ccodhab, ")
        strSQL.Append(" ccoddeb = @ccoddeb, ")
        strSQL.Append(" dfeccnt2 = @dfeccnt2, ")
        strSQL.Append(" lprint = @lprint, ")
        strSQL.Append(" cmonlet = @cmonlet ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodbco
        args(1) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(1).Value = lEntidad.cctacte
        args(2) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrochq
        args(3) = New SqlParameter("@cnomchq", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomchq
        args(4) = New SqlParameter("@cmonchq", SqlDbType.Decimal)
        args(4).Value = lEntidad.cmonchq
        args(5) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(5).Value = lEntidad.cflc
        args(6) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnomcta
        args(7) = New SqlParameter("@ccodhab", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodhab
        args(8) = New SqlParameter("@ccoddeb", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccoddeb
        args(9) = New SqlParameter("@dfeccnt2", SqlDbType.DateTime)
        args(9).Value = lEntidad.dfeccnt2
        args(10) = New SqlParameter("@lprint", SqlDbType.Bit)
        args(10).Value = IIf(lEntidad.lprint = Nothing, DBNull.Value, lEntidad.lprint)
        args(11) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(12) = New SqlParameter("@cmonlet", SqlDbType.VarChar)
        args(12).Value = lEntidad.cmonlet

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbdchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ctbdchq ")
        strSQL.Append(" ( cnumcom, ")
        strSQL.Append(" ccodbco, ")
        strSQL.Append(" cctacte, ")
        strSQL.Append(" cnrochq, ")
        strSQL.Append(" cnomchq, ")
        strSQL.Append(" cmonchq, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" cnomcta, ")
        strSQL.Append(" ccodhab, ")
        strSQL.Append(" ccoddeb, ")
        strSQL.Append(" dfeccnt2, ")
        strSQL.Append(" cmonlet, ")
        strSQL.Append(" lprint, ccodsol) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnumcom, ")
        strSQL.Append(" @ccodbco, ")
        strSQL.Append(" @cctacte, ")
        strSQL.Append(" @cnrochq, ")
        strSQL.Append(" @cnomchq, ")
        strSQL.Append(" @cmonchq, ")
        strSQL.Append(" @cflc, ")
        strSQL.Append(" @cnomcta, ")
        strSQL.Append(" @ccodhab, ")
        strSQL.Append(" @ccoddeb, ")
        strSQL.Append(" @dfeccnt2, ")
        strSQL.Append(" @cmonlet, ")
        strSQL.Append(" @lprint, @ccodsol) ")

        Dim args(13) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(1) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodbco
        args(2) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(2).Value = lEntidad.cctacte
        args(3) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnrochq
        args(4) = New SqlParameter("@cnomchq", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnomchq
        args(5) = New SqlParameter("@cmonchq", SqlDbType.Decimal)
        args(5).Value = lEntidad.cmonchq
        args(6) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(6).Value = lEntidad.cflc
        args(7) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(7).Value = lEntidad.cnomcta
        args(8) = New SqlParameter("@ccodhab", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodhab
        args(9) = New SqlParameter("@ccoddeb", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccoddeb
        args(10) = New SqlParameter("@dfeccnt2", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfeccnt2
        args(11) = New SqlParameter("@cmonlet", SqlDbType.VarChar)
        args(11).Value = lEntidad.cmonlet
        args(12) = New SqlParameter("@lprint", SqlDbType.Bit)
        args(12).Value = IIf(lEntidad.lprint = Nothing, DBNull.Value, lEntidad.lprint)
        args(13) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodsol

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbdchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ctbdchq ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbdchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodbco = IIf(.Item("ccodbco") Is DBNull.Value, Nothing, .Item("ccodbco"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.cnrochq = IIf(.Item("cnrochq") Is DBNull.Value, Nothing, .Item("cnrochq"))
                lEntidad.cnomchq = IIf(.Item("cnomchq") Is DBNull.Value, Nothing, .Item("cnomchq"))
                lEntidad.cmonchq = IIf(.Item("cmonchq") Is DBNull.Value, Nothing, .Item("cmonchq"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.cnomcta = IIf(.Item("cnomcta") Is DBNull.Value, Nothing, .Item("cnomcta"))
                lEntidad.ccodhab = IIf(.Item("ccodhab") Is DBNull.Value, Nothing, .Item("ccodhab"))
                lEntidad.ccoddeb = IIf(.Item("ccoddeb") Is DBNull.Value, Nothing, .Item("ccoddeb"))
                lEntidad.dfeccnt2 = IIf(.Item("dfeccnt2") Is DBNull.Value, Nothing, .Item("dfeccnt2"))
                lEntidad.lprint = IIf(.Item("lprint") Is DBNull.Value, Nothing, .Item("lprint"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ctbdchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnumcom),0) + 1 ")
        strSQL.Append(" FROM ctbdchq ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listactbdchq

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listactbdchq

        Try
            Do While dr.Read()
                Dim mEntidad As New ctbdchq
                mEntidad.cnumcom = IIf(dr("cnumcom") Is DBNull.Value, Nothing, dr("cnumcom"))
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.cnrochq = IIf(dr("cnrochq") Is DBNull.Value, Nothing, dr("cnrochq"))
                mEntidad.cnomchq = IIf(dr("cnomchq") Is DBNull.Value, Nothing, dr("cnomchq"))
                mEntidad.cmonchq = IIf(dr("cmonchq") Is DBNull.Value, Nothing, dr("cmonchq"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.ccodhab = IIf(dr("ccodhab") Is DBNull.Value, Nothing, dr("ccodhab"))
                mEntidad.ccoddeb = IIf(dr("ccoddeb") Is DBNull.Value, Nothing, dr("ccoddeb"))
                mEntidad.dfeccnt2 = IIf(dr("dfeccnt2") Is DBNull.Value, Nothing, dr("dfeccnt2"))
                mEntidad.lprint = IIf(dr("lprint") Is DBNull.Value, Nothing, dr("lprint"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("ctbdchq")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT cnumcom, ")
        strSQL.Append(" ccodbco, ")
        strSQL.Append(" cctacte, ")
        strSQL.Append(" cnrochq, ")
        strSQL.Append(" cnomchq, ")
        strSQL.Append(" cmonchq, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" cnomcta, ")
        strSQL.Append(" ccodhab, ")
        strSQL.Append(" ccoddeb, ")
        strSQL.Append(" dfeccnt2, ")
        strSQL.Append(" lprint ")
        strSQL.Append(" FROM ctbdchq ")

    End Sub


    '------------------------------------------------------
    'Generador del Modulo de Reportes
    '------------------------------------------------------
    'desembolsos de cartera ********* REPORTES CREDITICIOS **********
    'modificada por mlvg
    Public Function ObtenerDataSetEsp1(ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataSet

        'llama a un procedimientos almacenado que se depositara en dsbase

        Dim DS As DataSet
        Dim MyConnection As SqlConnection
        Dim MyDataAdapter As SqlDataAdapter

        MyConnection = New SqlConnection(Me.cnnStr)
        MyDataAdapter = New SqlDataAdapter("pa_desembolsos", MyConnection)
        MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
        MyDataAdapter.SelectCommand.Parameters.Add(New SqlParameter("@fecha1", SqlDbType.DateTime))
        MyDataAdapter.SelectCommand.Parameters.Add(New SqlParameter("@fecha2", SqlDbType.DateTime))
        MyDataAdapter.SelectCommand.Parameters("@fecha1").Value = Date1
        MyDataAdapter.SelectCommand.Parameters("@fecha2").Value = Date2

        DS = New DataSet
        MyDataAdapter.Fill(DS, "pa_desembolsos")


        MyDataAdapter.Dispose() 'Dispose of the DataAdapter.
        MyConnection.Close() 'Close the connection.

        'finaliza llamada del procedimientos almacenado

        Return ds



        'antes
        '        Dim strSQL As New StringBuilder
        '        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, Climide.cnomcli, climide.ccoddom, '                              ' as zona, cretlin.ccodlin, cremcre.ccodact, '                                                               ' as cnomact, '                                 ' as cdesfon, '                    ' as sexo, '                                ' as cartera, '                                               ' as analista, climide.csexo,cremcre.ccondic,")
        '        strSQL.Append(" cremcre.dfecvig, Cremcre.dfecven, cremcre.ntasint, cremcre.ncapdes, (cremcre.nintcal -(cremcre.nintpag+cremcre.nintpen)) as nsalint, (cremcre.nintmor-(cremcre.nmorpag+cremcre.npagcta)) as nsalmor, cremcre.nmorak, cremcre.ccodana, 000000000000.00 as ncapita, 0000000000000.00 as nmora, 00000000000000.00 as nintere, 00000000000.00 as notros, 0000000000000.00 as npago,' ' as cconcep, ")
        '        strSQL.Append(" (cremcre.ncapdes-cremcre.ncappag) as nSaldo, DATEDIFF(Month, cremcre.dfecvig, Cremcre.dfecven) as nmeses")
        '        strSQL.Append(" FROM cremcre, climide, cretlin ")
        '        strSQL.Append(" WHERE climide.ccodcli = cremcre.ccodcli and cremcre.cnrolin = cretlin.cnrolin ")
        '        strSQL.Append(" AND Cremcre.dFecvig >= " & "'" & Date1 & "'")
        '        strSQL.Append(" AND Cremcre.dFecvig <= " & "'" & Date2 & "'")

        '       Dim ds As DataSet

        '        Try
        '        DS = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        '        Catch ex As Exception
        '        Throw ex
        '        End Try

        '       Return ds



    End Function

    Public Function ObtenerDataSetEsp2(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT credkar.nMonto, credkar.cConcep")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE Credkar.cCodcta = " & "'" & cCodigo & "'")
        strSQL.Append(" AND credkar.cestado = ' ' AND credkar.cdescob = 'D'")
        strSQL.Append(" AND Not (credkar.cconcep in ('CJ','KP'))")
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp3(ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cremcre.ccodcta, Climide.cnomcli,")
        strSQL.Append(" cremcre.dfecvig, Cremcre.dfecven, cremcre.ntasint, cremcre.ncapdes,")
        strSQL.Append(" (cremcre.ncapdes-cremcre.ncappag) as nSaldo, DATEDIFF(Month, cremcre.dfecvig, Cremcre.dfecven) as nmeses")
        strSQL.Append(" FROM climide ")
        strSQL.Append(" INNER JOIN cremcre  ON climide.ccodcli = cremcre.ccodcli")
        strSQL.Append(" WHERE Cremcre.cestado = 'F' AND Cremcre.dFecvig >= " & "'" & Date1 & "'")
        strSQL.Append(" AND Cremcre.dFecvig <= " & "'" & Date2 & "'")
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    'dataset cartera vigente detallada ** modificada mlvg
    Public Function ObtenerDataSetcarteracreditos(ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, Climide.cnomcli, climide.ccoddom, '                              ' as zona, cretlin.ccodlin, cremcre.ccodact, '                                                               ' as cnomact, '                                 ' as cdesfon, '                    ' as sexo, '                                ' as cartera, '                                               ' as analista, climide.csexo,cremcre.ccondic,")
        strSQL.Append(" cremcre.dfecvig, Cremcre.dfecven, cremcre.ntasint, cremcre.ncapdes, (cremcre.nintcal -(cremcre.nintpag+cremcre.nintpen)) as nsalint, (cremcre.nintmor-(cremcre.nmorpag+cremcre.npagcta)) as nsalmor, cremcre.nmorak, cremcre.ccodana,000000000000.00 as ncapita, 0000000000000.00 as nmora, 00000000000000.00 as nintere, 00000000000.00 as notros, 0000000000000.00 as npago,' ' as cconcep, ")
        strSQL.Append(" (cremcre.ncapdes-cremcre.ncappag) as nSaldo, DATEDIFF(Month, cremcre.dfecvig, Cremcre.dfecven) as nmeses")
        strSQL.Append(" FROM cremcre, climide, cretlin ")
        strSQL.Append(" WHERE climide.ccodcli = cremcre.ccodcli and cremcre.cnrolin = cretlin.cnrolin and Cremcre.cestado = 'F' ")
        strSQL.Append(" AND Cremcre.dFecvig <= " & "'" & Date2 & "'")
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    'dataset cartera mora detallada ** modificada mlvg
    Public Function ObtenerDataSetcarteramora(ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, Climide.cnomcli, climide.ccoddom, '                              ' as zona, cretlin.ccodlin, cremcre.ccodact, '                                                               ' as cnomact, '                                 ' as cdesfon, '                    ' as sexo, '                                ' as cartera, '                                               ' as analista, climide.csexo,cremcre.ccondic,")
        strSQL.Append(" cremcre.dfecvig, Cremcre.dfecven, cremcre.ntasint, cremcre.ncapdes, (cremcre.nintcal -(cremcre.nintpag+cremcre.nintpen)) as nsalint, (cremcre.nintmor-(cremcre.nmorpag+cremcre.npagcta)) as nsalmor, cremcre.nmorak, cremcre.ccodana, 000000000000.00 as ncapita, 0000000000000.00 as nmora, 00000000000000.00 as nintere, 00000000000.00 as notros, 0000000000000.00 as npago, ' ' as cconcep,")
        strSQL.Append(" (cremcre.ncapdes-cremcre.ncappag) as nSaldo, DATEDIFF(Month, cremcre.dfecvig, Cremcre.dfecven) as nmeses")
        strSQL.Append(" FROM cremcre, climide, cretlin ")
        strSQL.Append(" WHERE climide.ccodcli = cremcre.ccodcli and cremcre.cnrolin = cretlin.cnrolin and Cremcre.cestado = 'F' ")
        strSQL.Append(" AND Cremcre.ndiaatr >= 1 ")
        strSQL.Append(" AND Cremcre.dFecvig <= " & "'" & Date2 & "'")
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    'dataset de ingresos diarios, creado por Rt, modificado por mlvg
    Public Function ObtenerDataSetEsp4(ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataSet


        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, Climide.cnomcli, climide.ccoddom, '                              ' as zona, cretlin.ccodlin, cremcre.ccodact, '                                                               ' as cnomact, '                                 ' as cdesfon, '                    ' as sexo, '                                ' as cartera, '                                               ' as analista, climide.csexo,cremcre.ccondic,000000000000.00 as npago,")
        strSQL.Append(" cremcre.dfecvig, Cremcre.dfecven, cremcre.ntasint, cremcre.ncapdes, (cremcre.nintcal -(cremcre.nintpag+cremcre.nintpen)) as nsalint, (cremcre.nintmor-(cremcre.nmorpag+cremcre.npagcta)) as nsalmor, cremcre.nmorak, cremcre.ccodana, ")
        strSQL.Append(" (cremcre.ncapdes-cremcre.ncappag) as nSaldo, DATEDIFF(Month, cremcre.dfecvig, Cremcre.dfecven) as nmeses, 000000000000.00 as ncapita, 0000000000000.00 as nmora, 00000000000000.00 as nintere, 00000000000.00 as notros, ' ' as cconcep")
        strSQL.Append(" FROM cremcre, climide, cretlin")
        strSQL.Append(" WHERE climide.ccodcli = cremcre.ccodcli and cremcre.cnrolin = cretlin.cnrolin and (cremcre.cestado ='F' OR cremcre.cestado ='G')")



        '        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, Climide.cnomcli, climide.ccoddom, '                              ' as zona, cretlin.ccodlin, cremcre.ccodact, '                                                               ' as cnomact, '                                 ' as cdesfon, '                    ' as sexo, '                                ' as cartera, '                                               ' as analista, climide.csexo,cremcre.ccondic,")
        '        strSQL.Append(" cremcre.dfecvig, Cremcre.dfecven, cremcre.ntasint, cremcre.ncapdes, (cremcre.nintcal -(cremcre.nintpag+cremcre.nintpen)) as nsalint, (cremcre.nintmor-(cremcre.nmorpag+cremcre.npagcta)) as nsalmor, cremcre.nmorak, cremcre.ccodana, ")
        '        strSQL.Append(" (cremcre.ncapdes-cremcre.ncappag) as nSaldo, DATEDIFF(Month, cremcre.dfecvig, Cremcre.dfecven) as nmeses, 000000000000.00 as ncapita, 0000000000000.00 as nmora, 00000000000000.00 as nintere, 00000000000.00 as notros, credkar.cconcep, credkar.nmonto")
        '        strSQL.Append(" FROM cremcre, climide, cretlin, credkar ")
        '        strSQL.Append(" WHERE climide.ccodcli = cremcre.ccodcli and cremcre.cnrolin = cretlin.cnrolin ")
        '        strSQL.Append(" AND cremcre.ccodcta  = credkar.ccodcta ")
        '        strSQL.Append(" AND credkar.cdescob = 'C' AND credkar.cestado =' ' ")
        '        strSQL.Append(" AND Credkar.dFecsis >= " & "'" & Date1 & "'")
        '        strSQL.Append(" AND Credkar.dFecsis <= " & "'" & Date2 & "'")
        '        strSQL.Append(" GROUP BY credkar.ccodcta,credkar.cnuming,credkar.dfecsis")


        '        Dim strSQL As New StringBuilder
        '        strSQL.Append(" SELECT climide.cnomcli, cremcre.ccodcta, credkar.cnuming, credkar.dfecpro, ")
        '        strSQL.Append(" credkar.cTippag, Tabttab.cDescri, ")
        '        strSQL.Append(" 00000000.00 as nTotal, 00000000.00 as nKapita, 00000000.00 as nIntere, 00000000.00 as nIntMor, ")
        '        strSQL.Append(" 00000000.00 as nComTra, 00000000.00 as nGestion, 00000000.00 as nHono, 00000000.00 as nOtros ")
        '        strSQL.Append(" FROM climide INNER JOIN cremcre ON Climide.ccodcli = Cremcre.ccodcli")
        '        strSQL.Append(" INNER JOIN credkar ON Cremcre.ccodcta = Credkar.ccodcta")
        '        strSQL.Append(" INNER JOIN Tabttab ON Credkar.cTippag = Tabttab.cCodigo")
        '        strSQL.Append(" WHERE credkar.cestado = ' ' AND credkar.cdescob = 'C' ")
        '        strSQL.Append(" AND Credkar.dFecsis >= " & "'" & Date1 & "'")
        '        strSQL.Append(" AND Credkar.dFecsis <= " & "'" & Date2 & "'")
        '        strSQL.Append(" AND TabtTab.cCodTab + Tabttab.cTipReg = '1461' ")
        '        strSQL.Append(" GROUP BY climide.cnomcli,cremcre.ccodcta,credkar.cnuming,credkar.dfecpro,credkar.cTippag,Tabttab.cDescri")
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function



    Public Function ObtenerDataSetEsp5(ByVal cCodigo As String, ByVal cNuming As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT credkar.cCodcta, credkar.nMonto, credkar.cConcep, credkar.cnuming")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE credkar.cCodcta = " & "'" & cCodigo & "'")
        strSQL.Append(" AND credkar.cNuming = " & "'" & cNuming & "'")


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function Nchequexcnumcom(ByVal pcNumcom As String, ByVal lccadena As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT (rtrim(ltrim(cnrochq)) + ' ch/ ') as cnumchq")
        strSQL.Append(" FROM ctbdchq ")
        strSQL.Append(" WHERE ctbdchq.cnumcom = @pcnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcnumcom", pcNumcom)


        Dim ds As New DataSet

        'Try
        '    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        'Catch ex As Exception
        '    Throw ex
        'End Try

        Try


            If lccadena.Trim = "" Then
                ds = Me.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
            Else
                ds = Me.ExecuteDataSet(lccadena, CommandType.Text, strSQL.ToString(), args, 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try



        If ds.Tables(0).Rows.Count <= 0 Then
            Return " "
        Else
            Return ds.Tables(0).Rows(0)("cnumchq")
        End If


    End Function




    '>>>>>>>>>>>>>>>>>>>>>>>>>>>AUXILIAR<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Public Function AgregarAuxiliar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbdchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO AUXILIAR ")
        strSQL.Append(" ( cnumcom, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" ndebe, ")
        strSQL.Append(" nhaber, ")
        strSQL.Append(" dfeccnt, ")
        strSQL.Append(" ccodbco, ")
        strSQL.Append(" ctipcta, ")
        strSQL.Append(" cctacte, ")
        strSQL.Append(" ctipapl, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" cconcep, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" cCodreg, ")
        strSQL.Append(" cdelet, ")
        strSQL.Append(" dfecmod, cnumrec) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnumcom, ")
        strSQL.Append(" @cnumdoc, ")
        strSQL.Append(" @ccodcta, ")
        strSQL.Append(" @ndebe, ")
        strSQL.Append(" @nhaber, ")
        strSQL.Append(" @dfeccnt, ")
        strSQL.Append(" @ccodbco, ")
        strSQL.Append(" @ctipcta, ")
        strSQL.Append(" @cctacte, ")
        strSQL.Append(" @ctipapl, ")
        strSQL.Append(" @cnomcli, ")
        strSQL.Append(" @cconcep, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @ffondos, ")
        strSQL.Append(" @ccodreg, ")
        strSQL.Append(" @cdelet, ")
        strSQL.Append(" @dfecmod, @cnumrec) ")

        Dim args(17) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(1) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnumdoc
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodcta
        args(3) = New SqlParameter("@ndebe", SqlDbType.Decimal)
        args(3).Value = lEntidad.ndebe
        args(4) = New SqlParameter("@nhaber", SqlDbType.Decimal)
        args(4).Value = lEntidad.nhaber
        args(5) = New SqlParameter("@dfeccnt", SqlDbType.DateTime)
        args(5).Value = lEntidad.dfeccnt
        args(6) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodbco
        args(7) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(7).Value = lEntidad.ctipcta
        args(8) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(8).Value = lEntidad.cctacte
        args(9) = New SqlParameter("@ctipapl", SqlDbType.VarChar)
        args(9).Value = lEntidad.ctipapl
        args(10) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(10).Value = lEntidad.cnomcli
        args(11) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(11).Value = lEntidad.cconcep
        args(12) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodofi
        args(13) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(13).Value = lEntidad.ffondos
        args(14) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(14).Value = "001"
        args(15) = New SqlParameter("@cdelet", SqlDbType.VarChar)
        args(15).Value = ""
        args(16) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(16).Value = Today
        args(17) = New SqlParameter("@cnumrec", SqlDbType.VarChar)
        args(17).Value = lEntidad.cnumrec



        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function AnulaAuxiliar(ByVal cnumcom As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append(" UPDATE AUXILIAR set cdelet = 'X' WHERE cnumcom = @cnumcom ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("cnumcom", cnumcom)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function NombreChequexcnumcom(ByVal pcNumcom As String, ByVal lccadena As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT (rtrim(ltrim(cnomchq))) as cnomchq")
        strSQL.Append(" FROM ctbdchq ")
        strSQL.Append(" WHERE ctbdchq.cnumcom = @pcnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcnumcom", pcNumcom)


        Dim ds As New DataSet

        'Try
        '    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        'Catch ex As Exception
        '    Throw ex
        'End Try

        Try
            If lccadena.Trim = "" Then
                ds = Me.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
            Else
                ds = Me.ExecuteDataSet(lccadena, CommandType.Text, strSQL.ToString(), args, 0)
            End If
        Catch ex As Exception
            Throw ex
        End Try


        If ds.Tables(0).Rows.Count <= 0 Then
            Return " "
        Else
            Return ds.Tables(0).Rows(0)("cnomchq")
        End If


    End Function
    Public Function ClientePorCodigo(ByVal CodigoCliente As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cnomcli")
        strSQL.Append(" FROM climide ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", CodigoCliente)


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        If ds.Tables(0).Rows.Count <= 0 Then
            Return " "
        Else
            Return ds.Tables(0).Rows(0)("cnomcli")
        End If


    End Function
    Public Function AnulaCheque(ByVal cnumcom As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbdchq ")
        strSQL.Append(" SET cFlc = 'X', ")
        strSQL.Append(" cnomchq = 'CHEQUE ANULADO' ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function VerificasiprocedeAnulacion(ByVal cnumcom As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cnumcom from ctbdchq where cnumcom = @cnumcom and cflc = 'X' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lverifica As Boolean = True

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnumcom")) Then
            Else
                lverifica = False
            End If
        End If

        Return lverifica
    End Function
    'verificar si ya existe cheque
    Public Function VerificarChequeExiste(ByVal ccodbco As String, ByVal cnrochq As String) As Boolean
        Dim strsql As New StringBuilder
        strsql.Append("select cnrochq from ctbdchq where ")
        strsql.Append("cnrochq = @cnrochq and ccodbco = @ccodbco ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnrochq", cnrochq)
        args(1) = New SqlParameter("@ccodbco", ccodbco)

        Dim ds As New DataSet
        Dim lvalida As Boolean = False
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnrochq")) Then
            Else
                lvalida = True
            End If
        End If

        Return lvalida
    End Function

End Class
