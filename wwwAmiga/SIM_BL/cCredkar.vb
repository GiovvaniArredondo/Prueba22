Imports System.Data.SqlClient
Public Class cCredkar

#Region " Privadas "
    Private mDb As New dbCredkar()
    Private mEntidad As credkar
#End Region

    Public Function ObtenerLista(ByVal ccodcta As String, ByVal cnrodoc As String, ByVal cconcep As String, ByVal cdescob As String) As listacredkar
        Return mDb.ObtenerListaPorID(ccodcta, cnrodoc, cconcep, cdescob)
    End Function

    Public Function ObtenerCredkar(ByRef mEntidad As credkar) As Integer
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
    Public Function obtenercnrodoc(ByVal pccodcta As String) As String
        Return mDb.Obtenercnrodoc(pccodcta)
    End Function

    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String) As listacredkar
        Return mDb.ObtenerListaPorCuenta(ccodcta)
    End Function
    Public Function Obtenerdatasetporid(ByVal ccodcta As String, ByVal cnuming As String, ByVal cdescob As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcta, cnuming, cdescob)
    End Function
    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByVal cnuming As String, ByVal cdescob As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerDataSetPorID2(ccodcta, cnuming, cdescob, cnrodoc)
    End Function

    Public Function Obtenerdatasetporid1(ByVal ccodcta As String, ByVal cdescob As String, ByVal cestado As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerDataSetPorID1(ccodcta, cdescob, cestado, cnrodoc)
        'Return mDb.DataSetPorID2(ccodcta, cdescob, cestado)
    End Function

    Public Function ObtenerListafecha(ByVal ccodcta As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal cdescob As String) As listacredkar
        Return mDb.ObtenerListafecha(ccodcta, dfecha1, dfecha2, cdescob)
    End Function

    'obtiene lista por ccodcta y cnuming
    Public Function ObtenerListacnuming(ByVal ccodcta As String, ByVal cnuming As String) As listacredkar
        Return mDb.ObtenerListacnuming(ccodcta, cnuming)
    End Function



    Public Function ActualizarCredkar1(ByVal aEntidad As credkar) As Integer
        Return mDb.Actualizar1(aEntidad)
    End Function


    Public Function ActualizarCredkar2(ByVal aEntidad As credkar) As Integer
        Return mDb.Actualizar2(aEntidad)
    End Function

    Public Function ObtenerDataSetPorunacuenta(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorunacuenta(ccodcta)
    End Function

    Public Function Eliminar_pagos(ByVal ccodcta As String, ByVal ldfecha As Date) As Integer
        Return mDb.Eliminar_pagos(ccodcta, ldfecha)
    End Function

    'actualiza monto desembolsado de credkar, unicamente cuando es cambio de pagos flat
    Public Function Actualizar_monto(ByVal ccodcta, ByVal nmonto, ByVal ldfecvig) As Integer
        Return mDb.Actualizar_monto(ccodcta, nmonto, ldfecvig)
    End Function

    Public Function obtenerdatasetkarflat(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet
        Return mDb.obtenerdatasetkarflat(ccodcta, ldfecha)
    End Function

    'funcion unicamente para plan de pagos flat habitat el salvador
    Public Function ObtenerDataSetkardexflat(ByVal ccodcta As String, ByVal ldfecha As Date) As DataSet
        Return mDb.ObtenerDataSetkardexflat(ccodcta, ldfecha)
    End Function

    Public Function DataSetPorcuenta_fecha(ByVal ccodcta As String, ByVal dfecha As Date) As DataSet
        Return mDb.DataSetPorcuenta_fecha(ccodcta, dfecha)
    End Function
    Public Function ResumenKardex(ByVal dfecha As Date, ByVal ccodusu As String) As DataSet
        Return mDb.ResumenKardex(dfecha, ccodusu)
    End Function
    Public Function CapitalPagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.CapitalPagado(ccodcta, dfecha)
    End Function
    Public Function UltimafechaProceso(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Return mDb.UltimafechaProceso(ccodcta, dfecha)
    End Function
    Public Function kardexplus(ByVal pccodcta As String, ByVal pdfecha As Date) As DataTable
        Return mDb.kardexplus(pccodcta, pdfecha)
    End Function
    Public Function KardexPagado(ByVal pccodcta As String) As DataSet
        Return mDb.KardexPagado(pccodcta)
    End Function
    Public Function KardexPagado2(ByVal pccodcta As String) As DataSet
        Return mDb.KardexPagado2(pccodcta)
    End Function

    Public Function fxCalifica(ByVal cCodcta As String) As String
        Return mDb.fxCalifica(cCodcta)
    End Function
    Public Function VerificaBoleta(ByVal cCodbco As String, ByVal cnuming As String) As Boolean
        Return mDb.VerificaBoleta(cCodbco, cnuming)
    End Function
    Public Function Obtenercnrodocmax(ByVal ccodcta As String) As String
        Return mDb.Obtenercnrodocmax(ccodcta)
    End Function
    Public Function ObtenercnrodocmaxDes(ByVal ccodcta As String) As String
        Return mDb.ObtenercnrodocmaxDes(ccodcta)
    End Function
    Public Function ValidaPagosRevertirDes(ByVal cCodsol As String, ByVal dfecha As Date) As Boolean
        Return mDb.ValidaPagosRevertirDes(cCodsol, dfecha)
    End Function
    Public Function ProvisionaRevertir(ByVal cCodcta As String, ByVal cnrodoc As String) As Double
        Return mDb.ProvisionaRevertir(cCodcta, cnrodoc)
    End Function
    Public Function RevierteProvision(ByVal cCodcta As String, ByVal nmonto As Double) As Integer
        Return mDb.RevierteProvision(cCodcta, nmonto)
    End Function
    Public Function RevierteProvisionMes(ByVal cCodcta As String, ByVal nmonto As Double) As Integer
        Return mDb.RevierteProvisionMes(cCodcta, nmonto)
    End Function
    Public Function UltimafechaProcesoGrupal(ByVal cCodsol As String) As Date
        Return mDb.UltimafechaProcesoGrupal(cCodsol)
    End Function
    Public Function ObtenerInteresAjustado(ByVal cCodcta As String) As Double
        Return mDb.ObtenerInteresAjustado(cCodcta)
    End Function
    Public Function ObtenerMoraAjustado(ByVal cCodcta As String) As Double
        Return mDb.ObtenerMoraAjustado(cCodcta)
    End Function
    Public Function RecuperarAjuste(ByVal cCodcta As String, ByVal dfecha As Date, ByVal cnumrec As String) As DataSet
        Return mDb.RecuperarAjuste(cCodcta, dfecha, cnumrec)
    End Function
    '****************************************************Clase Temporal
    Public Function PagosaConstruir() As DataSet
        Return mDb.PagosaConstruir()
    End Function
    Public Function DesembolsosAplicados(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.DesembolsosAplicados(ccodcta, dfecha)
    End Function
    Public Function UltimafechaCobro(ByVal ccodcta As String, ByVal dfecha As Date, ByVal ctipgas As String, ByVal dfecvig As Date) As Date
        Return mDb.UltimafechaCobro(ccodcta, dfecha, ctipgas, dfecvig)
    End Function
    Public Function Pagoenelmes(ByVal ccodcta As String, ByVal dfecha As Date, ByVal ctipgas As String, ByVal dfecvig As Date) As Boolean
        Return mDb.Pagoenelmes(ccodcta, dfecha, ctipgas, dfecvig)
    End Function
    Public Function AgregaraCaja(ByVal ccodusu As String, ByVal nsaldo As Decimal, ByVal dfecha As DateTime, ByVal ctipo As String, ByVal cnumcom As String, ByVal cbanco As String, ByVal ccodusu1 As String) As Integer
        Return mDb.AgregaraCaja(ccodusu, nsaldo, dfecha, ctipo, cnumcom, cbanco, ccodusu1)
    End Function
    Public Function VerificaProcedeCaja(ByVal ccodusu As String, ByVal ctipo As String) As Boolean
        Return mDb.VerificaProcedeCaja(ccodusu, ctipo)
    End Function
    Public Function ObtieneSaldodeCaja(ByVal ccodusu As String, ByVal ctipo As String) As Decimal
        Return mDb.ObtieneSaldodeCaja(ccodusu, ctipo)
    End Function
    Public Function ObtieneFechayHoraCaja(ByVal ccodusu As String, ByVal ctipo As String) As DateTime
        Return mDb.ObtieneFechayHoraCaja(ccodusu, ctipo)
    End Function
    Public Function ResumenKardexdosfechas(ByVal ccodusu As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal choraini As String, ByVal chora As String) As DataSet
        Return mDb.ResumenKardexdosfechas(ccodusu, dfecini, dfecfin, choraini, chora)
    End Function
    Public Function UltimadDocumentoProceso(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Return mDb.UltimadDocumentoProceso(ccodcta, dfecha)
    End Function
    Public Function UltimafechaCobroIntPendiente(ByVal ccodcta As String, ByVal dfecha As Date, ByVal ctipgas As String, ByVal dfecvig As Date) As Date
        Return mDb.UltimafechaCobroIntPendiente(ccodcta, dfecha, ctipgas, dfecvig)
    End Function
    Public Function InteresPendientePagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.InteresPendientePagado(ccodcta, dfecha)
    End Function
    Public Function InteresPagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.InteresPagado(ccodcta, dfecha)
    End Function
    Public Function UltimafechadePago(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cconcep As String, ByVal dfecvig As Date) As Date
        Return mDb.UltimafechadePago(ccodcta, dfecha, cconcep, dfecvig)
    End Function
    Public Function ObtenerUltimoPago(ByVal ccodcta As String, ByVal dfecha As Date) As DataTable
        Return mDb.ObtenerUltimoPago(ccodcta, dfecha)
    End Function
    Public Function ServicioPagado(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.ServicioPagado(ccodcta, dfecha)
    End Function
    Public Function ObtenerMontoPagado(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cconcep As String) As Double
        Return mDb.ObtenerMontoPagado(ccodcta, dfecha, cconcep)
    End Function
    Public Function ObtenerUltimoPagosegunConcepto(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cconcep As String) As DataTable
        Return mDb.ObtenerUltimoPagosegunConcepto(ccodcta, dfecha, cconcep)
    End Function
    Public Function ObtenerDeposito(ByVal ccodusu As String, ByVal dfecha As Date, ByVal ope As String) As DataSet
        Return mDb.ObtenerDeposito(ccodusu, dfecha, ope)
    End Function
    Public Function VerificaExisteArqueo(ByVal ccodusu As String, ByVal dfecha As Date) As Boolean
        Return mDb.VerificaExisteArqueo(ccodusu, dfecha)
    End Function
    Public Function GrabaSaldoArqueo(ByVal ccodusu As String, ByVal dfecha As Date, ByVal nsaldo As Decimal) As Integer
        Return mDb.GrabaSaldoArqueo(ccodusu, dfecha, nsaldo)
    End Function
    Public Function ObtenerSaldoArqueo(ByVal ccodusu As String, ByVal dfecha As Date) As Decimal
        Return mDb.ObtenerSaldoArqueo(ccodusu, dfecha)
    End Function
    Public Function VerificaAperturaCaja(ByVal ccodusu As String, ByVal dfecha As Date) As Boolean
        Return mDb.VerificaAperturaCaja(ccodusu, dfecha)
    End Function
    Public Function VerificaProcedeReapertura(ByVal ccodusu As String, ByVal ctipo As String, ByVal dfecha As Date) As Boolean
        Return mDb.VerificaProcedeReapertura(ccodusu, ctipo, dfecha)
    End Function
    Public Function ReaperturaCaja(ByVal ccodusu As String, ByVal dfecha As Date) As Integer
        Return mDb.ReaperturaCaja(ccodusu, dfecha)
    End Function
    Public Function ExisteBoletaBanco(ByVal cnumdoc As String, ByVal cbanco As String) As Boolean
        Return mDb.ExisteBoletaBanco(cnumdoc, cbanco)
    End Function
    Public Function ObtieneFechaCajaAnterior(ByVal ccodusu As String, ByVal dfecha1 As Date) As Date
        Return mDb.ObtieneFechaCajaAnterior(ccodusu, dfecha1)
    End Function
    Public Function ObtenerMontoPagadoG(ByVal ccodsol As String, ByVal dfecha As Date, ByVal cconcep As String) As Double
        Return mDb.ObtenerMontoPagadoG(ccodsol, dfecha, cconcep)
    End Function
    Public Function ValidaCajasCerradas(ByVal ccodofi As String, ByVal dfecha As String) As Integer
        Return mDb.ValidaCajasCerradas(ccodofi, dfecha)
    End Function
    Public Function ObtenerDepositoCaja(ByVal ccodusu As String, ByVal dfecha As Date, ByVal cbanco As String, ByVal cnumdoc As String) As String
        Return mDb.ObtenerDepositoCaja(ccodusu, dfecha, cbanco, cnumdoc)
    End Function
    Public Function RevierteDepositoCaja(ByVal cnumcom As String) As Integer 'Equivale a cancelar deposito
        Return mDb.RevierteDepositoCaja(cnumcom)
    End Function
    Public Function Obtener_Saldo_inicial_Cuadre(ByVal ccodusu As String, ByVal dfecha As Date) As Decimal
        Return mDb.Obtener_Saldo_inicial_Cuadre(ccodusu, dfecha)
    End Function
    Public Function Obtener_Saldo_inicial_Cuadre_General(ByVal dfecha As Date) As Decimal
        Return mDb.Obtener_Saldo_inicial_Cuadre_General(dfecha)
    End Function
    Public Function GrabaReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, ByVal usuario As String, ByVal id_interno As String, _
                                               ByVal id_operacion As String, ByVal valor_pagar As String, ByVal mensaje As String, _
                                               ByVal id_reserva As String, ByVal fecha_vence_reserva As Date, ByVal hora_vence_reserva As String, _
                                               ByVal codigo_mensaje As String, ByVal cestado As String) As Integer
        Return mDb.GrabaReservaRemesa(id_integracion, id_pagador, usuario, id_interno, id_operacion, valor_pagar, mensaje, id_reserva, fecha_vence_reserva, hora_vence_reserva, codigo_mensaje, cestado)
    End Function
    Public Function ReversaReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, ByVal usuario As String, ByVal id_interno As String, _
                                             ByVal id_operacion As String, ByVal valor_pagar As String, ByVal mensaje As String, _
                                             ByVal id_reserva As String, _
                                             ByVal codigo_mensaje As String, ByVal cestado As String) As Integer
        Return mDb.ReversaReservaRemesa(id_integracion, id_pagador, usuario, id_interno, id_operacion, valor_pagar, mensaje, id_reserva, codigo_mensaje, cestado)
    End Function
    Public Function ObtieneReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, _
                                         ByVal id_operacion As String) As String
        Return mDb.ObtieneReservaRemesa(id_integracion, id_pagador, id_operacion)
    End Function
    Public Function VerificaReservaRemesa(ByVal id_integracion As String, ByVal id_pagador As String, ByVal id_interno As String, _
                                     ByVal id_operacion As String) As Boolean
        Return mDb.VerificaReservaRemesa(id_integracion, id_pagador, id_interno, id_operacion)
    End Function


    'Funcion con Error en los fuentes Rafa 07/08/2014
    'Public Function ObtieneIDInternoRemesa(ByVal id_integracion As String, ByVal id_pagador As String, _
    '                             ByVal id_operacion As String) As String
    '    Return mDb.ObtieneIDInternoRemesa(id_integracion, id_pagador, id_interno, id_operacion)
    'End Function

    Public Function ObtieneIDInternoRemesa(ByVal id_integracion As String, ByVal id_pagador As String, _
                                 ByVal id_operacion As String) As String
        Return mDb.ObtieneIDInternoRemesa(id_integracion, id_pagador, id_operacion)
    End Function


    Public Function Actualiza_Dispersion(ByVal ds As DataSet) As Integer
        Return mDb.Actualiza_Dispersion(ds)
    End Function


    Public Function Extrae_Archivo_Dispersador(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                           ByVal GCNOMINS As String, ByVal GCCTABCO As String) As ArrayList
        Return mDb.Extrae_Archivo_Dispersador(pdfecini, pdfecfin, GCNOMINS, GCCTABCO)
    End Function

    Public Function Extrae_Archivo_Dispersador_Garantias(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                          ByVal GCNOMINS As String, ByVal GCCTABCO As String) As ArrayList
        Return mDb.Extrae_Archivo_Dispersador_Garantias(pdfecini, pdfecfin, GCNOMINS, GCCTABCO)
    End Function

    Public Function Genera_rutina_Exporta_Asientos(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                   ByVal gnIVA As Double) As DataSet
        Return mDb.Genera_rutina_Exporta_Asientos(pdfecini, pdfecfin, gnIVA)
    End Function

    Public Function Actualiza_Maestra_Pagos_Automaticos(ByVal id As Decimal, ByVal dfecsis As Date, ByVal dfecpro As Date, _
                                                        ByVal tipo As String, ByVal ccodcta As String, ByVal nmonto As Decimal, _
                                                        ByVal codigo_transaccion As String, ByVal ccodusu As String, _
                                                        ByVal cmotivo As String) As Integer
        Return mDb.Actualiza_Maestra_Pagos_Automaticos(id, dfecsis, dfecpro, tipo, ccodcta, nmonto, codigo_transaccion, ccodusu, cmotivo)

    End Function

    Public Function KardexPruebax(ByVal pccodcta As String, ByVal dfecha1 As String, ByVal dfecha2 As String, ByVal cdescob As String) As DataSet
        Return mDb.KardexPruebax(pccodcta, dfecha1, dfecha2, cdescob)
    End Function

    Public Function KardexPruebaxDes(ByVal pccodcta As String) As DataSet
        Return mDb.KardexPruebaxDes(pccodcta)
    End Function
    Public Function KardexPruebaxDes_(ByVal pccodcta As String) As DataSet
        Return mDb.KardexPruebaxDes_(pccodcta)
    End Function

    Public Function Inserta_AjusteX(ByVal Encabeza_Part() As String, ByVal Detalle_Pago() As String) As String
        Return mDb.Inserta_AjusteX(Encabeza_Part, Detalle_Pago)
    End Function

    Public Function Extrae_Detalle_Pagos(ByVal pdfecsys As Date, ByVal pcCodcta As String) As DataTable
        Return mDb.Extrae_Detalle_Pagos(pdfecsys, pcCodcta)
    End Function

    Public Function Extrae_Detalle_Pagos_Creditos(ByVal pcCodcta As String) As DataTable
        Return mDb.Extrae_Detalle_Pagos_Creditos(pcCodcta)
    End Function

    Public Function Inserta_Auxiliar_AjusteX(ByVal ccodcta As String, ByVal ccodcli As String, _
                                            ByVal dt As DataTable, ByVal pccodusu As String) As Integer
        Return mDb.Inserta_Auxiliar_AjusteX(ccodcta, ccodcli, dt, pccodusu)
    End Function

    Public Function Extrae_Auxiliar_Ajustes_Creditos(ByVal pcCodcta As String) As DataTable
        Return mDb.Extrae_Auxiliar_Ajustes_Creditos(pcCodcta)
    End Function

    Public Function obtenercnrodoc_(ByVal cCodcta As String, ByVal con As SqlConnection) As String
        Return mDb.Obtenercnrodoc_(cCodcta, con)
    End Function

    Public Function Pagos_Automaticos(ByVal dt As DataTable, ByVal pdfecsis As Date, _
                                      ByVal pcCodusu As String, ByVal FileName_Arch As String) As DataSet
        Return mDb.Pagos_Automaticos(dt, pdfecsis, pcCodusu, FileName_Arch)
    End Function

End Class
