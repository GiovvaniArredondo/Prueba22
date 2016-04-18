Imports System.Text
Public Class dbClimide
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcli = "" _
            Or lEntidad.ccodcli = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcli = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE climide ")
        strSQL.Append(" SET ccodofi = @ccodofi, ")
        strSQL.Append(" cnomcli = @cnomcli, ")
        strSQL.Append(" cnomcor = @cnomcor, ")
        strSQL.Append(" ccodsol = @ccodsol, ")
        strSQL.Append(" dnacimi = @dnacimi, ")
        strSQL.Append(" cclaper = @cclaper, ")
        strSQL.Append(" csexo = @csexo, ")
        strSQL.Append(" ctipper = @ctipper, ")
        strSQL.Append(" cindnac = @cindnac, ")
        strSQL.Append(" clugnac = @clugnac, ")
        strSQL.Append(" ctidoci = @ctidoci, ")
        strSQL.Append(" cnudoci = @cnudoci, ")
        strSQL.Append(" ctidotr = @ctidotr, ")
        strSQL.Append(" cnudotr = @cnudotr, ")
        strSQL.Append(" cestciv = @cestciv, ")
        strSQL.Append(" cnivins = @cnivins, ")
        strSQL.Append(" ccodcon = @ccodcon, ")
        strSQL.Append(" npercar = @npercar, ")
        strSQL.Append(" cgrusan = @cgrusan, ")
        strSQL.Append(" ccodpro = @ccodpro, ")
        strSQL.Append(" cestsoc = @cestsoc, ")
        strSQL.Append(" ccoddom = @ccoddom, ")
        strSQL.Append(" cdirdom = @cdirdom, ")
        strSQL.Append(" ccondom = @ccondom, ")
        strSQL.Append(" cteldom = @cteldom, ")
        strSQL.Append(" nanodom = @nanodom, ")
        strSQL.Append(" ccodsbs = @ccodsbs, ")
        strSQL.Append(" caccins = @caccins, ")
        strSQL.Append(" crelins = @crelins, ")
        strSQL.Append(" dregist = @dregist, ")
        strSQL.Append(" ndismen = @ndismen, ")
        strSQL.Append(" ccalint = @ccalint, ")
        strSQL.Append(" ccalext = @ccalext, ")
        strSQL.Append(" ccalpro = @ccalpro, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" cbenef1 = @cbenef1, ")
        strSQL.Append(" cbenef2 = @cbenef2, ")
        strSQL.Append(" dfechai = @dfechai, ")
        strSQL.Append(" nacciones = @nacciones, ")
        strSQL.Append(" ccargo = @ccargo, ")
        strSQL.Append(" cfirma = @cfirma, ")
        strSQL.Append(" cctacte = @cctacte, ")
        strSQL.Append(" cnombco = @cnombco, ")
        strSQL.Append(" lactivo = @lactivo, ")
        strSQL.Append(" cdevol = @cdevol, ")
        strSQL.Append(" cubifue = @cubifue, ")
        strSQL.Append(" cdirfue = @cdirfue, ")
        strSQL.Append(" nHijos = @nHijos, ")
        strSQL.Append(" nOtros = @nOtros, ")
        strSQL.Append(" cTipcli = @cTipcli, ")
        strSQL.Append(" cEscolar = @cEscolar, ")
        strSQL.Append(" cLugExp = @cLugExp, ")
        strSQL.Append(" dfchExp = @dfchExp, ")
        strSQL.Append(" cTipcli1 = @cTipcli1, ")
        strSQL.Append(" cTipviv = @cTipviv, ")
        strSQL.Append(" cDomAnt = @cDomAnt, ")
        strSQL.Append(" cTiemRes = @cTiemRes, ")
        strSQL.Append(" cRefe = @cRefe, ")
        strSQL.Append(" cSabeEsc = @cSabeEsc, ")
        strSQL.Append(" cNomDño = @cNomDño, ")
        strSQL.Append(" cTelDño = @cTelDño, ")
        strSQL.Append(" cNomcon = @cNomcon, ")
        strSQL.Append(" cTipCony = @cTipCony, ")
        strSQL.Append(" cDuiCony = @cDuiCony, ")
        strSQL.Append(" cSexcon = @cSexcon, ")
        strSQL.Append(" cProfCon = @cProfCon, ")
        strSQL.Append(" cLtrab = @cLtrab, ")
        strSQL.Append(" cDirCon = @cDirCon, ")
        strSQL.Append(" cTelcon = @cTelcon, ")
        strSQL.Append(" cSactCon = @cSactCon, ")
        strSQL.Append(" cTiempCon = @cTiempCon, ")
        strSQL.Append(" mDatAdi = @mDatAdi, ")
        strSQL.Append(" cNomInv = @cNomInv, ")
        strSQL.Append(" cPrefe1 = @cPrefe1, ")
        strSQL.Append(" cDomInv = @cDomInv, ")
        strSQL.Append(" cTelInv = @cTelInv, ")
        strSQL.Append(" cLugInv = @cLugInv, ")
        strSQL.Append(" cTelLugInv = @cTelLugInv, ")
        strSQL.Append(" cNomFam = @cNomFam, ")
        strSQL.Append(" cPrefe2 = @cPrefe2, ")
        strSQL.Append(" cDomFam = @cDomFam, ")
        strSQL.Append(" cTelFam = @cTelFam, ")
        strSQL.Append(" cLugFam = @cLugFam, ")
        strSQL.Append(" cTelLugFam = @cTelLugFam, ")
        strSQL.Append(" cNomVec = @cNomVec, ")
        strSQL.Append(" cPrefe3 = @cPrefe3, ")
        strSQL.Append(" cDomVec = @cDomVec, ")
        strSQL.Append(" cTelVec = @cTelVec, ")
        strSQL.Append(" clugVec = @clugVec ")
        strSQL.Append(" cTelLugVec = @cTelLugVec, ")
        strSQL.Append(" cAnoDom = @cAnoDom, ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(91) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodofi
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomcli
        args(2) = New SqlParameter("@cnomcor", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomcor
        args(3) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodsol
        args(4) = New SqlParameter("@dnacimi", SqlDbType.DateTime)
        args(4).Value = lEntidad.dnacimi
        args(5) = New SqlParameter("@cclaper", SqlDbType.VarChar)
        args(5).Value = lEntidad.cclaper
        args(6) = New SqlParameter("@csexo", SqlDbType.VarChar)
        args(6).Value = lEntidad.csexo
        args(7) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(7).Value = lEntidad.ctipper
        args(8) = New SqlParameter("@cindnac", SqlDbType.VarChar)
        args(8).Value = lEntidad.cindnac
        args(9) = New SqlParameter("@clugnac", SqlDbType.VarChar)
        args(9).Value = lEntidad.clugnac
        args(10) = New SqlParameter("@ctidoci", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctidoci
        args(11) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(11).Value = lEntidad.cnudoci
        args(12) = New SqlParameter("@ctidotr", SqlDbType.VarChar)
        args(12).Value = lEntidad.ctidotr
        args(13) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(13).Value = lEntidad.cnudotr
        args(14) = New SqlParameter("@cestciv", SqlDbType.VarChar)
        args(14).Value = lEntidad.cestciv
        args(15) = New SqlParameter("@cnivins", SqlDbType.VarChar)
        args(15).Value = lEntidad.cnivins
        args(16) = New SqlParameter("@ccodcon", SqlDbType.VarChar)
        args(16).Value = lEntidad.ccodcon
        args(17) = New SqlParameter("@npercar", SqlDbType.VarChar)
        args(17).Value = lEntidad.npercar
        args(18) = New SqlParameter("@cgrusan", SqlDbType.VarChar)
        args(18).Value = lEntidad.cgrusan
        args(19) = New SqlParameter("@ccodpro", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodpro
        args(20) = New SqlParameter("@cestsoc", SqlDbType.VarChar)
        args(20).Value = lEntidad.cestsoc
        args(21) = New SqlParameter("@ccoddom", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccoddom
        args(22) = New SqlParameter("@cdirdom", SqlDbType.VarChar)
        args(22).Value = lEntidad.cdirdom
        args(23) = New SqlParameter("@ccondom", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccondom
        args(24) = New SqlParameter("@cteldom", SqlDbType.VarChar)
        args(24).Value = lEntidad.cteldom
        args(25) = New SqlParameter("@nanodom", SqlDbType.VarChar)
        args(25).Value = lEntidad.nanodom
        args(26) = New SqlParameter("@ccodsbs", SqlDbType.VarChar)
        args(26).Value = lEntidad.ccodsbs
        args(27) = New SqlParameter("@caccins", SqlDbType.VarChar)
        args(27).Value = lEntidad.caccins
        args(28) = New SqlParameter("@crelins", SqlDbType.VarChar)
        args(28).Value = lEntidad.crelins
        args(29) = New SqlParameter("@dregist", SqlDbType.DateTime)
        args(29).Value = lEntidad.dregist
        args(30) = New SqlParameter("@ndismen", SqlDbType.VarChar)
        args(30).Value = lEntidad.ndismen
        args(31) = New SqlParameter("@ccalint", SqlDbType.VarChar)
        args(31).Value = lEntidad.ccalint
        args(32) = New SqlParameter("@ccalext", SqlDbType.VarChar)
        args(32).Value = lEntidad.ccalext
        args(33) = New SqlParameter("@ccalpro", SqlDbType.VarChar)
        args(33).Value = lEntidad.ccalpro
        args(34) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(34).Value = lEntidad.ccodusu
        args(35) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(35).Value = lEntidad.dfecmod
        args(36) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(36).Value = lEntidad.cflag
        args(37) = New SqlParameter("@cbenef1", SqlDbType.VarChar)
        args(37).Value = lEntidad.cbenef1
        args(38) = New SqlParameter("@cbenef2", SqlDbType.VarChar)
        args(38).Value = lEntidad.cbenef2
        args(39) = New SqlParameter("@dfechai", SqlDbType.DateTime)
        args(39).Value = lEntidad.dfechai
        args(40) = New SqlParameter("@nacciones", SqlDbType.VarChar)
        args(40).Value = lEntidad.nacciones
        args(41) = New SqlParameter("@ccargo", SqlDbType.VarChar)
        args(41).Value = lEntidad.ccargo
        args(42) = New SqlParameter("@cfirma", SqlDbType.VarChar)
        args(42).Value = lEntidad.cfirma
        args(43) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(43).Value = lEntidad.cctacte
        args(44) = New SqlParameter("@cnombco", SqlDbType.VarChar)
        args(44).Value = lEntidad.cnombco
        args(45) = New SqlParameter("@lactivo", SqlDbType.Bit)
        args(45).Value = lEntidad.lactivo
        args(46) = New SqlParameter("@cdevol", SqlDbType.VarChar)
        args(46).Value = lEntidad.cdevol
        args(47) = New SqlParameter("@cubifue", SqlDbType.VarChar)
        args(47).Value = lEntidad.cubifue
        args(48) = New SqlParameter("@cdirfue", SqlDbType.VarChar)
        args(48).Value = lEntidad.cdirfue
        args(49) = New SqlParameter("@nHijos", SqlDbType.VarChar)
        args(49).Value = lEntidad.nHijos
        args(50) = New SqlParameter("@nOtros", SqlDbType.VarChar)
        args(50).Value = lEntidad.nOtros
        args(51) = New SqlParameter("@cTipcli", SqlDbType.VarChar)
        args(51).Value = lEntidad.cTipcli
        args(52) = New SqlParameter("@cEscolar", SqlDbType.VarChar)
        args(52).Value = lEntidad.cEscolar
        args(53) = New SqlParameter("@cLugExp", SqlDbType.VarChar)
        args(53).Value = lEntidad.cLugExp
        args(54) = New SqlParameter("@dfchExp", SqlDbType.DateTime)
        args(54).Value = lEntidad.dfchExp
        args(55) = New SqlParameter("@cTipcli1", SqlDbType.VarChar)
        args(55).Value = lEntidad.cTipcli1
        args(56) = New SqlParameter("@cTipviv", SqlDbType.VarChar)
        args(56).Value = lEntidad.cTipviv
        args(57) = New SqlParameter("@cDomAnt", SqlDbType.VarChar)
        args(57).Value = lEntidad.cDomAnt
        args(58) = New SqlParameter("@cTiemRes", SqlDbType.VarChar)
        args(58).Value = lEntidad.cTiemRes
        args(59) = New SqlParameter("@cRefe", SqlDbType.VarChar)
        args(59).Value = lEntidad.cRefe
        args(60) = New SqlParameter("@cSabeEsc", SqlDbType.VarChar)
        args(60).Value = lEntidad.cSabeEsc
        args(61) = New SqlParameter("@cNomDño", SqlDbType.VarChar)
        args(61).Value = lEntidad.cNomDño
        args(62) = New SqlParameter("@cTelDño", SqlDbType.VarChar)
        args(62).Value = lEntidad.cTelDño
        args(63) = New SqlParameter("@cNomcon", SqlDbType.VarChar)
        args(63).Value = lEntidad.cNomcon
        args(64) = New SqlParameter("@cTipCony", SqlDbType.VarChar)
        args(64).Value = lEntidad.cTipCony
        args(65) = New SqlParameter("@cDuiCony", SqlDbType.VarChar)
        args(65).Value = lEntidad.cDuiCony
        args(66) = New SqlParameter("@cSexcon", SqlDbType.VarChar)
        args(66).Value = lEntidad.cSexcon
        args(67) = New SqlParameter("@cProfCon", SqlDbType.VarChar)
        args(67).Value = lEntidad.cProfCon
        args(68) = New SqlParameter("@cLtrab", SqlDbType.VarChar)
        args(68).Value = lEntidad.cLtrab
        args(69) = New SqlParameter("@cDirCon", SqlDbType.VarChar)
        args(69).Value = lEntidad.cDirCon
        args(70) = New SqlParameter("@cTelcon", SqlDbType.VarChar)
        args(70).Value = lEntidad.cTelcon
        args(71) = New SqlParameter("@cSactCon", SqlDbType.VarChar)
        args(71).Value = lEntidad.cSactCon
        args(72) = New SqlParameter("@cTiempCon", SqlDbType.VarChar)
        args(72).Value = lEntidad.cTiempCon
        args(73) = New SqlParameter("@mDatAdi", SqlDbType.VarChar)
        args(73).Value = lEntidad.mDatAdi
        args(74) = New SqlParameter("@cNomInv", SqlDbType.VarChar)
        args(74).Value = lEntidad.cNomInv
        args(75) = New SqlParameter("@cPrefe1", SqlDbType.VarChar)
        args(75).Value = lEntidad.cPrefe1
        args(76) = New SqlParameter("@cDomInv", SqlDbType.VarChar)
        args(76).Value = lEntidad.cDomInv
        args(77) = New SqlParameter("@cTelInv", SqlDbType.VarChar)
        args(77).Value = lEntidad.cTelInv
        args(78) = New SqlParameter("@cLugInv", SqlDbType.VarChar)
        args(78).Value = lEntidad.cLugInv
        args(79) = New SqlParameter("@cTelLugInv", SqlDbType.VarChar)
        args(79).Value = lEntidad.cTelLugInv
        args(80) = New SqlParameter("@cNomFam", SqlDbType.VarChar)
        args(80).Value = lEntidad.cNomFam
        args(81) = New SqlParameter("@cPrefe2", SqlDbType.VarChar)
        args(81).Value = lEntidad.cPrefe2
        args(82) = New SqlParameter("@cDomFam", SqlDbType.VarChar)
        args(82).Value = lEntidad.cDomFam
        args(83) = New SqlParameter("@cTelFam", SqlDbType.VarChar)
        args(83).Value = lEntidad.cTelFam
        args(84) = New SqlParameter("@cLugFam", SqlDbType.VarChar)
        args(84).Value = lEntidad.cLugFam
        args(85) = New SqlParameter("@cTelLugFam", SqlDbType.VarChar)
        args(85).Value = lEntidad.cTelLugFam
        args(86) = New SqlParameter("@cNomVec", SqlDbType.VarChar)
        args(86).Value = lEntidad.cNomVec
        args(87) = New SqlParameter("@cPrefe3", SqlDbType.VarChar)
        args(87).Value = lEntidad.cPrefe3
        args(88) = New SqlParameter("@cDomVec", SqlDbType.VarChar)
        args(88).Value = lEntidad.cDomVec
        args(89) = New SqlParameter("@cTelVec", SqlDbType.VarChar)
        args(89).Value = lEntidad.cTelVec
        args(90) = New SqlParameter("@clugVec", SqlDbType.VarChar)
        args(90).Value = lEntidad.clugVec
        args(91) = New SqlParameter("@cTelLugVec", SqlDbType.VarChar)
        args(91).Value = lEntidad.cTelLugVec
        args(92) = New SqlParameter("@cAnoDom", SqlDbType.VarChar)
        args(92).Value = lEntidad.cAnoDom
        args(93) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(93).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO climide ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" cnomcor, ") 
        strSQL.Append(" ccodsol, ") 
        strSQL.Append(" dnacimi, ") 
        strSQL.Append(" cclaper, ") 
        strSQL.Append(" csexo, ") 
        strSQL.Append(" ctipper, ") 
        strSQL.Append(" cindnac, ") 
        strSQL.Append(" clugnac, ") 
        strSQL.Append(" ctidoci, ") 
        strSQL.Append(" cnudoci, ") 
        strSQL.Append(" ctidotr, ") 
        strSQL.Append(" cnudotr, ") 
        strSQL.Append(" cestciv, ") 
        strSQL.Append(" cnivins, ") 
        strSQL.Append(" ccodcon, ") 
        strSQL.Append(" npercar, ") 
        strSQL.Append(" cgrusan, ") 
        strSQL.Append(" ccodpro, ") 
        strSQL.Append(" cestsoc, ") 
        strSQL.Append(" ccoddom, ") 
        strSQL.Append(" cdirdom, ") 
        strSQL.Append(" ccondom, ") 
        strSQL.Append(" cteldom, ") 
        strSQL.Append(" nanodom, ") 
        strSQL.Append(" ccodsbs, ") 
        strSQL.Append(" caccins, ") 
        strSQL.Append(" crelins, ") 
        strSQL.Append(" dregist, ") 
        strSQL.Append(" ndismen, ") 
        strSQL.Append(" ccalint, ") 
        strSQL.Append(" ccalext, ") 
        strSQL.Append(" ccalpro, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" cbenef1, ") 
        strSQL.Append(" cbenef2, ") 
        strSQL.Append(" dfechai, ") 
        strSQL.Append(" nacciones, ") 
        strSQL.Append(" ccargo, ") 
        strSQL.Append(" cfirma, ") 
        strSQL.Append(" cctacte, ") 
        strSQL.Append(" cnombco, ") 
        strSQL.Append(" lactivo, ") 
        strSQL.Append(" cdevol, ") 
        strSQL.Append(" cubifue, ") 
        strSQL.Append(" cdirfue, ") 
        strSQL.Append(" nHijos, ") 
        strSQL.Append(" nOtros, ") 
        strSQL.Append(" cTipcli, ") 
        strSQL.Append(" cEscolar, ") 
        strSQL.Append(" cLugExp, ") 
        strSQL.Append(" dfchExp, ") 
        strSQL.Append(" cTipcli1, ") 
        strSQL.Append(" cTipviv, ") 
        strSQL.Append(" cDomAnt, ") 
        strSQL.Append(" cTiemRes, ") 
        strSQL.Append(" cRefe, ") 
        strSQL.Append(" cSabeEsc, ") 
        strSQL.Append(" cNomDño, ") 
        strSQL.Append(" cTelDño, ") 
        strSQL.Append(" cNomcon, ") 
        strSQL.Append(" cTipCony, ") 
        strSQL.Append(" cDuiCony, ") 
        strSQL.Append(" cSexcon, ") 
        strSQL.Append(" cProfCon, ") 
        strSQL.Append(" cLtrab, ") 
        strSQL.Append(" cDirCon, ") 
        strSQL.Append(" cTelcon, ") 
        strSQL.Append(" cSactCon, ") 
        strSQL.Append(" cTiempCon, ") 
        strSQL.Append(" mDatAdi, ") 
        strSQL.Append(" cNomInv, ") 
        strSQL.Append(" cPrefe1, ") 
        strSQL.Append(" cDomInv, ") 
        strSQL.Append(" cTelInv, ") 
        strSQL.Append(" cLugInv, ") 
        strSQL.Append(" cTelLugInv, ") 
        strSQL.Append(" cNomFam, ") 
        strSQL.Append(" cPrefe2, ") 
        strSQL.Append(" cDomFam, ") 
        strSQL.Append(" cTelFam, ") 
        strSQL.Append(" cLugFam, ") 
        strSQL.Append(" cTelLugFam, ") 
        strSQL.Append(" cNomVec, ") 
        strSQL.Append(" cPrefe3, ") 
        strSQL.Append(" cDomVec, ") 
        strSQL.Append(" cTelVec, ") 
        strSQL.Append(" clugVec) ") 
        strSQL.Append(" cTelLugVec, ") 
        strSQL.Append(" cAnoDom, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodofi, ") 
        strSQL.Append(" @cnomcli, ") 
        strSQL.Append(" @cnomcor, ") 
        strSQL.Append(" @ccodsol, ") 
        strSQL.Append(" @dnacimi, ") 
        strSQL.Append(" @cclaper, ") 
        strSQL.Append(" @csexo, ") 
        strSQL.Append(" @ctipper, ") 
        strSQL.Append(" @cindnac, ") 
        strSQL.Append(" @clugnac, ") 
        strSQL.Append(" @ctidoci, ") 
        strSQL.Append(" @cnudoci, ") 
        strSQL.Append(" @ctidotr, ") 
        strSQL.Append(" @cnudotr, ") 
        strSQL.Append(" @cestciv, ") 
        strSQL.Append(" @cnivins, ") 
        strSQL.Append(" @ccodcon, ") 
        strSQL.Append(" @npercar, ") 
        strSQL.Append(" @cgrusan, ") 
        strSQL.Append(" @ccodpro, ") 
        strSQL.Append(" @cestsoc, ") 
        strSQL.Append(" @ccoddom, ") 
        strSQL.Append(" @cdirdom, ") 
        strSQL.Append(" @ccondom, ") 
        strSQL.Append(" @cteldom, ") 
        strSQL.Append(" @nanodom, ") 
        strSQL.Append(" @ccodsbs, ") 
        strSQL.Append(" @caccins, ") 
        strSQL.Append(" @crelins, ") 
        strSQL.Append(" @dregist, ") 
        strSQL.Append(" @ndismen, ") 
        strSQL.Append(" @ccalint, ") 
        strSQL.Append(" @ccalext, ") 
        strSQL.Append(" @ccalpro, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @cbenef1, ") 
        strSQL.Append(" @cbenef2, ") 
        strSQL.Append(" @dfechai, ") 
        strSQL.Append(" @nacciones, ") 
        strSQL.Append(" @ccargo, ") 
        strSQL.Append(" @cfirma, ") 
        strSQL.Append(" @cctacte, ") 
        strSQL.Append(" @cnombco, ") 
        strSQL.Append(" @lactivo, ") 
        strSQL.Append(" @cdevol, ") 
        strSQL.Append(" @cubifue, ") 
        strSQL.Append(" @cdirfue, ") 
        strSQL.Append(" @nHijos, ") 
        strSQL.Append(" @nOtros, ") 
        strSQL.Append(" @cTipcli, ") 
        strSQL.Append(" @cEscolar, ") 
        strSQL.Append(" @cLugExp, ") 
        strSQL.Append(" @dfchExp, ") 
        strSQL.Append(" @cTipcli1, ") 
        strSQL.Append(" @cTipviv, ") 
        strSQL.Append(" @cDomAnt, ") 
        strSQL.Append(" @cTiemRes, ") 
        strSQL.Append(" @cRefe, ") 
        strSQL.Append(" @cSabeEsc, ") 
        strSQL.Append(" @cNomDño, ") 
        strSQL.Append(" @cTelDño, ") 
        strSQL.Append(" @cNomcon, ") 
        strSQL.Append(" @cTipCony, ") 
        strSQL.Append(" @cDuiCony, ") 
        strSQL.Append(" @cSexcon, ") 
        strSQL.Append(" @cProfCon, ") 
        strSQL.Append(" @cLtrab, ") 
        strSQL.Append(" @cDirCon, ") 
        strSQL.Append(" @cTelcon, ") 
        strSQL.Append(" @cSactCon, ") 
        strSQL.Append(" @cTiempCon, ") 
        strSQL.Append(" @mDatAdi, ") 
        strSQL.Append(" @cNomInv, ") 
        strSQL.Append(" @cPrefe1, ") 
        strSQL.Append(" @cDomInv, ") 
        strSQL.Append(" @cTelInv, ") 
        strSQL.Append(" @cLugInv, ") 
        strSQL.Append(" @cTelLugInv, ") 
        strSQL.Append(" @cNomFam, ") 
        strSQL.Append(" @cPrefe2, ") 
        strSQL.Append(" @cDomFam, ") 
        strSQL.Append(" @cTelFam, ") 
        strSQL.Append(" @cLugFam, ") 
        strSQL.Append(" @cTelLugFam, ") 
        strSQL.Append(" @cNomVec, ") 
        strSQL.Append(" @cPrefe3, ") 
        strSQL.Append(" @cDomVec, ") 
        strSQL.Append(" @cTelVec, ") 
        strSQL.Append(" @clugVec) ") 
        strSQL.Append(" @cTelLugVec, ") 
        strSQL.Append(" @cAnoDom, ") 

        Dim args(91) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodofi
        args(2) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomcli
        args(3) = New SqlParameter("@cnomcor", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomcor
        args(4) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodsol
        args(5) = New SqlParameter("@dnacimi", SqlDbType.Datetime)
        args(5).Value = lEntidad.dnacimi
        args(6) = New SqlParameter("@cclaper", SqlDbType.VarChar)
        args(6).Value = lEntidad.cclaper
        args(7) = New SqlParameter("@csexo", SqlDbType.VarChar)
        args(7).Value = lEntidad.csexo
        args(8) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctipper
        args(9) = New SqlParameter("@cindnac", SqlDbType.VarChar)
        args(9).Value = lEntidad.cindnac
        args(10) = New SqlParameter("@clugnac", SqlDbType.VarChar)
        args(10).Value = lEntidad.clugnac
        args(11) = New SqlParameter("@ctidoci", SqlDbType.VarChar)
        args(11).Value = lEntidad.ctidoci
        args(12) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(12).Value = lEntidad.cnudoci
        args(13) = New SqlParameter("@ctidotr", SqlDbType.VarChar)
        args(13).Value = lEntidad.ctidotr
        args(14) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(14).Value = lEntidad.cnudotr
        args(15) = New SqlParameter("@cestciv", SqlDbType.VarChar)
        args(15).Value = lEntidad.cestciv
        args(16) = New SqlParameter("@cnivins", SqlDbType.VarChar)
        args(16).Value = lEntidad.cnivins
        args(17) = New SqlParameter("@ccodcon", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodcon
        args(18) = New SqlParameter("@npercar", SqlDbType.VarChar)
        args(18).Value = lEntidad.npercar
        args(19) = New SqlParameter("@cgrusan", SqlDbType.VarChar)
        args(19).Value = lEntidad.cgrusan
        args(20) = New SqlParameter("@ccodpro", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodpro
        args(21) = New SqlParameter("@cestsoc", SqlDbType.VarChar)
        args(21).Value = lEntidad.cestsoc
        args(22) = New SqlParameter("@ccoddom", SqlDbType.VarChar)
        args(22).Value = lEntidad.ccoddom
        args(23) = New SqlParameter("@cdirdom", SqlDbType.VarChar)
        args(23).Value = lEntidad.cdirdom
        args(24) = New SqlParameter("@ccondom", SqlDbType.VarChar)
        args(24).Value = lEntidad.ccondom
        args(25) = New SqlParameter("@cteldom", SqlDbType.VarChar)
        args(25).Value = lEntidad.cteldom
        args(26) = New SqlParameter("@nanodom", SqlDbType.VarChar)
        args(26).Value = lEntidad.nanodom
        args(27) = New SqlParameter("@ccodsbs", SqlDbType.VarChar)
        args(27).Value = lEntidad.ccodsbs
        args(28) = New SqlParameter("@caccins", SqlDbType.VarChar)
        args(28).Value = lEntidad.caccins
        args(29) = New SqlParameter("@crelins", SqlDbType.VarChar)
        args(29).Value = lEntidad.crelins
        args(30) = New SqlParameter("@dregist", SqlDbType.Datetime)
        args(30).Value = lEntidad.dregist
        args(31) = New SqlParameter("@ndismen", SqlDbType.VarChar)
        args(31).Value = lEntidad.ndismen
        args(32) = New SqlParameter("@ccalint", SqlDbType.VarChar)
        args(32).Value = lEntidad.ccalint
        args(33) = New SqlParameter("@ccalext", SqlDbType.VarChar)
        args(33).Value = lEntidad.ccalext
        args(34) = New SqlParameter("@ccalpro", SqlDbType.VarChar)
        args(34).Value = lEntidad.ccalpro
        args(35) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(35).Value = lEntidad.ccodusu
        args(36) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(36).Value = lEntidad.dfecmod
        args(37) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(37).Value = lEntidad.cflag
        args(38) = New SqlParameter("@cbenef1", SqlDbType.VarChar)
        args(38).Value = lEntidad.cbenef1
        args(39) = New SqlParameter("@cbenef2", SqlDbType.VarChar)
        args(39).Value = lEntidad.cbenef2
        args(40) = New SqlParameter("@dfechai", SqlDbType.Datetime)
        args(40).Value = lEntidad.dfechai
        args(41) = New SqlParameter("@nacciones", SqlDbType.VarChar)
        args(41).Value = lEntidad.nacciones
        args(42) = New SqlParameter("@ccargo", SqlDbType.VarChar)
        args(42).Value = lEntidad.ccargo
        args(43) = New SqlParameter("@cfirma", SqlDbType.VarChar)
        args(43).Value = lEntidad.cfirma
        args(44) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(44).Value = lEntidad.cctacte
        args(45) = New SqlParameter("@cnombco", SqlDbType.VarChar)
        args(45).Value = lEntidad.cnombco
        args(46) = New SqlParameter("@lactivo", SqlDbType.Bit)
        args(46).Value = lEntidad.lactivo
        args(47) = New SqlParameter("@cdevol", SqlDbType.VarChar)
        args(47).Value = lEntidad.cdevol
        args(48) = New SqlParameter("@cubifue", SqlDbType.VarChar)
        args(48).Value = lEntidad.cubifue
        args(49) = New SqlParameter("@cdirfue", SqlDbType.VarChar)
        args(49).Value = lEntidad.cdirfue
        args(50) = New SqlParameter("@nHijos", SqlDbType.VarChar)
        args(50).Value = lEntidad.nHijos
        args(51) = New SqlParameter("@nOtros", SqlDbType.VarChar)
        args(51).Value = lEntidad.nOtros
        args(52) = New SqlParameter("@cTipcli", SqlDbType.VarChar)
        args(52).Value = lEntidad.cTipcli
        args(53) = New SqlParameter("@cEscolar", SqlDbType.VarChar)
        args(53).Value = lEntidad.cEscolar
        args(54) = New SqlParameter("@cLugExp", SqlDbType.VarChar)
        args(54).Value = lEntidad.cLugExp
        args(55) = New SqlParameter("@dfchExp", SqlDbType.Datetime)
        args(55).Value = lEntidad.dfchExp
        args(56) = New SqlParameter("@cTipcli1", SqlDbType.VarChar)
        args(56).Value = lEntidad.cTipcli1
        args(57) = New SqlParameter("@cTipviv", SqlDbType.VarChar)
        args(57).Value = lEntidad.cTipviv
        args(58) = New SqlParameter("@cDomAnt", SqlDbType.VarChar)
        args(58).Value = lEntidad.cDomAnt
        args(59) = New SqlParameter("@cTiemRes", SqlDbType.VarChar)
        args(59).Value = lEntidad.cTiemRes
        args(60) = New SqlParameter("@cRefe", SqlDbType.VarChar)
        args(60).Value = lEntidad.cRefe
        args(61) = New SqlParameter("@cSabeEsc", SqlDbType.VarChar)
        args(61).Value = lEntidad.cSabeEsc
        args(62) = New SqlParameter("@cNomDño", SqlDbType.VarChar)
        args(62).Value = lEntidad.cNomDño
        args(63) = New SqlParameter("@cTelDño", SqlDbType.VarChar)
        args(63).Value = lEntidad.cTelDño
        args(64) = New SqlParameter("@cNomcon", SqlDbType.VarChar)
        args(64).Value = lEntidad.cNomcon
        args(65) = New SqlParameter("@cTipCony", SqlDbType.VarChar)
        args(65).Value = lEntidad.cTipCony
        args(66) = New SqlParameter("@cDuiCony", SqlDbType.VarChar)
        args(66).Value = lEntidad.cDuiCony
        args(67) = New SqlParameter("@cSexcon", SqlDbType.VarChar)
        args(67).Value = lEntidad.cSexcon
        args(68) = New SqlParameter("@cProfCon", SqlDbType.VarChar)
        args(68).Value = lEntidad.cProfCon
        args(69) = New SqlParameter("@cLtrab", SqlDbType.VarChar)
        args(69).Value = lEntidad.cLtrab
        args(70) = New SqlParameter("@cDirCon", SqlDbType.VarChar)
        args(70).Value = lEntidad.cDirCon
        args(71) = New SqlParameter("@cTelcon", SqlDbType.VarChar)
        args(71).Value = lEntidad.cTelcon
        args(72) = New SqlParameter("@cSactCon", SqlDbType.VarChar)
        args(72).Value = lEntidad.cSactCon
        args(73) = New SqlParameter("@cTiempCon", SqlDbType.VarChar)
        args(73).Value = lEntidad.cTiempCon
        args(74) = New SqlParameter("@mDatAdi", SqlDbType.VarChar)
        args(74).Value = lEntidad.mDatAdi
        args(75) = New SqlParameter("@cNomInv", SqlDbType.VarChar)
        args(75).Value = lEntidad.cNomInv
        args(76) = New SqlParameter("@cPrefe1", SqlDbType.VarChar)
        args(76).Value = lEntidad.cPrefe1
        args(77) = New SqlParameter("@cDomInv", SqlDbType.VarChar)
        args(77).Value = lEntidad.cDomInv
        args(78) = New SqlParameter("@cTelInv", SqlDbType.VarChar)
        args(78).Value = lEntidad.cTelInv
        args(79) = New SqlParameter("@cLugInv", SqlDbType.VarChar)
        args(79).Value = lEntidad.cLugInv
        args(80) = New SqlParameter("@cTelLugInv", SqlDbType.VarChar)
        args(80).Value = lEntidad.cTelLugInv
        args(81) = New SqlParameter("@cNomFam", SqlDbType.VarChar)
        args(81).Value = lEntidad.cNomFam
        args(82) = New SqlParameter("@cPrefe2", SqlDbType.VarChar)
        args(82).Value = lEntidad.cPrefe2
        args(83) = New SqlParameter("@cDomFam", SqlDbType.VarChar)
        args(83).Value = lEntidad.cDomFam
        args(84) = New SqlParameter("@cTelFam", SqlDbType.VarChar)
        args(84).Value = lEntidad.cTelFam
        args(85) = New SqlParameter("@cLugFam", SqlDbType.VarChar)
        args(85).Value = lEntidad.cLugFam
        args(86) = New SqlParameter("@cTelLugFam", SqlDbType.VarChar)
        args(86).Value = lEntidad.cTelLugFam
        args(87) = New SqlParameter("@cNomVec", SqlDbType.VarChar)
        args(87).Value = lEntidad.cNomVec
        args(88) = New SqlParameter("@cPrefe3", SqlDbType.VarChar)
        args(88).Value = lEntidad.cPrefe3
        args(89) = New SqlParameter("@cDomVec", SqlDbType.VarChar)
        args(89).Value = lEntidad.cDomVec
        args(90) = New SqlParameter("@cTelVec", SqlDbType.VarChar)
        args(90).Value = lEntidad.cTelVec
        args(91) = New SqlParameter("@clugVec", SqlDbType.VarChar)
        args(91).Value = lEntidad.clugVec
        args(92) = New SqlParameter("@cTelLugVec", SqlDbType.VarChar)
        args(92).Value = lEntidad.cTelLugVec
        args(93) = New SqlParameter("@cAnoDom", SqlDbType.VarChar)
        args(93).Value = lEntidad.cAnoDom

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM climide ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
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
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, "", .Item("cnomcli"))
                lEntidad.cnomcor = IIf(.Item("cnomcor") Is DBNull.Value, "", .Item("cnomcor"))
                lEntidad.ccodsol = IIf(.Item("ccodsol") Is DBNull.Value, "", .Item("ccodsol"))
                lEntidad.dnacimi = IIf(.Item("dnacimi") Is DBNull.Value, Nothing, .Item("dnacimi"))
                lEntidad.cclaper = IIf(.Item("cclaper") Is DBNull.Value, Nothing, .Item("cclaper"))
                lEntidad.csexo = IIf(.Item("csexo") Is DBNull.Value, "X", .Item("csexo"))
                lEntidad.ctipper = IIf(.Item("ctipper") Is DBNull.Value, "1", .Item("ctipper"))
                lEntidad.cindnac = IIf(.Item("cindnac") Is DBNull.Value, Nothing, .Item("cindnac"))
                lEntidad.clugnac = IIf(.Item("clugnac") Is DBNull.Value, Nothing, .Item("clugnac"))
                lEntidad.ctidoci = IIf(.Item("ctidoci") Is DBNull.Value, Nothing, .Item("ctidoci"))
                lEntidad.cnudoci = IIf(.Item("cnudoci") Is DBNull.Value, Nothing, .Item("cnudoci"))
                lEntidad.ctidotr = IIf(.Item("ctidotr") Is DBNull.Value, Nothing, .Item("ctidotr"))
                lEntidad.cnudotr = IIf(.Item("cnudotr") Is DBNull.Value, Nothing, .Item("cnudotr"))
                lEntidad.cestciv = IIf(.Item("cestciv") Is DBNull.Value, Nothing, .Item("cestciv"))
                lEntidad.cnivins = IIf(.Item("cnivins") Is DBNull.Value, Nothing, .Item("cnivins"))
                lEntidad.ccodcon = IIf(.Item("ccodcon") Is DBNull.Value, "00", .Item("ccodcon"))
                lEntidad.npercar = IIf(.Item("npercar") Is DBNull.Value, Nothing, .Item("npercar"))
                lEntidad.cgrusan = IIf(.Item("cgrusan") Is DBNull.Value, "", .Item("cgrusan"))
                lEntidad.ccodpro = IIf(.Item("ccodpro") Is DBNull.Value, Nothing, .Item("ccodpro"))
                lEntidad.cestsoc = IIf(.Item("cestsoc") Is DBNull.Value, Nothing, .Item("cestsoc"))
                lEntidad.ccoddom = IIf(.Item("ccoddom") Is DBNull.Value, Nothing, .Item("ccoddom"))
                lEntidad.cdirdom = IIf(.Item("cdirdom") Is DBNull.Value, "", .Item("cdirdom"))
                lEntidad.ccondom = IIf(.Item("ccondom") Is DBNull.Value, Nothing, .Item("ccondom"))
                lEntidad.cteldom = IIf(.Item("cteldom") Is DBNull.Value, Nothing, .Item("cteldom"))
                lEntidad.nanodom = IIf(.Item("nanodom") Is DBNull.Value, Nothing, .Item("nanodom"))
                lEntidad.ccodsbs = IIf(.Item("ccodsbs") Is DBNull.Value, Nothing, .Item("ccodsbs"))
                lEntidad.caccins = IIf(.Item("caccins") Is DBNull.Value, Nothing, .Item("caccins"))
                lEntidad.crelins = IIf(.Item("crelins") Is DBNull.Value, Nothing, .Item("crelins"))
                lEntidad.dregist = IIf(.Item("dregist") Is DBNull.Value, Nothing, .Item("dregist"))
                lEntidad.ndismen = IIf(.Item("ndismen") Is DBNull.Value, 0, .Item("ndismen"))
                lEntidad.ccalint = IIf(.Item("ccalint") Is DBNull.Value, Nothing, .Item("ccalint"))
                lEntidad.ccalext = IIf(.Item("ccalext") Is DBNull.Value, Nothing, .Item("ccalext"))
                lEntidad.ccalpro = IIf(.Item("ccalpro") Is DBNull.Value, Nothing, .Item("ccalpro"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cbenef1 = IIf(.Item("cbenef1") Is DBNull.Value, "", .Item("cbenef1"))
                lEntidad.cbenef2 = IIf(.Item("cbenef2") Is DBNull.Value, "", .Item("cbenef2"))
                lEntidad.dfechai = IIf(.Item("dfechai") Is DBNull.Value, Nothing, .Item("dfechai"))
                lEntidad.nacciones = IIf(.Item("nacciones") Is DBNull.Value, Nothing, .Item("nacciones"))
                lEntidad.ccargo = IIf(.Item("ccargo") Is DBNull.Value, Nothing, .Item("ccargo"))
                lEntidad.cfirma = IIf(.Item("cfirma") Is DBNull.Value, Nothing, .Item("cfirma"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, "", .Item("cctacte"))
                lEntidad.cnombco = IIf(.Item("cnombco") Is DBNull.Value, "", .Item("cnombco"))
                lEntidad.lactivo = IIf(.Item("lactivo") Is DBNull.Value, Nothing, .Item("lactivo"))
                lEntidad.cdevol = IIf(.Item("cdevol") Is DBNull.Value, Nothing, .Item("cdevol"))
                lEntidad.cubifue = IIf(.Item("cubifue") Is DBNull.Value, Nothing, .Item("cubifue"))
                lEntidad.cdirfue = IIf(.Item("cdirfue") Is DBNull.Value, "", .Item("cdirfue"))
                lEntidad.nHijos = IIf(.Item("nHijos") Is DBNull.Value, 0, .Item("nHijos"))
                lEntidad.nOtros = IIf(.Item("nOtros") Is DBNull.Value, Nothing, .Item("nOtros"))
                lEntidad.cTipcli = IIf(.Item("cTipcli") Is DBNull.Value, Nothing, .Item("cTipcli"))
                lEntidad.cEscolar = IIf(.Item("cEscolar") Is DBNull.Value, Nothing, .Item("cEscolar"))
                lEntidad.cLugExp = IIf(.Item("cLugExp") Is DBNull.Value, "", .Item("cLugExp"))
                lEntidad.dfchExp = IIf(.Item("dfchExp") Is DBNull.Value, Nothing, .Item("dfchExp"))
                lEntidad.cTipcli1 = IIf(.Item("cTipcli1") Is DBNull.Value, Nothing, .Item("cTipcli1"))
                lEntidad.cTipviv = IIf(.Item("cTipviv") Is DBNull.Value, Nothing, .Item("cTipviv"))
                lEntidad.cDomAnt = IIf(.Item("cDomAnt") Is DBNull.Value, "", .Item("cDomAnt"))
                lEntidad.cTiemRes = IIf(.Item("cTiemRes") Is DBNull.Value, Nothing, .Item("cTiemRes"))
                lEntidad.cRefe = IIf(.Item("cRefe") Is DBNull.Value, "", .Item("cRefe"))
                lEntidad.cSabeEsc = IIf(.Item("cSabeEsc") Is DBNull.Value, Nothing, .Item("cSabeEsc"))
                lEntidad.cNomDño = IIf(.Item("cNomDño") Is DBNull.Value, "", .Item("cNomDño"))
                lEntidad.cTelDño = IIf(.Item("cTelDño") Is DBNull.Value, "", .Item("cTelDño"))
                lEntidad.cNomcon = IIf(.Item("cNomcon") Is DBNull.Value, "", .Item("cNomcon"))
                lEntidad.cTipCony = IIf(.Item("cTipCony") Is DBNull.Value, Nothing, .Item("cTipCony"))
                lEntidad.cDuiCony = IIf(.Item("cDuiCony") Is DBNull.Value, "", .Item("cDuiCony"))
                lEntidad.cSexcon = IIf(.Item("cSexcon") Is DBNull.Value, "X", .Item("cSexcon"))
                lEntidad.cProfCon = IIf(.Item("cProfCon") Is DBNull.Value, Nothing, .Item("cProfCon"))
                lEntidad.cLtrab = IIf(.Item("cLtrab") Is DBNull.Value, Nothing, .Item("cLtrab"))
                lEntidad.cDirCon = IIf(.Item("cDirCon") Is DBNull.Value, "", .Item("cDirCon"))
                lEntidad.cTelcon = IIf(.Item("cTelcon") Is DBNull.Value, "", .Item("cTelcon"))
                lEntidad.cSactCon = IIf(.Item("cSactCon") Is DBNull.Value, Nothing, .Item("cSactCon"))
                lEntidad.cTiempCon = IIf(.Item("cTiempCon") Is DBNull.Value, Nothing, .Item("cTiempCon"))
                lEntidad.mDatAdi = IIf(.Item("mDatAdi") Is DBNull.Value, "", .Item("mDatAdi"))
                lEntidad.cNomInv = IIf(.Item("cNomInv") Is DBNull.Value, "", .Item("cNomInv"))
                lEntidad.cPrefe1 = IIf(.Item("cPrefe1") Is DBNull.Value, "", .Item("cPrefe1"))
                lEntidad.cDomInv = IIf(.Item("cDomInv") Is DBNull.Value, "", .Item("cDomInv"))
                lEntidad.cTelInv = IIf(.Item("cTelInv") Is DBNull.Value, "", .Item("cTelInv"))
                lEntidad.cLugInv = IIf(.Item("cLugInv") Is DBNull.Value, "", .Item("cLugInv"))
                lEntidad.cTelLugInv = IIf(.Item("cTelLugInv") Is DBNull.Value, "", .Item("cTelLugInv"))
                lEntidad.cNomFam = IIf(.Item("cNomFam") Is DBNull.Value, "", .Item("cNomFam"))
                lEntidad.cPrefe2 = IIf(.Item("cPrefe2") Is DBNull.Value, "", .Item("cPrefe2"))
                lEntidad.cDomFam = IIf(.Item("cDomFam") Is DBNull.Value, "", .Item("cDomFam"))
                lEntidad.cTelFam = IIf(.Item("cTelFam") Is DBNull.Value, "", .Item("cTelFam"))
                lEntidad.cLugFam = IIf(.Item("cLugFam") Is DBNull.Value, "", .Item("cLugFam"))
                lEntidad.cTelLugFam = IIf(.Item("cTelLugFam") Is DBNull.Value, "", .Item("cTelLugFam"))
                lEntidad.cNomVec = IIf(.Item("cNomVec") Is DBNull.Value, "", .Item("cNomVec"))
                lEntidad.cPrefe3 = IIf(.Item("cPrefe3") Is DBNull.Value, "", .Item("cPrefe3"))
                lEntidad.cDomVec = IIf(.Item("cDomVec") Is DBNull.Value, "", .Item("cDomVec"))
                lEntidad.cTelVec = IIf(.Item("cTelVec") Is DBNull.Value, "", .Item("cTelVec"))
                lEntidad.clugVec = IIf(.Item("clugVec") Is DBNull.Value, "", .Item("clugVec"))
                lEntidad.cTelLugVec = IIf(.Item("cTelLugVec") Is DBNull.Value, "", .Item("cTelLugVec"))
                lEntidad.dfCony = IIf(.Item("dfcony") Is DBNull.Value, Nothing, .Item("dfcony"))
                lEntidad.lsegvida = IIf(.Item("lsegvida") Is DBNull.Value, Nothing, .Item("lsegvida"))
                lEntidad.cetnia = IIf(.Item("cetnia") Is DBNull.Value, "1", .Item("cetnia"))
                lEntidad.cnivel = IIf(.Item("cnivel") Is DBNull.Value, "1", .Item("cnivel"))
                lEntidad.cconviv = IIf(.Item("cconviv") Is DBNull.Value, "1", .Item("cconviv"))
                lEntidad.cadicional = IIf(.Item("cadicional") Is DBNull.Value, "", .Item("cadicional"))
                lEntidad.nsabeesc = IIf(.Item("nsabeesc") Is DBNull.Value, 0, .Item("nsabeesc"))
                lEntidad.csegnom = IIf(.Item("csegnom") Is DBNull.Value, "", .Item("csegnom"))
                lEntidad.cternom = IIf(.Item("cternom") Is DBNull.Value, "", .Item("cternom"))
                lEntidad.cpriape = IIf(.Item("cpriape") Is DBNull.Value, "", .Item("cpriape"))
                lEntidad.csegape = IIf(.Item("csegape") Is DBNull.Value, "", .Item("csegape"))
                lEntidad.cleer = IIf(.Item("cleer") Is DBNull.Value, "", .Item("cleer"))
                lEntidad.cescribir = IIf(.Item("cescribir") Is DBNull.Value, "", .Item("cescribir"))
                lEntidad.cfirmar = IIf(.Item("cfirmar") Is DBNull.Value, "", .Item("cfirmar"))
                lEntidad.cotrtel = IIf(.Item("cotrtel") Is DBNull.Value, "", .Item("cotrtel"))
                lEntidad.cgrado = IIf(.Item("cgrado") Is DBNull.Value, "", .Item("cgrado"))
                lEntidad.clocalidad = IIf(.Item("clocalidad") Is DBNull.Value, "", .Item("clocalidad"))
                lEntidad.cgruetnico = IIf(.Item("cgruetnico") Is DBNull.Value, "", .Item("cgruetnico"))
                lEntidad.cidiomas = IIf(.Item("cidiomas") Is DBNull.Value, "", .Item("cidiomas"))
                lEntidad.cprinom = IIf(.Item("cprinom") Is DBNull.Value, "", .Item("cprinom"))

                lEntidad.ctipocondic = IIf(.Item("ctipocondic") Is DBNull.Value, "", .Item("ctipocondic"))
                lEntidad.cparedes = IIf(.Item("cparedes") Is DBNull.Value, "", .Item("cparedes"))
                lEntidad.cparedcondic = IIf(.Item("cparedcondic") Is DBNull.Value, "", .Item("cparedcondic"))
                lEntidad.cpiso = IIf(.Item("cpiso") Is DBNull.Value, "", .Item("cpiso"))
                lEntidad.cpisocondic = IIf(.Item("cpisocondic") Is DBNull.Value, "", .Item("cpisocondic"))
                lEntidad.ctecho = IIf(.Item("ctecho") Is DBNull.Value, "", .Item("ctecho"))
                lEntidad.ctechocondic = IIf(.Item("ctechocondic") Is DBNull.Value, "", .Item("ctechocondic"))
                lEntidad.cservicios = IIf(.Item("cservicios") Is DBNull.Value, "", .Item("cservicios"))
                lEntidad.csercondic = IIf(.Item("csercondic") Is DBNull.Value, "", .Item("csercondic"))
                lEntidad.cNomDño = IIf(.Item("cnomdño") Is DBNull.Value, "", .Item("cnomdño"))
                lEntidad.nvalor = IIf(.Item("nvalor") Is DBNull.Value, 0, .Item("nvalor"))
                lEntidad.nanodom = IIf(.Item("nanodom") Is DBNull.Value, "2013", .Item("nanodom"))
                lEntidad.id_codigo_postal = IIf(.Item("id_codigo_postal") Is DBNull.Value, "", .Item("id_codigo_postal"))
                lEntidad.id_ife = IIf(.Item("id_ife") Is DBNull.Value, "", .Item("id_ife"))
                lEntidad.cCalle = IIf(.Item("ccalle") Is DBNull.Value, "", .Item("ccalle"))
                lEntidad.cNoExt = IIf(.Item("cnoext") Is DBNull.Value, "", .Item("cnoext"))
                lEntidad.cNoInt = IIf(.Item("cnoint") Is DBNull.Value, "", .Item("cnoint"))
                lEntidad.ccorreo = IIf(.Item("ccorreo") Is DBNull.Value, "", .Item("ccorreo"))
                lEntidad.usuface = IIf(.Item("usuface") Is DBNull.Value, "", .Item("usuface"))
                lEntidad.latitud = IIf(.Item("latitud") Is DBNull.Value, "", .Item("latitud"))
                lEntidad.longitud = IIf(.Item("longitud") Is DBNull.Value, "", .Item("longitud"))

                Try
                    ' lEntidad.foto = .Item("foto")
                Catch ex As Exception
                End Try

                lEntidad.capecasada = IIf(.Item("capecasada") Is DBNull.Value, "", .Item("capecasada"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcli),0) + 1 ")
        strSQL.Append(" FROM climide ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaclimide

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaclimide

        Try
            Do While dr.Read()
                Dim mEntidad As New climide
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.cnomcor = IIf(dr("cnomcor") Is DBNull.Value, Nothing, dr("cnomcor"))
                mEntidad.ccodsol = IIf(dr("ccodsol") Is DBNull.Value, Nothing, dr("ccodsol"))
                mEntidad.dnacimi = IIf(dr("dnacimi") Is DBNull.Value, Nothing, dr("dnacimi"))
                mEntidad.cclaper = IIf(dr("cclaper") Is DBNull.Value, Nothing, dr("cclaper"))
                mEntidad.csexo = IIf(dr("csexo") Is DBNull.Value, Nothing, dr("csexo"))
                mEntidad.ctipper = IIf(dr("ctipper") Is DBNull.Value, Nothing, dr("ctipper"))
                mEntidad.cindnac = IIf(dr("cindnac") Is DBNull.Value, Nothing, dr("cindnac"))
                mEntidad.clugnac = IIf(dr("clugnac") Is DBNull.Value, Nothing, dr("clugnac"))
                mEntidad.ctidoci = IIf(dr("ctidoci") Is DBNull.Value, Nothing, dr("ctidoci"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.ctidotr = IIf(dr("ctidotr") Is DBNull.Value, Nothing, dr("ctidotr"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.cestciv = IIf(dr("cestciv") Is DBNull.Value, Nothing, dr("cestciv"))
                mEntidad.cnivins = IIf(dr("cnivins") Is DBNull.Value, Nothing, dr("cnivins"))
                mEntidad.ccodcon = IIf(dr("ccodcon") Is DBNull.Value, Nothing, dr("ccodcon"))
                mEntidad.npercar = IIf(dr("npercar") Is DBNull.Value, Nothing, dr("npercar"))
                mEntidad.cgrusan = IIf(dr("cgrusan") Is DBNull.Value, Nothing, dr("cgrusan"))
                mEntidad.ccodpro = IIf(dr("ccodpro") Is DBNull.Value, Nothing, dr("ccodpro"))
                mEntidad.cestsoc = IIf(dr("cestsoc") Is DBNull.Value, Nothing, dr("cestsoc"))
                mEntidad.ccoddom = IIf(dr("ccoddom") Is DBNull.Value, Nothing, dr("ccoddom"))
                mEntidad.cdirdom = IIf(dr("cdirdom") Is DBNull.Value, Nothing, dr("cdirdom"))
                mEntidad.ccondom = IIf(dr("ccondom") Is DBNull.Value, Nothing, dr("ccondom"))
                mEntidad.cteldom = IIf(dr("cteldom") Is DBNull.Value, Nothing, dr("cteldom"))
                mEntidad.nanodom = IIf(dr("nanodom") Is DBNull.Value, Nothing, dr("nanodom"))
                mEntidad.ccodsbs = IIf(dr("ccodsbs") Is DBNull.Value, Nothing, dr("ccodsbs"))
                mEntidad.caccins = IIf(dr("caccins") Is DBNull.Value, Nothing, dr("caccins"))
                mEntidad.crelins = IIf(dr("crelins") Is DBNull.Value, Nothing, dr("crelins"))
                mEntidad.dregist = IIf(dr("dregist") Is DBNull.Value, Nothing, dr("dregist"))
                mEntidad.ndismen = IIf(dr("ndismen") Is DBNull.Value, Nothing, dr("ndismen"))
                mEntidad.ccalint = IIf(dr("ccalint") Is DBNull.Value, Nothing, dr("ccalint"))
                mEntidad.ccalext = IIf(dr("ccalext") Is DBNull.Value, Nothing, dr("ccalext"))
                mEntidad.ccalpro = IIf(dr("ccalpro") Is DBNull.Value, Nothing, dr("ccalpro"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cbenef1 = IIf(dr("cbenef1") Is DBNull.Value, Nothing, dr("cbenef1"))
                mEntidad.cbenef2 = IIf(dr("cbenef2") Is DBNull.Value, Nothing, dr("cbenef2"))
                mEntidad.dfechai = IIf(dr("dfechai") Is DBNull.Value, Nothing, dr("dfechai"))
                mEntidad.nacciones = IIf(dr("nacciones") Is DBNull.Value, Nothing, dr("nacciones"))
                mEntidad.ccargo = IIf(dr("ccargo") Is DBNull.Value, Nothing, dr("ccargo"))
                mEntidad.cfirma = IIf(dr("cfirma") Is DBNull.Value, Nothing, dr("cfirma"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.cnombco = IIf(dr("cnombco") Is DBNull.Value, Nothing, dr("cnombco"))
                mEntidad.lactivo = IIf(dr("lactivo") Is DBNull.Value, Nothing, dr("lactivo"))
                mEntidad.cdevol = IIf(dr("cdevol") Is DBNull.Value, Nothing, dr("cdevol"))
                mEntidad.cubifue = IIf(dr("cubifue") Is DBNull.Value, Nothing, dr("cubifue"))
                mEntidad.cdirfue = IIf(dr("cdirfue") Is DBNull.Value, Nothing, dr("cdirfue"))
                mEntidad.nHijos = IIf(dr("nHijos") Is DBNull.Value, Nothing, dr("nHijos"))
                mEntidad.nOtros = IIf(dr("nOtros") Is DBNull.Value, Nothing, dr("nOtros"))
                mEntidad.cTipcli = IIf(dr("cTipcli") Is DBNull.Value, Nothing, dr("cTipcli"))
                mEntidad.cEscolar = IIf(dr("cEscolar") Is DBNull.Value, Nothing, dr("cEscolar"))
                mEntidad.cLugExp = IIf(dr("cLugExp") Is DBNull.Value, Nothing, dr("cLugExp"))
                mEntidad.dfchExp = IIf(dr("dfchExp") Is DBNull.Value, Nothing, dr("dfchExp"))
                mEntidad.cTipcli1 = IIf(dr("cTipcli1") Is DBNull.Value, Nothing, dr("cTipcli1"))
                mEntidad.cTipviv = IIf(dr("cTipviv") Is DBNull.Value, Nothing, dr("cTipviv"))
                mEntidad.cDomAnt = IIf(dr("cDomAnt") Is DBNull.Value, Nothing, dr("cDomAnt"))
                mEntidad.cTiemRes = IIf(dr("cTiemRes") Is DBNull.Value, Nothing, dr("cTiemRes"))
                mEntidad.cRefe = IIf(dr("cRefe") Is DBNull.Value, Nothing, dr("cRefe"))
                mEntidad.cSabeEsc = IIf(dr("cSabeEsc") Is DBNull.Value, Nothing, dr("cSabeEsc"))
                mEntidad.cNomDño = IIf(dr("cNomDño") Is DBNull.Value, Nothing, dr("cNomDño"))
                mEntidad.cTelDño = IIf(dr("cTelDño") Is DBNull.Value, Nothing, dr("cTelDño"))
                mEntidad.cNomcon = IIf(dr("cNomcon") Is DBNull.Value, Nothing, dr("cNomcon"))
                mEntidad.cTipCony = IIf(dr("cTipCony") Is DBNull.Value, Nothing, dr("cTipCony"))
                mEntidad.cDuiCony = IIf(dr("cDuiCony") Is DBNull.Value, Nothing, dr("cDuiCony"))
                mEntidad.cSexcon = IIf(dr("cSexcon") Is DBNull.Value, Nothing, dr("cSexcon"))
                mEntidad.cProfCon = IIf(dr("cProfCon") Is DBNull.Value, Nothing, dr("cProfCon"))
                mEntidad.cLtrab = IIf(dr("cLtrab") Is DBNull.Value, Nothing, dr("cLtrab"))
                mEntidad.cDirCon = IIf(dr("cDirCon") Is DBNull.Value, Nothing, dr("cDirCon"))
                mEntidad.cTelcon = IIf(dr("cTelcon") Is DBNull.Value, Nothing, dr("cTelcon"))
                mEntidad.cSactCon = IIf(dr("cSactCon") Is DBNull.Value, Nothing, dr("cSactCon"))
                mEntidad.cTiempCon = IIf(dr("cTiempCon") Is DBNull.Value, Nothing, dr("cTiempCon"))
                mEntidad.mDatAdi = IIf(dr("mDatAdi") Is DBNull.Value, Nothing, dr("mDatAdi"))
                mEntidad.cNomInv = IIf(dr("cNomInv") Is DBNull.Value, Nothing, dr("cNomInv"))
                mEntidad.cPrefe1 = IIf(dr("cPrefe1") Is DBNull.Value, Nothing, dr("cPrefe1"))
                mEntidad.cDomInv = IIf(dr("cDomInv") Is DBNull.Value, Nothing, dr("cDomInv"))
                mEntidad.cTelInv = IIf(dr("cTelInv") Is DBNull.Value, Nothing, dr("cTelInv"))
                mEntidad.cLugInv = IIf(dr("cLugInv") Is DBNull.Value, Nothing, dr("cLugInv"))
                mEntidad.cTelLugInv = IIf(dr("cTelLugInv") Is DBNull.Value, Nothing, dr("cTelLugInv"))
                mEntidad.cNomFam = IIf(dr("cNomFam") Is DBNull.Value, Nothing, dr("cNomFam"))
                mEntidad.cPrefe2 = IIf(dr("cPrefe2") Is DBNull.Value, Nothing, dr("cPrefe2"))
                mEntidad.cDomFam = IIf(dr("cDomFam") Is DBNull.Value, Nothing, dr("cDomFam"))
                mEntidad.cTelFam = IIf(dr("cTelFam") Is DBNull.Value, Nothing, dr("cTelFam"))
                mEntidad.cLugFam = IIf(dr("cLugFam") Is DBNull.Value, Nothing, dr("cLugFam"))
                mEntidad.cTelLugFam = IIf(dr("cTelLugFam") Is DBNull.Value, Nothing, dr("cTelLugFam"))
                mEntidad.cNomVec = IIf(dr("cNomVec") Is DBNull.Value, Nothing, dr("cNomVec"))
                mEntidad.cPrefe3 = IIf(dr("cPrefe3") Is DBNull.Value, Nothing, dr("cPrefe3"))
                mEntidad.cDomVec = IIf(dr("cDomVec") Is DBNull.Value, Nothing, dr("cDomVec"))
                mEntidad.cTelVec = IIf(dr("cTelVec") Is DBNull.Value, Nothing, dr("cTelVec"))
                mEntidad.clugVec = IIf(dr("clugVec") Is DBNull.Value, Nothing, dr("clugVec"))
                mEntidad.cTelLugVec = IIf(dr("cTelLugVec") Is DBNull.Value, Nothing, dr("cTelLugVec"))
                mEntidad.cAnoDom = IIf(dr("cAnoDom") Is DBNull.Value, Nothing, dr("cAnoDom"))
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
        tables(0) = New String("climide")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcli, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" cnomcor, ") 
        strSQL.Append(" ccodsol, ") 
        strSQL.Append(" dnacimi, ") 
        strSQL.Append(" cclaper, ") 
        strSQL.Append(" csexo, ") 
        strSQL.Append(" ctipper, ") 
        strSQL.Append(" cindnac, ") 
        strSQL.Append(" clugnac, ") 
        strSQL.Append(" ctidoci, ") 
        strSQL.Append(" cnudoci, ") 
        strSQL.Append(" ctidotr, ") 
        strSQL.Append(" cnudotr, ") 
        strSQL.Append(" cestciv, ") 
        strSQL.Append(" cnivins, ") 
        strSQL.Append(" ccodcon, ") 
        strSQL.Append(" npercar, ") 
        strSQL.Append(" cgrusan, ") 
        strSQL.Append(" ccodpro, ") 
        strSQL.Append(" cestsoc, ") 
        strSQL.Append(" ccoddom, ") 
        strSQL.Append(" cdirdom, ") 
        strSQL.Append(" ccondom, ") 
        strSQL.Append(" cteldom, ") 
        strSQL.Append(" nanodom, ") 
        strSQL.Append(" ccodsbs, ") 
        strSQL.Append(" caccins, ") 
        strSQL.Append(" crelins, ") 
        strSQL.Append(" dregist, ") 
        strSQL.Append(" ndismen, ") 
        strSQL.Append(" ccalint, ") 
        strSQL.Append(" ccalext, ") 
        strSQL.Append(" ccalpro, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" cbenef1, ") 
        strSQL.Append(" cbenef2, ") 
        strSQL.Append(" dfechai, ") 
        strSQL.Append(" nacciones, ") 
        strSQL.Append(" ccargo, ") 
        strSQL.Append(" cfirma, ") 
        strSQL.Append(" cctacte, ") 
        strSQL.Append(" cnombco, ") 
        strSQL.Append(" lactivo, ") 
        strSQL.Append(" cdevol, ") 
        strSQL.Append(" cubifue, ") 
        strSQL.Append(" cdirfue, ") 
        strSQL.Append(" nHijos, ") 
        strSQL.Append(" nOtros, ") 
        strSQL.Append(" cTipcli, ") 
        strSQL.Append(" cEscolar, ") 
        strSQL.Append(" cLugExp, ") 
        strSQL.Append(" dfchExp, ") 
        strSQL.Append(" cTipcli1, ") 
        strSQL.Append(" cTipviv, ") 
        strSQL.Append(" cDomAnt, ") 
        strSQL.Append(" cTiemRes, ") 
        strSQL.Append(" cRefe, ") 
        strSQL.Append(" cSabeEsc, ") 
        strSQL.Append(" cNomDño, ") 
        strSQL.Append(" cTelDño, ") 
        strSQL.Append(" cNomcon, ") 
        strSQL.Append(" cTipCony, ") 
        strSQL.Append(" cDuiCony, ") 
        strSQL.Append(" cSexcon, ") 
        strSQL.Append(" cProfCon, ") 
        strSQL.Append(" cLtrab, ") 
        strSQL.Append(" cDirCon, ") 
        strSQL.Append(" cTelcon, ") 
        strSQL.Append(" cSactCon, ") 
        strSQL.Append(" cTiempCon, ") 
        strSQL.Append(" mDatAdi, ") 
        strSQL.Append(" cNomInv, ") 
        strSQL.Append(" cPrefe1, ") 
        strSQL.Append(" cDomInv, ") 
        strSQL.Append(" cTelInv, ") 
        strSQL.Append(" cLugInv, ") 
        strSQL.Append(" cTelLugInv, ") 
        strSQL.Append(" cNomFam, ") 
        strSQL.Append(" cPrefe2, ") 
        strSQL.Append(" cDomFam, ") 
        strSQL.Append(" cTelFam, ") 
        strSQL.Append(" cLugFam, ") 
        strSQL.Append(" cTelLugFam, ") 
        strSQL.Append(" cNomVec, ") 
        strSQL.Append(" cPrefe3, ") 
        strSQL.Append(" cDomVec, ") 
        strSQL.Append(" cTelVec, ") 
        strSQL.Append(" clugVec, ") 
        strSQL.Append(" cTelLugVec, ") 
        strSQL.Append(" cAnoDom, ")
        strSQL.Append(" dfCony, ")
        strSQL.Append(" lsegvida, cetnia, cnivel, cadicional, cconviv,nsabeesc, ")
        strSQL.Append(" csegnom, cternom, cpriape, csegape, capecasada, cleer, cescribir, cfirmar, cotrtel, cgrado, clocalidad, cgruetnico, cidiomas, cprinom, ")
        strSQL.Append("ctipocondic, cparedes, cparedcondic, cpiso, cpisocondic, ctecho, ctechocondic, cservicios, csercondic, cnomdño, nvalor, nanodom, foto, id_ife, ccalle, cnoext, cnoint, id_codigo_postal, ccorreo, usuface,   ")
        strSQL.Append("isnull(latitud,space(1)) as latitud, isnull(longitud,space(1)) as longitud")
        strSQL.Append(" FROM climide ")

    End Sub


    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listaclimide
        Dim strSQL As New StringBuilder
        Dim lista As New listaclimide
        SelectTabla(strSQL)
        strSQL.Append("WHERE ccodcli = @ccodcli")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = codcli

        Dim dr As SqlDataReader
        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Try
            Do While dr.Read()
                Dim mEntidad As New climide
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.cnomcor = IIf(dr("cnomcor") Is DBNull.Value, Nothing, dr("cnomcor"))
                mEntidad.ccodsol = IIf(dr("ccodsol") Is DBNull.Value, Nothing, dr("ccodsol"))
                mEntidad.dnacimi = IIf(dr("dnacimi") Is DBNull.Value, Nothing, dr("dnacimi"))
                mEntidad.cclaper = IIf(dr("cclaper") Is DBNull.Value, Nothing, dr("cclaper"))
                mEntidad.csexo = IIf(dr("csexo") Is DBNull.Value, Nothing, dr("csexo"))
                mEntidad.ctipper = IIf(dr("ctipper") Is DBNull.Value, Nothing, dr("ctipper"))
                mEntidad.cindnac = IIf(dr("cindnac") Is DBNull.Value, Nothing, dr("cindnac"))
                mEntidad.clugnac = IIf(dr("clugnac") Is DBNull.Value, Nothing, dr("clugnac"))
                mEntidad.ctidoci = IIf(dr("ctidoci") Is DBNull.Value, Nothing, dr("ctidoci"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.ctidotr = IIf(dr("ctidotr") Is DBNull.Value, Nothing, dr("ctidotr"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.cestciv = IIf(dr("cestciv") Is DBNull.Value, Nothing, dr("cestciv"))
                mEntidad.cnivins = IIf(dr("cnivins") Is DBNull.Value, Nothing, dr("cnivins"))
                mEntidad.ccodcon = IIf(dr("ccodcon") Is DBNull.Value, Nothing, dr("ccodcon"))
                mEntidad.npercar = IIf(dr("npercar") Is DBNull.Value, Nothing, dr("npercar"))
                mEntidad.cgrusan = IIf(dr("cgrusan") Is DBNull.Value, Nothing, dr("cgrusan"))
                mEntidad.ccodpro = IIf(dr("ccodpro") Is DBNull.Value, Nothing, dr("ccodpro"))
                mEntidad.cestsoc = IIf(dr("cestsoc") Is DBNull.Value, Nothing, dr("cestsoc"))
                mEntidad.ccoddom = IIf(dr("ccoddom") Is DBNull.Value, Nothing, dr("ccoddom"))
                mEntidad.cdirdom = IIf(dr("cdirdom") Is DBNull.Value, Nothing, dr("cdirdom"))
                mEntidad.ccondom = IIf(dr("ccondom") Is DBNull.Value, Nothing, dr("ccondom"))
                mEntidad.cteldom = IIf(dr("cteldom") Is DBNull.Value, Nothing, dr("cteldom"))
                mEntidad.nanodom = IIf(dr("nanodom") Is DBNull.Value, Nothing, dr("nanodom"))
                mEntidad.ccodsbs = IIf(dr("ccodsbs") Is DBNull.Value, Nothing, dr("ccodsbs"))
                mEntidad.caccins = IIf(dr("caccins") Is DBNull.Value, Nothing, dr("caccins"))
                mEntidad.crelins = IIf(dr("crelins") Is DBNull.Value, Nothing, dr("crelins"))
                mEntidad.dregist = IIf(dr("dregist") Is DBNull.Value, Nothing, dr("dregist"))
                mEntidad.ndismen = IIf(dr("ndismen") Is DBNull.Value, Nothing, dr("ndismen"))
                mEntidad.ccalint = IIf(dr("ccalint") Is DBNull.Value, Nothing, dr("ccalint"))
                mEntidad.ccalext = IIf(dr("ccalext") Is DBNull.Value, Nothing, dr("ccalext"))
                mEntidad.ccalpro = IIf(dr("ccalpro") Is DBNull.Value, Nothing, dr("ccalpro"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cbenef1 = IIf(dr("cbenef1") Is DBNull.Value, Nothing, dr("cbenef1"))
                mEntidad.cbenef2 = IIf(dr("cbenef2") Is DBNull.Value, Nothing, dr("cbenef2"))
                mEntidad.dfechai = IIf(dr("dfechai") Is DBNull.Value, Nothing, dr("dfechai"))
                mEntidad.nacciones = IIf(dr("nacciones") Is DBNull.Value, Nothing, dr("nacciones"))
                mEntidad.ccargo = IIf(dr("ccargo") Is DBNull.Value, Nothing, dr("ccargo"))
                mEntidad.cfirma = IIf(dr("cfirma") Is DBNull.Value, Nothing, dr("cfirma"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.cnombco = IIf(dr("cnombco") Is DBNull.Value, Nothing, dr("cnombco"))
                mEntidad.lactivo = IIf(dr("lactivo") Is DBNull.Value, Nothing, dr("lactivo"))
                mEntidad.cdevol = IIf(dr("cdevol") Is DBNull.Value, Nothing, dr("cdevol"))
                mEntidad.cubifue = IIf(dr("cubifue") Is DBNull.Value, Nothing, dr("cubifue"))
                mEntidad.cdirfue = IIf(dr("cdirfue") Is DBNull.Value, Nothing, dr("cdirfue"))
                mEntidad.nHijos = IIf(dr("nHijos") Is DBNull.Value, Nothing, dr("nHijos"))
                mEntidad.nOtros = IIf(dr("nOtros") Is DBNull.Value, Nothing, dr("nOtros"))
                mEntidad.cTipcli = IIf(dr("cTipcli") Is DBNull.Value, Nothing, dr("cTipcli"))
                mEntidad.cEscolar = IIf(dr("cEscolar") Is DBNull.Value, Nothing, dr("cEscolar"))
                mEntidad.cLugExp = IIf(dr("cLugExp") Is DBNull.Value, Nothing, dr("cLugExp"))
                mEntidad.dfchExp = IIf(dr("dfchExp") Is DBNull.Value, Nothing, dr("dfchExp"))
                mEntidad.cTipcli1 = IIf(dr("cTipcli1") Is DBNull.Value, Nothing, dr("cTipcli1"))
                mEntidad.cTipviv = IIf(dr("cTipviv") Is DBNull.Value, Nothing, dr("cTipviv"))
                mEntidad.cDomAnt = IIf(dr("cDomAnt") Is DBNull.Value, Nothing, dr("cDomAnt"))
                mEntidad.cTiemRes = IIf(dr("cTiemRes") Is DBNull.Value, Nothing, dr("cTiemRes"))
                mEntidad.cRefe = IIf(dr("cRefe") Is DBNull.Value, Nothing, dr("cRefe"))
                mEntidad.cSabeEsc = IIf(dr("cSabeEsc") Is DBNull.Value, Nothing, dr("cSabeEsc"))
                mEntidad.cNomDño = IIf(dr("cNomDño") Is DBNull.Value, Nothing, dr("cNomDño"))
                mEntidad.cTelDño = IIf(dr("cTelDño") Is DBNull.Value, Nothing, dr("cTelDño"))
                mEntidad.cNomcon = IIf(dr("cNomcon") Is DBNull.Value, Nothing, dr("cNomcon"))
                mEntidad.cTipCony = IIf(dr("cTipCony") Is DBNull.Value, Nothing, dr("cTipCony"))
                mEntidad.cDuiCony = IIf(dr("cDuiCony") Is DBNull.Value, Nothing, dr("cDuiCony"))
                mEntidad.cSexcon = IIf(dr("cSexcon") Is DBNull.Value, Nothing, dr("cSexcon"))
                mEntidad.cProfCon = IIf(dr("cProfCon") Is DBNull.Value, Nothing, dr("cProfCon"))
                mEntidad.cLtrab = IIf(dr("cLtrab") Is DBNull.Value, Nothing, dr("cLtrab"))
                mEntidad.cDirCon = IIf(dr("cDirCon") Is DBNull.Value, Nothing, dr("cDirCon"))
                mEntidad.cTelcon = IIf(dr("cTelcon") Is DBNull.Value, Nothing, dr("cTelcon"))
                mEntidad.cSactCon = IIf(dr("cSactCon") Is DBNull.Value, Nothing, dr("cSactCon"))
                mEntidad.cTiempCon = IIf(dr("cTiempCon") Is DBNull.Value, Nothing, dr("cTiempCon"))
                mEntidad.mDatAdi = IIf(dr("mDatAdi") Is DBNull.Value, Nothing, dr("mDatAdi"))
                mEntidad.cNomInv = IIf(dr("cNomInv") Is DBNull.Value, Nothing, dr("cNomInv"))
                mEntidad.cPrefe1 = IIf(dr("cPrefe1") Is DBNull.Value, Nothing, dr("cPrefe1"))
                mEntidad.cDomInv = IIf(dr("cDomInv") Is DBNull.Value, Nothing, dr("cDomInv"))
                mEntidad.cTelInv = IIf(dr("cTelInv") Is DBNull.Value, Nothing, dr("cTelInv"))
                mEntidad.cLugInv = IIf(dr("cLugInv") Is DBNull.Value, Nothing, dr("cLugInv"))
                mEntidad.cTelLugInv = IIf(dr("cTelLugInv") Is DBNull.Value, Nothing, dr("cTelLugInv"))
                mEntidad.cNomFam = IIf(dr("cNomFam") Is DBNull.Value, Nothing, dr("cNomFam"))
                mEntidad.cPrefe2 = IIf(dr("cPrefe2") Is DBNull.Value, Nothing, dr("cPrefe2"))
                mEntidad.cDomFam = IIf(dr("cDomFam") Is DBNull.Value, Nothing, dr("cDomFam"))
                mEntidad.cTelFam = IIf(dr("cTelFam") Is DBNull.Value, Nothing, dr("cTelFam"))
                mEntidad.cLugFam = IIf(dr("cLugFam") Is DBNull.Value, Nothing, dr("cLugFam"))
                mEntidad.cTelLugFam = IIf(dr("cTelLugFam") Is DBNull.Value, Nothing, dr("cTelLugFam"))
                mEntidad.cNomVec = IIf(dr("cNomVec") Is DBNull.Value, Nothing, dr("cNomVec"))
                mEntidad.cPrefe3 = IIf(dr("cPrefe3") Is DBNull.Value, Nothing, dr("cPrefe3"))
                mEntidad.cDomVec = IIf(dr("cDomVec") Is DBNull.Value, Nothing, dr("cDomVec"))
                mEntidad.cTelVec = IIf(dr("cTelVec") Is DBNull.Value, Nothing, dr("cTelVec"))
                mEntidad.clugVec = IIf(dr("clugVec") Is DBNull.Value, Nothing, dr("clugVec"))
                mEntidad.cTelLugVec = IIf(dr("cTelLugVec") Is DBNull.Value, Nothing, dr("cTelLugVec"))
                mEntidad.cAnoDom = IIf(dr("cAnoDom") Is DBNull.Value, Nothing, dr("cAnoDom"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista
    End Function


    Public Function AgregarClimide(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO climide ")
        strSQL.Append(" ( ccodcli, ")
        strSQL.Append(" cclaper, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" cnomcor, ")
        strSQL.Append(" dnacimi, ")
        strSQL.Append(" cnudoci, ")
        strSQL.Append(" cnudotr, ")
        strSQL.Append(" csexo, ")
        strSQL.Append(" cestciv, ")
        strSQL.Append(" cCodpro, ")
        strSQL.Append(" cCodDom, ")
        strSQL.Append(" cDirDom, ")
        strSQL.Append(" cTelDom, ")
        strSQL.Append(" cNomCon, ")
        strSQL.Append(" dfCony, ")
        strSQL.Append(" cduiCony, ")
        strSQL.Append(" cSexCon, ")
        strSQL.Append(" cCodOfi, ")
        strSQL.Append(" cProfCon, ")
        strSQL.Append(" ctelfam, ")
        strSQL.Append(" mdatadi, ")
        strSQL.Append(" lsegvida, cfirma, cetnia, cnivel, cadicional, cconviv, ccodsol, clugexp, nsabeesc, npercar, ctidoci, ")
        strSQL.Append(" csegnom, cternom, cpriape, csegape, capecasada, cleer, cescribir, cfirmar, cotrtel, cgrado, nhijos, clocalidad, cgruetnico, cidiomas, cprinom,")
        strSQL.Append("ctipocondic, cparedes, cparedcondic, cpiso, cpisocondic, ctecho, ctechocondic, cservicios, csercondic, ")
        strSQL.Append("cnomdño, nvalor, nanodom, cgrusan, ccodcon, foto, ccodusu,  id_codigo_postal, dfecmod, id_ife, ccalle, cnoext, cnoint, ccorreo, usuface, latitud, longitud)")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ")
        strSQL.Append(" @cclaper, ")
        strSQL.Append(" @cnomcli, ")
        strSQL.Append(" @cnomcli, ")
        strSQL.Append(" @dnacimi, ")
        strSQL.Append(" @cnudoci, ")
        strSQL.Append(" @cnudotr, ")
        strSQL.Append(" @csexo, ")
        strSQL.Append(" @cestciv, ")
        strSQL.Append(" @cCodpro, ")
        strSQL.Append(" @cCodDom, ")
        strSQL.Append(" @cDirDom, ")
        strSQL.Append(" @cTelDom, ")
        strSQL.Append(" @cNomCon, ")
        strSQL.Append(" @dfCony, ")
        strSQL.Append(" @cduiCony, ")
        strSQL.Append(" @cSexCon,")
        strSQL.Append(" @cCodOfi,")
        strSQL.Append(" @cProfCon, ")
        strSQL.Append(" @ctelfam,")
        strSQL.Append(" @mdatadi,")
        strSQL.Append(" @lsegvida, @cfirma, @cetnia, @cnivel, @cadicional, @cconviv, @ccodsol, @clugexp,@nsabeesc, @npercar, @ctidoci,")
        strSQL.Append(" @csegnom, @cternom, @cpriape, @csegape, @capecasada, @cleer, @cescribir, @cfirmar, @cotrtel, @cgrado, @nhijos, @clocalidad, @cgruetnico, @cidiomas, @cprinom,")
        strSQL.Append("@ctipocondic, @cparedes, @cparedcondic, @cpiso, @cpisocondic, @ctecho, @ctechocondic, @cservicios, @csercondic, ")
        strSQL.Append("@cnomdño, @nvalor, @nanodom, @cgrusan, @ccodcon, @foto, @ccodusu, @id_codigo_postal, getdate(), @id_ife, @ccalle, @cnoext, @cnoint, @ccorreo, @usuface, @latitud, @longitud )")

        Dim args(71) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cclaper", SqlDbType.VarChar)
        args(1).Value = lEntidad.cclaper
        args(2) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomcli
        args(3) = New SqlParameter("@cnomcor", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomcli
        args(4) = New SqlParameter("@dnacimi", SqlDbType.DateTime)
        args(4).Value = lEntidad.dnacimi
        args(5) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnudoci
        args(6) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnudotr
        args(7) = New SqlParameter("@csexo", SqlDbType.VarChar)
        args(7).Value = lEntidad.csexo
        args(8) = New SqlParameter("@cestciv", SqlDbType.VarChar)
        args(8).Value = lEntidad.cestciv
        args(9) = New SqlParameter("@ccodpro", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodpro
        args(10) = New SqlParameter("@ccodDom", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccoddom
        args(11) = New SqlParameter("@cdirdom", SqlDbType.VarChar)
        args(11).Value = lEntidad.cdirdom
        args(12) = New SqlParameter("@cTelDom", SqlDbType.VarChar)
        args(12).Value = lEntidad.cteldom
        args(13) = New SqlParameter("@cNomCon", SqlDbType.VarChar)
        args(13).Value = lEntidad.cNomcon
        args(14) = New SqlParameter("@dfCony", SqlDbType.DateTime)
        args(14).Value = lEntidad.dfCony
        args(15) = New SqlParameter("@cduiCony", SqlDbType.VarChar)
        args(15).Value = lEntidad.cDuiCony
        args(16) = New SqlParameter("@cSexCon", SqlDbType.VarChar)
        args(16).Value = lEntidad.cSexcon
        args(17) = New SqlParameter("@cProfCon", SqlDbType.VarChar)
        args(17).Value = lEntidad.cProfCon
        args(18) = New SqlParameter("@cCodOfi", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodofi
        args(19) = New SqlParameter("@ctelfam", SqlDbType.VarChar)
        args(19).Value = lEntidad.cTelFam
        args(20) = New SqlParameter("@mdatadi", SqlDbType.VarChar)
        args(20).Value = lEntidad.mDatAdi
        args(21) = New SqlParameter("@lsegvida", SqlDbType.Bit)
        args(21).Value = lEntidad.lsegvida
        args(22) = New SqlParameter("@cfirma", SqlDbType.Bit)
        args(22).Value = lEntidad.cfirma
        args(23) = New SqlParameter("@cetnia", SqlDbType.VarChar)
        args(23).Value = lEntidad.cetnia
        args(24) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(24).Value = lEntidad.cnivel
        args(25) = New SqlParameter("@cadicional", SqlDbType.VarChar)
        args(25).Value = lEntidad.cadicional
        args(26) = New SqlParameter("@cconviv", SqlDbType.VarChar)
        args(26).Value = lEntidad.cconviv
        args(27) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(27).Value = lEntidad.ccodsol

        args(28) = New SqlParameter("@cLugExp", SqlDbType.VarChar)
        args(28).Value = lEntidad.cLugExp

        args(29) = New SqlParameter("@nsabeesc", SqlDbType.Int)
        args(29).Value = lEntidad.nsabeesc

        args(30) = New SqlParameter("@npercar", SqlDbType.Int)
        args(30).Value = lEntidad.npercar

        args(31) = New SqlParameter("@ctidoci", SqlDbType.VarChar)
        args(31).Value = lEntidad.ctidoci

        args(32) = New SqlParameter("@csegnom", SqlDbType.VarChar)
        args(32).Value = lEntidad.csegnom
        args(33) = New SqlParameter("@cternom", SqlDbType.VarChar)
        args(33).Value = lEntidad.cternom
        args(34) = New SqlParameter("@cpriape", SqlDbType.VarChar)
        args(34).Value = lEntidad.cpriape
        args(35) = New SqlParameter("@csegape", SqlDbType.VarChar)
        args(35).Value = lEntidad.csegape
        args(36) = New SqlParameter("@capecasada", SqlDbType.VarChar)
        args(36).Value = lEntidad.capecasada
        args(37) = New SqlParameter("@cleer", SqlDbType.VarChar)
        args(37).Value = lEntidad.cleer
        args(38) = New SqlParameter("@cescribir", SqlDbType.VarChar)
        args(38).Value = lEntidad.cescribir
        args(39) = New SqlParameter("@cfirmar", SqlDbType.VarChar)
        args(39).Value = lEntidad.cfirmar
        args(40) = New SqlParameter("@cotrtel", SqlDbType.VarChar)
        args(40).Value = lEntidad.cotrtel
        args(41) = New SqlParameter("@cgrado", SqlDbType.VarChar)
        args(41).Value = lEntidad.cgrado
        args(42) = New SqlParameter("@nhijos", SqlDbType.Int)
        args(42).Value = lEntidad.nHijos
        args(43) = New SqlParameter("@clocalidad", SqlDbType.VarChar)
        args(43).Value = lEntidad.clocalidad
        args(44) = New SqlParameter("@cgruetnico", SqlDbType.VarChar)
        args(44).Value = lEntidad.cgruetnico
        args(45) = New SqlParameter("@cidiomas", SqlDbType.VarChar)
        args(45).Value = lEntidad.cidiomas
        args(46) = New SqlParameter("@cprinom", SqlDbType.VarChar)
        args(46).Value = lEntidad.cprinom

        args(47) = New SqlParameter("@ctipocondic", SqlDbType.VarChar)
        args(47).Value = lEntidad.ctipocondic
        args(48) = New SqlParameter("@cparedes", SqlDbType.VarChar)
        args(48).Value = lEntidad.cparedes
        args(49) = New SqlParameter("@cparedcondic", SqlDbType.VarChar)
        args(49).Value = lEntidad.cparedcondic
        args(50) = New SqlParameter("@cpiso", SqlDbType.VarChar)
        args(50).Value = lEntidad.cpiso
        args(51) = New SqlParameter("@cpisocondic", SqlDbType.VarChar)
        args(51).Value = lEntidad.cpisocondic
        args(52) = New SqlParameter("@ctecho", SqlDbType.VarChar)
        args(52).Value = lEntidad.ctecho
        args(53) = New SqlParameter("@ctechocondic", SqlDbType.VarChar)
        args(53).Value = lEntidad.ctechocondic
        args(54) = New SqlParameter("@cservicios", SqlDbType.VarChar)
        args(54).Value = lEntidad.cservicios
        args(55) = New SqlParameter("@csercondic", SqlDbType.VarChar)
        args(55).Value = lEntidad.csercondic
        args(56) = New SqlParameter("@cnomdño", SqlDbType.VarChar)
        args(56).Value = lEntidad.cNomDño
        args(57) = New SqlParameter("@nvalor", SqlDbType.Decimal)
        args(57).Value = lEntidad.nvalor
        args(58) = New SqlParameter("@nanodom", SqlDbType.Int)
        args(58).Value = lEntidad.nanodom
        args(59) = New SqlParameter("@cgrusan", SqlDbType.VarChar)
        args(59).Value = lEntidad.cgrusan
        args(60) = New SqlParameter("@ccodcon", SqlDbType.VarChar)
        args(60).Value = lEntidad.ccodcon
        args(61) = New SqlParameter("@foto", SqlDbType.Image)
        args(61).Value = lEntidad.foto
        args(62) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(62).Value = lEntidad.ccodusu
        args(63) = New SqlParameter("@id_codigo_postal", SqlDbType.VarChar)
        args(63).Value = lEntidad.id_codigo_postal
        args(64) = New SqlParameter("@id_ife", SqlDbType.VarChar)
        args(64).Value = lEntidad.id_ife
        args(65) = New SqlParameter("@ccalle", SqlDbType.VarChar)
        args(65).Value = lEntidad.cCalle
        args(66) = New SqlParameter("@cnoext", SqlDbType.VarChar)
        args(66).Value = lEntidad.cNoExt
        args(67) = New SqlParameter("@cnoint", SqlDbType.VarChar)
        args(67).Value = lEntidad.cNoInt
        args(68) = New SqlParameter("@ccorreo", SqlDbType.VarChar)
        args(68).Value = lEntidad.ccorreo
        args(69) = New SqlParameter("@usuface", SqlDbType.VarChar)
        args(69).Value = lEntidad.usuface
        args(70) = New SqlParameter("@latitud", SqlDbType.VarChar)
        args(70).Value = lEntidad.latitud
        args(71) = New SqlParameter("@longitud", SqlDbType.VarChar)
        args(71).Value = lEntidad.longitud


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSet() As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT max(substring(ccodcli,4,12)) as correlativo ")
        strSQL.Append(" FROM climide ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ActualizaClimide(ByVal aEntidad As entidadBase, ByVal lnflag As Integer) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder


        strSQL.Append("UPDATE climide ")
        strSQL.Append(" SET cclaper = @cclaper, ")
        strSQL.Append(" cnomcli = @cnomcli, ")
        strSQL.Append(" cnomcor = @cnomcli, ")
        strSQL.Append(" dnacimi = @dnacimi, ")
        strSQL.Append(" cnudoci = @cnudoci, ")
        strSQL.Append(" cnudotr = @cnudotr, ")
        strSQL.Append(" csexo = @csexo, ")
        strSQL.Append(" cestciv = @cestciv, ")
        strSQL.Append(" ccodpro = @ccodpro, ")
        strSQL.Append(" cCodDom = @cCodDom, ")
        strSQL.Append(" cDirdom = @cDirdom, ")
        strSQL.Append(" cTeldom = @cTeldom, ")
        strSQL.Append(" cnomcon = @cnomcon, ")
        strSQL.Append(" dfCony = @dfCony, ")
        strSQL.Append(" cduiCony = @cduiCony, ")
        strSQL.Append(" cCodOfi = @cCodOfi, ")
        strSQL.Append(" cProfCon = @cProfCon, ")
        strSQL.Append(" ctelfam = @ctelfam, ")
        strSQL.Append(" mdatadi = @mdatadi, ")
        strSQL.Append(" lsegvida = @lsegvida, ")
        strSQL.Append(" cfirma = @cfirma, ")
        strSQL.Append(" cetnia = @cetnia, ")
        strSQL.Append(" cnivel = @cnivel, ")
        strSQL.Append(" cadicional = @cadicional, cSexcon = @cSexcon, ccodusu = @ccodusu, ")
        strSQL.Append(" cconviv = @cconviv, clugexp = @clugexp, nsabeesc = @nsabeesc, npercar = @npercar, ctidoci = @ctidoci, ")
        strSQL.Append(" csegnom = @csegnom, cternom = @cternom, cpriape = @cpriape, csegape= @csegape, capecasada = @capecasada, cleer= @cleer, ")
        strSQL.Append(" cescribir= @cescribir, cfirmar = @cfirmar, cotrtel = @cotrtel, cgrado = @cgrado, nhijos = @nhijos, clocalidad = @clocalidad, cgruetnico = @cgruetnico, cidiomas = @cidiomas, cprinom = @cprinom, ")
        strSQL.Append("ctipocondic =  @ctipocondic, cparedes= @cparedes, cparedcondic =  @cparedcondic, cpiso = @cpiso, cpisocondic= @cpisocondic, ctecho =  @ctecho, ctechocondic =  @ctechocondic, cservicios = @cservicios, csercondic =  @csercondic, cnomdño = @cnomdño,nvalor =  @nvalor, nanodom =  @nanodom,  ")
        strSQL.Append("cgrusan = @cgrusan, ccodcon = @ccodcon, id_codigo_postal = @id_codigo_postal, id_ife = @id_ife, dfecmod = getdate(), ")
        strSQL.Append("ccalle = @ccalle, cnoext = @cnoext, cnoint = @cnoint, ccorreo = @ccorreo, usuface = @usuface, latitud = @latitud, longitud = @longitud")

        If lnflag = 0 Then 'no actualizara foto
        Else
            strSQL.Append(" ,foto = @foto ")
        End If

        strSQL.Append(" WHERE ccodcli = @ccodcli ")


        Dim args(70) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cclaper", SqlDbType.VarChar)
        args(1).Value = lEntidad.cclaper
        args(2) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomcli
        args(3) = New SqlParameter("@cnomcor", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomcli
        args(4) = New SqlParameter("@dnacimi", SqlDbType.DateTime)
        args(4).Value = lEntidad.dnacimi
        args(5) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnudoci
        args(6) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnudotr
        args(7) = New SqlParameter("@csexo", SqlDbType.VarChar)
        args(7).Value = lEntidad.csexo
        args(8) = New SqlParameter("@cestciv", SqlDbType.VarChar)
        args(8).Value = lEntidad.cestciv
        args(9) = New SqlParameter("@ccodpro", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodpro
        args(10) = New SqlParameter("@ccodDom", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccoddom
        args(11) = New SqlParameter("@cdirdom", SqlDbType.VarChar)
        args(11).Value = lEntidad.cdirdom
        args(12) = New SqlParameter("@cTelDom", SqlDbType.VarChar)
        args(12).Value = lEntidad.cteldom
        args(13) = New SqlParameter("@cNomCon", SqlDbType.VarChar)
        args(13).Value = lEntidad.cNomcon
        args(14) = New SqlParameter("@dfCony", SqlDbType.DateTime)
        args(14).Value = lEntidad.dfCony
        args(15) = New SqlParameter("@cduiCony", SqlDbType.VarChar)
        args(15).Value = lEntidad.cDuiCony
        args(16) = New SqlParameter("@cSexCon", SqlDbType.VarChar)
        args(16).Value = lEntidad.cSexcon
        args(17) = New SqlParameter("@cProfCon", SqlDbType.VarChar)
        args(17).Value = lEntidad.cProfCon
        args(18) = New SqlParameter("@cCodOfi", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodofi
        args(19) = New SqlParameter("@ctelfam", SqlDbType.VarChar)
        args(19).Value = lEntidad.cTelFam
        args(20) = New SqlParameter("@mdatadi", SqlDbType.VarChar)
        args(20).Value = lEntidad.mDatAdi
        args(21) = New SqlParameter("@lsegvida", SqlDbType.Bit)
        args(21).Value = lEntidad.lsegvida
        args(22) = New SqlParameter("@cfirma", SqlDbType.Bit)
        args(22).Value = lEntidad.cfirma
        args(23) = New SqlParameter("@cetnia", SqlDbType.VarChar)
        args(23).Value = lEntidad.cetnia
        args(24) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(24).Value = lEntidad.cnivel
        args(25) = New SqlParameter("@cadicional", SqlDbType.VarChar)
        args(25).Value = lEntidad.cadicional
        args(26) = New SqlParameter("@cconviv", SqlDbType.VarChar)
        args(26).Value = lEntidad.cconviv
        args(27) = New SqlParameter("@clugexp", SqlDbType.VarChar)
        args(27).Value = lEntidad.cLugExp
        args(28) = New SqlParameter("@nsabeesc", SqlDbType.Int)
        args(28).Value = lEntidad.nsabeesc
        args(29) = New SqlParameter("@npercar", SqlDbType.Int)
        args(29).Value = lEntidad.npercar
        args(30) = New SqlParameter("@ctidoci", SqlDbType.VarChar)
        args(30).Value = lEntidad.ctidoci

        args(31) = New SqlParameter("@csegnom", SqlDbType.VarChar)
        args(31).Value = lEntidad.csegnom
        args(32) = New SqlParameter("@cternom", SqlDbType.VarChar)
        args(32).Value = lEntidad.cternom
        args(33) = New SqlParameter("@cpriape", SqlDbType.VarChar)
        args(33).Value = lEntidad.cpriape
        args(34) = New SqlParameter("@csegape", SqlDbType.VarChar)
        args(34).Value = lEntidad.csegape
        args(35) = New SqlParameter("@capecasada", SqlDbType.VarChar)
        args(35).Value = lEntidad.capecasada
        args(36) = New SqlParameter("@cleer", SqlDbType.VarChar)
        args(36).Value = lEntidad.cleer
        args(37) = New SqlParameter("@cescribir", SqlDbType.VarChar)
        args(37).Value = lEntidad.cescribir
        args(38) = New SqlParameter("@cfirmar", SqlDbType.VarChar)
        args(38).Value = lEntidad.cfirmar
        args(39) = New SqlParameter("@cotrtel", SqlDbType.VarChar)
        args(39).Value = lEntidad.cotrtel
        args(40) = New SqlParameter("@cgrado", SqlDbType.VarChar)
        args(40).Value = lEntidad.cgrado
        args(41) = New SqlParameter("@nhijos", SqlDbType.Int)
        args(41).Value = lEntidad.nHijos
        args(42) = New SqlParameter("@clocalidad", SqlDbType.VarChar)
        args(42).Value = lEntidad.clocalidad
        args(43) = New SqlParameter("@cgruetnico", SqlDbType.VarChar)
        args(43).Value = lEntidad.cgruetnico
        args(44) = New SqlParameter("@cidiomas", SqlDbType.VarChar)
        args(44).Value = lEntidad.cidiomas
        args(45) = New SqlParameter("@cprinom", SqlDbType.VarChar)
        args(45).Value = lEntidad.cprinom

        args(46) = New SqlParameter("@ctipocondic", SqlDbType.VarChar)
        args(46).Value = lEntidad.ctipocondic
        args(47) = New SqlParameter("@cparedes", SqlDbType.VarChar)
        args(47).Value = lEntidad.cparedes
        args(48) = New SqlParameter("@cparedcondic", SqlDbType.VarChar)
        args(48).Value = lEntidad.cparedcondic
        args(49) = New SqlParameter("@cpiso", SqlDbType.VarChar)
        args(49).Value = lEntidad.cpiso
        args(50) = New SqlParameter("@cpisocondic", SqlDbType.VarChar)
        args(50).Value = lEntidad.cpisocondic
        args(51) = New SqlParameter("@ctecho", SqlDbType.VarChar)
        args(51).Value = lEntidad.ctecho
        args(52) = New SqlParameter("@ctechocondic", SqlDbType.VarChar)
        args(52).Value = lEntidad.ctechocondic
        args(53) = New SqlParameter("@cservicios", SqlDbType.VarChar)
        args(53).Value = lEntidad.cservicios
        args(54) = New SqlParameter("@csercondic", SqlDbType.VarChar)
        args(54).Value = lEntidad.csercondic
        args(55) = New SqlParameter("@cnomdño", SqlDbType.VarChar)
        args(55).Value = lEntidad.cNomDño
        args(56) = New SqlParameter("@nvalor", SqlDbType.Decimal)
        args(56).Value = lEntidad.nvalor
        args(57) = New SqlParameter("@nanodom", SqlDbType.Int)
        args(57).Value = lEntidad.nanodom
        args(58) = New SqlParameter("@cgrusan", SqlDbType.VarChar)
        args(58).Value = lEntidad.cgrusan
        args(59) = New SqlParameter("@ccodcon", SqlDbType.VarChar)
        args(59).Value = lEntidad.ccodcon
        args(60) = New SqlParameter("@foto", SqlDbType.Image)
        args(60).Value = lEntidad.foto
        args(61) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(61).Value = lEntidad.ccodusu
        args(62) = New SqlParameter("@id_codigo_postal", SqlDbType.VarChar)
        args(62).Value = lEntidad.id_codigo_postal
        args(63) = New SqlParameter("@id_ife", SqlDbType.VarChar)
        args(63).Value = lEntidad.id_ife
        args(64) = New SqlParameter("@ccalle", SqlDbType.VarChar)
        args(64).Value = lEntidad.cCalle
        args(65) = New SqlParameter("@cnoext", SqlDbType.VarChar)
        args(65).Value = lEntidad.cNoExt
        args(66) = New SqlParameter("@cnoint", SqlDbType.VarChar)
        args(66).Value = lEntidad.cNoInt
        args(67) = New SqlParameter("@ccorreo", SqlDbType.VarChar)
        args(67).Value = lEntidad.ccorreo
        args(68) = New SqlParameter("@usuface", SqlDbType.VarChar)
        args(68).Value = lEntidad.usuface
        args(69) = New SqlParameter("@latitud", SqlDbType.VarChar)
        args(69).Value = lEntidad.latitud
        args(70) = New SqlParameter("@longitud", SqlDbType.VarChar)
        args(70).Value = lEntidad.longitud

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetEsp(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodCli As Codigo, cNomCli ")
        strSQL.Append(" FROM climide ")
        strSQL.Append(" where cnomcli like" & "'" & "%" & cCodigo & "%" & "'")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    'Public Function Busca_codigo_Clie(ByVal ccodcli As String) As String
    '    Dim retorno As String = ""

    '    Dim strSQL As New StringBuilder

    '    strSQL.Append(" select ccodcli from climide where ccodcli=@ccodcli or cnomcli=@ccodcli or cnudoci=@ccodcli ")

    '    Dim args(0) As SqlParameter
    '    args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
    '    args(0).Value = ccodcli

    '    Dim ds As DataSet

    '    Try
    '        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    '    For Each recorre As DataRow In ds.Tables(0).Rows

    '        retorno = recorre("ccodcli")

    '    Next


    '    Return retorno
    'End Function

    Public Function ObtenerDataSetNivel(ByVal ccodigo As String, ByVal nNivel As Integer, ByVal cOficina As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodCli As Codigo, cNomCli, cnudoci, ccodrec = case when cgrusan is null OR rtrim(ltrim(cgrusan)) = ' ' then '       ' else 'Rechazado' end ")
        strSQL.Append(" FROM climide ")
        strSQL.Append(" where cnomcli like" & "'" & "%" & ccodigo & "%" & "'")
        strSQL.Append(" or cnudoci =" & "'" & ccodigo & "'")
        strSQL.Append(" or ccodcli =" & "'" & ccodigo & "'")
        strSQL.Append(" and climide.ccodcli  not in( select ccodcli from cremcre where cestado in('F','E','C') ) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina

        If cOficina = "001" Then
        Else
            'strSQL.Append(" and left(cCodofi,3) = @cOficina ")
        End If
        'If nNivel < 9 Then
        '    strSQL.Append(" and left(cCodofi,3) = @cOficina ")
        'End If
        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function ObtenerDataSetNivel2(ByVal nNivel As Integer, ByVal cOficina As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT Climide.ccodcli As Codigo, CLIMIDE.cNomCli FROM CLIMIDE ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina
        If nNivel < 9 Then
            strSQL.Append(" WHERE  left(cCodofi,3) = @cOficina ")
        End If

        Dim ds As DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtenerDataSetEsp1(ByVal cCodigo As String, ByVal nnivel As Integer, ByVal coficina As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT Cremcre.cCodCta As Codigo, Climide.cNomCli, Cremcre.ncapdes, Cremcre.dfecvig ")
        strSQL.Append(" FROM climide INNER JOIN Cremcre")
        strSQL.Append(" ON Climide.ccodcli = Cremcre.ccodcli")
        strSQL.Append(" where Climide.cnomcli like" & "'" & "%" & cCodigo & "%" & "'" & "  and Cremcre.cestado =" & "'" & "F" & "'")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina
        If nNivel < 9 Then
            strSQL.Append(" and  substring(cremcre.ccodcta,4,3) = @cOficina ")
        End If

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function



    Public Function ActualizaReferencia(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder


        strSQL.Append("UPDATE climide ")
        strSQL.Append(" SET cnominv = @cnominv, ")
        strSQL.Append(" cdominv = @cdominv, ")
        strSQL.Append(" ctelinv = @ctelinv, ")
        strSQL.Append(" cluginv = @cluginv, ")
        strSQL.Append(" ctelluginv = @ctelluginv, ")
        strSQL.Append(" cnomfam = @cnomfam, ")
        strSQL.Append(" cdomfam = @cdomfam, ")
        strSQL.Append(" cteldño = @cteldño, ")
        strSQL.Append(" clugfam = @clugfam, ")
        strSQL.Append(" ctellugfam = @ctellugfam, ")
        strSQL.Append(" cnomvec = @cnomvec, ")
        strSQL.Append(" cdomvec = @cdomvec, ")
        strSQL.Append(" ctelvec = @ctelvec, ")
        strSQL.Append(" clugvec = @clugvec, ")
        strSQL.Append(" ctellugvec = @ctellugvec, ")
        strSQL.Append(" cprefe1 = @cprefe1, ")
        strSQL.Append(" cprefe2 = @cprefe2, ")
        strSQL.Append(" cprefe3 = @cprefe3 ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")


        Dim args(20) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cnominv", SqlDbType.VarChar)
        args(1).Value = lEntidad.cNomInv
        args(2) = New SqlParameter("@cdominv", SqlDbType.VarChar)
        args(2).Value = lEntidad.cDomInv
        args(3) = New SqlParameter("@ctelinv", SqlDbType.VarChar)
        args(3).Value = lEntidad.cTelInv
        args(4) = New SqlParameter("@cluginv", SqlDbType.VarChar)
        args(4).Value = lEntidad.cLugInv
        args(5) = New SqlParameter("@ctelluginv", SqlDbType.VarChar)
        args(5).Value = lEntidad.cTelLugInv
        args(6) = New SqlParameter("@cnomfam", SqlDbType.VarChar)
        args(6).Value = lEntidad.cNomFam
        args(7) = New SqlParameter("@cdomfam", SqlDbType.VarChar)
        args(7).Value = lEntidad.cDomFam
        args(8) = New SqlParameter("@cteldño", SqlDbType.VarChar)
        args(8).Value = lEntidad.cTelDño
        args(9) = New SqlParameter("@clugfam", SqlDbType.VarChar)
        args(9).Value = lEntidad.cLugFam
        args(10) = New SqlParameter("@ctellugfam", SqlDbType.VarChar)
        args(10).Value = lEntidad.cTelLugFam
        args(11) = New SqlParameter("@cnomvec", SqlDbType.VarChar)
        args(11).Value = lEntidad.cNomVec
        args(12) = New SqlParameter("@cdomvec", SqlDbType.VarChar)
        args(12).Value = lEntidad.cDomVec
        args(13) = New SqlParameter("@ctelvec", SqlDbType.VarChar)
        args(13).Value = lEntidad.cTelVec
        args(14) = New SqlParameter("@clugvec", SqlDbType.VarChar)
        args(14).Value = lEntidad.clugVec
        args(15) = New SqlParameter("@ctellugvec", SqlDbType.VarChar)
        args(15).Value = lEntidad.cTelLugVec
        args(16) = New SqlParameter("@cprefe1", SqlDbType.VarChar)
        args(16).Value = lEntidad.cPrefe1
        args(17) = New SqlParameter("@cprefe2", SqlDbType.VarChar)
        args(17).Value = lEntidad.cPrefe2
        args(18) = New SqlParameter("@cprefe3", SqlDbType.VarChar)
        args(18).Value = lEntidad.cPrefe3
        Try
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ObtenercCodgar(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(cnrohij)+1 as cnrohij")
        strSQL.Append(" FROM Climhij ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("cnrohij")) Then
                lccodgar = "01"
            Else
                lccodgar = ds.Tables(0).Rows(0)("cnrohij")

                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 2 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = Nothing
        End If


        Return lccodgar

    End Function

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function AgregarHijos(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO climhij ")
        strSQL.Append(" ( ccodcli, ")
        strSQL.Append(" cnomhij, ")
        strSQL.Append(" dfecnac, ")
        strSQL.Append(" ccodgrad, ")
        strSQL.Append(" lcarnet, ")
        strSQL.Append(" cnrohij, ")
        strSQL.Append(" ccodusu) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ")
        strSQL.Append(" @cnomhij, ")
        strSQL.Append(" @dfecnac, ")
        strSQL.Append(" @ccodgrad, ")
        strSQL.Append(" @lcarnet, ")
        strSQL.Append(" @cnrohij, ")
        strSQL.Append(" @ccodusu) ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cnomhij", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomhij
        args(2) = New SqlParameter("@dfecnac", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecnac
        args(3) = New SqlParameter("@ccodgrad", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodgra

        args(4) = New SqlParameter("@lcarnet", SqlDbType.Bit)
        args(4).Value = lEntidad.lcarnet
        args(5) = New SqlParameter("@cnrohij", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnrohij
        args(6) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ActualizarHijos(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("update climhij ")
        strSQL.Append(" SET cnomhij = @cnomhij, ")
        strSQL.Append(" dfecnac  = @dfecnac, ")
        strSQL.Append(" ccodgrad = @ccodgrad, ")
        strSQL.Append(" lcarnet  = @lcarnet, ")
        strSQL.Append(" ccodusu  = @ccodusu ")
        strSQL.Append(" WHERE cCodcli = @ccodcli and cnrohij = @cnrohij ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cnomhij", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomhij
        args(2) = New SqlParameter("@dfecnac", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecnac
        args(3) = New SqlParameter("@ccodgrad", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodgra

        args(4) = New SqlParameter("@lcarnet", SqlDbType.Bit)
        args(4).Value = lEntidad.lcarnet
        args(5) = New SqlParameter("@cnrohij", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnrohij
        args(6) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerDataSetHijos(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select cnrohij, cnomhij, dfecnac, ccodgrad, lcarnet, 000 as nedad ")
        strSQL.Append(" FROM Climhij WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetporHijo(ByVal ccodcli As String, ByVal cnrohij As String) As DataSet

        Dim strSQL As New StringBuilder


        strSQL.Append(" Select cnrohij, cnomhij, dfecnac, ccodgrad, lcarnet, 000 as nedad ")
        strSQL.Append(" FROM Climhij WHERE ccodcli = @ccodcli and cnrohij = @cnrohij ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@cnrohij", cnrohij)


        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function QuitarRegistroporHijo(ByVal ccodcli As String, ByVal cnrohij As String) As Integer

        Dim strSQL As New StringBuilder


        strSQL.Append(" DELETE ")
        strSQL.Append(" FROM Climhij WHERE ccodcli = @ccodcli and cnrohij = @cnrohij ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@cnrohij", cnrohij)


        Dim ds As New DataSet
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)



    End Function

    Public Function AgregarEstudioSocio(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO CLIMSOC ")
        strSQL.Append(" ( ccodcli, ")
        strSQL.Append(" cdejaesc, ")
        strSQL.Append(" nprestamo, ")
        strSQL.Append(" ninvertir1, ")
        strSQL.Append(" ninvertir2, ")
        strSQL.Append(" ninvertir3, ")
        strSQL.Append(" ninvertir4, ")
        strSQL.Append(" ninvertir5, ")
        strSQL.Append(" ninvertir6, ")
        strSQL.Append(" cinvertir, ")
        strSQL.Append(" nuso1, ")
        strSQL.Append(" nuso2, ")
        strSQL.Append(" nuso3, ")
        strSQL.Append(" nuso4, ")
        strSQL.Append(" nuso5, ")
        strSQL.Append(" nhogar1, ")
        strSQL.Append(" nhogar2, ")
        strSQL.Append(" nhogar3, ")
        strSQL.Append(" nhogar4, ")
        strSQL.Append(" nhogar5, ")
        strSQL.Append(" nhogar6, ")
        strSQL.Append(" nhogarxq1, ")
        strSQL.Append(" nhogarxq2, ")
        strSQL.Append(" nhogarxq3, ")
        strSQL.Append(" nhogarxq4, ")
        strSQL.Append(" nhogarxq5, ")
        strSQL.Append(" chogarxq, ")
        strSQL.Append(" nsiaumento1, ")
        strSQL.Append(" nsiaumento2, ")
        strSQL.Append(" nsiaumento3, ")
        strSQL.Append(" nsiaumento4, ")
        strSQL.Append(" nsiaumento5, ")
        strSQL.Append(" nenseres, ")
        strSQL.Append(" nsicual1, ")
        strSQL.Append(" nsicual2, ")
        strSQL.Append(" nsicual3, ")
        strSQL.Append(" nsicual4, ")
        strSQL.Append(" nsicual5, ")
        strSQL.Append(" nsicual6, ")
        strSQL.Append(" nsicual7, ")
        strSQL.Append(" csicual, ")
        strSQL.Append(" npropia, ")
        strSQL.Append(" nmejoras, ")
        strSQL.Append(" nsimejoras1, ")
        strSQL.Append(" nsimejoras2, ")
        strSQL.Append(" nsimejoras3, ")
        strSQL.Append(" nsimejoras4, ")
        strSQL.Append(" nsimejoras5, ")
        strSQL.Append(" nsimejoras6, ")
        strSQL.Append(" nsimejoras7, ")
        strSQL.Append(" nsimejoras8, ")
        strSQL.Append(" csimejoras, ")
        strSQL.Append(" cCodusu) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ")
        strSQL.Append(" @cdejaesc, ")
        strSQL.Append(" @nprestamo, ")
        strSQL.Append(" @ninvertir1, ")
        strSQL.Append(" @ninvertir2, ")
        strSQL.Append(" @ninvertir3, ")
        strSQL.Append(" @ninvertir4, ")
        strSQL.Append(" @ninvertir5, ")
        strSQL.Append(" @ninvertir6, ")
        strSQL.Append(" @cinvertir, ")
        strSQL.Append(" @nuso1, ")
        strSQL.Append(" @nuso2, ")
        strSQL.Append(" @nuso3, ")
        strSQL.Append(" @nuso4, ")
        strSQL.Append(" @nuso5, ")
        strSQL.Append(" @nhogar1, ")
        strSQL.Append(" @nhogar2, ")
        strSQL.Append(" @nhogar3, ")
        strSQL.Append(" @nhogar4, ")
        strSQL.Append(" @nhogar5, ")
        strSQL.Append(" @nhogar6, ")
        strSQL.Append(" @nhogarxq1, ")
        strSQL.Append(" @nhogarxq2, ")
        strSQL.Append(" @nhogarxq3, ")
        strSQL.Append(" @nhogarxq4, ")
        strSQL.Append(" @nhogarxq5, ")
        strSQL.Append(" @chogarxq, ")
        strSQL.Append(" @nsiaumento1, ")
        strSQL.Append(" @nsiaumento2, ")
        strSQL.Append(" @nsiaumento3, ")
        strSQL.Append(" @nsiaumento4, ")
        strSQL.Append(" @nsiaumento5, ")
        strSQL.Append(" @nenseres, ")
        strSQL.Append(" @nsicual1, ")
        strSQL.Append(" @nsicual2, ")
        strSQL.Append(" @nsicual3, ")
        strSQL.Append(" @nsicual4, ")
        strSQL.Append(" @nsicual5, ")
        strSQL.Append(" @nsicual6, ")
        strSQL.Append(" @nsicual7, ")
        strSQL.Append(" @csicual, ")
        strSQL.Append(" @npropia, ")
        strSQL.Append(" @nmejoras, ")
        strSQL.Append(" @nsimejoras1, ")
        strSQL.Append(" @nsimejoras2, ")
        strSQL.Append(" @nsimejoras3, ")
        strSQL.Append(" @nsimejoras4, ")
        strSQL.Append(" @nsimejoras5, ")
        strSQL.Append(" @nsimejoras6, ")
        strSQL.Append(" @nsimejoras7, ")
        strSQL.Append(" @nsimejoras8, ")
        strSQL.Append(" @csimejoras, ")
        strSQL.Append(" @cCodusu) ")

        Dim args(55) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cdejaesc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdejaesc
        args(2) = New SqlParameter("@nprestamo", SqlDbType.Int)
        args(2).Value = lEntidad.nprestamo
        args(3) = New SqlParameter("@ninvertir1", SqlDbType.Int)
        args(3).Value = lEntidad.ninvertir1
        args(4) = New SqlParameter("@ninvertir2", SqlDbType.Int)
        args(4).Value = lEntidad.ninvertir2
        args(5) = New SqlParameter("@ninvertir3", SqlDbType.Int)
        args(5).Value = lEntidad.ninvertir3
        args(6) = New SqlParameter("@ninvertir4", SqlDbType.Int)
        args(6).Value = lEntidad.ninvertir4
        args(7) = New SqlParameter("@ninvertir5", SqlDbType.Int)
        args(7).Value = lEntidad.ninvertir5
        args(8) = New SqlParameter("@ninvertir6", SqlDbType.Int)
        args(8).Value = lEntidad.ninvertir6
        args(9) = New SqlParameter("@cinvertir", SqlDbType.VarChar)
        args(9).Value = lEntidad.cinvertir
        args(10) = New SqlParameter("@nuso1", SqlDbType.Int)
        args(10).Value = lEntidad.nuso1
        args(11) = New SqlParameter("@nuso2", SqlDbType.Int)
        args(11).Value = lEntidad.nuso2
        args(12) = New SqlParameter("@nuso3", SqlDbType.Int)
        args(12).Value = lEntidad.nuso3
        args(13) = New SqlParameter("@nuso4", SqlDbType.Int)
        args(13).Value = lEntidad.nuso4
        args(14) = New SqlParameter("@nuso5", SqlDbType.Int)
        args(14).Value = lEntidad.nuso5
        args(15) = New SqlParameter("@nhogar1", SqlDbType.Int)
        args(15).Value = lEntidad.nhogar1
        args(16) = New SqlParameter("@nhogar2", SqlDbType.Int)
        args(16).Value = lEntidad.nhogar2
        args(17) = New SqlParameter("@nhogar3", SqlDbType.Int)
        args(17).Value = lEntidad.nhogar3
        args(18) = New SqlParameter("@nhogar4", SqlDbType.Int)
        args(18).Value = lEntidad.nhogar4
        args(19) = New SqlParameter("@nhogar5", SqlDbType.Int)
        args(19).Value = lEntidad.nhogar5
        args(20) = New SqlParameter("@nhogar6", SqlDbType.Int)
        args(20).Value = lEntidad.nhogar6
        args(21) = New SqlParameter("@nhogarxq1", SqlDbType.Int)
        args(21).Value = lEntidad.nhogarxq1
        args(22) = New SqlParameter("@nhogarxq2", SqlDbType.Int)
        args(22).Value = lEntidad.nhogarxq2
        args(23) = New SqlParameter("@nhogarxq3", SqlDbType.Int)
        args(23).Value = lEntidad.nhogarxq3
        args(24) = New SqlParameter("@nhogarxq4", SqlDbType.Int)
        args(24).Value = lEntidad.nhogarxq4
        args(25) = New SqlParameter("@nhogarxq5", SqlDbType.Int)
        args(25).Value = lEntidad.nhogarxq5
        args(26) = New SqlParameter("@chogarxq", SqlDbType.VarChar)
        args(26).Value = lEntidad.chogarxq
        args(27) = New SqlParameter("@nsiaumento1", SqlDbType.Int)
        args(27).Value = lEntidad.nsiaumento1
        args(28) = New SqlParameter("@nsiaumento2", SqlDbType.Int)
        args(28).Value = lEntidad.nsiaumento2
        args(29) = New SqlParameter("@nsiaumento3", SqlDbType.Int)
        args(29).Value = lEntidad.nsiaumento3
        args(30) = New SqlParameter("@nsiaumento4", SqlDbType.Int)
        args(30).Value = lEntidad.nsiaumento4
        args(31) = New SqlParameter("@nsiaumento5", SqlDbType.Int)
        args(31).Value = lEntidad.nsiaumento5
        args(32) = New SqlParameter("@nenseres", SqlDbType.Int)
        args(32).Value = lEntidad.nenseres
        args(33) = New SqlParameter("@nsicual1", SqlDbType.Int)
        args(33).Value = lEntidad.nsicual1
        args(34) = New SqlParameter("@nsicual2", SqlDbType.Int)
        args(34).Value = lEntidad.nsicual2
        args(35) = New SqlParameter("@nsicual3", SqlDbType.Int)
        args(35).Value = lEntidad.nsicual3
        args(36) = New SqlParameter("@nsicual4", SqlDbType.Int)
        args(36).Value = lEntidad.nsicual4
        args(37) = New SqlParameter("@nsicual5", SqlDbType.Int)
        args(37).Value = lEntidad.nsicual5
        args(38) = New SqlParameter("@nsicual6", SqlDbType.Int)
        args(38).Value = lEntidad.nsicual6
        args(39) = New SqlParameter("@nsicual7", SqlDbType.Int)
        args(39).Value = lEntidad.nsicual7
        args(40) = New SqlParameter("@csicual", SqlDbType.VarChar)
        args(40).Value = lEntidad.csicual
        args(41) = New SqlParameter("@npropia", SqlDbType.Int)
        args(41).Value = lEntidad.npropia
        args(42) = New SqlParameter("@nmejoras", SqlDbType.Int)
        args(42).Value = lEntidad.nmejoras
        args(43) = New SqlParameter("@nsimejoras1", SqlDbType.Int)
        args(43).Value = lEntidad.nsimejoras1
        args(44) = New SqlParameter("@nsimejoras2", SqlDbType.Int)
        args(44).Value = lEntidad.nsimejoras2
        args(45) = New SqlParameter("@nsimejoras3", SqlDbType.Int)
        args(45).Value = lEntidad.nsimejoras3
        args(46) = New SqlParameter("@nsimejoras4", SqlDbType.Int)
        args(46).Value = lEntidad.nsimejoras4
        args(47) = New SqlParameter("@nsimejoras5", SqlDbType.Int)
        args(47).Value = lEntidad.nsimejoras5
        args(48) = New SqlParameter("@nsimejoras6", SqlDbType.Int)
        args(48).Value = lEntidad.nsimejoras6
        args(49) = New SqlParameter("@nsimejoras7", SqlDbType.Int)
        args(49).Value = lEntidad.nsimejoras7
        args(50) = New SqlParameter("@nsimejoras8", SqlDbType.Int)
        args(50).Value = lEntidad.nsimejoras8
        args(51) = New SqlParameter("@csimejoras", SqlDbType.VarChar)
        args(51).Value = lEntidad.csimejoras
        args(52) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(52).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizarEstudioSocio(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE CLIMSOC SET ")
        strSQL.Append(" cdejaesc = @cdejaesc, ")
        strSQL.Append(" nprestamo = @nprestamo, ")
        strSQL.Append(" ninvertir1 = @ninvertir1, ")
        strSQL.Append(" ninvertir2 = @ninvertir2, ")
        strSQL.Append(" ninvertir3 = @ninvertir3, ")
        strSQL.Append(" ninvertir4 = @ninvertir4, ")
        strSQL.Append(" ninvertir5 = @ninvertir5, ")
        strSQL.Append(" ninvertir6 = @ninvertir6, ")
        strSQL.Append(" cinvertir = @cinvertir, ")
        strSQL.Append(" nuso1 = @nuso1, ")
        strSQL.Append(" nuso2 = @nuso2, ")
        strSQL.Append(" nuso3 = @nuso3, ")
        strSQL.Append(" nuso4 = @nuso4, ")
        strSQL.Append(" nuso5 = @nuso5, ")
        strSQL.Append(" nhogar1 = @nhogar1, ")
        strSQL.Append(" nhogar2 = @nhogar2, ")
        strSQL.Append(" nhogar3 = @nhogar3, ")
        strSQL.Append(" nhogar4 = @nhogar4, ")
        strSQL.Append(" nhogar5 = @nhogar5, ")
        strSQL.Append(" nhogar6 = @nhogar6, ")
        strSQL.Append(" nhogarxq1 = @nhogarxq1, ")
        strSQL.Append(" nhogarxq2 = @nhogarxq2, ")
        strSQL.Append(" nhogarxq3 = @nhogarxq3, ")
        strSQL.Append(" nhogarxq4 = @nhogarxq4, ")
        strSQL.Append(" nhogarxq5 = @nhogarxq5, ")
        strSQL.Append(" chogarxq = @chogarxq, ")
        strSQL.Append(" nsiaumento1 = @nsiaumento1, ")
        strSQL.Append(" nsiaumento2 = @nsiaumento2, ")
        strSQL.Append(" nsiaumento3 = @nsiaumento3, ")
        strSQL.Append(" nsiaumento4 = @nsiaumento4, ")
        strSQL.Append(" nsiaumento5 = @nsiaumento5, ")
        strSQL.Append(" nenseres = @nenseres, ")
        strSQL.Append(" nsicual1 = @nsicual1, ")
        strSQL.Append(" nsicual2 = @nsicual2, ")
        strSQL.Append(" nsicual3 = @nsicual3, ")
        strSQL.Append(" nsicual4 = @nsicual4, ")
        strSQL.Append(" nsicual5 = @nsicual5, ")
        strSQL.Append(" nsicual6 = @nsicual6, ")
        strSQL.Append(" nsicual7 = @nsicual7, ")
        strSQL.Append(" csicual = @csicual, ")
        strSQL.Append(" npropia = @npropia, ")
        strSQL.Append(" nmejoras = @nmejoras, ")
        strSQL.Append(" nsimejoras1 = @nsimejoras1, ")
        strSQL.Append(" nsimejoras2 = @nsimejoras2, ")
        strSQL.Append(" nsimejoras3 = @nsimejoras3, ")
        strSQL.Append(" nsimejoras4 = @nsimejoras4, ")
        strSQL.Append(" nsimejoras5 = @nsimejoras5, ")
        strSQL.Append(" nsimejoras6 = @nsimejoras6, ")
        strSQL.Append(" nsimejoras7 = @nsimejoras7, ")
        strSQL.Append(" nsimejoras8 = @nsimejoras8, ")
        strSQL.Append(" csimejoras = @csimejoras, ")
        strSQL.Append(" cCodusu = @cCodusu ")
        strSQL.Append(" WHERE cCodcli = @cCodcli ")

        Dim args(55) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cdejaesc", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdejaesc
        args(2) = New SqlParameter("@nprestamo", SqlDbType.Int)
        args(2).Value = lEntidad.nprestamo
        args(3) = New SqlParameter("@ninvertir1", SqlDbType.Int)
        args(3).Value = lEntidad.ninvertir1
        args(4) = New SqlParameter("@ninvertir2", SqlDbType.Int)
        args(4).Value = lEntidad.ninvertir2
        args(5) = New SqlParameter("@ninvertir3", SqlDbType.Int)
        args(5).Value = lEntidad.ninvertir3
        args(6) = New SqlParameter("@ninvertir4", SqlDbType.Int)
        args(6).Value = lEntidad.ninvertir4
        args(7) = New SqlParameter("@ninvertir5", SqlDbType.Int)
        args(7).Value = lEntidad.ninvertir5
        args(8) = New SqlParameter("@ninvertir6", SqlDbType.Int)
        args(8).Value = lEntidad.ninvertir6
        args(9) = New SqlParameter("@cinvertir", SqlDbType.VarChar)
        args(9).Value = lEntidad.cinvertir
        args(10) = New SqlParameter("@nuso1", SqlDbType.Int)
        args(10).Value = lEntidad.nuso1
        args(11) = New SqlParameter("@nuso2", SqlDbType.Int)
        args(11).Value = lEntidad.nuso2
        args(12) = New SqlParameter("@nuso3", SqlDbType.Int)
        args(12).Value = lEntidad.nuso3
        args(13) = New SqlParameter("@nuso4", SqlDbType.Int)
        args(13).Value = lEntidad.nuso4
        args(14) = New SqlParameter("@nuso5", SqlDbType.Int)
        args(14).Value = lEntidad.nuso5
        args(15) = New SqlParameter("@nhogar1", SqlDbType.Int)
        args(15).Value = lEntidad.nhogar1
        args(16) = New SqlParameter("@nhogar2", SqlDbType.Int)
        args(16).Value = lEntidad.nhogar2
        args(17) = New SqlParameter("@nhogar3", SqlDbType.Int)
        args(17).Value = lEntidad.nhogar3
        args(18) = New SqlParameter("@nhogar4", SqlDbType.Int)
        args(18).Value = lEntidad.nhogar4
        args(19) = New SqlParameter("@nhogar5", SqlDbType.Int)
        args(19).Value = lEntidad.nhogar5
        args(20) = New SqlParameter("@nhogar6", SqlDbType.Int)
        args(20).Value = lEntidad.nhogar6
        args(21) = New SqlParameter("@nhogarxq1", SqlDbType.Int)
        args(21).Value = lEntidad.nhogarxq1
        args(22) = New SqlParameter("@nhogarxq2", SqlDbType.Int)
        args(22).Value = lEntidad.nhogarxq2
        args(23) = New SqlParameter("@nhogarxq3", SqlDbType.Int)
        args(23).Value = lEntidad.nhogarxq3
        args(24) = New SqlParameter("@nhogarxq4", SqlDbType.Int)
        args(24).Value = lEntidad.nhogarxq4
        args(25) = New SqlParameter("@nhogarxq5", SqlDbType.Int)
        args(25).Value = lEntidad.nhogarxq5
        args(26) = New SqlParameter("@chogarxq", SqlDbType.VarChar)
        args(26).Value = lEntidad.chogarxq
        args(27) = New SqlParameter("@nsiaumento1", SqlDbType.Int)
        args(27).Value = lEntidad.nsiaumento1
        args(28) = New SqlParameter("@nsiaumento2", SqlDbType.Int)
        args(28).Value = lEntidad.nsiaumento2
        args(29) = New SqlParameter("@nsiaumento3", SqlDbType.Int)
        args(29).Value = lEntidad.nsiaumento3
        args(30) = New SqlParameter("@nsiaumento4", SqlDbType.Int)
        args(30).Value = lEntidad.nsiaumento4
        args(31) = New SqlParameter("@nsiaumento5", SqlDbType.Int)
        args(31).Value = lEntidad.nsiaumento5
        args(32) = New SqlParameter("@nenseres", SqlDbType.Int)
        args(32).Value = lEntidad.nenseres
        args(33) = New SqlParameter("@nsicual1", SqlDbType.Int)
        args(33).Value = lEntidad.nsicual1
        args(34) = New SqlParameter("@nsicual2", SqlDbType.Int)
        args(34).Value = lEntidad.nsicual2
        args(35) = New SqlParameter("@nsicual3", SqlDbType.Int)
        args(35).Value = lEntidad.nsicual3
        args(36) = New SqlParameter("@nsicual4", SqlDbType.Int)
        args(36).Value = lEntidad.nsicual4
        args(37) = New SqlParameter("@nsicual5", SqlDbType.Int)
        args(37).Value = lEntidad.nsicual5
        args(38) = New SqlParameter("@nsicual6", SqlDbType.Int)
        args(38).Value = lEntidad.nsicual6
        args(39) = New SqlParameter("@nsicual7", SqlDbType.Int)
        args(39).Value = lEntidad.nsicual7
        args(40) = New SqlParameter("@csicual", SqlDbType.VarChar)
        args(40).Value = lEntidad.csicual
        args(41) = New SqlParameter("@npropia", SqlDbType.Int)
        args(41).Value = lEntidad.npropia
        args(42) = New SqlParameter("@nmejoras", SqlDbType.Int)
        args(42).Value = lEntidad.nmejoras
        args(43) = New SqlParameter("@nsimejoras1", SqlDbType.Int)
        args(43).Value = lEntidad.nsimejoras1
        args(44) = New SqlParameter("@nsimejoras2", SqlDbType.Int)
        args(44).Value = lEntidad.nsimejoras2
        args(45) = New SqlParameter("@nsimejoras3", SqlDbType.Int)
        args(45).Value = lEntidad.nsimejoras3
        args(46) = New SqlParameter("@nsimejoras4", SqlDbType.Int)
        args(46).Value = lEntidad.nsimejoras4
        args(47) = New SqlParameter("@nsimejoras5", SqlDbType.Int)
        args(47).Value = lEntidad.nsimejoras5
        args(48) = New SqlParameter("@nsimejoras6", SqlDbType.Int)
        args(48).Value = lEntidad.nsimejoras6
        args(49) = New SqlParameter("@nsimejoras7", SqlDbType.Int)
        args(49).Value = lEntidad.nsimejoras7
        args(50) = New SqlParameter("@nsimejoras8", SqlDbType.Int)
        args(50).Value = lEntidad.nsimejoras8
        args(51) = New SqlParameter("@csimejoras", SqlDbType.VarChar)
        args(51).Value = lEntidad.csimejoras
        args(52) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(52).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ExisteRegistroSocioEco(ByVal cCodcli As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodcli FROM CLIMSOC Where cCodcli = @cCodcli ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function RecuperarEstudioSocio(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTablaEstudio(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cdejaesc = IIf(.Item("cdejaesc") Is DBNull.Value, Nothing, .Item("cdejaesc"))
                lEntidad.nprestamo = IIf(.Item("nprestamo") Is DBNull.Value, Nothing, .Item("nprestamo"))
                lEntidad.ninvertir1 = IIf(.Item("ninvertir1") Is DBNull.Value, Nothing, .Item("ninvertir1"))
                lEntidad.ninvertir2 = IIf(.Item("ninvertir2") Is DBNull.Value, Nothing, .Item("ninvertir2"))
                lEntidad.ninvertir3 = IIf(.Item("ninvertir3") Is DBNull.Value, Nothing, .Item("ninvertir3"))
                lEntidad.ninvertir4 = IIf(.Item("ninvertir4") Is DBNull.Value, Nothing, .Item("ninvertir4"))
                lEntidad.ninvertir5 = IIf(.Item("ninvertir5") Is DBNull.Value, Nothing, .Item("ninvertir5"))
                lEntidad.ninvertir6 = IIf(.Item("ninvertir6") Is DBNull.Value, Nothing, .Item("ninvertir6"))

                lEntidad.cinvertir = IIf(.Item("cinvertir") Is DBNull.Value, Nothing, .Item("cinvertir"))
                lEntidad.nuso1 = IIf(.Item("nuso1") Is DBNull.Value, Nothing, .Item("nuso1"))
                lEntidad.nuso2 = IIf(.Item("nuso2") Is DBNull.Value, Nothing, .Item("nuso2"))
                lEntidad.nuso3 = IIf(.Item("nuso3") Is DBNull.Value, Nothing, .Item("nuso3"))
                lEntidad.nuso4 = IIf(.Item("nuso4") Is DBNull.Value, Nothing, .Item("nuso4"))
                lEntidad.nuso5 = IIf(.Item("nuso5") Is DBNull.Value, Nothing, .Item("nuso5"))

                lEntidad.nhogar1 = IIf(.Item("nhogar1") Is DBNull.Value, Nothing, .Item("nhogar1"))
                lEntidad.nhogar2 = IIf(.Item("nhogar2") Is DBNull.Value, Nothing, .Item("nhogar2"))
                lEntidad.nhogar3 = IIf(.Item("nhogar3") Is DBNull.Value, Nothing, .Item("nhogar3"))
                lEntidad.nhogar4 = IIf(.Item("nhogar4") Is DBNull.Value, Nothing, .Item("nhogar4"))
                lEntidad.nhogar5 = IIf(.Item("nhogar5") Is DBNull.Value, Nothing, .Item("nhogar5"))
                lEntidad.nhogar6 = IIf(.Item("nhogar6") Is DBNull.Value, Nothing, .Item("nhogar6"))

                lEntidad.nhogarxq1 = IIf(.Item("nhogarxq1") Is DBNull.Value, Nothing, .Item("nhogarxq1"))
                lEntidad.nhogarxq2 = IIf(.Item("nhogarxq2") Is DBNull.Value, Nothing, .Item("nhogarxq2"))
                lEntidad.nhogarxq3 = IIf(.Item("nhogarxq3") Is DBNull.Value, Nothing, .Item("nhogarxq3"))
                lEntidad.nhogarxq4 = IIf(.Item("nhogarxq4") Is DBNull.Value, Nothing, .Item("nhogarxq4"))
                lEntidad.nhogarxq5 = IIf(.Item("nhogarxq5") Is DBNull.Value, Nothing, .Item("nhogarxq5"))

                lEntidad.chogarxq = IIf(.Item("chogarxq") Is DBNull.Value, Nothing, .Item("chogarxq"))

                lEntidad.nsiaumento1 = IIf(.Item("nsiaumento1") Is DBNull.Value, Nothing, .Item("nsiaumento1"))
                lEntidad.nsiaumento1 = IIf(.Item("nsiaumento2") Is DBNull.Value, Nothing, .Item("nsiaumento2"))
                lEntidad.nsiaumento1 = IIf(.Item("nsiaumento3") Is DBNull.Value, Nothing, .Item("nsiaumento3"))
                lEntidad.nsiaumento1 = IIf(.Item("nsiaumento4") Is DBNull.Value, Nothing, .Item("nsiaumento4"))
                lEntidad.nsiaumento1 = IIf(.Item("nsiaumento5") Is DBNull.Value, Nothing, .Item("nsiaumento5"))

                lEntidad.nenseres = IIf(.Item("nenseres") Is DBNull.Value, Nothing, .Item("nenseres"))

                lEntidad.nsicual1 = IIf(.Item("nsicual1") Is DBNull.Value, Nothing, .Item("nsicual1"))
                lEntidad.nsicual2 = IIf(.Item("nsicual2") Is DBNull.Value, Nothing, .Item("nsicual2"))
                lEntidad.nsicual3 = IIf(.Item("nsicual3") Is DBNull.Value, Nothing, .Item("nsicual3"))
                lEntidad.nsicual4 = IIf(.Item("nsicual4") Is DBNull.Value, Nothing, .Item("nsicual4"))
                lEntidad.nsicual5 = IIf(.Item("nsicual5") Is DBNull.Value, Nothing, .Item("nsicual5"))
                lEntidad.nsicual6 = IIf(.Item("nsicual6") Is DBNull.Value, Nothing, .Item("nsicual6"))
                lEntidad.nsicual7 = IIf(.Item("nsicual7") Is DBNull.Value, Nothing, .Item("nsicual7"))

                lEntidad.csicual = IIf(.Item("csicual") Is DBNull.Value, Nothing, .Item("csicual"))

                lEntidad.npropia = IIf(.Item("npropia") Is DBNull.Value, Nothing, .Item("npropia"))
                lEntidad.nmejoras = IIf(.Item("nmejoras") Is DBNull.Value, Nothing, .Item("nmejoras"))

                lEntidad.nsimejoras1 = IIf(.Item("nsimejoras1") Is DBNull.Value, Nothing, .Item("nsimejoras1"))
                lEntidad.nsimejoras2 = IIf(.Item("nsimejoras2") Is DBNull.Value, Nothing, .Item("nsimejoras2"))
                lEntidad.nsimejoras3 = IIf(.Item("nsimejoras3") Is DBNull.Value, Nothing, .Item("nsimejoras3"))
                lEntidad.nsimejoras4 = IIf(.Item("nsimejoras4") Is DBNull.Value, Nothing, .Item("nsimejoras4"))
                lEntidad.nsimejoras5 = IIf(.Item("nsimejoras5") Is DBNull.Value, Nothing, .Item("nsimejoras5"))
                lEntidad.nsimejoras6 = IIf(.Item("nsimejoras6") Is DBNull.Value, Nothing, .Item("nsimejoras6"))
                lEntidad.nsimejoras7 = IIf(.Item("nsimejoras7") Is DBNull.Value, Nothing, .Item("nsimejoras7"))
                lEntidad.nsimejoras8 = IIf(.Item("nsimejoras8") Is DBNull.Value, Nothing, .Item("nsimejoras8"))

                lEntidad.csimejoras = IIf(.Item("csimejoras") Is DBNull.Value, Nothing, .Item("csimejoras"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function
    Private Sub SelectTablaEstudio(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT * ")
        strSQL.Append(" FROM CLIMSOC ")
    End Sub
    Public Function RecuperarDireccion(ByVal cCodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cdirdom FROM CLIMIDE WHERE cCodcli = @cCodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcdirdom As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
            lcdirdom = ""
        Else
            lcdirdom = ds.Tables(0).Rows(0)("cdirdom")
        End If

        Return lcdirdom
    End Function

    Public Function VerificaDocumento(ByVal cCodigo As String) As Boolean
        Dim strsql As New StringBuilder
        strsql.Append("Select cnudoci from climide ")
        strsql.Append("WHERE ltrim(rtrim(cNudoci)) = @cCodigo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodigo", SqlDbType.VarChar)
        args(0).Value = cCodigo.Trim


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return True
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnudoci")) Then
                Return True
            Else
                Return False
            End If
        End If

    End Function
    Public Function ClienteMayorEdad() As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select MAX(dnacimi) as fecha FROM CLIMIDE ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds.Tables(0).Rows(0)("fecha")
        End If


    End Function


    Public Function RecuperarNombre(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select climide.cnomcli FROM CLIMIDE, cremcre WHERE cremcre.ccodcli = climide.ccodcli and cremcre.ccodcta = @cCodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcdirdom As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
            lcdirdom = ""
        Else
            lcdirdom = IIf(IsDBNull(ds.Tables(0).Rows(0)("cnomcli")), "", ds.Tables(0).Rows(0)("cnomcli"))
        End If

        Return lcdirdom
    End Function
    'OBTIENE LOS DATOS DE UN GRUPO AL CUAL PERTENECE UN CLIENTE
    'ESTO ES PARA EL RECIBO DE OTROS INGRESOS
    Public Function ObtenerDatosGrupo(ByVal ccodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select top 1 cremsol.* from cremcre inner join cremsol on cremcre.ccodsol=cremsol.ccodsol where cremcre.ccodcli=@ccodcli and cremcre.cestado='F' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccnomgru As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
            lccnomgru = ""
        Else
            lccnomgru = IIf(IsDBNull(ds.Tables(0).Rows(0)("cnomgru")), "", ds.Tables(0).Rows(0)("cnomgru"))
        End If

        Return lccnomgru

    End Function
    Public Function ActualizaCodigoRechazo(ByVal cCodcli As String, ByVal cCodrec As String, ByVal ccodusu As String, ByVal dfecha As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CLIMIDE set cgrusan = @cCodrec, ccodusu = @ccodusu, dfecult =@dfecha WHERE cCodcli = @cCodcli ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        args(1) = New SqlParameter("@cCodrec", SqlDbType.VarChar)
        args(1).Value = cCodrec
        args(2) = New SqlParameter("@cCodusu", SqlDbType.VarChar)
        args(2).Value = ccodusu
        args(3) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(3).Value = dfecha


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtieneClientesRechazados(ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select  climide.ccodcli, climide.cnomcli , tabttab.cdescri, climide.ccodusu, climide.dfecult ")
        strSQL.Append("from climide, tabttab where left(climide.cgrusan,2) = left(tabttab.ccodigo,2) ")
        strSQL.Append("and tabttab.ccodtab ='156' and ctipreg ='1' and dfecult >= @dfec1 and dfecult <= @dfec2 ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfec1", SqlDbType.DateTime)
        args(0).Value = dfec1
        args(1) = New SqlParameter("@dfec2", SqlDbType.DateTime)
        args(1).Value = dfec2


        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function
    Public Function StatusCliente(ByVal ccodcli As String) As String
        Dim strsql As New StringBuilder
        strsql.Append("select cgrusan from climide where ccodcli = @ccodcli")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        Dim ds As New DataSet
        Dim lccodrec As String

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lccodrec = ""
        Else
            lccodrec = IIf(IsDBNull(ds.Tables(0).Rows(0)("cgrusan")), "", ds.Tables(0).Rows(0)("cgrusan"))
        End If
        Return lccodrec
    End Function
    Public Function ActualizaClimideI(ByVal ccodcli As String, ByVal lccodagennuevo As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CLIMIDE SET ccodofi = @lccodagennuevo  WHERE ccodcli = @ccodcli  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lccodagennuevo", SqlDbType.VarChar)
        args(0).Value = lccodagennuevo
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = ccodcli
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerDatosClimide(ByVal cCodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ccodcli, cnomcli  ")
        strSQL.Append(" FROM climide ")
        strSQL.Append(" where ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function EliminarReferencias(ByVal ccodcli As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("delete from climref where ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function AgregarReferencias(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As climide
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO climref ")
        strSQL.Append(" ( ccodcli, cnomrefper1, cnomrefper2, cnomrefper3, ctelrefper1, ctelrefper2, ctelrefper3, cdirrefper1, cdirrefper2, cdirrefper3, ctiprefper1, ctiprefper2, ctiprefper3,   ")
        strSQL.Append(" cnomrefcom1, cnomrefcom2, cnomrefcom3, ctelrefcom1, ctelrefcom2, ctelrefcom3, cdirrefcom1, cdirrefcom2, cdirrefcom3, ctiprefcom1, ctiprefcom2, ctiprefcom3, cparentesco, ctelcelular, cparentesco1, ctelcelular1, dfecmod, ccodusu)   ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, @cnomrefper1, @cnomrefper2, @cnomrefper3, @ctelrefper1, @ctelrefper2, @ctelrefper3, @cdirrefper1, @cdirrefper2, @cdirrefper3, @ctiprefper1, @ctiprefper2, @ctiprefper3,   ")
        strSQL.Append(" @cnomrefcom1, @cnomrefcom2, @cnomrefcom3, @ctelrefcom1, @ctelrefcom2, @ctelrefcom3, @cdirrefcom1, @cdirrefcom2, @cdirrefcom3, @ctiprefcom1, @ctiprefcom2, @ctiprefcom3, @cparentesco, @ctelcelular, @cparentesco1, @ctelcelular1, getdate(), @ccodusu)   ")

        Dim args(30) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cnomrefper1", SqlDbType.VarChar)
        args(1).Value = lEntidad.cNomInv
        args(2) = New SqlParameter("@cnomrefper2", SqlDbType.VarChar)
        args(2).Value = lEntidad.cNomFam
        args(3) = New SqlParameter("@cnomrefper3", SqlDbType.VarChar)
        args(3).Value = lEntidad.cNomVec
        args(4) = New SqlParameter("@ctelrefper1", SqlDbType.VarChar)
        args(4).Value = lEntidad.cTelInv
        args(5) = New SqlParameter("@ctelrefper2", SqlDbType.VarChar)
        args(5).Value = lEntidad.cTelDño
        args(6) = New SqlParameter("@ctelrefper3", SqlDbType.VarChar)
        args(6).Value = lEntidad.cTelVec
        args(7) = New SqlParameter("@cdirrefper1", SqlDbType.VarChar)
        args(7).Value = lEntidad.cDomInv
        args(8) = New SqlParameter("@cdirrefper2", SqlDbType.VarChar)
        args(8).Value = lEntidad.cDomFam
        args(9) = New SqlParameter("@cdirrefper3", SqlDbType.VarChar)
        args(9).Value = lEntidad.cDomVec
        args(10) = New SqlParameter("@ctiprefper1", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctiprefper1
        args(11) = New SqlParameter("@ctiprefper2", SqlDbType.VarChar)
        args(11).Value = lEntidad.ctiprefper2
        args(12) = New SqlParameter("@ctiprefper3", SqlDbType.VarChar)
        args(12).Value = lEntidad.ctiprefper3

        args(13) = New SqlParameter("@cnomrefcom1", SqlDbType.VarChar)
        args(13).Value = lEntidad.cnomrefcom1
        args(14) = New SqlParameter("@cnomrefcom2", SqlDbType.VarChar)
        args(14).Value = lEntidad.cnomrefcom2
        args(15) = New SqlParameter("@cnomrefcom3", SqlDbType.VarChar)
        args(15).Value = lEntidad.cnomrefcom3
        args(16) = New SqlParameter("@ctelrefcom1", SqlDbType.VarChar)
        args(16).Value = lEntidad.ctelrefcom1
        args(17) = New SqlParameter("@ctelrefcom2", SqlDbType.VarChar)
        args(17).Value = lEntidad.ctelrefcom2
        args(18) = New SqlParameter("@ctelrefcom3", SqlDbType.VarChar)
        args(18).Value = lEntidad.ctelrefcom3
        args(19) = New SqlParameter("@cdirrefcom1", SqlDbType.VarChar)
        args(19).Value = lEntidad.cdirrefcom1
        args(20) = New SqlParameter("@cdirrefcom2", SqlDbType.VarChar)
        args(20).Value = lEntidad.cdirrefcom2
        args(21) = New SqlParameter("@cdirrefcom3", SqlDbType.VarChar)
        args(21).Value = lEntidad.cdirrefcom3
        args(22) = New SqlParameter("@ctiprefcom1", SqlDbType.VarChar)
        args(22).Value = lEntidad.ctiprefcom1
        args(23) = New SqlParameter("@ctiprefcom2", SqlDbType.VarChar)
        args(23).Value = lEntidad.ctiprefcom2
        args(24) = New SqlParameter("@ctiprefcom3", SqlDbType.VarChar)
        args(24).Value = lEntidad.ctiprefcom3
        args(25) = New SqlParameter("@cparentesco", SqlDbType.VarChar)
        args(25).Value = lEntidad.cparentesco
        args(26) = New SqlParameter("@ctelcelular", SqlDbType.VarChar)
        args(26).Value = lEntidad.ctelcelular
        args(27) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(27).Value = lEntidad.dfecmod
        args(28) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(28).Value = lEntidad.ccodusu
        args(29) = New SqlParameter("@cparentesco1", SqlDbType.VarChar)
        args(29).Value = lEntidad.cparentesco1
        args(30) = New SqlParameter("@ctelcelular1", SqlDbType.VarChar)
        args(30).Value = lEntidad.ctelcelular1

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerReferencias(ByVal ccodcli) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select climref.*, climide.cnomcli from climref , climide ")
        strSQL.Append("where climide.ccodcli = climref.ccodcli and climref.ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function RecuperarZona(ByVal cCodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccoddom FROM CLIMIDE WHERE cCodcli = @cCodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcdirdom As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
            lcdirdom = ""
        Else
            lcdirdom = ds.Tables(0).Rows(0)("ccoddom")
        End If

        Return lcdirdom
    End Function
    Public Function ObtenerDataSetporOficina(ByVal ccodreg As String, ByVal ccodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        'strSQL.Append("SELECT max(substring(ccodcli,7,6)) as correlativo ")
        'strSQL.Append(" FROM climide where left(ccodcli,3) = @ccodreg and substring(ccodcli,4,3) = @ccodofi ")

        'Esta parte es para q el codigo solo tenga la oficina
        strSQL.Append("SELECT max(substring(ccodcli,4,9)) as correlativo ")
        strSQL.Append(" FROM climide where left(ccodcli,3) =  @ccodofi ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodreg", SqlDbType.VarChar)
        args(0).Value = ccodreg
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = ccodofi

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function Documento_cliente_Existente(ByVal ccodigo As String, ByVal ccodcli As String) As Boolean
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lretorno As Boolean = True

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Select cnudoci from climide where ccodcli='" & ccodcli.Trim & "' and cnudoci='" & ccodigo & "'"
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Cliente")


                If ds.Tables("Cliente").Rows.Count = 0 Then
                    'Ahora Busca si ya existe en otro cliente ese documento
                    lretorno = VerificaDocumento(ccodigo.Trim)
                Else 'Lo encontro; es el mismo 
                    lretorno = True
                End If
               
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using
        Return lretorno
    End Function


    Public Function Buscar_Socio_ID(ByVal asociado As String) As DataSet


        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet
        Dim str_select As String

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try


                MyCommand.Connection = connection

                Dim letra As Char = Left(asociado, 1)

                If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
                    str_select = " Select ccodcli as asociado, cnomcli as nombre, cnudoci as dui, cnudotr as nit, cbenef1 as colegio, id_ife " & _
                                 " from climide where  ccodcli like " & "'%" & asociado.Trim & "%' order by ccodcli"
                Else
                    str_select = " Select ccodcli as asociado, cnomcli as nombre, cnudoci as dui, cnudotr as nit, cbenef1 as colegio, id_ife" & _
                                 " from climide where cnomcli like " & "'%" & asociado.Trim & "%' order by cnomcli"

                End If

                MyCommand.CommandText = str_select
                MyCommand.CommandType = CommandType.Text

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds, "BD_Socios")

                'lnRetorno = CInt(MyCommand.Parameters("@pnError").Value)

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return Ds

    End Function

    Public Function Extraer_Datos_Socio(ByVal pntipo As Integer, ByVal pcdescri As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                Select Case pntipo
                    Case 1  'Nombre del Socio
                        _sql = _
                                " Select top 600 ccodcli, ltrim(rtrim(cnomcli)) as cnomcli, cnudoci, (rtrim(cprinom) + SPACE(1) + rtrim(csegnom)) as cnombres, " & _
                                " (rtrim(cpriape) + SPACE(1) + rtrim(csegape))  as capellidos, 'ACTIVO' as cestado " & _
                                " from Climide " & _
                                " Where cnomcli like '%" & pcdescri & "%'"
                    Case 2   'Número de DUI
                        _sql = _
                                " Select top 600 ccodcli, ltrim(rtrim(cnomcli)) as cnomcli, cnudoci, (rtrim(cprinom) + SPACE(1) + rtrim(csegnom)) as cnombres, " & _
                               " (rtrim(cpriape) + SPACE(1) + rtrim(csegape))  as capellidos, 'ACTIVO' as cestado " & _
                                " from Climide " & _
                                " Where cnudoci like '%" & pcdescri & "%'"
                    Case Else   'Número de Socio
                        _sql = _
                                " Select top 600 ccodcli, ltrim(rtrim(cnomcli)) as cnomcli, cnudoci, (rtrim(cprinom) + SPACE(1) + rtrim(csegnom)) as cnombres, " & _
                                " (rtrim(cpriape) + SPACE(1) + rtrim(csegape))  as capellidos, 'ACTIVO' as cestado " & _
                                " from Climide " & _
                                " Where ccodcli like '%" & pcdescri & "%'"
                End Select




                command.CommandText = _
                                        _sql


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Parentesco")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function



    Public Function Mantenimiento_Clientes(ByVal Detalle_Cta As ArrayList, ByVal dt_ben As DataTable, _
                                           ByVal dt_firm As DataTable, ByVal dt_benAport As DataTable, _
                                           ByVal dt_Ref As DataTable) As String


        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Ofi As New DataSet
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcCtas_Aho As String
        Dim ccrefun As New dbCntamov
        Dim lnlibreta As Integer = 0
        Dim lccodcli As String = ""

        'Detalle_Cta.Item(0)    'Codigo Socio
        'Detalle_Cta.Item(1)    'Codigo Socio Manual
        'Detalle_Cta.Item(2)    'Primer Apellido
        'Detalle_Cta.Item(3)    'Segundo Apellido
        'Detalle_Cta.Item(4)    'Primer Nombre
        'Detalle_Cta.Item(5)    'Segundo Nombre
        'Detalle_Cta.Item(6)    'Nombre Completo
        'Detalle_Cta.Item(7)    'Nombre Segun NIT
        'Detalle_Cta.Item(8)    'Direccion Asociado 
        'Detalle_Cta.Item(9)    'Telefono Domicilio
        'Detalle_Cta.Item(10)   'Numero de Celular
        'Detalle_Cta.Item(11)   'Fecha de Nacimiento
        'Detalle_Cta.Item(12)   'Numero de CUPR
        'Detalle_Cta.Item(13)   'Numero de RFC
        'Detalle_Cta.Item(14)   'Genero
        'Detalle_Cta.Item(15)   'Profesion
        'Detalle_Cta.Item(16)   'Estado Civil
        'Detalle_Cta.Item(17)   'Estado Nacimiento
        'Detalle_Cta.Item(18)   'Estado Domicilio
        'Detalle_Cta.Item(19)   'Municipio Domicilio
        'Detalle_Cta.Item(20)   'No IFE
        'Detalle_Cta.Item(21)   'No de Hijos
        'Detalle_Cta.Item(22)   'No Dependientes

        'Nuevos Campos
        'Detalle_Cta.Item(23)   'Codigo Postal
        'Detalle_Cta.Item(24)   'Nombre de la Calle
        'Detalle_Cta.Item(25)   'No Exterior    
        'Detalle_Cta.Item(26)   'No Interior
        'Detalle_Cta.Item(27)   'Correo Electronico
        'Detalle_Cta.Item(28)   'Usuario Facebook
        'Detalle_Cta.Item(29)   'Latitud
        'Detalle_Cta.Item(30)   'Longitud

        'Detalle_Cta.Item(31)   'Otro Telefono
        'Detalle_Cta.Item(32)   'Condicion de la vivienda
        'Detalle_Cta.Item(33)   'Otro
        'Detalle_Cta.Item(34)   'Paredes
        'Detalle_Cta.Item(35)   'Piso
        'Detalle_Cta.Item(36)   'Techo
        'Detalle_Cta.Item(37)   'Servicios
        'Detalle_Cta.Item(38)   'Otro1
        'Detalle_Cta.Item(39)   'Otro2
        'Detalle_Cta.Item(40)   'Otro3
        'Detalle_Cta.Item(41)   'Otro4
        'Detalle_Cta.Item(42)   'Dueño
        'Detalle_Cta.Item(43)   'Valor Aproximado
        'Detalle_Cta.Item(44)   'Años de residir

        'Detalle_Cta.Item(45)   'Oficina
        'Detalle_Cta.Item(46)   'Fecha de Modificación
        'Detalle_Cta.Item(47)   'Usuario

        'Otros
        'Detalle_Cta.Item(48)   'Etnia
        'Detalle_Cta.Item(49)   'Grupo Etnico
        'Detalle_Cta.Item(50)   'idomas que domina
        'Detalle_Cta.Item(51)   'Escolaridad
        'Detalle_Cta.Item(52)   'Grado
        'Detalle_Cta.Item(53)   'Sabe Leer
        'Detalle_Cta.Item(54)   'Sabe firmar
        'Detalle_Cta.Item(55)   'Adicionales
        'Detalle_Cta.Item(56)   'Sabe escribir

        'Datos del Conyuge
        'Detalle_Cta.Item(57)   'Nombre del Coyuge   
        'Detalle_Cta.Item(58)   'Fecha de Nacimiento Cinyuge
        'Detalle_Cta.Item(59)   'No CURP conyuge 
        'Detalle_Cta.Item(60)   'Genero Conyuge
        'Detalle_Cta.Item(61)   'Profesion Conyuge
        'Detalle_Cta.Item(62)   'Sabe Leer y escribir
        'Detalle_Cta.Item(63)   'Id Conyuge
        'Detalle_Cta.Item(64)   'Condicion de la vivienda
        'Detalle_Cta.Item(65)   'Apellido de Casada
        'Detalle_Cta.Item(66)   'Tipo de Zona
        'Detalle_Cta.Item(67)   'Parentesco
        'Detalle_Cta.Item(68)   'Colonia
        'Detalle_Cta.Item(69)   'Municipio de nacimiento

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try



                'Inserta en Maestra de Clientes
                If Detalle_Cta.Item(0).ToString.Trim.Length = 0 Then 'Vefica si es Asociado Nuevo



                    command.CommandText = _
                                            " SELECT isnull(max(substring(ccodcli,4,9))+1,1) as correlativo FROM climide " & _
                                            " Where left(ccodcli,3) ='" & Detalle_Cta.Item(45) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Ofi, "Clientes")


                    For Each fila As DataRow In ds_Ofi.Tables("Clientes").Rows
                        lccodcli = fila("correlativo").ToString.Trim
                    Next

                    i = Double.Parse(lccodcli)

                    lccodcli = ccrefun.fxStrZero(i, 9)

                    Detalle_Cta.Item(1) = Detalle_Cta.Item(45) & lccodcli



                    ds_Ofi.Tables.Clear()

                    command.CommandText = _
                                            " Insert into climide (ccodcli,cclaper, cnomcli, cnomcor, dnacimi, cnudoci, cnudotr, csexo, cestciv, cCodpro, cCodDom, cDirDom, " & _
                                            " cTelDom, cNomCon, dfCony, cduiCony, cSexCon, cCodOfi, cProfCon, ctelfam, lsegvida, cfirma, cetnia, " & _
                                            " cnivel, cadicional, cconviv, ccodsol, clugexp, nsabeesc, npercar, ctidoci, csegnom, cternom, cpriape, csegape, " & _
                                            " capecasada, cleer, cescribir, cfirmar, cotrtel, cgrado, nhijos, clocalidad, cgruetnico, cidiomas, cprinom, " & _
                                            " ctipocondic, cparedes, cparedcondic, cpiso, cpisocondic, ctecho, ctechocondic, cservicios, csercondic, cnomdño,  " & _
                                            " nvalor, nanodom, cgrusan, ccodcon, ccodusu,  id_codigo_postal, dfecmod, id_ife, ccalle, cnoext, cnoint, " & _
                                            " ccorreo, usuface, latitud, longitud) " & _
                                            " Values('" & Detalle_Cta.Item(1) & "','1','" & Detalle_Cta.Item(6) & "','" & Detalle_Cta.Item(6) & "','" & _
                                            Detalle_Cta.Item(11) & "','" & Detalle_Cta.Item(12) & "','" & Detalle_Cta.Item(13) & "','" & Detalle_Cta.Item(14) & "','" & Detalle_Cta.Item(16) & "','" & _
                                            Detalle_Cta.Item(15) & "','" & Detalle_Cta.Item(68) & "','" & Detalle_Cta.Item(8) & "','" & Detalle_Cta.Item(9) & "','" & Detalle_Cta.Item(57) & "','" & Detalle_Cta.Item(58) & "','" & _
                                            Detalle_Cta.Item(59) & "','" & Detalle_Cta.Item(60) & "','" & Detalle_Cta.Item(45) & "','" & Detalle_Cta.Item(61) & "','" & Detalle_Cta.Item(10) & "',0,1,'" & _
                                            Detalle_Cta.Item(48) & "','" & Detalle_Cta.Item(51) & "','" & Detalle_Cta.Item(55) & "','" & Detalle_Cta.Item(64) & "','','" & _
                                            Detalle_Cta.Item(69) & "','1','" & Detalle_Cta.Item(22) & "','2','" & Detalle_Cta.Item(5) & "','','" & Detalle_Cta.Item(2) & "','" & Detalle_Cta.Item(3) & "','" & _
                                            Detalle_Cta.Item(65) & "','" & Detalle_Cta.Item(53) & "','" & Detalle_Cta.Item(56) & "','" & Detalle_Cta.Item(54) & "','','" & _
                                            Detalle_Cta.Item(31) & "','" & Detalle_Cta.Item(52) & "'," & Detalle_Cta.Item(21) & ",'" & Detalle_Cta.Item(66) & "','','" & _
                                            Detalle_Cta.Item(4) & "','','','" & Detalle_Cta.Item(33) & "','','" & _
                                            Detalle_Cta.Item(38) & "','" & Detalle_Cta.Item(35) & "','" & Detalle_Cta.Item(34) & "','" & Detalle_Cta.Item(37) & "','','" & _
                                            Detalle_Cta.Item(42) & "'," & Detalle_Cta.Item(43) & "," & Detalle_Cta.Item(44) & ",'','" & _
                                            Detalle_Cta.Item(67) & "','" & Detalle_Cta.Item(47) & "','" & Detalle_Cta.Item(23) & "',getdate(),'" & Detalle_Cta.Item(20) & "','" & _
                                            Detalle_Cta.Item(24) & "','" & Detalle_Cta.Item(25) & "','" & Detalle_Cta.Item(26) & "','" & Detalle_Cta.Item(27) & "','" & _
                                            Detalle_Cta.Item(28) & "','" & Detalle_Cta.Item(29) & "','" & Detalle_Cta.Item(30) & "')"
                   

                    command.ExecuteNonQuery()


                    lccodcli = Detalle_Cta.Item(1)

                    'Primero valida el numero de Libreta

                    '' Extrae numero de Libreta
                    'command.CommandText = _
                    '                        " Select ccodofi, ndesde, nhasta, nlibreta from libretas_agencia " & _
                    '                        " Where cestado = '01' and ccodofi = '" & Detalle_Cta.Item(31) & "'"


                    'command.CommandType = CommandType.Text

                    'MyAdapter.SelectCommand = command

                    'MyAdapter.Fill(ds_Ofi, "No_Libreta")


                    'If ds_Ofi.Tables("No_Libreta").Rows.Count = 0 Then
                    '    lnRetorno = 2
                    'End If

                    'For Each fila As DataRow In ds_Ofi.Tables("No_Libreta").Rows
                    '    lnlibreta = fila("nlibreta") + 1
                    '    Detalle_Cta.Item(4) = lnlibreta

                    '    If lnlibreta > fila("nhasta") Then
                    '        lnRetorno = 2
                    '    End If
                    'Next


                    'If lnRetorno = 2 And Detalle_Cta.Item(2).ToString.Trim.Length = 0 Then
                    '    Return lnRetorno
                    'End If


                    '* Primero Genera CTA. CONCENTRADORA                      

                    command.CommandText = _
                                            " Select isnull(max(RIGHT(CCODAHO,6))+1,1) as Contador From Ahomcta " & _
                                            " Where substring(ahomcta.ccodaho,7,2) = '01' and SUBSTRING(ccodaho,4,3) ='" & Detalle_Cta.Item(45) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Ofi, "Ctas_Ahorro")


                    For Each fila As DataRow In ds_Ofi.Tables("Ctas_Ahorro").Rows
                        lcCtas_Aho = fila("contador").ToString.Trim
                    Next

                    i = Double.Parse(lcCtas_Aho)

                    lcCtas_Aho = ccrefun.fxStrZero(i, 6)

                    lcCtas_Aho = "001" & Detalle_Cta.Item(45) & "01" + lcCtas_Aho



                    command.CommandText = _
                                            " Insert Into Ahomcta (ccodaho, cnrolin, ccodcta, cnudotr, nlibreta, " & _
                                            " cestado, cbloqueo, dfecini, dfecapr, dfecult, dfecmod, ccodusu, ncorrel, " & _
                                            " nnum, llave, nombre, apellido, nsaldoaho, nmonini," & _
                                            " nmonapr, nsaldnind, nmonres, producto, dfeccap, dultmov, dfechault, dfecfin) " & _
                                            " Values('" & lcCtas_Aho & "','0000100','','" & Detalle_Cta.Item(1) & "',1," & _
                                            " 'A','','" & Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "',getdate(),'" & Detalle_Cta.Item(33) & "',0," & _
                                            " 0,0,'" & Detalle_Cta.Item(4) + " " + Detalle_Cta.Item(5) & "','" & Detalle_Cta.Item(2) + " " + Detalle_Cta.Item(3) & "',0,0," & _
                                            " 0,0,0,'01','" & Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "','" & _
                                            Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "')"


                    command.ExecuteNonQuery()

                    'Fin Generación cta. Aportaciones


                    '* Inserta Beneficiarios de Aportaciones

                    'Borra Beneficiarios de las Aportaciones si Existen
                    command.CommandText = _
                                            " Delete from Ahomben " & _
                                            " Where ccodaho ='" & lcCtas_Aho & "'"

                    command.ExecuteNonQuery()

                    'Inserta Beneficiarios de la Cuenta
                    For Each fila As DataRow In dt_benAport.Rows
                        command.CommandText = _
                                                " Insert into Ahomben (ccodaho,ncorrel,cnomben,cparent,dfecnac,nporcen,dfecmod,ccodusu,cdirben,ccodcli) " & _
                                                " values('" & lcCtas_Aho & "'," & fila("IdCuenta") & ",'" & fila("cNomBen").ToString.Trim & "','" & _
                                                fila("cParent") & "','" & fila("dnacimi") & "'," & fila("nPorcen") & ",getdate(),'" & _
                                                Detalle_Cta.Item(33) & "','" & fila("cdirecc") & "','" & Detalle_Cta.Item(1) & "')"

                        command.ExecuteNonQuery()
                    Next


                    'Inserta Correlativo de Libreta
                    command.CommandText = _
                                           " Insert into Ahomlib (ccodaho, nlibreta, cestado, dfeccan, crazon, dfecapr, dfecmod, ccodusu) " & _
                                           " values('" & lcCtas_Aho & "'," & lnlibreta & ",'A','" & Detalle_Cta.Item(46) & "','1','" & _
                                           Detalle_Cta.Item(46) & "', getdate(),'" & Detalle_Cta.Item(33) & "')"

                    command.ExecuteNonQuery()



                    '* Segundo Genera Cuenta de Garantia Liquida
                    If ds_Ofi.Tables.Count > 0 Then
                        ds_Ofi.Clear()
                    End If


                    command.CommandText = _
                                            " Select isnull(max(RIGHT(CCODAHO,6))+1,1) as Contador From Ahomcta " & _
                                            " Where substring(ahomcta.ccodaho,7,2) = '02' and SUBSTRING(ccodaho,4,3) ='" & Detalle_Cta.Item(45) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Ofi, "Ctas_Ahorro")


                    For Each fila As DataRow In ds_Ofi.Tables("Ctas_Ahorro").Rows
                        lcCtas_Aho = fila("contador").ToString.Trim
                    Next

                    i = Double.Parse(lcCtas_Aho)

                    lcCtas_Aho = ccrefun.fxStrZero(i, 6)

                    lcCtas_Aho = "001" & Detalle_Cta.Item(45) & "02" + lcCtas_Aho


                    command.CommandText = _
                                           " Insert Into Ahomcta (ccodaho, cnrolin, ccodcta, cnudotr, nlibreta, " & _
                                           " cestado, cbloqueo, dfecini, dfecapr, dfecult, dfecmod, ccodusu, ncorrel, " & _
                                           " nnum, llave, nombre, apellido, nsaldoaho, nmonini," & _
                                           " nmonapr, nsaldnind, nmonres, producto, dfeccap, dultmov, dfechault, dfecfin) " & _
                                           " Values('" & lcCtas_Aho & "','0000200','','" & Detalle_Cta.Item(1) & "',1," & _
                                           " 'A','','" & Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "',getdate(),'" & Detalle_Cta.Item(33) & "',0," & _
                                           " 0,0,'" & Detalle_Cta.Item(4) + " " + Detalle_Cta.Item(5) & "','" & Detalle_Cta.Item(2) + " " + Detalle_Cta.Item(3) & "',0,0," & _
                                           " 0,0,0,'02','" & Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "','" & _
                                           Detalle_Cta.Item(46) & "','" & Detalle_Cta.Item(46) & "')"

                    command.ExecuteNonQuery()


                    '* Inserta Beneficiarios de Ahorro Corriente

                    'Borra Beneficiarios de Ahorro Corriente si Existen
                    command.CommandText = _
                                            " Delete from Ahomben " & _
                                            " Where ccodaho ='" & lcCtas_Aho & "'"

                    command.ExecuteNonQuery()

                    'Inserta Beneficiarios de la Cuenta
                    For Each fila As DataRow In dt_ben.Rows
                        command.CommandText = _
                                                " Insert into Ahomben (ccodaho,ncorrel,cnomben,cparent,dfecnac,nporcen,dfecmod,ccodusu,cdirben,ccodcli) " & _
                                                " values('" & lcCtas_Aho & "'," & fila("IdCuenta") & ",'" & fila("cNomBen").ToString.Trim & "','" & _
                                                fila("cParent") & "','" & fila("dnacimi") & "'," & fila("nPorcen") & ",getdate(),'" & _
                                                Detalle_Cta.Item(33) & "','" & fila("cdirecc") & "','" & Detalle_Cta.Item(1) & "')"

                        command.ExecuteNonQuery()
                    Next


                    'Actualiza el numero de libreta
                    command.CommandText = _
                                            " Update libretas_agencia set nlibreta = nlibreta + 2, dfecmod =getdate(), ccodusu ='" & Detalle_Cta.Item(33) & "'" & _
                                            " Where cestado = '01' and ccodofi = '" & Detalle_Cta.Item(31) & "'"

                    command.ExecuteNonQuery()

                    lnlibreta += 1

                    'Inserta Correlativo de Libreta
                    command.CommandText = _
                                           " Insert into Ahomlib (ccodaho, nlibreta, cestado, dfeccan, crazon, dfecapr, dfecmod, ccodusu) " & _
                                           " values('" & lcCtas_Aho & "'," & lnlibreta & ",'A','" & Detalle_Cta.Item(46) & "','1','" & _
                                           Detalle_Cta.Item(46) & "', getdate(),'" & Detalle_Cta.Item(33) & "')"

                    command.ExecuteNonQuery()



                    'Borra Firmas si Existen
                    command.CommandText = _
                                             " Delete from Ahomfir " & _
                                             " Where ccodaho ='" & lcCtas_Aho & "'"

                    command.ExecuteNonQuery()

                    'Inserta Firmas
                    For Each fila As DataRow In dt_firm.Rows

                        command.CommandText = _
                                                " Insert into Ahomfir (ccodaho, nlibreta, nmanco, cnomau, cnomgfir, dnacgfir, cdui, ccodusu, dfecmod, id) " & _
                                                " values('" & lcCtas_Aho & "',1,0,'','" & _
                                                fila("cNomFir").ToString.Trim & "','" & fila("dnacimi") & "','" & fila("cnudoci") & "','" & _
                                                Detalle_Cta.Item(33) & "',getdate()," & fila("IdCuenta") & ")"

                        command.ExecuteNonQuery()

                    Next


                    ''Borra Beneficiarios si Existen
                    'command.CommandText = _
                    '                        " Delete from Ahomben " & _
                    '                        " Where ccodaho ='" & Detalle_Cta.Item(2) & "'"

                    'command.ExecuteNonQuery()

                    ''Inserta Beneficiarios de la Cuenta
                    'For Each fila As DataRow In dt_ben.Rows
                    '    command.CommandText = _
                    '                            " Insert into Ahomben (ccodaho,ncorrel,cnomben,cparent,dfecnac,nporcen,dfecmod,ccodusu,cdirben,ccodcli) " & _
                    '                            " values('" & Detalle_Cta.Item(2) & "'," & fila("IdCuenta") & ",'" & fila("cNomBen").ToString.Trim & "','" & _
                    '                            fila("cParent") & "','" & fila("dnacimi") & "'," & fila("nPorcen") & ",getdate(),'" & _
                    '                            Detalle_Cta.Item(9) & "','" & fila("cdirecc") & "','" & Detalle_Cta.Item(1) & "')"

                    '    command.ExecuteNonQuery()
                    'Next


                    'Finaliza tratamiento de Ahorro Corriente


                    '* Referencias Personales

                    'Borra Referencias si Existen
                    'command.CommandText = _
                    '                         " Delete from Referencias" & _
                    '                         " Where ccodcli ='" & Detalle_Cta.Item(1) & "'"

                    'command.ExecuteNonQuery()


                    ' Inserta Referencias Personales
                    For Each fila As DataRow In dt_Ref.Rows
                        command.CommandText = _
                                                " Insert into Referencias (ccodcli, cnomref, cdirdom, ctelefono, cteltra, cParent, cflc) " & _
                                                " values('" & Detalle_Cta.Item(1) & "','" & fila("cNomRef") & "','" & fila("cDirecc") & "','" & _
                                                fila("ctelefono") & "','','" & fila("cParent") & "','" & fila("IdCuenta") & "')"
                        command.ExecuteNonQuery()
                    Next


                Else      'Actualiza Datos del Asociado

                    command.CommandText = _
                                           " Update climide set cnomcli='" & Detalle_Cta.Item(4) & "', cnomcor ='" & Detalle_Cta.Item(4) & "'," & _
                                           " dnacimi ='" & Detalle_Cta.Item(9) & "', csexo ='" & Detalle_Cta.Item(12) & "', clugnac ='" & Detalle_Cta.Item(15) & "'," & _
                                           " cnudoci ='" & Detalle_Cta.Item(10) & "', cnudotr ='" & Detalle_Cta.Item(11) & "', ccodpro ='" & Detalle_Cta.Item(13) & "'," & _
                                           " ccoddom ='" & Detalle_Cta.Item(16) & "', cdirdom ='" & Detalle_Cta.Item(6) & "', cteldom ='" & Detalle_Cta.Item(7) & "'," & _
                                           " cnomcon ='" & Detalle_Cta.Item(22) & "' ,cnombres ='" & Detalle_Cta.Item(2) & "', capellidos ='" & Detalle_Cta.Item(3) & "'," & _
                                           " ccodprodui ='" & Detalle_Cta.Item(13) & "',ccodtray ='" & Detalle_Cta.Item(19) & "', nsuetray =" & Detalle_Cta.Item(28) & "," & _
                                           " cdomtra ='" & Detalle_Cta.Item(20) & "', cteltralab ='" & Detalle_Cta.Item(21) & "',ctelfam ='" & Detalle_Cta.Item(8) & "'," & _
                                           " cestciv ='" & Detalle_Cta.Item(14) & "',dfCony ='" & Detalle_Cta.Item(23) & "',cDuiCony ='" & Detalle_Cta.Item(24) & "'," & _
                                           " cnitcon ='" & Detalle_Cta.Item(25) & "', cProfCon ='" & Detalle_Cta.Item(26) & "', nsueldcon=" & Detalle_Cta.Item(27) & "," & _
                                           " nOtrIn =" & Detalle_Cta.Item(29) & ", nGasMen =" & Detalle_Cta.Item(30) & "," & _
                                           " dfchExp ='" & Detalle_Cta.Item(17) & "', clugExp ='" & Detalle_Cta.Item(18) & "'," & _
                                           " ccodusu ='" & Detalle_Cta.Item(33) & "', dfecmod=getdate()," & _
                                           " ccorreo ='" & Detalle_Cta.Item(35) & "', nyearcasa =" & Detalle_Cta.Item(38) & ", cconviv ='" & Detalle_Cta.Item(46) & "'," & _
                                           " clugartray ='" & Detalle_Cta.Item(41) & "', cdomtray ='" & Detalle_Cta.Item(42) & "', npercar =" & Detalle_Cta.Item(37) & "," & _
                                           " nMonRem =" & Detalle_Cta.Item(43) & ", nMonR =" & Detalle_Cta.Item(44) & ", nProMenR =" & Detalle_Cta.Item(45) & "," & _
                                           " ccargo ='" & Detalle_Cta.Item(39) & "', cjefe ='" & Detalle_Cta.Item(40) & "', ctiempo =" & Detalle_Cta.Item(36) & _
                                           " Where cCodcli = '" & Detalle_Cta.Item(0) & "'"

                    command.ExecuteNonQuery()


                    '* Actualiza Referencias Personales

                    'Borra Referencias si Existen
                    command.CommandText = _
                                             " Delete from Referencias" & _
                                             " Where ccodcli ='" & Detalle_Cta.Item(0) & "'"

                    command.ExecuteNonQuery()


                    ' Inserta Referencias Personales
                    For Each fila As DataRow In dt_Ref.Rows
                        command.CommandText = _
                                                " Insert into Referencias (ccodcli, cnomref, cdirdom, ctelefono, cteltra, cParent, cflc) " & _
                                                " values('" & Detalle_Cta.Item(0) & "','" & fila("cNomRef") & "','" & fila("cDirecc") & "','" & _
                                                fila("ctelefono") & "','','" & fila("cParent") & "','" & fila("IdCuenta") & "')"
                        command.ExecuteNonQuery()
                    Next


                End If


                lnRetorno = 1
                Mytransaccion.Commit()

            Catch ex As Exception
                lccodcli = ""
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
                Mytransaccion.Rollback()
            Finally
                connection.Close()
            End Try

        End Using


        Return lccodcli

    End Function

    Public Function ValidarRangoProducto(ByVal pcCodCta As String) As DataSet

        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter

        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)

            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "sp_DatosCretlin"

                MyParameters = _
                                MyCommand.Parameters.Add("@pcCodCta", SqlDbType.VarChar)
                MyParameters.Value = pcCodCta
                MyParameters.Direction = ParameterDirection.Input


                MyCommand.CommandType = CommandType.StoredProcedure

                MyCommand.CommandType = CommandType.StoredProcedure
                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds, "Cretlin")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        Return Ds
    End Function

    Public Function ObtenerSolicitudesAbiertas(ByVal ccodcli As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT cremsol.cnomgru , cremsol.ccodsol, ")
        strSQL.Append(" CASE cremcre.cestado  WHEN 'C' THEN 'SUGERIDO'")
        strSQL.Append(" WHEN 'F' THEN 'VIGENTE'")
        strSQL.Append(" WHEN 'E' THEN 'AUTORIZADO'")
        strSQL.Append(" ELSE 'Estado no identificado'  End, CAST(dfecsol as date) from cremsol")
        strSQL.Append(" INNER JOIN cremcre on cremsol.cCodsol = cremcre.ccodsol")
        strSQL.Append(" AND cremcre.cestado NOT IN ( 'G' ) and cremcre.ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function ObtenerIntencionesCredito(ByVal ccodcli As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT cremsol.cnomgru , cremsol.ccodsol, ")
        strSQL.Append(" CASE cremcre.cestado  WHEN 'C' THEN 'SUGERIDO'")
        strSQL.Append(" WHEN 'F' THEN 'VIGENTE'")
        strSQL.Append(" WHEN 'E' THEN 'AUTORIZADO'")
        strSQL.Append(" ELSE 'Estado no identificado'  End, CAST(dfecsol as date) from cremsol")
        strSQL.Append(" INNER JOIN cremcre on cremsol.cCodsol = cremcre.ccodsol")
        strSQL.Append(" AND cremcre.cestado NOT IN ( 'G' ) and cremcre.ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
End Class
