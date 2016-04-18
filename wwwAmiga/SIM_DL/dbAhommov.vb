Imports System.Text
Public Class dbAhommov
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

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahommov
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.clinea =  "" _
            Or lEntidad.clinea = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.clinea = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahommov ")
        strSQL.Append(" SET dfecope = @dfecope, ") 
        strSQL.Append(" ctipope = @ctipope, ") 
        strSQL.Append(" cnumdoc = @cnumdoc, ") 
        strSQL.Append(" ctipdoc = @ctipdoc, ") 
        strSQL.Append(" crazon = @crazon, ") 
        strSQL.Append(" nlibreta = @nlibreta, ") 
        strSQL.Append(" cnrochq = @cnrochq, ") 
        strSQL.Append(" ctipchq = @ctipchq, ") 
        strSQL.Append(" dfecomp = @dfecomp, ") 
        strSQL.Append(" dfecefe = @dfecefe, ") 
        strSQL.Append(" npartida = @npartida, ") 
        strSQL.Append(" nmonto = @nmonto, ") 
        strSQL.Append(" interes = @interes, ") 
        strSQL.Append(" ncorrel = @ncorrel, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" nnum = @nnum, ") 
        strSQL.Append(" tip = @tip, ") 
        strSQL.Append(" nsaldoaho = @nsaldoaho, ") 
        strSQL.Append(" nsaldnind = @nsaldnind, ") 
        strSQL.Append(" cconcep = @cconcep, ") 
        strSQL.Append(" ctipaho = @ctipaho, ") 
        strSQL.Append(" producto = @producto, ") 
        strSQL.Append(" ncompen = @ncompen ") 
        strSQL.Append(" ccodtra = @ccodtra, ") 
        strSQL.Append(" notromon = @notromon, ") 
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND clinea = @clinea ") 

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@dfecope", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecope
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipope
        args(2) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnumdoc
        args(3) = New SqlParameter("@ctipdoc", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipdoc
        args(4) = New SqlParameter("@crazon", SqlDbType.VarChar)
        args(4).Value = lEntidad.crazon
        args(5) = New SqlParameter("@nlibreta", SqlDbType.Decimal)
        args(5).Value = lEntidad.nlibreta
        args(6) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnrochq
        args(7) = New SqlParameter("@ctipchq", SqlDbType.VarChar)
        args(7).Value = lEntidad.ctipchq
        args(8) = New SqlParameter("@dfecomp", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfecomp
        args(9) = New SqlParameter("@dfecefe", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecefe
        args(10) = New SqlParameter("@npartida", SqlDbType.Decimal)
        args(10).Value = lEntidad.npartida
        args(11) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(11).Value = lEntidad.nmonto
        args(12) = New SqlParameter("@interes", SqlDbType.Decimal)
        args(12).Value = lEntidad.interes
        args(13) = New SqlParameter("@ncorrel", SqlDbType.Decimal)
        args(13).Value = lEntidad.ncorrel
        args(14) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(14).Value = lEntidad.dfecmod
        args(15) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodusu
        args(16) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(16).Value = lEntidad.nnum
        args(17) = New SqlParameter("@tip", SqlDbType.VarChar)
        args(17).Value = lEntidad.tip
        args(18) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(18).Value = lEntidad.nsaldoaho
        args(19) = New SqlParameter("@nsaldnind", SqlDbType.Decimal)
        args(19).Value = lEntidad.nsaldnind
        args(20) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(20).Value = lEntidad.cconcep
        args(21) = New SqlParameter("@ctipaho", SqlDbType.VarChar)
        args(21).Value = lEntidad.ctipaho
        args(22) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(22).Value = lEntidad.producto
        args(23) = New SqlParameter("@ncompen", SqlDbType.Decimal)
        args(23).Value = lEntidad.ncompen
        args(24) = New SqlParameter("@ccodtra", SqlDbType.VarChar)
        args(24).Value = lEntidad.ccodtra
        args(25) = New SqlParameter("@notromon", SqlDbType.Decimal)
        args(25).Value = lEntidad.notromon
        args(26) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(26).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value,lEntidad.ccodaho)
        args(27) = New SqlParameter("@clinea", SqlDbType.VarChar)
        args(27).Value = IIf(lEntidad.clinea = Nothing, DBNull.Value,lEntidad.clinea)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahommov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahommov ")
        strSQL.Append(" ( ccodaho, ") 
        strSQL.Append(" dfecope, ") 
        strSQL.Append(" ctipope, ") 
        strSQL.Append(" cnumdoc, ") 
        strSQL.Append(" ctipdoc, ") 
        strSQL.Append(" crazon, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" cnrochq, ") 
        strSQL.Append(" ctipchq, ") 
        strSQL.Append(" dfecomp, ") 
        strSQL.Append(" dfecefe, ") 
        strSQL.Append(" npartida, ") 
        strSQL.Append(" nmonto, ") 
        strSQL.Append(" interes, ") 
        strSQL.Append(" clinea, ") 
        strSQL.Append(" ncorrel, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" nnum, ") 
        strSQL.Append(" tip, ") 
        strSQL.Append(" nsaldoaho, ") 
        strSQL.Append(" nsaldnind, ") 
        strSQL.Append(" cconcep, ") 
        strSQL.Append(" ctipaho, ") 
        strSQL.Append(" producto, ") 
        strSQL.Append(" ncompen, ")
        strSQL.Append(" ccodtra, ") 
        strSQL.Append(" notromon) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodaho, ") 
        strSQL.Append(" @dfecope, ") 
        strSQL.Append(" @ctipope, ") 
        strSQL.Append(" @cnumdoc, ") 
        strSQL.Append(" @ctipdoc, ") 
        strSQL.Append(" @crazon, ") 
        strSQL.Append(" @nlibreta, ") 
        strSQL.Append(" @cnrochq, ") 
        strSQL.Append(" @ctipchq, ") 
        strSQL.Append(" @dfecomp, ") 
        strSQL.Append(" @dfecefe, ") 
        strSQL.Append(" @npartida, ") 
        strSQL.Append(" @nmonto, ") 
        strSQL.Append(" @interes, ") 
        strSQL.Append(" @clinea, ") 
        strSQL.Append(" @ncorrel, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @nnum, ") 
        strSQL.Append(" @tip, ") 
        strSQL.Append(" @nsaldoaho, ") 
        strSQL.Append(" @nsaldnind, ") 
        strSQL.Append(" @cconcep, ") 
        strSQL.Append(" @ctipaho, ") 
        strSQL.Append(" @producto, ") 
        strSQL.Append(" @ncompen, ")
        strSQL.Append(" @ccodtra, ")
        strSQL.Append(" @notromon) ")

        Dim args(27) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(1) = New SqlParameter("@dfecope", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecope
        args(2) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipope
        args(3) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnumdoc
        args(4) = New SqlParameter("@ctipdoc", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipdoc
        args(5) = New SqlParameter("@crazon", SqlDbType.VarChar)
        args(5).Value = lEntidad.crazon
        args(6) = New SqlParameter("@nlibreta", SqlDbType.Decimal)
        args(6).Value = lEntidad.nlibreta
        args(7) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(7).Value = lEntidad.cnrochq
        args(8) = New SqlParameter("@ctipchq", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctipchq
        args(9) = New SqlParameter("@dfecomp", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecomp
        args(10) = New SqlParameter("@dfecefe", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecefe
        args(11) = New SqlParameter("@npartida", SqlDbType.Decimal)
        args(11).Value = lEntidad.npartida
        args(12) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(12).Value = lEntidad.nmonto
        args(13) = New SqlParameter("@interes", SqlDbType.Decimal)
        args(13).Value = lEntidad.interes
        args(14) = New SqlParameter("@clinea", SqlDbType.VarChar)
        args(14).Value = IIf(lEntidad.clinea = Nothing, "N", lEntidad.clinea)
        args(15) = New SqlParameter("@ncorrel", SqlDbType.Decimal)
        args(15).Value = lEntidad.ncorrel
        args(16) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(16).Value = lEntidad.dfecmod
        args(17) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodusu
        args(18) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(18).Value = lEntidad.nnum
        args(19) = New SqlParameter("@tip", SqlDbType.VarChar)
        args(19).Value = lEntidad.tip
        args(20) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(20).Value = lEntidad.nsaldoaho
        args(21) = New SqlParameter("@nsaldnind", SqlDbType.Decimal)
        args(21).Value = lEntidad.nsaldnind
        args(22) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(22).Value = lEntidad.cconcep
        args(23) = New SqlParameter("@ctipaho", SqlDbType.VarChar)
        args(23).Value = lEntidad.ctipaho
        args(24) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(24).Value = lEntidad.producto
        args(25) = New SqlParameter("@ncompen", SqlDbType.Decimal)
        args(25).Value = lEntidad.ncompen
        args(26) = New SqlParameter("@ccodtra", SqlDbType.VarChar)
        args(26).Value = lEntidad.ccodtra
        args(27) = New SqlParameter("@notromon", SqlDbType.Decimal)
        args(27).Value = lEntidad.notromon

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahommov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahommov ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND nnum = @nnum ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@nnum", SqlDbType.VarChar)
        args(1).Value = lEntidad.nnum

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahommov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND nnum = @nnum ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@nnum", SqlDbType.VarChar)
        args(1).Value = lEntidad.nnum

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.dfecope = IIf(.Item("dfecope") Is DBNull.Value, Nothing, .Item("dfecope"))
                lEntidad.ctipope = IIf(.Item("ctipope") Is DBNull.Value, Nothing, .Item("ctipope"))
                lEntidad.cnumdoc = IIf(.Item("cnumdoc") Is DBNull.Value, Nothing, .Item("cnumdoc"))
                lEntidad.ctipdoc = IIf(.Item("ctipdoc") Is DBNull.Value, Nothing, .Item("ctipdoc"))
                lEntidad.crazon = IIf(.Item("crazon") Is DBNull.Value, Nothing, .Item("crazon"))
                lEntidad.nlibreta = IIf(.Item("nlibreta") Is DBNull.Value, Nothing, .Item("nlibreta"))
                lEntidad.cnrochq = IIf(.Item("cnrochq") Is DBNull.Value, Nothing, .Item("cnrochq"))
                lEntidad.ctipchq = IIf(.Item("ctipchq") Is DBNull.Value, Nothing, .Item("ctipchq"))
                lEntidad.dfecomp = IIf(.Item("dfecomp") Is DBNull.Value, Nothing, .Item("dfecomp"))
                lEntidad.dfecefe = IIf(.Item("dfecefe") Is DBNull.Value, Nothing, .Item("dfecefe"))
                lEntidad.npartida = IIf(.Item("npartida") Is DBNull.Value, Nothing, .Item("npartida"))
                lEntidad.nmonto = IIf(.Item("nmonto") Is DBNull.Value, Nothing, .Item("nmonto"))
                lEntidad.interes = IIf(.Item("interes") Is DBNull.Value, Nothing, .Item("interes"))
                lEntidad.ncorrel = IIf(.Item("ncorrel") Is DBNull.Value, Nothing, .Item("ncorrel"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.nnum = IIf(.Item("nnum") Is DBNull.Value, Nothing, .Item("nnum"))
                lEntidad.tip = IIf(.Item("tip") Is DBNull.Value, Nothing, .Item("tip"))
                lEntidad.nsaldoaho = IIf(.Item("nsaldoaho") Is DBNull.Value, Nothing, .Item("nsaldoaho"))
                lEntidad.nsaldnind = IIf(.Item("nsaldnind") Is DBNull.Value, Nothing, .Item("nsaldnind"))
                lEntidad.cconcep = IIf(.Item("cconcep") Is DBNull.Value, Nothing, .Item("cconcep"))
                lEntidad.ctipaho = IIf(.Item("ctipaho") Is DBNull.Value, Nothing, .Item("ctipaho"))
                lEntidad.producto = IIf(.Item("producto") Is DBNull.Value, Nothing, .Item("producto"))
                lEntidad.ncompen = IIf(.Item("ncompen") Is DBNull.Value, Nothing, .Item("ncompen"))
                lEntidad.ccodtra = IIf(.Item("ccodtra") Is DBNull.Value, Nothing, .Item("ccodtra"))
                lEntidad.notromon = IIf(.Item("notromon") Is DBNull.Value, Nothing, .Item("notromon"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahommov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(clinea),0) + 1 ")
        strSQL.Append(" FROM ahommov ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodaho As String) As listaahommov

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listaahommov

        Try
            Do While dr.Read()
                Dim mEntidad As New ahommov
                mEntidad.ccodaho = ccodaho
                mEntidad.dfecope = IIf(dr("dfecope") Is DBNull.Value, Nothing, dr("dfecope"))
                mEntidad.ctipope = IIf(dr("ctipope") Is DBNull.Value, Nothing, dr("ctipope"))
                mEntidad.cnumdoc = IIf(dr("cnumdoc") Is DBNull.Value, Nothing, dr("cnumdoc"))
                mEntidad.ctipdoc = IIf(dr("ctipdoc") Is DBNull.Value, Nothing, dr("ctipdoc"))
                mEntidad.crazon = IIf(dr("crazon") Is DBNull.Value, Nothing, dr("crazon"))
                mEntidad.nlibreta = IIf(dr("nlibreta") Is DBNull.Value, Nothing, dr("nlibreta"))
                mEntidad.cnrochq = IIf(dr("cnrochq") Is DBNull.Value, Nothing, dr("cnrochq"))
                mEntidad.ctipchq = IIf(dr("ctipchq") Is DBNull.Value, Nothing, dr("ctipchq"))
                mEntidad.dfecomp = IIf(dr("dfecomp") Is DBNull.Value, Nothing, dr("dfecomp"))
                mEntidad.dfecefe = IIf(dr("dfecefe") Is DBNull.Value, Nothing, dr("dfecefe"))
                mEntidad.npartida = IIf(dr("npartida") Is DBNull.Value, Nothing, dr("npartida"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.interes = IIf(dr("interes") Is DBNull.Value, Nothing, dr("interes"))
                mEntidad.clinea = IIf(dr("clinea") Is DBNull.Value, Nothing, dr("clinea"))
                mEntidad.ncorrel = IIf(dr("ncorrel") Is DBNull.Value, Nothing, dr("ncorrel"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nnum = IIf(dr("nnum") Is DBNull.Value, Nothing, dr("nnum"))
                mEntidad.tip = IIf(dr("tip") Is DBNull.Value, Nothing, dr("tip"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.nsaldnind = IIf(dr("nsaldnind") Is DBNull.Value, Nothing, dr("nsaldnind"))
                mEntidad.cconcep = IIf(dr("cconcep") Is DBNull.Value, Nothing, dr("cconcep"))
                mEntidad.ctipaho = IIf(dr("ctipaho") Is DBNull.Value, Nothing, dr("ctipaho"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.ncompen = IIf(dr("ncompen") Is DBNull.Value, Nothing, dr("ncompen"))
                mEntidad.ccodtra = IIf(dr("ccodtra") Is DBNull.Value, Nothing, dr("ccodtra"))
                mEntidad.notromon = IIf(dr("notromon") Is DBNull.Value, Nothing, dr("notromon"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodaho As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodaho As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim tables(0) As String
        tables(0) = New String("ahommov")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodaho, ") 
        strSQL.Append(" dfecope, ") 
        strSQL.Append(" ctipope, ") 
        strSQL.Append(" cnumdoc, ") 
        strSQL.Append(" ctipdoc, ") 
        strSQL.Append(" crazon, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" cnrochq, ") 
        strSQL.Append(" ctipchq, ") 
        strSQL.Append(" dfecomp, ") 
        strSQL.Append(" dfecefe, ") 
        strSQL.Append(" npartida, ") 
        strSQL.Append(" nmonto, ") 
        strSQL.Append(" interes, ") 
        strSQL.Append(" clinea, ") 
        strSQL.Append(" ncorrel, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" nnum, ") 
        strSQL.Append(" tip, ") 
        strSQL.Append(" nsaldoaho, ") 
        strSQL.Append(" nsaldnind, ") 
        strSQL.Append(" cconcep, ") 
        strSQL.Append(" ctipaho, ") 
        strSQL.Append(" producto, ") 
        strSQL.Append(" ncompen, ") 
        strSQL.Append(" ccodtra, ") 
        strSQL.Append(" notromon ") 
        strSQL.Append(" FROM ahommov ")

    End Sub

    'funcion para la provision de intereses de ahorros


    Public Function obtiene_saldo_anterior_a_fecha_inicio(ByVal ccodaho As String, ByVal dfecha As Date) As Double

        Dim strSQL As New StringBuilder
        Dim lnsaldoantes As Double
        Dim dr As DataRow

        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ")
        strSQL.Append(" AND DFECOPE <  @dfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)
        args(0).Value = ccodaho
        args(1) = New SqlParameter("@dfecha", dfecha)
        args(1).Value = dfecha

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        lnsaldoantes = 0
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                If dr("dfecope") >= dfecha Then
                    lnsaldoantes = ds.Tables(0).Rows(0)("nsaldoaho")
                End If
            Next
        End If

        Return lnsaldoantes
    End Function

    'obtiene lista de ahommov con movimientos entre 2 fechas
    Public Function movimientos_por_cuent_fecha(ByVal ccodaho As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As listaahommov

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ")
        strSQL.Append(" AND dfecope >= @dfecha1 ")
        strSQL.Append(" AND dfecope <= @dfecha2 ")
        strSQL.Append(" ORDER BY dfecope")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho
        args(1) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(1).Value = dfecha1
        args(2) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(2).Value = dfecha2

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaahommov

        Try
            Do While dr.Read()
                Dim mEntidad As New ahommov
                mEntidad.ccodaho = ccodaho
                mEntidad.dfecope = IIf(dr("dfecope") Is DBNull.Value, Nothing, dr("dfecope"))
                mEntidad.ctipope = IIf(dr("ctipope") Is DBNull.Value, Nothing, dr("ctipope"))
                mEntidad.cnumdoc = IIf(dr("cnumdoc") Is DBNull.Value, Nothing, dr("cnumdoc"))
                mEntidad.ctipdoc = IIf(dr("ctipdoc") Is DBNull.Value, Nothing, dr("ctipdoc"))
                mEntidad.crazon = IIf(dr("crazon") Is DBNull.Value, Nothing, dr("crazon"))
                mEntidad.nlibreta = IIf(dr("nlibreta") Is DBNull.Value, Nothing, dr("nlibreta"))
                mEntidad.cnrochq = IIf(dr("cnrochq") Is DBNull.Value, Nothing, dr("cnrochq"))
                mEntidad.ctipchq = IIf(dr("ctipchq") Is DBNull.Value, Nothing, dr("ctipchq"))
                mEntidad.dfecomp = IIf(dr("dfecomp") Is DBNull.Value, Nothing, dr("dfecomp"))
                mEntidad.dfecefe = IIf(dr("dfecefe") Is DBNull.Value, Nothing, dr("dfecefe"))
                mEntidad.npartida = IIf(dr("npartida") Is DBNull.Value, Nothing, dr("npartida"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.interes = IIf(dr("interes") Is DBNull.Value, Nothing, dr("interes"))
                mEntidad.clinea = IIf(dr("clinea") Is DBNull.Value, Nothing, dr("clinea"))
                mEntidad.ncorrel = IIf(dr("ncorrel") Is DBNull.Value, Nothing, dr("ncorrel"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nnum = IIf(dr("nnum") Is DBNull.Value, Nothing, dr("nnum"))
                mEntidad.tip = IIf(dr("tip") Is DBNull.Value, Nothing, dr("tip"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.nsaldnind = IIf(dr("nsaldnind") Is DBNull.Value, Nothing, dr("nsaldnind"))
                mEntidad.cconcep = IIf(dr("cconcep") Is DBNull.Value, Nothing, dr("cconcep"))
                mEntidad.ctipaho = IIf(dr("ctipaho") Is DBNull.Value, Nothing, dr("ctipaho"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.ncompen = IIf(dr("ncompen") Is DBNull.Value, Nothing, dr("ncompen"))
                mEntidad.ccodtra = IIf(dr("ccodtra") Is DBNull.Value, Nothing, dr("ccodtra"))
                mEntidad.notromon = IIf(dr("notromon") Is DBNull.Value, Nothing, dr("notromon"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function


    'obtiene fecha de provision, si esta fue despues de la fecha en que inicia la provision
    Public Function obtiene_fecha_ultimo_movimiento(ByVal ccodaho As String, ByVal dfecha As Date) As Date

        Dim strSQL As New StringBuilder
        Dim lnsaldoantes As Double
        Dim dr As DataRow
        Dim ldfecha As Date

        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ")
        '        strSQL.Append(" AND DFECOPE <  @dfecha ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)
        args(0).Value = ccodaho
        '        args(1) = New SqlParameter("@dfecha", dfecha)
        '        args(1).Value = dfecha

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        lnsaldoantes = 0
        ldfecha = dfecha
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                If dr("dfecope") > dfecha Then
                    lnsaldoantes = ds.Tables(0).Rows(0)("nsaldoaho")
                    ldfecha = dr("dfecope")
                End If
            Next
        End If

        Return ldfecha
    End Function

    Public Function ObtieneCorrelativo(ByVal cCodaho As String) As Integer
        Dim strSQL As New StringBuilder
        'strSQL.Append("Select isnull(MAX(ncorrel),0) as ncorrel FROM AHOMMOV ")
        'strSQL.Append("WHERE ccodaho = @ccodaho ")
        strSQL.Append("Select nnum as ncorrel FROM AHOMCTA ")
        strSQL.Append("WHERE ccodaho = @ccodaho ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", cCodaho)
        args(0).Value = cCodaho

        Dim ds As New DataSet

        ds = ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lncorrel As Integer = 1

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ncorrel")) Then
            Else
                lncorrel = ds.Tables(0).Rows(0)("ncorrel")
                lncorrel += 1
            End If
        End If
        Return lncorrel

    End Function


    Public Function ObtieneCorrelativo_(ByVal cCodaho As String, ByVal con As SqlConnection) As Integer
       
        Dim _sql As String
        Dim devolver As Object = Nothing

        _sql = " Select isnull(MAX(ncorrel),0) as ncorrel FROM AHOMMOV " & _
               " Where ccodaho ='" & cCodaho & "'"

        Dim comando As New SqlCommand(_sql, con)
        comando.CommandType = CommandType.Text
        Dim ds As New DataSet
        Dim myadapter As New SqlDataAdapter

        Try

            myadapter.SelectCommand = comando
            myadapter.Fill(ds, "Correlativo")


            Dim lncorrel As Integer = 1

            If ds.Tables(0).Rows.Count = 0 Then
            Else
                If IsDBNull(ds.Tables(0).Rows(0)("ncorrel")) Then
                Else
                    lncorrel = ds.Tables(0).Rows(0)("ncorrel")
                    lncorrel += 1
                End If
            End If

            Return lncorrel

        Catch ex As Exception

        End Try

    End Function

    Public Function ObtieneLinea(ByVal cCodaho As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nnum FROM AHOMCTA ")
        strSQL.Append("WHERE ccodaho = @ccodaho ")

        'strSQL.Append("Select MAX(nnum) as nnum FROM AHOMMOV ")
        'strSQL.Append("WHERE ccodaho = @ccodaho ")

        'strSQL.Append("select top 1 nnum from ahommov where ccodaho =@ccodaho order by id desc ")



        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", cCodaho)
        args(0).Value = cCodaho

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnnum As Integer = 1

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nnum")) Then
            Else
                lnnum = ds.Tables(0).Rows(0)("nnum")
                lnnum += 1
            End If
        End If
        Return lnnum

    End Function


    Public Function ObtieneLinea_(ByVal cCodaho As String, ByVal con As SqlConnection) As Integer

        Dim _sql As String
        Dim devolver As Object = Nothing

        '_sql = " Select top 1 nnum from ahommov where ccodaho = '" & cCodaho & "' Order By id desc "
        '_sql = " Select MAX(nnum) as nnum From ahommov Where ccodaho = '" & cCodaho & "'"
        _sql = " Select nnum From ahomcta Where ccodaho = '" & cCodaho & "'"


        Dim comando As New SqlCommand(_sql, con)
        comando.CommandType = CommandType.Text
        Dim ds As New DataSet
        Dim myadapter As New SqlDataAdapter

        Try

            myadapter.SelectCommand = comando
            myadapter.Fill(ds, "Linea")


            Dim lnnum As Integer = 1

            If ds.Tables(0).Rows.Count = 0 Then
            Else
                If IsDBNull(ds.Tables(0).Rows(0)("nnum")) Then
                Else
                    lnnum = ds.Tables(0).Rows(0)("nnum")
                    lnnum += 1
                End If
            End If
            Return lnnum

        Catch ex As Exception

        End Try

    End Function

    Public Function ObtenerMovimientoAhorro(ByVal ccodaho As String, ByVal cconcep As String, ByVal dfecope As Date, ByVal cnumdoc As String) As DataTable
        Dim strCadena As String = ""
        Dim strcodigo As String = ""
        Dim strconcepto As String = ""
        Dim strfecha As String = ""
        Dim strdoc As String = ""
        Dim lcfecha As String
        lcfecha = Left(dfecope.ToString, 10)


        Dim dtTabla As New DataTable("Movimientos")
        Dim damovimientos As New SqlDataAdapter
        Dim cmComando As New SqlCommand
        strcodigo = " ahommov.ccodaho= '" + ccodaho + "'"
        strconcepto = " and ahommov.cconcep= '" + cconcep + "'"
        strfecha = " and ahommov.dfecope= '" + lcfecha + "'"
        strdoc = " and ahommov.cnumdoc= '" + cnumdoc + "'"

        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()
            strCadena = "set language spanish; " & _
            "Select * FROM AHOMMOV WHERE " & strcodigo & strconcepto & strfecha & strdoc


            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion

            damovimientos.SelectCommand = cmComando
            damovimientos.SelectCommand.CommandTimeout = 0
            damovimientos.Fill(dtTabla)
            damovimientos.SelectCommand.Dispose()


        End Using

        Return dtTabla
    End Function

    Public Function ObtenerBusquedadeMonto(ByVal dfecha As Date, ByVal ccodusu As String, ByVal nmonto As Decimal) As DataTable
        Dim strCadena As String = ""
        Dim strcodigo As String = ""
        Dim strconcepto As String = ""
        Dim strfecha As String = ""
        Dim strdoc As String = ""
        Dim lcfecha As String
        lcfecha = Left(dfecha.ToString, 10)


        Dim dtTabla As New DataTable("Movimientos")
        Dim damovimientos As New SqlDataAdapter
        Dim cmComando As New SqlCommand
        strcodigo = " ahommov.dfecope = '" + lcfecha + "'"
        strconcepto = " and ahommov.nmonto= '" + nmonto.ToString + "'"
        strfecha = " and ahommov.ccodusu= '" + ccodusu + "'"
        strdoc = " and ahomcta.ccodaho = ahommov.ccodaho and ahomcta.cnudotr = climide.ccodcli"

        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()
            strCadena = " " & _
            "Select AHOMCTA.ccodaho, AHOMCTA.nsaldoaho, AHOMMOV.nmonto, AHOMMOV.dfecope, climide.cnomcli " & _
            " FROM AHOMCTA, AHOMMOV, CLIMIDE WHERE " & strcodigo & strconcepto & strfecha & strdoc


            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion

            damovimientos.SelectCommand = cmComando
            damovimientos.SelectCommand.CommandTimeout = 0
            damovimientos.Fill(dtTabla)
            damovimientos.SelectCommand.Dispose()


        End Using

        Return dtTabla
    End Function
    Public Function ObtieneDepositosxcuenta(ByVal ccodaho As String, ByVal dfecha As Date) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("select sum(nmonto) as nmonto FROM AHOMMOV ")
        strSQL.Append("WHERE ccodaho = @ccodaho and dfecope >= @dfecha group by ccodaho")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnmonto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
            Else
                lnmonto = ds.Tables(0).Rows(0)("nmonto")
            End If
        End If

        Return lnmonto
    End Function

    Public Function ObtienePagina(ByVal cCodaho As String, ByVal nnum As Integer) As Integer
        nnum = nnum - 1
        Dim strSQL As New StringBuilder

        strSQL.Append("select pagina from ahommov where ccodaho =@ccodaho and nnum = @nnum order by id desc ")

        cCodaho = cCodaho.ToString.Trim

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", cCodaho)
        args(0).Value = cCodaho
        args(1) = New SqlParameter("@nnum", nnum)
        args(1).Value = nnum

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lnpagina As Integer = 1

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("pagina")) Then
            Else
                lnpagina = ds.Tables(0).Rows(0)("pagina")
                If nnum = 30 And lnpagina <= 3 Then
                    lnpagina += 1
                End If
                If nnum = 15 And lnpagina > 3 Then
                    lnpagina += 1
                End If
                If lnpagina > 4 Then
                    lnpagina = 1

                End If
            End If
        End If
        If lnpagina = 0 Then
            lnpagina = 1
        End If
        Return lnpagina

    End Function

    Public Function ObtienePaginaUltima(ByVal cCodaho As String, ByVal nnum As Integer) As Integer
        nnum = nnum - 1
        Dim strSQL As New StringBuilder

        strSQL.Append("select pagina from ahommov where ccodaho =@ccodaho and nnum = @nnum order by id desc ")

        cCodaho = cCodaho.ToString.Trim

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", cCodaho)
        args(0).Value = cCodaho
        args(1) = New SqlParameter("@nnum", nnum)
        args(1).Value = nnum

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lnpagina As Integer = 1

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("pagina")) Then
            Else
                lnpagina = ds.Tables(0).Rows(0)("pagina")
            End If
        End If
        Return lnpagina

    End Function

    Public Function fxLinea(ByVal pnlinea As Integer) As Integer
        If pnlinea > 65 Then
            'MESSAGEBOX("Su Libreta ha Terminado," + Chr(13) + "Pasar por una Nueva", 48, "mensaje")
            pnlinea = 1
        End If

        Return pnlinea
    End Function
End Class
