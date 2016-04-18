Public Class DEPMBEN
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcrt As String
 
    Private _ncorrel As Int32
 
    Private _cnomben As String
 
    Private _cparent As String
 
    Private _dfecnac As DateTime
 
    Private _nporcen As Int32
 
    Private _cdirben As String
 
    Private _ccodcli As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodcrt() As String
        Get
            Return _ccodcrt
        End Get
        Set(ByVal Value As String)
            _ccodcrt = Value
        End Set
    End Property 
 
    Public Property ncorrel() As Int32
        Get
            Return _ncorrel
        End Get
        Set(ByVal Value As Int32)
            _ncorrel = Value
        End Set
    End Property 
 
    Public Property cnomben() As String
        Get
            Return _cnomben
        End Get
        Set(ByVal Value As String)
            _cnomben = Value
        End Set
    End Property 
 
    Public Property cparent() As String
        Get
            Return _cparent
        End Get
        Set(ByVal Value As String)
            _cparent = Value
        End Set
    End Property 
 
    Public Property dfecnac() As DateTime
        Get
            Return _dfecnac
        End Get
        Set(ByVal Value As DateTime)
            _dfecnac = Value
        End Set
    End Property 
 
    Public Property nporcen() As Int32
        Get
            Return _nporcen
        End Get
        Set(ByVal Value As Int32)
            _nporcen = Value
        End Set
    End Property 
 
    Public Property cdirben() As String
        Get
            Return _cdirben
        End Get
        Set(ByVal Value As String)
            _cdirben = Value
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
 
#End Region
End Class
