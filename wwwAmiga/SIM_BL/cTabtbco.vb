Public Class cTabtbco
 
#Region " Privadas "
    Private mDb as New dbTabtbco()
    Private mEntidad as Tabtbco
#End Region
 
    Public Function ObtenerLista() As listaTabtbco
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerTabtbco(ByRef mEntidad As Tabtbco) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarTabtbco(ByVal ccodbco As String) As Integer
        Dim mEntidad As New Tabtbco
        mEntidad.ccodbco = ccodbco
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarTabtbco(ByVal aEntidad As Tabtbco) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    '    ObtenerDataSetPorID
    Public Function ObtenerDatasetporid(ByRef dstmp As DataSet, ByVal ccodofi As String) As Integer
        Return mDb.ObtenerDataSetPorID(dstmp, ccodofi)
    End Function

    Public Function ObtenerDataSetPorID_Oficina_Tipo(ByRef ds As DataSet, ByVal ccodofi As String, _
                                                     ByVal pctipo As String) As Integer
        Return mDb.ObtenerDataSetPorID_Oficina_Tipo(ds, ccodofi, pctipo)
    End Function

    Public Function ObtenerDatasetporidtodos(ByRef dstmp As DataSet, ByVal ccodofi As String, ByVal cgrupo As String) As Integer
        Return mDb.ObtenerDataSetPorIDTodos(dstmp, ccodofi, cgrupo)
    End Function
    Public Function ObtenerDatasetporidtodos2(ByRef dstmp As DataSet, ByVal ccodofi As String) As Integer
        Return mDb.ObtenerDataSetPorIDTodos2(dstmp, ccodofi)
    End Function
    Public Function CuentadeBanco(ByVal ccodbco As String) As String
        Return mDb.CuentadeBanco(ccodbco)
    End Function
    Public Function maxbanco() As String
        Return mDb.maxbanco()
    End Function
    Public Function Agregar(ByVal aEntidad As tabtbco) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function NombredeBanco(ByVal ccodbco As String) As String
        Return mDb.NombredeBanco(ccodbco)
    End Function
    Public Function RetornaCheque(ByVal ccodbco As String) As String
        Return mDb.RetornaCheque(ccodbco)
    End Function
    Public Function CuentadeBanco1(ByVal ccodbco As String) As String
        Return mDb.CuentadeBanco1(ccodbco)
    End Function
    Public Function ActualizaCorrelativo(ByVal cCodbco As String, ByVal cnrochq As String) As Integer
        Return mDb.ActualizaCorrelativo(cCodbco, cnrochq)
    End Function
    Public Function CuentadeBancoContable(ByVal ccodbco As String) As String
        Return mDb.CuentadeBancoContable(ccodbco)
    End Function
    Public Function CuentaContableBanco(ByVal cCodbco As String) As String
        Return mDb.CuentaContableBanco(cCodbco)
    End Function
    Public Function ObtenerBancosenUso(ByRef ds As DataSet, ByVal ccodofi As String) As Integer
        Return mDb.ObtenerBancosenUso(ds, ccodofi)
    End Function
    Public Function FondodeCuentaBancaria(ByVal ccodbco As String) As String
        Return mDb.FondodeCuentaBancaria(ccodbco)
    End Function
    Public Function ObtenerBancos() As DataSet
        Return mDb.ObtenerBancos()
    End Function
    Public Function ActualizaSaldos(ByVal ccodbco As String, ByVal nsaldo As Double, ByVal ncargos As Double, ByVal nabonos As Double) As Integer
        Return mDb.ActualizaSaldos(ccodbco, nsaldo, ncargos, nabonos)
    End Function
    Public Function ActualizaSaldosiniciales()
        Return mDb.ActualizaSaldosiniciales()
    End Function
    Public Function UltimoBancoIngresado() As String
        Return mDb.UltimoBancoIngresado()
    End Function
    Public Function ObtenerCuentaDocumento(ByVal ccodbco As String) As String
        Return mDb.ObtenerCuentaDocumento(ccodbco)
    End Function

    Public Function ObtenerCuenta_Oficina(ByVal ccodofi As String, ByVal pctipo As String) As String
        Return mDb.ObtenerCuenta_Oficina(ccodofi, pctipo)
    End Function

    Public Function Extrae_Bancos() As DataSet
        Return mDb.Extrae_Bancos()
    End Function

    Public Function Extrae_Ctas_Bancarias(ByVal pcCodbco As String) As DataSet
        Return mDb.Extrae_Ctas_Bancarias(pcCodbco)
    End Function

    Public Function Extrae_Bancos_Oficinas() As DataSet
        Return mDb.Extrae_Bancos_Oficinas()
    End Function
End Class
