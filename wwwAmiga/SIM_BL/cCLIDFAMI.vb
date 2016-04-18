Public Class cCLIDFAMI
 
#Region " Privadas "
    Private mDb as New dbCLIDFAMI()
    Private mEntidad as CLIDFAMI
#End Region
 
    Public Function ObtenerLista(ByVal ccodcli As String) As listaCLIDFAMI
        Return mDb.ObtenerListaPorID(ccodcli)
    End Function

    Public Function ObtenerCLIDFAMI(ByRef mEntidad As CLIDFAMI) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCLIDFAMI(ByVal ccodcli As String, ByVal cCodUni As String) As Integer
        Dim mEntidad As New CLIDFAMI
        mEntidad.ccodcli = ccodcli
        mEntidad.cCodUni = cCoduni
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCLIDFAMI(ByVal aEntidad As CLIDFAMI) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function AgregrarCLIDFAMI(ByVal aEntidad As CLIDFAMI) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenercCoduni(ByVal ccodcli As String) As String
        Return mDb.ObtenercCoduni(ccodcli)
    End Function
    Public Function ObtenerDataSetEspc(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetEspc(ccodcli)
    End Function
    Public Function ObtenercCoduni2(ByVal ccodcli As String) As String
        Return mDb.ObtenercCoduni2(ccodcli)
    End Function
    Public Function ObtenerFechaUlt(ByVal ccodcli As String) As Date
        Return mDb.ObtenerFechaUlt(ccodcli)
    End Function
End Class
