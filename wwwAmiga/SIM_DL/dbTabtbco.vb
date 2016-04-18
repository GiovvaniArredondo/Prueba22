Imports System.Text
Public Class dbTabtbco
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtbco
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodbco =  "" _
            Or lEntidad.ccodbco = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodbco = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtbco ")
        strSQL.Append(" SET cnombco = @cnombco, ") 
        strSQL.Append(" ctipcta = @ctipcta, ") 
        strSQL.Append(" cctacte = @cctacte, ") 
        strSQL.Append(" cserie = @cserie, ") 
        strSQL.Append(" cnroini = @cnroini, ") 
        strSQL.Append(" cnrofin = @cnrofin, ") 
        strSQL.Append(" ccodcta = @ccodcta, ") 
        strSQL.Append(" cnocorr = @cnocorr, ") 
        strSQL.Append(" nmondeb = @nmondeb, ") 
        strSQL.Append(" nmonhab = @nmonhab, ") 
        strSQL.Append(" saldant = @saldant, ") 
        strSQL.Append(" ncargos = @ncargos, ") 
        strSQL.Append(" nabonos = @nabonos, ") 
        strSQL.Append(" saldact = @saldact, ") 
        strSQL.Append(" uso = @uso, ") 
        strSQL.Append(" cguberna = @cguberna, ") 
        strSQL.Append(" cnomcta = @cnomcta, ") 
        strSQL.Append(" cfondos = @cfondos, ") 
        strSQL.Append(" ccodreg = @ccodreg, ") 
        strSQL.Append(" cgrupo = @cgrupo, ")
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" ccodofi = @ccodofi ")
        strSQL.Append(" WHERE ccodbco = @ccodbco ") 

        Dim args(22) As SqlParameter
        args(0) = New SqlParameter("@cnombco", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnombco
        args(1) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipcta
        args(2) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(2).Value = lEntidad.cctacte
        args(3) = New SqlParameter("@cserie", SqlDbType.VarChar)
        args(3).Value = lEntidad.cserie
        args(4) = New SqlParameter("@cnroini", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnroini
        args(5) = New SqlParameter("@cnrofin", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnrofin
        args(6) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodcta
        args(7) = New SqlParameter("@cnocorr", SqlDbType.VarChar)
        args(7).Value = lEntidad.cnocorr
        args(8) = New SqlParameter("@nmondeb", SqlDbType.VarChar)
        args(8).Value = lEntidad.nmondeb
        args(9) = New SqlParameter("@nmonhab", SqlDbType.VarChar)
        args(9).Value = lEntidad.nmonhab
        args(10) = New SqlParameter("@saldant", SqlDbType.VarChar)
        args(10).Value = lEntidad.saldant
        args(11) = New SqlParameter("@ncargos", SqlDbType.VarChar)
        args(11).Value = lEntidad.ncargos
        args(12) = New SqlParameter("@nabonos", SqlDbType.VarChar)
        args(12).Value = lEntidad.nabonos
        args(13) = New SqlParameter("@saldact", SqlDbType.VarChar)
        args(13).Value = lEntidad.saldact
        args(14) = New SqlParameter("@uso", SqlDbType.Bit)
        args(14).Value = IIf(lEntidad.uso = Nothing, DBNull.Value, lEntidad.uso)
        args(15) = New SqlParameter("@cguberna", SqlDbType.VarChar)
        args(15).Value = lEntidad.cguberna
        args(16) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(16).Value = lEntidad.cnomcta
        args(17) = New SqlParameter("@cfondos", SqlDbType.VarChar)
        args(17).Value = lEntidad.cfondos
        args(18) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodreg
        args(19) = New SqlParameter("@cgrupo", SqlDbType.VarChar)
        args(19).Value = lEntidad.cgrupo
        args(20) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(20).Value = lEntidad.cflag
        args(21) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccodofi
        args(22) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(22).Value = IIf(lEntidad.ccodbco = Nothing, DBNull.Value,lEntidad.ccodbco)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtbco
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtbco ")
        strSQL.Append(" ( ccodbco, ") 
        strSQL.Append(" cnombco, ") 
        strSQL.Append(" ctipcta, ") 
        strSQL.Append(" cctacte, ") 
        strSQL.Append(" cserie, ") 
        strSQL.Append(" cnroini, ") 
        strSQL.Append(" cnrofin, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" cnocorr, ") 
        strSQL.Append(" nmondeb, ") 
        strSQL.Append(" nmonhab, ") 
        strSQL.Append(" saldant, ") 
        strSQL.Append(" ncargos, ") 
        strSQL.Append(" nabonos, ") 
        strSQL.Append(" saldact, ") 
        strSQL.Append(" uso, ") 
        strSQL.Append(" cguberna, ") 
        strSQL.Append(" cnomcta, ") 
        strSQL.Append(" cfondos, ") 
        strSQL.Append(" ccodreg, ") 
        strSQL.Append(" cgrupo, ")
        strSQL.Append(" cflag, ") 
        strSQL.Append(" ccodofi) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodbco, ") 
        strSQL.Append(" @cnombco, ") 
        strSQL.Append(" @ctipcta, ") 
        strSQL.Append(" @cctacte, ") 
        strSQL.Append(" @cserie, ") 
        strSQL.Append(" @cnroini, ") 
        strSQL.Append(" @cnrofin, ") 
        strSQL.Append(" @ccodcta, ") 
        strSQL.Append(" @cnocorr, ") 
        strSQL.Append(" @nmondeb, ") 
        strSQL.Append(" @nmonhab, ") 
        strSQL.Append(" @saldant, ") 
        strSQL.Append(" @ncargos, ") 
        strSQL.Append(" @nabonos, ") 
        strSQL.Append(" @saldact, ") 
        strSQL.Append(" @uso, ") 
        strSQL.Append(" @cguberna, ") 
        strSQL.Append(" @cnomcta, ") 
        strSQL.Append(" @cfondos, ") 
        strSQL.Append(" @ccodreg, ") 
        strSQL.Append(" @cgrupo, ")
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @ccodofi) ")

        Dim args(22) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodbco = Nothing, DBNull.Value, lEntidad.ccodbco)
        args(1) = New SqlParameter("@cnombco", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnombco
        args(2) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipcta
        args(3) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(3).Value = lEntidad.cctacte
        args(4) = New SqlParameter("@cserie", SqlDbType.VarChar)
        args(4).Value = lEntidad.cserie
        args(5) = New SqlParameter("@cnroini", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnroini
        args(6) = New SqlParameter("@cnrofin", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnrofin
        args(7) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodcta
        args(8) = New SqlParameter("@cnocorr", SqlDbType.VarChar)
        args(8).Value = lEntidad.cnocorr
        args(9) = New SqlParameter("@nmondeb", SqlDbType.VarChar)
        args(9).Value = lEntidad.nmondeb
        args(10) = New SqlParameter("@nmonhab", SqlDbType.VarChar)
        args(10).Value = lEntidad.nmonhab
        args(11) = New SqlParameter("@saldant", SqlDbType.VarChar)
        args(11).Value = lEntidad.saldant
        args(12) = New SqlParameter("@ncargos", SqlDbType.VarChar)
        args(12).Value = lEntidad.ncargos
        args(13) = New SqlParameter("@nabonos", SqlDbType.VarChar)
        args(13).Value = lEntidad.nabonos
        args(14) = New SqlParameter("@saldact", SqlDbType.VarChar)
        args(14).Value = lEntidad.saldact
        args(15) = New SqlParameter("@uso", SqlDbType.Bit)
        args(15).Value = IIf(lEntidad.uso = Nothing, DBNull.Value, lEntidad.uso)
        args(16) = New SqlParameter("@cguberna", SqlDbType.VarChar)
        args(16).Value = lEntidad.cguberna
        args(17) = New SqlParameter("@cnomcta", SqlDbType.VarChar)
        args(17).Value = lEntidad.cnomcta
        args(18) = New SqlParameter("@cfondos", SqlDbType.VarChar)
        args(18).Value = lEntidad.cfondos
        args(19) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodreg
        args(20) = New SqlParameter("@cgrupo", SqlDbType.VarChar)
        args(20).Value = lEntidad.cgrupo
        args(21) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(21).Value = lEntidad.cflag
        args(22) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(22).Value = lEntidad.ccodofi

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtbco
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtbco ")
        strSQL.Append(" WHERE ccodbco = @ccodbco ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodbco

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtbco
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodbco = @ccodbco ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodbco

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnombco = IIf(.Item("cnombco") Is DBNull.Value, Nothing, .Item("cnombco"))
                lEntidad.ctipcta = IIf(.Item("ctipcta") Is DBNull.Value, Nothing, .Item("ctipcta"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.cserie = IIf(.Item("cserie") Is DBNull.Value, Nothing, .Item("cserie"))
                lEntidad.cnroini = IIf(.Item("cnroini") Is DBNull.Value, Nothing, .Item("cnroini"))
                lEntidad.cnrofin = IIf(.Item("cnrofin") Is DBNull.Value, Nothing, .Item("cnrofin"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cnocorr = IIf(.Item("cnocorr") Is DBNull.Value, Nothing, .Item("cnocorr"))
                lEntidad.nmondeb = IIf(.Item("nmondeb") Is DBNull.Value, Nothing, .Item("nmondeb"))
                lEntidad.nmonhab = IIf(.Item("nmonhab") Is DBNull.Value, Nothing, .Item("nmonhab"))
                lEntidad.saldant = IIf(.Item("saldant") Is DBNull.Value, Nothing, .Item("saldant"))
                lEntidad.ncargos = IIf(.Item("ncargos") Is DBNull.Value, Nothing, .Item("ncargos"))
                lEntidad.nabonos = IIf(.Item("nabonos") Is DBNull.Value, Nothing, .Item("nabonos"))
                lEntidad.saldact = IIf(.Item("saldact") Is DBNull.Value, Nothing, .Item("saldact"))
                lEntidad.uso = IIf(.Item("uso") Is DBNull.Value, Nothing, .Item("uso"))
                lEntidad.cguberna = IIf(.Item("cguberna") Is DBNull.Value, Nothing, .Item("cguberna"))
                lEntidad.cnomcta = IIf(.Item("cnomcta") Is DBNull.Value, Nothing, .Item("cnomcta"))
                lEntidad.cfondos = IIf(.Item("cfondos") Is DBNull.Value, Nothing, .Item("cfondos"))
                lEntidad.ccodreg = IIf(.Item("ccodreg") Is DBNull.Value, Nothing, .Item("ccodreg"))
                lEntidad.cgrupo = IIf(.Item("cgrupo") Is DBNull.Value, Nothing, .Item("cgrupo"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtbco
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodbco),0) + 1 ")
        strSQL.Append(" FROM tabtbco ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listatabtbco

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listatabtbco

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtbco
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cnombco = IIf(dr("cnombco") Is DBNull.Value, Nothing, dr("cnombco"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.cserie = IIf(dr("cserie") Is DBNull.Value, Nothing, dr("cserie"))
                mEntidad.cnroini = IIf(dr("cnroini") Is DBNull.Value, Nothing, dr("cnroini"))
                mEntidad.cnrofin = IIf(dr("cnrofin") Is DBNull.Value, Nothing, dr("cnrofin"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cnocorr = IIf(dr("cnocorr") Is DBNull.Value, Nothing, dr("cnocorr"))
                mEntidad.nmondeb = IIf(dr("nmondeb") Is DBNull.Value, Nothing, dr("nmondeb"))
                mEntidad.nmonhab = IIf(dr("nmonhab") Is DBNull.Value, Nothing, dr("nmonhab"))
                mEntidad.saldant = IIf(dr("saldant") Is DBNull.Value, Nothing, dr("saldant"))
                mEntidad.ncargos = IIf(dr("ncargos") Is DBNull.Value, Nothing, dr("ncargos"))
                mEntidad.nabonos = IIf(dr("nabonos") Is DBNull.Value, Nothing, dr("nabonos"))
                mEntidad.saldact = IIf(dr("saldact") Is DBNull.Value, Nothing, dr("saldact"))
                mEntidad.uso = IIf(dr("uso") Is DBNull.Value, Nothing, dr("uso"))
                mEntidad.cguberna = IIf(dr("cguberna") Is DBNull.Value, Nothing, dr("cguberna"))
                mEntidad.cnomcta = IIf(dr("cnomcta") Is DBNull.Value, Nothing, dr("cnomcta"))
                mEntidad.cfondos = IIf(dr("cfondos") Is DBNull.Value, Nothing, dr("cfondos"))
                mEntidad.ccodreg = IIf(dr("ccodreg") Is DBNull.Value, Nothing, dr("ccodreg"))
                mEntidad.cgrupo = IIf(dr("cgrupo") Is DBNull.Value, Nothing, dr("cgrupo"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
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

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet, ByVal ccodofi As String) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        'strSQL.Append(" WHERE uso = '1'  ")
        If ccodofi.Trim = "001" Then
        Else
            '        strSQL.Append(" and cCodofi = @cCodofi ")
        End If
        strSQL.Append(" ORDER BY ccodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi

        Dim tables(0) As String
        tables(0) = New String("tabtbco")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Public Function ObtenerDataSetPorIDTodos(ByRef ds As DataSet, ByVal ccodofi As String, ByVal cgrupo As String) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT left(tabtbco.ccodbco,2) as ccodbco, ")
        strSQL.Append(" tabtbco.cnombco, ")
        strSQL.Append(" tabtbco.ctipcta, ")
        strSQL.Append(" tabtbco.cctacte, ")
        strSQL.Append(" tabtbco.cserie, ")
        strSQL.Append(" tabtbco.cnroini, ")
        strSQL.Append(" tabtbco.cnrofin, ")
        strSQL.Append(" tabtbco.ccodcta, ")
        strSQL.Append(" tabtbco.cnocorr, ")
        strSQL.Append(" tabtbco.nmondeb, ")
        strSQL.Append(" tabtbco.nmonhab, ")
        strSQL.Append(" tabtbco.saldant, ")
        strSQL.Append(" tabtbco.ncargos, ")
        strSQL.Append(" tabtbco.nabonos, ")
        strSQL.Append(" tabtbco.saldact, ")
        strSQL.Append(" tabtbco.uso, ")
        strSQL.Append(" tabtbco.cguberna, ")
        strSQL.Append(" tabtbco.cnomcta, ")
        strSQL.Append(" tabtbco.cfondos, ")
        strSQL.Append(" tabtbco.ccodreg, ")
        strSQL.Append(" tabtbco.cgrupo, ")
        strSQL.Append(" tabtbco.cflag, ")
        strSQL.Append(" tabtbco.ccodofi ")


        If ccodofi = "001" Then
            strSQL.Append(" FROM tabtbco ")
            strSQL.Append(" WHERE tabtbco.Uso = '1' and tabtbco.cgrupo = @cgrupo  ")
        Else
            strSQL.Append(" FROM tabtbco, BANCOOFI ")
            strSQL.Append(" WHERE tabtbco.ccodbco = BANCOOFI.ccodbco and bancoofi.ccodofi =@ccodofi and  tabtbco.Uso = '1'  ")
            strSQL.Append(" and (tabtbco.cgrupo = '*' or tabtbco.cgrupo = @cgrupo) ")
        End If

        strSQL.Append(" ORDER BY tabtbco.cnombco ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)
        args(1) = New SqlParameter("@cgrupo", cgrupo)

        Dim tables(0) As String
        tables(0) = New String("tabtbco")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function
    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT left(ccodbco,2) as ccodbco, ")
        strSQL.Append(" cnombco, ")
        strSQL.Append(" ctipcta, ")
        strSQL.Append(" cctacte, ")
        strSQL.Append(" cserie, ")
        strSQL.Append(" cnroini, ")
        strSQL.Append(" cnrofin, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" cnocorr, ")
        strSQL.Append(" nmondeb, ")
        strSQL.Append(" nmonhab, ")
        strSQL.Append(" saldant, ")
        strSQL.Append(" ncargos, ")
        strSQL.Append(" nabonos, ")
        strSQL.Append(" saldact, ")
        strSQL.Append(" uso, ")
        strSQL.Append(" cguberna, ")
        strSQL.Append(" cnomcta, ")
        strSQL.Append(" cfondos, ")
        strSQL.Append(" ccodreg, ")
        strSQL.Append(" cgrupo, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" ccodofi ")
        strSQL.Append(" FROM tabtbco ")

    End Sub
    Public Function CuentadeBanco(ByVal ccodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtbco.cctacte from tabtbco where ccodbco = @ccodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)
        

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds.Tables(0).Rows(0)("cctacte")
        End If
    End Function

    Public Function maxbanco() As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select max(ccodbco)+1 as cCodbco from tabtbco ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString)

        If ds.Tables(0).Rows.Count = 0 Then
            Return "01"
        Else
            Return ds.Tables(0).Rows(0)("ccodbco")
        End If

    End Function

    Public Function NombredeBanco(ByVal ccodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtbco.cnombco from tabtbco where ccodbco = @ccodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds.Tables(0).Rows(0)("cnombco")
        End If
    End Function
    Public Function RetornaCheque(ByVal ccodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtbco.cnocorr from tabtbco where ccodbco= @ccodbco")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcnrocorr As String

        lcnrocorr = "1"

        If ds.Tables(0).Rows.Count = 0 Then

        Else

            lcnrocorr = IIf(IsDBNull(ds.Tables(0).Rows(0)("cnocorr")), "1", (Integer.Parse(ds.Tables(0).Rows(0)("cnocorr")) + 1).ToString)
        End If
        Return lcnrocorr
    End Function
    Public Function CuentadeBanco1(ByVal ccodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtbco.cctacte from tabtbco where ccodbco = @ccodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds.Tables(0).Rows(0)("cctacte")
        End If
    End Function

    Public Function ActualizaCorrelativo(ByVal cCodbco As String, ByVal cnrochq As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtbco SET cnocorr = @cnrochq where ccodbco = @ccodbco ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", cCodbco)
        args(1) = New SqlParameter("@cnrochq", cnrochq)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function CuentadeBancoContable(ByVal ccodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtbco.ccodcta from tabtbco where ccodbco = @ccodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds.Tables(0).Rows(0)("ccodcta")
        End If
    End Function
    Public Function CuentaContableBanco(ByVal cCodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodcta FROM TABTBCO Where cCodbco = @cCodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", cCodbco)
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return "*"
        Else
            Return ds.Tables(0).Rows(0)("cCodcta")
        End If


    End Function

    Public Function ObtenerBancosenUso(ByRef ds As DataSet, ByVal ccodofi As String) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE Uso = '1'  ")
        If ccodofi = "001" Then

        Else
            strSQL.Append(" and ccodofi = @cCodofi ")
        End If

        strSQL.Append(" ORDER BY tabtbco.cnombco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)


        Dim tables(0) As String
        tables(0) = New String("tabtbco")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function
    Public Function FondodeCuentaBancaria(ByVal ccodbco As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtbco.cfondos from tabtbco where ccodbco = @ccodbco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)


        Dim ds As New DataSet
        Dim lcfondos As String = "99"

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cfondos")) Then
            Else
                lcfondos = ds.Tables(0).Rows(0)("cfondos")
            End If
        End If
        Return lcfondos.Trim
    End Function
    Public Function ObtenerBancos() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM TABTBCO order by ccodbco ")

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ActualizaSaldos(ByVal ccodbco As String, ByVal nsaldo As Double, ByVal ncargos As Double, ByVal nabonos As Double) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE TABTBCO SET  ncargos = @ncargos, nabonos =@nabonos, saldact = @nsaldo  WHERE ccodbco = @ccodbco ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodbco", ccodbco)
        args(1) = New SqlParameter("@nsaldo", nsaldo)
        args(2) = New SqlParameter("@ncargos", ncargos)
        args(3) = New SqlParameter("@nabonos", nabonos)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    'Actualiza de saldo final a saldo inicial
    Public Function ActualizaSaldosiniciales()
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE TABTBCO SET  saldant = saldact  ")

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function
    Public Function UltimoBancoIngresado() As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select max(ccodbco) as cCodbco from tabtbco ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString)

        If ds.Tables(0).Rows.Count = 0 Then
            Return "01"
        Else
            Return ds.Tables(0).Rows(0)("ccodbco")
        End If


    End Function
    Public Function ObtenerCuentaDocumento(ByVal ccodbco As String) As String
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet

        Dim lccodaux As String = "*"
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Select ccodaux from tabtbco " & _
                                      "Where ccodbco='" & ccodbco & "'"
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Banco")
                For Each fila As DataRow In ds.Tables("Banco").Rows
                    lccodaux = IIf(IsDBNull(fila("ccodaux")), "*", fila("ccodaux"))
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using
        Return lccodaux
    End Function

    Public Function ObtenerDataSetPorIDTodos2(ByRef ds As DataSet, ByVal ccodofi As String) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE Uso = '1' and cgrupo = 'DE' ")
        If ccodofi = "001" Then

        Else
            strSQL.Append(" and ccodofi = @cCodofi ")
        End If

        strSQL.Append(" ORDER BY tabtbco.cnombco ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)


        Dim tables(0) As String
        tables(0) = New String("tabtbco")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function


    Public Function ObtenerCuenta_Oficina(ByVal ccodofi As String, ByVal pctipo As String) As String

        Dim lccodaux As String = "*"
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim sql_ As String = ""

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion

                sql_ = _
                        "Select * from tabtbco " & _
                        "Where Uso = '1' and cgrupo = '" & pctipo & "' " & _
                        "and ccodofi='" & ccodofi & "'"

                command.CommandText = sql_ 

                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Banco")

                For Each fila As DataRow In ds.Tables("Banco").Rows
                    lccodaux = fila("cctacte").ToString.Trim
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using

        Return lccodaux


    End Function


    Public Function ObtenerDataSetPorID_Oficina_Tipo(ByRef ds As DataSet, ByVal ccodofi As String, _
                                                     ByVal pctipo As String) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE uso = '1'  ")
        If ccodofi.Trim = "001" Then
        Else
            strSQL.Append(" and cCodofi = @cCodofi ")
        End If
        strSQL.Append(" and cgrupo = @cgrupo ")
        strSQL.Append(" ORDER BY ccodbco ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@cgrupo", SqlDbType.VarChar)
        args(1).Value = pctipo

        Dim tables(0) As String
        tables(0) = New String("tabtbco")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function


    'Extrae Bancos
    Public Function Extrae_Bancos() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select ltrim(rtrim(idccodbco)) as idccodbco, cnombco from Bancos " & _
                                        " Order by idccodbco "


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "BD_Bancos")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    'Extrae Ctas Bancarias 
    Public Function Extrae_Ctas_Bancarias(ByVal pcCodbco As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select idccodbco, RTRIM(ccodbco) as ccodbco, cnombco, cctacte, ccodcta, ('AGENCIA:' + ccodofi + ' ' + cnombco + ' | cta. #' + cctacte) as cnombco1 From tabtbco " & _
                                        " where idccodbco = '" & pcCodbco & "' and uso = 1 " & _
                                        " Order By ccodbco, ccodofi   "


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "BD_Ctas_Banco")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Extrae_Bancos_Oficinas() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lcCodcta_Ctb As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " SELECT b.ccodbco, a.cnombco, c.cnomofi, b.cctacte, " & _
                                        " (rtrim(ltrim(a.cnombco))+' | '+rtrim(ltrim(c.cnomofi))+' | '+rtrim(ltrim(b.cctacte))) as cdesbco FROM bancos a " & _
                                        " inner join TABTBCO b " & _
                                        " on b.idccodbco = a.Idccodbco " & _
                                        " INNER JOIN TABTOFI c " & _
                                        " on b.ccodofi = c.ccodofi " & _
                                        " where uso = 1 " & _
                                        " Order by a.idccodbco "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Bancos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

 
End Class
