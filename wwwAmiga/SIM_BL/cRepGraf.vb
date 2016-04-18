Public Class cRepGraf
#Region " Privadas "
    Private mDb As New dbRepGraf
    Private mEntidad As RepGraf
#End Region
    Public Function ObtenerDataSetEstadistico(ByVal pnLimite As Integer, ByVal pnLimite2 As Integer) As DataSet
        Return mDb.ObtenerDataSetEstadistico(pnLimite, pnLimite2)
    End Function
    Public Function ObtenerDataSetPorGenero(ByVal pcGenero As String) As DataSet
        Return mDb.ObtenerDataSetPorGenero(pcGenero)
    End Function
    Public Function ObtenerDataSetPorIDTab(ByVal cCodTab As String, ByVal cTipReg As String) As DataSet
        Return mDb.ObtenerDataSetPorIDTab(cCodTab, cTipReg)
    End Function
    Public Function ObtenerDataSetOficina() As DataSet
        Return mDb.ObtenerDataSetOficina()
    End Function
    Public Function ObtenerDataSetPorOficina(ByVal pcCodIns As String, ByVal pcCodOFi As String) As DataSet
        Return mDb.ObtenerDataSetPorOficina(pcCodIns, pcCodOFi)
    End Function
    Public Function ObtenerDataSetPorDestino(ByVal pcDestino As String) As DataSet
        Return mDb.ObtenerDataSetPorDestino(pcDestino)
    End Function
    Public Function ObtenerDataSetDestino(ByVal pcCodtab As String, ByVal pcTipReg As String) As DataSet
        Return mDb.ObtenerDataSetDestino(pcCodtab, pcTipReg)
    End Function
End Class
