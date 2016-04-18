Public Class ahompro2
    Inherits entidadBase
#Region " Privadas "
    Private _dultpro As DateTime
 
#End Region
 
#Region " Propiedades "
    Public Property dultpro() As DateTime
        Get
            Return _dultpro
        End Get
        Set(ByVal Value As DateTime)
            _dultpro = Value
        End Set
    End Property 
 
#End Region
End Class
