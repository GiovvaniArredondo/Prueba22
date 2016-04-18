Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Imports System.IO

Public Class class1

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
    'Codigo de Rechazo
    Private _cCodRec As String
    Public Property cCodRec() As String
        Get
            Return _cCodRec
        End Get
        Set(ByVal Value As String)
            _cCodRec = Value
        End Set
    End Property
    'Codigo de Actividad
    Private _cCodact As String
    Public Property cCodact() As String
        Get
            Return _cCodact
        End Get
        Set(ByVal Value As String)
            _cCodact = Value
        End Set
    End Property
    'Numero de linea
    Private _cNrolin As String
    Public Property cNrolin() As String
        Get
            Return _cNrolin
        End Get
        Set(ByVal Value As String)
            _cNrolin = Value
        End Set
    End Property

    'Codigo de Fuente de ingreso
    Private _cCodfue As String
    Public Property cCodfue() As String
        Get
            Return _cCodfue
        End Get
        Set(ByVal Value As String)
            _cCodfue = Value
        End Set
    End Property

    'Fecha de Desembolso
    Private _dFecDes As Date
    Public Property dFecDes() As Date
        Get
            Return _dFecDes
        End Get
        Set(ByVal Value As Date)
            _dFecDes = Value
        End Set
    End Property

    Private _dFecpri As Date
    Public Property dfecpri() As Date
        Get
            Return _dFecpri
        End Get
        Set(ByVal Value As Date)
            _dFecpri = Value
        End Set
    End Property
    'Fecha de cobro de desembolso
    Private _dFeccob As Date
    Public Property dfeccob() As Date
        Get
            Return _dFeccob
        End Get
        Set(ByVal Value As Date)
            _dFeccob = Value
        End Set
    End Property


    'Fecha de Aprobacion
    Private _dFecApr As Date
    Public Property dFecApr() As Date
        Get
            Return _dFecApr
        End Get
        Set(ByVal Value As Date)
            _dFecApr = Value
        End Set
    End Property

    'Fecha de Vencimiento
    Private _dFecVen As Date
    Public Property dFecVen() As Date
        Get
            Return _dFecVen
        End Get
        Set(ByVal Value As Date)
            _dFecVen = Value
        End Set
    End Property
    'Monto Desembolsado
    Private _nMonDes As Double
    Public Property nMonDes() As Double
        Get
            Return _nMonDes
        End Get
        Set(ByVal Value As Double)
            _nMonDes = Value
        End Set
    End Property

    'nmoncuo
    Private _nmoncuo As Double
    Public Property nmoncuo() As Double
        Get
            Return _nmoncuo
        End Get
        Set(ByVal Value As Double)
            _nmoncuo = Value
        End Set
    End Property
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Private _pncominf As Double
    Public Property pncominf() As Double
        Get
            Return _pncominf
        End Get
        Set(ByVal Value As Double)
            _pncominf = Value
        End Set
    End Property
    Private _pncomsup As Double
    Public Property pncomsup() As Double
        Get
            Return _pncomsup
        End Get
        Set(ByVal Value As Double)
            _pncomsup = Value
        End Set
    End Property
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    'Tasa de Interes
    Private _nTasInt As Double
    Public Property nTasInt() As Double
        Get
            Return _nTasInt
        End Get
        Set(ByVal Value As Double)
            _nTasInt = Value
        End Set
    End Property
    'Tipo de Periodo
    Private _cCodFor As String
    Public Property cCodFor() As String
        Get
            Return _cCodFor
        End Get
        Set(ByVal Value As String)
            _cCodFor = Value
        End Set
    End Property
    'Dias del Periodo
    Private _nPerDia As Integer
    Public Property nPerDia() As Integer
        Get
            Return _nPerDia
        End Get
        Set(ByVal Value As Integer)
            _nPerDia = Value
        End Set
    End Property
    'Numero de Cuotas
    Private _nNroCuo As Integer
    Public Property nNroCuo() As Integer
        Get
            Return _nNroCuo
        End Get
        Set(ByVal Value As Integer)
            _nNroCuo = Value
        End Set
    End Property
    Private _nNroCuo0 As Integer
    Public Property nNroCuo0() As Integer
        Get
            Return _nNroCuo0
        End Get
        Set(ByVal Value As Integer)
            _nNroCuo0 = Value
        End Set
    End Property

    'Tipo de Cuota
    Private _cTipCuo As String
    Public Property cTipCuo() As String
        Get
            Return _cTipCuo
        End Get
        Set(ByVal Value As String)
            _cTipCuo = Value
        End Set
    End Property
    'Dias de Gracia
    Private _nDiaGra As Integer
    Public Property nDiaGra() As Integer
        Get
            Return _nDiaGra
        End Get
        Set(ByVal Value As Integer)
            _nDiaGra = Value
        End Set
    End Property
    'Tipo de Calculo
    Private _cTipCal As String
    Public Property cTipCal() As String
        Get
            Return _cTipCal
        End Get
        Set(ByVal Value As String)
            _cTipCal = Value
        End Set
    End Property
    'Tipo de Estado
    Private _cTipEst As String
    Public Property cTipEst() As String
        Get
            Return _cTipEst
        End Get
        Set(ByVal Value As String)
            _cTipEst = Value
        End Set
    End Property
    'Tipo de Periodo
    Private _nTipPer As String
    Public Property nTipPer() As Integer
        Get
            Return _nTipPer
        End Get
        Set(ByVal Value As Integer)
            _nTipPer = Value
        End Set
    End Property
    Private _lFlat As Boolean
    Public Property lFlat() As Boolean
        Get
            Return _lFlat
        End Get
        Set(ByVal Value As Boolean)
            _lFlat = Value
        End Set
    End Property
    Private _lRedo As Boolean
    Public Property lRedo() As Boolean
        Get
            Return _lRedo
        End Get
        Set(ByVal Value As Boolean)
            _lRedo = Value
        End Set
    End Property
    Private _lliva As Boolean
    Public Property lliva() As Boolean
        Get
            Return _lliva
        End Get
        Set(ByVal Value As Boolean)
            _lliva = Value
        End Set
    End Property

    'Tipo Flat
    Private _cFlat As String
    Public Property cFlat() As String
        Get
            Return _cFlat
        End Get
        Set(ByVal Value As String)
            _cFlat = Value
        End Set
    End Property
    Private _gntasaiva As Double
    Public Property gntasaiva() As Double
        Get
            Return _gntasaiva
        End Get
        Set(ByVal Value As Double)
            _gntasaiva = Value
        End Set
    End Property


    Private _gnperbas As Integer
    Public Property gnperbas() As Integer
        Get
            Return vCnn
        End Get
        Set(ByVal Value As Integer)
            vCnn = Value
        End Set
    End Property
    'Cuenta de Credito
    Private _pcCodCre As String
    Public Property pcCodCre() As String
        Get
            Return _pcCodCre
        End Get
        Set(ByVal Value As String)
            _pcCodCre = Value
        End Set
    End Property
    Private _pcCodCre1 As String
    Public Property pcCodCre1() As String
        Get
            Return _pcCodCre1
        End Get
        Set(ByVal Value As String)
            _pcCodCre1 = Value
        End Set
    End Property
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    'Meses
    Private _nMeses As Integer
    Public Property nMeses() As Integer
        Get
            Return _nMeses
        End Get
        Set(ByVal Value As Integer)
            _nMeses = Value
        End Set
    End Property
    Private _cnnStr As New String(AppSettings("cnnString"))


    Protected Overridable Property cnnStr() As String
        Get
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property


    Private _gnporseg As Double
    Public Property gnporseg() As Double
        Get
            Return _gnporseg
        End Get
        Set(ByVal Value As Double)
            _gnporseg = Value
        End Set
    End Property


    Private _gnporres As Double
    Public Property gnporres() As Double
        Get
            Return _gnporres
        End Get
        Set(ByVal Value As Double)
            _gnporres = Value
        End Set
    End Property


    Private _gnpordan As Double
    Public Property gnpordan() As Double
        Get
            Return _gnpordan
        End Get
        Set(ByVal Value As Double)
            _gnpordan = Value
        End Set
    End Property

    Private _gnportal As Double
    Public Property gnportal() As Double
        Get
            Return _gnportal
        End Get
        Set(ByVal Value As Double)
            _gnportal = Value
        End Set
    End Property

    Private _gncosind As Double
    Public Property gncosind() As Double
        Get
            Return _gncosind
        End Get
        Set(ByVal Value As Double)
            _gncosind = Value
        End Set
    End Property


    Private _gncosdir As Double
    Public Property gncosdir() As Double
        Get
            Return _gncosdir
        End Get
        Set(ByVal Value As Double)
            _gncosdir = Value
        End Set
    End Property

    Private _gnprima As Double
    Public Property gnprima() As Double
        Get
            Return _gnprima
        End Get
        Set(ByVal Value As Double)
            _gnprima = Value
        End Set
    End Property


    Private _gnsubcidio As Double
    Public Property gnsubcidio() As Double
        Get
            Return _gnsubcidio
        End Get
        Set(ByVal Value As Double)
            _gnsubcidio = Value
        End Set
    End Property


    Private _gnmoncuo As Double
    Public Property gnmoncuo() As Double
        Get
            Return _gnmoncuo
        End Get
        Set(ByVal Value As Double)
            _gnmoncuo = Value
        End Set
    End Property


    Private _gntotcosind As Double
    Public Property gntotcosind() As Double
        Get
            Return _gntotcosind
        End Get
        Set(ByVal Value As Double)
            _gntotcosind = Value
        End Set
    End Property

    'agrega para ver si se cobran los seguros
    Private _lsegdeu As Boolean
    Public Property lsegdeu() As Boolean
        Get
            Return _lsegdeu
        End Get
        Set(ByVal Value As Boolean)
            _lsegdeu = Value
        End Set
    End Property

    Private _lsegdan As Boolean
    Public Property lsegdan() As Boolean
        Get
            Return _lsegdan
        End Get
        Set(ByVal Value As Boolean)
            _lsegdan = Value
        End Set
    End Property

    Private _lreserva As Boolean
    Public Property lreserva() As Boolean
        Get
            Return _lreserva
        End Get
        Set(ByVal Value As Boolean)
            _lreserva = Value
        End Set
    End Property

    Private _ltalona As Boolean
    Public Property ltalona() As Boolean
        Get
            Return _ltalona
        End Get
        Set(ByVal Value As Boolean)
            _ltalona = Value
        End Set
    End Property


    Private _ladmon1 As Boolean
    Public Property ladmon1() As Boolean
        Get
            Return _ladmon1
        End Get
        Set(ByVal Value As Boolean)
            _ladmon1 = Value
        End Set
    End Property

    Private _gdfeccuo As Date
    Public Property gdfeccuo() As Date
        Get
            Return _gdfeccuo
        End Get
        Set(ByVal Value As Date)
            _gdfeccuo = Value
        End Set
    End Property


    'Nuevo


    'Saldo de Capital a Refinanciar
    Private _pnSalCap As Double
    Public Property pnSalCap() As Double
        Get
            Return _pnSalCap
        End Get
        Set(ByVal Value As Double)
            _pnSalCap = Value
        End Set
    End Property

    'Saldo de Intereses a Refinanciar
    Private _pnSalInt As Double
    Public Property pnSalInt() As Double
        Get
            Return _pnSalInt
        End Get
        Set(ByVal Value As Double)
            _pnSalInt = Value
        End Set
    End Property

    'Saldo de Int. Moratorio a Refinanciar
    Private _pnSalMor As Double
    Public Property pnSalMor() As Double
        Get
            Return _pnSalMor
        End Get
        Set(ByVal Value As Double)
            _pnSalMor = Value
        End Set
    End Property

    'Prestamo a Refinanciar
    Private _pcCodRef As String
    Public Property pcCodRef() As String
        Get
            Return _pcCodRef
        End Get
        Set(ByVal Value As String)
            _pcCodRef = Value
        End Set
    End Property

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private _pcTabGasx As New DataSet
    Public Property pcTabGasx() As DataSet
        Get
            Return _pcTabGasx
        End Get
        Set(ByVal Value As DataSet)
            _pcTabGasx = Value
        End Set
    End Property

    Private _pctabgas As DataTable
    Public Property pctabgas() As DataTable
        Get
            Return _pctabgas
        End Get
        Set(ByVal Value As DataTable)
            _pctabgas = Value
        End Set
    End Property

    Private _usuario_aprobacion As String
    Public Property usuario_aprobacion() As String
        Get
            Return _usuario_aprobacion
        End Get
        Set(ByVal Value As String)
            _usuario_aprobacion = Value
        End Set
    End Property

    Private _codigo_nivel_aprobacion As String
    Public Property codigo_nivel_aprobacion() As String
        Get
            Return _codigo_nivel_aprobacion
        End Get
        Set(ByVal Value As String)
            _codigo_nivel_aprobacion = Value
        End Set
    End Property


    Private _pcCodusu As String
    Public Property pcCodUsu() As String
        Get
            Return _pcCodusu
        End Get
        Set(ByVal Value As String)
            _pcCodusu = Value
        End Set
    End Property

    'Fecha de sistemas
    Private _dFecsis As Date
    Public Property dFecsis() As Date
        Get
            Return _dFecsis
        End Get
        Set(ByVal Value As Date)
            _dFecsis = Value
        End Set
    End Property

    Private _cTipgas As String
    Public Property cTipGas() As String
        Get
            Return _cTipgas
        End Get
        Set(ByVal Value As String)
            _cTipgas = Value
        End Set
    End Property

    Private _cNroCuo As String
    Public Property cNrocuo() As String
        Get
            Return _cNroCuo
        End Get
        Set(ByVal Value As String)
            _cNroCuo = Value
        End Set
    End Property

    Private _cDesCob As String
    Public Property cDesCob() As String
        Get
            Return _cDesCob
        End Get
        Set(ByVal Value As String)
            _cDesCob = Value
        End Set
    End Property

    Private _nMongas As Double
    Public Property nMonGas() As Double
        Get
            Return _nMongas
        End Get
        Set(ByVal Value As Double)
            _nMongas = Value
        End Set
    End Property

    Private _cNomChq As String
    Public Property cNomChq() As String
        Get
            Return _cNomChq
        End Get
        Set(ByVal Value As String)
            _cNomChq = Value
        End Set
    End Property

    Private _pnmoncuo As Double
    Public Property pnmonCuo() As Double
        Get
            Return _pnmoncuo
        End Get
        Set(ByVal Value As Double)
            _pnmoncuo = Value
        End Set
    End Property

    Private _pctipcon As String
    Public Property pctipcon() As String
        Get
            Return _pctipcon
        End Get
        Set(ByVal Value As String)
            _pctipcon = Value
        End Set
    End Property

    Private _pnComtra As Double
    Public Property pnComtra() As Double
        Get
            Return _pnComtra
        End Get
        Set(ByVal Value As Double)
            _pnComtra = Value
        End Set
    End Property

    Private _pnSegVm As Decimal
    Public Property pnSegVm() As Decimal
        Get
            Return _pnSegVm
        End Get
        Set(ByVal Value As Decimal)
            _pnSegVm = Value
        End Set
    End Property


    Private _pnComPer As Double
    Private _pnSegDeu As Double
    Private _pniva As Double
    Public Property pniva() As Double
        Get
            Return _pniva
        End Get
        Set(ByVal Value As Double)
            _pniva = Value
        End Set
    End Property


    Public Property pnComPer() As Double
        Get
            Return _pnComPer
        End Get
        Set(ByVal Value As Double)
            _pnComPer = Value
        End Set
    End Property

    Public Property pnSegDeu() As Double
        Get
            Return _pnSegDeu
        End Get
        Set(ByVal Value As Double)
            _pnSegDeu = Value
        End Set
    End Property

    Private _lsegvid As Boolean
    Public Property lsegvid() As Boolean
        Get
            Return _lsegvid
        End Get
        Set(ByVal Value As Boolean)
            _lsegvid = Value
        End Set
    End Property

    Private _cfreccap As String
    Public Property cfreccap() As String
        Get
            Return _cfreccap
        End Get
        Set(ByVal Value As String)
            _cfreccap = Value
        End Set
    End Property

    Private _cfrecint As String
    Public Property cfrecint() As String
        Get
            Return _cfrecint
        End Get
        Set(ByVal Value As String)
            _cfrecint = Value
        End Set
    End Property
    Private _ccodana As String
    Public Property ccodana() As String
        Get
            Return _ccodana
        End Get
        Set(ByVal Value As String)
            _ccodana = Value
        End Set
    End Property

    Private _cCapacidad As String
    Public Property cCapacidad() As String
        Get
            Return _cCapacidad
        End Get
        Set(ByVal Value As String)
            _cCapacidad = Value
        End Set
    End Property
    Private _canalisis As String
    Public Property canalisis() As String
        Get
            Return _canalisis
        End Get
        Set(ByVal Value As String)
            _canalisis = Value
        End Set
    End Property
    Private _ngastos1 As Double
    Public Property ngastos1() As Double
        Get
            Return _ngastos1
        End Get
        Set(ByVal value As Double)
            _ngastos1 = value
        End Set
    End Property
    Private _dfecha As Date
    Public Property dfecha() As Date
        Get
            Return _dfecha
        End Get
        Set(ByVal value As Date)
            _dfecha = value
        End Set
    End Property

    Private _cDescre As String
    Public Property cDescre() As String
        Get
            Return _cDescre
        End Get
        Set(ByVal Value As String)
            _cDescre = Value
        End Set
    End Property

    Private _cprograma As String
    Public Property cprograma() As String
        Get
            Return _cprograma
        End Get
        Set(ByVal Value As String)
            _cprograma = Value
        End Set
    End Property
    Private _csececo As String
    Public Property csececo() As String
        Get
            Return _csececo
        End Get
        Set(ByVal Value As String)
            _csececo = Value
        End Set
    End Property
    Private _ctipgar As String
    Public Property ctipgar() As String
        Get
            Return _ctipgar
        End Get
        Set(ByVal Value As String)
            _ctipgar = Value
        End Set
    End Property

    Private _cacta As String
    Public Property cacta() As String
        Get
            Return _cacta
        End Get
        Set(ByVal Value As String)
            _cacta = Value
        End Set
    End Property
    Private _cresolucion As String
    Public Property cresolucion() As String
        Get
            Return _cresolucion
        End Get
        Set(ByVal Value As String)
            _cresolucion = Value
        End Set
    End Property
    Private _pcyears As String
    Public Property pcyears() As String
        Get
            Return _pcyears
        End Get
        Set(ByVal value As String)
            _pcyears = value
        End Set
    End Property

    Private _pcnomser As String
    Public Property pcnomser() As String
        Get
            Return _pcnomser
        End Get
        Set(ByVal value As String)
            _pcnomser = value
        End Set
    End Property
    Private _cfactura As String
    Public Property cfactura() As String
        Get
            Return _cfactura
        End Get
        Set(ByVal value As String)
            _cfactura = value
        End Set
    End Property
    Private _cctabco As String
    Public Property cctabco() As String
        Get
            Return _cctabco
        End Get
        Set(ByVal value As String)
            _cctabco = value
        End Set
    End Property
    'Fin



    ' FUNCIONES Y PROCEDIMIENTOS ***************
    Public Function Transac(ByVal Parametro1 As String, ByVal Parametro2 As String, ByVal Parametro3 As String, ByVal Parametro4 As String, ByVal parametro5 As String, ByVal parametro6 As String) As String
        Dim x As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String

        i = 0

        '--------------------------------------------------------
        'Proceso que parte cada uno de los parametros enviados
        '--------------------------------------------------------

        'Halla numero de parametros

        For x = 0 To Parametro1.Length - 1
            If Parametro1.Substring(x, 1) = "," Then
                i += 1
            End If
        Next

        'Declara arreglo segun cantidad de parametros
        Dim campos(i) As String
        Dim TipoD(i) As String
        Dim Param(i) As String



        '----------------------------------
        'Sacando los campos
        '----------------------------------

        i = 0
        j = 0
        k = 1

        For x = 0 To Parametro1.Length - 1
            If Parametro1.Substring(x, 1) = "," Then
                campos(k) = Parametro1.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        campo1 = campos(1)
        campo2 = campos(2)
        '   campo3 = campos(3)

        '----------------------------------
        'Sacando los Tipos
        '----------------------------------
        i = 0
        j = 0
        k = 1

        For x = 0 To Parametro2.Length - 1
            If Parametro2.Substring(x, 1) = "," Then
                TipoD(k) = Parametro2.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        '  campo1 = TipoD(1)
        '  campo2 = TipoD(2)
        '  campo3 = TipoD(3)
        '----------------------------------
        'Sacando los parametros
        '----------------------------------
        i = 0
        j = 0
        k = 1

        For x = 0 To Parametro3.Length - 1
            If Parametro3.Substring(x, 1) = "," Then
                Param(k) = Parametro3.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        ' campo1 = Param(1)
        ' campo2 = Param(2)
        ' campo3 = Param(3)
        '--------------------------------------------------------
        'Fin
        '--------------------------------------------------------


        'Evalua el tipo de Transacc Insert, Update, Delete, Select
        Dim codTransac As String
        Dim Valores As String
        Dim Values As Object

        k = campos.Length - 1

        Select Case parametro5
            Case Is = "S"
                For i = 1 To campos.Length - 1
                    If i = k Then
                        codTransac = codTransac & campos(i)
                    Else
                        codTransac = codTransac & campos(i) & ","
                    End If
                Next
                codTransac = "SELECT" & " " & codTransac & " " & "FROM" & " " & Parametro4 & " " & parametro6
            Case Is = "I"
                For i = 1 To campos.Length - 1
                    If TipoD(i) = "I" Then
                        Param(i) = Integer.Parse(Param(i))
                    ElseIf TipoD(i) = "D" Then
                        Param(i) = Double.Parse(Param(i))
                    ElseIf TipoD(i) = "F" Then
                        Param(i) = CDate(Param(i))
                    ElseIf TipoD(i) = "B" Then
                        Param(i) = Boolean.Parse(Param(i))
                        If Param(i) = "False" Then
                            Param(i) = 0
                        Else
                            Param(i) = 1
                        End If
                    End If
                    If i = k Then
                        Valores = Valores & campos(i)
                        Values = Values & "'" & Param(i) & "'"
                    Else
                        Valores = Valores & campos(i) & ","
                        Values = Values & "'" & Param(i) & "'" & ","
                    End If
                Next
                codTransac = "INSERT INTO" & " " & Parametro4 & " " & "(" & Valores & ")" & " " & "Values" & " " & "(" & Values & ")"

            Case Is = "U"
                For i = 1 To campos.Length - 1
                    If TipoD(i) = "I" Then
                        Param(i) = Integer.Parse(Param(i))
                    ElseIf TipoD(i) = "D" Then
                        Param(i) = Double.Parse(Param(i))
                    ElseIf TipoD(i) = "F" Then
                        Param(i) = CDate(Param(i).Substring(0, 8))
                    ElseIf TipoD(i) = "B" Then
                        Param(i) = Boolean.Parse(Param(i))
                    End If
                    If i = k Then
                        Valores = Valores & " " & campos(i) & "=" & "'" & Param(i) & "'"
                    Else
                        Valores = Valores & " " & campos(i) & "=" & "'" & Param(i) & "'" & ","
                    End If

                Next
                codTransac = "UPDATE" & " " & Parametro4 & " " & "SET" & " " & Valores & " " & parametro6
            Case Is = "D"
                codTransac = "DELETE" & " " & "From" & " " & Parametro4 & " " & parametro6
        End Select

        Return codTransac

    End Function

    '--------------------------------------------------------------------
    'Funcion que genera cualquier selec, solo se le envia el transac
    '--------------------------------------------------------------------


    Public Function ResulSelect(ByVal Parametro As String) As DataSet


        Try
            myconnection = New SqlConnection(Me.cnnStr)

            sql = Parametro

            mycommand = New SqlDataAdapter(sql, myconnection)

            mycommand.Fill(ds, "Resultado")


        Catch SqlException As Exception
            '    MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")

        End Try

        Return ds

    End Function
    '--------------------------------------------------------------------
    'Funcion que genera cualquier Insert,Update,Delete de cualquier tabla, solo se le 
    'envia el transac
    '--------------------------------------------------------------------

    Public Sub Insert(ByVal Parameter1 As String)


        Try
            myconnection = New SqlConnection(Me.cnnStr)

            sql = Parameter1

            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.ExecuteNonQuery()
            myconnection.Close()


        Catch SqlException As Exception
            '   MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try


    End Sub



    '*******************MIRNA ******************
    ' funciones y procedimientos generados por mirna




    ' Funcion que verifica
    ' si ya existe nombre de variable en tabla
    Public Function verifica_variables(ByVal paplicacion As String, ByVal pnombre As String) As String
        Dim cnombre As String
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select * from TABTVAR where cnomvar = " & "'" & pnombre & "'" & " AND ccodapl = " & "'" & paplicacion & "'"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "VARIABLES")
            cnombre = ds.Tables("VARIABLES").Rows(0)("cnomvar")
            cnombre = cnombre.Trim
            Return cnombre

        Catch SqlException As Exception
            ' EL RESULTADO DEL SELEC SE EVALUA EN LA INTERFASE
            cnombre = Nothing
            Return cnombre
        End Try

    End Function

    ' procedimiento para eliminar variables
    Public Sub eliminar_variables(ByVal paplica As String, ByVal pcnomvar As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Delete From TABTVAR Where cnomvar = '" & pcnomvar & "'" & "and ccodapl = " & "'" & paplica & "'"
            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString())
        End Try
    End Sub

    ' procedimiento para modificar variables

    Public Sub modificar_variables(ByVal pccodapl As String, ByVal pcnomvar As String, ByVal pcconvar As String, ByVal pcdesvar As String, ByVal pctipvar As String, ByVal pccodusu As String, ByVal pcarini As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Update TABTVAR Set  cconvar ='" & pcconvar _
                    & "',cdesvar ='" & pcdesvar _
                    & "',ctipvar ='" & pctipvar _
                    & "',ccodusu ='" & pccodusu _
                    & "',lcarini ='" & pcarini _
                    & "' Where cnomvar = '" & pcnomvar & "'"

            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub

    '****************************************************
    '********* FUNCIONES Y PROCEDIMIENTOS ***************
    '********* PARA FRMTABLASCOD ************************
    '****************************************************

    ' funcion que genera correlativo de ccodtab a adicionar
    ' esta función sera accesada solo por el administrador

    Public Function correlativo_tablas() As String
        Dim correla_M As String
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select max(ccodtab) as codigo from TABTTAB"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "Resultado")
            correla_M = ds.Tables("Resultado").Rows(0)("codigo")
            ds.Tables("Resultado").Rows.Clear()

        Catch SqlException As Exception
            'la excepcion se da cuando esta vacio y me interesa
            ' que siempre retorne 
            correla_M = "000"
            Return correla_M
        End Try
        Return correla_M
    End Function

    'genera un codigo unico de tablas
    ' esto permite que la tabttab no se repita
    Public Function genera_unico_tablas()
        Dim correla_M As String
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select MAX(IDCODIGO) as codigo from TABTTAB"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "Resultado")
            correla_M = ds.Tables("Resultado").Rows(0)("codigo")
            ds.Tables("Resultado").Rows.Clear()

        Catch SqlException As Exception
            'la excepcion se da cuando esta vacio y me interesa
            ' que siempre retorne 
            correla_M = "000000"
            Return correla_M
        End Try
        Return correla_M

    End Function


    ' procedimiento para eliminar datos en tablas de codigo
    Public Sub eliminar_tablas_codigo(ByVal pidcodigo As String, ByVal pccodtab As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Delete From TABTTAB Where ccodtab = '" & pccodtab & "'"
            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            ' MsgBox("Exception: " + SqlException.ToString())
        End Try
    End Sub

    'elimina solo un registro a la vez
    'pidcodigo es el valor de ccodigo
    Public Sub eliminar_tablas_codigo2(ByVal pidcodigo As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Delete From TABTTAB Where ccodigo = '" & pidcodigo & "'" & " AND CTIPREG = '1'"
            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString())
        End Try
    End Sub


    ' procedimiento para modificar datos en tablas de codigo

    Public Sub modificar_tablas_codigo(ByVal pidcodigo As String, ByVal pccodtab As String, ByVal pctipreg As String, ByVal pccodigo As String, ByVal pcdescri As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Update TABTTAB Set  ccodigo ='" & pccodigo _
                    & "',cdescri ='" & pcdescri _
                    & "' Where ccodtab = '" & pccodtab & "'" & " AND idcodigo = " & "'" & pidcodigo & "'"

            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub

    ' procedimiento para modificar datos en tablas de codigo
    ' ccodtab y ccodigo

    Public Sub modificar_tablas_codigo2(ByVal pccodtab As String, ByVal pccodigo As String, ByVal pcorden As String, ByVal pcdeslar As String, ByVal pcdescor As String, ByVal pnnumero As Integer, ByVal pdfecha As Date, ByVal pccontenido As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Update TABTTAB Set  corden ='" & pcorden _
                    & "',cdescri ='" & pcdeslar _
                    & "',cstrtab ='" & pcdescor _
                    & "',nnumtab = '" & pnnumero _
                    & "',dfectab = '" & pdfecha _
                    & "',maditab = '" & pccontenido _
                    & "' Where ccodtab = '" & pccodtab & "'" & " AND ccodigo = " & "'" & pccodigo & "'"

            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub



    ' *** MODIFICA ACTIVIDADES
    Public Sub modificar_actividades(ByVal pccodigo As String, ByVal pcdescrip As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Update TABTCIU Set  cdescri ='" & pcdescrip _
                    & "' Where ccodigo = '" & pccodigo & "'"

            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub

    ' *** MODIFICA PROFESIONES
    Public Sub modificar_profesiones(ByVal pccodigo As String, ByVal pcdescrip As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Update TABTPRF Set  cdescri ='" & pcdescrip _
                    & "' Where ccodigo = '" & pccodigo & "'"

            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString())
        End Try

    End Sub
    '** ELIMINA ACTIVIDADES
    Public Sub eliminar_actividades(ByVal pccodigo As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Delete From TABTCIU Where ccodigo = '" & pccodigo & "'"
            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString())
        End Try
    End Sub

    '** ELIMINA PROFESIONES
    Public Sub eliminar_profesiones(ByVal pccodigo As String)
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Delete From TABTPRF Where ccodigo = '" & pccodigo & "'"
            Dim myCommand As New SqlCommand(sql, myconnection)
            myconnection.Open()
            myCommand.ExecuteNonQuery()
            myconnection.Close()
        Catch SqlException As Exception
            Debug.WriteLine("Excepcion: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString())
        End Try
    End Sub


    Public Function verifica_actividades(ByVal pccodigo As String) As String
        Dim correla_M As String
        Try
            ds.Tables("Resultado").Rows.Clear()
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select ccodigo from TABTCIU where ccodigo = " & "'" & pccodigo & "'"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "Resultado")
            correla_M = ds.Tables("Resultado").Rows(0)("ccodigo")
            ds.Tables("Resultado").Rows.Clear()

        Catch SqlException As Exception
            'la excepcion se da cuando esta vacio y me interesa
            ' que siempre retorne 
            correla_M = "*"
            Return correla_M
        End Try
        Return correla_M
    End Function


    Public Function correlativo_profesiones() As String
        Dim correla_M As String
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select max(ccodigo) as codigo from TABTPRF"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "Resultado")
            correla_M = ds.Tables("Resultado").Rows(0)("codigo")
            ds.Tables("Resultado").Rows.Clear()

        Catch SqlException As Exception
            'la excepcion se da cuando esta vacio y me interesa
            ' que siempre retorne 
            correla_M = "000000"
            Return correla_M
        End Try
        Return correla_M
    End Function

    ' procedimientos agregados por mirna
    '***********  II PARTE *************

    Public Function busca_gastos(ByVal pcnrolin As String) As DataSet
        Dim lctipgas_M As String
        Dim lctipo_M As String
        lctipgas_M = "008"
        lctipo_M = "1"
        Try
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select cretgas.ctipgas as Tipo_Gasto, cretlin.cdeslin as Linea, tabttab.cdescri as Tipo_gas, cretgas.ccodope as Operac, cretgas.nmonpor as Monto, cretgas.nincost as Porcen from CRETLIN, CRETGAS,TABTTAB where cretlin.cnrolin = cretgas.cnrolin and  " & "cretlin.cnrolin = " & "'" & pcnrolin & "'" & "and tabttab.ccodtab = " & "'" & lctipgas_M & "'" & " and tabttab.ctipreg =" & "'" & lctipo_M & "'" & "and cretgas.ctipgas = tabttab.ccodigo"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "Resultado")
            Return ds

        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
    End Function


    'clase que genera los gastos iniciales y los deposita en planpago
    'dataset desconectado.
    'ojo ver matriz va al final
    Public Sub fxgastosiniciales(ByRef p_cplapag As DataTable, ByVal p_atabgas As DataTable, ByVal p_cfilret As String, ByVal p_cnorref As String, ByVal p_cuomens As Double, ByVal p_lredo As Boolean, ByVal pladmon As Boolean)
        'la matriz a p_atabgas ya no sera matriz
        'ya  que para ser enviada por parametro debe ser unidimensional
        'sera una tabla

        Dim i As Integer
        Dim fila As DataRow
        Dim ncuenta As Integer
        Dim ctipope As String
        Dim lcampos1 As String
        Dim factor As Double = 0
        Dim lncaptot_liq As Double = 0
        Dim ltipos1 As String
        Dim lcfilgas As DataTable
        Dim lntotcuo As Integer
        Dim lncaptot As Decimal
        Dim lninttot As Decimal
        Dim lncuotot As Decimal
        Dim lngasto As Decimal
        Dim nrocuo As String
        Dim lnafecta As Decimal 'si afecta el capital ,interes,etc
        Dim dr_M As DataRow
        Dim n As Integer
        Dim fila1 As DataRow
        Dim tmpplan As DataTable

        Dim lntotgasdes As Decimal
        Dim lntotgascuo As Decimal
        'hace una copia del datatable
        'y limpia datatable original para insertar nuevamente


        tmpplan = p_cplapag.Copy()

        p_cplapag.Clear()

        lntotgasdes = 0
        lntotgascuo = 0
        lncaptot = 0
        lninttot = 0
        lncuotot = 0


        i = tmpplan.Rows.Count 'cuenta el numero de registros
        Dim laVector(i, 4) As String
        'llena lavector
        ncuenta = 1
        Dim lnsaldo As Decimal = 0
        Dim lncapdes As Decimal = 0
        For Each fila In tmpplan.Rows
            ctipope = fila("ctipope")
            If ctipope = "D" Or ctipope = "X" Then
                lnsaldo = lnsaldo + fila("ncapita")
            Else
                'lnsaldo = lnsaldo - fila("ncapita")
                laVector(ncuenta, 1) = fila("ncapita")
                laVector(ncuenta, 2) = fila("nintere")
                lncaptot = lncaptot + fila("ncapita")
                lninttot = lninttot + fila("nintere")
                lncuotot = lncuotot + lncaptot + lninttot
                ncuenta = ncuenta + 1
            End If
            laVector(ncuenta, 4) = lnsaldo
        Next

        lncapdes = lncaptot

        'crea temporal de gastos lcfilgas
        lcampos1 = "ctipgas, ccodope, cnrocuo, ncapita, nintere, ngasto, cdescob,nsegdeu,"
        ltipos1 = "S,S,S,D,D,D,S,D,"
        lcfilgas = creadatasetdesconec(lcampos1, ltipos1, "gas")
        '        lntotcuo = laVector.Length
        lntotcuo = tmpplan.Rows.Count - 1 'se quita el desembolso

        Dim l_atabgas2 As String
        Dim l_atabgas3 As Decimal
        Dim l_atabgas1 As String
        Dim cuenta1 As Integer

        cuenta1 = 0
        For Each fila1 In p_atabgas.Rows
            l_atabgas2 = fila1(2) 'codigo de operacion
            l_atabgas2 = l_atabgas2.Trim
            l_atabgas1 = fila1(1) 'tipo de gasto
            l_atabgas3 = Double.Parse(fila1(3)) 'monto o porcentaje
            'todas las cuotas, porcen, capital,interes de la cuota,etc
            If l_atabgas2 = "121" Or l_atabgas2 = "122" Or l_atabgas2 = "123" Or l_atabgas2 = "124" Or l_atabgas2 = "125" Or l_atabgas2 = "126" Then
                For i = 1 To lntotcuo
                    nrocuo = i.ToString
                    If Mid(l_atabgas2, 3, 1) = "1" Then 'capital
                        lnafecta = laVector(i, 1)
                    ElseIf Mid(l_atabgas2, 3, 1) = "2" Then 'total cuota
                        lnafecta = laVector(i, 3)
                    ElseIf Mid(l_atabgas2, 3, 1) = "3" Then 'interes
                        lnafecta = laVector(i, 2)
                    ElseIf Mid(l_atabgas2, 3, 1) = "4" Then 'total aprobado
                        lnafecta = lncaptot
                    ElseIf Mid(l_atabgas2, 3, 1) = "5" Then 'sobre saldo
                        lnafecta = laVector(i, 4)
                    ElseIf Mid(l_atabgas2, 3, 1) = "6" Then 'distribuidas en cuotas
                        lnafecta = lncaptot
                    End If

                    'Verificamos si afecta a la distribucion de las cuotas
                    If Mid(l_atabgas2, 3, 1) = "6" Then 'Distribuye en las cuotas
                        lngasto = Math.Round(lnafecta * (l_atabgas3 / 100) / lntotcuo, 2)
                    Else
                        lngasto = lnafecta * (l_atabgas3 / 100)
                    End If

                    'actualiza tabla temporal
                    dr_M = lcfilgas.NewRow()
                    dr_M("ctipgas") = l_atabgas1
                    dr_M("ccodope") = l_atabgas2
                    dr_M("cnrocuo") = nrocuo
                    dr_M("ncapita") = laVector(i, 1)
                    dr_M("nintere") = laVector(i, 2)
                    'If l_atabgas1 = "03" Then
                    '    dr_M("nsegdeu") = lngasto
                    'Else
                    dr_M("ngasto") = lngasto
                    'End If

                    dr_M("cdescob") = "C"
                    lcfilgas.Rows.Add(dr_M)
                    lntotgascuo = lntotgascuo + lngasto

                Next


                'todas las cuotas, monto, capital cuota, etc
            ElseIf l_atabgas2 = "111" Or l_atabgas2 = "112" Or l_atabgas2 = "113" Or l_atabgas2 = "114" Or l_atabgas2 = "115" Or l_atabgas2 = "116" Then
                If Mid(l_atabgas2, 3, 1) = "6" Then 'Distribuye en las cuotas
                    lngasto = Math.Round(l_atabgas3 / lntotcuo, 2)
                Else
                    lngasto = l_atabgas3
                End If


                For i = 1 To lntotcuo
                    nrocuo = i.ToString
                    dr_M = lcfilgas.NewRow()
                    dr_M("ctipgas") = l_atabgas1
                    dr_M("ccodope") = l_atabgas2
                    dr_M("cnrocuo") = nrocuo
                    dr_M("ncapita") = laVector(i, 1)
                    dr_M("nintere") = laVector(i, 2)
                    'If l_atabgas1 = "03" Then
                    '    dr_M("nsegdeu") = lngasto
                    'Else
                    dr_M("ngasto") = lngasto
                    'End If

                    '                    dr_M("ngasto") = lngasto
                    dr_M("cdescob") = "C"
                    lcfilgas.Rows.Add(dr_M)
                    lntotgascuo = lntotgascuo + lngasto

                Next

                'afectar el en desembolso por un porcentaje
            ElseIf l_atabgas2 = "221" Or l_atabgas2 = "222" Or l_atabgas2 = "223" Or l_atabgas2 = "224" Or l_atabgas2 = "225" Then
                nrocuo = i.ToString


                'Modificación Especial Manejo de Comisión Sumada al Monto Dsembolsado    Mexico .... 2014
                If l_atabgas1 = "01" Then
                    'lncaptot = lncaptot + (lncaptot * (l_atabgas3 / 100))
                    lncapdes = Math.Round(lncapdes, 2)
                    factor = (l_atabgas3 / 100) + 1
                    lncaptot_liq = lncapdes / factor
                    lncaptot_liq = Math.Round(lncaptot_liq, 2)
                    lngasto = lncapdes - lncaptot_liq
                Else
                    lngasto = lncapdes * (l_atabgas3 / 100)
                End If

                'If l_atabgas1 = "03" Then

                'End If
                'actualiza tabla temporal
                i = 1

                dr_M = lcfilgas.NewRow()
                dr_M("ctipgas") = l_atabgas1
                dr_M("ccodope") = l_atabgas2
                dr_M("cnrocuo") = nrocuo
                dr_M("ncapita") = laVector(i, 1)
                dr_M("nintere") = laVector(i, 2)
                dr_M("ngasto") = lngasto
                dr_M("cdescob") = "D"
                lcfilgas.Rows.Add(dr_M)
                lntotgasdes = lntotgasdes + lngasto

                'monto fijo en el desembolso
            ElseIf l_atabgas2 = "211" Or l_atabgas2 = "212" Or l_atabgas2 = "213" Or l_atabgas2 = "214" Or l_atabgas2 = "215" Or l_atabgas2 = "21" Then
                i = 1

                nrocuo = i.ToString

                'If l_atabgas1 = "02" Then 'seguro de vida
                '    'verifica si aplica
                '    If Me.lsegvid = True Then
                '        lngasto = l_atabgas3 * Me.nMeses
                '    Else
                '        lngasto = 0
                '    End If

                'Else
                lngasto = l_atabgas3
                'End If

                'actualiza tabla temporal
                dr_M = lcfilgas.NewRow()
                dr_M("ctipgas") = l_atabgas1
                dr_M("ccodope") = l_atabgas2
                dr_M("cnrocuo") = nrocuo
                dr_M("ncapita") = laVector(i, 1)
                dr_M("nintere") = laVector(i, 2)
                dr_M("ngasto") = lngasto
                dr_M("cdescob") = "D"
                lcfilgas.Rows.Add(dr_M)
                lntotgasdes = lntotgasdes + lngasto



            End If

            'actualiza el plan de pagos
            cuenta1 = cuenta1 + 1
        Next

        'en esta seccion agregara los gastos a la tabla planpago
        Dim cnrocuo1 As Integer
        Dim cnrocuo2 As String
        Dim contador As Integer

        lntotgasdes = 0
        lntotgascuo = 0
        cuenta1 = 0
        cnrocuo1 = 0
        Dim lnsegdeu As Decimal = 0
        Dim lntotsegcuo As Decimal = 0
        Dim ctipgas As String

        For Each fila In tmpplan.Rows
            ctipope = fila("ctipope")
            cnrocuo1 = cnrocuo1 + 1
            cnrocuo2 = cnrocuo1.ToString.Trim

            For Each fila1 In lcfilgas.Rows
                lngasto = IIf(IsDBNull(fila1("ngasto")), 0, fila1("ngasto"))
                lnsegdeu = IIf(IsDBNull(fila1("nsegdeu")), 0, fila1("nsegdeu"))
                If fila1("cdescob") = "D" Then
                    lntotgasdes = lntotgasdes + lngasto
                End If
                If fila1("cnrocuo") = cnrocuo2 And fila1("cdescob") = "C" Then
                    lntotgascuo = lntotgascuo + lngasto
                    lntotsegcuo = lntotsegcuo + lnsegdeu
                End If

            Next fila1

            If ctipope = "D" Then
                fila("ngastos") = lntotgasdes
            Else
                'If fila("ctipgas") = "03" Then
                '    fila("nsegdeu") = lntotsegcuo
                'Else
                fila("ngastos") = lntotgascuo
                'fila("nsegdeu") = lntotsegcuo
                'End If
            End If
            'este paso es porque la primera cuota es 1 igual que el desembolso
            If cuenta1 = 0 Then
                cnrocuo1 = cnrocuo1 - 1
            End If
            p_cplapag.ImportRow(fila)

            lntotgasdes = 0
            lntotgascuo = 0
            lntotsegcuo = 0
            '**

            cuenta1 = cuenta1 + 1
        Next  'fila

        If Me.pcTabGasx.Tables.Count > 0 Then
            Me.pcTabGasx.Tables.Clear()
        End If
        Me.pcTabGasx.Tables.Add(lcfilgas)
        Me.Actualiza_Credgas()

    End Sub


    'funcion que crea los dataset desconectados

    Public Function creadatasetdesconec(ByVal pcampos As String, ByVal ptipos As String, ByVal pnomtab As String) As DataTable
        '*******ejempo de sintaxis de funcion creadatasetdesconec *****
        '        lcampos = "cnrolin, ccodlin, cdeslin,"
        '       ltipos = "S,I,F"
        '       lnomtab = "Datos"
        '      dstmp = ws.creadatasetdesconec(lcampos, ltipos,lnomtab)
        '     Me.dglineas.DataSource = dstmp.Tables("Datos")
        '********finaliza sintaxis de la clase **************

        'sintaxis de la clase
        Dim lcampos As String
        Dim ltipos As String


        Dim x As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String

        Dim dsnew As New DataSet
        Dim dt As New DataTable(pnomtab)
        Dim dc As New DataColumn
        '*************************************************
        'evalua datos y tipos de datos enviados

        i = 0

        '--------------------------------------------------------
        'Proceso que parte cada uno de los parametros enviados
        '--------------------------------------------------------

        'Halla numero de parametros

        For x = 0 To pcampos.Length - 1
            If pcampos.Substring(x, 1) = "," Then
                i += 1
            End If
        Next

        'Declara arreglo segun cantidad de parametros
        Dim campos(i) As String 'campos
        Dim TipoD(i) As String  'tipos
        Dim conte(i) As String  'contenidos

        '----------------------------------
        'Sacando los campos
        '----------------------------------

        i = 0
        j = 0
        k = 1

        For x = 0 To pcampos.Length - 1
            If pcampos.Substring(x, 1) = "," Then
                campos(k) = pcampos.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        campo1 = campos(1)
        campo2 = campos(2)

        '----------------------------------
        'Sacando los Tipos
        '----------------------------------
        i = 0
        j = 0
        k = 1

        For x = 0 To ptipos.Length - 1
            If ptipos.Substring(x, 1) = "," Then
                TipoD(k) = ptipos.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next


        'inicia proceso de la funcion
        Dim tipo As String
        Dim camp As String
        dt.Columns.Add(dc)

        For i = 1 To TipoD.Length - 1
            tipo = TipoD(i)
            camp = campos(i).Trim
            If tipo = "S" Then
                dt.Columns.Add(camp, Type.GetType("System.String")) 'string
            ElseIf tipo = "I" Then
                dt.Columns.Add(camp, Type.GetType("System.Int32")) 'entero
            ElseIf tipo = "F" Then
                dt.Columns.Add(camp, Type.GetType("System.DateTime")) 'fecha
            ElseIf tipo = "B" Then
                dt.Columns.Add(camp, Type.GetType("System.Boolean")) 'boolena
            ElseIf tipo = "D" Then
                dt.Columns.Add(camp, Type.GetType("System.Double")) 'double
            End If
        Next
        '  dsnew.Tables.Add(dt)
        ' Return dsnew.Tables(pnomtab)
        Return dt

        '***************************************************

    End Function


    ' ************ FIN SEGUNDA PARTE *********


    '******** FINALIZA FUNCIONES Y PROCEDIMIENTOS 
    '***FRAN
    'Genera el Código de la Cuenta 
    Function fxSteCuenta(ByVal p_cTipSer As String, ByVal p_cMoneda As String, ByVal p_cCodIns As String, ByVal p_cCodOfi As String) As String
        Dim lcCodCta_f As String
        Dim lcNumero_f As String
        lcCodCta_f = p_cCodIns & p_cCodOfi & p_cTipSer & p_cMoneda '& "Z"
        Try
            ds.Tables.Clear()
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select max(cCodCta) as ccodcta from CREMCRE"
            ' sql = sql + " Where SUBSTRING(cCodCta,1,9) = " & "'" & lcCodCta_f & "'"
            sql = sql + " Where left(cCodCta,9) = " & "'" & lcCodCta_f & "'"

            sql = sql + " GROUP BY cCodCta order by cCodcta"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "CreGen")
            Dim lnCount As Integer = 0
            lnCount = ds.Tables("CreGen").Rows.Count
            If lnCount <= 0 Then
                lcCodCta_f = p_cCodIns & p_cCodOfi & p_cTipSer & p_cMoneda & "00000000000"
            Else
                Dim lnReg As Integer = 0
                lnReg = lnCount - 1
                lcCodCta_f = ds.Tables("CreGen").Rows(lnReg)("cCodCta")
            End If
            lcNumero_f = fxStrZero(Val(lcCodCta_f.Trim.Substring(9, 9) + 1), 9)
            lcCodCta_f = Left(lcCodCta_f, 9) + lcNumero_f
            Return lcCodCta_f

        Catch ex As Exception

        End Try

    End Function
    'Genera el Código del Grupo
    Function fxSteCuentaGru(ByVal p_cCodIns As String, ByVal p_cCodOfi As String, ByVal p_ctipmet As String) As String
        Dim lcCodCta_f As String
        Dim lcNumero_f As String
        'lcCodCta_f = p_cCodIns & p_cCodOfi & p_ctipmet '& "Z"
        lcCodCta_f = p_cCodOfi & p_ctipmet '& "Z"
        Try
            ds.Tables.Clear()
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select max(cCodsol) as ccodsol from CREMSOL"

            sql = sql + " Where left(cCodSol,5) = " & "'" & lcCodCta_f & "'"

            sql = sql + " GROUP BY cCodSol"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "CreGen")
            Dim lnCount As Integer = 0
            lnCount = ds.Tables("CreGen").Rows.Count
            If lnCount <= 0 Then
                'lcCodCta_f = p_cCodIns & p_cCodOfi & p_ctipmet & "0000"
                lcCodCta_f = p_cCodOfi & p_ctipmet & "0000000"
            Else
                Dim lnReg As Integer = 0
                lnReg = lnCount - 1
                lcCodCta_f = ds.Tables("CreGen").Rows(lnReg)("cCodsol")
            End If
            'lcNumero_f = fxStrZero(Val(lcCodCta_f.Trim.Substring(8, 4) + 1), 4)
            lcNumero_f = fxStrZero(Val(lcCodCta_f.Trim.Substring(6, 6) + 1), 7)
            'lcCodCta_f = Left(lcCodCta_f, 8) + lcNumero_f
            lcCodCta_f = Left(lcCodCta_f, 5) + lcNumero_f
            Return lcCodCta_f

        Catch ex As Exception

        End Try

    End Function


    Public Function fxStrZero(ByVal pnParameter As Integer, ByVal pnNumDig As Integer) As String
        Dim lcDigConv As String
        Dim lnLongDat As Integer
        Dim k As Integer
        lnLongDat = pnParameter.ToString.Trim.Length
        If lnLongDat >= pnNumDig Then
            lcDigConv = pnParameter.ToString.Trim
        Else
            lcDigConv = pnParameter.ToString.Trim
            For k = 1 To (pnNumDig - lnLongDat)
                lcDigConv = "0" & lcDigConv
            Next
        End If
        Return lcDigConv
    End Function

    Public Function fxStrZero_Alfa(ByVal pnParameter As String, ByVal pnNumDig As Integer) As String
        Dim lcDigConv As String
        Dim lnLongDat As Integer
        Dim k As Integer
        lnLongDat = pnParameter.Trim.Length
        If lnLongDat >= pnNumDig Then
            lcDigConv = pnParameter.ToString.Trim
        Else
            lcDigConv = pnParameter.ToString.Trim
            For k = 1 To (pnNumDig - lnLongDat)
                lcDigConv = "0" & lcDigConv
            Next
        End If
        Return lcDigConv
    End Function

    Public Function fxCreateFilePlain() As DataTable

        Try
            Dim pCampos_f As String
            Dim pTipos_f As String
            pCampos_f = "dFecPro, cTipOpe, cNroCuo, nCapita, nIntere, cNomDia, "
            pCampos_f = pCampos_f & " nDifDia, nTasaIn, nTasaEf, nMCuota, "
            pCampos_f = pCampos_f & " nRecFij, nSalCan, nTipOpe, nIntCal, nGastos, "
            pCampos_f = pCampos_f & " nSalCap, cFlag,"

            pTipos_f = "F, S, S, D, D, S, "
            pTipos_f = pTipos_f & " I, D, D, D, "
            pTipos_f = pTipos_f & " D, D, I, D, D, "
            pTipos_f = pTipos_f & " D, S,"

            dsPlan.Clear()
            dsPlan = creadatasetdesconec(pCampos_f, pTipos_f, "PLAN")
            Return dsPlan
        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
    End Function

    Public Function fxCreatePlain(ByVal ndiafin As Integer, _
                                  ByVal ncuota As Double) As DataSet
        'Try
        Dim p_dfecpri As Date = Me.dfecpri
        Dim p_dFecDes As Date = Me.dFecDes
        Dim p_nMonDes As Double = Me.nMonDes
        Dim p_nTasInt As Double = Me.nTasInt
        Dim p_cCodFor As String = Me.cCodFor
        Dim p_nPerDia As Integer = Me.nPerDia
        Dim p_nNroCuo As Integer = Me.nNroCuo
        Dim p_cTipCuo As String = Me.cTipCuo
        Dim p_nDiaGra As Integer = Me.nDiaGra
        Dim p_cTipCal As String = Me.cTipCal
        Dim p_cTipEst As String = Me.cTipEst
        Dim p_nTipPeri As Integer = Me.nTipPer
        Dim p_lFlat As Boolean = Me.lFlat
        Dim p_lRedo As Boolean = Me.lRedo
        Dim p_cFlat As String = Me.cFlat

        Dim cfreccap As String = Me.cfreccap
        Dim cfrecint As String = Me.cfrecint



        Dim llObvDom As Integer
        Dim llObvSab As Integer


        Dim ecremcre As New cCremcre
        llObvSab = IIf(ecremcre.Sabado() = False, 0, 1)
        llObvDom = IIf(ecremcre.Domingo() = False, 0, 1)
        'Dim dsFS As New DataSet
        '**************
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DSFS As New DataSet
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable
        DSFS.Clear()
        lCampos1 = "dFecPro, dFecDes, nTasaIn, nMCuota, cTipOpe, nSalCap, nTipOpe,nDifDia,nTasaEf,nCapita,nIntere,cNroCuo,ngastos,nSegDeu,nsegdan, nresinc, ntalona, notrpag, nflag, Saldo,"
        lTipos1 = "F,F,D,D,S,D,I,I,D,D,D,S,D,D,D,D,D,D,I,D,"
        DT = creadatasetdesconec(lCampos1, lTipos1, "Plan")
        DR = DT.NewRow
        DR("dFecPro") = p_dFecDes
        DR("dFecDes") = p_dFecDes
        DR("nTasaIn") = p_nTasInt
        DR("nMCuota") = p_nMonDes
        DR("cTipOpe") = "D"
        DR("nSalCap") = p_nMonDes
        DR("nTipOpe") = Asc("D")
        DR("nCapita") = p_nMonDes
        DR("nIntere") = 0
        DR("cNroCuo") = "001"
        DR("nGastos") = 0
        DR("nSegDeu") = 0
        DR("nflag") = 1
        DT.Rows.Add(DR)
        Dim i As Integer
        For i = 1 To (p_nNroCuo * p_nTipPeri)
            DR = DT.NewRow
            DR("nTasaIn") = p_nTasInt
            DR("cTipOpe") = "N"
            DR("nTipOpe") = Asc("N")
            DR("nCapita") = 0
            DR("nIntere") = 0
            DR("cNroCuo") = fxStrZero(i, 3)
            DR("nGastos") = 0
            DR("nSegDeu") = 0
            DR("nflag") = 0
            DT.Rows.Add(DR)
        Next
        DSFS.Tables.Add(DT)

        fxDatePayment(p_dFecDes, p_cCodFor, p_nPerDia, p_nNroCuo, p_nDiaGra, llObvDom, llObvSab, p_nTipPeri, p_cFlat, _
                      DSFS, p_dfecpri, cfreccap, cfrecint, ndiafin)

        Dim dFecUlt As Date
        Dim Fila As DataRow
        Dim nCanti As Integer = 0
        Dim lnUltimo As Integer
        lnUltimo = DSFS.Tables(0).Rows.Count - 1
        dFecUlt = DSFS.Tables(0).Rows(lnUltimo)("dFecPro")
        omCalPago(p_dFecDes, dFecUlt, p_nNroCuo, p_nTasInt, Me.gnperbas, Me.nMonDes, Me.cTipEst, _
                  Me.cCodFor, Me.cTipCuo, Me.cFlat, DSFS, ncuota)


        Dim pnSaldo As Double = 0
        Dim pnCapTeo As Double = 0
        Dim pnCapDes As Double = 0
        nCanti = 0
        Dim lncuogas As Integer = 0
        For Each Fila In DSFS.Tables(0).Rows
            DSFS.Tables(0).Rows(nCanti)("nMCuota") = Math.Round(DSFS.Tables(0).Rows(nCanti)("nMCuota"), 2)
            DSFS.Tables(0).Rows(nCanti)("nSalCap") = Math.Round(DSFS.Tables(0).Rows(nCanti)("nSalCap"), 2)
            DSFS.Tables(0).Rows(nCanti)("nCapita") = Math.Round(DSFS.Tables(0).Rows(nCanti)("nCapita"), 2)
            DSFS.Tables(0).Rows(nCanti)("nIntere") = Math.Round(DSFS.Tables(0).Rows(nCanti)("nIntere"), 2)
            'Calcula Saldo para Ajusta Ultima Cuota
            If DSFS.Tables(0).Rows(nCanti)("cTipOpe") = "D" Then
                pnSaldo = pnSaldo + DSFS.Tables(0).Rows(nCanti)("nCapita")
                pnCapDes = pnCapDes + DSFS.Tables(0).Rows(nCanti)("nCapita")
                Fila("ngastos") = 0
            Else
                pnSaldo = pnSaldo - DSFS.Tables(0).Rows(nCanti)("nCapita")
                pnCapTeo = pnCapTeo + DSFS.Tables(0).Rows(nCanti)("nCapita")

                'Se agregan aditivos----------------------------------
                If lncuogas < Me.nNroCuo0 Then
                    Fila("ngastos") = ngastos1
                Else
                    Fila("ngastos") = 0
                End If
                lncuogas += 1
            End If
            Me.dFecVen = DSFS.Tables(0).Rows(nCanti)("dFecPro")
            nCanti = nCanti + 1
        Next
        nMeses = PlazoMeses(p_dFecDes, Me.dFecVen)
        If Math.Round(pnSaldo, 2) <> 0 Then
            Dim pnDifCap As Double = 0
            pnDifCap = Math.Round((pnCapDes - pnCapTeo), 2)
            DSFS.Tables(0).Rows(nCanti - 1)("nCapita") = DSFS.Tables(0).Rows(nCanti - 1)("nCapita") + pnDifCap
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'Carga Gastos al Plan de Pagos
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim dsgastos As New DataSet
        Dim mControl As New cCretgas
        Dim mdataset As New DataSet
        dsgastos = mControl.ObtenerDataSetPorID(Me.cNrolin)
        fxgastosiniciales(DSFS.Tables(0), dsgastos.Tables(0), "A", "N", Me.nMeses, False, False)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        '>>>>Gastos Especiales>>>>
        Me.OtrosGastos()
        nCanti = 0
        Dim lnotrgas As Double
        Dim lnotrogasto As Double = 0
        'For Each Fila In DSFS.Tables(0).Rows
        '    If DSFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
        '        lnotrgas = DSFS.Tables(0).Rows(nCanti)("nGastos")
        '        lnotrogasto = Gasto_Proporcional(Me.cCodFor, Me.nPerDia, lnotrgas)

        ' DSFS.Tables(0).Rows(nCanti)("nSegDeu") = Math.Round(Me.pnSegDeu, 2)
        ' DSFS.Tables(0).Rows(nCanti)("nGastos") = lnotrogasto + Math.Round(Me.pnComPer, 2)
        '    Else

        '    End If
        'nCanti = nCanti + 1
        'Next

        'División de IVA, si aplica
        If lliva Then
            For Each Fila In DSFS.Tables(0).Rows
                If Fila("cTipOpe") = "N" Then
                    Fila("nGastos") = Fila("nintere") - (Fila("nintere") / Me.pniva)
                    Fila("nGastos") = Math.Round(Fila("nGastos"), 2)
                    Fila("nintere") = Fila("nintere") - Fila("nGastos")
                End If
            Next
        End If

        '<<<<<<<<<<<<<<<<<<<<<<<<
        Return DSFS
        'Catch SqlException As Exception

        'End Try
    End Function


    'Funcion que devuelve la credcon, para verificar Sabado y Domingo
    Public Function FindeSemana() As DataSet
        Try
            myconnection = New SqlConnection(Me.Cnn)
            sql = "Select lObvDom, lObvSab FROM CREDCON"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "FSemana")
        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            '    MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
        Return ds
    End Function

    'Función que genera fechas de pago
    Public Function fxDatePayment(ByVal p_dFecDes As Date, ByVal p_cCodFor As String, _
                                  ByVal p_nPerDia As Integer, ByVal p_nNumCuo As Integer, ByVal p_nDiaGra As Integer, _
                                  ByVal p_lObvDom As Integer, ByVal p_lObvSab As Integer, ByVal p_ntipperi1 As Integer, _
                                  ByVal p_cTipFlat As String, ByRef dsFS As DataSet, ByVal p_dfecpri As Date, ByVal c_freccap As String, _
                                  ByVal c_frecint As String, ByVal n_diafin As Integer)

        Dim ldFecPro As Date
        Dim dsPlan_f As DataTable
        Dim Fila As DataRow
        Dim nCanti As Integer
        Dim nfrecuencia As Integer = 0
        Dim nfreckp As Integer = 0
        nCanti = 0
        Try
            'dsPlan_f = fxCreateFilePlain()
            '  p_dFecDes = IIf(p_dFecDes.ToString.Trim.Length = 0, CDate(Date.Now.ToString.Substring(0, 10)), p_dFecDes)
            If p_dFecDes = Nothing Or IsDBNull(p_dFecDes) Then
                p_dFecDes = Date.Now 'CDate(Date.Now.ToString.Substring(0, 10))
            Else
                p_dFecDes = p_dFecDes
            End If
            p_cCodFor = IIf((p_cCodFor <> "1" And p_cCodFor <> "2"), "1", p_cCodFor)
            p_nNumCuo = IIf(p_nNumCuo <= 0, 6, p_nNumCuo)
            ldFecPro = p_dFecDes

            Dim ldfecflag As Date
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'La frecuencia del interes es la que define el plan de pagos
            If c_frecint = "M" Then 'Mensual
                p_nPerDia = p_dfecpri.Day
                If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                    p_nPerDia = 31
                Else
                    p_nPerDia = p_nPerDia
                End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0
                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        nfrecuencia += 1
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                        Else
                            '                ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                        End If
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldFecPro
                        '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<
                        If c_freccap = "A" Then 'al vencimiento
                        ElseIf c_freccap = "B" Then 'catorcenal
                        ElseIf c_freccap = "D" Then ' diario
                        ElseIf c_freccap = "E" Then ' semestral
                            If nfrecuencia = 6 Then
                                dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                                nfrecuencia = 0
                            End If
                        ElseIf c_freccap = "I" Then 'bimensual
                            If nfrecuencia = 2 Then
                                dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                                nfrecuencia = 0
                            End If
                        ElseIf c_freccap = "M" Then 'mensual
                            dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                        ElseIf c_freccap = "S" Then 'semanal

                        ElseIf c_freccap = "T" Then 'trimestral
                            If nfrecuencia = 3 Then
                                dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                                nfrecuencia = 0
                            End If
                        ElseIf c_freccap = "C" Then 'Cuatrimestral
                            If nfrecuencia = 4 Then
                                dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                                nfrecuencia = 0
                            End If
                        ElseIf c_freccap = "N" Then 'Anual
                            If nfrecuencia = 12 Then
                                dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                                nfrecuencia = 0
                            End If

                        End If
                        '<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>

                    End If
                    nCanti = nCanti + 1
                Next
            ElseIf c_frecint = "X" Then 'frecuencia irregular
                'p_nPerDia = p_dfecpri.Day
                'If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                '    p_nPerDia = 31
                'Else
                p_nPerDia = p_nPerDia
                'End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0

                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                        Else
                            ldfecflag = ldFecPro
                            ldFecPro = DateAdd(DateInterval.Day, p_nPerDia, ldfecflag)
                        End If

                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldFecPro
                    End If

                    nCanti = nCanti + 1
                Next

            ElseIf c_frecint = "I" Then ' Bimensual
                p_nPerDia = p_dfecpri.Day
                If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                    p_nPerDia = 31
                Else
                    p_nPerDia = p_nPerDia
                End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0

                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                        Else
                            ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = fxNextFixedDay(ldfecflag, p_nPerDia)
                        End If

                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldFecPro
                    End If

                    nCanti = nCanti + 1
                Next

            ElseIf c_frecint = "T" Then 'Trimestral
                p_nPerDia = p_dfecpri.Day
                If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                    p_nPerDia = 31
                Else
                    p_nPerDia = p_nPerDia
                End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0
                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                            ldfecflag = ldFecPro
                        Else
                            ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = fxNextFixedDay(ldfecflag, p_nPerDia)
                            ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = ldfecflag
                        End If
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldfecflag
                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1

                    End If
                    nCanti = nCanti + 1
                Next
            ElseIf c_frecint = "C" Then 'Cuatrimestral
                p_nPerDia = p_dfecpri.Day
                If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                    p_nPerDia = 31
                Else
                    p_nPerDia = p_nPerDia
                End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0
                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                            ldfecflag = ldFecPro
                        Else
                            ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = fxNextFixedDay(ldfecflag, p_nPerDia)
                            ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = fxNextFixedDay(ldfecflag, p_nPerDia)
                            ldfecflag = ldFecPro
                        End If
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldfecflag
                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1

                    End If
                    nCanti = nCanti + 1
                Next

            ElseIf c_frecint = "E" Then 'Semestral
                p_nPerDia = p_dfecpri.Day
                If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                    p_nPerDia = 31
                Else
                    p_nPerDia = p_nPerDia
                End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0
                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                        Else
                            Dim k As Integer
                            For k = 1 To 3
                                ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                                ldFecPro = fxNextFixedDay(ldfecflag, p_nPerDia)
                            Next
                        End If
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldFecPro
                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                    End If
                    nCanti = nCanti + 1

                Next
            ElseIf c_frecint = "N" Then 'Anual
                p_nPerDia = p_dfecpri.Day
                If p_nPerDia <= 0 Or p_nPerDia > 31 Then
                    p_nPerDia = 31
                Else
                    p_nPerDia = p_nPerDia
                End If
                If p_dFecDes.Day < p_nPerDia Then
                    ldFecPro = p_dFecDes.AddDays(-p_dFecDes.Day)
                End If
                nCanti = 0
                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = fxNextFixedDay(ldFecPro, p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                        Else
                            Dim k As Integer
                            For k = 1 To 6
                                ldfecflag = fxNextFixedDay(ldFecPro, p_nPerDia)
                                ldFecPro = fxNextFixedDay(ldfecflag, p_nPerDia)
                            Next
                        End If
                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldFecPro
                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                    End If
                    nCanti = nCanti + 1

                Next

            Else

                Select Case c_frecint
                    Case "A" 'Al vencimiento
                        p_nPerDia = 0
                    Case "B" 'Catorcenal
                        p_nPerDia = 14
                    Case "D" 'Diario
                        p_nPerDia = 1
                    Case "Q" 'Quincenal
                        p_nPerDia = 15
                    Case "S" 'Semanal
                        p_nPerDia = 7
                End Select

                p_nPerDia = IIf(p_nPerDia <= 0, 30, p_nPerDia)
                nCanti = 0
                For Each Fila In dsFS.Tables(0).Rows
                    If dsFS.Tables(0).Rows(nCanti)("cTipOpe") = "N" Then
                        If nCanti = 1 Then
                            'ldFecPro = ldFecPro.AddDays(p_nPerDia)
                            ldFecPro = p_dfecpri 'ldFecPro.AddDays(p_nDiaGra)
                        Else
                            ldFecPro = ldFecPro.AddDays(p_nPerDia)
                        End If

                        dsFS.Tables(0).Rows(nCanti)("dFecPro") = ldFecPro
                        dsFS.Tables(0).Rows(nCanti)("nflag") = 1
                    End If
                    nCanti = nCanti + 1
                Next

            End If

            '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            Me.fxAvoidHolly(dsFS, p_lObvDom, p_lObvSab, n_diafin, p_dFecDes)
        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
    End Function

    Public Sub fxAvoidHolly(ByRef dsFS As DataSet, ByVal p_lObvDom As Integer, ByVal p_lObvSab As Integer, _
                            ByVal p_ndiafin As Integer, ByVal pdfecven As Date)

        Dim etabtofi As New cTabtofi
        Dim lccodofi As String = ""
        If pcCodCre Is Nothing Or IsDBNull(pcCodCre) Then
            pcCodCre = ""
        End If
        lccodofi = etabtofi.ObtenerOficinaPrestamo(pcCodCre)


        Dim mtabtfer As New cTabtfer
        Dim etabtfer As New tabtfer
        Dim dsfer As DataSet
        dsfer = mtabtfer.ObtenerDataSetPorIDOficina(lccodofi, pdfecven)
        Dim ldfecpro2 As Date
        Dim drfer As DataRow
        Dim drfila As DataRow
        Dim bandera As Boolean
        bandera = True
        Dim lndias As Double
        Dim nflag As Integer = 0
        For Each drfila In dsFS.Tables(0).Rows
            If drfila("CTIPOPE") <> "D" Then
                bandera = True
                ldfecpro2 = drfila("dfecpro")
                Do While bandera
                    '**********
                    If p_lObvDom = 1 And Weekday(ldfecpro2, FirstDayOfWeek.Sunday) = 1 Then
                        nflag = 1
                    ElseIf p_lObvSab = 1 And Weekday(ldfecpro2, FirstDayOfWeek.Sunday) = 7 Then
                        nflag = 1
                    Else
                        'calcula los feriados
                        For Each drfer In dsfer.Tables(0).Rows
                            If drfer("dferiad") = ldfecpro2 Then
                                nflag = 1
                            End If
                        Next
                    End If
                    '*********
                    If nflag = 1 Then
                        ldfecpro2 = ldfecpro2.AddDays(p_ndiafin)
                    Else
                        bandera = False
                    End If
                    nflag = 0
                Loop
                If ldfecpro2 <> drfila("dfecpro") Then
                    drfila("dfecpro") = ldfecpro2
                End If
            End If
        Next

    End Sub



    Public Function omCalPago(ByVal dFecAnt As Date, ByVal dFecUlt As Date, ByVal nNumCuo As Integer, _
                              ByVal nTasInt As Double, ByVal nPerBas As Integer, ByVal pnMonDes As Double, _
                              ByVal pcTipEst As String, ByVal pcCodFor As Integer, ByVal pcTipCuo As Integer, _
                              ByVal pcFlat As String, ByRef dsPlan As DataSet, ByVal ncuota As Double)

        Dim lcTipOpe As String
        Dim C_MAXITER As Integer = 60
        Dim nProDif, j, k As Integer
        Dim lnDifDia As Long
        Dim pnTasInt, pnTasaEf, lnDelMin, lnDelta As Double
        Dim lnTasPer As Double = 0
        Dim pnMonMin As Double = 0 '0.01f
        Dim nCanti, lnFlag, lnMinimo As Integer
        Dim ldFecPro, ldFecAnt As Date
        Dim lnCuota1, lnCuota2, lnUltPos, lnUltNeg As Double
        Dim lnSigno1, lnSigno2 As Integer
        Dim lnDifDias As Long
        lnDifDias = DateDiff(DateInterval.Day, dFecAnt, dFecUlt)
        'Cambio para FLAT
        '        If Me.cCodFor = "2" And Me.cFlat = "F" Then
        '       nProDif = 30
        '      Else
        nProDif = lnDifDias / nNumCuo
        '     End If
        'nProDif = Integer.Parse(DateDiff(DateInterval.DayOfYear, dFecUlt, dFecAnt) / nNumCuo)
        pnTasInt = (nTasInt / 100) 'Agregamos de un solo el IVA para el calculo teorico

        If pnTasInt = 0 Then
            pnTasaEf = 0
        Else
            pnTasaEf = ((pnTasInt + 1) ^ (nProDif / nPerBas) - 1)
        End If

        Dim tasaefiva As Double = 0
        'tasaefiva = ((0.12 + 1) ^ (nProDif / 365) - 1)


        nCanti = dsPlan.Tables(0).Rows.Count()
        If nCanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If

        Dim Fila As DataRow
        nCanti = 0
        ldFecAnt = dsPlan.Tables(0).Rows(nCanti)("dFecPro")
        For Each Fila In dsPlan.Tables(0).Rows
            lcTipOpe = Fila("cTipOpe")
            ldFecPro = Fila("dFecPro")
            If lcTipOpe = "N" Then
                j = j + 1
            End If
            'lnDifDia = Integer.Parse(DateDiff(DateInterval.DayOfYear, ldFecPro, dFecAnt))
            lnDifDia = DateDiff(DateInterval.Day, ldFecAnt, ldFecPro)
            ldFecAnt = ldFecPro

            If pnTasInt = 0 Then
                lnTasPer = 0
            Else
                If Me.cFlat = "F" Then
                    If Me.cCodFor = "2" Then
                        lnTasPer = pnTasInt / 12
                    Else

                        If Me.nPerDia = 1 Then
                            lnTasPer = pnTasInt / 12 / 30
                        ElseIf Me.nPerDia = 7 Then
                            lnTasPer = pnTasInt / 12 / 4
                        ElseIf Me.nPerDia = 14 Then
                            lnTasPer = pnTasInt / 12 / 2
                        ElseIf Me.nPerDia = 15 Then
                            lnTasPer = pnTasInt / 12 / 2
                        ElseIf Me.nPerDia = 28 Then
                            lnTasPer = pnTasInt / 12
                        ElseIf Me.nPerDia = 30 Then
                            lnTasPer = pnTasInt / 12
                        ElseIf Me.nPerDia = 60 Then
                            lnTasPer = (pnTasInt / 12) * 2
                        ElseIf Me.nPerDia = 90 Then
                            lnTasPer = (pnTasInt / 12) * 3
                        ElseIf Me.nPerDia = 120 Then
                            lnTasPer = (pnTasInt / 12) * 4
                        ElseIf Me.nPerDia = 180 Then
                            lnTasPer = (pnTasInt / 12) * 6
                        ElseIf Me.nPerDia = 0 Then 'Al vencimiento
                            lnTasPer = pnTasInt * lnDifDia / nPerBas
                        Else
                            Dim lnper As Double
                            lnper = 30 / Me.nPerDia
                            lnTasPer = pnTasInt / 12 / lnper
                            If Me.nPerDia > 30 Then
                                lnTasPer = Double.Parse(pnTasInt * lnDifDia / nPerBas)
                            End If
                        End If
                    End If
                Else
                    lnTasPer = Double.Parse(pnTasInt * lnDifDia / nPerBas)
                End If
            End If
            Fila("nDifDia") = lnDifDia
            Fila("nTasaEf") = lnTasPer
            Fila("nTasaIn") = pnTasInt
            nCanti = nCanti + 1
        Next
        If j = 0 Then
            Return xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, pcTipCuo, dsPlan)
        End If
        Dim laMCuota(C_MAXITER) As Double, laDifCap(C_MAXITER) As Double, laSigno(C_MAXITER) As String
        k = 1
        If pcFlat = "F" Then
            lnDelMin = Math.Round(j * pnMonMin, 2)
        End If
        lnDelMin = j * pnMonMin

        Dim lncuofrec As Integer = 0
        If Me.cfrecint = "M" Then
            Select Case Me.cfreccap
                Case "A"
                    lncuofrec = nNumCuo
                Case "B"
                    lncuofrec = nNumCuo
                Case "D"
                    lncuofrec = nNumCuo
                Case "E"
                    If cfreccap = cfrecint Then
                        lncuofrec = nNumCuo
                    Else
                        lncuofrec = Math.Round(nNumCuo / 6, 0)
                    End If
                Case "N"
                    If cfreccap = cfrecint Then
                        lncuofrec = nNumCuo
                    Else
                        lncuofrec = Math.Round(nNumCuo / 12, 0)
                    End If

                Case "I"
                    If cfreccap = cfrecint Then
                        lncuofrec = nNumCuo
                    Else
                        lncuofrec = Math.Round(nNumCuo / 2, 0)
                    End If

                Case "M"
                    lncuofrec = nNumCuo
                Case "Q"
                    lncuofrec = nNumCuo
                Case "S"
                    lncuofrec = nNumCuo
                Case "T"
                    If cfreccap = cfrecint Then
                        lncuofrec = nNumCuo
                    Else
                        lncuofrec = Math.Round(nNumCuo / 3, 0)
                    End If

                Case "C"
                    If cfreccap = cfrecint Then
                        lncuofrec = nNumCuo
                    Else
                        lncuofrec = Math.Round(nNumCuo / 4, 0)
                    End If

            End Select

        Else
            lncuofrec = nNumCuo
        End If

        'laMCuota(k) = math.round(pnMonDes * (((pnTasaEf + 1) ^ nNumCuo) * pnTasaEf) / (((pnTasaEf + 1) ^ nNumCuo) - 1), 2)
        
        'Modificado Cuota Fija, Especial Mexico 18/08/2014
        If ncuota > 0 Then
            laMCuota(k) = Math.Round(ncuota, 2)
        Else

            If pnTasaEf = 0 Then
                laMCuota(k) = Math.Round(pnMonDes / lncuofrec, 2)
            Else
                laMCuota(k) = Math.Round(pnMonDes * (((pnTasaEf + 1) ^ lncuofrec) * pnTasaEf) / (((pnTasaEf + 1) ^ lncuofrec) - 1), 2)
            End If
        End If

        If pcFlat = "F" Then
            laMCuota(k) = Math.Round(laMCuota(k), 2)
        End If

        laDifCap(k) = Math.Round(xmCalCuoFija(laMCuota(k), pnMonDes, pcFlat, pcTipEst, _
                      pcCodFor, pcTipCuo, dsPlan), 2)
        laSigno(k) = xmDetSigno(lnDelMin, laDifCap(k))

        If laSigno(k) <> 0 Then
            laSigno(k + 1) = laSigno(k)
        Else
            '    *--- No hay necesidad de mas ajustes ---*
            Return xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, pcTipCuo, dsPlan)
        End If
        ' *--- Buscar cambio de signo a partir de 1ra aproximacion ---*
        lnFlag = 0
        Dim i As Integer
        For i = k + 1 To C_MAXITER - 1
            lnDelta = laDifCap(k) / j
            k = k + 1

            'Modificado Cuota Fija, Especial Mexico 18/08/2014
            If ncuota > 0 Then
                laMCuota(k) = Math.Round(ncuota, 2)
            Else
                laMCuota(k) = Math.Round(laMCuota(k - 1) + lnDelta, 2)
            End If

            laDifCap(k) = Math.Round(xmCalCuoFija(laMCuota(k), pnMonDes, pcFlat, pcTipEst, _
                         pcCodFor, pcTipCuo, dsPlan), 2)
            laSigno(k) = xmDetSigno(lnDelMin, laDifCap(k))
            If laSigno(k) = 0 Then
                '*--- Salida por llegar al delta minimo ---*
                lnFlag = 1
                Exit For
            End If
            If laSigno(k) <> laSigno(k - 1) Then
                '*--- Salida por cambio de signo ---*
                Exit For
            End If
        Next
        If lnFlag = 1 Then
            '   *--- Salida por llegar al delta minimo ---*
            Return xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, _
                    pcTipCuo, dsPlan)
        End If
        If i >= C_MAXITER Then
            '   *--- Salida por llegar al maximo No.de iteraciones ---*
            Return xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, _
                    pcTipCuo, dsPlan)
        End If
        '*----- Inicio de metodo de biseccion -----*
        lnCuota1 = Math.Round(laMCuota(1), 2)
        lnSigno1 = laSigno(1)
        lnCuota2 = Math.Round(laMCuota(k), 2)
        lnSigno2 = laSigno(k)
        '*--- Reinicializa arreglos ---*
        For i = 1 To C_MAXITER
            laMCuota(i) = 0
            laSigno(i) = 0
        Next
        k = 1
        laMCuota(k) = Math.Round(lnCuota1, 2)
        laSigno(k) = lnSigno1
        laMCuota(k + 1) = Math.Round(lnCuota2, 2)
        laSigno(k + 1) = lnSigno2
        If laSigno(k) > 0 Then
            lnUltPos = Math.Round(laMCuota(k), 2)
            lnUltNeg = Math.Round(laMCuota(k + 1), 2)
        Else
            lnUltPos = Math.Round(laMCuota(k + 1), 2)
            lnUltNeg = Math.Round(laMCuota(k), 2)
        End If
        '*--- Calculo de 3ra apoximacion ---*
        k = k + 2

        'Modificado Cuota Fija, Especial Mexico 18/08/2014
        If ncuota > 0 Then
            laMCuota(k) = Math.Round(ncuota, 2)
        Else
            laMCuota(k) = Math.Round((laMCuota(k - 2) + laMCuota(k - 1)) / 2, 2)
        End If

        '*--- Loop de aproximaciones por mitad ---*

        For i = 3 To C_MAXITER - 1
            laDifCap(k) = Math.Round(xmCalCuoFija(laMCuota(k), pnMonDes, pcFlat, pcTipEst, _
                         pcCodFor, pcTipCuo, dsPlan), 2)
            laSigno(k) = xmDetSigno(lnDelMin, laDifCap(k))
            If Math.Abs(laMCuota(k) - laMCuota(k - 1)) <= (pnMonMin / 2) Then
                '*--- Fin por epsilon minimo ---*
                j = 1
                lnMinimo = Math.Abs(laDifCap(j))
                '*--- Busca laDifCap[x] minimo ---*
                Dim i1 As Integer
                For i1 = (j + 1) To k
                    If Math.Abs(laDifCap(i1)) < lnMinimo Then
                        lnMinimo = Math.Abs(laDifCap(i1))
                        j = i1
                    End If
                Next
                laDifCap(k) = Math.Round(xmCalCuoFija(laMCuota(j), pnMonDes, pcFlat, pcTipEst, _
                              pcCodFor, pcTipCuo, dsPlan), 2)
                Return xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, pcTipCuo, dsPlan)

            End If
            If laSigno(k) = 0 Then
                '*--- Salida por llegar al delta minimo ---*
                lnFlag = 1
                Exit For
            End If
            If laSigno(k) > 0 Then
                lnUltPos = Math.Round(laMCuota(k), 2)
            Else
                lnUltNeg = Math.Round(laMCuota(k), 2)
            End If
            k = k + 1
            laMCuota(k) = Math.Round((lnUltPos + lnUltNeg) / 2, 2)
        Next
        If lnFlag = 1 Then
            '   *--- Salida por llegar al lnDelMin ---*
            Return xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, pcTipCuo, dsPlan)
        End If
        '*--- Salida por llegar al maximo No. iteraciones ---*
        xmAjustar(pnMonDes, pcFlat, pcTipEst, pcCodFor, pcTipCuo, dsPlan)
    End Function

    'calcula interes y otros costos ver modificacion para habitat
    Public Function xmCalCuoFija(ByVal pMCuota As Double, ByVal pnMonDes As Double, ByVal pcFlat As String, _
    ByVal pcTipEst As String, ByVal pcCodFor As String, ByVal pcTipCuo As String, ByRef dsPlan As DataSet) As Double
        Dim lnCapAnt, lnCapCuo, lnSalCap, lnSumCap, lnMCuota, lnTasaEf, lnIntere, _
           lnRegAju, lnDelCap, pnCapita As Double
        Dim lcTipOpe As String
        Dim laPag, lnNumPag, lnNumPag1 As Integer
        lnSalCap = pnMonDes
        Dim Fila As DataRow
        Dim nCanti1 As Integer = 0
        Dim nNumCuo As Integer = 0
        Dim lncuocap As Integer = 1
        pnCapita = pnMonDes
        nCanti1 = dsPlan.Tables(0).Rows.Count()
        nNumCuo = dsPlan.Tables(0).Rows.Count()
        If nCanti1 = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        nCanti1 = 0
        For Each Fila In dsPlan.Tables(0).Rows
            If dsPlan.Tables(0).Rows(nCanti1)("cTipOpe") = "N" Then
                dsPlan.Tables(0).Rows(nCanti1)("nMCuota") = pMCuota
            End If
            nCanti1 = nCanti1 + 1
        Next
        lnNumPag1 = 0
        lnNumPag = 1
        lnCapCuo = 0
        lnSumCap = 0
        nCanti1 = 0
        Dim lcTipOpe1 As String
        For Each Fila In dsPlan.Tables(0).Rows
            If Fila("cTipOpe") = "N" Or Fila("cTipOpe") = "M" Then
                lnMCuota = dsPlan.Tables(0).Rows(nCanti1)("nMCuota")
                lnTasaEf = dsPlan.Tables(0).Rows(nCanti1)("nTasaEf")
                If pcFlat = "F" Then
                    lnIntere = Math.Round(Math.Round(pnCapita * lnTasaEf, 2), 2)
                Else
                    lnIntere = Math.Round(Math.Round(lnSalCap * lnTasaEf, 2), 2)
                End If
                '   *--- Calcula Capital y Saldo de Capital ---*
                If lnMCuota >= lnIntere Then
                    lcTipOpe1 = dsPlan.Tables(0).Rows(nCanti1)("cTipOpe")

                    If lcTipOpe1 = "N" Or lcTipOpe1 = "M" Then
                        If dsPlan.Tables(0).Rows(nCanti1)("nflag") = 1 Then
                            lnCapCuo = Math.Round(lnMCuota - lnIntere, 2)
                        Else
                            dsPlan.Tables(0).Rows(nCanti1)("nMCuota") = lnIntere
                            lnMCuota = lnIntere
                            lnCapCuo = 0
                        End If


                    End If
                End If
                If lnMCuota < lnIntere Then
                    lnMCuota = lnIntere
                    lnCapCuo = Math.Round(lnMCuota - lnIntere, 2)
                End If
                If lnNumPag < 1 And pcCodFor = "2" Then 'pcTipEst
                    lnCapCuo = 0
                    lnMCuota = lnIntere
                End If
                If lnNumPag = 1 And pcCodFor = "2" Then ' pcTipEst
                    lnMCuota = lnMCuota
                    lnCapCuo = lnCapCuo
                    lnNumPag = 0
                End If
                If pcTipCuo = "2" Then
                    lnCapCuo = 0
                    lnMCuota = lnIntere
                End If
                If pcTipCuo = "3" Or pcTipCuo = "6" Then
                    If dsPlan.Tables(0).Rows(nCanti1)("nflag") = 1 Then
                        Select Case Me.cfreccap
                            Case "A"
                                lncuocap = nNroCuo
                            Case "B"
                                lncuocap = nNroCuo
                            Case "D"
                                lncuocap = nNroCuo
                            Case "E"
                                If cfreccap = cfrecint Then
                                    lncuocap = nNroCuo
                                Else
                                    lncuocap = Math.Round(nNroCuo / 6, 0)
                                End If
                            Case "N"
                                If cfreccap = cfrecint Then
                                    lncuocap = nNroCuo
                                Else
                                    lncuocap = Math.Round(nNroCuo / 12, 0)
                                End If

                            Case "I"
                                If cfreccap = cfrecint Then
                                    lncuocap = nNroCuo
                                Else
                                    lncuocap = Math.Round(nNroCuo / 2, 0)
                                End If

                            Case "M"
                                lncuocap = nNroCuo
                            Case "S"
                                lncuocap = nNroCuo
                            Case "T"
                                If cfreccap = cfrecint Then
                                    lncuocap = nNroCuo
                                Else
                                    lncuocap = Math.Round(nNroCuo / 3, 0)
                                End If

                            Case "C"
                                If cfreccap = cfrecint Then
                                    lncuocap = nNroCuo
                                Else
                                    lncuocap = Math.Round(nNroCuo / 4, 0)
                                End If

                        End Select
                        lnMCuota = Math.Round(pnCapita / (lncuocap) + lnIntere, 2) 'laPag
                        lnCapCuo = Math.Round(pnCapita / (lncuocap), 2) 'laPag
                    End If

                End If
                lnSalCap = Math.Round(lnSalCap - lnCapCuo, 2)
                lnSumCap = Math.Round(lnSumCap + lnCapCuo, 2)
                dsPlan.Tables(0).Rows(nCanti1)("nCapita") = lnCapCuo
                dsPlan.Tables(0).Rows(nCanti1)("nMCuota") = lnMCuota
                dsPlan.Tables(0).Rows(nCanti1)("nSalCap") = lnSalCap
                dsPlan.Tables(0).Rows(nCanti1)("nIntere") = Math.Round(lnIntere, 2)
                lnNumPag = lnNumPag + 1
                lnNumPag1 = lnNumPag1 + 1
            End If
            nCanti1 = nCanti1 + 1
        Next
        lnDelCap = Math.Round((pnCapita - lnSumCap), 2)
        Return lnDelCap
    End Function

    Public Function xmDetSigno(ByVal pnDelMin As Double, ByVal pnMonto As Double) As Integer
        Dim lnSigno As Integer
        Dim NumAbs As Double
        If pnMonto > 0 Then
            lnSigno = 1
            NumAbs = pnMonto
        Else
            lnSigno = -1
            NumAbs = pnMonto * (-1)
        End If
        If pnDelMin >= NumAbs Then
            lnSigno = 0
        End If
        Return lnSigno
    End Function

    Public Function xmAjustar(ByVal pnCapita As Double, ByVal pcFlat As String, ByVal pcTipEst As String, _
    ByVal pcCodFor As Integer, ByVal pcTipCuo As Integer, ByRef dsPlan As DataSet)
        Dim lnFlag, nCanti, nReg As Integer
        Dim lnSalCap, lnIntere, lnTasaEf, lnMCuota, lnCuoRed, lnCapCuo, lnIntRed As Double
        Dim lcTipOpe As String
        Dim pnMonMin As Double = 0.01
        Dim lnNumPag As Integer = 1
        Dim lnNumPag1 As Integer = 0
        Dim laPAg As Integer = 0
        Dim lnRegAju As Integer = 0
        Dim lncuocap As Integer = 1
        lnFlag = 0
        lnSalCap = pnCapita
        nCanti = dsPlan.Tables(0).Rows.Count()
        nReg = dsPlan.Tables(0).Rows.Count() - 1
        If nCanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        laPAg = nCanti - 1
        Dim Fila As DataRow
        nCanti = 0
        For Each Fila In dsPlan.Tables(0).Rows
            lcTipOpe = dsPlan.Tables(0).Rows(nCanti)("cTipOpe")
            lnTasaEf = dsPlan.Tables(0).Rows(nCanti)("nTasaEf")
            If lcTipOpe <> "D" Then
                If pcFlat = "F" Then
                    lnIntere = Math.Round(Math.Round(pnCapita * lnTasaEf, 2), 2)
                Else
                    lnIntere = Math.Round(Math.Round(lnSalCap * lnTasaEf, 2), 2)
                End If
                lnMCuota = dsPlan.Tables(0).Rows(nCanti)("nMCuota")
                If pcFlat = "F" Then
                    lnCuoRed = Math.Round(lnMCuota, 2)
                Else
                    lnCuoRed = lnMCuota
                End If
                If lnCuoRed < lnMCuota Then
                    lnCuoRed = lnCuoRed + pnMonMin
                End If
                '*--- Calcula capital, interes y saldo de capital ---*
                If lnCuoRed >= lnIntere And (lcTipOpe = "N" Or lcTipOpe = "M") Then
                    lnCapCuo = lnCuoRed - lnIntere
                Else
                    If pcFlat = "F" Then
                        lnIntRed = Math.Round(lnIntere, 2)
                    Else
                        lnIntRed = lnIntere
                    End If
                    If lnIntRed < lnIntere Then
                        lnIntRed = lnIntRed + pnMonMin
                    End If
                    lnCuoRed = lnIntRed
                    lnCapCuo = lnCuoRed - lnIntere
                End If
                If lnNumPag < 1 And pcCodFor = "2" Then
                    lnCapCuo = 0
                    lnMCuota = lnIntere
                End If
                If lnNumPag = 1 And pcCodFor = "2" Then
                    lnMCuota = lnMCuota
                    lnCapCuo = lnCapCuo
                    lnNumPag = 0
                End If
                If pcTipCuo = "2" Then
                    lnCapCuo = 0
                    lnMCuota = lnIntere
                End If
                'If pcTipCuo = "3" Or pcTipCuo = "6" Then
                '    Select Case Me.cfreccap
                '        Case "A"
                '            lncuocap = laPAg
                '        Case "B"
                '            lncuocap = laPAg
                '        Case "D"
                '            lncuocap = laPAg
                '        Case "E"
                '            lncuocap = Math.Round(laPAg / 6, 0)
                '        Case "I"
                '            lncuocap = Math.Round(laPAg / 2, 0)
                '        Case "M"
                '            lncuocap = laPAg
                '        Case "S"
                '            lncuocap = laPAg
                '        Case "T"
                '            lncuocap = Math.Round(laPAg / 3, 0)
                '        Case "C"
                '            lncuocap = Math.Round(laPAg / 4, 0)
                '    End Select

                '    lnMCuota = pnCapita / lncuocap + lnIntere
                '    lnCapCuo = pnCapita / lncuocap
                'End If
                lnSalCap = lnSalCap - lnCapCuo
                dsPlan.Tables(0).Rows(nCanti)("nCapita") = lnCapCuo
                dsPlan.Tables(0).Rows(nCanti)("nMCuota") = lnCuoRed
                dsPlan.Tables(0).Rows(nCanti)("nSalCap") = lnSalCap
                dsPlan.Tables(0).Rows(nCanti)("nIntere") = lnIntere
                lnNumPag = lnNumPag + 1
                lnNumPag1 = lnNumPag1 + 1
            End If
            nCanti = nCanti + 1
        Next
        '*--- Evalua negativos ---*
        nCanti = 0
        Dim nControl As Integer = 0
        Dim lcNroCuo As String
        For Each Fila In dsPlan.Tables(0).Rows
            lnSalCap = dsPlan.Tables(0).Rows(nCanti)("nSalCap")
            lnCuoRed = dsPlan.Tables(0).Rows(nCanti)("nMCuota")
            lnCapCuo = dsPlan.Tables(0).Rows(nCanti)("nCapita")
            lcTipOpe = dsPlan.Tables(0).Rows(nCanti)("cTipOpe")
            lcNroCuo = dsPlan.Tables(0).Rows(nCanti)("cNroCuo")
            If lnSalCap < 0 And lcTipOpe <> "D" And lnFlag = 0 Then
                lnCapCuo = lnCapCuo + lnSalCap
                lnCuoRed = lnCuoRed + lnSalCap
                lnSalCap = 0
                dsPlan.Tables(0).Rows(nCanti)("nCapita") = lnCapCuo
                dsPlan.Tables(0).Rows(nCanti)("nMCuota") = lnCuoRed
                dsPlan.Tables(0).Rows(nCanti)("nSalCap") = lnSalCap
                lnFlag = 1
                lnRegAju = nCanti + 1
                nControl = nCanti
                Exit For
            End If
            nCanti = nCanti + 1
        Next
        '*--- Hubo saldo de capital negativo, se cerea siguientes cuotas ---*
        If lnFlag = 1 Then
            nCanti = 0
            'For Each Fila In dsPlan.Tables(0).Rows
            'If nCanti = nControl Then
            '             dsPlan.Tables(0).Rows(nCanti)("nCapita") = 0
            '            dsPlan.Tables(0).Rows(nCanti)("nMCuota") = 0
            '           dsPlan.Tables(0).Rows(nCanti)("nSalCap") = 0
            '          dsPlan.Tables(0).Rows(nCanti)("nIntere") = 0
            ' End If
            'nCanti = nCanti + 1
            '   Next
            Dim i2 As Integer = 0
            For i2 = lnRegAju To nControl
                dsPlan.Tables(0).Rows(i2)("nCapita") = 0
                dsPlan.Tables(0).Rows(i2)("nMCuota") = 0
                dsPlan.Tables(0).Rows(i2)("nSalCap") = 0
                dsPlan.Tables(0).Rows(i2)("nIntere") = 0
            Next
        Else
            lnSalCap = dsPlan.Tables(0).Rows(nReg)("nSalCap")
            lnCuoRed = dsPlan.Tables(0).Rows(nReg)("nMCuota")
            lnCapCuo = dsPlan.Tables(0).Rows(nReg)("nCapita")
            lcTipOpe = dsPlan.Tables(0).Rows(nReg)("cTipOpe")
            If lnSalCap > 0 Then
                lnCapCuo = lnCapCuo + lnSalCap
                lnCuoRed = lnCuoRed + lnSalCap
                lnSalCap = 0
                dsPlan.Tables(0).Rows(nReg)("nCapita") = lnCapCuo
                dsPlan.Tables(0).Rows(nReg)("nMCuota") = lnCuoRed
                dsPlan.Tables(0).Rows(nReg)("nSalCap") = lnSalCap
            End If
        End If
    End Function

    ' Genera siguiente fecha indicando un dia fijo
    Public Function fxNextFixedDay(ByVal p_dFecPro As Date, ByVal p_nPerDia As Integer) As Date
        Try
            Dim lnMesPro As Integer
            Dim lnAnoPro As Integer
            Dim lnPerDia As Integer
            Dim ldFecPro As Date
            Dim lcFecArm As Date
            Dim i As Integer

            lnPerDia = p_nPerDia
            lnMesPro = Month(p_dFecPro)
            lnAnoPro = Year(p_dFecPro)
            If lnMesPro = 12 Then
                lnMesPro = 1
                lnAnoPro += 1
            Else
                lnMesPro += 1
            End If
            For i = 1 To 30
                If lnMesPro = 2 And (lnPerDia >= 28 And lnPerDia <= 31) Then
                    Dim lcanobis As String
                    lcanobis = lnAnoPro.ToString.Trim
                    If lcanobis = "2008" Or lcanobis = "2012" Or lcanobis = "2016" Or lcanobis = "2020" _
                    Or lcanobis = "2024" Or lcanobis = "2028" Or lcanobis = "2032" Then
                        ldFecPro = CDate(lnAnoPro.ToString.Trim & "/" & fxStrZero(lnMesPro, 2) _
                                            & "/" & fxStrZero(29, 2))
                    Else
                        ldFecPro = CDate(lnAnoPro.ToString.Trim & "/" & fxStrZero(lnMesPro, 2) _
                                            & "/" & fxStrZero(28, 2))

                    End If

                Else
                    If lnPerDia = 31 And (lnMesPro = 2 Or lnMesPro = 4 Or lnMesPro = 6 Or lnMesPro = 9 _
                                          Or lnMesPro = 11) Then
                    Else
                        ldFecPro = CDate(lnAnoPro.ToString.Trim & "/" & fxStrZero(lnMesPro, 2) _
                           & "/" & fxStrZero(lnPerDia, 2))
                    End If
                    ' ldFecPro = CDate(lnMesPro.ToString & "/" & fxStrZero(lnPerDia, 2) & "/" & lnAnoPro.ToString.Trim)
                End If
                If Month(ldFecPro) = lnMesPro Then
                    Exit For
                End If
                lnPerDia = lnPerDia - 1
            Next i
            Return ldFecPro
        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            '   MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
    End Function


    Public Sub PlanTeorico(ByVal dsTeorico As DataTable, ByVal pcCodCreplan As String)
        '      Try
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl
        Dim Filapt As DataRow
        Dim nElem As Integer

        Dim MyDate As DateTime
        MyDate = Today
        Dim nCanti3 As Integer
        nCanti3 = dsTeorico.Rows.Count()
        eCredtpl.EliminarCredtpl(pcCodCreplan)
        nElem = 0
        For Each Filapt In dsTeorico.Rows
            If IsDBNull(Filapt("ngastos")) Then
                Filapt("ngastos") = 0
            End If
            entidadCredtpl.ccodcta = pcCodCreplan
            entidadCredtpl.ccodusu = ""
            entidadCredtpl.cflag = ""
            entidadCredtpl.cnrocuo = Filapt("cNroCuo")
            entidadCredtpl.ctipope = Filapt("cTipOpe")
            entidadCredtpl.dfecmod = MyDate
            entidadCredtpl.dfecven = Filapt("dFecPro")
            entidadCredtpl.lefectu = 0
            entidadCredtpl.ncapita = Math.Round(Filapt("nCapita"), 2)
            entidadCredtpl.nintere = Math.Round(Filapt("nIntere"), 2)
            entidadCredtpl.ntasint = Math.Round(Filapt("nTasaIn"), 2)
            entidadCredtpl.ngastos = Math.Round(Filapt("ngastos"), 2)
            entidadCredtpl.nsegdeu = Math.Round(Filapt("nSegdeu"), 2)

            If Filapt("cNroCuo") = "001" _
               And Filapt("cTipOpe") = "N" Then
                Me.pnmonCuo = Math.Round(Filapt("nCapita"), 2) + _
                Math.Round(Filapt("nIntere"), 2) + _
                Math.Round(Filapt("ngastos"), 2) + _
                Math.Round(Filapt("nSegDeu"), 2)

            End If
            eCredtpl.AgregarCredtpl(entidadCredtpl)
            nElem = nElem + 1
        Next

        '     Catch ex As Exception

        '    End Try
    End Sub
    Public Sub Graba_SugerenciaTmp()
        Dim entidadcremcre As New SIM.EL.cremcre
        Dim ecremcre As New SIM.BL.cCremcre
        entidadcremcre.ccodcta = Me.pcCodCre
        entidadcremcre.nmonsug = Me.nMonDes
        entidadcremcre.cestado = "C"
        entidadcremcre.ncuosug = Me.nNroCuo
        entidadcremcre.ncuosug0 = Me.nNroCuo0
        entidadcremcre.ctipper = Me.cCodFor
        entidadcremcre.nmeses = Me.nMeses
        entidadcremcre.ndiasug = Me.nPerDia
        entidadcremcre.ntasint = Me.nTasInt
        entidadcremcre.ctipcuo = Me.cTipCuo
        entidadcremcre.ccodrec = Me.cCodRec
        entidadcremcre.ccodfue = Me.cCodfue
        entidadcremcre.cnrolin = Me.cNrolin
        entidadcremcre.dfecmod = Today()
        entidadcremcre.ccodusu = Me.pcCodUsu
        entidadcremcre.dfecven = Me.dFecVen
        entidadcremcre.ndiagra = Me.nDiaGra
        entidadcremcre.cflat = Me.cFlat
        entidadcremcre.ccodact = Me.cCodact
        entidadcremcre.nprima = Me.gnprima
        entidadcremcre.ncosdir = Me.gncosdir
        entidadcremcre.ncosind = Me.gncosind
        entidadcremcre.nahoprg = Me.gnsubcidio
        entidadcremcre.dfecapr = Me.dFecDes
        entidadcremcre.dfecvig = Me.dFecDes
        entidadcremcre.dfectra = Me.gdfeccuo
        entidadcremcre.nmoncuo = Me.gnmoncuo
        entidadcremcre.ctipcon = Me.pctipcon
        entidadcremcre.cfreccap = Me.cfreccap
        entidadcremcre.cfrecint = Me.cfrecint
        entidadcremcre.lsegvid = Me.lsegvid
        entidadcremcre.ccapacidad = Me.cCapacidad
        entidadcremcre.canalisis = Me.canalisis
        ecremcre.ActualizarCremcreSug(entidadcremcre)

    End Sub

    Public Sub Graba_Sugerencia()
        'cremcre
        Dim entidadcremcre As New SIM.EL.cremcre
        Dim ecremcre As New SIM.BL.cCremcre
        entidadcremcre.ccodcta = Me.pcCodCre
        ecremcre.ObtenerCremcre(entidadcremcre)
        entidadcremcre.nmonsug = Me.nMonDes
        entidadcremcre.nmonapr = Me.nMonDes
        entidadcremcre.cestado = "C"
        entidadcremcre.ncuosug = Me.nNroCuo
        entidadcremcre.ncuosug0 = Me.nNroCuo0

        entidadcremcre.ctipper = Me.cCodFor
        entidadcremcre.nmeses = Me.nMeses
        entidadcremcre.ndiasug = Me.nPerDia
        entidadcremcre.ntasint = Me.nTasInt
        entidadcremcre.ctipcuo = Me.cTipCuo
        entidadcremcre.ccodrec = Me.cCodRec
        entidadcremcre.ccodfue = Me.cCodfue
        entidadcremcre.cnrolin = Me.cNrolin
        entidadcremcre.dfecmod = Today()
        entidadcremcre.ccodusu = Me.pcCodUsu
        entidadcremcre.dfecven = Me.dFecVen
        entidadcremcre.ndiagra = Me.nDiaGra
        entidadcremcre.cflat = Me.cFlat
        entidadcremcre.ccodact = Me.cCodact
        entidadcremcre.nprima = Me.gnprima
        entidadcremcre.ncosdir = Me.gncosdir
        entidadcremcre.ncosind = Me.gncosind
        entidadcremcre.nahoprg = Me.gnsubcidio
        entidadcremcre.dfecapr = Me.dFecDes
        entidadcremcre.dfecvig = Me.dFecDes
        entidadcremcre.dfectra = Me.gdfeccuo
        entidadcremcre.nmoncuo = Me.gnmoncuo

        entidadcremcre.ctipcon = Me.pctipcon

        entidadcremcre.cfreccap = Me.cfreccap
        entidadcremcre.cfrecint = Me.cfrecint

        entidadcremcre.lsegvid = Me.lsegvid
        entidadcremcre.ccapacidad = Me.cCapacidad
        entidadcremcre.canalisis = Me.canalisis
        ecremcre.ActualizarCremcreSug(entidadcremcre)
    End Sub
    Public Sub Graba_Propuesta()
        'elimina propuesta actual
        Dim epropuesta As New cPROPUESTA
        Dim entidadpropuesta As New PROPUESTA

        entidadpropuesta.ccodcta = pcCodCre
        entidadpropuesta.ccodusu = pcCodUsu

        epropuesta.EliminarPROPUESTA(entidadpropuesta)

        entidadpropuesta.cestado = "C"
        entidadpropuesta.nmonsug = Me.nMonDes
        entidadpropuesta.ncuosug = Me.nNroCuo
        entidadpropuesta.ctipper = Me.cCodFor
        entidadpropuesta.nmeses = Me.nMeses
        entidadpropuesta.ndiasug = Me.nPerDia
        entidadpropuesta.ntasint = Me.nTasInt
        entidadpropuesta.ctipcuo = Me.cTipCuo
        entidadpropuesta.cnrolin = Me.cNrolin
        entidadpropuesta.dfecmod = Now
        entidadpropuesta.ccodana = Me.ccodana
        entidadpropuesta.dfecven = Me.dFecVen
        entidadpropuesta.ndiagra = Me.nDiaGra
        entidadpropuesta.cflat = Me.cFlat
        entidadpropuesta.dfecapr = Me.dFecDes
        entidadpropuesta.dfecvig = Me.dFecDes
        entidadpropuesta.nmoncuo = Me.gnmoncuo
        entidadpropuesta.cfreccap = Me.cfreccap
        entidadpropuesta.cfrecint = Me.cfrecint

        entidadpropuesta.cprograma = Me.cprograma
        entidadpropuesta.cdescre = Me.cDescre
        entidadpropuesta.csececo = Me.csececo
        entidadpropuesta.ccodfue = Me.cCodfue
        entidadpropuesta.cflag = ""

        Try
            epropuesta.Agregar(entidadpropuesta)
        Catch ex As Exception

        End Try



    End Sub

    Public Sub grabaInfoConavi(ByVal ccodcta As String, ByVal txtInfoConavi As String)
        Dim ecremcre As New SIM.BL.cCremcre
        If (ccodcta <> "" And txtInfoConavi <> "") Then
            ecremcre.updateInfoConavi(ccodcta, txtInfoConavi)
        End If


    End Sub

    Public Sub Graba_Aprobacion(ByVal status As String)
        'cremcre
        Dim entidadcremcre As New SIM.EL.cremcre
        Dim ecremcre As New SIM.BL.cCremcre
        entidadcremcre.ccodcta = Me.pcCodCre
        ecremcre.ObtenerCremcre(entidadcremcre)
        entidadcremcre.nmonapr = Me.nMonDes
        entidadcremcre.cestado = status
        entidadcremcre.ncuoapr = Me.nNroCuo
        entidadcremcre.ctipper = Me.cCodFor
        entidadcremcre.nmeses = Me.nMeses
        entidadcremcre.ndiasug = Me.nPerDia
        entidadcremcre.ntasint = Me.nTasInt
        entidadcremcre.ctipcuo = Me.cTipCuo
        entidadcremcre.ccodrec = Me.cCodRec
        entidadcremcre.ccodfue = Me.cCodfue
        entidadcremcre.cnrolin = Me.cNrolin
        entidadcremcre.dfecmod = Today()
        entidadcremcre.ccodusu = Me.pcCodUsu
        entidadcremcre.dfecven = Me.dFecVen
        entidadcremcre.ndiagra = Me.nDiaGra
        entidadcremcre.cflat = Me.cFlat
        entidadcremcre.dfecapr = Me.dFecApr
        entidadcremcre.nprima = Me.gnprima
        entidadcremcre.ncosind = Me.gncosind 'Me.gntotcosind
        entidadcremcre.nahoprg = Me.gnsubcidio
        entidadcremcre.ncosdir = Me.gncosdir
        entidadcremcre.dfecapr = Me.dFecApr
        entidadcremcre.dfectra = Me.gdfeccuo
        entidadcremcre.nmoncuo = Me.gnmoncuo
        entidadcremcre.lsegvid = Me.lsegvid
        entidadcremcre.ncuosug0 = Me.nNroCuo0
        entidadcremcre.ctipcon = Me.pctipcon
        entidadcremcre.cacta = Me.cacta
        entidadcremcre.cresolucion = Me.cresolucion
        entidadcremcre.codigo_nivel_aprobacion = Me.codigo_nivel_aprobacion
        entidadcremcre.usuario_aprobacion = Me.usuario_aprobacion

        ecremcre.ActualizarCremcreApr(entidadcremcre)
    End Sub
    Public Function Plan_Print(ByVal dsplain As DataSet) As DataTable
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DataPlain As New DataSet
        Dim nElem As Integer
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable
        Dim lnTasa As Double
        'Dim dsPlain As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        lCampos1 = "dfecpro, Fecha, Operacion, N_Cuota, nmcuota, Capital, Interes, Gastos, Saldo, nsegdeu, nsegdan, nresinc, ntalona, notrpag, ncapita, nintere, dfecven, ctipope, cnrocuo,nsalcap,"
        lTipos1 = "F,F,S,S,D,D,D,D,D,D,D,D,D,D,D,D,F,S,S,D,"
        DT = creadatasetdesconec(lCampos1, lTipos1, "PlanTeo")
        nElem = 0
        Dim i As Integer
        Dim fila As DataRow
        DT.Clear()
        Dim dFecCon As Date
        DR = DT.NewRow
        Dim lnSaldo As Decimal = 0
        For Each fila In dsplain.Tables(0).Rows
            DR = DT.NewRow
            dFecCon = dsplain.Tables(0).Rows(nElem)("dFecPro")
            DR("Fecha") = dFecCon 'dFecCon.ToString.Substring(0, 10)
            DR("dfecpro") = dFecCon 'dFecCon.ToString.Substring(0, 10)
            DR("Operacion") = dsplain.Tables(0).Rows(nElem)("cTipOpe")
            DR("ctipope") = dsplain.Tables(0).Rows(nElem)("cTipOpe")

            DR("N_Cuota") = dsplain.Tables(0).Rows(nElem)("cNroCuo")
            DR("cnrocuo") = dsplain.Tables(0).Rows(nElem)("cNroCuo")

            DR("dfecven") = dFecCon 'dFecCon.ToString.Substring(0, 10)
            DR("ctipope") = dsplain.Tables(0).Rows(nElem)("cTipOpe")
            DR("cnrocuo") = dsplain.Tables(0).Rows(nElem)("cNroCuo")

            If dsplain.Tables(0).Rows(nElem)("cTipOpe") = "D" Then
                DR("nmcuota") = 0
            Else
                DR("nmcuota") = IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nCapita")), 0, dsplain.Tables(0).Rows(nElem)("nCapita")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nintere")), 0, dsplain.Tables(0).Rows(nElem)("nintere")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nsegdeu")), 0, dsplain.Tables(0).Rows(nElem)("nsegdeu")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nsegdan")), 0, dsplain.Tables(0).Rows(nElem)("nsegdan")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nresinc")), 0, dsplain.Tables(0).Rows(nElem)("nresinc")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("ntalona")), 0, dsplain.Tables(0).Rows(nElem)("ntalona")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("notrpag")), 0, dsplain.Tables(0).Rows(nElem)("notrpag")) + _
                IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("ngastos")), 0, Math.Round(dsplain.Tables(0).Rows(nElem)("ngastos"), 2))
            End If
            DR("Capital") = dsplain.Tables(0).Rows(nElem)("nCapita")
            DR("ncapita") = dsplain.Tables(0).Rows(nElem)("nCapita")
            DR("Interes") = dsplain.Tables(0).Rows(nElem)("nIntere")
            DR("nintere") = dsplain.Tables(0).Rows(nElem)("nIntere")
            'DR("Gastos") = dsplain.Tables(0).Rows(nElem)("nGastos")
            DR("ncapita") = dsplain.Tables(0).Rows(nElem)("nCapita")
            DR("nintere") = dsplain.Tables(0).Rows(nElem)("nIntere")


            DR("nsegdeu") = Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nsegdeu")), 0, dsplain.Tables(0).Rows(nElem)("nsegdeu")), 2)

            DR("nsegdan") = Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nsegdan")), 0, dsplain.Tables(0).Rows(nElem)("nsegdan")), 2)
            DR("nresinc") = Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("nresinc")), 0, dsplain.Tables(0).Rows(nElem)("nresinc")), 2)
            DR("ntalona") = Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("ntalona")), 0, dsplain.Tables(0).Rows(nElem)("ntalona")), 2)
            DR("notrpag") = Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("notrpag")), 0, dsplain.Tables(0).Rows(nElem)("notrpag")), 2)
            DR("Gastos") = Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("ngastos")), 0, dsplain.Tables(0).Rows(nElem)("ngastos")), 2)


            If dsplain.Tables(0).Rows(nElem)("cTipOpe") = "D" Then
                lnSaldo = lnSaldo + dsplain.Tables(0).Rows(nElem)("nCapita")
                DR("Capital") = 0
            Else
                lnSaldo = lnSaldo - dsplain.Tables(0).Rows(nElem)("nCapita")
            End If

            DR("Saldo") = Math.Round(lnSaldo, 2) 'Math.Round(IIf(IsDBNull(dsplain.Tables(0).Rows(nElem)("saldo")), 0, dsplain.Tables(0).Rows(nElem)("saldo")), 2)
            DR("nsalcap") = Math.Round(lnSaldo, 2)
            DT.Rows.Add(DR)
            nElem = nElem + 1
        Next
        DataPlain.Tables.Add(DT)
        Return DT
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Function
    Public Sub PlanTeoricoppg(ByVal dsTeorico As DataSet, ByVal pcCodCreplan As String)
        '      Try
        Dim entidadCredppg As New SIM.EL.credppg
        Dim eCredppg As New SIM.BL.cCredppg
        Dim Filapt As DataRow
        Dim nElem As Integer
        Dim MyDate As DateTime
        MyDate = Today
        Dim nCanti3 As Integer
        nCanti3 = dsTeorico.Tables(0).Rows.Count()
        eCredppg.EliminarCredppg(pcCodCreplan)
        nElem = 0
        For Each Filapt In dsTeorico.Tables(0).Rows
            entidadCredppg.ccodcta = pcCodCreplan
            entidadCredppg.ccodusu = ""
            entidadCredppg.cflag = ""
            entidadCredppg.cnrocuo = dsTeorico.Tables(0).Rows(nElem)("cNroCuo")
            entidadCredppg.ctipope = dsTeorico.Tables(0).Rows(nElem)("cTipOpe")
            entidadCredppg.dfecmod = MyDate
            entidadCredppg.dfecven = dsTeorico.Tables(0).Rows(nElem)("dFecPro")
            'entidadCredppg.lefectu = 0
            entidadCredppg.ncapita = Math.Round(dsTeorico.Tables(0).Rows(nElem)("nCapita"), 2)
            entidadCredppg.nintere = Math.Round(dsTeorico.Tables(0).Rows(nElem)("nIntere"), 2)
            'entidadCredppg.ngastos = math.round(dsTeorico.Tables(0).Rows(nElem)("ngastos"), 2)
            entidadCredppg.cestado = "E"
            entidadCredppg.ncappag = 0
            entidadCredppg.nintpag = 0
            entidadCredppg.nintmor = 0
            entidadCredppg.nmorpag = 0
            entidadCredppg.notrpag = 0
            entidadCredppg.dfecpag = MyDate

            'agrega gastos
            entidadCredppg.nsegdeu = Math.Round(dsTeorico.Tables(0).Rows(nElem)("nsegdeu"), 2)
            'entidadCredppg.nsegdan = math.round(dsTeorico.Tables(0).Rows(nElem)("nsegdan"), 2)
            'entidadCredppg.nresinc = math.round(dsTeorico.Tables(0).Rows(nElem)("nresinc"), 2)
            'entidadCredppg.ntalona = math.round(dsTeorico.Tables(0).Rows(nElem)("ntalona"), 2)
            entidadCredppg.ngastos = Math.Round(dsTeorico.Tables(0).Rows(nElem)("ngastos"), 2)

            'entidadCredppg.ntasint = math.round(dsTeorico.Tables(0).Rows(nElem)("nTasaIn"), 2)
            eCredppg.Agregar(entidadCredppg)
            nElem = nElem + 1
        Next
        '     Catch ex As Exception

        '    End Try
    End Sub
    Public Sub Graba_CambioCremcrePlan()
        'cremcre
        Dim entidadcremcre As New SIM.EL.cremcre
        Dim ecremcre As New SIM.BL.cCremcre
        entidadcremcre.ccodcta = Me.pcCodCre
        ecremcre.ObtenerCremcre(entidadcremcre)
        entidadcremcre.ncuoapr = Me.nNroCuo
        entidadcremcre.ctipper = Me.cCodFor
        entidadcremcre.nmeses = Me.nMeses
        entidadcremcre.ndiaapr = Me.nPerDia
        entidadcremcre.ntasint = Me.nTasInt
        entidadcremcre.ctipcuo = Me.cTipCuo
        entidadcremcre.cnrolin = Me.cNrolin
        entidadcremcre.dfecmod = Today()
        entidadcremcre.ccodusu = Me.pcCodUsu
        entidadcremcre.dfecven = Me.dFecVen
        entidadcremcre.ndiagra = Me.nDiaGra
        entidadcremcre.cflat = Me.cFlat
        entidadcremcre.nmoncuo = Me.nmoncuo

        entidadcremcre.nprima = Me.gnprima
        entidadcremcre.nahoprg = Me.gnsubcidio
        entidadcremcre.ncosdir = Me.gncosdir
        entidadcremcre.ncosind = Me.gncosind
        entidadcremcre.ncapdes = Me.nMonDes
        entidadcremcre.dfecvig = Me.dFecDes

        'graba fecha de primer pago en un campo disponibel DFECTRA
        entidadcremcre.dfectra = Me.gdfeccuo
        entidadcremcre.cfreccap = Me.cfreccap
        entidadcremcre.cfrecint = Me.cfrecint

        ecremcre.ActualizarPlan(entidadcremcre)
    End Sub
    Public Function Gravamen(ByVal ccodcta As String, ByVal ccodcli As String) As Double
        Dim dsg As New DataSet
        Dim nelem As Integer
        Dim entidadCrepgar As New SIM.EL.crepgar
        Dim eCrepgar As New SIM.BL.cCrepgar
        dsg = eCrepgar.ObtenerDataSetPorID(ccodcta, ccodcli)
        nelem = dsg.Tables(0).Rows.Count()
        If nelem = 0 Then  'En caso que no devuelva nada se sale
            Exit Function
        End If
        Dim fila As DataRow
        Dim lngravamen As Double = 0
        Dim lngrav As Double = 0
        nelem = 0
        For Each fila In dsg.Tables(0).Rows
            lngrav = dsg.Tables(0).Rows(nelem)("nMonGra")
            lngravamen = lngravamen + lngrav
            nelem = nelem + 1
        Next
        Return lngravamen
    End Function

    Public Function Verifica_Cuenta_Contable(ByVal pcCodCta As String, ByVal ccodigo As String) As Integer
        Dim entidadCtbmcta As New SIM.EL.ctbmcta
        Dim eCtbmcta As New SIM.BL.cCtbmcta
        Dim dsf As New DataSet
        Dim ncanti As Integer

        dsf = eCtbmcta.ObtenerDataSetPorCuenta(pcCodCta, ccodigo)

        ncanti = dsf.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Return 0
        Else
            Return 1
        End If

    End Function


    Public Function reportesahorros() As DataSet

        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsahorros As New DataSet
        Try
            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = cnnStr
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select climide.cnomcli, climide.ccodcli,climide.ccodpro,climide.csexo,climide.lactivo,ahomcta.ccodaho, ahomcta.dfecapr as dfecope, ahomcta.nsaldoaho, ahomcta.producto, tabtprf.cdescri, ahotlin.cdeslin, ahotlin.ntasint,00000000000.00 as nmonto from climide, ahomcta,  tabtprf, ahotlin where climide.ccodcli = ahomcta.ccodcli and climide.ccodpro = tabtprf.ccodigo and ahomcta.cnrolin = ahotlin.cnrolin"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(dsahorros, "repaho")
            Return dsahorros

        Catch ex As Exception

        End Try

    End Function

    'movimientos de ahorros
    Public Function reportesahorros_mov(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataSet

        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsahorros As New DataSet
        Try
            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = cnnStr
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select climide.cnomcli, climide.ccodcli,climide.ccodpro,climide.csexo,climide.lactivo,ahomcta.ccodaho, ahommov.nsaldoaho, ahommov.dfecope, ahomcta.producto, tabtprf.cdescri, ahotlin.cdeslin, ahotlin.ntasint, ahommov.nmonto from climide, ahomcta, tabtprf, ahotlin, ahommov where climide.ccodcli = ahomcta.ccodcli and climide.ccodpro = tabtprf.ccodigo and ahomcta.cnrolin = ahotlin.cnrolin and ahomcta.ccodaho = ahommov.ccodaho and ahommov.dfecope >= " & "'" & fecha1 & "'" & "and ahommov.dfecope <= " & "'" & fecha2 & "'"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(dsahorros, "repaho")
            Return dsahorros

        Catch ex As Exception

        End Try

    End Function


    'cartera a plazo
    Public Function reportesahorros_pla() As DataSet

        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsahorros As New DataSet
        Try
            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = cnnStr
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select climide.cnomcli, climide.ccodcli,climide.ccodpro,climide.csexo,climide.lactivo,ahomcrt.ccodcrt as ccodaho, ahomcrt.nsaldoaho, ahomcrt.dultpro, ' ' as cdeslin, dultpro as dfecope, ahomcrt.producto, tabtprf.cdescri, ahomcrt.ntasint, 0000000000.00 as nmonto from climide, ahomcrt,  tabtprf where climide.ccodcli = ahomcrt.ccodcli and climide.ccodpro = tabtprf.ccodigo "
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(dsahorros, "repaho")
            Return dsahorros

        Catch ex As Exception

        End Try

    End Function


    'pago de intereses de ahorros
    Public Function reportes_intereses_ahorros_pla(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataSet

        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsahorros As New DataSet
        Try
            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = cnnStr
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select climide.cnomcli, climide.ccodcli,climide.ccodpro,climide.csexo,climide.lactivo,ahomcrt.ccodcrt as ccodaho, ahomcrt.nsaldoaho, ahomcrt.dultpro, ' ' as cdeslin, ahomint.dfecpro as dfecope, ahomcrt.producto, tabtprf.cdescri, ahomcrt.ntasint, ahomint.nintere as nmonto from climide, ahomcrt, ahomint, tabtprf where climide.ccodcli = ahomcrt.ccodcli and ahomcrt.ccodcrt = ahomint.ccodcrt and climide.ccodpro = tabtprf.ccodigo and ahomint.dfecpro >= " & "'" & fecha1 & "'" & "and ahomint.dfecpro <= " & "'" & fecha2 & "'"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(dsahorros, "repaho")
            Return dsahorros

        Catch ex As Exception
        End Try

    End Function



    'sumario de ahorros
    'pago de intereses de ahorros
    Public Function reportes_intereses_ahorros(ByVal fecha1 As Date, ByVal fecha2 As Date) As DataSet

        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsahorros As New DataSet
        Try
            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = cnnStr
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select climide.cnomcli, climide.ccodcli,climide.ccodpro,climide.csexo,climide.lactivo,ahomcta.ccodaho, ahomcta.nsaldoaho, ahomaho.dfeccap as dultpro, ahotlin.cdeslin, ahomaho.dfeccap as dfecope, ahomcta.producto, tabtprf.cdescri, ahotlin.ntasint, ahomaho.nintere as nmonto from climide, ahomcta, ahotlin, ahomaho, tabtprf where climide.ccodcli = ahomcta.ccodcli and ahomcta.cnrolin = ahotlin.cnrolin and ahomcta.ccodaho = ahomaho.ccodaho and climide.ccodpro = tabtprf.ccodigo and ahomaho.dfeccap >= " & "'" & fecha1 & "'" & "and ahomaho.dfeccap <= " & "'" & fecha2 & "'"
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(dsahorros, "repaho")
            Return dsahorros

        Catch ex As Exception
        End Try

    End Function


    'OBTIENE LA CARTERA ACTUALIZADA POR OFICINA
    Public Function CARTERA_ACTUALIZADA_OFICINA(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String) As DataSet

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dtoficina As DataTable
        Dim clsprin As New class1
        Dim DSCARTERA As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsoficina As New DataSet
        Dim drcartera As DataRow
        Dim droficina As DataRow
        Dim categoria As String

        Dim mtabtofi As New cTabtofi
        Dim etabtofi As New tabtofi
        Dim lncapdes, lnsalcap, lnmora, lnsalint, lnsalmor, lnporc1, lnporc2 As Double
        lncapdes = lnsalcap = lnmora = lnsalint = lnsalmor = lnporc1 = lnporc2 = 0

        Dim cancela As String
        cancela = "0"
        dsoficina = mtabtofi.ObtenerDataSetPorID()

        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, "*", lczona)
        For Each droficina In dsoficina.Tables(0).Rows

            For Each drcartera In DSCARTERA.Tables(0).Rows
                If drcartera("coficina") = droficina("ccodofi") Then
                    lnporc1 = lnporc1 + 1
                    If drcartera("ndiaatr") > 0 Then
                        lnporc2 = lnporc2 + 1
                    End If
                    If IsDBNull(drcartera("nintteo")) Then
                        drcartera("nintteo") = 0
                    End If
                    If IsDBNull(drcartera("nintpag")) Then
                        drcartera("nintpag") = 0
                    End If
                    If IsDBNull(drcartera("ndifer")) Then
                        drcartera("ndifer") = 0
                    End If
                    'If IsDBNull(drcartera("ncosdir")) Then
                    '    drcartera("ncosdir") = 0
                    'End If
                    'If IsDBNull(drcartera("nprima")) Then
                    '    drcartera("nprima") = 0
                    'End If
                    If IsDBNull(drcartera("nahoprg")) Then
                        drcartera("nahoprg") = 0
                    End If
                    If IsDBNull(drcartera("tasa")) Then
                        drcartera("tasa") = 0
                    End If
                    If IsDBNull(drcartera("ncapita")) Then
                        drcartera("ncapita") = 0
                    End If
                    If IsDBNull(drcartera("ncappag")) Then
                        drcartera("ncappag") = 0
                    End If
                    If IsDBNull(drcartera("ncapdes")) Then
                        drcartera("ncapdes") = 0
                    End If

                    lncapdes = lncapdes + drcartera("ncapdes")
                    lnsalcap = lnsalcap + (drcartera("ncapdes") - drcartera("ncappag"))
                    If drcartera("ncapita") - drcartera("ncappag") > 0 Then
                        lnmora = lnmora + (drcartera("ncapita") - drcartera("ncappag"))
                    End If

                    lnsalint = lnsalint + drcartera("nsalint")
                End If
            Next

            droficina("ncapdes") = lncapdes
            droficina("nsalcap") = lnsalcap
            droficina("nmora") = lnmora
            droficina("nsalint") = lnsalint
            droficina("nsalmor") = lnsalmor
            droficina("nporc1") = lnporc1
            droficina("nporc2") = lnporc2

            lncapdes = 0
            lnsalcap = 0
            lnmora = 0
            lnsalint = 0
            lnsalmor = 0
            lnporc1 = 0
            lnporc2 = 0

        Next

        Return dsoficina

    End Function

    'OBTIENE LA CARTERA ACTUALIZADA POR FUENTE DE FONDOS
    Public Function CARTERA_ACTUALIZADA_FONDOS(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String) As DataSet

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dtoficina As DataTable
        Dim clsprin As New class1
        Dim DSCARTERA As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsoficina As New DataSet
        Dim drcartera As DataRow
        Dim droficina As DataRow
        Dim categoria As String

        Dim mfondos As New cTabttab
        Dim efondos As New tabttab
        Dim lncapdes, lnsalcap, lnmora, lnsalint, lnsalmor, lnporc1, lnporc2 As Double
        lncapdes = lnsalcap = lnmora = lnsalint = lnsalmor = lnporc1 = lnporc2 = 0

        Dim cancela As String
        Dim lccodfue As String
        cancela = "0"
        dsoficina = mfondos.ObtenerDataSetPorID("033", "1")

        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, "*", lczona)
        For Each droficina In dsoficina.Tables(0).Rows

            For Each drcartera In DSCARTERA.Tables(0).Rows
                If IsDBNull(drcartera("ccodfue")) Then
                    lccodfue = "01"
                Else
                    lccodfue = drcartera("ccodfue")
                End If
                If Trim(droficina("ccodigo")) = lccodfue Then
                    lnporc1 = lnporc1 + 1
                    If drcartera("ndiaatr") > 0 Then
                        lnporc2 = lnporc2 + 1
                    End If
                    If IsDBNull(drcartera("nintteo")) Then
                        drcartera("nintteo") = 0
                    End If
                    If IsDBNull(drcartera("nintpag")) Then
                        drcartera("nintpag") = 0
                    End If
                    If IsDBNull(drcartera("ndifer")) Then
                        drcartera("ndifer") = 0
                    End If
                    If IsDBNull(drcartera("nahoprg")) Then
                        drcartera("nahoprg") = 0
                    End If
                    If IsDBNull(drcartera("tasa")) Then
                        drcartera("tasa") = 0
                    End If
                    If IsDBNull(drcartera("ncapita")) Then
                        drcartera("ncapita") = 0
                    End If
                    If IsDBNull(drcartera("ncappag")) Then
                        drcartera("ncappag") = 0
                    End If
                    If IsDBNull(drcartera("ncapdes")) Then
                        drcartera("ncapdes") = 0
                    End If

                    lncapdes = lncapdes + drcartera("ncapdes")
                    lnsalcap = lnsalcap + (drcartera("ncapdes") - drcartera("ncappag"))
                    If drcartera("ncapita") - drcartera("ncappag") > 0 Then
                        lnmora = lnmora + (drcartera("ncapita") - drcartera("ncappag"))
                    End If
                    lnsalint = lnsalint + drcartera("nsalint")
                End If
            Next

            droficina("ncapdes") = lncapdes
            droficina("nsalcap") = lnsalcap
            droficina("nmora") = lnmora
            droficina("nsalint") = lnsalint
            droficina("nsalmor") = lnsalmor
            droficina("nporc1") = lnporc1
            droficina("nporc2") = lnporc2

            lncapdes = 0
            lnsalcap = 0
            lnmora = 0
            lnsalint = 0
            lnsalmor = 0
            lnporc1 = 0
            lnporc2 = 0

        Next

        Return dsoficina

    End Function


    'OBTIENE LA CARTERA ACTUALIZADA POR FUENTE DE FONDOS
    Public Function CARTERA_ACTUALIZADA_GENERO(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String) As DataSet

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dtoficina As DataTable
        Dim clsprin As New class1
        Dim DSCARTERA As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsoficina As New DataSet
        Dim drcartera As DataRow
        Dim droficina As DataRow
        Dim categoria As String

        Dim mfondos As New cTabttab
        Dim efondos As New tabttab
        Dim lncapdes, lnsalcap, lnmora, lnsalint, lnsalmor, lnporc1, lnporc2 As Double
        lncapdes = lnsalcap = lnmora = lnsalint = lnsalmor = lnporc1 = lnporc2 = 0

        Dim cancela As String
        cancela = "0"
        dsoficina = mfondos.ObtenerDataSetPorID("003", "1")

        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, "*", lczona)
        For Each droficina In dsoficina.Tables(0).Rows

            For Each drcartera In DSCARTERA.Tables(0).Rows
                If drcartera("csexo") = Trim(droficina("ccodigo")) Then
                    lnporc1 = lnporc1 + 1
                    If drcartera("ndiaatr") > 0 Then
                        lnporc2 = lnporc2 + 1
                    End If
                    If IsDBNull(drcartera("nintteo")) Then
                        drcartera("nintteo") = 0
                    End If
                    If IsDBNull(drcartera("nintpag")) Then
                        drcartera("nintpag") = 0
                    End If
                    If IsDBNull(drcartera("ndifer")) Then
                        drcartera("ndifer") = 0
                    End If
                    'If IsDBNull(drcartera("ncosdir")) Then
                    '    drcartera("ncosdir") = 0
                    'End If
                    'If IsDBNull(drcartera("nprima")) Then
                    '    drcartera("nprima") = 0
                    'End If
                    If IsDBNull(drcartera("nahoprg")) Then
                        drcartera("nahoprg") = 0
                    End If
                    If IsDBNull(drcartera("tasa")) Then
                        drcartera("tasa") = 0
                    End If
                    If IsDBNull(drcartera("ncapita")) Then
                        drcartera("ncapita") = 0
                    End If
                    If IsDBNull(drcartera("ncappag")) Then
                        drcartera("ncappag") = 0
                    End If
                    If IsDBNull(drcartera("ncapdes")) Then
                        drcartera("ncapdes") = 0
                    End If

                    lncapdes = lncapdes + drcartera("ncapdes")
                    lnsalcap = lnsalcap + (drcartera("ncapdes") - drcartera("ncappag"))
                    If drcartera("ncapita") - drcartera("ncappag") > 0 Then
                        lnmora = lnmora + (drcartera("ncapita") - drcartera("ncappag"))
                    End If
                    lnsalint = lnsalint + drcartera("nsalint")
                End If
            Next

            droficina("ncapdes") = lncapdes
            droficina("nsalcap") = lnsalcap
            droficina("nmora") = lnmora
            droficina("nsalint") = lnsalint
            droficina("nsalmor") = lnsalmor
            droficina("nporc1") = lnporc1
            droficina("nporc2") = lnporc2

            lncapdes = 0
            lnsalcap = 0
            lnmora = 0
            lnsalint = 0
            lnsalmor = 0
            lnporc1 = 0
            lnporc2 = 0
        Next
        Return dsoficina
    End Function


    'OBTIENE LA CARTERA ACTUALIZADA POR ANALISTAS
    Public Function CARTERA_ACTUALIZADA_ANALISTAS(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String) As DataSet

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dtoficina As DataTable
        Dim clsprin As New class1
        Dim DSCARTERA As New DataSet
        Dim clscartera As New dbCreditos
        Dim dsusuario As New DataSet
        Dim drcartera As DataRow
        Dim drusuario As DataRow
        Dim categoria As String

        Dim mtabtusu As New cTabtusu
        Dim etabtusu As New tabtusu
        Dim lncapdes, lnsalcap, lnmora, lnsalint, lnsalmor, lnporc1, lnporc2 As Double
        lncapdes = lnsalcap = lnmora = lnsalint = lnsalmor = lnporc1 = lnporc2 = 0

        Dim cancela As String
        Dim lncontaminada As Double
        Dim lnsalcap2 As Double
        cancela = "0"


        dsusuario = mtabtusu.ObtenerDataSetPorID()

        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, "*", lczona)

        For Each drusuario In dsusuario.Tables(0).Rows
            If drusuario("ccatego") = "ANA" Then
                For Each drcartera In DSCARTERA.Tables(0).Rows
                    ' drcartera("coficina") = drusuario("ccodofi")
                    If drcartera("ccodana") = drusuario("ccodusu") Then
                        lnporc1 = lnporc1 + 1
                        If drcartera("ndiaatr") > 0 Then
                            lnporc2 = lnporc2 + 1
                        End If
                        If IsDBNull(drcartera("nintteo")) Then
                            drcartera("nintteo") = 0
                        End If
                        If IsDBNull(drcartera("nintpag")) Then
                            drcartera("nintpag") = 0
                        End If
                        If IsDBNull(drcartera("ndifer")) Then
                            drcartera("ndifer") = 0
                        End If
                        'If IsDBNull(drcartera("ncosdir")) Then
                        '    drcartera("ncosdir") = 0
                        'End If
                        'If IsDBNull(drcartera("nprima")) Then
                        '    drcartera("nprima") = 0
                        'End If
                        If IsDBNull(drcartera("nahoprg")) Then
                            drcartera("nahoprg") = 0
                        End If
                        If IsDBNull(drcartera("tasa")) Then
                            drcartera("tasa") = 0
                        End If
                        If IsDBNull(drcartera("ncapita")) Then
                            drcartera("ncapita") = 0
                        End If
                        If IsDBNull(drcartera("ncappag")) Then
                            drcartera("ncappag") = 0
                        End If
                        If IsDBNull(drcartera("ncapdes")) Then
                            drcartera("ncapdes") = 0
                        End If
                        If IsDBNull(drcartera("ndiaatr")) Then
                            drcartera("ndiaatr") = 0
                        End If

                        lncapdes = lncapdes + drcartera("ncapdes")
                        lnsalcap = lnsalcap + (drcartera("ncapdes") - drcartera("ncappag"))
                        lnsalcap2 = (drcartera("ncapdes") - drcartera("ncappag"))
                        If drcartera("ncapita") - drcartera("ncappag") > 0 Then
                            lnmora = lnmora + (drcartera("ncapita") - drcartera("ncappag"))
                        End If

                        lnsalint = lnsalint + drcartera("nsalint")
                        If drcartera("ndiaatr") > 0 Then
                            lncontaminada = lncontaminada + lnsalcap2
                        End If

                    End If
                Next

                drusuario("ncapdes") = lncapdes
                drusuario("nsalcap") = lnsalcap
                drusuario("nmora") = lnmora
                drusuario("nsalint") = lnsalint
                drusuario("nsalmor") = lnsalmor
                drusuario("nporc1") = lnporc1
                drusuario("nporc2") = lnporc2
                drusuario("nconta") = lncontaminada
                lncapdes = 0
                lnsalcap = 0
                lnmora = 0
                lnsalint = 0
                lnsalmor = 0
                lnporc1 = 0
                lnporc2 = 0
                lncontaminada = 0
            End If

        Next

        Return dsusuario

    End Function


    'RESERVA



    'estratificacion de la mora 1-7 dias, 8-15 dias , 16-30 dias, ..........
    Public Function estratificacion(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal lcoficina As String, ByVal lcanalista As String, ByVal lcestrato As String, ByVal lclineas As String, ByVal lmora As Boolean, ByVal lczona As String) As DataSet

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim dtoficina As DataTable
        Dim clsprin As New class1
        Dim DSCARTERA As New DataSet
        Dim clscartera As New dbCreditos
        Dim drcartera As DataRow
        Dim categoria As String
        Dim dt As New DataTable
        Dim dsreserva As New DataSet

        Dim lncapdes, lnsalcap, lnmora, lnsalint, lnsalmor, lnporc1, lnporc2 As Double
        lncapdes = lnsalcap = lnmora = lnsalint = lnsalmor = lnporc1 = lnporc2 = 0

        Dim i As Integer
        Dim drreserva As DataRow
        Dim lccategoria As String
        Dim lcrango As String
        Dim lnparametros As Double
        Dim lnreserva As Double
        Dim lnreserva1 As Double
        Dim lnsalcap2 As Double
        lnreserva = 0

        Dim LNNUM As Double
        Dim LNPOR As Double
        Dim lncartot As Double
        Dim lnmortot As Double
        Dim lnpornum As Double
        Dim cancela As String
        cancela = "0"

        'crea dataset desconectado

        lcampos1 = "categoria, rango, ncapdes, nsalcap, nmora, nsalint, nsalmor, nparametro, nreserva, nnum, npor, ncartot, nmortot, npornum,"
        ltipos1 = "S,S,D,D,D,D,D,D,D,D,D,D,D,D,"
        dt = creadatasetdesconec(lcampos1, ltipos1, "PlanTeo")


        'llena datos con rango de reserva

        For i = 0 To 5
            drreserva = dt.NewRow
            If i = 0 Then
                lcrango = "CARTERA SIN ATRASOS "
                lccategoria = "A"
                lnparametros = 0
            ElseIf i = 1 Then
                lcrango = "CARTERA EN MORA DE 1-30"
                lccategoria = "A1"
                lnparametros = 0
            ElseIf i = 2 Then
                lcrango = "CARTERA EN MORA DE 31-60"
                lccategoria = "B"
                lnparametros = 10 / 100

            ElseIf i = 3 Then
                lcrango = "CARTERA EN MORA DE 61-90"
                lccategoria = "C"
                lnparametros = 30 / 100

            ElseIf i = 4 Then
                lcrango = "CARTERA EN MORA DE 91-180"
                lccategoria = "D"
                lnparametros = 50 / 100

            ElseIf i = 5 Then
                lcrango = "CARTERA EN MORA MAYOR 180"
                lccategoria = "E"
                lnparametros = 100 / 100
            End If

            drreserva("Rango") = lcrango
            drreserva("nsalcap") = 0
            drreserva("ncapdes") = 0
            drreserva("nmora") = 0
            drreserva("nsalint") = 0
            drreserva("nsalmor") = 0
            drreserva("nreserva") = 0
            drreserva("categoria") = lccategoria
            drreserva("nparametro") = lnparametros
            dt.Rows.Add(drreserva)

        Next

        dsreserva.Tables.Add(dt)

        DSCARTERA = clscartera.CARTERA_ACTUALIZADA(dfecha1, dfecha2, lcoficina, lcanalista, lcestrato, lclineas, lmora, cancela, "*", lczona)

        LNNUM = 0
        LNPOR = 0
        lncartot = 0
        lnmortot = 0
        lnpornum = 0

        'dice reserva, pero se saco de la estratificacion de la cartera

        For Each drreserva In dsreserva.Tables(0).Rows
            For Each drcartera In DSCARTERA.Tables(0).Rows
                If drcartera("categoria2") = drreserva("categoria") Then
                    lnporc1 = lnporc1 + 1
                    If drcartera("ndiaatr") > 0 Then
                        lnporc2 = lnporc2 + 1
                    End If
                    If IsDBNull(drcartera("nintteo")) Then
                        drcartera("nintteo") = 0
                    End If
                    If IsDBNull(drcartera("nintpag")) Then
                        drcartera("nintpag") = 0
                    End If
                    If IsDBNull(drcartera("ndifer")) Then
                        drcartera("ndifer") = 0
                    End If
                    If IsDBNull(drcartera("nahoprg")) Then
                        drcartera("nahoprg") = 0
                    End If
                    If IsDBNull(drcartera("tasa")) Then
                        drcartera("tasa") = 0
                    End If
                    If IsDBNull(drcartera("ncapita")) Then
                        drcartera("ncapita") = 0
                    End If
                    If IsDBNull(drcartera("ncappag")) Then
                        drcartera("ncappag") = 0
                    End If
                    If IsDBNull(drcartera("ncapdes")) Then
                        drcartera("ncapdes") = 0
                    End If

                    LNNUM = LNNUM + 1
                    lncapdes = lncapdes + drcartera("ncapdes")
                    lnsalcap = lnsalcap + (drcartera("ncapdes") - drcartera("ncappag"))
                    lnsalcap2 = (drcartera("ncapdes") - drcartera("ncappag"))

                    If drcartera("ncapita") - drcartera("ncappag") > 0 Then
                        lnmora = lnmora + (drcartera("ncapita") - drcartera("ncappag"))
                    End If

                    lncartot = lncartot + lnsalcap2
                    lnpornum = lnpornum + 1
                    lnmortot = lnmortot + lnmora

                    lnsalint = lnsalint + drcartera("nsalint")

                    'monto a reservar
                    lnreserva = lnreserva + ((drreserva("nparametro") * lnsalcap2))
                End If
            Next

            drreserva("ncapdes") = lncapdes
            drreserva("nsalcap") = lnsalcap
            drreserva("nmora") = lnmora
            drreserva("nsalint") = lnsalint
            drreserva("nsalmor") = lnsalmor
            drreserva("nreserva") = lnreserva
            drreserva("nparametro") = drreserva("nparametro") * 100
            drreserva("nnum") = LNNUM
            drreserva("ncartot") = lncartot
            drreserva("nmortot") = lnmortot
            drreserva("npornum") = lnpornum

            lncapdes = 0
            lnsalcap = 0
            lnmora = 0
            lnsalint = 0
            lnsalmor = 0
            lnporc1 = 0
            lnporc2 = 0
            lnreserva = 0
            LNNUM = 0

        Next

        Return dsreserva

    End Function



    'crea plan de pagos flat
    Public Sub FXMIGRAPLANUNACTA(ByVal lccodcta, ByVal ldfecvig, ByVal lncapdes, ByVal lnmoncuo, ByVal lncapita, ByVal lnintere, ByVal lnnumcuo, ByVal lnsegdeu, ByVal lnsegdan, ByVal lnreserva, ByVal lntalona, ByVal lnnoseg)

        'verifica si hay pagos para reconstruirlos
        Dim mcredkar As New cCredkar
        Dim ecredkar As New credkar
        Dim dskardex As New DataSet
        Dim mcreditos As New ccreditos
        Dim dscreditos As New DataSet
        Dim ldfecha As Date
        ldfecha = #2/28/2005#

        'ojo  *************** pendiente revision fecha     ***************

        dskardex = mcredkar.ObtenerDataSetkardexflat(lccodcta, ldfecha)
        dscreditos = mcreditos.recupera_ds(lccodcta)

        If dscreditos.Tables(0).Rows.Count > 0 Then

            'crea temporales de las tablas que necesitar
            Dim dscremcre As New DataSet
            Dim dscredppg As New DataSet
            Dim dscredkar As New DataSet

            Dim ecremcre1 As New cremcre
            Dim mcremcre1 As New cCremcre

            Dim ecredppg1 As New credppg
            Dim mcredppg1 As New cCredppg

            Dim ecredkar1 As New credkar
            Dim mcredkar1 As New cCredkar

            dscremcre = mcremcre1.ObtenerDataSetPorIDAC(lccodcta)
            dscredkar = mcredkar1.ObtenerDataSetPorunacuenta(lccodcta)
            dscredppg = mcredppg1.ObtenerDataSetPorID2(lccodcta)

            Dim lccodcli As String
            Dim lnmonapr As Double
            Dim ldfecpri As Date
            Dim ldfecven As Date
            Dim lncuoapr As Double
            Dim lncappag As Double
            Dim lnplazo As Double
            Dim lntalonario As Double
            Dim lnmonto As Double
            Dim lcdiapri As String
            Dim ldfecpriant As Date
            Dim i As Integer

            Dim lndif As Double
            Dim lcnrocuo As String
            Dim lntamano As Integer
            Dim n As Integer
            Dim ldfecvencuo As Date

            Dim ldfecpro1 As Date
            Dim bandera As Boolean


            lccodcli = dscremcre.Tables(0).Rows(0)("ccodcli")
            lnmonapr = lncapdes 'dscremcre.Tables(0).Rows(0)("nmonapr")

            ldfecpri = ldfecvig
            ldfecven = dscremcre.Tables(0).Rows(0)("dfecven")
            lncuoapr = dscremcre.Tables(0).Rows(0)("ncuoapr")
            lncappag = 0
            lncuoapr = lnnumcuo
            lnplazo = lncuoapr

            lntalonario = lntalona
            lnmonto = 0

            lcdiapri = DateAdd("m", 1, ldfecpri)

            'borra lo que hay en credkar
            mcredppg1.EliminarCredppg(lccodcta)

            '* INSERTA EL DESEMBOLSO
            ecredppg1.ccodcta = lccodcta
            ecredppg1.ccodusu = "9999"
            ecredppg1.cestado = " "
            ecredppg1.cflag = " "
            ecredppg1.cnrocuo = "001"
            ecredppg1.ctipope = "D"
            ecredppg1.dfecmod = Today()
            ecredppg1.dfecpag = ldfecvig
            ecredppg1.dfecven = ldfecvig
            ecredppg1.ncapita = lncapdes
            ecredppg1.ncappag = 0
            ecredppg1.ngastos = 0
            ecredppg1.nintere = 0
            ecredppg1.nintmor = 0
            ecredppg1.nintpag = 0
            ecredppg1.nmoncuo = 0
            ecredppg1.nmorpag = 0
            ecredppg1.notrpag = 0
            'ecredppg1.nresinc = 0
            ecredppg1.nsaldo = lncapdes
            'ecredppg1.nsegdan = 0
            'ecredppg1.nsegdeu = 0
            'ecredppg1.ntalona = 0
            mcredppg1.Agregar(ecredppg1)

            '   ** agrega las demas cuotas

            ldfecpriant = ldfecpri
            For i = 1 To lnplazo
                lnmonto = lnmonto + lncapita
                If i = lnplazo Then
                    lndif = lnmonapr - lnmonto
                    lncapita = lncapita + lndif
                    ' ** ajusta la ultima cuota
                End If
                lcnrocuo = i.ToString.Trim
                lntamano = lcnrocuo.Length
                For n = 1 To 3 - lntamano
                    lcnrocuo = "0" + lcnrocuo
                Next n
                ldfecvencuo = ldfecpri
                ldfecpri = DateAdd("m", i, ldfecvig)

                '********** OBVIAR LOS SABADOS Y DOMINGOS *********************

                ldfecpro1 = ldfecpri

                If Weekday(ldfecpro1, FirstDayOfWeek.Sunday) = 1 Then
                    ldfecpro1 = ldfecpro1.AddDays(-2)
                    bandera = False
                End If
                If Weekday(ldfecpro1, FirstDayOfWeek.Sunday) = 7 Then
                    ldfecpro1 = ldfecpro1.AddDays(-1)
                    bandera = False
                End If

                '*********  FINALIZA OBVIAR SABADOS Y DOMINGOS ****************

                ecredppg1.ccodcta = lccodcta
                ecredppg1.ccodusu = "9999"
                ecredppg1.cestado = " "
                ecredppg1.cflag = " "
                ecredppg1.cnrocuo = lcnrocuo
                ecredppg1.ctipope = "N"
                ecredppg1.dfecmod = Today()
                ecredppg1.dfecpag = ldfecpro1
                ecredppg1.dfecven = ldfecpro1
                ecredppg1.ncapita = lncapita
                ecredppg1.ncappag = 0
                ecredppg1.ngastos = 0
                ecredppg1.nintere = lnintere
                ecredppg1.nintmor = 0
                ecredppg1.nintpag = 0
                ecredppg1.nmoncuo = 0
                ecredppg1.nmorpag = 0
                ecredppg1.notrpag = 0
                'ecredppg1.nresinc = lnreserva
                ecredppg1.nsaldo = 0
                'ecredppg1.nsegdan = lnsegdan
                'ecredppg1.nsegdeu = lnsegdeu
                'ecredppg1.ntalona = lntalonario
                mcredppg1.Agregar(ecredppg1)

            Next

            'revisa si hay pagos para reconstruirlos





            If dskardex.Tables(0).Rows.Count > 0 Then
                generapagos(lccodcta, ldfecha, lncapita, lnintere, lnmoncuo, lncapdes)
            End If

        End If


    End Sub


    'GENERA PAGOS
    'genera los pagos flat segun condiciones de habitat


    Sub generapagos(ByVal lccodcta As String, ByVal ldfecha As Date, ByVal pncapita As Double, ByVal pnintere As Double, ByVal pnmoncuo As Double, ByVal lncapdes As Double)

        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        Dim dscreditos As New DataSet
        Dim segdeu As Integer
        Dim segdan As Integer
        Dim talona As Integer
        Dim reserva As Int16
        Dim ldfechades As Date
        Dim redo As Integer
        Dim ldultpag1 As Date
        Dim ldultpagmm As Date

        Dim ecredkar As New credkar
        Dim mcredkar As New cCredkar
        Dim dscredkar2 As New DataSet
        Dim dscredppg2 As New DataSet
        Dim mcredppg2 As New cCredppg
        Dim ecredppg2 As New credppg
        Dim dr As DataRow
        Dim ldfecsis As Date
        Dim ldfecpro As Date
        Dim lccodctb As String
        Dim lcnrodoc As String
        Dim lcnrodoc2 As String
        Dim drplan As DataRow
        Dim lnintere As Double

        Dim lntotint As Double
        Dim LNTOTALINT As Double
        Dim lntotcap As Double
        Dim ldpagoant As Date
        Dim drkardex As DataRow
        Dim LNTOTPAGINT As Double
        Dim LNTOTPAGCAP As Double
        Dim LNSALINT As Double
        Dim lnsalcap As Double

        Dim gnsegdan As Double
        Dim lnfecnum As Double
        Dim n As Integer

        Dim lccodant As String
        Dim ldpago As Date
        Dim ldfecvig As Date
        Dim lcnuming As String
        Dim ldultpag As Date


        Dim LNSD As Double
        Dim LNRE As Double
        Dim LNTA As Double
        Dim lnsn As Double

        Dim LNSD1 As Double
        Dim LNSN1 As Double
        Dim LNRE1 As Double
        Dim LNTA1 As Double

        Dim LNSDT As Double
        Dim LNSNT As Double
        Dim LNRET As Double
        Dim LNTAT As Double

        Dim LNPENSD As Double
        Dim LNPENSN As Double
        Dim LNPENRE As Double
        Dim LNPENTA As Double

        Dim lnsegdeu As Double
        Dim lnsegdan As Double
        Dim lnresinc As Double
        Dim lntalona As Double


        Dim lnseguro As Double
        Dim lntalonario As Double
        Dim calculo As New dbCreditos
        Dim lnintmor As Double

        Dim lncosind As Double
        Dim lncuoapr As Double
        Dim dfecha2 As Date
        Dim gnsummor As Double
        Dim lcnrolin As String
        Dim ldfecdes As Date
        Dim gdfecmor As Date
        Dim LNMONTO As Double
        Dim lncorrelativo As Double
        Dim gccodofi As String

        Dim lncapita As Double
        Dim dspagos As New DataSet
        Dim cuenta As Double

        lnsegdeu = 0
        lnsegdan = 0
        lnresinc = 0
        lntalona = 0

        'dataset solo para fecha CREMCRE.DFECVIG <= CTOD("28/02/2005");


        Dim ldfecha1 As Date
        Dim ldfechap As Date

        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre

        ldfecha1 = #2/28/2005#

        dscreditos = mcreditos.CARTERA_ACTUALIZADA_POR_CUENTA(lccodcta, ldfecha)

        If dscreditos.Tables(0).Rows.Count > 0 Then

            'actualiza creddppg plan de pagos con fecha, a partir de la cual se cobrara seguros
            dscredppg2 = mcredppg2.ObtenerDataSetPorID2(lccodcta)

            For Each drplan In dscredppg2.Tables(0).Rows

                If drplan("ctipope") <> "D" And drplan("dFecVen") < #7/1/2004# Then
                    ecredppg2.ccodcta = lccodcta
                    'ecredppg2.nsegdeu = 0
                    'ecredppg2.nsegdan = 0
                    'ecredppg2.nresinc = 0
                    'ecredppg2.ntalona = drplan("ntalona")
                    ecredppg2.cnrocuo = drplan("cnrocuo")
                    ecredppg2.ctipope = drplan("ctipope")
                    ecredppg2.dfecmod = Today()
                    ecredppg2.dfecpag = drplan("dfecpag")
                    ecredppg2.dfecven = drplan("dfecven")
                    ecredppg2.ncappag = drplan("ncappag")
                    ecredppg2.ncapita = drplan("ncapita")
                    ecredppg2.ngastos = drplan("ngastos")
                    ecredppg2.nintere = drplan("nintere")
                    ecredppg2.nintmor = drplan("nintmor")
                    ecredppg2.nintpag = drplan("nintpag")
                    ecredppg2.nmoncuo = drplan("nmoncuo")
                    ecredppg2.nmorpag = drplan("nmorpag")
                    ecredppg2.notrpag = drplan("notrpag")
                    ecredppg2.nsaldo = drplan("nsaldo")
                    ecredppg2.cestado = drplan("cestado")
                    ecredppg2.ccodusu = drplan("ccodusu")
                    ecredppg2.cflag = drplan("cflag")

                    'If IsDBNull(drplan("ntalona")) Then
                    '    ecredppg2.ntalona = 0.0
                    'Else
                    '    ecredppg2.ntalona = drplan("ntalona")
                    'End If
                    'continua
                    mcredppg2.ActualizarCredppg(ecredppg2)
                End If

                'actualiza talonario, es a otra fecha

                If drplan("ctipope") <> "D" And drplan("dFecVen") < Me.dfeccob Then


                    ecredppg2.ccodcta = lccodcta
                    ecredppg2.cnrocuo = drplan("cnrocuo")
                    ecredppg2.ctipope = drplan("ctipope")
                    ecredppg2.dfecmod = Today()
                    ecredppg2.dfecpag = drplan("dfecpag")
                    ecredppg2.dfecven = drplan("dfecven")
                    ecredppg2.ncappag = drplan("ncappag")
                    ecredppg2.ncapita = drplan("ncapita")
                    ecredppg2.ngastos = drplan("ngastos")
                    ecredppg2.nintere = drplan("nintere")
                    ecredppg2.nintmor = drplan("nintmor")
                    ecredppg2.nintpag = drplan("nintpag")
                    ecredppg2.nmoncuo = drplan("nmoncuo")
                    ecredppg2.nmorpag = drplan("nmorpag")
                    ecredppg2.notrpag = drplan("notrpag")
                    ecredppg2.nsaldo = drplan("nsaldo")
                    ecredppg2.cestado = drplan("cestado")
                    ecredppg2.ccodusu = drplan("ccodusu")
                    ecredppg2.cflag = drplan("cflag")

                    mcredppg2.ActualizarCredppg(ecredppg2)

                End If

            Next



            'finaliza actualizacion de datos en credppg ************************


            segdeu = dscreditos.Tables(0).Rows(0)("lsegdeu")
            segdan = dscreditos.Tables(0).Rows(0)("lsegdan")
            talona = dscreditos.Tables(0).Rows(0)("ltalona")
            reserva = dscreditos.Tables(0).Rows(0)("lreserva")
            ldfechades = dscreditos.Tables(0).Rows(0)("dfecvig")
            ldultpag1 = dscreditos.Tables(0).Rows(0)("dultpag")

            'datos para calculo de interes moratorio al final
            'lncapdes = dscreditos.Tables(0).Rows(0)("ncapdes")
            ldfecvig = dscreditos.Tables(0).Rows(0)("dfecvig")
            gnperbas = gnperbas

            lncosind = dscreditos.Tables(0).Rows(0)("ncosind")
            lncuoapr = dscreditos.Tables(0).Rows(0)("ncuoapr")
            dfecha2 = ldfecha
            gnsummor = dscreditos.Tables(0).Rows(0)("ncappag")
            lcnrolin = dscreditos.Tables(0).Rows(0)("cnrolin")
            gccodofi = dscreditos.Tables(0).Rows(0)("coficina")

            ldfecdes = ldfecvig
            gdfecmor = "07/01/2004"

            'obtiene el ultimo pago real de cobro de seguros

            '            ldultpagmm = mcredkar.obtenerfechaultima(lccodcta)

            If IsDBNull(dscreditos.Tables(0).Rows(0)("dfechaseg")) Then
                ldultpagmm = dscreditos.Tables(0).Rows(0)("dfecvig")
            Else
                ldultpagmm = dscreditos.Tables(0).Rows(0)("dfechaseg")
            End If

            ldfechap = #3/1/2005#

            dscredkar2 = mcredkar.obtenerdatasetkarflat(lccodcta, ldfechap)
            dscredppg2 = mcredppg2.ObtenerDataSetPorID2(lccodcta)



            'borrara los movimientos de credkar
            mcredkar.Eliminar_pagos(lccodcta, ldfechap)
            'fin borrado de los pagos credkar

            lntotint = 0
            LNTOTALINT = 0
            lntotcap = 0
            LNTOTPAGCAP = 0

            lccodant = lccodcta
            ldpago = dscredkar2.Tables(0).Rows(0)("dfecsis")
            ldpagoant = dscredkar2.Tables(0).Rows(0)("dfecpro")


            'actualizara la credkar con el monto del desembolso que se cambio y la cremcre


            ecremcre.ccodcta = lccodcta
            mcremcre.ObtenerCremcre(ecremcre)
            ecremcre.ncapdes = lncapdes
            ecremcre.dfecvig = ldfecvig
            mcremcre.ActualizarCremcre(ecremcre)

            mcredkar.Actualizar_monto(lccodcta, lncapdes, ldfecvig)

            'finaliza cambio de la credkar con nuevo cambio





            For Each dr In dscredkar2.Tables(0).Rows

                lcnuming = dr("cnuming")

                If ldultpag1 = Nothing Then
                    ldultpag = ldultpag1
                Else
                    ldultpag = ldultpag1
                End If

                ldfecsis = dr("dfecsis")
                ldfecpro = dr("dfecpro")
                lccodctb = dr("ccodctb")
                lcnrodoc = dr("cnrodoc")
                lcnrodoc2 = lcnrodoc
                LNMONTO = dr("nmonto")


                LNSD1 = 0
                LNSN1 = 0
                LNRE1 = 0
                LNTA1 = 0

                LNSDT = 0
                LNSNT = 0
                LNRET = 0
                LNTAT = 0


                lntotint = 0
                LNTOTALINT = 0
                lntotcap = 0
                'obtiene kardex de pagos actualizados con los nuevos pagos aplicados

                dspagos = mcredkar.ObtenerDataSetPorunacuenta(lccodcta)
                cuenta = dspagos.Tables(0).Rows.Count

                'obtiene el interes flat
                For Each drplan In dscredppg2.Tables(0).Rows
                    If drplan("ctipope") <> "D" Then
                        lnintere = drplan("nintere")

                        '**********

                        If drplan("dfecven") <= ldpagoant And drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNSD1 = LNSD1 + drplan("NSEGDEU")
                        End If
                        If drplan("dfecven") <= ldpagoant And drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNSN1 = LNSN1 + drplan("NSEGDAN")
                        End If
                        If drplan("dfecven") <= ldpagoant And drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNRE1 = LNRE1 + drplan("NRESINC")
                        End If
                        If drplan("dfecven") < ldpagoant And drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNTA1 = LNTA1 + drplan("NTALONA")
                        End If


                        '***totales generales
                        If drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNSDT = LNSDT + drplan("NSEGDEU")
                        End If
                        If drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNSNT = LNSNT + drplan("NSEGDAN")
                        End If
                        If drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNRET = LNRET + drplan("NRESINC")
                        End If
                        If drplan("ccodcta") = lccodcta And drplan("ctipope") <> "D" Then
                            LNTAT = LNTAT + drplan("NTALONA")
                        End If

                    End If


                    If drplan("dfecven") <= ldpagoant Then
                        lntotint = lntotint + drplan("nintere")
                        lntotcap = lntotcap + drplan("ncapita")
                    End If
                    LNTOTALINT = LNTOTALINT + drplan("nintere")


                    lnsegdeu = drplan("nsegdeu")
                    lnsegdan = drplan("nsegdan")
                    lnresinc = drplan("nresinc")
                    lntalona = drplan("ntalona")

                    LNSD1 = drplan("nsegdeu")
                    LNSN1 = drplan("nsegdan")
                    LNRE1 = drplan("nresinc")

                Next


                'suma lo de kardex
                LNSD = 0
                lnsn = 0
                LNRE = 0
                LNTA = 0

                LNTOTPAGINT = 0
                LNTOTPAGCAP = 0
                LNSD = 0
                lnsn = 0
                LNRE = 0
                LNTA = 0

                For Each drkardex In dspagos.Tables(0).Rows
                    If drkardex("cconcep") = "IN" Then
                        LNTOTPAGINT = LNTOTPAGINT + drkardex("nmonto")
                    End If

                    If drkardex("cconcep") = "KP" Then
                        LNTOTPAGCAP = LNTOTPAGCAP + drkardex("nmonto")
                    End If

                    If drkardex("CCONCEP") = "SD" Then
                        LNSD = LNSD + drkardex("nmonto")
                    End If

                    If drkardex("CCONCEP") = "03" Then
                        lnsn = lnsn + drkardex("nmonto")
                    End If

                    If drkardex("CCONCEP") = "01" Then
                        LNRE = LNRE + drkardex("nmonto")
                    End If

                    If drkardex("CCONCEP") = "06" Then
                        LNTA = LNTA + drkardex("nmonto")
                    End If
                Next

                LNSALINT = lntotint - LNTOTPAGINT
                If LNSALINT <= 0 And LNTOTPAGINT < LNTOTALINT Then
                    LNSALINT = lnintere
                End If

                lnsalcap = lncapdes - LNTOTPAGCAP


                gnporres = 0.005
                gnporseg = 0.004746
                gnsegdan = 0.004068


                If ldfecsis.Year <> ldultpagmm.Year Then
                    n = ldfecsis.Year - ldultpagmm.Year
                    lnfecnum = (ldfecsis.Month + n * 12) - ldultpagmm.Month
                Else
                    lnfecnum = ldfecsis.Month - ldultpagmm.Month
                End If


                Dim lnintmorapagado As Double
                Dim lndifdia As Double


                If lccodcta = lccodant Then
                    ldultpag1 = ldpagoant
                Else
                    ldultpag1 = ldultpag
                    lnintmorapagado = 0
                End If

                lndifdia = ldfecsis.ToOADate - ldultpag1.ToOADate
                If lndifdia < 0 Then
                    lndifdia = 0
                End If


                '*** VERIFICA SI DEJO SEGUROS PENDIENTES


                LNPENSD = 0
                LNPENSN = 0
                LNPENRE = 0
                LNPENTA = 0


                If LNSD1 - LNSD > (lnsegdeu * lnfecnum) Then
                    LNPENSD = (LNSD1 - LNSD) - (lnsegdeu * lnfecnum)
                End If

                If LNSN1 - lnsn > (lnsegdan * lnfecnum) Then
                    LNPENSN = (LNSN1 - lnsn) - (lnsegdan * lnfecnum)
                End If

                If LNRE1 - LNRE > (lnresinc * lnfecnum) Then
                    LNPENRE = (LNRE1 - LNRE) - (lnresinc * lnfecnum)
                End If

                '**********

                LNSD1 = (LNSD1 * lnfecnum)
                LNSN1 = (LNSN1 * lnfecnum)
                LNRE1 = (LNRE1 * lnfecnum)


                If LNSDT - LNSD >= LNSD1 Then
                    lnseguro = LNSD1
                Else
                    lnseguro = LNSDT - LNSD
                    If lnseguro < 0 Then
                        lnseguro = 0
                    End If
                End If



                'seguro de daños
                If LNSNT - lnsn >= LNSN1 Then
                    lnsegdan = LNSN1
                Else
                    lnsegdan = LNSNT - lnsn
                    If lnsegdan < 0 Then
                        lnsegdan = 0
                    End If
                End If


                'reserva
                If LNRET - LNRE >= LNRE1 Then
                    lnresinc = LNRE1
                Else
                    lnresinc = LNRET - LNRE
                    If lnresinc < 0 Then
                        lnresinc = 0
                    End If
                End If

                'calcula talonarios


                lntalonario = 0
                If "n/a" Like lcnuming And LNTAT - LNTA > 0 Then

                    lntalonario = (LNTA1 - LNTA)
                    If lntalonario < 0 Then
                        lntalonario = 0
                    End If
                    If LNTAT - LNTA > 0 And lntalonario <= 0 Then
                        lntalonario = 0.46
                    End If
                Else
                    If LNTAT - LNTA > 0 Then
                        lntalonario = 0.46
                    End If
                End If


                'finaliza calculo de talonarios


                lnintmor = calculo.mxCalcMoratory(dscredppg2, ldultpag, ldfecdes, gdfecmor, lncapdes, lncosind, lncuoapr, dfecha2, gnsummor, lcnrolin, gnperbas)

                'graba pago por pago en la credkar

                If LNMONTO > 0 Then


                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = LNMONTO
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "CJ"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If

                'reserva
                If lnresinc > 0 And LNMONTO > 0 Then
                    If LNMONTO > lnresinc Then
                        LNMONTO = LNMONTO - lnresinc
                    Else
                        lnresinc = LNMONTO
                        LNMONTO = 0
                    End If

                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = lnresinc
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "01"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If



                If lnseguro > 0 And LNMONTO > 0 Then
                    If LNMONTO > lnseguro Then
                        LNMONTO = LNMONTO - lnseguro
                    Else
                        lnseguro = LNMONTO
                        LNMONTO = 0
                    End If

                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = lnseguro
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "SD"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If



                If lnsegdan > 0 Then
                    If LNMONTO > lnsegdan Then
                        LNMONTO = LNMONTO - lnsegdan
                    Else
                        lnsegdan = LNMONTO
                        LNMONTO = 0
                    End If

                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = lnsegdan
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "03"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If



                If lntalonario > 0 Then
                    If LNMONTO > lntalonario Then
                        LNMONTO = LNMONTO - lntalonario
                    Else
                        lntalonario = LNMONTO
                        LNMONTO = 0
                    End If


                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = lntalonario
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "06"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If


                If lnintmor > 0 Then
                    If LNMONTO > lnintmor Then
                        LNMONTO = LNMONTO - lnintmor
                    Else
                        lnintmor = LNMONTO
                        LNMONTO = 0
                    End If
                    lnintmorapagado = lnintmorapagado + lnintmor

                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = lnintmor
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "MO"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If



                If LNSALINT > 0 Then
                    If LNMONTO > LNSALINT Then
                        LNMONTO = LNMONTO - LNSALINT
                    Else
                        LNSALINT = LNMONTO
                        LNMONTO = 0
                    End If


                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = LNSALINT
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "IN"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If



                If LNMONTO > 0 Then
                    lncapita = LNMONTO
                    If lncapita > lnsalcap Then
                        lncapita = lnsalcap
                        LNMONTO = LNMONTO - lnsalcap
                    Else
                        LNMONTO = 0
                    End If


                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = lncapita
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "KP"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If

                If LNMONTO > 0 Then

                    ecredkar.ccodcta = lccodcta
                    ecredkar.nmonto = LNMONTO
                    ecredkar.ccodctb = lccodctb
                    ecredkar.cconcep = "EX"
                    ecredkar.cdescob = "C"
                    ecredkar.ctippag = "N"
                    ecredkar.cestado = " "
                    ecredkar.ctippag = "N"
                    ecredkar.dfecsis = ldfecsis
                    ecredkar.dfecpro = ldfecpro
                    ecredkar.dfecmod = ldfecsis
                    ecredkar.ccodusu = "9999"
                    ecredkar.ccondic = "C"
                    ecredkar.cbanco = " "
                    ecredkar.cnuming = lcnuming
                    ecredkar.ctrasctb = 1
                    ecredkar.ndiaatr = 0
                    ecredkar.ccodofi = gccodofi
                    ecredkar.ccodins = gccodofi
                    ecredkar.cnrodoc = lcnrodoc2
                    lncorrelativo = lncorrelativo + 1
                    ecredkar.ncorrela = lncorrelativo
                    ecredkar.cflag = " "
                    ecredkar.crotativa = " "
                    mcredkar.agregarCredkar(ecredkar)

                End If

                lccodant = lccodcta.Trim
                ldpago = dr("dfecsis")
                ldpagoant = dr("dfecpro")
                ldultpagmm = dr("dfecpro")
                dspagos.Tables.Clear()

            Next

        End If

    End Sub



    Public Function Graba_Refinados() As Integer
        Dim eCancela As New cancela
        Dim mCancela As New cCancela
        Dim lnRetorno As Integer = 1
        Try
            eCancela.ccodpre = Me.pcCodCre
            eCancela.ccodcta = Me.pcCodRef
            eCancela.nsalcap = Me.pnSalCap
            eCancela.nsalint = Me.pnSalInt
            eCancela.nsalmor = Me.pnSalMor
            eCancela.nseguro = Me.pnSegDeu
            eCancela.nmanejo = Me.pnComPer
            eCancela.niva = Me.pniva

            eCancela.ccodcli = ""
            eCancela.ccodlin = ""
            eCancela.cnomcli = ""
            eCancela.cnumchq = ""
            eCancela.ctabco = ""
            eCancela.ntotal = Me.pnSalCap + Me.pnSalInt + Me.pnSalMor + Me.pnSegDeu + Me.pnComPer + Me.pniva
            mCancela.Agregar(eCancela)

            Return lnRetorno
        Catch ex As Exception
            lnRetorno = 0
            Return lnRetorno
        End Try

    End Function

    Public Sub Borra_Refinados()
        Dim eCancela As New SIM.BL.cCancela
        eCancela.EliminarRef(Me.pcCodCre, Me.pcCodRef)
    End Sub
    Public Sub BorraTodo_Refinados()
        Dim eCancela As New SIM.BL.cCancela
        eCancela.EliminarRefTodo(Me.pcCodCre)
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>><<
    Public Sub Borrar_Credgas()
        Dim eCredgas As New cCredgas
        eCredgas.Eliminarporcuenta(Me.pcCodCre)
    End Sub

    Public Sub Insertar_Credgas()
        If Me.pcTabGasx.Tables(0).Rows.Count = 0 Then

        Else
            Dim entidadCredgas As New SIM.EL.credgas
            Dim eCredgas As New SIM.BL.cCredgas

            Dim Filapt As DataRow
            Dim nElem As Integer
            Dim MyDate As DateTime
            MyDate = Today
            Dim nCantig As Integer
            nCantig = Me.pcTabGasx.Tables(0).Rows.Count()
            eCredgas.Eliminarporcuenta(Me.pcCodCre)
            eCredgas.EliminarporcuentaPropuesta(Me.pcCodCre, Me.pcCodUsu)
            nElem = 0
            Dim lngasdes0 As Double = 0
            Dim lcnrodoc As String = ""
            Dim ekardex As New cCredkar
            lcnrodoc = ekardex.obtenercnrodoc(Me.pcCodCre.Trim)

            Dim lcnrocuo As String
            For Each Filapt In Me.pcTabGasx.Tables(0).Rows
                If Me.pcTabGasx.Tables(0).Rows(nElem)("cDesCob") = "D" Then
                    entidadCredgas.ccodcta = Me.pcCodCre
                    entidadCredgas.ccodusu = Me.pcCodUsu
                    entidadCredgas.cdescob = Me.pcTabGasx.Tables(0).Rows(nElem)("cDesCob")
                    entidadCredgas.cestado = ""
                    entidadCredgas.cflag = "1"
                    entidadCredgas.cnrocuo = lcnrodoc
                    entidadCredgas.ctipgas = Me.pcTabGasx.Tables(0).Rows(nElem)("cTipGas")
                    entidadCredgas.cusugen = Me.pcCodUsu
                    entidadCredgas.dfecgen = Me.dFecsis
                    entidadCredgas.dfecmod = MyDate
                    entidadCredgas.dfecpag = MyDate
                    entidadCredgas.nmongas = Math.Round(Filapt("ngasto"), 2)
                    entidadCredgas.nmonpag = 0
                    entidadCredgas.ngasori = Math.Round(Filapt("ngasto"), 2)
                    'If entidadCredgas.ctipgas = "01" Then 'Solo ha estos gastos se cobra IVA
                    '    lngasdes0 = lngasdes0 + entidadCredgas.nmongas
                    'End If
                    eCredgas.Agregar(entidadCredgas)
                    eCredgas.AgregarPropuesta(entidadCredgas)
                Else 'Se agregan los gastos de las cuotas
                    lcnrocuo = Me.pcTabGasx.Tables(0).Rows(nElem)("cNroCuo")
                    If lcnrocuo.Trim.Length = 1 Then
                        lcnrocuo = "00" + lcnrocuo.Trim
                    ElseIf lcnrocuo.Trim.Length = 2 Then
                        lcnrocuo = "0" + lcnrocuo.Trim
                    End If
                    entidadCredgas.ccodcta = Me.pcCodCre
                    entidadCredgas.ccodusu = Me.pcCodUsu
                    entidadCredgas.cdescob = Me.pcTabGasx.Tables(0).Rows(nElem)("cDesCob")
                    entidadCredgas.cestado = ""
                    entidadCredgas.cflag = "1"
                    entidadCredgas.cnrocuo = lcnrocuo
                    entidadCredgas.ctipgas = Me.pcTabGasx.Tables(0).Rows(nElem)("cTipGas")
                    entidadCredgas.cusugen = Me.pcCodUsu
                    entidadCredgas.dfecgen = Me.dFecsis
                    entidadCredgas.dfecmod = MyDate
                    entidadCredgas.dfecpag = MyDate
                    entidadCredgas.nmongas = Math.Round(Filapt("ngasto"), 2)
                    entidadCredgas.ngasori = Math.Round(Filapt("ngasto"), 2)
                    entidadCredgas.nmonpag = 0
                    eCredgas.Agregar(entidadCredgas)
                    eCredgas.AgregarPropuesta(entidadCredgas)
                End If
                nElem = nElem + 1
            Next
            'Insertar el IVA
            'If lngasdes0 > 0 Then
            '    entidadCredgas.ccodcta = Me.pcCodCre
            '    entidadCredgas.ccodusu = Me.pcCodUsu
            '    entidadCredgas.cdescob = "D"
            '    entidadCredgas.cestado = ""
            '    entidadCredgas.cflag = ""
            '    entidadCredgas.cnrocuo = "001" 'Me.pcTabGasx.Tables(0).Rows(nElem)("cNroCuo")
            '    entidadCredgas.ctipgas = "IV"
            '    entidadCredgas.cusugen = Me.pcCodUsu
            '    entidadCredgas.dfecgen = Me.dFecsis
            '    entidadCredgas.dfecmod = MyDate
            '    entidadCredgas.dfecpag = MyDate
            '    entidadCredgas.nmongas = Math.Round(lngasdes0 * 0.12, 2)
            '    entidadCredgas.nmonpag = 0
            '    eCredgas.Agregar(entidadCredgas)
            'End If
            Dim lncomhip As Double = 0
            'lncomhip = Me.Comision_Hipotecaria
            'If lncomhip > 0 Then
            '    entidadCredgas.ccodcta = Me.pcCodCre
            '    entidadCredgas.ccodusu = Me.pcCodUsu
            '    entidadCredgas.cdescob = "D"
            '    entidadCredgas.cestado = ""
            '    entidadCredgas.cflag = ""
            '    entidadCredgas.cnrocuo = "001" 'Me.pcTabGasx.Tables(0).Rows(nElem)("cNroCuo")
            '    entidadCredgas.ctipgas = "08"
            '    entidadCredgas.cusugen = Me.pcCodUsu
            '    entidadCredgas.dfecgen = Me.dFecsis
            '    entidadCredgas.dfecmod = MyDate
            '    entidadCredgas.dfecpag = MyDate
            '    entidadCredgas.nmongas = Math.Round(lncomhip, 2)
            '    entidadCredgas.nmonpag = 0
            '    eCredgas.Agregar(entidadCredgas)
            'End If
        End If
    End Sub

    Public Sub Actualiza_Credgas()
        Me.Borrar_Credgas()
        Me.Insertar_Credgas()
    End Sub

    Public Function Comision_Hipotecaria() As Double
        Dim dsgh As New DataSet
        Dim lncomhip As Double
        Dim entidadcrepgar As New cCrepgar
        Dim lnporhip As Double
        dsgh = entidadcrepgar.ObtenerGarHipo(Me.pcCodCre)
        If dsgh.Tables(0).Rows.Count = 0 Then
            Return 0
        End If
        lnporhip = dsgh.Tables(0).Rows(0)("nnumtab")
        lncomhip = Math.Round((Me.nMonDes / 100) * lnporhip, 2)
        If lncomhip < 8.86 Then
            lncomhip = 8.86
        End If
        Return lncomhip
    End Function
    Public Sub Actualiza_Credgas_IVA()
        Dim MyDate As DateTime
        MyDate = Today()
        'Elimina Gasto
        Dim entidadCredgas As New credgas
        Dim ecredgas As New cCredgas
        entidadCredgas.ccodcta = Me.pcCodCre
        entidadCredgas.ctipgas = Me.cTipGas
        entidadCredgas.cnrocuo = Me.cNrocuo
        entidadCredgas.cdescob = Me.cDesCob
        ecredgas.Eliminar(entidadCredgas)
        'Agrega Gasto
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        entidadCredgas.ccodcta = Me.pcCodCre
        entidadCredgas.ccodusu = Me.pcCodUsu
        entidadCredgas.cdescob = Me.cDesCob
        entidadCredgas.cestado = ""
        entidadCredgas.cflag = ""
        entidadCredgas.cnrocuo = Me.cNrocuo
        entidadCredgas.ctipgas = Me.cTipGas
        entidadCredgas.cusugen = Me.pcCodUsu
        entidadCredgas.dfecgen = Me.dFecsis
        entidadCredgas.dfecmod = MyDate
        entidadCredgas.dfecpag = MyDate
        entidadCredgas.nmongas = Me.nMonGas
        entidadCredgas.nmonpag = 0
        ecredgas.Agregar(entidadCredgas)
    End Sub
    Public Sub Actualizar_Credchq()
        Dim ecredchq As New cCredchq
        Dim entidadCredchq As New credchq
        Dim dsChq As New DataSet
        Dim nelem As Integer
        Dim nelem1 As Integer = 0
        dsChq = ecredchq.ObtenerDataSetPorID(Me.pcCodCre)
        nelem = dsChq.Tables(0).Rows.Count
        entidadCredchq.ccodcta = Me.pcCodCre
        If nelem = 0 Then  'No existe en tabla se insertara
            entidadCredchq.ccodbco = ""
            entidadCredchq.ccodusu = Me.pcCodUsu
            entidadCredchq.cctacte = ""
            entidadCredchq.cdescob = "D"
            entidadCredchq.cestado = ""
            entidadCredchq.cnomchq = Me.cNomChq
            entidadCredchq.cflag = ""
            entidadCredchq.cnrochq = ""
            entidadCredchq.cnrodoc = "0001"
            ecredchq.Agregar(entidadCredchq)
        Else 'Se modificara
            Dim nfila1 As DataRow
            For Each nfila1 In dsChq.Tables(0).Rows
                entidadCredchq.ccodbco = dsChq.Tables(0).Rows(nelem1)("ccodbco")
                entidadCredchq.ccodusu = Me.pcCodUsu
                entidadCredchq.cctacte = dsChq.Tables(0).Rows(nelem1)("cctacte")
                entidadCredchq.cdescob = dsChq.Tables(0).Rows(nelem1)("cDesCob")
                entidadCredchq.cestado = dsChq.Tables(0).Rows(nelem1)("cestado")
                entidadCredchq.cflag = ""
                entidadCredchq.cnomchq = Me.cNomChq
                entidadCredchq.cnrochq = dsChq.Tables(0).Rows(nelem1)("cnrochq")
                entidadCredchq.cnrodoc = dsChq.Tables(0).Rows(nelem1)("cnrodoc")
                ecredchq.ActualizarCredchq(entidadCredchq)
                nelem1 += 1
            Next
        End If
    End Sub

    Public Function Garantizados(ByVal pccodcli As String) As DataSet
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsgarantia As New DataSet
        Try
            SqlConnection1 = New System.Data.SqlClient.SqlConnection
            SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
            ds = New DataSet
            SqlConnection1.ConnectionString = cnnStr
            SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
            SqlSelectCommand1.CommandText = "Select MAX(TABTTAB.cDesCri) as cdescri, max(left(climgar.ctipgar,2)) as ctipgar FROM CLIMGAR, TABTTAB where  CLIMGAR.cCodcli= " & "'" & pccodcli & "'" & " and  TABTTAB.cCodTab + TABTTAB.cTipReg = '0741' and  LEFT(Climgar.cTipGar,2) = LEFT(TABTTAB.cCodigo,2)  GROUP BY TABTTAB.cCodigo ORDER BY ctipgar desc "
            SqlSelectCommand1.Connection = SqlConnection1
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1
            SqlDataAdapter1.Fill(dsgarantia, "garant")
            Return dsgarantia
        Catch ex As Exception
        End Try
    End Function

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    'Función para Gastos especiales

    Public Function OtrosGastos()
        'Dim pccodlin1 As String
        'Dim plsegdeu1 As Boolean
        'Dim pcaplcom As String
        'Dim entidadcretlin As New cretlin
        'Dim ecretlin As New cCretlin

        'entidadcretlin.cnrolin = Me.cNrolin
        'ecretlin.ObtenerCretlinPorllave(entidadcretlin)
        'pccodlin1 = entidadcretlin.ccodlin
        'plsegdeu1 = entidadcretlin.lsegdeu



        'If pccodlin1.Substring(8, 2) = "06" Then
        '    pcaplcom = "0"
        'Else
        '    pcaplcom = "1"
        'End If
        'If plsegdeu1 = True Then
        '    pcaplcom = pcaplcom & "1"
        'Else
        '    pcaplcom = pcaplcom & "0"
        'End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'Comisiones no Definidas en la CRETGAS - Special
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<    

        'Verificamos si aplica comision a pretamos personales
        'If pcaplcom.Substring(0, 1) = "1" Then
        '    Me.pnComPer = Math.Round((Me.nMonDes * (Me.pnComtra / 100) * IIf(Me.cCodFor = "1", Me.nPerDia, 31)) / gnperbas, 2) 'Me.gnperbas
        'Else
        Me.pnComPer = 0
        'End If
        ''Verificamos si aplica comision a Seguro de Deuda
        '' If pcaplcom.Substring(1, 1) = "1" Then
        'If plsegdeu1 = True Then
        '    fxSegDeu()
        'Else
        Me.pnSegDeu = 0
        'End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Function

    Public Function fxSegDeu()
        Me.pnSegDeu = Math.Round(IIf(Me.cCodFor = "1", (Me.nMonDes * Me.pnSegVm * (Me.nPerDia / 31)), (Me.nMonDes * Me.pnSegVm)), 2)
    End Function

    Public Function formapago(ByVal ctipper As String, ByVal ndia As Integer, ByVal nnumcuo As Integer) As String
        Dim lcforma As String
        Dim lcforma1 As String
        If ctipper = "2" Then 'Fecha Fija
            lcforma = "MENSUALES"
        ElseIf ctipper = "1" Then 'Periodo Fijo
            If ndia = 1 Then
                lcforma = "DIARIAS"
            ElseIf ndia = 7 Or ndia = 8 Then
                lcforma = "SEMANALES"
            ElseIf ndia = 14 Or ndia = 15 Then
                lcforma = "QUINCENALES"
            ElseIf ndia >= 28 And ndia <= 31 Then
                lcforma = "MENSUALES"
            ElseIf ndia = 60 Then
                lcforma = "BIMENSUALES"
            ElseIf ndia = 90 Then
                lcforma = "TRIMESTRALES"
            ElseIf ndia = 120 Then
                lcforma = "CADA CUATRO MESES"
            ElseIf ndia = 180 Then
                lcforma = "SEMESTRALES"
            ElseIf ndia >= 360 And ndia <= 365 Then
                lcforma = "ANUALES"
            Else
                lcforma = "NO DEFINIDO"
            End If
        End If

        lcforma1 = nnumcuo.ToString & " CUOTA(S) " & lcforma
        If nnumcuo = 1 Then
            lcforma1 = "una cuota al vencimiento de  "
        End If
        Return lcforma1
    End Function
    Public Function _StrTo128C(ByVal tcString As String) As String

        Dim lcStart, lcStop, lcCheck, lcCar, lnI, lnCheckSum, lnAsc, Fn1, pares, valorMod
        Dim lnLong As Long
        Dim lnresiduo As Long
        Dim lnnumero As Long
        Dim lcRet As String

        lcStart = Chr(105 + 32)
        Fn1 = Chr(102 + 32)
        lcStop = Chr(106 + 32)
        lnCheckSum = 207
        pares = 2

        lcRet = tcString.Trim
        lnLong = Len(lcRet)


        '*--- La longitud debe ser par
        lnnumero = Math.DivRem(lnLong, 2, lnresiduo)
        '     IF MOD(lnLong,2) # 0
        If lnresiduo <> 0 Then
            lcRet = "0" + lcRet
            lnLong = Len(lcRet)
        End If

        '	*--- Convierto los pares a caracteres

        lcCar = ""
        For lnI = 0 To lnLong - 1 Step 2
            'lcCar = lcCar + Chr(Val(SUBS(lcRet, lnI, 2)) + 32)
            lcCar = lcCar + Chr(Val((lcRet.Substring(lnI, 2))) + 32)

            lnCheckSum = lnCheckSum + (Int(Val((lcRet.Substring(lnI, 2)))) * pares)
            pares = pares + 1
        Next lnI
        lcRet = lcCar
        lnnumero = Math.DivRem(lnCheckSum, 103, lnresiduo)

        valorMod = lnresiduo 'MOD(lnCheckSum,103)
        If valorMod < 95 And valorMod > 0 Then
            lcCheck = Chr(valorMod + 32)
        Else
            If valorMod > 94 Then
                lcCheck = Chr(valorMod + 100)
            Else
                If valorMod = 0 Then
                    lcCheck = Chr(232)
                End If
            End If
        End If

        lcRet = lcStart + Fn1 + lcRet + lcCheck + lcStop
        lnLong = Len(lcRet)


        lcRet = lcRet.Replace(Chr(32), Chr(232))
        lcRet = lcRet.Replace(Chr(127), Chr(192))
        lcRet = lcRet.Replace(Chr(128), Chr(193))

        Return lcRet

    End Function
    Public Function frecuencia(ByVal ctipper As String, ByVal ndia As Integer) As String
        Dim lcforma As String
        If ctipper = "2" Then 'Fecha Fija
            lcforma = "MENSUAL"
        ElseIf ctipper = "1" Then 'Periodo Fijo
            If ndia = 1 Then
                lcforma = "DIARIO"
            ElseIf ndia = 7 Or ndia = 8 Then
                lcforma = "SEMANAL"
            ElseIf ndia = 14 Or ndia = 15 Then
                lcforma = "QUINCENAL"
            ElseIf ndia >= 28 And ndia <= 31 Then
                lcforma = "MENSUAL"
            ElseIf ndia = 60 Then
                lcforma = "BIMENSUAL"
            ElseIf ndia = 90 Then
                lcforma = "TRIMESTRAL"
            ElseIf ndia = 120 Then
                lcforma = "CADA CUATRO MESES"
            ElseIf ndia = 180 Then
                lcforma = "SEMESTRAL"
            ElseIf ndia >= 360 And ndia <= 365 Then
                lcforma = "ANUAL"
            Else
                lcforma = "C/" & ndia.ToString.Trim & " DIAS"
            End If
        End If
        Return lcforma
    End Function
    '>>>>>>>>>>>>>>>>>>
    Public Function cierres_contabilidad_traslado(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal nomserver As String) As Integer
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsgarantia As New DataSet
        Dim nombre_tabla As String
        Dim cnnstr1 As String
        Dim nombase As String
        Dim baseorigen As String = "FUNDEA"

        Dim nomorigen As String
        nombase = "D" & ldfecha2.Year.ToString.Trim
        cnnstr1 = "server=" & nomserver & ";" & "database=" & nombase & ";" & "uid=sa; pwd=Fundea$%"
        'cnnstr1 = "server=" & nomserver & ";" & "database=" & nombase & ";" & "uid=sa; pwd=Fundea$%"

        'inserta cntamov
        nombre_tabla = nombase.Trim & ".dbo.cntamov"
        nomorigen = baseorigen.Trim & ".dbo.cntamov"

        myconnection = New SqlConnection(cnnstr1)

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()

        nombre_tabla = nombase.Trim & ".dbo.diario"
        nomorigen = baseorigen.Trim & ".dbo.diario"

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()

        nombre_tabla = nombase.Trim & ".dbo.ctbdchq"
        nomorigen = baseorigen.Trim & ".dbo.ctbdchq"

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()

        nombre_tabla = nombase.Trim & ".dbo.ctbmcta"
        nomorigen = baseorigen.Trim & ".dbo.ctbmcta"

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()

        nombre_tabla = nombase.Trim & ".dbo.tabtbco"
        nomorigen = baseorigen.Trim & ".dbo.tabtbco"

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()

        'nombre_tabla = nombase.Trim & ".dbo.ctbmpol"
        'nomorigen = baseorigen.Trim & ".dbo.ctbmpol"

        'sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.CommandTimeout = 0
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        nombre_tabla = nombase.Trim & ".dbo.tabtofi"
        nomorigen = baseorigen.Trim & ".dbo.tabtofi"

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()

        nombre_tabla = nombase.Trim & ".dbo.tabttab"
        nomorigen = baseorigen.Trim & ".dbo.tabttab"

        sql = " SELECT * INTO " & nombre_tabla & " FROM " & nomorigen
        cmd = New SqlCommand(sql, myconnection)
        myconnection.Open()
        cmd.CommandTimeout = 0
        cmd.ExecuteNonQuery()
        myconnection.Close()


        Return 1

        '       Catch ex As Exception
        '      Return 0
        '     End Try


        'Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        'Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        'Dim ds As DataSet
        'Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        'Dim dsgarantia As New DataSet
        'Dim nombre_tabla As String
        'Dim cnnstr1 As String
        'Dim nombase As String
        'Dim baseorigen As String = "INTEGRAL"

        'Dim nomorigen As String
        'nombase = "D" & ldfecha2.Year.ToString.Trim
        'cnnstr1 = "server=" & nomserver & ";" & "database=" & nombase & ";" & "uid=sa; pwd=SA2009$"

        'nombre_tabla = "cntamov"

        ''        Try
        ''crea cntamov
        'myconnection = New SqlConnection(cnnstr1)
        'sql = "CREATE TABLE " & nombre_tabla & "(" & "ffondos char(2), " & "cnumcom char(8) NOT NULL, " & "cnumlin numeric(10,0) NOT NULL," & "ccodcta varchar(20)," & "ndebe numeric(17,2)," & "nhaber numeric(17,2)," & "dfeccnt datetime," & "cclase char(2), " & "cflc char(3), " & "cnumdoc char(18), " & "ccodpres char(18), " & "cconcepto varchar(254), " & "cpoliza char(3), " & "ccodofi char(3), " & "dfecmod datetime, " & "ccodreg char(3), " & "ccodsec char(2), " & "nfln numeric(5,0), " & "cnumpol char(14), " & "ccodusu1 char(4), " & "ccodcli char(12), " & "cnumrec char(18) " & ")"
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''crea diario
        'nombre_tabla = "diario"
        'sql = "CREATE TABLE " & nombre_tabla & "(" & "cnumcom char(8) NOT NULL, " & "ccodofi char(3)," & "cglosa  varchar(MAX)," & "cnumdoc char(10)," & "dfeccnt datetime," & "dfecdoc datetime, " & "cestado char(1), " & "dfecmod datetime, " & "ffondos char(2), " & "cnrodoc char(10), " & "ccodreg char(3), " & "ccodusu char(4), " & "ctipasi char(3), " & "nfln Numeric(5,0) " & ")"
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''crea ctbdchq
        'nombre_tabla = "ctbdchq"
        'sql = "CREATE TABLE " & nombre_tabla & "(" & "cnumcom char(8) NOT NULL, " & "ccodbco char(50)," & "cctacte char(50)," & "cnrochq char(10)," & "cnomchq char(70)," & "cmonchq numeric(12,2), " & "cflc char(1), " & "cnomcta char(20), " & "dfeccnt2 datetime, " & "lprint bit, " & "cmonlet varchar(256) " & ")"
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''crea ctbmcta
        'nombre_tabla = "ctbmcta"
        'sql = "CREATE TABLE " & nombre_tabla & "(" & "ccodcta char(18) NOT NULL, " & "ctipmon char(1)," & "ctipcta char(2)," & "cnivel char(2)," & "cclase char(1)," & "cdescrip varchar(MAX), " & "nsalini numeric(17,2), " & "ndebeac numeric(17,2), " & "nhaberac numeric(17,2), " & "ccodto char(3), " & "dfecreg datetime, " & "dfecmod datetime, " & "ccodusu char(4), " & "cgu char(1), " & "cctasup char(18) " & ")"
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''crea tabtbco
        'nombre_tabla = "tabtbco"
        'sql = "CREATE TABLE " & nombre_tabla & "(" & "ccodbco char(50) NOT NULL, " & "cnombco char(60)," & "ctipcta char(1)," & "cctacte char(18)," & "ccodcta char(18)," & "cnocorr char(10), " & "saldant numeric(17,2), " & "ncargos numeric(17,2), " & "nabonos numeric(17,2), " & "saldact numeric(17,2), " & "uso bit, " & "cfondos char(2), " & "ccodreg char(3), " & "cgrupo char(20), " & "ccodofi char(3) " & ")"
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()


        ''inserta movimientos de base progresemos a  nuevo backup

        ''inserta cntamov
        'nombre_tabla = nombase.Trim & ".dbo.cntamov"
        'nomorigen = baseorigen.Trim & ".dbo.cntamov"

        'myconnection = New SqlConnection(Me.cnnStr)

        'sql = "INSERT INTO " & nombre_tabla & "(" & "ffondos, cnumcom, cnumlin, ccodcta, ndebe, nhaber, dfeccnt, cclase, cnumdoc, ccodpres, cconcepto, cpoliza, ccodofi, dfecmod, cflc, ccodreg, ccodsec, nfln, cnumpol, ccodusu1, ccodcli, cnumrec) " & "SELECT ffondos, cnumcom, cnumlin, ccodcta, ndebe, nhaber, dfeccnt, cclase, cnumdoc, ccodpres, cconcepto, cpoliza, ccodofi, dfecmod, cflc, ccodreg, ccodsec, nfln, cnumpol, ccodusu1, ccodcli, cnumrec FROM " & nomorigen
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.CommandTimeout = 0
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''inserta diario
        'nombre_tabla = nombase.Trim & ".dbo.diario"
        'nomorigen = baseorigen.Trim & ".dbo.diario"
        'sql = "INSERT INTO " & nombre_tabla & "(" & "cnumcom, ccodofi, cglosa, cnumdoc, dfeccnt, dfecdoc, dfecmod, ffondos, cnrodoc, ccodreg, ccodusu, ctipasi, nfln)" & " SELECT cnumcom, ccodofi, cglosa, cnumdoc, dfeccnt, dfecdoc, dfecmod, ffondos, cnrodoc, ccodreg, ccodusu, ctipasi, nfln  FROM  " & nomorigen
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()


        ''inserta ctbdchq
        'nombre_tabla = nombase.Trim & ".dbo.ctbdchq"
        'nomorigen = baseorigen.Trim & ".dbo.ctbdchq"
        'sql = "INSERT INTO " & nombre_tabla & "(" & "cnumcom, ccodbco, cctacte, cnrochq, cnomchq, cmonchq, cflc, cnomcta, dfeccnt2, lprint, cmonlet)" & " SELECT cnumcom, ccodbco, cctacte, cnrochq, cnomchq, cmonchq, cflc, cnomcta, dfeccnt2, lprint, cmonlet  FROM  " & nomorigen
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''inserta ctbmcta
        'nombre_tabla = nombase.Trim & ".dbo.ctbmcta"
        'nomorigen = baseorigen.Trim & ".dbo.ctbmcta"
        'sql = "INSERT INTO " & nombre_tabla & "(" & "ccodcta, ctipmon, ctipcta, cnivel, cclase, cdescrip, nsalini, ndebeac, nhaberac, ccodto, dfecreg, dfecmod, ccodusu, cgu, cctasup) " & " SELECT ccodcta, ctipmon, ctipcta, cnivel, cclase, cdescrip, nsalini, ndebeac, nhaberac, ccodto, dfecreg, dfecmod, ccodusu, cgu, cctasup  FROM  " & nomorigen
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()

        ''inserta tabtbco
        'nombre_tabla = nombase.Trim & ".dbo.tabtbco"
        'nomorigen = baseorigen.Trim & ".dbo.tabtbco"
        'sql = "INSERT INTO " & nombre_tabla & "(" & "ccodbco, cnombco, ctipcta, cctacte, ccodcta, cnocorr, saldant, ncargos, nabonos, saldact, uso, cfondos, ccodreg, cgrupo, ccodofi) " & " SELECT ccodbco, cnombco, ctipcta, cctacte, ccodcta, cnocorr, saldant, ncargos, nabonos, saldact, uso, cfondos, ccodreg, cgrupo, ccodofi  FROM  " & nomorigen
        'cmd = New SqlCommand(sql, myconnection)
        'myconnection.Open()
        'cmd.ExecuteNonQuery()
        'myconnection.Close()


        'Return 1

        ''       Catch ex As Exception
        ''      Return 0
        ''     End Try

    End Function

    Sub cierre_cntamov()
        Dim clsprin As New class1
        Dim dscierre As New DataSet
        Dim dscntamov As New DataSet
        Dim mcntamov As New cCntamov
        Dim ecntamov As New cntamov
    End Sub




    Public Function llama_sp_cierre_contable(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal nomserver As String) As Integer

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Dim lcnombre1, lcnombre2, lcnombre3 As String
        lcnombre1 = "cntamov" & ldfecha1.Year.ToString.Trim
        lcnombre2 = "diario" & ldfecha1.Year.ToString.Trim
        lcnombre3 = "ctbdchq" & ldfecha1.Year.ToString.Trim

        Try

            '***************  actualiza saldos iniciales de ctbmcta *************

            Dim classconta As New clsConta
            Dim dsbalance As New DataSet
            Dim ectbmcta As New ctbmcta
            Dim mctbmcta As New cCtbmcta
            Dim dr As DataRow

            classconta.dFecfin = ldfecha2
            '  dsbalance = classconta.GenBalance(ldfecha1, ldfecha2, "G")

            'ya no se trasladan saldos iniciales
            'For Each dr In dsbalance.Tables(0).Rows
            'ectbmcta.ccodcta = dr("ccodcta")
            'mctbmcta.ObtenerCtbmcta(ectbmcta)
            'ectbmcta.nsalini = dr("nsalfin")
            'If Left(dr("ccodcta"), 1) = "5" Or Left(dr("ccodcta"), 1) = "4" Then
            'ectbmcta.nsalini = 0
            'End If
            'mctbmcta.ActualizarCtbmcta(ectbmcta)
            ' Next


            Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
            Dim oCommand As SqlClient.SqlCommand = _
                    New SqlClient.SqlCommand("CIERRE_CONTABLE", oConexion)
            Dim oParameter As SqlClient.SqlParameter
            oParameter = oCommand.Parameters.Add("@ldfecha1", SqlDbType.DateTime)
            oParameter.Value = ldfecha1
            oParameter = oCommand.Parameters.Add("@ldfecha2", SqlDbType.DateTime)
            oParameter.Value = ldfecha2
            oParameter = oCommand.Parameters.Add("@nombre1", SqlDbType.VarChar)
            oParameter.Value = lcnombre1
            oParameter = oCommand.Parameters.Add("@nombre2", SqlDbType.VarChar)
            oParameter.Value = lcnombre2
            oParameter = oCommand.Parameters.Add("@nombre3", SqlDbType.VarChar)
            oParameter.Value = lcnombre3
            oParameter = oCommand.Parameters.Add("@ok", SqlDbType.Int)
            oParameter.Value = 1

            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New DataSet
            oDa.Fill(oDs)

            oDs.Dispose()
            oDa.Dispose()
            oCommand.Dispose()
            oConexion.Close()
            oConexion.Dispose()

            Return 1

        Catch ex As Exception
            Return 0
        End Try
    End Function




    Public Function cierre_crea_partidas_iniciales(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal nomserver As String) As Integer


        Dim classconta As New clsConta
        Dim mcntamov As New cCntamov
        Dim mtabtofi As New cTabtofi
        Dim dsoficinas As New DataSet
        Dim dsfondos As New DataSet
        Dim droficinas As DataRow
        Dim drfondos As DataRow
        Dim mtabttab As New cTabttab
        Dim lcoficina As String
        Dim lcfondo As String
        Dim dsbalance As New DataSet
        Dim lnnumlin As Integer
        Dim ldfecha As Date
        Dim cclase As New crefunc

        Dim entidaddiario As New diario
        Dim drcuentas As DataRow
        Dim lcnumpar As String
        Dim ediario As New cDiario
        Dim entidadcntamov As New cntamov
        Dim ecntamov As New cCntamov
        Dim clssdes As New clsDesembolsa
        Dim lcyears As String
        lcyears = Me.pcyears

        ldfecha = ldfecha2.AddDays(1)

        dsoficinas = mtabtofi.ObtenerDataSetPorID()
        dsfondos = mtabttab.ObtenerDataSetPorID("033", "1")
        lnnumlin = 0
        lcnumpar = cclase.fxStevo(ldfecha) 'Numero de Partida
        'hace partida
        Dim lnflag As Integer = 0
        Dim okmov As Integer

        Try


            For Each droficinas In dsoficinas.Tables(0).Rows
                lcoficina = droficinas("ccodofi")
                lcoficina = lcoficina.Trim

                For Each drfondos In dsfondos.Tables(0).Rows
                    lcfondo = drfondos("ccodigo")
                    'lcfondo = clssdes.ConvertidorFondos(lcfondo.Trim)

                    'Genera balance de comprobacion
                    classconta.pcCodofi = lcoficina
                    classconta.pcFuente = lcfondo
                    classconta.pcyears = lcyears
                    classconta.pccierre = "0"
                    classconta.dFecfin = ldfecha2
                    classconta.pcnomser = Me.pcnomser

                    dsbalance = classconta.GenComprobacionNivel(ldfecha1, ldfecha2, "bc", "99")


                    'dsbalance = mcntamov.Obtener_Saldos_fondos_oficina_CuentasdeResultado(ldfecha1, ldfecha2, lcfondo, lcoficina)

                    If dsbalance.Tables(0).Rows.Count > 0 Then

                        If lnflag = 0 Then
                            entidaddiario.cnumcom = lcnumpar
                            entidaddiario.cglosa = "Partidas de Apertura Año Fiscal " & ldfecha.Year.ToString & " fondo: " & lcfondo & " Oficina: " & lcoficina
                            entidaddiario.cnumdoc = "Apert"
                            entidaddiario.dfeccnt = ldfecha
                            entidaddiario.cestado = " "
                            entidaddiario.ccodofi = lcoficina
                            entidaddiario.ffondos = lcfondo
                            entidaddiario.dfecdoc = ldfecha
                            entidaddiario.dfecmod = Now

                            entidaddiario.ctipasi = "01"
                            entidaddiario.ctipmon = "1"
                            entidaddiario.ccodruc = "01"
                            entidaddiario.ccodemp = "01"
                            entidaddiario.ccodusu = Me.pcCodUsu
                            entidaddiario.nccompra = 0.0
                            entidaddiario.ncventa = 0.0
                            entidaddiario.ntcfijo = 0.0
                            entidaddiario.cnrodoc = " "
                            entidaddiario.cfv = " "
                            entidaddiario.nfln = 0.0
                            entidaddiario.ccodrev = " "
                            entidaddiario.ccodreg = "001"

                            ediario.agregarDiario(entidaddiario)
                            lnflag += 1
                        End If



                        For Each drcuentas In dsbalance.Tables(0).Rows
                            If drcuentas("ccodto") = "D" And drcuentas("nsalfin") <> 0 Then


                                lnnumlin = lnnumlin + 1
                                entidadcntamov.cnumcom = lcnumpar

                                entidadcntamov.ccodcta = drcuentas("ccodcta")


                                entidadcntamov.cnumlin = lnnumlin

                                If Left(drcuentas("ccodcta"), 1) = "1" Or _
                                Left(drcuentas("ccodcta"), 1) = "7" Or Left(drcuentas("ccodcta"), 1) = "8" Or _
                                Left(drcuentas("ccodcta"), 1) = "9" Then

                                    If drcuentas("nsalfin") > 0 Then 'Al debe

                                        entidadcntamov.ndebe = drcuentas("nsalfin")
                                        entidadcntamov.nhaber = 0

                                    Else 'Al Haber

                                        entidadcntamov.nhaber = Math.Abs(drcuentas("nsalfin"))
                                        entidadcntamov.ndebe = 0

                                    End If
                                Else
                                    If drcuentas("nsalfin") < 0 Then 'Al debe

                                        entidadcntamov.ndebe = Math.Abs(drcuentas("nsalfin"))
                                        entidadcntamov.nhaber = 0

                                    Else 'Al Haber

                                        entidadcntamov.nhaber = drcuentas("nsalfin")
                                        entidadcntamov.ndebe = 0

                                    End If

                                End If




                                entidadcntamov.ccodpres = "APERTURA"
                                entidadcntamov.cnumdoc = "APERTURA"
                                entidadcntamov.ccodofi = lcoficina
                                entidadcntamov.cflc = " "
                                entidadcntamov.dfeccnt = ldfecha
                                entidadcntamov.dfecmod = Now
                                entidadcntamov.ccodusu1 = Me.pcCodUsu
                                entidadcntamov.ffondos = lcfondo
                                entidadcntamov.cclase = Left(drcuentas("ccodcta"), 1)
                                entidadcntamov.cpoliza = "PA"

                                entidadcntamov.ccodsec = "01"
                                entidadcntamov.cconcepto = "PARTIDA INICIAL"
                                entidadcntamov.cnumpol = "001"
                                entidadcntamov.ccodreg = "001"
                                entidadcntamov.ccodcli = " "

                                ecntamov.agregarCntamov(entidadcntamov)




                            End If


                        Next
                        dsbalance.Tables.Clear()
                        dsbalance.Clear()

                        'borra movimientos de las tablas

                        okmov = borra_movimientos(ldfecha1, ldfecha2, nomserver, lcoficina, lcfondo)



                        '--------------------------------------------


                    End If 'si hay registros por fuente y fondo


                Next
            Next

            okmov = borra_encabezados(ldfecha1, ldfecha2, nomserver)
            If okmov = 1 Then
                cierra_tabla(ldfecha1, ldfecha2, "99")

            End If

            Return 1
        Catch ex As Exception
            Return 0
        End Try


    End Function

    'actualiza tabla donde guarda fecha
    Sub cierra_tabla(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal cfondo As String)

        'busca la fecha de tabla para cierre
        Dim ecntaprm As New cntaprm
        Dim mcntaprm As New cCntaprm
        Dim ldnewfec As Date
        ldnewfec = ldfecha2.AddYears(1)
        Dim lcano As String
        lcano = ldnewfec.Year.ToString.Trim
        Dim ldfechaf1 As Date
        Dim ldfechaf2 As Date
        Dim lccierre As String

        'actualiza el año anterior

        Dim ds As New DataSet
        Dim ncanti As Integer

        ds = mcntaprm.ObtenerDataSetPorID2(cfondo)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti > 0 Then
            ecntaprm.ccierre = "S"
            ecntaprm.ccodusu = "9999"
            ecntaprm.cflc = " "
            ecntaprm.cmesvig = ds.Tables(0).Rows(0)("cmesvig")
            ecntaprm.dfecfmes = ds.Tables(0).Rows(0)("dfecfmes")
            ecntaprm.dfecimes = ds.Tables(0).Rows(0)("dfecimes")
            ecntaprm.dfecmod = Date.Now
            ecntaprm.nbasdia = 0
            ecntaprm.nfln = 0
            ecntaprm.ntasama = 0
            ecntaprm.ntasama = 0
            ecntaprm.ntasame = 0
            ecntaprm.ntasame = 0
            ecntaprm.ntasmin = 0
            mcntaprm.ActualizarCntaprm(ecntaprm)

        End If

        'agrega el nuevo año

        ldfechaf1 = Date.Parse("01/01/" & lcano)
        ldfechaf2 = Date.Parse("31/12/" & lcano)
        lccierre = lcano & "01"

        ecntaprm.ccierre = "N"
        ecntaprm.ccodusu = "9999"
        ecntaprm.cflc = " "
        ecntaprm.cmesvig = lccierre
        ecntaprm.dfecfmes = ldfechaf2
        ecntaprm.dfecimes = ldfechaf1
        ecntaprm.dfecmod = Date.Now
        ecntaprm.nbasdia = 0
        ecntaprm.nfln = 0
        ecntaprm.ntasama = 0
        ecntaprm.ntasame = 0
        ecntaprm.ntasmin = 0

        mcntaprm.agregar(ecntaprm)

    End Sub




    Public Function borra_movimientos(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal nomserver As String, ByVal ccodofi As String, ByVal ffondos As String) As Integer
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsgarantia As New DataSet
        Dim nombre_tabla As String
        Dim cnnstr1 As String
        Dim nombase As String

        'cntamov
        Try

            myconnection = New SqlConnection(Me.cnnStr)
            sql = "DELETE FROM CNTAMOV WHERE DFECCNT <= " & "'" & ldfecha2 & "'" & " and ccodofi=" & "'" & ccodofi & "' and ffondos = " & "'" & ffondos & "'"
            Dim A As String
            A = sql.ToString
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.ExecuteNonQuery()
            myconnection.Close()

            ''ctbdchq
            'sql = "DELETE FROM CTBDCHQ WHERE DFECCNT2 <= " & "'" & ldfecha2 & "'"
            'cmd = New SqlCommand(sql, myconnection)
            'myconnection.Open()
            'cmd.ExecuteNonQuery()
            'myconnection.Close()

            ''diario
            'sql = "DELETE FROM DIARIO WHERE DFECCNT <= " & "'" & ldfecha2 & "'"
            'cmd = New SqlCommand(sql, myconnection)
            'myconnection.Open()
            'cmd.ExecuteNonQuery()
            'myconnection.Close()

            Return 1


        Catch ex As Exception

            Return 0

        End Try

    End Function



    Public Function crear_base_datos_cierre(ByVal ldfecha2 As Date, ByVal nomser As String)

        Dim nombase As String
        nombase = "D" & ldfecha2.Year.ToString.Trim

        Dim str As String

        Dim myConn As SqlConnection = New SqlConnection(Me.cnnStr)

        str = "USE master; CREATE DATABASE " & nombase & "; "

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Return 0
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If

        End Try

    End Function


    'inicializa numeros de partidas en cnumes
    Public Sub inicializa_numeros_de_partidas()
        Dim ecnumes As New cnumes
        Dim mcnumes As New cCnumes

        'enero
        ecnumes.numes = "01"
        ecnumes.cnumcom = "01000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'febrero
        ecnumes.numes = "02"
        ecnumes.cnumcom = "02000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'marzo
        ecnumes.numes = "03"
        ecnumes.cnumcom = "03000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'abril
        ecnumes.numes = "04"
        ecnumes.cnumcom = "04000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'mayo
        ecnumes.numes = "05"
        ecnumes.cnumcom = "05000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'junio
        ecnumes.numes = "06"
        ecnumes.cnumcom = "06000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'julio
        ecnumes.numes = "07"
        ecnumes.cnumcom = "07000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'agosto
        ecnumes.numes = "08"
        ecnumes.cnumcom = "08000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'septiembre
        ecnumes.numes = "09"
        ecnumes.cnumcom = "09000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'octubre
        ecnumes.numes = "10"
        ecnumes.cnumcom = "10000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)


        'noviembre
        ecnumes.numes = "11"
        ecnumes.cnumcom = "11000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)

        'diciembre
        ecnumes.numes = "12"
        ecnumes.cnumcom = "12000000"
        ecnumes.cierre = False
        mcnumes.ActualizarCnumes(ecnumes)


    End Sub
    Public Function formapago2(ByVal ctipper As String, ByVal ndia As Integer) As String
        Dim lcforma As String
        Dim lcforma1 As String
        If ctipper = "2" Then 'Fecha Fija
            lcforma = "MENSUALES"
        ElseIf ctipper = "1" Then 'Periodo Fijo
            If ndia = 1 Then
                lcforma = "DIARIAS"
            ElseIf ndia = 7 Or ndia = 8 Then
                lcforma = "SEMANALES"
            ElseIf ndia = 14 Or ndia = 15 Then
                lcforma = "QUINCENALES"
            ElseIf ndia >= 28 And ndia <= 31 Then
                lcforma = "MENSUALES"
            ElseIf ndia = 60 Then
                lcforma = "BIMENSUALES"
            ElseIf ndia = 90 Then
                lcforma = "TRIMESTRALES"
            ElseIf ndia = 120 Then
                lcforma = "CADA CUATRO MESES"
            ElseIf ndia = 180 Then
                lcforma = "SEMESTRALES"
            ElseIf ndia >= 360 And ndia <= 365 Then
                lcforma = "ANUALES"
            Else
                lcforma = "NO DEFINIDO"
            End If
        End If

        lcforma1 = " CUOTA(S) " & lcforma
        If ndia = 1 Then
            lcforma1 = "cuota al vencimiento  "
        End If
        Return lcforma1
    End Function
    Public Function ValorCuota(ByVal pccodcta As String) As Double
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        Dim lncuota As Decimal = 0

        entidadcremcre.ccodcta = pccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)

        lncuota = entidadcremcre.nmoncuo
        'Dim ecredppg As New cCredppg
        'Dim lncapint, lnsegdeu1, lncomision1, lncuota As Double
        'Dim mov As New creditos
        'Dim mcreditos As New ccreditos
        'lncapint = ecredppg.CapitalInteres(pccodcta)
        'mov.ccodcta = pccodcta
        'mcreditos.Obtenercreditos(mov)
        'Me.cNrolin = mov.cnrolin
        'If IsDBNull(Me.cNrolin) Or Me.cNrolin = Nothing Then
        '    Dim flag As String
        '    flag = ""
        'End If

        'Me.nMonDes = mov.ncapdes
        'Me.cCodFor = mov.ctipper
        'Me.nPerDia = mov.ndiasug
        'If IsDBNull(Me.cNrolin) Then
        '    Dim flag As String
        '    flag = ""
        'End If
        'Me.OtrosGastos()
        'lnsegdeu1 = Me.pnSegDeu
        'lncomision1 = Me.pnComPer
        'lncuota = Math.Round(lncapint + lnsegdeu1 + lncomision1, 2)
        Return lncuota
    End Function
    Public Function ValorCuotaCredtpl(ByVal pccodcta As String) As Double
        Dim ecredtpl As New cCredtpl
        Dim lncapint, lnsegdeu1, lncomision1, lncuota As Double
        Dim lnmonsug As String
        Dim mov As New creditos
        Dim mcreditos As New ccreditos
        lncapint = ecredtpl.CapitalInteres(pccodcta)
        mov.ccodcta = pccodcta
        mcreditos.Obtenercreditos(mov)
        Me.cNrolin = mov.cnrolin
        lnmonsug = mov.nmonsug
        If IsDBNull(lnmonsug) Then
            lnmonsug = 0
        End If
        If lnmonsug = 0 Then
            Me.nMonDes = mov.nmonsol
        Else
            Me.nMonDes = lnmonsug
        End If

        Me.cCodFor = mov.ctipper
        Me.nPerDia = mov.ndiasug
        Me.OtrosGastos()
        lnsegdeu1 = Math.Round(Me.pnSegDeu, 2)
        lncomision1 = Math.Round(Me.pnComPer, 2)
        lncuota = Math.Round(lncapint + lnsegdeu1 + lncomision1, 2)
        Return lncuota
    End Function
    'Public Function PlazoMeses(ByVal fechaVig As Date, ByVal fechaVen As Date) As Integer
    '    Dim lnmeses As Integer
    '    'lnmeses = Math.Ceiling(DateDiff(DateInterval.Day, fechaVig, fechaVen) / 30)
    '    lnmeses = DateDiff(DateInterval.Month, fechaVig, fechaVen)
    '    Return lnmeses
    'End Function
    Public Function Califica(ByVal pndiaatr As String, ByVal cfrecint As String) As String
        Dim pccalif As String

        If cfrecint = "S" Then          'Semanal
            If pndiaatr <= 0 Then
                pccalif = "AAA"
            ElseIf pndiaatr > 0 And pndiaatr <= 1 Then
                pccalif = "AA"
            ElseIf pndiaatr > 1 And pndiaatr <= 2 Then
                pccalif = "A"
            ElseIf pndiaatr > 2 And pndiaatr <= 4 Then
                pccalif = "B"
            ElseIf pndiaatr > 4 And pndiaatr <= 6 Then
                pccalif = "C"
            ElseIf pndiaatr > 6 And pndiaatr <= 8 Then
                pccalif = "D"
            ElseIf pndiaatr > 8 Then
                pccalif = "E"
            End If
        ElseIf cfrecint = "Q" Then      'Quincenal

            If pndiaatr <= 0 Then
                pccalif = "AAA"
            ElseIf pndiaatr > 0 And pndiaatr <= 1 Then
                pccalif = "AA"
            ElseIf pndiaatr > 1 And pndiaatr <= 2 Then
                pccalif = "A"
            ElseIf pndiaatr > 2 And pndiaatr <= 4 Then
                pccalif = "B"
            ElseIf pndiaatr > 4 And pndiaatr <= 6 Then
                pccalif = "C"
            ElseIf pndiaatr > 6 And pndiaatr <= 16 Then
                pccalif = "D"
            ElseIf pndiaatr > 16 Then
                pccalif = "E"
            End If
        ElseIf cfrecint = "M" Then      'Mensual

            If pndiaatr <= 0 Then
                pccalif = "AAA"
            ElseIf pndiaatr > 0 And pndiaatr <= 1 Then
                pccalif = "AA"
            ElseIf pndiaatr > 1 And pndiaatr <= 2 Then
                pccalif = "A"
            ElseIf pndiaatr > 2 And pndiaatr <= 4 Then
                pccalif = "B"
            ElseIf pndiaatr > 4 And pndiaatr <= 6 Then
                pccalif = "C"
            ElseIf pndiaatr > 6 And pndiaatr <= 31 Then
                pccalif = "D"
            ElseIf pndiaatr > 31 Then
                pccalif = "E"
            End If
        Else
            If pndiaatr <= 0 Then
                pccalif = "AAA"
            ElseIf pndiaatr > 0 And pndiaatr <= 1 Then
                pccalif = "AA"
            ElseIf pndiaatr > 1 And pndiaatr <= 2 Then
                pccalif = "A"
            ElseIf pndiaatr > 2 And pndiaatr <= 4 Then
                pccalif = "B"
            ElseIf pndiaatr > 4 And pndiaatr <= 6 Then
                pccalif = "C"
            ElseIf pndiaatr > 6 And pndiaatr <= 31 Then
                pccalif = "D"
            ElseIf pndiaatr > 31 Then
                pccalif = "E"
            End If
        End If


        Return pccalif
    End Function
    Public Function CalificaEstimacion(ByVal pndiaatr As String) As String
        Dim pccalif As String
        If pndiaatr <= 0 Then
            pccalif = "A"
        ElseIf pndiaatr > 0 And pndiaatr <= 30 Then
            pccalif = "B"
        ElseIf pndiaatr > 30 And pndiaatr <= 60 Then
            pccalif = "C"
        ElseIf pndiaatr > 60 And pndiaatr <= 90 Then
            pccalif = "D"
        ElseIf pndiaatr > 90 And pndiaatr <= 120 Then
            pccalif = "E"
        Else
            pccalif = "F"
        End If
        Return pccalif
    End Function

    Public Function InfoRed(ByVal ds As DataSet, ByVal ldfecha2 As Date) As Integer
        Dim clscartera As New dbCreditos
        Dim Fila As DataRow
        Dim cTransac As String
        Dim lcReturn As Integer = 1
        If ds.Tables(0).Rows.Count > 0 Then

            'Try


            myconnection = New SqlConnection(Me.cnnStr)


            'Primero Borra la Tabla

            cTransac = _
                        " Delete from Infored"


            cmd = New SqlCommand(cTransac, myconnection)

            myconnection.Open()
            cmd.ExecuteNonQuery()

            myconnection.Close()
            Dim año As String
            Dim mes As String
            Dim dia As String
            año = ldfecha2.ToString.Substring(6, 4)
            mes = ldfecha2.ToString.Substring(3, 2)
            dia = ldfecha2.ToString.Substring(0, 2)

            Dim lctipo_per As String = "1"
            Dim lcinst As String = "O1800"
            Dim plazo As Integer
            Dim lndeuda, lndeuda1 As Double
            Dim lctipoest As String
            Dim lccalifica As String
            Dim lncuomor As Integer
            Dim lcactividad As String
            Dim etabtciu As New cTabtciu
            Dim lcdui As String
            Dim etabttab As New cTabttab
            Dim lcdirdom As String
            Dim lcgenero As String
            For Each Fila In ds.Tables(0).Rows
                lcdirdom = Fila("cDirDom")
                lccalifica = Califica(Fila("ndiaatr"), Fila("CFRECINT"))
                lcactividad = etabttab.Describe(Fila("csececo"), "075") 'Left(etabtciu.CIIU(Fila("ccodact")), 60)
                lcgenero = IIf(Fila("genero") = "F", "FEMENINO", "MASCULINO")

                plazo = DateDiff(DateInterval.Month, Fila("dfecvig"), Fila("dfecven"))
                lndeuda = Math.Round(Fila("nsalcap") + Fila("nsalint"), 2)
                lndeuda1 = Math.Round(Fila("ncapmora") + Fila("nsalintmor"), 2)
                lctipoest = IIf(Fila("dfecven") < ldfecha2, "V", "A")
                lncuomor = Math.Ceiling(Fila("ndiaatr") / 31)
                lcdui = Left(Fila("cNudoci"), 10)
                Fila("cDirDom") = lcdirdom.Replace("'", "")

                If lncuomor > Fila("ncuoapr") Then
                    lncuomor = Fila("ncuoapr")
                End If
                'Ahora inserta lo Nueva Consulta
                'If Fila("ndiaatr") > 0 Then
                cTransac = _
                            " Insert Into Infored (Nombre, Num_ptmo, Fec_otor, Monto, Plazo, Saldo, Mora, Forma_pag," & _
                            " tipo_rel, linea_cre, Dias, tipo_lc, tipo_cob, ult_pag, tipo_gar, tipo_mon, " & _
                            " direccion, telefono, valcuota, DUI, NIT, cod_usu, esta_cance, fecha_can, fecha_ven, " & _
                            " Calif_act, año, mes, dia, documento, fechanac, tipo_per, inst, ncuotascre, ncuotasmor, calif_ter, calif_cli, nombre_emp, activi_eco )" & _
                            " Values (" & "'" & Fila("cNomcli") & "', " & "'" & Fila("cCodcta") & "', " & "'" & Fila("dfecvig") & "', " & _
                            Fila("nCapdes") & "," & "'" & plazo & "'" & ", " & "'" & lndeuda & "'" & ", " & "'" & lndeuda1 & "'" & ", " & "'5', " & _
                            "'" & lcgenero & "', " & "'S', " & Fila("ndiaatr") & ", " & "'" & lctipoest & "'" & "," & "'N', " & "'" & Fila("dUltpag") & "', " & _
                            "'" & Fila("cTipgar") & "', " & "'02', " & "'" & Left(Fila("cDirDom"), 72) & "', " & "'" & Fila("cTeldom") & "', " & _
                            Fila("ncuota") & ", " & "'" & lcdui & "', " & "'" & Fila("cNudotr") & "', " & "'" & Fila("cCodcli") & "', " & _
                            "'V', " & "' ', " & "'" & Fila("dfecven") & "', " & "'" & lccalifica & "'" & ", " & "'" & año & "'" & ", " & "'" & mes & "'" & _
                            ", " & "'" & dia & "'," & "' " & " '," & "'" & Fila("dnacimi") & "', " & "'" & lctipo_per & "'," & "'" & lcinst & "'," & _
                            "'" & Fila("ncuoapr") & "'," & "'" & lncuomor & "'," & "'" & " " & "'," & "'" & " " & "'," & "'" & " " & "'," & _
                            "'" & lcactividad & "'" & ")"

                cmd = New SqlCommand(cTransac, myconnection)

                myconnection.Open()
                cmd.ExecuteNonQuery()
                myconnection.Close()

                'End If

            Next



            'Catch SqlException As Exception
            'MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")

            '    lcReturn = 1
            'End Try


        End If


        Return lcReturn

    End Function

    Public Function Renta(ByVal nmonto As Double) As Double
        Dim pnrenta As Double = 0
        If nmonto >= 0.0 And nmonto <= 316.67 Then
            pnrenta = 0
        ElseIf nmonto > 316.67 And nmonto <= 469.05 Then
            pnrenta = 4.77 + Math.Round((nmonto - 316.67) * 0.1, 2)
        ElseIf nmonto > 469.05 And nmonto <= 761.91 Then
            pnrenta = 4.77 + Math.Round((nmonto - 228.57) * 0.1, 2)
        ElseIf nmonto > 761.91 And nmonto <= 1904.69 Then
            pnrenta = 60 + Math.Round((nmonto - 761.91) * 0.2, 2)
        Else
            pnrenta = 228.57 + Math.Round((nmonto - 1904.69) * 0.3, 2)
        End If
        Return pnrenta
    End Function

    Public Function ipip() As String
        Dim ip As Net.Dns
        Dim lcip As String
        Dim nombre_Host As String = ip.GetHostName

        Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)

        Dim direccion_Ip As String = este_Host.AddressList(0).ToString

        lcip = direccion_Ip
        Return lcip
    End Function
    Public Function MES(ByVal nmes As Integer) As String
        Dim cmes As String = ""
        If nmes = 1 Then
            cmes = "ENERO"
        ElseIf nmes = 2 Then
            cmes = "FEBRERO"
        ElseIf nmes = 3 Then
            cmes = "MARZO"
        ElseIf nmes = 4 Then
            cmes = "ABRIL"
        ElseIf nmes = 5 Then
            cmes = "MAYO"
        ElseIf nmes = 6 Then
            cmes = "JUNIO"
        ElseIf nmes = 7 Then
            cmes = "JULIO"
        ElseIf nmes = 8 Then
            cmes = "AGOSTO"
        ElseIf nmes = 9 Then
            cmes = "SEPTIEMBRE"
        ElseIf nmes = 10 Then
            cmes = "OCTUBRE"
        ElseIf nmes = 11 Then
            cmes = "NOMVIEMBRE"
        Else
            cmes = "DICIEMBRE"
        End If
        Return cmes
    End Function
    Function fxSteCuentaCen(ByVal p_cCodIns As String, ByVal p_cCodOfi As String) As String
        Dim lcCodCta_f As String
        Dim lcNumero_f As String
        lcCodCta_f = p_cCodIns & p_cCodOfi  '& "Z"
        Try
            ds.Tables.Clear()
            myconnection = New SqlConnection(Me.cnnStr)
            sql = "Select max(cCodsol) as ccodsol from CENTROS"

            sql = sql + " Where left(cCodSol,6) = " & "'" & lcCodCta_f & "'"

            sql = sql + " GROUP BY cCodSol"
            mycommand = New SqlDataAdapter(sql, myconnection)
            mycommand.Fill(ds, "CreGen")
            Dim lnCount As Integer = 0
            lnCount = ds.Tables("CreGen").Rows.Count
            If lnCount <= 0 Then
                lcCodCta_f = p_cCodIns & p_cCodOfi & "00000000"
            Else
                Dim lnReg As Integer = 0
                lnReg = lnCount - 1
                lcCodCta_f = ds.Tables("CreGen").Rows(lnReg)("cCodsol")
            End If
            lcNumero_f = fxStrZero(Val(lcCodCta_f.Trim.Substring(6, 6) + 1), 6)
            lcCodCta_f = Left(lcCodCta_f, 6) + lcNumero_f
            Return lcCodCta_f

        Catch ex As Exception

        End Try

    End Function
    Public Function ValorCuotaCapital(ByVal pccodcta As String) As Double
        Dim ecredppg As New cCredppg
        Dim lncapint, lnsegdeu1, lncomision1, lncuota As Double
        Dim mov As New creditos
        Dim mcreditos As New ccreditos
        lncapint = ecredppg.CuotaCapital(pccodcta)
        lncuota = Math.Round(lncapint, 2)
        Return lncuota
    End Function

    Public Function Gasto_Proporcional(ByVal ctipper As String, ByVal ndia As Integer, ByVal pngasto As Double) As Double
        Dim lngasto As Double = 0
        If ctipper = "2" Then 'Fecha Fija
            lngasto = pngasto
        ElseIf ctipper = "1" Then 'Periodo Fijo
            If ndia = 1 Then
                lngasto = Math.Round(pngasto / 30, 2)
            ElseIf ndia = 7 Or ndia = 8 Then
                lngasto = Math.Round(pngasto / 4, 2)
            ElseIf ndia = 14 Or ndia = 15 Then
                lngasto = Math.Round(pngasto / 2, 2)
            ElseIf ndia >= 28 And ndia <= 31 Then
                lngasto = Math.Round(pngasto, 2)
            ElseIf ndia = 60 Then
                lngasto = Math.Round(pngasto * 2, 2)
            ElseIf ndia = 90 Then
                lngasto = Math.Round(pngasto * 3, 2)
            ElseIf ndia = 120 Then
                lngasto = Math.Round(pngasto * 4, 2)
            ElseIf ndia = 180 Then
                lngasto = Math.Round(pngasto * 6, 2)
            ElseIf ndia >= 360 And ndia <= 365 Then
                lngasto = Math.Round(pngasto * 12, 2)
            Else
                lngasto = Math.Round(pngasto, 2)
            End If
        End If
        Return lngasto
    End Function


    Public Function RequisitosChequeados(ByVal ctipmet As String, ByVal ccodcta As String) As Boolean
        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        ds = ecremcre.PlantillaChequeo()

        Dim dsusu As New DataSet


        Dim fila As DataRow
        Dim fila1 As DataRow
        Dim i As Integer = 0
        Dim lccodchk As String
        Dim lnReq As Integer

        Dim lrespuesta As Boolean
        For Each fila In ds.Tables(0).Rows
            lccodchk = ds.Tables(0).Rows(i)("cCodchk")

            dsusu = ecremcre.UsuarioqChequearon(ccodcta)
            Dim y As Integer = 0
            Dim lflag As Boolean = False
            For Each fila1 In dsusu.Tables(0).Rows
                lflag = ecremcre.ListadoxUsuario(dsusu.Tables(0).Rows(y)("cCodusu"), ccodcta, lccodchk)
                If lflag = True Then
                    ds.Tables(0).Rows(i)("lopcion") = lflag
                    Exit For
                Else
                End If
                y += 1
            Next

            dsusu.Clear()
            'Comparamos requisito - chequeo
            If ctipmet = "01" Then 'individual
                lnReq = ds.Tables(0).Rows(i)("IND")
            ElseIf ctipmet = "02" Then ' Grupos solidarios
                lnReq = ds.Tables(0).Rows(i)("GS")
            Else
                lnReq = ds.Tables(0).Rows(i)("BC")
            End If

            If lnReq = 1 And ds.Tables(0).Rows(i)("lopcion") = False Then 'No cumple con un Requisito
                lrespuesta = False
                Exit For
            Else
                lrespuesta = True
            End If
            i += 1
        Next

        Return lrespuesta
    End Function

    Public Function ValidaLinea(ByVal cnrolin As String, ByVal nmonsug As Double, ByVal dfecvig As Date, ByVal dfecven As Date) As Boolean
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        Dim nliminf As Decimal = 0
        Dim nlimsup As Decimal = 0
        Dim nplazomin As Integer = 0
        Dim nplazomax As Integer = 0
        Dim cplazo As String = ""
        Dim lnmeses As Integer
        Dim lndias As Integer
        Dim lnmontosug As Double
        Dim lcflag As String
        Dim lcflag1 As String

        entidadCretlin.cnrolin = cnrolin
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)

        nliminf = entidadCretlin.nliminf
        nlimsup = entidadCretlin.nlimsup
        nplazomin = entidadCretlin.nplazomin
        nplazomax = entidadCretlin.nplazomax

        cplazo = entidadCretlin.ccodlin.Substring(1, 1)

        lnmontosug = nmonsug
        lnmeses = PlazoMeses(dfecvig, dfecven)

        'Verifica monto
        If lnmontosug >= nliminf And lnmontosug <= nlimsup Then
            lcflag = "1"
        Else
            lcflag = "0"
        End If

        If lnmeses >= nplazomin And lnmeses <= nplazomax Then
            lcflag1 = "1"
        Else
            lcflag1 = "0"
        End If


        If lcflag = "1" And lcflag1 = "1" Then
            Return True
        Else
            Return False
        End If


    End Function



    Public Function Valida_Monto_Comite(ByVal ccodigo As String, ByVal lnmonapr As Double) As Boolean
        Dim ds As New DataSet
        Dim mtabttab As New cTabttab
        Dim nliminf As Decimal = 0
        Dim nlimsup As Decimal = 0

        Dim lcflag As String


        ds = mtabttab.Datos_Niveles_Aprobacion(ccodigo)

        For Each fila As DataRow In ds.Tables(0).Rows
            nliminf = fila("limite_inferior")
            nlimsup = fila("limite_superior")
        Next

        'Verifica monto
        If lnmonapr >= nliminf And lnmonapr <= nlimsup Then
            lcflag = "1"
        Else
            lcflag = "0"
        End If

        If lcflag = "1" Then
            Return True
        Else
            Return False
        End If


    End Function

    Public Function fxIntPro(ByVal cCodcta As String, ByVal nAbono As Double, ByVal cnrodoc As String) As Double 'Funcion para Intereses Provisionados

        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        Dim lnProvAct As Double = 0
        Dim lnProvan As Double = 0

        ds = ecremcre.Provisionado(cCodcta)
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnProvAct = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovis")), 0, ds.Tables(0).Rows(0)("nprovis"))
            '  lnProvan = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovan")), 0, ds.Tables(0).Rows(0)("nprovan"))
        End If

        Dim lnIntProv As Double = 0
        Dim lnIntAct As Double = 0

        If nAbono >= lnProvAct Then
            lnIntProv = nAbono
            lnIntAct = 0
        Else
            lnIntProv = nAbono
            lnIntAct = Math.Round(lnProvAct - nAbono, 2)
        End If

        Dim nabono1 As Double = 0
        Dim lndesint As Double = 0

        ''Descarga Provison Acumulada del Mes

        'nabono1 = nAbono - lnProvAct

        'If nabono1 < 0 Then
        '    lndesint = lnProvan
        'Else
        '    If nabono1 >= lnProvan Then
        '        lndesint = 0
        '    Else
        '        lndesint = lnProvan - nabono1
        '    End If

        'End If

        'Actualiza provision y Traslado a Espejo de Provision
        'Verifica si existe
        Dim lverifica As Boolean
        Dim lnbandera As Integer
        lverifica = ecremcre.VerificaSiExisteEspejo(cCodcta, cnrodoc)
        If lverifica = False Then 'inserta solo el registro
            lnbandera = ecremcre.InsertaRegistroProvisionEspejo(cCodcta, cnrodoc)
        End If

        'Actualiza provision
        Try
            ecremcre.ActualizaProvisionEspejo(cCodcta, cnrodoc, lnProvAct, lnProvan)
            ecremcre.ActualizaProvision(cCodcta, lnIntAct, lndesint)
        Catch ex As Exception
            Return 0
        End Try



        Return lnIntProv


    End Function

    Public Function ProvisionDiaria(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ds As DataSet, ByVal ndias As Integer)
        Dim ecremcre As New cCremcre
        'Busca si existe registro de Provision
        Dim fila As DataRow
        Dim i As Integer
        Dim lccodcta As String
        Dim lverifica As Boolean
        Dim lnbandera As Integer
        Dim lnbandera1 As Integer
        Dim lnsalcap As Double = 0
        Dim lntasa As Double = 0
        Dim lnintdia As Double = 0
        Dim lnmordia As Double = 0
        Dim lndiaatr As Integer = 0
        Dim lnmorak As Double = 0
        Dim lntasam As Double = 0
        Dim lcestado As String
        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("cCodcta")
            lndiaatr = fila("ndiaatr")
            lcestado = fila("cestado")
            If lcestado.Trim = "F" Then


                'If lccodcta = "002002011905615348" Then
                '    lccodcta = "002002011905615348"
                'End If

                If fila("ccondic") <> "S" Then
                    lverifica = ecremcre.VerificaRegistroProvision(lccodcta)
                    If lverifica = False Then ' Agrega
                        'Inserta Registro
                        lnbandera = ecremcre.InsertaRegistroProvision(lccodcta)
                    End If
                    lnmorak = fila("ncapmora")
                    lnsalcap = fila("nSalCap")
                    lntasa = fila("ntasint")
                    lntasam = fila("ntasmor")
                    If lnsalcap > 0 Then
                        lnintdia = Math.Round(ndias * lnsalcap * lntasa / (gnperbas * 100), 2)
                        lnmordia = Math.Round(ndias * lnmorak * lntasam / (gnperbas * 100), 2)
                    Else
                        lnintdia = 0
                        lnmordia = 0
                    End If
                Else
                    lnintdia = 0
                    lnmordia = 0
                End If
                'Actualiza en credpro
                lnbandera = ecremcre.RegistraProvisionDiario(lccodcta, lnintdia, dfecha1, lnmordia)
                lnbandera1 = ecremcre.ActualizaCremcre(lccodcta, lndiaatr)
            End If

            i += 1
        Next

    End Function


    Public Function ReclasificacionDiaria(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ds As DataSet) As Integer
        Dim ecremcre As New cCremcre
        Dim clsdes As New clsDesembolsa
        'Busca si existe registro de Provision
        Dim fila As DataRow
        Dim i As Integer
        Dim lccodcta As String
        Dim lverifica As Boolean
        Dim lnbandera As Integer
        Dim lnbandera1 As Integer
        Dim lnsalcap As Double = 0
        Dim lntasa As Double = 0
        Dim lnintdia As Double = 0
        Dim lndiaatr As Integer = 0
        Dim lccondic As String = ""
        Dim ldfecven As Date
        Dim lccondicN As String = ""
        Dim ldfeclim As Date

        Dim lcampos1 As String
        Dim ltipos1 As String

        Dim lccuentad As String = ""
        Dim lccuentah As String = ""
        Dim lcestado As String

        Dim dt As New DataTable
        lcampos1 = "cCodcta,cDescri,nDebe,nHaber,cCodLin,cDesTra,ffondos,ccodofi,"
        ltipos1 = "S,S,D,D,S,S,S,"
        dt = creadatasetdesconec(lcampos1, ltipos1, "ASIENTO")
        Dim drasiento As DataRow
        Dim dsasiento As New DataSet

        'ldfeclim = DateAdd(DateInterval.Day, 8, dfecha1)

        Dim lcmetodo As String = ""
        Dim lccodlin As String = ""
        Dim lccodpres As String = ""
        Dim lccodofi As String = ""

        Dim k As Integer = 0
        k = ecremcre.EliminaAsientos()
        Dim lcaux As String = ""

        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("cCodcta")
            lnsalcap = fila("nSalCap")
            lccondic = fila("cCondic")
            lndiaatr = fila("ndiaatr")
            ldfecven = fila("dfecven")
            lccodlin = fila("ccodlin")
            lccodpres = fila("cCodpres")
            lccodofi = fila("cCodofi")
            lcestado = fila("cestado")
            If lcestado.Trim = "F" Then

                lcaux = IIf(IsDBNull(fila("ctipgar")), "01", fila("ctipgar"))

                ldfeclim = ldfecven 'DateAdd(DateInterval.Day, 7, ldfecven)
                fila("cFlgMod") = ""
                lcmetodo = lccodlin.Substring(4, 2)

                If lccondic = "J" Or lccondic = "P" Or lccondic = "R" Or lccondic = "S" Then
                Else
                    'Asigna estado Actual
                    If dfecha1 > ldfeclim Or lndiaatr >= 90 Then 'Credito ya esta vencido
                        lccondicN = "V"
                    ElseIf lndiaatr <= 0 Then 'vigentes al día
                        lccondicN = "N"
                    ElseIf lndiaatr > 0 And lndiaatr < 90 Then 'vigentes en mora
                        lccondicN = "M"
                    End If

                    If lccondic.Trim = lccondicN.Trim Then
                        fila("cFlgMod") = ""
                    Else 'Hubo cambio en la Condicion

                        'Determinamos el traslado que se dara
                        If lccondic = "N" And lccondicN = "M" Then 'de normal a mora
                            fila("cFlgMod") = "*"
                        ElseIf lccondic = "M" And lccondicN = "N" Then 'de mora a normal
                            fila("cFlgMod") = "&"
                        ElseIf lccondic = "N" And lccondicN = "V" Then 'de normal a vencidos
                            fila("cFlgMod") = "!"
                        ElseIf lccondic = "M" And lccondicN = "V" Then 'de mora a vencidos
                            fila("cFlgMod") = "?"
                        End If

                    End If

                    If fila("cFlgMod") = "*" Then
                        'Cargo Vigente en mora
                        lccuentad = CuentaContable(lcmetodo, "M", lcaux)
                        k = ecremcre.AgregaAsiento(lccuentad, "CAPITAL VIGENTE EN MORA", lnsalcap, 0, _
                                               lccodlin, "De Vigentes al día a Vigentes en Mora", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)

                        'Abono Vigente al día
                        lccuentah = CuentaContable(lcmetodo, "N", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentah, "CAPITAL VIGENTE AL DIA", 0, lnsalcap, _
                           lccodlin, "De Vigentes al día a Vigentes en Mora", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)

                        k = ecremcre.ActualizaCondicion(lccodcta, lccondicN)

                    ElseIf fila("cFlgMod") = "&" Then
                        'Cargo Vigente al día
                        lccuentad = CuentaContable(lcmetodo, "N", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentad, "CAPITAL VIGENTE AL DIA", lnsalcap, 0, _
                                                   lccodlin, "De  Vigentes en Mora a Vigentes al día", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)

                        'Abono Vigente en mora
                        lccuentah = CuentaContable(lcmetodo, "M", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentah, "CAPITAL VIGENTE EN MORA", 0, lnsalcap, lccodlin, _
                                                    "De  Vigentes en Mora a Vigentes al día", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)

                        k = ecremcre.ActualizaCondicion(lccodcta, lccondicN)
                    ElseIf fila("cFlgMod") = "!" Then
                        'Cargo Vencidos
                        lccuentad = CuentaContable(lcmetodo, "V", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentad, "CAPITAL VENCIDO", lnsalcap, 0, lccodlin, _
                                                   "De  Vigentes al día a Vencido en Cobro Admtvo ", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)


                        'Abono Vigente al día
                        lccuentah = CuentaContable(lcmetodo, "N", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentah, "CAPITAL VIGENTE AL DIA", 0, lnsalcap, _
                                                   lccodlin, "De  Vigentes al día a Vencido en Cobro Admtvo  ", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)

                        k = ecremcre.ActualizaCondicion(lccodcta, lccondicN)
                    ElseIf fila("cFlgMod") = "?" Then
                        'Cargo Vencidos
                        lccuentad = CuentaContable(lcmetodo, "V", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentad, "CAPITAL VENCIDO", lnsalcap, 0, lccodlin, _
                                                    "De  Vigentes en Mora a Vencido en Cobro Admtvo ", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)


                        'Abono Vigente en Mora
                        lccuentah = CuentaContable(lcmetodo, "M", lcaux)

                        k = ecremcre.AgregaAsiento(lccuentah, "CAPITAL VIGENTE EN MORA", 0, lnsalcap, _
                                                    lccodlin, "De  Vigentes en Mora a Vencido en Cobro Admtvo ", clsdes.ConvertidorFondos(lccodlin.Substring(2, 2).Trim), lccodlin.Substring(4, 2), lccodpres, lccodofi)

                        k = ecremcre.ActualizaCondicion(lccodcta, lccondicN)

                        If dfecha1 > ldfeclim Then 'Contractualmente

                        Else 'por dias de atraso--------------------Tendra que realizar traslado de intereses e int. moratorios

                        End If
                    End If
                End If
            End If
            i += 1
        Next

        Return k
    End Function

    Public Function CuentaContable(ByVal lcmetodo As String, ByVal condicion As String, ByVal caux As String) As String
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim cplanti As String = ""
        Dim lccodigo As String = ""
        Dim lcmascara As String = "CKPN" & condicion.Trim



        If lcmascara <> Nothing Then
            entidadtabtmak.ccodigo = lcmascara
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lcctactb = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lcctactb = cplanti.Replace("TP", lcmetodo)
                lcctactb = lcctactb.Replace("GA", caux)
            End If
        End If

        Return lcctactb

    End Function
    Public Function periodo(ByVal c_frecint As String) As Integer
        Dim p_nperdia As Integer = 30
        Select Case c_frecint
            Case "A" 'Al vencimiento
                p_nperdia = 0
            Case "E" ' semestral
                p_nperdia = 180
            Case "I" ' Bimensual
                p_nperdia = 60
            Case "M" ' mensual
                p_nperdia = 30
            Case "T" ' Trimestral
                p_nperdia = 90
            Case "B" 'Catorcenal
                p_nperdia = 14
            Case "D" 'Diario
                p_nperdia = 1
            Case "S" 'Semanal
                p_nperdia = 7
        End Select

        p_nperdia = IIf(p_nperdia < 0, 30, p_nperdia)
        Return p_nperdia
    End Function
    Public Sub GeneraPlanExportable(ByVal cCodsol As String, ByVal dfecha As Date, ByVal nciclo As Integer)
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter

        Dim ecredppg As New cCredppg
        Dim ecremsol As New cCremsol
        Dim ecremcre As New cCremcre

        Dim lcnombre As String
        lcnombre = ecremsol.ObtenerNombre(cCodsol.Trim)

        Dim ds As New DataSet
        ds = ecredppg.FechasdePago(cCodsol, dfecha)
        Dim lcarchivo As String = "c:/txt/" & lcnombre.Trim & ".txt"

        If File.Exists(lcarchivo) Then
            File.Delete(lcarchivo)
        End If

        Dim FilePath As String = lcarchivo
        'Se abre el archivo y si este no existe se crea
        strStreamW = File.OpenWrite(FilePath)
        strStreamWriter = New StreamWriter(strStreamW, _
                            System.Text.Encoding.UTF8)


        'Se traen los datos que necesitamos para el archivo
        'TraerDatosArchivo retorna un dataset pero perfectamente
        'podria ser cualquier otro tipo de objeto

        Dim fila As DataRow
        Dim ldfecvig As Date
        Dim lcfecvig As String = ""
        Dim i As Integer = 0
        Dim lccadena As String = ""
        Dim lccodigo As String = "Prestamo" 'Space(20)
        Dim lcnomcli As String = "Cliente" 'Space(60)
        Dim lccapital As String = Space(20)
        Dim lcinteres As String = Space(20)
        Dim lcnrochq As String = Space(15)
        Dim lccodana As String = ""
        Dim etabtusu As New cTabtusu
        Dim lcnomusu As String = ""
        lccodana = ecremcre.CodigoAnalistadeGrupo(cCodsol.Trim, dfecha)
        lcnomusu = etabtusu.NombreUsuario(lccodana.Trim)
        Dim lcdeslin As String = ""
        lcdeslin = ecremcre.LineadeGrupo(cCodsol.Trim, dfecha)
        Dim lcnrolin As String = ""
        Dim lcfondos As String = ""
        Dim mcretlin As New cCretlin
        lcnrolin = ecremcre.NumeroLineaGrupo(cCodsol.Trim, dfecha)
        lcfondos = mcretlin.ObtenerFuentedeFondos(lcnrolin)
        Dim ecntamov As New cCntamov
        For Each fila In ds.Tables(0).Rows
            ldfecvig = ds.Tables(0).Rows(i)("dfecven")
            lcfecvig = Me.zeros(Left(ldfecvig.ToString, 10), 15)

            lccadena = lccadena + (lcfecvig + Chr(9))

            i += 1
        Next
        strStreamWriter.WriteLine(Me.zeros("Grupo/Banco:", 20) & Chr(9) & Me.zeros(lcnombre, 60) & Chr(9) & Me.zeros("", 15) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Codigo GS/BC:", 20) & Chr(9) & Me.zeros("'" & cCodsol.Trim, 60) & Me.zeros("", 15) & Chr(9) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Linea de Crédito:", 20) & Chr(9) & Me.zeros(lcdeslin.Trim, 60) & Me.zeros("", 15) & Chr(9) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Fondo:", 20) & Chr(9) & Me.zeros(lcfondos.Trim, 60) & Chr(9) & Me.zeros("", 15) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Asesor:", 20) & Chr(9) & Me.zeros(lcnomusu.Trim, 60) & Chr(9) & Me.zeros("", 15) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Ciclo:", 20) & Chr(9) & Me.zeros("'" & nciclo.ToString.Trim, 60) & Chr(9) & Me.zeros("", 15) & Chr(9) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Fecha Desemb:", 20) & Chr(9) & Me.zeros("'" & Left(dfecha.ToString, 10), 60) & Chr(9) & Me.zeros("", 15) & Chr(9) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros("Cuotas:", 20) & Chr(9) & Me.zeros("'" & i.ToString, 60) & Chr(9) & Me.zeros("", 15) & Chr(9) & Chr(9) & "" & Me.zeros("", 15) & Chr(9) & Me.zeros("", 15))
        strStreamWriter.WriteLine(Me.zeros(lccodigo, 20) & Chr(9) & Me.zeros(lcnomcli, 60) & Chr(9) & Me.zeros("Nº Cheque", 15) & Chr(9) & lccadena & Me.zeros("Total Cap", 15) & Chr(9) & Me.zeros("Total Int", 15))
        Dim ds1 As New DataSet
        Dim fila1 As DataRow
        Dim y As Integer = 0



        ds1 = ecremcre.ObtenerClientedeGrupo(cCodsol, dfecha)
        For Each fila1 In ds1.Tables(0).Rows
            lccadena = ""

            lccodigo = ds1.Tables(0).Rows(y)("cCodcta")
            lcnomcli = Trim(ds1.Tables(0).Rows(y)("cnomcli"))
            lcnrochq = ecntamov.ObtieneChequeporCredito(lccodigo, dfecha)

            Dim ds2 As New DataSet
            Dim fila2 As DataRow
            Dim z As Integer = 0

            Dim lncapita As Double = 0
            Dim lnintere As Double = 0
            Dim lncuota As Double = 0

            Dim lntotcapita As Double = 0
            Dim lntotintere As Double = 0

            ds2 = ecredppg.PlandePagosIndividual(lccodigo)



            For Each fila2 In ds2.Tables(0).Rows
                lncapita = ds2.Tables(0).Rows(z)("ncapita")
                lnintere = ds2.Tables(0).Rows(z)("nintere")
                lncuota = lncapita + lnintere

                lccadena = lccadena + (Me.zeros(lncuota.ToString, 15) + Chr(9))

                lntotcapita = lntotcapita + lncapita
                lntotintere = lntotintere + lnintere

                z += 1
            Next
            lccadena = lccadena + (Me.zeros(lntotcapita.ToString, 15) + Chr(9) + Me.zeros(lntotintere.ToString, 15))
            strStreamWriter.WriteLine(Me.zeros("'" & lccodigo, 20) & Chr(9) & Me.zeros(lcnomcli, 60) & Chr(9) & Me.zeros(lcnrochq, 15) & Chr(9) & lccadena)
            y += 1
        Next

        strStreamWriter.Close()



    End Sub

    Public Function zeros(ByVal valor As String, ByVal nlong As Integer) As String
        Dim tamano As Integer
        Dim lcvalor As String
        lcvalor = valor.Trim
        Dim i As Integer
        tamano = valor.Trim.Length
        If tamano >= nlong Then
            lcvalor = Left(valor.Trim, nlong)
        Else
            For i = 1 To nlong - tamano
                lcvalor = lcvalor & " "
            Next
        End If

        Return lcvalor
    End Function

    Public Function zeros_Derecha(ByVal valor As String, ByVal nlong As Integer) As String
        Dim tamano As Integer
        Dim lcvalor As String
        lcvalor = valor.Trim
        Dim i As Integer
        tamano = valor.Trim.Length
        If tamano >= nlong Then
            lcvalor = Left(valor.Trim, nlong)
        Else
            For i = 1 To nlong - tamano
                lcvalor = lcvalor & "0"
            Next
        End If

        Return lcvalor
    End Function


    'Plan de pagos Reestructurado
    Public Function CreaEstructuraPlan() As DataSet
        Try
            Dim lCampos1 As String
            Dim lTipos1 As String
            Dim DSFS As New DataSet
            Dim DR As DataRow
            Dim DC As DataColumn
            Dim DT As DataTable
            DSFS.Clear()
            lCampos1 = "dFecPro, dFecDes, nTasaIn, nMCuota, cTipOpe, nSalCap, nTipOpe,nDifDia,nTasaEf,nCapita,nIntere,cNroCuo,ngastos,nSegDeu,nsegdan, nresinc, ntalona, notrpag, nflag,"
            lTipos1 = "F,F,D,D,S,D,I,I,D,D,D,S,D,D,D,D,D,D,I,"
            DT = creadatasetdesconec(lCampos1, lTipos1, "Plan")
            'DR = DT.NewRow
            'DR("dFecPro") = p_dFecDes
            'DR("dFecDes") = p_dFecDes
            'DR("nTasaIn") = p_nTasInt
            'DR("nMCuota") = p_nMonDes
            'DR("cTipOpe") = "D"
            'DR("nSalCap") = p_nMonDes
            'DR("nTipOpe") = Asc("D")
            'DR("nCapita") = p_nMonDes
            'DR("nIntere") = 0
            'DR("cNroCuo") = "001"
            'DR("nGastos") = 0
            'DR("nSegDeu") = 0
            'DR("nflag") = 1
            'DT.Rows.Add(DR)

            DSFS.Tables.Add(DT)

            Return DSFS
        Catch SqlException As Exception

        End Try
    End Function

    Public Function ValidaCaracter(ByVal caracter As String) As Boolean
        Dim lccaracter As String
        Dim lvalida As Boolean = True
        lccaracter = caracter.ToUpper
        If lccaracter.Trim = "0" Then
            lvalida = False
        ElseIf lccaracter.Trim = "1" Then
            lvalida = False
        ElseIf lccaracter.Trim = "2" Then
            lvalida = False
        ElseIf lccaracter.Trim = "3" Then
            lvalida = False
        ElseIf lccaracter.Trim = "4" Then
            lvalida = False
        ElseIf lccaracter.Trim = "5" Then
            lvalida = False
        ElseIf lccaracter.Trim = "6" Then
            lvalida = False
        ElseIf lccaracter.Trim = "7" Then
            lvalida = False
        ElseIf lccaracter.Trim = "8" Then
            lvalida = False
        ElseIf lccaracter.Trim = "9" Then
            lvalida = False
        Else
            lvalida = True
        End If
        Return lvalida
    End Function
    Public Function LecturaDPI(ByVal documento As String) As String
        Dim lcdocumento As String
        lcdocumento = documento.Replace("-", "").Replace(",", "").Replace(" ", "").Trim
        Dim lonli As Integer
        lonli = lcdocumento.Trim.Length

        Dim lcbloque1 As String
        Dim lcbloque2 As String
        Dim lcbloque3 As String

        If lonli < 13 Then 'DPI incompleto
            Return ""
        Else
            lcbloque1 = Left(lcdocumento, 4)
            lcbloque2 = lcdocumento.Substring(4, 5)
            lcbloque3 = Right(lcdocumento, 4)
        End If

        Dim lcbloque1a As String
        Dim lcbloque2a As String
        Dim lcbloque3a As String

        'Verifica ceros inciales
        Dim i As Integer = 0
        Dim lccaracter As String = ""
        Dim lnconta As Integer = 0
        Dim lcini As String = ""
        For i = 0 To lcbloque1.Length - 1
            lccaracter = lcbloque1.Substring(i, 1)
            If lccaracter = "0" Then
                lnconta += 1
                lcini = lcini & "CERO "
            Else
                Exit For
            End If
        Next

        lcbloque1a = lcini & Num2Text(Integer.Parse(lcbloque1))
        '-----------------------------------------------------

        lnconta = 0
        lcini = ""

        For i = 0 To lcbloque2.Length - 1
            lccaracter = lcbloque2.Substring(i, 1)
            If lccaracter = "0" Then
                lnconta += 1
                lcini = lcini & "CERO "
            Else
                Exit For
            End If
        Next
        lcbloque2a = lcini & Num2Text(Integer.Parse(lcbloque2))
        '------------------------------------------------------

        lnconta = 0
        lcini = ""

        For i = 0 To lcbloque3.Length - 1
            lccaracter = lcbloque3.Substring(i, 1)
            If lccaracter = "0" Then
                lnconta += 1
                lcini = lcini & "CERO "
            Else
                Exit For
            End If
        Next
        lcbloque3a = lcini & Num2Text(Integer.Parse(lcbloque3))

        Dim lcdpi As String = ""
        lcdpi = "con Documento Personal de Identificación número " & lcbloque1a.ToLower & " , " & lcbloque2a.ToLower & " , " & lcbloque3a.ToLower
        Return lcdpi
    End Function

    Public Function LecturaCedula(ByVal documento As String) As String
        Dim lcdocumento As String
        lcdocumento = documento.Replace("-", "").Replace(",", "").Trim
        Dim lccedula As String
        Dim lcorden1 As String
        Dim lcorden As String
        Dim lonli As Integer
        Dim lcregistro As String
        lonli = lcdocumento.Trim.Length
        Dim i As Integer = 0
        Dim lccaracter As String = ""
        Dim lcregis As String

        'Extrae registro
        For i = lonli To 1 Step -1
            lccaracter = lcdocumento.Substring(i - 1, 1)
            If lccaracter = " " Then
                Exit For
            Else
                lcregistro = lccaracter + lcregistro
            End If
        Next

        If lcregistro.Trim = "" Then
            lcregis = ""
        Else
            lcregis = Num2Text(Integer.Parse(lcregistro)).ToLower
        End If

        lcorden1 = lcdocumento.Substring(1, 2)

        lcorden = Num2Text(Integer.Parse(lcorden1)).ToLower
        lccedula = "con cedula de vecindad con número de orden " & Left(lcdocumento.Trim, 1) & " guión " & lcorden.ToLower & " y registro " & lcregis

        Return lccedula
    End Function
    'Public Function EdadLetras(ByVal dfecha As Date) As String
    '    'Separamos el dia , mes y año
    '    Dim lcfecha As String
    '    Dim lndia As Integer
    '    Dim lnmes As Integer
    '    Dim lnano As Integer
    '    lndia = dfecha.Day
    '    lnmes = dfecha.Month
    '    lnano = dfecha.Year

    '    Dim lndia1 As Integer
    '    Dim lnmes1 As Integer
    '    Dim lnano1 As Integer

    '    lndia1 = Today.Day
    '    lnmes1 = Today.Month
    '    lnano1 = Today.Year

    '    Dim lnedad As Integer = 0

    '    If lnmes > lnmes1 Then 'ya cumplio años
    '        lnedad = lnano1 - lnano
    '    Else
    '        If lnmes = lnmes1 Then 'Esta en el mes del cumpleaños
    '            If lndia >= lndia1 Then 'ya cumplio años
    '                lnedad = lnano1 - lnano
    '            Else
    '                lnedad = lnano1 - lnano - 1
    '            End If
    '        Else
    '            lnedad = lnano1 - lnano - 1
    '        End If
    '    End If

    '    Dim lcedad As String
    '    lcedad = "de " & Num2Text(lnedad).ToLower & " años de Edad "
    '    Return lcedad
    'End Function
    Public Function Num2Text(ByVal value As Double) As String
        If value < 0 Then
            Num2Text = ""
        Else


            Try


                Select Case value
                    Case 0 : Num2Text = "CERO"
                    Case 1 : Num2Text = "UNO"
                    Case 2 : Num2Text = "DOS"
                    Case 3 : Num2Text = "TRES"
                    Case 4 : Num2Text = "CUATRO"
                    Case 5 : Num2Text = "CINCO"
                    Case 6 : Num2Text = "SEIS"
                    Case 7 : Num2Text = "SIETE"
                    Case 8 : Num2Text = "OCHO"
                    Case 9 : Num2Text = "NUEVE"
                    Case 10 : Num2Text = "DIEZ"
                    Case 11 : Num2Text = "ONCE"
                    Case 12 : Num2Text = "DOCE"
                    Case 13 : Num2Text = "TRECE"
                    Case 14 : Num2Text = "CATORCE"
                    Case 15 : Num2Text = "QUINCE"
                    Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
                    Case 20 : Num2Text = "VEINTE"
                    Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
                    Case 30 : Num2Text = "TREINTA"
                    Case 40 : Num2Text = "CUARENTA"
                    Case 50 : Num2Text = "CINCUENTA"
                    Case 60 : Num2Text = "SESENTA"
                    Case 70 : Num2Text = "SETENTA"
                    Case 80 : Num2Text = "OCHENTA"
                    Case 90 : Num2Text = "NOVENTA"
                    Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
                    Case 100 : Num2Text = "CIEN"
                    Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
                    Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
                    Case 500 : Num2Text = "QUINIENTOS"
                    Case 700 : Num2Text = "SETECIENTOS"
                    Case 900 : Num2Text = "NOVECIENTOS"
                    Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
                    Case 1000 : Num2Text = "MIL"
                    Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
                    Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                        If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
                    Case 1000000 : Num2Text = "UN MILLON"
                    Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
                    Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                        If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
                    Case 1000000000000.0# : Num2Text = "UN BILLON"
                    Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
                    Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                        If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
                End Select
                If Num2Text = "UNO MIL" Then
                    Num2Text = "UN MIL"
                End If

            Catch ex As Exception
                Num2Text = ""
            End Try
        End If

    End Function

    Public Function CreateDataConciliar() As DataTable
        Dim dt As New DataTable

        Try
            Dim pCampos_f As String
            Dim pTipos_f As String
            pCampos_f = "dFeccnt,cnumdoc,nvalor,cnomcli,cconcepto,cflag,cmes,nvalortot,"
            pTipos_f = "F,S,D,S,S,S,S,D,"

            dt = creadatasetdesconec(pCampos_f, pTipos_f, "BANCOS")

            'ds.Tables.Add(dt)
            Return dt
        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
    End Function

    '------ESTIMACION------
    Public Function RotorActualizador(ByVal dfecha1 As Date, ByVal dfecha2 As Date) As Integer
        'Obtiene dataset de fondos
        Dim dsfondos As New DataSet
        Dim dsoficina As New DataSet
        Dim etabttab As New cTabttab
        Dim etabtofi As New cTabtofi
        Dim ds As New DataSet
        Dim ecreditos As New ccreditos
        Dim dsdata As New DataSet
        Dim dsstatus As New DataSet

        dsstatus = etabttab.ObtenerDataSetPorID("046", "1")
        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        dsoficina = etabtofi.ObtenerDataSetPorID()

        Dim filafondo As DataRow
        Dim filaoficina As DataRow
        Dim filastatus As DataRow

        Dim i As Integer = 0
        Dim y As Integer = 0
        Dim w As Integer = 0

        Dim lccodfue As String
        Dim lccodofi As String
        Dim lcstatus As String

        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable

        Dim fila As DataRow



        For Each filafondo In dsfondos.Tables(0).Rows
            lccodfue = filafondo("ccodigo")
            y = 0
            For Each filaoficina In dsoficina.Tables(0).Rows
                lccodofi = filaoficina("ccodofi")

                w = 0
                For Each filastatus In dsstatus.Tables(0).Rows
                    lcstatus = Trim(filastatus("ccodigo"))



                    DT = CreateDataEstimacion()
                    'Obtiene dataset con datos
                    ecreditos.tipo = "A"
                    ds = ecreditos.DatosparaEstimacion(dfecha1, dfecha2, lccodofi.Trim, "*", "*", lccodfue.Trim, False, "*", lcstatus, lccodofi)


                    Dim z As Integer = 0
                    Dim lndias As Integer = 0
                    Dim lnreserva As Double = 0
                    Dim lncapdes As Double = 0
                    Dim lncappag As Double = 0
                    Dim lnsaldo As Double = 0

                    '--------------------------
                    Dim lnrango0a As Double = 0
                    Dim lnrango1a As Double = 0
                    Dim lnrango2a As Double = 0
                    Dim lnrango3a As Double = 0
                    Dim lnrango4a As Double = 0
                    Dim lnrango5a As Double = 0
                    Dim lnrango6a As Double = 0
                    Dim lnrango7a As Double = 0
                    Dim lnrango8a As Double = 0
                    '--------------------------
                    Dim lnrango0b As Double = 0
                    Dim lnrango1b As Double = 0
                    Dim lnrango2b As Double = 0
                    Dim lnrango3b As Double = 0
                    Dim lnrango4b As Double = 0
                    Dim lnrango5b As Double = 0
                    Dim lnrango6b As Double = 0
                    Dim lnrango7b As Double = 0
                    Dim lnrango8b As Double = 0
                    '--------------------------
                    Dim lnsalcar As Double = 0

                    Dim lccalifica As String = ""
                    Dim lnpor As Double = 0

                    For Each fila In ds.Tables(0).Rows
                        lndias = fila("ndias")
                        lncapdes = fila("ncapdes")
                        lncappag = fila("ncappag")

                        lnsaldo = IIf((lncapdes - lncappag) < 0, 0, (lncapdes - lncappag))
                        If lndias <= 0 Then
                            lnrango0b = lnrango0b + lnsaldo
                        ElseIf lndias >= 1 And lndias <= 31 Then
                            'lnreserva = Math.Round(lnsaldo * 0.01, 2)
                            lnrango1b = lnrango1b + lnsaldo
                        ElseIf lndias >= 32 And lndias <= 61 Then
                            'lnreserva = Math.Round(lnsaldo * 0.1, 2)
                            lnrango2b = lnrango2b + lnsaldo
                        ElseIf lndias >= 62 And lndias <= 91 Then
                            'lnreserva = Math.Round(lnsaldo * 0.25, 2)
                            lnrango3b = lnrango3b + lnsaldo
                        ElseIf lndias >= 92 And lndias <= 181 Then
                            'lnreserva = Math.Round(lnsaldo * 0.5, 2)
                            lnrango4b = lnrango4b + lnsaldo
                        ElseIf lndias > 181 Then
                            'lnreserva = Math.Round(lnsaldo * 0.75, 2)
                            lnrango5b = lnrango5b + lnsaldo
                        End If
                        z += 1
                    Next

                    'Aplica Porcentajes
                    Dim cont As Integer = 0
                    For cont = 1 To 6
                        DR = DT.NewRow
                        DR("ccodofi") = lccodofi
                        DR("ffondos") = lccodfue
                        DR("dfecha") = dfecha2
                        DR("cmes") = (dfecha2.ToString).Substring(3, 2)
                        DR("cyear") = (dfecha2.ToString).Substring(6, 4)
                        DR("ccodusu") = Me.pcCodUsu
                        DR("status") = lcstatus.Trim

                        If cont = 1 Then
                            DR("nsaldo") = lnrango0b
                            DR("ccalifica") = "A"
                        ElseIf cont = 2 Then
                            DR("nsaldo") = lnrango1b
                            DR("ccalifica") = "B"
                        ElseIf cont = 3 Then
                            DR("nsaldo") = lnrango2b
                            DR("ccalifica") = "C"
                        ElseIf cont = 4 Then
                            DR("nsaldo") = lnrango3b
                            DR("ccalifica") = "D"
                        ElseIf cont = 5 Then
                            DR("nsaldo") = lnrango4b
                            DR("ccalifica") = "E"
                        ElseIf cont = 6 Then
                            DR("nsaldo") = lnrango5b
                            DR("ccalifica") = "F"
                        End If
                        lnpor = ecreditos.ObtienePorcentajeEstimacion(DR("ccalifica"), lccodfue)
                        lnreserva = Math.Round(lnpor / 100 * DR("nsaldo"), 2)
                        DR("nestimacion") = lnreserva

                        DT.Rows.Add(DR)

                    Next


                    dsdata.Tables.Add(DT)
                    'Agregar Bomba de datos
                    Dim k As Integer = 0
                    Dim filadata As DataRow

                    For Each filadata In dsdata.Tables(0).Rows
                        If lccodofi = "001" Then
                        Else
                            ecreditos.InsertarEstimacion(lccodofi, lccodfue, filadata("nsaldo"), dfecha2, filadata("cmes"), filadata("cyear"), Me.pcCodUsu, filadata("ccalifica"), filadata("nestimacion"), lcstatus)
                        End If

                        k += 1
                    Next

                    dsdata.Clear()
                    dsdata.Tables.Clear()

                    w += 1
                Next


                y += 1
            Next

            i += 1
        Next

    End Function
    Public Function CreateDataEstimacion() As DataTable
        Dim dt As New DataTable

        Try
            Dim pCampos_f As String
            Dim pTipos_f As String
            pCampos_f = "ccodofi,ffondos,nsaldo,dfecha,cmes,cyear,ccodusu,ccalifica,cflag,nestimacion,status,"
            pTipos_f = "S,S,D,F,S,S,S,S,S,D,S,"

            dt = creadatasetdesconec(pCampos_f, pTipos_f, "ESTIMACION")

            'ds.Tables.Add(dt)
            Return dt
        Catch SqlException As Exception
            Debug.WriteLine("Exception: " + SqlException.ToString())
            '  MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try
    End Function

    Public Function GeneraEstimacionContable(ByVal dfecant As Date)
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak

        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim lcctactb1 As String = ""
        Dim cplanti As String = ""

        Dim cClsAdP As New SIM.BL.ClsAdPart
        Dim clsdes As New clsDesembolsa

        Dim lcfecant As String
        lcfecant = dfecant.ToString

        Dim lcmes As String = lcfecant.Substring(3, 2)
        Dim lcyear As String = lcfecant.Substring(6, 4)

        Dim lcmesant As String = ""
        Dim lcyearant As String = ""

        If lcmes = "01" Then
            lcmesant = "12"
            lcyearant = (Integer.Parse(lcyear) - 1).ToString
        Else
            Dim lnmes As Integer = 0
            lnmes = Integer.Parse(lcmes) - 1
            If lnmes < 10 Then
                lcmesant = "0" + lnmes.ToString
            Else
                lcmesant = lnmes.ToString
            End If

            lcyearant = lcyear
        End If

        Dim dsfondos As New DataSet
        Dim dsoficina As New DataSet
        Dim etabttab As New cTabttab
        Dim etabtofi As New cTabtofi

        Dim dsstatus As New DataSet
        Dim filasatatus As DataRow

        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        dsoficina = etabtofi.ObtenerDataSetPorID()
        dsstatus = etabttab.ObtenerDataSetPorID("046", "1")

        Dim filafondo As DataRow
        Dim filaoficina As DataRow

        Dim i As Integer = 0
        Dim y As Integer = 0
        Dim w As Integer = 0

        Dim lccodfue As String
        Dim lccodofi As String
        Dim lcstatus As String

        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable

        Dim fila As DataRow

        Dim lnestimacion As Decimal = 0
        Dim lnestiantes As Decimal = 0

        Dim ecreditos As New ccreditos
        Dim lndifer As Decimal = 0

        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0

        Dim clase As New crefunc

        Dim lcmascara As String = "CECI1"
        If lcmascara <> Nothing Then
            entidadtabtmak.ccodigo = lcmascara
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lcctactb = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lcctactb = cplanti.Trim
            End If
        End If
        lcmascara = "CEECI"
        If lcmascara <> Nothing Then
            entidadtabtmak.ccodigo = lcmascara
            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
            If busquedaplantilla = 0 Then
                lcctactb1 = "*"
            Else
                cplanti = entidadtabtmak.cplanti.Trim
                lcctactb1 = cplanti.Trim
            End If
        End If

        Dim lcnombremes As String = ""
        lcnombremes = Me.MES(dfecant.Month)

        Dim oki As Integer = 0
        For Each filaoficina In dsoficina.Tables(0).Rows
            lccodofi = filaoficina("ccodofi")
            y = 0
            'Graba Partida contable
            cClsAdP._dfecmod = Now
            cClsAdP._ccodusu = pcCodUsu
            cClsAdP._ccodofi = lccodofi 'Session("gcCodofi")
            cClsAdP._cconcepto = ("ESTIMACION MENSUAL CUENTA INCOBRABLES " + lcnombremes + " " + lcyear)
            cClsAdP._dfeccnt = dfecant
            cClsAdP._cpoliza = " "
            cClsAdP._nCuenta = 1
            cClsAdP._cnumdoc = "R"
            cClsAdP._llbandera = True
            cClsAdP._ccodpres = ""


            For Each filafondo In dsfondos.Tables(0).Rows
                lccodfue = filafondo("ccodigo")
                cClsAdP._ffondos = clsdes.ConvertidorFondos(lccodfue.Trim)

                w = 0
                For Each filasatatus In dsstatus.Tables(0).Rows
                    lcstatus = filasatatus("ccodigo")

                    lcctactb1 = lcctactb1.Replace("CC", clase.CodigoCondicion(lcstatus))

                    'Obtiene Estimacion Actual
                    lnestimacion = ecreditos.ObtieneEstimacion(lccodfue, lccodofi, lcmes, lcyear, lcstatus)
                    'Obtiene Estimacion Anterior
                    lnestiantes = ecreditos.ObtieneEstimacion(lccodfue, lccodofi, lcmesant, lcyearant, lcstatus)

                    lndifer = Math.Round(lnestimacion - lnestiantes, 2)

                    If lndifer <> 0 Then


                        If lndifer > 0 Then
                            lndebe = lndifer
                            lnhaber = 0
                        Else
                            lndebe = 0
                            lnhaber = Math.Abs(lndifer)
                        End If


                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = lndebe
                        cClsAdP._nhaber = lnhaber
                        cClsAdP._cclase = Left(lcctactb, 1)
                        cClsAdP._cpoliza = "AR"
                        oki = cClsAdP.AdPartida()

                        cClsAdP._nCuenta += 1


                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1
                        cClsAdP._ndebe = lnhaber
                        cClsAdP._nhaber = lndebe
                        cClsAdP._cclase = Left(lcctactb1, 1)
                        cClsAdP._cpoliza = "AR"

                        oki = cClsAdP.AdPartida()

                        cClsAdP._nCuenta += 1
                    End If

                    w += 1
                Next


                y += 1
            Next

            i += 1
        Next
    End Function
    Public Function CalcularSeguroDeuda(ByVal cCodcta As String, ByVal dfecval As Date, ByVal nsaldo As Double, ByVal dfecvig As Date) As Decimal 'se cobrara una vez al mes
        'Dim ldfecha As Date
        'Dim ecredkar As New cCredkar


        'Dim lnmeses As Integer = 0

        'ldfecha = ecredkar.UltimafechaCobro(cCodcta, dfecval, "03", dfecvig)

        'lnmeses = DateDiff(DateInterval.Month, ldfecha, dfecval)





        'Dim llpago As Boolean
        'If lnmeses = 0 Then
        '    llpago = ecredkar.Pagoenelmes(cCodcta, dfecval, "03", dfecvig)
        '    If llpago = False Then
        '        lnmeses = 1
        '    End If

        'End If


        'If lnmeses < 0 Then
        '    lnmeses = 0

        'End If



        'Dim ecremcre As New cCremcre
        'Dim entidadcremcre As New cremcre
        'Dim lcnrolin As String
        Dim lnsegdeu As Decimal = 0

        'entidadcremcre.ccodcta = cCodcta
        'ecremcre.ObtenerCremcre(entidadcremcre)

        'lcnrolin = entidadcremcre.cnrolin


        ''Obtiene porcentaje de seguro de deuda
        'Dim ecretgas As New cCretgas
        'Dim lnmonpor As Decimal = 0

        'lnmonpor = ecretgas.ObtienevalordeGasto(lcnrolin, "03", "125")

        'lnsegdeu = Math.Round((nsaldo * lnmonpor / 100) * lnmeses, 2)

        Return lnsegdeu
    End Function
    Public Function CalcularManejo(ByVal cCodcta As String, ByVal dfecval As Date, ByVal nmonto As Double, ByVal lcancela As Boolean) As Decimal 'se cobrara una vez al mes
        'Obtener el interes pendiente al dia
        Dim ecredppg As New cCredppg
        Dim lninterepen As Double = 0
        Dim ecredkar As New cCredkar
        Dim lninterepag As Double = 0

        If lcancela = True Then
            lninterepen = ecredppg.InteresPendienteTotal(cCodcta, dfecval)
        Else
            lninterepen = ecredppg.InteresPendiente(cCodcta, dfecval)
        End If

        If lninterepen = 0 Then
            Return 0
        End If

        'Obtener Interes Pendiente Pagado
        lninterepag = ecredkar.InteresPendientePagado(cCodcta, dfecval)

        Dim lnmanejo As Double = 0
        lnmanejo = Math.Round(lninterepen - lninterepag, 2)
        If lnmanejo < 0 Then
            lnmanejo = 0
        End If

        'lnmanejo = 0

        Return lnmanejo


    End Function

    Public Function CalcularIVAManejo(ByVal ntasaiva As String, ByVal nvalor As Double) As Decimal 'se cobrara una vez al mes
        Dim lniva As Decimal = 0
        'lniva = Math.Round(ntasaiva * nvalor / 100, 2)

        Return lniva
    End Function
    Public Function Cominola(ByVal lcmonto As String) As String
        Dim lnentero As Double
        Dim lndeci As Double
        Dim lnmonsug As Double
        Dim lcentero As String = ""
        Dim lcdeci As String
        lnmonsug = Double.Parse(lcmonto)

        lnentero = Decimal.Floor(lnmonsug)
        lndeci = Math.Round((lnmonsug - lnentero) * 100)

        lcdeci = "." & lndeci.ToString
        If lcdeci.Trim = ".0" Then
            lcdeci = ".00"
        End If

        Dim longitud As Integer = 0
        lcmonto = lnentero.ToString
        longitud = lcmonto.Trim.Length
        Dim lcvalor As String = ""
        Dim y As Integer
        Dim lnconta As Integer = 0
        y = Math.Round(longitud / 3, 0)


        Dim c As Integer = 0


        If y < 1 Then
            lcvalor = lcmonto
        Else
            Dim i As Integer
            Dim lcflag As String = ""
            Dim k As Integer = 0
            For i = 1 To longitud
                lcflag = lcmonto.Trim.Substring(longitud - i, 1)
                k += 1
                If k > 3 And y > lnconta Then

                    lcvalor = "," & lcvalor
                    lcvalor = lcflag & lcvalor

                    lnconta += 1
                    k = 0
                Else
                    lcvalor = lcflag & lcvalor
                End If



            Next

        End If

        Return (lcvalor & lcdeci)
    End Function
    Public Function TablaBalance() As DataSet
        Dim lCampos1 As String
        Dim lTipos1 As String
        Dim DSFS As New DataSet
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable
        DSFS.Clear()
        lCampos1 = "cNombre, cfecha1, cfecha2, cfecha3, cfecha4, cfecha5, cflag,"
        lTipos1 = "S,S,S,S,S,S,S,"
        DT = creadatasetdesconec(lCampos1, lTipos1, "Balance")
        Dim i As Integer
        For i = 0 To 44
            DR = DT.NewRow
            If i = 0 Then
                DR("cNombre") = ""
                DR("cflag") = ""
            ElseIf i = 1 Then
                DR("cNombre") = "ACTIVO"
                DR("cflag") = "*"
            ElseIf i = 2 Then
                DR("cNombre") = "Activo Circulante"
                DR("cflag") = ""
            ElseIf i = 3 Then
                DR("cNombre") = "Disponible"
                DR("cflag") = ""
            ElseIf i = 4 Then
                DR("cNombre") = "cuentas x Cobrar"
                DR("cflag") = ""
            ElseIf i = 5 Then
                DR("cNombre") = "Inventario"
                DR("cflag") = ""
            ElseIf i = 6 Then
                DR("cNombre") = "Activo Fijo"
                DR("cflag") = ""
            ElseIf i = 7 Then
                DR("cNombre") = "Otros Activos"
                DR("cflag") = ""
            ElseIf i = 8 Then
                DR("cNombre") = "PASIVO"
                DR("cflag") = "*"
                '-----------------------------------------------
            ElseIf i = 9 Then
                DR("cNombre") = "Pasivo Circulante"
                DR("cflag") = ""

            ElseIf i = 10 Then
                DR("cNombre") = "Proveedores"
                DR("cflag") = ""
            ElseIf i = 11 Then
                DR("cNombre") = "Otras Cuentas por Pagar"
                DR("cflag") = ""

            ElseIf i = 12 Then
                DR("cNombre") = "Pasivo Fijo"
                DR("cflag") = ""

            ElseIf i = 13 Then
                DR("cNombre") = "Otros Ptmos. a Largo P."
                DR("cflag") = ""
                '-----------------------------------------------
            ElseIf i = 14 Then
                DR("cNombre") = "PATRIMONIO"
                DR("cflag") = "*"
            ElseIf i = 15 Then
                DR("cNombre") = "_______________________________________________"
                DR("cflag") = ""
            ElseIf i = 16 Then
                DR("cNombre") = "ESTADO DE RESULTADOS"
                DR("cflag") = "*"
            ElseIf i = 17 Then
                DR("cNombre") = "INGRESOS"
                DR("cflag") = "*"
            ElseIf i = 18 Then
                DR("cNombre") = "Ingresos Familiares"
                DR("cflag") = ""
            ElseIf i = 19 Then
                DR("cNombre") = "VENTAS"
                DR("cflag") = "*"
            ElseIf i = 20 Then
                DR("cNombre") = "Rec.Ctas x Cobrar"
                DR("cflag") = ""
            ElseIf i = 21 Then
                DR("cNombre") = "Otros Ingresos"
                DR("cflag") = ""
            ElseIf i = 22 Then
                DR("cNombre") = "EGRESOS"
                DR("cflag") = "*"
            ElseIf i = 23 Then
                DR("cNombre") = "Gastos Familiares"
                DR("cflag") = ""
            ElseIf i = 24 Then
                DR("cNombre") = "Costo de Ventas"
                DR("cflag") = ""
            ElseIf i = 25 Then
                DR("cNombre") = "Otros Egresos"
                DR("cflag") = ""
            ElseIf i = 26 Then
                DR("cNombre") = "Pago de Ptmos."
                DR("cflag") = ""
            ElseIf i = 27 Then
                DR("cNombre") = "Impuestos"
                DR("cflag") = ""
            ElseIf i = 28 Then
                DR("cNombre") = "_______________________________________________"
                DR("cflag") = ""
            ElseIf i = 29 Then
                DR("cNombre") = "DISPONIBILIDAD FAMILIAR"
                DR("cflag") = "*"
            ElseIf i = 30 Then
                DR("cNombre") = "_______________________________________________"
                DR("cflag") = ""
            ElseIf i = 31 Then
                DR("cNombre") = "INDICES FINANCIEROS"
                DR("cflag") = "*"
            ElseIf i = 32 Then
                DR("cNombre") = "Rotacion de Inventario"
                DR("cflag") = ""
            ElseIf i = 33 Then
                DR("cNombre") = "Indice de Endeudamiento"
                DR("cflag") = ""
            ElseIf i = 34 Then
                DR("cNombre") = "Margen Bruto/ventas"
                DR("cflag") = ""
            ElseIf i = 35 Then
                DR("cNombre") = "Capital de Trabajo"
                DR("cflag") = ""
            ElseIf i = 36 Then
                DR("cNombre") = "Liquidez"
                DR("cflag") = ""
            ElseIf i = 37 Then
                DR("cNombre") = "Rentabilidad del Negocio"
                DR("cflag") = ""
            ElseIf i = 38 Then
                DR("cNombre") = "Rotacion de CxC"
                DR("cflag") = ""
            ElseIf i = 39 Then
                DR("cNombre") = "Ciclo Operacional"
                DR("cflag") = ""
            ElseIf i = 40 Then
                DR("cNombre") = "Punto de Equilibrio"
                DR("cflag") = ""
            ElseIf i = 41 Then
                DR("cNombre") = "Margen de Seguridad"
                DR("cflag") = ""
            ElseIf i = 42 Then
                DR("cNombre") = "Margen Bruto Promedio"
                DR("cflag") = "*"
            ElseIf i = 43 Then
                DR("cNombre") = "Margen(Q)"
                DR("cflag") = ""
            ElseIf i = 44 Then
                DR("cNombre") = "Margen(%)"
                DR("cflag") = ""
            End If
            DR("cfecha1") = ""
            DR("cfecha2") = ""
            DR("cfecha3") = ""
            DR("cfecha4") = ""
            DR("cfecha5") = ""
            DT.Rows.Add(DR)
        Next
        DSFS.Tables.Add(DT)
        Return DSFS
    End Function
    Public Function CalculaEdad(ByVal dfecha As Date) As Integer
        'Separamos el dia , mes y año
        Dim lcfecha As String
        Dim lndia As Integer
        Dim lnmes As Integer
        Dim lnano As Integer
        lndia = dfecha.Day
        lnmes = dfecha.Month
        lnano = dfecha.Year

        Dim lndia1 As Integer
        Dim lnmes1 As Integer
        Dim lnano1 As Integer

        lndia1 = Today.Day
        lnmes1 = Today.Month
        lnano1 = Today.Year

        Dim lnedad As Integer = 0

        If lnmes < lnmes1 Then 'ya cumplio años
            lnedad = lnano1 - lnano
        Else
            If lnmes = lnmes1 Then 'Esta en el mes del cumpleaños
                If lndia >= lndia1 Then 'ya cumplio años
                    lnedad = lnano1 - lnano
                Else
                    lnedad = lnano1 - lnano - 1
                End If
            Else
                lnedad = lnano1 - lnano - 1
            End If
        End If
        If lnedad < 0 Then
            lnedad = 0
        End If
        Return lnedad
    End Function

    Public Function EdadLetras(ByVal dfecha As Date) As String
        ''Separamos el dia , mes y año
        'Dim lcfecha As String
        'Dim lndia As Integer
        'Dim lnmes As Integer
        'Dim lnano As Integer
        'lndia = dfecha.Day
        'lnmes = dfecha.Month
        'lnano = dfecha.Year

        'Dim lndia1 As Integer
        'Dim lnmes1 As Integer
        'Dim lnano1 As Integer

        'lndia1 = Today.Day
        'lnmes1 = Today.Month
        'lnano1 = Today.Year

        Dim lnedad As Integer = 0
        lnedad = CalculaEdad(dfecha)
        'If lnmes > lnmes1 Then 'ya cumplio años
        '    lnedad = lnano1 - lnano
        'Else
        '    If lnmes = lnmes1 Then 'Esta en el mes del cumpleaños
        '        If lndia >= lndia1 Then 'ya cumplio años
        '            lnedad = lnano1 - lnano
        '        Else
        '            lnedad = lnano1 - lnano - 1
        '        End If
        '    Else
        '        lnedad = lnano1 - lnano - 1
        '    End If
        'End If

        Dim lcedad As String
        lcedad = "de " & Num2Text(lnedad).ToLower & " años de Edad "
        Return lcedad
    End Function
    Public Function CreaEstructuraTabular() As DataSet
        Try
            Dim lCampos1 As String
            Dim lTipos1 As String
            Dim DSFS As New DataSet
            Dim DR As DataRow
            Dim DC As DataColumn
            Dim DT As DataTable
            DSFS.Clear()
            lCampos1 = "numero,nombre,depto,muni,comuni,clasif,edad,sexo,actividad,tipo,paredes,pisos,techos,haci,agua,desague,asistencia,nivele,dependencia,cbai,cbvi,linea1,linea2,mintegrado,mmonetario,minter,mppidebajo,mppiarriba,"
            lTipos1 = "I,S,S,S,S,S,I,S,S,I,I,I,I,I,I,I,I,I,I,I,I,I,I,S,S,S,D,D,"
            DT = creadatasetdesconec(lCampos1, lTipos1, "Tabular")

            DSFS.Tables.Add(DT)

            Return DSFS
        Catch SqlException As Exception

        End Try
    End Function
    Public Function TabularDatos() As DataSet
        Dim etabtular As New cTABULAR
        Dim ds As New DataSet
        Dim dsdatos As New DataSet
        dsdatos = etabtular.ObtenerDatosTabular()
        ds = CreaEstructuraTabular()
        Dim dt As DataTable
        Dim dr As DataRow
        dt = ds.Tables(0)

        Dim fila As DataRow
        Dim i As Integer = 1
        Dim lnratio As Double = 0
        Dim lnasistencia As Integer = 0
        Dim lnfactor As Double = 0
        Dim lcresul As String = ""
        Dim B29 As Integer = 0
        Dim B33 As Integer = 0
        Dim B32 As Integer = 0
        Dim B35 As Integer = 0
        Dim B36 As Integer = 0
        For Each fila In dsdatos.Tables(0).Rows
            dr = dt.NewRow
            dr("numero") = i
            dr("nombre") = fila("cnomcli")
            dr("depto") = fila("cdepa")
            dr("muni") = fila("cmuni")
            dr("comuni") = fila("ccomu")
            dr("clasif") = fila("cnivreg")
            dr("edad") = CalculaEdad(fila("dnacimi"))
            dr("sexo") = fila("csexo")
            dr("actividad") = ""
            dr("tipo") = fila("tipo")
            dr("paredes") = fila("paredes")
            dr("pisos") = fila("pisos")
            dr("techos") = fila("techos")
            If fila("Hacden") = 0 Then
                lnratio = 0
            Else
                lnratio = fila("Hacnum") / fila("Hacden")
            End If
            If lnratio >= 3 Then
                dr("haci") = 0
            Else
                dr("haci") = 1
            End If
            dr("agua") = fila("agua")
            dr("desague") = fila("desague")
            If fila("escolar31") = 0 Then
                dr("asistencia") = 1
            Else
                dr("asistencia") = fila("escolar32")
            End If

            dr("nivele") = fila("nivelducativo")
            If fila("depe39") = 0 Then
                lnratio = 0
            Else
                lnratio = fila("depe37") / fila("depe39")
            End If
            If lnratio >= 4 Then
                dr("dependencia") = 0
            Else
                dr("dependencia") = 1
            End If
            If fila("res031") = 0 Then
                dr("cbai") = 0
            Else
                If (fila("res002") + fila("res003") / fila("res031")) >= 390.21 Then
                    dr("cbai") = 1
                Else
                    dr("cbai") = 0
                End If
            End If
            If fila("res031") = 0 Then
                dr("cbvi") = 0
            Else
                lnfactor = ((fila("res021") + fila("res022") + fila("res023") + fila("res024") + fila("res025") + fila("res026") + fila("res027") _
                + fila("res028") + fila("res029") + fila("res030")) + ((fila("res005") + fila("res006") + fila("res007") + fila("res008") + fila("res009") + _
                  fila("res010") + fila("res011") + fila("res012") + fila("res013") + fila("res014") + fila("res015") + fila("res016") + fila("res017") + _
                  fila("res018")) * 12)) / 12 / fila("res031")
                If lnfactor >= 690.1 Then
                    dr("cbvi") = 1
                Else
                    dr("cbvi") = 0
                End If
            End If
            lnfactor = 0
            If fila("res031") = 0 Then
                dr("linea1") = 0
            Else
                lnfactor = ((((fila("res005") + fila("res006") + fila("res007") + fila("res008") + fila("res009") + _
                  fila("res010") + fila("res011") + fila("res012") + fila("res013") + fila("res014") + fila("res015") + _
                  fila("res016") + fila("res017") + fila("res018")) * 12) + _
                  (fila("res021") + fila("res022") + fila("res023") + fila("res024") + fila("res025") + fila("res026") + fila("res027") _
                + fila("res028") + fila("res029") + fila("res030"))) / fila("res031") / gnperbas) * 0.12482

            End If
            If lnfactor >= 1 Then
                dr("linea1") = 1
            Else
                dr("linea1") = 0
            End If
            If lnfactor >= 2 Then
                dr("linea2") = 1
            Else
                dr("linea2") = 0
            End If
            B29 = fila("tipo") + fila("paredes") + fila("pisos") + fila("techos") + dr("haci") + fila("agua") + fila("desague") + dr("asistencia") + fila("nivelducativo") + dr("dependencia")
            B33 = dr("cbvi")
            lcresul = IIf((B29 = 10 And B33 = 1), "integrado", IIf((B29 = 10 And B33 = 0), "reciente", IIf((B29 <= 9 And B33 = 1), "inercial", IIf((B29 <= 9 And B33 = 0), "cronico", ""))))
            dr("mintegrado") = lcresul

            B32 = dr("cbai")
            lcresul = IIf(((B32 = 0 And B33 = 0)), "pobre extremo", IIf(((B32 = 1 And B33 = 0)), "pobre", IIf(((B32 = 1 And B33 = 1)), "no pobre", IIf(((B32 = 0 And B33 = 1)), "alerta", ""))))
            dr("mmonetario") = lcresul

            B35 = dr("linea1")
            B36 = dr("linea2")
            lcresul = IIf(((B35 = 0 And B36 = 0)), "extremamente pobre", IIf(((B35 = 1 And B36 = 0)), "pobre", IIf(((B35 = 1 And B36 = 1)), "no pobre", "")))
            dr("minter") = lcresul

            'dr("mppidebajo")=
            'dr("mppiarriba")=

            dt.Rows.Add(dr)
            i += 1
        Next

        Return ds
    End Function

    Public Function MoraNogestionada(ByVal ccodana As String, ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Dim egestion As New cGestion
        Dim ds As New DataSet
        Dim dsgestion As New DataSet
        ds = egestion.Moranogestionada(ccodana, ndesde, nhasta)
        Dim fila As DataRow
        Dim lccodcta As String
        Dim lccodusu As String = ""
        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("cuenta")
            'verifica si ha sido gestionado
            dsgestion = egestion.VerificaGestion(lccodcta, dfec1, dfec2)
            If dsgestion.Tables(0).Rows.Count > 0 Then
                fila("gestionado") = "SI"
                fila("gestion") = dsgestion.Tables(0).Rows(0)("ccodusu")
                fila("cuantas") = dsgestion.Tables(0).Rows.Count.ToString
            End If
            dsgestion.Clear()
        Next

        Return ds
    End Function

    Public Function CreaEstructuraEstadoResultados() As DataSet
        Try
            Dim lCampos1 As String
            Dim lTipos1 As String
            Dim DSFS As New DataSet
            Dim DR As DataRow
            Dim DC As DataColumn
            Dim DT As DataTable
            DSFS.Clear()
            lCampos1 = "ccodcta,cdescrip,nsalini,nsaldo,nsalfin,cnivel,ccodofi,ffondos,cflag,ccampo,"
            lTipos1 = "S,S,D,D,D,S,S,S,S,S,"
            DT = creadatasetdesconec(lCampos1, lTipos1, "Estado")

            DSFS.Tables.Add(DT)

            Return DSFS
        Catch SqlException As Exception

        End Try
    End Function
    Public Function DatosEstado(ByVal dsdatos As DataSet) As DataSet

        Dim ds As New DataSet
        ds = CreaEstructuraEstadoResultados()
        Dim dt As DataTable
        Dim dr As DataRow
        dt = ds.Tables(0)

        Dim fila As DataRow
        Dim i As Integer = 1
        Dim lningresos As Double = 0
        Dim lnegresos As Double = 0

        Dim lningmes As Double = 0
        Dim lnegmes As Double = 0

        Dim lningini As Double = 0
        Dim lnegini As Double = 0

        dr = dt.NewRow
        dr("ccodcta") = ""
        dr("cdescrip") = "INGRESOS"
        dr("nsalini") = 0
        dr("nsaldo") = 0
        dr("nsalfin") = 0
        dr("cnivel") = "00"
        dr("ccodofi") = "000"
        dr("ffondos") = "00"
        dr("ccampo") = ""
        dt.Rows.Add(dr)

        For Each fila In dsdatos.Tables(0).Rows
            If Left(fila("ccodcta"), 1) = "6" Or Left(fila("ccodcta"), 1) = "7" Then
                If (Left(fila("ccodcta"), 1) = "6" Or Left(fila("ccodcta"), 1) = "7") And fila("cnivel") = "01" Then
                    If Left(fila("ccodcta"), 1) = "6" And fila("cnivel") = "01" Then
                        lningresos = fila("nsalfin")
                        lningmes = Math.Round(fila("nhaber") - fila("ndebe"), 2)
                        lningini = fila("nsalini")
                    End If
                    If Left(fila("ccodcta"), 1) = "7" And fila("cnivel") = "01" Then
                        lnegresos = fila("nsalfin")
                        lnegmes = Math.Round(fila("ndebe") - fila("nhaber"), 2)
                        lnegini = fila("nsalini")

                        dr = dt.NewRow
                        dr("ccodcta") = ""
                        dr("cdescrip") = "Total INGRESOS:"
                        dr("nsalini") = lningini
                        dr("nsaldo") = lningmes
                        dr("nsalfin") = lningresos
                        dr("cnivel") = ""
                        dr("ccodofi") = "000"
                        dr("ffondos") = "00"
                        dr("ccampo") = ""
                        dt.Rows.Add(dr)

                        dr = dt.NewRow
                        dr("ccodcta") = ""
                        dr("cdescrip") = fila("cdescrip")
                        dr("nsalini") = 0
                        dr("nsaldo") = 0
                        dr("nsalfin") = 0
                        dr("cnivel") = "00"
                        dr("ccodofi") = "000"
                        dr("ffondos") = "00"
                        dr("ccampo") = ""
                        dt.Rows.Add(dr)

                    End If

                Else
                    dr = dt.NewRow
                    dr("ccodcta") = fila("ccodcta")
                    dr("cdescrip") = fila("cdescrip")
                    dr("nsalini") = fila("nsalini")
                    If Left(fila("ccodcta"), 1) = "6" Then
                        dr("nsaldo") = Math.Round(fila("nhaber") - fila("ndebe"), 2)
                    Else
                        dr("nsaldo") = Math.Round(fila("ndebe") - fila("nhaber"), 2)
                    End If
                    dr("nsalfin") = fila("nsalfin")
                    dr("cnivel") = fila("cnivel")
                    dr("ccodofi") = fila("ccodofi")
                    dr("ffondos") = fila("ffondos")
                    dr("ccampo") = fila("ccampo")
                    dt.Rows.Add(dr)
                End If



            End If

            i += 1
        Next
        dr = dt.NewRow
        dr("ccodcta") = ""
        dr("cdescrip") = "Total COSTOS Y GASTOS:"
        dr("nsalini") = lnegini
        dr("nsaldo") = lnegmes
        dr("nsalfin") = lnegresos
        dr("cnivel") = ""
        dr("ccodofi") = "000"
        dr("ffondos") = "00"
        dr("ccampo") = ""
        dt.Rows.Add(dr)

        Dim lnresultado As Double = 0
        Dim lnreslmes As Double = 0
        lnresultado = Math.Round(lningresos - lnegresos, 2)
        lnreslmes = Math.Round(lningmes - lnegmes, 2)

        dr = dt.NewRow
        dr("ccodcta") = ""
        If lnreslmes >= 0 Then
            dr("cdescrip") = "Utilidad del Periodo"
        Else
            dr("cdescrip") = "Perdida del Periodo"
        End If
        dr("nsalini") = 0
        dr("nsaldo") = lnreslmes
        dr("nsalfin") = 0
        dr("cnivel") = ""
        dr("ccodofi") = "000"
        dr("ffondos") = "00"
        dr("ccampo") = ""
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("ccodcta") = ""
        If lnresultado >= 0 Then
            dr("cdescrip") = "Utilidad Acumulada"
        Else
            dr("cdescrip") = "Perdida Acumulada"
        End If
        dr("nsalini") = 0
        dr("nsaldo") = 0
        dr("nsalfin") = lnresultado
        dr("cnivel") = ""
        dr("ccodofi") = "000"
        dr("ffondos") = "00"
        dr("ccampo") = ""
        dt.Rows.Add(dr)


        Return ds
    End Function
    Public Function Validarfondos(ByVal ds As DataSet) As Boolean
        Dim dsfondos As New DataSet
        Dim etabttab As New cTabttab
        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        Dim fila As DataRow
        Dim lcfondo As String
        Dim sumObjectd As Object
        Dim sumObjecth As Object
        For Each fila In dsfondos.Tables(0).Rows
            lcfondo = fila("ccodigo")
            ' Declare an object variable.

            sumObjectd = ds.Tables(0).Compute("Sum(ndebe)", "ffondos = " & lcfondo)
            sumObjecth = ds.Tables(0).Compute("Sum(nhaber)", "ffondos = " & lcfondo)

            If sumObjectd <> sumObjecth Then
                Return False
            End If
        Next

        Return True
    End Function

    Public Function CalcularServicios(ByVal cCodcta As String, ByVal dfecval As Date, ByVal lcancela As Boolean) As Decimal 'se cobrara una vez al mes
        'Obtener el interes pendiente al dia
        Dim ecredppg As New cCredppg
        Dim lninterepen As Double = 0
        Dim ecredkar As New cCredkar
        Dim lninterepag As Double = 0

        If lcancela = True Then
            lninterepen = ecredppg.InteresPendienteTotal(cCodcta, dfecval)
        Else
            lninterepen = ecredppg.InteresPendiente(cCodcta, dfecval)
        End If

        If lninterepen = 0 Then
            Return 0
        End If

        'Obtener Interes Pendiente Pagado
        lninterepag = ecredkar.ServicioPagado(cCodcta, dfecval)

        Dim lnmanejo As Double = 0
        lnmanejo = Math.Round(lninterepen - lninterepag, 2)
        If lnmanejo < 0 Then
            lnmanejo = 0
        End If


        Return lnmanejo

    End Function

    Public Function IncluirCampo(ByVal cadena As String, ByVal palabra As String) As Boolean
        Dim a As Integer
        a = InStr(cadena, palabra)
        If a <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ObtenerSumadeDepositos(ByVal ccodcli As String, ByVal dfecha As Date) As Decimal
        Dim eahomcta As New cAhomcta
        Dim eahomcrt As New cAhomcrt
        Dim eahommov As New cAhommov
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        Dim fila As DataRow
        Dim lccodaho As String
        Dim lndepositos As Decimal = 0
        Dim lnsuma As Decimal = 0

        ds = eahomcta.ObtieneCuentasxCliente(ccodcli)
        For Each fila In ds.Tables(0).Rows
            lccodaho = fila("ccodaho")
            lndepositos = eahommov.ObtieneDepositosxcuenta(lccodaho, dfecha)
            lnsuma = lnsuma + lndepositos
        Next

        Dim lncertificados As Decimal = 0
        lncertificados = eahomcrt.ObtieneDepositosxcuenta(ccodcli, dfecha)

        Dim lnabonos As Decimal = 0
        lnabonos = ecreditos.ObtenerAbonosCreditos(ccodcli, dfecha)

        lnsuma = lnsuma + lncertificados + lnabonos

        Return lnsuma
    End Function
    Public Function CargaBeneficiarios() As DataSet

        Try

            Dim rs As New DataSet, dr As DataRow
            Dim dat_AdPar As New DataTable("Beneficiarios")
            dat_AdPar.Clear()
            'Agregando la Encabezado 
            dat_AdPar.Columns.Add("IdCorre", Type.GetType("System.Decimal"))
            dat_AdPar.Columns.Add("cNomben", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("cParentesco", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("cdirben", Type.GetType("System.String"))
            dat_AdPar.Columns.Add("nPorcen", Type.GetType("System.Decimal"))
            dat_AdPar.Columns.Add("dfecnac", Type.GetType("System.DateTime"))

            rs.Tables.Add(dat_AdPar)

            Return rs

        Catch ex As Exception

        End Try

    End Function
    'Public Function ValidaEMail(ByVal EMail As String) As Boolean
    '    'Como primera regla un correo electronico debe contener la @
    '    If Not EMail.Contains("@") Then
    '        Return False
    '    End If
    '    'Dividimos la cadena en secciones, obviamente estas deben ser 2
    '    'el usuario y el host, utilizamos como separador la @
    '    Dim SeccionesEMail As String() = EMail.Split(CChar("@"))
    '    'Ahora verificamos que evidentemente solo sean 2 secciones, ya que 
    '    'en caso contrario eso significa que hay mas de una @ y eso es incorrecto
    '    If SeccionesEMail.Length <> 2 Then
    '        Return False
    '    End If
    '    'Ahora verificamos que la segunda seccion de la cadena de correo contenga
    '    'al menos un punto, ya que la seccion del dominio debe contener el punto
    '    'Podemos establecer un tamaño minimo para el dominio en este caso le puse 3
    '    If Not SeccionesEMail(1).Contains(".") Or Not SeccionesEMail(1).Length >= 3 Then
    '        Return False
    '    End If
    '    Return True
    'End Function
    Public Function fxLinea(ByVal pnlinea As Integer) As Integer
        If pnlinea > 65 Then
            'MESSAGEBOX("Su Libreta ha Terminado," + Chr(13) + "Pasar por una Nueva", 48, "mensaje")
            pnlinea = 1
        End If

        Return pnlinea
    End Function
    Public Function GrabarBoletas(ByVal cbanco As String, ByVal cnuming As String, ByVal cestado As String, ByVal dfecsis As Date, ByVal dfecpro As Date, ByVal nmonto As Decimal) As Integer
        Dim eboletas As New cBOLETAS
        Dim entidadboletas As New BOLETAS

        entidadboletas.cbanco = cbanco
        entidadboletas.cnuming = cnuming
        entidadboletas.cestado = cestado
        entidadboletas.dfecsis = dfecsis
        entidadboletas.dfecpro = dfecpro
        entidadboletas.nmonto = nmonto

        Try
            eboletas.Agregar(entidadboletas)
            Return 1
        Catch ex As Exception
            Return 0
        End Try


    End Function
    'para validar solo meses abiertos
    Public Function valida_mes(ByVal dfecha As Date, ByVal gdfecsis As Date) As Boolean

        Dim mes1 As Integer = Month(gdfecsis)
        Dim mes2 As Integer = dfecha.ToString.Trim.Substring(3, 2)

        Dim ldfeclim As Date
        ldfeclim = DateAdd(DateInterval.Month, 1, gdfecsis)
        If dfecha > ldfeclim Then
            Return False
        End If

        'If mes2 > (mes1 + 1) Then 'mes de la fecha es mayor al que se esta procesando actualmente
        '    Return False
        'End If

        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select As String = ""
        Dim mes As String = dfecha.ToString.Trim.Substring(3, 2)
        Dim fila As DataRow
        Dim resp As Boolean = False

        Dim ds As New DataSet

        con.ConnectionString = stringconnection
        con.Open()

        str_select = "select cierre from cnumes where numes = " & miclase1.ToString(mes)
        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        For Each fila In ds.Tables(0).Rows
            If fila("cierre") = 0 Then
                resp = True
            End If
        Next

        Return resp

    End Function
    Public Function Moraaportaciones(ByVal lccodcli As String, ByVal dfecha2 As String) As Decimal
        Dim eahomcta As New cAhomcta
        Dim lnaporta As Decimal = 0
        Dim lnaportateo As Decimal = 0
        Dim lnmora As Decimal = 0
        Dim lncondonar As Decimal = 0


        lnaporta = eahomcta.Aportaciones(lccodcli)
        lnaportateo = AportacionTeorica(lccodcli, dfecha2)
        lncondonar = eahomcta.condonacionAportaciones(lccodcli)

        lnmora = lnaportateo - (lnaporta + lncondonar)

        If lnmora < 0 Then
            lnmora = 0
        End If

        lnmora = 0
        Return lnmora

    End Function

    Public Function AportacionTeorica(ByVal lccodcli As String, ByVal dfecha2 As Date) As Decimal
        Dim dfecha1 As Date 'fecha de ingreso

        'Obtenemos dataset de aportaciones
        Dim eahomcta As New cAhomcta


        dfecha1 = eahomcta.ObtieneFechaIngreso(lccodcli, "06")




        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        ds = eahomcta.ObtenerDataAportacion()

        Dim ldini As Date
        Dim ldfin As Date
        Dim lnvalor As Decimal = 0
        Dim lnmeses As Integer = 0
        Dim lnaporta As Decimal = 0

        For Each fila In ds.Tables(0).Rows
            ldini = ds.Tables(0).Rows(i)("dfecini")
            ldfin = ds.Tables(0).Rows(i)("dfecfin")
            lnvalor = ds.Tables(0).Rows(i)("naportacion")

            If (dfecha1 >= ldini And dfecha1 <= ldfin) Then
                'Obtenemos los meses a calcular
                If ldfin < dfecha2 Then
                    lnmeses = DateDiff(DateInterval.Month, dfecha1, ldfin)
                Else
                    lnmeses = DateDiff(DateInterval.Month, dfecha1, dfecha2)
                End If

                lnaporta = lnaporta + (lnmeses * lnvalor)
                dfecha1 = DateAdd(DateInterval.Day, 1, ldfin)


            End If

            i += 1
        Next

        Return lnaporta
        '    If dfecha1 >= #12/20/1971# And dfecha1 <= #3/31/1992# Then


        '    End If




    End Function
    Public Function PartidasDepreciacion(ByVal ds As DataSet, ByVal dfecha As DateTime)

        Dim mcntamov As New cCntamov
        Dim mtabtofi As New cTabtofi
        Dim dsoficinas As New DataSet
        Dim dsfondos As New DataSet
        Dim droficinas As DataRow
        Dim drfondos As DataRow
        Dim mtabttab As New cTabttab
        Dim lcoficina As String
        Dim lcfondo As String
        Dim dr As DataRow
        Dim lnnumlin As Integer
        Dim ldfecha As DateTime
        Dim ldfecha2 As DateTime
        Dim cclase As New crefunc

        Dim entidaddiario As New diario
        Dim drcuentas As DataRow
        Dim lcnumpar As String
        Dim ediario As New cDiario
        Dim entidadcntamov As New cntamov
        Dim ecntamov As New cCntamov
        Dim clssdes As New clsDesembolsa
        Dim i As Integer = 0
        Dim lcdescr As String

        ldfecha = dfecha
        ldfecha2 = dfecha
        dsoficinas = mtabtofi.ObtenerDataSetPorID()
        dsfondos = mtabttab.ObtenerDataSetPorID("033", "1")
        lnnumlin = 0

        Try


            For Each droficinas In dsoficinas.Tables(0).Rows
                lcoficina = droficinas("ccodofi")
                lcoficina = lcoficina.Trim

                For Each drfondos In dsfondos.Tables(0).Rows
                    lcfondo = drfondos("ccodigo")
                    lcfondo = lcfondo.Trim 'clssdes.ConvertidorFondos(lcfondo.Trim)

                    'dsbalance = mcntamov.Obtener_Saldos_fondos_oficina_CuentasdeResultado(ldfecha1, ldfecha2, lcfondo, lcoficina)

                    If ds.Tables(0).Rows.Count > 0 Then
                        If ds.Tables(0).Rows(0)("ccodofi") = lcoficina And ds.Tables(0).Rows(0)("ffondos") = lcfondo Then
                            lcnumpar = cclase.fxStevo(ldfecha2) 'Numero de Partida
                            entidaddiario.cnumcom = lcnumpar
                            entidaddiario.cglosa = "Partida DEPRE." & "Mes:" & ldfecha2.Month.ToString & " fondo:" & lcfondo & " Oficina:" & lcoficina
                            entidaddiario.cnumdoc = "DEPRE"
                            entidaddiario.dfeccnt = ldfecha2
                            entidaddiario.cestado = " "
                            entidaddiario.ccodofi = lcoficina
                            entidaddiario.ffondos = lcfondo
                            entidaddiario.dfecdoc = ldfecha2
                            entidaddiario.dfecmod = ldfecha2 + " " + Now.TimeOfDay.ToString

                            entidaddiario.ctipasi = "01"
                            entidaddiario.ctipmon = "1"
                            entidaddiario.ccodruc = "01"
                            entidaddiario.ccodemp = "01"
                            entidaddiario.ccodusu = Me.pcCodUsu
                            entidaddiario.nccompra = 0.0
                            entidaddiario.ncventa = 0.0
                            entidaddiario.ntcfijo = 0.0
                            entidaddiario.cnrodoc = " "
                            entidaddiario.cfv = " "
                            entidaddiario.nfln = 0.0
                            entidaddiario.ccodrev = " "
                            entidaddiario.ccodreg = "001"

                            ediario.agregarDiario(entidaddiario)

                            'hace partida
                            Dim lnflag As Integer = 0
                            Dim lntotdebe As Double = 0
                            Dim lntothaber As Double = 0
                            Dim lnresultado As Double = 0
                            Dim lnsaldotot As Double = 0
                            Dim lccodctad As String
                            Dim lccodctah As String



                            For Each dr In ds.Tables(0).Rows
                                lnresultado = ds.Tables(0).Rows(i)("depremensual")
                                ' Registra depreciaciones oficinas centrales
                                If ds.Tables(0).Rows(i)("ccodofi") = "001" Then
                                    If ds.Tables(0).Rows(i)("ccodact") = "30" Then
                                        lccodctad = "703110010103"
                                        lccodctah = "203102010401"
                                        lcdescr = "Equipó Computo"
                                    End If
                                    If ds.Tables(0).Rows(i)("ccodact") = "10" Or ds.Tables(0).Rows(i)("ccodact") = "20" Then
                                        lccodctad = "703110010102"
                                        lccodctah = "203102010301"
                                        lcdescr = "Mobiliario y Equipo"
                                    End If
                                    If ds.Tables(0).Rows(i)("ccodact") = "40" Then
                                        lccodctad = "703110010106"
                                        lccodctah = "203102010701"
                                        lcdescr = "Vehiculos"
                                    End If
                                    ' registra el debe
                                    lnnumlin = lnnumlin + 1
                                    entidadcntamov.cnumcom = lcnumpar
                                    entidadcntamov.ccodcta = lccodctad
                                    entidadcntamov.cnumlin = lnnumlin
                                    entidadcntamov.nhaber = 0
                                    entidadcntamov.ndebe = lnresultado
                                    entidadcntamov.ccodpres = "DEPRE. MENSUAL"
                                    entidadcntamov.cnumdoc = "DEPRE"
                                    entidadcntamov.ccodofi = ds.Tables(0).Rows(i)("ccodofi")
                                    entidadcntamov.cflc = " "
                                    entidadcntamov.dfeccnt = ldfecha2
                                    entidadcntamov.dfecmod = ldfecha2 + " " + Now.TimeOfDay.ToString
                                    entidadcntamov.ccodusu1 = Me.pcCodUsu
                                    entidadcntamov.ffondos = ds.Tables(0).Rows(i)("ffondos")
                                    entidadcntamov.cclase = Left(lccodctad, 1)
                                    entidadcntamov.cpoliza = "DE"

                                    entidadcntamov.ccodsec = "01"
                                    entidadcntamov.cconcepto = "DEPRE. MENSUAL " & lcdescr & " Mes:" & ldfecha2.Month.ToString & " fondo: " & lcfondo & " Oficina: " & lcoficina
                                    entidadcntamov.cnumpol = "001"
                                    entidadcntamov.ccodreg = "001"
                                    entidadcntamov.ccodcli = " "
                                    ecntamov.agregarCntamov(entidadcntamov)

                                    ' registra haber
                                    lnnumlin = lnnumlin + 1

                                    entidadcntamov.cnumcom = lcnumpar
                                    entidadcntamov.ccodcta = lccodctah
                                    entidadcntamov.cnumlin = lnnumlin
                                    entidadcntamov.nhaber = lnresultado
                                    entidadcntamov.ndebe = 0
                                    entidadcntamov.ccodpres = "DEPRE. MENSUAL"
                                    entidadcntamov.cnumdoc = "DEPRE"
                                    entidadcntamov.ccodofi = ds.Tables(0).Rows(i)("ccodofi")
                                    entidadcntamov.cflc = " "
                                    entidadcntamov.dfeccnt = ldfecha2
                                    entidadcntamov.dfecmod = ldfecha2 + " " + Now.TimeOfDay.ToString
                                    entidadcntamov.ccodusu1 = Me.pcCodUsu
                                    entidadcntamov.ffondos = ds.Tables(0).Rows(i)("ffondos")
                                    entidadcntamov.cclase = Left(lccodctah, 1)
                                    entidadcntamov.cpoliza = "DE"

                                    entidadcntamov.ccodsec = "01"
                                    entidadcntamov.cconcepto = "DEPRE. MENSUAL " & lcdescr & " Mes:" & ldfecha2.Month.ToString & " fondo: " & lcfondo & " Oficina: " & lcoficina
                                    entidadcntamov.cnumpol = "001"
                                    entidadcntamov.ccodreg = "001"
                                    entidadcntamov.ccodcli = " "

                                    ecntamov.agregarCntamov(entidadcntamov)

                                Else
                                    ' registra depreciaciones agencias regionales.
                                    If ds.Tables(0).Rows(i)("ccodofi") = lcoficina Or ds.Tables(0).Rows(i)("ccodofi") <> "001" Then
                                        If ds.Tables(0).Rows(i)("ccodact") = "30" Then
                                            lccodctad = "709110010103"
                                            lccodctah = "203102010401"
                                            lcdescr = "Equipó Computo"
                                        End If
                                        If ds.Tables(0).Rows(i)("ccodact") = "10" Or ds.Tables(0).Rows(i)("ccodact") = "20" Then
                                            lccodctad = "709110010102"
                                            lccodctah = "203102010301"
                                            lcdescr = "Mobiliario y Equipo"
                                        End If
                                        If ds.Tables(0).Rows(i)("ccodact") = "40" Then
                                            lccodctad = "709110010106"
                                            lccodctah = "203102010701"
                                            lcdescr = "Vehiculos"
                                        End If
                                    End If

                                    ' registra el debe
                                    lnnumlin = lnnumlin + 1
                                    entidadcntamov.cnumcom = lcnumpar
                                    entidadcntamov.ccodcta = lccodctad
                                    entidadcntamov.cnumlin = lnnumlin
                                    entidadcntamov.nhaber = 0
                                    entidadcntamov.ndebe = lnresultado
                                    entidadcntamov.ccodpres = "DEPRE. MENSUAL"
                                    entidadcntamov.cnumdoc = "DEPRE"
                                    entidadcntamov.ccodofi = ds.Tables(0).Rows(i)("ccodofi")
                                    entidadcntamov.cflc = " "
                                    entidadcntamov.dfeccnt = ldfecha2
                                    entidadcntamov.dfecmod = ldfecha2 + " " + Now.TimeOfDay.ToString
                                    entidadcntamov.ccodusu1 = Me.pcCodUsu
                                    entidadcntamov.ffondos = ds.Tables(0).Rows(i)("ffondos")
                                    entidadcntamov.cclase = Left(lccodctad, 1)
                                    entidadcntamov.cpoliza = "DE"

                                    entidadcntamov.ccodsec = "01"
                                    entidadcntamov.cconcepto = "DEPRE. MENSUAL " & lcdescr & " Mes:" & ldfecha2.Month.ToString & " fondo:" & lcfondo & " Oficina:" & lcoficina
                                    entidadcntamov.cnumpol = "001"
                                    entidadcntamov.ccodreg = "001"
                                    entidadcntamov.ccodcli = " "
                                    ecntamov.agregarCntamov(entidadcntamov)

                                    ' registra haber
                                    lnnumlin = lnnumlin + 1

                                    entidadcntamov.cnumcom = lcnumpar
                                    entidadcntamov.ccodcta = lccodctah
                                    entidadcntamov.cnumlin = lnnumlin
                                    entidadcntamov.nhaber = lnresultado
                                    entidadcntamov.ndebe = 0
                                    entidadcntamov.ccodpres = "DEPRE. MENSUAL"
                                    entidadcntamov.cnumdoc = "DEPRE"
                                    entidadcntamov.ccodofi = ds.Tables(0).Rows(i)("ccodofi")
                                    entidadcntamov.cflc = " "
                                    entidadcntamov.dfeccnt = ldfecha2
                                    entidadcntamov.dfecmod = ldfecha2 + " " + Now.TimeOfDay.ToString
                                    entidadcntamov.ccodusu1 = Me.pcCodUsu
                                    entidadcntamov.ffondos = ds.Tables(0).Rows(i)("ffondos")
                                    entidadcntamov.cclase = Left(lccodctah, 1)
                                    entidadcntamov.cpoliza = "DE"

                                    entidadcntamov.ccodsec = "01"
                                    entidadcntamov.cconcepto = "DEPRE. MENSUAL " & lcdescr & " Mes:" & ldfecha2.Month.ToString & " fondo: " & lcfondo & " Oficina: " & lcoficina
                                    entidadcntamov.cnumpol = "001"
                                    entidadcntamov.ccodreg = "001"
                                    entidadcntamov.ccodcli = " "

                                    ecntamov.agregarCntamov(entidadcntamov)



                                End If
                                i += 1
                            Next
                        End If
                    End If
                    lnnumlin = 0

                Next
            Next
            Return lcnumpar
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function TipodeGarantia(ByVal pccodcta As String) As String
        Dim lctipo As String = ""
        Dim etabttab As New cTabttab
        Dim lctipgar, lcdesgar As String
        lctipgar = ObtenerCodigoGarantia(pccodcta)
        lcdesgar = etabttab.Describe(lctipgar, "074")

        Return lcdesgar
    End Function
    Public Function VerificaExistePlanTeorico(ByVal ccodcre As String) As Boolean
        Dim ecredtpl As New cCredtpl
        Dim entidadcredtpl As New credtpl
        Dim i As Integer = 0
        entidadcredtpl.ccodcta = ccodcre
        entidadcredtpl.ctipope = "D"
        entidadcredtpl.cnrocuo = "001"
        i = ecredtpl.ObtenerCredtpl(entidadcredtpl)
        If i = 0 Then
            Return False
        Else
            Return True
        End If


    End Function
    Public Function ValidaEMail(ByVal EMail As String) As Boolean
        'Como primera regla un correo electronico debe contener la @
        If Not EMail.Contains("@") Then
            Return False
        End If
        'Dividimos la cadena en secciones, obviamente estas deben ser 2
        'el usuario y el host, utilizamos como separador la @
        Dim SeccionesEMail As String() = EMail.Split(CChar("@"))
        'Ahora verificamos que evidentemente solo sean 2 secciones, ya que 
        'en caso contrario eso significa que hay mas de una @ y eso es incorrecto
        If SeccionesEMail.Length <> 2 Then
            Return False
        End If
        'Ahora verificamos que la segunda seccion de la cadena de correo contenga
        'al menos un punto, ya que la seccion del dominio debe contener el punto
        'Podemos establecer un tamaño minimo para el dominio en este caso le puse 3
        If Not SeccionesEMail(1).Contains(".") Or Not SeccionesEMail(1).Length >= 3 Then
            Return False
        End If
        Return True
    End Function

    Public Function ObtenerCodigoGarantia(ByVal ccodcta As String) As String
        'Carga garantias para contabilizar combinacion
        Dim etabttab As New cTabttab
        Dim ecrepgar As New cCrepgar
        Dim ds As New DataSet
        ds = etabttab.ObtenerDataSetPorIDx("037", "1")
        Dim lccodigo As String
        Dim lncontados As Integer = 0
        Dim lcllave As String = "" '"000"
        For Each fila As DataRow In ds.Tables(0).Rows
            lccodigo = fila("ccodigo")
            'Obtener garantias de un tipo determinado en crepgar
            lncontados = ecrepgar.ObtenerGarantiasdeuntipoRegistrada(ccodcta, lccodigo)
            fila("ncontados") = lncontados
            'Armamos codigo contatenado q servira para saber la combinacion
            If lncontados = 0 Then
                lcllave = lcllave.Trim + "0"
            Else
                lcllave = lcllave.Trim + "1"
            End If
        Next

        'Buscamos llave en codigos de garantias contables
        Dim lccodaux As String = ""
        lccodaux = etabttab.ObtieneCodigoxCampoAuxiliar(lcllave, "074")

        Return lccodaux
    End Function

    Public Function ObtenerCuotaOficial(ByVal ccodcta As String) As Decimal
        Dim lncuota As Decimal
        Dim lncapint As Decimal
        Dim lncargo As Decimal
        Dim ecredtpl As New cCredtpl
        Dim ecredgas As New cCredgas

        lncapint = ecredtpl.CapitalInteres(ccodcta)
        lncargo = ecredgas.ObtenerGastoAsignadaaCuota(ccodcta)

        lncuota = Math.Round(lncapint + lncargo, 2)

        Return lncuota

    End Function

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    Public Function fxIntProMor(ByVal cCodcta As String, ByVal nAbono As Double, ByVal cnrodoc As String) As Double 'Funcion para Intereses Moratorios Provisionados

        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        Dim lnProvAct As Double = 0
        Dim lnProvan As Double = 0

        ds = ecremcre.Provisionado(cCodcta)
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            lnProvAct = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovpas")), 0, ds.Tables(0).Rows(0)("nprovpas"))
            'lnProvan = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovmor")), 0, ds.Tables(0).Rows(0)("nprovmor"))
        End If

        Dim lnIntProv As Double = 0
        Dim lnIntAct As Double = 0

        If nAbono >= lnProvAct Then
            lnIntProv = nAbono
            lnIntAct = 0
        Else
            lnIntProv = nAbono
            lnIntAct = Math.Round(lnProvAct - nAbono, 2)
        End If

        Dim nabono1 As Double = 0
        Dim lndesint As Double = 0

        'Descarga Provison Acumulada del Mes

        'nabono1 = nAbono - lnProvAct

        'If nabono1 < 0 Then
        '    lndesint = lnProvan
        'Else
        '    If nabono1 >= lnProvan Then
        '        lndesint = 0
        '    Else
        '        lndesint = lnProvan - nabono1
        '    End If

        'End If

        'Actualiza provision y Traslado a Espejo de Provision
        'Verifica si existe
        Dim lverifica As Boolean
        Dim lnbandera As Integer
        lverifica = ecremcre.VerificaSiExisteEspejo(cCodcta, cnrodoc)
        If lverifica = False Then 'inserta solo el registro
            lnbandera = ecremcre.InsertaRegistroProvisionEspejo(cCodcta, cnrodoc)
        End If

        'Actualiza provision
        Try
            ecremcre.ActualizaProvisionEspejoM(cCodcta, cnrodoc, lnProvAct, lnProvan)
            ecremcre.ActualizaProvisionM(cCodcta, lnIntAct, lndesint)
        Catch ex As Exception
            Return 0
        End Try




        Return lnIntProv


    End Function

    Public Function PlazoMeses(ByVal fechaVig As Date, ByVal fechaVen As Date) As Integer
        Dim lnmeses As Integer
        'lnmeses = DateDiff(DateInterval.Month, fechaVig, fechaVen)
        lnmeses = EvalTiempo(fechaVig, fechaVen)
        Return lnmeses
    End Function
    Public Function EvalTiempo(ByVal Fecha1 As DateTime, ByVal FechaFinal As DateTime) As Integer
        Dim Meses As Integer = 0

        If Fecha1.AddMonths(1) >= FechaFinal Then
            Return 0
            Exit Function
        End If

        Do
            If Fecha1 >= FechaFinal Then
                If Fecha1 = FechaFinal Then
                    Return Meses
                Else
                    Dim lndias As Integer
                    lndias = DateDiff(DateInterval.Day, FechaFinal, Fecha1) 'dias que faltan para completar mes
                    If lndias <= 15 Then
                        Return Meses
                    Else
                        Return Meses - 1
                    End If

                End If

                Exit Function
            End If

            Fecha1 = Fecha1.AddMonths(1)
            Meses += 1
        Loop
    End Function
    Public Sub Auditoria(ByVal ccodusu As String, ByVal dfecsis As String, ByVal pctrs As String, ByVal pidopcion As Integer)
        'Auditoria'
        Try
            Dim ip As Net.Dns
            Dim nombre_Host As String = ip.GetHostName
            Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)
            Dim direccion_Ip As String = este_Host.AddressList(0).ToString
            Dim entidadusuarios As New usuarios
            Dim milogin As New cLogin
            Dim eusuarios As New cusuarios
            entidadusuarios.cip = direccion_Ip
            entidadusuarios.dfecha = Today
            entidadusuarios.chora = TimeOfDay.ToString.Substring(11, 12)
            entidadusuarios.idUsuario = milogin.IdUsuario(ccodusu)
            entidadusuarios.gdfecsis = dfecsis
            entidadusuarios.ctrs = pctrs
            entidadusuarios.idopcion = pidopcion

            eusuarios.RegistraAuditoria(entidadusuarios)
        Catch ex As Exception

        End Try
    End Sub
    Public Function AjusteContableProvision(ByVal ds As DataSet, ByVal dfecha As Date, ByVal ccodusu As String) As Integer
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim cClsAdP As New SIM.BL.ClsAdPart

        Dim ldfecha As Date = dfecha
        Dim ecremcre As New cCremcre
        Dim etabttab As New cTabttab
        Dim dsfondos As New DataSet
        Dim dsmetodo As New DataSet
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim lcctactb1 As String = ""

        Dim lcctactba As String = ""
        Dim lcctactb1a As String = ""

        Dim cplanti As String = ""
        Dim dsoficina As New DataSet
        Dim etabtofi As New cTabtofi
        Dim lccodofi As String = ""

        dsoficina = etabtofi.ObtenerDataSetPorID()
        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodigo As String
        Dim clasefunc As New crefunc

        Dim lnsalint As Decimal = 0
        Dim lnsalmor As Decimal = 0

        Dim lnsalintctb As Decimal = 0
        Dim lnsalmorctb As Decimal = 0

        Dim lcmascara As String = "CINNN"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactb = "*"
        Else
            lcctactb = entidadtabtmak.cplanti.Trim
        End If

        lcmascara = "CINFN"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactba = "*"
        Else
            lcctactba = entidadtabtmak.cplanti.Trim
        End If


        lcmascara = "CMONN"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactb1 = "*"
        Else
            lcctactb1 = entidadtabtmak.cplanti.Trim
        End If

        lcmascara = "CMOFN"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactb1a = "*"
        Else
            lcctactb1a = entidadtabtmak.cplanti.Trim
        End If

        Dim oki As Integer = 0
        Dim x As Integer = 0


        '---------------Genera Partida Regularizadora
        cClsAdP._dfecmod = Now()
        cClsAdP._ccodusu = ccodusu
        cClsAdP._cconcepto = "PARTIDA DIARIA REGULARIZADORA DEL DIA:  " & Left(dfecha.ToString, 10)
        cClsAdP._dfeccnt = ldfecha
        cClsAdP._cpoliza = "PI"
        cClsAdP._nCuenta = 1
        cClsAdP._cnumdoc = "F"
        cClsAdP._llbandera = True
        cClsAdP._ccodpres = ""

        For Each fila00 As DataRow In dsoficina.Tables(0).Rows 'Oficinas
            lccodofi = Trim(fila00("ccodofi"))
            cClsAdP._ccodofi = lccodofi

            x = 0
            For Each fila In dsfondos.Tables(0).Rows 'Fondos
                lccodigo = Trim(fila("ccodigo"))
                cClsAdP._ffondos = lccodigo.Trim

                'Obtiene Saldos de intereses normales
                lnsalint = SaldosIntereses(ds, lccodofi, lccodigo, 1)
                lnsalmor = SaldosIntereses(ds, lccodofi, lccodigo, 2)

                'Obtiene Saldos contables
                lnsalintctb = ObtenerSaldo(lcctactb, lccodofi, lccodigo, dfecha)
                lnsalmorctb = ObtenerSaldo(lcctactb1, lccodofi, lccodigo, dfecha)

                If Math.Round(lnsalintctb - lnsalint, 2) <> 0 Or Math.Round(lnsalmorctb - lnsalmor, 2) <> 0 Then


                    If Math.Round(lnsalintctb - lnsalint, 2) > 0 Then 'Saldo de Intereses
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalintctb - lnsalint, 2)
                        cClsAdP._cclase = Left(lcctactb, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactba
                        cClsAdP._ndebe = Math.Round(lnsalintctb - lnsalint, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactba, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    Else
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = Math.Round(lnsalint - lnsalintctb, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactb, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactba
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalint - lnsalintctb, 2)
                        cClsAdP._cclase = Left(lcctactba, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    End If

                    'Saldo de Interes Moratorio
                    If Math.Round(lnsalmorctb - lnsalmor, 2) > 0 Then 'Saldo de Int. Moratorio
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalmorctb - lnsalmor, 2)
                        cClsAdP._cclase = Left(lcctactb1, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1a
                        cClsAdP._ndebe = Math.Round(lnsalmorctb - lnsalmor, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactb1a, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    Else
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1
                        cClsAdP._ndebe = Math.Round(lnsalmor - lnsalmorctb, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactb1, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1a
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalmor - lnsalmorctb, 2)
                        cClsAdP._cclase = Left(lcctactb1a, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    End If
                End If

            Next
        Next
    End Function
    Public Function SaldosIntereses(ByVal ds As DataSet, ByVal ccodofi As String, ByVal ffondos As String, ByVal nflag As Integer) As Decimal
        Dim dscartera As New DataSet
        dscartera = Filtrar(ds.Tables(0), " ccondic <> 'S' and  ccodofi='" & ccodofi & "'  and substring(ccodlin,3,2) = '" & ffondos & "'")
        Dim lnsaldo As Decimal = 0

        For Each fila As DataRow In dscartera.Tables(0).Rows
            If nflag = 1 Then
                lnsaldo = lnsaldo + fila("nsalintant")
            Else
                lnsaldo = lnsaldo + fila("nsalMorAnt")
            End If

        Next

        Return lnsaldo
    End Function
    Public Function SaldosInteresesCastigada(ByVal ds As DataSet, ByVal ccodofi As String, ByVal ffondos As String, ByVal nflag As Integer) As Decimal
        Dim dscartera As New DataSet
        dscartera = Filtrar(ds.Tables(0), " ccondic = 'S' and  ccodofi='" & ccodofi & "'  and substring(ccodlin,3,2) = '" & ffondos & "'")
        Dim lnsaldo As Decimal = 0

        For Each fila As DataRow In dscartera.Tables(0).Rows
            If nflag = 1 Then
                lnsaldo = lnsaldo + fila("nsalintant")
            Else
                lnsaldo = lnsaldo + fila("nsalMorAnt")
            End If

        Next

        Return lnsaldo
    End Function
    Public Function Filtrar(ByVal dt As DataTable, ByVal filtro As String) As DataSet
        Dim tabla As DataTable
        tabla = FiltraTabla(dt, filtro)

        Dim ds2 As New DataSet
        ds2.Tables.Add(tabla)

        Return ds2
    End Function

    Public Function FiltraTabla(ByVal TablaTemporal As DataTable, ByVal Filtro As String) As DataTable

        Dim dvVista As New DataView

        dvVista = TablaTemporal.DefaultView

        dvVista.RowFilter = Filtro

        Return dvVista.ToTable

    End Function
    Public Function ObtenerSaldo(ByVal ccodcta As String, ByVal ccodofi As String, ByVal ffondos As String, ByVal dfecha As Date) As Decimal
        Dim classconta As New clsConta
        Dim mcntamov As New cCntamov
        Dim ecntaprm As New cCntaprm
        Dim ds As New DataSet
        Dim ds2 As New DataSet
        ds = ecntaprm.ObtenerfiscaltoClose("99")

        Dim lnsaldo As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            Dim ldfecha1 As Date
            Dim ldfecha2 As Date
            Dim lcnivel As Integer
            lcnivel = ccodcta.Trim.Length

            ldfecha1 = ds.Tables(0).Rows(0)("dfecimes")
            ldfecha2 = dfecha

            ds2 = mcntamov.ObtenerSaldosPorCuenta1(ldfecha1, ldfecha2, ccodcta, lcnivel, "", ccodofi, ffondos)

            Dim lndebe As Decimal = 0
            Dim lnhaber As Decimal = 0

            If ds2.Tables(0).Rows.Count = 0 Then
            Else
                lndebe = IIf(IsDBNull(ds2.Tables(0).Rows(0)("ndebe")), 0, ds2.Tables(0).Rows(0)("ndebe"))
                lnhaber = IIf(IsDBNull(ds2.Tables(0).Rows(0)("ndebe")), 0, ds2.Tables(0).Rows(0)("nhaber"))
            End If

            If ccodcta.Substring(0, 1) = "1" Or ccodcta.Substring(0, 1) = "8" Or ccodcta.Substring(0, 1) = "7" Or ccodcta.Substring(0, 1) = "9" Then
                lnsaldo = Math.Round(lndebe - lnhaber, 2)
            Else
                lnsaldo = Math.Round(lnhaber - lndebe, 2)
            End If


        End If

        Return lnsaldo
    End Function

    Public Function PrimerDiaMes(ByVal datFecha As Date) As Date
        Dim dfecha As Date
        dfecha = DateSerial(Year(datFecha), Month(datFecha), 1)
        Return dfecha
    End Function    ' PrimerDiaMes

    Public Function ActualizaGarantiaCremcre(ByVal ccodcta As String) As Integer
        Dim command As New SqlCommand
        Dim lcaux As String = ""
        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                lcaux = ObtenerCodigoGarantia(ccodcta)
                command.Connection = conneccion
                command.CommandText = "UPDATE CREMCRE SET ctipgar ='" & lcaux.Trim & "' where ccodcta ='" & ccodcta & "'"
                command.ExecuteNonQuery()
                lnretorno = 1
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using
        Return lnretorno
    End Function
    Public Function AjusteContableProvisionCastigada(ByVal ds As DataSet, ByVal dfecha As Date, ByVal ccodusu As String) As Integer
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim cClsAdP As New SIM.BL.ClsAdPart

        Dim ldfecha As Date = dfecha
        Dim ecremcre As New cCremcre
        Dim etabttab As New cTabttab
        Dim dsfondos As New DataSet
        Dim dsmetodo As New DataSet
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim lcctactb1 As String = ""

        Dim lcctactba As String = ""
        Dim lcctactb1a As String = ""

        Dim cplanti As String = ""
        Dim dsoficina As New DataSet
        Dim etabtofi As New cTabtofi
        Dim lccodofi As String = ""

        dsoficina = etabtofi.ObtenerDataSetPorID()
        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodigo As String
        Dim clasefunc As New crefunc

        Dim lnsalint As Decimal = 0
        Dim lnsalmor As Decimal = 0

        Dim lnsalintctb As Decimal = 0
        Dim lnsalmorctb As Decimal = 0

        Dim lcmascara As String = "CINXS"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactb = "*"
        Else
            lcctactb = entidadtabtmak.cplanti.Trim
        End If

        lcmascara = "CCJXS"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactba = "*"
        Else
            lcctactba = entidadtabtmak.cplanti.Trim
        End If


        lcmascara = "CMOXS"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactb1 = "*"
        Else
            lcctactb1 = entidadtabtmak.cplanti.Trim
        End If

        lcmascara = "CCJXS"
        entidadtabtmak.ccodigo = lcmascara
        busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
        If busquedaplantilla = 0 Then
            lcctactb1a = "*"
        Else
            lcctactb1a = entidadtabtmak.cplanti.Trim
        End If

        Dim oki As Integer = 0
        Dim x As Integer = 0


        '---------------Genera Partida Regularizadora
        cClsAdP._dfecmod = Now()
        cClsAdP._ccodusu = ccodusu
        cClsAdP._cconcepto = "PARTIDA DIARIA REGULARIZADORA CARTERA CASTIGADA DEL DIA:  " & Left(dfecha.ToString, 10)
        cClsAdP._dfeccnt = ldfecha
        cClsAdP._cpoliza = "PI"
        cClsAdP._nCuenta = 1
        cClsAdP._cnumdoc = "F"
        cClsAdP._llbandera = True
        cClsAdP._ccodpres = ""

        For Each fila00 As DataRow In dsoficina.Tables(0).Rows 'Oficinas
            lccodofi = Trim(fila00("ccodofi"))
            cClsAdP._ccodofi = lccodofi

            x = 0
            For Each fila In dsfondos.Tables(0).Rows 'Fondos
                lccodigo = Trim(fila("ccodigo"))
                cClsAdP._ffondos = lccodigo.Trim

                'Obtiene Saldos de intereses normales
                lnsalint = SaldosInteresesCastigada(ds, lccodofi, lccodigo, 1)
                lnsalmor = SaldosInteresesCastigada(ds, lccodofi, lccodigo, 2)

                'Obtiene Saldos contables
                lnsalintctb = ObtenerSaldo(lcctactb, lccodofi, lccodigo, dfecha)
                lnsalmorctb = ObtenerSaldo(lcctactb1, lccodofi, lccodigo, dfecha)

                If Math.Round(lnsalintctb - lnsalint, 2) <> 0 Or Math.Round(lnsalmorctb - lnsalmor, 2) <> 0 Then


                    If Math.Round(lnsalintctb - lnsalint, 2) > 0 Then 'Saldo de Intereses
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalintctb - lnsalint, 2)
                        cClsAdP._cclase = Left(lcctactb, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactba
                        cClsAdP._ndebe = Math.Round(lnsalintctb - lnsalint, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactba, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    Else
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = Math.Round(lnsalint - lnsalintctb, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactb, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactba
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalint - lnsalintctb, 2)
                        cClsAdP._cclase = Left(lcctactba, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    End If

                    'Saldo de Interes Moratorio
                    If Math.Round(lnsalmorctb - lnsalmor, 2) > 0 Then 'Saldo de Int. Moratorio
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalmorctb - lnsalmor, 2)
                        cClsAdP._cclase = Left(lcctactb1, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1a
                        cClsAdP._ndebe = Math.Round(lnsalmorctb - lnsalmor, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactb1a, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    Else
                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1
                        cClsAdP._ndebe = Math.Round(lnsalmor - lnsalmorctb, 2)
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = Left(lcctactb1, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb1a
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = Math.Round(lnsalmor - lnsalmorctb, 2)
                        cClsAdP._cclase = Left(lcctactb1a, 1)
                        oki = cClsAdP.AdPartida()
                        cClsAdP._nCuenta += 1
                    End If
                End If

            Next
        Next
    End Function
    Public Function VerificaConexion(ByVal ccodusu As String) As Integer
        Dim lnretorno As Integer = 0
        Try
            'Validar que Variable de Sesion de Usuario no vaya vacio
            Dim eusuarios As New cusuarios
            Dim lccodusu As String
            lccodusu = ccodusu
            lnretorno = eusuarios.ValidaSesionUsuario(lccodusu)
        Catch ex As Exception

        End Try

        Return lnretorno
    End Function
    Public Function CierreBancario(ByVal dfecha1 As Date, ByVal dfecha2 As Date) As Integer
        'Obtiene tabtbco
        Dim etabtbco As New cTabtbco

        Dim ecntamov As New cCntamov
        Dim ds As New DataSet

        ds = etabtbco.ObtenerBancos()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodcta As String = ""
        Dim lnsaldoi As Double = 0
        Dim lncargos As Double = 0
        Dim lnabonos As Double = 0
        Dim lnsaldo As Double = 0
        Dim lccodbco As String = ""

        Try
            For Each fila In ds.Tables(0).Rows
                lccodcta = fila("ccodcta")
                lnsaldoi = fila("saldant")
                lccodbco = fila("ccodbco")
                'Obtiene cargos y abonos del periodo
                lncargos = ecntamov.ObtieneCargosBancarios(dfecha1, dfecha2, lccodcta.Trim)
                lnabonos = ecntamov.ObtieneAbonosBancarios(dfecha1, dfecha2, lccodcta.Trim)

                lnsaldo = Math.Round((lnsaldoi + lncargos - lnabonos), 2)
                'Graba saldos iniciales
                etabtbco.ActualizaSaldos(lccodbco.Trim, lnsaldo, lncargos, lnabonos)

            Next

            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function cierre_crea_partidas_cierre(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal nomserver As String, ByVal cctaliq As String) As Integer

        Dim mcntamov As New cCntamov
        Dim mtabtofi As New cTabtofi
        Dim dsoficinas As New DataSet
        Dim dsfondos As New DataSet
        Dim droficinas As DataRow
        Dim drfondos As DataRow
        Dim mtabttab As New cTabttab
        Dim lcoficina As String
        Dim lcfondo As String
        Dim dsbalance As New DataSet
        Dim lnnumlin As Integer
        Dim ldfecha As Date
        Dim cclase As New crefunc

        Dim entidaddiario As New diario
        Dim drcuentas As DataRow
        Dim lcnumpar As String
        Dim ediario As New cDiario
        Dim entidadcntamov As New cntamov
        Dim ecntamov As New cCntamov
        Dim clssdes As New clsDesembolsa


        ldfecha = ldfecha2.AddDays(1)

        dsoficinas = mtabtofi.ObtenerDataSetPorID()
        dsfondos = mtabttab.ObtenerDataSetPorID("033", "1")
        lnnumlin = 0

        Try


            For Each droficinas In dsoficinas.Tables(0).Rows
                lcoficina = droficinas("ccodofi")
                lcoficina = lcoficina.Trim

                For Each drfondos In dsfondos.Tables(0).Rows
                    lcfondo = drfondos("ccodigo")
                    lcfondo = lcfondo.Trim 'clssdes.ConvertidorFondos(lcfondo.Trim)

                    dsbalance = mcntamov.Obtener_Saldos_fondos_oficina_CuentasdeResultado(ldfecha1, ldfecha2, lcfondo, lcoficina)

                    If dsbalance.Tables(0).Rows.Count > 0 Then

                        lcnumpar = cclase.fxStevo(ldfecha2) 'Numero de Partida
                        entidaddiario.cnumcom = lcnumpar
                        entidaddiario.cglosa = "Partidas de Liquidacion de Cuentas de Resultado " & ldfecha2.Year.ToString & " fondo: " & lcfondo & " Oficina: " & lcoficina
                        entidaddiario.cnumdoc = "Cierre"
                        entidaddiario.dfeccnt = ldfecha2
                        entidaddiario.cestado = " "
                        entidaddiario.ccodofi = lcoficina
                        entidaddiario.ffondos = lcfondo
                        entidaddiario.dfecdoc = ldfecha2
                        entidaddiario.dfecmod = Now

                        entidaddiario.ctipasi = "01"
                        entidaddiario.ctipmon = "1"
                        entidaddiario.ccodruc = "01"
                        entidaddiario.ccodemp = "01"
                        entidaddiario.ccodusu = Me.pcCodUsu
                        entidaddiario.nccompra = 0.0
                        entidaddiario.ncventa = 0.0
                        entidaddiario.ntcfijo = 0.0
                        entidaddiario.cnrodoc = " "
                        entidaddiario.cfv = " "
                        entidaddiario.nfln = 0.0
                        entidaddiario.ccodrev = " "
                        entidaddiario.ccodreg = "001"

                        ediario.agregarDiario(entidaddiario)

                        'hace partida
                        Dim lnflag As Integer = 0
                        Dim lntotdebe As Double = 0
                        Dim lntothaber As Double = 0
                        Dim lnresultado As Double = 0
                        Dim lnsaldotot As Double = 0

                        For Each drcuentas In dsbalance.Tables(0).Rows
                            lnresultado = 0
                            If Left(drcuentas("ccodcta"), 1) = "6" Then 'producto
                                lnresultado = Math.Round(drcuentas("nhaber") - drcuentas("ndebe"), 2)
                            Else 'gastos
                                lnresultado = Math.Round(drcuentas("ndebe") - drcuentas("nhaber"), 2)
                            End If

                            If lnresultado <> 0 Then 'drcuentas("ndebe") <> 0 Or drcuentas("nhaber") <> 0 Then
                                lnflag = 1
                                If lnresultado >= 0 Then
                                    If Left(drcuentas("ccodcta"), 1) = "6" Then
                                        lnnumlin = lnnumlin + 1
                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = drcuentas("ccodcta")
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = 0
                                        entidadcntamov.ndebe = lnresultado
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = Left(drcuentas("ccodcta"), 1)
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "
                                        ecntamov.agregarCntamov(entidadcntamov)


                                        lnnumlin = lnnumlin + 1

                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = cctaliq
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = lnresultado
                                        entidadcntamov.ndebe = 0
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = "5"
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "


                                        ecntamov.agregarCntamov(entidadcntamov)

                                    Else
                                        lnnumlin = lnnumlin + 1
                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = drcuentas("ccodcta")
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = lnresultado
                                        entidadcntamov.ndebe = 0
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = Left(drcuentas("ccodcta"), 1)
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "
                                        ecntamov.agregarCntamov(entidadcntamov)

                                        lnnumlin = lnnumlin + 1

                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = cctaliq
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = 0
                                        entidadcntamov.ndebe = lnresultado
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = "5"
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "


                                        ecntamov.agregarCntamov(entidadcntamov)

                                    End If

                                Else ' saldos negativos
                                    If Left(drcuentas("ccodcta"), 1) = "6" Then
                                        lnnumlin = lnnumlin + 1
                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = drcuentas("ccodcta")
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = Math.Abs(lnresultado)
                                        entidadcntamov.ndebe = 0
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = Left(drcuentas("ccodcta"), 1)
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "
                                        ecntamov.agregarCntamov(entidadcntamov)


                                        lnnumlin = lnnumlin + 1

                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = cctaliq
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = 0
                                        entidadcntamov.ndebe = Math.Abs(lnresultado)
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = "5"
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "


                                        ecntamov.agregarCntamov(entidadcntamov)

                                    Else
                                        lnnumlin = lnnumlin + 1
                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = drcuentas("ccodcta")
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = 0
                                        entidadcntamov.ndebe = Math.Abs(lnresultado)
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = Left(drcuentas("ccodcta"), 1)
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "
                                        ecntamov.agregarCntamov(entidadcntamov)

                                        lnnumlin = lnnumlin + 1

                                        entidadcntamov.cnumcom = lcnumpar
                                        entidadcntamov.ccodcta = cctaliq
                                        entidadcntamov.cnumlin = lnnumlin
                                        entidadcntamov.nhaber = Math.Abs(lnresultado)
                                        entidadcntamov.ndebe = 0
                                        entidadcntamov.ccodpres = "CIERRE"
                                        entidadcntamov.cnumdoc = "CIERRE"
                                        entidadcntamov.ccodofi = lcoficina
                                        entidadcntamov.cflc = " "
                                        entidadcntamov.dfeccnt = ldfecha2
                                        entidadcntamov.dfecmod = Now
                                        entidadcntamov.ccodusu1 = Me.pcCodUsu
                                        entidadcntamov.ffondos = lcfondo
                                        entidadcntamov.cclase = "5"
                                        entidadcntamov.cpoliza = "FC"

                                        entidadcntamov.ccodsec = "01"
                                        entidadcntamov.cconcepto = "LIQUIDACION DE CUENTAS DE RESULTADO"
                                        entidadcntamov.cnumpol = "001"
                                        entidadcntamov.ccodreg = "001"
                                        entidadcntamov.ccodcli = " "


                                        ecntamov.agregarCntamov(entidadcntamov)

                                    End If
                                End If
                            End If
                        Next
                    End If
                    lnnumlin = 0

                Next
            Next
            Return 1
        Catch ex As Exception
            Return 0
        End Try




    End Function
    Public Function TrasladaSaldosBancarios()
        Dim etabtbco As New cTabtbco
        etabtbco.ActualizaSaldosiniciales()

    End Function
    Public Function borra_encabezados(ByVal ldfecha1 As Date, ByVal ldfecha2 As Date, ByVal nomserver As String) As Integer
        Dim SqlConnection1 As System.Data.SqlClient.SqlConnection
        Dim SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Dim ds As DataSet
        Dim SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Dim dsgarantia As New DataSet
        Dim nombre_tabla As String
        Dim cnnstr1 As String
        Dim nombase As String

        'cntamov
        Try

            'myconnection = New SqlConnection(Me.cnnStr)
            'sql = "DELETE FROM CNTAMOV WHERE DFECCNT <= " & "'" & ldfecha2 & "'"
            'cmd = New SqlCommand(sql, myconnection)
            'myconnection.Open()
            'cmd.ExecuteNonQuery()
            'myconnection.Close()

            'ctbdchq
            sql = "DELETE FROM CTBDCHQ WHERE DFECCNT2 <= " & "'" & ldfecha2 & "'"
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.ExecuteNonQuery()
            myconnection.Close()

            'diario
            sql = "DELETE FROM DIARIO WHERE DFECCNT <= " & "'" & ldfecha2 & "'"
            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.ExecuteNonQuery()
            myconnection.Close()

            Return 1


        Catch ex As Exception

            Return 0

        End Try


    End Function
    Public Function Porcentaje_Rango(ByVal factor As Decimal) As Decimal
        Dim lnpor As Decimal = 0
        Dim etabttab As New cTabttab
        If factor <= 0 Then
            lnpor = 0
        ElseIf factor > 0 And factor <= 0.25 Then
            lnpor = etabttab.ObtenerFactor("162", "09")
        ElseIf factor > 0.25 And factor <= 0.5 Then
            lnpor = etabttab.ObtenerFactor("162", "10")
        ElseIf factor > 0.5 And factor <= 1 Then
            lnpor = etabttab.ObtenerFactor("162", "11")
        ElseIf factor > 1 And factor <= 1.5 Then
            lnpor = etabttab.ObtenerFactor("162", "12")
        ElseIf factor > 1.5 And factor <= 2 Then
            lnpor = etabttab.ObtenerFactor("162", "13")
        ElseIf factor > 2 And factor <= 2.5 Then
            lnpor = etabttab.ObtenerFactor("162", "14")
        ElseIf factor > 2.5 And factor <= 3 Then
            lnpor = etabttab.ObtenerFactor("162", "15")
        Else
            lnpor = etabttab.ObtenerFactor("162", "16")
        End If
        Return lnpor
    End Function

    Public Function fxIniDate(ByVal dfecha As Date) As Date
        Dim ldFecha As Date
        ldFecha = dfecha.AddDays(((-1) * Day(dfecha) + 1))
        Return ldFecha
    End Function
    Public Function fxEndDate(ByVal dfecha As Date) As Date
        Dim ldFecha As Date
        ldFecha = fxIniDate(dfecha).AddDays(31)
        ldFecha = ldFecha.AddDays(((-1) * Day(ldFecha)))

        Return ldFecha
    End Function
    Public Function CalculoCajaChica(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String, ByVal ccodenc As String) As DataSet
        Dim ecntamov As New cCntamov
        Dim ds As New DataSet
        ds = ecntamov.Obtenermovcajachica(dfecini, dfecfin, ccodofi, cfuente, ccodenc)
        Dim fila As DataRow
        Dim lnSalAct As Double = 0
        Dim lnSalAnt As Double = 0
        Dim lndebe As Double = 0
        Dim lctipo As String = ""
        For Each fila In ds.Tables(0).Rows
            lndebe = fila("ndebe")
            lctipo = Left(fila("cTipo"), 6)

            If lctipo = "305101" Then
            Else
                If lctipo = "101101" Then
                    lnSalAct = lnSalAnt + lndebe
                Else
                    lnSalAct = lnSalAnt - (lndebe)
                End If
                fila("nsaldo") = lnSalAct
                lnSalAnt = lnSalAct
            End If
        Next
        Return ds
    End Function
    Public Function LiquidaCajaChica(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As String
        Dim ds As New DataSet

        Dim ecntamov As New cCntamov
        Dim entidadcntamov As New cntamov
        Dim cClsAdP As New ClsAdPart


        Dim fila As DataRow

        Dim lcpartidas As String = ""
        Dim lnMontoTotal As Decimal = 0

        Dim oki As String


        ds = ecntamov.DataParaLiquidarCajaChica(dfecini, dfecfin, ccodofi)



        If ds.Tables(0).Rows.Count > 0 Then
            ecntamov.ActualizaNOLiquidadoCC(dfecini, dfecfin, ccodofi)

            cClsAdP._nCuenta = 1


            For Each fila In ds.Tables(0).Rows

                'Graba Partida contable en la parte del debe

                cClsAdP._dfecmod = Me.dfecha + " " + Now.TimeOfDay.ToString
                cClsAdP._ccodusu = Me._pcCodusu
                cClsAdP._ccodofi = "001"
                cClsAdP._cconcepto = "LIQUIDACION DE CAJA CHICA DEL " + dfecini + " al " + dfecfin + " of. " + ccodofi
                cClsAdP._dfeccnt = Me.dfecha
                cClsAdP._cpoliza = "CC"
                cClsAdP._cnumdoc = Me.cfactura

                cClsAdP._llbandera = True
                cClsAdP._ccodpres = ""
                cClsAdP._ffondos = "99"
                cClsAdP._cnumrec = ""
                cClsAdP._pccodcli = ""
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString

                cClsAdP._ccodcta = fila("ccodcta")
                cClsAdP._ndebe = fila("monto")
                cClsAdP._nhaber = 0
                cClsAdP._cclase = Left(fila("ccodcta"), 1)


                oki = cClsAdP.AdPartida()

                cClsAdP._nCuenta += 1

                lnMontoTotal += fila("monto")

            Next

            'GRABA LA PARTE DEL HABER DEL LA PARTIDA

            cClsAdP._dfecmod = Me.dfecha + " " + Now.TimeOfDay.ToString
            cClsAdP._ccodusu = Me._pcCodusu
            cClsAdP._ccodofi = "001"
            cClsAdP._cconcepto = "LIQUIDACION DE CAJA CHICA DEL " + dfecini + " al " + dfecfin + " of. " + ccodofi
            cClsAdP._dfeccnt = Me.dfecha
            cClsAdP._cpoliza = "CC"
            cClsAdP._cnumdoc = Me.cfactura

            cClsAdP._llbandera = True
            cClsAdP._ccodpres = ""
            cClsAdP._ffondos = "99"
            cClsAdP._cnumrec = ""
            cClsAdP._pccodcli = ""
            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString

            cClsAdP._ccodcta = Me.cctabco
            cClsAdP._ndebe = 0
            cClsAdP._nhaber = lnMontoTotal
            cClsAdP._cclase = Left(Me.cctabco, 1)


            oki = cClsAdP.AdPartida()

            ecntamov.ActualizaLiquidadoCC(oki, dfecini, dfecfin, ccodofi)

            'Partidas Generadas
            lcpartidas = oki

            'GENERA REINTEGRO AUTOMATICO POR EL MONTO TOTAL DE LO GASTADO CAMBIO SOLICITADO POR CONTABILIDAD 15/06/2012

            entidadcntamov.cnit = "3832181-5"
            entidadcntamov.cproveedor = "3832181-5"
            entidadcntamov.cdescri = "REINTEGRO DE CAJA CHICA"
            entidadcntamov.dfecha = dfecfin.AddDays(1)
            entidadcntamov.ctipo = "1011010401" + ccodofi.Substring(1, 2)
            entidadcntamov.cfactura = "REINTEGRO"
            entidadcntamov.ndebe = lnMontoTotal
            entidadcntamov.nsaldo = 0
            entidadcntamov.cflag = " "
            entidadcntamov.ccodant = " "
            entidadcntamov.laplcon = False
            entidadcntamov.cctabco = Me.cctabco
            entidadcntamov.ccodofi = ccodofi
            entidadcntamov.ccodins = "001"
            entidadcntamov.ccodenc = Me._pcCodusu
            entidadcntamov.nmonfac = lnMontoTotal
            entidadcntamov.niva = 0
            entidadcntamov.nisr = 0
            entidadcntamov.cnumcom = ""
            entidadcntamov.cfuente = "99"
            entidadcntamov.dfecmod = Now
            entidadcntamov.ccodbco = ""
            entidadcntamov.cestado = " "
            entidadcntamov.ctipope = "R"
            entidadcntamov.ccodres = Me._pcCodusu
            entidadcntamov.cauxcta = "0"

            ecntamov.AgregarAuxiliarCaja(entidadcntamov)

            '--------------------------------------------------------------


        Else
            lcpartidas = "0"
        End If

        Return lcpartidas

    End Function
    Public Function ActualizaCicloCremcre(ByVal ccodcta As String) As Integer
        Dim command As New SqlCommand
        Dim lnciclo As Integer
        Dim ccodcli As String = ""
        Dim ecreditos As New ccreditos
        Dim entidadcreditos As New creditos
        entidadcreditos.ccodcta = ccodcta
        ecreditos.Obtenercreditos(entidadcreditos)
        ccodcli = entidadcreditos.ccodcli

        lnciclo = ecreditos.fxCiclo(ccodcli, ccodcta)

        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try

                command.Connection = conneccion
                command.CommandText = "UPDATE CREMCRE SET nciclo ='" & lnciclo & "' where ccodcta ='" & ccodcta & "'"
                command.ExecuteNonQuery()
                lnretorno = 1
            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using
        Return lnretorno
    End Function

    Public Function PeriodoBase(ByVal year As Integer) As Integer
        Dim pnperbas As Integer
        If (year - (Int(year / 400) * 400)) = 0 Or ((year - (Int(year / 4) * 4)) = 0 And (year - (Int(year / 100) * 100)) <> 0) Then
            pnperbas = 366
        Else
            pnperbas = 365
        End If
        Return pnperbas
    End Function

    Public Function ValidaDUI(ByVal chrDUI As String) As Boolean


        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim valor3 As Integer
        Dim valor4 As Integer
        Dim valor5 As Integer
        Dim valor6 As Integer
        Dim valor7 As Integer
        Dim valor8 As Integer
        Dim vdigito As Integer
        Try
            'Primero verificamos que traiga el guion en la penultima posicion
            If chrDUI.Substring(8, 1) = "-" Then
            Else
                Return False
            End If

            '------------------------------
            Dim v_sumaN As Integer
            Dim vDUIResto As Integer
            Dim vResiduo As Integer
            ' -------------------------------
            valor1 = (chrDUI.Substring(0, 1) * 9)
            valor2 = (chrDUI.Substring(1, 1) * 8)
            valor3 = (chrDUI.Substring(2, 1) * 7)
            valor4 = (chrDUI.Substring(3, 1) * 6)
            valor5 = (chrDUI.Substring(4, 1) * 5)
            valor6 = (chrDUI.Substring(5, 1) * 4)
            valor7 = (chrDUI.Substring(6, 1) * 3)
            valor8 = (chrDUI.Substring(7, 1) * 2)
            '-------------------------------
            v_sumaN = (valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8)
            vResiduo = v_sumaN Mod 10
            '------------------------------
            If vResiduo = 10 Or vResiduo = 0 Then
                vDUIResto = 0
            Else
                vDUIResto = (10 - vResiduo)
            End If
            '-------------------------------
            If vDUIResto <> (chrDUI.Substring(9, 1)) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function fxReducePay(ByVal pnmonpag As Double, ByVal pndeuda As Double) As Decimal
        Dim lnvalor As Decimal = 0
        If pndeuda >= pnmonpag Then
            lnvalor = pnmonpag
        Else
            lnvalor = pndeuda
        End If

        Return lnvalor
    End Function

    'colocar en el archivo clsprincipal

    'Public Function zeros_Derecha(ByVal valor As String, ByVal nlong As Integer) As String
    '    Dim tamano As Integer
    '    Dim lcvalor As String
    '    lcvalor = valor.Trim
    '    Dim i As Integer
    '    tamano = valor.Trim.Length
    '    If tamano >= nlong Then
    '        lcvalor = Left(valor.Trim, nlong)
    '    Else
    '        For i = 1 To nlong - tamano
    '            lcvalor = lcvalor & "0"
    '        Next
    '    End If

    '    Return lcvalor
    'End Function

End Class


