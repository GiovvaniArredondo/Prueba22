Imports System.Text
Public Class dbDiario
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As diario
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnumcom =  "" _
            Or lEntidad.cnumcom = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnumcom = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE diario ")
        strSQL.Append(" SET ccodofi = @ccodofi, ") 
        strSQL.Append(" ctipasi = @ctipasi, ") 
        strSQL.Append(" ctipmon = @ctipmon, ") 
        strSQL.Append(" cglosa = @cglosa, ") 
        strSQL.Append(" cnumdoc = @cnumdoc, ") 
        strSQL.Append(" ccodruc = @ccodruc, ") 
        strSQL.Append(" ccodemp = @ccodemp, ") 
        strSQL.Append(" dfecdoc = @dfecdoc, ") 
        strSQL.Append(" dfeccnt = @dfeccnt, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" nccompra = @nccompra, ") 
        strSQL.Append(" ncventa = @ncventa, ") 
        strSQL.Append(" ntcfijo = @ntcfijo, ") 
        strSQL.Append(" cfv = @cfv, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" nfln = @nfln, ") 
        strSQL.Append(" cnrodoc = @cnrodoc, ") 
        strSQL.Append(" ffondos = @ffondos, ") 
        strSQL.Append(" ccodrev = @ccodrev, ") 
        strSQL.Append(" ccodreg = @ccodreg ") 
        strSQL.Append(" WHERE cnumcom = @cnumcom ") 

        Dim args(21) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodofi
        args(1) = New SqlParameter("@ctipasi", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipasi
        args(2) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipmon
        args(3) = New SqlParameter("@cglosa", SqlDbType.VarChar)
        args(3).Value = lEntidad.cglosa
        args(4) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumdoc
        args(5) = New SqlParameter("@ccodruc", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodruc
        args(6) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodemp
        args(7) = New SqlParameter("@dfecdoc", SqlDbType.Datetime)
        args(7).Value = lEntidad.dfecdoc
        args(8) = New SqlParameter("@dfeccnt", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfeccnt
        args(9) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecmod
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodusu
        args(11) = New SqlParameter("@nccompra", SqlDbType.VarChar)
        args(11).Value = lEntidad.nccompra
        args(12) = New SqlParameter("@ncventa", SqlDbType.VarChar)
        args(12).Value = lEntidad.ncventa
        args(13) = New SqlParameter("@ntcfijo", SqlDbType.VarChar)
        args(13).Value = lEntidad.ntcfijo
        args(14) = New SqlParameter("@cfv", SqlDbType.VarChar)
        args(14).Value = lEntidad.cfv
        args(15) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(15).Value = lEntidad.cestado
        args(16) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(16).Value = lEntidad.nfln
        args(17) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(17).Value = lEntidad.cnrodoc
        args(18) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(18).Value = lEntidad.ffondos
        args(19) = New SqlParameter("@ccodrev", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodrev
        args(20) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodreg
        args(21) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(21).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value,lEntidad.cnumcom)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function Actualizar_cierre(ByVal lcnumcom As String, ByVal lcnumcomant As String) As Integer


        'Dim lEntidad As diario
        'Dim lID As Long
        'lEntidad = aEntidad

        'Dim strSQL As New StringBuilder
        'strSQL.Append("UPDATE diario ")
        'strSQL.Append(" cnumcom = @cnumcom ")
        'strSQL.Append(" WHERE cnumcom = @lcnumcomant ")

        ' Dim args(1) As SqlParameter
        ' args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        ' args(0).Value = lEntidad.cnumcom
        ' args(1) = New SqlParameter("lcnumcomant", SqlDbType.VarChar)
        ' args(1).Value = lcnumcomant

        Dim myconnection As SqlConnection
        Dim sql As String

        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Update DIARIO Set  cnumcom ='" & "'" & lcnumcom & "'" & " Where cnumcom = '" & lcnumcomant & "'"

            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
        End Try


        '        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As diario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO diario ")
        strSQL.Append(" ( cnumcom, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ctipasi, ")
        strSQL.Append(" ctipmon, ")
        strSQL.Append(" cglosa, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" ccodruc, ")
        strSQL.Append(" ccodemp, ")
        strSQL.Append(" dfecdoc, ")
        strSQL.Append(" dfeccnt, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" nccompra, ")
        strSQL.Append(" ncventa, ")
        strSQL.Append(" ntcfijo, ")
        strSQL.Append(" cfv, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" cnrodoc, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" ccodrev, ")
        strSQL.Append(" ccodreg) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnumcom, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @ctipasi, ")
        strSQL.Append(" @ctipmon, ")
        strSQL.Append(" @cglosa, ")
        strSQL.Append(" @cnumdoc, ")
        strSQL.Append(" @ccodruc, ")
        strSQL.Append(" @ccodemp, ")
        strSQL.Append(" @dfecdoc, ")
        strSQL.Append(" @dfeccnt, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @nccompra, ")
        strSQL.Append(" @ncventa, ")
        strSQL.Append(" @ntcfijo, ")
        strSQL.Append(" @cfv, ")
        strSQL.Append(" @cestado, ")
        strSQL.Append(" @nfln, ")
        strSQL.Append(" @cnrodoc, ")
        strSQL.Append(" @ffondos, ")
        strSQL.Append(" @ccodrev, ")
        strSQL.Append(" @ccodreg) ")

        Dim args(21) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cnumcom = Nothing, DBNull.Value, lEntidad.cnumcom)
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodofi
        args(2) = New SqlParameter("@ctipasi", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipasi
        args(3) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipmon
        args(4) = New SqlParameter("@cglosa", SqlDbType.VarChar)
        args(4).Value = lEntidad.cglosa
        args(5) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnumdoc
        args(6) = New SqlParameter("@ccodruc", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodruc
        args(7) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodemp
        args(8) = New SqlParameter("@dfecdoc", SqlDbType.DateTime)
        args(8).Value = lEntidad.dfecdoc
        args(9) = New SqlParameter("@dfeccnt", SqlDbType.DateTime)
        args(9).Value = lEntidad.dfeccnt
        args(10) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu
        args(12) = New SqlParameter("@nccompra", SqlDbType.Decimal)
        args(12).Value = lEntidad.nccompra
        args(13) = New SqlParameter("@ncventa", SqlDbType.Decimal)
        args(13).Value = lEntidad.ncventa
        args(14) = New SqlParameter("@ntcfijo", SqlDbType.Decimal)
        args(14).Value = lEntidad.ntcfijo
        args(15) = New SqlParameter("@cfv", SqlDbType.VarChar)
        args(15).Value = lEntidad.cfv
        args(16) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(16).Value = lEntidad.cestado
        args(17) = New SqlParameter("@nfln", SqlDbType.Decimal)
        args(17).Value = lEntidad.nfln
        args(18) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(18).Value = lEntidad.cnrodoc
        args(19) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(19).Value = lEntidad.ffondos
        args(20) = New SqlParameter("@ccodrev", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodrev
        args(21) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccodreg

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As diario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM diario ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As diario
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
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.ctipasi = IIf(.Item("ctipasi") Is DBNull.Value, Nothing, .Item("ctipasi"))
                lEntidad.ctipmon = IIf(.Item("ctipmon") Is DBNull.Value, Nothing, .Item("ctipmon"))
                lEntidad.cglosa = IIf(.Item("cglosa") Is DBNull.Value, Nothing, .Item("cglosa"))
                lEntidad.cnumdoc = IIf(.Item("cnumdoc") Is DBNull.Value, Nothing, .Item("cnumdoc"))
                lEntidad.ccodruc = IIf(.Item("ccodruc") Is DBNull.Value, Nothing, .Item("ccodruc"))
                lEntidad.ccodemp = IIf(.Item("ccodemp") Is DBNull.Value, Nothing, .Item("ccodemp"))
                lEntidad.dfecdoc = IIf(.Item("dfecdoc") Is DBNull.Value, Nothing, .Item("dfecdoc"))
                lEntidad.dfeccnt = IIf(.Item("dfeccnt") Is DBNull.Value, Nothing, .Item("dfeccnt"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.nccompra = IIf(.Item("nccompra") Is DBNull.Value, Nothing, .Item("nccompra"))
                lEntidad.ncventa = IIf(.Item("ncventa") Is DBNull.Value, Nothing, .Item("ncventa"))
                lEntidad.ntcfijo = IIf(.Item("ntcfijo") Is DBNull.Value, Nothing, .Item("ntcfijo"))
                lEntidad.cfv = IIf(.Item("cfv") Is DBNull.Value, Nothing, .Item("cfv"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
                lEntidad.cnrodoc = IIf(.Item("cnrodoc") Is DBNull.Value, Nothing, .Item("cnrodoc"))
                lEntidad.ffondos = IIf(.Item("ffondos") Is DBNull.Value, Nothing, .Item("ffondos"))
                lEntidad.ccodrev = IIf(.Item("ccodrev") Is DBNull.Value, Nothing, .Item("ccodrev"))
                lEntidad.ccodreg = IIf(.Item("ccodreg") Is DBNull.Value, Nothing, .Item("ccodreg"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As diario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnumcom),0) + 1 ")
        strSQL.Append(" FROM diario ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listadiario

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listadiario

        Try
            Do While dr.Read()
                Dim mEntidad As New diario
                mEntidad.cnumcom = IIf(dr("cnumcom") Is DBNull.Value, Nothing, dr("cnumcom"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ctipasi = IIf(dr("ctipasi") Is DBNull.Value, Nothing, dr("ctipasi"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.cglosa = IIf(dr("cglosa") Is DBNull.Value, Nothing, dr("cglosa"))
                mEntidad.cnumdoc = IIf(dr("cnumdoc") Is DBNull.Value, Nothing, dr("cnumdoc"))
                mEntidad.ccodruc = IIf(dr("ccodruc") Is DBNull.Value, Nothing, dr("ccodruc"))
                mEntidad.ccodemp = IIf(dr("ccodemp") Is DBNull.Value, Nothing, dr("ccodemp"))
                mEntidad.dfecdoc = IIf(dr("dfecdoc") Is DBNull.Value, Nothing, dr("dfecdoc"))
                mEntidad.dfeccnt = IIf(dr("dfeccnt") Is DBNull.Value, Nothing, dr("dfeccnt"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nccompra = IIf(dr("nccompra") Is DBNull.Value, Nothing, dr("nccompra"))
                mEntidad.ncventa = IIf(dr("ncventa") Is DBNull.Value, Nothing, dr("ncventa"))
                mEntidad.ntcfijo = IIf(dr("ntcfijo") Is DBNull.Value, Nothing, dr("ntcfijo"))
                mEntidad.cfv = IIf(dr("cfv") Is DBNull.Value, Nothing, dr("cfv"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.cnrodoc = IIf(dr("cnrodoc") Is DBNull.Value, Nothing, dr("cnrodoc"))
                mEntidad.ffondos = IIf(dr("ffondos") Is DBNull.Value, Nothing, dr("ffondos"))
                mEntidad.ccodrev = IIf(dr("ccodrev") Is DBNull.Value, Nothing, dr("ccodrev"))
                mEntidad.ccodreg = IIf(dr("ccodreg") Is DBNull.Value, Nothing, dr("ccodreg"))
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
        tables(0) = New String("diario")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT cnumcom, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ctipasi, ")
        strSQL.Append(" ctipmon, ")
        strSQL.Append(" cglosa, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" ccodruc, ")
        strSQL.Append(" ccodemp, ")
        strSQL.Append(" dfecdoc, ")
        strSQL.Append(" dfeccnt, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" nccompra, ")
        strSQL.Append(" ncventa, ")
        strSQL.Append(" ntcfijo, ")
        strSQL.Append(" cfv, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" cnrodoc, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" ccodrev, ")
        strSQL.Append(" ccodreg ")
        strSQL.Append(" FROM diario ")

    End Sub

    Public Function siexistepartida(ByVal cnumcom1 As String) As Boolean

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT diario.cnumcom ")
        strSQL.Append(" FROM diario")
        strSQL.Append(" WHERE diario.cnumcom = @cnumcom1 ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom1", SqlDbType.VarChar)
        args(0).Value = cnumcom1

        Dim ds As DataSet
        Dim si As Boolean

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count >= 1 Then
                si = True
            Else
                si = False
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return si

    End Function

    Public Function ObtieneNumerodePartidas(ByVal cglosa As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select Diario.dfeccnt, Diario.cglosa, Diario.cnumcom, Diario.ccodofi, ")
        strSQL.Append("ndebe = (select SUM(ndebe) as ndebe from cntamov where diario.cnumcom = cntamov.cnumcom ), ")
        strSQL.Append("nhaber = (select SUM(nhaber) as nhaber from cntamov where diario.cnumcom = cntamov.cnumcom) ")
        strSQL.Append(" FROM DIARIO where Diario.dfeccnt >= @dfecha and Diario.dfeccnt <= @dfecha ")
        strSQL.Append("and Diario.cglosa like" & "'" & "%" & cglosa & "%" & "'")


        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function VerificasiprocedeAnulacion(ByVal cnumcom As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cnumcom from diario where cnumcom = @cnumcom and (nfln = '1' or nfln='2') ")

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
    Public Function BanderaAnulada(ByVal cnumcom As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE diario ")
        strSQL.Append(" SET nfln   = '1' ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function BanderaAnulada2(ByVal cnumcom As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE diario ")
        strSQL.Append(" SET nfln   = '2' ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function ActualizaPartidaRevertida(ByVal cnumcom As String, ByVal cnumcom2 As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE diario ")
        strSQL.Append(" SET cnrodoc   = @cnumcom2 ")
        strSQL.Append(" WHERE cnumcom = @cnumcom ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = cnumcom
        args(1) = New SqlParameter("@cnumcom2", SqlDbType.VarChar)
        args(1).Value = cnumcom2

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function ObtenerCabezaPartida(ByVal cnumcom As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from DIARIO where cnumcom = @cnumcom ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", cnumcom)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

End Class
