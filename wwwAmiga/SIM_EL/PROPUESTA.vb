Public Class PROPUESTA
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _cestado As String
 
    Private _ccodcli As String
 
    Private _ctipcuo As String
 
    Private _ctipper As String
 
    Private _ccodana As String
 
    Private _dfecasi As DateTime
 
    Private _dfecsol As DateTime
 
    Private _nmonsol As Decimal
 
    Private _nmonsug As Decimal
 
    Private _ncuosug As Decimal
 
    Private _ndiasug As Decimal
 
    Private _ndiagra As Decimal
 
    Private _dfecapr As DateTime
 
    Private _dfecven As DateTime
 
    Private _nmonapr As Decimal
 
    Private _nmoncuo As Decimal
 
    Private _ncuoapr As Decimal
 
    Private _ndiaapr As Decimal
 
    Private _cnrolin As String
 
    Private _ntasint As Decimal
 
    Private _dfecvig As DateTime
 
    Private _ngastos As Decimal
 
    Private _ncapdes As Decimal
 
    Private _nmeses As Decimal
 
    Private _csececo As String
 
    Private _nciclo As Decimal
 
    Private _ccodsol As String
 
    Private _ncapoto As Decimal
 
    Private _ccodusu As String
 
    Private _dfecmod As DateTime
 
    Private _cflag As String
 
    Private _cflat As String
 
    Private _coficina As String
 
    Private _cfreccap As String
 
    Private _cfrecint As String
 
    Private _cprograma As String

    Private _cdescre As String

    Private _ccodfue As String
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
 
    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal Value As String)
            _cestado = Value
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
 
    Public Property ctipcuo() As String
        Get
            Return _ctipcuo
        End Get
        Set(ByVal Value As String)
            _ctipcuo = Value
        End Set
    End Property 
 
    Public Property ctipper() As String
        Get
            Return _ctipper
        End Get
        Set(ByVal Value As String)
            _ctipper = Value
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
 
    Public Property dfecasi() As DateTime
        Get
            Return _dfecasi
        End Get
        Set(ByVal Value As DateTime)
            _dfecasi = Value
        End Set
    End Property 
 
    Public Property dfecsol() As DateTime
        Get
            Return _dfecsol
        End Get
        Set(ByVal Value As DateTime)
            _dfecsol = Value
        End Set
    End Property 
 
    Public Property nmonsol() As Decimal
        Get
            Return _nmonsol
        End Get
        Set(ByVal Value As Decimal)
            _nmonsol = Value
        End Set
    End Property 
 
    Public Property nmonsug() As Decimal
        Get
            Return _nmonsug
        End Get
        Set(ByVal Value As Decimal)
            _nmonsug = Value
        End Set
    End Property 
 
    Public Property ncuosug() As Decimal
        Get
            Return _ncuosug
        End Get
        Set(ByVal Value As Decimal)
            _ncuosug = Value
        End Set
    End Property 
 
    Public Property ndiasug() As Decimal
        Get
            Return _ndiasug
        End Get
        Set(ByVal Value As Decimal)
            _ndiasug = Value
        End Set
    End Property 
 
    Public Property ndiagra() As Decimal
        Get
            Return _ndiagra
        End Get
        Set(ByVal Value As Decimal)
            _ndiagra = Value
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
 
    Public Property dfecven() As DateTime
        Get
            Return _dfecven
        End Get
        Set(ByVal Value As DateTime)
            _dfecven = Value
        End Set
    End Property 
 
    Public Property nmonapr() As Decimal
        Get
            Return _nmonapr
        End Get
        Set(ByVal Value As Decimal)
            _nmonapr = Value
        End Set
    End Property 
 
    Public Property nmoncuo() As Decimal
        Get
            Return _nmoncuo
        End Get
        Set(ByVal Value As Decimal)
            _nmoncuo = Value
        End Set
    End Property 
 
    Public Property ncuoapr() As Decimal
        Get
            Return _ncuoapr
        End Get
        Set(ByVal Value As Decimal)
            _ncuoapr = Value
        End Set
    End Property 
 
    Public Property ndiaapr() As Decimal
        Get
            Return _ndiaapr
        End Get
        Set(ByVal Value As Decimal)
            _ndiaapr = Value
        End Set
    End Property 
 
    Public Property cnrolin() As String
        Get
            Return _cnrolin
        End Get
        Set(ByVal Value As String)
            _cnrolin = Value
        End Set
    End Property 
 
    Public Property ntasint() As Decimal
        Get
            Return _ntasint
        End Get
        Set(ByVal Value As Decimal)
            _ntasint = Value
        End Set
    End Property 
 
    Public Property dfecvig() As DateTime
        Get
            Return _dfecvig
        End Get
        Set(ByVal Value As DateTime)
            _dfecvig = Value
        End Set
    End Property 
 
    Public Property ngastos() As Decimal
        Get
            Return _ngastos
        End Get
        Set(ByVal Value As Decimal)
            _ngastos = Value
        End Set
    End Property 
 
    Public Property ncapdes() As Decimal
        Get
            Return _ncapdes
        End Get
        Set(ByVal Value As Decimal)
            _ncapdes = Value
        End Set
    End Property 
 
    Public Property nmeses() As Decimal
        Get
            Return _nmeses
        End Get
        Set(ByVal Value As Decimal)
            _nmeses = Value
        End Set
    End Property 
 
    Public Property csececo() As String
        Get
            Return _csececo
        End Get
        Set(ByVal Value As String)
            _csececo = Value
        End Set
    End Property 
 
    Public Property nciclo() As Decimal
        Get
            Return _nciclo
        End Get
        Set(ByVal Value As Decimal)
            _nciclo = Value
        End Set
    End Property 
 
    Public Property ccodsol() As String
        Get
            Return _ccodsol
        End Get
        Set(ByVal Value As String)
            _ccodsol = Value
        End Set
    End Property 
 
    Public Property ncapoto() As Decimal
        Get
            Return _ncapoto
        End Get
        Set(ByVal Value As Decimal)
            _ncapoto = Value
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
 
    Public Property cflat() As String
        Get
            Return _cflat
        End Get
        Set(ByVal Value As String)
            _cflat = Value
        End Set
    End Property 
 
    Public Property coficina() As String
        Get
            Return _coficina
        End Get
        Set(ByVal Value As String)
            _coficina = Value
        End Set
    End Property 
 
    Public Property cfreccap() As String
        Get
            Return _cfreccap
        End Get
        Set(ByVal Value As String)
            _cfreccap = Value
        End Set
    End Property 
 
    Public Property cfrecint() As String
        Get
            Return _cfrecint
        End Get
        Set(ByVal Value As String)
            _cfrecint = Value
        End Set
    End Property 
 
    Public Property cprograma() As String
        Get
            Return _cprograma
        End Get
        Set(ByVal Value As String)
            _cprograma = Value
        End Set
    End Property 

    Public Property cdescre() As String
        Get
            Return _cdescre
        End Get
        Set(ByVal Value As String)
            _cdescre = Value
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
#End Region
End Class
