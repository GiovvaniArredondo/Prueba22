Public Class notas
    Inherits entidadBase
#Region " Privadas "
    Private _ccodcli As String
 
    Private _ccodcta As String
 
    Private _fecha As DateTime
 
    Private _dias As Decimal
 
    Private _nota As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodcli() As String
        Get
            Return _ccodcli
        End Get
        Set(ByVal Value As String)
            _ccodcli = Value
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
 
    Public Property fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            _fecha = Value
        End Set
    End Property 
 
    Public Property dias() As Decimal
        Get
            Return _dias
        End Get
        Set(ByVal Value As Decimal)
            _dias = Value
        End Set
    End Property 
 
    Public Property nota() As String
        Get
            Return _nota
        End Get
        Set(ByVal Value As String)
            _nota = Value
        End Set
    End Property 
 
#End Region
End Class
