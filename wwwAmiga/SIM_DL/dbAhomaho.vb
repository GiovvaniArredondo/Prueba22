Imports System.Text
Public Class dbAhomaho
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomaho
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.dfeccap = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            '     lEntidad.dfeccap = lID

            '     Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomaho ")
        strSQL.Append(" SET cnudotr = @cnudotr, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" nsaldoaho = @nsaldoaho, ")
        strSQL.Append(" ccodlin = @ccodlin, ")
        strSQL.Append(" cdeslin = @cdeslin, ")
        strSQL.Append(" producto = @producto, ")
        strSQL.Append(" nintere = @nintere ")
        strSQL.Append(" cnomcli = @cnomcli, ")
        strSQL.Append(" nsaldoant = @nsaldoant, ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ")
        strSQL.Append(" AND dfeccap = @dfeccap ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnudotr
        args(1) = New SqlParameter("@ntasint", SqlDbType.VarChar)
        args(1).Value = lEntidad.ntasint
        args(2) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(2).Value = lEntidad.nsaldoaho
        args(3) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodlin
        args(4) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdeslin
        args(5) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(5).Value = lEntidad.producto
        args(6) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(6).Value = lEntidad.nintere
        args(7) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(7).Value = lEntidad.cnomcli
        args(8) = New SqlParameter("@nsaldoant", SqlDbType.Decimal)
        args(8).Value = lEntidad.nsaldoant
        args(9) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(10) = New SqlParameter("@dfeccap", SqlDbType.DateTime)
        args(10).Value = IIf(lEntidad.dfeccap = Nothing, DBNull.Value, lEntidad.dfeccap)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomaho
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomaho ")
        strSQL.Append(" ( ccodaho, ") 
        strSQL.Append(" cnudotr, ") 
        strSQL.Append(" dfeccap, ") 
        strSQL.Append(" ntasint, ") 
        strSQL.Append(" nsaldoaho, ") 
        strSQL.Append(" ccodlin, ") 
        strSQL.Append(" cdeslin, ") 
        strSQL.Append(" producto, ") 
        strSQL.Append(" nintere, ")
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" nsaldoant) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodaho, ") 
        strSQL.Append(" @cnudotr, ") 
        strSQL.Append(" @dfeccap, ") 
        strSQL.Append(" @ntasint, ") 
        strSQL.Append(" @nsaldoaho, ") 
        strSQL.Append(" @ccodlin, ") 
        strSQL.Append(" @cdeslin, ") 
        strSQL.Append(" @producto, ") 
        strSQL.Append(" @nintere, ")
        strSQL.Append(" @cnomcli, ") 
        strSQL.Append(" @nsaldoant) ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(1) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnudotr
        args(2) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(2).Value = IIf(lEntidad.dfeccap = Nothing, DBNull.Value, lEntidad.dfeccap)
        args(3) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(3).Value = lEntidad.ntasint
        args(4) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(4).Value = lEntidad.nsaldoaho
        args(5) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodlin
        args(6) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(6).Value = lEntidad.cdeslin
        args(7) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(7).Value = lEntidad.producto
        args(8) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(8).Value = lEntidad.nintere
        args(9) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(9).Value = lEntidad.cnomcli
        args(10) = New SqlParameter("@nsaldoant", SqlDbType.Decimal)
        args(10).Value = lEntidad.nsaldoant

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomaho
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomaho ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND dfeccap = @dfeccap ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfeccap

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomaho
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND dfeccap = @dfeccap ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfeccap

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnudotr = IIf(.Item("cnudotr") Is DBNull.Value, Nothing, .Item("cnudotr"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.nsaldoaho = IIf(.Item("nsaldoaho") Is DBNull.Value, Nothing, .Item("nsaldoaho"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.cdeslin = IIf(.Item("cdeslin") Is DBNull.Value, Nothing, .Item("cdeslin"))
                lEntidad.producto = IIf(.Item("producto") Is DBNull.Value, Nothing, .Item("producto"))
                lEntidad.nintere = IIf(.Item("nintere") Is DBNull.Value, Nothing, .Item("nintere"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.nsaldoant = IIf(.Item("nsaldoant") Is DBNull.Value, Nothing, .Item("nsaldoant"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomaho
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(dfeccap),0) + 1 ")
        strSQL.Append(" FROM ahomaho ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodaho As String) As listaahomaho

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listaahomaho

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomaho
                mEntidad.ccodaho = ccodaho
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.nsaldoant = IIf(dr("nsaldoant") Is DBNull.Value, Nothing, dr("nsaldoant"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    'obtiene lista filtrada por codigo de ahorros y fechas
    Public Function ObtenerListaporcuentayfechas(ByVal ccodaho As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As listaahomaho

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ")
        strSQL.Append(" and dfeccap >= @dfecha1 ")
        strSQL.Append(" and dfeccap <= @dfecha2 ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho
        args(1) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(1).Value = dfecha1
        args(2) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(2).Value = dfecha2

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaahomaho

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomaho
                mEntidad.ccodaho = ccodaho
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.nsaldoant = IIf(dr("nsaldoant") Is DBNull.Value, Nothing, dr("nsaldoant"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerDataSetPorID(ByVal ccodaho As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    'obtiene dataset por fecha
    Public Function ObtenerDataSetPorfecha(ByVal dfeccap As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfeccap = @dfeccap ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dfeccap", dfeccap)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    Public Function ObtenerDataSetPorID(ByVal ccodaho As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim tables(0) As String
        tables(0) = New String("ahomaho")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodaho, ")
        strSQL.Append(" cnudotr, ")
        strSQL.Append(" dfeccap, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" nsaldoaho, ")
        strSQL.Append(" ccodlin, ")
        strSQL.Append(" cdeslin, ")
        strSQL.Append(" producto, ")
        strSQL.Append(" nintere, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" nsaldoant ")
        strSQL.Append(" FROM ahomaho ")

    End Sub

End Class
