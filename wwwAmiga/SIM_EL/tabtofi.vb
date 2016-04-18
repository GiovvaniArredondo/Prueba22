Public Class tabtofi
    Inherits entidadBase

#Region " Privadas "
    Private _cvalcie As Boolean

    Private _ccodins As String

    Private _ccodofi As String

    Private _cnomofi As String

    Private _ctipofi As String

    Private _cofisup As String

    Private _cdrive As String

    Private _cserver As String

    Private _cusuari As String

    Private _cclave As String

    Private _ctipser As String

    Private _ninterco As Decimal

    Private _cflag As String

    Private _nNivel As Integer

    Private _nlibdesde As Integer

    Private _nlibhasta As Integer

    Private _ncerdesde As Integer

    Private _ncerhasta As Integer

    Private _cmuni As String

    Private _cdepa As String

    Private _cdireccion As String

    Private _ctelefono As String
#End Region
 
#Region " Propiedades "
    Public Property cValCie() As Boolean
        Get
            Return _cvalcie
        End Get
        Set(ByVal Value As Boolean)
            _cvalcie = cValCie
        End Set
    End Property


    Public Property ccodins() As String
        Get
            Return _ccodins
        End Get
        Set(ByVal Value As String)
            _ccodins = Value
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

    Public Property cnomofi() As String
        Get
            Return _cnomofi
        End Get
        Set(ByVal Value As String)
            _cnomofi = Value
        End Set
    End Property

    Public Property ctipofi() As String
        Get
            Return _ctipofi
        End Get
        Set(ByVal Value As String)
            _ctipofi = Value
        End Set
    End Property

    Public Property cofisup() As String
        Get
            Return _cofisup
        End Get
        Set(ByVal Value As String)
            _cofisup = Value
        End Set
    End Property

    Public Property cdrive() As String
        Get
            Return _cdrive
        End Get
        Set(ByVal Value As String)
            _cdrive = Value
        End Set
    End Property

    Public Property cserver() As String
        Get
            Return _cserver
        End Get
        Set(ByVal Value As String)
            _cserver = Value
        End Set
    End Property

    Public Property cusuari() As String
        Get
            Return _cusuari
        End Get
        Set(ByVal Value As String)
            _cusuari = Value
        End Set
    End Property

    Public Property cclave() As String
        Get
            Return _cclave
        End Get
        Set(ByVal Value As String)
            _cclave = Value
        End Set
    End Property

    Public Property ctipser() As String
        Get
            Return _ctipser
        End Get
        Set(ByVal Value As String)
            _ctipser = Value
        End Set
    End Property

    Public Property ninterco() As Decimal
        Get
            Return _ninterco
        End Get
        Set(ByVal Value As Decimal)
            _ninterco = Value
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

    Public Property nNivel() As Integer
        Get
            Return _nNivel
        End Get
        Set(ByVal Value As Integer)
            _nNivel = Value
        End Set
    End Property

    Public Property nlibdesde() As Integer
        Get
            Return _nlibdesde
        End Get
        Set(ByVal Value As Integer)
            _nlibdesde = Value
        End Set
    End Property
    Public Property nlibhasta() As Integer
        Get
            Return _nlibhasta
        End Get
        Set(ByVal Value As Integer)
            _nlibhasta = Value
        End Set
    End Property
    Public Property ncerdesde() As Integer
        Get
            Return _ncerdesde
        End Get
        Set(ByVal Value As Integer)
            _ncerdesde = Value
        End Set
    End Property
    Public Property ncerhasta() As Integer
        Get
            Return _ncerhasta
        End Get
        Set(ByVal Value As Integer)
            _ncerhasta = Value
        End Set
    End Property

    Public Property cmuni() As String
        Get
            Return _cmuni
        End Get
        Set(ByVal Value As String)
            _cmuni = Value
        End Set
    End Property
    Public Property cdepa() As String
        Get
            Return _cdepa
        End Get
        Set(ByVal Value As String)
            _cdepa = Value
        End Set
    End Property

    Public Property cdireccion() As String
        Get
            Return _cdireccion
        End Get
        Set(ByVal Value As String)
            _cdireccion = Value
        End Set
    End Property

    Public Property ctelefono() As String
        Get
            Return _ctelefono
        End Get
        Set(ByVal Value As String)
            _ctelefono = Value
        End Set
    End Property
#End Region

End Class
