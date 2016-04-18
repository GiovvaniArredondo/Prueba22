Imports System.Data.SqlClient
Public Class clsDesembolsa

#Region " Variables "
    Public cCuenta As String
    Private nCapita As Double
    Private ncapita1 As Double
    Private nDescuento As Double
    Private nComOtorg As Double
    Private nComEsc As Double
    Private nSegdeu As Double
    Private ncomision As Double
    Private nseguro As Double
    Private nHono As Double
    Private nDerIns As Double
    Private nIntere As Double
    Private nIntMor As Double
    Private nTota As Double
    Private nDesembolso As Double
    Private _gniva As Double
    Private cTipdes As String
    Public cBanco As String
    Public cOficina As String
    Public cGlosa As String
    Public cNrochq As String
    Public cnumrec As String
    Private cReg As String
    Private cCotacte As String
    Public cNomcli As String
    Private cTippag As String
    Public gdfecsis As Date
    Private gcCodUsu As String
    Private nKP As Double
    Public nCJ As Double
    Private cnrodoc As String
    Private cFlag As String
    Private ccodcta As String
    Private ctrasctb As Boolean
    Private nIVA As Double
    Private nflag As Integer
    Private ccodsol As String
    Private cnrodoc1 As String
    Private clsppal As New class1
#End Region

#Region " Propiedades "
    Public Property _nCapita1() As Double
        Get
            Return ncapita1
        End Get
        Set(ByVal Value As Double)
            ncapita1 = Value
        End Set
    End Property

    Public Property _cFlag() As String
        Get
            Return cFlag
        End Get
        Set(ByVal Value As String)
            cFlag = Value
        End Set
    End Property
    Public Property _cCodcta() As String
        Get
            Return ccodcta
        End Get
        Set(ByVal Value As String)
            ccodcta = Value
        End Set
    End Property
    Public Property _cCuenta() As String
        Get
            Return cCuenta
        End Get
        Set(ByVal Value As String)
            cCuenta = Value
        End Set
    End Property

    Public Property _nCapita() As Double
        Get
            Return nCapita
        End Get
        Set(ByVal Value As Double)
            nCapita = Value
        End Set
    End Property
    Public Property _nIntere() As Double
        Get
            Return nIntere
        End Get
        Set(ByVal Value As Double)
            nIntere = Value
        End Set
    End Property
    Public Property _nIntMor() As Double
        Get
            Return nIntMor
        End Get
        Set(ByVal Value As Double)
            nIntMor = Value
        End Set
    End Property
    Public Property _nTota() As Double
        Get
            Return nTota
        End Get
        Set(ByVal Value As Double)
            nTota = Value
        End Set
    End Property
    Public Property _nDescuento() As Double
        Get
            Return nDescuento
        End Get
        Set(ByVal Value As Double)
            nDescuento = Value
        End Set
    End Property
    Public Property _nKP() As Double
        Get
            Return nKP
        End Get
        Set(ByVal Value As Double)
            nKP = Value
        End Set
    End Property
    Public Property _nCJ() As Double
        Get
            Return nCJ
        End Get
        Set(ByVal Value As Double)
            nCJ = Value
        End Set
    End Property
    Public Property _nComEsc() As Double
        Get
            Return nComEsc
        End Get
        Set(ByVal Value As Double)
            nComEsc = Value
        End Set
    End Property
    Public Property _nSegDeu() As Double
        Get
            Return nSegdeu
        End Get
        Set(ByVal Value As Double)
            nSegdeu = Value
        End Set
    End Property
    Public Property _ncomision() As Double
        Get
            Return ncomision
        End Get
        Set(ByVal Value As Double)
            ncomision = Value
        End Set
    End Property
    Public Property _nseguro() As Double
        Get
            Return nseguro
        End Get
        Set(ByVal Value As Double)
            nseguro = Value
        End Set
    End Property
    Public Property _nHono() As Double
        Get
            Return nHono
        End Get
        Set(ByVal Value As Double)
            nHono = Value
        End Set
    End Property
    Public Property _nDerIns() As Double
        Get
            Return nDerIns
        End Get
        Set(ByVal Value As Double)
            nDerIns = Value
        End Set
    End Property

    Public Property _nDesembolso() As Double
        Get
            Return nDesembolso
        End Get
        Set(ByVal Value As Double)
            nDesembolso = Value
        End Set
    End Property
    Public Property _nComOtorg() As Double
        Get
            Return nComOtorg
        End Get
        Set(ByVal Value As Double)
            nComOtorg = Value
        End Set
    End Property
    Public Property _cTipdes() As String
        Get
            Return cTipdes
        End Get
        Set(ByVal Value As String)
            cTipdes = Value
        End Set
    End Property
    Public Property _cBanco() As String
        Get
            Return cBanco
        End Get
        Set(ByVal Value As String)
            cBanco = Value
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
    Public Property _cGlosa() As String
        Get
            Return cGlosa
        End Get
        Set(ByVal Value As String)
            cGlosa = Value
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
    Public Property _cNumrec() As String
        Get
            Return cnumrec
        End Get
        Set(ByVal Value As String)
            cnumrec = Value
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
    Public Property _cCotacte() As String
        Get
            Return cCotacte
        End Get
        Set(ByVal Value As String)
            cCotacte = Value
        End Set
    End Property
    Public Property _cNomcli() As String
        Get
            Return cNomcli
        End Get
        Set(ByVal Value As String)
            cNomcli = Value
        End Set
    End Property
    Public Property _cTippag() As String
        Get
            Return cTippag
        End Get
        Set(ByVal Value As String)
            cTippag = Value
        End Set
    End Property
    Public Property _gdfecsis() As Date
        Get
            Return gdfecsis
        End Get
        Set(ByVal Value As Date)
            gdfecsis = Value
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

    Public Property gniva() As Double
        Get
            Return _gniva
        End Get
        Set(ByVal value As Double)
            _gniva = value
        End Set
    End Property

    Public Property _cNrodoc() As String
        Get
            Return cnrodoc
        End Get
        Set(ByVal Value As String)
            cnrodoc = Value
        End Set
    End Property
    Public Property _ctrasctb() As Boolean
        Get
            Return ctrasctb
        End Get
        Set(ByVal Value As Boolean)
            ctrasctb = Value
        End Set
    End Property

    Public Property _nIVA() As Double
        Get
            Return nIVA
        End Get
        Set(ByVal Value As Double)
            nIVA = Value
        End Set
    End Property

    Public Property _nflag() As Integer
        Get
            Return nflag
        End Get
        Set(ByVal Value As Integer)
            nflag = Value
        End Set
    End Property

    Public Property _ccodsol() As String
        Get
            Return ccodsol
        End Get
        Set(ByVal value As String)
            ccodsol = value
        End Set
    End Property
#End Region

