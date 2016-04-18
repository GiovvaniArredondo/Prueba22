Public Class correla
    Inherits entidadBase
#Region " Privadas "
    Private _ccodana As String
 
    Private _cdescri As String
 
    Private _ccodcta As String
 
    Private _ccorrela As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodana() As String
        Get
            Return _ccodana
        End Get
        Set(ByVal Value As String)
            _ccodana = Value
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
 
    Public Property ccodcta() As String
        Get
            Return _ccodcta
        End Get
        Set(ByVal Value As String)
            _ccodcta = Value
        End Set
    End Property 
 
    Public Property ccorrela() As String
        Get
            Return _ccorrela
        End Get
        Set(ByVal Value As String)
            _ccorrela = Value
        End Set
    End Property 
 
#End Region
End Class
