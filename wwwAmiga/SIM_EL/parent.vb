Public Class parent
    Inherits entidadBase
#Region " Privadas "
    Private _cparent As String
 
    Private _cdescri As String
 
#End Region
 
#Region " Propiedades "
    Public Property cparent() As String
        Get
            Return _cparent
        End Get
        Set(ByVal Value As String)
            _cparent = Value
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
