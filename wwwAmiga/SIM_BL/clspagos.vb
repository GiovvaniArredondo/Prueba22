Public Class clspagos
    'efectua anulaciones de pagos
    Dim clase As New crefunc
#Region " Propiedades "

    Private _ccodcta As String
    Private _dfecpro As Date
    Private _cnuming As String
    Private _cnrodoc As String
    Private _dfecsis As Date
    Private _ccodusu As String
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal value As String)
            _ccodusu = value
        End Set
    End Property

    Public Property ccodcta1() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property

    Public Property cnuming() As String
        Get
            Return _cnuming
        End Get
        Set(ByVal Value As String)
            _cnuming = Value
        End Set
    End Property

    Public Property dfecpro() As DateTime
        Get
            Return _dfecpro
        End Get
        Set(ByVal Value As DateTime)
            _dfecpro = Value
        End Set
    End Property
    Public Property dfecsis() As DateTime
        Get
            Return _dfecsis
        End Get
        Set(ByVal Value As DateTime)
            _dfecsis = Value
        End Set
    End Property

    Public Property cnrodoc() As String
        Get
            Return _cnrodoc
        End Get
        Set(ByVal Value As String)
            _cnrodoc = Value
        End Set
    End Property

    Dim _gccodofi As String
    Public Property gccodofi() As String
        Get
            Return _gccodofi
        End Get
        Set(ByVal Value As String)
            _gccodofi = Value
        End Set
    End Property

#End Region

