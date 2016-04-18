Imports System.Text
Public Class dbClidfin
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidfin
        Dim lID As Long
        lEntidad = aEntidad

        'If lEntidad.ccodfue =  "" _
        '    Or lEntidad.ccodfue = Nothing Then 

        '    lID = Me.ObtenerID(lEntidad)

        '    If lID = -1 Then Return -1

        '    'lEntidad.ccodfue = lID

        '    Return Agregar(lEntidad)

        'End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE clidfin ")
        strSQL.Append(" SET cnomfue = @cnomfue, ") 
        strSQL.Append(" ctidofu = @ctidofu, ") 
        strSQL.Append(" cnudofu = @cnudofu, ") 
        strSQL.Append(" dinifue = @dinifue, ") 
        strSQL.Append(" nemplea = @nemplea, ") 
        strSQL.Append(" cubifue = @cubifue, ") 
        strSQL.Append(" cdirfue = @cdirfue, ") 
        strSQL.Append(" ctelfue = @ctelfue, ") 
        strSQL.Append(" cconfue = @cconfue, ") 
        strSQL.Append(" csececo = @csececo, ") 
        strSQL.Append(" ccodact = @ccodact, ") 
        strSQL.Append(" canoubi = @canoubi, ") 
        strSQL.Append(" nfahope = @nfahope, ") 
        strSQL.Append(" nfahote = @nfahote, ") 
        strSQL.Append(" nfamupe = @nfamupe, ") 
        strSQL.Append(" nfamute = @nfamute, ") 
        strSQL.Append(" nnfhope = @nnfhope, ") 
        strSQL.Append(" nnfhote = @nnfhote, ") 
        strSQL.Append(" nnfmupe = @nnfmupe, ") 
        strSQL.Append(" nnfmute = @nnfmute, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" nsueldo = @nsueldo, ") 
        strSQL.Append(" ctipneg = @ctipneg, cmanfon = @cmanfon, cpuesto = @cpuesto , cjefe = @cjefe, cpuestojefe = @cpuestojefe, dfechaA = @dfechaA, cconcpa = @cconcpa , cconvta = @cconvta,  ")
        strSQL.Append(" cpara = @cpara, nmetros = @nmetros, nvaras = @nvaras , cmedida = @cmedida, ncantidad = @ncantidad, cdirterreno = @cdirterreno, cgiro = @cgiro, ")
        strSQL.Append(" longitud = @longitud, latitud = @latitud ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ctiprel = @ctiprel ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 

        Dim args(42) As SqlParameter
        args(0) = New SqlParameter("@cnomfue", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomfue
        args(1) = New SqlParameter("@ctidofu", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctidofu
        args(2) = New SqlParameter("@cnudofu", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnudofu
        args(3) = New SqlParameter("@dinifue", SqlDbType.Datetime)
        args(3).Value = lEntidad.dinifue
        args(4) = New SqlParameter("@nemplea", SqlDbType.Decimal)
        args(4).Value = lEntidad.nemplea
        args(5) = New SqlParameter("@cubifue", SqlDbType.VarChar)
        args(5).Value = lEntidad.cubifue
        args(6) = New SqlParameter("@cdirfue", SqlDbType.VarChar)
        args(6).Value = lEntidad.cdirfue
        args(7) = New SqlParameter("@ctelfue", SqlDbType.VarChar)
        args(7).Value = lEntidad.ctelfue
        args(8) = New SqlParameter("@cconfue", SqlDbType.VarChar)
        args(8).Value = lEntidad.cconfue
        args(9) = New SqlParameter("@csececo", SqlDbType.VarChar)
        args(9).Value = lEntidad.csececo
        args(10) = New SqlParameter("@ccodact", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodact
        args(11) = New SqlParameter("@canoubi", SqlDbType.DateTime)
        args(11).Value = lEntidad.canoubi
        args(12) = New SqlParameter("@nfahope", SqlDbType.Decimal)
        args(12).Value = lEntidad.nfahope
        args(13) = New SqlParameter("@nfahote", SqlDbType.Decimal)
        args(13).Value = lEntidad.nfahote
        args(14) = New SqlParameter("@nfamupe", SqlDbType.Decimal)
        args(14).Value = lEntidad.nfamupe
        args(15) = New SqlParameter("@nfamute", SqlDbType.Decimal)
        args(15).Value = lEntidad.nfamute
        args(16) = New SqlParameter("@nnfhope", SqlDbType.Decimal)
        args(16).Value = lEntidad.nnfhope
        args(17) = New SqlParameter("@nnfhote", SqlDbType.Decimal)
        args(17).Value = lEntidad.nnfhote
        args(18) = New SqlParameter("@nnfmupe", SqlDbType.Decimal)
        args(18).Value = lEntidad.nnfmupe
        args(19) = New SqlParameter("@nnfmute", SqlDbType.Decimal)
        args(19).Value = lEntidad.nnfmute
        args(20) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodusu
        args(21) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(21).Value = lEntidad.dfecmod
        args(22) = New SqlParameter("@nsueldo", SqlDbType.Decimal)
        args(22).Value = lEntidad.nsueldo
        args(23) = New SqlParameter("@ctipneg", SqlDbType.VarChar)
        args(23).Value = lEntidad.ctipneg
        args(24) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(24).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value,lEntidad.ccodcli)
        args(25) = New SqlParameter("@ctiprel", SqlDbType.VarChar)
        args(25).Value = IIf(lEntidad.ctiprel = Nothing, DBNull.Value,lEntidad.ctiprel)
        args(26) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(26).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value,lEntidad.ccodfue)
        args(27) = New SqlParameter("@cmanfon", SqlDbType.VarChar)
        args(27).Value = lEntidad.cmanfon
        args(28) = New SqlParameter("@cpuesto", SqlDbType.VarChar)
        args(28).Value = lEntidad.cpuesto
        args(29) = New SqlParameter("@cjefe", SqlDbType.VarChar)
        args(29).Value = lEntidad.cjefe
        args(30) = New SqlParameter("@cpuestojefe", SqlDbType.VarChar)
        args(30).Value = lEntidad.cpuestojefe
        args(31) = New SqlParameter("@dfechaA", SqlDbType.DateTime)
        args(31).Value = lEntidad.dfechaA
        args(32) = New SqlParameter("@cconcpa", SqlDbType.VarChar)
        args(32).Value = lEntidad.cconcpa
        args(33) = New SqlParameter("@cconvta", SqlDbType.VarChar)
        args(33).Value = lEntidad.cconvta

        args(34) = New SqlParameter("@cpara", SqlDbType.VarChar)
        args(34).Value = lEntidad.cpara
        args(35) = New SqlParameter("@nmetros", SqlDbType.Decimal)
        args(35).Value = lEntidad.nmetros
        args(36) = New SqlParameter("@nvaras", SqlDbType.Decimal)
        args(36).Value = lEntidad.nvaras
        args(37) = New SqlParameter("@cmedida", SqlDbType.VarChar)
        args(37).Value = lEntidad.cmedida
        args(38) = New SqlParameter("@ncantidad", SqlDbType.Decimal)
        args(38).Value = lEntidad.ncantidad

        args(39) = New SqlParameter("@cdirterreno", SqlDbType.VarChar)
        args(39).Value = lEntidad.cdirterreno
        args(40) = New SqlParameter("@cgiro", SqlDbType.VarChar)
        args(40).Value = lEntidad.cgiro
        args(41) = New SqlParameter("@latitud", SqlDbType.VarChar)
        args(41).Value = lEntidad.latitud
        args(42) = New SqlParameter("@longitud", SqlDbType.VarChar)
        args(42).Value = lEntidad.longitud

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidfin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO clidfin ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ctiprel, ") 
        strSQL.Append(" ccodfue, ") 
        strSQL.Append(" cnomfue, ") 
        strSQL.Append(" ctidofu, ") 
        strSQL.Append(" cnudofu, ") 
        strSQL.Append(" dinifue, ") 
        strSQL.Append(" nemplea, ") 
        strSQL.Append(" cubifue, ") 
        strSQL.Append(" cdirfue, ") 
        strSQL.Append(" ctelfue, ") 
        strSQL.Append(" cconfue, ") 
        strSQL.Append(" csececo, ") 
        strSQL.Append(" ccodact, ") 
        strSQL.Append(" canoubi, ") 
        strSQL.Append(" nfahope, ") 
        strSQL.Append(" nfahote, ") 
        strSQL.Append(" nfamupe, ") 
        strSQL.Append(" nfamute, ") 
        strSQL.Append(" nnfhope, ") 
        strSQL.Append(" nnfhote, ") 
        strSQL.Append(" nnfmupe, ") 
        strSQL.Append(" nnfmute, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" nsueldo, ") 
        strSQL.Append(" ctipneg, cmanfon, cpuesto, cjefe, cpuestojefe, dfechaA, cconcpa, cconvta, cpara,")
        strSQL.Append(" nmetros, nvaras, cmedida, ncantidad, cdirterreno, cgiro, longitud, latitud) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ctiprel, ") 
        strSQL.Append(" @ccodfue, ") 
        strSQL.Append(" @cnomfue, ") 
        strSQL.Append(" @ctidofu, ") 
        strSQL.Append(" @cnudofu, ") 
        strSQL.Append(" @dinifue, ") 
        strSQL.Append(" @nemplea, ") 
        strSQL.Append(" @cubifue, ") 
        strSQL.Append(" @cdirfue, ") 
        strSQL.Append(" @ctelfue, ") 
        strSQL.Append(" @cconfue, ") 
        strSQL.Append(" @csececo, ") 
        strSQL.Append(" @ccodact, ") 
        strSQL.Append(" @canoubi, ") 
        strSQL.Append(" @nfahope, ") 
        strSQL.Append(" @nfahote, ") 
        strSQL.Append(" @nfamupe, ") 
        strSQL.Append(" @nfamute, ") 
        strSQL.Append(" @nnfhope, ") 
        strSQL.Append(" @nnfhote, ") 
        strSQL.Append(" @nnfmupe, ") 
        strSQL.Append(" @nnfmute, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @nsueldo, ") 
        strSQL.Append(" @ctipneg, @cmanfon, @cpuesto, @cjefe, @cpuestojefe, @dfechaA, @cconcpa, @cconvta, @cpara, ")
        strSQL.Append(" @nmetros, @nvaras, @cmedida, @ncantidad, @cdirterreno, @cgiro, @longitud, @latitud) ")
        'strSQL.Append(" @ctipneg, @cmanfon, @cpuesto, @cjefe, @cpuestojefe, @dfechaA, @cconcpa, @cconvta, @cpara, @nmetros, @nvaras, @cmedida, @ncantidad, @cdirterreno ) ")

        Dim args(42) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ctiprel", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ctiprel = Nothing, DBNull.Value, lEntidad.ctiprel)
        args(2) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value, lEntidad.ccodfue)
        args(3) = New SqlParameter("@cnomfue", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomfue
        args(4) = New SqlParameter("@ctidofu", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctidofu
        args(5) = New SqlParameter("@cnudofu", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnudofu
        args(6) = New SqlParameter("@dinifue", SqlDbType.Datetime)
        args(6).Value = lEntidad.dinifue
        args(7) = New SqlParameter("@nemplea", SqlDbType.Decimal)
        args(7).Value = lEntidad.nemplea
        args(8) = New SqlParameter("@cubifue", SqlDbType.VarChar)
        args(8).Value = lEntidad.cubifue
        args(9) = New SqlParameter("@cdirfue", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdirfue
        args(10) = New SqlParameter("@ctelfue", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctelfue
        args(11) = New SqlParameter("@cconfue", SqlDbType.VarChar)
        args(11).Value = lEntidad.cconfue
        args(12) = New SqlParameter("@csececo", SqlDbType.VarChar)
        args(12).Value = lEntidad.csececo
        args(13) = New SqlParameter("@ccodact", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodact
        args(14) = New SqlParameter("@canoubi", SqlDbType.DateTime)
        args(14).Value = lEntidad.canoubi
        args(15) = New SqlParameter("@nfahope", SqlDbType.Decimal)
        args(15).Value = lEntidad.nfahope
        args(16) = New SqlParameter("@nfahote", SqlDbType.Decimal)
        args(16).Value = lEntidad.nfahote
        args(17) = New SqlParameter("@nfamupe", SqlDbType.Decimal)
        args(17).Value = lEntidad.nfamupe
        args(18) = New SqlParameter("@nfamute", SqlDbType.Decimal)
        args(18).Value = lEntidad.nfamute
        args(19) = New SqlParameter("@nnfhope", SqlDbType.Decimal)
        args(19).Value = lEntidad.nnfhope
        args(20) = New SqlParameter("@nnfhote", SqlDbType.Decimal)
        args(20).Value = lEntidad.nnfhote
        args(21) = New SqlParameter("@nnfmupe", SqlDbType.Decimal)
        args(21).Value = lEntidad.nnfmupe
        args(22) = New SqlParameter("@nnfmute", SqlDbType.Decimal)
        args(22).Value = lEntidad.nnfmute
        args(23) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccodusu
        args(24) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(24).Value = lEntidad.dfecmod
        args(25) = New SqlParameter("@nsueldo", SqlDbType.Decimal)
        args(25).Value = lEntidad.nsueldo
        args(26) = New SqlParameter("@ctipneg", SqlDbType.VarChar)
        args(26).Value = lEntidad.ctipneg

        args(27) = New SqlParameter("@cmanfon", SqlDbType.VarChar)
        args(27).Value = lEntidad.cmanfon
        args(28) = New SqlParameter("@cpuesto", SqlDbType.VarChar)
        args(28).Value = lEntidad.cpuesto
        args(29) = New SqlParameter("@cjefe", SqlDbType.VarChar)
        args(29).Value = lEntidad.cjefe
        args(30) = New SqlParameter("@cpuestojefe", SqlDbType.VarChar)
        args(30).Value = lEntidad.cpuestojefe

        args(31) = New SqlParameter("@dfechaA", SqlDbType.DateTime)
        args(31).Value = lEntidad.dfechaA
        args(32) = New SqlParameter("@cconcpa", SqlDbType.VarChar)
        args(32).Value = lEntidad.cconcpa
        args(33) = New SqlParameter("@cconvta", SqlDbType.VarChar)
        args(33).Value = lEntidad.cconvta

        args(34) = New SqlParameter("@cpara", SqlDbType.VarChar)
        args(34).Value = lEntidad.cpara
        args(35) = New SqlParameter("@nmetros", SqlDbType.Decimal)
        args(35).Value = lEntidad.nmetros
        args(36) = New SqlParameter("@nvaras", SqlDbType.Decimal)
        args(36).Value = lEntidad.nvaras
        args(37) = New SqlParameter("@cmedida", SqlDbType.VarChar)
        args(37).Value = lEntidad.cmedida
        args(38) = New SqlParameter("@ncantidad", SqlDbType.Decimal)
        args(38).Value = lEntidad.ncantidad
        args(39) = New SqlParameter("@cdirterreno", SqlDbType.VarChar)
        args(39).Value = lEntidad.cdirterreno
        args(40) = New SqlParameter("@cgiro", SqlDbType.VarChar)
        args(40).Value = lEntidad.cgiro
        args(41) = New SqlParameter("@latitud", SqlDbType.VarChar)
        args(41).Value = lEntidad.latitud
        args(42) = New SqlParameter("@longitud", SqlDbType.VarChar)
        args(42).Value = lEntidad.longitud

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function Elimina(ByVal ccodcli As String, ByVal ctiprel As String, ByVal ccodfue As String) As Integer

        Dim strSQL As New StringBuilder

        strSQL.Append("DELETE FROM clidfin ")
        strSQL.Append(" WHERE ccodcli = '" & ccodcli & "'")
        strSQL.Append(" AND ctiprel = " & "'" & ctiprel & "'")
        strSQL.Append(" AND ccodfue = " & "'" & ccodfue & "'")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@cTiprel", ctiprel)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidfin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ctiprel = @ctiprel ")
        strSQL.Append(" AND ccodfue = @ccodfue ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ctiprel", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctiprel
        args(2) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodfue

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomfue = IIf(.Item("cnomfue") Is DBNull.Value, Nothing, .Item("cnomfue"))
                lEntidad.ctidofu = IIf(.Item("ctidofu") Is DBNull.Value, Nothing, .Item("ctidofu"))
                lEntidad.cnudofu = IIf(.Item("cnudofu") Is DBNull.Value, Nothing, .Item("cnudofu"))
                lEntidad.dinifue = IIf(.Item("dinifue") Is DBNull.Value, Nothing, .Item("dinifue"))
                lEntidad.nemplea = IIf(.Item("nemplea") Is DBNull.Value, Nothing, .Item("nemplea"))
                lEntidad.cubifue = IIf(.Item("cubifue") Is DBNull.Value, Nothing, .Item("cubifue"))
                lEntidad.cdirfue = IIf(.Item("cdirfue") Is DBNull.Value, Nothing, .Item("cdirfue"))
                lEntidad.ctelfue = IIf(.Item("ctelfue") Is DBNull.Value, Nothing, .Item("ctelfue"))
                lEntidad.cconfue = IIf(.Item("cconfue") Is DBNull.Value, Nothing, .Item("cconfue"))
                lEntidad.csececo = IIf(.Item("csececo") Is DBNull.Value, Nothing, .Item("csececo"))
                lEntidad.ccodact = IIf(.Item("ccodact") Is DBNull.Value, Nothing, .Item("ccodact"))
                lEntidad.canoubi = IIf(.Item("canoubi") Is DBNull.Value, Nothing, .Item("canoubi"))
                lEntidad.nfahope = IIf(.Item("nfahope") Is DBNull.Value, 0, .Item("nfahope"))
                lEntidad.nfahote = IIf(.Item("nfahote") Is DBNull.Value, 0, .Item("nfahote"))
                lEntidad.nfamupe = IIf(.Item("nfamupe") Is DBNull.Value, 0, .Item("nfamupe"))
                lEntidad.nfamute = IIf(.Item("nfamute") Is DBNull.Value, 0, .Item("nfamute"))
                lEntidad.nnfhope = IIf(.Item("nnfhope") Is DBNull.Value, 0, .Item("nnfhope"))
                lEntidad.nnfhote = IIf(.Item("nnfhote") Is DBNull.Value, 0, .Item("nnfhote"))
                lEntidad.nnfmupe = IIf(.Item("nnfmupe") Is DBNull.Value, 0, .Item("nnfmupe"))
                lEntidad.nnfmute = IIf(.Item("nnfmute") Is DBNull.Value, 0, .Item("nnfmute"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.nsueldo = IIf(.Item("nsueldo") Is DBNull.Value, Nothing, .Item("nsueldo"))
                lEntidad.ctipneg = IIf(.Item("ctipneg") Is DBNull.Value, Nothing, .Item("ctipneg"))
                lEntidad.dfechaA = IIf(.Item("dfechaA") Is DBNull.Value, Now, .Item("dfechaA"))
                lEntidad.cconcpa = IIf(.Item("cconcpa") Is DBNull.Value, Nothing, .Item("cconcpa"))
                lEntidad.cconvta = IIf(.Item("cconvta") Is DBNull.Value, Nothing, .Item("cconvta"))
                lEntidad.cpara = IIf(.Item("cpara") Is DBNull.Value, Nothing, .Item("cpara"))
                lEntidad.nmetros = IIf(.Item("cpara") Is DBNull.Value, 0, .Item("nmetros"))
                lEntidad.nvaras = IIf(.Item("nvaras") Is DBNull.Value, 0, .Item("nvaras"))
                lEntidad.cmedida = IIf(.Item("cmedida") Is DBNull.Value, Nothing, .Item("cmedida"))
                lEntidad.ncantidad = IIf(.Item("ncantidad") Is DBNull.Value, 0, .Item("ncantidad"))
                lEntidad.cdirterreno = IIf(.Item("cdirterreno") Is DBNull.Value, Nothing, .Item("cdirterreno"))
                lEntidad.cpuesto = IIf(.Item("cpuesto") Is DBNull.Value, "", .Item("cpuesto"))
                lEntidad.cjefe = IIf(.Item("cjefe") Is DBNull.Value, Nothing, .Item("cjefe"))
                lEntidad.cpuestojefe = IIf(.Item("cpuestojefe") Is DBNull.Value, Nothing, .Item("cpuestojefe"))
                lEntidad.cgiro = IIf(.Item("cgiro") Is DBNull.Value, Nothing, .Item("cgiro"))
                lEntidad.latitud = IIf(.Item("latitud") Is DBNull.Value, "", .Item("latitud"))
                lEntidad.longitud = IIf(.Item("longitud") Is DBNull.Value, "", .Item("longitud"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As clidfin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodfue),0) + 1 ")
        strSQL.Append(" FROM clidfin ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ctiprel = @ctiprel ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ctiprel", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctiprel

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ByVal ccodcli As String, ByVal ctiprel As String) As listaclidfin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ctiprel = @ctiprel ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ctiprel", SqlDbType.VarChar)
        args(1).Value = ctiprel

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaclidfin

        Try
            Do While dr.Read()
                Dim mEntidad As New clidfin
                mEntidad.ccodcli = ccodcli
                mEntidad.ctiprel = ctiprel
                mEntidad.ccodfue = IIf(dr("ccodfue") Is DBNull.Value, Nothing, dr("ccodfue"))
                mEntidad.cnomfue = IIf(dr("cnomfue") Is DBNull.Value, Nothing, dr("cnomfue"))
                mEntidad.ctidofu = IIf(dr("ctidofu") Is DBNull.Value, Nothing, dr("ctidofu"))
                mEntidad.cnudofu = IIf(dr("cnudofu") Is DBNull.Value, Nothing, dr("cnudofu"))
                mEntidad.dinifue = IIf(dr("dinifue") Is DBNull.Value, Nothing, dr("dinifue"))
                mEntidad.nemplea = IIf(dr("nemplea") Is DBNull.Value, Nothing, dr("nemplea"))
                mEntidad.cubifue = IIf(dr("cubifue") Is DBNull.Value, Nothing, dr("cubifue"))
                mEntidad.cdirfue = IIf(dr("cdirfue") Is DBNull.Value, Nothing, dr("cdirfue"))
                mEntidad.ctelfue = IIf(dr("ctelfue") Is DBNull.Value, Nothing, dr("ctelfue"))
                mEntidad.cconfue = IIf(dr("cconfue") Is DBNull.Value, Nothing, dr("cconfue"))
                mEntidad.csececo = IIf(dr("csececo") Is DBNull.Value, Nothing, dr("csececo"))
                mEntidad.ccodact = IIf(dr("ccodact") Is DBNull.Value, Nothing, dr("ccodact"))
                mEntidad.canoubi = IIf(dr("canoubi") Is DBNull.Value, Nothing, dr("canoubi"))
                mEntidad.nfahope = IIf(dr("nfahope") Is DBNull.Value, Nothing, dr("nfahope"))
                mEntidad.nfahote = IIf(dr("nfahote") Is DBNull.Value, Nothing, dr("nfahote"))
                mEntidad.nfamupe = IIf(dr("nfamupe") Is DBNull.Value, Nothing, dr("nfamupe"))
                mEntidad.nfamute = IIf(dr("nfamute") Is DBNull.Value, Nothing, dr("nfamute"))
                mEntidad.nnfhope = IIf(dr("nnfhope") Is DBNull.Value, Nothing, dr("nnfhope"))
                mEntidad.nnfhote = IIf(dr("nnfhote") Is DBNull.Value, Nothing, dr("nnfhote"))
                mEntidad.nnfmupe = IIf(dr("nnfmupe") Is DBNull.Value, Nothing, dr("nnfmupe"))
                mEntidad.nnfmute = IIf(dr("nnfmute") Is DBNull.Value, Nothing, dr("nnfmute"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.nsueldo = IIf(dr("nsueldo") Is DBNull.Value, Nothing, dr("nsueldo"))
                mEntidad.ctipneg = IIf(dr("ctipneg") Is DBNull.Value, Nothing, dr("ctipneg"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorID2(ByVal ccodcli As String) As listaclidfin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaclidfin

        Try
            Do While dr.Read()
                Dim mEntidad As New clidfin
                mEntidad.ccodcli = ccodcli
                mEntidad.ctiprel = IIf(dr("ctiprel") Is DBNull.Value, Nothing, dr("ctiprel"))
                mEntidad.ccodfue = IIf(dr("ccodfue") Is DBNull.Value, Nothing, dr("ccodfue"))
                mEntidad.cnomfue = IIf(dr("cnomfue") Is DBNull.Value, Nothing, dr("cnomfue"))
                mEntidad.ctidofu = IIf(dr("ctidofu") Is DBNull.Value, Nothing, dr("ctidofu"))
                mEntidad.cnudofu = IIf(dr("cnudofu") Is DBNull.Value, Nothing, dr("cnudofu"))
                mEntidad.dinifue = IIf(dr("dinifue") Is DBNull.Value, Nothing, dr("dinifue"))
                mEntidad.nemplea = IIf(dr("nemplea") Is DBNull.Value, Nothing, dr("nemplea"))
                mEntidad.cubifue = IIf(dr("cubifue") Is DBNull.Value, Nothing, dr("cubifue"))
                mEntidad.cdirfue = IIf(dr("cdirfue") Is DBNull.Value, Nothing, dr("cdirfue"))
                mEntidad.ctelfue = IIf(dr("ctelfue") Is DBNull.Value, Nothing, dr("ctelfue"))
                mEntidad.cconfue = IIf(dr("cconfue") Is DBNull.Value, Nothing, dr("cconfue"))
                mEntidad.csececo = IIf(dr("csececo") Is DBNull.Value, Nothing, dr("csececo"))
                mEntidad.ccodact = IIf(dr("ccodact") Is DBNull.Value, Nothing, dr("ccodact"))
                mEntidad.canoubi = IIf(dr("canoubi") Is DBNull.Value, Nothing, dr("canoubi"))
                mEntidad.nfahope = IIf(dr("nfahope") Is DBNull.Value, Nothing, dr("nfahope"))
                mEntidad.nfahote = IIf(dr("nfahote") Is DBNull.Value, Nothing, dr("nfahote"))
                mEntidad.nfamupe = IIf(dr("nfamupe") Is DBNull.Value, Nothing, dr("nfamupe"))
                mEntidad.nfamute = IIf(dr("nfamute") Is DBNull.Value, Nothing, dr("nfamute"))
                mEntidad.nnfhope = IIf(dr("nnfhope") Is DBNull.Value, Nothing, dr("nnfhope"))
                mEntidad.nnfhote = IIf(dr("nnfhote") Is DBNull.Value, Nothing, dr("nnfhote"))
                mEntidad.nnfmupe = IIf(dr("nnfmupe") Is DBNull.Value, Nothing, dr("nnfmupe"))
                mEntidad.nnfmute = IIf(dr("nnfmute") Is DBNull.Value, Nothing, dr("nnfmute"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.nsueldo = IIf(dr("nsueldo") Is DBNull.Value, Nothing, dr("nsueldo"))
                mEntidad.ctipneg = IIf(dr("ctipneg") Is DBNull.Value, Nothing, dr("ctipneg"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ctiprel As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ctiprel = @ctiprel ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ctiprel", ctiprel)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ctiprel As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ctiprel = @ctiprel ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ctiprel", ctiprel)

        Dim tables(0) As String
        tables(0) = New String("clidfin")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Public Function ObtenerDataSetEspc(ByVal ccodcli As String, ByVal ctiprel As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cCodFue as Nro, cNomfue, cdirfue, ctelfue, csececo, cgiro, cTipNeg FROM Clidfin ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ctiprel = @ctiprel ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ctiprel", ctiprel)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcli, ")
        strSQL.Append(" ctiprel, ")
        strSQL.Append(" ccodfue, ")
        strSQL.Append(" cnomfue, ")
        strSQL.Append(" rtrim(ctidofu) as ctidofu, ")
        strSQL.Append(" cnudofu, ")
        strSQL.Append(" dinifue, ")
        strSQL.Append(" nemplea, ")
        strSQL.Append(" rtrim(cubifue) as cubifue, ")
        strSQL.Append(" cdirfue, ")
        strSQL.Append(" ctelfue, ")
        strSQL.Append(" rtrim(cconfue) as cconfue, ")
        strSQL.Append(" rtrim(csececo) as csececo, ")
        strSQL.Append(" rtrim(ccodact) as ccodact, ")
        strSQL.Append(" canoubi, ")
        strSQL.Append(" nfahope, ")
        strSQL.Append(" nfahote, ")
        strSQL.Append(" nfamupe, ")
        strSQL.Append(" nfamute, ")
        strSQL.Append(" nnfhope, ")
        strSQL.Append(" nnfhote, ")
        strSQL.Append(" nnfmupe, ")
        strSQL.Append(" nnfmute, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" nsueldo, ")
        strSQL.Append(" ctipneg, dfechaA, cconcpa, cconvta, ")
        strSQL.Append("cpara, nmetros, nvaras, cmedida, ncantidad, cdirterreno, cpuesto, cjefe, cpuestojefe, cgiro, ")
        strSQL.Append("isnull(latitud,space(1)) as latitud, isnull(longitud,space(1)) as longitud")
        strSQL.Append(" FROM clidfin ")

    End Sub
    Public Function RecuperarporCliente(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidfin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ctiprel = IIf(.Item("ctiprel") Is DBNull.Value, Nothing, .Item("ctiprel"))
                lEntidad.ccodfue = IIf(.Item("ccodfue") Is DBNull.Value, Nothing, .Item("ccodfue"))
                lEntidad.cnomfue = IIf(.Item("cnomfue") Is DBNull.Value, Nothing, .Item("cnomfue"))
                lEntidad.ctidofu = IIf(.Item("ctidofu") Is DBNull.Value, Nothing, .Item("ctidofu"))
                lEntidad.cnudofu = IIf(.Item("cnudofu") Is DBNull.Value, Nothing, .Item("cnudofu"))
                lEntidad.dinifue = IIf(.Item("dinifue") Is DBNull.Value, Nothing, .Item("dinifue"))
                lEntidad.nemplea = IIf(.Item("nemplea") Is DBNull.Value, Nothing, .Item("nemplea"))
                lEntidad.cubifue = IIf(.Item("cubifue") Is DBNull.Value, Nothing, .Item("cubifue"))
                lEntidad.cdirfue = IIf(.Item("cdirfue") Is DBNull.Value, Nothing, .Item("cdirfue"))
                lEntidad.ctelfue = IIf(.Item("ctelfue") Is DBNull.Value, Nothing, .Item("ctelfue"))
                lEntidad.cconfue = IIf(.Item("cconfue") Is DBNull.Value, Nothing, .Item("cconfue"))
                lEntidad.csececo = IIf(.Item("csececo") Is DBNull.Value, Nothing, .Item("csececo"))
                lEntidad.ccodact = IIf(.Item("ccodact") Is DBNull.Value, Nothing, .Item("ccodact"))
                lEntidad.canoubi = IIf(.Item("canoubi") Is DBNull.Value, Nothing, .Item("canoubi"))
                lEntidad.nfahope = IIf(.Item("nfahope") Is DBNull.Value, Nothing, .Item("nfahope"))
                lEntidad.nfahote = IIf(.Item("nfahote") Is DBNull.Value, Nothing, .Item("nfahote"))
                lEntidad.nfamupe = IIf(.Item("nfamupe") Is DBNull.Value, Nothing, .Item("nfamupe"))
                lEntidad.nfamute = IIf(.Item("nfamute") Is DBNull.Value, Nothing, .Item("nfamute"))
                lEntidad.nnfhope = IIf(.Item("nnfhope") Is DBNull.Value, Nothing, .Item("nnfhope"))
                lEntidad.nnfhote = IIf(.Item("nnfhote") Is DBNull.Value, Nothing, .Item("nnfhote"))
                lEntidad.nnfmupe = IIf(.Item("nnfmupe") Is DBNull.Value, Nothing, .Item("nnfmupe"))
                lEntidad.nnfmute = IIf(.Item("nnfmute") Is DBNull.Value, Nothing, .Item("nnfmute"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.nsueldo = IIf(.Item("nsueldo") Is DBNull.Value, Nothing, .Item("nsueldo"))
                lEntidad.ctipneg = IIf(.Item("ctipneg") Is DBNull.Value, Nothing, .Item("ctipneg"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function


    Public Function ObtenercCoduni(ByVal ccodcli As String, ByVal ctiprel As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(ccodfue)+1 as ccodfue")
        strSQL.Append(" FROM Clidfin ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND cTiprel = @ctiprel ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@cTiprel", ctiprel)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("ccodfue")) Then
                lccodgar = "01"
            Else
                lccodgar = ds.Tables(0).Rows(0)("ccodfue")
                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 2 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = "01"
        End If



        Return lccodgar

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidfin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CLIDFin ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND cTiprel = @cTiprel ")
        strSQL.Append(" AND cCodfue = @cCodFue ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@cTiprel", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctiprel
        args(2) = New SqlParameter("@cCodfue", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodfue


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerDataSetPorCodigo(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDirNegocio(ByVal ccodcli As String) As String
        Dim strSQL As New StringBuilder

        strSQL.Append("Select cDirFue FROM CLIDFIN WHERE ccodcli = @ccodcli ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet
        Dim lcdirfue As String

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcdirfue = ""
        Else
            lcdirfue = ds.Tables(0).Rows(0)("cdirfue")
        End If
        Return lcdirfue.Trim
    End Function
    Public Function BuscarSectorEconomico(ByVal ccodcli As String) As String
        Dim strSQl As New StringBuilder

        strSQl.Append("Select csececo FROM CLIDFIN WHERE ccodcli = @ccodcli and csececo is not null order by dinifue desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As New DataSet
        Dim lccsececo As String

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQl.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lccsececo = "C"
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("csececo")) Then
                lccsececo = "C"
            Else
                If ds.Tables(0).Rows(0)("csececo") = " " Then
                    lccsececo = "C"
                Else
                    lccsececo = ds.Tables(0).Rows(0)("csececo")
                End If

            End If

        End If
        Return lccsececo.Trim
    End Function
    Public Function BuscarActividad(ByVal ccodcli As String) As String
        Dim strSQl As New StringBuilder

        strSQl.Append("Select ccodact FROM CLIDFIN WHERE ccodcli = @ccodcli order by dinifue desc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli


        Dim ds As New DataSet
        Dim lccsececo As String

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQl.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lccsececo = "999999"
        Else
            lccsececo = "999999"
            For Each fila As DataRow In ds.Tables(0).Rows
                If IsDBNull(fila("ccodact")) Then
                Else
                    If fila("ccodact") = " " Then
                    Else
                        lccsececo = ds.Tables(0).Rows(0)("ccodact")
                    End If

                End If
                Exit For
            Next

        End If
        Return lccsececo.Trim
    End Function

    'Extrae fuente de Ingreso
    Public Function Extrae_Ultima_Fuente_de_Ingreso(ByVal pcCodigo As String) As String

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lcFuente As String

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select MAX(ccodfue) as ccodfue from clidfin " & _
                                        " Where ccodcli ='" & pcCodigo & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Fuente")

                For Each fila As DataRow In ds_Trab.Tables("Fuente").Rows
                    lcFuente = fila("cCodfue")
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lcFuente

    End Function
End Class
