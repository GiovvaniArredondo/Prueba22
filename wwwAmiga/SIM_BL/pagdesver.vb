Imports System
Imports System.EnterpriseServices
Imports System.Data.SqlClient

'<Transaction(TransactionOption.RequiresNew)> _
Public Class pagdesver
    '   Inherits ServicedComponent
#Region "Privadas"
    Private oktransac As Integer
    Private clssdes As New clsDesembolsa
    Private clase As New crefunc
    Private clsppal As New class1
    Private eahomcta As New cAhomcta
    Private eahommov As New cAhommov
    Private entidadahommov As New ahommov
    Private entidadahomcta As New ahomcta
#End Region

#Region "Propiedades"
    Private lccodcta As String
    Public Property pccodcta() As String
        Get
            pccodcta = lccodcta
        End Get
        Set(ByVal Value As String)
            lccodcta = Value
        End Set
    End Property


    Private _pcctaahovis As String
    Public Property pcctaahovis() As String
        Get
            pcctaahovis = _pcctaahovis
        End Get
        Set(ByVal value As String)
            _pcctaahovis = value
        End Set

    End Property
    Private lccodcli As String
    Public Property pccodcli() As String
        Get
            pccodcli = lccodcli
        End Get
        Set(ByVal Value As String)
            lccodcli = Value
        End Set
    End Property

    Private lcnomcli As String
    Public Property pcnomcli() As String
        Get
            pcnomcli = lcnomcli
        End Get
        Set(ByVal Value As String)
            lcnomcli = Value
        End Set
    End Property

    Private lncapdes As Double
    Public Property pncapdes() As Double
        Get
            pncapdes = lncapdes
        End Get
        Set(ByVal Value As Double)
            lncapdes = Value
        End Set
    End Property


    Private lnsalint As Double
    Public Property pnsalint() As Double
        Get
            pnsalint = lnsalint
        End Get
        Set(ByVal Value As Double)
            lnsalint = Value
        End Set
    End Property

    Private lnsalmor As Double
    Public Property pnsalmor() As Double
        Get
            pnsalmor = lnsalmor
        End Get
        Set(ByVal Value As Double)
            lnsalmor = Value
        End Set
    End Property

    Private lndeucap As Double
    Public Property pndeucap() As Double
        Get
            pndeucap = lndeucap
        End Get
        Set(ByVal Value As Double)
            lndeucap = Value
        End Set
    End Property

    Private lnmoncuo As Double
    Public Property pnmoncuo() As Double
        Get
            pnmoncuo = lnmoncuo
        End Get
        Set(ByVal Value As Double)
            lnmoncuo = Value
        End Set
    End Property


    Private lndiaatr As Double
    Public Property pndiaatr() As Integer
        Get
            pndiaatr = lndiaatr
        End Get
        Set(ByVal Value As Integer)
            lndiaatr = Value
        End Set
    End Property

    Private ldultpag As Date
    Public Property pdultpag() As Date
        Get
            pdultpag = ldultpag
        End Get
        Set(ByVal Value As Date)
            ldultpag = Value
        End Set
    End Property

    Private ldfecval As Date
    Public Property pdfecval() As Date
        Get
            pdfecval = ldfecval
        End Get
        Set(ByVal Value As Date)
            ldfecval = Value
        End Set
    End Property

    Private lncapita As Double
    Public Property pncapita() As Double
        Get
            pncapita = lncapita
        End Get
        Set(ByVal Value As Double)
            lncapita = Value
        End Set
    End Property

    Private lncomision As Double
    Public Property pncomision() As Double
        Get
            pncomision = lncomision
        End Get
        Set(ByVal Value As Double)
            lncomision = Value
        End Set
    End Property

    Private lnhonorarios As Double
    Public Property pnhonorarios() As Double
        Get
            pnhonorarios = lnhonorarios
        End Get
        Set(ByVal Value As Double)
            lnhonorarios = Value
        End Set
    End Property

    Private lngestion As Double
    Public Property pngestion() As Double
        Get
            pngestion = lngestion
        End Get
        Set(ByVal Value As Double)
            lngestion = Value
        End Set
    End Property

    Private lnmonpag As Double
    Public Property pnmonpag() As Double
        Get
            pnmonpag = lnmonpag
        End Get
        Set(ByVal Value As Double)
            lnmonpag = Value
        End Set
    End Property

    Private lcbanco As String
    Public Property pcbanco() As String
        Get
            pcbanco = lcbanco
        End Get
        Set(ByVal Value As String)
            lcbanco = Value
        End Set
    End Property


    Private lctippag As String
    Public Property pctippag() As String
        Get
            pctippag = lctippag
        End Get
        Set(ByVal Value As String)
            lctippag = Value
        End Set
    End Property

    Private lcnuming As String
    Public Property pcnuming() As String
        Get
            pcnuming = lcnuming
        End Get
        Set(ByVal Value As String)
            lcnuming = Value
        End Set
    End Property
    Private lcnuming0 As String
    Public Property pcnuming0() As String
        Get
            pcnuming0 = lcnuming0
        End Get
        Set(ByVal Value As String)
            lcnuming0 = Value
        End Set
    End Property


    Private lnintpag As Double
    Public Property pnintpag() As Double
        Get
            pnintpag = lnintpag
        End Get
        Set(ByVal Value As Double)
            lnintpag = Value
        End Set
    End Property

    Private lnintpen As Double
    Public Property pnintpen() As Double
        Get
            pnintpen = lnintpen
        End Get
        Set(ByVal Value As Double)
            lnintpen = Value
        End Set
    End Property

    Private lnintcal As Double
    Public Property pnintcal() As Double
        Get
            pnintcal = lnintcal
        End Get
        Set(ByVal Value As Double)
            lnintcal = Value
        End Set
    End Property

    Private lnmorpag As Double
    Public Property pnmorpag() As Double
        Get
            pnmorpag = lnmorpag
        End Get
        Set(ByVal Value As Double)
            lnmorpag = Value
        End Set
    End Property
    Private lnpagcta As Double
    Public Property pnpagcta() As Double
        Get
            pnpagcta = lnpagcta
        End Get
        Set(ByVal Value As Double)
            lnpagcta = Value
        End Set
    End Property
    Private lnintmor As Double
    Public Property pnintmor() As Double
        Get
            pnintmor = lnintmor
        End Get
        Set(ByVal Value As Double)
            lnintmor = Value
        End Set
    End Property

    Private lncappag1 As Double
    Public Property pncappag() As Double
        Get
            pncappag = lncappag1
        End Get
        Set(ByVal Value As Double)
            lncappag1 = Value
        End Set
    End Property

    Private ldfecsis As Date
    Public Property gdfecsis() As Date
        Get
            gdfecsis = ldfecsis
        End Get
        Set(ByVal Value As Date)
            ldfecsis = Value
        End Set
    End Property

    Private lccodusu1 As String
    Public Property gccodusu() As String
        Get
            gccodusu = lccodusu1
        End Get
        Set(ByVal Value As String)
            lccodusu1 = Value
        End Set
    End Property

    Private _segdeu As Double
    Public Property segdeu() As Double
        Get
            segdeu = _segdeu
        End Get
        Set(ByVal Value As Double)
            _segdeu = Value
        End Set
    End Property

    Private _manejo As Double
    Public Property manejo() As Double
        Get
            manejo = _manejo
        End Get
        Set(ByVal Value As Double)
            _manejo = Value
        End Set
    End Property
    Private _niva As Double
    Public Property niva() As Double
        Get
            niva = _niva
        End Get
        Set(ByVal value As Double)
            _niva = value
        End Set
    End Property


    Private _ahosim As Double
    Public Property ahosim() As Double
        Get
            ahosim = _ahosim
        End Get
        Set(ByVal Value As Double)
            _ahosim = Value
        End Set
    End Property
    Private _gcpuente As String
    Public Property gcpuente() As String
        Get
            gcpuente = _gcpuente
        End Get
        Set(ByVal Value As String)
            _gcpuente = Value
        End Set
    End Property

    Private _pccolector As String
    Public Property pccolector() As String
        Get
            pccolector = _pccolector
        End Get
        Set(ByVal Value As String)
            _pccolector = Value
        End Set
    End Property

    Private _aporta As Double
    Public Property aporta() As Double
        Get
            aporta = _aporta
        End Get
        Set(ByVal Value As Double)
            _aporta = Value
        End Set
    End Property

    Private _ahovis As Double
    Public Property ahovis() As Double
        Get
            ahovis = _ahovis
        End Get
        Set(ByVal Value As Double)
            _ahovis = Value
        End Set
    End Property

    Private _lsolidario As Boolean
    Public Property lsolidario() As Boolean
        Get
            lsolidario = _lsolidario
        End Get
        Set(ByVal Value As Boolean)
            _lsolidario = Value
        End Set
    End Property
    Private _lret As Boolean
    Public Property lret() As Boolean
        Get
            lret = _lret
        End Get
        Set(ByVal Value As Boolean)
            _lret = Value
        End Set
    End Property


    Private _pcCuentaAj As String
    Public Property pcCuentaAj() As String
        Get
            pcCuentaAj = _pcCuentaAj
        End Get
        Set(ByVal Value As String)
            _pcCuentaAj = Value
        End Set
    End Property
    Private _pcCuentaAj2 As String
    Public Property pcCuentaAj2() As String
        Get
            pcCuentaAj2 = _pcCuentaAj2
        End Get
        Set(ByVal Value As String)
            _pcCuentaAj2 = Value
        End Set
    End Property
    Private _pcCuentaAj3 As String
    Public Property pcCuentaAj3() As String
        Get
            pcCuentaAj3 = _pcCuentaAj3
        End Get
        Set(ByVal Value As String)
            _pcCuentaAj3 = Value
        End Set
    End Property

    Private _nretencion As Double 'porcentaje de retencion
    Public Property nretencion() As Double
        Get
            nretencion = _nretencion
        End Get
        Set(ByVal Value As Double)
            _nretencion = Value
        End Set
    End Property

    Private _gniva As Double 'porcentaje de retencion
    Public Property gniva() As Double
        Get
            gniva = _gniva
        End Get
        Set(ByVal Value As Double)
            _gniva = Value
        End Set
    End Property

    Private _pcCodctaAho As String
    Public Property pcCodctaAho() As String
        Get
            pcCodctaAho = _pcCodctaAho
        End Get
        Set(ByVal Value As String)
            _pcCodctaAho = Value
        End Set
    End Property

