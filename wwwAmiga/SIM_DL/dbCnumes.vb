Imports System.Text
Public Class dbCnumes
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cnumes
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.numes =  "" _
            Or lEntidad.numes = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.numes = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cnumes ")
        strSQL.Append(" SET cnumcom = @cnumcom, ") 
        strSQL.Append(" cierre = @cierre ")
        strSQL.Append(" WHERE numes = @numes ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom
        args(1) = New SqlParameter("@cierre", SqlDbType.Bit)
        args(1).Value = IIf(lEntidad.cierre = Nothing, DBNull.Value, lEntidad.cierre)
        args(2) = New SqlParameter("@numes", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.numes = Nothing, DBNull.Value,lEntidad.numes)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cnumes
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cnumes ")
        strSQL.Append(" ( numes) ") 
        strSQL.Append(" cnumcom, ") 
        strSQL.Append(" cierre, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @numes) ") 
        strSQL.Append(" @cnumcom, ") 
        strSQL.Append(" @cierre, ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@numes", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.numes = Nothing, DBNull.Value, lEntidad.numes)
        args(1) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnumcom
        args(2) = New SqlParameter("@cierre", SqlDbType.Bit)
        args(2).Value = IIf(lEntidad.cierre = Nothing, DBNull.Value, lEntidad.cierre)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cnumes
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cnumes ")
        strSQL.Append(" WHERE numes = @numes ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@numes", SqlDbType.VarChar)
        args(0).Value = lEntidad.numes

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cnumes
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE numes = @numes ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@numes", SqlDbType.VarChar)
        args(0).Value = lEntidad.numes

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnumcom = IIf(.Item("cnumcom") Is DBNull.Value, Nothing, .Item("cnumcom"))
                lEntidad.cierre = IIf(.Item("cierre") Is DBNull.Value, Nothing, .Item("cierre"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cnumes
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(numes),0) + 1 ")
        strSQL.Append(" FROM cnumes ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacnumes

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listacnumes

        Try
            Do While dr.Read()
                Dim mEntidad As New cnumes
                mEntidad.numes = IIf(dr("numes") Is DBNull.Value, Nothing, dr("numes"))
                mEntidad.cnumcom = IIf(dr("cnumcom") Is DBNull.Value, Nothing, dr("cnumcom"))
                mEntidad.cierre = IIf(dr("cierre") Is DBNull.Value, Nothing, dr("cierre"))
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
        tables(0) = New String("cnumes")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT numes, ") 
        strSQL.Append(" cnumcom, ") 
        strSQL.Append(" cierre ") 
        strSQL.Append(" FROM cnumes ")

    End Sub


    Public Function ActualizarCnumes(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cnumes
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cnumes ")
        strSQL.Append(" SET cnumcom = @cnumcom ")
        strSQL.Append(" WHERE numes = @numes ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnumcom
        args(1) = New SqlParameter("@cierre", SqlDbType.Bit)
        args(1).Value = IIf(lEntidad.cierre = Nothing, DBNull.Value, lEntidad.cierre)
        args(2) = New SqlParameter("@numes", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.numes = Nothing, DBNull.Value, lEntidad.numes)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

End Class
