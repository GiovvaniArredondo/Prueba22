Public Class cAhomaho
 
#Region " Privadas "
    Private mDb as New dbAhomaho()
    Private mEntidad as Ahomaho
#End Region
 
    Public Function ObtenerLista(ByVal ccodaho As String) As listaahomaho
        Return mDb.ObtenerListaPorID(ccodaho)
    End Function

    'Agregar
    Public Function Agregar(ByRef mEntidad As ahomaho) As Integer
        Return mDb.Agregar(mEntidad)
    End Function

    Public Function ObtenerAhomaho(ByRef mEntidad As ahomaho) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarAhomaho(ByVal ccodaho As String) As Integer
        Dim mEntidad As New ahomaho
        mEntidad.ccodaho = ccodaho
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAhomaho(ByVal aEntidad As ahomaho) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    'obtiene dataset de provision por fechas

    Public Function ObtenerDataSetPorfecha(ByVal dfeccap As Date) As DataSet
        Return mDb.ObtenerDataSetPorfecha(dfeccap)
    End Function

    'se ocupa para filtrar interes y capitalizarlos por trimestre
    Public Function ObtenerListaporcuentayfechas(ByVal ccodaho As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As listaahomaho
        Return mDb.ObtenerListaporcuentayfechas(ccodaho, dfecha1, dfecha2)
    End Function


End Class
