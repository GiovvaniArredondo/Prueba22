Public Class tabtvar
    Inherits entidadBase
#Region " Privadas "
    Private _ccodapl As String
 
    Private _cnomvar As String
 
    Private _cconvar As String
 
    Private _cdesvar As String
 
    Private _ctipvar As String
 
    Private _ccodusu As String
 
    Private _lcarini As Boolean
 
    Private _cflag As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodapl() As String
        Get
            Return _ccodapl
        End Get
        Set(ByVal Value As String)
            _ccodapl = Value
        End Set
    End Property 
 
    Public Property cnomvar() As String
        Get
            Return _cnomvar
        End Get
        Set(ByVal Value As String)
            _cnomvar = Value
        End Set
    End Property 
 
    Public Property cconvar() As String
        Get
            Return _cconvar
        End Get
        Set(ByVal Value As String)
            _cconvar = Value
        End Set
    End Property 
 
    Public Property cdesvar() As String
        Get
            Return _cdesvar
        End Get
        Set(ByVal Value As String)
            _cdesvar = Value
        End Set
    End Property 
 
    Public Property ctipvar() As String
        Get
            Return _ctipvar
        End Get
        Set(ByVal Value As String)
            _ctipvar = Value
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
 
    Public Property lcarini() As Boolean
        Get
            Return _lcarini
        End Get
        Set(ByVal Value As Boolean)
            _lcarini = Value
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
 
#End Region
End Class
