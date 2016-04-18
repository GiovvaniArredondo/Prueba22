Imports System.Text
Public Class dbCLIDAGRO
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDAGRO
        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CLIDAGRO ")
        strSQL.Append(" SET ccodusu = @ccodusu, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" ningreso = @ningreso, ")
        strSQL.Append(" ncosto = @ncosto, ") 
        strSQL.Append(" nrendimiento = @nrendimiento ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 
        strSQL.Append(" AND ccodigo = @ccodigo ") 
        strSQL.Append(" AND ctipo = @ctipo ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodusu
        args(1) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecmod
        args(2) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(2).Value = lEntidad.cflag
        args(3) = New SqlParameter("@ningreso", SqlDbType.VarChar)
        args(3).Value = lEntidad.ningreso
        args(4) = New SqlParameter("@ncosto", SqlDbType.VarChar)
        args(4).Value = lEntidad.ncosto
        args(5) = New SqlParameter("@nrendimiento", SqlDbType.VarChar)
        args(5).Value = lEntidad.nrendimiento
        args(6) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodcli = Nothing, "", lEntidad.ccodcli)
        args(7) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.ccodfue = Nothing, "", lEntidad.ccodfue)
        args(8) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(8).Value = IIf(lEntidad.devalua = Nothing, DBNull.Value,lEntidad.devalua)
        args(9) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.ccodigo = Nothing, "", lEntidad.ccodigo)
        args(10) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ctipo = Nothing, "", lEntidad.ctipo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDAGRO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO CLIDAGRO ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodfue, ") 
        strSQL.Append(" devalua, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" ccodigo, ") 
        strSQL.Append(" ningreso, ")
        strSQL.Append(" ncosto, ") 
        strSQL.Append(" nrendimiento, ctipo) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodfue, ") 
        strSQL.Append(" @devalua, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @ccodigo, ") 
        strSQL.Append(" @ningreso, ")
        strSQL.Append(" @ncosto, ") 
        strSQL.Append(" @nrendimiento, @ctipo) ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value, lEntidad.ccodfue)
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = IIf(lEntidad.devalua = Nothing, DBNull.Value, lEntidad.devalua)
        args(3) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodusu
        args(4) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(4).Value = lEntidad.dfecmod
        args(5) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(5).Value = lEntidad.cflag
        args(6) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value, lEntidad.ccodigo)
        args(7) = New SqlParameter("@ningreso", SqlDbType.VarChar)
        args(7).Value = lEntidad.ningreso
        args(8) = New SqlParameter("@ncosto", SqlDbType.VarChar)
        args(8).Value = lEntidad.ncosto
        args(9) = New SqlParameter("@nrendimiento", SqlDbType.VarChar)
        args(9).Value = lEntidad.nrendimiento
        args(10) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctipo


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDAGRO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CLIDAGRO ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 
        strSQL.Append(" AND ccodigo = @ccodigo ") 
        strSQL.Append(" AND ctipo = @ctipo ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = lEntidad.devalua
        args(3) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodigo
        args(4) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipo


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDAGRO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 
        strSQL.Append(" AND ccodigo = @ccodigo ") 
        strSQL.Append(" AND ctipo = @ctipo ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = lEntidad.devalua
        args(3) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodigo
        args(4) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.ningreso = IIf(.Item("ningreso") Is DBNull.Value, Nothing, .Item("ningreso"))
                lEntidad.ncosto = IIf(.Item("ncosto") Is DBNull.Value, Nothing, .Item("ncosto"))
                lEntidad.nrendimiento = IIf(.Item("nrendimiento") Is DBNull.Value, Nothing, .Item("nrendimiento"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As CLIDAGRO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodigo),0) + 1 ")
        strSQL.Append(" FROM CLIDAGRO ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = lEntidad.devalua

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcli As String, ccodfue As String, devalua As DateTime) As listaCLIDAGRO

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = devalua

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaCLIDAGRO

        Try
            Do While dr.Read()
                Dim mEntidad As New CLIDAGRO
                mEntidad.ccodcli = ccodcli
                mEntidad.ccodfue = ccodfue
                mEntidad.devalua = devalua
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
                mEntidad.ningreso = IIf(dr("ningreso") Is DBNull.Value, Nothing, dr("ningreso"))
                mEntidad.ncosto = IIf(dr("ncosto") Is DBNull.Value, Nothing, dr("ncosto"))
                mEntidad.nrendimiento = IIf(dr("nrendimiento") Is DBNull.Value, Nothing, dr("nrendimiento"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, ccodfue As String, devalua As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)
        args(2) = New SqlParameter("@devalua", devalua)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, ccodfue As String, devalua As DateTime, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ccodcli, ")
        strSQL.Append(" ccodfue, ")
        strSQL.Append(" devalua, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" (ctipo + ccodigo) as ccodigo, ")
        strSQL.Append(" ningreso, ")
        strSQL.Append(" ncosto, ")
        strSQL.Append(" nrendimiento, ctipo, space(120) as descripcion ")
        strSQL.Append(" FROM CLIDAGRO ")

        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)
        args(2) = New SqlParameter("@devalua", devalua)

        Dim tables(0) As String
        tables(0) = New String("CLIDAGRO")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcli, ") 
        strSQL.Append(" ccodfue, ") 
        strSQL.Append(" devalua, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" ccodigo, ") 
        strSQL.Append(" ningreso, ") 
        strSQL.Append(" ncosto, ") 
        strSQL.Append(" nrendimiento, ctipo, space(120) as descripcion ")
        strSQL.Append(" FROM CLIDAGRO ")

    End Sub
    Public Function ObtenerDataSet(ByVal ccodcli As String, ByVal ccodfue As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT devalua ")
        
        strSQL.Append(" FROM CLIDAGRO  ")

        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodfue = @ccodfue ")

        strSQL.Append(" group by devalua ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)

        Dim tables(0) As String
        tables(0) = New String("CLIDAGRO")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function
    Public Function ObtenerTotal(ByVal ccodcli As String, ByVal ccodfue As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select ctipo,  sum(ningreso) as ningreso, sum(ncosto) as ncosto , sum(nrendimiento) as nrendimiento ")
        strSQL.Append("from CLIDAGRO ")
        strSQL.Append("where ccodcli = @ccodcli and  ccodfue = @ccodfue  and devalua = @devalua ")
        strSQL.Append("group by ctipo  ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)
        args(2) = New SqlParameter("@devalua", dfecha)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
End Class
