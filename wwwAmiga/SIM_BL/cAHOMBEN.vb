Public Class cAHOMBEN
 
#Region " Privadas "
    Private mDb as New dbAHOMBEN()
    Private mEntidad as AHOMBEN
#End Region
 
    Public Function ObtenerLista(ByVal ccodaho As String) As listaAHOMBEN
        Return mDb.ObtenerListaPorID(ccodaho)
    End Function

    Public Function ObtenerAHOMBEN(ByRef mEntidad As AHOMBEN) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarAHOMBEN(ByVal mEntidad As AHOMBEN) As Integer
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAHOMBEN(ByVal aEntidad As AHOMBEN) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    'agregar
    Public Function agregar(ByVal aEntidad As AHOMBEN) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function ObtenerBeneficiarios(ByVal ccodaho As String) As DataSet
        Return mDb.ObtenerBeneficiarios(ccodaho)
    End Function

    Public Function Extrae_Beneficiarios_Ctas(ByVal pcCodcli As String, ByVal producto As String) As DataSet
        Return mDb.Extrae_Beneficiarios_Ctas(pcCodcli, producto)
    End Function


    Public Function Extrae_Beneficiarios(ByVal pcCodcli As String) As DataSet
        Return mDb.Extrae_Beneficiarios(pcCodcli)
    End Function

    Public Function Extrae_Beneficiarios_Aporta_Corriente(ByVal pcCodcli As String) As DataSet
        Return mDb.Extrae_Beneficiarios_Aporta_Corriente(pcCodcli)
    End Function
End Class
