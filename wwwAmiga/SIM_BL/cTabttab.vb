Public Class cTabttab
 
#Region " Privadas "
    Private mDb as New dbTabttab()
    Private mEntidad as Tabttab
#End Region
    Public Function ObtenerDataSetCamposAdicionales(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet
        Return mDb.ObtenerDataSetCamposAdicionales(ccodtab, ctipreg)
    End Function
    Public Function ObtenerLista(ByVal ccodtab, ByVal ctipreg) As listatabttab
        Return mDb.ObtenerListaPorID(ccodtab, ctipreg)
    End Function

    Public Function ObtenerTabttab(ByRef mEntidad As tabttab) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarTabttab(ByVal corden As String) As Integer
        Dim mEntidad As New tabttab
        mEntidad.corden = corden
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarTabttab(ByVal aEntidad As tabttab) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    '    ObtenerDataSetPorID
    Public Function ObtenerDataSetPorID(ByVal ccodtab, ByVal ctipreg) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodtab, ctipreg)
    End Function

    Public Function ObtenerDataSetPorID2(ByVal ccodtab, ByVal ctipreg, ByVal ccodigo) As DataSet
        Return mDb.ObtenerDataSetPorID2(ccodtab, ctipreg, ccodigo)
    End Function
    Public Function Describe(ByVal ccodigo, ByVal ctabla) As String
        Return mDb.Describe(ccodigo, ctabla)
    End Function
    Public Function TablasTab(ByVal tabla As String, ByVal ccodigo As String) As DataSet
        Return mDb.TablasTab(tabla, ccodigo)
    End Function

    Public Function ObtenerListaPorIDxcodigo(ByVal ccodtab As String, ByVal ctipreg As String, ByVal ccodigo As String) As listatabttab
        Return mDb.ObtenerListaPorIDxcodigo(ccodtab, ctipreg, ccodigo)
    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer
        Return mDb.ObtenerDataSetPorID(ds)
    End Function
    Public Function ObtenerFrecuencia(ByVal cfrecuencia As String) As DataSet
        Return mDb.ObtenerFrecuencia(cfrecuencia)
    End Function
    Public Function ObtenerTipodePago(ByVal nnivel As Integer) As listatabttab
        Return mDb.ObtenerTipodePago(nnivel)
    End Function
    Public Function ObtenerDataSetPorIDx(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet
        Return mDb.ObtenerDataSetPorIDx(ccodtab, ctipreg)
    End Function
    Public Function VerificaUsuarioCajero(ByVal ccodigo As String) As Boolean
        Return mDb.VerificaUsuarioCajero(ccodigo)
    End Function
    Public Function ObtieneCodigoCajero(ByVal ccodigo As String) As String
        Return mDb.ObtieneCodigoCajero(ccodigo)
    End Function
    Public Function ObtieneTipoCajero(ByVal ccodigo As String) As String
        Return mDb.ObtieneTipoCajero(ccodigo)
    End Function
    Public Function ObtieneContabledelCajero(ByVal ccodigo As String) As String
        Return mDb.ObtieneContabledelCajero(ccodigo)
    End Function
    Public Function ObtieneContabledelCajero2(ByVal ccodigo As String) As String
        Return mDb.ObtieneContabledelCajero2(ccodigo)
    End Function
    Public Function DescribeAux(ByVal lccodigo As String, ByVal lctabla As String) As String
        Return mDb.DescribeAux(lccodigo, lctabla)
    End Function
    Public Function CargaListadoChkGastos() As DataSet
        Return mDb.CargaListadoChkGastos()
    End Function
    Public Function ObtenerListaPorIDOrdenado(ByVal ccodtab As String, ByVal ctipreg As String) As listatabttab
        Return mDb.ObtenerListaPorIDOrdenado(ccodtab, ctipreg)
    End Function
    Public Function ObtieneCodigoxCampoAuxiliar(ByVal lccodigo As String, ByVal lctabla As String) As String
        Return mDb.ObtieneCodigoxCampoAuxiliar(lccodigo, lctabla)
    End Function
    Public Function ObtenerDatasetTabla(ByVal lctabla As String, ByVal ccodins As String) As DataSet
        Return mDb.ObtenerDatasetTabla(lctabla, ccodins)
    End Function
    Public Function ObtenerDataSetCondicionado(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet
        Return mDb.obtenerDataSetCondicionado(ccodtab, ctipreg)
    End Function
    Public Function ObtenerCuentadeOperacionesCaja(ByVal ccodtab As String, ByVal ccodigo As String) As String
        Return mDb.ObtenerCuentadeOperacionesCaja(ccodtab, ccodigo)
    End Function
    Public Function ObtenerTipodeOperacionesCaja(ByVal ccodtab As String, ByVal ccodigo As String) As String
        Return mDb.ObtenerTipodeOperacionesCaja(ccodtab, ccodigo)
    End Function
    Public Function ObtenerCondicionadoscFlag(ByVal lctabla As String) As DataSet
        Return mDb.ObtenerCondicionadoscFlag(lctabla)
    End Function
    Public Function GrabarTabttabNumerico(ByVal ccodtab As String, ByVal ccodigo As String, ByVal nnumtab As Integer) As Integer
        Return mDb.GrabarTabttabNumerico(ccodtab, ccodigo, nnumtab)
    End Function
    Public Function ObtenerFactor(ByVal ccodtab As String, ByVal ccodigo As String) As Decimal
        Return mDb.ObtenerFactor(ccodtab, ccodigo)
    End Function

    Public Function ObtenerDescripcion(ByVal ccodtab As String, ByVal ccodigo As String) As String
        Return mDb.ObtenerDescripcion(ccodtab, ccodigo)
    End Function

    Public Function Mantenimiento_Niveles_Aprobacion(ByVal Detalle_Cta As ArrayList) As Integer
        Return mDb.Mantenimiento_Niveles_Aprobacion(Detalle_Cta)
    End Function

    Public Function Extrae_Niveles_Aprobacion() As DataSet
        Return mDb.Extrae_Niveles_Aprobacion()
    End Function

    Public Function Lista_Niveles_Aprobacion() As DataSet
        Return mDb.Lista_Niveles_Aprobacion()
    End Function

    Public Function Mantenimiento_Usuarios_Niveles_Aprobacion(ByVal Detalle_Cta As ArrayList) As Integer
        Return mDb.Mantenimiento_Usuarios_Niveles_Aprobacion(Detalle_Cta)
    End Function

    Public Function Extrae_Usuarios_Niveles_Aprobacion(ByVal codigo_nivel_aprobacion As String) As DataSet
        Return mDb.Extrae_Usuarios_Niveles_Aprobacion(codigo_nivel_aprobacion)
    End Function

    Public Function Extrae_Comite_Usuario(ByVal idsuario As Integer) As DataSet
        Return mDb.Extrae_Comite_Usuario(idsuario)
    End Function
    Public Function Datos_Niveles_Aprobacion(ByVal pcCodigo As String) As DataSet
        Return mDb.Datos_Niveles_Aprobacion(pcCodigo)
    End Function

    Public Function Extrae_Datos_Libretas(ByVal pcCodofi As String, ByVal pctodas As String) As DataSet
        Return mDb.Extrae_Datos_Libretas(pcCodofi, pctodas)
    End Function

    Public Function Mantenimiento_Oficinas_Libretas(ByVal Detalle_Cta As ArrayList) As Integer
        Return mDb.Mantenimiento_Oficinas_Libretas(Detalle_Cta)
    End Function



    Public Function Valida_Niveles_Aprobacion(ByVal lnmonapr As Double, ByVal pcCodcta As String) As Integer
        Return mDb.Valida_Niveles_Aprobacion(lnmonapr, pcCodcta)
    End Function

    Public Function Extrae_Cuenta_CTB_Cajero(ByVal pcCodana As String) As String
        Return mDb.Extrae_Cuenta_CTB_Cajero(pcCodana)
    End Function
End Class