#Region " Metodos "
    Public Property _cNrodoc1() As String
        Get
            Return cnrodoc1
        End Get
        Set(ByVal Value As String)
            cnrodoc1 = Value
        End Set
    End Property

    Public Function Miembros() As DataSet

        Try


            Dim rs As New DataSet, dr As DataRow
            Dim dat_Refi As New DataTable("Refina")

            'Agregando la Encabezado de la Factura
            dat_Refi.Columns.Add("cCodcli", Type.GetType("System.String"))
            dat_Refi.Columns.Add("cNomcli", Type.GetType("System.String"))
            dat_Refi.Columns.Add("cnudoci", Type.GetType("System.String"))
            dat_Refi.Columns.Add("dfecnac", Type.GetType("System.DateTime"))

            rs.Tables.Add(dat_Refi)

            Return rs

        Catch ex As Exception

        End Try

    End Function



    Public Function CargaRefina() As DataSet

        Try


            Dim rs As New DataSet, dr As DataRow
            Dim dat_Refi As New DataTable("Refina")

            'Agregando la Encabezado de la Factura
            dat_Refi.Columns.Add("IdCuenta", Type.GetType("System.String"))
            dat_Refi.Columns.Add("nCapita", Type.GetType("System.Decimal"))
            dat_Refi.Columns.Add("nIntere", Type.GetType("System.Decimal"))
            dat_Refi.Columns.Add("nIntMor", Type.GetType("System.Decimal"))
            dat_Refi.Columns.Add("nTota", Type.GetType("System.Decimal"))
            dat_Refi.Columns.Add("nSegDeu", Type.GetType("System.Decimal"))
            dat_Refi.Columns.Add("nComision", Type.GetType("System.Decimal"))
            dat_Refi.Columns.Add("niva", Type.GetType("System.Decimal"))
            rs.Tables.Add(dat_Refi)

            Return rs

        Catch ex As Exception

        End Try

    End Function


    Public Function RealizaRefina() As Integer

        Dim lnRetorno As Integer = 1
        Dim ds_refi As New DataSet
        Dim ncanti As Integer
        Dim lcnomcli As String
        Dim lccodcli As String
        Dim lccodlin As String
        Dim lcnuming As String = "CANC/REFI"
        Dim lcnrodoc As String



        Try

            'Datos del Cliente
            Dim cCremRef As New SIM.EL.CremRef
            Dim eCremRef As New SIM.BL.cCremRef


            ds_refi = eCremRef.ObtenerDataSetEsp1(Me.cCuenta)

            ncanti = ds_refi.Tables(0).Rows.Count()

            If ncanti = 0 Then  'En caso que no devuelva nada se sale
                Exit Function
            End If


            Dim Fila As DataRow
            ncanti = 0

            For Each Fila In ds_refi.Tables(0).Rows
                lccodcli = ds_refi.Tables(0).Rows(ncanti)("ccodcli")
                lcnomcli = ds_refi.Tables(0).Rows(ncanti)("cnomcli")
                lccodlin = ds_refi.Tables(0).Rows(ncanti)("ccodlin")
                ncanti += 1
            Next


            'Inserta en la Cancela

            cCremRef.ccodcta = Me.cCuenta
            cCremRef.ccodcli = lccodcli
            cCremRef.ccodlin = lccodlin
            cCremRef.cnomcli = lcnomcli
            cCremRef.nsalcap = Me.nCapita
            cCremRef.nsalint = Me.nIntere
            cCremRef.nsalmor = Me.nIntMor
            cCremRef.nseguro = Me.nseguro
            cCremRef.nmanejo = Me.ncomision
            cCremRef.ntotal = Me.nTota
            cCremRef.ccodpre = Me.ccodcta
            cCremRef.dfecsis = Me.gdfecsis
            cCremRef.dfecpro = Today()
            cCremRef.ccodusu = Me.gcCodUsu
            cCremRef.ctabco = ""
            cCremRef.cnumchq = ""
            cCremRef.niva = Me.nIVA

            eCremRef.Agregar(cCremRef)

            'Inserta

            Dim cCredkar As New SIM.EL.credkar
            Dim eCredkar As New SIM.BL.cCredkar

            'Obtiene el numero de Documento
            lcnrodoc = eCredkar.obtenercnrodoc(Me.cCuenta)

            'IVA
            If Me.nIVA > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.nIVA
                cCredkar.cconcep = "10"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""

                eCredkar.agregarCredkar(cCredkar)

            End If



            'Seguro de deuda
            If Me.nseguro > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.nseguro
                cCredkar.cconcep = "11"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""

                eCredkar.agregarCredkar(cCredkar)

            End If

            'Comision
            If Me.ncomision > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.ncomision
                cCredkar.cconcep = "12"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""



                eCredkar.agregarCredkar(cCredkar)

            End If

            'Capital Refinanciado

            If Me.nCapita > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.nCapita
                cCredkar.cconcep = "KP"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""



                eCredkar.agregarCredkar(cCredkar)

            End If

            'Interes Refinanciado
            If Me.nIntere > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.nIntere
                cCredkar.cconcep = "IN"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""

                eCredkar.agregarCredkar(cCredkar)

            End If

            'Mora Refinanciado
            If Me.nIntMor > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.nIntMor
                cCredkar.cconcep = "MO"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""

                eCredkar.agregarCredkar(cCredkar)
            End If

            'Total Refinanciado
            If Me.nTota > 0 Then

                cCredkar.ccodcta = Me.cCuenta
                cCredkar.dfecpro = Me.gdfecsis
                cCredkar.dfecsis = Me.gdfecsis
                cCredkar.nmonto = Me.nTota
                cCredkar.cconcep = "CJ"
                cCredkar.ctippag = "C"
                cCredkar.cmoneda = "1"
                cCredkar.ccondic = "N"
                cCredkar.cdescob = "C"
                cCredkar.cnrodoc = lcnrodoc
                cCredkar.cnuming = lcnuming
                cCredkar.ccodusu = Me.gcCodUsu
                cCredkar.ccodofi = Me.cOficina
                cCredkar.dfecmod = Today()
                cCredkar.ctrasctb = Me.ctrasctb

                cCredkar.cnrocuo = "000"
                cCredkar.ccodins = Left(Me.cCuenta, 3)
                cCredkar.cestado = " "
                cCredkar.ctermid = " "
                cCredkar.cbanco = ""
                cCredkar.ccodctb = ""
                cCredkar.cflag = ""
                cCredkar.cclipag = ""
                cCredkar.cnomcta = ""
                cCredkar.cnumcta = ""
                cCredkar.crotativa = ""

                eCredkar.agregarCredkar(cCredkar)
            End If


            'Ahora lo cancelara de la cremcre

            Dim eCremcre As New SIM.EL.cremcre
            Dim bCremcre As New SIM.BL.cCremcre

            eCremcre.ccodcta = Me.cCuenta
            eCremcre.cestado = "G"
            eCremcre.ncappag = Me.nCapita
            eCremcre.nintpag = Me.nIntere
            eCremcre.nintmor = Me.nIntMor

            bCremcre.Actualizar1(eCremcre)

            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

    Public Function ChequeGrupal(ByVal cnumpar As String) As Integer
        'Inserta en la ctbdchq 
        Dim lnCJ As Double
        Dim pcBanco As String

        lnCJ = Me.nCJ
        pcBanco = Me.cBanco

        Dim entidadCtbdChq As New SIM.EL.ctbdchq
        Dim eCtbdchq As New SIM.BL.cCtbdchq
        Dim pcCotacte As String

        pcCotacte = Me.cCotacte



        entidadCtbdChq.cnumcom = cnumpar
        eCtbdchq.ObtenerCtbdchq(entidadCtbdChq)

        entidadCtbdChq.cnumcom = cnumpar
        entidadCtbdChq.cmonchq = lnCJ
        entidadCtbdChq.cnomchq = Me.cNomcli
        entidadCtbdChq.cnrochq = Me.cNrochq
        entidadCtbdChq.cnomcta = " "
        entidadCtbdChq.dfeccnt2 = Me.gdfecsis
        entidadCtbdChq.ccodbco = pcBanco 'Me.cmbBancos.SelectedItem.Text.Trim
        entidadCtbdChq.cflc = " "
        entidadCtbdChq.lprint = True
        entidadCtbdChq.ccoddeb = " "
        entidadCtbdChq.ccodhab = " "
        entidadCtbdChq.cctacte = pcCotacte
        entidadCtbdChq.ccodsol = Me.ccodsol
        eCtbdchq.Agregar(entidadCtbdChq)

    End Function

    Public Function Desembolso(ByVal cnumpar As String, ByVal ctipmet As String, ByVal bandera As Integer, ByVal bandera2 As Integer) As Integer


        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lnCuota As Double
        Dim lcNrolin As String
        Dim lcCondic As String
        Dim lcNorref As String
        Dim lcSececo As String
        Dim lnRetorno As Integer
        Dim lncapdes As Double = 0
        Dim lnmonapr As Double = 0
        Dim lngastos As Double = 0
        Dim lcnumrec As String = Me.cnumrec

        lcNumpar = cnumpar
        '-------------------------------------------------
        'Sacando las cuotas 
        '-------------------------------------------------

        cClase.pcoficina = Me.cOficina
        Try

            '-------------------------------------------------
            'Graba los cambios en la Maestra de Creditos
            '-------------------------------------------------
            Dim entidadCredtpl As New SIM.EL.credtpl
            Dim eCredtpl As New SIM.BL.cCredtpl
            Dim entidadCremcre As New SIM.EL.cremcre
            Dim ecreditos As New SIM.BL.cCremcre

            entidadCremcre.ccodcta = Me.cCuenta
            ecreditos.ObtenerCremcre(entidadCremcre)

            lcNrolin = entidadCremcre.cnrolin
            lcNorref = entidadCremcre.cnorref
            lcCondic = entidadCremcre.ccondic
            lcSececo = entidadCremcre.csececo
            'lnCuota = entidadCremcre.nmoncuo
            lnCuota = eCredtpl.CapitalInteres(Me.cCuenta)
            lnmonapr = entidadCremcre.nmonapr
            lncapdes = entidadCremcre.ncapdes
            lngastos = entidadCremcre.ngastos




            '          entidadCredtpl.ccodcta = Me.cCuenta
            '         entidadCredtpl.ctipope = "N"
            '        entidadCredtpl.cnrocuo = "001"

            '       eCredtpl.ObtenerCredtpl(entidadCredtpl)
            '      lnCuota = entidadCredtpl.ncapita + entidadCredtpl.nintere + entidadCredtpl.ngastos + entidadCredtpl.nsegdeu

            '>>>>>>>>Fecha Real  de Desembolso
            Dim ldfecDes As Date
            entidadCredtpl.ccodcta = Me.cCuenta
            entidadCredtpl.ctipope = "D"
            entidadCredtpl.cnrocuo = "001"
            eCredtpl.ObtenerCredtpl(entidadCredtpl)
            ldfecDes = entidadCredtpl.dfecven
            'Me.gdfecsis = ldfecDes
            If bandera2 = 0 Then


                entidadCremcre.ccodpag = Me.cBanco
                entidadCremcre.ncapdes = entidadCremcre.ncapdes + Me.nCapita
                entidadCremcre.ncapoto = entidadCremcre.ncapoto + Me.nCapita
                entidadCremcre.cestado = "F"
                entidadCremcre.dfecmod = Me.gdfecsis
                entidadCremcre.dfecvig = ldfecDes 'Me.gdfecsis
                entidadCremcre.nmoncuo = lnCuota
                entidadCremcre.cflag = " "
                entidadCremcre.ndiaatr = 0
                entidadCremcre.ndiaant = 0
                entidadCremcre.ccalif = "A"
                entidadCremcre.cnrodes = Me.cnrodoc.Trim
                entidadCremcre.ndeseje = 0

                If bandera = 0 Then
                    entidadCremcre.ngaspag = Me.nDescuento
                    entidadCremcre.ngastos = Me.nDescuento

                Else
                    entidadCremcre.ngaspag = lngastos
                    entidadCremcre.ngastos = lngastos
                End If

                ecreditos.ModificaCremcre(entidadCremcre)
                If bandera = 0 Then
                    If lncapdes > 0 Then
                    Else

                        '-----------------------------------------------
                        'Graba las cuotas en Credppg
                        '-----------------------------------------------
                        Dim ds As New DataSet
                        Dim ncanti As Integer
                        Dim entidadCredppg As New SIM.EL.credppg
                        Dim eCredppg As New SIM.BL.cCredppg

                        entidadCredppg.ccodcta = Me.cCuenta
                        entidadCredppg.ctipope = "N"
                        entidadCredppg.cnrocuo = "001"

                        '        eCredppg.ObtenerCredppg(entidadCredppg)

                        ds = eCredtpl.ObtenerDataSetPorID(Me.cCuenta)


                        ncanti = ds.Tables(0).Rows.Count()

                        If ncanti = 0 Then  'En caso que no devuelva nada se sale
                            Exit Function
                        End If


                        Dim Fila As DataRow
                        ncanti = 0

                        For Each Fila In ds.Tables(0).Rows
                            entidadCredppg.ccodcta = ds.Tables(0).Rows(ncanti)("ccodcta")
                            entidadCredppg.dfecven = ds.Tables(0).Rows(ncanti)("dfecven")
                            entidadCredppg.ctipope = ds.Tables(0).Rows(ncanti)("ctipope")
                            entidadCredppg.cnrocuo = ds.Tables(0).Rows(ncanti)("cnrocuo")
                            entidadCredppg.ncapita = ds.Tables(0).Rows(ncanti)("ncapita")
                            entidadCredppg.nintere = ds.Tables(0).Rows(ncanti)("nIntere") + ds.Tables(0).Rows(ncanti)("ngastos")
                            entidadCredppg.nsegdeu = ds.Tables(0).Rows(ncanti)("nsegdeu")
                            entidadCredppg.ngastos = 0
                            entidadCredppg.cflag = " "
                            If ncanti = 0 Then
                                entidadCredppg.cestado = "E"
                            Else
                                entidadCredppg.cestado = "N"
                            End If

                            'IIf(ncanti = 0, entidadCredppg.cestado = "E", entidadCredppg.cestado = "N")

                            entidadCredppg.dfecpag = Me.gdfecsis 'Hay que suplantarla por una fecha vacia

                            entidadCredppg.dfecmod = Me.gdfecsis
                            entidadCredppg.ccodusu = Me.gcCodUsu
                            entidadCredppg.ncappag = 0
                            entidadCredppg.nintpag = 0
                            entidadCredppg.nmorpag = 0
                            entidadCredppg.notrpag = 0

                            eCredppg.Agregar(entidadCredppg)
                            ncanti = ncanti + 1
                        Next

                        ds.Tables.Clear()

                    End If
                End If
            End If
            '---------------------------------------------------
            'Graba Desembolso en Credkar,cntamov,ctbdchq,Diario
            '---------------------------------------------------
            Dim entidadCretlin As New SIM.EL.cretlin
            Dim eCretlin As New SIM.BL.cCretlin
            Dim lcCodlin As String
            Dim pcBanco As String
            Dim lccuenta As String
            Dim lnComOtorg As Double
            Dim lniva As Double
            Dim lnComEsc As Double
            Dim lnSedDeu As Double
            Dim lnHono As Double
            Dim lnDerIns As Double
            Dim lcTipdes As String
            Dim lnum As Integer = 1
            Dim lnKP As Double
            Dim lnCJ As Double


            lcTipdes = Me.cTipdes

            'Comisiones
            lnComOtorg = Me.nComOtorg 'Comision por Otorgamiento
            lniva = Me.nIVA
            lnComEsc = Me.nComEsc 'Comision por Escrituracion
            lnSedDeu = Me.nSegdeu 'Seguro de Deuda
            lnHono = Me.nHono  'Honorarios por Servicios
            lnDerIns = Me.nDerIns 'Derechos de Inscripcion
            lnKP = Me.nCapita
            lnCJ = Me.nCJ


            'Obtien el cCodlin 
            entidadCretlin.cnrolin = lcNrolin
            eCretlin.ObtenerCretlin(entidadCretlin)
            lcCodlin = entidadCretlin.ccodlin
            pcBanco = Me.cBanco


            '------------------------------------
            'Obteniendo las cuenta Contable 
            '------------------------------------
            '  lcNumpar = cClase.fxStevo() 'Numero de Partida

            'KP
            'If lnKP > 0 Then


            '-------------------------
            'Inserta en la Diario
            '-------------------------

            If Me.nflag = 1 Then
                Dim entidadDiario As New SIM.EL.diario
                Dim eDiario As New SIM.BL.cDiario

                entidadDiario.cnumcom = lcNumpar
                eDiario.ObtenerDiario(entidadDiario)

                entidadDiario.cnumcom = lcNumpar
                entidadDiario.ccodofi = Me.cOficina
                entidadDiario.ctipasi = "012"
                entidadDiario.ctipmon = "1"
                entidadDiario.cglosa = Me.cGlosa
                entidadDiario.cnumdoc = Me.cNrochq
                entidadDiario.ccodreg = Me.cReg
                entidadDiario.ccodrev = " "
                entidadDiario.ccodruc = " "
                entidadDiario.dfeccnt = Me.gdfecsis
                entidadDiario.dfecdoc = Me.gdfecsis
                entidadDiario.dfecmod = Me.gdfecsis
                entidadDiario.ffondos = lcCodlin.Substring(2, 2)
                entidadDiario.ccodusu = Me.gcCodUsu
                entidadDiario.cestado = " "
                entidadDiario.cfv = " "
                entidadDiario.nccompra = 0
                entidadDiario.ncventa = 0
                entidadDiario.nfln = 0
                entidadDiario.ntcfijo = 0
                'entidadDiario.ccodemp = " "
                entidadDiario.cnrodoc = " "

                eDiario.agregarDiario(entidadDiario)
            End If

            'Inserta en la ctbdchq 
            If ctipmet = "0" And lcTipdes.Trim <> "E" Then
                Dim entidadCtbdChq As New SIM.EL.ctbdchq
                Dim eCtbdchq As New SIM.BL.cCtbdchq
                Dim pcCotacte As String

                pcCotacte = Me.cCotacte

                entidadCtbdChq.cnumcom = lcNumpar
                eCtbdchq.ObtenerCtbdchq(entidadCtbdChq)

                entidadCtbdChq.cnumcom = lcNumpar
                entidadCtbdChq.cmonchq = lnCJ
                entidadCtbdChq.cnomchq = Me.cNomcli
                entidadCtbdChq.cnrochq = Me.cNrochq
                entidadCtbdChq.cnomcta = " "
                entidadCtbdChq.dfeccnt2 = Me.gdfecsis
                entidadCtbdChq.ccodbco = pcBanco 'Me.cmbBancos.SelectedItem.Text.Trim
                entidadCtbdChq.cflc = " "
                entidadCtbdChq.lprint = True
                entidadCtbdChq.ccoddeb = " "
                entidadCtbdChq.ccodhab = " "
                entidadCtbdChq.cctacte = pcCotacte
                entidadCtbdChq.ccodsol = Me.ccodsol


                eCtbdchq.Agregar(entidadCtbdChq)
                GrabaenAuxiliar(lcNumpar, "A")

            End If

            'Inserta en la Credkar
            'Cuenta Contable de Capital
            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "KP", "D", lcCondic, lcTipdes, pcBanco, lnKP, 0, 0)

            Dim entidadKardex As New SIM.EL.credkar
            Dim eKardex As New SIM.BL.cCredkar

            entidadKardex.ccodcta = Me.cCuenta
            eKardex.ObtenerCredkar(entidadKardex)

            entidadKardex.ccodcta = Me.cCuenta
            entidadKardex.dfecpro = Me.gdfecsis
            entidadKardex.dfecsis = Me.gdfecsis
            entidadKardex.cnrocuo = "001"
            'entidadKardex.nmonto = lnKP
            entidadKardex.nmonto = Me.ncapita1 'lnKP
            entidadKardex.ccodins = Me.cReg
            entidadKardex.ccodofi = Me.cOficina
            entidadKardex.ctippag = Me.cTippag
            entidadKardex.cestado = " "
            entidadKardex.ctermid = " "
            entidadKardex.cnrodoc = Me.cnrodoc
            entidadKardex.ccodusu = Me.gcCodUsu
            entidadKardex.dfecmod = Me.gdfecsis
            entidadKardex.cmoneda = " "
            entidadKardex.ccondic = lcCondic
            entidadKardex.cconcep = "KP"
            entidadKardex.cdescob = "D"
            entidadKardex.cnuming = Me.cNrochq
            entidadKardex.cbanco = " "
            entidadKardex.ccodctb = lccuenta
            entidadKardex.ctrasctb = True
            entidadKardex.cflag = "1"
            entidadKardex.cclipag = " "
            entidadKardex.cnomcta = " "
            entidadKardex.cnumcta = " "
            entidadKardex.crotativa = " "
            entidadKardex.ndiaatr = 0
            entidadKardex.cnuming0 = lcnumrec
            'entidadKardex.cnuming = ""


            eKardex.agregarCredkar(entidadKardex)

            'Inserta en la Cntamov

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            entidadCntamov.cnumcom = lcNumpar
            eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = lcNumpar
            entidadCntamov.ccodsec = lcSececo
            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            entidadCntamov.cnumlin = lnum
            entidadCntamov.ccodcta = lccuenta
            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            'entidadCntamov.ndebe = lnKP
            entidadCntamov.ndebe = Me.ncapita1 'lnKP 
            entidadCntamov.nhaber = 0
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cNrochq
            entidadCntamov.dfeccnt = Me.gdfecsis
            entidadCntamov.dfecmod = Me.gdfecsis
            entidadCntamov.ccodpres = Me.cCuenta
            entidadCntamov.cconcepto = Me.cGlosa
            entidadCntamov.cpoliza = "EG"
            entidadCntamov.ccodofi = Me.cOficina
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = Me.cReg
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.gcCodUsu

            eCntamov.agregarCntamov(entidadCntamov)

            lnum += 1
            'End If






            '----------------------------------------------------------------------
            'Insercion del Refinanciamiento Inserta el Capital Interes y Mora, seguro y comision
            'Solo se hara el asiento contable
            '----------------------------------------------------------------------
            Dim x As Integer
            Dim entidadCremref As New SIM.EL.CremRef
            Dim eCremref As New SIM.BL.cCremRef
            Dim ds_ref As New DataSet
            Dim lccodcta As String
            Dim lnsalcap As Double
            Dim lnsalint As Double
            Dim lnsalmor As Double
            Dim lnsegdeu As Double
            Dim lncomision As Double
            Dim lnseguro As Double
            Dim lnivar As Double = 0


            ds_ref = eCremref.ObtenerDataSetEsp2(Me.cCuenta)


            x = ds_ref.Tables(0).Rows.Count()

            If x = 0 Then  'En caso que no devuelva nada se sale
                '  Exit Function
            Else 'Actualiza campo cNorref R= Refinanciado(Novado)
                Actualiza_cNorref(Me.cCuenta, "R")
            End If

            Dim lncreref As Integer

            Dim lnsalcap0 As Double = 0
            Dim lnsalint0 As Double = 0
            Dim lnsalmor0 As Double = 0
            Dim lnsegdeu0 As Double = 0
            Dim lncomision0 As Double = 0
            Dim lnseguro0 As Double = 0
            Dim lnivar0 As Double = 0

            lncreref = x - 1

            x = 0
            If bandera2 = 0 Then


                If bandera = 0 Then

                    Dim fila As DataRow

                    For Each fila In ds_ref.Tables(0).Rows
                        lccodcta = ds_ref.Tables(0).Rows(x)("cCodpre")
                        lnsalcap = ds_ref.Tables(0).Rows(x)("nsalcap")
                        lnsalint = ds_ref.Tables(0).Rows(x)("nsalint")
                        lnsalmor = ds_ref.Tables(0).Rows(x)("nsalmor")
                        lcCodlin = ds_ref.Tables(0).Rows(x)("ccodlin")
                        lnseguro = ds_ref.Tables(0).Rows(x)("nseguro")
                        lncomision = ds_ref.Tables(0).Rows(x)("nmanejo")
                        lnivar = ds_ref.Tables(0).Rows(x)("niva")

                        lnsalcap0 = lnsalcap0 + lnsalcap
                        lnsalint0 = lnsalint0 + lnsalint
                        lnsalmor0 = lnsalmor0 + lnsalmor
                        lnseguro0 = lnseguro0 + lnseguro
                        lncomision0 = lncomision0 + lncomision
                        lnivar0 = lnivar0 + lnivar

                        '--------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        If lnivar > 0 Or lnivar0 > 0 Then
                            'Cuenta Contable de Interes Moratorio Refinanciado

                            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "IV", "D", lcCondic, lcTipdes, pcBanco, lnivar, 0, 0)
                            If lnivar0 > 0 And lncreref = x Then
                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lnivar0
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = lcCondic
                                entidadKardex.cconcep = "IV"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lccuenta
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "9"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '   entidadKardex.cnuming = ""

                                eKardex.agregarCredkar(entidadKardex)
                            End If
                            'Inserta en la Cntamov

                            entidadCntamov.cnumcom = lcNumpar
                            eCntamov.ObtenerCntamov(entidadCntamov)

                            entidadCntamov.cnumcom = lcNumpar
                            entidadCntamov.ccodsec = lcSececo
                            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                            entidadCntamov.cnumlin = lnum
                            entidadCntamov.ccodcta = lccuenta
                            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                            entidadCntamov.ndebe = 0
                            entidadCntamov.nhaber = lnivar
                            entidadCntamov.cflc = " "
                            entidadCntamov.nfln = 0
                            entidadCntamov.cnumdoc = Me.cNrochq
                            entidadCntamov.dfeccnt = Me.gdfecsis
                            entidadCntamov.dfecmod = Me.gdfecsis
                            entidadCntamov.ccodpres = Me.cCuenta
                            entidadCntamov.cconcepto = "IVA DE REFINANCIAMIENTO"
                            entidadCntamov.cpoliza = "EG"
                            entidadCntamov.ccodofi = Me.cOficina
                            entidadCntamov.cnumpol = " "
                            entidadCntamov.ccodreg = Me.cReg
                            entidadCntamov.ccodcli = " "
                            entidadCntamov.ccodusu1 = Me.gcCodUsu

                            eCntamov.agregarCntamov(entidadCntamov)
                            lnum += 1
                        End If


                        '---------------------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                        If lnsalcap > 0 Or lnsalcap0 > 0 Then    'Capital Refinanciado

                            'Cuenta Contable de Capital Refinanciado

                            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "KR", "D", lcCondic, lcTipdes, pcBanco, lnsalcap, 0, 0)

                            If lnsalcap0 > 0 And lncreref = x Then
                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lnsalcap0 'lnsalcap
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = lcCondic
                                entidadKardex.cconcep = "KR"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lccuenta
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "7"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '      entidadKardex.cnuming = ""

                                eKardex.agregarCredkar(entidadKardex)
                            End If

                            'Inserta en la Cntamov

                            entidadCntamov.cnumcom = lcNumpar
                            eCntamov.ObtenerCntamov(entidadCntamov)

                            entidadCntamov.cnumcom = lcNumpar
                            entidadCntamov.ccodsec = lcSececo
                            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                            entidadCntamov.cnumlin = lnum
                            entidadCntamov.ccodcta = lccuenta
                            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                            entidadCntamov.ndebe = 0
                            entidadCntamov.nhaber = lnsalcap
                            entidadCntamov.cflc = " "
                            entidadCntamov.nfln = 0
                            entidadCntamov.cnumdoc = Me.cNrochq
                            entidadCntamov.dfeccnt = Me.gdfecsis
                            entidadCntamov.dfecmod = Me.gdfecsis
                            entidadCntamov.ccodpres = Me.cCuenta
                            entidadCntamov.cconcepto = "CAPITAL REFINANCIADO"
                            entidadCntamov.cpoliza = "EG"
                            entidadCntamov.ccodofi = Me.cOficina
                            entidadCntamov.cnumpol = " "
                            entidadCntamov.ccodreg = Me.cReg
                            entidadCntamov.ccodcli = " "
                            entidadCntamov.ccodusu1 = Me.gcCodUsu

                            eCntamov.agregarCntamov(entidadCntamov)
                            lnum += 1

                        End If
                        Dim lnintprov As Double = 0
                        Dim lnAbono As Double = 0
                        If lnsalint > 0 Then    'Interes Refinanciado    

                            'Cuenta Contable de Interes Refinanciado

                            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "IR", "D", lcCondic, lcTipdes, pcBanco, lnsalint, 0, 0)

                            Dim clsppal As New class1
                            lnintprov = clsppal.fxIntPro(Me.cCuenta, lnsalint, Me.cnrodoc)
                            If lnintprov > 0 Then 'Agrega el interes provisionado
                                Dim lnIntAct As Double = 0
                                lnIntAct = lnintprov
                                Dim lcctactbprov As String
                                lcctactbprov = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", "IN", "C", "P", lcTipdes, pcBanco, lnsalint, 0, 0)


                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lnintprov
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = "P"
                                entidadKardex.cconcep = "IR"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lcctactbprov
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "8"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '     entidadKardex.cnuming = ""


                                eKardex.agregarCredkar(entidadKardex)

                                'Inserta en la Cntamov

                                entidadCntamov.cnumcom = lcNumpar
                                eCntamov.ObtenerCntamov(entidadCntamov)

                                entidadCntamov.cnumcom = lcNumpar
                                entidadCntamov.ccodsec = lcSececo
                                entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                                entidadCntamov.cnumlin = lnum
                                entidadCntamov.ccodcta = lcctactbprov
                                entidadCntamov.cclase = lcctactbprov.Substring(0, 1).Trim
                                entidadCntamov.ndebe = 0
                                entidadCntamov.nhaber = lnintprov
                                entidadCntamov.cflc = " "
                                entidadCntamov.nfln = 0
                                entidadCntamov.cnumdoc = Me.cNrochq
                                entidadCntamov.dfeccnt = Me.gdfecsis
                                entidadCntamov.dfecmod = Me.gdfecsis
                                entidadCntamov.ccodpres = Me.cCuenta
                                entidadCntamov.cconcepto = "PAGO DE INTERES PROVISIONADO REFINANCIADO"
                                entidadCntamov.cpoliza = "EG"
                                entidadCntamov.ccodofi = Me.cOficina
                                entidadCntamov.cnumpol = " "
                                entidadCntamov.ccodreg = Me.cReg
                                entidadCntamov.ccodcli = " "
                                entidadCntamov.ccodusu1 = Me.gcCodUsu

                                eCntamov.agregarCntamov(entidadCntamov)
                                lnum += 1



                            End If

                            '----
                            'Interes No Provisionado

                            lnAbono = lnsalint
                            lnAbono = IIf((lnAbono - lnintprov) > 0, (lnAbono - lnintprov), 0)

                            If lnAbono > 0 Then
                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lnAbono
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = "N"
                                entidadKardex.cconcep = "IR"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lccuenta
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "8"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '     entidadKardex.cnuming = ""


                                eKardex.agregarCredkar(entidadKardex)

                                'Inserta en la Cntamov

                                entidadCntamov.cnumcom = lcNumpar
                                eCntamov.ObtenerCntamov(entidadCntamov)

                                entidadCntamov.cnumcom = lcNumpar
                                entidadCntamov.ccodsec = lcSececo
                                entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                                entidadCntamov.cnumlin = lnum
                                entidadCntamov.ccodcta = lccuenta
                                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                                entidadCntamov.ndebe = 0
                                entidadCntamov.nhaber = lnAbono
                                entidadCntamov.cflc = " "
                                entidadCntamov.nfln = 0
                                entidadCntamov.cnumdoc = Me.cNrochq
                                entidadCntamov.dfeccnt = Me.gdfecsis
                                entidadCntamov.dfecmod = Me.gdfecsis
                                entidadCntamov.ccodpres = Me.cCuenta
                                entidadCntamov.cconcepto = "PAGO DE INTERES PROVISIONADO REFINANCIADO"
                                entidadCntamov.cpoliza = "EG"
                                entidadCntamov.ccodofi = Me.cOficina
                                entidadCntamov.cnumpol = " "
                                entidadCntamov.ccodreg = Me.cReg
                                entidadCntamov.ccodcli = " "
                                entidadCntamov.ccodusu1 = Me.gcCodUsu

                                eCntamov.agregarCntamov(entidadCntamov)
                                lnum += 1


                            End If


                            'If lnsalint0 > 0 And lncreref = x Then
                            'End If

                        End If


                        If lnsalmor > 0 Or lnsalmor0 > 0 Then    'Mora Refinanciada
                            'Cuenta Contable de Interes Moratorio Refinanciado

                            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "MR", "D", lcCondic, lcTipdes, pcBanco, lnsalmor, 0, 0)
                            If lnsalmor0 > 0 And lncreref = x Then
                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lnsalmor0
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = lcCondic
                                entidadKardex.cconcep = "MR"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lccuenta
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "9"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '    entidadKardex.cnuming = ""

                                eKardex.agregarCredkar(entidadKardex)
                            End If
                            'Inserta en la Cntamov

                            entidadCntamov.cnumcom = lcNumpar
                            eCntamov.ObtenerCntamov(entidadCntamov)

                            entidadCntamov.cnumcom = lcNumpar
                            entidadCntamov.ccodsec = lcSececo
                            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                            entidadCntamov.cnumlin = lnum
                            entidadCntamov.ccodcta = lccuenta
                            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                            entidadCntamov.ndebe = 0
                            entidadCntamov.nhaber = lnsalmor
                            entidadCntamov.cflc = " "
                            entidadCntamov.nfln = 0
                            entidadCntamov.cnumdoc = Me.cNrochq
                            entidadCntamov.dfeccnt = Me.gdfecsis
                            entidadCntamov.dfecmod = Me.gdfecsis
                            entidadCntamov.ccodpres = Me.cCuenta
                            entidadCntamov.cconcepto = "MORA DE REFINANCIAMIENTO"
                            entidadCntamov.cpoliza = "EG"
                            entidadCntamov.ccodofi = Me.cOficina
                            entidadCntamov.cnumpol = " "
                            entidadCntamov.ccodreg = Me.cReg
                            entidadCntamov.ccodcli = " "
                            entidadCntamov.ccodusu1 = Me.gcCodUsu

                            eCntamov.agregarCntamov(entidadCntamov)
                            lnum += 1
                        End If

                        If lnseguro > 0 Or lnseguro0 > 0 Then
                            'Cuenta Contable de seguro de deuda

                            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "SD", "D", lcCondic, lcTipdes, pcBanco, lnseguro, 0, 0)
                            If lnseguro0 > 0 And lncreref = x Then
                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lnseguro0
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = lcCondic
                                entidadKardex.cconcep = "SD"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lccuenta
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "9"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '   entidadKardex.cnuming = ""

                                eKardex.agregarCredkar(entidadKardex)
                            End If
                            'Inserta en la Cntamov

                            entidadCntamov.cnumcom = lcNumpar
                            eCntamov.ObtenerCntamov(entidadCntamov)

                            entidadCntamov.cnumcom = lcNumpar
                            entidadCntamov.ccodsec = lcSececo
                            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                            entidadCntamov.cnumlin = lnum
                            entidadCntamov.ccodcta = lccuenta
                            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                            entidadCntamov.ndebe = 0
                            entidadCntamov.nhaber = lnseguro
                            entidadCntamov.cflc = " "
                            entidadCntamov.nfln = 0
                            entidadCntamov.cnumdoc = Me.cNrochq
                            entidadCntamov.dfeccnt = Me.gdfecsis
                            entidadCntamov.dfecmod = Me.gdfecsis
                            entidadCntamov.ccodpres = Me.cCuenta
                            entidadCntamov.cconcepto = "SEGURO DE REFINANCIAMIENTO"
                            entidadCntamov.cpoliza = "EG"
                            entidadCntamov.ccodofi = Me.cOficina
                            entidadCntamov.cnumpol = " "
                            entidadCntamov.ccodreg = Me.cReg
                            entidadCntamov.ccodcli = " "
                            entidadCntamov.ccodusu1 = Me.gcCodUsu

                            eCntamov.agregarCntamov(entidadCntamov)
                            lnum += 1
                        End If
                        If lncomision > 0 Or lncomision0 > 0 Then
                            'Cuenta Contable de Interes Moratorio Refinanciado

                            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CO", "D", lcCondic, lcTipdes, pcBanco, lnsalmor, 0, 0)
                            If lncomision0 > 0 And lncreref = x Then
                                'Inserta en la credkar
                                entidadKardex.ccodcta = Me.cCuenta
                                entidadKardex.dfecpro = Me.gdfecsis
                                entidadKardex.dfecsis = Me.gdfecsis
                                entidadKardex.cnrocuo = "001"
                                entidadKardex.nmonto = lncomision0
                                entidadKardex.ccodins = Me.cReg
                                entidadKardex.ccodofi = Me.cOficina
                                entidadKardex.ctippag = Me.cTippag
                                entidadKardex.cestado = " "
                                entidadKardex.ctermid = " "
                                entidadKardex.cnrodoc = Me.cnrodoc
                                entidadKardex.ccodusu = Me.gcCodUsu
                                entidadKardex.dfecmod = Me.gdfecsis
                                entidadKardex.cmoneda = " "
                                entidadKardex.ccondic = lcCondic
                                entidadKardex.cconcep = "CO"
                                entidadKardex.cdescob = "D"
                                entidadKardex.cnuming = Me.cNrochq
                                entidadKardex.cbanco = " "
                                entidadKardex.ccodctb = lccuenta
                                entidadKardex.ctrasctb = True
                                entidadKardex.cflag = "9"
                                entidadKardex.cclipag = " "
                                entidadKardex.cnomcta = " "
                                entidadKardex.cnumcta = " "
                                entidadKardex.crotativa = " "
                                entidadKardex.ndiaatr = 0
                                entidadKardex.cnuming0 = lcnumrec
                                '  entidadKardex.cnuming = ""

                                eKardex.agregarCredkar(entidadKardex)
                            End If
                            'Inserta en la Cntamov

                            entidadCntamov.cnumcom = lcNumpar
                            eCntamov.ObtenerCntamov(entidadCntamov)

                            entidadCntamov.cnumcom = lcNumpar
                            entidadCntamov.ccodsec = lcSececo
                            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                            entidadCntamov.cnumlin = lnum
                            entidadCntamov.ccodcta = lccuenta
                            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                            entidadCntamov.ndebe = 0
                            entidadCntamov.nhaber = lncomision
                            entidadCntamov.cflc = " "
                            entidadCntamov.nfln = 0
                            entidadCntamov.cnumdoc = Me.cNrochq
                            entidadCntamov.dfeccnt = Me.gdfecsis
                            entidadCntamov.dfecmod = Me.gdfecsis
                            entidadCntamov.ccodpres = Me.cCuenta
                            entidadCntamov.cconcepto = "MANEJO DE REFINANCIAMIENTO"
                            entidadCntamov.cpoliza = "EG"
                            entidadCntamov.ccodofi = Me.cOficina
                            entidadCntamov.cnumpol = " "
                            entidadCntamov.ccodreg = Me.cReg
                            entidadCntamov.ccodcli = " "
                            entidadCntamov.ccodusu1 = Me.gcCodUsu

                            eCntamov.agregarCntamov(entidadCntamov)
                            lnum += 1
                        End If
                        x += 1
                    Next
                End If
            End If
            '-------------------------------------------------------------------
            'Fin 
            '-------------------------------------------------------------------

            entidadCntamov.cconcepto = Me.cGlosa

            '----------------------------------------------------------------------Barrera Cargos



            Dim dsg As New DataSet
            Dim ecredgas As New cCredgas
            dsg = ecredgas.CargaGastos(Me.cCuenta, "D", Me.cnrodoc)


            Dim arrayd As New ArrayList
            Dim lnMongas As Double = 0

            arrayd.Add(0)  '01
            arrayd.Add(0)  'Iva 01

            If Not IsDBNull(dsg.Tables(0).Compute("sum(nmongas)", "ctipgas in('01')")) Then
                arrayd.Item(0) = dsg.Tables(0).Compute("sum(nmongas)", "ctipgas in('01')")
                arrayd.Item(1) = arrayd.Item(0) - Math.Round(arrayd.Item(0) / Me._gniva, 2)
                arrayd.Item(1) = Math.Round(arrayd.Item(1), 2)
            End If


            If arrayd.Item(1) > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", "08", _
                                      "D", "N", lcTipdes, pcBanco, lncomision, 0, 0)


                'Inserta en la Credkar
                entidadKardex.nmonto = arrayd.Item(1)
                entidadKardex.cflag = ""
                entidadKardex.cconcep = "08"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)


                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = arrayd.Item(1)
                entidadCntamov.cconcepto = "IVA COMISIONES"
                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1


            End If

            For Each fila As DataRow In dsg.Tables(0).Rows
                If fila("nmongas") > 0 Then


                    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", fila("ctipgas"), "D", "N", lcTipdes, pcBanco, lncomision, 0, 0)

                    If fila("ctipgas").ToString.Trim = "01" Then
                        fila("nmongas") = fila("nmongas") - arrayd.Item(1)
                        fila("nmongas") = Math.Round(fila("nmongas"), 2)
                    End If

                    'Inserta en la Credkar
                    entidadKardex.nmonto = fila("nmongas")
                    entidadKardex.cconcep = fila("ctipgas")
                    entidadKardex.cflag = "2"
                    entidadKardex.ccodctb = lccuenta

                    eKardex.agregarCredkar(entidadKardex)

                    'Inserta en la Cntamov
                    entidadCntamov.cnumlin = lnum
                    entidadCntamov.ccodcta = lccuenta
                    entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                    entidadCntamov.ndebe = 0
                    entidadCntamov.nhaber = fila("nmongas")

                    eCntamov.agregarCntamov(entidadCntamov)

                    lnum += 1


                    
                End If
            Next


            '----------------------------------------------------------------------Cierra Barrido de Cargos
            'CJ Desembolso liquido
            If lnCJ > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CJ", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnCJ
                entidadKardex.cflag = "7"
                entidadKardex.cconcep = "CJ"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov

                'Cambio solicitado por los ss
                entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)

                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnCJ

                eCntamov.agregarCntamov(entidadCntamov)
                lnum += 1
            End If


            Dim lnre As Integer = 0
            lnre = clsppal.ActualizaGarantiaCremcre(Me.cCuenta)
            lnre = clsppal.ActualizaCicloCremcre(Me.cCuenta)

            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function
    Public Function ConvertidorFondos(ByVal cCodfue As String) As String
        Dim lccodfue As String
        'If cCodfue.Trim = "03" Or cCodfue.Trim = "05" Or cCodfue.Trim = "07" Or cCodfue.Trim = "11" _
        'Or cCodfue.Trim = "12" Or cCodfue.Trim = "13" Or cCodfue.Trim = "15" Or cCodfue.Trim = "17" _
        'Or cCodfue.Trim = "18" Then
        '    lccodfue = "99"
        'Else
        lccodfue = cCodfue.Trim
        'End If

        Return lccodfue
    End Function


    ''Desembolso sin cheque
    Public Function DesembolsoSinCheque(ByVal cnumpar As String, ByVal ctipmet As String) As Integer


        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lnCuota As Double
        Dim lcNrolin As String
        Dim lcCondic As String
        Dim lcNorref As String
        Dim lcSececo As String
        Dim lnRetorno As Integer

        lcNumpar = cnumpar
        '-------------------------------------------------
        'Sacando las cuotas 
        '-------------------------------------------------

        Try



            Dim entidadCredtpl As New SIM.EL.credtpl
            Dim eCredtpl As New SIM.BL.cCredtpl


            '          entidadCredtpl.ccodcta = Me.cCuenta
            '         entidadCredtpl.ctipope = "N"
            '        entidadCredtpl.cnrocuo = "001"

            '       eCredtpl.ObtenerCredtpl(entidadCredtpl)
            '      lnCuota = entidadCredtpl.ncapita + entidadCredtpl.nintere + entidadCredtpl.ngastos + entidadCredtpl.nsegdeu

            '>>>>>>>>Fecha Real  de Desembolso
            Dim ldfecDes As Date
            entidadCredtpl.ccodcta = Me.cCuenta
            entidadCredtpl.ctipope = "D"
            entidadCredtpl.cnrocuo = "001"
            eCredtpl.ObtenerCredtpl(entidadCredtpl)
            ldfecDes = entidadCredtpl.dfecven
            Me.gdfecsis = ldfecDes
            '-------------------------------------------------
            'Graba los cambios en la Maestra de Creditos
            '-------------------------------------------------

            Dim entidadCremcre As New SIM.EL.cremcre
            Dim ecreditos As New SIM.BL.cCremcre

            entidadCremcre.ccodcta = Me.cCuenta
            ecreditos.ObtenerCremcre(entidadCremcre)

            lcNrolin = entidadCremcre.cnrolin
            lcNorref = entidadCremcre.cnorref
            lcCondic = entidadCremcre.ccondic
            lcSececo = entidadCremcre.csececo
            lnCuota = entidadCremcre.nmoncuo

            entidadCremcre.ncapdes = entidadCremcre.ncapdes + Me.nCapita
            entidadCremcre.ncapoto = entidadCremcre.ncapoto + Me.nCapita


            'entidadCremcre.ncapdes = Me.nCapita
            'entidadCremcre.ncapoto = Me.nCapita
            entidadCremcre.cestado = "F"
            entidadCremcre.dfecmod = Me.gdfecsis
            entidadCremcre.dfecvig = Me.gdfecsis
            entidadCremcre.nmoncuo = lnCuota
            entidadCremcre.ngaspag = Me.nDescuento
            entidadCremcre.ngastos = Me.nDescuento
            entidadCremcre.cflag = " "
            entidadCremcre.ndiaatr = 0
            entidadCremcre.ndiaant = 0
            entidadCremcre.ccalif = "A"
            entidadCremcre.cnrodes = Me.cnrodoc.Trim
            'entidadCremcre.ccodsol = "0001"



            'Da un error hay que Grabarlo tambien en la Ccodsol, Consultar
            'entidadCremcre.ccodsol = " "  
            entidadCremcre.ndeseje = 0
            entidadCremcre.ccodpag = Me.cBanco

            ecreditos.ModificaCremcre(entidadCremcre)


            '-----------------------------------------------
            'Graba las cuotas en Credppg
            '-----------------------------------------------
            Dim ds As New DataSet
            Dim ncanti As Integer
            Dim entidadCredppg As New SIM.EL.credppg
            Dim eCredppg As New SIM.BL.cCredppg

            entidadCredppg.ccodcta = Me.cCuenta
            entidadCredppg.ctipope = "N"
            entidadCredppg.cnrocuo = "001"

            '        eCredppg.ObtenerCredppg(entidadCredppg)

            ds = eCredtpl.ObtenerDataSetPorID(Me.cCuenta)


            ncanti = ds.Tables(0).Rows.Count()

            If ncanti = 0 Then  'En caso que no devuelva nada se sale
                Exit Function
            End If


            Dim Fila As DataRow
            ncanti = 0

            For Each Fila In ds.Tables(0).Rows
                entidadCredppg.ccodcta = ds.Tables(0).Rows(ncanti)("ccodcta")
                entidadCredppg.dfecven = ds.Tables(0).Rows(ncanti)("dfecven")
                entidadCredppg.ctipope = ds.Tables(0).Rows(ncanti)("ctipope")
                entidadCredppg.cnrocuo = ds.Tables(0).Rows(ncanti)("cnrocuo")
                entidadCredppg.ncapita = ds.Tables(0).Rows(ncanti)("ncapita")
                entidadCredppg.nintere = ds.Tables(0).Rows(ncanti)("nIntere")
                entidadCredppg.nsegdeu = ds.Tables(0).Rows(ncanti)("nsegdeu")
                entidadCredppg.cflag = " "
                If ncanti = 0 Then
                    entidadCredppg.cestado = "E"
                Else
                    entidadCredppg.cestado = "N"
                End If

                'IIf(ncanti = 0, entidadCredppg.cestado = "E", entidadCredppg.cestado = "N")

                entidadCredppg.dfecpag = Me.gdfecsis 'Hay que suplantarla por una fecha vacia

                entidadCredppg.dfecmod = Me.gdfecsis
                entidadCredppg.ccodusu = Me.gcCodUsu
                entidadCredppg.ncappag = 0
                entidadCredppg.nintpag = 0
                entidadCredppg.nmorpag = 0
                entidadCredppg.notrpag = 0

                eCredppg.Agregar(entidadCredppg)
                ncanti = ncanti + 1
            Next

            ds.Tables.Clear()


            '---------------------------------------------------
            'Graba Desembolso en Credkar,cntamov,ctbdchq,Diario
            '---------------------------------------------------
            Dim entidadCretlin As New SIM.EL.cretlin
            Dim eCretlin As New SIM.BL.cCretlin
            Dim lcCodlin As String
            Dim pcBanco As String
            Dim lccuenta As String
            Dim lnComOtorg As Double
            Dim lniva As Double
            Dim lnComEsc As Double
            Dim lnSedDeu As Double
            Dim lnHono As Double
            Dim lnDerIns As Double
            Dim lcTipdes As String
            Dim lnum As Integer = 1
            Dim lnKP As Double
            Dim lnCJ As Double


            lcTipdes = Me.cTipdes

            'Comisiones
            lnComOtorg = Me.nComOtorg 'Comision por Otorgamiento
            lniva = Me.nIVA
            lnComEsc = Me.nComEsc 'Comision por Escrituracion
            lnSedDeu = Me.nSegdeu 'Seguro de Deuda
            lnHono = Me.nHono  'Honorarios por Servicios
            lnDerIns = Me.nDerIns 'Derechos de Inscripcion
            lnKP = Me.nCapita
            lnCJ = Me.nCJ


            'Obtien el cCodlin 
            entidadCretlin.cnrolin = lcNrolin
            eCretlin.ObtenerCretlin(entidadCretlin)
            lcCodlin = entidadCretlin.ccodlin
            pcBanco = Me.cBanco


            'Cuenta Contable de Capital
            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "KP", "D", lcCondic, lcTipdes, pcBanco, lnKP, 0, 0)

            Dim entidadKardex As New SIM.EL.credkar
            Dim eKardex As New SIM.BL.cCredkar

            entidadKardex.ccodcta = Me.cCuenta
            eKardex.ObtenerCredkar(entidadKardex)

            entidadKardex.ccodcta = Me.cCuenta
            entidadKardex.dfecpro = Me.gdfecsis
            entidadKardex.dfecsis = Me.gdfecsis
            entidadKardex.cnrocuo = "001"
            entidadKardex.nmonto = lnKP
            entidadKardex.ccodins = Me.cReg
            entidadKardex.ccodofi = Me.cOficina
            entidadKardex.ctippag = Me.cTippag
            entidadKardex.cestado = " "
            entidadKardex.ctermid = " "
            entidadKardex.cnrodoc = Me.cnrodoc
            entidadKardex.ccodusu = Me.gcCodUsu
            entidadKardex.dfecmod = Me.gdfecsis
            entidadKardex.cmoneda = " "
            entidadKardex.ccondic = lcCondic
            entidadKardex.cconcep = "KP"
            entidadKardex.cdescob = "D"
            entidadKardex.cnuming = Me.cNrochq
            entidadKardex.cbanco = " "
            entidadKardex.ccodctb = lccuenta
            entidadKardex.ctrasctb = True
            entidadKardex.cflag = "1"
            entidadKardex.cclipag = " "
            entidadKardex.cnomcta = " "
            entidadKardex.cnumcta = " "
            entidadKardex.crotativa = " "
            entidadKardex.ndiaatr = 0
            ' entidadKardex.cnuming = Me.cNrochq


            eKardex.agregarCredkar(entidadKardex)


            '----------------------------------------------------------------------Barrera Cargos
            Dim dsg As New DataSet
            Dim ecredgas As New cCredgas
            dsg = ecredgas.CargaGastos(Me.cCuenta, "D", Me.cnrodoc)
            For Each filag As DataRow In dsg.Tables(0).Rows
                If filag("nmongas") > 0 Then
                    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", filag("ctipgas"), "D", "N", lcTipdes, pcBanco, filag("nmongas"), 0, 0)
                    'Inserta en la Credkar
                    entidadKardex.nmonto = filag("nmongas")
                    entidadKardex.cconcep = filag("ctipgas")
                    entidadKardex.cflag = "2"
                    entidadKardex.ccodctb = lccuenta
                    eKardex.agregarCredkar(entidadKardex)
                End If
            Next


            '----------------------------------------------------------------------Cierra Barrido de Cargos


            'CJ Desembolso liquido
            If lnCJ > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CJ", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnCJ
                entidadKardex.cflag = "7"
                entidadKardex.cconcep = "CJ"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)


            End If
            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function


    'Desembolso solo cheque
    Public Function DesembolsoSoloCheque(ByVal cnumpar As String, ByVal ctipmet As String) As Integer


        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lnCuota As Double
        Dim lcNrolin As String
        Dim lcCondic As String
        Dim lcNorref As String
        Dim lcSececo As String
        Dim lnRetorno As Integer

        lcNumpar = cnumpar
        '-------------------------------------------------
        'Sacando las cuotas 
        '-------------------------------------------------

        Try



            '---------------------------------------------------
            'Graba Desembolso en Credkar,cntamov,ctbdchq,Diario
            '---------------------------------------------------
            Dim entidadCretlin As New SIM.EL.cretlin
            Dim eCretlin As New SIM.BL.cCretlin
            Dim lcCodlin As String
            Dim pcBanco As String
            Dim lccuenta As String
            Dim lnComOtorg As Double
            Dim lniva As Double
            Dim lnComEsc As Double
            Dim lnSedDeu As Double
            Dim lnHono As Double
            Dim lnDerIns As Double
            Dim lcTipdes As String
            Dim lnum As Integer = 1
            Dim lnKP As Double
            Dim lnCJ As Double


            lcTipdes = Me.cTipdes

            'Comisiones
            lnComOtorg = Me.nComOtorg 'Comision por Otorgamiento
            lniva = Me.nIVA
            lnComEsc = Me.nComEsc 'Comision por Escrituracion
            lnSedDeu = Me.nSegdeu 'Seguro de Deuda
            lnHono = Me.nHono  'Honorarios por Servicios
            lnDerIns = Me.nDerIns 'Derechos de Inscripcion
            lnKP = Me.nCapita
            lnCJ = Me.nCJ

            '-------------------------------------------------
            'Graba los cambios en la Maestra de Creditos
            '-------------------------------------------------

            Dim entidadCremcre As New SIM.EL.cremcre
            Dim ecreditos As New SIM.BL.cCremcre

            entidadCremcre.ccodcta = Me.cCuenta
            ecreditos.ObtenerCremcre(entidadCremcre)

            lcNrolin = entidadCremcre.cnrolin
            lcNorref = entidadCremcre.cnorref
            lcCondic = entidadCremcre.ccondic
            lcSececo = entidadCremcre.csececo
            lnCuota = entidadCremcre.nmoncuo


            'Obtien el cCodlin 
            entidadCretlin.cnrolin = lcNrolin
            eCretlin.ObtenerCretlin(entidadCretlin)
            lcCodlin = entidadCretlin.ccodlin
            pcBanco = Me.cBanco


            '------------------------------------
            'Obteniendo las cuenta Contable 
            '------------------------------------
            '  lcNumpar = cClase.fxStevo() 'Numero de Partida

            'KP
            'If lnKP > 0 Then


            '-------------------------
            'Inserta en la Diario
            '-------------------------
            If Me.nflag = 1 Then
                Dim entidadDiario As New SIM.EL.diario
                Dim eDiario As New SIM.BL.cDiario

                entidadDiario.cnumcom = lcNumpar
                eDiario.ObtenerDiario(entidadDiario)

                entidadDiario.cnumcom = lcNumpar
                entidadDiario.ccodofi = Me.cOficina
                entidadDiario.ctipasi = "012"
                entidadDiario.ctipmon = "1"
                entidadDiario.cglosa = Me.cGlosa
                entidadDiario.cnumdoc = Me.cNrochq
                entidadDiario.ccodreg = Me.cReg
                entidadDiario.ccodrev = " "
                entidadDiario.ccodruc = " "
                entidadDiario.dfeccnt = Me.gdfecsis
                entidadDiario.dfecdoc = Me.gdfecsis
                entidadDiario.dfecmod = Me.gdfecsis
                entidadDiario.ffondos = lcCodlin.Substring(2, 2)
                entidadDiario.ccodusu = Me.gcCodUsu
                entidadDiario.cestado = " "
                entidadDiario.cfv = " "
                entidadDiario.nccompra = 0
                entidadDiario.ncventa = 0
                entidadDiario.nfln = 0
                entidadDiario.ntcfijo = 0
                'entidadDiario.ccodemp = " "
                entidadDiario.cnrodoc = " "

                eDiario.agregarDiario(entidadDiario)
            End If

            Dim entidadCtbdChq As New SIM.EL.ctbdchq
            Dim eCtbdchq As New SIM.BL.cCtbdchq
            Dim pcCotacte As String

            pcCotacte = Me.cCotacte

            entidadCtbdChq.cnumcom = lcNumpar
            eCtbdchq.ObtenerCtbdchq(entidadCtbdChq)

            entidadCtbdChq.cnumcom = lcNumpar
            entidadCtbdChq.cmonchq = lnCJ
            entidadCtbdChq.cnomchq = Me.cNomcli
            entidadCtbdChq.cnrochq = Me.cNrochq
            entidadCtbdChq.cnomcta = " "
            entidadCtbdChq.dfeccnt2 = Me.gdfecsis
            entidadCtbdChq.ccodbco = pcBanco 'Me.cmbBancos.SelectedItem.Text.Trim
            entidadCtbdChq.cflc = " "
            entidadCtbdChq.lprint = True
            entidadCtbdChq.ccoddeb = " "
            entidadCtbdChq.ccodhab = " "
            entidadCtbdChq.cctacte = pcCotacte
            entidadCtbdChq.ccodsol = Me.ccodsol

            eCtbdchq.Agregar(entidadCtbdChq)

            Me.cnumrec = ""
            GrabaenAuxiliar(lcNumpar, "A")
            'Inserta en la Credkar
            'Cuenta Contable de Capital
            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "KP", "D", lcCondic, lcTipdes, pcBanco, lnKP, 0, 0)


            'Inserta en la Cntamov

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            entidadCntamov.cnumcom = lcNumpar
            eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = lcNumpar
            entidadCntamov.ccodsec = lcSececo
            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            entidadCntamov.cnumlin = lnum
            entidadCntamov.ccodcta = lccuenta
            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            entidadCntamov.ndebe = lnKP
            entidadCntamov.nhaber = 0
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cNrochq
            entidadCntamov.dfeccnt = Me.gdfecsis
            entidadCntamov.dfecmod = Me.gdfecsis
            entidadCntamov.ccodpres = Me.cCuenta
            entidadCntamov.cconcepto = Me.cGlosa
            entidadCntamov.cpoliza = "EG"
            entidadCntamov.ccodofi = Me.cOficina
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = Me.cReg
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.gcCodUsu

            eCntamov.agregarCntamov(entidadCntamov)

            lnum += 1
            'End If
            '----------------------------------------------------------------------Barrera Cargos
            Dim dtg As New DataTable
            Dim ecredgas As New cCredgas
            dtg = ecredgas.CargaComisionesGrupal(Me.ccodsol, "D")
            For Each fila As DataRow In dtg.Rows
                If fila("nmongas") > 0 Then


                    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, "N", fila("ccodigo"), "D", "N", lcTipdes, pcBanco, fila("nmongas"), 0, 0)
                    'Inserta en la Cntamov
                    entidadCntamov.cnumlin = lnum
                    entidadCntamov.ccodcta = lccuenta
                    entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                    entidadCntamov.ndebe = 0
                    entidadCntamov.nhaber = fila("nmongas")

                    eCntamov.agregarCntamov(entidadCntamov)

                    lnum += 1
                End If
            Next


            '----------------------------------------------------------------------Cierra Barrido de Cargos


            'CJ Desembolso liquido
            If lnCJ > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CJ", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)


                'Inserta en la Cntamov
                entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnCJ

                eCntamov.agregarCntamov(entidadCntamov)

            End If

            'Agregar Cuentas Especiales ---------------------------------->

            'If lnCJ > 0 Then ' monto total pagado
            '    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CXP", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

            '    'Inserta en la Cntamov
            '    entidadCntamov.ffondos = "99"
            '    entidadCntamov.cnumlin = lnum
            '    entidadCntamov.ccodcta = lccuenta
            '    entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '    entidadCntamov.ndebe = lnCJ
            '    entidadCntamov.nhaber = 0

            '    eCntamov.agregarCntamov(entidadCntamov)
            '    lnum += 1
            '    lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CXC", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

            '    'Inserta en la Cntamov
            '    entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '    entidadCntamov.cnumlin = lnum
            '    entidadCntamov.ccodcta = lccuenta
            '    entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '    entidadCntamov.ndebe = 0
            '    entidadCntamov.nhaber = lnCJ

            '    eCntamov.agregarCntamov(entidadCntamov)

            '    lnum += 1
            'End If


            '<<<<<<<<<<<<<<<<<<--------------------------------------------
            Dim lnre As Integer = 0
            lnre = clsppal.ActualizaGarantiaCremcre(Me.cCuenta)
            lnre = clsppal.ActualizaCicloCremcre(Me.cCuenta)

            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

    Public Function GrabaenAuxiliar(ByVal cnumpar As String, ByVal tipo As String) As Integer
        Dim lcnumdoc As String = Me.cNrochq
        Dim lccodcta As String
        Dim lcnumrec As String = Me.cnumrec
        Dim etabtbco As New cTabtbco
        lccodcta = etabtbco.CuentadeBancoContable(Me.cBanco)
        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0

        If tipo = "C" Then 'Pagos
            lndebe = Me.nCJ
            lnhaber = 0
        Else 'Desembolsos
            lndebe = 0
            lnhaber = Me.nCJ
        End If
        Dim ldfeccnt As Date = Me.gdfecsis
        Dim lccodbco As String = Me.cBanco
        Dim lctipcta As String = ""
        Dim lcctacte As String = etabtbco.CuentadeBanco1(Me.cBanco)
        Dim lctipapl As String = "A"
        Dim lcnomcli As String = Me.cNomcli
        Dim lcconcep As String = Me.cGlosa
        Dim lccodofi As String = Me.cOficina
        Dim lcfondos As String
        Dim lcnrolin As String
        Dim lccodlin As String
        Dim lcnumpar As String = cnumpar

        Dim entidadCremcre As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre

        Dim entidadCretlin As New SIM.EL.cretlin
        Dim ecretlin As New SIM.BL.cCretlin


        entidadCremcre.ccodcta = Me.cCuenta
        ecreditos.ObtenerCremcre(entidadCremcre)

        lcnrolin = entidadCremcre.cnrolin


        'Obtien el cCodlin 
        entidadCretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadCretlin)
        lccodlin = entidadCretlin.ccodlin

        lcfondos = ConvertidorFondos(lccodlin.Substring(2, 2).Trim)

        Dim entidadCtbdChq As New SIM.EL.ctbdchq
        Dim eCtbdchq As New SIM.BL.cCtbdchq

        entidadCtbdChq.cnumcom = lcnumpar.Trim
        entidadCtbdChq.cnumdoc = lcnumdoc.Trim
        entidadCtbdChq.cCodcta = lccodcta.Trim
        entidadCtbdChq.ndebe = lndebe
        entidadCtbdChq.nhaber = lnhaber
        entidadCtbdChq.dfeccnt = ldfeccnt
        entidadCtbdChq.ccodbco = lccodbco.Trim
        entidadCtbdChq.ctipcta = lctipcta.Trim
        entidadCtbdChq.cctacte = lcctacte.Trim
        entidadCtbdChq.ctipapl = lctipapl.Trim
        entidadCtbdChq.cnomcli = lcnomcli.Trim
        entidadCtbdChq.cconcep = lcconcep.Trim
        entidadCtbdChq.ccodofi = lccodofi.Trim
        entidadCtbdChq.ffondos = lcfondos.Trim
        entidadCtbdChq.cnumrec = lcnumrec
        Try
            eCtbdchq.AgregarAuxiliar(entidadCtbdChq)
        Catch ex As Exception

        End Try

    End Function

    'Desembolso de extrafinanciamiento
    Public Function DesembolsoExtrafinanciamiento(ByVal cnumpar As String, ByVal ctipmet As String) As Integer


        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lnCuota As Double
        Dim lcNrolin As String
        Dim lcCondic As String = "N"
        Dim lcNorref As String
        Dim lcSececo As String
        Dim lnRetorno As Integer

        lcNumpar = cnumpar
        '-------------------------------------------------
        'Sacando las cuotas 
        '-------------------------------------------------

        Try



            Dim entidadCredtpl As New SIM.EL.credtpl
            Dim eCredtpl As New SIM.BL.cCredtpl


            '          entidadCredtpl.ccodcta = Me.cCuenta
            '         entidadCredtpl.ctipope = "N"
            '        entidadCredtpl.cnrocuo = "001"

            '       eCredtpl.ObtenerCredtpl(entidadCredtpl)
            '      lnCuota = entidadCredtpl.ncapita + entidadCredtpl.nintere + entidadCredtpl.ngastos + entidadCredtpl.nsegdeu

            '>>>>>>>>Fecha Real  de Desembolso
            'Dim ldfecDes As Date
            'entidadCredtpl.ccodcta = Me.cCuenta
            'entidadCredtpl.ctipope = "D"
            'entidadCredtpl.cnrocuo = "001"
            'eCredtpl.ObtenerCredtpl(entidadCredtpl)
            'ldfecDes = entidadCredtpl.dfecven
            'Me.gdfecsis = ldfecDes
            '-------------------------------------------------
            'Graba los cambios en la Maestra de Creditos
            '-------------------------------------------------

            Dim entidadCremcre As New SIM.EL.cremcre
            Dim ecreditos As New SIM.BL.cCremcre

            entidadCremcre.ccodcta = Me.cCuenta
            ecreditos.ObtenerCremcre(entidadCremcre)

            lcNrolin = entidadCremcre.cnrolin
            'lcNorref = entidadCremcre.cnorref
            'lcCondic = entidadCremcre.ccondic
            'lcSececo = entidadCremcre.csececo
            'lnCuota = entidadCremcre.nmoncuo



            'entidadCremcre.ncapdes = Me.nCapita
            'entidadCremcre.ncapoto = Me.nCapita
            'entidadCremcre.cestado = "F"
            'entidadCremcre.dfecmod = Me.gdfecsis
            'entidadCremcre.dfecvig = Me.gdfecsis
            'entidadCremcre.nmoncuo = lnCuota
            'entidadCremcre.ngaspag = Me.nDescuento
            'entidadCremcre.ngastos = Me.nDescuento
            'entidadCremcre.cflag = " "
            'entidadCremcre.ndiaatr = 0
            'entidadCremcre.ndiaant = 0
            'entidadCremcre.ccalif = "A"
            'entidadCremcre.cnrodes = Me.cnrodoc.Trim
            ''entidadCremcre.ccodsol = "0001"



            ''Da un error hay que Grabarlo tambien en la Ccodsol, Consultar
            ''entidadCremcre.ccodsol = " "  
            'entidadCremcre.ndeseje = 0

            'ecreditos.ModificaCremcre(entidadCremcre)


            '-----------------------------------------------
            'Graba las cuotas en Credppg
            '-----------------------------------------------
            'Dim ds As New DataSet
            'Dim ncanti As Integer
            'Dim entidadCredppg As New SIM.EL.credppg
            'Dim eCredppg As New SIM.BL.cCredppg

            'entidadCredppg.ccodcta = Me.cCuenta
            'entidadCredppg.ctipope = "N"
            'entidadCredppg.cnrocuo = "001"

            ''        eCredppg.ObtenerCredppg(entidadCredppg)

            'ds = eCredtpl.ObtenerDataSetPorID(Me.cCuenta)


            'ncanti = ds.Tables(0).Rows.Count()

            'If ncanti = 0 Then  'En caso que no devuelva nada se sale
            '    Exit Function
            'End If


            'Dim Fila As DataRow
            'ncanti = 0

            'For Each Fila In ds.Tables(0).Rows
            '    entidadCredppg.ccodcta = ds.Tables(0).Rows(ncanti)("ccodcta")
            '    entidadCredppg.dfecven = ds.Tables(0).Rows(ncanti)("dfecven")
            '    entidadCredppg.ctipope = ds.Tables(0).Rows(ncanti)("ctipope")
            '    entidadCredppg.cnrocuo = ds.Tables(0).Rows(ncanti)("cnrocuo")
            '    entidadCredppg.ncapita = ds.Tables(0).Rows(ncanti)("ncapita")
            '    entidadCredppg.nintere = ds.Tables(0).Rows(ncanti)("nIntere")
            '    entidadCredppg.nsegdeu = ds.Tables(0).Rows(ncanti)("nsegdeu")
            '    entidadCredppg.cflag = " "
            '    If ncanti = 0 Then
            '        entidadCredppg.cestado = "E"
            '    Else
            '        entidadCredppg.cestado = "N"
            '    End If

            '    'IIf(ncanti = 0, entidadCredppg.cestado = "E", entidadCredppg.cestado = "N")

            '    entidadCredppg.dfecpag = Me.gdfecsis 'Hay que suplantarla por una fecha vacia

            '    entidadCredppg.dfecmod = Me.gdfecsis
            '    entidadCredppg.ccodusu = Me.gcCodUsu
            '    entidadCredppg.ncappag = 0
            '    entidadCredppg.nintpag = 0
            '    entidadCredppg.nmorpag = 0
            '    entidadCredppg.notrpag = 0

            '    eCredppg.Agregar(entidadCredppg)
            '    ncanti = ncanti + 1
            'Next

            'ds.Tables.Clear()


            '---------------------------------------------------
            'Graba Desembolso en Credkar,cntamov,ctbdchq,Diario
            '---------------------------------------------------
            Dim entidadCretlin As New SIM.EL.cretlin
            Dim eCretlin As New SIM.BL.cCretlin
            Dim lcCodlin As String
            Dim pcBanco As String
            Dim lccuenta As String
            Dim lnComOtorg As Double
            Dim lniva As Double
            Dim lnComEsc As Double
            Dim lnSedDeu As Double
            Dim lnHono As Double
            Dim lnDerIns As Double
            Dim lcTipdes As String
            Dim lnum As Integer = 1
            Dim lnKP As Double
            Dim lnCJ As Double


            lcTipdes = Me.cTipdes

            'Comisiones
            lnComOtorg = Me.nComOtorg 'Comision por Otorgamiento
            lniva = Me.nIVA
            lnComEsc = Me.nComEsc 'Comision por Escrituracion
            lnSedDeu = Me.nSegdeu 'Seguro de Deuda
            lnHono = Me.nHono  'Honorarios por Servicios
            lnDerIns = Me.nDerIns 'Derechos de Inscripcion
            lnKP = Me.nCapita
            lnCJ = Me.nCJ


            'Obtien el cCodlin 
            entidadCretlin.cnrolin = lcNrolin
            eCretlin.ObtenerCretlin(entidadCretlin)
            lcCodlin = entidadCretlin.ccodlin
            pcBanco = Me.cBanco


            '------------------------------------
            'Obteniendo las cuenta Contable 
            '------------------------------------
            '  lcNumpar = cClase.fxStevo() 'Numero de Partida

            'KP
            'If lnKP > 0 Then


            '-------------------------
            'Inserta en la Diario
            '-------------------------
            If Me.nflag = 1 Then
                Dim entidadDiario As New SIM.EL.diario
                Dim eDiario As New SIM.BL.cDiario

                entidadDiario.cnumcom = lcNumpar
                eDiario.ObtenerDiario(entidadDiario)

                entidadDiario.cnumcom = lcNumpar
                entidadDiario.ccodofi = Me.cOficina
                entidadDiario.ctipasi = "012"
                entidadDiario.ctipmon = "1"
                entidadDiario.cglosa = Me.cGlosa
                entidadDiario.cnumdoc = Me.cNrochq
                entidadDiario.ccodreg = Me.cReg
                entidadDiario.ccodrev = " "
                entidadDiario.ccodruc = " "
                entidadDiario.dfeccnt = Me.gdfecsis
                entidadDiario.dfecdoc = Me.gdfecsis
                entidadDiario.dfecmod = Me.gdfecsis
                entidadDiario.ffondos = lcCodlin.Substring(2, 2)
                entidadDiario.ccodusu = Me.gcCodUsu
                entidadDiario.cestado = " "
                entidadDiario.cfv = " "
                entidadDiario.nccompra = 0
                entidadDiario.ncventa = 0
                entidadDiario.nfln = 0
                entidadDiario.ntcfijo = 0
                'entidadDiario.ccodemp = " "
                entidadDiario.cnrodoc = " "

                eDiario.agregarDiario(entidadDiario)
            End If
            'Inserta en la ctbdchq 
            If ctipmet = "0" Then
                Dim entidadCtbdChq As New SIM.EL.ctbdchq
                Dim eCtbdchq As New SIM.BL.cCtbdchq
                Dim pcCotacte As String

                pcCotacte = Me.cCotacte

                entidadCtbdChq.cnumcom = lcNumpar
                eCtbdchq.ObtenerCtbdchq(entidadCtbdChq)

                entidadCtbdChq.cnumcom = lcNumpar
                entidadCtbdChq.cmonchq = lnCJ
                entidadCtbdChq.cnomchq = Me.cNomcli
                entidadCtbdChq.cnrochq = Me.cNrochq
                entidadCtbdChq.cnomcta = " "
                entidadCtbdChq.dfeccnt2 = Me.gdfecsis
                entidadCtbdChq.ccodbco = pcBanco 'Me.cmbBancos.SelectedItem.Text.Trim
                entidadCtbdChq.cflc = " "
                entidadCtbdChq.lprint = True
                entidadCtbdChq.ccoddeb = " "
                entidadCtbdChq.ccodhab = " "
                entidadCtbdChq.cctacte = pcCotacte
                entidadCtbdChq.ccodsol = Me.ccodsol

                Me.cnumrec = ""
                eCtbdchq.Agregar(entidadCtbdChq)
                GrabaenAuxiliar(lcNumpar, "A")

            End If

            'Inserta en la Credkar
            'Cuenta Contable de Capital
            lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "KP", "D", lcCondic, lcTipdes, pcBanco, lnKP, 0, 0)

            Dim entidadKardex As New SIM.EL.credkar
            Dim eKardex As New SIM.BL.cCredkar

            entidadKardex.ccodcta = Me.cCuenta
            eKardex.ObtenerCredkar(entidadKardex)

            entidadKardex.ccodcta = Me.cCuenta
            entidadKardex.dfecpro = Me.gdfecsis
            entidadKardex.dfecsis = Me.gdfecsis
            entidadKardex.cnrocuo = "001"
            entidadKardex.nmonto = lnKP
            entidadKardex.ccodins = Me.cReg
            entidadKardex.ccodofi = Me.cOficina
            entidadKardex.ctippag = Me.cTippag
            entidadKardex.cestado = " "
            entidadKardex.ctermid = " "
            entidadKardex.cnrodoc = Me.cnrodoc
            entidadKardex.ccodusu = Me.gcCodUsu
            entidadKardex.dfecmod = Me.gdfecsis
            entidadKardex.cmoneda = " "
            entidadKardex.ccondic = lcCondic
            entidadKardex.cconcep = "KP"
            entidadKardex.cdescob = "D"
            entidadKardex.cnuming = "EXTRA"
            entidadKardex.cbanco = " "
            entidadKardex.ccodctb = lccuenta
            entidadKardex.ctrasctb = True
            entidadKardex.cflag = "1"
            entidadKardex.cclipag = " "
            entidadKardex.cnomcta = " "
            entidadKardex.cnumcta = " "
            entidadKardex.crotativa = " "
            entidadKardex.ndiaatr = 0
            'entidadKardex.cnuming = ""


            eKardex.agregarCredkar(entidadKardex)

            'Inserta en la Cntamov

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            entidadCntamov.cnumcom = lcNumpar
            eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = lcNumpar
            entidadCntamov.ccodsec = lcSececo
            entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            entidadCntamov.cnumlin = lnum
            entidadCntamov.ccodcta = lccuenta
            entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            entidadCntamov.ndebe = lnKP
            entidadCntamov.nhaber = 0
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cNrochq
            entidadCntamov.dfeccnt = Me.gdfecsis
            entidadCntamov.dfecmod = Me.gdfecsis
            entidadCntamov.ccodpres = Me.cCuenta
            entidadCntamov.cconcepto = Me.cGlosa
            entidadCntamov.cpoliza = "EG"
            entidadCntamov.ccodofi = Me.cOficina
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = Me.cReg
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.gcCodUsu

            eCntamov.agregarCntamov(entidadCntamov)

            lnum += 1
            'End If






            '----------------------------------------------------------------------
            'Insercion del Refinanciamiento Inserta el Capital Interes y Mora, seguro y comision
            'Solo se hara el asiento contable
            '----------------------------------------------------------------------
            'Dim x As Integer
            'Dim entidadCremref As New SIM.EL.CremRef
            'Dim eCremref As New SIM.BL.cCremRef
            'Dim ds_ref As New DataSet
            'Dim lccodcta As String
            'Dim lnsalcap As Double
            'Dim lnsalint As Double
            'Dim lnsalmor As Double
            'Dim lnsegdeu As Double
            'Dim lncomision As Double



            'ds_ref = eCremref.ObtenerDataSetEsp2(Me.cCuenta)


            'x = ds_ref.Tables(0).Rows.Count()

            'If x = 0 Then  'En caso que no devuelva nada se sale
            '    '  Exit Function
            'End If

            Dim lncreref As Integer

            Dim lnsalcap0 As Double = 0
            Dim lnsalint0 As Double = 0
            Dim lnsalmor0 As Double = 0
            Dim lnsegdeu0 As Double = 0
            Dim lncomision0 As Double = 0

            'lncreref = x - 1

            'x = 0

            'For Each Fila In ds_ref.Tables(0).Rows
            '    lccodcta = ds_ref.Tables(0).Rows(x)("cCodpre")
            '    lnsalcap = ds_ref.Tables(0).Rows(x)("nsalcap")
            '    lnsalint = ds_ref.Tables(0).Rows(x)("nsalint")
            '    lnsalmor = ds_ref.Tables(0).Rows(x)("nsalmor")
            '    lcCodlin = ds_ref.Tables(0).Rows(x)("ccodlin")
            '    lnsegdeu = ds_ref.Tables(0).Rows(x)("nseguro")
            '    lncomision = ds_ref.Tables(0).Rows(x)("nmanejo")

            '    lnsalcap0 = lnsalcap0 + lnsalcap
            '    lnsalint0 = lnsalint0 + lnsalint
            '    lnsalmor0 = lnsalmor0 + lnsalmor
            '    lnsegdeu0 = lnsegdeu0 + lnsegdeu
            '    lncomision0 = lncomision0 + lncomision

            '    If lnsalcap > 0 Or lnsalcap0 > 0 Then    'Capital Refinanciado

            '        'Cuenta Contable de Capital Refinanciado

            '        lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "KR", "D", lcCondic, lcTipdes, pcBanco, lnsalcap, 0, 0)

            '        If lnsalcap0 > 0 And lncreref = x Then
            '            'Inserta en la credkar
            '            entidadKardex.ccodcta = Me.cCuenta
            '            entidadKardex.dfecpro = Me.gdfecsis
            '            entidadKardex.dfecsis = Me.gdfecsis
            '            entidadKardex.cnrocuo = "001"
            '            entidadKardex.nmonto = lnsalcap0 'lnsalcap
            '            entidadKardex.ccodins = Me.cReg
            '            entidadKardex.ccodofi = Me.cOficina
            '            entidadKardex.ctippag = Me.cTippag
            '            entidadKardex.cestado = " "
            '            entidadKardex.ctermid = " "
            '            entidadKardex.cnrodoc = Me.cnrodoc
            '            entidadKardex.ccodusu = Me.gcCodUsu
            '            entidadKardex.dfecmod = Me.gdfecsis
            '            entidadKardex.cmoneda = " "
            '            entidadKardex.ccondic = lcCondic
            '            entidadKardex.cconcep = "KR"
            '            entidadKardex.cdescob = "D"
            '            entidadKardex.cnuming = Me.cNrochq
            '            entidadKardex.cbanco = " "
            '            entidadKardex.ccodctb = lccuenta
            '            entidadKardex.ctrasctb = True
            '            entidadKardex.cflag = "7"
            '            entidadKardex.cclipag = " "
            '            entidadKardex.cnomcta = " "
            '            entidadKardex.cnumcta = " "
            '            entidadKardex.crotativa = " "
            '            entidadKardex.ndiaatr = 0
            '            '      entidadKardex.cnuming = ""

            '            eKardex.agregarCredkar(entidadKardex)
            '        End If

            '        'Inserta en la Cntamov

            '        entidadCntamov.cnumcom = lcNumpar
            '        eCntamov.ObtenerCntamov(entidadCntamov)

            '        entidadCntamov.cnumcom = lcNumpar
            '        entidadCntamov.ccodsec = lcSececo
            '        entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '        entidadCntamov.cnumlin = lnum
            '        entidadCntamov.ccodcta = lccuenta
            '        entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '        entidadCntamov.ndebe = 0
            '        entidadCntamov.nhaber = lnsalcap
            '        entidadCntamov.cflc = " "
            '        entidadCntamov.nfln = 0
            '        entidadCntamov.cnumdoc = Me.cNrochq
            '        entidadCntamov.dfeccnt = Me.gdfecsis
            '        entidadCntamov.dfecmod = Me.gdfecsis
            '        entidadCntamov.ccodpres = Me.cCuenta
            '        entidadCntamov.cconcepto = Me.cGlosa
            '        entidadCntamov.cpoliza = "EG"
            '        entidadCntamov.ccodofi = Me.cOficina
            '        entidadCntamov.cnumpol = " "
            '        entidadCntamov.ccodreg = Me.cReg
            '        entidadCntamov.ccodcli = " "
            '        entidadCntamov.ccodusu1 = Me.gcCodUsu

            '        eCntamov.agregarCntamov(entidadCntamov)
            '        lnum += 1

            '    End If

            '    If lnsalint > 0 Or lnsalint0 > 0 Then    'Interes Refinanciado    

            '        'Cuenta Contable de Interes Refinanciado

            '        lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "IR", "D", lcCondic, lcTipdes, pcBanco, lnsalint, 0, 0)

            '        If lnsalint0 > 0 And lncreref = x Then
            '            'Inserta en la credkar
            '            entidadKardex.ccodcta = Me.cCuenta
            '            entidadKardex.dfecpro = Me.gdfecsis
            '            entidadKardex.dfecsis = Me.gdfecsis
            '            entidadKardex.cnrocuo = "001"
            '            entidadKardex.nmonto = lnsalint0
            '            entidadKardex.ccodins = Me.cReg
            '            entidadKardex.ccodofi = Me.cOficina
            '            entidadKardex.ctippag = Me.cTippag
            '            entidadKardex.cestado = " "
            '            entidadKardex.ctermid = " "
            '            entidadKardex.cnrodoc = Me.cnrodoc
            '            entidadKardex.ccodusu = Me.gcCodUsu
            '            entidadKardex.dfecmod = Me.gdfecsis
            '            entidadKardex.cmoneda = " "
            '            entidadKardex.ccondic = lcCondic
            '            entidadKardex.cconcep = "IR"
            '            entidadKardex.cdescob = "D"
            '            entidadKardex.cnuming = Me.cNrochq
            '            entidadKardex.cbanco = " "
            '            entidadKardex.ccodctb = lccuenta
            '            entidadKardex.ctrasctb = True
            '            entidadKardex.cflag = "8"
            '            entidadKardex.cclipag = " "
            '            entidadKardex.cnomcta = " "
            '            entidadKardex.cnumcta = " "
            '            entidadKardex.crotativa = " "
            '            entidadKardex.ndiaatr = 0
            '            '     entidadKardex.cnuming = ""


            '            eKardex.agregarCredkar(entidadKardex)
            '        End If
            '        'Inserta en la Cntamov

            '        entidadCntamov.cnumcom = lcNumpar
            '        eCntamov.ObtenerCntamov(entidadCntamov)

            '        entidadCntamov.cnumcom = lcNumpar
            '        entidadCntamov.ccodsec = lcSececo
            '        entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '        entidadCntamov.cnumlin = lnum
            '        entidadCntamov.ccodcta = lccuenta
            '        entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '        entidadCntamov.ndebe = 0
            '        entidadCntamov.nhaber = lnsalint
            '        entidadCntamov.cflc = " "
            '        entidadCntamov.nfln = 0
            '        entidadCntamov.cnumdoc = Me.cNrochq
            '        entidadCntamov.dfeccnt = Me.gdfecsis
            '        entidadCntamov.dfecmod = Me.gdfecsis
            '        entidadCntamov.ccodpres = Me.cCuenta
            '        entidadCntamov.cconcepto = Me.cGlosa
            '        entidadCntamov.cpoliza = "EG"
            '        entidadCntamov.ccodofi = Me.cOficina
            '        entidadCntamov.cnumpol = " "
            '        entidadCntamov.ccodreg = Me.cReg
            '        entidadCntamov.ccodcli = " "
            '        entidadCntamov.ccodusu1 = Me.gcCodUsu

            '        eCntamov.agregarCntamov(entidadCntamov)
            '        lnum += 1

            '    End If

            '    If lnsalmor > 0 Or lnsalmor0 > 0 Then    'Mora Refinanciada
            '        'Cuenta Contable de Interes Moratorio Refinanciado

            '        lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "MR", "D", lcCondic, lcTipdes, pcBanco, lnsalmor, 0, 0)
            '        If lnsalmor0 > 0 And lncreref = x Then
            '            'Inserta en la credkar
            '            entidadKardex.ccodcta = Me.cCuenta
            '            entidadKardex.dfecpro = Me.gdfecsis
            '            entidadKardex.dfecsis = Me.gdfecsis
            '            entidadKardex.cnrocuo = "001"
            '            entidadKardex.nmonto = lnsalmor0
            '            entidadKardex.ccodins = Me.cReg
            '            entidadKardex.ccodofi = Me.cOficina
            '            entidadKardex.ctippag = Me.cTippag
            '            entidadKardex.cestado = " "
            '            entidadKardex.ctermid = " "
            '            entidadKardex.cnrodoc = Me.cnrodoc
            '            entidadKardex.ccodusu = Me.gcCodUsu
            '            entidadKardex.dfecmod = Me.gdfecsis
            '            entidadKardex.cmoneda = " "
            '            entidadKardex.ccondic = lcCondic
            '            entidadKardex.cconcep = "MR"
            '            entidadKardex.cdescob = "D"
            '            entidadKardex.cnuming = Me.cNrochq
            '            entidadKardex.cbanco = " "
            '            entidadKardex.ccodctb = lccuenta
            '            entidadKardex.ctrasctb = True
            '            entidadKardex.cflag = "9"
            '            entidadKardex.cclipag = " "
            '            entidadKardex.cnomcta = " "
            '            entidadKardex.cnumcta = " "
            '            entidadKardex.crotativa = " "
            '            entidadKardex.ndiaatr = 0
            '            '    entidadKardex.cnuming = ""

            '            eKardex.agregarCredkar(entidadKardex)
            '        End If
            '        'Inserta en la Cntamov

            '        entidadCntamov.cnumcom = lcNumpar
            '        eCntamov.ObtenerCntamov(entidadCntamov)

            '        entidadCntamov.cnumcom = lcNumpar
            '        entidadCntamov.ccodsec = lcSececo
            '        entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '        entidadCntamov.cnumlin = lnum
            '        entidadCntamov.ccodcta = lccuenta
            '        entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '        entidadCntamov.ndebe = 0
            '        entidadCntamov.nhaber = lnsalmor
            '        entidadCntamov.cflc = " "
            '        entidadCntamov.nfln = 0
            '        entidadCntamov.cnumdoc = Me.cNrochq
            '        entidadCntamov.dfeccnt = Me.gdfecsis
            '        entidadCntamov.dfecmod = Me.gdfecsis
            '        entidadCntamov.ccodpres = Me.cCuenta
            '        entidadCntamov.cconcepto = Me.cGlosa
            '        entidadCntamov.cpoliza = "EG"
            '        entidadCntamov.ccodofi = Me.cOficina
            '        entidadCntamov.cnumpol = " "
            '        entidadCntamov.ccodreg = Me.cReg
            '        entidadCntamov.ccodcli = " "
            '        entidadCntamov.ccodusu1 = Me.gcCodUsu

            '        eCntamov.agregarCntamov(entidadCntamov)
            '        lnum += 1
            '    End If

            '    If lnsegdeu > 0 Or lnsegdeu0 > 0 Then
            '        'Cuenta Contable de Interes Moratorio Refinanciado

            '        lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "SD", "D", lcCondic, lcTipdes, pcBanco, lnsalmor, 0, 0)
            '        If lnsegdeu0 > 0 And lncreref = x Then
            '            'Inserta en la credkar
            '            entidadKardex.ccodcta = Me.cCuenta
            '            entidadKardex.dfecpro = Me.gdfecsis
            '            entidadKardex.dfecsis = Me.gdfecsis
            '            entidadKardex.cnrocuo = "001"
            '            entidadKardex.nmonto = lnsegdeu0
            '            entidadKardex.ccodins = Me.cReg
            '            entidadKardex.ccodofi = Me.cOficina
            '            entidadKardex.ctippag = Me.cTippag
            '            entidadKardex.cestado = " "
            '            entidadKardex.ctermid = " "
            '            entidadKardex.cnrodoc = Me.cnrodoc
            '            entidadKardex.ccodusu = Me.gcCodUsu
            '            entidadKardex.dfecmod = Me.gdfecsis
            '            entidadKardex.cmoneda = " "
            '            entidadKardex.ccondic = lcCondic
            '            entidadKardex.cconcep = "SD"
            '            entidadKardex.cdescob = "D"
            '            entidadKardex.cnuming = Me.cNrochq
            '            entidadKardex.cbanco = " "
            '            entidadKardex.ccodctb = lccuenta
            '            entidadKardex.ctrasctb = True
            '            entidadKardex.cflag = "9"
            '            entidadKardex.cclipag = " "
            '            entidadKardex.cnomcta = " "
            '            entidadKardex.cnumcta = " "
            '            entidadKardex.crotativa = " "
            '            entidadKardex.ndiaatr = 0
            '            '   entidadKardex.cnuming = ""

            '            eKardex.agregarCredkar(entidadKardex)
            '        End If
            '        'Inserta en la Cntamov

            '        entidadCntamov.cnumcom = lcNumpar
            '        eCntamov.ObtenerCntamov(entidadCntamov)

            '        entidadCntamov.cnumcom = lcNumpar
            '        entidadCntamov.ccodsec = lcSececo
            '        entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '        entidadCntamov.cnumlin = lnum
            '        entidadCntamov.ccodcta = lccuenta
            '        entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '        entidadCntamov.ndebe = 0
            '        entidadCntamov.nhaber = lnsegdeu
            '        entidadCntamov.cflc = " "
            '        entidadCntamov.nfln = 0
            '        entidadCntamov.cnumdoc = Me.cNrochq
            '        entidadCntamov.dfeccnt = Me.gdfecsis
            '        entidadCntamov.dfecmod = Me.gdfecsis
            '        entidadCntamov.ccodpres = Me.cCuenta
            '        entidadCntamov.cconcepto = Me.cGlosa
            '        entidadCntamov.cpoliza = "EG"
            '        entidadCntamov.ccodofi = Me.cOficina
            '        entidadCntamov.cnumpol = " "
            '        entidadCntamov.ccodreg = Me.cReg
            '        entidadCntamov.ccodcli = " "
            '        entidadCntamov.ccodusu1 = Me.gcCodUsu

            '        eCntamov.agregarCntamov(entidadCntamov)
            '        lnum += 1
            '    End If
            '    If lncomision > 0 Or lncomision0 > 0 Then
            '        'Cuenta Contable de Interes Moratorio Refinanciado

            '        lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CO", "D", lcCondic, lcTipdes, pcBanco, lnsalmor, 0, 0)
            '        If lncomision0 > 0 And lncreref = x Then
            '            'Inserta en la credkar
            '            entidadKardex.ccodcta = Me.cCuenta
            '            entidadKardex.dfecpro = Me.gdfecsis
            '            entidadKardex.dfecsis = Me.gdfecsis
            '            entidadKardex.cnrocuo = "001"
            '            entidadKardex.nmonto = lncomision0
            '            entidadKardex.ccodins = Me.cReg
            '            entidadKardex.ccodofi = Me.cOficina
            '            entidadKardex.ctippag = Me.cTippag
            '            entidadKardex.cestado = " "
            '            entidadKardex.ctermid = " "
            '            entidadKardex.cnrodoc = Me.cnrodoc
            '            entidadKardex.ccodusu = Me.gcCodUsu
            '            entidadKardex.dfecmod = Me.gdfecsis
            '            entidadKardex.cmoneda = " "
            '            entidadKardex.ccondic = lcCondic
            '            entidadKardex.cconcep = "CO"
            '            entidadKardex.cdescob = "D"
            '            entidadKardex.cnuming = Me.cNrochq
            '            entidadKardex.cbanco = " "
            '            entidadKardex.ccodctb = lccuenta
            '            entidadKardex.ctrasctb = True
            '            entidadKardex.cflag = "9"
            '            entidadKardex.cclipag = " "
            '            entidadKardex.cnomcta = " "
            '            entidadKardex.cnumcta = " "
            '            entidadKardex.crotativa = " "
            '            entidadKardex.ndiaatr = 0
            '            '  entidadKardex.cnuming = ""

            '            eKardex.agregarCredkar(entidadKardex)
            '        End If
            '        'Inserta en la Cntamov

            '        entidadCntamov.cnumcom = lcNumpar
            '        eCntamov.ObtenerCntamov(entidadCntamov)

            '        entidadCntamov.cnumcom = lcNumpar
            '        entidadCntamov.ccodsec = lcSececo
            '        entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
            '        entidadCntamov.cnumlin = lnum
            '        entidadCntamov.ccodcta = lccuenta
            '        entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
            '        entidadCntamov.ndebe = 0
            '        entidadCntamov.nhaber = lncomision
            '        entidadCntamov.cflc = " "
            '        entidadCntamov.nfln = 0
            '        entidadCntamov.cnumdoc = Me.cNrochq
            '        entidadCntamov.dfeccnt = Me.gdfecsis
            '        entidadCntamov.dfecmod = Me.gdfecsis
            '        entidadCntamov.ccodpres = Me.cCuenta
            '        entidadCntamov.cconcepto = Me.cGlosa
            '        entidadCntamov.cpoliza = "EG"
            '        entidadCntamov.ccodofi = Me.cOficina
            '        entidadCntamov.cnumpol = " "
            '        entidadCntamov.ccodreg = Me.cReg
            '        entidadCntamov.ccodcli = " "
            '        entidadCntamov.ccodusu1 = Me.gcCodUsu

            '        eCntamov.agregarCntamov(entidadCntamov)
            '        lnum += 1
            '    End If
            '    x += 1
            'Next


            '-------------------------------------------------------------------
            'Fin 
            '-------------------------------------------------------------------



            '01 Comision por Otorgamiento
            If lnComOtorg > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "01", "D", lcCondic, lcTipdes, pcBanco, lnComOtorg, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnComOtorg
                entidadKardex.cconcep = "01"
                entidadKardex.cflag = "2"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnComOtorg

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1
            End If
            If lniva > 0 Then 'SEGURO DE VIDA
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "02", "D", lcCondic, lcTipdes, pcBanco, lniva, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnComOtorg
                entidadKardex.cconcep = "02"
                entidadKardex.cflag = "2"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lniva

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1
            End If

            '04 Comision por Escrituracion 
            If lnComEsc > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "04", "D", lcCondic, lcTipdes, pcBanco, lnComEsc, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnComEsc
                entidadKardex.cflag = "3"
                entidadKardex.cconcep = "04"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnComEsc

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1

            End If

            '05 Seguro de Deuda
            If lnSedDeu > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "05", "D", lcCondic, lcTipdes, pcBanco, lnSedDeu, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnSedDeu
                entidadKardex.cflag = "4"
                entidadKardex.cconcep = "05"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnSedDeu

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1

            End If

            '08 Honorarios por Servicios
            If lnHono > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "08", "D", lcCondic, lcTipdes, pcBanco, lnHono, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnHono
                entidadKardex.cflag = "5"
                entidadKardex.cconcep = "08"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnHono

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1

            End If

            '09 Derechos de Inscripcion
            If lnDerIns > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "09", "D", lcCondic, lcTipdes, pcBanco, lnDerIns, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnDerIns
                entidadKardex.cflag = "6"
                entidadKardex.cconcep = "09"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnDerIns

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1

            End If

            'CJ Desembolso liquido
            If lnCJ > 0 Then
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CJ", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

                'Inserta en la Credkar
                entidadKardex.nmonto = lnCJ
                entidadKardex.cflag = "7"
                entidadKardex.cconcep = "CJ"
                entidadKardex.ccodctb = lccuenta

                eKardex.agregarCredkar(entidadKardex)

                'Inserta en la Cntamov

                'Cambio solicitado por los ss
                entidadCntamov.ffondos = "99"

                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnCJ

                eCntamov.agregarCntamov(entidadCntamov)
                lnum += 1
            End If
            'Agregar Cuentas Especiales ---------------------------------->

            If lnCJ > 0 Then ' monto total pagado
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CXP", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

                'Inserta en la Cntamov
                entidadCntamov.ffondos = "99"
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = lnCJ
                entidadCntamov.nhaber = 0

                eCntamov.agregarCntamov(entidadCntamov)
                lnum += 1
                lccuenta = cClase.fxcuentacontable(Me.cCuenta, lcCodlin, lcNorref, "CXC", "D", lcCondic, lcTipdes, pcBanco, lnCJ, 0, 0)

                'Inserta en la Cntamov
                entidadCntamov.ffondos = ConvertidorFondos(lcCodlin.Substring(2, 2).Trim)
                entidadCntamov.cnumlin = lnum
                entidadCntamov.ccodcta = lccuenta
                entidadCntamov.cclase = lccuenta.Substring(0, 1).Trim
                entidadCntamov.ndebe = 0
                entidadCntamov.nhaber = lnCJ

                eCntamov.agregarCntamov(entidadCntamov)

                lnum += 1
            End If


            '<<<<<<<<<<<<<<<<<<--------------------------------------------



            lnRetorno = 1
            Return lnRetorno

        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function
    Public Function Actualiza_cNorref(ByVal ccodcta As String, ByVal pcnorref As String) As Integer


        Dim command As New SqlCommand
        Dim ecreditos As New ccreditos
        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(ecreditos.CadenaActual)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "Update cremcre set cnorref ='" & pcnorref & "' where ccodcta ='" & ccodcta & "'"
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                lnretorno = 1
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try
        End Using

        Return lnretorno
    End Function

#End Region



End Class
