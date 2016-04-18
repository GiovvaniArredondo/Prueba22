Public Class cCntamov
 
#Region " Privadas "
    Private mDb As New dbCntamov()
    Private mEntidad As cntamov
#End Region

    Public Function ObtenerLista(ByVal cnumcom As String) As listacntamov
        Return mDb.ObtenerListaPorID(cnumcom)
    End Function

    Public Function ObtenerCntamov(ByRef mEntidad As cntamov) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCntamov(ByVal ccodsec As String) As Integer
        Dim mEntidad As New cntamov
        mEntidad.ccodsec = ccodsec
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCntamov(ByVal aEntidad As cntamov) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function agregarCntamov(ByVal aEntidad As cntamov) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function BusquedaporCuenta(ByVal aEntidad As cntamov) As Integer
        Return mDb.BusquedaporCuenta(aEntidad)
    End Function
    'fran
    Public Function ObtenerDataSetPorCuenta1(ByVal pcCodcta, ByVal pdFecIni, ByVal pdFecFin) As DataSet
        Return mDb.ObtenerDataSetPorCuenta1(pcCodcta, pdFecIni, pdFecFin)
    End Function
    Public Function ObtenerlistaConsCtas(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal ccodigo As String, ByVal ccadena As String) As DataSet
        Return mDb.ObtenerlistaConsCtas(pdFecIni, pdFecFin, ccodigo, ccadena)
    End Function
    Public Function ObtenerLibroDiarioMayor(ByVal pdFecIni As Date, ByVal pdFecFin As Date) As DataSet
        Return mDb.ObtenerLibroDiarioMayor(pdFecIni, pdFecFin)
    End Function
    Public Function ObtenerSaldosIni(ByVal pdFecIni As Date, ByVal pdFecFin As Date) As DataSet
        Return mDb.ObtenerSaldosIni(pdFecIni, pdFecFin)
    End Function
    Public Function ObtenerSaldosIniporCuenta(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcCodCta As String) As DataSet
        Return mDb.ObtenerSaldosIniPorCuenta(pdFecIni, pdFecFin, pcCodCta)
    End Function
    Public Function ObtenerLibroMayor(ByVal pdFecIni As Date, ByVal pdFecFin As Date) As DataSet
        Return mDb.ObtenerLibroMayor(pdFecIni, pdFecFin)
    End Function
    Public Function ObtenerMov(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pdFecIniper As Date, ByVal pdFecFinper As Date, ByVal pccodcta As String) As DataSet
        Return mDb.ObtenerMov(pdFecIni, pdFecFin, pdFecIniper, pdFecFinper, pccodcta)
    End Function
    Public Function CuentaSuperior(ByVal pcCodcta As String) As DataSet
        Return mDb.CuentaSuperior(pcCodcta)
    End Function
    'saldos iniciales y finales para cualquier cuenta
    Public Function ObtenerSaldosPorCuenta(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet
        Return mDb.ObtenerSaldosPorCuenta(pdFecIni, pdFecFin, pcCodCta, lnnivel, lcnomser, lccodofi, lcfuente)
    End Function
    Public Function ObtenerSaldosPorCuenta1(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet
        Return mDb.ObtenerSaldosPorCuenta1(pdFecIni, pdFecFin, pcCodCta, lnnivel, lcnomser, lccodofi, lcfuente)
    End Function
    Public Function ObtenerSaldosPorCuenta3(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
        Return mDb.ObtenerSaldosPorCuenta3(pdFecIni, pdFecFin, pcCodCta, lnnivel, lcnomser, lccodofi, lcfuente, ccadena, lccierre)
    End Function
    Public Function ObtenerSaldosPorCuenta4(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal lccadena As String, ByVal lccierre As String) As DataSet
        Return mDb.ObtenerSaldosPorCuenta4(pdFecIni, pdFecFin, pcCodCta, lnnivel, lcnomser, lccodofi, lcfuente, lccadena, lccierre)
    End Function
    Public Function ObtenerSaldosPorCuenta5(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet
        Return mDb.ObtenerSaldosPorCuenta5(pdFecIni, pdFecFin, lcnomser, lccodofi, lcfuente)
    End Function
    'funcion exclusiva para cierres
    Public Function Obtener_Saldos_fondos_oficina(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal lcfondo As String, ByVal lcoficina As String) As DataSet
        Return mDb.Obtener_Saldos_fondos_oficina(pdFecIni, pdFecFin, lcfondo, lcoficina)
    End Function


    'listado de partidas
    Public Function Obtenerlistado_Partidas(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String) As DataSet
        Return mDb.Obtenerlistado_Partidas(pdFecIni, pdFecFin, lcnomser, lccodofi, lcfuente)
    End Function

    Public Function movimientos_por_cuenta(ByVal pdFecIni As Date, ByVal pdFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String) As DataSet
        Return mDb.movimientos_por_cuenta(pdFecIni, pdFecFin, pcCodCta, lnnivel, lcnomser)
    End Function
    Public Function ObtenerAuxiliar(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal lccadena As String) As DataSet
        Return mDb.ObtenerAuxiliar(dfecIni, dFecFin, lccodcta, lccodofi, lcfuente, lccadena)
    End Function
    Public Function sumasporcuenta(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lcfuente As String, ByVal ccadena As String) As DataSet
        Return mDb.sumasporcuenta(dfecIni, dFecFin, lccodcta, lnnivel, lcnomser, lcfuente, ccadena)
    End Function
    Public Function Cuentaslibro(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lccodcta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodcta1 As String, ByVal lcfuente As String, ByVal lccodofi As String, ByVal ccadena As String) As DataSet
        Return mDb.Cuentaslibro(dfecIni, dFecFin, lccodcta, lnnivel, lcnomser, lccodcta1, lcfuente, lccodofi, ccadena)
    End Function
    Public Function EliminarDetalle(ByVal aEntidad As entidadBase) As Integer
        Return mDb.EliminarDetalle(aEntidad)
    End Function
    Public Function ObtieneChequeporCredito(ByVal cCodpres As String, ByVal dfecha As Date) As String
        Return mDb.ObtieneChequeporCredito(cCodpres, dfecha)
    End Function
    Public Function listadodepartidasConsolidadas(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String) As DataSet
        Return mDb.listadodepartidasConsolidadas(dfecini, dfecfin, ccodofi, cfuente)
    End Function
    Public Function listadodepartidas(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String) As DataSet
        Return mDb.listadodepartidas(dfecini, dfecfin, ccodofi, cfuente)
    End Function
    Public Function ObtieneOtrosIngresos(ByVal cCodcli As String, ByVal cnumdoc As String) As DataSet
        Return mDb.ObtieneOtrosIngresos(cCodcli, cnumdoc)
    End Function
    Public Function ValidaNumeroRemesa(ByVal cCodcta As String, ByVal cnumdoc As String) As Boolean
        Return mDb.ValidaNumeroRemesa(cCodcta, cnumdoc)
    End Function
    Public Function DataConciliar(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cpoliza As String, ByVal ccodcta As String) As DataSet
        Return mDb.DataConciliar(dfecini, dfecfin, cpoliza, ccodcta)
    End Function
Public Function BuscaPolizaOtrosIngresos(ByVal ccodcli As String, ByVal boleta As String, ByVal Tipo As String, ByVal Recibo As String) As DataSet
        Return mDb.BuscaPolizaOtrosIngresos(ccodcli, boleta, Tipo, Recibo)
    End Function

    Public Function VerificarReversionOtrosIngresos(ByVal ccodcli As String, ByVal boleta As String, ByVal Tipo As String) As Integer
        Return mDb.VerificarReversionOtrosIngresos(ccodcli, boleta, Tipo)
    End Function
    Public Function EsPolizaOtrosIngresos(ByVal boleta As String) As DataSet
        Return mDb.EsPolizaOtrosIngresos(boleta)
    End Function
    Public Function BuscaPolizaReversadaOtrosIngresosParaImpresion(ByVal ccodcli As String, ByVal boleta As String, ByVal Tipo As String) As DataSet
        Return mDb.BuscaPolizaReversadaOtrosIngresosParaImpresion(ccodcli, boleta, Tipo)
    End Function
    Public Function VerificaChequeProveedor(ByVal cnumcom As String) As Boolean
        Return mDb.VerificaChequeProveedor(cnumcom)
    End Function
    Public Function ObtenerCuerpoPartida(ByVal cnumcom As String) As DataSet
        Return mDb.ObtenerCuerpoPartida(cnumcom)
    End Function
    'Public Function ObtenerSaldosIniciales(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
    '    Return mDb.ObtenerSaldosIniciales(dfecIni, dFecFin, pcCodCta, lnnivel, lcnomser, lccodofi, lcfuente, ccadena, lccierre)
    'End Function
    Public Function ObtieneNroCheque(ByVal ccodpres As String, ByVal dfecha As Date) As String
        Return mDb.ObtieneNroCheque(ccodpres, dfecha)
    End Function
    Public Function Obtenerresumendetalle(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String) As DataSet
        Return mDb.Obtenerresumendetalle(ccodofi, cfuente, dfecini, dfecfin, ccadena, dfecinicial, lccierre)
    End Function
    Public Function Obtenerresumendetalle2(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String) As DataSet
        Return mDb.Obtenerresumendetalle2(ccodofi, cfuente, dfecini, dfecfin, ccadena, dfecinicial, lccierre)
    End Function
    Public Function ObtenerSaldoPartidaInicial(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String, ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerSaldoPartidaInicial(ccodofi, cfuente, dfecini, dfecfin, ccadena, dfecinicial, lccierre, ccodcta)
    End Function
    Public Function ObtenerSaldoInicial(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String, ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerSaldoInicial(ccodofi, cfuente, dfecini, dfecfin, ccadena, dfecinicial, lccierre, ccodcta)
    End Function
    Public Function ObtenerMovPeriodo(ByVal ccodofi As String, ByVal cfuente As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccadena As String, ByVal dfecinicial As Date, ByVal lccierre As String, ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerMovPeriodo(ccodofi, cfuente, dfecini, dfecfin, ccadena, dfecinicial, lccierre, ccodcta)
    End Function
    Public Function ObtenerPartidadePago(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cpoliza As String) As DataSet
        Return mDb.ObtenerPartidadePago(ccodcta, cnrodoc, cpoliza)
    End Function
    Public Function ObtenerPartidadePagoIngresoAjuste(ByVal ccodcta As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerPartidadePagoIngresoAjuste(ccodcta, cnrodoc)
    End Function
    Public Function GeneraDatosConta(ByVal dfeccnt As Date) As DataSet
        Return mDb.GeneraDatosConta(dfeccnt)
    End Function
    Public Function ObtieneCargosBancarios(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodcta As String) As Double
        Return mDb.ObtieneCargosBancarios(dfecha1, dfecha2, ccodcta)
    End Function
    Public Function ObtieneAbonosBancarios(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodcta As String) As Double
        Return mDb.ObtieneAbonosBancarios(dfecha1, dfecha2, ccodcta)
    End Function
    Public Function Obtener_Saldos_fondos_oficina_CuentasdeResultado(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal lcfondo As String, ByVal lcoficina As String) As DataSet
        Return mDb.Obtener_Saldos_fondos_oficina_CuentasdeResultado(dfecIni, dFecFin, lcfondo, lcoficina)
    End Function
    Public Function ObtenerSaldosIniciales(ByVal dfecIni As Date, ByVal dFecFin As Date, ByVal pcCodCta As String, ByVal lnnivel As Integer, ByVal lcnomser As String, ByVal lccodofi As String, ByVal lcfuente As String, ByVal ccadena As String, ByVal lccierre As String) As DataSet
        Return mDb.ObtenerSaldosIniciales(dfecIni, dFecFin, pcCodCta, lnnivel, lcnomser, lccodofi, lcfuente, ccadena, lccierre)
    End Function
    Public Function ValidaUltimaFechaDeLiquidacion(ByVal ccodofi As String, ByVal fecha As Date) As Boolean
        Return mDb.ValidaUltimaFechaDeLiquidacion(ccodofi, fecha)
    End Function
    Public Function AgregarAuxiliarCaja(ByVal aEntidad As entidadBase) As Integer
        Return mDb.AgregarAuxiliarCaja(aEntidad)
    End Function
    Public Function Obtenermovcajachica(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String, ByVal ccodenc As String) As DataSet
        Return mDb.Obtenermovcajachica(dfecini, dfecfin, ccodofi, cfuente, ccodenc)
    End Function
    Public Function DataParaLiquidarCajaChica(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As DataSet
        Return mDb.DataParaLiquidarCajaChica(dfecini, dfecfin, ccodofi)
    End Function

    Public Function ObtenermovcajachicaImpresion(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String, ByVal cfuente As String, ByVal ccodenc As String) As DataSet
        Return mDb.ObtenermovcajachicaImpresion(dfecini, dfecfin, ccodofi, cfuente, ccodenc)
    End Function

    Public Function ObtenerEfectivoCajaChicaAgencia(ByVal ccodofi As String) As Double
        Return mDb.ObtenerEfectivoCajaChicaAgencia(ccodofi)
    End Function

    Public Function ObtenerCajaChicaConsolidado(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal laplcon As String, ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerCajaChicaConsolidado(dfecini, dfecfin, laplcon, ccodofi)
    End Function
    Public Function ActualizaNOLiquidadoCC(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As Integer
        Return mDb.ActualizaNOLiquidadoCC(dfecini, dfecfin, ccodofi)
    End Function
    Public Function ActualizaLiquidadoCC(ByVal cnumcom As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal ccodofi As String) As Integer
        Return mDb.ActualizaLiquidadoCC(cnumcom, dfecini, dfecfin, ccodofi)
    End Function
    Public Function ObtenerAuxiliarCajaPorId(ByRef aEntidad As entidadBase) As Integer
        Return mDb.ObtenerAuxiliarCajaPorId(aEntidad)
    End Function
    Public Function ActualizarAuxiliarCaja(ByVal aEntidad As entidadBase) As Integer
        Return mDb.ActualizarAuxiliarCaja(aEntidad)
    End Function
    Public Function ObtieneMontoAutorizadoCajaChicaOficina(ByVal ccodofi As String) As Decimal
        Return mDb.ObtieneMontoAutorizadoCajaChicaOficina(ccodofi)
    End Function

    Public Function ObtieneNumeroPartidaporCredito(ByVal cCodpres As String, ByVal dfecha As Date) As String
        Return mDb.ObtieneNumeroPartidaporCredito(cCodpres, dfecha)
    End Function

    Public Function Extrae_Partida_Diario(ByVal pcnumcom As String, ByVal ccadena As String) As DataSet
        Return mDb.Extrae_Partida_Diario(pcnumcom, ccadena)
    End Function
End Class
