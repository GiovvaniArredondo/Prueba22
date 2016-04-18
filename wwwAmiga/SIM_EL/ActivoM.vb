Public Class ActivoM
    Inherits entidadBase
#Region " Privadas "
    Private _ccodinv As String
    Private _ccodusu As String
    Private _ccodofi As String
    Private _dfectra As DateTime
    Private _cestado As String
#End Region

#Region " Propiedades "
    Public Property ccodinv() As String
        Get
            Return _ccodinv
        End Get
        Set(ByVal value As String)
            _ccodinv = value
        End Set
    End Property

    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal value As String)
            _ccodusu = value
        End Set
    End Property

    Public Property ccodofi() As String
        Get
            Return _ccodofi
        End Get
        Set(ByVal value As String)
            _ccodofi = value
        End Set
    End Property

    Public Property dfectra() As DateTime
        Get
            Return _dfectra
        End Get
        Set(ByVal value As Date)
            _dfectra = value
        End Set
    End Property

    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal value As String)
            _cestado = value
        End Set
    End Property

#End Region
End Class
