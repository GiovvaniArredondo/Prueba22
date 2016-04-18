Public Class cCntaprmAct
#Region " Privadas "
    Private mDb As New dbCntaprmAct()
    Private mEntidad As cntaprmAct

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

    Public Function ObtenerLista() As listacntaprmAct
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerListaPorIDyear() As listacntaprmAct
        Dim lcfondo As String
        lcfondo = Me.cfondo
        mDb.cfondo = lcfondo
        Return mDb.ObtenerListaPorIDyear()
    End Function
    Public Function ObtenerCntaprmAct(ByRef mEntidad As cntaprmAct) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCntaprmAct(ByVal cmesvig As String) As Integer
        Dim mEntidad As New cntaprmAct
        mEntidad.cmesvig = cmesvig
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCntaprmAct(ByVal aEntidad As cntaprm) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodigo As String, ByVal ccadena As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodigo, ccadena)
    End Function
    Public Function ObtenerDataSetPorID2(ByVal cfondo As String) As DataSet
        Return mDb.ObtenerDataSetPorID2(cfondo)
    End Function
    Public Function agregar(ByVal aEntidad As cntaprmAct) As Integer
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
    Public Function CierreMesAct(ByVal pcmesvig As String, ByVal ccodigo As String, ByVal ccodusu As String) As Integer
        Return mDb.CierreMesACt(pcmesvig, ccodigo, ccodusu)
    End Function
    Public Function AbreMesAct(ByVal pcmesvig As String, ByVal ldfecini As Date, ByVal ldfecfin As Date, ByVal ccodusu As String, ByVal ccodigo As String) As Integer
        Return mDb.AbreMesAct(pcmesvig, ldfecini, ldfecfin, ccodusu, ccodigo)
    End Function
End Class
