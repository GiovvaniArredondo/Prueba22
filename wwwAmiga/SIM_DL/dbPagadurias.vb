Imports System.Text
Public Class dbPagadurias
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As pagadurias
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.nombre = "" _
            Or lEntidad.cflag = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cflag = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE pagadurias ")
        strSQL.Append(" SET nombre = @nombre, ") 
        strSQL.Append(" cflag = @cflag, ") 

        Dim args(-1) As SqlParameter
        args(0) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(1) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.cflag = Nothing, DBNull.Value, lEntidad.cflag)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As pagadurias
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO pagadurias ")
        strSQL.Append(" ( nombre, ") 
        strSQL.Append(" cflag) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @nombre, ") 
        strSQL.Append(" @cflag) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(1) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.cflag = Nothing, DBNull.Value, lEntidad.cflag)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As pagadurias
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM pagadurias ")

        Dim args(-1) As SqlParameter

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As pagadurias
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As pagadurias
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(),0) + 1 ")
        strSQL.Append(" FROM pagadurias ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listapagadurias

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listapagadurias

        Try
            Do While dr.Read()
                Dim mEntidad As New pagadurias
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
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
        tables(0) = New String("pagadurias")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT nombre, ") 
        strSQL.Append(" cflag ") 
        strSQL.Append(" FROM pagadurias order by nombre ")

    End Sub
    Public Function EliminaporPagaduria(ByVal cCodcta As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM PAGADURIA WHERE cCodcta = @ccodcta")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function


    Public Function AgregaporPagaduria(ByVal ccodcta As String, ByVal ccodcli As String, ByVal cnomcli As String, _
                                       ByVal ncuota As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO PAGADURIA(ccodcta, ccodcli, cnomcli, ncuota, cdescob, cflag) ")
        strSQL.Append("VALUES(@ccodcta, @ccodcli, @cnomcli, @ncuota, 'D', '')")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = ccodcli
        args(2) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(2).Value = cnomcli
        args(3) = New SqlParameter("@ncuota", SqlDbType.Decimal)
        args(3).Value = ncuota


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerPagaduria() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CLIMIDE.CPAGADU, max(climide.ccodcli) as ccodcli FROM  CLIMIDE ")
        strSQL.Append("WHERE CLIMIDE.CPAGADU <> ' ' ")
        strSQL.Append("GROUP BY cpagadu order by cpagadu ")

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function
End Class
