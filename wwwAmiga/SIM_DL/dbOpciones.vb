Imports System.Text
Public Class dbOpciones
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opciones
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.idOpcion =  0 _
            Or lEntidad.idOpcion = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.idOpcion = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE opciones ")
        strSQL.Append(" SET idOpcionPadre = @idOpcionPadre, ") 
        strSQL.Append(" opcion = @opcion, ") 
        strSQL.Append(" url = @url, ") 
        strSQL.Append(" descripcion = @descripcion ") 
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@idOpcionPadre", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcionPadre
        args(1) = New SqlParameter("@opcion", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.opcion = Nothing, DBNull.Value, lEntidad.opcion)
        args(2) = New SqlParameter("@url", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.url = Nothing, DBNull.Value, lEntidad.url)
        args(3) = New SqlParameter("@descripcion", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.descripcion = Nothing, DBNull.Value, lEntidad.descripcion)
        args(4) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(4).Value = IIf(lEntidad.idOpcion = Nothing, DBNull.Value,lEntidad.idOpcion)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opciones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO opciones ")
        strSQL.Append(" ( idOpcion, ") 
        strSQL.Append(" idOpcionPadre, ") 
        strSQL.Append(" opcion, ") 
        strSQL.Append(" url, ") 
        strSQL.Append(" descripcion) ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @idOpcion, ") 
        strSQL.Append(" @idOpcionPadre, ") 
        strSQL.Append(" @opcion, ") 
        strSQL.Append(" @url, ") 
        strSQL.Append(" @descripcion) ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idOpcion = Nothing, DBNull.Value, lEntidad.idOpcion)
        args(1) = New SqlParameter("@idOpcionPadre", SqlDbType.Int)
        args(1).Value = lEntidad.idOpcionPadre
        args(2) = New SqlParameter("@opcion", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.opcion = Nothing, DBNull.Value, lEntidad.opcion)
        args(3) = New SqlParameter("@url", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.url = Nothing, DBNull.Value, lEntidad.url)
        args(4) = New SqlParameter("@descripcion", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.descripcion = Nothing, DBNull.Value, lEntidad.descripcion)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opciones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM opciones ")
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As opciones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idOpcion = @idOpcion ") 
        strSQL.Append(" ORDER BY idopcionPadre, idopcion ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idOpcion", SqlDbType.Int)
        args(0).Value = lEntidad.idOpcion

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.idOpcionPadre = IIf(.Item("idOpcionPadre") Is DBNull.Value, Nothing, .Item("idOpcionPadre"))
                lEntidad.opcion = IIf(.Item("opcion") Is DBNull.Value, Nothing, .Item("opcion"))
                lEntidad.url = IIf(.Item("url") Is DBNull.Value, Nothing, .Item("url"))
                lEntidad.descripcion = IIf(.Item("descripcion") Is DBNull.Value, Nothing, .Item("descripcion"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As opciones
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idOpcion),0) + 1 ")
        strSQL.Append(" FROM opciones ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaopciones

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaopciones

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
        tables(0) = New String("opciones")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT idOpcion, ") 
        strSQL.Append(" idOpcionPadre, ") 
        strSQL.Append(" opcion, ") 
        strSQL.Append(" url, ") 
        strSQL.Append(" descripcion ") 
        strSQL.Append(" FROM opciones ")

    End Sub


    Public Function ObtenerListaOpcionesGrupo(ByVal idgrupo As String) As listaopciones
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT opciones.idOpcion, ")
        strSQL.Append(" opciones.idOpcionPadre, ")
        strSQL.Append(" opciones.opcion, ")
        strSQL.Append(" opciones.url, ")
        strSQL.Append(" opciones.descripcion ")
        strSQL.Append(" FROM opciones, opcionesGrupo ")
        strSQL.Append(" WHERE opciones.idopcion = opcionesGrupo.idopcion ")
        strSQL.Append(" and opcionesGrupo.idgrupo = @idgrupo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idgrupo", SqlDbType.VarChar)
        args(0).Value = idgrupo

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
