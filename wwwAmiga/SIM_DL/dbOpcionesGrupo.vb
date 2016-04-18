Imports System.Text
Public Class dbOpcionesGrupo
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesGrupo
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.idGrupo =  0 _
            Or lEntidad.idGrupo = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.idGrupo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE opcionesGrupo ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" AND idGrupo = @idGrupo ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idOpcion = Nothing, DBNull.Value,lEntidad.idOpcion)
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.idGrupo = Nothing, DBNull.Value,lEntidad.idGrupo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO opcionesGrupo ")
        strSQL.Append(" ( idOpcion, ") 
        strSQL.Append(" idGrupo) ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @idOpcion, ") 
        strSQL.Append(" @idGrupo) ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idOpcion = Nothing, DBNull.Value, lEntidad.idOpcion)
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.idGrupo = Nothing, DBNull.Value, lEntidad.idGrupo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM opcionesGrupo ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" AND idGrupo = @idGrupo ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = lEntidad.idGrupo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opcionesGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" AND idGrupo = @idGrupo ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = lEntidad.idGrupo

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

        Dim lEntidad As opcionesGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idGrupo),0) + 1 ")
        strSQL.Append(" FROM opcionesGrupo ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(idOpcion As Int32) As listaopcionesGrupo

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = idOpcion

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaopcionesGrupo

        Try
            Do While dr.Read()
                Dim mEntidad As New opcionesGrupo
                mEntidad.idOpcion = idOpcion
                mEntidad.idGrupo = IIf(dr("idGrupo") Is DBNull.Value, Nothing, dr("idGrupo"))
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
        tables(0) = New String("opcionesGrupo")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT idOpcion, ") 
        strSQL.Append(" idGrupo ") 
        strSQL.Append(" FROM opcionesGrupo ")

    End Sub

    Public Function ObtenerListaPorUsuario(ByVal idUsuario As Int32) As listaopciones

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT distinct opciones.idOpcion, ")
        strSQL.Append(" opciones.idOpcionPadre, ")
        strSQL.Append(" opciones.opcion, ")
        strSQL.Append(" opciones.url, ")
        strSQL.Append(" opciones.descripcion ")
        strSQL.Append(" FROM usuarioGrupo, opcionesGrupo, opciones ")
        strSQL.Append(" WHERE opcionesGrupo.idGrupo = usuarioGrupo.idGrupo and opciones.idOpcion = opcionesGrupo.idOpcion ")
        strSQL.Append(" AND usuarioGrupo.idUsuario = @idUsuario ")
        strSQL.Append(" ORDER BY opciones.descripcion")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = idUsuario

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaopciones

        Try
            Do While dr.Read()
                Dim mEntidad As New opciones
                mEntidad.idOpcion = IIf(dr("idOpcion") Is DBNull.Value, Nothing, dr("idOpcion"))
                mEntidad.idOpcionPadre = IIf(dr("idOpcionPadre") Is DBNull.Value, Nothing, dr("idOpcionPadre"))
                mEntidad.opcion = IIf(dr("opcion") Is DBNull.Value, Nothing, dr("opcion"))
                mEntidad.url = IIf(dr("url") Is DBNull.Value, Nothing, dr("url"))
                mEntidad.descripcion = IIf(dr("descripcion") Is DBNull.Value, Nothing, dr("descripcion"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
   


End Class
