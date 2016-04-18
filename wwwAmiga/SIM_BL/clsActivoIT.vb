Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings

Public Class clsActivoTI

#Region "Propiedades"
    Private _cCodinv As String
    Private _cnSerie As String
    Private _cmodelo As String
    Private _ccodmar As String
    Private _ccodlin As String
    Private _cnlicen As String
    Private _cusulog As String
    Private _cpaslog As String
    Private _cpasint As String
    Private _cdetalle As String
    Private _dfecmod As Date
    Private _ccodusu As String
    Public Property cCodinv() As String
        Get
            Return _cCodinv
        End Get
        Set(ByVal Value As String)
            _cCodinv = Value
        End Set
    End Property
    Public Property cnSerie() As String
        Get
            Return _cnSerie
        End Get
        Set(ByVal Value As String)
            _cnSerie = Value
        End Set
    End Property
    Public Property cModelo() As String
        Get
            Return _cmodelo
        End Get
        Set(ByVal Value As String)
            _cmodelo = Value
        End Set
    End Property
    Public Property cCodMar() As String
        Get
            Return _ccodmar
        End Get
        Set(ByVal Value As String)
            _ccodmar = Value
        End Set
    End Property
    Public Property cCodLin() As String
        Get
            Return _ccodlin
        End Get
        Set(ByVal Value As String)
            _ccodlin = Value
        End Set
    End Property
    Public Property cnlicen() As String
        Get
            Return _cnlicen
        End Get
        Set(ByVal Value As String)
            _cnlicen = Value
        End Set
    End Property
    Public Property cUsuLog() As String
        Get
            Return _cusulog
        End Get
        Set(ByVal Value As String)
            _cusulog = Value
        End Set
    End Property
    Public Property cPaslog() As String
        Get
            Return _cpaslog
        End Get
        Set(ByVal Value As String)
            _cpaslog = Value
        End Set
    End Property
    Public Property cPasint() As String
        Get
            Return _cpasint
        End Get
        Set(ByVal Value As String)
            _cpasint = Value
        End Set
    End Property
    Public Property cdetalle() As String
        Get
            Return _cdetalle
        End Get
        Set(ByVal Value As String)
            _cdetalle = Value
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
    Public Property dfecmod() As Date
        Get
            Return _dfecmod
        End Get
        Set(ByVal value As Date)
            _dfecmod = value
        End Set
    End Property

#End Region

    Public Function GrabarMovimientoTI() As Integer
        Dim i As Integer
        Dim cActivoTI As New SIM.EL.ActivoIT
        Dim eactivoTI As New SIM.BL.cActivoIT
        Try
            cActivoTI.ccodinv = Me.cCodinv
            cActivoTI.cnserie = Me.cnSerie
            cActivoTI.cmodelo = Me.cModelo
            cActivoTI.ccodmar = Me.cCodMar
            cActivoTI.ccodlin = Me.cCodLin
            cActivoTI.cnlicen = Me.cnlicen
            cActivoTI.cusulog = Me.cUsuLog
            cActivoTI.cpaslog = Me.cPaslog
            cActivoTI.cpasint = Me.cPasint
            cActivoTI.cdetall = Me.cdetalle
            cActivoTI.ccodusu = Me.ccodusu
            cActivoTI.dfecmod = Me.dfecmod
            i = eactivoTI.Agregar(cActivoTI)
            Return i
        Catch ex As Exception
            i = 0
            Return i
        End Try
    End Function
    Public Function UpdateMovimientoTI() As Integer
        Dim i As Integer
        Dim cActivoTI As New SIM.EL.ActivoIT
        Dim eactivoTI As New SIM.BL.cActivoIT
        Try
            cActivoTI.ccodinv = Me.cCodinv
            cActivoTI.cnserie = Me.cnSerie
            cActivoTI.cmodelo = Me.cModelo
            cActivoTI.ccodmar = Me.cCodMar
            cActivoTI.ccodlin = Me.cCodLin
            cActivoTI.cnlicen = Me.cnlicen
            cActivoTI.cusulog = Me.cUsuLog
            cActivoTI.cpaslog = Me.cPaslog
            cActivoTI.cpasint = Me.cPasint
            cActivoTI.cdetall = Me.cdetalle
            cActivoTI.ccodusu = Me.ccodusu
            cActivoTI.dfecmod = Me.dfecmod
            i = eactivoTI.Actualizar(cActivoTI)
            Return i
        Catch ex As Exception
            i = 0
            Return i
        End Try
    End Function
End Class