#Region " Métodos "
    Public Function anulapagos() As Integer
        Dim entidadcredkar As New SIM.EL.credkar
        Dim ecredkar As New SIM.BL.cCredkar
        Dim ds As New DataSet
        Dim filakar As DataRow
        Dim lncontador As Integer
        Dim lcnumcom As String
        Dim numpartida As New crefunc
        Dim ecntamov As New cntamov
        Dim mcntamov As New cCntamov
        Dim ediario As New diario
        Dim mdiario As New cDiario
        Dim lccuenta As String
        Dim lcbanco As String = ""
        Dim clsppal As New class1

        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre

        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim busquedaplantilla As Integer
        Dim cplanti As String = ""
        Dim lcctactb As String = "*"
        Dim ecretlin As New cCretlin
        Dim pccodlin As String = ""
        Dim clssdes As New clsDesembolsa
        Dim lccodfue As String
        Dim lcnuming As String = ""
        Dim lcnumrec As String = ""
        Dim lcnomcli As String = ""
        Dim eclimide As New cClimide
        lcnomcli = eclimide.RecuperarNombre(Me.ccodcta1)
        pccodlin = ecretlin.ObtieneCodigoLineadecredito(Me.ccodcta1)
        lccodfue = clssdes.ConvertidorFondos(pccodlin.Substring(2, 2))

        Dim lccondic As String = ""
        Dim lcoficina As String
        entidad1.ccodcta = Me.ccodcta1
        ecreditos.ObtenerCremcre(entidad1)
        lcoficina = entidad1.coficina
        lccondic = entidad1.ccondic
        Try
            'crea partida para la reversion
            lcnumcom = numpartida.fxStevo(Me.dfecsis)
            ediario.cnumcom = lcnumcom
            ediario.cglosa = "REV.PAGOS Ref: " & Me.ccodcta1
            ediario.cnumdoc = Me.cnuming
            ediario.dfeccnt = Me.dfecsis
            ediario.dfecdoc = Me.dfecsis
            ediario.dfecmod = Me.dfecsis
            ediario.ccodusu = Me.ccodusu
            ediario.ccodofi = lcoficina 'Me.ccodcta1.Substring(3, 3).Trim
            ediario.ctipmon = "1"
            ediario.ccodruc = " "
            ediario.ctipasi = "011"
            mdiario.agregarDiario(ediario)

            entidadcredkar.ccodcta = Me.ccodcta1
            entidadcredkar.cconcep = "CJ"
            entidadcredkar.cdescob = "C"
            entidadcredkar.cnuming = Me.cnuming
            entidadcredkar.cnrodoc = Me.cnrodoc
            ecredkar.ObtenerCredkar(entidadcredkar)
            ds = ecredkar.ObtenerDataSetPorID2(Me.ccodcta1, Me.cnuming, "C", Me.cnrodoc)
            lncontador = 0
            lccuenta = ""

            Dim lctippag As String = ""
            Dim lncaja As Double = 0

            If ds.Tables(0).Rows.Count > 0 Then
                For Each filakar In ds.Tables(0).Rows
                    lctippag = filakar("ctippag")
                    lcbanco = filakar("cbanco")
                    entidadcredkar.cestado = "X"
                    entidadcredkar.dfecpro = Me.dfecpro
                    entidadcredkar.dfecsis = Me.dfecpro
                    entidadcredkar.dfecmod = Now()
                    entidadcredkar.cnrodoc = filakar("cnrodoc")
                    entidadcredkar.ccodctb = filakar("ccodctb")
                    entidadcredkar.cconcep = filakar("cconcep")
                    entidadcredkar.nmonto = filakar("nmonto")
                    entidadcredkar.ccondic = filakar("ccondic")
                    entidadcredkar.ctrasctb = True
                    ecredkar.ActualizarCredkar1(entidadcredkar)

                    'Graba Boleta Revertida
                    If filakar("cconcep") = "CJ" Then
                        clsppal.GrabarBoletas(filakar("cbanco"), filakar("cnuming"), "X", Me.dfecpro, filakar("dfecpro"), (filakar("nmonto") * (-1)))
                    End If
                    If filakar("cconcep") = "CJ" Then
                        lncaja = filakar("nmonto")
                    End If

                Next

                'Reversion movimientos especiales
                If lncaja > 0 Then
                    'Aplicacion contable en base a la partida
                    'ObtenerPartidadePago
                    Dim dsconta As New DataSet
                    If lctippag.Trim = "P" Then
                        dsconta = mcntamov.ObtenerPartidadePagoIngresoAjuste(Me.ccodcta1, Me.cnrodoc)
                    Else
                        dsconta = mcntamov.ObtenerPartidadePago(Me.ccodcta1, Me.cnrodoc, "ING")
                    End If

                    For Each filaconta As DataRow In dsconta.Tables(0).Rows
                        lncontador = lncontador + 1

                        'agrega reversion a la cntamov
                        ecntamov.cnumcom = lcnumcom
                        ecntamov.ccodofi = filaconta("ccodofi")
                        ecntamov.cclase = filaconta("cclase")
                        ecntamov.cnumlin = lncontador
                        ecntamov.cnumdoc = "REV/" & Me.cnuming
                        ecntamov.dfeccnt = Me.dfecsis
                        ecntamov.dfecmod = Now
                        If filaconta("ccodsec") = "KP" And lccondic <> "S" Then 'Se rearmara cuenta contable por si ha sido trasladado a otra tipo de cartera
                            lcctactb = clase.fxcuentacontable(Me.ccodcta1, pccodlin, "N", "KP", "C", lccondic, lctippag, lcbanco, 0, 0, 0)
                            ecntamov.ccodcta = lcctactb
                        Else
                            ecntamov.ccodcta = filaconta("ccodcta")
                        End If
                        If filaconta("ndebe") > 0 Then
                            ecntamov.ndebe = 0
                            ecntamov.nhaber = filaconta("ndebe")
                        Else
                            ecntamov.ndebe = filaconta("nhaber")
                            ecntamov.nhaber = 0
                        End If
                        ecntamov.ffondos = filaconta("ffondos")
                        ecntamov.ccodpres = filaconta("ccodpres")
                        ecntamov.cflc = " "
                        ecntamov.nfln = filaconta("nfln")
                        ecntamov.cconcepto = filaconta("cconcepto")
                        ecntamov.cnumpol = filaconta("cnumpol")
                        ecntamov.ccodreg = filaconta("ccodreg")
                        ecntamov.cpoliza = "AR"
                        ecntamov.ccodusu1 = Me.ccodusu
                        ecntamov.corden = filaconta("corden")
                        ecntamov.ccodsec = filaconta("ccodsec")
                        ecntamov.ccodcli = filaconta("ccodcli")
                        ecntamov.cnumrec = IIf(IsDBNull(filaconta("cnumrec")), "", filaconta("cnumrec"))

                        mcntamov.agregarCntamov(ecntamov)

                        'If filakar("cconcep") = "CJ" Then
                        '    'abonar
                        '    ecntamov.nhaber = filakar("nmonto")
                        '    ecntamov.ndebe = 0
                        '    lncaja = filakar("nmonto")
                        '    lcbanco = filakar("cbanco")
                        '    lcnuming = IIf(IsDBNull(filakar("cnuming")), "", filakar("cnuming"))
                        '    lcnumrec = IIf(IsDBNull(filakar("cnumrec")), "", filakar("cnumrec"))
                        '    ecntamov.ffondos = lccodfue
                        'Else
                        '    ecntamov.ndebe = filakar("nmonto")
                        '    ecntamov.nhaber = 0
                        '    ecntamov.ffondos = lccodfue
                        'End If



                    Next

                    ''Revierte Auxiliar

                    'clssdes.cNrochq = lcnuming
                    'clssdes.cnumrec = ""
                    'clssdes.cBanco = lcbanco
                    'clssdes.nCJ = lncaja
                    'clssdes.gdfecsis = Me.dfecsis
                    'clssdes.cNomcli = lcnomcli
                    'clssdes.cGlosa = "REV.PAGOS"
                    'clssdes.cOficina = Me.ccodcta1.Substring(3, 3)
                    'clssdes.cCuenta = Me.ccodcta1
                    'clssdes.cnumrec = lcnumrec
                    'clssdes.GrabaenAuxiliar(lcnumcom, "D")


                End If


            End If


            'cambia estado a vigente
            entidad1.ccodcta = Me.ccodcta1
            entidad1.cestado = "F"
            ecreditos.Actualizar2(entidad1)

            'Revierte provision
            Dim dspro As New DataSet
            dspro = ecreditos.ObtenerEspejoProvision(Me.ccodcta1, Me.cnrodoc)
            Dim lnprovis As Double = 0
            Dim lnprovan As Double = 0
            Dim lnprovpas As Double = 0
            Dim lnprovmor As Double = 0
            If dspro.Tables(0).Rows.Count = 0 Then 'No tiene espejo
            Else
                lnprovis = IIf(IsDBNull(dspro.Tables(0).Rows(0)("nprovis")), 0, dspro.Tables(0).Rows(0)("nprovis"))
                lnprovan = IIf(IsDBNull(dspro.Tables(0).Rows(0)("nprovan")), 0, dspro.Tables(0).Rows(0)("nprovan"))
                lnprovpas = IIf(IsDBNull(dspro.Tables(0).Rows(0)("nprovpas")), 0, dspro.Tables(0).Rows(0)("nprovpas"))
                lnprovmor = IIf(IsDBNull(dspro.Tables(0).Rows(0)("nprovmor")), 0, dspro.Tables(0).Rows(0)("nprovmor"))
                ecreditos.ActualizaProvisiondeEspejo(Me.ccodcta1, lnprovis, lnprovan, lnprovmor, lnprovpas)

            End If

            'Dim lnprov As Double = 0
            'lnprov = ecredkar.ProvisionaRevertir(Me.ccodcta1, Me.cnrodoc)
            ''verifica si es de mes anterior
            'If Me.dfecsis.Month <> Me.dfecpro.Month Then
            '    ecredkar.RevierteProvision(Me.ccodcta1, lnprov)
            'Else
            '    ecredkar.RevierteProvisionMes(Me.ccodcta1, lnprov)
            'End If



            Return 1

        Catch ex As Exception
            Return 0
        End Try
    End Function

    'rutina para convertir los pagos de la credkar, en una sola fila
    Function conviertepagos(ByVal btodos As Boolean) As DataSet
        'obtiene nombre del cliente por credito
        Dim lcnomcli As String
        Dim mclientes As New ccreditos
        Dim eclientes As New creditos
        Dim ldfecven As Date
        Dim lnmoncuo As Double
        Dim lncuoapr As Integer
        Dim lcnomusu As String
        Dim lcdescob As String

        Dim mpagos As New cCredkar
        Dim mListakardex As listacredkar
        Dim mEntidadk As credkar
        Dim dspagos1 As New DataSet
        Dim clspagos1 As New clspagos
        Dim clspagos2 As New cCredkar
        Dim lcestado As String

        Dim dstmp As New DataSet
        Dim dr As DataRow
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcfilgas As New DataTable
        Dim clsprin As New class1
        Dim lcnrodoc As String
        Dim lncuenta2 As Integer

        Dim lnotros, lnintere, lncapita, lnmora, lnpago, lnsaldo As Double
        Dim ldfecsis, ldfecpro As Date
        Dim lcnuming As String
        Dim lcevalua As String
        Dim lccodcta As String
        Dim lncapdes As Double

        Dim lncuenta As Integer
        Dim i As Integer


        lcampos1 = "ccodcta, cnomcli, ncapdes,dfecsis, dfecpro, cnrodoc, nmonto, cconcep, cnuming, cdescob,ncapita,nintere,nmora,notros,npago,nsaldo,dfecven,nmoncuo,ncuoapr,cnomusu,"
        ltipos1 = "S,S,D,F,F,S,D,S,S,S,D,D,D,D,D,D,F,D,D,S,"
        lcfilgas = clsprin.creadatasetdesconec(lcampos1, ltipos1, "KARDEX1")

        'obtiene toda la base de la cremcre para filtrar pagos
        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre
        Dim mlistacremcre As listacremcre
        Dim filacre As DataRow
        If btodos = False Then 'es 0
            mlistacremcre = mcremcre.ObtenerListaPorcredito(Me.ccodcta1)
        Else
            mlistacremcre = mcremcre.ObtenerListaPorID()
        End If
        For Each ecremcre In mlistacremcre
            If ecremcre.cestado = "F" Then
                Me.ccodcta1 = ecremcre.ccodcta

                eclientes.ccodcta = Me.ccodcta1
                mclientes.Obtenercreditos(eclientes)
                lcnomcli = eclientes.cnomcli
                ldfecven = eclientes.dfecven
                lnmoncuo = eclientes.nmoncuo
                lncuoapr = eclientes.ncuoapr
                lcnomusu = eclientes.cNomUsu

                lcestado = " "

                mListakardex = clspagos2.ObtenerListaPorCuenta(Me.ccodcta1)
                lncuenta2 = mListakardex.Count

                lnintere = 0
                lncapita = 0
                lnmora = 0
                lnpago = 0
                lnotros = 0
                lncuenta = 0
                lncuenta = mListakardex.Count - 1
                i = 0
                lncapdes = mListakardex(0).nmonto
                lnsaldo = lncapdes + lncapdes ' porque el primero siempre es el desembolso

                Do
                    ldfecpro = mListakardex(i).dfecpro
                    ldfecsis = mListakardex(i).dfecsis
                    lcnuming = mListakardex(i).cnuming
                    lcdescob = mListakardex(i).cdescob
                    lcnrodoc = mListakardex(i).cnrodoc
                    lccodcta = mListakardex(i).ccodcta
                    Do
                        If mListakardex(i).cconcep = "KP" And mListakardex(i).cdescob = "D" Then
                            lncapdes = mListakardex(0).nmonto
                        End If

                        lcevalua = mListakardex(i).cconcep
                        If mListakardex(i).cconcep = "KP" Then
                            lncapita = lncapita + mListakardex(i).nmonto
                        ElseIf mListakardex(i).cconcep = "IN" Then
                            lnintere = lnintere + mListakardex(i).nmonto
                        ElseIf mListakardex(i).cconcep = "MO" Then
                            lnmora = lnmora + mListakardex(i).nmonto
                        ElseIf mListakardex(i).cconcep = "CJ" Then
                            lnpago = lnpago + mListakardex(i).nmonto
                        Else
                            lnotros = lnotros + mListakardex(i).nmonto
                        End If
                        If mListakardex(i).cnrodoc <> lcnrodoc Then
                            Exit Do
                        End If

                        If i <= lncuenta Then
                            i = i + 1
                            If i > lncuenta Then
                                Exit Do
                            End If
                        Else
                            Exit Do
                        End If
                    Loop While mListakardex(i).cnrodoc = lcnrodoc
                    'antes i <= lncuenta + 1 
                    lnsaldo = lnsaldo - lncapita

                    dr = lcfilgas.NewRow()
                    dr("ccodcta") = lccodcta
                    dr("cnomcli") = lcnomcli
                    dr("ncapdes") = lncapdes
                    dr("dfecsis") = ldfecsis
                    dr("dfecpro") = ldfecpro
                    dr("cnrodoc") = lcnrodoc
                    dr("cnuming") = lcnuming
                    dr("cdescob") = lcdescob
                    dr("ncapita") = lncapita
                    dr("nintere") = lnintere
                    dr("nmora") = lnmora
                    dr("npago") = lnpago
                    dr("notros") = lnotros
                    dr("nsaldo") = lnsaldo
                    dr("dfecven") = ldfecven
                    dr("nmoncuo") = lnmoncuo
                    dr("ncuoapr") = lncuoapr
                    dr("cnomusu") = lcnomusu
                    lncapita = 0
                    lnintere = 0
                    lnpago = 0
                    lnotros = 0
                    lnmora = 0
                    lcfilgas.Rows.Add(dr)
                Loop While i <= lncuenta
            End If 'CESTADO
        Next
        dstmp.Tables.Add(lcfilgas)
        Return dstmp

    End Function

    Function conviertepagos(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lcdescob As String) As DataSet
        'obtiene nombre del cliente por credito
        Dim lcnomcli As String
        Dim mclientes As New ccreditos
        Dim eclientes As New creditos
        Dim ldfecven As Date
        Dim lnmoncuo As Double
        Dim lncuoapr As Integer
        Dim lcnomusu As String

        Dim mpagos As New cCredkar
        Dim mListakardex As listacredkar
        Dim mEntidadk As credkar
        Dim dspagos1 As New DataSet
        Dim clspagos1 As New clspagos
        Dim clspagos2 As New cCredkar
        Dim lcestado As String

        Dim dstmp As New DataSet
        Dim dr As DataRow
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcfilgas As New DataTable
        Dim clsprin As New class1
        Dim lcnrodoc As String
        Dim lncuenta2 As Integer

        Dim lnotros, lnintere, lncapita, lnmora, lnpago, lnsaldo As Double
        Dim ldfecsis, ldfecpro As Date
        Dim lcnuming As String
        Dim lcevalua As String
        Dim lccodcta As String
        Dim lncapdes As Double


        Dim lncuenta As Integer
        Dim i As Integer


        lcampos1 = "ccodcta, cnomcli, ncapdes,dfecsis, dfecpro, cnrodoc, nmonto, cconcep, cnuming, cdescob,ncapita,nintere,nmora,notros,npago,nsaldo,dfecven,nmoncuo,ncuoapr,cnomusu,"
        ltipos1 = "S,S,D,F,F,S,D,S,S,S,D,D,D,D,D,D,F,D,D,S,"
        lcfilgas = clsprin.creadatasetdesconec(lcampos1, ltipos1, "KARDEX1")

        'obtiene toda la base de la cremcre para filtrar pagos
        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre
        Dim mlistacremcre As listacremcre
        Dim filacre As DataRow
        '   If btodos = False Then 'es 0
        '  mlistacremcre = mcremcre.ObtenerListaPorcredito(Me.ccodcta1)
        ' Else
        mlistacremcre = mcremcre.ObtenerListaPorID()
        'End If
        For Each ecremcre In mlistacremcre
            If ecremcre.cestado = "F" Then
                Me.ccodcta1 = ecremcre.ccodcta

                eclientes.ccodcta = Me.ccodcta1
                mclientes.Obtenercreditos(eclientes)
                lcnomcli = eclientes.cnomcli
                ldfecven = eclientes.dfecven
                lnmoncuo = eclientes.nmoncuo
                lncuoapr = eclientes.ncuoapr
                lcnomusu = eclientes.cNomUsu

                lcestado = " "

                mListakardex = clspagos2.ObtenerListafecha(Me.ccodcta1, ldfecha1, ldfecha2, lcdescob)
                lncuenta2 = mListakardex.Count

                lnintere = 0
                lncapita = 0
                lnmora = 0
                lnpago = 0
                lnotros = 0
                lncuenta = 0
                lncuenta = mListakardex.Count - 1
                i = 0
                If lncuenta > 0 Then
                    lncapdes = mListakardex(0).nmonto
                    lnsaldo = lncapdes + lncapdes ' porque el primero siempre es el desembolso

                    Do
                        ldfecpro = mListakardex(i).dfecpro
                        ldfecsis = mListakardex(i).dfecsis
                        lcnuming = mListakardex(i).cnuming
                        lcdescob = mListakardex(i).cdescob
                        lcnrodoc = mListakardex(i).cnrodoc
                        lccodcta = mListakardex(i).ccodcta
                        Do
                            If mListakardex(i).cconcep = "KP" And mListakardex(i).cdescob = "D" Then
                                lncapdes = mListakardex(0).nmonto
                            End If

                            lcevalua = mListakardex(i).cconcep

                            If mListakardex(i).cconcep = "KP" Then
                                lncapita = lncapita + mListakardex(i).nmonto
                            ElseIf mListakardex(i).cconcep = "IN" Then
                                lnintere = lnintere + mListakardex(i).nmonto
                            ElseIf mListakardex(i).cconcep = "MO" Then
                                lnmora = lnmora + mListakardex(i).nmonto
                            ElseIf mListakardex(i).cconcep = "CJ" Then
                                lnpago = lnpago + mListakardex(i).nmonto
                            Else
                                lnotros = lnotros + mListakardex(i).nmonto
                            End If
                            If i <= lncuenta Then
                                i = i + 1
                                If i > lncuenta Then
                                    Exit Do
                                End If
                            Else
                                Exit Do
                            End If
                        Loop While mListakardex(i).cnrodoc = lcnrodoc
                        lnsaldo = lnsaldo - lncapita

                        dr = lcfilgas.NewRow()
                        dr("ccodcta") = lccodcta
                        dr("cnomcli") = lcnomcli
                        dr("ncapdes") = lncapdes
                        dr("dfecsis") = ldfecsis
                        dr("dfecpro") = ldfecpro
                        dr("cnrodoc") = lcnrodoc
                        dr("cnuming") = lcnuming
                        dr("cdescob") = lcdescob
                        dr("ncapita") = lncapita
                        dr("nintere") = lnintere
                        dr("nmora") = lnmora
                        dr("npago") = lnpago
                        dr("notros") = lnotros
                        dr("nsaldo") = lnsaldo
                        dr("dfecven") = ldfecven
                        dr("nmoncuo") = lnmoncuo
                        dr("ncuoapr") = lncuoapr
                        dr("cnomusu") = lcnomusu
                        lncapita = 0
                        lnintere = 0
                        lnpago = 0
                        lnotros = 0
                        lnmora = 0
                        lcfilgas.Rows.Add(dr)
                    Loop While i <= lncuenta
                End If 'mayor que cero
            End If 'CESTADO
        Next
        dstmp.Tables.Add(lcfilgas)
        Return dstmp

    End Function


    Function conviertepagos_cnuming(ByVal ccodcta, ByVal lcnuming2) As DataSet
        'obtiene nombre del cliente por credito
        Dim lcnomcli As String
        Dim mclientes As New ccreditos
        Dim eclientes As New creditos
        Dim ldfecven As Date
        Dim lnmoncuo As Double
        Dim lncuoapr As Integer
        Dim lcnomusu As String

        Dim mpagos As New cCredkar
        Dim mListakardex As listacredkar
        Dim mEntidadk As credkar
        Dim dspagos1 As New DataSet
        Dim clspagos1 As New clspagos
        Dim clspagos2 As New cCredkar
        Dim lcestado As String

        Dim dstmp As New DataSet
        Dim dr As DataRow
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcfilgas As New DataTable
        Dim clsprin As New class1
        Dim lcnrodoc As String
        Dim lncuenta2 As Integer

        Dim lnotros, lnintere, lncapita, lnmora, lnpago, lnsaldo As Double
        Dim ldfecsis, ldfecpro As Date
        Dim lcnuming, lcdescob As String
        Dim lcevalua As String
        Dim lccodcta As String
        Dim lncapdes As Double

        Dim lncuenta As Integer
        Dim i As Integer


        lcampos1 = "ccodcta, cnomcli, ncapdes,dfecsis, dfecpro, cnrodoc, nmonto, cconcep, cnuming, cdescob,ncapita,nintere,nmora,notros,npago,nsaldo,dfecven,nmoncuo,ncuoapr,cnomusu,"
        ltipos1 = "S,S,D,F,F,S,D,S,S,S,D,D,D,D,D,D,F,D,D,S,"
        lcfilgas = clsprin.creadatasetdesconec(lcampos1, ltipos1, "KARDEX1")

        'obtiene toda la base de la cremcre para filtrar pagos
        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre
        Dim mlistacremcre As listacremcre
        Dim filacre As DataRow
        '   If btodos = False Then 'es 0
        '  mlistacremcre = mcremcre.ObtenerListaPorcredito(Me.ccodcta1)
        ' Else
        mlistacremcre = mcremcre.ObtenerListaPorID()
        'End If
        For Each ecremcre In mlistacremcre
            If ecremcre.cestado = "F" Then
                Me.ccodcta1 = ecremcre.ccodcta

                eclientes.ccodcta = Me.ccodcta1
                mclientes.Obtenercreditos(eclientes)
                lcnomcli = eclientes.cnomcli
                ldfecven = eclientes.dfecven
                lnmoncuo = eclientes.nmoncuo
                lncuoapr = eclientes.ncuoapr
                lcnomusu = eclientes.cNomUsu

                lcestado = " "

                mListakardex = clspagos2.ObtenerListacnuming(Me.ccodcta1, lcnuming2)
                lncuenta2 = mListakardex.Count

                lnintere = 0
                lncapita = 0
                lnmora = 0
                lnpago = 0
                lnotros = 0
                lncuenta = 0
                lncuenta = mListakardex.Count - 1
                i = 0
                If lncuenta > 0 Then
                    lncapdes = mListakardex(0).nmonto
                    lnsaldo = lncapdes + lncapdes ' porque el primero siempre es el desembolso

                    Do
                        ldfecpro = mListakardex(i).dfecpro
                        ldfecsis = mListakardex(i).dfecsis
                        lcnuming = mListakardex(i).cnuming
                        lcdescob = mListakardex(i).cdescob
                        lcnrodoc = mListakardex(i).cnrodoc
                        lccodcta = mListakardex(i).ccodcta
                        Do
                            If mListakardex(i).cconcep = "KP" And mListakardex(i).cdescob = "D" Then
                                lncapdes = mListakardex(0).nmonto
                            End If

                            lcevalua = mListakardex(i).cconcep

                            If mListakardex(i).cconcep = "KP" Then
                                lncapita = lncapita + mListakardex(i).nmonto
                            ElseIf mListakardex(i).cconcep = "IN" Then
                                lnintere = lnintere + mListakardex(i).nmonto
                            ElseIf mListakardex(i).cconcep = "MO" Then
                                lnmora = lnmora + mListakardex(i).nmonto
                            ElseIf mListakardex(i).cconcep = "CJ" Then
                                lnpago = lnpago + mListakardex(i).nmonto
                            Else
                                lnotros = lnotros + mListakardex(i).nmonto
                            End If
                            If i <= lncuenta Then
                                i = i + 1
                                If i > lncuenta Then
                                    Exit Do
                                End If
                            Else
                                Exit Do
                            End If
                        Loop While mListakardex(i).cnrodoc = lcnrodoc
                        lnsaldo = lnsaldo - lncapita

                        dr = lcfilgas.NewRow()
                        dr("ccodcta") = lccodcta
                        dr("cnomcli") = lcnomcli
                        dr("ncapdes") = lncapdes
                        dr("dfecsis") = ldfecsis
                        dr("dfecpro") = ldfecpro
                        dr("cnrodoc") = lcnrodoc
                        dr("cnuming") = lcnuming
                        dr("cdescob") = lcdescob
                        dr("ncapita") = lncapita
                        dr("nintere") = lnintere
                        dr("nmora") = lnmora
                        dr("npago") = lnpago
                        dr("notros") = lnotros
                        dr("nsaldo") = lnsaldo
                        dr("dfecven") = ldfecven
                        dr("nmoncuo") = lnmoncuo
                        dr("ncuoapr") = lncuoapr
                        dr("cnomusu") = lcnomusu
                        lncapita = 0
                        lnintere = 0
                        lnpago = 0
                        lnotros = 0
                        lnmora = 0
                        lcfilgas.Rows.Add(dr)
                    Loop While i <= lncuenta
                End If 'mayor que cero
            End If 'CESTADO
        Next
        dstmp.Tables.Add(lcfilgas)
        Return dstmp

    End Function


    'crea numero de partida para la partida fija de pagos
    '    lcnumcom = Mid(gccodofi, 2, 2) & "999997"
    Public Function crea_partidas_pagos(ByVal dfecha As Date)
        Dim lcnumcom1 As String
        Dim lcnumcom As String
        Dim numpartida As New crefunc
        Dim mcntamov As New dbCntamov
        Dim ecntamov As New cntamov
        Dim mdiario As New dbDiario
        Dim ediario As New diario
        Dim fila As DataRow
        Dim lcantnumcom As String
        Dim filacntamov As DataRow
        Dim lncuenta As Integer
        Dim i As Integer
        Dim si As Integer
        Try
            lcantnumcom = "99999997"

            'obtiene de la diario
            ediario.cnumcom = lcantnumcom
            si = mdiario.Recuperar(ediario)
            If si > 0 Then
                lcnumcom = numpartida.fxStevo(dfecha)

                'ahora crea un nuevo registro con el nuevo numero de partida
                ediario.cnumcom = lcnumcom
                mdiario.Agregar(ediario)

                ecntamov.cnumcom = lcantnumcom
                'mcntamov.Actualizar(ecntamov)

                mcntamov.Actualizar_partida(lcnumcom, lcantnumcom)
                ediario.cnumcom = lcantnumcom
                mdiario.Eliminar(ediario)
            End If

        Catch ex As Exception
            Return -1
        End Try


    End Function

#End Region

End Class
