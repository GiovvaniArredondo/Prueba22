Public Class BOLETAS
    Inherits entidadBase
#Region " Privadas "
    Private _cbanco As String
 
    Private _cnuming As String
 
    Private _cestado As String
 
    Private _dfecsis As DateTime
 
    Private _dfecpro As DateTime

    Private _nmonto As Decimal
#End Region
 
#Region " Propiedades "
    Public Property cbanco() As String
        Get
            Return _cbanco
        End Get
        Set(ByVal Value As String)
            _cbanco = Value
        End Set
    End Property 
 
    Public Property cnuming() As String
        Get
            Return _cnuming
        End Get
        Set(ByVal Value As String)
            _cnuming = Value
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
 
    Public Property dfecsis() As DateTime
        Get
            Return _dfecsis
        End Get
        Set(ByVal Value As DateTime)
            _dfecsis = Value
        End Set
    End Property 
 
    Public Property dfecpro() As DateTime
        Get
            Return _dfecpro
        End Get
        Set(ByVal Value As DateTime)
            _dfecpro = Value
        End Set
    End Property 

    Public Property nmonto() As Decimal
        Get
            Return _nmonto
        End Get
        Set(ByVal Value As Decimal)
            _nmonto = Value
        End Set
    End Property
#End Region
End Class
