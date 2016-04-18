Imports System.Text
Public Class dbCredtpl
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credtpl
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnrocuo = "" _
            Or lEntidad.cnrocuo = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnrocuo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credtpl ")
        strSQL.Append(" SET dfecven = @dfecven, ")
        strSQL.Append(" ncapita = @ncapita, ")
        strSQL.Append(" nintere = @nintere, ")
        strSQL.Append(" nGastos = @ngastos, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" ccodusu = @ccodusu ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipope = @ctipope ")
        strSQL.Append(" AND cnrocuo = @cnrocuo ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecven
        args(1) = New SqlParameter("@ncapita", SqlDbType.Decimal)
        args(1).Value = lEntidad.ncapita
        args(2) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(2).Value = lEntidad.nintere
        args(3) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(3).Value = lEntidad.ngastos
        args(4) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(4).Value = lEntidad.ntasint
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(6).Value = lEntidad.dfecmod
        args(7) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(7).Value = lEntidad.cflag
        args(8) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(9) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.ctipope = Nothing, DBNull.Value, lEntidad.ctipope)
        args(10) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value, lEntidad.cnrocuo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credtpl
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO credtpl ")
        strSQL.Append(" ( ccodcta, ")
        strSQL.Append(" dfecven, ")
        strSQL.Append(" lefectu, ")
        strSQL.Append(" ctipope, ")
        strSQL.Append(" cnrocuo, ")
        strSQL.Append(" ncapita, ")
        strSQL.Append(" nintere, ")
        strSQL.Append(" ngastos, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" nsegdeu, ")
        strSQL.Append(" cflag ) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ")
        strSQL.Append(" @dfecven, ")
        strSQL.Append(" @lefectu, ")
        strSQL.Append(" @ctipope, ")
        strSQL.Append(" @cnrocuo, ")
        strSQL.Append(" @ncapita, ")
        strSQL.Append(" @nintere, ")
        strSQL.Append(" @ngastos, ")
        strSQL.Append(" @ntasint, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @nsegdeu, ")
        strSQL.Append(" @cflag ) ")

        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecven
        args(2) = New SqlParameter("@lefectu", SqlDbType.Bit)
        args(2).Value = lEntidad.lefectu
        args(3) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ctipope = Nothing, DBNull.Value, lEntidad.ctipope)
        args(4) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value, lEntidad.cnrocuo)
        args(5) = New SqlParameter("@ncapita", SqlDbType.Decimal)
        args(5).Value = lEntidad.ncapita
        args(6) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(6).Value = lEntidad.nintere
        args(7) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(7).Value = lEntidad.ngastos
        args(8) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(8).Value = lEntidad.ntasint
        args(9) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodusu
        args(10) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@nsegdeu", SqlDbType.Decimal)
        args(11).Value = lEntidad.nSegDeu
        args(12) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(12).Value = lEntidad.cflag

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credtpl
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credtpl ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        ' strSQL.Append(" AND ctipope = @ctipope ") 
        'strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        'args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        'args(1).Value = lEntidad.ctipope
        'args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        'args(2).Value = lEntidad.cnrocuo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credtpl
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipope = @ctipope ")
        strSQL.Append(" AND cnrocuo = @cnrocuo ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipope
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.dfecven = IIf(.Item("dfecven") Is DBNull.Value, Nothing, .Item("dfecven"))
                lEntidad.ncapita = IIf(.Item("ncapita") Is DBNull.Value, Nothing, .Item("ncapita"))
                lEntidad.nintere = IIf(.Item("nintere") Is DBNull.Value, Nothing, .Item("nintere"))
                lEntidad.nintere = IIf(.Item("ngastos") Is DBNull.Value, Nothing, .Item("ngastos"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As credtpl
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnrocuo),0) + 1 ")
        strSQL.Append(" FROM credtpl ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipope = @ctipope ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipope

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ByVal ccodcta As String, ByVal ctipope As String) As listacredtpl

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipope = @ctipope ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ctipope", SqlDbType.VarChar)
        args(1).Value = ctipope

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacredtpl

        Try
            Do While dr.Read()
                Dim mEntidad As New credtpl
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.ctipope = ctipope
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.ncapita = IIf(dr("ncapita") Is DBNull.Value, Nothing, dr("ncapita"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
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

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta order by dfecven ")
        '        strSQL.Append(" AND ctipope = @ctipope ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        '       args(1) = New SqlParameter("@ctipope", ctipope)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String, ByVal ctipope As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipope = @ctipope ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipope", ctipope)

        Dim tables(0) As String
        tables(0) = New String("credtpl")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" dfecven, ")
        strSQL.Append(" ctipope, ")
        strSQL.Append(" cnrocuo, ")
        strSQL.Append(" ncapita, ")
        strSQL.Append(" nintere, ")
        strSQL.Append(" ngastos, ")
        strSQL.Append(" nsegdeu, ")
        strSQL.Append(" round(ntasint/12,2) as ntasint, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" 000000.00 as saldo, 000000.00 as salint, (ncapita + nintere + ngastos + nsegdeu) as nmoncuo, space(60) as cnomcli, space(20) as cnudoci ")
        strSQL.Append(" FROM credtpl ")

    End Sub

    Public Function ObtenerListaPorID2(ByVal ccodcta As String) As listacredtpl

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacredtpl

        Try
            Do While dr.Read()
                Dim mEntidad As New credtpl
                mEntidad.ccodcta = ccodcta
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.ctipope = IIf(dr("ctipope") Is DBNull.Value, Nothing, dr("ctipope"))
                mEntidad.cnrocuo = IIf(dr("cnrocuo") Is DBNull.Value, Nothing, dr("cnrocuo"))
                mEntidad.ncapita = IIf(dr("ncapita") Is DBNull.Value, Nothing, dr("ncapita"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.nintere = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
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
    Public Function Obtenerprimeracuota(ByVal ccodcta As String) As Date

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and cNrocuo = '001' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim dprifec As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            dprifec = Today.AddDays(1)
        Else
            dprifec = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return dprifec

    End Function
    Public Function CapitalInteres(ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT nCapita, nIntere, ngastos ")
        strSQL.Append(" FROM credtpl ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' and cNrocuo = '001' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lnCapInt As Double
        Dim lncapita As Double
        Dim lnintere As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnintere = ds.Tables(0).Rows(0)("nIntere") + ds.Tables(0).Rows(0)("ngastos")
            lnCapInt = lncapita + lnintere
        End If
        Return lnCapInt
    End Function


    Public Function Monto_Total_CapitalInteres(ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(nCapita) as ncapita, sum(nIntere) as nIntere ")
        strSQL.Append(" FROM credtpl ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope = 'N' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lnCapInt As Double
        Dim lncapita As Double
        Dim lnintere As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnintere = ds.Tables(0).Rows(0)("nIntere")
            lnCapInt = lncapita + lnintere
        End If
        Return lnCapInt
    End Function


    Public Function CapitalInteresGrupal(ByVal ccodsol As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT sum(credtpl.nCapita)as ncapita, sum(credtpl.nIntere) as nintere ")
        strSQL.Append(" FROM credtpl, cremcre ")
        strSQL.Append(" WHERE cremcre.ccodsol =@ccodsol and cremcre.ccodcta = credtpl.ccodcta ")
        strSQL.Append(" AND credtpl.cTipope = 'N' and credtpl.cNrocuo = '001' and (cremcre.cestado = 'C' or cremcre.cestado = 'E' ) ")
        strSQL.Append(" group by cremcre.ccodsol, cremcre.dfecven")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", ccodsol)

        Dim ds As New DataSet
        Dim lnCapInt As Double
        Dim lncapita As Double
        Dim lnintere As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCapInt = 0
        Else
            lncapita = ds.Tables(0).Rows(0)("nCapita")
            lnintere = ds.Tables(0).Rows(0)("nIntere")
            lnCapInt = lncapita + lnintere
        End If
        Return lnCapInt
    End Function

    Public Function CuoAhorro(ByVal nmonto As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" select nAhorro from cuotaaho where nmonto >= @nmonto order by nmonto ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nmonto", nmonto)

        Dim ds As New DataSet
        Dim lnCuoAhorro As Double
       

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lnCuoAhorro = 0
        Else
            lnCuoAhorro = ds.Tables(0).Rows(0)("nAhorro")
        End If
        Return lnCuoAhorro
    End Function

    Public Function PlanGrupalTeorico(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        If cCodsol = Nothing Then
            Exit Function
        End If
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT credtpl.dfecven, credtpl.ctipope, credtpl.cnrocuo,")
        strSQL.Append(" round(credtpl.ntasint/12,2) as ntasint, ")
        strSQL.Append("  sum(credtpl.ncapita) as ncapita, ")
        strSQL.Append(" sum(credtpl.nintere) as nintere, ")
        strSQL.Append(" sum(credtpl.ngastos) as ngastos, ")
        strSQL.Append(" sum(credtpl.nsegdeu) as nsegdeu, ")
        strSQL.Append(" 000000.00 as saldo, 000000.00 as salint, ")
        strSQL.Append(" sum((credtpl.ncapita+credtpl.nintere+(case when credtpl.ngastos is null then 0 else credtpl.ngastos end ) + (case when credtpl.nsegdeu is null then 0 else credtpl.nsegdeu end ))) as nmoncuo ")
        strSQL.Append(" FROM credtpl, cremcre ")
        strSQL.Append(" WHERE cremcre.ccodcta = credtpl.ccodcta and cremcre.ccodsol = @cCodsol and cremcre.dfecvig >=@dfecha and cremcre.dfecvig <= @dfecha ")
        strSQL.Append(" GROUP BY cremcre.cCodsol, cremcre.dfecvig, credtpl.dfecven, credtpl.ctipope, credtpl.cnrocuo,")
        strSQL.Append(" credtpl.ntasint ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", cCodsol)
        args(1) = New SqlParameter("@dfecha", dfecha)
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function CargarAditivos(ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder

        strSQL.Append("Select ngastos ")
        strSQL.Append("FROM CREDTPL WHERE ctipope ='N' and cnrocuo ='001'  ")
        strSQL.Append("and ccodcta = @ccodcta ")

        Dim ds As New DataSet
        Dim lngasto As Double = 0

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else

            If IsDBNull(ds.Tables(0).Rows(0)("ngastos")) Then
            Else
                lngasto = ds.Tables(0).Rows(0)("ngastos")

            End If

        End If
        Return lngasto
    End Function
    Public Function PlanesdePagosGrupos(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT climide.cnomcli, credtpl.ccodcta, credtpl.dfecven, credtpl.ctipope, credtpl.cnrocuo,")
        strSQL.Append(" round(credtpl.ntasint/12,2) as ntasint, ")
        strSQL.Append(" credtpl.ncapita, ")
        strSQL.Append(" credtpl.nintere, ")
        strSQL.Append(" credtpl.ngastos, ")
        strSQL.Append(" credtpl.nsegdeu, ")
        strSQL.Append(" 000000.00 as saldo, 000000.00 as salint, ")
        strSQL.Append(" cretlin.cdeslin, tabtofi.cnomofi, tabtusu.cnomusu as cnomana ")
        strSQL.Append(" FROM credtpl, cremcre, climide, cretlin, tabtofi, tabtusu ")
        strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.ccodcta = credtpl.ccodcta and cremcre.ccodsol = @cCodsol and ")
        strSQL.Append(" cremcre.dfecvig >=@dfecha and cremcre.dfecvig <= @dfecha  ")
        strSQL.Append(" and cremcre.cnrolin = cretlin.cnrolin and cremcre.coficina = tabtofi.ccodofi and cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" order by credtpl.ccodcta, credtpl.dfecven ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", cCodsol)
        args(1) = New SqlParameter("@dfecha", dfecha)
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function ObtenerUltimacuota(ByVal ccodcta As String) As Date

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT dfecven from CREDTPL ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cTipope <> 'D'  order by dfecven desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim dprifec As Date

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            dprifec = Today.AddDays(1)
        Else
            dprifec = ds.Tables(0).Rows(0)("dfecven")
        End If
        Return dprifec

    End Function
    Public Function ObtieneNumeroCuotas(ByVal ccodcta As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT  count(ccodcta) as ncuotas ")
        strSQL.Append("FROM CREDTPL ")
        strSQL.Append("WHERE ccodcta = @ccodcta and ctipope <> 'D' group by ccodcta ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As New DataSet
        Dim lncuotas As Integer = 1

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lncuotas = IIf(IsDBNull(ds.Tables(0).Rows(0)("ncuotas")), 1, ds.Tables(0).Rows(0)("ncuotas"))
        End If
        Return lncuotas

    End Function
End Class
