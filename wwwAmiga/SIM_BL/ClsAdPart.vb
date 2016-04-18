Public Class ClsAdPart

#Region " Variables "
    Private ffondos As String
    Private cnumcom As String
    Private cnumlin As String
    Private ccodcta As String
    Private cclase As String
    Private ndebe As Double
    Private nhaber As Double
    Private cnumdoc As String
    Private cnumrec As String
    Private dfeccnt As Date
    Private ccodofi As String
    Private cpoliza As String
    Private cconcepto As String
    Private dfecmod As Date
    Private ccodusu As String
    Private nCuenta As Integer
    Private cNumpar As String
    Private ds As New DataSet
    Private llbandera As Boolean
    Private cnomchq As String
    Private cmonletras As String
    Private cBanco As String
    Private cCuenta As String
    Private nMonchq As Double
    Private nSalTra As Double
    ' Parametros para formar cuentas contable
    Private pccodcta As String
    Private pccodlin As String
    Private pcnorref As String
    Private pccondic As String

    Private cconceptopar As String
    Private cCodpres As String
#End Region

#Region " Propiedades "
    Public Property _ccodpres() As String
        Get
            Return cCodpres
        End Get
        Set(ByVal Value As String)
            cCodpres = Value
        End Set
    End Property

    Public Property _cnomchq() As String
        Get
            Return cnomchq
        End Get
        Set(ByVal Value As String)
            cnomchq = Value
        End Set
    End Property
    Public Property _cmonletras() As String
        Get
            Return cmonletras
        End Get
        Set(ByVal Value As String)
            cmonletras = Value
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
    Public Property _nMonchq() As Double
        Get
            Return nMonchq
        End Get
        Set(ByVal Value As Double)
            nMonchq = Value
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


    Public Property _cNumpar() As String
        Get
            Return cNumpar
        End Get
        Set(ByVal Value As String)
            cNumpar = Value
        End Set
    End Property

    Public Property _ffondos() As String
        Get
            Return ffondos
        End Get
        Set(ByVal Value As String)
            ffondos = Value
        End Set
    End Property
    Public Property _cnumcom() As String
        Get
            Return cnumcom
        End Get
        Set(ByVal Value As String)
            cnumcom = Value
        End Set
    End Property

    Public Property _cnumlin() As String
        Get
            Return cnumlin
        End Get
        Set(ByVal Value As String)
            cnumlin = Value
        End Set
    End Property
    Public Property _ccodcta() As String
        Get
            Return ccodcta
        End Get
        Set(ByVal Value As String)
            ccodcta = Value
        End Set
    End Property
    Public Property _cclase() As String
        Get
            Return cclase
        End Get
        Set(ByVal Value As String)
            cclase = Value
        End Set
    End Property
    Public Property _ndebe() As Double
        Get
            Return ndebe
        End Get
        Set(ByVal Value As Double)
            ndebe = Value
        End Set
    End Property
    Public Property _nhaber() As Double
        Get
            Return nhaber
        End Get
        Set(ByVal Value As Double)
            nhaber = Value
        End Set
    End Property
    Public Property _cnumdoc() As String
        Get
            Return cnumdoc
        End Get
        Set(ByVal Value As String)
            cnumdoc = Value
        End Set
    End Property
    Public Property _cnumrec() As String
        Get
            Return cnumrec
        End Get
        Set(ByVal Value As String)
            cnumrec = Value
        End Set
    End Property

    Public Property _ccodofi() As String
        Get
            Return ccodofi
        End Get
        Set(ByVal Value As String)
            ccodofi = Value
        End Set
    End Property
    Public Property _cpoliza() As String
        Get
            Return cpoliza
        End Get
        Set(ByVal Value As String)
            cpoliza = Value
        End Set
    End Property
    Public Property _dfeccnt() As Date
        Get
            Return dfeccnt
        End Get
        Set(ByVal Value As Date)
            dfeccnt = Value
        End Set
    End Property
    Public Property _dfecmod() As Date
        Get
            Return dfecmod
        End Get
        Set(ByVal Value As Date)
            dfecmod = Value
        End Set
    End Property
    Public Property _cconcepto() As String
        Get
            Return cconcepto
        End Get
        Set(ByVal Value As String)
            cconcepto = Value
        End Set
    End Property
    Public Property _ccodusu() As String
        Get
            Return ccodusu
        End Get
        Set(ByVal Value As String)
            ccodusu = Value
        End Set
    End Property
    Public Property _nCuenta() As Integer
        Get
            Return nCuenta
        End Get
        Set(ByVal Value As Integer)
            nCuenta = Value
        End Set
    End Property
    Public Property _llbandera() As Boolean
        Get
            Return llbandera
        End Get
        Set(ByVal Value As Boolean)
            llbandera = Value
        End Set
    End Property
    Public Property _nSalTra() As Double
        Get
            Return nSalTra
        End Get
        Set(ByVal Value As Double)
            nSalTra = Value
        End Set
    End Property

    Public Property _pccodcta() As String
        Get
            Return pccodcta
        End Get
        Set(ByVal Value As String)
            pccodcta = Value
        End Set
    End Property

    Public Property _pccodlin() As String
        Get
            Return pccodlin
        End Get
        Set(ByVal Value As String)
            pccodlin = Value
        End Set
    End Property

    Public Property _pcnorref() As String
        Get
            Return pcnorref
        End Get
        Set(ByVal Value As String)
            pcnorref = Value
        End Set
    End Property

    Public Property _pccondic() As String
        Get
            Return pccondic
        End Get
        Set(ByVal Value As String)
            pccondic = Value
        End Set
    End Property
    '***********************************
    Private pcnuming As String
    Public Property _pcnuming() As String
        Get
            Return pcnuming
        End Get
        Set(ByVal Value As String)
            pcnuming = Value
        End Set
    End Property
    '************************************
    Private pccodfue As String
    Public Property _pccodfue() As String
        Get
            Return pccodfue
        End Get
        Set(ByVal Value As String)
            pccodfue = Value
        End Set
    End Property
    '************************************
    Private pdfecsis As Date
    Public Property _pdfecsis() As Date
        Get
            Return pdfecsis
        End Get
        Set(ByVal Value As Date)
            pdfecsis = Value
        End Set
    End Property
    '************************************
    Private pccodcli As String
    Public Property _pccodcli() As String
        Get
            Return pccodcli
        End Get
        Set(ByVal Value As String)
            pccodcli = Value
        End Set
    End Property

    '************************************
    Private pccodusu As String
    Public Property _pccodusu() As String
        Get
            Return pccodusu
        End Get
        Set(ByVal Value As String)
            pccodusu = Value
        End Set
    End Property

    Public Property _cconceptopar() As String
        Get
            Return cconceptopar
        End Get
        Set(ByVal Value As String)
            cconceptopar = Value
        End Set
    End Property

