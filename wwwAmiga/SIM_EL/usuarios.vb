Public Class usuarios
    Inherits entidadBase
#Region " Privadas "
    Private _idUsuario As Int32
 
    Private _usuario As String
 
    Private _password As String

    Private _direccion As String

    Private _telefono As String

    Private _cargo As String

    Private _nombre As String

    Private _ccodofi As String

    Private _cip As String

    Private _dfecha As Date

    Private _chora As String

    Private _gdfecsis As Date

    Private _ctrs As String

    Private _lesapod As Boolean
    Private _lescaje As Boolean

    Private _idopcion As Integer

    Private _xfirma As Array
#End Region
 
#Region " Propiedades "
    Public Property idopcion() As Integer
        Get
            Return _idopcion
        End Get
        Set(ByVal Value As Integer)
            _idopcion = Value
        End Set
    End Property
    Public Property lescaje() As Boolean
        Get
            Return _lescaje
        End Get
        Set(ByVal Value As Boolean)
            _lescaje = Value
        End Set
    End Property

    Public Property xfirma() As Array
        Get
            Return _xfirma
        End Get
        Set(ByVal Value As Array)
            _xfirma = Value
        End Set
    End Property
 
    Public Property lesapod() As Boolean
        Get
            Return _lesapod
        End Get
        Set(ByVal Value As Boolean)
            _lesapod = Value
        End Set
    End Property

    Public Property idUsuario() As Int32
        Get
            Return _idUsuario
        End Get
        Set(ByVal Value As Int32)
            _idUsuario = Value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal Value As String)
            _usuario = Value
        End Set
    End Property

    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal Value As String)
            _password = Value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal Value As String)
            _direccion = Value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal Value As String)
            _telefono = Value
        End Set
    End Property

    Public Property cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal Value As String)
            _cargo = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal Value As String)
            _nombre = Value
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

    Public Property cip() As String
        Get
            Return _cip
        End Get
        Set(ByVal value As String)
            _cip = value
        End Set
    End Property

    Public Property dfecha() As Date
        Get
            Return _dfecha
        End Get
        Set(ByVal value As Date)
            _dfecha = value
        End Set
    End Property

    Public Property chora() As String
        Get
            Return _chora
        End Get
        Set(ByVal value As String)
            _chora = value
        End Set
    End Property

    Public Property gdfecsis() As Date
        Get
            Return _gdfecsis
        End Get
        Set(ByVal value As Date)
            _gdfecsis = value
        End Set
    End Property

    Public Property ctrs() As String
        Get
            Return _ctrs
        End Get
        Set(ByVal value As String)
            _ctrs = value
        End Set
    End Property
#End Region
End Class
