Public Class cCredtpl
 
#Region " Privadas "
    Private mDb as New dbCredtpl()
    Private mEntidad as Credtpl
#End Region
 
    Public Function ObtenerLista(ByVal ccodcta As String, ByVal ctipope As String) As listacredtpl
        Return mDb.ObtenerListaPorID(ccodcta, ctipope)
    End Function
    Public Function ObtenerLista2(ByVal ccodcta As String) As listacredtpl
        Return mDb.ObtenerListaPorID2(ccodcta)
    End Function
    Public Function ObtenerCredtpl(ByRef mEntidad As credtpl) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCredtpl(ByVal ccodcta As String) As Integer
        Dim mEntidad As New credtpl
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCredtpl(ByVal aEntidad As credtpl) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcta)
    End Function

    Public Function AgregarCredtpl(ByVal aEntidad As credtpl) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function Obtenerprimeracuota(ByVal ccodcta As String) As Date
        Return mDb.Obtenerprimeracuota(ccodcta)
    End Function
    Public Function CapitalInteres(ByVal ccodcta As String) As Double
        Return mDb.CapitalInteres(ccodcta)
    End Function
    Public Function CapitalInteresGrupal(ByVal ccodsol As String) As Double
        Return mDb.CapitalInteresGrupal(ccodsol)
    End Function
    Public Function CuoAhorro(ByVal nmonto As String) As Double
        Return mDb.CuoAhorro(nmonto)
    End Function
    Public Function PlanGrupalTeorico(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.PlanGrupalTeorico(cCodsol, dfecha)
    End Function
    Public Function CargarAditivos(ByVal ccodcta As String) As Double
        Return mDb.CargarAditivos(ccodcta)
    End Function
    Public Function PlanesdePagosGrupos(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.PlanesdePagosGrupos(cCodsol, dfecha)
    End Function
    Public Function ObtenerUltimacuota(ByVal ccodcta As String) As Date
        Return mDb.ObtenerUltimacuota(ccodcta)
    End Function
    Public Function ObtieneNumeroCuotas(ByVal ccodcta As String) As Integer
        Return mDb.ObtieneNumeroCuotas(ccodcta)
    End Function
    Public Function Monto_Total_CapitalInteres(ByVal ccodcta As String) As Double
        Return mDb.Monto_Total_CapitalInteres(ccodcta)
    End Function
End Class
