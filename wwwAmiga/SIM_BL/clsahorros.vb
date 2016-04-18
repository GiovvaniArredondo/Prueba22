Public Class clsahorros
#Region " Propiedades "

    Private _ccodaho As String
    Private _ccodcli As String
    Private _nahorros As Double
    Private _nsaldocre As Double
    Private _pdfecha As Date
    Private _gccodofi As String
    Private _pccodcaja As String

    Public Property ccodaho() As String
        Get
            Return _ccodaho
        End Get
        Set(ByVal Value As String)
            _ccodaho = Value
        End Set
    End Property

    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property

    Public Property gccodofi() As String
        Get
            Return _gccodofi
        End Get
        Set(ByVal Value As String)
            _gccodofi = Value
        End Set
    End Property

    Public Property nahorros() As Double
        Get
            Return _nahorros
        End Get
        Set(ByVal Value As Double)
            _nahorros = Value
        End Set
    End Property

    Public Property nsaldocre() As Double
        Get
            Return _nsaldocre
        End Get
        Set(ByVal Value As Double)
            _nsaldocre = Value
        End Set
    End Property


    Public Property pdfecha() As Date
        Get
            Return _pdfecha
        End Get
        Set(ByVal Value As Date)
            _pdfecha = Value
        End Set
    End Property

    Public Property pccodcaja() As String
        Get
            Return _pccodcaja
        End Get
        Set(ByVal Value As String)
            _pccodcaja = Value
        End Set
    End Property

#End Region