#End Region

#Region " Metodos "
    Public Function CargaPartida() As DataSet

        Try

            Dim rs As New DataSet, dr As DataRow
            Dim dat_AdPar As New DataTable("Partidas")
            dat_AdPar.Clear()
            'Agregando la Encabezado de la Factura
            dat_AdPar.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_AdPar.Columns.Add("cCodcta", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("cdescri", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("nDebe", Type.GetType("System.Decimal"))
            dat_AdPar.Columns.Add("nHaber", Type.GetType("System.Decimal"))
            dat_AdPar.Columns.Add("cConcepto", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("ffondos", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("ccodofi", Type.GetType("System.String"))
            rs.Tables.Add(dat_AdPar)

            Return rs

        Catch ex As Exception

        End Try

    End Function
    Public Function ModPartida() As String
        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lcRetorno As String = "0"


        Try
            '-------------------------
            'Inserta en la Diario
            '-------------------------
            Dim entidadDiario As New SIM.EL.diario
            Dim eDiario As New SIM.BL.cDiario

            'entidadDiario.cnumcom = lcNumpar
            'eDiario.ObtenerDiario(entidadDiario)

            'Obtiene el numero de la partida
            entidadDiario.cnumcom = Me.cnumcom
            entidadDiario.ccodofi = Me.ccodofi
            entidadDiario.ctipasi = "012"
            entidadDiario.ctipmon = "1"
            entidadDiario.cglosa = Me.cconcepto
            entidadDiario.cnumdoc = Me.cnumdoc
            entidadDiario.ccodreg = " "
            entidadDiario.ccodrev = " "
            entidadDiario.ccodruc = " "
            entidadDiario.dfeccnt = Me.dfeccnt
            entidadDiario.dfecdoc = Me.dfeccnt
            entidadDiario.dfecmod = Me.dfecmod
            entidadDiario.ffondos = Me.ffondos
            entidadDiario.ccodusu = Me.ccodusu
            entidadDiario.cestado = " "
            entidadDiario.cfv = " "
            entidadDiario.nccompra = 0
            entidadDiario.ncventa = 0
            entidadDiario.nfln = 0
            entidadDiario.ntcfijo = 0
            'entidadDiario.ccodemp = " "
            entidadDiario.cnrodoc = " "


            eDiario.ActualizarDiario(entidadDiario)

            '----------------------------
            'Inserta Cntamov
            '----------------------------

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            'entidadCntamov.cnumcom = lcNumpar
            'eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = Me.cnumcom
            entidadCntamov.ccodsec = " "
            entidadCntamov.ffondos = Me.ffondos
            entidadCntamov.cnumlin = Me.cnumlin
            entidadCntamov.ccodcta = Me.ccodcta
            entidadCntamov.cclase = Me.cclase
            entidadCntamov.ndebe = Me.ndebe
            entidadCntamov.nhaber = Me.nhaber
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cnumdoc
            entidadCntamov.dfeccnt = Me.dfeccnt
            entidadCntamov.dfecmod = Me.dfecmod
            entidadCntamov.ccodpres = " "
            entidadCntamov.cconcepto = Me.cconcepto
            entidadCntamov.cpoliza = " "
            entidadCntamov.ccodofi = Me.ccodofi
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = " "
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.ccodusu

            eCntamov.ActualizarCntamov(entidadCntamov)

            Return lcRetorno
        Catch ex As Exception
            Return lcRetorno = "0"
        End Try

    End Function

    Public Function AdPartida() As String
        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lcRetorno As String = "0"


        Try
            '-------------------------
            'Inserta en la Diario
            '-------------------------
            If Me.nCuenta = 1 Then
                Dim entidadDiario As New SIM.EL.diario
                Dim eDiario As New SIM.BL.cDiario

                entidadDiario.cnumcom = lcNumpar
                eDiario.ObtenerDiario(entidadDiario)

                'Obtiene el numero de la partida

                Me.cNumpar = cClase.fxStevo(Me.dfeccnt)

                entidadDiario.cnumcom = Me.cNumpar
                entidadDiario.ccodofi = Me.ccodofi
                entidadDiario.ctipasi = "012"
                entidadDiario.ctipmon = "1"
                entidadDiario.cglosa = Me.cconcepto
                entidadDiario.cnumdoc = Me.cnumdoc
                entidadDiario.ccodreg = " "
                entidadDiario.ccodrev = " "
                entidadDiario.ccodruc = " "
                entidadDiario.dfeccnt = Me.dfeccnt
                entidadDiario.dfecdoc = Me.dfeccnt
                entidadDiario.dfecmod = Me.dfecmod
                entidadDiario.ffondos = Me.ffondos
                entidadDiario.ccodusu = Me.ccodusu
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

            '----------------------------
            'Inserta Cntamov
            '----------------------------

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            entidadCntamov.cnumcom = lcNumpar
            eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = Me.cNumpar
            entidadCntamov.ccodsec = " "
            entidadCntamov.ffondos = Me.ffondos
            entidadCntamov.cnumlin = Me.cnumlin
            entidadCntamov.ccodcta = Me.ccodcta
            entidadCntamov.cclase = Me.cclase
            entidadCntamov.ndebe = Me.ndebe
            entidadCntamov.nhaber = Me.nhaber
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cnumdoc
            entidadCntamov.dfeccnt = Me.dfeccnt
            entidadCntamov.dfecmod = Me.dfecmod
            entidadCntamov.ccodpres = Me.cCodpres
            entidadCntamov.cconcepto = Me.cconcepto
            entidadCntamov.cpoliza = Me.cpoliza
            entidadCntamov.ccodofi = Me.ccodofi
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = " "
            entidadCntamov.ccodcli = IIf(IsDBNull(Me.pccodcli) Or Me.pccodcli Is Nothing, "", Me.pccodcli)
            entidadCntamov.ccodusu1 = Me.ccodusu

            entidadCntamov.cnumrec = IIf(IsDBNull(Me.cnumrec) Or Me.cnumrec Is Nothing, "", Me.cnumrec)

            eCntamov.agregarCntamov(entidadCntamov)

            lcRetorno = Me.cNumpar

            Return lcRetorno

        Catch ex As Exception
            Return lcRetorno = "0"
        End Try

    End Function

    Public Function AdChqs() As String
        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lcRetorno As String = "0"


        Try
            '-------------------------
            'Inserta en la Diario
            '-------------------------
            If Me.nCuenta = 1 Then
                Dim entidadDiario As New SIM.EL.diario
                Dim eDiario As New SIM.BL.cDiario

                entidadDiario.cnumcom = lcNumpar
                eDiario.ObtenerDiario(entidadDiario)

                'Obtiene el numero de la partida
                Me.cNumpar = cClase.fxStevo(Me.dfeccnt)

                entidadDiario.cnumcom = Me.cNumpar
                entidadDiario.ccodofi = Me.ccodofi
                entidadDiario.ctipasi = "012"
                entidadDiario.ctipmon = "1"
                entidadDiario.cglosa = Me.cconcepto
                entidadDiario.cnumdoc = Me.cnumdoc
                entidadDiario.ccodreg = " "
                entidadDiario.ccodrev = " "
                entidadDiario.ccodruc = " "
                entidadDiario.dfeccnt = Me.dfeccnt
                entidadDiario.dfecdoc = Me.dfeccnt
                entidadDiario.dfecmod = Me.dfecmod
                entidadDiario.ffondos = Me.ffondos
                entidadDiario.ccodusu = Me.ccodusu
                entidadDiario.cestado = " "
                entidadDiario.cfv = " "
                entidadDiario.nccompra = 0
                entidadDiario.ncventa = 0
                entidadDiario.nfln = 0
                entidadDiario.ntcfijo = 0
                'entidadDiario.ccodemp = " "
                entidadDiario.cnrodoc = " "

                eDiario.agregarDiario(entidadDiario)

                '----------------------------
                'Inserta en la ctbdchq
                '----------------------------

                Dim entidadCtbdChq As New SIM.EL.ctbdchq
                Dim eCtbdchq As New SIM.BL.cCtbdchq
                Dim pcCotacte As String

                pcCotacte = Me.cCuenta



                entidadCtbdChq.cnumcom = Me.cNumpar
                eCtbdchq.ObtenerCtbdchq(entidadCtbdChq)

                entidadCtbdChq.cnumcom = Me.cNumpar
                entidadCtbdChq.cmonchq = Me.nMonchq
                entidadCtbdChq.cnomchq = Me.cnomchq
                entidadCtbdChq.cnrochq = Me.cnumdoc
                entidadCtbdChq.cnomcta = " "
                entidadCtbdChq.dfeccnt2 = Me.dfeccnt
                entidadCtbdChq.ccodbco = Me.cBanco
                entidadCtbdChq.cflc = " "
                entidadCtbdChq.lprint = True
                entidadCtbdChq.ccoddeb = " "
                entidadCtbdChq.ccodhab = " "
                entidadCtbdChq.cctacte = Me.cCuenta
                entidadCtbdChq.cmonlet = Me.cmonletras

                eCtbdchq.Agregar(entidadCtbdChq)

            End If


            '----------------------------
            'Inserta Cntamov
            '----------------------------

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            entidadCntamov.cnumcom = lcNumpar
            eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = Me.cNumpar
            entidadCntamov.ccodsec = " "
            entidadCntamov.ffondos = Me.ffondos
            entidadCntamov.cnumlin = Me.cnumlin
            entidadCntamov.ccodcta = Me.ccodcta
            entidadCntamov.cclase = Me.cclase
            entidadCntamov.ndebe = Me.ndebe
            entidadCntamov.nhaber = Me.nhaber
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cnumdoc
            entidadCntamov.dfeccnt = Me.dfeccnt
            entidadCntamov.dfecmod = Me.dfecmod
            entidadCntamov.ccodpres = " "
            entidadCntamov.cconcepto = Me.cconcepto
            entidadCntamov.cpoliza = Me.cpoliza
            entidadCntamov.ccodofi = Me.ccodofi
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = " "
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.ccodusu

            eCntamov.agregarCntamov(entidadCntamov)

            lcRetorno = Me.cNumpar

            Return lcRetorno

        Catch ex As Exception
            Return lcRetorno = "0"
        End Try

    End Function

    Public Function ModChqs() As String
        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lcRetorno As String = "0"


        Try
            '-------------------------
            'Inserta en la Diario
            '-------------------------
            Dim entidadDiario As New SIM.EL.diario
            Dim eDiario As New SIM.BL.cDiario

            entidadDiario.cnumcom = Me.cnumcom
            entidadDiario.ccodofi = Me.ccodofi
            entidadDiario.ctipasi = "012"
            entidadDiario.ctipmon = "1"
            entidadDiario.cglosa = Me.cconcepto
            entidadDiario.cnumdoc = Me.cnumdoc
            entidadDiario.ccodreg = " "
            entidadDiario.ccodrev = " "
            entidadDiario.ccodruc = " "
            entidadDiario.dfeccnt = Me.dfeccnt
            entidadDiario.dfecdoc = Me.dfeccnt
            entidadDiario.dfecmod = Me.dfecmod
            entidadDiario.ffondos = Me.ffondos
            entidadDiario.ccodusu = Me.ccodusu
            entidadDiario.cestado = " "
            entidadDiario.cfv = " "
            entidadDiario.nccompra = 0
            entidadDiario.ncventa = 0
            entidadDiario.nfln = 0
            entidadDiario.ntcfijo = 0
            'entidadDiario.ccodemp = " "
            entidadDiario.cnrodoc = " "

            eDiario.ActualizarDiario(entidadDiario)

            '----------------------------
            'Inserta Ctbdchqs
            '----------------------------
            Dim entidadCtbdChq As New SIM.EL.ctbdchq
            Dim eCtbdchq As New SIM.BL.cCtbdchq
            Dim pcCotacte As String

            pcCotacte = Me.cCuenta

            'entidadCtbdChq.cnumcom = Me.cNumpar
            'eCtbdchq.ObtenerCtbdchq(entidadCtbdChq)

            entidadCtbdChq.cnumcom = Me.cnumcom
            entidadCtbdChq.cmonchq = Me.nMonchq
            entidadCtbdChq.cnomchq = Me.cnomchq
            entidadCtbdChq.cnrochq = Me.cnumdoc
            entidadCtbdChq.cnomcta = " "
            entidadCtbdChq.dfeccnt2 = Me.dfeccnt
            entidadCtbdChq.ccodbco = Me.cBanco  'Me.cmbBancos.SelectedItem.Text.Trim
            entidadCtbdChq.cflc = " "
            entidadCtbdChq.lprint = True
            entidadCtbdChq.ccoddeb = " "
            entidadCtbdChq.ccodhab = " "
            entidadCtbdChq.cctacte = Me.cCuenta
            entidadCtbdChq.cmonlet = Me.cmonletras

            eCtbdchq.ActualizarCtbdchq(entidadCtbdChq)

            '----------------------------
            'Inserta Cntamov
            '----------------------------

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov


            entidadCntamov.cnumcom = Me.cnumcom
            entidadCntamov.ccodsec = " "
            entidadCntamov.ffondos = Me.ffondos
            entidadCntamov.cnumlin = Me.cnumlin
            entidadCntamov.ccodcta = Me.ccodcta
            entidadCntamov.cclase = Me.cclase
            entidadCntamov.ndebe = Me.ndebe
            entidadCntamov.nhaber = Me.nhaber
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cnumdoc
            entidadCntamov.dfeccnt = Me.dfeccnt
            entidadCntamov.dfecmod = Me.dfecmod
            entidadCntamov.ccodpres = " "
            entidadCntamov.cconcepto = Me.cconcepto
            entidadCntamov.cpoliza = " "
            entidadCntamov.ccodofi = Me.ccodofi
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = " "
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.ccodusu

            eCntamov.ActualizarCntamov(entidadCntamov)

            lcRetorno = Me.cnumcom

            Return lcRetorno

        Catch ex As Exception
            Return lcRetorno = "0"
        End Try

    End Function

    Public Function BuscaPartidaDes(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp5(ccodigo, cfondo, ccadena)

        Return ds

    End Function

    Public Function BuscaPartidaDet(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp6(ccodigo, cfondo, ccadena)

        Return ds

    End Function
    Public Function BuscaPartidaDesChq(ByVal ccodigo As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp7(ccodigo)

        Return ds

    End Function

    Public Function Reporte(ByVal ccodigo As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp8(ccodigo)

        Return ds

    End Function

    Public Function ReportePartida(ByVal ccodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet

        Dim eCtbmcta As New SIM.BL.cCtbmcta

        ds = eCtbmcta.ObtenerDataSetEsp9(ccodigo, cfondo, ccadena)

        Return ds

    End Function

    Public Function PartidaTraslado() As Integer
        Dim clsCrefunc As New crefunc
        Dim lnnumlin As Integer = 0
        Dim lcctactb As String
        Dim lcctactb1 As String

        Dim oktransac As String
        'Saldo a Trasladar
        Try
            lcctactb = clsCrefunc.fxcuentacontable(Me.pccodcta, Me.pccodlin, Me.pcnorref, "KP", "C", Me.pccondic, "", "", Me.nSalTra, 0, 0)
        Catch ex As Exception

        End Try
        If lcctactb = "*" Then
            oktransac = 2
            Throw New Exception("Mesanje personalizado")
            Return -1 'Error porque no existe   
        End If
        ' Cuenta cartera saneada
        Try
            lcctactb1 = clsCrefunc.fxcuentacontable(Me.pccodcta, Me.pccodlin, Me.pcnorref, "KP", "C", Me.pccondic + "RS", "", "", Me.nSalTra, 0, 0)
        Catch ex As Exception

        End Try
        If lcctactb1 = "*" Then
            oktransac = 2
            Throw New Exception("Mesanje personalizado")
            Return -1 'Error porque no existe   
        End If


        Me.cnumcom = clsCrefunc.fxStevo(Me.pdfecsis)

        'cntamov
        Dim entidadcntamov As New SIM.EL.cntamov
        Dim ecntamov As New SIM.BL.cCntamov
        entidadcntamov.cnumcom = Me.cNumpar

        'diario
        Dim entidaddiario As New SIM.EL.diario
        Dim ediario As New SIM.BL.cDiario
        entidaddiario.cnumcom = Me.cNumpar

        entidaddiario.cnumcom = Me.cnumcom
        entidaddiario.cglosa = "Traslado a Saneada de cred. No. " & Me.pccodcta
        entidaddiario.cnumdoc = Me.pcnuming
        entidaddiario.dfeccnt = Me.pdfecsis
        entidaddiario.cestado = " "
        entidaddiario.ccodofi = Me.pccodcta.Substring(3, 3)
        entidaddiario.ffondos = Me.pccodfue
        entidaddiario.dfecdoc = Me.pdfecsis
        entidaddiario.dfecmod = Me.pdfecsis
        ediario.agregarDiario(entidaddiario)

        'contabilidad
        lnnumlin = lnnumlin + 1
        entidadcntamov.cnumcom = Me.cnumcom
        entidadcntamov.ccodcta = lcctactb
        entidadcntamov.cnumlin = lnnumlin
        entidadcntamov.nhaber = Me.nSalTra
        entidadcntamov.ndebe = 0
        entidadcntamov.ccodpres = Me.pccodcta
        entidadcntamov.cnumdoc = Me.pcnuming
        entidadcntamov.ccodofi = Me.pccodcta.Substring(3, 3)
        entidadcntamov.cflc = " "
        entidadcntamov.dfeccnt = Me.pdfecsis
        entidadcntamov.ccodusu1 = Me.pccodusu
        entidadcntamov.ffondos = Me.pccodfue
        entidadcntamov.cclase = Left(lcctactb, 1)
        entidadcntamov.cpoliza = "TR"
        entidadcntamov.dfecmod = Me.pdfecsis

        entidadcntamov.ccodsec = ""
        entidadcntamov.cconcepto = "TRASLADO A CARTERA SANEADA"
        entidadcntamov.cnumpol = ""
        entidadcntamov.ccodreg = Me.pccodcta.Substring(0, 3)
        entidadcntamov.ccodcli = Me.pccodcli

        oktransac = ecntamov.agregarCntamov(entidadcntamov)

        'contabilidad
        lnnumlin = lnnumlin + 1
        entidadcntamov.cnumcom = Me.cnumcom
        entidadcntamov.ccodcta = lcctactb1
        entidadcntamov.cnumlin = lnnumlin
        entidadcntamov.nhaber = 0
        entidadcntamov.ndebe = Me.nSalTra
        entidadcntamov.ccodpres = Me.pccodcta
        entidadcntamov.cnumdoc = Me.pcnuming
        entidadcntamov.ccodofi = Me.pccodcta.Substring(3, 3)
        entidadcntamov.cflc = " "
        entidadcntamov.dfeccnt = Me.pdfecsis
        entidadcntamov.ccodusu1 = Me.pccodusu
        entidadcntamov.ffondos = Me.pccodfue
        entidadcntamov.cclase = Left(lcctactb1, 1)
        entidadcntamov.cpoliza = "TR"
        entidadcntamov.dfecmod = Me.pdfecsis

        entidadcntamov.ccodsec = ""
        entidadcntamov.cconcepto = "TRASLADO A CARTERA SANEADA"
        entidadcntamov.cnumpol = ""
        entidadcntamov.ccodreg = Me.pccodcta.Substring(0, 3)
        entidadcntamov.ccodcli = Me.pccodcli

        oktransac = ecntamov.agregarCntamov(entidadcntamov)

    End Function
    Public Function EliminarRegistro() As Integer
        Dim entidadCntamov As New SIM.EL.cntamov
        Dim eCntamov As New SIM.BL.cCntamov
        Dim lcRetorno As String = "0"
        Try
            entidadCntamov.cnumcom = Me.cNumpar
            eCntamov.EliminarDetalle(entidadCntamov)
            lcRetorno = Me.cNumpar
            Return lcRetorno
        Catch ex As Exception
            Return lcRetorno = "0"
        End Try

    End Function

    Public Function AdPartidaDetalle() As String
        Dim cClase As New SIM.BL.crefunc
        Dim lcNumpar As String
        Dim lcRetorno As String = "0"


        Try

            '----------------------------
            'Inserta Cntamov
            '----------------------------

            Dim entidadCntamov As New SIM.EL.cntamov
            Dim eCntamov As New SIM.BL.cCntamov

            entidadCntamov.cnumcom = lcNumpar
            eCntamov.ObtenerCntamov(entidadCntamov)

            entidadCntamov.cnumcom = Me.cNumpar
            entidadCntamov.ccodsec = " "
            entidadCntamov.ffondos = Me.ffondos
            entidadCntamov.cnumlin = Me.cnumlin
            entidadCntamov.ccodcta = Me.ccodcta
            entidadCntamov.cclase = Me.cclase
            entidadCntamov.ndebe = Me.ndebe
            entidadCntamov.nhaber = Me.nhaber
            entidadCntamov.cflc = " "
            entidadCntamov.nfln = 0
            entidadCntamov.cnumdoc = Me.cnumdoc
            entidadCntamov.dfeccnt = Me.dfeccnt
            entidadCntamov.dfecmod = Me.dfecmod
            entidadCntamov.ccodpres = " "
            entidadCntamov.cconcepto = Me.cconceptopar
            entidadCntamov.cpoliza = Me.cpoliza
            entidadCntamov.ccodofi = Me.ccodofi
            entidadCntamov.cnumpol = " "
            entidadCntamov.ccodreg = " "
            entidadCntamov.ccodcli = " "
            entidadCntamov.ccodusu1 = Me.ccodusu


            eCntamov.agregarCntamov(entidadCntamov)

            lcRetorno = Me.cNumpar

            Return lcRetorno

        Catch ex As Exception
            Return lcRetorno = "0"
        End Try

    End Function
    
#End Region

End Class
