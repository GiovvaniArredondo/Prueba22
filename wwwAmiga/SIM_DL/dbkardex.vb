Imports System.Text
Public Class dbkardex
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credkar
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnuming = "" _
            Or lEntidad.cnuming = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnuming = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE kardex ")
        strSQL.Append(" SET dfecpro = @dfecpro, ")
        strSQL.Append(" dfecsis = @dfecsis, ")
        strSQL.Append(" cnrocuo = @cnrocuo, ")
        strSQL.Append(" nmonto = @nmonto, ")
        strSQL.Append(" ccodins = @ccodins, ")
        strSQL.Append(" ccodofi = @ccodofi, ")
        strSQL.Append(" ctippag = @ctippag, ")
        strSQL.Append(" cestado = @cestado, ")
        strSQL.Append(" ctermid = @ctermid, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cmoneda = @cmoneda, ")
        strSQL.Append(" ccondic = @ccondic, ")
        strSQL.Append(" cbanco = @cbanco, ")
        strSQL.Append(" ccodctb = @ccodctb, ")
        strSQL.Append(" ctrasctb = @ctrasctb, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" cclipag = @cclipag, ")
        strSQL.Append(" mancomunad = @mancomunad, ")
        strSQL.Append(" cnomcta = @cnomcta, ")
        strSQL.Append(" cnumcta = @cnumcta, ")
        strSQL.Append(" crotativa = @crotativa, ")
        strSQL.Append(" ndiaatr = @ndiaatr ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" AND cconcep = @cconcep ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cnuming = @cnuming ")

        Dim args(27) As SqlParameter
        args(0) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecpro
        args(1) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecsis
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo
        args(3) = New SqlParameter("@nmonto", SqlDbType.VarChar)
        args(3).Value = lEntidad.nmonto
        args(4) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodins
        args(5) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodofi
        args(6) = New SqlParameter("@ctippag", SqlDbType.VarChar)
        args(6).Value = lEntidad.ctippag
        args(7) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(7).Value = lEntidad.cestado
        args(8) = New SqlParameter("@ctermid", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctermid
        args(9) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodusu
        args(10) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(11).Value = lEntidad.cmoneda
        args(12) = New SqlParameter("@ccondic", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccondic
        args(13) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(13).Value = lEntidad.cbanco
        args(14) = New SqlParameter("@ccodctb", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodctb
        args(15) = New SqlParameter("@ctrasctb", SqlDbType.Bit)
        args(15).Value = IIf(lEntidad.ctrasctb = Nothing, DBNull.Value, lEntidad.ctrasctb)
        args(16) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(16).Value = lEntidad.cflag
        args(17) = New SqlParameter("@cclipag", SqlDbType.VarChar)
        args(17).Value = lEntidad.cclipag
        args(18) = New SqlParameter("@mancomunad", SqlDbType.VarChar)
        args(18).Value = lEntidad.mancomunad
        args(19) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(19).Value = lEntidad.cnomcta
        args(20) = New SqlParameter("@cnumcta", SqlDbType.VarChar)
        args(20).Value = lEntidad.cnumcta
        args(21) = New SqlParameter("@crotativa", SqlDbType.VarChar)
        args(21).Value = lEntidad.crotativa
        args(22) = New SqlParameter("@ndiaatr", SqlDbType.VarChar)
        args(22).Value = lEntidad.ndiaatr
        args(23) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(23).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(24) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(24).Value = IIf(lEntidad.cnrodoc = Nothing, DBNull.Value, lEntidad.cnrodoc)
        args(25) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(25).Value = IIf(lEntidad.cconcep = Nothing, DBNull.Value, lEntidad.cconcep)
        args(26) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(26).Value = IIf(lEntidad.cdescob = Nothing, DBNull.Value, lEntidad.cdescob)
        args(27) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(27).Value = IIf(lEntidad.cnuming = Nothing, DBNull.Value, lEntidad.cnuming)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As kardex
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO kardex ")
        strSQL.Append(" ( ccodcta, ")
        strSQL.Append(" dfecpro, ")
        strSQL.Append(" dfecsis, ")
        strSQL.Append(" cnrocuo, ")
        strSQL.Append(" nmonto, ")
        strSQL.Append(" ccodins, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ctippag, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" ctermid, ")
        strSQL.Append(" cnrodoc, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cmoneda, ")
        strSQL.Append(" ccondic, ")
        strSQL.Append(" cconcep, ")
        strSQL.Append(" cdescob, ")
        strSQL.Append(" cnuming, ")
        strSQL.Append(" cbanco, ")
        strSQL.Append(" ccodctb, ")
        strSQL.Append(" ctrasctb, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cclipag, ")
        strSQL.Append(" mancomunad, ")
        strSQL.Append(" cnomcta, ")
        strSQL.Append(" cnumcta, ")
        strSQL.Append(" crotativa, ")
        strSQL.Append(" ndiaatr) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ")
        strSQL.Append(" @dfecpro, ")
        strSQL.Append(" @dfecsis, ")
        strSQL.Append(" @cnrocuo, ")
        strSQL.Append(" @nmonto, ")
        strSQL.Append(" @ccodins, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @ctippag, ")
        strSQL.Append(" @cestado, ")
        strSQL.Append(" @ctermid, ")
        strSQL.Append(" @cnrodoc, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @cmoneda, ")
        strSQL.Append(" @ccondic, ")
        strSQL.Append(" @cconcep, ")
        strSQL.Append(" @cdescob, ")
        strSQL.Append(" @cnuming, ")
        strSQL.Append(" @cbanco, ")
        strSQL.Append(" @ccodctb, ")
        strSQL.Append(" @ctrasctb, ")
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @cclipag, ")
        strSQL.Append(" @mancomunad, ")
        strSQL.Append(" @cnomcta, ")
        strSQL.Append(" @cnumcta, ")
        strSQL.Append(" @crotativa, ")
        strSQL.Append(" @ndiaatr) ")

        Dim args(27) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecpro
        args(2) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecsis
        args(3) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnrocuo
        args(4) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmonto
        args(5) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodins
        args(6) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodofi
        args(7) = New SqlParameter("@ctippag", SqlDbType.VarChar)
        args(7).Value = lEntidad.ctippag
        args(8) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(8).Value = lEntidad.cestado
        args(9) = New SqlParameter("@ctermid", SqlDbType.VarChar)
        args(9).Value = lEntidad.ctermid
        args(10) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.cnrodoc = Nothing, DBNull.Value, lEntidad.cnrodoc)
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu
        args(12) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(12).Value = lEntidad.dfecmod
        args(13) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(13).Value = lEntidad.cmoneda
        args(14) = New SqlParameter("@ccondic", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccondic
        args(15) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(15).Value = IIf(lEntidad.cconcep = Nothing, DBNull.Value, lEntidad.cconcep)
        args(16) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(16).Value = IIf(lEntidad.cdescob = Nothing, DBNull.Value, lEntidad.cdescob)
        args(17) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(17).Value = IIf(lEntidad.cnuming = Nothing, DBNull.Value, lEntidad.cnuming)
        args(18) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(18).Value = lEntidad.cbanco
        args(19) = New SqlParameter("@ccodctb", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodctb
        args(20) = New SqlParameter("@ctrasctb", SqlDbType.Bit)
        args(20).Value = IIf(lEntidad.ctrasctb = Nothing, DBNull.Value, lEntidad.ctrasctb)
        args(21) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(21).Value = lEntidad.cflag
        args(22) = New SqlParameter("@cclipag", SqlDbType.VarChar)
        args(22).Value = lEntidad.cclipag
        args(23) = New SqlParameter("@mancomunad", SqlDbType.VarChar)
        args(23).Value = lEntidad.mancomunad
        args(24) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(24).Value = lEntidad.cnomcta
        args(25) = New SqlParameter("@cnumcta", SqlDbType.VarChar)
        args(25).Value = lEntidad.cnumcta
        args(26) = New SqlParameter("@crotativa", SqlDbType.VarChar)
        args(26).Value = lEntidad.crotativa
        args(27) = New SqlParameter("@ndiaatr", SqlDbType.Decimal)
        args(27).Value = lEntidad.ndiaatr

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As kardex
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM kardex ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" AND cconcep = @cconcep ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cnuming = @cnuming ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrodoc
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = lEntidad.cconcep
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdescob
        args(4) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnuming

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As kardex
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI AND CREMCRE.CCODCTA = CREDKAR.CCODCTA AND")
        strSQL.Append(" CREMCRE.ccodcta = @ccodcta ")
        strSQL.Append(" AND CREDKAR.cdescob = @cdescob ")
        strSQL.Append(" AND CREDKAR.cnuming = @cnuming ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrodoc
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = lEntidad.cconcep
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdescob
        args(4) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnuming

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.dfecpro = IIf(.Item("dfecpro") Is DBNull.Value, Nothing, .Item("dfecpro"))
                lEntidad.dfecsis = IIf(.Item("dfecsis") Is DBNull.Value, Nothing, .Item("dfecsis"))
                lEntidad.cnrocuo = IIf(.Item("cnrocuo") Is DBNull.Value, Nothing, .Item("cnrocuo"))
                lEntidad.nmonto = IIf(.Item("nmonto") Is DBNull.Value, Nothing, .Item("nmonto"))
                lEntidad.ccodins = IIf(.Item("ccodins") Is DBNull.Value, Nothing, .Item("ccodins"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.ctippag = IIf(.Item("ctippag") Is DBNull.Value, Nothing, .Item("ctippag"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.ctermid = IIf(.Item("ctermid") Is DBNull.Value, Nothing, .Item("ctermid"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cmoneda = IIf(.Item("cmoneda") Is DBNull.Value, Nothing, .Item("cmoneda"))
                lEntidad.ccondic = IIf(.Item("ccondic") Is DBNull.Value, Nothing, .Item("ccondic"))
                lEntidad.cbanco = IIf(.Item("cbanco") Is DBNull.Value, Nothing, .Item("cbanco"))
                lEntidad.ccodctb = IIf(.Item("ccodctb") Is DBNull.Value, Nothing, .Item("ccodctb"))
                lEntidad.ctrasctb = IIf(.Item("ctrasctb") Is DBNull.Value, Nothing, .Item("ctrasctb"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cclipag = IIf(.Item("cclipag") Is DBNull.Value, Nothing, .Item("cclipag"))
                lEntidad.mancomunad = IIf(.Item("mancomunad") Is DBNull.Value, Nothing, .Item("mancomunad"))
                lEntidad.cnomcta = IIf(.Item("cnomcta") Is DBNull.Value, Nothing, .Item("cnomcta"))
                lEntidad.cnumcta = IIf(.Item("cnumcta") Is DBNull.Value, Nothing, .Item("cnumcta"))
                lEntidad.crotativa = IIf(.Item("crotativa") Is DBNull.Value, Nothing, .Item("crotativa"))
                lEntidad.ndiaatr = IIf(.Item("ndiaatr") Is DBNull.Value, Nothing, .Item("ndiaatr"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.ncapdes = IIf(.Item("ncapdes") Is DBNull.Value, Nothing, .Item("ncapdes"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As kardex
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnuming),0) + 1 ")
        strSQL.Append(" FROM kardex ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" AND cconcep = @cconcep ")
        strSQL.Append(" AND cdescob = @cdescob ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrodoc
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = lEntidad.cconcep
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdescob

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function ObtenerListaPorID(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cconcep As String, ByVal cdescob As String) As listakardex

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" AND cconcep = @cconcep ")
        strSQL.Append(" AND cdescob = @cdescob ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = cconcep
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = cdescob

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listakardex

        Try
            Do While dr.Read()
                Dim mEntidad As New kardex
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ctippag = IIf(dr("ctippag") Is DBNull.Value, Nothing, dr("ctippag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctermid = IIf(dr("ctermid") Is DBNull.Value, Nothing, dr("ctermid"))
                mEntidad.cnrodoc = cnrodoc
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.cconcep = cconcep
                mEntidad.cdescob = cdescob
                mEntidad.cnuming = IIf(dr("cnuming") Is DBNull.Value, Nothing, dr("cnuming"))
                mEntidad.cbanco = IIf(dr("cbanco") Is DBNull.Value, Nothing, dr("cbanco"))
                mEntidad.ccodctb = IIf(dr("ccodctb") Is DBNull.Value, Nothing, dr("ccodctb"))
                mEntidad.ctrasctb = IIf(dr("ctrasctb") Is DBNull.Value, Nothing, dr("ctrasctb"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cclipag = IIf(dr("cclipag") Is DBNull.Value, Nothing, dr("cclipag"))
                mEntidad.mancomunad = IIf(dr("mancomunad") Is DBNull.Value, Nothing, dr("mancomunad"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.cnumcta = IIf(dr("cnumcta") Is DBNull.Value, Nothing, dr("cnumcta"))
                mEntidad.crotativa = IIf(dr("crotativa") Is DBNull.Value, Nothing, dr("crotativa"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cconcep As String, ByVal cdescob As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" AND cconcep = @cconcep ")
        strSQL.Append(" AND cdescob = @cdescob ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnrodoc", cnrodoc)
        args(2) = New SqlParameter("@cconcep", cconcep)
        args(3) = New SqlParameter("@cdescob", cdescob)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function

    Public Function ObtenerDataSetPorcuenta(ByVal ccodcta As String, ByVal cestado As String) As DataSet

        'Dim strSQL As New StringBuilder
        'SelectTabla("Select climide.cnomcli,Credkar.ccodcta,")
        'strSQL.Append(" WHERE ccodcta = @ccodcta ")
        'strSQL.Append(" AND cestado = @cestado ")

        'Dim args(1) As SqlParameter
        'args(0) = New SqlParameter("@ccodcta", ccodcta)
        'args(1) = New SqlParameter("@cestado", cestado)

        'Dim ds As DataSet

        'ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        'Return ds

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT Climide.cnomcli,Cremcre.ncapdes,Credkar.ccodcta,Credkar.dfecsis,Credkar.cnrodoc, ")
        strSQL.Append(" Credkar.cCodctb,Ctbmcta.cdescrip,Cntamov.cnumcom,Cntamov.ndebe,Cntamov.nhaber")
        strSQL.Append(" FROM Climide INNER JOIN Cremcre ON climide.ccodcli = Cremcre.ccodcli ")
        strSQL.Append(" INNER JOIN Credkar ON Cremcre.ccodcta = Credkar.ccodcta INNER JOIN Cntamov ")
        strSQL.Append(" ON Credkar.ccodcta = Cntamov.cCodpres INNER JOIN Ctbmcta ")
        strSQL.Append(" ON Cntamov.ccodcta = Ctbmcta.cCodcta ")
        strSQL.Append(" WHERE Credkar.ccodcta = @ccodcta ")
        strSQL.Append(" AND Credkar.cestado = @cestado ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cestado", cestado)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByVal dfecsis As Date, ByVal cdescob As String, ByVal cnuming As String, ByVal cestado As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE CREMCRE.ccodcta = CREDKAR.CCODCTA ")
        strSQL.Append(" AND CREMCRE.ccodcli = CLIMIDE.ccodcli")
        strSQL.Append(" AND CREMCRE.ccodcta = @ccodcta ")
        strSQL.Append(" AND CREDKAR.dfecpro = @dfecsis ")
        strSQL.Append(" AND CREDKAR.cdescob = @cdescob ")
        strSQL.Append(" AND CREDKAR.cnumrec = @cnuming ")
        strSQL.Append(" AND CREDKAR.cestado = @cestado ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecsis", dfecsis)
        args(2) = New SqlParameter("@cdescob", cdescob)
        args(3) = New SqlParameter("@cnuming", cnuming)
        args(4) = New SqlParameter("@cestado", cestado)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function



    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT CREMCRE.ccodcta, ")
        strSQL.Append(" CREDKAR.dfecpro, ")
        strSQL.Append(" CREDKAR.dfecsis, ")
        strSQL.Append(" CREDKAR.cnrocuo, ")
        strSQL.Append(" CREDKAR.nmonto, ")
        strSQL.Append(" CREDKAR.ccodins, ")
        strSQL.Append(" CREDKAR.ccodofi, ")
        strSQL.Append(" CREDKAR.ctippag, ")
        strSQL.Append(" CREDKAR.cestado, ")
        strSQL.Append(" CREDKAR.ctermid, ")
        strSQL.Append(" CREDKAR.cnrodoc, ")
        strSQL.Append(" CREDKAR.ccodusu, ")
        strSQL.Append(" CREDKAR.dfecmod, ")
        strSQL.Append(" CREDKAR.cmoneda, ")
        strSQL.Append(" CREDKAR.ccondic, ")
        strSQL.Append(" CREDKAR.cconcep, ")
        strSQL.Append(" CREDKAR.cdescob, ")
        strSQL.Append(" CREDKAR.cnuming, CREDKAR.cnumrec, ")
        strSQL.Append(" CREDKAR.cbanco, ")
        strSQL.Append(" CREDKAR.ccodctb, ")
        strSQL.Append(" CREDKAR.ctrasctb, ")
        strSQL.Append(" CREDKAR.cflag, ")
        strSQL.Append(" CREDKAR.cclipag, ")
        strSQL.Append(" CREDKAR.mancomunad, ")
        strSQL.Append(" CREDKAR.cnomcta, ")
        strSQL.Append(" CREDKAR.cnumcta, ")
        strSQL.Append(" CREDKAR.crotativa, ")
        strSQL.Append(" CREDKAR.ndiaatr, ")
        strSQL.Append(" CREMCRE.ncapdes, ")
        strSQL.Append(" CREMCRE.ccodcli, ")
        strSQL.Append(" CLIMIDE.cnomcli, CLIMIDE.ccodcli ")
        strSQL.Append(" FROM  cremcre,credkar, climide ")
    End Sub
    ' todos los metodos estan sobrecargados
    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String) As listakardex
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cestado = ' ' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listakardex

        Try
            Do While dr.Read()
                Dim mEntidad As New kardex
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ctippag = IIf(dr("ctippag") Is DBNull.Value, Nothing, dr("ctippag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctermid = IIf(dr("ctermid") Is DBNull.Value, Nothing, dr("ctermid"))
                mEntidad.cnrodoc = IIf(dr("cnrodoc") Is DBNull.Value, Nothing, dr("cnrodoc"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.cconcep = IIf(dr("cconcep") Is DBNull.Value, Nothing, dr("cconcep"))
                mEntidad.cdescob = IIf(dr("cdescob") Is DBNull.Value, Nothing, dr("cdescob"))
                mEntidad.cnuming = IIf(dr("cnuming") Is DBNull.Value, Nothing, dr("cnuming"))
                mEntidad.cbanco = IIf(dr("cbanco") Is DBNull.Value, Nothing, dr("cbanco"))
                mEntidad.ccodctb = IIf(dr("ccodctb") Is DBNull.Value, Nothing, dr("ccodctb"))
                mEntidad.ctrasctb = IIf(dr("ctrasctb") Is DBNull.Value, Nothing, dr("ctrasctb"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cclipag = IIf(dr("cclipag") Is DBNull.Value, Nothing, dr("cclipag"))
                mEntidad.mancomunad = IIf(dr("mancomunad") Is DBNull.Value, Nothing, dr("mancomunad"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.cnumcta = IIf(dr("cnumcta") Is DBNull.Value, Nothing, dr("cnumcta"))
                mEntidad.crotativa = IIf(dr("crotativa") Is DBNull.Value, Nothing, dr("crotativa"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaatr = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ndiaatr = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String, ByVal cdescob As String) As listakardex
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cestado = ' ' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(1).Value = cdescob

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listakardex

        Try
            Do While dr.Read()
                Dim mEntidad As New kardex
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ctippag = IIf(dr("ctippag") Is DBNull.Value, Nothing, dr("ctippag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctermid = IIf(dr("ctermid") Is DBNull.Value, Nothing, dr("ctermid"))
                mEntidad.cnrodoc = IIf(dr("cnrodoc") Is DBNull.Value, Nothing, dr("cnrodoc"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.cconcep = IIf(dr("cconcep") Is DBNull.Value, Nothing, dr("cconcep"))
                mEntidad.cdescob = IIf(dr("cdescob") Is DBNull.Value, Nothing, dr("cdescob"))
                mEntidad.cnuming = IIf(dr("cnuming") Is DBNull.Value, Nothing, dr("cnuming"))
                mEntidad.cbanco = IIf(dr("cbanco") Is DBNull.Value, Nothing, dr("cbanco"))
                mEntidad.ccodctb = IIf(dr("ccodctb") Is DBNull.Value, Nothing, dr("ccodctb"))
                mEntidad.ctrasctb = IIf(dr("ctrasctb") Is DBNull.Value, Nothing, dr("ctrasctb"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cclipag = IIf(dr("cclipag") Is DBNull.Value, Nothing, dr("cclipag"))
                mEntidad.mancomunad = IIf(dr("mancomunad") Is DBNull.Value, Nothing, dr("mancomunad"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.cnumcta = IIf(dr("cnumcta") Is DBNull.Value, Nothing, dr("cnumcta"))
                mEntidad.crotativa = IIf(dr("crotativa") Is DBNull.Value, Nothing, dr("crotativa"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaatr = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ndiaatr = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListakardexPorCuenta(ByVal ccodcta As String) As listakardex
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE CREMCRE.ccodcta = @ccodcta ")
        strSQL.Append(" AND CREMCRE.cestado = ' ' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listakardex

        Try
            Do While dr.Read()
                Dim mEntidad As New kardex
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ctippag = IIf(dr("ctippag") Is DBNull.Value, Nothing, dr("ctippag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctermid = IIf(dr("ctermid") Is DBNull.Value, Nothing, dr("ctermid"))
                mEntidad.cnrodoc = IIf(dr("cnrodoc") Is DBNull.Value, Nothing, dr("cnrodoc"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.cconcep = IIf(dr("cconcep") Is DBNull.Value, Nothing, dr("cconcep"))
                mEntidad.cdescob = IIf(dr("cdescob") Is DBNull.Value, Nothing, dr("cdescob"))
                mEntidad.cnuming = IIf(dr("cnuming") Is DBNull.Value, Nothing, dr("cnuming"))
                mEntidad.cbanco = IIf(dr("cbanco") Is DBNull.Value, Nothing, dr("cbanco"))
                mEntidad.ccodctb = IIf(dr("ccodctb") Is DBNull.Value, Nothing, dr("ccodctb"))
                mEntidad.ctrasctb = IIf(dr("ctrasctb") Is DBNull.Value, Nothing, dr("ctrasctb"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cclipag = IIf(dr("cclipag") Is DBNull.Value, Nothing, dr("cclipag"))
                mEntidad.mancomunad = IIf(dr("mancomunad") Is DBNull.Value, Nothing, dr("mancomunad"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.cnumcta = IIf(dr("cnumcta") Is DBNull.Value, Nothing, dr("cnumcta"))
                mEntidad.crotativa = IIf(dr("crotativa") Is DBNull.Value, Nothing, dr("crotativa"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaatr = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ndiaatr = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String, ByVal dfecsis As Date) As listakardex
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND dfecsis = @dfecsis ")
        strSQL.Append(" AND cestado = ' ' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@dfecsis", SqlDbType.VarChar)
        args(1).Value = dfecsis

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listakardex

        Try
            Do While dr.Read()
                Dim mEntidad As New kardex
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ctippag = IIf(dr("ctippag") Is DBNull.Value, Nothing, dr("ctippag"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ctermid = IIf(dr("ctermid") Is DBNull.Value, Nothing, dr("ctermid"))
                mEntidad.cnrodoc = IIf(dr("cnrodoc") Is DBNull.Value, Nothing, dr("cnrodoc"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.cconcep = IIf(dr("cconcep") Is DBNull.Value, Nothing, dr("cconcep"))
                mEntidad.cdescob = IIf(dr("cdescob") Is DBNull.Value, Nothing, dr("cdescob"))
                mEntidad.cnuming = IIf(dr("cnuming") Is DBNull.Value, Nothing, dr("cnuming"))
                mEntidad.cbanco = IIf(dr("cbanco") Is DBNull.Value, Nothing, dr("cbanco"))
                mEntidad.ccodctb = IIf(dr("ccodctb") Is DBNull.Value, Nothing, dr("ccodctb"))
                mEntidad.ctrasctb = IIf(dr("ctrasctb") Is DBNull.Value, Nothing, dr("ctrasctb"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cclipag = IIf(dr("cclipag") Is DBNull.Value, Nothing, dr("cclipag"))
                mEntidad.mancomunad = IIf(dr("mancomunad") Is DBNull.Value, Nothing, dr("mancomunad"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.cnumcta = IIf(dr("cnumcta") Is DBNull.Value, Nothing, dr("cnumcta"))
                mEntidad.crotativa = IIf(dr("crotativa") Is DBNull.Value, Nothing, dr("crotativa"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaatr = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ndiaatr = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function

    Public Function ObtenerDataSetPorcuenta1(ByVal ccodcta As String, ByVal cpoliza As String, ByVal cnumdoc As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" Select distinct cntamov.dfeccnt,cntamov.ccodpres,cntamov.cnumcom,cntamov.ndebe,cntamov.nhaber,ctbmcta.ccodcta,ctbmcta.cdescrip,ctbdchq.cnomchq from ctbmcta")
        strSQL.Append(" INNER JOIN cntamov ON ctbmcta.ccodcta = cntamov.ccodcta INNER JOIN CTBDCHQ ON cntamov.cnumcom = ctbdchq.cnumcom ")
        strSQL.Append(" where cntamov.ccodpres = @ccodcta and cntamov.cpoliza = @cpoliza and cntamov.cnumdoc = @cnumdoc ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cpoliza", cpoliza)
        args(2) = New SqlParameter("@cnumdoc", cnumdoc)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorcuenta2(ByVal ccodcta As String, ByVal cpoliza As String, ByVal cnumdoc As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" Select cremcre.nmonapr, climide.cteldom, climide.cnudotr, climide.cnomcli,cremcre.ccodcli,cremcre.ccodcta,cremcre.ncapdes,cremcre.ngastos,cremcre.ncuoapr,")
        strSQL.Append(" cremcre.nmoncuo,cremcre.dfecvig,cntamov.cnumcom,ctbdchq.cnrochq, cretlin.cdeslin from Climide inner join Cremcre ON climide.ccodcli = cremcre.ccodcli ")
        strSQL.Append(" inner join Cretlin On cremcre.cnrolin = cretlin.cnrolin inner join cntamov ON cremcre.ccodcta = cntamov.ccodpres inner join ctbdchq On cntamov.cnumcom = ctbdchq.cnumcom ")
        strSQL.Append(" where cremcre.ccodcta = @ccodcta and cntamov.cpoliza = @cpoliza and cntamov.cnumdoc = @cnumdoc ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cpoliza", cpoliza)
        args(2) = New SqlParameter("@cnumdoc", cnumdoc)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorcuenta3(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cnumdoc As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" select max(cremsol.cnomgru) as cnomcli, ")
        strSQL.Append(" max(cremsol.ccodsol) as ccodcli, ")
        strSQL.Append(" ' ' as ccodcta, ")
        strSQL.Append(" sum(cremcre.ngastos) as ngastos, max(cremcre.ncuoapr) as ncuoapr, max(cremcre.dfecvig) as dfecvig,  ")
        strSQL.Append(" (select sum(cremcre.ncapdes) from cremcre where cremcre.ccodsol = @ccodcta and cremcre.dfecvig >= @dfecha and dfecvig <= @dfecha group by cremcre.ccodsol, cremcre.dfecvig) as ncapdes, ")
        strSQL.Append(" (select sum(cremcre.nmonapr) from cremcre where cremcre.ccodsol = @ccodcta and cremcre.dfecvig >= @dfecha and dfecvig <= @dfecha group by cremcre.ccodsol, cremcre.dfecvig) as nmonapr, ")
        strSQL.Append(" (select sum(cremcre.nmoncuo) from cremcre where cremcre.ccodsol = @ccodcta and cremcre.dfecvig >= @dfecha and dfecvig <= @dfecha group by cremcre.ccodsol, cremcre.dfecvig) as nmoncuo, ")
        strSQL.Append(" (select min(ctbdchq.cnumcom) from ctbdchq where ctbdchq.ccodsol = @ccodcta and dfeccnt2 >= @dfecha and dfeccnt2 <= @dfecha group by ctbdchq.ccodsol, ctbdchq.dfeccnt2) as cnumcom, ")
        strSQL.Append(" (select min(ctbdchq.cnrochq) from ctbdchq where ctbdchq.ccodsol = @ccodcta and dfeccnt2 >= @dfecha and dfeccnt2 <= @dfecha group by ctbdchq.ccodsol, ctbdchq.dfeccnt2) as cnrochq, ")
        strSQL.Append("  max(cretlin.cdeslin) as cdeslin ")
        strSQL.Append("  from cremcre, cremsol, cretlin ")
        strSQL.Append("  WHERE cremcre.ccodsol = cremsol.ccodsol ")
        strSQL.Append("  and   cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append("  and   cremcre.ccodsol =  @ccodcta ")
        strSQL.Append("  and   cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha  ")
        strSQL.Append("  group by cremcre.ccodsol, cremcre.dfecvig ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)
        args(2) = New SqlParameter("@cnumdoc", cnumdoc)



        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDatosparaRecibo(ByVal ccodcta As String, ByVal cnuming As String, ByVal cdescob As String, ByVal cnrodoc As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnuming = @cnuming ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cnrodoc =@cnrodoc ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnuming", cnuming)
        args(2) = New SqlParameter("@cdescob", cdescob)
        args(3) = New SqlParameter("@cnrodoc", cnrodoc)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

End Class