#Region " Métodos "

    'obtiene saldos para grid
    Dim mahomcta As New cAhomcta
    Dim eahomcta As New ahomcta

    Dim ecreditos As New creditos
    Dim mcreditos As New ccreditos

    Dim listacre As New listacreditos
    Dim listaaho As New listaahomcta


    Sub liquidasocio()
        Dim lccodaho As String
        Dim lnsaldoaho As Double
        Dim lnsaldocre As Double
        Dim lnsalaho1 As Double
        Dim lnsalaho2 As Double
        Dim lnremanente As Double
        Dim lnsalaho3 As Double
        Dim lnsalahosocio As Double

        Dim cahomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta

        Dim cahommov1 As New cAhommov
        Dim ahommov1 As New ahommov
        Dim lnsaldo As Double
        Dim lnnewsal As Double
        Dim lnnumlin As Integer
        Dim lcnumpar As String
        Dim lccodofi As String
        Dim lcctactb As String
        Dim lnnumlin2 As Integer


        Dim clspago As New pagdesver
        cargaahorros()
        cargacreditos()

        lnsaldoaho = Me.nahorros
        lnsaldocre = Me.nsaldocre
        lnsalaho2 = 0
        lnremanente = 0
        lnsalaho3 = 0
        'cancelara los creditos
        lccodofi = Me.gccodofi

        For Each eahomcta In listaaho
            lccodaho = eahomcta.ccodaho
            lnsalaho1 = eahomcta.nsaldoaho + lnremanente
            lnsalahosocio = eahomcta.nsaldoaho
            'primero cancela creditos
            lnsalaho3 = lnsalaho1
            cargacreditos() 'debe actualizarse cada vez que entra al bocle para ver pagos
            For Each ecreditos In listacre
                If lnsalaho3 > 0 Then

                    If ecreditos.nsalcap + ecreditos.nsalint + ecreditos.nsalmor >= lnsalaho1 Then
                        lnsalaho2 = lnsalaho1
                        lnremanente = 0
                    Else
                        lnsalaho2 = lnsalaho1 - (ecreditos.nsalcap + ecreditos.nsalint + ecreditos.nsalmor)
                        lnremanente = lnsalaho2 'lo que sobro del anterior ahorro
                    End If
                    lnsalaho3 = lnremanente
                    If ecreditos.nsalcap + ecreditos.nsalint + ecreditos.nsalmor > 0 Then
                        clspago.pccodcta = ecreditos.ccodcta
                        clspago.pccodcli = ecreditos.ccodcli
                        clspago.pcnomcli = ecreditos.cnomcli
                        clspago.pncapdes = ecreditos.ncapdes
                        clspago.pnsalint = ecreditos.nsalint
                        clspago.pnsalmor = ecreditos.nsalmor
                        clspago.pnmoncuo = ecreditos.nmoncuo
                        clspago.pndiaatr = ecreditos.ndiaatr
                        clspago.pndeucap = ecreditos.nsalcap
                        clspago.pdfecval = Me.pdfecha
                        clspago.pncapita = ecreditos.nsalcap
                        clspago.pncomision = 0
                        clspago.pnhonorarios = 0
                        clspago.pnmonpag = lnsalaho2
                        clspago.pcbanco = "05"
                        clspago.pctippag = "A"
                        clspago.pcnuming = "LIQ."
                        clspago.pnintpag = ecreditos.nintpag
                        clspago.pnintpen = ecreditos.nintpen
                        clspago.pnintcal = ecreditos.nintcal
                        clspago.pnpagcta = ecreditos.npagcta
                        clspago.pnintmor = ecreditos.nintmor
                        clspago.pncappag = ecreditos.ncappag
                        clspago.gdfecsis = Me.pdfecha
                        clspago.mxdistribute()
                    End If

                End If
            Next
            'cancelara cuenta de ahorros


            If lccodaho <> Nothing And lnsalahosocio > 0 Then


                'busca el saldo de las cuentas 
                ahomcta1.ccodaho = lccodaho
                cahomcta1.ObtenerAhomcta(ahomcta1)
                lnsaldo = ahomcta1.nsaldoaho
                lnnewsal = lnsaldo - lnsalahosocio ' retiro
                lnnumlin = ahomcta1.nnum + 1

                ahomcta1.nsaldoaho = lnnewsal
                ahomcta1.dfechault = Me.pdfecha
                ahomcta1.dfecult = Me.pdfecha
                ahomcta1.dfecmod = Me.pdfecha
                ahomcta1.dultmov = Me.pdfecha
                ahomcta1.nnum = lnnumlin
                cahomcta1.ActualizarAhomcta(ahomcta1)

                'graba los movimientos
                ahommov1.ccodaho = lccodaho
                ahommov1.nnum = lnnumlin
                ahommov1.nmonto = lnsalahosocio
                ahommov1.nsaldoaho = lnnewsal
                ahommov1.nsaldnind = lnnewsal
                ahommov1.cconcep = "RE"
                ahommov1.ccodusu = "9999"
                ahommov1.cnumdoc = "LIQ."
                ahommov1.dfecefe = Me.pdfecha
                ahommov1.dfecomp = Me.pdfecha
                ahommov1.dfecmod = Me.pdfecha
                ahommov1.dfecope = Me.pdfecha
                ahommov1.clinea = "S"
                ahommov1.npartida = 0
                ahommov1.interes = 0
                ahommov1.ctipope = "D"
                ahommov1.ncompen = 0
                ahommov1.notromon = 0
                ahommov1.ccodtra = " "
                cahommov1.agregar(ahommov1)

                ' graba en contabilidad
                'cntamov
                Dim cclase As New crefunc
                lcnumpar = cclase.fxStevo(Me.pdfecha)

                Dim entidadcntamov As New SIM.EL.cntamov
                Dim ecntamov As New SIM.BL.cCntamov
                entidadcntamov.cnumcom = lcnumpar

                'diario
                Dim entidaddiario As New SIM.EL.diario
                Dim ediario As New SIM.BL.cDiario
                entidaddiario.cnumcom = lcnumpar

                'diario
                entidaddiario.cnumcom = lcnumpar
                entidaddiario.cglosa = "Liquidacion de Ahorros" & lccodaho
                entidaddiario.cnumdoc = "LIQ.S"
                entidaddiario.dfeccnt = Me.pdfecha
                entidaddiario.cestado = " "
                entidaddiario.ccodofi = lccodofi
                entidaddiario.ffondos = " "
                entidaddiario.dfecdoc = Me.pdfecha
                entidaddiario.dfecmod = Me.pdfecha
                ediario.agregarDiario(entidaddiario)

                'cntamov
                Dim lcconcep As String
                lcconcep = Mid(lccodaho, 7, 2)
                lcctactb = cclase.fxcuentacontableahorros("C", lcconcep, "N", "N", "N", lccodofi)

                lnnumlin2 = 1
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin2
                entidadcntamov.nhaber = 0
                entidadcntamov.ndebe = lnsalahosocio
                entidadcntamov.ccodpres = lccodaho
                entidadcntamov.cnumdoc = "LIQ."
                entidadcntamov.ccodofi = lccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = Me.pdfecha
                entidadcntamov.dfecmod = Me.pdfecha
                entidadcntamov.ccodusu1 = "9999"
                entidadcntamov.ffondos = " "
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "RT"
                ecntamov.agregarCntamov(entidadcntamov)


                'cuenta por contra
                lcctactb = cclase.fxcuentacontableahorros("CCJ", Me.pccodcaja, "N", "N", "N", lccodofi)

                lnnumlin2 = 2
                entidadcntamov.ccodcta = lcctactb
                entidadcntamov.cnumlin = lnnumlin2
                entidadcntamov.nhaber = lnsalahosocio
                entidadcntamov.ndebe = 0
                entidadcntamov.ccodpres = lccodaho
                entidadcntamov.cnumdoc = "LIQ"
                entidadcntamov.ccodofi = lccodofi
                entidadcntamov.cflc = " "
                entidadcntamov.dfeccnt = Me.pdfecha
                entidadcntamov.dfecmod = Me.pdfecha
                entidadcntamov.ccodusu1 = "9999"
                entidadcntamov.ffondos = " "
                entidadcntamov.cclase = Left(lcctactb, 1)
                entidadcntamov.cpoliza = "DP"
                ecntamov.agregarCntamov(entidadcntamov)
            End If

        Next

    End Sub


    Sub cargaahorros()
        Dim lccodcli As String
        lccodcli = Me.ccodcli
        listaaho = mahomcta.ObtenerListaahoporcliente(lccodcli)
    End Sub

    Sub cargacreditos()
        'localiza las deudas pendientes
        Dim lccodcli As String
        lccodcli = Me.ccodcli
        listacre = mcreditos.ObtenerListaPorCliente(lccodcli)
    End Sub

#End Region

End Class
