Public Class ClsRevDesem

    Dim cClsAdP As New SIM.BL.ClsAdPart
#Region " Variables "
    Private cCuenta As String
    Private gdFecsis As Date
    Private gcCodUsu As String
    Private cNrodoc As String
    Private cReg As String
    Private cOficina As String
    Private cGlosa As String
    Private cNrochq As String

    Dim cClase As New SIM.BL.crefunc


#End Region

#Region " Propiedades "
    Public Property _cCuenta() As String
        Get
            Return cCuenta
        End Get
        Set(ByVal Value As String)
            cCuenta = Value
        End Set
    End Property
    Public Property _gdFecsis() As Date
        Get
            Return gdFecsis
        End Get
        Set(ByVal Value As Date)
            gdFecsis = Value
        End Set
    End Property
    Public Property _gcCodUsu() As String
        Get
            Return gcCodUsu
        End Get
        Set(ByVal Value As String)
            gcCodUsu = Value
        End Set
    End Property
    Public Property _cNrochq() As String
        Get
            Return cNrochq
        End Get
        Set(ByVal Value As String)
            cNrochq = Value
        End Set
    End Property

    Public Property _cNrodoc() As String
        Get
            Return cNrodoc
        End Get
        Set(ByVal Value As String)
            cNrodoc = Value
        End Set
    End Property
    Public Property _cGlosa() As String
        Get
            Return cGlosa
        End Get
        Set(ByVal Value As String)
            cGlosa = Value
        End Set
    End Property
    Public Property _cOficina() As String
        Get
            Return cOficina
        End Get
        Set(ByVal Value As String)
            cOficina = Value
        End Set
    End Property
    Public Property _cReg() As String
        Get
            Return cReg
        End Get
        Set(ByVal Value As String)
            cReg = Value
        End Set
    End Property
#End Region