#End Region

    Public Sub New()
    End Sub

    '   <AutoComplete()> _
    Public Function mxdistribute() As Integer
        Dim utilnuemeros As New utilNumeros
        'temporalmente 
        Dim gccodofi As String = Mid(Me.pccodcta, 4, 3)
        Dim a As String
        Dim lccodcta As String = Me.pccodcta
        Dim lncapita As Double = Math.Round(Me.pncapita, 2)
        Dim lnintere As Double = Math.Round(Me.pnsalint, 2)
        Dim lnmora As Double = Math.Round(Me.pnsalmor, 2)
        Dim lncomision As Double = Math.Round(Me.pncomision, 2)
        Dim lnhonorarios As Double = Math.Round(Me.pnhonorarios, 2)
        Dim lnmanejo As Double = Math.Round(Me.manejo, 2)
        Dim lniva As Double = Math.Round(Me.niva, 2)
        Dim lnahosim As Double = Math.Round(Me.ahosim, 2)
        Dim lnahovis As Double = Math.Round(Me.ahovis, 2)
        Dim lnaporta As Double = Math.Round(Me.aporta, 2)
        Dim lnsegdeu As Double = Math.Round(Me.segdeu, 2)
        Dim lsolidario As Boolean = False
        Dim lretencion As Boolean = Me.lret
        Dim lcctaret As String = "*"
        Dim lnretencion As Double = Math.Round(Me.nretencion, 2)

        Dim lnretencion1 As Double = 0
        Dim lnretencion2 As Double = 0

        Dim lngestion As Double = Math.Round(Me.pngestion, 2)
        Dim lnmonpag As Double = Math.Round(Me.pnmonpag, 2)
        Dim ldfecval As Date = Me.pdfecval
        Dim lndeutot As Double = Math.Round(Me.pndeucap, 2)
        Dim lcbanco As String = Me.pcbanco
        Dim lniva_interes As Double = 0
        Dim lniva_total As Double = 0
        Dim lniva_mora As Double = 0
        Dim lnintmor As Double
        Dim lntotapag As Double = 0
        Dim lcnrodoc As String
        '        Dim kardex As DataTable
        Dim crefunc As New SIM.bl.crefunc
        '       Dim cre As New DataSet
        Dim lcctactb As String
        'variables necesitadas para la clase
        Dim lctippag As String
        Dim lnmonto As Double
        Dim lnintpag As Double
        Dim lndifint As Double
        Dim lcnorref As String
        Dim lccodlin As String
        Dim lcconcep As String
        Dim lcdescob As String
        Dim lccondic As String
        Dim lcnrolin As String
        Dim lnintcap As Double
        Dim ldfecsis As Date
        Dim lccodusu As String
        Dim lngastot As Double
        Dim lnnumlin As Integer

        Dim lccodfue As String
        'actualiza tablas de contabilidad
        Dim lcnumcom As String
        Dim ok As Integer
        Dim tamano As Integer
        Dim i As Integer
        Dim lnlinaho As Integer

        'Obtiene fecha y hora actual

        Dim lchora As String = TimeOfDay.ToString.Substring(11, 12).Replace(".", "").ToUpper
        Dim lcfecha As String
        lcfecha = "#" & Left(gdfecsis.ToString, 10) & " " & lchora & "#"

        Dim ldfecha As DateTime
        ldfecha = DateTime.Parse(lcfecha)

        Dim lctaespecial As String = "*"
        '----------------------------------------

        'obtiene el numero de partida
        lcnumcom = "99999997"  'Mid(gccodofi, 2, 2)

        'temporalmente
        lndifint = 0
        lnintcap = 0
        lctippag = pctippag.Trim
        'Genera las cuentas de orden para cuando exista Condonaciones>>>>>
        Dim lccontra7 As String = "*"
        Dim lccontra8 As String = "*"

        Dim lccontra7a As String = ""
        Dim lccontra8a As String = ""
        lngastot = 0

        '   Try
        'abre las colecciones para tomar otros datos que hacen falta
        'en las tablas de las colecciones

        'cremcre
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre
        entidad1.ccodcta = lccodcta
        ecreditos.ObtenerCremcre(entidad1)
        gccodofi = entidad1.coficina


        crefunc.pcoficina = gccodofi
        crefunc.pccodusu = gccodusu
        'credkar
        Dim ecredkar As New SIM.BL.cCredkar
        Dim entidadkardex As New SIM.EL.credkar

        'cntamov
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        entidadcntamov.cnumcom = lcnumcom

        'diario
        Dim entidaddiario As New SIM.EL.diario
        Dim ediario As New SIM.BL.cDiario

        entidaddiario.cnumcom = lcnumcom

        'ahorros
        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov

        Dim lccodaho As String
        Dim lnsaldoaho As Double
        Dim lnnewsalaho As Double

        'actualiza tabla de comprobantes
        Dim mtabtvar As New cTabtvar
        Dim etabtvar As New tabtvar

        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNCORRELA"
        etabtvar.lcarini = True
        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.cconvar = Me.pcnuming
        mtabtvar.ActualizarTabtvar(etabtvar)
        '        GNNUMLIN


        'obtendra el numero de linea donde va en la digitacion de la partida de ingresos
        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNNUMLIN"
        etabtvar.lcarini = True
        mtabtvar.ObtenerTabtvar(etabtvar)
        lnnumlin = Integer.Parse(etabtvar.cconvar)


        'obtiene numero de documento
        lcnrodoc = ecredkar.obtenercnrodoc(pccodcta)
        If lcnrodoc = Nothing Then
            lcnrodoc = "002"
        End If
        tamano = lcnrodoc.Trim.Length
        For i = 1 To 3 - tamano
            lcnrodoc = "0" & lcnrodoc
        Next


        lcconcep = "C"
        lcdescob = "C"
        lccondic = entidad1.ccondic
        lcnrolin = entidad1.cnrolin

        lcnorref = entidad1.cnorref

        Dim ecretlin As New cCretlin




        'carga propiedades
        entidad1.nintpag = Me.pnintpag
        entidad1.nintpen = Me.pnintpen
        entidad1.nintcal = Me.pnintcal
        entidad1.nmorpag = Me.pnmorpag
        entidad1.npagcta = Me.pnpagcta
        entidad1.nintmor = Me.pnintmor
        entidad1.dultpag = Me.pdultpag
        entidad1.ncappag = Me.pncappag

        'cretlin
        Dim entidad2 As New SIM.EL.cretlin

        entidad2.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidad2)

        lccodlin = entidad2.ccodlin
        lccodfue = clssdes.ConvertidorFondos(lccodlin.Trim.Substring(2, 2)) 'entidad1.ccodfue

        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim busquedaplantilla As Integer
        Dim cplanti As String

        If lctippag = "I" Then

            entidadtabtmak.ccodigo = "CMONN"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra8 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                'lccontra7 = cplanti
                lccontra8 = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If
            entidadtabtmak.ccodigo = "CMOFN"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra8a = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                'lccontra7 = cplanti
                lccontra8a = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If


            entidadtabtmak.ccodigo = "CINNN"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra7 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra7 = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If
            entidadtabtmak.ccodigo = "CINFN"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra7a = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra7a = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If


        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        Dim siexiste As Boolean
        'inicia rutina de grabado en tablas
        '**************************  DATOS **********************
        '******************    agrega a la diario ***************

        'localiza si ya existe ese numero de partida en la diario,
        'de lo contrario ya no lo agregara
        siexiste = ediario.siexistepartida(lcnumcom)
        If siexiste = False Then 'si ya existe no es necesario agregarlo en la diario
            entidaddiario.cnumcom = lcnumcom
            entidaddiario.cglosa = "PARTIDA DE PAGO DE PRESTAMOS"
            entidaddiario.cnumdoc = pcnuming
            entidaddiario.dfeccnt = gdfecsis
            entidaddiario.cestado = " "
            entidaddiario.ccodofi = gccodofi
            entidaddiario.ffondos = lccodfue
            entidaddiario.dfecdoc = gdfecsis
            entidaddiario.dfecmod = gdfecsis
            ediario.agregarDiario(entidaddiario)
        End If
        Dim lcnomcli As String = ""
        Dim ecremcre As New cCremcre
        lcnomcli = ecremcre.ObtenerNombrexCuenta(lccodcta)
        
        
        '------------------------------------------------------------------------------------------------------------
        If pctippag.Trim = "I" Then 'Cuando existen condonacion no hay que cobrar Cargos
        Else
            'Cobro de Cargos
            Dim ecredgas As New cCredgas
            Dim dsg As New DataSet
            dsg = ecredgas.CargaGastosCuota(pccodcta, pdfecval, "C", "001")
            Dim filag As DataRow

            For Each filag In dsg.Tables(0).Rows
                If filag("nmongas") > 0 And lnmonpag > 0 Then
                    Try
                        If lctippag = "I" Then
                            lcctactb = lccontra8
                        Else
                            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, filag("ctipgas"), lcdescob, lccondic, lctippag, pcbanco, filag("nmongas"), lnintcap, lndifint)
                        End If
                    Catch ex As Exception
                        lcctactb = "*"

                    End Try
                    If lcctactb = "*" Then
                        oktransac = 2
                    End If
                    If lnmonpag > filag("nmongas") Then
                        lnintmor = filag("nmongas")
                        lnmonpag = Math.Round(lnmonpag - filag("nmongas"), 2)
                    Else
                        filag("nmongas") = lnmonpag
                        lnmonpag = 0
                    End If
                    lntotapag = lntotapag + filag("nmongas")
                    entidadkardex.ccodcta = pccodcta
                    entidadkardex.nmonto = filag("nmongas")
                    entidadkardex.ccodctb = lcctactb
                    entidadkardex.cconcep = filag("ctipgas")
                    entidadkardex.cdescob = "C"
                    entidadkardex.ctippag = lctippag
                    entidadkardex.cestado = " "
                    entidadkardex.ctippag = lctippag.Trim
                    entidadkardex.dfecsis = gdfecsis
                    entidadkardex.dfecpro = pdfecval
                    entidadkardex.dfecmod = Now()
                    entidadkardex.ccodusu = gccodusu
                    entidadkardex.ccondic = "N"
                    entidadkardex.cbanco = pcbanco
                    entidadkardex.cnuming = pcnuming
                    entidadkardex.cnuming0 = pcnuming0
                    entidadkardex.ctrasctb = 1
                    entidadkardex.ndiaatr = Me.pndiaatr
                    entidadkardex.ccodofi = gccodofi
                    entidadkardex.ccodins = gccodofi
                    entidadkardex.cnrodoc = lcnrodoc
                    entidadkardex.lsolidario = lsolidario
                    entidadkardex.cclipag = "0"

                    ecredkar.agregarCredkar(entidadkardex) ' graba

                    
                    'contabilidad
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lcctactb
                    entidadcntamov.cnumlin = lnnumlin
                    entidadcntamov.nhaber = filag("nmongas")
                    entidadcntamov.ndebe = 0
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.dfecmod = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = lccodfue
                    entidadcntamov.cclase = Left(lcctactb, 1)
                    entidadcntamov.cpoliza = "ING"

                    entidadcntamov.ccodsec = filag("ctipgas")
                    entidadcntamov.cconcepto = filag("cdescri")
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli

                    entidadcntamov.corden = lcnrodoc
                    entidadcntamov.cnumrec = pcnuming0
                    ecntamov.agregarCntamov(entidadcntamov)
                End If

            Next
            'Fin de Cargos-------------------------------------------------------------------------------------------

        End If


        ''mora
        'Try
        '    If lctippag = "I" Then
        '        lcctactb = lccontra8
        '    Else
        '        lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "MO", lcdescob, lccondic, lctippag, pcbanco, lnmora, lnintcap, lndifint)
        '    End If
        'Catch ex As Exception

        'End Try
        'If lcctactb = "*" Then
        '    oktransac = 2
        '    'Throw New Exception("Mesanje personalizado")
        '    'Return -1 'Error porque no existe 
        'End If

        'If lctippag = "I" Then 'condonacion de interes moratorio
        '    'Nuevo Tropi--------------------------------------------------------------------------------------------
        '    Dim lnIntActM As Double = 0
        '    Dim lnAbonoM As Double = 0

        '    If lnmora > 0 And lnmonpag > 0 Then
        '        If lnmonpag > lnmora Then
        '            lnintmor = lnmora
        '            lnmonpag = lnmonpag - lnintmor
        '        Else
        '            lnintmor = lnmonpag
        '            lnmonpag = 0
        '        End If


        '        lnretencion1 = 0

        '        Dim lnintprovM As Double = 0
        '        lnintprovM = clsppal.fxIntProMor(pccodcta, lnintmor, lcnrodoc)

        '        If lnintprovM > 0 Then 'Agrega el interes provisionado
        '            lnIntActM = lnintprovM
        '            Dim lcctactbprovM As String

        '            If lctippag = "I" Then
        '                lcctactbprovM = lccontra8
        '            Else
        '                lcctactbprovM = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "MO", lcdescob, "P", lctippag, pcbanco, lnintere, lnintcap, lndifint)
        '            End If
        '            If lcctactbprovM = "*" Then
        '                oktransac = 2
        '            End If
        '            lntotapag = lntotapag + lnIntActM

        '            entidadkardex.ccodcta = pccodcta
        '            entidadkardex.nmonto = lnIntActM 'Math.Round(lnintmor - lnretencion1, 2)
        '            entidadkardex.ccodctb = lcctactbprovM
        '            entidadkardex.cconcep = "MO"
        '            entidadkardex.cdescob = "C"
        '            entidadkardex.ctippag = lctippag
        '            entidadkardex.cestado = " "
        '            entidadkardex.ctippag = lctippag.Trim
        '            entidadkardex.dfecsis = gdfecsis
        '            entidadkardex.dfecpro = pdfecval
        '            entidadkardex.dfecmod = Now()
        '            entidadkardex.ccodusu = gccodusu
        '            entidadkardex.ccondic = "P"
        '            entidadkardex.cbanco = pcbanco
        '            entidadkardex.cnuming = pcnuming
        '            entidadkardex.cnuming0 = pcnuming0
        '            entidadkardex.ctrasctb = 1
        '            entidadkardex.ndiaatr = Me.pndiaatr
        '            entidadkardex.ccodofi = gccodofi
        '            entidadkardex.ccodins = gccodofi
        '            entidadkardex.cnrodoc = lcnrodoc
        '            entidadkardex.lsolidario = lsolidario
        '            entidadkardex.cclipag = "0"
        '            ecredkar.agregarCredkar(entidadkardex) ' graba



        '            'contabilidad
        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lcctactbprovM
        '            entidadcntamov.cnumlin = lnnumlin
        '            entidadcntamov.nhaber = Math.Round(lnIntActM, 2)
        '            entidadcntamov.ndebe = 0
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.dfecmod = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lcctactb, 1)
        '            entidadcntamov.cpoliza = "ING"
        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "PAGO DE MORA PROVISIONADO"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.corden = lcnrodoc
        '            entidadcntamov.cnumrec = pcnuming0
        '            ecntamov.agregarCntamov(entidadcntamov)

        '            '---------------------------------------------------------------------------------


        '        End If

        '        'Interes Moratorio No Provisionado
        '        lnAbonoM = lnintmor
        '        lnAbonoM = IIf((lnAbonoM - lnintprovM) > 0, (lnAbonoM - lnintprovM), 0)

        '        If lnAbonoM > 0 Then
        '            lntotapag = lntotapag + lnAbonoM
        '            entidadkardex.ccodcta = pccodcta
        '            entidadkardex.nmonto = lnAbonoM 'lnintere
        '            entidadkardex.ccodctb = lcctactb
        '            entidadkardex.cconcep = "MO"
        '            entidadkardex.cdescob = "C"
        '            entidadkardex.ctippag = lctippag
        '            entidadkardex.cestado = " "
        '            entidadkardex.ctippag = lctippag
        '            entidadkardex.dfecsis = gdfecsis
        '            entidadkardex.dfecmod = Now
        '            entidadkardex.dfecpro = pdfecval
        '            entidadkardex.ccodusu = gccodusu
        '            entidadkardex.ccondic = "N"
        '            entidadkardex.cbanco = pcbanco
        '            entidadkardex.cnuming = pcnuming
        '            entidadkardex.cnuming0 = pcnuming0
        '            entidadkardex.ctrasctb = 1
        '            entidadkardex.ndiaatr = Me.pndiaatr
        '            entidadkardex.ccodofi = gccodofi
        '            entidadkardex.ccodins = gccodofi
        '            entidadkardex.cnrodoc = lcnrodoc

        '            'contabilidad
        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lcctactb
        '            entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
        '            entidadcntamov.nhaber = lnAbonoM 'lnintere
        '            entidadcntamov.ndebe = 0
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lccodcta, 1)
        '            entidadcntamov.cpoliza = "ING"
        '            entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "PAGO DE MORA"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.cnumrec = pcnuming0
        '            entidadcntamov.corden = lcnrodoc

        '            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

        '            entidadcntamov.cnumrec = pcnuming0
        '            oktransac = ecntamov.agregarCntamov(entidadcntamov)


        '        End If



        '    End If


        'Else ' Pago normal
        '    'mora
        '    'Nuevo Tropi--------------------------------------------------------------------------------------------
        '    Dim lnIntActM As Double = 0
        '    Dim lnAbonoM As Double = 0

        '    If lnmora > 0 And lnmonpag > 0 Then
        '        If lnmonpag > lnmora Then
        '            lnintmor = lnmora
        '            lnmonpag = lnmonpag - lnintmor
        '        Else
        '            lnintmor = lnmonpag
        '            lnmonpag = 0
        '        End If

        '        'Verifica condicion para hacer partida adicional
        '        If lccondic = "S" Then
        '            entidadtabtmak.ccodigo = "CMOXS"
        '            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        '            If busquedaplantilla = 0 Then
        '                lctaespecial = "*"
        '            Else
        '                cplanti = entidadtabtmak.cplanti.Trim
        '                lctaespecial = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
        '            End If
        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lctaespecial
        '            entidadcntamov.cnumlin = lnnumlin
        '            entidadcntamov.nhaber = Math.Round(lnintmor, 2)
        '            entidadcntamov.ndebe = 0
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.dfecmod = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lctaespecial, 1)
        '            entidadcntamov.cpoliza = "ING"
        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "PAGO DE MORA/CASTIGADO"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.corden = lcnrodoc
        '            entidadcntamov.cnumrec = pcnuming0
        '            ecntamov.agregarCntamov(entidadcntamov)
        '        End If

        '        lnretencion1 = 0

        '        Dim lnintprovM As Double = 0
        '        lnintprovM = clsppal.fxIntProMor(pccodcta, lnintmor, lcnrodoc)

        '        If lnintprovM > 0 Then 'Agrega el interes provisionado
        '            lnIntActM = lnintprovM
        '            Dim lcctactbprovM As String

        '            If lctippag = "I" Then
        '                lcctactbprovM = lccontra8
        '            Else
        '                lcctactbprovM = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "MO", lcdescob, "P", lctippag, pcbanco, lnintere, lnintcap, lndifint)
        '            End If
        '            If lcctactbprovM = "*" Then
        '                oktransac = 2
        '            End If
        '            lntotapag = lntotapag + lnIntActM

        '            entidadkardex.ccodcta = pccodcta
        '            entidadkardex.nmonto = lnIntActM 'Math.Round(lnintmor - lnretencion1, 2)
        '            entidadkardex.ccodctb = lcctactbprovM
        '            entidadkardex.cconcep = "MO"
        '            entidadkardex.cdescob = "C"
        '            entidadkardex.ctippag = lctippag
        '            entidadkardex.cestado = " "
        '            entidadkardex.ctippag = lctippag.Trim
        '            entidadkardex.dfecsis = gdfecsis
        '            entidadkardex.dfecpro = pdfecval
        '            entidadkardex.dfecmod = Now()
        '            entidadkardex.ccodusu = gccodusu
        '            entidadkardex.ccondic = "P"
        '            entidadkardex.cbanco = pcbanco
        '            entidadkardex.cnuming = pcnuming
        '            entidadkardex.cnuming0 = pcnuming0
        '            entidadkardex.ctrasctb = 1
        '            entidadkardex.ndiaatr = Me.pndiaatr
        '            entidadkardex.ccodofi = gccodofi
        '            entidadkardex.ccodins = gccodofi
        '            entidadkardex.cnrodoc = lcnrodoc
        '            entidadkardex.lsolidario = lsolidario
        '            entidadkardex.cclipag = "0"
        '            ecredkar.agregarCredkar(entidadkardex) ' graba



        '            'contabilidad
        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lcctactbprovM
        '            entidadcntamov.cnumlin = lnnumlin
        '            entidadcntamov.nhaber = Math.Round(lnIntActM, 2)
        '            entidadcntamov.ndebe = 0
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.dfecmod = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lcctactb, 1)
        '            entidadcntamov.cpoliza = "ING"
        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "PAGO DE MORA PROVISIONADO"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.corden = lcnrodoc
        '            entidadcntamov.cnumrec = pcnuming0
        '            If lccondic = "S" Then
        '            Else
        '                ecntamov.agregarCntamov(entidadcntamov)
        '            End If


        '            'Movimiento Regularizador----------------------------------------------
        '            entidadtabtmak.ccodigo = "CMOFN"
        '            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        '            If busquedaplantilla = 0 Then
        '                lcctactb = "*"
        '            Else
        '                cplanti = entidadtabtmak.cplanti.Trim
        '                lcctactb = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
        '            End If

        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lcctactb
        '            entidadcntamov.cnumlin = lnnumlin
        '            entidadcntamov.nhaber = 0
        '            entidadcntamov.ndebe = Math.Round(lnIntActM, 2)
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.dfecmod = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lcctactb, 1)
        '            entidadcntamov.cpoliza = "ING"

        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "REGULARIZA  MORA"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.corden = lcnrodoc
        '            entidadcntamov.cnumrec = pcnuming0

        '            If lccondic = "S" Then
        '            Else
        '                ecntamov.agregarCntamov(entidadcntamov)
        '            End If

        '            If lccondic = "S" Then
        '                entidadtabtmak.ccodigo = "CMONS"
        '            Else
        '                entidadtabtmak.ccodigo = "CMOING"
        '            End If

        '            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        '            If busquedaplantilla = 0 Then
        '                lcctactb = "*"
        '            Else
        '                cplanti = entidadtabtmak.cplanti.Trim
        '                lcctactb = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
        '            End If

        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lcctactb
        '            entidadcntamov.cnumlin = lnnumlin
        '            entidadcntamov.nhaber = Math.Round(lnIntActM, 2)
        '            entidadcntamov.ndebe = 0
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.dfecmod = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lcctactb, 1)
        '            entidadcntamov.cpoliza = "ING"

        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "REGULARIZA  MORA"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.corden = lcnrodoc
        '            entidadcntamov.cnumrec = pcnuming0
        '            ecntamov.agregarCntamov(entidadcntamov)

        '            '---------------------------------------------------------------------------------


        '        End If

        '        'Interes Moratorio No Provisionado
        '        lnAbonoM = lnintmor
        '        lnAbonoM = IIf((lnAbonoM - lnintprovM) > 0, (lnAbonoM - lnintprovM), 0)

        '        If lnAbonoM > 0 Then
        '            lntotapag = lntotapag + lnAbonoM
        '            entidadkardex.ccodcta = pccodcta
        '            entidadkardex.nmonto = lnAbonoM 'lnintere
        '            entidadkardex.ccodctb = lcctactb
        '            entidadkardex.cconcep = "MO"
        '            entidadkardex.cdescob = "C"
        '            entidadkardex.ctippag = lctippag
        '            entidadkardex.cestado = " "
        '            entidadkardex.ctippag = lctippag
        '            entidadkardex.dfecsis = gdfecsis
        '            entidadkardex.dfecmod = Now
        '            entidadkardex.dfecpro = pdfecval
        '            entidadkardex.ccodusu = gccodusu
        '            entidadkardex.ccondic = "N"
        '            entidadkardex.cbanco = pcbanco
        '            entidadkardex.cnuming = pcnuming
        '            entidadkardex.cnuming0 = pcnuming0
        '            entidadkardex.ctrasctb = 1
        '            entidadkardex.ndiaatr = Me.pndiaatr
        '            entidadkardex.ccodofi = gccodofi
        '            entidadkardex.ccodins = gccodofi
        '            entidadkardex.cnrodoc = lcnrodoc

        '            'contabilidad
        '            lnnumlin = lnnumlin + 1
        '            entidadcntamov.ccodcta = lcctactb
        '            entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
        '            entidadcntamov.nhaber = lnAbonoM 'lnintere
        '            entidadcntamov.ndebe = 0
        '            entidadcntamov.ccodpres = lccodcta
        '            entidadcntamov.cnumdoc = pcnuming
        '            entidadcntamov.ccodofi = gccodofi
        '            entidadcntamov.cflc = " "
        '            entidadcntamov.dfeccnt = gdfecsis
        '            entidadcntamov.ccodusu1 = gccodusu
        '            entidadcntamov.ffondos = lccodfue
        '            entidadcntamov.cclase = Left(lcctactb, 1)
        '            entidadcntamov.cpoliza = "ING"
        '            entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

        '            entidadcntamov.ccodsec = "MO"
        '            entidadcntamov.cconcepto = "PAGO DE MORA"
        '            entidadcntamov.cnumpol = ""
        '            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '            entidadcntamov.ccodcli = lccodcli
        '            entidadcntamov.cnumrec = pcnuming0
        '            entidadcntamov.corden = lcnrodoc

        '            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
        '            oktransac = ecntamov.agregarCntamov(entidadcntamov)


        '        End If



        '    End If



        'End If '-------------finaliza interes moratorio-------------------------------------------------

        'mora
        Try
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "MO", lcdescob, lccondic, lctippag, pcbanco, lnmora, _
                                                    lnintcap, lndifint)
            End If
        Catch ex As Exception

        End Try
        If lcctactb = "*" Then
            oktransac = 2
            'Throw New Exception("Mesanje personalizado")
            'Return -1 'Error porque no existe 
        End If

        If lnmora > 0 And lnmonpag > 0 Then
           
            If lnmonpag > lnmora Then
                lnmonpag = Math.Round(lnmonpag - lnmora, 2)

                'Quitando el Iva de la Mora
                lniva_mora = lnmora - (lnmora / Me.gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnmora = Math.Round(lnmora - lniva_mora, 2)
                lniva_total = lniva_total + lniva_mora
            Else
                lnmora = lnmonpag
                lnmonpag = 0

                'Quitando el Iva de la Mora
                lniva_mora = lnmora - (lnmora / Me.gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnmora = Math.Round(lnmora - lniva_mora, 2)
                lniva_total = lniva_total + lniva_mora
            End If


            lnintmor = lnmora

            lntotapag = lntotapag + lnintmor
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnintmor
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "MO"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag.Trim
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cclipag = "0"
            'entidadkardex.cnrocuo = Me.ccodgar
            ecredkar.agregarCredkar(entidadkardex) ' graba

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnintmor
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.dfecmod = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "IN"

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE MORA"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.cnumrec = pcnuming0
            entidadcntamov.ccodcli = lccodcli
            ecntamov.agregarCntamov(entidadcntamov)

        End If


        'intereses
        If lctippag = "I" Then
            lcctactb = lccontra7
        Else
            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "R", "IN", lcdescob, lccondic, lctippag, pcbanco, lnintere, lnintcap, lndifint)
        End If
        If lcctactb = "*" Then
            oktransac = 2
            '    Return oktransac

        End If
        'Nuevo Tropi--------------------------------------------------------------------------------------------
        Dim lnIntAct As Double = 0
        Dim lnAbono As Double = 0

        If lctippag = "I" Then 'condonacion de interes normal
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Pago de Interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<
            If lnintere > 0 And lnmonpag > 0 Then
                If lnmonpag > lnintere Then
                    lnmonpag = lnmonpag - lnintere
                    'Quitando el Iva del Interes
                    lniva_interes = lnintere - (lnintere / Me.gniva)
                    lniva_interes = Math.Round(lniva_interes, 2)
                    lnintere = Math.Round(lnintere - lniva_interes, 2)
                    lniva_total = lniva_total + lniva_interes
                Else
                    lnintere = lnmonpag
                    lnmonpag = 0

                    'Quitando el Iva del Interes
                    lniva_interes = lnintere - (lnintere / Me.gniva)
                    lniva_interes = Math.Round(lniva_interes, 2)
                    lnintere = Math.Round(lnintere - lniva_interes, 2)
                    lniva_total = lniva_total + lniva_interes
                End If


                If lnintere > 0 Then 'Cobro de Interes

                    Dim lcctactbprov As String

                    If lctippag = "I" Then
                        lcctactbprov = lccontra7
                    Else
                        lcctactbprov = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "IN", lcdescob, "P", lctippag, pcbanco, _
                                                                lnintere, lnintcap, lndifint)
                    End If
                    If lcctactbprov = "*" Then
                        oktransac = 2
                    End If
                    lntotapag = lntotapag + lnintere

                    entidadkardex.ccodcta = pccodcta
                    entidadkardex.nmonto = lnintere
                    entidadkardex.ccodctb = lcctactbprov
                    entidadkardex.cconcep = "IN"
                    entidadkardex.cdescob = "C"
                    entidadkardex.ctippag = lctippag
                    entidadkardex.cestado = " "
                    entidadkardex.ctippag = lctippag
                    entidadkardex.dfecsis = gdfecsis
                    entidadkardex.dfecmod = Now
                    entidadkardex.dfecpro = pdfecval
                    entidadkardex.ccodusu = gccodusu
                    entidadkardex.ccondic = "P" 'lccondic
                    entidadkardex.cbanco = pcbanco
                    entidadkardex.cnuming = pcnuming
                    entidadkardex.cnuming0 = pcnuming0
                    entidadkardex.ctrasctb = 1
                    entidadkardex.ndiaatr = Me.pndiaatr
                    entidadkardex.ccodofi = gccodofi
                    entidadkardex.ccodins = gccodofi
                    entidadkardex.cnrodoc = lcnrodoc

                    'contabilidad
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lcctactbprov
                    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                    entidadcntamov.nhaber = lnintere
                    entidadcntamov.ndebe = 0
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = lccodfue
                    entidadcntamov.cclase = Left(lcctactbprov, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                    entidadcntamov.ccodsec = "IN"
                    entidadcntamov.cconcepto = "PAGO DE INTERES"
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.cnumrec = pcnuming0
                    entidadcntamov.corden = lcnrodoc
                    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

                    oktransac = ecntamov.agregarCntamov(entidadcntamov)


                    '--------------------------------------------------------------------------------------------
                End If


                'Dim lnintprov As Double = 0
                'lnintprov = clsppal.fxIntPro(pccodcta, lnintere, lcnrodoc)
                'If lnintprov > 0 Then 'Agrega el interes provisionado

                '    lnIntAct = lnintprov
                '    Dim lcctactbprov As String

                '    If lctippag = "I" Then
                '        lcctactbprov = lccontra7
                '    Else
                '        lcctactbprov = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "IN", lcdescob, "P", lctippag, pcbanco, lnintere, lnintcap, lndifint)
                '    End If
                '    If lcctactbprov = "*" Then
                '        oktransac = 2
                '    End If
                '    lntotapag = lntotapag + lnIntAct

                '    entidadkardex.ccodcta = pccodcta
                '    entidadkardex.nmonto = lnIntAct 'lnintere
                '    entidadkardex.ccodctb = lcctactbprov
                '    entidadkardex.cconcep = "IN"
                '    entidadkardex.cdescob = "C"
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.cestado = " "
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.dfecsis = gdfecsis
                '    entidadkardex.dfecmod = Now
                '    entidadkardex.dfecpro = pdfecval
                '    entidadkardex.ccodusu = gccodusu
                '    entidadkardex.ccondic = "P" 'lccondic
                '    entidadkardex.cbanco = pcbanco
                '    entidadkardex.cnuming = pcnuming
                '    entidadkardex.cnuming0 = pcnuming0
                '    entidadkardex.ctrasctb = 1
                '    entidadkardex.ndiaatr = Me.pndiaatr
                '    entidadkardex.ccodofi = gccodofi
                '    entidadkardex.ccodins = gccodofi
                '    entidadkardex.cnrodoc = lcnrodoc

                '    'contabilidad
                '    lnnumlin = lnnumlin + 1
                '    entidadcntamov.ccodcta = lcctactbprov
                '    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                '    entidadcntamov.nhaber = lnIntAct 'lnintere
                '    entidadcntamov.ndebe = 0
                '    entidadcntamov.ccodpres = lccodcta
                '    entidadcntamov.cnumdoc = pcnuming
                '    entidadcntamov.ccodofi = gccodofi
                '    entidadcntamov.cflc = " "
                '    entidadcntamov.dfeccnt = gdfecsis
                '    entidadcntamov.ccodusu1 = gccodusu
                '    entidadcntamov.ffondos = lccodfue
                '    entidadcntamov.cclase = Left(lcctactbprov, 1)
                '    entidadcntamov.cpoliza = "ING"
                '    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                '    entidadcntamov.ccodsec = "IN"
                '    entidadcntamov.cconcepto = "PAGO DE INTERES PROVISIONADO"
                '    entidadcntamov.cnumpol = ""
                '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                '    entidadcntamov.ccodcli = lccodcli
                '    entidadcntamov.cnumrec = pcnuming0
                '    entidadcntamov.corden = lcnrodoc
                '    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

                '    oktransac = ecntamov.agregarCntamov(entidadcntamov)


                '    '--------------------------------------------------------------------------------------------
                'End If

                'Interes No Provisionado

                'lnAbono = lnintere
                'lnAbono = IIf((lnAbono - lnintprov) > 0, (lnAbono - lnintprov), 0)
                'If lnAbono > 0 Then

                '    lntotapag = lntotapag + lnAbono
                '    entidadkardex.ccodcta = pccodcta
                '    entidadkardex.nmonto = lnAbono 'lnintere
                '    entidadkardex.ccodctb = lcctactb
                '    entidadkardex.cconcep = "IN"
                '    entidadkardex.cdescob = "C"
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.cestado = " "
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.dfecsis = gdfecsis
                '    entidadkardex.dfecmod = Now
                '    entidadkardex.dfecpro = pdfecval
                '    entidadkardex.ccodusu = gccodusu
                '    entidadkardex.ccondic = "N"
                '    entidadkardex.cbanco = pcbanco
                '    entidadkardex.cnuming = pcnuming
                '    entidadkardex.cnuming0 = pcnuming0
                '    entidadkardex.ctrasctb = 1
                '    entidadkardex.ndiaatr = Me.pndiaatr
                '    entidadkardex.ccodofi = gccodofi
                '    entidadkardex.ccodins = gccodofi
                '    entidadkardex.cnrodoc = lcnrodoc

                '    'contabilidad
                '    lnnumlin = lnnumlin + 1
                '    entidadcntamov.ccodcta = lcctactb
                '    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                '    entidadcntamov.nhaber = lnAbono 'lnintere
                '    entidadcntamov.ndebe = 0
                '    entidadcntamov.ccodpres = lccodcta
                '    entidadcntamov.cnumdoc = pcnuming
                '    entidadcntamov.ccodofi = gccodofi
                '    entidadcntamov.cflc = " "
                '    entidadcntamov.dfeccnt = gdfecsis
                '    entidadcntamov.ccodusu1 = gccodusu
                '    entidadcntamov.ffondos = lccodfue
                '    entidadcntamov.cclase = Left(lcctactb, 1)
                '    entidadcntamov.cpoliza = "ING"
                '    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                '    entidadcntamov.ccodsec = "IN"
                '    entidadcntamov.cconcepto = "PAGO DE INTERES"
                '    entidadcntamov.cnumpol = ""
                '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                '    entidadcntamov.ccodcli = lccodcli

                '    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
                '    entidadcntamov.cnumrec = pcnuming0
                '    entidadcntamov.corden = lcnrodoc
                '    oktransac = ecntamov.agregarCntamov(entidadcntamov)

                'End If

            End If

        Else
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Pago de Interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<
            If lnintere > 0 And lnmonpag > 0 Then
                'If lnmonpag > lnintere Then
                '    lnmonpag = lnmonpag - lnintere
                'Else
                '    lnintere = lnmonpag
                '    lnmonpag = 0
                'End If
                If lnmonpag > lnintere Then
                    lnmonpag = lnmonpag - lnintere
                    'Quitando el Iva del Interes
                    lniva_interes = lnintere - (lnintere / Me.gniva)
                    lniva_interes = Math.Round(lniva_interes, 2)
                    lnintere = Math.Round(lnintere - lniva_interes, 2)
                    lniva_total = lniva_total + lniva_interes
                Else
                    lnintere = lnmonpag
                    lnmonpag = 0

                    'Quitando el Iva del Interes
                    lniva_interes = lnintere - (lnintere / Me.gniva)
                    lniva_interes = Math.Round(lniva_interes, 2)
                    lnintere = Math.Round(lnintere - lniva_interes, 2)
                    lniva_total = lniva_total + lniva_interes
                End If

                If lccondic = "S" Then
                    entidadtabtmak.ccodigo = "CINXS"
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lctaespecial = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lctaespecial = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
                    End If
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lctaespecial
                    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                    entidadcntamov.nhaber = lnintere 'lnintere
                    entidadcntamov.ndebe = 0
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = lccodfue
                    entidadcntamov.cclase = Left(lctaespecial, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                    entidadcntamov.ccodsec = "IN"
                    entidadcntamov.cconcepto = "PAGO DE INTERES/CASTIGADO"
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.cnumrec = pcnuming0
                    entidadcntamov.corden = lcnrodoc
                    oktransac = ecntamov.agregarCntamov(entidadcntamov)

                End If


                If lnintere > 0 Then 'Cobro de Interes

                    Dim lcctactbprov As String

                    If lctippag = "I" Then
                        lcctactbprov = lccontra7
                    Else
                        lcctactbprov = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "IN", lcdescob, "P", lctippag, pcbanco, _
                                                                lnintere, lnintcap, lndifint)
                    End If

                    If lcctactbprov = "*" Then
                        oktransac = 2
                    End If
                    lntotapag = lntotapag + lnintere

                    entidadkardex.ccodcta = pccodcta
                    entidadkardex.nmonto = lnintere
                    entidadkardex.ccodctb = lcctactbprov
                    entidadkardex.cconcep = "IN"
                    entidadkardex.cdescob = "C"
                    entidadkardex.ctippag = lctippag
                    entidadkardex.cestado = " "
                    entidadkardex.ctippag = lctippag
                    entidadkardex.dfecsis = gdfecsis
                    entidadkardex.dfecmod = Now
                    entidadkardex.dfecpro = pdfecval
                    entidadkardex.ccodusu = gccodusu
                    entidadkardex.ccondic = "P" 'lccondic
                    entidadkardex.cbanco = pcbanco
                    entidadkardex.cnuming = pcnuming
                    entidadkardex.cnuming0 = pcnuming0
                    entidadkardex.ctrasctb = 1
                    entidadkardex.ndiaatr = Me.pndiaatr
                    entidadkardex.ccodofi = gccodofi
                    entidadkardex.ccodins = gccodofi
                    entidadkardex.cnrodoc = lcnrodoc

                    'contabilidad
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lcctactbprov
                    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                    entidadcntamov.nhaber = lnintere
                    entidadcntamov.ndebe = 0
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = lccodfue
                    entidadcntamov.cclase = Left(lcctactbprov, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                    entidadcntamov.ccodsec = "IN"
                    entidadcntamov.cconcepto = "PAGO DE INTERES"
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.cnumrec = pcnuming0
                    entidadcntamov.corden = lcnrodoc
                    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

                    oktransac = ecntamov.agregarCntamov(entidadcntamov)


                    '--------------------------------------------------------------------------------------------
                End If


                'Dim lnintprov As Double = 0
                'lnintprov = clsppal.fxIntPro(pccodcta, lnintere, lcnrodoc)
                'If lnintprov > 0 Then 'Agrega el interes provisionado

                '    lnIntAct = lnintprov
                '    Dim lcctactbprov As String

                '    If lctippag = "I" Then
                '        lcctactbprov = lccontra7
                '    Else
                '        lcctactbprov = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "IN", lcdescob, "P", lctippag, pcbanco, lnintere, lnintcap, lndifint)
                '    End If
                '    If lcctactbprov = "*" Then
                '        oktransac = 2
                '    End If
                '    lntotapag = lntotapag + lnIntAct

                '    entidadkardex.ccodcta = pccodcta
                '    entidadkardex.nmonto = lnIntAct 'lnintere
                '    entidadkardex.ccodctb = lcctactbprov
                '    entidadkardex.cconcep = "IN"
                '    entidadkardex.cdescob = "C"
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.cestado = " "
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.dfecsis = gdfecsis
                '    entidadkardex.dfecmod = Now
                '    entidadkardex.dfecpro = pdfecval
                '    entidadkardex.ccodusu = gccodusu
                '    entidadkardex.ccondic = "P" 'lccondic
                '    entidadkardex.cbanco = pcbanco
                '    entidadkardex.cnuming = pcnuming
                '    entidadkardex.cnuming0 = pcnuming0
                '    entidadkardex.ctrasctb = 1
                '    entidadkardex.ndiaatr = Me.pndiaatr
                '    entidadkardex.ccodofi = gccodofi
                '    entidadkardex.ccodins = gccodofi
                '    entidadkardex.cnrodoc = lcnrodoc

                '    'contabilidad
                '    lnnumlin = lnnumlin + 1
                '    entidadcntamov.ccodcta = lcctactbprov
                '    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                '    entidadcntamov.nhaber = lnIntAct 'lnintere
                '    entidadcntamov.ndebe = 0
                '    entidadcntamov.ccodpres = lccodcta
                '    entidadcntamov.cnumdoc = pcnuming
                '    entidadcntamov.ccodofi = gccodofi
                '    entidadcntamov.cflc = " "
                '    entidadcntamov.dfeccnt = gdfecsis
                '    entidadcntamov.ccodusu1 = gccodusu
                '    entidadcntamov.ffondos = lccodfue
                '    entidadcntamov.cclase = Left(lcctactbprov, 1)
                '    entidadcntamov.cpoliza = "ING"
                '    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                '    entidadcntamov.ccodsec = "IN"
                '    entidadcntamov.cconcepto = "PAGO DE INTERES PROVISIONADO"
                '    entidadcntamov.cnumpol = ""
                '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                '    entidadcntamov.ccodcli = lccodcli
                '    entidadcntamov.cnumrec = pcnuming0
                '    entidadcntamov.corden = lcnrodoc
                '    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

                '    If lccondic = "S" Then
                '    Else
                '        ecntamov.agregarCntamov(entidadcntamov)
                '    End If

                '    'Movimiento Regularizador----------------------------------------------
                '    entidadtabtmak.ccodigo = "CINFN"
                '    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                '    If busquedaplantilla = 0 Then
                '        lcctactb = "*"
                '    Else
                '        cplanti = entidadtabtmak.cplanti.Trim
                '        lcctactb = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
                '    End If
                '    lnnumlin = lnnumlin + 1
                '    entidadcntamov.ccodcta = lcctactb
                '    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                '    entidadcntamov.nhaber = 0
                '    entidadcntamov.ndebe = lnIntAct 'lnintere
                '    entidadcntamov.ccodpres = lccodcta
                '    entidadcntamov.cnumdoc = pcnuming
                '    entidadcntamov.ccodofi = gccodofi
                '    entidadcntamov.cflc = " "
                '    entidadcntamov.dfeccnt = gdfecsis
                '    entidadcntamov.ccodusu1 = gccodusu
                '    entidadcntamov.ffondos = lccodfue
                '    entidadcntamov.cclase = Left(lcctactb, 1)
                '    entidadcntamov.cpoliza = "ING"
                '    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                '    entidadcntamov.ccodsec = "IN"
                '    entidadcntamov.cconcepto = "INTERES REGULARIZADO"
                '    entidadcntamov.cnumpol = ""
                '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                '    entidadcntamov.ccodcli = lccodcli
                '    entidadcntamov.cnumrec = pcnuming0
                '    entidadcntamov.corden = lcnrodoc


                '    If lccondic = "S" Then
                '    Else
                '        ecntamov.agregarCntamov(entidadcntamov)
                '    End If
                '    If lccondic.Trim = "S" Then
                '        entidadtabtmak.ccodigo = "CINNS"
                '    Else
                '        entidadtabtmak.ccodigo = "CINING"
                '    End If


                '    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                '    If busquedaplantilla = 0 Then
                '        lcctactb = "*"
                '    Else
                '        cplanti = entidadtabtmak.cplanti.Trim
                '        lcctactb = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
                '    End If
                '    lnnumlin = lnnumlin + 1
                '    entidadcntamov.ccodcta = lcctactb
                '    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                '    entidadcntamov.nhaber = lnIntAct 'lnintere
                '    entidadcntamov.ndebe = 0
                '    entidadcntamov.ccodpres = lccodcta
                '    entidadcntamov.cnumdoc = pcnuming
                '    entidadcntamov.ccodofi = gccodofi
                '    entidadcntamov.cflc = " "
                '    entidadcntamov.dfeccnt = gdfecsis
                '    entidadcntamov.ccodusu1 = gccodusu
                '    entidadcntamov.ffondos = lccodfue
                '    entidadcntamov.cclase = Left(lcctactb, 1)
                '    entidadcntamov.cpoliza = "ING"
                '    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                '    entidadcntamov.ccodsec = "IN"
                '    entidadcntamov.cconcepto = "INTERES REGULARIZADO"
                '    entidadcntamov.cnumpol = ""
                '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                '    entidadcntamov.ccodcli = lccodcli
                '    entidadcntamov.cnumrec = pcnuming0
                '    entidadcntamov.corden = lcnrodoc
                '    oktransac = ecntamov.agregarCntamov(entidadcntamov)

                '    '--------------------------------------------------------------------------------------------
                'End If

                ''Interes No Provisionado

                'lnAbono = lnintere
                'lnAbono = IIf((lnAbono - lnintprov) > 0, (lnAbono - lnintprov), 0)
                'If lnAbono > 0 Then

                '    lntotapag = lntotapag + lnAbono
                '    entidadkardex.ccodcta = pccodcta
                '    entidadkardex.nmonto = lnAbono 'lnintere
                '    entidadkardex.ccodctb = lcctactb
                '    entidadkardex.cconcep = "IN"
                '    entidadkardex.cdescob = "C"
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.cestado = " "
                '    entidadkardex.ctippag = lctippag
                '    entidadkardex.dfecsis = gdfecsis
                '    entidadkardex.dfecmod = Now
                '    entidadkardex.dfecpro = pdfecval
                '    entidadkardex.ccodusu = gccodusu
                '    entidadkardex.ccondic = "N"
                '    entidadkardex.cbanco = pcbanco
                '    entidadkardex.cnuming = pcnuming
                '    entidadkardex.cnuming0 = pcnuming0
                '    entidadkardex.ctrasctb = 1
                '    entidadkardex.ndiaatr = Me.pndiaatr
                '    entidadkardex.ccodofi = gccodofi
                '    entidadkardex.ccodins = gccodofi
                '    entidadkardex.cnrodoc = lcnrodoc

                '    'contabilidad
                '    lnnumlin = lnnumlin + 1
                '    entidadcntamov.ccodcta = lcctactb
                '    entidadcntamov.cnumlin = lnnumlin 'ecntamov.ObtenerLinea(lcnumcom)
                '    entidadcntamov.nhaber = lnAbono 'lnintere
                '    entidadcntamov.ndebe = 0
                '    entidadcntamov.ccodpres = lccodcta
                '    entidadcntamov.cnumdoc = pcnuming
                '    entidadcntamov.ccodofi = gccodofi
                '    entidadcntamov.cflc = " "
                '    entidadcntamov.dfeccnt = gdfecsis
                '    entidadcntamov.ccodusu1 = gccodusu
                '    entidadcntamov.ffondos = lccodfue
                '    entidadcntamov.cclase = Left(lcctactb, 1)
                '    entidadcntamov.cpoliza = "ING"
                '    entidadcntamov.dfecmod = gdfecsis + " " + Now.TimeOfDay.ToString

                '    entidadcntamov.ccodsec = "IN"
                '    entidadcntamov.cconcepto = "PAGO DE INTERES"
                '    entidadcntamov.cnumpol = ""
                '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                '    entidadcntamov.ccodcli = lccodcli

                '    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
                '    entidadcntamov.cnumrec = pcnuming0
                '    entidadcntamov.corden = lcnrodoc
                '    oktransac = ecntamov.agregarCntamov(entidadcntamov)

                'End If

            End If

        End If


        'Iva Interes Moratorio
        If lniva_mora > 0 Then
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "IM", lcdescob, lccondic, lctippag, pcbanco, lniva_mora, _
                                                    lnintcap, lndifint)
            End If

            If lcctactb = "*" Then
                oktransac = 2
            End If
            '    Return oktransac
            'Es para que no incluya en el pago el movimiento sin cuenta
            'y no descuadre la partida
            'lntotapag = lntotapag + lnmonpag
            'Else

            lntotapag = lntotapag + lniva_mora
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lniva_mora
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "IM"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lniva_mora
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = "IM"
            entidadcntamov.cconcepto = "IVA MORA"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
            entidadcntamov.corden = lcnrodoc
            entidadcntamov.cnumrec = pcnuming0

            oktransac = ecntamov.agregarCntamov(entidadcntamov)
            ' End If

        End If

        'Iva Interes Normal
        If lniva_interes > 0 Then
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "08", lcdescob, lccondic, lctippag, pcbanco, lniva_interes, _
                                                    lnintcap, lndifint)
            End If

            If lcctactb = "*" Then
                oktransac = 2
            End If
            '    Return oktransac
            'Es para que no incluya en el pago el movimiento sin cuenta
            'y no descuadre la partida
            'lntotapag = lntotapag + lnmonpag
            'Else

            lntotapag = lntotapag + lniva_interes
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lniva_interes
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "08"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lniva_interes
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = "08"
            entidadcntamov.cconcepto = "IVA INTERES"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
            entidadcntamov.corden = lcnrodoc
            entidadcntamov.cnumrec = pcnuming0

            oktransac = ecntamov.agregarCntamov(entidadcntamov)
            ' End If

        End If

        'Iva total Comentariado se separara
        'If lniva_total > 0 Then
        '    If lctippag = "I" Then
        '        lcctactb = lccontra8
        '    Else
        '        lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "08", lcdescob, lccondic, lctippag, pcbanco, lniva_total, _
        '                                            lnintcap, lndifint)
        '    End If

        '    If lcctactb = "*" Then
        '        oktransac = 2
        '    End If
        '    '    Return oktransac
        '    'Es para que no incluya en el pago el movimiento sin cuenta
        '    'y no descuadre la partida
        '    'lntotapag = lntotapag + lnmonpag
        '    'Else

        '    lntotapag = lntotapag + lniva_total
        '    entidadkardex.ccodcta = pccodcta
        '    entidadkardex.nmonto = lniva_total
        '    entidadkardex.ccodctb = lcctactb
        '    entidadkardex.cconcep = "08"
        '    entidadkardex.cdescob = "C"
        '    entidadkardex.ctippag = lctippag
        '    entidadkardex.cestado = " "
        '    entidadkardex.ctippag = lctippag
        '    entidadkardex.dfecsis = gdfecsis
        '    entidadkardex.dfecmod = Now()
        '    entidadkardex.dfecpro = pdfecval
        '    entidadkardex.ccodusu = gccodusu
        '    entidadkardex.ccondic = "N"
        '    entidadkardex.cbanco = pcbanco
        '    entidadkardex.cnuming = pcnuming
        '    entidadkardex.cnuming0 = pcnuming0
        '    entidadkardex.ctrasctb = 1
        '    entidadkardex.ndiaatr = Me.pndiaatr
        '    entidadkardex.ccodofi = gccodofi
        '    entidadkardex.ccodins = gccodofi
        '    entidadkardex.cnrodoc = lcnrodoc
        '    entidadkardex.cclipag = "0"
        '    entidadkardex.lsolidario = lsolidario
        '    'contabilidad
        '    lnnumlin = lnnumlin + 1
        '    entidadcntamov.ccodcta = lcctactb
        '    entidadcntamov.cnumlin = lnnumlin
        '    entidadcntamov.nhaber = lniva_total
        '    entidadcntamov.ndebe = 0
        '    entidadcntamov.ccodpres = lccodcta
        '    entidadcntamov.cnumdoc = pcnuming
        '    entidadcntamov.ccodofi = gccodofi
        '    entidadcntamov.cflc = " "
        '    entidadcntamov.dfeccnt = gdfecsis
        '    entidadcntamov.ccodusu1 = gccodusu
        '    entidadcntamov.ffondos = lccodfue
        '    entidadcntamov.cclase = Left(lcctactb, 1)
        '    entidadcntamov.cpoliza = "ING"
        '    entidadcntamov.dfecmod = gdfecsis

        '    entidadcntamov.ccodsec = "08"
        '    entidadcntamov.cconcepto = "IVA TOTAL"
        '    entidadcntamov.cnumpol = ""
        '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '    entidadcntamov.ccodcli = lccodcli

        '    oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
        '    entidadcntamov.corden = lcnrodoc
        '    entidadcntamov.cnumrec = pcnuming0

        '    oktransac = ecntamov.agregarCntamov(entidadcntamov)
        '    ' End If

        'End If


        '-------------------------------------------------------------------------------------------------------

        'capital
        Dim lnpagocap As Double
        lnpagocap = 0
        If lccondic = "S" Then
            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "KP", lcdescob, lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
        Else
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "KP", lcdescob, lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
            End If

        End If

        If lcctactb = "*" Then
            oktransac = 2
            ' Return oktransac

        End If

        If lndeutot > 0 And lnmonpag > 0 Then
            If lndeutot > lnmonpag Then
                lnpagocap = lnmonpag
                lnmonpag = 0
            Else
                lnpagocap = lndeutot
                lnmonpag = lnmonpag - lnpagocap
            End If
            lntotapag = lntotapag + lnpagocap
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnpagocap
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "KP"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnpagocap
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = "KP"
            entidadcntamov.cconcepto = "PAGO DE CAPITAL"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.cnumrec = pcnuming0

            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
            entidadcntamov.corden = lcnrodoc
            oktransac = ecntamov.agregarCntamov(entidadcntamov)

            '---
            If lccondic = "S" Then
                entidadtabtmak.ccodigo = "CKPXS"
                busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                If busquedaplantilla = 0 Then
                    lctaespecial = "*"
                Else
                    cplanti = entidadtabtmak.cplanti.Trim
                    lctaespecial = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
                End If

                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lctaespecial
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = lnpagocap
                entidadcntamov.ndebe = 0
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lctaespecial, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = "KP"
                entidadcntamov.cconcepto = "PAGO DE CAPITAL/CASTIGADO"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli
                entidadcntamov.cnumrec = pcnuming0
                entidadcntamov.corden = lcnrodoc
                oktransac = ecntamov.agregarCntamov(entidadcntamov)
            End If
            '----
        End If

        'excedentes se contabilizara como ahorro a la vista, en otras versiones poner EX
        If lnmonpag > 0 Then
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "EX", lcdescob, lccondic, lctippag, pcbanco, lnmonpag, lnintcap, lndifint)
            End If
            If lcctactb = "*" Then
                oktransac = 2
            End If
            '    Return oktransac
            'Es para que no incluya en el pago el movimiento sin cuenta
            'y no descuadre la partida
            'lntotapag = lntotapag + lnmonpag
            'Else

            lntotapag = lntotapag + lnmonpag
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnmonpag
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "EX"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnmonpag
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = "EX"
            entidadcntamov.cconcepto = "EXCEDENTE DE CUOTA"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba
            entidadcntamov.corden = lcnrodoc
            entidadcntamov.cnumrec = pcnuming0

            oktransac = ecntamov.agregarCntamov(entidadcntamov)
            ' End If

        End If

        'actualiza el cj **** mxupdatecaja  ****
        If lntotapag > 0 Then ' monto total pagado

            If lctippag = "I" Then
                lcctactb = lccontra7
            Else
                If pccolector.ToString = "2" Then  'Corresponsales Electronicos /Paynet
                    lcctactb = Me.gcpuente
                Else
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "CJ", lcdescob, lccondic, lctippag, pcbanco, lnmonpag, lnintcap, lndifint)
                End If

            End If
            If lcctactb = "*" Then
                oktransac = 2
            End If

            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = Math.Round(lntotapag, 2)
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "CJ"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

            'Aplica distribucion diferente cuando sea interes normal e interes moratorio
            'contabilidad
            If lctippag = "I" Then
                If Me.pnsalmor > 0 Then
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lccontra8a
                    entidadcntamov.cnumlin = lnnumlin
                    entidadcntamov.nhaber = 0
                    entidadcntamov.ndebe = Math.Round(pnsalmor, 2) 'lntotapag
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = lccodfue
                    entidadcntamov.cclase = Left(lccontra8a, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis

                    entidadcntamov.ccodsec = "CJ"
                    entidadcntamov.cconcepto = "REGISTRO DE CAJA"
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.corden = lcnrodoc
                    entidadcntamov.cnumrec = pcnuming0
                    oktransac = ecntamov.agregarCntamov(entidadcntamov)

                End If
                If Me.pnsalint > 0 Then
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lccontra7a
                    entidadcntamov.cnumlin = lnnumlin
                    entidadcntamov.nhaber = 0
                    entidadcntamov.ndebe = Math.Round(pnsalint, 2) 'lntotapag
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = lccodfue
                    entidadcntamov.cclase = Left(lccontra7a, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis

                    entidadcntamov.ccodsec = "CJ"
                    entidadcntamov.cconcepto = "REGISTRO DE CAJA"
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.corden = lcnrodoc
                    entidadcntamov.cnumrec = pcnuming0
                    oktransac = ecntamov.agregarCntamov(entidadcntamov)
                End If

            Else
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = 0
                entidadcntamov.ndebe = Math.Round(lntotapag, 2) 'lntotapag
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = "CJ"
                entidadcntamov.cconcepto = "REGISTRO DE CAJA"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli

                entidadcntamov.cnumrec = pcnuming0
                entidadcntamov.corden = lcnrodoc
                oktransac = ecntamov.agregarCntamov(entidadcntamov)


            End If

            If lccondic = "S" Then
                entidadtabtmak.ccodigo = "CCJXS"
                busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                If busquedaplantilla = 0 Then
                    lctaespecial = "*"
                Else
                    cplanti = entidadtabtmak.cplanti.Trim
                    lctaespecial = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
                End If
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lctaespecial
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = 0
                entidadcntamov.ndebe = Math.Round(lntotapag, 2)
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lctaespecial, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = "CJ"
                entidadcntamov.cconcepto = "REGISTRO DE CAJA/CASTIGADOS"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli

                entidadcntamov.cnumrec = pcnuming0
                entidadcntamov.corden = lcnrodoc
                oktransac = ecntamov.agregarCntamov(entidadcntamov)

            End If
        End If
        'Agregar Cuentas Especiales ---------------------------------->

        'If lccondic.Trim = "S" Then
        '    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "OR2", lcdescob, "N", lctippag, pcbanco, lnmonpag, lnintcap, lndifint)
        '    'contabilidad
        '    lnnumlin = lnnumlin + 1
        '    entidadcntamov.ccodcta = lcctactb
        '    entidadcntamov.cnumlin = lnnumlin
        '    entidadcntamov.ndebe = (lnpagocap + lnAbono + lnIntAct + lnintmor)
        '    entidadcntamov.nhaber = 0
        '    entidadcntamov.ccodpres = lccodcta
        '    entidadcntamov.cnumdoc = pcnuming
        '    entidadcntamov.ccodofi = gccodofi
        '    entidadcntamov.cflc = " "
        '    entidadcntamov.dfeccnt = gdfecsis
        '    entidadcntamov.ccodusu1 = gccodusu
        '    entidadcntamov.ffondos = lccodfue
        '    entidadcntamov.cclase = Left(lccodcta, 1)
        '    entidadcntamov.cpoliza = "ING"
        '    entidadcntamov.dfecmod = gdfecsis

        '    entidadcntamov.ccodsec = ""
        '    entidadcntamov.cconcepto = "CUENTA DE ORDEN"
        '    entidadcntamov.cnumpol = ""
        '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '    entidadcntamov.ccodcli = lccodcli
        '    entidadcntamov.corden = lcnrodoc
        '    oktransac = ecntamov.agregarCntamov(entidadcntamov)

        '    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "OR1", lcdescob, "N", lctippag, pcbanco, lnmonpag, lnintcap, lndifint)
        '    'contabilidad
        '    lnnumlin = lnnumlin + 1
        '    entidadcntamov.ccodcta = lcctactb
        '    entidadcntamov.cnumlin = lnnumlin
        '    entidadcntamov.ndebe = 0
        '    entidadcntamov.nhaber = (lnpagocap + lnAbono + lnIntAct + lnintmor)
        '    entidadcntamov.ccodpres = lccodcta
        '    entidadcntamov.cnumdoc = pcnuming
        '    entidadcntamov.ccodofi = gccodofi
        '    entidadcntamov.cflc = " "
        '    entidadcntamov.dfeccnt = gdfecsis
        '    entidadcntamov.ccodusu1 = gccodusu
        '    entidadcntamov.ffondos = lccodfue
        '    entidadcntamov.cclase = Left(lccodcta, 1)
        '    entidadcntamov.cpoliza = "ING"
        '    entidadcntamov.dfecmod = gdfecsis

        '    entidadcntamov.ccodsec = ""
        '    entidadcntamov.cconcepto = "CUENTA DE ORDEN"
        '    entidadcntamov.cnumpol = ""
        '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '    entidadcntamov.ccodcli = lccodcli
        '    entidadcntamov.corden = lcnrodoc
        '    oktransac = ecntamov.agregarCntamov(entidadcntamov)

        'End If
        '<<<<<<<<<<<<<<<<<<--------------------------------------------


        'ACTUALIZA NUMLIN EN LA CNTAMOV, PORQUE SON PAGOS Y CONTINUARA DONDE SE QUEDO
        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNNUMLIN"
        etabtvar.lcarini = True

        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.cconvar = lnnumlin.ToString.Trim
        etabtvar.cdesvar = "NUMERO DE REGISTRO EN LA CNTAMOV"
        etabtvar.ctipvar = "C"
        etabtvar.ccodusu = Me.lccodusu1
        etabtvar.cflag = ""
        mtabtvar.ActualizarTabtvar(etabtvar)
        ' FIN DE ACTUALIZACION DE NUMLIN EN LA DE PAGOS


        'actualiza tablas creditos
        'mxupdatetmp
        Dim lncapdes As Double
        Dim lcestado As String
        Dim ldfecter As Date
        Dim ldultpag As Date
        Dim pdultima As Date
        Dim lnintpen As Double
        Dim lnpagcta As Double
        Dim lnmorpag As Double
        Dim lncappag As Double
        Dim lngaspag As Double
        Dim resultadocremcre As Integer
        Dim ldfecapr As Date
        Dim ldfectra As Date


        lnintpen = 0
        lnpagcta = 0
        lnmorpag = 0

        lncapdes = entidad1.ncapdes
        ldfecapr = entidad1.dfecapr
        ldfectra = entidad1.dfectra

        If Math.Round(entidad1.ncapdes, 2) <= Math.Round(entidad1.ncappag + lnpagocap, 2) Then
            lcestado = "G"
        Else
            lcestado = entidad1.cestado
        End If
        If lcestado = "G" Then
            ldfecter = pdfecval
        End If
        If lnpagocap > 0 Then
            ldultpag = pdfecval
        Else
            ldultpag = entidad1.dultpag
        End If
        If entidad1.dultpag = Nothing Then
            pdultima = entidad1.dfecvig
        Else
            pdultima = entidad1.dultpag
        End If

        If entidad1.nintpag + entidad1.nintpen + lnintere >= entidad1.nintcal Then
            lnintpag = entidad1.nintpag + entidad1.nintpen + lnintere
        Else
            lnintpag = entidad1.nintpag
            lnintpen = lnintpen + lnintere
        End If

        If entidad1.nmorpag + entidad1.npagcta + lnintmor >= entidad1.nintmor Then
            lnmorpag = entidad1.nmorpag + entidad1.npagcta + lnintmor
        Else
            lnmorpag = entidad1.nmorpag
            lnpagcta = lnpagcta + lnintmor
        End If
        lncappag = entidad1.ncappag + lnpagocap
        lngaspag = entidad1.ngaspag + lngastot

        entidad1.ncappag = lncappag
        entidad1.nintpag = lnintpag
        entidad1.nintpen = lnintpen
        entidad1.nmorpag = lnmorpag
        entidad1.npagcta = lnpagcta
        entidad1.ngaspag = lngaspag
        entidad1.cestado = lcestado
        entidad1.dfecter = ldfecter
        entidad1.dultpag = ldultpag
        entidad1.dfecmod = gdfecsis
        entidad1.dfecasi = gdfecsis
        entidad1.dfecadm = gdfecsis
        entidad1.dfecapr = ldfecapr
        entidad1.dfecter = gdfecsis
        entidad1.dfecadm = gdfecsis
        entidad1.dfectra = ldfectra
        entidad1.lctaret = 1
        entidad1.cflag = "1"
        entidad1.cflag = ""
        'entidad1.dfectra = gdfecsis
        ecreditos.ActualizarCremcre(entidad1)
        Return 1
        ' Catch
        '   End Try

    End Function

    'Funcion exclusiva para Ajustes de creditos NO CALCULA
    Public Function mxdistributeAjuste(ByVal tipo As String) As String
        Dim utilnuemeros As New utilNumeros
        'temporalmente 
        Dim gccodofi As String = Mid(Me.pccodcta, 4, 3)


        Dim a As String
        Dim lccodcta As String = Me.pccodcta
        Dim lncapita As Double = Math.Round(Me.pncapita, 2)
        Dim lnintere As Double = Math.Round(Me.pnsalint, 2)
        Dim lnmora As Double = Math.Round(Me.pnsalmor, 2)
        Dim lncomision As Double = Math.Round(Me.pncomision, 2)
        Dim lnhonorarios As Double = Math.Round(Me.pnhonorarios, 2)
        Dim lnmanejo As Double = Math.Round(Me.manejo, 2)
        Dim lnahosim As Double = Math.Round(Me.ahosim, 2)
        Dim lnahovis As Double = Math.Round(Me.ahovis, 2)
        Dim lnaporta As Double = Math.Round(Me.aporta, 2)
        Dim lnsegdeu As Double = Math.Round(Me.segdeu, 2)
        Dim lsolidario As Boolean = Me.lsolidario

        Dim lngestion As Double = Math.Round(Me.pngestion, 2)
        Dim lnmonpag As Double = Math.Round(Me.pnmonpag, 2)
        Dim ldfecval As Date = Me.pdfecval
        Dim lndeutot As Double = Math.Round(Me.pndeucap, 2)
        Dim lcbanco As String = Me.pcbanco
        Dim lnintmor As Double
        Dim lntotapag As Double = 0
        Dim lcnrodoc As String
        '        Dim kardex As DataTable
        Dim crefunc As New SIM.BL.crefunc
        '       Dim cre As New DataSet
        Dim lcctactb As String
        'variables necesitadas para la clase
        Dim lctippag As String
        Dim lnmonto As Double
        Dim lnintpag As Double
        Dim lndifint As Double
        Dim lcnorref As String
        Dim lccodlin As String
        Dim lcconcep As String
        Dim lcdescob As String
        Dim lccondic As String
        Dim lcnrolin As String
        Dim lnintcap As Double
        Dim ldfecsis As Date
        Dim lccodusu As String
        Dim lngastot As Double
        Dim lnnumlin As Integer

        Dim lccodfue As String
        'actualiza tablas de contabilidad
        Dim lcnumcom As String
        Dim ok As Integer
        Dim tamano As Integer
        Dim i As Integer
        Dim lnlinaho As Integer


        'obtiene el numero de partida
        lcnumcom = clase.fxStevo(gdfecsis)


        'temporalmente
        lndifint = 0
        lnintcap = 0
        lctippag = pctippag.Trim
        'Genera las cuentas de orden para cuando exista Condonaciones>>>>>
        Dim lccontra7 As String = "*"
        Dim lccontra8 As String = "*"
        If lctippag = "I" Then
            Dim entidadtabtmak As New SIM.EL.tabtmak
            Dim etabtmak As New SIM.BL.cTabtmak
            Dim busquedaplantilla As Integer
            Dim cplanti As String

            entidadtabtmak.ccodigo = "CNICS7"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra7 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra7 = cplanti
            End If

            entidadtabtmak.ccodigo = "CNICS8"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra8 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra8 = cplanti
            End If
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        lngastot = 0

        '   Try
        'abre las colecciones para tomar otros datos que hacen falta
        'en las tablas de las colecciones

        'cremcre
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre
        entidad1.ccodcta = lccodcta
        ecreditos.ObtenerCremcre(entidad1)

        gccodofi = entidad1.coficina

        'credkar
        Dim ecredkar As New SIM.BL.cCredkar
        Dim entidadkardex As New SIM.EL.credkar

        'cntamov
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        entidadcntamov.cnumcom = lcnumcom

        'diario
        Dim entidaddiario As New SIM.EL.diario
        Dim ediario As New SIM.BL.cDiario
        entidaddiario.cnumcom = lcnumcom

        'ahorros
        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov

        Dim lccodaho As String
        Dim lnsaldoaho As Double
        Dim lnnewsalaho As Double

        'actualiza tabla de comprobantes
        Dim mtabtvar As New cTabtvar
        Dim etabtvar As New tabtvar

        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNCORRELA"
        etabtvar.lcarini = True
        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.cconvar = Me.pcnuming0
        mtabtvar.ActualizarTabtvar(etabtvar)
        '        GNNUMLIN


        'obtendra el numero de linea donde va en la digitacion de la partida de ingresos
        'etabtvar.ccodapl = "CRE"
        'etabtvar.cnomvar = "GNNUMLIN"
        'etabtvar.lcarini = True
        'mtabtvar.ObtenerTabtvar(etabtvar)
        lnnumlin = 0 'Integer.Parse(etabtvar.cconvar)


        'obtiene numero de documento
        lcnrodoc = ecredkar.obtenercnrodoc(pccodcta)
        If lcnrodoc = Nothing Then
            lcnrodoc = "002"
        End If
        tamano = lcnrodoc.Trim.Length
        For i = 1 To 3 - tamano
            lcnrodoc = "0" & lcnrodoc
        Next


        lcconcep = "C"
        lcdescob = "C"
        lccondic = entidad1.ccondic
        lcnrolin = entidad1.cnrolin

        lcnorref = entidad1.cnorref

        Dim ecretlin As New cCretlin




        'carga propiedades
        entidad1.nintpag = Me.pnintpag
        entidad1.nintpen = Me.pnintpen
        entidad1.nintcal = Me.pnintcal
        entidad1.nmorpag = Me.pnmorpag
        entidad1.npagcta = Me.pnpagcta
        entidad1.nintmor = Me.pnintmor
        entidad1.dultpag = Me.pdultpag
        entidad1.ncappag = Me.pncappag


        'cretlin
        Dim entidad2 As New SIM.EL.cretlin

        entidad2.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidad2)

        lccodlin = entidad2.ccodlin
        lccodfue = clssdes.ConvertidorFondos(lccodlin.Trim.Substring(2, 2)) 'entidad1.ccodfue

        Dim siexiste As Boolean
        'inicia rutina de grabado en tablas
        '**************************  DATOS **********************
        '******************    agrega a la diario ***************

        'localiza si ya existe ese numero de partida en la diario,
        'de lo contrario ya no lo agregara
        siexiste = ediario.siexistepartida(lcnumcom)
        If siexiste = False Then 'si ya existe no es necesario agregarlo en la diario
            entidaddiario.cnumcom = lcnumcom
            entidaddiario.cglosa = "Ajuste de Crédito. No. " & lccodcta & " Nota No. " & pcnuming
            entidaddiario.cnumdoc = pcnuming
            entidaddiario.dfeccnt = gdfecsis
            entidaddiario.cestado = " "
            entidaddiario.ccodofi = gccodofi
            entidaddiario.ffondos = lccodfue
            entidaddiario.dfecdoc = gdfecsis
            entidaddiario.dfecmod = gdfecsis
            ediario.agregarDiario(entidaddiario)
        End If
        Dim lcnomcli As String = ""
        Dim ecremcre As New cCremcre
        lcnomcli = ecremcre.ObtenerNombrexCuenta(lccodcta)

        'mora

        Try
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "MO", lcdescob, lccondic, lctippag, pcbanco, lnmora, lnintcap, lndifint)
            End If
        Catch ex As Exception

        End Try
        If lcctactb = "*" Then
            oktransac = 2
            'Throw New Exception("Mesanje personalizado")
            'Return -1 'Error porque no existe 
        End If
        'mora
        If lnmora <> 0 Then
            lntotapag = lntotapag + lnmora
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnmora
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "MO"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag.Trim
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.dfecmod = Now()
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cclipag = "0"
            ecredkar.agregarCredkar(entidadkardex) ' graba

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = IIf(tipo = "C", 0, Math.Abs(lnmora))
            entidadcntamov.ndebe = IIf(tipo = "C", Math.Abs(lnmora), 0)
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.dfecmod = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "AR"

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "AJUSTE DE MORA"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcnrodoc
            entidadcntamov.ccodsec = "MO"
            ecntamov.agregarCntamov(entidadcntamov)

        End If

        'intereses
        If lctippag = "I" Then
            lcctactb = lccontra8
        Else
            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "R", "IN", lcdescob, lccondic, lctippag, pcbanco, lnintere, lnintcap, lndifint)
        End If
        If lcctactb = "*" Then
            oktransac = 2
            '    Return oktransac

        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Pago de Interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<

        If lnintere <> 0 Then

            lntotapag = lntotapag + lnintere
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnintere
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "IN"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = IIf(tipo = "C", 0, Math.Abs(lnintere))
            entidadcntamov.ndebe = IIf(tipo = "C", Math.Abs(lnintere), 0)
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lccodcta, 1)
            entidadcntamov.cpoliza = "AR"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "AJUSTE DE INTERES"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcnrodoc
            entidadcntamov.ccodsec = "IN"


            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

            oktransac = ecntamov.agregarCntamov(entidadcntamov)

        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<

        'capital
        Dim lnpagocap As Double
        lnpagocap = 0
        If lctippag = "I" Then
            lcctactb = lccontra8
        Else
            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "KP", lcdescob, lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
        End If
        If lcctactb = "*" Then
            oktransac = 2
            ' Return oktransac

        End If

        If lncapita <> 0 Then
            lntotapag = lntotapag + lncapita
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lncapita
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "KP"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = IIf(tipo = "C", 0, Math.Abs(lncapita))
            entidadcntamov.ndebe = IIf(tipo = "C", Math.Abs(lncapita), 0)
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lccodcta, 1)
            entidadcntamov.cpoliza = "AR"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "AJUSTE DE CAPITAL"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcnrodoc
            entidadcntamov.ccodsec = "KP"


            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba

            oktransac = ecntamov.agregarCntamov(entidadcntamov)

        End If


        'actualiza el cj **** mxupdatecaja  ****
        If lntotapag <> 0 Then ' monto total pagado

            If lctippag = "I" Then
                lcctactb = lccontra7
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "CJ", lcdescob, lccondic, lctippag, pcbanco, lnmonpag, lnintcap, lndifint)
            End If
            If lcctactb = "*" Then
                oktransac = 2
                '   Return ok
                '   Return oktransac

            End If


            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lntotapag
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "CJ"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = Now()
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = pcbanco
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba


            'dividimos las cuentas
            'contabilidad
            If lncapita <> 0 Then
                lcctactb = pcCuentaAj
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.ndebe = IIf(tipo = "C", 0, Math.Abs(lncapita))
                entidadcntamov.nhaber = IIf(tipo = "C", Math.Abs(lncapita), 0)
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "AR"
                entidadcntamov.dfecmod = gdfecsis
                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "AJUSTE REGISTRO DE CAJA CAPITAL"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli
                entidadcntamov.corden = lcnrodoc
                entidadcntamov.ccodsec = "CJ"
                oktransac = ecntamov.agregarCntamov(entidadcntamov)
            End If
            If lnintere <> 0 Then
                lcctactb = pcCuentaAj2
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.ndebe = IIf(tipo = "C", 0, Math.Abs(lnintere))
                entidadcntamov.nhaber = IIf(tipo = "C", Math.Abs(lnintere), 0)
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "AR"
                entidadcntamov.dfecmod = gdfecsis
                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "AJUSTE REGISTRO DE CAJA INTERES"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli
                entidadcntamov.corden = lcnrodoc
                entidadcntamov.ccodsec = "CJ"
                oktransac = ecntamov.agregarCntamov(entidadcntamov)
            End If
            If lnmora <> 0 Then
                lcctactb = pcCuentaAj3
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.ndebe = IIf(tipo = "C", 0, Math.Abs(lnmora))
                entidadcntamov.nhaber = IIf(tipo = "C", Math.Abs(lnmora), 0)
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "AR"
                entidadcntamov.dfecmod = gdfecsis
                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "AJUSTE REGISTRO DE CAJA MORA"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli
                entidadcntamov.corden = lcnrodoc
                entidadcntamov.ccodsec = "CJ"
                oktransac = ecntamov.agregarCntamov(entidadcntamov)
            End If



        End If



        'ACTUALIZA NUMLIN EN LA CNTAMOV, PORQUE SON PAGOS Y CONTINUARA DONDE SE QUEDO
        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNNUMLIN"
        etabtvar.lcarini = True

        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.cconvar = lnnumlin.ToString.Trim
        etabtvar.cdesvar = "NUMERO DE REGISTRO EN LA CNTAMOV"
        etabtvar.ctipvar = "C"
        etabtvar.ccodusu = Me.lccodusu1
        etabtvar.cflag = ""
        mtabtvar.ActualizarTabtvar(etabtvar)
        ' FIN DE ACTUALIZACION DE NUMLIN EN LA DE PAGOS


        'actualiza tablas creditos
        'mxupdatetmp
        Dim lncapdes As Double
        Dim lcestado As String
        Dim ldfecter As Date
        Dim ldultpag As Date
        Dim pdultima As Date
        Dim lnintpen As Double
        Dim lnpagcta As Double
        Dim lnmorpag As Double
        Dim lncappag As Double
        Dim lngaspag As Double
        Dim resultadocremcre As Integer
        Dim ldfecapr As Date
        Dim ldfectra As Date


        lnintpen = 0
        lnpagcta = 0
        lnmorpag = 0

        lncapdes = entidad1.ncapdes
        ldfecapr = entidad1.dfecapr
        ldfectra = entidad1.dfectra

        If Math.Round(entidad1.ncapdes, 2) <= Math.Round(entidad1.ncappag + lncapita, 2) Then
            lcestado = "G"
        Else
            lcestado = entidad1.cestado
        End If
        If lcestado = "G" Then
            ldfecter = pdfecval
        End If
        If lncapita <> 0 Then
            ldultpag = pdfecval
        Else
            ldultpag = entidad1.dultpag
        End If
        If entidad1.dultpag = Nothing Then
            pdultima = entidad1.dfecvig
        Else
            pdultima = entidad1.dultpag
        End If

        If entidad1.nintpag + entidad1.nintpen + lnintere >= entidad1.nintcal Then
            lnintpag = entidad1.nintpag + entidad1.nintpen + lnintere
        Else
            lnintpag = entidad1.nintpag
            lnintpen = lnintpen + lnintere
        End If

        If entidad1.nmorpag + entidad1.npagcta + lnintmor >= entidad1.nintmor Then
            lnmorpag = entidad1.nmorpag + entidad1.npagcta + lnintmor
        Else
            lnmorpag = entidad1.nmorpag
            lnpagcta = lnpagcta + lnintmor
        End If
        lncappag = entidad1.ncappag + lnpagocap
        lngaspag = entidad1.ngaspag + lngastot

        entidad1.ncappag = lncappag
        entidad1.nintpag = lnintpag
        entidad1.nintpen = lnintpen
        entidad1.nmorpag = lnmorpag
        entidad1.npagcta = lnpagcta
        entidad1.ngaspag = lngaspag
        entidad1.cestado = lcestado
        entidad1.dfecter = ldfecter
        entidad1.dultpag = ldultpag
        entidad1.dfecmod = gdfecsis
        entidad1.dfecasi = gdfecsis
        entidad1.dfecadm = gdfecsis
        entidad1.dfecapr = ldfecapr
        entidad1.dfecter = gdfecsis
        entidad1.dfecadm = gdfecsis
        entidad1.dfectra = ldfectra
        entidad1.lctaret = 1
        entidad1.cflag = "1"
        entidad1.cflag = ""
        entidad1.dfectra = gdfecsis
        ecreditos.ActualizarCremcre(entidad1)
        Return lcnumcom
        ' Catch
        '   End Try

    End Function




    Public Function mxdistribute_Transac(ByVal con As SqlConnection) As Integer

        Dim str_select As String
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim error100 As Integer
        Dim fecha1 As String
        Dim fecha2 As String

        Dim utilnuemeros As New utilNumeros
        Dim llBandera_aho As Boolean = False
        'temporalmente 
        Dim gccodofi As String = Mid(Me.pccodcta, 4, 3)
        Dim a As String
        Dim lccodcta As String = Me.pccodcta
        Dim lncapita As Double = Math.Round(Me.pncapita, 2)
        Dim lnintere As Double = Math.Round(Me.pnsalint, 2)
        Dim lnmora As Double = Math.Round(Me.pnsalmor, 2)
        Dim lnsegveh As Double = 0 'Math.Round(Me.pnsegveh, 2)
        Dim lncomision As Double = Math.Round(Me.manejo, 2) 'Math.Round(Me.pncomision, 2)

        Dim lnhonorarios As Double = Math.Round(Me.pnhonorarios, 2)
        Dim lnmanejo As Double = Math.Round(Me.manejo, 2)
        Dim lnahosim As Double = Math.Round(Me.ahosim, 2)
        Dim lnahovis As Double = Math.Round(Me.ahovis, 2)
        Dim lnaporta As Double = Math.Round(Me.aporta, 2)
        Dim lnsegdeu As Double = Math.Round(Me.segdeu, 2)
        Dim lsolidario As Boolean = Me.lsolidario
        'Dim lnsegdan As Double = Math.Round(Me.segdan, 2)
        Dim lncobiva As Double = 0 'Math.Round(Me.iva, 2)


        'Dim lndepurada As Double = Math.Round(Me.pndepurada, 2)
        'Dim lnanotacion As Double = Math.Round(Me.pnanotacion, 2)
        'Dim lndeudores As Double = Math.Round(Me.pndeudores, 2)
        'Dim lncostas As Double = Math.Round(Me.pncostas, 2)
        'Dim lnprotege As Double = Math.Round(Me.pnprotege, 2)
        Dim lnpagocap1 As Double = 0

        Dim lcorden As String = ""

        'If IsDBNull(Me.pcorden) Or Me.pcorden = Nothing Then
        '    Me.pcorden = ""
        'End If
        'lcorden = Me.pcorden

        Dim lngestion As Double = Math.Round(Me.pngestion, 2)
        Dim lnmonpag As Double = Math.Round(Me.pnmonpag, 2)
        Dim ldfecval As Date = Me.pdfecval
        Dim lndeutot As Double = Math.Round(Me.pndeucap, 2)
        Dim lcbanco As String = Me.pcbanco
        Dim lnintmor As Double
        Dim lntotapag As Double = 0
        Dim lcnrodoc As String
        '        Dim kardex As DataTable
        Dim crefunc As New SIM.BL.crefunc
        '       Dim cre As New DataSet
        Dim lcctactb As String
        'variables necesitadas para la clase
        Dim lctippag As String
        Dim lnmonto As Double
        Dim lnintpag As Double
        Dim lndifint As Double
        Dim lcnorref As String
        Dim lccodlin As String
        Dim lcconcep As String
        Dim lcdescob As String
        Dim lccondic As String
        Dim lcnrolin As String
        Dim lnintcap As Double
        Dim ldfecsis As Date
        Dim lccodusu As String
        Dim lngastot As Double
        Dim lnnumlin As Integer

        Dim lccodfue As String
        'actualiza tablas de contabilidad
        Dim lcnumcom As String
        Dim ok As Integer
        Dim tamano As Integer
        Dim i As Integer
        Dim lnlinaho As Integer
        Dim lcsececo As String

        Dim lncuoapr As Integer = 0
        Dim lnsaldo As Double = 0
        Dim lncorrel As Integer = 0
        Dim lnlinea As Integer = 0

        'obtiene el numero de partida
        If pctippag.Trim = "I" Then 'Partida aparte por ser condonacion
            lcnumcom = clase.fxStevo(Me.pdfecval)
        Else
            lcnumcom = "99999997"  'Mid(gccodofi, 2, 2)
        End If

        'temporalmente
        lndifint = 0
        lnintcap = 0
        lctippag = pctippag.Trim
        'Genera las cuentas de orden para cuando exista Condonaciones>>>>>
        Dim lccontra7 As String = "*"
        Dim lccontra8 As String = "*"

        Dim lccontra9 As String = "*"
        Dim lccontra10 As String = "*"

        lngastot = 0

        Dim lcproducto As String = "*"
        Dim lccta1sp As String = "*"
        Dim lccta2sp As String = "*"
        Dim CodigoSocio As String = ""
        Dim NombreSocio As String = ""
        Dim pcglosa As String = ""
        Dim lniva_interes As Double = 0
        Dim lniva_total As Double = 0
        Dim lniva_mora As Double = 0

        '   Try
        'abre las colecciones para tomar otros datos que hacen falta
        'en las tablas de las colecciones

        'cremcref
        Dim lnmercantil As Integer = 0
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre
        entidad1.ccodcta = lccodcta
        ecreditos.ObtenerCremcre(entidad1)
        gccodofi = entidad1.coficina
        lcproducto = "" ' Left(entidad1.cproducto, 1)
        lcsececo = IIf(IsDBNull(entidad1.csececo), "", entidad1.csececo)
        lncuoapr = entidad1.ncuoapr
        CodigoSocio = entidad1.ccodcli


        Dim entidadclimide As New SIM.EL.climide
        Dim eclimide As New SIM.BL.cClimide

        entidadclimide.ccodcli = CodigoSocio
        eclimide.ObtenerClimide(entidadclimide)

        NombreSocio = entidadclimide.cnomcli
        pcglosa = "Pagos de Prestamos Ref #: " & pccodcta & " a Nombre de : " & NombreSocio & " No Documento " & pcnuming0


        'lnmercantil = IIf(IsDBNull(entidad1.ncodcli), 0, entidad1.ncodcli)
        'si lnmercantil es 1 no cobrara mas que solo capital


        lcsececo = lcsececo.Trim
        'crefunc.pcsececo = lcsececo

        crefunc.pcoficina = gccodofi
        'credkar
        Dim ecredkar As New SIM.BL.cCredkar
        Dim entidadkardex As New SIM.EL.credkar

        'cntamov
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        entidadcntamov.cnumcom = lcnumcom

        'diario
        Dim entidaddiario As New SIM.EL.diario
        Dim ediario As New SIM.BL.cDiario
        entidaddiario.cnumcom = lcnumcom

        'ahorros
        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov

        Dim lccodaho As String
        Dim lnsaldoaho As Double
        Dim lnnewsalaho As Double

        'actualiza tabla de comprobantes
        Dim mtabtvar As New cTabtvar
        Dim etabtvar As New tabtvar


        'Si el tipo es condonacion de intereses no actualizara el contador de pagos en la maestra

        If Me.pcnuming <> "COND" Then
            etabtvar.ccodapl = "CRE"
            etabtvar.cnomvar = "GNCORRELA"
            etabtvar.lcarini = True
            mtabtvar.ObtenerTabtvar(etabtvar)
            'etabtvar.cconvar = Me.pcnuming0
            etabtvar.cconvar = Me.pcnuming

            Try
                mtabtvar.ActualizarTabtvar(etabtvar)
            Catch ex As Exception
                error100 = -100
                Return error100
            End Try

        End If

       
        '        GNNUMLIN


        'obtendra el numero de linea donde va en la digitacion de la partida de ingresos
        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNNUMLIN"
        etabtvar.lcarini = True
        mtabtvar.ObtenerTabtvar(etabtvar)
        lnnumlin = Integer.Parse(etabtvar.cconvar)


        'obtiene numero de documento
        'Comentariado se quedaba pegado Timeout Rafa    13/11/2013
        'lcnrodoc = ecredkar.obtenercnrodoc(pccodcta)
        lcnrodoc = ecredkar.obtenercnrodoc_(pccodcta, con)
        If lcnrodoc = Nothing Then
            lcnrodoc = "0002"
        End If
        tamano = lcnrodoc.Trim.Length
        For i = 1 To 4 - tamano
            lcnrodoc = "0" & lcnrodoc
        Next


        lcconcep = "C"
        lcdescob = "C"
        lccondic = entidad1.ccondic
        lcnrolin = entidad1.cnrolin

        lcnorref = entidad1.cnorref

        Dim ecretlin As New cCretlin




        'carga propiedades
        entidad1.nintpag = Me.pnintpag
        entidad1.nintpen = Me.pnintpen
        entidad1.nintcal = Me.pnintcal
        entidad1.nmorpag = Me.pnmorpag
        entidad1.npagcta = Me.pnpagcta
        entidad1.nintmor = Me.pnintmor
        entidad1.dultpag = Me.pdultpag
        entidad1.ncappag = Me.pncappag

        'cretlin
        Dim entidad2 As New SIM.EL.cretlin

        'entidad2.cnrolin = lcnrolin
        'ecretlin.ObtenerCretlin(entidad2)

        'lccodlin = entidad2.ccodlin
        'lccodfue = clssdes.ConvertidorFondos(lccodlin.Trim.Substring(2, 2)) 'entidad1.ccodfue

        'lccodlin = clsppal.ConviertePlazoLinea(lccodlin, lncuoapr)

        ''Recontruyendo codigo de Linea para creditos migrados  04/2013
        ''1101010101

        'If Me.cCodsector.Trim.Length = 0 Then
        '    Me.cCodsector = lccodlin.Trim.Substring(6, 2)
        'End If

        'lccodlin = Left(lccodlin, 6) + Me.cCodsector + Right(lccodlin, 2)


        entidad2.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidad2)

        lccodlin = entidad2.ccodlin

        'lccodlin = Left(RTrim(lccodlin), 4) + Me.pcSector.Trim + RTrim(Right(lccodlin, 4))

        lccodfue = clssdes.ConvertidorFondos(lccodlin.Trim.Substring(2, 2)) 'entidad1.ccodfue



        '********** cambio por mirna  nueva forma de lineas optim ***
        'lccodlin = Me.pclineam

        If lccodlin = "08" Then
            lccodlin = "07"
        End If


        If lctippag = "I" Then
            Dim entidadtabtmak As New SIM.EL.tabtmak
            Dim etabtmak As New SIM.BL.cTabtmak
            Dim busquedaplantilla As Integer
            Dim cplanti As String

            entidadtabtmak.ccodigo = "CNICS7"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra8 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                'lccontra7 = cplanti
                lccontra8 = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If

            entidadtabtmak.ccodigo = "CNICS8"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra7 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra7 = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If

            entidadtabtmak.ccodigo = "COONN"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra9 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra9 = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)
            End If

            entidadtabtmak.ccodigo = "CCONS"
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lccontra10 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lccontra10 = clase.fxBuildCtaCtb(cplanti, lccodlin, gccodofi, lccondic, pccodcta)

            End If

        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        Dim siexiste As Boolean
        'inicia rutina de grabado en tablas
        '**************************  DATOS **********************
        '******************    agrega a la diario ***************

        'localiza si ya existe ese numero de partida en la diario,
        'de lo contrario ya no lo agregara
        siexiste = ediario.siexistepartida(lcnumcom)
        If siexiste = False Then 'si ya existe no es necesario agregarlo en la diario
            entidaddiario.cnumcom = lcnumcom
            If pctippag.Trim = "I" Then
                entidaddiario.cglosa = "CONDONACION DE INTERESES CREDITO : " & pccodcta
            Else
                entidaddiario.cglosa = "PARTIDA DE INGRESOS DIARIOS DEL DIA: " & Left(gdfecsis.ToString, 10)
            End If
            entidaddiario.cnumdoc = pcnuming
            entidaddiario.dfeccnt = gdfecsis
            entidaddiario.cestado = " "
            entidaddiario.ccodofi = gccodofi
            entidaddiario.ffondos = lccodfue
            entidaddiario.dfecdoc = gdfecsis
            entidaddiario.dfecmod = gdfecsis


            Try
                ediario.agregarDiario(entidaddiario)
            Catch ex As Exception
                error100 = -100
                Return error100
            End Try



        End If
        Dim lcnomcli As String = ""
        Dim ecremcre As New cCremcre
        lcnomcli = ecremcre.ObtenerNombrexCuenta(lccodcta)


        fecha1 = gdfecsis
        fecha2 = pdfecval
        If fecha2.Length = 0 Then
            fecha2 = fecha1
        End If



        'Primero Cobrar los Aditivos

        ' cobro honorarios

        If lnhonorarios > 0 And lnmonpag > 0 Then
            Try
                If lctippag = "I" Then
                    lcctactb = lccontra8
                Else
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "HO", lcdescob, lccondic, _
                                                        lctippag, pcbanco, lnsegdeu, lnintcap, lndifint)
                End If
            Catch ex As Exception
                error100 = -100
                Return error100

            End Try
            If lcctactb = "*" Then
                oktransac = 2
                'Throw New Exception("Mesanje personalizado")
                'Return -1 'Error porque no existe 
            End If

            If lnmonpag > lnhonorarios Then
                lnmonpag = lnmonpag - lnhonorarios
            Else
                lnhonorarios = lnmonpag
                lnmonpag = 0
            End If

            lntotapag = lntotapag + lnhonorarios
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnhonorarios
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "HO"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag.Trim
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cclipag = "0"
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
             "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
             "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
             "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
             miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
             miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
             miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
             miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
             miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnhonorarios
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.dfecmod = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "HONORARIOS"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


        End If



        'Comisión por Manejo    ----------------------------------------------------------------------------------------

        If lnmanejo > 0 And lnmonpag > 0 Then
            Try
                If lctippag = "I" Then
                    lcctactb = lccontra8
                Else
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "08", lcdescob, lccondic, _
                                                        lctippag, pcbanco, lnmanejo, lnintcap, lndifint)
                End If
            Catch ex As Exception
                error100 = -100
                Return error100

            End Try
            If lcctactb = "*" Then
                oktransac = 2
                'Throw New Exception("Mesanje personalizado")
                'Return -1 'Error porque no existe 
            End If

            If lnmonpag > lnmanejo Then
                lnmonpag = lnmonpag - lnmanejo
            Else
                lnmanejo = lnmonpag
                lnmonpag = 0
            End If

            lntotapag = lntotapag + lnmanejo
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnmanejo
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "08"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag.Trim
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cclipag = "0"
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
             "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
             "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
             "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
             miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
             miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
             miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
             miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
             miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnmanejo
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.dfecmod = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "MANEJO"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


        End If



        'Seguro de Deuda      ----------------------------------------------------------------------------------------




        'Seguro de Vehiculos  ----------------------------------------------------------------------------------------

        If lnsegveh > 0 And lnmonpag > 0 Then
            Try
                If lctippag = "I" Then
                    lcctactb = lccontra8
                Else
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "SD", lcdescob, lccondic, _
                                                        lctippag, pcbanco, lnsegveh, lnintcap, lndifint)
                End If
            Catch ex As Exception
                error100 = -100
                Return error100

            End Try
            If lcctactb = "*" Then
                oktransac = 2
                'Throw New Exception("Mesanje personalizado")
                'Return -1 'Error porque no existe 
            End If

            If lnmonpag > lnsegveh Then
                lnmonpag = lnmonpag - lnsegveh
            Else
                lnsegveh = lnmonpag
                lnmonpag = 0
            End If

            lntotapag = lntotapag + lnsegveh
            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnsegveh
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "SH"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag.Trim
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cclipag = "0"
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
             "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
             "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
             "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
             miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
             miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
             miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
             miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
             miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnsegveh
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.dfecmod = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "SEGURO DE VEHICULO"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


        End If




        ''IVA--------------------------------------------------------------------------------------------------------
        'If lncobiva > 0 And lnmonpag > 0 Then
        '    Try
        '        If lctippag = "I" Then
        '            lcctactb = lccontra8
        '        Else
        '            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "03", lcdescob, lccondic, _
        '                                                lctippag, pcbanco, lncobiva, lnintcap, lndifint)
        '        End If
        '    Catch ex As Exception
        '        error100 = -100
        '        Return error100

        '    End Try
        '    If lcctactb = "*" Then
        '        oktransac = 2
        '        'Throw New Exception("Mesanje personalizado")
        '        'Return -1 'Error porque no existe 
        '    End If

        '    If lnmonpag > lncobiva Then
        '        lnintmor = lncobiva
        '        lnmonpag = lnmonpag - lncobiva
        '    Else
        '        lncobiva = lnmonpag
        '        lnmonpag = 0
        '    End If
        '    lntotapag = lntotapag + lncobiva
        '    entidadkardex.ccodcta = pccodcta
        '    entidadkardex.nmonto = lncobiva
        '    entidadkardex.ccodctb = lcctactb
        '    entidadkardex.cconcep = "03"
        '    entidadkardex.cdescob = "C"
        '    entidadkardex.ctippag = lctippag
        '    entidadkardex.cestado = " "
        '    entidadkardex.ctippag = lctippag.Trim
        '    entidadkardex.dfecsis = gdfecsis
        '    entidadkardex.dfecpro = pdfecval
        '    entidadkardex.dfecmod = gdfecsis
        '    entidadkardex.ccodusu = gccodusu
        '    entidadkardex.ccondic = "N"
        '    entidadkardex.cbanco = ""
        '    entidadkardex.cnuming = pcnuming
        '    entidadkardex.cnuming0 = pcnuming0
        '    entidadkardex.ctrasctb = 1
        '    entidadkardex.ndiaatr = Me.pndiaatr
        '    entidadkardex.ccodofi = gccodofi
        '    entidadkardex.ccodins = gccodofi
        '    entidadkardex.cnrodoc = lcnrodoc
        '    entidadkardex.lsolidario = lsolidario
        '    entidadkardex.cclipag = "0"
        '    entidadkardex.cnumcta = ""
        '    entidadkardex.mancomunad = 0

        '    str_select = "insert into credkar " & _
        '     "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
        '     "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
        '     "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
        '     miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
        '     miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
        '     miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
        '     miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
        '     miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

        '    error100 = miclase.nonquery_sin_parametros(con, str_select)
        '    If error100 = -100 Then
        '        Return error100
        '    End If
        '    'contabilidad
        '    lnnumlin = lnnumlin + 1
        '    entidadcntamov.ccodcta = lcctactb
        '    entidadcntamov.cnumlin = lnnumlin
        '    entidadcntamov.nhaber = lncobiva
        '    entidadcntamov.ndebe = 0
        '    entidadcntamov.ccodpres = lccodcta
        '    entidadcntamov.cnumdoc = pcnuming
        '    entidadcntamov.ccodofi = gccodofi
        '    entidadcntamov.cflc = " "
        '    entidadcntamov.dfeccnt = gdfecsis
        '    entidadcntamov.dfecmod = gdfecsis
        '    entidadcntamov.ccodusu1 = gccodusu
        '    entidadcntamov.ffondos = lccodfue
        '    entidadcntamov.cclase = Left(lcctactb, 1)
        '    entidadcntamov.cpoliza = "ING"

        '    entidadcntamov.ccodsec = ""
        '    entidadcntamov.cconcepto = "PAGO DE IVA"
        '    entidadcntamov.cnumpol = ""
        '    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
        '    entidadcntamov.ccodcli = lccodcli
        '    entidadcntamov.corden = lcorden

        '    str_select = "insert into cntamov " & _
        '                "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
        '                "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
        '                "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
        '                "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
        '                "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
        '                "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
        '                miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
        '                "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


        '    error100 = miclase.nonquery_sin_parametros(con, str_select)
        '    If error100 = -100 Then
        '        Return error100
        '    End If

        '    'ecntamov.agregarCntamov(entidadcntamov)


        'End If

        'Fin de cobro de IVA-----------------------------------------------------------------------------------


        'mora

        If lnmora > 0 And lnmonpag > 0 Then
            Try
                If lctippag = "I" Then
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "MO", lcdescob, lccondic, lctippag, pcbanco, lnmora, lnintcap, lndifint)
                    'lcctactb = lccontra8
                Else
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "MO", lcdescob, lccondic, lctippag, pcbanco, lnmora, lnintcap, lndifint)
                End If
            Catch ex As Exception
                error100 = -100
                Return error100

            End Try
            If lcctactb = "*" Then
                oktransac = 2
                'Throw New Exception("Mesanje personalizado")
                'Return -1 'Error porque no existe 
            End If
            'mora


            'If lnmonpag > lnmora Then
            '    lnintmor = lnmora
            '    lnmonpag = lnmonpag - lnintmor
            'Else
            '    lnintmor = lnmonpag
            '    lnmonpag = 0
            'End If
            If lnmonpag > lnmora Then
                lnmonpag = Math.Round(lnmonpag - lnmora, 2)

                'Quitando el Iva de la Mora
                lniva_mora = lnmora - (lnmora / Me.gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnmora = Math.Round(lnmora - lniva_mora, 2)
                lniva_total = lniva_total + lniva_mora
            Else
                lnmora = lnmonpag
                lnmonpag = 0

                'Quitando el Iva de la Mora
                lniva_mora = lnmora - (lnmora / Me.gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnmora = Math.Round(lnmora - lniva_mora, 2)
                lniva_total = lniva_total + lniva_mora
            End If


            lntotapag = lntotapag + lnmora


            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnmora
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "MO"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag.Trim
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cclipag = "0"
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
             "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
             "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
             "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
             miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
             miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
             miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
             miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
             miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


            'ecredkar.agregarCredkar(entidadkardex) ' graba

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnmora
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.dfecmod = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE MORA"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli
            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If

            'ecntamov.agregarCntamov(entidadcntamov)

        End If
        '----------------------------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------------------------

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Pago de Interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<
        If lnintere > 0 And lnmonpag > 0 Then
            'intereses
            'If lctippag = "I" Then
            '    lcctactb = lccontra8
            'Else
            lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "R", "IN", lcdescob, lccondic, lctippag, pcbanco, lnintere, lnintcap, lndifint)
            'End If
            If lcctactb = "*" Then
                oktransac = 2
                '    Return oktransac

            End If

            Dim clsppal As New class1
            Dim Array_Prov As New ArrayList

            'If lnmonpag > lnintere Then
            '    lnmonpag = lnmonpag - lnintere
            'Else
            '    lnintere = lnmonpag
            '    lnmonpag = 0
            'End If

            If lnmonpag > lnintere Then
                lnmonpag = lnmonpag - lnintere
                'Quitando el Iva del Interes
                lniva_interes = lnintere - (lnintere / Me.gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)
                lniva_total = lniva_total + lniva_interes
            Else
                lnintere = lnmonpag
                lnmonpag = 0

                'Quitando el Iva del Interes
                lniva_interes = lnintere - (lnintere / Me.gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)
                lniva_total = lniva_total + lniva_interes
            End If


            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "IN", lcdescob, "P", lctippag, pcbanco, lnintere, lnintcap, lndifint)
            End If
            If lcctactb = "*" Then
                oktransac = 2
            End If

            lntotapag = lntotapag + lnintere

            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lnintere
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "IN"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
            "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
            "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
            "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
            miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
            miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
            miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
            miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
            miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If
            'oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba



            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lnintere
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE INTERES"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli


            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


        End If


        'Iva Interes Moratorio
        If lniva_mora > 0 Then
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "IM", lcdescob, lccondic, lctippag, pcbanco, lniva_mora, _
                                                    lnintcap, lndifint)
            End If

            If lcctactb = "*" Then
                oktransac = 2
            End If

            lntotapag = lntotapag + lniva_mora


            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lniva_mora
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "IM"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
                        "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
                        "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
                        "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
                        miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
                        miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
                        miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
                        miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
                        miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lniva_mora
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "IVA MORA"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli


            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


        End If

        'Iva Interes Normal
        If lniva_interes > 0 Then

            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "08", lcdescob, lccondic, lctippag, pcbanco, lniva_interes, _
                                                    lnintcap, lndifint)
            End If

            If lcctactb = "*" Then
                oktransac = 2
            End If
            '    Return oktransac
            'Es para que no incluya en el pago el movimiento sin cuenta
            'y no descuadre la partida
            'lntotapag = lntotapag + lnmonpag
            'Else
            lntotapag = lntotapag + lniva_interes


            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = lniva_interes
            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "08"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = lccondic
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            entidadkardex.ctrasctb = 1
            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
                        "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
                        "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
                        "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
                        miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
                        miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
                        miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
                        miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
                        miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.nhaber = lniva_interes
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "IVA INTERES"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli


            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


        End If


        '----------------------------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------------------------
        ' primero cobrara deuda de capital
        Dim lnpagocap As Double
        lnpagocap = 0

        If lndeutot > 0 And lnmonpag > 0 Then
            'If lccondic = "S" Then
            '    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "ICD", lcdescob, "N", lctippag, pcbanco, lncapita, lnintcap, lndifint)
            'Else
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "KP", lcdescob, lccondic, lctippag, pcbanco, _
                                                    lncapita, lnintcap, lndifint)
            End If

            'End If

            If lcctactb = "*" Then
                oktransac = 2
                ' Return oktransac

            End If

            'If lndeutot > lnmonpag Then
            '    lnpagocap = lnmonpag
            '    lnmonpag = 0
            'Else
            '    lnpagocap = lndeutot
            '    lnmonpag = lnmonpag - lnpagocap
            'End If


            lnpagocap = clsppal.fxReducePay(lnmonpag, lncapita)
            lnmonpag = lnmonpag - lnpagocap

            If lnpagocap > 0 Then
                lndeutot = lndeutot - lnpagocap
                lntotapag = lntotapag + lnpagocap
                entidadkardex.ccodcta = pccodcta
                entidadkardex.nmonto = lnpagocap
                entidadkardex.ccodctb = lcctactb
                entidadkardex.cconcep = "KP"
                entidadkardex.cdescob = "C"
                entidadkardex.ctippag = lctippag
                entidadkardex.cestado = " "
                entidadkardex.ctippag = lctippag
                entidadkardex.dfecsis = gdfecsis
                entidadkardex.dfecmod = gdfecsis
                entidadkardex.dfecpro = pdfecval
                entidadkardex.ccodusu = gccodusu
                entidadkardex.ccondic = "N"
                entidadkardex.cbanco = ""
                entidadkardex.cnuming = pcnuming
                entidadkardex.cnuming0 = pcnuming0
                entidadkardex.ctrasctb = 1
                entidadkardex.ndiaatr = Me.pndiaatr
                entidadkardex.ccodofi = gccodofi
                entidadkardex.ccodins = gccodofi
                entidadkardex.cnrodoc = lcnrodoc
                entidadkardex.cclipag = "0"
                entidadkardex.lsolidario = lsolidario
                entidadkardex.cnumcta = ""

                str_select = "insert into credkar " & _
                 "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
                 "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
                 "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
                 miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
                 miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
                 miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
                 miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
                 miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If
                'oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba



                'contabilidad
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = lnpagocap
                entidadcntamov.ndebe = 0
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "PAGO DE CAPITAL"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli

                entidadcntamov.corden = lcorden

                str_select = "insert into cntamov " & _
                            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                            "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                            "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                            "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                            "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                            miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                            "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If

                'oktransac = ecntamov.agregarCntamov(entidadcntamov)


                'Cuentas Especiales  para Cobranza Judicial (embargo/Depurada)

                'Cuentas Especiales para Saneado ('Depurada')

            End If
        End If
        '----------------------------------------------------------------------------------------------------------------------------------------






        '--------------------------------------------------------------
        'Cobra capital adelantado-----------------------------------
        If lndeutot > 0 And lnmonpag > 0 Then
            'If lccondic = "S" Then
            '    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "ICD", lcdescob, "N", lctippag, pcbanco, lncapita, lnintcap, lndifint)
            'Else
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "KP", lcdescob, lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
            End If

            'End If

            If lcctactb = "*" Then
                oktransac = 2
                ' Return oktransac

            End If

            lnpagocap1 = 0
            If lndeutot > lnmonpag Then
                lnpagocap1 = lnmonpag
                lnmonpag = 0
            Else
                lnpagocap1 = Math.Round(lndeutot, 2)
                lnmonpag = lnmonpag - lnpagocap1
            End If


            'lnpagocap = clsppal.fxReducePay(lnmonpag, lncapita)
            'lnmonpag = lnmonpag - lnpagocap
            If lnpagocap1 > 0 Then


                lndeutot = lndeutot - lnpagocap1
                lntotapag = lntotapag + lnpagocap1

                entidadkardex.ccodcta = pccodcta
                entidadkardex.nmonto = Math.Round(lnpagocap1, 2)
                entidadkardex.ccodctb = lcctactb
                entidadkardex.cconcep = "KP"
                entidadkardex.cdescob = "C"
                entidadkardex.ctippag = lctippag
                entidadkardex.cestado = " "
                entidadkardex.ctippag = lctippag
                entidadkardex.dfecsis = gdfecsis
                entidadkardex.dfecmod = gdfecsis
                entidadkardex.dfecpro = pdfecval
                entidadkardex.ccodusu = gccodusu
                entidadkardex.ccondic = "P"
                entidadkardex.cbanco = ""
                entidadkardex.cnuming = pcnuming
                entidadkardex.cnuming0 = pcnuming0
                entidadkardex.ctrasctb = 1
                entidadkardex.ndiaatr = Me.pndiaatr
                entidadkardex.ccodofi = gccodofi
                entidadkardex.ccodins = gccodofi
                entidadkardex.cnrodoc = lcnrodoc
                entidadkardex.cclipag = "0"
                entidadkardex.lsolidario = lsolidario
                entidadkardex.cnumcta = ""
                entidadkardex.mancomunad = 0

                str_select = "insert into credkar " & _
                 "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
                 "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
                 "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
                 miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
                 miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
                 miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
                 miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
                 miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If
                'oktransac = ecredkar.agregarCredkar(entidadkardex) ' graba


                'contabilidad
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = Math.Round(lnpagocap1, 2)
                entidadcntamov.ndebe = 0
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "PAGO DE CAPITAL"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli



                entidadcntamov.corden = lcorden

                str_select = "insert into cntamov " & _
                            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                            "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                            "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                            "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                            "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                            miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                            "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If

                'oktransac = ecntamov.agregarCntamov(entidadcntamov)
            End If
        End If

        Dim lccta1 As String = "*"
        Dim lccta2 As String = "*"
        Dim lccta3 As String = "*"
        Dim lccta4 As String = "*"

        'Capital pagado
        Dim lnkpreg As Decimal = 0
        lnkpreg = Math.Round(lnpagocap + lnpagocap1, 2)
        If lnkpreg > 0 And (lccondic = "S") Then 'Cobranza Judicial / Saneado 'lccondic = "J" Or
            'si producto es L se va a otra cuenta

            If lcproducto = "L" Then
                lccta1 = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "KP1", "O", "J", lctippag, pcbanco, lncapita, lnintcap, lndifint)
            Else
                lccta1 = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "KP1", "O", lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
            End If

            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lccta1
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.ndebe = 0
            entidadcntamov.nhaber = lnkpreg
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lccta1, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE CAPITAL"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            entidadcntamov.corden = lcorden
            'oktransac = ecntamov.agregarCntamov(entidadcntamov)

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If


            lccta2 = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "KP2", "O", lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)



            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lccta2
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.ndebe = lnkpreg
            entidadcntamov.nhaber = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lccta2, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE CAPITAL"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If

            'oktransac = ecntamov.agregarCntamov(entidadcntamov)

            lccta3 = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "KP3", "O", lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lccta3
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.ndebe = 0
            entidadcntamov.nhaber = lnkpreg
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lccta3, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE CAPITAL"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If

            'oktransac = ecntamov.agregarCntamov(entidadcntamov)

            lccta4 = crefunc.fxcuentacontable(pccodcta, lccodlin, "N", "KP4", "O", lccondic, lctippag, pcbanco, lncapita, lnintcap, lndifint)
            'contabilidad
            lnnumlin = lnnumlin + 1
            entidadcntamov.ccodcta = lccta4
            entidadcntamov.cnumlin = lnnumlin
            entidadcntamov.ndebe = lnkpreg
            entidadcntamov.nhaber = 0
            entidadcntamov.ccodpres = lccodcta
            entidadcntamov.cnumdoc = pcnuming
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = gdfecsis
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = lccodfue
            entidadcntamov.cclase = Left(lccta4, 1)
            entidadcntamov.cpoliza = "ING"
            entidadcntamov.dfecmod = gdfecsis

            entidadcntamov.ccodsec = ""
            entidadcntamov.cconcepto = "PAGO DE CAPITAL"
            entidadcntamov.cnumpol = ""
            entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
            entidadcntamov.ccodcli = lccodcli

            entidadcntamov.corden = lcorden

            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                        "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                        "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                        "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                        "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                        miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                        "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If

            'oktransac = ecntamov.agregarCntamov(entidadcntamov)


        End If


        '----------------------------------------------------------------------------------------------------------------------------------------
        'excedentes se contabilizara como ahorro a la vista, en otras versiones poner EX
        If lnmonpag > 0 Then
            If lctippag = "I" Then
                lcctactb = lccontra8
            Else
                lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "EX", lcdescob, lccondic, lctippag, pcbanco, _
                                                    lnmonpag, lnintcap, lndifint)
            End If
            If lcctactb = "*" Then
                oktransac = 2
                '    Return oktransac
                'Es para que no incluya en el pago el movimiento sin cuenta
                'y no descuadre la partida
                lntotapag = lntotapag - lnmonpag
            Else

                lntotapag = lntotapag + lnmonpag
                entidadkardex.ccodcta = pccodcta
                entidadkardex.nmonto = lnmonpag
                entidadkardex.ccodctb = lcctactb
                entidadkardex.cconcep = "EX"
                entidadkardex.cdescob = "C"
                entidadkardex.ctippag = lctippag
                entidadkardex.cestado = " "
                entidadkardex.ctippag = lctippag
                entidadkardex.dfecsis = gdfecsis
                entidadkardex.dfecmod = gdfecsis
                entidadkardex.dfecpro = pdfecval
                entidadkardex.ccodusu = gccodusu
                entidadkardex.ccondic = "N"
                entidadkardex.cbanco = ""
                entidadkardex.cnuming = pcnuming
                entidadkardex.cnuming0 = pcnuming0
                entidadkardex.ctrasctb = 1
                entidadkardex.ndiaatr = Me.pndiaatr
                entidadkardex.ccodofi = gccodofi
                entidadkardex.ccodins = gccodofi
                entidadkardex.cnrodoc = lcnrodoc
                entidadkardex.cclipag = "0"
                entidadkardex.lsolidario = lsolidario
                entidadkardex.cnumcta = ""
                entidadkardex.mancomunad = 0

                str_select = "insert into credkar " & _
                 "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
                 "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
                 "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
                 miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
                 miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
                 miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
                 miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
                 miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If
                'oktransac = ecredkar.agregarCredkar(entidadkardex)


                'contabilidad
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = lnmonpag
                entidadcntamov.ndebe = 0
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "EXCEDENTE DE CUOTA"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli


                entidadcntamov.corden = lcorden

                str_select = "insert into cntamov " & _
                            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                            "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                            "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                            "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                            "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                            miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                            "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"


                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If

                'oktransac = ecntamov.agregarCntamov(entidadcntamov)
                Dim ds As New DataSet

                str_select = _
                              " Select ccodaho from ahomcta where substring(ccodaho,7,2) = '01' " & _
                              " and cestado = 'A' and cnudotr = '" & lccodcli.Trim & "'"


                ds = miclase.devolver_dataset(con, str_select)

                For Each fila As DataRow In ds.Tables(0).Rows
                    pcctaahovis = fila("ccodaho")
                Next


                'Agregamos a cuenta de ahorro a la vista
                lccodaho = pcctaahovis

                If lccodaho.Trim = "" Then
                Else

                    Dim fila As DataRow
                    'Dim ds As DataSet

                    If llBandera_aho Then 'Ya existio una aplicación al Ahorro simultaneo

                        If lnmonpag > 0 Then

                            lnsaldo = lnsaldo + lnmonpag
                            lnlinea += 1
                            If lnlinea > 65 Then
                                'MESSAGEBOX("Su Libreta ha Terminado," + Chr(13) + "Pasar por una Nueva", 48, "mensaje")
                                lnlinea = 1
                            End If

                            entidadahommov.ccodaho = lccodaho
                            entidadahommov.dfecope = gdfecsis
                            entidadahommov.ctipope = "D"
                            entidadahommov.ctipdoc = "E"
                            'Modificado por Error Detectado  Rafa 04/02/2014
                            'entidadahommov.cnumdoc = "0001"
                            entidadahommov.cnumdoc = pcnuming
                            entidadahommov.crazon = "Dep.x cuota prestamo"
                            entidadahommov.nmonto = lnmonpag
                            entidadahommov.clinea = "N"
                            entidadahommov.ncorrel = lncorrel
                            entidadahommov.dfecmod = Now
                            entidadahommov.ccodusu = gccodusu
                            entidadahommov.nnum = lnlinea
                            entidadahommov.nsaldoaho = lnsaldo
                            entidadahommov.nsaldnind = lnsaldo
                            entidadahommov.cconcep = "DP"
                            entidadahommov.nlibreta = 0
                            entidadahommov.cnrochq = ""
                            entidadahommov.ctipchq = ""
                            entidadahommov.dfecomp = gdfecsis
                            entidadahommov.dfecefe = ldfecval
                            entidadahommov.npartida = "0"
                            entidadahommov.interes = "0"
                            entidadahommov.tip = ""
                            entidadahommov.ctipaho = lccodaho.Substring(6, 2)
                            entidadahommov.producto = ""
                            entidadahommov.ncompen = 0
                            entidadahommov.ccodtra = ""
                            entidadahommov.notromon = 0
                            entidadahommov.pagina = 0 'lnpagina

                            str_select = "insert into ahommov " & _
                                "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                                "('" & lccodaho & "', '" & fecha1 & "', 'D', '" & entidadahommov.cnumdoc & "', 'E', 'Dep.x cuota prestamo', " & entidadahommov.nlibreta & "," & miclase1.ToString(entidadahommov.cnrochq) & "," & miclase1.ToString(entidadahommov.ctipchq) & "," & _
                                "'" & fecha1 & " ', '" & fecha1 & "', 0, '" & entidadahommov.nmonto & "', 0, 'N', " & _
                                lnlinea & ", '" & fecha1 & "', '" & entidadahommov.ccodusu & "', " & lnlinea & ", ' ', " & lnsaldo & ", " & lnsaldo & ", 'DP', " & _
                                "'" & entidadahommov.ctipaho & "', ' ', " & entidadahommov.ncompen & ", ' ', 0)"

                            error100 = miclase.nonquery_sin_parametros(con, str_select)
                            If error100 = -100 Then
                                Return error100
                            End If

                            'eahommov.agregar(entidadahommov)

                            'Actualiza Saldo en tabla Maestra

                            str_select = "update ahomcta " & _
                                         "set ncorrel=" & lnlinea & ",nsaldoaho=" & lnsaldo & ",nsaldnind=" & lnsaldo & ",dfechault=" & miclase1.ToString(fecha1) & _
                                         ",dfecult=" & miclase1.ToString(fecha1) & ",dfecmod=" & miclase1.ToString(fecha1) & _
                                         ",dultmov=" & miclase1.ToString(fecha1) & ",nnum=" & lnlinea & _
                                         " where ccodaho=" & miclase1.ToString(lccodaho)

                            error100 = miclase.nonquery_sin_parametros(con, str_select)
                            If error100 = -100 Then
                                Return error100
                            End If
                        End If


                    Else
                        str_select = "select nnum, nsaldoaho from ahomcta where ccodaho = " & miclase1.ToString(lccodaho)
                        ds = miclase.devolver_dataset(con, str_select)


                        lnsaldoaho = 0

                        If lnmonpag > 0 Then
                            For Each fila In ds.Tables(0).Rows
                                lnsaldoaho = fila("nsaldoaho")
                                lnlinea = fila("nnum")
                                lncorrel = fila("nnum")
                            Next



                            'Otiene saldo actual de la cuenta
                            'lnsaldoaho = eahomcta.ObtieneSaldodeCuenta(lccodaho)
                            lnsaldo = lnsaldoaho + lnmonpag

                            ''lncorrel = eahommov.ObtieneCorrelativo(lccodaho)
                            ''lnlinea = eahommov.ObtieneLinea(lccodaho)
                            ''Dim lnpagina As Integer
                            'lncorrel = eahommov.ObtieneCorrelativo(lccodaho)
                            'lnlinea = eahommov.ObtieneLinea(lccodaho)
                            ''lnpagina = eahommov.ObtienePagina(lccodaho, lnlinea) 'obtiene pagina
                            'lnlinea = clsppal.fxLinea(lnlinea)
                            ''lnlinea = clsppal.fxLinea(lnlinea, lnpagina, lccodaho)

                            lnlinea += 1
                            If lnlinea > 65 Then
                                'MESSAGEBOX("Su Libreta ha Terminado," + Chr(13) + "Pasar por una Nueva", 48, "mensaje")
                                lnlinea = 1
                            End If

                            entidadahommov.ccodaho = lccodaho
                            entidadahommov.dfecope = gdfecsis
                            entidadahommov.ctipope = "D"
                            entidadahommov.ctipdoc = "E"
                            entidadahommov.cnumdoc = "0001"
                            entidadahommov.crazon = "Dep.x cuota prestamo"
                            entidadahommov.nmonto = lnmonpag
                            entidadahommov.clinea = "N"
                            entidadahommov.ncorrel = lncorrel
                            entidadahommov.dfecmod = Now
                            entidadahommov.ccodusu = gccodusu
                            entidadahommov.nnum = lnlinea
                            entidadahommov.nsaldoaho = lnsaldo
                            entidadahommov.nsaldnind = lnsaldo
                            entidadahommov.cconcep = "DP"
                            entidadahommov.nlibreta = 0
                            entidadahommov.cnrochq = ""
                            entidadahommov.ctipchq = ""
                            entidadahommov.dfecomp = gdfecsis
                            entidadahommov.dfecefe = gdfecsis
                            entidadahommov.npartida = "0"
                            entidadahommov.interes = "0"
                            entidadahommov.tip = ""
                            entidadahommov.ctipaho = lccodaho.Substring(6, 2)
                            entidadahommov.producto = ""
                            entidadahommov.ncompen = 1
                            entidadahommov.ccodtra = ""
                            entidadahommov.notromon = 0
                            entidadahommov.pagina = 0 'lnpagina
                            'eahommov.agregar(entidadahommov)

                            'Obtiene Linea de ahorro a la vista
                            Dim eahotlin As New cAhotlin
                            lcnrolin = eahotlin.ObtieneLineaAhorro(lccodaho.Substring(6, 2))

                            'Dim etabtofi As New cTabtofi
                            'Dim lcnomofi As String
                            'lcnomofi = etabtofi.NombreAgencia(gccodofi)


                            'Actualiza en la ahomcta
                            entidadahomcta.ccodaho = lccodaho
                            eahomcta.ObtenerAhomcta(entidadahomcta)

                            entidadahomcta.ccodcta = lccodcta
                            entidadahomcta.cnrolin = lcnrolin
                            entidadahomcta.cnudotr = lccodcli
                            entidadahomcta.dfecapr = gdfecsis
                            entidadahomcta.dfecmod = Now
                            entidadahomcta.ccodusu = gccodusu
                            entidadahomcta.nombre = lcnomcli
                            entidadahomcta.nsaldoaho = lnsaldo
                            entidadahomcta.nmonapr = lnsaldo
                            entidadahomcta.nsaldnind = lnsaldo
                            entidadahomcta.nnum = lncorrel
                            entidadahomcta.nmonres = (entidadahomcta.nmonres + lnmonpag)
                            entidadahomcta.dfechault = gdfecsis
                            entidadahomcta.llave = "P.CUOTA"
                            entidadahomcta.cmotivo = "" 'lcnomofi

                            str_select = "insert into ahommov " & _
                                   "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                   "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                                   "('" & lccodaho & "', '" & fecha1 & "', 'D', '" & entidadahommov.cnumdoc & "', 'E', 'Dep.x cuota prestamo', " & entidadahommov.nlibreta & "," & miclase1.ToString(entidadahommov.cnrochq) & "," & miclase1.ToString(entidadahommov.ctipchq) & "," & _
                                   "'" & fecha1 & " ', '" & fecha1 & "', 0, '" & entidadahommov.nmonto & "', 0, 'N', " & _
                                   lnlinea & ", '" & fecha1 & "', '" & entidadahommov.ccodusu & "', " & lnlinea & ", ' ', " & lnsaldo & ", " & lnsaldo & ", 'DP', " & _
                                   "'" & entidadahommov.ctipaho & "', ' ', " & entidadahommov.ncompen & ", ' ', 0)"

                            error100 = miclase.nonquery_sin_parametros(con, str_select)
                            If error100 = -100 Then
                                Return error100
                            End If

                            str_select = "update ahomcta " & _
                                         "set ncorrel=" & lnlinea & ",nsaldoaho=" & lnsaldo & ",nsaldnind=" & lnsaldo & ",dfechault=" & miclase1.ToString(fecha1) & _
                                         ",dfecult=" & miclase1.ToString(fecha1) & ",dfecmod=" & miclase1.ToString(fecha1) & _
                                         ",dultmov=" & miclase1.ToString(fecha1) & ",nnum=" & lnlinea & ",nmonres=" & entidadahomcta.nmonres & ",cmotivo=" & miclase1.ToString(entidadahomcta.cmotivo) & _
                                         " where ccodaho=" & miclase1.ToString(lccodaho)

                            error100 = miclase.nonquery_sin_parametros(con, str_select)
                            If error100 = -100 Then
                                Return error100
                            End If

                            'eahomcta.ActualizarenDesembolso(entidadahomcta)

                        End If
                    End If

                End If

            End If

        End If
        '----------------------------------------------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------------------------------------------------
        'actualiza el cj **** mxupdatecaja  ****
        If lntotapag > 0 Then ' monto total pagado


            If lctippag = "I" Then
                lcctactb = lccontra7
            ElseIf lctippag = "T" Then   'Tranferencia de Ahorro a Prestamo hara el descargo contable
                lcctactb = crefunc.fxcuentaAhorros(con, Me.pcCodctaAho)


                Dim ds As New DataSet
                Dim lnLibreta As Double


                str_select = _
                              " Select * from Ahomcta " & _
                              " where ccodaho= '" & Me.pcCodctaAho & "'"


                ds = miclase.devolver_dataset(con, str_select)

                For Each fila As DataRow In ds.Tables(0).Rows
                    lnsaldoaho = fila("nsaldoaho") - lntotapag
                    lnLibreta = fila("nlibreta")
                    lnlinea = fila("nnum")
                Next


                lnlinea += 1
                If lnlinea > 65 Then
                    'MESSAGEBOX("Su Libreta ha Terminado," + Chr(13) + "Pasar por una Nueva", 48, "mensaje")
                    lnlinea = 1
                End If
                '                lnlinea = eahommov.fxLinea(lnlinea)

                ' Inserta en la Maestra de Ahorros
                str_select = _
                              " Update ahomcta " & _
                              " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnsaldoaho & ",nsaldnind= " & lnsaldoaho & "," & _
                              " dfechault='" & fecha1 & "', dfecult='" & fecha1 & "',dfecmod= getdate()," & _
                              " dultmov='" & fecha1 & "',nnum=" & lnlinea & ",nmonres=nmonres" & _
                              " where ccodaho= '" & Me.pcCodctaAho & "'"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If


                ' Inserta en el Movimiento de Ahorros
                str_select = _
                                        "insert into ahommov " & _
                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                                        "('" & Me.pcCodctaAho & "','" & fecha1 & "', 'R', '" & lcnumcom & "', 'E', 'RETIRO POR TRANSFERENCIA-PRESTAMO', " & lnLibreta & ", '', ''," & _
                                        "'" & fecha1 & "','" & fecha1 & "',0," & lntotapag & ",0,'N'," & _
                                        lnlinea & ",getdate(), '" & gccodusu & "', " & lnlinea & ", '', " & _
                                        lnsaldoaho & ", " & lnsaldoaho & ", 'RT','" & Me.pcCodctaAho.Substring(6, 2).Trim & "',' ',0,'',0)"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If

                ' Else
                'If pcCodctaCt.Trim.Length = 0 Then   'Pago por Cuenta Contable
                '    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "CJ", lcdescob, lccondic, lctippag, pcbanco, _
                '                                    lnmonpag, lnintcap, lndifint)
                'Else
                '    lcctactb = pcCodctaCt.Trim
                'End If



            End If






            'Modificación Extrae la Oficina del Cajero 04/2013
            Dim occlas_tab As New cTabttab
            Dim lcCodOfi_Caj As String

            lcCodOfi_Caj = "" 'occlas_tab.Extrae_Cta_Contable_Cajero(gccodusu)


            entidadkardex.ccodcta = pccodcta
            entidadkardex.nmonto = Math.Round(lntotapag, 2)

            entidadkardex.ccodctb = lcctactb
            entidadkardex.cconcep = "CJ"
            entidadkardex.cdescob = "C"
            entidadkardex.ctippag = lctippag
            entidadkardex.cestado = " "
            entidadkardex.ctippag = lctippag
            entidadkardex.dfecsis = gdfecsis
            entidadkardex.dfecmod = gdfecsis
            entidadkardex.dfecpro = pdfecval
            entidadkardex.ccodusu = gccodusu
            entidadkardex.ccondic = "N"
            entidadkardex.cbanco = ""
            entidadkardex.cnuming = pcnuming
            entidadkardex.cnuming0 = pcnuming0
            'If plbanapl = True Then
            '   entidadkardex.ctrasctb = 0
            'Else
            entidadkardex.ctrasctb = 1
            'End If

            entidadkardex.ndiaatr = Me.pndiaatr
            entidadkardex.ccodofi = gccodofi
            entidadkardex.ccodins = gccodofi
            entidadkardex.cnrodoc = lcnrodoc
            entidadkardex.cclipag = "0"
            entidadkardex.lsolidario = lsolidario
            entidadkardex.cnumcta = ""
            entidadkardex.mancomunad = 0

            str_select = "insert into credkar " & _
             "(ccodcta,dfecpro,dfecsis,cnrocuo,nmonto,ccodins,ccodofi,ctippag,cestado,ctermid,cnrodoc,ccodusu,dfecmod,cmoneda,ccondic,cconcep," & _
             "cdescob,cnuming,cbanco,ccodctb,ctrasctb,cflag,cclipag,mancomunad,cnomcta,cnumcta,crotativa,ndiaatr,ccalif,lrecprov,cnumrec,crever) values " & _
             "(" & miclase1.ToString(entidadkardex.ccodcta) & "," & miclase1.ToString(fecha2) & "," & miclase1.ToString(fecha1) & ", ' ', " & entidadkardex.nmonto & "," & _
             miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ccodofi) & "," & miclase1.ToString(entidadkardex.ctippag) & ", ' ', ' ', " & _
             miclase1.ToString(entidadkardex.cnrodoc) & "," & miclase1.ToString(gccodusu) & "," & miclase1.ToString(fecha1) & ", '1', " & miclase1.ToString(entidadkardex.ccondic) & "," & _
             miclase1.ToString(entidadkardex.cconcep) & "," & miclase1.ToString(entidadkardex.cdescob) & "," & miclase1.ToString(entidadkardex.cnuming) & "," & _
             miclase1.ToString(entidadkardex.cbanco) & "," & miclase1.ToString(entidadkardex.ccodctb) & "," & miclase1.ToString(entidadkardex.ctrasctb) & ", ' ', " & _
             miclase1.ToString(entidadkardex.cclipag) & ", '0', ' ', ' ', ' ', " & entidadkardex.ndiaatr & ", ' ', 0,  " & miclase1.ToString(pcnuming0.ToString) & ", ' ')"

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                Return error100
            End If



            If lctippag = "I" Then '<<<Aca se haran dos registro para la condonacion 1- para la cuenta de intereses normal y 2- para la cuenta de interes moratorio>>>
                lcctactb = lccontra7
                'contabilidad
                If lnintere > 0 Then
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lcctactb
                    entidadcntamov.cnumlin = lnnumlin
                    entidadcntamov.nhaber = 0
                    entidadcntamov.ndebe = Math.Round(lnintere, 2)
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = "01" 'lccodfue
                    entidadcntamov.cclase = Left(lccodcta, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis

                    entidadcntamov.ccodsec = ""
                    entidadcntamov.cconcepto = "REGISTRO DE CAJA COND. INT."
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.corden = lcorden

                    str_select = "insert into cntamov " & _
                                "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                                "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                                "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                                "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                                "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                                "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                                miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                                "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return error100
                    End If
                End If

                If lnmora > 0 Then
                    lcctactb = crefunc.fxcuentacontable(pccodcta, lccodlin, lcnorref, "MO", lcdescob, lccondic, lctippag, pcbanco, lnmora, lnintcap, lndifint)
                    lnnumlin = lnnumlin + 1
                    entidadcntamov.ccodcta = lcctactb
                    entidadcntamov.cnumlin = lnnumlin
                    entidadcntamov.nhaber = 0
                    entidadcntamov.ndebe = Math.Round(lnmora, 2)
                    entidadcntamov.ccodpres = lccodcta
                    entidadcntamov.cnumdoc = pcnuming
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = gdfecsis
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = "01" 'lccodfue
                    entidadcntamov.cclase = Left(lccodcta, 1)
                    entidadcntamov.cpoliza = "ING"
                    entidadcntamov.dfecmod = gdfecsis

                    entidadcntamov.ccodsec = ""
                    entidadcntamov.cconcepto = "REGISTRO DE CAJA COND. MORA"
                    entidadcntamov.cnumpol = ""
                    entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                    entidadcntamov.ccodcli = lccodcli
                    entidadcntamov.corden = lcorden

                    str_select = "insert into cntamov " & _
                                "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                                "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                                "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                                "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                                "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                                "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                                miclase1.ToString(entidadcntamov.ccodofi) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                                "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return error100
                    End If
                End If




            Else
                'contabilidad
                lnnumlin = lnnumlin + 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin
                entidadcntamov.nhaber = 0
                entidadcntamov.ndebe = Math.Round(lntotapag, 2)
                entidadcntamov.ccodpres = lccodcta
                entidadcntamov.cnumdoc = pcnuming
                entidadcntamov.ccodofi = gccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = gdfecsis
                entidadcntamov.ccodusu1 = gccodusu
                entidadcntamov.ffondos = lccodfue
                entidadcntamov.cclase = Left(lccodcta, 1)
                entidadcntamov.cpoliza = "ING"
                entidadcntamov.dfecmod = gdfecsis

                entidadcntamov.ccodsec = ""
                entidadcntamov.cconcepto = "REGISTRO DE CAJA"
                entidadcntamov.cnumpol = ""
                entidadcntamov.ccodreg = lccodcta.Substring(0, 3)
                entidadcntamov.ccodcli = lccodcli
                entidadcntamov.corden = lcorden

                str_select = "insert into cntamov " & _
                            "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, " & _
                            "ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                            "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco, dfecmod, cnumrec) values " & _
                            "(' ','01', '" & lcnumcom & "', '" & entidadcntamov.cnumlin & "', '" & entidadcntamov.ccodcta & "', '" & Left(entidadcntamov.ccodcta, 1) & _
                            "', " & entidadcntamov.ndebe & "," & entidadcntamov.nhaber & ", ' ', 0, '" & entidadcntamov.cnumdoc & "', " & _
                            "'" & fecha1 & "', '" & entidadcntamov.ccodpres & "'," & miclase1.ToString(entidadcntamov.cconcepto) & "," & miclase1.ToString(entidadcntamov.cpoliza) & "," & _
                            miclase1.ToString(lcCodOfi_Caj) & ", ' ', " & miclase1.ToString(entidadcntamov.ccodreg) & ", '" & entidadcntamov.ccodcli & "', '" & gccodusu & "', " & _
                            "' '," & miclase1.ToString(entidadcntamov.corden) & ",0, 0, " & miclase1.ToString(fecha1) & "," & miclase1.ToString(fecha1) & "," & miclase1.ToString(pcnuming0.ToString) & ")"

                error100 = miclase.nonquery_sin_parametros(con, str_select)
                If error100 = -100 Then
                    Return error100
                End If

            End If
        End If



        'ACTUALIZA NUMLIN EN LA CNTAMOV, PORQUE SON PAGOS Y CONTINUARA DONDE SE QUEDO
        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "GNNUMLIN"
        etabtvar.lcarini = True

        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.cconvar = lnnumlin.ToString.Trim
        etabtvar.cdesvar = "NUMERO DE REGISTRO EN LA CNTAMOV"
        etabtvar.ctipvar = "C"
        etabtvar.ccodusu = Me.lccodusu1
        etabtvar.cflag = ""

        Try
            mtabtvar.ActualizarTabtvar(etabtvar)
        Catch ex As Exception
            error100 = -100
            Return error100
        End Try

        ' FIN DE ACTUALIZACION DE NUMLIN EN LA DE PAGOS


        'actualiza tablas creditos
        'mxupdatetmp
        Dim lncapdes As Double
        Dim lcestado As String
        Dim ldfecter As Date
        Dim ldultpag As Date
        Dim pdultima As Date
        Dim lnintpen As Double
        Dim lnpagcta As Double
        Dim lnmorpag As Double
        Dim lncappag As Double
        Dim lngaspag As Double
        Dim resultadocremcre As Integer
        Dim ldfecapr As Date
        Dim ldfectra As Date
        Dim lnmoncuo As Double

        lnintpen = 0
        lnpagcta = 0
        lnmorpag = 0

        lncapdes = entidad1.ncapdes
        ldfecapr = entidad1.dfecapr
        ldfectra = entidad1.dfectra
        lnmoncuo = entidad1.nmoncuo

        If Math.Round(entidad1.ncapdes, 2) <= Math.Round(entidad1.ncappag + lnpagocap + lnpagocap1, 2) Then
            lcestado = "G"
        Else
            lcestado = entidad1.cestado
        End If
        If lcestado = "G" Then
            ldfecter = pdfecval
        End If
        If lnpagocap > 0 Then
            ldultpag = pdfecval
        Else
            ldultpag = entidad1.dultpag
        End If
        If entidad1.dultpag = Nothing Then
            pdultima = entidad1.dfecvig
        Else
            pdultima = entidad1.dultpag
        End If

        If entidad1.nintpag + entidad1.nintpen + lnintere >= entidad1.nintcal Then
            lnintpag = entidad1.nintpag + entidad1.nintpen + lnintere
        Else
            lnintpag = entidad1.nintpag
            lnintpen = lnintpen + lnintere
        End If

        If entidad1.nmorpag + entidad1.npagcta + lnintmor >= entidad1.nintmor Then
            lnmorpag = entidad1.nmorpag + entidad1.npagcta + lnintmor
        Else
            lnmorpag = entidad1.nmorpag
            lnpagcta = lnpagcta + lnintmor
        End If
        lncappag = entidad1.ncappag + lnpagocap + lnpagocap1
        lngaspag = entidad1.ngaspag + lngastot

        entidad1.ncappag = lncappag
        entidad1.nintpag = lnintpag
        entidad1.nintpen = lnintpen
        entidad1.nmorpag = lnmorpag
        entidad1.npagcta = lnpagcta
        entidad1.ngaspag = lngaspag
        entidad1.cestado = lcestado
        entidad1.dfecter = ldfecter
        entidad1.dultpag = ldultpag
        entidad1.dfecmod = gdfecsis
        entidad1.dfecasi = gdfecsis
        entidad1.dfecadm = gdfecsis
        entidad1.dfecapr = ldfecapr
        entidad1.dfecter = gdfecsis
        entidad1.dfecadm = gdfecsis
        entidad1.dfectra = ldfectra
        entidad1.lctaret = 1
        entidad1.cflag = "1"
        entidad1.cflag = ""
        entidad1.dfectra = gdfecsis
        entidad1.nmoncuo = lnmoncuo

        str_select = "update cremcre set " & _
                     "ncappag=" & lncappag & ",nintpag=" & lnintpag & ",nintpen=" & lnintpen & ",nmorpag=" & lnmorpag & ",npagcta=" & lnpagcta & "," & _
                     "ngaspag=" & lngaspag & ",cestado=" & miclase1.ToString(lcestado) & "," & _
                     "dultpag=" & miclase1.ToString(miclase1.transformar_fecha_mdy_to_dmy(ldultpag)) & ",dfecmod=" & miclase1.ToString(fecha1) & "," & _
                     "dfecasi=" & miclase1.ToString(fecha1) & ",dfecadm=" & miclase1.ToString(fecha1) & ",dfecapr=" & miclase1.ToString(miclase1.transformar_fecha_mdy_to_dmy(ldfecapr)) & "," & _
                     "dfecter=" & miclase1.ToString(fecha1) & ",dfectra=" & miclase1.ToString(ldfectra) & "," & _
                     "lctaret=1,cflag=' ', nmoncuo=" & lnmoncuo & " where ccodcta = " & miclase1.ToString(pccodcta)
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            Return error100
        End If

        'ecreditos.ActualizarCremcre(entidad1)


        Return 1
        ' Catch
        '   End Try

    End Function


    Public Function Deposito_Concentradora_Transac(ByVal con As SqlConnection, ByVal pccodcli As String, _
                                                   ByVal pnmonpag As Double) As Integer

        Dim str_select As String
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim error100 As Integer
        Dim fecha1 As String
        Dim fecha2 As String
        Dim ds As New DataSet
        Dim lccodaho As String
        Dim lnsaldoaho As Double = 0
        Dim lnsaldo As Double = 0
        Dim lnlinea As Integer
        Dim lncorrel As Integer
        Dim lcnrolin As String

        If pnmonpag > 0 Then
            str_select = _
                          " Select ccodaho from ahomcta where substring(ccodaho,7,2) = '01' " & _
                          " and cestado = 'A' and cnudotr = '" & pccodcli & "'"


            ds = miclase.devolver_dataset(con, str_select)

            For Each fila As DataRow In ds.Tables(0).Rows
                pcctaahovis = fila("ccodaho")
            Next


            'Agregamos a cuenta de ahorro a la vista
            lccodaho = pcctaahovis

            If lccodaho.Trim = "" Then
                Return 2
            Else

                Dim fila As DataRow


                str_select = "select nnum, nsaldoaho from ahomcta where ccodaho = " & miclase1.ToString(lccodaho)
                ds = miclase.devolver_dataset(con, str_select)


                lnsaldoaho = 0

                If pnmonpag > 0 Then
                    For Each fila In ds.Tables(0).Rows
                        lnsaldoaho = fila("nsaldoaho")
                        lnlinea = fila("nnum")
                        lncorrel = fila("nnum")
                    Next



                    'Otiene saldo actual de la cuenta

                    lnsaldo = lnsaldoaho + pnmonpag

                    lnlinea += 1
                    If lnlinea > 65 Then
                        lnlinea = 1
                    End If

                    entidadahommov.ccodaho = lccodaho
                    entidadahommov.dfecope = gdfecsis
                    entidadahommov.ctipope = "D"
                    entidadahommov.ctipdoc = "E"
                    entidadahommov.cnumdoc = "0001"
                    entidadahommov.crazon = "Dep.x cuota prestamo cancelado"
                    entidadahommov.nmonto = pnmonpag
                    entidadahommov.clinea = "N"
                    entidadahommov.ncorrel = lncorrel
                    entidadahommov.dfecmod = Now
                    entidadahommov.ccodusu = gccodusu
                    entidadahommov.nnum = lnlinea
                    entidadahommov.nsaldoaho = lnsaldo
                    entidadahommov.nsaldnind = lnsaldo
                    entidadahommov.cconcep = "DP"
                    entidadahommov.nlibreta = 0
                    entidadahommov.cnrochq = ""
                    entidadahommov.ctipchq = ""
                    entidadahommov.dfecomp = gdfecsis
                    entidadahommov.dfecefe = gdfecsis
                    entidadahommov.npartida = "0"
                    entidadahommov.interes = "0"
                    entidadahommov.tip = ""
                    entidadahommov.ctipaho = lccodaho.Substring(6, 2)
                    entidadahommov.producto = ""
                    entidadahommov.ncompen = 1
                    entidadahommov.ccodtra = ""
                    entidadahommov.notromon = 0
                    entidadahommov.pagina = 0 'lnpagina
                    'eahommov.agregar(entidadahommov)

                    'Obtiene Linea de ahorro a la vista
                    Dim eahotlin As New cAhotlin
                    lcnrolin = eahotlin.ObtieneLineaAhorro(lccodaho.Substring(6, 2))

                    'Dim etabtofi As New cTabtofi
                    'Dim lcnomofi As String
                    'lcnomofi = etabtofi.NombreAgencia(gccodofi)


                    'Actualiza en la ahomcta
                    entidadahomcta.ccodaho = lccodaho
                    eahomcta.ObtenerAhomcta(entidadahomcta)

                    entidadahomcta.ccodcta = lccodcta
                    entidadahomcta.cnrolin = lcnrolin
                    entidadahomcta.cnudotr = lccodcli
                    entidadahomcta.dfecapr = gdfecsis
                    entidadahomcta.dfecmod = Now
                    entidadahomcta.ccodusu = gccodusu
                    entidadahomcta.nombre = lcnomcli
                    entidadahomcta.nsaldoaho = lnsaldo
                    entidadahomcta.nmonapr = lnsaldo
                    entidadahomcta.nsaldnind = lnsaldo
                    entidadahomcta.nnum = lncorrel
                    entidadahomcta.nmonres = (entidadahomcta.nmonres + pnmorpag)
                    entidadahomcta.dfechault = gdfecsis
                    entidadahomcta.llave = "P.CUOTA"
                    entidadahomcta.cmotivo = "" 'lcnomofi

                    str_select = "insert into ahommov " & _
                           "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                           "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                           "('" & lccodaho & "', '" & fecha1 & "', 'D', '" & entidadahommov.cnumdoc & "', 'E', 'Dep.x cuota prestamo', " & entidadahommov.nlibreta & "," & miclase1.ToString(entidadahommov.cnrochq) & "," & miclase1.ToString(entidadahommov.ctipchq) & "," & _
                           "'" & fecha1 & " ', '" & fecha1 & "', 0, '" & entidadahommov.nmonto & "', 0, 'N', " & _
                           lnlinea & ", '" & fecha1 & "', '" & entidadahommov.ccodusu & "', " & lnlinea & ", ' ', " & lnsaldo & ", " & lnsaldo & ", 'DP', " & _
                           "'" & entidadahommov.ctipaho & "', ' ', " & entidadahommov.ncompen & ", ' ', 0)"

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return error100
                    End If

                    str_select = "update ahomcta " & _
                                 "set ncorrel=" & lnlinea & ",nsaldoaho=" & lnsaldo & ",nsaldnind=" & lnsaldo & ",dfechault=" & miclase1.ToString(fecha1) & _
                                 ",dfecult=" & miclase1.ToString(fecha1) & ",dfecmod=" & miclase1.ToString(fecha1) & _
                                 ",dultmov=" & miclase1.ToString(fecha1) & ",nnum=" & lnlinea & ",nmonres=" & entidadahomcta.nmonres & ",cmotivo=" & miclase1.ToString(entidadahomcta.cmotivo) & _
                                 " where ccodaho=" & miclase1.ToString(lccodaho)

                    error100 = miclase.nonquery_sin_parametros(con, str_select)
                    If error100 = -100 Then
                        Return error100
                    End If
                End If
            End If
        End If


        Return 1

    End Function

End Class
