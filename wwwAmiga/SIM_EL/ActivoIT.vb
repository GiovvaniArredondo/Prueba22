Public Class ActivoIT
    Inherits entidadBase
#Region " Privadas "
    Private _ccodinv As String
    Private _cnserie As String
    Private _cmodelo As String
    Private _ccodmar As String
    Private _ccodlin As String
    Private _cnlicen As String
    Private _cdetall As String
    Private _cusulog As String
    Private _cpaslog As String
    Private _cpasint As String
    Private _dfecmod As DateTime
    Private _ccodusu As String
#End Region

#Region " Propiedades "

    Public Property ccodinv() As String
        Get
            Return _ccodinv
        End Get
        Set(ByVal value As String)
            _ccodinv = value
        End Set
    End Property

    Public Property cnserie() As String
        Get
            Return _cnserie
        End Get
        Set(ByVal value As String)
            _cnserie = value
        End Set
    End Property

    Public Property cmodelo() As String
        Get
            Return _cmodelo
        End Get
        Set(ByVal value As String)
            _cmodelo = value
        End Set
    End Property

    Public Property ccodmar() As String
        Get
            Return _ccodmar
        End Get
        Set(ByVal value As String)
            _ccodmar = value
        End Set
    End Property

    Public Property ccodlin() As String
        Get
            Return _ccodlin
        End Get
        Set(ByVal value As String)
            _ccodlin = value
        End Set
    End Property

    Public Property cnlicen() As String
        Get
            Return _cnlicen
        End Get
        Set(ByVal value As String)
            _cnlicen = value
        End Set
    End Property

    Public Property cusulog() As String
        Get
            Return _cusulog
        End Get
        Set(ByVal value As String)
            _cusulog = value
        End Set
    End Property

    Public Property cpaslog() As String
        Get
            Return _cpaslog
        End Get
        Set(ByVal value As String)
            _cpaslog = value
        End Set
    End Property

    Public Property cpasint() As String
        Get
            Return _cpasint
        End Get
        Set(ByVal value As String)
            _cpasint = value
        End Set
    End Property

    Public Property cdetall() As String
        Get
            Return _cdetall
        End Get
        Set(ByVal value As String)
            _cdetall = value
        End Set
    End Property
    Public Property dfecmod() As String
        Get
            Return _dfecmod
        End Get
        Set(ByVal value As String)
            _dfecmod = value
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
#End Region
End Class