#Region " Metodos "
    Public Sub Revierte()
        Dim lcCondic As String
        Dim lcNumcom As String
        Dim lcNumpar As String
        Dim ds As New DataSet
        Dim nCanti As Integer
        Dim clsdes As New clsDesembolsa


        '---------------------------------
        'Cambiara el Estado en la Cremcre
        '---------------------------------
        Dim entidadCremcre As New SIM.EL.cremcre
        Dim eCremcre As New SIM.BL.cCremcre
        Dim lcnrolin As String
        Dim ldfecdes As Date

        entidadCremcre.ccodcta = Me._cCuenta
        eCremcre.ObtenerCremcre(entidadCremcre)

        lcnrolin = entidadCremcre.cnrolin
        ldfecdes = entidadCremcre.dfecvig

        entidadCremcre.ncapdes = 0
        entidadCremcre.ncapoto = 0
        entidadCremcre.cestado = "C"
        eCremcre.ActualizarCremcreRev(entidadCremcre)

        '------------------------------------
        'Elimina el Desembolso de la Credkar
        '------------------------------------
        Dim entidadKardex As New SIM.EL.credkar
        Dim eKardex As New SIM.BL.cCredkar

        entidadKardex.ccodcta = Me.cCuenta
        eKardex.ObtenerCredkar(entidadKardex)


        entidadKardex.cestado = "X"
        entidadKardex.cdescob = "D"
        entidadKardex.cnrodoc = Me._cNrodoc

        eKardex.ActualizarCredkar1(entidadKardex)

        '---------------------------------
        'Revierte el cheque de la ctbdchq
        '---------------------------------

        'Primero sacara el numero de la Partida de la cntamov
        Dim entidadCntamov As New SIM.EL.cntamov
        Dim ecCntamov As New SIM.BL.cCntamov

        entidadCntamov.ccodpres = Me.cCuenta
        entidadCntamov.cpoliza = "EG"
        entidadCntamov.cnumdoc = Me.cNrochq


        Dim i As Integer = 0
        i = ecCntamov.BusquedaporCuenta(entidadCntamov)

        If i = 0 Then
            lcNumcom = ""
        Else
            lcNumcom = entidadCntamov.cnumcom
        End If



        Dim entidadCtbdchq As New SIM.EL.ctbdchq
        Dim eCtbdchq As New SIM.BL.cCtbdchq
        Dim lnumchq As String
        Dim lcbanco As String = ""
        Dim lcmonchq As Double = 0
        Dim lcnomcli As String = ""

        entidadCtbdchq.cnumcom = lcNumcom
        i = eCtbdchq.ObtenerCtbdchq(entidadCtbdchq)
        If i = 0 Then

        Else
            lnumchq = entidadCtbdchq.cnrochq.Trim
            lcbanco = entidadCtbdchq.ccodbco.Trim
            lcmonchq = entidadCtbdchq.cmonchq
            lcnomcli = entidadCtbdchq.cnomchq.Trim

            entidadCtbdchq.cflc = "X"
            entidadCtbdchq.cnomchq = ("CHEQUE ANULADO:" & "/" & lcnomcli.Trim)
            eCtbdchq.ActualizarCtbdchqRever(entidadCtbdchq)

        End If



        '        eCtbdchq.AnulaAuxiliar(lcnumcom)

 
        '--------------------------------------
        'Borra El plan de Pagos de la  Credppg
        '--------------------------------------
        Dim entidadCredpp As New SIM.EL.credppg
        Dim eCredppg As New SIM.BL.cCredppg

        entidadCredpp.ccodcta = Me._cCuenta
        eCredppg.ObtenerCredppg(entidadCredpp)
        eCredppg.EliminaPlanPagos(entidadCredpp)


        '--------------------------------------
        'Borra los Gastos de la Credgas
        '--------------------------------------
        Dim entidadCredgas As New SIM.EL.credgas
        Dim eCredgas As New SIM.BL.cCredgas

        entidadCredgas.ccodcta = Me._cCuenta
        eCredgas.ObtenerCredgas(entidadCredgas)
        eCredgas.EliminarGastos(entidadCredgas)

        '---------------------------------------
        'Borra crepgar
        '--------------------------------------
        Dim entidadCrepgar As New crepgar
        Dim ecrepgar As New cCrepgar

        entidadCrepgar.ccodcta = Me._cCuenta
        ecrepgar.EliminarCrepgar2(entidadCrepgar)
        '----------------------------------------
        'Realiza la reversion contable
        '----------------------------------------
        lcNumpar = cClase.fxStevo(gdFecsis)


        Dim cCretlin As New SIM.BL.cCretlin
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim lcCodlin As String

        entidadCretlin.cnrolin = lcnrolin
        cCretlin.ObtenerCretlin(entidadCretlin)
        lcCodlin = entidadCretlin.ccodlin



        '-------------------------
        'Inserta en la Diario
        '-------------------------

        Dim entidadDiario As New SIM.EL.diario
        Dim eDiario As New SIM.BL.cDiario

        entidadDiario.cnumcom = lcNumpar
        eDiario.ObtenerDiario(entidadDiario)

        entidadDiario.cnumcom = lcNumpar
        entidadDiario.ccodofi = Me.cOficina
        entidadDiario.ctipasi = "012"
        entidadDiario.ctipmon = "1"
        entidadDiario.cglosa = Me.cGlosa
        entidadDiario.cnumdoc = Me._cNrodoc
        entidadDiario.ccodreg = Me.cReg
        entidadDiario.ccodrev = " "
        entidadDiario.ccodruc = " "
        entidadDiario.dfeccnt = gdFecsis
        entidadDiario.dfecdoc = ldfecdes
        entidadDiario.dfecmod = Me.gdFecsis
        entidadDiario.ffondos = lcCodlin.Substring(2, 2)
        entidadDiario.ccodusu = Me.gcCodUsu
        entidadDiario.cestado = " "
        entidadDiario.cfv = " "
        entidadDiario.nccompra = 0
        entidadDiario.ncventa = 0
        entidadDiario.nfln = 0
        entidadDiario.ntcfijo = 0
        entidadDiario.cnrodoc = " "

        eDiario.agregarDiario(entidadDiario)

        'Fin

        '------------------------------------------
        'Movimiento en la maestra de Conta cntamov
        '------------------------------------------

        eKardex.ObtenerCredkar(entidadKardex)

        ds = eKardex.Obtenerdatasetporid1(Me.cCuenta, "D", "X", Me.cNrodoc)

        Dim lnvalida As Integer = 0
        ncanti = ds.Tables(0).Rows.Count()
        lnvalida = nCanti
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If


        Dim Fila As DataRow
        Dim lnum As Integer = 1
        Dim lcconcep As String


        nCanti = 0
        For Each Fila In ds.Tables(0).Rows
            entidadKardex.ccodcta = ds.Tables(0).Rows(nCanti)("ccodcta")
            entidadKardex.nmonto = ds.Tables(0).Rows(nCanti)("nMonto")
            entidadKardex.ccodctb = ds.Tables(0).Rows(nCanti)("cCodctb")
            entidadKardex.cconcep = ds.Tables(0).Rows(nCanti)("cConcep")
            lcconcep = ds.Tables(0).Rows(nCanti)("cConcep")


            'Inserta en la Cntamov

            entidadCntamov.cnumcom = lcNumpar
            ecCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = lcNumpar
            entidadCntamov.ccodsec = " "
            entidadCntamov.ffondos = lcCodlin.Substring(2, 2) 'lcCodlin.Substring(2, 2).Trim
            entidadCntamov.cnumlin = lnum
            entidadCntamov.ccodcta = entidadKardex.ccodctb
            entidadCntamov.cclase = entidadKardex.ccodctb.Substring(0, 1).Trim

            If lcconcep.Trim = "KP" Then
                entidadCntamov.ffondos = lcCodlin.Substring(2, 2)
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = entidadKardex.nmonto
            Else
                If lcconcep.Trim = "CJ" Then
                    entidadCntamov.ffondos = lcCodlin.Substring(2, 2)
                End If
                entidadCntamov.ndebe = entidadKardex.nmonto
                entidadCntamov.nhaber = 0
            End If

            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me._cNrodoc
            entidadCntamov.dfeccnt = gdFecsis
            entidadCntamov.dfecmod = Me.gdFecsis
            entidadCntamov.ccodpres = Me.cCuenta
            entidadCntamov.cconcepto = Me.cGlosa
            entidadCntamov.cpoliza = "AR"
            entidadCntamov.ccodofi = Me.cOficina
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = Me.cReg
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.gcCodUsu

            ecCntamov.agregarCntamov(entidadCntamov)

            lnum += 1
            nCanti += 1
        Next

        ds.Tables.Clear()

        If lnvalida > 0 Then
            'Agregar Cuentas Especiales ------------------------------------------>
            'If lcmonchq > 0 Then
            '    Dim lccuenta As String = "*"
            '    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", "CXP", "D", "N", "N", lcbanco, lcmonchq, 0, 0)

            '    'Inserta en la Cntamov
            '    entidadCntamov.ffondos = "99"
            '    entidadCntamov.cnumlin = lnum
            '    entidadCntamov.ccodcta = lccuenta
            '    entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '    entidadCntamov.ndebe = 0
            '    entidadCntamov.nhaber = lcmonchq

            '    ecCntamov.agregarCntamov(entidadCntamov)
            '    lnum += 1
            '    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", "CXC", "D", "N", "N", lcbanco, lcmonchq, 0, 0)

            '    'Inserta en la Cntamov
            '    entidadCntamov.ffondos = clsdes.ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '    entidadCntamov.cnumlin = lnum
            '    entidadCntamov.ccodcta = lccuenta
            '    entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '    entidadCntamov.ndebe = lcmonchq
            '    entidadCntamov.nhaber = 0

            '    ecCntamov.agregarCntamov(entidadCntamov)

            '    lnum += 1

            'End If


            '----------------------------------------------------------------------
        End If

        'Revierte auxiliar
        ''Graba en Auxliar
        If i = 0 Then
        Else

            Dim clsauxiliar As New clsDesembolsa
            clsauxiliar.cNrochq = lnumchq
            clsauxiliar.cnumrec = ""
            clsauxiliar.cBanco = lcbanco
            clsauxiliar.nCJ = lcmonchq
            clsauxiliar.gdfecsis = gdFecsis
            clsauxiliar.cNomcli = lcnomcli
            clsauxiliar.cGlosa = Me.cGlosa
            clsauxiliar.cOficina = Me.cOficina
            clsauxiliar.cCuenta = Me.cCuenta
            clsauxiliar.GrabaenAuxiliar(lcNumpar, "C")

        End If

        '------------------------------------------------------
        '------------------------------------------------------
        'En caso de refinanciamiento
        '------------------------------------------------------

        Dim cCremRef As New SIM.EL.CremRef
        Dim eCremRef As New SIM.BL.cCremRef
        Dim ds_refi As New DataSet
        Dim lccodcta As String



        ds_refi = eCremRef.ObtenerDataSetEsp2(Me.cCuenta)

        nCanti = ds_refi.Tables(0).Rows.Count()

        If nCanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If


        nCanti = 0

        For Each Fila In ds_refi.Tables(0).Rows
            lccodcta = ds_refi.Tables(0).Rows(nCanti)("ccodcta")


            'Primero quitara el moviento en la Credkar
            Dim cCredkar As New SIM.EL.credkar
            Dim eCredkar As New SIM.BL.cCredkar


            cCredkar.cestado = "X"
            cCredkar.cnuming = "CANC/REFI"
            cCredkar.cdescob = "C"
            cCredkar.ccodcta = lccodcta


            eCredkar.ActualizarCredkar2(cCredkar)


            'Ahora cambiara el estado en la cremcre

            entidadCremcre.cestado = "F"
            entidadCremcre.ccodcta = lccodcta

            eCremcre.Actualizar2(entidadCremcre)

            'Ahora borrara el registro de la cremref

            cCremRef.ccodcta = lccodcta
            eCremRef.EliminarCremRef(lccodcta)


            nCanti += 1
        Next

    End Sub

    Public Function RevierteProvisionContable(ByVal cCodcta As String, ByVal dfecha As Date, ByVal ccodusu As String) As Integer
        Dim ecremcre As New cCremcre
        Dim entidadtabtmak As New tabtmak
        Dim etabtmak As New cTabtmak
        Dim busquedaplantilla As String
        Dim lcctactb As String
        Dim cplanti As String
        Dim oki As String = ""
        Dim lccc As String
        Dim lcfondos As String
        Dim clasefunc As New crefunc
        Dim lccodofi As String
        Dim ds As New DataSet
        ds = ecremcre.RecuperarProvisionCredito(cCodcta)

        Dim lnprovis As Decimal = 0
        Dim lnprovismor As Decimal = 0

        If ds.Tables(0).Rows.Count = 0 Then 'Es desembolso del mismo dia
            Return 0
        End If
        Try

        
            lccodofi = ds.Tables(0).Rows(0)("ccodofi")
            lcfondos = ds.Tables(0).Rows(0)("ffondos")
            lccc = clasefunc.CodigoCondicion(ds.Tables(0).Rows(0)("ccondic"))
            lnprovis = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovis")), 0, ds.Tables(0).Rows(0)("nprovis"))
            lnprovismor = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovpas")), 0, ds.Tables(0).Rows(0)("nprovpas"))

            If lnprovis > 0 Or lnprovismor > 0 Then
                'Graba Partida contable
                cClsAdP._dfecmod = dfecha
                cClsAdP._ccodusu = ccodusu
                cClsAdP._ccodofi = lccodofi
                cClsAdP._ffondos = lcfondos.Trim
                cClsAdP._cconcepto = "PARTIDA REVERSION DE PROVISION DE CREDITO:  " & cCodcta.Trim
                cClsAdP._dfeccnt = dfecha
                cClsAdP._cpoliza = "PI"
                cClsAdP._nCuenta = 1
                cClsAdP._cnumdoc = "F"
                cClsAdP._llbandera = True
                cClsAdP._ccodpres = ""
            End If

            If lnprovis > 0 Then
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                'Cargo
                Dim lcmascara As String = "CINNN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Replace("CC", lccc)
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = 0
                cClsAdP._nhaber = lnprovis
                cClsAdP._cclase = "1"


                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    Exit Function
                End If
                cClsAdP._nCuenta += 1

                'Abono
                lcmascara = "CINFN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Replace("CC", lccc)
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lnprovis
                cClsAdP._nhaber = 0
                cClsAdP._cclase = "6"


                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    Exit Function
                End If
                cClsAdP._nCuenta += 1
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            End If

            '------Provision de intereses moratorios
            If lnprovismor > 0 Then
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                'Cargo
                Dim lcmascara As String = "CMONN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Replace("CC", lccc)
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = 0
                cClsAdP._nhaber = lnprovismor
                cClsAdP._cclase = "1"


                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    Exit Function
                End If
                cClsAdP._nCuenta += 1

                'Abono
                lcmascara = "CMOFN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Replace("CC", lccc)
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lnprovismor
                cClsAdP._nhaber = 0
                cClsAdP._cclase = "6"


                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    Exit Function
                End If
                cClsAdP._nCuenta += 1
            End If

            Return 1
        Catch ex As Exception
            Return 9
        End Try


    End Function

#End Region
    

End Class
