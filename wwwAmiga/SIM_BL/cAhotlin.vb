Public Class cAhotlin
 
#Region " Privadas "
    Private mDb as New dbAhotlin()
    Private mEntidad as Ahotlin
#End Region
 
    Public Function ObtenerLista() As listaAhotlin
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerAhotlin(ByRef mEntidad As Ahotlin) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarAhotlin(ByVal cnrolin As String) As Integer
        Dim mEntidad As New Ahotlin
        mEntidad.cnrolin = cnrolin
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarAhotlin(ByVal aEntidad As Ahotlin) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtieneLineaAhorro(ByVal ctipo As String) As String
        Return mDb.ObtieneLineaAhorro(ctipo)
    End Function

    Public Function ObtieneLineaAhorro_ID(ByVal cdescri As String) As DataSet
        Return mDb.ObtieneLineaAhorro_ID(cdescri)
    End Function

    Public Function ObtenerLista_PorTipo(ByVal ctipAho As String) As listaahotlin
        Return mDb.ObtenerLista_PorTipo(ctipAho)
    End Function

    Public Function Extraer_Lineas_Producto(ByVal producto As String) As DataSet
        Return mDb.Extraer_Lineas_Producto(producto)
    End Function

    Public Function Mantenimiento_Lineas(ByVal array_d As ArrayList) As Integer
        Return mDb.Mantenimiento_Lineas(array_d)
    End Function

    Public Function ObtenerLista_Depo() As listaahotlin
        Return mDb.ObtenerListaPorID_()
    End Function

    Public Function ObtenerListaTodos() As listaahotlin
        Return mDb.ObtenerListaTodos()
    End Function
End Class
