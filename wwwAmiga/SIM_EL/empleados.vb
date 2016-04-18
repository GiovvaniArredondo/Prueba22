Public Class empleados
    Inherits entidadBase
#Region " Privadas "
    Private _id As String
 
    Private _cnomemp As String
 
    Private _cdui As String
 
    Private _ccargo As String
 
    Private _cdepto As String
 
    Private _cafp As String
 
    Private _nsalario As Decimal

    Private _ncomision As Decimal

    Private _nbonificacion As Decimal

    Private _notros As Decimal

    Private _ncelular As Decimal
#End Region
 
#Region " Propiedades "
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal Value As String)
            _id = Value
        End Set
    End Property 
 
    Public Property cnomemp() As String
        Get
            Return _cnomemp
        End Get
        Set(ByVal Value As String)
            _cnomemp = Value
        End Set
    End Property 
 
    Public Property cdui() As String
        Get
            Return _cdui
        End Get
        Set(ByVal Value As String)
            _cdui = Value
        End Set
    End Property 
 
    Public Property ccargo() As String
        Get
            Return _ccargo
        End Get
        Set(ByVal Value As String)
            _ccargo = Value
        End Set
    End Property 
 
    Public Property cdepto() As String
        Get
            Return _cdepto
        End Get
        Set(ByVal Value As String)
            _cdepto = Value
        End Set
    End Property 
 
    Public Property cafp() As String
        Get
            Return _cafp
        End Get
        Set(ByVal Value As String)
            _cafp = Value
        End Set
    End Property 
 
    Public Property nsalario() As Decimal
        Get
            Return _nsalario
        End Get
        Set(ByVal Value As Decimal)
            _nsalario = Value
        End Set
    End Property 

    Public Property ncomision() As Decimal
        Get
            Return _ncomision
        End Get
        Set(ByVal Value As Decimal)
            _ncomision = Value
        End Set
    End Property

    Public Property nbonificacion() As Decimal
        Get
            Return _nbonificacion
        End Get
        Set(ByVal Value As Decimal)
            _nbonificacion = Value
        End Set
    End Property

    Public Property notros() As Decimal
        Get
            Return _notros
        End Get
        Set(ByVal Value As Decimal)
            _notros = Value
        End Set
    End Property

    Public Property ncelular() As Decimal
        Get
            Return _ncelular
        End Get
        Set(ByVal Value As Decimal)
            _ncelular = Value
        End Set
    End Property
#End Region
End Class
