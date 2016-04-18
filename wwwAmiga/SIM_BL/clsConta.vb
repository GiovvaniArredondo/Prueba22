Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings


Public Class clsConta
#Region "Propiedades"
    Private _cCodofi As String
    Public Property cCodofi() As String
        Get
            Return _cCodofi
        End Get
        Set(ByVal Value As String)
            _cCodofi = Value
        End Set
    End Property
    Private _cCodUsu As String
    Public Property cCodUsu() As String
        Get
            Return _cCodUsu
        End Get
        Set(ByVal Value As String)
            _cCodUsu = Value
        End Set
    End Property
    Private _dfecmes As String
    Public Property dfecmes() As String
        Get
            Return _dfecmes
        End Get
        Set(ByVal Value As String)
            _dfecmes = Value
        End Set
    End Property
    Private _dFecIni As Date
    Public Property dFecIni() As Date
        Get
            Return _dFecIni
        End Get
        Set(ByVal Value As Date)
            _dFecIni = Value
        End Set
    End Property
    Private _dFecfin As Date
    Public Property dFecfin() As Date
        Get
            Return _dFecfin
        End Get
        Set(ByVal Value As Date)
            _dFecfin = Value
        End Set
    End Property

    Private _dBuscar As Date
    Public Property dBuscar() As Date
        Get
            Return _dBuscar
        End Get
        Set(ByVal Value As Date)
            _dBuscar = Value
        End Set
    End Property

    Private _cBuscar As String
    Public Property cBuscar() As String
        Get
            Return _cBuscar
        End Get
        Set(ByVal Value As String)
            _cBuscar = Value
        End Set
    End Property
    Private _nBuscar As Double
    Public Property nBuscar() As Double
        Get
            Return _nBuscar
        End Get
        Set(ByVal Value As Double)
            _nBuscar = Value
        End Set
    End Property

    Private _nOpBuscar As Integer
    Public Property nOpBuscar() As Integer
        Get
            Return _nOpBuscar
        End Get
        Set(ByVal Value As Integer)
            _nOpBuscar = Value
        End Set
    End Property


    Private _pnsalini As Double
    Public Property pnsalini() As Double
        Get
            Return _pnsalini
        End Get
        Set(ByVal Value As Double)
            _pnsalini = Value
        End Set
    End Property

    Private _pnsalfin As Double
    Public Property pnsalfin() As Double
        Get
            Return _pnsalfin
        End Get
        Set(ByVal Value As Double)
            _pnsalfin = Value
        End Set
    End Property

    Private _pndebe As Double
    Public Property pndebe() As Double
        Get
            Return _pndebe
        End Get
        Set(ByVal Value As Double)
            _pndebe = Value
        End Set
    End Property


    Private _pnhaber As Double
    Public Property pnhaber() As Double
        Get
            Return _pnhaber
        End Get
        Set(ByVal Value As Double)
            _pnhaber = Value
        End Set
    End Property

    Private _pnutilidad As Double
    Public Property pnutilidad() As Double
        Get
            Return _pnutilidad
        End Get
        Set(ByVal Value As Double)
            _pnutilidad = Value
        End Set
    End Property

    Private _pningresos As Double
    Public Property pningresos() As Double
        Get
            Return _pningresos
        End Get
        Set(ByVal Value As Double)
            _pningresos = Value
        End Set
    End Property


    Private _pngastos As Double
    Public Property pngastos() As Double
        Get
            Return _pngastos
        End Get
        Set(ByVal Value As Double)
            _pngastos = Value
        End Set
    End Property


    Private _pnactivo As Double
    Public Property pnactivo() As Double
        Get
            Return _pnactivo
        End Get
        Set(ByVal Value As Double)
            _pnactivo = Value
        End Set
    End Property


    Private _pnpasivo As Double
    Public Property pnpasivo() As Double
        Get
            Return _pnpasivo
        End Get
        Set(ByVal Value As Double)
            _pnpasivo = Value
        End Set
    End Property

    Private _pcnomser As String
    Public Property pcnomser() As String
        Get
            Return _pcnomser
        End Get
        Set(ByVal Value As String)
            _pcnomser = Value
        End Set
    End Property

    Private _cdesde As String
    Public Property cdesde() As String
        Get
            Return _cdesde
        End Get
        Set(ByVal Value As String)
            _cdesde = Value
        End Set
    End Property
    Private _chasta As String
    Public Property chasta() As String
        Get
            Return _chasta
        End Get
        Set(ByVal Value As String)
            _chasta = Value
        End Set
    End Property
    Private _pnDebeac As Double
    Public Property pnDebeac() As Double
        Get
            Return _pnDebeac
        End Get
        Set(ByVal Value As Double)
            _pnDebeac = Value
        End Set
    End Property
    Private _pnHaberac As Double
    Public Property pnHabereac() As Double
        Get
            Return _pnHaberac
        End Get
        Set(ByVal Value As Double)
            _pnHaberac = Value
        End Set
    End Property

    Private _pnCargos As Double
    Public Property pnCargos() As Double
        Get
            Return _pnCargos
        End Get
        Set(ByVal Value As Double)
            _pnCargos = Value
        End Set
    End Property
    Private _pnAbonos As Double
    Public Property pnAbonos() As Double
        Get
            Return _pnAbonos
        End Get
        Set(ByVal Value As Double)
            _pnAbonos = Value
        End Set
    End Property
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Private _pcCodOfi As String
    Public Property pcCodofi() As String
        Get
            Return _pcCodOfi
        End Get
        Set(ByVal Value As String)
            _pcCodOfi = Value
        End Set
    End Property
    Private _pcFuente As String
    Public Property pcFuente() As String
        Get
            Return _pcFuente
        End Get
        Set(ByVal Value As String)
            _pcFuente = Value
        End Set
    End Property
    Private _pcyears As String
    Public Property pcyears() As String
        Get
            Return _pcyears
        End Get
        Set(ByVal Value As String)
            _pcyears = Value
        End Set
    End Property

    Private _pccierre As String
    Public Property pccierre() As String
        Get
            Return _pccierre
        End Get
        Set(ByVal Value As String)
            _pccierre = Value
        End Set
    End Property
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private _nValacc As Double
    Public Property nValacc() As Double
        Get
            Return _nValacc
        End Get
        Set(ByVal Value As Double)
            _nValacc = Value
        End Set
    End Property

    Private _pnSumdebe As Double
    Public Property pnSumdebe() As Double
        Get
            Return _pnSumdebe
        End Get
        Set(ByVal Value As Double)
            _pnSumdebe = Value
        End Set
    End Property

    Private _pnSumhaber As Double
    Public Property pnSumhaber() As Double
        Get
            Return _pnSumhaber
        End Get
        Set(ByVal Value As Double)
            _pnSumhaber = Value
        End Set
    End Property
    Private _pndebei As Double
    Public Property pndebei() As Double
        Get
            Return _pndebei
        End Get
        Set(ByVal Value As Double)
            _pndebei = Value
        End Set
    End Property
    Private _pndebei2 As Double
    Public Property pndebei2() As Double
        Get
            Return _pndebei2
        End Get
        Set(ByVal Value As Double)
            _pndebei2 = Value
        End Set
    End Property

    Private _pnhaberi As Double
    Public Property pnhaberi() As Double
        Get
            Return _pnhaberi
        End Get
        Set(ByVal Value As Double)
            _pnhaberi = Value
        End Set
    End Property
    Private _pnhaberi2 As Double
    Public Property pnhaberi2() As Double
        Get
            Return _pnhaberi2
        End Get
        Set(ByVal Value As Double)
            _pnhaberi2 = Value
        End Set
    End Property

