Imports System.Text
Public Class dbAutopag
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As autopag
        Dim lID As Long
        lEntidad = aEntidad

        '       If lEntidad.ccodcli = "" _
        '                  Or lEntidad.cflat = Nothing Then

        '            lID = Me.ObtenerID(lEntidad)

        '           If lID = -1 Then Return -1

        '          lEntidad.cflat = lID

        '         Return Agregar(lEntidad)

        '        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE autopag ")
        strSQL.Append(" SET ccodcta = @ccodcta, ")
        strSQL.Append(" ccodcli = @ccodcli, ")
        strSQL.Append(" cnomcli = @cnomcli, ")
        strSQL.Append(" dfecpag = @dfecpag, ")
        strSQL.Append(" nmonto = @nmonto, ")
        strSQL.Append(" ccodofi = @ccodofi, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" cmotivo = @cmotivo, ")
        strSQL.Append(" cflat = @cflat ")

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcli
        args(2) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomcli
        args(3) = New SqlParameter("@dfecpag", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfecpag
        args(4) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmonto
        args(5) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodofi
        args(6) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(6).Value = lEntidad.cflag
        args(7) = New SqlParameter("@cmotivo", SqlDbType.VarChar)
        args(7).Value = lEntidad.cmotivo
        args(8) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflat

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As autopag
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO autopag ")
        strSQL.Append(" ( ccodcta, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" dfecpag, ")
        strSQL.Append(" nmonto, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cmotivo, ")
        strSQL.Append(" cflat) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ")
        strSQL.Append(" @ccodcli, ")
        strSQL.Append(" @cnomcli, ")
        strSQL.Append(" @dfecpag, ")
        strSQL.Append(" @nmonto, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @cmotivo, ")
        strSQL.Append(" @cflat) ")

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcli
        args(2) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomcli
        args(3) = New SqlParameter("@dfecpag", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfecpag
        args(4) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmonto
        args(5) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodofi
        args(6) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(6).Value = lEntidad.cflag
        args(7) = New SqlParameter("@cmotivo", SqlDbType.VarChar)
        args(7).Value = lEntidad.cmotivo
        args(8) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflat


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As autopag
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM autopag ")

        '        Dim args(-1) As SqlParameter

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As autopag
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        '        Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.dfecpag = IIf(.Item("dfecpag") Is DBNull.Value, Nothing, .Item("dfecpag"))
                lEntidad.nmonto = IIf(.Item("nmonto") Is DBNull.Value, Nothing, .Item("nmonto"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cmotivo = IIf(.Item("cmotivo") Is DBNull.Value, Nothing, .Item("cmotivo"))
                lEntidad.cflat = IIf(.Item("cflat") Is DBNull.Value, Nothing, .Item("cflat"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As autopag
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT case isnull(max()) when 1 then 1 else max() + 1 end ")
        strSQL.Append(" FROM autopag ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaautopag

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaautopag

        Try
            Do While dr.Read()
                Dim mEntidad As New autopag
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.dfecpag = IIf(dr("dfecpag") Is DBNull.Value, Nothing, dr("dfecpag"))
                mEntidad.nmonto = IIf(dr("nmonto") Is DBNull.Value, Nothing, dr("nmonto"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cmotivo = IIf(dr("cmotivo") Is DBNull.Value, Nothing, dr("cmotivo"))
                mEntidad.cflat = IIf(dr("cflat") Is DBNull.Value, Nothing, dr("cflat"))
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

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("autopag")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" dfecpag, ")
        strSQL.Append(" nmonto, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cmotivo, ")
        strSQL.Append(" cflat ")
        strSQL.Append(" FROM autopag ")

    End Sub

    Public Function obtenerpagosfecha(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodofi As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        Dim ds1 As New DataSet

        If lccodofi = "*" Then 'todas
            strSQL.Append("WHERE dfecpag >= @ldfecha1 ")
            strSQL.Append(" AND dfecpag <= @ldfecha2 ")

        Else
            strSQL.Append("WHERE dfecpag >= @ldfecha1 ")
            strSQL.Append(" AND dfecpag <= @ldfecha2 ")
            strSQL.Append(" AND ccodofi = @lccodofi ")
        End If


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ldfecha1", SqlDbType.DateTime)
        args(0).Value = ldfecha1
        args(1) = New SqlParameter("@ldfecha2", SqlDbType.DateTime)
        args(1).Value = ldfecha2
        args(2) = New SqlParameter("@lccodofi", SqlDbType.VarChar)
        args(2).Value = lccodofi


        ds1 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds1

    End Function
    Public Function RecibosATM(ByVal dfecha1 As Date, ByVal dfecha2 As Date) As DataSet
        Dim strSQL As New StringBuilder

        'SelectTablapagos(strSQL)
        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, MAX(A.cCodcli) as ccodcli, MAX(B.cnrolin) as cnrolin, B.ccodcta, B.nCapDes, ")
        strSQL.Append("B.dfecvig, B.dfecven, C.cnuming,C.cnumrec, C.dFecsis, C.Dfecpro,E.cnomusu,C.cnrodoc, max(B.ctipper) as ctipper,")
        strSQL.Append("MAX(b.ndiaapr) as ndiaapr,")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'NOTA DE ABONO' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(60) as cnomusu, space(60) as cnomofi, space(40) as cprograma,")
        strSQL.Append("00000000.00 as nsaldo,  00000000.00 as nsalant, space(80) as ccanlet, getdate() as dultpag, getdate() as dfecha,")
        strSQL.Append("000000.00 as nmoncuo,")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = 'SD' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'CO' OR C.CCONCEP = '05' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ' and C.CCONCEP <> 'IN' and C.CCONCEP <> 'MO' and C.CCONCEP <> '05'  THEN C.NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append("INNER JOIN (Credkar C INNER JOIN autopag D ON C.cCodcta = D.cCodcta and D.cmotivo='ok' and D.dfecpag = @DFECHA2) ON B.cCodcta = C.cCodcta ")
        strSQL.Append("INNER JOIN tabtusu E ON E.cCodusu = B.cCodana ")

        strSQL.Append("WHERE  C.CDESCOB = 'C' AND C.cestado = ' ' and left(C.cnumrec,3) = 'ATM' ")
        strSQL.Append("AND C.DFECpro >= @DFECHA1 AND C.DFECpro <= @DFECHA2 ")
        Dim transac As String
        strSQL.Append("GROUP BY B.cCodcta,  B.nCapDes, C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec, C.cTippag, C.cCodOfi, ")
        strSQL.Append("B.dFecvig, B.dfecven, E.cnomusu order by C.cnumrec ")
        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function
    Private Sub SelectTablapagos(ByRef strSQL As StringBuilder)

        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, MAX(A.cCodcli) as ccodcli, MAX(B.cnrolin) as cnrolin, B.ccodcta, B.nCapDes, ")
        strSQL.Append("B.dfecvig, B.dfecven, C.cnuming, C.dFecsis, C.Dfecpro,E.cnomusu,C.cnrodoc, max(B.ctipper) as ctipper,")
        strSQL.Append("MAX(b.ndiaapr) as ndiaapr,")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'NOTA DE ABONO' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(60) as cnomusu, space(60) as cnomofi, space(40) as cprograma,")
        strSQL.Append("00000000.00 as nsaldo,  00000000.00 as nsalant, space(80) as ccanlet, getdate() as dultpag, getdate() as dfecha,")
        strSQL.Append("000000.00 as nmoncuo,")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = 'SD' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'CO' OR C.CCONCEP = 'OP' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN C.NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN C.NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append("INNER JOIN (Credkar C INNER JOIN autopag D ON C.cCodcta = D.cCodcta and D.cmotivo='ok') ON B.cCodcta = C.cCodcta ")
        strSQL.Append("INNER JOIN tabtusu E ON E.cCodusu = B.cCodana ")

    End Sub
End Class
