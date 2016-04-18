Public Class cCremsol

#Region " Privadas "
    Private mDb as New dbCremsol()
    Private mEntidad as Cremsol
#End Region
 
    Public Function ObtenerLista() As listaCremsol
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCremsol(ByRef mEntidad As Cremsol) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCremsol(ByVal cCodsol As String) As Integer
        Dim mEntidad As New Cremsol
        mEntidad.cCodsol = cCodsol
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCremsol(ByVal aEntidad As Cremsol) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetNivel2() As DataSet
        Return mDb.ObtenerDataSetNivel2()
    End Function
    Public Function ObtenerDataSetCentros() As DataSet
        Return mDb.ObtenerDataSetCentros()
    End Function
    Public Function ObtenerDataSetNivelGru(ByVal ccodigo As String, ByVal ccodcen As String, ByVal ctipmet As String, ByVal cCodofi As String) As DataSet
        Return mDb.ObtenerDataSetNivelGru(ccodigo, ccodcen, ctipmet, cCodofi)
    End Function
    Public Function Agregar(ByVal aEntidad As cremsol) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function Actualizar(ByVal aEntidad As cremsol) As Integer
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
    Public Function DataSetCentros(ByVal cCodcen As String) As DataSet
        Return mDb.DataSetCentros(cCodcen)
    End Function
    Public Function DataSetDoclegal(ByVal cCodsol As String) As DataSet
        Return mDb.DataSetDoclegal(cCodsol)
    End Function
    Public Function ObtenerNombrecentro(ByVal cCodsol As String) As String
        Return mDb.ObtenerNombreCentro(cCodsol)
    End Function
    Public Function ObtenerNombreCentro2(ByVal cCodsol As String) As String
        Return mDb.ObtenerNombreCentro2(cCodsol)
    End Function
    Public Function ReciboGrupal(ByVal ccodsol As String) As DataSet
        Return mDb.ReciboGrupal(ccodsol)
    End Function
    Public Function ReciboGrupal2(ByVal ccodsol As String) As DataSet
        Return mDb.ReciboGrupal2(ccodsol)
    End Function
    Public Function ReseteaBancoComunal(ByVal ccodsol As String) As Integer
        Return mDb.ReseteaBancoComunal(ccodsol)
    End Function
    Public Function ActualizaMiembro(ByVal ccodcli As String, ByVal ccodsol As String) As Integer
        Return mDb.ActualizaMiembro(ccodcli, ccodsol)
    End Function
    Public Function ListaMiembros(ByVal cCodsol As String) As DataSet
        Return mDb.ListaMiembros(cCodsol)
    End Function
    Public Function ObtenerDataSetNivelTodos(ByVal ccodigo As String, ByVal cCodofi As String) As DataSet
        Return mDb.ObtenerDataSetNivelTodos(ccodigo, cCodofi)
    End Function
    Public Function ObtenerDireccion(ByVal cCodsol As String) As String
        Return mDb.ObtenerDireccion(cCodsol)
    End Function
    Public Function VerificaDuplicidad(ByVal cCodcli As String, ByVal cCodsol As String) As Boolean
        Return mDb.VerificaDuplicidad(cCodcli, cCodsol)
    End Function
    Public Function VerificaDuplicidad2(ByVal cCodcli As String, ByVal cCodsol As String) As Boolean
        Return mDb.VerificaDuplicidad2(cCodcli, cCodsol)
    End Function
    Public Function ObtieneCodigoxNombre(ByVal cCodsol As String, ByVal Nombre As String, ByVal ccodofi As String) As Boolean
        Return mDb.ObtieneCodigoxNombre(cCodsol, Nombre, ccodofi)
    End Function
    Public Function ObtenerCicloGrupo(ByVal ccodsol As String, ByVal dfecha As Date) As Integer
        Return mDb.ObtenerCicloGrupo(ccodsol, dfecha)
    End Function
    Public Function VerificaGrupoActivo(ByVal cCodsol As String, ByVal cCodofi As String) As Boolean
        Return mDb.VerificaGrupoActivo(cCodsol, cCodofi)
    End Function
    Public Function Datos_Miembros_Grupo(ByVal pcCodsol As String) As DataSet
        Return mDb.Datos_Miembros_Grupo(pcCodsol)
    End Function

    Public Function Datos_Miembros_Contrato(ByVal pcCodsol As String, ByVal pcCodcli As String) As DataSet
        Return mDb.Datos_Miembros_Contrato(pcCodsol, pcCodcli)
    End Function
End Class
