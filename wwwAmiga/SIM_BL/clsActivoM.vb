Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings

Public Class clsActivoM

#Region "Propiedades"
    Private _cCodinv As String
    Public Property cCodinv() As String
        Get
            Return _cCodinv
        End Get
        Set(ByVal Value As String)
            _cCodinv = Value
        End Set
    End Property

    Private _ccodusu As String
    Public Property ccodusu() As String
        Get
            Return _ccodusu
        End Get
        Set(ByVal value As String)
            _ccodusu = value
        End Set
    End Property

    Private _ccodofi As String
    Public Property ccodofi() As String
        Get
            Return _ccodofi
        End Get
        Set(ByVal value As String)
            _ccodofi = value
        End Set
    End Property

    Private _dfectra As Date
    Public Property dfectra() As Date
        Get
            Return _dfectra
        End Get
        Set(ByVal value As Date)
            _dfectra = value
        End Set
    End Property

    Private _cestado As String
    Public Property cestado() As String
        Get
            Return _cestado
        End Get
        Set(ByVal value As String)
            _cestado = value
        End Set
    End Property

#End Region

    Public Function GrabarMovimiento() As Integer
        Dim i As Integer
        Dim cActivoM As New SIM.EL.ActivoM
        Dim eactivom As New SIM.BL.cActivoM
        Try
            cActivoM.ccodinv = Me.cCodinv
            cActivoM.ccodusu = Me.ccodusu
            cActivoM.ccodofi = Me.ccodofi
            cActivoM.dfectra = Me.dfectra
            cActivoM.cestado = Me.cestado

            i = eactivom.Agregar(cActivoM)
            Return i
        Catch ex As Exception
            i = 0
            Return i
        End Try
    End Function
    Public Function UpdateMovimiento() As Integer
        Dim i As Integer
        Dim cActivoM As New SIM.EL.ActivoM
        Dim eactivom As New SIM.BL.cActivoM
        Try
            cActivoM.ccodinv = Me.cCodinv
            cActivoM.ccodusu = Me.ccodusu
            cActivoM.ccodofi = Me.ccodofi
            cActivoM.dfectra = Me.dfectra
            cActivoM.cestado = Me.cestado

            i = eactivom.Actualizar(cActivoM)
            Return i
        Catch ex As Exception
            i = 0
            Return i
        End Try
    End Function
End Class
