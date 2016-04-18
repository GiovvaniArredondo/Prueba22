Public Class credgas
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _cusugen As String
 
    Private _dfecgen As DateTime
 
    Private _dfecpag As DateTime
 
    Private _ctipgas As String
 
    Private _cestado As String
 
    Private _nmongas As Decimal
    Private _ngasori As Decimal
 
    Private _nmonpag As Decimal
 
    Private _cnrocuo As String
 
    Private _cdescob As String
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
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
 
    Public Property cusugen() As String
        Get
            Return _cusugen
        End Get
        Set(ByVal Value As String)
            _cusugen = Value
        End Set
    End Property 
 
    Public Property dfecgen() As DateTime
        Get
            Return _dfecgen
        End Get
        Set(ByVal Value As DateTime)
            _dfecgen = Value
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
 
    Public Property ctipgas() As String
        Get
            Return _ctipgas
        End Get
        Set(ByVal Value As String)
            _ctipgas = Value
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
 
    Public Property nmongas() As Decimal
        Get
            Return _nmongas
        End Get
        Set(ByVal Value As Decimal)
            _nmongas = Value
        End Set
    End Property 
    Public Property ngasori() As Decimal
        Get
            Return _ngasori
        End Get
        Set(ByVal Value As Decimal)
            _ngasori = Value
        End Set
    End Property
    Public Property nmonpag() As Decimal
        Get
            Return _nmonpag
        End Get
        Set(ByVal Value As Decimal)
            _nmonpag = Value
        End Set
    End Property 
 
    Public Property cnrocuo() As String
        Get
            Return _cnrocuo
        End Get
        Set(ByVal Value As String)
            _cnrocuo = Value
        End Set
    End Property 
 
    Public Property cdescob() As String
        Get
            Return _cdescob
        End Get
        Set(ByVal Value As String)
            _cdescob = Value
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
