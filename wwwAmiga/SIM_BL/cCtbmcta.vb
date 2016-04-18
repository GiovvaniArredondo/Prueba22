Public Class cCtbmcta
#Region " Privadas "
    Private mDb As New dbCtbmcta()
    Private mEntidad As ctbmcta
#End Region

    Public Function ObtenerLista(ByVal ccodigo As String, ByVal ccadena As String) As listactbmcta
        Return mDb.ObtenerListaPorID(ccodigo, ccadena)
    End Function
    Public Function ObtenerListaPorID45(ByVal cCodigo As String) As listactbmcta
        Return mDb.ObtenerListaPorID45(cCodigo)
    End Function
    Public Function ObtenerLista1(ByVal cCodigo As String) As listactbmcta
        Return mDb.ObtenerListaPorID1(cCodigo)
    End Function

    Public Function ObtenerCtbmcta(ByRef mEntidad As ctbmcta) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCtbmcta(ByVal ccodcta As String) As Integer
        Dim mEntidad As New ctbmcta
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCtbmcta(ByVal aEntidad As ctbmcta) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerDataSetEsp(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp(cCodigo)
    End Function

    Public Function ObtenerDataSetEsp1(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp1(cCodigo)
    End Function

    Public Function ObtenerDataSetEsp2(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp2(cCodigo)
    End Function
    'Public Function ObtenerDataSetEsp3(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet
    '    Return mDb.ObtenerDataSetEsp3(cCodigo, cfondo, ccadena, ccodofi, cpoliza)
    'End Function
    Public Function ObtenerDataSetEsp3(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerDataSetEsp3(cCodigo, cfondo, ccadena, ccodofi)
    End Function
    'Public Function ObtenerDataSetEsp4(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet
    '    Return mDb.ObtenerDataSetEsp4(cCodigo, cfondo, ccadena, ccodofi, cpoliza)
    'End Function
    Public Function ObtenerDataSetEsp4(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerDataSetEsp4(cCodigo, cfondo, ccadena, ccodofi)
    End Function
    Public Function ObtenerDataSetEsp5(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet
        Return mDb.ObtenerDataSetEsp5(cCodigo, cfondo, ccadena)
    End Function
    Public Function ObtenerDataSetEsp6(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet
        Return mDb.ObtenerDataSetEsp6(cCodigo, cfondo, ccadena)
    End Function
    Public Function ObtenerDataSetEsp7(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp7(cCodigo)
    End Function
    Public Function ObtenerDataSetEsp8(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp8(cCodigo)
    End Function

    Public Function ObtenerDataSetEsp9(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet
        Return mDb.ObtenerDataSetEsp9(cCodigo, cfondo, ccadena)
    End Function


    'fran
    Public Function ObtenerLista2() As listactbmcta
        Return mDb.ObtenerListaPorID2()
    End Function
    Public Function ObtenerLista2a(ByVal ccodigo As String) As listactbmcta
        Return mDb.ObtenerListaPorID2a(ccodigo)
    End Function

    Public Function Agregar(ByVal aEntidad As ctbmcta) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorCuenta(ByVal pcCodCta As String, ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerDataSetPorCuenta(pcCodCta, ccodigo)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodigo)
    End Function
    Public Function ObtenerDataSetPorIDDet() As DataSet
        Return mDb.ObtenerDataSetPorIDDet()
    End Function
    Public Function ObtenerDataSetPorID2() As DataSet
        Return mDb.ObtenerDataSetPorID2()
    End Function
    Public Function ObtenerDataSetPorID3(ByVal pccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorID3(pccodcta)
    End Function
    Public Function ValidarCuenta(ByVal pccodcta As String) As Integer
        Return mDb.ValidarCuenta(pccodcta)
    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ObtenerDataSetEstado(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEstado(cCodigo)
    End Function
    Public Function ObtenerDataSetCuentas(ByVal cCodigo1 As String, ByVal cCodigo2 As String, ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetCuentas(cCodigo1, cCodigo2, cCodigo)
    End Function
    Public Function ObtenerDescripcionPorCuenta(ByVal cCodCta As String, ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerDescripcionPorCuenta(cCodCta, ccodigo)
    End Function
    Public Function saldoinicial(ByVal cCodcta As String) As Double
        Return mDb.saldoinicial(cCodcta)
    End Function

    Public Function ActualizarSaldos(ByVal ccodcta As String, ByVal nsalini As Double, ByVal cfondo As String) As Integer
        Return mDb.ActualizarSaldos(ccodcta, nsalini, cfondo)
    End Function

    Public Function EntradaCatalogo(ByVal cCodigo As String) As Integer
        Return mDb.EntradaCatalogo(cCodigo)
    End Function
    Public Function SalidaCatalogo(ByVal cCodigo As String) As Integer
        Return mDb.SalidaCatalogo(cCodigo)
    End Function

    Public Function PlantillaDataSet(ByVal cCodigo As String, ByVal cnivel As String) As DataSet
        Return mDb.PlantillaDataSet(cCodigo, cnivel)
    End Function
    Public Function PlantillaAux(ByVal ccodpla As String, ByVal cCodigo As String) As DataSet
        Return mDb.PlantillaAux(ccodpla, cCodigo)
    End Function
    Public Function Plantilla1(ByVal ccodtab As String) As DataSet
        Return mDb.Plantilla1(ccodtab)
    End Function
    Public Function CatalagoCombo() As DataSet
        Return mDb.CatalagoCombo()
    End Function
    'Public Function ObtenerDataSetEsp4a(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet
    '    Return mDb.ObtenerDataSetEsp4a(dfecini, dfecfin, cfondo, ccadena, ccodofi, cpoliza)
    'End Function
    Public Function ObtenerDataSetEsp4a(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerDataSetEsp4a(dfecini, dfecfin, cfondo, ccadena, ccodofi)
    End Function
    Public Function ObtieneNiveles() As DataSet
        Return mDb.ObtieneNiveles()
    End Function
    Public Function Modificar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Modificar(aEntidad)
    End Function
    Public Function ObtenerBusquedaCheque(ByVal cfondo As String, ByVal ccadena As String, ByVal cbanco As String, ByVal cnrochq As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal opcion As Integer, ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerBusquedaCheque(cfondo, ccadena, cbanco, cnrochq, dfecini, dfecfin, opcion, ccodigo)
    End Function
    Public Function ObtenerBusquedaPartidaBancaria(ByVal cfondo As String, ByVal ccadena As String, ByVal cbanco As String, ByVal cnrochq As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal opcion As Integer, ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerBusquedaPartidaBancaria(cfondo, ccadena, cbanco, cnrochq, dfecini, dfecfin, opcion, ccodigo)
    End Function
    Public Function PartidaFiltrada(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccodofi As String) As DataSet
        Return mDb.PartidaFiltrada(cCodigo, cfondo, ccodofi)
    End Function
    Public Function ObtieneCuentaCajaChica() As DataSet
        Return mDb.ObtieneCuentaCajaChica()
    End Function
    Public Function ObtieneAuxCta(ByVal ccodcta As String) As Decimal
        Return mDb.ObtieneAuxCta(ccodcta)
    End Function
    Public Function ObtieneCuentaCajaChica2(ByVal ccodofi As String) As DataSet
        Return mDb.ObtieneCuentaCajaChica2(ccodofi)
    End Function

    Public Function Extraer_Ctas_Ctb() As DataSet
        Return mDb.Extraer_Ctas_Ctb()
    End Function
End Class
