Imports System.Text
Public Class dbEncuestas
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Encuestas
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodpreg =  "" _
            Or lEntidad.ccodpreg = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodpreg = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE Encuestas ")
        strSQL.Append(" SET cpregunta = @cpregunta, ") 
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cpregunta", SqlDbType.VarChar)
        args(0).Value = lEntidad.cpregunta
        args(1) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodenc = Nothing, DBNull.Value,lEntidad.ccodenc)
        args(2) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodpreg = Nothing, DBNull.Value,lEntidad.ccodpreg)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Encuestas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Encuestas ")
        strSQL.Append(" ( ccodenc) ") 
        strSQL.Append(" ccodpreg, ") 
        strSQL.Append(" cpregunta, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodenc) ") 
        strSQL.Append(" @ccodpreg, ") 
        strSQL.Append(" @cpregunta, ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodenc = Nothing, DBNull.Value, lEntidad.ccodenc)
        args(1) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodpreg = Nothing, DBNull.Value, lEntidad.ccodpreg)
        args(2) = New SqlParameter("@cpregunta", SqlDbType.VarChar)
        args(2).Value = lEntidad.cpregunta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Encuestas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM Encuestas ")
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodenc
        args(1) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodpreg

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Encuestas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodenc
        args(1) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodpreg

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cpregunta = IIf(.Item("cpregunta") Is DBNull.Value, Nothing, .Item("cpregunta"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As Encuestas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodpreg),0) + 1 ")
        strSQL.Append(" FROM Encuestas ")
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodenc

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodenc As String) As listaEncuestas

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(0).Value = ccodenc

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaEncuestas

        Try
            Do While dr.Read()
                Dim mEntidad As New Encuestas
                mEntidad.ccodenc = ccodenc
                mEntidad.ccodpreg = IIf(dr("ccodpreg") Is DBNull.Value, Nothing, dr("ccodpreg"))
                mEntidad.cpregunta = IIf(dr("cpregunta") Is DBNull.Value, Nothing, dr("cpregunta"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodenc As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 
        strSQL.Append(" order by ccodpreg ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", ccodenc)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodenc As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodenc = @ccodenc ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", ccodenc)

        Dim tables(0) As String
        tables(0) = New String("Encuestas")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodenc, ") 
        strSQL.Append(" ccodpreg, ") 
        strSQL.Append(" cpregunta, cflag, creferencia ")
        strSQL.Append(" FROM Encuestas ")

    End Sub

    Public Function ObtenerRespuestasPregunta(ByVal ccodenc As String, ByVal ccodpreg As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select crespuestas , ccodres from respuestas ")
        strSQL.Append("where ccodenc = @ccodenc and ccodpreg = @ccodpreg ")
        strSQL.Append("order by ccodres ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodenc", ccodenc)
        args(1) = New SqlParameter("@ccodpreg", ccodpreg)

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
End Class
