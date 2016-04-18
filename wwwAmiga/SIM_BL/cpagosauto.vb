Imports System.Data.SqlClient

Public Class cpagosauto

    Dim oktransac As Integer

    Private lccodcta As String
    Public Property pccodcta() As String
        Get
            pccodcta = lccodcta
        End Get
        Set(ByVal Value As String)
            lccodcta = Value
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

    Private lnporiva As Double
    Public Property pnporiva() As Double
        Get
            pnporiva = lnporiva
        End Get
        Set(ByVal Value As Double)
            lnporiva = Value
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

    Private _segdan As Double
    Public Property segdan() As Double
        Get
            segdan = _segdan
        End Get
        Set(ByVal Value As Double)
            _segdan = Value
        End Set
    End Property

    Private _reserva As Double
    Public Property reserva() As Double
        Get
            reserva = _reserva
        End Get
        Set(ByVal Value As Double)
            _reserva = Value
        End Set
    End Property

    Private _talona As Double
    Public Property talona() As Double
        Get
            talona = _talona
        End Get
        Set(ByVal Value As Double)
            _talona = Value
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
    'agregados para los pagos automaticos

    Private _gncorrela As Double
    Public Property gncorrela() As Double
        Get
            gncorrela = _gncorrela
        End Get
        Set(ByVal Value As Double)
            _gncorrela = Value
        End Set
    End Property


    Private _gnperbas As Double
    Public Property gnperbas() As Double
        Get
            gnperbas = _gnperbas
        End Get
        Set(ByVal Value As Double)
            _gnperbas = Value
        End Set
    End Property

    Private _gncosind As Double
    Public Property gncosind() As Double
        Get
            gncosind = _gncosind
        End Get
        Set(ByVal Value As Double)
            _gncosind = Value
        End Set
    End Property

    Private _gnmora As Double
    Public Property gnmora() As Double
        Get
            gnmora = _gnmora
        End Get
        Set(ByVal Value As Double)
            _gnmora = Value
        End Set
    End Property

    Private _gnsegdeu As Double
    Public Property gnsegdeu() As Double
        Get
            gnsegdeu = _gnsegdeu
        End Get
        Set(ByVal Value As Double)
            _gnsegdeu = Value
        End Set
    End Property
    Private _gnsegdeu1 As Double
    Public Property gnsegdeu1() As Double
        Get
            gnsegdeu1 = _gnsegdeu1
        End Get
        Set(ByVal Value As Double)
            _gnsegdeu1 = Value
        End Set
    End Property
    Private _gnmanejo As Double
    Public Property gnmanejo() As Double
        Get
            gnmanejo = _gnmanejo
        End Get
        Set(ByVal Value As Double)
            _gnmanejo = Value
        End Set
    End Property

    Private _gnporseg As Double
    Public Property gnporseg() As Double
        Get
            gnporseg = _gnporseg
        End Get
        Set(ByVal Value As Double)
            _gnporseg = Value
        End Set
    End Property

    Private _gniva As Double
    Public Property gniva() As Double
        Get
            gniva = _gniva
        End Get
        Set(ByVal Value As Double)
            _gniva = Value
        End Set
    End Property

    Private _gnsegdan As Double
    Public Property gnsegdan() As Double
        Get
            gnsegdan = _gnsegdan
        End Get
        Set(ByVal Value As Double)
            _gnsegdan = Value
        End Set
    End Property

    Private _gnporres As Double
    Public Property gnporres() As Double
        Get
            gnporres = _gnporres
        End Get
        Set(ByVal Value As Double)
            _gnporres = Value
        End Set
    End Property

    Private _gntalona As Double
    Public Property gntalona() As Double
        Get
            gntalona = _gntalona
        End Get
        Set(ByVal Value As Double)
            _gntalona = Value
        End Set
    End Property

    Private _gdfecmor As Date
    Public Property gdfecmor() As Date
        Get
            gdfecmor = _gdfecmor
        End Get
        Set(ByVal Value As Date)
            _gdfecmor = Value
        End Set
    End Property
    Private _gnpergra As Integer
    Public Property gnpergra() As Integer
        Get
            gnpergra = _gnpergra
        End Get
        Set(ByVal value As Integer)
            _gnpergra = value
        End Set
    End Property

    Private _gcCodofi As String
    Public Property gcCodofi() As String
        Get
            gcCodofi = _gcCodofi
        End Get
        Set(ByVal value As String)
            _gcCodofi = value
        End Set
    End Property
    'procesar pagos automaticos


    Public Function fxpagosautomaticos(ByVal lcnombar As String, ByVal ldfecbar As Date, ByRef dspagos1 As DataSet, _
                                       ByVal lcancela As Boolean, ByVal pnporint As Double, ByVal cnuevo As String, _
                                       ByVal pnDiagra As Integer) As Integer


        Dim fila As DataRow
        Dim cls1 As New pagdesver
        Dim lccodcta As String

        Dim mcreditos As New ccreditos
        Dim ecreditos As New creditos
        Dim clsaplica As New payment

        Dim lnpropseg As Double
        Dim lnpropman As Double
        Dim lnperbas As Double
        Dim lnporsegdeu As Double
        Dim lnporsegdan As Double
        Dim lnporres As Double
        Dim lnportalona As Double
        Dim lccomprobante As String = ""
        Dim lccomprobante0 As String = ""
        Dim ok As Integer
        Dim okpago As Integer
        Dim lcnrolin As String
        Dim ecretlin As New cretlin
        Dim mcretlin As New cCretlin
        Dim lcnomcli As String
        Dim lineasegdeu As Boolean
        Dim lsegdan, lreserva, ltalona, ladmon As String
        Dim llsolidario As Boolean
        Dim lnsegdeu, lnsegdan, lnreserva, lntalona, lngasadm As Double
        Dim lcflat As String = ""
        Dim lnmora As Double = 0
        Dim clsppal As New class1
        'lee un archivo de texto
        Dim etabtofi As New cTabtofi
        Dim lnmontoint As Decimal = 0

        For Each fila In dspagos1.Tables(0).Rows
            If IsDBNull(fila("cflag")) Then
                lccomprobante0 = etabtofi.ObtieneCorrelativo(fila("ccodofi"))


                '***** optiene datos aplicar **
                lccodcta = fila("ccodcta")
                lnmonpag = fila("nmonto")
                lccodcli = fila("ccodcli")
                'lccomprobante = fila("cnuming")
                ' lccomprobante0 = fila("cnuming0")

                llsolidario = False 'fila("lsol")

                ecreditos.ccodcta = lccodcta
                mcreditos.Obtenercreditos(ecreditos)

                'Me.pcbanco = ecreditos.ccodpag
                clsaplica.pccodcta = lccodcta
                clsaplica.pccodcli = ecreditos.ccodcli
                clsaplica.pnprima = 0
                clsaplica.pncosdir = ecreditos.ncapdes
                clsaplica.pncosind = 0
                clsaplica.pnsubcidio = ecreditos.nahoprg
                clsaplica.pcflat = ecreditos.cflat
                lcflat = ecreditos.cflat
                '  clsaplica.pdfecdes = ecreditos.dfecvig
                Dim ldfecvig As Date
                ldfecvig = ecreditos.dfecvig
                lcnrolin = ecreditos.cnrolin
                lcnomcli = ecreditos.cnomcli

                ldfecval = Date.Parse(fila("dfecpag"))
                'ldfecval = ldfecbar
                clsaplica.pccodcta = lccodcta
                clsaplica.pdfecval = ldfecval
                clsaplica.gdfecsis = Me.gdfecsis
                clsaplica.gnperbas = gnperbas
                clsaplica.cosind = gncosind
                clsaplica.gnmora = gnmora
                clsaplica.gdultpag = #2/1/1970# 'ecreditos.dultpag


                If ldfecvig >= #7/11/2008# Then
                    lnpropseg = gnsegdeu1
                Else
                    lnpropseg = gnsegdeu
                End If


                lnpropman = gnmanejo
                lnperbas = gnperbas
                lnporsegdeu = gnporseg
                lnporsegdan = gnsegdan
                lnporres = gnporres
                lnportalona = gntalona
                gdfecmor = Me.gdfecmor

                clsaplica.porsegdeu = lnpropseg
                clsaplica.porcomision = lnpropman

                clsaplica.porres = lnporres
                clsaplica.portalona = lnportalona

                clsaplica.gdfecmor = gdfecmor
                ok = 0

                'obtiene datos de los seguros

                ecretlin.cnrolin = lcnrolin
                mcretlin.ObtenerCretlin(ecretlin)
                lineasegdeu = ecretlin.lsegdeu
                Dim lccodlin As String
                lccodlin = ecretlin.ccodlin
                clsaplica.pcestado = "F"
                clsaplica.gnpergra = Me.gnpergra
                ok = clsaplica.omcalcinterest("T", ldfecval)

                '************ finaliza obtencion de datos *********
                Dim lnintere As Double = 0
                If ok = 1 Then
                    '********* efectua el P A G O ***********


                    cls1.pccodcta = lccodcta
                    cls1.pncapita = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    cls1.pnsalint = utilNumeros.Redondear(clsaplica.pnsalint, 2)

                    cls1.pncomision = lncomision 'costos adminisrativos
                    cls1.pccodcli = lccodcli

                    cls1.pncomision = 0
                    cls1.pnhonorarios = 0
                    cls1.pngestion = 0
                    cls1.pnmonpag = lnmonpag
                    cls1.pdfecval = ldfecval
                    cls1.pndeucap = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                    cls1.pcbanco = Me.pcbanco.Trim
                    cls1.pctippag = Me.pctippag.Trim
                    cls1.pcnuming = lccomprobante0.Trim
                    cls1.pcnuming0 = "ATM-" & fila("ccodofi") & lccomprobante0.Trim
                    cls1.gdfecsis = Me.gdfecsis
                    cls1.gccodusu = Me.gccodusu

                    lnmora = utilNumeros.Redondear(clsaplica.pnsalmor, 2)


                    cls1.pnhonorarios = 0
                    cls1.pngestion = 0
                    cls1.pnmonpag = lnmonpag
                    cls1.pdfecval = ldfecval
                    cls1.pndeucap = cls1.pncapita
                    'cls1.pcnuming = lccomprobante
                    cls1.gdfecsis = Me.gdfecsis 'ldfecbar
                    'cls1.gccodusu = "9999"
                    cls1.ahovis = 0

                    'actualiza propiedades de la pagdesver

                    cls1.pnintpag = clsaplica.pnintpag
                    cls1.pnintpen = clsaplica.pnintpen
                    cls1.pnintcal = clsaplica.pnintcal
                    cls1.pnmorpag = clsaplica.pnmorpag
                    cls1.pnpagcta = clsaplica.pnpagcta

                    'Nuevo Analisis de Gracia especial AMIGA Mexico 04/05/2015
                    If clsaplica.pndiaatr > pnDiagra Then
                        cls1.pnintmor = clsaplica.pnintmor
                        cls1.pnsalmor = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
                    Else
                        cls1.pnintmor = 0
                        cls1.pnsalmor = 0
                    End If

                    cls1.pdultpag = clsaplica.pdultpag
                    cls1.pncappag = clsaplica.pncapdes - clsaplica.pncappag
                    cls1.pccodcli = lccodcli
                    ' cls1.tipopag = "A"
                    cls1.pndiaatr = clsaplica.pndiaatr
                    cls1.pncappag = clsaplica.pncappag
                    cls1.gniva = Me.gniva


                    'Calcula comision ----------------------
                    Dim ecredkar As New cCredkar
                    Dim ldultfecha As Date
                    ldultfecha = ecredkar.UltimafechaProceso(lccodcta, ldfecval)
                    Dim lndias As Integer
                    Dim lniva As Decimal = 0
                    Dim lniva1 As Decimal = 0
                    Dim lniva2 As Decimal = 0
                    Dim lniva3 As Decimal = 0
                    Dim lnmanejo As Decimal = 0

                    lndias = DateDiff(DateInterval.Day, ldultfecha, ldfecval)
                    lncomision = 0

                    lnsegdeu = clsppal.CalcularSeguroDeuda(lccodcta, ldfecval, clsaplica.pncapdes, clsaplica.pdfecvig)
                    lnmanejo = clsppal.CalcularManejo(lccodcta, ldfecval, clsaplica.pncapdes, lcancela)
                    lniva = 0
                    cls1.niva = lniva
                    cls1.manejo = lnmanejo
                    cls1.segdeu = lnsegdeu
                    cls1.lsolidario = llsolidario


                    If lcflat = "F" Then

                        lnmontoint = lnmonpag - clsaplica.pnsalmor  'se le quita gastos en intereses moratorios

                        If lnmontoint < 0 Then
                            lnmontoint = 0
                        End If

                        '                        lnintere = clsaplica.InteresFlatCobrar(lccodcta, lnmontoint, ldfecval)

                        If lcancela = True Then
                            clsaplica.porinteres = pnporint
                            'lnintere = clsaplica.interesCancelacion(lccodcta, ldfecval)

                            lncapita = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            lnmonpag = Math.Round(lncapita + lnintere + lnmora + lncomision + lnhonorarios + lngestion, 2)
                        Else
                            'lnintere = cls1.pnsalint 'clsaplica.InteresaAplicar(lccodcta, Math.Round(lnmonpag - (lncomision + lnhonorarios + lngestion + lnmora), 2))
                            lnintere = clsaplica.InteresFlatCobrar(lccodcta, lnmontoint, ldfecval)
                        End If
                        '                        cls1.pnsalint = lnintere
                        cls1.pnsalint = lnintere
                    End If


                    ''------------------------------------------------------------------------------
                    ''recalcula IVA en base a lo que realmente paga
                    ''------------------------------------------------------------------------------
                    Dim lnpago As Double = lnmonpag
                    Dim lnivar As Decimal = 0

                    If lnpago < (lnsegdeu + lnmanejo + lnmora + lnintere + lniva) Then



                        If lnpago >= lnsegdeu Then
                            lnpago = Math.Round(lnpago - lnsegdeu, 2)

                            If lnpago >= Math.Round((lnmanejo + (lnmanejo * pnporiva / 100)), 2) Then
                                lnpago = lnpago - (lnmanejo + Math.Round((lnmanejo * pnporiva / 100), 2))
                                lnivar = Math.Round((lnmanejo * pnporiva / 100), 2)

                                If lnpago > 0 Then
                                    If lnpago >= Math.Round((lnmora + (lnmora * pnporiva / 100)), 2) Then
                                        lnpago = lnpago - (lnmora + Math.Round((lnmora * pnporiva / 100), 2))
                                        lnivar = lnivar + Math.Round((lnmora * pnporiva / 100), 2)
                                        If lnpago > 0 Then
                                            If lnpago >= Math.Round((lnintere + (lnintere * pnporiva / 100)), 2) Then
                                                lnpago = lnpago - (lnintere + Math.Round((lnintere * pnporiva / 100), 2))
                                                lnivar = lnivar + Math.Round((lnintere * pnporiva / 100), 2)
                                            Else
                                                lnintere = Math.Round(lnpago / (1 + (pnporiva / 100)), 2)
                                                lnivar = Math.Round(lnivar + Math.Round((lnintere * pnporiva / 100), 2), 2)
                                                lnpago = 0
                                            End If

                                        End If
                                    Else
                                        lnmora = Math.Round(lnpago / (1 + (pnporiva / 100)), 2)
                                        lnivar = Math.Round(lnivar + Math.Round(((lnmora) * pnporiva / 100), 2), 2)
                                        lnpago = 0
                                    End If

                                End If
                            Else
                                lnmanejo = Math.Round(lnpago / (1 + (pnporiva / 100)), 2)
                                lnivar = Math.Round((lnmanejo) * pnporiva / 100, 2)
                                lnpago = 0
                            End If


                        Else
                            lnpago = 0
                        End If

                        cls1.niva = Math.Round(lnivar, 2)
                    End If

                    '---------------------------------------

                    cls1.gcpuente = Me.gcpuente
                    cls1.pccolector = Me.pccolector   ' 1 Banamex, 2 Paynet

                    Dim error100 As Integer
                    Dim miclase As New clase_jaime
                    Dim miclase1 As New clase_funciones
                    Dim con As New SqlConnection
                    Dim stringconnection As String = miclase.conexion()
                    Dim str_select As String = ""
                    con.ConnectionString = stringconnection

                    con.Open()


                    str_select = "SET LANGUAGE spanish; begin tran"
                    error100 = miclase.nonquery_sin_parametros(con, str_select)

                    If error100 = -100 Then
                        str_select = "rollback tran"
                        error100 = miclase.nonquery_sin_parametros(con, str_select)
                        con.Close()

                        'codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK, " & _
                        '                 "Advertencia SIM.NET ')</script>"


                        'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                        Exit Function
                    End If

                    cls1.pcCodctaAho = ""

                    okpago = 0
                    'okpago = cls1.mxdistribute()

                    error100 = cls1.mxdistribute_Transac(con)


                    If error100 = -100 Then
                        okpago = 0
                        str_select = "rollback tran"
                        error100 = miclase.nonquery_sin_parametros(con, str_select)
                        con.Close()

                        'codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                        '               "Advertencia SIM.NET ')</script>"

                        'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                        Exit Function
                    End If

                    str_select = "commit tran"
                    error100 = miclase.nonquery_sin_parametros(con, str_select)

                    If error100 = -100 Then
                        okpago = 0
                        str_select = "rollback tran"
                        error100 = miclase.nonquery_sin_parametros(con, str_select)
                        con.Close()

                        'codigoJs = "<script language='javascript'>alert(''Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                        '               "Advertencia SIM.NET ')</script>"

                        'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                        Exit Function
                    End If

                    con.Close()

                    If error100 <> -100 Then
                        okpago = 1
                    End If


                    If okpago = 0 Then
                        fila("cflag") = "X" ' no se puede aplicar el pago
                        fila("cmotivo") = "Error plantilla contable" ' no se puede aplicar el pago

                        'actualiza pago
                        Me.gncorrela = Integer.Parse(lccomprobante0)

                    Else
                        fila("cflag") = " "
                        fila("cmotivo") = "ok" ' 
                        etabtofi.ActualizaCorrelativo(fila("ccodofi"), lccomprobante0)
                    End If
                Else

                    fila("cflag") = "X" ' no se puede aplicar el pago
                    fila("cmotivo") = "Error al cargar datos del pago" ' no se puede aplicar el pago
                End If

            End If

        Next

        If lccomprobante.Trim.Length > 0 Then
            Me.gncorrela = Integer.Parse(lccomprobante0)
        End If

    End Function

End Class
