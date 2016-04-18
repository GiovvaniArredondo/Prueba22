Imports System.Text
Public Class dbcentros
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As centros
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cCodsol =  "" _
            Or lEntidad.cCodsol = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cCodsol = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE centros ")
        strSQL.Append(" SET cnomgru = @cnomgru, ") 
        strSQL.Append(" cdirdom = @cdirdom, ")
        strSQL.Append(" cdiareu = @cdiareu, ") 
        strSQL.Append(" chora = @chora, ") 
        strSQL.Append(" ccodofi = @ccodofi, ") 
        strSQL.Append(" ccodins = @ccodins, ")
        strSQL.Append(" cfrecreu = @cfrecreu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" lactivo = @lactivo, ccodzon = @ccodzon ")
        strSQL.Append(" WHERE cCodsol = @cCodsol ") 

        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@cnomgru", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomgru
        args(1) = New SqlParameter("@cdirdom", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdirdom
        args(2) = New SqlParameter("@cdiareu", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdiareu
        args(3) = New SqlParameter("@chora", SqlDbType.VarChar)
        args(3).Value = lEntidad.chora
        args(4) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodofi
        args(5) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodins
        args(6) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(6).Value = lEntidad.dfecmod
        args(7) = New SqlParameter("@cfrecreu", SqlDbType.VarChar)
        args(7).Value = lEntidad.cfrecreu
        args(8) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.cCodsol = Nothing, DBNull.Value, lEntidad.cCodsol)
        args(9) = New SqlParameter("@lactivo", SqlDbType.Bit)
        args(9).Value = lEntidad.lactivo
        args(10) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(10).Value = lEntidad.cCodzon


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As centros
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO centros ")
        strSQL.Append(" ( cCodsol, ") 
        strSQL.Append(" cnomgru, ") 
        strSQL.Append(" cdirdom, ")
        strSQL.Append(" cdiareu, ") 
        strSQL.Append(" chora, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" ccodins, ")
        strSQL.Append(" cfrecreu, ")
        strSQL.Append(" dfecmod, lactivo, ccodzon) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cCodsol, ") 
        strSQL.Append(" @cnomgru, ") 
        strSQL.Append(" @cdirdom, ")
        strSQL.Append(" @cdiareu, ") 
        strSQL.Append(" @chora, ") 
        strSQL.Append(" @ccodofi, ") 
        strSQL.Append(" @ccodins, ")
        strSQL.Append(" @cfrecreu, ")
        strSQL.Append(" @dfecmod, @lactivo, @ccodzon) ")

        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cCodsol = Nothing, DBNull.Value, lEntidad.cCodsol)
        args(1) = New SqlParameter("@cnomgru", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomgru
        args(2) = New SqlParameter("@cdirdom", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdirdom
        args(3) = New SqlParameter("@cdiareu", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdiareu
        args(4) = New SqlParameter("@chora", SqlDbType.VarChar)
        args(4).Value = lEntidad.chora
        args(5) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodofi
        args(6) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodins
        args(7) = New SqlParameter("@cfrecreu", SqlDbType.VarChar)
        args(7).Value = lEntidad.cfrecreu
        args(8) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(8).Value = lEntidad.dfecmod
        args(9) = New SqlParameter("@lactivo", SqlDbType.Bit)
        args(9).Value = lEntidad.lactivo
        args(10) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(10).Value = lEntidad.cCodzon
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As centros
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM centros ")
        strSQL.Append(" WHERE cCodsol = @cCodsol ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = lEntidad.cCodsol

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As centros
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCodsol = @cCodsol ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = lEntidad.cCodsol

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomgru = IIf(.Item("cnomgru") Is DBNull.Value, Nothing, .Item("cnomgru"))
                lEntidad.dfecha = IIf(.Item("dfecha") Is DBNull.Value, Nothing, .Item("dfecha"))
                lEntidad.ccoddep = IIf(.Item("ccoddep") Is DBNull.Value, Nothing, .Item("ccoddep"))
                lEntidad.ccodmun = IIf(.Item("ccodmun") Is DBNull.Value, Nothing, .Item("ccodmun"))
                lEntidad.ccodcan = IIf(.Item("ccodcan") Is DBNull.Value, Nothing, .Item("ccodcan"))
                lEntidad.cdirdom = IIf(.Item("cdirdom") Is DBNull.Value, Nothing, .Item("cdirdom"))
                lEntidad.cdiareu = IIf(.Item("cdiareu") Is DBNull.Value, Nothing, .Item("cdiareu"))
                lEntidad.chora = IIf(.Item("chora") Is DBNull.Value, Nothing, .Item("chora"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.ccodins = IIf(.Item("ccodins") Is DBNull.Value, Nothing, .Item("ccodins"))
                lEntidad.cfrecreu = IIf(.Item("cfrecreu") Is DBNull.Value, Nothing, .Item("cfrecreu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.lactivo = IIf(.Item("lactivo") Is DBNull.Value, 0, .Item("lactivo"))
                lEntidad.cCodzon = IIf(.Item("ccodzon") Is DBNull.Value, 0, .Item("ccodzon"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As centros
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cCodsol),0) + 1 ")
        strSQL.Append(" FROM centros ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacentros

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listacentros

        Try
            Do While dr.Read()
                Dim mEntidad As New centros
                mEntidad.cCodsol = IIf(dr("cCodsol") Is DBNull.Value, Nothing, dr("cCodsol"))
                mEntidad.cnomgru = IIf(dr("cnomgru") Is DBNull.Value, Nothing, dr("cnomgru"))
                mEntidad.dfecha = IIf(dr("dfecha") Is DBNull.Value, Nothing, dr("dfecha"))
                mEntidad.ccoddep = IIf(dr("ccoddep") Is DBNull.Value, Nothing, dr("ccoddep"))
                mEntidad.ccodmun = IIf(dr("ccodmun") Is DBNull.Value, Nothing, dr("ccodmun"))
                mEntidad.ccodcan = IIf(dr("ccodcan") Is DBNull.Value, Nothing, dr("ccodcan"))
                mEntidad.cdirdom = IIf(dr("cdirdom") Is DBNull.Value, Nothing, dr("cdirdom"))
                mEntidad.cdiareu = IIf(dr("cdiareu") Is DBNull.Value, Nothing, dr("cdiareu"))
                mEntidad.chora = IIf(dr("chora") Is DBNull.Value, Nothing, dr("chora"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cfrecreu = IIf(dr("cfrecreu") Is DBNull.Value, Nothing, dr("cfrecreu"))
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
        tables(0) = New String("centros")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT cCodsol, ") 
        strSQL.Append(" cnomgru, ") 
        strSQL.Append(" dfecha, ") 
        strSQL.Append(" ccoddep, ") 
        strSQL.Append(" ccodmun, ") 
        strSQL.Append(" ccodcan, ") 
        strSQL.Append(" cdirdom, ") 
        strSQL.Append(" cdiareu, ") 
        strSQL.Append(" chora, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" ccodins, ") 
        strSQL.Append(" dfecmod, cfrecreu, lactivo, ccodzon ")
        strSQL.Append(" FROM centros ")

    End Sub

    Public Function ObtenerDataSetNivel2() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT centros.cCodsol As Codigo, centros.cnomgru FROM centros ")

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtenerDataSetNivel(ByVal ccodigo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodsol As Codigo, cNomgru ")
        strSQL.Append(" FROM centros ")
        strSQL.Append(" where cnomgru like" & "'" & "%" & ccodigo & "%" & "'")

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtenerNombre(ByVal cCodsol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT centros.cnomgru FROM centros WHERE cCodsol = @ccodsol")
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                lcnomgru = "NO EXISTE"
            Else
                lcnomgru = ds.Tables(0).Rows(0)("cnomgru")
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return lcnomgru
    End Function

    Public Function DataSetDoc1(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT centros.cCodsol, centros.cnomgru, centros.cdirdom, SUM(CREMCRE.nMonsug) as nMonsug, CRETLIN.nTasInt, ")
        strSQL.Append(" CREMCRE.dfecven, (DATEDIFF(day, cremcre.dfecvig, cremcre.dfecven))/7 as  Semanas, ")
        strSQL.Append(" CREMCRE.nCuoSug, CREMCRE.cTipper, CREMCRE.nDiasug, space(60) as cforma ")
        strSQL.Append(" FROM centros, CREMCRE, CRETLIN ")
        strSQL.Append(" WHERE CREMCRE.cCodsol = centros.cCodsol and CREMCRE.cNrolin = CRETLIN.cNrolin and centros.cCodsol = @ccodsol and ")
        strSQL.Append(" (CREMCRE.cEstado = 'C' ) ")
        strSQL.Append(" GROUP BY centros.cCodsol, CREMCRE.dfecVig, centros.cnomgru, centros.cdirdom, CRETLIN.nTasInt, ")
        strSQL.Append(" CREMCRE.dfecven,  CREMCRE.nCuoSug, CREMCRE.cTipper, CREMCRE.nDiasug ")
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function DataSetDoc2(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CREMCRE.cCodcta, CREMCRE.cCodcli, centros.cCodsol, centros.cnomgru, centros.cdirdom, CREMCRE.nMonApr,  ")
        strSQL.Append(" CREMCRE.dfecven, CLIMIDE.cnomcli, 000000.00 as  nDescuento, TABTUSU.cNomusu, CREMCRE.cCodAct,  ")
        strSQL.Append(" space(60) as cactividad , 000000.00 as npresant, space(60) as cdepto, space(60) as cmuni, ")
        strSQL.Append(" centros.cCodzon, 000 as nsocant, 000 nsocnue, 000 as nsocret, CREMCRE.dfecapr, CREMCRE.dfecvig ")
        strSQL.Append(" FROM centros, CREMCRE, CLIMIDE, TABTUSU ")
        strSQL.Append(" WHERE CREMCRE.cCodsol = centros.cCodsol and CREMCRE.ccodcli = CLIMIDE.ccodcli and ")
        strSQL.Append(" CREMCRE.cCodsol = @ccodsol and ")
        strSQL.Append(" CREMCRE.cEstado = 'E' and CREMCRE.cCodAna = TABTUSU.cCodusu ")
        'strSQL.Append(" GROUP BY CREMCRE.cCodcta, centros.cCodsol, centros.cnomgru,  CREMCRE.nmonapr, centros.cdirdom, CREMCRE.dfecven, CLIMIDE.cnomcli ")
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
   
End Class
