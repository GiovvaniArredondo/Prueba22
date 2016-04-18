Public Class credchq
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcta As String
 
    Private _cnrodoc As String
 
    Private _ccodbco As String
 
    Private _cnrochq As String
 
    Private _cctacte As String
 
    Private _ccodusu As String
 
    Private _cdescob As String
 
    Private _cestado As String
 
    Private _cflag As String

    Private _cnomchq As String
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
 
    Public Property cnrodoc() As String
        Get
            Return _cnrodoc
        End Get
        Set(ByVal Value As String)
            _cnrodoc = Value
        End Set
    End Property 
 
    Public Property ccodbco() As String
        Get
            Return _ccodbco
        End Get
        Set(ByVal Value As String)
            _ccodbco = Value
        End Set
    End Property 
 
    Public Property cnrochq() As String
        Get
            Return _cnrochq
        End Get
        Set(ByVal Value As String)
            _cnrochq = Value
        End Set
    End Property 
 
    Public Property cctacte() As String
        Get
            Return _cctacte
        End Get
        Set(ByVal Value As String)
            _cctacte = Value
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
 
    Public Property cdescob() As String
        Get
            Return _cdescob
        End Get
        Set(ByVal Value As String)
            _cdescob = Value
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
 
    Public Property cflag() As String
        Get
            Return _cflag
        End Get
        Set(ByVal Value As String)
            _cflag = Value
        End Set
    End Property 

    Public Property cnomchq() As String
        Get
            Return _cnomchq
        End Get
        Set(ByVal Value As String)
            _cnomchq = Value
        End Set
    End Property
#End Region
End Class
