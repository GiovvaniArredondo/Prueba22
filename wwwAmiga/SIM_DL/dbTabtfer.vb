Imports System.Text
Public Class dbTabtfer
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtfer
        Dim lID As Long
        lEntidad = aEntidad

        '        If lEntidad.dferiad =  0 _
        '           Or lEntidad.dferiad = Nothing Then 

        '      lID = Me.ObtenerID(lEntidad)

        '        If lID = -1 Then Return -1

        '        lEntidad.dferiad = lID

        '        Return Agregar(lEntidad)

        '       End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtfer ")
        strSQL.Append(" SET xflag1 = @xflag1, ")
        strSQL.Append(" WHERE dferiad = @dferiad ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@xflag1", SqlDbType.VarChar)
        args(0).Value = lEntidad.xflag1

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtfer
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtfer ")
        strSQL.Append(" ( dferiad, ")
        strSQL.Append(" xflag1) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @dferiad, ")
        strSQL.Append(" @xflag1) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dferiad", SqlDbType.DateTime)
        args(0).Value = lEntidad.dferiad
        args(1) = New SqlParameter("@xflag1", SqlDbType.VarChar)
        args(1).Value = lEntidad.xflag1

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtfer
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtfer ")
        strSQL.Append(" WHERE dferiad = @dferiad ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dferiad", SqlDbType.DateTime)
        args(0).Value = lEntidad.dferiad

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtfer
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dferiad = @dferiad ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dferiad", SqlDbType.DateTime)
        args(0).Value = lEntidad.dferiad

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.xflag1 = IIf(.Item("xflag1") Is DBNull.Value, Nothing, .Item("xflag1"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtfer
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT case isnull(max(dferiad)) when 1 then 1 else max(dferiad) + 1 end ")
        strSQL.Append(" FROM tabtfer ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listatabtfer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listatabtfer

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtfer
                mEntidad.dferiad = IIf(dr("dferiad") Is DBNull.Value, Nothing, dr("dferiad"))
                mEntidad.xflag1 = IIf(dr("xflag1") Is DBNull.Value, Nothing, dr("xflag1"))
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

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function ObtenerDataSetPorIDOficina(ByVal ccodofi As String, ByVal pdfecven As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" where ccodofi='" & ccodofi & "' and dferiad >='" & pdfecven & "'")
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("tabtfer")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT dferiad, ")
        strSQL.Append(" xflag1 ")
        strSQL.Append(" FROM tabtfer ")

    End Sub

    Public Function ValidaFeriado(ByVal dfecha As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Select dferiad FROM TABTFER  WHERE dferiad>= @dfecha and dferiad<= @dfecha ")

        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim i As Integer = 0
        If ds.Tables(0).Rows.Count = 0 Then
            i = 0
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("dferiad")) Then
                i = 0
            Else
                i = 1
            End If
        End If
        Return i
    End Function
End Class
