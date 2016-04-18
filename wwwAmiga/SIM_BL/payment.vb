Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Text
'calculos en la forma de pagos

Public Class payment

#Region "Propiedades"
    Private _gnpergra As Integer
    Public Property gnpergra() As Integer
        Get
            gnpergra = _gnpergra
        End Get
        Set(ByVal value As Integer)
            _gnpergra = value
        End Set
    End Property

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

    '    Private lncappag As Double
    '   Public Property pncappag() As Double
    '      Get
    '         pncappag = lncappag
    '    End Get
    '   Set(ByVal Value As Double)
    '      lncappag = Value
    ' End Set
    'End Property

    Private lnsalint As Double
    Public Property pnsalint() As Double
        Get
            pnsalint = lnsalint
        End Get
        Set(ByVal Value As Double)
            lnsalint = Value
        End Set
    End Property
    Private lnsalser As Double
    Public Property pnsalser() As Double
        Get
            pnsalser = lnsalser
        End Get
        Set(ByVal Value As Double)
            lnsalser = Value
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
    Private lndeucap2 As Double
    Public Property pndeucap2() As Double
        Get
            pndeucap2 = lndeucap2
        End Get
        Set(ByVal Value As Double)
            lndeucap2 = Value
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
    Private ldultpag2 As Date
    Public Property pdultpag2() As Date
        Get
            pdultpag2 = ldultpag2
        End Get
        Set(ByVal Value As Date)
            ldultpag2 = Value
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
    Private ldfecval2 As Date
    Public Property pdfecval2() As Date
        Get
            pdfecval2 = ldfecval2
        End Get
        Set(ByVal Value As Date)
            ldfecval2 = Value
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
    Private lncapcal As Double
    Public Property pncapcal() As Double
        Get
            pncapcal = lncapcal
        End Get
        Set(ByVal Value As Double)
            lncapcal = Value
        End Set
    End Property


    Private lnperbas As Double
    Public Property gnperbas() As Double
        Get
            gnperbas = lnperbas
        End Get
        Set(ByVal Value As Double)
            lnperbas = Value
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


    Private lddultpag As Date
    Public Property gdultpag() As Date
        Get
            gdultpag = lddultpag
        End Get
        Set(ByVal Value As Date)
            lddultpag = Value
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

    Private _manejo As Double
    Public Property manejo() As Double
        Get
            manejo = _manejo
        End Get
        Set(ByVal Value As Double)
            _manejo = Value
        End Set
    End Property

    Private _ahosim As Double
    Public Property ahosim() As Double
        Get
            ahosim = _ahosim
        End Get
        Set(ByVal Value As Double)
            _ahosim = Value
        End Set
    End Property

    Private _aporta As Double
    Public Property aporta() As Double
        Get
            aporta = _aporta
        End Get
        Set(ByVal Value As Double)
            _aporta = Value
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



    Private _pdfecvig As Date
    Public Property pdfecvig() As Date
        Get
            pdfecvig = _pdfecvig
        End Get
        Set(ByVal Value As Date)
            _pdfecvig = Value
        End Set
    End Property

    'cnrolin
    Private _cnrolin As String
    Public Property cnrolin() As String
        Get
            cnrolin = _cnrolin
        End Get
        Set(ByVal Value As String)
            _cnrolin = Value
        End Set
    End Property

    Private lnmonpag1 As Double
    Public Property pnmonpag1() As Double
        Get
            pnmonpag1 = lnmonpag1
        End Get
        Set(ByVal Value As Double)
            lnmonpag1 = Value
        End Set
    End Property
    'porsegdeu
    Private _porsegdeu As Double
    Public Property porsegdeu() As Double
        Get
            porsegdeu = _porsegdeu
        End Get
        Set(ByVal Value As Double)
            _porsegdeu = Value
        End Set
    End Property

    'porcentaje de comision
    Private _porcomision As Double
    Public Property porcomision() As Double
        Get
            porcomision = _porcomision
        End Get
        Set(ByVal Value As Double)
            _porcomision = Value
        End Set
    End Property
    'portalona
    Private _portalona As Double
    Public Property portalona() As Double
        Get
            portalona = _portalona
        End Get
        Set(ByVal Value As Double)
            _portalona = Value
        End Set
    End Property
    Private _pncosdir As Decimal
    Public Property pncosdir() As Decimal
        Get
            pncosdir = _pncosdir
        End Get
        Set(ByVal Value As Decimal)
            _pncosdir = Value
        End Set
    End Property

    Private _pncosind As Decimal
    Public Property pncosind() As Decimal
        Get
            pncosind = _pncosind
        End Get
        Set(ByVal Value As Decimal)
            _pncosind = Value
        End Set
    End Property

    Private _pnsubcidio As Decimal
    Public Property pnsubcidio() As Decimal
        Get
            pnsubcidio = _pnsubcidio
        End Get
        Set(ByVal Value As Decimal)
            _pnsubcidio = Value
        End Set
    End Property
    Private _pnprima As Decimal
    Public Property pnprima() As Decimal
        Get
            pnprima = _pnprima
        End Get
        Set(ByVal Value As Decimal)
            _pnprima = Value
        End Set
    End Property
    'constate cobrada de mora a partir de 01/julio/2004
    Private _gnmora As Double
    Public Property gnmora() As Double
        Get
            gnmora = _gnmora
        End Get
        Set(ByVal Value As Double)
            _gnmora = Value
        End Set
    End Property
    'fecha a partir de la cual se cobra nueva mora
    Private _gdfecmor As Date
    Public Property gdfecmor() As Date
        Get
            gdfecmor = _gdfecmor
        End Get
        Set(ByVal Value As Date)
            _gdfecmor = Value
        End Set
    End Property
    '    porres
    Private _porres As Double
    Public Property porres() As Double
        Get
            porres = _porres
        End Get
        Set(ByVal Value As Double)
            _porres = Value
        End Set
    End Property

    Private _cosind As Double
    Public Property cosind() As Double
        Get
            cosind = _cosind
        End Get
        Set(ByVal Value As Double)
            _cosind = Value
        End Set
    End Property
    Private _pcflat As String
    Public Property pcflat() As String
        Get
            pcflat = _pcflat
        End Get
        Set(ByVal Value As String)
            _pcflat = Value
        End Set
    End Property
    Private _pdfecoto As Date
    Public Property pdfecoto() As Date
        Get
            pdfecoto = _pdfecoto
        End Get
        Set(ByVal Value As Date)
            _pdfecoto = Value
        End Set
    End Property

    Private _pdfecven As Date
    Public Property pdfecven() As Date
        Get
            pdfecven = _pdfecven
        End Get
        Set(ByVal Value As Date)
            _pdfecven = Value
        End Set
    End Property
    Private _pccodana As String
    Public Property pccodana() As String
        Get
            pccodana = _pccodana
        End Get
        Set(ByVal Value As String)
            _pccodana = Value
        End Set
    End Property

    Private lcestado As String
    Public Property pcestado() As String
        Get
            pcestado = lcestado
        End Get
        Set(ByVal Value As String)
            lcestado = Value
        End Set
    End Property
    Private _porinteres As Double
    Public Property porinteres() As Double
        Get
            porinteres = _porinteres
        End Get
        Set(ByVal Value As Double)
            _porinteres = Value
        End Set
    End Property

    Private lnsalintAnt As Double
    Public Property pnsalintAnt() As Double
        Get
            pnsalintAnt = lnsalintAnt
        End Get
        Set(ByVal Value As Double)
            lnsalintAnt = Value
        End Set
    End Property
    Private lnsalmorAnt As Double
    Public Property pnsalmorAnt() As Double
        Get
            pnsalmorAnt = lnsalmorAnt
        End Get
        Set(ByVal Value As Double)
            lnsalmorAnt = Value
        End Set
    End Property

    Private lndiaatrAnt As Double
    Public Property pndiaatrAnt() As Integer
        Get
            pndiaatrAnt = lndiaatrAnt
        End Get
        Set(ByVal Value As Integer)
            lndiaatrAnt = Value
        End Set
    End Property

    Private lndeucapAnt As Double
    Public Property pndeucapAnt() As Double
        Get
            pndeucapAnt = lndeucapAnt
        End Get
        Set(ByVal Value As Double)
            lndeucapAnt = Value
        End Set
    End Property
    Private lnsalmorPen As Double
    Public Property pnsalmorPen() As Double
        Get
            pnsalmorPen = lnsalmorPen
        End Get
        Set(ByVal Value As Double)
            lnsalmorPen = Value
        End Set
    End Property

    Private lndiaatrint As Integer
    Public Property pndiaatrint() As Integer
        Get
            pndiaatrint = lndiaatrint
        End Get
        Set(ByVal Value As Integer)
            lndiaatrint = Value
        End Set
    End Property
