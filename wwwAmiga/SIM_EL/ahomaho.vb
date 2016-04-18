Public Class ahomaho
    Inherits entidadBase
#Region " Privadas "
    Private _ccodaho As String
 
    Private _cnudotr As String
 
    Private _dfeccap As DateTime
 
    Private _ntasint As Decimal
 
    Private _nsaldoaho As Decimal
 
    Private _ccodlin As String
 
    Private _cdeslin As String
 
    Private _producto As String
 
    Private _nintere As Decimal
 
    Private _cnomcli As String
 
    Private _nsaldoant As Decimal
 
#End Region
 
#Region " Propiedades "
    Public Property ccodaho() As String
        Get
            Return _ccodaho
        End Get
        Set(ByVal Value As String)
            _ccodaho = Value
        End Set
    End Property 
 
    Public Property cnudotr() As String
        Get
            Return _cnudotr
        End Get
        Set(ByVal Value As String)
            _cnudotr = Value
        End Set
    End Property 
 
    Public Property dfeccap() As DateTime
        Get
            Return _dfeccap
        End Get
        Set(ByVal Value As DateTime)
            _dfeccap = Value
        End Set
    End Property 
 
    Public Property ntasint() As Decimal
        Get
            Return _ntasint
        End Get
        Set(ByVal Value As Decimal)
            _ntasint = Value
        End Set
    End Property 
 
    Public Property nsaldoaho() As Decimal
        Get
            Return _nsaldoaho
        End Get
        Set(ByVal Value As Decimal)
            _nsaldoaho = Value
        End Set
    End Property 
 
    Public Property ccodlin() As String
        Get
            Return _ccodlin
        End Get
        Set(ByVal Value As String)
            _ccodlin = Value
        End Set
    End Property 
 
    Public Property cdeslin() As String
        Get
            Return _cdeslin
        End Get
        Set(ByVal Value As String)
            _cdeslin = Value
        End Set
    End Property 
 
    Public Property producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal Value As String)
            _producto = Value
        End Set
    End Property 
 
    Public Property nintere() As Decimal
        Get
            Return _nintere
        End Get
        Set(ByVal Value As Decimal)
            _nintere = Value
        End Set
    End Property 
 
    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
        End Set
    End Property 
 
    Public Property nsaldoant() As Decimal
        Get
            Return _nsaldoant
        End Get
        Set(ByVal Value As Decimal)
            _nsaldoant = Value
        End Set
    End Property 
 
#End Region
End Class
