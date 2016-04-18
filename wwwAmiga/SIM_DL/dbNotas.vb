Imports System.Text
Public Class dbNotas
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As notas
        Dim lID As Long
        lEntidad = aEntidad

        'If lEntidad.ccodcta = Nothing Then

        '    lID = Me.ObtenerID(lEntidad)

        '    If lID = -1 Then Return -1

        '    lEntidad.ccodcta = lID

        '    Return Agregar(lEntidad)

        'End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE notas ")
        strSQL.Append(" SET  ")
        strSQL.Append(" dias = @dias, ") 
        strSQL.Append(" nota = @nota ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND fecha >= @fecha and fecha <= @fecha ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@dias", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.dias = Nothing, DBNull.Value, lEntidad.dias)
        args(2) = New SqlParameter("@nota", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.nota = Nothing, "", lEntidad.nota)
        args(3) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value,lEntidad.ccodcta)
        args(4) = New SqlParameter("@fecha", SqlDbType.Datetime)
        args(4).Value = IIf(lEntidad.fecha = Nothing, DBNull.Value,lEntidad.fecha)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As notas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO notas ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" fecha, ")
        strSQL.Append(" dias, ") 
        strSQL.Append(" nota) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodcta, ") 
        strSQL.Append(" @fecha, ")
        strSQL.Append(" @dias, ") 
        strSQL.Append(" @nota) ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(2) = New SqlParameter("@fecha", SqlDbType.Datetime)
        args(2).Value = IIf(lEntidad.fecha = Nothing, DBNull.Value, lEntidad.fecha)
        args(3) = New SqlParameter("@dias", SqlDbType.Int)
        args(3).Value = IIf(lEntidad.dias = Nothing, DBNull.Value, lEntidad.dias)
        args(4) = New SqlParameter("@nota", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.nota = Nothing, DBNull.Value, lEntidad.nota)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As notas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM notas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND fecha = @fecha ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@fecha", SqlDbType.Datetime)
        args(1).Value = lEntidad.fecha

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As notas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND fecha = @fecha ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@fecha", SqlDbType.Datetime)
        args(1).Value = lEntidad.fecha

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, "", .Item("ccodcli"))
                lEntidad.dias = IIf(.Item("dias") Is DBNull.Value, 0, .Item("dias"))
                lEntidad.nota = IIf(.Item("nota") Is DBNull.Value, "", .Item("nota"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As notas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(fecha),0) + 1 ")
        strSQL.Append(" FROM notas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcta As String) As listanotas

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listanotas

        Try
            Do While dr.Read()
                Dim mEntidad As New notas
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccodcta = ccodcta
                mEntidad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
                mEntidad.dias = IIf(dr("dias") Is DBNull.Value, Nothing, dr("dias"))
                mEntidad.nota = IIf(dr("nota") Is DBNull.Value, Nothing, dr("nota"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim tables(0) As String
        tables(0) = New String("notas")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcli, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" fecha, ") 
        strSQL.Append(" dias, ") 
        strSQL.Append(" nota ") 
        strSQL.Append(" FROM notas ")

    End Sub

    Public Function ObtieneNota(ByVal ccodcta As String, ByVal dfecha As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nota FROM notas ")
        strSQL.Append("WHERE ccodcta = @ccodcta and fecha >= @dfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcnota As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nota")) Then
            Else
                lcnota = ds.Tables(0).Rows(0)("nota")
            End If
        End If

        Return lcnota
    End Function

    Public Function Verficasiprocedenota(ByVal dfecha As Date, ByVal ccodcta As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("select nota from notas ")
        strSQL.Append("where fecha >= @dfecha and fecha <= @dfecha and ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfecha", dfecha)

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lverifica As Boolean = True
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nota")) Then
            Else
                lverifica = False
            End If
        End If

        Return lverifica
    End Function

End Class
