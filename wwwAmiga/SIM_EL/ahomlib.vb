Public Class ahomlib
    Inherits entidadBase
#Region " Privadas "
    Private _ccodaho As String
 
    Private _nlibreta As Decimal
 
    Private _cestado As String
 
    Private _dfeccan As DateTime
 
    Private _crazon As String
 
    Private _dfecapr As DateTime
 
    Private _dfecmod As DateTime
 
    Private _ccodusu As String
 
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
 
    Public Property nlibreta() As Decimal
        Get
            Return _nlibreta
        End Get
        Set(ByVal Value As Decimal)
            _nlibreta = Value
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
 
    Public Property dfeccan() As DateTime
        Get
            Return _dfeccan
        End Get
        Set(ByVal Value As DateTime)
            _dfeccan = Value
        End Set
    End Property 
 
    Public Property crazon() As String
        Get
            Return _crazon
        End Get
        Set(ByVal Value As String)
            _crazon = Value
        End Set
    End Property 
 
    Public Property dfecapr() As DateTime
        Get
            Return _dfecapr
        End Get
        Set(ByVal Value As DateTime)
            _dfecapr = Value
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
 
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal Value As String)
            _ccodusu = Value
        End Set
    End Property 
 
#End Region
End Class
