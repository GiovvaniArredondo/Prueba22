Imports System.Configuration.ConfigurationSettings
Public MustInherit Class dbBase

#Region " Protegidas "
    Protected _sError As String
    Protected _sql As Microsoft.ApplicationBlocks.Data.SqlHelper
    'Protected _sql As Microsoft.ApplicationBlocks.Data.OdbcHelper
    Protected _cnnStr As New String(AppSettings("cnnString"))
    Protected _gcnnString As New String(AppSettings("gcnnString"))
#End Region

#Region " Propiedades "

    Protected Overridable Property sql() As Microsoft.ApplicationBlocks.Data.SqlHelper
        Get
            Return Me._sql
        End Get
        Set(ByVal Value As Microsoft.ApplicationBlocks.Data.SqlHelper)
            Me._sql = Value
        End Set
    End Property

    'Protected Overridable Property sql() As OdbcHelper
    '    Get
    '        Return Me._sql
    '    End Get
    '    Set(ByVal Value As OdbcHelper)
    '        Me._sql = Value
    '    End Set
    'End Property

    Protected Overridable Property sError() As String
        Get
            Return Me._sError
        End Get
        Set(ByVal Value As String)
            Me._sError = Value
        End Set
    End Property

    Protected Overridable Property cnnStr() As String
        Get
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property


    Protected Overridable Property gcnnString() As String
        Get
            Return Me._gcnnString
        End Get
        Set(ByVal Value As String)
            Me._gcnnString = Value
        End Set
    End Property
#End Region

#Region " Métodos Públicos "

    Public MustOverride Function Actualizar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Actualizar los datos de la Entidad


    Public MustOverride Function Agregar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Insertar los datos de la Entidad

    Public MustOverride Function Eliminar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Eliminar los datos de la Entidad

    Public MustOverride Function Recuperar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Recuperar los datos de la Entidad

    Public MustOverride Function ObtenerID(ByVal aEntidad As entidadBase) As Long
    'Funcion que se encarga de Obtener el Maximo ID de la Entidad.

#End Region


End Class
