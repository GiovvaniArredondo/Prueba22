Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
'calculos en la forma de pagos

Public Class ccalculomora

#Region "Propiedades"
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

    Private ldfecval As Date
    Public Property pdfecval() As Date
        Get
            pdfecval = ldfecval
        End Get
        Set(ByVal Value As Date)
            ldfecval = Value
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



    Sub creditos1()
        Try
            Dim LCESTADO As String
            LCESTADO = "F"



            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            If Me.pccodcta = "" Then
                SqlSelectCommand1.CommandText = "Select cremcre.*, climide.cnomcli, cretlin.ccodlin, cretlin.cdeslin, tabtusu.cnomusu from CREMCRE, CLIMIDE, CRETLIN,TABTUSU WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI AND CREMCRE.CNROLIN = CRETLIN.CNROLIN AND CREMCRE.CCODANA = TABTUSU.CCODUSU " & " AND CREMCRE.CESTADO = " & "'" & LCESTADO & "'"
            Else
                SqlSelectCommand1.CommandText = "Select cremcre.*, climide.cnomcli, cretlin.ccodlin, cretlin.cdeslin, tabtusu.cnomusu from CREMCRE, CLIMIDE, CRETLIN,TABTUSU WHERE CREMCRE.CCODCLI = CLIMIDE.CCODCLI AND CREMCRE.CNROLIN = CRETLIN.CNROLIN AND CREMCRE.CCODANA = TABTUSU.CCODUSU AND CREMCRE.CCODCTA = " & "'" & pccodcta & "'" & " "
            End If
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

    Sub kardex1(ByVal pccodcta As String)
        Try

            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            '            SqlConnection1.ConnectionString = "workstation id=MIRNA;packet size=4096;user id=sa;data source=MIRNA;persist security info=True;initial catalog=FUNDAMICRO;password=sa"
            SqlConnection1.ConnectionString = Me.cnnStr()

            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select credkar.* from credkar where credkar.ccodcta = " & "'" & pccodcta & "'" & "order by dfecpro"
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
            SqlConnection1.ConnectionString = Me.cnnStr()
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select cretlin.* from cretlin where left(cretlin.cnrolin,5) = " & "Left(" & "'" & pcnrolin & "'" & ",5)"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(cre, "lineacre")

        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub


    Function omcalcinterest() As Integer
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
        Dim filacreditosb As DataRow


        ldultpag = Me.gdultpag


        Dim mcremcre2 As New cCremcre
        Dim entidadcre2 As New cremcre
        '        entidadcre2.ccodcta = Me.pccodcta
        '        mcremcre2.ObtenerCremcre(entidadcre2)

        Try
            '****************** TEMPORALMENTE ******************

            Me.pdfecval = Me.pdfecval ' fecha valor
            interes = 0

            lnSalCap = 0
            lnCapCal = 0
            mora = 0

            creditos1()
            If cre.Tables("creditos").Rows.Count > 0 Then
                For Each filacreditosb In cre.Tables("creditos").Rows
                    Me.pccodcta = filacreditosb("ccodcta")
                    entidadcre2.ccodcta = Me.pccodcta
                    mcremcre2.ObtenerCremcre(entidadcre2)

                    lcnrolin = cre.Tables("creditos").Rows(0)("cnrolin")
                    planpago1(pccodcta)
                    kardex1(pccodcta)
                    gastos1(pccodcta)
                    linea1(lcnrolin)

                    'calcula el interes a partir de las tablas anteriores ya llenas
                    lncapdes = 0
                    lncappag = 0
                    lnintpag = 0
                    lnmorpag = 0
                    lnmonto = 0
                    lngaspag = 0
                    'colocara una fecha mucho anterior
                    'ya que los registros no vienen en orden y evaluara la fecha mayor


                    If cre.Tables("kardex").Rows.Count <= 0 Then
                    Else
                        For Each filakar In cre.Tables("kardex").Rows
                            If filakar("cconcep") <> "CJ" Then
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
                                ElseIf filakar("cconcep") = "MO" Then
                                    lnmorpag = lnmorpag + filakar("nmonto")
                                    mora = mora + filakar("nmonto")
                                ElseIf filakar("cconcep") = "CJ" Then

                                Else
                                    'gastos
                                    ncuenta = 0
                                    For Each filagas In cre.Tables("gastos").Rows
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
                        Next
                    End If
                    pdultpag = ldultpag

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
                    For i = 0 To lncuentafilas Step -1
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
                            Do While cre.Tables("kardex").Rows(i)("cnrodoc") = lcnrodoc
                                If cre.Tables("kardex").Rows(i)("cconcep") = "IN" Then
                                    lnintpen = lnintpen + cre.Tables("kardex").Rows(i)("nmonto")
                                ElseIf cre.Tables("kardex").Rows(i)("cconcep") = "MO" Then
                                    lnpagcta = lnpagcta + cre.Tables("kardex").Rows(i)("nmonto")
                                End If
                                If i > 0 Then
                                    i = i - 1
                                End If
                            Loop
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

                    'NO ESTA EN LA VERSION DE PROFIM
                    ' For Each filaplan In cre.Tables("planpago").Rows
                    'If filaplan("ctipope") <> "D" Then
                    'If lnintpagk1 > 0 Then
                    'If filaplan("nIntere") <= lnintpagk1 Then
                    'cre.Tables("creditos").Rows(0)("nintpag") = filaplan("nintere")
                    'Else
                    '   cre.Tables("creditos").Rows(0)("nintpag") = lnintpagk1
                    'End If
                    'End If

                    'End If
                    '   Next

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

                    '** calcula el interes
                    lnintere = mxCalcInterest(cre.Tables("creditos").Rows(0)("ncapdes") - cre.Tables("creditos").Rows(0)("ncappag"))
                    lnintmor = mxCalcMoratory()
                    lnDiaAtr = mxCalcDiaAtr()

                    'actualiza creditos
                    cre.Tables("creditos").Rows(0)("ncapcal") = lnCapCal
                    cre.Tables("creditos").Rows(0)("nintcal") = lnintere + cre.Tables("creditos").Rows(0)("nintpag") + interes
                    cre.Tables("creditos").Rows(0)("nIntMor") = lnintmor + cre.Tables("creditos").Rows(0)("nmorpag") + mora
                    cre.Tables("creditos").Rows(0)("ndiaatr") = lnDiaAtr


                    '**************actualiza las propiedades********************
                    '  Me.pcnomcli = cre.Tables("creditos").Rows(0)("cnomcli")
                    Me.pccodcli = cre.Tables("creditos").Rows(0)("ccodcli")
                    Me.pncapdes = cre.Tables("creditos").Rows(0)("ncapdes")
                    Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")
                    Me.pnsalint = cre.Tables("creditos").Rows(0)("nintcal") - (cre.Tables("creditos").Rows(0)("nintpag") + cre.Tables("creditos").Rows(0)("nintpen"))
                    Me.pnsalmor = cre.Tables("creditos").Rows(0)("nintmor") - (cre.Tables("creditos").Rows(0)("nmorpag") + cre.Tables("creditos").Rows(0)("npagcta"))
                    Me.pndiaatr = cre.Tables("creditos").Rows(0)("ndiaatr")
                    Me.pnintpag = cre.Tables("creditos").Rows(0)("nintpag")
                    Me.pnintpen = cre.Tables("creditos").Rows(0)("nintpen")
                    Me.pnintcal = cre.Tables("creditos").Rows(0)("nintcal")
                    Me.pnmorpag = cre.Tables("creditos").Rows(0)("nmorpag")
                    Me.pnpagcta = cre.Tables("creditos").Rows(0)("npagcta")
                    Me.pnintmor = cre.Tables("creditos").Rows(0)("nintmor")
                    Me.pdultpag = cre.Tables("creditos").Rows(0)("dultpag")
                    Me.pncappag = cre.Tables("creditos").Rows(0)("ncappag")

                    Dim lndeucap1 As Double
                    Dim fila As DataRow
                    'evalue el pncapita, capital minimo necesario para pagar
                    lndeucap1 = 0
                    For Each fila In cre.Tables("planpago").Rows
                        If fila("dfecven") <= Me.pdfecval And fila("ctipope") <> "D" Then
                            lndeucap1 = lndeucap1 + (fila("ncapita") - fila("ncappag"))
                        End If
                    Next
                    Me.pndeucap = lndeucap1
                    '                    Return 1


                    'en este apartado actualiza cremcre maestra
                    entidadcre2.dultpag = Me.pdultpag
                    entidadcre2.nintpen = Me.pnintpen
                    entidadcre2.nintpag = Me.pnintpag
                    entidadcre2.nintmor = Me.pnintmor
                    entidadcre2.nmorpag = Me.pnmorpag
                    entidadcre2.nintcal = Me.pnintcal
                    entidadcre2.npagcta = Me.pnpagcta
                    entidadcre2.ncappag = Me.pncappag
                    entidadcre2.ndiaatr = Me.pndiaatr
                    mcremcre2.ActualizarCremcre(entidadcre2)


                Next filacreditosb

            End If 'si existen creditos


            Return 0
        Catch
            Return 0
        End Try

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
            lnintere = lnintere + (lntasefe * p_salcap)
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
                    lntasmor = cre.Tables("lineacre").Rows(cuentaf)("ntasmor") / (gnperbas * 100)
                    lnTasEfe1 = lntasmor * lndifdia
                    lnintmor = lnintmor + (lnTasEfe1 * lncapita1)
                    If cre.Tables("lineacre").Rows(cuentaf)("dfecvig") < filacuotas("dFecVen") Then
                        Exit For
                    End If
                    ldfecpro1 = ldultpag1
                    cuentaf = cuentaf + 1
                Next
            End If 'ctipope <> D
        Next 'filacuotas
        Return lnintmor
    End Function

    'regresa los dias de atraso
    Function mxCalcDiaAtr() As Integer
        Dim lndiaatr1 As Integer
        Dim filacuotas As DataRow
        Dim lcpendiente As String
        Dim lnfecha1 As Double
        Dim lnfecha2 As Double
        lcpendiente = "E"
        lndiaatr1 = 0
        For Each filacuotas In cre.Tables("planpago").Rows
            '            If filacuotas("ctipope") = lcpendiente Then
            If filacuotas("ncapita") > filacuotas("ncappag") And filacuotas("ctipope") <> "D" Then
                lnfecha1 = Me.pdfecval.ToOADate
                lnfecha2 = filacuotas("dfecven").ToOADate
                lndiaatr1 = lnfecha1 - lnfecha2

                Exit For
            End If
        Next
        Return lndiaatr1

    End Function

End Class














