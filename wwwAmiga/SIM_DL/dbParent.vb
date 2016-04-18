Imports System.Text
Public Class dbParent
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As parent
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cparent =  "" _
            Or lEntidad.cparent = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cparent = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE parent ")
        strSQL.Append(" SET cdescri = @cdescri, ") 
        strSQL.Append(" WHERE cparent = @cparent ") 

        Dim args(-1) As SqlParameter
        args(0) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(0).Value = lEntidad.cdescri
        args(1) = New SqlParameter("@cparent", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.cparent = Nothing, DBNull.Value,lEntidad.cparent)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As parent
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO parent ")
        strSQL.Append(" ( cparent, ") 
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cparent, ") 
        strSQL.Append(" @cdescri, ") 

        Dim args(-1) As SqlParameter
        args(0) = New SqlParameter("@cparent", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cparent = Nothing, DBNull.Value, lEntidad.cparent)
        args(1) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdescri

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As parent
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM parent ")
        strSQL.Append(" WHERE cparent = @cparent ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cparent", SqlDbType.VarChar)
        args(0).Value = lEntidad.cparent

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As parent
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cparent = @cparent ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cparent", SqlDbType.VarChar)
        args(0).Value = lEntidad.cparent

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cdescri = IIf(.Item("cdescri") Is DBNull.Value, Nothing, .Item("cdescri"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As parent
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cparent),0) + 1 ")
        strSQL.Append(" FROM parent ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaparent

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaparent

        Try
            Do While dr.Read()
                Dim mEntidad As New parent
                mEntidad.cparent = IIf(dr("cparent") Is DBNull.Value, Nothing, dr("cparent"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
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
        tables(0) = New String("parent")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT cparent, ") 
        strSQL.Append(" cdescri ") 
        strSQL.Append(" FROM parent ")

    End Sub

End Class
