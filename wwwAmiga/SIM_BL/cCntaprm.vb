Public Class cCntaprm
#Region " Privadas "
    Private mDb As New dbCntaprm()
    Private mEntidad As cntaprm

    Private _cfondo As String
    Public Property cfondo() As String
        Get
            Return _cfondo
        End Get
        Set(ByVal Value As String)
            _cfondo = Value
        End Set
    End Property

#End Region

    Public Function ObtenerLista() As listacntaprm
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerListaPorIDyear() As listacntaprm
        Dim lcfondo As String
        lcfondo = Me.cfondo
        mDb.cfondo = lcfondo
        Return mDb.ObtenerListaPorIDyear()
    End Function
    Public Function ObtenerCntaprm(ByRef mEntidad As cntaprm) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCntaprm(ByVal cmesvig As String) As Integer
        Dim mEntidad As New cntaprm
        mEntidad.cmesvig = cmesvig
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCntaprm(ByVal aEntidad As cntaprm) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodigo As String, ByVal ccadena As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodigo, ccadena)
    End Function
    Public Function ObtenerDataSetPorID2(ByVal cfondo As String) As DataSet
        Return mDb.ObtenerDataSetPorID2(cfondo)
    End Function
    Public Function agregar(ByVal aEntidad As cntaprm) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function ObtenerMestoClose(ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerMestoClose(ccodigo)
    End Function
    Public Function CierreMes(ByVal pcmesvig As String, ByVal ccodigo As String) As Integer
        Return mDb.CierreMes(pcmesvig, ccodigo)
    End Function
    Public Function AbreMes(ByVal pcmesvig As String, ByVal pdfecini As Date, ByVal pdfecfin As Date, ByVal pccodusu As String, ByVal ccodigo As String) As Integer
        Return mDb.AbreMes(pcmesvig, pdfecini, pdfecfin, pccodusu, ccodigo)
    End Function
    Public Function ObtenerfiscaltoClose(ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerfiscaltoClose(ccodigo)
    End Function
    Public Function ObtenerDataSetPoryear(ByVal cyear As String) As DataSet
        Return mDb.ObtenerDataSetPoryear(cyear)
    End Function
End Class
