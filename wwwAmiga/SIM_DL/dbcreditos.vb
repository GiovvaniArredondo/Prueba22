Imports System
Imports System.Text
Imports System.IO


Public Class dbCreditos
    Inherits dbBase

#Region "Propiedades"
    'Chequeo internos de cliente
    Private _chequeo1a As String
    Private _chequeo2b As String
    Private _chequeo3c As String
    Private _chequeo4d As String
    'Chequeo internos del cliente
    Public Property chequeo1a() As String
        Get
            Return _chequeo1a
        End Get
        Set(ByVal Value As String)
            _chequeo1a = Value
        End Set
    End Property

    Public Property chequeo2b() As String
        Get
            Return _chequeo2b
        End Get
        Set(ByVal Value As String)
            _chequeo2b = Value
        End Set
    End Property

    Public Property chequeo3c() As String
        Get
            Return _chequeo3c
        End Get
        Set(ByVal Value As String)
            _chequeo3c = Value
        End Set
    End Property

    Public Property chequeo4d() As String
        Get
            Return _chequeo4d
        End Get
        Set(ByVal Value As String)
            _chequeo4d = Value
        End Set
    End Property

    Private _nintpen As Double
    Private _nmorpen As Double
    Public Property nintpen() As Double
        Get
            Return _nintpen
        End Get
        Set(ByVal Value As Double)
            _nintpen = Value
        End Set
    End Property
    Public Property nmorpen() As Double
        Get
            Return _nmorpen
        End Get
        Set(ByVal Value As Double)
            _nmorpen = Value
        End Set
    End Property

#End Region
    Private _dbcartera As String
    Public Property dbcartera() As String
        Get
            Return _dbcartera
        End Get
        Set(ByVal Value As String)
            _dbcartera = Value
        End Set
    End Property

    Private _dbtipo As String
    Public Property dbtipo() As String
        Get
            Return _dbtipo
        End Get
        Set(ByVal Value As String)
            _dbtipo = Value
        End Set
    End Property
    'propiedades especiales
    '>>>>>>>>>>>>>>>>>>>>>>>>>>
    Private _dbmonto As Double
    Public Property dbmonto() As Double
        Get
            Return _dbmonto
        End Get
        Set(ByVal Value As Double)
            _dbmonto = Value
        End Set
    End Property
    Private _dbsaldo As Double
    Public Property dbsaldo() As Double
        Get
            Return _dbsaldo
        End Get
        Set(ByVal Value As Double)
            _dbsaldo = Value
        End Set
    End Property
    Private _dbafectada As Double
    Public Property dbafectada() As Double
        Get
            Return _dbafectada
        End Get
        Set(ByVal Value As Double)
            _dbafectada = Value
        End Set
    End Property
    Private _dbcasos As Integer
    Public Property dbcasos() As Integer
        Get
            Return _dbcasos
        End Get
        Set(ByVal Value As Integer)
            _dbcasos = Value
        End Set
    End Property
    Private _dbhombres As Integer
    Public Property dbhombres() As Integer
        Get
            Return _dbhombres
        End Get
        Set(ByVal Value As Integer)
            _dbhombres = Value
        End Set
    End Property
    Private _dbmujeres As Integer
    Public Property dbmujeres() As Integer
        Get
            Return _dbmujeres
        End Get
        Set(ByVal Value As Integer)
            _dbmujeres = Value
        End Set
    End Property



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
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As creditos
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If
        '        strSQL.Append(" ccodprd = @ccodprd, ")

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE creditos ")
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
        strSQL.Append(" dfectra = @dfectra, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" cflat = @cflat, ")
        strSQL.Append(" nnumfal = @nnumfal, ")
        strSQL.Append(" ctipgar = @ctipgar, ")
        strSQL.Append(" cnomcli = @cnomcli, ")
        strSQL.Append(" cnudoci = @cnudoci, ")
        strSQL.Append(" ccodlin = @ccodlin, ")
        strSQL.Append(" coficina = @coficina ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(90) As SqlParameter
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
        args(34) = New SqlParameter("@ctipcon", SqlDbType.Decimal)
        args(34).Value = lEntidad.ctipcon
        args(35) = New SqlParameter("@ccodapo", SqlDbType.VarChar)
        args(35).Value = lEntidad.ccodapo
        args(36) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(36).Value = lEntidad.dfecvig
        args(37) = New SqlParameter("@ndeseje", SqlDbType.VarChar)
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
        args(53) = New SqlParameter("@ccondic", SqlDbType.Decimal)
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
        args(61) = New SqlParameter("@lctaret", SqlDbType.VarChar)
        args(61).Value = lEntidad.lctaret
        args(62) = New SqlParameter("@cclacre", SqlDbType.VarChar)
        args(62).Value = lEntidad.cclacre
        args(63) = New SqlParameter("@ccalif", SqlDbType.VarChar)
        args(63).Value = lEntidad.ccalif
        args(64) = New SqlParameter("@nsegvid", SqlDbType.Decimal)
        args(64).Value = lEntidad.nsegvid
        args(65) = New SqlParameter("@cnumexp", SqlDbType.Decimal)
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
        args(71) = New SqlParameter("@csececo", SqlDbType.Decimal)
        args(71).Value = lEntidad.csececo
        args(72) = New SqlParameter("@nciclo", SqlDbType.VarChar)
        args(72).Value = lEntidad.nciclo
        args(73) = New SqlParameter("@ccodsol", SqlDbType.Decimal)
        args(73).Value = lEntidad.ccodsol
        args(74) = New SqlParameter("@nmorak", SqlDbType.VarChar)
        args(74).Value = lEntidad.nmorak
        args(75) = New SqlParameter("@nahoprg", SqlDbType.Decimal)
        args(75).Value = lEntidad.nahoprg
        args(76) = New SqlParameter("@cliquid", SqlDbType.Decimal)
        args(76).Value = lEntidad.cliquid
        args(77) = New SqlParameter("@clineac", SqlDbType.VarChar)
        args(77).Value = lEntidad.clineac
        args(78) = New SqlParameter("@ncapoto", SqlDbType.Decimal)
        args(78).Value = lEntidad.ncapoto
        args(79) = New SqlParameter("@ccontra", SqlDbType.Decimal)
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
        args(88) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(88).Value = lEntidad.cnomcli
        args(89) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(89).Value = lEntidad.cnudoci
        args(90) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(90).Value = lEntidad.ccodlin
        'args(91) = New SqlParameter("@ncosdir", SqlDbType.Decimal)
        'args(91).Value = lEntidad.ncosdir
        'args(92) = New SqlParameter("@ncosind", SqlDbType.Decimal)
        'args(92).Value = lEntidad.ncosind
        'args(93) = New SqlParameter("@nprima", SqlDbType.Decimal)
        'args(93).Value = lEntidad.nprima
        'args(94) = New SqlParameter("@coficina", SqlDbType.VarChar)
        'args(94).Value = lEntidad.coficina


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As creditos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO creditos ")
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
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" cnudoci, ")
        strSQL.Append(" ccodlin) ")
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
        strSQL.Append(" @cnomcli, ")
        strSQL.Append(" @cnudoci, ")
        strSQL.Append(" @ccodlin, ")
        strSQL.Append(" @coficina) ")

        Dim args(90) As SqlParameter
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
        args(13) = New SqlParameter("@ntipperc", SqlDbType.VarChar)
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
        args(27) = New SqlParameter("@nmonapr", SqlDbType.VarChar)
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
        args(35) = New SqlParameter("@ctipcon", SqlDbType.Decimal)
        args(35).Value = lEntidad.ctipcon
        args(36) = New SqlParameter("@ccodapo", SqlDbType.VarChar)
        args(36).Value = lEntidad.ccodapo
        args(37) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(37).Value = lEntidad.dfecvig
        args(38) = New SqlParameter("@ndeseje", SqlDbType.VarChar)
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
        args(62) = New SqlParameter("@lctaret", SqlDbType.VarChar)
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
        args(75) = New SqlParameter("@nmorak", SqlDbType.VarChar)
        args(75).Value = lEntidad.nmorak
        args(76) = New SqlParameter("@nahoprg", SqlDbType.Decimal)
        args(76).Value = lEntidad.nahoprg
        args(77) = New SqlParameter("@cliquid", SqlDbType.Decimal)
        args(77).Value = lEntidad.cliquid
        args(78) = New SqlParameter("@clineac", SqlDbType.VarChar)
        args(78).Value = lEntidad.clineac
        args(79) = New SqlParameter("@ncapoto", SqlDbType.VarChar)
        args(79).Value = lEntidad.ncapoto
        args(80) = New SqlParameter("@ccontra", SqlDbType.Decimal)
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
        args(88) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(88).Value = lEntidad.cnomcli
        args(89) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(89).Value = lEntidad.cnudoci
        args(90) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(90).Value = lEntidad.ccodlin
        'args(91) = New SqlParameter("@ncosdir", SqlDbType.Decimal)
        'args(91).Value = lEntidad.ncosdir
        'args(92) = New SqlParameter("@ncosind", SqlDbType.Decimal)
        'args(92).Value = lEntidad.ncosind
        'args(93) = New SqlParameter("@nprima", SqlDbType.Decimal)
        'args(93).Value = lEntidad.nprima
        'args(94) = New SqlParameter("@coficina", SqlDbType.VarChar)
        'args(94).Value = lEntidad.coficina

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As creditos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM creditos ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function recupera_ds(ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcta = @ccodcta")
        strSQL.Append(" AND CREMCRE.ccodcli = CLIMIDE.ccodcli")
        strSQL.Append(" AND CREMCRE.cnrolin = CRETLIN.cnrolin")
        strSQL.Append(" AND CREMCRE.ccodana = TABTUSU.ccodusu")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Return ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)


    End Function


    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As creditos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI AND CREMCRE.CNROLIN = CRETLIN.CNROLIN AND CREMCRE.cCodAna = TABTUSU.cCodUsu AND")
        strSQL.Append(" CREMCRE.ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Dim dsDatos As DataSet

        dsDatos = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

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
                lEntidad.ncuosug0 = IIf(.Item("ncuosug0") Is DBNull.Value, 0, .Item("ncuosug0"))
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
                lEntidad.ctipcon = IIf(.Item("ctipcon") Is DBNull.Value, "A", .Item("ctipcon"))
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
                lEntidad.ccontra = IIf(.Item("ccontra") Is DBNull.Value, Nothing, .Item("ccontra"))
                lEntidad.dfectra = IIf(.Item("dfectra") Is DBNull.Value, Nothing, .Item("dfectra"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cflat = IIf(.Item("cflat") Is DBNull.Value, Nothing, .Item("cflat"))
                lEntidad.nnumfal = IIf(.Item("nnumfal") Is DBNull.Value, Nothing, .Item("nnumfal"))
                lEntidad.ctipgar = IIf(.Item("ctipgar") Is DBNull.Value, Nothing, .Item("ctipgar"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.cnudoci = IIf(.Item("cnudoci") Is DBNull.Value, Nothing, .Item("cnudoci"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.cNomUsu = IIf(.Item("cNomusu") Is DBNull.Value, Nothing, .Item("cNomusu"))
                lEntidad.nsalcap = IIf(.Item("ncapdes") Is DBNull.Value, 0, .Item("nCapDes")) - IIf(.Item("ncappag") Is DBNull.Value, 0, .Item("ncappag"))
                lEntidad.nsalint = IIf(.Item("nintcal") Is DBNull.Value, 0, .Item("nintcal")) - (IIf(.Item("nintpag") Is DBNull.Value, 0, .Item("nintpag")) + IIf(.Item("nintpen") Is DBNull.Value, 0, .Item("nintpen")))
                lEntidad.nsalmor = IIf(.Item("nintmor") Is DBNull.Value, 0, .Item("nintmor")) - (IIf(.Item("npagcta") Is DBNull.Value, 0, .Item("npagcta")) + IIf(.Item("nmorpag") Is DBNull.Value, 0, .Item("nmorpag")))
                'lEntidad.ncosdir = .Item("ncosdir")
                'lEntidad.ncosind = IIf(.Item("ncosind") Is DBNull.Value, Nothing, .Item("ncosind"))
                'lEntidad.nprima = IIf(.Item("nprima") Is DBNull.Value, Nothing, .Item("nprima"))
                'lEntidad.coficina = IIf(.Item("coficina") Is DBNull.Value, Nothing, .Item("coficina"))
                lEntidad.cdirdom = IIf(.Item("cdirdom") Is DBNull.Value, Nothing, .Item("cdirdom"))
                lEntidad.cfreccap = IIf(.Item("cfreccap") Is DBNull.Value, Nothing, .Item("cfreccap"))
                lEntidad.cfrecint = IIf(.Item("cfrecint") Is DBNull.Value, Nothing, .Item("cfrecint"))
                lEntidad.coficina = IIf(.Item("coficina") Is DBNull.Value, Nothing, .Item("coficina"))
                lEntidad.lsegvid = IIf(.Item("lsegvid") Is DBNull.Value, 0, .Item("lsegvid"))
                lEntidad.canalisis = IIf(.Item("canalisis") Is DBNull.Value, "", .Item("canalisis"))
                lEntidad.ccapacidad = IIf(.Item("ccapacidad") Is DBNull.Value, "", .Item("ccapacidad"))
                lEntidad.ccoddom = IIf(.Item("ccoddom") Is DBNull.Value, "", .Item("ccoddom"))
                lEntidad.csexo = IIf(.Item("csexo") Is DBNull.Value, "X", .Item("csexo"))
                lEntidad.ccodpag = IIf(.Item("ccodpag") Is DBNull.Value, "", .Item("ccodpag"))
                lEntidad.cprograma = IIf(.Item("cprograma") Is DBNull.Value, "", .Item("cprograma"))
                lEntidad.cfueing = IIf(.Item("cfueing") Is DBNull.Value, "", .Item("cfueing"))
                lEntidad.cacta = IIf(.Item("cacta") Is DBNull.Value, "", .Item("cacta"))
                lEntidad.cresolucion = IIf(.Item("cresolucion") Is DBNull.Value, "", .Item("cresolucion"))
                lEntidad.digitaliza_foto = IIf(.Item("digitaliza_foto") Is DBNull.Value, "", .Item("digitaliza_foto"))

            End With
        Catch ex As Exception

        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As creditos
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcta),0) + 1 ")
        strSQL.Append(" FROM creditos ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function


    'cambia la lista por dataset
    Public Function Obtenerdatasetcreditos() As DataSet

        Dim SqlConnection1 As SqlConnection
        Dim SqlDataAdapter1 As SqlDataAdapter
        Dim ds As New DataSet
        Dim SqlSelectCommand1 As SqlCommand

        SqlConnection1 = New SqlConnection
        SqlDataAdapter1 = New SqlDataAdapter
        ds = New DataSet
        SqlConnection1.ConnectionString = Me.cnnStr()
        SqlSelectCommand1 = New SqlCommand
        SqlSelectCommand1.CommandText = "Select cremcre.*, climide.cnomcli,  cretlin.ccodlin, cretlin.cdeslin, tabtusu.cnomusu from CREMCRE, CLIMIDE, CRETLIN,TABTUSU WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI AND CREMCRE.CNROLIN = CRETLIN.CNROLIN AND CREMCRE.CCODANA = TABTUSU.CCODUSU " & " AND CREMCRE.CESTADO = 'F' "
        SqlSelectCommand1.Connection = SqlConnection1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.Fill(ds, "creditos1")

        Return ds

    End Function


    Public Function ObtenerListaPorID() As listacreditos

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacreditos

        Try
            Do While dr.Read()
                Dim mEntidad As New creditos
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
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.cNomUsu = IIf(dr("cnomusu") Is DBNull.Value, Nothing, dr("cnomusu"))
                'mEntidad.ncosdir = IIf(dr("ncosdir") Is DBNull.Value, Nothing, dr("ncosdir"))
                'mEntidad.ncosind = IIf(dr("ncosind") Is DBNull.Value, Nothing, dr("ncosind"))
                'mEntidad.nprima = IIf(dr("nprima") Is DBNull.Value, Nothing, dr("nprima"))
                'mEntidad.coficina = IIf(dr("coficina") Is DBNull.Value, Nothing, dr("coficina"))
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
        strSQL.Append("WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI ")
        strSQL.Append(" AND CREMCRE.CNROLIN = CRETLIN.CNROLIN ")
        strSQL.Append(" AND CREMCRE.CCODANA = TABTUSU.CCODUSU ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds

    End Function


    'pendiente
    Public Function obtenercartera(ByVal ldfechamora As Date, ByVal pccodcta1 As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        Dim ds1 As New DataSet

        strSQL.Append("WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI ")
        strSQL.Append(" AND CREMCRE.CNROLIN = CRETLIN.CNROLIN ")
        strSQL.Append(" AND CREMCRE.CCODANA = TABTUSU.CCODUSU ")
        strSQL.Append(" AND CREMCRE.CCODCTA = CREDKAR.CCODCTA ")
        strSQL.Append(" AND CREDKAR.CDESCOB = 'D' AND CREDKAR.CCONCEP = 'CJ' AND CREDKAR.CESTADO = ' ' ")
        strSQL.Append(" AND CREMCRE.Cestado = " & "'" & "F" & "'")
        strSQL.Append(" AND CREMCRE.dfecvig <= @ldfechamora")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ldfechamora", SqlDbType.DateTime)
        args(0).Value = ldfechamora

        ds1 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds1

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("creditos")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function


    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT CREMCRE.ccodcta, ")
        strSQL.Append(" CREMCRE.cCodofi, ")
        strSQL.Append(" CREMCRE.ccodprd, ")
        strSQL.Append(" CREMCRE.cmoneda, ")
        strSQL.Append(" CREMCRE.cestado, ")
        strSQL.Append(" CREMCRE.ccodcli, ")
        strSQL.Append(" CREMCRE.ccatego, ")
        strSQL.Append(" CREMCRE.ccodfue, ")
        strSQL.Append(" CREMCRE.ccodact, ")
        strSQL.Append(" CREMCRE.ctipcre, ")
        strSQL.Append(" CREMCRE.cdescre, ")
        strSQL.Append(" CREMCRE.ctipcuo, ")
        strSQL.Append(" CREMCRE.ctipper, ")
        strSQL.Append(" CREMCRE.ntipperc, ")
        strSQL.Append(" CREMCRE.cctapre, ")
        strSQL.Append(" CREMCRE.cnorref, ")
        strSQL.Append(" CREMCRE.ccodana, ")
        strSQL.Append(" CREMCRE.dfecasi, ")
        strSQL.Append(" CREMCRE.dfecsol, ")
        strSQL.Append(" CREMCRE.nmonsol, ")
        strSQL.Append(" CREMCRE.nmonsug, ")
        strSQL.Append(" CREMCRE.ncuosug, ")
        strSQL.Append(" CREMCRE.ndessug, ")
        strSQL.Append(" CREMCRE.ndiasug, ")
        strSQL.Append(" CREMCRE.ndiagra, ")
        strSQL.Append(" CREMCRE.dfecven, ")
        strSQL.Append(" CREMCRE.nmonapr, ")
        strSQL.Append(" CREMCRE.nmoncuo, ")
        strSQL.Append(" CREMCRE.nintapr, ")
        strSQL.Append(" CREMCRE.ncuoapr, ")
        strSQL.Append(" CREMCRE.ndiaapr, ")
        strSQL.Append(" CREMCRE.ndesapr, ")
        strSQL.Append(" CRETLIN.cnrolin, ")
        strSQL.Append(" CREMCRE.ntasint, ")
        strSQL.Append(" CREMCRE.ctipcon, ")
        strSQL.Append(" CREMCRE.ccodapo, ")
        strSQL.Append(" CREMCRE.dfecvig, ")
        strSQL.Append(" CREMCRE.ndeseje, ")
        strSQL.Append(" CREMCRE.ngastos, ")
        strSQL.Append(" CREMCRE.ncappag, ")
        strSQL.Append(" CREMCRE.nintpen, ")
        strSQL.Append(" CREMCRE.nintcal, ")
        strSQL.Append(" CREMCRE.nintpag, ")
        strSQL.Append(" CREMCRE.nintmor, ")
        strSQL.Append(" CREMCRE.nmorpag, ")
        strSQL.Append(" CREMCRE.npagcta, ")
        strSQL.Append(" CREMCRE.ncapdes, ")
        strSQL.Append(" CREMCRE.ncapcal, ")
        strSQL.Append(" CREMCRE.ngaspag, ")
        strSQL.Append(" CREMCRE.ndiaatr, ")
        strSQL.Append(" CREMCRE.dfecapr, ")
        strSQL.Append(" CREMCRE.ndiaant, ")
        strSQL.Append(" CREMCRE.natracu, ")
        strSQL.Append(" CREMCRE.natrmax, ")
        strSQL.Append(" CREMCRE.ccondic, ")
        strSQL.Append(" CREMCRE.dultpag, ")
        strSQL.Append(" CREMCRE.dfecter, ")
        strSQL.Append(" CREMCRE.ccodrec, ")
        strSQL.Append(" CREMCRE.nnota1, ")
        strSQL.Append(" CREMCRE.nnota2, ")
        strSQL.Append(" CREMCRE.cmarjud, ")
        strSQL.Append(" CREMCRE.ntipcam, ")
        strSQL.Append(" CREMCRE.lctaret, ")
        strSQL.Append(" CREMCRE.cclacre, ")
        strSQL.Append(" CREMCRE.ccalif, ")
        strSQL.Append(" CREMCRE.nsegvid, ")
        strSQL.Append(" CREMCRE.cnumexp, ")
        strSQL.Append(" CREMCRE.ccodrub, ")
        strSQL.Append(" CREMCRE.cregist, ")
        strSQL.Append(" CREMCRE.dfecadm, ")
        strSQL.Append(" CREMCRE.nintadm, ")
        strSQL.Append(" CREMCRE.nmeses, ")
        strSQL.Append(" CREMCRE.csececo, ")
        strSQL.Append(" CREMCRE.nciclo, ")
        strSQL.Append(" CREMCRE.ccodsol, ")
        strSQL.Append(" CREMCRE.nmorak, ")
        strSQL.Append(" CREMCRE.nahoprg, ")
        strSQL.Append(" CREMCRE.cliquid, ")
        strSQL.Append(" CRETLIN.cdeslin as clineac, ")
        strSQL.Append(" CREMCRE.ncapoto, ")
        strSQL.Append(" CREMCRE.ccontra, ")
        strSQL.Append(" CREMCRE.dfectra, ")
        strSQL.Append(" CREMCRE.ccodusu, ")
        strSQL.Append(" CREMCRE.dfecmod, ")
        strSQL.Append(" CREMCRE.cflag, ")
        strSQL.Append(" CREMCRE.cflat, ")
        strSQL.Append(" CREMCRE.nnumfal, CREMCRE.coficina, cremcre.lsegvid, ")
        strSQL.Append(" CREMCRE.ctipgar, ")
        strSQL.Append(" CLIMIDE.cnomcli, ")
        strSQL.Append(" CLIMIDE.cnudoci, ")
        strSQL.Append(" CRETLIN.ccodlin, ")
        strSQL.Append(" TABTUSU.cNomUsu, ")
        strSQL.Append(" cremcre.ncapdes - ncappag as nsalcap, ")
        strSQL.Append(" cremcre.nintcal-(nintpag+nintpen) as nsalint, ")
        strSQL.Append(" cremcre.nintmor-(nmorpag+npagcta) as nsalmor, ")
        strSQL.Append(" ltrim(CLIMIDE.cdirdom) as cdirdom, ")
        strSQL.Append(" climide.ccoddom, ")
        strSQL.Append(" '                                ' as zona, ")
        strSQL.Append(" '                                ' as cnomact, ")
        strSQL.Append(" '                                ' as cdesfon, ")
        strSQL.Append(" '                                ' as sexo, ")
        strSQL.Append(" '                                ' as cartera, ")
        strSQL.Append(" '                                ' as analista, ")
        strSQL.Append(" climide.csexo, ")
        strSQL.Append(" nintmor-(nmorpag+ npagcta) as nmorak, ")
        strSQL.Append(" 00000000000.00 as ncapita, ")
        strSQL.Append(" 00000000000.00 as nmora, ")
        strSQL.Append(" 00000000000.00 as nintere, ")
        strSQL.Append(" 00000000000.00 as notros, ")
        strSQL.Append(" 00000000000.00 as npago, ")
        strSQL.Append("  '  ' as cconcep, ")
        strSQL.Append(" cremcre.ncapdes - ncappag as nsaldo, ")
        strSQL.Append(" 0000000000 as nmeses, isnull(cremcre.digitaliza_foto,0) as digitaliza_foto, ")
        strSQL.Append(" CRETLIN.lsegdeu, ")
        strSQL.Append(" CRETLIN.lreserva, cremcre.cacta, cremcre.cresolucion, ")
        strSQL.Append(" CRETLIN.lsegdan, climide.csexo ,cremcre.ccodpag, ")
        strSQL.Append(" CRETLIN.ltalona, cremcre.cfreccap, cremcre.cfrecint, cremcre.ccapacidad, cremcre.canalisis, climide.ccoddom, cremcre.ncuosug0, CREMCRE.cprograma, cremcre.cfueing  ")
        strSQL.Append(" FROM CREMCRE,CLIMIDE,CRETLIN, TABTUSU ")
        '*
        'strSQL.Append(" DATEDIFF(cremcre.dfecven, cremcre.dfecapr)/30 as nmeses ")

    End Sub



    Private Sub SelectTabla_con_kardex(ByRef strSQL As StringBuilder)

        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, max(A.csexo) as csexo, MAX(A.cCodcli) as ccodcli, B.ccodcta, 0000 as nciclo, '001' as ccodtrx, 'COBRO DE PRESTAMOS' as cdestrx, 0000000.00 as negreso, 00000000.00 as ncontaI,  00000000.00 as ncontaE, ")
        strSQL.Append("C.dfecsis as dfecvig, B.dfecven, C.cnuming, C.dFecsis, C.Dfecpro, C.cnumrec, ")
        strSQL.Append("B.coficina as cCodOfi,B.coficina, D.cnomofi, B.ccodana, F.cnomusu,  ")
        strSQL.Append("B.ccodsol, H.cnomgru, T.cCodsol as cCodcen, T.cNomgru as cNomcen, L.cnrolin, L.cdeslin,L.ccodlin, ")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'N.A/CHEQUE' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append("WHEN 'P' THEN 'AJUSTES' ")
        strSQL.Append("WHEN 'D' THEN 'DOCUMENTO' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append(" case b.cflat when 'F' then 'FLAT' else 'Sobre Saldo' end as cflat, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(40) as cnomusu, space(60) as cnombco, ")
        strSQL.Append("00000000000.00 as nsaldo, 00000000000.00 as nCapdes, ")
        strSQL.Append("B.ndiaatr as numdiasatraso, ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN (C.CCONCEP = 'IN' and c.ccondic <> 'S') or (C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='2')  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("Nservicio  = SUM(CASE  WHEN C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='1'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVADES  = SUM(CASE  WHEN C.CCONCEP = '02' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("nGasto01 =  SUM(CASE  WHEN C.CCONCEP = '01' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("nGasto02 = SUM(CASE  WHEN C.CCONCEP = '02' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("nGasto03 = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("nGasto04 = SUM(CASE  WHEN C.CCONCEP = '04' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("nGasto05 = SUM(CASE  WHEN C.CCONCEP = '05' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("nGasto06 = SUM(CASE  WHEN C.CCONCEP = '06' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("ccodusu = max(C.ccodusu), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ' and C.CCONCEP <> 'MO' and C.CCONCEP <> 'IN' and C.CCONCEP <> 'EX'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append(" INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin ")
        strSQL.Append(" INNER JOIN CREMSOL H ON B.ccodsol = H.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS T ON H.ccodcen = T.ccodsol  ")
        strSQL.Append(" inner join tabtusu F on B.ccodana = F.ccodusu ")

    End Sub
    Private Sub SelectTabla_con_kardex_fondo(ByRef strSQL As StringBuilder)
        strSQL.Append("SELECT max(A.cnomcli) AS cNomcli,  ")
        strSQL.Append("space(15) as crotativa, max(D.ccodigo) as cCodigo, max(D.cdescri) as cDescri,  ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END),  ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END)  ")
        strSQL.Append("FROM   CLIMIDE A INNER JOIN CREMCRE B ON A.CCODCLI = B.CCODCLI  ")
        strSQL.Append(" INNER JOIN CRETLIN E ON B.cNrolin = E.cnrolin   ")
        strSQL.Append(" INNER JOIN CREDKAR C ON B.CCODCTA = C.CCODCTA ")
        strSQL.Append(" INNER JOIN TABTTAB D ON substring(E.ccodlin,3,2) = D.CCODIGO  ")
    End Sub

    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listacreditos
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu and cremcre.ccodcli = @ccodcli")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = codcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacreditos

        Try
            Do While dr.Read()
                Dim mEntidad As New creditos
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
                mEntidad.ctipgar = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.cnudoci = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.cNomUsu = IIf(dr("cnomusu") Is DBNull.Value, Nothing, dr("cNomusu"))
                mEntidad.nsalcap = IIf(dr("nsalcap") Is DBNull.Value, Nothing, dr("nsalcap"))
                mEntidad.nsalint = IIf(dr("nsalint") Is DBNull.Value, Nothing, dr("nsalint"))
                mEntidad.nsalmor = IIf(dr("nsalmor") Is DBNull.Value, Nothing, dr("nsalmor"))

                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function

    Public Function ObtenerDataSetPorCliente(ByVal codcli As String) As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcli = @ccodcli")
        strSQL.Append(" AND CREMCRE.ccodcli = CLIMIDE.ccodcli")
        strSQL.Append(" AND CREMCRE.cnrolin = CRETLIN.cnrolin")
        strSQL.Append(" AND CREMCRE.ccodana = TABTUSU.ccodusu")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = codcli

        Return ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

    End Function


    'obtiene dataset por creditos


    Public Function ObtenerDataSetPorcredito1(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcli = CLIMIDE.ccodcli")
        strSQL.Append("AND cremcre.cnrolin = cretlin.cnrolin")
        strSQL.Append("AND cremcre.ccodana = tabtusu.ccodusu")
        strSQL.Append("AND CREMCRE.ccodcta = @ccodcta")
        strSQL.Append("AND CREMCRE.dfecvig <= @ldfecha")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ldfecha", SqlDbType.DateTime)
        args(1).Value = ldfecha

        Return ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

    End Function


    Public Function ObtenerDataSetPorcredito11(ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcli = CLIMIDE.ccodcli ")
        strSQL.Append("AND cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append("AND cremcre.ccodana = tabtusu.ccodusu ")
        strSQL.Append("AND CREMCRE.ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Return ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

    End Function


    Public Function ObtenerDataSetvigente() As DataSet
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
        strSQL.Append("AND CREMCRE.cestado = 'F'")


        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    'OBTIENE LA CARTERA CON SUS PAGOS ACTUALIZADOS
    Public Function CARTERA_ACTUALIZADA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.ccodcta, CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.dfecvig,CREMCRE.dfecven, CLIMIDE.cnomcli, ")
        strSQL.Append("CLIMIDE.cdirdom, CLIMIDE.ccodcli, CREMCRE.nahoprg, CREMCRE.cflat, CREMCRE.cestado,")
        strSQL.Append("CREMCRE.ndiaatr, CLIMIDE.csexo, SPACE(6) as categoria, SPACE(1) as categoria2, ")
        strSQL.Append("CREMCRE.ntasint/100 as tasa,CRETLIN.ntasmor/100 as tasamor, ")
        strSQL.Append("CREMCRE.Dfecvig as dfecha, CREMCRE.cnrolin, CREMCRE.ncuoapr,CREMCRE.ccodfue, ")
        strSQL.Append("000000000000.00 as nsalint, 000000000000.00 as nsalintmor, CREMCRE.cOficina, CREMCRE.cCodana,")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS ncappag,")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS nintpag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS nmorpag, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS ncapita, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS nintteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D' AND CNROCUO = '001'  GROUP BY CREDPPG.CCODCTA) AS nintrea, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS dultpag, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS dultpagint, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS dultpagmor, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' and CREDKAR.CESTADO = ' ' AND CREDKAR.CDESCOB = 'D' GROUP BY CREDKAR.CCODCTA) AS ncapdes, ")
        strSQL.Append("cretlin.lsegdeu, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS ncappag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS nintpag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS nmorpag, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS ncapita, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS nintteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NOTRPAG) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnotrpagind, ")
        strSQL.Append("(SELECT COUNT(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS numcuoteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NOTRPAG) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnotrpagplatot, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'SD' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS pnsegdeukar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = '03' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS pnsegdankar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = '01' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS pnreservakar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = '06' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS pntalonakar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'CO' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS pnadmkar, ")
        strSQL.Append("(SELECT DATEDIFF(day, MAX(CREDKAR.DFECPRO), @dfecha2) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS ndifer, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) AS dfecultp ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append("INNER JOIN CRETLIN ON CRETLIN.CNROLIN = CREMCRE.CNROLIN ")
        strSQL.Append("INNER JOIN TABTUSU ON TABTUSU.cCodusu = CREMCRE.cCodana ")
        strSQL.Append("WHERE CREMCRE.dfecvig <= @dfecha2 ")
        'getdate()

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
                'strSQL.Append("AND CREMCRE.cestado = 'F' ")
            Else
                'vigentes
                'strSQL.Append("AND CREMCRE.cestado = 'F' ")
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(5) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(5).Value = lczona

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)


        'finaliza restablece forma de antes


        Dim cuenta As Integer
        cuenta = ds.Tables(0).Rows.Count

        'este proceso es para calcular la mora de interes y los dias de atraso
        '********** VERIFICAR SI ES NECESARIO
        Dim drcreditos As DataRow
        Dim dsplan As New DataSet
        Dim mcredppg As New dbCredppg
        Dim drplan As DataRow
        Dim lncappag As Double
        Dim lncappen As Double
        lncappen = 0
        Dim ldfechapen As Date
        Dim lndias As Double
        Dim lcnomcli As String
        Dim lnintmor As Double
        Dim lncapdes As Double
        Dim lnsalcap As Double
        Dim lnmora As Double
        Dim lnsalint As Double

        Dim ldultpag As Date
        Dim ldfecdes As Date
        Dim lncosind As Double
        Dim lncuoapr As Double
        Dim lnmorpag As Double
        Dim gdfecmor As Date
        Dim gnsummor As Double
        Dim lcnrolin As String
        Dim gnperbas As Double
        Dim lncapsigue As Double
        Dim lccodctaplan As String
        Dim ldfeccalc As Date = dfecha2

        lnsalint = 0
        lnintmor = 0
        lncapdes = 0
        lnsalcap = 0
        lnmora = 0
        Dim lnporc2 As Double
        Dim verifica As Integer

        Dim lnintpag As Double
        Dim lnintcal As Double
        Dim lnmonpag1 As Double
        Dim lccodcta As String

        Dim lcestado As String = "F"

        For Each drcreditos In ds.Tables(0).Rows

            lnporc2 = 0
            If drcreditos("ndiaatr") > 0 Then
                lnporc2 = lnporc2 + 1
            End If
            If IsDBNull(drcreditos("nintteo")) Then
                drcreditos("nintteo") = 0
            End If
            If IsDBNull(drcreditos("nintpag")) Then
                drcreditos("nintpag") = 0
            End If
            If IsDBNull(drcreditos("ndifer")) Then
                drcreditos("ndifer") = 0
            Else 'Verifica creditos saneados
                If IsDBNull(drcreditos("cCondic")) Then
                    drcreditos("cCondic") = "N"
                End If
                If drcreditos("cCondic") = "S" Then
                    Dim lndiast As Integer

                    If IsDBNull(drcreditos("dfectra")) Then
                    Else
                        ldfeccalc = drcreditos("dfectra")
                        lndiast = DateDiff(DateInterval.Day, drcreditos("dfecultp"), drcreditos("dfectra"))
                        If lndiast < 0 Then
                            lndiast = 0
                        End If
                        drcreditos("ndifer") = lndiast
                    End If
                End If
            End If

            If IsDBNull(drcreditos("nahoprg")) Then
                drcreditos("nahoprg") = 0
            End If
            If IsDBNull(drcreditos("tasa")) Then
                drcreditos("tasa") = 0
            End If
            If IsDBNull(drcreditos("ncapita")) Then
                drcreditos("ncapita") = 0
            End If
            If IsDBNull(drcreditos("ncappag")) Then
                drcreditos("ncappag") = 0
            End If
            If IsDBNull(drcreditos("ncapdes")) Then
                drcreditos("ncapdes") = 0
            End If
            If IsDBNull(drcreditos("dultpag")) Then
                drcreditos("dultpag") = drcreditos("dfecvig")
            End If
            If drcreditos("dfecvig") <= #11/24/2007# Then
                lcestado = drcreditos("cestado")
            Else
                If drcreditos("ncapdes") - drcreditos("ncappag") <= 0 Then
                    lcestado = "G"
                Else
                    lcestado = "F"
                End If
            End If


            lncapdes = lncapdes + drcreditos("ncapdes")
            lnsalcap = lnsalcap + (drcreditos("ncapdes") - drcreditos("ncappag"))
            If lnsalcap < 0 Then
                lnsalcap = 0
            End If

            If drcreditos("ncapita") - drcreditos("ncappag") > 0 Then
                lnmora = lnmora + (drcreditos("ncapita") - drcreditos("ncappag"))
            End If
            'para intereses pendientes de pagar
            lnintcal = 0
            lccodcta = drcreditos("ccodcta")
            lnintpag = drcreditos("nintpag")



            '**************************
            Me.mxPendiente(lccodcta, dfecha2)
            If IsDBNull(drcreditos("cflat")) Then
                drcreditos("cflat") = ""
            End If
            If drcreditos("cflat") = "F" Then
                If drcreditos("nintteo") - drcreditos("nintpag") <= 0 Then
                    lnsalint = lnsalint + drcreditos("nintrea")
                Else
                    lnsalint = lnsalint + drcreditos("nintteo") - drcreditos("nintpag")
                End If
            Else
                lnintpag = lnintpag - Me.nintpen
                If drcreditos("ncapdes") - drcreditos("ncappag") > 0 Then
                    'Cobro sobresaldo Mensual

                    lnsalint = lnsalint + Math.Round(((drcreditos("tasa") * drcreditos("ndifer")) * (drcreditos("ncapdes") - drcreditos("ncappag"))) / 360, 2)

                    lnintcal = lnsalint + lnintpag

                    lnsalint = lnintcal - (lnintpag + Me.nintpen)

                End If
            End If

            drcreditos("nsalint") = lnsalint

            '*******************   fin datos manuales de cobro de intereses **********************


            lncappen = 0

            lcnomcli = drcreditos("cnomcli")
            lccodctaplan = drcreditos("ccodcta")
            verifica = mcredppg.ObtenerDataSetPorID2(lccodctaplan, dsplan)
            Dim lnintmor2 As Double
            lnintmor2 = 0
            If verifica = 1 Then

                If IsDBNull(drcreditos("ncappag")) Then
                    lncappag = 0
                Else
                    lncappag = drcreditos("ncappag")
                End If

                'calcula dias de atraso
                lncapsigue = lncappag
                lnintmor2 = lncappag
                For Each drplan In dsplan.Tables(0).Rows
                    If lncappen > lncappag Then
                        drplan("ncappag") = lnintmor2
                        lnintmor2 = 0
                        Exit For
                    Else
                        lncappen = lncappen + drplan("ncapita")
                        ldfechapen = drplan("dfecven")
                        'agregado porque no graba capital pagado
                        If lnintmor2 >= drplan("ncapita") Then
                            drplan("ncappag") = drplan("ncapita")
                            lnintmor2 = lnintmor2 - drplan("ncapita")
                        Else
                            drplan("ncappag") = lnintmor2
                            lnintmor2 = 0
                        End If

                    End If
                Next
                lndias = dfecha2.ToOADate - ldfechapen.ToOADate
                If lndias <= 0 Then
                    lndias = 0
                End If
                drcreditos("ndiaatr") = lndias
                If lndias >= 1 And lndias <= 30 Then  '
                    drcreditos("categoria") = "A"
                End If
                If lndias > 30 And lndias <= 60 Then
                    drcreditos("categoria") = "B"
                End If
                If lndias > 60 And lndias <= 90 Then
                    drcreditos("categoria") = "C"
                End If
                If lndias > 90 And lndias <= 180 Then
                    drcreditos("categoria") = "D"
                End If
                If lndias > 180 Then
                    drcreditos("categoria") = "E"
                End If


                'OBTIENE LA CATEGORIA PARA LA ESTRATIFICACION DE LA MORA

                drcreditos("categoria2") = Me.Califica(lndias)


                lnsalint = 0
                lnintmor = 0
                lncapdes = 0
                lnsalcap = 0
                lnmora = 0

                'retorna mora


                ldfecdes = drcreditos("dfecvig")
                lncapdes = drcreditos("ncapdes")
                '                lncosind = drcreditos("ncosind")
                lncuoapr = drcreditos("ncuoapr")
                If IsDBNull(drcreditos("dultpag")) Then
                    drcreditos("dultpag") = drcreditos("dfecvig")
                End If
                ldultpag = drcreditos("dultpag")

                If IsDBNull(drcreditos("nmorpag")) Then
                    drcreditos("nmorpag") = 0
                End If
                If IsDBNull(drcreditos("ncuoapr")) Then
                    drcreditos("ncuoapr") = 0
                End If
                'If IsDBNull(drcreditos("ncosind")) Then
                '    drcreditos("ncosind") = 0
                'End If
                If IsDBNull(drcreditos("ncapdes")) Then
                    drcreditos("ncapdes") = 0
                End If

                lnmorpag = drcreditos("nmorpag")
                lcnrolin = drcreditos("cnrolin")
                gnsummor = drcreditos("ncappag")
                'estos datos es necesario jalarlos como parametros
                gnperbas = 360
                gdfecmor = "07/01/2004"
                'datos como parametros


                'If drcreditos("ccodcta") = "001242010000000015" Then
                ' lnintmor = 0
                ' End If


                lnintmor = mxCalcMoratory(dsplan, ldultpag, ldfecdes, gdfecmor, lncapdes, lncosind, lncuoapr, dfecha2, gnsummor, lcnrolin, gnperbas)
                drcreditos("nsalintmor") = lnintmor - Me.nmorpen

                '                dsplan.Tables(0).Reset()
                If lcestado <> "F" And lcestado <> "G" Then
                    drcreditos.Delete()
                    ds.Tables(0).GetChanges(DataRowState.Deleted)
                Else
                    If cancela = "1" Then 'son creditos cancelados
                        If (lcestrato <> "*" And lcestrato <> drcreditos("Categoria")) Or lcestado = "F" Then
                            drcreditos.Delete()
                            ds.Tables(0).GetChanges(DataRowState.Deleted)
                        End If
                    Else
                        If (lcestrato <> "*" And lcestrato <> drcreditos("Categoria")) Or lcestado = "G" Then
                            'verifica si ha hecho el ultimo pago en el mes para colocarlo en la cartera
                            'If drcreditos("dultpag") >= dfecha1 And drcreditos("dultpag") <= dfecha2 And lnsalcap <= 0 Then

                            'Else

                            drcreditos.Delete()
                            ds.Tables(0).GetChanges(DataRowState.Deleted)
                            'End If
                        End If

                    End If
                End If
                dsplan.Tables(0).Rows.Clear()

            End If

        Next
        ds.Tables(0).AcceptChanges()

        Return ds
    End Function




    'OBTIENE LA CARTERA CON SUS PAGOS ACTUALIZADOS
    Public Function CARTERA_ACTUALIZADA_POR_CUENTA(ByVal CCODCTA, ByVal ldfecha1) As DataSet
        Dim strSQL As New StringBuilder
        'restablece la forma de antes
        strSQL.Append(" SELECT DISTINCT CREMCRE.ccodcta, ")
        strSQL.Append(" CREMCRE.ncapdes, ")
        strSQL.Append(" CREMCRE.dfecvig, ")
        strSQL.Append(" CREMCRE.dfecven, ")
        strSQL.Append(" CLIMIDE.cnomcli, ")
        strSQL.Append(" CLIMIDE.cdirdom, ")
        strSQL.Append(" CLIMIDE.ccodcli, ")
        strSQL.Append(" CREMCRE.nahoprg, ")
        strSQL.Append(" CREMCRE.cflat, ")
        strSQL.Append(" CREMCRE.ndiaatr, ")
        strSQL.Append(" CLIMIDE.csexo, ")
        strSQL.Append(" ' ' as categoria, ")
        strSQL.Append(" ' ' as categoria2, ")
        strSQL.Append(" CREMCRE.ntasint/100 as tasa, ")
        strSQL.Append(" CRETLIN.ntasmor/100 as tasamor, ")
        strSQL.Append(" @ldfecha1 as dfecha, ")
        strSQL.Append(" CREMCRE.coficina, ")
        strSQL.Append(" CREMCRE.cnrolin, ")
        strSQL.Append(" CREMCRE.ncuoapr, ")
        strSQL.Append(" CREMCRE.ccodfue, ")
        strSQL.Append(" 000000000000.00 as nsalint, ")
        strSQL.Append(" 000000000000.00 as nsalintmor, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS ncappag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'IN' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS nintpag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'MO' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS nmorpag, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @ldfecha1 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS ncapita, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @ldfecha1 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS nintteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @ldfecha1 AND CREDPPG.CTIPOPE <> 'D' AND CNROCUO = '001'  GROUP BY CREDPPG.CCODCTA) AS nintrea, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'KP' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS dultpag, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'IN' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS dultpagint, ")

        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND credkar.cestado =' ' and credkar.cdescob = 'C' and (credkar.cconcep = '03' OR credkar.cconcep = '06' OR credkar.cconcep = '01' OR credkar.cconcep = 'SD' and credkar.cestado = ' ') GROUP BY CREDKAR.CCODCTA) AS dfechaseg, ")


        strSQL.Append(" cretlin.ladmon1, ")
        strSQL.Append(" cretlin.lreserva, ")
        strSQL.Append(" cretlin.lsegdan, ")
        strSQL.Append(" cretlin.ltalona, ")
        strSQL.Append(" cretlin.lsegdeu, ")

        'obtiene un valor de seguros flat
        strSQL.Append("(SELECT SUM(CREDPPG.NSEGDEU) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnsegdeuind, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NSEGDAN) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnsegdanind, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NRESINC) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnreservaind, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NTALONA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pntalonaind, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NOTRPAG) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnotrpagind, ")
        'cuenta cuotas
        strSQL.Append("(SELECT COUNT(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.DFECVEN <= @ldfecha1 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS numcuoteo, ")

        'obtiene suma total de seguros flat
        strSQL.Append("(SELECT SUM(CREDPPG.NSEGDEU) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnsegdeuplatot, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NSEGDAN) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnsegdanplatot, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NRESINC) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnreservaplatot, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NTALONA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pntalonaplatot, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NOTRPAG) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnotrpagplatot, ")

        'obtiene suma de kardex de seguros
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'SD' AND CREDKAR.CDESCOB = 'C' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS pnsegdeukar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = '03' AND CREDKAR.CDESCOB = 'C' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS pnsegdankar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = '01' AND CREDKAR.CDESCOB = 'C' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS pnreservakar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = '06' AND CREDKAR.CDESCOB = 'C' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS pntalonakar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'CO' AND CREDKAR.CDESCOB = 'C' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA) AS pnadmkar, ")


        strSQL.Append("(datediff(@ldfecha1,(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @ldfecha1 AND CREDKAR.CCONCEP = 'KP' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA))) AS ndifer ")

        strSQL.Append(" FROM CREMCRE ,  CLIMIDE,  TABTUSU ,  CRETLIN ")

        strSQL.Append("WHERE CREMCRE.ccodcli = CLIMIDE.ccodcli ")
        strSQL.Append("AND CREMCRE.ccodana = TABTUSU.ccodusu ")
        strSQL.Append("AND CREMCRE.cnrolin = CRETLIN.cnrolin ")
        strSQL.Append("AND CREMCRE.ccodcta = @ccodcta ")
        strSQL.Append("AND CREMCRE.dfecvig <= @ldfecha1 ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = CCODCTA
        args(1) = New SqlParameter("@ldfecha1", SqlDbType.DateTime)
        args(1).Value = ldfecha1

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)


        'finaliza restablece forma de antes


        Dim cuenta As Integer
        cuenta = ds.Tables(0).Rows.Count

        'este proceso es para calcular la mora de interes y los dias de atraso
        '********** VERIFICAR SI ES NECESARIO
        Dim drcreditos As DataRow
        Dim dsplan As New DataSet
        Dim mcredppg As New dbCredppg
        Dim drplan As DataRow
        Dim lncappag As Double
        Dim lncappen As Double
        lncappen = 0
        Dim ldfechapen As Date
        Dim lndias As Double
        Dim lcnomcli As String
        Dim lnintmor As Double
        Dim lncapdes As Double
        Dim lnsalcap As Double
        Dim lnmora As Double
        Dim lnsalint As Double

        Dim ldultpag As Date
        Dim ldfecdes As Date
        Dim lncosind As Double
        Dim lncuoapr As Double
        Dim lnmorpag As Double
        Dim gdfecmor As Date
        Dim gnsummor As Double
        Dim lcnrolin As String
        Dim gnperbas As Double
        Dim lncapsigue As Double
        Dim lccodctaplan As String

        lnsalint = 0
        lnintmor = 0
        lncapdes = 0
        lnsalcap = 0
        lnmora = 0
        Dim lnporc2 As Double
        Dim verifica As Integer

        Dim dfecha2 As Date
        dfecha2 = ldfecha1


        For Each drcreditos In ds.Tables(0).Rows

            lnporc2 = 0
            If drcreditos("ndiaatr") > 0 Then
                lnporc2 = lnporc2 + 1
            End If
            If IsDBNull(drcreditos("nintteo")) Then
                drcreditos("nintteo") = 0
            End If
            If IsDBNull(drcreditos("nintpag")) Then
                drcreditos("nintpag") = 0
            End If
            If IsDBNull(drcreditos("ndifer")) Then
                drcreditos("ndifer") = 0
            End If
            'If IsDBNull(drcreditos("ncosdir")) Then
            '    drcreditos("ncosdir") = 0
            'End If
            'If IsDBNull(drcreditos("nprima")) Then
            '    drcreditos("nprima") = 0
            'End If
            If IsDBNull(drcreditos("nahoprg")) Then
                drcreditos("nahoprg") = 0
            End If
            If IsDBNull(drcreditos("tasa")) Then
                drcreditos("tasa") = 0
            End If
            If IsDBNull(drcreditos("ncapita")) Then
                drcreditos("ncapita") = 0
            End If
            If IsDBNull(drcreditos("ncappag")) Then
                drcreditos("ncappag") = 0
            End If
            If IsDBNull(drcreditos("ncapdes")) Then
                drcreditos("ncapdes") = 0
            End If

            If IsDBNull(drcreditos("nintrea")) Then
                drcreditos("nintrea") = 0
            End If


            lncapdes = lncapdes + drcreditos("ncapdes")
            lnsalcap = lnsalcap + (drcreditos("ncapdes") - drcreditos("ncappag"))

            If drcreditos("ncapita") - drcreditos("ncappag") > 0 Then
                lnmora = lnmora + (drcreditos("ncapita") - drcreditos("ncappag"))
            End If

            'If drcreditos("ccodcta") = "001350011000001282" Then
            'Dim a1 As String
            'a1 = 1
            'End If

            If drcreditos("cflat") = "F" Then
                If drcreditos("nintteo") - drcreditos("nintpag") <= 0 Then
                    lnsalint = lnsalint + drcreditos("nintrea")
                Else
                    lnsalint = lnsalint + drcreditos("nintteo") - drcreditos("nintpag")
                End If
            Else
                'If drcreditos("nprima") = 0 And drcreditos("ncosind") = 0 Then
                '    lnsalint = lnsalint + ((drcreditos("tasa") * drcreditos("ndifer")) / 365) * (drcreditos("ncapdes"))
                'Else
                If drcreditos("ncapdes") - drcreditos("ncappag") > 0 Then
                    'lnsalint = lnsalint + ((drcreditos("tasa") * drcreditos("ndifer")) / 365) * ((drcreditos("ncosdir")) / (drcreditos("ncapdes"))) * (drcreditos("ncapdes") - drcreditos("ncappag"))
                    lnsalint = lnsalint + Math.Round(((drcreditos("tasa") * drcreditos("ndifer")) * (drcreditos("ncapdes") - drcreditos("ncappag"))) / 360, 2)

                End If
                'End If
            End If

            drcreditos("nsalint") = lnsalint

            '*******************   fin datos manuales de cobro de intereses **********************


            lncappen = 0

            lcnomcli = drcreditos("cnomcli")
            lccodctaplan = drcreditos("ccodcta")
            verifica = mcredppg.ObtenerDataSetPorID2(lccodctaplan, dsplan)

            If verifica = 1 Then

                If IsDBNull(drcreditos("ncappag")) Then
                    lncappag = 0
                Else
                    lncappag = drcreditos("ncappag")
                End If

                'calcula dias de atraso
                lncapsigue = lncappag
                For Each drplan In dsplan.Tables(0).Rows
                    If lncappen > lncappag Then
                        Exit For
                    Else
                        lncappen = lncappen + drplan("ncapita")
                        ldfechapen = drplan("dfecven")

                    End If
                Next
                lndias = dfecha2.ToOADate - ldfechapen.ToOADate
                If lndias < 0 Then
                    lndias = 0
                End If
                drcreditos("ndiaatr") = lndias
                If lndias >= 1 And lndias <= 30 Then   '
                    drcreditos("categoria") = "A"
                End If
                If lndias >= 31 And lndias <= 60 Then
                    drcreditos("categoria") = "B"
                End If
                If lndias >= 61 And lndias <= 90 Then
                    drcreditos("categoria") = "C"
                End If
                If lndias >= 91 And lndias <= 180 Then
                    drcreditos("categoria") = "D"
                End If
                If lndias >= 181 Then
                    drcreditos("categoria") = "E"
                End If


                'OBTIENE LA CATEGORIA PARA LA ESTRATIFICACION DE LA MORA


                If lndias < 1 Then
                    drcreditos("categoria2") = "-"
                End If

                If lndias >= 1 And lndias <= 7 Then
                    drcreditos("categoria2") = "A"
                End If
                If lndias >= 8 And lndias <= 15 Then
                    drcreditos("categoria2") = "B"
                End If
                If lndias >= 16 And lndias <= 30 Then
                    drcreditos("categoria2") = "C"
                End If
                If lndias >= 31 And lndias <= 60 Then
                    drcreditos("categoria2") = "D"
                End If
                If lndias >= 61 And lndias <= 90 Then
                    drcreditos("categoria2") = "E"
                End If
                If lndias >= 91 And lndias <= 120 Then
                    drcreditos("categoria2") = "F"
                End If
                If lndias >= 121 And lndias <= 180 Then
                    drcreditos("categoria2") = "G"
                End If

                If lndias >= 181 And lndias <= 360 Then
                    drcreditos("categoria2") = "H"
                End If
                If lndias >= 361 Then
                    drcreditos("categoria2") = "I"
                End If


                lnsalint = 0
                lnintmor = 0
                lncapdes = 0
                lnsalcap = 0
                lnmora = 0

                'retorna mora


                ldfecdes = drcreditos("dfecvig")
                lncapdes = drcreditos("ncapdes")
                lncosind = drcreditos("ncosind")
                lncuoapr = drcreditos("ncuoapr")
                If IsDBNull(drcreditos("dultpag")) Then
                    drcreditos("dultpag") = drcreditos("dfecvig")
                End If
                ldultpag = drcreditos("dultpag")

                If IsDBNull(drcreditos("nmorpag")) Then
                    drcreditos("nmorpag") = 0
                End If
                If IsDBNull(drcreditos("ncuoapr")) Then
                    drcreditos("ncuoapr") = 0
                End If
                If IsDBNull(drcreditos("ncosind")) Then
                    drcreditos("ncosind") = 0
                End If
                If IsDBNull(drcreditos("ncapdes")) Then
                    drcreditos("ncapdes") = 0
                End If

                lnmorpag = drcreditos("nmorpag")
                lcnrolin = drcreditos("cnrolin")
                gnsummor = drcreditos("ncappag")
                'estos datos es necesario jalarlos como parametros
                gnperbas = 360
                gdfecmor = "07/01/2004"

                lnintmor = mxCalcMoratory(dsplan, ldultpag, ldfecdes, gdfecmor, lncapdes, lncosind, lncuoapr, dfecha2, gnsummor, lcnrolin, gnperbas)
                drcreditos("nsalintmor") = lnintmor

                dsplan.Tables(0).Rows.Clear()
            End If

        Next
        Return ds
    End Function

    ' saca los intereses moratorios
    Function mxCalcMoratory(ByVal plan As DataSet, ByVal ldultpag As Date, ByVal pdfecdes As Date, ByVal gdfecmor As Date, ByVal pncapdes As Double, ByVal pncosind As Double, ByVal pncuoapr As Double, ByVal pdfecval As Date, ByVal gnsummor As Double, ByVal pcnrolin As String, ByVal gnperbas As Double) As Double
        Dim filacuotas As DataRow
        Dim lncapita1 As Double
        Dim ldfecpro1 As Date
        Dim cuentafila As Integer
        Dim cuentaf As Integer
        Dim ldfecven1 As Date
        Dim lndifdia As Double
        Dim lntasmor As Double
        Dim ldultpag1 As Date
        Dim lnintmor As Double
        Dim lnTasEfe1 As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double
        Dim lndif As Integer
        Dim lncuodeu As Double
        Dim pngasadm As Double
        Dim lncapsigue As Double

        Dim ldfecven11 As Date
        lnintmor = 0
        lncuodeu = 0
        lndif = 0
        pngasadm = 0
        ldultpag1 = ldultpag
        lncapsigue = gnsummor


        For Each filacuotas In plan.Tables(0).Rows
            'calcula mora de gastos administrativos
            If filacuotas("ctipope") <> "D" And filacuotas("dfecven") <= pdfecval Then
                pngasadm = pngasadm + (pncapdes * pncosind) / pncuoapr
            End If

            ' calcula mora
            If filacuotas("ctipope") <> "D" And filacuotas("nCapita") > filacuotas("nCapPag") Then
                If filacuotas("dfecven") >= pdfecval Then
                    Exit For
                End If
                lncapita1 = filacuotas("nCapita") - filacuotas("nCapPag")
                ldfecpro1 = pdfecval

                'obtiene las lineas de credito

                Dim clslinea As New dbCretlin
                Dim dslinea As New DataSet
                Dim cuenta As Integer
                'dslinea = clslinea.ObtenerDataSetPorcnrolin(pcnrolin)
                cuenta = clslinea.ObtenerDataSetPorID2(pcnrolin, dslinea)
                If cuenta = 1 Then

                    cuentafila = dslinea.Tables(0).Rows.Count

                    cuentaf = 0
                    For i As Integer = cuentafila To 1 Step -1
                        If ldultpag > filacuotas("dFecVen") Then
                            ldfecven1 = ldultpag
                        Else
                            ldfecven1 = filacuotas("dfecven")
                        End If

                        If dslinea.Tables(0).Rows(cuentaf)("dfecvig") > ldfecven1 Then
                            ldultpag1 = dslinea.Tables(0).Rows(cuentaf)("dfecvig")
                        Else
                            ldultpag1 = ldfecven1
                        End If
                        lnfecha1 = ldfecpro1.ToOADate
                        lnfecha2 = ldultpag1.ToOADate
                        lndifdia = lnfecha1 - lnfecha2 'Double.Parse(ldfecpro1) - Double.Parse(ldultpag1)
                        lntasmor = dslinea.Tables(0).Rows(cuentaf)("ntasmor") / (gnperbas * 100)
                        lnTasEfe1 = lntasmor * lndifdia
                        lnintmor = lnintmor + (lnTasEfe1 * lncapita1)
                        If dslinea.Tables(0).Rows(cuentaf)("dfecvig") < filacuotas("dFecVen") Then
                            Exit For
                        End If
                        ldfecpro1 = ldultpag1
                        cuentaf = cuentaf + 1
                    Next
                End If
            End If 'ctipope <> D
        Next 'filacuotas

        Return lnintmor


    End Function


    'OBTIENE PAGOS CON SUS DETALLES DE CARTERA

    Public Function DETALLE_CARTERA_Y_PAGOS(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String, ByVal ctippag As String) As DataSet
        Dim lctipo As String
        Dim lccartera As String = dbcartera
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex(strSQL)



        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and (left(C.cnuming,9) <>'CANC/REFI' or c.cnuming is null)) ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String
        If ctippag <> "*" Then
            strSQL.Append("AND c.ctippag = @ctippag ")
        End If
        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND b.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND b.ccondic = 'S' ")
                Else
                    strSQL.Append("AND b.ccondic <> 'S' ")
                End If
            End If
        End If

        'Cesar Torres 24/01/2016 Agregar el campo ndiaatr
        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,   C.cTippag, B.coficina, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin,L.ccodlin, B.ccodana, F.cnomusu, B.cflat, B.ndiaatr ")
        strSQL.Append("order by C.dfecsis,C.cNuming, C.cnumrec, T.ccodsol,  L.cnrolin ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        args(8) = New SqlParameter("@ctippag", SqlDbType.VarChar)
        args(8).Value = ctippag

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
                lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
                lnciclo = Me.Ciclo(lccodcli, lccodcta)
                ds.Tables(0).Rows(ele)("nciclo") = lnciclo
                ele += 1
            Next
        End If
        Return ds

    End Function

    Public Function CAPITAL_VIGENTE_ASESOR(ByVal ds As DataSet, ByVal ldfecha2 As Date) As DataSet
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lcanalista As String
            Dim capitalVigente As Double

            For Each fila In ds.Tables(0).Rows
                lcanalista = ds.Tables(0).Rows(ele)("ccodusu")
                capitalVigente = Me.CAPITAL_VIGENTE(lcanalista, ldfecha2)
                ds.Tables(0).Rows(ele)("capital_vigente") = capitalVigente
                ele += 1
            Next
        End If
        Return ds
    End Function

    Public Function CAPITAL_PAGADO(ByRef lcanalista As String, ByVal ldfecha2 As Date) As Double 'obtiene el monto del capital pagado de los creditos vigentes
        Dim ds As DataSet
        Dim strSQL As New StringBuilder
        Dim totalPagado As Double

        strSQL.Append(" Select capital_pagos = ISNULL(sum(nmonto),0) from credkar ")
        strSQL.Append(" Where  cdescob = 'C' and cconcep = 'KP' and cestado <> 'X' ")
        strSQL.Append(" AND ccodcta IN (select ccodcta from cremcre where cestado = 'F' and ccodana = @lcanalista)")
        strSQL.Append(" AND dfecpro < @FECHA2")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(0).Value = lcanalista
        args(1) = New SqlParameter("@FECHA2", SqlDbType.DateTime)
        args(1).Value = ldfecha2

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows
                totalPagado = ds.Tables(0).Rows(ele)("capital_pagos")


                ele += 1
            Next
        End If
        Return totalPagado
    End Function

    Public Function CAPITAL_VIGENTE(ByVal lcanalista As String, ByVal ldfecha2 As Date) As Double
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT isnull(sum(nmonto),0) as capital_actual from cremcre a ")
        strSQL.Append("inner join credkar b on a.ccodcta = b.ccodcta ")
        strSQL.Append("where  a.cestado = 'F' and b.cconcep = 'KP' and b.cdescob = 'D' ")
        strSQL.Append("and b.cestado = '' and a.ccodana = @lcanalista AND b.dfecsis <= @FECHA2")

        Dim capitalPagado As Double
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(0).Value = lcanalista
        args(1) = New SqlParameter("@FECHA2", SqlDbType.DateTime)
        args(1).Value = ldfecha2

        Dim dbCapitalVigente As Double

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow

            Dim lccodusu As String
            Dim total_mes_actual As Double
            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows
                lccodusu = lcanalista
                capitalPagado = Me.CAPITAL_PAGADO(lccodusu, ldfecha2)
                dbCapitalVigente = ds.Tables(0).Rows(ele)("capital_actual")
                dbCapitalVigente = dbCapitalVigente - capitalPagado
                ele += 1
            Next
        End If
        Return dbCapitalVigente


    End Function

    '/****** FERNANDO ABREGO RDZ Object:  StoredProcedure [dbo].[Generar_Rpt82]    Script Date: 06/11/2015 19:09:01 ******/

    Public Function Rpt_ComisionMensuales82(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal bandera As String) As DataSet

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Generar_Rpt82"

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha1", SqlDbType.DateTime)
                MyParameters.Value = dfecha1
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha2", SqlDbType.DateTime)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodusu", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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
    '/****** FERNANDO ABREGO RDZ Object:  StoredProcedure [dbo].[Generar_Rpt82]    Script Date: 06/11/2015 19:09:01 ******/

    Public Function Rpt_DPGrupales88(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal bandera As String) As DataSet
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "SeguimientoProducto88"

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha1", SqlDbType.DateTime)
                MyParameters.Value = dfecha1
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha2", SqlDbType.DateTime)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodusu", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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



    Public Function COMISIONES_ASESOR(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal bandera As String) As DataSet
        'Dim cnn As New SqlConnection 'declaracion de conexion
        'Dim cmd As New SqlCommand 'declaracion ejecucion
        'Dim adaptador As New SqlDataAdapter ' declaracion de adapatador de datos
        'Dim datos As SqlDataReader 'solo lectura de datos
        'Dim Rpt82_Almacenado As DataSet 'almacena datos
        ''leer todos los analistas vigentes
        'Try
        '    cnn.ConnectionString = Me.cnnStr
        '    cnn.Open()
        '    cmd.Connection = cnn
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.CommandText = "[Generar_Rpt82]"
        '    cmd.Parameters.Add(New SqlParameter("@fecha1", dfecha1))
        '    cmd.Parameters.Add(New SqlParameter("@fecha2", dfecha2))
        '    cmd.Parameters.Add(New SqlParameter("@ccodofi", lcoficina))
        '    cmd.Parameters.Add(New SqlParameter("@ccodusu", lcanalista))
        '    datos = cmd.ExecuteReader
        '    If datos.Read Then
        '        MsgBox("encontre datos")

        '        adaptador.SelectCommand = cmd
        '        adaptador.Fill(Rpt82_Almacenado)

        '    Else
        '        MsgBox("Revisar please")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'Return Rpt82_Almacenado
    End Function

    Public Function PORCENTAJE_COMISION(ByVal capitalColocadoMesAnterior As Double, ByVal capitalColocadoMesActual As Double) As Double
        Dim porcentajeComision As Double
        If capitalColocadoMesActual >= 50000 Then
            porcentajeComision = 0.01
        Else
            porcentajeComision = 0
        End If

        'If capitalColocadoMesAnterior >= 200000 And capitalColocadoMesActual >= 50000 Then
        '    porcentajeComision = 0.01
        'Else
        '    porcentajeComision = 0
        'End If

        Return porcentajeComision
    End Function

    Public Function COMISION_COLOCACION_ASESOR(ByVal porcentajeComision As Double, ByVal capitalColocadoMesActual As Double) As Double
        Dim comisionColocacion As Double
        comisionColocacion = capitalColocadoMesActual * porcentajeComision
        Return comisionColocacion
    End Function

    'OBTIENE MONTO DE COMISION
    Public Function MONTO_COMISION(ByVal ds As DataSet) As DataSet

        Dim comision As Double
        Dim porcentajeComision As Double
        Dim capitalComisionable As Double
        Dim porcentajeMora As Double

        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow


            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows

                capitalComisionable = ds.Tables(0).Rows(ele)("capital_mes_actual")
                porcentajeMora = ds.Tables(0).Rows(ele)("porcentaje_mora")
                If (porcentajeMora < 3) Then
                    porcentajeComision = 0.02
                Else
                    porcentajeComision = 0.03
                End If
                comision = capitalComisionable * porcentajeComision
                ds.Tables(0).Rows(ele)("comision") = comision
                ele += 1
            Next
        End If
        Return ds

    End Function

    'OBTIENE CAPITAL RECUPERADO

    Public Function CAPITAL_RECUPERADO_ASESOR(ByVal lccodusu As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As Integer

        Dim capitalRecuperado, comisionRecuperado As Double



        Dim strSQL As New StringBuilder





        strSQL.Append(" SELECT  ISNULL(SUM(nmonto), 0) as capital_recuperado  from credkar ")
        strSQL.Append(" INNER JOIN cremcre ON credkar.ccodcta = cremcre.ccodcta ")
        strSQL.Append(" WHERE cconcep = 'KP'  AND cdescob = 'C' AND credkar.cestado = '' and ")
        strSQL.Append(" dfecpro >= @DFECHA1 and dfecpro <= @DFECHA2 ")
        strSQL.Append(" AND credkar.ccodcta IN (select ccodcta from cremcre where cestado = 'F' and ccodana = @lcanalista )")


        Dim transac As String

        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(2).Value = lccodusu

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            ele = 0
            For Each fila In ds.Tables(0).Rows
                capitalRecuperado = ds.Tables(0).Rows(ele)("capital_recuperado")

                ele += 1

            Next
        End If

        Return capitalRecuperado
    End Function


    'OBTIENE COMISION RECUPERADO
    Public Function COMISION_RECUPERADO(ByVal ds As DataSet) As DataSet

        Dim comisionRecuperado As Double
        Dim capitalColocado As Double
        Dim capitalRecuperado As Double
        Dim comisionColocado As Double
        Dim porcentajeMora As Double
        Dim porcentajeComisionRecuperado As Double

        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow


            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows

                comisionColocado = ds.Tables(0).Rows(ele)("comision")

                'Evalua si obtuvo comision por colocacion de creditos

                If comisionColocado > 0 Then
                    porcentajeMora = ds.Tables(0).Rows(ele)("porcentaje_mora")
                    capitalRecuperado = ds.Tables(0).Rows(ele)("capital_recuperado")

                    If porcentajeMora >= 0 And porcentajeMora <= 0.01 Then
                        porcentajeComisionRecuperado = 0.02
                    ElseIf porcentajeMora > 0.01 And porcentajeMora <= 5 Then
                        porcentajeComisionRecuperado = 0.015
                    ElseIf porcentajeMora > 5 And porcentajeMora <= 8 Then
                        porcentajeComisionRecuperado = 0.01
                    ElseIf porcentajeMora > 8 Then
                        porcentajeComisionRecuperado = 0
                        'Si la mora es mayor de 8% no hay comisiones por colocacion y recuperacion
                        ds.Tables(0).Rows(ele)("comision") = 0
                    End If




                Else
                    porcentajeComisionRecuperado = 0

                End If

                'calcula el monto de comision por recuperacion
                comisionRecuperado = porcentajeComisionRecuperado * capitalRecuperado
                ds.Tables(0).Rows(ele)("porComRec") = porcentajeComisionRecuperado * 100
                ds.Tables(0).Rows(ele)("comision_recuperacion") = comisionRecuperado
                ele += 1
            Next
        End If
        Return ds

    End Function
    'OBTIENE CAPITAL RECUPERADO
    Public Function CAPITAL_RECUPERADO(ByVal ds As DataSet, ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As DataSet

        Dim capitalRecuperado As Double
        Dim lcanalista As String
        Dim strSQL As StringBuilder

        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow


            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows

                lcanalista = ds.Tables(0).Rows(ele)("ccodusu")
                capitalRecuperado = CAPITAL_RECUPERADO_ASESOR(lcanalista, ldfecha1, ldfecha2)
                ds.Tables(0).Rows(ele)("capital_recuperado") = capitalRecuperado
                ele += 1
            Next
        End If
        Return ds

    End Function

    'OBTIENE PORCENTAJE DE MORA
    Public Function PORCENTAJE_MORA(ByVal ds As DataSet) As DataSet

        Dim porcentajeMora As Double
        Dim lcanalista As String
        Dim capitalVigente As Double
        Dim capitalEnMora As Double

        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow


            Dim ele As Integer
            For Each fila In ds.Tables(0).Rows

                capitalVigente = ds.Tables(0).Rows(ele)("capital_vigente")
                capitalEnMora = ds.Tables(0).Rows(ele)("mora")
                If (capitalVigente > 0 And capitalEnMora > 0) Then
                    porcentajeMora = (capitalEnMora * 100) / capitalVigente

                Else
                    porcentajeMora = 0
                End If
                ds.Tables(0).Rows(ele)("porcentaje_mora") = porcentajeMora

                ele += 1
            Next
        End If
        Return ds

    End Function


    Public Function NOMBRE_MES(ByVal fecha As Date) As String
        Dim mes As Integer
        Dim nombreMes As String

        mes = Month(fecha)
        nombreMes = UCase(MonthName(mes))
        Return nombreMes
    End Function

    'OBTIENE colocacion en mes actual

    Public Function COMISIONES_ASESOR_MES_ACTUAL(ByVal lccodusu As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As Integer

        Dim total_colocado As Double



        Dim strSQL As New StringBuilder

        'obtiene capital colocado sin comisiones

        strSQL.Append("SELECT sum(creditos.ncapdes-creditos.ngastos) as total_colocado from cremcre as creditos ")
        strSQL.Append(" WHERE creditos.ccodana = @LCANALISTA ")
        strSQL.Append(" AND creditos.cestado = 'F' ")
        strSQL.Append(" AND dfecvig >= @DFECHA1 and dfecvig <= @DFECHA2 ")
        strSQL.Append(" AND creditos.CCODANA = @lcanalista ")
        strSQL.Append(" group by creditos.ccodana")

        Dim transac As String

        Dim a As String
        a = strSQL.ToString

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(2).Value = lccodusu

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                total_colocado = ds.Tables(0).Rows(ele)("total_colocado")
                Return total_colocado

            Next
        End If


    End Function


    Public Function DETALLE_CARTERA_Y_PAGOS_POR_CUENTA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lccodcta As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcli = climide.ccodcli ")
        strSQL.Append("AND CREMCRE.ccodana = tabtusu.ccodusu ")
        strSQL.Append("AND CREMCRE.cnrolin = cretlin.cnrolin ")
        strSQL.Append("AND CREMCRE.ccodcta = credkar.ccodcta ")
        '        strSQL.Append("AND CREDKAR.CDESCOB = @lcdescob ")
        strSQL.Append("AND CREDKAR.cestado = ' ' ")
        strSQL.Append("AND CREDKAR.ccodcta = @lccodcta ")





        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        End If

        If dfecha1 = dfecha2 Then
            strSQL.Append("AND CREDKAR.DFECSIS = @DFECHA1 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC")

        Else
            strSQL.Append("AND credkar.dfecpro >= @DFECHA1 ")
            strSQL.Append("AND credkar.dfecpro <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")

        End If

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccodcta", SqlDbType.VarChar)
        args(6).Value = lccodcta

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function




    'OBTIENE PAGOS CON SUS DETALLES DE CARTERA
    Public Function DETALLE_CARTERA_Y_PAGOS_FONDO(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String) As DataSet
        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex_fondo(strSQL)

        If bandera = "*" Then
            strSQL.Append("  INNER JOIN Tabtofi F ON C.cCodofi = F.cCodofi and left(C.cnuming,9) ='CANC/REFI'  ")
        Else
            strSQL.Append("  INNER JOIN Tabtofi F ON C.cCodofi = F.cCodofi and left(C.cnuming,9) <>'CANC/REFI'  ")
        End If

        strSQL.Append(" WHERE C.cDescob = @lcdescob AND C.cEstado = ' ' ")
        strSQL.Append("  AND D.ccodtab + D.cTipReg = '0331' ")


        If lcanalista <> "*" Then
            strSQL.Append("AND B.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND B.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(E.ccodlin,3,2) = @lclineas ")
        End If

        If dfecha1 = dfecha2 Then
            strSQL.Append("AND C.DFECSIS = @DFECHA1 ")

        Else
            strSQL.Append("AND C.dFecsis >= @DFECHA1 ")
            strSQL.Append("AND C.dFecsis <= @DFECHA2  ")

        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If


        strSQL.Append(" GROUP BY D.CCODIGO ")
        'strSQL.Append(" GROUP BY B.dfecvig, B.dfecven, B.cCodcta,  B.nCapdes, ")
        'strSQL.Append(" C.dfecsis, C.dfecpro, C.cNrodoc, C.cNuming, D.cCodigo ")


        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function

    Public Function ObtenerListadetallada(ByVal dfecha1 As Date, ByVal dfecha2 As Date) As listacreditos

        Dim strSQL As New StringBuilder
        SelectTabla_con_kardex(strSQL)
        strSQL.Append("WHERE CREMCRE.ccodcli = climide.ccodcli ")
        strSQL.Append("AND CREMCRE.ccodana = tabtusu.ccodusu ")
        strSQL.Append("AND CREMCRE.cnrolin = cretlin.cnrolin ")
        strSQL.Append("AND CREMCRE.ccodcta = credkar.ccodcta ")
        strSQL.Append("AND CREDKAR.CDESCOB = 'C' ")
        strSQL.Append("AND credkar.dfecpro >= @DFECHA1 ")
        strSQL.Append("AND credkar.dfecpro <= @DFECHA2 order by ccodcta, dfecsis, cnrodoc")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        Dim ds As DataSet


        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listacreditos

        Try
            Do While dr.Read()
                Dim mEntidad As New creditos
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
                mEntidad.ctipgar = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.cnudoci = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.cNomUsu = IIf(dr("cnomusu") Is DBNull.Value, Nothing, dr("cNomusu"))
                mEntidad.nsalcap = IIf(dr("nsalcap") Is DBNull.Value, Nothing, dr("nsalcap"))
                mEntidad.nsalint = IIf(dr("nsalint") Is DBNull.Value, Nothing, dr("nsalint"))
                mEntidad.nsalmor = IIf(dr("nsalmor") Is DBNull.Value, Nothing, dr("nsalmor"))

                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function



    Public Function Obtenerbusquedacredito(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        If cmetodologia = "1" Then
            strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec, climide.cnudoci ")
            strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu")
            strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
            If ctipo = "1" Then
                strSQL.Append(" and CLIMIDE.cnomcli like" & "'" & "%" & cnombre & "%" & "'")
            ElseIf ctipo = "2" Then
                strSQL.Append(" and CREMCRE.ccodcta like" & "'" & "%" & cnombre & "%" & "'")
            Else
                strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
            End If
            If cbusq = "1" Then
                strSQL.Append(" and CREMCRE.cestado ='A' and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "2" Then
                strSQL.Append(" and CREMCRE.cestado ='C'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "3" Then
                strSQL.Append(" and CREMCRE.cestado ='E'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null)  ")
            ElseIf cbusq = "4" Then
                strSQL.Append(" and CREMCRE.cestado ='F'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "5" Then

            ElseIf cbusq = "6" Then
                strSQL.Append(" and CREMCRE.cestado ='D'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "7" Then
                strSQL.Append(" and CREMCRE.cestado ='G' ")
            End If
            If cflag = "00" Then
            Else
                If cflag = "01" Then 'individual
                    strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
                Else
                    strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
                End If

            End If
            If cCodofi = "001" Then
            Else
                strSQL.Append(" and cremcre.coficina = @cCodofi ")
            End If

        Else
            If cbusq = "3" Then 'Creditos en Estado de Aprobacion para desembolsar
                strSQL.Append("SELECT cremcre.ccodsol as codigo, cremsol.cnomgru as cnomcli, sum(cremcre.ncapdes) as ncapdes ,cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec, space(14) as cnudoci ")
                strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
                strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
                strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
                strSQL.Append(" and CREMCRE.cestado ='E'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
                'If cbusq = "1" Then
                '    strSQL.Append(" and CREMCRE.cestado ='A' ")
                'ElseIf cbusq = "2" Then
                '    strSQL.Append(" and CREMCRE.cestado ='C' ")
                'ElseIf cbusq = "3" Then
                '    strSQL.Append(" and CREMCRE.cestado ='E' ")
                'ElseIf cbusq = "4" Then
                '    strSQL.Append(" and CREMCRE.cestado ='F' ")
                'ElseIf cbusq = "5" Then

                'ElseIf cbusq = "6" Then
                '    strSQL.Append(" and CREMCRE.cestado ='D' ")
                'ElseIf cbusq = "7" Then
                '    strSQL.Append(" and CREMCRE.cestado ='G' ")
                'End If

                If ctipo = "1" Then
                    strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
                ElseIf ctipo = "2" Then
                    strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
                Else
                    strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
                End If
                If cCodofi = "001" Then
                Else
                    strSQL.Append(" and cremcre.coficina = @cCodofi ")
                End If

                strSQL.Append(" GROUP BY cremcre.ccodsol, cremsol.cnomgru, cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec")
            Else
                strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec, climide.cnudoci ")
                strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
                strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
                strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
                If ctipo = "1" Then
                    strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
                ElseIf ctipo = "2" Then
                    strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
                Else
                    strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
                End If
                If cbusq = "1" Then
                    strSQL.Append(" and CREMCRE.cestado ='A'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
                ElseIf cbusq = "2" Then
                    strSQL.Append(" and CREMCRE.cestado ='C'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
                ElseIf cbusq = "3" Then
                    strSQL.Append(" and CREMCRE.cestado ='E'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
                ElseIf cbusq = "4" Then
                    strSQL.Append(" and CREMCRE.cestado ='F'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
                ElseIf cbusq = "5" Then
                ElseIf cbusq = "6" Then
                    strSQL.Append(" and CREMCRE.cestado ='D'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
                End If
                If cCodofi = "001" Then
                Else
                    strSQL.Append(" and cremcre.coficina = @cCodofi ")
                End If

            End If
            If cflag = "00" Then
            Else
                If cflag = "01" Then 'individual
                    strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
                Else
                    strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
                End If

            End If
            If cCodofi = "001" Then
            Else
                strSQL.Append(" and cremcre.coficina = @cCodofi ")
            End If


        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi

        'args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        'args(1).Value = cOficina
        'If nNivel < 9 Then
        '    strSQL.Append(" and  substring(CREMCRE.cCodCta,4,3) = @cOficina ")
        'End If

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function Detalle_Kardex(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        SelectTablakardex(strSQL)
        strSQL.Append(" on cremcre.ccodcta = credkar.ccodcta ")
        strSQL.Append(" WHERE credkar.ccodcta = @lccodcta ")
        strSQL.Append(" AND credkar.cestado = ' ' ")

        'If dfecha1 = dfecha2 Then
        'strSQL.Append("AND b.DFECSIS = @DFECHA1 GROUP BY a.CCODCTA, b.DFECSIS, b.CNRODOC")
        'Else
        'strSQL.Append(" and CREDKAR.DFECPRO >= @dfecha1 ")
        strSQL.Append(" and credkar.dfecpro <= @dfecha2 GROUP BY cremcre.CCODCTA, cremcre.ctipper, cremcre.ndiaapr, credkar.DFECSIS, credkar.CNRODOC, credkar.dfecpro, credkar.ccodusu ")

        'End If

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.Char)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.Char)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.Char)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.Char)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccodcta", SqlDbType.Char)
        args(6).Value = lccodcta

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function

    Public Function Historial_cre1(ByVal lcCodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select CREMCRE.cCodCta, CREMCRE.nCapdes, CREMCRE.cTipPer, CREMCRE.nCuoApr, CREMCRE.cEstado, CREMCRE.CFRECINT, ")
        strSQL.Append("CREMCRE.nDiaApr, 000000 as ndiashis, CREMCRE.nMeses,")
        strSQL.Append("CREMCRE.nTasInt, CREMCRE.cCalif, CREMCRE.cCodcli,")
        strSQL.Append("SPACE(30) As cFormas, ")
        strSQL.Append("SPACE(90) As cGarantia, ")
        strSQL.Append("0000 as nCiclo, cremcre.dfecvig, cremcre.dfecven ")
        strSQL.Append("FROM CREMCRE WHERE cCodcli = @lcCodcli")
        strSQL.Append(" and (CREMCRE.cEstado = 'F' or CREMCRE.cEstado = 'G')")
        strSQL.Append(" ORDER BY CREMCRE.dFecVig")
        Dim a As String
        a = strSQL.ToString

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@lcCodcli", SqlDbType.Char)
        args(0).Value = lcCodcli

        Dim dsh As New DataSet
        dsh = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        '*******
        If dsh.Tables(0).Rows.Count = 0 Then
            Return dsh
        End If
        Dim fila As DataRow
        Dim nCanti As Integer = 0
        Dim pccodcta As String
        Dim pccodcli As String
        Dim pcgarantia As String
        Dim lndiashis As Integer
        Dim ds1 As New DataSet

        ds1.Tables.Clear()
        For Each fila In dsh.Tables(0).Rows
            pccodcta = dsh.Tables(0).Rows(nCanti)("ccodcta")
            pccodcli = dsh.Tables(0).Rows(nCanti)("ccodcli")
            ds1 = Me.Historial_cre2(pccodcta)
            If ds1.Tables(0).Rows.Count = 0 Then
                pcgarantia = "NO DEFINIDA"
            Else
                pcgarantia = ds1.Tables(0).Rows(0)("cgarantia")
            End If
            dsh.Tables(0).Rows(nCanti)("cgarantia") = pcgarantia
            lndiashis = Me.diashis(pccodcta)
            dsh.Tables(0).Rows(nCanti)("ndiashis") = lndiashis
            Try
                If IsDBNull(fila("nmeses")) Then
                    fila("nmeses") = DateDiff(DateInterval.Month, fila("dfecvig"), fila("dfecven"))
                End If
                If fila("nmeses") = 0 Then
                    fila("nmeses") = DateDiff(DateInterval.Month, fila("dfecvig"), fila("dfecven"))
                End If
            Catch ex As Exception

            End Try

            nCanti = nCanti + 1
        Next
        '*******
        Return dsh
    End Function
    'calcula dias de atraso en ultimo pago
    ' a creditos historicos a partir del kardex
    Public Function diashis(ByVal ccodcta As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("select a.ndiaatr from credkar a where a.cnrodoc = (select max(b.cnrodoc)  from credkar b ")
        strSQL.Append("where b.cCodcta = @ccodcta and b.cEstado = ' ' and b.cDescob = 'C' ")
        strSQL.Append("GROUP BY b.cCodcta) and a.cCodcta = @ccodcta and a.cConcep = 'KP' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.Char)
        args(0).Value = ccodcta

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString, args, 0)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("ndiaatr")
        End If

    End Function


    Public Function Historial_cre2(ByVal lccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select CREPGAR.cCodcta, max(ltrim(TABTTAB.cDescri)) as cGarantia ")
        strSQL.Append("FROM CREPGAR, TABTTAB, CLIMGAR ")
        strSQL.Append(" WHERE CREPGAR.cCodcta = @lccodcta ")
        strSQL.Append(" and CLIMGAR.cTipGar = left(TABTTAB.cCodigo,2) ")
        strSQL.Append(" and TABTTAB.cCodTab + TABTTAB.cTipReg = '0741'")
        strSQL.Append(" and CLIMGAR.cCodcli = CREPGAR.cCodcli AND Climgar.cCodGar = CREPGAR.cCodGar")
        strSQL.Append(" GROUP BY CREPGAR.cCodcta")
        Dim a As String
        a = strSQL.ToString

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@lcCodcta", SqlDbType.Char)
        args(0).Value = lccodcta

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function

   

    Private Sub SelectTablakardex(ByRef strSQL As StringBuilder)
        strSQL.Append("Select Cremcre.cCodcta, cremcre.ctipper, credkar.dfecsis, credkar.cnrodoc, 0000.00 as Otros,")
        strSQL.Append(" 00000000000.00 as nsaldo, credkar.ccodusu, ")
        strSQL.Append(" credkar.dfecsis as dfecvig, ")
        strSQL.Append(" credkar.dfecsis as dfecven, ")
        strSQL.Append(" max(credkar.ndiaatr) as ndiaatr,")
        strSQL.Append(" max(credkar.cnuming) as cnuming,")
        strSQL.Append(" max(credkar.cnumrec) as cnumrec,")
        strSQL.Append(" space(60) as cnomcli, ")
        strSQL.Append(" space(12) as ccodcli, ")
        strSQL.Append(" space(10) as cnuming, ")
        strSQL.Append(" credkar.dfecpro, ")
        strSQL.Append(" space(1) as crotativa, ")
        strSQL.Append(" 00000000000.00 as nmonto, ")
        strSQL.Append(" 00000000000.00 as nmoracap, ")
        strSQL.Append(" space(2) as cConcep, ")
        strSQL.Append(" MAX(cremcre.nmoncuo) as nmoncuo, ")
        strSQL.Append(" MAX(cremcre.ncuoapr) as ncuoapr, ")
        strSQL.Append(" MAX(cremcre.ctipper) as ctipper, ")
        strSQL.Append(" MAX(cremcre.ndiaapr) as ndiaapr, ")
        strSQL.Append(" MAX(cremcre.dfecven) as dfecven1, ")
        strSQL.Append("ncapdes = sum(case when credkar.cConcep = 'KP' and credkar.cdescob = 'D'  then credkar.nmonto else 0 end),")
        strSQL.Append("ncapita = sum(case when credkar.cConcep  = 'KP' then credkar.nMonto else 0 end),  ")
        strSQL.Append("nintere = sum(case when credkar.cConcep  = 'IN'  then credkar.nMonto else 0 end),")
        strSQL.Append("nservicio = sum(case when credkar.cConcep  = 'IN' and credkar.ccondic = 'S' then credkar.nMonto else 0 end),")
        strSQL.Append("niva_int = sum(case when credkar.cConcep  = '08'  then credkar.nMonto else 0 end),")
        strSQL.Append("niva_mora = sum(case when credkar.cConcep  = 'IM'  then credkar.nMonto else 0 end),")
        strSQL.Append("notros = sum(case when credkar.cConcep  <> 'KP' and credkar.cConcep <> 'IN' and credkar.cConcep <> 'MO' and credkar.cConcep <> 'CJ' then credkar.nMonto else 0 end),")
        strSQL.Append("nexcedente = sum(case when credkar.cConcep  = 'EX' then credkar.nMonto else 0 end),")
        strSQL.Append("nmora = sum(case when credkar.cConcep  = 'MO' then credkar.nMonto else 0 end),")
        strSQL.Append("npago = sum(case when credkar.cConcep  = 'CJ' then credkar.nMonto else 0 end),")
        strSQL.Append("nsegdeu = sum(case when credkar.cConcep  = 'SD' then credkar.nMonto else 0 end),")
        strSQL.Append("nsegdan = sum(case when credkar.cConcep  = 'GA' then credkar.nMonto else 0 end),")
        strSQL.Append("nreserva = sum(case when credkar.cConcep  = 'RI' or credkar.Cconcep = '01' then credkar.nMonto else 0 end),")
        strSQL.Append("ntalona = sum(case when credkar.cConcep  = 'TA' or credkar.Cconcep = '06' then credkar.nMonto else 0 end),")
        strSQL.Append("ngasadm = sum(case when credkar.cConcep  = 'OP' or credkar.Cconcep = 'CO' then credkar.nMonto else 0 end),  ")
        strSQL.Append("cDescob = MAX(case when credkar.cDescob  = 'D' then 'D' else 'C' end) ")
        strSQL.Append(" from cremcre  join credkar  ")
    End Sub

    Public Function Resumen(ByVal lcCodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select cremcre.cCodCta, cremcre.ccodcli, cremcre.nmonsol, cremcre.nmonsug, cremcre.nmoncuo,")
        strSQL.Append("cremcre.ntasint, climide.cTelDom, climide.cnomcli, climide.cnudoci, climide.cnudotr, climide.npercar, climide.cdirdom, ")
        strSQL.Append("cretlin.cdeslin, cretlin.ccodlin, climide.dnacimi, climide.cestciv, cremcre.csececo, cremcre.ccodact, ")
        strSQL.Append(" climide.ccodpro, climide.cNomFam, climide.cDomFam, climide.cTelFam, climide.cLugFam, climide.cTelLugFam,")
        strSQL.Append("climide.cNomVec	, climide.cDomVec, climide.cTelVec, climide.cLugVec, climide.cTelLugVec,climide.cteldño, ")
        strSQL.Append("climide.cnomcon, climide.cprofcon, climide.cltrab, climide.cdircon, climide.ctelcon, climide.csactcon, climide.ctiempcon, ")
        strSQL.Append("cremcre.cdestino, cremcre.cdescre, climide.cnominv, climide.cdominv, climide.cprefe1, climide.ctelinv, climide.cluginv, climide.ctelluginv ")
        strSQL.Append("from cremcre, climide, cretlin")
        strSQL.Append(" where cremcre.cCodcta = @lccodcta and cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin ")


        Dim a As String
        a = strSQL.ToString

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@lcCodcta", SqlDbType.Char)
        args(0).Value = lcCodcta

        Dim dsRes As New DataSet
        dsRes = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return dsRes
    End Function
    'Iguala a ceros monto sugerencia cada ves que actualizas tasa 
    Public Function IgualaCerosNmonsug(ByVal ccodsol As String) As String
        Dim montoSug As Decimal = 0.0
        Dim strSQL As New StringBuilder
        strSQL.Append(" update cremcre set nmonsug=@montoSug where ccodsol=@ccodsol ")
        Try
            Dim a As String
            a = strSQL.ToString

            Dim args(1) As SqlParameter
            args(0) = New SqlParameter("@montoSug", SqlDbType.Decimal)
            args(0).Value = montoSug
            args(1) = New SqlParameter("@ccodsol", SqlDbType.Char)
            args(1).Value = ccodsol

            sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Return 1

        Catch ex As Exception
            Return 0
        End Try
    End Function


    'Actualiza el producto
    Public Function actualizaCnrolin(ByVal cnrolin As String, ByVal ccodsol As String) As String

        If cnrolin = "" Then
            cnrolin = "0001600"

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append(" update cremcre set cnrolin=@cnrolin where ccodsol=@ccodsol ")
        Try
            Dim a As String
            a = strSQL.ToString

            Dim args(1) As SqlParameter
            args(0) = New SqlParameter("@cnrolin", SqlDbType.Char)
            args(0).Value = cnrolin
            args(1) = New SqlParameter("@ccodsol", SqlDbType.Char)
            args(1).Value = ccodsol

            sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Return 1

        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Multicolector(ByVal pccodana As String, ByVal pdfecini As Date, ByVal pdfecfin As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, cremcre.ccodcli, cremcre.dfecvig, cremcre.nmoncuo as nmoncuo, cremcre.cnrolin, climide.cnomcli, space(128) as cbarra, cretlin.ccodlin ")
        strSQL.Append("from cremcre, climide, cretlin ")
        strSQL.Append("where cremcre.ccodcli = climide.ccodcli  and cremcre.cnrolin = cretlin.cnrolin and  cremcre.ccodana = @pccodana ")
        strSQL.Append(" and cremcre.dfecvig >= @pdfecini and cremcre.dfecvig <= @pdfecfin ")
        strSQL.Append("order by cremcre.dfecvig, climide.cnomcli ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@pccodana", SqlDbType.Char)
        args(0).Value = pccodana

        args(1) = New SqlParameter("@pdfecini", SqlDbType.DateTime)
        args(1).Value = pdfecini

        args(2) = New SqlParameter("@pdfecfin", SqlDbType.DateTime)
        args(2).Value = pdfecfin

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function

    Public Function CreTraslado(ByVal pccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select cremcre.cCodcli, climide.cnomcli, tabtusu.cnomusu,")
        strSQL.Append("tabttab.cdescri as condicion, cremcre.cestado,")
        strSQL.Append("cremcre.ncapdes-cremcre.ncappag as nsalcap,")
        strSQL.Append("cremcre.nintcal-cremcre.nintpag-cremcre.nintpen as nsalint,")
        strSQL.Append("cremcre.nintmor-cremcre.nmorpag-cremcre.npagcta as nsalmor,")
        strSQL.Append("cremcre.ndiaatr, cremcre.ccondic, cretlin.ccodlin ")
        strSQL.Append("from cremcre, climide, tabtusu, tabttab, cretlin ")
        strSQL.Append("where cremcre.ccodcta = @pccodcta ")
        strSQL.Append(" and cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" and cremcre.ccodcli = climide.ccodcli and cremcre.ccodana = tabtusu.ccodusu ")
        strSQL.Append(" and tabttab.ccodtab = '046' and tabttab.ctipreg = '1'  and cremcre.ccondic = tabttab.ccodigo")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodcta", SqlDbType.Char)
        args(0).Value = pccodcta


        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function Trasladar(ByVal aEntidad As entidadBase) As Integer
        Try

            Dim lEntidad As creditos
            Dim lID As Long

            lEntidad = aEntidad


            Dim strSQL As New StringBuilder
            strSQL.Append("UPDATE cremcre ")
            strSQL.Append(" SET ccondic = @cCondic, dFectra = @dfectra, cContra=@cContra ")
            strSQL.Append(" WHERE ccodcta = @ccodcta ")


            Dim args(3) As SqlParameter
            args(0) = New SqlParameter("@ccondic", SqlDbType.VarChar)
            args(0).Value = lEntidad.ccondic
            args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
            args(1).Value = lEntidad.ccodcta
            args(2) = New SqlParameter("@ccontra", SqlDbType.VarChar)
            args(2).Value = lEntidad.ccontra
            args(3) = New SqlParameter("@dfectra", SqlDbType.DateTime)
            args(3).Value = lEntidad.dfectra

            sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub ReclasificacionCartera()
        Dim strSQL As New StringBuilder
        strSQL.Append("Select Cremcre.cCodcta, Cremcre.cCondic, space(1) as cCondicNew, ")
        strSQL.Append("Cremcre.nDiaAtr, Cremcre.cEstado, Cremcre.ncuoApr, Cremcre.cTipPer ")
        strSQL.Append("FROM CREMCRE WHERE Cremcre.cEstado = 'F'  And cremcre.ccondic <> 'S' ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If
        Dim fila As DataRow
        Dim nCanti As Integer = 0

        Dim lcCodcta As String
        Dim lnDiaatr As Integer
        Dim lcCondic As String
        Dim lcCondicNew As String
        Dim lnCuoApr As Integer
        Dim lcTipper As String


        For Each fila In ds.Tables(0).Rows
            lcCodcta = ds.Tables(0).Rows(nCanti)("ccodcta")
            lnDiaatr = ds.Tables(0).Rows(nCanti)("nDiaAtr")
            lcCondic = ds.Tables(0).Rows(nCanti)("cCondic")
            lnCuoApr = ds.Tables(0).Rows(nCanti)("nCuoApr")
            lcTipper = ds.Tables(0).Rows(nCanti)("cTipper")
            If lnDiaatr > 180 Then
                lcCondicNew = "V"
            Else
                lcCondicNew = "N"
            End If
            If lcTipper = "1" And lnCuoApr = 1 And lnDiaatr = 1 Then
                lcCondicNew = "V"
            End If
            Me.ActualizaCondicion(lcCodcta, lcCondicNew)
            nCanti = nCanti + 1
        Next

    End Sub
    Public Function ActualizaCondicion(ByVal pcCodcta As String, ByVal pcConNue As String)
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE Set cCondic = @pcConNue WHERE cCodcta = @pcCodCta")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@pcCodcta", SqlDbType.Char)
        args(0).Value = pcCodcta

        args(1) = New SqlParameter("@pcConNue", SqlDbType.Char)
        args(1).Value = pcConNue

        sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function CalculoMora(ByVal dfecha2 As Date) As Integer
        Dim strSQL As New StringBuilder

        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.ccodcta, CREMCRE.dfecvig,CREMCRE.dfecven, CLIMIDE.cnomcli, ")
        strSQL.Append("CLIMIDE.cdirdom, CLIMIDE.ccodcli, CREMCRE.nahoprg, CREMCRE.cflat, ")
        strSQL.Append("CREMCRE.ndiaatr, CLIMIDE.csexo, SPACE(6) as categoria, SPACE(10) as categoria2, ")
        strSQL.Append("CREMCRE.ntasint/100 as tasa,CRETLIN.ntasmor/100 as tasamor, ")
        strSQL.Append("CREMCRE.Dfecvig as dfecha, CREMCRE.cnrolin, CREMCRE.ncuoapr,CREMCRE.ccodfue, ")
        strSQL.Append("000000000000.00 as nsalint, 000000000000.00 as nsalintmor, CREMCRE.cOficina, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS ncappag,")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' GROUP BY CREDKAR.CCODCTA) AS nintpag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' GROUP BY CREDKAR.CCODCTA) AS nmorpag, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS ncapita, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS nintteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D' AND CNROCUO = '001'  GROUP BY CREDPPG.CCODCTA) AS nintrea, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' GROUP BY CREDKAR.CCODCTA) AS dultpag, ")
        strSQL.Append("(SELECT MAX(CREDKAR.DFECPRO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' GROUP BY CREDKAR.CCODCTA) AS dultpagint, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' GROUP BY CREDKAR.CCODCTA) AS ncapdes, ")
        strSQL.Append("cretlin.lsegdeu, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS ncappag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' GROUP BY CREDKAR.CCODCTA) AS nintpag, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' GROUP BY CREDKAR.CCODCTA) AS nmorpag, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS ncapita, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NINTERE) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA  AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS nintteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NOTRPAG) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.CNROCUO = '001' AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnotrpagind, ")
        strSQL.Append("(SELECT COUNT(CREDPPG.NCAPITA) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND CREDPPG.DFECVEN <= @dfecha2 AND CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS numcuoteo, ")
        strSQL.Append("(SELECT SUM(CREDPPG.NOTRPAG) FROM CREDPPG WHERE CREDPPG.CCODCTA = CREMCRE.CCODCTA   AND   CREDPPG.CTIPOPE <> 'D'  GROUP BY CREDPPG.CCODCTA) AS pnotrpagplatot, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'SD' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS pnsegdeukar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = '03' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS pnsegdankar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = '01' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS pnreservakar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = '06' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS pntalonakar, ")
        strSQL.Append("(SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'CO' AND CREDKAR.CDESCOB = 'C' GROUP BY CREDKAR.CCODCTA) AS pnadmkar, ")
        strSQL.Append("(SELECT DATEDIFF(day, MAX(CREDKAR.DFECPRO), @dfecha2) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' GROUP BY CREDKAR.CCODCTA) AS ndifer ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append("INNER JOIN CRETLIN ON CRETLIN.CNROLIN = CREMCRE.CNROLIN ")
        strSQL.Append("INNER JOIN TABTUSU ON TABTUSU.cCodusu = CREMCRE.cCodana ")
        strSQL.Append("WHERE CREMCRE.dfecvig <= @dfecha2 ")


        strSQL.Append("AND CREMCRE.cestado = 'F' ")

        Dim a As String
        a = strSQL.ToString

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(0).Value = dfecha2

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)


        Dim cuenta As Integer
        cuenta = ds.Tables(0).Rows.Count

        'este proceso es para calcular la mora de interes y los dias de atraso
        '********** VERIFICAR SI ES NECESARIO
        Dim drcreditos As DataRow
        Dim dsplan As New DataSet
        Dim mcredppg As New dbCredppg
        Dim drplan As DataRow
        Dim lncappag As Double
        Dim lncappen As Double
        lncappen = 0
        Dim ldfechapen As Date
        Dim lndias As Double
        Dim lcnomcli As String
        Dim lnintmor As Double
        Dim lncapdes As Double
        Dim lnsalcap As Double
        Dim lnmora As Double
        Dim lnsalint As Double

        Dim ldultpag As Date
        Dim ldfecdes As Date
        Dim lncosind As Double
        Dim lncuoapr As Double
        Dim lnmorpag As Double
        Dim gdfecmor As Date
        Dim gnsummor As Double
        Dim lcnrolin As String
        Dim gnperbas As Double
        Dim lncapsigue As Double
        Dim lccodctaplan As String

        lnsalint = 0
        lnintmor = 0
        lncapdes = 0
        lnsalcap = 0
        lnmora = 0
        Dim lnporc2 As Double
        Dim verifica As Integer
        Dim lccodcta As String
        Dim lndiaatr As Integer

        For Each drcreditos In ds.Tables(0).Rows
            lnporc2 = 0
            If drcreditos("ndiaatr") > 0 Then
                lnporc2 = lnporc2 + 1
            End If
            If IsDBNull(drcreditos("nintteo")) Then
                drcreditos("nintteo") = 0
            End If
            If IsDBNull(drcreditos("nintpag")) Then
                drcreditos("nintpag") = 0
            End If
            If IsDBNull(drcreditos("ndifer")) Then
                drcreditos("ndifer") = 0
            End If

            If IsDBNull(drcreditos("nahoprg")) Then
                drcreditos("nahoprg") = 0
            End If
            If IsDBNull(drcreditos("tasa")) Then
                drcreditos("tasa") = 0
            End If
            If IsDBNull(drcreditos("ncapita")) Then
                drcreditos("ncapita") = 0
            End If
            If IsDBNull(drcreditos("ncappag")) Then
                drcreditos("ncappag") = 0
            End If
            If IsDBNull(drcreditos("ncapdes")) Then
                drcreditos("ncapdes") = 0
            End If

            lncapdes = lncapdes + drcreditos("ncapdes")
            lnsalcap = lnsalcap + (drcreditos("ncapdes") - drcreditos("ncappag"))

            If drcreditos("ncapita") - drcreditos("ncappag") > 0 Then
                lnmora = lnmora + (drcreditos("ncapita") - drcreditos("ncappag"))
            End If


            If drcreditos("cflat") = "F" Then
                If drcreditos("nintteo") - drcreditos("nintpag") <= 0 Then
                    lnsalint = lnsalint + drcreditos("nintrea")
                Else
                    lnsalint = lnsalint + drcreditos("nintteo") - drcreditos("nintpag")
                End If
            Else

                If drcreditos("ncapdes") - drcreditos("ncappag") > 0 Then
                    lnsalint = lnsalint + Math.Round(((drcreditos("tasa") * drcreditos("ndifer")) * (drcreditos("ncapdes") - drcreditos("ncappag"))) / 360, 2)
                End If
            End If

            drcreditos("nsalint") = lnsalint

            '*******************   fin datos manuales de cobro de intereses **********************


            lncappen = 0

            lcnomcli = drcreditos("cnomcli")
            lccodctaplan = drcreditos("ccodcta")

            verifica = mcredppg.ObtenerDataSetPorID2(lccodctaplan, dsplan)

            If verifica = 1 Then

                If IsDBNull(drcreditos("ncappag")) Then
                    lncappag = 0
                Else
                    lncappag = drcreditos("ncappag")
                End If

                'calcula dias de atraso
                lncapsigue = lncappag
                For Each drplan In dsplan.Tables(0).Rows
                    If lncappen > lncappag Then
                        Exit For
                    Else
                        lncappen = lncappen + drplan("ncapita")
                        ldfechapen = drplan("dfecven")

                    End If
                Next
                lndias = dfecha2.ToOADate - ldfechapen.ToOADate
                If lndias < 0 Then
                    lndias = 0
                End If
                drcreditos("ndiaatr") = lndias
                If lndias >= 1 And lndias <= 30 Then
                    drcreditos("categoria") = "A"
                End If
                If lndias >= 31 And lndias <= 60 Then
                    drcreditos("categoria") = "B"
                End If
                If lndias >= 61 And lndias <= 90 Then
                    drcreditos("categoria") = "C"
                End If
                If lndias >= 91 And lndias <= 180 Then
                    drcreditos("categoria") = "D"
                End If
                If lndias >= 181 Then
                    drcreditos("categoria") = "E"
                End If


                'OBTIENE LA CATEGORIA PARA LA ESTRATIFICACION DE LA MORA


                If lndias < 1 Then
                    drcreditos("categoria2") = "-"
                End If

                If lndias >= 1 And lndias <= 7 Then
                    drcreditos("categoria2") = "A"
                End If
                If lndias >= 8 And lndias <= 15 Then
                    drcreditos("categoria2") = "B"
                End If
                If lndias >= 16 And lndias <= 30 Then
                    drcreditos("categoria2") = "C"
                End If
                If lndias >= 31 And lndias <= 60 Then
                    drcreditos("categoria2") = "D"
                End If
                If lndias >= 61 And lndias <= 90 Then
                    drcreditos("categoria2") = "E"
                End If
                If lndias >= 91 And lndias <= 120 Then
                    drcreditos("categoria2") = "F"
                End If
                If lndias >= 121 And lndias <= 180 Then
                    drcreditos("categoria2") = "G"
                End If

                If lndias >= 181 And lndias <= 360 Then
                    drcreditos("categoria2") = "H"
                End If
                If lndias >= 361 Then
                    drcreditos("categoria2") = "I"
                End If


                lnsalint = 0
                lnintmor = 0
                lncapdes = 0
                lnsalcap = 0
                lnmora = 0

                'retorna mora


                ldfecdes = drcreditos("dfecvig")
                lncapdes = drcreditos("ncapdes")
                '                lncosind = drcreditos("ncosind")
                lncuoapr = drcreditos("ncuoapr")
                If IsDBNull(drcreditos("dultpag")) Then
                    drcreditos("dultpag") = drcreditos("dfecvig")
                End If
                ldultpag = drcreditos("dultpag")

                If IsDBNull(drcreditos("nmorpag")) Then
                    drcreditos("nmorpag") = 0
                End If
                If IsDBNull(drcreditos("ncuoapr")) Then
                    drcreditos("ncuoapr") = 0
                End If

                If IsDBNull(drcreditos("ncapdes")) Then
                    drcreditos("ncapdes") = 0
                End If

                lnmorpag = drcreditos("nmorpag")
                lcnrolin = drcreditos("cnrolin")
                gnsummor = drcreditos("ncappag")
                'estos datos es necesario jalarlos como parametros
                gnperbas = 360
                gdfecmor = "07/01/2004"
                'datos como parametros

                lnintmor = mxCalcMoratory(dsplan, ldultpag, ldfecdes, gdfecmor, lncapdes, lncosind, lncuoapr, dfecha2, gnsummor, lcnrolin, gnperbas)
                drcreditos("nsalintmor") = lnintmor

                'Actualiza CREMCRE
                lccodcta = drcreditos("cCodcta")
                lndiaatr = drcreditos("ndiaatr")
                Me.ActualizaDiasAtraso(lccodcta, lndiaatr)


                drcreditos.Delete()
                ds.Tables(0).GetChanges(DataRowState.Deleted)


                dsplan.Tables(0).Rows.Clear()

            End If

        Next
        ds.Tables(0).AcceptChanges()


    End Function
    Public Function ActualizaDiasAtraso(ByVal pcCodcta As String, ByVal pnDiaAtr As Integer)
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CREMCRE Set nDiaAtr = @pnDiaAtr WHERE cCodcta = @pcCodCta")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@pcCodcta", SqlDbType.Char)
        args(0).Value = pcCodcta

        args(1) = New SqlParameter("@pnDiaAtr", SqlDbType.Int)
        args(1).Value = pnDiaAtr

        sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ChequeoInterno(ByVal pcCodcli As String, ByVal pccodcta As String)

        Dim strSQL1 As New StringBuilder
        Dim strSQL2 As New StringBuilder
        Dim strSQL3 As New StringBuilder
        Dim strSQL4 As New StringBuilder
        Dim strSQL5 As New StringBuilder

        Dim ds As New DataSet
        Dim lcComodin As String
        Dim lcCodeudor As String = ""

        strSQL1.Append("Select CREMCRE.cCodcta FROM CREMCRE WHERE CREMCRE.cCodcli = @pcCodcli and CREMCRE.cEstado ='F'")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@pcCodcli", SqlDbType.Char)
        args(0).Value = pcCodcli
        args(1) = New SqlParameter("@lcCodeudor", SqlDbType.Char)
        args(1).Value = ""
        args(2) = New SqlParameter("@pcCodcta", SqlDbType.Char)
        args(2).Value = pccodcta

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL1.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Me.chequeo1a = "CLIENTE NO TIENE CREDITOS VIGENTES"
        Else
            lcComodin = ds.Tables(0).Rows(0)("cCodcta")
            Me.chequeo1a = "CLIENTE TIENE CREDITO VIGENTE Nº " & lcComodin.Trim
        End If
        '-------------------------------------

        ds.Tables.Clear()
        ds.Clear()
        strSQL2.Append("Select CLIMGAR.cCodcli, CREMCRE.cCodcta FROM CLIMGAR, CREMCRE ")
        strSQL2.Append(" WHERE CREMCRE.cCodcli = CLIMGAR.cCodcli and CLIMGAR.cCoduni = @pcCodcli and CREMCRE.cEstado ='F'")
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL2.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Me.chequeo2b = "CLIENTE NO ES CODEUDOR DE NINGUN CREDITO VIGENTE"
            lcCodeudor = ""
        Else
            lcComodin = ds.Tables(0).Rows(0)("cCodcta")
            lcCodeudor = ds.Tables(0).Rows(0)("cCodcli")
            Me.chequeo2b = "CLIENTE ES CODEUDOR DEL CREDITO  Nº " & lcComodin.Trim
        End If

        '-----------------------------------
        ds.Tables.Clear()
        ds.Clear()
        strSQL3.Append("Select CLIMGAR.cCodUni FROM CLIMGAR, CREMCRE ")
        strSQL3.Append(" WHERE CREMCRE.cCodcli = CLIMGAR.cCodcli and CLIMGAR.cCodcli = @pcCodcli  ")
        strSQL3.Append(" and CLIMGAR.cCodUni <>' ' and climgar.ctipgar ='01' GROUP BY CLIMGAR.cCodUni")

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL3.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Me.chequeo3c = "CODEUDOR NO ES CODEUDOR DE NINGUN CREDITO VIGENTE"

        Else
            lcCodeudor = ds.Tables(0).Rows(0)("cCodUni")
            args(1).Value = lcCodeudor

            strSQL4.Append("Select CLIMGAR.cCodcli, CREMCRE.cCodcta FROM CLIMGAR, CREMCRE ")
            strSQL4.Append(" WHERE CREMCRE.cCodcli = CLIMGAR.cCodcli and CLIMGAR.cCoduni = @lcCodeudor and CREMCRE.cEstado ='F'")
            strSQL4.Append(" and CREMCRE.cCodcta <> @pcCodcta")
            ds.Tables.Clear()
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL4.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                Me.chequeo3c = "CODEUDOR NO ES CODEUDOR DE NINGUN CREDITO VIGENTE"
            Else
                lcComodin = ds.Tables(0).Rows(0)("cCodcta")
                Me.chequeo3c = "CODEUDOR ES CODEUDOR DEL CREDITO No." & lcComodin
            End If
        End If

        ds.Tables.Clear()
        ds.Clear()

        strSQL5.Append("Select CREMCRE.cCodcta FROM CREMCRE WHERE CREMCRE.cCodcli = @lcCodeudor and CREMCRE.cEstado ='F'")
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL5.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Me.chequeo4d = "CODEUDOR NO TIENE CREDITOS VIGENTES"
        Else
            lcComodin = ds.Tables(0).Rows(0)("cCodcta")
            Me.chequeo4d = "CODEUDOR TIENE VIGENTE CREDITO No." & lcComodin
        End If

    End Function
    Public Function mxPendiente(ByVal ccodcta As String, ByVal dfecha As Date)
        Dim strSQL As New StringBuilder
        strSQL.Append("Select Cremcre.cCodcta, credkar.cnrodoc, ")
        strSQL.Append(" ncapita = sum(case when credkar.cConcep  = 'KP' then credkar.nMonto else 0 end),  ")
        strSQL.Append(" nintere = sum(case when credkar.cConcep  = 'IN' then credkar.nMonto else 0 end),")
        strSQL.Append("   nmora = sum(case when credkar.cConcep  = 'MO' then credkar.nMonto else 0 end) ")
        strSQL.Append(" from cremcre  join credkar  on cremcre.ccodcta = credkar.ccodcta where cremcre.ccodcta = @ccodcta and credkar.cdescob = 'C'")
        strSQL.Append(" and credkar.dfecpro <= @dfecha GROUP BY cremcre.CCODCTA , CREDKAR.DFECPRO, credkar.CNRODOC, credkar.dfecpro ")
        strSQL.Append(" order by credkar.cnrodoc desc")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.Char)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha
        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lnintpen As Double
        Dim lnmorpen As Double
        Dim fila As DataRow
        Dim elem As Integer

        Dim lncapita As Double = 0
        Dim lnintere As Double = 0
        Dim lnintmor As Double = 0

        If ds.Tables(0).Rows.Count <= 0 Then
            lnintpen = 0
            lnmorpen = 0
        Else
            For Each fila In ds.Tables(0).Rows
                lncapita = ds.Tables(0).Rows(elem)("ncapita")
                lnintere = ds.Tables(0).Rows(elem)("nintere")
                lnintmor = ds.Tables(0).Rows(elem)("nmora")
                If lncapita = 0 Then
                    lnintpen = lnintpen + lnintere
                    lnmorpen = lnmorpen + lnintmor
                Else
                    Exit For
                End If
                elem += 1
            Next
        End If
        Me.nintpen = lnintpen
        Me.nmorpen = lnmorpen
    End Function
    Public Function Ultimopago(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT MAX(CREDKAR.DFECPRO) as dfecpro FROM CREDKAR WHERE  ")
        strSQL.Append("CREDKAR.CCODCTA = @ccodcta  AND CREDKAR.DFECPRO < @dfecha AND CREDKAR.CCONCEP = 'KP' and credkar.cestado = ' ' GROUP BY CREDKAR.CCODCTA ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.Char)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha
        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count = 0 Then
            Return Today()
        Else
            Return ds.Tables(0).Rows(0)("dfecpro")
        End If
    End Function
    Public Function Califica(ByVal lndias As Integer) As String
        Dim lccatego As String
        If lndias < 1 Then
            lccatego = "A"
        End If
        If lndias >= 1 And lndias <= 30 Then
            lccatego = "A1"
        End If
        If lndias >= 31 And lndias <= 60 Then
            lccatego = "B"
        End If
        If lndias >= 61 And lndias <= 90 Then
            lccatego = "C"
        End If
        If lndias >= 91 And lndias <= 180 Then
            lccatego = "D"
        End If
        If lndias > 180 Then
            lccatego = "E"
        End If
        Return lccatego
    End Function
    Public Function ObtenerCicloCancelado(ByVal ccodcli As String) As Integer
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lnciclo As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Select count(ccodcta) as ciclo from cancelados where ccodcli='" & ccodcli & "' group by ccodcli"
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Cancelados")
                For Each fila As DataRow In ds.Tables("Cancelados").Rows
                    lnciclo = fila("ciclo")
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using

        Return lnciclo
    End Function
    Public Function Ciclo(ByVal ccodcli As String, ByVal ccodcta As String) As Integer
        Dim strSQL As New StringBuilder
        Dim nciclo As Integer = 0
        strSQL.Append("SELECT Cremcre.cCodcta FROM cremcre where cremcre.ccodcli = @ccodcli   ")
        strSQL.Append(" order by Cremcre.dfecvig  ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.Char)
        args(0).Value = ccodcli

        args(1) = New SqlParameter("@ccodcta", SqlDbType.Char)
        args(1).Value = ccodcta

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count = 0 Then
            nciclo = 1
        Else
            Dim fila As DataRow
            Dim nelem As Integer = 0

            Dim pccodcta As String
            For Each fila In ds.Tables(0).Rows
                pccodcta = ds.Tables(0).Rows(nelem)("ccodcta")
                nciclo += 1
                If pccodcta = ccodcta Then
                    Exit For
                End If
                nelem += 1
            Next

        End If
        Dim lncican As Integer = 0
        Dim lnciclo As Integer = 0

        lncican = ObtenerCicloCancelado(ccodcli)

        lnciclo = nciclo + lncican

        Return lnciclo
    End Function

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>hackeada por cesar torres
    Public Function CarteraCalculadaFiltrada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String, ByVal cnrolin As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,cremcre.cdescre, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, cremcre.ccodana, tabtusu.cnomusu as cnomana, tabtofi.cnomofi, climide.cclaper, climide.ccodofi, cremcre.nciclo,cremcre.csececo, cremcre.ccontra,cremcre.canalisis,k.cnomusu as cnomoto,")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,00000000.00 as nsalcon, 0000000000 as ncapmora,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, CREMCRE.coficina, CREMCRE.cnrolin, climide.csexo, CREMCRE.CFRECINT,")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append(" case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo, ")
        strSQL.Append(" cremcre.ctipgar, climide.cnudoci, climide.cnudotr,cremcre.ctipcuo,cremcre.cflat, substring(cretlin.ccodlin,3,2) as ffondos,substring(cretlin.ccodlin,5,2) as ctipmet, tabttab.cdescri , cretlin.ccodlin, cremcre.nmoncuo, cretlin.ntasmor ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN tabtusu ON cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" INNER JOIN tabtusu k ON cremcre.canalisis = k.ccodusu  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" INNER JOIN TABTOFI ON CREMCRE.COFICINA = TABTOFI.CCODOFI  ")
        strSQL.Append(" inner join tabttab on substring(cretlin.ccodlin,3,2) = left(tabttab.ccodigo,2) and tabttab.ccodtab ='033' ")

        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If



        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona ")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If


        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If

        If cnrolin <> "*" Then
            strSQL.Append(" AND cremcre.cnrolin = @cnrolin")

        End If
        strSQL.Append(" ORDER BY cremcre.coficina, cremcre.ccodana, cremcre.ccodcta, cremcre.dfecvig, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString


        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto
        args(8) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(8).Value = cnrolin


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function


    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Solo Para Conocedores
    Public Function CarteraCalculada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,cremcre.cdescre, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, cremcre.ccodana, tabtusu.cnomusu as cnomana, tabtofi.cnomofi, climide.cclaper, climide.ccodofi, cremcre.nciclo,cremcre.csececo, cremcre.ccontra,cremcre.canalisis,k.cnomusu as cnomoto,")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,00000000.00 as nsalcon, 0000000000 as ncapmora,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, CREMCRE.coficina, CREMCRE.cnrolin, climide.csexo, CREMCRE.CFRECINT,")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append(" case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo, ")
        strSQL.Append(" cremcre.ctipgar, climide.cnudoci, climide.cnudotr,cremcre.ctipcuo,cremcre.cflat, substring(cretlin.ccodlin,3,2) as ffondos,substring(cretlin.ccodlin,5,2) as ctipmet, tabttab.cdescri , cretlin.ccodlin, cremcre.nmoncuo, cretlin.ntasmor ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN tabtusu ON cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" INNER JOIN tabtusu k ON cremcre.canalisis = k.ccodusu  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" INNER JOIN TABTOFI ON CREMCRE.COFICINA = TABTOFI.CCODOFI  ")
        strSQL.Append(" inner join tabttab on substring(cretlin.ccodlin,3,2) = left(tabttab.ccodigo,2) and tabttab.ccodtab ='033' ")

        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If



        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona ")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If


        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY cremcre.coficina, cremcre.ccodana, cremcre.ccodcta, cremcre.dfecvig, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString


        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function AgendaComite(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String, ByVal lnnivel As Integer, ByVal limite1 As Double, ByVal limite2 As Double) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("select cremcre.ccodcta, cremcre.ccodana, cremcre.dfecasi, climide.cnomcli, cremcre.ctipper, cremcre.ndiasug, cremcre.ccodcli, tabtusu.cnomusu, cremcre.nmonsug as nmonsol, cremcre.nmoncuo, cremcre.ncuosug,")
        strSQL.Append(" space(60) as cperiodo, space(60) as cgarantia, CREMCRE.ntasint, cretlin.cnrolin, cretlin.cdeslin, cremcre.dfecsol, ")
        strSQL.Append(" 000 as nciclo, climide.cteldom, ltrim(tabttab.cdescri) as cdescri, cremcre.dfecvig, climide.cdirdom, 0000 as ndias ")
        strSQL.Append(" FROM tabtusu, cremcre, cretlin, tabttab, climide ")
        strSQL.Append(" where tabtusu.ccodusu = cremcre.ccodana and ")
        strSQL.Append("  cremcre.ccodcli = climide.ccodcli and ")
        strSQL.Append("  cremcre.cnrolin  = cretlin.cnrolin and ")
        strSQL.Append("  tabttab.ccodtab = '033' and tabttab.ctipreg = '1' and ")
        strSQL.Append("  left(tabttab.ccodigo,2) = substring(cretlin.ccodlin,3,2) and ")
        strSQL.Append("  cremcre.cestado = 'C' and cremcre.ccodrec = ' ' ")
        strSQL.Append(" and cremcre.dfecsol >=@dfecha1 and cremcre.dfecsol <=@dfecha2 ")

        'If lnnivel = 1 Then
        strSQL.Append(" and cremcre.nmonsug > @limite1 and cremcre.nmonsug <= @limite2 ")
        'ElseIf lnnivel = 2 Then
        'Else
        '    strSQL.Append(" and cremcre.nmonsug >5000 ")
        'End If
        'se filtra solo para creditos cancelados y/o vencimiento

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        strSQL.Append(" ORDER BY CREMCRE.cCodAna, cremcre.dfecsol,  CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString



        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lnnivel", SqlDbType.Int)
        args(6).Value = lnnivel
        args(7) = New SqlParameter("@limite1", SqlDbType.Decimal)
        args(7).Value = limite1
        args(8) = New SqlParameter("@limite2", SqlDbType.Decimal)
        args(8).Value = limite2

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function RMunicipios(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT a.ccodzon, a.cdeszon as Municipio, ")
        strSQL.Append("(select b.cdeszon  from tabtzon b where ctipzon ='1' and left(b.ccodzon,2) = left(a.ccodzon,2)) as Departamento,")
        strSQL.Append("(select b.ccodzon  from tabtzon b where ctipzon ='1' and left(b.ccodzon,2) = left(a.ccodzon,2)) as ccoddep,")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM tabtzon a ")
        strSQL.Append(" INNER JOIN CLIMIDE c ON left(c.cCoddom,4) = left(a.cCodzon,4) ")
        strSQL.Append(" WHERE  a.ctipzon ='2'  ")
        strSQL.Append(" order by a.cdeszon ")


        'If lcanalista <> "*" Then
        'strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        'End If
        'If lcoficina <> "*" Then
        'strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        'End If


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function

    Public Function MontoTotal(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        ds = Me.CarteraCalculada3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As Double
        Dim ds As New DataSet
        '        ds = Me.SelectMultiple(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        ds = Me.CarteraCalculada3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function

    Public Function TotalCreditos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As Integer
        Dim ds As New DataSet
        'ds = Me.SelectMultiple(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        ds = Me.CarteraCalculada3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function Saldoafectado(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        ds = Me.CarteraCalculada3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 0 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As Integer
        Dim ds As New DataSet
        'ds = Me.SelectMultiple(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        ds = Me.CarteraCalculada3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodzon)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 0 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function

    Public Function SelectMultiple(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodcta, CREMCRE.cestado, 00000 as ndias,CREMCRE.dfecvig,")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")

        strSQL.Append(" WHERE left(CLIMIDE.cCoddom,4) = @lccodzon ")
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If

        strSQL.Append(" group BY CREMCRE.cCodcta, CREMCRE.cEstado, CREMCRE.dfecvig ")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodzon", SqlDbType.VarChar)
        args(6).Value = lccodzon


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lncre As Integer = 0

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        lncre = ds.Tables(0).Rows.Count
        ds1 = Me.ValidaEstado(ds, dfecha2)
        lncre = ds1.Tables(0).Rows.Count
        Return ds1
    End Function
    Public Function RMontos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT a.rangos, a.ndesde, a.nhasta, ")
        strSQL.Append(" 0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM rangosmontos a ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function SelectMultiple2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT CREMCRE.cCodcta, CREMCRE.cestado, 00000 as ndias,CREMCRE.dfecvig,")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")

        strSQL.Append(" WHERE CREMCRE.nCapdes >=@lndesde and CREMCRE.nCapdes <=@lnhasta ")
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If

        strSQL.Append(" group BY CREMCRE.cCodcta, CREMCRE.cEstado, CREMCRE.dfecvig ")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lndesde", SqlDbType.Decimal)
        args(6).Value = lndesde
        args(7) = New SqlParameter("@lnhasta", SqlDbType.Decimal)
        args(7).Value = lnhasta


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1

    End Function
    Public Function TotalCreditos2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Integer
        Dim ds As New DataSet
        '        ds = Me.SelectMultiple2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        '        ds = Me.SelectMultiple2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Integer
        Dim ds As New DataSet
        'ds = Me.SelectMultiple2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0

        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function
    Public Function SelectMultiple3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT CREMCRE.cCodcta, CREMCRE.cestado, 00000 as ndias,CREMCRE.dfecvig,")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")

        strSQL.Append(" WHERE round(DATEDIFF(month, cremcre.dfecvig, cremcre.dfecven),0) >=@lndesde and ")
        strSQL.Append("  round(DATEDIFF(month, cremcre.dfecvig, cremcre.dfecven),0) <=@lnhasta  ")
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If

        strSQL.Append(" group BY CREMCRE.cCodcta, CREMCRE.cEstado, CREMCRE.dfecvig ")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lndesde", SqlDbType.Decimal)
        args(6).Value = lndesde
        args(7) = New SqlParameter("@lnhasta", SqlDbType.Decimal)
        args(7).Value = lnhasta


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)

        Return ds1

    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function TotalCreditos3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Integer
        Dim ds As New DataSet
        '        ds = Me.SelectMultiple3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada5(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada5(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada5(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        'ds = Me.SelectMultiple3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada5(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0

        Dim pccodcta As String
        Dim pndias As Integer
        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Integer
        Dim ds As New DataSet
        'ds = Me.SelectMultiple3(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada5(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0

        Dim pccodcta As String
        Dim pndias As Integer
        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function
    Public Function RPlazos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT a.rangos, a.ndesde, a.nhasta, ")
        strSQL.Append(" 0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM rangosmeses a ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function diasAtraso(ByVal pccodcta As String, ByVal pncappag As Double, ByVal pdfecsis As Date) As Integer
        Dim lncappen As Double = 0
        Dim ldfechapen As Date
        Dim lndias As Integer = 0
        Dim lncapita As Double = 0
        Dim strSQL As New StringBuilder
        Dim dsplan As New DataSet
        strSQL.Append("select * from credppg where ctipope = 'N' and ccodcta =@pccodcta order by dfecven")
        Dim args(0) As SqlParameter
        Dim drplan As DataRow
        args(0) = New SqlParameter("@pccodcta", SqlDbType.Char)
        args(0).Value = pccodcta
        dsplan = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsplan.Tables(0).Rows.Count = 0 Then
            Return 0
        End If

        For Each drplan In dsplan.Tables(0).Rows

            If Math.Round(lncappen, 2) > Math.Round(pncappag, 2) Then
                Exit For
            Else
                lncapita = drplan("ncapita")
                lncappen = lncappen + lncapita
                ldfechapen = drplan("dfecven")
            End If
        Next
        lndias = pdfecsis.ToOADate - ldfechapen.ToOADate
        If lndias < 0 Then
            lndias = 0
        End If
        Return lndias
    End Function
    Public Function RReserva(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("select b.ccodofi, b.cnomofi, a.ccodigo, a.cdescri, a.nnumtab,  0000000000000.00 as nmonto, ")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec, ")
        strSQL.Append(" 000.00 as npromedio")
        strSQL.Append(" from tabttab a , tabtofi b where a.ccodtab = '101' and a.ctipreg = '1' order by b.ccodofi, a.ccodigo ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function RporFondos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("select a.ccodigo, a.cdescri, a.nnumtab,  0000000000000.00 as nmonto, ")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec, ")
        strSQL.Append(" 000.00 as npromedio")
        strSQL.Append(" from tabttab a where a.ccodtab = '033' and ctipreg = '1' order by ccodigo ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function TotalCreditos4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Integer
        Dim ds As New DataSet
        Dim lntotalcre As Integer = 0
        '        ds = Me.SelectMultiple4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        End If
        Dim fila As DataRow
        Dim pccodcta As String
        Dim pndias As Integer
        Dim elem As Integer = 0
        Dim pncappag As Double = 0

        For Each fila In ds.Tables(0).Rows
            pccodcta = ds.Tables(0).Rows(elem)("ccodcta")
            pncappag = ds.Tables(0).Rows(elem)("ncappag")
            pndias = Me.diasAtraso(pccodcta, pncappag, dfecha2)
            If pndias >= lndesde And pndias <= lnhasta Then
                lntotalcre = lntotalcre + 1
            End If
            elem += 1
        Next

        Return lntotalcre
    End Function
    Public Function TotalCreditos6(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        Dim lntotalcre As Integer = 0
        '        ds = Me.SelectMultiple4(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lndesde, lnhasta)
        ds = Me.CarteraCalculada6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        End If
        Dim fila As DataRow
        Dim pccodcta As String
        Dim pndias As Integer
        Dim elem As Integer = 0
        Dim pncappag As Double = 0

        For Each fila In ds.Tables(0).Rows
            pccodcta = ds.Tables(0).Rows(elem)("ccodcta")
            pncappag = ds.Tables(0).Rows(elem)("ncappag")

            lntotalcre = lntotalcre + 1
            elem += 1
        Next

        Return lntotalcre
    End Function
    Public Function MontoTotal4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pncappag = ds.Tables(0).Rows(elem1)("ncappag")
                pndias = Me.diasAtraso(pccodcta, pncappag, dfecha2)
                If pndias >= lndesde And pndias <= lnhasta Then
                    lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function MontoTotal6(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows

                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")

                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If pndias >= lndesde And pndias <= lnhasta Then
                    lnmonto = lncapdes - lncappag
                    lnmontot = lnmontot + lnmonto
                End If

                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal6(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")

                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto


                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function

    Public Function Saldoafectado4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag

                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")

                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If pndias >= lndesde And pndias <= lnhasta Then
                    If lnmonto > lnsalteo And pndias > 30 Then
                        lnmontot = lnmontot + lnmonto
                    End If
                End If

                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado6(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag

                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")

                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto

                End If

                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada2(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera)

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0


        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag

                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")

                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If pndias >= lndesde And pndias <= lnhasta Then
                    If lnmonto > lnsalteo And pndias > 0 Then
                        lncasos += 1
                    End If
                End If

                elem1 += 1
            Next
        End If
        Return lncasos
    End Function
    Public Function casosafectado6(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada6(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim pccodcta As String
        Dim pndias As Integer
        Dim pncappag As Double = 0


        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag

                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")

                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If


                elem1 += 1
            Next
        End If
        Return lncasos
    End Function

    Public Function SelectMultiple4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT CREMCRE.cCodcta, CREMCRE.cestado, 00000 as ndias,CREMCRE.dfecvig,")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")

        strSQL.Append(" WHERE CREMCRE.nCapdes >=0 ")
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If

        strSQL.Append(" group BY CREMCRE.cCodcta, CREMCRE.cEstado, cremcre.dfecvig ")

        Dim a As String
        Dim ds As New DataSet
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lndesde", SqlDbType.Decimal)
        args(6).Value = lndesde
        args(7) = New SqlParameter("@lnhasta", SqlDbType.Decimal)
        args(7).Value = lnhasta

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        'proceso Depurador
        Dim ds1 As New DataSet
        ds1 = ValidaEstado(ds, dfecha2)

        Return ds1
    End Function
    Public Function ValidaEstado(ByVal dsvalida As DataSet, ByVal dfecha2 As Date) As DataSet
        Dim lcestado As String
        If dsvalida.Tables(0).Rows.Count = 0 Then
        Else
            Dim nelem As Integer
            Dim fila As DataRow
            Dim lncapdes As Double = 0
            Dim lncappag As Double = 0
            Dim lnsaldo As Double = 0
            Dim ecredkar As New dbCredkar
            Dim ldultpag As Date


            For Each fila In dsvalida.Tables(0).Rows
               
                If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncapdes")) Then
                    dsvalida.Tables(0).Rows(nelem)("ncapdes") = 0
                End If
                If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncappag")) Then
                    dsvalida.Tables(0).Rows(nelem)("ncappag") = 0
                End If
                lncapdes = dsvalida.Tables(0).Rows(nelem)("ncapdes")
                lncappag = dsvalida.Tables(0).Rows(nelem)("ncappag")
                lnsaldo = lncapdes - lncappag
                If Math.Round(lnsaldo, 2) <= 0 Then
                    dsvalida.Tables(0).Rows(nelem)("cEstado") = "G"
                    lcestado = "G"
                Else
                    dsvalida.Tables(0).Rows(nelem)("cEstado") = "F"
                    lcestado = "F"
                End If

                If lcestado.Trim = "G" Then
                    dsvalida.Tables(0).Rows(nelem).Delete()
                    dsvalida.Tables(0).GetChanges(DataRowState.Deleted)
                End If
                nelem += 1
            Next
        End If
        dsvalida.Tables(0).AcceptChanges()
        Return dsvalida
    End Function

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function CarteraCalculada2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append(" case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin  ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        'strSQL.Append(" INNER JOIN CREDKAR ON CREMCRE.ccodcta = CREDKAR.cCodcta ")
        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)
        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If


        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        ds1 = Me.ValidaEstado(ds, dfecha2)

        Return ds1
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function CarteraCalculada3(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodzon As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        strSQL.Append(" and left(CLIMIDE.cCoddom,len(rtrim(ltrim(@lccodzon)))) = @lccodzon ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(cretlin.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodzon", SqlDbType.VarChar)
        args(6).Value = lccodzon


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function CarteraCalculada4(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append(" INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin  ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        strSQL.Append(" and CREMCRE.nCapdes >=@lndesde and CREMCRE.nCapdes <=@lnhasta ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lndesde", SqlDbType.Decimal)
        args(6).Value = lndesde
        args(7) = New SqlParameter("@lnhasta", SqlDbType.Decimal)
        args(7).Value = lnhasta

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function CarteraCalculada5(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lndesde As Double, ByVal lnhasta As Double) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        strSQL.Append(" and round(DATEDIFF(month, cremcre.dfecvig, cremcre.dfecven),0) >=@lndesde and ")
        strSQL.Append("  round(DATEDIFF(month, cremcre.dfecvig, cremcre.dfecven),0) <=@lnhasta  ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(cretlin.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lndesde", SqlDbType.Decimal)
        args(6).Value = lndesde
        args(7) = New SqlParameter("@lnhasta", SqlDbType.Decimal)
        args(7).Value = lnhasta

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function CarteraCalculada6(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append(" INNER JOIN CRETLIN ON CRETLIN.cnrolin = CREMCRE.cNrolin ")
        strSQL.Append(" and substring(CRETLIN.ccodlin,3,2) = @lccodigo ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")

        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        'If lclineas <> "*" Then
        'strSQL.Append("AND CREMCRE.cnrolin = @lclineas ")
        'End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)

        Return ds1
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ActualizaCalificacion(ByVal aEntidad As entidadBase) As Integer
        Try

            Dim lEntidad As creditos
            Dim lID As Long

            lEntidad = aEntidad


            Dim strSQL As New StringBuilder
            strSQL.Append("UPDATE cremcre ")
            strSQL.Append(" SET ccalif = @cCalif ")
            strSQL.Append(" WHERE ccodcta = @ccodcta ")


            Dim args(3) As SqlParameter
            args(0) = New SqlParameter("@ccalif", SqlDbType.VarChar)
            args(0).Value = lEntidad.ccalif
            args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
            args(1).Value = lEntidad.ccodcta

            sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function CarteraCancelada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 0000 as nciclo, ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes,  ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append("          (SELECT MAX(CREDKAR.DFECSIS) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA)  AS dultpag  ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CREDKAR ON CREMCRE.cCodcta = CREDKAR.ccodCta ")
        strSQL.Append(" and (case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end)  <= ")
        strSQL.Append("     (case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end)      ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" WHERE ")
        strSQL.Append(" CREMCRE.dfecvig <= @dfecha2    ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G')  ")
        strSQL.Append(" and (SELECT MAX(CREDKAR.dfecsis) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) >= @dfecha1 ")
        strSQL.Append(" and (SELECT MAX(CREDKAR.dfecsis) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) <= @dfecha2 ")



        'se filtra solo para creditos cancelados y/o vencimiento


        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.CCONDIC, CREMCRE.ccodsol , CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim lcestado As String


        Dim ds As New DataSet
        Dim fila As DataRow
        Dim elem As Integer
        Dim lnciclo As Integer
        Dim lccodcta As String
        Dim lccodcli As String

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(elem)("ccodcta")
            lccodcli = ds.Tables(0).Rows(elem)("ccodcli")
            lnciclo = Me.Ciclo(lccodcli, lccodcta)
            ds.Tables(0).Rows(elem)("nciclo") = lnciclo
            elem += 1
        Next

        Return ds
    End Function
    Public Function DeudaProyectada(ByVal pccodcta As String, ByVal pdfecha As Date) As Double
        Dim strSQL As New StringBuilder

        'Saldo teorico
        strSQL.Append("SELECT ncapita= SUM(CASE  WHEN ctipope ='N' THEN nCapita ELSE 0 END),   ")
        strSQL.Append(" nmonto= SUM(CASE  WHEN ctipope ='D' THEN nCapita ELSE 0 END)   ")
        strSQL.Append("FROM credppg ")
        strSQL.Append("WHERE  cCodcta = @pccodcta ")
        strSQL.Append("and dfecven < @pdfecha ")
        strSQL.Append("GROUP BY cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@pdfecha", SqlDbType.DateTime)
        args(0).Value = pdfecha
        args(1) = New SqlParameter("@pccodcta", SqlDbType.VarChar)
        args(1).Value = pccodcta

        Dim lnmonto As Double = 0
        Dim lncapita As Double = 0
        Dim lnsaldoteo As Double = 0

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        If ds.Tables(0).Rows.Count = 0 Then
            lnsaldoteo = 0
        Else
            lnmonto = ds.Tables(0).Rows(0)("nmonto")
            lncapita = ds.Tables(0).Rows(0)("ncapita")
            lnsaldoteo = Math.Round(lnmonto - lncapita, 2)
        End If
        Return lnsaldoteo

    End Function
    Public Function DeudaProyectadaIncluye(ByVal pccodcta As String, ByVal pdfecha As Date) As Double
        Dim strSQL As New StringBuilder

        'Saldo teorico
        strSQL.Append("SELECT ncapita= SUM(CASE  WHEN ctipope ='N' THEN nCapita ELSE 0 END),   ")
        strSQL.Append(" nmonto= SUM(CASE  WHEN ctipope ='D' THEN nCapita ELSE 0 END)   ")
        strSQL.Append("FROM credppg ")
        strSQL.Append("WHERE  cCodcta = @pccodcta ")
        strSQL.Append("and dfecven <= @pdfecha ")
        strSQL.Append("GROUP BY cCodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@pdfecha", SqlDbType.DateTime)
        args(0).Value = pdfecha
        args(1) = New SqlParameter("@pccodcta", SqlDbType.VarChar)
        args(1).Value = pccodcta

        Dim lnmonto As Double = 0
        Dim lncapita As Double = 0
        Dim lnsaldoteo As Double = 0

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        If ds.Tables(0).Rows.Count = 0 Then
            lnsaldoteo = 0
        Else
            lnmonto = ds.Tables(0).Rows(0)("nmonto")
            lncapita = ds.Tables(0).Rows(0)("ncapita")
            lnsaldoteo = Math.Round(lnmonto - lncapita, 2)
        End If
        Return lnsaldoteo

    End Function
    Public Function mensaje() As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select * from mensajes ")
        Dim ds As New DataSet
        Dim lcmensaje As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        If ds.Tables(0).Rows.Count = 0 Then
            lcmensaje = " "
        Else
            lcmensaje = ds.Tables(0).Rows(0)("mensaje")
        End If
        Return lcmensaje
    End Function
    Public Function Autor() As String
        Dim strSQL As New StringBuilder
        Dim strSQL1 As New StringBuilder
        Dim strSQL2 As New StringBuilder

        strSQL.Append("select * from mensajes where nflag = '0' order by id")
        Dim ds As New DataSet
        Dim ds1 As New DataSet
        Dim lcautor As String
        Dim lnid As Integer
        'Dim lnid As Integer
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        strSQL.Append(" ")
        If ds.Tables(0).Rows.Count = 0 Then
            lcautor = " "
        Else
            lcautor = ds.Tables(0).Rows(0)("autor")
            lnid = ds.Tables(0).Rows(0)("id")
            Dim args(0) As SqlParameter
            args(0) = New SqlParameter("@lnid", SqlDbType.Int)
            args(0).Value = lnid

            strSQL.Append("update mensajes set nflag = '1' where id = @lnid ")
            sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            strSQL.Append(" ")
        End If
        ds.Tables.Clear()

        'Verifica si todos quedan en 1
        strSQL1.Append("select * from mensajes where nflag = '0'")
        ds1 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL1.ToString())
        strSQL1.Append(" ")

        If ds1.Tables(0).Rows.Count = 0 Then

            strSQL2.Append("update mensajes set nflag = '0' ")
            sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL2.ToString())
        End If

        Return lcautor
    End Function

    'Informes Estadisticos
    Public Function CarteraEstadistica(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As Integer
        Dim ds As New DataSet
        ds = Me.SelectEstadistico(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctippre)
        Return ds.Tables(0).Rows.Count
    End Function
    Public Function CarteraEstadistica2(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As Double
        Dim ds As New DataSet
        ds = Me.SelectEstadistico(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctippre)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lncapdes As Double = 0
        Dim lntotcapdes As Double = 0
        For Each fila In ds.Tables(0).Rows
            lncapdes = ds.Tables(0).Rows(ele)("nCapDes")
            lntotcapdes = lntotcapdes + lncapdes
            ele += 1
        Next
        Return lntotcapdes
    End Function
    Public Function CarteraEstadisticaN(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, _
                                        ByVal lcanalista As String, ByVal lcestrato As String, _
                                        ByVal lclineas As String, ByVal lmora As Boolean, _
                                        ByVal cancela As String, ByVal lccartera As String, _
                                        ByVal lczona As String, ByVal lcsol As String, _
                                        ByVal lctipPre As String) As Integer
        Dim ds As New DataSet
        ds = Me.SelectEstadistico(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctipPre)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lnprenue As Integer = 0
        Dim lnprerec As Integer = 0
        Dim lnciclo As Integer = 0
        Dim lnretorno As Integer
        For Each fila In ds.Tables(0).Rows
            lnciclo = ds.Tables(0).Rows(ele)("nciclo")
            If lnciclo <= 1 Then
                lnprenue += 1
            Else
                lnprerec += 1
            End If
            ele += 1
        Next
        If lctipPre = "N" Then
            lnretorno = lnprenue
        Else
            lnretorno = lnprerec
        End If
        Return lnretorno
    End Function
    Public Function CarteraEstadisticaC(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctipPre As String) As Double
        Dim ds As New DataSet
        ds = Me.SelectEstadistico(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lczona, lcsol, lctipPre)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lncolnue As Double = 0
        Dim lncolrec As Double = 0
        Dim lnciclo As Integer = 0
        Dim lncapdes As Double = 0
        Dim lccodcta As String
        For Each fila In ds.Tables(0).Rows
            lncapdes = ds.Tables(0).Rows(ele)("ncapdes")
            lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
            lnciclo = ds.Tables(0).Rows(ele)("nciclo")
            If lnciclo <= 1 Then
                lncolnue = lncolnue + lncapdes
            Else
                lncolrec = lncolrec + +lncapdes
            End If
            ele += 1
        Next
        If lctipPre = "N" Then
            Return lncolnue
        Else
            Return lncolrec
        End If
    End Function

    Public Function SelectEstadistico(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcsol As String, ByVal lctippre As String) As DataSet
        Dim strSQL As New StringBuilder
        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, 0000 as nciclo, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.dfecapr, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= @dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= @dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" inner join credkar on cremcre.ccodcta = credkar.ccodcta and credkar.cdescob ='D' and credkar.cconcep ='KP' and credkar.cestado =' ' and CREDKAR.dfecsis >= @dfecha1 and CREDKAR.dfecsis <= @dfecha2 ")

        If lcsol = "C" Then
            strSQL.Append("WHERE  CREMCRE.dfecsol >= @dfecha1 and CREMCRE.dfecsol <= @dfecha2 ")
        ElseIf lcsol = "E" Then
            strSQL.Append("WHERE  CREMCRE.dfecapr >= @dfecha1 and CREMCRE.dfecapr <= @dfecha2 ")
        Else
            'strSQL.Append("WHERE  CREMCRE.dfecvig >= @dfecha1 and CREMCRE.dfecvig <= @dfecha2 ")
            '      strSQL.Append("WHERE  CREDKAR.dfecsis >= @dfecha1 and CREDKAR.dfecsis <= @dfecha2 ")
            strSQL.Append(" WHERE (CREMCRE.cestado = 'F' or CREMCRE.cEstado = 'G') ")
        End If

        If cancela = "3" Then 'Creditos en proceso
            strSQL.Append("and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end = 0 ")
        ElseIf cancela = "4" Then 'creditos Denegados
            strSQL.Append("and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end = 0 ")
            strSQL.Append("and CREMCRE.cCodRec <> ' ' ")
        ElseIf cancela = "5" Then 'creditos Vigentes
            'strSQL.Append("and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
            'strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(cretlin.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcsol", SqlDbType.VarChar)
        args(7).Value = lcsol
        args(8) = New SqlParameter("@lctippre", SqlDbType.VarChar)
        args(8).Value = lctippre

        Dim lcestado As String

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Dim fila As DataRow
        Dim ele As Integer = 0

        Dim lnciclo As Integer
        Dim lccodcli As String
        Dim lccodcta As String
        For Each fila In ds.Tables(0).Rows
            lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
            lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
            lnciclo = Me.Ciclo(lccodcli, lccodcta)
            ds.Tables(0).Rows(ele)("nciclo") = lnciclo
            ele += 1
        Next
        Return ds
    End Function
    Public Function RActividades(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT a.ccodigo, a.cdescri as Actividad, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM tabtciu a ")
        strSQL.Append(" order by a.cdescri ")


        'If lcanalista <> "*" Then
        'strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        'End If
        'If lcoficina <> "*" Then
        'strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        'End If


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function CarteraCalculada7(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        strSQL.Append(" and CREMCRE.cCodact = @lccodigo ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function TotalCreditos7(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal7(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal7(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado7(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado7(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada7(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Destino
    Public Function RDestino(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT left(a.ccodigo,1) as cCodigo, a.cdescri as Destino, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM tabttab a ")
        strSQL.Append(" WHERE  a.cCodtab= '005' and a.ctipreg = '1' order by a.cdescri ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function CarteraCalculada8(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, climide.csexo, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")


        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        'If cadena.Trim = cadenaactual.Trim Then
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        'Else
        'strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        'strSQL.Append(" and cremcre.cestado ='F'  ") '

        'End If


        'strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        'strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        'strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        'strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        If cflag = "D" Then
            strSQL.Append(" and CREMCRE.cDescre = @lccodigo ")
        ElseIf cflag = "S" Then
            strSQL.Append(" and left(CREMCRE.cSecEco,1) = left(@lccodigo,1) ")
        ElseIf cflag = "T" Then
            strSQL.Append(" and substring(cretlin.ccodlin,7,2) = @lccodigo ")
        End If
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function TotalCreditos8(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal8(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal8(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado8(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado8(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function

    'especial
    Public Function Carteraxsector(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String)
        Dim ds As New DataSet
        ds = Me.CarteraCalculada8(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer
        Dim lnsaldot As Double = 0
        Dim lncapdest As Double = 0
        Dim lnhombres As Integer = 0
        Dim lnmujeres As Integer = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                lncapdest = lncapdest + lncapdes
                lnsaldot = lnsaldot + lnmonto
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                    lnmontot = lnmontot + lnmonto
                End If
                If fila1("csexo") = "M" Then
                    lnhombres += 1
                Else
                    lnmujeres += 1
                End If
                elem1 += 1
            Next
        End If
        Me.dbcasos = lncasos
        Me.dbmonto = lncapdest
        Me.dbsaldo = lnsaldot
        Me.dbafectada = lnmontot
        Me.dbhombres = lnhombres
        Me.dbmujeres = lnmujeres

    End Function
    '
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function RAnalistas(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT a.ccodusu, a.cnomusu as Analistas, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec, 0000000000.00 as nPar30sal ")
        strSQL.Append(" FROM tabtusu a ")
        strSQL.Append(" order by a.cnomusu ")


        'If lcoficina <> "*" Then
        'strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        'End If


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function

    Public Function TotalCreditos9(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal9(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal9(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado9(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado9(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada9(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function

    Public Function CarteraCalculada9(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        strSQL.Append(" and CREMCRE.cCodana = @lccodigo ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function RGenero(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT left(a.ccodigo,1) as cCodigo, a.cdescri as Genero, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM tabttab a ")
        strSQL.Append(" WHERE  a.cCodtab= '003' and a.ctipreg = '1' order by a.cdescri ")


        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    '-------------------------------------------------------
    Public Function TotalCreditos10(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal10(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal10(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado10(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado10(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada10(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function

    Public Function CarteraCalculada10(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI and CLIMIDE.cSexo = @lccodigo ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        'strSQL.Append(" and CLIMIDE.cSexo = @lccodigo ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        'ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    '---------------------------------------------------------------------
    Public Function TotalCreditos11(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function MontoTotal11(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lnmonto = ds.Tables(0).Rows(elem1)("ncapdes")
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function SaldoTotal11(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnmonto = lncapdes - lncappag
                lnmontot = lnmontot + lnmonto
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function Saldoafectado11(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Double
        Dim ds As New DataSet
        ds = Me.CarteraCalculada11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                If lnmonto > lnsalteo And pndias > 30 Then
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Return lnmontot
    End Function
    Public Function casosafectado11(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                End If
                elem1 += 1
            Next
        End If
        Return lncasos
    End Function

    Public Function CarteraCalculada11(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" and  CREMCRE.dfecvig <= @dfecha2  and ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  >")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end     ")
        strSQL.Append("inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (cremcre.cestado ='F' or cremcre.cestado='G') and cremcre.dfecvig<=@dfecha2 ")
        strSQL.Append(" and CREMCRE.coficina  = @lccodigo ")
        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        ' If lcoficina <> "*" Then
        ' strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        'End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    Public Function ROficina(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT left(a.ccodofi,3) as cCodigo, a.cnomofi as Oficina, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM tabtofi a ")
        strSQL.Append(" WHERE a.ctipofi = '1' order by a.cnomofi ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function Decersion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CLIMIDE.cCodcli, CLIMIDE.cnomcli, MAX(CREMCRE.dfecven) as dfecven,   max(cremcre.ccodcta) as ccodcta, ")
        strSQL.Append("MAX(CREDKAR.DFECSIS)  AS dultpag, cremcre.ccodana, tabtusu.cnomusu as analista, 000000.00 as ncuota, 00000 as ndiaatr    ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CREDKAR ON CREMCRE.ccodcta = CREDKAR.ccodcta and credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' ")
        strSQL.Append(" inner join tabtusu on cremcre.ccodana = tabtusu.ccodusu ")
        strSQL.Append(" INNER JOIN CLIMIDE ON  CLIMIDE.cCodcli = CREMCRE.cCodcli ")
        strSQL.Append(" WHERE   ")
        strSQL.Append(" CREMCRE.dfecvig <= @dfecha2      ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G')    ")
        strSQL.Append(" and (SELECT MAX(CREDKAR.dfecsis) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) >= @dfecha1   ")
        strSQL.Append(" and (SELECT MAX(CREDKAR.dfecsis) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) <= @dfecha2   ")
        strSQL.Append(" and (case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end)  <=   ")
        strSQL.Append("     (case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end)        ")
        strSQL.Append(" AND not cremcre.ccodcli in  ")
        strSQL.Append("    (SELECT Cremcre.ccodcli ")
        strSQL.Append("                   FROM CREMCRE, climide WHERE  ")
        strSQL.Append("                   CREMCRE.DFECVIG >= @dfecha1  ")
        strSQL.Append("              AND CREMCRE.CCODCLI = CLIMIDE.CCODCLI)  ")
        strSQL.Append(" group by climide.ccodcli, CLIMIDE.cNomcli , cremcre.ccodana, tabtusu.cnomusu ")
        strSQL.Append(" ORDER BY  tabtusu.cnomusu, CLIMIDE.cNomcli ")


        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2

        Dim lcestado As String


        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodcta As String
        Dim lndiaatr As Integer

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            'Rellena campos dias de atraso y valor de ultima cuota
            For Each fila In ds.Tables(0).Rows
                lccodcta = ds.Tables(0).Rows(i)("ccodcta")
                lndiaatr = Me.diashis(lccodcta)
                ds.Tables(0).Rows(i)("ndiaatr") = lndiaatr
                i += 1
            Next

        End If
        Return ds
    End Function
    Public Function RSector(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT left(a.ccodigo,1) as cCodigo, a.cdescri as Destino, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec, 0000000 as nhombres, 0000000 as nmujeres ")
        strSQL.Append(" FROM tabttab a ")
        strSQL.Append(" WHERE  a.cCodtab= '021' and a.ctipreg = '1' order by a.cdescri ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    'estado del credito en tiempo real
    Public Function Estado(ByVal dfecha2 As Date, ByVal ccodcta As String) As String
        Dim strSQL As New StringBuilder

        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint,  ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and cremcre.ccodcta = @ccodcta ")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(0).Value = dfecha2
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = ccodcta

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstadoind(ds, dfecha2)
        If ds1.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds1.Tables(0).Rows(0)("cestado")
        End If



    End Function
    Public Function ValidaEstadoind(ByVal dsvalida As DataSet, ByVal dfecha2 As Date) As DataSet
        Dim lcestado As String
        If dsvalida.Tables(0).Rows.Count = 0 Then
        Else
            Dim nelem As Integer
            Dim fila As DataRow
            Dim lncapdes As Double = 0
            Dim lncappag As Double = 0
            Dim lnsaldo As Double = 0
            Dim ecredkar As New dbCredkar
            Dim ldultpag As Date

            For Each fila In dsvalida.Tables(0).Rows

                If dsvalida.Tables(0).Rows(nelem)("dfecvig") <= #11/24/2007# Then
                    ldultpag = ecredkar.UltimafechaProceso(dsvalida.Tables(0).Rows(nelem)("ccodcta"), dfecha2)
                    If dsvalida.Tables(0).Rows(nelem)("cEstado") = "G" And ldultpag >= #11/24/2007# Then

                        If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncapdes")) Then
                            dsvalida.Tables(0).Rows(nelem)("ncapdes") = 0
                        End If

                        If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncappag")) Then
                            dsvalida.Tables(0).Rows(nelem)("ncappag") = 0
                        End If

                        lncapdes = dsvalida.Tables(0).Rows(nelem)("ncapdes")
                        lncappag = dsvalida.Tables(0).Rows(nelem)("ncappag")
                        lnsaldo = lncapdes - lncappag

                        If lnsaldo <= 0 Then
                            dsvalida.Tables(0).Rows(nelem)("cEstado") = "G"
                            lcestado = "G"
                        Else
                            dsvalida.Tables(0).Rows(nelem)("cEstado") = "F"
                            lcestado = "F"
                        End If
                    Else
                        lcestado = dsvalida.Tables(0).Rows(nelem)("cEstado")
                    End If
                Else
                    If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncapdes")) Then
                        dsvalida.Tables(0).Rows(nelem)("ncapdes") = 0
                    End If
                    If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncappag")) Then
                        dsvalida.Tables(0).Rows(nelem)("ncappag") = 0
                    End If
                    lncapdes = dsvalida.Tables(0).Rows(nelem)("ncapdes")
                    lncappag = dsvalida.Tables(0).Rows(nelem)("ncappag")
                    lnsaldo = lncapdes - lncappag
                    If lnsaldo <= 0 Then
                        dsvalida.Tables(0).Rows(nelem)("cEstado") = "G"
                        lcestado = "G"
                    Else
                        dsvalida.Tables(0).Rows(nelem)("cEstado") = "F"
                        lcestado = "F"
                    End If
                End If


                If lcestado.Trim = "G" Then
                End If
                nelem += 1
            Next
        End If
        Return dsvalida
    End Function

    Public Function RGarantia(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT left(a.ccodigo,2) as cCodigo, a.cdescri as Destino, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec ")
        strSQL.Append(" FROM tabttab a ")
        strSQL.Append(" WHERE  a.cCodtab= '074' and a.ctipreg = '1' order by a.cdescri ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function

    Public Function CarteraCalculada12(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven,  SPACE(6) as categoria,cremcre.ctipgar, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin  ")
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")


        '      strSQL.Append(" and CLIMIDE.cSexo = @lccodigo ")

        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo

        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function TotalCreditos12(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim ds As New DataSet
        ds = Me.CarteraCalculada12(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Return ds
        'Dim lntotalcre As Integer
        'lntotalcre = ds.Tables(0).Rows.Count
        'Return lntotalcre
    End Function

    Public Function Carteraxgarantia(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim ds As New DataSet
        ds = Me.CarteraCalculada12(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Return ds
    End Function

    Public Function CarteraCalculada13(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin  ")
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        If lccodigo = "A" Then
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) <=21  ")
        ElseIf lccodigo = "B" Then
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) >21    ")
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) <=30    ")
        ElseIf lccodigo = "C" Then
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) >30    ")
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) <=40    ")
        ElseIf lccodigo = "D" Then
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) >40    ")
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) <=50    ")
        ElseIf lccodigo = "E" Then
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) >50    ")
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) <=60    ")
        ElseIf lccodigo = "F" Then
            strSQL.Append(" and round(DATEDIFF(year, climide.dnacimi, @dfecha2),0) >60    ")
        End If



        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        args(6).Value = lccodigo

        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    Public Function CarteraCalculada14(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, 00000 as ndias, 0000 as nciclo, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append("case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag, ")
        strSQL.Append("case when (SELECT SUM(CREdppg.Ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREDppg.DFECven < @dfecha2 AND credppg.ctipope = 'N' GROUP BY CREDppg.CCODCTA) is null then 0 else (SELECT SUM(CREdppg.ncapita) FROM CREDppg WHERE CREDppg.CCODCTA = CREMCRE.CCODCTA  AND CREdppg.DFECven < @dfecha2 AND credppg.ctipope= 'N'  GROUP BY CREDppg.CCODCTA) end AS npagTeo ")
        strSQL.Append("FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin  ")
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        'Dim lnciclo As Integer
        'lnciclo = Integer.Parse(lccodigo)

        '      strSQL.Append(" and MAX(cremcre.ccodcli) = @lnciclo ")

        '
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado")

        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        'args(6) = New SqlParameter("@lccodigo", SqlDbType.VarChar)
        'args(6).Value = lccodigo


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)

        'ciclea el credito
        ' If ds1.Tables(0).Rows.Count > 0 Then
        'Dim fila As DataRow
        'Dim ele As Integer
        'Dim lnciclo1 As Integer
        'Dim lccodcta As String
        'Dim lccodcli As String
        'For Each fila In ds1.Tables(0).Rows
        'lccodcli = ds1.Tables(0).Rows(ele)("ccodcli")
        'lccodcta = ds1.Tables(0).Rows(ele)("ccodcta")
        'lnciclo1 = Me.Ciclo(lccodcli, lccodcta)

        'If lnciclo1 = lnciclo Then
        'Else
        'ds1.Tables(0).Rows(ele).Delete()
        'ds1.Tables(0).GetChanges(DataRowState.Deleted)
        'End If
        'ele += 1
        'Next
        'ds1.Tables(0).AcceptChanges()
        'End If

        Return ds1
    End Function

    Public Function TotalCreditos13(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As Integer
        Dim ds As New DataSet
        ds = Me.CarteraCalculada13(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lntotalcre As Integer
        lntotalcre = ds.Tables(0).Rows.Count
        Return lntotalcre
    End Function
    Public Function TotalCreditos14(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String) As DataSet
        Dim ds As New DataSet
        ds = Me.CarteraCalculada14(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        'Dim lntotalcre As Integer
        'lntotalcre = ds.Tables(0).Rows.Count
        Return ds 'lntotalcre
    End Function
    Public Function Carteraxedad(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String, ByVal cflag As String)
        Dim ds As New DataSet
        ds = Me.CarteraCalculada13(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer
        Dim lnsaldot As Double = 0
        Dim lncapdest As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                lncapdest = lncapdest + lncapdes
                lnsaldot = lnsaldot + lnmonto
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Me.dbcasos = lncasos
        Me.dbmonto = lncapdest
        Me.dbsaldo = lnsaldot
        Me.dbafectada = lnmontot
    End Function
    Public Function Carteraxsecuencia(ByVal ds As DataSet, ByVal dfecha2 As Date)
        'Dim ds As New DataSet
        'ds = Me.CarteraCalculada14(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo, cflag)
        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim lncasos As Integer = 0
        Dim pccodcta As String
        Dim pndias As Integer
        Dim lnsaldot As Double = 0
        Dim lncapdest As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)

                lncapdest = lncapdest + lncapdes
                lnsaldot = lnsaldot + lnmonto
                If lnmonto > lnsalteo And pndias > 30 Then
                    lncasos += 1
                    lnmontot = lnmontot + lnmonto
                End If
                elem1 += 1
            Next
        End If
        Me.dbcasos = lncasos
        Me.dbmonto = lncapdest
        Me.dbsaldo = lnsaldot
        Me.dbafectada = lnmontot
    End Function

    'Funcion que debuelve el numero mayor de ciclos que existen
    Public Function maxCiclo() As Integer
        Dim strSQL As New StringBuilder
        Dim ds As New DataSet
        strSQL.Append("SELECT MAX(CANTIDAD) as maxciclo FROM (SELECT COUNT(*) as CANTIDAD FROM CREMCRE GROUP BY ccodcli) as tabla1 ")
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("maxciclo")
        End If
    End Function

    Public Function CarteraCalculada15(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("select credppg.dfecven, count(credppg.dfecven) as cuotas, ")
        strSQL.Append("       sum(credppg.ncapita) as ncapita, ")
        strSQL.Append("       sum(credppg.nintere) as nintere,  ")
        strSQL.Append("       sum(credppg.ngastos) as ncomision,  ")
        strSQL.Append("       sum(credppg.nsegdeu) as nseguro  ")
        strSQL.Append("  from credppg, cremcre, cretlin  ")
        strSQL.Append("  where cremcre.ccodcta = credppg.ccodcta and cremcre.cnrolin =  cretlin.cnrolin and ")
        strSQL.Append(" credppg.dfecven >=@dfecha1 and credppg.dfecven <=@dfecha2 and credppg.ctipope = 'N' ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")


        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append("  group by credppg.dfecven ")
        strSQL.Append("  order by credppg.dfecven ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        'ds1 = Me.ValidaEstado(ds, dfecha2)

        Dim fila As DataRow
        For Each fila In ds.Tables(0).Rows
            fila("nseguro") = 0
            fila("ncomision") = 0
        Next
        Return ds
    End Function
    Public Function DETALLE_CARTERA_Y_PAGOS_Extorno(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex(strSQL)



        'If bandera = "*" Then
        '    strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON substring(C.cCodcta,4,3) = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        'Else
        '    strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON substring(C.cCodcta,4,3) = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        'End If
        'If bandera = "*" Then
        strSQL.Append("INNER JOIN Tabtofi D ON B.coficina = D.cCodofi  ")

        strSQL.Append("INNER JOIN credkar C ON B.ccodcta = C.ccodcta  ")
        '---------
        If bandera = "*" Then
            strSQL.Append(" and left(C.cnuming,9) ='CANC/REFI' ")
        Else
            strSQL.Append(" and left(C.cnuming,9) <>'CANC/REFI' ")
        End If

        '---------

        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = 'X' ")
        strSQL.Append("AND C.dfecmod >= @DFECHA1 AND C.dfecmod <= @DFECHA2 ")
        



        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        'strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cTippag, C.cCodOfi, D.cNomofi, B.dfecven, H.cCodsol, H.cnomgru ")
        'strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cTippag, C.cCodOfi, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin, C.cnumrec ")
        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,   C.cTippag, B.coficina, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin,L.ccodlin, B.ccodana, F.cnomusu, B.cflat ")
        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
                lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
                lnciclo = Me.Ciclo(lccodcli, lccodcta)
                ds.Tables(0).Rows(ele)("nciclo") = lnciclo
                ele += 1
            Next
        End If
        Return ds

    End Function

    Public Function Resumen_Mensual_Recuperaciones(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" select c.dfecsis,  ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN (C.CCONCEP = 'IN' AND C.CCONDIC <> 'S') or (C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='2')  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'IN' AND C.CCONDIC ='S' and a.cclaper ='1' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("      NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END)   ")
        strSQL.Append("      FROM   Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli  ")
        strSQL.Append("                       INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin  ")


        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY  C.Dfecsis  ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function

    Public Function Resumen_Anual_Recuperaciones(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" select year(c.dfecsis) as anos,  ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN (C.CCONCEP = 'IN' and c.ccondic <> 'S') or (C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='2') THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='1'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("      FROM   Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli  ")
        strSQL.Append("                       INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin  ")


        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY  year(C.Dfecsis)  ")
        strSQL.Append("order by  year(c.dfecsis)  ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function


    Public Function Resumen_Mensual_Colocacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" select c.dfecsis,  ")
        strSQL.Append(" nnum =  (select count(*) from credkar  g   WHERE  g.CDESCOB = 'D' AND g.cestado = ' ' ")
        strSQL.Append("  and g.cconcep = 'KP' and g.dfecsis = c.dfecsis), ")
        strSQL.Append("      NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = 'SD' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("      NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("      NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'CO' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      niva  = SUM(CASE  WHEN C.CCONCEP = '02' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END)   ")
        strSQL.Append("      FROM   Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli  ")
        strSQL.Append("                       INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin  ")


        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY  C.Dfecsis  ")
        strSQL.Append("ORDER BY  C.Dfecsis  ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function


    Public Function Resumen_Anual_Colocacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append(" select year(c.dfecsis) as anos,  ")
        strSQL.Append(" nnum =  (select count(*) from credkar  g   WHERE  g.CDESCOB = 'D' AND g.cestado = ' ' ")
        strSQL.Append("  and g.cconcep = 'KP' and year(g.dfecsis) = year(c.dfecsis)), ")
        strSQL.Append("      NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = 'SD' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("      NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("      NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'CO' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END),  ")
        strSQL.Append("      NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END)   ")
        strSQL.Append("      FROM   Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli  ")
        strSQL.Append("                       INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin  ")


        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY  year(C.Dfecsis)  ")
        strSQL.Append("ORDER BY  year(C.Dfecsis)  ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function

    Public Function CarteraCalculada16(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("select cremsol.cnomgru,credppg.dfecven,count(credppg.dfecven) as cuotas, ")
        strSQL.Append("       sum(credppg.ncapita) as ncapita, ")
        strSQL.Append("       sum(credppg.nintere) as nintere,  ")
        strSQL.Append("       sum(credppg.ngastos) as ncomision,  ")
        strSQL.Append("       sum(credppg.nsegdeu) as nseguro  ")
        strSQL.Append("  from credppg, cremcre, cretlin, climide,cremsol  ")
        strSQL.Append("  where cremcre.ccodcli = climide.ccodcli and cremcre.ccodcta = credppg.ccodcta and cremcre.cnrolin =  cretlin.cnrolin and cremcre.ccodsol = cremsol.cCodsol ")
        strSQL.Append(" and credppg.dfecven >=@dfecha1 and credppg.dfecven <=@dfecha2 and credppg.ctipope = 'N' ")
        strSQL.Append(" and (cremcre.cestado ='F' ) ")



        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append("  group by credppg.dfecven , cremsol.cnomgru ")
        strSQL.Append("  order by cremsol.cnomgru ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds
    End Function
    ''Function Create by Fernando
    Public Function CarteraCalculada16_551(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("select climide.cnomcli,cremsol.cnomgru,credppg.dfecven,credppg.ccodcta,cremcre.ndiaatr, count(credppg.dfecven) as cuotas, ")
        strSQL.Append("       sum(credppg.ncapita) as ncapita, ")
        strSQL.Append("       sum(credppg.nintere) as nintere,  ")
        strSQL.Append("       sum(credppg.ngastos) as ncomision,  ")
        strSQL.Append("       sum(credppg.nsegdeu) as nseguro  ")
        strSQL.Append("  from credppg, cremcre, cretlin, climide,cremsol ")
        strSQL.Append("  where cremcre.ccodcli = climide.ccodcli and cremcre.ccodcta = credppg.ccodcta and cremcre.cnrolin =  cretlin.cnrolin and  ")
        strSQL.Append(" cremcre.ccodsol = cremsol.cCodsol and credppg.dfecven >=@dfecha1 and credppg.dfecven <=@dfecha2 and credppg.ctipope = 'N' ")
        strSQL.Append(" and (cremcre.cestado ='F' ) ")
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" group by credppg.dfecven,climide.cnomcli ,credppg.ccodcta, cremsol.cnomgru,cremcre.ndiaatr  ")
        strSQL.Append("  order by cremsol.cnomgru  ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ''retornando valores de set
        Return ds
    End Function
    'Obtiene el capital moratorio por cliente en el reporte  55
    Public Function ObtieneCpMoratorixCliente(ByVal ccodcta As String, ByVal fecha2 As Date) As Double

        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim NcapMora As Double
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_ObtenerCapMoratorio"

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodcta", SqlDbType.VarChar)
                MyParameters.Value = ccodcta
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha2", SqlDbType.Date)
                MyParameters.Value = fecha2
                MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyCommand.CommandType = CommandType.StoredProcedure
                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds, "Proyeccion")

                For Each rows As DataRow In Ds.Tables(0).Rows
                    NcapMora = rows("Column1")
                Next
                'lnRetorno = CInt(MyCommand.Parameters("@pnError").Value)

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return NcapMora

    End Function



    'Funcion  de reporte 55.1
    Public Function CarteraCalculada1655_1(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String) As DataSet
        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_Poyeccion55_1"

                MyParameters = _
                                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha1", SqlDbType.Date)
                MyParameters.Value = dfecha1
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@fecha2", SqlDbType.Date)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@analista", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input

               

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds, "Proyeccion")
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


    Public Function CarteraCalculada17(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, ")
        If cflag = "D" Then
            strSQL.Append(" left(CREMCRE.cDesCre,1) as cSecEco, ")
        ElseIf cflag = "S" Then
            strSQL.Append(" left(CREMCRE.cSecECo,1) as cSecEco, ")
        End If

        strSQL.Append(" ltrim(rtrim(TABTTAB.cDescri)) as cDescri, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint,  ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        If cflag = "D" Then
            strSQL.Append(" INNER JOIN TABTTAB ON CREMCRE.cDesCre = left(ltrim(TABTTAB.ccodigo),1) ")
            strSQL.Append("  and TABTTAB.cCodtab = '005' and TABTTAB.cTipReg = '1'  ")
        Else
            strSQL.Append(" INNER JOIN TABTTAB ON CREMCRE.cSecECo = left(ltrim(TABTTAB.ccodigo),1) ")
            strSQL.Append("  and TABTTAB.cCodtab = '021' and TABTTAB.cTipReg = '1'  ")
        End If



        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        'strSQL.Append(" GROUP BY CREMCRE.cCodCta, CREMCRE.cSecECo, TABTTAB.cDescri, CREMCRE.cEstado, CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CRETLIN.ntasint, ")
        'strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom  ")


        strSQL.Append(" ORDER BY ltrim(rtrim(TABTTAB.cDescri)),  CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(7).Value = cflag

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function CarteraCalculada18(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, ")
        strSQL.Append(" space(1) as cSecEco, ")
        strSQL.Append(" space(60) as cDescri, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint,cremcre.ctipgar,  ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If


        strSQL.Append(" ORDER BY ncapdes,  CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(7).Value = cflag

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    Public Function RangoMonto(ByVal nmonto As Double) As String
        Dim strSql As New StringBuilder
        strSql.Append("Select rangos from rangosmontos ")
        strSql.Append(" WHERE @nmonto >= ndesde and @nmonto <= nhasta ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(0).Value = nmonto

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return ""
        Else
            Return ds.Tables(0).Rows(0)("rangos")
        End If
    End Function
    Public Function RangoMontoD(ByVal nmonto As Double) As Double
        Dim strSql As New StringBuilder
        strSql.Append("Select ndesde from rangosmontos ")
        strSql.Append(" WHERE @nmonto >= ndesde and @nmonto <= nhasta ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(0).Value = nmonto

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("ndesde")
        End If
    End Function

    Public Function Garantia_Nombre(ByVal ccodigo As String) As String
        Dim strSql As New StringBuilder
        strSql.Append("Select ltrim(rtrim(cdescri)) as garantia from tabttab ")
        strSql.Append(" WHERE ccodtab = '074' and ctipreg = '1' and ccodigo = @ccodigo ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = ccodigo

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSql.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return "NO DEFINIDA"
        Else
            Return ds.Tables(0).Rows(0)("garantia")
        End If
    End Function
    Public Function CarteraCalculadaINFORED(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, 'F' as cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, substring(cretlin.ccodlin,9,2) as csececo,  ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, climide.csexo as genero, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' and CREDKAR.lrecprov = '0' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' and CREDKAR.lrecprov = '0' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")

        strSQL.Append(" , CASE Cremcre.cTipgar")
        strSQL.Append("	WHEN '01' THEN 'HI'")
        strSQL.Append(" WHEN '02' THEN 'SO'")
        strSQL.Append(" WHEN '03' THEN 'FI'")
        strSQL.Append(" WHEN '04' THEN 'PR'")
        strSQL.Append(" ELSE 'NA'")
        strSQL.Append(" END AS CTIPGAR , climide.cnudoci, climide.cnudotr ")

        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")

        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")

        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' and CREDKAR.lrecprov = '0' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' and CREDKAR.lrecprov = '0' GROUP BY CREDKAR.CCODCTA) end      ")

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY  CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function SaldoxCuenta(ByVal ccodcta As String, ByVal dfecha As Date) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append(" select  cremcre.ccodcta,  ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strsql.Append(" from cremcre ")
        strsql.Append(" where cremcre.ccodcta = @ccodcta and ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end > ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end   ")
        strsql.Append(" group by cremcre.ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Return ExecuteDataSet(Me.cnnStr, CommandType.Text, strsql.ToString(), args, 0)

    End Function

    Public Function CarteraCalculadaxCentro(ByVal dfecha As Date, ByVal ccodcen As String) As DataSet
        Dim strSQL As New StringBuilder

        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint,  ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")

        strSQL.Append(" , CASE Cremcre.cTipgar")
        strSQL.Append("	WHEN '01' THEN 'HI'")
        strSQL.Append(" WHEN '02' THEN 'SO'")
        strSQL.Append(" WHEN '03' THEN 'FI'")
        strSQL.Append(" WHEN '04' THEN 'PR'")
        strSQL.Append(" ELSE 'NA'")
        strSQL.Append(" END AS CTIPGAR , climide.cnudoci, climide.cnudotr ")

        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")

        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")

        strSQL.Append(" and CREMSOL.cCodcen = @cCodcen ")

        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@ccodcen", SqlDbType.VarChar)
        args(1).Value = ccodcen


        Dim lcestado As String
        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Return ds
    End Function

    Public Function ResumenCaja(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcanalista As String, ByVal lcoficina As String, ByVal lclineas As String, ByVal lccajeros As String, ByVal lczona As String, ByVal lctippag As String, ByVal lcbanco As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" select c.cbanco, ")
        strSQL.Append(" C.ctippag, Case C.cTippag  ")
        strSQL.Append("        WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("        WHEN 'C' THEN 'NOTA DE ABONO/CHEQUE' ")
        strSQL.Append("        WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append("         END AS cTipopago, ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append(" FROM Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append(" INNER JOIN Credkar C ON B.cCodcta = C.cCodcta ")
        strSQL.Append(" INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin ")

        strSQL.Append("WHERE  C.CDESCOB = 'C' AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")

        If lctippag = "C" Then
            strSQL.Append("AND c.cbanco = @lcbanco and c.ctippag = @lctippag ")
        Else
            strSQL.Append("AND c.ctippag = @lctippag ")
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        strSQL.Append(" group by c.ctippag, c.cbanco ")
        strSQL.Append(" order by c.ctippag, c.cbanco ")


        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(5).Value = lccajeros
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lctippag", SqlDbType.VarChar)
        args(7).Value = lctippag
        args(8) = New SqlParameter("@lcbanco", SqlDbType.VarChar)
        args(8).Value = lcbanco

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function

    Private Sub SelectTabla_con_kardex_Otros(ByRef strSQL As StringBuilder)

        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, MAX(A.cCodcli) as ccodcli, B.ccodcta, 0000 as nciclo,")
        strSQL.Append("C.dfecsis as dfecvig, B.dfecven, C.cnuming, C.dFecsis, C.Dfecpro,")
        strSQL.Append("C.cCodOfi, D.cnomofi,")
        strSQL.Append("B.ccodsol, H.cnomgru, T.cCodsol as cCodcen, T.cNomgru as cNomcen, ")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'NOTA DE ABONO' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(40) as cnomusu, ")
        strSQL.Append("00000000000.00 as nsaldo, 00000000000.00 as nCapdes, R.cNombco, ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'CO' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append(" INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin ")
        strSQL.Append(" INNER JOIN CREMSOL H ON B.ccodsol = H.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS T ON H.ccodcen = T.ccodsol  ")


    End Sub

    Public Function DETALLE_CARTERA_Y_PAGOS_OTROS(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex_Otros(strSQL)



        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        End If

        strSQL.Append(" INNER JOIN TABTBCO R ON C.cbanco = R.cCodbco and (R.cCodbco = '77' or R.cCodbco = '88' or R.cCodbco = '99')  ")


        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")


        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cTippag, C.cCodOfi, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, R.cnombco ")

        If lcdescob = "D" Then

        Else
        
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
                lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
                lnciclo = Me.Ciclo(lccodcli, lccodcta)
                ds.Tables(0).Rows(ele)("nciclo") = lnciclo
                ele += 1
            Next
        End If
        Return ds

    End Function

    Public Function DETALLE_CARTERA_Y_PAGOS_EXCEDENTES(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, MAX(A.cCodcli) as ccodcli, B.ccodcta, 0000 as nciclo,")
        strSQL.Append("C.dfecsis as dfecvig, B.dfecven, C.cnuming, C.dFecsis, C.Dfecpro, C.cbanco,")
        strSQL.Append("C.cCodOfi, D.cnomofi,")
        strSQL.Append("B.ccodsol, H.cnomgru, T.cCodsol as cCodcen, T.cNomgru as cNomcen, ")
        'Cesar Torres 24/01/2016 a peticion de Control y seguimiento se agregan dias de atraso y nombre grupo
        strSQL.Append("C.ctippag, Case cTippag, B.ndiaatr ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'NOTA DE ABONO' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(40) as cnomusu, space(60) as cnombco, ")
        strSQL.Append("00000000000.00 as nsaldo, 00000000000.00 as nCapdes, ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN C.CCONCEP = 'IN' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = 'CO' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append(" INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin ")
        strSQL.Append(" INNER JOIN CREMSOL H ON B.ccodsol = H.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS T ON H.ccodcen = T.ccodsol  ")




        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) <>'CANC/REFI') ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")


        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cTippag, C.cCodOfi, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, C.cBanco ")



        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            Dim lctippag As String
            Dim lcnombco As String
            Dim lccodbco As String
            Dim etabtbco As New dbTabtbco
            Dim lNEXCED As Double
            For Each fila In ds.Tables(0).Rows
                lctippag = ds.Tables(0).Rows(ele)("ctippag")
                lccodbco = ds.Tables(0).Rows(ele)("cbanco")
                lNEXCED = ds.Tables(0).Rows(ele)("NEXCED")
                If lctippag = "E" Then
                    lcnombco = "EFECTIVO"
                ElseIf lctippag = "I" Then
                    lcnombco = "CONDONACIONES"
                Else
                    lcnombco = etabtbco.NombredeBanco(lccodbco.Trim)
                End If
                ds.Tables(0).Rows(ele)("cnombco") = lcnombco.Trim
                If lNEXCED <= 0 Then
                    ds.Tables(0).Rows(ele).Delete()
                    ds.Tables(0).GetChanges(DataRowState.Deleted)
                End If

                ele += 1


            Next
            ds.Tables(0).AcceptChanges()
        End If
        Return ds

    End Function

    Public Function StatusCredito(ByVal ccodcta As String) As String
        Dim strsql As New StringBuilder
        strsql.Append("select ccodrec from cremcre where ccodcta = @ccodcta")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        Dim ds As New DataSet
        Dim lccodrec As String

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strsql.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            lccodrec = ""
        Else
            lccodrec = IIf(IsDBNull(ds.Tables(0).Rows(0)("ccodrec")), "", ds.Tables(0).Rows(0)("ccodrec"))
        End If
        Return lccodrec
    End Function

    '>>>>>>>>><<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    Public Function ObtenerbusquedaGrupal(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String) As DataSet

        Dim strSQL As New StringBuilder

        If cbusq = "3" Then 'Creditos en Estado de Aprobacion para desembolsar
            strSQL.Append("SELECT cremcre.ccodsol as codigo, cremsol.cnomgru as cnomcli, sum(cremcre.ncapdes) as ncapdes ,cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec ")
            strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
            strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
            strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
            strSQL.Append(" and CREMCRE.cestado ='E' ")
            If ctipo = "1" Then
                strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
            ElseIf ctipo = "2" Then
                strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
            Else
                strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
            End If
            strSQL.Append(" GROUP BY cremcre.ccodsol, cremsol.cnomgru, cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec")
        Else
            strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec ")
            strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
            strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
            strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
            If ctipo = "1" Then
                strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
            ElseIf ctipo = "2" Then
                strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
            Else
                strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
            End If
            If cbusq = "1" Then
                strSQL.Append(" and CREMCRE.cestado ='A'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "2" Then
                strSQL.Append(" and CREMCRE.cestado ='C'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "3" Then
                strSQL.Append(" and CREMCRE.cestado ='E'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "4" Then
                strSQL.Append(" and CREMCRE.cestado ='F'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            ElseIf cbusq = "5" Then
            ElseIf cbusq = "6" Then
                strSQL.Append(" and CREMCRE.cestado ='D'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            End If

        End If

        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    '-------------------------------------------------------------------------------------------------------------
    Public Function ObtenerbusquedacreditoGrupales(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet

        Dim strSQL As New StringBuilder


        strSQL.Append("SELECT cremcre.ccodsol as codigo, cremsol.cnomgru as cnomcli, ")
        strSQL.Append("sum(cremcre.ncapdes) as ncapdes ,cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec ")
        strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
        strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
        strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol and cremcre.ccodsol not in ('001001000000') ")
        If ctipo = "1" Then
            strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
        ElseIf ctipo = "2" Then
            strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
        Else
            strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
        End If
        If cCodofi = "001" Then
        Else
            strSQL.Append(" and cremcre.coficina = @cCodofi ")
        End If


        If cbusq = "1" Then
            strSQL.Append(" and CREMCRE.cestado ='A'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
        ElseIf cbusq = "2" Then
            strSQL.Append(" and CREMCRE.cestado ='C'   and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")

        ElseIf cbusq = "3" Then
            strSQL.Append(" and CREMCRE.cestado ='E'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
            strSQL.Append(" GROUP BY cremcre.ccodsol, cremsol.cnomgru, cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec ")


        ElseIf cbusq = "4" Then
            strSQL.Append(" and CREMCRE.cestado ='F'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
        ElseIf cbusq = "5" Then
        ElseIf cbusq = "6" Then
            strSQL.Append(" and CREMCRE.cestado ='D'  and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null) ")
        End If
        If cCodofi = "001" Then
        Else
            strSQL.Append(" and cremcre.coficina = @cCodofi ")
        End If

        If cbusq <> "3" Then
            strSQL.Append(" GROUP BY cremcre.ccodsol, cremsol.cnomgru, cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec ")
            strSQL.Append(" ORDER BY cremcre.dfecvig  ")
        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi

        'args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        'args(1).Value = cOficina
        'If nNivel < 9 Then
        '    strSQL.Append(" and  substring(CREMCRE.cCodCta,4,3) = @cOficina ")
        'End If

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        If cbusq = "3" Then

            Dim Ds2 As New DataSet

            Dim myview As DataView = New DataView(ds.Tables(0))

            Dim dtsinduplicar As DataTable

            dtsinduplicar = myview.ToTable(True, "codigo", "cnomcli", "ncapdes", "dfecvig", "cestado", "ccodrec")

            Ds2.Tables.Add(dtsinduplicar)

            ds = Ds2.Copy
            Dim maxFechaAprobacion As Date
            Dim fecha_aprobacion As DataColumn
            fecha_aprobacion = New DataColumn("fecha_aprobacion", System.Type.GetType("System.DateTime"))
            ds.Tables(0).Columns.Add(fecha_aprobacion)

            Dim dtFechaAprobacion As Date

            'Agregar una columna al DS y despues ordenar por esa columna
            Dim counter As Integer
            counter = 0
            For Each row As DataRow In ds.Tables(0).Rows

                'Buscar el credito de ese grupo que tenga la fecha_aprobacion mas alta
                maxFechaAprobacion = FechaAprobacionXGrupo(row("codigo"))
                row("fecha_aprobacion") = maxFechaAprobacion
            Next
            'reordenar
            Dim dt = ds.Tables(0)
            dt.DefaultView.Sort = "fecha_aprobacion DESC"
            ds.Tables.RemoveAt(0)
            ds.Tables.Add(dt.DefaultView.ToTable)
            ds.AcceptChanges()

        End If


        Return ds

    End Function

    ''Cesar Torres buscar la fecha_aprobacion mas alta por grupo
    Public Function FechaAprobacionXGrupo(ByVal ccodsol As String) As Date
        Dim MaxDate As Date

        Dim strSQL As New StringBuilder
        strSQL.Append("Select MAX(fecha_aprobacion) as maxApr FROM cremcre where ccodsol = @ccodsol AND cestado = 'E' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim dsMaxApr As DataSet

        Try
            dsMaxApr = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
            MaxDate = dsMaxApr.Tables(0).Rows(0)("maxApr").ToString()

        Catch ex As Exception
            Throw ex
        End Try

        Return MaxDate
    End Function

    'Validacion de Grupo en montos y comision monto cerrado
    '**Fer Abrego 09072015
    'pendiente---.....
    Public Function ValidadorMontosMasComison(ByVal cbxLineas As String, ByVal ccodsol As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append("Select ccodcta,cli.cnomcli,cre.ccodsol,cre.cnrolin,cre.nmonsug,gas.nmonpor ")
        strSQL.Append("From cremcre cre inner join cretgas  gas on cre.cnrolin=gas.cnrolin inner join ")
        strSQL.Append("climide cli on cre.ccodcli=cli.ccodcli where cestado='C' and cre.ccodsol=@cCodsol ")

        Dim args(0) As SqlParameter
        'args(0) = New SqlParameter("@cbxLineas", SqlDbType.VarChar)
        'args(0).Value = cbxLineas
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol


        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ListadoCreditosxGrupoPreAprobar(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, climide.cnomcli, climide.cnudoci, cremcre.nmonsug, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.nmonsol, cremcre.lsegvid, cremcre.nmonapr ")
        strSQL.Append("FROM CLIMIDE, CREMCRE ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and (cremcre.cestado = 'C' or cremcre.cestado = 'E') and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function ClientexGrupoSolicitud(ByVal ccodsol As String, ByVal ccodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta  ")
        strSQL.Append("from cremcre where cremcre.ccodcli = @ccodcli  and cremcre.cestado = 'A' ")
        strSQL.Append(" and cremcre.ccodsol = @ccodsol and (cremcre.ccodrec = ' ' or cremcre.ccodrec is null)")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol
        args(1) = New SqlParameter("@cCodcli", SqlDbType.VarChar)
        args(1).Value = ccodcli

        Dim ds As New DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try
        Dim lccodcta As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodcta")) Then

            Else
                lccodcta = ds.Tables(0).Rows(0)("ccodcta")
            End If

        End If
        Return lccodcta
    End Function


    'solicitud modificar
    Public Function ListadoCreditosxGrupoSolicitud2(ByVal ccodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.*  ")
        strSQL.Append("from cremcre where cremcre.ccodcli = @ccodsol and cremcre.cestado = 'A' ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    'solicitud nueva
    Public Function ListadoCreditosxGrupoSolicitud(ByVal ccodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select climide.cnomcli, climide.cnudoci, 500.00 as nmonsol, climide.ccodcli  ")
        strSQL.Append("from climide where climide.ccodsol = @ccodsol order by climide.cnomcli ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    'Verifica la si existen solicitudes grupales en camino
    Public Function Verifica_Solicitudes_Pendientes(ByVal cCodsol As String) As Boolean

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
                                        " Select b.cestado from cremsol a " & _
                                        " inner join cremcre b " & _
                                        " on a.cCodsol = b.ccodsol " & _
                                        " Where b.cestado in('C','E')" & _
                                        " and b.ccodsol = '" & cCodsol & "'" & _
                                        " group by b.cestado "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Solicitudes")

                If ds_Trab.Tables("Solicitudes").Rows.Count > 0 Then
                    llvalida = True
                End If


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return llvalida

    End Function


    Public Function Extrae_Resolucion_Usuario(ByVal cCodsol As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim id_usuario_comite_1 As Integer
        Dim id_usuario_comite_2 As Integer
        Dim id_usuario_comite_3 As Integer
        Dim id_usuario_comite_4 As Integer
        Dim id_usuario_comite_5 As Integer


        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                'Extrae Datos de la Resolución
                command.CommandText = _
                                        " Select b.ccodcta, a.ccodcli, a.cnomcli, a.cnudoci, b.nmonsug, b.nmonapr, b.ncuosug as ncuoapr, " & _
                                        " b.cnrolin, b.nmonsol, 00000000.00 as nmonto, b.cflat, b.cfrecint," & _
                                        " a.csexo, SPACE(80) as ctipogar, 0000000.00 as nmontas, 0000000.00 as nmongra, " & _
                                        " space(120) as cnotario, c.cnomgru, d.xfirma, d.nombre, d.xfirma, d.xfirma as xfirma1, " & _
                                        " d.xfirma as xfirma2, d.xfirma as xfirma3, d.xfirma as xfirma4, d.xfirma as xfirma5, " & _
                                        " SPACE(90) as Usuario_Comite_Des_1, SPACE(90) as Usuario_Comite_Des_2, SPACE(90) as Usuario_Comite_Des_3," & _
                                        " SPACE(90) as Usuario_Comite_Des_4, SPACE(90) as Usuario_Comite_Des_5," & _
                                        " isnull(b.usuario_comite_1,0) as usuario_comite_1, isnull(b.usuario_comite_2,0) as usuario_comite_2, " & _
                                        " isnull(b.usuario_comite_3,0) as usuario_comite_3, isnull(b.usuario_comite_4,0) as usuario_comite_4, " & _
                                        " isnull(b.usuario_comite_5,0) as usuario_comite_5, " & _
                                        " space(90) as Nivel_Comite_1, space(90) as Nivel_Comite_2, space(90) as Nivel_Comite_3, " & _
                                        " space(90) as Nivel_Comite_4, space(90) as Nivel_Comite_5 " & _
                                        " FROM CLIMIDE a " & _
                                        " Inner Join CREMCRE b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " Inner Join CREMSOL c " & _
                                        " on b.ccodsol = c.cCodsol " & _
                                        " Inner Join usuarios d " & _
                                        " on b.ccodana = d.usuario " & _
                                        " Where b.ccodsol = '" & cCodsol & "' and " & _
                                        " b.cestado IN('C','E') and (b.cCodrec=' ' or b.ccodrec is null) " & _
                                        " Order by a.cnomcli "



                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Resolucion")


                'Usuario Comodin
                command.CommandText = _
                                        " select idUsuario, usuario, nombre, xfirma from usuarios " & _
                                        " where idUsuario = 1"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios_Valida")


                'Barre la tabla para igual a un null
                For Each fila As DataRow In ds_Trab.Tables("Usuarios_Valida").Rows
                    For Each Linea As DataRow In ds_Trab.Tables("Resolucion").Rows
                        Linea("xfirma2") = fila("xfirma")
                        Linea("xfirma3") = fila("xfirma")
                        Linea("xfirma4") = fila("xfirma")
                        Linea("xfirma5") = fila("xfirma")
                    Next
                Next
                

                'Extrayendo Usuarios de Firmas

                For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                    id_usuario_comite_1 = fila("usuario_comite_1")
                    id_usuario_comite_2 = fila("usuario_comite_2")
                    id_usuario_comite_3 = fila("usuario_comite_3")
                    id_usuario_comite_4 = fila("usuario_comite_4")
                    id_usuario_comite_5 = fila("usuario_comite_5")
                Next

                

                'Extrae Usuarios
                command.CommandText = _
                                        " select idUsuario, usuario, nombre, xfirma from usuarios " & _
                                        " where idUsuario In(" & id_usuario_comite_1 & "," & id_usuario_comite_2 & "," & id_usuario_comite_3 & "," & _
                                        id_usuario_comite_4 & "," & id_usuario_comite_5 & ")"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios")

                'Extrae niveles de Comite
                Dim ds_niveles As New DataSet
                Dim miComponente As New dbTabttab
                Dim lcComite As String = ""


                For Each Linea As DataRow In ds_Trab.Tables("Usuarios").Rows
                    For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                        If fila("usuario_comite_1") = Linea("idUsuario") Then
                            fila("Nivel_Comite_1") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_2") = Linea("idUsuario") Then
                            fila("Nivel_Comite_2") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_3") = Linea("idUsuario") Then
                            fila("Nivel_Comite_3") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_4") = Linea("idUsuario") Then
                            fila("Nivel_Comite_4") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_5") = Linea("idUsuario") Then
                            fila("Nivel_Comite_5") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                    Next
                Next


                For Each Linea As DataRow In ds_Trab.Tables("Usuarios").Rows
                    For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                        If fila("usuario_comite_1") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_1") = Linea("nombre")
                            fila("xfirma1") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_2") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_2") = Linea("nombre")
                            fila("xfirma2") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_3") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_3") = Linea("nombre")
                            fila("xfirma3") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_4") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_4") = Linea("nombre")
                            fila("xfirma4") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_5") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_5") = Linea("nombre")
                            fila("xfirma5") = Linea("xfirma")
                        End If
                    Next
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
    ''Validacion por estatus menciona el estatus
    Public Function Estatus_grupal(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" Select cremcre.cestado FROM CREMCRE ")
        strSQL.Append(" WHERE cremcre.ccodsol = @cCodsol ")
        strSQL.Append(" and cremcre.cestado IN ('A' ,'C' ) ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        ''retorna estatus del grupo con informativo 
        Return ds


    End Function
    Public Function buscaCodigosClientes(ByVal ccodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" Select ccodcli FROM CREMCRE ")
        strSQL.Append(" WHERE cremcre.ccodsol = @cCodsol ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = ccodsol

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        ''retorna estatus del grupo con informativo 
        Return ds

    End Function
    'Cuenta los creditos distintos a G
    Public Function buscarCreditos(ByVal ccodcli As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append(" select COUNT(ccodcta) from cremcre ")
        strSQL.Append(" where ccodcli=@ccodcli and  cestado <> 'G' ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim conuntoCreditos As Integer

        Try
            conuntoCreditos = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        ''retorna estatus del grupo con informativo 
        Return conuntoCreditos


    End Function

    'solicitud existente
    Public Function ListadoCreditosxGrupoSugerencia(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, climide.ccodcli, climide.cnomcli, climide.cnudoci, cremcre.nmonsug, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.nmonsol, 00000000.00 as nmonto, cremcre.cflat, isnull(cremcre.digitaliza_foto,0) as digitaliza_foto, ")
        strSQL.Append("climide.csexo, SPACE(80) as ctipogar, 0000000.00 as nmontas, 0000000.00 as nmongra, space(120) as cnotario, cremsol.cnomgru ")
        strSQL.Append("FROM CLIMIDE, CREMCRE, CREMSOL ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and cremcre.ccodsol = cremsol.ccodsol ")
        strSQL.Append("and (cremcre.cestado = 'A' or cremcre.cestado = 'C') and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) order by climide.cnomcli ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ListadoCreditosxGrupoAprobar(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, climide.ccodcli, climide.cnomcli, climide.cnudoci, cremcre.nmonsug, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.nmonsol,cremcre.nmonapr, ")
        strSQL.Append("climide.csexo, SPACE(80) as ctipogar, 0000000.00 as nmontas, 0000000.00 as nmongra, space(120) as cnotario ")
        strSQL.Append("FROM CLIMIDE, CREMCRE ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and (cremcre.cestado = 'C' or cremcre.cestado = 'E') and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) order by climide.cnomcli ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ListadoCreditosxGrupoDesembolso(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcli, cremcre.ccodcta, climide.cnomcli, climide.cnudoci, cremcre.nmonapr, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.nmonsol, cremcre.dfecvig, cremcre.lsegvid, cretlin.ccodlin ")
        strSQL.Append("FROM CLIMIDE, CREMCRE, cretlin ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol and cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append("and (cremcre.cestado = 'E') and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) ")
        strSQL.Append(" order by climide.cnomcli ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerbusquedacreditoAmbos_(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, _
                                                ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, _
                                                ByVal cCodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        If cmetodologia = "1" Then
            strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec, climide.cnudoci ")
            strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu")
            strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
            If ctipo = "1" Then
                strSQL.Append(" and CLIMIDE.cnomcli like" & "'" & "%" & cnombre & "%" & "'")
            ElseIf ctipo = "2" Then
                strSQL.Append(" and CREMCRE.ccodcta like" & "'" & "%" & cnombre & "%" & "'")
            Else
                strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
            End If
            If cbusq = "1" Then
                strSQL.Append(" and CREMCRE.cestado ='A' ")
            ElseIf cbusq = "2" Then
                strSQL.Append(" and CREMCRE.cestado ='C' ")
            ElseIf cbusq = "3" Then
                strSQL.Append(" and CREMCRE.cestado ='E' ")
            ElseIf cbusq = "4" Then
                strSQL.Append(" and CREMCRE.cestado ='F' ")
            ElseIf cbusq = "5" Then

            ElseIf cbusq = "6" Then
                strSQL.Append(" and CREMCRE.cestado ='D' ")
            ElseIf cbusq = "7" Then
                strSQL.Append(" and CREMCRE.cestado ='G' ")
            End If
            'If cflag = "00" Then
            'Else
            '    If cbusq = "4" Or cbusq = "6" Or cbusq = "7" Then
            '    Else
            '        If cflag = "01" Then 'individual
            '            strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
            '        Else
            '            strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
            '        End If
            '    End If
            'End If
            'If cCodofi = "001" Or cCodofi = "037" Then
            'Else
            '    strSQL.Append(" and cremcre.coficina = @cCodofi ")
            'End If

        Else
            If cbusq = "3" Then 'Creditos en Estado de Aprobacion para desembolsar
                strSQL.Append("SELECT cremcre.ccodsol as codigo, cremsol.cnomgru as cnomcli, sum(cremcre.ncapdes) as ncapdes ,cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec ")
                strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
                strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
                strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
                ' strSQL.Append(" and CREMCRE.cestado ='E' ")
                If cbusq = "1" Then
                    strSQL.Append(" and CREMCRE.cestado ='A' ")
                ElseIf cbusq = "2" Then
                    strSQL.Append(" and CREMCRE.cestado ='C' ")
                ElseIf cbusq = "3" Then
                    strSQL.Append(" and CREMCRE.cestado ='E' ")
                ElseIf cbusq = "4" Then
                    strSQL.Append(" and CREMCRE.cestado ='F' ")
                ElseIf cbusq = "5" Then

                ElseIf cbusq = "6" Then
                    strSQL.Append(" and CREMCRE.cestado ='D' ")
                ElseIf cbusq = "7" Then
                    strSQL.Append(" and CREMCRE.cestado ='G' ")
                End If

                If ctipo = "1" Then
                    strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
                ElseIf ctipo = "2" Then
                    strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
                Else
                    strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
                End If
                'If cflag = "00" Then
                'Else
                '    If cflag = "01" Then 'individual
                '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
                '    Else
                '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
                '    End If

                'End If
                'If cCodofi = "001" Then
                'Else
                '    strSQL.Append(" and cremcre.coficina = @cCodofi ")
                'End If

                strSQL.Append(" GROUP BY cremcre.ccodsol, cremsol.cnomgru, cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec")
            Else
                strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec ")
                strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
                strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
                strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
                If ctipo = "1" Then
                    strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
                ElseIf ctipo = "2" Then
                    strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
                Else
                    strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
                End If
                If cbusq = "1" Then
                    strSQL.Append(" and CREMCRE.cestado ='A' ")
                ElseIf cbusq = "2" Then
                    strSQL.Append(" and CREMCRE.cestado ='C' ")
                ElseIf cbusq = "3" Then
                    strSQL.Append(" and CREMCRE.cestado ='E' ")
                ElseIf cbusq = "4" Then
                    strSQL.Append(" and CREMCRE.cestado ='F' ")
                ElseIf cbusq = "5" Then
                ElseIf cbusq = "6" Then
                    strSQL.Append(" and CREMCRE.cestado ='D' ")
                End If
                If cCodofi = "001" Then
                Else
                    strSQL.Append(" and cremcre.coficina = @cCodofi ")
                End If

            End If
            'If cflag = "00" Then
            'Else
            '    If cflag = "01" Then 'individual
            '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
            '    Else
            '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
            '    End If

            'End If
            'If cCodofi = "001" Then
            'Else
            '    strSQL.Append(" and cremcre.coficina = @cCodofi ")
            'End If


        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi

        'args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        'args(1).Value = cOficina
        'If nNivel < 9 Then
        '    strSQL.Append(" and  substring(CREMCRE.cCodCta,4,3) = @cOficina ")
        'End If

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ObtenerbusquedacreditoAmbos(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, _
                                                ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, _
                                                ByVal cCodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        If cmetodologia = "1" Then
            strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec, climide.cnudoci ")
            strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu")
            strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
            If ctipo = "1" Then
                strSQL.Append(" and CLIMIDE.cnomcli like" & "'" & "%" & cnombre & "%" & "'")
            ElseIf ctipo = "2" Then
                strSQL.Append(" and CREMCRE.ccodcta like" & "'" & "%" & cnombre & "%" & "'")
            Else
                strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
            End If
            If cbusq = "1" Then
                strSQL.Append(" and CREMCRE.cestado ='A' ")
            ElseIf cbusq = "2" Then
                strSQL.Append(" and CREMCRE.cestado ='C' ")
            ElseIf cbusq = "3" Then
                strSQL.Append(" and CREMCRE.cestado ='E' ")
            ElseIf cbusq = "4" Then
                strSQL.Append(" and CREMCRE.cestado ='F' ")
            ElseIf cbusq = "5" Then

            ElseIf cbusq = "6" Then
                strSQL.Append(" and CREMCRE.cestado ='D' ")
            ElseIf cbusq = "7" Then
                strSQL.Append(" and CREMCRE.cestado ='G' ")
            End If
            If cflag = "00" Then
            Else
                If cbusq = "4" Or cbusq = "6" Or cbusq = "7" Then
                Else
                    If cflag = "01" Then 'individual
                        strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
                    Else
                        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
                    End If
                End If
            End If
            'If cCodofi = "001" Or cCodofi = "037" Then
            'Else
            '    strSQL.Append(" and cremcre.coficina = @cCodofi ")
            'End If

        Else
            If cbusq = "3" Then 'Creditos en Estado de Aprobacion para desembolsar
                strSQL.Append("SELECT cremcre.ccodsol as codigo, cremsol.cnomgru as cnomcli, sum(cremcre.ncapdes) as ncapdes ,cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec ")
                strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
                strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
                strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
                ' strSQL.Append(" and CREMCRE.cestado ='E' ")
                If cbusq = "1" Then
                    strSQL.Append(" and CREMCRE.cestado ='A' ")
                ElseIf cbusq = "2" Then
                    strSQL.Append(" and CREMCRE.cestado ='C' ")
                ElseIf cbusq = "3" Then
                    strSQL.Append(" and CREMCRE.cestado ='E' ")
                ElseIf cbusq = "4" Then
                    strSQL.Append(" and CREMCRE.cestado ='F' ")
                ElseIf cbusq = "5" Then

                ElseIf cbusq = "6" Then
                    strSQL.Append(" and CREMCRE.cestado ='D' ")
                ElseIf cbusq = "7" Then
                    strSQL.Append(" and CREMCRE.cestado ='G' ")
                End If

                If ctipo = "1" Then
                    strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
                ElseIf ctipo = "2" Then
                    strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
                Else
                    strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
                End If
                'If cflag = "00" Then
                'Else
                '    If cflag = "01" Then 'individual
                '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
                '    Else
                '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
                '    End If

                'End If
                'If cCodofi = "001" Then
                'Else
                '    strSQL.Append(" and cremcre.coficina = @cCodofi ")
                'End If

                strSQL.Append(" GROUP BY cremcre.ccodsol, cremsol.cnomgru, cremcre.dfecvig, cremcre.cestado, cremcre.ccodrec")
            Else
                strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec ")
                strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu, cremsol")
                strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
                strSQL.Append(" and Cremcre.ccodsol = cremsol.ccodsol ")
                If ctipo = "1" Then
                    strSQL.Append(" and CREMSOL.cnomgru like" & "'" & "%" & cnombre & "%" & "'")
                ElseIf ctipo = "2" Then
                    strSQL.Append(" and CREMSOL.ccodsol like" & "'" & "%" & cnombre & "%" & "'")
                Else
                    strSQL.Append(" and CLIMIDE.cnudoci like" & "'" & "%" & cnombre & "%" & "'")
                End If
                If cbusq = "1" Then
                    strSQL.Append(" and CREMCRE.cestado ='A' ")
                ElseIf cbusq = "2" Then
                    strSQL.Append(" and CREMCRE.cestado ='C' ")
                ElseIf cbusq = "3" Then
                    strSQL.Append(" and CREMCRE.cestado ='E' ")
                ElseIf cbusq = "4" Then
                    strSQL.Append(" and CREMCRE.cestado ='F' ")
                ElseIf cbusq = "5" Then
                ElseIf cbusq = "6" Then
                    strSQL.Append(" and CREMCRE.cestado ='D' ")
                End If
                If cCodofi = "001" Then
                Else
                    strSQL.Append(" and cremcre.coficina = @cCodofi ")
                End If

            End If
            'If cflag = "00" Then
            'Else
            '    If cflag = "01" Then 'individual
            '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) = '01' ")
            '    Else
            '        strSQL.Append(" and substring(cremcre.ccodcta,7,2) <> '01' ")
            '    End If

            'End If
            'If cCodofi = "001" Then
            'Else
            '    strSQL.Append(" and cremcre.coficina = @cCodofi ")
            'End If


        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi

        'args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        'args(1).Value = cOficina
        'If nNivel < 9 Then
        '    strSQL.Append(" and  substring(CREMCRE.cCodCta,4,3) = @cOficina ")
        'End If

        Dim ds As DataSet

        Dim cadena = strSQL.ToString()

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    Public Function CargaFechas(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select dFecvig from cremcre ")
        strSQL.Append(" WHERE  CREMCRE.cCodsol = @cCodsol ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ")
        'strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        'strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND CREDKAR.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")
        strSQL.Append(" GROUP BY dfecvig order by dfecvig desc")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        'args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        'args(1).Value = dfecha2


        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds



    End Function

    Public Function HistoricoGrupal(ByVal cCodsol As String, ByVal dfecvig As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select case credkar.cdescob when 'D' then '' else credkar.cnuming end as cnuming, credkar.cnumrec,  ")
        strSQL.Append("00000000000.00 as nsaldo, ")
        strSQL.Append("credkar.dfecsis, ")
        strSQL.Append("credkar.dfecpro,  ")
        strSQL.Append("ncapdes = sum(case when credkar.cConcep = 'KP' and credkar.cdescob = 'D'  then credkar.nmonto else 0 end), ")
        strSQL.Append("ncapita = sum(case when credkar.cConcep  = 'KP' then credkar.nMonto else 0 end), ")
        strSQL.Append("nintere = sum(case when credkar.cConcep  = 'IN' then credkar.nMonto else 0 end), ")
        strSQL.Append("notros = sum(case when credkar.cConcep  <> 'KP' and credkar.cConcep <> 'IN' and credkar.cConcep <> 'MO' and credkar.cConcep <> 'CJ' then credkar.nMonto else 0 end), ")
        strSQL.Append("nmora = sum(case when credkar.cConcep  = 'MO' then credkar.nMonto else 0 end), ")
        strSQL.Append("npago = sum(case when credkar.cConcep  = 'CJ' then credkar.nMonto else 0 end), ")
        strSQL.Append("cDescob = MAX(case when credkar.cDescob  = 'D' then 'D' else 'C' end)  ")
        strSQL.Append("from cremcre join credkar ")
        strSQL.Append("  on cremcre.ccodcta = credkar.ccodcta  ")
        strSQL.Append("   WHERE cremcre.ccodsol = @cCodsol ")
        strSQL.Append("   and cremcre.dfecvig >= @dfecvig and cremcre.dfecvig<= @dfecvig  ")
        strSQL.Append("   and credkar.cestado = ' '  ")
        strSQL.Append(" GROUP BY credkar.DFECSIS, credkar.cdescob, credkar.cnuming , credkar.cnumrec, credkar.dfecpro ")
        strSQL.Append(" order by credkar.dfecsis, credkar.dfecpro ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(1).Value = dfecvig


        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    'Reporte Validacion Cartera y Contabilidad'>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<
    Public Function ValidadorPlusCierre(ByVal dfecha As Date, ByVal coficina As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT A.ccodigo, A.cdescri, 0000000.00 as NCAPITA1, 0000000.00 as NDESEMB1, 0000000.00 as NCAPITArev1, 0000000.00 as NDESEMBrev1,  ")
        strSQL.Append(" NCAPITA     = SUM(CASE  WHEN B.CCONCEP = 'CJ' and B.cdescob = 'C' and B.cestado = ' ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append(" NDESEMB     = SUM(CASE  WHEN B.CCONCEP = 'CJ' and B.cdescob = 'D' and B.cestado = ' ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append(" NCAPITArev  = SUM(CASE  WHEN B.CCONCEP = 'CJ' and B.cdescob = 'C' and B.cestado = 'X' THEN NMONTO ELSE 0 END), ")
        strSQL.Append(" NDESEMBrev  = SUM(CASE  WHEN B.CCONCEP = 'CJ' and B.cdescob = 'D' and B.cestado = 'X' THEN NMONTO ELSE 0 END) ")
        strSQL.Append(" FROM tabttab A , credkar B, cremcre C, cretlin D ")
        strSQL.Append(" WHERE A.ccodtab ='033' and A.ctipreg ='1' ")
        strSQL.Append(" and C.cnrolin = D.cnrolin and B.ccodcta = C.ccodcta ")
        strSQL.Append(" and substring(D.ccodlin, 3,2)  = left(A.ccodigo,2) ")
        strSQL.Append(" and B.dfecsis = @dfecha ")
        If coficina = "001" Then
        Else
            strSQL.Append(" and C.coficina = @coficina ")
        End If
        strSQL.Append(" GROUP BY A.ccodigo, A.cdescri ")
        strSQL.Append(" ORDER BY a.ccodigo ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@coficina", SqlDbType.VarChar)
        args(1).Value = coficina

        Dim ds As New DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Dim fila As DataRow
        Dim fila1 As DataRow
        Dim i As Integer = 0

        Dim lccodigo As String = ""
        For Each fila In ds.Tables(0).Rows
            lccodigo = ds.Tables(0).Rows(i)("cCodigo")
            Dim ds1 As New DataSet
            Dim y As Integer = 0
            ds1 = ValidadorPlusCierreConta(dfecha, coficina, lccodigo.Trim)
            For Each fila1 In ds1.Tables(0).Rows
                ds.Tables(0).Rows(i)("NCAPITA1") = IIf(IsDBNull(ds1.Tables(0).Rows(y)("NCAPITA1")), 0, ds1.Tables(0).Rows(y)("NCAPITA1"))
                ds.Tables(0).Rows(i)("NDESEMB1") = IIf(IsDBNull(ds1.Tables(0).Rows(y)("NDESEMB1")), 0, ds1.Tables(0).Rows(y)("NDESEMB1"))
                ds.Tables(0).Rows(i)("NCAPITArev1") = IIf(IsDBNull(ds1.Tables(0).Rows(y)("NCAPITArev1")), 0, ds1.Tables(0).Rows(y)("NCAPITArev1"))
                ds.Tables(0).Rows(i)("NDESEMBrev1") = IIf(IsDBNull(ds1.Tables(0).Rows(y)("NDESEMBrev1")), 0, ds1.Tables(0).Rows(y)("NDESEMBrev1"))

                y += 1
            Next
            i += 1
        Next

        Return ds

    End Function
    Public Function SaldoTotalxAgenciaConta(ByVal lcoficina As String, ByVal dfecha2 As Date) As Double
        Dim strSQL As New StringBuilder
        Dim ecntaprm As New dbCntaprm
        Dim ds1 As New DataSet
        Dim ncanti As Integer = 0
        ds1 = ecntaprm.ObtenerDataSetPorID("99", Me.cnnStr)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Return 0
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        strSQL.Append("SELECT SUM(cntamov.ndebe-cntamov.nhaber) as nsaldo FROM cntamov ")
        strSQL.Append("WHERE  ")
        strSQL.Append(" (left(cntamov.ccodcta,5) = '10301' or left(cntamov.ccodcta,5) = '10302' or left(cntamov.ccodcta,5) = '10303') ")
        strSQL.Append(" and cntamov.cflc = ' '")
        strSQL.Append(" and cntamov.dfeccnt >= @ldfecinicial and cntamov.dfeccnt <= @dfecha2 ")
        If lcoficina <> "*" Then
            strSQL.Append("AND cntamov.ccodofi = @lcoficina ")
        End If

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(0).Value = dfecha2
        args(1) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(1).Value = lcoficina
        args(2) = New SqlParameter("@ldfecinicial", SqlDbType.DateTime)
        args(2).Value = ldfecinicial

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lnsaldo As Double = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nsaldo")) Then
            Else
                lnsaldo = ds.Tables(0).Rows(0)("nsaldo")
            End If
        End If
        Return lnsaldo
    End Function
    Public Function SaldoTotalxAgencia(ByVal lcoficina As String, ByVal dfecha2 As Date) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")


        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")

        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")

        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G')  ")
        strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
        strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        strSQL.Append(" and CREMCRE.cCondic <> 'S' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(0).Value = dfecha2
        args(1) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(1).Value = lcoficina

        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnsaldo As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnsaldot As Double = 0

        '     Try
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        For Each fila In ds.Tables(0).Rows
            lncapdes = ds.Tables(0).Rows(i)("ncapdes")
            lncappag = ds.Tables(0).Rows(i)("ncappag")
            lnsaldo = lncapdes - lncappag
            lnsaldot = lnsaldot + lnsaldo
            i += 1
        Next
        Return lnsaldot
        '       Catch ex As Exception
        '          Return lnsaldot
        '        End Try


    End Function


    Public Function CarteraCalculadaUseEstado(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, CREMCRE.coficina, ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria, cretlin.ntasmor, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strSQL.Append(" ,cremcre.ctipgar, climide.cnudoci, climide.cnudotr ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
        strSQL.Append(" and (cremcre.cestado ='F' ) ") 
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ") '
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        'strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona

        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function


    Public Function CarteraCalculadaXXX(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim myconnection As SqlConnection
        Dim mycommand As SqlDataAdapter


        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        Dim sql_ As String
        Dim ds As New DataSet

        Dim vCadena As String = Me.cnnStr

        'Envia nueva cadena de conexion para Backup


        'Try

        ' vCadena = vCadena.Replace(BdAct.Trim, BdRpt.Trim)

        myconnection = New SqlConnection(vCadena)


        sql_ = _
             "SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint," & _
             "cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria, " & _
             "cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen," & _
             "case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes," & _
             "case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag " & _
             " ,cremcre.ctipgar, climide.cnudoci, climide.cnudotr " & _
             " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin " & _
             " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  " & _
             " INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  " & _
             " INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  " & _
             " WHERE CREMCRE.dfecvig <= '" & dfecha2 & "'" & _
             " and (cremcre.cestado ='F' or cremcre.cestado='G') " & _
             " and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > " & _
             "     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <='" & dfecha2 & "'" & " AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      "


        If cancela = "1" Then
            sql_ = sql_ & "AND CREMCRE.dfecvig >='" & dfecha1 & "'"
            sql_ = sql_ & "AND CREMCRE.cestado = 'G' "
        Else
            If cancela = "2" Then ' para los vencimientos
                sql_ = sql_ & " AND CREMCRE.dfecven >= dfecha1 and CREMCRE.dfecven <= '" & dfecha2 & "'"
            Else
            End If
        End If

        If lcanalista <> "*" Then
            sql_ = sql_ & " and cremcre.cCodana ='" & lcanalista & "'"
        End If
        If lcoficina <> "*" Then
            sql_ = sql_ & " and cremcre.coficina ='" & lcoficina & "'"
        End If
        If lclineas <> "*" Then
            sql_ = sql_ & " and substring(C.ccodlin,3,2) = '" & lclineas & "'"
        End If
        If lczona <> "*" Then
            sql_ = sql_ & " and LEFT(climide.cCoddom,4)= '" & lczona & "'"
        End If

        If lccartera <> "*" Then
            sql_ = sql_ & " AND CREMCRE.ccondic = '" & lccartera & "'"
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    sql_ = sql_ & " AND CREMCRE.ccondic = 'S' "
                Else
                    sql_ = sql_ & " AND CREMCRE.ccondic <> 'S' "
                End If
            End If
        End If
        sql_ = sql_ & " ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli"



        mycommand = New SqlDataAdapter(sql_, myconnection)

        myconnection.Open()



        mycommand.Fill(ds, "Reportes")

        myconnection.Close()




        'Catch ex As Exception
        '    Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
        '    Console.WriteLine("  Message: {0}", ex.Message)
        'End Try
        Dim ds1 As New DataSet
        Return ds


        'Nuevo
        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function Cadenabk(ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from BACKUPDATOS ")
        strSQL.Append("WHERE dfecha >= @dfecha and dfecha <= @dfecha ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function CadenaActual() As String
        Return Me.cnnStr
    End Function
    Public Function CadenaDatos(ByVal dfecha As Date) As String
        Dim ds As New DataSet
        ds = Cadenabk(dfecha)
        Dim cadena As String = Me.cnnStr
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("base")) Then
            Else
                Dim lcbase As String = ""
                lcbase = ds.Tables(0).Rows(0)("base")
                cadena = Me.cnnStr.Replace("AMIGA", lcbase)
            End If
        End If
        Return cadena
    End Function

    Public Function ValidadorPlusCierreConta(ByVal dfecha As Date, ByVal coficina As String, ByVal ffondo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT   ")
        strSQL.Append(" NCAPITA1     = SUM(CASE  WHEN B.cpoliza = 'ING' and left(B.cCodcta,6) = '101103'  and B.cflc = ' ' THEN B.ndebe ELSE 0 END),  ")
        strSQL.Append(" NDESEMB1     = SUM(CASE  WHEN B.cpoliza = 'EG' and left(B.cCodcta,6) = '101103'  and B.cflc = ' ' THEN B.nhaber ELSE 0 END),  ")
        strSQL.Append(" NCAPITArev1  = SUM(CASE  WHEN B.cpoliza = 'RV' and left(B.cCodcta,6) = '101103'  and B.cflc = ' ' and B.cnumdoc like '%REV/%' THEN B.nhaber ELSE 0 END),  ")
        strSQL.Append(" NDESEMBrev1  = SUM(CASE  WHEN B.cpoliza = 'RV' and left(B.cCodcta,6) = '101103'  and B.cflc = ' ' and B.cConcepto like '%REVERSION DE DESEMBOLSO%' THEN B.ndebe ELSE 0 END) ")
        strSQL.Append(" FROM cntamov B, cremcre C, cretlin D  ")
        strSQL.Append(" WHERE ")
        strSQL.Append("  C.cnrolin = D.cnrolin and B.ccodpres = C.ccodcta  ")
        strSQL.Append(" and B.ffondos  = @ffondo ")
        strSQL.Append(" and B.dfeccnt >= @dfecha and  B.dfeccnt <= @dfecha")
        If coficina = "001" Then
        Else
            strSQL.Append(" and C.coficina = @coficina ")
        End If
        'strSQL.Append(" GROUP BY A.ccodigo, A.cdescri ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(0).Value = dfecha
        args(1) = New SqlParameter("@coficina", SqlDbType.VarChar)
        args(1).Value = coficina
        args(2) = New SqlParameter("@ffondo", SqlDbType.VarChar)
        args(2).Value = ffondo

        Dim ds As New DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    Public Function DETALLE_CARTERA_Y_PAGOS_AJUSTES(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex(strSQL)



        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and (left(C.cnuming,9) <>'CANC/REFI' or c.cnuming is null)) ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' and C.CTIPPAG = 'P' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        'strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec, C.cTippag, C.cCodOfi, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru ")
        '        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,  C.cTippag, C.cCodOfi, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin ")

        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,   C.cTippag, B.coficina, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin,L.ccodlin, B.ccodana, F.cnomusu, B.cflat ")


        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
                lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
                lnciclo = Me.Ciclo(lccodcli, lccodcta)
                ds.Tables(0).Rows(ele)("nciclo") = lnciclo
                ele += 1
            Next
        End If
        Return ds

    End Function

    '>>>>>>>>>>>>>>>>>>>>>>Creditos con ajuste en plan de pagos
    Public Function CarteraCalculadaCondicionTras(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint,  ")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, CREMCRE.coficina, CREMCRE.cnrolin, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")

        strSQL.Append(" ,cremcre.ctipgar, climide.cnudoci, climide.cnudotr ")

        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")

        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")


        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)
        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If

        strSQL.Append(" and cremcre.ccontra = 'A' ")

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If


        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function

    Public Function ListadoCreditosxGrupoVigencia(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, climide.cnomcli, climide.cnudoci, cremcre.nmonsug, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.ncapdes as  nmonsol , 00000000.00 as nmonto, cremcre.cflat ")
        strSQL.Append("FROM CLIMIDE, CREMCRE ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and cremcre.cestado = 'F'  and dfecvig >= @dfecha and dfecvig <= @dfecha ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha


        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function CreditosxGrupoVigencia(ByVal cCodsol As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta ")
        strSQL.Append("FROM CLIMIDE, CREMCRE ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and cremcre.cestado = 'F'  ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim lccodcta As String = ""
        Dim ds As New DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
            If ds.Tables(0).Rows.Count = 0 Then
                lccodcta = ""
            Else
                lccodcta = IIf(IsDBNull(ds.Tables(0).Rows(0)("cCodcta")), "", ds.Tables(0).Rows(0)("cCodcta"))
            End If
        Catch ex As Exception
            lccodcta = ""
        End Try

        Return lccodcta

    End Function
    'GENERA DESEMBOLSOS CONSOLIDADOS
    Public Function ConsolidadoCreditosOtorgados(ByVal Fondo As String, ByVal Agencia As String, ByVal FechaInicio As String, ByVal FechaFin As String, ByRef TotalCreditosOtorgados As Decimal, ByRef MontoOtorgado As Decimal, ByRef Promedio As Decimal, ByVal canalista As String) As DataTable

        Dim strCadena As String
        Dim strFondo As String
        Dim strAgencia As String
        Dim strProducto As String
        Dim strFecha As String
        Dim strAnalista As String
        Dim strRango1 As String
        Dim strRango2 As String
        Dim strRango3 As String
        Dim strRango4 As String
        Dim drResultado As SqlDataReader
        Dim dtTabla As New DataTable("creditosotorgados")
        Dim fila As Data.DataRow
        Dim filacompleta() As Data.DataRow
        Dim strNombreProducto As String
        Dim i As Integer
        Dim j As Integer


        'tabla para guardar datos temporales antes de mandarlo al reporte

        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim creditosotorgados As DataColumn = New DataColumn("creditosotorgados")
        Dim individuales As DataColumn = New DataColumn("individuales")
        Dim bc As DataColumn = New DataColumn("bc")
        Dim gs As DataColumn = New DataColumn("gs")

        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        creditosotorgados.DataType = System.Type.GetType("System.String")
        individuales.DataType = System.Type.GetType("System.Decimal")
        bc.DataType = System.Type.GetType("System.Decimal")
        gs.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(creditosotorgados)
        dtTabla.Columns.Add(individuales)
        dtTabla.Columns.Add(bc)
        dtTabla.Columns.Add(gs)


        For i = 1 To 8

            fila = dtTabla.NewRow()
            fila("id") = Integer.Parse(i.ToString)
            fila("individuales") = Decimal.Parse("0.0")
            fila("bc") = Decimal.Parse("0.0")
            fila("gs") = Decimal.Parse("0.0")
            Select Case i
                Case 1, 5
                    fila("creditosotorgados") = "hasta 5,000"
                Case 2, 6
                    fila("creditosotorgados") = "Entre Q.5,001 y Q.10,000"
                Case 3, 7
                    fila("creditosotorgados") = "Entre Q.10,001 y Q.30,000"
                Case 4, 8
                    fila("creditosotorgados") = "Más de Q.30,000"
            End Select
            dtTabla.Rows.Add(fila)
        Next

        strFondo = ""
        strAgencia = ""
        strProducto = ""
        strAnalista = ""


        Dim cmComando As New SqlCommand

        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "'"
            End If

            If Agencia <> "*" Then
                strAgencia = " and Cremcre.coficina= '" + Agencia + "'"
            End If

            If canalista <> "*" Then
                strAnalista = " and Cremcre.ccodana= '" + canalista + "'"
            End If

            strFecha = " and CREDKAR.dfecsis between '" + FechaInicio + "' and '" + FechaFin + "'"
            strRango1 = " and CREDKAR.nmonto between 0 and 5000 "
            strRango2 = " and CREDKAR.nmonto between 5001 and 10000 "
            strRango3 = " and CREDKAR.nmonto between 10001 and 30000 "
            strRango4 = " and CREDKAR.nmonto >30000"


            'OBTIENE LOS TOTALES PARA DESPUES MANDARLOS COMO PARAMETRO

            strCadena = " " & _
            " select count(CREDKAR.CCODCTA) as creditos, " & _
            " case when " & _
            " sum(CREDKAR.nmonto) is null then 0 " & _
            " else " & _
            " sum(CREDKAR.nmonto) end  as monto, " & _
            " case when " & _
            " avg(CREDKAR.nmonto) is null then 0 " & _
            " else " & _
            " avg(CREDKAR.nmonto) end  as promedio" & _
            " FROM CREDKAR inner join cremcre on cremcre.ccodcta=credkar.ccodcta " & _
            " inner join cretlin on cremcre.cnrolin=cretlin.cnrolin " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='D' " & _
            " and (CREMCRE.cestado='F' or  CREMCRE.cestado='G')" & _
            " and CREDKAR.cconcep='KP' " + strFondo + strAgencia + strAnalista + strFecha

            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion
            drResultado = cmComando.ExecuteReader
            If drResultado.Read Then
                TotalCreditosOtorgados = Decimal.Parse(drResultado.Item("creditos").ToString)
                MontoOtorgado = Decimal.Parse(drResultado.Item("monto").ToString)
                Promedio = Decimal.Parse(drResultado.Item("promedio").ToString)
            End If
            cmComando.Dispose()
            drResultado.Close()

            '********************************************************************************
            For j = 1 To 3

                strProducto = " and substring(CREDKAR.ccodcta,7,2)= '0" + j.ToString + "'"

                Select Case j
                    Case 1
                        strNombreProducto = "individuales"
                    Case 2
                        strNombreProducto = "bc"
                    Case 3
                        strNombreProducto = "gs"
                End Select

                For i = 1 To 4

                    strCadena = " " & _
                            " select count(CREDKAR.CCODCTA) as creditos, " & _
                            " case when " & _
                            " sum(CREDKAR.nmonto) is null then 0 " & _
                            " else " & _
                            " sum(CREDKAR.nmonto) end  as monto " & _
                            " FROM CREDKAR inner join cremcre on cremcre.ccodcta=credkar.ccodcta " & _
                            " inner join cretlin on cremcre.cnrolin=cretlin.cnrolin " & _
                            " WHERE CREDKAR.cestado='' " & _
                            " and CREDKAR.cdescob='D' " & _
                            " and (CREMCRE.cestado='F' or  CREMCRE.cestado='G') " & _
                            " and CREDKAR.cconcep='KP' " + strFondo + strProducto + strAgencia + strAnalista + strFecha

                    Select Case i

                        Case 1
                            strCadena = strCadena + strRango1

                            cmComando.CommandText = strCadena
                            cmComando.Connection = cnConexion
                            drResultado = cmComando.ExecuteReader

                            'ACTUALIZA TABLA CON LOS VALORES DEL PRIMER RANGO
                            If drResultado.Read Then
                                filacompleta = dtTabla.Select("id=1")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("creditos").ToString)
                                filacompleta = dtTabla.Select("id=5")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("monto").ToString)
                            End If

                        Case 2

                            strCadena = strCadena + strRango2

                            cmComando.CommandText = strCadena
                            cmComando.Connection = cnConexion
                            drResultado = cmComando.ExecuteReader

                            'ACTUALIZA TABLA CON LOS VALORES DEL SEGUNDO RANGO
                            If drResultado.Read Then
                                filacompleta = dtTabla.Select("id=2")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("creditos").ToString)
                                filacompleta = dtTabla.Select("id=6")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("monto").ToString)
                            End If
                        Case 3
                            strCadena = strCadena + strRango3

                            cmComando.CommandText = strCadena
                            cmComando.Connection = cnConexion
                            drResultado = cmComando.ExecuteReader

                            'ACTUALIZA TABLA CON LOS VALORES DEL TERCER RANGO
                            If drResultado.Read Then
                                filacompleta = dtTabla.Select("id=3")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("creditos").ToString)
                                filacompleta = dtTabla.Select("id=7")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("monto").ToString)
                            End If
                        Case 4
                            strCadena = strCadena + strRango4

                            cmComando.CommandText = strCadena
                            cmComando.Connection = cnConexion
                            drResultado = cmComando.ExecuteReader

                            'ACTUALIZA TABLA CON LOS VALORES DEL CUARTO RANGO
                            If drResultado.Read Then
                                filacompleta = dtTabla.Select("id=4")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("creditos").ToString)
                                filacompleta = dtTabla.Select("id=8")
                                filacompleta(0)(strNombreProducto) = Decimal.Parse(drResultado.Item("monto").ToString)
                            End If
                    End Select
                    strCadena = ""
                    cmComando.Dispose()
                    drResultado.Close()
                Next
            Next

        End Using

        Return dtTabla
    End Function
    Public Function ConsultaFDL(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim strSQL As New StringBuilder


        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If

        strSQL.Append(" SELECT DISTINCT ('REF:' + CREMCRE.ccodcli) as cCodcli , CONVERT(char(10),CREMCRE.dfecsol,103) as dfecsol,CLIMIDE.csexo,  ")
        strSQL.Append(" case when (SELECT TABTTAB.cdescri FROM TABTTAB WHERE TABTTAB.ccodtab = '150' and left(tabttab.ccodigo,1) =  left(CLIMIDE.cetnia,1)  ) is null then 'Indigena' else (SELECT TABTTAB.cdescri FROM TABTTAB WHERE TABTTAB.ccodtab = '150' and left(tabttab.ccodigo,1) =  left(CLIMIDE.cetnia,1)  )  end as Etnia,   ")
        strSQL.Append(" case when (SELECT count(CLIMHIJ.ccodcli) FROM CLIMHIJ WHERE CLIMHIJ.CCODCLI= CREMCRE.CCODCLI  GROUP BY CLIMHIJ.CCODCLI) is null then 0  end as Hijos,   ")
        strSQL.Append(" CREMCRE.coficina, ('REF:' + CREMCRE.cCodCta) as cCodcta,CONVERT(char(10), cremcre.dfecvig, 103) AS FechaOtorgamiento,CONVERT(char(10), cremcre.dfecven, 103) AS FechaVencimiento,  ")
        strSQL.Append(" CREMCRE.ncuoapr,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes,  ")
        strSQL.Append(" CREMCRE.nmoncuo,CREMCRE.cfreccap,CREMCRE.cfrecint,  ")
        strSQL.Append(" case when (SELECT (CLIDFAMI.ningcony+CLIDFAMI.ningfami+CLIDFAMI.ningsspc+CLIDFAMI.ningvari+CLIDFAMI.ningreme) FROM CLIDFAMI WHERE CLIDFAMI.CCODCLI= CREMCRE.CCODCLI  GROUP BY CLIDFAMI.CCODCLI,CLIDFAMI.ningcony+CLIDFAMI.ningfami+CLIDFAMI.ningsspc+CLIDFAMI.ningvari+CLIDFAMI.ningreme) is null then 0  end as Ingresos,   ")
        strSQL.Append(" substring(CREMCRE.ccodcta,7,2) as producto,  ")
        'strSQL.Append(" case when (SELECT TABTTAB.cdescri FROM TABTTAB WHERE TABTTAB.ccodtab+TABTTAB.ctipreg+TABTTAB.ccodigo= ('0371'+CREMCRE.ctipgar) and  TABTTAB.ccodigo=CREMCRE.ctipgar) is null then 'GARANTIA'  end as Garantia,   ")
        strSQL.Append(" case when (SELECT TABTTAB.cdescri FROM TABTTAB WHERE TABTTAB.ccodtab = '074' and left(tabttab.ccodigo,2) =  left(CREMCRE.ctipgar,2)  ) is null then 'FIDUCIARIA' else (SELECT TABTTAB.cdescri FROM TABTTAB WHERE TABTTAB.ccodtab = '074' and left(tabttab.ccodigo,2) =  left(CREMCRE.ctipgar,2)  )  end as Garantia,   ")
        'strSQL.Append(" ,case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA and CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' AND CREMCRE.CESTADO='F' and cremcre.dfecvig<=@dfecha2 GROUP BY CREDKAR.CCODCTA)is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  and CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' AND CREMCRE.CESTADO='F' and cremcre.dfecvig<= @dfecha2) end as Saldo   ")
        strSQL.Append(" (case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end - ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end) AS Saldo,  ")


        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= cremcre.dultpag and credkar.dfecsis<= cremcre.dultpag and  credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'CJ' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= cremcre.dultpag and credkar.dfecsis<= cremcre.dultpag AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'CJ' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as UltimoPago,  ")

        strSQL.Append(" CONVERT(char(10), CREMCRE.dultpag, 103) AS FechaUltimoPago, cremcre.cestado  ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")

        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If



        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If


        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        'strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString


        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        'ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds

    End Function

    'Reportes Adicionados
    'GENERA CREDITOS POR PLAZO
    Public Function CreditosPorPlazo(ByVal Fondo As String, ByVal Agencia As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strTipoCartera As String = ""
        Dim strAgenciaCredkar As String = ""
        Dim strAgenciaCremcre As String = ""
        Dim strProducto As String = ""
        Dim strFecha As String = ""
        Dim strRango1 As String = ""
        Dim strRango2 As String = ""
        Dim strRango3 As String = ""
        Dim strRango4 As String = ""
        Dim strPlazo As String = ""
        Dim drResultado As SqlDataReader
        Dim dtTabla As New DataTable("creditosporplazo")
        Dim fila As Data.DataRow
        Dim strDescripcion As String = ""
        Dim i As Integer


        Dim cadenaactual As String
        Dim cadena As String


        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim descripcion As DataColumn = New DataColumn("descripcion")
        Dim creditosbuenos As DataColumn = New DataColumn("creditosbuenos")
        Dim saldocapital As DataColumn = New DataColumn("saldocapital")
        Dim creditoscontaminados As DataColumn = New DataColumn("creditoscontaminados")
        Dim saldocontaminado As DataColumn = New DataColumn("saldocontaminado")

        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        descripcion.DataType = System.Type.GetType("System.String")
        creditosbuenos.DataType = System.Type.GetType("System.Decimal")
        saldocapital.DataType = System.Type.GetType("System.Decimal")
        creditoscontaminados.DataType = System.Type.GetType("System.Decimal")
        saldocontaminado.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(descripcion)
        dtTabla.Columns.Add(creditosbuenos)
        dtTabla.Columns.Add(saldocapital)
        dtTabla.Columns.Add(creditoscontaminados)
        dtTabla.Columns.Add(saldocontaminado)


        Dim cmComando As New SqlCommand
        Dim drTemporal As SqlDataReader
        Dim strBaseTemporal As String = ""

        'VERIFICA SI GENERA EL REPORTE EN EL BACKUP O EN LA RAIZ
        'Using cnTemporal As New SqlConnection(Me.cnnStr)
        '    cnTemporal.Open()
        '    cmComando.Connection = cnTemporal
        '    cmComando.CommandText = "select base from backupdatos where right(CONVERT(VARCHAR(10), dfecha, 103),7)='" + Right(FechaFin, 7) + "'"
        '    drTemporal = cmComando.ExecuteReader
        '    If drTemporal.Read Then
        '        strBaseTemporal = drTemporal.Item("base").ToString
        '    End If
        '    drTemporal.Close()
        '    cmComando.Dispose()
        '    cnTemporal.Close()
        'End Using

        'If strBaseTemporal <> "" Then
        '    cadena = Replace(cadena, "Fondesol", strBaseTemporal)
        'End If

        cadenaactual = Me.cnnStr
        'cadena = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(FechaFin))
        If cadena.Trim = cadenaactual.Trim Then
            cadena = cadenaactual
        End If

        Using cnConexion As New SqlConnection(cadena)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "'"
            End If

            'segun fran se filtra el campo coficina
            If Agencia <> "*" Then
                strAgenciaCredkar = " and CREMCRE.COFICINA= '" + Agencia + "'"
                strAgenciaCremcre = " and CREMCRE.COFICINA= '" + Agencia + "'"
            End If

            If TipoCartera <> "*" Then
                If TipoCartera = "I" Then
                    strTipoCartera = " AND CREMCRE.ccondic = 'S' "
                Else
                    strTipoCartera = " AND CREMCRE.ccondic <> 'S' "
                End If
            End If

            strFecha = " and CREMCRE.dfecvig<='" + FechaFin + "'"

            For i = 1 To 2

                If i = 1 Then
                    strPlazo = " AND LEFT(CRETLIN.CCODLIN,2)<>'12' "
                    strDescripcion = "CORTO PLAZO"
                Else
                    strPlazo = " AND LEFT(CRETLIN.CCODLIN,2)='12' "
                    strDescripcion = "LARGO PLAZO"
                End If

                'OBTIENE LOS TOTALES PARA DESPUES MANDARLOS COMO PARAMETRO
                strCadena = " " & _
                " SELECT (  " & _
                " SELECT SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN  " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strPlazo + strFondo + strAgenciaCredkar + strTipoCartera + strFecha & _
                " )-( " & _
                " SELECT SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'C'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strPlazo + strFondo + strAgenciaCredkar + strTipoCartera + strFecha & _
                " ) as saldocapital, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " + strPlazo + strFondo + strAgenciaCremcre + strTipoCartera + strFecha & _
                " ) as creditosbuenos, " & _
                " ( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strPlazo + strFondo + strAgenciaCredkar + strTipoCartera + strFecha & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strPlazo + strFondo + strAgenciaCredkar + strTipoCartera + strFecha & _
                " ) end   " & _
                " )-( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strPlazo + strFondo + strAgenciaCredkar + strTipoCartera + strFecha & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strPlazo + strFondo + strAgenciaCredkar + strTipoCartera + strFecha & _
                " ) end   " & _
                " ) as saldocontaminado, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " & _
                " and cremcre.ndiaatr>0 " + strPlazo + strFondo + strAgenciaCremcre + strTipoCartera + strFecha & _
                " ) as creditoscontaminados "


                cmComando.CommandText = strCadena
                cmComando.Connection = cnConexion
                drResultado = cmComando.ExecuteReader
                If drResultado.Read Then
                    fila = dtTabla.NewRow()
                    fila("id") = i
                    fila("descripcion") = strDescripcion
                    fila("saldocapital") = Decimal.Parse(IIf(IsDBNull(drResultado.Item("saldocapital")), 0, drResultado.Item("saldocapital")).ToString)
                    fila("creditosbuenos") = Decimal.Parse(IIf(IsDBNull(drResultado.Item("creditosbuenos")), 0, drResultado.Item("creditosbuenos")).ToString)
                    fila("saldocontaminado") = Decimal.Parse(IIf(IsDBNull(drResultado.Item("saldocontaminado")), 0, drResultado.Item("saldocontaminado")).ToString)
                    fila("creditoscontaminados") = Decimal.Parse(IIf(IsDBNull(drResultado.Item("creditoscontaminados")), 0, drResultado.Item("creditoscontaminados")).ToString)
                    dtTabla.Rows.Add(fila)
                End If
                cmComando.Dispose()
                drResultado.Close()
            Next
            '********************************************************************************            
        End Using

        Return dtTabla
    End Function
    ' OBTIENE EL RESUMEN DEL REPORTE 17 POR PRODUCTO
    ' PARAMETROS
    ' FONDO
    ' AGENCIA
    ' FECHAFIN: LA FECHA FIN CUANDO ES MES CERRADO TIENE QUE SER EL ULTIMO DIA DEL MES PARA QUE VAYA AL BACKUP
    Public Function ResumenCarteraPorProducto(ByVal Fondo As String, ByVal Agencia As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strTipoCartera As String = ""
        Dim strAgenciaCredkar As String = ""
        Dim strAgenciaCremcre As String = ""
        Dim strProducto As String = ""
        Dim strFecha As String = ""
        Dim strRango1 As String = ""
        Dim strRango2 As String = ""
        Dim strRango3 As String = ""
        Dim strRango4 As String = ""
        Dim strPlazo As String = ""
        Dim intPrestamos As Integer = 0
        Dim drResultado As SqlDataReader
        Dim dtTabla As New DataTable("resumencartera")
        Dim fila As Data.DataRow
        Dim strDescripcion As String = ""
        Dim cadenaactual As String = ""
        Dim cadena As String = ""
        Dim i As Integer



        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim descripcion As DataColumn = New DataColumn("descripcion")
        Dim personas As DataColumn = New DataColumn("personas")
        Dim prestamos As DataColumn = New DataColumn("prestamos")
        Dim montootorgado As DataColumn = New DataColumn("montootorgado")
        Dim saldocapital As DataColumn = New DataColumn("saldocapital")
        Dim mujeres As DataColumn = New DataColumn("mujeres")
        Dim hombres As DataColumn = New DataColumn("hombres")

        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        descripcion.DataType = System.Type.GetType("System.String")
        personas.DataType = System.Type.GetType("System.Decimal")
        prestamos.DataType = System.Type.GetType("System.Decimal")
        montootorgado.DataType = System.Type.GetType("System.Decimal")
        saldocapital.DataType = System.Type.GetType("System.Decimal")
        mujeres.DataType = System.Type.GetType("System.Decimal")
        hombres.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(descripcion)
        dtTabla.Columns.Add(personas)
        dtTabla.Columns.Add(prestamos)
        dtTabla.Columns.Add(montootorgado)
        dtTabla.Columns.Add(saldocapital)
        dtTabla.Columns.Add(mujeres)
        dtTabla.Columns.Add(hombres)


        Dim cmComando As New SqlCommand

        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(FechaFin))
        If cadena.Trim = cadenaactual.Trim Then
            cadena = cadenaactual
        End If

        Using cnConexion As New SqlConnection(cadena)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "' "
            End If

            If Agencia <> "*" Then
                strAgenciaCredkar = " and CREMCRE.COFICINA= '" + Agencia + "' "
            End If

            If TipoCartera <> "*" Then
                If TipoCartera = "I" Then
                    strTipoCartera = " AND CREMCRE.ccondic = 'S' "
                Else
                    strTipoCartera = " AND CREMCRE.ccondic <> 'S' "
                End If
            End If

            strFecha = " and CREMCRE.dfecvig<='" + FechaFin + "' "

            For i = 1 To 3
                strCadena = ""
                Select Case i
                    Case 1
                        strProducto = " and substring(cremcre.ccodcta,7,2)='01' "
                        strDescripcion = "01- Individual"
                    Case 2
                        strProducto = " and substring(cremcre.ccodcta,7,2)='02' "
                        strDescripcion = "02- Banco Comunal"
                    Case 3
                        strProducto = " and substring(cremcre.ccodcta,7,2)='03' "
                        strDescripcion = "02- Grupo Solidario"
                End Select

                'OBTIENE NUMERO BANCOS,GRUPOS Y PERSONAS
                If i <> 1 Then
                    strCadena = "" & _
                    " SELECT count(distinct cremcre.ccodsol) as total " & _
                    " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN" & _
                    " WHERE CREDKAR.CCONCEP = 'KP' " & _
                    " AND CREDKAR.CDESCOB = 'D' " & _
                    " and CREDKAR.CESTADO = ' ' " & _
                    " AND CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto
                    cmComando.CommandText = strCadena
                    cmComando.Connection = cnConexion
                    intPrestamos = cmComando.ExecuteScalar
                    cmComando.Dispose()
                End If

                'OBTIENE LOS DATOS PRINCIPALES
                strCadena = " " & _
                " SELECT ( " & _
                " Select SUM(CREDKAR.NMONTO) " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto & _
                " )-( " & _
                " SELECT SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'C'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto & _
                " ) as saldocapital, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto & _
                " ) as numeropersonas, " & _
                " (SELECT SUM(CREDKAR.NMONTO) " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto & _
                " ) as montootorgado, " & _
                " ( " & _
                " SELECT count(distinct cremcre.ccodcta) " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " inner join climide on cremcre.ccodcli=climide.ccodcli " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto & _
                " and climide.csexo<>'M' " & _
                " ) as mujeres, " & _
                " ( " & _
                " SELECT count(distinct cremcre.ccodcta) " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " inner join climide on cremcre.ccodcli=climide.ccodcli " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFecha + strAgenciaCredkar + strFondo + strTipoCartera + strProducto & _
                " and climide.csexo='M' " & _
                " ) as hombres "


                cmComando.CommandText = strCadena
                cmComando.Connection = cnConexion
                drResultado = cmComando.ExecuteReader
                If drResultado.Read Then
                    fila = dtTabla.NewRow()
                    fila("id") = i
                    fila("descripcion") = strDescripcion
                    fila("personas") = Decimal.Parse(drResultado.Item("numeropersonas").ToString)
                    If i = 1 Then
                        fila("prestamos") = Decimal.Parse(drResultado.Item("numeropersonas").ToString)
                    Else
                        fila("prestamos") = Decimal.Parse(intPrestamos.ToString)
                    End If

                    If IsDBNull(drResultado.Item("montootorgado")) Then
                        fila("montootorgado") = 0
                    Else
                        fila("montootorgado") = Decimal.Parse(drResultado.Item("montootorgado").ToString)
                    End If

                    'fila("saldocapital") = Decimal.Parse(drResultado.Item("saldocapital").ToString)
                    If IsDBNull(drResultado.Item("saldocapital")) Then
                        fila("saldocapital") = 0
                    Else
                        fila("saldocapital") = Decimal.Parse(drResultado.Item("saldocapital").ToString)
                    End If

                    If IsDBNull(drResultado.Item("mujeres")) Then
                        fila("mujeres") = 0
                    Else
                        fila("mujeres") = Decimal.Parse(drResultado.Item("mujeres").ToString)
                    End If

                    'fila("mujeres") = Decimal.Parse(drResultado.Item("mujeres").ToString)

                    If IsDBNull(drResultado.Item("hombres")) Then
                        fila("hombres") = 0
                    Else
                        fila("hombres") = Decimal.Parse(drResultado.Item("hombres").ToString)
                    End If

                    'fila("hombres") = Decimal.Parse(drResultado.Item("hombres").ToString)

                    dtTabla.Rows.Add(fila)
                End If
                cmComando.Dispose()
                drResultado.Close()
            Next
            '********************************************************************************            
        End Using

        Return dtTabla
    End Function
    'GENERA REPORTE POR PERIODICIDAD DE COBRO
    ' PARAMETROS
    ' FONDO:
    ' AGENCIA:
    ' FECHAFIN: LA FECHA FIN CUANDO ES MES CERRADO TIENE QUE SER EL ULTIMO DIA DEL MES PARA QUE VAYA AL BACKUP
    Public Function PeriodicidadCobro(ByVal Fondo As String, ByVal Agencia As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strTipoCartera As String = ""
        Dim strAgenciaCredkar As String = ""
        Dim strAgenciaCremcre As String = ""
        Dim strFecha As String = ""
        Dim drResultado As SqlDataReader
        Dim dtTabla As New DataTable("periodicidadcobros")
        Dim fila As Data.DataRow
        Dim strDescripcion As String = ""
        Dim strCodigoPeriodicidad As String = ""
        Dim drPeriodicidad As SqlDataReader
        Dim i As Integer = 0
        Dim cadena As String = ""
        Dim cadenaactual As String = ""



        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim descripcion As DataColumn = New DataColumn("descripcion")
        Dim creditosbuenos As DataColumn = New DataColumn("creditosbuenos")
        Dim saldocapital As DataColumn = New DataColumn("saldocapital")
        Dim creditoscontaminados As DataColumn = New DataColumn("creditoscontaminados")
        Dim saldocontaminado As DataColumn = New DataColumn("saldocontaminado")

        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        descripcion.DataType = System.Type.GetType("System.String")
        creditosbuenos.DataType = System.Type.GetType("System.Decimal")
        saldocapital.DataType = System.Type.GetType("System.Decimal")
        creditoscontaminados.DataType = System.Type.GetType("System.Decimal")
        saldocontaminado.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(descripcion)
        dtTabla.Columns.Add(creditosbuenos)
        dtTabla.Columns.Add(saldocapital)
        dtTabla.Columns.Add(creditoscontaminados)
        dtTabla.Columns.Add(saldocontaminado)


        Dim cmComando As New SqlCommand
        Dim cmComando2 As New SqlCommand


        Dim cnConexion2 As New SqlConnection(Me.cnnStr)
        cnConexion2.Open()
        'OBTIENE EL DATA READER DE LOS TIPOS DE COBRO DE LA CARTERA 
        'ccodtab + ctipreg='0601'

        strCadena = " select ccodigo,cdescri " & _
        "from tabttab " & _
        "where ccodtab + ctipreg='0601' " & _
        "order by nnumtab"

        cmComando2.CommandText = strCadena
        cmComando2.Connection = cnConexion2
        drPeriodicidad = cmComando2.ExecuteReader
        cmComando2.Dispose()

        strCadena = ""

        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(FechaFin))
        If cadena.Trim = cadenaactual.Trim Then
            cadena = cadenaactual
        End If

        Using cnConexion As New SqlConnection(cadena)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "'"
            End If

            If Agencia <> "*" Then
                strAgenciaCredkar = " and CREMCRE.COFICINA= '" + Agencia + "'"
                strAgenciaCremcre = " and CREMCRE.COFICINA= '" + Agencia + "'"
            End If

            If TipoCartera <> "*" Then
                If TipoCartera = "I" Then
                    strTipoCartera = " AND CREMCRE.ccondic = 'S' "
                Else
                    strTipoCartera = " AND CREMCRE.ccondic <> 'S' "
                End If
            End If

            strFecha = " and CREMCRE.dfecvig<='" + FechaFin + "'"

            While drPeriodicidad.Read
                i = i + 1

                strDescripcion = drPeriodicidad.Item("cdescri").ToString
                If Trim(drPeriodicidad.Item("ccodigo").ToString) = "A" Then
                    strCodigoPeriodicidad = " and (CREMCRE.cfreccap='" + Trim(drPeriodicidad.Item("ccodigo").ToString) + "' or CREMCRE.cfreccap is NULL)"
                Else
                    strCodigoPeriodicidad = " and CREMCRE.cfreccap='" + Trim(drPeriodicidad.Item("ccodigo").ToString) + "'"
                End If

                
                strCadena = " " & _
                " SELECT (  " & _
                " case when( (  " & _
                " Select SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN  " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' '  " & _
                " AND CREMCRE.CESTADO='F'  " + strFondo + strAgenciaCredkar + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                " )-(  " & _
                " " & _
                " select (  " & _
                " case when ((    " & _
                "  SELECT SUM(CREDKAR.NMONTO) as monto   " & _
                "  FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  WHERE CREDKAR.CCONCEP = 'KP'     " & _
                "  AND CREDKAR.CDESCOB = 'C'     " & _
                "  and CREDKAR.CESTADO = ' '    " & _
                "  AND CREMCRE.CESTADO='F'  " + strFondo + strAgenciaCredkar + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  )) is null then 0  " & _
                "  else  " & _
                "  (  " & _
                "  Select SUM(credkar.nmonto)  " & _
                "  FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  WHERE CREDKAR.CCONCEP = 'KP'     " & _
                "  AND CREDKAR.CDESCOB = 'C'     " & _
                "  and CREDKAR.CESTADO = ' '    " & _
                "  AND CREMCRE.CESTADO='F'  " + strFondo + strAgenciaCredkar + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  ) end) as monto  " & _
                " " & _
                " )) is null then 0  " & _
                " else  " & _
                " ((   " & _
                " Select SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN  " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' '   " & _
                " AND CREMCRE.CESTADO='F'   " + strFondo + strAgenciaCredkar + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                " )-(   " & _
                 " " & _
                " select (  " & _
                " case when ((    " & _
                "  SELECT SUM(CREDKAR.NMONTO) as monto   " & _
                "  FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  WHERE CREDKAR.CCONCEP = 'KP'     " & _
                "  AND CREDKAR.CDESCOB = 'C'     " & _
                "  and CREDKAR.CESTADO = ' '    " & _
                "  AND CREMCRE.CESTADO='F'  " + strFondo + strAgenciaCredkar + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  )) is null then 0  " & _
                "  else  " & _
                "  (  " & _
                "  Select SUM(credkar.nmonto)  " & _
                "  FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  WHERE CREDKAR.CCONCEP = 'KP'     " & _
                "  AND CREDKAR.CDESCOB = 'C'     " & _
                "  and CREDKAR.CESTADO = ' '    " & _
                "  AND CREMCRE.CESTADO='F'  " + strFondo + strAgenciaCredkar + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  ) end) as monto  " & _
                " " & _
                " )) end) as saldocapital,    " & _
                " (case when((   " & _
                " Select count(CREMCRE.CCODCTA)   " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN   " & _
                "  where CREMCRE.CESTADO='F'   " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  )) is null then 0   " & _
                " else   " & _
                " (   " & _
                "  Select count(CREMCRE.CCODCTA)   " & _
                "  FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  where CREMCRE.CESTADO='F'    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  ) end) as creditosbuenos,     " & _
                " ( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                " ) end   " & _
                " )-( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                " ) end   " & _
                " ) as saldocontaminado, " & _
                " (   " & _
                " case when((   " & _
                "  Select count(CREMCRE.CCODCTA)   " & _
                "  FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  where CREMCRE.CESTADO='F'    " & _
                "  and cremcre.ndiaatr>0   " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "  )) is null then 0   " & _
                " else   " & _
                "  (   " & _
                "  Select count(CREMCRE.CCODCTA)   " & _
                "  FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                "  where CREMCRE.CESTADO='F'    " & _
                "  and cremcre.ndiaatr>0   " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera + strCodigoPeriodicidad & _
                "   ) end) as creditoscontaminados "


                cmComando.CommandText = strCadena
                cmComando.Connection = cnConexion
                drResultado = cmComando.ExecuteReader
                fila = dtTabla.NewRow()
                If drResultado.Read Then
                    fila("id") = i
                    fila("descripcion") = Trim(strDescripcion)
                    fila("saldocapital") = Decimal.Parse(drResultado.Item("saldocapital").ToString)
                    fila("creditosbuenos") = Decimal.Parse(drResultado.Item("creditosbuenos").ToString)
                    fila("saldocontaminado") = Decimal.Parse(drResultado.Item("saldocontaminado").ToString)
                    fila("creditoscontaminados") = Decimal.Parse(drResultado.Item("creditoscontaminados").ToString)
                End If

                dtTabla.Rows.Add(fila)
                cmComando.Dispose()
                drResultado.Close()
            End While
            '********************************************************************************            
        End Using

        cnConexion2.Close()
        Return dtTabla
    End Function
    'GENERA UN REPORTE DE DESEMBOLSO PERO DE FORMA CONSOLIDADA
    Public Function ResumenDesembolso(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal Analista As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strAgencia As String = ""
        Dim strProducto As String = ""
        Dim strAnalista As String = ""
        Dim strFecha As String = ""
        Dim dtTabla As New DataTable("resumendesembolsos")
        Dim daDesembolso As New SqlDataAdapter
        Dim cmComando As New SqlCommand


        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "' "
            End If
            If Agencia <> "*" Then
                strAgencia = " AND CREMCRE.coficina='" + Agencia + "' "
            End If
            If Producto <> "*" Then
                strProducto = " AND SUBSTRING(CRETLIN.CCODLIN,5,2)='" + Producto + "' "
            End If
            If Analista <> "*" Then
                strAnalista = " AND CREMCRE.ccodana='" + Analista + "' "
            End If

            strFecha = " and credkar.dfecsis between '" + FechaInicio + "' and '" + FechaFin + "' "

            ' LE QUITE ESTE FILTRO YA QUE TOMABA EN CUENTA LOS AJUSTES QUE CARTERA HACIA Y POR ESO NO CUADRABA

            ''" AND CREMCRE.CESTADO='F' " & _

            strCadena = " " & _
            " SELECT cremcre.ccodcta,  CREMCRE.CCODSOL,cremcre.coficina as CCODOFI,SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO " & _
            " ,SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO " & _
            " ,CREDKAR.NMONTO,CREMCRE.DFECVIG,CREMCRE.DFECVEN,CREMCRE.ccodana " & _
            " ,TABTOFI.CNOMOFI,TABTTAB.CDESCRI,CREMSOL.CNOMGRU " & _
            " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA  " & _
            " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
            " INNER JOIN TABTOFI ON cremcre.coficina=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " WHERE CREDKAR.CCONCEP = 'KP'  " & _
            " AND CREDKAR.CDESCOB = 'D'  " & _
            " and CREDKAR.CESTADO = ' ' " & _
            " AND CCODTAB+CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha


            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion
            daDesembolso.SelectCommand = cmComando

            daDesembolso.Fill(dtTabla)

        End Using

        Return dtTabla
    End Function

    'GENERA EL REPORTE DE TODA LA CARTERA DIVIDIDA POR AGENCIA
    Public Function ConsolidadoCarteraDivididaPorAgencia(ByVal Fondo As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFechaCredkar As String = ""
        Dim strFondo As String = ""
        Dim CadenaActual As String = ""
        Dim cadena As String = ""
        Dim strTipoCartera As String = ""
        Dim strAgenciaCredkar As String = ""
        Dim strAgenciaCremcre As String = ""
        Dim strFecha As String = ""
        Dim drResultado As SqlDataReader
        Dim dtTabla As New DataTable("consolidadocarteroficina")
        Dim fila As Data.DataRow
        Dim strDescripcion As String = ""
        Dim strCodigoPeriodicidad As String = ""
        Dim drPeriodicidad As SqlDataReader
        Dim i As Integer = 0


        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim descripcion As DataColumn = New DataColumn("descripcion")
        Dim creditosbuenos As DataColumn = New DataColumn("creditosbuenos")
        Dim saldocapital As DataColumn = New DataColumn("saldocapital")
        Dim creditoscontaminados As DataColumn = New DataColumn("creditoscontaminados")
        Dim saldocontaminado As DataColumn = New DataColumn("saldocontaminado")

        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        descripcion.DataType = System.Type.GetType("System.String")
        creditosbuenos.DataType = System.Type.GetType("System.Decimal")
        saldocapital.DataType = System.Type.GetType("System.Decimal")
        creditoscontaminados.DataType = System.Type.GetType("System.Decimal")
        saldocontaminado.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(descripcion)
        dtTabla.Columns.Add(creditosbuenos)
        dtTabla.Columns.Add(saldocapital)
        dtTabla.Columns.Add(creditoscontaminados)
        dtTabla.Columns.Add(saldocontaminado)


        Dim cmComando As New SqlCommand
        Dim cmComando2 As New SqlCommand


        Dim cnConexion2 As New SqlConnection(Me.cnnStr)
        cnConexion2.Open()

        'OBTIENE EL DATA READER DE LAS OFICINAS

        strCadena = " select ccodofi,cnomofi " & _
        "from tabtofi "
        ' "where ccodofi <>'001' "


        cmComando2.CommandText = strCadena
        cmComando2.Connection = cnConexion2
        drPeriodicidad = cmComando2.ExecuteReader
        cmComando2.Dispose()

        strCadena = ""

        CadenaActual = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(FechaFin))
        If cadena.Trim = CadenaActual.Trim Then
            cadena = CadenaActual
        End If

        Using cnConexion As New SqlConnection(cadena)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "'"
            End If

            If TipoCartera <> "*" Then
                If TipoCartera = "I" Then
                    strTipoCartera = " AND CREMCRE.ccondic = 'S' "
                Else
                    strTipoCartera = " AND CREMCRE.ccondic <> 'S' "
                End If
            End If



            strFecha = " and CREMCRE.dfecvig<='" + FechaFin + "'"
            strFechaCredkar = " and CREDKAR.dfecsis<='" + FechaFin + "'"



            While drPeriodicidad.Read
                i = i + 1

                strDescripcion = drPeriodicidad.Item("ccodofi").ToString + " - " + drPeriodicidad.Item("cnomofi").ToString

                strAgenciaCredkar = " and CREMCRE.COFICINA= '" + drPeriodicidad.Item("ccodofi").ToString + "'"
                strAgenciaCremcre = " and CREMCRE.COFICINA= '" + drPeriodicidad.Item("ccodofi").ToString + "'"


                strCadena = " " & _
                " SELECT ( " & _
                " Select SUM(NCAPDES - NCAPPAG) " & _
                " FROM ( " & _
                " Select " & _
                "  ISNULL((SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA and CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' " + strFechaCredkar + " GROUP BY CREDKAR.CCODCTA),0) AS NCAPDES, " & _
                "  ISNULL((SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA and CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' " + strFechaCredkar + " GROUP BY CREDKAR.CCODCTA),0) AS NCAPPAG " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN  " & _
                " WHERE (CREMCRE.CESTADO='F' or CREMCRE.CESTADO='G') " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) AS TEMP " & _
                " WHERE NCAPDES>NCAPPAG ) as saldocapital, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) as creditosbuenos, " & _
                " ( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) end   " & _
                " )-( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) end   " & _
                " ) as saldocontaminado, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " & _
                " and cremcre.ndiaatr>0 " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) as creditoscontaminados "

                cmComando.CommandText = strCadena
                cmComando.Connection = cnConexion
                drResultado = cmComando.ExecuteReader
                fila = dtTabla.NewRow()
                If drResultado.Read Then
                    fila("id") = i
                    fila("descripcion") = Trim(strDescripcion)
                    If IsDBNull(drResultado.Item("saldocapital")) Then
                        fila("saldocapital") = 0
                    Else
                        fila("saldocapital") = Decimal.Parse(drResultado.Item("saldocapital").ToString)
                    End If
                    'fila("saldocapital") = Decimal.Parse(drResultado.Item("saldocapital").ToString)
                    If IsDBNull(drResultado.Item("creditosbuenos")) Then
                        fila("creditosbuenos") = 0
                    Else
                        fila("creditosbuenos") = Decimal.Parse(drResultado.Item("creditosbuenos").ToString)
                    End If

                    If IsDBNull(drResultado.Item("saldocontaminado")) Then
                        fila("saldocontaminado") = 0
                    Else
                        fila("saldocontaminado") = Decimal.Parse(drResultado.Item("saldocontaminado").ToString)
                    End If

                    If IsDBNull(drResultado.Item("creditoscontaminados")) Then
                        fila("creditoscontaminados") = 0
                    Else
                        fila("creditoscontaminados") = Decimal.Parse(drResultado.Item("creditoscontaminados").ToString)
                    End If

                End If

                dtTabla.Rows.Add(fila)
                cmComando.Dispose()
                drResultado.Close()
            End While
            '********************************************************************************            
        End Using

        cnConexion2.Close()
        Return dtTabla
    End Function

    Public Function ConsolidadoCarteraDivididaPorAgenciaxxx(ByVal Fondo As String, ByVal TipoCartera As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim CadenaActual As String = ""
        Dim cadena As String = ""
        Dim strTipoCartera As String = ""
        Dim strAgenciaCredkar As String = ""
        Dim strAgenciaCremcre As String = ""
        Dim strFecha As String = ""
        Dim drResultado As SqlDataReader
        Dim dtTabla As New DataTable("consolidadocarteroficina")
        Dim fila As Data.DataRow
        Dim strDescripcion As String = ""
        Dim strCodigoPeriodicidad As String = ""
        Dim drPeriodicidad As SqlDataReader
        Dim i As Integer = 0


        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim descripcion As DataColumn = New DataColumn("descripcion")
        Dim creditosbuenos As DataColumn = New DataColumn("creditosbuenos")
        Dim saldocapital As DataColumn = New DataColumn("saldocapital")
        Dim creditoscontaminados As DataColumn = New DataColumn("creditoscontaminados")
        Dim saldocontaminado As DataColumn = New DataColumn("saldocontaminado")

        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        descripcion.DataType = System.Type.GetType("System.String")
        creditosbuenos.DataType = System.Type.GetType("System.Decimal")
        saldocapital.DataType = System.Type.GetType("System.Decimal")
        creditoscontaminados.DataType = System.Type.GetType("System.Decimal")
        saldocontaminado.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(descripcion)
        dtTabla.Columns.Add(creditosbuenos)
        dtTabla.Columns.Add(saldocapital)
        dtTabla.Columns.Add(creditoscontaminados)
        dtTabla.Columns.Add(saldocontaminado)


        Dim cmComando As New SqlCommand
        Dim cmComando2 As New SqlCommand


        Dim cnConexion2 As New SqlConnection(Me.cnnStr)
        cnConexion2.Open()

        'OBTIENE EL DATA READER DE LAS OFICINAS

        strCadena = " select ccodofi,cnomofi " & _
        "from tabtofi " & _
        ""


        cmComando2.CommandText = strCadena
        cmComando2.Connection = cnConexion2
        drPeriodicidad = cmComando2.ExecuteReader
        cmComando2.Dispose()

        strCadena = ""

        CadenaActual = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(FechaFin))
        If cadena.Trim = CadenaActual.Trim Then
            cadena = CadenaActual
        End If

        Using cnConexion As New SqlConnection(cadena)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "'"
            End If

            If TipoCartera <> "*" Then
                If TipoCartera = "I" Then
                    strTipoCartera = " AND CREMCRE.ccondic = 'S' "
                Else
                    strTipoCartera = " AND CREMCRE.ccondic <> 'S' "
                End If
            End If



            strFecha = " and CREMCRE.dfecvig<='" + FechaFin + "'"

            While drPeriodicidad.Read
                i = i + 1

                strDescripcion = drPeriodicidad.Item("ccodofi").ToString + " - " + drPeriodicidad.Item("cnomofi").ToString

                strAgenciaCredkar = " and CREMCRE.COFICINA= '" + drPeriodicidad.Item("ccodofi").ToString + "'"
                strAgenciaCremcre = " and CREMCRE.COFICINA= '" + drPeriodicidad.Item("ccodofi").ToString + "'"


                strCadena = " " & _
                " SELECT (  " & _
                " SELECT SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN  " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'D'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " )-( " & _
                " SELECT SUM(CREDKAR.NMONTO)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " WHERE CREDKAR.CCONCEP = 'KP'  " & _
                " AND CREDKAR.CDESCOB = 'C'  " & _
                " and CREDKAR.CESTADO = ' ' " & _
                " AND CREMCRE.CESTADO='F' " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) as saldocapital, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) as creditosbuenos, " & _
                " ( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'D'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) end   " & _
                " )-( " & _
                " " & _
                " select  " & _
                " case when (   " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) is null then 0  " & _
                " else  " & _
                " (  " & _
                " Select SUM(credkar.nmonto)  " & _
                " FROM CREDKAR inner join CREMCRE on CREDKAR.CCODCTA = CREMCRE.CCODCTA   " & _
                " INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN    " & _
                " WHERE CREDKAR.CCONCEP = 'KP'     " & _
                " AND CREDKAR.CDESCOB = 'C'     " & _
                " and CREDKAR.CESTADO = ' '    " & _
                " AND CREMCRE.CESTADO='F'    " & _
                " and cremcre.ndiaatr>0    " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) end   " & _
                " ) as saldocontaminado, " & _
                " (SELECT count(CREMCRE.CCODCTA)  " & _
                " FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.CNROLIN=CRETLIN.CNROLIN " & _
                " where CREMCRE.CESTADO='F' " & _
                " and cremcre.ndiaatr>0 " + strFondo + strAgenciaCremcre + strFecha + strTipoCartera & _
                " ) as creditoscontaminados "

                cmComando.CommandText = strCadena
                cmComando.Connection = cnConexion
                drResultado = cmComando.ExecuteReader
                fila = dtTabla.NewRow()
                If drResultado.Read Then
                    fila("id") = i
                    fila("descripcion") = Trim(strDescripcion)
                    fila("saldocapital") = Decimal.Parse(drResultado.Item("saldocapital").ToString)
                    fila("creditosbuenos") = Decimal.Parse(drResultado.Item("creditosbuenos").ToString)
                    fila("saldocontaminado") = Decimal.Parse(drResultado.Item("saldocontaminado").ToString)
                    fila("creditoscontaminados") = Decimal.Parse(drResultado.Item("creditoscontaminados").ToString)
                End If

                dtTabla.Rows.Add(fila)
                cmComando.Dispose()
                drResultado.Close()
            End While
            '********************************************************************************            
        End Using

        cnConexion2.Close()
        Return dtTabla
    End Function
    'GENERA EL REPORTE DE INGRESOS DE FORMA CONSOLIDADA
    Public Function ResumenIngresos(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal Analista As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strAgencia As String = ""
        Dim strProducto As String = ""
        Dim strAnalista As String = ""
        Dim strFecha As String = ""
        Dim dtTabla As New DataTable("resumeningresos")
        Dim daIngresos As New SqlDataAdapter
        Dim cmComando As New SqlCommand


        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "' "
            End If
            If Agencia <> "*" Then
                strAgencia = " AND CREMCRE.COFICINA='" + Agencia + "' "
            End If
            If Producto <> "*" Then
                strProducto = " AND SUBSTRING(CRETLIN.CCODLIN,5,2)='" + Producto + "' "
            End If
            If Analista <> "*" Then
                strAnalista = " AND CREMCRE.ccodana='" + Analista + "' "
            End If

            strFecha = " and credkar.dfecsis between '" + FechaInicio + "' and '" + FechaFin + "' "


            strCadena = " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,CREDKAR.nmonto as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,000000.00 as interes,00000000.00 as mora,00000000.00 as exedente, 00000000.00 as nseguro, 00000000.00 as ncomision, 00000000.00 as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='KP' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
            " " & _
            " UNION all " & _
            " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,CREDKAR.nmonto as interes,00000000.00 as mora,00000000.00 as exedente, 00000000.00 as nseguro, 00000000.00 as ncomision, 00000000.00 as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='IN' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
            " " & _
            " UNION ALL " & _
            " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,00000000.00 as interes,CREDKAR.nmonto as mora,00000000.00 as exedente, 00000000.00 as nseguro, 00000000.00 as ncomision, 00000000.00 as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='MO' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
            " " & _
            " UNION ALL " & _
            " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,00000000.00 as interes,00000000.00 as mora,CREDKAR.nmonto as exedente, 00000000.00 as nseguro, 00000000.00 as ncomision, 00000000.00 as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='EX' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
            " " & _
            " UNION ALL " & _
            " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,00000000.00 as interes,00000000.00 as mora,00000000.00 as exedente, credkar.nmonto as nseguro, 00000000.00 as ncomision, 00000000.00 as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='03' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
            " " & _
            " UNION ALL " & _
            " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,00000000.00 as interes,00000000.00 as mora,00000000.00 as exedente, 00000000.00 as nseguro, credkar.nmonto as ncomision, 00000000.00 as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='05' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
                        " " & _
            " UNION ALL " & _
            " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as capital, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " TABTTAB.CDESCRI,00000000.00 as interes,00000000.00 as mora,00000000.00 as exedente, 00000000.00 as nseguro, 00000000.00 as ncomision, credkar.nmonto as niva " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " WHERE CREDKAR.cestado='' " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='08' " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha



            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion
            daIngresos.SelectCommand = cmComando

            daIngresos.Fill(dtTabla)

        End Using

        Return dtTabla
    End Function
    'GENERA LA CARTERA CON INTERESES SUSPENDIDOS
    Public Function CarteraConInteresesSuspendidos(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strAgencia As String = ""
        Dim strProducto As String = ""
        Dim strAnalista As String = ""
        Dim strFecha As String = ""
        Dim cadena As String = ""
        Dim CadenaActual As String = ""
        Dim dtTabla As New DataTable("carterasuspendida")
        Dim daCarteraSuspendida As New SqlDataAdapter
        Dim cmComando As New SqlCommand

        Try


            CadenaActual = Me.cnnStr
            cadena = Me.CadenaDatos(Date.Parse(FechaFin))
            If cadena.Trim = CadenaActual.Trim Then
                cadena = CadenaActual
            End If

            Using cnConexion As New SqlConnection(cadena)
                cnConexion.Open()

                If Fondo <> "*" Then
                    strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "' "
                    'strFondo = " and cremcre.ccodfue= '" + Fondo + "' "
                End If
                If Agencia <> "*" Then
                    strAgencia = " AND C.COFICINA='" + Agencia + "' "
                End If
                If Producto <> "*" Then
                    strProducto = " AND SUBSTRING(CRETLIN.CCODLIN,5,2)='" + Producto + "' "
                End If


                strFecha = " and C.dfectra <='" + FechaFin + "' "


                strCadena = " " & _
                " SELECT C.CCODCTA,C.CCODSOL,CREMSOL.CNOMGRU,CLIMIDE.CNOMCLI, " & _
                " (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' AND CREDKAR.CESTADO = ' ' AND CREDKAR.CCODCTA = c.CCODCTA)- " & _
                " (CASE WHEN (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' AND CREDKAR.CESTADO = ' ' AND CREDKAR.CCODCTA = C.CCODCTA) IS NULL THEN 0 " & _
                "  ELSE (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' AND CREDKAR.CESTADO = ' ' AND CREDKAR.CCODCTA = C.CCODCTA) END " & _
                " ) AS NSALCAP,C.NCAPDES,(C.NINTCAL-c.nintpag-c.nintpen) as nintcal,(C.NINTMOR-c.nmorpag-c.npagcta) as nintmor,C.NDIAATR,DFECTRA,NPERIODO,SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO,SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO,C.DFECVIG,C.DFECVEN,C.DULTPAG,INTEGRAL.DBO.TABTTAB.CDESCRI " & _
                " from CREMCRE as C INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN INNER JOIN CREMSOL ON C.CCODSOL=CREMSOL.CCODSOL INNER JOIN CLIMIDE ON C.CCODCLI=CLIMIDE.CCODCLI INNER JOIN INTEGRAL.DBO.TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=INTEGRAL.DBO.TABTTAB.CCODIGO " & _
                " where C.CCONTRA='G' " & _
                " AND C.CESTADO='F' " & _
                " AND INTEGRAL.DBO.TABTTAB.CCODTAB+INTEGRAL.DBO.TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto & _
                " ORDER BY CREMSOL.CNOMGRU,CLIMIDE.CNOMCLI"

                cmComando.CommandText = strCadena
                cmComando.Connection = cnConexion
                daCarteraSuspendida.SelectCommand = cmComando

                daCarteraSuspendida.Fill(dtTabla)

            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return dtTabla
    End Function

    Public Function DatosparaEstimacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lccodigo As String) As DataSet
        Dim ds As New DataSet

        ds = Me.CarteraCalculada11(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, lccartera, lccodigo)

        Dim lnmontot As Double = 0
        Dim lnmonto As Double = 0
        Dim lncapdes As Double = 0
        Dim lncappag As Double = 0
        Dim lnpagteo As Double = 0
        Dim lnsalteo As Double = 0
        Dim pccodcta As String
        Dim pndias As Integer

        If ds.Tables(0).Rows.Count = 0 Then
            lnmontot = 0
        Else
            Dim fila1 As DataRow
            Dim elem1 As Integer
            For Each fila1 In ds.Tables(0).Rows
                lncapdes = ds.Tables(0).Rows(elem1)("ncapdes")
                lncappag = ds.Tables(0).Rows(elem1)("ncappag")
                lnpagteo = ds.Tables(0).Rows(elem1)("npagteo")
                lnsalteo = IIf((lncapdes - lnpagteo) < 0, 0, (lncapdes - lnpagteo))
                lnmonto = lncapdes - lncappag
                pccodcta = ds.Tables(0).Rows(elem1)("ccodcta")
                pndias = Me.diasAtraso(pccodcta, lncappag, dfecha2)
                ds.Tables(0).Rows(elem1)("ndias") = pndias
                elem1 += 1
            Next
        End If
        Return ds
    End Function

    Public Function InsertarEstimacion(ByVal ccodofi As String, ByVal ffondos As String, ByVal nsaldo As Double, ByVal dfecha As Date, ByVal cmes As String, ByVal cyear As String, ByVal ccodusu As String, ByVal ccalifica As String, ByVal nestimacion As Double, ByVal cstatus As String) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ESTIMACION(ccodofi, ffondos, nsaldo, dfecha, cmes, cyear, ccodusu, ccalifica, nestimacion, status ) ")
        strSQL.Append("VALUES(@ccodofi, @ffondos, @nsaldo, @dfecha, @cmes, @cyear, @ccodusu, @ccalifica, @nestimacion, @cstatus)")

        Dim args(9) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(1).Value = ffondos
        args(2) = New SqlParameter("@nsaldo", SqlDbType.Decimal)
        args(2).Value = nsaldo
        args(3) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(3).Value = dfecha
        args(4) = New SqlParameter("@cmes", SqlDbType.VarChar)
        args(4).Value = cmes
        args(4) = New SqlParameter("@cmes", SqlDbType.VarChar)
        args(4).Value = cmes
        args(5) = New SqlParameter("@cyear", SqlDbType.VarChar)
        args(5).Value = cyear
        args(6) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(6).Value = ccodusu
        args(7) = New SqlParameter("@ccalifica", SqlDbType.VarChar)
        args(7).Value = ccalifica
        args(8) = New SqlParameter("@nestimacion", SqlDbType.Decimal)
        args(8).Value = nestimacion
        args(9) = New SqlParameter("@cstatus", SqlDbType.VarChar)
        args(9).Value = cstatus

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function

    'GENERA REPORTE DE INGRESOS CONDONADOS
    Public Function IngresosCondonados(ByVal Fondo As String, ByVal Agencia As String, ByVal Producto As String, ByVal Analista As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strAgencia As String = ""
        Dim strProducto As String = ""
        Dim strAnalista As String = ""
        Dim strFecha As String = ""
        Dim dtTabla As New DataTable("resumeningresos")
        Dim daIngresos As New SqlDataAdapter
        Dim cmComando As New SqlCommand


        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()

            If Fondo <> "*" Then
                strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "' "
            End If
            If Agencia <> "*" Then
                strAgencia = " AND CREMCRE.COFICINA='" + Agencia + "' "
            End If
            If Producto <> "*" Then
                strProducto = " AND SUBSTRING(CRETLIN.CCODLIN,5,2)='" + Producto + "' "
            End If
            If Analista <> "*" Then
                strAnalista = " AND CREMCRE.ccodana='" + Analista + "' "
            End If

            strFecha = " and credkar.dfecsis between '" + FechaInicio + "' and '" + FechaFin + "' "


            strCadena = " " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREDKAR.CCODCTA,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,CREDKAR.nmonto as interes, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " 00000000.00 as mora,TABTTAB.CDESCRI,CLIMIDE.CNOMCLI " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL  " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI  " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=CREMCRE.CCODCLI " & _
            " WHERE CREDKAR.cestado=''  " & _
            " and CREDKAR.cdescob='C' " & _
            " and CREDKAR.cconcep='IN' " & _
            " and CREDKAR.CNUMING='COND' " & _
            " AND CREDKAR.CTIPPAG='I'  " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha & _
            " UNION ALL " & _
            " select TABTOFI.CNOMOFI,CREDKAR.CCODOFI,CREDKAR.CCODCTA,CREMCRE.CCODSOL,CREMSOL.CNOMGRU,00000000.00 as interes, " & _
            " CREDKAR.DFECSIS,CREDKAR.DFECPRO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,3,2) AS FONDO, " & _
            " SUBSTRING(CRETLIN.CCODLIN,5,2) AS PRODUCTO, " & _
            " CREDKAR.NMONTO as mora,TABTTAB.CDESCRI,CLIMIDE.CNOMCLI " & _
            " FROM CREDKAR inner join CREMCRE on CREMCRE.ccodcta=CREDKAR.ccodcta " & _
            " inner JOIN CRETLIN on CREMCRE.cnrolin=CRETLIN.cnrolin  " & _
            " INNER JOIN CREMSOL ON CREMSOL.CCODSOL=CREMCRE.CCODSOL  " & _
            " INNER JOIN TABTOFI ON CREDKAR.CCODOFI=TABTOFI.CCODOFI  " & _
            " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
            " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=CREMCRE.CCODCLI " & _
            " WHERE CREDKAR.cestado=''  " & _
            " and CREDKAR.cdescob='C'   " & _
            " and CREDKAR.cconcep='MO' " & _
            " and CREDKAR.CNUMING='COND' " & _
            " AND CREDKAR.CTIPPAG='I'   " & _
            " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strFondo + strAgencia + strProducto + strAnalista + strFecha


            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion
            daIngresos.SelectCommand = cmComando
            daIngresos.SelectCommand.CommandTimeout = 0
            daIngresos.Fill(dtTabla)
            daIngresos.SelectCommand.Dispose()

        End Using

        Return dtTabla
    End Function

    ' GENERA EL RESUMEN  DEL REPORTE 3 DE CARTERA VIGENTE
    Public Function ResumenDeCartera3(ByVal Fondo As String, ByVal Agencia As String, ByVal Analista As String, ByVal TipoCartera As String, ByVal Municipio As String, ByVal FechaFin As String) As DataTable

        Dim strTipoCartera As String = ""
        Dim strMunicipio As String = ""
        Dim strCadena As String = ""
        Dim strFondo As String = ""
        Dim strAgencia As String = ""
        Dim strProducto As String = ""
        Dim strAnalista As String = ""
        Dim strFecha As String = ""
        Dim strFecha3 As String = ""
        Dim strGrupo As String = ""
        Dim strFecha2 As String = ""
        Dim dtTabla As New DataTable("resumencartera3")
        Dim daCarteraSuspendida As New SqlDataAdapter
        Dim cmComando As New SqlCommand
        Dim cmComando2 As New SqlCommand
        Dim drResultado As SqlDataReader
        Dim fila As Data.DataRow
        Dim CadenaActual As String = ""
        Dim cadena As String = ""
        Dim i As Integer = 0

        'se declara la variable como nombre de columna
        Dim id As DataColumn = New DataColumn("id")
        Dim ccodsol As DataColumn = New DataColumn("ccodsol")
        Dim cnomgru As DataColumn = New DataColumn("cnomgru")
        Dim dfecvig As DataColumn = New DataColumn("dfecvig")
        Dim dfecven As DataColumn = New DataColumn("dfecven")
        Dim ccodprd As DataColumn = New DataColumn("ccodprd")
        Dim cdescri As DataColumn = New DataColumn("cdescri")
        Dim vigentes As DataColumn = New DataColumn("vigentes")
        Dim integrantes As DataColumn = New DataColumn("integrantes")
        Dim hombres As DataColumn = New DataColumn("hombres")
        Dim mujeres As DataColumn = New DataColumn("mujeres")
        Dim ncapdes As DataColumn = New DataColumn("ncapdes")
        Dim nsalcap As DataColumn = New DataColumn("nsalcap")


        'se le cambia el tipo
        id.DataType = System.Type.GetType("System.Int32")
        ccodsol.DataType = System.Type.GetType("System.String")
        cnomgru.DataType = System.Type.GetType("System.String")
        dfecvig.DataType = System.Type.GetType("System.DateTime")
        dfecven.DataType = System.Type.GetType("System.DateTime")
        ccodprd.DataType = System.Type.GetType("System.String")
        cdescri.DataType = System.Type.GetType("System.String")
        vigentes.DataType = System.Type.GetType("System.Decimal")
        integrantes.DataType = System.Type.GetType("System.Decimal")
        hombres.DataType = System.Type.GetType("System.Decimal")
        mujeres.DataType = System.Type.GetType("System.Decimal")
        ncapdes.DataType = System.Type.GetType("System.Decimal")
        nsalcap.DataType = System.Type.GetType("System.Decimal")

        'se agrega a la tabla
        dtTabla.Columns.Add(id)
        dtTabla.Columns.Add(ccodsol)
        dtTabla.Columns.Add(cnomgru)
        dtTabla.Columns.Add(dfecvig)
        dtTabla.Columns.Add(dfecven)
        dtTabla.Columns.Add(ccodprd)
        dtTabla.Columns.Add(cdescri)
        dtTabla.Columns.Add(vigentes)
        dtTabla.Columns.Add(integrantes)
        dtTabla.Columns.Add(hombres)
        dtTabla.Columns.Add(mujeres)
        dtTabla.Columns.Add(ncapdes)
        dtTabla.Columns.Add(nsalcap)

        CadenaActual = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(FechaFin))
        If cadena.Trim = CadenaActual.Trim Then
            cadena = CadenaActual
        End If


        Using cnConexion2 As New SqlConnection(cadena)
            cnConexion2.Open()

            For i = 1 To 3

                If Fondo <> "*" Then
                    strFondo = " and substring(CRETLIN.CCODLIN,3,2)= '" + Fondo + "' "
                End If
                If Agencia <> "*" Then
                    strAgencia = " AND C.COFICINA='" + Agencia + "' "
                End If

                If TipoCartera <> "*" Then
                    If TipoCartera = "I" Then
                        strTipoCartera = " AND C.ccondic = 'S' "
                    Else
                        strTipoCartera = " AND C.ccondic <> 'S' "
                    End If
                End If

                If Analista <> "*" Then
                    strAnalista = " AND C.CCODANA='" + Analista + "' "
                End If

                If Municipio <> "*" Then
                    strMunicipio = " AND Left(climide.ccoddom, 4) = '" + Municipio + "' "
                End If


                strFecha = " and CREDKAR.dfecsis <='" + FechaFin + "' "

                strProducto = " AND SUBSTRING(C.CCODCTA,7,2)='0" + i.ToString + "'"

                If i = 1 Then

                    strCadena = " " & _
                    " select " & _
                    " ( " & _
                    " Select COUNT(C.CCODCTA) " & _
                    " FROM CREMCRE AS C INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN   " & _
                    " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
                    " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=C.CCODCLI " & _
                    " WHERE C.CCODSOL='001001000000' " & _
                    " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " & _
                    " AND C.CESTADO in('G','F') " + strFondo + strAgencia + strAnalista + strTipoCartera + strMunicipio & _
                    " ) as integrantes, " & _
                    " ( " & _
                    " Select COUNT(C.CCODCTA) " & _
                    " FROM CREMCRE AS C INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN   " & _
                    " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)= TABTTAB.CCODIGO " & _
                    " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=C.CCODCLI " & _
                    " WHERE C.CCODSOL='001001000000' " & _
                    " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " & _
                    " AND C.CESTADO='F' " + strFondo + strAgencia + strAnalista + strTipoCartera + strMunicipio & _
                    " ) as vigentes, " & _
                    " ( " & _
                    " SELECT ((  " & _
                    " Select SUM(CREDKAR.NMONTO) " & _
                    " FROM CREDKAR inner join CREMCRE AS C on CREDKAR.CCODCTA = C.CCODCTA INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN     " & _
                    " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=C.CCODCLI " & _
                    " WHERE CREDKAR.CCONCEP = 'KP'    AND CREDKAR.CDESCOB = 'D'    and CREDKAR.CESTADO = ' '    AND C.CESTADO='F'  AND C.CCODSOL='001001000000' " + strFondo + strAgencia + strFecha + strAnalista + strTipoCartera + strMunicipio + " )-   " & _
                    " ISNULL((Select SUM(CREDKAR.NMONTO)    FROM CREDKAR inner join CREMCRE AS C on CREDKAR.CCODCTA = C.CCODCTA INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN  INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=C.CCODCLI  WHERE CREDKAR.CCONCEP = 'KP'    AND CREDKAR.CDESCOB = 'C'    and CREDKAR.CESTADO = ' '   AND C.CESTADO='F'  AND C.CCODSOL='001001000000' " + strFondo + strAgencia + strFecha + strAnalista + strTipoCartera + strMunicipio + " ),0)  ) " & _
                    " )as saldocapital, " & _
                    " ( " & _
                    " Select COUNT(C.CCODCTA) " & _
                    " FROM CREMCRE AS C INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN INNER JOIN CLIMIDE ON C.CCODCLI=CLIMIDE.CCODCLI " & _
                    " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO  " & _
                    " WHERE C.CCODSOL='001001000000' " & _
                    " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471'  " & _
                    " AND C.CESTADO in('G','F') " & _
                    " AND CLIMIDE.CSEXO<>'M' " + strFondo + strAgencia + strAnalista + strTipoCartera + strMunicipio & _
                    " ) as mujeres, " & _
                    " ( " & _
                    " Select COUNT(C.CCODCTA) " & _
                    " FROM CREMCRE AS C INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN INNER JOIN CLIMIDE ON C.CCODCLI=CLIMIDE.CCODCLI " & _
                    " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO  " & _
                    " WHERE C.CCODSOL='001001000000' " & _
                    " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471'  " & _
                    " AND C.CESTADO in('G','F') " & _
                    " AND CLIMIDE.CSEXO='M' " + strFondo + strAgencia + strAnalista + strTipoCartera + strMunicipio & _
                    " ) as hombres, " & _
                    " ( " & _
                    " Select SUM(CREDKAR.NMONTO) " & _
                    " FROM CREDKAR inner join CREMCRE AS C on CREDKAR.CCODCTA = C.CCODCTA INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=C.CCODCLI    " & _
                    " WHERE CREDKAR.CCONCEP = 'KP'    AND CREDKAR.CDESCOB = 'D'    and CREDKAR.CESTADO = ' ' AND C.CCODSOL='001001000000' AND C.CESTADO='F'  " + strFondo + strAgencia + strFecha + strAnalista + strTipoCartera + strMunicipio & _
                    " ) as montootorgado"

                Else
                    strCadena = " " & _
                    " SELECT MONTOOTORGADO,SALDOCAPITAL,VIGENTES,CCODSOL,CNOMGRU,CCODPRD,CDESCRI,DFECVIG,DFECVEN, " & _
                    " ( " & _
                    "     select COUNT(C2.CCODCTA) " & _
                    "     from CREMCRE AS C2 " & _
                    "     WHERE C2.CESTADO IN ('F','G')  " & _
                    "     AND C2.CCODSOL=TEMP2.CCODSOL " & _
                    "     AND C2.DFECVIG=TEMP2.DFECVIG " & _
                    " ) as integrantes, " & _
                    " ( " & _
                    " select COUNT(C3.CCODCTA)  " & _
                    " from CREMCRE AS C3 INNER JOIN CLIMIDE ON C3.CCODCLI=CLIMIDE.CCODCLI  " & _
                    " where  C3.CESTADO IN ('F','G')  " & _
                    " AND CLIMIDE.CSEXO<>'M' " & _
                    " AND C3.CCODSOL=TEMP2.CCODSOL " & _
                    " AND C3.DFECVIG=TEMP2.DFECVIG " & _
                    " ) as mujeres, " & _
                    " ( " & _
                    " select COUNT(C4.CCODCTA)  " & _
                    " from CREMCRE AS C4 INNER JOIN CLIMIDE ON C4.CCODCLI=CLIMIDE.CCODCLI  " & _
                    " where  C4.CESTADO IN ('F','G')  " & _
                    " AND CLIMIDE.CSEXO='M' " & _
                    " AND C4.CCODSOL=TEMP2.CCODSOL " & _
                    " AND C4.DFECVIG=TEMP2.DFECVIG " & _
                    " ) as hombres " & _
                    " FROM ( " & _
                    " SELECT SUM(montootorgado) as montootorgado,SUM(SALDOCAPITAL) as saldocapital,count(ccodsol) as vigentes, " & _
                    " CCODSOL,CNOMGRU,CCODPRD,CDESCRI,DFECVIG,DFECVEN " & _
                    " FROM ( " & _
                    " SELECT " & _
                    " ( select COUNT(*) " & _
                    " from CREDKAR  " & _
                    " WHERE CREDKAR.CCODCTA = C.CCODCTA " & _
                    "  AND C.CESTADO IN ('F','G')  " & _
                    "  ) as integrantes, " & _
                    " (Select SUM(CREDKAR.NMONTO)  " & _
                    " FROM CREDKAR " & _
                    " WHERE CREDKAR.CCODCTA = C.CCODCTA " & _
                    " AND CREDKAR.CCONCEP = 'KP' " & _
                    " AND CREDKAR.CDESCOB = 'D' " & _
                    " and CREDKAR.CESTADO = ' ' " + strFecha & _
                    " ) as montootorgado," & _
                    " (Select SUM(CREDKAR.NMONTO) " & _
                    " FROM CREDKAR " & _
                    " WHERE CREDKAR.CCODCTA = C.CCODCTA " & _
                    " AND CREDKAR.CCONCEP = 'KP' " & _
                    " AND CREDKAR.CDESCOB = 'D' " & _
                    " and CREDKAR.CESTADO = ' ' " + strFecha & _
                    " )- " & _
                    " ISNULL((Select SUM(CREDKAR.NMONTO) " & _
                    " FROM CREDKAR  " & _
                    " WHERE CREDKAR.CCODCTA = C.CCODCTA " & _
                    " AND CREDKAR.CCONCEP = 'KP' " & _
                    " AND CREDKAR.CDESCOB = 'C' " & _
                    " and CREDKAR.CESTADO = ' ' " + strFecha & _
                    " ),0) as saldocapital,C.CCODSOL,CREMSOL.CNOMGRU,C.DFECVIG,C.DFECVEN,SUBSTRING(CRETLIN.CCODLIN,5,2) AS ccodprd,TABTTAB.CDESCRI " & _
                    " FROM CREMCRE AS C INNER JOIN CREMSOL ON C.CCODSOL=CREMSOL.CCODSOL INNER JOIN CRETLIN ON C.CNROLIN=CRETLIN.CNROLIN " & _
                    " INNER JOIN TABTTAB ON SUBSTRING(CRETLIN.CCODLIN,5,2)=TABTTAB.CCODIGO " & _
                    " INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI=C.CCODCLI " & _
                    " WHERE C.CESTADO='F' " & _
                    " AND TABTTAB.CCODTAB+TABTTAB.CTIPREG='1471' " + strProducto + strFondo + strAgencia + strAnalista + strTipoCartera + strMunicipio & _
                    " ) TEMP  " & _
                    " GROUP BY CCODSOL,CNOMGRU,CCODPRD,CDESCRI,DFECVIG,DFECVEN " & _
                    " ) AS TEMP2 "

                End If



                cmComando2.CommandText = strCadena
                cmComando2.Connection = cnConexion2
                drResultado = cmComando2.ExecuteReader

                If i = 1 Then
                    If drResultado.Read Then


                        fila = dtTabla.NewRow()
                        fila("ccodsol") = "001001000000"
                        fila("cnomgru") = "INDIVIDUALES"
                        fila("dfecvig") = "01/01/2005"
                        fila("dfecven") = "01/01/2005"
                        fila("ccodprd") = "01"
                        fila("cdescri") = "CREDITOS INDIVIDUALES"
                        fila("vigentes") = drResultado.Item("vigentes")
                        fila("integrantes") = drResultado.Item("integrantes")
                        fila("nsalcap") = drResultado.Item("saldocapital")
                        fila("hombres") = drResultado.Item("hombres")
                        fila("mujeres") = drResultado.Item("mujeres")
                        If IsDBNull(drResultado.Item("MontoOtorgado")) Then
                            fila("ncapdes") = 0
                        Else
                            fila("ncapdes") = drResultado.Item("montootorgado")
                        End If
                        If IsDBNull(drResultado.Item("saldocapital")) Then
                            fila("nsalcap") = 0
                        Else
                            fila("nsalcap") = drResultado.Item("saldocapital")
                        End If


                        dtTabla.Rows.Add(fila)
                    End If
                Else
                    While drResultado.Read
                        fila = dtTabla.NewRow()
                        fila("ccodsol") = drResultado.Item("ccodsol")
                        fila("cnomgru") = drResultado.Item("cnomgru")
                        fila("dfecvig") = drResultado.Item("dfecvig")
                        fila("dfecven") = drResultado.Item("dfecven")
                        fila("ccodprd") = drResultado.Item("ccodprd")
                        fila("cdescri") = drResultado.Item("cdescri")
                        fila("vigentes") = drResultado.Item("vigentes")
                        fila("nsalcap") = drResultado.Item("saldocapital")
                        fila("integrantes") = drResultado.Item("integrantes")
                        fila("hombres") = drResultado.Item("hombres")
                        fila("mujeres") = drResultado.Item("mujeres")
                        fila("ncapdes") = drResultado.Item("montootorgado")
                        dtTabla.Rows.Add(fila)
                    End While
                End If


                strCadena = ""
                drResultado.Close()
            Next
        End Using

        Return dtTabla
    End Function

'GENERA REPORTE DE OTROS INGRESOS
    Public Function OtrosIngresos(ByVal Agencia As String, ByVal FechaInicio As String, ByVal FechaFin As String) As DataTable

        Dim strCadena As String = ""
        Dim strAgencia As String = ""
        Dim strFecha As String = ""
        Dim dtTabla As New DataTable("otrosingresos")
        Dim daIngresos As New SqlDataAdapter
        Dim cmComando As New SqlCommand


        Using cnConexion As New SqlConnection(Me.cnnStr)
            cnConexion.Open()


            If Agencia <> "*" Then
                strAgencia = " and cntamov.ccodofi='" + Agencia + "' "
            End If

            strFecha = " and cntamov.dfeccnt between '" + FechaInicio + "' and '" + FechaFin + "' "


            strCadena = " " & _
            " select cremsol.cnomgru as cnomcli,temp.ffondos as fondo,temp.cnumdoc,temp.dfeccnt,temp.ccodofi,(CASE WHEN temp.cnumrec='' THEN temp.ndebe*-1 ELSE temp.ndebe END) as ndebe,temp.cnumrec,temp.ccodcli as otrosingresos,c2.ccodcli as codcliente,c2.ccodsol, " & _
            " ( " & _
            " select count(ccodsol) " & _
            " from cremcre as c1 " & _
            " where c1.ccodsol=c2.ccodsol " & _
            " and cestado='F' " & _
            " group by c1.ccodsol " & _
            " ) as clientes,CREMSOL.cnomgru " & _
            " from ( " & _
            " select cnumcom,ffondos,dfeccnt,ccodpres,ccodofi,cnumrec,ccodcli,cnumdoc,ndebe " & _
            " from cntamov " & _
            " where ccodcli in ('LG','CO') " & _
            " and ndebe>0 " + strAgencia + strFecha & _
            " and cflc<>'X' " & _
            " group by cnumcom,ffondos,dfeccnt,ccodpres,ccodofi,cnumrec,ccodcli,cnumdoc,ndebe) as temp " & _
            " inner join cremcre as c2 on temp.ccodpres=c2.ccodcli inner join CREMSOL ON CREMSOL.CCODSOL=C2.CCODSOL " & _
            " where c2.cestado='F' " & _
            " and substring(c2.ccodcta,7,2) in ('02','03') " & _
            " union all " & _
            " select climide.cnomcli,temp.ffondos as fondo,temp.cnumdoc,temp.dfeccnt,temp.ccodofi,(CASE WHEN temp.cnumrec='' THEN temp.ndebe*-1 ELSE temp.ndebe END) as ndebe,temp.cnumrec,temp.ccodcli as otrosingresos,c2.ccodcli as codcliente,c2.ccodsol, " & _
            " ( " & _
            " select count(ccodsol) " & _
            " from cremcre as c1 " & _
            " where c1.ccodsol=c2.ccodsol " & _
            " and c1.ccodcli=c2.ccodcli " & _
            " and cestado='F' " & _
            " group by c1.ccodsol " & _
            " ) as clientes,CREMSOL.cnomgru " & _
            " from ( " & _
            " select cnumcom,ffondos,dfeccnt,ccodpres,ccodofi,cnumrec,ccodcli,cnumdoc,ndebe " & _
            " from cntamov " & _
            " where ccodcli in ('LG','CO') " & _
            " and ndebe>0 " + strAgencia + strFecha & _
            " and cflc<>'X' " & _
            " group by cnumcom,ffondos,dfeccnt,ccodpres,ccodofi,cnumrec,ccodcli,cnumdoc,ndebe) as temp " & _
            " inner join cremcre as c2 on temp.ccodpres=c2.ccodcli inner join CREMSOL ON CREMSOL.CCODSOL=C2.CCODSOL " & _
            " inner join climide on climide.ccodcli=c2.ccodcli " & _
            " where c2.cestado='F' " & _
            " and substring(c2.ccodcta,7,2) in ('01') " & _
            " union all " & _
            " select cnomcli,temp.ffondos as fondo,temp.cnumdoc,temp.dfeccnt,temp.ccodofi,(CASE WHEN temp.cnumrec='' THEN temp.ndebe*-1 ELSE temp.ndebe END) as ndebe,temp.cnumrec,temp.ccodcli as otrosingresos,ccodpres as codcliente,ccodpres as ccodsol,clientes,SPACE(20) as cnomgru " & _
            " from ( " & _
            " select climide.cnomcli,cntamov.cnumcom,cntamov.ffondos,cntamov.dfeccnt,cntamov.ccodpres,cntamov.ccodofi,cntamov.cnumrec,cntamov.ccodcli,cntamov.cnumdoc,cntamov.ndebe,count(climide.ccodcli) as clientes " & _
            " from cntamov inner join climide on cntamov.ccodpres=climide.ccodcli " & _
            " where cntamov.ccodcli in ('RF') " & _
            " and cntamov.ndebe>0 " + strAgencia + strFecha & _
            " and cflc<>'X' " & _
            " group by climide.cnomcli,cntamov.cnumcom,cntamov.ffondos,cntamov.dfeccnt,cntamov.ccodpres,cntamov.ccodofi,cntamov.cnumrec,cntamov.ccodcli,cntamov.cnumdoc,cntamov.ndebe ) as temp "


            cmComando.CommandText = strCadena
            cmComando.Connection = cnConexion
            daIngresos.SelectCommand = cmComando
            daIngresos.SelectCommand.CommandTimeout = 0
            daIngresos.Fill(dtTabla)
            daIngresos.SelectCommand.Dispose()

        End Using

        Return dtTabla
    End Function

    Public Function Estimacionpor(ByVal cmes As String, ByVal cyear As String, ByVal ccodofi As String, ByVal ffondos As String, ByVal ccalifica As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nestimacion from estimacion ")
        strSQL.Append("WHERE left(cmes,2) = left(@cmes,2) and left(cyear,4) =left(@cyear,4) ")
        strSQL.Append("and left(ccodofi,3) = left(@ccodofi,3) and left(ffondos,2) = left(@ffondos,2) ")
        strSQL.Append("and rtrim(ltrim(ccalifica)) = rtrim(ltrim(@ccalifica)) ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(0).Value = ffondos
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = ccodofi
        args(2) = New SqlParameter("@cmes", SqlDbType.VarChar)
        args(2).Value = cmes
        args(3) = New SqlParameter("@cyear", SqlDbType.VarChar)
        args(3).Value = cyear
        args(4) = New SqlParameter("@ccalifica", SqlDbType.VarChar)
        args(4).Value = ccalifica

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnestimacion As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nestimacion")) Then

            Else
                lnestimacion = ds.Tables(0).Rows(0)("nestimacion")
            End If
        End If
        Return lnestimacion
    End Function

    Public Function EstimacionCartera(ByVal dfecha As Date) As DataSet
        Dim lcfecha As String
        lcfecha = dfecha.ToString
        Dim lcmes As String = lcfecha.Substring(3, 2)
        Dim lcyear As String = lcfecha.Substring(6, 4)


        Dim strSQL As New StringBuilder
        strSQL.Append("select ESTIMACION.ccodofi, estimacion.status, estimacion.nestimacion, tabtofi.cnomofi, estimacion.ffondos , tabttab.cdescri, ")
        strSQL.Append("estimacion.nsaldo, rtrim(ltrim(estimacion.ccalifica)) as ccalifica,  000000000.00 as valor, space(60) as etiqueta, 000.00 as npor, space(1) as cflag, ")
        strSQL.Append("nnumtab = (select nnumtab from tabttab where ccodtab ='101' and ltrim(rtrim(tabttab.ccodigo)) = rtrim(ltrim(ESTIMACION.ccalifica))),")
        strSQL.Append("00 as nnumtab2, 000000000.00 as nestiant ")
        strSQL.Append("from estimacion, tabtofi, tabttab ")
        strSQL.Append("WHERE estimacion.ccodofi = tabtofi.ccodofi and ")
        strSQL.Append("left(tabttab.ccodigo,2) = estimacion.ffondos ")
        strSQL.Append("and tabttab.ccodtab = '033' and tabttab.ctipreg = '1'  ")
        strSQL.Append("and left(cmes,2) = left(@cmes,2) and left(cyear,4) = left(@cyear,4) ")
        strSQL.Append("order by estimacion.ccodofi, estimacion.ffondos, estimacion.status, estimacion.ccalifica ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cmes", SqlDbType.VarChar)
        args(0).Value = lcmes
        args(1) = New SqlParameter("@cyear", SqlDbType.VarChar)
        args(1).Value = lcyear


        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    'Obtiene porcentaje de estimacion segun calificacion y fondo
    Public Function ObtienePorcentajeEstimacion(ByVal ccalifica As String, ByVal ffondos As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nnumtab from tabttab ")
        strSQL.Append("where ")
        strSQL.Append("ccodtab ='101' ")
        strSQL.Append("and ltrim(rtrim(ccodigo)) = rtrim(ltrim(@ccalifica)) ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccalifica", SqlDbType.VarChar)
        args(0).Value = ccalifica.Trim

        Dim ds As New DataSet
        Dim lnpor As Decimal = 0

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nnumtab")) Then
            Else
                lnpor = ds.Tables(0).Rows(0)("nnumtab")
            End If

        End If
        Return lnpor

    End Function

    Public Function ObtieneEstimacion(ByVal ffondos As String, ByVal ccodofi As String, ByVal cmes As String, ByVal cyear As String, ByVal status As String) As Decimal

        Dim strSQL As New StringBuilder
        strSQL.Append("Select sum(nestimacion) as nestimacion FROM ESTIMACION ")
        strSQL.Append("WHERE left(ffondos,2) = left(@ffondos,2) ")
        strSQL.Append("and left(ccodofi,3) = left(@ccodofi,3) ")
        strSQL.Append("and left(cmes,2) = left(@cmes,2) and left(cyear,4) = left(@cyear,4) and left(status,1) = left(@status,1) ")
        strSQL.Append("group by ffondos, ccodofi, cmes, cyear ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(0).Value = ffondos
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = ccodofi
        args(2) = New SqlParameter("@cmes", SqlDbType.VarChar)
        args(2).Value = cmes
        args(3) = New SqlParameter("@cyear", SqlDbType.VarChar)
        args(3).Value = cyear
        args(4) = New SqlParameter("@status", SqlDbType.VarChar)
        args(4).Value = status


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lnestimacion As Decimal = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nestimacion")) Then
            Else
                lnestimacion = ds.Tables(0).Rows(0)("nestimacion")
            End If
        End If

        Return lnestimacion
    End Function
    Public Function ObtieneCiclo(ByVal ccodcli As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT Cremcre.cCodcta FROM cremcre where cremcre.ccodcli = @ccodcli and cestado <> 'A' ")
        strSQL.Append(" order by Cremcre.dfecvig  ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.Char)
        args(0).Value = ccodcli

       
        Dim lnciclo As Integer = 1
        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count = 0 Then
            Return lnciclo
        Else
            lnciclo = ds.Tables(0).Rows.Count
            lnciclo += 1

        End If
        Return lnciclo
    End Function
    Public Function RecuperarProvision(ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select CREDPRO.*, climide.cnomcli, cremcre.ndiaatr, space(1) as cCalif, space(60) as cdescri from CREDPRO, climide, cremcre  ")
        strSQL.Append("WHERE credpro.cCodcta = cremcre.ccodcta and cremcre.ccodcli = climide.ccodcli and credpro.nprovan > 0 ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dfecha", SqlDbType.VarChar)
        args(0).Value = dfecha

        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer
        Dim lccalif As String = ""
        Dim lcdescri As String = ""


        Dim CadenaActual As String = ""
        Dim cadena As String = ""



        CadenaActual = Me.cnnStr
        cadena = Me.CadenaDatos(Date.Parse(dfecha))
        If cadena.Trim = CadenaActual.Trim Then
            cadena = CadenaActual
        End If

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
        If cadena.Trim = CadenaActual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        Return ds
    End Function
    Public Function Solicitudes(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" select cremcre.ccodcta, cremcre.ccodana, cremcre.dfecasi, climide.cnomcli, cremcre.ctipper, cremcre.ndiasug, cremcre.ccodcli, tabtusu.cnomusu, cremcre.nmonsol, cremcre.nmoncuo, cremcre.ncuosug,")
        strSQL.Append(" space(60) as cperiodo, space(60) as cgarantia, CREMCRE.ntasint, cretlin.cnrolin, cretlin.cdeslin, cremcre.dfecsol, ")
        strSQL.Append(" 000 as nciclo, climide.cteldom, ltrim(tabttab.cdescri) as cdescri, cremcre.dfecvig, climide.cdirdom, 0000 as ndias ")
        strSQL.Append(" FROM tabtusu, cremcre, cretlin, tabttab, climide ")
        strSQL.Append(" where tabtusu.ccodusu = cremcre.ccodana and ")
        strSQL.Append(" cremcre.ccodcli = climide.ccodcli and ")
        strSQL.Append(" cremcre.cnrolin  = cretlin.cnrolin and ")
        strSQL.Append(" tabttab.ccodtab = '033' and tabttab.ctipreg = '1' and ")
        strSQL.Append(" left(tabttab.ccodigo,2) = substring(cretlin.ccodlin,3,2) and ")
        strSQL.Append(" cremcre.cestado IN('A','C','E') and cremcre.ccodrec = ' ' ")
        'strSQL.Append(" and cremcre.dfecsol >=@dfecha1 and cremcre.dfecsol <=@dfecha2 ")

        'If lnnivel = 1 Then
        '        strSQL.Append(" and cremcre.nmonsug > @limite1 and cremcre.nmonsug <= @limite2 ")
        'ElseIf lnnivel = 2 Then
        'Else
        '    strSQL.Append(" and cremcre.nmonsug >5000 ")
        'End If
        'se filtra solo para creditos cancelados y/o vencimiento

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        strSQL.Append(" ORDER BY CREMCRE.cCodAna, cremcre.dfecsol,  CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString



        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            Dim nelem As Integer
            Dim fila As DataRow
            Dim pccodcta As String
            Dim pccodcli As String
            Dim pctipper As String
            Dim pndia As Integer
            Dim ldfecsol As Date
            Dim pnciclo As Integer
            Dim lndias As Integer

            For Each fila In ds.Tables(0).Rows
                pccodcta = fila("ccodcta")
                pccodcli = fila("ccodcli")
                pctipper = fila("ctipper")
                ldfecsol = fila("dfecasi")
                pndia = fila("ndiasug")
                pnciclo = Me.Ciclo(pccodcli, pccodcta)

                lndias = DateDiff(DateInterval.Day, ldfecsol, dfecha)
                fila("nciclo") = pnciclo
                fila("ndias") = lndias
                nelem += 1
            Next


        End If


        Return ds
    End Function


    Public Function Solicitudes_Pendientes(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, _
                                           ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, _
                                           ByVal lmora As Boolean, ByVal lccartera As String, ByVal dfecha As Date) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                'Extrae solictudes Pendientes
                _sql = _
                         " Select b.ccodcta, b.ccodana, b.dfecasi, e.cnomcli, b.ctipper, b.ndiasug, " & _
                         " b.ccodcli, a.cnomusu, b.nmonsol, b.nmoncuo, b.ncuosug, " & _
                         " space(60) as cperiodo, space(60) as cgarantia, b.ntasint, c.cnrolin, c.cdeslin, b.dfecsol, " & _
                         " 000 as nciclo, e.cteldom, ltrim(d.cdescri) as cdescri, b.dfecvig, e.cdirdom, 0000 as ndias, " & _
                         " b.ccodsol, f.cnomgru, b.ccodofi, g.cnomofi " & _
                         " FROM tabtusu a " & _
                         " inner join cremcre b " & _
                         " on a.ccodusu = b.ccodana " & _
                         " inner join cretlin c " & _
                         " on b.cnrolin = c.cnrolin " & _
                         " inner join tabttab d " & _
                         " on b.cnrolin  = c.cnrolin " & _
                         " inner join climide e " & _
                         " on b.ccodcli = e.ccodcli " & _
                         " inner join cremsol f " & _
                         " on b.ccodsol = f.cCodsol " & _
                         " inner join tabtofi g " & _
                         " on b.ccodofi = g.ccodofi " & _
                         " where  d.ccodtab = '033' and d.ctipreg = '1' and " & _
                         " left(d.ccodigo,2) = substring(c.ccodlin,3,2) and " & _
                         " b.cestado IN('A','C','E') and b.ccodrec = ' ' "


                If lcanalista <> "*" Then
                    _sql = _sql + "and b.ccodana = @lcanalista "
                End If
                If lcoficina <> "*" Then
                    _sql = _sql + "and b.coficina = @lcoficina "
                End If
                If lclineas <> "*" Then
                    _sql = _sql + "and substring(c.ccodlin,3,2) = @lclineas "
                End If

                _sql = _sql + " Order by b.ccodofi, b.ccodsol "


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Temporal")


                Dim pnciclo As Integer
                Dim lndias As Integer
                Dim ldfecsol As Date

                For Each fila As DataRow In ds_Trab.Tables("Temporal").Rows
                    ldfecsol = fila("dfecasi")
                    lndias = DateDiff(DateInterval.Day, ldfecsol, dfecha)
                    fila("nciclo") = Me.Ciclo(fila("ccodcli"), fila("ccodcta"))
                    fila("ndias") = lndias
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

    Public Function RAldeas(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT a.ccodzon, a.cdeszon as Comunidad, a.cnivreg, ")
        strSQL.Append("(select b.cdeszon from tabtzon b where ctipzon ='1' and left(b.ccodzon,2) = left(a.ccodzon,2)) as Departamento, ")
        strSQL.Append("   (select b.ccodzon from tabtzon b where ctipzon ='1' and left(b.ccodzon,2) = left(a.ccodzon,2)) as ccoddep, ")
        strSQL.Append("(select c.cdeszon from tabtzon c where ctipzon ='2' and left(c.ccodzon,4) = left(a.ccodzon,4)) as Municipio, ")
        strSQL.Append("   (select c.ccodzon from tabtzon c where ctipzon ='2' and left(c.ccodzon,4) = left(a.ccodzon,4)) as ccodmun, ")
        strSQL.Append("   0000000000000.00 as nmonto, ")
        strSQL.Append("   0000000000000.00 as nsaldo, ")
        strSQL.Append("   000000000 as ncreditos, ")
        strSQL.Append("   0000000000000.00 as ncarafecta, ")
        strSQL.Append("   0000000000 as ncasosafec ")
        strSQL.Append("   FROM tabtzon a ")
        strSQL.Append("   WHERE  a.ctipzon ='3'  ")

        If lczona = "*" Then
        Else
            strSQL.Append(" and left(a.ccodzon,4) = left(@lczona,4)")
        End If

        strSQL.Append(" order by a.ccodzon")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Public Function EstructuraComisiones() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT left(tabttab.ccodigo,2) as ccodigo,tabttab.cdescri, 00000000.00 as nmongas ")
        strSQL.Append(" FROM tabttab ")
        strSQL.Append(" WHERE  tabttab.ccodtab ='008' and tabttab.ctipreg ='1' order by tabttab.ccodigo ")


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds
    End Function

    Public Function Comisiones(ByVal nmonto As Double, ByVal csector As String, ByVal lsegvid As Boolean) As DataTable
        Dim ds As New DataSet
        ds = EstructuraComisiones()

        Dim fila As DataRow
        Dim lnmonto As Double = 0
        For Each fila In ds.Tables(0).Rows

            lnmonto = ObtieneComision(nmonto, csector, fila("ccodigo"))
            If lnmonto = 0 Then
                lnmonto = ObtieneComision(nmonto, "00", fila("ccodigo"))
            End If
            If fila("ccodigo") = "03" Then 'microseguro
                If lsegvid = True Then
                Else
                    lnmonto = 0
                End If
            End If
            fila("nmongas") = lnmonto
        Next
        Return ds.Tables(0)
    End Function


    Public Function ObtieneComision(ByVal nmonto As Double, ByVal csector As String, ByVal ctipgas As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT comisiones.nmonto ")
        strSQL.Append("FROM comisiones ")
        strSQL.Append("WHERE  @nmonto>= comisiones.nliminf  and @nmonto <= comisiones.nlimsup ")
        strSQL.Append("and  ctipgas = @ctipgas ") 'csector = @csector and

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nmonto", SqlDbType.Decimal)
        args(0).Value = nmonto
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = ctipgas.Trim

        'args(1) = New SqlParameter("@csector", SqlDbType.VarChar)
        'args(1).Value = csector.Trim

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnmonto As Double = 0
        Dim lnexced As Double = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lnmonto = ds.Tables(0).Rows(0)("nmonto")
            If nmonto > 60000 And (ctipgas = "01" Or ctipgas = "04") Then 'Cobrara excedente
                lnexced = Math.Round(((nmonto - 60000) * 0.004 / 2), 2)
                lnmonto = lnmonto + lnexced
            End If
        End If

        Return lnmonto
    End Function
    Public Function ComisionesGrupal(ByVal dsgrupo As DataSet) As DataTable
        Dim ds As New DataSet
        ds = EstructuraComisiones()

        Dim fila As DataRow
        Dim fila1 As DataRow
        Dim lnmonto As Double = 0
        Dim lccodlin As String
        For Each fila In ds.Tables(0).Rows
            For Each fila1 In dsgrupo.Tables(0).Rows
                lccodlin = fila1("ccodlin")
                lnmonto = ObtieneComision(fila1("nmonapr"), lccodlin.Substring(8, 2), fila("ccodigo"))
                If lnmonto = 0 Then
                    lnmonto = ObtieneComision(fila1("nmonapr"), "00", fila("ccodigo"))
                End If
                If fila("ccodigo") = "03" Then 'microseguro
                    If fila1("lsegvid") = True Then
                    Else
                        lnmonto = 0
                    End If
                End If
                fila("nmongas") = fila("nmongas") + lnmonto
            Next
        Next
        Return ds.Tables(0)

    End Function
    Public Function HistorialCreditos(ByVal ccodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select case when(select count(ccodcli) as vig from cremcre where ccodcli = @ccodcli and cestado ='F') is null then 0 else (select count(ccodcli) as vig from cremcre where ccodcli = @ccodcli and cestado ='F') end as ncrevig, ")
        strSQL.Append(" case when(select count(ccodcli) as vig from cremcre where ccodcli = @ccodcli and cestado ='G') is null then 0 else (select count(ccodcli) as vig from cremcre where ccodcli = @ccodcli and cestado ='G') end as ncrecan ")
        strSQL.Append(" from cremcre where ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function SaldoxCuenta2(ByVal ccodcta As String, ByVal dfecha As Date) As DataSet
        Dim strsql As New StringBuilder

        strsql.Append(" select  cremcre.ccodcta,cremcre.ccodcli,  ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strsql.Append(" from cremcre ")
        strsql.Append(" where cremcre.ccodcta = @ccodcta and ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end > ")
        strsql.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end   ")
        strsql.Append(" group by cremcre.ccodcta,cremcre.ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Return ExecuteDataSet(Me.cnnStr, CommandType.Text, strsql.ToString(), args, 0)

    End Function
    Public Function ObtenerAbonosCreditos(ByVal ccodcli As String, ByVal dfecha As Date) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("select sum(credkar.nmonto) as nmonto from cremcre, credkar ")
        strSQL.Append("where cremcre.ccodcta = credkar.ccodcta and cremcre.ccodcli = @ccodcli ")
        strSQL.Append("and credkar.dfecsis >= @dfecha and credkar.cdescob ='C'  and credkar.cconcep = 'CJ' ")
        strSQL.Append("and credkar.cestado <> 'X' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lnmonto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
            Else
                lnmonto = ds.Tables(0).Rows(0)("nmonto")
            End If
        End If

        Return lnmonto
    End Function
    Public Function RTipoCartera(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lccartera As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT left(a.ccodigo,2) as cCodigo, a.cdescri as Destino, ")
        strSQL.Append("   0000000000000.00 as nmonto,")
        strSQL.Append(" 0000000000000.00 as nsaldo,")
        strSQL.Append(" 0000000000 as ncreditos, ")
        strSQL.Append(" 0000000000000.00 as ncarafecta, ")
        strSQL.Append(" 0000000000 as ncasosafec, 0000000 as nhombres, 0000000 as nmujeres ")
        strSQL.Append(" FROM tabttab a ")
        strSQL.Append(" WHERE  a.cCodtab= '034' and a.ctipreg = '1' order by a.cdescri ")


        Dim a As String
        a = strSQL.ToString

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds
    End Function
    Private Sub SelectTabla_con_Banco(ByRef strSQL As StringBuilder)

        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, max(A.csexo) as csexo, MAX(A.cCodcli) as ccodcli, B.ccodcta, 0000 as nciclo,")
        strSQL.Append("C.dfecsis as dfecvig, B.dfecven, C.cnuming, C.dFecsis, C.Dfecpro, C.cnumrec, ")
        strSQL.Append("B.coficina as cCodOfi,B.coficina, D.cnomofi, B.ccodana, F.cnomusu, ")
        strSQL.Append("B.ccodsol, H.cnomgru, T.cCodsol as cCodcen, T.cNomgru as cNomcen, L.cnrolin, L.cdeslin, X.cnombco, C.cbanco, c.cbanco as ccodbco, ")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'N.A/CHEQUE' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append("WHEN 'P' THEN 'AJUSTES' ")
        strSQL.Append("WHEN 'D' THEN 'DOCUMENTO' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(40) as cnomusu,  ")
        strSQL.Append("00000000000.00 as nsaldo, 00000000000.00 as nCapdes, ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN (C.CCONCEP = 'IN' and c.ccondic <> 'S') or (C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='2')  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("Nservicio  = SUM(CASE  WHEN C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='1'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVADES  = SUM(CASE  WHEN C.CCONCEP = '02' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append(" INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin ")
        strSQL.Append(" INNER JOIN CREMSOL H ON B.ccodsol = H.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS T ON H.ccodcen = T.ccodsol  ")
        strSQL.Append(" inner join tabtusu F on B.ccodana = F.ccodusu ")
        'strSQL.Append(" inner join tabtbco X on C.cbanco = X.ccodbco ")
    End Sub

    Public Function DETALLE_CARTERA_Y_PAGOS_en_BANCOS(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_Banco(strSQL)



        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and (left(C.cnuming,9) <>'CANC/REFI' or c.cnuming is null)) ON B.cCodcta = C.cCodcta ")
        End If
        strSQL.Append(" inner join tabtbco X on C.cbanco = X.ccodbco ")

        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String

        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY C.cbanco, X.cnombco, B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,   C.cTippag, B.coficina, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin, B.ccodana, F.cnomusu ")
        strSQL.Append("order by C.cbanco, C.dfecsis, B.ccodsol,  L.cnrolin ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
                lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
                lnciclo = Me.Ciclo(lccodcli, lccodcta)
                ds.Tables(0).Rows(ele)("nciclo") = lnciclo
                ele += 1
            Next
        End If
        Return ds

    End Function
    Public Function ClientesdeGrupoenProceso(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, climide.ccodcli, climide.cnomcli, climide.cnudoci, cremcre.nmonsug, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.nmonsol, 00000000.00 as nmonto, cremcre.cflat, ")
        strSQL.Append("climide.csexo, SPACE(80) as ctipogar, 0000000.00 as nmontas, 0000000.00 as nmongra, space(120) as cnotario ")
        strSQL.Append("FROM CLIMIDE, CREMCRE ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and (cremcre.cestado = 'A' or cremcre.cestado = 'C' or cremcre.cestado ='E') and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) order by climide.cnomcli ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function FiltraTablaInteresesVencidos(ByVal TablaTemporal As DataTable, ByVal Filtro As String) As DataTable

        Dim dvVista As New DataView

        dvVista = TablaTemporal.DefaultView

        dvVista.RowFilter = Filtro

        Return dvVista.ToTable

    End Function
    Public Function Carteratotal() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodcta from cremcre where ctipgar is null ")

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception

        End Try

        Return ds

    End Function
    Public Function ActualizaTipoGarantia(ByVal ccodcta As String, ByVal ctipgar As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cremcre SET ctipgar = @ctipgar   WHERE ccodcta = @ccodcta")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ctipgar", SqlDbType.VarChar)
        args(1).Value = ctipgar


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function ListadoCreditosxGrupoenProceso(ByVal cCodsol As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.ccodcta, climide.cnomcli, climide.cnudoci, cremcre.nmonsug, cremcre.ncuosug as ncuoapr, cremcre.cnrolin, cremcre.nmonsol, cremcre.lsegvid, cremcre.nmonapr ")
        strSQL.Append("FROM CLIMIDE, CREMCRE ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol ")
        strSQL.Append("and (cremcre.cestado ='A' or cremcre.cestado = 'C' or cremcre.cestado = 'E') and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol

        Dim ds As DataSet

        Try
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Private Sub SelectTabla_con_kardex_CAJA(ByRef strSQL As StringBuilder)

        strSQL.Append("SELECT  max(A.cnomcli) as cnomcli, max(A.csexo) as csexo, MAX(A.cCodcli) as ccodcli, B.ccodcta, 0000 as nciclo, '001' as ccodtrx, 'COBRO DE PRESTAMOS' as cdestrx, 0000000.00 as negreso,   00000000.00 as ncontaE, C.dFecsis as dfecha2, space(150) as cnomofi, 000000000.00 as nsalini, ")
        strSQL.Append("C.dfecsis as dfecvig, B.dfecven,C.cnumrec as cnuming, C.dFecsis, C.Dfecpro, C.cnumrec, ")
        strSQL.Append("B.coficina as cCodOfi,B.coficina, D.cnomofi, B.ccodana, F.cnomusu, ")
        strSQL.Append("B.ccodsol, H.cnomgru, T.cCodsol as cCodcen, T.cNomgru as cNomcen, L.cnrolin, L.cdeslin, min(c.dfecmod) as dfecmod,  ")
        strSQL.Append("C.ctippag, Case cTippag ")
        strSQL.Append("WHEN 'E' THEN 'EFECTIVO' ")
        strSQL.Append("WHEN 'C' THEN 'N.A/CHEQUE' ")
        strSQL.Append("WHEN 'I' THEN 'CONDONACION' ")
        strSQL.Append("WHEN 'P' THEN 'AJUSTES' ")
        strSQL.Append("WHEN 'D' THEN 'DOCUMENTO' ")
        strSQL.Append(" END AS cTipopago, ")
        strSQL.Append("00000 as ncuoapr, 00000 as ndiaatr, SPACE(40) as cnomusu, space(60) as cnombco, ")
        strSQL.Append("00000000000.00 as nsaldo, 00000000000.00 as nCapdes, ")
        strSQL.Append("ncontaI =SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.ccodctb <> ' ' and C.ccodctb is not null  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NCAPITA  = SUM(CASE  WHEN C.CCONCEP = 'KP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NINTERE  = SUM(CASE  WHEN (C.CCONCEP = 'IN' and c.ccondic <> 'S') or (C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='2')  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("Nservicio  = SUM(CASE  WHEN C.CCONCEP = 'IN' and c.ccondic = 'S' and a.cclaper ='1'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NMORA    = SUM(CASE  WHEN C.CCONCEP = 'MO' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGO    = SUM(CASE  WHEN C.CCONCEP = 'CJ' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NPAGOEFE    = SUM(CASE  WHEN C.CCONCEP = 'CJ' and C.CTIPPAG = 'E' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDAN  = SUM(CASE  WHEN C.CCONCEP = 'GA' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NSEGDEU  = SUM(CASE  WHEN C.CCONCEP = '03' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NRESERVA = SUM(CASE  WHEN C.CCONCEP = '01' OR C.CCONCEP = 'RI'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NTALONA  = SUM(CASE  WHEN C.CCONCEP = '06' OR C.CCONCEP = 'TA'  THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NGASADM  = SUM(CASE  WHEN C.CCONCEP = '05' OR C.CCONCEP = 'OP' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NEXCED  = SUM(CASE  WHEN C.CCONCEP = 'EX' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVA  = SUM(CASE  WHEN C.CCONCEP = '08' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("NIVADES  = SUM(CASE  WHEN C.CCONCEP = '02' THEN NMONTO ELSE 0 END), ")
        strSQL.Append("TIPOPAGO = MAX(CASE  WHEN LTRIM(C.CCONCEP) = 'M' THEN 'Pagos manuales' ELSE 'Pagos automáticos' END), ")
        strSQL.Append("NOTROS = SUM(CASE  WHEN C.CCONCEP <> 'KP' AND C.CCONCEP <> 'CJ' and C.CCONCEP <> 'MO' and C.CCONCEP <> 'IN' and C.CCONCEP <> 'EX'  THEN NMONTO ELSE 0 END) ")
        strSQL.Append("FROM    Climide A INNER JOIN Cremcre B ON A.cCodcli = B.cCodcli ")
        strSQL.Append(" INNER JOIN Cretlin L ON B.cnrolin = L.cNrolin ")
        strSQL.Append(" INNER JOIN CREMSOL H ON B.ccodsol = H.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS T ON H.ccodcen = T.ccodsol  ")
        strSQL.Append(" inner join tabtusu F on B.ccodana = F.ccodusu ")

    End Sub

    Public Function DETALLE_CARTERA_Y_PAGOS_CAJA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String, ByVal ctippag As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex_CAJA(strSQL)
        If bandera = "*" Then
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and left(C.cnuming,9) ='CANC/REFI') ON B.cCodcta = C.cCodcta ")
        Else
            strSQL.Append("INNER JOIN (Credkar C INNER JOIN Tabtofi D ON C.cCodofi = D.cCodofi and (left(C.cnuming,9) <>'CANC/REFI' or c.cnuming is null)) ON B.cCodcta = C.cCodcta ")
        End If



        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")




        Dim transac As String
        If ctippag <> "*" Then
            strSQL.Append("AND c.ctippag = @ctippag ")
        End If
        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If


        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,   C.cTippag, B.coficina, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin, B.ccodana, F.cnomusu ")
        strSQL.Append("order by C.dfecsis,C.cNuming, C.cnumrec, T.ccodsol,  L.cnrolin ")


        Dim a As String
        a = strSQL.ToString

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        args(8) = New SqlParameter("@ctippag", SqlDbType.VarChar)
        args(8).Value = ctippag

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Return ds

    End Function
    '----------------
    Public Function ObtenerPagosdelPeriodo(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim strSQL As New StringBuilder
        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis>=@dfecha1 and  credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis>=@dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis>=@dfecha1 and  credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis>=@dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'IN' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS nintpag,  ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis>=@dfecha1 and  credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis>=@dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'MO' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS nmorpag  ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN tabtusu ON cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" INNER JOIN tabtusu k ON cremcre.canalisis = k.ccodusu  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" INNER JOIN TABTOFI ON CREMCRE.COFICINA = TABTOFI.CCODOFI  ")
        strSQL.Append(" inner join tabttab on substring(cretlin.ccodlin,3,2) = left(tabttab.ccodigo,2) and tabttab.ccodtab ='033' ")

        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            '       strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            '      strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")
        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado ='G' ) ") '

        End If
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If


        Dim a As String
        a = strSQL.ToString


        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        '    ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds
    End Function

    Public Function Filtrado(ByVal ds As DataSet, ByVal ccodcta As String) As DataSet
        Dim tabla As DataTable

        tabla = FiltraTabla(ds.Tables(0), "ccodcta='" + ccodcta + "'")

        Dim ds2 As New DataSet
        ds2.Tables.Add(tabla)
     

        Return ds2

    End Function
    Public Function FiltraTabla(ByVal TablaTemporal As DataTable, ByVal Filtro As String) As DataTable

        Dim dvVista As New DataView

        dvVista = TablaTemporal.DefaultView

        dvVista.RowFilter = Filtro

        Return dvVista.ToTable

    End Function
    Public Function CarteraCalculadaMINE(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,cremcre.cdescre, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, cremcre.ccodana, tabtusu.cnomusu as cnomana, tabtofi.cnomofi, climide.cclaper, climide.ccodofi, cremcre.nciclo,cremcre.csececo, cremcre.ccontra,cremcre.canalisis,k.cnomusu as cnomoto,cretlin.ccodlin,")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, CREMCRE.coficina, CREMCRE.cnrolin, climide.csexo, cretlin.ntasmor, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append(" (SELECT max(CREDKAR.dfecpro) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA)  AS dfecult  ")
        strSQL.Append(" ,cremcre.ctipgar, climide.cnudoci, climide.cnudotr,cremcre.ctipcuo,cremcre.cflat, substring(cretlin.ccodlin,3,2) as ffondos, tabttab.cdescri , cretlin.ccodlin, cremcre.nmoncuo ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN tabtusu ON cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" INNER JOIN tabtusu k ON cremcre.canalisis = k.ccodusu  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" INNER JOIN TABTOFI ON CREMCRE.COFICINA = TABTOFI.CCODOFI  ")
        strSQL.Append(" inner join tabttab on substring(cretlin.ccodlin,3,2) = left(tabttab.ccodigo,2) and tabttab.ccodtab ='033' ")

        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If
        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        ' strSQL.Append(" ORDER BY cremcre.coficina, cremcre.ccodana, cremcre.ccodcta, cremcre.dfecvig, CLIMIDE.cNomcli")

        'Creditos Cancelados en el periodo---------------------------------------------------------------------------------------
        strSQL.Append(" UNION ALL ")
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,cremcre.cdescre, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, cremcre.ccodana, tabtusu.cnomusu as cnomana, tabtofi.cnomofi, climide.cclaper, climide.ccodofi, cremcre.nciclo,cremcre.csececo, cremcre.ccontra,cremcre.canalisis,k.cnomusu as cnomoto,cretlin.ccodlin,")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, CREMCRE.coficina, CREMCRE.cnrolin, climide.csexo, cretlin.ntasmor, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag,  ")
        strSQL.Append(" (SELECT max(CREDKAR.dfecpro) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA)  AS dfecult  ")
        strSQL.Append(" ,cremcre.ctipgar, climide.cnudoci, climide.cnudotr,cremcre.ctipcuo,cremcre.cflat, substring(cretlin.ccodlin,3,2) as ffondos, tabttab.cdescri , cretlin.ccodlin, cremcre.nmoncuo ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN tabtusu ON cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" INNER JOIN tabtusu k ON cremcre.canalisis = k.ccodusu  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" INNER JOIN TABTOFI ON CREMCRE.COFICINA = TABTOFI.CCODOFI  ")
        strSQL.Append(" inner join tabttab on substring(cretlin.ccodlin,3,2) = left(tabttab.ccodigo,2) and tabttab.ccodtab ='033' ")

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  <= ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")
        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='G'  ")
        End If
        'Cancelados
        '        strSQL.Append(" CREMCRE.dfecvig <= @dfecha2    ")
        '       strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G')  ")
        strSQL.Append(" and (SELECT MAX(CREDKAR.dfecsis) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) >= @dfecha1 ")
        strSQL.Append(" and (SELECT MAX(CREDKAR.dfecsis) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2  and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) <= @dfecha2 ")

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If
        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY cremcre.coficina, cremcre.ccodana, cremcre.ccodcta, cremcre.dfecvig, CLIMIDE.cNomcli")
        '----------------------------------<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>



        Dim a As String
        a = strSQL.ToString


        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        '  ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds
    End Function
    Public Function RotorProbatorio() As DataSet
        Dim myadapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim myParameter As SqlParameter
        Dim ds As New DataSet

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "sp_SelectMine"

                command.CommandType = CommandType.StoredProcedure

                command.Parameters.Add("@fecha", SqlDbType.DateTime)
                myParameter.Value = #8/31/2013#


                myadapter.Fill(ds, "Mine")
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return ds
    End Function
    '-------Dentro de dbcreditos.vb

    Public Function Extraer_Cartera(ByVal pdfecsis As Date, ByVal pnTipo As Integer, ByVal lcanalista As String, _
                                       ByVal lcoficina As String, ByVal lclineas As String, ByVal lczona As String, _
                                       ByVal lcproducto As String, ByVal lccartera As String, ByVal lctipo As String) As DataSet


        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Sp_Cartera_Vigente"

                MyParameters = _
                                MyCommand.Parameters.Add("@dfecpro", SqlDbType.DateTime)
                MyParameters.Value = pdfecsis
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@ntipo", SqlDbType.Int)
                MyParameters.Value = pnTipo
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcanalista", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcoficina", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lclineas", SqlDbType.VarChar)
                MyParameters.Value = lclineas
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lczona", SqlDbType.VarChar)
                MyParameters.Value = lczona
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcproducto", SqlDbType.VarChar)
                MyParameters.Value = lcproducto
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lctipo", SqlDbType.VarChar)
                MyParameters.Value = lctipo
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lccartera", SqlDbType.VarChar)
                MyParameters.Value = lccartera
                MyParameters.Direction = ParameterDirection.Input

                'MyParameters = _
                '              MyCommand.Parameters.Add("@pnError", SqlDbType.Int)
                'MyParameters.Direction = ParameterDirection.ReturnValue

                '--@lcanalista varchar(10), 
                '--@lcoficina varchar(10),
                '--@lclineas varchar(10),
                '--@lczona varchar(10),
                '--@lcproducto varchar(10),
                '--@lctipo varchar(10),
                '--@lccartera varchar(10)    


                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds, "Cartera")

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
    Public Function Obtener_Saldo(ByVal ccodcta As String) As Decimal
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lnsaldo As Decimal = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = " Select Cremcre.ccodcta, " & _
                                      " ncapdes = case when(select sum(credkar.nmonto) from credkar where cremcre.ccodcta = credkar.ccodcta and credkar.cdescob ='D' and " & _
                                      " credkar.cestado =' ' and credkar.cconcep ='KP' and credkar.ccodcta ='" & ccodcta & _
                                      " 'group by credkar.ccodcta ) is null then 0 else   (select sum(credkar.nmonto) from credkar " & _
                                      " where cremcre.ccodcta = credkar.ccodcta and credkar.cdescob ='D' and credkar.cestado =' ' and " & _
                                      " credkar.cconcep ='KP' and credkar.ccodcta ='" & ccodcta & "' group by credkar.ccodcta ) end ," & _
                                      " ncappag = case when(select sum(credkar.nmonto) from credkar where cremcre.ccodcta = credkar.ccodcta and credkar.cdescob ='C' and " & _
                                      " credkar.cestado =' ' and credkar.cconcep ='KP' and credkar.ccodcta ='" & ccodcta & _
                                      " ' group by credkar.ccodcta ) is null then 0 else   (select sum(credkar.nmonto) from credkar " & _
                                      " where cremcre.ccodcta = credkar.ccodcta and credkar.cdescob ='C' and credkar.cestado =' ' and " & _
                                      " credkar.cconcep ='KP' and credkar.ccodcta ='" & ccodcta & "' group by credkar.ccodcta ) end " & _
                                      " FROM cremcre where ccodcta='" & ccodcta & "'"
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Saldo")
                For Each fila As DataRow In ds.Tables("Saldo").Rows
                    lnsaldo = Math.Round(fila("ncapdes") - fila("ncappag"), 2)
                Next

            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return Math.Round(lnsaldo, 2)
    End Function
    Public Function ValidaEstadoMINE(ByVal dsvalida As DataSet, ByVal dfecha2 As Date) As DataSet
        Dim lcestado As String
        If dsvalida.Tables(0).Rows.Count = 0 Then
        Else
            Dim nelem As Integer
            Dim fila As DataRow
            Dim lncapdes As Double = 0
            Dim lncappag As Double = 0
            Dim lnsaldo As Double = 0
            Dim ecredkar As New dbCredkar
            Dim ldultpag As Date


            For Each fila In dsvalida.Tables(0).Rows

                If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncapdes")) Then
                    dsvalida.Tables(0).Rows(nelem)("ncapdes") = 0
                End If
                If IsDBNull(dsvalida.Tables(0).Rows(nelem)("ncappag")) Then
                    dsvalida.Tables(0).Rows(nelem)("ncappag") = 0
                End If
                lncapdes = dsvalida.Tables(0).Rows(nelem)("ncapdes")
                lncappag = dsvalida.Tables(0).Rows(nelem)("ncappag")
                lnsaldo = lncapdes - lncappag
                If Math.Round(lnsaldo, 2) <= 0 Then
                    dsvalida.Tables(0).Rows(nelem)("cEstado") = "G"
                    lcestado = "G"
                Else
                    dsvalida.Tables(0).Rows(nelem)("cEstado") = "F"
                    lcestado = "F"
                End If

                'If lcestado.Trim = "G" Then
                '    dsvalida.Tables(0).Rows(nelem).Delete()
                '    dsvalida.Tables(0).GetChanges(DataRowState.Deleted)
                'End If
                nelem += 1
            Next
        End If
        ' dsvalida.Tables(0).AcceptChanges()
        Return dsvalida
    End Function
    Public Function Trasladar_Analista_Lote(ByVal ccodanaact As String, ByVal cmetodo As String, ByVal cprogra As String, ByVal cproducto As String, _
                                          ByVal cfondo As String, ByVal cdepa As String, ByVal cmuni As String, ByVal caldea As String, _
                                          ByVal ccodananue As String, ByVal ctipo As String) As Integer

        Dim i As Integer = 0
        Dim command As New SqlCommand
        Dim sqltext As String
        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                sqltext = "UPDATE CREMCRE SET ccodana ='" & ccodananue.Trim & "' " & _
                                        "WHERE cestado ='F' "

                If ccodanaact.Trim = "" Then
                Else
                    sqltext = sqltext & " and ccodana= '" & ccodanaact.Trim & "'"
                End If

                If cmetodo.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.cnrolin = (select cretlin.cnrolin from cretlin where cremcre.cnrolin = cretlin.cnrolin and substring(cretlin.ccodlin,5,2) ='" & cmetodo.Trim & "' group by cretlin.cnrolin ) "
                End If
                If cprogra.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.cnrolin = (select cretlin.cnrolin from cretlin where cremcre.cnrolin = cretlin.cnrolin and substring(cretlin.ccodlin,7,2) ='" & cprogra.Trim & "' group by cretlin.cnrolin ) "
                End If
                If cproducto.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.cnrolin = (select cretlin.cnrolin from cretlin where cremcre.cnrolin = cretlin.cnrolin and substring(cretlin.ccodlin,9,2) ='" & cproducto.Trim & "' group by cretlin.cnrolin ) "
                End If
                If cfondo.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.cnrolin = (select cretlin.cnrolin from cretlin where cremcre.cnrolin = cretlin.cnrolin and substring(cretlin.ccodlin,3,2) ='" & cfondo.Trim & "' group by cretlin.cnrolin ) "
                End If
                If cdepa.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.ccodcli = (select climide.ccodcli from climide where cremcre.ccodcli = climide.ccodcli and left(climide.ccoddom,2) ='" & Left(cdepa.Trim, 2) & "' group by climide.ccodcli )"
                End If
                If cmuni.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.ccodcli = (select climide.ccodcli from climide where cremcre.ccodcli = climide.ccodcli and left(climide.ccoddom,4) ='" & Left(cmuni.Trim, 4) & "' group by climide.ccodcli )"
                End If
                If caldea.Trim = "" Then
                Else
                    sqltext = sqltext & " and cremcre.ccodcli = (select climide.ccodcli from climide where cremcre.ccodcli = climide.ccodcli and left(climide.ccoddom,6) ='" & Left(caldea.Trim, 6) & "' group by climide.ccodcli )"
                End If
                If ctipo.Trim = "" Then 'tipo de cartera
                Else
                    If ctipo = "I" Then 'cartera castigada
                        sqltext = sqltext & " and cremcre.ccodcli = 'S' "
                    Else
                        sqltext = sqltext & " and cremcre.ccodcli <> 'S' "
                    End If

                End If
                command.Connection = conneccion
                command.CommandText = sqltext
                command.ExecuteNonQuery()
                lnretorno = 1
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using
        Return lnretorno
    End Function
    Public Function ComisionesIndividual(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String) As DataSet
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "rptComisiones"


                MyParameters = _
                               MyCommand.Parameters.Add("@dfecha1", SqlDbType.DateTime)
                MyParameters.Value = dfecha1
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                              MyCommand.Parameters.Add("@dfecha2", SqlDbType.DateTime)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                              MyCommand.Parameters.Add("@lcoficina", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                              MyCommand.Parameters.Add("@lcanalista", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input


                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return Ds

    End Function

    'Pagos aplicados de Agencia
    Public Function DETALLE_CARTERA_Y_PAGOS_AGENCIA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcdescob As String, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal bandera As String, ByVal lccajeros As String, ByVal lczona As String, ByVal ctippag As String) As DataSet

        Dim strSQL As New StringBuilder

        SelectTabla_con_kardex(strSQL)
        If bandera = "*" Then
            strSQL.Append("INNER JOIN Credkar C ON B.cCodcta = C.cCodcta and left(C.cnuming,9) ='CANC/REFI'  ")
        Else
            strSQL.Append("INNER JOIN Credkar C ON B.cCodcta = C.cCodcta and (left(C.cnuming,9) <>'CANC/REFI' or c.cnuming is null) ")
        End If
        strSQL.Append(" inner join tabtofi D on b.coficina = D.ccodofi ")

        strSQL.Append("WHERE  C.CDESCOB = @lcdescob AND C.cestado = ' ' ")
        strSQL.Append("AND C.DFECSIS >= @DFECHA1 AND C.DFECSIS <= @DFECHA2 ")


        Dim transac As String
        If ctippag <> "*" Then
            strSQL.Append("AND c.ctippag = @ctippag ")
        End If
        If lcanalista <> "*" Then
            strSQL.Append("AND b.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND b.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(L.ccodlin,3,2) = @lclineas ")
        End If
        If lccajeros <> "*" Then
            strSQL.Append("AND C.ccodusu = @lccajeros ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(A.cCoddom,4)= @lczona ")
        End If

        '        strSQL.Append("AND CREDKAR.DFECSIS >= @DFECHA1 ")
        strSQL.Append("GROUP BY B.cCodcta,  C.Dfecsis,  C.Dfecpro,  C.cNrodoc,  C.cNuming, C.cnumrec,   C.cTippag, B.coficina, D.cNomofi, B.dfecven, B.ccodsol, H.cnomgru, T.ccodsol, T.cnomgru, L.cnrolin, L.cdeslin,L.ccodlin, B.ccodana, F.cnomusu, B.cflat ")
        strSQL.Append("order by C.dfecsis,C.cNuming, C.cnumrec, T.ccodsol,  L.cnrolin ")

        If lcdescob = "D" Then
            'strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA")
        Else
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.CCODCTA, CREDKAR.DFECSIS, CREDKAR.CNRODOC ")
            ' strSQL.Append("AND CREDKAR.DFECSIS <= @DFECHA2 GROUP BY CREMCRE.cCodcta,  CREDKAR.Dfecsis,  CREDKAR.Dfecpro,  CREDKAR.cNrodoc,  CREDKAR.cNuming")
        End If


        Dim a As String
        a = strSQL.ToString

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcdescob", SqlDbType.VarChar)
        args(2).Value = lcdescob
        args(3) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(3).Value = lcoficina
        args(4) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(4).Value = lcanalista
        args(5) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(5).Value = lclineas
        args(6) = New SqlParameter("@lccajeros", SqlDbType.VarChar)
        args(6).Value = lccajeros
        args(7) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(7).Value = lczona
        args(8) = New SqlParameter("@ctippag", SqlDbType.VarChar)
        args(8).Value = ctippag

        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer
            Dim lnciclo As Integer
            Dim lccodcta As String
            Dim lccodcli As String
            For Each fila In ds.Tables(0).Rows
                lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
                lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
                lnciclo = Me.Ciclo(lccodcli, lccodcta)
                ds.Tables(0).Rows(ele)("nciclo") = lnciclo
                ele += 1
            Next
        End If
        Return ds

    End Function
    Public Function CarteraTrasladada(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String, ByVal lcproducto As String) As DataSet
        Dim strSQL As New StringBuilder

        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append(" SELECT DISTINCT CREMCRE.cCodCta,cremcre.cdescre, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.ntasint, cremcre.ccodana, tabtusu.cnomusu as cnomana, tabtofi.cnomofi, climide.cclaper, climide.ccodofi, cremcre.nciclo,cremcre.csececo, cremcre.ccontra,cremcre.canalisis,k.cnomusu as cnomoto,")
        strSQL.Append("cremcre.dfecvig, cremcre.dfecven, CREMCRE.ncuoapr, CREMCRE.ccodact, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.dnacimi, climide.cteldom, climide.ctelfam, SPACE(6) as categoria,  ")
        strSQL.Append("cremcre.ccodsol, cremsol.cnomgru, cremsol.ccodcen, centros.cnomgru as cnomcen, CREMCRE.coficina, CREMCRE.cnrolin, climide.csexo, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end AS ncappag  ")
        strSQL.Append(" ,cremcre.ctipgar, climide.cnudoci, climide.cnudotr,cremcre.ctipcuo,cremcre.cflat, substring(cretlin.ccodlin,3,2) as ffondos, tabttab.cdescri , cretlin.ccodlin, cremcre.nmoncuo, cretlin.ntasmor ")
        strSQL.Append(" FROM CREMCRE INNER JOIN CRETLIN ON CREMCRE.cnrolin = CRETLIN.cNrolin ")
        strSQL.Append(" INNER JOIN CLIMIDE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI  ")
        strSQL.Append(" INNER JOIN tabtusu ON cremcre.ccodana = tabtusu.ccodusu  ")
        strSQL.Append(" INNER JOIN tabtusu k ON cremcre.canalisis = k.ccodusu  ")
        strSQL.Append(" INNER JOIN CREMSOL ON CREMSOL.ccodsol = CREMCRE.ccodsol  ")
        strSQL.Append(" INNER JOIN CENTROS ON CREMSOL.ccodcen = CENTROS.ccodsol  ")
        strSQL.Append(" INNER JOIN TABTOFI ON CREMCRE.COFICINA = TABTOFI.CCODOFI  ")
        strSQL.Append(" inner join tabttab on substring(cretlin.ccodlin,3,2) = left(tabttab.ccodigo,2) and tabttab.ccodtab ='033' ")

        Dim cadenaactual As String
        Dim cadena As String
        cadenaactual = Me.cnnStr
        cadena = Me.CadenaDatos(dfecha2)

        If cadena.Trim = cadenaactual.Trim Then
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and (cremcre.cestado ='F' or cremcre.cestado='G') ") '
            strSQL.Append(" and case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end  > ")
            strSQL.Append("     case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end      ")

        Else
            strSQL.Append(" WHERE CREMCRE.dfecvig <= @dfecha2   ")
            strSQL.Append(" and cremcre.cestado ='F'  ") '

        End If

        strSQL.Append(" and cremcre.dfectra >= @dfecha1 and cremcre.dfectra <=@dfecha2 ")

        'se filtra solo para creditos cancelados y/o vencimiento
        If cancela = "1" Then
            strSQL.Append("AND CREMCRE.dfecvig >= @dfecha1 ")
            strSQL.Append("AND CREMCRE.cestado = 'G' ")
        Else
            If cancela = "2" Then ' para los vencimientos
                strSQL.Append("AND CREMCRE.dfecven >= @dfecha1 and CREMCRE.dfecven <= @dfecha2 ")
            Else
            End If
        End If

        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(CRETLIN.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If
        If lcproducto <> "*" Then
            strSQL.Append("AND substring(CREMCRE.cCodcta,7,2) = @lcproducto ")
        End If


        'If lccartera <> "*" Then
        '    strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        'Else
        '    If lctipo <> "*" Then
        '        If lctipo = "I" Then
        strSQL.Append("AND CREMCRE.ccondic = 'S' ")
        '        Else
        'strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
        '        End If
        '    End If
        'End If
        strSQL.Append(" ORDER BY cremcre.coficina, cremcre.ccodana, cremcre.ccodcta, cremcre.dfecvig, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString


        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona
        args(7) = New SqlParameter("@lcproducto", SqlDbType.VarChar)
        args(7).Value = lcproducto


        Dim lcestado As String


        Dim ds As New DataSet
        Dim ds1 As New DataSet
        If cadena.Trim = cadenaactual.Trim Then
            ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Else
            ds = ExecuteDataSet(cadena, CommandType.Text, strSQL.ToString(), args, 0)
        End If

        ds1 = Me.ValidaEstado(ds, dfecha2)
        Return ds1
    End Function
    Public Function ListadoCreditosParaContrato(ByVal cCodsol As String, ByVal cestado As String, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select climide.cnomcli, climide.cnudoci, cremcre.nmonapr ")
        strSQL.Append("FROM CLIMIDE, CREMCRE, cretlin ")
        strSQL.Append("WHERE climide.ccodcli = cremcre.ccodcli and cremcre.ccodsol = @cCodsol and cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append("and (cremcre.cestado = @cestado) and (cremcre.cCodrec=' ' or cremcre.ccodrec is null) ")
        strSQL.Append("and cremcre.ccodcta <> @ccodcta order by climide.cnomcli ")


        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.VarChar)
        args(0).Value = cCodsol
        args(1) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(1).Value = cestado
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = ccodcta

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function SelectIncentivos(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim strSQL As New StringBuilder
        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, 0000 as nciclo,substring(cretlin.ccodlin,5,2) as ctipmet,cremcre.ccodana, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.dfecapr, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= @dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= @dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'KP' AND CREDKAR.CDESCOB = 'D' and CREDKAR.CESTADO = ' ' GROUP BY CREDKAR.CCODCTA) end as nCapDes ")
        strSQL.Append(" FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (CREMCRE.cestado = 'F' or CREMCRE.cEstado = 'G') ")
        strSQL.Append(" and  CREMCRE.dfecvig >= @dfecha1 and CREMCRE.dfecvig <= @dfecha2 ")

      
        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(cretlin.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona

        Dim lcestado As String

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Dim fila As DataRow
        Dim ele As Integer = 0

        Dim lnciclo As Integer
        Dim lccodcli As String
        Dim lccodcta As String
        For Each fila In ds.Tables(0).Rows
            lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
            lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
            lnciclo = Me.Ciclo(lccodcli, lccodcta)
            ds.Tables(0).Rows(ele)("nciclo") = lnciclo
            ele += 1
        Next
        Return ds
    End Function
    Public Function SelectIncentivosRecuperacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal cancela As String, ByVal lccartera As String, ByVal lczona As String) As DataSet
        Dim strSQL As New StringBuilder
        Dim lctipo As String
        lctipo = Me.dbtipo
        If IsDBNull(lctipo) Then
            lctipo = "*"
        End If
        If lctipo = Nothing Then
            lctipo = "*"
        End If
        'Nuevo
        strSQL.Append("SELECT DISTINCT CREMCRE.cCodCta, 0000 as nciclo,substring(cretlin.ccodlin,5,2) as ctipmet,cremcre.ccodana, CREMCRE.cEstado,CREMCRE.ccodcli , CREMCRE.cCondic, CREMCRE.dFectra, CREMCRE.dfecapr, ")
        strSQL.Append(" cremcre.dfecvig, cremcre.dfecven, climide.cnomcli, climide.cdirdom, climide.cCoddom, climide.cteldom, SPACE(6) as categoria, ")
        strSQL.Append(" case when (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= @dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'CJ' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' and credkar.ctippag <> 'P' GROUP BY CREDKAR.CCODCTA) is null then 0 else (SELECT SUM(CREDKAR.NMONTO) FROM CREDKAR WHERE CREDKAR.CCODCTA = CREMCRE.CCODCTA  AND credkar.dfecsis >= @dfecha1 and credkar.dfecsis <= @dfecha2 AND CREDKAR.CCONCEP = 'CJ' AND CREDKAR.CDESCOB = 'C' and CREDKAR.CESTADO = ' ' and credkar.ctippag <> 'P' GROUP BY CREDKAR.CCODCTA) end as ncappag ")
        strSQL.Append(" FROM CLIMIDE INNER JOIN CREMCRE ON CLIMIDE.CCODCLI = CREMCRE.CCODCLI ")
        strSQL.Append(" inner join cretlin on cremcre.cnrolin = cretlin.cnrolin ")
        strSQL.Append(" WHERE (CREMCRE.cestado = 'F' or CREMCRE.cEstado = 'G') ")



        If lcanalista <> "*" Then
            strSQL.Append("AND CREMCRE.CCODANA = @lcanalista ")
        End If
        If lcoficina <> "*" Then
            strSQL.Append("AND CREMCRE.coficina = @lcoficina ")
        End If
        If lclineas <> "*" Then
            strSQL.Append("AND substring(cretlin.ccodlin,3,2) = @lclineas ")
        End If
        If lczona <> "*" Then
            strSQL.Append("AND LEFT(CLIMIDE.cCoddom,4)= @lczona")
        End If

        If lccartera <> "*" Then
            strSQL.Append("AND CREMCRE.ccondic = @lccartera ")
        Else
            If lctipo <> "*" Then
                If lctipo = "I" Then
                    strSQL.Append("AND CREMCRE.ccondic = 'S' ")
                Else
                    strSQL.Append("AND CREMCRE.ccondic <> 'S' ")
                End If
            End If
        End If
        strSQL.Append(" ORDER BY CREMCRE.cEstado, CLIMIDE.cNomcli")

        Dim a As String
        a = strSQL.ToString

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@dfecha1", SqlDbType.DateTime)
        args(0).Value = dfecha1
        args(1) = New SqlParameter("@dfecha2", SqlDbType.DateTime)
        args(1).Value = dfecha2
        args(2) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(2).Value = lcoficina
        args(3) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(3).Value = lcanalista
        args(4) = New SqlParameter("@lclineas", SqlDbType.VarChar)
        args(4).Value = lclineas
        args(5) = New SqlParameter("@lccartera", SqlDbType.VarChar)
        args(5).Value = lccartera
        args(6) = New SqlParameter("@lczona", SqlDbType.VarChar)
        args(6).Value = lczona

        Dim lcestado As String

        Dim ds As New DataSet
        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
        Dim fila As DataRow
        Dim ele As Integer = 0

        'Dim lnciclo As Integer
        'Dim lccodcli As String
        'Dim lccodcta As String
        'For Each fila In ds.Tables(0).Rows
        '    lccodcli = ds.Tables(0).Rows(ele)("ccodcli")
        '    lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
        '    lnciclo = Me.Ciclo(lccodcli, lccodcta)
        '    ds.Tables(0).Rows(ele)("nciclo") = lnciclo
        '    ele += 1
        'Next
        Return ds
    End Function


    Public Function ObtenerGastos(ByVal ccodcta As String, ByVal cnrodoc As String) As DataSet

        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim lnIVA As Double = 0
        Dim lnMongas_IVA As Double = 0
        Dim lnMongas As Double = 0

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            command.Connection = connection


            Try

                command.CommandText = _
                                        " Select b.ccodcta, b.ccodcli , a.cnomcli, b.dfecvig, b.dfecven, c.cdeslin, b.ncuoapr," & _
                                        " '' as cctaapor, '' as cctasimul, '' as cctavista, b.cfrecint, b.ncapdes, b.nmonapr, e.cnomusu," & _
                                        " b.nmoncuo, d.ctipgas, f.cdescri, (d.nmongas-d.nmonpag) as nmongas, " & _
                                        " case when (select SUM(nmongra) from crepgar where ccodcta = b.ccodcta) is null then 0 else  " & _
                                        " (select SUM(nmongra) from crepgar where ccodcta = b.ccodcta) end as nmongra " & _
                                        " From climide a" & _
                                        " Inner Join cremcre b" & _
                                        " On a.ccodcli = b.ccodcli " & _
                                        " Inner Join cretlin c" & _
                                        " On b.cnrolin = c.cnrolin" & _
                                        " Inner Join credgas d" & _
                                        " On b.ccodcta = d.ccodcta" & _
                                        " Inner Join tabtusu e" & _
                                        " ON b.ccodana = e.ccodusu" & _
                                        " Inner Join tabttab f" & _
                                        " On d.ctipgas = f.ccodigo" & _
                                        " Where b.ccodcta = '" & ccodcta & "'" & _
                                        " and cdescob ='D' " & _
                                        " and f.ccodtab + f.ctipreg = '0081'"

                'and cnrodoc = '" & cnrodoc & "'" & _
                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Gastos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Finally
                connection.Close()
            End Try

        End Using

        Return ds

    End Function


    Public Function ObtenerLiquidacion_Deudor(ByVal ccodcta As String, ByVal cnrodoc As String) As DataSet

        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim lnIVA As Double = 0
        Dim lnMongas_IVA As Double = 0
        Dim lnMongas As Double = 0

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            command.Connection = connection


            Try

                command.CommandText = _
                                        " Select b.ccodcta, b.ccodcli , a.cnomcli, b.dfecvig, b.dfecven, c.cdeslin, b.ncuoapr, " & _
                                        " b.cctaapor, b.cctasimul, b.cctavista, b.cfrecint, b.ncapdes, b.nmonapr, e.cnomusu, " & _
                                        " b.nmoncuo, '' as ctipgas, '' as cdescri, 0.000 as nmongas, " & _
                                        " case when (select SUM(nmongra) from crepgar where ccodcta = b.ccodcta) is null then 0 else " & _
                                        " (select SUM(nmongra) from crepgar where ccodcta = b.ccodcta) end as nmongra " & _
                                        " From climide a " & _
                                        " Inner Join cremcre b " & _
                                        " On a.ccodcli = b.ccodcli " & _
                                        " Inner Join cretlin c " & _
                                        " On b.cnrolin = c.cnrolin " & _
                                        " Inner Join tabtusu e " & _
                                        " ON b.ccodana = e.ccodusu " & _
                                        " Where b.ccodcta = '" & ccodcta & "'"



                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Gastos")


                command.CommandText = _
                                        " Select b.cnomchq as cnombre, b.nmonto, b.cnrochq, '--' AS cconcepto From Cremcre a" & _
                                        " Inner Join Credchq b " & _
                                        " On a.cCodcta = b.cCodcta " & _
                                        " Where a.ccodcta = '" & ccodcta & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Cheques")


                'Extrae Tipo de Garantía

                command.CommandText = _
                                        " Select a.ccodcta, a.ctipgar, c.cdescri, " & _
                                        " (rtrim(c.cdescri) + ' | ' + b.cdescri) as cdesgarantia From Cremcre a " & _
                                        " inner join Crepgar b " & _
                                        " on a.ccodcta = b.ccodcta " & _
                                        " inner join Tabttab c " & _
                                        " on b.ctipgar = c.ccodigo " & _
                                        " where ccodtab + ctipreg = '0741' and a.ccodcta = '" & ccodcta & "'"



                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Garantias")


                'Generando Desconectado para acumular el IVA
                Dim dr As DataRow
                Dim dat_AdPar As New DataTable("Gastos_Fin")
                dat_AdPar.Clear()
                'Agregando la Encabezado de la Factura

                dat_AdPar.Columns.Add("cTipgas", Type.GetType("System.String"))
                dat_AdPar.Columns.Add("cDescri", Type.GetType("System.String"))
                dat_AdPar.Columns.Add("nMongas", Type.GetType("System.Decimal"))

                ds.Tables.Add(dat_AdPar)



                'For Each fila As DataRow In ds.Tables("Gastos").Rows

                '    'Si el gasto contiene IVA lo Acumulara
                '    If fila("ctipgas").ToString.Trim = "30" Then
                '        lnMongas = Math.Round(fila("nMongas") / GNIVA, 2)
                '        lnMongas_IVA = lnMongas_IVA + fila("nMongas")
                '    Else
                '        lnMongas = fila("nMongas")
                '    End If

                '    dr = ds.Tables("Gastos_Fin").NewRow
                '    dr("cTipgas") = fila("ctipgas")
                '    dr("cDescri") = fila("cDescri")
                '    dr("nMongas") = lnMongas

                '    ds.Tables("Gastos_Fin").Rows.Add(dr)
                'Next

                'If lnMongas_IVA > 0 Then
                '    lnMongas_IVA = lnMongas_IVA - Math.Round(lnMongas_IVA / GNIVA, 2)

                '    dr = ds.Tables("Gastos_Fin").NewRow
                '    dr("cTipgas") = "IV"
                '    dr("cDescri") = "IVA Comisiones"
                '    dr("nMongas") = lnMongas_IVA

                '    ds.Tables("Gastos_Fin").Rows.Add(dr)
                'End If


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Finally
                connection.Close()
            End Try

        End Using

        Return ds

    End Function

    Public Function ObtenerLiquidacion(ByVal ccodcta As String, ByVal cnrodoc As String, _
                                       ByVal GNIVA As Double) As DataSet

        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim lnIVA As Double = 0
        Dim lnMongas_IVA As Double = 0
        Dim lnMongas As Double = 0

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            command.Connection = connection


            Try

                command.CommandText = _
                                        " Select b.ccodcta, b.ccodcli , a.cnomcli, b.dfecvig, b.dfecven, c.cdeslin, b.ncuoapr," & _
                                        " '' as cctaapor, '' as cctasimul, '' as cctavista, b.cfrecint, b.ncapdes, b.nmonapr, e.cnomusu," & _
                                        " b.nmoncuo, d.ctipgas, f.cdescri, (d.nmongas-d.nmonpag) as nmongas, " & _
                                        " case when (select SUM(nmongra) from crepgar where ccodcta = b.ccodcta) is null then 0 else  " & _
                                        " (select SUM(nmongra) from crepgar where ccodcta = b.ccodcta) end as nmongra " & _
                                        " From climide a" & _
                                        " Inner Join cremcre b" & _
                                        " On a.ccodcli = b.ccodcli " & _
                                        " Inner Join cretlin c" & _
                                        " On b.cnrolin = c.cnrolin" & _
                                        " Inner Join credgas d" & _
                                        " On b.ccodcta = d.ccodcta" & _
                                        " Inner Join tabtusu e" & _
                                        " ON b.ccodana = e.ccodusu" & _
                                        " Inner Join tabttab f" & _
                                        " On d.ctipgas = f.ccodigo" & _
                                        " Where b.ccodcta = '" & ccodcta & "'" & _
                                        " and cdescob ='D' and cnrocuo = '" & cnrodoc & "'" & _
                                        " and f.ccodtab + f.ctipreg = '0081'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Gastos")


                command.CommandText = _
                                        " Select ISNULL(b.cnomchq, '') as cnombre, ISNULL(b.nmonto,0) AS nmonto, isnull(b.cnrochq,'') as cnrochq, '--' AS cconcepto From Cremcre a" & _
                                        " Inner Join Credchq b " & _
                                        " On a.cCodcta = b.cCodcta " & _
                                        " Where a.ccodcta = '" & ccodcta & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Cheques")


                'Extrae Tipo de Garantía
                command.CommandText = _
                                        " Select a.ccodcta, a.ctipgar, c.cdescri, " & _
                                        " (rtrim(c.cdescri)) as cdesgarantia From Cremcre a " & _
                                        " inner join Crepgar b " & _
                                        " on a.ccodcta = b.ccodcta " & _
                                        " inner join Tabttab c " & _
                                        " on b.ctipgar = c.ccodigo " & _
                                        " where ccodtab + ctipreg = '0741' and a.ccodcta = '" & ccodcta & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Garantias")


                'Generando Desconectado para acumular el IVA
                Dim dr As DataRow
                Dim dat_AdPar As New DataTable("Gastos_Fin")
                dat_AdPar.Clear()
                'Agregando la Encabezado de la Factura

                dat_AdPar.Columns.Add("cTipgas", Type.GetType("System.String"))
                dat_AdPar.Columns.Add("cDescri", Type.GetType("System.String"))
                dat_AdPar.Columns.Add("nMongas", Type.GetType("System.Decimal"))

                ds.Tables.Add(dat_AdPar)



                For Each fila As DataRow In ds.Tables("Gastos").Rows

                    'Si el gasto contiene IVA lo Acumulara
                    If fila("ctipgas").ToString.Trim = "01" Then
                        lnMongas = Math.Round(fila("nMongas") / GNIVA, 2)
                        lnMongas_IVA = lnMongas_IVA + fila("nMongas")
                    Else
                        lnMongas = fila("nMongas")
                    End If

                    dr = ds.Tables("Gastos_Fin").NewRow
                    dr("cTipgas") = fila("ctipgas")
                    dr("cDescri") = fila("cDescri")
                    dr("nMongas") = lnMongas

                    ds.Tables("Gastos_Fin").Rows.Add(dr)
                Next

                If lnMongas_IVA > 0 Then
                    lnMongas_IVA = lnMongas_IVA - Math.Round(lnMongas_IVA / GNIVA, 2)

                    dr = ds.Tables("Gastos_Fin").NewRow
                    dr("cTipgas") = "IV"
                    dr("cDescri") = "IVA Comisiones"
                    dr("nMongas") = lnMongas_IVA

                    ds.Tables("Gastos_Fin").Rows.Add(dr)
                End If


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
            Finally
                connection.Close()
            End Try

        End Using

        Return ds

    End Function


    Public Function Obtenerbusquedacreditos(ByVal cnombre As String, ByVal cestado As String, ByVal ctipo As String, ByVal cbusq As String, ByVal cmetodologia As String, ByVal cflag As String, ByVal cCodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cremcre.ccodcta as codigo, climide.cnomcli, cremcre.ncapdes,(cremcre.ncapdes-cremcre.ncappag) as nsalcap,cremcre.dfecvig,cremcre.cestado, cremcre.ccodrec, climide.cnudoci, climide.foto  ")
        strSQL.Append(" FROM cremcre, climide, cretlin, tabtusu")
        strSQL.Append(" WHERE cremcre.ccodcli = climide.ccodcli and cremcre.cnrolin = cretlin.cnrolin and cremcre.ccodana = tabtusu.ccodusu ")
        strSQL.Append(" and climide.ccodcli = @ccodcli")


        If cbusq = "1" Then
            strSQL.Append(" and CREMCRE.cestado ='F' ")
        ElseIf cbusq = "2" Then
            strSQL.Append(" and CREMCRE.cestado ='G' ")
        ElseIf cbusq = "3" Then
            strSQL.Append(" and CREMCRE.cestado ='A' ")
        ElseIf cbusq = "4" Then 'en la sugerencia
            strSQL.Append(" and (CREMCRE.cestado ='C' or CREMCRE.cestado ='A') and  CREMCRE.ccodrec = ' ' ")
        ElseIf cbusq = "5" Then 'en la aprobacion
            strSQL.Append(" and (CREMCRE.cestado ='E' or CREMCRE.cestado ='C') and  CREMCRE.ccodrec = ' ' ")
        ElseIf cbusq = "6" Then ' en el desembolso
            strSQL.Append(" and (CREMCRE.cestado ='E' ) and  CREMCRE.ccodrec = ' ' ")
        ElseIf cbusq = "7" Then
            strSQL.Append(" and CREMCRE.ccodrec <> ' ' ")
        ElseIf cbusq = "8" Then
            strSQL.Append(" and (CREMCRE.cestado ='E' or cremcre.cestado ='F') and  CREMCRE.ccodrec = ' ' ")
        Else

        End If
        If cflag = "00" Then
        Else
        End If
        If cCodofi = "001" Then
        Else
            'strSQL.Append(" and cremcre.coficina = @cCodofi ")
        End If


        strSQL.Append(" order by cremcre.dfecvig desc  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.VarChar)
        args(0).Value = cCodofi

        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = cnombre

        'args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        'args(1).Value = cOficina
        'If nNivel < 9 Then
        '    strSQL.Append(" and  substring(CREMCRE.cCodCta,4,3) = @cOficina ")
        'End If

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    Public Function Extrae_Datos_Grupo(ByVal ccodigo As String) As DataSet

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
                                        " Select b.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci, b.nmonapr, SUM(d.nintere+d.ngastos) as ninteres " & _
                                        " FROM Climide a " & _
                                        " Inner Join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " Inner Join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credtpl d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " WHERE b.ccodsol = '" & ccodigo & "'" & _
                                        " and b.cestado = 'E' " & _
                                        " and (b.cCodrec=' ' or b.ccodrec is null) " & _
                                        " and d.ctipope = 'N' " & _
                                        " group by  b. nmonapr, b.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci " & _
                                        " Order by a.cnomcli "


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


    Public Function Extrae_Datos_Grupo_Vigente(ByVal ccodigo As String) As DataSet

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
                                        " Select b.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci, b.nmonapr, SUM(d.nintere+d.ngastos) as ninteres " & _
                                        " FROM Climide a " & _
                                        " Inner Join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " Inner Join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join credtpl d " & _
                                        " on b.ccodcta = d.ccodcta " & _
                                        " WHERE b.ccodsol = '" & ccodigo & "'" & _
                                        " and b.cestado = 'F' " & _
                                        " and (b.cCodrec=' ' or b.ccodrec is null) " & _
                                        " and d.ctipope = 'N' " & _
                                        " group by  b. nmonapr, b.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci " & _
                                        " Order by a.cnomcli "


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


    Public Function Extrae_Datos_Grupo_Sugerido_Aprobado(ByVal ccodigo As String) As DataSet

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
                                        " Select b.ccodcli, b.ccodcta, a.cnomcli, a.cnudoci, b.nmonsug as nmonapr  " & _
                                        " FROM Climide a " & _
                                        " Inner Join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " Inner Join cretlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " WHERE b.ccodsol = '" & ccodigo & "'" & _
                                        " and b.cestado IN('C','E') " & _
                                        " and (b.cCodrec=' ' or b.ccodrec is null) " & _
                                        " Order by a.cnomcli "


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


    Public Function Creditosrangodias_Individual(ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.cCodcta, cremcre.ccodcli, climide.cnomcli, climide.cdirdom, climide.cteldom, case when climide.cteldom is null then '' else climide.cteldom  end as cteldom, case when climide.ctelfam  is null then '' else climide.ctelfam  end as ctelfam , cremcre.ndiaatr, cremcre.cestado, ")
        strSQL.Append("0000000.00 as nsalcap, 0000000.00 as nsalint, 0000000.00 as nsalmor, 0000000.00 as nmorcap, ")
        strSQL.Append("0000000.00 as nsegdeu, 0000000.00 as nmanejo, 0000000.00 as naporta, 0000000.00 as ncostas, ")
        strSQL.Append("0000000.00 as nanotacion, 0000000.00 as ndeudores, 0000000.00 as ndepurada, 0000000.00 as nsegvid, 0000000.00 as nhaberes, cremsol.cnomgru,")
        strSQL.Append("ndia= (select DAY(credppg.dfecven) from credppg where cremcre.ccodcta = credppg.ccodcta and cnrocuo ='001' and ctipope ='N') ")
        strSQL.Append("FROM CREMCRE, CLIMIDE, CREMSOL ")
        strSQL.Append("WHERE cremcre.ccodcli = climide.ccodcli and cremcre.ndiaatr >= @ndesde and cremcre.ndiaatr <= @nhasta and cremcre.ccodsol = cremsol.ccodsol ")
        strSQL.Append("and cremcre.cestado = 'F' and cremcre.ccodcta = @ccodcta order by climide.cnomcli ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ndesde", SqlDbType.Int)
        args(0).Value = ndesde
        args(1) = New SqlParameter("@nhasta", SqlDbType.Int)
        args(1).Value = nhasta
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = ccodcta

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function Creditosrangodias(ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodana As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cremcre.cCodcta, cremcre.ccodcli, climide.cnomcli, climide.cdirdom, climide.cteldom, case when climide.cteldom is null then '' else climide.cteldom  end as cteldom, case when climide.ctelfam  is null then '' else climide.ctelfam  end as ctelfam , cremcre.ndiaatr, cremcre.cestado, ")
        strSQL.Append("0000000.00 as nsalcap, 0000000.00 as nsalint, 0000000.00 as nsalmor, 0000000.00 as nmorcap, ")
        strSQL.Append("0000000.00 as nsegdeu, 0000000.00 as nmanejo, 0000000.00 as naporta, 0000000.00 as ncostas, ")
        strSQL.Append("0000000.00 as nanotacion, 0000000.00 as ndeudores, 0000000.00 as ndepurada, 0000000.00 as nsegvid, 0000000.00 as nhaberes, cremsol.cnomgru, ")
        strSQL.Append("ndia= (select DAY(credppg.dfecven) from credppg where cremcre.ccodcta = credppg.ccodcta and cnrocuo ='001' and ctipope ='N') ")
        strSQL.Append("FROM CREMCRE, CLIMIDE, CREMSOL ")
        strSQL.Append("WHERE cremcre.ccodcli = climide.ccodcli and cremcre.ndiaatr >= @ndesde and cremcre.ndiaatr <= @nhasta and cremcre.ccodsol = cremsol.ccodsol ")
        strSQL.Append("and cremcre.cestado = 'F' and cremcre.ccodana = @ccodana order by climide.cnomcli ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ndesde", SqlDbType.Int)
        args(0).Value = ndesde
        args(1) = New SqlParameter("@nhasta", SqlDbType.Int)
        args(1).Value = nhasta
        args(2) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(2).Value = ccodana

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    Public Function ListaCarteraxAnalista(ByVal cCodana As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append("SELECT cli.ccodcli as socio, cre.ccodcta as credito, cre.nmoncuo as cuota, cre.dfecvig as vigencia, ")
        strSQL.Append("cre.ncapdes as desembols, cre.ncapdes - cre.ncappag as saldo_cap, cre.ndiaatr as atraso, ")
        strSQL.Append("cli.cnomcli as nombre, cli.cdirdom as direccion, ")
        strSQL.Append("cli.cpagadu as trabajo, cli.cdirfue as dir_trab, cli.cteltralab as tel_trab, ccodcon as celular, ")
        strSQL.Append("cli.cteldom as tel_casa, cli.cnomcon as conyuge, cli.cteltray as trabaja, cli.ctelcon as tel_traba ")
        strSQL.Append("FROM CREMCRE as cre, CLIMIDE as cli ")
        strSQL.Append("WHERE cre.ccodana = @ccodana AND cre.cestado = 'F' AND cre.ccodcli = cli.ccodcli ")
        strSQL.Append("order by cli.cnomcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodana", SqlDbType.VarChar)
        args(0).Value = cCodana

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    'Funcion para obtener el capital de producto  por parametros como: 
    Public Function capital_producto(ByVal idasesor As String, ByVal idproducto As String, ByVal lfecha1 As DateTime, ByVal lfecha2 As DateTime) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append(" Select isnull(sum(nmonto),0) as total_colocado from cremcre a inner join credkar b on a.ccodcta = b.ccodcta where a.cestado in ('F','G')  and ")
        strSQL.Append("b.cconcep = 'CJ' and b.cestado <> 'X' and b.cdescob = 'D' and dfecsis >= @DFECHA1 and dfecsis <= @DFECHA2")
        strSQL.Append(" and a.ccodana = @lcanalista and a.cnrolin=@idproducto")
        'Parametros por buscar
        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
        args(0).Value = idasesor
        args(1) = New SqlParameter("@idproducto", SqlDbType.VarChar)
        args(1).Value = idproducto
        args(2) = New SqlParameter("@DFECHA1", SqlDbType.DateTime)
        args(2).Value = lfecha1
        args(3) = New SqlParameter("@DFECHA2", SqlDbType.DateTime)
        args(3).Value = lfecha2
        Dim DataCapital As New DataSet

        Try
            DataCapital = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception

            Throw ex
        End Try
        'Creacion de un datatable
        Dim tempDs_Capital As DataTable = DataCapital.Tables(0).Copy
        Dim capital As Double
        For Each rowcapital As DataRow In tempDs_Capital.Rows
            capital = rowcapital("total_colocado")
        Next
        Return capital

    End Function


    '-- =============================================
    '-- Author:         <FERNANDO ABREGO RDZ>
    '-- Create date: <2/26/2015>
    '-- Description:  <Comportamiento_Productos>
    '-- Eventos:        <ninguno>
    '-- Fuciones:      <Compartamiento_Productos>
    '-- Procesos:      <ninguno>
    '-- =============================================
    Public Function Buscar_Oficinas(ByVal lcoficina As String) As DataSet

        Dim strSQL As New StringBuilder
        'Busca las sucursales formando una lista de ellos o de el
        strSQL.Append("SELECT ccodofi ,cnomofi FROM tabtofi where ccodofi <> '' ")

        If lcoficina <> "*" Then

            strSQL.Append(" and tabtofi.ccodofi = @lcoficina") 'if buscar la sucursal

        End If

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
        args(0).Value = lcoficina

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception

            Throw ex


        End Try

        Return ds


    End Function
    'Consulta de Analista y por sucursales y formacion de Dataset
    '-- =============================================
    '-- Author:         <FERNANDO ABREGO RDZ> <CESAR TORRES>
    '-- Create date: <17/2/2015>
    '-- Description:  <Comportamiento_Productos>
    '-- Eventos:        <ninguno>
    '-- Fuciones:      <Consulta_analistaSuc -->   >
    '-- Procesos:      <ninguno>
    '-- NOTA IMPORTANTE:
    'Esta funcion utiliza fucniones internas para realizar el llenado del dataset y asi enviarlo a que calcule la mora
    'Funciones: 
    'Busca_Creditos,capital_producto
    ' totalcredito = Busca_Creditos(idasesor, idproducto, lfecha1, lfecha2)
    ' totalcapital = capital_producto(idasesor, idproducto, lfecha1, lfecha2)
    '-- =============================================

    Public Function Consulta_analistaSuc(ByVal dsbaseSucu As DataSet, ByVal dataset_productos As DataSet, ByVal lfecha1 As DateTime, ByVal lfecha2 As DateTime, ByVal lcanalista As String) As DataSet
        'Creacion de datatable temporal para dataset de sucursal
        Dim tempDataset As DataTable = dsbaseSucu.Tables(0).Copy
        'Recibe el numero de ofician en la lista 
        Dim parametro As String
        'creacion de un datatset 
        Dim ds As New DataSet
        'Variable que almacena el valor de Busca_Creditos
        Dim totalcredito As Integer = 0
        'Almacena el capital de producto
        Dim totalcapital As Double
        'almacena nombre sucursales
        Dim nombre_sucursal As String
        'Almacena asesores 
        Dim asesores_nombres As String
        'Almacena el valor de rowProducto_x_Ase
        Dim nombre_producto As String
        'Datatable para crear columnas y alamcenar valores y ai ser capoturado por un dataset
        Dim ConjuntoDatos As New DataTable
        ConjuntoDatos.Columns.Add("Id_Sucursal")
        ConjuntoDatos.Columns.Add("Sucursales")
        ConjuntoDatos.Columns.Add("id_Asesor")
        ConjuntoDatos.Columns.Add("Asesores")
        ConjuntoDatos.Columns.Add("idproducto")
        ConjuntoDatos.Columns.Add("Producto")
        ConjuntoDatos.Columns.Add("Creditos")
        ConjuntoDatos.Columns.Add("Capital_Desembolsado")
        ConjuntoDatos.Columns.Add("mora")
        'lectura de datos por cada filtro, sucursales, asesor, productos credistos 
        For Each row As DataRow In tempDataset.Rows 'Lectura de dataset
            'primera parte Realzia consultas por Codigo de oficina y analista
            parametro = ""
            nombre_sucursal = ""
            parametro = row("ccodofi")
            nombre_sucursal = row("cnomofi")
            Dim strSQL As New StringBuilder
            strSQL.Append("SELECT ccodusu,cnomusu FROM tabtusu  WHERE ccodofi = @lcoficina")

            If lcanalista <> "*" Then
                strSQL.Append(" AND ccodusu = @lcanalista")
            End If

            Dim args(1) As SqlParameter
            args(0) = New SqlParameter("@lcoficina", SqlDbType.VarChar)
            args(0).Value = parametro
            args(1) = New SqlParameter("@lcanalista", SqlDbType.VarChar)
            args(1).Value = lcanalista
            'fin de esta parte 
            'ALmacena en dataset = ds
            Try
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
                'Creacion de una datatble temproal para el dataset
                Dim tempDs_Asesores As DataTable = ds.Tables(0).Copy
                'Realizamos un For Each para leer el datatable
                For Each datos_asesores As DataRow In tempDs_Asesores.Rows
                    'Declaracion de variables para almacenar 
                    Dim idasesor As String
                    idasesor = ""
                    asesores_nombres = ""
                    idasesor = datos_asesores("ccodusu")
                    asesores_nombres = datos_asesores("cnomusu")
                    'creacion de datatble temproal para dataset de productos 
                    Dim tempDs_Porductos As DataTable = dataset_productos.Tables(0).Copy
                    Dim idproducto As String
                    'For each para la lectura de datatable de productos
                    For Each rowProducto_x_Ase As DataRow In tempDs_Porductos.Rows
                        idproducto = rowProducto_x_Ase("cnrolin")
                        nombre_producto = rowProducto_x_Ase("cdeslin")
                        'funciones para la obtencion del creditos
                        totalcredito = Busca_Creditos(idasesor, idproducto, lfecha1, lfecha2)
                        'Funcion para la obtencion de capital del producto
                        totalcapital = capital_producto(idasesor, idproducto, lfecha1, lfecha2)
                        'Almacenamiento de valores por cada ronda del ciclo
                        Dim newrRow As DataRow = ConjuntoDatos.NewRow
                        newrRow("Id_Sucursal") = parametro
                        newrRow("Sucursales") = nombre_sucursal
                        newrRow("id_Asesor") = idasesor
                        newrRow("Asesores") = asesores_nombres
                        newrRow("idproducto") = idproducto
                        newrRow("Producto") = nombre_producto
                        newrRow("Creditos") = totalcredito
                        newrRow("Capital_Desembolsado") = totalcapital
                        newrRow("mora") = 0
                        'Almacenamiento de los resultados
                        ConjuntoDatos.Rows.Add(newrRow)

                    Next
                Next
            Catch ex As Exception
                Throw ex
            End Try
        Next
        'Creamos un nuevo dtaast donde almacenaremos los valores de la variable =ConjuntoDatos
        Dim DsConjunto_Datos As New DataSet
        DsConjunto_Datos.Tables.Add(ConjuntoDatos)
        Return DsConjunto_Datos

    End Function
    'Realziacion para la busqueda de creditos
    Public Function Busca_Creditos(ByVal idasesor As String, ByVal idproducto As String, ByVal lfecha1 As DateTime, ByVal lfecha2 As DateTime) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(count(*),0) AS TOTAL FROM cremcre where ccodana=@idasesosr and cnrolin=@idproducto and dfecvig >= @lfecha1 and dfecvig <= @lfecha2 and cestado in ('F' , 'G')")

        'parametrios a consultar
        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@idasesosr", SqlDbType.VarChar)
        args(0).Value = idasesor
        args(1) = New SqlParameter("@idproducto", SqlDbType.VarChar)
        args(1).Value = idproducto
        args(2) = New SqlParameter("@lfecha1", SqlDbType.DateTime)
        args(2).Value = lfecha1
        args(3) = New SqlParameter("@lfecha2", SqlDbType.DateTime)
        args(3).Value = lfecha2

        Dim Data_Porducto_xAsosor As New DataSet
        Try
            Data_Porducto_xAsosor = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception

            Throw ex
        End Try

        Dim tempDs_Porductos As DataTable = Data_Porducto_xAsosor.Tables(0).Copy
        Dim TOTAL As Integer
        For Each rowtotal As DataRow In tempDs_Porductos.Rows
            TOTAL = rowtotal("TOTAL")
        Next
        Return TOTAL

    End Function

    'Funcion para la busqeda de productos
    Public Function Productos_Search()
        Dim strSQL As New StringBuilder
        'Select obtiene las sucursales
        strSQL.Append("select cdeslin,cnrolin  from cretlin where cnrolin ='0002000' or cnrolin ='0000600'or cnrolin ='0001300' or cnrolin ='0001400' ")
        strSQL.Append("or cnrolin ='0001500' or cnrolin ='0001600' or cnrolin ='0001700' ")
        strSQL.Append("or cnrolin ='0001800' or cnrolin ='0001900' or cnrolin ='0000900'")
        'creacion del datset
        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception

            Throw ex

        End Try

        Return ds
    End Function

    '-- =============================================
    '-- Author:         <FERNANDO ABREGO RDZ> <CESAR TORRES>
    '-- Create date: <17/2/2015>
    '-- Description:  <Consulta de clientes- por estado f and g  >
    '-- Eventos:        <ninguno>
    '-- Fuciones:      <Consulta_analistaSuc -->   >
    '-- Procesos:      <ninguno>
    '-- NOTA IMPORTANTE:
    '-- =============================================
    Public Function Buscar_clientes(ByVal lfecha2 As DateTime, ByVal lfecha1 As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT replace(climide.cnomcli,'Ñ','N') from climide inner join cremcre on climide.ccodcli=cremcre.ccodcli  where  cestado ='F' OR cestado='G' ")
        strSQL.Append("and dfecvig=@DFECHA1 and dfecvig <= @DFECHA2 ")
        'array para parametros
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@DFECHA1", SqlDbType.DateTime)
        args(0).Value = lfecha1
        args(1) = New SqlParameter("@DFECHA2", SqlDbType.DateTime)
        args(1).Value = lfecha2

        Dim Datos_Calientes As DataSet

        Try
            Datos_Calientes = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception

            Throw ex
        End Try
        Return Datos_Calientes

    End Function

    Public Function Rpt_Dolares_Desembolso_inusuales(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Dim periodo_De_reporte As String
        Dim fecha3Valoracion As DateTime = ldfecha2
        Dim strSQL2 As New StringBuilder
        Dim strSQL3 As New StringBuilder

        Dim mes As Integer
        'Dim dias_restados As Integer
        mes = Month(ldfecha2)
        Dim fechainicio As DateTime = ldfecha1
        Dim fecha_si_cero As DateTime
        Select Case mes
            Case 1 To 3
                fecha_si_cero = New DateTime(DateTime.Now.Year, 1, 1) 'utilizada si el valor del dolar es cero tomar el ultimo
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 4 To 6
                fecha_si_cero = New DateTime(DateTime.Now.Year, 4, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 7 To 9
                fecha_si_cero = New DateTime(DateTime.Now.Year, 7, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 10 To 12
                fecha_si_cero = New DateTime(DateTime.Now.Year, 10, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
        End Select
        Dim strSQL As New StringBuilder
        strSQL.Append("select TOP(1)Valor_Dolar*Factor_Monto as Valoracion_Dolares FROM Valoracion_Year where Ano_Valorado >= @DFECHA4 and Ano_Valorado <= @DFECHA3")
        strSQL.Append(" ORDER BY Ano_Valorado DESC")
        'array para parametros
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@DFECHA4", SqlDbType.DateTime)
        args(0).Value = fechainicio
        args(1) = New SqlParameter("@DFECHA3", SqlDbType.DateTime)
        args(1).Value = fecha3Valoracion


        Dim Dato_valoracion As DataSet

        Dim valoracion_monto As Double
        Dato_valoracion = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim tempDataset As DataTable = Dato_valoracion.Tables(0).Copy

        For Each rowsDa As DataRow In tempDataset.Rows
            valoracion_monto = rowsDa("Valoracion_Dolares")
        Next
        valoracion_monto = valoracion_monto
        'Funcion DATASET_DL utiliza los datos como filtros para la elaboracion de la consulta del reporte
        'Rpt_Desembolso_inusuales(valoracion_monto, fechainicio, fecha3Valoracion)

        Dim var2monto As Double = valoracion_monto

        If var2monto = 0.0 Then
            strSQL3.Append("select TOP(1)Valor_Dolar*Factor_Monto as Valoracion_Dolares FROM Valoracion_Year where Ano_Valorado >= @DFECHA4 and Ano_Valorado <= @DFECHA3")
            strSQL3.Append(" ORDER BY Ano_Valorado DESC")
            'array para parametros
            Dim args3(1) As SqlParameter
            args3(0) = New SqlParameter("@DFECHA4", SqlDbType.DateTime)
            args3(0).Value = fecha_si_cero
            args3(1) = New SqlParameter("@DFECHA3", SqlDbType.DateTime)
            args3(1).Value = fecha3Valoracion


            Dim Dato_valoracion3 As DataSet


            Dato_valoracion3 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args3)

            Dim tempDataset3 As DataTable = Dato_valoracion3.Tables(0).Copy

            For Each rowsDa3 As DataRow In tempDataset3.Rows
                var2monto = rowsDa3("Valoracion_Dolares")
            Next

            var2monto = var2monto

        End If


        strSQL2.Append("select tabtofi.cnomofi, climide.cnomcli,credkar.nmonto,credkar.dfecmod ")
        strSQL2.Append("from credkar,cremcre,climide,tabtofi where credkar.ccodcta=cremcre.ccodcta ")
        strSQL2.Append("and climide.ccodcli=cremcre.ccodcli and tabtofi.ccodofi=cremcre.cCodofi ")
        strSQL2.Append("and cdescob='D' and credkar.nmonto >=@Valoracion_monto and credkar.dfecmod >=@DFECHA1 and credkar.dfecmod <=@DFECHA2")

        Dim args2(2) As SqlParameter
        args2(0) = New SqlParameter("@DFECHA1", SqlDbType.DateTime)
        args2(0).Value = fechainicio
        args2(1) = New SqlParameter("@DFECHA2", SqlDbType.DateTime)
        args2(1).Value = ldfecha2
        args2(2) = New SqlParameter("@Valoracion_monto", SqlDbType.Float)
        args2(2).Value = var2monto

        Dim Rpt_Desembolso_Inusuales_dataset As DataSet

        Try
            Rpt_Desembolso_Inusuales_dataset = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL2.ToString(), args2)
        Catch ex As Exception
            Throw ex
        End Try

        Dim TemRptDesembolsos_inusuales As DataTable = Rpt_Desembolso_Inusuales_dataset.Tables(0).Copy

        Dim newCustomersRow As DataRow = TemRptDesembolsos_inusuales.NewRow()

        newCustomersRow("cnomofi") = periodo_De_reporte

        TemRptDesembolsos_inusuales.Rows.Add(newCustomersRow)

        TemRptDesembolsos_inusuales.Columns("cnomofi").ColumnName = "Sucursal"
        TemRptDesembolsos_inusuales.Columns("cnomcli").ColumnName = "Nombre Cliente"
        TemRptDesembolsos_inusuales.Columns("nmonto").ColumnName = "Monto"
        TemRptDesembolsos_inusuales.Columns("dfecmod").ColumnName = "Fecha de Operacion"

        Return TemRptDesembolsos_inusuales


    End Function

    Public Function Rpt_Pago_Cuotas_inusuales(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Dim periodo_De_reporte As String
        Dim fecha3Valoracion As DateTime = ldfecha2
        Dim strSQL2 As New StringBuilder
        Dim strSQL3 As New StringBuilder
        Dim mes As Integer
        'Dim dias_restados As Integer
        mes = Month(ldfecha2)
        Dim fechainicio As DateTime = ldfecha1
        Dim fecha_si_cero As DateTime
        Select Case mes
            Case 1 To 3
                fecha_si_cero = New DateTime(DateTime.Now.Year, 1, 1) 'utilizada si el valor del dolar es cero tomar el ultimo
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 4 To 6
                fecha_si_cero = New DateTime(DateTime.Now.Year, 4, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 7 To 9
                fecha_si_cero = New DateTime(DateTime.Now.Year, 7, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 10 To 12
                fecha_si_cero = New DateTime(DateTime.Now.Year, 10, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
        End Select
        Dim strSQL As New StringBuilder
        strSQL.Append("select TOP(1)Valor_Dolar*Factor_Monto as Valoracion_Dolares FROM Valoracion_Year where Ano_Valorado >= @DFECHA4 and Ano_Valorado <= @DFECHA3")
        strSQL.Append(" ORDER BY Ano_Valorado DESC")
        'array para parametros
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@DFECHA4", SqlDbType.DateTime)
        args(0).Value = fechainicio
        args(1) = New SqlParameter("@DFECHA3", SqlDbType.DateTime)
        args(1).Value = fecha3Valoracion


        Dim Dato_valoracion As DataSet

        Dim valoracion_monto As Double
        Dato_valoracion = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim tempDataset As DataTable = Dato_valoracion.Tables(0).Copy

        For Each rowsDa As DataRow In tempDataset.Rows
            valoracion_monto = rowsDa("Valoracion_Dolares")
        Next
        valoracion_monto = valoracion_monto
        'Funcion DATASET_DL utiliza los datos como filtros para la elaboracion de la consulta del reporte
        'Rpt_Desembolso_inusuales(valoracion_monto, fechainicio, fecha3Valoracion)

        Dim var2monto As Double = valoracion_monto

        If var2monto = 0.0 Then
            strSQL3.Append("select TOP(1)Valor_Dolar*Factor_Monto as Valoracion_Dolares FROM Valoracion_Year where Ano_Valorado >= @DFECHA4 and Ano_Valorado <= @DFECHA3")
            strSQL3.Append(" ORDER BY Ano_Valorado DESC")
            'array para parametros
            Dim args3(1) As SqlParameter
            args3(0) = New SqlParameter("@DFECHA4", SqlDbType.DateTime)
            args3(0).Value = fecha_si_cero
            args3(1) = New SqlParameter("@DFECHA3", SqlDbType.DateTime)
            args3(1).Value = fecha3Valoracion


            Dim Dato_valoracion3 As DataSet


            Dato_valoracion3 = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args3)

            Dim tempDataset3 As DataTable = Dato_valoracion3.Tables(0).Copy

            For Each rowsDa3 As DataRow In tempDataset3.Rows
                var2monto = rowsDa3("Valoracion_Dolares")
            Next

            var2monto = var2monto

        End If

        strSQL2.Append("select tabtofi.cnomofi, climide.cnomcli,credkar.nmonto,credkar.dfecmod ")
        strSQL2.Append("from credkar,cremcre,climide,tabtofi where credkar.ccodcta=cremcre.ccodcta ")
        strSQL2.Append("and climide.ccodcli=cremcre.ccodcli and tabtofi.ccodofi=cremcre.cCodofi ")
        strSQL2.Append("and cdescob='C' and credkar.nmonto >=@Valoracion_monto and credkar.dfecmod >=@DFECHA1 and credkar.dfecmod <=@DFECHA2")

        Dim args2(2) As SqlParameter
        args2(0) = New SqlParameter("@DFECHA1", SqlDbType.DateTime)
        args2(0).Value = fechainicio
        args2(1) = New SqlParameter("@DFECHA2", SqlDbType.DateTime)
        args2(1).Value = ldfecha2
        args2(2) = New SqlParameter("@Valoracion_monto", SqlDbType.Float)
        args2(2).Value = var2monto

        Dim RdbPagos_Cuotas_Inusuales_dataset As DataSet

        Try
            RdbPagos_Cuotas_Inusuales_dataset = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL2.ToString(), args2)
        Catch ex As Exception
            Throw ex
        End Try

        Dim TemRptPagos_inusuales As DataTable = RdbPagos_Cuotas_Inusuales_dataset.Tables(0).Copy

        Dim newCustomersRow As DataRow = TemRptPagos_inusuales.NewRow()

        newCustomersRow("cnomofi") = periodo_De_reporte

        TemRptPagos_inusuales.Rows.Add(newCustomersRow)

        TemRptPagos_inusuales.Columns("cnomofi").ColumnName = "Sucursal"
        TemRptPagos_inusuales.Columns("cnomcli").ColumnName = "Nombre Cliente"
        TemRptPagos_inusuales.Columns("nmonto").ColumnName = "Monto"
        TemRptPagos_inusuales.Columns("dfecmod").ColumnName = "Fecha de Operacion"

        Return TemRptPagos_inusuales


    End Function

    Public Function Rpt_Desembolso(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable
        Dim strSQL As New StringBuilder
        strSQL.Append("select tabtofi.cnomofi,SUM(nmonto) as Total_Desembolsado ")
        strSQL.Append("from credkar,cremcre,tabtofi where credkar.ccodcta=cremcre.ccodcta ")
        strSQL.Append("and tabtofi.ccodofi=cremcre.cCodofi and cconcep='CJ' and ctippag='D' ")
        strSQL.Append("and dfecvig >= @DFECHA1 and dfecvig <= @DFECHA2 group by cnomofi ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@DFECHA1", SqlDbType.DateTime)
        args(0).Value = ldfecha1
        args(1) = New SqlParameter("@DFECHA2", SqlDbType.DateTime)
        args(1).Value = ldfecha2

        Dim Dataset_Desembolsos As DataSet

        Try
            Dataset_Desembolsos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        'Return Rpt_DL_Dataset
        'Pasamos un DataSet a Un DataTable para llamar asi a la funcion de Excel
        Dim TemRptDesembolsos As DataTable = Dataset_Desembolsos.Tables(0).Copy

        Dim SumTotDesembolsado As Object = TemRptDesembolsos.Compute("sum(Total_Desembolsado)", "")
        'Asignamos la fila al final de su columan perteneciente ,ya calculada
        Dim newCustomersRow As DataRow = TemRptDesembolsos.NewRow()
        newCustomersRow("Total_Desembolsado") = SumTotDesembolsado
        newCustomersRow("cnomofi") = "TOTAL DESEMBOLSADO"

        TemRptDesembolsos.Rows.Add(newCustomersRow)

        'Damos nombres de tipo Vista para el usuario
        TemRptDesembolsos.Columns("cnomofi").ColumnName = "Sucursal"
        TemRptDesembolsos.Columns("Total_Desembolsado").ColumnName = "Total desembolsado"

        return TemRptDesembolsos
    End Function
    '----------Ejecuta anexo C-----------------------------------------------------------------------------
    Public Function cargarAnexoC() As DataTable
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Anexo_C"

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
                'lnRetorno = CInt(MyCommand.Parameters("@pnError").Value)

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Dim TblAnexoC As DataTable = Ds.Tables(0).Copy

        Return TblAnexoC

    End Function

    '/****** FERNANDO ABREGO RDZ Object:  StoredProcedure [dbo].[Rpt_CuentaMaestra]    Script Date: 02/07/2015 19:09:01 ******/
    Public Function Rpt_CuentaMaestra(ByVal dfecha1 As Date, ByVal dfecha2 As Date) As DataSet

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "ObtieneCuentaFondoMaestra"

                MyParameters = _
                                MyCommand.Parameters.Add("@dfecha1", SqlDbType.DateTime)
                MyParameters.Value = dfecha1
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@dfecha2", SqlDbType.DateTime)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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
    'Reporte de Getsores en mora
    Public Function Rpt_GestoresMora(ByVal dfecha2 As Date, ByVal oficina As String, ByVal asesor As String) As DataSet

        If oficina = "" Or oficina Is Nothing Then

            oficina = "*"
        End If
        If asesor = "" Or asesor Is Nothing Then

            asesor = "*"
        End If

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_Creditos_X_Gestores_Cobranza"
                MyParameters = _
                                MyCommand.Parameters.Add("@fecha2", SqlDbType.DateTime)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                '@ccodofi varchar(3),
                '@gestor varchar(100)
                MyParameters = _
                                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                MyParameters.Value = oficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@gestor", SqlDbType.VarChar)
                MyParameters.Value = asesor
                MyParameters.Direction = ParameterDirection.Input


                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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
    'Obtener lista de usuarios y nombres
    Public Function consultaCodigoAnalistasGestores(ByVal oficina As String) As DataSet
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_ReporteCodigoAnalistas"
              
                MyParameters = _
                                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                MyParameters.Value = oficina
                MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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
    'Eejcuta Store procedure de consulta de garantias prendarias para emsa de control
    Public Function consultaGarantiasPrendarias() As DataSet

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_GarantiasPrendarias"

                'MyParameters = _
                '                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                'MyParameters.Value = oficina
                'MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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
    'Ejecutar Reporte de Detalle de garantias
    Public Function ConsultaDetalleGarantias(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataSet


        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_DetallesDeGarantias"

                MyParameters = _
                               MyCommand.Parameters.Add("@fecha1", SqlDbType.Date)
                MyParameters.Value = fecha1
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                              MyCommand.Parameters.Add("@fecha2", SqlDbType.Date)
                MyParameters.Value = fecha2
                MyParameters.Direction = ParameterDirection.Input

                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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

    'Ejecuta reporte de Asignacion de Analista
    Public Function ExecReporteAsigAnalistas(ByVal dfecha2 As Date, ByVal oficina As String, ByVal asesor As String) As DataSet

        If oficina = "" Or oficina Is Nothing Then

            oficina = "*"
        End If
        If asesor = "" Or asesor Is Nothing Then

            asesor = "*"
        End If

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "select * from GestoreSeleccionados"
                MyParameters = _
                                MyCommand.Parameters.Add("@fecha2", SqlDbType.DateTime)
                MyParameters.Value = dfecha2
                MyParameters.Direction = ParameterDirection.Input

                '@ccodofi varchar(3),
                '@gestor varchar(100)
                MyParameters = _
                                MyCommand.Parameters.Add("@ccodofi", SqlDbType.VarChar)
                MyParameters.Value = oficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@gestor", SqlDbType.VarChar)
                MyParameters.Value = asesor
                MyParameters.Direction = ParameterDirection.Input


                MyCommand.CommandType = CommandType.Text


                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds)
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
    Public Function RdbOperaciones_Insuales(ByVal ldfecha1 As DateTime, ByVal ldfecha2 As DateTime) As DataTable

        'Dim fecha4Valoracion As DateTime = ldfecha2
        Dim periodo_De_reporte As String
        Dim mes As Integer
        'Dim dias_restados As Integer
        mes = Month(ldfecha2)
        Dim fechainicio As DateTime = ldfecha1
        Select Case mes
            Case 1 To 3

                'fechainicio = New DateTime(DateTime.Now.Year, 1, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 4 To 6
                'fechainicio = New DateTime(DateTime.Now.Year, 4, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 7 To 9

                'fechainicio = New DateTime(DateTime.Now.Year, 7, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
            Case 10 To 12

                'fechainicio = New DateTime(DateTime.Now.Year, 10, 1)
                periodo_De_reporte = "Fechas de Valoracion:  " & fechainicio & "  a  " & ldfecha2
        End Select

        Dim strSQL As New StringBuilder

        strSQL.Append("select tabtofi.cnomofi, climide.cnomcli, cremcre.dfecmod ")
        strSQL.Append("from cremcre JOIN climide on cremcre.ccodcli=climide.ccodcli inner join tabtofi on cremcre.cCodofi=tabtofi.ccodofi ")
        strSQL.Append("where cremcre.cestado='G' ")
        strSQL.Append("and cremcre.dfecmod >=@DFECHA1 and cremcre.dfecmod<=@DFECHA2 ")
        strSQL.Append("group by cremcre.ccodcli,climide.cnomcli,cremcre.dfecmod,tabtofi.cnomofi ")
        strSQL.Append("having datediff(dd,min(cremcre.fecha_desembolso),max(cremcre.dfecven))/2 <= datediff(dd,min(cremcre.fecha_desembolso),max('20150323'))")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@DFECHA1", SqlDbType.DateTime)
        args(0).Value = fechainicio
        args(1) = New SqlParameter("@DFECHA2", SqlDbType.DateTime)
        args(1).Value = ldfecha2

        Dim RdbOperaciones_Cuotas_Inusuales_dataset As DataSet

        Try
            RdbOperaciones_Cuotas_Inusuales_dataset = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Dim TemRptOperaciones_inusuales As DataTable = RdbOperaciones_Cuotas_Inusuales_dataset.Tables(0).Copy

        Dim newCustomersRow As DataRow = TemRptOperaciones_inusuales.NewRow()

        newCustomersRow("cnomofi") = periodo_De_reporte

        TemRptOperaciones_inusuales.Rows.Add(newCustomersRow)

        TemRptOperaciones_inusuales.Columns("cnomofi").ColumnName = "Sucursal"
        TemRptOperaciones_inusuales.Columns("cnomcli").ColumnName = "Nombre Cliente"

        TemRptOperaciones_inusuales.Columns("dfecmod").ColumnName = "Fecha de Operacion"

        Return TemRptOperaciones_inusuales

        'ExportarDataTableAExcel(TemRptOperaciones_inusuales)


    End Function
    'Funcion de exportacion a Excel 
    'Creador: FERNANDO ABREGO RDZ
    'Fecha: 03/03/2015
    'Desc:Descopone y brinda formato a un datatable
    Shared Function ExportarDataTableAExcel(ByVal Tabla As DataTable) As Boolean
        Try
            'Creamos las variables
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim filaTabla As System.Data.DataRow

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Tabla.Columns.Count
            Dim NRow As Integer = Tabla.Rows.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(3, i) = Tabla.Columns(i - 1).Caption
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            For Fila As Integer = 0 To NRow - 1
                filaTabla = Tabla.Rows(Fila)
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 4, Col + 1) = filaTabla(Col)
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(3).Font.Bold = 1
            exHoja.Rows.Item(3).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            ExportarDataTableAExcel = True
        Catch ex As Exception
            MsgBox(" ERROR : " & ex.Message & " --UtilForm.ExportarDataTableAExcel", "Administrador")
            ExportarDataTableAExcel = False
        End Try
    End Function
    '''''''''FIN

    'Valida si cliente tiene credito vigente
    Public Function Credito_Vigente_por_Cliente(ByVal cCodcli As String) As DataSet

        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False
        Dim dr As DataRow


        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select b.ccodcta, b.ccodcli, b.cestado, b.dfecvig, b.ncapdes from climide a" & _
                                        " inner join cremcre b " & _
                                        " on a.ccodcli = b.ccodcli " & _
                                        " where a.ccodcli = '" & cCodcli & "'" & _
                                        " and b.cestado = 'F' "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Cartera")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    'Valida Archivo Txt
    Public Function Valida_Archivo_Txt(ByVal cnomarch As String) As Integer

        Dim lnRetorno As Integer = 0
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False
        Dim dr As DataRow


        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select * from Detalle_archivos_txt " & _
                                        " Where cnomarch like '" & cnomarch & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Archivo_Plano")

                If ds_Trab.Tables("Archivo_Plano").Rows.Count > 0 Then
                    lnRetorno = 1
                End If

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnRetorno

    End Function


    Public Function Actualiza_Datos_Archivo_Txt(ByVal cnomarch As String, ByVal fecha_archivo As Date, _
                                                ByVal ccodusu As String) As Integer

        Dim lnRetorno As Integer = 0
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False
        Dim dr As DataRow


        Using connection
            connection.Open()

            Try
                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Insert into Detalle_archivos_txt (cnomarch, fecha_archivo, dfecmod, ccodusu)" & _
                                        " Values('" & cnomarch & "','" & fecha_archivo & "', getdate(),'" & ccodusu & "')"

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


    Public Function Extraer_Cartera_SP(ByVal pdfecsis As Date, ByVal pnTipo As Integer, ByVal lcanalista As String, _
                                       ByVal lcoficina As String, ByVal lclineas As String, ByVal lczona As String, _
                                       ByVal lcproducto As String, ByVal lccartera As String, ByVal lctipo As String, _
                                       ByVal lnmora As Integer) As DataSet


        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet
        'Cesar Torres 02/02/2016 reducir los campos del dataset
        Dim DsR As New DataSet
        'Cesar Torres 02/02/2016

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Sp_Cartera_Vigente"

                MyParameters = _
                                MyCommand.Parameters.Add("@dfecpro", SqlDbType.DateTime)
                MyParameters.Value = pdfecsis
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcanalista", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcoficina", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lclineas", SqlDbType.VarChar)
                MyParameters.Value = lclineas
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lczona", SqlDbType.VarChar)
                MyParameters.Value = lczona
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcproducto", SqlDbType.VarChar)
                MyParameters.Value = lcproducto
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lctipo", SqlDbType.VarChar)
                MyParameters.Value = lctipo
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lccartera", SqlDbType.VarChar)
                MyParameters.Value = lccartera
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lnmora", SqlDbType.Int)
                MyParameters.Value = lnmora
                MyParameters.Direction = ParameterDirection.Input


                'MyParameters = _
                '              MyCommand.Parameters.Add("@pnError", SqlDbType.Int)
                'MyParameters.Direction = ParameterDirection.ReturnValue

                '--@lcanalista varchar(10), 
                '--@lcoficina varchar(10),
                '--@lclineas varchar(10),
                '--@lczona varchar(10),
                '--@lcproducto varchar(10),
                '--@lctipo varchar(10),
                '--@lccartera varchar(10)    


                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds, "Cartera")

                '<!-- Cesar Torres 02/05/2016 reducir columnas


                'Primero le copiamos la estructura del datatable 
                Dim myRpt As Data.DataTable = DsR.Tables.Add("RptCartera")

                With myRpt
                    .Columns.Add("Credito", Type.GetType("System.String"))
                    .Columns.Add("Oficina", Type.GetType("System.String"))
                    '.Columns.Add("Asesor", Type.GetType("System.String"))
                    '.Columns.Add("FechaDesembolso", Type.GetType("System.String"))
                    '.Columns.Add("Grupo", Type.GetType("System.String"))

                    '.Columns.Add("CapitalMora", Type.GetType("System.String"))
                    '.Columns.Add("SaldoCapital", Type.GetType("System.String"))
                    '.Columns.Add("SaldoIntereses", Type.GetType("System.String"))
                    '.Columns.Add("SaldoInteres Moratorio", Type.GetType("System.String"))

                    '.Columns.Add("DiasAtraso", Type.GetType("System.String"))

                End With


                ''Ahora copiamos la data del datatable a nuestras nuevas columnas

                Dim cnomgru, cnomana, cnomofi, dfecvig, ncapmora, codigo_credito As String
                Dim nSalCap, nSalint, nSalintMor, ndiaatr As String




                For i As Integer = 0 To Ds.Tables(0).Rows.Count - 1
                    Dim j As Integer = DsR.Tables(0).Rows.Count()
                    codigo_credito = Ds.Tables(0).Rows(i)("codigo_credito")
                    cnomofi = Ds.Tables(0).Rows(i)("cnomofi")
                    '    cnomgru = Ds.Tables(0).Rows(i)("cnomgru")
                    '    cnomana = Ds.Tables(0).Rows(i)("cnomana")
                    '    nSalCap = Ds.Tables(0).Rows(i)("nSalCap")
                    '    ncapmora = Ds.Tables(0).Rows(i)("ncapmora")
                    '    nSalint = Ds.Tables(0).Rows(i)("nSalint")
                    '    nSalintMor = Ds.Tables(0).Rows(i)("nSalintMor")
                    '    dfecvig = Ds.Tables(0).Rows(i)("dfecvig")
                    '    ndiaatr = Ds.Tables(0).Rows(i)("ndiaatr")

                    DsR.Tables(0).Rows.Add(i)("Credito") = codigo_credito
                    DsR.Tables(0).Rows.Add(i)("Oficina") = cnomofi
                    '    DsR.Tables(0).Rows(j)("cnomgru") = cnomgru
                    '    DsR.Tables(0).Rows.Add(j)("cnomana") = cnomana
                    '    DsR.Tables(0).Rows(j)("ncapmora") = ncapmora
                    '    DsR.Tables(0).Rows.Add(j)("nSalCap") = nSalCap
                    '    DsR.Tables(0).Rows(j)("nSalint") = nSalint
                    '    DsR.Tables(0).Rows.Add(j)("nSalintMor") = nSalintMor
                    '    DsR.Tables(0).Rows(j)("dfecvig") = dfecvig
                    '    DsR.Tables(0).Rows(j)("ndiaatr") = ndiaatr

                Next
                ''Cesar Torres 02/05/2016 reducir columnas -->





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

    'Extrae cartera mora grupal
    Public Function Extraer_Cartera_SP_MoraGpo(ByVal pdfecsis As Date, ByVal pnTipo As Integer, ByVal lcanalista As String, _
                                       ByVal lcoficina As String, ByVal lclineas As String, ByVal lczona As String, _
                                       ByVal lcproducto As String, ByVal lccartera As String, ByVal lctipo As String, _
                                       ByVal lnmora As Integer) As DataSet


        'Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "PROC_CarteraMora_Grupal"

                MyParameters = _
                                MyCommand.Parameters.Add("@dfecpro", SqlDbType.DateTime)
                MyParameters.Value = pdfecsis
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcanalista", SqlDbType.VarChar)
                MyParameters.Value = lcanalista
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcoficina", SqlDbType.VarChar)
                MyParameters.Value = lcoficina
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lclineas", SqlDbType.VarChar)
                MyParameters.Value = lclineas
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lczona", SqlDbType.VarChar)
                MyParameters.Value = lczona
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lcproducto", SqlDbType.VarChar)
                MyParameters.Value = lcproducto
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lctipo", SqlDbType.VarChar)
                MyParameters.Value = lctipo
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lccartera", SqlDbType.VarChar)
                MyParameters.Value = lccartera
                MyParameters.Direction = ParameterDirection.Input

                MyParameters = _
                                MyCommand.Parameters.Add("@lnmora", SqlDbType.Int)
                MyParameters.Value = lnmora
                MyParameters.Direction = ParameterDirection.Input


                'MyParameters = _
                '              MyCommand.Parameters.Add("@pnError", SqlDbType.Int)
                'MyParameters.Direction = ParameterDirection.ReturnValue

                '--@lcanalista varchar(10), 
                '--@lcoficina varchar(10),
                '--@lclineas varchar(10),
                '--@lczona varchar(10),
                '--@lcproducto varchar(10),
                '--@lctipo varchar(10),
                '--@lccartera varchar(10)    


                MyCommand.CommandType = CommandType.StoredProcedure

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.SelectCommand.CommandTimeout = 0

                MyAdapter.Fill(Ds, "Cartera")
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


End Class
