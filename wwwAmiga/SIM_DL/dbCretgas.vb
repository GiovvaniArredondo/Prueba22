Imports System.Text
Public Class dbCretgas
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretgas
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ctipgas =  "" _
            Or lEntidad.ctipgas = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ctipgas = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cretgas ")
        strSQL.Append(" SET ccodope = @ccodope, ") 
        strSQL.Append(" nmonpor = @nmonpor, ") 
        strSQL.Append(" cgasobl = @cgasobl, ") 
        strSQL.Append(" nincost = @nincost, ") 
        strSQL.Append(" lafeiva = @lafeiva, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" dfecmod = @dfecmod ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" cedad = @cedad, ") 
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@ccodope", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodope
        args(1) = New SqlParameter("@nmonpor", SqlDbType.VarChar)
        args(1).Value = lEntidad.nmonpor
        args(2) = New SqlParameter("@cgasobl", SqlDbType.VarChar)
        args(2).Value = lEntidad.cgasobl
        args(3) = New SqlParameter("@nincost", SqlDbType.VarChar)
        args(3).Value = lEntidad.nincost
        args(4) = New SqlParameter("@lafeiva", SqlDbType.Bit)
        args(4).Value = IIf(lEntidad.lafeiva = Nothing, DBNull.Value, lEntidad.lafeiva)
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(6).Value = lEntidad.dfecmod
        args(7) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(7).Value = lEntidad.cflag
        args(8) = New SqlParameter("@cedad", SqlDbType.VarChar)
        args(8).Value = lEntidad.cedad
        args(9) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.cnrolin = Nothing, DBNull.Value,lEntidad.cnrolin)
        args(10) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ctipgas = Nothing, DBNull.Value,lEntidad.ctipgas)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cretgas ")
        strSQL.Append(" ( cnrolin, ") 
        strSQL.Append(" ctipgas, ") 
        strSQL.Append(" ccodope, ") 
        strSQL.Append(" nmonpor, ") 
        strSQL.Append(" cgasobl, ") 
        strSQL.Append(" nincost, ") 
        strSQL.Append(" lafeiva, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ") 
        strSQL.Append(" cedad) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnrolin, ") 
        strSQL.Append(" @ctipgas, ") 
        strSQL.Append(" @ccodope, ") 
        strSQL.Append(" @nmonpor, ") 
        strSQL.Append(" @cgasobl, ") 
        strSQL.Append(" @nincost, ") 
        strSQL.Append(" @lafeiva, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @cedad) ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cnrolin = Nothing, DBNull.Value, lEntidad.cnrolin)
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ctipgas = Nothing, DBNull.Value, lEntidad.ctipgas)
        args(2) = New SqlParameter("@ccodope", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodope
        args(3) = New SqlParameter("@nmonpor", SqlDbType.Decimal)
        args(3).Value = lEntidad.nmonpor
        args(4) = New SqlParameter("@cgasobl", SqlDbType.VarChar)
        args(4).Value = lEntidad.cgasobl
        args(5) = New SqlParameter("@nincost", SqlDbType.Decimal)
        args(5).Value = lEntidad.nincost
        args(6) = New SqlParameter("@lafeiva", SqlDbType.Bit)
        args(6).Value = IIf(lEntidad.lafeiva = Nothing, DBNull.Value, lEntidad.lafeiva)
        args(7) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodusu
        args(8) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfecmod
        args(9) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(9).Value = lEntidad.cflag
        args(10) = New SqlParameter("@cedad", SqlDbType.VarChar)
        args(10).Value = lEntidad.cedad

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cretgas ")
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipgas

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cretgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND ccodope = @ccodope ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipgas
        args(2) = New SqlParameter("@ccodope", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodope


        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodope = IIf(.Item("ccodope") Is DBNull.Value, Nothing, .Item("ccodope"))
                lEntidad.nmonpor = IIf(.Item("nmonpor") Is DBNull.Value, Nothing, .Item("nmonpor"))
                lEntidad.cgasobl = IIf(.Item("cgasobl") Is DBNull.Value, Nothing, .Item("cgasobl"))
                lEntidad.nincost = IIf(.Item("nincost") Is DBNull.Value, Nothing, .Item("nincost"))
                lEntidad.lafeiva = IIf(.Item("lafeiva") Is DBNull.Value, Nothing, .Item("lafeiva"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cedad = IIf(.Item("cedad") Is DBNull.Value, Nothing, .Item("cedad"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cretgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ctipgas),0) + 1 ")
        strSQL.Append(" FROM cretgas ")
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(cnrolin As String) As listacretgas

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = cnrolin

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listacretgas

        Try
            Do While dr.Read()
                Dim mEntidad As New cretgas
                mEntidad.cnrolin = cnrolin
                mEntidad.ctipgas = IIf(dr("ctipgas") Is DBNull.Value, Nothing, dr("ctipgas"))
                mEntidad.ccodope = IIf(dr("ccodope") Is DBNull.Value, Nothing, dr("ccodope"))
                mEntidad.nmonpor = IIf(dr("nmonpor") Is DBNull.Value, Nothing, dr("nmonpor"))
                mEntidad.cgasobl = IIf(dr("cgasobl") Is DBNull.Value, Nothing, dr("cgasobl"))
                mEntidad.nincost = IIf(dr("nincost") Is DBNull.Value, Nothing, dr("nincost"))
                mEntidad.lafeiva = IIf(dr("lafeiva") Is DBNull.Value, Nothing, dr("lafeiva"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cedad = IIf(dr("cedad") Is DBNull.Value, Nothing, dr("cedad"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(cnrolin As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", cnrolin)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(cnrolin As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", cnrolin)

        Dim tables(0) As String
        tables(0) = New String("cretgas")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT cnrolin, ") 
        strSQL.Append(" ctipgas, ") 
        strSQL.Append(" ccodope, ") 
        strSQL.Append(" nmonpor, ") 
        strSQL.Append(" cgasobl, ") 
        strSQL.Append(" nincost, ") 
        strSQL.Append(" lafeiva, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" cedad ") 
        strSQL.Append(" FROM cretgas ")

    End Sub

    Public Function Obtenerdatasetgastos(ByVal cnrolin As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cretgas.ctipgas as codigo,cretgas.cnrolin,cretgas.ccodope, tabttab.cdescri as gastos, '                                                ' as cuota, cretgas.nmonpor as monto, cretgas.nmonpor as porcen, '                             ' as afecta ")
        strSQL.Append(" FROM cretlin, cretgas, tabttab")
        strSQL.Append(" WHERE cretlin.cnrolin = cretgas.cnrolin and tabttab.ccodtab ='008' and tabttab.ctipreg ='1' and rtrim(tabttab.ccodigo) = rtrim(cretgas.ctipgas) ")
        strSQL.Append(" and cretlin.cnrolin = @cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", cnrolin)


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtienevalordeGasto(ByVal cnrolin As String, ByVal ctipgas As String, ByVal ccodope As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT nmonpor FROM CRETGAS ")
        strSQL.Append("WHERE cnrolin = @cnrolin and ctipgas = @ctipgas and ccodope = @ccodope ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", cnrolin)
        args(1) = New SqlParameter("@ctipgas", ctipgas)
        args(2) = New SqlParameter("@ccodope", ccodope)

        Dim ds As New DataSet
        Dim lnmonpor As Decimal = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonpor")) Then
            Else
                lnmonpor = ds.Tables(0).Rows(0)("nmonpor")
            End If
        End If

        Return lnmonpor


    End Function
End Class
