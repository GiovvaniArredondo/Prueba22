Public Class cprovisiones


#Region " Propiedades "
    Private _dultpro As Date
    Private _proact As Date
    Private _gccodofi As String
    Private _gccodusu As String

    Public Property dultpro() As DateTime
        Get
            Return _dultpro
        End Get
        Set(ByVal Value As DateTime)
            _dultpro = Value
        End Set
    End Property

    Public Property proact() As DateTime
        Get
            Return _proact
        End Get
        Set(ByVal Value As DateTime)
            _proact = Value
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

    Public Property gccodusu() As String
        Get
            Return _gccodusu
        End Get
        Set(ByVal Value As String)
            _gccodusu = Value
        End Set
    End Property

#End Region


#Region " Métodos "


    Sub provision_certificados()
        Dim mahomcrt As New cAhomcrt
        Dim eahomcrt As New ahomcrt
        Dim lista As New listaahomcrt
        Dim listaintereses As New listaahomint
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double

        Dim lntasint As Double
        Dim lninteres As Double
        Dim lnplazo As Double
        Dim ldultpro As Date
        Dim lndifdia As Double
        Dim lnmonto As Double
        Dim lccodcrt As String
        Dim ldmenpro As Date
        Dim lntotint As Double
        Dim lnsaldoaho As Double
        lntotint = 0

        Dim mahomint As New cAhomint
        Dim eahomint As New ahomint
        Dim ldfecha As Date
        Dim lccodaho As String
        Dim lnnumlin As Integer

        Dim mahomcta As New cAhomcta
        Dim eahomcta As New ahomcta
        Dim mahommov As New cAhommov
        Dim eahommov As New ahommov

        ' graba en contabilidad
        'cntamov
        Dim cclase As New crefunc
        Dim lcnumpar As String
        Dim lcnrodoc As String
        Dim lcctactb As String

        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        Dim lcproducto As String
        Dim lnintereses As Double
        Dim lnnum As Integer

        'diario
        Dim entidaddiario As New SIM.EL.diario
        Dim ediario As New SIM.BL.cDiario

        Dim lcconcep As String
        Dim lnnumlin2 As Integer
        Dim lcproductoaho As String

        lista = mahomcrt.ObtenerLista2()

        lnintereses = 0
        lnnum = 0


        For Each eahomcrt In lista
            If eahomcrt.cliq = "N" Then
                lntasint = eahomcrt.ntasint
                lnplazo = eahomcrt.nplazo
                ldultpro = Me.dultpro   'antes eahomcrt.dultpro
                lccodcrt = eahomcrt.ccodcrt.Trim
                ldmenpro = eahomcrt.dmenpro
                lccodaho = eahomcrt.ccodaho
                lcproducto = eahomcrt.producto
                'saca el producto de la cuenta de ahorro donde se van los interese de a plazo
                lcproductoaho = Mid(lccodaho, 7, 2)
                If ldultpro = Nothing Then
                    ldultpro = Me.proact
                End If
                lnfecha1 = Me.proact.ToOADate
                lnfecha2 = ldultpro.ToOADate
                lndifdia = lnfecha1 - lnfecha2
                lnmonto = eahomcrt.nmonapr
                lninteres = lnmonto * lndifdia * ((lntasint / 100)) / 360
                lnintereses = lnintereses + lninteres

                'actualiza con fecha, despues se correra una rutina para actualizar base de datos

                '                eahomcrt.dultpro = Me.proact

                'agrega los interes provisionados por cada certificado

                lnnum = lnnum + 1
                eahomint.ccodcrt = lccodcrt.Trim
                eahomint.nnum = lnnum
                eahomint.ccodcli = eahomcrt.ccodcli
                eahomint.ccodcta = eahomcrt.ccodcta
                eahomint.ccodusu = eahomcrt.ccodusu
                eahomint.cestado = " "
                eahomint.cnrolin = eahomcrt.cnrolin
                eahomint.dfecapr = eahomcrt.dfecapr
                eahomint.dfeccap = Me.proact
                eahomint.dfecliq = Me.proact
                eahomint.dfecmod = Me.proact
                eahomint.dfecmod2 = Me.proact
                eahomint.dfecori = eahomcrt.dfecori
                eahomint.dfecpro = Me.proact
                eahomint.dfecprv = eahomcrt.dfecprv
                eahomint.dfecven = eahomcrt.dfecven
                eahomint.nmonapr = eahomcrt.nmonapr
                eahomint.nsaldoaho = eahomcrt.nsaldoaho
                eahomint.ntasint = eahomcrt.ntasint
                eahomint.producto = eahomcrt.producto
                eahomint.nplazo = eahomcrt.nplazo
                eahomint.ntasint = eahomcrt.ntasint
                eahomint.nintere = lninteres
                eahomint.nombre = eahomcrt.nombre
                mahomint.agregar(eahomint)

                'verifica si hay pago de certificados, por cumplir el mes
                If (ldmenpro.ToOADate + 30 > Me.dultpro.ToOADate) And (ldmenpro.ToOADate + 30 <= Me.proact.ToOADate) Then

                    ldfecha = ldmenpro.AddDays(30)
                    eahomcrt.dmenpro = ldfecha
                    'suma el total de intereses provisionados para ser pagados
                    eahomint.ccodcrt = lccodcrt
                    listaintereses = mahomint.ObtenerLista(lccodcrt, Me.proact)
                    For Each eahomint In listaintereses
                        lntotint = eahomint.nintere + lntotint
                    Next
                    lntotint = lntotint + lninteres 'porque no incluye la provision de hoy

                    'obtiene saldo de la ahomcta para actualizar pago de ahorros
                    eahomcta.ccodaho = lccodaho
                    mahomcta.ObtenerAhomcta(eahomcta)
                    lnsaldoaho = eahomcta.nsaldoaho
                    lnnumlin = eahomcta.nnum + 1

                    eahomcta.nsaldoaho = lntotint + lnsaldoaho
                    eahomcta.dfechault = ldfecha
                    eahomcta.dfecult = ldfecha
                    eahomcta.dfecmod = ldfecha
                    eahomcta.dultmov = ldfecha
                    eahomcta.nnum = lnnumlin
                    mahomcta.ActualizarAhomcta(eahomcta)

                    'graba los movimientos
                    eahommov.ccodaho = lccodaho
                    eahommov.nnum = lnnumlin
                    eahommov.nmonto = lntotint
                    eahommov.nsaldoaho = lntotint + lnsaldoaho
                    eahommov.nsaldnind = lntotint + lnsaldoaho
                    eahommov.cconcep = "DP"
                    eahommov.ccodusu = "9999"
                    eahommov.cnumdoc = "Int/cert"
                    eahommov.dfecefe = Me.proact
                    eahommov.dfecomp = Me.proact
                    eahommov.dfecmod = Me.proact
                    eahommov.dfecope = Me.proact
                    eahommov.clinea = "S"
                    eahommov.npartida = 0
                    eahommov.interes = 0
                    eahommov.ctipope = "D"
                    eahommov.ncompen = 0
                    eahommov.notromon = 0
                    eahommov.ccodtra = " "
                    mahommov.agregar(eahommov)

                    lcnrodoc = "INT/CERT"
                    lcnumpar = cclase.fxStevo(ldfecha)

                    entidaddiario.cnumcom = lcnumpar

                    'diario
                    entidaddiario.cnumcom = lcnumpar
                    entidaddiario.cglosa = "Deposito de ahorros " & lccodaho & " recibo No. " & lcnrodoc
                    entidaddiario.cnumdoc = lcnrodoc
                    entidaddiario.dfeccnt = ldfecha
                    entidaddiario.cestado = " "
                    entidaddiario.ccodofi = Me.gccodofi
                    entidaddiario.ffondos = " "
                    entidaddiario.dfecdoc = ldfecha
                    entidaddiario.dfecmod = ldfecha
                    ediario.agregarDiario(entidaddiario)

                    'cntamov
                    entidadcntamov.cnumcom = lcnumpar
                    lcconcep = Mid(lccodaho, 7, 2)
                    lcctactb = cclase.fxcuentacontableahorros("CP", "PL", "N", "N", "N", Me.gccodofi)

                    lnnumlin2 = 1
                    entidadcntamov.ccodcta = lcctactb
                    entidadcntamov.cnumlin = lnnumlin2
                    entidadcntamov.nhaber = 0
                    entidadcntamov.ndebe = lntotint
                    entidadcntamov.ccodpres = lccodaho
                    entidadcntamov.cnumdoc = lcnrodoc
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = ldfecha
                    entidadcntamov.dfecmod = ldfecha
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = " "
                    entidadcntamov.cclase = Left(lcctactb, 1)
                    entidadcntamov.cpoliza = "DP"
                    ecntamov.agregarCntamov(entidadcntamov)

                    'cuenta por contra
                    lcctactb = cclase.fxcuentacontableahorros("CP", lcproductoaho, "N", "N", "N", gccodofi)

                    lnnumlin2 = 2
                    entidadcntamov.ccodcta = lcctactb
                    entidadcntamov.cnumlin = lnnumlin2
                    entidadcntamov.nhaber = lntotint
                    entidadcntamov.ndebe = 0
                    entidadcntamov.ccodpres = lccodaho
                    entidadcntamov.cnumdoc = lcnrodoc
                    entidadcntamov.ccodofi = gccodofi
                    entidadcntamov.cflc = " "
                    entidadcntamov.dfeccnt = ldfecha
                    entidadcntamov.dfecmod = ldfecha
                    entidadcntamov.ccodusu1 = gccodusu
                    entidadcntamov.ffondos = " "
                    entidadcntamov.cclase = Left(lcctactb, 1)
                    entidadcntamov.cpoliza = "DP"
                    ecntamov.agregarCntamov(entidadcntamov)
                End If
            End If
        Next


        'actualiza ultima provision
        Dim mahompro2 As New cAhompro2
        Dim eahompro2 As New ahompro2

        eahompro2.dultpro = Me.proact
        mahompro2.Agregar(eahompro2)

        'hace la partida concentrada por toda la provision


        If lnintereses > 0 Then

            lcnrodoc = "INT/CERT"
            lcnumpar = cclase.fxStevo(Me.proact)

            entidaddiario.cnumcom = lcnumpar

            'diario
            entidaddiario.cnumcom = lcnumpar
            entidaddiario.cglosa = "Provision de intereses de p/cert. a plazo "
            entidaddiario.cnumdoc = lcnrodoc
            entidaddiario.dfeccnt = Me.proact
            entidaddiario.cestado = " "
            entidaddiario.ccodofi = Me.gccodofi
            entidaddiario.ffondos = " "
            entidaddiario.dfecdoc = Me.proact
            entidaddiario.dfecmod = Me.proact
            ediario.agregarDiario(entidaddiario)

            'cntamov
            entidadcntamov.cnumcom = lcnumpar
            lcctactb = cclase.fxcuentacontableahorros("CP", "IN", "N", "N", "N", Me.gccodofi)

            lnnumlin2 = 1
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin2
            entidadcntamov.nhaber = 0
            entidadcntamov.ndebe = lnintereses
            entidadcntamov.ccodpres = ""
            entidadcntamov.cnumdoc = lcnrodoc
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = Me.proact
            entidadcntamov.dfecmod = Me.proact
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = " "
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "DP"
            ecntamov.agregarCntamov(entidadcntamov)

            'cuenta por contra
            lcctactb = cclase.fxcuentacontableahorros("CP", "PL", "N", "N", "N", gccodofi)

            lnnumlin2 = 2
            entidadcntamov.ccodcta = lcctactb
            entidadcntamov.cnumlin = lnnumlin2
            entidadcntamov.nhaber = lnintereses
            entidadcntamov.ndebe = 0
            entidadcntamov.ccodpres = ""
            entidadcntamov.cnumdoc = lcnrodoc
            entidadcntamov.ccodofi = gccodofi
            entidadcntamov.cflc = " "
            entidadcntamov.dfeccnt = Me.proact
            entidadcntamov.dfecmod = Me.proact
            entidadcntamov.ccodusu1 = gccodusu
            entidadcntamov.ffondos = " "
            entidadcntamov.cclase = Left(lcctactb, 1)
            entidadcntamov.cpoliza = "DP"
            ecntamov.agregarCntamov(entidadcntamov)

        End If ' intereses

        'actualiza tabla de certificados con ultima fecha de pagos
        'y renueva los certificados


        Dim e1ahomcrt As New ahomcrt
        Dim m1ahomcrt As New cAhomcrt

        For Each eahomcrt In lista
            If eahomcrt.cliq = "N" Then
                e1ahomcrt.ccodcrt = eahomcrt.ccodcrt
                m1ahomcrt.ObtenerAhomcrt(e1ahomcrt)
                e1ahomcrt.dultpro = Me.proact
                e1ahomcrt.dmenpro = eahomcrt.dmenpro
                m1ahomcrt.ActualizarAhomcrt(e1ahomcrt)
            End If
        Next

    End Sub

#End Region

End Class
