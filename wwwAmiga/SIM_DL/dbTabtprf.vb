Imports System.Text
Public Class dbTabtprf
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtprf
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodigo =  "" _
            Or lEntidad.ccodigo = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodigo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtprf ")
        strSQL.Append(" SET cdescri = @cdescri, ") 
        strSQL.Append(" WHERE ccodigo = @ccodigo ") 

        Dim args(-1) As SqlParameter
        args(0) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(0).Value = lEntidad.cdescri
        args(1) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value,lEntidad.ccodigo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtprf
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtprf ")
        strSQL.Append(" ( ccodigo, ") 
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodigo, ") 
        strSQL.Append(" @cdescri, ") 

        Dim args(-1) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value, lEntidad.ccodigo)
        args(1) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdescri

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtprf
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtprf ")
        strSQL.Append(" WHERE ccodigo = @ccodigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodigo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtprf
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodigo = @ccodigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodigo

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

        Dim lEntidad As tabtprf
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodigo),0) + 1 ")
        strSQL.Append(" FROM tabtprf ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listatabtprf

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" order by cdescri ")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listatabtprf

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtprf
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
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
        tables(0) = New String("tabtprf")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT rtrim(ltrim(ccodigo)) as ccodigo, ")
        strSQL.Append(" cdescri ") 
        strSQL.Append(" FROM tabtprf ")

    End Sub
    Public Function profesion(ByVal lccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cdescri from tabtprf ")
        strSQL.Append("WHERE cCodigo = @lcCodigo")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo
        
        Dim lcprofes As String
        Dim dsprof As DataSet
        dsprof = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsprof.Tables(0).Rows.Count = 0 Then
            lcprofes = "NO INDICADO"
        Else
            lcprofes = dsprof.Tables(0).Rows(0)("cdescri")
        End If
        Return lcprofes
    End Function

End Class
