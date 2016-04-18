Public Class clidbal
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodfue As String
 
    Private _devalua As DateTime
 
    Private _dbalanc As DateTime
 
    Private _nactdis As Decimal
 
    Private _nctacob As Decimal
 
    Private _ninvent As Decimal
 
    Private _nactfij As Decimal
 
    Private _nprovee As Decimal
 
    Private _notrpre As Decimal
 
    Private _ncreins As Decimal
 
    Private _nventas As Decimal
 
    Private _nrecupe As Decimal
 
    Private _nmercad As Decimal
 
    Private _notregr As Decimal
 
    Private _nemplea As Decimal
 
    Private _nsueldo As Decimal
 
    Private _npagpres As Decimal
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _notring As Decimal
 
    Private _nimpues As Decimal
 
    Private _nimprev As Decimal
 
    Private _notract As Decimal

    Private _nmarseg As Decimal
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
 
    Public Property dbalanc() As DateTime
        Get
            Return _dbalanc
        End Get
        Set(ByVal Value As DateTime)
            _dbalanc = Value
        End Set
    End Property 
 
    Public Property nactdis() As Decimal
        Get
            Return _nactdis
        End Get
        Set(ByVal Value As Decimal)
            _nactdis = Value
        End Set
    End Property 
 
    Public Property nctacob() As Decimal
        Get
            Return _nctacob
        End Get
        Set(ByVal Value As Decimal)
            _nctacob = Value
        End Set
    End Property 
 
    Public Property ninvent() As Decimal
        Get
            Return _ninvent
        End Get
        Set(ByVal Value As Decimal)
            _ninvent = Value
        End Set
    End Property 
 
    Public Property nactfij() As Decimal
        Get
            Return _nactfij
        End Get
        Set(ByVal Value As Decimal)
            _nactfij = Value
        End Set
    End Property 
 
    Public Property nprovee() As Decimal
        Get
            Return _nprovee
        End Get
        Set(ByVal Value As Decimal)
            _nprovee = Value
        End Set
    End Property 
 
    Public Property notrpre() As Decimal
        Get
            Return _notrpre
        End Get
        Set(ByVal Value As Decimal)
            _notrpre = Value
        End Set
    End Property 
 
    Public Property ncreins() As Decimal
        Get
            Return _ncreins
        End Get
        Set(ByVal Value As Decimal)
            _ncreins = Value
        End Set
    End Property 
 
    Public Property nventas() As Decimal
        Get
            Return _nventas
        End Get
        Set(ByVal Value As Decimal)
            _nventas = Value
        End Set
    End Property 
 
    Public Property nrecupe() As Decimal
        Get
            Return _nrecupe
        End Get
        Set(ByVal Value As Decimal)
            _nrecupe = Value
        End Set
    End Property 
 
    Public Property nmercad() As Decimal
        Get
            Return _nmercad
        End Get
        Set(ByVal Value As Decimal)
            _nmercad = Value
        End Set
    End Property 
 
    Public Property notregr() As Decimal
        Get
            Return _notregr
        End Get
        Set(ByVal Value As Decimal)
            _notregr = Value
        End Set
    End Property 
 
    Public Property nemplea() As Decimal
        Get
            Return _nemplea
        End Get
        Set(ByVal Value As Decimal)
            _nemplea = Value
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
 
    Public Property npagpres() As Decimal
        Get
            Return _npagpres
        End Get
        Set(ByVal Value As Decimal)
            _npagpres = Value
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
 
    Public Property notring() As Decimal
        Get
            Return _notring
        End Get
        Set(ByVal Value As Decimal)
            _notring = Value
        End Set
    End Property 
 
    Public Property nimpues() As Decimal
        Get
            Return _nimpues
        End Get
        Set(ByVal Value As Decimal)
            _nimpues = Value
        End Set
    End Property 
 
    Public Property nimprev() As Decimal
        Get
            Return _nimprev
        End Get
        Set(ByVal Value As Decimal)
            _nimprev = Value
        End Set
    End Property 
 
    Public Property notract() As Decimal
        Get
            Return _notract
        End Get
        Set(ByVal Value As Decimal)
            _notract = Value
        End Set
    End Property 

    Public Property nmarseg() As Decimal
        Get
            Return _nmarseg
        End Get
        Set(ByVal Value As Decimal)
            _nmarseg = Value
        End Set
    End Property
    Private _ndinefe As Double
    Public Property ndinefe() As Double
        Get
            Return _ndinefe
        End Get
        Set(ByVal Value As Double)
            _ndinefe = Value
        End Set
    End Property
    Private _ndinban As Double
    Public Property ndinban() As Double
        Get
            Return _ndinban
        End Get
        Set(ByVal Value As Double)
            _ndinban = Value
        End Set
    End Property
    Private _nbienesinm As Double
    Public Property nbienesinm() As Double
        Get
            Return _nbienesinm
        End Get
        Set(ByVal Value As Double)
            _nbienesinm = Value
        End Set
    End Property
    Private _nbienesens As Double
    Public Property nbienesens() As Double
        Get
            Return _nbienesens
        End Get
        Set(ByVal Value As Double)
            _nbienesens = Value
        End Set
    End Property
    Private _nvehiculos As Double
    Public Property nvehiculos() As Double
        Get
            Return _nvehiculos
        End Get
        Set(ByVal Value As Double)
            _nvehiculos = Value
        End Set
    End Property
    Private _nganado As Double
    Public Property nganado() As Double
        Get
            Return _nganado
        End Get
        Set(ByVal Value As Double)
            _nganado = Value
        End Set
    End Property
    Private _notrosbienes As Double
    Public Property notrosbienes() As Double
        Get
            Return _notrosbienes
        End Get
        Set(ByVal Value As Double)
            _notrosbienes = Value
        End Set
    End Property
    Private _noblbancos As Double
    Public Property noblbancos() As Double
        Get
            Return _noblbancos
        End Get
        Set(ByVal Value As Double)
            _noblbancos = Value
        End Set
    End Property
    Private _noblbens As Double
    Public Property noblens() As Double
        Get
            Return _noblbens
        End Get
        Set(ByVal Value As Double)
            _noblbens = Value
        End Set
    End Property
    Private _ntienyalm As Double
    Public Property ntienyalm() As Double
        Get
            Return _ntienyalm
        End Get
        Set(ByVal Value As Double)
            _ntienyalm = Value
        End Set
    End Property
    Private _noblgasfam As Double
    Public Property noblgasfam() As Double
        Get
            Return _noblgasfam
        End Get
        Set(ByVal Value As Double)
            _noblgasfam = Value
        End Set
    End Property
    Private _notrosObl As Double
    Public Property notrosObl() As Double
        Get
            Return _notrosObl
        End Get
        Set(ByVal Value As Double)
            _notrosObl = Value
        End Set
    End Property

#End Region
End Class
