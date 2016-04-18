Public Class cntabal
    Inherits entidadBase
#Region " Privadas "
    Private _cfecmes As String
 
    Private _ccodcta As String
 
    Private _nsalini As Decimal
 
    Private _ndebe As Decimal
 
    Private _nhaber As Decimal
 
    Private _nsalfin As Decimal
 
    Private _ndebeac As Decimal
 
    Private _nhaberac As Decimal
 
    Private _ctipmon As String
 
    Private _cnivel As String
 
    Private _ctipcta As String
 
    Private _cclase As String
 
    Private _ccodusu As String
 
    Private _ccodbal As String
 
    Private _cflc As String
 
    Private _nfln As Decimal
 
    Private _bs As String
 
    Private _ccodto As String
 
    Private _ccodofi As String
 
    Private _ffondos As String

    Private _cdescrip As String
#End Region
 
#Region " Propiedades "
    Public Property cfecmes() As String
        Get
            Return _cfecmes
        End Get
        Set(ByVal Value As String)
            _cfecmes = Value
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
 
    Public Property nsalini() As Decimal
        Get
            Return _nsalini
        End Get
        Set(ByVal Value As Decimal)
            _nsalini = Value
        End Set
    End Property 
 
    Public Property ndebe() As Decimal
        Get
            Return _ndebe
        End Get
        Set(ByVal Value As Decimal)
            _ndebe = Value
        End Set
    End Property 
 
    Public Property nhaber() As Decimal
        Get
            Return _nhaber
        End Get
        Set(ByVal Value As Decimal)
            _nhaber = Value
        End Set
    End Property 
 
    Public Property nsalfin() As Decimal
        Get
            Return _nsalfin
        End Get
        Set(ByVal Value As Decimal)
            _nsalfin = Value
        End Set
    End Property 
 
    Public Property ndebeac() As Decimal
        Get
            Return _ndebeac
        End Get
        Set(ByVal Value As Decimal)
            _ndebeac = Value
        End Set
    End Property 
 
    Public Property nhaberac() As Decimal
        Get
            Return _nhaberac
        End Get
        Set(ByVal Value As Decimal)
            _nhaberac = Value
        End Set
    End Property 
 
    Public Property ctipmon() As String
        Get
            Return _ctipmon
        End Get
        Set(ByVal Value As String)
            _ctipmon = Value
        End Set
    End Property 
 
    Public Property cnivel() As String
        Get
            Return _cnivel
        End Get
        Set(ByVal Value As String)
            _cnivel = Value
        End Set
    End Property 
 
    Public Property ctipcta() As String
        Get
            Return _ctipcta
        End Get
        Set(ByVal Value As String)
            _ctipcta = Value
        End Set
    End Property 
 
    Public Property cclase() As String
        Get
            Return _cclase
        End Get
        Set(ByVal Value As String)
            _cclase = Value
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
 
    Public Property ccodbal() As String
        Get
            Return _ccodbal
        End Get
        Set(ByVal Value As String)
            _ccodbal = Value
        End Set
    End Property 
 
    Public Property cflc() As String
        Get
            Return _cflc
        End Get
        Set(ByVal Value As String)
            _cflc = Value
        End Set
    End Property 
 
    Public Property nfln() As Decimal
        Get
            Return _nfln
        End Get
        Set(ByVal Value As Decimal)
            _nfln = Value
        End Set
    End Property 
 
    Public Property bs() As String
        Get
            Return _bs
        End Get
        Set(ByVal Value As String)
            _bs = Value
        End Set
    End Property 
 
    Public Property ccodto() As String
        Get
            Return _ccodto
        End Get
        Set(ByVal Value As String)
            _ccodto = Value
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
 
    Public Property ffondos() As String
        Get
            Return _ffondos
        End Get
        Set(ByVal Value As String)
            _ffondos = Value
        End Set
    End Property 

    Public Property cdescrip() As String
        Get
            Return _cdescrip
        End Get
        Set(ByVal Value As String)
            _cdescrip = Value
        End Set
    End Property
#End Region
End Class
