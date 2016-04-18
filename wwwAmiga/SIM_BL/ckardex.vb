Public Class ckardex
#Region " Privadas "
    Private mDb As New dbkardex
    Private mEntidad As kardex
#End Region

    Public Function Obtenerkardex(ByRef mEntidad As kardex) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCredkar(ByVal ccodcta As String) As Integer
        Dim mEntidad As New credkar
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCredkar(ByVal aEntidad As credkar) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function agregarCredkar(ByVal aEntidad As credkar) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cconcep As String, ByVal cdescob As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcta, cnrodoc, cconcep, cdescob)
    End Function
    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByVal dfecsis As Date, ByVal cdescob As String, ByVal cnuming As String, ByVal cestado As String) As DataSet
        Return mDb.ObtenerDataSetPorID2(ccodcta, dfecsis, cdescob, cnuming, cestado)
    End Function

    Public Function ObtenerDataSetPorcuenta(ByVal ccodcta As String, ByVal cestado As String) As DataSet
        Return mDb.ObtenerDataSetPorcuenta(ccodcta, cestado)
    End Function
    Public Function ObtenerDataSetPorcuenta1(ByVal ccodcta As String, ByVal cestado As String, ByVal cnumdoc As String) As DataSet
        Return mDb.ObtenerDataSetPorcuenta1(ccodcta, cestado, cnumdoc)
    End Function
    Public Function ObtenerDataSetPorcuenta2(ByVal ccodcta As String, ByVal cestado As String, ByVal cnumdoc As String) As DataSet
        Return mDb.ObtenerDataSetPorcuenta2(ccodcta, cestado, cnumdoc)
    End Function
    Public Function ObtenerListakardexPorCuenta(ByVal ccodcta As String) As listakardex
        Return mDb.ObtenerListakardexPorCuenta(ccodcta)
    End Function
    Public Function ObtenerDataSetPorcuenta3(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cnumdoc As String) As DataSet
        Return mDb.ObtenerDataSetPorcuenta3(ccodcta, dfecha, cnumdoc)
    End Function
    Public Function ObtenerDatosparaRecibo(ByVal ccodcta As String, ByVal cnuming As String, ByVal cdescob As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerDatosparaRecibo(ccodcta, cnuming, cdescob, cnrodoc)
    End Function
End Class
