Imports System.Text
Public Class dbAhomtrs
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomtrs
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodtrs =  "" _
            Or lEntidad.ccodtrs = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodtrs = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomtrs ")
        strSQL.Append(" SET cnomtrs = @cnomtrs, ") 
        strSQL.Append(" ccta1 = @ccta1, ") 
        strSQL.Append(" ccta2 = @ccta2, ") 
        strSQL.Append(" ccta3 = @ccta3, ") 
        strSQL.Append(" ccta4 = @ccta4, ") 
        strSQL.Append(" ccta5 = @ccta5, ") 
        strSQL.Append(" ccta6 = @ccta6, ") 
        strSQL.Append(" ccodtip = @ccodtip, ") 
        strSQL.Append(" cahodep = @cahodep, ") 
        strSQL.Append(" cdiames = @cdiames, ") 
        strSQL.Append(" ctipaho = @ctipaho ") 
        strSQL.Append(" cmoneda = @cmoneda, ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" WHERE ccodtrs = @ccodtrs ") 

        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@cnomtrs", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomtrs
        args(1) = New SqlParameter("@ccta1", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccta1
        args(2) = New SqlParameter("@ccta2", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccta2
        args(3) = New SqlParameter("@ccta3", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccta3
        args(4) = New SqlParameter("@ccta4", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccta4
        args(5) = New SqlParameter("@ccta5", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccta5
        args(6) = New SqlParameter("@ccta6", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccta6
        args(7) = New SqlParameter("@ccodtip", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodtip
        args(8) = New SqlParameter("@cahodep", SqlDbType.VarChar)
        args(8).Value = lEntidad.cahodep
        args(9) = New SqlParameter("@cdiames", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdiames
        args(10) = New SqlParameter("@ctipaho", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctipaho
        args(11) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(11).Value = lEntidad.cmoneda
        args(12) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(12).Value = lEntidad.cflag
        args(13) = New SqlParameter("@ccodtrs", SqlDbType.VarChar)
        args(13).Value = IIf(lEntidad.ccodtrs = Nothing, DBNull.Value,lEntidad.ccodtrs)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomtrs
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomtrs ")
        strSQL.Append(" ( ccodtrs, ") 
        strSQL.Append(" cnomtrs, ") 
        strSQL.Append(" ccta1, ") 
        strSQL.Append(" ccta2, ") 
        strSQL.Append(" ccta3, ") 
        strSQL.Append(" ccta4, ") 
        strSQL.Append(" ccta5, ") 
        strSQL.Append(" ccta6, ") 
        strSQL.Append(" ccodtip, ") 
        strSQL.Append(" cahodep, ") 
        strSQL.Append(" cdiames, ") 
        strSQL.Append(" ctipaho) ") 
        strSQL.Append(" cmoneda, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodtrs, ") 
        strSQL.Append(" @cnomtrs, ") 
        strSQL.Append(" @ccta1, ") 
        strSQL.Append(" @ccta2, ") 
        strSQL.Append(" @ccta3, ") 
        strSQL.Append(" @ccta4, ") 
        strSQL.Append(" @ccta5, ") 
        strSQL.Append(" @ccta6, ") 
        strSQL.Append(" @ccodtip, ") 
        strSQL.Append(" @cahodep, ") 
        strSQL.Append(" @cdiames, ") 
        strSQL.Append(" @ctipaho) ") 
        strSQL.Append(" @cmoneda, ") 
        strSQL.Append(" @cflag, ") 

        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@ccodtrs", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodtrs = Nothing, DBNull.Value, lEntidad.ccodtrs)
        args(1) = New SqlParameter("@cnomtrs", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomtrs
        args(2) = New SqlParameter("@ccta1", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccta1
        args(3) = New SqlParameter("@ccta2", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccta2
        args(4) = New SqlParameter("@ccta3", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccta3
        args(5) = New SqlParameter("@ccta4", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccta4
        args(6) = New SqlParameter("@ccta5", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccta5
        args(7) = New SqlParameter("@ccta6", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccta6
        args(8) = New SqlParameter("@ccodtip", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodtip
        args(9) = New SqlParameter("@cahodep", SqlDbType.VarChar)
        args(9).Value = lEntidad.cahodep
        args(10) = New SqlParameter("@cdiames", SqlDbType.VarChar)
        args(10).Value = lEntidad.cdiames
        args(11) = New SqlParameter("@ctipaho", SqlDbType.VarChar)
        args(11).Value = lEntidad.ctipaho
        args(12) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(12).Value = lEntidad.cmoneda
        args(13) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(13).Value = lEntidad.cflag

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomtrs
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomtrs ")
        strSQL.Append(" WHERE ccodtrs = @ccodtrs ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodtrs", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodtrs

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomtrs
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtrs = @ccodtrs ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodtrs", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodtrs

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomtrs = IIf(.Item("cnomtrs") Is DBNull.Value, Nothing, .Item("cnomtrs"))
                lEntidad.ccta1 = IIf(.Item("ccta1") Is DBNull.Value, Nothing, .Item("ccta1"))
                lEntidad.ccta2 = IIf(.Item("ccta2") Is DBNull.Value, Nothing, .Item("ccta2"))
                lEntidad.ccta3 = IIf(.Item("ccta3") Is DBNull.Value, Nothing, .Item("ccta3"))
                lEntidad.ccta4 = IIf(.Item("ccta4") Is DBNull.Value, Nothing, .Item("ccta4"))
                lEntidad.ccta5 = IIf(.Item("ccta5") Is DBNull.Value, Nothing, .Item("ccta5"))
                lEntidad.ccta6 = IIf(.Item("ccta6") Is DBNull.Value, Nothing, .Item("ccta6"))
                lEntidad.ccodtip = IIf(.Item("ccodtip") Is DBNull.Value, Nothing, .Item("ccodtip"))
                lEntidad.cahodep = IIf(.Item("cahodep") Is DBNull.Value, Nothing, .Item("cahodep"))
                lEntidad.cdiames = IIf(.Item("cdiames") Is DBNull.Value, Nothing, .Item("cdiames"))
                lEntidad.ctipaho = IIf(.Item("ctipaho") Is DBNull.Value, Nothing, .Item("ctipaho"))
                lEntidad.cmoneda = IIf(.Item("cmoneda") Is DBNull.Value, Nothing, .Item("cmoneda"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomtrs
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodtrs),0) + 1 ")
        strSQL.Append(" FROM ahomtrs ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaahomtrs

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaahomtrs

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomtrs
                mEntidad.ccodtrs = IIf(dr("ccodtrs") Is DBNull.Value, Nothing, dr("ccodtrs"))
                mEntidad.cnomtrs = IIf(dr("cnomtrs") Is DBNull.Value, Nothing, dr("cnomtrs"))
                mEntidad.ccta1 = IIf(dr("ccta1") Is DBNull.Value, Nothing, dr("ccta1"))
                mEntidad.ccta2 = IIf(dr("ccta2") Is DBNull.Value, Nothing, dr("ccta2"))
                mEntidad.ccta3 = IIf(dr("ccta3") Is DBNull.Value, Nothing, dr("ccta3"))
                mEntidad.ccta4 = IIf(dr("ccta4") Is DBNull.Value, Nothing, dr("ccta4"))
                mEntidad.ccta5 = IIf(dr("ccta5") Is DBNull.Value, Nothing, dr("ccta5"))
                mEntidad.ccta6 = IIf(dr("ccta6") Is DBNull.Value, Nothing, dr("ccta6"))
                mEntidad.ccodtip = IIf(dr("ccodtip") Is DBNull.Value, Nothing, dr("ccodtip"))
                mEntidad.cahodep = IIf(dr("cahodep") Is DBNull.Value, Nothing, dr("cahodep"))
                mEntidad.cdiames = IIf(dr("cdiames") Is DBNull.Value, Nothing, dr("cdiames"))
                mEntidad.ctipaho = IIf(dr("ctipaho") Is DBNull.Value, Nothing, dr("ctipaho"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
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
        tables(0) = New String("ahomtrs")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodtrs, ") 
        strSQL.Append(" cnomtrs, ") 
        strSQL.Append(" ccta1, ") 
        strSQL.Append(" ccta2, ") 
        strSQL.Append(" ccta3, ") 
        strSQL.Append(" ccta4, ") 
        strSQL.Append(" ccta5, ") 
        strSQL.Append(" ccta6, ") 
        strSQL.Append(" ccodtip, ") 
        strSQL.Append(" cahodep, ") 
        strSQL.Append(" cdiames, ") 
        strSQL.Append(" ctipaho, ") 
        strSQL.Append(" cmoneda, ") 
        strSQL.Append(" cflag ") 
        strSQL.Append(" FROM ahomtrs ")

    End Sub

    Public Function ObtenerCuenta(ByVal ccodtrs As String, ByVal campo As Integer) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ")
        If campo = 1 Then
            strSQL.Append("ccta1 ")
        ElseIf campo = 2 Then
            strSQL.Append("ccta2 ")
        ElseIf campo = 3 Then
            strSQL.Append("ccta3 ")
        ElseIf campo = 4 Then
            strSQL.Append("ccta4 ")
        ElseIf campo = 5 Then
            strSQL.Append("ccta5 ")
        ElseIf campo = 6 Then
            strSQL.Append("ccta6 ")
        ElseIf campo = 7 Then
            strSQL.Append("ccodtip ")
        ElseIf campo = 8 Then
            strSQL.Append("cahodep ")
        ElseIf campo = 9 Then
            strSQL.Append("cdiames ")
        ElseIf campo = 10 Then
            strSQL.Append("ctipaho ")
        ElseIf campo = 11 Then
            strSQL.Append("cmoneda ")
        End If

        strSQL.Append("from ahomtrs where ccodtrs = @ccodtrs ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtrs", SqlDbType.VarChar)
        args(0).Value = ccodtrs

        args(1) = New SqlParameter("@campo", SqlDbType.VarChar)
        args(1).Value = campo

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        Dim lccampo As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If campo = 1 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccta1")), "", ds.Tables(0).Rows(0)("ccta1"))
            ElseIf campo = 2 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccta2")), "", ds.Tables(0).Rows(0)("ccta2"))
            ElseIf campo = 3 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccta3")), "", ds.Tables(0).Rows(0)("ccta3"))
            ElseIf campo = 4 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccta4")), "", ds.Tables(0).Rows(0)("ccta4"))
            ElseIf campo = 5 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccta5")), "", ds.Tables(0).Rows(0)("ccta5"))
            ElseIf campo = 6 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccta6")), "", ds.Tables(0).Rows(0)("ccta6"))
            ElseIf campo = 7 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccodtip")), "", ds.Tables(0).Rows(0)("ccodtip"))
            ElseIf campo = 8 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("cahodep")), "", ds.Tables(0).Rows(0)("cahodep"))
            ElseIf campo = 9 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("cdiames")), "", ds.Tables(0).Rows(0)("cdiames"))
            ElseIf campo = 10 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("ctipaho")), "", ds.Tables(0).Rows(0)("ctipaho"))
            ElseIf campo = 11 Then
                lccampo = IIf(IsDBNull(ds.Tables(0).Rows(0)("cmoneda")), "", ds.Tables(0).Rows(0)("cmoneda"))
            End If

        End If
        Return lccampo
    End Function

End Class
