Public Class autopag
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _ccodcli As String
 
    Private _cnomcli As String
 
    Private _dfecpag As DateTime
 
    Private _nmonto As Decimal
 
    Private _ccodofi As String
 
    Private _cflag As String
 
    Private _cmotivo As String
 
    Private _cflat As String
 
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
 
    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
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
 
    Public Property nmonto() As Decimal
        Get
            Return _nmonto
        End Get
        Set(ByVal Value As Decimal)
            _nmonto = Value
        End Set
    End Property 
 
    Public Property ccodofi() As String
        Get
            Return _ccodofi
        End Get
        Set(ByVal Value As String)
            _ccodofi = Value
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
 
    Public Property cmotivo() As String
        Get
            Return _cmotivo
        End Get
        Set(ByVal Value As String)
            _cmotivo = Value
        End Set
    End Property 
 
    Public Property cflat() As String
        Get
            Return _cflat
        End Get
        Set(ByVal Value As String)
            _cflat = Value
        End Set
    End Property 
 
#End Region
End Class
