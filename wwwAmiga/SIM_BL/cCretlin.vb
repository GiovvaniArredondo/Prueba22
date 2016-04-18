Public Class cCretlin
 
#Region " Privadas "
    Private mDb as New dbCretlin()
    Private mEntidad as Cretlin
#End Region
 
    Public Function ObtenerLista() As listaCretlin
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCretlin(ByRef mEntidad As Cretlin) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
    Public Function ObtenerCretlinPorllave(ByRef mEntidad As cretlin) As Integer
        Return mDb.Recuperarporllave(mEntidad)
    End Function

    Public Function EliminarCretlin(ByRef mEntidad As cretlin) As Integer
        '  Dim mEntidad As New cretlin
        '     mEntidad.cnrolin = cnrolin
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCretlin(ByVal aEntidad As cretlin) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function AGREGAR(ByVal aEntidad As cretlin) As Integer
        Return mDb.Agregar(aEntidad)
    End Function


    Public Function ObtenerListaPorLinea(ByVal linea As String) As listacretlin
        Return mDb.ObtenerListaPorLinea(linea)
    End Function

    Public Function Obtenernrolin() As String
        Return mDb.Obtenernrolin()
    End Function

    Public Function ObtenerDataSetPorcuena2() As DataSet
        Return mDb.ObtenerDataSetPorcuena2()
    End Function

    Public Function ObtenerDataSetPorcuena(ByVal pcnrolin As String) As DataSet
        Return mDb.ObtenerDataSetPorcuena(pcnrolin)
    End Function

    Public Function ObtenerFuentedeFondos(ByVal pcnrolin As String) As String
        Return mDb.ObtenerFuentedeFondos(pcnrolin)
    End Function
    Public Function RecuperarporFuente(ByVal cCodfue As String, ByVal ctipo As String) As DataSet
        Return mDb.RecuperarporFuente(cCodfue, ctipo)
    End Function

    Public Function ObtieneLineaGrupo(ByVal cCodsol As String, ByVal dfecvig As Date) As String
        Return mDb.ObtieneLineaGrupo(cCodsol, dfecvig)
    End Function
    Public Function ObtenerFuentedeFondosCodigo(ByVal pcnrolin As String) As String
        Return mDb.ObtenerFuentedeFondosCodigo(pcnrolin)
    End Function
    Public Function ObtieneLinea(ByVal cnrolin As String) As String
        Return mDb.ObtieneLinea(cnrolin)
    End Function
    Public Function ObtieneCodigoLinea(ByVal cnrolin As String) As String
        Return mDb.ObtieneCodigoLinea(cnrolin)
    End Function
    Public Function ObtieneCodigoLineadecredito(ByVal ccodcta As String) As String
        Return mDb.ObtieneCodigoLineadecredito(ccodcta)
    End Function
    Public Function ObtenerListaTodas() As listacretlin
        Return mDb.ObtenerListaPorIDTodas()
    End Function
    Public Function VericasiestaActivada(ByVal cnrolin As String) As Boolean
        Return mDb.VericasiestaActivada(cnrolin)
    End Function
    Public Function RecuperarporCartera(ByVal cTipo As String, ByVal metodo As String, ByVal ccodfue As String) As DataSet
        Return mDb.RecuperarporCartera(cTipo, metodo, ccodfue)
    End Function
    Public Function ObtieneNroLineaCredito(ByVal cCodcta As String) As String
        Return mDb.ObtieneNroLineaCredito(cCodcta)
    End Function
    Public Function RecuperarporFuenteTodos(ByVal cCodfue As String, ByVal cTipo As String) As DataSet
        Return mDb.RecuperarporFuenteTodos(cCodfue, cTipo)
    End Function
    Public Function ObtenerTasaEstandar(ByVal cnrolin As String) As Decimal
        Return mDb.ObtenerTasaEstandar(cnrolin)
    End Function
    Public Function ObtenerTasaMinima(ByVal cnrolin As String) As Decimal
        Return mDb.ObtenerTasaMinima(cnrolin)
    End Function
    Public Function ObtenerTasaMaxima(ByVal cnrolin As String) As Decimal
        Return mDb.ObtenerTasaMaxima(cnrolin)
    End Function
    Public Function ObtenerProducto(ByVal programa As String, ByVal metodo As String) As DataSet
        Return mDb.ObtenerProducto(programa, metodo)
    End Function
    Public Function Verifica_Linea_Revolvente(ByVal ccodcta As String) As Boolean
        Return mDb.Verifica_Linea_Revolvente(ccodcta)
    End Function

    Public Function Recuperarpor_Metodo(ByVal metodo As String) As DataSet
        Return mDb.Recuperarpor_Metodo(metodo)
    End Function
    Public Function UpdateCremcre(ByVal ccodcta As String, ByVal nmonsug As Integer) 
        Return mDb.UpdateCremcre(ccodcta, nmonsug)
    End Function
End Class
