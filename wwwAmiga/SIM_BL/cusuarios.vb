Public Class cusuarios
#Region " Privadas "
    Private mDb As New dbUsuarios
    Private mEntidad As usuarios
#End Region

    Public Function ObtenerLista() As listausuarios
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerListaporID2(ByVal cCatego As String) As listausuarios
        Return mDb.ObtenerListaPorID2(cCatego)
    End Function

    Public Function Obtenerusuarios(ByRef mEntidad As usuarios) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function Eliminarusuarios(ByVal ccodusu As String) As Integer
        Dim mEntidad As New usuarios
        mEntidad.idUsuario = ccodusu
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function Actualizarusuarios(ByVal aEntidad As usuarios) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function


    Public Function ObtenerListaPorusuario(ByVal usuario1 As String) As listausuarios
        Return mDb.ObtenerListaPorusuario(usuario1)
    End Function


    Public Function ObtenerListaPorcodigo(ByVal usuario1 As Integer) As listausuarios
        Return mDb.ObtenerListaPorcodigo(usuario1)
    End Function

    Public Function ObtenerID(ByVal aEntidad As usuarios) As Integer
        Return mDb.ObtenerID(aEntidad)
    End Function


    Public Function agregar(ByVal aEntidad As usuarios) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function ObtenerNAnalistas() As Integer
        Return mDb.ObtenerNAnalistas()
    End Function
    Public Function analistas() As DataSet
        Return mDb.Analistas()
    End Function
    Public Function ActualizaClave(ByVal usuario As String, ByVal clave As String, ByVal dfecven As Date) As Integer
        Return mDb.ActualizaClave(usuario, clave, dfecven)
    End Function
    Public Function ActualizaEstado(ByVal usuario As String) As Integer
        Return mDb.ActualizaEstado(usuario)
    End Function
    Public Function GrabarIntentos(ByVal usuario As String, ByVal intentos As Integer) As Integer
        Return mDb.GrabarIntentos(usuario, intentos)
    End Function
    Public Function RecuperarIntentos(ByVal usuario As String) As Integer
        Return mDb.RecuperarIntentos(usuario)
    End Function
    Public Function RecuperarEstatus(ByVal usuario As String) As Boolean
        Return mDb.RecuperarEstatus(usuario)
    End Function
    Public Function RegistraAuditoria(ByVal aEntidad As usuarios) As Integer
        Return mDb.RegistraAuditoria(aEntidad)
    End Function
    Public Function Oficina(ByVal usuario As String) As String
        Return mDb.Oficina(usuario)
    End Function
    Public Function VerificarAccesoGrupo(ByVal usuario As String) As Boolean
        Return mDb.VerificarAccesoGrupo(usuario)
    End Function
    Public Function IdUsuario(ByVal usuario As String) As Integer
        Return mDb.IdUsuario(usuario)
    End Function
    Public Function ObtenerUsuarios2() As DataSet
        Return mDb.ObtieneUsuarios2()
    End Function
    Public Function ObtenerNombreUsuario(ByVal cusuario As String) As String
        Return mDb.ObtenerNombreUsuario(cusuario)
    End Function
    Public Function ValidaProcesaPagos(ByVal usuario As String) As Boolean
        Return mDb.ValidaProcesaPagos(usuario)
    End Function
    Public Function ObtenerCajeros() As DataSet
        Return mDb.ObtenerCajeros()
    End Function
    Public Function ActualizaCajero(ByVal usuario As String, ByVal nvalor As Integer) As Integer
        Return mDb.ActualizaCajero(usuario, nvalor)
    End Function
    Public Function ValidaCuentaCajero(ByVal ccodusu As String) As Boolean
        Return mDb.ValidaCuentaCajero(ccodusu)
    End Function
    Public Function CuentaContableCajero(ByVal ccodusu As String) As String
        Return mDb.CuentaContableCajero(ccodusu)
    End Function
    Public Function ObtenerCajerosOficina(ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerCajerosOficina(ccodofi)
    End Function
    Public Function ValidaSesionUsuario(ByVal ccodusu As String) As Integer
        Return mDb.ValidaSesionUsuario(ccodusu)
    End Function
    Public Function VerificaCargo(ByVal usuario As String, ByVal ccodofi As String, ByVal cargo As String) As Boolean
        Return mDb.VerificaCargo(usuario, ccodofi, cargo)
    End Function
    Public Function ObtenerCajerosAgencias(ByVal ccodofi As String) As DataSet
        Return mDb.ObtenerCajerosAgencias(ccodofi)
    End Function
    Public Function ObtnerDataSetPorNombre(ByVal cnombre As String) As DataSet
        Return mDb.ObtenerDataSetNombre(cnombre)
    End Function
    Public Function ObtnerDataSetPorNombreActivoFijo(ByVal cnombre As String) As DataSet
        Return mDb.ObtenerDataSetNombreActivoFijo(cnombre)
    End Function
    Public Function ObtenerResponsableCC(ByVal ccodofi As String, ByVal ccodusu As String) As DataSet
        Return mDb.ObtenerResponsableCC(ccodofi, ccodusu)
    End Function

    Public Function RecuperarUsuario(ByRef mEntidad As usuarios) As String
        Return mDb.RecuperarUsuario(mEntidad)
    End Function

    Public Function NombreUsuario(ByVal ccodusu As String) As String
        Return mDb.NombreUsuario(ccodusu)
    End Function

    Public Function Extrae_Usuarios_Activos() As DataSet
        Return mDb.Extrae_Usuarios_Activos()
    End Function

    Public Function Actualizar_Firmas_Digitales(ByVal firma As Array, ByVal idusuario As Integer) As Integer
        Return mDb.Actualizar_Firmas_Digitales(firma, idusuario)
    End Function

    Public Function Extrae_Datos_Usuario(ByVal Idusuario As Integer) As DataSet
        Return mDb.Extrae_Datos_Usuario(Idusuario)
    End Function

    Public Function Extraer_Analistas() As DataSet
        Return mDb.Extraer_Analistas()
    End Function

End Class
