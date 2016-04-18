Imports System.Text
Public Class dbAhompro2
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahompro2
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.dultpro = Nothing Then

            '      lID = Me.ObtenerID(lEntidad)

            '     If lID = -1 Then Return -1

            '    lEntidad.dultpro = lID
            '
            '           Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahompro2 ")
        strSQL.Append(" WHERE dultpro = @dultpro ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dultpro", SqlDbType.DateTime)
        args(0).Value = IIf(lEntidad.dultpro = Nothing, DBNull.Value, lEntidad.dultpro)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahompro2
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahompro2 ")
        strSQL.Append(" (dultpro) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @dultpro) ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dultpro", SqlDbType.Datetime)
        args(0).Value = IIf(lEntidad.dultpro = Nothing, DBNull.Value, lEntidad.dultpro)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahompro2
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahompro2 ")
        strSQL.Append(" WHERE dultpro = @dultpro ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dultpro", SqlDbType.Datetime)
        args(0).Value = lEntidad.dultpro

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahompro2
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dultpro = @dultpro ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dultpro", SqlDbType.Datetime)
        args(0).Value = lEntidad.dultpro

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

        Dim lEntidad As ahompro2
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(dultpro),0) + 1 ")
        strSQL.Append(" FROM ahompro2 ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaahompro2

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaahompro2

        Try
            Do While dr.Read()
                Dim mEntidad As New ahompro2
                mEntidad.dultpro = IIf(dr("dultpro") Is DBNull.Value, Nothing, dr("dultpro"))
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
        tables(0) = New String("ahompro2")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT dultpro ") 
        strSQL.Append(" FROM ahompro2 ")

    End Sub

End Class
