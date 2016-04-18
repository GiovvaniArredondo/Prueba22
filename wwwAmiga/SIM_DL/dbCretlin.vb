Imports System.Text
Public Class dbCretlin
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As cretlin
        Dim lID As Long
        lEntidad = aEntidad
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cretlin ")
        strSQL.Append(" SET ccodlin = @ccodlin, ")
        strSQL.Append(" dfecvig = @dfecvig, ")
        strSQL.Append(" cdeslin = @cdeslin, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" ntasintmin = @ntasintmin, ")
        strSQL.Append(" ntasintmax = @ntasintmax,")
        strSQL.Append(" ctipcal = @ctipcal, ")
        strSQL.Append(" ntasmor = @ntasmor, ")
        strSQL.Append(" nliminf = @nliminf, ")
        strSQL.Append(" nlimsup = @nlimsup, ")
        strSQL.Append(" lactiva = @lactiva, ")
        strSQL.Append(" llinusa = @llinusa, ")
        strSQL.Append(" llinpre = @llinpre, ")
        strSQL.Append(" cnropar = @cnropar, ")
        strSQL.Append(" nmondes = @nmondes, ")
        strSQL.Append(" ctipdes = @ctipdes, ")
        strSQL.Append(" ndesuso = @ndesuso, ")
        strSQL.Append(" ladmon = @ladmon, ")
        strSQL.Append(" lsegvida = @lsegvida, ")
        strSQL.Append(" lsegdeu = @lsegdeu, ")
        strSQL.Append(" lredo = @lredo, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = getdate(), ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" ccodrub = @ccodrub, ")
        strSQL.Append(" ctiplin = @ctiplin, ")
        strSQL.Append(" ctipo = @ctipo, ")
        strSQL.Append(" ccodbco = @ccodbco, ")
        strSQL.Append(" cctacte = @cctacte, nplazomin = @nplazomin, nplazomax = @nplazomax, ")
        strSQL.Append(" lliva = @lliva, nocuotas = @nocuotas, nmoncuo = @nmoncuo")
        strSQL.Append(" WHERE cnrolin = @cnrolin ")

        Dim args(34) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodlin
        args(2) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecvig
        args(3) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdeslin
        args(4) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(4).Value = lEntidad.ntasint
        args(5) = New SqlParameter("@ctipcal", SqlDbType.VarChar)
        args(5).Value = lEntidad.ctipcal
        args(6) = New SqlParameter("@ntasmor", SqlDbType.Decimal)
        args(6).Value = lEntidad.ntasmor
        args(7) = New SqlParameter("@nliminf", SqlDbType.Decimal)
        args(7).Value = lEntidad.nliminf
        args(8) = New SqlParameter("@nlimsup", SqlDbType.Decimal)
        args(8).Value = lEntidad.nlimsup
        args(9) = New SqlParameter("@lactiva", SqlDbType.Bit)
        args(9).Value = IIf(lEntidad.lactiva = Nothing, 0, lEntidad.lactiva)
        args(10) = New SqlParameter("@llinusa", SqlDbType.Bit)
        args(10).Value = IIf(lEntidad.llinusa = Nothing, 0, lEntidad.llinusa)
        args(11) = New SqlParameter("@llinpre", SqlDbType.Bit)
        args(11).Value = IIf(lEntidad.llinpre = Nothing, 0, lEntidad.llinpre)
        args(12) = New SqlParameter("@cnropar", SqlDbType.VarChar)
        args(12).Value = lEntidad.cnropar
        args(13) = New SqlParameter("@nmondes", SqlDbType.Decimal)
        args(13).Value = lEntidad.nmondes
        args(14) = New SqlParameter("@ctipdes", SqlDbType.VarChar)
        args(14).Value = lEntidad.ctipdes
        args(15) = New SqlParameter("@ndesuso", SqlDbType.Decimal)
        args(15).Value = lEntidad.ndesuso
        args(16) = New SqlParameter("@ladmon", SqlDbType.Bit)
        args(16).Value = IIf(lEntidad.ladmon = Nothing, 0, lEntidad.ladmon)
        args(17) = New SqlParameter("@lsegvida", SqlDbType.Bit)
        args(17).Value = IIf(lEntidad.lsegvida = Nothing, 0, lEntidad.lsegvida)
        args(18) = New SqlParameter("@lsegdeu", SqlDbType.Bit)
        args(18).Value = IIf(lEntidad.lsegdeu = Nothing, 0, lEntidad.lsegdeu)
        args(19) = New SqlParameter("@lredo", SqlDbType.Bit)
        args(19).Value = IIf(lEntidad.lredo = Nothing, 0, lEntidad.lredo)
        args(20) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodusu
        args(21) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(21).Value = lEntidad.dfecmod
        args(22) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(22).Value = lEntidad.cflag
        args(23) = New SqlParameter("@ccodrub", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccodrub
        args(24) = New SqlParameter("@ctiplin", SqlDbType.VarChar)
        args(24).Value = lEntidad.ctiplin
        args(25) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(25).Value = lEntidad.ctipo
        args(26) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(26).Value = lEntidad.ccodbco
        args(27) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(27).Value = lEntidad.cctacte
        args(28) = New SqlParameter("@ntasintmin", SqlDbType.Decimal)
        args(28).Value = lEntidad.ntasintmin
        args(29) = New SqlParameter("@ntasintmax", SqlDbType.Decimal)
        args(29).Value = lEntidad.ntasintmax
        args(30) = New SqlParameter("@nplazomin", SqlDbType.Int)
        args(30).Value = lEntidad.nplazomin
        args(31) = New SqlParameter("@nplazomax", SqlDbType.Int)
        args(31).Value = lEntidad.nplazomax
        args(32) = New SqlParameter("@lliva", SqlDbType.Bit)
        args(32).Value = lEntidad.lliva
        args(33) = New SqlParameter("@nocuotas", SqlDbType.Decimal)
        args(33).Value = lEntidad.nocuotas
        args(34) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(34).Value = lEntidad.nmoncuo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cretlin ")
        strSQL.Append(" ( cnrolin, ")
        strSQL.Append(" ccodlin, ")
        strSQL.Append(" dfecvig, ")
        strSQL.Append(" cdeslin, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" ctipcal, ")
        strSQL.Append(" ntasmor, ")
        strSQL.Append(" nliminf, ")
        strSQL.Append(" nlimsup, ")
        strSQL.Append(" lactiva, ")
        strSQL.Append(" llinusa, ")
        strSQL.Append(" llinpre, ")
        strSQL.Append(" cnropar, ")
        strSQL.Append(" nmondes, ")
        strSQL.Append(" ctipdes, ")
        strSQL.Append(" ndesuso, ")
        strSQL.Append(" ladmon, ")
        strSQL.Append(" lsegvida, ")
        strSQL.Append(" lsegdeu, ")
        strSQL.Append(" lredo, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" ccodrub, ")
        strSQL.Append(" ctiplin, ")
        strSQL.Append(" ctipo, ")
        strSQL.Append(" ccodbco, ")
        strSQL.Append(" cctacte, ntasintmin, ntasintmax, nplazomin, nplazomax, lliva, nocuotas, nmoncuo) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnrolin, ")
        strSQL.Append(" @ccodlin, ")
        strSQL.Append(" @dfecvig, ")
        strSQL.Append(" @cdeslin, ")
        strSQL.Append(" @ntasint, ")
        strSQL.Append(" @ctipcal, ")
        strSQL.Append(" @ntasmor, ")
        strSQL.Append(" @nliminf, ")
        strSQL.Append(" @nlimsup, ")
        strSQL.Append(" @lactiva, ")
        strSQL.Append(" @llinusa, ")
        strSQL.Append(" @llinpre, ")
        strSQL.Append(" @cnropar, ")
        strSQL.Append(" @nmondes, ")
        strSQL.Append(" @ctipdes, ")
        strSQL.Append(" @ndesuso, ")
        strSQL.Append(" @ladmon, ")
        strSQL.Append(" @lsegvida, ")
        strSQL.Append(" @lsegdeu, ")
        strSQL.Append(" @lredo, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" getdate(), ")
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @ccodrub, ")
        strSQL.Append(" @ctiplin, ")
        strSQL.Append(" @ctipo, ")
        strSQL.Append(" @ccodbco, ")
        strSQL.Append(" @cctacte, @ntasintmin, @ntasintmax, @nplazomin, @nplazomax, @lliva, @nocuotas, @nmoncuo) ")

        Dim args(34) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodlin
        args(2) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecvig
        args(3) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdeslin
        args(4) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(4).Value = lEntidad.ntasint
        args(5) = New SqlParameter("@ctipcal", SqlDbType.VarChar)
        args(5).Value = lEntidad.ctipcal
        args(6) = New SqlParameter("@ntasmor", SqlDbType.Decimal)
        args(6).Value = lEntidad.ntasmor
        args(7) = New SqlParameter("@nliminf", SqlDbType.Decimal)
        args(7).Value = lEntidad.nliminf
        args(8) = New SqlParameter("@nlimsup", SqlDbType.Decimal)
        args(8).Value = lEntidad.nlimsup
        args(9) = New SqlParameter("@lactiva", SqlDbType.Bit)
        args(9).Value = IIf(lEntidad.lactiva = Nothing, 0, lEntidad.lactiva)
        args(10) = New SqlParameter("@llinusa", SqlDbType.Bit)
        args(10).Value = IIf(lEntidad.llinusa = Nothing, 0, lEntidad.llinusa)
        args(11) = New SqlParameter("@llinpre", SqlDbType.Bit)
        args(11).Value = IIf(lEntidad.llinpre = Nothing, 0, lEntidad.llinpre)
        args(12) = New SqlParameter("@cnropar", SqlDbType.VarChar)
        args(12).Value = lEntidad.cnropar
        args(13) = New SqlParameter("@nmondes", SqlDbType.Decimal)
        args(13).Value = lEntidad.nmondes
        args(14) = New SqlParameter("@ctipdes", SqlDbType.VarChar)
        args(14).Value = lEntidad.ctipdes
        args(15) = New SqlParameter("@ndesuso", SqlDbType.Decimal)
        args(15).Value = lEntidad.ndesuso
        args(16) = New SqlParameter("@ladmon", SqlDbType.Bit)
        args(16).Value = IIf(lEntidad.ladmon = Nothing, 0, lEntidad.ladmon)
        args(17) = New SqlParameter("@lsegvida", SqlDbType.Bit)
        args(17).Value = IIf(lEntidad.lsegvida = Nothing, 0, lEntidad.lsegvida)
        args(18) = New SqlParameter("@lsegdeu", SqlDbType.Bit)
        args(18).Value = IIf(lEntidad.lsegdeu = Nothing, 0, lEntidad.lsegdeu)
        args(19) = New SqlParameter("@lredo", SqlDbType.Bit)
        args(19).Value = IIf(lEntidad.lredo = Nothing, 0, lEntidad.lredo)
        args(20) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodusu
        args(21) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(21).Value = lEntidad.dfecmod
        args(22) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(22).Value = lEntidad.cflag
        args(23) = New SqlParameter("@ccodrub", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccodrub
        args(24) = New SqlParameter("@ctiplin", SqlDbType.VarChar)
        args(24).Value = lEntidad.ctiplin
        args(25) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(25).Value = lEntidad.ctipo
        args(26) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(26).Value = lEntidad.ccodbco
        args(27) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(27).Value = lEntidad.cctacte
        args(28) = New SqlParameter("@ntasintmin", SqlDbType.Decimal)
        args(28).Value = lEntidad.ntasintmin
        args(29) = New SqlParameter("@ntasintmax", SqlDbType.Decimal)
        args(29).Value = lEntidad.ntasintmax
        args(30) = New SqlParameter("@nplazomin", SqlDbType.Int)
        args(30).Value = lEntidad.nplazomin
        args(31) = New SqlParameter("@nplazomax", SqlDbType.Int)
        args(31).Value = lEntidad.nplazomax
        args(32) = New SqlParameter("@lliva", SqlDbType.Bit)
        args(32).Value = lEntidad.lliva
        args(33) = New SqlParameter("@nocuotas", SqlDbType.Decimal)
        args(33).Value = lEntidad.nocuotas
        args(34) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(34).Value = lEntidad.nmoncuo


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cretlin ")
        strSQL.Append(" WHERE cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnrolin = IIf(.Item("cnrolin") Is DBNull.Value, Nothing, .Item("cnrolin"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.dfecvig = IIf(.Item("dfecvig") Is DBNull.Value, Nothing, .Item("dfecvig"))
                lEntidad.cdeslin = IIf(.Item("cdeslin") Is DBNull.Value, Nothing, .Item("cdeslin"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.ctipcal = IIf(.Item("ctipcal") Is DBNull.Value, Nothing, .Item("ctipcal"))
                lEntidad.ntasmor = IIf(.Item("ntasmor") Is DBNull.Value, Nothing, .Item("ntasmor"))
                lEntidad.nliminf = IIf(.Item("nliminf") Is DBNull.Value, Nothing, .Item("nliminf"))
                lEntidad.nlimsup = IIf(.Item("nlimsup") Is DBNull.Value, Nothing, .Item("nlimsup"))
                lEntidad.lactiva = IIf(.Item("lactiva") Is DBNull.Value, Nothing, .Item("lactiva"))
                lEntidad.llinusa = IIf(.Item("llinusa") Is DBNull.Value, Nothing, .Item("llinusa"))
                lEntidad.llinpre = IIf(.Item("llinpre") Is DBNull.Value, Nothing, .Item("llinpre"))
                lEntidad.cnropar = IIf(.Item("cnropar") Is DBNull.Value, Nothing, .Item("cnropar"))
                lEntidad.nmondes = IIf(.Item("nmondes") Is DBNull.Value, Nothing, .Item("nmondes"))
                lEntidad.ctipdes = IIf(.Item("ctipdes") Is DBNull.Value, Nothing, .Item("ctipdes"))
                lEntidad.ndesuso = IIf(.Item("ndesuso") Is DBNull.Value, Nothing, .Item("ndesuso"))
                lEntidad.ladmon = IIf(.Item("ladmon") Is DBNull.Value, Nothing, .Item("ladmon"))
                lEntidad.lsegvida = IIf(.Item("lsegvida") Is DBNull.Value, Nothing, .Item("lsegvida"))
                lEntidad.lsegdeu = IIf(.Item("lsegdeu") Is DBNull.Value, Nothing, .Item("lsegdeu"))
                lEntidad.lredo = IIf(.Item("lredo") Is DBNull.Value, Nothing, .Item("lredo"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.ccodrub = IIf(.Item("ccodrub") Is DBNull.Value, Nothing, .Item("ccodrub"))
                lEntidad.ctiplin = IIf(.Item("ctiplin") Is DBNull.Value, Nothing, .Item("ctiplin"))
                lEntidad.ctipo = IIf(.Item("ctipo") Is DBNull.Value, Nothing, .Item("ctipo"))
                lEntidad.ccodbco = IIf(.Item("ccodbco") Is DBNull.Value, Nothing, .Item("ccodbco"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.ntasintmin = IIf(.Item("ntasintmin") Is DBNull.Value, 0, .Item("ntasintmin"))
                lEntidad.ntasintmax = IIf(.Item("ntasintmax") Is DBNull.Value, 0, .Item("ntasintmax"))
                lEntidad.nplazomin = IIf(.Item("nplazomin") Is DBNull.Value, 0, .Item("nplazomin"))
                lEntidad.nplazomax = IIf(.Item("nplazomax") Is DBNull.Value, 0, .Item("nplazomax"))
                lEntidad.lliva = IIf(.Item("lliva") Is DBNull.Value, Nothing, .Item("lliva"))
                lEntidad.nocuotas = IIf(.Item("nocuotas") Is DBNull.Value, Nothing, .Item("nocuotas"))
                lEntidad.nmoncuo = IIf(.Item("nmoncuo") Is DBNull.Value, Nothing, .Item("nmoncuo"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cretlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(),0) + 1 ")
        strSQL.Append(" FROM cretlin ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function Obtenernrolin() As String

        Dim strSQL As New StringBuilder
        Dim lcnrolin As String
        Dim i As Integer
        Dim tamano As Integer

        strSQL.Append("SELECT max(cnrolin)+100 as cnrolin")
        strSQL.Append(" FROM cretlin ")

        '        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        '        Dim args(1) As SqlParameter
        '       args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("cnrolin")) Then
                lcnrolin = "0000100"
            Else
                lcnrolin = ds.Tables(0).Rows(0)("cnrolin")
                lcnrolin.Trim()
                tamano = lcnrolin.Trim.Length
                For i = 1 To 7 - tamano
                    lcnrolin = "0" & lcnrolin
                Next

            End If
        Else
            lcnrolin = "0000100" 'Nothing
        End If
        Return lcnrolin

    End Function

    Public Function ObtenerListaPorID() As listacretlin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE lactiva = 1 ")
        strSQL.Append(" order by cdeslin")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacretlin

        Try
            Do While dr.Read()
                Dim mEntidad As New cretlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.llinusa = IIf(dr("llinusa") Is DBNull.Value, Nothing, dr("llinusa"))
                mEntidad.llinpre = IIf(dr("llinpre") Is DBNull.Value, Nothing, dr("llinpre"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmondes = IIf(dr("nmondes") Is DBNull.Value, Nothing, dr("nmondes"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ladmon = IIf(dr("ladmon") Is DBNull.Value, Nothing, dr("ladmon"))
                mEntidad.lsegvida = IIf(dr("lsegvida") Is DBNull.Value, Nothing, dr("lsegvida"))
                mEntidad.lsegdeu = IIf(dr("lsegdeu") Is DBNull.Value, Nothing, dr("lsegdeu"))
                mEntidad.lredo = IIf(dr("lredo") Is DBNull.Value, Nothing, dr("lredo"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
                mEntidad.ctiplin = IIf(dr("ctiplin") Is DBNull.Value, Nothing, dr("ctiplin"))
                mEntidad.ctipo = IIf(dr("ctipo") Is DBNull.Value, Nothing, dr("ctipo"))
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.nplazomin = IIf(dr("nplazomin") Is DBNull.Value, Nothing, dr("nplazomin"))
                mEntidad.nplazomax = IIf(dr("nplazomax") Is DBNull.Value, Nothing, dr("nplazomax"))
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

    Public Function ObtenerListaPorLinea(ByVal linea As String) As listacretlin
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE cdeslin like" & "'" & "%" & linea & "%" & "'")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@linea", SqlDbType.VarChar)
        args(0).Value = linea

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacretlin

        Try
            Do While dr.Read()
                Dim mEntidad As New cretlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.llinusa = IIf(dr("llinusa") Is DBNull.Value, Nothing, dr("llinusa"))
                mEntidad.llinpre = IIf(dr("llinpre") Is DBNull.Value, Nothing, dr("llinpre"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmondes = IIf(dr("nmondes") Is DBNull.Value, Nothing, dr("nmondes"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ladmon = IIf(dr("ladmon") Is DBNull.Value, Nothing, dr("ladmon"))
                mEntidad.lsegvida = IIf(dr("lsegvida") Is DBNull.Value, Nothing, dr("lsegvida"))
                mEntidad.lsegdeu = IIf(dr("lsegdeu") Is DBNull.Value, Nothing, dr("lsegdeu"))
                mEntidad.lredo = IIf(dr("lredo") Is DBNull.Value, Nothing, dr("lredo"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
                mEntidad.ctiplin = IIf(dr("ctiplin") Is DBNull.Value, Nothing, dr("ctiplin"))
                mEntidad.ctipo = IIf(dr("ctipo") Is DBNull.Value, Nothing, dr("ctipo"))
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("cretlin")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT cnrolin, ")
        strSQL.Append(" ccodlin, ")
        strSQL.Append(" dfecvig, ")
        strSQL.Append(" cdeslin, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" ctipcal, ")
        strSQL.Append(" ntasmor, ")
        strSQL.Append(" nliminf, ")
        strSQL.Append(" nlimsup, ")
        strSQL.Append(" lactiva, ")
        strSQL.Append(" llinusa, ")
        strSQL.Append(" llinpre, ")
        strSQL.Append(" cnropar, ")
        strSQL.Append(" nmondes, ")
        strSQL.Append(" ctipdes, ")
        strSQL.Append(" ndesuso, ")
        strSQL.Append(" ladmon, ")
        strSQL.Append(" lsegvida, ")
        strSQL.Append(" lsegdeu, ")
        strSQL.Append(" lredo, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" ccodrub, ")
        strSQL.Append(" ctiplin, ")
        strSQL.Append(" ctipo, ")
        strSQL.Append(" ccodbco, ")
        strSQL.Append(" cctacte,ntasintmin, ntasintmax, nplazomin, nplazomax, ")
        strSQL.Append(" isnull(lliva,0) as lliva, isnull(nocuotas,0) as nocuotas, isnull(nmoncuo,0) as nmoncuo ")
        strSQL.Append(" FROM cretlin ")

    End Sub

    Public Function Recuperarporllave(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin


        'Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                'lEntidad.cnrolin = IIf(.Item("cnrolin") Is DBNull.Value, Nothing, .Item("cnrolin"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.dfecvig = IIf(.Item("dfecvig") Is DBNull.Value, Nothing, .Item("dfecvig"))
                lEntidad.cdeslin = IIf(.Item("cdeslin") Is DBNull.Value, Nothing, .Item("cdeslin"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.ctipcal = IIf(.Item("ctipcal") Is DBNull.Value, Nothing, .Item("ctipcal"))
                lEntidad.ntasmor = IIf(.Item("ntasmor") Is DBNull.Value, Nothing, .Item("ntasmor"))
                lEntidad.nliminf = IIf(.Item("nliminf") Is DBNull.Value, Nothing, .Item("nliminf"))
                lEntidad.nlimsup = IIf(.Item("nlimsup") Is DBNull.Value, Nothing, .Item("nlimsup"))
                lEntidad.lactiva = IIf(.Item("lactiva") Is DBNull.Value, Nothing, .Item("lactiva"))
                lEntidad.llinusa = IIf(.Item("llinusa") Is DBNull.Value, Nothing, .Item("llinusa"))
                lEntidad.llinpre = IIf(.Item("llinpre") Is DBNull.Value, Nothing, .Item("llinpre"))
                lEntidad.cnropar = IIf(.Item("cnropar") Is DBNull.Value, Nothing, .Item("cnropar"))
                lEntidad.nmondes = IIf(.Item("nmondes") Is DBNull.Value, Nothing, .Item("nmondes"))
                lEntidad.ctipdes = IIf(.Item("ctipdes") Is DBNull.Value, Nothing, .Item("ctipdes"))
                lEntidad.ndesuso = IIf(.Item("ndesuso") Is DBNull.Value, Nothing, .Item("ndesuso"))
                lEntidad.ladmon = IIf(.Item("ladmon") Is DBNull.Value, Nothing, .Item("ladmon"))
                lEntidad.lsegvida = IIf(.Item("lsegvida") Is DBNull.Value, Nothing, .Item("lsegvida"))
                lEntidad.lsegdeu = IIf(.Item("lsegdeu") Is DBNull.Value, Nothing, .Item("lsegdeu"))
                lEntidad.lredo = IIf(.Item("lredo") Is DBNull.Value, Nothing, .Item("lredo"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.ccodrub = IIf(.Item("ccodrub") Is DBNull.Value, Nothing, .Item("ccodrub"))
                lEntidad.ctiplin = IIf(.Item("ctiplin") Is DBNull.Value, Nothing, .Item("ctiplin"))
                lEntidad.ctipo = IIf(.Item("ctipo") Is DBNull.Value, Nothing, .Item("ctipo"))
                lEntidad.ccodbco = IIf(.Item("ccodbco") Is DBNull.Value, Nothing, .Item("ccodbco"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.nplazomin = IIf(.Item("nplazomin") Is DBNull.Value, Nothing, .Item("nplazomin"))
                lEntidad.nplazomax = IIf(.Item("nplazomax") Is DBNull.Value, Nothing, .Item("nplazomax"))
                lEntidad.lliva = IIf(.Item("lliva") Is DBNull.Value, Nothing, .Item("lliva"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Function ObtenerDataSetPorID2(ByVal pcnrolin As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" where left(cretlin.cnrolin,5) =  Left(@pcnrolin,5)")

        '        strSQL.Append(" WHERE ccodcta = ?ccodcta ")
        '        strSQL.Append(" AND ctipope <> 'D' order by dfecven ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcnrolin", SqlDbType.VarChar)
        args(0).Value = pcnrolin

        Dim tables(0) As String
        tables(0) = New String("cretlin")

        Try
            sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)
        Catch ex As Exception
            Return 0
        End Try

        Return 1

    End Function


    Public Function ObtenerDataSetPorcuena2() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorcuena(ByVal pcnrolin As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @pcnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcnrolin", SqlDbType.VarChar)
        args(0).Value = pcnrolin

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerFuentedeFondos(ByVal pcnrolin As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("Select TABTTAB.cdescri from TABTTAB, CRETLIN")
        strSQL.Append(" WHERE CRETLIN.cnrolin = @pcnrolin ")
        strSQL.Append(" and TABTTAB.ccodtab = '033' and TABTTAB.ctipreg = '1'")
        strSQL.Append(" and substring(CRETLIN.ccodlin,3,2) = left(TABTTAB.ccodigo,2) ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcnrolin", SqlDbType.VarChar)
        args(0).Value = pcnrolin

        Dim ds As DataSet
        Dim lcfondo As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcfondo = ""
        Else
            lcfondo = ds.Tables(0).Rows(0)("cdescri")
        End If
        Return lcfondo
    End Function

    'Recupera lineas por fuente de fondo
    Public Function RecuperarporFuente(ByVal cCodfue As String, ByVal cTipo As String) As DataSet


        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE substring(cCodlin,3,2) = @cCodfue and  lactiva = 1 and substring(cCodlin,5,2) =@ctipo ")
        strSQL.Append(" order by cdeslin ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodfue", SqlDbType.VarChar)
        args(0).Value = cCodfue

        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = cTipo

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
        'Dim lista As New listacretlin

        'Try
        '    Do While dr.Read()
        '        Dim mEntidad As New cretlin
        '        mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
        '        mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
        '        mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
        '        mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
        '        mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
        '        mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
        '        mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
        '        mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
        '        mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
        '        mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
        '        mEntidad.llinusa = IIf(dr("llinusa") Is DBNull.Value, Nothing, dr("llinusa"))
        '        mEntidad.llinpre = IIf(dr("llinpre") Is DBNull.Value, Nothing, dr("llinpre"))
        '        mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
        '        mEntidad.nmondes = IIf(dr("nmondes") Is DBNull.Value, Nothing, dr("nmondes"))
        '        mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
        '        mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
        '        mEntidad.ladmon = IIf(dr("ladmon") Is DBNull.Value, Nothing, dr("ladmon"))
        '        mEntidad.lsegvida = IIf(dr("lsegvida") Is DBNull.Value, Nothing, dr("lsegvida"))
        '        mEntidad.lsegdeu = IIf(dr("lsegdeu") Is DBNull.Value, Nothing, dr("lsegdeu"))
        '        mEntidad.lredo = IIf(dr("lredo") Is DBNull.Value, Nothing, dr("lredo"))
        '        mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
        '        mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
        '        mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
        '        mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
        '        mEntidad.ctiplin = IIf(dr("ctiplin") Is DBNull.Value, Nothing, dr("ctiplin"))
        '        mEntidad.ctipo = IIf(dr("ctipo") Is DBNull.Value, Nothing, dr("ctipo"))
        '        mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
        '        mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
        '        lista.Add(mEntidad)
        '    Loop
        'Catch ex As Exception
        '    Throw ex
        'Finally
        '    dr.Close()
        'End Try

        'Return lista

    End Function
    Public Function ObtieneLineaGrupo(ByVal cCodsol As String, ByVal dfecvig As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cretlin.cdeslin from cretlin, cremcre ")
        strSQL.Append("WHERE cremcre.cCodsol = @cCodsol and cremcre.dfecvig>=@dfecvig and cremcre.dfecvig<=@dfecvig ")
        strSQL.Append(" and cremcre.cnrolin = cretlin.cnrolin ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.Char)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(1).Value = dfecvig

        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = ""
        Else
            lcnomusu = ds.Tables(0).Rows(0)("cdeslin")
        End If
        Return lcnomusu


    End Function

    Public Function ObtenerFuentedeFondosCodigo(ByVal pcnrolin As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("Select left(TABTTAB.ccodigo,2) as ccodigo from TABTTAB, CRETLIN")
        strSQL.Append(" WHERE CRETLIN.cnrolin = @pcnrolin ")
        strSQL.Append(" and TABTTAB.ccodtab = '033' and TABTTAB.ctipreg = '1'")
        strSQL.Append(" and substring(CRETLIN.ccodlin,3,2) = left(TABTTAB.ccodigo,2) ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcnrolin", SqlDbType.VarChar)
        args(0).Value = pcnrolin

        Dim ds As DataSet
        Dim lcfondo As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lcfondo = ""
        Else
            lcfondo = ds.Tables(0).Rows(0)("ccodigo")
        End If
        Return lcfondo
    End Function

    Public Function ObtieneLinea(ByVal cnrolin As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cretlin.cdeslin from cretlin ")
        strSQL.Append("WHERE cretlin.cnrolin = @cnrolin  ")



        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
        args(0).Value = cnrolin

        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = ""
        Else
            lcnomusu = ds.Tables(0).Rows(0)("cdeslin")
        End If
        Return lcnomusu


    End Function

    Public Function ObtieneCodigoLinea(ByVal cnrolin As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cretlin.cCodlin from cretlin ")
        strSQL.Append("WHERE cretlin.cnrolin = @cnrolin  ")



        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
        args(0).Value = cnrolin

        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = ""
        Else
            lcnomusu = IIf(IsDBNull(ds.Tables(0).Rows(0)("cCodlin")), "", ds.Tables(0).Rows(0)("cCodlin"))
        End If
        Return lcnomusu


    End Function
    Public Function ObtieneCodigoLineadecredito(ByVal ccodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cretlin.cCodlin from cretlin, cremcre ")
        strSQL.Append("WHERE cremcre.cnrolin =cretlin.cnrolin and cremcre.ccodcta= @ccodcta  ")



        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.Char)
        args(0).Value = ccodcta

        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = "9999999999"
        Else
            lcnomusu = IIf(IsDBNull(ds.Tables(0).Rows(0)("cCodlin")), "", ds.Tables(0).Rows(0)("cCodlin"))
        End If
        Return lcnomusu


    End Function


    Public Function ObtenerListaPorIDTodas() As listacretlin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" order by cdeslin")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacretlin

        Try
            Do While dr.Read()
                Dim mEntidad As New cretlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.llinusa = IIf(dr("llinusa") Is DBNull.Value, Nothing, dr("llinusa"))
                mEntidad.llinpre = IIf(dr("llinpre") Is DBNull.Value, Nothing, dr("llinpre"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmondes = IIf(dr("nmondes") Is DBNull.Value, Nothing, dr("nmondes"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ladmon = IIf(dr("ladmon") Is DBNull.Value, Nothing, dr("ladmon"))
                mEntidad.lsegvida = IIf(dr("lsegvida") Is DBNull.Value, Nothing, dr("lsegvida"))
                mEntidad.lsegdeu = IIf(dr("lsegdeu") Is DBNull.Value, Nothing, dr("lsegdeu"))
                mEntidad.lredo = IIf(dr("lredo") Is DBNull.Value, Nothing, dr("lredo"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
                mEntidad.ctiplin = IIf(dr("ctiplin") Is DBNull.Value, Nothing, dr("ctiplin"))
                mEntidad.ctipo = IIf(dr("ctipo") Is DBNull.Value, Nothing, dr("ctipo"))
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function VericasiestaActivada(ByVal cnrolin As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cretlin.lactiva from cretlin ")
        strSQL.Append("WHERE cretlin.cnrolin = @cnrolin  ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
        args(0).Value = cnrolin

        Dim ds As New DataSet
        Dim lactiva As Boolean = False
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("lactiva")) Then
            Else

                lactiva = ds.Tables(0).Rows(0)("lactiva")
            End If

        End If

        Return lactiva
    End Function

    Public Function Recuperarpor_Metodo(ByVal metodo As String) As DataSet


        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE   lactiva = 1 and substring(cCodlin,5,2) = @metodo")
        strSQL.Append(" order by cdeslin ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@metodo", SqlDbType.VarChar)
        args(0).Value = metodo
        


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function RecuperarporCartera(ByVal cTipo As String, ByVal metodo As String, ByVal ccodfue As String) As DataSet


        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE   lactiva = 1 and substring(cCodlin,5,2) = @metodo and substring(cCodlin,9,2) =@ctipo and substring(ccodlin,3,2) = @ccodfue ")
        strSQL.Append(" order by cdeslin ")

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(0).Value = cTipo
        args(1) = New SqlParameter("@metodo", SqlDbType.VarChar)
        args(1).Value = metodo
        args(2) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(2).Value = ccodfue


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtieneNroLineaCredito(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.cnrolin from  cremcre ")
        strSQL.Append("WHERE cremcre.cCodcta = @cCodcta ")



        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.Char)
        args(0).Value = cCodcta


        Dim ds As DataSet
        Dim lcnrolin As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnrolin = ""
        Else
            lcnrolin = ds.Tables(0).Rows(0)("cnrolin")
        End If
        Return lcnrolin


    End Function
    Public Function RecuperarporFuenteTodos(ByVal cCodfue As String, ByVal cTipo As String) As DataSet


        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE substring(cCodlin,3,2) = @cCodfue and  substring(cCodlin,5,2) =@ctipo ")
        strSQL.Append(" order by cdeslin ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodfue", SqlDbType.VarChar)
        args(0).Value = cCodfue

        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = cTipo

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerTasaEstandar(ByVal cnrolin As String) As Decimal
        Dim strsQL As New StringBuilder
        strsQL.Append("select ntasint from cretlin ")
        strsQL.Append("where cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
        args(0).Value = cnrolin

        Dim ds As New DataSet
        Dim lntasint As Decimal = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lntasint = IIf(IsDBNull(ds.Tables(0).Rows(0)("ntasint")), "", ds.Tables(0).Rows(0)("ntasint"))
        End If
        Return lntasint

    End Function
    Public Function ObtenerTasaMinima(ByVal cnrolin As String) As Decimal
        Dim strsQL As New StringBuilder
        strsQL.Append("select ntasintmin from cretlin ")
        strsQL.Append("where cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
        args(0).Value = cnrolin

        Dim ds As New DataSet
        Dim lntasint As Decimal = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lntasint = IIf(IsDBNull(ds.Tables(0).Rows(0)("ntasintmin")), "", ds.Tables(0).Rows(0)("ntasintmin"))
        End If
        Return lntasint

    End Function
    Public Function ObtenerTasaMaxima(ByVal cnrolin As String) As Decimal
        Dim strsQL As New StringBuilder
        strsQL.Append("select ntasintmax from cretlin ")
        strsQL.Append("where cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
        args(0).Value = cnrolin

        Dim ds As New DataSet
        Dim lntasint As Decimal = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lntasint = IIf(IsDBNull(ds.Tables(0).Rows(0)("ntasintmax")), "", ds.Tables(0).Rows(0)("ntasintmax"))
        End If
        Return lntasint

    End Function
    Public Function ObtenerProducto(ByVal programa As String, ByVal metodo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select lineaaux.producto as ccodigo, tabttab.cdescri from lineaaux, tabttab  ")
        strSQL.Append("where lineaaux.producto = tabttab.ccodigo ")
        strSQL.Append("and tabttab.ccodtab ='075' and tabttab.ctipreg = '1'  ")
        strSQL.Append("and lineaaux.programa = @programa and  lineaaux.metodo = @metodo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@programa", SqlDbType.Char)
        args(0).Value = programa
        args(1) = New SqlParameter("@metodo", SqlDbType.Char)
        args(1).Value = metodo


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function Verifica_Linea_Revolvente(ByVal ccodcta As String) As Boolean
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lverifica As Boolean = False

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Select cretlin.llinpre from cretlin, cremcre  where cremcre.cnrolin = cretlin.cnrolin and  " & _
                                      "cremcre.ccodcta ='" & ccodcta & "'"
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Linea")

                For Each fila As DataRow In ds.Tables("Linea").Rows
                    lverifica = IIf(fila("llinpre") = 0, False, True)
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()

            End Try

        End Using
        Return lverifica
    End Function

    Public Function UpdateCremcre(ByVal ccodcta As String, ByVal nmonsug As Integer)


        Dim strSQL As New StringBuilder

        strSQL.Append(" update cremcre set nmonsug=@nmonsug where ccodcta=@ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nmonsug", nmonsug)
        args(1) = New SqlParameter("@ccodcta", ccodcta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
End Class
