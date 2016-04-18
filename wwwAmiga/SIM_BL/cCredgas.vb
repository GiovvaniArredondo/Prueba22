Public Class cCredgas
 
#Region " Privadas "
    Private mDb as New dbCredgas()
    Private mEntidad as Credgas
#End Region
 
    'Public Function ObtenerLista() As listaCredgas
    '    Return mDb.ObtenerListaPorID()
    'End Function
    Public Function Agregar(ByRef mEntidad As credgas) As Integer
        Return mDb.Agregar(mEntidad)
    End Function

    Public Function ObtenerCredgas(ByRef mEntidad As credgas) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarCredgas(ByVal ccodcta As String) As Integer
        Dim mEntidad As New credgas
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCredgas(ByVal aEntidad As credgas) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function EliminarGastos(ByRef mEntidad As credgas) As Integer
        Return mDb.EliminaGastos(mEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal pccodcta As String, ByVal pctipgas As String, ByVal pcnrocuo As String) As DataSet
        Return mDb.ObtenerDataSetPorID(pccodcta, pctipgas, pcnrocuo)
    End Function
    Public Function Eliminarporcuenta(ByVal pccodcta As String)
        Return mDb.Eliminarporcuenta(pccodcta)
    End Function
    Public Function EliminarporcuentaDes(ByVal pccodcta As String)
        Return mDb.EliminarporcuentaDes(pccodcta)
    End Function
    Public Function Eliminar(ByRef aEntidad As credgas) As Integer
        Return mDb.Eliminar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByVal cdescob As String) As DataSet
        Return mDb.ObtenerDataSetPorID2(ccodcta, cdescob)
    End Function
    Public Function CargaComisiones(ByVal ccodcta As String, ByVal cdescob As String) As DataTable
        Return mDb.CargaComisiones(ccodcta, cdescob)
    End Function
    Public Function Extrae__cadenas(ByVal cadenaselect As String) As String
        Return mDb.Extrae__cadenas(cadenaselect)
    End Function

    Public Function CargaComisionesGrupal(ByVal ccodcta As String, ByVal cdescob As String) As DataTable
        Return mDb.CargaComisionesGrupal(ccodcta, cdescob)
    End Function
    Public Function CargaListadoChkGastosCredito(ByVal ccodcta As String) As DataSet
        Return mDb.CargaListadoChkGastosCredito(ccodcta)
    End Function
    Public Function AplicaEdiciondeCampo(ByVal ccodigo As String) As Boolean
        Return mDb.AplicaEdiciondeCampo(ccodigo)
    End Function
    Public Function EliminarporcuentaPropuesta(ByVal ccodcta As String, ByVal cusugen As String)
        Return mDb.EliminarporcuentaPropuesta(ccodcta, cusugen)
    End Function
    Public Function EliminarporcuentaPropuestaDes(ByVal ccodcta As String, ByVal cusugen As String)
        Return mDb.EliminarporcuentaPropuestaDes(ccodcta, cusugen)
    End Function
    Public Function AgregarPropuesta(ByVal aEntidad As entidadBase) As Integer
        Return mDb.AgregarPropuesta(aEntidad)
    End Function
    Public Function CargaGastos(ByVal ccodcta As String, ByVal cdescob As String, ByVal cnrocuo As String) As DataSet
        Return mDb.CargaGastos(ccodcta, cdescob, cnrocuo)
    End Function
    Public Function CargaGastosCuota(ByVal ccodcta As String, ByVal dfecha As Date, ByVal cdescob As String, ByVal cnrocuo As String) As DataSet
        Dim ds As New DataSet
        ds = mDb.CargaGastos(ccodcta, cdescob, cnrocuo)
        If cdescob.Trim = "D" Then
            Return ds
        End If
        Dim clsaditivos As New cClsAditivos
        Dim fila As DataRow
        Dim lncargo As Double = 0
        clsaditivos.pccodcta = ccodcta
        clsaditivos.pdfecval = dfecha
        For Each fila In ds.Tables(0).Rows
            lncargo = utilNumeros.Redondear(clsaditivos.CargosdeCuotas(Trim(fila("ctipgas")), dfecha), 2)
            fila("nmongas") = lncargo
        Next
        Return ds
    End Function
    Public Function ObtenerGastohastafecha(ByVal ctipgas As String, ByVal ccodcta As String, ByVal cnrocuo As String) As Decimal
        Return mDb.ObtenerGastohastafecha(ctipgas, ccodcta, cnrocuo)
    End Function
    Public Function ObtenerGastodeCuota(ByVal ctipgas As String, ByVal ccodcta As String, ByVal cnrocuo As String) As Decimal
        Return mDb.ObtenerGastodeCuota(ctipgas, ccodcta, cnrocuo)
    End Function

    Public Function Extrae_Gastos(ByVal pcCodcta As String, ByVal pcTipo As String) As DataSet
        Return mDb.Extrae_Gastos(pcCodcta, pcTipo)
    End Function
    Public Function ObtenerGastoAsignadaaCuota(ByVal ccodcta As String) As Decimal
        Return mDb.ObtenerGastoAsignadaaCuota(ccodcta)
    End Function
    Public Function ObtenerGastoDesembolso(ByVal ccodcta As String, ByVal cnrocuo As String) As Decimal
        Return mDb.ObtenerGastoDesembolso(ccodcta, cnrocuo)
    End Function
End Class
