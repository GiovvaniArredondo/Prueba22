Public Class gestion
    Inherits entidadBase
#Region " Privadas "
    Private _dfecges As DateTime
 
    Private _time_in As String
 
    Private _time_out As String
 
    Private _dfecpag As DateTime
 
    Private _gestion As String
 
    Private _resultados As String
 
    Private _observa As String
 
    Private _ccodcli As String
 
    Private _ccodcta As String
 
    Private _cflag As String
 
    Private _ccodusu As String
 
    Private _ccodana As String
 
    Private _dias_mora As Decimal

    Private _idgestion As String

    Private _cfrecpag As String

    Private _nmonconv As Decimal

#End Region
 
#Region " Propiedades "
    Public Property dfecges() As DateTime
        Get
            Return _dfecges
        End Get
        Set(ByVal Value As DateTime)
            _dfecges = Value
        End Set
    End Property 
 
    Public Property time_in() As String
        Get
            Return _time_in
        End Get
        Set(ByVal Value As String)
            _time_in = Value
        End Set
    End Property 
 
    Public Property time_out() As String
        Get
            Return _time_out
        End Get
        Set(ByVal Value As String)
            _time_out = Value
        End Set
    End Property 
 
    Public Property dfecpag() As DateTime
        Get
            Return _dfecpag
        End Get
        Set(ByVal Value As DateTime)
            _dfecpag = Value
        End Set
    End Property 
 
    Public Property gestion() As String
        Get
            Return _gestion
        End Get
        Set(ByVal Value As String)
            _gestion = Value
        End Set
    End Property 
 
    Public Property resultados() As String
        Get
            Return _resultados
        End Get
        Set(ByVal Value As String)
            _resultados = Value
        End Set
    End Property 
 
    Public Property observa() As String
        Get
            Return _observa
        End Get
        Set(ByVal Value As String)
            _observa = Value
        End Set
    End Property 
 
    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
        End Set
    End Property 
 
    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property 
 
    Public Property cflag() As String
        Get
            Return _cflag
        End Get
        Set(ByVal Value As String)
            _cflag = Value
        End Set
    End Property 
 
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal Value As String)
            _ccodusu = Value
        End Set
    End Property 
 
    Public Property ccodana() As String
        Get
            Return _ccodana
        End Get
        Set(ByVal Value As String)
            _ccodana = Value
        End Set
    End Property 
 
    Public Property dias_mora() As Decimal
        Get
            Return _dias_mora
        End Get
        Set(ByVal Value As Decimal)
            _dias_mora = Value
        End Set
    End Property 

    Public Property idgestion() As String
        Get
            Return _idgestion
        End Get
        Set(ByVal Value As String)
            _idgestion = Value
        End Set
    End Property

    Public Property cfrecpag() As String
        Get
            Return _cfrecpag
        End Get
        Set(ByVal value As String)
            _cfrecpag = value
        End Set
    End Property
    Public Property nmonconv() As Decimal
        Get
            Return _nmonconv
        End Get
        Set(ByVal value As Decimal)
            _nmonconv = value
        End Set
    End Property
#End Region
End Class
