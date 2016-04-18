Public Class grupos
    Inherits entidadBase
#Region " Privadas "
    Private _idGrupo As Int32
 
    Private _grupo As String
 
    Private _codigoGrupo As String
 
#End Region
 
#Region " Propiedades "
    Public Property idGrupo() As Int32
        Get
            Return _idGrupo
        End Get
        Set(ByVal Value As Int32)
            _idGrupo = Value
        End Set
    End Property 
 
    Public Property grupo() As String
        Get
            Return _grupo
        End Get
        Set(ByVal Value As String)
            _grupo = Value
        End Set
    End Property 
 
    Public Property codigoGrupo() As String
        Get
            Return _codigoGrupo
        End Get
        Set(ByVal Value As String)
            _codigoGrupo = Value
        End Set
    End Property 
 
#End Region
End Class
