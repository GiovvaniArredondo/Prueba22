Public Class tabttab
    Inherits entidadBase
#Region " Privadas "
    Private _corden As String
 
    Private _ccodtab As String
 
    Private _ctipreg As String
 
    Private _ccodigo As String
 
    Private _cdescri As String
 
    Private _llogtab As Boolean
 
    Private _dfectab As DateTime
 
    Private _cstrtab As String
 
    Private _nnumtab As Decimal
 
    Private _maditab As String
 
    Private _lmodifi As Boolean
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _nflag As Decimal
 
    Private _coordinado As String
 
    Private _ccodcta As String
 
    Private _ccodana As String
 
    Private _IdCodigo As String

    Private _cdescri_ As String
#End Region
 
#Region " Propiedades "
    Public Property corden() As String
        Get
            Return _corden
        End Get
        Set(ByVal Value As String)
            _corden = Value
        End Set
    End Property 
 
    Public Property ccodtab() As String
        Get
            Return _ccodtab
        End Get
        Set(ByVal Value As String)
            _ccodtab = Value
        End Set
    End Property 
 
    Public Property ctipreg() As String
        Get
            Return _ctipreg
        End Get
        Set(ByVal Value As String)
            _ctipreg = Value
        End Set
    End Property 
 
    Public Property ccodigo() As String
        Get
            Return _ccodigo
        End Get
        Set(ByVal Value As String)
            _ccodigo = Value
        End Set
    End Property 
 
    Public Property cdescri() As String
        Get
            Return _cdescri
        End Get
        Set(ByVal Value As String)
            _cdescri = Value
        End Set
    End Property

    Public Property cdescri_() As String
        Get
            Return _cdescri_
        End Get
        Set(ByVal Value As String)
            _cdescri_ = Value
        End Set
    End Property
 
    Public Property llogtab() As Boolean
        Get
            Return _llogtab
        End Get
        Set(ByVal Value As Boolean)
            _llogtab = Value
        End Set
    End Property 
 
    Public Property dfectab() As DateTime
        Get
            Return _dfectab
        End Get
        Set(ByVal Value As DateTime)
            _dfectab = Value
        End Set
    End Property 
 
    Public Property cstrtab() As String
        Get
            Return _cstrtab
        End Get
        Set(ByVal Value As String)
            _cstrtab = Value
        End Set
    End Property 
 
    Public Property nnumtab() As Decimal
        Get
            Return _nnumtab
        End Get
        Set(ByVal Value As Decimal)
            _nnumtab = Value
        End Set
    End Property 
 
    Public Property maditab() As String
        Get
            Return _maditab
        End Get
        Set(ByVal Value As String)
            _maditab = Value
        End Set
    End Property 
 
    Public Property lmodifi() As Boolean
        Get
            Return _lmodifi
        End Get
        Set(ByVal Value As Boolean)
            _lmodifi = Value
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
 
    Public Property nflag() As Decimal
        Get
            Return _nflag
        End Get
        Set(ByVal Value As Decimal)
            _nflag = Value
        End Set
    End Property 
 
    Public Property coordinado() As String
        Get
            Return _coordinado
        End Get
        Set(ByVal Value As String)
            _coordinado = Value
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
 
    Public Property ccodana() As String
        Get
            Return _ccodana
        End Get
        Set(ByVal Value As String)
            _ccodana = Value
        End Set
    End Property 
 
    Public Property IdCodigo() As String
        Get
            Return _IdCodigo
        End Get
        Set(ByVal Value As String)
            _IdCodigo = Value
        End Set
    End Property 
 
#End Region

End Class
