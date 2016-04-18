Public Class personal
    Inherits entidadBase
#Region " Privadas "
    Private _idempleado As Int32
 
    Private _nombre As String
 
    Private _email As String
 
    Private _tel As String
 
    Private _cel As String
 
    Private _reglon As String
 
    Private _contrato As String
 
    Private _idPuestoNominal As Int32
 
    Private _idpuestoFuncional As Int32
 
    Private _idprofesion As Int32
 
    Private _idarea As Int32
 
    Private _iddependencia As Int32
 
    Private _idsede As Int32
 
    Private _libre As String
 
    Private _dfecmod As DateTime
 
    Private _foto() As Byte

 
#End Region
 
#Region " Propiedades "
    Public Property idempleado() As Int32
        Get
            Return _idempleado
        End Get
        Set(ByVal Value As Int32)
            _idempleado = Value
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
 
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property 
 
    Public Property tel() As String
        Get
            Return _tel
        End Get
        Set(ByVal Value As String)
            _tel = Value
        End Set
    End Property 
 
    Public Property cel() As String
        Get
            Return _cel
        End Get
        Set(ByVal Value As String)
            _cel = Value
        End Set
    End Property 
 
    Public Property reglon() As String
        Get
            Return _reglon
        End Get
        Set(ByVal Value As String)
            _reglon = Value
        End Set
    End Property 
 
    Public Property contrato() As String
        Get
            Return _contrato
        End Get
        Set(ByVal Value As String)
            _contrato = Value
        End Set
    End Property 
 
    Public Property idPuestoNominal() As Int32
        Get
            Return _idPuestoNominal
        End Get
        Set(ByVal Value As Int32)
            _idPuestoNominal = Value
        End Set
    End Property 
 
    Public Property idpuestoFuncional() As Int32
        Get
            Return _idpuestoFuncional
        End Get
        Set(ByVal Value As Int32)
            _idpuestoFuncional = Value
        End Set
    End Property 
 
    Public Property idprofesion() As Int32
        Get
            Return _idprofesion
        End Get
        Set(ByVal Value As Int32)
            _idprofesion = Value
        End Set
    End Property 
 
    Public Property idarea() As Int32
        Get
            Return _idarea
        End Get
        Set(ByVal Value As Int32)
            _idarea = Value
        End Set
    End Property 
 
    Public Property iddependencia() As Int32
        Get
            Return _iddependencia
        End Get
        Set(ByVal Value As Int32)
            _iddependencia = Value
        End Set
    End Property 
 
    Public Property idsede() As Int32
        Get
            Return _idsede
        End Get
        Set(ByVal Value As Int32)
            _idsede = Value
        End Set
    End Property 
 
    Public Property libre() As String
        Get
            Return _libre
        End Get
        Set(ByVal Value As String)
            _libre = Value
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
 
    Public Property foto() As Array
        Get
            Return _foto
        End Get
        Set(ByVal Value As Array)
            _foto = Value
        End Set
    End Property
 
#End Region
End Class