#End Region

    'Agrega Catalogo a CNTABAL
    Public Function AgregarCNTABAL(ByVal ccodigo As String) As Integer
        Dim entidadctbmcta As New SIM.EL.ctbmcta
        Dim ectbmcta As New SIM.BL.cCtbmcta

        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal

        Dim ds As New DataSet
        Dim nelem As Integer
        Dim fila As DataRow
        ds = ectbmcta.ObtenerDataSetPorID(ccodigo)
        nelem = ds.Tables(0).Rows.Count()
        If nelem = 0 Then
            Return 0
        End If
        nelem = 0
        For Each fila In ds.Tables(0).Rows
            entidadcntabal.ccodcta = ds.Tables(0).Rows(nelem)("cCodCta")
            entidadcntabal.bs = ""
            entidadcntabal.cclase = ds.Tables(0).Rows(nelem)("cClase")
            entidadcntabal.ccodbal = ds.Tables(0).Rows(nelem)("cCtaSup")
            entidadcntabal.ccodofi = Me.cCodofi
            entidadcntabal.ccodto = ds.Tables(0).Rows(nelem)("cCodto")
            entidadcntabal.ccodusu = Me.cCodUsu
            entidadcntabal.cfecmes = Me.dfecmes
            entidadcntabal.cflc = ""
            entidadcntabal.cnivel = ds.Tables(0).Rows(nelem)("cNivel")
            entidadcntabal.ctipcta = ds.Tables(0).Rows(nelem)("cTipCta")
            entidadcntabal.ctipmon = ds.Tables(0).Rows(nelem)("ctipmon")
            entidadcntabal.ffondos = ""
            entidadcntabal.ndebe = 0
            entidadcntabal.ndebeac = 0
            entidadcntabal.nsalfin = 0
            entidadcntabal.nsalini = 0
            ecntabal.Agregar(entidadcntabal)
            nelem = nelem + 1
        Next
        Return 1
    End Function

    'Calcula Saldos para Cuentas de Detalle
    Public Function CtaDetalle() As Integer
        Dim entidadctbmcta As New SIM.EL.ctbmcta
        Dim ectbmcta As New SIM.BL.cCtbmcta
        Dim ds As New DataSet
        Dim nelem As Integer
        Dim fila As DataRow
        Dim pnSalIni As Double = 0
        ds = ectbmcta.ObtenerDataSetPorIDDet
        nelem = ds.Tables(0).Rows.Count()
        If nelem = 0 Then
            Return 0
        End If
        nelem = 0
        Dim pcCodCta As String
        Dim pnSaldo As Double
        For Each fila In ds.Tables(0).Rows
            pcCodCta = ds.Tables(0).Rows(nelem)("cCodCta")
            pnSalIni = ds.Tables(0).Rows(nelem)("nSalIni")
            CalculaSaldoDet(pcCodCta.Trim, Me.dFecIni, Me.dFecfin, Me.dfecmes, pnSalIni)
            nelem = nelem + 1
        Next
    End Function

    Public Function CalculaSaldoDet(ByVal pcCodCta As String, ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcFecmes As String, ByVal nSalIni As Double)
        'ObtenerDataSetPorCuenta1
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        Dim ds As New DataSet
        Dim nelem1 As Integer
        Dim lnSaldo As Double
        Dim lnDebe As Double = 0
        Dim lnhaber As Double = 0
        ds = ecntamov.ObtenerDataSetPorCuenta1(pcCodCta, pdFecIni, pdFecFin)
        nelem1 = ds.Tables(0).Rows.Count()
        If nelem1 = 0 Then
            Return 0
        End If
        lnDebe = IIf(IsDBNull(ds.Tables(0).Rows(0)("nDebe")), 0, ds.Tables(0).Rows(0)("nDebe"))
        lnhaber = IIf(IsDBNull(ds.Tables(0).Rows(0)("nhaber")), 0, ds.Tables(0).Rows(0)("nhaber"))

        'Actualiza cntabal
        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal
        entidadcntabal.ccodcta = pcCodCta
        entidadcntabal.ndebe = lnDebe
        entidadcntabal.nhaber = lnhaber
        entidadcntabal.nsalini = nSalIni
        'De Acuerdo a Naturaleza de Cuentas realiza Operacion
        If Left(pcCodCta, 1) = "1" Or _
                     Left(pcCodCta, 1) = "5" Or Left(pcCodCta, 1) = "7" Or Left(pcCodCta, 1) = "8" Or _
                     Left(pcCodCta, 2) = "91" Or Left(pcCodCta, 2) = "92" Then
            entidadcntabal.nsalfin = (nSalIni + lnDebe) - lnhaber
        Else
            entidadcntabal.nsalfin = (nSalIni + lnhaber) - lnDebe
        End If
        entidadcntabal.ndebeac = lnDebe
        entidadcntabal.nhaberac = lnhaber
        entidadcntabal.cfecmes = pcFecmes
        entidadcntabal.ffondos = "01"
        ecntabal.Actualizar1(entidadcntabal)
    End Function

    Public Function CtaResumen() As Integer
        Dim entidadctbmcta As New SIM.EL.ctbmcta
        Dim ectbmcta As New SIM.BL.cCtbmcta
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet

        Dim nelem1 As Integer
        Dim nelem2 As Integer
        Dim nelem3 As Integer

        Dim fila1 As DataRow
        Dim fila2 As DataRow
        Dim fila3 As DataRow

        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal

        ds1 = ectbmcta.ObtenerDataSetPorID2
        nelem1 = ds1.Tables(0).Rows.Count()
        Dim pcCodCta As String
        Dim pcCodCtah As String
        Dim pnSaldo As Double
        Dim pnSaldop, pnDebep, pnHaberp As Double ' Saldo de cuentas Padres
        Dim pnSalInip As Double
        If nelem1 = 0 Then
            Return 0
        End If
        nelem1 = 0
        For Each fila1 In ds1.Tables(0).Rows 'Cuentas Padres
            pcCodCta = ds1.Tables(0).Rows(nelem1)("cCodCta")
            ds2 = ectbmcta.ObtenerDataSetPorID3(pcCodCta.Trim)
            nelem2 = ds2.Tables(0).Rows.Count
            pnSaldop = 0
            pnDebep = 0
            pnHaberp = 0
            pnSalInip = 0

            If nelem2 = 0 Then

            Else
                nelem2 = 0
                For Each fila2 In ds2.Tables(0).Rows 'Cuentas Hijas
                    pcCodCtah = ds2.Tables(0).Rows(nelem2)("cCodCta")
                    ds3.Tables.Clear()
                    Dim pnsaliniH, pnSaldoH, pnDebeH, pnHaberH As Double 'Saldo de cuentas hijas
                    ds3 = ecntabal.ObtenerDataSetPorIDH(pcCodCtah.Trim)
                    nelem3 = ds3.Tables(0).Rows.Count
                    If nelem3 = 0 Then
                        pnSaldoH = 0
                    Else
                        nelem3 = 0
                        pnSaldoH = 0
                        pnsaliniH = 0
                        pnDebeH = 0
                        pnHaberH = 0
                        For Each fila3 In ds3.Tables(0).Rows    'Saldos de Cuentas Hijas
                            pnsaliniH = ds3.Tables(0).Rows(nelem3)("nSalIni")
                            pnSaldoH = ds3.Tables(0).Rows(nelem3)("nSalfin")
                            pnDebeH = ds3.Tables(0).Rows(nelem3)("nDebe")
                            pnHaberH = ds3.Tables(0).Rows(nelem3)("nHaber")
                            nelem3 = nelem3 + 1
                        Next
                    End If
                    nelem2 = nelem2 + 1
                    pnSaldop = pnSaldop + pnSaldoH
                    pnDebep = pnDebep + pnDebeH
                    pnHaberp = pnHaberp + pnHaberH
                    pnSalInip = pnSalInip + pnsaliniH
                Next
                'Grabar el saldo de cuentas hijas en cuenta padre
                entidadcntabal.ccodcta = pcCodCta.Trim
                entidadcntabal.cfecmes = Me.dfecmes
                entidadcntabal.ndebe = pnDebep
                entidadcntabal.nhaber = pnHaberp
                entidadcntabal.nsalini = pnSalInip
                entidadcntabal.nsalfin = pnSaldop
                entidadcntabal.ndebeac = pnDebep
                entidadcntabal.nhaberac = pnHaberp
                entidadcntabal.ffondos = "01"
                ecntabal.Actualizar1(entidadcntabal)
            End If
            nelem1 = nelem1 + 1
        Next
    End Function


    Public Function GenBalance() As DataSet

        Dim claseppal As New class1

        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal
        Dim i As Integer
        i = 0

        Dim mlistacntabal As listacntabal
        mlistacntabal = ecntabal.ObtenerLista
        Dim lcCodCta As String
        Dim lcCtaSup As String
        Dim lcCodto As String
        Dim lnsalfin As Double
        Dim lcnivel As String
        Dim lcdescrip As String
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim lcnivelS As String
        Dim lcFecLet As String
        dsBal.Clear()
        lCampos1 = "cCodCta, cDescrip, cCodto, nNivel01, nnivel02, cnivel02, nnivel03, cnivel03, nnivel04, cnivel04, nnivel05, cDes05, nnivel06, cnivel06, cFecha, "
        lTipos1 = "S,S,S,D,D,S,D,S,D,S,D,S,D,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        lcFecLet = Me.Fecha(Me.dFecfin)
        Dim lnAct, lnPas, lnPat As Double
        Dim lnFlag As Integer
        Dim lcCamCta As String
        lcCamCta = "1"
        lnFlag = 0
        lnPas = 0
        lnPat = 0
        For Each entidadcntabal In mlistacntabal
            lcCodCta = mlistacntabal(i).ccodcta
            lnsalfin = mlistacntabal(i).nsalfin
            lcCodto = mlistacntabal(i).ccodto
            lcnivel = mlistacntabal(i).cnivel
            lcCtaSup = mlistacntabal(i).ccodbal
            lcdescrip = mlistacntabal(i).cdescrip
            lcnivelS = claseppal.fxStrZero(lcCtaSup.Trim.Length, 2).ToString
            If lnsalfin <> 0 Then
                'Asigna Total de Activo
                If lcCodCta.Trim = "1" Then
                    lnAct = lnsalfin
                End If
                'Break Activo
                If Left(lcCodCta.Trim, 1) <> lcCamCta Then
                    If lcCamCta = "1" Then
                        DR = DT.NewRow
                        DR("cCodcta") = ""
                        DR("cCodto") = ""
                        DR("cDescrip") = "TOTAL ACTIVO"
                        DR("nNivel02") = lnAct
                        DR("cnivel02") = lcdescrip
                        DR("cFecha") = lcFecLet
                        DT.Rows.Add(DR)
                        lnFlag = lnFlag + 1
                    End If
                End If
                'Break Pasivo
                If lcCodCta.Trim = "2" Then
                    lnPas = lnsalfin
                End If
                'Break Patrimonio
                If lcCodCta.Trim = "3" Then
                    lnPat = lnsalfin
                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                DR = DT.NewRow
                DR("cCodcta") = lcCodCta
                DR("cCodto") = lcCodto
                DR("cDescrip") = lcdescrip
                DR("cFecha") = lcFecLet
                If lcCodto = "P" Then
                    DR("nNivel01") = lnsalfin
                ElseIf lcCodto = "D" Then
                    DR("nNivel06") = lnsalfin
                    DR("cnivel06") = lcdescrip
                Else
                    If lcnivelS = "01" Then
                        DR("nNivel02") = lnsalfin
                        DR("cnivel02") = lcdescrip

                    ElseIf lcnivelS = "02" Then
                        DR("nNivel03") = lnsalfin
                        DR("cnivel03") = lcdescrip

                    ElseIf lcnivelS = "03" Then
                        DR("nNivel04") = lnsalfin
                        DR("cnivel04") = lcdescrip
                    ElseIf lcnivelS = "05" Then
                        DR("nnivel05") = lnsalfin
                        DR("cnivel05") = lcdescrip
                    End If
                End If
                DT.Rows.Add(DR)
                lcCamCta = Left(lcCodCta.Trim, 1)
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            End If
            i = i + 1
        Next
        If lnFlag = 0 Then
            DR = DT.NewRow
            DR("cCodcta") = ""
            DR("cFecha") = lcFecLet
            DR("cCodto") = ""
            DR("cDescrip") = "TOTAL ACTIVO"
            DR("cnivel02") = "TOTAL ACTIVO"
            DR("nNivel02") = lnAct

            DT.Rows.Add(DR)
        End If
        'Agregar Total Pasivo y Patrimonio y Resultado de Ejercicio
        Dim lnResEje As Double
        lnResEje = Me.Resultado_Ejercicio()
        '-----------------
        DR = DT.NewRow
        DR("cCodcta") = ""
        DR("cFecha") = lcFecLet
        DR("cCodto") = ""
        DR("cDescrip") = "RESULTADO DEL EJERCICIO"
        DR("cnivel02") = "RESULTADO DEL EJERCICIO"
        DR("nNivel02") = lnResEje

        DT.Rows.Add(DR)

        '------------------
        DR = DT.NewRow
        DR("cCodcta") = ""
        DR("cFecha") = lcFecLet
        DR("cCodto") = ""
        DR("cDescrip") = "TOTAL PASIVO Y PATRIMONIO"
        DR("cnivel02") = "TOTAL PASIVO Y PATRIMONIO"
        DR("nNivel02") = lnResEje + lnPas + lnPat

        DT.Rows.Add(DR)
        '-------------------
        dsBal.Tables.Add(DT)

        Return dsBal
    End Function
    Public Function Catalogo(ByVal ccodigo As String) As DataSet
        Dim ectbmcta As New cCtbmcta
        Dim ecntamov As New cCntamov
        Dim ds As New DataSet
        Dim dsdet As New DataSet


        Dim elem As Integer = 0
        Dim reg As Integer = 0
        Dim fila As DataRow
        ds = ectbmcta.ObtenerDataSetPorID(ccodigo)
        reg = ds.Tables(0).Rows.Count
        If ds.Tables(0).Rows.Count = 0 Then
            Return ds
        End If
        Dim lccodto As String
        Dim lccodcta As String
        Dim lcctasup As String
        Dim lnfila As DataRow
        Dim lndebeac As Double = 0
        Dim lnhaberac As Double = 0
        Dim lncargos As Double = 0
        Dim lnabonos As Double = 0
        Dim lnsalini As Double = 0


        For Each fila In ds.Tables(0).Rows
            lccodto = ds.Tables(0).Rows(elem)("cCodto")
            lccodcta = ds.Tables(0).Rows(elem)("cCodCta")
            If lccodto.Trim = "R" Then 'Nivel 1
                Dim dssup1 As New DataSet
                Dim elem1 As Integer = 0
                Dim fila1 As DataRow
                Dim lccodcta1 As String
                Dim lccodto1 As String
                dssup1 = ecntamov.CuentaSuperior(lccodcta.Trim)
                For Each fila1 In dssup1.Tables(0).Rows
                    lccodcta1 = dssup1.Tables(0).Rows(elem1)("cCodcta")
                    lccodto1 = dssup1.Tables(0).Rows(elem1)("cCodto")
                    If lccodto1.Trim = "R" Then 'Nivel 11
                        Dim dssup2 As New DataSet
                        Dim elem2 As Integer = 0
                        Dim fila2 As DataRow
                        Dim lccodcta2 As String
                        Dim lccodto2 As String
                        dssup2 = ecntamov.CuentaSuperior(lccodcta1.Trim)
                        For Each fila2 In dssup2.Tables(0).Rows
                            lccodcta2 = dssup2.Tables(0).Rows(elem2)("cCodcta")
                            lccodto2 = dssup2.Tables(0).Rows(elem2)("cCodto")
                            If lccodto2.Trim = "R" Then 'Nivel 1101
                                Dim dssup3 As New DataSet
                                Dim elem3 As Integer = 0
                                Dim fila3 As DataRow
                                Dim lccodcta3 As String
                                Dim lccodto3 As String
                                dssup3 = ecntamov.CuentaSuperior(lccodcta2.Trim)
                                For Each fila3 In dssup3.Tables(0).Rows
                                    lccodcta3 = dssup3.Tables(0).Rows(elem3)("cCodcta")
                                    lccodto3 = dssup3.Tables(0).Rows(elem3)("cCodto")
                                    If lccodto3.Trim = "R" Then 'Nivel 110101
                                        Dim dssup4 As New DataSet
                                        Dim elem4 As Integer = 0
                                        Dim fila4 As DataRow
                                        Dim lccodcta4 As String
                                        Dim lccodto4 As String
                                        dssup4 = ecntamov.CuentaSuperior(lccodcta3.Trim)
                                        For Each fila4 In dssup4.Tables(0).Rows
                                            lccodcta4 = dssup4.Tables(0).Rows(elem4)("cCodcta")
                                            lccodto4 = dssup4.Tables(0).Rows(elem4)("cCodto")
                                            If lccodto4.Trim = "R" Then 'Nivel 11010101
                                                Dim dssup5 As New DataSet
                                                Dim elem5 As Integer = 0
                                                Dim fila5 As DataRow
                                                Dim lccodcta5 As String
                                                Dim lccodto5 As String
                                                dssup5 = ecntamov.CuentaSuperior(lccodcta4.Trim)
                                                For Each fila5 In dssup5.Tables(0).Rows
                                                    lccodcta5 = dssup5.Tables(0).Rows(elem5)("cCodcta")
                                                    lccodto5 = dssup5.Tables(0).Rows(elem5)("cCodto")
                                                    If lccodto5.Trim = "R" Then 'Nivel 1101010101
                                                        Dim dssup6 As New DataSet
                                                        Dim elem6 As Integer = 0
                                                        Dim fila6 As DataRow
                                                        Dim lccodcta6 As String
                                                        Dim lccodto6 As String
                                                        dssup6 = ecntamov.CuentaSuperior(lccodcta5.Trim)
                                                        For Each fila6 In dssup6.Tables(0).Rows
                                                            lccodcta6 = dssup6.Tables(0).Rows(elem6)("cCodcta")
                                                            lccodto6 = dssup6.Tables(0).Rows(elem6)("cCodto")
                                                            If lccodto6.Trim = "R" Then 'Nivel 1101010101
                                                                Dim dssup7 As New DataSet
                                                                Dim elem7 As Integer = 0
                                                                Dim fila7 As DataRow
                                                                Dim lccodcta7 As String
                                                                Dim lccodto7 As String
                                                                dssup7 = ecntamov.CuentaSuperior(lccodcta6.Trim)
                                                                For Each fila7 In dssup7.Tables(0).Rows
                                                                    lccodcta7 = dssup7.Tables(0).Rows(elem7)("cCodcta")
                                                                    lccodto7 = dssup7.Tables(0).Rows(elem7)("cCodto")
                                                                    If lccodto7.Trim = "R" Then 'Nivel 1101010101


                                                                    Else
                                                                        Me.LibroMayorDetallado1(lccodcta7)
                                                                        lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                                                                        lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                                                                        lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                                                                        lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))


                                                                        ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                                                                        ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                                                                        ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                                                                        ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos

                                                                    End If
                                                                    elem7 += 1
                                                                Next


                                                            Else
                                                                Me.LibroMayorDetallado1(lccodcta6)
                                                                lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                                                                lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                                                                lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                                                                lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))


                                                                ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                                                                ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                                                                ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                                                                ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos



                                                            End If
                                                            elem6 += 1
                                                        Next
                                                    Else
                                                        Me.LibroMayorDetallado1(lccodcta5)
                                                        lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                                                        lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                                                        lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                                                        lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))


                                                        ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                                                        ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                                                        ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                                                        ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos

                                                    End If
                                                    elem5 += 1
                                                Next

                                            Else
                                                Me.LibroMayorDetallado1(lccodcta4)
                                                lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                                                lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                                                lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                                                lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))

                                                ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                                                ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                                                ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                                                ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos



                                            End If
                                            elem4 += 1
                                        Next

                                    Else
                                        Me.LibroMayorDetallado1(lccodcta3)
                                        lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                                        lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                                        lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                                        lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))


                                        ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                                        ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                                        ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                                        ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos



                                    End If
                                    elem3 += 1
                                Next

                            Else
                                Me.LibroMayorDetallado1(lccodcta2)
                                lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                                lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                                lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                                lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))


                                ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                                ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                                ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                                ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos


                            End If
                            elem2 += 1
                        Next

                    Else
                        Me.LibroMayorDetallado1(lccodcta1)
                        lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nDebeac")), 0, ds.Tables(0).Rows(elem)("nDebeac"))
                        lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))
                        lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nCargos")), 0, ds.Tables(0).Rows(elem)("nCargos"))
                        lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nAbonos")), 0, ds.Tables(0).Rows(elem)("nAbonos"))


                        ds.Tables(0).Rows(elem)("nDebeac") = lndebeac + Me.pnDebeac
                        ds.Tables(0).Rows(elem)("nHaberac") = lnhaberac + Me.pnHabereac
                        ds.Tables(0).Rows(elem)("nCargos") = lncargos + Me.pnCargos
                        ds.Tables(0).Rows(elem)("nAbonos") = lnabonos + Me.pnAbonos


                    End If
                    elem1 += 1
                Next
            Else
                Me.LibroMayorDetallado1(lccodcta)
                ds.Tables(0).Rows(elem)("nDebeac") = Me.pnDebeac
                ds.Tables(0).Rows(elem)("nHaberac") = Me.pnHabereac
                ds.Tables(0).Rows(elem)("nCargos") = Me.pnCargos
                ds.Tables(0).Rows(elem)("nAbonos") = Me.pnAbonos


            End If
            elem += 1
        Next

        elem = 0
        For Each fila In ds.Tables(0).Rows
            lnsalini = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nsalini")), 0, ds.Tables(0).Rows(elem)("nsalini"))
            lndebeac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("ndebeac")), 0, ds.Tables(0).Rows(elem)("ndebeac"))
            lnhaberac = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nhaberac")), 0, ds.Tables(0).Rows(elem)("nhaberac"))

            lncargos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("ncargos")), 0, ds.Tables(0).Rows(elem)("ncargos"))
            lnabonos = IIf(IsDBNull(ds.Tables(0).Rows(elem)("nabonos")), 0, ds.Tables(0).Rows(elem)("nabonos"))

            lccodcta = ds.Tables(0).Rows(elem)("ccodcta")
            lccodcta = lccodcta.Trim
            If Left(lccodcta, 1) = "2" Or Left(lccodcta, 1) = "3" Or Left(lccodcta, 1) = "5" _
            Or Left(lccodcta, 1) = "7" Then
                ds.Tables(0).Rows(elem)("nsalini") = lnsalini + lnhaberac - lndebeac
                ds.Tables(0).Rows(elem)("nSalAct") = lnsalini + lnhaberac - lndebeac + lnabonos - lncargos
            Else
                ds.Tables(0).Rows(elem)("nsalini") = lnsalini - lnhaberac + lndebeac
                ds.Tables(0).Rows(elem)("nSalAct") = lnsalini - lnhaberac + lndebeac - lnabonos + lncargos
            End If
            If ds.Tables(0).Rows(elem)("nsalini") = 0 And _
                   ds.Tables(0).Rows(elem)("nsalact") = 0 And _
                  ds.Tables(0).Rows(elem)("ncargos") = 0 And _
                 ds.Tables(0).Rows(elem)("nabonos") = 0 Then

                ds.Tables(0).Rows(elem).Delete()
                ds.Tables(0).GetChanges(DataRowState.Deleted)
                reg = reg - 1
            End If
            elem += 1
        Next
        ds.Tables(0).AcceptChanges()

        Return ds
    End Function

    Public Function LibroMayorDetallado1(ByVal pcCodcta As String)
        Dim ecntamov1 As New SIM.BL.cCntamov
        Dim dsCtb1 As New DataSet
        Dim dateIni, dateFin As Date
        dateIni = Me.Fecha_Inicial(Me.dFecIni)
        dateFin = Me.Fecha_DiaAntes(Me.dFecIni)
        dsCtb1 = ecntamov1.ObtenerMov(dateIni, dateFin, Me.dFecIni, Me.dFecfin, pcCodcta)
        If dsCtb1.Tables(0).Rows.Count = 0 Then
            Me.pnDebeac = 0
            Me.pnHabereac = 0
            Me.pnCargos = 0
            Me.pnAbonos = 0

        Else
            Me.pnDebeac = IIf(IsDBNull(dsCtb1.Tables(0).Rows(0)("nDebeac")), 0, dsCtb1.Tables(0).Rows(0)("nDebeac"))
            Me.pnHabereac = IIf(IsDBNull(dsCtb1.Tables(0).Rows(0)("nHaberac")), 0, dsCtb1.Tables(0).Rows(0)("nHaberac"))
            Me.pnCargos = IIf(IsDBNull(dsCtb1.Tables(0).Rows(0)("nCargos")), 0, dsCtb1.Tables(0).Rows(0)("nCargos"))
            Me.pnAbonos = IIf(IsDBNull(dsCtb1.Tables(0).Rows(0)("nAbonos")), 0, dsCtb1.Tables(0).Rows(0)("nAbonos"))
        End If
    End Function

    'nueva forma de generar el balance, cargara saldos iniciales a la fecha solicitada
    '+ los movimientos menos los abonos del mes
    Public Function cadena(ByVal cfondo As String, ByVal cyears As String, ByVal cnomser As String) As String
        Dim ecntaprm As New cCntaprm
        Dim ds As New DataSet
        Dim lcyears As String
        Dim lcmesvig As String
        Dim ecreditos As New ccreditos
        Dim cierre As String
        Dim cnnstr1 As String
        Dim cnn1 As ConnectionState
        Dim cnnstr2 As String
        Dim cierre2 As String

        ds = ecntaprm.ObtenerfiscaltoClose(cfondo.Trim)
        lcmesvig = ds.Tables(0).Rows(0)("cmesvig")
        lcyears = Left(lcmesvig, 4)

        If lcyears.Trim = cyears.Trim Then
            cnnstr1 = ""
        Else
            If cfondo.Trim = "99" Then
                cierre = "D" & cyears.Trim
            Else
                cierre = "D" & cyears.Trim
            End If
            cnnstr1 = ecreditos.CadenaActual()
            cnnstr1 = cnnstr1.Replace("FUNDEA", cierre)
            'cnnstr1 = "server=" & cnomser & ";" & "database=" & cierre & ";" & "uid=sa ; pwd=SA2012$%"
        End If

        Return cnnstr1
    End Function
    Public Function GenBalance(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double
        Dim lntothaber As Double
        Dim lnsalantgas As Double
        Dim lnsalanting As Double

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer
        Dim lccadena As String
        lccadena = Me.cadena(Me.pcFuente, Me.pcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")
        Dim lnsalfin1 As Double


        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        listacatalogo = mctbmcta.ObtenerLista(Me.pcFuente, lccadena)


        i = 0
        'mayorisa todas las cuentas del catalogo

        For Each ectbmcta In listacatalogo
            lccodcta = listacatalogo(i).ccodcta.Trim
            lcdescrip = listacatalogo(i).cdescrip
            lccodto = listacatalogo(i).ccodto.Trim
            lcnivel = listacatalogo(i).cnivel
            lnsalini = listacatalogo(i).nsalini


            'obtiene saldo inicial antes de la fecha de inicio
            lnnivel = lccodcta.Length
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            Dim ldfec1 As Date
            Dim ldfec2 As Date

            If ldfecinicial = ldfecha1 Then
                lnsalfin1 = 0
            Else
                ldfec1 = ldfecinicial
                ldfec2 = ldfecha1
                lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            End If
            Me.pndebe = 0
            Me.pnhaber = 0
            calcula_saldos4(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            Me.pndebe = Math.Round(Me.pndebe, 2)
            Me.pnhaber = Math.Round(Me.pnhaber, 2)

            Me.pnsalini = lnsalini + lnsalfin1
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                Me.pnsalfin = Math.Round(lnsalini + lnsalfin1 + Me.pndebe - Me.pnhaber, 2)
            Else
                Me.pnsalfin = Math.Round(lnsalini + lnsalfin1 + (Me.pnhaber - Me.pndebe), 2)
            End If


            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            '            calcula_saldos(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser)

            'evalua si es balance general
            If lccodcta.Substring(0, 1) = "7" And lccodto = "D" And lctipo = "G" Then
                lngastos = lngastos + ((Me.pnsalini + Me.pndebe) - Me.pnhaber)
                lnsalantgas = lnsalantgas + Me.pnsalini
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If

            If lccodcta.Substring(0, 1) = "7" And lctipo = "G" Then
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If


            If lccodcta.Substring(0, 1) = "6" And lccodto = "D" And lctipo = "G" Then
                lningresos = lningresos + ((Me.pnsalini + Me.pnhaber) - Me.pndebe)
                lnsalanting = lnsalanting + Me.pnsalini
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If

            If lccodcta.Substring(0, 1) = "6" And lctipo = "G" Then
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If

            If lccodto = "D" Then
                lntotsalini = lntotsalini + Me.pnsalini
                lntotsalfin = lntotsalfin + Me.pnsalfin
                lntotdebe = lntotdebe + Me.pndebe
                lntothaber = lntothaber + Me.pnhaber
            End If


            drcatalogo = DT.NewRow
            drcatalogo("cCodcta") = lccodcta
            drcatalogo("cCodto") = lccodto
            drcatalogo("cDescrip") = lcdescrip
            drcatalogo("cnivel") = lcnivel
            drcatalogo("nsalini") = Me.pnsalini
            drcatalogo("nsalfin") = Me.pnsalfin
            drcatalogo("ndebe") = Me.pndebe
            drcatalogo("nhaber") = Me.pnhaber

            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Then
                drcatalogo("ctipo") = "1"
            ElseIf lccodcta.Substring(0, 1) = "2" Or lccodcta.Substring(0, 1) = "3" Or lccodcta.Substring(0, 1) = "4" Or lccodcta.Substring(0, 1) = "5" Or lccodcta.Substring(0, 1) = "6" Then
                drcatalogo("ctipo") = "2"
            Else
                drcatalogo("ctipo") = "3"
            End If


            If Me.pnsalini = 0 And Me.pnsalfin = 0 And Me.pndebe = 0 And Me.pnhaber = 0 Then
                If lctipo = "G" And lccodcta.Substring(0, 1) = "3" Then 'balance general
                    If lnnivel = 1 Then
                        DT.Rows.Add(drcatalogo)
                    Else
                        If lccodcta = "34" Or lccodcta = "341" Or lccodcta = "3410" Or lccodcta = "3410000" Or lccodcta = "3411" Or lccodcta = "3411000" Then
                            DT.Rows.Add(drcatalogo)
                        End If
                    End If
                End If
            Else
                DT.Rows.Add(drcatalogo)
            End If
            i = i + 1
        Next

        dsBal.Tables.Add(DT)

        If lctipo = "G" Then ' es balance general
            lnutilidad = lningresos - lngastos
            If lnutilidad > 0 Then
                lntothaber = lntothaber + lnutilidad
                lntotsalfin = lntotsalfin + lnutilidad
            ElseIf lnutilidad < 0 Then
                lntotdebe = lntotdebe + Math.Abs(lnutilidad)
                lntotsalfin = lntotsalfin - Math.Abs(lnutilidad)
            End If

            For Each dr In dsBal.Tables(0).Rows
                'UTILIDADDES
                lccodcta = dr("ccodcta").trim
                If lccodcta = "3" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad

                End If
                If lccodcta = "34" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "341" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "3410" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "3410000" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If


                'DEFICIT

                If lccodcta = "3" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") - Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "34" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "341" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "3411" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "3411000" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If


                If dr("nsalini") = 0 And dr("nsalfin") = 0 And dr("ndebe") = 0 And dr("nhaber") = 0 Then
                    'dr.Delete()
                    'dsBal.Tables(0).GetChanges(DataRowState.Deleted)
                End If


                If dr("ccodto") = "D" And (lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7") Then
                    Me.pnactivo = Me.pnactivo + Me.pnsalfin
                ElseIf dr("ccodto") = "D" And (lccodcta.Substring(0, 1) = "2" Or lccodcta.Substring(0, 1) = "3" Or lccodcta.Substring(0, 1) = "4" Or lccodcta.Substring(0, 1) = "5" Or lccodcta.Substring(0, 1) = "6") Then
                    Me.pnpasivo = Me.pnpasivo + Me.pnsalfin
                End If

            Next

            ' dsBal.Tables(0).AcceptChanges()

        End If

        Me.pnsalini = lntotsalini
        Me.pnsalfin = lntotsalfin
        Me.pndebe = lntotdebe
        Me.pnhaber = lntothaber

        Return dsBal


    End Function

    Public Function GenComprobacion(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double



        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        listacatalogo = mctbmcta.ObtenerLista(Me.pcFuente, lccadena)
        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        i = 0
        'mayorisa todas las cuentas del catalogo
        For Each ectbmcta In listacatalogo
            lccodcta = listacatalogo(i).ccodcta.Trim

            lcdescrip = listacatalogo(i).cdescrip
            lccodto = listacatalogo(i).ccodto.Trim
            lcnivel = listacatalogo(i).cnivel
            'lnsalini = listacatalogo(i).nsalini

            'obtiene saldo inicial antes de la fecha de inicio

            lnnivel = lccodcta.Length
            lnsalini = calcula_saldosiniciales(ldfecinicial, ldfecinicial, lccodcta, lnnivel, Me.pcnomser, lccadena)


            Dim ldfec1 As Date
            Dim ldfec2 As Date

            If ldfecinicial = ldfecha1 Then
                lnsalfin1 = 0
            Else
                ldfec1 = ldfecinicial
                ldfec2 = ldfecha1
                lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            End If
            Me.pndebe = 0
            Me.pnhaber = 0
            calcula_saldos4(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            Me.pndebe = Math.Round(Me.pndebe, 2)
            Me.pnhaber = Math.Round(Me.pnhaber, 2)


            drcatalogo = DT.NewRow
            drcatalogo("cCodcta") = lccodcta
            drcatalogo("cCodto") = lccodto
            drcatalogo("cDescrip") = lcdescrip
            drcatalogo("cnivel") = lcnivel
            drcatalogo("nsalini") = Math.Round(lnsalini + lnsalfin1, 2)
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + Me.pndebe - Me.pnhaber, 2)
            Else
                drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + (Me.pnhaber - Me.pndebe), 2)
            End If


            drcatalogo("ndebe") = Me.pndebe
            drcatalogo("nhaber") = Me.pnhaber

            If lctipo = "bc" Then
                If lnsalini = 0 And lnsalfin1 = 0 And Me.pndebe = 0 And Me.pnhaber = 0 Then
                Else
                    DT.Rows.Add(drcatalogo)
                End If
            Else
                DT.Rows.Add(drcatalogo)
            End If


            i = i + 1
        Next

        dsBal.Tables.Add(DT)

        Dim mcntamov As New cCntamov
        Dim dstotales As New DataSet
        dstotales = mcntamov.ObtenerSaldosPorCuenta5(ldfecha1, ldfecha2, Me.pcnomser, Me.pcCodofi, Me.pcFuente)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lndebe As Double
        Dim lnhaber As Double

        For Each fila In dstotales.Tables(0).Rows
            If IsDBNull(dstotales.Tables(0).Rows(ele)("ndebe")) Then
                dstotales.Tables(0).Rows(ele)("ndebe") = 0
            End If
            If IsDBNull(dstotales.Tables(0).Rows(ele)("nhaber")) Then
                dstotales.Tables(0).Rows(ele)("nhaber") = 0
            End If
            lndebe = Math.Round(dstotales.Tables(0).Rows(ele)("ndebe"), 2)
            lnhaber = Math.Round(dstotales.Tables(0).Rows(ele)("nhaber"), 2)
            Me.pnDebeac = Me.pnDebeac + lndebe
            Me.pnHabereac = Me.pnHabereac + lnhaber
            ele += 1
        Next

        Me.pnsalini = lntotsalini
        Me.pnsalfin = lntotsalfin
        Me.pndebe = Math.Round(Me.pnDebeac, 2)
        Me.pnhaber = Math.Round(Me.pnHabereac, 2)

        Return dsBal

    End Function

    Public Function GenBalance1(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double
        Dim lntothaber As Double
        Dim lnsalantgas As Double
        Dim lnsalanting As Double

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0


        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        listacatalogo = mctbmcta.ObtenerLista1(Me.pcFuente)

        i = 0
        'mayorisa todas las cuentas del catalogo
        For Each ectbmcta In listacatalogo
            lccodcta = listacatalogo(i).ccodcta.Trim
            lcdescrip = listacatalogo(i).cdescrip
            lccodto = listacatalogo(i).ccodto.Trim
            lcnivel = listacatalogo(i).cnivel
            'obtiene saldo inicial antes de la fecha de inicio
            lnnivel = lccodcta.Length
            calcula_saldos1(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser)
            Me.pnsalini = 0
            'evalua si es balance general
            If lccodcta.Substring(0, 1) = "7" And lccodto = "D" And lctipo = "G" Then
                lngastos = lngastos + ((Me.pnsalini + Me.pndebe) - Me.pnhaber)
                lnsalantgas = lnsalantgas + Me.pnsalini
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If

            If lccodcta.Substring(0, 1) = "7" And lctipo = "G" Then
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If


            If lccodcta.Substring(0, 1) = "6" And lccodto = "D" And lctipo = "G" Then
                lningresos = lningresos + ((Me.pnsalini + Me.pnhaber) - Me.pndebe)
                lnsalanting = lnsalanting + Me.pnsalini
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If

            If lccodcta.Substring(0, 1) = "6" And lctipo = "G" Then
                Me.pnsalini = 0
                Me.pndebe = 0
                Me.pnhaber = 0
                Me.pnsalfin = 0
            End If

            If lccodto = "D" Then
                lntotsalini = lntotsalini + Me.pnsalini
                lntotsalfin = lntotsalfin + Me.pnsalfin
                lntotdebe = lntotdebe + Me.pndebe
                lntothaber = lntothaber + Me.pnhaber
            End If


            drcatalogo = DT.NewRow
            drcatalogo("cCodcta") = lccodcta
            drcatalogo("cCodto") = lccodto
            drcatalogo("cDescrip") = lcdescrip
            drcatalogo("cnivel") = lcnivel
            drcatalogo("nsalini") = Me.pnsalini
            drcatalogo("nsalfin") = Me.pnsalfin
            drcatalogo("ndebe") = Me.pndebe
            drcatalogo("nhaber") = Me.pnhaber

            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                drcatalogo("ctipo") = "1"
            ElseIf lccodcta.Substring(0, 1) = "2" Or lccodcta.Substring(0, 1) = "3" Or lccodcta.Substring(0, 1) = "4" Or lccodcta.Substring(0, 1) = "5" Or lccodcta.Substring(0, 1) = "6" Then
                drcatalogo("ctipo") = "2"
            Else
                drcatalogo("ctipo") = "3"
            End If


            If Me.pnsalini = 0 And Me.pnsalfin = 0 And Me.pndebe = 0 And Me.pnhaber = 0 Then
                If lctipo = "G" And lccodcta.Substring(0, 1) = "3" Then 'balance general
                    If lnnivel = 1 Then
                        DT.Rows.Add(drcatalogo)
                    Else
                        If lccodcta = "31" Or lccodcta = "3106" Or lccodcta = "310601" Or lccodcta = "31060101" Or lccodcta = "3107" Or lccodcta = "310701" Or lccodcta = "31070101" Then
                            DT.Rows.Add(drcatalogo)
                        End If
                    End If
                End If
            Else
                DT.Rows.Add(drcatalogo)
            End If
            i = i + 1
        Next

        dsBal.Tables.Add(DT)

        If lctipo = "G" Then ' es balance general
            lnutilidad = lningresos - lngastos
            If lnutilidad > 0 Then
                lntothaber = lntothaber + lnutilidad
                lntotsalfin = lntotsalfin + lnutilidad
            ElseIf lnutilidad < 0 Then
                lntotdebe = lntotdebe + Math.Abs(lnutilidad)
                lntotsalfin = lntotsalfin - Math.Abs(lnutilidad)
            End If

            For Each dr In dsBal.Tables(0).Rows
                'UTILIDADDES
                lccodcta = dr("ccodcta").trim
                If lccodcta = "3" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "31" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "3106" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "310601" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If
                If lccodcta = "31060101" And lnutilidad > 0 Then
                    dr("nhaber") = dr("nhaber") + lnutilidad
                    dr("nsalfin") = dr("nsalfin") + lnutilidad
                End If

                'DEFICIT

                If lccodcta = "3" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") - Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "31" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "3107" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "310701" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If
                If lccodcta = "31070101" And lnutilidad < 0 Then
                    dr("ndebe") = dr("ndebe") + Math.Abs(lnutilidad)
                    dr("nsalfin") = dr("nsalfin") - Math.Abs(lnutilidad)
                End If

                If dr("nsalini") = 0 And dr("nsalfin") = 0 And dr("ndebe") = 0 And dr("nhaber") = 0 Then
                    'dr.Delete()
                    'dsBal.Tables(0).GetChanges(DataRowState.Deleted)
                End If


                If dr("ccodto") = "D" And (lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9") Then
                    Me.pnactivo = Me.pnactivo + Me.pnsalfin
                ElseIf dr("ccodto") = "D" And (lccodcta.Substring(0, 1) = "2" Or lccodcta.Substring(0, 1) = "3" Or lccodcta.Substring(0, 1) = "4" Or lccodcta.Substring(0, 1) = "5" Or lccodcta.Substring(0, 1) = "6") Then
                    Me.pnpasivo = Me.pnpasivo + Me.pnsalfin
                End If

            Next

            ' dsBal.Tables(0).AcceptChanges()

        End If

        Me.pnsalini = lntotsalini
        Me.pnsalfin = lntotsalfin
        Me.pndebe = lntotdebe
        Me.pnhaber = lntothaber

        Return dsBal

    End Function



    Public Function estado_resultados(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim mcntamov As New cCntamov
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double
        Dim lntothaber As Double
        Dim lnsalantgas As Double
        Dim lnsalanting As Double
        Dim dsres As New DataSet
        Me.pnutilidad = 0

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0

        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, cnumcom, cnumdoc, dfeccnt, ndebe, nhaber, nsalini, nsalfin, ctipo,"
        lTipos1 = "S,S,S,S,S,S,F,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        dsres = GenBalance(ldfecha1, ldfecha2, "C")

        For Each dr In dsres.Tables(0).Rows
            lccodcta = dr("ccodcta").trim
            If Left(lccodcta, 1) = "5" Or Left(lccodcta, 1) = "4" Then
                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = dr("ccodcta")
                drcatalogo("cCodto") = dr("ccodto").trim
                drcatalogo("cDescrip") = dr("cdescrip").trim
                drcatalogo("cnivel") = dr("cnivel").trim
                drcatalogo("nsalini") = dr("nsalini")
                drcatalogo("nsalfin") = dr("nsalfin")
                drcatalogo("ndebe") = dr("ndebe")
                drcatalogo("nhaber") = dr("nhaber")
                If Left(lccodcta, 1) = "5" Then
                    drcatalogo("ctipo") = "1"
                Else
                    drcatalogo("ctipo") = "2"
                End If

                If Left(lccodcta, 1) = "5" And drcatalogo("cCodto") = "D" Then
                    lningresos = lningresos + dr("nsalfin")
                End If
                If Left(lccodcta, 1) = "4" And drcatalogo("cCodto") = "D" Then
                    lngastos = lngastos + dr("nsalfin")
                End If
                DT.Rows.Add(drcatalogo)
            End If
        Next
        Me.pnutilidad = lningresos - lngastos
        Me.pningresos = lningresos
        Me.pngastos = lngastos
        dsBal.Tables.Add(DT)
        Return dsBal

    End Function

    Public Function estado_resultados1(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim mcntamov As New cCntamov
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double
        Dim lntothaber As Double
        Dim lnsalantgas As Double
        Dim lnsalanting As Double
        Dim dsres As New DataSet
        Me.pnutilidad = 0

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0

        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, cnumcom, cnumdoc, dfeccnt, ndebe, nhaber, nsalini, nsalfin, ctipo,"
        lTipos1 = "S,S,S,S,S,S,F,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        dsres = GenBalance1(ldfecha1, ldfecha2, "C")

        For Each dr In dsres.Tables(0).Rows
            lccodcta = dr("ccodcta").trim
            If Left(lccodcta, 1) = "5" Or Left(lccodcta, 1) = "4" Then
                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = dr("ccodcta")
                drcatalogo("cCodto") = dr("ccodto").trim
                drcatalogo("cDescrip") = dr("cdescrip").trim
                drcatalogo("cnivel") = dr("cnivel").trim
                drcatalogo("nsalini") = dr("nsalini")
                drcatalogo("nsalfin") = dr("nsalfin")
                drcatalogo("ndebe") = dr("ndebe")
                drcatalogo("nhaber") = dr("nhaber")
                If Left(lccodcta, 1) = "5" Then
                    drcatalogo("ctipo") = "1"
                Else
                    drcatalogo("ctipo") = "2"
                End If

                If Left(lccodcta, 1) = "5" And drcatalogo("cCodto") = "D" Then
                    lningresos = lningresos + dr("nsalfin")
                End If
                If Left(lccodcta, 1) = "4" And drcatalogo("cCodto") = "D" Then
                    lngastos = lngastos + dr("nsalfin")
                End If
                DT.Rows.Add(drcatalogo)
            End If
        Next
        Me.pnutilidad = lningresos - lngastos
        Me.pningresos = lningresos
        Me.pngastos = lngastos
        dsBal.Tables.Add(DT)
        Return dsBal

    End Function
    Public Function estado_resultados2(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date) As DataSet
        Dim mctbmcta As New cCtbmcta
        Dim ds As New DataSet
        Dim ldfechasta As Date
        ldfechasta = ldfecha2
        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm

        Dim ds1 As New DataSet
        Dim ncanti As Integer
        Dim lcmesvig As String

        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta


        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = eCntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If



        Dim ldfecinicial As Date
        Dim ldfecfinal As Date

        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")
        Dim ldfechaa As Date


        ds = mctbmcta.ObtenerDataSetEstado(Me.pcFuente)
        Dim nctas As Integer
        nctas = ds.Tables(0).Rows.Count

        Dim fila As DataRow
        Dim ele As Integer
        Dim lccodcta As String
        Dim lcnivel As String

        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim mcntamov As New cCntamov
        Dim lcnomser As String
        Dim lndebe, lnhaber As Double
        'Dim lningresos As Double = 0
        ' Dim lnegresos As Double = 0
        Dim lning1, lning2, lning3, lning4, lning5, lning6, lning7, lning8, lning9, lning10, lning11, lning12 As Double
        Dim lnegr1, lnegr2, lnegr3, lnegr4, lnegr5, lnegr6, lnegr7, lnegr8, lnegr9, lnegr10, lnegr11, lnegr12 As Double

        Dim DR As DataRow

        DR = ds.Tables(0).NewRow
        DR("cdescrip") = "UTILIDAD (PERDIDA) DEL PERIODO"
        DR("ccodcta") = ""
        DR("cnivel") = "99"
        DR("acumulado") = 0
        DR("nsalini") = 0
        DR("Enero") = 0
        DR("febrero") = 0
        DR("marzo") = 0
        DR("abril") = 0
        DR("mayo") = 0
        DR("junio") = 0
        DR("julio") = 0
        DR("agosto") = 0
        DR("septiembre") = 0
        DR("octubre") = 0
        DR("noviembre") = 0
        DR("diciembre") = 0
        ds.Tables(0).Rows.Add(DR)

        Dim filax As DataRow
        Dim elex As Integer = 0

        Dim ds2 As New DataSet
        'ObtenerCntaprm
        lcnomser = Me.pcnomser
        For Each fila In ds.Tables(0).Rows
            lnsalfin = 0
            lccodcta = ds.Tables(0).Rows(ele)("ccodcta")
            lccodcta = lccodcta.Trim
            lcnivel = ds.Tables(0).Rows(ele)("cnivel")

            Dim i As Integer = 0
            For i = 1 To 12
                lnsalfin = 0
                If i = 1 Then

                    ldfecha1 = ldfecinicial
                    ldfecha2 = ldfecinicial.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Enero") = lning1 - lnegr1

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0

                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Enero") = lnsalfin

                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning1 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr1 = lnsalfin
                        End If




                    End If
                ElseIf i = 2 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("febrero") = lning2 - lnegr2

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)


                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else
                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0

                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If
                        End If
                        ds.Tables(0).Rows(ele)("Febrero") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning2 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr2 = lnsalfin
                        End If

                    End If
                ElseIf i = 3 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Marzo") = lning3 - lnegr3

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else
                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Marzo") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning3 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr3 = lnsalfin
                        End If
                    End If
                ElseIf i = 4 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Abril") = lning4 - lnegr4

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)

                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else


                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Abril") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning4 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr4 = lnsalfin
                        End If
                    End If
                ElseIf i = 5 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Mayo") = lning5 - lnegr5

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)

                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Mayo") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning5 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr5 = lnsalfin
                        End If
                    End If
                ElseIf i = 6 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Junio") = lning6 - lnegr6

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Junio") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning6 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr6 = lnsalfin
                        End If
                    End If
                ElseIf i = 7 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Julio") = lning7 - lnegr7

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Julio") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning7 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr7 = lnsalfin
                        End If
                    End If
                ElseIf i = 8 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Agosto") = lning8 - lnegr8

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Agosto") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning8 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr8 = lnsalfin
                        End If
                    End If
                ElseIf i = 9 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Septiembre") = lning9 - lnegr9

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Septiembre") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning9 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr9 = lnsalfin
                        End If
                    End If
                ElseIf i = 10 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Octubre") = lning10 - lnegr10

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)

                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else
                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Octubre") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning10 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr10 = lnsalfin
                        End If
                    End If
                ElseIf i = 11 Then
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Noviembre") = lning11 - lnegr11

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Noviembre") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning11 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr11 = lnsalfin
                        End If
                    End If
                Else
                    ldfecha1 = ldfecha2.AddDays(1)
                    ldfecha2 = ldfecha1.AddMonths(1).AddDays(-1)
                    If ldfechasta < ldfecha2 Then
                        Exit For
                    End If
                    If lccodcta = "" Then
                        ds.Tables(0).Rows(ele)("Diciembre") = lning12 - lnegr12

                    Else
                        ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, lccodcta, lcnivel, lcnomser, Me.pcCodofi, Me.pcFuente)
                        If ds2.Tables(0).Rows.Count = 0 Then
                            lnsalfin = 0
                        Else

                            lnsalini = 0 'ds2.Tables(0).Rows(0)("nsalini")
                            lndebe = 0
                            lnhaber = 0
                            For Each filax In ds2.Tables(0).Rows
                                lndebe = lndebe + ds2.Tables(0).Rows(elex)("ndebe")
                                lnhaber = lnhaber + ds2.Tables(0).Rows(elex)("nhaber")
                                elex += 1
                            Next
                            elex = 0
                            If lccodcta.Substring(0, 1) = "6" Then
                                lnsalfin = lnhaber - lndebe
                            Else
                                lnsalfin = lndebe - lnhaber
                            End If

                        End If
                        ds.Tables(0).Rows(ele)("Diciembre") = lnsalfin
                        If lccodcta.Trim = "6" And lcnivel = "01" Then
                            lning12 = lnsalfin
                        End If
                        If lccodcta.Trim = "7" And lcnivel = "01" Then
                            lnegr12 = lnsalfin
                        End If
                    End If
                End If

            Next
            ele += 1
        Next

        Return ds
    End Function

    'calcula los saldos y verifca que año fiscal se esta trabajando
    Sub calcula_saldos(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String)

        Dim mcntamov As New cCntamov
        Dim ldfecha As Date
        Dim ds As New DataSet
        Dim lnsalini As Double
        Dim lnsalfin1 As Double

        Me.pnsalini = 0
        Me.pnsalfin = 0
        Me.pndebe = 0
        Me.pnhaber = 0

        If ldfecha1.Day <> 1 And ldfecha1.Month <> 1 Then
            ldfecha = ldfecha1.AddDays(-1)
        Else
            ldfecha = ldfecha1
        End If
        lcnomser = Me.pcnomser

        ds = mcntamov.ObtenerSaldosPorCuenta("01/01/1970", ldfecha, lccodcta, lnnivel, lcnomser, Me.pcCodofi, Me.pcFuente)

        If IsDBNull(ds.Tables(0).Rows(0)("nsalini")) Then
            ds.Tables(0).Rows(0)("nsalini") = 0
        End If

        If IsDBNull(ds.Tables(0).Rows(0)("ndebe")) Then
            ds.Tables(0).Rows(0)("ndebe") = 0
        End If

        If IsDBNull(ds.Tables(0).Rows(0)("nhaber")) Then
            ds.Tables(0).Rows(0)("nhaber") = 0
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "9" Then
                Me.pnsalini = (ds.Tables(0).Rows(0)("nsalini") + ds.Tables(0).Rows(0)("nDebe")) - ds.Tables(0).Rows(0)("nHaber")
            Else
                Me.pnsalini = (ds.Tables(0).Rows(0)("nsalini") + ds.Tables(0).Rows(0)("nhaber")) - ds.Tables(0).Rows(0)("ndebe")
            End If
        End If
        ds.Tables.Clear()
        'saldo final
        ds = mcntamov.ObtenerSaldosPorCuenta(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, Me.pcCodofi, Me.pcFuente)

        If IsDBNull(ds.Tables(0).Rows(0)("nsalini")) Then
            ds.Tables(0).Rows(0)("nsalini") = 0
        End If

        If IsDBNull(ds.Tables(0).Rows(0)("ndebe")) Then
            ds.Tables(0).Rows(0)("ndebe") = 0
        End If

        If IsDBNull(ds.Tables(0).Rows(0)("nhaber")) Then
            ds.Tables(0).Rows(0)("nhaber") = 0
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            Me.pndebe = ds.Tables(0).Rows(0)("ndebe")
            Me.pnhaber = ds.Tables(0).Rows(0)("nhaber")
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "9" Then
                Me.pnsalfin = (Me.pnsalini + ds.Tables(0).Rows(0)("ndebe")) - ds.Tables(0).Rows(0)("nhaber")
            Else
                Me.pnsalfin = (Me.pnsalini + ds.Tables(0).Rows(0)("nhaber")) - ds.Tables(0).Rows(0)("ndebe")
            End If
        End If


    End Sub

    Sub calcula_saldos1(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String)

        Dim mcntamov As New cCntamov
        Dim ldfecha As Date
        Dim ds As New DataSet
        Dim lnsalini As Double
        Dim lnsalfin1 As Double

        Me.pnsalini = 0
        Me.pnsalfin = 0
        Me.pndebe = 0
        Me.pnhaber = 0

        If ldfecha1.Day <> 1 And ldfecha1.Month <> 1 Then
            ldfecha = ldfecha1.AddDays(-1)
        Else
            ldfecha = ldfecha1
        End If
        lcnomser = Me.pcnomser


        ds = mcntamov.ObtenerSaldosPorCuenta(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, Me.pcCodofi, Me.pcFuente)

        If IsDBNull(ds.Tables(0).Rows(0)("nsalini")) Then
            ds.Tables(0).Rows(0)("nsalini") = 0
        End If

        If IsDBNull(ds.Tables(0).Rows(0)("ndebe")) Then
            ds.Tables(0).Rows(0)("ndebe") = 0
        End If

        If IsDBNull(ds.Tables(0).Rows(0)("nhaber")) Then
            ds.Tables(0).Rows(0)("nhaber") = 0
        End If

        If ds.Tables(0).Rows.Count > 0 Then
            Me.pndebe = ds.Tables(0).Rows(0)("ndebe")
            Me.pnhaber = ds.Tables(0).Rows(0)("nhaber")
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "9" Then
                Me.pnsalfin = (Me.pnsalini + ds.Tables(0).Rows(0)("ndebe")) - ds.Tables(0).Rows(0)("nhaber")
            Else
                Me.pnsalfin = (Me.pnsalini + ds.Tables(0).Rows(0)("nhaber")) - ds.Tables(0).Rows(0)("ndebe")
            End If
        End If


    End Sub
    Public Function calcula_saldos3(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccadena As String) As Double

        Dim mcntamov As New cCntamov
        Dim ldfecha As Date
        Dim ds As New DataSet
        Dim lnsalini As Double = 0
        Dim lnsalfin1 As Double = 0

        Dim lndebeant As Double = 0
        Dim lnhaberant As Double = 0

        Me.pnsalini = 0
        Me.pnsalfin = 0
        Me.pndebe = 0
        Me.pnhaber = 0

        If ldfecha1.Day <> 1 And ldfecha1.Month <> 1 Then
            ldfecha = ldfecha1.AddDays(-1)
        Else
            ldfecha = ldfecha1
        End If
        lcnomser = Me.pcnomser


        ds = mcntamov.ObtenerSaldosPorCuenta3(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, Me.pcCodofi, Me.pcFuente, lccadena, Me.pccierre)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim elex As Integer = 0
            Dim filax As DataRow
            Dim lndebex As Double = 0
            Dim lnhaberx As Double = 0

            For Each filax In ds.Tables(0).Rows
                If IsDBNull(ds.Tables(0).Rows(elex)("ndebe")) Then
                    ds.Tables(0).Rows(elex)("ndebe") = 0
                End If
                If IsDBNull(ds.Tables(0).Rows(elex)("nhaber")) Then
                    ds.Tables(0).Rows(elex)("nhaber") = 0
                End If
                lndebex = Math.Round(ds.Tables(0).Rows(elex)("ndebe"), 2)
                lnhaberx = Math.Round(ds.Tables(0).Rows(elex)("nhaber"), 2)
                lndebeant = lndebeant + lndebex
                lnhaberant = lnhaberant + lnhaberx
                elex += 1
            Next

            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                lnsalfin1 = Math.Round(lndebeant - lnhaberant, 2)
            Else
                lnsalfin1 = Math.Round(lnhaberant - lndebeant, 2)
            End If
        End If
        Return lnsalfin1

    End Function
    Public Function calcula_saldos4(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccadena As String)

        Dim mcntamov As New cCntamov
        Dim ldfecha As Date
        Dim ds As New DataSet
        Dim lnsalini As Double
        Dim lnsalfin1 As Double

        Dim lndebeant As Double = 0
        Dim lnhaberant As Double = 0

        Me.pnsalini = 0
        Me.pnsalfin = 0
        Me.pndebe = 0
        Me.pnhaber = 0

        If ldfecha1.Day <> 1 And ldfecha1.Month <> 1 Then
            ldfecha = ldfecha1.AddDays(-1)
        Else
            ldfecha = ldfecha1
        End If
        lcnomser = Me.pcnomser


        ds = mcntamov.ObtenerSaldosPorCuenta4(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, Me.pcCodofi, Me.pcFuente, lccadena, Me.pccierre)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim elex As Integer = 0
            Dim filax As DataRow
            Dim lndebex As Double = 0
            Dim lnhaberx As Double = 0

            For Each filax In ds.Tables(0).Rows
                If IsDBNull(ds.Tables(0).Rows(elex)("ndebe")) Then
                    ds.Tables(0).Rows(elex)("ndebe") = 0
                End If
                If IsDBNull(ds.Tables(0).Rows(elex)("nhaber")) Then
                    ds.Tables(0).Rows(elex)("nhaber") = 0
                End If
                lndebex = Math.Round(ds.Tables(0).Rows(elex)("ndebe"), 2)
                lnhaberx = Math.Round(ds.Tables(0).Rows(elex)("nhaber"), 2)
                Me.pndebe = Me.pndebe + lndebex
                Me.pnhaber = Me.pnhaber + lnhaberx
                elex += 1
            Next

        End If

    End Function
    Public Function Resultado_Ejercicio() As Double
        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal
        Dim mlistacntabal As listacntabal
        mlistacntabal = ecntabal.ObtenerListaPorIDRes
        Dim lcCodCta As String
        Dim lnSalFin, lnSalIng, lnSalGas, lnResEje As Double
        Dim i As Integer
        i = 0
        lnSalIng = 0
        lnSalGas = 0
        For Each entidadcntabal In mlistacntabal
            lcCodCta = mlistacntabal(i).ccodcta
            lnSalFin = mlistacntabal(i).nsalfin
            If lcCodCta.Trim = "6" Then 'Ingreso
                lnSalIng = lnSalFin
            End If
            If lcCodCta.Trim = "7" Or lcCodCta.Trim = "8" Then 'Gasto
                lnSalGas = lnSalGas + lnSalFin
            End If
            i = i + 1
        Next
        lnResEje = lnSalIng - lnSalGas
        Return lnResEje
    End Function

    Public Function Fecha(ByVal dFecha As Date) As String
        Dim lcFecha As String
        Dim lcFecLar, lcMesLet As String
        Dim lcDia, lcMes, lcAño As String

        lcFecha = dFecha.ToString
        lcDia = lcFecha.Substring(0, 2)
        lcMes = lcFecha.Substring(3, 2)
        lcAño = lcFecha.Substring(6, 4)

        If lcMes = "01" Then
            lcMesLet = " ENERO "
        ElseIf lcMes = "02" Then
            lcMesLet = " FEBRERO "
        ElseIf lcMes = "03" Then
            lcMesLet = " MARZO "
        ElseIf lcMes = "04" Then
            lcMesLet = " ABRIL "
        ElseIf lcMes = "05" Then
            lcMesLet = " MAYO "
        ElseIf lcMes = "06" Then
            lcMesLet = " JUNIO "
        ElseIf lcMes = "07" Then
            lcMesLet = " JULIO "
        ElseIf lcMes = "08" Then
            lcMesLet = " AGOSTO "
        ElseIf lcMes = "09" Then
            lcMesLet = " SEPTIEMBRE "
        ElseIf lcMes = "10" Then
            lcMesLet = " OCTUBRE "
        ElseIf lcMes = "11" Then
            lcMesLet = " NOVIEMBRE "
        ElseIf lcMes = "12" Then
            lcMesLet = " DICIEMBRE "
        End If
        lcFecLar = "AL " + lcDia + " DE " + lcMesLet + " DE " + lcAño
        Return lcFecLar
    End Function
    Public Function GenResultado() As DataSet
        Dim claseppal As New class1

        Dim entidadcntabal As New SIM.EL.cntabal
        Dim ecntabal As New SIM.BL.cCntabal
        Dim i As Integer
        i = 0

        Dim mlistacntabal As listacntabal
        mlistacntabal = ecntabal.ObtenerListaPorIDRes
        Dim lcCodCta As String
        Dim lcCtaSup As String
        Dim lcCodto As String
        Dim lnsalfin As Double
        Dim lcnivel As String
        Dim lcdescrip As String
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dsRes As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim lcnivelS As String
        Dim lcFecLet As String
        dsRes.Clear()
        lCampos1 = "cCodCta, cDescrip, cCodto, nNivel01, nnivel02, nnivel03, nnivel04, nnivel05, nnivel06, cFecha, cNivel02,cNivel03,cNivel04,cNivel05,cNivel06,"
        lTipos1 = "S,S,S,D,D,D,D,D,D,S,S,S,S,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "Resultado")
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        lcFecLet = Me.Fecha(Me.dFecfin)
        Dim lnIng, lnGas As Double
        Dim lnFlag As Integer
        Dim lcCamCta As String
        lcCamCta = "6"
        lnFlag = 0
        lnIng = 0
        lnGas = 0
        For Each entidadcntabal In mlistacntabal
            lcCodCta = mlistacntabal(i).ccodcta
            lnsalfin = mlistacntabal(i).nsalfin
            lcCodto = mlistacntabal(i).ccodto
            lcnivel = mlistacntabal(i).cnivel
            lcCtaSup = mlistacntabal(i).ccodbal
            lcdescrip = mlistacntabal(i).cdescrip
            lcnivelS = claseppal.fxStrZero(lcCtaSup.Trim.Length, 2).ToString
            If lnsalfin <> 0 Then
                'Asigna Total de Ingresos
                If lcCodCta.Trim = "6" Then
                    lnIng = lnsalfin
                End If
                'Break Ingreso
                If Left(lcCodCta.Trim, 1) <> lcCamCta Then
                    If lcCamCta = "6" Then
                        DR = DT.NewRow
                        DR("cCodcta") = ""
                        DR("cCodto") = ""
                        DR("cDescrip") = "TOTAL DE INGRESOS"
                        DR("cNivel02") = "TOTAL DE INGRESOS"
                        DR("nNivel02") = lnIng
                        DR("cFecha") = lcFecLet
                        DT.Rows.Add(DR)
                        lnFlag = lnFlag + 1
                    End If
                End If

                'Break Gastos
                If lcCodCta.Trim = "7" Or lcCodCta.Trim = "8" Then
                    lnGas = lnGas + lnsalfin
                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                DR = DT.NewRow
                DR("cCodcta") = lcCodCta
                DR("cCodto") = lcCodto
                DR("cDescrip") = lcdescrip
                DR("cFecha") = lcFecLet
                If lcCodto = "P" Then
                    DR("nNivel01") = lnsalfin
                ElseIf lcCodto = "D" Then
                    DR("nNivel06") = lnsalfin
                    DR("cNivel06") = lcdescrip
                Else
                    If lcnivelS = "01" Then
                        DR("nNivel02") = lnsalfin
                        DR("cNivel02") = lcdescrip
                    ElseIf lcnivelS = "02" Then
                        DR("nNivel03") = lnsalfin
                        DR("cNivel03") = lcdescrip
                    ElseIf lcnivelS = "03" Then
                        DR("nNivel04") = lnsalfin
                        DR("cNivel04") = lcdescrip
                    ElseIf lcnivelS = "05" Then
                        DR("nnivel05") = lnsalfin
                        DR("cNivel05") = lcdescrip
                    End If
                End If
                DT.Rows.Add(DR)
                lcCamCta = Left(lcCodCta.Trim, 1)
            End If
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            i = i + 1
        Next
        If lnFlag = 0 Then
            DR = DT.NewRow
            DR("cCodcta") = ""
            DR("cFecha") = lcFecLet
            DR("cCodto") = ""
            DR("cDescrip") = "TOTAL DE INGRESOS"
            DR("nNivel02") = lnIng
            DR("cNivel02") = "TOTAL DE INGRESOS"
            DT.Rows.Add(DR)
        End If
        'Agregar Total Pasivo y Patrimonio y Resultado de Ejercicio
        Dim lnResEje As Double
        lnResEje = Me.Resultado_Ejercicio()
        '-----------------
        DR = DT.NewRow
        DR("cCodcta") = ""
        DR("cFecha") = lcFecLet
        DR("cCodto") = ""
        DR("cDescrip") = "TOTAL DE EGRESOS"
        DR("nNivel02") = lnGas
        DR("cNivel02") = "TOTAL DE EGRESOS"
        DT.Rows.Add(DR)

        '------------------
        DR = DT.NewRow
        DR("cCodcta") = ""
        DR("cFecha") = lcFecLet
        DR("cCodto") = ""
        DR("cDescrip") = "RESULTADO DEL EJERCICIO"
        DR("nNivel02") = lnResEje
        DR("cNivel02") = "RESULTADO DEL EJERCICIO"
        DT.Rows.Add(DR)
        '-------------------
        dsRes.Tables.Add(DT)

        Return dsRes
    End Function
    Public Function ConsMov() As DataSet
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        Dim dsctbcls As New DataSet
        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String



        lcyears = Me.pcyears
        lccadena = Me.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        dsctbcls = ecntamov.ObtenerlistaConsCtas(Me.dFecIni, Me.dFecfin, Me.pcFuente, lccadena)
        Return dsctbcls
    End Function

    Public Function Fecha_Inicial(ByVal dfecha As Date) As Date 'Obtiene Fecha Inicial del Periodo
        Dim lcdia As String
        Dim lcMes As String
        Dim lcaño As String
        Dim lnaño As Integer
        Dim ldFechaIni As Date
        Dim lcFecha As String
        lcFecha = dfecha.ToString.Trim
        lcdia = Left(lcFecha, 2)
        lcMes = (lcFecha).Substring(3, 2)
        lcaño = (lcFecha).Substring(6, 4)
        If lcdia = "01" Then
            If lcMes = "01" Then
                lnaño = Val(lcaño) - 1
                lcaño = lnaño.ToString
            End If
        End If

        ldFechaIni = CDate("01/01/" & lcaño)
        Return ldFechaIni
    End Function
    Public Function Fecha_DiaAntes(ByVal dFecha As Date) As Date
        Dim ldFechaDiaAnt As Date
        ldFechaDiaAnt = dFecha.AddDays(-1)
        Return ldFechaDiaAnt
    End Function
    Public Function Librodiariomayor() As DataSet
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        Dim dsCtb As New DataSet
        dsCtb = ecntamov.ObtenerLibroDiarioMayor(Me.dFecIni, Me.dFecfin)
        Dim nelem As Integer
        nelem = dsCtb.Tables(0).Rows.Count
        If nelem = 0 Then

        End If
        nelem = 0
        Dim fila As DataRow
        Dim lcCodCta, lccodCta1 As String
        Dim lnSalAnt As Double
        Dim lnSalAcu As Double
        Dim lnSalAcu1 As Double = 0
        Dim lnSaldo As Double = 0
        Dim lnDebe, lnHaber As Double
        lccodCta1 = dsCtb.Tables(0).Rows(nelem)("cCodCta")
        For Each fila In dsCtb.Tables(0).Rows    'Saldos de Cuentas Hijas

            lcCodCta = dsCtb.Tables(0).Rows(nelem)("cCodCta")
            lnSalAcu = 0
            If lcCodCta = lccodCta1 Then
            Else
                lnSalAcu1 = 0
            End If
            lnSalAnt = Me.SaldoInicial(lcCodCta.Trim)
            dsCtb.Tables(0).Rows(nelem)("nSalAnt") = lnSalAnt
            lnSaldo = lnSalAnt
            lnDebe = dsCtb.Tables(0).Rows(nelem)("nDebe")
            lnHaber = dsCtb.Tables(0).Rows(nelem)("nHaber")

            If Left(lcCodCta, 1) = "1" Or _
                               Left(lcCodCta, 1) = "5" Or Left(lcCodCta, 1) = "7" Or Left(lcCodCta, 1) = "8" Or _
                              Left(lcCodCta, 2) = "91" Or Left(lcCodCta, 2) = "92" Then
                lnSalAcu = (lnSaldo + lnDebe) - lnHaber
                lnSalAcu1 = lnSalAcu1 + lnSalAcu
            Else
                lnSalAcu = (lnSaldo + lnHaber) - lnDebe
                lnSalAcu1 = lnSalAcu1 + lnSalAcu
            End If

            dsCtb.Tables(0).Rows(nelem)("nSalAnt") = lnSalAcu1
            dsCtb.Tables(0).Rows(nelem)("nSaldo") = lnSaldo 'lnSalAcu
            lccodCta1 = lcCodCta
            nelem = nelem + 1
        Next
        Return dsCtb
    End Function
    Public Function SaldoInicial(ByVal pcCodCta As String) As Double 'Calcula Saldo Inicial por Cuenta
        Dim entidadcntamov1 As New SIM.EL.cntamov
        Dim ecntamov1 As New SIM.BL.cCntamov
        Dim dsCtb1 As New DataSet
        Dim dateIni, dateFin As Date
        dateIni = Me.Fecha_Inicial(Me.dFecIni)
        dateFin = Me.Fecha_DiaAntes(Me.dFecIni)
        dsCtb1 = ecntamov1.ObtenerSaldosIniporCuenta(dateIni, dateFin, pcCodCta)
        Dim nelem1 As Integer = 0
        Dim pnSaldoIni As Double = 0
        Dim pnDebe, pnHaber, pnSalIni As Double
        pnDebe = 0
        pnHaber = 0
        pnSalIni = 0

        nelem1 = dsCtb1.Tables(0).Rows.Count
        If nelem1 = 0 Then
            pnSaldoIni = 0
        Else
            pnDebe = IIf(dsCtb1.Tables(0).Rows(0)("nDebe") Is DBNull.Value, 0, dsCtb1.Tables(0).Rows(0)("nDebe"))
            pnHaber = IIf(dsCtb1.Tables(0).Rows(0)("nHaber") Is DBNull.Value, 0, dsCtb1.Tables(0).Rows(0)("nHaber"))
            pnSalIni = IIf(dsCtb1.Tables(0).Rows(0)("nSalIni") Is DBNull.Value, 0, dsCtb1.Tables(0).Rows(0)("nSalIni"))
            If Left(pcCodCta, 1) = "1" Or _
                                Left(pcCodCta, 1) = "5" Or Left(pcCodCta, 1) = "7" Or Left(pcCodCta, 1) = "8" Or _
                                Left(pcCodCta, 2) = "91" Or Left(pcCodCta, 2) = "92" Then
                pnSaldoIni = (pnSalIni + pnDebe) - pnHaber
            Else
                pnSaldoIni = (pnSalIni + pnHaber) - pnDebe
            End If
        End If
        Return pnSaldoIni
    End Function
    Public Function LibromayorDetallado() As DataSet
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        Dim dsCtb2 As New DataSet
        dsCtb2 = ecntamov.ObtenerLibroMayor(Me.dFecIni, Me.dFecfin)
        Dim nelem As Integer
        nelem = dsCtb2.Tables(0).Rows.Count
        If nelem = 0 Then

        End If
        nelem = 0
        Dim fila As DataRow
        Dim lcCodCta As String
        Dim lnSalAnt As Double
        Dim lnSalIni, lnSalFin As Double
        Dim lnDebe, lnHaber, lndiferencia As Double
        lcCodCta = dsCtb2.Tables(0).Rows(nelem)("cCodCta")
        For Each fila In dsCtb2.Tables(0).Rows    'Saldos de Cuentas Hijas
            lcCodCta = dsCtb2.Tables(0).Rows(nelem)("cCodCta")
            lnSalIni = 0
            lnSalFin = 0
            lndiferencia = 0
            lnSalIni = Me.SaldoInicial(lcCodCta)
            lnDebe = IIf(dsCtb2.Tables(0).Rows(nelem)("nDebe") Is DBNull.Value, 0, dsCtb2.Tables(0).Rows(nelem)("nDebe"))
            lnHaber = IIf(dsCtb2.Tables(0).Rows(nelem)("nHaber") Is DBNull.Value, 0, dsCtb2.Tables(0).Rows(nelem)("nHaber"))
            If lnDebe = 0 Then
                dsCtb2.Tables(0).Rows(nelem)("nDebe") = 0
            End If
            If lnHaber = 0 Then
                dsCtb2.Tables(0).Rows(nelem)("nHaber") = 0
            End If

            If Left(lcCodCta, 1) = "1" Or _
                              Left(lcCodCta, 1) = "5" Or Left(lcCodCta, 1) = "7" Or Left(lcCodCta, 1) = "8" Or _
                            Left(lcCodCta, 2) = "91" Or Left(lcCodCta, 2) = "92" Then
                lnSalFin = lnSalIni + lnDebe - lnHaber
                lndiferencia = lnDebe - lnHaber
            Else
                lnSalFin = lnSalIni - lnDebe + lnHaber
                lndiferencia = lnHaber - lnDebe
            End If
            dsCtb2.Tables(0).Rows(nelem)("nSalIni") = lnSalIni
            dsCtb2.Tables(0).Rows(nelem)("nSalFin") = lnSalFin
            dsCtb2.Tables(0).Rows(nelem)("Diferencia") = lndiferencia
            nelem = nelem + 1
        Next
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim claseppal As New class1
        Dim dsLib As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim lcnivelS As String
        Dim lcFecLet As String
        dsLib.Clear()
        lCampos1 = "cCodcta, cDescrip, nSalIni, nSalFin, nDebe, nHaber, dfecIni, dFecFin, Diferencia,"
        lTipos1 = "S,S,D,D,D,D,F,F,D,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "Libro1")
        nelem = 0
        Dim lnSalIni1, lnSalFin1, lnDebe1, lnHaber1 As Double
        lnSalIni1 = 0
        lnSalFin1 = 0
        lnDebe1 = 0
        lnHaber1 = 0
        For Each fila In dsCtb2.Tables(0).Rows
            lnSalIni1 = dsCtb2.Tables(0).Rows(nelem)("nSalIni")
            lnSalFin1 = dsCtb2.Tables(0).Rows(nelem)("nSalFin")
            lnDebe1 = dsCtb2.Tables(0).Rows(nelem)("nDebe")
            lnHaber1 = dsCtb2.Tables(0).Rows(nelem)("nHaber")
            If lnSalIni1 <> 0 Or lnSalFin1 <> 0 Or lnDebe1 <> 0 Or lnHaber1 <> 0 Then
                DR = DT.NewRow
                DR("cCodcta") = dsCtb2.Tables(0).Rows(nelem)("cCodCta")
                DR("cDescrip") = dsCtb2.Tables(0).Rows(nelem)("cDescrip")
                DR("nSalIni") = dsCtb2.Tables(0).Rows(nelem)("nSalIni")
                DR("nSalFin") = dsCtb2.Tables(0).Rows(nelem)("nSalFin")
                DR("nDebe") = dsCtb2.Tables(0).Rows(nelem)("nDebe")
                DR("nHaber") = dsCtb2.Tables(0).Rows(nelem)("nHaber")
                DR("dFecIni") = dsCtb2.Tables(0).Rows(nelem)("dFecIni")
                DR("dFecFin") = dsCtb2.Tables(0).Rows(nelem)("dFecFin")
                DR("diferencia") = dsCtb2.Tables(0).Rows(nelem)("diferencia")
                DT.Rows.Add(DR)
            End If
            nelem = nelem + 1
        Next
        dsLib.Tables.Add(DT)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Return dsLib

    End Function
    'Funcion para Consulta General de movimientos contables
    Public Function Consulta_General() As DataSet
        Dim claseppal As New class1
        Dim entidadconctb As New SIM.EL.ComCtb
        Dim econctb As New SIM.BL.cComCtb
        Dim i As Integer
        i = 0
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dsCon As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim lcnivelS As String
        Dim lcFecLet As String
        dsCon.Clear()
        lCampos1 = "cNumcom, dFecCnt, cCodOfi, cTipAsi, cTipMon, cCodCta, nDebe, nHaber, nSalIni, cDescrip, cNumDoc, cGlosa, cNomChq, cNomCli,"
        lTipos1 = "S,F,S,S,S,S,D,D,D,S,S,S,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "Consulta")
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim ds1 As New DataSet
        ds1 = econctb.ObtenerConsulta1(Me.dFecIni, Me.dFecfin, Me.nOpBuscar, Me.cBuscar)
        Dim nelem As Integer = 0
        Dim cons1, cons2, cons3 As Integer
        cons1 = 0
        cons2 = 0
        cons3 = 0

        nelem = ds1.Tables(0).Rows.Count
        If nelem <> 0 Then
            cons1 = 1
            nelem = 0
            Dim fila As DataRow
            'Agrega primera Consulta
            For Each fila In ds1.Tables(0).Rows
                DR = DT.NewRow
                DR("cNumcom") = ds1.Tables(0).Rows(nelem)("cNumcom")
                DR("dFecCnt") = ds1.Tables(0).Rows(nelem)("dFecCnt")
                DR("cCodOFi") = ds1.Tables(0).Rows(nelem)("cCodOfi")
                DR("cTipAsi") = ds1.Tables(0).Rows(nelem)("cTipAsi")
                DR("cTipMon") = ds1.Tables(0).Rows(nelem)("cTipMon")
                DR("cCodcta") = ds1.Tables(0).Rows(nelem)("cCodcta")
                DR("nDebe") = ds1.Tables(0).Rows(nelem)("nDebe")
                DR("nHaber") = ds1.Tables(0).Rows(nelem)("nHaber")
                DR("nSalIni") = ds1.Tables(0).Rows(nelem)("nSalIni")
                DR("cDescrip") = ds1.Tables(0).Rows(nelem)("cDescrip")
                DR("cNumDoc") = ds1.Tables(0).Rows(nelem)("cNumDoc")
                DR("cGlosa") = ds1.Tables(0).Rows(nelem)("cGlosa")
                DR("cNomChq") = ""
                DR("cNomCli") = ""
                DT.Rows.Add(DR)
                nelem += 1
            Next
        End If

        ds1.Tables.Clear()
        ds1 = econctb.ObtenerConsulta2(Me.dFecIni, Me.dFecfin, Me.nOpBuscar, Me.cBuscar)
        nelem = ds1.Tables(0).Rows.Count
        If nelem <> 0 Then
            cons2 = 1
            nelem = 0
            Dim fila As DataRow
            'Agrega Segunda Consulta
            For Each fila In ds1.Tables(0).Rows
                DR = DT.NewRow
                DR("cNumcom") = ds1.Tables(0).Rows(nelem)("cNumcom")
                DR("dFecCnt") = ds1.Tables(0).Rows(nelem)("dFecCnt")
                DR("cCodOFi") = ds1.Tables(0).Rows(nelem)("cCodOfi")
                DR("cTipAsi") = ds1.Tables(0).Rows(nelem)("cTipAsi")
                DR("cTipMon") = ds1.Tables(0).Rows(nelem)("cTipMon")
                DR("cCodcta") = ds1.Tables(0).Rows(nelem)("cCodcta")
                DR("nDebe") = ds1.Tables(0).Rows(nelem)("nDebe")
                DR("nHaber") = ds1.Tables(0).Rows(nelem)("nHaber")
                DR("nSalIni") = ds1.Tables(0).Rows(nelem)("nSalIni")
                DR("cDescrip") = ds1.Tables(0).Rows(nelem)("cDescrip")
                DR("cNumDoc") = ds1.Tables(0).Rows(nelem)("cNumDoc")
                DR("cGlosa") = ds1.Tables(0).Rows(nelem)("cGlosa")
                DR("cNomChq") = ds1.Tables(0).Rows(nelem)("cNomChq")
                DR("cNomCli") = ""
                DT.Rows.Add(DR)
                nelem += 1
            Next
        End If

        ds1.Tables.Clear()
        ds1 = econctb.ObtenerConsulta3(Me.dFecIni, Me.dFecfin, Me.nOpBuscar, Me.cBuscar)
        nelem = ds1.Tables(0).Rows.Count
        If nelem <> 0 Then
            cons3 = 1
            nelem = 0
            Dim fila As DataRow
            'Agrega Tercera Consulta
            For Each fila In ds1.Tables(0).Rows
                DR = DT.NewRow
                DR("cNumcom") = ds1.Tables(0).Rows(nelem)("cNumcom")
                DR("dFecCnt") = ds1.Tables(0).Rows(nelem)("dFecCnt")
                DR("cCodOFi") = ds1.Tables(0).Rows(nelem)("cCodOfi")
                DR("cTipAsi") = ds1.Tables(0).Rows(nelem)("cTipAsi")
                DR("cTipMon") = ds1.Tables(0).Rows(nelem)("cTipMon")
                DR("cCodcta") = ds1.Tables(0).Rows(nelem)("cCodcta")
                DR("nDebe") = ds1.Tables(0).Rows(nelem)("nDebe")
                DR("nHaber") = ds1.Tables(0).Rows(nelem)("nHaber")
                DR("nSalIni") = ds1.Tables(0).Rows(nelem)("nSalIni")
                DR("cDescrip") = ds1.Tables(0).Rows(nelem)("cDescrip")
                DR("cNumDoc") = ds1.Tables(0).Rows(nelem)("cNumDoc")
                DR("cGlosa") = ds1.Tables(0).Rows(nelem)("cGlosa")
                DR("cNomChq") = ""
                DR("cNomCli") = ds1.Tables(0).Rows(nelem)("cNomCli")
                DT.Rows.Add(DR)
                nelem += 1
            Next
        End If
        If (cons1 + cons2 + cons3) = 0 Then
            DR = DT.NewRow
            DR("cNumcom") = ""
            DR("dFecCnt") = Me.dFecIni
            DR("cCodOFi") = ""
            DR("cTipAsi") = ""
            DR("cTipMon") = ""
            DR("cCodcta") = ""
            DR("nDebe") = 0
            DR("nHaber") = 0
            DR("nSalIni") = 0
            DR("cDescrip") = ""
            DR("cNumDoc") = ""
            DR("cGlosa") = ""
            DR("cNomChq") = ""
            DR("cNomCli") = ""
            DT.Rows.Add(DR)
        End If
        dsCon.Tables.Add(DT)
        Return dsCon
    End Function
    Public Function Inspeccion() As DataSet
        Dim entidadconctb As New SIM.EL.ComCtb
        Dim econctb As New SIM.BL.cComCtb
        Dim nelem, nelem1 As Integer
        Dim dsCtb As New DataSet
        Dim dsCtb1 As New DataSet
        Dim claseppal As New class1
        nelem = 0
        dsCtb = econctb.ObtenerDataSetPorID(Me.dFecIni, Me.dFecfin)
        nelem = dsCtb.Tables(0).Rows.Count
        If nelem = 0 Then
            Exit Function
        End If
        nelem = 0
        nelem1 = 0
        Dim fila As DataRow
        Dim lcNumCom As String
        Dim lnDebe, lnHaber As Double
        For Each fila In dsCtb.Tables(0).Rows
            lcNumCom = dsCtb.Tables(0).Rows(nelem)("cNumcom")
            dsCtb1.Tables.Clear()
            dsCtb1 = econctb.Total_Por_Partida(lcNumCom)
            nelem1 = dsCtb1.Tables(0).Rows.Count
            If nelem1 = 0 Then
                lnDebe = 0
                lnHaber = 0
            Else
                lnDebe = dsCtb1.Tables(0).Rows(0)("nDebe")
                lnHaber = dsCtb1.Tables(0).Rows(0)("nHaber")
            End If
            dsCtb.Tables(0).Rows(nelem)("nDebe") = lnDebe
            dsCtb.Tables(0).Rows(nelem)("nHaber") = lnHaber
            nelem += 1
        Next
        'Descarga filtro en dataSet
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dsFilt As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim lcnivelS As String
        Dim lcFecLet As String
        Dim ldFecCnt As Date
        Dim lcNumDoc As String
        Dim lcGlosa As String
        dsFilt.Clear()
        lCampos1 = "cNumcom, cGlosa, dFecCnt, nDebe, nHaber, cNumdoc,"
        lTipos1 = "S,S,F,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "ConsInc")
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        nelem = 0
        For Each fila In dsCtb.Tables(0).Rows
            lcNumCom = dsCtb.Tables(0).Rows(nelem)("cNumcom")
            ldFecCnt = dsCtb.Tables(0).Rows(nelem)("dFecCnt")
            lnDebe = dsCtb.Tables(0).Rows(0)("nDebe")
            lnHaber = dsCtb.Tables(0).Rows(0)("nHaber")
            lcNumDoc = dsCtb.Tables(0).Rows(0)("cNroDoc")
            lcGlosa = dsCtb.Tables(0).Rows(0)("cGlosa")
            If lnDebe <> lnHaber Then
                DR = DT.NewRow
                DR("cNumcom") = lcNumCom
                DR("dFecCnt") = ldFecCnt
                DR("nDebe") = lnDebe
                DR("nHaber") = lnHaber
                DR("cNumDoc") = lcNumDoc
                DR("cGlosa") = lcGlosa
                DT.Rows.Add(DR)
            End If
            nelem += 1
        Next
        dsFilt.Tables.Add(DT)
        Return dsFilt
    End Function

    Public Function lmAuxiliar(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String, ByVal ccodcta1 As String, ByVal ccodcta2 As String, ByVal tipo As String) As DataSet
        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double
        Dim mcntamov As New cCntamov


        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String

        lnnivel = ccodcta1.Trim.Length

        lcyears = Me.pcyears
        lccadena = Me.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, ccodcta1, cdescrip, nsalini, nmovant, dia, cnumcom, cnomcli,cglosa, ndebe, nhaber, ccodofi, ffondos, cdescri, cnumdoc, dfeccnt, nsaldo,"
        lTipos1 = "S,S,S,D,D,I,S,S,S,D,D,S,S,S,S,F,D,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        Dim dscuentas As New DataSet
        Dim dsmov As New DataSet

        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0

        Dim ldfec1 As Date
        Dim ldfec2 As Date
        Dim ectbdchq As New cCtbdchq
        Dim lcglosa As String
        Dim lcglosa1 As String
        i = 0
        Dim fila As DataRow
        dscuentas = mctbmcta.ObtenerDataSetCuentas(ccodcta1, ccodcta2, Me.pcFuente)

        'mayorisa todas las cuentas del catalogo
        For Each fila In dscuentas.Tables(0).Rows
            lntotsalini = 0
            lccodcta = dscuentas.Tables(0).Rows(i)("ccodcta")
            'lnsalini = dscuentas.Tables(0).Rows(i)("nsalini")
            lnsalini = calcula_saldosiniciales(ldfecinicial, ldfecinicial, lccodcta, lnnivel, Me.pcnomser, lccadena)
            dscuentas.Tables(0).Rows(i)("nsalini") = lnsalini
            lccodcta = lccodcta.Trim

            'Busca cuenta con respectivos movimientos
            dsmov = mcntamov.ObtenerAuxiliar(ldfecha1, ldfecha2, lccodcta, Me.pcCodofi, Me.pcFuente, lccadena)
            Dim fila1 As DataRow
            Dim i1 As Integer = 0
            If ldfecinicial = ldfecha1 Then
                lnsalfin1 = 0
            Else
                ldfec1 = ldfecinicial
                ldfec2 = ldfecha1
                lnnivel = lccodcta.Length
                lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            End If
            lntotsalini = lnsalfin1 + lnsalini
            Dim lccodpres As String = ""
            Dim lcnumdoc As String = ""
            Dim lcnumrec As String = ""
            If tipo = "A" Then 'movimientos por cuenta Auxiliar
                For Each fila1 In dsmov.Tables(0).Rows
                    lcglosa = ""
                    lcglosa1 = ""
                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = dsmov.Tables(0).Rows(i1)("ccodcta")
                    drcatalogo("cCodcta1") = lccodcta
                    drcatalogo("cdescrip") = dsmov.Tables(0).Rows(i1)("cdescrip")
                    drcatalogo("cdescri") = dsmov.Tables(0).Rows(i1)("cdescri")
                    drcatalogo("nsalini") = lntotsalini
                    drcatalogo("nmovant") = lnsalfin1
                    drcatalogo("dia") = dsmov.Tables(0).Rows(i1)("dia")
                    drcatalogo("dfeccnt") = fila1("dfeccnt")
                    drcatalogo("cnumcom") = dsmov.Tables(0).Rows(i1)("cnumcom")
                    drcatalogo("ffondos") = dsmov.Tables(0).Rows(i1)("ffondos")
                    lcglosa1 = ectbdchq.Nchequexcnumcom(dsmov.Tables(0).Rows(i1)("cnumcom"), lccadena).Trim
                    lcglosa = dsmov.Tables(0).Rows(i1)("cglosa")
                    lccodpres = IIf(IsDBNull(dsmov.Tables(0).Rows(i1)("cCodpres")), "", dsmov.Tables(0).Rows(i1)("cCodpres"))
                    lcnumdoc = IIf(IsDBNull(dsmov.Tables(0).Rows(i1)("cnumdoc")), "", dsmov.Tables(0).Rows(i1)("cnumdoc"))
                    lcnumrec = IIf(IsDBNull(dsmov.Tables(0).Rows(i1)("cnumrec")), "", dsmov.Tables(0).Rows(i1)("cnumrec"))
                    If Left(lcglosa.Trim, 28) = "PARTIDA DE PAGO DE PRESTAMOS" Then
                        lcglosa = "PAGO DE CREDITO Nº " & lccodpres.Trim & " Doc Nº " & lcnumrec
                    ElseIf Left(lcglosa.Trim, 9) = "REV.PAGOS" Then
                        lcglosa = "REVERSION DE PAGO CREDITO Nº " & lccodpres.Trim & " Doc Nº " & lcnumdoc
                    Else
                        If lcnumdoc.Trim = "" Then
                        Else
                            lcglosa = lcglosa & " " & " Doc Nº " & lcnumdoc
                        End If

                    End If
                    drcatalogo("cglosa") = lcglosa1.Trim + " " + lcglosa.Trim
                    drcatalogo("ndebe") = dsmov.Tables(0).Rows(i1)("ndebe")
                    drcatalogo("nhaber") = dsmov.Tables(0).Rows(i1)("nhaber")
                    drcatalogo("ccodofi") = dsmov.Tables(0).Rows(i1)("ccodofi")
                    DT.Rows.Add(drcatalogo)
                    i1 = i1 + 1
                Next

            Else 'Movimientos por bancos
                Dim ecremcre As New cCremcre
                Dim lcnomcli As String = ""
                Dim lnsaldo As Double = 0
                lnsaldo = lntotsalini
                For Each fila1 In dsmov.Tables(0).Rows
                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = dsmov.Tables(0).Rows(i1)("ccodcta")
                    drcatalogo("cCodcta1") = lccodcta
                    drcatalogo("cdescrip") = dsmov.Tables(0).Rows(i1)("cdescrip")
                    drcatalogo("cdescri") = dsmov.Tables(0).Rows(i1)("cdescri")
                    drcatalogo("nsalini") = lntotsalini
                    drcatalogo("nmovant") = lnsalfin1
                    drcatalogo("dia") = dsmov.Tables(0).Rows(i1)("dia")
                    drcatalogo("dfeccnt") = dsmov.Tables(0).Rows(i1)("dfeccnt")
                    drcatalogo("cnumcom") = dsmov.Tables(0).Rows(i1)("cnumcom")
                    drcatalogo("ffondos") = dsmov.Tables(0).Rows(i1)("ffondos")
                    lcglosa1 = ectbdchq.Nchequexcnumcom(dsmov.Tables(0).Rows(i1)("cnumcom"), lccadena).Trim
                    lcglosa = dsmov.Tables(0).Rows(i1)("cglosa")
                    lccodpres = IIf(IsDBNull(dsmov.Tables(0).Rows(i1)("cCodpres")), "", dsmov.Tables(0).Rows(i1)("cCodpres"))
                    lcnumdoc = IIf(IsDBNull(dsmov.Tables(0).Rows(i1)("cnumdoc")), "", dsmov.Tables(0).Rows(i1)("cnumdoc"))
                    lcnomcli = ecremcre.ObtenerNombrexCuenta(lccodpres)

                    If lcnomcli.Trim = "" Then
                        lcnomcli = ectbdchq.NombreChequexcnumcom(dsmov.Tables(0).Rows(i1)("cnumcom"), lccadena).Trim
                        'BUSCA EL NOMBRE DE CLIENTE A KIEN SE LE APLICO LA REFERENCIA,COMISION O LEGALIZACION
                        'SI ESTA VACIO LCNOMCLI
                        If lcnomcli = "" Then
                            lcnomcli = ectbdchq.ClientePorCodigo(dsmov.Tables(0).Rows(i1)("cCodpres"))
                        End If

                    End If
                    If Left(lcglosa.Trim, 13) = "Pago de cred." Then
                        lcglosa = "PAGO DE CREDITO Nº " & lccodpres.Trim
                        drcatalogo("cnumdoc") = lcnumdoc
                    ElseIf Left(lcglosa.Trim, 9) = "REV.PAGOS" Then
                        lcglosa = "REVERSION DE PAGO CREDITO Nº " & lccodpres.Trim
                        drcatalogo("cnumdoc") = lcnumdoc
                    ElseIf Left(lcglosa.Trim, 12) = "POR COBRO DE" Then
                        'lcglosa = "REVERSION DE PAGO CREDITO Nº " & lccodpres.Trim
                        drcatalogo("cnumdoc") = lcnumdoc
                    Else
                        lcglosa = lcglosa1.Trim + " " + lcglosa.Trim
                        drcatalogo("cnumdoc") = lcnumdoc.Trim 'lcglosa1
                    End If
                    drcatalogo("cnomcli") = lcnomcli.Trim
                    drcatalogo("cglosa") = lcglosa.Trim
                    drcatalogo("ndebe") = dsmov.Tables(0).Rows(i1)("ndebe")
                    drcatalogo("nhaber") = dsmov.Tables(0).Rows(i1)("nhaber")
                    drcatalogo("ccodofi") = dsmov.Tables(0).Rows(i1)("ccodofi")

                    lnsaldo = lnsaldo + (drcatalogo("ndebe") - drcatalogo("nhaber"))
                    drcatalogo("nsaldo") = lnsaldo
                    DT.Rows.Add(drcatalogo)
                    i1 = i1 + 1
                Next


            End If
            '            dsBal.Tables.Add(DT)

            i = i + 1
        Next

        Dim dtNew As DataTable
        dtNew = SelectDataTable(DT, "", "ccodcta asc, ffondos asc, dfeccnt asc")


        dsBal.Tables.Add(DT)

        Return dsBal


       
    End Function
  
   
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Public Function libro(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodcta1 As String, ByVal lnnivel1 As Integer, ByVal lcnomser As String, ByVal lccodcta2 As String, ByVal lcfuente As String, ByVal lccodofi As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim ecntamov As New cCntamov
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double

        Dim dslibro As New DataSet
        Dim dslibromov As New DataSet

        Me.pcFuente = lcfuente
        Me.pcCodofi = lccodofi
        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String



        lcyears = Me.pcyears
        lccadena = Me.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip,  nsalant, ncargos, nabonos, nsalact, dfeccnt, id,"
        lTipos1 = "S,S,D,D,D,D,F,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")
        lnnivel1 = lccodcta1.Trim.Length
        dslibro = ecntamov.Cuentaslibro(ldfecha1, ldfecha2, lccodcta1, lnnivel1, lcnomser, lccodcta2, lcfuente, lccodofi, lccadena)
        Dim fila1 As DataRow
        Dim elem1 As Integer = 0

        Dim fila2 As DataRow
        Dim elem2 As Integer = 0

        'listacatalogo = mctbmcta.ObtenerLista()
        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        i = 0
        'mayorisa todas las cuentas del catalogo
        For Each fila1 In dslibro.Tables(0).Rows
            lccodcta = dslibro.Tables(0).Rows(elem1)("cCodcta")
            lccodcta = lccodcta.Trim

            lcdescrip = dslibro.Tables(0).Rows(elem1)("cdescrip")
            lccodto = dslibro.Tables(0).Rows(elem1)("cCodto")
            lcnivel = dslibro.Tables(0).Rows(elem1)("cnivel")
            lnsalini = dslibro.Tables(0).Rows(elem1)("nSalini")

            'obtiene saldo inicial antes de la fecha de inicio
            lnnivel = lccodcta.Length

            Dim ldfec1 As Date
            Dim ldfec2 As Date

            If ldfecinicial = ldfecha1 Then
                lnsalfin1 = 0
            Else
                ldfec1 = ldfecinicial
                ldfec2 = ldfecha1
                lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            End If
            Me.pndebe = 0
            Me.pnhaber = 0
            calcula_saldos4(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            Me.pndebe = Math.Round(Me.pndebe, 2)
            Me.pnhaber = Math.Round(Me.pnhaber, 2)

            Dim lntmp1, lntmp2, lntmp3, lntmp4 As Double

            'Agrega los movimientos
            dslibromov = ecntamov.sumasporcuenta(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, lcfuente, lccadena)
            elem2 = 0
            Dim lnsaldo As Double = 0
            lnsaldo = Math.Round(lnsalini + lnsalfin1, 2)
            If dslibromov.Tables(0).Rows.Count = 0 Then
                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = lccodcta
                drcatalogo("id") = Left(lccodcta, lnnivel)
                drcatalogo("cDescrip") = lcdescrip
                drcatalogo("nsalant") = lnsaldo
                If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "9" Then
                    drcatalogo("nsalact") = Math.Round(lnsaldo, 2)
                Else
                    drcatalogo("nsalact") = Math.Round(lnsaldo, 2)
                End If
                lnsaldo = drcatalogo("nsalact")

                drcatalogo("nCargos") = 0
                drcatalogo("nAbonos") = 0
                DT.Rows.Add(drcatalogo)
            End If
            For Each fila2 In dslibromov.Tables(0).Rows
                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = lccodcta
                drcatalogo("id") = Left(lccodcta, lnnivel)
                drcatalogo("cDescrip") = lcdescrip
                drcatalogo("dfeccnt") = dslibromov.Tables(0).Rows(elem2)("dfeccnt")
                drcatalogo("nsalant") = lnsaldo
                If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                    drcatalogo("nsalact") = Math.Round(lnsaldo + dslibromov.Tables(0).Rows(elem2)("ncargos") - dslibromov.Tables(0).Rows(elem2)("nabonos"), 2)
                Else
                    drcatalogo("nsalact") = Math.Round(lnsaldo + (dslibromov.Tables(0).Rows(elem2)("nabonos") - dslibromov.Tables(0).Rows(elem2)("ncargos")), 2)
                End If
                lnsaldo = drcatalogo("nsalact")

                drcatalogo("nCargos") = dslibromov.Tables(0).Rows(elem2)("ncargos")
                drcatalogo("nAbonos") = dslibromov.Tables(0).Rows(elem2)("nabonos")

                elem2 += 1
                lntmp1 = drcatalogo("nsalant")
                lntmp2 = drcatalogo("nsalact")
                lntmp3 = drcatalogo("nCargos")
                lntmp4 = drcatalogo("nAbonos")
                If lntmp1 = 0 And lntmp2 = 0 And lntmp3 = 0 And lntmp4 = 0 Then
                Else
                    DT.Rows.Add(drcatalogo)
                End If


            Next
            elem1 += 1
        Next

        dsBal.Tables.Add(DT)

        Return dsBal

    End Function
    Public Function Depurador(ByVal ds As DataSet) As DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lcnivel As String

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow
        Dim lccodcta As String

        Dim nflag_act As Integer = 0
        Dim lnactivo As Double = 0


        Dim nflag_pat As Integer = 0
        Dim lnpatrimonio As Double = 0

        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        For Each fila In ds.Tables(0).Rows
            lcnivel = ds.Tables(0).Rows(i)("cnivel")
            lccodcta = ds.Tables(0).Rows(i)("cCodcta")

            If Left(lccodcta, 1) = "1" Then ' total de Activos
                If lccodcta = 1 Then
                    lnactivo = ds.Tables(0).Rows(i)("nsalfin")
                End If
            Else
                If nflag_act = 0 And lnactivo > 0 Then
                    nflag_act = 1
                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = ""
                    drcatalogo("cCodto") = "R"
                    drcatalogo("cDescrip") = "TOTAL DE ACTIVOS"
                    drcatalogo("cnivel") = "02"
                    drcatalogo("nsalini") = 0
                    drcatalogo("nsalfin") = lnactivo
                    drcatalogo("ndebe") = 0
                    drcatalogo("nhaber") = 0
                    DT.Rows.Add(drcatalogo)

                    drcatalogo = DT.NewRow
                    DT.Rows.Add(drcatalogo)
                End If
            End If
            If lccodcta = "2" Or lccodcta = "3" Then
                lnpatrimonio = lnpatrimonio + ds.Tables(0).Rows(i)("nsalfin")
            End If

            If lcnivel.Trim > "03" Then
                '       ds.Tables(0).Rows(i).Delete()
                '      ds.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = ds.Tables(0).Rows(i)("ccodcta")
                drcatalogo("cCodto") = ds.Tables(0).Rows(i)("ccodto")
                drcatalogo("cDescrip") = ds.Tables(0).Rows(i)("cdescrip")
                drcatalogo("cnivel") = ds.Tables(0).Rows(i)("cnivel")
                drcatalogo("nsalini") = ds.Tables(0).Rows(i)("nsalini")
                drcatalogo("nsalfin") = ds.Tables(0).Rows(i)("nsalfin")
                drcatalogo("ndebe") = ds.Tables(0).Rows(i)("ndebe")
                drcatalogo("nhaber") = ds.Tables(0).Rows(i)("nhaber")
                DT.Rows.Add(drcatalogo)
            End If
            i += 1
        Next

        drcatalogo = DT.NewRow
        drcatalogo("cCodcta") = ""
        drcatalogo("cCodto") = "R"
        drcatalogo("cDescrip") = "TOTAL PASIVO Y PATRIMONIO"
        drcatalogo("cnivel") = "02"
        drcatalogo("nsalini") = 0
        drcatalogo("nsalfin") = lnpatrimonio
        drcatalogo("ndebe") = 0
        drcatalogo("nhaber") = 0
        DT.Rows.Add(drcatalogo)

        dsBal.Tables.Add(DT)
        'ds.Tables(0).AcceptChanges()
        Return dsBal
    End Function

    Public Function GenEstRes(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double



        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String



        lcyears = Me.pcyears
        lccadena = Me.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        listacatalogo = mctbmcta.ObtenerListaPorID45(Me.pcFuente)
        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        i = 0
        'mayorisa todas las cuentas del catalogo
        For Each ectbmcta In listacatalogo
            lccodcta = listacatalogo(i).ccodcta.Trim

            lcdescrip = listacatalogo(i).cdescrip
            lccodto = listacatalogo(i).ccodto.Trim
            lcnivel = listacatalogo(i).cnivel
            lnsalini = listacatalogo(i).nsalini

            'obtiene saldo inicial antes de la fecha de inicio
            lnnivel = lccodcta.Length

            Dim ldfec1 As Date
            Dim ldfec2 As Date

            If ldfecinicial = ldfecha1 Then
                lnsalfin1 = 0
            Else
                ldfec1 = ldfecinicial
                ldfec2 = ldfecha1
                lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            End If
            Me.pndebe = 0
            Me.pnhaber = 0
            calcula_saldos4(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser, lccadena)
            Me.pndebe = Math.Round(Me.pndebe, 2)
            Me.pnhaber = Math.Round(Me.pnhaber, 2)


            drcatalogo = DT.NewRow
            drcatalogo("cCodcta") = lccodcta
            drcatalogo("cCodto") = lccodto
            drcatalogo("cDescrip") = lcdescrip
            drcatalogo("cnivel") = lcnivel
            drcatalogo("nsalini") = Math.Round(lnsalini + lnsalfin1, 2)
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + Me.pndebe - Me.pnhaber, 2)
            Else
                drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + (Me.pnhaber - Me.pndebe), 2)
            End If


            drcatalogo("ndebe") = Me.pndebe
            drcatalogo("nhaber") = Me.pnhaber

            If lctipo = "bc" Then
                If lnsalini = 0 And lnsalfin1 = 0 And Me.pndebe = 0 And Me.pnhaber = 0 Then
                Else
                    DT.Rows.Add(drcatalogo)
                End If
            Else
                DT.Rows.Add(drcatalogo)
            End If


            i = i + 1
        Next

        dsBal.Tables.Add(DT)

        Dim mcntamov As New cCntamov
        Dim dstotales As New DataSet
        dstotales = mcntamov.ObtenerSaldosPorCuenta5(ldfecha1, ldfecha2, Me.pcnomser, Me.pcCodofi, Me.pcFuente)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lndebe As Double
        Dim lnhaber As Double

        For Each fila In dstotales.Tables(0).Rows
            If IsDBNull(dstotales.Tables(0).Rows(ele)("ndebe")) Then
                dstotales.Tables(0).Rows(ele)("ndebe") = 0
            End If
            If IsDBNull(dstotales.Tables(0).Rows(ele)("nhaber")) Then
                dstotales.Tables(0).Rows(ele)("nhaber") = 0
            End If
            lndebe = Math.Round(dstotales.Tables(0).Rows(ele)("ndebe"), 2)
            lnhaber = Math.Round(dstotales.Tables(0).Rows(ele)("nhaber"), 2)
            Me.pnDebeac = Me.pnDebeac + lndebe
            Me.pnHabereac = Me.pnHabereac + lnhaber
            ele += 1
        Next

        Me.pnsalini = lntotsalini
        Me.pnsalfin = lntotsalfin
        Me.pndebe = Math.Round(Me.pnDebeac, 2)
        Me.pnhaber = Math.Round(Me.pnHabereac, 2)

        Return dsBal
    End Function
    Public Function EstadoSuper(ByVal ds As DataSet, ByVal ccodpla As String, ByVal cnivel As String) As DataSet
        Dim ectbmcta As New cCtbmcta
        Dim dsp As New DataSet
        'If Me.pcFuente = "99" Then 'plantilla de titularizadora
        dsp = ectbmcta.PlantillaDataSet(ccodpla, cnivel)
        'Else 'plantilla de fondos
        '    dsp = ectbmcta.PlantillaDataSet("0002")
        'End If

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodcta As String
        Dim lnsalfin As Double
        Dim lccodigo As String
        Dim lccodigoa As String
        Dim lnsaldo As Double
        Dim lnacciones As Integer
        For Each fila In dsp.Tables(0).Rows
            lccodigo = dsp.Tables(0).Rows(i)("cCodigo")
            If lccodigo.Trim = "53" Then
                lccodigo = "53"
            End If
            lccodigoa = IIf(IsDBNull(dsp.Tables(0).Rows(i)("cCodigoa")), "", dsp.Tables(0).Rows(i)("cCodigoa"))
            'Busca saldo de esta cuenta
            If lccodigo.Trim = "" Then
            Else

                lnsalfin = BuscadorAux(lccodigo.Trim, ds, ccodpla)

                dsp.Tables(0).Rows(i)("nsaldo") = lnsalfin
            End If

            If lccodigoa.Trim = "" Then
            Else

                lnsalfin = BuscadorAux(lccodigoa.Trim, ds, ccodpla)
                dsp.Tables(0).Rows(i)("nsaldoa") = lnsalfin
            End If
            i += 1
        Next



        Return dsp
    End Function
    Public Function Buscador(ByVal parametro As String, ByVal ds As DataSet) As Double
        Dim fila As DataRow
        Dim k As Integer
        Dim lccodcta As String
        Dim lnsalfin As Double = 0
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(k)("ccodcta")
            If lccodcta.Trim = parametro.Trim Then
                lnsalfin = ds.Tables(0).Rows(k)("nsalfin")
                Exit For
            End If
            k += 1
        Next
        Return lnsalfin

    End Function
    Public Function BuscadorAux(ByVal parametro As String, ByVal dsctas As DataSet, ByVal ccodpla As String) As String
        Dim ectbmcta As New cCtbmcta
        Dim ds As New DataSet
        Dim lnsaldo As Double = 0
        'If Me.pcFuente = "99" Then
        ds = ectbmcta.PlantillaAux(ccodpla.Trim, parametro)
        'Else
        '    ds = ectbmcta.PlantillaAux("0002", parametro)
        'End If

        Dim fila As DataRow
        Dim i As Integer
        Dim lccodcta As String
        Dim lcsigno As String
        If parametro.Trim = "11" Then
            Dim cc As Integer
            cc = 1
        End If
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i)("ccodcta")
            lcsigno = ds.Tables(0).Rows(i)("csigno")
            If lcsigno = "+" Then
                lnsaldo = lnsaldo + Buscador(lccodcta.Trim, dsctas)
            Else
                lnsaldo = lnsaldo - Buscador(lccodcta.Trim, dsctas)
            End If

            i += 1
        Next
        Return lnsaldo
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
    Public Function Depurador2(ByVal ds As DataSet) As DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lcnivel As String

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow
        Dim lccodcta As String

        Dim lnsalant, lncargos, lnabonos, lnsalact As Double


        lCampos1 = "cCodCta, cDescrip,  nsalant, ncargos, nabonos, nsalact, dfeccnt, id,"
        lTipos1 = "S,S,D,D,D,D,F,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i)("cCodcta")
            lnsalant = ds.Tables(0).Rows(i)("nsalant")
            lncargos = ds.Tables(0).Rows(i)("ncargos")
            lnabonos = ds.Tables(0).Rows(i)("nabonos")
            lnsalact = ds.Tables(0).Rows(i)("nsalact")


            lcnivel = Trim(Str(lccodcta.Trim.Length))
            lcnivel = IIf(lcnivel.Trim.Length > 1, lcnivel, ("0" + lcnivel.Trim))
            If lccodcta.Trim.Length > 3 Then
            Else
                If lnsalant <> 0 Or lncargos <> 0 Or lnabonos <> 0 Or lnsalact <> 0 Then
                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = ds.Tables(0).Rows(i)("ccodcta")
                    drcatalogo("cdescrip") = ds.Tables(0).Rows(i)("cdescrip")
                    drcatalogo("nsalant") = ds.Tables(0).Rows(i)("nsalant")
                    drcatalogo("ncargos") = ds.Tables(0).Rows(i)("ncargos")
                    drcatalogo("nabonos") = ds.Tables(0).Rows(i)("nabonos")
                    drcatalogo("nsalact") = ds.Tables(0).Rows(i)("nsalact")
                    drcatalogo("dfeccnt") = ds.Tables(0).Rows(i)("dfeccnt")
                    drcatalogo("id") = ds.Tables(0).Rows(i)("id")
                    DT.Rows.Add(drcatalogo)
                End If
            End If
            i += 1
        Next
        dsBal.Tables.Add(DT)
        Return dsBal
    End Function

    Public Function Depurador3(ByVal ds As DataSet) As DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lcnivel As String

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow
        Dim lccodcta As String

        Dim nflag_act As Integer = 0
        Dim lnactivo As Double = 0


        Dim nflag_pat As Integer = 0
        Dim lnpatrimonio As Double = 0

        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        Dim lccodto As String = ""

        For Each fila In ds.Tables(0).Rows
            lcnivel = ds.Tables(0).Rows(i)("cnivel")
            lccodcta = ds.Tables(0).Rows(i)("cCodcta")
            lccodto = ds.Tables(0).Rows(i)("cCodto")

            If Left(lccodcta, 1) = "1" Then ' total de Activos
                If lccodcta = 1 Then
                    lnactivo = ds.Tables(0).Rows(i)("nsalfin")
                End If
            Else
                If nflag_act = 0 And lnactivo > 0 Then
                    nflag_act = 1
                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = ""
                    drcatalogo("cCodto") = "R"
                    drcatalogo("cDescrip") = "TOTAL DE ACTIVOS"
                    drcatalogo("cnivel") = "02"
                    drcatalogo("nsalini") = 0
                    drcatalogo("nsalfin") = lnactivo
                    drcatalogo("ndebe") = 0
                    drcatalogo("nhaber") = 0
                    DT.Rows.Add(drcatalogo)

                    drcatalogo = DT.NewRow
                    DT.Rows.Add(drcatalogo)
                End If
            End If
            If lccodcta = "3" Or lccodcta = "5" Then
                lnpatrimonio = lnpatrimonio + ds.Tables(0).Rows(i)("nsalfin")
            End If

            If lccodto.Trim = "D" Then 'lcnivel.Trim > "03" Then
                '       ds.Tables(0).Rows(i).Delete()
                '      ds.Tables(0).GetChanges(DataRowState.Deleted)
            Else

                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = ds.Tables(0).Rows(i)("ccodcta")
                drcatalogo("cCodto") = ds.Tables(0).Rows(i)("ccodto")
                drcatalogo("cDescrip") = ds.Tables(0).Rows(i)("cdescrip")
                drcatalogo("cnivel") = ds.Tables(0).Rows(i)("cnivel")
                drcatalogo("nsalini") = ds.Tables(0).Rows(i)("nsalini")
                drcatalogo("nsalfin") = ds.Tables(0).Rows(i)("nsalfin")
                drcatalogo("ndebe") = ds.Tables(0).Rows(i)("ndebe")
                drcatalogo("nhaber") = ds.Tables(0).Rows(i)("nhaber")
                DT.Rows.Add(drcatalogo)
            End If
            i += 1
        Next

        drcatalogo = DT.NewRow
        drcatalogo("cCodcta") = ""
        drcatalogo("cCodto") = "R"
        drcatalogo("cDescrip") = "TOTAL PASIVO Y PATRIMONIO"
        drcatalogo("cnivel") = "02"
        drcatalogo("nsalini") = 0
        drcatalogo("nsalfin") = lnpatrimonio
        drcatalogo("ndebe") = 0
        drcatalogo("nhaber") = 0
        DT.Rows.Add(drcatalogo)

        dsBal.Tables.Add(DT)
        'ds.Tables(0).AcceptChanges()
        Return dsBal
    End Function
    Public Function BuscadorMensual(ByVal parametro As String, ByVal ds As DataSet) As Double
        Dim fila As DataRow
        Dim k As Integer
        Dim lccodcta As String
        Dim lnsalfin As Double = 0
        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(k)("ccodcta")
            If lccodcta.Trim = parametro.Trim Then
                lndebe = ds.Tables(0).Rows(k)("ndebe")
                lnhaber = ds.Tables(0).Rows(k)("nhaber")
                lnsalfin = IIf(Left(lccodcta.Trim, 1) = "5", (lnhaber - lndebe), (lndebe - lnhaber))
                'ds.Tables(0).Rows(k)("nsalfin")
                Exit For
            End If
            k += 1
        Next
        Return lnsalfin

    End Function
    Public Function BuscadorAuxMensual(ByVal parametro As String, ByVal dsctas As DataSet, ByVal ccodpla As String) As String
        Dim ectbmcta As New cCtbmcta
        Dim ds As New DataSet
        Dim lnsaldo As Double = 0
        'If Me.pcFuente = "99" Then
        ds = ectbmcta.PlantillaAux(ccodpla.Trim, parametro)
        'Else
        '    ds = ectbmcta.PlantillaAux("0002", parametro)
        'End If

        Dim fila As DataRow
        Dim i As Integer
        Dim lccodcta As String
        Dim lcsigno As String
        If parametro.Trim = "11" Then
            Dim cc As Integer
            cc = 1
        End If
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i)("ccodcta")
            lcsigno = ds.Tables(0).Rows(i)("csigno")
            If lcsigno = "+" Then
                lnsaldo = lnsaldo + BuscadorMensual(lccodcta.Trim, dsctas)
            Else
                lnsaldo = lnsaldo - BuscadorMensual(lccodcta.Trim, dsctas)
            End If

            i += 1
        Next
        Return lnsaldo
    End Function
    Public Function EstadoSuperMensual(ByVal ds As DataSet, ByVal ccodpla As String, ByVal cnivel As String) As DataSet
        Dim ectbmcta As New cCtbmcta
        Dim dsp As New DataSet
        'If Me.pcFuente = "99" Then 'plantilla de titularizadora
        dsp = ectbmcta.PlantillaDataSet(ccodpla, cnivel)
        'Else 'plantilla de fondos
        '    dsp = ectbmcta.PlantillaDataSet("0002")
        'End If

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodcta As String
        Dim lnsalfin As Double
        Dim lccodigo As String
        Dim lnsaldo As Double
        Dim lnacciones As Integer
        For Each fila In dsp.Tables(0).Rows
            lccodigo = dsp.Tables(0).Rows(i)("cCodigo")

            'Busca saldo de esta cuenta
            If lccodigo.Trim = "" Then
            Else

                lnsalfin = BuscadorAuxMensual(lccodigo.Trim, ds, ccodpla)

                dsp.Tables(0).Rows(i)("nsaldo") = lnsalfin
            End If

            i += 1
        Next
        Return dsp
    End Function


    Public Function GenComprobacionNivel(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String, ByVal cnivel As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double



        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, ccodofi, ffondos, ccampo, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,S,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        listacatalogo = mctbmcta.ObtenerLista(Me.pcFuente, lccadena)
        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        i = 0


        'mayorisa todas las cuentas del catalogo
        For Each ectbmcta In listacatalogo
            lccodcta = listacatalogo(i).ccodcta.Trim

            lcdescrip = listacatalogo(i).cdescrip
            lccodto = listacatalogo(i).ccodto.Trim
            lcnivel = listacatalogo(i).cnivel
            '            lnsalini = listacatalogo(i).nsalini

            'obtiene saldo inicial antes de la fecha de inicio

            lnnivel = lccodcta.Length
            lnsalini = calcula_saldosiniciales(ldfecinicial, ldfecinicial, lccodcta, lnnivel, Me.pcnomser, lccadena)

            If lnnivel > Integer.Parse(cnivel) Then
            Else



                Dim ldfec1 As Date
                Dim ldfec2 As Date

                If ldfecinicial = ldfecha1 Then
                    lnsalfin1 = 0
                Else
                    ldfec1 = ldfecinicial
                    ldfec2 = ldfecha1
                    lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
                End If
                Me.pndebe = 0
                Me.pnhaber = 0
                calcula_saldos4(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser, lccadena)
                Me.pndebe = Math.Round(Me.pndebe, 2)
                Me.pnhaber = Math.Round(Me.pnhaber, 2)


                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = lccodcta
                drcatalogo("cCodto") = lccodto
                drcatalogo("cDescrip") = lcdescrip
                drcatalogo("cnivel") = lcnivel
                drcatalogo("nsalini") = Math.Round(lnsalini + lnsalfin1, 2)
                If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                    drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + Me.pndebe - Me.pnhaber, 2)
                Else
                    drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + (Me.pnhaber - Me.pndebe), 2)
                End If


                drcatalogo("ndebe") = Me.pndebe
                drcatalogo("nhaber") = Me.pnhaber

                If lctipo = "bc" Then
                    If lnsalini = 0 And lnsalfin1 = 0 And Me.pndebe = 0 And Me.pnhaber = 0 Then
                    Else
                        DT.Rows.Add(drcatalogo)
                    End If
                Else
                    DT.Rows.Add(drcatalogo)
                End If
            End If

            i = i + 1
        Next

        dsBal.Tables.Add(DT)

        Dim mcntamov As New cCntamov
        Dim dstotales As New DataSet
        dstotales = mcntamov.ObtenerSaldosPorCuenta5(ldfecha1, ldfecha2, Me.pcnomser, Me.pcCodofi, Me.pcFuente)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lndebe As Double
        Dim lnhaber As Double

        For Each fila In dstotales.Tables(0).Rows
            If IsDBNull(dstotales.Tables(0).Rows(ele)("ndebe")) Then
                dstotales.Tables(0).Rows(ele)("ndebe") = 0
            End If
            If IsDBNull(dstotales.Tables(0).Rows(ele)("nhaber")) Then
                dstotales.Tables(0).Rows(ele)("nhaber") = 0
            End If
            lndebe = Math.Round(dstotales.Tables(0).Rows(ele)("ndebe"), 2)
            lnhaber = Math.Round(dstotales.Tables(0).Rows(ele)("nhaber"), 2)
            Me.pnDebeac = Me.pnDebeac + lndebe
            Me.pnHabereac = Me.pnHabereac + lnhaber
            ele += 1
        Next

        Me.pnsalini = lntotsalini
        Me.pnsalfin = lntotsalfin
        Me.pndebe = Math.Round(Me.pnDebeac, 2)
        Me.pnhaber = Math.Round(Me.pnHabereac, 2)

        Return dsBal

    End Function
    Public Function calcula_saldosiniciales(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccadena As String) As Double

        Dim mcntamov As New cCntamov
        Dim ldfecha As Date
        Dim ds As New DataSet
        Dim lnsalini As Double = 0
        Dim lnsalfin1 As Double = 0

        Dim lndebeant As Double = 0
        Dim lnhaberant As Double = 0

        Me.pnsalini = 0
        Me.pnsalfin = 0
        Me.pndebe = 0
        Me.pnhaber = 0

        If ldfecha1.Day <> 1 And ldfecha1.Month <> 1 Then
            ldfecha = ldfecha1.AddDays(-1)
        Else
            ldfecha = ldfecha1
        End If
        lcnomser = Me.pcnomser


        ds = mcntamov.ObtenerSaldosIniciales(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, Me.pcCodofi, Me.pcFuente, lccadena, Me.pccierre)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim elex As Integer = 0
            Dim filax As DataRow
            Dim lndebex As Double = 0
            Dim lnhaberx As Double = 0

            For Each filax In ds.Tables(0).Rows
                If IsDBNull(ds.Tables(0).Rows(elex)("ndebe")) Then
                    ds.Tables(0).Rows(elex)("ndebe") = 0
                End If
                If IsDBNull(ds.Tables(0).Rows(elex)("nhaber")) Then
                    ds.Tables(0).Rows(elex)("nhaber") = 0
                End If
                lndebex = Math.Round(ds.Tables(0).Rows(elex)("ndebe"), 2)
                lnhaberx = Math.Round(ds.Tables(0).Rows(elex)("nhaber"), 2)
                lndebeant = lndebeant + lndebex
                lnhaberant = lnhaberant + lnhaberx
                elex += 1
            Next

            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                lnsalfin1 = Math.Round(lndebeant - lnhaberant, 2)
            Else
                lnsalfin1 = Math.Round(lnhaberant - lndebeant, 2)
            End If
        End If
        Return lnsalfin1

    End Function
    '---------------------------------------------------------------------------------------
    Public Function GenComprobacionNivelconAuxiliares(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String, ByVal cnivel As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double



        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, nflag, cflag, norden, nnivel, ccodofi, ffondos, ccampo,"
        lTipos1 = "S,S,S,S,D,D,D,D,S,I,S,I,I,S,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        listacatalogo = mctbmcta.ObtenerLista(Me.pcFuente, lccadena)
        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        i = 0
        Dim dsaux As New DataSet
        Dim ecntamov As New cCntamov
        dsaux = ecntamov.Obtenerresumendetalle2(Me.pcCodofi, Me.pcFuente, ldfecha1, ldfecha2, lccadena, ldfecinicial, Me.pccierre)
        Dim filaaux As DataRow

        'Dim dsfondos As New DataSet
        'Dim dsoficina As New DataSet
        'Dim etabttab As New cTabttab
        'Dim etabtofi As New cTabtofi

        'dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        'dsoficina = etabtofi.ObtenerDataSetPorID()

        Dim filaf As DataRow
        Dim filao As DataRow

        Dim dtaux As DataTable
        Dim dtNew As DataTable

        Dim lnsalinix As Double = 0
        Dim lnsalfinx As Double = 0
        Dim lndebex As Double = 0
        Dim lnhaberx As Double = 0
        'mayorisa todas las cuentas del catalogo
        For Each ectbmcta In listacatalogo
            lccodcta = listacatalogo(i).ccodcta.Trim


            lcdescrip = listacatalogo(i).cdescrip
            lccodto = listacatalogo(i).ccodto.Trim
            lcnivel = listacatalogo(i).cnivel
            '            lnsalini = listacatalogo(i).nsalini

            'obtiene saldo inicial antes de la fecha de inicio

            lnnivel = lccodcta.Length


            If lnnivel > Integer.Parse(cnivel) Then
            Else

                lnsalini = calcula_saldosiniciales(ldfecinicial, ldfecinicial, lccodcta, lnnivel, Me.pcnomser, lccadena)

                Dim ldfec1 As Date
                Dim ldfec2 As Date

                If ldfecinicial = ldfecha1 Then
                    lnsalfin1 = 0
                Else
                    ldfec1 = ldfecinicial
                    ldfec2 = ldfecha1
                    lnsalfin1 = calcula_saldos3(ldfec1, ldfec2, lccodcta, lnnivel, Me.pcnomser, lccadena)
                End If
                Me.pndebe = 0
                Me.pnhaber = 0
                calcula_saldos4(ldfecha1, ldfecha2, lccodcta, lnnivel, Me.pcnomser, lccadena)
                Me.pndebe = Math.Round(Me.pndebe, 2)
                Me.pnhaber = Math.Round(Me.pnhaber, 2)


                drcatalogo = DT.NewRow
                drcatalogo("cCodcta") = lccodcta
                drcatalogo("cCodto") = lccodto
                drcatalogo("cDescrip") = lcdescrip
                drcatalogo("cnivel") = lcnivel
                drcatalogo("nsalini") = Math.Round(lnsalini + lnsalfin1, 2)
                If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                    drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + Me.pndebe - Me.pnhaber, 2)
                Else
                    drcatalogo("nsalfin") = Math.Round(lnsalini + lnsalfin1 + (Me.pnhaber - Me.pndebe), 2)
                End If


                drcatalogo("ndebe") = Me.pndebe
                drcatalogo("nhaber") = Me.pnhaber

                drcatalogo("ccodofi") = "000"
                drcatalogo("ffondos") = "00"
                If lctipo = "bc" Then
                    If lnsalini = 0 And lnsalfin1 = 0 And Me.pndebe = 0 And Me.pnhaber = 0 Then
                        If lcnivel = "01" Or lcnivel = "02" And Left(lccodcta, 1) = "4" Then
                            DT.Rows.Add(drcatalogo)
                        End If
                    Else
                        DT.Rows.Add(drcatalogo)
                    End If
                Else
                    DT.Rows.Add(drcatalogo)
                End If

                If lccodto = "D" Then 'Adicionara detalle por oficina y por fondo
                    '------------------------------------------------------------>
                    For Each filaaux In dsaux.Tables(0).Rows
                        '-------------------------------------------------------------
                        If lccodcta.Trim = Trim(filaaux("cCodcta")) Then
                            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                                lnsalinix = Math.Round((filaaux("ninidebe") + filaaux("ndebei")) - (filaaux("ninihaber") + filaaux("nhaberi")), 2)
                                lnsalfinx = Math.Round(lnsalinix + filaaux("ndebe") - filaaux("nhaber"), 2)
                            Else
                                lnsalinix = Math.Round((filaaux("ninihaber") + filaaux("nhaberi") - (filaaux("ninidebe") + filaaux("ndebei"))), 2)
                                lnsalfinx = Math.Round(lnsalinix + (filaaux("nhaber") - filaaux("ndebe")), 2)
                            End If
                            If lnsalinix = 0 And lnsalfinx = 0 And filaaux("ndebe") = 0 And filaaux("nhaber") = 0 Then
                            Else
                                drcatalogo = DT.NewRow
                                drcatalogo("cCodcta") = lccodcta.Trim + "-" + Trim(filaaux("cCodofi")) + "-" + Trim(filaaux("cCodigo"))
                                drcatalogo("cCodto") = lccodto
                                drcatalogo("cDescrip") = "  " + Trim(filaaux("cnomofi")) + "-" + Trim(filaaux("cdescri"))
                                drcatalogo("cnivel") = lcnivel
                                drcatalogo("nsalini") = lnsalinix
                                drcatalogo("nsalfin") = lnsalfinx
                                drcatalogo("ndebe") = filaaux("ndebe")
                                drcatalogo("nhaber") = filaaux("nhaber")
                                drcatalogo("ccodofi") = filaaux("ccodofi")
                                drcatalogo("ffondos") = filaaux("ccodigo")
                                drcatalogo("ccampo") = lccodcta.Trim
                                DT.Rows.Add(drcatalogo)


                            End If


                        End If
                        '------------------------------------------------------------<
                    Next


                End If

            End If



            i = i + 1
        Next

        dsBal.Tables.Add(DT)

        Dim mcntamov As New cCntamov
        Dim dstotales As New DataSet
        dstotales = mcntamov.ObtenerSaldosPorCuenta5(ldfecha1, ldfecha2, Me.pcnomser, Me.pcCodofi, Me.pcFuente)
        Dim fila As DataRow
        Dim ele As Integer = 0
        Dim lndebe As Double
        Dim lnhaber As Double

        For Each fila In dstotales.Tables(0).Rows
            If IsDBNull(dstotales.Tables(0).Rows(ele)("ndebe")) Then
                dstotales.Tables(0).Rows(ele)("ndebe") = 0
            End If
            If IsDBNull(dstotales.Tables(0).Rows(ele)("nhaber")) Then
                dstotales.Tables(0).Rows(ele)("nhaber") = 0
            End If
            lndebe = Math.Round(dstotales.Tables(0).Rows(ele)("ndebe"), 2)
            lnhaber = Math.Round(dstotales.Tables(0).Rows(ele)("nhaber"), 2)
            Me.pnDebeac = Me.pnDebeac + lndebe
            Me.pnHabereac = Me.pnHabereac + lnhaber
            ele += 1
        Next

        Me.pnsalini = lntotsalini
        Me.pnsalfin = lntotsalfin
        Me.pndebe = Math.Round(Me.pnDebeac, 2)
        Me.pnhaber = Math.Round(Me.pnHabereac, 2)

        Return dsBal

    End Function

    '------------------------------------------------------------
    Public Function GenComprobacionNivelPlus(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String, ByVal cnivel As String, ByVal ccodcta1 As String, ByVal ccodcta2 As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double



        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        'ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ds1 = ecntaprm.ObtenerDataSetPoryear(lcyears)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, cflag, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        Dim dsbalance As New DataSet
        dsbalance = GenerarPlusComprobacion(ldfecha1, ldfecha2, lctipo, cnivel, "*", "*")

        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        Dim lnsalinip As Double = 0
        i = 0
        Dim fila As DataRow
        Dim pasa As Integer = 1
        pndebe = pnSumdebe
        pnhaber = pnSumhaber
        pnsalini = 0
        pnsalfin = 0

        Dim dsoficina As New DataSet
        Dim dsfondos As New DataSet

        Dim etabtofi As New cTabtofi
        Dim etabttab As New cTabttab

        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        dsoficina = etabtofi.ObtenerDataSetPorID()

        Dim filafondo As DataRow
        Dim filaoficina As DataRow

        Dim lccodofi As String
        Dim lcfondo As String

        'Variables para auxiliares
        Dim lnsalini_aux As Double = 0
        Dim lnsalfin_aux As Double = 0
        Dim lndebe_aux As Double = 0
        Dim lnhaber_aux As Double = 0
        Dim lnsalfin1_aux As Double = 0

        Dim lcoficina As String = pcCodofi
        Dim lcfuente As String = pcFuente

        'mayorisa todas las cuentas del catalogo
        For Each fila In dsbalance.Tables(0).Rows
            lccodcta = fila("ccodcta")
            lnnivel = lccodcta.Trim.Length
            lccodto = fila("ccodto")


            If ccodcta1 = "*" And ccodcta2 = "*" Then
                pasa = 1

            Else
                If lccodcta.Trim >= ccodcta1.Trim And lccodcta.Trim <= ccodcta2.Trim Then
                    pasa = 1
                Else
                    pasa = 0
                End If
            End If
            If pasa = 1 Then
                If lnnivel > Integer.Parse(cnivel) Then
                Else

                    lcdescrip = fila("cdescrip")

                    lcnivel = fila("cnivel")
                    'obtiene saldo inicial antes de la fecha de inicio


                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = lccodcta
                    drcatalogo("cCodto") = lccodto
                    drcatalogo("cDescrip") = lcdescrip
                    drcatalogo("cnivel") = lcnivel
                    drcatalogo("nsalini") = fila("nsalini")

                    drcatalogo("nsalfin") = fila("nsalfin")
                    drcatalogo("ndebe") = fila("ndebe")
                    drcatalogo("nhaber") = fila("nhaber")

                    DT.Rows.Add(drcatalogo)


                End If

            End If

        Next

        dsBal.Tables.Add(DT)

        Return dsBal

    End Function

    Public Function GenerarPlusComprobacion(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String, ByVal cnivel As String, ByVal ccodcta1 As String, ByVal ccodcta2 As String) As DataSet
        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta
        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ecntamov As New cCntamov

        Dim ncanti As Integer = 0


        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        'ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ds1 = ecntaprm.ObtenerDataSetPoryear(lcyears)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        Dim ds As New DataSet
        Dim dsreplica As New DataSet
        'ds = ecntamov.Obtenerresumendetalle(pcCodofi, pcFuente, ldfecha1, ldfecha2, lccadena, ldfecinicial)
        ds = ecntamov.Obtenerresumendetalle(pcCodofi, pcFuente, ldfecha1, ldfecha2, lccadena, ldfecinicial, Me.pccierre)
        dsreplica = ds

        pndebe = 0
        pnhaber = 0
        Dim fila As DataRow
        Dim lndebe As Double, lnhaber As Double
        Dim lccodcta As String
        Dim lnnivel As Integer
        Dim lccodto As String

        Dim lndebei As Double = 0
        Dim lnhaberi As Double = 0

        Dim lndebei2 As Double = 0
        Dim lnhaberi2 As Double = 0
        pnSumdebe = 0
        pnSumhaber = 0

        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("ccodcta")
            lccodto = fila("ccodto")



            If lccodto.Trim = "R" Then
                ObtenerMayorizacion(dsreplica, lccodcta)
                lndebe = Me.pndebe
                lnhaber = Me.pnhaber

                lndebei = Me.pndebei
                lnhaberi = Me.pnhaberi

                lndebei2 = Me.pndebei2
                lnhaberi2 = Me.pnhaberi2

                fila("ndebe") = lndebe
                fila("nhaber") = lnhaber
            Else
                lndebe = fila("ndebe")
                lnhaber = fila("nhaber")

                lndebei = fila("ninidebe")
                lnhaberi = fila("ninihaber")

                lndebei2 = fila("ndebei")
                lnhaberi2 = fila("nhaberi")


            End If

            If lccodto.Trim = "D" Then
                pnSumdebe = Math.Round(pnSumdebe + lndebe, 2)
                pnSumhaber = Math.Round(pnSumhaber + lnhaber, 2)
            End If

            If fila("cnivel") = "01" Then
                fila("ccol") = "0"
            ElseIf fila("cnivel") = "02" Then
                fila("ccol") = "1"
            ElseIf fila("cnivel") = "03" Then
                fila("ccol") = "2"
            ElseIf fila("cnivel") = "04" Then
                fila("ccol") = "3"
            ElseIf fila("cnivel") = "05" Then
                fila("ccol") = "X"
            ElseIf fila("cnivel") = "06" Then
                fila("ccol") = "4"
            ElseIf fila("cnivel") = "08" Then
                fila("ccol") = "5"
            ElseIf fila("cnivel") = "10" Then
                fila("ccol") = "6"
            ElseIf fila("cnivel") = "12" Then
                fila("ccol") = "7"
            ElseIf fila("cnivel") = "14" Then
                fila("ccol") = "8"
            ElseIf fila("cnivel") = "16" Then
                fila("ccol") = "9"
            End If

            lnnivel = lccodcta.Trim.Length

            'If lnnivel > 1 Then
            If lccodcta.Substring(0, 1) = "1" Or lccodcta.Substring(0, 1) = "7" Or lccodcta.Substring(0, 1) = "8" Or lccodcta.Substring(0, 1) = "9" Then
                fila("nsalini") = lndebei + lndebei2 - lnhaberi - lnhaberi2
                fila("nsalfin") = Math.Round(fila("nsalini") + lndebe - lnhaber, 2)

            Else
                fila("nsalini") = lnhaberi + lnhaberi2 - lndebei - lndebei2
                fila("nsalfin") = Math.Round(fila("nsalini") + (lnhaber - lndebe), 2)


            End If


        Next

        Return ds
    End Function


    Public Sub ObtenerMayorizacion(ByVal ds As DataSet, ByVal ccodcta As String)
        Dim fila As DataRow
        Dim longitud As Integer
        longitud = ccodcta.Trim.Length
        pndebe = 0
        pnhaber = 0
        pndebei = 0
        pnhaberi = 0
        pndebei2 = 0
        pnhaberi2 = 0
        For Each fila In ds.Tables(0).Rows
            If ccodcta.Trim = Trim(fila("ccodcta")) Then
            Else
                If ccodcta.Trim = Left(fila("ccodcta"), longitud) Then
                    pndebe = pndebe + fila("ndebe")
                    pnhaber = pnhaber + fila("nhaber")

                    pndebei = pndebei + fila("ninidebe")
                    pnhaberi = pnhaberi + fila("ninihaber")

                    pndebei2 = pndebei2 + fila("ndebei")
                    pnhaberi2 = pnhaberi2 + fila("nhaberi")

                End If

            End If

            '            End If
        Next
    End Sub
    Public Function ObtieneSaldodelaCuenta(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Dim ecntamov As New cCntamov

    End Function
    Public Function EstructuraDataset() As DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lcnivel As String

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow
        Dim lccodcta As String


        lCampos1 = "cCodCta, dfeccnt, cnumcom , cnumlin, cpoliza, cdescrip, cglosa, ndebe, nhaber, cnumpol, nsalini,  nsaldo, dfecini, dfecfin, nsalacu,  "
        lTipos1 = "S,F,S,S,S,S,S,D,D,S,D,D,F,F,D,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        dsBal.Tables.Add(DT)

        Return dsBal
    End Function

    Public Function AgregarDataset(ByVal ds1 As DataSet, ByVal ds2 As DataSet) As DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lcnivel As String

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow
        Dim lccodcta As String


        'lCampos1 = "cCodCta, dfeccnt, cnumcom , cnumlin, cpoliza, cdescrip, cglosa, ndebe, nhaber, cnumpol, nsalini,  nsaldo, dfecini, dfecfin, nsalacu,  "
        'lTipos1 = "S, F, S, S, S, S, S, D, D, S, D,  D, F, F, D,"
        'DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")

        DT = ds1.Tables(0)

        For Each fila In ds2.Tables(0).Rows
            drcatalogo = DT.NewRow
            drcatalogo("cCodcta") = fila("ccodcta")
            drcatalogo("dfeccnt") = fila("dfeccnt")
            drcatalogo("cnumcom") = fila("cnumcom")
            drcatalogo("cnumlin") = fila("cnumlin")
            drcatalogo("cpoliza") = fila("cpoliza")
            drcatalogo("cdescrip") = fila("cdescrip")
            drcatalogo("cglosa") = fila("cglosa")
            drcatalogo("ndebe") = fila("ndebe")
            drcatalogo("nhaber") = fila("nhaber")
            drcatalogo("cnumpol") = fila("cnumpol")
            drcatalogo("nsalini") = fila("nsalini")
            drcatalogo("nsaldo") = fila("nsaldo")
            drcatalogo("dfecini") = fila("dfecini")
            drcatalogo("dfecfin") = fila("dfecfin")
            drcatalogo("nsalacu") = fila("nsalacu")

            DT.Rows.Add(drcatalogo)

            drcatalogo = DT.NewRow
            DT.Rows.Add(drcatalogo)

        Next

        'ds1.Tables.Add(DT)

        Return ds1
    End Function

    '---------------------------------------------------------------------------------------------
    Public Function GenComprobacionNivelPlusconAuxiliar(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal lctipo As String, ByVal cnivel As String, ByVal ccodcta1 As String, ByVal ccodcta2 As String) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim DT As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim ectbmcta As New ctbmcta
        Dim mctbmcta As New cCtbmcta
        Dim drcatalogo As DataRow
        Dim listacatalogo As New listactbmcta
        Dim i As Integer
        Dim lccodcta As String
        Dim lccodto As String
        Dim lcdescrip As String
        Dim lcnivel As String
        Dim lnsalini As Double
        Dim lnsalfin As Double
        Dim lnnivel As Integer
        Dim lngastos As Double
        Dim lningresos As Double
        Dim dr As DataRow
        Dim lnutilidad As Double

        Dim lntotsalini As Double
        Dim lntotsalfin As Double
        Dim lntotdebe As Double = 0
        Dim lntothaber As Double = 0
        Dim lnsalantgas As Double
        Dim lnsalanting As Double



        Dim ds1 As New DataSet
        Dim ecntaprm As New cCntaprm
        Dim ncanti As Integer

        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcyears = Me.pcyears
        lccadena = clssconta.cadena(Me.pcFuente, lcyears, Me.pcnomser)

        'ds1 = ecntaprm.ObtenerDataSetPorID(Me.pcFuente, lccadena)
        ds1 = ecntaprm.ObtenerDataSetPoryear(lcyears)
        ncanti = ds1.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim ldfecinicial As Date
        Dim ldfecfinal As Date
        ldfecinicial = ds1.Tables(0).Rows(0)("dFecimes")
        ldfecfinal = ds1.Tables(0).Rows(0)("dFecfmes")

        lngastos = 0
        lningresos = 0
        lnsalantgas = 0
        lnsalanting = 0
        Me.pnactivo = 0
        Me.pnpasivo = 0

        Me.pnDebeac = 0
        Me.pnHabereac = 0
        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, cflag, "
        lTipos1 = "S,S,S,S,D,D,D,D,S,S,"
        DT = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        Dim dsbalance As New DataSet
        Dim dsauxiliar As New DataSet

        dsbalance = GenerarPlusComprobacion(ldfecha1, ldfecha2, lctipo, cnivel, "*", "*")

        Dim lnsalfin1 As Double = 0
        Dim lnsalfin2 As Double = 0
        Dim lnsalinip As Double = 0
        i = 0
        Dim fila As DataRow
        Dim pasa As Integer = 1
        pndebe = pnSumdebe
        pnhaber = pnSumhaber
        pnsalini = 0
        pnsalfin = 0

        Dim dsoficina As New DataSet
        Dim dsfondos As New DataSet

        Dim etabtofi As New cTabtofi
        Dim etabttab As New cTabttab

        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        dsoficina = etabtofi.ObtenerDataSetPorID()

        Dim filafondo As DataRow
        Dim filaoficina As DataRow

        Dim lccodofi As String
        Dim lcfondo As String

        'Variables para auxiliares
        Dim lnsalini_aux As Double = 0
        Dim lnsalfin_aux As Double = 0
        Dim lndebe_aux As Double = 0
        Dim lnhaber_aux As Double = 0
        Dim lnsalfin1_aux As Double = 0

        Dim lcoficina As String = pcCodofi
        Dim lcfuente As String = pcFuente

        Dim filaaux As DataRow
        'mayorisa todas las cuentas del catalogo
        For Each fila In dsbalance.Tables(0).Rows
            pcCodofi = lcoficina
            pcFuente = lcfuente

            lccodcta = fila("ccodcta")
            lccodcta = lccodcta.Trim
            lnnivel = lccodcta.Trim.Length
            lccodto = fila("ccodto")


            If ccodcta1 = "*" And ccodcta2 = "*" Then
                pasa = 1

            Else
                If lccodcta.Trim >= ccodcta1.Trim And lccodcta.Trim <= ccodcta2.Trim Then
                    pasa = 1
                Else
                    pasa = 0
                End If
            End If
            If pasa = 1 Then
                If lnnivel > Integer.Parse(cnivel) Then
                Else

                    lcdescrip = fila("cdescrip")

                    lcnivel = fila("cnivel")
                    'obtiene saldo inicial antes de la fecha de inicio


                    drcatalogo = DT.NewRow
                    drcatalogo("cCodcta") = lccodcta
                    drcatalogo("cCodto") = lccodto
                    drcatalogo("cDescrip") = lcdescrip
                    drcatalogo("cnivel") = lcnivel
                    drcatalogo("nsalini") = fila("nsalini")

                    drcatalogo("nsalfin") = fila("nsalfin")
                    drcatalogo("ndebe") = fila("ndebe")
                    drcatalogo("nhaber") = fila("nhaber")

                    DT.Rows.Add(drcatalogo)

                    If lccodto.Trim = "D" Then
                        If fila("nsalini") = 0 And fila("nsalfin") = 0 And fila("ndebe") = 0 And fila("nhaber") = 0 Then
                        Else

                            '-----inicia proceso de oficina
                            For Each filaoficina In dsoficina.Tables(0).Rows
                                lccodofi = filaoficina("ccodofi")
                                Me.pcCodofi = lccodofi.Trim
                                Me.pcFuente = "00"
                                'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                                dsauxiliar = GenerarPlusComprobacion(ldfecha1, ldfecha2, lctipo, cnivel, lccodcta.Trim, lccodcta.Trim)
                                For Each filaaux In dsauxiliar.Tables(0).Rows

                                    'obtiene saldo inicial antes de la fecha de inicio


                                    drcatalogo = DT.NewRow
                                    drcatalogo("cCodcta") = lccodofi
                                    drcatalogo("cCodto") = lccodto
                                    drcatalogo("cDescrip") = Trim(filaoficina("cnomofi"))

                                    drcatalogo("cnivel") = lcnivel
                                    drcatalogo("nsalini") = filaaux("nsalini")

                                    drcatalogo("nsalfin") = filaaux("nsalfin")
                                    drcatalogo("ndebe") = filaaux("ndebe")
                                    drcatalogo("nhaber") = filaaux("nhaber")

                                    DT.Rows.Add(drcatalogo)

                                Next
                                'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

                                '----inicia proceso por fondo 
                                For Each filafondo In dsfondos.Tables(0).Rows
                                    lcfondo = filafondo("ccodigo")
                                    Me.pcFuente = lcfondo.Trim
                                    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                                    dsauxiliar = GenerarPlusComprobacion(ldfecha1, ldfecha2, lctipo, cnivel, lccodcta.Trim, lccodcta.Trim)
                                    For Each filaaux In dsauxiliar.Tables(0).Rows

                                        'obtiene saldo inicial antes de la fecha de inicio


                                        drcatalogo = DT.NewRow
                                        drcatalogo("cCodcta") = lcfondo
                                        drcatalogo("cCodto") = lccodto
                                        drcatalogo("cDescrip") = Trim(filafondo("cdescri"))

                                        drcatalogo("cnivel") = lcnivel
                                        drcatalogo("nsalini") = filaaux("nsalini")

                                        drcatalogo("nsalfin") = filaaux("nsalfin")
                                        drcatalogo("ndebe") = filaaux("ndebe")
                                        drcatalogo("nhaber") = filaaux("nhaber")

                                        DT.Rows.Add(drcatalogo)

                                    Next
                                    'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


                                Next    '----termina proceso por fondo
                            Next '----termina proceso de oficina
                        End If
                    End If
                End If

            End If

        Next

        dsBal.Tables.Add(DT)

        Return dsBal

    End Function

    Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String, ByVal sort As String) As DataTable

        Dim rows As DataRow()

        Dim dtNew As DataTable

        ' copy table structure
        dtNew = dt.Clone()

        ' sort and filter data
        rows = dt.Select(filter, sort)

        ' fill dtNew with selected rows

        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)

        Next

        ' return filtered dt
        Return dtNew

    End Function
    Public Function AnexaAuxiliares(ByVal dsbalance As DataSet) As DataSet
        Dim fila As DataRow
        Dim lningreso As Double = 0
        Dim lnegreso As Double = 0
        Dim ds As New DataSet

        Dim str As String


        Dim lnorden As Integer = 0
        Dim lccodcta As String
        For Each fila In dsbalance.Tables(0).Rows
            lccodcta = Trim(fila("ccodcta"))
            If Left(lccodcta.Trim, 1) = "1" Or Left(lccodcta.Trim, 1) = "2" Or Left(lccodcta.Trim, 1) = "3" Or Left(lccodcta.Trim, 1) = "4" _
            Or Left(lccodcta.Trim, 1) = "5" Then
                fila("nflag") = 1
                fila("cflag") = Left(lccodcta.Trim, 1)
                fila("norden") = lnorden
                fila("nnivel") = lccodcta.Trim.Length
                str = New String(Chr(32), lccodcta.Trim.Length)
                fila("cdescrip") = str + Trim(fila("cdescrip"))

                lnorden += 1
            Else
                fila("nflag") = 0
                If Left(lccodcta.Trim, 1) = "6" And Trim(fila("cnivel")) = "01" Then
                    lningreso = fila("nsalfin")
                End If
                If Left(lccodcta.Trim, 1) = "7" And Trim(fila("cnivel")) = "01" Then
                    lnegreso = fila("nsalfin")
                End If
            End If
        Next
        'Agregamos la utilidad o perdida del periodo-----x
        Dim dr As DataRow

        dr = dsbalance.Tables(0).NewRow()
        If Math.Round((lningreso - lnegreso), 2) >= 0 Then
            dr("norden") = "99999999"
            dr("cDescrip") = "UTILIDAD DEL PERIODO"
            dr("nsalfin") = Math.Round(lningreso - lnegreso, 2)
            dr("nflag") = 1
            dr("cflag") = "9"
            dr("nnivel") = 99
            dr("cnivel") = "99"
        Else
            dr("cDescrip") = "PERDIDA DEL PERIODO"
            dr("nsalfin") = Math.Round(lnegreso - lningreso, 2)
            dr("nflag") = 1
            dr("cflag") = "9"
            dr("norden") = "99999999"
            dr("nnivel") = 99
            dr("cnivel") = "99"
        End If

        dsbalance.Tables(0).Rows.Add(dr)





        '------------------------------------------------x
        Dim filtro As String = "nflag = 1 and cnivel <> '01'"

        'Declarando Arreglos
        Dim rows() As DataRow = Nothing
        Dim sortOrder As String = "nOrden ASC"


        Dim dt As DataTable = dsbalance.Tables(0)


        Dim dtNew As DataTable = dt.Clone()

        rows = dt.Select(filtro, sortOrder)


        'Insertara el datarow filtrado en un el dataset
        For Each drx As DataRow In rows
            dtNew.ImportRow(drx)
        Next

        ds.Tables.Add(dtNew)

        Return ds
    End Function
    Public Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable

        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next

        Return dtNew
    End Function
    Public Function AnexaAuxiliaresEstadoRestultados(ByVal dsbalance As DataSet) As DataSet
        Dim fila As DataRow
        Dim lningreso As Double = 0
        Dim lnegreso As Double = 0
        Dim ds As New DataSet

        Dim str As String


        Dim lnorden As Integer = 0
        Dim lccodcta As String
        For Each fila In dsbalance.Tables(0).Rows
            lccodcta = Trim(fila("ccodcta"))
            If Left(lccodcta.Trim, 1) = "6" Or Left(lccodcta.Trim, 1) = "7" Then
                fila("nflag") = 1
                fila("cflag") = Left(lccodcta.Trim, 1)
                fila("norden") = lnorden
                fila("nnivel") = lccodcta.Trim.Length
                str = New String(Chr(32), lccodcta.Trim.Length)
                fila("cdescrip") = str + Trim(fila("cdescrip"))
                lnorden += 1

            End If
        Next
        'Agregamos la utilidad o perdida del periodo-----x
        'Dim dr As DataRow

        'dr = dsbalance.Tables(0).NewRow()
        'If Math.Round((lningreso - lnegreso), 2) >= 0 Then
        '    dr("norden") = "99999999"
        '    dr("cDescrip") = "UTILIDAD DEL PERIODO"
        '    dr("nsalfin") = Math.Round(lningreso - lnegreso, 2)
        '    dr("nflag") = 1
        '    dr("cflag") = "9"
        '    dr("nnivel") = 99
        '    dr("cnivel") = "99"
        'Else
        '    dr("cDescrip") = "PERDIDA DEL PERIODO"
        '    dr("nsalfin") = Math.Round(lnegreso - lningreso, 2)
        '    dr("nflag") = 1
        '    dr("cflag") = "9"
        '    dr("norden") = "99999999"
        '    dr("nnivel") = 99
        '    dr("cnivel") = "99"
        'End If

        'dsbalance.Tables(0).Rows.Add(dr)





        '------------------------------------------------x
        Dim filtro As String = "nflag = 1 and cnivel <> '01'"

        'Declarando Arreglos
        Dim rows() As DataRow = Nothing
        Dim sortOrder As String = "nOrden ASC"


        Dim dt As DataTable = dsbalance.Tables(0)


        Dim dtNew As DataTable = dt.Clone()

        rows = dt.Select(filtro, sortOrder)


        'Insertara el datarow filtrado en un el dataset
        For Each drx As DataRow In rows
            dtNew.ImportRow(drx)
        Next

        ds.Tables.Add(dtNew)

        Return ds
    End Function
    Public Function NivelOfi(ByVal ds As DataSet, ByVal parametro As Integer) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim dt As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow

        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, nflag, cflag, norden, nnivel, ccodofi, ffondos, ccampo,"
        lTipos1 = "S,S,S,S,D,D,D,D,S,I,S,I,I,S,S,S,"
        dt = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        Dim fila As DataRow
        Dim lnnivel As Integer
        Dim lccodcta As String
        Dim dr As DataRow
        Dim etabtofi As New cTabtofi
        Dim lnflag As Integer = 0
        Dim dsdatos As New DataSet
        dsdatos = ds
        Dim str As String
        Dim lccodofi As String = ""
        str = New String(Chr(32), 7)




        Dim lnactivo As Double = 0
        Dim lnregularizadora As Double = 0
        Dim lnpasivo As Double = 0
        Dim lnutilidad As Double = 0
        Dim lncapital As Double = 0
        Dim lningreso As Double = 0
        Dim lnegreso As Double = 0

        For Each fila In ds.Tables(0).Rows

            If IsDBNull(fila("ccodcta")) Then
            Else
                If Left(fila("ccodcta"), 1) = "1" And fila("cnivel") = "02" Then
                    lnactivo = lnactivo + fila("nsalfin")
                End If
                If Left(fila("ccodcta"), 1) = "2" And fila("cnivel") = "02" Then
                    lnregularizadora = lnregularizadora + fila("nsalfin")
                End If
                If Left(fila("ccodcta"), 1) = "3" And fila("cnivel") = "02" Then
                    lnpasivo = lnpasivo + fila("nsalfin")
                End If
                If Left(fila("ccodcta"), 1) = "5" And fila("cnivel") = "02" Then
                    lncapital = lncapital + fila("nsalfin")
                End If

                If fila("ccodcta") = "21" And fila("cnivel") = "02" Then
                    drcatalogo = dt.NewRow()
                    drcatalogo("ccodcta") = ""
                    drcatalogo("cnivel") = "02"
                    drcatalogo("cdescrip") = "TOTAL DE ACTIVO"
                    drcatalogo("nsalfin") = lnactivo
                    drcatalogo("cflag") = "1"
                    dt.Rows.Add(drcatalogo)

                End If
                If fila("ccodcta") = "31" And fila("cnivel") = "02" Then
                    drcatalogo = dt.NewRow()
                    drcatalogo("ccodcta") = ""
                    drcatalogo("cnivel") = "02"
                    drcatalogo("cdescrip") = "TOTAL REGULADORAS DE ACTIVO"
                    drcatalogo("nsalfin") = lnregularizadora
                    drcatalogo("cflag") = "2"
                    dt.Rows.Add(drcatalogo)

                    drcatalogo = dt.NewRow()
                    drcatalogo("ccodcta") = ""
                    drcatalogo("cnivel") = "02"
                    drcatalogo("cdescrip") = "GRAN TOTAL DEL ACTIVO"
                    drcatalogo("nsalfin") = Math.Round((lnactivo - lnregularizadora), 2)
                    drcatalogo("cflag") = "2"
                    dt.Rows.Add(drcatalogo)
                End If
                If fila("ccodcta") = "41" And fila("cnivel") = "02" Then
                    drcatalogo = dt.NewRow()
                    drcatalogo("ccodcta") = ""
                    drcatalogo("cnivel") = "02"
                    drcatalogo("cdescrip") = "TOTAL DE PASIVO"
                    drcatalogo("nsalfin") = lnpasivo
                    drcatalogo("cflag") = "3"
                    dt.Rows.Add(drcatalogo)
                End If

                lccodcta = fila("ccodcta")
                lnnivel = lccodcta.Trim.Length

                'If lnnivel = 14 Then 'insertaremos nivel de oficina
                '    lnflag = 1
                'End If
                If lccodofi.Trim <> Trim(fila("ccodofi")) And lnflag = 0 And lnnivel = 14 Then
                    lnflag = 1
                End If

            End If
            If lnflag = 1 Then
                drcatalogo = dt.NewRow()
                drcatalogo("ccodcta") = fila("ccampo") + "-" + fila("ccodofi")
                drcatalogo("cnivel") = "10"
                drcatalogo("cdescrip") = str & etabtofi.NombreAgencia(fila("ccodofi"))
                drcatalogo("nsalfin") = ObtenerSaldo(dsdatos, lccodcta.Trim, fila("ccodofi"), 0)
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)

            End If

            If parametro = 0 Then
                If lnnivel = 14 Then
                Else
                    'Agregar campos a otro dataset
                    drcatalogo = dt.NewRow
                    drcatalogo("cCodcta") = fila("ccodcta")
                    drcatalogo("cDescrip") = str & fila("cdescrip")
                    drcatalogo("cnivel") = fila("cnivel")
                    drcatalogo("nsalini") = fila("nsalini")
                    drcatalogo("nsalfin") = fila("nsalfin")
                    drcatalogo("ndebe") = fila("ndebe")
                    drcatalogo("nhaber") = fila("nhaber")
                    drcatalogo("ccodofi") = fila("ccodofi")
                    drcatalogo("ffondos") = fila("ffondos")
                    drcatalogo("cflag") = fila("cflag")
                    dt.Rows.Add(drcatalogo)
                    '---------------------------------------

                End If
            Else
                'Agregar campos a otro dataset
                drcatalogo = dt.NewRow
                drcatalogo("cCodcta") = fila("ccodcta")
                drcatalogo("cDescrip") = str & fila("cdescrip")
                drcatalogo("cnivel") = fila("cnivel")
                drcatalogo("nsalini") = fila("nsalini")
                drcatalogo("nsalfin") = fila("nsalfin")
                drcatalogo("ndebe") = fila("ndebe")
                drcatalogo("nhaber") = fila("nhaber")
                drcatalogo("ccodofi") = fila("ccodofi")
                drcatalogo("ffondos") = fila("ffondos")
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)
                '---------------------------------------

            End If
            If fila("cnivel") = "99" Then
                drcatalogo = dt.NewRow
                drcatalogo("cCodcta") = fila("ccodcta")
                drcatalogo("cDescrip") = fila("cdescrip")
                drcatalogo("cnivel") = "02"
                drcatalogo("nsalini") = fila("nsalini")
                drcatalogo("nsalfin") = fila("nsalfin")
                drcatalogo("ndebe") = fila("ndebe")
                drcatalogo("nhaber") = fila("nhaber")
                drcatalogo("ccodofi") = fila("ccodofi")
                drcatalogo("ffondos") = fila("ffondos")
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)


                drcatalogo = dt.NewRow()
                drcatalogo("ccodcta") = ""
                drcatalogo("cnivel") = "02"
                drcatalogo("cdescrip") = "TOTAL CAPITAL"
                If Left(fila("cdescrip"), 7) = "PERDIDA" Then
                    fila("nsalfin") = Math.Round(fila("nsalfin") * (-1), 2)
                End If
                drcatalogo("nsalfin") = Math.Round(fila("nsalfin") + lncapital, 2)
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)

                drcatalogo = dt.NewRow()
                drcatalogo("ccodcta") = ""
                drcatalogo("cnivel") = "02"
                drcatalogo("cdescrip") = "TOTAL PASIVO + CAPITAL = ACTIVO "
                drcatalogo("nsalfin") = Math.Round(fila("nsalfin") + lncapital + lnpasivo, 2)
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)

            End If

            lccodofi = IIf(IsDBNull(fila("ccodofi")), "", fila("ccodofi"))
            lnflag = 0
        Next


        dsBal.Tables.Add(dt)

        Return dsBal
    End Function

    Public Function ObtenerSaldo(ByVal ds As DataSet, ByVal ccodcta As String, ByVal ccodofi As String, ByVal ncampo As Integer) As Double
        Dim lccodcta As String = Left(ccodcta, 7)
        Dim filtro As String = "ccampo =" & "'" & lccodcta & "'" & " and ccodofi = " & "'" & ccodofi & "'"

        'Declarando Arreglos
        Dim rows() As DataRow = Nothing
        Dim sortOrder As String = "ccodcta ASC"


        Dim dt As DataTable = ds.Tables(0)


        Dim dtNew As DataTable = dt.Clone()

        rows = dt.Select(filtro, sortOrder)


        'Insertara el datarow filtrado en un el dataset
        For Each drx As DataRow In rows
            dtNew.ImportRow(drx)
        Next

        Dim lnsaldo As Double = 0
        Dim fila As DataRow
        For Each fila In dtNew.Rows
            If ncampo = 0 Then
                lnsaldo = lnsaldo + fila("nsalfin")
            ElseIf ncampo = 1 Then
                lnsaldo = lnsaldo + fila("nsalini")
            ElseIf ncampo = 2 Then
                lnsaldo = lnsaldo + fila("nsaldo")
            End If

        Next

        Return lnsaldo
    End Function

    Public Function NivelOfiEstado(ByVal ds As DataSet, ByVal parametro As Integer) As DataSet

        Dim claseppal As New class1
        Dim dsBal As New DataSet
        Dim dt As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim drcatalogo As DataRow

        lCampos1 = "cCodCta, cDescrip, cCodto, cnivel, nsalini, ndebe, nhaber, nsalfin, ctipo, nflag, cflag, norden, nnivel, ccodofi, ffondos, ccampo,nsaldo,"
        lTipos1 = "S,S,S,S,D,D,D,D,S,I,S,I,I,S,S,S,D,"
        dt = claseppal.creadatasetdesconec(lCampos1, lTipos1, "balance")


        Dim fila As DataRow
        Dim lnnivel As Integer
        Dim lccodcta As String
        Dim dr As DataRow
        Dim etabtofi As New cTabtofi
        Dim lnflag As Integer = 0
        Dim dsdatos As New DataSet
        dsdatos = ds
        Dim str As String
        Dim lccodofi As String = ""
        str = New String(Chr(32), 7)

        For Each fila In ds.Tables(0).Rows


            If IsDBNull(fila("ccodcta")) Then
            Else

                lccodcta = fila("ccodcta")
                lnnivel = lccodcta.Trim.Length

                'If lnnivel = 14 Then 'insertaremos nivel de oficina
                '    lnflag = 1
                'End If
                If lccodofi.Trim <> Trim(fila("ccodofi")) And lnflag = 0 And lnnivel = 14 Then
                    lnflag = 1
                End If

            End If
            If lnflag = 1 Then
                drcatalogo = dt.NewRow()
                drcatalogo("ccodcta") = fila("ccampo") + "-" + fila("ccodofi")
                drcatalogo("cnivel") = "10"
                drcatalogo("cdescrip") = str & etabtofi.NombreAgencia(fila("ccodofi"))
                drcatalogo("nsalfin") = ObtenerSaldo(dsdatos, lccodcta.Trim, fila("ccodofi"), 0)
                drcatalogo("nsalini") = ObtenerSaldo(dsdatos, lccodcta.Trim, fila("ccodofi"), 1)
                drcatalogo("nsaldo") = ObtenerSaldo(dsdatos, lccodcta.Trim, fila("ccodofi"), 2)
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)

            End If

            If parametro = 0 Then
                If lnnivel = 14 Then
                Else
                    'Agregar campos a otro dataset
                    drcatalogo = dt.NewRow
                    drcatalogo("cCodcta") = fila("ccodcta")
                    drcatalogo("cDescrip") = str & fila("cdescrip")
                    drcatalogo("cnivel") = fila("cnivel")
                    drcatalogo("nsalini") = fila("nsalini")
                    drcatalogo("nsalfin") = fila("nsalfin")
                    drcatalogo("nsaldo") = fila("nsaldo")
                    '   drcatalogo("ndebe") = fila("ndebe")
                    '  drcatalogo("nhaber") = fila("nhaber")
                    drcatalogo("ccodofi") = fila("ccodofi")
                    drcatalogo("ffondos") = fila("ffondos")
                    drcatalogo("cflag") = fila("cflag")
                    dt.Rows.Add(drcatalogo)
                    '---------------------------------------

                End If
            Else
                'Agregar campos a otro dataset
                drcatalogo = dt.NewRow
                drcatalogo("cCodcta") = fila("ccodcta")
                drcatalogo("cDescrip") = str & fila("cdescrip")
                drcatalogo("cnivel") = fila("cnivel")
                drcatalogo("nsalini") = fila("nsalini")
                drcatalogo("nsalfin") = fila("nsalfin")
                drcatalogo("nsaldo") = fila("nsaldo")
                'drcatalogo("ndebe") = fila("ndebe")
                'drcatalogo("nhaber") = fila("nhaber")
                drcatalogo("ccodofi") = fila("ccodofi")
                drcatalogo("ffondos") = fila("ffondos")
                drcatalogo("cflag") = fila("cflag")
                dt.Rows.Add(drcatalogo)
                '---------------------------------------

            End If

            lccodofi = IIf(IsDBNull(fila("ccodofi")), "", fila("ccodofi"))
            lnflag = 0
        Next


        dsBal.Tables.Add(dt)

        Return dsBal
    End Function
    Public Function ObtenerSaldoFinal(ByVal ds As DataSet, ByVal ccodcta As String) As Double
        Dim lccodcta As String = Left(ccodcta, 7)
        Dim filtro As String = "ccodcta='" & ccodcta & "'"

        'Declarando Arreglos
        Dim rows() As DataRow = Nothing
        Dim sortOrder As String = "ccodcta ASC"


        Dim dt As DataTable = ds.Tables(0)


        Dim dtNew As DataTable = dt.Clone()

        rows = dt.Select(filtro, sortOrder)


        'Insertara el datarow filtrado en un el dataset
        For Each drx As DataRow In rows
            dtNew.ImportRow(drx)
        Next

        Dim lnsaldo As Double = 0
        Dim fila As DataRow
        For Each fila In dtNew.Rows
            lnsaldo = fila("nsalfin")
        Next

        Return lnsaldo

    End Function
    Public Function ObtieneMesaCerrar() As String
        Dim lcmes As String = ""
        Dim ecreditos As New dbCreditos
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet

        Using conneccion As New SqlConnection(ecreditos.CadenaActual)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select * from cnumes order by numes"
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Mes")
                For Each fila As DataRow In ds.Tables("Mes").Rows
                    If fila("cierre") = False Then
                        lcmes = fila("numes")
                        Exit For
                    End If
                Next
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return lcmes
    End Function
    Public Function ActualizarMesCerrado(ByVal numes As String) As Integer
        Dim ecreditos As New dbCreditos
        Dim command As New SqlCommand
        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(ecreditos.CadenaActual)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "update cnumes set cierre='1' where numes='" & numes & "'"
                command.ExecuteNonQuery()
                lnretorno = 1
            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using
        Return lnretorno
    End Function
    Public Function ValidaMesCierre(ByVal dfeccnt As Date) As Boolean
        'Obtiene mes de vigencia
        Dim ecntaprm As New cCntaprm
        Dim ds1 As New DataSet
        Dim lcyear As String
        ds1 = ecntaprm.ObtenerMestoClose("99")
        If ds1.Tables(0).Rows.Count = 0 Then
            Return False
        Else
            lcyear = Left(ds1.Tables(0).Rows(0)("cmesvig"), 4)
        End If
        If dfeccnt.Year < Integer.Parse(lcyear) Then
            Return False
        End If

        Dim ecreditos As New dbCreditos
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lvalida As Boolean = False
        Dim lnnum As String

        lnnum = CStr(Month(dfeccnt))

        If lnnum.Length = 1 Then
            lnnum = "0" & lnnum.Trim
        End If

        Using conneccion As New SqlConnection(ecreditos.CadenaActual)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select * from cnumes where cierre = 0 and numes='" & lnnum & "'"
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Mes")

                If ds.Tables("Mes").Rows.Count = 0 Then
                    'verifica si es año mayor
                    If dfeccnt.Year > Integer.Parse(lcyear) Then
                        lvalida = True
                    Else
                        lvalida = False
                    End If

                Else
                    lvalida = True
                End If

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using

        Return lvalida
    End Function
End Class
