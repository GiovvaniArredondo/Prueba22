Public Class cCredppg
 
#Region " Privadas "
    Private mDb as New dbCredppg()
    Private mEntidad as Credppg
#End Region
 
    Public Function ObtenerLista(ByVal ccodcta As String, ByVal ctipope As String) As listacredppg
        Return mDb.ObtenerListaPorID(ccodcta, ctipope)
    End Function

    Public Function ObtenerCredppg(ByRef mEntidad As credppg) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCredppg(ByVal ccodcta As String) As Integer
        Dim mEntidad As New credppg
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCredppg(ByVal aEntidad As credppg) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerListaPorCuenta(ByVal ccodcta As String) As listacredppg
        Return mDb.ObtenerListaPorCuenta(ccodcta)
    End Function

    Public Function Agregar(ByVal aEntidad As credppg) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function EliminaPlanPagos(ByRef mEntidad As credppg) As Integer
        Return mDb.EliminaPlanPagos(mEntidad)
    End Function

    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorID2(ccodcta)
    End Function

    Public Function ObtenerDataSetPorcuenta_fecha(ByVal ldfecha As Date, ByVal pccodcta1 As String) As DataSet
        Return mDb.ObtenerDataSetPorcuenta_fecha(ldfecha, pccodcta1)
    End Function
    Public Function Recuperar(ByVal aEntidad As credppg) As Integer
        Return mDb.Recuperar(aEntidad)
    End Function
    Public Function ObtenerSaldoTeorico(ByVal pccodcta As String, ByVal pdfecha As Date, ByVal pncapdes As Double)
        Return mDb.ObtenerSaldoTeorico(pccodcta, pdfecha, pncapdes)
    End Function
    Public Function Obtenerprimeracuota(ByVal pcCodcta As String) As Date
        Return mDb.Obtenerprimeracuota(pcCodcta)
    End Function
    Public Function CapitalInteres(ByVal pccodcta As String) As Decimal 'valores decimales
        Return mDb.CapitalInteres(pccodcta)
    End Function
    Public Function plandepagosLibreta(ByVal ccodcta As String, ByVal dfecini As Date, ByVal dfecfin As Date) As DataSet
        Return mDb.plandepagosLibreta(ccodcta, dfecini, dfecfin)
    End Function
    Public Function ProximaFecha(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Return mDb.ProximaFecha(ccodcta, dfecha)
    End Function
    Public Function CuotaCapital(ByVal ccodcta As String) As Double
        Return mDb.CuotaCapital(ccodcta)
    End Function
    Public Function CuotasPagadas(ByVal ccodcta As String, ByVal nsaldopag As Double) As String
        Return mDb.CuotasPagadas(ccodcta, nsaldopag)
    End Function
    Public Function CuotasTeoricas(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Return mDb.CuotasTeoricas(ccodcta, dfecha)
    End Function
    Public Function AnteriorFecha(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Return mDb.AnteriorFecha(ccodcta, dfecha)
    End Function
    Public Function ValidaFrecuencia(ByVal cfreckp As String, ByVal cfrecint As String, ByVal ncuotas As Integer) As Boolean
        Return mDb.ValidaFrecuencia(cfreckp, cfrecint, ncuotas)
    End Function
    Public Function RecuperaPlanPagos(ByVal ccodcta As String) As DataSet
        Return mDb.RecuperaPlanPagos(ccodcta)
    End Function
    Public Function InteresNovencido(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.InteresNovencido(ccodcta, dfecha)
    End Function
    Public Function Interesvencido(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.Interesvencido(ccodcta, dfecha)
    End Function
    Public Function CuotaGrupal(ByVal cCodsol As String, ByVal dfecha As String) As Double
        Return mDb.CuotaGrupal(cCodsol, dfecha)
    End Function
    Public Function FechasdePago(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.FechasdePago(cCodsol, dfecha)
    End Function
    Public Function PlandePagosIndividual(ByVal cCodcta As String) As DataSet
        Return mDb.PlandePagosIndividual(cCodcta)
    End Function
    Public Function UltimaCuotaVencida(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Return mDb.UltimaCuotaVencida(ccodcta, dfecha)
    End Function
    Public Function UltimaCuotadePlan(ByVal ccodcta As String) As Date
        Return mDb.UltimaCuotadePlan(ccodcta)
    End Function
    Public Function CuotaseVence(ByVal cCodcta As String, ByVal dfecini As Date, ByVal dfecfin As Date) As String
        Return mDb.CuotaseVence(cCodcta, dfecini, dfecfin)
    End Function
    Public Function PlanGrupalTeorico(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.PlanGrupalTeorico(cCodsol, dfecha)
    End Function
    Public Function ProximaCuotadePlan(ByVal ccodcta As String, ByVal dfecha As Date) As Date
        Return mDb.ProximaCuotadePlan(ccodcta, dfecha)
    End Function
    Public Function ConsolidaPlanExtra(ByVal ccodcta As String) As DataSet
        Return mDb.ConsolidaPlanExtra(ccodcta)
    End Function
    Public Function NumeroCuotaProximaFecha(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Return mDb.NumeroCuotaProximaFecha(ccodcta, dfecha)
    End Function
    Public Function CuotasTeoricasMonto(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.CuotasTeoricasMonto(ccodcta, dfecha)
    End Function
    Public Function CuotaTeoricaMonto(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.CuotaTeoricaMonto(ccodcta, dfecha)
    End Function
    Public Function InteresPendiente(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.InteresPendiente(ccodcta, dfecha)
    End Function
    Public Function InteresPendienteTotal(ByVal ccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.InteresPendienteTotal(ccodcta, dfecha)
    End Function
    Public Function FechaCapitalCubierto(ByVal ccodcta As String, ByVal nsaldopag As Double, ByVal dfecvig As Date) As Date
        Return mDb.FechaCapitalCubierto(ccodcta, nsaldopag, dfecvig)
    End Function
    Public Function FechaInteresCubierto(ByVal ccodcta As String, ByVal nsaldopag As Double, ByVal dfecvig As Date) As Date
        Return mDb.FechaInteresCubierto(ccodcta, nsaldopag, dfecvig)
    End Function
    Public Function ObtenerCuotaUltimaVencida(ByVal ccodcta As String, ByVal dfecha As Date) As String
        Return mDb.ObtenerCuotaUltimaVencida(ccodcta, dfecha)
    End Function
    Public Function GrabaInteresCongelado(ByVal ccodcta As String, ByVal cnrocuo As String, ByVal nmonto As Decimal) As Integer
        Return mDb.GrabaInteresCongelado(ccodcta, cnrocuo, nmonto)
    End Function
    Public Function CuotaTeoricaMontoporRango(ByVal ccodcta As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As Double
        Return mDb.CuotaTeoricaMontoporRango(ccodcta, dfecha1, dfecha2)
    End Function
    Public Function ObtenerSaldoInteresPlan(ByVal lccodcta As String) As Double
        Return mDb.ObtenerSaldoInteresPlan(lccodcta)
    End Function
    Public Function CapitalInteres_Total(ByVal ccodcta As String) As Double
        Return mDb.CapitalInteres_Total(ccodcta)
    End Function

    Public Function Extrae_Saldo_Interes_Total_Flat(ByVal pccodcta As String, ByVal dfecha As Date) As Double
        Return mDb.Extrae_Saldo_Interes_Total_Flat(pccodcta, dfecha)
    End Function
    Public Function SaldoAlDia(ByVal lccodcta As String, ByVal ldfecval As Date) As Double
        Return mDb.SaldoAlDia(lccodcta, ldfecval)
    End Function


End Class
