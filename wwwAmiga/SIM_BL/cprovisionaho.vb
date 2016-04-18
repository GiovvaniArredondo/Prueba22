Public Class cprovisionaho

#Region "Propiedades"
    Private _gccodofi As String

    Public Property gccodofi() As String
        Get
            Return _gccodofi
        End Get
        Set(ByVal Value As String)
            _gccodofi = Value
        End Set
    End Property

    Private _gccodusu As String
    Public Property gccodusu() As String
        Get
            gccodusu = _gccodusu
        End Get
        Set(ByVal Value As String)
            _gccodusu = Value
        End Set
    End Property

    'fecha de provision de intereses
    Private _gdfecpro As Date
    Public Property gdfecpro() As Date
        Get
            gdfecpro = _gdfecpro
        End Get
        Set(ByVal Value As Date)
            _gdfecpro = Value
        End Set
    End Property

    'fecha de inicio de provision de intereses
    Private _gdfecini As Date
    Public Property gdfecini() As Date
        Get
            gdfecini = _gdfecini
        End Get
        Set(ByVal Value As Date)
            _gdfecini = Value
        End Set
    End Property

    Private _gccodfue As String
    Public Property gccodfue() As String
        Get
            gccodfue = _gccodfue
        End Get
        Set(ByVal Value As String)
            _gccodfue = Value
        End Set
    End Property

#End Region

    'provisiones de ahorro, no icluye aportaciones

