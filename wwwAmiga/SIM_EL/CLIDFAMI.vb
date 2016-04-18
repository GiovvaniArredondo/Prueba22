Public Class CLIDFAMI
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _dEvalua As Date
 
    Private _nIngCony As Decimal
 
    Private _nIngFami As Decimal
 
    Private _nIngSSPC As Decimal
 
    Private _nIngReme As Decimal
 
    Private _nIngVari As Decimal
 
    Private _nGasCasa As Decimal
 
    Private _nGasAlim As Decimal
 
    Private _nGasAlte As Decimal
 
    Private _ngasTran As Decimal
 
    Private _nGasEduc As Decimal
 
    Private _nGasSalu As Decimal
 
    Private _nGasRopa As Decimal
 
    Private _nGasPres As Decimal
 
    Private _cCodusu As String

    Private _cCodUni As String
 
    Private _dFecMod As DateTime

 
#End Region
 
#Region " Propiedades "
    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property 
 
    Public Property dEvalua() As Date
        Get
            Return _dEvalua
        End Get
        Set(ByVal Value As Date)
            _dEvalua = Value
        End Set
    End Property

    Public Property nIngCony() As Decimal
        Get
            Return _nIngCony
        End Get
        Set(ByVal Value As Decimal)
            _nIngCony = Value
        End Set
    End Property

    Public Property nIngFami() As Decimal
        Get
            Return _nIngFami
        End Get
        Set(ByVal Value As Decimal)
            _nIngFami = Value
        End Set
    End Property

    Public Property nIngSSPC() As Decimal
        Get
            Return _nIngSSPC
        End Get
        Set(ByVal Value As Decimal)
            _nIngSSPC = Value
        End Set
    End Property

    Public Property nIngReme() As Decimal
        Get
            Return _nIngReme
        End Get
        Set(ByVal Value As Decimal)
            _nIngReme = Value
        End Set
    End Property

    Public Property nIngVari() As Decimal
        Get
            Return _nIngVari
        End Get
        Set(ByVal Value As Decimal)
            _nIngVari = Value
        End Set
    End Property

    Public Property nGasCasa() As Decimal
        Get
            Return _nGasCasa
        End Get
        Set(ByVal Value As Decimal)
            _nGasCasa = Value
        End Set
    End Property

    Public Property nGasAlim() As Decimal
        Get
            Return _nGasAlim
        End Get
        Set(ByVal Value As Decimal)
            _nGasAlim = Value
        End Set
    End Property

    Public Property nGasAlte() As Decimal
        Get
            Return _nGasAlte
        End Get
        Set(ByVal Value As Decimal)
            _nGasAlte = Value
        End Set
    End Property

    Public Property ngasTran() As Decimal
        Get
            Return _ngasTran
        End Get
        Set(ByVal Value As Decimal)
            _ngasTran = Value
        End Set
    End Property

    Public Property nGasEduc() As Decimal
        Get
            Return _nGasEduc
        End Get
        Set(ByVal Value As Decimal)
            _nGasEduc = Value
        End Set
    End Property

    Public Property nGasSalu() As Decimal
        Get
            Return _nGasSalu
        End Get
        Set(ByVal Value As Decimal)
            _nGasSalu = Value
        End Set
    End Property

    Public Property nGasRopa() As Decimal
        Get
            Return _nGasRopa
        End Get
        Set(ByVal Value As Decimal)
            _nGasRopa = Value
        End Set
    End Property

    Public Property nGasPres() As Decimal
        Get
            Return _nGasPres
        End Get
        Set(ByVal Value As Decimal)
            _nGasPres = Value
        End Set
    End Property

    Public Property cCodusu() As String
        Get
            Return _cCodusu
        End Get
        Set(ByVal Value As String)
            _cCodusu = Value
        End Set
    End Property
    Public Property cCodUni() As String
        Get
            Return _cCodUni
        End Get
        Set(ByVal Value As String)
            _cCodUni = Value
        End Set
    End Property

    Public Property dFecMod() As DateTime
        Get
            Return _dFecMod
        End Get
        Set(ByVal Value As DateTime)
            _dFecMod = Value
        End Set
    End Property

#End Region
End Class
