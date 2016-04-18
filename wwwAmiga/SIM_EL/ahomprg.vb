Public Class ahomprg
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _cnomcli As String
 
    Private _cta_fuente As String
 
    Private _cta_destin As String
 
    Private _fec_hoy As DateTime
 
    Private _fec_aplica As DateTime
 
    Private _cantidad As Decimal
 
    Private _ccodusu As String
 
    Private _estado As String
 
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
 
    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
        End Set
    End Property 
 
    Public Property cta_fuente() As String
        Get
            Return _cta_fuente
        End Get
        Set(ByVal Value As String)
            _cta_fuente = Value
        End Set
    End Property 
 
    Public Property cta_destin() As String
        Get
            Return _cta_destin
        End Get
        Set(ByVal Value As String)
            _cta_destin = Value
        End Set
    End Property 
 
    Public Property fec_hoy() As DateTime
        Get
            Return _fec_hoy
        End Get
        Set(ByVal Value As DateTime)
            _fec_hoy = Value
        End Set
    End Property 
 
    Public Property fec_aplica() As DateTime
        Get
            Return _fec_aplica
        End Get
        Set(ByVal Value As DateTime)
            _fec_aplica = Value
        End Set
    End Property 
 
    Public Property cantidad() As Decimal
        Get
            Return _cantidad
        End Get
        Set(ByVal Value As Decimal)
            _cantidad = Value
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
 
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal Value As String)
            _estado = Value
        End Set
    End Property 
 
#End Region
End Class
