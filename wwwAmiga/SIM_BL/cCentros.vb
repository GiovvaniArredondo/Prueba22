Public Class ccentros

#Region " Privadas "
    Private mDb as New dbcentros()
    Private mEntidad as centros
#End Region
 
    Public Function ObtenerLista() As listacentros
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function Obtenercentros(ByRef mEntidad As centros) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function Eliminarcentros(ByVal cCodsol As String) As Integer
        Dim mEntidad As New centros
        mEntidad.cCodsol = cCodsol
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function Actualizarcentros(ByVal aEntidad As centros) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetNivel2() As DataSet
        Return mDb.ObtenerDataSetNivel2()
    End Function
    Public Function ObtenerDataSetNivel(ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerDataSetNivel(ccodigo)
    End Function
 
    Public Function Agregar(ByVal aEntidad As centros) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function Actualizar(ByVal aEntidad As centros) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerNombre(ByVal cCodsol As String) As String
        Return mDb.ObtenerNombre(cCodsol)
    End Function
    Public Function DataSetDoc1(ByVal cCodsol As String) As DataSet
        Return mDb.DataSetDoc1(cCodsol)
    End Function
    Public Function DataSetDoc2(ByVal cCodsol As String) As DataSet
        Return mDb.DataSetDoc2(cCodsol)
    End Function
End Class
