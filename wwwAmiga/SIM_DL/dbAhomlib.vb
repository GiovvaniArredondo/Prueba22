Imports System.Text
Public Class dbAhomlib
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomlib
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.nlibreta =  0 _
            Or lEntidad.nlibreta = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.nlibreta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomlib ")
        strSQL.Append(" SET cestado = @cestado, ") 
        strSQL.Append(" dfeccan = @dfeccan, ") 
        strSQL.Append(" crazon = @crazon, ") 
        strSQL.Append(" dfecapr = @dfecapr ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND nlibreta = @nlibreta ") 

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cestado = Nothing, DBNull.Value, lEntidad.cestado)
        args(1) = New SqlParameter("@dfeccan", SqlDbType.Datetime)
        args(1).Value = IIf(lEntidad.dfeccan = Nothing, DBNull.Value, lEntidad.dfeccan)
        args(2) = New SqlParameter("@crazon", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.crazon = Nothing, DBNull.Value, lEntidad.crazon)
        args(3) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(3).Value = IIf(lEntidad.dfecapr = Nothing, DBNull.Value, lEntidad.dfecapr)
        args(4) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(4).Value = IIf(lEntidad.dfecmod = Nothing, DBNull.Value, lEntidad.dfecmod)
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodusu = Nothing, DBNull.Value, lEntidad.ccodusu)
        args(6) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value,lEntidad.ccodaho)
        args(7) = New SqlParameter("@nlibreta", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.nlibreta = Nothing, DBNull.Value,lEntidad.nlibreta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomlib
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomlib ")
        strSQL.Append(" ( ccodaho, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" dfeccan, ") 
        strSQL.Append(" crazon, ") 
        strSQL.Append(" dfecapr, ")
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodaho, ") 
        strSQL.Append(" @nlibreta, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @dfeccan, ") 
        strSQL.Append(" @crazon, ") 
        strSQL.Append(" @dfecapr, ")
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @ccodusu) ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(1) = New SqlParameter("@nlibreta", SqlDbType.Decimal)
        args(1).Value = IIf(lEntidad.nlibreta = Nothing, 0, lEntidad.nlibreta)
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.cestado = Nothing, DBNull.Value, lEntidad.cestado)
        args(3) = New SqlParameter("@dfeccan", SqlDbType.Datetime)
        args(3).Value = IIf(lEntidad.dfeccan = Nothing, DBNull.Value, lEntidad.dfeccan)
        args(4) = New SqlParameter("@crazon", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.crazon = Nothing, DBNull.Value, lEntidad.crazon)
        args(5) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(5).Value = IIf(lEntidad.dfecapr = Nothing, DBNull.Value, lEntidad.dfecapr)
        args(6) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(6).Value = IIf(lEntidad.dfecmod = Nothing, DBNull.Value, lEntidad.dfecmod)
        args(7) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.ccodusu = Nothing, DBNull.Value, lEntidad.ccodusu)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomlib
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomlib ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND nlibreta = @nlibreta ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@nlibreta", SqlDbType.VarChar)
        args(1).Value = lEntidad.nlibreta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomlib
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND nlibreta = @nlibreta ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@nlibreta", SqlDbType.VarChar)
        args(1).Value = lEntidad.nlibreta

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.dfeccan = IIf(.Item("dfeccan") Is DBNull.Value, Nothing, .Item("dfeccan"))
                lEntidad.crazon = IIf(.Item("crazon") Is DBNull.Value, Nothing, .Item("crazon"))
                lEntidad.dfecapr = IIf(.Item("dfecapr") Is DBNull.Value, Nothing, .Item("dfecapr"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomlib
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(nlibreta),0) + 1 ")
        strSQL.Append(" FROM ahomlib ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodaho As String) As listaahomlib

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listaahomlib

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomlib
                mEntidad.ccodaho = ccodaho
                mEntidad.nlibreta = IIf(dr("nlibreta") Is DBNull.Value, Nothing, dr("nlibreta"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.dfeccan = IIf(dr("dfeccan") Is DBNull.Value, Nothing, dr("dfeccan"))
                mEntidad.crazon = IIf(dr("crazon") Is DBNull.Value, Nothing, dr("crazon"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodaho As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodaho As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim tables(0) As String
        tables(0) = New String("ahomlib")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodaho, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" dfeccan, ") 
        strSQL.Append(" crazon, ") 
        strSQL.Append(" dfecapr, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu ") 
        strSQL.Append(" FROM ahomlib ")

    End Sub

    Public Function ObtenerCorrelativoSugerido() As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Select MAX(nlibreta) as nlibreta FROM AHOMLIB ")

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lnlibreta As Integer = 1
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nlibreta")) Then
            Else
                lnlibreta = ds.Tables(0).Rows(0)("nlibreta")
                lnlibreta += 1

            End If
        End If

        Return lnlibreta
    End Function
    Public Function VerificaLibreta(ByVal nlibreta As Integer) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nlibreta FROM AHOMLIB ")
        strSQL.Append("WHERE nlibreta = @nlibreta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@nlibreta", nlibreta)


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lverifica As Boolean = False
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nlibreta")) Then
            Else
                lverifica = True
            End If
        End If

        Return lverifica

    End Function

End Class
