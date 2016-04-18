Public Class pagadurias
    Inherits entidadBase
#Region " Privadas "
    Private _nombre As String
 
    Private _cflag As String
 
#End Region
 
#Region " Propiedades "
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal Value As String)
            _nombre = Value
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
