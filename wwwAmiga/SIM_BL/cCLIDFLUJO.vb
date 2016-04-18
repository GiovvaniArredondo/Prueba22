Public Class cCLIDFLUJO
 
#Region " Privadas "
    Private mDb as New dbCLIDFLUJO()
    Private mEntidad as CLIDFLUJO
#End Region
 

 
    Public Function ObtenerCLIDFLUJO(ByRef mEntidad As CLIDFLUJO) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCLIDFLUJO(ByVal mEntidad As CLIDFLUJO) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCLIDFLUJO(ByVal aEntidad As CLIDFLUJO) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorcliente(ByVal ccodcli As String, ByVal ccodfue As String) As DataSet
        Return mDb.ObtenerDataSetPorcliente(ccodcli, ccodfue)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date, ByRef ds As DataSet) As Integer
        Return mDb.ObtenerDataSetPorID(ccodcli, ccodfue, devalua, ds)
    End Function
    Public Function ObtenerPromedio(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date) As Decimal
        Return mDb.ObtenerPromedio(ccodcli, ccodfue, devalua)
    End Function
End Class
