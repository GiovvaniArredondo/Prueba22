Imports System.Text
Public Class dbUsuarioGrupo
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarioGrupo
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
        strSQL.Append("UPDATE usuarioGrupo ")
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 
        strSQL.Append(" AND idGrupo = @idGrupo ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idUsuario = Nothing, DBNull.Value,lEntidad.idUsuario)
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.idGrupo = Nothing, DBNull.Value,lEntidad.idGrupo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarioGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO usuarioGrupo ")
        strSQL.Append(" ( idUsuario, ") 
        strSQL.Append(" idGrupo) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @idUsuario, ") 
        strSQL.Append(" @idGrupo) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idUsuario = Nothing, DBNull.Value, lEntidad.idUsuario)
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.idGrupo = Nothing, DBNull.Value, lEntidad.idGrupo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarioGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM usuarioGrupo ")
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 
        strSQL.Append(" AND idGrupo = @idGrupo ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = lEntidad.idUsuario
        args(1) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(1).Value = lEntidad.idGrupo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarioGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idUsuario = @idUsuario ")
        strSQL.Append(" AND idGrupo = @idGrupo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = lEntidad.idUsuario
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

        Dim lEntidad As usuarioGrupo
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idGrupo),0) + 1 ")
        strSQL.Append(" FROM usuarioGrupo ")
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = lEntidad.idUsuario

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(idUsuario As Int32) As listausuarioGrupo

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = idUsuario

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListausuarioGrupo

        Try
            Do While dr.Read()
                Dim mEntidad As New usuarioGrupo
                mEntidad.idUsuario = idUsuario
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

    Public Function ObtenerDataSetPorID(idUsuario As Int32) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", idUsuario)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(idUsuario As Int32, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", idUsuario)

        Dim tables(0) As String
        tables(0) = New String("usuarioGrupo")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function


    Public Function ObtenerDataSetPorID2(ByVal idUsuario As Int32, ByVal idgrupo As Int32) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idUsuario = @idUsuario ")
        strSQL.Append(" AND idgrupo = @idgrupo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", idUsuario)
        args(1) = New SqlParameter("@idgrupo", idgrupo)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT idUsuario, ")
        strSQL.Append(" idGrupo ")
        strSQL.Append(" FROM usuarioGrupo ")

    End Sub

    Public Function RetornaGrupo(ByVal usuario As String) As Integer
        Dim strsql As New StringBuilder
        strsql.Append("select usuariogrupo.idgrupo from usuarios, usuariogrupo ")
        strsql.Append(" WHERE usuarios.idusuario = usuariogrupo.idusuario and usuarios.usuario = @usuario ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@Usuario", usuario)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("idgrupo")
        End If

    End Function

    Public Function DataSetReportes(ByVal idgrupo As Integer) As DataSet
        Dim strsql As New StringBuilder
        strsql.Append("select * from ReportesGrupo  where idgrupo = @idgrupo order by idopcion ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idgrupo", SqlDbType.Int)
        args(0).Value = idgrupo

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        Return ds

    End Function
End Class
