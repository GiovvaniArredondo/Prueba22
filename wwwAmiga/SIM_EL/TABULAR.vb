Public Class TABULAR
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodenc As String
 
    Private _ccodpreg As String
 
    Private _ccodres As String
 
    Private _ccodusu As String
 
    Private _dfecha As DateTime

    Private _nvalor As Decimal
 
#End Region
 
#Region " Propiedades "
    Public Property nvalor() As String
        Get
            Return _nvalor
        End Get
        Set(ByVal Value As String)
            _nvalor = Value
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
 
    Public Property ccodenc() As String
        Get
            Return _ccodenc
        End Get
        Set(ByVal Value As String)
            _ccodenc = Value
        End Set
    End Property 
 
    Public Property ccodpreg() As String
        Get
            Return _ccodpreg
        End Get
        Set(ByVal Value As String)
            _ccodpreg = Value
        End Set
    End Property 
 
    Public Property ccodres() As String
        Get
            Return _ccodres
        End Get
        Set(ByVal Value As String)
            _ccodres = Value
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
 
    Public Property dfecha() As DateTime
        Get
            Return _dfecha
        End Get
        Set(ByVal Value As DateTime)
            _dfecha = Value
        End Set
    End Property 
 
#End Region
End Class
