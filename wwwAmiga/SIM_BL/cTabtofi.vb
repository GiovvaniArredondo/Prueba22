Public Class cTabtofi
 
#Region " Privadas "
    Private mDb as New dbTabtofi()
    Private mEntidad as Tabtofi
#End Region
 
    Public Function ObtenerLista() As listaTabtofi
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerListaporNivel(ByVal nNivel As Integer, ByVal cOficina As String) As listatabtofi
        Return mDb.ObtenerlistaporNivel(nNivel, cOficina)
    End Function
    Public Function ObtenerListaporNivel2(ByVal nNivel As Integer, ByVal cOficina As String) As listatabtofi
        Return mDb.ObtenerlistaporNivel2(nNivel, cOficina)
    End Function
    Public Function ObtenerTabtofi(ByRef mEntidad As tabtofi) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarTabtofi(ByVal ccodins As String) As Integer
        Dim mEntidad As New tabtofi
        mEntidad.ccodins = ccodins
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabtofi(ByVal aEntidad As tabtofi) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerDataSetPorID() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function
    Public Function OficinaCtb(ByVal ccodofi) As String
        Return mDb.OficinaCtb(ccodofi)
    End Function
    Public Function ObtenerDataSetPorNivel(ByVal nNivel As Integer, ByVal cOficina As String) As DataSet
        Return mDb.ObtenerDataSetPorNivel(nNivel, cOficina)
    End Function
    Public Function ObtenerDataSetPorNivel2(ByVal nNivel As Integer, ByVal cOficina As String) As DataSet
        Return mDb.ObtenerDataSetPorNivel2(nNivel, cOficina)
    End Function
    Public Function NombreAgencia(ByVal ccodofi As String) As String
        Return mDb.NombreAgencia(ccodofi)
    End Function
    Public Function ActualizaValidacion(ByVal cCodofi As String, ByVal lvalcie As Boolean) As Integer
        Return mDb.ActualizaValidacion(cCodofi, lvalcie)
    End Function
    Public Function CargaAgenciaChk()
        Return mDb.CargaAgenciaChk()
    End Function
    Public Function ReseteaValidador() As Integer
        Return mDb.ReseteaValidador()
    End Function
    Public Function NombreDepartamento(ByVal ccodofi As String) As String
        Return mDb.NombreDepartamento(ccodofi)
    End Function
    Public Function NombreMunicipio(ByVal ccodofi As String) As String
        Return mDb.NombreMunicipio(ccodofi)
    End Function
    Public Function NombreDireccion(ByVal ccodofi As String) As String
        Return mDb.NombreDireccion(ccodofi)
    End Function
    Public Function ObtieneCorrelativo(ByVal cCodofi As String) As String
        Return mDb.ObtieneCorrelativo(cCodofi)
    End Function
    Public Function ActualizaCorrelativo(ByVal cCodofi As String, ByVal cnuevo As String) As Integer
        Return mDb.ActualizaCorrelativo(cCodofi, cnuevo)
    End Function
    Public Function OficinaAux(ByVal lcCodofi As String) As String
        Return mDb.OficinaAux(lcCodofi)
    End Function
    Public Function VerificaValidacionAgencia(ByVal ccodofi As String) As Boolean
        Return mDb.VerificaValidacionAgencia(ccodofi)
    End Function
    Public Function ObtenerOficinasdeRegion(ByVal ccodins As String, ByVal ccodofi As String, ByVal nnivel As Integer) As DataSet
        Return mDb.ObtenerOficinasdeRegion(ccodins, ccodofi, nnivel)
    End Function
    Public Function ObtenerRegiondeUsuario(ByVal ccodusu As String) As String
        Return mDb.ObtenerRegiondeUsuario(ccodusu)
    End Function
    Public Function ObtenerRegiondeOficina(ByVal ccodofi As String) As String
        Return mDb.ObtenerRegiondeOficina(ccodofi)
    End Function
    Public Function ValidaEstadoAgencia(ByVal cCodofi As String) As String
        Return mDb.ValidaEstadoAgencia(cCodofi)
    End Function
    Public Function ObtenerOficinaPrestamo(ByVal ccodcta As String) As String
        Return mDb.ObtenerOficinaPrestamo(ccodcta)
    End Function

    Public Function ObtenerNombreOficina(ByVal ccodofi As String) As String
        Return mDb.ObtenerNombreOficina(ccodofi)
    End Function
End Class
