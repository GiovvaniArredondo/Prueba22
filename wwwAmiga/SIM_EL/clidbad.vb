Public Class clidbad
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodfue As String
 
    Private _devalua As DateTime
 
    Private _nsueldo As Decimal
 
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
 
    Public Property ccodfue() As String
        Get
            Return _ccodfue
        End Get
        Set(ByVal Value As String)
            _ccodfue = Value
        End Set
    End Property 
 
    Public Property devalua() As DateTime
        Get
            Return _devalua
        End Get
        Set(ByVal Value As DateTime)
            _devalua = Value
        End Set
    End Property 
 
    Public Property nsueldo() As Decimal
        Get
            Return _nsueldo
        End Get
        Set(ByVal Value As Decimal)
            _nsueldo = Value
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
