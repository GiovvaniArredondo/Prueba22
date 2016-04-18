Public Class clipcta
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodcta As String
 
    Private _ctiprel As String
 
    Private _cestrel As String
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
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
 
    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property 
 
    Public Property ctiprel() As String
        Get
            Return _ctiprel
        End Get
        Set(ByVal Value As String)
            _ctiprel = Value
        End Set
    End Property 
 
    Public Property cestrel() As String
        Get
            Return _cestrel
        End Get
        Set(ByVal Value As String)
            _cestrel = Value
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
 
    Public Property dfecmod() As DateTime
        Get
            Return _dfecmod
        End Get
        Set(ByVal Value As DateTime)
            _dfecmod = Value
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
 
#End Region
End Class
