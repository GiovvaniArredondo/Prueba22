Imports System.Text
Public Class dbPromociones
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As promociones
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.codigo =  0 _
            Or lEntidad.codigo = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.codigo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE promociones ")
        strSQL.Append(" SET nombre = @nombre, ") 
        strSQL.Append(" vigencia = @vigencia, ") 
        strSQL.Append(" WHERE codigo = @codigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(1) = New SqlParameter("@vigencia", SqlDbType.Datetime)
        args(1).Value = IIf(lEntidad.vigencia = Nothing, DBNull.Value, lEntidad.vigencia)
        args(2) = New SqlParameter("@codigo", SqlDbType.Int)
        args(2).Value = IIf(lEntidad.codigo = Nothing, DBNull.Value,lEntidad.codigo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As promociones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO promociones ")
        strSQL.Append(" ( codigo) ") 
        strSQL.Append(" nombre, ") 
        strSQL.Append(" vigencia, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @codigo) ") 
        strSQL.Append(" @nombre, ") 
        strSQL.Append(" @vigencia, ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@codigo", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.codigo = Nothing, DBNull.Value, lEntidad.codigo)
        args(1) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(2) = New SqlParameter("@vigencia", SqlDbType.Datetime)
        args(2).Value = IIf(lEntidad.vigencia = Nothing, DBNull.Value, lEntidad.vigencia)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As promociones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM promociones ")
        strSQL.Append(" WHERE codigo = @codigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@codigo", SqlDbType.Int)
        args(0).Value = lEntidad.codigo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As promociones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE codigo = @codigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@codigo", SqlDbType.Int)
        args(0).Value = lEntidad.codigo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.vigencia = IIf(.Item("vigencia") Is DBNull.Value, Nothing, .Item("vigencia"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As promociones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(codigo),0) + 1 ")
        strSQL.Append(" FROM promociones ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listapromociones

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listapromociones

        Try
            Do While dr.Read()
                Dim mEntidad As New promociones
                mEntidad.codigo = IIf(dr("codigo") Is DBNull.Value, Nothing, dr("codigo"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                mEntidad.vigencia = IIf(dr("vigencia") Is DBNull.Value, Nothing, dr("vigencia"))
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
        tables(0) = New String("promociones")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT codigo, ") 
        strSQL.Append(" nombre, ") 
        strSQL.Append(" vigencia ") 
        strSQL.Append(" FROM promociones ")

    End Sub

End Class
