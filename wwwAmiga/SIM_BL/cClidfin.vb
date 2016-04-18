Public Class cClidfin
 
#Region " Privadas "
    Private mDb as New dbClidfin()
    Private mEntidad as Clidfin
#End Region

    Public Function ObtenerLista(ByVal ccodcli As String, ByVal ctiprel As String) As listaclidfin
        Return mDb.ObtenerListaPorID(ccodcli, ctiprel)
    End Function

    Public Function ObtenerLista2(ByVal ccodcli As String) As listaclidfin
        Return mDb.ObtenerListaPorID2(ccodcli)

    End Function

    Public Function ObtenerClidfin(ByRef mEntidad As clidfin) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
    Public Function ObtenerClidfinporCliente(ByRef mEntidad As clidfin) As Integer
        Return mDb.RecuperarporCliente(mEntidad)
    End Function
    Public Function EliminarClidfin(ByVal ccodcli As String, ByVal ctiprel As String, ByVal ccodfue As String) As Integer
        Return mDb.Elimina(ccodcli, ctiprel, ccodfue)
    End Function
    Public Function ActualizarClidfin(ByVal aEntidad As clidfin) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenercCoduni(ByVal ccodcli As String, ByVal ctiprel As String)
        Return mDb.ObtenercCoduni(ccodcli, ctiprel)
    End Function
    Public Function ObtenerDataSetEspc(ByVal ccodcli As String, ByVal ctiprel As String) As DataSet
        Return mDb.ObtenerDataSetEspc(ccodcli, ctiprel)
    End Function
    Public Function Agregar(ByVal aEntidad As clidfin) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorCodigo(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetPorCodigo(ccodcli)
    End Function
    Public Function ObtenerDirNegocio(ByVal cCodcli As String) As String
        Return mDb.ObtenerDirNegocio(cCodcli)
    End Function
    Public Function BuscarSectorEconomico(ByVal ccodcli As String) As String
        Return mDb.BuscarSectorEconomico(ccodcli)
    End Function
    Public Function BuscarActividad(ByVal ccodcli As String) As String
        Return mDb.BuscarActividad(ccodcli)
    End Function

    Public Function Extrae_Ultima_Fuente_de_Ingreso(ByVal pcCodigo As String) As String
        Return mDb.Extrae_Ultima_Fuente_de_Ingreso(pcCodigo)
    End Function
End Class
