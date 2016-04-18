Public Class tabtzon
    Inherits entidadBase
#Region " Privadas "
    Private _ccodzon As String
 
    Private _cdeszon As String
 
    Private _ctipzon As String
 
    Private _cnivreg As String
 
#End Region
 
#Region " Propiedades "
    Public Property ccodzon() As String
        Get
            Return _ccodzon
        End Get
        Set(ByVal Value As String)
            _ccodzon = Value
        End Set
    End Property 
 
    Public Property cdeszon() As String
        Get
            Return _cdeszon
        End Get
        Set(ByVal Value As String)
            _cdeszon = Value
        End Set
    End Property 
 
    Public Property ctipzon() As String
        Get
            Return _ctipzon
        End Get
        Set(ByVal Value As String)
            _ctipzon = Value
        End Set
    End Property 
 
    Public Property cnivreg() As String
        Get
            Return _cnivreg
        End Get
        Set(ByVal Value As String)
            _cnivreg = Value
        End Set
    End Property 
 
#End Region
End Class