#Region "Métodos"
    'metodo para provisionar intereses de ahorro
    'no incluye aportaciones
    Sub provisiona_intereses_ahorro()
        Dim clscuentas As New cAhomcta
        Dim listacuentas As New listaahomcta
        Dim listamovimientos As New listaahommov
        Dim eahomcta As New ahomcta

        Dim eahotlin As New ahotlin
        Dim mahotlin As New cAhotlin
        Dim mahommov As New cahommov
        Dim eahommov As New ahommov

        Dim eahomaho As New ahomaho
        Dim mahomaho As New cahomaho

        Dim lntasint As Double
        Dim lnsalant As Double
        Dim lccodaho As String
        Dim lndias As Double
        Dim ldfecult As Date
        Dim lnsaldo As Double
        Dim lninteres As Double
        Dim lnprovi As Double
        lnprovi = 0
        Dim lnint01 As Double
        Dim lnint02 As Double
        Dim lnint03 As Double
        Dim lnint04 As Double
        Dim lnint05 As Double

        Dim cls1 As New crefunc
        Dim lcnumcom As String
        Dim ediario As New diario
        Dim mdiario As New cDiario
        Dim ecntamov As New cntamov
        Dim mcntamov As New cCntamov
        Dim lcctactb As String
        Dim lnnumlin As Double

        Dim eclimide As New climide
        Dim mclimide As New cClimide

        lnint01 = 0
        lnint02 = 0
        lnint03 = 0
        lnint04 = 0
        lnint05 = 0
        listacuentas = clscuentas.ObtenerLista

        For Each eahomcta In listacuentas
            If eahomcta.nsaldoaho > 0 And eahomcta.producto <> "06" Then
                eahotlin.cnrolin = eahomcta.cnrolin
                mahotlin.ObtenerAhotlin(eahotlin)
                lntasint = eahotlin.ntasint / 100
                lccodaho = eahomcta.ccodaho
                'obtiene saldo antes de fecha de mes de provision
                lnsalant = mahommov.obtiene_saldo_anterior_a_fecha_inicio(lccodaho, Me.gdfecini)
                'obtiene movimientos 
                listamovimientos = mahommov.movimientos_por_cuent_fecha(lccodaho, Me.gdfecini, Me.gdfecpro) 'calcula itereses
                'obtiene fecha de ultimo movimiento, si fuera despues de la fecha de inicio del mes a provisionar
                ldfecult = mahommov.obtiene_fecha_ultimo_movimiento(lccodaho, Me.gdfecini)

                For Each eahommov In listamovimientos
                    lndias = ldfecult.ToOADate - eahommov.dfecope.ToOADate
                    lninteres = (lndias * lnsalant * lntasint) / 365
                    lnsalant = eahommov.nsaldoaho
                    ldfecult = eahommov.dfecope
                    lnprovi = lnprovi + lninteres
                Next
                'calcula interes para ultima fecha
                lndias = Me.gdfecpro.ToOADate - ldfecult.ToOADate
                lninteres = (lnsalant * lndias * lntasint) / 365
                lnprovi = lnprovi + lninteres
                'graba en tabla de provision
                eahomaho.ccodaho = eahomcta.ccodaho
                eclimide.ccodcli = eahomcta.ccodcli
                mclimide.ObtenerClimide(eclimide)

                If eclimide.cnomcli = Nothing Then
                    eahomaho.cnomcli = " "
                Else
                    eahomaho.cnomcli = eclimide.cnomcli
                End If
                eahomaho.cnudotr = eahomcta.ccodcli
                eahomaho.dfeccap = Me.gdfecpro
                eahomaho.nintere = lninteres
                eahomaho.nsaldoaho = lnsalant
                eahomaho.ntasint = lntasint * 100
                eahomaho.producto = eahomcta.producto
                mahomaho.Agregar(eahomaho)
                'suma intereses para cada tipo de ahorro
                If eahomcta.producto.Trim = "01" Then
                    lnint01 = lnint01 + lninteres
                ElseIf eahomcta.producto.Trim = "02" Then
                    lnint02 = lnint02 + lninteres
                ElseIf eahomcta.producto.Trim = "03" Then
                    lnint03 = lnint03 + lninteres
                ElseIf eahomcta.producto.Trim = "04" Then
                    lnint04 = lnint04 + lninteres
                ElseIf eahomcta.producto.Trim = "05" Then
                    lnint05 = lnint05 + lninteres
                End If
            End If
        Next

        If lnint01 + lnint02 + lnint03 + lnint04 + lnint05 > 0 Then
            'hace aplicacion contable
            lcnumcom = cls1.fxStevo(Me.gdfecpro)
            ediario.cnumcom = lcnumcom
            ediario.cglosa = "Provision de intereses de ahorro" & "01"
            ediario.cnumdoc = "Provision"
            ediario.dfeccnt = Me.gdfecpro
            ediario.cestado = " "
            ediario.ccodofi = gccodofi
            ediario.ffondos = gccodfue
            ediario.dfecdoc = Me.gdfecpro
            ediario.dfecmod = Me.gdfecpro
            mdiario.agregarDiario(ediario)
        End If

        'para ahorro 01
        If lnint01 > 0 Then

            'cntamov carga
            lcctactb = cls1.fxcuentacontable("", "", "N", "01", "CI", "N", "I", "", lnint01, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.cnumcom = lcnumcom
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = lnint01
            ecntamov.nhaber = 0
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)

            'abona
            lcctactb = cls1.fxcuentacontable("", "", "P", "01", "CI", "N", "A", "", lnint01, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.cnumcom = lcnumcom
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = 0
            ecntamov.nhaber = lnint01
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)

        End If

        'para ahorro 02
        If lnint02 Then
            'carga
            lcctactb = cls1.fxcuentacontable("", "", "N", "02", "CI", "N", "I", "", lnint02, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.cnumcom = lcnumcom
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = lnint02
            ecntamov.nhaber = 0
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)

            'abona
            lcctactb = cls1.fxcuentacontable("", "", "P", "02", "CI", "N", "A", "", lnint02, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.cnumcom = lcnumcom
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = 0
            ecntamov.nhaber = lnint02
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)
        End If


        'para ahorro 03
        If lnint03 Then
            'carga
            ecntamov.cnumcom = lcnumcom
            lcctactb = cls1.fxcuentacontable("", "", "N", "03", "CI", "N", "I", "", lnint03, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = lnint03
            ecntamov.nhaber = 0
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)

            'abona
            ecntamov.cnumcom = lcnumcom
            lcctactb = cls1.fxcuentacontable("", "", "P", "03", "CI", "N", "A", "", lnint03, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = 0
            ecntamov.nhaber = lnint03
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)
        End If

        'para ahorro 04
        If lnint04 Then
            'carga
            ecntamov.cnumcom = lcnumcom
            lcctactb = cls1.fxcuentacontable("", "", "N", "04", "CI", "N", "I", "", lnint04, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = lnint04
            ecntamov.nhaber = 0
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)

            'abona
            ecntamov.cnumcom = lcnumcom
            lcctactb = cls1.fxcuentacontable("", "", "P", "04", "CI", "N", "A", "", lnint04, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = 0
            ecntamov.nhaber = lnint04
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)
        End If

        'para ahorro 05
        If lnint05 Then

            'carga
            ecntamov.cnumcom = lcnumcom
            lcctactb = cls1.fxcuentacontable("", "", "N", "05", "CI", "N", "I", "", lnint05, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = lnint05
            ecntamov.nhaber = 0
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)

            'abona
            ecntamov.cnumcom = lcnumcom
            lcctactb = cls1.fxcuentacontable("", "", "P", "05", "CI", "N", "A", "", lnint05, 0, 0)
            lnnumlin = lnnumlin + 1
            ecntamov.ccodcta = lcctactb
            ecntamov.cnumlin = lnnumlin
            ecntamov.ndebe = 0
            ecntamov.nhaber = lnint05
            ecntamov.ccodpres = ""
            ecntamov.cnumdoc = "Prov/aho"
            ecntamov.ccodofi = gccodofi
            ecntamov.cflc = " "
            ecntamov.dfeccnt = Me.gdfecpro
            ecntamov.dfecmod = Me.gdfecpro
            ecntamov.ccodusu1 = gccodusu
            ecntamov.ffondos = Me.gccodfue
            ecntamov.cclase = Left(lcctactb, 1)
            ecntamov.cpoliza = "IN"
            mcntamov.agregarCntamov(ecntamov)
        End If

    End Sub



    'capitaliza intereses de ahorros
    Sub capitalizar_intereses()
        Dim mahomaho As New cAhomaho
        Dim eahomaho As New ahomaho
        Dim listainteres As New listaahomaho

        Dim clscuentas As New cAhomcta
        Dim listacuentas As New listaahomcta
        Dim eahomcta As New ahomcta
        Dim mahomcta As New cAhomcta

        Dim cls1 As New crefunc
        Dim lcnumcom As String
        Dim ediario As New diario
        Dim mdiario As New cDiario
        Dim ecntamov As New cntamov
        Dim mcntamov As New cCntamov
        Dim lcctactb As String
        Dim lnnumlin As Double

        Dim ldfechaini As Date
        Dim ldfechafin As Date
        Dim lccodaho As String
        Dim lninteres As Double
        lninteres = 0
        Dim lnint01 As Double
        Dim lnint02 As Double
        Dim lnint03 As Double
        Dim lnint04 As Double
        Dim lnint05 As Double

        Dim chomcta1 As New cAhomcta
        Dim ahomcta1 As New ahomcta
        Dim ahommov1 As New ahommov
        Dim cahommov1 As New cAhommov
        Dim lnsaldo As Double
        Dim lnnewsal As Double

        lnsaldo = 0
        lnnewsal = 0

        listacuentas = mahomcta.ObtenerLista

        ' obtiene los intereses acumulado por cada cuenta de ahorro
        If gdfecpro.Month = 3 Or gdfecpro.Month = 6 Or gdfecpro.Month = 9 Or gdfecpro.Month = 12 Then
            If gdfecpro.Month = 3 Then
                ldfechaini = Date.Parse("01" & "/" & "01" & "/" & Me.gdfecpro.Year.ToString)
            Else
                ldfechaini = Date.Parse("01" & "/" & (Me.gdfecpro.Month - 3).ToString & "/" & Me.gdfecpro.Year.ToString)
            End If
            ldfechafin = Me.gdfecpro
            For Each eahomcta In listacuentas
                If eahomcta.producto.Trim <> "06" Then 'diferente de aportaciones
                    lccodaho = eahomcta.ccodaho
                    listainteres = mahomaho.ObtenerListaporcuentayfechas(lccodaho, ldfechaini, ldfechafin)
                    For Each eahomaho In listainteres
                        lninteres = lninteres + eahomaho.nintere
                    Next
                    eahomcta.nmonres = lninteres ' variable que se ocupo como impase para depositar interes
                End If

                'envia intereses capitalizados a cada cuenta de ahorro
                'busca el saldo de las cuentas 
                ahomcta1.ccodaho = eahomcta.ccodaho
                chomcta1.ObtenerAhomcta(ahomcta1)
                lnsaldo = ahomcta1.nsaldoaho
                lnnewsal = lnsaldo + lninteres
                lnnumlin = ahomcta1.nnum + 1

                ahomcta1.nsaldoaho = lnnewsal
                ahomcta1.dfechault = Me.gdfecpro
                ahomcta1.dfecult = Me.gdfecpro
                ahomcta1.dfecmod = Me.gdfecpro
                ahomcta1.dultmov = Me.gdfecpro
                ahomcta1.nnum = lnnumlin
                chomcta1.ActualizarAhomcta(ahomcta1)

                'graba los movimientos
                ahommov1.ccodaho = lccodaho
                ahommov1.nnum = lnnumlin
                ahommov1.nmonto = lninteres
                ahommov1.nsaldoaho = lnnewsal
                ahommov1.nsaldnind = lnnewsal
                ahommov1.cconcep = "DP"
                ahommov1.ccodusu = "9999"
                ahommov1.cnumdoc = ""
                ahommov1.dfecefe = Me.gdfecpro
                ahommov1.dfecomp = Me.gdfecpro
                ahommov1.dfecmod = Me.gdfecpro
                ahommov1.dfecope = Me.gdfecpro
                ahommov1.clinea = "S"
                ahommov1.npartida = 0
                ahommov1.interes = 0
                ahommov1.ctipope = "D"
                ahommov1.ncompen = 0
                ahommov1.notromon = 0
                ahommov1.ccodtra = " "
                cahommov1.agregar(ahommov1)

                'acumulara los intereses por cada tipo de ahorro
                If eahomcta.producto.Trim = "01" Then
                    lnint01 = lnint01 + lninteres
                End If
                If eahomcta.producto.Trim = "02" Then
                    lnint02 = lnint02 + lninteres
                End If
                If eahomcta.producto.Trim = "03" Then
                    lnint03 = lnint03 + lninteres
                End If
                If eahomcta.producto.Trim = "04" Then
                    lnint04 = lnint04 + lninteres
                End If
                If eahomcta.producto.Trim = "01" Then
                    lnint05 = lnint05 + lninteres
                End If
            Next

            'hace aplicacion contable
            'hace aplicacion contable

            lcnumcom = cls1.fxStevo(Me.gdfecpro)
            ediario.cnumcom = lcnumcom
            ediario.cglosa = "Capitalizacion de intereses"
            ediario.cnumdoc = "Capital."
            ediario.dfeccnt = Me.gdfecpro
            ediario.cestado = " "
            ediario.ccodofi = gccodofi
            ediario.ffondos = gccodfue
            ediario.dfecdoc = Me.gdfecpro
            ediario.dfecmod = Me.gdfecpro
            mdiario.agregarDiario(ediario)

            'para ahorro 01
            If lnint01 > 0 Then

                'cntamov carga
                lcctactb = cls1.fxcuentacontable("", "", "N", "01", "CC", "N", "I", "", lnint01, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.cnumcom = lcnumcom
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = lnint01
                ecntamov.nhaber = 0
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Capital."
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)

                'abona
                lcctactb = cls1.fxcuentacontable("", "", "P", "01", "CC", "N", "A", "", lnint01, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.cnumcom = lcnumcom
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = 0
                ecntamov.nhaber = lnint01
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Capital."
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)

            End If

            'para ahorro 02
            If lnint02 Then
                'carga
                lcctactb = cls1.fxcuentacontable("", "", "N", "02", "CC", "N", "I", "", lnint02, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.cnumcom = lcnumcom
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = lnint02
                ecntamov.nhaber = 0
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)

                'abona
                lcctactb = cls1.fxcuentacontable("", "", "P", "02", "CC", "N", "A", "", lnint02, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.cnumcom = lcnumcom
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = 0
                ecntamov.nhaber = lnint02
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)
            End If


            'para ahorro 03
            If lnint03 Then
                'carga
                ecntamov.cnumcom = lcnumcom
                lcctactb = cls1.fxcuentacontable("", "", "N", "03", "CC", "N", "I", "", lnint03, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = lnint03
                ecntamov.nhaber = 0
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)

                'abona
                ecntamov.cnumcom = lcnumcom
                lcctactb = cls1.fxcuentacontable("", "", "P", "03", "CC", "N", "A", "", lnint03, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = 0
                ecntamov.nhaber = lnint03
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)
            End If

            'para ahorro 04
            If lnint04 Then
                'carga
                ecntamov.cnumcom = lcnumcom
                lcctactb = cls1.fxcuentacontable("", "", "N", "04", "CC", "N", "I", "", lnint04, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = lnint04
                ecntamov.nhaber = 0
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)

                'abona
                ecntamov.cnumcom = lcnumcom
                lcctactb = cls1.fxcuentacontable("", "", "P", "04", "CC", "N", "A", "", lnint04, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = 0
                ecntamov.nhaber = lnint04
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)
            End If

            'para ahorro 05
            If lnint05 Then

                'carga
                ecntamov.cnumcom = lcnumcom
                lcctactb = cls1.fxcuentacontable("", "", "N", "05", "CC", "N", "I", "", lnint05, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = lnint05
                ecntamov.nhaber = 0
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)

                'abona
                ecntamov.cnumcom = lcnumcom
                lcctactb = cls1.fxcuentacontable("", "", "P", "05", "CC", "N", "A", "", lnint05, 0, 0)
                lnnumlin = lnnumlin + 1
                ecntamov.ccodcta = lcctactb
                ecntamov.cnumlin = lnnumlin
                ecntamov.ndebe = 0
                ecntamov.nhaber = lnint05
                ecntamov.ccodpres = ""
                ecntamov.cnumdoc = "Prov/aho"
                ecntamov.ccodofi = gccodofi
                ecntamov.cflc = " "
                ecntamov.dfeccnt = Me.gdfecpro
                ecntamov.dfecmod = Me.gdfecpro
                ecntamov.ccodusu1 = gccodusu
                ecntamov.ffondos = Me.gccodfue
                ecntamov.cclase = Left(lcctactb, 1)
                ecntamov.cpoliza = "IN"
                mcntamov.agregarCntamov(ecntamov)
            End If


        End If

    End Sub

#End Region


End Class
