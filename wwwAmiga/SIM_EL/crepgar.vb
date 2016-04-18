Public Class crepgar
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _ccodcli As String
 
    Private _ccodgar As String
 
    Private _cmoneda As String
 
    Private _nmongra As Decimal
 
    Private _cestado As String
 
    Private _cnumins As String
 
    Private _dfecval As DateTime
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String

    Private _ctipgar As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
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
 
    Public Property ccodgar() As String
        Get
            Return _ccodgar
        End Get
        Set(ByVal Value As String)
            _ccodgar = Value
        End Set
    End Property 
 
    Public Property cmoneda() As String
        Get
            Return _cmoneda
        End Get
        Set(ByVal Value As String)
            _cmoneda = Value
        End Set
    End Property 
 
    Public Property nmongra() As Decimal
        Get
            Return _nmongra
        End Get
        Set(ByVal Value As Decimal)
            _nmongra = Value
        End Set
    End Property 
 
    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal Value As String)
            _cestado = Value
        End Set
    End Property 
 
    Public Property cnumins() As String
        Get
            Return _cnumins
        End Get
        Set(ByVal Value As String)
            _cnumins = Value
        End Set
    End Property 
 
    Public Property dfecval() As DateTime
        Get
            Return _dfecval
        End Get
        Set(ByVal Value As DateTime)
            _dfecval = Value
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

    Public Property ctipgar() As String
        Get
            Return _ctipgar
        End Get
        Set(ByVal Value As String)
            _ctipgar = Value
        End Set
    End Property
#End Region
End Class
