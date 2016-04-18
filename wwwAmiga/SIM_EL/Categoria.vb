Public Class Categoria
    Inherits entidadBase
#Region " Privadas "
    Private _cCatego As String
 
    Private _Limite As Int32

    Private _Limite2 As Int32
 
    Private _nNumCre As Int32
 
    Private _nSalCre As Decimal
 
    Private _nCarAfe As Decimal
 
    Private _nSalMora As Decimal
 
#End Region
 
#Region " Propiedades "
    Public Property cCatego() As String
        Get
            Return _cCatego
        End Get
        Set(ByVal Value As String)
            _cCatego = Value
        End Set
    End Property 
 
    Public Property Limite() As Int32
        Get
            Return _Limite
        End Get
        Set(ByVal Value As Int32)
            _Limite = Value
        End Set
    End Property 

    Public Property Limite2() As Int32
        Get
            Return _Limite2
        End Get
        Set(ByVal Value As Int32)
            _Limite2 = Value
        End Set
    End Property

    Public Property nNumCre() As Int32
        Get
            Return _nNumCre
        End Get
        Set(ByVal Value As Int32)
            _nNumCre = Value
        End Set
    End Property

    Public Property nSalCre() As Decimal
        Get
            Return _nSalCre
        End Get
        Set(ByVal Value As Decimal)
            _nSalCre = Value
        End Set
    End Property

    Public Property nCarAfe() As Decimal
        Get
            Return _nCarAfe
        End Get
        Set(ByVal Value As Decimal)
            _nCarAfe = Value
        End Set
    End Property

    Public Property nSalMora() As Decimal
        Get
            Return _nSalMora
        End Get
        Set(ByVal Value As Decimal)
            _nSalMora = Value
        End Set
    End Property

#End Region
End Class
