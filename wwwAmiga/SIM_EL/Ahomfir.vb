Public Class Ahomfir
    Inherits entidadBase
#Region " Privadas "
    Private _ccodaho As String
 
    Private _nlibreta As Int32
 
    Private _nmanco As Int32
 
    Private _cnomau As String
 
    Private _cnomgfir As String
 
    Private _cnomgfir2 As String
 
    Private _cnomgfir3 As String
 
    Private _dnacgfir As DateTime
 
    Private _dnacgfir2 As DateTime
 
    Private _dnacgfir3 As DateTime
 
    Private _cdui1 As String
 
    Private _cdui2 As String
 
    Private _cdui3 As String
 
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
 
    Public Property nlibreta() As Int32
        Get
            Return _nlibreta
        End Get
        Set(ByVal Value As Int32)
            _nlibreta = Value
        End Set
    End Property 
 
    Public Property nmanco() As Int32
        Get
            Return _nmanco
        End Get
        Set(ByVal Value As Int32)
            _nmanco = Value
        End Set
    End Property 
 
    Public Property cnomau() As String
        Get
            Return _cnomau
        End Get
        Set(ByVal Value As String)
            _cnomau = Value
        End Set
    End Property 
 
    Public Property cnomgfir() As String
        Get
            Return _cnomgfir
        End Get
        Set(ByVal Value As String)
            _cnomgfir = Value
        End Set
    End Property 
 
    Public Property cnomgfir2() As String
        Get
            Return _cnomgfir2
        End Get
        Set(ByVal Value As String)
            _cnomgfir2 = Value
        End Set
    End Property 
 
    Public Property cnomgfir3() As String
        Get
            Return _cnomgfir3
        End Get
        Set(ByVal Value As String)
            _cnomgfir3 = Value
        End Set
    End Property 
 
    Public Property dnacgfir() As DateTime
        Get
            Return _dnacgfir
        End Get
        Set(ByVal Value As DateTime)
            _dnacgfir = Value
        End Set
    End Property 
 
    Public Property dnacgfir2() As DateTime
        Get
            Return _dnacgfir2
        End Get
        Set(ByVal Value As DateTime)
            _dnacgfir2 = Value
        End Set
    End Property 
 
    Public Property dnacgfir3() As DateTime
        Get
            Return _dnacgfir3
        End Get
        Set(ByVal Value As DateTime)
            _dnacgfir3 = Value
        End Set
    End Property 
 
    Public Property cdui1() As String
        Get
            Return _cdui1
        End Get
        Set(ByVal Value As String)
            _cdui1 = Value
        End Set
    End Property 
 
    Public Property cdui2() As String
        Get
            Return _cdui2
        End Get
        Set(ByVal Value As String)
            _cdui2 = Value
        End Set
    End Property 
 
    Public Property cdui3() As String
        Get
            Return _cdui3
        End Get
        Set(ByVal Value As String)
            _cdui3 = Value
        End Set
    End Property 
 
#End Region
End Class
