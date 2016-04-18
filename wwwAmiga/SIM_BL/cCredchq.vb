Public Class cCredchq
 
#Region " Privadas "
    Private mDb as New dbCredchq()
    Private mEntidad as Credchq
#End Region
 
    Public Function ObtenerLista() As listaCredchq
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCredchq(ByRef mEntidad As Credchq) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCredchq(ByVal ccodcta As String) As Integer
        Dim mEntidad As New Credchq
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCredchq(ByVal aEntidad As Credchq) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Agregar(ByVal aEntidad As credchq) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal pccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorID(pccodcta)
    End Function
    Public Function ObtenercredchqPorllave(ByRef mEntidad As credchq) As Integer
        Return mDb.Recuperarporllave(mEntidad)
    End Function
    Public Function VerificarPorID(ByVal pccodcta) As Integer
        Return mDb.VerificarPorID(pccodcta)
    End Function
    Public Function ObtieneCheques(ByVal cCodcta As String) As DataSet
        Return mDb.ObtieneCheques(cCodcta)
    End Function
    Public Function AgregaRegistro(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal cnomchq As String, ByVal nmonto As Double) As Integer
        Return mDb.AgregaRegistro(cCodcta, cnrodoc, cnomchq, nmonto)
    End Function
    Public Function ActualizaRegistro(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal cnomchq As String, ByVal nmonto As Double) As Integer
        Return mDb.ActualizaRegistro(cCodcta, cnrodoc, cnomchq, nmonto)
    End Function
    Public Function MaximoCheque(ByVal cCodcta As String) As String
        Return mDb.MaximoCheque(cCodcta)
    End Function
    Public Function QuitarUltimoCheque(ByVal cCodcta As String, ByVal cnrodoc As String) As Integer
        Return mDb.QuitarUltimoCheque(cCodcta, cnrodoc)
    End Function
    Public Function QuitarTodoslosCheques(ByVal cCodcta As String) As Integer
        Return mDb.QuitarTodoslosCheques(cCodcta)
    End Function
    Public Function MontodeCheques(ByVal cCodcta As String) As Double
        Return mDb.MontodeCheques(cCodcta)
    End Function

End Class
