Imports System
Imports System.Text
Public Class dbCremcre
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cCodofi = @cCodofi, ")
        strSQL.Append(" ccodprd = @ccodprd, ")
        strSQL.Append(" cmoneda = @cmoneda, ")
        strSQL.Append(" cestado = @cestado, ")
        strSQL.Append(" ccodcli = @ccodcli, ")
        strSQL.Append(" ccatego = @ccatego, ")
        strSQL.Append(" ccodfue = @ccodfue, ")
        strSQL.Append(" ccodact = @ccodact, ")
        strSQL.Append(" ctipcre = @ctipcre, ")
        strSQL.Append(" cdescre = @cdescre, ")
        strSQL.Append(" ctipcuo = @ctipcuo, ")
        strSQL.Append(" ctipper = @ctipper, ")
        strSQL.Append(" ntipperc = @ntipperc, ")
        strSQL.Append(" cctapre = @cctapre, ")
        strSQL.Append(" cnorref = @cnorref, ")
        strSQL.Append(" ccodana = @ccodana, ")
        strSQL.Append(" dfecasi = @dfecasi, ")
        strSQL.Append(" dfecsol = @dfecsol, ")
        strSQL.Append(" nmonsol = @nmonsol, ")
        strSQL.Append(" nmonsug = @nmonsug, ")
        strSQL.Append(" ncuosug = @ncuosug, ")
        strSQL.Append(" ndessug = @ndessug, ")
        strSQL.Append(" ndiasug = @ndiasug, ")
        strSQL.Append(" ndiagra = @ndiagra, ")
        strSQL.Append(" dfecapr = @dfecapr, ")
        strSQL.Append(" dfecven = @dfecven, ")
        strSQL.Append(" nmonapr = @nmonapr, ")
        strSQL.Append(" nmoncuo = @nmoncuo, ")
        strSQL.Append(" nintapr = @nintapr, ")
        strSQL.Append(" ncuoapr = @ncuoapr, ")
        strSQL.Append(" ndiaapr = @ndiaapr, ")
        strSQL.Append(" ndesapr = @ndesapr, ")
        strSQL.Append(" cnrolin = @cnrolin, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" ctipcon = @ctipcon, ")
        strSQL.Append(" ccodapo = @ccodapo, ")
        strSQL.Append(" dfecvig = @dfecvig, ")
        strSQL.Append(" ndeseje = @ndeseje, ")
        strSQL.Append(" ngastos = @ngastos, ")
        strSQL.Append(" ncappag = @ncappag, ")
        strSQL.Append(" nintpen = @nintpen, ")
        strSQL.Append(" nintcal = @nintcal, ")
        strSQL.Append(" nintpag = @nintpag, ")
        strSQL.Append(" nintmor = @nintmor, ")
        strSQL.Append(" nmorpag = @nmorpag, ")
        strSQL.Append(" npagcta = @npagcta, ")
        strSQL.Append(" ncapdes = @ncapdes, ")
        strSQL.Append(" ncapcal = @ncapcal, ")
        strSQL.Append(" ngaspag = @ngaspag, ")
        strSQL.Append(" ndiaatr = @ndiaatr, ")
        strSQL.Append(" ndiaant = @ndiaant, ")
        strSQL.Append(" natracu = @natracu, ")
        strSQL.Append(" natrmax = @natrmax, ")
        strSQL.Append(" ccondic = @ccondic, ")
        strSQL.Append(" dultpag = @dultpag, ")
        strSQL.Append(" dfecter = @dfecter, ")
        strSQL.Append(" ccodrec = @ccodrec, ")
        strSQL.Append(" nnota1 = @nnota1, ")
        strSQL.Append(" nnota2 = @nnota2, ")
        strSQL.Append(" cmarjud = @cmarjud, ")
        strSQL.Append(" ntipcam = @ntipcam, ")
        strSQL.Append(" lctaret = @lctaret, ")
        strSQL.Append(" cclacre = @cclacre, ")
        strSQL.Append(" ccalif = @ccalif, ")
        strSQL.Append(" nsegvid = @nsegvid, ")
        strSQL.Append(" cnumexp = @cnumexp, ")
        strSQL.Append(" ccodrub = @ccodrub, ")
        strSQL.Append(" cregist = @cregist, ")
        strSQL.Append(" dfecadm = @dfecadm, ")
        strSQL.Append(" nintadm = @nintadm, ")
        strSQL.Append(" nmeses = @nmeses, ")
        strSQL.Append(" csececo = @csececo, ")
        strSQL.Append(" nciclo = @nciclo, ")
        strSQL.Append(" ccodsol = @ccodsol, ")
        strSQL.Append(" nmorak = @nmorak, ")
        strSQL.Append(" nahoprg = @nahoprg, ")
        strSQL.Append(" cliquid = @cliquid, ")
        strSQL.Append(" clineac = @clineac, ")
        strSQL.Append(" ncapoto = @ncapoto, ")
        strSQL.Append(" ccontra = @ccontra, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" cflat = @cflat, ")
        strSQL.Append(" nnumfal = @nnumfal, ")
        strSQL.Append(" ctipgar = @ctipgar, ")
        strSQL.Append(" coficina = @coficina,  ")
        strSQL.Append(" ccargo = @ccargo, lsegvid = @lsegvid, cprograma = @cprograma, canalisis = @ccodana, cfueing= @cfueing  ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(92) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = lEntidad.cCodofi
        args(1) = New SqlParameter("@ccodprd", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodprd
        args(2) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(2).Value = lEntidad.cmoneda
        args(3) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(3).Value = lEntidad.cestado
        args(4) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodcli
        args(5) = New SqlParameter("@ccatego", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccatego
        args(6) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodfue
        args(7) = New SqlParameter("@ccodact", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodact
        args(8) = New SqlParameter("@ctipcre", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctipcre
        args(9) = New SqlParameter("@cdescre", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdescre
        args(10) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctipcuo
        args(11) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(11).Value = lEntidad.ctipper
        args(12) = New SqlParameter("@ntipperc", SqlDbType.Decimal)
        args(12).Value = lEntidad.ntipperc
        args(13) = New SqlParameter("@cctapre", SqlDbType.VarChar)
        args(13).Value = lEntidad.cctapre
        args(14) = New SqlParameter("@cnorref", SqlDbType.VarChar)
        args(14).Value = lEntidad.cnorref
        args(15) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodana
        args(16) = New SqlParameter("@dfecasi", SqlDbType.DateTime)
        args(16).Value = lEntidad.dfecasi
        args(17) = New SqlParameter("@dfecsol", SqlDbType.DateTime)
        args(17).Value = lEntidad.dfecsol
        args(18) = New SqlParameter("@nmonsol", SqlDbType.Decimal)
        args(18).Value = lEntidad.nmonsol
        args(19) = New SqlParameter("@nmonsug", SqlDbType.Decimal)
        args(19).Value = lEntidad.nmonsug
        args(20) = New SqlParameter("@ncuosug", SqlDbType.Decimal)
        args(20).Value = lEntidad.ncuosug
        args(21) = New SqlParameter("@ndessug", SqlDbType.Decimal)
        args(21).Value = lEntidad.ndessug
        args(22) = New SqlParameter("@ndiasug", SqlDbType.Decimal)
        args(22).Value = lEntidad.ndiasug
        args(23) = New SqlParameter("@ndiagra", SqlDbType.Decimal)
        args(23).Value = lEntidad.ndiagra
        args(24) = New SqlParameter("@dfecapr", SqlDbType.DateTime)
        args(24).Value = lEntidad.dfecapr
        args(25) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(25).Value = lEntidad.dfecven
        args(26) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(26).Value = lEntidad.nmonapr
        args(27) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(27).Value = lEntidad.nmoncuo
        args(28) = New SqlParameter("@nintapr", SqlDbType.Decimal)
        args(28).Value = lEntidad.nintapr
        args(29) = New SqlParameter("@ncuoapr", SqlDbType.Decimal)
        args(29).Value = lEntidad.ncuoapr
        args(30) = New SqlParameter("@ndiaapr", SqlDbType.Decimal)
        args(30).Value = lEntidad.ndiaapr
        args(31) = New SqlParameter("@ndesapr", SqlDbType.Decimal)
        args(31).Value = lEntidad.ndesapr
        args(32) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(32).Value = lEntidad.cnrolin
        args(33) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(33).Value = lEntidad.ntasint
        args(34) = New SqlParameter("@ctipcon", SqlDbType.VarChar)
        args(34).Value = lEntidad.ctipcon
        args(35) = New SqlParameter("@ccodapo", SqlDbType.VarChar)
        args(35).Value = lEntidad.ccodapo
        args(36) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(36).Value = lEntidad.dfecvig
        args(37) = New SqlParameter("@ndeseje", SqlDbType.Decimal)
        args(37).Value = lEntidad.ndeseje
        args(38) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(38).Value = lEntidad.ngastos
        args(39) = New SqlParameter("@ncappag", SqlDbType.Decimal)
        args(39).Value = lEntidad.ncappag
        args(40) = New SqlParameter("@nintpen", SqlDbType.Decimal)
        args(40).Value = lEntidad.nintpen
        args(41) = New SqlParameter("@nintcal", SqlDbType.Decimal)
        args(41).Value = lEntidad.nintcal
        args(42) = New SqlParameter("@nintpag", SqlDbType.Decimal)
        args(42).Value = lEntidad.nintpag
        args(43) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(43).Value = lEntidad.nintmor
        args(44) = New SqlParameter("@nmorpag", SqlDbType.Decimal)
        args(44).Value = lEntidad.nmorpag
        args(45) = New SqlParameter("@npagcta", SqlDbType.Decimal)
        args(45).Value = lEntidad.npagcta
        args(46) = New SqlParameter("@ncapdes", SqlDbType.Decimal)
        args(46).Value = lEntidad.ncapdes
        args(47) = New SqlParameter("@ncapcal", SqlDbType.Decimal)
        args(47).Value = lEntidad.ncapcal
        args(48) = New SqlParameter("@ngaspag", SqlDbType.Decimal)
        args(48).Value = lEntidad.ngaspag
        args(49) = New SqlParameter("@ndiaatr", SqlDbType.Decimal)
        args(49).Value = lEntidad.ndiaatr
        args(50) = New SqlParameter("@ndiaant", SqlDbType.Decimal)
        args(50).Value = lEntidad.ndiaant
        args(51) = New SqlParameter("@natracu", SqlDbType.Decimal)
        args(51).Value = lEntidad.natracu
        args(52) = New SqlParameter("@natrmax", SqlDbType.Decimal)
        args(52).Value = lEntidad.natrmax
        args(53) = New SqlParameter("@ccondic", SqlDbType.VarChar)
        args(53).Value = lEntidad.ccondic
        args(54) = New SqlParameter("@dultpag", SqlDbType.DateTime)
        args(54).Value = lEntidad.dultpag
        args(55) = New SqlParameter("@dfecter", SqlDbType.DateTime)
        args(55).Value = lEntidad.dfecter
        args(56) = New SqlParameter("@ccodrec", SqlDbType.VarChar)
        args(56).Value = lEntidad.ccodrec
        args(57) = New SqlParameter("@nnota1", SqlDbType.Decimal)
        args(57).Value = lEntidad.nnota1
        args(58) = New SqlParameter("@nnota2", SqlDbType.Decimal)
        args(58).Value = lEntidad.nnota2
        args(59) = New SqlParameter("@cmarjud", SqlDbType.VarChar)
        args(59).Value = lEntidad.cmarjud
        args(60) = New SqlParameter("@ntipcam", SqlDbType.Decimal)
        args(60).Value = lEntidad.ntipcam
        args(61) = New SqlParameter("@lctaret", SqlDbType.Bit)
        args(61).Value = lEntidad.lctaret
        args(62) = New SqlParameter("@cclacre", SqlDbType.VarChar)
        args(62).Value = lEntidad.cclacre
        args(63) = New SqlParameter("@ccalif", SqlDbType.VarChar)
        args(63).Value = lEntidad.ccalif
        args(64) = New SqlParameter("@nsegvid", SqlDbType.Decimal)
        args(64).Value = lEntidad.nsegvid
        args(65) = New SqlParameter("@cnumexp", SqlDbType.VarChar)
        args(65).Value = lEntidad.cnumexp
        args(66) = New SqlParameter("@ccodrub", SqlDbType.VarChar)
        args(66).Value = lEntidad.ccodrub
        args(67) = New SqlParameter("@cregist", SqlDbType.VarChar)
        args(67).Value = lEntidad.cregist
        args(68) = New SqlParameter("@dfecadm", SqlDbType.DateTime)
        args(68).Value = lEntidad.dfecadm
        args(69) = New SqlParameter("@nintadm", SqlDbType.Decimal)
        args(69).Value = lEntidad.nintadm
        args(70) = New SqlParameter("@nmeses", SqlDbType.Decimal)
        args(70).Value = lEntidad.nmeses
        args(71) = New SqlParameter("@csececo", SqlDbType.VarChar)
        args(71).Value = lEntidad.csececo
        args(72) = New SqlParameter("@nciclo", SqlDbType.Decimal)
        args(72).Value = lEntidad.nciclo
        args(73) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(73).Value = lEntidad.ccodsol
        args(74) = New SqlParameter("@nmorak", SqlDbType.Decimal)
        args(74).Value = lEntidad.nmorak
        args(75) = New SqlParameter("@nahoprg", SqlDbType.Decimal)
        args(75).Value = lEntidad.nahoprg
        args(76) = New SqlParameter("@cliquid", SqlDbType.VarChar)
        args(76).Value = lEntidad.cliquid
        args(77) = New SqlParameter("@clineac", SqlDbType.VarChar)
        args(77).Value = lEntidad.clineac
        args(78) = New SqlParameter("@ncapoto", SqlDbType.Decimal)
        args(78).Value = lEntidad.ncapoto
        args(79) = New SqlParameter("@ccontra", SqlDbType.VarChar)
        args(79).Value = lEntidad.ccontra
        args(80) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(80).Value = lEntidad.dfectra
        args(81) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(81).Value = lEntidad.ccodusu
        args(82) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(82).Value = lEntidad.dfecmod
        args(83) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(83).Value = lEntidad.cflag
        args(84) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(84).Value = lEntidad.cflat
        args(85) = New SqlParameter("@nnumfal", SqlDbType.Decimal)
        args(85).Value = lEntidad.nnumfal
        args(86) = New SqlParameter("@ctipgar", SqlDbType.VarChar)
        args(86).Value = lEntidad.ctipgar
        args(87) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(87).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(88) = New SqlParameter("@coficina", SqlDbType.VarChar)
        args(88).Value = lEntidad.coficina
        args(89) = New SqlParameter("@ccargo", SqlDbType.VarChar)
        args(89).Value = lEntidad.ccargo
        args(90) = New SqlParameter("@lsegvid", SqlDbType.Bit)
        args(90).Value = lEntidad.lsegvid
        args(91) = New SqlParameter("@cprograma", SqlDbType.VarChar)
        args(91).Value = lEntidad.cprograma
        args(92) = New SqlParameter("@cfueing", SqlDbType.VarChar)
        args(92).Value = lEntidad.cfueing

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cremcre ")
        strSQL.Append(" ( ccodcta, ")
        strSQL.Append(" cCodofi, ")
        strSQL.Append(" ccodprd, ")
        strSQL.Append(" cmoneda, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" ccatego, ")
        strSQL.Append(" ccodfue, ")
        strSQL.Append(" ccodact, ")
        strSQL.Append(" ctipcre, ")
        strSQL.Append(" cdescre, ")
        strSQL.Append(" ctipcuo, ")
        strSQL.Append(" ctipper, ")
        strSQL.Append(" ntipperc, ")
        strSQL.Append(" cctapre, ")
        strSQL.Append(" cnorref, ")
        strSQL.Append(" ccodana, ")
        strSQL.Append(" dfecasi, ")
        strSQL.Append(" dfecsol, ")
        strSQL.Append(" nmonsol, ")
        strSQL.Append(" nmonsug, ")
        strSQL.Append(" ncuosug, ")
        strSQL.Append(" ndessug, ")
        strSQL.Append(" ndiasug, ")
        strSQL.Append(" ndiagra, ")
        strSQL.Append(" dfecapr, ")
        strSQL.Append(" dfecven, ")
        strSQL.Append(" nmonapr, ")
        strSQL.Append(" nmoncuo, ")
        strSQL.Append(" nintapr, ")
        strSQL.Append(" ncuoapr, ")
        strSQL.Append(" ndiaapr, ")
        strSQL.Append(" ndesapr, ")
        strSQL.Append(" cnrolin, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" ctipcon, ")
        strSQL.Append(" ccodapo, ")
        strSQL.Append(" dfecvig, ")
        strSQL.Append(" ndeseje, ")
        strSQL.Append(" ngastos, ")
        strSQL.Append(" ncappag, ")
        strSQL.Append(" nintpen, ")
        strSQL.Append(" nintcal, ")
        strSQL.Append(" nintpag, ")
        strSQL.Append(" nintmor, ")
        strSQL.Append(" nmorpag, ")
        strSQL.Append(" npagcta, ")
        strSQL.Append(" ncapdes, ")
        strSQL.Append(" ncapcal, ")
        strSQL.Append(" ngaspag, ")
        strSQL.Append(" ndiaatr, ")
        strSQL.Append(" ndiaant, ")
        strSQL.Append(" natracu, ")
        strSQL.Append(" natrmax, ")
        strSQL.Append(" ccondic, ")
        strSQL.Append(" dultpag, ")
        strSQL.Append(" dfecter, ")
        strSQL.Append(" ccodrec, ")
        strSQL.Append(" nnota1, ")
        strSQL.Append(" nnota2, ")
        strSQL.Append(" cmarjud, ")
        strSQL.Append(" ntipcam, ")
        strSQL.Append(" lctaret, ")
        strSQL.Append(" cclacre, ")
        strSQL.Append(" ccalif, ")
        strSQL.Append(" nsegvid, ")
        strSQL.Append(" cnumexp, ")
        strSQL.Append(" ccodrub, ")
        strSQL.Append(" cregist, ")
        strSQL.Append(" dfecadm, ")
        strSQL.Append(" nintadm, ")
        strSQL.Append(" nmeses, ")
        strSQL.Append(" csececo, ")
        strSQL.Append(" nciclo, ")
        strSQL.Append(" ccodsol, ")
        strSQL.Append(" nmorak, ")
        strSQL.Append(" nahoprg, ")
        strSQL.Append(" cliquid, ")
        strSQL.Append(" clineac, ")
        strSQL.Append(" ncapoto, ")
        strSQL.Append(" ccontra, ")
        strSQL.Append(" dfectra, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cflat, ")
        strSQL.Append(" nnumfal, ")
        strSQL.Append(" ctipgar, ")
        strSQL.Append(" coficina, ccargo, cfreccap, cfrecint, lsegvid,ccapacidad, canalisis, cprograma, cfueing) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ")
        strSQL.Append(" @cCodofi, ")
        strSQL.Append(" @ccodprd, ")
        strSQL.Append(" @cmoneda, ")
        strSQL.Append(" @cestado, ")
        strSQL.Append(" @ccodcli, ")
        strSQL.Append(" @ccatego, ")
        strSQL.Append(" @ccodfue, ")
        strSQL.Append(" @ccodact, ")
        strSQL.Append(" @ctipcre, ")
        strSQL.Append(" @cdescre, ")
        strSQL.Append(" @ctipcuo, ")
        strSQL.Append(" @ctipper, ")
        strSQL.Append(" @ntipperc, ")
        strSQL.Append(" @cctapre, ")
        strSQL.Append(" @cnorref, ")
        strSQL.Append(" @ccodana, ")
        strSQL.Append(" @dfecasi, ")
        strSQL.Append(" @dfecsol, ")
        strSQL.Append(" @nmonsol, ")
        strSQL.Append(" @nmonsug, ")
        strSQL.Append(" @ncuosug, ")
        strSQL.Append(" @ndessug, ")
        strSQL.Append(" @ndiasug, ")
        strSQL.Append(" @ndiagra, ")
        strSQL.Append(" @dfecapr, ")
        strSQL.Append(" @dfecven, ")
        strSQL.Append(" @nmonapr, ")
        strSQL.Append(" @nmoncuo, ")
        strSQL.Append(" @nintapr, ")
        strSQL.Append(" @ncuoapr, ")
        strSQL.Append(" @ndiaapr, ")
        strSQL.Append(" @ndesapr, ")
        strSQL.Append(" @cnrolin, ")
        strSQL.Append(" @ntasint, ")
        strSQL.Append(" @ctipcon, ")
        strSQL.Append(" @ccodapo, ")
        strSQL.Append(" @dfecvig, ")
        strSQL.Append(" @ndeseje, ")
        strSQL.Append(" @ngastos, ")
        strSQL.Append(" @ncappag, ")
        strSQL.Append(" @nintpen, ")
        strSQL.Append(" @nintcal, ")
        strSQL.Append(" @nintpag, ")
        strSQL.Append(" @nintmor, ")
        strSQL.Append(" @nmorpag, ")
        strSQL.Append(" @npagcta, ")
        strSQL.Append(" @ncapdes, ")
        strSQL.Append(" @ncapcal, ")
        strSQL.Append(" @ngaspag, ")
        strSQL.Append(" @ndiaatr, ")
        strSQL.Append(" @ndiaant, ")
        strSQL.Append(" @natracu, ")
        strSQL.Append(" @natrmax, ")
        strSQL.Append(" @ccondic, ")
        strSQL.Append(" @dultpag, ")
        strSQL.Append(" @dfecter, ")
        strSQL.Append(" @ccodrec, ")
        strSQL.Append(" @nnota1, ")
        strSQL.Append(" @nnota2, ")
        strSQL.Append(" @cmarjud, ")
        strSQL.Append(" @ntipcam, ")
        strSQL.Append(" @lctaret, ")
        strSQL.Append(" @cclacre, ")
        strSQL.Append(" @ccalif, ")
        strSQL.Append(" @nsegvid, ")
        strSQL.Append(" @cnumexp, ")
        strSQL.Append(" @ccodrub, ")
        strSQL.Append(" @cregist, ")
        strSQL.Append(" @dfecadm, ")
        strSQL.Append(" @nintadm, ")
        strSQL.Append(" @nmeses, ")
        strSQL.Append(" @csececo, ")
        strSQL.Append(" @nciclo, ")
        strSQL.Append(" @ccodsol, ")
        strSQL.Append(" @nmorak, ")
        strSQL.Append(" @nahoprg, ")
        strSQL.Append(" @cliquid, ")
        strSQL.Append(" @clineac, ")
        strSQL.Append(" @ncapoto, ")
        strSQL.Append(" @ccontra, ")
        strSQL.Append(" @dfectra, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @cflat, ")
        strSQL.Append(" @nnumfal, ")
        strSQL.Append(" @ctipgar, ")
        strSQL.Append(" @coficina, @ccargo, @cfreccap, @cfrecint, @lsegvid,'',@ccodana , @cprograma, @cfueing) ")

        Dim args(94) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(1).Value = lEntidad.cCodofi
        args(2) = New SqlParameter("@ccodprd", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodprd
        args(3) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(3).Value = lEntidad.cmoneda
        args(4) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(4).Value = lEntidad.cestado
        args(5) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodcli
        args(6) = New SqlParameter("@ccatego", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccatego
        args(7) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodfue
        args(8) = New SqlParameter("@ccodact", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodact
        args(9) = New SqlParameter("@ctipcre", SqlDbType.VarChar)
        args(9).Value = lEntidad.ctipcre
        args(10) = New SqlParameter("@cdescre", SqlDbType.VarChar)
        args(10).Value = lEntidad.cdescre
        args(11) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(11).Value = lEntidad.ctipcuo
        args(12) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(12).Value = lEntidad.ctipper
        args(13) = New SqlParameter("@ntipperc", SqlDbType.Decimal)
        args(13).Value = lEntidad.ntipperc
        args(14) = New SqlParameter("@cctapre", SqlDbType.VarChar)
        args(14).Value = lEntidad.cctapre
        args(15) = New SqlParameter("@cnorref", SqlDbType.VarChar)
        args(15).Value = lEntidad.cnorref
        args(16) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(16).Value = lEntidad.ccodana
        args(17) = New SqlParameter("@dfecasi", SqlDbType.DateTime)
        args(17).Value = lEntidad.dfecasi
        args(18) = New SqlParameter("@dfecsol", SqlDbType.DateTime)
        args(18).Value = lEntidad.dfecsol
        args(19) = New SqlParameter("@nmonsol", SqlDbType.Decimal)
        args(19).Value = lEntidad.nmonsol
        args(20) = New SqlParameter("@nmonsug", SqlDbType.Decimal)
        args(20).Value = lEntidad.nmonsug
        args(21) = New SqlParameter("@ncuosug", SqlDbType.Decimal)
        args(21).Value = lEntidad.ncuosug
        args(22) = New SqlParameter("@ndessug", SqlDbType.Decimal)
        args(22).Value = lEntidad.ndessug
        args(23) = New SqlParameter("@ndiasug", SqlDbType.Decimal)
        args(23).Value = lEntidad.ndiasug
        args(24) = New SqlParameter("@ndiagra", SqlDbType.Decimal)
        args(24).Value = lEntidad.ndiagra
        args(25) = New SqlParameter("@dfecapr", SqlDbType.DateTime)
        args(25).Value = lEntidad.dfecapr
        args(26) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(26).Value = lEntidad.dfecven
        args(27) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(27).Value = lEntidad.nmonapr
        args(28) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(28).Value = lEntidad.nmoncuo
        args(29) = New SqlParameter("@nintapr", SqlDbType.Decimal)
        args(29).Value = lEntidad.nintapr
        args(30) = New SqlParameter("@ncuoapr", SqlDbType.Decimal)
        args(30).Value = lEntidad.ncuoapr
        args(31) = New SqlParameter("@ndiaapr", SqlDbType.Decimal)
        args(31).Value = lEntidad.ndiaapr
        args(32) = New SqlParameter("@ndesapr", SqlDbType.Decimal)
        args(32).Value = lEntidad.ndesapr
        args(33) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(33).Value = lEntidad.cnrolin
        args(34) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(34).Value = lEntidad.ntasint
        args(35) = New SqlParameter("@ctipcon", SqlDbType.VarChar)
        args(35).Value = lEntidad.ctipcon
        args(36) = New SqlParameter("@ccodapo", SqlDbType.VarChar)
        args(36).Value = lEntidad.ccodapo
        args(37) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(37).Value = lEntidad.dfecvig
        args(38) = New SqlParameter("@ndeseje", SqlDbType.Decimal)
        args(38).Value = lEntidad.ndeseje
        args(39) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(39).Value = lEntidad.ngastos
        args(40) = New SqlParameter("@ncappag", SqlDbType.Decimal)
        args(40).Value = lEntidad.ncappag
        args(41) = New SqlParameter("@nintpen", SqlDbType.Decimal)
        args(41).Value = lEntidad.nintpen
        args(42) = New SqlParameter("@nintcal", SqlDbType.Decimal)
        args(42).Value = lEntidad.nintcal
        args(43) = New SqlParameter("@nintpag", SqlDbType.Decimal)
        args(43).Value = lEntidad.nintpag
        args(44) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(44).Value = lEntidad.nintmor
        args(45) = New SqlParameter("@nmorpag", SqlDbType.Decimal)
        args(45).Value = lEntidad.nmorpag
        args(46) = New SqlParameter("@npagcta", SqlDbType.Decimal)
        args(46).Value = lEntidad.npagcta
        args(47) = New SqlParameter("@ncapdes", SqlDbType.Decimal)
        args(47).Value = lEntidad.ncapdes
        args(48) = New SqlParameter("@ncapcal", SqlDbType.Decimal)
        args(48).Value = lEntidad.ncapcal
        args(49) = New SqlParameter("@ngaspag", SqlDbType.Decimal)
        args(49).Value = lEntidad.ngaspag
        args(50) = New SqlParameter("@ndiaatr", SqlDbType.Decimal)
        args(50).Value = lEntidad.ndiaatr
        args(51) = New SqlParameter("@ndiaant", SqlDbType.Decimal)
        args(51).Value = lEntidad.ndiaant
        args(52) = New SqlParameter("@natracu", SqlDbType.Decimal)
        args(52).Value = lEntidad.natracu
        args(53) = New SqlParameter("@natrmax", SqlDbType.Decimal)
        args(53).Value = lEntidad.natrmax
        args(54) = New SqlParameter("@ccondic", SqlDbType.VarChar)
        args(54).Value = lEntidad.ccondic
        args(55) = New SqlParameter("@dultpag", SqlDbType.DateTime)
        args(55).Value = lEntidad.dultpag
        args(56) = New SqlParameter("@dfecter", SqlDbType.DateTime)
        args(56).Value = lEntidad.dfecter
        args(57) = New SqlParameter("@ccodrec", SqlDbType.VarChar)
        args(57).Value = lEntidad.ccodrec
        args(58) = New SqlParameter("@nnota1", SqlDbType.VarChar)
        args(58).Value = lEntidad.nnota1
        args(59) = New SqlParameter("@nnota2", SqlDbType.Decimal)
        args(59).Value = lEntidad.nnota2
        args(60) = New SqlParameter("@cmarjud", SqlDbType.Decimal)
        args(60).Value = lEntidad.cmarjud
        args(61) = New SqlParameter("@ntipcam", SqlDbType.VarChar)
        args(61).Value = lEntidad.ntipcam
        args(62) = New SqlParameter("@lctaret", SqlDbType.Bit)
        args(62).Value = lEntidad.lctaret
        args(63) = New SqlParameter("@cclacre", SqlDbType.VarChar)
        args(63).Value = lEntidad.cclacre
        args(64) = New SqlParameter("@ccalif", SqlDbType.VarChar)
        args(64).Value = lEntidad.ccalif
        args(65) = New SqlParameter("@nsegvid", SqlDbType.VarChar)
        args(65).Value = lEntidad.nsegvid
        args(66) = New SqlParameter("@cnumexp", SqlDbType.VarChar)
        args(66).Value = lEntidad.cnumexp
        args(67) = New SqlParameter("@ccodrub", SqlDbType.VarChar)
        args(67).Value = lEntidad.ccodrub
        args(68) = New SqlParameter("@cregist", SqlDbType.VarChar)
        args(68).Value = lEntidad.cregist
        args(69) = New SqlParameter("@dfecadm", SqlDbType.DateTime)
        args(69).Value = lEntidad.dfecadm
        args(70) = New SqlParameter("@nintadm", SqlDbType.Decimal)
        args(70).Value = lEntidad.nintadm
        args(71) = New SqlParameter("@nmeses", SqlDbType.Decimal)
        args(71).Value = lEntidad.nmeses
        args(72) = New SqlParameter("@csececo", SqlDbType.VarChar)
        args(72).Value = lEntidad.csececo
        args(73) = New SqlParameter("@nciclo", SqlDbType.Decimal)
        args(73).Value = lEntidad.nciclo
        args(74) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(74).Value = lEntidad.ccodsol
        args(75) = New SqlParameter("@nmorak", SqlDbType.Decimal)
        args(75).Value = lEntidad.nmorak
        args(76) = New SqlParameter("@nahoprg", SqlDbType.Decimal)
        args(76).Value = lEntidad.nahoprg
        args(77) = New SqlParameter("@cliquid", SqlDbType.VarChar)
        args(77).Value = lEntidad.cliquid
        args(78) = New SqlParameter("@clineac", SqlDbType.VarChar)
        args(78).Value = lEntidad.clineac
        args(79) = New SqlParameter("@ncapoto", SqlDbType.Decimal)
        args(79).Value = lEntidad.ncapoto
        args(80) = New SqlParameter("@ccontra", SqlDbType.VarChar)
        args(80).Value = lEntidad.ccontra
        args(81) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(81).Value = lEntidad.dfectra
        args(82) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(82).Value = lEntidad.ccodusu
        args(83) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(83).Value = lEntidad.dfecmod
        args(84) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(84).Value = lEntidad.cflag
        args(85) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(85).Value = lEntidad.cflat
        args(86) = New SqlParameter("@nnumfal", SqlDbType.Decimal)
        args(86).Value = lEntidad.nnumfal
        args(87) = New SqlParameter("@ctipgar", SqlDbType.VarChar)
        args(87).Value = lEntidad.ctipgar
        args(88) = New SqlParameter("@coficina", SqlDbType.VarChar)
        args(88).Value = lEntidad.coficina
        args(89) = New SqlParameter("@ccargo", SqlDbType.VarChar)
        args(89).Value = lEntidad.ccargo
        args(90) = New SqlParameter("@cfreccap", SqlDbType.VarChar)
        args(90).Value = lEntidad.cfreccap
        args(91) = New SqlParameter("@cfrecint", SqlDbType.VarChar)
        args(91).Value = lEntidad.cfrecint
        args(92) = New SqlParameter("@lsegvid", SqlDbType.Bit)
        args(92).Value = lEntidad.lsegvid
        args(93) = New SqlParameter("@cprograma", SqlDbType.VarChar)
        args(93).Value = lEntidad.cprograma
        args(94) = New SqlParameter("@cfueing", SqlDbType.VarChar)
        args(94).Value = lEntidad.cfueing

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cremcre ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cCodofi = IIf(.Item("cCodofi") Is DBNull.Value, Nothing, .Item("cCodofi"))
                lEntidad.ccodprd = IIf(.Item("ccodprd") Is DBNull.Value, Nothing, .Item("ccodprd"))
                lEntidad.cmoneda = IIf(.Item("cmoneda") Is DBNull.Value, Nothing, .Item("cmoneda"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.ccatego = IIf(.Item("ccatego") Is DBNull.Value, Nothing, .Item("ccatego"))
                lEntidad.ccodfue = IIf(.Item("ccodfue") Is DBNull.Value, Nothing, .Item("ccodfue"))
                lEntidad.ccodact = IIf(.Item("ccodact") Is DBNull.Value, Nothing, .Item("ccodact"))
                lEntidad.ctipcre = IIf(.Item("ctipcre") Is DBNull.Value, Nothing, .Item("ctipcre"))
                lEntidad.cdescre = IIf(.Item("cdescre") Is DBNull.Value, Nothing, .Item("cdescre"))
                lEntidad.ctipcuo = IIf(.Item("ctipcuo") Is DBNull.Value, Nothing, .Item("ctipcuo"))
                lEntidad.ctipper = IIf(.Item("ctipper") Is DBNull.Value, Nothing, .Item("ctipper"))
                lEntidad.ntipperc = IIf(.Item("ntipperc") Is DBNull.Value, Nothing, .Item("ntipperc"))
                lEntidad.cctapre = IIf(.Item("cctapre") Is DBNull.Value, Nothing, .Item("cctapre"))
                lEntidad.cnorref = IIf(.Item("cnorref") Is DBNull.Value, Nothing, .Item("cnorref"))
                lEntidad.ccodana = IIf(.Item("ccodana") Is DBNull.Value, Nothing, .Item("ccodana"))
                lEntidad.dfecasi = IIf(.Item("dfecasi") Is DBNull.Value, Nothing, .Item("dfecasi"))
                lEntidad.dfecsol = IIf(.Item("dfecsol") Is DBNull.Value, Nothing, .Item("dfecsol"))
                lEntidad.nmonsol = IIf(.Item("nmonsol") Is DBNull.Value, Nothing, .Item("nmonsol"))
                lEntidad.nmonsug = IIf(.Item("nmonsug") Is DBNull.Value, Nothing, .Item("nmonsug"))
                lEntidad.ncuosug = IIf(.Item("ncuosug") Is DBNull.Value, Nothing, .Item("ncuosug"))
                lEntidad.ndessug = IIf(.Item("ndessug") Is DBNull.Value, Nothing, .Item("ndessug"))
                lEntidad.ndiasug = IIf(.Item("ndiasug") Is DBNull.Value, Nothing, .Item("ndiasug"))
                lEntidad.ndiagra = IIf(.Item("ndiagra") Is DBNull.Value, Nothing, .Item("ndiagra"))
                lEntidad.dfecapr = IIf(.Item("dfecapr") Is DBNull.Value, Nothing, .Item("dfecapr"))
                lEntidad.dfecven = IIf(.Item("dfecven") Is DBNull.Value, Nothing, .Item("dfecven"))
                lEntidad.nmonapr = IIf(.Item("nmonapr") Is DBNull.Value, Nothing, .Item("nmonapr"))
                lEntidad.nmoncuo = IIf(.Item("nmoncuo") Is DBNull.Value, Nothing, .Item("nmoncuo"))
                lEntidad.nintapr = IIf(.Item("nintapr") Is DBNull.Value, Nothing, .Item("nintapr"))
                lEntidad.ncuoapr = IIf(.Item("ncuoapr") Is DBNull.Value, Nothing, .Item("ncuoapr"))
                lEntidad.ndiaapr = IIf(.Item("ndiaapr") Is DBNull.Value, Nothing, .Item("ndiaapr"))
                lEntidad.ndesapr = IIf(.Item("ndesapr") Is DBNull.Value, Nothing, .Item("ndesapr"))
                lEntidad.cnrolin = IIf(.Item("cnrolin") Is DBNull.Value, Nothing, .Item("cnrolin"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.ctipcon = IIf(.Item("ctipcon") Is DBNull.Value, Nothing, .Item("ctipcon"))
                lEntidad.ccodapo = IIf(.Item("ccodapo") Is DBNull.Value, Nothing, .Item("ccodapo"))
                lEntidad.dfecvig = IIf(.Item("dfecvig") Is DBNull.Value, Nothing, .Item("dfecvig"))
                lEntidad.ndeseje = IIf(.Item("ndeseje") Is DBNull.Value, Nothing, .Item("ndeseje"))
                lEntidad.ngastos = IIf(.Item("ngastos") Is DBNull.Value, Nothing, .Item("ngastos"))
                lEntidad.ncappag = IIf(.Item("ncappag") Is DBNull.Value, Nothing, .Item("ncappag"))
                lEntidad.nintpen = IIf(.Item("nintpen") Is DBNull.Value, Nothing, .Item("nintpen"))
                lEntidad.nintcal = IIf(.Item("nintcal") Is DBNull.Value, Nothing, .Item("nintcal"))
                lEntidad.nintpag = IIf(.Item("nintpag") Is DBNull.Value, Nothing, .Item("nintpag"))
                lEntidad.nintmor = IIf(.Item("nintmor") Is DBNull.Value, Nothing, .Item("nintmor"))
                lEntidad.nmorpag = IIf(.Item("nmorpag") Is DBNull.Value, Nothing, .Item("nmorpag"))
                lEntidad.npagcta = IIf(.Item("npagcta") Is DBNull.Value, Nothing, .Item("npagcta"))
                lEntidad.ncapdes = IIf(.Item("ncapdes") Is DBNull.Value, Nothing, .Item("ncapdes"))
                lEntidad.ncapcal = IIf(.Item("ncapcal") Is DBNull.Value, Nothing, .Item("ncapcal"))
                lEntidad.ngaspag = IIf(.Item("ngaspag") Is DBNull.Value, Nothing, .Item("ngaspag"))
                lEntidad.ndiaatr = IIf(.Item("ndiaatr") Is DBNull.Value, Nothing, .Item("ndiaatr"))
                lEntidad.ndiaant = IIf(.Item("ndiaant") Is DBNull.Value, Nothing, .Item("ndiaant"))
                lEntidad.natracu = IIf(.Item("natracu") Is DBNull.Value, Nothing, .Item("natracu"))
                lEntidad.natrmax = IIf(.Item("natrmax") Is DBNull.Value, Nothing, .Item("natrmax"))
                lEntidad.ccondic = IIf(.Item("ccondic") Is DBNull.Value, Nothing, .Item("ccondic"))
                lEntidad.dultpag = IIf(.Item("dultpag") Is DBNull.Value, Nothing, .Item("dultpag"))
                lEntidad.dfecter = IIf(.Item("dfecter") Is DBNull.Value, Nothing, .Item("dfecter"))
                lEntidad.ccodrec = IIf(.Item("ccodrec") Is DBNull.Value, Nothing, .Item("ccodrec"))
                lEntidad.nnota1 = IIf(.Item("nnota1") Is DBNull.Value, Nothing, .Item("nnota1"))
                lEntidad.nnota2 = IIf(.Item("nnota2") Is DBNull.Value, Nothing, .Item("nnota2"))
                lEntidad.cmarjud = IIf(.Item("cmarjud") Is DBNull.Value, Nothing, .Item("cmarjud"))
                lEntidad.ntipcam = IIf(.Item("ntipcam") Is DBNull.Value, Nothing, .Item("ntipcam"))
                lEntidad.lctaret = IIf(.Item("lctaret") Is DBNull.Value, Nothing, .Item("lctaret"))
                lEntidad.cclacre = IIf(.Item("cclacre") Is DBNull.Value, Nothing, .Item("cclacre"))
                lEntidad.ccalif = IIf(.Item("ccalif") Is DBNull.Value, Nothing, .Item("ccalif"))
                lEntidad.nsegvid = IIf(.Item("nsegvid") Is DBNull.Value, Nothing, .Item("nsegvid"))
                lEntidad.cnumexp = IIf(.Item("cnumexp") Is DBNull.Value, Nothing, .Item("cnumexp"))
                lEntidad.ccodrub = IIf(.Item("ccodrub") Is DBNull.Value, Nothing, .Item("ccodrub"))
                lEntidad.cregist = IIf(.Item("cregist") Is DBNull.Value, Nothing, .Item("cregist"))
                lEntidad.dfecadm = IIf(.Item("dfecadm") Is DBNull.Value, Nothing, .Item("dfecadm"))
                lEntidad.nintadm = IIf(.Item("nintadm") Is DBNull.Value, Nothing, .Item("nintadm"))
                lEntidad.nmeses = IIf(.Item("nmeses") Is DBNull.Value, Nothing, .Item("nmeses"))
                lEntidad.csececo = IIf(.Item("csececo") Is DBNull.Value, Nothing, .Item("csececo"))
                lEntidad.nciclo = IIf(.Item("nciclo") Is DBNull.Value, Nothing, .Item("nciclo"))
                lEntidad.ccodsol = IIf(.Item("ccodsol") Is DBNull.Value, Nothing, .Item("ccodsol"))
                lEntidad.nmorak = IIf(.Item("nmorak") Is DBNull.Value, Nothing, .Item("nmorak"))
                lEntidad.nahoprg = IIf(.Item("nahoprg") Is DBNull.Value, Nothing, .Item("nahoprg"))
                lEntidad.cliquid = IIf(.Item("cliquid") Is DBNull.Value, Nothing, .Item("cliquid"))
                lEntidad.clineac = IIf(.Item("clineac") Is DBNull.Value, Nothing, .Item("clineac"))
                lEntidad.ncapoto = IIf(.Item("ncapoto") Is DBNull.Value, Nothing, .Item("ncapoto"))
                lEntidad.ccontra = IIf(.Item("ccontra") Is DBNull.Value, "", .Item("ccontra"))
                lEntidad.dfectra = IIf(.Item("dfectra") Is DBNull.Value, Nothing, .Item("dfectra"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cflat = IIf(.Item("cflat") Is DBNull.Value, Nothing, .Item("cflat"))
                lEntidad.nnumfal = IIf(.Item("nnumfal") Is DBNull.Value, Nothing, .Item("nnumfal"))
                lEntidad.ctipgar = IIf(.Item("ctipgar") Is DBNull.Value, "", .Item("ctipgar"))
                lEntidad.cnrodes = IIf(.Item("cnrodes") Is DBNull.Value, Nothing, .Item("cnrodes"))
                lEntidad.coficina = IIf(.Item("coficina") Is DBNull.Value, Nothing, .Item("coficina"))
                lEntidad.cfreccap = IIf(.Item("cfreccap") Is DBNull.Value, Nothing, .Item("cfreccap"))
                lEntidad.cfrecint = IIf(.Item("cfrecint") Is DBNull.Value, Nothing, .Item("cfrecint"))
                lEntidad.lsegvid = IIf(.Item("lsegvid") Is DBNull.Value, Nothing, .Item("lsegvid"))
                lEntidad.ccodpag = IIf(.Item("ccodpag") Is DBNull.Value, Nothing, .Item("ccodpag"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cremcre
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcta),0) + 1 ")
        strSQL.Append(" FROM cremcre ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function
    Public Function contratoProducto(ByVal ccodcta As String) As String
        Dim strSQL As New StringBuilder
        Dim cnrolin, contrato As String
        strSQL.Append("SELECT cnrolin from cremcre where ccodcta = @ccodcta ")
        Dim ds As SqlDataReader


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        ds = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Try
            Do While ds.Read()
                cnrolin = ds("cnrolin")
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            ds.Close()
        End Try

        'limitar a este producto por ahora
        If (cnrolin = "0002300" Or cnrolin = "0002500") Then
            contrato = "Documentos\Creditos\Autoproduccion\Contrato.docx"
        Else
            contrato = "Documentos\Creditos\CONTRATO_GRUPAL.docx"
        End If
        Return contrato
    End Function

    Public Function ObtenerListaPorID() As listacremcre

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacremcre

        Try
            Do While dr.Read()
                Dim mEntidad As New cremcre
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cCodofi = IIf(dr("cCodofi") Is DBNull.Value, Nothing, dr("cCodofi"))
                mEntidad.ccodprd = IIf(dr("ccodprd") Is DBNull.Value, Nothing, dr("ccodprd"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccatego = IIf(dr("ccatego") Is DBNull.Value, Nothing, dr("ccatego"))
                mEntidad.ccodfue = IIf(dr("ccodfue") Is DBNull.Value, Nothing, dr("ccodfue"))
                mEntidad.ccodact = IIf(dr("ccodact") Is DBNull.Value, Nothing, dr("ccodact"))
                mEntidad.ctipcre = IIf(dr("ctipcre") Is DBNull.Value, Nothing, dr("ctipcre"))
                mEntidad.cdescre = IIf(dr("cdescre") Is DBNull.Value, Nothing, dr("cdescre"))
                mEntidad.ctipcuo = IIf(dr("ctipcuo") Is DBNull.Value, Nothing, dr("ctipcuo"))
                mEntidad.ctipper = IIf(dr("ctipper") Is DBNull.Value, Nothing, dr("ctipper"))
                mEntidad.ntipperc = IIf(dr("ntipperc") Is DBNull.Value, Nothing, dr("ntipperc"))
                mEntidad.cctapre = IIf(dr("cctapre") Is DBNull.Value, Nothing, dr("cctapre"))
                mEntidad.cnorref = IIf(dr("cnorref") Is DBNull.Value, Nothing, dr("cnorref"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.dfecasi = IIf(dr("dfecasi") Is DBNull.Value, Nothing, dr("dfecasi"))
                mEntidad.dfecsol = IIf(dr("dfecsol") Is DBNull.Value, Nothing, dr("dfecsol"))
                mEntidad.nmonsol = IIf(dr("nmonsol") Is DBNull.Value, Nothing, dr("nmonsol"))
                mEntidad.nmonsug = IIf(dr("nmonsug") Is DBNull.Value, Nothing, dr("nmonsug"))
                mEntidad.ncuosug = IIf(dr("ncuosug") Is DBNull.Value, Nothing, dr("ncuosug"))
                mEntidad.ndessug = IIf(dr("ndessug") Is DBNull.Value, Nothing, dr("ndessug"))
                mEntidad.ndiasug = IIf(dr("ndiasug") Is DBNull.Value, Nothing, dr("ndiasug"))
                mEntidad.ndiagra = IIf(dr("ndiagra") Is DBNull.Value, Nothing, dr("ndiagra"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nmoncuo = IIf(dr("nmoncuo") Is DBNull.Value, Nothing, dr("nmoncuo"))
                mEntidad.nintapr = IIf(dr("nintapr") Is DBNull.Value, Nothing, dr("nintapr"))
                mEntidad.ncuoapr = IIf(dr("ncuoapr") Is DBNull.Value, Nothing, dr("ncuoapr"))
                mEntidad.ndiaapr = IIf(dr("ndiaapr") Is DBNull.Value, Nothing, dr("ndiaapr"))
                mEntidad.ndesapr = IIf(dr("ndesapr") Is DBNull.Value, Nothing, dr("ndesapr"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcon = IIf(dr("ctipcon") Is DBNull.Value, Nothing, dr("ctipcon"))
                mEntidad.ccodapo = IIf(dr("ccodapo") Is DBNull.Value, Nothing, dr("ccodapo"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.ndeseje = IIf(dr("ndeseje") Is DBNull.Value, Nothing, dr("ndeseje"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ncappag = IIf(dr("ncappag") Is DBNull.Value, Nothing, dr("ncappag"))
                mEntidad.nintpen = IIf(dr("nintpen") Is DBNull.Value, Nothing, dr("nintpen"))
                mEntidad.nintcal = IIf(dr("nintcal") Is DBNull.Value, Nothing, dr("nintcal"))
                mEntidad.nintpag = IIf(dr("nintpag") Is DBNull.Value, Nothing, dr("nintpag"))
                mEntidad.nintmor = IIf(dr("nintmor") Is DBNull.Value, Nothing, dr("nintmor"))
                mEntidad.nmorpag = IIf(dr("nmorpag") Is DBNull.Value, Nothing, dr("nmorpag"))
                mEntidad.npagcta = IIf(dr("npagcta") Is DBNull.Value, Nothing, dr("npagcta"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                mEntidad.ncapcal = IIf(dr("ncapcal") Is DBNull.Value, Nothing, dr("ncapcal"))
                mEntidad.ngaspag = IIf(dr("ngaspag") Is DBNull.Value, Nothing, dr("ngaspag"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaant = IIf(dr("ndiaant") Is DBNull.Value, Nothing, dr("ndiaant"))
                mEntidad.natracu = IIf(dr("natracu") Is DBNull.Value, Nothing, dr("natracu"))
                mEntidad.natrmax = IIf(dr("natrmax") Is DBNull.Value, Nothing, dr("natrmax"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.dultpag = IIf(dr("dultpag") Is DBNull.Value, Nothing, dr("dultpag"))
                mEntidad.dfecter = IIf(dr("dfecter") Is DBNull.Value, Nothing, dr("dfecter"))
                mEntidad.ccodrec = IIf(dr("ccodrec") Is DBNull.Value, Nothing, dr("ccodrec"))
                mEntidad.nnota1 = IIf(dr("nnota1") Is DBNull.Value, Nothing, dr("nnota1"))
                mEntidad.nnota2 = IIf(dr("nnota2") Is DBNull.Value, Nothing, dr("nnota2"))
                mEntidad.cmarjud = IIf(dr("cmarjud") Is DBNull.Value, Nothing, dr("cmarjud"))
                mEntidad.ntipcam = IIf(dr("ntipcam") Is DBNull.Value, Nothing, dr("ntipcam"))
                mEntidad.lctaret = IIf(dr("lctaret") Is DBNull.Value, Nothing, dr("lctaret"))
                mEntidad.cclacre = IIf(dr("cclacre") Is DBNull.Value, Nothing, dr("cclacre"))
                mEntidad.ccalif = IIf(dr("ccalif") Is DBNull.Value, Nothing, dr("ccalif"))
                mEntidad.nsegvid = IIf(dr("nsegvid") Is DBNull.Value, Nothing, dr("nsegvid"))
                mEntidad.cnumexp = IIf(dr("cnumexp") Is DBNull.Value, Nothing, dr("cnumexp"))
                mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
                mEntidad.cregist = IIf(dr("cregist") Is DBNull.Value, Nothing, dr("cregist"))
                mEntidad.dfecadm = IIf(dr("dfecadm") Is DBNull.Value, Nothing, dr("dfecadm"))
                mEntidad.nintadm = IIf(dr("nintadm") Is DBNull.Value, Nothing, dr("nintadm"))
                mEntidad.nmeses = IIf(dr("nmeses") Is DBNull.Value, Nothing, dr("nmeses"))
                mEntidad.csececo = IIf(dr("csececo") Is DBNull.Value, Nothing, dr("csececo"))
                mEntidad.nciclo = IIf(dr("nciclo") Is DBNull.Value, Nothing, dr("nciclo"))
                mEntidad.ccodsol = IIf(dr("ccodsol") Is DBNull.Value, Nothing, dr("ccodsol"))
                mEntidad.nmorak = IIf(dr("nmorak") Is DBNull.Value, Nothing, dr("nmorak"))
                mEntidad.nahoprg = IIf(dr("nahoprg") Is DBNull.Value, Nothing, dr("nahoprg"))
                mEntidad.cliquid = IIf(dr("cliquid") Is DBNull.Value, Nothing, dr("cliquid"))
                mEntidad.clineac = IIf(dr("clineac") Is DBNull.Value, Nothing, dr("clineac"))
                mEntidad.ncapoto = IIf(dr("ncapoto") Is DBNull.Value, Nothing, dr("ncapoto"))
                mEntidad.ccontra = IIf(dr("ccontra") Is DBNull.Value, Nothing, dr("ccontra"))
                mEntidad.dfectra = IIf(dr("dfectra") Is DBNull.Value, Nothing, dr("dfectra"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cflat = IIf(dr("cflat") Is DBNull.Value, Nothing, dr("cflat"))
                mEntidad.nnumfal = IIf(dr("nnumfal") Is DBNull.Value, Nothing, dr("nnumfal"))
                mEntidad.ctipgar = IIf(dr("ctipgar") Is DBNull.Value, Nothing, dr("ctipgar"))
                mEntidad.coficina = IIf(dr("coficina") Is DBNull.Value, Nothing, dr("coficina"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorcredito(ByVal ccodcta As String) As listacremcre
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE ccodcta = @ccodcta")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacremcre

        Try
            Do While dr.Read()
                Dim mEntidad As New cremcre
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cCodofi = IIf(dr("cCodofi") Is DBNull.Value, Nothing, dr("cCodofi"))
                mEntidad.ccodprd = IIf(dr("ccodprd") Is DBNull.Value, Nothing, dr("ccodprd"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccatego = IIf(dr("ccatego") Is DBNull.Value, Nothing, dr("ccatego"))
                mEntidad.ccodfue = IIf(dr("ccodfue") Is DBNull.Value, Nothing, dr("ccodfue"))
                mEntidad.ccodact = IIf(dr("ccodact") Is DBNull.Value, Nothing, dr("ccodact"))
                mEntidad.ctipcre = IIf(dr("ctipcre") Is DBNull.Value, Nothing, dr("ctipcre"))
                mEntidad.cdescre = IIf(dr("cdescre") Is DBNull.Value, Nothing, dr("cdescre"))
                mEntidad.ctipcuo = IIf(dr("ctipcuo") Is DBNull.Value, Nothing, dr("ctipcuo"))
                mEntidad.ctipper = IIf(dr("ctipper") Is DBNull.Value, Nothing, dr("ctipper"))
                mEntidad.ntipperc = IIf(dr("ntipperc") Is DBNull.Value, Nothing, dr("ntipperc"))
                mEntidad.cctapre = IIf(dr("cctapre") Is DBNull.Value, Nothing, dr("cctapre"))
                mEntidad.cnorref = IIf(dr("cnorref") Is DBNull.Value, Nothing, dr("cnorref"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.dfecasi = IIf(dr("dfecasi") Is DBNull.Value, Nothing, dr("dfecasi"))
                mEntidad.dfecsol = IIf(dr("dfecsol") Is DBNull.Value, Nothing, dr("dfecsol"))
                mEntidad.nmonsol = IIf(dr("nmonsol") Is DBNull.Value, Nothing, dr("nmonsol"))
                mEntidad.nmonsug = IIf(dr("nmonsug") Is DBNull.Value, Nothing, dr("nmonsug"))
                mEntidad.ncuosug = IIf(dr("ncuosug") Is DBNull.Value, Nothing, dr("ncuosug"))
                mEntidad.ndessug = IIf(dr("ndessug") Is DBNull.Value, Nothing, dr("ndessug"))
                mEntidad.ndiasug = IIf(dr("ndiasug") Is DBNull.Value, Nothing, dr("ndiasug"))
                mEntidad.ndiagra = IIf(dr("ndiagra") Is DBNull.Value, Nothing, dr("ndiagra"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nmoncuo = IIf(dr("nmoncuo") Is DBNull.Value, Nothing, dr("nmoncuo"))
                mEntidad.nintapr = IIf(dr("nintapr") Is DBNull.Value, Nothing, dr("nintapr"))
                mEntidad.ncuoapr = IIf(dr("ncuoapr") Is DBNull.Value, Nothing, dr("ncuoapr"))
                mEntidad.ndiaapr = IIf(dr("ndiaapr") Is DBNull.Value, Nothing, dr("ndiaapr"))
                mEntidad.ndesapr = IIf(dr("ndesapr") Is DBNull.Value, Nothing, dr("ndesapr"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcon = IIf(dr("ctipcon") Is DBNull.Value, Nothing, dr("ctipcon"))
                mEntidad.ccodapo = IIf(dr("ccodapo") Is DBNull.Value, Nothing, dr("ccodapo"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.ndeseje = IIf(dr("ndeseje") Is DBNull.Value, Nothing, dr("ndeseje"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ncappag = IIf(dr("ncappag") Is DBNull.Value, Nothing, dr("ncappag"))
                mEntidad.nintpen = IIf(dr("nintpen") Is DBNull.Value, Nothing, dr("nintpen"))
                mEntidad.nintcal = IIf(dr("nintcal") Is DBNull.Value, Nothing, dr("nintcal"))
                mEntidad.nintpag = IIf(dr("nintpag") Is DBNull.Value, Nothing, dr("nintpag"))
                mEntidad.nintmor = IIf(dr("nintmor") Is DBNull.Value, Nothing, dr("nintmor"))
                mEntidad.nmorpag = IIf(dr("nmorpag") Is DBNull.Value, Nothing, dr("nmorpag"))
                mEntidad.npagcta = IIf(dr("npagcta") Is DBNull.Value, Nothing, dr("npagcta"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                mEntidad.ncapcal = IIf(dr("ncapcal") Is DBNull.Value, Nothing, dr("ncapcal"))
                mEntidad.ngaspag = IIf(dr("ngaspag") Is DBNull.Value, Nothing, dr("ngaspag"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaant = IIf(dr("ndiaant") Is DBNull.Value, Nothing, dr("ndiaant"))
                mEntidad.natracu = IIf(dr("natracu") Is DBNull.Value, Nothing, dr("natracu"))
                mEntidad.natrmax = IIf(dr("natrmax") Is DBNull.Value, Nothing, dr("natrmax"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.dultpag = IIf(dr("dultpag") Is DBNull.Value, Nothing, dr("dultpag"))
                mEntidad.dfecter = IIf(dr("dfecter") Is DBNull.Value, Nothing, dr("dfecter"))
                mEntidad.ccodrec = IIf(dr("ccodrec") Is DBNull.Value, Nothing, dr("ccodrec"))
                mEntidad.nnota1 = IIf(dr("nnota1") Is DBNull.Value, Nothing, dr("nnota1"))
                mEntidad.nnota2 = IIf(dr("nnota2") Is DBNull.Value, Nothing, dr("nnota2"))
                mEntidad.cmarjud = IIf(dr("cmarjud") Is DBNull.Value, Nothing, dr("cmarjud"))
                mEntidad.ntipcam = IIf(dr("ntipcam") Is DBNull.Value, Nothing, dr("ntipcam"))
                mEntidad.lctaret = IIf(dr("lctaret") Is DBNull.Value, Nothing, dr("lctaret"))
                mEntidad.cclacre = IIf(dr("cclacre") Is DBNull.Value, Nothing, dr("cclacre"))
                mEntidad.ccalif = IIf(dr("ccalif") Is DBNull.Value, Nothing, dr("ccalif"))
                mEntidad.nsegvid = IIf(dr("nsegvid") Is DBNull.Value, Nothing, dr("nsegvid"))
                mEntidad.cnumexp = IIf(dr("cnumexp") Is DBNull.Value, Nothing, dr("cnumexp"))
                mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
                mEntidad.cregist = IIf(dr("cregist") Is DBNull.Value, Nothing, dr("cregist"))
                mEntidad.dfecadm = IIf(dr("dfecadm") Is DBNull.Value, Nothing, dr("dfecadm"))
                mEntidad.nintadm = IIf(dr("nintadm") Is DBNull.Value, Nothing, dr("nintadm"))
                mEntidad.nmeses = IIf(dr("nmeses") Is DBNull.Value, Nothing, dr("nmeses"))
                mEntidad.csececo = IIf(dr("csececo") Is DBNull.Value, Nothing, dr("csececo"))
                mEntidad.nciclo = IIf(dr("nciclo") Is DBNull.Value, Nothing, dr("nciclo"))
                mEntidad.ccodsol = IIf(dr("ccodsol") Is DBNull.Value, Nothing, dr("ccodsol"))
                mEntidad.nmorak = IIf(dr("nmorak") Is DBNull.Value, Nothing, dr("nmorak"))
                mEntidad.nahoprg = IIf(dr("nahoprg") Is DBNull.Value, Nothing, dr("nahoprg"))
                mEntidad.cliquid = IIf(dr("cliquid") Is DBNull.Value, Nothing, dr("cliquid"))
                mEntidad.clineac = IIf(dr("clineac") Is DBNull.Value, Nothing, dr("clineac"))
                mEntidad.ncapoto = IIf(dr("ncapoto") Is DBNull.Value, Nothing, dr("ncapoto"))
                mEntidad.ccontra = IIf(dr("ccontra") Is DBNull.Value, Nothing, dr("ccontra"))
                mEntidad.dfectra = IIf(dr("dfectra") Is DBNull.Value, Nothing, dr("dfectra"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cflat = IIf(dr("cflat") Is DBNull.Value, Nothing, dr("cflat"))
                mEntidad.nnumfal = IIf(dr("nnumfal") Is DBNull.Value, Nothing, dr("nnumfal"))
                mEntidad.ctipgar = IIf(dr("ctipgar") Is DBNull.Value, Nothing, dr("ctipgar"))
                mEntidad.coficina = IIf(dr("coficina") Is DBNull.Value, Nothing, dr("coficina"))
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
        tables(0) = New String("cremcre")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" cCodofi, ")
        strSQL.Append(" ccodprd, ")
        strSQL.Append(" cmoneda, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" ccatego, ")
        strSQL.Append(" ccodfue, ")
        strSQL.Append(" ccodact, ")
        strSQL.Append(" ctipcre, ")
        strSQL.Append(" cdescre, ")
        strSQL.Append(" ctipcuo, ")
        strSQL.Append(" ctipper, ")
        strSQL.Append(" ntipperc, ")
        strSQL.Append(" cctapre, ")
        strSQL.Append(" cnorref, ")
        strSQL.Append(" ccodana, ")
        strSQL.Append(" dfecasi, ")
        strSQL.Append(" dfecsol, ")
        strSQL.Append(" nmonsol, ")
        strSQL.Append(" nmonsug, ")
        strSQL.Append(" ncuosug, ")
        strSQL.Append(" ndessug, ")
        strSQL.Append(" ndiasug, ")
        strSQL.Append(" ndiagra, ")
        strSQL.Append(" dfecapr, ")
        strSQL.Append(" dfecven, ")
        strSQL.Append(" nmonapr, ")
        strSQL.Append(" nmoncuo, ")
        strSQL.Append(" nintapr, ")
        strSQL.Append(" ncuoapr, ")
        strSQL.Append(" ndiaapr, ")
        strSQL.Append(" ndesapr, ")
        strSQL.Append(" cnrolin, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" ctipcon, ")
        strSQL.Append(" ccodapo, ")
        strSQL.Append(" dfecvig, ")
        strSQL.Append(" ndeseje, ")
        strSQL.Append(" ngastos, ")
        strSQL.Append(" ncappag, ")
        strSQL.Append(" nintpen, ")
        strSQL.Append(" nintcal, ")
        strSQL.Append(" nintpag, ")
        strSQL.Append(" nintmor, ")
        strSQL.Append(" nmorpag, ")
        strSQL.Append(" npagcta, ")
        strSQL.Append(" ncapdes, ")
        strSQL.Append(" ncapcal, ")
        strSQL.Append(" ngaspag, ")
        strSQL.Append(" ndiaatr, ")
        strSQL.Append(" ndiaant, ")
        strSQL.Append(" natracu, ")
        strSQL.Append(" natrmax, ")
        strSQL.Append(" ccondic, ")
        strSQL.Append(" dultpag, ")
        strSQL.Append(" dfecter, ")
        strSQL.Append(" ccodrec, ")
        strSQL.Append(" nnota1, ")
        strSQL.Append(" nnota2, ")
        strSQL.Append(" cmarjud, ")
        strSQL.Append(" ntipcam, ")
        strSQL.Append(" lctaret, ")
        strSQL.Append(" cclacre, ")
        strSQL.Append(" ccalif, ")
        strSQL.Append(" nsegvid, ")
        strSQL.Append(" cnumexp, ")
        strSQL.Append(" ccodrub, ")
        strSQL.Append(" cregist, ")
        strSQL.Append(" dfecadm, ")
        strSQL.Append(" nintadm, ")
        strSQL.Append(" nmeses, ")
        strSQL.Append(" csececo, ")
        strSQL.Append(" nciclo, ")
        strSQL.Append(" ccodsol, ")
        strSQL.Append(" nmorak, ")
        strSQL.Append(" nahoprg, ")
        strSQL.Append(" cliquid, ")
        strSQL.Append(" clineac, ")
        strSQL.Append(" ncapoto, ")
        strSQL.Append(" ccontra, ")
        strSQL.Append(" dfectra, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cflat, ")
        strSQL.Append(" nnumfal, ")
        strSQL.Append(" ctipgar, ")
        strSQL.Append(" cnrodes, ")
        strSQL.Append(" coficina, cfreccap, cfrecint, lsegvid, ccodpag ")
        strSQL.Append(" FROM cremcre ")

    End Sub

    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listacremcre
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE ccodcli = @ccodcli")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = codcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacremcre

        Try
            Do While dr.Read()
                Dim mEntidad As New cremcre
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cCodofi = IIf(dr("cCodofi") Is DBNull.Value, Nothing, dr("cCodofi"))
                mEntidad.ccodprd = IIf(dr("ccodprd") Is DBNull.Value, Nothing, dr("ccodprd"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccatego = IIf(dr("ccatego") Is DBNull.Value, Nothing, dr("ccatego"))
                mEntidad.ccodfue = IIf(dr("ccodfue") Is DBNull.Value, Nothing, dr("ccodfue"))
                mEntidad.ccodact = IIf(dr("ccodact") Is DBNull.Value, Nothing, dr("ccodact"))
                mEntidad.ctipcre = IIf(dr("ctipcre") Is DBNull.Value, Nothing, dr("ctipcre"))
                mEntidad.cdescre = IIf(dr("cdescre") Is DBNull.Value, Nothing, dr("cdescre"))
                mEntidad.ctipcuo = IIf(dr("ctipcuo") Is DBNull.Value, Nothing, dr("ctipcuo"))
                mEntidad.ctipper = IIf(dr("ctipper") Is DBNull.Value, Nothing, dr("ctipper"))
                mEntidad.ntipperc = IIf(dr("ntipperc") Is DBNull.Value, Nothing, dr("ntipperc"))
                mEntidad.cctapre = IIf(dr("cctapre") Is DBNull.Value, Nothing, dr("cctapre"))
                mEntidad.cnorref = IIf(dr("cnorref") Is DBNull.Value, Nothing, dr("cnorref"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.dfecasi = IIf(dr("dfecasi") Is DBNull.Value, Nothing, dr("dfecasi"))
                mEntidad.dfecsol = IIf(dr("dfecsol") Is DBNull.Value, Nothing, dr("dfecsol"))
                mEntidad.nmonsol = IIf(dr("nmonsol") Is DBNull.Value, Nothing, dr("nmonsol"))
                mEntidad.nmonsug = IIf(dr("nmonsug") Is DBNull.Value, Nothing, dr("nmonsug"))
                mEntidad.ncuosug = IIf(dr("ncuosug") Is DBNull.Value, Nothing, dr("ncuosug"))
                mEntidad.ndessug = IIf(dr("ndessug") Is DBNull.Value, Nothing, dr("ndessug"))
                mEntidad.ndiasug = IIf(dr("ndiasug") Is DBNull.Value, Nothing, dr("ndiasug"))
                mEntidad.ndiagra = IIf(dr("ndiagra") Is DBNull.Value, Nothing, dr("ndiagra"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nmoncuo = IIf(dr("nmoncuo") Is DBNull.Value, Nothing, dr("nmoncuo"))
                mEntidad.nintapr = IIf(dr("nintapr") Is DBNull.Value, Nothing, dr("nintapr"))
                mEntidad.ncuoapr = IIf(dr("ncuoapr") Is DBNull.Value, Nothing, dr("ncuoapr"))
                mEntidad.ndiaapr = IIf(dr("ndiaapr") Is DBNull.Value, Nothing, dr("ndiaapr"))
                mEntidad.ndesapr = IIf(dr("ndesapr") Is DBNull.Value, Nothing, dr("ndesapr"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcon = IIf(dr("ctipcon") Is DBNull.Value, Nothing, dr("ctipcon"))
                mEntidad.ccodapo = IIf(dr("ccodapo") Is DBNull.Value, Nothing, dr("ccodapo"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.ndeseje = IIf(dr("ndeseje") Is DBNull.Value, Nothing, dr("ndeseje"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ncappag = IIf(dr("ncappag") Is DBNull.Value, Nothing, dr("ncappag"))
                mEntidad.nintpen = IIf(dr("nintpen") Is DBNull.Value, Nothing, dr("nintpen"))
                mEntidad.nintcal = IIf(dr("nintcal") Is DBNull.Value, Nothing, dr("nintcal"))
                mEntidad.nintpag = IIf(dr("nintpag") Is DBNull.Value, Nothing, dr("nintpag"))
                mEntidad.nintmor = IIf(dr("nintmor") Is DBNull.Value, Nothing, dr("nintmor"))
                mEntidad.nmorpag = IIf(dr("nmorpag") Is DBNull.Value, Nothing, dr("nmorpag"))
                mEntidad.npagcta = IIf(dr("npagcta") Is DBNull.Value, Nothing, dr("npagcta"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                mEntidad.ncapcal = IIf(dr("ncapcal") Is DBNull.Value, Nothing, dr("ncapcal"))
                mEntidad.ngaspag = IIf(dr("ngaspag") Is DBNull.Value, Nothing, dr("ngaspag"))
                mEntidad.ndiaatr = IIf(dr("ndiaatr") Is DBNull.Value, Nothing, dr("ndiaatr"))
                mEntidad.ndiaant = IIf(dr("ndiaant") Is DBNull.Value, Nothing, dr("ndiaant"))
                mEntidad.natracu = IIf(dr("natracu") Is DBNull.Value, Nothing, dr("natracu"))
                mEntidad.natrmax = IIf(dr("natrmax") Is DBNull.Value, Nothing, dr("natrmax"))
                mEntidad.ccondic = IIf(dr("ccondic") Is DBNull.Value, Nothing, dr("ccondic"))
                mEntidad.dultpag = IIf(dr("dultpag") Is DBNull.Value, Nothing, dr("dultpag"))
                mEntidad.dfecter = IIf(dr("dfecter") Is DBNull.Value, Nothing, dr("dfecter"))
                mEntidad.ccodrec = IIf(dr("ccodrec") Is DBNull.Value, Nothing, dr("ccodrec"))
                mEntidad.nnota1 = IIf(dr("nnota1") Is DBNull.Value, Nothing, dr("nnota1"))
                mEntidad.nnota2 = IIf(dr("nnota2") Is DBNull.Value, Nothing, dr("nnota2"))
                mEntidad.cmarjud = IIf(dr("cmarjud") Is DBNull.Value, Nothing, dr("cmarjud"))
                mEntidad.ntipcam = IIf(dr("ntipcam") Is DBNull.Value, Nothing, dr("ntipcam"))
                mEntidad.lctaret = IIf(dr("lctaret") Is DBNull.Value, Nothing, dr("lctaret"))
                mEntidad.cclacre = IIf(dr("cclacre") Is DBNull.Value, Nothing, dr("cclacre"))
                mEntidad.ccalif = IIf(dr("ccalif") Is DBNull.Value, Nothing, dr("ccalif"))
                mEntidad.nsegvid = IIf(dr("nsegvid") Is DBNull.Value, Nothing, dr("nsegvid"))
                mEntidad.cnumexp = IIf(dr("cnumexp") Is DBNull.Value, Nothing, dr("cnumexp"))
                mEntidad.ccodrub = IIf(dr("ccodrub") Is DBNull.Value, Nothing, dr("ccodrub"))
                mEntidad.cregist = IIf(dr("cregist") Is DBNull.Value, Nothing, dr("cregist"))
                mEntidad.dfecadm = IIf(dr("dfecadm") Is DBNull.Value, Nothing, dr("dfecadm"))
                mEntidad.nintadm = IIf(dr("nintadm") Is DBNull.Value, Nothing, dr("nintadm"))
                mEntidad.nmeses = IIf(dr("nmeses") Is DBNull.Value, Nothing, dr("nmeses"))
                mEntidad.csececo = IIf(dr("csececo") Is DBNull.Value, Nothing, dr("csececo"))
                mEntidad.nciclo = IIf(dr("nciclo") Is DBNull.Value, Nothing, dr("nciclo"))
                mEntidad.ccodsol = IIf(dr("ccodsol") Is DBNull.Value, Nothing, dr("ccodsol"))
                mEntidad.nmorak = IIf(dr("nmorak") Is DBNull.Value, Nothing, dr("nmorak"))
                mEntidad.nahoprg = IIf(dr("nahoprg") Is DBNull.Value, Nothing, dr("nahoprg"))
                mEntidad.cliquid = IIf(dr("cliquid") Is DBNull.Value, Nothing, dr("cliquid"))
                mEntidad.clineac = IIf(dr("clineac") Is DBNull.Value, Nothing, dr("clineac"))
                mEntidad.ncapoto = IIf(dr("ncapoto") Is DBNull.Value, Nothing, dr("ncapoto"))
                mEntidad.ccontra = IIf(dr("ccontra") Is DBNull.Value, Nothing, dr("ccontra"))
                mEntidad.dfectra = IIf(dr("dfectra") Is DBNull.Value, Nothing, dr("dfectra"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cflat = IIf(dr("cflat") Is DBNull.Value, Nothing, dr("cflat"))
                mEntidad.nnumfal = IIf(dr("nnumfal") Is DBNull.Value, Nothing, dr("nnumfal"))
                mEntidad.ctipgar = IIf(dr("ctipgar") Is DBNull.Value, Nothing, dr("ctipgar"))
                mEntidad.coficina = IIf(dr("coficina") Is DBNull.Value, Nothing, dr("coficina"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function

    Public Function ActualizarCRe(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cEstado = @cEstado, ")
        strSQL.Append(" nCapdes = @nCapdes, ")
        strSQL.Append(" nCapOto = @nCapOto ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(3) As SqlParameter

        args(0) = New SqlParameter("@cEstado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@nCapdes", SqlDbType.Decimal)
        args(1).Value = lEntidad.ncapdes
        args(2) = New SqlParameter("@nCapOto", SqlDbType.Decimal)
        args(2).Value = lEntidad.ncapoto
        args(3) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ModificaCremcre(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET ncapdes = @ncapdes, ")
        strSQL.Append(" ncapoto = @ncapoto, ")
        strSQL.Append(" cestado = @cestado, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" dfecvig = @dfecvig, ")
        strSQL.Append(" nmoncuo = @nmoncuo, ")
        strSQL.Append(" ngaspag = @ngaspag, ")
        strSQL.Append(" ngastos = @ngastos, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" ndiaatr = @ndiaatr, ")
        strSQL.Append(" ccalif = @ccalif, ")
        strSQL.Append(" ccodsol = @ccodsol, ")
        strSQL.Append(" ndeseje = @ndeseje,")
        strSQL.Append(" cnrodes = @cnrodes,")
        strSQL.Append(" ccodpag = @ccodpag, fecha_desembolso = getdate()")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")



        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@ncapdes", SqlDbType.Decimal)
        args(0).Value = lEntidad.ncapdes
        args(1) = New SqlParameter("@ncapoto", SqlDbType.Decimal)
        args(1).Value = lEntidad.ncapoto
        args(2) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(2).Value = lEntidad.nmoncuo
        args(3) = New SqlParameter("@ngaspag", SqlDbType.Decimal)
        args(3).Value = lEntidad.ngaspag
        args(4) = New SqlParameter("@ngastos", SqlDbType.Decimal)
        args(4).Value = lEntidad.ngastos
        args(5) = New SqlParameter("@ndiaatr", SqlDbType.Decimal)
        args(5).Value = lEntidad.ndiaatr
        args(6) = New SqlParameter("@ndeseje", SqlDbType.Decimal)
        args(6).Value = lEntidad.ndeseje
        args(7) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecmod
        args(8) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(8).Value = lEntidad.cestado
        args(9) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(9).Value = lEntidad.dfecvig
        args(10) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(10).Value = lEntidad.cflag
        args(11) = New SqlParameter("@ccalif", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccalif
        args(12) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodsol
        args(13) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodcta
        args(14) = New SqlParameter("@cnrodes", SqlDbType.VarChar)
        args(14).Value = lEntidad.cnrodes
        args(15) = New SqlParameter("@ccodpag", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodpag


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetPorIDRC(ByVal ccodCta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT Climide.cCodCli, Climide.cNomCli, Climide.dNacimi, Climide.cDirDom, ")
        strSQL.Append("Climide.cTelDom, Climide.nHijos, Climide.nOtros, Cremcre.cCodCta, Cremcre.nMonSol,")
        strSQL.Append("Cremcre.nMonSug, Cremcre.nCuoSug,Cremcre.nDiaSug, Cremcre.nTasInt,")
        strSQL.Append("Cretlin.cDeslin From CLIMIDE INNER JOIN CREMCRE ON Climide.cCodcli = Cremcre.cCodcli ")
        strSQL.Append("INNER JOIN CRETLIN ON Cremcre.cNrolin = Cretlin.cNrolin ")
        strSQL.Append("WHERE CREMCRE.cCodCta =" & ccodCta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function ObtenerDataSetPorIDAC(ByVal ccodCta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT Climide.cCodCli, Climide.cNomCli, Climide.dNacimi, Climide.cDirDom, ")
        strSQL.Append("Climide.cTelDom, Climide.nHijos, Climide.nOtros, Cremcre.cCodCta, Cremcre.nMonSol,")
        strSQL.Append("Cremcre.nMonSug, Cremcre.nCuoSug,Cremcre.nDiaSug, Cremcre.nTasInt,")
        strSQL.Append("CREMCRE.nMonApr, CREMCRE.nCuoApr, CREMCRE.nDiaApr,")
        strSQL.Append("Cretlin.cDeslin From CLIMIDE INNER JOIN CREMCRE ON Climide.cCodcli = Cremcre.cCodcli ")
        strSQL.Append("INNER JOIN CRETLIN ON Cremcre.cNrolin = Cretlin.cNrolin ")
        strSQL.Append("WHERE CREMCRE.cCodCta =" & ccodCta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ActualizarSug(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cestado = @cestado, ")
        strSQL.Append(" ctipcuo = @ctipcuo, ")
        strSQL.Append(" ctipper = @ctipper, ")
        strSQL.Append(" nmonsug = @nmonsug, nmonapr = @nmonapr, ")
        strSQL.Append(" ncuosug = @ncuosug, ncuosug0 = @ncuosug0, ")
        strSQL.Append(" ndiasug = @ndiasug, ")
        strSQL.Append(" ndiagra = @ndiagra, ")
        strSQL.Append(" dfecven = @dfecven, ")
        strSQL.Append(" cnrolin = @cnrolin, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" ccodrec = @ccodrec, ")
        strSQL.Append(" nmeses = @nmeses, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflat = @cflat, ")
        strSQL.Append(" nmoncuo = @nmoncuo, ")
        strSQL.Append(" ctipcon = @ctipcon, ")
        strSQL.Append(" dfecvig = @dfecvig, ")
        strSQL.Append(" cfreccap = @cfreccap, ")
        strSQL.Append(" cfrecint = @cfrecint, lsegvid = @lsegvid, ccapacidad = @ccapacidad, ccodfue = @ccodfue ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(27) As SqlParameter
        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipcuo
        args(2) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipper
        args(3) = New SqlParameter("@nmonsug", SqlDbType.Decimal)
        args(3).Value = lEntidad.nmonsug
        args(4) = New SqlParameter("@ncuosug", SqlDbType.Int)
        args(4).Value = lEntidad.ncuosug
        args(5) = New SqlParameter("@ndiasug", SqlDbType.Int)
        args(5).Value = lEntidad.ndiasug
        args(6) = New SqlParameter("@ndiagra", SqlDbType.Int)
        args(6).Value = lEntidad.ndiagra
        args(7) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecven
        args(8) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(8).Value = lEntidad.cnrolin
        args(9) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(9).Value = lEntidad.ntasint
        args(10) = New SqlParameter("@ccodrec", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodrec
        args(11) = New SqlParameter("@nmeses", SqlDbType.Int)
        args(11).Value = lEntidad.nmeses
        args(12) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodusu
        args(13) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(13).Value = lEntidad.dfecmod
        args(14) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(14).Value = lEntidad.cflat
        args(15) = New SqlParameter("@ccodFue", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodfue
        args(16) = New SqlParameter("@ccodAct", SqlDbType.VarChar)
        args(16).Value = lEntidad.ccodact
        args(17) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(17).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(18) = New SqlParameter("@ctipcon", SqlDbType.VarChar)
        args(18).Value = lEntidad.ctipcon
        args(19) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(19).Value = lEntidad.dfecvig
        args(20) = New SqlParameter("@cfreccap", SqlDbType.VarChar)
        args(20).Value = lEntidad.cfreccap
        args(21) = New SqlParameter("@cfrecint", SqlDbType.VarChar)
        args(21).Value = lEntidad.cfrecint
        args(22) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(22).Value = lEntidad.nmoncuo
        args(23) = New SqlParameter("@lsegvid", SqlDbType.Bit)
        args(23).Value = lEntidad.lsegvid
        args(24) = New SqlParameter("@ccapacidad", SqlDbType.VarChar)
        args(24).Value = lEntidad.ccapacidad
        args(25) = New SqlParameter("@canalisis", SqlDbType.VarChar)
        args(25).Value = lEntidad.canalisis
        args(26) = New SqlParameter("@ncuosug0", SqlDbType.Int)
        args(26).Value = lEntidad.ncuosug0
        args(27) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(27).Value = lEntidad.nmonapr

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function updateInfoConavi(ByVal ccodcta As String, ByVal txtInfoConavi As String)
        Dim strSQLDelete As New StringBuilder
        strSQLDelete.Append("DELETE FROM tbl_info_conavi where ccodcta = @ccodcta ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQLDelete.ToString(), args)

        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO tbl_info_conavi VALUES ( @ccodcta, @txtInfoConavi )")
        Dim argss(2) As SqlParameter
        argss(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        argss(0).Value = ccodcta
        argss(1) = New SqlParameter("@txtInfoConavi", SqlDbType.VarChar)
        argss(1).Value = txtInfoConavi
        sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), argss)

    End Function

    Public Function ActualizarApr(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad
        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cestado = @cestado, ")
        strSQL.Append(" ctipcuo = @ctipcuo, ")
        strSQL.Append(" ctipper = @ctipper, ")
        strSQL.Append(" nmonApr = @nmonApr, ")
        strSQL.Append(" ncuoApr = @ncuoApr, ncuosug0 = @ncuosug0, ")
        strSQL.Append(" ndiasug = @ndiasug, ")
        strSQL.Append(" ndiagra = @ndiagra, ")
        strSQL.Append(" dfecven = @dfecven, ")
        strSQL.Append(" cnrolin = @cnrolin, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" ccodrec = @ccodrec, ")
        strSQL.Append(" nmeses = @nmeses, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflat = @cflat, ")
        strSQL.Append(" ccodFue = @ccodFue, ")
        strSQL.Append(" dFecApr = @dFecApr, ")
        strSQL.Append(" nmoncuo = @nmoncuo, lsegvid = @lsegvid, ctipcon = @ctipcon, cacta = @cacta, cresolucion = @cresolucion, codigo_nivel_aprobacion = @codigo_nivel_aprobacion, ")
        strSQL.Append(" usuario_aprobacion = @usuario_aprobacion, fecha_aprobacion = getdate() ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipcuo
        args(2) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipper
        args(3) = New SqlParameter("@nmonApr", SqlDbType.Decimal)
        args(3).Value = lEntidad.nmonapr
        args(4) = New SqlParameter("@ncuoApr", SqlDbType.Int)
        args(4).Value = lEntidad.ncuoapr
        args(5) = New SqlParameter("@ndiasug", SqlDbType.Int)
        args(5).Value = lEntidad.ndiasug
        args(6) = New SqlParameter("@ndiagra", SqlDbType.Int)
        args(6).Value = lEntidad.ndiagra
        args(7) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecven
        args(8) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(8).Value = lEntidad.cnrolin
        args(9) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(9).Value = lEntidad.ntasint
        args(10) = New SqlParameter("@ccodrec", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodrec
        args(11) = New SqlParameter("@nmeses", SqlDbType.Int)
        args(11).Value = lEntidad.nmeses
        args(12) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodusu
        args(13) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(13).Value = lEntidad.dfecmod
        args(14) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(14).Value = lEntidad.cflat
        args(15) = New SqlParameter("@ccodFue", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodfue
        args(16) = New SqlParameter("@dFecapr", SqlDbType.DateTime)
        args(16).Value = lEntidad.dfecapr
        args(17) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(17).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(18) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(18).Value = lEntidad.nmoncuo
        args(19) = New SqlParameter("@lsegvid", SqlDbType.Bit)
        args(19).Value = lEntidad.lsegvid
        args(20) = New SqlParameter("@ncuosug0", SqlDbType.Int)
        args(20).Value = lEntidad.ncuosug0
        args(21) = New SqlParameter("@ctipcon", SqlDbType.VarChar)
        args(21).Value = lEntidad.ctipcon
        args(22) = New SqlParameter("@cacta", SqlDbType.VarChar)
        args(22).Value = lEntidad.cacta
        args(23) = New SqlParameter("@cresolucion", SqlDbType.VarChar)
        args(23).Value = lEntidad.cresolucion
        args(24) = New SqlParameter("@codigo_nivel_aprobacion", SqlDbType.VarChar)
        args(24).Value = lEntidad.codigo_nivel_aprobacion
        args(25) = New SqlParameter("@usuario_aprobacion", SqlDbType.VarChar)
        args(25).Value = lEntidad.usuario_aprobacion


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizarPlan(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET ctipcuo = @ctipcuo, ")
        strSQL.Append(" ctipper = @ctipper, ")
        strSQL.Append(" ncuoapr = @ncuoapr, ")
        strSQL.Append(" ndiaapr = @ndiaapr, ")
        strSQL.Append(" ndiagra = @ndiagra, ")
        strSQL.Append(" dfecven = @dfecven, ")
        strSQL.Append(" cnrolin = @cnrolin, ")
        strSQL.Append(" ntasint = @ntasint, ")
        strSQL.Append(" nmeses = @nmeses, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflat = @cflat, ")
        strSQL.Append(" cfreccap = @cfreccap, ")
        strSQL.Append(" cfrecint = @cfrecint ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(14) As SqlParameter
        args(0) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(0).Value = lEntidad.ctipcuo
        args(1) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipper
        args(2) = New SqlParameter("@ncuoapr", SqlDbType.Int)
        args(2).Value = lEntidad.ncuoapr
        args(3) = New SqlParameter("@ndiaapr", SqlDbType.Int)
        args(3).Value = lEntidad.ndiaapr
        args(4) = New SqlParameter("@ndiagra", SqlDbType.Int)
        args(4).Value = lEntidad.ndiagra
        args(5) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(5).Value = lEntidad.dfecven
        args(6) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnrolin
        args(7) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(7).Value = lEntidad.ntasint
        args(8) = New SqlParameter("@nmeses", SqlDbType.Int)
        args(8).Value = lEntidad.nmeses
        args(9) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodusu
        args(10) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(11).Value = lEntidad.cflat
        args(12) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(12).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(13) = New SqlParameter("@cfreccap", SqlDbType.VarChar)
        args(13).Value = lEntidad.cfreccap
        args(14) = New SqlParameter("@cfrecint", SqlDbType.VarChar)
        args(14).Value = lEntidad.cfrecint


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function



    Public Function Actualizar1(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long

        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cestado = @cEstado, ")
        strSQL.Append(" ncappag  = @ncappag , ")
        strSQL.Append(" nintpag = @nintpag, ")
        strSQL.Append(" nintmor = @nintmor ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@ncappag", SqlDbType.Decimal)
        args(1).Value = lEntidad.ncappag
        args(2) = New SqlParameter("@nintpag", SqlDbType.Decimal)
        args(2).Value = lEntidad.nintpag
        args(3) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(3).Value = lEntidad.nintmor
        args(4) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function Actualizar2(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long

        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cestado = @cEstado")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetPor_cliente(ByVal pccodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT * from cremcre where ccodcli=" & pccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds
    End Function
    Public Function ActualizarAnalista(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long

        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET ccodana = @ccodana")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodana
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function CreditosxGrupo(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, cremcre.ccodcli, cremcre.nmonapr, cremcre.dfecvig, cremcre.cnrolin from cremcre ")
        strSQL.Append("WHERE cremcre.ccodsol = @ccodsol and cremcre.cestado = 'E' ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function SeguroVida(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select Climide.lSegvida,DATEDIFF(month, cremcre.dfecvig, cremcre.dfecven) as  nMeses from climide, cremcre ")
        strSQL.Append("WHERE Cremcre.ccodcta = @cCodcta and Climide.ccodcli = Cremcre.cCodcli ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        Dim ds As New DataSet
        Dim lnsegvida As Double = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lnsegvida = 0
        Else
            Dim lsegvida As Boolean
            lsegvida = ds.Tables(0).Rows(0)("lsegvida")
            If lsegvida = True Then
                Dim lnmeses As Integer
                lnmeses = ds.Tables(0).Rows(0)("nMeses")
                lnsegvida = lnmeses * 1.5
            Else
                lnsegvida = 0
            End If

        End If
        Return lnsegvida
    End Function

    Public Function PresAnt(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ncapdes from cremcre where cremcre.ccodcta = @ccodcta order by cremcre.dfecvig ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        Dim ds As New DataSet
        Dim lncapdes As Double = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lncapdes = 0
        Else
            Dim i As Integer
            i = ds.Tables(0).Rows.Count
            If i > 1 Then
                lncapdes = ds.Tables(0).Rows(i - 2)("nCapdes")
            Else
                lncapdes = 0
            End If
        End If
        Return lncapdes
    End Function

    Public Function AntSocio(ByVal ccodcli As String, ByVal ccodsol As String, ByVal dfecha As Date) As Integer
        Dim strsql As New StringBuilder
        strsql.Append("Select cCodcta from cremcre where cCodcli = @cCodcli and cCodsol = @cCodsol ")
        strsql.Append(" and cestado = 'G' and dfecvig >= @dfecha and dfecvig <= @dfecha ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = ccodcli
        args(2) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(2).Value = dfecha

        Dim ds As New DataSet
        Dim i As Integer
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            'Verifica si ya ha tenido creditos antes
            Dim strsql1 As New StringBuilder
            strsql1.Append("Select cCodcta from cremcre where cCodcli = @cCodcli and cCodsol = @cCodsol ")
            strsql1.Append(" and cestado = 'G'  ")
            Dim ds1 As New DataSet
            ds1 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql1.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                i = 0
            Else
                i = -1
            End If
        Else
            i = 1
        End If

        Return i
    End Function

    Public Function PresGrAnt(ByVal cCodsol As String) As Date
        Dim strsql As New StringBuilder
        strsql.Append("select dfecvig from cremcre ")
        strsql.Append(" where ccodsol = @ccodsol and cestado = 'G' group by dfecvig order by dfecvig desc ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        Dim ds As New DataSet
        Dim ldfecha As Date
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            ldfecha = Today
        Else
            ldfecha = ds.Tables(0).Rows(0)("dfecvig")
        End If
        Return ldfecha
    End Function

    Public Function ObtenerPresidenta(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Dim strsql As New StringBuilder

        strsql.Append("select climide.cnomcli  from climide, cremcre ")
        strsql.Append(" where climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @ccodsol ")
        strsql.Append(" and cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha and cremcre.ccargo = '01' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet
        Dim lcnomcli As String = ""
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomcli = ""
        Else
            lcnomcli = ds.Tables(0).Rows(0)("cnomcli")
        End If
        Return lcnomcli
    End Function

    Public Function ObtenerSocias(ByVal cCodsol As String) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select cremcre.ccodcta as codigo, climide.cnomcli, 00000.00 as ncuota,")
        strsql.Append(" 00000.00 as npago, lctaret as lsolidario, cremcre.dfecvig, cremcre.dfecven, ")
        strsql.Append(" tabtusu.cnomusu, 000000.00 as ndeuda, cretlin.ccodlin, cremcre.cflat ")
        strsql.Append(" from climide, cremcre, tabtusu, cretlin ")
        strsql.Append(" where climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @ccodsol ")
        strsql.Append(" and cremcre.cnrolin = cretlin.cnrolin and cremcre.cestado = 'F' ")
        strsql.Append(" and cremcre.ccodana = tabtusu.ccodusu order by climide.cnomcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function
    Public Function ObtenerSocia(ByVal cCodcta As String) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select codigo, cnomcli,  ncuota,")
        strsql.Append("  npago,  lsolidario   from PAGOSLT ")
        strsql.Append(" where codigo = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function

    Public Function EliminaTablaPagos(ByVal cCodsol As String) As Integer
        Dim strsql As New StringBuilder
        strsql.Append("DELETE FROM PAGOSLT where cCodsol = @cCodsol ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
    End Function

    Public Function InsertaTablaPagos(ByVal ccodcta As String, ByVal cnomcli As String, ByVal ncuota As Double, ByVal npago As Double, ByVal lsolidario As Boolean, ByVal ndeuda As Double, ByVal cCodsol As String) As Integer
        Dim strsql As New StringBuilder
        strsql.Append("INSERT INTO PAGOSLT(codigo, cnomcli, ncuota, npago, lsolidario, ndeuda, cCodsol ) ")
        strsql.Append(" VALUES(@ccodcta, @cnomcli, @ncuota, @npago, @lsolidario, @ndeuda, @cCodsol ) ")
        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = cnomcli
        args(2) = New SqlParameter("@ncuota", SqlDbType.Decimal)
        args(2).Value = ncuota
        args(3) = New SqlParameter("@npago", SqlDbType.Decimal)
        args(3).Value = npago
        args(4) = New SqlParameter("@lsolidario", SqlDbType.Bit)
        args(4).Value = lsolidario
        args(5) = New SqlParameter("@ndeuda", SqlDbType.Decimal)
        args(5).Value = ndeuda
        args(6) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(6).Value = cCodsol


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
    End Function

    Public Function ActualizaTablaPagos(ByVal ccodcta As String, ByVal npago As Double, ByVal lsolidario As Boolean, ByVal cCodsol As String) As Integer
        Dim strsql As New StringBuilder
        strsql.Append("UPDATE PAGOSLT SET npago = @npago, lsolidario = @lsolidario ")
        strsql.Append("  WHERE codigo = @ccodcta and cCodsol = @cCodsol  ")
        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@npago", SqlDbType.Decimal)
        args(1).Value = npago
        args(2) = New SqlParameter("@lsolidario", SqlDbType.Bit)
        args(2).Value = lsolidario
        args(3) = New SqlParameter("@ccodSol", SqlDbType.VarChar)
        args(3).Value = cCodsol


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
    End Function

    Public Function ObtenerTablaPagos(ByVal cCodsol As String) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select codigo, cnomcli,  ncuota, ndeuda, ")
        strsql.Append("  npago,  lsolidario, cCodsol   from PAGOSLT WHERE cCodsol = @cCodsol order by cnomcli ")

        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodSol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function

    Public Function ObtenerSociasporCentro(ByVal cCodsol As String) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select cremcre.ccodcta as codigo, climide.cnomcli, 00000.00 as ncuota,  ")
        strsql.Append(" 00000.00 as npago, lctaret as lsolidario, cremcre.dfecvig, cremcre.dfecven, 000000.00 as ndeuda, ")
        strsql.Append(" tabtusu.cnomusu from climide, cremcre, cremsol, tabtusu ")
        strsql.Append(" where climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = cremsol.ccodsol ")
        strsql.Append(" and cremcre.cCodsol = @ccodsol ")
        strsql.Append(" and cremcre.ccodana = tabtusu.ccodusu")
        strsql.Append(" and cremcre.cestado = 'F' order by cremcre.dfecvig, climide.cnomcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function

    Public Function ActualizarGrupo(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long

        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET ccodsol = @ccodsol")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodsol
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function TasaCredito(ByVal cCodcta As String) As Double
        Dim strsql As New StringBuilder

        strsql.Append("select ntasint from cremcre ")
        strsql.Append(" where ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        Dim lntasa As Double = 0
        lntasa = ds.Tables(0).Rows(0)("ntasint")

        Return lntasa
    End Function

    Public Function CargaListadoChk() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodchk, cNomchk ,  lopcion FROM MASCHEK order by cCodchk")
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function
    Public Function CargaListadoChkCliente(ByVal cCodcta As String, ByVal ccodusu As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremchk.cCodchk, maschek.cNomchk ,  cremchk.lopcion FROM cremchk, maschek ")
        strSQL.Append("WHERE cremchk.ccodchk = maschek.ccodchk and cremchk.cCodcta = @cCodcta and cremchk.ccodusu = @ccodusu ")
        strSQL.Append(" order by maschek.cCodchk")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function CargaListadoChkxItem(ByVal cCodcta As String, ByVal ccodchk As String, ByVal ccodusu As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremchk.cCodchk, maschek.cNomchk ,  cremchk.lopcion FROM cremchk, maschek ")
        strSQL.Append("WHERE cremchk.ccodchk = maschek.ccodchk and cremchk.cCodcta = @cCodcta and cremchk.ccodchk = @ccodchk ")
        strSQL.Append(" and cremchk.ccodusu = @ccodusu ")
        strSQL.Append(" order by maschek.cCodchk")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@ccodchk", SqlDbType.VarChar)
        args(1).Value = ccodchk
        args(2) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(2).Value = ccodusu


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            ds.Clear()
            ds = CargaListadoChkitem2(ccodchk)
        End If

        Return ds
    End Function
    Public Function CargaListadoChkitem2(ByVal cCodchk As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodchk, cNomchk ,  lopcion FROM MASCHEK where ccodchk = @ccodchk order by cCodchk")
        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodchk", SqlDbType.VarChar)
        args(0).Value = cCodchk

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function EliminaListaxUsuario(ByVal cCodcta As String, ByVal cCodusu As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Delete FROM CREMCHK where cCodcta = @cCodcta and cCodusu = @cCodusu ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = cCodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function InsertaListaxUsuario(ByVal cCodcta As String, ByVal cCodusu As String, ByVal lopcion As Boolean, ByVal ccodchk As String, ByVal dfecreg As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("insert into CREMCHK(cCodchk, cCodcta, lopcion, cCodusu, dfecreg) VALUES ")
        strSQL.Append("(@ccodchk, @cCodcta, @lopcion, @cCodusu, @dfecreg)")
        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodchk", SqlDbType.VarChar)
        args(0).Value = ccodchk
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = cCodcta
        args(2) = New SqlParameter("@lopcion", SqlDbType.Bit)
        args(2).Value = lopcion
        args(3) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(3).Value = cCodusu
        args(4) = New SqlParameter("@dfecreg", SqlDbType.DateTime)
        args(4).Value = dfecreg

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function PlantillaChequeo() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select maschek.* from maschek  ")

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())


    End Function

    Public Function UsuarioqChequearon(ByVal cCodcta As String) As DataSet
        Dim strsql As New StringBuilder
        strsql.Append("select upper(ccodusu) as ccodusu from cremchk where cCodcta = @cCodcta group by ccodusu ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

    End Function

    Public Function ListadoxUsuario(ByVal cCodusu As String, ByVal cCodcta As String, ByVal ccodchk As String) As Boolean
        Dim strsql As New StringBuilder
        strsql.Append("select cremchk.* from cremchk where ccodCta = @cCodcta and upper(cCodusu) = upper(@cCodusu) and cCodchk = @cCodchk")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = cCodusu
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = cCodcta
        args(2) = New SqlParameter("@ccodchk", SqlDbType.VarChar)
        args(2).Value = ccodchk

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return ds.Tables(0).Rows(0)("lopcion")
        End If



    End Function

    Public Function VerificaConsistencias(ByVal cCodsol As String) As Boolean

        Dim strSQL As New StringBuilder
        strSQL.Append("Select cnrolin , ncuosug from cremcre where ccodsol = @ccodsol and (cestado = 'C' or cestado = 'D' ) ")
        strSQL.Append("and (cCodrec =' ' or ccodrec is null ) group by cnrolin, ncuosug")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count > 1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ObtenerNombrexCuenta(ByVal cCodsol As String) As String
        Dim strsql As New StringBuilder

        strsql.Append("select climide.cnomcli  from climide, cremcre ")
        strsql.Append(" where climide.ccodcli = cremcre.ccodcli and cremcre.ccodcta = @ccodsol ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As New DataSet
        Dim lcnomcli As String = ""
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomcli = ""
        Else
            lcnomcli = ds.Tables(0).Rows(0)("cnomcli")
        End If
        Return lcnomcli
    End Function

    Public Function ObtenerCreditosxGrupo(ByVal cCodsol As String, ByVal dfecha As Date, ByVal dfecha2 As Date) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select cremcre.cCodcta, cremcre.nmonapr, cremcre.nmoncuo, climide.cnomcli,    ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecpro <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecpro <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecpro <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecpro <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strsql.Append(" from climide, cremcre  ")
        strsql.Append(" where climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @ccodsol and cremcre.dfecvig>=@dfecha and cremcre.dfecvig<= @dfecha  and (cremcre.cestado='F' or cremcre.cestado='G') ")



        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha
        args(2) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(2).Value = dfecha


        Dim ds As New DataSet
        Dim lcnomcli As String = ""
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function
    Public Function ValidaSolicitudPendiente(ByVal cCodcli As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta FROM CREMCRE ")
        strSQL.Append("WHERE cCodcli = @cCodcli ")
        strSQL.Append(" and cestado <> 'A' and cestado <> 'F' and cestado <> 'G' and rtrim(ltrim(cCodrec)) = '' ")
        'strSQL.Append(" and (cestado = 'A' or cestado = 'C' or cestado = 'D' or cestado = 'E' or  cestado = 'F' ) and rtrim(ltrim(cCodrec)) = '' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodcta")) Then
                Return False
            Else
                Return True
            End If
        End If

    End Function
    'Agrega funcion de validacion si tiene otros tipos de creditos
    Public Function Buscar_Creditos_codigos(ByVal codigo As String) As String
        Dim retorno As String = ""

        Dim strSQL As New StringBuilder
        strSQL.Append("select cestado from cremcre where ccodcli=@cCodcli and cestado in ('F','C','E') ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = codigo

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Catch ex As Exception

        End Try

        For Each revisa As DataRow In ds.Tables(0).Rows

            retorno = revisa("cestado")

            If retorno = "" Or retorno Is Nothing Then

                retorno = "1"

            End If

        Next


        Return retorno

    End Function


    Public Function ValidaSolicitudPendienteGrupal(ByVal cCodcli As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta FROM CREMCRE ")
        strSQL.Append("WHERE cCodsol = @cCodcli ")
        strSQL.Append(" and cestado <> 'A' and cestado <> 'F' and cestado <> 'G' and isnull(rtrim(ltrim(cCodrec)),'') = '' ")
        'strSQL.Append(" and (cestado = 'A' or cestado = 'C' or cestado = 'D' or cestado = 'E' or  cestado = 'F' ) and rtrim(ltrim(cCodrec)) = '' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodcta")) Then
                Return False
            Else
                Return True
            End If
        End If

    End Function
    'Busca codigos
    Public Function BuscaCreditos(ByVal ccodsol As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("select cremcre.ccodcli,cnomcli from cremcre inner join climide on cremcre.ccodcli=climide.ccodcli where cremcre.ccodsol=@ccodsol ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)





        Return ds
    End Function
    'Obtiene codigo de clientes y nombres segun el grupo filtrado
    Public Function obtenerGrupos(ByVal codigoGrupal As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("select cremcre.ccodcli,cnomcli from cremcre inner join ")
        strSQL.Append(" climide on cremcre.ccodcli=climide.ccodcli where cremcre.ccodsol=@ccodsol ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = codigoGrupal

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function obtenerCcodsolxClientes(ByVal ccodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select cremcre.ccodsol,cremsol.cnomgru,cremcre.cnrolin from cremcre inner join cremsol on cremcre.ccodsol=cremsol.ccodsol ")
        strSQL.Append(" where cremcre.ccodcli=@ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    'Obtiene creditos por grupal
    Public Function obtenercuentasEstatus(ByVal ccodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select cestado from cremcre ")
        strSQL.Append(" where cremcre.ccodsol=@ccodsol ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    'Validanco reglas de prodcutos
    Public Function validarReglasProductos(ByVal ccodsol As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("select top 1 gs from cremcre inner join Reglas_Producto on cremcre.cnrolin=Reglas_Producto.cnrolin where ccodsol=@ccodsol")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim gs As Integer

        gs = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return gs

    End Function

    ''Agrega funcion de validacion si tiene otros tipos de creditos
    'Public Function Buscar_Creditos_codigos(ByVal codigo As String) As String
    '    Dim retorno As String = ""

    '    Dim strSQL As New StringBuilder
    '    strSQL.Append("select cestado from cremcre where ccodcli=@cCodcli and cestado not in ('F','C','E') ")

    '    Dim args(0) As SqlParameter
    '    args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
    '    args(0).Value = codigo

    '    Dim ds As New DataSet

    '    Try
    '        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    '    Catch ex As Exception

    '    End Try

    '    For Each revisa As DataRow In ds.Tables(0).Rows

    '        retorno = revisa("cestado")

    '        If retorno = "" Or retorno Is Nothing Then

    '            retorno = "1"

    '        End If

    '    Next


    '    Return retorno

    'End Function


    Public Function ObtieneSolicitudPendienteGrupal(ByVal cCodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta, cestado FROM CREMCRE ")
        strSQL.Append("WHERE cCodsol = @cCodcli ")
        strSQL.Append(" and cestado = 'A'  and isnull(rtrim(ltrim(cCodrec)),'') = '' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function Sabado() As Boolean
        Dim strsql As New StringBuilder
        strsql.Append("select lobvsab from CREDCON ")
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString())

        Dim lsabado As Boolean
        If ds.Tables(0).Rows.Count = 0 Then
            lsabado = False
        Else
            lsabado = IIf(IsDBNull(ds.Tables(0).Rows(0)("lobvsab")), False, ds.Tables(0).Rows(0)("lobvsab"))
        End If
        Return lsabado
    End Function

    Public Function Domingo() As Boolean
        Dim strsql As New StringBuilder
        strsql.Append("select lobvdom from CREDCON ")
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString())

        Dim lsabado As Boolean
        If ds.Tables(0).Rows.Count = 0 Then
            lsabado = False
        Else
            lsabado = IIf(IsDBNull(ds.Tables(0).Rows(0)("lobvdom")), False, ds.Tables(0).Rows(0)("lobvdom"))
        End If
        Return lsabado
    End Function

    Public Function ValidaRetiroGrupo(ByVal cCodcli) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodsol FROM CREMCRE WHERE cCodcli = @cCodcli and cestado = 'F'  ")
        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ObtieneAnalistaGrupal(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT TABTUSU.cNomusu FROM CREMCRE, TABTUSU  ")
        strSQL.Append("WHERE cremcre.ccodana = tabtusu.ccodusu and cremcre.cCodsol = @cCodsol ")
        strSQL.Append("and dfecvig>=@dfecha and dfecvig<=@dfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim lcnomana As String = ""

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lcnomana = ds.Tables(0).Rows(0)("cnomusu")
        End If
        Return lcnomana
    End Function

    Public Function CambiaAnalistaGrupal(ByVal cCodsol As String, ByVal dfecha As Date, ByVal ccodana As String) As Integer


        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET ccodana = @ccodana")
        strSQL.Append(" WHERE ccodsol = @ccodsol ")
        strSQL.Append(" and dfecvig>=@dfecha and dfecvig<=@dfecha ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha
        args(2) = New SqlParameter("@cCodana", SqlDbType.VarChar)
        args(2).Value = ccodana


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ValidaExistenciaCredito(ByVal ccodsol As String, ByVal dfecha As Date) As Boolean
        Dim strSQL As New StringBuilder

        strSQL.Append("Select cCodsol from CREMCRE ")
        strSQL.Append("WHERE cCodsol = @cCodsol and dfecvig>=@dfecha and dfecvig<=@dfecha and cEstado ='F' ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lvalida As Boolean
        If ds.Tables(0).Rows.Count = 0 Then
            lvalida = False
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodsol")) Then
                lvalida = False
            Else
                lvalida = True
            End If
        End If

        Return lvalida
    End Function

    Public Function ReseteaProvision(ByVal cCodcta As String) As Integer
        Dim strSQL As New StringBuilder

        strSQL.Append("DELETE FROM CREDPRO WHERE  cCodcta = @cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    '>>>>>><
    Public Function RecuperarProvisionAcumulada(ByVal cCodigo As String, ByVal cmetodo As String, ByVal ccodofi As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select sum(CREDPRO.nprovan) as nprovis, cremcre.coficina as ccodofi from CREDPRO, climide, cremcre, cretlin  ")
        strSQL.Append("WHERE cremcre.cnrolin = cretlin.cnrolin and credpro.cCodcta = cremcre.ccodcta  ")
        strSQL.Append(" and cremcre.ccodcli = climide.ccodcli and credpro.nprovan > 0 ")
        strSQL.Append(" and substring(cretlin.ccodlin, 3,2) = @cCodigo and left(cremcre.ccondic,1) = left(@cmetodo,1) ")
        strSQL.Append(" and cremcre.coficina = @ccodofi  group by cremcre.coficina ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar) 'fuente de fondos
        args(0).Value = cCodigo
        args(1) = New SqlParameter("@cmetodo", SqlDbType.VarChar) 'metodologia
        args(1).Value = cmetodo
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar) 'metodologia
        args(2).Value = ccodofi


        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer
        Dim lnprovis As Double = 0


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnprovis = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovis")), 0, ds.Tables(0).Rows(0)("nprovis"))
        End If

        Return lnprovis
    End Function
    Public Function InicializaMes() As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nProvan = '0', nprovmor = '0'  ")



        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function Provisionado(ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from CREDPRO WHERE cCodcta = @cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds


    End Function

    Public Function ActualizaProvision(ByVal cCodcta As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nProvis = @nIntAct, nProvan = 0 WHERE cCodcta = @cCodcta ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@nIntAct", SqlDbType.Decimal)
        args(1).Value = nIntAct
        args(2) = New SqlParameter("@nDesInt", SqlDbType.Decimal)
        args(2).Value = nDesInt



        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function VerificaRegistroProvision(ByVal cCodcta As String) As Boolean
        Dim strsql As New StringBuilder
        strsql.Append("Select cCodcta from credpro where cCodcta = @cCodcta")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function InsertaRegistroProvision(ByVal cCodcta As String) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO CREDPRO ")
        strSQL.Append(" (cCodcta, nprovis, nprovan, nprovpas, nprovmor)")
        strSQL.Append(" VALUES (@ccodcta, '0', '0', '0','0') ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RegistraProvisionDiaria(ByVal cCodcta As String, ByVal nintdia As Double, ByVal dfecha As Date, ByVal nintmor As Double) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nprovis = nprovis , nprovan = (nprovan + @nintdia), dfecpro = @dfecha, nprovmor = (nprovmor +  @nintmor) ")
        strSQL.Append(" WHERE cCodcta = @cCodcta")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@nintdia", SqlDbType.Decimal)
        args(1).Value = nintdia
        args(2) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(2).Value = dfecha
        args(3) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(3).Value = nintmor

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RegistraProvisionMensual1(ByVal dfecha As Date) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nprovis = (nprovis + nprovan),nprovpas = (nprovpas + nprovmor),  dfecpro = @dfecha, ndiaint = nprovan, ndiaintmor = nprovmor ")


        Dim args(2) As SqlParameter
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RegistraProvisionMensual2(ByVal cCodcta As String, ByVal nintdia As Double, ByVal dfecha As Date) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nprovan =  '0', dfecpro = @dfecha ")
        strSQL.Append(" WHERE cCodcta = @cCodcta")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@nintdia", SqlDbType.Decimal)
        args(1).Value = nintdia
        args(2) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(2).Value = dfecha

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaCremcre(ByVal cCodcta As String, ByVal ndiaatr As Integer) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE ")
        strSQL.Append(" SET  ndiaatr = @ndiaatr ")
        strSQL.Append(" WHERE cCodcta = @cCodcta")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@ndiaatr", SqlDbType.Int)
        args(1).Value = ndiaatr

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RecuperarProvision() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select CREDPRO.*, climide.cnomcli, cremcre.ndiaatr, space(1) as cCalif, space(60) as cdescri from CREDPRO, climide, cremcre  ")
        strSQL.Append("WHERE credpro.cCodcta = cremcre.ccodcta and cremcre.ccodcli = climide.ccodcli and (credpro.ndiaint > 0 or credpro.ndiaintmor > 0 ) ")

        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer
        Dim lccalif As String = ""
        Dim lcdescri As String = ""

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        For Each fila In ds.Tables(0).Rows
            If fila("ndiaatr") <= 0 Then
                lccalif = "A"
                lcdescri = "0 DIAS DE ATRASO"

            ElseIf fila("ndiaatr") > 0 And fila("ndiaatr") <= 30 Then
                lccalif = "B"
                lcdescri = "DE 1 A 30 DIAS DE ATRASO"

            ElseIf fila("ndiaatr") > 30 And fila("ndiaatr") <= 60 Then
                lccalif = "C"
                lcdescri = "DE 31 A 60 DIAS DE ATRASO"

            ElseIf fila("ndiaatr") > 60 And fila("ndiaatr") <= 90 Then
                lccalif = "D"
                lcdescri = "DE 61 A 90 DIAS DE ATRASO"

            Else
                lccalif = "E"
                lcdescri = "MAS DE 90 DIAS DE ATRASO"

            End If
            ds.Tables(0).Rows(i)("cCalif") = lccalif
            ds.Tables(0).Rows(i)("cdescri") = lcdescri

            i += 1
        Next

        Return ds
    End Function

    Public Function ActualizarCierreCremcre(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" Then
            Return -1
        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET nCapCal = @ncapcal, ")
        strSQL.Append(" nCapdes = @nCapdes, ")
        strSQL.Append(" nCappag = @nCappag, ")
        strSQL.Append(" ndiaatr = @ndiaatr, ")
        strSQL.Append(" nintcal = @nintcal, ")
        strSQL.Append(" nintpag = @nintpag, ")
        strSQL.Append(" nintpen = @nintpen, ")
        strSQL.Append(" npagcta = @npagcta, ")
        strSQL.Append(" nmorpag = @nmorpag, ")
        strSQL.Append(" nintmor = @nintmor, ")
        strSQL.Append(" dultpag = @dultpag, nmorak = @nmorak, ccalif = @ccalif, ")
        strSQL.Append(" nsalcap = @nsalcap, nsalint = @nsalint, nsalmor = @nsalmor, dfecmod = getdate() ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(16) As SqlParameter

        args(0) = New SqlParameter("@ncapcal", SqlDbType.Decimal)
        args(0).Value = lEntidad.ncapcal
        args(1) = New SqlParameter("@nCapdes", SqlDbType.Decimal)
        args(1).Value = lEntidad.ncapdes
        args(2) = New SqlParameter("@nCappag", SqlDbType.Decimal)
        args(2).Value = lEntidad.ncappag
        args(3) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(4) = New SqlParameter("@ndiaatr", SqlDbType.Int)
        args(4).Value = lEntidad.ndiaatr
        args(5) = New SqlParameter("@nintcal", SqlDbType.Decimal)
        args(5).Value = lEntidad.nintcal
        args(6) = New SqlParameter("@nintpag", SqlDbType.Decimal)
        args(6).Value = lEntidad.nintpag
        args(7) = New SqlParameter("@nintpen", SqlDbType.Decimal)
        args(7).Value = lEntidad.nintpen
        args(8) = New SqlParameter("@npagcta", SqlDbType.Decimal)
        args(8).Value = lEntidad.npagcta
        args(9) = New SqlParameter("@nmorpag", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmorpag
        args(10) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(10).Value = lEntidad.nintmor
        args(11) = New SqlParameter("@dultpag", SqlDbType.DateTime)
        args(11).Value = lEntidad.dultpag
        args(12) = New SqlParameter("@nmorak", SqlDbType.Decimal)
        args(12).Value = lEntidad.nmorak
        args(13) = New SqlParameter("@ccalif", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccalif
        args(14) = New SqlParameter("@nsalcap", SqlDbType.Decimal)
        args(14).Value = lEntidad.nsalcap
        args(15) = New SqlParameter("@nsalint", SqlDbType.Decimal)
        args(15).Value = lEntidad.nsalint
        args(16) = New SqlParameter("@nsalmor", SqlDbType.Decimal)
        args(16).Value = lEntidad.nsalmor

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    '------------------->>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<-------------------------------
    Public Function ActualizarCalificacionCremcre(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cremcre
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" Then
            Return -1
        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre ")
        strSQL.Append(" SET cCalif = @cCalif, ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(11) As SqlParameter

        args(0) = New SqlParameter("@cCalif", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccalif

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    '--------------------ASIENTOS TEMPORALES reclasificación
    Public Function EliminaAsientos() As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ASIENTOS ")

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function
    Public Function AgregaAsiento(ByVal cCodcta As String, ByVal cdescri As String, ByVal ndebe As Double, ByVal nhaber As Double, _
                                  ByVal cCodlin As String, ByVal cdestra As String, ByVal ffondos As String, ByVal ctipmet As String, ByVal ccodpres As String, ByVal ccodofi As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ASIENTOS(cCodcta, cdescri, ndebe, nhaber, cCodlin, cdestra, ffondos, ctipmet, ccodpres, ccodofi) ")
        strSQL.Append("VALUES(@cCodcta, @cdescri, @ndebe, @nhaber, @cCodlin, @cdestra, @ffondos, @ctipmet, @ccodpres, @ccodofi)")

        Dim args(9) As SqlParameter

        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(1).Value = cdescri
        args(2) = New SqlParameter("@nDebe", SqlDbType.Decimal)
        args(2).Value = ndebe
        args(3) = New SqlParameter("@nHaber", SqlDbType.Decimal)
        args(3).Value = nhaber
        args(4) = New SqlParameter("@cCodlin", SqlDbType.VarChar)
        args(4).Value = cCodlin
        args(5) = New SqlParameter("@cdestra", SqlDbType.VarChar)
        args(5).Value = cdestra
        args(6) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(6).Value = ffondos
        args(7) = New SqlParameter("@ctipmet", SqlDbType.VarChar)
        args(7).Value = ctipmet
        args(8) = New SqlParameter("@ccodpres", SqlDbType.VarChar)
        args(8).Value = ccodpres
        args(9) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(9).Value = ccodofi


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function RecuperarAsiento(ByVal ccodigo As String, ByVal cmetodo As String, ByVal cCodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta,  sum(ndebe) as ndebe, sum(nhaber) as nhaber ")
        strSQL.Append("  FROM ASIENTOS WHERE ffondos = @ccodigo and ctipmet = @cmetodo and cCodofi =@cCodofi GROUP BY cCodofi, ffondos, ctipmet, ccodcta ")
        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = ccodigo
        args(1) = New SqlParameter("@cmetodo", SqlDbType.VarChar)
        args(1).Value = cmetodo
        args(2) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(2).Value = cCodofi


        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaCondicion(ByVal cCodcta As String, ByVal cCondicion As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE  set cCondic = @cCondicion WHERE cCodcta = @cCodcta ")

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cCondicion", SqlDbType.VarChar)
        args(1).Value = cCondicion

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizaCondicionContra(ByVal cCodcta As String, ByVal cCondicion As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE  set ccontra = @cCondicion WHERE cCodcta = @cCodcta ")

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cCondicion", SqlDbType.VarChar)
        args(1).Value = cCondicion

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RecuperaCreditosReclasificados(ByVal cCodofi As String)
        Dim strSQL As New StringBuilder
        strSQL.Append("Select distinct asientos.cCodpres, climide.cnomcli, (asientos.ndebe + asientos.nhaber) as nsaldo, ")
        strSQL.Append(" asientos.cdestra, cremcre.coficina, tabtofi.cnomofi, asientos.cnumcom from asientos, cremcre, climide, tabtofi ")
        strSQL.Append(" WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodcta = asientos.ccodpres ")
        strSQL.Append(" and cremcre.coficina = tabtofi.ccodofi  ")
        If cCodofi = "001" Then
        Else
            strSQL.Append(" and cremcre.coficina = @ccodofi  ")
        End If
        strSQL.Append(" order by asientos.cdestra ")

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function StatusCredito(ByVal cCondic As String) As String
        Dim lcstatus As String = ""

        If cCondic = "N" Then
            lcstatus = "VIGENTE AL DIA"
        ElseIf cCondic = "M" Then
            lcstatus = "VIGENTE EN MORA"
        ElseIf cCondic = "V" Then
            lcstatus = "VENCIDO EN COBRO ADMINISTRATIVO"
        ElseIf cCondic = "J" Then
            lcstatus = "VENCIDO EN COBRO JUDICIAL"
        ElseIf cCondic = "R" Then
            lcstatus = "REESTRUCTURADO"
        ElseIf cCondic = "P" Then
            lcstatus = "PRORROGADO"
        ElseIf cCondic = "S" Then
            lcstatus = "CASTIGADO"
        Else
            lcstatus = ""
        End If

        Return lcstatus
    End Function

    Public Function ObtenerSociasporCentroAnular(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select cremcre.ccodcta as codigo, climide.cnomcli, 00000.00 as ncuota,  ")
        strsql.Append(" 00000.00 as npago, lctaret as lsolidario, cremcre.dfecvig, cremcre.dfecven, 000000.00 as ndeuda, ")
        strsql.Append(" tabtusu.cnomusu from climide, cremcre, cremsol, tabtusu ")
        strsql.Append(" where climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = cremsol.ccodsol ")
        strsql.Append(" and cremcre.cCodsol = @ccodsol ")
        strsql.Append(" and cremcre.ccodana = tabtusu.ccodusu")
        strsql.Append(" and cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha")
        strsql.Append(" and (cremcre.cestado = 'F' or cremcre.cestado ='G') order by cremcre.dfecvig, climide.cnomcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha



        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function
    Public Function ObtenerClientedeGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append("select cremcre.ccodcta, climide.cnomcli  ")
        strsql.Append(" from cremcre, climide ")
        strsql.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.ccodsol = @cCodsol and ")
        strsql.Append(" cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha and ")
        strsql.Append(" (cremcre.cestado = 'F' or cremcre.cestado = 'G') ")



        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)
        Return ds
    End Function

    Public Function CodigoAnalistadeGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select max(cremcre.cCodana) as ccodana FROM CREMCRE ")
        strSQL.Append("WHERE cremcre.ccodsol = @cCodsol and cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha ")
        strSQL.Append("GROUP BY cremcre.ccodsol, cremcre.dfecvig  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodana As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodana")) Then
            Else
                lccodana = ds.Tables(0).Rows(0)("cCodana")
            End If
        End If
        Return lccodana
    End Function
    Public Function LineadeGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select max(cretlin.cdeslin)  as cdeslin FROM CREMCRE, CRETLIN ")
        strSQL.Append("WHERE cremcre.ccodsol = @cCodsol and cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha ")
        strSQL.Append(" and cremcre.cnrolin = cretlin.cnrolin  group by cremcre.ccodsol, cremcre.dfecvig ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcdeslin As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cdeslin")) Then
            Else
                lcdeslin = ds.Tables(0).Rows(0)("cdeslin")
            End If
        End If
        Return lcdeslin
    End Function
    Public Function NumeroLineaGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select max(cremcre.cnrolin) as cnrolin FROM CREMCRE ")
        strSQL.Append("WHERE cremcre.ccodsol = @cCodsol and cremcre.dfecvig >= @dfecha and cremcre.dfecvig <= @dfecha ")
        strSQL.Append("   group by cremcre.ccodsol, cremcre.dfecvig ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcnrolin As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnrolin")) Then
            Else
                lcnrolin = ds.Tables(0).Rows(0)("cnrolin")
            End If
        End If
        Return lcnrolin
    End Function

    Public Function OficinaAsientos() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select cCodofi from asientos group by cCodofi order by ccodofi ")
        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ActualizaCremcreRees(ByVal cCodcta As String, ByVal dfecven As Date, ByVal ncuoapr As Integer, ByVal nmoncuo As Decimal, ByVal cfreccap As String, ByVal cfrecint As String, ByVal nintmor As Decimal) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE set dfecven = @dfecven , ncuoapr = @ncuoapr, nmoncuo = @nmoncuo, ")
        strSQL.Append(" cfreccap = @cfreccap, cfrecint = @cfrecint, nintadm = @nintmor  WHERE cCodcta = @cCodcta ")

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(1).Value = dfecven

        args(2) = New SqlParameter("@ncuoapr", SqlDbType.Int)
        args(2).Value = ncuoapr

        args(3) = New SqlParameter("@nmoncuo", SqlDbType.Decimal)
        args(3).Value = nmoncuo

        args(4) = New SqlParameter("@cfreccap", SqlDbType.VarChar)
        args(4).Value = cfreccap

        args(5) = New SqlParameter("@cfrecint", SqlDbType.VarChar)
        args(5).Value = cfrecint

        args(6) = New SqlParameter("@nintmor", SqlDbType.Decimal)
        args(6).Value = nintmor
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaSuspensiondeCredito(ByVal ccodcta As String, ByVal dfectra As Date, ByVal ccontra As String, ByVal nperiodo As Integer) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE set dfectra = @dfectra , ccontra = @ccontra, nperiodo = @nperiodo WHERE ccodcta = @ccodcta ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        args(1) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(1).Value = dfectra

        args(2) = New SqlParameter("@ccontra", SqlDbType.VarChar)
        args(2).Value = ccontra

        args(3) = New SqlParameter("@nperiodo", SqlDbType.Int)
        args(3).Value = nperiodo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaCremcreExtra(ByVal cCodcta As String, ByVal dfecven As Date, ByVal ncuoapr As Integer, ByVal nCapdes As Double, ByVal nmonapr As Double) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE set dfecven = @dfecven , ncuoapr = @ncuoapr, nCapdes = @nCapdes, nMonapr = @nMonapr WHERE cCodcta = @cCodcta ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(1).Value = dfecven

        args(2) = New SqlParameter("@ncuoapr", SqlDbType.Int)
        args(2).Value = ncuoapr

        args(3) = New SqlParameter("@nCapdes", SqlDbType.Decimal)
        args(3).Value = nCapdes

        args(4) = New SqlParameter("@nMonapr", SqlDbType.Decimal)
        args(4).Value = nmonapr

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    'Verifica si existe Base de datos
    Public Function VerficaExisteBase(ByVal nombre As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT name FROM master.dbo.sysdatabases where name = @nombre ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(0).Value = nombre

        Dim ds As New DataSet
        Dim i As Integer = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            i = 0
        Else
            i = IIf(IsDBNull(ds.Tables(0).Rows(0)("name")), 0, 1)
        End If
        Return i
    End Function
    Public Function CrearBasedeDatos(ByVal MyDatabase As String) As Integer
        Dim str As String

        Dim myConn As SqlConnection = New SqlConnection(Me.cnnStr)

        str = "USE master; CREATE DATABASE " & MyDatabase & "; "

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If
        End Try

        'CrearTablas(MyDatabase)
        CrearTablasCierreDeMes(MyDatabase)

        'Dim str As String

        'Dim myConn As SqlConnection = New SqlConnection(Me.cnnStr)

        'str = "USE master; CREATE DATABASE " & MyDatabase & "; "

        'Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        'Try
        '    myConn.Open()
        '    myCommand.ExecuteNonQuery()
        'Catch ex As Exception

        'Finally
        '    If (myConn.State = ConnectionState.Open) Then
        '        myConn.Close()
        '    End If
        'End Try

        'CrearTablas(MyDatabase)
    End Function
    Public Function CrearTablas(ByVal mibase As String) As Integer
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim lcnombre1, lcnombre2, lcnombre3, lcnombre4, lcnombre5, lcnombre6, lcnombre7 As String
        lcnombre1 = mibase.Trim + ".dbo.Cremcre"
        lcnombre2 = mibase.Trim + ".dbo.Cretlin"
        lcnombre3 = mibase.Trim + ".dbo.Cremsol"
        lcnombre4 = mibase.Trim + ".dbo.Credppg"
        lcnombre5 = mibase.Trim + ".dbo.Credkar"
        lcnombre6 = mibase.Trim + ".dbo.Climide"
        lcnombre7 = mibase.Trim + ".dbo.Centros"

        'Try

        '***************  actualiza saldos iniciales de ctbmcta *************


        Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
        Dim oCommand As SqlClient.SqlCommand = _
                New SqlClient.SqlCommand("GENERAR_TABLAS", oConexion)
        Dim oParameter As SqlClient.SqlParameter
        'oParameter = oCommand.Parameters.Add("@Base", SqlDbType.VarChar)
        'oParameter.Value = ""
        oParameter = oCommand.Parameters.Add("@nombre1", SqlDbType.VarChar)
        oParameter.Value = lcnombre1
        oParameter = oCommand.Parameters.Add("@nombre2", SqlDbType.VarChar)
        oParameter.Value = lcnombre2
        oParameter = oCommand.Parameters.Add("@nombre3", SqlDbType.VarChar)
        oParameter.Value = lcnombre3
        oParameter = oCommand.Parameters.Add("@nombre4", SqlDbType.VarChar)
        oParameter.Value = lcnombre4
        oParameter = oCommand.Parameters.Add("@nombre5", SqlDbType.VarChar)
        oParameter.Value = lcnombre5
        oParameter = oCommand.Parameters.Add("@nombre6", SqlDbType.VarChar)
        oParameter.Value = lcnombre6
        oParameter = oCommand.Parameters.Add("@nombre7", SqlDbType.VarChar)
        oParameter.Value = lcnombre7



        oCommand.CommandType = CommandType.StoredProcedure
        oCommand.CommandTimeout = 0

        oConexion.Open()
        oDa = New SqlClient.SqlDataAdapter(oCommand)
        oDs = New DataSet
        oDa.Fill(oDs)

        oDs.Dispose()
        oDa.Dispose()
        oCommand.Dispose()
        oConexion.Close()
        oConexion.Dispose()

        Return 1

        'Catch ex As Exception
        Return 0
        'End Try

    End Function

    Public Function ObtieneSolicitudPendiente(ByVal cCodcli As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta FROM CREMCRE ")
        strSQL.Append("WHERE cCodcta = @cCodcli ")
        strSQL.Append(" and (cestado = 'A'  or cestado = 'C') and rtrim(ltrim(cCodrec)) = '' ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodcta")) Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Public Function ActualizaCodigoRechazo(ByVal cCodcta As String, ByVal cCodrec As String, ByVal ccodusu As String, ByVal dfecha As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE set cCodrec = @cCodrec, ccodusu = @ccodusu, dfecadm = @dfecha WHERE cCodcta = @cCodcta ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cCodrec", SqlDbType.VarChar)
        args(1).Value = cCodrec
        args(2) = New SqlParameter("@cCodusu", SqlDbType.VarChar)
        args(2).Value = ccodusu
        args(3) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(3).Value = dfecha


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerSaldoAjuste(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT nAjuInt FROM CREMCRE WHERE cCodcta = @cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString, args)
        Dim lnsaldo As Double = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lnsaldo = IIf(IsDBNull(ds.Tables(0).Rows(0)("nAjuint")), 0, ds.Tables(0).Rows(0)("nAjuint"))
        End If
        Dim lnajuste As Double = 0
        Dim lnmonto As Double = 0
        lnmonto = 0 'Me.ObtenerInterePagado(cCodcta)
        lnajuste = IIf((lnsaldo - lnmonto) < 0, 0, (lnsaldo - lnmonto))

        Return lnajuste
    End Function
    Public Function ObtieneCreditosCliente(ByVal cCodcli As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta FROM CREMCRE ")
        strSQL.Append("WHERE cCodcli = @cCodcli ")
        strSQL.Append("  and rtrim(ltrim(cCodrec)) = ' ' ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodcta")) Then
                Return False
            Else
                Return True
            End If
        End If

    End Function
    Public Function ObtieneCreditosRechazados(ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select  climide.ccodcli, climide.cnomcli , cremcre.ccodcta, tabttab.cdescri, cremcre.ccodusu, cremcre.dfecadm ")
        strSQL.Append("from cremcre, climide, tabttab where cremcre.ccodcli = climide.ccodcli and  left(cremcre.ccodrec,3) = left(tabttab.ccodigo,3) ")
        strSQL.Append("and tabttab.ccodtab ='042' and ctipreg ='1' and dfecadm >= @dfec1 and dfecadm <= @dfec2 ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfec1", SqlDbType.DateTime)
        args(0).Value = dfec1
        args(1) = New SqlParameter("@dfec2", SqlDbType.DateTime)
        args(1).Value = dfec2


        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function
    Public Function ValidaCreditoConyugue(ByVal cedula As String, ByVal ccodofi As String) As Boolean

        Dim strSQL As New StringBuilder
        Dim valor As Integer
        Dim dr As SqlDataReader

        Try


            Using cn As New SqlConnection(Me.cnnStr)
                cn.Open()
                Dim cmComando As New SqlCommand("sp_validaCreditoConyugue", cn)
                cmComando.CommandType = CommandType.StoredProcedure
                cmComando.Parameters.Add("@cedula", SqlDbType.VarChar)
                cmComando.Parameters("@cedula").Value = cedula.Trim
                cmComando.Parameters.Add("@oficina", SqlDbType.VarChar)
                cmComando.Parameters("@oficina").Value = ccodofi.Trim
                cmComando.Parameters.Add("@valor", SqlDbType.Int)
                cmComando.Parameters("@valor").Direction = ParameterDirection.Output
                cmComando.ExecuteNonQuery()
                valor = cmComando.Parameters("@valor").Value
                cn.Close()

            End Using

        Catch ex As Exception
            Return True
        End Try

        If valor = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function InsertaFechaBackup(ByVal fecha As String, ByVal base As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append(" insert into backupdatos values(@fecha,@base)")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@fecha", SqlDbType.VarChar)
        args(0).Value = fecha

        args(1) = New SqlParameter("@base", SqlDbType.VarChar)
        args(1).Value = base

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function GrabaInteresCongelado(ByVal ccodcta As String, ByVal nmonto As Decimal) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE set nintadm = (nintadm + @nmonto)  ")
        strSQL.Append("WHERE  ccodcta = @ccodcta  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@nmonto", nmonto)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function ActualizaAgencia2FC(ByVal lccodpres As String, ByVal lccodagennuevo As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE SET ccodofi = @lccodagennuevo ,coficina = @lccodagennuevo WHERE ccodcta = @lccodpres and cestado='F'  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lccodpres", SqlDbType.VarChar)
        args(0).Value = lccodpres
        args(1) = New SqlParameter("@lccodagennuevo", SqlDbType.VarChar)
        args(1).Value = lccodagennuevo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizaNrodeLinea2FC(ByVal cnrolin As String, ByVal lccodpres As String, ByVal lccodfue As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE SET cnrolin = @cnrolin,  ccodfue = @lccodfue  WHERE ccodcta = @lccodpres  ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = cnrolin
        args(1) = New SqlParameter("@lccodpres", SqlDbType.VarChar)
        args(1).Value = lccodpres
        args(2) = New SqlParameter("@lccodfue", SqlDbType.VarChar)
        args(2).Value = lccodfue



        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RecuperarProvisionAcumuladaMora(ByVal cCodigo As String, ByVal cmetodo As String, ByVal ccodofi As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select sum(CREDPRO.nprovmor) as nprovis, cremcre.coficina as ccodofi from CREDPRO, climide, cremcre, cretlin  ")
        strSQL.Append("WHERE cremcre.cnrolin = cretlin.cnrolin and credpro.cCodcta = cremcre.ccodcta  ")
        strSQL.Append(" and cremcre.ccodcli = climide.ccodcli and credpro.nprovmor > 0 ")
        strSQL.Append(" and substring(cretlin.ccodlin, 3,2) = @cCodigo and left(cremcre.ccondic,1) = left(@cmetodo,1) ")
        strSQL.Append(" and cremcre.coficina = @ccodofi ")
        strSQL.Append(" group by cremcre.coficina ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar) 'fuente de fondos
        args(0).Value = cCodigo
        args(1) = New SqlParameter("@cmetodo", SqlDbType.VarChar) 'metodologia
        args(1).Value = cmetodo
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi


        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer
        Dim lnprovis As Double = 0


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnprovis = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovis")), 0, ds.Tables(0).Rows(0)("nprovis"))
        End If

        Return lnprovis
    End Function

    Public Function RecuperarProvisionCredito(ByVal cCodigo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select CREDPRO.*,  cremcre.coficina as ccodofi, cremcre.ccondic, substring(cretlin.ccodlin, 3,2)  as ffondos from CREDPRO, cremcre, cretlin  ")
        strSQL.Append("WHERE cremcre.cnrolin = cretlin.cnrolin and credpro.cCodcta = cremcre.ccodcta  ")
        strSQL.Append(" and credpro.ccodcta = @ccodigo   ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar) 'fuente de fondos
        args(0).Value = cCodigo

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function VerificaSiExisteEspejo(ByVal cCodcta As String, ByVal cnrodoc As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodcta from ESPEJOpro ")
        strSQL.Append("where cCodcta = @ccodcta and cnrodoc = @cnrodoc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lverifica As Boolean = False
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cCodcta")) Then
            Else
                lverifica = True
            End If
        End If

        Return lverifica
    End Function
    Public Function InsertaRegistroProvisionEspejo(ByVal cCodcta As String, ByVal cnrodoc As String) As Integer


        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ESPEJOpro ")
        strSQL.Append(" (cCodcta, nprovis, nprovan, nprovpas, nprovmor,  cnrodoc, dfecpro, cflag, ndiaint, ndiaintmor )")
        strSQL.Append(" VALUES (@ccodcta, '0', '0', '0','0', @cnrodoc, getdate(),' ', '0','0') ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizaProvisionEspejo(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ESPEJOpro ")
        strSQL.Append(" SET  nProvis = @nIntAct, nProvan = 0 WHERE cCodcta = @cCodcta and cnrodoc = @cnrodoc ")


        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc
        args(2) = New SqlParameter("@nIntAct", SqlDbType.Decimal)
        args(2).Value = nIntAct
        args(3) = New SqlParameter("@nDesInt", SqlDbType.Decimal)
        args(3).Value = nDesInt


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizaProvisionEspejo2(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ESPEJOpro ")
        strSQL.Append(" SET  nProvis2 = @nIntAct, nProvmor = @nDesInt WHERE cCodcta = @cCodcta and cnrodoc = @cnrodoc ")


        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc
        args(2) = New SqlParameter("@nIntAct", SqlDbType.Decimal)
        args(2).Value = nIntAct
        args(3) = New SqlParameter("@nDesInt", SqlDbType.Decimal)
        args(3).Value = nDesInt


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function ObtenerEspejoProvision(ByVal cCodcta As String, ByVal cnrodoc As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from EspejoPro where cCodcta = @ccodcta and cnrodoc = @cnrodoc ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaProvisiondeEspejo(ByVal cCodcta As String, ByVal nprovis As Double, ByVal nprovan As Double, ByVal nprovmor As Double, ByVal nprovpas As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nprovis = @nprovis, nprovan = @nprovan, nprovmor = @nprovmor, nprovpas = @nprovpas ")
        strSQL.Append(" WHERE cCodcta = @cCodcta ")


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@nprovis", SqlDbType.Decimal)
        args(1).Value = nprovis
        args(2) = New SqlParameter("@nprovan", SqlDbType.Decimal)
        args(2).Value = nprovan
        args(3) = New SqlParameter("@nprovmor", SqlDbType.Decimal)
        args(3).Value = nprovmor
        args(4) = New SqlParameter("@nprovpas", SqlDbType.Decimal)
        args(4).Value = nprovpas


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizaProvisionEspejoM(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ESPEJOpro ")
        strSQL.Append(" SET  nProvpas = @nIntAct, nProvmor = 0 WHERE cCodcta = @cCodcta and cnrodoc = @cnrodoc ")


        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@cnrodoc", SqlDbType.VarChar)
        args(1).Value = cnrodoc
        args(2) = New SqlParameter("@nIntAct", SqlDbType.Decimal)
        args(2).Value = nIntAct
        args(3) = New SqlParameter("@nDesInt", SqlDbType.Decimal)
        args(3).Value = nDesInt


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaProvisionM(ByVal cCodcta As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREDPRO ")
        strSQL.Append(" SET  nProvpas = @nIntAct, nProvmor = 0 WHERE cCodcta = @cCodcta ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        args(1) = New SqlParameter("@nIntAct", SqlDbType.Decimal)
        args(1).Value = nIntAct
        args(2) = New SqlParameter("@nDesInt", SqlDbType.Decimal)
        args(2).Value = nDesInt



        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Sub GenerarBackup(ByVal dfecha As Date)

        Dim lcfecha As String
        lcfecha = dfecha.ToString
        Dim lcbase As String
        lcbase = "BK" + lcfecha.Substring(0, 2) + lcfecha.Substring(3, 2) + lcfecha.Substring(6, 4) + ".bak"

        'Definimos la instruccion SQL para realizar el backup
        'y la ruta donde se guardará dicho respaldo.
        Dim sBackup As String = "BACKUP DATABASE [FUNDEA] " & _
                         "TO DISK = N'C:\TEMP\" & lcbase & "'"

        Using con As New SqlConnection(Me.cnnStr)
            Try
                con.Open()

                'Creamos el comando SQL que realizará el backup
                Dim cmdBackUp As New SqlCommand(sBackup, con)
                'Establecemos el tiempo de respuesta del comando
                'a ilimitado pasando un valor 0 a la propiedad
                'CommandTimeOut para evitar que el tiempo de espera
                'se agote antes de finalizar el backup
                cmdBackUp.CommandTimeout = 0

                'Ejecutamos el backup
                cmdBackUp.ExecuteNonQuery()

            Catch ex As Exception

            Finally
                'Cerramos la conección
                con.Close()
            End Try

        End Using

    End Sub
    Public Function CrearTablasCierreDeMes(ByVal mibase As String) As Integer
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim lcnombre1, lcnombre2, lcnombre3, lcnombre4, lcnombre5, lcnombre6, lcnombre7 As String
        lcnombre1 = mibase.Trim + ".dbo.Cremcre"
        lcnombre2 = mibase.Trim + ".dbo.Cretlin"
        lcnombre3 = mibase.Trim + ".dbo.Cremsol"
        lcnombre4 = mibase.Trim + ".dbo.Credppg"
        lcnombre5 = mibase.Trim + ".dbo.Credkar"
        lcnombre6 = mibase.Trim + ".dbo.Climide"
        lcnombre7 = mibase.Trim + ".dbo.Centros"

        Dim myconnection As SqlConnection
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsgarantia As New DataSet
        Dim nombre_tabla As String
        Dim cnnstr1 As String
        Dim nombase As String
        Dim baseorigen As String = "FUNDEA"
        Dim nomorigen As String
        Dim sql As String

        Dim cmd As SqlCommand


        Try

            nomorigen = baseorigen.Trim & ".dbo.Cremcre"

            myconnection = New SqlConnection(Me.cnnStr)

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre1 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()

            nomorigen = baseorigen.Trim & ".dbo.Cretlin"

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre2 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()

            nomorigen = baseorigen.Trim & ".dbo.Cremsol"

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre3 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()


            nomorigen = baseorigen.Trim & ".dbo.Credppg"

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre4 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()


            nomorigen = baseorigen.Trim & ".dbo.Credkar"

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre5 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()


            nomorigen = baseorigen.Trim & ".dbo.Climide"

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre6 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()

            nomorigen = baseorigen.Trim & ".dbo.Centros"

            sql = "USE " + mibase + "; SELECT * INTO " & lcnombre7 & " FROM " & nomorigen
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()

            'CREA LOS INDICES PARA LAS TABLAS CREADAS

            Dim llaves As String

            llaves = "USE " + mibase + "; ALTER TABLE [dbo].[Centros] ADD  CONSTRAINT [PK_Centros] PRIMARY KEY CLUSTERED ([cCodsol] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ; " & _
            " ALTER TABLE [dbo].[climide] ADD  CONSTRAINT [PK_climide] PRIMARY KEY CLUSTERED ([ccodcli] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]; " & _
            " ALTER TABLE [dbo].[credkar] ADD  CONSTRAINT [PK_credkar] PRIMARY KEY CLUSTERED ([ccodcta] ASC,	[dfecpro] ASC,	[cestado] ASC,	[cnrodoc] ASC,	[ccondic] ASC,	[cconcep] ASC,	[cdescob] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]; " & _
            " ALTER TABLE [dbo].[credppg] ADD  CONSTRAINT [PK_credppg] PRIMARY KEY CLUSTERED ([ccodcta] ASC,	[dfecven] ASC,	[ctipope] ASC,	[cnrocuo] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]; " & _
            " ALTER TABLE [dbo].[cremcre] ADD  CONSTRAINT [PK_cremcre] PRIMARY KEY CLUSTERED ([ccodcta] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]; " & _
            " ALTER TABLE [dbo].[cremsol] ADD  CONSTRAINT [PK_cremsol] PRIMARY KEY CLUSTERED ([cCodsol] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]; " & _
            " ALTER TABLE [dbo].[cretlin] ADD  CONSTRAINT [PK_cretlin] PRIMARY KEY CLUSTERED ([cnrolin] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]; "

            cmd = New SqlCommand(llaves, myconnection)
            myconnection.Open()
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            myconnection.Close()

            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function TrasladaDatos(ByVal aEntidad As entidadBase) As Integer
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter

        Dim lEntidad As cremcre
        lEntidad = aEntidad

        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "INSERT INTO TRASCARTERA(ccodcta, cjuzagado, cNumJuicio, cabogado, dfecdemanda, " & _
                                      "csitactual, nvaldemanda, dfecdes, nvalordesc, ccodusu, dfecmod, ccondicAnt, ccondic) VALUES(" & _
                                      "'" & lEntidad.ccodcta & "','" & lEntidad.cjuzgado & "','" & lEntidad.cnumjuicio & "','" & _
                                      lEntidad.cabogado & "','" & lEntidad.dfecdemanda & "','" & lEntidad.csitactual & "','" & _
                                      lEntidad.nvaldemanda & "','" & lEntidad.dfecdes & "','" & lEntidad.nvalordesc & "','" & lEntidad.ccodusu & _
                                      "','" & lEntidad.dfecmod & "','" & lEntidad.ccondicAnt & "','" & lEntidad.ccondic & "')"
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                lnretorno = 1
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return lnretorno
    End Function
    Public Function Actualiza_Numero_Partida(ByVal ccodigo As String, ByVal cmetodo As String, ByVal cCodofi As String, ByVal cnumcom As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("update asientos set cnumcom = @cnumcom ")
        strSQL.Append("  WHERE ffondos = @ccodigo and ctipmet = @cmetodo and cCodofi =@cCodofi  ")
        Dim args(3) As SqlParameter

        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = ccodigo
        args(1) = New SqlParameter("@cmetodo", SqlDbType.VarChar)
        args(1).Value = cmetodo
        args(2) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(2).Value = cCodofi
        args(3) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(3).Value = cnumcom

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function InteresMoratorio(ByVal cCodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, cretlin.ntasmor ")
        strSQL.Append(" FROM cremcre INNER JOIN ")
        strSQL.Append(" cretlin ON cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE cremcre.ccodcta=@ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        Dim ds As New DataSet
        Dim lnInterMora As Double = 0
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lnInterMora = 0
        Else
            lnInterMora = ds.Tables(0).Rows(0)("ntasmor")
        End If

        Return lnInterMora
    End Function

    Public Function DestinoCredito(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cremcre.ccodcta, cremcre.ccodcli, cremcre.cdescre, LTRIM(RTRIM(tabtdes.cdescri)) as cdescri ")
        strSQL.Append(" FROM cremcre INNER JOIN ")
        strSQL.Append(" tabtdes ON cremcre.cDesCred = tabtdes.ccodigo ")
        strSQL.Append(" WHERE cremcre.ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcDestino As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cdescri")) Then
            Else
                lcDestino = ds.Tables(0).Rows(0)("cdescri")
            End If
        End If
        Return lcDestino
    End Function

    Public Function FormadePago(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT tabttab.cdescri ")
        strSQL.Append(" FROM  cremcre INNER JOIN ")
        strSQL.Append(" tabttab ON cremcre.cfreccap = tabttab.ccodigo ")
        strSQL.Append(" WHERE  (cremcre.ccodcta = @ccodcta) AND (tabttab.ccodtab = '060') AND (tabttab.ctipreg = '1')     ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcFormadePago As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cdescri")) Then
            Else
                lcFormadePago = ds.Tables(0).Rows(0)("cdescri")
            End If
        End If
        Return lcFormadePago
    End Function



    Public Function Extrae_Datos_Arhivo_Dispersion_Garantias(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                            ByVal lldispersa As Integer) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select b.ccodcta, a.cnomcli, b.dfecvig, d.nmonto as ncapdes, b.dfecven, a.id_ife," & _
                                        " b.ccodsol, e.cnomgru, b.ccodofi, f.cnomofi  from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join Dispersa_Garant d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " inner join cremsol e " & _
                                        " on b.ccodsol = e.cCodsol " & _
                                        " inner join tabtofi f " & _
                                        " on b.cCodofi = f.ccodofi " & _
                                        " where (b.dfecsis >= '" & pdfecini & "' and b.dfecsis <= '" & pdfecfin & "') " & _
                                        " and isnull(d.ldispersa,0) = " & lldispersa & _
                                        " order by b.ccodsol, b.cCodofi  "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Data_Desembolsos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Extrae_Datos_Arhivo_Dispersion(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                   ByVal lldispersa As Integer) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                '04 - 08 - 2015 --- se agrego nueva condicion and d.cestado<>'X' es para evitar los duplicados
                command.CommandText = _
                                        " Select b.ccodcta, a.cnomcli, b.dfecvig, d.nmonto as ncapdes, b.dfecven, a.id_ife," & _
                                        " b.ccodsol, e.cnomgru, b.ccodofi, f.cnomofi  from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credkar d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " inner join cremsol e " & _
                                        " on b.ccodsol = e.cCodsol " & _
                                        " inner join tabtofi f " & _
                                        " on b.cCodofi = f.ccodofi " & _
                                        " where b.cestado = 'F' and (b.dfecvig >= '" & pdfecini & "' and b.dfecvig <= '" & pdfecfin & "') " & _
                                        " and d.cdescob = 'D' and  d.cconcep = 'CJ' " & _
                                        " and isnull(d.ldispersa,0) = " & lldispersa & " and d.cestado<>'X' " & _
                                        " order by b.ccodsol, b.cCodofi  "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Data_Desembolsos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Extrae_Datos_Grupo_Solidario(ByVal ccodigo As String) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select a.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci,a.id_ife, b.dfecvig, b.ncapdes, " & _
                                        " c.ccodsol   from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cremsol c " & _
                                        " on b.ccodsol = c.ccodsol " & _
                                        " Where  b.cestado = 'F'  AND  c.cCodsol  = '" & ccodigo & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Data_Grupo")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Extrae_Datos_Grupo_Solidario_Impresion(ByVal ccodigo As String) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select a.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci,a.id_ife,  b.dfecvig, d.nmonto as ncapdes, " & _
                                        " c.ccodsol, space(50) as cletras, space(50) as cmonto   from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cremsol c " & _
                                        " on b.ccodsol = c.ccodsol " & _
                                        " inner join credkar d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " where d.cdescob = 'D' and cconcep = 'CJ'" & _
                                        " and d.cestado <>'X' and b.cestado = 'F' and c.cCodsol  = '" & ccodigo & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Data_Grupo")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Actualiza_Bandera_Digitalización(ByVal ccodcta As String) As Integer


        Dim lnRetorno As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)


        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Update Cremcre set digitaliza_foto = 1" & _
                                        " Where cCodcta ='" & ccodcta & "'"

                command.CommandType = CommandType.Text

                command.ExecuteNonQuery()

                lnRetorno = 1

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnRetorno

    End Function
    'Select datos  29 07 2015
    Public Function select_datosComprobante(ByVal ccodcli As String, ByVal ccodcligar As String) As Integer
        Dim selecrReturn As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim datos As SqlDataReader
        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection
                command.CommandType = CommandType.Text
                command.CommandText = "Select * from Climgar Where ccodcli=@ccodcli and link_foto=@ccodcligar"
                command.Parameters.Add(New SqlParameter("@ccodcli", ccodcli))
                command.Parameters.Add(New SqlParameter("@ccodgar", ccodcligar))
                datos = command.ExecuteReader
                If datos.Read Then
                    selecrReturn = 1
                Else
                    selecrReturn = 0
                End If

                ',[ccodgar]
                ',[ccodcligar]
                ',[Digitalizar]

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        'si es 1 excelente =P
        Return selecrReturn

    End Function
    'inserta datos en taba de garantias
    Public Function inserta_datos_ComprobantesGarantias(ByVal ccodcli As String, ByVal inserccodgar_gar As String, ByVal ccodcligar As String) As Integer
        Dim insertRetorno As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)
        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection
                command.CommandType = CommandType.Text
                command.CommandText = "Insert into Comprobantes_Garantias (ccodcli,ccodgar,ccodcligar) values (@ccodcli,@inserccodgar_gar,@ccodcligar)"
                command.Parameters.Add(New SqlParameter("@ccodcli", ccodcli))
                command.Parameters.Add(New SqlParameter("@inserccodgar_gar", inserccodgar_gar))
                command.Parameters.Add(New SqlParameter("@ccodcligar", ccodcligar))
                command.ExecuteNonQuery()

                insertRetorno = 1

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        'si es 1 excelente =P
        Return insertRetorno


    End Function

    'funcion de actualiza tabla en digitalizar
    Public Function Actualiza_banderas_Comprobante(ByVal codigo As String, ByVal inserccodgar_gar As String, ByVal ccodcligar As String, ByVal firma As String) As Integer
        Dim lnRetorno As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)
        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection
                command.CommandType = CommandType.Text
                command.CommandText = "Update climgar set Digitaliza = 1,link_foto=@link_fotos where ccodcli=@ccodcli and ccodgar=@inserccodgar_gar "
                command.Parameters.Add(New SqlParameter("@ccodcli", codigo))
                command.Parameters.Add(New SqlParameter("@inserccodgar_gar", inserccodgar_gar))
                command.Parameters.Add(New SqlParameter("@link_fotos", ccodcligar))
                command.ExecuteNonQuery()

                lnRetorno = 1

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        Return lnRetorno

    End Function


    Public Function Actualiza_Usuario_Nivel_Comite(ByVal Comite As String, ByVal idusuario As Integer, _
                                                   ByVal pcCodcta As String) As Integer


        Dim lnRetorno As Integer = 0
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim lnComite As Integer = Integer.Parse(Comite)
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection



                Select Case lnComite
                    Case 1
                        _sql = _
                                " Update Cremcre set usuario_comite_1 =" & idusuario & _
                                " Where cCodcta ='" & pcCodcta & "'"
                    Case 2
                        _sql = _
                                " Update Cremcre set usuario_comite_2 =" & idusuario & _
                                " Where cCodcta ='" & pcCodcta & "'"
                    Case 3
                        _sql = _
                                " Update Cremcre set usuario_comite_3 =" & idusuario & _
                                " Where cCodcta ='" & pcCodcta & "'"
                    Case 4
                        _sql = _
                                " Update Cremcre set usuario_comite_4 =" & idusuario & _
                                " Where cCodcta ='" & pcCodcta & "'"
                    Case 5
                        _sql = _
                                " Update Cremcre set usuario_comite_5 =" & idusuario & _
                                " Where cCodcta ='" & pcCodcta & "'"
                End Select


                command.CommandText = _
                                        _sql

                command.CommandType = CommandType.Text

                command.ExecuteNonQuery()

                lnRetorno = 1

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnRetorno

    End Function



    Public Function Valida_Creditos_Vigentes_porCliente(ByVal cCodcli As String) As Boolean

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select isnull(count(b.ccodcta),0) as No from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " Where b.cestado = 'F' AND b.cestado = 'C' AND b.cestado = 'E' " & _
                                        " and b.ccodcli ='" & cCodcli & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Audita_Creditos")


                For Each fila As DataRow In ds_Trab.Tables("Audita_Creditos").Rows
                    If fila("No") > 0 Then
                        llvalida = True
                    End If
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return llvalida

    End Function


    'Realiza el Cambio de status de un Grupo Solidario
    Public Function Realiza_Cambio_Estado_Credito_Sol(ByVal dt_grupo As DataTable, ByVal pcEstado As String) As Integer

        Dim lnRetorno As Integer = 0
        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try



                For Each Fila As DataRow In dt_grupo.Rows

                    'Borrado de Gastos
                    command.CommandText = _
                                              " Delete From credgas " & _
                                              " Where cCodcta ='" & Fila("cCodcta") & "'"

                    command.ExecuteNonQuery()


                    'Borrado de Plan de Pagos
                    command.CommandText = _
                                              " Delete From credtpl " & _
                                              " Where cCodcta ='" & Fila("cCodcta") & "'"

                    command.ExecuteNonQuery()


                    'Borrado de Cheques
                    command.CommandText = _
                                            " Delete From credchq " & _
                                            " Where cCodcta ='" & Fila("cCodcta") & "'"

                    command.ExecuteNonQuery()


                    'Actualiza Estado del Credito
                    command.CommandText = _
                                            " Update Cremcre set cestado = '" & pcEstado & "', digitaliza_foto =0 " & _
                                            " Where cCodcta ='" & Fila("cCodcta") & "'"

                    command.ExecuteNonQuery()


                Next


                ' Attempt to commit the transaction.
                transaction.Commit()
                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using


        Return lnRetorno



    End Function


    'Realiza el Cambio de status de un credito
    Public Function Realiza_Cambio_Estado_Credito(ByVal pcCodcta As String, ByVal pcEstado As String) As Integer

        Dim Fila As DataRow
        Dim lnRetorno As Integer = 0
        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try

                'Borrado de Gastos
                command.CommandText = _
                                          " Delete From credgas " & _
                                          " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                'Borrado de Plan de Pagos
                command.CommandText = _
                                          " Delete From credtpl " & _
                                          " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                'Borrado de Cheques
                command.CommandText = _
                                        " Delete From credchq " & _
                                        " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                'Actualiza Estado del Credito
                command.CommandText = _
                                        " Update Cremcre set cestado = '" & pcEstado & "', digitaliza_foto =0 " & _
                                        " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                ' Attempt to commit the transaction.
                transaction.Commit()
                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using


        Return lnRetorno



    End Function


    'Eliminar Solicitud de Crédito
    Public Function Eliminar_Credito(ByVal pcCodcta As String) As Integer

        Dim Fila As DataRow
        Dim lnRetorno As Integer = 0
        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try

                'Borrado de Gastos
                command.CommandText = _
                                          " Delete From credgas " & _
                                          " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                'Borrado de Plan de Pagos
                command.CommandText = _
                                          " Delete From credtpl " & _
                                          " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                'Borrado de Cheques
                command.CommandText = _
                                        " Delete From credchq " & _
                                        " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                'Elimina Estado del Crédito
                command.CommandText = _
                                        " Delete from Cremcre " & _
                                        " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                ' Attempt to commit the transaction.
                transaction.Commit()
                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using


        Return lnRetorno



    End Function




    'Promocion de Creditos, por cantidad de semanas
    Public Function Cartera_Promociones(ByVal cCodofi As String, ByVal ndias As Integer, _
                                        ByVal pdfecha As Date) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                'Extrae los creditos que apliquen 
                command.CommandText = _
                                        " Select a.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci, a.cteldom, a.ctelfam, a.cdirdom from climide a" & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " Where b.cestado = 'F' and b.nciclo > 2 and b.ccalif <= 'C' and b.cCodofi = '" & cCodofi & "'" & _
                                        " and DATEDIFF(day, b.dfecvig, '" & pdfecha & "') > " & ndias


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Promocion")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    'Genera Informe de Promocion
    Public Function Cartera_Promociones_Detalle(ByVal cCodofi As String, ByVal ndias As Integer, _
                                                ByVal pdfecha As Date) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False
        Dim dr As DataRow
        Dim dt As New DataTable("Detalle_Promociones")

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                dt.Clear()
                'Agregando la Encabezado de la Factura
                dt.Columns.Add("ccodcli", Type.GetType("System.String"))
                dt.Columns.Add("cCodcta", Type.GetType("System.String"))
                dt.Columns.Add("cnomcli", Type.GetType("System.String"))
                dt.Columns.Add("cnudoci", Type.GetType("System.String"))
                dt.Columns.Add("cteldom", Type.GetType("System.String"))
                dt.Columns.Add("ctelfam", Type.GetType("System.String"))
                dt.Columns.Add("cdirdom", Type.GetType("System.String"))
                dt.Columns.Add("ncapdes", Type.GetType("System.Decimal"))
                dt.Columns.Add("dfecvig", Type.GetType("System.DateTime"))
                dt.Columns.Add("dfecven", Type.GetType("System.DateTime"))
                dt.Columns.Add("ccalif", Type.GetType("System.String"))
                ds_Trab.Tables.Add(dt)


                'Extrae los creditos que apliquen 
                command.CommandText = _
                                        " Select a.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci, a.cteldom, a.ctelfam, a.cdirdom from climide a" & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " Where b.cestado = 'F' and b.nciclo > 2 and b.ccalif <= 'C' and b.cCodofi = '" & cCodofi & "'" & _
                                        " and DATEDIFF(day, b.dfecvig, '" & pdfecha & "') > " & ndias

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Promocion")


                For Each fila As DataRow In ds_Trab.Tables("Promocion").Rows


                    command.CommandText = _
                                           " Select a.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci, a.cteldom, a.ctelfam, a.cdirdom, " & _
                                           " b.ncapdes, b.dfecvig, b.dfecven, b.ccalif from climide a" & _
                                           " inner join cremcre b " & _
                                           " on a.ccodcli = b.ccodcli " & _
                                           " Where b.ccodcli ='" & fila("cCodcli") & "' and b.cestado in('F','G') Order by b.dfecvig"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Trab, "Datos_Per")


                    'Inserta en Desconectado Historial de Prestamos
                    For Each Linea As DataRow In ds_Trab.Tables("Datos_Per").Rows

                        dr = ds_Trab.Tables("Detalle_Promociones").NewRow
                        dr("ccodcli") = Linea("ccodcli")
                        dr("cCodcta") = Linea("ccodcta")
                        dr("cnomcli") = Linea("cnomcli")
                        dr("cnudoci") = Linea("cnudoci")
                        dr("cteldom") = Linea("cteldom")
                        dr("ctelfam") = Linea("ctelfam")
                        dr("cdirdom") = Linea("cdirdom")
                        dr("ncapdes") = Linea("ncapdes")
                        dr("dfecvig") = Linea("dfecvig")
                        dr("dfecven") = Linea("dfecven")
                        dr("ccalif") = Linea("ccalif")

                        ds_Trab.Tables("Detalle_Promociones").Rows.Add(dr)
                    Next

                    If ds_Trab.Tables("Datos_Per").Rows.Count > 0 Then
                        ds_Trab.Tables("Datos_Per").Rows.Clear()
                    End If

                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    'Valida porcentaje de Pago de creditos vigente, por cliente
    Public Function Valida_Porcentaje_Refina(ByVal cCodcli As String, ByVal pnPorcenLim As Integer) As Boolean

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False
        Dim dr As DataRow
        Dim dt As New DataTable("Detalle_Promociones")
        Dim lnPorcen As Double

        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection

                'Extrae los creditos que apliquen 
                command.CommandText = _
                                        " Select b.ccodcta, a.cnomcli, b.dfecvig, b.dfecven, b.ncapdes, SUM(d.nmonto) as npagado, " & _
                                        " (b.ncapdes-SUM(d.nmonto)) as nsaldocap  from climide a " & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " inner join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credkar d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " where b.cestado = 'F' " & _
                                        " and b.ccodcli = '" & cCodcli & "' " & _
                                        " and d.cdescob = 'C' " & _
                                        " and d.cconcep = 'KP' and d.cestado <> 'X' " & _
                                        " group by a.cnomcli, b.ccodcta, b.dfecvig, b.ncapdes, b.dfecven " & _
                                        " order by b.dfecvig "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Cartera")


                For Each fila As DataRow In ds_Trab.Tables("Cartera").Rows

                    lnPorcen = Math.Round((fila("npagado") / fila("ncapdes") * 100), 2)

                    If pnPorcenLim <= lnPorcen Then
                        llvalida = True
                    Else
                        llvalida = False
                        Exit For
                    End If
                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return llvalida

    End Function


    'Actualiza la Oficina del Crédito
    Public Function Actualizar_Oficina_Credito(ByVal pcCodcta As String, ByVal pcCodofi As String) As Integer

        Dim Fila As DataRow
        Dim lnRetorno As Integer = 0
        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try


                'Elimina Estado del Crédito
                command.CommandText = _
                                        " Update Cremcre set ccodofi ='" & pcCodofi & "', coficina ='" & pcCodofi & "'" & _
                                        " Where cCodcta ='" & pcCodcta & "'"

                command.ExecuteNonQuery()


                ' Attempt to commit the transaction.
                transaction.Commit()
                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using


        Return lnRetorno



    End Function
    Public Function CancelarCredito(ByVal ccodcta As String)
        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Sp_Cancelar_Credito_Vigente"

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodcta", SqlDbType.VarChar)
                MyParameters.Value = ccodcta
                MyParameters.Direction = ParameterDirection.Input
                MyCommand.CommandType = CommandType.StoredProcedure
                MyCommand.ExecuteNonQuery()
               

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

    End Function

    Public Function EliminarSeguros(ByVal ccodcta As String) As Integer
        Dim validaSeguro As Integer = 0
        '---------------------------
        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try

                'Borrado de Gastos
                command.CommandText = _
                                          " Delete From aux_ingresos " & _
                                          " Where ctiping='03' and ccodcta ='" & ccodcta & "'"

                command.ExecuteNonQuery()

                ' Attempt to commit the transaction.
                transaction.Commit()
                'Console.WriteLine("Both records are written to database.")
                connection.Close()

                validaSeguro = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using
        '-----------------------------
        Return validaSeguro
    End Function



End Class
