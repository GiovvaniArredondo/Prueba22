Public Class cancela
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _cnomcli As String
 
    Private _nsalcap As Decimal
 
    Private _ctabco As String
 
    Private _cnumchq As String
 
    Private _ntotal As Decimal
 
    Private _ccodcli As String
 
    Private _nsalint As Decimal
 
    Private _nsalmor As Decimal
 
    Private _nmanejo As Decimal
 
    Private _nseguro As Decimal
 
    Private _ccodlin As String
 
    Private _ccodpre As String

    Private _ccodref As String

    Private _niva As String
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
 
    Public Property cnomcli() As String
        Get
            Return _cnomcli
        End Get
        Set(ByVal Value As String)
            _cnomcli = Value
        End Set
    End Property 
 
    Public Property nsalcap() As Decimal
        Get
            Return _nsalcap
        End Get
        Set(ByVal Value As Decimal)
            _nsalcap = Value
        End Set
    End Property 
 
    Public Property ctabco() As String
        Get
            Return _ctabco
        End Get
        Set(ByVal Value As String)
            _ctabco = Value
        End Set
    End Property 
 
    Public Property cnumchq() As String
        Get
            Return _cnumchq
        End Get
        Set(ByVal Value As String)
            _cnumchq = Value
        End Set
    End Property 
 
    Public Property ntotal() As Decimal
        Get
            Return _ntotal
        End Get
        Set(ByVal Value As Decimal)
            _ntotal = Value
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
 
    Public Property nsalint() As Decimal
        Get
            Return _nsalint
        End Get
        Set(ByVal Value As Decimal)
            _nsalint = Value
        End Set
    End Property 
 
    Public Property nsalmor() As Decimal
        Get
            Return _nsalmor
        End Get
        Set(ByVal Value As Decimal)
            _nsalmor = Value
        End Set
    End Property 
 
    Public Property nmanejo() As Decimal
        Get
            Return _nmanejo
        End Get
        Set(ByVal Value As Decimal)
            _nmanejo = Value
        End Set
    End Property 
    Public Property niva() As Decimal
        Get
            Return _niva
        End Get
        Set(ByVal Value As Decimal)
            _niva = Value
        End Set
    End Property


    Public Property nseguro() As Decimal
        Get
            Return _nseguro
        End Get
        Set(ByVal Value As Decimal)
            _nseguro = Value
        End Set
    End Property 
 
    Public Property ccodlin() As String
        Get
            Return _ccodlin
        End Get
        Set(ByVal Value As String)
            _ccodlin = Value
        End Set
    End Property 
 
    Public Property ccodpre() As String
        Get
            Return _ccodpre
        End Get
        Set(ByVal Value As String)
            _ccodpre = Value
        End Set
    End Property 

    Public Property ccodref() As String
        Get
            Return _ccodref
        End Get
        Set(ByVal Value As String)
            _ccodref = Value
        End Set
    End Property
#End Region
End Class
