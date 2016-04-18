Imports System.Text
Public Class dbOpcionesUsuario
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesUsuario
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.idUsuario =  0 _
            Or lEntidad.idUsuario = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.idUsuario = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE opcionesUsuario ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" AND idUsuario = @idUsuario ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idOpcion = Nothing, DBNull.Value,lEntidad.idOpcion)
        args(1) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.idUsuario = Nothing, DBNull.Value,lEntidad.idUsuario)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesUsuario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO opcionesUsuario ")
        strSQL.Append(" ( idOpcion, ") 
        strSQL.Append(" idUsuario) ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @idOpcion, ") 
        strSQL.Append(" @idUsuario) ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idOpcion = Nothing, DBNull.Value, lEntidad.idOpcion)
        args(1) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.idUsuario = Nothing, DBNull.Value, lEntidad.idUsuario)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesUsuario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM opcionesUsuario ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" AND idUsuario = @idUsuario ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion
        args(1) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(1).Value = lEntidad.idUsuario

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesUsuario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" AND idUsuario = @idUsuario ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion
        args(1) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(1).Value = lEntidad.idUsuario

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As opcionesUsuario
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idUsuario),0) + 1 ")
        strSQL.Append(" FROM opcionesUsuario ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(idOpcion As Int32) As listaopcionesUsuario

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = idOpcion

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaopcionesUsuario

        Try
            Do While dr.Read()
                Dim mEntidad As New opcionesUsuario
                mEntidad.idOpcion = idOpcion
                mEntidad.idUsuario = IIf(dr("idUsuario") Is DBNull.Value, Nothing, dr("idUsuario"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(idOpcion As Int32) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", idOpcion)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(idOpcion As Int32, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", idOpcion)

        Dim tables(0) As String
        tables(0) = New String("opcionesUsuario")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT idOpcion, ") 
        strSQL.Append(" idUsuario ") 
        strSQL.Append(" FROM opcionesUsuario ")

    End Sub

End Class