#End Region


    Private cre As New DataSet
    Private myconnection As SqlConnection
    Private mycommand As SqlDataAdapter
    Private cmd As SqlCommand
    Private vCadena As String
    Private sql As String
    Private vCnn As String
    Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
    Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand

    ' temporalmente ****************
    Dim vpdfecval As Date

    Private _cnnStr As New String(AppSettings("cnnString"))
    Protected Overridable Property cnnStr() As String
        Get
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property



    Sub creditos1(ByVal pccodcta As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select cremcre.*,climide.ctipcli,climide.cclaper, climide.cnomcli, cretlin.ccodlin, cretlin.cdeslin, cretlin.lsegdeu, tabtusu.cnomusu from CREMCRE, CLIMIDE, CRETLIN,TABTUSU WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI AND CREMCRE.CNROLIN = CRETLIN.CNROLIN AND CREMCRE.CCODANA = TABTUSU.CCODUSU AND CREMCRE.CCODCTA = " & "'" & pccodcta & "'"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "creditos")
        Catch myexception As Exception
            '            Response.Write("Exception: " + myexception.ToString())
        End Try

    End Sub

    Sub planpago1(ByVal pccodcta As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            '            SqlConnection1.ConnectionString = "workstation id=MIRNA;packet size=4096;user id=sa;data source=MIRNA;persist security info=True;initial catalog=FUNDAMICRO;password=sa"
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select credppg.* from credppg where ccodcta =" & "'" & pccodcta & "'" & "order by dfecven"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "planpago")

        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub

    Sub kardexINFORED(ByVal pccodcta As String, ByVal pdfecha As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            SqlConnection1.ConnectionString = Me.cnnStr()

            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.dfecpro<=" & "'" & pdfecha & "'" & " and credkar.ccodcta = " & " '" & pccodcta & "'" & " and credkar.cestado =" & "'" & " " & "'" & " and credkar.lrecprov = " & "'" & "0" & "'" & " order by dfecpro"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "kardex")

        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub
    Sub kardex1(ByVal pccodcta As String, ByVal pdfecha As Date, ByVal tipo As String)
        Try

            Dim cadenaactual As String
            Dim cadena As String
            Dim ecreditos As New dbCreditos
            cadenaactual = Me.cnnStr
            cadena = ecreditos.CadenaDatos(pdfecha)

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()

            If tipo.Trim = "T" Then
                SqlConnection1.ConnectionString = Me.cnnStr()
                SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
                SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.dfecpro<='" & pdfecha & "' and credkar.ccodcta = " & " '" & pccodcta & "'" & " and credkar.cestado =" & "'" & " " & "'" & " order by dfecpro,cnrodoc"

            Else
                SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
                SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.dfecsis<='" & pdfecha & "' and credkar.ccodcta = " & " '" & pccodcta & "'" & " and credkar.cestado =" & "'" & " " & "'" & " order by dfecpro,cnrodoc"

                If cadena.Trim = cadenaactual.Trim Then
                    SqlConnection1.ConnectionString = Me.cnnStr()
                Else
                    SqlConnection1.ConnectionString = cadena
                End If
            End If
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "kardex")

        Catch SqlException As Exception

            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try
    End Sub


    Sub gastos1(ByVal pccodcta As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select credgas.* from credgas where credgas.ccodcta = " & "'" & pccodcta & "'"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "gastos")


        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub

    Sub linea1(ByVal pcnrolin As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,7) = " & "Left(" & "'" & pcnrolin & "'" & ",7)"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "lineacre")

        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub


    Function omcalcinterest(ByVal tipo As String, ByVal dfecant As String) As Integer
        'incorpora al dataset las tablas del kardex y plan de pagos
        Dim lcnrolin As String
        Dim filakar As DataRow
        Dim filagas As DataRow
        Dim lncapdes As Double
        Dim lncappag As Double
        Dim lnintpag As Double
        Dim lnmorpag As Double
        Dim lnmonto As Double
        Dim lcestado As String
        Dim lngaspag As Double
        Dim ldultven As Date
        Dim filaplan As DataRow
        Dim lnSalCap As Double
        Dim ncuenta As Integer
        Dim lnCapCal As Double
        Dim lnDiaAtr As Integer
        Dim interes As Double
        Dim mora As Double
        Dim ldultpag As Date
        Dim ldtulpag2 As Date
        Dim lnahosim As Double
        Dim lnaporta As Double
        Dim lnsegdeu As Double
        Dim lncomision As Double = 0
        Dim lniva As Double = 0

        Dim clsppal As New class1
        Dim ecredppg As New cCredppg
        Dim lncapint As Double
        Dim lctipper As String
        Dim lndiasug As Integer
        Dim lsegdeu1 As Boolean
        Dim lccodlin As String
        Dim pdfecha As Date
        Dim pdfechareal As Date
        pdfecha = Me.pdfecval
        Me.pdfecval2 = Me.pdfecval

        Dim lninteresesperado As Double 'interes esperado a la fecha en que paga
        lninteresesperado = 0
        Dim LDULTPAGINT As Date
        Dim lntotalinteres As Double  'interes total esperado en plan de pagos
        Dim lnintereind As Double  ' interes unitario flat a pagar en plan de pagos
        Dim lntasacre As Double = 0
        Me.pnsalser = 0

        Dim lctipcli As String = ""
        ldultpag = Me.gdultpag
        ldultpag2 = Me.gdultpag
        pdfechareal = Me.pdfecval
        cre.Tables.Clear()

        ldultpag = Me.gdultpag
        Dim okcre As Integer
        Dim lninteresflatpendiente As Double

        lninteresflatpendiente = 0

        pnsalint = 0
        pnsalmor = 0
        pnsalmorPen = 0
        pnsalintAnt = 0
        pnsalmorAnt = 0
        pndiaatrAnt = 0
        pndeucapAnt = 0
        pndiaatr = 0

        Try
            '****************** TEMPORALMENTE ******************

            Me.pdfecval = Me.pdfecval ' fecha valor
            interes = 0
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'If pccodcta = "022002011700164601" Then
            'lnSalCap = 0
            'End If
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            lnSalCap = 0
            lnCapCal = 0
            lnintcal = 0
            mora = 0
            creditos1(pccodcta)
            'Verificar estado del credito a la fecha de calculo

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If cre.Tables("creditos").Rows.Count > 0 Then
                If IsDBNull(Me.pcestado) Then

                Else
                    cre.Tables("creditos").Rows(0)("cestado") = Me.pcestado
                End If
                lcnrolin = cre.Tables("creditos").Rows(0)("cnrolin")
                lncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                lctipper = cre.Tables("creditos").Rows(0)("ctipper")
                lndiasug = cre.Tables("creditos").Rows(0)("ndiasug")
                lsegdeu1 = cre.Tables("creditos").Rows(0)("lsegdeu")
                lccodlin = cre.Tables("creditos").Rows(0)("cCodlin")
                lntasacre = cre.Tables("creditos").Rows(0)("ntasint")
                lctipcli = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("cclaper")), "1", cre.Tables("creditos").Rows(0)("cclaper"))

                Me.pcflat = cre.Tables("creditos").Rows(0)("cFlat")
                'Calcula Cuota>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                lncapint = ecredppg.CapitalInteres(pccodcta)
                Dim pcaplcom As String
                If lccodlin.Substring(8, 2) = "06" Then
                    pcaplcom = "0"
                Else
                    pcaplcom = "1"
                End If
                If lsegdeu1 = True Then
                    pcaplcom = pcaplcom & "1"
                Else
                    pcaplcom = pcaplcom & "0"
                End If
                'Verificamos si aplica comision a pretamos personales
                If pcaplcom.Substring(0, 1) = "1" Then
                    lncomision = (lncapdes * (Me.porcomision / 100) * IIf(lctipper = "1", lndiasug, 31)) / Me.gnperbas
                Else
                    lncomision = 0
                End If
                'Verificamos si aplica comision a Seguro de Deuda
                ' If pcaplcom.Substring(1, 1) = "1" Then
                If lsegdeu1 = True Then
                    lnsegdeu = IIf(lctipper = "1", (lncapdes * Me.porsegdeu * (lndiasug / 30)), (lncapdes * Me.porsegdeu))
                Else
                    lnsegdeu = 0
                End If
                Me.pnmoncuo = utilNumeros.Redondear(lncapint + lncomision + lnsegdeu, 2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If cre.Tables("creditos").Rows(0)("cestado") = "G" Then
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                    Me.pdultpag2 = cre.Tables("creditos").Rows(0)("dultpag")
                    'Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                    Return 9
                    Exit Function
                End If

                'Me.pnmoncuo = cre.Tables("creditos").Rows(0)("nmoncuo")
                Me.pccodana = cre.Tables("creditos").Rows(0)("ccodana")
                If IsDBNull(cre.Tables("creditos").Rows(0)("nintadm")) Then
                    pnsalmorPen = 0
                Else
                    pnsalmorPen = cre.Tables("creditos").Rows(0)("nintadm")
                End If
                'Para Creditos Saneados >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                Dim lccondic As String
                Dim ldfectra As Date
                Dim lccontra As String
                Dim lnperiodo As Integer = 0



                lccondic = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccondic")), "N", cre.Tables("creditos").Rows(0)("ccondic"))
                ldfectra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("dfectra")), Me.gdfecsis, cre.Tables("creditos").Rows(0)("dfectra"))
                lccontra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccontra")), "N", cre.Tables("creditos").Rows(0)("ccontra"))

                lnperiodo = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("nperiodo")), 0, cre.Tables("creditos").Rows(0)("nperiodo"))

                Dim ldfeclim As Date
                ldfeclim = DateAdd(DateInterval.Day, lnperiodo, ldfectra)

                If lccondic = "S" Then ' Or (lccontra = "G" And ldfeclim >= Me.pdfecval)
                    Me.pdfecval = ldfectra

                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If IsDBNull(cre.Tables("creditos").Rows(0)("dfecvig")) Then
                    Me.pdfecoto = #7/1/2000#
                Else
                    Me.pdfecoto = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag2 = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                End If
                Me.pdfecven = cre.Tables("creditos").Rows(0)("dfecven")

                Me.cnrolin = lcnrolin
                planpago1(pccodcta)
                If lccondic = "S" Then
                    kardex1(pccodcta, pdfechareal, tipo)
                Else
                    kardex1(pccodcta, pdfecha, tipo)
                End If
                gastos1(pccodcta)
                linea1(lcnrolin)
                For Each filalineacre As DataRow In cre.Tables("LINEACRE").Rows 'esta cambio se debe a que tomara de la cremcre la tasa de interes
                    filalineacre("ntasint") = lntasacre
                Next
                'calcula el interes a partir de las tablas anteriores ya llenas
                lncapdes = 0
                lncappag = 0
                lnintpag = 0
                lnmorpag = 0
                lnmonto = 0
                lngaspag = 0
                lnahosim = 0
                lnaporta = 0
                lnsegdeu = 0
                lncomision = 0
                lniva = 0

                Dim lcdockp As String = ""
                Dim lcdocaj As String = ""
                'colocara una fecha mucho anterior
                'ya que los registros no vienen en orden y evaluara la fecha mayor
                Dim lnintpagado As Double = 0

                If cre.Tables("kardex").Rows.Count <= 0 Then
                Else
                    For Each filakar In cre.Tables("kardex").Rows
                        ldultpag2 = Date.Parse(filakar("dfecpro"))
                        If filakar("cestado") = " " Then
                            If filakar("cconcep") <> "CJ" Then
                                If filakar("cdescob") = "D" Then
                                    Me.pdfecvig = filakar("dfecpro")
                                    LDULTPAGINT = filakar("dfecpro")
                                End If
                                If filakar("cconcep") = "KP" And filakar("cdescob") = "D" Then
                                    lncapdes = lncapdes + filakar("nmonto")
                                    If filakar("dfecpro") > ldultpag Then
                                        ldultpag = Date.Parse(filakar("dfecpro"))
                                    End If
                                ElseIf filakar("cconcep") = "KP" And filakar("cdescob") = "C" Then
                                    lncappag = lncappag + filakar("nmonto")
                                    If filakar("ctippag") <> "P" Then 'ultimo cambio
                                        lcdockp = filakar("cnrodoc")
                                    End If

                                    If filakar("dfecpro") > ldultpag Then 'cambio harikiry 'Or (filakar("ctippag") <> "P" )
                                        ldultpag = filakar("dfecpro")
                                    End If
                                ElseIf filakar("cconcep") = "IN" Then
                                    lnintpag = lnintpag + filakar("nmonto")
                                    lnintpagado = lnintpagado + filakar("nmonto")
                                    interes = interes + filakar("nmonto")
                                    LDULTPAGINT = filakar("dfecpro")
                                    If filakar("ctippag") = "P" Then 'ultimo cambio
                                        lcdocaj = filakar("cnrodoc")
                                    End If
                                ElseIf filakar("cconcep") = "08" And filakar("cdescob") = "C" Then
                                    lnintpag = lnintpag + filakar("nmonto")
                                    lnintpagado = lnintpagado + filakar("nmonto")
                                    interes = interes + filakar("nmonto")

                                ElseIf filakar("cconcep") = "MO" Or filakar("cconcep") = "IM" Then
                                    lnmorpag = lnmorpag + filakar("nmonto")
                                    mora = mora + filakar("nmonto")
                                    If filakar("ctippag") = "P" Then 'ultimo cambio
                                        lcdocaj = filakar("cnrodoc")
                                    End If

                                ElseIf filakar("cconcep") = "SD" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' Seguro de Deuda
                                    lnsegdeu = lnsegdeu + filakar("nmonto")
                                ElseIf (filakar("cconcep") = "CO" Or filakar("cconcep") = "OP") And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' manejo
                                    lncomision = lncomision + filakar("nmonto")
                                ElseIf filakar("cconcep") = "IV" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' iva
                                    lniva = lniva + filakar("nmonto")

                                    'verifica si pago algo de ahorros en la ultima fecha de pago
                                ElseIf filakar("cconcep") = "01" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' ahorro simultaneo
                                    lnahosim = lnahosim + filakar("nmonto")

                                ElseIf filakar("cconcep") = "06" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' aportaciones
                                    lnaporta = lnaporta + filakar("nmonto")

                                ElseIf filakar("cconcep") = "CJ" Then

                                Else
                                    'gastos
                                    ncuenta = 0
                                    For Each filagas In cre.Tables("gastos").Rows
                                        If IsDBNull(filagas("cnrocuo")) Then
                                            filagas("cnrocuo") = "000"
                                        End If
                                        If IsDBNull(filakar("cnrocuo")) Then
                                            filakar("cnrocuo") = "000"
                                        End If
                                        If filagas("cnrocuo") = filakar("cnrocuo") And filagas("cdescob") = filakar("cdescob") And filagas("ctipgas") = filakar("cconcep") Then
                                            If filagas("nmongas") - filagas("nmonpag") < filakar("nmonto") Then
                                                lnmonto = filagas("nmongas") - filagas("nmonpag")
                                                lcestado = "P"
                                            Else
                                                lnmonto = filagas("nmongas")
                                                lcestado = "E"
                                            End If
                                            cre.Tables("gastos").Rows(ncuenta)("nmonpag") = lnmonto
                                            cre.Tables("gastos").Rows(ncuenta)("dfecpag") = filakar("dfecpro")
                                        End If
                                        ncuenta = ncuenta + 1
                                    Next
                                    lngaspag = lngaspag + filakar("nmonto")
                                End If
                            End If
                        End If
                    Next

                End If
                Me.pdultpag = ldultpag
                Me.pdultpag2 = ldultpag2
                Me.ahosim = lnahosim
                Me.aporta = lnaporta

                'calcula fecha de ultimo pago cuando no abona intereses
                Dim lsi As Boolean
                Dim cuentafilas As Integer
                cuentafilas = cre.Tables("kardex").Rows.Count
                'esta sentencia da error porque no hay lineas
                '   If cuentafilas > 0 Then
                '  filakar.Delete()
                ' End If
                'evalua todo en busca de interes y si no haya evalua abajo
                For Each filakar In cre.Tables("kardex").Rows
                    If filakar("dfecpro") = ldultpag And filakar("cconcep") = "IN" Then
                        'llega hasta el final
                        lsi = True
                        Exit For
                    Else
                        lsi = False
                        Exit For
                    End If
                Next

                '*********** busca interes pendiente que se guardo en cclip **********
                lninteresflatpendiente = 0
                Dim lnflayfloy As Double = 0
                Dim lcclipag As String

                For Each filakar In cre.Tables("kardex").Rows
                    If IsDBNull(filakar("cclipag")) Then
                        filakar("cclipag") = 0
                    End If
                    lcclipag = filakar("cclipag")

                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " Then
                            lninteresflatpendiente = Double.Parse(filakar("cclipag"))
                        End If
                        ' Exit For
                    End If
                Next

                'Verifica pagos despues de interes pendiente
                For Each filakar In cre.Tables("kardex").Rows
                    lcclipag = filakar("cclipag")
                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " And lcclipag <> "0" Then
                        Else
                            lnflayfloy = Double.Parse(filakar("nmonto"))
                            Exit For
                        End If
                    End If
                Next
                If lninteresflatpendiente <= 0 Then
                    lnflayfloy = 0
                End If

                'false significa no abono intereses

                'revisar esta parte ***** no completa ***********
                If lsi = False Then
                    'verifica si abono a capital en el ultimo pago
                    'y se va para atras de uno en uno
                    For Each filakar In cre.Tables("kardex").Rows
                        If filakar("dfecpro") = ldultpag And filakar("cconcep") = "KP" Then
                            If filakar("cconcep") = "KP" And filakar("cestado") = " " Then
                                ldultpag = filakar("dfecpro")
                            End If
                        End If
                    Next
                End If 'lsi ultimo pago no abona interese

                '***********
                'halla pagos a cuenta
                Dim lnintpen As Double
                Dim lnpagcta As Double
                Dim lncuentafilas As Integer
                Dim llfin As Boolean
                Dim i As Integer
                Dim lcnrodoc As String
                Dim iguardado As Integer

                lnintpen = 0
                lnpagcta = 0
                llfin = False

                lncuentafilas = cre.Tables("kardex").Rows.Count
                lncuentafilas = lncuentafilas - 1
                'For i = 0 To lncuentafilas Step -1
                For i = lncuentafilas To 0 Step -1

                    If cre.Tables("kardex").Rows(i)("cdescob") = "D" Then

                    Else
                        lcnrodoc = cre.Tables("kardex").Rows(i)("cnrodoc")
                        iguardado = i
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc

                            If cre.Tables("kardex").Rows(i)("cconcep") = "KP" Then
                                llfin = True
                                Exit For
                            End If
                            If i > 0 Then

                                i = i - 1
                            End If
                        Loop
                        If llfin Then
                            Exit For
                        End If
                        i = iguardado
                        Dim flagi As Integer
                        flagi = iguardado
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc
                            'If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Then
                            If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Or cre.Tables("kardex").Rows(i)("cconcep") = "08" Then
                                lnintpen = lnintpen + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                                'ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Then
                            ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Or cre.Tables("kardex").Rows(i)("cconcep") = "IM" Then
                                lnpagcta = lnpagcta + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                            End If
                            If i > 0 Then
                                i = i - 1
                            End If
                        Loop
                        'i = flagi 
                        i = i + 1
                    End If
                Next
                If pcflat.Trim = "F" Then
                    lnintpag = lnintpag '- lnintpen
                Else
                    lnintpag = lnintpag - lnintpen
                End If

                lnmorpag = lnmorpag - lnpagcta

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapdes") = lncapdes
                cre.Tables("creditos").Rows(0)("ncappag") = lncappag
                cre.Tables("creditos").Rows(0)("nintpag") = lnintpag
                cre.Tables("creditos").Rows(0)("nmorpag") = lnmorpag
                'cre.Tables("kardex").Rows(0)("ngaspag") = lngaspag
                cre.Tables("creditos").Rows(0)("dultpag") = ldultpag
                cre.Tables("creditos").Rows(0)("nintpen") = lnintpen
                cre.Tables("creditos").Rows(0)("npagcta") = lnpagcta
                Dim lncuentaplan As Integer
                'halla teorico y cancela cuotas y fecha de vencimiento
                lncuentaplan = cre.Tables("planpago").Rows.Count
                lncuentaplan = lncuentaplan - 1
                ldultven = cre.Tables("planpago").Rows(lncuentaplan)("dfecven")
                ncuenta = 0

                Dim lnllave As Integer = 0
                Dim lnllave1 As Integer = 0

                If Me.pcflat.Trim = "F" Then
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "D" Then
                            lnSalCap = lnSalCap + filaplan("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                        Else
                            lnCapCal = lnCapCal + filaplan("ncapita")
                            lnintcal = lnintcal + filaplan("nintere")

                            'If Math.Round(lnintcal, 2) > Math.Round(lnintpagado, 2) And lnllave = 0 Then
                            If Math.Round(lnintcal, 2) >= Math.Round(lnintpagado, 2) And lnllave = 0 Then
                                ldultven = filaplan("dfecven")
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                lnllave = 1
                                'Exit For
                            End If
                            If Math.Round(lnCapCal, 2) > Math.Round(lncappag, 2) And lnllave1 = 0 Then
                                ldultven = filaplan("dfecven")
                                lncappag = filaplan("ncapita") - (lnCapCal - lncappag)
                                cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                lnllave1 = 1
                                'Exit For
                            End If

                            If lnllave = 0 Then
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                            End If
                            If lnllave1 = 0 Then
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                                cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                            End If

                            If lnllave = 1 And lnllave1 = 1 Then
                                Exit For
                            End If
                        End If
                        ncuenta = ncuenta + 1
                    Next

                Else 'Sobresaldo
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "D" Then
                            lnSalCap = lnSalCap + filaplan("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                        Else
                            lnCapCal = lnCapCal + filaplan("ncapita")
                            lnintcal = lnintcal + filaplan("nintere")

                            If Math.Round(lnCapCal, 2) > Math.Round(lncappag, 2) Then
                                ldultven = filaplan("dfecven")
                                lncappag = Math.Round(filaplan("ncapita") - (lnCapCal - lncappag), 2)
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)

                                If cre.Tables("planpago").Rows(ncuenta)("ncapita") = 0 Then
                                Else
                                    cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                                End If

                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado

                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                Exit For
                            End If


                            cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                            cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                        End If
                        ncuenta = ncuenta + 1
                    Next

                End If


                'Debido a Error reportado version Mexico 2015, hara un nuevo barrido para el Interes pagado, por problemas en la proyección 
                'del interes FLAT

                If Me.pcflat.Trim = "F" Then
                    lnintcal = 0
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "N" Then
                            lnintcal = lnintcal + filaplan("nintere")
                            If Math.Round(lnintcal, 2) > Math.Round(lnintpagado, 2) And lnllave = 0 Then
                                ldultven = filaplan("dfecven")
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado
                                lnllave = 1
                                Exit For
                            End If

                            If lnllave = 0 Then
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                            End If

                        End If
                    Next
                End If



                Dim lnintpagk1 As Double
                Dim lnintpagk As Double
                Dim ldfecven As Date
                Dim lnintmor As Double

                lnintpagk1 = cre.Tables("creditos").Rows(0)("nintpag")
                lnintpagk = cre.Tables("creditos").Rows(0)("nintpag")


                'encuentra capital teorico
                Dim ncuentatot As Integer
                Dim lnintere As Double
                lnCapCal = 0
                ncuenta = 0
                ncuentatot = cre.Tables("planpago").Rows.Count
                If ncuentatot > 0 Then
                    ncuentatot = ncuentatot - 1
                End If

                Do While cre.Tables("planpago").Rows(ncuenta)("dfecven") < gdfecsis And ncuenta <= ncuentatot
                    If cre.Tables("planpago").Rows(ncuenta)("ctipope") <> "D" And ncuenta <= ncuentatot Then
                        lnCapCal = lnCapCal + cre.Tables("planpago").Rows(ncuenta)("ncapita")
                    End If
                    ncuenta = ncuenta + 1
                    If ncuenta > ncuentatot Then
                        Exit Do
                    End If
                Loop
                ldfecven = cre.Tables("planpago").Rows(ncuentatot)("dfecven")

                '** calcula el interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<
                Dim lnintproximo As Decimal = 0
                Dim lnnext As Integer = 0
                'determina interes esperado
                lninteresesperado = 0
                lntotalinteres = 0
                lnintereind = 0
                Dim ldfecant As Date
                Dim fila As DataRow
                For Each fila In cre.Tables("planpago").Rows
                    If fila("dfecven") <= Me.pdfecval And fila("ctipope") <> "D" Then
                        lninteresesperado = lninteresesperado + fila("nintere")
                        If fila("dfecven") = Me.pdfecval Then
                            lnnext = 1
                        End If
                    Else
                        If fila("ctipope") <> "D" And lnnext = 0 Then
                            If Me.pdfecval > ldfecant Then 'la activa o abierta es un dia despues de vencida la anterior
                                lnnext = 1
                                lnintproximo = lnintproximo + fila("nintere")
                                lnintereind = fila("nintere")
                            End If
                        Else
                        End If
                    End If
                    If fila("ctipope") <> "D" Then
                        lntotalinteres = lntotalinteres + fila("nintere")
                        If lnnext = 0 Then
                            lnintereind = fila("nintere")
                        End If
                    End If
                    ldfecant = fila("dfecven")
                Next


                '*********************   Nueva forma de cobrar interes flat ******************************
                Dim n As Double
                Dim lnfecnum2 As Double

                If Me.pdfecval.Year <> LDULTPAGINT.Year Then     ' pdultpag.Year 
                    n = Me.pdfecval.Year - Me.pdultpag.Year
                    lnfecnum2 = (Me.pdfecval.Month + n * 12) - LDULTPAGINT.Month 'pdultpag
                Else
                    lnfecnum2 = Me.pdfecval.Month - LDULTPAGINT.Month 'pdultpag
                End If
                '*************** Finaliza nueva forma de cobrar interes flat *****************************

                '** calcula el interes flat o sobre saldos
                If Me.pcflat = "F" Then
                    'lnintere = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                    'Modificado a petición Mexico solo mostrara como saldo lo vencido   29/10/2014
                    lnintere = Math.Round((lninteresesperado - lnintpag), 2)
                    If lnintere < 0 Then
                        lnintere = 0
                    End If
                    If lnintere <= 0 And Math.Round(lntotalinteres - lnintpag, 2) > 0 Then

                        'Modificado a petición Mexico solo mostrara como saldo lo vencido   29/10/2014
                        'Calcular el interes de la proxima cuota
                        If Math.Round((lninteresesperado - lnintpag), 2) > 0 Then
                            lnintere = Math.Round((lninteresesperado - lnintpag), 2)
                        Else
                            lnintere = 0 'mxCalcInterestFLAT(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes")) ' Math.Round(lnintproximo, 2) 
                        End If
                        'If Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2) > 0 Then
                        '    lnintere = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                        'Else
                        '    lnintere = 0 'mxCalcInterestFLAT(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes")) ' Math.Round(lnintproximo, 2) 
                        'End If
                        'If Math.Round(lnintere, 2) > Math.Round(lnintereind, 2) Then
                        '    lnintere = lnintereind
                        'Else
                        'End If
                    Else 'Aqui tendria q ir el calculo de intereses si el credito esta vencido y ya pago todo el interes teorico
                        'lnintere = lnintereind

                        'Prueba Rafa 09/09/2014
                        'For Each filaplan In cre.Tables("planpago").Rows
                        '    If filaplan("nintere") - filaplan("nintpag") > 0 And filaplan("ctipope") = "N" _
                        '       And filaplan("dfecven") <= Me.pdfecval Then
                        '        lnintere = filaplan("nintere") - filaplan("nintpag")
                        '        Exit For
                        '    End If
                        'Next
                        'Modificado por Erro detectado, En prueba 09/05/2014 Rafa
                        lnintere = 0
                        For Each filaplan In cre.Tables("planpago").Rows
                            If filaplan("nintere") - filaplan("nintpag") > 0 And filaplan("ctipope") = "N" _
                               And filaplan("dfecven") <= Me.pdfecval Then
                                lnintere = lnintere + filaplan("nintere") - filaplan("nintpag")
                                'Exit For
                            End If

                        Next

                        '  Do While .NOT.EOF()
                        '      If CUOTAS.nintere - CUOTAS.nintPag > 0 Then
                        '          lnintere = CUOTAS.nintere - CUOTAS.nintPag
                        'EXIT
                        '      End If
                        '      SKIP()
                        '      ENDDO()
                    End If

                    lnintere = IIf(Math.Round(lnintere, 2) < 0, 0, Math.Round(lnintere, 2))
                Else
                    lnintere = mxCalcInterest(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                End If

                '>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<Calculo para utilizar en partida regularizadora

                Dim lnintereant As Decimal = 0
                If tipo = "R" Then 'para partida regularizadora
                    If Me.pcflat = "F" Then
                        lnintereant = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                        If lnintereant < 0 Then
                            lnintereant = 0
                        End If
                        If lnintereant <= 0 And Math.Round(lntotalinteres - lnintpag, 2) > 0 Then
                            'Calcular el interes de la proxima cuota
                            If Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2) > 0 Then
                                lnintereant = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                            Else
                                If lccondic = "S" Then
                                    lnintereant = mxCalcInterestFLATAnt(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes"), pdfecval) ' Math.Round(lnintproximo, 2) 
                                Else
                                    lnintereant = mxCalcInterestFLATAnt(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes"), dfecant) ' Math.Round(lnintproximo, 2) 
                                End If

                            End If
                            'If Math.Round(lnintereant, 2) > Math.Round(lnintereind, 2) Then
                            '    lnintereant = lnintereind
                            'Else
                            'End If
                        Else 'Aqui tendria q ir el calculo de intereses si el credito esta vencido y ya pago todo el interes teorico, Pendiente de resolver
                            lnintereant = lnintereind
                        End If

                        lnintereant = IIf(Math.Round(lnintereant, 2) < 0, 0, Math.Round(lnintereant, 2))
                    Else
                        If lccondic = "S" Then
                            lnintereant = mxCalcInterestAnt(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"), pdfecval)
                        Else
                            lnintereant = mxCalcInterestAnt(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"), dfecant)
                        End If

                    End If
                End If


                '<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


                Dim ecredkar As New cCredkar
                Dim lnintaju As Double = 0
                Dim lnmoraju As Double = 0



                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                If lcdockp >= lcdocaj Then 'ultimo cambio estilo Harikiry

                Else
                    lnintaju = ecredkar.ObtenerInteresAjustado(pccodcta)
                    lnmoraju = ecredkar.ObtenerMoraAjustado(pccodcta)

                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                'lnintere = lnintere - lnintaju

                

                If Me.pcflat.Trim = "F" Then
                    lnDiaAtr = mxCalcDiaAtr()
                Else
                    lnDiaAtr = mxCalcDiaAtr2()
                End If


                lnintmor = mxCalcMoratory()
                If lnDiaAtr <= 0 Then
                    lnintmor = 0
                End If

                Dim lnintmorant As Decimal = 0
                If tipo = "R" Then 'para partida regularizadora
                    If Me.pcflat.Trim = "F" Then
                        pndiaatrAnt = mxCalcDiaAtrAnt(dfecant)
                    Else
                        pndiaatrAnt = mxCalcDiaAtrAnt2(dfecant)
                    End If
                    If pndiaatrAnt <= 0 Then
                        lnintmorant = 0
                    Else
                        If lccondic = "S" Then
                            lnintmorant = mxCalcMoratoryAnt(pdfecval)
                        Else
                            lnintmorant = mxCalcMoratoryAnt(dfecant)
                        End If

                    End If
                End If

                '                lnintmor = lnintmor - lnmoraju

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapcal") = lnCapCal
                cre.Tables("creditos").Rows(0)("nintcal") = lnintere + cre.Tables("creditos").Rows(0)("nintpag") '+ cre.Tables("creditos").Rows(0)("nintpen") 'ultimo cambio
                cre.Tables("creditos").Rows(0)("nIntMor") = lnintmor + cre.Tables("creditos").Rows(0)("nmorpag")  '+ cre.Tables("creditos").Rows(0)("npagcta") 'ultimo cambio
                cre.Tables("creditos").Rows(0)("ndiaatr") = lnDiaAtr


                '**************actualiza las propiedades********************
                Me.pcnomcli = cre.Tables("creditos").Rows(0)("cnomcli")
                Me.pccodcli = cre.Tables("creditos").Rows(0)("ccodcli")
                Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")


                If (Me.pncapdes - Me.pncappag) <= 0 Then
                    Return 9
                End If
                ' DIRECTO DEL CALCULO
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If pcflat.Trim = "F" Then
                    pnsalint = lnintere - lnintaju
                Else
                    Me.pnsalint = cre.Tables("creditos").Rows(0)("nintcal") - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) '- lnintaju
                End If


                Me.pnsalmor = (cre.Tables("creditos").Rows(0)("nintmor") + pnsalmorPen) - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) '- lnmoraju

                If Me.pnsalint < 0 Then
                    Me.pnsalint = 0
                End If
                If Me.pnsalmor < 0 Then
                    Me.pnsalmor = 0
                End If


                If tipo = "R" Then 'para partida regularizadora
                    If pcflat.Trim = "F" Then
                        pnsalintAnt = lnintereant - lnintaju
                    Else
                        Me.pnsalintAnt = (lnintereant + cre.Tables("creditos").Rows(0)("nintpag")) - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) '- lnintaju
                    End If
                    Me.pnsalmorAnt = (lnintmorant + cre.Tables("creditos").Rows(0)("nmorpag")) - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) '- lnmoraju
                    If Me.pnsalintAnt < 0 Then
                        Me.pnsalintAnt = 0
                    End If
                    If Me.pnsalmorAnt < 0 Then
                        Me.pnsalmorAnt = 0
                    End If
                End If

               
                '
                Me.pndiaatr = cre.Tables("creditos").Rows(0)("ndiaatr")
                If Me.pndiaatr < 0 Then
                    Me.pndiaatr = 0
                End If
                Me.pnintpag = cre.Tables("creditos").Rows(0)("nintpag")
                Me.pnintpen = cre.Tables("creditos").Rows(0)("nintpen")
                Me.pnintcal = cre.Tables("creditos").Rows(0)("nintcal")
                Me.pnmorpag = cre.Tables("creditos").Rows(0)("nmorpag")
                Me.pnpagcta = cre.Tables("creditos").Rows(0)("npagcta")
                Me.pnintmor = cre.Tables("creditos").Rows(0)("nintmor")
                Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")
                Me.pncapcal = cre.Tables("creditos").Rows(0)("ncapcal")



                Dim lndeucap1 As Double
                'Dim fila As DataRow
                'evalue el pncapita, capital minimo necesario para pagar
                lndeucap1 = 0
                For Each fila In cre.Tables("planpago").Rows
                    'pdfechareal por Me.pdfecval
                    If fila("dfecven") < pdfechareal And fila("ctipope") <> "D" Then
                        lndeucap1 = lndeucap1 + (fila("ncapita") - fila("ncappag"))
                    End If
                    If Math.Round(lndeucap1, 2) < 0 Then
                        lndeucap1 = 0
                    End If
                Next
                Me.pndeucap = Math.Round(lndeucap1, 2)

                'If pndeucap > Math.Round((pncapdes - pncappag), 2) Then
                '    pndeucap = Math.Round((pncapdes - pncappag), 2)
                'End If

                '-------Deuda capital incluyendo capital del dia de pago
                Dim lndeucap2 As Double = 0
                'Dim fila As DataRow
                'evalue el pncapita, capital minimo necesario para pagar
                lndeucap2 = 0
                For Each fila In cre.Tables("planpago").Rows
                    'pdfechareal por Me.pdfecval
                    If fila("dfecven") <= pdfechareal And fila("ctipope") <> "D" Then
                        lndeucap2 = lndeucap2 + (fila("ncapita") - fila("ncappag"))
                    End If
                    If Math.Round(lndeucap2, 2) < 0 Then
                        lndeucap2 = 0
                    End If
                Next
                Me.pndeucap2 = Math.Round(lndeucap2, 2)
              

                If tipo = "R" Then 'para partida regularizadora
                    Dim lndeucapant As Double
                    'Dim fila As DataRow
                    'evalue el pncapita, capital minimo necesario para pagar
                    lndeucapant = 0
                    For Each fila In cre.Tables("planpago").Rows
                        'pdfechareal por Me.pdfecval
                        If fila("dfecven") < dfecant And fila("ctipope") <> "D" Then
                            lndeucapant = lndeucapant + (fila("ncapita") - fila("ncappag"))
                        End If
                        If Math.Round(lndeucapant, 2) < 0 Then
                            lndeucapant = 0
                        End If
                    Next
                    Me.pndeucapAnt = Math.Round(lndeucapant, 2)

                End If

                Return 1
            End If 'si existen creditos

            Return 0
        Catch ex As Exception
            Return 0
        End Try


    End Function


    Function omcalcinterestPruebax_Flat(ByVal tipo As String, ByVal dfecant As String, _
                                        ByVal dtx As DataTable) As Integer
        'incorpora al dataset las tablas del kardex y plan de pagos
        Dim lcnrolin As String
        Dim filakar As DataRow
        Dim filagas As DataRow
        Dim lncapdes As Double
        Dim lncappag As Double
        Dim lnintpag As Double
        Dim lnmorpag As Double
        Dim lnmonto As Double
        Dim lcestado As String
        Dim lngaspag As Double
        Dim ldultven As Date
        Dim filaplan As DataRow
        Dim lnSalCap As Double
        Dim ncuenta As Integer
        Dim lnCapCal As Double
        Dim lnDiaAtr As Integer
        Dim interes As Double
        Dim mora As Double
        Dim ldultpag As Date
        Dim ldtulpag2 As Date
        Dim lnahosim As Double
        Dim lnaporta As Double
        Dim lnsegdeu As Double
        Dim lncomision As Double = 0
        Dim lniva As Double = 0

        Dim clsppal As New class1
        Dim ecredppg As New cCredppg
        Dim lncapint As Double
        Dim lctipper As String
        Dim lndiasug As Integer
        Dim lsegdeu1 As Boolean
        Dim lccodlin As String
        Dim pdfecha As Date
        Dim pdfechareal As Date
        pdfecha = Me.pdfecval
        Me.pdfecval2 = Me.pdfecval

        Dim lninteresesperado As Double 'interes esperado a la fecha en que paga
        lninteresesperado = 0
        Dim LDULTPAGINT As Date
        Dim lntotalinteres As Double  'interes total esperado en plan de pagos
        Dim lnintereind As Double  ' interes unitario flat a pagar en plan de pagos
        Dim lntasacre As Double = 0
        Me.pnsalser = 0

        Dim lctipcli As String = ""
        ldultpag = Me.gdultpag
        ldultpag2 = Me.gdultpag
        pdfechareal = Me.pdfecval
        cre.Tables.Clear()

        ldultpag = Me.gdultpag
        Dim okcre As Integer
        Dim lninteresflatpendiente As Double

        lninteresflatpendiente = 0

        pnsalint = 0
        pnsalmor = 0
        pnsalmorPen = 0
        pnsalintAnt = 0
        pnsalmorAnt = 0
        pndiaatrAnt = 0
        pndeucapAnt = 0
        pndiaatr = 0

        Try
            '****************** TEMPORALMENTE ******************

            Me.pdfecval = Me.pdfecval ' fecha valor
            interes = 0
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'If pccodcta = "022002011700164601" Then
            'lnSalCap = 0
            'End If
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            lnSalCap = 0
            lnCapCal = 0
            lnintcal = 0
            mora = 0
            creditos1(pccodcta)
            'Verificar estado del credito a la fecha de calculo

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If cre.Tables("creditos").Rows.Count > 0 Then
                If IsDBNull(Me.pcestado) Then

                Else
                    cre.Tables("creditos").Rows(0)("cestado") = Me.pcestado
                End If
                lcnrolin = cre.Tables("creditos").Rows(0)("cnrolin")
                lncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                lctipper = cre.Tables("creditos").Rows(0)("ctipper")
                lndiasug = cre.Tables("creditos").Rows(0)("ndiasug")
                lsegdeu1 = cre.Tables("creditos").Rows(0)("lsegdeu")
                lccodlin = cre.Tables("creditos").Rows(0)("cCodlin")
                lntasacre = cre.Tables("creditos").Rows(0)("ntasint")
                lctipcli = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("cclaper")), "1", cre.Tables("creditos").Rows(0)("cclaper"))

                Me.pcflat = cre.Tables("creditos").Rows(0)("cFlat")
                'Calcula Cuota>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                lncapint = ecredppg.CapitalInteres(pccodcta)
                Dim pcaplcom As String
                If lccodlin.Substring(8, 2) = "06" Then
                    pcaplcom = "0"
                Else
                    pcaplcom = "1"
                End If
                If lsegdeu1 = True Then
                    pcaplcom = pcaplcom & "1"
                Else
                    pcaplcom = pcaplcom & "0"
                End If
                'Verificamos si aplica comision a pretamos personales
                If pcaplcom.Substring(0, 1) = "1" Then
                    lncomision = (lncapdes * (Me.porcomision / 100) * IIf(lctipper = "1", lndiasug, 31)) / Me.gnperbas
                Else
                    lncomision = 0
                End If
                'Verificamos si aplica comision a Seguro de Deuda
                ' If pcaplcom.Substring(1, 1) = "1" Then
                If lsegdeu1 = True Then
                    lnsegdeu = IIf(lctipper = "1", (lncapdes * Me.porsegdeu * (lndiasug / 30)), (lncapdes * Me.porsegdeu))
                Else
                    lnsegdeu = 0
                End If
                Me.pnmoncuo = utilNumeros.Redondear(lncapint + lncomision + lnsegdeu, 2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If cre.Tables("creditos").Rows(0)("cestado") = "G" Then
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                    Me.pdultpag2 = cre.Tables("creditos").Rows(0)("dultpag")
                    Return 9
                    Exit Function
                End If

                'Me.pnmoncuo = cre.Tables("creditos").Rows(0)("nmoncuo")
                Me.pccodana = cre.Tables("creditos").Rows(0)("ccodana")
                If IsDBNull(cre.Tables("creditos").Rows(0)("nintadm")) Then
                    pnsalmorPen = 0
                Else
                    pnsalmorPen = cre.Tables("creditos").Rows(0)("nintadm")
                End If
                'Para Creditos Saneados >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                Dim lccondic As String
                Dim ldfectra As Date
                Dim lccontra As String
                Dim lnperiodo As Integer = 0



                lccondic = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccondic")), "N", cre.Tables("creditos").Rows(0)("ccondic"))
                ldfectra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("dfectra")), Me.gdfecsis, cre.Tables("creditos").Rows(0)("dfectra"))
                lccontra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccontra")), "N", cre.Tables("creditos").Rows(0)("ccontra"))

                lnperiodo = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("nperiodo")), 0, cre.Tables("creditos").Rows(0)("nperiodo"))

                Dim ldfeclim As Date
                ldfeclim = DateAdd(DateInterval.Day, lnperiodo, ldfectra)

                If lccondic = "S" Then ' Or (lccontra = "G" And ldfeclim >= Me.pdfecval)
                    Me.pdfecval = ldfectra

                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If IsDBNull(cre.Tables("creditos").Rows(0)("dfecvig")) Then
                    Me.pdfecoto = #7/1/2000#
                Else
                    Me.pdfecoto = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag2 = cre.Tables("creditos").Rows(0)("dfecvig")
                End If
                Me.pdfecven = cre.Tables("creditos").Rows(0)("dfecven")

                Me.cnrolin = lcnrolin
                planpago1(pccodcta)
                'If lccondic = "S" Then
                '    kardex1(pccodcta, pdfechareal, tipo)
                'Else
                '    kardex1(pccodcta, pdfecha, tipo)
                'End If

                Dim dstable As New DataTable
                dstable = dtx.Clone
                dstable.TableName = "Kardex"

                cre.Tables.Add(dstable)

                Dim copyRow As DataRow
                For Each copyRow In dtx.Rows
                    cre.Tables("Kardex").ImportRow(copyRow)
                Next

                gastos1(pccodcta)
                linea1(lcnrolin)
                For Each filalineacre As DataRow In cre.Tables("LINEACRE").Rows 'esta cambio se debe a que tomara de la cremcre la tasa de interes
                    filalineacre("ntasint") = lntasacre
                Next
                'calcula el interes a partir de las tablas anteriores ya llenas
                lncapdes = 0
                lncappag = 0
                lnintpag = 0
                lnmorpag = 0
                lnmonto = 0
                lngaspag = 0
                lnahosim = 0
                lnaporta = 0
                lnsegdeu = 0
                lncomision = 0
                lniva = 0

                Dim lcdockp As String = ""
                Dim lcdocaj As String = ""
                'colocara una fecha mucho anterior
                'ya que los registros no vienen en orden y evaluara la fecha mayor
                Dim lnintpagado As Double = 0

                If cre.Tables("kardex").Rows.Count <= 0 Then
                Else
                    For Each filakar In cre.Tables("kardex").Rows
                        ldultpag2 = Date.Parse(filakar("dfecpro"))
                        If filakar("cestado") = " " Then
                            If filakar("cconcep") <> "CJ" Then
                                If filakar("cdescob") = "D" Then
                                    Me.pdfecvig = filakar("dfecpro")
                                    LDULTPAGINT = filakar("dfecpro")
                                End If
                                If filakar("cconcep") = "KP" And filakar("cdescob") = "D" Then
                                    lncapdes = lncapdes + filakar("nmonto")
                                    If filakar("dfecpro") > ldultpag Then
                                        ldultpag = Date.Parse(filakar("dfecpro"))
                                    End If
                                ElseIf filakar("cconcep") = "KP" And filakar("cdescob") = "C" Then
                                    lncappag = lncappag + filakar("nmonto")
                                    If filakar("ctippag") <> "P" Then 'ultimo cambio
                                        lcdockp = filakar("cnrodoc")
                                    End If

                                    If filakar("dfecpro") > ldultpag Then 'cambio harikiry 'Or (filakar("ctippag") <> "P" )
                                        ldultpag = filakar("dfecpro")
                                    End If
                                ElseIf filakar("cconcep") = "IN" Then
                                    lnintpag = lnintpag + filakar("nmonto")
                                    lnintpagado = lnintpagado + filakar("nmonto")
                                    interes = interes + filakar("nmonto")
                                    LDULTPAGINT = filakar("dfecpro")
                                    If filakar("ctippag") = "P" Then 'ultimo cambio
                                        lcdocaj = filakar("cnrodoc")
                                    End If
                                ElseIf filakar("cconcep") = "08" And filakar("cdescob") = "C" Then
                                    lnintpag = lnintpag + filakar("nmonto")
                                    lnintpagado = lnintpagado + filakar("nmonto")
                                    interes = interes + filakar("nmonto")

                                ElseIf filakar("cconcep") = "MO" Or filakar("cconcep") = "IM" Then
                                    lnmorpag = lnmorpag + filakar("nmonto")
                                    mora = mora + filakar("nmonto")
                                    If filakar("ctippag") = "P" Then 'ultimo cambio
                                        lcdocaj = filakar("cnrodoc")
                                    End If

                                ElseIf filakar("cconcep") = "SD" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' Seguro de Deuda
                                    lnsegdeu = lnsegdeu + filakar("nmonto")
                                ElseIf (filakar("cconcep") = "CO" Or filakar("cconcep") = "OP") And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' manejo
                                    lncomision = lncomision + filakar("nmonto")
                                ElseIf filakar("cconcep") = "IV" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' iva
                                    lniva = lniva + filakar("nmonto")

                                    'verifica si pago algo de ahorros en la ultima fecha de pago
                                ElseIf filakar("cconcep") = "01" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' ahorro simultaneo
                                    lnahosim = lnahosim + filakar("nmonto")

                                ElseIf filakar("cconcep") = "06" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' aportaciones
                                    lnaporta = lnaporta + filakar("nmonto")

                                ElseIf filakar("cconcep") = "CJ" Then

                                Else
                                    'gastos
                                    ncuenta = 0
                                    For Each filagas In cre.Tables("gastos").Rows
                                        If IsDBNull(filagas("cnrocuo")) Then
                                            filagas("cnrocuo") = "000"
                                        End If
                                        If IsDBNull(filakar("cnrocuo")) Then
                                            filakar("cnrocuo") = "000"
                                        End If
                                        If filagas("cnrocuo") = filakar("cnrocuo") And filagas("cdescob") = filakar("cdescob") And filagas("ctipgas") = filakar("cconcep") Then
                                            If filagas("nmongas") - filagas("nmonpag") < filakar("nmonto") Then
                                                lnmonto = filagas("nmongas") - filagas("nmonpag")
                                                lcestado = "P"
                                            Else
                                                lnmonto = filagas("nmongas")
                                                lcestado = "E"
                                            End If
                                            cre.Tables("gastos").Rows(ncuenta)("nmonpag") = lnmonto
                                            cre.Tables("gastos").Rows(ncuenta)("dfecpag") = filakar("dfecpro")
                                        End If
                                        ncuenta = ncuenta + 1
                                    Next
                                    lngaspag = lngaspag + filakar("nmonto")
                                End If
                            End If
                        End If
                    Next

                End If
                Me.pdultpag = ldultpag
                Me.pdultpag2 = ldultpag2
                Me.ahosim = lnahosim
                Me.aporta = lnaporta

                'calcula fecha de ultimo pago cuando no abona intereses
                Dim lsi As Boolean
                Dim cuentafilas As Integer
                cuentafilas = cre.Tables("kardex").Rows.Count
                'esta sentencia da error porque no hay lineas
                '   If cuentafilas > 0 Then
                '  filakar.Delete()
                ' End If
                'evalua todo en busca de interes y si no haya evalua abajo
                For Each filakar In cre.Tables("kardex").Rows
                    If filakar("dfecpro") = ldultpag And filakar("cconcep") = "IN" Then
                        'llega hasta el final
                        lsi = True
                        Exit For
                    Else
                        lsi = False
                        Exit For
                    End If
                Next

                '*********** busca interes pendiente que se guardo en cclip **********
                lninteresflatpendiente = 0
                Dim lnflayfloy As Double = 0
                Dim lcclipag As String

                For Each filakar In cre.Tables("kardex").Rows
                    If IsDBNull(filakar("cclipag")) Then
                        filakar("cclipag") = 0
                    End If
                    lcclipag = filakar("cclipag")

                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " Then
                            lninteresflatpendiente = Double.Parse(filakar("cclipag"))
                        End If
                        ' Exit For
                    End If
                Next

                'Verifica pagos despues de interes pendiente
                For Each filakar In cre.Tables("kardex").Rows
                    lcclipag = filakar("cclipag")
                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " And lcclipag <> "0" Then
                        Else
                            lnflayfloy = Double.Parse(filakar("nmonto"))
                            Exit For
                        End If
                    End If
                Next
                If lninteresflatpendiente <= 0 Then
                    lnflayfloy = 0
                End If

                'false significa no abono intereses

                'revisar esta parte ***** no completa ***********
                If lsi = False Then
                    'verifica si abono a capital en el ultimo pago
                    'y se va para atras de uno en uno
                    For Each filakar In cre.Tables("kardex").Rows
                        If filakar("dfecpro") = ldultpag And filakar("cconcep") = "KP" Then
                            If filakar("cconcep") = "KP" And filakar("cestado") = " " Then
                                ldultpag = filakar("dfecpro")
                            End If
                        End If
                    Next
                End If 'lsi ultimo pago no abona interese

                '***********
                'halla pagos a cuenta
                Dim lnintpen As Double
                Dim lnpagcta As Double
                Dim lncuentafilas As Integer
                Dim llfin As Boolean
                Dim i As Integer
                Dim lcnrodoc As String
                Dim iguardado As Integer

                lnintpen = 0
                lnpagcta = 0
                llfin = False

                lncuentafilas = cre.Tables("kardex").Rows.Count
                lncuentafilas = lncuentafilas - 1
                'For i = 0 To lncuentafilas Step -1
                For i = lncuentafilas To 0 Step -1

                    If cre.Tables("kardex").Rows(i)("cdescob") = "D" Then

                    Else
                        lcnrodoc = cre.Tables("kardex").Rows(i)("cnrodoc")
                        iguardado = i
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc

                            If cre.Tables("kardex").Rows(i)("cconcep") = "KP" Then
                                llfin = True
                                Exit For
                            End If
                            If i > 0 Then

                                i = i - 1
                            End If
                        Loop
                        If llfin Then
                            Exit For
                        End If
                        i = iguardado
                        Dim flagi As Integer
                        flagi = iguardado
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc
                            'If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Then
                            If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Or cre.Tables("kardex").Rows(i)("cconcep") = "08" Then
                                lnintpen = lnintpen + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                                'ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Then
                            ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Or cre.Tables("kardex").Rows(i)("cconcep") = "IM" Then
                                lnpagcta = lnpagcta + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                            End If
                            If i > 0 Then
                                i = i - 1
                            End If
                        Loop
                        'i = flagi 
                        i = i + 1
                    End If
                Next
                If pcflat.Trim = "F" Then
                    lnintpag = lnintpag '- lnintpen
                Else
                    lnintpag = lnintpag - lnintpen
                End If

                lnmorpag = lnmorpag - lnpagcta

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapdes") = lncapdes
                cre.Tables("creditos").Rows(0)("ncappag") = lncappag
                cre.Tables("creditos").Rows(0)("nintpag") = lnintpag
                cre.Tables("creditos").Rows(0)("nmorpag") = lnmorpag
                'cre.Tables("kardex").Rows(0)("ngaspag") = lngaspag
                cre.Tables("creditos").Rows(0)("dultpag") = ldultpag
                cre.Tables("creditos").Rows(0)("nintpen") = lnintpen
                cre.Tables("creditos").Rows(0)("npagcta") = lnpagcta
                Dim lncuentaplan As Integer
                'halla teorico y cancela cuotas y fecha de vencimiento
                lncuentaplan = cre.Tables("planpago").Rows.Count
                lncuentaplan = lncuentaplan - 1
                ldultven = cre.Tables("planpago").Rows(lncuentaplan)("dfecven")
                ncuenta = 0

                Dim lnllave As Integer = 0
                If Me.pcflat.Trim = "F" Then
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "D" Then
                            lnSalCap = lnSalCap + filaplan("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                        Else
                            lnCapCal = lnCapCal + filaplan("ncapita")
                            lnintcal = lnintcal + filaplan("nintere")

                            If Math.Round(lnintcal, 2) > Math.Round(lnintpagado, 2) And lnllave = 0 Then
                                ldultven = filaplan("dfecven")
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                lnllave = 1
                                'Exit For
                            End If
                            If Math.Round(lnCapCal, 2) > Math.Round(lncappag, 2) Then
                                ldultven = filaplan("dfecven")
                                lncappag = filaplan("ncapita") - (lnCapCal - lncappag)
                                cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                Exit For
                            End If


                            cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                            cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                            If lnllave = 0 Then
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                            End If

                        End If
                        ncuenta = ncuenta + 1
                    Next

                Else 'Sobresaldo
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "D" Then
                            lnSalCap = lnSalCap + filaplan("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                        Else
                            lnCapCal = lnCapCal + filaplan("ncapita")
                            lnintcal = lnintcal + filaplan("nintere")

                            If Math.Round(lnCapCal, 2) > Math.Round(lncappag, 2) Then
                                ldultven = filaplan("dfecven")
                                lncappag = Math.Round(filaplan("ncapita") - (lnCapCal - lncappag), 2)
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)

                                If cre.Tables("planpago").Rows(ncuenta)("ncapita") = 0 Then
                                Else
                                    cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                                End If

                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado

                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                Exit For
                            End If


                            cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                            cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                        End If
                        ncuenta = ncuenta + 1
                    Next

                End If



                'Debido a Error reportado version Mexico 2015, hara un nuevo barrido para el Interes pagado, por problemas en la proyección 
                'del interes FLAT

                If Me.pcflat.Trim = "F" Then
                    lnintcal = 0
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "N" Then
                            lnintcal = lnintcal + filaplan("nintere")
                            If Math.Round(lnintcal, 2) > Math.Round(lnintpagado, 2) And lnllave = 0 Then
                                ldultven = filaplan("dfecven")
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado
                                lnllave = 1
                                Exit For
                            End If

                            If lnllave = 0 Then
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                            End If

                        End If
                    Next
                End If

                Dim lnintpagk1 As Double
                Dim lnintpagk As Double
                Dim ldfecven As Date
                Dim lnintmor As Double

                lnintpagk1 = cre.Tables("creditos").Rows(0)("nintpag")
                lnintpagk = cre.Tables("creditos").Rows(0)("nintpag")


                'encuentra capital teorico
                Dim ncuentatot As Integer
                Dim lnintere As Double
                lnCapCal = 0
                ncuenta = 0
                ncuentatot = cre.Tables("planpago").Rows.Count
                If ncuentatot > 0 Then
                    ncuentatot = ncuentatot - 1
                End If

                Do While cre.Tables("planpago").Rows(ncuenta)("dfecven") < gdfecsis And ncuenta <= ncuentatot
                    If cre.Tables("planpago").Rows(ncuenta)("ctipope") <> "D" And ncuenta <= ncuentatot Then
                        lnCapCal = lnCapCal + cre.Tables("planpago").Rows(ncuenta)("ncapita")
                    End If
                    ncuenta = ncuenta + 1
                    If ncuenta > ncuentatot Then
                        Exit Do
                    End If
                Loop
                ldfecven = cre.Tables("planpago").Rows(ncuentatot)("dfecven")

                '** calcula el interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<
                Dim lnintproximo As Decimal = 0
                Dim lnnext As Integer = 0
                'determina interes esperado
                lninteresesperado = 0
                lntotalinteres = 0
                lnintereind = 0
                Dim ldfecant As Date
                Dim fila As DataRow
                For Each fila In cre.Tables("planpago").Rows
                    If fila("dfecven") <= Me.pdfecval And fila("ctipope") <> "D" Then
                        lninteresesperado = lninteresesperado + fila("nintere")
                        If fila("dfecven") = Me.pdfecval Then
                            lnnext = 1
                        End If
                    Else
                        If fila("ctipope") <> "D" And lnnext = 0 Then
                            If Me.pdfecval > ldfecant Then 'la activa o abierta es un dia despues de vencida la anterior
                                lnnext = 1
                                lnintproximo = lnintproximo + fila("nintere")
                                lnintereind = fila("nintere")
                            End If
                        Else
                        End If
                    End If
                    If fila("ctipope") <> "D" Then
                        lntotalinteres = lntotalinteres + fila("nintere")
                        If lnnext = 0 Then
                            lnintereind = fila("nintere")
                        End If
                    End If
                    ldfecant = fila("dfecven")
                Next


                '*********************   Nueva forma de cobrar interes flat ******************************
                Dim n As Double
                Dim lnfecnum2 As Double

                If Me.pdfecval.Year <> LDULTPAGINT.Year Then     ' pdultpag.Year 
                    n = Me.pdfecval.Year - Me.pdultpag.Year
                    lnfecnum2 = (Me.pdfecval.Month + n * 12) - LDULTPAGINT.Month 'pdultpag
                Else
                    lnfecnum2 = Me.pdfecval.Month - LDULTPAGINT.Month 'pdultpag
                End If
                '*************** Finaliza nueva forma de cobrar interes flat *****************************

                '** calcula el interes flat o sobre saldos
                If Me.pcflat = "F" Then
                    'lnintere = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                    'Modificado a petición Mexico solo mostrara como saldo lo vencido   29/10/2014
                    lnintere = Math.Round((lninteresesperado - lnintpag), 2)
                    If lnintere < 0 Then
                        lnintere = 0
                    End If
                    If lnintere <= 0 And Math.Round(lntotalinteres - lnintpag, 2) > 0 Then

                        'Modificado a petición Mexico solo mostrara como saldo lo vencido   29/10/2014
                        'Calcular el interes de la proxima cuota
                        If Math.Round((lninteresesperado - lnintpag), 2) > 0 Then
                            lnintere = Math.Round((lninteresesperado - lnintpag), 2)
                        Else
                            lnintere = 0 'mxCalcInterestFLAT(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes")) ' Math.Round(lnintproximo, 2) 
                        End If
                        'If Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2) > 0 Then
                        '    lnintere = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                        'Else
                        '    lnintere = 0 'mxCalcInterestFLAT(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes")) ' Math.Round(lnintproximo, 2) 
                        'End If
                        'If Math.Round(lnintere, 2) > Math.Round(lnintereind, 2) Then
                        '    lnintere = lnintereind
                        'Else
                        'End If
                    Else 'Aqui tendria q ir el calculo de intereses si el credito esta vencido y ya pago todo el interes teorico
                        'lnintere = lnintereind

                        'Prueba Rafa 09/09/2014
                        For Each filaplan In cre.Tables("planpago").Rows
                            If filaplan("nintere") - filaplan("nintpag") > 0 And filaplan("ctipope") = "N" _
                               And filaplan("dfecven") <= Me.pdfecval Then
                                lnintere = filaplan("nintere") - filaplan("nintpag")
                                Exit For
                            End If

                        Next

                        '  Do While .NOT.EOF()
                        '      If CUOTAS.nintere - CUOTAS.nintPag > 0 Then
                        '          lnintere = CUOTAS.nintere - CUOTAS.nintPag
                        'EXIT
                        '      End If
                        '      SKIP()
                        '      ENDDO()
                    End If

                    lnintere = IIf(Math.Round(lnintere, 2) < 0, 0, Math.Round(lnintere, 2))
                Else
                    lnintere = mxCalcInterest(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                End If

                '>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<Calculo para utilizar en partida regularizadora

                Dim lnintereant As Decimal = 0
                If tipo = "R" Then 'para partida regularizadora
                    If Me.pcflat = "F" Then
                        lnintereant = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                        If lnintereant < 0 Then
                            lnintereant = 0
                        End If
                        If lnintereant <= 0 And Math.Round(lntotalinteres - lnintpag, 2) > 0 Then
                            'Calcular el interes de la proxima cuota
                            If Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2) > 0 Then
                                lnintereant = Math.Round((lninteresesperado + lnintproximo) - lnintpag, 2)
                            Else
                                If lccondic = "S" Then
                                    lnintereant = mxCalcInterestFLATAnt(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes"), pdfecval) ' Math.Round(lnintproximo, 2) 
                                Else
                                    lnintereant = mxCalcInterestFLATAnt(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes"), dfecant) ' Math.Round(lnintproximo, 2) 
                                End If

                            End If
                            'If Math.Round(lnintereant, 2) > Math.Round(lnintereind, 2) Then
                            '    lnintereant = lnintereind
                            'Else
                            'End If
                        Else 'Aqui tendria q ir el calculo de intereses si el credito esta vencido y ya pago todo el interes teorico, Pendiente de resolver
                            lnintereant = lnintereind
                        End If

                        lnintereant = IIf(Math.Round(lnintereant, 2) < 0, 0, Math.Round(lnintereant, 2))
                    Else
                        If lccondic = "S" Then
                            lnintereant = mxCalcInterestAnt(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"), pdfecval)
                        Else
                            lnintereant = mxCalcInterestAnt(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"), dfecant)
                        End If

                    End If
                End If


                '<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


                Dim ecredkar As New cCredkar
                Dim lnintaju As Double = 0
                Dim lnmoraju As Double = 0



                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                If lcdockp >= lcdocaj Then 'ultimo cambio estilo Harikiry

                Else
                    lnintaju = ecredkar.ObtenerInteresAjustado(pccodcta)
                    lnmoraju = ecredkar.ObtenerMoraAjustado(pccodcta)

                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                'lnintere = lnintere - lnintaju



                If Me.pcflat.Trim = "F" Then
                    lnDiaAtr = mxCalcDiaAtr()
                Else
                    lnDiaAtr = mxCalcDiaAtr2()
                End If


                lnintmor = mxCalcMoratory()
                If lnDiaAtr <= 0 Then
                    lnintmor = 0
                End If

                Dim lnintmorant As Decimal = 0
                If tipo = "R" Then 'para partida regularizadora
                    If Me.pcflat.Trim = "F" Then
                        pndiaatrAnt = mxCalcDiaAtrAnt(dfecant)
                    Else
                        pndiaatrAnt = mxCalcDiaAtrAnt2(dfecant)
                    End If
                    If pndiaatrAnt <= 0 Then
                        lnintmorant = 0
                    Else
                        If lccondic = "S" Then
                            lnintmorant = mxCalcMoratoryAnt(pdfecval)
                        Else
                            lnintmorant = mxCalcMoratoryAnt(dfecant)
                        End If

                    End If
                End If

                '                lnintmor = lnintmor - lnmoraju

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapcal") = lnCapCal
                cre.Tables("creditos").Rows(0)("nintcal") = lnintere + cre.Tables("creditos").Rows(0)("nintpag") '+ cre.Tables("creditos").Rows(0)("nintpen") 'ultimo cambio
                cre.Tables("creditos").Rows(0)("nIntMor") = lnintmor + cre.Tables("creditos").Rows(0)("nmorpag")  '+ cre.Tables("creditos").Rows(0)("npagcta") 'ultimo cambio
                cre.Tables("creditos").Rows(0)("ndiaatr") = lnDiaAtr


                '**************actualiza las propiedades********************
                Me.pcnomcli = cre.Tables("creditos").Rows(0)("cnomcli")
                Me.pccodcli = cre.Tables("creditos").Rows(0)("ccodcli")
                Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")


                If (Me.pncapdes - Me.pncappag) <= 0 Then
                    Return 9
                End If
                ' DIRECTO DEL CALCULO
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If pcflat.Trim = "F" Then
                    pnsalint = lnintere - lnintaju
                Else
                    Me.pnsalint = cre.Tables("creditos").Rows(0)("nintcal") - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) '- lnintaju
                End If


                Me.pnsalmor = (cre.Tables("creditos").Rows(0)("nintmor") + pnsalmorPen) - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) '- lnmoraju

                If Me.pnsalint < 0 Then
                    Me.pnsalint = 0
                End If
                If Me.pnsalmor < 0 Then
                    Me.pnsalmor = 0
                End If


                If tipo = "R" Then 'para partida regularizadora
                    If pcflat.Trim = "F" Then
                        pnsalintAnt = lnintereant - lnintaju
                    Else
                        Me.pnsalintAnt = (lnintereant + cre.Tables("creditos").Rows(0)("nintpag")) - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) '- lnintaju
                    End If
                    Me.pnsalmorAnt = (lnintmorant + cre.Tables("creditos").Rows(0)("nmorpag")) - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) '- lnmoraju
                    If Me.pnsalintAnt < 0 Then
                        Me.pnsalintAnt = 0
                    End If
                    If Me.pnsalmorAnt < 0 Then
                        Me.pnsalmorAnt = 0
                    End If
                End If


                '
                Me.pndiaatr = cre.Tables("creditos").Rows(0)("ndiaatr")
                If Me.pndiaatr < 0 Then
                    Me.pndiaatr = 0
                End If
                Me.pnintpag = cre.Tables("creditos").Rows(0)("nintpag")
                Me.pnintpen = cre.Tables("creditos").Rows(0)("nintpen")
                Me.pnintcal = cre.Tables("creditos").Rows(0)("nintcal")
                Me.pnmorpag = cre.Tables("creditos").Rows(0)("nmorpag")
                Me.pnpagcta = cre.Tables("creditos").Rows(0)("npagcta")
                Me.pnintmor = cre.Tables("creditos").Rows(0)("nintmor")
                Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")
                Me.pncapcal = cre.Tables("creditos").Rows(0)("ncapcal")



                Dim lndeucap1 As Double
                'Dim fila As DataRow
                'evalue el pncapita, capital minimo necesario para pagar
                lndeucap1 = 0
                For Each fila In cre.Tables("planpago").Rows
                    'pdfechareal por Me.pdfecval
                    If fila("dfecven") < pdfechareal And fila("ctipope") <> "D" Then
                        lndeucap1 = lndeucap1 + (fila("ncapita") - fila("ncappag"))
                    End If
                    If Math.Round(lndeucap1, 2) < 0 Then
                        lndeucap1 = 0
                    End If
                Next
                Me.pndeucap = Math.Round(lndeucap1, 2)

                'If pndeucap > Math.Round((pncapdes - pncappag), 2) Then
                '    pndeucap = Math.Round((pncapdes - pncappag), 2)
                'End If

                '-------Deuda capital incluyendo capital del dia de pago
                Dim lndeucap2 As Double = 0
                'Dim fila As DataRow
                'evalue el pncapita, capital minimo necesario para pagar
                lndeucap2 = 0
                For Each fila In cre.Tables("planpago").Rows
                    'pdfechareal por Me.pdfecval
                    If fila("dfecven") <= pdfechareal And fila("ctipope") <> "D" Then
                        lndeucap2 = lndeucap2 + (fila("ncapita") - fila("ncappag"))
                    End If
                    If Math.Round(lndeucap2, 2) < 0 Then
                        lndeucap2 = 0
                    End If
                Next
                Me.pndeucap2 = Math.Round(lndeucap2, 2)


                If tipo = "R" Then 'para partida regularizadora
                    Dim lndeucapant As Double
                    'Dim fila As DataRow
                    'evalue el pncapita, capital minimo necesario para pagar
                    lndeucapant = 0
                    For Each fila In cre.Tables("planpago").Rows
                        'pdfechareal por Me.pdfecval
                        If fila("dfecven") < dfecant And fila("ctipope") <> "D" Then
                            lndeucapant = lndeucapant + (fila("ncapita") - fila("ncappag"))
                        End If
                        If Math.Round(lndeucapant, 2) < 0 Then
                            lndeucapant = 0
                        End If
                    Next
                    Me.pndeucapAnt = Math.Round(lndeucapant, 2)

                End If

                Return 1
            End If 'si existen creditos

            Return 0
        Catch ex As Exception
            Return 0
        End Try


    End Function

    'calculo para prueba X utiliza otro parametro
    Function omcalcinterestPruebax(ByVal tipo As String, ByVal dtx As DataTable) As Integer
        'incorpora al dataset las tablas del kardex y plan de pagos
        Dim lcnrolin As String
        Dim filakar As DataRow
        Dim filagas As DataRow
        Dim lncapdes As Double
        Dim lncappag As Double
        Dim lnintpag As Double
        Dim lnmorpag As Double
        Dim lnmonto As Double
        Dim lcestado As String
        Dim lngaspag As Double
        Dim ldultven As Date
        Dim filaplan As DataRow
        Dim lnSalCap As Double
        Dim ncuenta As Integer
        Dim lnCapCal As Double
        Dim lnDiaAtr As Integer
        Dim interes As Double
        Dim mora As Double
        Dim ldultpag As Date
        Dim ldtulpag2 As Date
        Dim lnahosim As Double
        Dim lnaporta As Double
        Dim lnsegdeu As Double
        Dim lncomision As Double = 0
        Dim lniva As Double = 0

        Dim clsppal As New class1
        Dim ecredppg As New cCredppg
        Dim lncapint As Double
        Dim lctipper As String
        Dim lndiasug As Integer
        Dim lsegdeu1 As Boolean
        Dim lccodlin As String
        Dim pdfecha As Date
        Dim pdfechareal As Date
        pdfecha = Me.pdfecval
        Dim lninteresesperado As Double 'interes esperado a la fecha en que paga
        lninteresesperado = 0
        Dim LDULTPAGINT As Date
        Dim lntotalinteres As Double  'interes total esperado en plan de pagos
        Dim lnintereind As Double  ' interes unitario flat a pagar en plan de pagos


        ldultpag = Me.gdultpag
        ldultpag2 = Me.gdultpag
        pdfechareal = Me.pdfecval
        cre.Tables.Clear()

        ldultpag = Me.gdultpag
        Dim okcre As Integer
        Dim lninteresflatpendiente As Double

        lninteresflatpendiente = 0

        Try
            '****************** TEMPORALMENTE ******************

            Me.pdfecval = Me.pdfecval ' fecha valor
            interes = 0
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'If pccodcta = "022002011700164601" Then
            'lnSalCap = 0
            'End If
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            lnSalCap = 0
            lnCapCal = 0
            lnintcal = 0
            mora = 0
            creditos1(pccodcta)
            'Verificar estado del credito a la fecha de calculo

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If cre.Tables("creditos").Rows.Count > 0 Then
                If IsDBNull(Me.pcestado) Then

                Else
                    cre.Tables("creditos").Rows(0)("cestado") = Me.pcestado
                End If
                lcnrolin = cre.Tables("creditos").Rows(0)("cnrolin")
                lncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                lctipper = cre.Tables("creditos").Rows(0)("ctipper")
                lndiasug = cre.Tables("creditos").Rows(0)("ndiasug")
                lsegdeu1 = cre.Tables("creditos").Rows(0)("lsegdeu")
                lccodlin = cre.Tables("creditos").Rows(0)("cCodlin")
                Me.pcflat = cre.Tables("creditos").Rows(0)("cFlat")
                Me.pccodcli = cre.Tables("creditos").Rows(0)("ccodcli")
                'Calcula Cuota>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                lncapint = ecredppg.CapitalInteres(pccodcta)
                Dim pcaplcom As String
                If lccodlin.Substring(8, 2) = "06" Then
                    pcaplcom = "0"
                Else
                    pcaplcom = "1"
                End If
                If lsegdeu1 = True Then
                    pcaplcom = pcaplcom & "1"
                Else
                    pcaplcom = pcaplcom & "0"
                End If
                'Verificamos si aplica comision a pretamos personales
                'If pcaplcom.Substring(0, 1) = "1" Then
                '    lncomision = (lncapdes * (Me.porcomision / 100) * IIf(lctipper = "1", lndiasug, 31)) / Me.gnperbas
                'Else
                lncomision = 0
                'End If
                'Verificamos si aplica comision a Seguro de Deuda
                ' If pcaplcom.Substring(1, 1) = "1" Then
                If lsegdeu1 = True Then
                    lnsegdeu = IIf(lctipper = "1", (lncapdes * Me.porsegdeu * (lndiasug / 30)), (lncapdes * Me.porsegdeu))
                Else
                    lnsegdeu = 0
                End If
                Me.pnmoncuo = utilNumeros.Redondear(lncapint + lncomision + lnsegdeu, 2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If cre.Tables("creditos").Rows(0)("cestado") = "G" Then
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag2 = cre.Tables("creditos").Rows(0)("dfecvig")
                    Return 9
                    Exit Function
                End If

                'Me.pnmoncuo = cre.Tables("creditos").Rows(0)("nmoncuo")
                Me.pccodana = cre.Tables("creditos").Rows(0)("ccodana")
                'Para Creditos Saneados >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                Dim lccondic As String
                Dim ldfectra As Date
                Dim lccontra As String
                Dim lnperiodo As Integer = 0

                lccondic = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccondic")), "N", cre.Tables("creditos").Rows(0)("ccondic"))
                ldfectra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("dfectra")), Me.gdfecsis, cre.Tables("creditos").Rows(0)("dfectra"))
                lccontra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccontra")), "N", cre.Tables("creditos").Rows(0)("ccontra"))

                lnperiodo = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("nperiodo")), 0, cre.Tables("creditos").Rows(0)("nperiodo"))

                Dim ldfeclim As Date
                ldfeclim = DateAdd(DateInterval.Day, lnperiodo, ldfectra)

                If lccondic = "S" Or (lccontra = "G" And ldfeclim >= Me.pdfecval) Then
                    Me.pdfecval = ldfectra
                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If IsDBNull(cre.Tables("creditos").Rows(0)("dfecvig")) Then
                    Me.pdfecoto = #7/1/2000#
                Else
                    Me.pdfecoto = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag2 = cre.Tables("creditos").Rows(0)("dfecvig")
                End If
                Me.pdfecven = cre.Tables("creditos").Rows(0)("dfecven")

                Me.cnrolin = lcnrolin

                planpago1_(pccodcta, pdfechareal)
                'Quitaremos el iva al interes en plan de pagos cuando es flat
                If Me.pcflat.Trim = "F" Then
                    Dim filas As DataRow
                    Dim lnint As Double = 0
                    For Each filas In cre.Tables("planpago").Rows
                        If filas("ctipope") = "D" Then
                        Else
                            lnint = filas("nintere") - Math.Round(filas("nintere") * 0.12 / 1.12, 2)
                            filas("nintere") = Math.Round(lnint, 2)
                        End If
                    Next
                End If


                '---------------------------------------------
                'If lccondic = "S" Then
                '    kardex1(pccodcta, pdfechareal, tipo)
                'Else
                '    kardex1(pccodcta, pdfecha, tipo)
                'End If
                Dim dstable As New DataTable
                dstable = dtx.Clone
                dstable.TableName = "Kardex"

                cre.Tables.Add(dstable)

                Dim copyRow As DataRow
                For Each copyRow In dtx.Rows
                    cre.Tables("Kardex").ImportRow(copyRow)
                Next

                '---------------------------------------------
                gastos1(pccodcta)
                linea1_(lcnrolin, pdfechareal)
                lineamor1(lcnrolin, pdfechareal)
                lineaQuiebre(lcnrolin, pdfechareal)

                'lineamorX(lcnrolin)
                'calcula el interes a partir de las tablas anteriores ya llenas
                lncapdes = 0
                lncappag = 0
                lnintpag = 0
                lnmorpag = 0
                lnmonto = 0
                lngaspag = 0
                lnahosim = 0
                lnaporta = 0
                lnsegdeu = 0
                lncomision = 0
                lniva = 0

                Dim lcdockp As String = ""
                Dim lcdocaj As String = ""
                'colocara una fecha mucho anterior
                'ya que los registros no vienen en orden y evaluara la fecha mayor
                Dim lnintpagado As Double = 0

                If cre.Tables("kardex").Rows.Count <= 0 Then
                Else
                    For Each filakar In cre.Tables("kardex").Rows
                        ldultpag2 = Date.Parse(filakar("dfecpro"))
                        If filakar("cestado") = " " Then
                            If filakar("cconcep") <> "CJ" Then
                                If filakar("cdescob") = "D" Then
                                    Me.pdfecvig = filakar("dfecpro")
                                    LDULTPAGINT = filakar("dfecpro")
                                End If
                                If filakar("cconcep") = "KP" And filakar("cdescob") = "D" Then
                                    lncapdes = lncapdes + filakar("nmonto")
                                    If filakar("dfecpro") > ldultpag Then
                                        ldultpag = Date.Parse(filakar("dfecpro"))
                                    End If
                                ElseIf filakar("cconcep") = "KP" And filakar("cdescob") = "C" Then
                                    lncappag = lncappag + filakar("nmonto")
                                    If filakar("ctippag") <> "P" Then 'ultimo cambio
                                        lcdockp = filakar("cnrodoc")
                                    End If

                                    If filakar("dfecpro") > ldultpag Then
                                        ldultpag = filakar("dfecpro")
                                    End If
                                ElseIf filakar("cconcep") = "IN" Then
                                    lnintpag = lnintpag + filakar("nmonto")
                                    lnintpagado = lnintpagado + filakar("nmonto")
                                    interes = interes + filakar("nmonto")
                                    LDULTPAGINT = filakar("dfecpro")
                                    If filakar("ctippag") = "P" Then 'ultimo cambio
                                        lcdocaj = filakar("cnrodoc")
                                    End If
                                ElseIf filakar("cconcep") = "MO" Then
                                    lnmorpag = lnmorpag + filakar("nmonto")
                                    mora = mora + filakar("nmonto")
                                    If filakar("ctippag") = "P" Then 'ultimo cambio
                                        lcdocaj = filakar("cnrodoc")
                                    End If
                                ElseIf filakar("cconcep") = "SD" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' Seguro de Deuda
                                    lnsegdeu = lnsegdeu + filakar("nmonto")
                                ElseIf (filakar("cconcep") = "CO" Or filakar("cconcep") = "OP") And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' manejo
                                    lncomision = lncomision + filakar("nmonto")
                                ElseIf filakar("cconcep") = "IV" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' iva
                                    lniva = lniva + filakar("nmonto")

                                    'verifica si pago algo de ahorros en la ultima fecha de pago
                                ElseIf filakar("cconcep") = "01" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' ahorro simultaneo
                                    lnahosim = lnahosim + filakar("nmonto")

                                ElseIf filakar("cconcep") = "06" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' aportaciones
                                    lnaporta = lnaporta + filakar("nmonto")

                                ElseIf filakar("cconcep") = "CJ" Then

                                Else
                                    'gastos
                                    ncuenta = 0
                                    For Each filagas In cre.Tables("gastos").Rows
                                        If IsDBNull(filagas("cnrocuo")) Then
                                            filagas("cnrocuo") = "000"
                                        End If
                                        If IsDBNull(filakar("cnrocuo")) Then
                                            filakar("cnrocuo") = "000"
                                        End If
                                        If filagas("cnrocuo") = filakar("cnrocuo") And filagas("cdescob") = filakar("cdescob") And filagas("ctipgas") = filakar("cconcep") Then
                                            If filagas("nmongas") - filagas("nmonpag") < filakar("nmonto") Then
                                                lnmonto = filagas("nmongas") - filagas("nmonpag")
                                                lcestado = "P"
                                            Else
                                                lnmonto = filagas("nmongas")
                                                lcestado = "E"
                                            End If
                                            cre.Tables("gastos").Rows(ncuenta)("nmonpag") = lnmonto
                                            cre.Tables("gastos").Rows(ncuenta)("dfecpag") = filakar("dfecpro")
                                        End If
                                        ncuenta = ncuenta + 1
                                    Next
                                    lngaspag = lngaspag + filakar("nmonto")
                                End If
                            End If
                        End If
                    Next

                End If
                lineamorX(lcnrolin)

                Me.pdultpag = ldultpag
                Me.pdultpag2 = ldultpag2
                Me.ahosim = lnahosim
                Me.aporta = lnaporta

                'calcula fecha de ultimo pago cuando no abona intereses
                Dim lsi As Boolean
                Dim cuentafilas As Integer
                cuentafilas = cre.Tables("kardex").Rows.Count
                'esta sentencia da error porque no hay lineas
                '   If cuentafilas > 0 Then
                '  filakar.Delete()
                ' End If
                'evalua todo en busca de interes y si no haya evalua abajo
                For Each filakar In cre.Tables("kardex").Rows
                    If filakar("dfecpro") = ldultpag And filakar("cconcep") = "IN" Then
                        'llega hasta el final
                        lsi = True
                        Exit For
                    Else
                        lsi = False
                        Exit For
                    End If
                Next

                '*********** busca interes pendiente que se guardo en cclip **********
                lninteresflatpendiente = 0
                Dim lnflayfloy As Double = 0
                Dim lcclipag As String

                For Each filakar In cre.Tables("kardex").Rows
                    If IsDBNull(filakar("cclipag")) Then
                        filakar("cclipag") = 0
                    End If
                    lcclipag = filakar("cclipag")

                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " Then
                            lninteresflatpendiente = Double.Parse(filakar("cclipag"))
                        End If
                        ' Exit For
                    End If
                Next

                'Verifica pagos despues de interes pendiente
                For Each filakar In cre.Tables("kardex").Rows
                    lcclipag = filakar("cclipag")
                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " And lcclipag <> "0" Then
                        Else
                            lnflayfloy = Double.Parse(filakar("nmonto"))
                            Exit For
                        End If
                    End If
                Next
                If lninteresflatpendiente <= 0 Then
                    lnflayfloy = 0
                End If

                'false significa no abono intereses

                'revisar esta parte ***** no completa ***********
                If lsi = False Then
                    'verifica si abono a capital en el ultimo pago
                    'y se va para atras de uno en uno
                    For Each filakar In cre.Tables("kardex").Rows
                        If filakar("dfecpro") = ldultpag And filakar("cconcep") = "KP" Then
                            If filakar("cconcep") = "KP" And filakar("cestado") = " " Then
                                ldultpag = filakar("dfecpro")
                            End If
                        End If
                    Next
                End If 'lsi ultimo pago no abona interese

                '***********
                'halla pagos a cuenta
                Dim lnintpen As Double
                Dim lnpagcta As Double
                Dim lncuentafilas As Integer
                Dim llfin As Boolean
                Dim i As Integer
                Dim lcnrodoc As String
                Dim iguardado As Integer

                lnintpen = 0
                lnpagcta = 0
                llfin = False

                lncuentafilas = cre.Tables("kardex").Rows.Count
                lncuentafilas = lncuentafilas - 1
                'For i = 0 To lncuentafilas Step -1
                For i = lncuentafilas To 0 Step -1

                    If cre.Tables("kardex").Rows(i)("cdescob") = "D" Then

                    Else
                        lcnrodoc = cre.Tables("kardex").Rows(i)("cnrodoc")
                        iguardado = i
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc

                            If cre.Tables("kardex").Rows(i)("cconcep") = "KP" Then
                                llfin = True
                                Exit For
                            End If
                            If i > 0 Then

                                i = i - 1
                            End If
                        Loop
                        If llfin Then
                            Exit For
                        End If
                        i = iguardado
                        Dim flagi As Integer
                        flagi = iguardado
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc
                            If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Then
                                lnintpen = lnintpen + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                            ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Then
                                lnpagcta = lnpagcta + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                            End If
                            If i > 0 Then
                                i = i - 1
                            End If
                        Loop
                        'i = flagi 
                        i = i + 1
                    End If
                Next
                lnintpag = lnintpag '- lnintpen
                lnmorpag = lnmorpag - lnpagcta

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapdes") = lncapdes
                cre.Tables("creditos").Rows(0)("ncappag") = lncappag
                cre.Tables("creditos").Rows(0)("nintpag") = lnintpag
                cre.Tables("creditos").Rows(0)("nmorpag") = lnmorpag
                'cre.Tables("kardex").Rows(0)("ngaspag") = lngaspag
                cre.Tables("creditos").Rows(0)("dultpag") = ldultpag
                cre.Tables("creditos").Rows(0)("nintpen") = lnintpen
                cre.Tables("creditos").Rows(0)("npagcta") = lnpagcta
                Dim lncuentaplan As Integer
                'halla teorico y cancela cuotas y fecha de vencimiento
                lncuentaplan = cre.Tables("planpago").Rows.Count
                lncuentaplan = lncuentaplan - 1
                ldultven = cre.Tables("planpago").Rows(lncuentaplan)("dfecven")
                ncuenta = 0

                If Me.pcflat.Trim = "F" Then
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "D" Then
                            lnSalCap = lnSalCap + filaplan("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                        Else
                            lnCapCal = lnCapCal + filaplan("ncapita")
                            lnintcal = lnintcal + filaplan("nintere")

                            If Math.Round(lnintcal, 2) > Math.Round(lnintpagado, 2) Then
                                ldultven = filaplan("dfecven")
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)
                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                Exit For
                            End If
                            If Math.Round(lnCapCal, 2) > Math.Round(lncappag, 2) Then
                                ldultven = filaplan("dfecven")
                                lncappag = filaplan("ncapita") - (lnCapCal - lncappag)
                                cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                Exit For
                            End If


                            cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                            cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                        End If
                        ncuenta = ncuenta + 1
                    Next

                Else 'Sobresaldo
                    For Each filaplan In cre.Tables("planpago").Rows
                        If filaplan("ctipope") = "D" Then
                            lnSalCap = lnSalCap + filaplan("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                        Else
                            lnCapCal = lnCapCal + filaplan("ncapita")
                            lnintcal = lnintcal + filaplan("nintere")

                            'If lnintcal > lnintpagado Then
                            '    ldultven = filaplan("dfecven")
                            '    lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)
                            '    cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado
                            '    cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                            '    Exit For
                            'End If
                            'If (lnCapCal + lnintcal) > (lncappag + lnintpagado) Then
                            If Math.Round(lnCapCal, 2) > Math.Round(lncappag, 2) Then
                                ldultven = filaplan("dfecven")
                                lncappag = filaplan("ncapita") - (lnCapCal - lncappag)
                                lnintpagado = filaplan("nintere") - (lnintcal - lnintpagado)

                                If cre.Tables("planpago").Rows(ncuenta)("ncapita") = 0 Then
                                Else
                                    cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                                End If

                                cre.Tables("planpago").Rows(ncuenta)("nintpag") = lnintpagado

                                cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                                Exit For
                            End If


                            cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                            cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                            cre.Tables("planpago").Rows(ncuenta)("nintpag") = cre.Tables("planpago").Rows(ncuenta)("nintere")
                        End If
                        ncuenta = ncuenta + 1
                    Next

                End If




                Dim lnintpagk1 As Double
                Dim lnintpagk As Double
                Dim ldfecven As Date
                Dim lnintmor As Double

                lnintpagk1 = cre.Tables("creditos").Rows(0)("nintpag")
                lnintpagk = cre.Tables("creditos").Rows(0)("nintpag")


                'encuentra capital teorico
                Dim ncuentatot As Integer
                Dim lnintere As Double
                lnCapCal = 0
                ncuenta = 0
                ncuentatot = cre.Tables("planpago").Rows.Count
                If ncuentatot > 0 Then
                    ncuentatot = ncuentatot - 1
                End If

                Do While cre.Tables("planpago").Rows(ncuenta)("dfecven") < gdfecsis And ncuenta <= ncuentatot
                    If cre.Tables("planpago").Rows(ncuenta)("ctipope") <> "D" And ncuenta <= ncuentatot Then
                        lnCapCal = lnCapCal + cre.Tables("planpago").Rows(ncuenta)("ncapita")
                    End If
                    ncuenta = ncuenta + 1
                    If ncuenta > ncuentatot Then
                        Exit Do
                    End If
                Loop
                ldfecven = cre.Tables("planpago").Rows(ncuentatot)("dfecven")

                '** calcula el interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<

                'determina interes esperado
                lninteresesperado = 0
                lntotalinteres = 0
                lnintereind = 0
                Dim fila As DataRow


                For Each fila In cre.Tables("planpago").Rows
                    If fila("dfecven") <= Me.pdfecval And fila("ctipope") <> "D" Then
                        lninteresesperado = lninteresesperado + filaplan("nintere")
                    End If
                    If fila("ctipope") <> "D" Then
                        lntotalinteres = lntotalinteres + filaplan("nintere")
                        lnintereind = filaplan("nintere")
                    End If

                Next


                '*********************   Nueva forma de cobrar interes flat ******************************
                Dim n As Double
                Dim lnfecnum2 As Double

                If Me.pdfecval.Year <> LDULTPAGINT.Year Then     ' pdultpag.Year 
                    n = Me.pdfecval.Year - Me.pdultpag.Year
                    lnfecnum2 = (Me.pdfecval.Month + n * 12) - LDULTPAGINT.Month 'pdultpag
                Else
                    lnfecnum2 = Me.pdfecval.Month - LDULTPAGINT.Month 'pdultpag
                End If
                '*************** Finaliza nueva forma de cobrar interes flat *****************************

                '** calcula el interes flat o sobre saldos
                If Me.pcflat = "F" Then
                    ''le guitamos el iva-------------------------------
                    'Dim lnintsiva As Double = 0
                    'lnintsiva = Math.Round(lninteresesperado * 0.12 / 1.12, 2)
                    'lninteresesperado = lninteresesperado - lnintsiva
                    ''--------------------------------------------------
                    'lnintsiva = Math.Round(lntotalinteres * 0.12 / 1.12, 2)
                    'lntotalinteres = lntotalinteres - lnintsiva
                    ''--------------------------------------------------
                    'lnintsiva = Math.Round(lnintereind * 0.12 / 1.12, 2)
                    'lnintereind = lnintereind - lnintsiva
                    ''--------------------------------------------------

                    lnintere = lninteresesperado - lnintpag
                    If lnintere < 0 Then
                        lnintere = 0
                    End If

                    If lnintere <= 0 And lntotalinteres - lnintpag > 0 Then
                        'lnintere = mxCalcInterestFLAT(pccodcta, cre.Tables("creditos").Rows(0)("ncapdes"))
                        'If lnintere > lnintereind Then
                        lnintere = lnintereind
                        ' End If
                    End If
                    lnintere = IIf(lnintere < 0, 0, lnintere)

                Else
                    ' lnintere = mxCalcInterest(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                    '          lnintere = mxCalcIntereses()

                    If cre.Tables("LINEACREQ").Rows.Count > 1 Then 'Existe quiebre
                        lnintere = mxCalcInterestQuiebre(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                    Else
                        lnintere = mxCalcInterest(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                    End If

                End If


                Dim ecredkar As New cCredkar
                Dim lnintaju As Double = 0
                Dim lnmoraju As Double = 0



                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                If lcdockp >= lcdocaj Then 'ultimo cambio estilo Harikiry
                Else
                    lnintaju = ecredkar.ObtenerInteresAjustado(pccodcta)
                    lnmoraju = ecredkar.ObtenerMoraAjustado(pccodcta)

                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                'lnintere = lnintere - lnintaju

                If Me.pcflat.Trim = "F" Then
                    lnDiaAtr = mxCalcDiaAtr()
                Else
                    lnDiaAtr = mxCalcDiaAtr2()
                End If

                'If Me.pcflat.Trim = "F" Then
                '    lnintmor = mxCalcMoratoryFlat()
                'Else
                lnintmor = mxCalcMoratory()
                'End If


                If lnDiaAtr <= 0 Then
                    lnintmor = 0
                End If


                lnintmor = lnintmor - lnmoraju

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapcal") = lnCapCal
                cre.Tables("creditos").Rows(0)("nintcal") = lnintere + cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen") 'ultimo cambio
                cre.Tables("creditos").Rows(0)("nIntMor") = lnintmor + cre.Tables("creditos").Rows(0)("nmorpag") '+ cre.Tables("creditos").Rows(0)("npagcta") 'ultimo cambio
                cre.Tables("creditos").Rows(0)("ndiaatr") = lnDiaAtr


                '**************actualiza las propiedades********************
                Me.pcnomcli = cre.Tables("creditos").Rows(0)("cnomcli")
                Me.pccodcli = cre.Tables("creditos").Rows(0)("ccodcli")
                Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")


                If (Me.pncapdes - Me.pncappag) <= 0 Then
                    Return 9
                End If
                ' DIRECTO DEL CALCULO
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>

                Me.pnsalint = cre.Tables("creditos").Rows(0)("nintcal") - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) ' lnintere 
                Me.pnsalmor = cre.Tables("creditos").Rows(0)("nintmor") - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) ' lnintmor
                'Me.pnsalint = cre.Tables("creditos").Rows(0)("nintcal") - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) - lnintaju ' lnintere 
                'Me.pnsalmor = cre.Tables("creditos").Rows(0)("nintmor") - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) - lnmoraju ' lnintmor

                If Me.pnsalint < 0 Then
                    Me.pnsalint = 0
                End If
                If Me.pnsalmor < 0 Then
                    Me.pnsalmor = 0
                End If
                '
                Me.pndiaatr = cre.Tables("creditos").Rows(0)("ndiaatr")
                If Me.pndiaatr < 0 Then
                    Me.pndiaatr = 0
                End If
                Me.pndiaatrint = mxCalcDiaAtrInt(pccodcta, pdfecval, pdfecval)

                'Cambio de acuerdo a normativa de la super
                'los dias mayores entre el capital e intereses

                If pndiaatrint > pndiaatr Then
                    pndiaatr = pndiaatrint
                End If
                '----------------------------------------------------------------------

                Me.pnintpag = cre.Tables("creditos").Rows(0)("nintpag")
                Me.pnintpen = cre.Tables("creditos").Rows(0)("nintpen")
                Me.pnintcal = cre.Tables("creditos").Rows(0)("nintcal")
                Me.pnmorpag = cre.Tables("creditos").Rows(0)("nmorpag")
                Me.pnpagcta = cre.Tables("creditos").Rows(0)("npagcta")
                Me.pnintmor = cre.Tables("creditos").Rows(0)("nintmor")
                Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")
                Me.pncapcal = cre.Tables("creditos").Rows(0)("ncapcal")



                Dim lndeucap1 As Double
                'Dim fila As DataRow
                'evalue el pncapita, capital minimo necesario para pagar
                lndeucap1 = 0
                For Each fila In cre.Tables("planpago").Rows
                    'pdfechareal por Me.pdfecval
                    If fila("dfecven") < pdfechareal And fila("ctipope") <> "D" Then
                        lndeucap1 = lndeucap1 + (fila("ncapita") - fila("ncappag"))
                    End If
                    If Math.Round(lndeucap1, 2) < 0 Then
                        lndeucap1 = 0
                    End If
                Next
                Me.pndeucap = Math.Round(lndeucap1, 2)



                Return 1
            End If 'si existen creditos


            Return 0
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Function mxCalcDiaAtrInt(ByVal cCodcta As String, ByVal dfecha As Date, ByVal dfecval As Date) As Integer
        'Obtener ultima fecha de pago de capital
        Dim ecredkar As New cCredkar
        Dim ldultkp As Date
        ldultkp = ecredkar.UltimafechaCobro(cCodcta, dfecha, "KP", dfecha)

        'Obtener fecha de proximo pago presente
        Dim ecredppg As New cCredppg
        Dim ldfecpag As Date
        Dim ldfecant As Date
        ldfecpag = ecredppg.ProximaFecha(cCodcta, ldultkp) 'dfecha
        ldfecant = ecredppg.AnteriorFecha(cCodcta, ldultkp)

        Dim lndiaatrint As Integer = 0
        If ldultkp = ldfecpag Then 'pagando al dia
        Else
            If ldultkp >= ldfecant And dfecval < ldfecpag Then
                lndiaatrint = 0
            Else
                If ldultkp < ldfecpag And dfecval >= ldfecpag Then
                    lndiaatrint = DateDiff(DateInterval.Day, ldfecpag, dfecval)
                Else
                    lndiaatrint = DateDiff(DateInterval.Day, ldultkp, dfecval) - 1
                End If

            End If

        End If
        If lndiaatrint < 0 Then
            lndiaatrint = 0
        End If
        Return lndiaatrint
    End Function

    'retorna el interes
    Function mxCalcInterest(ByVal p_salcap As Double) As Double
        Dim ldfecpro As Date
        Dim ldultpag As Date
        Dim ldant As Date
        Dim lntasa As Double
        Dim lndifdia As Double
        Dim filalineacre As DataRow
        Dim lntasint As Double
        Dim lntasefe As Double
        Dim lnintere As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double
        Dim ldfecha2 As Date

        ldfecpro = Me.pdfecval
        ldultpag = pdultpag
        ldant = ldfecpro
        For Each filalineacre In cre.Tables("LINEACRE").Rows
            lntasa = filalineacre("ntasint")
            If filalineacre("dfecvig") > ldultpag Then
                lnfecha1 = Me.pdfecval.ToOADate
                ldfecha2 = filalineacre("dfecvig")
                lnfecha2 = ldfecha2.ToOADate

                lndifdia = lnfecha1 - lnfecha2
                ldant = filalineacre("dfecvig")
            Else
                lnfecha1 = ldant.ToOADate
                lnfecha2 = ldultpag.ToOADate
                lndifdia = lnfecha1 - lnfecha2
            End If
            lntasint = lntasa / (gnperbas * 100)
            lntasefe = lntasint * lndifdia
            lnintere = lnintere + Math.Round((lntasefe * p_salcap), 2)
        Next
        Return lnintere
    End Function
    Function mxCalcInterestAnt(ByVal p_salcap As Double, ByVal dfecant As Date) As Double
        Dim ldfecpro As Date
        Dim ldultpag As Date
        Dim ldant As Date
        Dim lntasa As Double
        Dim lndifdia As Double
        Dim filalineacre As DataRow
        Dim lntasint As Double
        Dim lntasefe As Double
        Dim lnintere As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double
        Dim ldfecha2 As Date

        ldfecpro = dfecant
        ldultpag = pdultpag
        ldant = ldfecpro
        For Each filalineacre In cre.Tables("LINEACRE").Rows
            lntasa = filalineacre("ntasint")
            If filalineacre("dfecvig") > ldultpag Then
                lnfecha1 = Me.pdfecval.ToOADate
                ldfecha2 = filalineacre("dfecvig")
                lnfecha2 = ldfecha2.ToOADate

                lndifdia = lnfecha1 - lnfecha2
                ldant = filalineacre("dfecvig")
            Else
                lnfecha1 = ldant.ToOADate
                lnfecha2 = ldultpag.ToOADate
                lndifdia = lnfecha1 - lnfecha2
            End If
            lntasint = lntasa / (gnperbas * 100)
            lntasefe = lntasint * lndifdia
            lnintere = lnintere + Math.Round((lntasefe * p_salcap), 2)
        Next
        Return lnintere
    End Function

    Function mxCalcInterestFLAT(ByVal p_ccodcta As String, ByVal p_ncapdes As Double) As Double
        Dim ecredppg As New cCredppg
        Dim ldfecant As Date


        ldfecant = ecredppg.AnteriorFecha(p_ccodcta, Me.pdfecval) '  Me.pdfecoto
        Dim lnDifDias As Long
        lnDifDias = DateDiff(DateInterval.Day, ldfecant, Me.pdfecval)

        Dim lntasa As Double
        Dim filalineacre As DataRow
        Dim lntasint As Double = 0
        Dim lntasefe As Double = 0
        Dim lnintere As Double = 0

        For Each filalineacre In cre.Tables("LINEACRE").Rows
            lntasa = filalineacre("ntasint")

            lntasint = lntasa / (gnperbas * 100)
            lntasefe = lntasint * lnDifDias
            lnintere = lnintere + (lntasefe * p_ncapdes)
        Next
        Return lnintere


    End Function
    Function mxCalcInterestFLATAnt(ByVal p_ccodcta As String, ByVal p_ncapdes As Double, ByVal dfecant As Date) As Double
        Dim ecredppg As New cCredppg
        Dim ldfecant As Date


        ldfecant = ecredppg.AnteriorFecha(p_ccodcta, dfecant) '  Me.pdfecoto
        Dim lnDifDias As Long
        lnDifDias = DateDiff(DateInterval.Day, ldfecant, dfecant)

        Dim lntasa As Double
        Dim filalineacre As DataRow
        Dim lntasint As Double = 0
        Dim lntasefe As Double = 0
        Dim lnintere As Double = 0

        For Each filalineacre In cre.Tables("LINEACRE").Rows
            lntasa = filalineacre("ntasint")

            lntasint = lntasa / (gnperbas * 100)
            lntasefe = lntasint * lnDifDias
            lnintere = lnintere + (lntasefe * p_ncapdes)
        Next
        Return lnintere


    End Function
    'calcula la mora
    Function mxCalcMoratory() As Double
        Dim filacuotas As DataRow
        Dim lncapita1 As Double
        Dim ldfecpro1 As Date
        Dim cuentafila As Integer
        Dim cuentaf As Integer
        Dim ldfecven1 As Date
        Dim lndifdia As Double
        Dim lntasmor As Double
        Dim ldultpag1 As Date
        Dim lnintmor As Double
        Dim lnTasEfe1 As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double

        lnintmor = 0
        ldultpag1 = cre.Tables("creditos").Rows(0)("dUltPag")

        For Each filacuotas In cre.Tables("planpago").Rows
            If filacuotas("ctipope") <> "D" And filacuotas("nCapita") > filacuotas("nCapPag") Then
                If filacuotas("dfecven") >= Me.pdfecval Then
                    Exit For
                End If
                lncapita1 = filacuotas("nCapita") - filacuotas("nCapPag")
                ldfecpro1 = Me.pdfecval

                cuentafila = cre.Tables("lineacre").Rows.Count
                '  If cuentafila > 0 Then
                '  cuentafila = cuentafila - 1
                ' End If
                cuentaf = 0
                For i As Integer = cuentafila To 1 Step -1
                    If cre.Tables("creditos").Rows(0)("dultpag") > filacuotas("dFecVen") Then
                        ldfecven1 = cre.Tables("creditos").Rows(0)("dultpag")
                    Else
                        ldfecven1 = filacuotas("dfecven")
                    End If

                    If cre.Tables("lineacre").Rows(cuentaf)("dfecvig") > ldfecven1 Then
                        ldultpag1 = cre.Tables("lineacre").Rows(cuentaf)("dfecvig")
                    Else
                        ldultpag1 = ldfecven1
                    End If
                    lnfecha1 = ldfecpro1.ToOADate
                    lnfecha2 = ldultpag1.ToOADate
                    lndifdia = lnfecha1 - lnfecha2 'Double.Parse(ldfecpro1) - Double.Parse(ldultpag1)
                    'If lndifdia <= 2 Then
                    '    lndifdia = 0
                    'End If
                    lntasmor = cre.Tables("lineacre").Rows(cuentaf)("ntasmor") / (gnperbas * 100)
                    lnTasEfe1 = lntasmor * lndifdia
                    lnintmor = lnintmor + Math.Round((lnTasEfe1 * lncapita1), 2)
                    If cre.Tables("lineacre").Rows(cuentaf)("dfecvig") < filacuotas("dFecVen") Then
                        Exit For
                    End If
                    ldfecpro1 = ldultpag1
                    cuentaf = cuentaf + 1
                Next
            End If 'ctipope <> D
        Next 'filacuotas
        Return Math.Round(lnintmor, 2)
    End Function
    Function mxCalcMoratoryAnt(ByVal dfecant As Date) As Double
        Dim filacuotas As DataRow
        Dim lncapita1 As Double
        Dim ldfecpro1 As Date
        Dim cuentafila As Integer
        Dim cuentaf As Integer
        Dim ldfecven1 As Date
        Dim lndifdia As Double
        Dim lntasmor As Double
        Dim ldultpag1 As Date
        Dim lnintmor As Double
        Dim lnTasEfe1 As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double

        lnintmor = 0
        ldultpag1 = cre.Tables("creditos").Rows(0)("dUltPag")

        For Each filacuotas In cre.Tables("planpago").Rows
            If filacuotas("ctipope") <> "D" And filacuotas("nCapita") > filacuotas("nCapPag") Then
                If filacuotas("dfecven") >= dfecant Then
                    Exit For
                End If
                lncapita1 = filacuotas("nCapita") - filacuotas("nCapPag")
                ldfecpro1 = dfecant

                cuentafila = cre.Tables("lineacre").Rows.Count
              
                cuentaf = 0
                For i As Integer = cuentafila To 1 Step -1
                    If cre.Tables("creditos").Rows(0)("dultpag") > filacuotas("dFecVen") Then
                        ldfecven1 = cre.Tables("creditos").Rows(0)("dultpag")
                    Else
                        ldfecven1 = filacuotas("dfecven")
                    End If

                    If cre.Tables("lineacre").Rows(cuentaf)("dfecvig") > ldfecven1 Then
                        ldultpag1 = cre.Tables("lineacre").Rows(cuentaf)("dfecvig")
                    Else
                        ldultpag1 = ldfecven1
                    End If
                    lnfecha1 = ldfecpro1.ToOADate
                    lnfecha2 = ldultpag1.ToOADate
                    lndifdia = lnfecha1 - lnfecha2 'Double.Parse(ldfecpro1) - Double.Parse(ldultpag1)
                    
                    lntasmor = cre.Tables("lineacre").Rows(cuentaf)("ntasmor") / (gnperbas * 100)
                    lnTasEfe1 = lntasmor * lndifdia
                    lnintmor = lnintmor + Math.Round((lnTasEfe1 * lncapita1), 2)
                    If cre.Tables("lineacre").Rows(cuentaf)("dfecvig") < filacuotas("dFecVen") Then
                        Exit For
                    End If
                    ldfecpro1 = ldultpag1
                    cuentaf = cuentaf + 1
                Next
            End If 'ctipope <> D
        Next 'filacuotas
        Return Math.Round(lnintmor, 2)
    End Function
    'regresa los dias de atraso
    Function mxCalcDiaAtr() As Integer
        Dim lndiaatr1 As Integer
        Dim filacuotas As DataRow
        Dim lcpendiente As String
        Dim lnfecha1 As Date
        Dim lnfecha2 As Date
        lcpendiente = "E"
        lndiaatr1 = 0
        For Each filacuotas In cre.Tables("planpago").Rows
            If (Math.Round(filacuotas("ncapita"), 2) > Math.Round(filacuotas("ncappag"), 2) Or _
               Math.Round(filacuotas("nintere"), 2) > Math.Round(filacuotas("nintpag"), 2)) And filacuotas("ctipope") <> "D" Then
                lnfecha1 = Me.pdfecval2
                lnfecha2 = filacuotas("dfecven")
                lndiaatr1 = lnfecha1.ToOADate - lnfecha2.ToOADate
                If lndiaatr1 < 0 Then
                    lndiaatr1 = 0
                End If
                'lndiaatr1 = lnfecha1 - lnfecha2
                Exit For
            End If
        Next
        If lndiaatr1 = 0 Then
        Else
            'If lndiaatr1 <= Me._gnpergra Then
            '    lndiaatr1 = 0
            'End If

        End If
        Return lndiaatr1
    End Function

    Function mxCalcDiaAtrAnt(ByVal dfecant As Date) As Integer
        Dim lndiaatr1 As Integer
        Dim filacuotas As DataRow
        Dim lcpendiente As String
        Dim lnfecha1 As Date
        Dim lnfecha2 As Date
        lcpendiente = "E"
        lndiaatr1 = 0
        For Each filacuotas In cre.Tables("planpago").Rows
            If (Math.Round(filacuotas("ncapita"), 2) > Math.Round(filacuotas("ncappag"), 2) Or _
               Math.Round(filacuotas("nintere"), 2) > Math.Round(filacuotas("nintpag"), 2)) And filacuotas("ctipope") <> "D" Then
                lnfecha1 = dfecant
                lnfecha2 = filacuotas("dfecven")
                lndiaatr1 = lnfecha1.ToOADate - lnfecha2.ToOADate
                If lndiaatr1 < 0 Then
                    lndiaatr1 = 0
                End If

                Exit For
            End If
        Next
        If lndiaatr1 = 0 Then
        Else
           

        End If
        Return lndiaatr1
    End Function
    'numero de meses

    Function meses_desde_ultimo_pago(ByVal fecha1 As Date, ByVal fecha2 As Date)
        Dim n As Double
        Dim lnfecnum As Double
        lnfecnum = 0

        If fecha1.Year <> fecha2.Year Then
            n = fecha1.Year - fecha2.Year
            lnfecnum = (fecha1.Month + n * 12) - fecha2.Month
            If lnfecnum = 0 Then
                lnfecnum = 1
            End If
        Else
            lnfecnum = fecha1.Month - fecha2.Month
            If lnfecnum = 0 Then
                lnfecnum = 1
            End If
        End If
        Return lnfecnum
    End Function


    Function omcalcinterestINFORED() As Integer
        'incorpora al dataset las tablas del kardex y plan de pagos
        Dim lcnrolin As String
        Dim filakar As DataRow
        Dim filagas As DataRow
        Dim lncapdes As Double
        Dim lncappag As Double
        Dim lnintpag As Double
        Dim lnmorpag As Double
        Dim lnmonto As Double
        Dim lcestado As String
        Dim lngaspag As Double
        Dim ldultven As Date
        Dim filaplan As DataRow
        Dim lnSalCap As Double
        Dim ncuenta As Integer
        Dim lnCapCal As Double
        Dim lnDiaAtr As Integer
        Dim interes As Double
        Dim mora As Double
        Dim ldultpag As Date
        Dim lnahosim As Double
        Dim lnaporta As Double
        Dim lnsegdeu As Double
        Dim lncomision As Double = 0
        Dim lniva As Double = 0

        Dim clsppal As New class1
        Dim ecredppg As New cCredppg
        Dim lncapint As Double
        Dim lctipper As String
        Dim lndiasug As Integer
        Dim lsegdeu1 As Boolean
        Dim lccodlin As String
        Dim pdfecha As Date
        Dim pdfechareal As Date
        pdfecha = Me.pdfecval
        Dim lninteresesperado As Double 'interes esperado a la fecha en que paga
        lninteresesperado = 0
        Dim LDULTPAGINT As Date
        Dim lntotalinteres As Double  'interes total esperado en plan de pagos
        Dim lnintereind As Double  ' interes unitario flat a pagar en plan de pagos


        ldultpag = Me.gdultpag
        pdfechareal = Me.pdfecval
        cre.Tables.Clear()

        ldultpag = Me.gdultpag
        Dim okcre As Integer
        Dim lninteresflatpendiente As Double

        lninteresflatpendiente = 0

        Try
            '****************** TEMPORALMENTE ******************

            Me.pdfecval = Me.pdfecval ' fecha valor
            interes = 0
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
          
            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            lnSalCap = 0
            lnCapCal = 0
            mora = 0
            creditos1(pccodcta)
            'Verificar estado del credito a la fecha de calculo

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If cre.Tables("creditos").Rows.Count > 0 Then
                If IsDBNull(Me.pcestado) Then

                Else
                    cre.Tables("creditos").Rows(0)("cestado") = Me.pcestado
                End If
                lcnrolin = cre.Tables("creditos").Rows(0)("cnrolin")
                lncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                lctipper = cre.Tables("creditos").Rows(0)("ctipper")
                lndiasug = cre.Tables("creditos").Rows(0)("ndiasug")
                lsegdeu1 = cre.Tables("creditos").Rows(0)("lsegdeu")
                lccodlin = cre.Tables("creditos").Rows(0)("cCodlin")
                Me.pcflat = cre.Tables("creditos").Rows(0)("cFlat")
                'Calcula Cuota>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                lncapint = ecredppg.CapitalInteres(pccodcta)
                Dim pcaplcom As String
                If lccodlin.Substring(8, 2) = "06" Then
                    pcaplcom = "0"
                Else
                    pcaplcom = "1"
                End If
                If lsegdeu1 = True Then
                    pcaplcom = pcaplcom & "1"
                Else
                    pcaplcom = pcaplcom & "0"
                End If
                'Verificamos si aplica comision a pretamos personales
                If pcaplcom.Substring(0, 1) = "1" Then
                    lncomision = (lncapdes * (Me.porcomision / 100) * IIf(lctipper = "1", lndiasug, 31)) / Me.gnperbas
                Else
                    lncomision = 0
                End If
                'Verificamos si aplica comision a Seguro de Deuda
                ' If pcaplcom.Substring(1, 1) = "1" Then
                If lsegdeu1 = True Then
                    lnsegdeu = IIf(lctipper = "1", (lncapdes * Me.porsegdeu * (lndiasug / 30)), (lncapdes * Me.porsegdeu))
                Else
                    lnsegdeu = 0
                End If
                Me.pnmoncuo = utilNumeros.Redondear(lncapint + lncomision + lnsegdeu, 2)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If cre.Tables("creditos").Rows(0)("cestado") = "G" Then
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dfecvig")
                    Return 9
                    Exit Function
                End If

                'Me.pnmoncuo = cre.Tables("creditos").Rows(0)("nmoncuo")
                Me.pccodana = cre.Tables("creditos").Rows(0)("ccodana")
                'Para Creditos Saneados >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                Dim lccondic As String
                Dim ldfectra As Date
                lccondic = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("ccondic")), "N", cre.Tables("creditos").Rows(0)("ccondic"))
                ldfectra = IIf(IsDBNull(cre.Tables("creditos").Rows(0)("dfectra")), Me.gdfecsis, cre.Tables("creditos").Rows(0)("dfectra"))
                If lccondic = "S" Then
                    Me.pdfecval = ldfectra
                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If IsDBNull(cre.Tables("creditos").Rows(0)("dfecvig")) Then
                    Me.pdfecoto = #7/1/2000#
                Else
                    Me.pdfecoto = cre.Tables("creditos").Rows(0)("dfecvig")
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dfecvig")
                End If
                Me.pdfecven = cre.Tables("creditos").Rows(0)("dfecven")

                Me.cnrolin = lcnrolin
                planpago1(pccodcta)
                If lccondic = "S" Then
                    kardexINFORED(pccodcta, pdfechareal)
                Else
                    kardexINFORED(pccodcta, pdfecha)
                End If
                gastos1(pccodcta)
                linea1(lcnrolin)

                'calcula el interes a partir de las tablas anteriores ya llenas
                lncapdes = 0
                lncappag = 0
                lnintpag = 0
                lnmorpag = 0
                lnmonto = 0
                lngaspag = 0
                lnahosim = 0
                lnaporta = 0
                lnsegdeu = 0
                lncomision = 0
                lniva = 0
                'colocara una fecha mucho anterior
                'ya que los registros no vienen en orden y evaluara la fecha mayor


                If cre.Tables("kardex").Rows.Count <= 0 Then
                Else
                    For Each filakar In cre.Tables("kardex").Rows
                        If filakar("cestado") = " " Then
                            If filakar("cconcep") <> "CJ" Then
                                If filakar("cdescob") = "D" Then
                                    Me.pdfecvig = filakar("dfecpro")
                                    LDULTPAGINT = filakar("dfecpro")
                                End If
                                If filakar("cconcep") = "KP" And filakar("cdescob") = "D" Then
                                    lncapdes = lncapdes + filakar("nmonto")
                                    If filakar("dfecpro") > ldultpag Then
                                        ldultpag = Date.Parse(filakar("dfecpro"))
                                    End If
                                ElseIf filakar("cconcep") = "KP" And filakar("cdescob") = "C" Then
                                    lncappag = lncappag + filakar("nmonto")
                                    If filakar("dfecpro") > ldultpag Then
                                        ldultpag = filakar("dfecpro")
                                    End If
                                ElseIf filakar("cconcep") = "IN" Then
                                    lnintpag = lnintpag + filakar("nmonto")
                                    interes = interes + filakar("nmonto")
                                    LDULTPAGINT = filakar("dfecpro")
                                ElseIf filakar("cconcep") = "MO" Then
                                    lnmorpag = lnmorpag + filakar("nmonto")
                                    mora = mora + filakar("nmonto")
                                ElseIf filakar("cconcep") = "SD" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' Seguro de Deuda
                                    lnsegdeu = lnsegdeu + filakar("nmonto")
                                ElseIf (filakar("cconcep") = "CO" Or filakar("cconcep") = "OP") And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' manejo
                                    lncomision = lncomision + filakar("nmonto")
                                ElseIf filakar("cconcep") = "IV" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' iva
                                    lniva = lniva + filakar("nmonto")

                                    'verifica si pago algo de ahorros en la ultima fecha de pago
                                ElseIf filakar("cconcep") = "01" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then  ' ahorro simultaneo
                                    lnahosim = lnahosim + filakar("nmonto")

                                ElseIf filakar("cconcep") = "06" And filakar("dfecpro").month = Me.pdfecval.Month And filakar("dfecpro").year = Me.pdfecval.Year Then ' aportaciones
                                    lnaporta = lnaporta + filakar("nmonto")

                                ElseIf filakar("cconcep") = "CJ" Then

                                Else
                                    'gastos
                                    ncuenta = 0
                                    For Each filagas In cre.Tables("gastos").Rows
                                        If IsDBNull(filagas("cnrocuo")) Then
                                            filagas("cnrocuo") = "000"
                                        End If
                                        If IsDBNull(filakar("cnrocuo")) Then
                                            filakar("cnrocuo") = "000"
                                        End If
                                        If filagas("cnrocuo") = filakar("cnrocuo") And filagas("cdescob") = filakar("cdescob") And filagas("ctipgas") = filakar("cconcep") Then
                                            If filagas("nmongas") - filagas("nmonpag") < filakar("nmonto") Then
                                                lnmonto = filagas("nmongas") - filagas("nmonpag")
                                                lcestado = "P"
                                            Else
                                                lnmonto = filagas("nmongas")
                                                lcestado = "E"
                                            End If
                                            cre.Tables("gastos").Rows(ncuenta)("nmonpag") = lnmonto
                                            cre.Tables("gastos").Rows(ncuenta)("dfecpag") = filakar("dfecpro")
                                        End If
                                        ncuenta = ncuenta + 1
                                    Next
                                    lngaspag = lngaspag + filakar("nmonto")
                                End If
                            End If
                        End If
                    Next

                End If
                Me.pdultpag = ldultpag
                Me.ahosim = lnahosim
                Me.aporta = lnaporta

                'calcula fecha de ultimo pago cuando no abona intereses
                Dim lsi As Boolean
                Dim cuentafilas As Integer
                cuentafilas = cre.Tables("kardex").Rows.Count
                'esta sentencia da error porque no hay lineas
                '   If cuentafilas > 0 Then
                '  filakar.Delete()
                ' End If
                'evalua todo en busca de interes y si no haya evalua abajo
                For Each filakar In cre.Tables("kardex").Rows
                    If filakar("dfecpro") = ldultpag And filakar("cconcep") = "IN" Then
                        'llega hasta el final
                        lsi = True
                        Exit For
                    Else
                        lsi = False
                        Exit For
                    End If
                Next

                '*********** busca interes pendiente que se guardo en cclip **********
                lninteresflatpendiente = 0
                Dim lnflayfloy As Double = 0
                Dim lcclipag As String

                For Each filakar In cre.Tables("kardex").Rows
                    lcclipag = filakar("cclipag")

                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " Then
                            lninteresflatpendiente = Double.Parse(filakar("cclipag"))
                        End If
                        ' Exit For
                    End If
                Next

                'Verifica pagos despues de interes pendiente
                For Each filakar In cre.Tables("kardex").Rows
                    lcclipag = filakar("cclipag")
                    If filakar("dfecpro") = LDULTPAGINT And filakar("cconcep") = "IN" Then
                        If lcclipag.Trim <> "" And lcclipag <> " " And lcclipag <> "0" Then
                        Else
                            lnflayfloy = Double.Parse(filakar("nmonto"))
                            Exit For
                        End If
                    End If
                Next
                If lninteresflatpendiente <= 0 Then
                    lnflayfloy = 0
                End If

                'false significa no abono intereses

                'revisar esta parte ***** no completa ***********
                If lsi = False Then
                    'verifica si abono a capital en el ultimo pago
                    'y se va para atras de uno en uno
                    For Each filakar In cre.Tables("kardex").Rows
                        If filakar("dfecpro") = ldultpag And filakar("cconcep") = "KP" Then
                            If filakar("cconcep") = "KP" And filakar("cestado") = " " Then
                                ldultpag = filakar("dfecpro")
                            End If
                        End If
                    Next
                End If 'lsi ultimo pago no abona interese

                '***********
                'halla pagos a cuenta
                Dim lnintpen As Double
                Dim lnpagcta As Double
                Dim lncuentafilas As Integer
                Dim llfin As Boolean
                Dim i As Integer
                Dim lcnrodoc As String
                Dim iguardado As Integer

                lnintpen = 0
                lnpagcta = 0
                llfin = False

                lncuentafilas = cre.Tables("kardex").Rows.Count
                lncuentafilas = lncuentafilas - 1
                'For i = 0 To lncuentafilas Step -1
                For i = lncuentafilas To 0 Step -1

                    If cre.Tables("kardex").Rows(i)("cdescob") = "D" Then

                    Else
                        lcnrodoc = cre.Tables("kardex").Rows(i)("cnrodoc")
                        iguardado = i
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc

                            If cre.Tables("kardex").Rows(i)("cconcep") = "KP" Then
                                llfin = True
                                Exit For
                            End If
                            If i > 0 Then

                                i = i - 1
                            End If
                        Loop
                        If llfin Then
                            Exit For
                        End If
                        i = iguardado
                        Dim flagi As Integer
                        flagi = iguardado
                        Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc
                            If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Then
                                lnintpen = lnintpen + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                            ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Then
                                lnpagcta = lnpagcta + cre.Tables("kardex").Rows(i)("nmonto")
                                If flagi > 0 Then
                                    flagi = flagi - 1
                                End If
                            End If
                            If i > 0 Then
                                i = i - 1
                            End If
                        Loop
                        'i = flagi 
                        i = i + 1
                    End If
                Next
                lnintpag = lnintpag - lnintpen
                lnmorpag = lnmorpag - lnpagcta

                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapdes") = lncapdes
                cre.Tables("creditos").Rows(0)("ncappag") = lncappag
                cre.Tables("creditos").Rows(0)("nintpag") = lnintpag
                cre.Tables("creditos").Rows(0)("nmorpag") = lnmorpag
                'cre.Tables("kardex").Rows(0)("ngaspag") = lngaspag
                cre.Tables("creditos").Rows(0)("dultpag") = ldultpag
                cre.Tables("creditos").Rows(0)("nintpen") = lnintpen
                cre.Tables("creditos").Rows(0)("npagcta") = lnpagcta
                Dim lncuentaplan As Integer
                'halla teorico y cancela cuotas y fecha de vencimiento
                lncuentaplan = cre.Tables("planpago").Rows.Count
                lncuentaplan = lncuentaplan - 1
                ldultven = cre.Tables("planpago").Rows(lncuentaplan)("dfecven")
                ncuenta = 0





                For Each filaplan In cre.Tables("planpago").Rows
                    If filaplan("ctipope") = "D" Then
                        lnSalCap = lnSalCap + filaplan("ncapita")
                        cre.Tables("planpago").Rows(ncuenta)("cestado") = "E" 'pagado
                    Else
                        lnCapCal = lnCapCal + filaplan("ncapita")
                        If lnCapCal > lncappag Then
                            ldultven = filaplan("dfecven")
                            lncappag = filaplan("ncapita") - (lnCapCal - lncappag)
                            cre.Tables("planpago").Rows(ncuenta)("ncappag") = lncappag
                            cre.Tables("planpago").Rows(ncuenta)("cestado") = " " 'pendiente
                            Exit For
                        End If
                        cre.Tables("planpago").Rows(ncuenta)("cestado") = " "
                        cre.Tables("planpago").Rows(ncuenta)("ncappag") = cre.Tables("planpago").Rows(ncuenta)("ncapita")
                    End If
                    ncuenta = ncuenta + 1
                Next


                '** modificacion error 11-2002
                Dim lnintpagk1 As Double
                Dim lnintpagk As Double
                Dim ldfecven As Date
                Dim lnintmor As Double

                lnintpagk1 = cre.Tables("creditos").Rows(0)("nintpag")
                lnintpagk = cre.Tables("creditos").Rows(0)("nintpag")


                'encuentra capital teorico
                Dim ncuentatot As Integer
                Dim lnintere As Double
                lnCapCal = 0
                ncuenta = 0
                ncuentatot = cre.Tables("planpago").Rows.Count
                If ncuentatot > 0 Then
                    ncuentatot = ncuentatot - 1
                End If

                Do While cre.Tables("planpago").Rows(ncuenta)("dfecven") < gdfecsis And ncuenta <= ncuentatot
                    If cre.Tables("planpago").Rows(ncuenta)("ctipope") <> "D" And ncuenta <= ncuentatot Then
                        lnCapCal = lnCapCal + cre.Tables("planpago").Rows(ncuenta)("ncapita")
                    End If
                    ncuenta = ncuenta + 1
                    If ncuenta > ncuentatot Then
                        Exit Do
                    End If
                Loop
                ldfecven = cre.Tables("planpago").Rows(ncuentatot)("dfecven")

                '** calcula el interes >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<

                'determina interes esperado
                lninteresesperado = 0
                lntotalinteres = 0
                lnintereind = 0
                Dim fila As DataRow
                For Each fila In cre.Tables("planpago").Rows
                    If fila("dfecven") <= Me.pdfecval And fila("ctipope") <> "D" Then
                        lninteresesperado = lninteresesperado + filaplan("nintere")
                    End If
                    lntotalinteres = lntotalinteres + filaplan("nintere")
                    lnintereind = filaplan("nintere")
                Next


                '*********************   Nueva forma de cobrar interes flat ******************************
                Dim n As Double
                Dim lnfecnum2 As Double

                If Me.pdfecval.Year <> LDULTPAGINT.Year Then     ' pdultpag.Year 
                    n = Me.pdfecval.Year - Me.pdultpag.Year
                    lnfecnum2 = (Me.pdfecval.Month + n * 12) - LDULTPAGINT.Month 'pdultpag
                Else
                    lnfecnum2 = Me.pdfecval.Month - LDULTPAGINT.Month 'pdultpag
                End If
                '*************** Finaliza nueva forma de cobrar interes flat *****************************

                '** calcula el interes flat o sobre saldos
                If Me.pcflat = "F" Then
                    lnintere = lninteresesperado - lnintpag
                    If lnintere < 0 Then
                        lnintere = 0
                    End If
                    If lnintere <= 0 And lntotalinteres - lnintpag > 0 Then
                        lnintere = lnintereind
                    End If
                    lnintere = (lnintereind * lnfecnum2) + lninteresflatpendiente - lnflayfloy ' cambio ultimo   falta interes pendiente
                    lnintere = IIf(lnintere < 0, 0, lnintere)
                Else
                    lnintere = mxCalcInterest(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                    'lnintere = mxCalcIntereses()
                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
                lnintmor = mxCalcMoratory()

                If Me.pcflat.Trim = "F" Then
                    lnDiaAtr = mxCalcDiaAtr()
                Else
                    lnDiaAtr = mxCalcDiaAtr2()
                End If



                'actualiza creditos
                cre.Tables("creditos").Rows(0)("ncapcal") = lnCapCal
                cre.Tables("creditos").Rows(0)("nintcal") = lnintere + cre.Tables("creditos").Rows(0)("nintpag")
                cre.Tables("creditos").Rows(0)("nIntMor") = lnintmor + cre.Tables("creditos").Rows(0)("nmorpag")
                cre.Tables("creditos").Rows(0)("ndiaatr") = lnDiaAtr


                '**************actualiza las propiedades********************
                Me.pcnomcli = cre.Tables("creditos").Rows(0)("cnomcli")
                Me.pccodcli = cre.Tables("creditos").Rows(0)("ccodcli")
                Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")


                If (Me.pncapdes - Me.pncappag) <= 0 Then
                    Return 9
                End If
                ' DIRECTO DEL CALCULO
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>

                Me.pnsalint = cre.Tables("creditos").Rows(0)("nintcal") - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen")) ' lnintere 
                Me.pnsalmor = cre.Tables("creditos").Rows(0)("nintmor") - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta")) ' lnintmor
                If Me.pnsalint < 0 Then
                    Me.pnsalint = 0
                End If
                If Me.pnsalmor < 0 Then
                    Me.pnsalmor = 0
                End If
                '
                Me.pndiaatr = cre.Tables("creditos").Rows(0)("ndiaatr")
                If Me.pndiaatr < 0 Then
                    Me.pndiaatr = 0
                End If
                Me.pnintpag = cre.Tables("creditos").Rows(0)("nintpag")
                Me.pnintpen = cre.Tables("creditos").Rows(0)("nintpen")
                Me.pnintcal = cre.Tables("creditos").Rows(0)("nintcal")
                Me.pnmorpag = cre.Tables("creditos").Rows(0)("nmorpag")
                Me.pnpagcta = cre.Tables("creditos").Rows(0)("npagcta")
                Me.pnintmor = cre.Tables("creditos").Rows(0)("nintmor")
                Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")




                Dim lndeucap1 As Double
                'Dim fila As DataRow
                'evalue el pncapita, capital minimo necesario para pagar
                lndeucap1 = 0
                For Each fila In cre.Tables("planpago").Rows
                    'pdfechareal por Me.pdfecval
                    If fila("dfecven") < pdfechareal And fila("ctipope") <> "D" Then
                        lndeucap1 = lndeucap1 + (fila("ncapita") - fila("ncappag"))
                    End If
                Next
                Me.pndeucap = lndeucap1
                Return 1
            End If 'si existen creditos

            Return 0
        Catch
            Return 0
        End Try


    End Function

    Function InteresaAplicar(ByVal pcCodcta As String, ByVal pnmonto As Double) As Double
        'Obtener cuanto a pagado de capital y de interes
        Dim ecredkar As New cCredkar
        Dim ecredppg As New cCredppg
        Dim ds As New DataSet
        ds = ecredkar.KardexPagado2(pcCodcta)
        Dim lncappag As Double = 0
        Dim lnintpag As Double = 0

        Dim lncapapag As Double = 0
        Dim lnintapag As Double = 0


        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lncappag = ds.Tables(0).Rows(0)("nCapita")
            lnintpag = ds.Tables(0).Rows(0)("nintere")
        End If

        ds.Clear()

        ds = ecredppg.RecuperaPlanPagos(pcCodcta)

        Dim fila As DataRow
        Dim i As Integer = 0

        Dim lncapita As Double = 0
        Dim lnintere As Double = 0
        Dim lccuoint As String = "001"
        Dim lccuocap As String = "001"

        For Each fila In ds.Tables(0).Rows
            lncapita = ds.Tables(0).Rows(i)("ncapita")
            lnintere = ds.Tables(0).Rows(i)("nintere")

            If pnmonto = 0 Then
                Exit For
            End If

            If lnintpag > lnintere And lnintpag <> 0 Then
                lnintpag = lnintpag - lnintere
            Else
                lnintere = lnintere - lnintpag
                lnintpag = 0

                If pnmonto > lnintere Then
                    pnmonto = Math.Round(pnmonto - lnintere, 2)
                    lnintapag = lnintapag + lnintere

                Else
                    lnintapag = Math.Round(lnintapag + pnmonto, 2)
                    pnmonto = 0

                End If

            End If

            If lncappag > lncapita And lncappag <> 0 Then

                lncappag = lncappag - lncapita
            Else
                lncapita = lncapita - lncappag
                lncappag = 0

                If pnmonto > lncapita Then
                    pnmonto = Math.Round(pnmonto - lncapita, 2)
                    lncapapag = lncapapag + lncapita

                Else
                    lncapapag = Math.Round(lncapapag + pnmonto, 2)
                    pnmonto = 0


                End If

            End If



            i += 1
        Next

        Return Math.Round(lnintapag, 2)
    End Function

    'Interes a Aplicar por Cancelación

    Function interesCancelacion(ByVal cCodcta As String, ByVal dfecha As Date) As Double
        Dim ecredppg As New cCredppg
        Dim lnintereNO As Double = 0
        Dim lnintereSI As Double = 0
        Dim lnpenal As Double = 0

        Dim ecredkar As New cCredkar
        Dim ds As New DataSet
        ds = ecredkar.KardexPagado(cCodcta)
        Dim lnintpag As Double = 0
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnintpag = ds.Tables(0).Rows(0)("nintere")
        End If

        lnintereNO = ecredppg.InteresNovencido(cCodcta, dfecha)
        lnintereSI = ecredppg.Interesvencido(cCodcta, dfecha)
        lnpenal = Math.Round(lnintereNO * Me.porinteres, 2)

        Dim lnintere As Double = 0
        Dim lnintcal As Double = 0

        lnintere = lnintereSI - lnintpag

        If lnintere > 0 Then 'tiene interes vencido
            lnintcal = Math.Round(lnintere + lnpenal, 2)
        Else 'tiene interes anticipado
            If Math.Abs(lnintere) > lnpenal Then
                lnintcal = 0
            Else
                lnintcal = Math.Round(lnpenal - Math.Abs(lnintere), 2)
            End If
        End If
        Return lnintcal
    End Function


    ', ByVal dfecven As Date
    'Nueva Forma de Cobro Flat
    Public Function InteresFlatCobrar(ByVal ccodcta As String, ByVal pnmonpag As Decimal, ByVal dfecha As Date) As Decimal


        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lncappag As Decimal = 0
        Dim lnintpag As Decimal = 0
        Dim lnintere As Decimal = 0
        Dim lnmonpag As Decimal = pnmonpag
        'Dim pdfecven As Date = dfecven

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()

            Try

                command.Connection = conneccion


                'Suma el Iva como Interes para hacer el analisis
                command.CommandText = "Select cremcre.ccodcta, " & _
                                      "ncappag = isnull((select isnull(sum(nmonto),0) from credkar where credkar.ccodcta = cremcre.ccodcta " & _
                                      "and credkar.cestado<>'X' and credkar.cdescob='C' and credkar.cconcep ='KP'  group by credkar.ccodcta),0), " & _
                                      "nintpag =isnull((select isnull(sum(nmonto),0) from credkar where credkar.ccodcta = cremcre.ccodcta and " & _
                                      "credkar.cestado<>'X' and credkar.cdescob='C' and credkar.cconcep IN('IN','08') and (credkar.ccondic <> 'F' and " & _
                                      "credkar.ccondic <> 'H' ) group by credkar.ccodcta),0) " & _
                                      "From cremcre where cremcre.ccodcta ='" & ccodcta & "'"

                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Kardex")

                For Each fila0 As DataRow In ds.Tables("Kardex").Rows
                    lncappag = fila0("ncappag")
                    lnintpag = fila0("nintpag")
                Next

                command.CommandText = "Select dfecven , cnrocuo,  ncapita, nintere, 000000.00 as ncappag, 0000000.00 as nintpag, " & _
                                      "space(1) as  cflag From credppg where ccodcta ='" & ccodcta & "' and ctipope ='N'" & _
                                      "order by dfecven "
                '" and dfecven <='" & dfecven & "'" & _
                '"dfecven <= '" & dfecha & "'" & _

                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Plan")

                'Rutina para cubrir cuota a cuota
                Dim fila As DataRow
                For Each fila In ds.Tables("Plan").Rows
                    If lnintpag >= fila("nintere") Then
                        fila("nintpag") = fila("nintere")
                        lnintpag = lnintpag - fila("nintpag")
                        'Corregido por Error Reportado Mexico  29/10/2014
                        'fila("cflag") = "*"   
                    Else
                        fila("nintpag") = lnintpag
                        lnintpag = 0
                    End If
                    If lncappag >= fila("ncapita") Then
                        fila("ncappag") = fila("ncapita")
                        lncappag = lncappag - fila("ncappag")
                        fila("cflag") = "*"
                    Else
                        fila("ncappag") = lncappag
                        lncappag = 0
                    End If
                Next

                For Each fila In ds.Tables("Plan").Rows
                    If fila("cflag") <> "*" Then
                        If lnmonpag > Math.Round(fila("nintere") - fila("nintpag"), 2) Then
                            lnmonpag = lnmonpag - (Math.Round(fila("nintere") - fila("nintpag"), 2))
                            lnintere = lnintere + Math.Round(fila("nintere") - fila("nintpag"), 2)
                            fila("nintpag") = fila("nintere")
                        Else
                            fila("nintpag") = lnmonpag
                            lnintere = lnintere + lnmonpag
                            lnmonpag = 0
                        End If

                        If lnmonpag > Math.Round(fila("ncapita") - fila("ncappag"), 2) Then
                            lnmonpag = lnmonpag - (Math.Round(fila("ncapita") - fila("ncappag"), 2))
                            fila("ncappag") = fila("ncapita")
                        Else
                            fila("ncappag") = lnmonpag
                            lnmonpag = 0
                        End If
                        If lnmonpag = 0 Then 'Salta si es cero Modificado 06092014
                            Exit For
                        End If
                    End If
                Next


            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return lnintere

    End Function


    Public Function InteresFlatCobrar_PruebaX(ByVal ccodcta As String, ByVal pnmonpag As Decimal, ByVal dfecha As Date, _
                                              ByVal dsKar As DataSet) As Decimal


        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lncappag As Decimal = 0
        Dim lnintpag As Decimal = 0
        Dim lnintere As Decimal = 0
        Dim lniva_int As Double = 0
        Dim lnmonpag As Decimal = pnmonpag
        'Dim pdfecven As Date = dfecven

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()

            Try

                command.Connection = conneccion


                ''Suma el Iva como Interes para hacer el analisis
                'command.CommandText = "Select cremcre.ccodcta, " & _
                '                      "ncappag = isnull((select isnull(sum(nmonto),0) from credkar where credkar.ccodcta = cremcre.ccodcta " & _
                '                      "and credkar.cestado<>'X' and credkar.cdescob='C' and credkar.cconcep ='KP'  group by credkar.ccodcta),0), " & _
                '                      "nintpag =isnull((select isnull(sum(nmonto),0) from credkar where credkar.ccodcta = cremcre.ccodcta and " & _
                '                      "credkar.cestado<>'X' and credkar.cdescob='C' and credkar.cconcep IN('IN','08') and (credkar.ccondic <> 'F' and " & _
                '                      "credkar.ccondic <> 'H' ) group by credkar.ccodcta),0) " & _
                '                      "From cremcre where cremcre.ccodcta ='" & ccodcta & "'"

                'command.CommandType = CommandType.Text
                'myadapter.SelectCommand = command
                'myadapter.Fill(ds, "Kardex")

                'For Each fila0 As DataRow In ds.Tables("Kardex").Rows
                '    lncappag = fila0("ncappag")
                '    lnintpag = fila0("nintpag")
                'Next

                If Not IsDBNull(dsKar.Tables(0).Compute("sum(ncapita)", "cdescob = 'C'")) Then
                    lncappag = dsKar.Tables(0).Compute("sum(ncapita)", "cdescob = 'C'")
                End If
                If Not IsDBNull(dsKar.Tables(0).Compute("sum(niva_int)", "cdescob = 'C'")) Then
                    lniva_int = dsKar.Tables(0).Compute("sum(niva_int)", "cdescob = 'C'")
                End If
                If Not IsDBNull(dsKar.Tables(0).Compute("sum(nintere)", "cdescob = 'C'")) Then
                    lnintpag = dsKar.Tables(0).Compute("sum(nintere)", "cdescob = 'C'")
                End If

                lnintpag = lnintpag + lniva_int

                command.CommandText = "Select dfecven , cnrocuo,  ncapita, nintere, 000000.00 as ncappag, 0000000.00 as nintpag, " & _
                                      "space(1) as  cflag From credppg where ccodcta ='" & ccodcta & "' and ctipope ='N'" & _
                                      "order by dfecven "
                '" and dfecven <='" & dfecven & "'" & _
                '"dfecven <= '" & dfecha & "'" & _

                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Plan")

                'Rutina para cubrir cuota a cuota
                Dim fila As DataRow
                For Each fila In ds.Tables("Plan").Rows
                    If lnintpag >= fila("nintere") Then
                        fila("nintpag") = fila("nintere")
                        lnintpag = lnintpag - fila("nintpag")
                        'Corregido por Error Reportado Mexico  29/10/2014
                        'fila("cflag") = "*"   
                    Else
                        fila("nintpag") = lnintpag
                        lnintpag = 0
                    End If
                    If lncappag >= fila("ncapita") Then
                        fila("ncappag") = fila("ncapita")
                        lncappag = lncappag - fila("ncappag")
                        fila("cflag") = "*"
                    Else
                        fila("ncappag") = lncappag
                        lncappag = 0
                    End If
                Next

                For Each fila In ds.Tables("Plan").Rows
                    If fila("cflag") <> "*" Then
                        If lnmonpag > Math.Round(fila("nintere") - fila("nintpag"), 2) Then
                            lnmonpag = lnmonpag - (Math.Round(fila("nintere") - fila("nintpag"), 2))
                            lnintere = lnintere + Math.Round(fila("nintere") - fila("nintpag"), 2)
                            fila("nintpag") = fila("nintere")
                        Else
                            fila("nintpag") = lnmonpag
                            lnintere = lnintere + lnmonpag
                            lnmonpag = 0
                        End If

                        If lnmonpag > Math.Round(fila("ncapita") - fila("ncappag"), 2) Then
                            lnmonpag = lnmonpag - (Math.Round(fila("ncapita") - fila("ncappag"), 2))
                            fila("ncappag") = fila("ncapita")
                        Else
                            fila("ncappag") = lnmonpag
                            lnmonpag = 0
                        End If
                        If lnmonpag = 0 Then 'Salta si es cero Modificado 06092014
                            Exit For
                        End If
                    End If
                Next


            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return lnintere

    End Function


    Function mxCalcDiaAtr2() As Integer 'calculo de dias de atraso en base al capital
        Dim lndiaatr1 As Integer
        Dim filacuotas As DataRow
        Dim lcpendiente As String
        Dim lnfecha1 As Date
        Dim lnfecha2 As Date
        lcpendiente = "E"
        lndiaatr1 = 0
        'If Math.Round(filacuotas("ncapita") + filacuotas("nintere"), 2) > Math.Round(filacuotas("ncappag") + filacuotas("nintpag"), 2) And filacuotas("ctipope") <> "D" Then
        For Each filacuotas In cre.Tables("planpago").Rows
            If Math.Round(filacuotas("ncapita"), 2) > Math.Round(filacuotas("ncappag"), 2) And filacuotas("ctipope") <> "D" Then
                lnfecha1 = Me.pdfecval2
                lnfecha2 = filacuotas("dfecven")
                lndiaatr1 = lnfecha1.ToOADate - lnfecha2.ToOADate
                If lndiaatr1 < 0 Then
                    lndiaatr1 = 0
                End If
                'lndiaatr1 = lnfecha1 - lnfecha2
                Exit For
            End If
        Next
        If lndiaatr1 = 0 Then
        Else
            'If lndiaatr1 <= Me._gnpergra Then
            '    lndiaatr1 = 0
            'End If
        End If
        Return lndiaatr1
    End Function
    Function mxCalcDiaAtrAnt2(ByVal dfecant As Date) As Integer 'calculo de dias de atraso en base al capital
        Dim lndiaatr1 As Integer
        Dim filacuotas As DataRow
        Dim lcpendiente As String
        Dim lnfecha1 As Date
        Dim lnfecha2 As Date
        lcpendiente = "E"
        lndiaatr1 = 0
        For Each filacuotas In cre.Tables("planpago").Rows
            If Math.Round(filacuotas("ncapita"), 2) > Math.Round(filacuotas("ncappag"), 2) And filacuotas("ctipope") <> "D" Then
                lnfecha1 = dfecant
                lnfecha2 = filacuotas("dfecven")
                lndiaatr1 = lnfecha1.ToOADate - lnfecha2.ToOADate
                If lndiaatr1 < 0 Then
                    lndiaatr1 = 0
                End If

                Exit For
            End If
        Next
        If lndiaatr1 = 0 Then
        Else
            
        End If
        Return lndiaatr1
    End Function


    'Calculo que incluye calculo parcial para mas de un desembolso
    'retorna el interes
    'Function mxCalcIntereses() As Double
    '    Dim fila As DataRow
    '    Dim lnmonto As Double = 0
    '    Dim ldfecpro As Date = Me.pdfecval
    '    Dim ldfecval As Date = Me.pdfecval
    '    Dim lninteres As Double = 0
    '    Dim lnintpag As Double = 0
    '    Dim lnintere As Double = 0
    '    Dim lnsaldo As Double = 0
    '    Dim ldfecha As Date
    '    Dim k As Integer = 0
    '    For Each fila In cre.Tables("kardex").Rows
    '        If k = 0 Then
    '            ldfecha = fila("dfecpro")
    '            k += 1
    '        End If

    '        If fila("cDescob") = "D" Then
    '            If fila("cConcep") = "KP" Then
    '                lnmonto = fila("nmonto")
    '                ldfecpro = fila("dfecpro")
    '                'lninteres = lninteres + INTERESCalculado(lnmonto, ldfecpro)
    '                lninteres = lninteres + INTERESCalculado(lnsaldo, ldfecha, ldfecpro)
    '                lnsaldo = lnsaldo + lnmonto
    '                ldfecha = fila("dfecpro")
    '            End If
    '        Else
    '            If fila("cconcep") = "KP" Then
    '                lnmonto = fila("nmonto")
    '                lninteres = lninteres + INTERESCalculado(lnsaldo, ldfecha, ldfecpro)
    '                lnsaldo = lnsaldo - lnmonto
    '                ldfecha = fila("dfecpro")
    '            End If
    '        End If
    '        If fila("cConcep") = "IN" And fila("cDescob") = "C" Then
    '            lnintpag = lnintpag + fila("nmonto")
    '        End If


    '    Next
    '    'Calcula al dia
    '    ldfecpro = Me.pdfecval
    '    lninteres = lninteres + INTERESCalculado(lnsaldo, ldfecha, ldfecpro)

    '    lnintere = lninteres '- lnintpag
    '    Return lnintere
    'End Function
    'Function INTERESCalculado(ByVal nsaldo As Double, ByVal fecha As Date, ByVal ldfecsis As Date) As Double
    '    Dim ldfecpro As Date
    '    Dim ldultpag As Date
    '    Dim ldant As Date
    '    Dim lntasa As Double
    '    Dim lndifdia As Double
    '    Dim filalineacre As DataRow
    '    Dim lntasint As Double
    '    Dim lntasefe As Double
    '    Dim lnintere As Double
    '    Dim lnfecha1 As Double
    '    Dim lnfecha2 As Double
    '    Dim ldfecha2 As Date

    '    ldfecpro = ldfecsis 'Me.pdfecval
    '    ldant = fecha
    '    For Each filalineacre In cre.Tables("LINEACRE").Rows
    '        lntasa = filalineacre("ntasint")

    '        lnfecha1 = ldant.ToOADate
    '        lnfecha2 = ldfecpro.ToOADate
    '        lndifdia = lnfecha2 - lnfecha1

    '        lntasint = lntasa / (gnperbas * 100)
    '        lntasefe = lntasint * lndifdia
    '        lnintere = lnintere + (lntasefe * nsaldo)
    '    Next
    '    If lnintere < 0 Then
    '        lnintere = 0
    '    End If
    '    Return Math.Round(lnintere, 2)
    'End Function
    '-------------------------------------------------------------
    'retorna el interes
    Function mxCalcIntereses() As Double
        Dim fila As DataRow
        Dim lnmonto As Double = 0
        Dim ldfecpro As Date = Me.pdfecval
        Dim ldfecval As Date = Me.pdfecval
        Dim lninteres As Double = 0
        Dim lnintpag As Double = 0
        Dim lnintere As Double = 0
        Dim lnsaldo As Double = 0
        Dim ldfecha As Date
        Dim k As Integer = 0
        For Each fila In cre.Tables("kardex").Rows
            If k = 0 Then
                ldfecha = fila("dfecpro")
                k += 1
            End If

            If fila("cDescob") = "D" Then
                If fila("cConcep") = "KP" Then
                    lnmonto = fila("nmonto")
                    ldfecpro = fila("dfecpro")
                    'lninteres = lninteres + INTERESCalculado(lnmonto, ldfecpro)
                    lninteres = lninteres + INTERESCalculado(lnsaldo, ldfecha, ldfecpro)
                    lnsaldo = lnsaldo + lnmonto
                    ldfecha = fila("dfecpro")
                End If
            Else
                If fila("cconcep") = "KP" Then
                    lnmonto = fila("nmonto")
                    ldfecpro = fila("dfecpro")
                    lninteres = lninteres + INTERESCalculado(lnsaldo, ldfecha, ldfecpro)
                    lnsaldo = lnsaldo - lnmonto
                    ldfecha = fila("dfecpro")

                End If
            End If
            If fila("cConcep") = "IN" And fila("cDescob") = "C" Then
                lnintpag = lnintpag + fila("nmonto")
            End If


        Next
        'Calcula al dia
        ldfecha = ldfecpro
        ldfecpro = Me.pdfecval
        lninteres = lninteres + INTERESCalculado(lnsaldo, ldfecha, ldfecpro)

        lnintere = Math.Round(lninteres - lnintpag, 2)

      
        Return lnintere
    End Function
    Function INTERESCalculado(ByVal nsaldo As Double, ByVal fecha As Date, ByVal ldfecsis As Date) As Double
        Dim ldfecpro As Date
        Dim ldultpag As Date
        Dim ldant As Date
        Dim lntasa As Double
        Dim lndifdia As Double
        Dim filalineacre As DataRow
        Dim lntasint As Double
        Dim lntasefe As Double
        Dim lnintere As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double
        Dim ldfecha2 As Date

        ldfecpro = ldfecsis 'Me.pdfecval
        ldant = fecha
        For Each filalineacre In cre.Tables("LINEACRE").Rows
            lntasa = filalineacre("ntasint")

            lnfecha1 = ldant.ToOADate
            lnfecha2 = ldfecpro.ToOADate
            lndifdia = (lnfecha2 - lnfecha1)

            lntasint = lntasa / (gnperbas * 100)
            lntasefe = lntasint * lndifdia
            lnintere = lnintere + (lntasefe * nsaldo)
        Next
        If lnintere < 0 Then
            lnintere = 0
        End If
        Return Math.Round(lnintere, 2)
    End Function

    Function CalculaInteresFlat(ByVal cCodcta As String, ByVal dfecha As Date) As Double
        Dim ecredppg As New cCredppg
        Dim lnintereSI As Double = 0
        Dim lnpenal As Double = 0

        Dim ecredkar As New cCredkar
        Dim ds As New DataSet
        ds = ecredkar.KardexPagado2(cCodcta)
        Dim lnintpag As Double = 0
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnintpag = ds.Tables(0).Rows(0)("nintere")
        End If

        lnintereSI = ecredppg.Interesvencido(cCodcta, dfecha)

        Dim lnintere As Double = 0
        Dim lnintcal As Double = 0

        lnintere = lnintereSI - lnintpag

        If lnintere > 0 Then 'tiene interes vencido
            lnintcal = Math.Round(lnintere, 2)
        Else 'tiene interes anticipado
            lnintcal = 0
        End If
        Return lnintcal
    End Function


    Sub planpago1_(ByVal pccodcta As String, ByVal dfecha As Date)
        Try
            Dim cadenaactual As String
            Dim cadena As String
            cadenaactual = Me.cnnStr
            Dim ecreditos As New ccreditos
            cadena = ecreditos.CadenaDatos(dfecha)



            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            If cadena.Trim = cadenaactual.Trim Then
                SqlConnection1.ConnectionString = Me.cnnStr()
            Else
                SqlConnection1.ConnectionString = cadena
            End If

            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select credppg.* from credppg where ccodcta =" & "'" & pccodcta & "'" & "order by dfecven"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "planpago")



        Catch ex As Exception
            Try
                SqlConnection1.ConnectionString = Me.cnnStr()
                SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
                SqlSelectCommand1.CommandText = "Select credppg.* from credppg where ccodcta =" & "'" & pccodcta & "'" & "order by dfecven"
                SqlSelectCommand1.Connection = SqlConnection1
                SqlDataAdapter1.SelectCommand = SqlSelectCommand1
                SqlDataAdapter1.Fill(cre, "planpago")
            Catch ex2 As Exception


            End Try

        End Try

    End Sub



    Sub linea1_(ByVal pcnrolin As String, ByVal dfecha As Date)
        Try

            Dim cadenaactual As String
            Dim cadena As String
            cadenaactual = Me.cnnStr
            Dim ecreditos As New ccreditos
            cadena = ecreditos.CadenaDatos(dfecha)


            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()

            If cadena.Trim = cadenaactual.Trim Then
                SqlConnection1.ConnectionString = Me.cnnStr()
            Else
                SqlConnection1.ConnectionString = cadena
            End If


            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,7) = " & "Left(" & "'" & pcnrolin & "'" & ",7)  "
            'SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,5) = " & "Left(" & "'" & pcnrolin & "'" & ",5)  and dfecvig <= " & "'" & Me.gdfecsis & "'" & " order by cnrolin desc "
            'En caso de incluir el quiebre de tasa de interes
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "lineacre")

        Catch ex As Exception
            Try
                SqlConnection1.ConnectionString = Me.cnnStr()
                SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
                SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,7) = " & "Left(" & "'" & pcnrolin & "'" & ",7)  "
                SqlSelectCommand1.Connection = SqlConnection1
                SqlDataAdapter1.SelectCommand = SqlSelectCommand1
                SqlDataAdapter1.Fill(cre, "lineacre")
            Catch ex2 As Exception

            End Try

        End Try

    End Sub

    Sub lineamor1(ByVal pcnrolin As String, ByVal dfecha As Date)
        Try
            Dim cadenaactual As String
            Dim cadena As String
            cadenaactual = Me.cnnStr
            Dim ecreditos As New ccreditos
            cadena = ecreditos.CadenaDatos(dfecha)

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            If cadena.Trim = cadenaactual.Trim Then
                SqlConnection1.ConnectionString = Me.cnnStr()
            Else
                SqlConnection1.ConnectionString = cadena
            End If

            'SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,5) = " & "Left(" & "'" & pcnrolin & "'" & ",5)  and dfecvig < " & "'" & Me.gdfecsis & "'" & " order by cnrolin desc "
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "lineacremor")

        Catch ex As Exception
            Try
                SqlConnection1.ConnectionString = Me.cnnStr()
                SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
                SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,5) = " & "Left(" & "'" & pcnrolin & "'" & ",5)  and dfecvig < " & "'" & Me.gdfecsis & "'" & " order by cnrolin desc "
                SqlSelectCommand1.Connection = SqlConnection1
                SqlDataAdapter1.SelectCommand = SqlSelectCommand1
                SqlDataAdapter1.Fill(cre, "lineacremor")
            Catch ex2 As Exception

            End Try


        End Try

    End Sub

    Sub lineaQuiebre(ByVal pcnrolin As String, ByVal dfecha As Date)
        Try

            Dim cadenaactual As String
            Dim cadena As String
            cadenaactual = Me.cnnStr
            Dim ecreditos As New ccreditos
            cadena = ecreditos.CadenaDatos(dfecha)


            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()

            If cadena.Trim = cadenaactual.Trim Then
                SqlConnection1.ConnectionString = Me.cnnStr()
            Else
                SqlConnection1.ConnectionString = cadena
            End If


            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            'SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,7) = " & "Left(" & "'" & pcnrolin & "'" & ",7)  "
            SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,5) = " & "Left(" & "'" & pcnrolin & "'" & ",5)  and dfecmod <= " & "'" & Me.gdfecsis & "'" & " order by cnrolin desc "
            'En caso de incluir el quiebre de tasa de interes
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "lineacreQ")

        Catch ex As Exception
            Try
                SqlConnection1.ConnectionString = Me.cnnStr()
                SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
                SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,7) = " & "Left(" & "'" & pcnrolin & "'" & ",7)  "
                SqlSelectCommand1.Connection = SqlConnection1
                SqlDataAdapter1.SelectCommand = SqlSelectCommand1
                SqlDataAdapter1.Fill(cre, "lineacreQ")
            Catch ex2 As Exception

            End Try

        End Try

    End Sub

    Function mxCalcInterestQuiebre(ByVal p_salcap As Double) As Double
        Dim clsppal As New class1
        Dim ldfecpro As Date
        Dim ldultpag As Date
        Dim ldant As Date
        Dim lntasa As Double
        Dim lndifdia As Double
        Dim filalineacre As DataRow
        Dim lntasint As Double
        Dim lntasefe As Double
        Dim lnintere As Double
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double
        Dim ldfecha2 As Date


        ldfecpro = Me.pdfecval
        ldultpag = pdultpag
        ldant = ldfecpro

        Dim tmpultpag As Date
        Dim nyear As Integer = 0
        Dim Q As Integer = 0
        Dim fechyearant As Date
        Dim fechiniact As Date
        Dim lndia As Integer = 0
        Dim contador_dias As Integer = 1

        For Each filalineacre In cre.Tables("LINEACREQ").Rows
            lntasa = filalineacre("ntasint")

            ldultpag = IIf(filalineacre("dfecmod") > pdultpag, filalineacre("dfecmod"), pdultpag)
            lndifdia = DateDiff(DateInterval.Day, ldultpag, ldfecpro)

            tmpultpag = ldultpag
            lndia = 0
            If Year(ldultpag) < Year(ldfecpro) Then

                Do While Year(tmpultpag) < Year(ldfecpro)
                    fechyearant = Date.Parse("31/12/" & Year(tmpultpag).ToString)
                    lndifdia = DateDiff(DateInterval.Day, tmpultpag, fechyearant) + lndia

                    lntasint = lntasa / (clsppal.PeriodoBase(fechyearant.Year) * 100)
                    lntasefe = lntasint * lndifdia
                    lnintere = lnintere + Math.Round((lntasefe * p_salcap), 2)
                    '--Incrementa el año
                    tmpultpag = Date.Parse("01/01/" & (Year(tmpultpag) + 1).ToString)
                    lndia = 1
                Loop
                '**--Calcula interese desde el inicio del año actual hasta la fecha del sistema
                fechiniact = Date.Parse("01/01/" & Year(ldfecpro).ToString)
                lndifdia = DateDiff(DateInterval.Day, fechiniact, ldfecpro) + 1

                lntasint = lntasa / (clsppal.PeriodoBase(ldfecpro.Year) * 100)
                lntasefe = lntasint * lndifdia
                lnintere = lnintere + Math.Round((lntasefe * p_salcap), 2)

            Else
                lntasint = lntasa / (clsppal.PeriodoBase(ldfecpro.Year) * 100)
                lntasefe = lntasint * lndifdia
                lnintere = lnintere + Math.Round((lntasefe * p_salcap), 2)
            End If
            ldfecpro = ldultpag
        Next
        Return lnintere
    End Function


    Sub lineamorX(ByVal pcnrolin As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            ds.Clear()
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,5) = " & "Left(" & "'" & pcnrolin & "'" & ",5)  and dfecvig < " & "'" & Me.pdfecvig & "'" & " order by cnrolin desc "
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "lineacremor")

        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub
    
End Class
