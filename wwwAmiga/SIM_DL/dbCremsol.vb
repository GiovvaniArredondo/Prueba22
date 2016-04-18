Imports System.Text
Public Class dbCremsol
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremsol
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
        strSQL.Append("UPDATE cremsol ")
        strSQL.Append(" SET cnomgru = @cnomgru, ") 
        strSQL.Append(" cdirdom = @cdirdom, ")
        strSQL.Append(" cdiareu = @cdiareu, ") 
        strSQL.Append(" chora = @chora, ") 
        strSQL.Append(" ccodofi = @ccodofi, ") 
        strSQL.Append(" ccodins = @ccodins, ")
        strSQL.Append(" cfrecreu = @cfrecreu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" lactivo = @lactivo, ccodzon = @ccodzon, ccodcen = @ccodcen, ccodcli = @ccodcli ")
        strSQL.Append(" WHERE cCodsol = @cCodsol ") 

        Dim args(12) As SqlParameter
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
        args(11) = New SqlParameter("@ccodcen", SqlDbType.VarChar)
        args(11).Value = lEntidad.cCodcen
        args(12) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(12).Value = lEntidad.cCodcli


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremsol
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cremsol ")
        strSQL.Append(" ( cCodsol, ") 
        strSQL.Append(" cnomgru, ") 
        strSQL.Append(" cdirdom, ")
        strSQL.Append(" cdiareu, ") 
        strSQL.Append(" chora, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" ccodins, ")
        strSQL.Append(" cfrecreu, ")
        strSQL.Append(" dfecmod, lactivo, ccodzon, ccodcen, cCodcli) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cCodsol, ") 
        strSQL.Append(" @cnomgru, ") 
        strSQL.Append(" @cdirdom, ")
        strSQL.Append(" @cdiareu, ") 
        strSQL.Append(" @chora, ") 
        strSQL.Append(" @ccodofi, ") 
        strSQL.Append(" @ccodins, ")
        strSQL.Append(" @cfrecreu, ")
        strSQL.Append(" @dfecmod, @lactivo, @ccodzon, @ccodcen, @cCodcli) ")

        Dim args(13) As SqlParameter
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
        args(11) = New SqlParameter("@ccodcen", SqlDbType.VarChar)
        args(11).Value = lEntidad.cCodcen
        args(12) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(12).Value = lEntidad.cCodcli



        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremsol
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cremsol ")
        strSQL.Append(" WHERE cCodsol = @cCodsol ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = lEntidad.cCodsol

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremsol
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
                lEntidad.cdirdom = IIf(.Item("cdirdom") Is DBNull.Value, "", .Item("cdirdom"))
                lEntidad.cdiareu = IIf(.Item("cdiareu") Is DBNull.Value, "", .Item("cdiareu"))
                lEntidad.chora = IIf(.Item("chora") Is DBNull.Value, "", .Item("chora"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.ccodins = IIf(.Item("ccodins") Is DBNull.Value, Nothing, .Item("ccodins"))
                lEntidad.cfrecreu = IIf(.Item("cfrecreu") Is DBNull.Value, "", .Item("cfrecreu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.lactivo = IIf(.Item("lactivo") Is DBNull.Value, 0, .Item("lactivo"))
                lEntidad.cCodzon = IIf(.Item("ccodzon") Is DBNull.Value, Nothing, .Item("ccodzon"))
                lEntidad.cCodcen = IIf(.Item("ccodcen") Is DBNull.Value, Nothing, .Item("ccodcen"))
                lEntidad.cCodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cremsol
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cCodsol),0) + 1 ")
        strSQL.Append(" FROM cremsol ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacremsol

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listacremsol

        Try
            Do While dr.Read()
                Dim mEntidad As New cremsol
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
        tables(0) = New String("cremsol")

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
        strSQL.Append(" dfecmod, cfrecreu, lactivo, ccodzon, ccodcen, ccodcli ")
        strSQL.Append(" FROM cremsol ")

    End Sub

    Public Function ObtenerDataSetNivel2() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT Cremsol.cCodsol As Codigo, CREMSOL.cnomgru FROM CREMSOL ")

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function ObtenerDataSetCentros() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT Centros.cCodsol As Codigo, Centros.cnomgru FROM CENTROS ")

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtenerDataSetNivelGru(ByVal ccodigo As String, ByVal ccodcen As String, ByVal ctipmet As String, ByVal cCodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodsol As Codigo, cNomgru ")
        strSQL.Append(" FROM cremsol ")
        strSQL.Append(" where cnomgru like" & "'" & "%" & ccodigo & "%" & "'")
        If ctipmet = "03" Then
            strSQL.Append(" and (substring(cCodsol, 7,2) <> '02'  )")
        Else
            strSQL.Append(" and substring(cCodsol, 7,2) = @ctipmet  ")
        End If


        If cCodofi = "001" Then
        Else
            strSQL.Append(" and cremsol.ccodofi = @cCodofi ")
        End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi
        args(1) = New SqlParameter("@ctipmet", SqlDbType.VarChar)
        args(1).Value = ctipmet


        Dim a As String
        a = strSQL.ToString()

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtenerNombre(ByVal cCodsol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CREMSOL.cnomgru FROM CREMSOL WHERE cCodsol = @ccodsol")
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                lcnomgru = ""
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
        strSQL.Append("SELECT CREMSOL.cCodsol, CREMSOL.cnomgru, CREMSOL.cdirdom, SUM(CREMCRE.nMonsug) as nMonsug, CRETLIN.nTasInt, ")
        strSQL.Append(" CREMCRE.dfecven, (DATEDIFF(day, cremcre.dfecvig, cremcre.dfecven))/7 as  Semanas, ")
        strSQL.Append(" CREMCRE.nCuoSug, CREMCRE.cTipper, CREMCRE.nDiasug, space(60) as cforma, CENTROS.cnomgru as cnomcen ")
        strSQL.Append(" FROM CREMSOL, CREMCRE, CRETLIN, CENTROS ")
        strSQL.Append(" WHERE CREMCRE.cCodsol = CREMSOL.cCodsol and CREMCRE.cNrolin = CRETLIN.cNrolin and CREMSOL.cCodsol = @ccodsol and ")
        strSQL.Append(" (CREMCRE.cEstado = 'C' ) and CREMSOL.cCodcen = CENTROS.cCodsol ")
        strSQL.Append(" GROUP BY CREMSOl.cCodsol, CREMCRE.dfecVig, CREMSOL.cnomgru, CREMSOL.cdirdom, CRETLIN.nTasInt, ")
        strSQL.Append(" CREMCRE.dfecven,  CREMCRE.nCuoSug, CREMCRE.cTipper, CREMCRE.nDiasug, centros.cnomgru ")
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
        strSQL.Append("SELECT CREMCRE.cCodcta, CREMCRE.cCodcli, CREMSOL.cCodsol, CREMSOL.cnomgru, CREMSOL.cdirdom, CREMCRE.nMonApr,  ")
        strSQL.Append(" CREMCRE.dfecven, CLIMIDE.cnomcli, 000000.00 as  nDescuento, TABTUSU.cNomusu, CREMCRE.cCodAct,   ")
        strSQL.Append(" space(60) as cactividad , 000000.00 as npresant, space(60) as cdepto, space(60) as cmuni, ")
        strSQL.Append(" CREMSOL.cCodzon, 000 as nsocant, 000 nsocnue, 000 as nsocret, CREMCRE.dfecapr, CREMCRE.dfecvig, ")
        strSQL.Append(" space(60) as cpresidenta, space(60) as cfuente, CREMCRE.cNrolin, CENTROS.cNomgru as cnomcen ")
        strSQL.Append(" FROM CREMSOL, CREMCRE, CLIMIDE, TABTUSU, CENTROS ")
        strSQL.Append(" WHERE CREMCRE.cCodsol = CREMSOL.cCodsol and CREMCRE.ccodcli = CLIMIDE.ccodcli and ")
        strSQL.Append(" CREMCRE.cCodsol = @ccodsol and ")
        strSQL.Append(" CREMCRE.cEstado = 'E' and CREMCRE.cCodAna = TABTUSU.cCodusu ")
        strSQL.Append(" and CREMSOL.cCodcen = CENTROS.cCodsol ")
        'strSQL.Append(" GROUP BY CREMCRE.cCodcta, CREMSOl.cCodsol, CREMSOL.cnomgru,  CREMCRE.nmonapr, CREMSOL.cdirdom, CREMCRE.dfecven, CLIMIDE.cnomcli ")
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

    Public Function DataSetCentros(ByVal cCodcen As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CREMSOL.cCodsol, CREMSOL.cNomgru, CENTROS.cnomgru as cnomcen  ")
        strSQL.Append(" FROM CENTROS, CREMSOL ")
        strSQL.Append(" WHERE CREMSOL.ccodcen = CENTROS.ccodsol and CREMSOL.cCodcen =  @ccodcen  ")
        
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcen", SqlDbType.VarChar)
        args(0).Value = cCodcen


        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function DataSetDoclegal(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CLIMIDE.cNomcli, CLIMIDE.cCodpro, CREMSOL.ccodzon, CREMCRE.nmonapr, CREMCRE.cNrolin, ")
        strSQL.Append("(DATEDIFF(day, cremcre.dfecvig, cremcre.dfecven))/7 as  Semanas, CREMCRE.dfecven, ")
        strSQL.Append(" CREMCRE.ncuoapr, CREMCRE.ndiasug, CREMCRE.ctipper, CLIMIDE.cfirma, CREMCRE.dfecvig, ")
        strSQL.Append(" CLIMIDE.dnacimi, CLIMIDE.cNudoci, cremsol.cdiareu ")
        strSQL.Append(" FROM CREMSOL, CREMCRE, CLIMIDE ")
        strSQL.Append(" WHERE CREMCRE.cCodsol = CREMSOL.cCodsol and CREMCRE.ccodcli = CLIMIDE.ccodcli and ")
        strSQL.Append(" CREMCRE.cCodsol = @ccodsol and ")
        strSQL.Append(" CREMCRE.cEstado = 'E'  ")
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
    Public Function ObtenerNombreCentro(ByVal cCodsol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CENTROS.cnomgru FROM CENTROS WHERE cCodsol = @ccodsol")
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

    Public Function ObtenerNombreCentro2(ByVal cCodsol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CENTROS.cnomgru FROM CENTROS, CREMSOL WHERE cremsol.ccodcen =centros.ccodsol and cremsol.cCodsol = @ccodsol")
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                lcnomgru = ""
            Else
                lcnomgru = ds.Tables(0).Rows(0)("cnomgru")
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return lcnomgru
    End Function
    Public Function ReciboGrupal(ByVal ccodsol As String) As DataSet
        Dim strsql As New StringBuilder
        strsql.Append(" select  cremsol.ccodsol,  cremsol.cnomgru , space(4) as cnrodoc, space(18) as cnuming, space(18) as cnumrec ")
        strsql.Append(" from cremsol where cremsol.ccodsol = @ccodsol ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds

    End Function

    Public Function ReciboGrupal2(ByVal ccodsol As String) As DataSet
        Dim strsql As New StringBuilder
        strsql.Append(" select  centros.ccodsol,  centros.cnomgru , space(4) as cnrodoc, space(10) as cnuming ")
        strsql.Append(" from centros where  centros.ccodsol = @ccodsol ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds

    End Function

    Public Function ReseteaBancoComunal(ByVal ccodsol As String) As Integer
        Dim strsql As New StringBuilder
        strsql.Append(" UPDATE CLIMIDE SET cCodsol = '', lactivo = '0' Where cCodsol = @cCodsol ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strsql.ToString(), args)


    End Function
    Public Function ActualizaMiembro(ByVal ccodcli As String, ByVal ccodsol As String) As Integer
        Dim strsql As New StringBuilder
        strsql.Append(" UPDATE CLIMIDE SET cCodsol = @cCodsol, lactivo = '1'  Where cCodcli = @cCodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = ccodcli


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strsql.ToString(), args)


    End Function

    Public Function ListaMiembros(ByVal cCodsol As String) As DataSet
        Dim strsql As New StringBuilder
        strsql.Append(" Select cCodcli, cnudoci, cnomcli, dnacimi as dfecnac from climide where cCodsol = @cCodsol order by cnomcli")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As New DataSet


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function

    Public Function ObtenerDataSetNivelTodos(ByVal ccodigo As String, ByVal cCodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodsol As Codigo, cNomgru ")
        strSQL.Append(" FROM cremsol ")
        strSQL.Append(" where cnomgru like" & "'" & "%" & ccodigo & "%" & "'")

        'If cCodofi = "001" Then
        'Else
        '    strSQL.Append(" and ccodofi = @cCodofi ")
        'End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi


        Dim a As String
        a = strSQL.ToString()

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function ObtenerDireccion(ByVal cCodsol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT CREMSOL.cdirdom FROM CREMSOL WHERE cCodsol = @ccodsol")
        Dim lcnomgru As String

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol


        Dim ds As New DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                lcnomgru = ""
            Else
                lcnomgru = ds.Tables(0).Rows(0)("cdirdom")
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return lcnomgru
    End Function

    Public Function VerificaDuplicidad(ByVal cCodcli As String, ByVal cCodsol As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodSol FROM CLIMIDE WHERE cCodcli =@cCodcli ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodsol")) Then
                Return True
            Else
                Dim lccodsol As String
                lccodsol = ds.Tables(0).Rows(0)("cCodsol")
                If lccodsol.Trim.Length > 0 Then
                    If lccodsol.Trim = cCodsol.Trim Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
                

            End If
        End If

    End Function

    Public Function VerificaDuplicidad2(ByVal cCodcli As String, ByVal cCodsol As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodSol FROM CREMCRE WHERE cCodcli =@cCodcli WHERE cEstado <> 'G' GROUP BY cCodsol ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodsol")) Then
                Return True
            Else
                Dim lccodsol As String
                Dim fila As DataRow
                Dim i As Integer = 0
                For Each fila In ds.Tables(0).Rows
                    lccodsol = ds.Tables(0).Rows(i)("cCodsol")
                    If lccodsol.Trim = cCodsol.Trim Then

                    Else
                        Return False
                    End If
                    i += 1
                Next
                Return True

            End If
        End If

    End Function

    Public Function ObtieneCodigoxNombre(ByVal cCodsol As String, ByVal Nombre As String, ByVal cCodofi As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodsol, cCodofi from CREMSOL ")
        strSQL.Append(" WHERE cnomgru = @Nombre")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@Nombre", SqlDbType.VarChar)
        args(0).Value = Nombre

        Dim lvalida As Boolean

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodsol As String = ""
        Dim lccodofi As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
            lvalida = True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodsol")) Then
                lvalida = True
            Else
                lccodsol = ds.Tables(0).Rows(0)("cCodsol")
                lccodofi = ds.Tables(0).Rows(0)("cCodofi")
                If cCodsol <> lccodsol And cCodofi = lccodofi Then
                    lvalida = False
                Else
                    lvalida = True
                End If
            End If
        End If


        Return lvalida
    End Function

    Public Function ObtenerCicloGrupo(ByVal ccodsol As String, ByVal dfecha As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT dfecvig from CREMCRE ")
        strSQL.Append(" WHERE ccodsol = @ccodsol GROUP BY dfecvig order by dfecvig ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnciclo As Integer = 1
        Dim ldfecha As Date

        For Each fila In ds.Tables(0).Rows
            ldfecha = ds.Tables(0).Rows(i)("dfecvig")
            If ldfecha >= dfecha And ldfecha <= dfecha Then 'es el ciclo
                lnciclo = i + 1
            End If
            i += 1
        Next

        Return lnciclo
    End Function
    Public Function VerificaGrupoActivo(ByVal cCodsol As String, ByVal cCodofi As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodsol, cCodofi from CREMSOL ")
        strSQL.Append(" WHERE ccodsol = @ccodsol and lactivo ='1' ")
        If cCodofi = "001" Then
        Else
            '    strSQL.Append(" and substring(ccodsol,4,3) = @ccodofi ")
        End If

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = cCodofi

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function



    Public Function Datos_Miembros_Grupo(ByVal pcCodsol As String) As DataSet

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim _sql As String = ""
        Dim lcprofe As String
        Dim etabtprf As New SIM.DL.dbTabtprf

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection


                _sql = _
                        " Select a.*, b.ccodcta, c.cnomgru from climide a" & _
                        " Inner Join cremcre b " & _
                        " On a.ccodcli = b.ccodcli " & _
                        " Inner join cremsol c " & _
                        " On b.ccodsol = c.cCodsol " & _
                        " Where b.ccodsol = '" & pcCodsol & "' AND b.cestado = 'F'" & _
                        " Order by a.cnomcli "

                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Miembros_Grupos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds

    End Function


    Public Function Datos_Miembros_Contrato(ByVal pcCodsol As String, ByVal pcCodcli As String) As DataSet

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim _sql As String = ""
        Dim lcprofe As String
        Dim etabtprf As New SIM.DL.dbTabtprf

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection


                _sql = _
                        " Select a.*, b.ccodcta, c.cnomgru from climide a" & _
                        " Inner Join cremcre b " & _
                        " On a.ccodcli = b.ccodcli " & _
                        " Inner join cremsol c " & _
                        " On b.ccodsol = c.cCodsol " & _
                        " Where b.ccodsol = '" & pcCodsol & "'" & _
                        " and a.ccodcli > '" & pcCodcli & "'" & _
                        " Order by a.ccodcli asc "

                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Miembros_Grupos")


                If ds.Tables("Miembros_Grupos").Rows.Count = 0 Then

                    ds.Tables.Clear()

                    _sql = _
                            " Select a.*, b.ccodcta, c.cnomgru from climide a" & _
                            " Inner Join cremcre b " & _
                            " On a.ccodcli = b.ccodcli " & _
                            " Inner join cremsol c " & _
                            " On b.ccodsol = c.cCodsol " & _
                            " Where b.ccodsol = '" & pcCodsol & "'" & _
                            " Order by a.ccodcli asc "

                    command.CommandText = _sql

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds, "Miembros_Grupos")

                End If

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds

    End Function
End Class
