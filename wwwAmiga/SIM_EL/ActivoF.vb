Public Class ActivoF
    Inherits entidadBase

#Region " Privadas "
    Private _ccodinv As String
    Private _ccodofi As String
    Private _ffondos As String
    Private _cnrochq As String
    Private _cnumcom As String
    Private _ccodpro As String
    Private _cnumdoc As String
    Private _dfecadq As DateTime
    Private _dfecbja As DateTime
    Private _ccodemp As String
    Private _ccodusu As String
    Private _nactdep As Integer
    Private _ccodact As String
    Private _ctipact As String
    Private _cdesbien As String
    Private _nviduti As Integer
    Private _nvalcpa As Double
    Private _nvalres As Double
    Private _nvalno As Double
    Private _ccodadq As String
    Private _cestbien As String
    Private _ccodsec As String
    Private _ccodubi As String
    Private _cnumser As String
    Private _cunidad As String
    Private _dfecdep As DateTime
#End Region
 
#Region " Propiedades "
    Public Property ccodinv() As String
        Get
            Return _ccodinv
        End Get
        Set(ByVal Value As String)
            _ccodinv = Value
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
        Set(ByVal value As String)
            _ffondos = value
        End Set
    End Property

    Public Property cnrochq() As String
        Get
            Return _cnrochq
        End Get
        Set(ByVal value As String)
            _cnrochq = value
        End Set
    End Property

    Public Property cnumcom() As String
        Get
            Return _cnumcom
        End Get
        Set(ByVal value As String)
            _cnumcom = value
        End Set
    End Property

    Public Property ccodpro() As String
        Get
            Return _ccodpro
        End Get
        Set(ByVal value As String)
            _ccodpro = value
        End Set
    End Property

    Public Property cnumdoc() As String
        Get
            Return _cnumdoc
        End Get
        Set(ByVal value As String)
            _cnumdoc = value
        End Set
    End Property

    Public Property dfecadq() As DateTime
        Get
            Return _dfecadq
        End Get
        Set(ByVal Value As DateTime)
            _dfecadq = Value
        End Set
    End Property

    Public Property dfecbja() As DateTime
        Get
            Return _dfecbja
        End Get
        Set(ByVal value As DateTime)
            _dfecbja = value
        End Set
    End Property

    Public Property ccodemp() As String
        Get
            Return _ccodemp
        End Get
        Set(ByVal value As String)
            _ccodemp = value
        End Set
    End Property

    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal value As String)
            _ccodusu = value
        End Set
    End Property

    Public Property nactdep() As Integer
        Get
            Return _nactdep
        End Get
        Set(ByVal value As Integer)
            _nactdep = value
        End Set
    End Property

    Public Property ccodact() As String
        Get
            Return _ccodact
        End Get
        Set(ByVal Value As String)
            _ccodact = Value
        End Set
    End Property

    Public Property ctipact() As String
        Get
            Return _ctipact
        End Get
        Set(ByVal Value As String)
            _ctipact = Value
        End Set
    End Property

    Public Property cdesbien() As String
        Get
            Return _cdesbien
        End Get
        Set(ByVal Value As String)
            _cdesbien = Value
        End Set
    End Property

    Public Property nviduti() As Integer
        Get
            Return _nviduti
        End Get
        Set(ByVal Value As Integer)
            _nviduti = Value
        End Set
    End Property

    Public Property nvalcpa() As Double
        Get
            Return _nvalcpa
        End Get
        Set(ByVal Value As Double)
            _nvalcpa = Value
        End Set
    End Property

    Public Property nvalres() As Double
        Get
            Return _nvalres
        End Get
        Set(ByVal Value As Double)
            _nvalres = Value
        End Set
    End Property

    Public Property nvalno() As Double
        Get
            Return _nvalno
        End Get
        Set(ByVal Value As Double)
            _nvalno = Value
        End Set
    End Property

    Public Property ccodadq() As String
        Get
            Return _ccodadq
        End Get
        Set(ByVal Value As String)
            _ccodadq = Value
        End Set
    End Property

    Public Property cestbien() As String
        Get
            Return _cestbien
        End Get
        Set(ByVal Value As String)
            _cestbien = Value
        End Set
    End Property

    Public Property ccodsec() As String
        Get
            Return _ccodsec
        End Get
        Set(ByVal value As String)
            _ccodsec = value
        End Set
    End Property

    Public Property ccodubi() As String
        Get
            Return _ccodubi
        End Get
        Set(ByVal Value As String)
            _ccodubi = Value
        End Set
    End Property

    Public Property cnumser() As String
        Get
            Return _cnumser
        End Get
        Set(ByVal Value As String)
            _cnumser = Value
        End Set
    End Property

    Public Property cunidad() As String
        Get
            Return _cunidad
        End Get
        Set(ByVal Value As String)
            _cunidad = Value
        End Set
    End Property

    Public Property dfecdep() As Date
        Get
            Return _dfecdep
        End Get
        Set(ByVal value As DateTime)
            _dfecdep = value
        End Set
    End Property
#End Region
End Class
