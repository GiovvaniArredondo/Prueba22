Imports System.Text
Public Class dbCredppg
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credppg
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnrocuo =  "" _
            Or lEntidad.cnrocuo = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnrocuo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credppg ")
        strSQL.Append(" SET dfecven = @dfecven, ") 
        strSQL.Append(" dfecpag = @dfecpag, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" ncapita = @ncapita, ") 
        strSQL.Append(" nintere = @nintere, ") 
        strSQL.Append(" ncappag = @ncappag, ") 
        strSQL.Append(" nintpag = @nintpag, ") 
        strSQL.Append(" nintmor = @nintmor, ")
        strSQL.Append(" ngastos = @ngastos, ")
        strSQL.Append(" nmorpag = @nmorpag, ") 
        strSQL.Append(" notrpag = @notrpag, ") 
        strSQL.Append(" ccodusu = @ccodusu ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipope = @ctipope ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecven
        args(1) = New SqlParameter("@dfecpag", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecpag
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = lEntidad.cestado
        args(3) = New SqlParameter("@ncapita", SqlDbType.VarChar)
        args(3).Value = lEntidad.ncapita
        args(4) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(4).Value = lEntidad.nintere
        args(5) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(5).Value = lEntidad.ngastos
        args(6) = New SqlParameter("@ncappag", SqlDbType.Decimal)
        args(6).Value = lEntidad.ncappag
        args(7) = New SqlParameter("@nintpag", SqlDbType.Decimal)
        args(7).Value = lEntidad.nintpag
        args(8) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(8).Value = lEntidad.nintmor
        args(9) = New SqlParameter("@nmorpag", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmorpag
        args(10) = New SqlParameter("@notrpag", SqlDbType.Decimal)
        args(10).Value = lEntidad.notrpag
        args(11) = New SqlParameter("@ccodusu", SqlDbType.Decimal)
        args(11).Value = lEntidad.ccodusu
        args(12) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(12).Value = lEntidad.dfecmod
        args(13) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(13).Value = lEntidad.cflag
        args(14) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(14).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(15) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(15).Value = IIf(lEntidad.ctipope = Nothing, DBNull.Value, lEntidad.ctipope)
        args(16) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(16).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value, lEntidad.cnrocuo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credppg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO credppg ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" dfecven, ") 
        strSQL.Append(" dfecpag, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" ctipope, ") 
        strSQL.Append(" cnrocuo, ") 
        strSQL.Append(" ncapita, ") 
        strSQL.Append(" nintere, ")
        strSQL.Append(" ngastos, ")
        strSQL.Append(" ncappag, ") 
        strSQL.Append(" nintpag, ") 
        strSQL.Append(" nintmor, ") 
        strSQL.Append(" nmorpag, ") 
        strSQL.Append(" notrpag, ") 
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, nsegdeu) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @dfecven, ") 
        strSQL.Append(" @dfecpag, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @ctipope, ") 
        strSQL.Append(" @cnrocuo, ") 
        strSQL.Append(" @ncapita, ") 
        strSQL.Append(" @nintere, ")
        strSQL.Append(" @ngastos, ")
        strSQL.Append(" @ncappag, ") 
        strSQL.Append(" @nintpag, ") 
        strSQL.Append(" @nintmor, ") 
        strSQL.Append(" @nmorpag, ") 
        strSQL.Append(" @notrpag, ") 
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, @nsegdeu) ")

        Dim args(17) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecven
        args(2) = New SqlParameter("@dfecpag", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecpag
        args(3) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(3).Value = lEntidad.cestado
        args(4) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.ctipope = Nothing, DBNull.Value, lEntidad.ctipope)
        args(5) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value, lEntidad.cnrocuo)
        args(6) = New SqlParameter("@ncapita", SqlDbType.Decimal)
        args(6).Value = lEntidad.ncapita
        args(7) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(7).Value = lEntidad.nintere
        args(8) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(8).Value = lEntidad.ngastos
        args(9) = New SqlParameter("@ncappag", SqlDbType.Decimal)
        args(9).Value = lEntidad.ncappag
        args(10) = New SqlParameter("@nintpag", SqlDbType.Decimal)
        args(10).Value = lEntidad.nintpag
        args(11) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(11).Value = lEntidad.nintmor
        args(12) = New SqlParameter("@nmorpag", SqlDbType.Decimal)
        args(12).Value = lEntidad.nmorpag
        args(13) = New SqlParameter("@notrpag", SqlDbType.Decimal)
        args(13).Value = lEntidad.notrpag
        args(14) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodusu
        args(15) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(15).Value = lEntidad.dfecmod
        args(16) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(16).Value = lEntidad.cflag
        args(17) = New SqlParameter("@nsegdeu", SqlDbType.Decimal)
        args(17).Value = lEntidad.nsegdeu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credppg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        'strSQL.Append(" AND ctipope = @ctipope ") 
        'strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        'args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        'args(1).Value = lEntidad.ctipope
        'args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        'args(2).Value = lEntidad.cnrocuo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credppg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipope = @ctipope ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipope
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.dfecven = IIf(.Item("dfecven") Is DBNull.Value, Nothing, .Item("dfecven"))
                lEntidad.dfecpag = IIf(.Item("dfecpag") Is DBNull.Value, Nothing, .Item("dfecpag"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.ncapita = IIf(.Item("ncapita") Is DBNull.Value, Nothing, .Item("ncapita"))
                lEntidad.nintere = IIf(.Item("nintere") Is DBNull.Value, Nothing, .Item("nintere"))
                lEntidad.ngastos = IIf(.Item("ngastos") Is DBNull.Value, Nothing, .Item("ngastos"))
                lEntidad.ncappag = IIf(.Item("ncappag") Is DBNull.Value, Nothing, .Item("ncappag"))
                lEntidad.nintpag = IIf(.Item("nintpag") Is DBNull.Value, Nothing, .Item("nintpag"))
                lEntidad.nintmor = IIf(.Item("nintmor") Is DBNull.Value, Nothing, .Item("nintmor"))
                lEntidad.nmorpag = IIf(.Item("nmorpag") Is DBNull.Value, Nothing, .Item("nmorpag"))
                lEntidad.notrpag = IIf(.Item("notrpag") Is DBNull.Value, Nothing, .Item("notrpag"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As credppg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnrocuo),0) + 1 ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipope = @ctipope ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipope

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcta As String, ctipope As String) As listacredppg

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipope = @ctipope ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = ctipope

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listacredppg

        Try
            Do While dr.Read()
                Dim mEntidad As New credppg
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.dfecpag = IIf(dr("dfecpag") Is DBNull.Value, Nothing, dr("dfecpag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctipope = ctipope
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.ncapita = IIf(dr("ncapita") Is DBNull.Value, Nothing, dr("ncapita"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ncappag = IIf(dr("ncappag") Is DBNull.Value, Nothing, dr("ncappag"))
                mEntidad.nintpag = IIf(dr("nintpag") Is DBNull.Value, Nothing, dr("nintpag"))
                mEntidad.nintmor = IIf(dr("nintmor") Is DBNull.Value, Nothing, dr("nintmor"))
                mEntidad.nmorpag = IIf(dr("nmorpag") Is DBNull.Value, Nothing, dr("nmorpag"))
                mEntidad.notrpag = IIf(dr("notrpag") Is DBNull.Value, Nothing, dr("notrpag"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String, ctipope As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipope = @ctipope ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipope", ctipope)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String, ctipope As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipope = @ctipope ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipope", ctipope)

        Dim tables(0) As String
        tables(0) = New String("credppg")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcta, ") 
        strSQL.Append(" dfecven, ") 
        strSQL.Append(" dfecpag, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" ctipope, ") 
        strSQL.Append(" cnrocuo, ") 
        strSQL.Append(" ncapita, ") 
        strSQL.Append(" nintere, ")
        strSQL.Append(" ngastos, ")
        strSQL.Append(" ncappag, ") 
        strSQL.Append(" nintpag, ") 
        strSQL.Append(" nintmor, ") 
        strSQL.Append(" nmorpag, ") 
        strSQL.Append(" notrpag, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ")
        strSQL.Append(" 0000000.00 as ntasint, ")
        strSQL.Append(" nsegdeu, 0000000.00 as nresinc, ")
        strSQL.Append(" (ncapita+nintere+(case when ngastos is null then 0 else ngastos end ) + (case when nsegdeu is null then 0 else nsegdeu end )) as nmoncuo, 000000.00 as ntalona, ")
        strSQL.Append(" ncapita as nsaldo, 00000000.00 as saldo, dfecven as dfecpro, 0000000.00 as nsegdan, 000000.00 as salint, space(60) as cnomcli, space(20) as cnudoci ")
        'strSQL.Append(" 000000.00 as saldo, 000000.00 as salint, (ncapita + nintere + ngastos + nsegdeu) as nmoncuo ")
        strSQL.Append(" FROM credppg ")

    End Sub

    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String) As listacredppg
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacredppg

        Try
            Do While dr.Read()
                Dim mEntidad As New credppg
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.dfecpag = IIf(dr("dfecpag") Is DBNull.Value, Nothing, dr("dfecpag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctipope = IIf(dr("ctipope") Is DBNull.Value, Nothing, dr("ctipope"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.ncapita = IIf(dr("ncapita") Is DBNull.Value, Nothing, dr("ncapita"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ncappag = IIf(dr("ncappag") Is DBNull.Value, Nothing, dr("ncappag"))
                mEntidad.nintpag = IIf(dr("nintpag") Is DBNull.Value, Nothing, dr("nintpag"))
                mEntidad.nintmor = IIf(dr("nintmor") Is DBNull.Value, Nothing, dr("nintmor"))
                mEntidad.nmorpag = IIf(dr("nmorpag") Is DBNull.Value, Nothing, dr("nmorpag"))
                mEntidad.notrpag = IIf(dr("notrpag") Is DBNull.Value, Nothing, dr("notrpag"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.nsegdeu = IIf(dr("nsegdeu") Is DBNull.Value, Nothing, dr("nsegdeu"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function EliminaPlanPagos(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credppg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipope <> 'D' order by credppg.dfecven ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim tables(0) As String
        tables(0) = New String("credppg")
        Try
            sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Catch ex As Exception
         
            Return 0
        End Try

        Return 1

    End Function


    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    'dataset para calculo de mora
    Public Function ObtenerDataSetPorcuenta_fecha(ByVal ldfecha As Date, ByVal pccodcta1 As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE  dfecven <= @ldfecha")
        strSQL.Append("  order by ccodcta,dfecven")

        Dim args(0) As SqlParameter

        args(0) = New SqlParameter("@ldfecha", SqlDbType.DateTime)
        args(0).Value = ldfecha


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    'Obtiene el saldo de teorico en base a una fecha determinada
    Public Function ObtenerSaldoTeorico(ByVal lccodcta As String, ByVal ldfecha As Date, ByVal lnCapDes As Double) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT  sum(ncapita) as nCapita FROM credppg WHERE ccodcta = @lccodcta ")
        strSQL.Append(" and ctipope = 'N' and dfecven < @ldfecha group by cCodcta ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@ldfecha", SqlDbType.DateTime)
        args(0).Value = ldfecha
        args(1) = New SqlParameter("@lccodcta", SqlDbType.VarChar)
        args(1).Value = lccodcta

        Dim ds As DataSet
        Dim lncappag As Double
        Dim lnsalteo As Double
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lncappag = 0
        Else
            lncappag = ds.Tables(0).Rows(0)("nCapita")
        End If
        If lnCapDes = 0 Then
            lnsalteo = 0
        Else
            lnsalteo = lnCapDes - lncappag
        End If
        Return lnsalteo
    End Function
    Public Function Obtenerprimeracuota(ByVal ccodcta As String) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and cNrocuo = '001' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim dprifec As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            dprifec = Today.AddDays(1)
        Else
            dprifec = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return dprifec

    End Function
    'valores decimal estaba en double
    'Fernando abrego rdz  02/06/2015
    Public Function CapitalInteres(ByVal ccodcta As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nCapita, nIntere ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and cNrocuo = '001' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        'valores de double a decimal
        Dim lnCapInt As Decimal
        Dim lncapita As Decimal
        Dim lnintere As Decimal

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnintere = ds.Tables(0).Rows(0)("nIntere")
            lnCapInt = lncapita + lnintere
        End If
        Return lnCapInt
    End Function


    Public Function CapitalInteres_Total(ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(nCapita) as ncapita, sum(nIntere) as nIntere ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N'")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lnCapInt As Double
        Dim lncapita As Double
        Dim lnintere As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnintere = ds.Tables(0).Rows(0)("nIntere")
            lnCapInt = lncapita + lnintere
        End If
        Return lnCapInt
    End Function

    Public Function plandepagosLibreta(ByVal ccodcta As String, ByVal dfecini As Date, ByVal dfecfin As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" Select cremcre.ccodcta, credppg.ncapita, credppg.nintere , 00000000.00 as nmoncuo,")
        strSQL.Append(" climide.cnomcli, credppg.dfecven, credppg.cnrocuo ")
        strSQL.Append(" from cremcre, climide, credppg WHERE cremcre.ccodcli = climide.ccodcli ")
        strSQL.Append(" and  cremcre.ccodcta = credppg.ccodcta ")
        strSQL.Append(" and Credppg.ccodcta =@ccodcta and Credppg.dfecven>=@dfecini and Credppg.dfecven<=@dfecfin ")
        strSQL.Append(" and Credppg.ctipope = 'N' ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecini", dfecini)
        args(2) = New SqlParameter("@dfecfin", dfecfin)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function

    Public Function ProximaFecha(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven>= @dfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim pdfecven As Date
        

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            pdfecven = dfecha
        Else
            pdfecven = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return pdfecven
    End Function
    Public Function NumeroCuotaProximaFecha(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cnrocuo ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven>= @dfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim pdfecven As String = ""


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            pdfecven = "001"
        Else
            pdfecven = ds.Tables(0).Rows(0)("cnrocuo")
        End If
        Return pdfecven
    End Function

    Public Function CuotaCapital(ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nCapita ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and cNrocuo = '001' and ncapita > 0 ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lnCapInt As Double
        Dim lncapita As Double
        Dim lnintere As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
            Dim ldfecven As Date
            ldfecven = UltimaCuotadePlan(ccodcta)
            lnCapInt = UltimaCuotadeCapital(ccodcta, ldfecven)
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnCapInt = lncapita
        End If
        Return lnCapInt
    End Function

    Public Function CuotasPagadas(ByVal ccodcta As String, ByVal nsaldopag As Double) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nCapita, cnrocuo, 00000.00 as ncappag ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' order by cNrocuo  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lcnrocuo As String = "001"

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcnrocuo = "001"
        Else
            Dim fila As DataRow
            Dim i As Integer = 0
            Dim lncapita As Double = 0

            For Each fila In ds.Tables(0).Rows

                lncapita = ds.Tables(0).Rows(i)("ncapita")

                If Math.Round(nsaldopag, 2) >= Math.Round(lncapita, 2) Then
                    lcnrocuo = ds.Tables(0).Rows(i)("cnrocuo")
                    nsaldopag = nsaldopag - lncapita
                Else
                    Exit For
                End If
                i += 1
            Next
        End If
        Return lcnrocuo
    End Function

    Public Function CuotasTeoricas(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT max(cnrocuo) as cnrocuo ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven<= @dfecha group by ccodcta  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lcnrocuo As String = "000"

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcnrocuo = "001"
        Else
            lcnrocuo = ds.Tables(0).Rows(0)("cnrocuo")
        End If
        Return lcnrocuo
    End Function
    Public Function AnteriorFecha(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven<= @dfecha order by dfecven desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim pdfecven As Date


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            pdfecven = dfecha
        Else
            pdfecven = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return pdfecven
    End Function

    Public Function ValidaFrecuencia(ByVal cfreckp As String, ByVal cfrecint As String, ByVal ncuotas As Integer) As Boolean
        'Verifica frecuencia para Cada tipo
        Dim lvalida As Boolean = False
        Dim lnentero As Double = 0
        Dim lndecimal As Double = 0

        Select Case cfreckp
            Case "A" 'Al vencimiento
                lvalida = True
            Case "Q" 'Quicenal
                lvalida = True
            Case "B" 'Catorcenal
                If cfrecint = "D" Then
                    If ncuotas < 14 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 14)
                        lndecimal = Math.Round((Math.Round((ncuotas / 14), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "S" Then
                    If ncuotas < 2 Then
                        lvalida = False
                    Else

                        lnentero = Decimal.Floor(ncuotas / 2)
                        lndecimal = Math.Round((Math.Round((ncuotas / 2), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If
                    End If
                ElseIf cfrecint = "B" Then
                    lvalida = True
                End If

            Case "D" 'Diario
                lvalida = True
            Case "E" 'Semestral
                If cfrecint = "D" Then
                    If ncuotas < 182 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 182)
                        lndecimal = Math.Round((Math.Round((ncuotas / 182), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "S" Then
                    If ncuotas < 26 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 26)
                        lndecimal = Math.Round((Math.Round((ncuotas / 26), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "B" Then
                    If ncuotas < 13 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 13)
                        lndecimal = Math.Round((Math.Round((ncuotas / 13), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If
                    End If

                ElseIf cfrecint = "M" Then
                    If ncuotas < 6 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 6)
                        lndecimal = Math.Round((Math.Round((ncuotas / 6), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "I" Then
                    If ncuotas < 3 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 3)
                        lndecimal = Math.Round((Math.Round((ncuotas / 3), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If


                ElseIf cfrecint = "T" Then
                    If ncuotas < 2 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 2)
                        lndecimal = Math.Round((Math.Round((ncuotas / 2), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "C" Then
                    If ncuotas < 3 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 3)
                        lndecimal = Math.Round((Math.Round((ncuotas / 3), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "E" Then

                    lvalida = True
                End If

            Case "I" 'Bimensual
                If cfrecint = "D" Then
                    If ncuotas < 60 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 60)
                        lndecimal = Math.Round((Math.Round((ncuotas / 60), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "S" Then
                    If ncuotas < 8 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 8)
                        lndecimal = Math.Round((Math.Round((ncuotas / 8), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "B" Then
                    If ncuotas < 4 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 4)
                        lndecimal = Math.Round((Math.Round((ncuotas / 4), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "M" Then
                    If ncuotas < 2 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 2)
                        lndecimal = Math.Round((Math.Round((ncuotas / 2), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "I" Then
                    lvalida = True
                End If

            Case "M" 'Mensual
                If cfrecint = "D" Then
                    If ncuotas < 30 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 30)
                        lndecimal = Math.Round((Math.Round((ncuotas / 30), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "S" Then
                    If ncuotas < 4 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 4)
                        lndecimal = Math.Round((Math.Round((ncuotas / 4), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "B" Then
                    If ncuotas < 2 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 2)
                        lndecimal = Math.Round((Math.Round((ncuotas / 2), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "M" Then
                    lvalida = True
                End If

            Case "S" 'Semanal
                If cfrecint = "D" Then
                    If ncuotas < 7 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 7)
                        lndecimal = Math.Round((Math.Round((ncuotas / 7), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "S" Then
                    lvalida = True
                End If

            Case "T" 'Trimestral
                If cfrecint = "D" Then
                    If ncuotas < 90 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 90)
                        lndecimal = Math.Round((Math.Round((ncuotas / 90), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "S" Then
                    If ncuotas < 12 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 12)
                        lndecimal = Math.Round((Math.Round((ncuotas / 12), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "B" Then
                    If ncuotas < 6 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 6)
                        lndecimal = Math.Round((Math.Round((ncuotas / 6), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "M" Then

                    If ncuotas < 3 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 3)
                        lndecimal = Math.Round((Math.Round((ncuotas / 3), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "I" Then
                    If ncuotas < 3 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 2)
                        lndecimal = Math.Round((Math.Round((ncuotas / 2), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If


                ElseIf cfrecint = "T" Then

                    lvalida = True
                End If

                '-------------------------------------------
            Case "C" 'Cuatrimestral
                If cfrecint = "D" Then
                    If ncuotas < 120 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 120)
                        lndecimal = Math.Round((Math.Round((ncuotas / 120), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "S" Then
                    If ncuotas < 12 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 12)
                        lndecimal = Math.Round((Math.Round((ncuotas / 12), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "B" Then
                    If ncuotas < 6 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 6)
                        lndecimal = Math.Round((Math.Round((ncuotas / 6), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "M" Then

                    If ncuotas < 4 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 4)
                        lndecimal = Math.Round((Math.Round((ncuotas / 4), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "I" Then
                    If ncuotas < 2 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 2)
                        lndecimal = Math.Round((Math.Round((ncuotas / 2), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If


                ElseIf cfrecint = "T" Then

                    lvalida = True
                ElseIf cfrecint = "C" Then

                    lvalida = True

                End If
                '---------------------------------------------
            Case "N" 'anual
                If cfrecint = "D" Then
                    If ncuotas < 365 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 365)
                        lndecimal = Math.Round((Math.Round((ncuotas / 365), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "S" Then
                    If ncuotas < 42 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 42)
                        lndecimal = Math.Round((Math.Round((ncuotas / 42), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "B" Then
                    If ncuotas < 26 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 26)
                        lndecimal = Math.Round((Math.Round((ncuotas / 26), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If
                    End If

                ElseIf cfrecint = "M" Then
                    If ncuotas < 12 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 12)
                        lndecimal = Math.Round((Math.Round((ncuotas / 12), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "I" Then
                    If ncuotas < 6 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 6)
                        lndecimal = Math.Round((Math.Round((ncuotas / 6), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If


                ElseIf cfrecint = "T" Then
                    If ncuotas < 4 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 4)
                        lndecimal = Math.Round((Math.Round((ncuotas / 4), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If
                ElseIf cfrecint = "C" Then
                    If ncuotas < 6 Then
                        lvalida = False
                    Else
                        lnentero = Decimal.Floor(ncuotas / 6)
                        lndecimal = Math.Round((Math.Round((ncuotas / 6), 2) - lnentero) * 100, 0)
                        If lndecimal > 0 Then
                            lvalida = False
                        Else
                            lvalida = True
                        End If

                    End If

                ElseIf cfrecint = "E" Then

                    lvalida = True
                ElseIf cfrecint = "N" Then
                    lvalida = True
                End If

        End Select

        Return lvalida
    End Function
    Public Function RecuperaPlanPagos(ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ncapita, nintere, cnrocuo ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' order by dfecven ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim dprifec As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function InteresNovencido(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(nintere) as nintere ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven > @dfecha group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lninteres As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lninteres = 0
        Else
            lninteres = ds.Tables(0).Rows(0)("nintere")
        End If

        Return lninteres
    End Function

    Public Function Interesvencido(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(nintere) as nintere ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven <= @dfecha group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lninteres As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lninteres = 0
        Else
            lninteres = ds.Tables(0).Rows(0)("nintere")
        End If

        Return lninteres
    End Function

    Public Function CuotaGrupal(ByVal cCodsol As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder

        strSQL.Append(" select sum(credppg.ncapita+credppg.nintere) as cuota ")
        strSQL.Append(" from credppg , cremcre where cremcre.ccodcta = credppg.ccodcta ")
        strSQL.Append(" and credppg.cnrocuo ='001' and credppg.ctipope = 'N' ")
        strSQL.Append(" and cremcre.ccodsol =  @cCodsol and cremcre.dfecvig >=@dfecha and cremcre.dfecvig<=@dfecha ")
        strSQL.Append(" group by cremcre.ccodsol ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", cCodsol)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lnCuota As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCuota = 0
        Else
            lnCuota = IIf(IsDBNull(ds.Tables(0).Rows(0)("cuota")), 0, ds.Tables(0).Rows(0)("cuota"))
        End If

        Return lnCuota
    End Function
    Public Function FechasdePago(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" select credppg.dfecven  ")
        strSQL.Append(" from cremcre, credppg where cremcre.ccodcta = credppg.ccodcta  ")
        strSQL.Append(" and cremcre.ccodsol = @cCodsol and cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha ")
        strSQL.Append(" and credppg.ctipope ='N' ")
        strSQL.Append(" group by credppg.dfecven order by credppg.dfecven ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", cCodsol)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function PlandePagosIndividual(ByVal cCodcta As String) As DataSet
        Dim strSQL As New StringBuilder


        strsql.Append(" select credppg.ccodcta, climide.cnomcli , ")
        strsql.Append(" credppg.ncapita, credppg.nintere from cremcre, climide, credppg ")
        strsql.Append(" where cremcre.ccodcli = climide.ccodcli and cremcre.ccodcta = credppg.ccodcta ")
        strSQL.Append(" and cremcre.ccodcta =@cCodcta and credppg.ctipope = 'N' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds


    End Function

    Public Function UltimaCuotaVencida(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT max(dfecven) as dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND  dfecven<= @dfecha group by ccodcta  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim ldfecven As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            ldfecven = Today
        Else
            ldfecven = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return ldfecven
    End Function

    Public Function UltimaCuotadePlan(ByVal ccodcta As String) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT max(dfecven) as dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append("  group by ccodcta  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)


        Dim ds As New DataSet
        Dim ldfecven As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            ldfecven = Today
        Else
            ldfecven = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return ldfecven
    End Function

    Public Function UltimaCuotadeCapital(ByVal cCodcta As String, ByVal dfecven As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nCapita ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven>=@dfecven and dfecven<=@dfecven ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        args(1) = New SqlParameter("@dfecven", dfecven)

        Dim ds As New DataSet
        Dim lnCapInt As Double
        Dim lncapita As Double
        Dim lnintere As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnCapInt = lncapita
        End If
        Return lnCapInt
    End Function

    Public Function CuotaseVence(ByVal cCodcta As String, ByVal dfecini As Date, ByVal dfecfin As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT dfecven FROM CREDPPG   ")
        strSQL.Append("WHERE cCodcta = @cCodcta and cTipope ='N' ")
        strSQL.Append("and dfecven >= @dfecini and dfecven <= @dfecfin ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        args(1) = New SqlParameter("@dfecini", dfecini)
        args(2) = New SqlParameter("@dfecfin", dfecfin)

        Dim ds As New DataSet
        Dim lcflag As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcflag = ""
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("dfecven")) Then
                lcflag = ""
            Else
                Dim ldfecvig As Date
                ldfecvig = ds.Tables(0).Rows(0)("dfecven")
                lcflag = ldfecvig.ToString
            End If
        End If

        Return lcflag
    End Function
    Public Function PlanGrupalTeorico(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT credppg.dfecven, credppg.ctipope, credppg.cnrocuo,")
        strSQL.Append(" round(cretlin.ntasint/12,2) as ntasint, ")
        strSQL.Append("  sum(credppg.ncapita) as ncapita, ")
        strSQL.Append(" sum(credppg.nintere) as nintere, ")
        strSQL.Append(" sum(credppg.ngastos) as ngastos, ")
        strSQL.Append(" sum(credppg.nsegdeu) as nsegdeu, ")
        strSQL.Append(" 000000.00 as saldo, 000000.00 as salint, ")
        strSQL.Append(" sum((credppg.ncapita+credppg.nintere+(case when credppg.ngastos is null then 0 else credppg.ngastos end ) + (case when credppg.nsegdeu is null then 0 else credppg.nsegdeu end ))) as nmoncuo ")
        strSQL.Append(" FROM credppg, cremcre, cretlin ")
        strSQL.Append(" WHERE cremcre.ccodcta = credppg.ccodcta and cremcre.ccodsol = @cCodsol and cremcre.dfecvig >=@dfecha and cremcre.dfecvig <= @dfecha ")
        strSQL.Append(" and cretlin.cnrolin = cremcre.cnrolin")
        strSQL.Append(" GROUP BY cremcre.cCodsol, cremcre.dfecvig, credppg.dfecven, credppg.ctipope, credppg.cnrocuo,")
        strSQL.Append(" cretlin.ntasint ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", ccodsol)
        args(1) = New SqlParameter("@dfecha", dfecha)
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function ProximaCuotadePlan(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT min(dfecven) as dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and dfecven > @dfecha ")
        strSQL.Append("  group by ccodcta  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim ldfecven As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            ldfecven = dfecha
        Else
            ldfecven = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return ldfecven
    End Function

    Public Function ConsolidaPlanExtra(ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" select  ccodcta, dfecven,  SUM(ncapita) as ncapita, ")
        strSQL.Append(" SUM(nintere) as nintere , ctipope from credppg ")
        strSQL.Append(" where ccodcta =@ccodcta ")
        strSQL.Append(" group by ccodcta, dfecven, ctipope order by dfecven ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function CuotasTeoricasMonto(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(ncapita) as ncapita ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven<= @dfecha group by ccodcta  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lncapita As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lncapita = ds.Tables(0).Rows(0)("ncapita")
        End If
        Return lncapita
    End Function

    Public Function CuotaTeoricaMonto(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ncapita ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven>= @dfecha and dfecven <= @dfecha  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lncapita As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lncapita = ds.Tables(0).Rows(0)("ncapita")
        End If
        Return lncapita
    End Function
    Public Function InteresPendiente(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(ngastos) as nintere ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven <= @dfecha group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lninteres As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lninteres = 0
        Else
            lninteres = ds.Tables(0).Rows(0)("nintere")
        End If

        Return lninteres
    End Function

    Public Function InteresPendienteTotal(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(ngastos) as nintere ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N'  group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lninteres As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lninteres = 0
        Else
            lninteres = ds.Tables(0).Rows(0)("nintere")
        End If

        Return lninteres
    End Function
    Public Function FechaCapitalCubierto(ByVal ccodcta As String, ByVal nsaldopag As Double, ByVal dfecvig As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nCapita, cnrocuo, 00000.00 as ncappag, dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' order by cNrocuo  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lcnrocuo As String = "001"
        Dim ldfecha As Date = dfecvig

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcnrocuo = "001"
        Else
            Dim fila As DataRow
            Dim i As Integer = 0
            Dim lncapita As Double = 0

            For Each fila In ds.Tables(0).Rows

                lncapita = ds.Tables(0).Rows(i)("ncapita")


                If Math.Round(nsaldopag, 2) >= Math.Round(lncapita, 2) Then
                    lcnrocuo = ds.Tables(0).Rows(i)("cnrocuo")
                    ldfecha = ds.Tables(0).Rows(i)("dfecven")
                    nsaldopag = nsaldopag - lncapita
                Else
                    Exit For
                End If
                i += 1
            Next
        End If
        Return ldfecha
    End Function

    Public Function FechaInteresCubierto(ByVal ccodcta As String, ByVal nsaldopag As Double, ByVal dfecvig As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nintere, cnrocuo, 00000.00 as nintpag, dfecven ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' order by cNrocuo  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lcnrocuo As String = "001"
        Dim ldfecha As Date = dfecvig

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcnrocuo = "001"
        Else
            Dim fila As DataRow
            Dim i As Integer = 0
            Dim lnintere As Double = 0

            For Each fila In ds.Tables(0).Rows

                lnintere = ds.Tables(0).Rows(i)("nintere")


                If Math.Round(nsaldopag, 2) >= Math.Round(lnintere, 2) Then
                    lcnrocuo = ds.Tables(0).Rows(i)("cnrocuo")
                    ldfecha = ds.Tables(0).Rows(i)("dfecven")
                    nsaldopag = nsaldopag - lnintere
                Else
                    Exit For
                End If
                i += 1
            Next
        End If
        Return ldfecha
    End Function
    Public Function ObtenerCuotaUltimaVencida(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT max(cnrocuo) as cnrocuo ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven <= @dfecha group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        Dim lcnrocuo As String = "001"


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnrocuo")) Then
            Else
                lcnrocuo = ds.Tables(0).Rows(0)("cnrocuo")
            End If
        
        End If
        Return lcnrocuo
    End Function
    Public Function GrabaInteresCongelado(ByVal ccodcta As String, ByVal cnrocuo As String, ByVal nmonto As Decimal) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPPG set ngastos = (ngastos + @nmonto)  ")
        strSQL.Append("WHERE  ccodcta = @ccodcta and cnrocuo = @cnrocuo and ctipope ='N' ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnrocuo", cnrocuo)
        args(2) = New SqlParameter("@nmonto", nmonto)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function CuotaTeoricaMontoporRango(ByVal ccodcta As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ncapita ")
        strSQL.Append(" FROM credppg ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and dfecven>= @dfecha1 and dfecven <= @dfecha2  ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha1", dfecha1)
        args(2) = New SqlParameter("@dfecha2", dfecha2)

        Dim ds As New DataSet
        Dim lncapita As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lncapita = ds.Tables(0).Rows(0)("ncapita")
        End If
        Return lncapita
    End Function
    Public Function ObtenerSaldoInteresPlan(ByVal lccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT  sum(nintere) as nintere FROM credppg WHERE ccodcta = @lccodcta ")
        strSQL.Append(" and ctipope = 'N' group by cCodcta ")

        Dim args(0) As SqlParameter

        args(0) = New SqlParameter("@lccodcta", SqlDbType.VarChar)
        args(0).Value = lccodcta

        Dim ds As DataSet
        Dim lnintere As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnintere = ds.Tables(0).Rows(0)("nintere")
        End If
        Return lnintere
    End Function

    Public Function SaldoAlDia(ByVal lccodcta As String, ByVal ldfecval As Date) As Double

        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim saldoActual As Double

        'Cesar Torres 02/02/2016 reducir los campos del dataset
        Dim DsR As New DataSet
        'Cesar Torres 02/02/2016

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Call_fxSalIntere_Flat"

                MyParameters = _
                                MyCommand.Parameters.Add("@pccodcta", SqlDbType.VarChar)
                MyParameters.Value = lccodcta
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                        MyCommand.Parameters.Add("@dfecha", SqlDbType.Date)
                MyParameters.Value = ldfecval
                MyParameters.Direction = ParameterDirection.Input


                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds, "Cartera")
                saldoActual = Ds.Tables(0).Rows(0)("saldo_al_dia")
            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using
        Return saldoActual



    End Function

    Public Function Extrae_Saldo_Interes_Total_Flat(ByVal pccodcta As String, ByVal dfecha As Date) As Double

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lnPagado As Double = 0
        Dim lnTeorico As Double = 0
        Dim lnSaldoInteresFlat As Double = 0

        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection

                'Extrae lo pagado incluyendo Iva
                command.CommandText = _
                                        " Select isnull(sum(nmonto),0) as npagado from credkar " & _
                                        " where ccodcta = '" & pccodcta & "'" & _
                                        " and cdescob = 'C' and cconcep in('IN','08') " & _
                                        " and cestado <> 'X' " & _
                                        " and dfecsis <='" & dfecha & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Pagado")


                For Each fila As DataRow In ds_Trab.Tables("Pagado").Rows
                    lnPagado = fila("npagado")
                Next


                'Extrae lo Teorico sin tomar encuenta si la cuota de Interes esta vencida
                command.CommandText = _
                                        " Select isnull(SUM(nintere),0) as nintere from credppg " & _
                                        " where ccodcta = '" & pccodcta & "' " & _
                                        " and ctipope = 'N' "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Teorico")


                For Each fila As DataRow In ds_Trab.Tables("Teorico").Rows
                    lnTeorico = fila("nintere")
                Next


                lnSaldoInteresFlat = lnTeorico - lnPagado
                lnSaldoInteresFlat = Math.Round(lnSaldoInteresFlat, 2)

                If lnSaldoInteresFlat < 0 Then
                    lnSaldoInteresFlat = 0
                End If

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnSaldoInteresFlat

    End Function

End Class

