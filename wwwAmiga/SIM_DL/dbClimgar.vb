Imports System.Text
Public Class dbClimgar
    Inherits dbBase
    Public Overridable Function ExecuteDataSet(ByVal connectionString As String, _
                           ByVal commandType As CommandType, _
                           ByVal commandText As String, _
                           ByVal params As SqlParameter(), _
                           ByVal commandTimeout As Integer) As DataSet
        Dim adapter As New SqlDataAdapter(commandText, connectionString)

        With adapter.SelectCommand
            .CommandType = commandType
            .CommandTimeout = commandTimeout
            .Parameters.AddRange(params)
        End With

        Dim data As New DataSet

        adapter.Fill(data)
        adapter.SelectCommand.Dispose()

        Return data
    End Function
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climgar
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE climgar ")
        strSQL.Append(" SET destado = @destado, ")
        strSQL.Append(" ctipdes = @ctipdes, ") 
        strSQL.Append(" ccoduni = @ccoduni, ") 
        strSQL.Append(" ctipgar = @ctipgar, ") 
        strSQL.Append(" cdescri = @cdescri, ")
        strSQL.Append(" cmoneda = @cmoneda, ") 
        strSQL.Append(" nmongar = @nmongar, ") 
        strSQL.Append(" nmontas = @nmontas, ")
        strSQL.Append(" ccodusu = @ccodusu, nmongra = @nmongra, ")
        strSQL.Append(" dfecmod = @dfecmod, cnotario = @cnotario, nnumeropr = @nnumeropr, dfechaes = @dfechaes, clugares =@clugares, ")
        strSQL.Append(" cpropietario = @cpropietario, ")
        strSQL.Append(" cprofinca = @cprofinca, ")
        strSQL.Append(" cprofolio = @cprofolio, ")
        strSQL.Append(" cprolibro = @cprolibro, ")
        strSQL.Append(" cprode = @cprode, ")
        strSQL.Append(" dprofecha = @dprofecha, ")
        strSQL.Append(" cmunfinca = @cmunfinca, ")
        strSQL.Append(" cmunfolio = @cmunfolio, ")
        strSQL.Append(" cmunlibro = @cmunlibro, ")
        strSQL.Append(" cmunde = @cmunde, ")
        strSQL.Append(" dmunfecha = @dmunfecha, ")
        strSQL.Append(" cdireccion = @cdireccion, ")
        strSQL.Append(" ctopo = @ctopo, ")
        strSQL.Append(" cespdir = @cespdir, ")
        strSQL.Append(" cuso = @cuso, ")
        strSQL.Append(" cespuso = @cespuso, ")
        strSQL.Append(" clocalidad = @clocalidad, ")
        strSQL.Append(" nniveles = @nniveles, ")
        strSQL.Append(" cacceso = @cacceso, ")
        strSQL.Append(" cservicios = @cservicios, ")
        strSQL.Append(" cespser = @cespser, ")
        strSQL.Append(" cambientes = @cambientes, ")
        strSQL.Append(" cespamb = @cespamb, ")
        strSQL.Append(" ctecho = @ctecho, ")
        strSQL.Append(" cesptecho = @cesptecho, ")
        strSQL.Append(" cpiso = @cpiso, ")
        strSQL.Append(" cesppiso = @cesppiso, ")
        strSQL.Append(" cparedes = @cparedes, ")
        strSQL.Append(" cesppared = @cesppared, ")
        strSQL.Append(" nnmedida = @nnmedida, ")
        strSQL.Append(" nncolin = @nncolin, ")
        strSQL.Append(" nsmedida = @nsmedida, ")
        strSQL.Append(" nscolin = @nscolin, ")
        strSQL.Append(" nemedida = @nemedida, ")
        strSQL.Append(" necolin = @necolin, ")
        strSQL.Append(" nomedida = @nomedida, ")
        strSQL.Append(" nocolin = @nocolin, ")
        strSQL.Append(" nlongitud = @nlongitud, ")
        strSQL.Append(" nlatitud = @nlatitud, cubica = @cubica ")
        strSQL.Append(" WHERE ccodcli = @ccodcli  ")
        strSQL.Append(" AND ccodgar = @ccodgar ") 

        Dim args(69) As SqlParameter
        args(0) = New SqlParameter("@destado", SqlDbType.DateTime)
        args(0).Value = lEntidad.destado
        args(1) = New SqlParameter("@ctipdes", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipdes
        args(2) = New SqlParameter("@ccoduni", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccoduni
        args(3) = New SqlParameter("@ctipgar", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipgar
        args(4) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdescri
        args(5) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(5).Value = lEntidad.cmoneda
        args(6) = New SqlParameter("@nmongar", SqlDbType.Decimal)
        args(6).Value = lEntidad.nmongar
        args(7) = New SqlParameter("@nmontas", SqlDbType.Decimal)
        args(7).Value = lEntidad.nmontas
        args(8) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodusu
        args(9) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(9).Value = lEntidad.dfecmod
        args(10) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(11) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value, lEntidad.ccodgar)
        args(12) = New SqlParameter("@cnotario", SqlDbType.VarChar)
        args(12).Value = lEntidad.cnotario
        args(13) = New SqlParameter("@nnumeropr", SqlDbType.VarChar)
        args(13).Value = lEntidad.nnumeropr
        args(14) = New SqlParameter("@dfechaes", SqlDbType.DateTime)
        args(14).Value = lEntidad.dfechaes
        args(15) = New SqlParameter("@clugares", SqlDbType.VarChar)
        args(15).Value = lEntidad.clugares
        args(16) = New SqlParameter("@nmongra", SqlDbType.Decimal)
        args(16).Value = lEntidad.nmongra
        args(17) = New SqlParameter("@ccoddep", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccoddep
        args(18) = New SqlParameter("@dfecval", SqlDbType.DateTime)
        args(18).Value = lEntidad.dfecval
        args(19) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(19).Value = lEntidad.cflag
        args(20) = New SqlParameter("@cubica", SqlDbType.VarChar)
        args(20).Value = lEntidad.cubica
        args(21) = New SqlParameter("@cdirec", SqlDbType.VarChar)
        args(21).Value = lEntidad.cdirec
        args(22) = New SqlParameter("@dpresent", SqlDbType.DateTime)
        args(22).Value = lEntidad.dpresent
        args(23) = New SqlParameter("@dinscrip", SqlDbType.DateTime)
        args(23).Value = lEntidad.dinscrip
        args(24) = New SqlParameter("@cnumins", SqlDbType.VarChar)
        args(24).Value = lEntidad.cnumins
        args(25) = New SqlParameter("@cnumpres", SqlDbType.VarChar)
        args(25).Value = lEntidad.cnumpres
        args(26) = New SqlParameter("@cobser", SqlDbType.VarChar)
        args(26).Value = lEntidad.cobser
        
        args(27) = New SqlParameter("@cpropietario", SqlDbType.VarChar)
        args(27).Value = lEntidad.cpropietario
        args(28) = New SqlParameter("@cprofinca", SqlDbType.VarChar)
        args(28).Value = lEntidad.cprofinca
        args(29) = New SqlParameter("@cprofolio", SqlDbType.VarChar)
        args(29).Value = lEntidad.cprofolio
        args(30) = New SqlParameter("@cprolibro", SqlDbType.VarChar)
        args(30).Value = lEntidad.cprolibro
        args(31) = New SqlParameter("@cprode", SqlDbType.VarChar)
        args(31).Value = lEntidad.cprode
        args(32) = New SqlParameter("@dprofecha", SqlDbType.DateTime)
        args(32).Value = lEntidad.dprofecha
        args(33) = New SqlParameter("@cmunfinca", SqlDbType.VarChar)
        args(33).Value = lEntidad.cmunfinca
        args(34) = New SqlParameter("@cmunfolio", SqlDbType.VarChar)
        args(34).Value = lEntidad.cmunfolio
        args(35) = New SqlParameter("@cmunlibro", SqlDbType.VarChar)
        args(35).Value = lEntidad.cmunlibro
        args(36) = New SqlParameter("@cmunde", SqlDbType.VarChar)
        args(36).Value = lEntidad.cmunde
        args(37) = New SqlParameter("@dmunfecha", SqlDbType.DateTime)
        args(37).Value = lEntidad.dmunfecha
        args(38) = New SqlParameter("@cdireccion", SqlDbType.VarChar)
        args(38).Value = lEntidad.cdireccion
        args(39) = New SqlParameter("@ctopo", SqlDbType.VarChar)
        args(39).Value = lEntidad.ctopo
        args(40) = New SqlParameter("@cespdir", SqlDbType.VarChar)
        args(40).Value = lEntidad.cespdir
        args(41) = New SqlParameter("@cuso", SqlDbType.VarChar)
        args(41).Value = lEntidad.cuso
        args(42) = New SqlParameter("@cespuso", SqlDbType.VarChar)
        args(42).Value = lEntidad.cespuso
        args(43) = New SqlParameter("@clocalidad", SqlDbType.VarChar)
        args(43).Value = lEntidad.clocalidad
        args(44) = New SqlParameter("@nniveles", SqlDbType.Int)
        args(44).Value = lEntidad.nniveles
        args(45) = New SqlParameter("@cacceso", SqlDbType.VarChar)
        args(45).Value = lEntidad.cacceso
        args(46) = New SqlParameter("@cservicios", SqlDbType.VarChar)
        args(46).Value = lEntidad.cservicios
        args(47) = New SqlParameter("@cespser", SqlDbType.VarChar)
        args(47).Value = lEntidad.cespser
        args(48) = New SqlParameter("@cambientes", SqlDbType.VarChar)
        args(48).Value = lEntidad.cambientes
        args(49) = New SqlParameter("@cespamb", SqlDbType.VarChar)
        args(49).Value = lEntidad.cespamb
        args(50) = New SqlParameter("@ctecho", SqlDbType.VarChar)
        args(50).Value = lEntidad.ctecho
        args(51) = New SqlParameter("@cesptecho", SqlDbType.VarChar)
        args(51).Value = lEntidad.cesptecho
        args(52) = New SqlParameter("@cpiso", SqlDbType.VarChar)
        args(52).Value = lEntidad.cpiso
        args(53) = New SqlParameter("@cesppiso", SqlDbType.VarChar)
        args(53).Value = lEntidad.cesppiso
        args(54) = New SqlParameter("@cparedes", SqlDbType.VarChar)
        args(54).Value = lEntidad.cparedes
        args(55) = New SqlParameter("@cesppared", SqlDbType.VarChar)
        args(55).Value = lEntidad.cesppared
        args(56) = New SqlParameter("@nnmedida", SqlDbType.Decimal)
        args(56).Value = lEntidad.nnmedida
        args(57) = New SqlParameter("@nncolin", SqlDbType.VarChar)
        args(57).Value = lEntidad.nncolin
        args(58) = New SqlParameter("@nsmedida", SqlDbType.Decimal)
        args(58).Value = lEntidad.nsmedida
        args(59) = New SqlParameter("@nscolin", SqlDbType.VarChar)
        args(59).Value = lEntidad.nscolin
        args(60) = New SqlParameter("@nemedida", SqlDbType.Decimal)
        args(60).Value = lEntidad.nemedida
        args(61) = New SqlParameter("@necolin", SqlDbType.VarChar)
        args(61).Value = lEntidad.necolin
        args(62) = New SqlParameter("@nomedida", SqlDbType.Decimal)
        args(62).Value = lEntidad.nomedida
        args(63) = New SqlParameter("@nocolin", SqlDbType.VarChar)
        args(63).Value = lEntidad.nocolin
        args(64) = New SqlParameter("@nlongitud", SqlDbType.Decimal)
        args(64).Value = lEntidad.nlongitud
        args(65) = New SqlParameter("@nlatitud", SqlDbType.Decimal)
        args(65).Value = lEntidad.nlatitud

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO climgar ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodgar, ")
        strSQL.Append(" destado, ") 
        strSQL.Append(" ctipdes, ") 
        strSQL.Append(" ccoduni, ") 
        strSQL.Append(" ctipgar, ") 
        strSQL.Append(" cdescri, ")
        strSQL.Append(" cmoneda, ") 
        strSQL.Append(" nmongar, ") 
        strSQL.Append(" nmontas, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" nMonGra, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" ccodzon, ")
        strSQL.Append(" csitgar, ")
        strSQL.Append(" dfecrev, ")
        strSQL.Append(" ccoddep, ")
        strSQL.Append(" dfecval, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cubica, ")
        strSQL.Append(" cdirec, ")
        strSQL.Append(" dpresent, ")
        strSQL.Append(" dinscrip, ")
        strSQL.Append(" cnumins, ")
        strSQL.Append(" cnumpres, ")
        strSQL.Append(" cobser, cnotario, nnumeropr, dfechaes, clugares, ")
        strSQL.Append(" cpropietario, ")
        strSQL.Append(" cprofinca, ")
        strSQL.Append(" cprofolio, ")
        strSQL.Append(" cprolibro, ")
        strSQL.Append(" cprode, ")
        strSQL.Append(" dprofecha, ")
        strSQL.Append(" cmunfinca, ")
        strSQL.Append(" cmunfolio, ")
        strSQL.Append(" cmunlibro, ")
        strSQL.Append(" cmunde, ")
        strSQL.Append(" dmunfecha, ")
        strSQL.Append(" cdireccion, ")
        strSQL.Append(" ctopo, ")
        strSQL.Append(" cespdir, ")
        strSQL.Append(" cuso, ")
        strSQL.Append(" cespuso, ")
        strSQL.Append(" clocalidad, ")
        strSQL.Append(" nniveles, ")
        strSQL.Append(" cacceso, ")
        strSQL.Append(" cservicios, ")
        strSQL.Append(" cespser, ")
        strSQL.Append(" cambientes, ")
        strSQL.Append(" cespamb, ")
        strSQL.Append(" ctecho, ")
        strSQL.Append(" cesptecho, ")
        strSQL.Append(" cpiso, ")
        strSQL.Append(" cesppiso, ")
        strSQL.Append(" cparedes, ")
        strSQL.Append(" cesppared, ")
        strSQL.Append(" nnmedida, ")
        strSQL.Append(" nncolin, ")
        strSQL.Append(" nsmedida, ")
        strSQL.Append(" nscolin, ")
        strSQL.Append(" nemedida, ")
        strSQL.Append(" necolin, ")
        strSQL.Append(" nomedida, ")
        strSQL.Append(" nocolin, ")
        strSQL.Append(" nlongitud, ")
        strSQL.Append(" nlatitud) ")

        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodgar, ")
        strSQL.Append(" @destado, ") 
        strSQL.Append(" @ctipdes, ") 
        strSQL.Append(" @ccoduni, ") 
        strSQL.Append(" @ctipgar, ") 
        strSQL.Append(" @cdescri, ")
        strSQL.Append(" @cmoneda, ") 
        strSQL.Append(" @nmongar, ") 
        strSQL.Append(" @nmontas, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @nmongra, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @cestado,  ")
        strSQL.Append(" @ccodzon, ")
        strSQL.Append(" @csitgar, ")
        strSQL.Append(" @dfecrev, ")
        strSQL.Append(" @ccoddep, ")
        strSQL.Append(" @dfecval, ")
        strSQL.Append(" @cflag, ")
        strSQL.Append(" @cubica, ")
        strSQL.Append(" @cdirec, ")
        strSQL.Append(" @dpresent, ")
        strSQL.Append(" @dinscrip, ")
        strSQL.Append(" @cnumins, ")
        strSQL.Append(" @cnumpres, ")
        strSQL.Append(" @cobser, @cnotario, @nnumeropr, @dfechaes, @clugares, ")
        strSQL.Append(" @cpropietario, ")
        strSQL.Append(" @cprofinca, ")
        strSQL.Append(" @cprofolio, ")
        strSQL.Append(" @cprolibro, ")
        strSQL.Append(" @cprode, ")
        strSQL.Append(" @dprofecha, ")
        strSQL.Append(" @cmunfinca, ")
        strSQL.Append(" @cmunfolio, ")
        strSQL.Append(" @cmunlibro, ")
        strSQL.Append(" @cmunde, ")
        strSQL.Append(" @dmunfecha, ")
        strSQL.Append(" @cdireccion, ")
        strSQL.Append(" @ctopo, ")
        strSQL.Append(" @cespdir, ")
        strSQL.Append(" @cuso, ")
        strSQL.Append(" @cespuso, ")
        strSQL.Append(" @clocalidad, ")
        strSQL.Append(" @nniveles, ")
        strSQL.Append(" @cacceso, ")
        strSQL.Append(" @cservicios, ")
        strSQL.Append(" @cespser, ")
        strSQL.Append(" @cambientes, ")
        strSQL.Append(" @cespamb, ")
        strSQL.Append(" @ctecho, ")
        strSQL.Append(" @cesptecho, ")
        strSQL.Append(" @cpiso, ")
        strSQL.Append(" @cesppiso, ")
        strSQL.Append(" @cparedes, ")
        strSQL.Append(" @cesppared, ")
        strSQL.Append(" @nnmedida, ")
        strSQL.Append(" @nncolin, ")
        strSQL.Append(" @nsmedida, ")
        strSQL.Append(" @nscolin, ")
        strSQL.Append(" @nemedida, ")
        strSQL.Append(" @necolin, ")
        strSQL.Append(" @nomedida, ")
        strSQL.Append(" @nocolin, ")
        strSQL.Append(" @nlongitud, ")
        strSQL.Append(" @nlatitud) ")

        Dim args(69) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value, lEntidad.ccodgar)
        args(2) = New SqlParameter("@destado", SqlDbType.DateTime)
        args(2).Value = lEntidad.destado
        args(3) = New SqlParameter("@ctipdes", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipdes
        args(4) = New SqlParameter("@ccoduni", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccoduni
        args(5) = New SqlParameter("@ctipgar", SqlDbType.VarChar)
        args(5).Value = lEntidad.ctipgar
        args(6) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(6).Value = lEntidad.cdescri
        args(7) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(7).Value = lEntidad.cmoneda
        args(8) = New SqlParameter("@nmongar", SqlDbType.Decimal)
        args(8).Value = lEntidad.nmongar
        args(9) = New SqlParameter("@nmontas", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmontas
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodusu
        args(11) = New SqlParameter("@nmongra", SqlDbType.Decimal)
        args(11).Value = lEntidad.nmongra
        args(12) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(12).Value = lEntidad.dfecmod
        args(13) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(13).Value = lEntidad.cestado
        args(14) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodzon
        args(15) = New SqlParameter("@csitgar", SqlDbType.VarChar)
        args(15).Value = lEntidad.csitgar
        args(16) = New SqlParameter("@dfecrev", SqlDbType.DateTime)
        args(16).Value = lEntidad.dfecrev
        args(17) = New SqlParameter("@ccoddep", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccoddep
        args(18) = New SqlParameter("@dfecval", SqlDbType.DateTime)
        args(18).Value = lEntidad.dfecval
        args(19) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(19).Value = lEntidad.cflag
        args(20) = New SqlParameter("@cubica", SqlDbType.VarChar)
        args(20).Value = lEntidad.cubica
        args(21) = New SqlParameter("@cdirec", SqlDbType.VarChar)
        args(21).Value = lEntidad.cdirec
        args(22) = New SqlParameter("@dpresent", SqlDbType.DateTime)
        args(22).Value = lEntidad.dpresent
        args(23) = New SqlParameter("@dinscrip", SqlDbType.DateTime)
        args(23).Value = lEntidad.dinscrip
        args(24) = New SqlParameter("@cnumins", SqlDbType.VarChar)
        args(24).Value = lEntidad.cnumins
        args(25) = New SqlParameter("@cnumpres", SqlDbType.VarChar)
        args(25).Value = lEntidad.cnumpres
        args(26) = New SqlParameter("@cobser", SqlDbType.VarChar)
        args(26).Value = lEntidad.cobser
        args(27) = New SqlParameter("@cnotario", SqlDbType.VarChar)
        args(27).Value = lEntidad.cnotario
        args(28) = New SqlParameter("@nnumeropr", SqlDbType.VarChar)
        args(28).Value = lEntidad.nnumeropr
        args(29) = New SqlParameter("@dfechaes", SqlDbType.DateTime)
        args(29).Value = lEntidad.dfechaes
        args(30) = New SqlParameter("@clugares", SqlDbType.VarChar)
        args(30).Value = lEntidad.clugares

        args(31) = New SqlParameter("@cpropietario", SqlDbType.VarChar)
        args(31).Value = lEntidad.cpropietario
        args(32) = New SqlParameter("@cprofinca", SqlDbType.VarChar)
        args(32).Value = lEntidad.cprofinca
        args(33) = New SqlParameter("@cprofolio", SqlDbType.VarChar)
        args(33).Value = lEntidad.cprofolio
        args(34) = New SqlParameter("@cprolibro", SqlDbType.VarChar)
        args(34).Value = lEntidad.cprolibro
        args(35) = New SqlParameter("@cprode", SqlDbType.VarChar)
        args(35).Value = lEntidad.cprode
        args(36) = New SqlParameter("@dprofecha", SqlDbType.DateTime)
        args(36).Value = lEntidad.dprofecha
        args(37) = New SqlParameter("@cmunfinca", SqlDbType.VarChar)
        args(37).Value = lEntidad.cmunfinca
        args(38) = New SqlParameter("@cmunfolio", SqlDbType.VarChar)
        args(38).Value = lEntidad.cmunfolio
        args(39) = New SqlParameter("@cmunlibro", SqlDbType.VarChar)
        args(39).Value = lEntidad.cmunlibro
        args(40) = New SqlParameter("@cmunde", SqlDbType.VarChar)
        args(40).Value = lEntidad.cmunde
        args(41) = New SqlParameter("@dmunfecha", SqlDbType.DateTime)
        args(41).Value = lEntidad.dmunfecha
        args(42) = New SqlParameter("@cdireccion", SqlDbType.VarChar)
        args(42).Value = lEntidad.cdireccion
        args(43) = New SqlParameter("@ctopo", SqlDbType.VarChar)
        args(43).Value = lEntidad.ctopo
        args(44) = New SqlParameter("@cespdir", SqlDbType.VarChar)
        args(44).Value = lEntidad.cespdir
        args(45) = New SqlParameter("@cuso", SqlDbType.VarChar)
        args(45).Value = lEntidad.cuso
        args(46) = New SqlParameter("@cespuso", SqlDbType.VarChar)
        args(46).Value = lEntidad.cespuso
        args(47) = New SqlParameter("@clocalidad", SqlDbType.VarChar)
        args(47).Value = lEntidad.clocalidad
        args(48) = New SqlParameter("@nniveles", SqlDbType.Int)
        args(48).Value = lEntidad.nniveles
        args(49) = New SqlParameter("@cacceso", SqlDbType.VarChar)
        args(49).Value = lEntidad.cacceso
        args(50) = New SqlParameter("@cservicios", SqlDbType.VarChar)
        args(50).Value = lEntidad.cservicios
        args(51) = New SqlParameter("@cespser", SqlDbType.VarChar)
        args(51).Value = lEntidad.cespser
        args(52) = New SqlParameter("@cambientes", SqlDbType.VarChar)
        args(52).Value = lEntidad.cambientes
        args(53) = New SqlParameter("@cespamb", SqlDbType.VarChar)
        args(53).Value = lEntidad.cespamb
        args(54) = New SqlParameter("@ctecho", SqlDbType.VarChar)
        args(54).Value = lEntidad.ctecho
        args(55) = New SqlParameter("@cesptecho", SqlDbType.VarChar)
        args(55).Value = lEntidad.cesptecho
        args(56) = New SqlParameter("@cpiso", SqlDbType.VarChar)
        args(56).Value = lEntidad.cpiso
        args(57) = New SqlParameter("@cesppiso", SqlDbType.VarChar)
        args(57).Value = lEntidad.cesppiso
        args(58) = New SqlParameter("@cparedes", SqlDbType.VarChar)
        args(58).Value = lEntidad.cparedes
        args(59) = New SqlParameter("@cesppared", SqlDbType.VarChar)
        args(59).Value = lEntidad.cesppared
        args(60) = New SqlParameter("@nnmedida", SqlDbType.Decimal)
        args(60).Value = lEntidad.nnmedida
        args(61) = New SqlParameter("@nncolin", SqlDbType.VarChar)
        args(61).Value = lEntidad.nncolin
        args(62) = New SqlParameter("@nsmedida", SqlDbType.Decimal)
        args(62).Value = lEntidad.nsmedida
        args(63) = New SqlParameter("@nscolin", SqlDbType.VarChar)
        args(63).Value = lEntidad.nscolin
        args(64) = New SqlParameter("@nemedida", SqlDbType.Decimal)
        args(64).Value = lEntidad.nemedida
        args(65) = New SqlParameter("@necolin", SqlDbType.VarChar)
        args(65).Value = lEntidad.necolin
        args(66) = New SqlParameter("@nomedida", SqlDbType.Decimal)
        args(66).Value = lEntidad.nomedida
        args(67) = New SqlParameter("@nocolin", SqlDbType.VarChar)
        args(67).Value = lEntidad.nocolin
        args(68) = New SqlParameter("@nlongitud", SqlDbType.Decimal)
        args(68).Value = lEntidad.nlongitud
        args(69) = New SqlParameter("@nlatitud", SqlDbType.Decimal)
        args(69).Value = lEntidad.nlatitud

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As climgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM climgar ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodgar = @ccodgar ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodgar

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodgar = @ccodgar ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodgar

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.destado = IIf(.Item("destado") Is DBNull.Value, Nothing, .Item("destado"))
                lEntidad.ctipdes = IIf(.Item("ctipdes") Is DBNull.Value, Nothing, .Item("ctipdes"))
                lEntidad.ccoduni = IIf(.Item("ccoduni") Is DBNull.Value, Nothing, .Item("ccoduni"))
                lEntidad.ctipgar = IIf(.Item("ctipgar") Is DBNull.Value, Nothing, .Item("ctipgar"))
                lEntidad.cdescri = IIf(.Item("cdescri") Is DBNull.Value, Nothing, .Item("cdescri"))
                lEntidad.ccodzon = IIf(.Item("ccodzon") Is DBNull.Value, Nothing, .Item("ccodzon"))
                lEntidad.cmoneda = IIf(.Item("cmoneda") Is DBNull.Value, Nothing, .Item("cmoneda"))
                lEntidad.nmongar = IIf(.Item("nmongar") Is DBNull.Value, Nothing, .Item("nmongar"))
                lEntidad.nmontas = IIf(.Item("nmontas") Is DBNull.Value, Nothing, .Item("nmontas"))
                lEntidad.nmongra = IIf(.Item("nmongra") Is DBNull.Value, Nothing, .Item("nmongra"))
                lEntidad.csitgar = IIf(.Item("csitgar") Is DBNull.Value, Nothing, .Item("csitgar"))
                lEntidad.dfecrev = IIf(.Item("dfecrev") Is DBNull.Value, Nothing, .Item("dfecrev"))
                lEntidad.ccoddep = IIf(.Item("ccoddep") Is DBNull.Value, Nothing, .Item("ccoddep"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cdirec = IIf(.Item("cdirec") Is DBNull.Value, Nothing, .Item("cdirec"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As climgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodgar),0) + 1 ")
        strSQL.Append(" FROM climgar ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ByVal ccodcli As String) As listaclimgar

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaclimgar

        Try
            Do While dr.Read()
                Dim mEntidad As New climgar
                mEntidad.ccodcli = ccodcli
                mEntidad.ccodgar = IIf(dr("ccodgar") Is DBNull.Value, Nothing, dr("ccodgar"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.destado = IIf(dr("destado") Is DBNull.Value, Nothing, dr("destado"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ccoduni = IIf(dr("ccoduni") Is DBNull.Value, Nothing, dr("ccoduni"))
                mEntidad.ctipgar = IIf(dr("ctipgar") Is DBNull.Value, Nothing, dr("ctipgar"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.ccodzon = IIf(dr("ccodzon") Is DBNull.Value, Nothing, dr("ccodzon"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.nmongar = IIf(dr("nmongar") Is DBNull.Value, Nothing, dr("nmongar"))
                mEntidad.nmontas = IIf(dr("nmontas") Is DBNull.Value, Nothing, dr("nmontas"))
                mEntidad.nmongra = IIf(dr("nmongra") Is DBNull.Value, Nothing, dr("nmongra"))
                mEntidad.csitgar = IIf(dr("csitgar") Is DBNull.Value, Nothing, dr("csitgar"))
                mEntidad.dfecrev = IIf(dr("dfecrev") Is DBNull.Value, Nothing, dr("dfecrev"))
                mEntidad.ccoddep = IIf(dr("ccoddep") Is DBNull.Value, Nothing, dr("ccoddep"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cdirec = IIf(dr("cdirec") Is DBNull.Value, Nothing, dr("cdirec"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim tables(0) As String
        tables(0) = New String("climgar")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcli, ")
        strSQL.Append(" ccodgar, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" destado, ")
        strSQL.Append(" rtrim(ctipdes) as ctipdes, ")
        strSQL.Append(" ccoduni, ")
        strSQL.Append(" rtrim(ctipgar) as ctipgar, ")
        strSQL.Append(" cdescri, ")
        strSQL.Append(" ccodzon, ")
        strSQL.Append(" rtrim(cmoneda) as cmoneda, ")
        strSQL.Append(" nmongar, ")
        strSQL.Append(" nmontas, ")
        strSQL.Append(" nmongra, ")
        strSQL.Append(" csitgar, ")
        strSQL.Append(" dfecrev, ")
        strSQL.Append(" ccoddep, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" cdirec ")
        strSQL.Append(" FROM climgar ")

    End Sub

    Public Function ObtenerDataSetEspc(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select cCodgar as Nro, cTipgar as Tipo, dEstado as Fecha, ")
        strSQL.Append(" cDescri as Descripcion, nMongar as Garantia, nMontas as Tasacion, ")
        strSQL.Append(" cestado = case cestado when 'A' then 'DESCARGADA' ")
        strSQL.Append(" when 'P' then 'ENTREGADA' ")
        strSQL.Append(" Else 'PENDIENTE' END , link_foto as link ")
        strSQL.Append(" FROM Climgar WHERE ccodcli = @ccodcli order by destado desc ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        'Si no es garantia liquida, coloca estado vacio
        For Each fila As DataRow In ds.Tables(0).Rows
            If fila("Tipo").ToString.Trim <> "04" Then
                fila("cestado") = ""
            End If
        Next

        'For Each link As DataRow In ds.Tables(0).Rows
        '    If link("link").ToString.Trim <> "" Then
        '        link("link") = l
        '        '<A HREF="file:///C:/Comprobante/ENA%20CONDE%20MENDEZ-001000000009-005.JPG"> Garantia </A> 
        '    End If
        'Next

        Return ds

    End Function



    Public Function ObtenerDataSetporcCodgar(ByVal ccodigo As String, ByVal cCodgar As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select nmongar, nmontas, cdescri as Descripcion, ")
        strSQL.Append(" left(ctipdes,2) as ctipdes, left(ctipgar,2) as ctipgar, cmoneda, ccoduni, nmongra, climgar.dpresent, climgar.dinscrip, climgar.cnumins, climgar.cnumpres, climgar.cobser, ")
        strSQL.Append(" cpropietario, cprofinca, ")
        strSQL.Append(" cprofolio, ")
        strSQL.Append(" cprolibro, ")
        strSQL.Append(" cprode, ")
        strSQL.Append(" dprofecha, ")
        strSQL.Append(" cmunfinca, ")
        strSQL.Append(" cmunfolio, ")
        strSQL.Append(" cmunlibro, ")
        strSQL.Append(" cmunde, ")
        strSQL.Append(" dmunfecha, ")
        strSQL.Append(" cdireccion, ")
        strSQL.Append(" ctopo, ")
        strSQL.Append(" cespdir, ")
        strSQL.Append(" cuso, ")
        strSQL.Append(" cespuso, ")
        strSQL.Append(" clocalidad, ")
        strSQL.Append(" nniveles, ")
        strSQL.Append(" cacceso, ")
        strSQL.Append(" cservicios, ")
        strSQL.Append(" cespser, ")
        strSQL.Append(" cambientes, ")
        strSQL.Append(" cespamb, ")
        strSQL.Append(" ctecho, ")
        strSQL.Append(" cesptecho, ")
        strSQL.Append(" cpiso, ")
        strSQL.Append(" cesppiso, ")
        strSQL.Append(" cparedes, ")
        strSQL.Append(" cesppared, ")
        strSQL.Append(" nnmedida, ")
        strSQL.Append(" nncolin, ")
        strSQL.Append(" nsmedida, ")
        strSQL.Append(" nscolin, ")
        strSQL.Append(" nemedida, ")
        strSQL.Append(" necolin, ")
        strSQL.Append(" nomedida, ")
        strSQL.Append(" nocolin, ")
        strSQL.Append(" nlongitud, ")
        strSQL.Append(" nlatitud, cubica, dfecval, cnotario, nnumeropr, dfechaes, clugares ")
        strSQL.Append(" FROM Climgar WHERE ccodcli = @ccodcli and cCodgar = @cCodgar")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodigo)
        args(1) = New SqlParameter("@ccodgar", cCodgar)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenercCodgar(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(ccodgar)+1 as ccodgar")
        strSQL.Append(" FROM Climgar ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("cCodgar")) Then
                lccodgar = "001"
            Else
                lccodgar = ds.Tables(0).Rows(0)("cCodgar")

                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 3 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = Nothing
        End If


        Return lccodgar

    End Function
    'Public Function ObtenercCodgar(ByVal ccodcli As String) As String

    '    Dim strSQL As New StringBuilder
    '    Dim lccodgar As String
    '    Dim i As Integer
    '    Dim tamano As Integer
    '    '*******
    '    strSQL.Append("SELECT max(ccodgar)+1 as ccodgar")
    '    strSQL.Append(" FROM Climgar ")
    '    strSQL.Append(" WHERE ccodcli = @ccodcli ")

    '    Dim args(1) As SqlParameter
    '    args(0) = New SqlParameter("@ccodcli", ccodcli)
    '    Dim ds As DataSet

    '    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    '    If ds.Tables(0).Rows.Count > 0 Then
    '        lccodgar = ds.Tables(0).Rows(0)("cCodgar")
    '        lccodgar.Trim()
    '        tamano = lccodgar.Trim.Length
    '        For i = 1 To 3 - tamano
    '            lccodgar = "0" & lccodgar
    '        Next
    '    Else
    '        lccodgar = Nothing
    '    End If
    '    Return lccodgar

    'End Function
    Public Function ObtenerDataSetRepo(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT climide.ccodcli,climide.cnomcli,climgar.ctipdes,climgar.cdescri, ")
        strSQL.Append(" climgar.nmongar,climgar.nmontas, tabttab.cdescri as cdescrip FROM climide ")
        strSQL.Append(" INNER JOIN climgar ON climide.ccodcli = climgar.ccodcli INNER JOIN tabttab ")
        strSQL.Append(" ON climgar.ctipgar = tabttab.ccodigo WHERE tabttab.ccodtab + ctipreg = '0741' ")
        strSQL.Append(" and climgar.ccodcli =@ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    'fran Eric
    Public Function ObtenerDataSetEspc1(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder

        'strSQL.Append(" Select *, (nMontas-nmongra) as Disponible ")
        'strSQL.Append(" FROM Climgar WHERE ccodcli = @ccodcli ")

        strSQL.Append(" Select climgar.*, (climgar.nMontas-climgar.nmongra) as Disponible ")
        strSQL.Append("  FROM Climgar WHERE climgar.ccodcli = @ccodcli ")
        'strSQL.Append("  and (climgar.nmongra) = 0   ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds

    End Function
    Public Function Actualizar1(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climgar
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE climgar ")
        strSQL.Append(" SET nmongra = @nmongra ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodgar = @ccodgar ")

        Dim args(3) As SqlParameter

        args(1) = New SqlParameter("@nmongra", SqlDbType.Decimal)
        args(1).Value = lEntidad.nmongra
        args(2) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(3) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value, lEntidad.ccodgar)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetPor_Garantia_Cliente(ByVal ccodcli As String, ByVal ctipgar As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT climgar.ccodcli, ")
        strSQL.Append(" climgar.ccodgar, ")
        strSQL.Append(" climgar.cestado, ")
        strSQL.Append(" climgar.destado, ")
        strSQL.Append(" rtrim(ctipdes) as ctipdes, ")
        strSQL.Append(" climgar.ccoduni, ")
        strSQL.Append(" rtrim(ctipgar) as ctipgar, ")
        strSQL.Append(" climgar.cdescri, ")
        strSQL.Append(" climgar.ccodzon, ")
        strSQL.Append(" rtrim(cmoneda) as cmoneda, ")
        strSQL.Append(" climgar.nmongar, ")
        strSQL.Append(" climgar.nmontas, ")
        strSQL.Append(" climgar.nmongra, ")
        strSQL.Append(" climgar.csitgar, ")
        strSQL.Append(" climgar.dfecrev, ")
        strSQL.Append(" climgar.ccoddep, ")
        strSQL.Append(" climgar.ccodusu, ")
        strSQL.Append(" climgar.dfecmod, ")
        strSQL.Append(" climgar.cflag, ")
        strSQL.Append(" climgar.cdirec, climgar.cnotario, climgar.nnumeropr, climgar.dfechaes, climgar.clugares ")
        strSQL.Append(" FROM climgar,climide ")
        strSQL.Append(" WHERE climide.ccodcli = climgar.ccodcli ")
        strSQL.Append(" and climgar.ccodcli = @ccodcli ")
        strSQL.Append(" and climgar.ctipgar = @ctipgar ")
        If ctipgar.Trim = "01" Then
            strSQL.Append(" and rtrim(ltrim(climgar.ccoduni)) <> '' ")
            strSQL.Append(" and rtrim(ltrim(climgar.ccoduni)) <> '-' ")
        End If
       
        'strSQL.Append(" and climgar.ccoduni <> '-' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ctipgar", ctipgar)

        Dim ds As DataSet

        ' Try

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

        'Catch ex As Exception

        ' End Try

    End Function
    Public Function Fiadores(ByVal lccodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select Climgar.cCoduni, climide.cnomcli as cnomfia, climide.cnudoci as cduifia, climide.cteldom as ctelfia,")
        strSQL.Append("climide.cdirdom as cdirfia, climide.cnudotr as cnitfia, climide.ccodpro, space(40) as cproffia ")
        strSQL.Append(" from Climgar, climide ")
        strSQL.Append("WHERE climgar.cCodcli = @lcCodcli")
        strSQL.Append(" and climgar.ctipgar =  '01'")
        strSQL.Append(" and climgar.ccoduni = climide.ccodcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodcli", SqlDbType.Char)
        args(0).Value = lccodcli
        

        Dim dsfia As DataSet
        dsfia = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsfia.Tables(0).Rows.Count = 0 Then

        Else
            Dim nelem As Integer
            Dim Fila As DataRow
            Dim lcprofe As String
            Dim etabtprf As New SIM.DL.dbTabtprf
            nelem = 0
            For Each Fila In dsfia.Tables(0).Rows
                lcprofe = etabtprf.profesion(dsfia.Tables(0).Rows(nelem)("ccodpro")).Trim
                dsfia.Tables(0).Rows(nelem)("cproffia") = lcprofe
                nelem += 1
            Next
        End If
        Return dsfia
    End Function
    Public Function GarantiaTipo(ByVal lccodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT TABTTAB.cdescri, TABTTAB.ccodigo, CLIMGAR.cCodCli, CLIMGAR.cCodgar, CLIMGAR.cCoduni,")
        strSQL.Append("CLIMGAR.cTipGar, CLIMGAR.nMonTas FROM TABTTAB, CLIMGAR ")
        strSQL.Append(" WHERE TABTTAB.ccodtab + TABTTAB.ctipreg = '0741' and TABTTAB.cCodigo = climgar.ctipgar")
        strSQL.Append(" and Climgar.cCodcli = @lcCodcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodcli", SqlDbType.Char)
        args(0).Value = lccodcli

        Dim dsgar As DataSet
        Dim lctipogar As String
        dsgar = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsgar.Tables(0).Rows.Count = 0 Then
            lctipogar = ""
        Else
            lctipogar = dsgar.Tables(0).Rows(0)("cdescri")
        End If
        Return lctipogar
    End Function
    Public Function ValorGarantia(ByVal lccodcli As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SUM(Climgar.nMongra) as nMonGra from climgar")
        strSQL.Append(" WHERE Climgar.cCodcli = @lcCodcli group by climgar.ccodcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodcli", SqlDbType.Char)
        args(0).Value = lccodcli

        Dim dsgar As DataSet
        Dim lcvalorgar As Double
        dsgar = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsgar.Tables(0).Rows.Count = 0 Then
            lcvalorgar = 0
        Else
            lcvalorgar = dsgar.Tables(0).Rows(0)("nmongra")
        End If
        Return lcvalorgar
    End Function
    Public Function ClimHip(ByVal lccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select distinct climgar.cCodgar as Nro, climgar.cdescri, cremcre.dfecvig, crepgar.nmongra,  ")
        strSQL.Append("climgar.dpresent, climgar.dinscrip, climgar.cnumins, climgar.cnumpres,")
        strSQL.Append("climgar.cobser, climgar.ccodcli   from climgar, crepgar, cremcre where ")
        strSQL.Append("climgar.ccodcli = crepgar.ccodcli and climgar.ccodgar = crepgar.ccodgar and ")
        strSQL.Append("substring(climgar.ctipgar,1,2) = '03'")
        strSQL.Append(" and crepgar.ccodcta = cremcre.ccodcta ")
        strSQL.Append(" and  crepgar.ccodcta = @lccodcta ")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodcta", SqlDbType.Char)
        args(0).Value = lccodcta


        Dim dship As DataSet
        dship = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return dship
    End Function
    Public Function ActualizarHipo(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As climgar
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE climgar ")
        strSQL.Append(" SET dpresent = @dpresent, ")
        strSQL.Append(" dinscrip = @dinscrip, ")
        strSQL.Append(" cnumins = @cnumins, ")
        strSQL.Append(" cnumpres = @cnumpres, ")
        strSQL.Append(" cobser = @cobser ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodgar = @ccodgar ")

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dpresent", SqlDbType.DateTime)
        args(0).Value = lEntidad.dpresent
        args(1) = New SqlParameter("@dinscrip", SqlDbType.DateTime)
        args(1).Value = lEntidad.dinscrip
        args(2) = New SqlParameter("@cnumins", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnumins
        args(3) = New SqlParameter("@cnumpres", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnumpres
        args(4) = New SqlParameter("@cobser", SqlDbType.VarChar)
        args(4).Value = lEntidad.cobser
        args(5) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(6) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value, lEntidad.ccodgar)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function RepgHip(ByVal ldfecini As Date, ByVal ldfecfin As Date, ByVal lcfec As String, ByVal lcestados As String, ByVal lcopcion As Integer) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select distinct cremcre.ccodcta, climide.ccodcli, climide.cnomcli,  ")
        strSQL.Append("climgar.ccodgar, climgar.cdescri,  climgar.nmongra, ")
        strSQL.Append("climgar.dpresent, climgar.dinscrip, climgar.cnumins, climgar.cnumpres, climgar.cobser ")
        strSQL.Append("from climide, climgar, cremcre ")
        strSQL.Append("where cremcre.ccodcli = climide.ccodcli ")
        strSQL.Append("and climide.ccodcli = climgar.ccodcli ")
        strSQL.Append("and substring(climgar.ctipgar,1,2) = '03'")

        If lcfec <> "*" Then
            strSQL.Append(" AND CREMCRE.dfecvig >= @ldfecini ")
            strSQL.Append(" AND CREMCRE.dfecvig <= @ldfecfin ")
        End If
        If lcestados = "111" Then
            strSQL.Append(" AND CREMCRE.cCondic IN ('N','V','P','J','S') ")
        ElseIf lcestados = "110" Then
            strSQL.Append(" AND CREMCRE.cCondic IN ('N','V','P','J') ")
            strSQL.Append(" and CREMCRE.cEstado IN ('F','G')")
        ElseIf lcestados = "100" Then
            strSQL.Append(" AND CREMCRE.cCondic IN ('N','V','P','J') ")
            strSQL.Append(" and CREMCRE.cEstado IN ('F')")
        ElseIf lcestados = "010" Then
            strSQL.Append(" AND CREMCRE.cCondic IN ('N','V','P','J') ")
            strSQL.Append(" and CREMCRE.cEstado IN ('G')")
        ElseIf lcestados = "001" Then
            strSQL.Append(" AND CREMCRE.cCondic IN ('N','V','P','J','S')")
        End If

        If lcopcion = 2 Then
            strSQL.Append("AND CLIMGAR.dpresent <> #1/1/1900#  ")
            strSQL.Append("AND CLIMGAR.dinscrip <> #1/1/1900#  ")
        ElseIf lcopcion = 3 Then
            strSQL.Append("AND CLIMGAR.dpresent <> #1/1/1900#  ")
            strSQL.Append("AND CLIMGAR.dinscrip = #1/1/1900#  ")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@ldfecini", SqlDbType.DateTime)
        args(0).Value = ldfecini
        args(1) = New SqlParameter("@ldfecfin", SqlDbType.DateTime)
        args(1).Value = ldfecfin
        args(2) = New SqlParameter("@lcfec", SqlDbType.Char)
        args(2).Value = lcfec
        args(3) = New SqlParameter("@lcestados", SqlDbType.Char)
        args(3).Value = lcestados
        args(4) = New SqlParameter("@lcopcion", SqlDbType.Int)
        args(4).Value = lcopcion

        Dim dship As DataSet
        dship = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return dship
    End Function
    Public Function DatosFiador(ByVal pcCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" Select Climide.cnomcli, climide.cdirdom, climide.cteldom, cremcre.ccodcta from climide inner join climgar on ")
        strSQL.Append(" climide.ccodcli = climgar.ccoduni ")
        strSQL.Append(" inner join cremcre on climgar.ccodcli = cremcre.ccodcli and cremcre.ccodcta = @pcCodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcCodcta", SqlDbType.VarChar)
        args(0).Value = pcCodcta
        Dim ds As New DataSet
        Dim lcdatos As String
        Dim lcnomcli, lcdirdom, lcteldom As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcdatos = ""

        Else
            Dim fila As DataRow
            Dim i As Integer
            For Each fila In ds.Tables(0).Rows
                lcnomcli = ds.Tables(0).Rows(i)("cnomcli")
                lcdirdom = ds.Tables(0).Rows(i)("cdirdom")
                lcteldom = ds.Tables(0).Rows(i)("cteldom")
                lcdatos = lcdatos + lcnomcli.Trim + " " + lcdirdom.Trim + " " + lcteldom.Trim + " "
                i += 1
            Next
        End If
        Return lcdatos
    End Function
    Public Function ValidaGarantiaPref(ByVal lccodcli As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("select climide.cnomcli,climgar.cdescri from climide, climgar, tabttab ")
        strSQL.Append("where climide.ccodcli = climgar.ccodcli ")
        strSQL.Append("and tabttab.ccodtab = '074' and tabttab.ctipreg ='1' ")
        strSQL.Append("and  climgar.ctipgar = left(tabttab.ccodigo,2) ")
        strSQL.Append("and climgar.ctipgar ='05' ")
        strSQL.Append("and climgar.ccodcli = @lccodcli ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodcli", SqlDbType.Char)
        args(0).Value = lccodcli

        Dim dsgar As DataSet
        Dim lcvalorgar As Double
        dsgar = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsgar.Tables(0).Rows.Count = 0 Then
            lcvalorgar = 0
        Else
            lcvalorgar = 1
        End If
        Return lcvalorgar
    End Function
    Public Function ObtenerDataSetPor_Garantia_Prendaria(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT climgar.ccodcli, ")
        strSQL.Append(" climgar.ccodgar, ")
        strSQL.Append(" climgar.cestado, ")
        strSQL.Append(" climgar.destado, ")
        strSQL.Append(" rtrim(ctipdes) as ctipdes, ")
        strSQL.Append(" climgar.ccoduni, ")
        strSQL.Append(" rtrim(ctipgar) as ctipgar, ")
        strSQL.Append(" climgar.cdescri, ")
        strSQL.Append(" climgar.ccodzon, ")
        strSQL.Append(" rtrim(cmoneda) as cmoneda, ")
        strSQL.Append(" climgar.nmongar, ")
        strSQL.Append(" climgar.nmontas, ")
        strSQL.Append(" climgar.nmongra, ")
        strSQL.Append(" climgar.csitgar, ")
        strSQL.Append(" climgar.dfecrev, ")
        strSQL.Append(" climgar.ccoddep, ")
        strSQL.Append(" climgar.ccodusu, ")
        strSQL.Append(" climgar.dfecmod, ")
        strSQL.Append(" climgar.cflag, ")
        strSQL.Append(" climgar.cdirec ")
        strSQL.Append(" FROM climgar,climide ")

        strSQL.Append(" WHERE climide.ccodcli = climgar.ccodcli ")
        strSQL.Append(" and climgar.ccodcli = @ccodcli ")
        strSQL.Append(" and climgar.ctipgar = '02' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ' Try

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

        'Catch ex As Exception

        ' End Try

    End Function
    'Obtiene descripcion de garantia hipotecaria para contrato
    Public Function ObtieneGarantiaHipotecaria(ByVal cCodSol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" select climgar.cdescri, climgar.ctipgar, cremcre.ccodsol from cremcre, climide, climgar ")
        strSQL.Append(" where cremcre.ccodcli = climide.ccodcli ")
        strSQL.Append(" and climide.ccodcli = climgar.ccodcli ")
        strSQL.Append(" and (climgar.ctipgar = '03' ) ")
        strSQL.Append(" and   cremcre.ccodsol = @cCodsol ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", cCodSol)
        Dim ds As New DataSet
        Dim lcdescri As String


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then

        End If

    End Function

    Public Function CreditosdeCodeudor(ByVal ccodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select climgar.ccoduni, cremcre.ccodcta from climgar,cremcre ")
        strSQL.Append("where climgar.ccodcli = @ccodcli and climgar.ctipgar ='01' ")
        strSQL.Append("and cremcre.cestado ='F' and cremcre.ccodcli = climgar.ccoduni ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As New DataSet
        Dim lcdescri As String = "CODEUDOR NO TIENE CREDITOS VIGENTES"


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccoduni")) Then
            Else
                Dim fila As DataRow
                Dim lccodigos As String = ""
                Dim lccodcta As String = ""
                lcdescri = "CODEUDOR TIENE VIGENTE CREDITO No."
                For Each fila In ds.Tables(0).Rows
                    lccodcta = fila("ccodcta")
                    lccodigos = lccodigos & lccodcta & " -"
                Next

                lcdescri = lcdescri & lccodigos
            End If
        End If

        Return lcdescri
    End Function

    Public Function ObtenerDataSetEspc12(ByVal ccodcli As String, ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" Select distinct climgar.*,  (climgar.nMontas-climgar.nmongra) as Disponible ")
        strSQL.Append("  FROM Climgar, crepgar WHERE climgar.ccodcli = @ccodcli ")
        strSQL.Append("  and climgar.ccodcli = crepgar.ccodcli and climgar.ccodgar = crepgar.ccodgar   ")
        strSQL.Append(" and crepgar.ccodcta = @ccodcta")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds

    End Function
    Public Function ObtenerDataSetEspcGrupal(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select climgar.*, (climgar.nMontas-climgar.nmongra) as Disponible, (climgar.ccodcli+climgar.ccodgar) as llave ")
        strSQL.Append("  FROM Climgar, cremcre WHERE climgar.ccodcli = cremcre.ccodcli and  cremcre.ccodsol = @ccodcli ")
        strSQL.Append(" and (cremcre.cestado ='A' or cremcre.cestado ='C' or cremcre.cestado ='E' )")
        'strSQL.Append("  and (climgar.nmongra) = 0   ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    'LLenado de Grid nuevo grupal
    Public Function Proce_LlenadoGrid(ByVal ccodcli As String) As DataSet


        Dim strSQL As New StringBuilder

        strSQL.Append(" select distinct aho.cnudotr,cli.cnomcli,aho.nsaldnind, cast(cre.nmonsug as decimal(12,2)) as 'MontoSol',  ")
        strSQL.Append(" isnull(rp.porcentaje_Garantias,0) as porcentaje_Garantias ,gas.nmonpor  from cremcre cre inner join climide cli on cre.ccodcli=cli.ccodcli  ")
        strSQL.Append(" inner join ahomcta aho on cli.ccodcli=aho.cnudotr inner join  Reglas_Producto rp on cre.cnrolin=rp.cnrolin inner join cretgas gas ")
        strSQL.Append(" on cre.cnrolin=gas.cnrolin where cre.ccodsol=@ccodsol and aho.producto not in('01') and cre.cestado = 'E' order by cli.cnomcli  ")
       
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodsol", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function obtnerCreditos(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder

        strSQL.Append(" select ccodcta from cremcre where ccodcta=@ccodcta ")
        
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcli)

        Dim ccodcta As String

        ccodcta = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ccodcta


    End Function
    'Obtener seguro d eproducto
    Public Function obtenerSeguro(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder

        strSQL.Append(" select cnrolin from cremcre where ccodcta=@ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcli)

        Dim cnrolin As String

        cnrolin = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return cnrolin


    End Function
    'Ontiene montos de seguro del producto
    Public Function Buscarmonto(ByVal cnrolin As String) As Integer

        Dim strSQL As New StringBuilder

        strSQL.Append(" select isnull(seguro,0) from Reglas_Producto where cnrolin=@cnrolin ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", cnrolin)

        Dim nmotnoPro As String

        nmotnoPro = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return nmotnoPro
    End Function

    'obtiene monto de seguros
    Public Function obtenerSeguros(ByVal ccodcta As String) As Integer

        Dim strSQL As New StringBuilder

        strSQL.Append(" select isnull(nmonto,0) from aux_ingresos where ccodcta=@ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim monto As Integer

        monto = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return monto

    End Function




    Public Function ObtenerDataSetEspcGrupal2(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" Select distinct climgar.*,(climgar.ccodcli+climgar.ccodgar) as llave, cremcre.ccodcta, (climgar.nMontas-climgar.nmongra) as Disponible ")
        strSQL.Append("  FROM Climgar, crepgar, cremcre WHERE climgar.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @ccodcli ")
        strSQL.Append(" and (cremcre.cestado ='C' or cremcre.cestado ='E') and cremcre.ccodcta =Crepgar.ccodcta ")
        strSQL.Append("  and climgar.ccodcli = crepgar.ccodcli and climgar.ccodgar = crepgar.ccodgar   ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetporcCodgarGrupal(ByVal ccodigo As String, ByVal cCodgar As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select cremcre.ccodcta, climgar.nmongar, climgar.nmontas, climgar.cdescri as Descripcion, ")
        strSQL.Append(" left(climgar.ctipdes,2) as ctipdes, left(climgar.ctipgar,2) as ctipgar, climgar.cmoneda, climgar.ccoduni, climgar.nmongra, climgar.dpresent, climgar.dinscrip, climgar.cnumins, climgar.cnumpres, climgar.cobser ")
        strSQL.Append(" FROM Climgar, cremcre WHERE climgar.ccodcli = @ccodcli and climgar.cCodgar = @cCodgar")
        strSQL.Append(" and cremcre.ccodcli = climgar.ccodcli and (cremcre.cestado ='C' or cremcre.cestado ='E')")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodigo)
        args(1) = New SqlParameter("@ccodgar", cCodgar)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetGravamen(ByVal ccodcli As String, ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder

        'strSQL.Append(" Select *, (nMontas-nmongra) as Disponible ")
        'strSQL.Append(" FROM Climgar WHERE ccodcli = @ccodcli ")

        strSQL.Append(" Select climgar.*, crepgar.nmongra as ngravamen, (climgar.nMontas-climgar.nmongra) as Disponible ")
        strSQL.Append("  FROM Climgar, crepgar WHERE climgar.ccodcli = @ccodcli and climgar.ccodcli = crepgar.ccodcli and climgar.ccodgar = crepgar.ccodgar ")
        strSQL.Append(" and crepgar.ccodcta = @ccodcta")
        'strSQL.Append("  and (climgar.nmongra) = 0   ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function Extrae_Garantia_Pendiente(ByVal pcCodcli As String) As DataSet

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
                        " Select cCodgar as Nro, cTipgar as Tipo, dEstado as Fecha, " & _
                        " cDescri as Descripcion, nMongar as Garantia, nMontas as Tasacion " & _
                        " FROM Climgar " & _
                        " Where ccodcli = '" & pcCodcli & "' and ctipgar  = '04' and cestado = 'A'"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "G_Liquidas")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds

    End Function

    Public Function Extrae_Garantia_Liquida(ByVal pcCodcli As String) As DataSet

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
                        " Select cCodgar as Nro, cTipgar as Tipo, dEstado as Fecha, " & _
                        " cDescri as Descripcion, nMongar as Garantia, nMontas as Tasacion " & _
                        " FROM Climgar " & _
                        " Where ccodcli = '" & pcCodcli & "' and ctipgar  = '04' and cestado = ''"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "G_Liquidas")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds

    End Function

    Public Function Datos_Fiadores(ByVal pcCodcta As String) As DataSet

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
                        " Select c.* from cremcre a " & _
                        " inner join crepgar b " & _
                        " on a.ccodcta = b.ccodcta " & _
                        " inner join climgar c " & _
                        " on b.ccodcli = c.ccodcli " & _
                        " inner join climide d " & _
                        " on c.ccoduni = d.ccodcli " & _
                        " where a.ccodcta = '" & pcCodcta & "' and b.ctipgar  = '01' " & _
                        " and b.ccodgar = c.ccodgar "

                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Fiadores")


                For Each fila As DataRow In ds.Tables("Fiadores").Rows
                    lcprofe = etabtprf.profesion(fila("ccodpro")).Trim()
                    fila("cproffia") = lcprofe
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds

    End Function



    Public Function Actualiza_Garantias_Activas(ByVal pcCodcli As String, ByVal pcCodgar As String, _
                                                ByVal pcEstado As String) As Integer

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lnRetorno As Integer = 0


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection


                command.CommandText = _
                                        " Update Climgar set cestado = '" & pcEstado & "'" & _
                                        " Where cCodcli ='" & pcCodcli & "' and cCodgar ='" & pcCodgar & "'"

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

    'Actualiza auxiliar de otros ingresos
    Public Function Actualiza_Auxiliar_Otros_Ing(ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                                 ByVal pcTipIng As String, ByVal pdfecpag As Date, _
                                                 ByVal pccodusu As String, ByVal pcnomcli As String) As Integer

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lnRetorno As Integer = 0


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection


                command.CommandText = _
                                        " Insert into aux_ingresos (ccodcta, cnomcli, nmonto, ctiping, dfecpag, dfecmod, ccodusu)" & _
                                        " values('" & pcCodcta & "','" & pcnomcli & "'," & pnmonto & ",'" & pcTipIng & "','" & pdfecpag & _
                                        "',getdate(),'" & pccodusu & "')"

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

    Public Function Valida_Existencia_Tipo_Ingreso(ByVal pcCodcta As String, ByVal pctiping As String, ByVal fecha_sistema As DateTime) As Boolean

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim llgarantia As Boolean = True

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection

                command.CommandText = _
                                        " Select * From aux_ingresos " & _
                                        " Where ccodcta = '" & pcCodcta & "' and ctiping = '" & pctiping & "' and dfecpag = '" & fecha_sistema & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Garantias")

                If ds.Tables("Garantias").Rows.Count = 0 Then
                    llgarantia = False
                End If
                'Al poner en false esta variable permitira Aplicar Garantias
                llgarantia = False
            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return llgarantia

    End Function

    Public Function Valida_Existencia_Garantia_Liquida_Activa(ByVal pcCodcli As String) As Boolean

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim llgarantia As Boolean = True

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection

                command.CommandText = _
                                        " Select ccodcli, ccodgar, cestado, nmongar, nmontas From climgar " & _
                                        " Where ccodcli = '" & pcCodcli & "' and cestado = 'A'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Garantias")

                If ds.Tables("Garantias").Rows.Count = 0 Then
                    llgarantia = False
                End If

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return llgarantia

    End Function

    Public Function Extrae_Datos_Otros_Ingresos(ByVal pcCodcta As String) As DataSet

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
                        " Select ROW_NUMBER () OVER (ORDER BY dfecpag) as No, dfecpag, " & _
                        " tipo = case ctiping when  '03' then 'SEGURO' " & _
                        " when  '04' then 'GARANTIA LIQUIDA' " & _
                        " ELSE 'OTRO INGRESO' " & _
                        " END, " & _
                        " nmonto from aux_ingresos " & _
                        " Where ccodcta = '" & pcCodcta & "'" & _
                        " order by dfecpag, ctiping "

                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Otros INgresos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds

    End Function
    'Inserta en Accounting Master
    Public Function Mantenimiento_Otros_Ingresos(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                                 ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
                                                 ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
                                                 ByVal pcEstado As String, ByVal id_identity As Integer) As String

        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lcnumcom As String = "0"
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim occlass As New dbCntamov
        'Dim lcCodcta_ISR As String = ""
        Dim lcCodcta_Aho As String = ""
        'Dim lcCodcta_CJA As String = ""
        'Dim lcCodbco As String = ""
        Dim lcCtacte As String = ""
        Dim lnSaldoAho As Double = 0
        Dim lnLibreta As String = 0
        Dim lnlinea As Integer = 0
        Dim lnPagina As Integer = 0
        Dim lnpaginau As Integer = 0
        Dim eahommov As New dbAhommov
        Dim lcCodaho_dep As String = ""
        Dim lcCodaho_provis As String = Encabeza_Part(24)
        Dim lntotal_p As Double = 0

        Dim lnDebe As Double = Math.Round((Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))), 2)

        'Dim Datos_Cert() As String = {Date.Parse(Me.Txtdfeccnt.Text), Session("gccodofi"), _
        '                              concepto, "PA", Session("GDFECSIS"), _
        '                              Session("gcCodusu"), "", "", "", Double.Parse(Me.TxtnMonCert.Text), _
        '                              Me.TxtcCodcrt.Text.Trim, Me.Txtndias.Text.ToString, Me.TxtcCodPerson.Text.Trim, _
        '                              CbxBancos1.SelectedValue.Trim, CbxCtasBanco1.SelectedValue.Trim, _
        '                              CbxCtasBanco1.SelectItem.text.trim, lcmonto_letras, _
        '                              Me.Txtcnrochq.Text.Trim, Me.Txtctitular.Text.Trim, Double.Parse(TxtnIntere.Text), _
        '                              Double.Parse(TxtnImpuestos.Text), CbxCtaAho1.SelectedItem.Text.Trim,
        '                              Me.CbxUsuarios1.SelectedValue.Trim, Session("gccontra"), lccodcta}




        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try

                'Extrae Mascara de Ahorros
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '02'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho = fila("cCta1").ToString.Trim
                    'lcCodaho_provis = fila("cCta2").ToString.Trim
                Next


                ds.Tables.Clear()


                'Extrae cuenta de ahorros
                command.CommandText = _
                                        " Select ccodaho from Ahomcta " & _
                                        " Where cnudotr='" & pccodcli & "' and producto = '02'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "CtasAhorro")


                For Each fila As DataRow In ds.Tables("CtasAhorro").Rows
                    Encabeza_Part(20) = fila("ccodaho").ToString.Trim
                Next


                If Encabeza_Part(20).Trim.Length = 0 Then
                    lcnumcom = "2"
                    Return lcnumcom
                End If

                'Extrae Correlativo de Partida
                command.CommandText = _
                                        " Select * from cnumes " & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_No_Part")

                For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                    lcnumcom = fila("cnumcom").ToString.Trim
                Next

                i = Double.Parse(Right(lcnumcom, 6)) + 1


                lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                           ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                           occlass.fxStrZero(i, 6)


                'Inserta Asiento Contable, Primero lo hara en la Maestra
                command.CommandText = _
                                         " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                        " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                        " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                        " Values('" & _
                                        lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                        Encabeza_Part(2) & "','',''," & _
                                        "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                        Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                command.ExecuteNonQuery()

                'Actualizara en la cNumes      
                'no se le inserta id solo son las partida de mes
                command.CommandText = _
                                        " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                            ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                command.ExecuteNonQuery()


                i = 1

                'Cargo id_identity
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodaho_provis & "','" & _
                                        lcCodaho_provis.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                        ",0,'',0,'','" & _
                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                command.ExecuteNonQuery()



                i += 1

                'Descargo
                'Insertamos id_identity
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli ) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                        lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "',0" & _
                                        "," & lnDebe & ",'',0,'','" & _
                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                command.ExecuteNonQuery()


                'Extre Movimiento de Ahorro
                command.CommandText = _
                                        " Select * from Ahomcta " & _
                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Ahorro")

                For Each fila As DataRow In ds.Tables("Ahorro").Rows
                    lnSaldoAho = fila("nsaldoaho") + (Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19)))
                    lnSaldoAho = Math.Round(lnSaldoAho, 2)
                    lnLibreta = fila("nlibreta")
                    lnlinea = fila("nnum") + 1
                Next

                'lnlinea = eahommov.fxLinea(lnlinea)

                If lnlinea > 65 Then
                    lnlinea = 1
                End If



                ' Inserta en la Maestra de Ahorros
                'inserta nueva id=id_identity
                command.CommandText = _
                                        " Update ahomcta " & _
                                        " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                        " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres " & _
                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"
                command.ExecuteNonQuery()


                lntotal_p = Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))
                lntotal_p = Math.Round(lntotal_p, 2)


                ' Inserta en el Movimiento de Ahorros
                'Nuevo id id_identity
                command.CommandText = _
                                        "insert into ahommov " & _
                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina ) values " & _
                                        "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'D', 'GAR', 'E', 'DEPOSITO x GARANTIA LIQUIDA', " & lnLibreta & ", '', ''," & _
                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & lntotal_p & ",0,'N'," & _
                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                        lnSaldoAho & ", " & lnSaldoAho & ", 'DP','02',' ',0,'',0," & lnPagina & ")"

                command.ExecuteNonQuery()



                'Actualiza estado de la Garantia, en la Maestra
                'No se hace el cambio de id_identity
                command.CommandText = _
                                       " Update Climgar set cestado = 'A'" & _
                                       " Where cCodcli ='" & pccodcli & "' and cCodgar ='" & pcCodgar & "'"

                command.ExecuteNonQuery()


                'Inserta Movimiento en auxiliar
                'ya no se insertara a qui por motivos de borrado
                'command.CommandText = _
                '                        " Insert into aux_ingresos (ccodcta, cnomcli, nmonto, ctiping, dfecpag, dfecmod, ccodusu, id_climgar)" & _
                '                        " values('" & pcCodcta & "','" & pcnomcli & "'," & pnmonto & ",'" & pcTipIng & "','" & pdfecpag & _
                '                        "',getdate(),'" & pccodusu & "'," & id_identity & ")"

                'command.ExecuteNonQuery()


                ' Attempt to commit the transaction.
                MyTransac.Commit()



            Catch ex As Exception
                lcnumcom = "0"

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)


                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lcnumcom

    End Function


    Public Function Entrega_Garantia_Liquida(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                             ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
                                              ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
                                              ByVal pcEstado As String) As String


        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lcnumcom As String = "0"
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim occlass As New dbCntamov
        'Dim lcCodcta_ISR As String = ""
        Dim lcCodcta_Aho As String = ""
        'Dim lcCodcta_CJA As String = ""
        'Dim lcCodbco As String = ""
        Dim lcCtacte As String = ""
        Dim lnSaldoAho As Double = 0
        Dim lnLibreta As String = 0
        Dim lnlinea As Integer = 0
        Dim lnPagina As Integer = 0
        Dim lnpaginau As Integer = 0
        Dim eahommov As New dbAhommov
        Dim lcCodaho_dep As String = ""
        Dim lcCodaho_provis As String = Encabeza_Part(24)
        Dim lntotal_p As Double = 0

        Dim lnDebe As Double = Math.Round((Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))), 2)

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try

                'Extrae Mascara de Ahorros
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '02'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho = fila("cCta1").ToString.Trim
                    'lcCodaho_provis = fila("cCta2").ToString.Trim
                Next


                ds.Tables.Clear()


                'Extrae cuenta de ahorros
                command.CommandText = _
                                        " Select ccodaho from Ahomcta " & _
                                        " Where cnudotr='" & pccodcli & "' and producto = '02'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "CtasAhorro")


                For Each fila As DataRow In ds.Tables("CtasAhorro").Rows
                    Encabeza_Part(20) = fila("ccodaho").ToString.Trim
                Next


                If Encabeza_Part(20).Trim.Length = 0 Then
                    lcnumcom = "2"
                    Return lcnumcom
                End If



                'Extrae Correlativo de Partida
                command.CommandText = _
                                        " Select * from cnumes " & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_No_Part")

                For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                    lcnumcom = fila("cnumcom").ToString.Trim
                Next

                i = Double.Parse(Right(lcnumcom, 6)) + 1


                lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                           ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                           occlass.fxStrZero(i, 6)



                'Inserta Asiento Contable, Primero lo hara en la Maestra
                command.CommandText = _
                                        " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                        " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                        " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                        " Values('" & _
                                        lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                        Encabeza_Part(2) & "','',''," & _
                                        "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                        Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                command.ExecuteNonQuery()

                'Actualizara en la cNumes                           
                command.CommandText = _
                                        " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                            ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                command.ExecuteNonQuery()


                i = 1

                'Cargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodaho_provis & "','" & _
                                        lcCodaho_provis.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                        ",0,'',0,'','" & _
                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                command.ExecuteNonQuery()



                i += 1

                'Descargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                        lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "',0" & _
                                        "," & lnDebe & ",'',0,'','" & _
                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                command.ExecuteNonQuery()




                'Extre Movimiento de Ahorro
                command.CommandText = _
                                        " Select * from Ahomcta " & _
                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Ahorro")

                For Each fila As DataRow In ds.Tables("Ahorro").Rows
                    lnSaldoAho = fila("nsaldoaho") - Double.Parse(Encabeza_Part(19))
                    lnSaldoAho = Math.Round(lnSaldoAho, 2)
                    lnLibreta = fila("nlibreta")
                    lnlinea = fila("nnum") + 1
                Next

                'lnlinea = eahommov.fxLinea(lnlinea)

                If lnlinea > 65 Then
                    lnlinea = 1
                End If


                ' Inserta en la Maestra de Ahorros
                command.CommandText = _
                                        " Update ahomcta " & _
                                        " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                        " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres" & _
                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"
                command.ExecuteNonQuery()


                lntotal_p = Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))
                lntotal_p = Math.Round(lntotal_p, 2)


                ' Inserta en el Movimiento de Ahorros
                command.CommandText = _
                                        "insert into ahommov " & _
                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina) values " & _
                                        "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'R', 'GAR', 'E', 'RETIRO CANCELACION x GARANTIA LIQUIDA', " & lnLibreta & ", '', ''," & _
                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & lntotal_p & ",0,'N'," & _
                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                        lnSaldoAho & ", " & lnSaldoAho & ", 'RT','02',' ',0,'',0," & lnPagina & ")"

                command.ExecuteNonQuery()



                'Actualiza estado de la Garantia, en la Maestra

                command.CommandText = _
                                       " Update Climgar set cestado = 'P'" & _
                                       " Where cCodcli ='" & pccodcli & "' and cCodgar ='" & pcCodgar & "'"

                command.ExecuteNonQuery()


                ' Inserta Movimiento en Dispersador
                command.CommandText = _
                                        " Insert into Dispersa_Garant (ccodcta, cnomcli, nmonto, dfecsis, ccodusu, dfecmod, ldispersa) " & _
                                        " Values('" & Encabeza_Part(23) & "','" & Encabeza_Part(25) & "'," & Encabeza_Part(19) & ",'" & _
                                        ldfeccnt & "','" & Encabeza_Part(5) & "',getdate(),0) "
                command.ExecuteNonQuery()

                ' Attempt to commit the transaction.
                MyTransac.Commit()



            Catch ex As Exception
                lcnumcom = "0"

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lcnumcom

    End Function

    Public Function BuscarCredito_(ByVal credito As String) As String
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim credito_ As String

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection

                command.CommandText = _
                                        " Select ccodcta from cremcre  " & _
                                        " Where ccodcli = '" & credito & "' and cestado in('A','C','E')"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds)

                For Each row As DataRow In ds.Tables(0).Rows

                    credito_ = (row("ccodcta"))

                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return credito_



    End Function

    Public Function ObtenerDatosCliente(ByVal codigoCli As String, ByVal cogar As String) As DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim credito_ As String

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection

                command.CommandText = _
                                        " Select destado from Climgar  " & _
                                        " Where ccodcli = '" & codigoCli & "' and ccodgar = '" & cogar & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds)


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using




        Return ds
    End Function

    Public Function ObtenerDatosCliente_(ByVal codigoCli As String, ByVal Estatus As String) As DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim credito_ As String

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try
                command.Connection = connection

                command.CommandText = _
                                        " Select ccodgar,destado,nmongar from Climgar  " & _
                                        " Where ccodcli = '" & codigoCli & "' and cestado = ''"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds)


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Return ds
    End Function
    '---29 07 2015
    Public Function Obtener_estatus(ByVal codigo As String, ByVal ccodgar As String) As String
        Dim retorno_estatus As String = ""

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select cestado FROM Climgar WHERE ccodcli = @ccodcli and ccodgar = @ccodgar ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", codigo)
        args(1) = New SqlParameter("@ccodgar", ccodgar)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        'Si no es garantia liquida, coloca estado vacio
        For Each fila As DataRow In ds.Tables(0).Rows
            retorno_estatus = fila("cestado")

        Next

        Return retorno_estatus
    End Function


    Public Function Obtener_identiy_climgar(ByVal codigoCli As String, ByVal codigoGar As String) As String
        Dim Identity_ As Integer = 0


        Dim strSQL As New StringBuilder

        strSQL.Append(" Select id FROM Climgar WHERE ccodcli = @ccodcli and ccodgar = @ccodgar ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", codigoCli)
        args(1) = New SqlParameter("@ccodgar", codigoGar)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        'Si no es garantia liquida, coloca estado vacio
        For Each fila As DataRow In ds.Tables(0).Rows
            Identity_ = fila("id")

        Next


        Return Identity_
    End Function
    'Actualiza,Elimina,y modifica Cuentas Contables

    'Reverseo de garantia --
    Public Function EliminarGarantias(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                            ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
                                            ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
                                            ByVal pcEstado As String, ByVal id_identity As Integer) As String


        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lcnumcom As String = "0"
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim occlass As New dbCntamov
        'Dim lcCodcta_ISR As String = ""
        Dim lcCodcta_Aho As String = ""
        'Dim lcCodcta_CJA As String = ""
        'Dim lcCodbco As String = ""
        Dim lcCtacte As String = ""
        Dim lnSaldoAho As Double = 0
        Dim lnLibreta As String = 0
        Dim lnlinea As Integer = 0
        Dim lnPagina As Integer = 0
        Dim lnpaginau As Integer = 0
        Dim eahommov As New dbAhommov
        Dim lcCodaho_dep As String = ""
        Dim lcCodaho_provis As String = Encabeza_Part(24)
        Dim lntotal_p As Double = 0

        Dim lnDebe As Double = Math.Round((Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))), 2)





        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try

                'Extrae Mascara de Ahorros
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '02'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho = fila("cCta1").ToString.Trim
                    'lcCodaho_provis = fila("cCta2").ToString.Trim
                Next


                ds.Tables.Clear()


                'Extrae cuenta de ahorros
                command.CommandText = _
                                        " Select ccodaho from Ahomcta " & _
                                        " Where cnudotr='" & pccodcli & "' and producto = '02'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "CtasAhorro")


                For Each fila As DataRow In ds.Tables("CtasAhorro").Rows
                    Encabeza_Part(20) = fila("ccodaho").ToString.Trim
                Next


                If Encabeza_Part(20).Trim.Length = 0 Then
                    lcnumcom = "2"
                    Return lcnumcom
                End If



                'Extrae Correlativo de Partida
                command.CommandText = _
                                        " Select * from cnumes " & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_No_Part")

                For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                    lcnumcom = fila("cnumcom").ToString.Trim
                Next

                i = Double.Parse(Right(lcnumcom, 6)) + 1


                lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                           ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                           occlass.fxStrZero(i, 6)



                'Inserta Asiento Contable, Primero lo hara en la Maestra
                command.CommandText = _
                                        " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                        " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                        " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                        " Values('" & _
                                        lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                        Encabeza_Part(2) & "','',''," & _
                                        "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                        Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                command.ExecuteNonQuery()

                'Actualizara en la cNumes                           
                command.CommandText = _
                                        " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                        " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                            ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                command.ExecuteNonQuery()


                i = 1

                'Cargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli ) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodaho_provis & "','" & _
                                        lcCodaho_provis.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                        ",0,'',0,'','" & _
                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                command.ExecuteNonQuery()



                i += 1

                'Descargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli ) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                        lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "',0" & _
                                        "," & lnDebe & ",'',0,'','" & _
                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"
                command.ExecuteNonQuery()



                'Extre Movimiento de Ahorro
                command.CommandText = _
                                        " Select * from Ahomcta " & _
                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Ahorro")

                For Each fila As DataRow In ds.Tables("Ahorro").Rows
                    lnSaldoAho = fila("nsaldoaho") - (Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19)))
                    lnSaldoAho = Math.Round(lnSaldoAho, 2)
                    lnLibreta = fila("nlibreta")
                    lnlinea = fila("nnum") + 1
                Next

                'lnlinea = eahommov.fxLinea(lnlinea)

                If lnlinea > 65 Then
                    lnlinea = 1
                End If



                ' Inserta en la Maestra de Ahorros
                ' hay que hacer update para ajustar saldos - monto
                command.CommandText = _
                                        " Update ahomcta " & _
                                        " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                        " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres " & _
                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"
                command.ExecuteNonQuery()


                lntotal_p = Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))
                lntotal_p = Math.Round(lntotal_p, 2)


                ' Inserta en el Movimiento de Ahorros
                'Agregado de id_Identity
                command.CommandText = _
                                        "insert into ahommov " & _
                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina ) values " & _
                                        "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'R', 'GAR', 'E', 'RETIRO CANCELACION x GARANTIA LIQUIDA', " & lnLibreta & ", '', ''," & _
                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & lntotal_p & ",0,'N'," & _
                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                        lnSaldoAho & ", " & lnSaldoAho & ", 'RT','02',' ',0,'',0," & lnPagina & ")"

                command.ExecuteNonQuery()



                'Elimina Garantia en Climgar

                command.CommandText = _
                                       " Delete Climgar where id= " & id_identity

                command.ExecuteNonQuery()


                '' Inserta Movimiento en Dispersador
                'command.CommandText = _
                '                        " Insert into Dispersa_Garant (ccodcta, cnomcli, nmonto, dfecsis, ccodusu, dfecmod, ldispersa) " & _
                '                        " Values('" & Encabeza_Part(23) & "','" & Encabeza_Part(25) & "'," & Encabeza_Part(19) & ",'" & _
                '                        ldfeccnt & "','" & Encabeza_Part(5) & "',getdate(),0) "
                'command.ExecuteNonQuery()

                ' Attempt to commit the transaction.
                MyTransac.Commit()



            Catch ex As Exception
                lcnumcom = "0"

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lcnumcom


    End Function




End Class
