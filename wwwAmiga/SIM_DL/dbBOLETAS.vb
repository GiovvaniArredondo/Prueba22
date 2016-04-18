Imports System.Text
Public Class dbBOLETAS
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

        Dim lEntidad As BOLETAS
        Dim lID As Long
        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE BOLETAS ")
        strSQL.Append(" SET dfecsis = @dfecsis, ")
        strSQL.Append(" dfecpro = @dfecpro, ") 
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 
        strSQL.Append(" AND cestado = @cestado ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecsis
        args(1) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecpro
        args(2) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.cbanco = Nothing, DBNull.Value,lEntidad.cbanco)
        args(3) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.cnuming = Nothing, DBNull.Value,lEntidad.cnuming)
        args(4) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.cestado = Nothing, DBNull.Value,lEntidad.cestado)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As BOLETAS
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO BOLETAS ")
        strSQL.Append(" (cbanco, ")
        strSQL.Append(" cnuming, ") 
        strSQL.Append(" cestado, ")
        strSQL.Append(" dfecsis, ") 
        strSQL.Append(" dfecpro, nmonto) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cbanco, ") 
        strSQL.Append(" @cnuming, ") 
        strSQL.Append(" @cestado, ")
        strSQL.Append(" @dfecsis, ") 
        strSQL.Append(" @dfecpro, @nmonto) ")

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(0).Value = lEntidad.cbanco
        args(1) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.cnuming = Nothing, DBNull.Value, lEntidad.cnuming)
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.cestado = Nothing, DBNull.Value, lEntidad.cestado)
        args(3) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(3).Value = lEntidad.dfecsis
        args(4) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(4).Value = lEntidad.dfecpro
        args(5) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(5).Value = lEntidad.nmonto

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As BOLETAS
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM BOLETAS ")
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 
        strSQL.Append(" AND cestado = @cestado ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(0).Value = lEntidad.cbanco
        args(1) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnuming
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = lEntidad.cestado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As BOLETAS
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 
        strSQL.Append(" AND cestado = @cestado ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(0).Value = lEntidad.cbanco
        args(1) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnuming
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = lEntidad.cestado

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.dfecsis = IIf(.Item("dfecsis") Is DBNull.Value, Nothing, .Item("dfecsis"))
                lEntidad.dfecpro = IIf(.Item("dfecpro") Is DBNull.Value, Nothing, .Item("dfecpro"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As BOLETAS
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cestado),0) + 1 ")
        strSQL.Append(" FROM BOLETAS ")
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(0).Value = lEntidad.cbanco
        args(1) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnuming

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(cbanco As String, cnuming As String) As listaBOLETAS

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cbanco", SqlDbType.VarChar)
        args(0).Value = cbanco
        args(1) = New SqlParameter("@cnuming", SqlDbType.VarChar)
        args(1).Value = cnuming

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaBOLETAS

        Try
            Do While dr.Read()
                Dim mEntidad As New BOLETAS
                mEntidad.cbanco = cbanco
                mEntidad.cnuming = cnuming
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(cbanco As String, cnuming As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cbanco", cbanco)
        args(1) = New SqlParameter("@cnuming", cnuming)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(cbanco As String, cnuming As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cbanco = @cbanco ") 
        strSQL.Append(" AND cnuming = @cnuming ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cbanco", cbanco)
        args(1) = New SqlParameter("@cnuming", cnuming)

        Dim tables(0) As String
        tables(0) = New String("BOLETAS")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT cbanco, ") 
        strSQL.Append(" cnuming, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" dfecsis, ") 
        strSQL.Append(" dfecpro ") 
        strSQL.Append(" FROM BOLETAS ")

    End Sub

    Public Function ValidaBoleta(ByVal cnuming As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("select sum(nmonto) as nmonto from BOLETAS ")
        strSQL.Append("where rtrim(ltrim(cnuming)) = rtrim(ltrim(@cnuming))  ")
        strSQL.Append("group by  cnuming ")

        Dim ds As New DataSet
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnuming", cnuming)


        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lvalida As Boolean = True
        Dim lnmonto As Double = 0
        Dim i As Integer = 0

        i = ds.Tables(0).Rows.Count
        If i = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
            Else
                lnmonto = ds.Tables(0).Rows(0)("nmonto")

                If Math.Round(lnmonto, 2) <= 0 Then
                Else
                    lvalida = False
                End If
            End If

        End If

        Return lvalida

    End Function
End Class
