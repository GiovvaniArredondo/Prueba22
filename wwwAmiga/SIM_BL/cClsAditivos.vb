Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Imports System.IO

Public Class cClsAditivos

    Dim ds As New DataSet
    Dim dsPlan As DataTable
    Dim myconnection As SqlConnection
    Dim mycommand As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim vCadena As String
    Dim sql As String
    Private vCnn As String
    Public Property Cnn() As String
        Get
            Return vCnn
        End Get
        Set(ByVal Value As String)
            vCnn = Value
        End Set
    End Property

    Private _pdfeclim As Date
    Public Property pdfeclim() As Date
        Get
            Return _pdfeclim
        End Get
        Set(ByVal Value As Date)
            _pdfeclim = Value
        End Set
    End Property

    Private _pnsegmax As Decimal
    Public Property pnsegmax() As Decimal
        Get
            Return _pnsegmax
        End Get
        Set(ByVal Value As Decimal)
            _pnsegmax = Value
        End Set
    End Property

    Private _pdfecseg1 As Date
    Public Property pdfecseg1() As Date
        Get
            Return _pdfecseg1
        End Get
        Set(ByVal Value As Date)
            _pdfecseg1 = Value
        End Set
    End Property

    Private _pdfecseg2 As Date
    Public Property pdfecseg2() As Date
        Get
            Return _pdfecseg2
        End Get
        Set(ByVal Value As Date)
            _pdfecseg2 = Value
        End Set
    End Property


    Private _pnsalcap As Decimal
    Public Property pnsalcap() As Decimal
        Get
            Return _pnsalcap
        End Get
        Set(ByVal Value As Decimal)
            _pnsalcap = Value
        End Set
    End Property

    Private _pccodcta As String
    Public Property pccodcta() As String
        Get
            Return _pccodcta
        End Get
        Set(ByVal value As String)
            _pccodcta = value
        End Set
    End Property

    Private _pdfecval As Date
    Public Property pdfecval() As Date
        Get
            Return _pdfecval
        End Get
        Set(ByVal Value As Date)
            _pdfecval = Value
        End Set
    End Property

    Private _pdfecsis As Date
    Public Property pdfecsis() As Date
        Get
            Return _pdfecsis
        End Get
        Set(ByVal Value As Date)
            _pdfecsis = Value
        End Set
    End Property

    Private _pcnrolin As String
    Public Property pcnrolin() As String
        Get
            Return _pcnrolin
        End Get
        Set(ByVal value As String)
            _pcnrolin = value
        End Set
    End Property

    Private _pnmancta As Decimal
    Public Property pnmancta() As Decimal
        Get
            Return _pnmancta
        End Get
        Set(ByVal Value As Decimal)
            _pnmancta = Value
        End Set
    End Property

    Private _pdfecefec6 As Date
    Public Property pdfecefec6() As Date
        Get
            Return _pdfecefec6
        End Get
        Set(ByVal value As Date)
            _pdfecefec6 = value
        End Set
    End Property

    Private _pnmancta6 As Decimal
    Public Property pnmancta6() As Decimal
        Get
            Return _pnmancta6
        End Get
        Set(ByVal value As Decimal)
            _pnmancta6 = value
        End Set
    End Property
    Private _pnmancta5 As Decimal
    Public Property pnmancta5() As Decimal
        Get
            Return _pnmancta5
        End Get
        Set(ByVal value As Decimal)
            _pnmancta5 = value
        End Set
    End Property

    Private _pcCostas As String
    Public Property pcCostas() As String
        Get
            Return _pcCostas
        End Get
        Set(ByVal value As String)
            _pcCostas = value
        End Set
    End Property
    Private _pcAnotacion As String
    Public Property pcAnotacion() As String
        Get
            Return _pcAnotacion
        End Get
        Set(ByVal value As String)
            _pcAnotacion = value
        End Set
    End Property
    Private _pcDeudores As String
    Public Property pcDeudores() As String
        Get
            Return _pcDeudores
        End Get
        Set(ByVal value As String)
            _pcDeudores = value
        End Set
    End Property

    Private _pcPorCob As String
    Public Property pcPorCob() As String
        Get
            Return _pcPorCob
        End Get
        Set(ByVal value As String)
            _pcPorCob = value
        End Set
    End Property

    Private _pnsegvid As Decimal
    Public Property pnsegvid() As Decimal
        Get
            Return _pnsegvid
        End Get
        Set(ByVal value As Decimal)
            _pnsegvid = value
        End Set
    End Property

    Private _pnvaluo As Decimal
    Public Property pnvaluo() As Decimal
        Get
            Return _pnvaluo
        End Get
        Set(ByVal value As Decimal)
            _pnvaluo = value
        End Set
    End Property

    Private _pniva As Decimal
    Public Property pniva() As Decimal
        Get
            Return _pniva
        End Get
        Set(ByVal value As Decimal)
            _pniva = value
        End Set
    End Property


    Public Function AhorroSimultaneo() As Decimal
        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'Dim ldfecvig As Date
        'Dim lnmonapr As Decimal = 0
        Dim lnahosim As Decimal = 0
        'Dim lcproducto As String = ""

        'Dim lcnrolin As String
        'Dim ldfecult As Date
        'Dim lnmeses As Integer = 1
        'Dim ecredkar As New cCredkar

        'lcnrolin = entidadcremcre.cnrolin


        'ldfecvig = entidadcremcre.dfecvig
        'lcproducto = entidadcremcre.cproducto

        'If ldfecvig >= #11/16/2006# Then
        '    lnahosim = 0.0
        'Else
        '    ldfecult = ecredkar.UltimafechadePago(pccodcta, pdfecval, "04", ldfecvig)
        '    lnmeses = DateDiff(DateInterval.Month, ldfecult, pdfecval)

        '    lnahosim = 2.86 * lnmeses
        'End If
        'If lcNroLin = "0029400" Or lcNroLin = "0063700" Then
        '    lnahosim = 0
        'End If
        'If Left(lcproducto, 1) = "L" Or Left(lcproducto, 1) = "J" Or Left(lcproducto, 1) = "K" Then
        '    lnahosim = 0
        'End If


        Return lnahosim
    End Function

    Public Function SeguroProtege() As Decimal
        Return 0

        'Dim lnmeses As Integer = 0
        'Dim ldfecult As Date
        'Dim ecredkar As New cCredkar

        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'Dim ldfecvig As Date
        'Dim lnmonapr As Decimal = 0
        'Dim lcvida As String = ""
        'ldfecvig = entidadcremcre.dfecvig
        'lnmonapr = entidadcremcre.nmonapr
        'lcvida = IIf(IsDBNull(entidadcremcre.ccodsol), "", entidadcremcre.ccodsol.Trim)

        'ldfecult = ecredkar.UltimafechadePago(pccodcta, pdfecval, "SV", ldfecvig)
        'lnmeses = DateDiff(DateInterval.Month, ldfecult, pdfecval)


        'Dim lnsegvid As Double = 0
        'If lcvida.Trim = "PROTEGE" Then
        '    lnsegvid = Math.Round(lnmonapr * pnsegvid * lnmeses, 2)
        'End If

        'Return lnsegvid
    End Function

    Public Function Depurada() As Decimal
        Dim lndepurada As Decimal = 0
        'Dim ecntamov As New cCntamov
        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'Dim lccodcli As String

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'lccodcli = entidadcremcre.ccodcli

        'ecntamov.ObtieneCuentasporCobrar(lccodcli, pcPorCob)
        'If lndepurada < 0 Then
        '    lndepurada = 0
        'End If
        Return lndepurada
    End Function

    Public Function Deudores() As Decimal
        Dim lndeudores As Decimal = 0
        'Dim ecntamov As New cCntamov
        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'Dim lccodcli As String

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'lccodcli = entidadcremcre.ccodcli


        'lndeudores = ecntamov.ObtieneCuentasporCobrar(lccodcli, pcDeudores)
        'If lndeudores < 0 Then
        '    lndeudores = 0
        'End If

        Return lndeudores
    End Function

    Public Function AnotacionPreventiva() As Decimal
        Dim lnanotacion As Decimal = 0
        'Dim ecntamov As New cCntamov
        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'Dim lccodcli As String

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'lccodcli = entidadcremcre.ccodcli

        'lnanotacion = ecntamov.ObtieneCuentasporCobrar(lccodcli, pcAnotacion)
        'If lnanotacion < 0 Then
        '    lnanotacion = 0
        'End If
        Return lnanotacion
    End Function

    Public Function CostasProcesales() As Decimal
        Dim lncostas As Decimal = 0
        'Dim ecntamov As New cCntamov
        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'Dim lccodcli As String

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'lccodcli = entidadcremcre.ccodcli

        'lncostas = ecntamov.ObtieneCuentasporCobrar(lccodcli, pcCostas)
        'If lncostas < 0 Then
        '    lncostas = 0
        'End If
        Return lncostas
    End Function


    Public Function Aportaciones() As Decimal

        'Dim cobrar_apo As String = ""
        'Dim gnaporta As Double = 0
        'Dim lnaportapagada As Double = 0
        'Dim lcproducto As String = ""

        'Dim ecremcre As New cCremcre
        'Dim entidadcremcre As New cremcre
        'Dim ecredkar As New cCredkar
        'Dim ldfecvig As Date
        Dim lnaporta As Decimal = 0
        'Dim lccodcli As String
        'Dim lcnrolin As String
        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)

        'lccodcli = entidadcremcre.ccodcli
        'ldfecvig = entidadcremcre.dfecvig
        'lcnrolin = entidadcremcre.cnrolin
        'lcproducto = entidadcremcre.cproducto

        'If ldfecvig < #5/1/2009# Then
        '    gnaporta = 2.86
        'Else
        '    gnaporta = 4.0
        'End If

        'lnaportapagada = ecredkar.ObtieneAportacionPagadames(pdfecval, lccodcli)

        'If lnaportapagada >= gnaporta Then
        '    lnaporta = 0
        'Else
        '    lnaporta = gnaporta - lnaportapagada
        'End If

        'cobrar_apo = ecremcre.CobraAportacion(lccodcli)
        ''Aportaciones
        'If lcnrolin = "0075700" Or lcnrolin = "0090100" Then
        '    lnaporta = 0
        'End If

        'If lcnrolin = "0080900" And cobrar_apo = "NO" Then
        '    lnaporta = 0
        'End If
        'If lcnrolin = "0078700" Then
        '    lnaporta = 0
        'End If
        'If Left(lcproducto, 1) = "L" Or Left(lcproducto, 1) = "J" Or Left(lcproducto, 1) = "K" Then
        '    lnaporta = 0
        'End If

        'If lcnrolin = "0096700" Then
        '    lnaporta = 0
        'End If
        ''fondo empleados
        'If lcnrolin = "0029400" Or lcnrolin = "0063700" Then
        '    lnaporta = 0
        'End If

        ''If Month(ldfecvig) = Month(pdfecval) And Year(ldfecvig) = Year(pdfecval) Then
        ''lnaporta = 0
        ''End If

        Return Math.Round(lnaporta, 2)
    End Function


    Public Function ManejoCuenta() As Decimal
        Dim lnmeses As Integer = 0
        Dim ldfecult As Date
        Dim ecredkar As New cCredkar
        Dim lnmanejo As Decimal = 0

        Dim ecremcre As New cCremcre
        Dim entidadcremcre As New cremcre
        Dim ldfecvig As Date
        Dim lcnrolin As String

        entidadcremcre.ccodcta = pccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)
        ldfecvig = entidadcremcre.dfecvig
        lcnrolin = entidadcremcre.cnrolin

        ldfecult = ecredkar.UltimafechadePago(pccodcta, pdfecval, "03", ldfecvig)
        lnmeses = DateDiff(DateInterval.Month, ldfecult, pdfecval)

        If ldfecvig > pdfeclim Then
            lnmanejo = Math.Round((pnmancta + 0.22) * lnmeses, 2)
        Else
            lnmanejo = Math.Round(pnmancta * lnmeses, 2)
        End If

        If ldfecvig >= pdfecefec6 And ldfecvig <= #11/15/2006# Then
            lnmanejo = Math.Round(pnmancta6 * lnmeses, 2)
        End If

        'acta #1566
        If ldfecvig >= #6/15/2009# Then
            lnmanejo = Math.Round((pnmancta + 0.62) * lnmeses, 2)
        End If

        'acta #xxxx
        If ldfecvig >= #4/1/2010# Then
            lnmanejo = Math.Round((pnmancta + 1.62) * lnmeses, 2)
        End If

        
        If lcnrolin = "0029400" Or lcnrolin = "0063700" Then
            lnmanejo = 0
        End If

        If lcnrolin = "0073300" Then
            lnmanejo = Math.Round(pnmancta5 * lnmeses, 2)
        End If
        If lcnrolin = "0078600" Then
            lnmanejo = Math.Round(2.26 * lnmeses, 2)
        End If
        If lcnrolin = "0078800" Or lcnrolin = "0080300" Then
            lnmanejo = Math.Round(2.13 * lnmeses, 2)
        End If
        If lcnrolin = "0084200" Then
            lnmanejo = 0
        End If
        If lcnrolin = "0090800" Or lcnrolin = "0090900" Then
            lnmanejo = Math.Round(9.04 * lnmeses, 2)
        End If
        If lcnrolin = "0093800" Then
            lnmanejo = Math.Round(9.04 * lnmeses, 2)
        End If

        If lcnrolin = "0093800" And ldfecvig >= #3/14/2011# Then
            lnmanejo = Math.Round(4.52 * lnmeses, 2)
        End If

        If lcnrolin = "0075700" Or lcnrolin = "0090100" Then
            lnmanejo = 0
        End If

        If lcnrolin = "0095000" Then
            'If pccodcta = "001001011003203370" Then
            lnmanejo = Math.Round(4.52 * lnmeses, 2)
        End If

        If lcnrolin = "0096500" Or lcnrolin = "0096600" Or lcnrolin = "0096700" Or lcnrolin = "0090800" Or lcnrolin = "0090900" Then
            lnmanejo = Math.Round(9.04 * lnmeses, 2)
        End If

        Return lnmanejo
    End Function
    Public Function manejocuentax() As Decimal
        Dim lnmanejo As Decimal = 0

        Dim ecremcre As New cCremcre
        Dim entidadcremcre As New cremcre
        Dim ldfecvig As Date
        Dim lcnrolin As String


        entidadcremcre.ccodcta = pccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)
        ldfecvig = entidadcremcre.dfecvig
        lcnrolin = entidadcremcre.cnrolin

        If ldfecvig >= pdfeclim Then
            lnmanejo = pnmancta + 0.22
        Else
            lnmanejo = pnmancta
        End If

        If ldfecvig >= pdfecefec6 And ldfecvig <= #11/15/2006# Then
            lnmanejo = pnmancta6
        End If

        If ldfecvig >= #6/15/2009# Then
            lnmanejo = 1.0
        End If

        If ldfecvig >= #4/1/2010# Then
            lnmanejo = pnmancta + 1.62
        End If

        If lcnrolin = "0075700" Or lcnrolin = "0090100" Then
            lnmanejo = 0
        End If


        If lcnrolin = "0029400" Or lcnrolin = "0063700" Then
            lnmanejo = 0
        End If

        If lcnrolin = "0073300" Then
            lnmanejo = pnmancta5
        End If

        If lcnrolin = "0078600" Then
            lnmanejo = 2.26
        End If

        If lcnrolin = "0078800" Or lcnrolin = "0080300" Then
            lnmanejo = 2.13
        End If

        If lcnrolin = "0084200" Then
            lnmanejo = 0.0
        End If

        If lcnrolin = "0090800" Or lcnrolin = "0090900" Then
            lnmanejo = Math.Round(9.04, 2)
        End If
        If lcnrolin = "0093800" Then
            lnmanejo = Math.Round(9.04, 2)
        End If
        If lcnrolin = "0093800" And ldfecvig >= #3/14/2011# Then
            lnmanejo = Math.Round(4.52, 2)
        End If

        If lcnrolin = "0095000" Then
            '            If pccodcta = "001001011003203370" Then
            lnmanejo = Math.Round(4.52, 2)
            'End If
        End If
        If lcnrolin = "0096500" Or lcnrolin = "0096600" Or lcnrolin = "0096700" Or lcnrolin = "0090800" Or lcnrolin = "0090900" Then
            lnmanejo = Math.Round(9.04, 2)
        End If


        Return lnmanejo
    End Function

    Public Function SeguroDeudax() As Decimal
        'Dim ecremcre As New cCremcre
        'Dim entidadcremcre As New cremcre

        'Dim lcnrolin As String
        'Dim ldfecvig As Date

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'lcnrolin = entidadcremcre.cnrolin
        'ldfecvig = entidadcremcre.dfecvig

        Dim lnsegdeu As Decimal = 0

        'If ldfecvig < pdfeclim Then
        '    lnsegdeu = Math.Round(0.00075 * (pnsalcap), 2)
        'End If

        'If ldfecvig >= pdfeclim Then
        '    lnsegdeu = Math.Round(0.001 * (pnsalcap), 2)
        'End If

        'If ldfecvig >= #6/11/2008# Then
        '    lnsegdeu = Math.Round(0.0008 * (pnsalcap), 2)
        'End If


        'Dim lnporseg As Double = 0
        'Dim etabtvar As New cTabtvar
        'Dim ds As New DataSet



        'If lcnrolin = "0095000" Then
        '    lnsegdeu = Math.Round((0.00038 * pnsalcap), 2)
        'End If


        'ds = etabtvar.SeguroporCredito(pccodcta)

        'If ds.Tables(0).Rows.Count = 0 Then
        'Else
        '    If IsDBNull(ds.Tables(0).Rows(0)("nporseg")) Then
        '    Else
        '        lnporseg = ds.Tables(0).Rows(0)("nporseg")
        '        lnsegdeu = Math.Round((lnporseg * pnsalcap), 2)
        '    End If

        'End If


        Return lnsegdeu

    End Function
    Public Function SeguroDeuda() As Decimal
        'Dim lnmeses As Integer = 0
        'Dim ecredkar As New cCredkar
        'Dim ecremcre As New cCremcre
        'Dim entidadcremcre As New cremcre
        'Dim lccodcli As String
        'Dim ldnacimi As Date
        'Dim eclimide As New cClimide
        'Dim entidadclimide As New climide
        'Dim clsppal As New class1
        'Dim lnedad As Integer = 0
        Dim lnsegdeu As Decimal = 0
        'Dim lcnrolin As String

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)
        'lccodcli = entidadcremcre.ccodcli
        'lcnrolin = entidadcremcre.cnrolin

        'entidadclimide.ccodcli = lccodcli
        'eclimide.ObtenerClimide(entidadclimide)

        'ldnacimi = entidadclimide.dnacimi

        'Dim ldfecvig As Date
        'ldfecvig = entidadcremcre.dfecvig

        'lnedad = clsppal.CalculaEdad(ldnacimi)

        'Dim ldfecult As Date

        'ldfecult = ecredkar.UltimafechadePago2(pccodcta, pdfecval, "SD", "SR", ldfecvig)

        'lnmeses = DateDiff(DateInterval.Month, ldfecult, pdfecval)
        'If pnsalcap <= pnsegmax Then
        '    If lnedad >= 75 Then
        '        lnsegdeu = 0
        '    Else
        '        If ldfecvig > pdfeclim Then
        '            lnsegdeu = Math.Round((0.001 * pnsalcap) * lnmeses, 2)
        '        Else
        '            lnsegdeu = Math.Round((0.00075 * pnsalcap) * lnmeses, 2)
        '        End If

        '        If ldfecvig >= pdfecseg1 And ldfecvig <= pdfecseg2 Then
        '            lnsegdeu = Math.Round((0.0008 * pnsalcap) * lnmeses, 2)
        '        End If
        '        If ldfecvig > pdfecseg2 Then
        '            lnsegdeu = Math.Round((0.001 * pnsalcap) * lnmeses, 2)
        '        End If

        '    End If
        'Else
        '    If lnedad < 75 Then

        '        If ldfecvig > pdfeclim Then
        '            lnsegdeu = Math.Round((0.001 * pnsegmax) * lnmeses, 2)
        '        Else
        '            lnsegdeu = Math.Round((0.00075 * pnsegmax) * lnmeses, 2)
        '        End If
        '        If ldfecvig >= pdfecseg1 And ldfecvig <= pdfecseg2 Then
        '            lnsegdeu = Math.Round((0.0008 * pnsalcap) * lnmeses, 2)
        '        End If
        '        If ldfecvig > pdfecseg2 Then
        '            lnsegdeu = Math.Round((0.001 * pnsalcap) * lnmeses, 2)
        '        End If
        '    Else
        '        lnsegdeu = 0
        '    End If

        'End If

        'If lcnrolin = "0086700" Then
        '    lnsegdeu = Math.Round((0.001 * pnsalcap) * lnmeses, 2)
        'End If

        ''fondo empleados
        'If lcnrolin = "0029400" Or lcnrolin = "0063700" Then
        '    lnsegdeu = 0
        'End If


        'Dim lnporseg As Double = 0
        'Dim etabtvar As New cTabtvar
        'Dim ds As New DataSet



        'If lcnrolin = "0095000" Then
        '    lnsegdeu = Math.Round((0.00038 * pnsalcap) * lnmeses, 2)
        'End If


        'ds = etabtvar.SeguroporCredito(pccodcta)

        'If ds.Tables(0).Rows.Count = 0 Then
        'Else
        '    If IsDBNull(ds.Tables(0).Rows(0)("nporseg")) Then
        '    Else
        '        lnporseg = ds.Tables(0).Rows(0)("nporseg")

        '        lnsegdeu = Math.Round((lnporseg * pnsalcap) * lnmeses, 2)


        '    End If

        'End If


        Return lnsegdeu
    End Function

    Public Function SeguroDanos() As Decimal
        Dim lnsegdan As Decimal = 0
        'Dim lnseguro As Decimal = 0
        'Dim ecredkar As New cCredkar
        'Dim ldfecult As Date
        'Dim lnmeses As Integer = 0
        'Dim entidadcremcre As New cremcre
        'Dim ecremcre As New cCremcre
        'Dim lnimpbom As Decimal = 0
        'Dim lniva As Decimal = 0
        'Dim ecretgas As New cCretgas
        'Dim lverifica As Boolean

        'entidadcremcre.ccodcta = pccodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)

        'Dim lnmonsol As Decimal = 0
        'Dim ldfecvig As Date
        'Dim lcnrolin As String = ""

        'ldfecvig = entidadcremcre.dfecvig
        'lnmonsol = entidadcremcre.nmonsol
        'lcnrolin = entidadcremcre.cnrolin

        ''Busca si linea posee en el gasto de seguro de daños (15)
        'lverifica = ecretgas.VerificarsiExisteGasto(lcnrolin, "15")
        'If lverifica = True Or lcnrolin = "0095000" Then
        '    ldfecult = ecredkar.UltimafechadePago(pccodcta, pdfecval, "15", ldfecvig)

        '    lnmeses = DateDiff(DateInterval.Month, ldfecult, pdfecval)


        '    lnseguro = Math.Round((lnmonsol * 0.27 / 1000) * lnmeses, 2)

        '    lnimpbom = Math.Round(lnseguro * 0.02, 2)

        '    lniva = IVA(lnseguro + lnimpbom)
        '    lnsegdan = lnseguro + lnimpbom + lniva

        'End If


        Return lnsegdan

    End Function

    Public Function IVA(ByVal valor As Decimal) As Decimal
        Dim lniva As Decimal = 0
        lniva = Math.Round(valor * 0.13, 2)
        Return lniva
    End Function

    Public Function SeguroDanosx() As Decimal
        Dim lnsegdan As Decimal = 0
        Dim lnseguro As Decimal = 0
        Dim lnimpbom As Decimal = 0
        Dim lniva As Decimal = 0

        Dim lnmonsol As Decimal = 0
        Dim ldfecvig As Date
        Dim lcnrolin As String = ""



        lnseguro = Math.Round(pnvaluo * 0.27 / 1000, 2)

        lnimpbom = Math.Round(lnseguro * 0.02, 2)

        lniva = IVA(lnseguro + lnimpbom)
        lnsegdan = lnseguro + lnimpbom + lniva




        Return lnsegdan

    End Function
    Public Function ObtenerIVACargos(ByVal ds As DataSet, ByVal pniva As Double) As Decimal
        Dim fila As DataRow
        Dim lnIVA As Double = 0
        For Each fila In ds.Tables(0).Rows
            If fila("cflag") = "X" Then 'aplica iva
                lnIVA = lnIVA + Math.Round(fila("nmongas") * pniva, 2)
            End If
        Next
        Return lnIVA
    End Function
    Public Function ObtenerSumaCargos(ByVal ds As DataSet) As Decimal
        Dim fila As DataRow
        Dim lncargos As Double = 0
        For Each fila In ds.Tables(0).Rows

            lncargos = lncargos + Math.Round(fila("nmongas"), 2)

        Next
        Return lncargos
    End Function
    Public Function CargosdeCuotas(ByVal ccodigo As String, ByVal dfecha As Date) As Decimal
        Dim lnmeses As Integer = 0
        Dim ldfecult As Date
        Dim ecredkar As New cCredkar
        Dim lncargo As Decimal = 0
        Dim lncargoteo As Decimal = 0
        Dim ecredppg As New cCredppg
        Dim ecremcre As New cCremcre
        Dim entidadcremcre As New cremcre
        Dim ldfecvig As Date
        Dim lcfrecint As String
        Dim lcfreccap As String = "M"

        Dim ecredgas As New cCredgas
        Dim entidadcredgas As New credgas

        entidadcremcre.ccodcta = pccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)
        ldfecvig = entidadcremcre.dfecvig
        lcfrecint = entidadcremcre.cfrecint
        lcfreccap = entidadcremcre.cfreccap

        '--------------------------------------------------------------------------------------------------------
        Dim lnmanejoreal As Decimal = 0
        lnmanejoreal = ecredkar.ObtenerMontoPagado(pccodcta, dfecha, ccodigo)

        Dim lcnrocuo As String = "001"
        lcnrocuo = ecredppg.CuotasTeoricas(pccodcta, dfecha)
        Dim lnmanejoteo As Decimal = 0
        lnmanejoteo = ecredgas.ObtenerGastohastafecha(ccodigo, pccodcta, lcnrocuo)



        lncargo = Math.Round(lnmanejoteo - lnmanejoreal, 2)
        If lncargo < 0 Then
            lncargo = 0
        End If
        If lncargo = 0 Then
            'verifica si ya pago en el mes esa comision
            Dim dtp As New DataTable
            dtp = ecredkar.ObtenerUltimoPagosegunConcepto(pccodcta, dfecha, ccodigo)
            If dtp.Rows.Count = 0 Then
                lncargo = ecredgas.ObtenerGastodeCuota(ccodigo, pccodcta, lcnrocuo)
            Else
                Dim ldultgas As Date
                ldultgas = dtp.Rows(0)("dfecpro")
                'Compara el mes con la fecha
                If ldultgas.Month = dfecha.Month Then 'ya pago
                Else
                    ' lncargo = ecredgas.ObtenerGastodeCuota(ccodigo, pccodcta, lcnrocuo)
                    lncargo = 0
                End If
            End If
        End If

        Return lncargo
    End Function

End Class