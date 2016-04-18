Public Class tabtciu
    Inherits entidadBase
#Region " Privadas "
    Private _ccodigo As String
 
    Private _cdescri As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodigo() As String
        Get
            Return _ccodigo
        End Get
        Set(ByVal Value As String)
            _ccodigo = Value
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
 
#End Region
End Class
