Imports System.Text
Public Class dbGrupos
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As grupos
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
        strSQL.Append("UPDATE grupos ")
        strSQL.Append(" SET grupo = @grupo, ") 
        strSQL.Append(" codigoGrupo = @codigoGrupo ") 
        strSQL.Append(" WHERE idGrupo = @idGrupo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@grupo", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.grupo = Nothing, DBNull.Value, lEntidad.grupo)
        args(1) = New SqlParameter("@codigoGrupo", SqlDbType.VarChar)
        args(1).Value = lEntidad.codigoGrupo
        args(2) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(2).Value = IIf(lEntidad.idGrupo = Nothing, DBNull.Value,lEntidad.idGrupo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As grupos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO grupos ")
        strSQL.Append(" ( idGrupo, ") 
        strSQL.Append(" grupo, ") 
        strSQL.Append(" codigoGrupo) ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @idGrupo, ") 
        strSQL.Append(" @grupo, ") 
        strSQL.Append(" @codigoGrupo) ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idGrupo = Nothing, DBNull.Value, lEntidad.idGrupo)
        args(1) = New SqlParameter("@grupo", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.grupo = Nothing, DBNull.Value, lEntidad.grupo)
        args(2) = New SqlParameter("@codigoGrupo", SqlDbType.VarChar)
        args(2).Value = lEntidad.codigoGrupo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As grupos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM grupos ")
        strSQL.Append(" WHERE idGrupo = @idGrupo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(0).Value = lEntidad.idGrupo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As grupos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idGrupo = @idGrupo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idGrupo", SqlDbType.Int)
        args(0).Value = lEntidad.idGrupo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.grupo = IIf(.Item("grupo") Is DBNull.Value, Nothing, .Item("grupo"))
                lEntidad.codigoGrupo = IIf(.Item("codigoGrupo") Is DBNull.Value, Nothing, .Item("codigoGrupo"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As grupos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idGrupo),0) + 1 ")
        strSQL.Append(" FROM grupos ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listagrupos

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listagrupos

        Try
            Do While dr.Read()
                Dim mEntidad As New grupos
                mEntidad.idGrupo = IIf(dr("idGrupo") Is DBNull.Value, Nothing, dr("idGrupo"))
                mEntidad.grupo = IIf(dr("grupo") Is DBNull.Value, Nothing, dr("grupo"))
                mEntidad.codigoGrupo = IIf(dr("codigoGrupo") Is DBNull.Value, Nothing, dr("codigoGrupo"))
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
        tables(0) = New String("grupos")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT idGrupo, ") 
        strSQL.Append(" grupo, ") 
        strSQL.Append(" codigoGrupo ") 
        strSQL.Append(" FROM grupos ")

    End Sub

    Public Function ObtenerIDCentro(ByVal ccodsol) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodcen from cremsol where ccodsol = @ccodsol ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lccodcen As String
        If ds.Tables(0).Rows.Count = 0 Then
            lccodcen = "001001000000"
        Else
            lccodcen = ds.Tables(0).Rows(0)("ccodcen")
        End If
        Return lccodcen
    End Function

End Class
