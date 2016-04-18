Imports System.Text
Public Class dbCredchq
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credchq
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credchq ")
        strSQL.Append(" SET ccodcta = @ccodcta, ")
        strSQL.Append(" cnrodoc = @cnrodoc, ")
        strSQL.Append(" ccodbco = @ccodbco, ")
        strSQL.Append(" cnrochq = @cnrochq, ")
        strSQL.Append(" cctacte = @cctacte, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" cdescob = @cdescob, ")
        strSQL.Append(" cestado = @cestado, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" cnomchq = @cnomchq ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(9) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrodoc
        args(2) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodbco
        args(3) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnrochq
        args(4) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(4).Value = lEntidad.cctacte
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(6).Value = lEntidad.cdescob
        args(7) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(7).Value = lEntidad.cestado
        args(8) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflag
        args(9) = New SqlParameter("@cnomchq", SqlDbType.VarChar)
        args(9).Value = lEntidad.cnomchq

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO credchq ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" cnrodoc, ") 
        strSQL.Append(" ccodbco, ") 
        strSQL.Append(" cnrochq, ") 
        strSQL.Append(" cctacte, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" cdescob, ")
        strSQL.Append(" cestado, ") 
        strSQL.Append(" cflag, ")
        strSQL.Append(" cnomchq )")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @cnrodoc, ") 
        strSQL.Append(" @ccodbco, ") 
        strSQL.Append(" @cnrochq, ") 
        strSQL.Append(" @cctacte, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @cdescob, ")
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @cnomchq ) ")

        Dim args(9) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrodoc
        args(2) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodbco
        args(3) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnrochq
        args(4) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(4).Value = lEntidad.cctacte
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(6).Value = lEntidad.cdescob
        args(7) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(7).Value = lEntidad.cestado
        args(8) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflag
        args(9) = New SqlParameter("@cnomchq", SqlDbType.VarChar)
        args(9).Value = lEntidad.cnomchq


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credchq ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cnrodoc = IIf(.Item("cnrodoc") Is DBNull.Value, Nothing, .Item("cnrodoc"))
                lEntidad.ccodbco = IIf(.Item("ccodbco") Is DBNull.Value, Nothing, .Item("ccodbco"))
                lEntidad.cnrochq = IIf(.Item("cnrochq") Is DBNull.Value, Nothing, .Item("cnrochq"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.cdescob = IIf(.Item("cdescob") Is DBNull.Value, Nothing, .Item("cdescob"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cflag = IIf(.Item("cnomchq") Is DBNull.Value, Nothing, .Item("cnomchq"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As credchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcta),0) + 1 ")
        strSQL.Append(" FROM credchq ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacredchq

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listacredchq

        Try
            Do While dr.Read()
                Dim mEntidad As New credchq
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cnrodoc = IIf(dr("cnrodoc") Is DBNull.Value, Nothing, dr("cnrodoc"))
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cnrochq = IIf(dr("cnrochq") Is DBNull.Value, Nothing, dr("cnrochq"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cdescob = IIf(dr("cdescob") Is DBNull.Value, Nothing, dr("cdescob"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cnomchq = IIf(dr("cnomchq") Is DBNull.Value, Nothing, dr("cnomchq"))
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

    Public Function ObtenerDataSetPorID(ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("credchq")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcta, ") 
        strSQL.Append(" cnrodoc, ") 
        strSQL.Append(" ccodbco, ") 
        strSQL.Append(" cnrochq, ") 
        strSQL.Append(" cctacte, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" cdescob, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" cflag, ")
        strSQL.Append(" cnomchq ")
        strSQL.Append(" FROM credchq ")

    End Sub

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ObtenerDataSetPorID(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function Recuperarporllave(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credchq
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta


        'Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cnrodoc = IIf(.Item("cnrodoc") Is DBNull.Value, Nothing, .Item("cnrodoc"))
                lEntidad.ccodbco = IIf(.Item("ccodbco") Is DBNull.Value, Nothing, .Item("ccodbco"))
                lEntidad.cnrochq = IIf(.Item("cnrochq") Is DBNull.Value, Nothing, .Item("cnrochq"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.cdescob = IIf(.Item("cdescob") Is DBNull.Value, Nothing, .Item("cdescob"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.cnomchq = IIf(.Item("cnomchq") Is DBNull.Value, Nothing, .Item("cnomchq"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function
    Public Function VerificarPorID(ByVal ccodcta As String) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function
    Public Function ObtieneCheques(ByVal cCodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodcta, cnrodoc, cnomchq, nmonto ")
        strSQL.Append("FROM CREDCHQ ")
        strSQL.Append("WHERE cCodcta = @cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function AgregaRegistro(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal cnomchq As String, ByVal nmonto As Double) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO CREDCHQ(cCodcta, cnrodoc, cnomchq, nmonto) ")
        strSQL.Append("VALUES(@cCodcta, @cnrodoc, @cnomchq, @nmonto)  ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        args(1) = New SqlParameter("@cnrodoc", cnrodoc)
        args(2) = New SqlParameter("@cnomchq", cnomchq)
        args(3) = New SqlParameter("@nmonto", nmonto)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function ActualizaRegistro(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal cnomchq As String, ByVal nmonto As Double) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDCHQ SET  cnomchq = @cnomchq, nmonto = @nmonto ")
        strSQL.Append("WHERE cCodcta = @cCodcta and cnrodoc = @cnrodoc ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        args(1) = New SqlParameter("@cnrodoc", cnrodoc)
        args(2) = New SqlParameter("@cnomchq", cnomchq)
        args(3) = New SqlParameter("@nmonto", nmonto)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function MaximoCheque(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT MAX(cnrodoc) as cnrodoc FROM CREDCHQ ")
        strSQL.Append("WHERE cCodcta = @cCodcta group by cCodcta ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcnrodoc As String = "0001"
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnrodoc")) Then
            Else
                lcnrodoc = ds.Tables(0).Rows(0)("cnrodoc")
            End If
        End If
        Return lcnrodoc
    End Function
    Public Function QuitarUltimoCheque(ByVal cCodcta As String, ByVal cnrodoc As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CREDCHQ ")
        strSQL.Append("WHERE cCodcta = @cCodcta and cnrodoc = @cnrodoc ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)
        args(1) = New SqlParameter("@cnrodoc", cnrodoc)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function QuitarTodoslosCheques(ByVal cCodcta As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CREDCHQ ")
        strSQL.Append("WHERE cCodcta = @cCodcta  ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function MontodeCheques(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select sum(nmonto) as nmonto FROM CREDCHQ ")
        strSQL.Append("WHERE cCodcta = @cCodcta  GROUP BY cCodcta ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lnmonto As Double = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lnmonto = IIf(IsDBNull(ds.Tables(0).Rows(0)("nmonto")), 0, ds.Tables(0).Rows(0)("nmonto"))
        End If
        Return lnmonto

    End Function

End Class
