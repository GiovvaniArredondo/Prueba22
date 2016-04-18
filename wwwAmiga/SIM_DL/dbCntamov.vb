Imports System.Text
Public Class dbCntamov
    Inherits dbBase

    'Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

    '    Dim lEntidad As cntamov
    '    Dim lID As Long
    '    lEntidad = aEntidad

    '    If lEntidad.cnumlin =  0 _
    '        Or lEntidad.cnumlin = Nothing Then 

    '        lID = Me.ObtenerID(lEntidad)

    '        If lID = -1 Then Return -1

    '        lEntidad.cnumlin = lID

    '        Return Agregar(lEntidad)

    '    End If

    '    Dim strSQL As New StringBuilder
    '    strSQL.Append("UPDATE cntamov ")
    '    strSQL.Append(" SET ccodsec = @ccodsec, ") 
    '    strSQL.Append(" ffondos = @ffondos, ") 
    '    strSQL.Append(" ccodcta = @ccodcta, ") 
    '    strSQL.Append(" cclase = @cclase, ") 
    '    strSQL.Append(" ndebe = @ndebe, ") 
    '    strSQL.Append(" nhaber = @nhaber, ") 
    '    strSQL.Append(" cflc = @cflc, ") 
    '    strSQL.Append(" nfln = @nfln, ") 
    '    strSQL.Append(" cnumdoc = @cnumdoc, ") 
    '    strSQL.Append(" dfeccnt = @dfeccnt, ") 
    '    strSQL.Append(" ccodpres = @ccodpres, ") 
    '    strSQL.Append(" cconcepto = @cconcepto, ") 
    '    strSQL.Append(" cpoliza = @cpoliza, ") 
    '    strSQL.Append(" ccodofi = @ccodofi, ") 
    '    strSQL.Append(" cnumpol = @cnumpol, ") 
    '    strSQL.Append(" ccodreg = @ccodreg, ") 
    '    strSQL.Append(" dfecmod = @dfecmod ") 
    '    strSQL.Append(" ccodusu1 = @ccodusu1, ") 
    '    strSQL.Append(" ccodcli = @ccodcli, ") 
    '    strSQL.Append(" WHERE cnumcom = @cnumcom ") 
    '    strSQL.Append(" AND cnumlin = @cnumlin ") 

    '    Dim args(18) As SqlParameter
    '    args(0) = New SqlParameter("@ccodsec", SqlDbType.VarChar)
    '    args(0).Value = lEntidad.ccodsec
    '    args(1) = New SqlParameter("@ffondos", SqlDbType.VarChar)
    '    args(1).Value = lEntidad.ffondos
    '    args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
    '    args(2).Value = lEntidad.ccodcta
    '    args(3) = New SqlParameter("@cclase", SqlDbType.VarChar)
    '    args(3).Value = lEntidad.cclase
    '    args(4) = New SqlParameter("@ndebe", SqlDbType.VarChar)
    '    args(4).Value = lEntidad.ndebe
    '    args(5) = New SqlParameter("@nhaber", SqlDbType.VarChar)
    '    args(5).Value = lEntidad.nhaber
    '    args(6) = New SqlParameter("@cflc", SqlDbType.VarChar)
    '    args(6).Value = lEntidad.cflc
    '    args(7) = New SqlParameter("@nfln", SqlDbType.VarChar)
    '    args(7).Value = lEntidad.nfln
    '    args(8) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
    '    args(8).Value = lEntidad.cnumdoc
    '    args(9) = New SqlParameter("@dfeccnt", SqlDbType.Datetime)
    '    args(9).Value = lEntidad.dfeccnt
    '    args(10) = New SqlParameter("@ccodpres", SqlDbType.VarChar)
    '    args(10).Value = lEntidad.ccodpres
    '    args(11) = New SqlParameter("@cconcepto", SqlDbType.VarChar)
    '    args(11).Value = lEntidad.cconcepto
    '    args(12) = New SqlParameter("@cpoliza", SqlDbType.VarChar)
    '    args(12).Value = lEntidad.cpoliza
    '    args(13) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
    '    args(13).Value = lEntidad.ccodofi
    '    args(14) = New SqlParameter("@cnumpol", SqlDbType.VarChar)
    '    args(14).Value = lEntidad.cnumpol
    '    args(15) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
    '    args(15).Value = lEntidad.ccodreg
    '    args(16) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
    '    args(16).Value = lEntidad.dfecmod
    '    args(17) = New SqlParameter("@ccodusu1", SqlDbType.VarChar)
    '    args(17).Value = lEntidad.ccodusu1
    '    args(18) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
    '    args(18).Value = lEntidad.ccodcli
    '    args(19) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
    '    args(19).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value,lEntidad.cnumcom)
    '    args(20) = New SqlParameter("@cnumlin", SqlDbType.VarChar)
    '    args(20).Value = IIf(lEntidad.cnumlin = Nothing, DBNull.Value,lEntidad.cnumlin)

    '    Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    'End Function
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

        Dim lEntidad As cntamov
        Dim lID As Long
        lEntidad = aEntidad

        'If lEntidad.cnumlin =  0 _
        '    Or lEntidad.cnumlin = Nothing Then 

        '    lID = Me.ObtenerID(lEntidad)

        '    If lID = -1 Then Return -1

        '    lEntidad.cnumlin = lID

        '    Return Agregar(lEntidad)

        'End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntamov ")
        strSQL.Append(" SET ccodsec = @ccodsec, ")
        strSQL.Append(" ffondos = @ffondos, ")
        strSQL.Append(" ccodcta = @ccodcta, ")
        strSQL.Append(" cclase = @cclase, ")
        strSQL.Append(" cflc = @cflc, ")
        strSQL.Append(" nfln = @nfln, ")
        strSQL.Append(" dfeccnt = @dfeccnt, ")
        strSQL.Append(" cconcepto = @cconcepto, ")
        strSQL.Append(" cpoliza = @cpoliza, ")
        strSQL.Append(" ccodofi = @ccodofi, ")
        strSQL.Append(" cnumpol = @cnumpol, ")
        strSQL.Append(" ccodreg = @ccodreg, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" ccodusu1 = @ccodusu1, ")
        strSQL.Append(" ccodcli = @ccodcli ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")
        'strSQL.Append(" AND cnumlin = @cnumlin ") 

        Dim args(21) As SqlParameter
        args(0) = New SqlParameter("@ccodsec", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodsec
        args(1) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(1).Value = lEntidad.ffondos
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodcta
        args(3) = New SqlParameter("@cclase", SqlDbType.VarChar)
        args(3).Value = lEntidad.cclase
        args(4) = New SqlParameter("@ndebe", SqlDbType.Decimal)
        args(4).Value = lEntidad.ndebe
        args(5) = New SqlParameter("@nhaber", SqlDbType.Decimal)
        args(5).Value = lEntidad.nhaber
        args(6) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(6).Value = lEntidad.cflc
        args(7) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(7).Value = lEntidad.nfln
        args(8) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(8).Value = lEntidad.cnumdoc
        args(9) = New SqlParameter("@dfeccnt", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfeccnt
        args(10) = New SqlParameter("@ccodpres", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodpres
        args(11) = New SqlParameter("@cconcepto", SqlDbType.VarChar)
        args(11).Value = lEntidad.cconcepto
        args(12) = New SqlParameter("@cpoliza", SqlDbType.VarChar)
        args(12).Value = lEntidad.cpoliza
        args(13) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodofi
        args(14) = New SqlParameter("@cnumpol", SqlDbType.VarChar)
        args(14).Value = lEntidad.cnumpol
        args(15) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodreg
        args(16) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(16).Value = lEntidad.dfecmod
        args(17) = New SqlParameter("@ccodusu1", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodusu1
        args(18) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodcli
        args(19) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(19).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(20) = New SqlParameter("@cnumlin", SqlDbType.VarChar)
        args(20).Value = IIf(lEntidad.cnumlin = Nothing, DBNull.Value, lEntidad.cnumlin)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function Actualizar_cierre(ByVal aEntidad As entidadBase, ByVal lcantnumcom As String) As Integer

        Dim lEntidad As cntamov
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntamov ")
        strSQL.Append(" SET cnumcom = @cnumcom ")
        strSQL.Append(" WHERE cnumcom = @lcantnumcom")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(1) = New SqlParameter("@lcantnumcom", SqlDbType.VarChar)
        args(1).Value = lcantnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cntamov ")
        strSQL.Append(" ( ccodsec, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" cnumcom, ")
        strSQL.Append(" cnumlin, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" cclase, ")
        strSQL.Append(" ndebe, ")
        strSQL.Append(" nhaber, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" dfeccnt, ")
        strSQL.Append(" ccodpres, ")
        strSQL.Append(" cconcepto, ")
        strSQL.Append(" cpoliza, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" cnumpol, ")
        strSQL.Append(" ccodreg, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu1, ")
        strSQL.Append(" ccodcli, cnumrec, corden) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodsec, ")
        strSQL.Append(" @ffondos, ")
        strSQL.Append(" @cnumcom, ")
        strSQL.Append(" @cnumlin, ")
        strSQL.Append(" @ccodcta, ")
        strSQL.Append(" @cclase, ")
        strSQL.Append(" @ndebe, ")
        strSQL.Append(" @nhaber, ")
        strSQL.Append(" @cflc, ")
        strSQL.Append(" @nfln, ")
        strSQL.Append(" @cnumdoc, ")
        strSQL.Append(" @dfeccnt, ")
        strSQL.Append(" @ccodpres, ")
        strSQL.Append(" @cconcepto, ")
        strSQL.Append(" @cpoliza, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @cnumpol, ")
        strSQL.Append(" @ccodreg, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @ccodusu1, ")
        strSQL.Append(" @ccodcli, @cnumrec, @corden) ")

        Dim args(23) As SqlParameter
        args(0) = New SqlParameter("@ccodsec", SqlDbType.Char)
        args(0).Value = lEntidad.ccodsec
        args(1) = New SqlParameter("@ffondos", SqlDbType.Char)
        args(1).Value = lEntidad.ffondos
        args(2) = New SqlParameter("@cnumcom", SqlDbType.Char)
        args(2).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(3) = New SqlParameter("@cnumlin", SqlDbType.Decimal)
        args(3).Value = IIf(lEntidad.cnumlin = Nothing, DBNull.Value, lEntidad.cnumlin)
        args(4) = New SqlParameter("@ccodcta", SqlDbType.Char)
        args(4).Value = lEntidad.ccodcta
        args(5) = New SqlParameter("@cclase", SqlDbType.Char)
        args(5).Value = lEntidad.cclase
        args(6) = New SqlParameter("@ndebe", SqlDbType.Decimal)
        args(6).Value = lEntidad.ndebe
        args(7) = New SqlParameter("@nhaber", SqlDbType.Decimal)
        args(7).Value = lEntidad.nhaber
        args(8) = New SqlParameter("@cflc", SqlDbType.Char)
        args(8).Value = lEntidad.cflc
        args(9) = New SqlParameter("@nfln", SqlDbType.Decimal)
        args(9).Value = lEntidad.nfln
        args(10) = New SqlParameter("@cnumdoc", SqlDbType.Char)
        args(10).Value = lEntidad.cnumdoc
        args(11) = New SqlParameter("@dfeccnt", SqlDbType.DateTime)
        args(11).Value = lEntidad.dfeccnt
        args(12) = New SqlParameter("@ccodpres", SqlDbType.Char)
        args(12).Value = lEntidad.ccodpres
        args(13) = New SqlParameter("@cconcepto", SqlDbType.VarChar)
        args(13).Value = lEntidad.cconcepto
        args(14) = New SqlParameter("@cpoliza", SqlDbType.VarChar)
        args(14).Value = lEntidad.cpoliza
        args(15) = New SqlParameter("@ccodofi", SqlDbType.Char)
        args(15).Value = lEntidad.ccodofi
        args(16) = New SqlParameter("@cnumpol", SqlDbType.Char)
        args(16).Value = lEntidad.cnumpol
        args(17) = New SqlParameter("@ccodreg", SqlDbType.Char)
        args(17).Value = lEntidad.ccodreg
        args(18) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(18).Value = lEntidad.dfecmod
        args(19) = New SqlParameter("@ccodusu1", SqlDbType.Char)
        args(19).Value = lEntidad.ccodusu1
        args(20) = New SqlParameter("@ccodcli", SqlDbType.Char)
        args(20).Value = lEntidad.ccodcli
        args(21) = New SqlParameter("@cnumrec", SqlDbType.Char)
        args(21).Value = lEntidad.cnumrec
        args(22) = New SqlParameter("@corden", SqlDbType.Char)
        args(22).Value = lEntidad.corden

        If lEntidad.ffondos = "99" Then
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteNonQuery(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cntamov ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")
        strSQL.Append(" AND cnumlin = @cnumlin ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom
        args(1) = New SqlParameter("@cnumlin", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnumlin

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnumcom = @cnumcom ")
        strSQL.Append(" AND cnumlin = @cnumlin ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom
        args(1) = New SqlParameter("@cnumlin", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnumlin

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodsec = IIf(.Item("ccodsec") Is DBNull.Value, Nothing, .Item("ccodsec"))
                lEntidad.ffondos = IIf(.Item("ffondos") Is DBNull.Value, Nothing, .Item("ffondos"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cclase = IIf(.Item("cclase") Is DBNull.Value, Nothing, .Item("cclase"))
                lEntidad.ndebe = IIf(.Item("ndebe") Is DBNull.Value, Nothing, .Item("ndebe"))
                lEntidad.nhaber = IIf(.Item("nhaber") Is DBNull.Value, Nothing, .Item("nhaber"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
                lEntidad.cnumdoc = IIf(.Item("cnumdoc") Is DBNull.Value, Nothing, .Item("cnumdoc"))
                lEntidad.dfeccnt = IIf(.Item("dfeccnt") Is DBNull.Value, Nothing, .Item("dfeccnt"))
                lEntidad.ccodpres = IIf(.Item("ccodpres") Is DBNull.Value, Nothing, .Item("ccodpres"))
                lEntidad.cconcepto = IIf(.Item("cconcepto") Is DBNull.Value, Nothing, .Item("cconcepto"))
                lEntidad.cpoliza = IIf(.Item("cpoliza") Is DBNull.Value, Nothing, .Item("cpoliza"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.cnumpol = IIf(.Item("cnumpol") Is DBNull.Value, Nothing, .Item("cnumpol"))
                lEntidad.ccodreg = IIf(.Item("ccodreg") Is DBNull.Value, Nothing, .Item("ccodreg"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu1 = IIf(.Item("ccodusu1") Is DBNull.Value, Nothing, .Item("ccodusu1"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function


    Public Function Recuperar_cnumcom(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntamov
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
                lEntidad.ccodsec = IIf(.Item("ccodsec") Is DBNull.Value, Nothing, .Item("ccodsec"))
                lEntidad.ffondos = IIf(.Item("ffondos") Is DBNull.Value, Nothing, .Item("ffondos"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cclase = IIf(.Item("cclase") Is DBNull.Value, Nothing, .Item("cclase"))
                lEntidad.ndebe = IIf(.Item("ndebe") Is DBNull.Value, Nothing, .Item("ndebe"))
                lEntidad.nhaber = IIf(.Item("nhaber") Is DBNull.Value, Nothing, .Item("nhaber"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
                lEntidad.cnumdoc = IIf(.Item("cnumdoc") Is DBNull.Value, Nothing, .Item("cnumdoc"))
                lEntidad.dfeccnt = IIf(.Item("dfeccnt") Is DBNull.Value, Nothing, .Item("dfeccnt"))
                lEntidad.ccodpres = IIf(.Item("ccodpres") Is DBNull.Value, Nothing, .Item("ccodpres"))
                lEntidad.cconcepto = IIf(.Item("cconcepto") Is DBNull.Value, Nothing, .Item("cconcepto"))
                lEntidad.cpoliza = IIf(.Item("cpoliza") Is DBNull.Value, Nothing, .Item("cpoliza"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.cnumpol = IIf(.Item("cnumpol") Is DBNull.Value, Nothing, .Item("cnumpol"))
                lEntidad.ccodreg = IIf(.Item("ccodreg") Is DBNull.Value, Nothing, .Item("ccodreg"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu1 = IIf(.Item("ccodusu1") Is DBNull.Value, Nothing, .Item("ccodusu1"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnumlin),0) + 1 ")
        strSQL.Append(" FROM cntamov ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ByVal cnumcom As String) As listacntamov

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacntamov

        Try
            Do While dr.Read()
                Dim mEntidad As New cntamov
                mEntidad.ccodsec = IIf(dr("ccodsec") Is DBNull.Value, Nothing, dr("ccodsec"))
                mEntidad.ffondos = IIf(dr("ffondos") Is DBNull.Value, Nothing, dr("ffondos"))
                mEntidad.cnumcom = cnumcom
                mEntidad.cnumlin = IIf(dr("cnumlin") Is DBNull.Value, Nothing, dr("cnumlin"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.ndebe = IIf(dr("ndebe") Is DBNull.Value, Nothing, dr("ndebe"))
                mEntidad.nhaber = IIf(dr("nhaber") Is DBNull.Value, Nothing, dr("nhaber"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.cnumdoc = IIf(dr("cnumdoc") Is DBNull.Value, Nothing, dr("cnumdoc"))
                mEntidad.dfeccnt = IIf(dr("dfeccnt") Is DBNull.Value, Nothing, dr("dfeccnt"))
                mEntidad.ccodpres = IIf(dr("ccodpres") Is DBNull.Value, Nothing, dr("ccodpres"))
                mEntidad.cconcepto = IIf(dr("cconcepto") Is DBNull.Value, Nothing, dr("cconcepto"))
                mEntidad.cpoliza = IIf(dr("cpoliza") Is DBNull.Value, Nothing, dr("cpoliza"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cnumpol = IIf(dr("cnumpol") Is DBNull.Value, Nothing, dr("cnumpol"))
                mEntidad.ccodreg = IIf(dr("ccodreg") Is DBNull.Value, Nothing, dr("ccodreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu1 = IIf(dr("ccodusu1") Is DBNull.Value, Nothing, dr("ccodusu1"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByVal cnumcom As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", cnumcom)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal cnumcom As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", cnumcom)

        Dim tables(0) As String
        tables(0) = New String("cntamov")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodsec, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" cnumcom, ")
        strSQL.Append(" cnumlin, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" cclase, ")
        strSQL.Append(" ndebe, ")
        strSQL.Append(" nhaber, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" dfeccnt, ")
        strSQL.Append(" ccodpres, ")
        strSQL.Append(" cconcepto, ")
        strSQL.Append(" cpoliza, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" cnumpol, ")
        strSQL.Append(" ccodreg, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu1, ")
        strSQL.Append(" ccodcli ")
        strSQL.Append(" FROM cntamov ")

    End Sub

    Public Function BusquedaporCuenta(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCodpres = @cCodpres ")
        strSQL.Append(" AND cPoliza = @cpoliza ")
        strSQL.Append(" AND cNumdoc = @cNumdoc ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cCodpres", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodpres
        args(1) = New SqlParameter("@cpoliza", SqlDbType.VarChar)
        args(1).Value = lEntidad.cpoliza
        args(2) = New SqlParameter("@cNumdoc", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnumdoc


        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodsec = IIf(.Item("ccodsec") Is DBNull.Value, Nothing, .Item("ccodsec"))
                lEntidad.ffondos = IIf(.Item("ffondos") Is DBNull.Value, Nothing, .Item("ffondos"))
                lEntidad.cnumcom = IIf(.Item("cnumcom") Is DBNull.Value, Nothing, .Item("cnumcom"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cclase = IIf(.Item("cclase") Is DBNull.Value, Nothing, .Item("cclase"))
                lEntidad.ndebe = IIf(.Item("ndebe") Is DBNull.Value, Nothing, .Item("ndebe"))
                lEntidad.nhaber = IIf(.Item("nhaber") Is DBNull.Value, Nothing, .Item("nhaber"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
                lEntidad.cnumdoc = IIf(.Item("cnumdoc") Is DBNull.Value, Nothing, .Item("cnumdoc"))
                lEntidad.dfeccnt = IIf(.Item("dfeccnt") Is DBNull.Value, Nothing, .Item("dfeccnt"))
                lEntidad.ccodpres = IIf(.Item("ccodpres") Is DBNull.Value, Nothing, .Item("ccodpres"))
                lEntidad.cconcepto = IIf(.Item("cconcepto") Is DBNull.Value, Nothing, .Item("cconcepto"))
                lEntidad.cpoliza = IIf(.Item("cpoliza") Is DBNull.Value, Nothing, .Item("cpoliza"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.cnumpol = IIf(.Item("cnumpol") Is DBNull.Value, Nothing, .Item("cnumpol"))
                lEntidad.ccodreg = IIf(.Item("ccodreg") Is DBNull.Value, Nothing, .Item("ccodreg"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu1 = IIf(.Item("ccodusu1") Is DBNull.Value, Nothing, .Item("ccodusu1"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function
    'fran
    Public Function ObtenerDataSetPorCuenta1(ByVal cCodCta As String, ByVal dFecIni As Date, ByVal dFecFin As Date) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT CNTAMOV.ccodCta, SUM(CNTAMOV.nDebe) as nDebe, SUM(CNTAMOV.nHaber) as nHaber FROM CNTAMOV, ")
        strSQL.Append("DIARIO")
        strSQL.Append(" WHERE DIARIO.cNumCom = CNTAMOV.cNumCom and CNTAMOV.ccodcta = @ccodcta ")
        strSQL.Append("and CNTAMOV.dFecCnt >= @dFecIni and CNTAMOV.dFecCnt <= @dFecFin ")
        strSQL.Append("and cflc <>" & "'" & "X" & "'")
        strSQL.Append(" GROUP BY cCodCta ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodCta)
        args(1) = New SqlParameter("@dfecini", dFecIni)
        args(2) = New SqlParameter("@dfecfin", dFecFin)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerlistaConsCtas(ByVal dFecIni As Date, ByVal dFecFin As Date, ByVal ccodigo As String, ByVal ccadena As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT CNTAMOV.ccodCta, CTBMCTA.cDescrip, SUM(CNTAMOV.nDebe) as nDebe, SUM(CNTAMOV.nHaber) as nHaber, @dFecIni as dFecIni, @dFecFin as dFecFin FROM CNTAMOV, ")
        strSQL.Append("DIARIO, CTBMCTA")
        strSQL.Append(" WHERE CTBMCTA.cCodCta = CNTAMOV.cCodCta and DIARIO.cNumCom = CNTAMOV.cNumCom ")
        strSQL.Append("and CNTAMOV.dFecCnt >= @dFecIni and CNTAMOV.dFecCnt <= @dFecFin ")
        strSQL.Append("and CNTAMOV.cflc <>" & "'" & "X" & "'")
        strSQL.Append(" GROUP BY CTBMCTA.cDescrip, CNTAMOV.cCodCta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dFecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)

        Dim ds As DataSet
        If ccodigo.Trim = "99" Then
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
            End If

        Else
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
            End If

        End If


        Return ds

    End Function
    Public Function ObtenerLibroDiarioMayor(ByVal dFecIni As Date, ByVal dFecFin As Date) As DataSet
        Dim StrSQL As New StringBuilder
        StrSQL.Append("Select CTBMCTA.cCodCta, CTBMCTA.cDescrip, CTBMCTA.nSalIni, CNTAMOV.dFecCnt, CNTAMOV.cNumCom,")
        StrSQL.Append("CNTAMOV.nDebe, CNTAMOV.nHaber, DIARIO.cGlosa, 00000000.00 as nSaldo, 00000000.00 as nSalAnt, @dFecIni as dFecini, @dfecfin as dfecfin ")
        StrSQL.Append(" FROM CTBMCTA, DIARIO, CNTAMOV WHERE ")
        StrSQL.Append(" CTBMCTA.cCodcta = CNTAMOV.cCodCta and DIARIO.cNumcom = CNTAMOV.cNumCom ")
        StrSQL.Append("and CNTAMOV.dFecCnt >= @dFecIni and CNTAMOV.dFecCnt <= @dFecFin ")
        StrSQL.Append("and CNTAMOV.cflc <>" & "'" & "X" & "'")
        StrSQL.Append(" ORDER BY CTBMCTA.cCodcta, CNTAMOV.dFecCnt ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dFecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerSaldosIni(ByVal dfecIni As Date, ByVal dFecFin As Date) As DataSet
        Dim StrSQL As New StringBuilder

        StrSQL.Append("SELECT a.cCodCta, a.nSalIni, ")
        StrSQL.Append("(SELECT SUM(b.nDebe)  FROM CNTAMOV AS b ")
        StrSQL.Append(" WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dFecFin GROUP BY b.cCodCta)  AS nDebe,")
        StrSQL.Append(" (SELECT SUM(b.nHaber)  FROM CNTAMOV AS b  WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dFecFin")
        StrSQL.Append(" GROUP BY b.cCodCta) AS nHaber FROM CTBMCTA AS a WHERE ")
        StrSQL.Append(" cCodto =" & "'" & "D" & "'")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerLibroMayor(ByVal dFecIni As Date, ByVal dFecFin As Date) As DataSet
        Dim StrSQL As New StringBuilder

        StrSQL.Append("SELECT a.cCodCta, a.cDescrip, 00000000.00 as nSalIni, 00000000.00 as nSalFin, 00000000.00 as Diferencia, @dfecIni as dFecIni, @dfecFin as dFecFin, ")
        StrSQL.Append("(SELECT SUM(b.nDebe)  FROM CNTAMOV AS b ")
        StrSQL.Append(" WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dFecFin GROUP BY b.cCodCta  )  AS nDebe,")
        StrSQL.Append(" (SELECT SUM(b.nHaber)  FROM CNTAMOV AS b  WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dFecFin ")
        StrSQL.Append(" GROUP BY b.cCodCta ) AS nHaber FROM CTBMCTA AS a WHERE ")
        StrSQL.Append(" a.cCodto =" & "'" & "D" & "'")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dFecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds
    End Function
    Public Function ObtenerSaldosIniPorCuenta(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String) As DataSet
        Dim StrSQL As New StringBuilder

        StrSQL.Append("SELECT a.cCodCta, a.nSalIni, ")
        StrSQL.Append("(SELECT SUM(b.nDebe)  FROM CNTAMOV AS b ")
        StrSQL.Append(" WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dFecFin )  AS nDebe,")
        StrSQL.Append(" (SELECT SUM(b.nHaber)  FROM CNTAMOV AS b  WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dFecFin")
        StrSQL.Append(" ) AS nHaber FROM CTBMCTA AS a WHERE ")
        StrSQL.Append(" cCodto =" & "'" & "D" & "'")
        StrSQL.Append(" and cCodCta = @pcCodCta")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@pcCodCta", pcCodCta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerMov(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal dfeciniper As Date, ByVal dfecfinper As Date, ByVal pccodcta As String) As DataSet
        Dim StrSQL As New StringBuilder

        StrSQL.Append("SELECT a.cCodCta,")
        StrSQL.Append("(SELECT SUM(b.nDebe)  FROM CNTAMOV AS b ")
        StrSQL.Append("WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dfecfin )")
        StrSQL.Append(" AS nDebeac,")
        StrSQL.Append("(SELECT SUM(b.nHaber)  FROM CNTAMOV AS b  WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIni and b.dFecCnt <= @dfecfin)")
        StrSQL.Append(" AS nHaberac,")
        StrSQL.Append("(SELECT SUM(b.nDebe)  FROM CNTAMOV AS b ")
        StrSQL.Append("WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIniper and b.dFecCnt <= @dfecfinper )")
        StrSQL.Append("AS ncargos,")
        StrSQL.Append("(SELECT SUM(b.nHaber)  FROM CNTAMOV AS b  WHERE a.cCodCta = b.cCodCta and b.dFecCnt >= @dfecIniper and b.dFecCnt <= @dfecfinper)")
        StrSQL.Append("AS nabonos ")
        StrSQL.Append("FROM CTBMCTA AS a  ")
        StrSQL.Append(" WHERE a.cCodto =" & "'" & "D" & "'")
        StrSQL.Append(" and a.cCodcta=@pccodcta ")
        StrSQL.Append(" group by a.cCodcta, a.cCtaSup Order by a.cCodcta ")



        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@dfeciniper", dfeciniper)
        args(3) = New SqlParameter("@dfecfinper", dfecfinper)
        args(4) = New SqlParameter("@pccodcta", pccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds
    End Function

    Public Function CuentaSuperior(ByVal pcCodcta As String) As DataSet

        Dim StrSQL As New StringBuilder
        StrSQL.Append(" SELECT * ")
        StrSQL.Append(" FROM CTBMCTA  ")
        StrSQL.Append(" WHERE CTBMCTA.cCtaSup = @pcCodCta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodcta", pcCodcta)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        Return ds
    End Function
    Public Function Actualizar_partida(ByVal lcnumcom As String, ByVal lcantnumcom As String) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntamov ")
        strSQL.Append(" SET cnumcom = @lcnumcom ")
        strSQL.Append(" WHERE cnumcom = @lcantnumcom")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcnumcom", SqlDbType.VarChar)
        args(0).Value = lcnumcom
        args(1) = New SqlParameter("@lcantnumcom", SqlDbType.VarChar)
        args(1).Value = lcantnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerSaldosPorCuenta(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet

        Dim StrSQL As New StringBuilder

        '***************************  verifica si entrara al cierre, tomara dfecfin como fecha que define año de cierre
        Dim cierre As String
        Dim cnnstr1 As String
        Dim cnn1 As ConnectionState
        Dim cnnstr2 As String
        cierre = "D" & dFecFin.Year.ToString.Trim
        cnnstr1 = "server=" & lcnomser & ";" & "database=" & cierre & ";" & "uid=sa; pwd=sa2007"

        Dim myConn1 As SqlClient.SqlConnection = New SqlConnection(cnnstr1)
        cnnstr2 = Me.cnnStr
        'Try
        'myConn1.Open()
        'cnn1 = myConn1.State
        'cnnstr2 = cnnstr1
        'myConn1.Close()

        'Catch ex As Exception
        cnn1 = myConn1.State
        If cnn1 = ConnectionState.Broken Or cnn1 = ConnectionState.Closed Or cnn1 = ConnectionState.Fetching Then
            cnnstr2 = Me.cnnStr
            cierre = "FUNDAMICRO"
            myConn1.Close()
        End If
        'End Try
        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccodofi = "000" And lcfuente = "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, sum(ctbmcta.nsalini) as nsalini ")
            StrSQL.Append("FROM ctbmcta, diario, cntamov ")
            StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(ctbmcta.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '")
        ElseIf lccodofi <> "000" And lcfuente = "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, sum(ctbmcta.nsalini) as nsalini ")
            StrSQL.Append("FROM ctbmcta, diario, cntamov ")
            StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(ctbmcta.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
        ElseIf lccodofi = "000" And lcfuente <> "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, sum(ctbmcta.nsalini) as nsalini ")
            StrSQL.Append("FROM ctbmcta, diario, cntamov ")
            StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(ctbmcta.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente")
        Else
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, sum(ctbmcta.nsalini) as nsalini ")
            StrSQL.Append("FROM ctbmcta, diario, cntamov ")
            StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(ctbmcta.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente")
        End If


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@pcCodCta", pcCodCta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lccodofi", lccodofi)
        args(5) = New SqlParameter("@lcfuente", lcfuente)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(cnnstr2, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerSaldosPorCuenta1(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet

        Dim StrSQL As New StringBuilder

        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccodofi = "000" And lcfuente = "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
        ElseIf lccodofi <> "000" And lcfuente = "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
        ElseIf lccodofi = "000" And lcfuente <> "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
        Else
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
        End If


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@pcCodCta", pcCodCta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lccodofi", lccodofi)
        args(5) = New SqlParameter("@lcfuente", lcfuente)


        Dim ds As DataSet
        If lcfuente.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
        End If

        Return ds

    End Function
    Public Function ObtenerSaldosPorCuenta3(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
        'saldos antes de 
        Dim StrSQL As New StringBuilder

        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If lccodofi = "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cflc = ' '  and left(cntamov.cpoliza,2) <>'PA'  group by cntamov.ccodcta")

            ElseIf lccodofi = "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")

            ElseIf lccodofi <> "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
            Else
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '  and left(cntamov.cpoliza,2) <>'PA' ")
                StrSQL.Append("  group by cntamov.ccodcta")
            End If

        Else
            If lccodofi = "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")


            ElseIf lccodofi = "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")

            ElseIf lccodofi <> "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
            Else
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append("  group by cntamov.ccodcta")
            End If
        End If


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@pcCodCta", pcCodCta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lccodofi", lccodofi)
        args(5) = New SqlParameter("@lcfuente", lcfuente)


        Dim ds As DataSet

        'If lcfuente = "99" Then
        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, StrSQL.ToString(), args, 0)
        End If

        'Else
        'If ccadena.Trim = "" Then
        '    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
        'Else
        '    ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
        'End If

        'End If
        Return ds

        ''saldos antes de 
        'Dim StrSQL As New StringBuilder

        ''****************************  finaliza verificacion de cadena de conexion ************************
        'If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
        '    If lccodofi = "000" And lcfuente = "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
        '    ElseIf lccodofi <> "000" And lcfuente = "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
        '        StrSQL.Append(" and cntamov.cflc = ' '  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")

        '    ElseIf lccodofi = "000" And lcfuente <> "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' '")
        '        StrSQL.Append(" and cntamov.ffondos = @lcfuente  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")

        '    ElseIf lccodofi <> "000" And lcfuente <> "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' '")
        '        StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
        '        StrSQL.Append(" and cntamov.ffondos = @lcfuente and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
        '    Else
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) <>'PA' ")
        '        StrSQL.Append("  group by cntamov.ccodcta")
        '    End If

        'Else
        '    If lccodofi = "000" And lcfuente = "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cpoliza <> 'PL' ")
        '        StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
        '    ElseIf lccodofi <> "000" And lcfuente = "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
        '        StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")

        '        StrSQL.Append(" and cntamov.cpoliza <> 'PL' ")
        '    ElseIf lccodofi = "000" And lcfuente <> "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' '")
        '        StrSQL.Append(" and cntamov.cpoliza <> 'PL' ")
        '        StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")

        '    ElseIf lccodofi <> "000" And lcfuente <> "00" Then
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' '")
        '        StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
        '        StrSQL.Append(" and cntamov.cpoliza <> 'PL' ")
        '        StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
        '    Else
        '        StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
        '        StrSQL.Append("FROM  diario, cntamov ")
        '        StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt < @dFecFin ")
        '        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
        '        StrSQL.Append(" and cntamov.cflc = ' '")
        '        StrSQL.Append(" and cntamov.cpoliza <> 'PL' ")
        '        StrSQL.Append("  group by cntamov.ccodcta")
        '    End If
        'End If


        'Dim args(5) As SqlParameter
        'args(0) = New SqlParameter("@dfecini", dfecIni)
        'args(1) = New SqlParameter("@dfecfin", dFecFin)
        'args(2) = New SqlParameter("@pcCodCta", pcCodCta)
        'args(3) = New SqlParameter("@lnnivel", lnnivel)
        'args(4) = New SqlParameter("@lccodofi", lccodofi)
        'args(5) = New SqlParameter("@lcfuente", lcfuente)


        'Dim ds As DataSet

        'If lcfuente = "99" Then
        '    If ccadena.Trim = "" Then
        '        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        '    Else
        '        ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
        '    End If

        'Else
        '    If ccadena.Trim = "" Then
        '        ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
        '    Else
        '        ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
        '    End If

        'End If
        'Return ds

    End Function
    Public Function ObtenerSaldosPorCuenta4(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
        'saldos antes de 
        Dim StrSQL As New StringBuilder

        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If lccodofi = "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cflc = ' '  and left(cntamov.cpoliza,2) <>'PA'  group by cntamov.ccodcta")

            ElseIf lccodofi = "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
            Else
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  and left(cntamov.cpoliza,2) <>'PA' group by cntamov.ccodcta")
            End If

        Else
            If lccodofi = "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")

            ElseIf lccodofi = "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
            Else
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cpoliza <> 'FC'  ")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
            End If

        End If


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@pcCodCta", pcCodCta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lccodofi", lccodofi)
        args(5) = New SqlParameter("@lcfuente", lcfuente)


        Dim ds As DataSet
        'If lcfuente = "99" Then
        If ccadena.Trim = "" Then
            ds = Me.ExecuteDataSet(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args, 0)
        Else
            ds = Me.ExecuteDataSet(ccadena, CommandType.Text, StrSQL.ToString(), args, 0)
        End If

        'Else
        'If ccadena.Trim = "" Then
        '    ds = Me.ExecuteDataSet(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args, 0)
        'Else
        '    ds = Me.ExecuteDataSet(ccadena, CommandType.Text, StrSQL.ToString(), args, 0)
        'End If

        'End If

        Return ds

    End Function
    Public Function ObtenerSaldosPorCuenta5(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet
        'saldos antes de 
        Dim StrSQL As New StringBuilder

        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccodofi = "000" And lcfuente = "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
        ElseIf lccodofi <> "000" And lcfuente = "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
            StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")

        ElseIf lccodofi = "000" And lcfuente <> "00" Then
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
        Else
            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
            StrSQL.Append("FROM  diario, cntamov ")
            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
            StrSQL.Append(" and cntamov.cflc = ' '")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
        End If


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lccodofi", lccodofi)
        args(3) = New SqlParameter("@lcfuente", lcfuente)


        Dim ds As DataSet
        If lcfuente.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
        End If

        Return ds

    End Function
    'esta rutina es para cierres mensuales, recibo como parametro el fondo y oficina
    Public Function Obtener_Saldos_fondos_oficina(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lcfondo As String, ByVal lcoficina As String) As DataSet

        Dim StrSQL As New StringBuilder

        StrSQL.Append("SELECT cntamov.ccodcta, sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, sum(ctbmcta.nsalini) as nsalini ")
        StrSQL.Append("FROM ctbmcta, diario, cntamov ")
        StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
        StrSQL.Append(" and ltrim(cntamov.ffondos) = @lcfondo")
        StrSQL.Append(" and ltrim(cntamov.ccodofi) = @lcoficina")
        StrSQL.Append(" and cntamov.cflc = ' '")
        StrSQL.Append(" group by cntamov.ccodcta")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lcfondo", lcfondo)
        args(3) = New SqlParameter("@lcoficina", lcoficina)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function



    Public Function Obtenerlistado_Partidas(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet
        Dim StrSQL As New StringBuilder
        '***  verifica si entrara al cierre, tomara dfecfin como fecha que define año de cierre ******
        Dim cierre As String
        Dim cnnstr1 As String
        Dim cnn1 As ConnectionState
        Dim cnnstr2 As String
        Dim cierre2 As String
        cierre = "D" & dFecFin.Year.ToString.Trim
        cnnstr1 = "server=" & lcnomser & ";" & "database=" & cierre & ";" & "uid=sa; pwd=SA2009$"

        Dim myConn1 As SqlClient.SqlConnection = New SqlConnection(cnnstr1)
        cnnstr2 = Me.cnnStr
        Try
            myConn1.Open()
            cnn1 = myConn1.State
            cnnstr2 = cnnstr1
            myConn1.Close()

        Catch ex As Exception
            cnn1 = myConn1.State
            If cnn1 = ConnectionState.Broken Or cnn1 = ConnectionState.Closed Or cnn1 = ConnectionState.Fetching Then
                cnnstr2 = Me.cnnStr
                cierre = "FUNDAMICRO"
                myConn1.Close()
            End If
        End Try

        '****************************  finaliza verificacion de cadena de conexion ************************
        Dim ctbmcta1 As String
        Dim cntamov1 As String
        Dim diario1 As String

        ctbmcta1 = cierre & ".dbo." & "ctbmcta"
        cntamov1 = cierre & ".dbo." & "cntamov"
        diario1 = cierre & ".dbo." & "diario"


        'llama al procedimiento almacenado que ejecuta los comandos
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As New DataSet

        Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
        Dim oCommand As SqlClient.SqlCommand = _
                New SqlClient.SqlCommand("LIBRO_DIARIO", oConexion)
        Dim oParameter As SqlClient.SqlParameter
        oParameter = oCommand.Parameters.Add("@dfecini1", SqlDbType.DateTime)
        oParameter.Value = dfecIni
        oParameter = oCommand.Parameters.Add("@dfecfin1", SqlDbType.DateTime)
        oParameter.Value = dFecFin
        oParameter = oCommand.Parameters.Add("@ctbmcta1", SqlDbType.VarChar)
        oParameter.Value = ctbmcta1
        oParameter = oCommand.Parameters.Add("@cntamov1", SqlDbType.VarChar)
        oParameter.Value = cntamov1
        oParameter = oCommand.Parameters.Add("@diario1", SqlDbType.VarChar)
        oParameter.Value = diario1
        oParameter = oCommand.Parameters.Add("@lcregional1", SqlDbType.VarChar)
        oParameter.Value = "000"
        oParameter = oCommand.Parameters.Add("@lcoficina1", SqlDbType.VarChar)
        oParameter.Value = lccodofi
        oParameter = oCommand.Parameters.Add("@lcfondo1", SqlDbType.VarChar)
        oParameter.Value = lcfuente

        oCommand.CommandType = CommandType.StoredProcedure
        oConexion.Open()
        oDa = New SqlClient.SqlDataAdapter(oCommand)

        oDa.Fill(oDs)

        Return oDs

    End Function


    'funcion para mostrar estado de cuenta
    Public Function movimientos_por_cuenta(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String) As DataSet

        '***************************  verifica si entrara al cierre, tomara dfecfin como fecha que define año de cierre
        Dim cierre As String
        Dim cnnstr1 As String
        Dim cnn1 As ConnectionState
        Dim cnnstr2 As String
        cierre = "D" & dFecFin.Year.ToString.Trim
        cnnstr1 = "server=" & lcnomser & ";" & "database=" & cierre & ";" & "uid=sa; pwd=SA2009$"

        Dim myConn1 As SqlClient.SqlConnection = New SqlConnection(cnnstr1)
        cnnstr2 = Me.cnnStr
        Try
            myConn1.Open()
            cnn1 = myConn1.State
            cnnstr2 = cnnstr1
            myConn1.Close()

        Catch ex As Exception
            cnn1 = myConn1.State
            If cnn1 = ConnectionState.Broken Or cnn1 = ConnectionState.Closed Or cnn1 = ConnectionState.Fetching Then
                cnnstr2 = Me.cnnStr
                myConn1.Close()
            End If
        End Try
        '****************************  finaliza verificacion de cadena de conexion ************************


        Dim StrSQL As New StringBuilder
        StrSQL.Append("SELECT ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, cntamov.ndebe, cntamov.nhaber, cntamov.dfeccnt, cntamov.cnumcom, cntamov.cnumdoc, diario.cglosa, 0000000000000.00 as nsalfin ")
        StrSQL.Append("FROM ctbmcta, diario, cntamov ")
        StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
        StrSQL.Append(" and cntamov.cflc =' ' ")
        StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @lccodcta")
        StrSQL.Append(" order by cntamov.dfeccnt,cntamov.cnumcom, cntamov.cnumdoc")


        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lccodcta", lccodcta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(cnnstr2, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerAuxiliar(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal lccadena As String) As DataSet
        'saldos antes de 
        Dim StrSQL As New StringBuilder

        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccodofi = "000" And lcfuente = "00" Then
            StrSQL.Append("select cntamov.cnumrec, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append(" day(cntamov.dfeccnt) as dia, cntamov.cnumcom, diario.cglosa, cntamov.ndebe, ")
            StrSQL.Append("cntamov.ccodpres, cntamov.cpoliza, cntamov.cnumdoc, cntamov.ffondos, tabttab.cdescri, cntamov.dfeccnt, ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi from FUNDEA.dbo.ctbmcta, diario, cntamov, FUNDEA.dbo.tabttab ")
            StrSQL.Append(" where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom and cntamov.cflc = ' ' ")
            StrSQL.Append(" and cntamov.ccodcta=@lccodcta ")
            StrSQL.Append(" and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin  ")
            StrSQL.Append(" and tabttab.ctipreg ='1' and tabttab.ccodtab ='033' and left(cntamov.ffondos,2) = left(tabttab.ccodigo,2) ")
            StrSQL.Append(" and left(cntamov.cpoliza,2) <>'PA' ")
            StrSQL.Append(" order by cntamov.ccodcta, cntamov.dfeccnt, cntamov.cnumdoc ")

        ElseIf lccodofi <> "000" And lcfuente = "00" Then
            StrSQL.Append("select cntamov.cnumrec,cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append(" day(cntamov.dfeccnt) as dia, cntamov.cnumcom, diario.cglosa, cntamov.ndebe, ")
            StrSQL.Append("cntamov.ccodpres, cntamov.cpoliza, cntamov.cnumdoc, cntamov.ffondos, tabttab.cdescri, cntamov.dfeccnt, ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi from FUNDEA.dbo.ctbmcta, diario, cntamov, FUNDEA.dbo.tabttab ")
            StrSQL.Append(" where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom and cntamov.cflc = ' ' ")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
            StrSQL.Append(" and cntamov.ccodcta=@lccodcta ")
            StrSQL.Append(" and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin  ")
            StrSQL.Append(" and tabttab.ctipreg ='1' and tabttab.ccodtab ='033' and left(cntamov.ffondos,2) = left(tabttab.ccodigo,2) ")
            StrSQL.Append(" and left(cntamov.cpoliza,2) <>'PA' ")
            StrSQL.Append(" order by cntamov.ccodcta, cntamov.dfeccnt, cntamov.cnumdoc ")

        ElseIf lccodofi = "000" And lcfuente <> "00" Then
            StrSQL.Append("select cntamov.cnumrec,cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append(" day(cntamov.dfeccnt) as dia, cntamov.cnumcom, diario.cglosa, cntamov.ndebe, ")
            StrSQL.Append("cntamov.ccodpres, cntamov.cpoliza, cntamov.cnumdoc,  cntamov.ffondos, tabttab.cdescri, cntamov.dfeccnt,")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi from FUNDEA.dbo.ctbmcta, diario, cntamov, FUNDEA.dbo.tabttab ")
            StrSQL.Append(" where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom and cntamov.cflc = ' ' ")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente ")
            StrSQL.Append(" and cntamov.ccodcta=@lccodcta ")
            StrSQL.Append(" and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin  ")
            StrSQL.Append(" and tabttab.ctipreg ='1' and tabttab.ccodtab ='033' and left(cntamov.ffondos,2) = left(tabttab.ccodigo,2) ")
            StrSQL.Append(" and left(cntamov.cpoliza,2) <>'PA' ")
            StrSQL.Append(" order by cntamov.ccodcta, cntamov.dfeccnt, cntamov.cnumdoc ")

        Else
            StrSQL.Append("select cntamov.cnumrec,cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append(" day(cntamov.dfeccnt) as dia, cntamov.cnumcom, diario.cglosa, cntamov.ndebe, ")
            StrSQL.Append("cntamov.ccodpres, cntamov.cpoliza, cntamov.cnumdoc,  cntamov.ffondos, tabttab.cdescri,cntamov.dfeccnt, ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi from FUNDEA.dbo.ctbmcta, diario, cntamov, FUNDEA.dbo.tabttab ")
            StrSQL.Append(" where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom and cntamov.cflc = ' ' ")
            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente ")
            StrSQL.Append(" and cntamov.ccodcta=@lccodcta ")
            StrSQL.Append(" and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin  ")
            StrSQL.Append(" and tabttab.ctipreg ='1' and tabttab.ccodtab ='033' and left(cntamov.ffondos,2) = left(tabttab.ccodigo,2) ")
            StrSQL.Append(" and left(cntamov.cpoliza,2) <>'PA' ")
            StrSQL.Append(" order by cntamov.ccodcta, cntamov.dfeccnt, cntamov.cnumdoc ")

        End If


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lccodofi", lccodofi)
        args(3) = New SqlParameter("@lcfuente", lcfuente)
        args(4) = New SqlParameter("@lccodcta", lccodcta)



        Dim ds As DataSet
        If lccadena.Trim = "" Then
            ds = Me.ExecuteDataSet(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args, 0)
        Else
            ds = Me.ExecuteDataSet(lccadena, CommandType.Text, StrSQL.ToString(), args, 0)
        End If

        '        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        Return ds

    End Function
    Public Function sumasporcuenta(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lcfuente As String, ByVal ccadena As String) As DataSet

        '***************************  verifica si entrara al cierre, tomara dfecfin como fecha que define año de cierre
        'Dim cierre As String
        'Dim cnnstr1 As String
        'Dim cnn1 As ConnectionState
        'Dim cnnstr2 As String
        'cierre = "D" & dFecFin.Year.ToString.Trim
        'cnnstr1 = "server=" & lcnomser & ";" & "database=" & cierre & ";" & "uid=sa; pwd=sa2007"

        'Dim myConn1 As SqlClient.SqlConnection = New SqlConnection(cnnstr1)
        'cnnstr2 = Me.cnnStr
        'Try
        '    myConn1.Open()
        '    cnn1 = myConn1.State
        '    cnnstr2 = cnnstr1
        '    myConn1.Close()

        'Catch ex As Exception
        '    cnn1 = myConn1.State
        '    If cnn1 = ConnectionState.Broken Or cnn1 = ConnectionState.Closed Or cnn1 = ConnectionState.Fetching Then
        '        cnnstr2 = Me.cnnStr
        '        myConn1.Close()
        '    End If
        'End Try
        '****************************  finaliza verificacion de cadena de conexion ************************


        Dim StrSQL As New StringBuilder
        If lcfuente = "00" Then
            StrSQL.Append("select left(cntamov.ccodcta , @lnnivel) as ccodcta,  cntamov.dfeccnt,  ")
            StrSQL.Append("00000000.00 as nsalant,  ")
            StrSQL.Append("sum(cntamov.ndebe) as ncargos,  ")
            StrSQL.Append(" sum(cntamov.nhaber) as nabonos, ")
            StrSQL.Append(" 00000000.00 as nsalact  ")
            StrSQL.Append(" from ctbmcta  ")
            StrSQL.Append(" inner join cntamov on ctbmcta.ccodcta = cntamov.ccodcta    ")
            StrSQL.Append(" where dfeccnt>=@dfecIni and dfeccnt<=@dfecfin and cntamov.cflc=' '  ")
            StrSQL.Append(" and left(cntamov.ccodcta, @lnnivel) = @lccodcta ")
            StrSQL.Append(" group by left(cntamov.ccodcta, @lnnivel), cntamov.dfeccnt ")
            StrSQL.Append(" order by left(cntamov.ccodcta, @lnnivel), cntamov.dfeccnt ")
        Else
            StrSQL.Append("select left(cntamov.ccodcta , @lnnivel) as ccodcta,  cntamov.dfeccnt,  ")
            StrSQL.Append("00000000.00 as nsalant,  ")
            StrSQL.Append("sum(cntamov.ndebe) as ncargos,  ")
            StrSQL.Append(" sum(cntamov.nhaber) as nabonos, ")
            StrSQL.Append(" 00000000.00 as nsalact  ")
            StrSQL.Append(" from ctbmcta  ")
            StrSQL.Append(" inner join cntamov on ctbmcta.ccodcta = cntamov.ccodcta    ")
            StrSQL.Append(" where dfeccnt>=@dfecIni and dfeccnt<=@dfecfin and cntamov.cflc=' '  ")
            StrSQL.Append(" and left(cntamov.ccodcta, @lnnivel) = @lccodcta ")
            StrSQL.Append(" and cntamov.ffondos = @lcfuente ")
            StrSQL.Append(" group by left(cntamov.ccodcta, @lnnivel), cntamov.dfeccnt ")
            StrSQL.Append(" order by left(cntamov.ccodcta, @lnnivel), cntamov.dfeccnt ")
        End If



        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lccodcta", lccodcta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lcfuente", lcfuente)

        Dim ds As DataSet

        If lcfuente = "99" Then
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
            End If

        Else
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
            End If

        End If


        Return ds

    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function Cuentaslibro(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodcta1 As String, ByVal lcfuente As String, ByVal lccodofi As String, ByVal ccadena As String) As DataSet

        ''***************************  verifica si entrara al cierre, tomara dfecfin como fecha que define año de cierre
        'Dim cierre As String
        'Dim cnnstr1 As String
        'Dim cnn1 As ConnectionState
        'Dim cnnstr2 As String
        'cierre = "D" & dFecFin.Year.ToString.Trim
        'cnnstr1 = "server=" & lcnomser & ";" & "database=" & cierre & ";" & "uid=sa; pwd=sa2007"

        'Dim myConn1 As SqlClient.SqlConnection = New SqlConnection(cnnstr1)
        'cnnstr2 = Me.cnnStr
        'Try
        '    myConn1.Open()
        '    cnn1 = myConn1.State
        '    cnnstr2 = cnnstr1
        '    myConn1.Close()

        'Catch ex As Exception
        '    cnn1 = myConn1.State
        '    If cnn1 = ConnectionState.Broken Or cnn1 = ConnectionState.Closed Or cnn1 = ConnectionState.Fetching Then
        '        cnnstr2 = Me.cnnStr
        '        myConn1.Close()
        '    End If
        'End Try
        ''****************************  finaliza verificacion de cadena de conexion ************************


        Dim StrSQL As New StringBuilder



        StrSQL.Append("select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, ctbmcta.nsalini  ")
        StrSQL.Append(" from ctbmcta ")
        If lccodcta = "*" Then
        Else
            StrSQL.Append(" where left(ctbmcta.ccodcta,@lnnivel)>= @lccodcta and left(ctbmcta.ccodcta,@lnnivel)<= @lccodcta1   ")
            StrSQL.Append(" and len(ltrim(rtrim(ctbmcta.ccodcta))) = @lnnivel ")
        End If
        StrSQL.Append(" order by ctbmcta.ccodcta ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lccodcta", lccodcta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lccodcta1", lccodcta1)

        Dim ds As DataSet
        If lcfuente = "99" Then
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
            End If

        Else
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
            End If

        End If


        Return ds

    End Function
    Public Function EliminarDetalle(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cntamov ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtieneChequeporCredito(ByVal cCodpres As String, ByVal dfecha As Date) As String
        Dim StrSQL As New StringBuilder
        StrSQL.Append("Select cnumdoc, cnumcom from cntamov ")
        StrSQL.Append("WHERE cpoliza = 'EG' and ccodpres = @cCodpres ")
        StrSQL.Append("and dfeccnt >= @dfecha and dfeccnt <= @dfecha ")
        StrSQL.Append("group by cnumdoc, cnumcom order by cnumcom desc ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodpres", SqlDbType.VarChar)
        args(0).Value = cCodpres
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Dim lcnrochq As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnumdoc")) Then
            Else
                lcnrochq = ds.Tables(0).Rows(0)("cnumdoc")
            End If
        End If

        Return lcnrochq


    End Function
    Public Function listadodepartidasConsolidadas(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String) As DataSet
        Dim StrSQL As New StringBuilder
        Dim ds As New DataSet
        If ccodofi = "000" And cfuente = "00" Then 'todo
            StrSQL.Append(" select diario.ccodofi as coficina,tabtofi.cnomofi, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  diario.cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov , tabtofi ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin and diario.ccodofi = tabtofi.ccodofi ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")
        ElseIf ccodofi <> "000" And cfuente <> "00" Then 'oficina y fuente elegidas
            StrSQL.Append(" select diario.ccodofi as coficina,tabtofi.cnomofi,ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  diario.cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov , tabtofi ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append(" and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @cfuente and diario.ccodofi = tabtofi.ccodofi ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")

        ElseIf ccodofi = "000" And cfuente <> "00" Then ' todas las oficina solo una fuente
            StrSQL.Append(" select diario.ccodofi as coficina,tabtofi.cnomofi, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  diario.cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov , tabtofi ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append(" and cntamov.ffondos = @cfuente and diario.ccodofi = tabtofi.ccodofi ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")

        ElseIf ccodofi <> "000" And cfuente = "00" Then 'solo una oficina , todas las fuentes
            StrSQL.Append(" select diario.ccodofi as coficina,tabtofi.cnomofi, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  diario.cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov , tabtofi ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append(" and cntamov.ccodofi = @ccodofi and diario.ccodofi = tabtofi.ccodofi  ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")

        End If


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@cfuente", cfuente)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        Return ds
    End Function

    Public Function listadodepartidas(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String) As DataSet
        Dim StrSQL As New StringBuilder
        Dim ds As New DataSet
        If ccodofi = "000" And cfuente = "00" Then 'todo
            StrSQL.Append(" select tabtofi.cnomofi, diario.ccodofi as coficina, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  cntamov.cconcepto as cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov, tabtofi  ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")
        ElseIf ccodofi <> "000" And cfuente <> "00" Then 'oficina y fuente elegidas
            StrSQL.Append(" select tabtofi.cnomofi,diario.ccodofi as coficina, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  cntamov.cconcepto as cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov, tabtofi  ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append(" and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @cfuente ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")

        ElseIf ccodofi = "000" And cfuente <> "00" Then ' todas las oficina solo una fuente
            StrSQL.Append(" select tabtofi.cnomofi,diario.ccodofi as coficina, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  cntamov.cconcepto as cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov, tabtofi  ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append(" and cntamov.ffondos = @cfuente ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")

        ElseIf ccodofi <> "000" And cfuente = "00" Then 'solo una oficina , todas las fuentes
            StrSQL.Append(" select tabtofi.cnomofi,diario.ccodofi as coficina, ctbmcta.cdescrip, cntamov.dfeccnt, cntamov.cnumcom, cntamov.ccodcta, ctbmcta.cdescrip, ctbmcta.nsalini, 00000000.00 as nmovant, ")
            StrSQL.Append("  day(cntamov.dfeccnt) as dia,  cntamov.cconcepto as cglosa, cntamov.ndebe,  ")
            StrSQL.Append(" cntamov.nhaber, cntamov.ccodofi, cntamov.ffondos, cntamov.cpoliza, cntamov.ccodusu1 from ctbmcta, diario, cntamov, tabtofi  ")
            StrSQL.Append("  where ctbmcta.ccodcta = cntamov.ccodcta and diario.cnumcom = cntamov.cnumcom ")
            StrSQL.Append("  and cntamov.cflc = ' '  ")
            StrSQL.Append(" and cntamov.dfeccnt >=@dfecini and cntamov.dfeccnt <= @dfecfin ")
            StrSQL.Append(" and cntamov.ccodofi = @ccodofi  ")
            StrSQL.Append("  order by cntamov.cnumcom, cntamov.ccodcta, cntamov.dfeccnt   ")

        End If


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@cfuente", cfuente)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)
        Return ds
    End Function

    Public Function ObtieneOtrosIngresos(ByVal cCodcli As String, ByVal cnumdoc As String) As DataSet
        Dim strSQL As New StringBuilder
        Dim ds As New DataSet
        strSQL.Append("Select * from CNTAMOV ")
        strSQL.Append("WHERE cCodpres = @cCodcli and cnumdoc = @cnumdoc and ndebe > 0  ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", cCodcli)
        args(1) = New SqlParameter("@cnumdoc", cnumdoc)


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    Public Function ValidaNumeroRemesa(ByVal cCodcta As String, ByVal cnumdoc As String) As Boolean
        Dim strSQL As New StringBuilder
        Dim ds As New DataSet
        Dim lcrevertido As String = ""
        lcrevertido = "REV/" + cnumdoc.Trim
        strSQL.Append("SELECT cnumdoc FROM CNTAMOV ")
        strSQL.Append("WHERE cnumdoc = @cnumdoc or cnumdoc = @lcrevertido ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnumdoc", cnumdoc)
        args(1) = New SqlParameter("@lcrevertido", lcrevertido)

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim llvalida As Boolean = True
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim cont As Integer = 0
        cont = ds.Tables(0).Rows.Count
        If cont = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnumdoc")) Then
            Else
                'verifica si esta revertido
                Dim fila As DataRow
                Dim i As Integer = 0
                Dim lcnumdoc As String = ""
                If cont > 1 Then
                    For Each fila In ds.Tables(0).Rows
                        lcnumdoc = ds.Tables(0).Rows(i)("cnumdoc")
                        If lcnumdoc.Trim = lcrevertido.Trim Then
                            a += 1
                        Else
                            b += 1
                        End If
                        i += 1
                    Next
                    If a = b Then
                        llvalida = True
                    Else
                        llvalida = False
                    End If
                Else
                    llvalida = False
                End If

            End If
        End If
        Return llvalida
    End Function

    Public Function DataConciliar(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cpoliza As String, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        Dim ds As New DataSet

        strSQL.Append("Select cntamov.dfeccnt, cntamov.cnumdoc, sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, ")
        strSQL.Append("space(1) as cflag, 000000.00 as nvalor, max(diario.cglosa) as cConcepto, space(2) as cmes  ")
        strSQL.Append("FROM Diario, cntamov ")
        strSQL.Append("WHERE Diario.cnumcom = CNTAMOV.cnumcom ")
        strSQL.Append("and cflc = ' ' ")
        strSQL.Append("and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin ")
        strSQL.Append("and cntamov.cCodcta = @ccodcta ")
        strSQL.Append("group by cntamov.cnumdoc, cntamov.dfeccnt ")
        strSQL.Append("order by  cntamov.dfeccnt, cntamov.cnumdoc ")

        'strSQL.Append("and cpoliza = @cpoliza ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodcta", ccodcta)
        'args(2) = New SqlParameter("@cpoliza", cpoliza)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
Public Function BuscaPolizaOtrosIngresos(ByVal ccodcli As String, ByVal boleta As String, ByVal Tipo As String, ByVal Recibo As String) As DataSet

        Dim strSQL As New StringBuilder
        Dim ds As New DataSet

        strSQL.Append("select * ")
        strSQL.Append("from cntamov ")
        strSQL.Append("where ccodpres=@ccodcli ")
        strSQL.Append("and cnumdoc=@boleta ")
        strSQL.Append("and ccodcli=@tipo ")
        strSQL.Append("and cnumrec=@recibo ")
        strSQL.Append("and cflc='' ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@boleta", boleta)
        args(2) = New SqlParameter("@tipo", Tipo)
        args(3) = New SqlParameter("@recibo", Recibo)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function VerificarReversionOtrosIngresos(ByVal ccodcli As String, ByVal boleta As String, ByVal Tipo As String) As Integer

        Dim strSQL As New StringBuilder
        Dim strSQL2 As New StringBuilder
        Dim ds As New DataSet
        Dim ds2 As New DataSet
        Dim FilasReversadas As Integer = 0
        Dim FilasAplicadas As Integer = 0
        Dim Resultado As Boolean

        ' VERIFICA CUANTAS REVERSIONES TIENE LA BOLETA
        strSQL.Append("select DISTINCT CNUMCOM ")
        strSQL.Append("from cntamov ")
        strSQL.Append("where cnumdoc=@boleta ")
        strSQL.Append("and cntamov.ccodpres=@ccodcli ")
        strSQL.Append("and ccodcli=@tipo ")
        strSQL.Append("and cconcepto like '%REV. OTROS INGRESOS%' ")
        strSQL.Append("and cflc='' ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@boleta", boleta)
        args(2) = New SqlParameter("@tipo", Tipo)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        FilasReversadas = ds.Tables(0).Rows.Count

        ' VERIFICA CUANTAS VECES SE HA HECHO EL PAGO DE UNA BOLETA
        strSQL2.Append("select DISTINCT CNUMCOM ")
        strSQL2.Append("from cntamov ")
        strSQL2.Append("where cnumdoc=@boleta ")
        strSQL2.Append("and cntamov.ccodpres=@ccodcli ")
        strSQL2.Append("and ccodcli=@tipo ")
        strSQL2.Append("and cconcepto not like '%REV. OTROS INGRESOS%' ")
        strSQL2.Append("and cflc='' ")

        Dim args2(3) As SqlParameter
        args2(0) = New SqlParameter("@ccodcli", ccodcli)
        args2(1) = New SqlParameter("@boleta", boleta)
        args2(2) = New SqlParameter("@tipo", Tipo)

        ds2 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL2.ToString(), args2)
        FilasAplicadas = ds2.Tables(0).Rows.Count

        Return (FilasAplicadas - FilasReversadas)


    End Function

    Public Function EsPolizaOtrosIngresos(ByVal boleta As String) As DataSet

        Dim strSQL As New StringBuilder
        Dim ds As New DataSet

        strSQL.Append("select * ")
        strSQL.Append("from cntamov ")
        strSQL.Append("where cnumdoc=@boleta ")
        strSQL.Append("and ccodcli in ('RF','LG','CO') ")
        strSQL.Append("and cflc='' ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@boleta", boleta)
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function BuscaPolizaReversadaOtrosIngresosParaImpresion(ByVal ccodcli As String, ByVal boleta As String, ByVal Tipo As String) As DataSet

        Dim strSQL As New StringBuilder
        Dim ds As New DataSet

        strSQL.Append("select top 1 cntamov.dfeccnt,climide.ccodcli,climide.cnomcli,diario.cglosa,cntamov.cnumdoc,cntamov.cnumrec,cntamov.nhaber,cntamov.ndebe,cntamov.cnumcom ")
        strSQL.Append("from diario inner join cntamov on diario.cnumcom=cntamov.cnumcom inner join climide ")
        strSQL.Append("on climide.ccodcli=cntamov.ccodpres ")
        strSQL.Append("where cntamov.cnumdoc=@boleta ")
        strSQL.Append("and cntamov.ccodpres=@ccodcli ")
        strSQL.Append("and cntamov.ccodcli=@tipo ")
        strSQL.Append("and cglosa like '%REV. OTROS INGRESOS%' ")
        strSQL.Append("and cflc='' ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@boleta", boleta)
        args(2) = New SqlParameter("@tipo", Tipo)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function VerificaChequeProveedor(ByVal cnumcom As String) As Boolean
        Dim strSQL As New StringBuilder
        Dim ds As New DataSet

        strSQL.Append("Select cntamov.ccodpres from  cntamov, ctbdchq ")
        strSQL.Append("where  cntamov.cpoliza = 'EG' and ctbdchq.cnumcom = cntamov.cnumcom and cntamov.cflc = ' '  ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", cnumcom)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lverifica As Boolean = False

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodpres")) Then
                lverifica = True
            Else
                If Trim(ds.Tables(0).Rows(0)("ccodpres")) = "" Then
                    lverifica = True
                End If
            End If
        End If

        Return lverifica

    End Function
    Public Function ObtenerCuerpoPartida(ByVal cnumcom As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from CNTAMOV where cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", cnumcom)

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds

    End Function
    '----Obtiene saldos iniciales
    'Public Function ObtenerSaldosIniciales(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
    '    'saldos antes de 
    '    Dim StrSQL As New StringBuilder

    '    '****************************  finaliza verificacion de cadena de conexion ************************
    '    If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
    '        If lccodofi = "000" And lcfuente = "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) ='PA' group by cntamov.ccodcta")
    '        ElseIf lccodofi <> "000" And lcfuente = "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
    '            StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) ='PA'  group by cntamov.ccodcta")

    '        ElseIf lccodofi = "000" And lcfuente <> "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' '")
    '            StrSQL.Append(" and cntamov.ffondos = @lcfuente and left(cntamov.cpoliza,2) ='PA'  group by cntamov.ccodcta")

    '        ElseIf lccodofi <> "000" And lcfuente <> "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' '")
    '            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
    '            StrSQL.Append(" and cntamov.ffondos = @lcfuente and left(cntamov.cpoliza,2) ='PA'  group by cntamov.ccodcta")
    '        Else
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) ='PA' ")
    '            StrSQL.Append("  group by cntamov.ccodcta")
    '        End If

    '    Else
    '        If lccodofi = "000" And lcfuente = "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA'  ")
    '            StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
    '        ElseIf lccodofi <> "000" And lcfuente = "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
    '            StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
    '            StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")


    '        ElseIf lccodofi = "000" And lcfuente <> "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' '")
    '            StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
    '            StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")

    '        ElseIf lccodofi <> "000" And lcfuente <> "00" Then
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' '")
    '            StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
    '            StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
    '            StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
    '        Else
    '            StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
    '            StrSQL.Append("FROM  diario, cntamov ")
    '            StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
    '            StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
    '            StrSQL.Append(" and cntamov.cflc = ' '")
    '            StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
    '            StrSQL.Append("  group by cntamov.ccodcta")
    '        End If
    '    End If


    '    Dim args(5) As SqlParameter
    '    args(0) = New SqlParameter("@dfecini", dfecIni)
    '    args(1) = New SqlParameter("@dfecfin", dFecFin)
    '    args(2) = New SqlParameter("@pcCodCta", pcCodCta)
    '    args(3) = New SqlParameter("@lnnivel", lnnivel)
    '    args(4) = New SqlParameter("@lccodofi", lccodofi)
    '    args(5) = New SqlParameter("@lcfuente", lcfuente)


    '    Dim ds As DataSet

    '    'If lcfuente = "99" Then
    '    If ccadena.Trim = "" Then
    '        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args, 0)
    '    Else
    '        ds = ExecuteDataSet(ccadena, CommandType.Text, StrSQL.ToString(), args, 0)
    '    End If

    '    'Else
    '    '    If ccadena.Trim = "" Then
    '    '        ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
    '    '    Else
    '    '        ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
    '    '    End If

    '    'End If
    '    Return ds

    'End Function
    Public Function ObtieneNroCheque(ByVal ccodpres As String, ByVal dfecha As Date) As String


        Dim strSQL As New StringBuilder
        strSQL.Append(" Select ctbdchq.cnrochq from cntamov, ctbdchq ")
        strSQL.Append(" WHERE cntamov.cnumcom = ctbdchq.cnumcom and cntamov.cCodpres = @cCodpres ")
        strSQL.Append(" AND cntamov.cPoliza = 'EG' ")
        strSQL.Append(" and cntamov.dfeccnt >= @dfecha and cntamov.dfeccnt <= @dfecha ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodpres", SqlDbType.VarChar)
        args(0).Value = ccodpres
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha


        Dim dsDatos As New DataSet
        Dim lcnrochq As String = ""

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(dsDatos.Tables(0).Rows(0)("cnrochq")) Then
            Else
                lcnrochq = dsDatos.Tables(0).Rows(0)("cnrochq")
            End If
        End If

        Return lcnrochq
    End Function
    Public Function Obtenerresumendetalle(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String) As DataSet
        Dim strSQL As New StringBuilder
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag  ")
                strSQL.Append(" from ctbmcta order by ccodcta ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and  cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag ")
                strSQL.Append(" from ctbmcta order by ccodcta ")

            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag ")
                strSQL.Append(" from ctbmcta order by ccodcta ")

            Else
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag ")
                strSQL.Append(" from ctbmcta order by ccodcta ")
            End If

        Else 'Antes del cierre no debe incluir la partida de liquidacion
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag  ")
                strSQL.Append(" from ctbmcta order by ccodcta ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and  cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag ")
                strSQL.Append(" from ctbmcta order by ccodcta ")

            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag ")
                strSQL.Append(" from ctbmcta order by ccodcta ")

            Else
                strSQL.Append(" Select ctbmcta.ccodcta, ctbmcta.cdescrip, ctbmcta.ccodto, ctbmcta.cnivel, space(1) as cflag, space(1) as ccol,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta)  end as ninidebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta) end as ndebei, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini  group by cntamov.ccodcta) end as nhaberi, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and ctbmcta.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin group by cntamov.ccodcta) end as nhaber, ")
                strSQL.Append(" 00000000000.00 as nsalfin, 00000000000.00 as nsalini, 00000000000.00 as nflag ")
                strSQL.Append(" from ctbmcta order by ccodcta ")
            End If

        End If

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@ffondos", cfuente)
        args(4) = New SqlParameter("@dfecinicial", dfecinicial)

        Dim ds As New DataSet

        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        Return ds
    End Function

    Public Function Obtenerresumendetalle2(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String) As DataSet
        Dim strSQL As New StringBuilder
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo, tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos  group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")


            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo, tabtofi.cnomofi, tabttab.cdescri,")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and  cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and  cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo   and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos  group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and  cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and  cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo,tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi   group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")


            Else
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo,tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo   group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")

            End If

        Else 'Antes del cierre no debe incluir la partida de liquidacion
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo,tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")

             

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo,tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and  cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and  cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ffondos = @ffondos group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo,tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo and cntamov.ccodofi = @ccodofi  group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")

            Else
                strSQL.Append(" select a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo,tabtofi.cnomofi, tabttab.cdescri, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta)  end as ninidebe,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo group by cntamov.ccodcta )  is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza ='PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <= @dfecinicial and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta)  end as ninihaber, ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta) end as ndebei,  ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt < @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecinicial and cntamov.dfeccnt <  @dfecini and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo   group by cntamov.ccodcta) end as nhaberi,  ")
                strSQL.Append(" case when (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.ndebe)  from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta) end as ndebe, ")
                strSQL.Append(" case when (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta ) is null then 0 else (select sum(cntamov.nhaber) from cntamov where cntamov.cflc = ' ' and a.ccodcta = cntamov.ccodcta and cntamov.cpoliza <>'FC' and cntamov.cpoliza <>'PA' and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin and cntamov.ccodofi = tabtofi.ccodofi and cntamov.ffondos = tabttab.ccodigo  group by cntamov.ccodcta) end as nhaber ")
                strSQL.Append(" From ctbmcta a, tabtofi, tabttab where a.ccodto ='D' ")
                strSQL.Append(" and tabttab.ccodtab ='033' and tabttab.ctipreg ='1' ")
                strSQL.Append(" order by a.ccodcta, tabtofi.ccodofi, tabttab.ccodigo ")

            End If

        End If

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@ffondos", cfuente)
        args(4) = New SqlParameter("@dfecinicial", dfecinicial)


        Dim ds As New DataSet

        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        Return ds
    End Function


    Public Function ObtenerSaldoPartidaInicial(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi  ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            Else
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            End If

        Else 'Antes del cierre no debe incluir la partida de liquidacion
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi  ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            Else
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza = 'PA' ")
                strSQL.Append("and dfeccnt >= @dfecinicial and dfeccnt <= @dfecinicial ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            End If

        End If

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@ffondos", cfuente)
        args(4) = New SqlParameter("@dfecinicial", dfecinicial)
        args(5) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet

        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        Return ds
    End Function

    Public Function ObtenerSaldoInicial(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi  ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            Else
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            End If

        Else 'Antes del cierre no debe incluir la partida de liquidacion
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi  ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            Else
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            End If

        End If

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@ffondos", cfuente)
        args(4) = New SqlParameter("@dfecinicial", dfecinicial)
        args(5) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet

        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        Return ds
    End Function

    Public Function ObtenerMovPeriodo(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi  ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            Else
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <> 'PA' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            End If

        Else 'Antes del cierre no debe incluir la partida de liquidacion
            If ccodofi <> "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            ElseIf ccodofi = "000" And cfuente <> "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ffondos = @ffondos ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            ElseIf ccodofi <> "000" And cfuente = "00" Then
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("and cntamov.ccodofi = @ccodofi  ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")


            Else
                strSQL.Append("select ccodcta, ccodofi, ffondos, sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
                strSQL.Append("from  cntamov where cflc = ' ' and cpoliza <>'FC' ")
                strSQL.Append("and dfeccnt > @dfecinicial and dfeccnt < @dfecini ")
                strSQL.Append("and ccodcta = @ccodcta ")
                strSQL.Append("group by ccodcta, ccodofi, ffondos ")

            End If

        End If

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@ffondos", cfuente)
        args(4) = New SqlParameter("@dfecinicial", dfecinicial)
        args(5) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet

        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        Return ds
    End Function
    Public Function ObtenerPartidadePago(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cpoliza As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * from cntamov ")
        strSQL.Append("WHERE ccodpres = @ccodcta and corden = @cnrodoc and cpoliza = @cpoliza   ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnrodoc", cnrodoc)
        args(2) = New SqlParameter("@cpoliza", cpoliza)
        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function

    Public Function ObtenerPartidadePagoIngresoAjuste(ByVal ccodcta As String, ByVal cnrodoc As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * from cntamov ")
        strSQL.Append("WHERE ccodpres = @ccodcta and corden = @cnrodoc and (cpoliza = 'ING'  or cpoliza ='AR') ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnrodoc", cnrodoc)

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function GeneraDatosConta(ByVal dfeccnt As Date) As DataSet
        Dim command As New SqlCommand
        Dim mydata As New SqlDataAdapter
        Dim ds As New DataSet

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select diario.cnumcom, diario.cglosa," & _
                                      "cntamov.ccodofi, cntamov.ffondos, cntamov.ccodcta, cntamov.ndebe, cntamov.nhaber," & _
                                      "cntamov.ccodpres, cntamov.ccodsec, cntamov.dfeccnt from diario " & _
                                      "inner join cntamov on diario.cnumcom = cntamov.cnumcom " & _
                                      "where cntamov.dfeccnt >='" & dfeccnt & "' and cntamov.dfeccnt<='" & dfeccnt & "' and cntamov.cflc ='' " & _
                                      "order by diario.cnumcom "
                command.CommandType = CommandType.Text
                mydata.SelectCommand = command
                mydata.Fill(ds, "Datos")

            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using
        Return ds
    End Function
    Public Function ObtieneCargosBancarios(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" select SUM(ndebe) as ndebe ")
        strSQL.Append(" from cntamov ")
        strSQL.Append(" where cflc = ' ' and ccodcta = @ccodcta ")
        strSQL.Append(" and dfeccnt >= @dfecha1 and dfeccnt <= @dfecha2 group by cCodcta")

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", dfecha1)
        args(1) = New SqlParameter("@dfecha2", dfecha2)
        args(2) = New SqlParameter("@cCodCta", ccodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ndebe")) Then
            Else
                lnmonto = ds.Tables(0).Rows(0)("ndebe")
            End If
        End If

        Return lnmonto
    End Function

    Public Function ObtieneAbonosBancarios(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" select SUM(nhaber) as nhaber ")
        strSQL.Append(" from cntamov ")
        strSQL.Append(" where cflc = ' ' and ccodcta = @ccodcta ")
        strSQL.Append(" and dfeccnt >= @dfecha1 and dfeccnt <= @dfecha2 group by cCodcta")

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", dfecha1)
        args(1) = New SqlParameter("@dfecha2", dfecha2)
        args(2) = New SqlParameter("@cCodCta", ccodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nhaber")) Then
            Else
                lnmonto = ds.Tables(0).Rows(0)("nhaber")
            End If
        End If

        Return lnmonto
    End Function
    Public Function Obtener_Saldos_fondos_oficina_CuentasdeResultado(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lcfondo As String, ByVal lcoficina As String) As DataSet

        Dim StrSQL As New StringBuilder

        StrSQL.Append("SELECT cntamov.ccodcta, sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber, sum(ctbmcta.nsalini) as nsalini ")
        StrSQL.Append("FROM ctbmcta, diario, cntamov ")
        StrSQL.Append(" WHERE ctbmcta.ccodcta = cntamov.cCodCta  and cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
        StrSQL.Append(" and ltrim(cntamov.ffondos) = @lcfondo")
        StrSQL.Append(" and ltrim(cntamov.ccodofi) = @lcoficina")
        StrSQL.Append(" and cntamov.cflc = ' ' and (left(cntamov.ccodcta,1) ='6' or left(cntamov.ccodcta,1) ='7') ")
        StrSQL.Append(" group by cntamov.ccodcta")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@lcfondo", lcfondo)
        args(3) = New SqlParameter("@lcoficina", lcoficina)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Return ds

    End Function
    '----Obtiene saldos iniciales
    Public Function ObtenerSaldosIniciales(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
        'saldos antes de 
        Dim StrSQL As New StringBuilder

        '****************************  finaliza verificacion de cadena de conexion ************************
        If lccierre.Trim = "0" Or lccierre.Trim = "2" Then
            If lccodofi = "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) ='PA' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) ='PA'  group by cntamov.ccodcta")

            ElseIf lccodofi = "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente and left(cntamov.cpoliza,2) ='PA'  group by cntamov.ccodcta")

            ElseIf lccodofi <> "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente and left(cntamov.cpoliza,2) ='PA'  group by cntamov.ccodcta")
            Else
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' ' and left(cntamov.cpoliza,2) ='PA' ")
                StrSQL.Append("  group by cntamov.ccodcta")
            End If

        Else
            If lccodofi = "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA'  ")
                StrSQL.Append(" and cntamov.cflc = ' ' group by cntamov.ccodcta")
            ElseIf lccodofi <> "000" And lcfuente = "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
                StrSQL.Append(" and cntamov.cflc = ' '  group by cntamov.ccodcta")


            ElseIf lccodofi = "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")

            ElseIf lccodofi <> "000" And lcfuente <> "00" Then
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and cntamov.ccodofi = @lccodofi")
                StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
                StrSQL.Append(" and cntamov.ffondos = @lcfuente  group by cntamov.ccodcta")
            Else
                StrSQL.Append("SELECT sum(cntamov.ndebe) as ndebe, sum(cntamov.nhaber) as nhaber ")
                StrSQL.Append("FROM  diario, cntamov ")
                StrSQL.Append(" WHERE  cntamov.cnumcom = diario.cnumcom and cntamov.dfeccnt >= @dfecIni and cntamov.dFecCnt <= @dFecFin ")
                StrSQL.Append(" and left(cntamov.ccodcta,@lnnivel) = @pccodcta")
                StrSQL.Append(" and cntamov.cflc = ' '")
                StrSQL.Append(" and left(cntamov.cpoliza,2) ='PA' ")
                StrSQL.Append("  group by cntamov.ccodcta")
            End If
        End If


        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecIni)
        args(1) = New SqlParameter("@dfecfin", dFecFin)
        args(2) = New SqlParameter("@pcCodCta", pcCodCta)
        args(3) = New SqlParameter("@lnnivel", lnnivel)
        args(4) = New SqlParameter("@lccodofi", lccodofi)
        args(5) = New SqlParameter("@lcfuente", lcfuente)


        Dim ds As DataSet

        'If lcfuente = "99" Then
        If ccadena.Trim = "" Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(ccadena, CommandType.Text, StrSQL.ToString(), args, 0)
        End If

        'Else
        '    If ccadena.Trim = "" Then
        '        ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, StrSQL.ToString(), args)
        '    Else
        '        ds = sql.ExecuteDataset(ccadena, CommandType.Text, StrSQL.ToString(), args)
        '    End If

        'End If
        Return ds

    End Function
    Public Function ValidaUltimaFechaDeLiquidacion(ByVal ccodofi As String, ByVal fecha As Date) As Boolean
        Dim strSQL As New StringBuilder
        Dim valido As Boolean
        Dim dfecha As Date

        'SE CAMBIO LA VALIDACION PARA QUE VERIFICA SI YA ESTA EL REINTEGRO QUIERE DECIR QUE YA LIQUIDARON

        strSQL.Append("select top 1 dfecha ")
        strSQL.Append("from auxcaja ")
        strSQL.Append("where ccodofi=@ccodofi ")
        'strSQL.Append("and ctipope='G' ")
        'strSQL.Append("and laplcon=1 ")
        strSQL.Append("and ctipope='R'  ")
        strSQL.Append("and laplcon=0 ")
        strSQL.Append("order by dfecha desc")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        If ds.Tables(0).Rows.Count = 0 Then
            valido = True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("dfecha")) Then
                valido = True
            Else
                dfecha = ds.Tables(0).Rows(0)("dfecha")
                If fecha < dfecha Then
                    valido = False
                Else
                    valido = True
                End If
            End If
        End If

        Return valido
    End Function
    Public Function AgregarAuxiliarCaja(ByVal aEntidad As entidadBase) As Integer


        Dim lEntidad As cntamov
        lEntidad = aEntidad

        'Dim lnnumlin As Decimal = 1
        'lnnumlin = ObtenerLinea(lEntidad.cnumcom)

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO auxcaja ")
        strSQL.Append(" ( cnit, ")
        strSQL.Append(" cproveedor, ")
        strSQL.Append(" cdescri, ")
        strSQL.Append(" dfecha, ")
        strSQL.Append(" ctipo, ")
        strSQL.Append(" cfactura, ")
        strSQL.Append(" ndebe, ")
        strSQL.Append(" nsaldo, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" ccodant, ")
        strSQL.Append(" laplcon, ")
        strSQL.Append(" cctabco, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ccodins, ")
        strSQL.Append(" ccodenc, ")
        strSQL.Append(" nmonfac, ")
        strSQL.Append(" niva, ")
        strSQL.Append(" nisr, ")
        strSQL.Append(" cnumcom, ")
        strSQL.Append(" cfuente, ")
        strSQL.Append(" dfecmod, ccodbco, cestado, ctipope, ccodres, cauxcta) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnit, ")
        strSQL.Append(" @cproveedor, ")
        strSQL.Append(" @cdescri, ")
        strSQL.Append(" @dfecha, ")
        strSQL.Append(" @ctipo, ")
        strSQL.Append(" @cfactura, ")
        strSQL.Append(" @ndebe, ")
        strSQL.Append(" @nsaldo, ")
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @ccodant, ")
        strSQL.Append(" @laplcon, ")
        strSQL.Append(" @cctabco, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @ccodins, ")
        strSQL.Append(" @ccodenc, ")
        strSQL.Append(" @nmonfac, ")
        strSQL.Append(" @niva, ")
        strSQL.Append(" @nisr, ")
        strSQL.Append(" @cnumcom, ")
        strSQL.Append(" @cfuente, ")
        strSQL.Append(" @dfecmod, @ccodbco, @cestado, @ctipope, @ccodres, @cauxcta) ")

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@cnit", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnit
        args(1) = New SqlParameter("@cproveedor", SqlDbType.VarChar)
        args(1).Value = lEntidad.cproveedor
        args(2) = New SqlParameter("@cdescri", SqlDbType.Char)
        args(2).Value = IIf(lEntidad.cdescri = Nothing, DBNull.Value, lEntidad.cdescri)
        args(3) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfecha
        args(4) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipo
        args(5) = New SqlParameter("@cfactura", SqlDbType.VarChar)
        args(5).Value = lEntidad.cfactura
        args(6) = New SqlParameter("@ndebe", SqlDbType.Decimal)
        args(6).Value = lEntidad.ndebe
        args(7) = New SqlParameter("@nsaldo", SqlDbType.Decimal)
        args(7).Value = lEntidad.nsaldo
        args(8) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflag
        args(9) = New SqlParameter("@ccodant", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodant
        args(10) = New SqlParameter("@laplcon", SqlDbType.Bit)
        args(10).Value = lEntidad.laplcon
        args(11) = New SqlParameter("@cctabco", SqlDbType.VarChar)
        args(11).Value = lEntidad.cctabco
        args(12) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodofi
        args(13) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodins
        args(14) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodenc
        args(15) = New SqlParameter("@nmonfac", SqlDbType.Decimal)
        args(15).Value = lEntidad.nmonfac
        args(16) = New SqlParameter("@niva", SqlDbType.Decimal)
        args(16).Value = lEntidad.niva
        args(17) = New SqlParameter("@nisr", SqlDbType.Decimal)
        args(17).Value = lEntidad.nisr
        args(18) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(18).Value = lEntidad.cnumcom
        args(19) = New SqlParameter("@cfuente", SqlDbType.Char)
        args(19).Value = lEntidad.cfuente
        args(20) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(20).Value = lEntidad.dfecmod
        args(21) = New SqlParameter("@ccodbco", SqlDbType.Char)
        args(21).Value = lEntidad.ccodbco
        args(22) = New SqlParameter("@cestado", SqlDbType.Char)
        args(22).Value = lEntidad.cestado
        args(23) = New SqlParameter("@ctipope", SqlDbType.Char)
        args(23).Value = lEntidad.ctipope
        args(24) = New SqlParameter("@ccodres", SqlDbType.Char)
        args(24).Value = lEntidad.ccodres
        args(25) = New SqlParameter("@cauxcta", SqlDbType.Decimal)
        args(25).Value = lEntidad.cauxcta

        Try
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception

        End Try



    End Function
    Public Function Obtenermovcajachica(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String, ByVal ccodenc As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT AUXCAJA.idcchica,AUXCAJA.cNit, CNTAEMP.cDescri As cDesPro, AUXCAJA.cDescri, AUXCAJA.dFecha, ")
        strSQL.Append("AUXCAJA.cFactura, AUXCAJA.cTipo, AUXCAJA.nDebe, AUXCAJA.nSaldo, AUXCAJA.nMonFac, ")
        strSQL.Append("AUXCAJA.cProveedor,AUXCAJA.cFuente, AUXCAJA.cCodRes, AUXCAJA.cAuxCta,AUXCAJA.CTIPOPE,AUXCAJA.laplcon, ")
        strSQL.Append(" (case when AUXCAJA.ctipope='A' then 'Apertura' 	when AUXCAJA.ctipope='R' then 'Reintegro' when AUXCAJA.ctipope='G' then 'Gasto' end) as destipope ")
        strSQL.Append("FROM AUXCAJA, CNTAEMP ")
        strSQL.Append("WHERE AUXCAJA.dFecha >= @dfecini and AUXCAJA.dFecha <= @dfecfin ")
        strSQL.Append("and AUXCAJA.cProveedor = CNTAEMP.cCodEmp and auxcaja.cestado = ' '")
        If ccodofi.Trim = "" Then
        Else
            strSQL.Append("and AUXCAJA.cCodOfi = @cCodOfi ")
        End If
        If cfuente.Trim = "" Then
        Else
            strSQL.Append("and AUXCAJA.cfuente = @cfuente ")
        End If
        If ccodenc = "" Then
        Else
            strSQL.Append("and AUXCAJA.ccodenc = @ccodenc ")
        End If


        strSQL.Append("order by auxcaja.dfecha ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@cfuente", cfuente)
        args(4) = New SqlParameter("@ccodenc", ccodenc)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds
    End Function
    Public Function DataParaLiquidarCajaChica(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append("select auxcaja.ctipo as ccodcta,sum(nmonfac) as monto ")
        strSQL.Append("from auxcaja ")
        strSQL.Append("where auxcaja.dfecha between @dfecini and @dfecfin ")
        strSQL.Append("and auxcaja.laplcon='0' ")
        strSQL.Append("and auxcaja.cnumcom='' ")
        strSQL.Append("and auxcaja.cestado='' ")
        strSQL.Append("and auxcaja.ctipope='G' ")

        If ccodofi = "" Then
        Else
            strSQL.Append("and auxcaja.ccodofi=@ccodofi ")
        End If

        strSQL.Append("group by ctipo ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds
    End Function

    Public Function ObtenermovcajachicaImpresion(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String, ByVal ccodenc As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT AUXCAJA.idcchica,AUXCAJA.cNit, CNTAEMP.cDescri As cDesPro, AUXCAJA.cDescri, AUXCAJA.dFecha, ")
        strSQL.Append("AUXCAJA.cFactura, AUXCAJA.cTipo, AUXCAJA.nDebe, AUXCAJA.nSaldo, AUXCAJA.nMonFac, ")
        strSQL.Append("AUXCAJA.cProveedor,AUXCAJA.cFuente, AUXCAJA.cCodRes, AUXCAJA.cAuxCta,ctbmcta.cDescrip,auxcaja.cobservac ")
        strSQL.Append("FROM AUXCAJA, CNTAEMP,ctbmcta ")
        strSQL.Append("WHERE AUXCAJA.dFecha >= @dfecini and AUXCAJA.dFecha <= @dfecfin ")
        strSQL.Append("and AUXCAJA.cProveedor = CNTAEMP.cCodEmp and auxcaja.cestado = ' ' ")
        strSQL.Append("and auxcaja.ctipo=ctbmcta.ccodcta ")
        strSQL.Append("and AUXCAJA.ctipope='G' ")
        If ccodofi.Trim = "" Then
        Else
            strSQL.Append("and AUXCAJA.cCodOfi = @cCodOfi ")
        End If
        If cfuente.Trim = "" Then
        Else
            strSQL.Append("and AUXCAJA.cfuente = @cfuente ")
        End If
        If ccodenc = "" Then
        Else
            strSQL.Append("and AUXCAJA.ccodenc = @ccodenc ")
        End If


        strSQL.Append("order by auxcaja.dfecha ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@ccodofi", ccodofi)
        args(3) = New SqlParameter("@cfuente", cfuente)
        args(4) = New SqlParameter("@ccodenc", ccodenc)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds
    End Function


    Public Function ObtenerEfectivoCajaChicaAgencia(ByVal ccodofi As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT nmontocc as nmonto ")
        strSQL.Append("FROM tabtofi ")
        strSQL.Append("where ccodofi=@ccodofi ")

        If ccodofi.Trim = "" Then
        Else
            strSQL.Append("and cCodOfi = @cCodOfi ")
        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim nmonto As Decimal = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
            Else
                nmonto = ds.Tables(0).Rows(0)("nmonto")
            End If
        End If

        Return nmonto

    End Function

    Public Function ObtenerCajaChicaConsolidado(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal laplcon As String, ByVal ccodofi As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" select ROW_NUMBER() OVER( ORDER BY tabtofi.ccodofi asc ) AS correlativo,tabtofi.ccodofi,tabtofi.cnomofi,usuarios.nombre,usuarios.cctabco,sum(nmonfac) as total ")
        strSQL.Append(" from auxcaja inner join cntaemp on auxcaja.cnit=cntaemp.ccodemp ")
        strSQL.Append(" inner join tabtofi on auxcaja.ccodofi=tabtofi.ccodofi ")
        strSQL.Append(" inner join usuarios on auxcaja.ccodenc=usuarios.usuario ")
        strSQL.Append(" where auxcaja.cestado='' ")
        strSQL.Append(" and auxcaja.ctipope='G' ")
        strSQL.Append(" and auxcaja.laplcon=@laplcon ")
        strSQL.Append(" and auxcaja.dfecha between @dfecini and @dfecfin ")

        If ccodofi = "" Then
        Else
            strSQL.Append(" and auxcaja.ccodofi=@ccodofi ")
        End If

        strSQL.Append(" group by tabtofi.ccodofi,tabtofi.cnomofi,usuarios.nombre,usuarios.cctabco ")
        strSQL.Append(" order by tabtofi.ccodofi ")



        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecini", dfecini)
        args(1) = New SqlParameter("@dfecfin", dfecfin)
        args(2) = New SqlParameter("@laplcon", laplcon)
        args(3) = New SqlParameter("@ccodofi", ccodofi)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds

    End Function
    Public Function ActualizaNOLiquidadoCC(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append(" UPDATE AUXCAJA set laplcon ='1' where auxcaja.dfecha between @dfecini and @dfecfin  ")

        If ccodofi = "" Then
        Else
            strSQL.Append(" and auxcaja.ccodofi=@ccodofi")
        End If

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@dfecini", SqlDbType.DateTime)
        args(0).Value = dfecini
        args(1) = New SqlParameter("@dfecfin", SqlDbType.DateTime)
        args(1).Value = dfecfin
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizaLiquidadoCC(ByVal cnumcom As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE AUXCAJA set cnumcom = @cnumcom where auxcaja.dfecha between @dfecini and @dfecfin and laplcon ='1' ")

        If ccodofi = "" Then
        Else
            strSQL.Append("and AUXCAJA.cCodOfi = @cCodOfi ")
        End If

        Dim args(3) As SqlParameter

        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom
        args(1) = New SqlParameter("@dfecini", SqlDbType.DateTime)
        args(1).Value = dfecini
        args(2) = New SqlParameter("@dfecfin", SqlDbType.DateTime)
        args(2).Value = dfecfin
        args(3) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(3).Value = ccodofi

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerAuxiliarCajaPorId(ByVal aEntidad As entidadBase) As Integer

        Dim ds As New DataSet
        Dim lEntidad As cntamov
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append(" select  ")
        strSQL.Append(" cnit, ")
        strSQL.Append(" cproveedor, ")
        strSQL.Append(" cdescri, ")
        strSQL.Append(" dfecha, ")
        strSQL.Append(" ctipo, ")
        strSQL.Append(" cfactura, ")
        strSQL.Append(" ndebe, ")
        strSQL.Append(" nsaldo, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" ccodant, ")
        strSQL.Append(" laplcon, ")
        strSQL.Append(" cctabco, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ccodins, ")
        strSQL.Append(" ccodenc, ")
        strSQL.Append(" nmonfac, ")
        strSQL.Append(" niva, ")
        strSQL.Append(" nisr, ")
        strSQL.Append(" cnumcom, ")
        strSQL.Append(" cfuente, ")
        strSQL.Append(" dfecmod, ccodbco, cestado, ctipope, ccodres, cauxcta ")
        strSQL.Append(" from auxcaja ")
        strSQL.Append(" where idcchica=@idcchica ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idcchica", SqlDbType.Int)
        args(0).Value = Integer.Parse(lEntidad.ccodsec)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else

            lEntidad.cnit = ds.Tables(0).Rows(0).Item("cnit")
            lEntidad.cproveedor = ds.Tables(0).Rows(0).Item("cproveedor")
            lEntidad.cdescri = ds.Tables(0).Rows(0).Item("cdescri")
            lEntidad.dfecha = ds.Tables(0).Rows(0).Item("dfecha")
            lEntidad.ctipo = ds.Tables(0).Rows(0).Item("ctipo")
            lEntidad.cfactura = ds.Tables(0).Rows(0).Item("cfactura")
            lEntidad.ndebe = ds.Tables(0).Rows(0).Item("ndebe")
            lEntidad.nsaldo = ds.Tables(0).Rows(0).Item("nsaldo")
            lEntidad.cflag = ds.Tables(0).Rows(0).Item("cflag")
            lEntidad.ccodant = ds.Tables(0).Rows(0).Item("ccodant")
            lEntidad.laplcon = ds.Tables(0).Rows(0).Item("laplcon")
            lEntidad.cctabco = ds.Tables(0).Rows(0).Item("cctabco")
            lEntidad.ccodofi = ds.Tables(0).Rows(0).Item("ccodofi")
            lEntidad.ccodins = ds.Tables(0).Rows(0).Item("ccodins")
            lEntidad.ccodenc = ds.Tables(0).Rows(0).Item("ccodenc")
            lEntidad.nmonfac = ds.Tables(0).Rows(0).Item("nmonfac")
            lEntidad.niva = ds.Tables(0).Rows(0).Item("niva")
            lEntidad.nisr = ds.Tables(0).Rows(0).Item("nisr")
            lEntidad.cnumcom = ds.Tables(0).Rows(0).Item("cnumcom")
            lEntidad.cfuente = ds.Tables(0).Rows(0).Item("cfuente")
            lEntidad.dfecmod = ds.Tables(0).Rows(0).Item("dfecmod")
            lEntidad.ccodbco = ds.Tables(0).Rows(0).Item("ccodbco")
            lEntidad.cestado = ds.Tables(0).Rows(0).Item("cestado")
            lEntidad.ctipope = ds.Tables(0).Rows(0).Item("ctipope")
            lEntidad.ccodres = ds.Tables(0).Rows(0).Item("ccodres")
            lEntidad.cauxcta = ds.Tables(0).Rows(0).Item("cauxcta")

        End If

        Return 1

    End Function
    Public Function ActualizarAuxiliarCaja(ByVal aEntidad As entidadBase) As Integer


        Dim lEntidad As cntamov
        lEntidad = aEntidad

        'Dim lnnumlin As Decimal = 1
        'lnnumlin = ObtenerLinea(lEntidad.cnumcom)

        Dim strSQL As New StringBuilder

        strSQL.Append(" update auxcaja set")
        strSQL.Append(" cnit=@cnit, ")
        strSQL.Append(" cproveedor=@cproveedor, ")
        strSQL.Append(" cdescri=@cdescri, ")
        strSQL.Append(" dfecha=@dfecha, ")
        strSQL.Append(" ctipo=@ctipo, ")
        strSQL.Append(" cfactura=@cfactura, ")
        strSQL.Append(" ndebe=@ndebe, ")
        strSQL.Append(" nsaldo=@nsaldo, ")
        strSQL.Append(" cflag=@cflag, ")
        strSQL.Append(" ccodant=@ccodant, ")
        strSQL.Append(" ccodofi=@ccodofi, ")
        strSQL.Append(" ccodins=@ccodins, ")
        strSQL.Append(" ccodenc=@ccodenc, ")
        strSQL.Append(" nmonfac=@nmonfac, ")
        strSQL.Append(" niva=@niva, ")
        strSQL.Append(" nisr=@nisr, ")
        strSQL.Append(" cfuente=@cfuente, ")
        strSQL.Append(" dfecmod=@dfecmod, cestado=@cestado, ctipope=@ctipope, ccodres=@ccodres,cobservac=@cobservac ")
        strSQL.Append(" where idcchica=@idcchica ")

        Dim args(27) As SqlParameter
        args(0) = New SqlParameter("@cnit", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnit
        args(1) = New SqlParameter("@cproveedor", SqlDbType.VarChar)
        args(1).Value = lEntidad.cproveedor
        args(2) = New SqlParameter("@cdescri", SqlDbType.Char)
        args(2).Value = IIf(lEntidad.cdescri = Nothing, DBNull.Value, lEntidad.cdescri)
        args(3) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfecha
        args(4) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipo
        args(5) = New SqlParameter("@cfactura", SqlDbType.VarChar)
        args(5).Value = lEntidad.cfactura
        args(6) = New SqlParameter("@ndebe", SqlDbType.Decimal)
        args(6).Value = lEntidad.ndebe
        args(7) = New SqlParameter("@nsaldo", SqlDbType.Decimal)
        args(7).Value = lEntidad.nsaldo
        args(8) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflag
        args(9) = New SqlParameter("@ccodant", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodant
        args(10) = New SqlParameter("@laplcon", SqlDbType.Bit)
        args(10).Value = lEntidad.laplcon
        args(11) = New SqlParameter("@cctabco", SqlDbType.VarChar)
        args(11).Value = lEntidad.cctabco
        args(12) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodofi
        args(13) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodins
        args(14) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodenc
        args(15) = New SqlParameter("@nmonfac", SqlDbType.Decimal)
        args(15).Value = lEntidad.nmonfac
        args(16) = New SqlParameter("@niva", SqlDbType.Decimal)
        args(16).Value = lEntidad.niva
        args(17) = New SqlParameter("@nisr", SqlDbType.Decimal)
        args(17).Value = lEntidad.nisr
        args(18) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(18).Value = lEntidad.cnumcom
        args(19) = New SqlParameter("@cfuente", SqlDbType.Char)
        args(19).Value = lEntidad.cfuente
        args(20) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(20).Value = lEntidad.dfecmod
        args(21) = New SqlParameter("@ccodbco", SqlDbType.Char)
        args(21).Value = lEntidad.ccodbco
        args(22) = New SqlParameter("@cestado", SqlDbType.Char)
        args(22).Value = lEntidad.cestado
        args(23) = New SqlParameter("@ctipope", SqlDbType.Char)
        args(23).Value = lEntidad.ctipope
        args(24) = New SqlParameter("@ccodres", SqlDbType.Char)
        args(24).Value = lEntidad.ccodres
        args(25) = New SqlParameter("@cauxcta", SqlDbType.Decimal)
        args(25).Value = lEntidad.cauxcta
        args(26) = New SqlParameter("@idcchica", SqlDbType.Int)
        args(26).Value = Integer.Parse(lEntidad.ccodsec)
        args(27) = New SqlParameter("@cobservac", SqlDbType.VarChar)
        args(27).Value = lEntidad.cconcepto


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtieneMontoAutorizadoCajaChicaOficina(ByVal ccodofi As String) As Decimal
        Dim strSQL As New StringBuilder

        strSQL.Append("Select nmontocc ")
        strSQL.Append("from tabtofi ")
        strSQL.Append("where ccodofi=@ccodofi ")

        If ccodofi.Trim = "" Then
        Else
            strSQL.Append("and cCodOfi = @cCodOfi ")
        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim nmonto As Decimal = 0

        If ds.Tables(0).Rows.Count = 0 Then
            nmonto = 0
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmontocc")) Then
                nmonto = 0
            Else
                nmonto = ds.Tables(0).Rows(0)("nmontocc")
            End If
        End If

        Return nmonto
    End Function

    Public Function ObtieneNumeroPartidaporCredito(ByVal cCodpres As String, ByVal dfecha As Date) As String
        Dim StrSQL As New StringBuilder
        StrSQL.Append("Select cnumdoc, cnumcom from cntamov ")
        StrSQL.Append("WHERE cpoliza = 'EG' and ccodpres = @cCodpres ")
        StrSQL.Append("and dfeccnt >= @dfecha and dfeccnt <= @dfecha ")
        StrSQL.Append("group by cnumdoc, cnumcom order by cnumcom desc ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodpres", SqlDbType.VarChar)
        args(0).Value = cCodpres
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, StrSQL.ToString(), args)

        Dim lcnumcom As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnumcom")) Then
            Else
                lcnumcom = ds.Tables(0).Rows(0)("cnumcom")
            End If
        End If

        Return lcnumcom

    End Function


    Public Function fxStrZero(ByVal pnParameter As Integer, ByVal pnNumDig As Integer) As String
        Dim lcDigConv As String
        Dim lnLongDat As Integer
        Dim k As Integer
        lnLongDat = pnParameter.ToString.Trim.Length
        If lnLongDat >= pnNumDig Then
            lcDigConv = pnParameter.ToString.Trim
        Else
            lcDigConv = pnParameter.ToString.Trim
            For k = 1 To (pnNumDig - lnLongDat)
                lcDigConv = "0" & lcDigConv
            Next
        End If
        Return lcDigConv
    End Function

    Public Function Extrae_Partida_Diario(ByVal pcnumcom As String, ByVal ccadena As String) As DataSet

        Dim ds As New DataSet
        Dim _sql As String = ""
        'Dim connection As Object = Conexion()
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim conexion As String = IIf(ccadena.Trim.Length = 0, Me.cnnStr, ccadena)

        'If Me.Tipo_Cnn = 2 Then 'MYSQL          
        '    pcBAse = pcBAse & "."
        '    pcBAse = pcBAse.Trim
        'Else
        '    pcBAse = pcBAse & ".dbo."
        '    pcBAse = pcBAse.Trim
        'End If


        Using connection As New SqlConnection(conexion)
            connection.Open()

            command.Connection = connection

            Try

                command.CommandText = _
                                        " SELECT C.cnumcom, C.cglosa, C.dfeccnt, B.cnumlin as idCuenta," & _
                                        " A.cCodcta, A.cDescrip as cdescri, B.nDebe, B.nHaber, " & _
                                        " B.cconcepto, B.cCodofi, space(4) as cCostos, cpoliza as ccodtrans," & _
                                        " ctipasi, E.cnomofi, space(0) as ccodbco, space(0) as cctacte, B.cpoliza " & _
                                        " From ctbmcta A " & _
                                        " inner join cntamov B " & _
                                        " on B.cCodcta = A.cCodcta " & _
                                        " inner join Diario C " & _
                                        " on B.cnumcom = C.cnumcom " & _
                                        " inner join Tabtofi E " & _
                                        " on B.cCodofi = E.cCodofi " & _
                                        " WHERE B.cflc <> 'X' and C.cnumcom ='" & pcnumcom & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Partidas")

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds

    End Function

End Class
