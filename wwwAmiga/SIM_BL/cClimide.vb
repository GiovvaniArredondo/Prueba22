Public Class cClimide
 
#Region " Privadas "
    Private mDb as New dbClimide()
    Private mEntidad as Climide
#End Region
 
    Public Function ObtenerLista() As listaClimide
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerSolicitudesAbiertas(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerSolicitudesAbiertas(ccodcli)
    End Function
    Public Function ValidarRangoProducto(ByVal pcCodCta As String, ByVal lmonsug As Double) As DataSet
        Return mDb.ValidarRangoProducto(pcCodCta)
    End Function
    Public Function ObtenerIntencionesCredito(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerIntencionesCredito(ccodcli)
    End Function

    Public Function ObtenerClimide(ByRef mEntidad As climide) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarClimide(ByVal ccodcli As String) As Integer
        Dim mEntidad As New climide
        mEntidad.ccodcli = ccodcli
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarClimide(ByVal aEntidad As climide) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listaclimide
        Return mDb.ObtenerListaPorCliente(codcli)
    End Function
    ' ObtenerListaPorCliente_nombre
    Public Function ObtenerListaPorCliente_nombre(ByVal cnomcli As String) As listaclimide
        Return mDb.ObtenerListaPorCliente(cnomcli)
    End Function
    Public Function AgregaClimide(ByVal aEntidad As climide) As Integer
        Return mDb.AgregarClimide(aEntidad)
    End Function

    Public Function ObtenerDataSet() As DataSet
        Return mDb.ObtenerDataSet()
    End Function
    Public Function ActualizarClimide1(ByVal aEntidad As climide, ByVal lnflag As Integer) As Integer
        Return mDb.ActualizaClimide(aEntidad, lnflag)
    End Function
    Public Function ObtenerDataSetEsp(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEsp(cCodigo)
    End Function
    Public Function ObtenerDataSetNivel(ByVal ccodigo As String, ByVal nNivel As String, ByVal cOficina As String) As DataSet
        Return mDb.ObtenerDataSetNivel(ccodigo, nNivel, cOficina)
    End Function
    'Public Function Busca_codigo_Clie(ByVal ccodcli As String) As String
    '    Return mDb.Busca_codigo_Clie(ccodcli)
    'End Function
    Public Function ObtenerDataSetNivel2(ByVal nNivel, ByVal cOficina) As DataSet
        Return mDb.ObtenerDataSetNivel2(nNivel, cOficina)
    End Function
    Public Function ObtenerDataSetEsp1(ByVal cCodigo As String, ByVal nnivel As Integer, ByVal coficina As String) As DataSet
        Return mDb.ObtenerDataSetEsp1(cCodigo, nnivel, coficina)
    End Function
    Public Function ActualizaReferencia(ByVal aEntidad As climide) As Integer
        Return mDb.ActualizaReferencia(aEntidad)
    End Function
    Public Function ObtenercCodgar(ByVal ccodcli As String) As String
        Return mDb.ObtenercCodgar(ccodcli)
    End Function
    Public Function AgregarHijos(ByVal aEntidad As entidadBase) As Integer
        Return mDb.AgregarHijos(aEntidad)
    End Function
    Public Function ActualizarHijos(ByVal aEntidad As entidadBase) As Integer
        Return mDb.ActualizarHijos(aEntidad)
    End Function
    Public Function ObtenerDataSetHijos(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetHijos(ccodcli)
    End Function
    Public Function ObtenerDataSetporHijo(ByVal ccodcli As String, ByVal cnrohij As String) As DataSet
        Return mDb.ObtenerDataSetporHijo(ccodcli, cnrohij)
    End Function
    Public Function QuitarRegistroporHijo(ByVal ccodcli As String, ByVal cnrohij As String) As Integer
        Return mDb.QuitarRegistroporHijo(ccodcli, cnrohij)
    End Function
    Public Function AgregarEstudioSocio(ByVal aEntidad As entidadBase) As Integer
        Return mDb.AgregarEstudioSocio(aEntidad)
    End Function
    Public Function ActualizarEstudioSocio(ByVal aEntidad As entidadBase) As Integer
        Return mDb.ActualizarEstudioSocio(aEntidad)
    End Function
    Public Function ExisteRegistroSocioEco(ByVal cCodcli As String) As Boolean
        Return mDb.ExisteRegistroSocioEco(cCodcli)
    End Function
    Public Function RecuperarEstudioSocio(ByVal aEntidad As entidadBase) As Integer
        Return mDb.RecuperarEstudioSocio(aEntidad)
    End Function
    Public Function RecuperarDireccion(ByVal cCodcli As String) As String
        Return mDb.RecuperarDireccion(cCodcli)
    End Function
    Public Function VerificaDocumento(ByVal cCodigo As String) As Boolean
        Return mDb.VerificaDocumento(cCodigo)
    End Function
    Public Function ClienteMayorEdad() As String
        Return mDb.ClienteMayorEdad()
    End Function
    Public Function RecuperarNombre(ByVal cCodcta As String) As String
        Return mDb.RecuperarNombre(cCodcta)
    End Function
    Public Function ObtenerDatosGrupo(ByVal ccodcli As String) As String
        Return mDb.ObtenerDatosGrupo(ccodcli)
    End Function
    Public Function ActualizaCodigoRechazo(ByVal cCodcli As String, ByVal cCodrec As String, ByVal ccodusu As String, ByVal dfecha As Date) As Integer
        Return mDb.ActualizaCodigoRechazo(cCodcli, cCodrec, ccodusu, dfecha)
    End Function
    Public Function ObtieneClientesRechazados(ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Return mDb.ObtieneClientesRechazados(dfec1, dfec2)
    End Function
    Public Function StatusCliente(ByVal ccodcli As String) As String
        Return mDb.StatusCliente(ccodcli)
    End Function
    Public Function ActualizaClimideI(ByVal ccodcli As String, ByVal lccodagennuevo As String) As Integer
        Return mDb.ActualizaClimideI(ccodcli, lccodagennuevo)
    End Function
    Public Function ObtenerDatosClimide(ByVal cCodcli As String) As DataSet
        Return mDb.ObtenerDatosClimide(cCodcli)
    End Function
    Public Function EliminarReferencias(ByVal ccodcli As String) As Integer
        Return mDb.EliminarReferencias(ccodcli)
    End Function
    Public Function ObtenerReferencias(ByVal ccodcli) As DataSet
        Return mDb.ObtenerReferencias(ccodcli)
    End Function
    Public Function AgregarReferencias(ByVal aEntidad As entidadBase) As Integer
        Return mDb.AgregarReferencias(aEntidad)
    End Function
    Public Function RecuperarZona(ByVal cCodcli As String) As String
        Return mDb.RecuperarZona(cCodcli)
    End Function
    Public Function ObtenerDataSetporOficina(ByVal ccodreg As String, ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerDataSetporOficina(ccodreg, ccodofi)
    End Function
    Public Function Documento_cliente_Existente(ByVal ccodigo As String, ByVal ccodcli As String) As Boolean
        Return mDb.Documento_cliente_Existente(ccodigo, ccodcli)
    End Function

    Public Function Buscar_Socio_ID(ByVal asociado As String) As DataSet
        Return mDb.Buscar_Socio_ID(asociado)
    End Function

    Public Function Extraer_Datos_Socio(ByVal pntipo As Integer, ByVal pcdescri As String) As DataSet
        Return mDb.Extraer_Datos_Socio(pntipo, pcdescri)
    End Function

    Public Function Mantenimiento_Clientes(ByVal Detalle_Cta As ArrayList, ByVal dt_ben As DataTable, _
                                           ByVal dt_firm As DataTable, ByVal dt_benAport As DataTable, _
                                           ByVal dt_Ref As DataTable) As String
        Return mDb.Mantenimiento_Clientes(Detalle_Cta, dt_ben, dt_firm, dt_benAport, dt_Ref)

    End Function
End Class
