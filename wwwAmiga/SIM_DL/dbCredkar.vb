Imports System.IO
Imports System.Text
Public Class dbCredkar
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credkar
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnuming =  "" _
            Or lEntidad.cnuming = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnuming = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credkar ")
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
        strSQL.Append(" AND ccondic = @ccondic ")

        Dim args(28) As SqlParameter
        args(0) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecpro
        args(1) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecsis
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo
        args(3) = New SqlParameter("@nmonto", SqlDbType.Decimal)
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
        args(18) = New SqlParameter("@mancomunad", SqlDbType.Decimal)
        args(18).Value = lEntidad.mancomunad
        args(19) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(19).Value = lEntidad.cnomcta
        args(20) = New SqlParameter("@cnumcta", SqlDbType.VarChar)
        args(20).Value = lEntidad.cnumcta
        args(21) = New SqlParameter("@crotativa", SqlDbType.VarChar)
        args(21).Value = lEntidad.crotativa
        args(22) = New SqlParameter("@ndiaatr", SqlDbType.VarChar)
        args(22).Value = lEntidad.ndiaatr
        args(23) = New SqlParameter("@ccodcta", SqlDbType.Decimal)
        args(23).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value,lEntidad.ccodcta)
        args(24) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(24).Value = IIf(lEntidad.cnrodoc = Nothing, DBNull.Value,lEntidad.cnrodoc)
        args(25) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(25).Value = IIf(lEntidad.cconcep = Nothing, DBNull.Value,lEntidad.cconcep)
        args(26) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(26).Value = IIf(lEntidad.cdescob = Nothing, DBNull.Value,lEntidad.cdescob)
        args(27) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(27).Value = IIf(lEntidad.cnuming = Nothing, DBNull.Value,lEntidad.cnuming)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credkar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO credkar ")
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
        strSQL.Append(" ndiaatr, lrecprov, cnumrec) ")
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
        strSQL.Append(" @ndiaatr, @lsolidario, @cnumrec) ")

        Dim args(29) As SqlParameter
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
        args(17).Value = IIf(lEntidad.cnuming = Nothing, "", lEntidad.cnuming)
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
        args(23) = New SqlParameter("@mancomunad", SqlDbType.Decimal)
        args(23).Value = lEntidad.mancomunad
        args(24) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(24).Value = lEntidad.cnomcta
        args(25) = New SqlParameter("@cnumcta", SqlDbType.VarChar)
        args(25).Value = lEntidad.cnumcta
        args(26) = New SqlParameter("@crotativa", SqlDbType.VarChar)
        args(26).Value = lEntidad.crotativa
        args(27) = New SqlParameter("@ndiaatr", SqlDbType.Decimal)
        args(27).Value = lEntidad.ndiaatr
        args(28) = New SqlParameter("@lsolidario", SqlDbType.Bit)
        args(28).Value = lEntidad.lsolidario
        args(29) = New SqlParameter("@cnumrec", SqlDbType.VarChar)
        args(29).Value = lEntidad.cnuming0

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credkar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credkar ")
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

        Dim lEntidad As credkar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
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
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As credkar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnuming),0) + 1 ")
        strSQL.Append(" FROM credkar ")
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

    Public Function Obtenercnrodoc(ByVal ccodcta As String) As String

        Dim strSQL As New StringBuilder
        Dim lcnrodoc As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(cnrodoc)+1 as cnrodoc")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        If ds.Tables(0).Rows.Count > 0 Then

            If IsDBNull(ds.Tables(0).Rows(0)("cnrodoc")) Then
                lcnrodoc = "0001"
            Else
                lcnrodoc = ds.Tables(0).Rows(0)("cnrodoc")
                lcnrodoc.Trim()
                tamano = lcnrodoc.Trim.Length
                For i = 1 To 4 - tamano
                    lcnrodoc = "0" & lcnrodoc
                Next
            End If
        End If

        Return lcnrodoc

    End Function

    Public Function ObtenerListaPorID(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cconcep As String, ByVal cdescob As String) As listacredkar

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

        Dim lista As New listacredkar

        Try
            Do While dr.Read()
                Dim mEntidad As New credkar
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
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String, ByVal cnuming As String, ByVal cdescob As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnuming = @cnuming ")
        strSQL.Append(" AND cdescob = @cdescob ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnuming", cnuming)
        args(2) = New SqlParameter("@cdescob", cdescob)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByVal cnuming As String, ByVal cdescob As String, ByVal cnrodoc As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnumrec = @cnuming ")
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

    Public Function ObtenerDataSetPorID1(ByVal ccodcta As String, ByVal cdescob As String, ByVal cestado As String, ByVal cnrodoc As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cestado = @cestado ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")


        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cestado", cestado)
        args(2) = New SqlParameter("@cdescob", cdescob)
        args(3) = New SqlParameter("@cnrodoc", cnrodoc)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cconcep As String, ByVal cdescob As String, ByRef ds As DataSet) As Integer

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

        Dim tables(0) As String
        tables(0) = New String("credkar")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
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
        strSQL.Append(" ndiaatr, cnumrec ")
        strSQL.Append(" FROM credkar ")

    End Sub

    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String) As listacredkar
        'modificado para que ordene por cnrodoc  para estado de cuenta

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta order by cnrodoc ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacredkar

        Try
            Do While dr.Read()
                Dim mEntidad As New credkar
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
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function DataSetPorID2(ByVal ccodcta As String, ByVal cDescob As String, ByVal cEstado As String) As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cEstado = @cEstado ")
        strSQL.Append(" ORDER BY cFlag ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cdescob", cDescob)
        args(2) = New SqlParameter("@cEstado", cEstado)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    'mirna
    Public Function ObtenerListafecha(ByVal ccodcta As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal cdescob As String) As listacredkar
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND dfecsis >=  @dfecha1 ")
        strSQL.Append(" AND dfecsis <=  @dfecha2 ")
        strSQL.Append(" AND cdescob =  @cdescob order by cnrodoc ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(1).Value = dfecha1
        args(2) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(2).Value = dfecha2
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = cdescob


        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacredkar

        Try
            Do While dr.Read()
                Dim mEntidad As New credkar
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
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListacnuming(ByVal ccodcta As String, ByVal cnuming As String) As listacredkar
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnuming =  @cnuming ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@cnuming", SqlDbType.DateTime)
        args(1).Value = cnuming


        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacredkar

        Try
            Do While dr.Read()
                Dim mEntidad As New credkar
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
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    'mirna
    Public Function DataSetPorID(ByVal ccodcta As String, ByVal cDescob As String, ByVal cEstado As String) As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = @cdescob ")
        strSQL.Append(" AND cEstado = @cEstado ")
        strSQL.Append(" ORDER BY cFlag ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cdescob", cDescob)
        args(2) = New SqlParameter("@cEstado", cEstado)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    Public Function Actualizar1(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credkar
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credkar ")
        strSQL.Append(" SET cestado = @cestado ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" AND cdescob = @cdescob ")


        Dim args(3) As SqlParameter

        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrodoc
        args(2) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdescob
        args(3) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodcta


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function Actualizar2(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credkar
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credkar ")
        strSQL.Append(" SET cestado = @cestado ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cnuming = @cnuming ")
        strSQL.Append(" AND cdescob = @cdescob ")


        Dim args(3) As SqlParameter

        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnuming
        args(2) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdescob
        args(3) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodcta


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function ObtenerDataSetPorunacuenta(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob <> 'D' ")
        strSQL.Append(" AND cestado = ' ' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("?ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function obtenerdatasetkarflat(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cestado = ' ' ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cconcep = 'CJ' ")
        strSQL.Append(" AND dfecsis >= @ldfecha ")
        strSQL.Append(" ORDER BY CREDKAR.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ldfecha", SqlDbType.DateTime)
        args(1).Value = ldfecha


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds


    End Function


    Public Function Actualizar_monto(ByVal ccodcta As String, ByVal nmonto As Double, ByVal ldfecvig As Date) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credkar ")
        strSQL.Append(" SET nmonto = @nmonto, ")
        strSQL.Append(" dfecsis = @ldfecvig ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'D' ")
        strSQL.Append(" AND cnrodoc = '0001' ")


        Dim args(2) As SqlParameter


        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(1).Value = nmonto
        args(2) = New SqlParameter("@ldfecvig", SqlDbType.DateTime)
        args(2).Value = ldfecvig


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function Eliminar_pagos(ByVal ccodcta As String, ByVal ldfecha As Date) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credkar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND dfecsis >= @ldfecha ")
        strSQL.Append(" AND cdescob = 'C' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ldfecha", SqlDbType.DateTime)
        args(1).Value = ldfecha

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetkardexflat(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cestado = ' ' ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND dfecsis > @ldfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(0).Value = ccodcta

        args(1) = New SqlParameter("@ldfecha", SqlDbType.DateTime)
        args(1).Value = ldfecha


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function DataSetPorcuenta_fecha(ByVal ccodcta As String, ByVal dfecha As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfecsis <= @dfecha order by ccodcta, dfecsis, cnrodoc")

        Dim args(0) As SqlParameter


        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha

        Try
            Dim ds As DataSet

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

            Return ds


        Catch ex As Exception
            Dim a As String
            a = ccodcta
        End Try

    End Function

    Public Function SelectKardex(ByVal strSQL As StringBuilder)
        strSQL.Append("select NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'E' ")
        strSQL.Append("WHEN 'C' THEN 'C' ")
        strSQL.Append("WHEN 'I' THEN 'I' ")
        strSQL.Append("WHEN 'P' THEN 'P' ")
        strSQL.Append("WHEN 'D' THEN 'D' ")
        strSQL.Append(" END AS Tipopago, ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append("INNER JOIN Credkar C ON B.cCodcta = C.cCodcta ")


    End Function

    Public Function ResumenKardex(ByVal dfecha As Date, ByVal ccodusu As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectKardex(strSQL)
        
        strSQL.Append("WHERE  C.CDESCOB = 'C' AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @dfecha AND C.DFECSIS <= @dfecha ")
        strSQL.Append("AND C.ccodusu >= @ccodusu  ")
        strSQL.Append("GROUP BY c.ctippag ")



        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodusu", SqlDbType.Char)
        args(1).Value = ccodusu

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function
    Public Function Obtiene_interes_pendiente(ByVal ccodcta As String, ByVal pdfecha As Date, ByVal cnrodoc As String, ByRef lnintpen As Double) As Double
        Dim strSQL As New StringBuilder
        Dim lnpendiente As Double
        lnpendiente = 0
        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'IN' ")
        strSQL.Append(" AND dfecsis = @pdfecha ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" group by ccodcta ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@pdfecha", SqlDbType.DateTime)
        args(1).Value = pdfecha
        args(2) = New SqlParameter("@cnrodoc", SqlDbType.Char)
        args(2).Value = cnrodoc

        Dim a As String
        a = strSQL.ToString

        Dim ds As DataSet
        Try

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count > 0 Then
                lnintpen = ds.Tables(0).Rows(0)("nmonto")
            End If
            ds.Clear()

        Catch ex As Exception
            lnpendiente = 0
        End Try
        Return lnpendiente

    End Function
    Public Function Obtiene_interesmora_pendiente(ByVal ccodcta As String, ByVal pdfecha As Date, ByVal cnrodoc As String, ByRef lnpagcta As Double) As Double
        Dim strSQL As New StringBuilder
        Dim lnpendientemor As Double
        lnpendientemor = 0
        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'MO' ")
        strSQL.Append(" AND dfecsis = @pdfecha ")
        strSQL.Append(" AND cnrodoc = @cnrodoc ")
        strSQL.Append(" group by ccodcta ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@pdfecha", SqlDbType.DateTime)
        args(1).Value = pdfecha
        args(2) = New SqlParameter("@cnrodoc", SqlDbType.Char)
        args(2).Value = cnrodoc

        Dim a As String
        a = strSQL.ToString

        Dim ds As DataSet
        Try

            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count > 0 Then
                lnpagcta = ds.Tables(0).Rows(0)("nmonto")
            End If
            ds.Clear()

        Catch ex As Exception
            lnpendientemor = 0
        End Try
        Return lnpendientemor

    End Function
    Public Function CapitalPagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'KP' ")
        strSQL.Append("AND  DFECSIS < @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lncappag As Double
            lncappag = ds.Tables(0).Rows(0)("nmonto")
            Return lncappag
        End If

    End Function
    Public Function UltimafechaProceso(ByVal ccodcta As String, ByVal dfecha As Date) As Date

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(dfecpro) as dfecpro ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append("AND  DFECpro <= @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return Today
        Else
            Dim ldfecult As Date
            ldfecult = ds.Tables(0).Rows(0)("dfecpro")
            Return ldfecult
        End If
    End Function
    Public Function kardexplus(ByVal pccodcta As String, ByVal dfecha As Date) As DataTable
        Dim strSQL As New StringBuilder
        strSQL.Append("Select credkar. * from credkar where CREDKAR.CCODCTA =@pccodcta  ")
        strSQL.Append(" AND CREDKAR.DFECSIS <= @dfecha AND CREDKAR.CESTADO = ' ' order by credkar.dfecpro ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@pccodcta", SqlDbType.VarChar)
        args(1).Value = pccodcta

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        dt = ds.Tables(0)
        Return dt
    End Function

    Public Function KardexPagado(ByVal pccodcta As String) As DataSet
        Dim strSQL As New StringBuilder

        SelectKardex(strSQL)

        strSQL.Append("WHERE  C.CDESCOB = 'C' AND C.cestado = ' ' ")
        strSQL.Append("AND C.ccodcta = @pcCodcta  ")
        strSQL.Append("GROUP BY c.cCodcta ")



        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@pcCodcta", SqlDbType.VarChar)
        args(0).Value = pccodcta


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function fxCalifica(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select CREDKAR.*, cremcre.ccontra, cremcre.ccondic as condicion from CREDKAR, cremcre where CREDKAR.cCodcta = @cCodcta ")
        strSQL.Append(" and cremcre.ccodcta = credkar.ccodcta ")
        strSQL.Append("and  CREDKAR.cDescob = 'C' AND CREDKAR.cestado = ' ' and  CREDKAR.cConcep ='CJ' ")
        strSQL.Append("order by CREDKAR.cnrodoc ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnrango1 As Integer = 0
        Dim lnrango2 As Integer = 0
        Dim lnrango3 As Integer = 0
        Dim lnpagos As Integer = 0
        Dim lndiaatr As Integer = 0
        Dim lccontra As String = ""
        Dim lccondic As String = ""

        lnpagos = ds.Tables(0).Rows.Count

        For Each fila In ds.Tables(0).Rows
            lndiaatr = ds.Tables(0).Rows(i)("ndiaatr")
            lccontra = IIf(IsDBNull(ds.Tables(0).Rows(i)("ccontra")), "N", ds.Tables(0).Rows(i)("ccontra"))
            lccondic = ds.Tables(0).Rows(i)("condicion")
            If lndiaatr <= 7 Then
                lnrango1 += 1
            ElseIf lndiaatr > 7 And lndiaatr <= 30 Then
                lnrango2 += 1
            Else
                lnrango3 += 1
            End If

            i += 1
        Next

        Dim lnpor1 As Double = 0
        Dim lnpor2 As Double = 0
        Dim lnpor3 As Double = 0

        if lnpagos > 0 then
            lnpor1 = Math.Round(100 * lnrango1 / lnpagos, 2)
            lnpor2 = Math.Round(100 * lnrango2 / lnpagos, 2)
            lnpor3 = Math.Round(100 * lnrango3 / lnpagos, 2)
        End If

        Dim lcCalif As String = ""
        If lccondic.Trim = "S" Then
            lcCalif = "G"
        Else
            If lccontra.Trim = "P" Or lccontra.Trim = "D" Or lccontra.Trim = "T" Then 'Prorrogado, novaDo, reesTructurado
                lcCalif = "E"
            ElseIf lccontra.Trim = "J" Then
                lcCalif = "F"
            Else
                If lnrango2 <= 0 And lnrango3 <= 0 And lnrango1 > 0 Then
                    lcCalif = "A1"
                ElseIf lnrango3 <= 0 And lnrango2 > 0 Then
                    lcCalif = "A2"
                ElseIf lnpor3 > 0 And lnpor3 <= 10 Then
                    lcCalif = "B1"
                ElseIf lnpor3 > 10 And lnpor3 <= 25 Then
                    lcCalif = "B2"
                ElseIf lnpor3 > 25 And lnpor3 <= 50 Then
                    lcCalif = "C"
                Else
                    lcCalif = "D"
                End If

            End If

        End If

        Return lcCalif
    End Function

    Public Function VerificaBoleta(ByVal cCodbco As String, ByVal cnuming As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cnuming from CREDKAR ")
        strSQL.Append("WHERE ltrim(rtrim(cnuming)) = @cnuming  and cEstado = ' ' ")
        
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(0).Value = cnuming.Trim

        args(1) = New SqlParameter("@cCodbco", SqlDbType.VarChar)
        args(1).Value = cCodbco.Trim


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnuming")) Then
                Return True
            Else
                Return False
            End If

        End If
    End Function

    '----------------------------------------------------------------
    Public Function Obtenercnrodocmax(ByVal ccodcta As String) As String

        Dim strSQL As New StringBuilder
        Dim lcnrodoc As String = ""
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(cnrodoc) as cnrodoc")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cDescob ='C' and cestado = ' ' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        If ds.Tables(0).Rows.Count > 0 Then

            If IsDBNull(ds.Tables(0).Rows(0)("cnrodoc")) Then
                lcnrodoc = ""
            Else
                lcnrodoc = ds.Tables(0).Rows(0)("cnrodoc")
            End If
        End If

        Return lcnrodoc

    End Function

    Public Function ObtenercnrodocmaxDes(ByVal ccodcta As String) As String

        Dim strSQL As New StringBuilder
        Dim lcnrodoc As String = ""
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(cnrodoc) as cnrodoc")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cDescob ='D' and cestado = ' ' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        If ds.Tables(0).Rows.Count > 0 Then

            If IsDBNull(ds.Tables(0).Rows(0)("cnrodoc")) Then
                lcnrodoc = ""
            Else
                lcnrodoc = ds.Tables(0).Rows(0)("cnrodoc")
            End If
        End If

        Return lcnrodoc

    End Function

    Public Function ValidaPagosRevertirDes(ByVal cCodsol As String, ByVal dfecha As Date) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append(" select sum(nmonto) as nmonto  from cremcre, credkar ")
        strSQL.Append(" where cremcre.ccodcta = credkar.ccodcta ")
        strSQL.Append(" and   cremcre.ccodsol = @cCodsol ")
        strSQL.Append(" and cremcre.dfecvig>=@dfecha and cremcre.dfecvig<=@dfecha ")
        strSQL.Append(" and   credkar.cconcep ='CJ' and credkar.cDescob = 'C' ")
        strSQL.Append(" and   credkar.cestado = ' ' group by cremcre.ccodsol ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lvalida As Boolean
        If ds.Tables(0).Rows.Count = 0 Then
            lvalida = True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
                lvalida = True
            Else
                If ds.Tables(0).Rows(0)("nmonto") = 0 Then
                    lvalida = True
                Else
                    lvalida = False
                End If

            End If

        End If
        Return lvalida

    End Function
    'Revierte Provision-------------------------------------------------------------------------->
    Public Function ProvisionaRevertir(ByVal cCodcta As String, ByVal cnrodoc As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nmonto FROM CREDKAR WHERE ")
        strSQL.Append(" cCodcta =@cCodcta and cNrodoc =@cnrodoc and cConcep = 'IN' and cDescob ='C' and cCondic = 'P' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc

        Dim ds As New DataSet
        Dim lnmonto As Double = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
           lnmonto = 0
        else
            lnmonto = IIf(IsDBNull(ds.Tables(0).Rows(0)("nmonto")), 0, ds.Tables(0).Rows(0)("nmonto"))
        End If
        Return lnmonto
    End Function

    Public Function RevierteProvision(ByVal cCodcta As String, ByVal nmonto As Double) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credpro SET nprovis = nprovis + @nmonto WHERE cCodcta = @cCodcta ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(1).Value = nmonto

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function RevierteProvisionMes(ByVal cCodcta As String, ByVal nmonto As Double) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credpro SET nprovis = nprovis + @nmonto, nprovan = nprovan + @nmonto ")
        strSQL.Append("  WHERE cCodcta = @cCodcta ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(1).Value = nmonto

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function UltimafechaProcesoGrupal(ByVal cCodsol As String) As Date

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(credkar.dfecpro) as dfecpro ")
        strSQL.Append(" FROM CREDKAR, CREMCRE ")
        strSQL.Append(" WHERE cremcre.ccodcta = credkar.ccodcta  ")
        strSQL.Append(" AND credkar.cEstado = ' ' ")
        strSQL.Append("AND  cremcre.ccodsol = @cCodsol and cremcre.cestado ='F' ")
        strSQL.Append(" group by cremcre.ccodsol ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return Today
        Else
            Dim ldfecult As Date
            ldfecult = ds.Tables(0).Rows(0)("dfecpro")
            Return ldfecult
        End If
    End Function
  

    Public Function ObtenerInteresAjustado(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cDescob ='C' and cestado = ' ' and cConcep ='IN'  ")
        strSQL.Append(" and cTippag ='P' group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        Dim ds As New DataSet
        Dim lnmonto As Double = 0


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lnmonto = 0
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
                lnmonto = 0
            Else
                lnmonto = ds.Tables(0).Rows(0)("nmonto")
            End If

        End If
        Return lnmonto

    End Function

    Public Function ObtenerMoraAjustado(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM credkar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cDescob ='C' and cestado = ' ' and cConcep ='MO'  ")
        strSQL.Append(" and cTippag ='P' group by cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        Dim ds As New DataSet
        Dim lnmonto As Double = 0


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lnmonto = 0
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
                lnmonto = 0
            Else
                lnmonto = ds.Tables(0).Rows(0)("nmonto")
            End If

        End If
        Return lnmonto

    End Function

    Public Function RecuperarAjuste(ByVal cCodcta As String, ByVal dfecha As Date, ByVal cnumrec As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cConcep,  cCodctb, cCodcta, nmonto FROM CREDKAR ")
        strSQL.Append("WHERE cCodcta = @cCodcta and dfecSis >= @dfecha and dfecsis <= @dfecha  ")
        strSQL.Append(" and cnumrec = @cnumrec and cDescob ='C' and cEstado = ' ' and cTippag ='P' ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)
        args(2) = New SqlParameter("@cnumrec", cnumrec)


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    '****************************************************Clase Temporal
    Public Function PagosaConstruir() As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append("select cCodcta, cnuming, cnrodoc, dfecpro, ")
        strSQL.Append("dfecsis, cestado from credkar where cestado ='X' and ")
        strSQL.Append("dfecsis>='01-04-2010' and cdescob ='C' ")
        strSQL.Append("and cConcep ='CJ' ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds


    End Function
    '****************************************************
    Public Function DesembolsosAplicados(ByVal ccodcta As String, ByVal dfecha As Date) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'D' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'KP' ")
        strSQL.Append("AND  DFECSIS < @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lncappag As Double
            lncappag = ds.Tables(0).Rows(0)("nmonto")
            Return lncappag
        End If

    End Function
    Public Function UltimafechaCobro(ByVal ccodcta As String, ByVal dfecha As Date, ByVal ctipgas As String, ByVal dfecvig As Date) As Date

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(dfecpro) as dfecpro ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND  dfecpro <= @dfecha ")
        strSQL.Append(" and cconcep = @ctipgas ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta
        args(2) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(2).Value = ctipgas


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return dfecvig
        Else
            Dim ldfecult As Date
            ldfecult = ds.Tables(0).Rows(0)("dfecpro")
            Return ldfecult
        End If
    End Function


    Public Function Pagoenelmes(ByVal ccodcta As String, ByVal dfecha As Date, ByVal ctipgas As String, ByVal dfecvig As Date) As Boolean

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(dfecpro) as dfecpro ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND  dfecpro <= @dfecha ")
        strSQL.Append(" and cconcep = @ctipgas ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta
        args(2) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(2).Value = ctipgas


        Dim ds As New DataSet
        Dim llpago As Boolean

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            llpago = False
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("dfecpro")) Then
                llpago = False
            Else
                llpago = True
            End If

        End If

        Return llpago
    End Function

    '------------------------<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>-----------------------
    Public Function AgregaraCaja(ByVal ccodusu As String, ByVal nsaldo As Decimal, ByVal dfecha As DateTime, ByVal ctipo As String, ByVal cnumcom As String, ByVal cbanco As String, ByVal ccodusu1 As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO CAJA(ccodusu, nsaldo, dfecha , ctipo, cnumcom, cbanco, ccodusu1, cestado) ")
        strSQL.Append("VALUES(@ccodusu, @nsaldo, @dfecha , @ctipo, @cnumcom,@cbanco, @ccodusu1, ' ') ")

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("@nsaldo", SqlDbType.Decimal)
        args(1).Value = nsaldo
        args(2) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(2).Value = dfecha
        args(3) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(3).Value = ctipo
        args(4) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(4).Value = cnumcom
        args(5) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(5).Value = cbanco
        args(6) = New SqlParameter("@ccodusu1", SqlDbType.VarChar)
        args(6).Value = ccodusu1


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function VerificaProcedeCaja(ByVal ccodusu As String, ByVal ctipo As String) As Boolean
        Dim strSQL As New StringBuilder

        strSQL.Append("Select ctipo FROM CAJA ")
        strSQL.Append("WHERE ccodusu = @ccodusu and (ctipo = 'A' or ctipo ='C' ) and CAJA.cestado <> 'X'  order by id desc ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu

        Dim ds As New DataSet


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lprocede As Boolean = True

        If ds.Tables(0).Rows.Count = 0 Then
            If ctipo = "C" Then
                lprocede = False 'no procede
            Else
                lprocede = True 'procede
            End If

        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ctipo")) Then
                If ctipo = "C" Then
                    lprocede = False 'no procede
                Else
                    lprocede = True 'procede
                End If
            Else
                Dim lctipo As String
                lctipo = ds.Tables(0).Rows(0)("ctipo")
                If ctipo.Trim = lctipo.Trim Then
                    'No procede
                    lprocede = False
                End If
            End If
        End If

        Return lprocede
    End Function
    Public Function ObtieneSaldodeCaja(ByVal ccodusu As String, ByVal ctipo As String) As Decimal
        Dim strSQL As New StringBuilder

        strSQL.Append("Select nsaldo FROM CAJA ")
        strSQL.Append("WHERE ccodusu = @ccodusu and ctipo = @ctipo order by dfecha desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo


        Dim ds As New DataSet


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnsaldo As Decimal = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nsaldo")) Then
            Else

                lnsaldo = ds.Tables(0).Rows(0)("nsaldo")
            End If
        End If

        Return lnsaldo
    End Function
    Public Function ObtieneFechayHoraCaja(ByVal ccodusu As String, ByVal ctipo As String) As DateTime
        Dim strSQL As New StringBuilder

        strSQL.Append("Select dfecha FROM CAJA ")
        strSQL.Append("WHERE ccodusu = @ccodusu and ctipo = @ctipo order by dfecha desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo


        Dim ds As New DataSet


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim ldfecha As DateTime = Now

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("dfecha")) Then
            Else

                ldfecha = ds.Tables(0).Rows(0)("dfecha")
            End If
        End If

        Return ldfecha
    End Function
    Public Function ResumenKardexdosfechas(ByVal ccodusu As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal choraini As String, ByVal chora As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectKardex(strSQL)

        strSQL.Append("WHERE  C.CDESCOB = 'C' AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @dfecini AND C.DFECSIS <= @dfecfin ")
        strSQL.Append("AND SUBSTRING ( CONVERT(char(38),  c.dfecmod,121), 12,8) >= @choraini AND SUBSTRING ( CONVERT(char(38),  c.dfecmod,121), 12,8) <= @chora ")
        strSQL.Append("AND C.ccodusu = @ccodusu  ")
        strSQL.Append("GROUP BY c.ctippag ")



        Dim a As String
        a = strSQL.ToString

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecini", SqlDbType.Date)
        args(0).Value = dfecini
        args(1) = New SqlParameter("@ccodusu", SqlDbType.Char)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@dfecfin", SqlDbType.Date)
        args(2).Value = dfecfin
        args(3) = New SqlParameter("@choraini", SqlDbType.Char)
        args(3).Value = choraini
        args(4) = New SqlParameter("@chora", SqlDbType.Char)
        args(4).Value = chora




        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function
    Public Function UltimadDocumentoProceso(ByVal ccodcta As String, ByVal dfecha As Date) As String

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(cnrodoc) as cnrodoc ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cEstado = ' ' and cDescob = 'C' ")
        strSQL.Append(" AND  DFECpro <= @dfecha  ")
        strSQL.Append(" and  (cnumcta = ' '   or cnumcta is null)")
        strSQL.Append(" and cnrodoc not in ")
        strSQL.Append(" (select cnumcta from credkar where ccodcta = @ccodcta")
        strSQL.Append(" and (cnumcta <> ' ')) ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return "0001"
        Else
            Dim lcnrodoc As String
            lcnrodoc = ds.Tables(0).Rows(0)("cnrodoc")
            Return lcnrodoc
        End If
    End Function
    Public Function UltimafechaCobroIntPendiente(ByVal ccodcta As String, ByVal dfecha As Date, ByVal ctipgas As String, ByVal dfecvig As Date) As Date

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(dfecpro) as dfecpro ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND  dfecpro <= @dfecha ")
        strSQL.Append(" and cconcep = @ctipgas and ccondic ='P' ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta
        args(2) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(2).Value = ctipgas


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return dfecvig
        Else
            Dim ldfecult As Date
            ldfecult = ds.Tables(0).Rows(0)("dfecpro")
            Return ldfecult
        End If
    End Function

    Public Function InteresPendientePagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'IN' and ccondic ='P' ")
        strSQL.Append(" AND  DFECSIS <= @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lnintpag As Double
            lnintpag = ds.Tables(0).Rows(0)("nmonto")
            Return lnintpag
        End If

    End Function
    Public Function KardexPagado2(ByVal pccodcta As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append("select NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append("INNER JOIN Credkar C ON B.cCodcta = C.cCodcta ")

        strSQL.Append("WHERE  C.CDESCOB = 'C' AND C.cestado = ' ' ")
        strSQL.Append("AND C.ccodcta = @pcCodcta  ")
        strSQL.Append("GROUP BY c.cCodcta ")



        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@pcCodcta", SqlDbType.VarChar)
        args(0).Value = pccodcta


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function InteresPagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'IN' ")
        strSQL.Append("AND  DFECSIS < @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lncappag As Double
            lncappag = ds.Tables(0).Rows(0)("nmonto")
            Return lncappag
        End If

    End Function
    Public Function UltimafechadePago(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cconcep As String, ByVal dfecvig As Date) As Date

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT MAX(dfecpro) as dfecpro ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append("AND  DFECpro <= @dfecha  ")
        strSQL.Append("and cConcep = @cconcep ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = cconcep.Trim


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return dfecvig
        Else
            Dim ldfecult As Date
            ldfecult = ds.Tables(0).Rows(0)("dfecpro")
            Return ldfecult
        End If
    End Function
    Public Function ObtenerUltimoPago(ByVal ccodcta As String, ByVal dfecha As Date) As DataTable

        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT a.* ")
        strSQL.Append("FROM CREDKAR a  ")
        strSQL.Append("WHERE a.ccodcta = @ccodcta  ")
        strSQL.Append("and a.cEstado = ' '  ")
        strSQL.Append("and  a.dfecpro <= @dfecha ")
        strSQL.Append("and a.cConcep = 'CJ' ")
        strSQL.Append("and a.dfecpro = (select MAX(dfecpro) from credkar where credkar.ccodcta = a.ccodcta and credkar.cdescob ='C' and  ")
        strSQL.Append("credkar.cestado =' ' and credkar.cconcep ='CJ' group by credkar.ccodcta )  ")


        Dim a As String
        a = strSQL.ToString

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds.Tables(0)
    End Function
    Public Function ServicioPagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = 'IN' and ccondic ='S' ")
        strSQL.Append(" AND  DFECSIS <= @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lnintpag As Double
            lnintpag = ds.Tables(0).Rows(0)("nmonto")
            Return lnintpag
        End If

    End Function
    Public Function ObtenerMontoPagado(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cconcep As String) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = 'C' ")
        strSQL.Append(" AND cEstado = ' ' ")
        strSQL.Append(" AND cconcep = @cconcep ")
        strSQL.Append("AND  dfecsis <= @dfecha ")
        strSQL.Append(" group by ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = cconcep

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lnmonto As Double
            lnmonto = ds.Tables(0).Rows(0)("nmonto")
            Return lnmonto
        End If

    End Function
    Public Function ObtenerUltimoPagosegunConcepto(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cconcep As String) As DataTable

        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT a.* ")
        strSQL.Append("FROM CREDKAR a  ")
        strSQL.Append("WHERE a.ccodcta = @ccodcta  ")
        strSQL.Append("and a.cEstado = ' '  ")
        strSQL.Append("and  a.dfecpro <= @dfecha ")
        strSQL.Append("and a.cConcep = @cconcep ")
        strSQL.Append("and a.dfecpro = (select MAX(dfecpro) from credkar where credkar.ccodcta = a.ccodcta and credkar.cdescob ='C' and  ")
        strSQL.Append("credkar.cestado =' ' and credkar.cconcep =@cconcep group by credkar.ccodcta )  ")


        Dim a As String
        a = strSQL.ToString

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = cconcep


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds.Tables(0)
    End Function
    Public Function ObtenerDeposito(ByVal ccodusu As String, ByVal dfecha As Date, ByVal ope As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT  CAJA.*, ")
        strSQL.Append(" cnumdoc = (select diario.cnumdoc from diario where caja.cnumcom = diario.cnumcom),  ")
        strSQL.Append(" cnombco= (select tabtbco.cnombco from tabtbco where caja.cbanco = tabtbco.ccodbco), ")
        If ope.Trim = "D" Then
            strSQL.Append(" ncontaE = (select cntamov.ndebe from cntamov, diario, tabtbco where caja.cnumcom = diario.cnumcom and diario.cnumcom = cntamov.cnumcom and cntamov.cflc =' ' and cntamov.ccodcta = tabtbco.ccodcta  ) ")
        ElseIf ope.Trim = "005" Then
            strSQL.Append(" ncontaE = (select cntamov.nhaber from cntamov, diario where caja.cnumcom = diario.cnumcom and diario.cnumcom = cntamov.cnumcom and cntamov.cflc =' '  and cntamov.nhaber >0 )  ")
        ElseIf ope.Trim = "016" Or ope.Trim = "003" Then
            strSQL.Append(" ncontaI = (select cntamov.ndebe from cntamov, diario where caja.cnumcom = diario.cnumcom and diario.cnumcom = cntamov.cnumcom and cntamov.cflc =' '  and cntamov.ndebe >0 )  ")
        End If
        strSQL.Append(" from CAJA ")
        strSQL.Append("WHERE CAJA.ctipo =@ope ")
        If ccodusu = "*" Then
        Else
            strSQL.Append(" and  CAJA.ccodusu = @ccodusu ")
        End If

        strSQL.Append(" and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha ")
        strSQL.Append(" and CAJA.cestado <> 'X' ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@ope", SqlDbType.VarChar)
        args(2).Value = ope

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function VerificaExisteArqueo(ByVal ccodusu As String, ByVal dfecha As Date) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * from CAJA ")
        strSQL.Append("WHERE CAJA.ctipo ='Q' and  CAJA.ccodusu = @ccodusu and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lverifica As Boolean = False
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lverifica = True
        End If

        Return lverifica
    End Function
    Public Function GrabaSaldoArqueo(ByVal ccodusu As String, ByVal dfecha As Date, ByVal nsaldo As Decimal) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CAJA set nsaldo = @nsaldo  ")
        strSQL.Append("WHERE CAJA.ctipo ='Q' and  CAJA.ccodusu = @ccodusu and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@nsaldo", SqlDbType.Decimal)
        args(2).Value = nsaldo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function ObtenerSaldoArqueo(ByVal ccodusu As String, ByVal dfecha As Date) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * from CAJA ")
        strSQL.Append("WHERE CAJA.ctipo ='Q' and  CAJA.ccodusu = @ccodusu and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lnsaldo As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nsaldo")) Then
            Else
                lnsaldo = ds.Tables(0).Rows(0)("nsaldo")
            End If

        End If

        Return lnsaldo
    End Function

    Public Function VerificaAperturaCaja(ByVal ccodusu As String, ByVal dfecha As Date) As Boolean
        Dim strSQL As New StringBuilder

        strSQL.Append("Select ctipo FROM CAJA ")
        strSQL.Append("WHERE ccodusu = @ccodusu and ctipo = 'A'  and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha  ")
        strSQL.Append(" and  CAJA.cestado <> 'X'")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        Dim ds As New DataSet


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lprocede As Boolean = False

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ctipo")) Then
            Else
                lprocede = True
            End If
        End If

        Return lprocede
    End Function

    Public Function VerificaProcedeReapertura(ByVal ccodusu As String, ByVal ctipo As String, ByVal dfecha As Date) As Boolean
        Dim strSQL As New StringBuilder

        strSQL.Append("Select ctipo FROM CAJA ")
        strSQL.Append("WHERE ccodusu = @ccodusu and (ctipo = 'A' or ctipo ='C' ) and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha and CAJA.cestado <> 'X'  order by id desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lprocede As Boolean = True

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ctipo")) Then
            Else
                Dim lctipo As String
                lctipo = ds.Tables(0).Rows(0)("ctipo")
                If ctipo.Trim = lctipo.Trim Then
                    'No procede
                    lprocede = False
                End If
            End If
        End If

        Return lprocede
    End Function
    Public Function ReaperturaCaja(ByVal ccodusu As String, ByVal dfecha As Date) As Integer 'Equivale a cancelar cierre de caja
        Dim strSQL As New StringBuilder
        strSQL.Append("update caja set cestado ='X'  ")
        strSQL.Append("WHERE ccodusu = @ccodusu  and cast(CAJA.dfecha as date) >= @dfecha and cast(CAJA.dfecha as date) <= @dfecha and ctipo ='C'   ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ExisteBoletaBanco(ByVal cnumdoc As String, ByVal cbanco As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("select DIARIO.cnumdoc from caja, diario ")
        strSQL.Append("where caja.cnumcom = diario.cnumcom and diario.cnumdoc = @cnumdoc and caja.cbanco = @cbanco and caja.cestado <> 'X'  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("cnumdoc", SqlDbType.VarChar)
        args(0).Value = cnumdoc
        args(1) = New SqlParameter("cbanco", SqlDbType.VarChar)
        args(1).Value = cbanco

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lexiste As Boolean = False

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnumdoc")) Then
            Else
                lexiste = True
            End If
        End If
        Return lexiste
    End Function

    Public Function ObtieneFechaCajaAnterior(ByVal ccodusu As String, ByVal dfecha1 As Date) As Date
        Dim strSQL As New StringBuilder

        strSQL.Append("Select cast(CAJA.dfecha as date) as dfecha FROM CAJA ")
        strSQL.Append("WHERE ccodusu = @ccodusu and (ctipo = 'A' or ctipo ='C' ) and CAJA.cestado <> 'X'  order by id desc ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim ldfecha As Date = dfecha1

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("dfecha")) Then
            Else
                ldfecha = ds.Tables(0).Rows(0)("dfecha")
            End If
        End If

        Return ldfecha
    End Function

    Public Function ObtenerMontoPagadoG(ByVal ccodsol As String, ByVal dfecha As Date, ByVal cconcep As String) As Double

        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT sum(credkar.nmonto) as nmonto ")
        strSQL.Append(" FROM CREDKAR, CREMCRE ")
        strSQL.Append(" WHERE credkar.ccodcta = cremcre.ccodcta ")
        strSQL.Append(" AND cremcre.ccodsol = @ccodsol  ")
        strSQL.Append(" AND credkar.cdescob = 'C' ")
        strSQL.Append(" AND credkar.cEstado = ' ' ")
        strSQL.Append(" AND credkar.cconcep = @cconcep ")
        strSQL.Append("AND  credkar.dfecsis <= @dfecha ")
        strSQL.Append(" group by credkar.ccodcta ")


        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(1).Value = ccodsol
        args(2) = New SqlParameter("@cconcep", SqlDbType.VarChar)
        args(2).Value = cconcep

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Dim lnmonto As Double
            lnmonto = ds.Tables(0).Rows(0)("nmonto")
            Return lnmonto
        End If

    End Function
    Public Function ValidaCajasCerradas(ByVal ccodofi As String, ByVal dfecha As String) As Integer
        Dim strSql As New StringBuilder
        Dim args(1) As SqlParameter
        Dim ds As New DataSet
        Dim valor As Integer = 0


        strSql.Append(" select  caja.* from caja ")
        strSql.Append(" inner join usuarios on  caja.ccodusu = usuarios.usuario and usuarios.ccodofi =@ccodofi  ")
        strSql.Append(" where  cast(caja.dfecha as date) >= @dfecha and cast(caja.dfecha as date) <=@dfecha ")
        strSql.Append(" and caja.cestado <> 'X'  order by caja.ccodusu, caja.id")
        
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@dfecha", SqlDbType.VarChar)
        args(1).Value = dfecha

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSql.ToString, args)

        If ds.Tables(0).Rows.Count = 0 Then
            valor = 0
        Else
            Dim lnape As Integer = 0
            Dim lncie As Integer = 0
            For Each fila As DataRow In ds.Tables(0).Rows
                If fila("ctipo") = "A" Then
                    lnape += 1
                ElseIf fila("ctipo") = "C" Then
                    lncie += 1
                End If
            Next
            If lnape <> lncie Then
                valor = 1
            Else
                valor = 0
            End If

        End If

        Return valor

    End Function

    Public Function ObtenerDepositoCaja(ByVal ccodusu As String, ByVal dfecha As Date, ByVal cbanco As String, ByVal cnumdoc As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select caja.cnumcom from caja, diario ")
        strSQL.Append("where caja.ccodusu = @ccodusu and caja.cbanco = @cbanco and diario.cnumdoc = @cnumdoc and cast(caja.dfecha as date) = @dfecha ")
        strSQL.Append("and diario.cnumcom = caja.cnumcom and caja.cestado <> 'X' ")
        Dim args(3) As SqlParameter
        Dim ds As New DataSet

        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(1).Value = cbanco
        args(2) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(2).Value = cnumdoc
        args(3) = New SqlParameter("@dfecha", SqlDbType.Date)
        args(3).Value = dfecha


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Dim lcnumcom As String
            lcnumcom = ds.Tables(0).Rows(0)("cnumcom")
            Return lcnumcom
        End If

    End Function
    Public Function RevierteDepositoCaja(ByVal cnumcom As String) As Integer 'Equivale a cancelar deposito
        Dim strSQL As New StringBuilder
        strSQL.Append("update caja set cestado ='X'  ")
        strSQL.Append("WHERE cnumcom = @cnumcom and ctipo ='D'   ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function Obtener_Saldo_inicial_Cuadre(ByVal ccodusu As String, ByVal dfecha As Date) As Decimal
        Dim lnsaldo As Decimal = 0
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Select nsaldo FROM CAJA  " & _
                                      "WHERE ccodusu = '" & ccodusu & "' and ctipo = 'A'  and " & _
                                      "cast(CAJA.dfecha as date) >= '" & dfecha & "' and cast(CAJA.dfecha as date) <= '" & dfecha & "'" & _
                                      " and  CAJA.cestado <> 'X' order by id desc "
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Saldo")
                For Each fila As DataRow In ds.Tables("Saldo").Rows
                    lnsaldo = fila("nsaldo")
                Next
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using
        Return lnsaldo
    End Function
    Public Function Obtener_Saldo_inicial_Cuadre_General(ByVal dfecha As Date) As Decimal
        Dim lnsaldo As Decimal = 0
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Select sum(nsaldo) as nsaldo FROM CAJA  " & _
                                      "WHERE ctipo = 'A'  and " & _
                                      "cast(CAJA.dfecha as date) >= '" & dfecha & "' and cast(CAJA.dfecha as date) <= '" & dfecha & "'" & _
                                      " and  CAJA.cestado <> 'X' group by cast(CAJA.dfecha as date) "
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Saldo")
                For Each fila As DataRow In ds.Tables("Saldo").Rows
                    lnsaldo = fila("nsaldo")
                Next
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using
        Return lnsaldo
    End Function
    Public Function GrabaReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, ByVal usuario As String, ByVal id_interno As String, _
                                                 ByVal id_operacion As String, ByVal valor_pagar As String, ByVal mensaje As String, _
                                                 ByVal id_reserva As String, ByVal fecha_vence_reserva As Date, ByVal hora_vence_reserva As String, _
                                                 ByVal codigo_mensaje As String, ByVal cestado As String) As Integer
        Using conneccion As New SqlConnection(Me.cnnStr)
            Dim command As New SqlCommand
            conneccion.Open()
            Try
                command.Connection = conneccion
                'Elimina si existe alguna reserva
                command.CommandText = "delete from ReservaRemesa where " & _
                                                             "id_integracion='" & id_integracion & "' and " & _
                                                             "id_pagador='" & id_pagador & "' and " & _
                                                             "id_interno='" & id_interno & "' and " & _
                                                             "cestado=' ' and " & _
                                                             "id_operacion='" & id_operacion & "' and " & _
                                                             "id_reserva='" & id_reserva & "'"
                command.ExecuteNonQuery()
                'Agrega Reserva
                command.CommandText = "insert into ReservaRemesa(id_integracion,   id_pagador, usuario,  id_interno,  id_operacion,  valor_pagar,   mensaje, " & _
                                                             " id_reserva,    fecha_vence_reserva,   hora_vence_reserva,  codigo_mensaje,  cestado) values('" & _
                                                             id_integracion & "','" & id_pagador & "','" & usuario & "','" & id_interno & "','" & id_operacion & "','" & valor_pagar & _
                                                             "','" & mensaje & "','" & id_reserva & "','" & Left(fecha_vence_reserva.ToString, 10) & "','" & hora_vence_reserva & "','" & _
                                                             codigo_mensaje & "','" & cestado & "')"
                command.ExecuteNonQuery()
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using

    End Function

    Public Function ReversaReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, ByVal usuario As String, ByVal id_interno As String, _
                                             ByVal id_operacion As String, ByVal valor_pagar As String, ByVal mensaje As String, _
                                             ByVal id_reserva As String, _
                                             ByVal codigo_mensaje As String, ByVal cestado As String) As Integer
        Using conneccion As New SqlConnection(Me.cnnStr)
            Dim command As New SqlCommand
            conneccion.Open()
            Try
                command.Connection = conneccion
                'Elimina si existe alguna reserva
                command.CommandText = "update ReservaRemesa set cestado='X' where " & _
                                                             "id_integracion='" & id_integracion & "' and " & _
                                                             "id_pagador='" & id_pagador & "' and " & _
                                                             "id_interno='" & id_interno & "' and " & _
                                                             "cestado<>'X' and " & _
                                                             "id_operacion='" & id_operacion & "' and " & _
                                                             "id_reserva='" & id_reserva & "'"
                command.ExecuteNonQuery()
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using

    End Function

    Public Function ObtieneReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, _
                                         ByVal id_operacion As String) As String
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim pid_reserva As String = ""
        Using conneccion As New SqlConnection(Me.cnnStr)

            conneccion.Open()
            Try
                command.Connection = conneccion
                'Elimina si existe alguna reserva
                command.CommandText = "Select * from ReservaRemesa  where " & _
                                                             "id_integracion='" & id_integracion & "' and " & _
                                                             "id_pagador='" & id_pagador & "' and " & _
                                                              "cestado<>'X' and " & _
                                                             "id_operacion='" & id_operacion & "'"

                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Reserva")
                For Each fila As DataRow In ds.Tables("Reserva").Rows
                    pid_reserva = fila("id_reserva")
                Next

            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using

        Return pid_reserva
    End Function
    Public Function VerificaReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, ByVal id_interno As String, _
                                     ByVal id_operacion As String) As Boolean
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lreserva As Boolean = False
        Using conneccion As New SqlConnection(Me.cnnStr)

            conneccion.Open()
            Try
                command.Connection = conneccion
                'Elimina si existe alguna reserva
                command.CommandText = "Select * from ReservaRemesa  where " & _
                                                             "id_integracion='" & id_integracion & "' and " & _
                                                             "id_pagador='" & id_pagador & "' and " & _
                                                             "id_interno='" & id_interno & "' and " & _
                                                             "cestado<>'X' and " & _
                                                             "id_operacion='" & id_operacion & "'"

                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Reserva")
                For Each fila As DataRow In ds.Tables("Reserva").Rows
                    lreserva = True
                Next

            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using

        Return lreserva
    End Function
    Public Function ObtieneIDInternoRemesa(ByVal id_integracion As String, ByVal id_pagador As String, _
                                     ByVal id_operacion As String) As String
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim pid_reserva As String = ""
        Using conneccion As New SqlConnection(Me.cnnStr)

            conneccion.Open()
            Try
                command.Connection = conneccion
                'Elimina si existe alguna reserva
                command.CommandText = "Select * from ReservaRemesa  where " & _
                                                             "id_integracion='" & id_integracion & "' and " & _
                                                             "id_pagador='" & id_pagador & "' and " & _
                                                              "cestado<>'X' and " & _
                                                             "id_operacion='" & id_operacion & "'"

                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Reserva")
                For Each fila As DataRow In ds.Tables("Reserva").Rows
                    pid_reserva = fila("id_interno")
                Next

            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using

        Return pid_reserva
    End Function

    Public Function Actualiza_Dispersion(ByVal ds As DataSet) As Integer


        Dim lnRetorno As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                For Each fila As DataRow In ds.Tables(0).Rows

                    command.CommandText = _
                                           " Update Credkar set ldispersa = 1" & _
                                           " Where cCodcta ='" & fila("cCodcta").ToString.Trim & "' and cestado <> 'X' and cdescob = 'D'"

                    command.CommandType = CommandType.Text

                    command.ExecuteNonQuery()
                Next

                lnRetorno = 1

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnRetorno

    End Function


    'Genera Archivo Dispersador
    Public Function Extrae_Archivo_Dispersador(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                               ByVal GCNOMINS As String, ByVal GCCTABCO As String) As ArrayList

        Dim lnRetorno As Integer = 0
        Dim ds As New DataSet
        Dim pdfecha As Date = pdfecfin
        Dim array_d As New ArrayList


        array_d.Add(0)    'Bandera si ocurre Error o pasa el proceso
        array_d.Add("")   'Path
        array_d.Add("")   'Nombre de Archivo
        array_d.Add(1)    'Evalua si no existen datos


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            Dim MyAdapter As New SqlDataAdapter

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try


                command.CommandText = _
                                        " Select b.ccodcta, a.cnomcli, b.dfecvig, d.nmonto as ncapdes, b.dfecven, a.id_ife from climide a" & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credkar d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " where b.cestado = 'F' and (b.dfecvig >= '" & pdfecini & "' and b.dfecvig <= '" & pdfecfin & "') " & _
                                        " and d.cdescob = 'D' and  d.cconcep = 'CJ'" & _
                                        " and isnull(d.ldispersa,0) = 0 and d.cestado<>'X' "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Data_Desembolsos")



                For Each fila As DataRow In ds.Tables("Data_Desembolsos").Rows
                    command.CommandText = _
                                           " Update Credkar set ldispersa = 1, dfecdispersa = getdate()" & _
                                           " Where cCodcta ='" & fila("cCodcta").ToString.Trim & "' and cestado <> 'X' and cdescob = 'D'"

                    command.CommandType = CommandType.Text

                    command.ExecuteNonQuery()
                Next


                '''''
                'Genera Archivo Dispersador, Evaluando si existen datos para generar el Archivo
                '''''

                If ds.Tables("Data_Desembolsos").Rows.Count = 0 Then
                    array_d.Item(3) = 0
                Else
                    'Variables para abrir el archivo en modo de escritura
                    Dim strStreamW As Stream
                    Dim strStreamWriter As StreamWriter
                    Dim ldfecha As Date = pdfecha
                    Dim ldfecha_proceso As Date
                    Dim lcdia_p As String = ""
                    Dim lcmes_p As String = ""
                    Dim lcano_p As String = ""

                    Dim lcdia As String = IIf(ldfecha.Day.ToString.Trim.Length = 1, "0" & ldfecha.Day.ToString, ldfecha.Day.ToString)
                    Dim lcmes As String = IIf(ldfecha.Month.ToString.Trim.Length = 1, "0" & ldfecha.Month.ToString, ldfecha.Month.ToString)
                    Dim lcano As String = ldfecha.Year.ToString.Trim
                    Dim lcnombre As String

                    lcnombre = lcdia & lcmes & lcano & ".txt"

                    Dim FilePath As String = "c:/txt/" & lcnombre


                    'Verifica si existe el archivo en el server para Eliminarlo
                    If System.IO.File.Exists(FilePath) Then
                        System.IO.File.Delete(FilePath)
                    End If

                    'Se abre el archivo y si este no existe se crea
                    strStreamW = File.OpenWrite(FilePath)
                    strStreamWriter = New StreamWriter(strStreamW, _
                                        System.Text.Encoding.ASCII)


                    'Analiza Fecha de Proceso para realizar la proyeccion
                    Dim lndia_ As Integer = ldfecha.DayOfWeek

                    Select Case lndia_
                        Case 4    'Jueves
                            ldfecha_proceso = pdfecha.AddDays(4)
                        Case 5    'Viernes  
                            ldfecha_proceso = pdfecha.AddDays(4)
                            'ldfecha_proceso = pdfecha.AddDays(5)
                        Case Else  'Otro Dia
                            ldfecha_proceso = pdfecha.AddDays(2)
                    End Select


                    lcdia_p = IIf(ldfecha_proceso.Day.ToString.Trim.Length = 1, "0" & ldfecha_proceso.Day.ToString, _
                                  ldfecha_proceso.Day.ToString)
                    lcmes_p = IIf(ldfecha_proceso.Month.ToString.Trim.Length = 1, "0" & ldfecha_proceso.Month.ToString, _
                                  ldfecha_proceso.Month.ToString)
                    lcano_p = ldfecha_proceso.Year.ToString.Trim


                    'Se traen los datos que necesitamos para el archivo
                    'TraerDatosArchivo retorna un dataset pero perfectamente
                    'podria ser cualquier otro tipo de objeto

                    Dim dr As DataRow
                    Dim ID_Empresa As String = "1000090541445"
                    Dim secuencia As String = "0001"
                    Dim nombre_Empresa As String = GCNOMINS
                    Dim Descrip_Archivo As String
                    Dim lcdecimal As String
                    Dim lntamano As Integer



                    Dim Tipo_Registro As String = "3"
                    Dim Tipo_Operacion As String = "07"
                    Dim Sucursal As String = "0870"
                    Dim Emisor As String = "48"
                    Dim Naturaleza As String = "09"
                    Dim pcMonto As String = ""
                    Dim Espacios As String = ""
                    Dim Espacios_0 As String = ""
                    Dim Espacios_1 As String = ""
                    Dim Espacios_2 As String = ""
                    Dim Espacios_3 As String = ""
                    Dim Espacios_4 As String = ""
                    Dim Espacios_5 As String = ""
                    Dim Beneficiario As String = ""
                    Dim Banco As String = "0002"
                    Dim Moneda As String = "001"
                    Dim pNoIFE As String = ""
                    Dim Dato_Banamex_1 As String = "1"
                    Dim Dato_Banamex_2 As String = "2"
                    Dim fecha_infor As String = lcdia & lcmes & lcano
                    Dim fecha_infor_proyec As String = lcdia_p & lcmes_p & lcano_p
                    Dim Otros_Banco = "00000000000099"

                    Dim Cierre_Banco = "0000"
                    Dim pnMonto_Total As Double
                    Dim pnRegistro_Total As Double
                    Dim Linea_Final As String = "4001"
                    Dim pcNoRegistro As String = ""
                    Dim pcMonto_Total As String = ""
                    Dim pcCargos As String = "000001"
                    Dim pcCtaBanco As String = "5783795"
                    Dim agencia As String = GCCTABCO
                    Dim lnEntero As Integer
                    Dim lndecimal As Integer
                    Dim n As Integer


                    Descrip_Archivo = "//MD" & fecha_infor
                    Descrip_Archivo = zeros(Descrip_Archivo.Trim, 20)
                    nombre_Empresa = zeros(nombre_Empresa.Trim, 36)

                    'Cantidad de Registros
                    If Not IsDBNull(ds.Tables(0).Compute("count(ccodcta)", "")) Then
                        pnRegistro_Total = ds.Tables(0).Compute("count(ccodcta)", "")
                    End If

                    pcNoRegistro = pnRegistro_Total.ToString.Trim
                    pcNoRegistro = fxStrZero(pcNoRegistro.Trim, 6)


                    'Suma el Monto Total a Dispersar
                    If Not IsDBNull(ds.Tables(0).Compute("sum(ncapdes)", "")) Then
                        pnMonto_Total = ds.Tables(0).Compute("sum(ncapdes)", "")
                    End If

                    lnEntero = Math.Truncate(pnMonto_Total)
                    'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

                    lndecimal = ExtraeDecimales(lnEntero.ToString.Trim)

                    'Convertira a 2 digitos los decimales
                    lcdecimal = lndecimal.ToString.Trim
                    lntamano = lcdecimal.Length
                    For n = 1 To 2 - lntamano
                        lcdecimal = "0" + lcdecimal
                    Next n

                    pcMonto_Total = lnEntero.ToString.Trim + lcdecimal

                    pcMonto_Total = fxStrZero(pcMonto_Total.Trim, 18)
                    pcCtaBanco = fxStrZero(pcCtaBanco.Trim, 20)
                    agencia = fxStrZero(agencia.Trim, 4)
                    pcCtaBanco = fxStrZero(pcCtaBanco.Trim, 20)

                    Espacios_0 = zeros(Espacios_0.Trim, 40)
                    Espacios_5 = zeros(Espacios_5.Trim, 20)

                    'Inserta Primera Linea
                    'strStreamWriter.WriteLine(ID_Empresa.ToString.Trim & fecha_infor & secuencia & nombre_Empresa & Descrip_Archivo & _
                    '                          Naturaleza & Espacios_0 & "B01")

                    strStreamWriter.WriteLine("1000090541445" & fecha_infor & secuencia & nombre_Empresa & Descrip_Archivo & _
                                              Naturaleza & Espacios_0 & "B01")



                    'Insertar Linea No 2
                    strStreamWriter.WriteLine(Dato_Banamex_2 & Dato_Banamex_1 & Moneda & pcMonto_Total & "01" & agencia & _
                                              pcCtaBanco & Espacios_5)


                    For Each dr In ds.Tables(0).Rows

                        'Convirtiendo Longitud de Campos
                        Emisor = zeros(Emisor.Trim, 16)


                        lnEntero = Math.Truncate(dr("ncapdes"))
                        'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

                        lndecimal = ExtraeDecimales(lnEntero.ToString.Trim)

                        'Convertira a 2 digitos los decimales
                        lcdecimal = lndecimal.ToString.Trim
                        lntamano = lcdecimal.Length
                        For n = 1 To 2 - lntamano
                            lcdecimal = "0" + lcdecimal
                        Next n

                        pcMonto = lnEntero.ToString.Trim + "." + lcdecimal


                        'pcMonto = Format(Math.Round(dr("ncapdes"), 2), "#########.00")
                        pcMonto = fxStrZero_Alfa(pcMonto.Trim, 20)
                        Espacios = zeros(Espacios.Trim, 34)
                        dr("cnomcli") = dr("cnomcli").ToString.Replace("Ñ", "N")
                        Beneficiario = zeros(dr("cnomcli").ToString.Trim, 55)
                        Espacios_1 = zeros(Espacios_1.Trim, 40)
                        Espacios_2 = zeros(Espacios_2.Trim, 6)
                        pNoIFE = zeros_Derecha(dr("id_ife").ToString.Trim, 20)
                        Dato_Banamex_1 = zeros(Dato_Banamex_1, 10)
                        Dato_Banamex_2 = zeros(Dato_Banamex_2, 10)
                        Espacios_3 = zeros(Espacios_3.Trim, 13)
                        Espacios_4 = zeros(Espacios_4.Trim, 31)

                        'Escribimos la línea en el achivo de texto
                        strStreamWriter.WriteLine(Tipo_Registro & Tipo_Operacion & Sucursal & Emisor & pcMonto & Espacios & _
                                                  Beneficiario & Espacios_1 & Banco & Espacios_2 & Moneda & "1" & pNoIFE & Dato_Banamex_1 & _
                                                  Dato_Banamex_2 & fecha_infor_proyec & Espacios_3 & Otros_Banco & Espacios_4 & Cierre_Banco)

                    Next


                    'Agrega fila final
                    strStreamWriter.WriteLine(Linea_Final & pcNoRegistro & pcMonto_Total & pcCargos & pcMonto_Total)

                    strStreamWriter.Close()

                    'Parametros de Salida
                    array_d.Item(1) = FilePath        'Path
                    array_d.Item(2) = lcnombre.Trim   'Nombre de Archivo

                End If

                ' Attempt to commit the transaction.
                transaction.Commit()

                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                array_d.Item(0) = 1      'Bandera si ocurre Error o pasa el proceso                


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using

        Return array_d

    End Function


    Public Function Extrae_Archivo_Dispersador_Garantias(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                        ByVal GCNOMINS As String, ByVal GCCTABCO As String) As ArrayList

        Dim lnRetorno As Integer = 0
        Dim ds As New DataSet
        Dim pdfecha As Date = pdfecfin
        Dim array_d As New ArrayList


        array_d.Add(0)    'Bandera si ocurre Error o pasa el proceso
        array_d.Add("")   'Path
        array_d.Add("")   'Nombre de Archivo
        array_d.Add(1)    'Evalua si no existen datos


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            Dim MyAdapter As New SqlDataAdapter

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try


                command.CommandText = _
                                        " Select b.ccodcta, a.cnomcli, b.dfecvig, d.nmonto as ncapdes, b.dfecven, a.id_ife from climide a" & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join Dispersa_Garant d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " where (d.dfecsis >= '" & pdfecini & "' and d.dfecsis <= '" & pdfecfin & "') " & _
                                        " and isnull(d.ldispersa,0) = 0 "


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Data_Desembolsos")



                For Each fila As DataRow In ds.Tables("Data_Desembolsos").Rows
                    command.CommandText = _
                                           " Update Dispersa_Garant set ldispersa = 1, dfecdispersa = getdate()" & _
                                           " Where cCodcta ='" & fila("cCodcta").ToString.Trim & "'"

                    command.CommandType = CommandType.Text

                    command.ExecuteNonQuery()
                Next


                '''''
                'Genera Archivo Dispersador, Evaluando si existen datos para generar el Archivo
                '''''

                If ds.Tables("Data_Desembolsos").Rows.Count = 0 Then
                    array_d.Item(3) = 0
                Else
                    'Variables para abrir el archivo en modo de escritura
                    Dim strStreamW As Stream
                    Dim strStreamWriter As StreamWriter
                    Dim ldfecha As Date = pdfecha
                    Dim ldfecha_proceso As Date
                    Dim lcdia_p As String = ""
                    Dim lcmes_p As String = ""
                    Dim lcano_p As String = ""

                    Dim lcdia As String = IIf(ldfecha.Day.ToString.Trim.Length = 1, "0" & ldfecha.Day.ToString, ldfecha.Day.ToString)
                    Dim lcmes As String = IIf(ldfecha.Month.ToString.Trim.Length = 1, "0" & ldfecha.Month.ToString, ldfecha.Month.ToString)
                    Dim lcano As String = ldfecha.Year.ToString.Trim
                    Dim lcnombre As String

                    lcnombre = lcdia & lcmes & lcano & ".txt"

                    Dim FilePath As String = "c:/txt/" & lcnombre


                    'Verifica si existe el archivo en el server para Eliminarlo
                    If System.IO.File.Exists(FilePath) Then
                        System.IO.File.Delete(FilePath)
                    End If

                    'Se abre el archivo y si este no existe se crea
                    strStreamW = File.OpenWrite(FilePath)
                    strStreamWriter = New StreamWriter(strStreamW, _
                                        System.Text.Encoding.ASCII)


                    'Analiza Fecha de Proceso para realizar la proyeccion
                    Dim lndia_ As Integer = ldfecha.DayOfWeek

                    Select Case lndia_
                        Case 4    'Jueves
                            ldfecha_proceso = pdfecha.AddDays(4)
                        Case 5    'Viernes  
                            ldfecha_proceso = pdfecha.AddDays(4)
                            'ldfecha_proceso = pdfecha.AddDays(5)
                        Case Else  'Otro Dia
                            ldfecha_proceso = pdfecha.AddDays(2)
                    End Select


                    lcdia_p = IIf(ldfecha_proceso.Day.ToString.Trim.Length = 1, "0" & ldfecha_proceso.Day.ToString, _
                                  ldfecha_proceso.Day.ToString)
                    lcmes_p = IIf(ldfecha_proceso.Month.ToString.Trim.Length = 1, "0" & ldfecha_proceso.Month.ToString, _
                                  ldfecha_proceso.Month.ToString)
                    lcano_p = ldfecha_proceso.Year.ToString.Trim


                    'Se traen los datos que necesitamos para el archivo
                    'TraerDatosArchivo retorna un dataset pero perfectamente
                    'podria ser cualquier otro tipo de objeto

                    Dim dr As DataRow
                    Dim ID_Empresa As String = "1000090541445"
                    Dim secuencia As String = "0001"
                    Dim nombre_Empresa As String = GCNOMINS
                    Dim Descrip_Archivo As String
                    Dim lcdecimal As String
                    Dim lntamano As Integer



                    Dim Tipo_Registro As String = "3"
                    Dim Tipo_Operacion As String = "07"
                    Dim Sucursal As String = "0870"
                    Dim Emisor As String = "48"
                    Dim Naturaleza As String = "09"
                    Dim pcMonto As String = ""
                    Dim Espacios As String = ""
                    Dim Espacios_0 As String = ""
                    Dim Espacios_1 As String = ""
                    Dim Espacios_2 As String = ""
                    Dim Espacios_3 As String = ""
                    Dim Espacios_4 As String = ""
                    Dim Espacios_5 As String = ""
                    Dim Beneficiario As String = ""
                    Dim Banco As String = "0002"
                    Dim Moneda As String = "001"
                    Dim pNoIFE As String = ""
                    Dim Dato_Banamex_1 As String = "1"
                    Dim Dato_Banamex_2 As String = "2"
                    Dim fecha_infor As String = lcdia & lcmes & lcano
                    Dim fecha_infor_proyec As String = lcdia_p & lcmes_p & lcano_p
                    Dim Otros_Banco = "00000000000099"

                    Dim Cierre_Banco = "0000"
                    Dim pnMonto_Total As Double
                    Dim pnRegistro_Total As Double
                    Dim Linea_Final As String = "4001"
                    Dim pcNoRegistro As String = ""
                    Dim pcMonto_Total As String = ""
                    Dim pcCargos As String = "000001"
                    Dim pcCtaBanco As String = "5783795"
                    Dim agencia As String = GCCTABCO
                    Dim lnEntero As Integer
                    Dim lndecimal As Integer
                    Dim n As Integer


                    Descrip_Archivo = "//MD" & fecha_infor
                    Descrip_Archivo = zeros(Descrip_Archivo.Trim, 20)
                    nombre_Empresa = zeros(nombre_Empresa.Trim, 36)

                    'Cantidad de Registros
                    If Not IsDBNull(ds.Tables(0).Compute("count(ccodcta)", "")) Then
                        pnRegistro_Total = ds.Tables(0).Compute("count(ccodcta)", "")
                    End If

                    pcNoRegistro = pnRegistro_Total.ToString.Trim
                    pcNoRegistro = fxStrZero(pcNoRegistro.Trim, 6)


                    'Suma el Monto Total a Dispersar
                    If Not IsDBNull(ds.Tables(0).Compute("sum(ncapdes)", "")) Then
                        pnMonto_Total = ds.Tables(0).Compute("sum(ncapdes)", "")
                    End If

                    lnEntero = Math.Truncate(pnMonto_Total)
                    'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

                    lndecimal = ExtraeDecimales(lnEntero.ToString.Trim)

                    'Convertira a 2 digitos los decimales
                    lcdecimal = lndecimal.ToString.Trim
                    lntamano = lcdecimal.Length
                    For n = 1 To 2 - lntamano
                        lcdecimal = "0" + lcdecimal
                    Next n

                    pcMonto_Total = lnEntero.ToString.Trim + lcdecimal

                    pcMonto_Total = fxStrZero(pcMonto_Total.Trim, 18)
                    pcCtaBanco = fxStrZero(pcCtaBanco.Trim, 20)
                    agencia = fxStrZero(agencia.Trim, 4)
                    pcCtaBanco = fxStrZero(pcCtaBanco.Trim, 20)

                    Espacios_0 = zeros(Espacios_0.Trim, 40)
                    Espacios_5 = zeros(Espacios_5.Trim, 20)

                    'Inserta Primera Linea
                    'strStreamWriter.WriteLine(ID_Empresa.ToString.Trim & fecha_infor & secuencia & nombre_Empresa & Descrip_Archivo & _
                    '                          Naturaleza & Espacios_0 & "B01")

                    strStreamWriter.WriteLine("1000090541445" & fecha_infor & secuencia & nombre_Empresa & Descrip_Archivo & _
                                              Naturaleza & Espacios_0 & "B01")



                    'Insertar Linea No 2
                    strStreamWriter.WriteLine(Dato_Banamex_2 & Dato_Banamex_1 & Moneda & pcMonto_Total & "01" & agencia & _
                                              pcCtaBanco & Espacios_5)


                    For Each dr In ds.Tables(0).Rows

                        'Convirtiendo Longitud de Campos
                        Emisor = zeros(Emisor.Trim, 16)


                        lnEntero = Math.Truncate(dr("ncapdes"))
                        'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

                        lndecimal = ExtraeDecimales(lnEntero.ToString.Trim)

                        'Convertira a 2 digitos los decimales
                        lcdecimal = lndecimal.ToString.Trim
                        lntamano = lcdecimal.Length
                        For n = 1 To 2 - lntamano
                            lcdecimal = "0" + lcdecimal
                        Next n

                        pcMonto = lnEntero.ToString.Trim + "." + lcdecimal


                        'pcMonto = Format(Math.Round(dr("ncapdes"), 2), "#########.00")
                        pcMonto = fxStrZero_Alfa(pcMonto.Trim, 20)
                        Espacios = zeros(Espacios.Trim, 34)
                        dr("cnomcli") = dr("cnomcli").ToString.Replace("Ñ", "N")
                        Beneficiario = zeros(dr("cnomcli").ToString.Trim, 55)
                        Espacios_1 = zeros(Espacios_1.Trim, 40)
                        Espacios_2 = zeros(Espacios_2.Trim, 6)
                        pNoIFE = zeros_Derecha(dr("id_ife").ToString.Trim, 20)
                        Dato_Banamex_1 = zeros(Dato_Banamex_1, 10)
                        Dato_Banamex_2 = zeros(Dato_Banamex_2, 10)
                        Espacios_3 = zeros(Espacios_3.Trim, 13)
                        Espacios_4 = zeros(Espacios_4.Trim, 31)

                        'Escribimos la línea en el achivo de texto
                        strStreamWriter.WriteLine(Tipo_Registro & Tipo_Operacion & Sucursal & Emisor & pcMonto & Espacios & _
                                                  Beneficiario & Espacios_1 & Banco & Espacios_2 & Moneda & "1" & pNoIFE & Dato_Banamex_1 & _
                                                  Dato_Banamex_2 & fecha_infor_proyec & Espacios_3 & Otros_Banco & Espacios_4 & Cierre_Banco)

                    Next


                    'Agrega fila final
                    strStreamWriter.WriteLine(Linea_Final & pcNoRegistro & pcMonto_Total & pcCargos & pcMonto_Total)

                    strStreamWriter.Close()

                    'Parametros de Salida
                    array_d.Item(1) = FilePath        'Path
                    array_d.Item(2) = lcnombre.Trim   'Nombre de Archivo

                End If

                ' Attempt to commit the transaction.
                transaction.Commit()

                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                array_d.Item(0) = 1      'Bandera si ocurre Error o pasa el proceso                


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using

        Return array_d

    End Function


    Public Function zeros(ByVal valor As String, ByVal nlong As Integer) As String
        Dim tamano As Integer
        Dim lcvalor As String
        lcvalor = valor.Trim
        Dim i As Integer
        tamano = valor.Trim.Length
        If tamano >= nlong Then
            lcvalor = Left(valor.Trim, nlong)
        Else
            For i = 1 To nlong - tamano
                lcvalor = lcvalor & " "
            Next
        End If

        Return lcvalor
    End Function

    Public Function zeros_Derecha(ByVal valor As String, ByVal nlong As Integer) As String
        Dim tamano As Integer
        Dim lcvalor As String
        lcvalor = valor.Trim
        Dim i As Integer
        tamano = valor.Trim.Length
        If tamano >= nlong Then
            lcvalor = Left(valor.Trim, nlong)
        Else
            For i = 1 To nlong - tamano
                lcvalor = lcvalor & "0"
            Next
        End If

        Return lcvalor
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

    Public Function fxStrZero_Alfa(ByVal pnParameter As String, ByVal pnNumDig As Integer) As String
        Dim lcDigConv As String
        Dim lnLongDat As Integer
        Dim k As Integer
        lnLongDat = pnParameter.Trim.Length
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


    'Esta funcion saca la parte decimal a parti de un string

    Public Function ExtraeDecimales(ByVal Parametro As String) As Double
        Dim x As Integer
        Dim Longit As Integer
        Dim i As Integer
        Dim lnResulta As Double

        Longit = Parametro.Length



        For x = 0 To Parametro.Length - 1
            If Parametro.Substring(x, 1) = "." Then
                x += 1
                Longit = Longit - x
                lnResulta = Double.Parse(Parametro.Substring(x, Longit))
                Exit For
            End If
        Next

        Return lnResulta

    End Function



    Public Function Genera_rutina_Exporta_Asientos(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                   ByVal gnIVA As Double) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False
        Dim dr As DataRow
        Dim dt As New DataTable("Detalle_Asiento")

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                dt.Clear()
                'Agregando la Encabezado del Desconectado
                dt.Columns.Add("cnomcli", Type.GetType("System.String"))
                dt.Columns.Add("cCodcta", Type.GetType("System.String"))
                dt.Columns.Add("No_folio", Type.GetType("System.String"))
                dt.Columns.Add("tipo_Doc", Type.GetType("System.String"))
                dt.Columns.Add("dfecsis", Type.GetType("System.DateTime"))
                dt.Columns.Add("ccodofi", Type.GetType("System.String"))
                dt.Columns.Add("tipo_Asiento", Type.GetType("System.String"))
                dt.Columns.Add("valor_1", Type.GetType("System.Decimal"))
                dt.Columns.Add("valor_Iva", Type.GetType("System.Decimal"))
                dt.Columns.Add("valor_Imp", Type.GetType("System.Decimal"))
                dt.Columns.Add("valor_Total", Type.GetType("System.Decimal"))


                ds_Trab.Tables.Add(dt)


                'Extrae los pagos
                command.CommandText = _
                                        " Select d.ccodcta, a.cnomcli, d.dfecsis, SUM(d.nmonto) as nmonto, " & _
                                        " cconcep = case d.cconcep  when 'KP' then 'CAPITAL' " & _
                                        " when 'IN' then 'INTERES' " & _
                                        " when 'MO' then 'MORA' " & _
                                        " when '08' then 'IVA INTERES' " & _
                                        " when 'IM' then 'IVA MORA' " & _
                                        " when 'EX' then 'EXCEDENTE DE CUOTA' " & _
                                        " when 'CJ' then 'TOTAL PAGO' " & _
                                        " END, " & _
                                        " b.cCodofi, e.cnomofi, d.cnrodoc " & _
                                        " from Climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credkar d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " inner join tabtofi e " & _
                                        " on a.ccodofi = e.ccodofi " & _
                                        " where d.cestado <> 'X' " & _
                                        " and d.cdescob = 'C' and Not d.cconcep IN('08','IM')" & _
                                        " and (d.dfecsis >= '" & pdfecini & "' and d.dfecsis <= '" & pdfecfin & "') " & _
                                        " group by d.ccodcta, a.cnomcli, d.cconcep, d.dfecsis, b.cCodofi, e.cnomofi, d.cnrodoc "


                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Pagos")


                'Extrae Desembolsos
                command.CommandText = _
                                        " Select d.ccodcta, a.cnomcli, d.dfecsis, SUM(d.nmonto) as nmonto, " & _
                                        " cconcep = case d.cconcep  when 'KP' then 'TOTAL OTORGADO' " & _
                                        " when '01' then 'COMISION' " & _
                                        " when '08' then 'IVA COMISION' " & _
                                        " when 'CJ' then 'LIQUIDO A ENTREGAR' " & _
                                        " END, " & _
                                        " b.cCodofi, e.cnomofi, d.cnrodoc " & _
                                        " from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli  " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credkar d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " inner join tabtofi e " & _
                                        " on a.ccodofi = e.ccodofi " & _
                                        " Where d.cestado <> 'X' " & _
                                        " and d.cdescob = 'D' and Not d.cconcep IN('08')" & _
                                        " and (d.dfecsis >= '" & pdfecini & "' and d.dfecsis <= '" & pdfecfin & "') " & _
                                        " group by d.ccodcta, a.cnomcli, d.cconcep, d.dfecsis, b.cCodofi, e.cnomofi, d.cnrodoc "


                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Desembolsos")


                'Extrae Garantías Seguros
                command.CommandText = _
                                        " Select c.ccodcta, b.ccodofi, a.cnomcli, c.dfecpag as dfecsis, sum(nmonto) as nmonto, " & _
                                        " cconcep = case c.ctiping  when '03' then 'SEGURO' " & _
                                        " when '04' then 'GARANTIA LIQUIDA' " & _
                                        " End " & _
                                        " from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join aux_ingresos c " & _
                                        " on b.ccodcta = c.ccodcta " & _
                                        " Where c.dfecpag >= '" & pdfecini & "' and c.dfecpag <= '" & pdfecfin & "'" & _
                                        " group by c.ccodcta, b.ccodofi, a.cnomcli, c.dfecpag, c.ctiping "


                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Garantias")

                'Inserta Pagos
                For Each fila As DataRow In ds_Trab.Tables("Pagos").Rows

                    dr = ds_Trab.Tables("Detalle_Asiento").NewRow
                    dr("ccodcta") = fila("ccodcta")
                    dr("cnomcli") = fila("cnomcli")
                    dr("No_folio") = fila("cnrodoc")
                    dr("tipo_Doc") = fila("cconcep")
                    dr("dfecsis") = fila("dfecsis")
                    dr("tipo_Asiento") = "PAGOS"
                    dr("ccodofi") = fila("ccodofi")

                    dr("valor_1") = 0
                    dr("valor_Iva") = 0
                    dr("valor_Imp") = 0
                    dr("valor_Total") = 0

                    If fila("cconcep") = "TOTAL PAGO" Then
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Total") = fila("nmonto")
                    ElseIf fila("cconcep") = "INTERES" Or fila("cconcep") = "MORA" Then
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Iva") = Math.Round((fila("nmonto") * gnIVA) - dr("valor_1"), 2)
                        dr("valor_Total") = dr("valor_1") + dr("valor_Iva")
                    Else
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Total") = fila("nmonto")
                    End If
                    ds_Trab.Tables("Detalle_Asiento").Rows.Add(dr)

                Next


                'Inserta Desembolsos
                For Each fila As DataRow In ds_Trab.Tables("Desembolsos").Rows

                    dr = ds_Trab.Tables("Detalle_Asiento").NewRow
                    dr("ccodcta") = fila("ccodcta")
                    dr("cnomcli") = fila("cnomcli")
                    dr("No_folio") = fila("cnrodoc")
                    dr("tipo_Doc") = fila("cconcep")
                    dr("dfecsis") = fila("dfecsis")
                    dr("tipo_Asiento") = "DESEMBOLSOS"
                    dr("ccodofi") = fila("ccodofi")

                    dr("valor_1") = 0
                    dr("valor_Iva") = 0
                    dr("valor_Imp") = 0
                    dr("valor_Total") = 0


                    If fila("cconcep") = "TOTAL OTORGADO" Then
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Total") = fila("nmonto")
                    ElseIf fila("cconcep") = "COMISION" Then
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Iva") = Math.Round((fila("nmonto") * gnIVA) - dr("valor_1"), 2)
                        dr("valor_Total") = dr("valor_1") + dr("valor_Iva")
                    Else
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Total") = fila("nmonto")
                    End If
                    ds_Trab.Tables("Detalle_Asiento").Rows.Add(dr)

                Next

                'Inserta Garantías, Seguro

                For Each fila As DataRow In ds_Trab.Tables("Garantias").Rows

                    dr = ds_Trab.Tables("Detalle_Asiento").NewRow
                    dr("ccodcta") = fila("ccodcta")
                    dr("cnomcli") = fila("cnomcli")
                    dr("No_folio") = "0001"
                    dr("tipo_Doc") = fila("cconcep")
                    dr("dfecsis") = fila("dfecsis")
                    dr("ccodofi") = fila("ccodofi")

                    If fila("cconcep") = "SEGURO" Then
                        dr("tipo_Asiento") = "SEGUROS"
                    Else
                        dr("tipo_Asiento") = "GARANTIAS"
                    End If


                    dr("valor_1") = 0
                    dr("valor_Iva") = 0
                    dr("valor_Imp") = 0
                    dr("valor_Total") = 0

                    If fila("cconcep") = "SEGURO" Then
                        dr("valor_1") = Math.Round(fila("nmonto") / gnIVA, 2)
                        dr("valor_Iva") = Math.Round(fila("nmonto") - dr("valor_1"), 2)
                        dr("valor_Total") = fila("nmonto")
                    Else                'Garantía
                        dr("valor_1") = fila("nmonto")
                        dr("valor_Total") = fila("nmonto")
                    End If
                    ds_Trab.Tables("Detalle_Asiento").Rows.Add(dr)
                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return ds_Trab

    End Function



    'Actualiza Maestra de Pagos Automaticos
    Public Function Actualiza_Maestra_Pagos_Automaticos(ByVal id As Decimal, ByVal dfecsis As Date, ByVal dfecpro As Date, _
                                                        ByVal tipo As String, ByVal ccodcta As String, ByVal nmonto As Decimal, _
                                                        ByVal codigo_transaccion As String, ByVal ccodusu As String, _
                                                        ByVal cmotivo As String) As Integer




        Dim lnRetorno As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection



                command.CommandText = _
                                       " Insert into pagos_automaticos (id, dfecsis,dfecpro, tipo, ccodcta, nmonto , codigo_transaccion," & _
                                       " ccodusu, dfecmod, cmotivo, cflc)" & _
                                       " Values( " & id & ",'" & dfecsis & "','" & dfecpro & "','" & tipo & "','" & ccodcta & "'," & nmonto & ",'" & _
                                        codigo_transaccion & "','" & ccodusu & "',getdate(),'" & cmotivo & "','')"

                command.CommandType = CommandType.Text

                command.ExecuteNonQuery()


                lnRetorno = 1

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnRetorno

    End Function


    Public Function KardexPruebax(ByVal pccodcta As String, ByVal dfecha1 As String, ByVal dfecha2 As String, ByVal cdescob As String) As DataSet
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand

        Try

            Dim cadenaactual As String
            Dim cadena As String
            Dim ecreditos As New dbCreditos
            cadenaactual = Me.cnnStr

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds.Clear()


            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            'SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.cdescob = " & "'" & cdescob & "'" & " and  credkar.dfecsis>=" & "'" & dfecha1 & "'" & " and credkar.dfecsis <= " & "'" & dfecha2 & "'" & " and credkar.ccodcta = " & " '" & pccodcta & "'" & " and credkar.cestado =" & "'" & " " & "'" & " order by dfecpro"
            SqlSelectCommand1.CommandText = " Select ccodcta, dfecsis, dfecpro, cdescob, cnrodoc, ndiaatr," & _
                                            " ncapdes = sum(case when cConcep = 'KP' and cdescob = 'D'  then nmonto else 0 end), " & _
                                            " npago = sum(case when cConcep  = 'CJ' then nMonto else 0 end), " & _
                                            " ncapita = sum(case when cConcep  = 'KP' then nMonto else 0 end),  " & _
                                            " nintere = sum(case when cConcep  = 'IN'  then nMonto else 0 end), " & _
                                            " nmora = sum(case when cConcep  = 'MO' then nMonto else 0 end), " & _
                                            " niva_int = sum(case when cConcep  = '08'  then nMonto else 0 end)," & _
                                            " niva_mora = sum(case when cConcep  = 'IM'  then nMonto else 0 end), " & _
                                            " notros = sum(case when cConcep  <> 'KP' and cConcep <> 'IN' and cConcep <> 'MO' and cConcep <> 'CJ' then nMonto else 0 end), " & _
                                            " nexcedente = sum(case when cConcep  = 'EX' then nMonto else 0 end), " & _
                                            " 000000.00 as nsaldo " & _
                                            " from credkar where ccodcta = '" & pccodcta & "' " & _
                                            " and dfecsis between '" & dfecha1 & "' and '" & dfecha2 & "'" & _
                                            " and cdescob = 'C' and cestado <> 'X' " & _
                                            " group by ccodcta, dfecsis, dfecpro, cdescob, cnrodoc, ndiaatr " & _
                                            " order by dfecpro "

            SqlConnection1.ConnectionString = Me.cnnStr()

            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(ds, "kardex")


        Catch SqlException As Exception

            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

        Return ds

    End Function
    Public Function KardexPruebaxDes(ByVal pccodcta As String) As DataSet
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter

        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim ds As New DataSet
        Try

            Dim cadenaactual As String
            Dim cadena As String
            Dim ecreditos As New dbCreditos
            cadenaactual = Me.cnnStr

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter

            ds.Clear()

            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            'SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.cdescob ='D' and  credkar.ccodcta = " & " '" & pccodcta & "'" & " and credkar.cestado =" & "'" & " " & "'" & " order by dfecpro"

            SqlSelectCommand1.CommandText = _
                                             " Select ccodcta, dfecsis, dfecpro, cdescob, cnrodoc, 0000 as ndiaatr," & _
                                             " ncapdes = sum(case when cConcep = 'KP' and cdescob = 'D'  then nmonto else 0 end), " & _
                                             " 000000.00 as npago,000000.00 as ncapita,000000.00 as nintere,000000.00 as nmora,000000.00 as niva_int, " & _
                                             " 000000.00 as niva_mora,000000.00 as notros,000000.00 as nexcedente, 000000.00 as nsaldo " & _
                                             " from credkar where ccodcta = '" & pccodcta & "'" & _
                                             " and cestado <>'X' and cdescob ='D' " & _
                                             " group by ccodcta, dfecsis, dfecpro, cdescob, cnrodoc " & _
                                             " order by dfecpro "

            SqlConnection1.ConnectionString = Me.cnnStr()

            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(ds, "kardex")


        Catch SqlException As Exception

            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

        Return ds

    End Function

    Public Function KardexPruebaxDes_(ByVal pccodcta As String) As DataSet
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter

        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim ds As New DataSet
        Try

            Dim cadenaactual As String
            Dim cadena As String
            Dim ecreditos As New dbCreditos
            cadenaactual = Me.cnnStr

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter

            ds.Clear()

            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.cdescob ='D' and  credkar.ccodcta = " & " '" & pccodcta & "'" & " and credkar.cestado =" & "'" & " " & "'" & " order by dfecpro"

            SqlConnection1.ConnectionString = Me.cnnStr()

            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(ds, "kardex")


        Catch SqlException As Exception

            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

        Return ds

    End Function



    Public Function Inserta_AjusteX(ByVal Encabeza_Part() As String, ByVal Detalle_Pago() As String) As Integer

        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lnRetorno As Integer = 0
        Dim lcnumcom As String = ""
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim lniva_mora As Double = 0
        Dim lnintmor As Double = Detalle_Pago(0)
        Dim lnsalInt As Double = Detalle_Pago(1)
        Dim lniva_interes As Double = 0
        Dim lncapita As Double = Detalle_Pago(2)
        Dim lnmonpag As Double = Detalle_Pago(3)
        Dim gniva As Double = Detalle_Pago(4)
        Dim lcCodcta_CJ As Double = Detalle_Pago(5)
        Dim lcCondic As String = Detalle_Pago(6)
        Dim lnnumero As Integer = Detalle_Pago(7)


        Dim lcCodcta_KP As String = ""
        Dim lcCodcta_IN As String = ""
        Dim lcCodcta_MO As String = ""
        Dim lcCodcta_IV As String = ""
        Dim lnDebe As Double = 0
        Dim lnHaber As Double = 0

        'Dim Encabeza_Part() As String = {Date.Parse(Me.Txtdfeccnt.Text), Me.CbxOficina1.SelectedValue.Trim, _
        '                               Me.TxtcGlosa.Text.Trim, Me.CbxTipAsCtb1.SelectedValue.Trim, Me.ObtenerVariable("GDFECSIS"),
        '                               session("gcCodusu"), Me.txtNoPartida.text.trim, _
        '                               Me.CbxBancos2.SelectedValue.Trim, Me.cbxCtaBco.SelectedValue.Trim, Me.txtcCodcta.text}



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try


                'Extrae Correlativo de Partida
                command.CommandText = _
                                        " Select * from cnumes " & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_No_Part")

                For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                    lcnumcom = fila("cnumcom").ToString.Trim
                Next

                i = Double.Parse(Right(lcnumcom, 6)) + 1


                'lcnumcom = lcmes + Clase.fxStrZero(lnTota, lnlong)
                lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                           ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                           fxStrZero(i, 6)

                'Inserta Asiento Contable, Primero lo hara en la Maestra
                command.CommandText = _
                                        " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                        " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                        " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                        " Values('" & _
                                        lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                        Encabeza_Part(2) & "','',''," & _
                                        "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                        Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                command.ExecuteNonQuery()

                'Actualizara en la cNumes                           
                command.CommandText = _
                                        " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                            ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                command.ExecuteNonQuery()



                i = 1

                'Extrae Mascaras de Capital, Interes, Mora
                If ds.Tables.Count > 0 Then
                    ds.Tables.Clear()
                End If

                command.CommandText = _
                                        " Select * from tabtmak " & _
                                        " where ccodigo in('CKPN" & lcCondic & "','CINN" & lcCondic & "','CMON" & lcCondic & "','CIVN" & lcCondic & "')"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    If fila("ccodigo").ToString.Trim = "CIVN" & lcCondic Then
                        lcCodcta_IV = fila("cplanti").ToString.Trim
                    End If
                    If fila("ccodigo").ToString.Trim = "CMON" & lcCondic Then
                        lcCodcta_MO = fila("cplanti").ToString.Trim
                    End If
                    If fila("ccodigo").ToString.Trim = "CINN" & lcCondic Then
                        lcCodcta_IN = fila("cplanti").ToString.Trim
                    End If
                    If fila("ccodigo").ToString.Trim = "CKPN" & lcCondic Then
                        lcCodcta_KP = fila("cplanti").ToString.Trim
                    End If
                Next

                i += 1

                Dim lcnrodoc As String
                lcnrodoc = conviertecnrodoc(lnnumero)

                'Interes Moratorio + Iva
                If lnintmor <> 0 Then
                    If lnintmor < 0 Then
                        lnintmor = lnintmor * (-1)
                        lniva_mora = lnintmor - (lnintmor / gniva)
                        lniva_mora = Math.Round(lniva_mora, 2)
                        lnintmor = Math.Round(lnintmor - lniva_mora, 2)
                        lnintmor = lnintmor * (-1)
                        lniva_mora = lniva_mora * (-1)
                    Else
                        lniva_mora = lnintmor - (lnintmor / gniva)
                        lniva_mora = Math.Round(lniva_mora, 2)
                        lnintmor = Math.Round(lnintmor - lniva_mora, 2)
                    End If



                    'Inserta el Iva
                    If lnintmor < 0 Then
                        lnDebe = Math.Abs(lniva_mora)
                        lnHaber = 0
                    Else
                        lnDebe = 0
                        lnHaber = lniva_mora
                    End If

                    command.CommandText = _
                                           " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                           " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                           " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                           " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_IV & "','" & _
                                           lcCodcta_IV.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                           "," & lnHaber & ",'',0,'','" & _
                                           Encabeza_Part(0) & "','','AJUSTE IVA MORA','" & Encabeza_Part(3) & "','" & _
                                           Encabeza_Part(1) & "','','" & _
                                           Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    command.CommandText = _
                                          " Insert Into credkar (ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado," & _
                                          " ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep,cdescob,cnuming," & _
                                          " cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa," & _
                                          " ndiaatr, ccalif, lrecprov, cnumrec, ldispersa, dfecdispersa) Values('" & _
                                          Encabeza_Part(9) & "','" & Encabeza_Part(4) & "','" & Encabeza_Part(4) & "','001'," & lniva_mora & ",'001','" & Encabeza_Part(1) & "','C',''," & _
                                          "'','" & lcnrodoc & "','" & Encabeza_Part(5) & "',getdate(),'','" & lcCondic & "','IM','C',''," & _
                                          "'','" & lcCodcta_IV & "','','',0,0,'','',''," & _
                                          " 0,'',0,'AJUSTE',null,null)"



                    command.ExecuteNonQuery()


                    'Inserta el Interes Moratorio
                    If lnintmor < 0 Then
                        lnDebe = Math.Abs(lnintmor)
                        lnHaber = 0
                    Else
                        lnDebe = 0
                        lnHaber = lnintmor
                    End If

                    command.CommandText = _
                                         " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                         " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                         " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                         " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_MO & "','" & _
                                         lcCodcta_MO.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                         "," & lnHaber & ",'',0,'','" & _
                                         Encabeza_Part(0) & "','','AJUSTE MORA','" & Encabeza_Part(3) & "','" & _
                                         Encabeza_Part(1) & "','','" & _
                                         Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    command.CommandText = _
                                          " Insert Into credkar (ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado," & _
                                          " ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep,cdescob,cnuming," & _
                                          " cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa," & _
                                          " ndiaatr, ccalif, lrecprov, cnumrec, ldispersa, dfecdispersa) Values('" & _
                                          Encabeza_Part(9) & "','" & Encabeza_Part(4) & "','" & Encabeza_Part(4) & "','001'," & lnintmor & ",'001','" & Encabeza_Part(1) & "','C',''," & _
                                          "'','" & lcnrodoc & "','" & Encabeza_Part(5) & "',getdate(),'','" & lcCondic & "','MO','C',''," & _
                                          "'','" & lcCodcta_MO & "','','',0,0,'','',''," & _
                                          " 0,'',0,'AJUSTE',null,null)"



                    command.ExecuteNonQuery()

                End If


                'Interes Normal + Iva
                If lnsalInt <> 0 Then
                    If lnsalInt < 0 Then
                        lnsalInt = lnsalInt * (-1)
                        lniva_interes = lnsalInt - (lnsalInt / gniva)
                        lniva_interes = Math.Round(lniva_interes, 2)
                        lnsalInt = Math.Round(lnsalInt - lniva_interes, 2)
                        lnsalInt = lnsalInt * (-1)
                        lniva_interes = lniva_interes * (-1)
                    Else
                        lniva_interes = lnsalInt - (lnsalInt / gniva)
                        lniva_interes = Math.Round(lniva_interes, 2)
                        lnsalInt = Math.Round(lnsalInt - lniva_interes, 2)

                    End If



                    'Inserta el Iva
                    If lnsalInt < 0 Then
                        lnDebe = Math.Abs(lniva_interes)
                        lnHaber = 0
                    Else
                        lnDebe = 0
                        lnHaber = lniva_interes
                    End If

                    command.CommandText = _
                                           " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                           " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                           " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                           " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_IV & "','" & _
                                           lcCodcta_IV.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                           "," & lnHaber & ",'',0,'','" & _
                                           Encabeza_Part(0) & "','','AJUSTE IVA INTERES NORMAL','" & Encabeza_Part(3) & "','" & _
                                           Encabeza_Part(1) & "','','" & _
                                           Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    command.CommandText = _
                                          " Insert Into credkar (ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado," & _
                                          " ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep,cdescob,cnuming," & _
                                          " cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa," & _
                                          " ndiaatr, ccalif, lrecprov, cnumrec, ldispersa, dfecdispersa) Values('" & _
                                          Encabeza_Part(9) & "','" & Encabeza_Part(4) & "','" & Encabeza_Part(4) & "','001'," & lniva_interes & ",'001','" & Encabeza_Part(1) & "','C',''," & _
                                          "'','" & lcnrodoc & "','" & Encabeza_Part(5) & "',getdate(),'','" & lcCondic & "','08','C',''," & _
                                          "'','" & lcCodcta_IV & "','','',0,0,'','',''," & _
                                          " 0,'',0,'AJUSTE',null,null)"



                    command.ExecuteNonQuery()


                    'Inserta Interes Normal
                    If lnsalInt < 0 Then
                        lnDebe = Math.Abs(lnsalInt)
                        lnHaber = 0
                    Else
                        lnDebe = 0
                        lnHaber = lnsalInt
                    End If

                    command.CommandText = _
                                           " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                           " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                           " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                           " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_IN & "','" & _
                                           lcCodcta_IN.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                           "," & lnHaber & ",'',0,'','" & _
                                           Encabeza_Part(0) & "','','AJUSTE INTERES NORMAL','" & Encabeza_Part(3) & "','" & _
                                           Encabeza_Part(1) & "','','" & _
                                           Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    command.CommandText = _
                                          " Insert Into credkar (ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado," & _
                                          " ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep,cdescob,cnuming," & _
                                          " cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa," & _
                                          " ndiaatr, ccalif, lrecprov, cnumrec, ldispersa, dfecdispersa) Values('" & _
                                          Encabeza_Part(9) & "','" & Encabeza_Part(4) & "','" & Encabeza_Part(4) & "','001'," & lnsalInt & ",'001','" & Encabeza_Part(1) & "','C',''," & _
                                          "'','" & lcnrodoc & "','" & Encabeza_Part(5) & "',getdate(),'','" & lcCondic & "','IN','C',''," & _
                                          "'','" & lcCodcta_IN & "','','',0,0,'','',''," & _
                                          " 0,'',0,'AJUSTE',null,null)"



                    command.ExecuteNonQuery()


                End If

                'Capital
                If lncapita <> 0 Then

                    If lncapita < 0 Then
                        lnDebe = Math.Abs(lncapita)
                        lnHaber = 0
                    Else
                        lnDebe = 0
                        lnHaber = lncapita
                    End If

                    command.CommandText = _
                                           " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                           " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                           " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                           " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_KP & "','" & _
                                           lcCodcta_KP.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                           "," & lnHaber & ",'',0,'','" & _
                                           Encabeza_Part(0) & "','','AJUSTE CAPITAL','" & Encabeza_Part(3) & "','" & _
                                           Encabeza_Part(1) & "','','" & _
                                           Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    command.CommandText = _
                                          " Insert Into credkar (ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado," & _
                                          " ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep,cdescob,cnuming," & _
                                          " cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa," & _
                                          " ndiaatr, ccalif, lrecprov, cnumrec, ldispersa, dfecdispersa) Values('" & _
                                          Encabeza_Part(9) & "','" & Encabeza_Part(4) & "','" & Encabeza_Part(4) & "','001'," & lncapita & ",'001','" & Encabeza_Part(1) & "','C',''," & _
                                          "'','" & lcnrodoc & "','" & Encabeza_Part(5) & "',getdate(),'','" & lcCondic & "','KP','C',''," & _
                                          "'','" & lcCodcta_KP & "','','',0,0,'','',''," & _
                                          " 0,'',0,'AJUSTE',null,null)"



                    command.ExecuteNonQuery()


                End If

                'Monto Total
                If lnmonpag > 0 Then


                    lnDebe = IIf(lnmonpag < 0, Math.Abs(lnmonpag), lnmonpag)
                    lnHaber = 0


                    command.CommandText = _
                                           " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                           " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                           " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                           " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_CJ & "','" & _
                                           lcCodcta_CJ.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                           "," & lnHaber & ",'',0,'','" & _
                                           Encabeza_Part(0) & "','','TOTAL AJUSTE','" & Encabeza_Part(3) & "','" & _
                                           Encabeza_Part(1) & "','','" & _
                                           Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    command.CommandText = _
                                          " Insert Into credkar (ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado," & _
                                          " ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep,cdescob,cnuming," & _
                                          " cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa," & _
                                          " ndiaatr, ccalif, lrecprov, cnumrec, ldispersa, dfecdispersa) Values('" & _
                                          Encabeza_Part(9) & "','" & Encabeza_Part(4) & "','" & Encabeza_Part(4) & "','001'," & lnmonpag & ",'001','" & Encabeza_Part(1) & "','C',''," & _
                                          "'','" & lcnrodoc & "','" & Encabeza_Part(5) & "',getdate(),'','" & lcCondic & "','CJ','C',''," & _
                                          "'','" & lcCodcta_CJ & "','','',0,0,'','',''," & _
                                          " 0,'',0,'AJUSTE',null,null)"



                    command.ExecuteNonQuery()


                End If


                ' Attempt to commit the transaction.
                MyTransac.Commit()
                lnRetorno = 1

            Catch ex As Exception

                lcnumcom = ""
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lnRetorno

    End Function


    Private Function conviertecnrodoc(ByVal numero As Integer) As String

        Dim lcnrodoc As String
        Dim i As Integer
        lcnrodoc = numero.ToString().Trim
        Dim tamano As Integer
        tamano = lcnrodoc.Trim.Length
        For i = 1 To 4 - tamano
            lcnrodoc = "0" & lcnrodoc
        Next

        Return lcnrodoc
    End Function


    Public Function Extrae_Detalle_Pagos(ByVal pdfecsys As Date, ByVal pcCodcta As String) As DataTable

        Dim lnRetorno As Integer = 0
        Dim ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            Dim MyAdapter As New SqlDataAdapter

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try

                command.CommandText = _
                                        " Select dfecsis, dfecpro, nmonto, cnrodoc from credkar " & _
                                        " Where dfecsis > '" & pdfecsys & "'" & _
                                        " and cdescob = 'C' and cconcep = 'CJ' " & _
                                        " and cestado = '' " & _
                                        " and ccodcta = '" & pcCodcta & "'" & _
                                        " Order by dfecsis, cnrodoc "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Data_Desembolsos")


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            Finally
                connection.Close()
            End Try
        End Using

        Return ds.Tables("Data_Desembolsos")

    End Function


    Public Function Extrae_Detalle_Pagos_Creditos(ByVal pcCodcta As String) As DataTable

        Dim lnRetorno As Integer = 0
        Dim ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            Dim MyAdapter As New SqlDataAdapter

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try

                command.CommandText = _
                                        " Select dfecsis, dfecpro, nmonto, cnrodoc, cnuming from credkar " & _
                                        " Where cdescob = 'C' and cconcep = 'CJ' " & _
                                        " and cestado = '' " & _
                                        " and ccodcta = '" & pcCodcta & "'" & _
                                        " Order by dfecsis, cnrodoc "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Data_Pagos")


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            Finally
                connection.Close()
            End Try
        End Using

        Return ds.Tables("Data_Pagos")

    End Function


    Public Function Inserta_Auxiliar_AjusteX(ByVal ccodcta As String, ByVal ccodcli As String, _
                                            ByVal dt As DataTable, ByVal pccodusu As String) As Integer

        Dim ds As New DataSet
        Dim lnRetorno As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction




        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try


                For Each fila As DataRow In dt.Rows
                    If fila("cnrodoc").ToString.Trim.Length = 0 Then
                        command.CommandText = _
                                        " Insert Into aux_ajustes (ccodcta, ccodcli, cnuming, dfecpro, nmonto, dfecmod, ccodusu)" & _
                                        " Values('" & ccodcta & "','" & ccodcli & "','" & fila("cnuming") & "','" & fila("dfecpro") & "'," & _
                                        fila("nmonto") & ",getdate(), '" & pccodusu & "')"

                        command.ExecuteNonQuery()
                    End If
                Next



                ' Attempt to commit the transaction.
                MyTransac.Commit()
                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lnRetorno

    End Function


    Public Function Extrae_Auxiliar_Ajustes_Creditos(ByVal pcCodcta As String) As DataTable

        Dim lnRetorno As Integer = 0
        Dim ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            Dim MyAdapter As New SqlDataAdapter

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try

                command.CommandText = _
                                        " Select dfecpro, cnuming, nmonto, ccodusu from aux_ajustes " & _
                                        " Where ccodcta = '" & pcCodcta & "'" & _
                                        " Order by dfecpro"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Data_Pagos")


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            Finally
                connection.Close()
            End Try
        End Using

        Return ds.Tables("Data_Pagos")

    End Function


    Public Function Obtenercnrodoc_(ByVal cCodcta As String, ByVal con As SqlConnection) As Integer


        Dim _sql As String
        Dim lcnrodoc As String
        Dim i As Integer
        Dim tamano As Integer

        _sql = " SELECT max(cnrodoc)+1 as cnrodoc From credkar Where ccodcta ='" & cCodcta & "'"


        Dim comando As New SqlCommand(_sql, con)
        comando.CommandType = CommandType.Text
        Dim ds As New DataSet
        Dim myadapter As New SqlDataAdapter

        Try

            myadapter.SelectCommand = comando
            myadapter.Fill(ds, "Documentos")


            If ds.Tables(0).Rows.Count > 0 Then

                If IsDBNull(ds.Tables(0).Rows(0)("cnrodoc")) Then
                    lcnrodoc = "0001"
                Else
                    lcnrodoc = ds.Tables(0).Rows(0)("cnrodoc")
                    lcnrodoc.Trim()
                    tamano = lcnrodoc.Trim.Length
                    For i = 1 To 4 - tamano
                        lcnrodoc = "0" & lcnrodoc
                    Next
                End If
            End If

            Return lcnrodoc

        Catch ex As Exception

        End Try

    End Function


    Public Function Pagos_Automaticos(ByVal dt As DataTable, ByVal pdfecsis As Date, _
                                      ByVal pcCodusu As String, ByVal FileName_Arch As String) As DataSet

        Dim lnRetorno As Integer = 1
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim MyParameters As New SqlParameter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim Ds As New DataSet


        Using connection
            connection.Open()

            Try

                command.Connection = connection
                'command.CommandText = "Pago_Automatico_Test"
                command.CommandText = "Pago_Automatico_Tabla_Temporal"

                command.CommandType = CommandType.StoredProcedure
                command.CommandTimeout = 0
                command.Parameters.AddWithValue("@TablaParametro", dt)
                command.Parameters.AddWithValue("@pdfecsis", pdfecsis)
                command.Parameters.AddWithValue("@pccodusu", pcCodusu)
                command.Parameters.AddWithValue("@Name_Arch", FileName_Arch)



                MyAdapter.SelectCommand = command
                MyAdapter.Fill(Ds, "Datos")

                ' lnRetorno = CInt(MyParameters.Value)

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return Ds

    End Function
End Class