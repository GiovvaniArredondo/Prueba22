Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings


Public Class clsversion1
    Dim vCadena As String
    Dim sql As String
    Private vCnn As String
    Public Property Cnn() As String
        Get
            Return vCnn
        End Get
        Set(ByVal Value As String)
            vCnn = Value
        End Set
    End Property

    Private _dFecpar As Date
    Public Property dFecpar() As Date
        Get
            Return _dFecpar
        End Get
        Set(ByVal Value As Date)
            _dFecpar = Value
        End Set
    End Property

    Dim ecntaprm As New cCntaprm
    Public Function validaMes(ByVal ccodigo As String) As Integer
        'Obtiene mes de vigencia
        Dim ds As New DataSet
        Dim ldfecini As Date
        Dim ldfecfin As Date
        ds = ecntaprm.ObtenerMestoClose(ccodigo)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            ldfecini = ds.Tables(0).Rows(0)("dfecini")
            ldfecfin = ds.Tables(0).Rows(0)("dfecfin")

            If Me.dFecpar < ldfecini Then
                Return 0
            Else
                Return 1
            End If
        End If

    End Function
End Class
