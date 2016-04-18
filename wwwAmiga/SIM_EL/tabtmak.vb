Public Class tabtmak
    Inherits entidadBase
#Region " Privadas "
    Private _ccodapl As String
 
    Private _ccodigo As String
 
    Private _cdebhab As String
 
    Private _cdescri As String
 
    Private _cplanti As String
 
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
 
    Public Property ccodigo() As String
        Get
            Return _ccodigo
        End Get
        Set(ByVal Value As String)
            _ccodigo = Value
        End Set
    End Property 
 
    Public Property cdebhab() As String
        Get
            Return _cdebhab
        End Get
        Set(ByVal Value As String)
            _cdebhab = Value
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
 
    Public Property cplanti() As String
        Get
            Return _cplanti
        End Get
        Set(ByVal Value As String)
            _cplanti = Value
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
