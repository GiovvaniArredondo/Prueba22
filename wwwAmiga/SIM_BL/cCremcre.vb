Public Class cCremcre

#Region " Privadas "
    Private mDb As New dbCremcre
    Private mEntidad As cremcre
#End Region

    Public Function contratoProducto(ByVal ccodcta As String) As String
        Return mDb.contratoProducto(ccodcta)
    End Function

    Public Function ObtenerLista() As listacremcre
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function CancelarCredito(ByVal ccodcta As String)
        Return mDb.CancelarCredito(ccodcta)
    End Function

    Public Function ObtenerCremcre(ByRef mEntidad As cremcre) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
    Public Function EliminarSeguros(ByVal ccodcta As String) As Integer
        Return mDb.EliminarSeguros(ccodcta)
    End Function

    Public Function EliminarCremcre(ByVal ccodcta As String) As Integer
        Dim mEntidad As New cremcre
        mEntidad.ccodcta = ccodcta
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarCremcre(ByVal aEntidad As cremcre) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerListaPorCliente(ByVal codcli As String) As listacremcre
        Return mDb.ObtenerListaPorCliente(codcli)
    End Function
    Public Function obtenerlis() As listacremcre
        Return mDb.ObtenerListaPorID()
    End Function

    Public Function ActualizarCremcreRev(ByVal aEntidad As cremcre) As Integer
        Return mDb.ActualizarCRe(aEntidad)
    End Function


    Public Function ModificaCremcre(ByVal aEntidad As cremcre) As Integer
        Return mDb.ModificaCremcre(aEntidad)
    End Function
    Public Function ActualizarCremcreSug(ByVal aEntidad As cremcre) As Integer
        Return mDb.ActualizarSug(aEntidad)
    End Function
    'grabaInfoConavi(ByVal ccodcta As String, ByVal txtInfoConavi As String)
    Public Function updateInfoConavi(ByVal ccodcta As String, ByVal txtInfoConavi As String)
        Return mDb.updateInfoConavi(ccodcta, txtInfoConavi)
    End Function
    Public Function ActualizarCremcreApr(ByVal aEntidad As cremcre) As Integer
        Return mDb.ActualizarApr(aEntidad)
    End Function

    Public Function ObtenerDataSetPorIDRC(ByVal cCodCta As String) As DataSet
        Return mDb.ObtenerDataSetPorIDRC(cCodCta)
    End Function
    Public Function ObtenerDataSetPorIDAC(ByVal cCodCta As String) As DataSet
        Return mDb.ObtenerDataSetPorIDAC(cCodCta)
    End Function
    Public Function ObtenerListaPorID() As listacremcre
        Return mDb.ObtenerListaPorID()
    End Function
    Public Function ObtenerListaPorcredito(ByVal codcta As String) As listacremcre
        Return mDb.ObtenerListaPorcredito(codcta)
    End Function
    Public Function ActualizarPlan(ByVal aEntidad As cremcre) As Integer
        Return mDb.ActualizarPlan(aEntidad)
    End Function

    Public Function Actualizar1(ByVal aEntidad As cremcre) As Integer
        Return mDb.Actualizar1(aEntidad)
    End Function

    Public Function Actualizar2(ByVal aEntidad As cremcre) As Integer
        Return mDb.Actualizar2(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As cremcre) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function Actualizar(ByVal aEntidad As cremcre) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetPor_cliente(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetPor_cliente(ccodcli)
    End Function
    Public Function ActualizarAnalista(ByVal aEntidad As cremcre) As Integer
        Return mDb.ActualizarAnalista(aEntidad)
    End Function
    Public Function CreditosxGrupo(ByVal cCodsol As String) As DataSet
        Return mDb.CreditosxGrupo(cCodsol)
    End Function
    Public Function SeguroVida(ByVal cCodcta As String) As Double
        Return mDb.SeguroVida(cCodcta)
    End Function
    Public Function PresAnt(ByVal cCodcta As String) As Double
        Return mDb.PresAnt(cCodcta)
    End Function
    Public Function PresGrAnt(ByVal cCodsol As String) As Date
        Return mDb.PresGrAnt(cCodsol)
    End Function
    Public Function AntSocio(ByVal ccodcli As String, ByVal ccodsol As String, ByVal dfecha As Date) As Integer
        Return mDb.AntSocio(ccodcli, ccodsol, dfecha)
    End Function
    Public Function ObtenerPresidenta(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Return mDb.ObtenerPresidenta(cCodsol, dfecha)
    End Function
    Public Function ObtenerSocias(ByVal cCodsol As String) As DataSet
        Return mDb.ObtenerSocias(cCodsol)
    End Function
    Public Function ObtenerSociasporCentro(ByVal cCodsol As String) As DataSet
        Return mDb.ObtenerSociasporCentro(cCodsol)
    End Function
    Public Function ObtenerSocia(ByVal cCodcta As String) As DataSet
        Return mDb.ObtenerSocia(cCodcta)
    End Function
    Public Function EliminaTablaPagos(ByVal cCodsol As String) As Integer
        Return mDb.EliminaTablaPagos(cCodsol)
    End Function
    Public Function InsertaTablaPagos(ByVal ccodcta As String, ByVal cnomcli As String, ByVal ncuota As Double, ByVal npago As Double, ByVal lsolidario As Boolean, ByVal ndeuda As Double, ByVal ccodsol As String) As Integer
        Return mDb.InsertaTablaPagos(ccodcta, cnomcli, ncuota, npago, lsolidario, ndeuda, ccodsol)
    End Function
    Public Function ActualizaTablaPagos(ByVal ccodcta As String, ByVal npago As Double, ByVal lsolidario As Boolean, ByVal ccodsol As String) As Integer
        Return mDb.ActualizaTablaPagos(ccodcta, npago, lsolidario, ccodsol)
    End Function
    Public Function ObtenerTablaPagos(ByVal ccodsol As String) As DataSet
        Return mDb.ObtenerTablaPagos(ccodsol)
    End Function

    Public Function Actualizargrupo(ByVal aEntidad As cremcre) As Integer
        Return mDb.ActualizarGrupo(aEntidad)
    End Function
    Public Function TasaCredito(ByVal cCodcta As String) As Double
        Return mDb.TasaCredito(cCodcta)
    End Function
    Public Function CargaListadoChk() As DataSet
        Return mDb.CargaListadoChk()
    End Function
    Public Function CargaListadoChkCliente(ByVal cCodcta As String, ByVal ccodusu As String) As DataSet
        Return mDb.CargaListadoChkCliente(cCodcta, ccodusu)
    End Function
    Public Function CargaListadoChkxItem(ByVal cCodcta As String, ByVal ccodchk As String, ByVal ccodusu As String) As DataSet
        Return mDb.CargaListadoChkxItem(cCodcta, ccodchk, ccodusu)
    End Function
    Public Function EliminaListaxUsuario(ByVal cCodcta As String, ByVal cCodusu As String) As Integer
        Return mDb.EliminaListaxUsuario(cCodcta, cCodusu)
    End Function
    Public Function InsertaListaxUsuario(ByVal cCodcta As String, ByVal cCodusu As String, ByVal lopcion As Boolean, ByVal ccodchk As String, ByVal dfecreg As Date) As Integer
        Return mDb.InsertaListaxUsuario(cCodcta, cCodusu, lopcion, ccodchk, dfecreg)
    End Function
    Public Function PlantillaChequeo() As DataSet
        Return mDb.PlantillaChequeo()
    End Function
    Public Function UsuarioqChequearon(ByVal cCodcta As String) As DataSet
        Return mDb.UsuarioqChequearon(cCodcta)
    End Function
    Public Function ListadoxUsuario(ByVal cCodusu As String, ByVal cCodcta As String, ByVal cCodchk As String) As Boolean
        Return mDb.ListadoxUsuario(cCodusu, cCodcta, cCodchk)
    End Function
    Public Function VerificaConsistencias(ByVal cCodsol As String) As Boolean
        Return mDb.VerificaConsistencias(cCodsol)
    End Function
    Public Function ObtenerNombrexCuenta(ByVal cCodsol As String) As String
        Return mDb.ObtenerNombrexCuenta(cCodsol)
    End Function
    Public Function ObtenerCreditosxGrupo(ByVal cCodsol As String, ByVal dfecha As Date, ByVal dfecha2 As Date) As DataSet
        Return mDb.ObtenerCreditosxGrupo(cCodsol, dfecha, dfecha2)
    End Function

    Public Function ValidaSolicitudPendiente(ByVal cCodcli As String) As Boolean
        Return mDb.ValidaSolicitudPendiente(cCodcli)
    End Function
    'Agregado para Validar el estatus del cliente
    Public Function Buscar_Creditos_codigos(ByVal codigo As String) As String
        Return mDb.Buscar_Creditos_codigos(codigo)
    End Function
    Public Function ValidaSolicitudPendienteGrupal(ByVal cCodcli As String) As Boolean
        Return mDb.ValidaSolicitudPendienteGrupal(cCodcli)
    End Function
    Public Function BuscaCreditos(ByVal codgrupal As String) As DataSet
        Return mDb.BuscaCreditos(codgrupal)
    End Function
    Public Function obtenerGrupos(ByVal codigogrupal As String) As DataSet
        Return mDb.obtenerGrupos(codigogrupal)
    End Function
    Public Function validarReglasProductos(ByVal ccodsol As String) As Integer
        Return mDb.validarReglasProductos(ccodsol)
    End Function
    Public Function obtenerCcodsolxClientes(ByVal ccodcli) As DataSet
        Return mDb.obtenerCcodsolxClientes(ccodcli)
    End Function
    Public Function obtenercuentasEstatus(ByVal ccodsol As String) As DataSet
        Return mDb.obtenercuentasEstatus(ccodsol)
    End Function

    Public Function Sabado() As Boolean
        Return mDb.Sabado
    End Function
    Public Function Domingo() As Boolean
        Return mDb.Domingo
    End Function
    Public Function ValidaRetiroGrupo(ByVal cCodcli) As Boolean
        Return mDb.ValidaRetiroGrupo(cCodcli)
    End Function
    Public Function ObtieneAnalistaGrupal(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Return mDb.ObtieneAnalistaGrupal(cCodsol, dfecha)
    End Function
    Public Function CambiaAnalistaGrupal(ByVal cCodsol As String, ByVal dfecha As Date, ByVal ccodana As String) As Integer
        Return mDb.CambiaAnalistaGrupal(cCodsol, dfecha, ccodana)
    End Function
    Public Function ValidaExistenciaCredito(ByVal ccodsol As String, ByVal dfecha As Date) As Boolean
        Return mDb.ValidaExistenciaCredito(ccodsol, dfecha)
    End Function
    Public Function ReseteaProvision(ByVal cCodcta As String) As Integer
        Return mDb.ReseteaProvision(cCodcta)
    End Function
    Public Function Provisionado(ByVal ccodcta As String) As DataSet
        Return mDb.Provisionado(ccodcta)
    End Function
    Public Function ActualizaProvision(ByVal cCodcta As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer
        Return mDb.ActualizaProvision(cCodcta, nIntAct, nDesInt)
    End Function
    Public Function VerificaRegistroProvision(ByVal cCodcta As String) As Boolean
        Return mDb.VerificaRegistroProvision(cCodcta)
    End Function
    Public Function InsertaRegistroProvision(ByVal cCodcta As String) As Integer
        Return mDb.InsertaRegistroProvision(cCodcta)
    End Function
    Public Function RegistraProvisionDiario(ByVal cCodcta As String, ByVal nintdia As Double, ByVal dfecha As Date, ByVal nprovmor As Double) As Integer
        Return mDb.RegistraProvisionDiaria(cCodcta, nintdia, dfecha, nprovmor)
    End Function
    Public Function RegistraProvisionMensual1(ByVal dfecha As Date) As Integer
        Return mDb.RegistraProvisionMensual1(dfecha)
    End Function
    Public Function RegistraProvisionMensual2(ByVal cCodcta As String, ByVal nintdia As Double, ByVal dfecha As Date) As Integer
        Return mDb.RegistraProvisionMensual2(cCodcta, nintdia, dfecha)
    End Function

    Public Function ActualizaCremcre(ByVal cCodcta As String, ByVal ndiaatr As Integer) As Integer
        Return mDb.ActualizaCremcre(cCodcta, ndiaatr)
    End Function
    Public Function InicializaMes() As Integer
        Return mDb.InicializaMes()
    End Function
    Public Function RecuperarProvisionAcumulada(ByVal cCodigo As String, ByVal cmetodo As String, ByVal ccodofi As String) As Double
        Return mDb.RecuperarProvisionAcumulada(cCodigo, cmetodo, ccodofi)
    End Function
    Public Function RecuperarProvision() As DataSet
        Return mDb.RecuperarProvision()
    End Function
    Public Function ActualizarCierreCremcre(ByVal aEntidad As entidadBase) As Integer
        Return mDb.ActualizarCierreCremcre(aEntidad)
    End Function
    Public Function ActualizarCalificacionCremcre(ByVal aEntidad As entidadBase) As Integer
        Return mDb.ActualizarCalificacionCremcre(aEntidad)
    End Function
    Public Function EliminaAsientos() As Integer
        Return mDb.EliminaAsientos()
    End Function
    Public Function AgregaAsiento(ByVal cCodcta As String, ByVal cdescri As String, ByVal ndebe As Double, ByVal nhaber As Double, _
                              ByVal cCodlin As String, ByVal cdestra As String, ByVal ffondos As String, ByVal ctipmet As String, ByVal ccodpres As String, ByVal ccodofi As String) As Integer
        Return mDb.AgregaAsiento(cCodcta, cdescri, ndebe, nhaber, cCodlin, cdestra, ffondos, ctipmet, ccodpres, ccodofi)
    End Function
    Public Function RecuperarAsiento(ByVal ccodigo As String, ByVal cmetodo As String, ByVal cCodofi As String) As DataSet
        Return mDb.RecuperarAsiento(ccodigo, cmetodo, cCodofi)
    End Function
    Public Function ActualizaCondicion(ByVal cCodcta As String, ByVal cCondicion As String) As Integer
        Return mDb.ActualizaCondicion(cCodcta, cCondicion)
    End Function
    Public Function ActualizaCondicionContra(ByVal cCodcta As String, ByVal cCondicion As String) As Integer
        Return mDb.ActualizaCondicionContra(cCodcta, cCondicion)
    End Function
    Public Function RecuperaCreditosReclasificados(ByVal cCodofi As String)
        Return mDb.RecuperaCreditosReclasificados(cCodofi)
    End Function
    Public Function StatusCredito(ByVal cCondic As String) As String
        Return mDb.StatusCredito(cCondic)
    End Function
    Public Function ObtenerSociasporCentroAnular(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.ObtenerSociasporCentroAnular(cCodsol, dfecha)
    End Function
    Public Function ObtenerClientedeGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As DataSet
        Return mDb.ObtenerClientedeGrupo(cCodsol, dfecha)
    End Function
    Public Function CodigoAnalistadeGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Return mDb.CodigoAnalistadeGrupo(cCodsol, dfecha)
    End Function
    Public Function LineadeGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Return mDb.LineadeGrupo(cCodsol, dfecha)
    End Function
    Public Function NumeroLineaGrupo(ByVal cCodsol As String, ByVal dfecha As Date) As String
        Return mDb.NumeroLineaGrupo(cCodsol, dfecha)
    End Function
    Public Function OficinaAsientos() As DataSet
        Return mDb.OficinaAsientos()
    End Function
    Public Function ActualizaCremcreRees(ByVal cCodcta As String, ByVal dfecven As Date, ByVal ncuoapr As Integer, ByVal nmoncuo As Decimal, ByVal cfreccap As String, ByVal cfrecint As String, ByVal nintmor As Decimal) As Integer
        Return mDb.ActualizaCremcreRees(cCodcta, dfecven, ncuoapr, nmoncuo, cfreccap, cfrecint, nintmor)
    End Function
    Public Function ActualizaSuspensiondeCredito(ByVal ccodcta As String, ByVal dfectra As Date, ByVal ccontra As String, ByVal nperiodo As Integer) As Integer
        Return mDb.ActualizaSuspensiondeCredito(ccodcta, dfectra, ccontra, nperiodo)
    End Function
    Public Function ActualizaCremcreExtra(ByVal cCodcta As String, ByVal dfecven As Date, ByVal ncuoapr As Integer, ByVal nCapdes As Double, ByVal nmonapr As Double) As Integer
        Return mDb.ActualizaCremcreExtra(cCodcta, dfecven, ncuoapr, nCapdes, nmonapr)
    End Function
    Public Function VerficaExisteBase(ByVal nombre As String) As Integer
        Return mDb.VerficaExisteBase(nombre)
    End Function
    Public Function CrearBasedeDatos(ByVal MyDatabase As String) As Integer
        Return mDb.CrearBasedeDatos(MyDatabase)
    End Function
    Public Function ObtieneSolicitudPendienteGrupal(ByVal cCodcli As String) As DataSet
        Return mDb.ObtieneSolicitudPendienteGrupal(cCodcli)
    End Function
    Public Function ObtieneSolicitudPendiente(ByVal cCodcli As String) As Boolean
        Return mDb.ObtieneSolicitudPendiente(cCodcli)
    End Function
    Public Function ActualizaCodigoRechazo(ByVal cCodcta As String, ByVal cCodrec As String, ByVal ccodusu As String, ByVal dfecha As Date) As Integer
        Return mDb.ActualizaCodigoRechazo(cCodcta, cCodrec, ccodusu, dfecha)
    End Function
    Public Function ObtenerSaldoAjuste(ByVal cCodcta As String) As Double
        Return mDb.ObtenerSaldoAjuste(cCodcta)
    End Function
    Public Function ObtieneCreditosCliente(ByVal cCodcli As String) As Boolean
        Return mDb.ObtieneCreditosCliente(cCodcli)
    End Function
    Public Function ObtieneCreditosRechazados(ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Return mDb.ObtieneCreditosRechazados(dfec1, dfec2)
    End Function
    Public Function ValidaCreditoConyugue(ByVal cedula As String, ByVal ccodofi As String) As Boolean
        Return mDb.ValidaCreditoConyugue(cedula, ccodofi)
    End Function
    Public Function InsertaFechaBackup(ByVal fecha As String, ByVal base As String) As Integer
        Return mDb.InsertaFechaBackup(fecha, base)
    End Function
    Public Function GrabaInteresCongelado(ByVal ccodcta As String, ByVal nmonto As Decimal) As Integer
        Return mDb.GrabaInteresCongelado(ccodcta, nmonto)
    End Function
    Public Function ActualizaAgencia2FC(ByVal lccodpres As String, ByVal lccodagennuevo As String) As Integer
        Return mDb.ActualizaAgencia2FC(lccodpres, lccodagennuevo)
    End Function
    Public Function ActualizaNrodeLinea2FC(ByVal cnrolin As String, ByVal lccodpres As String, ByVal lccodfue As String) As Integer
        Return mDb.ActualizaNrodeLinea2FC(cnrolin, lccodpres, lccodfue)
    End Function
    Public Function RecuperarProvisionAcumuladaMora(ByVal cCodigo As String, ByVal cmetodo As String, ByVal ccodofi As String) As Double
        Return mDb.RecuperarProvisionAcumuladaMora(cCodigo, cmetodo, ccodofi)
    End Function
    Public Function RecuperarProvisionCredito(ByVal cCodigo As String) As DataSet
        Return mDb.RecuperarProvisionCredito(cCodigo)
    End Function

    Public Function VerificaSiExisteEspejo(ByVal cCodcta As String, ByVal cnrodoc As String) As Boolean
        Return mDb.VerificaSiExisteEspejo(cCodcta, cnrodoc)
    End Function
    Public Function InsertaRegistroProvisionEspejo(ByVal cCodcta As String, ByVal cnrodoc As String) As Integer
        Return mDb.InsertaRegistroProvisionEspejo(cCodcta, cnrodoc)
    End Function
    Public Function ActualizaProvisionEspejo(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer
        Return mDb.ActualizaProvisionEspejo(cCodcta, cnrodoc, nIntAct, nDesInt)
    End Function
    Public Function ActualizaProvisionEspejo2(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer
        Return mDb.ActualizaProvisionEspejo2(cCodcta, cnrodoc, nIntAct, nDesInt)
    End Function
    Public Function ObtenerEspejoProvision(ByVal cCodcta As String, ByVal cnrodoc As String) As DataSet
        Return mDb.ObtenerEspejoProvision(cCodcta, cnrodoc)
    End Function
    Public Function ActualizaProvisiondeEspejo(ByVal cCodcta As String, ByVal nprovis As Double, ByVal nprovan As Double, ByVal nprovmor As Double, ByVal nprovis2 As Double) As Integer
        Return mDb.ActualizaProvisiondeEspejo(cCodcta, nprovis, nprovan, nprovmor, nprovis2)
    End Function
    Public Function ActualizaProvisionEspejoM(ByVal cCodcta As String, ByVal cnrodoc As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer
        Return mDb.ActualizaProvisionEspejoM(cCodcta, cnrodoc, nIntAct, nDesInt)
    End Function
    Public Function ActualizaProvisionM(ByVal cCodcta As String, ByVal nIntAct As Double, ByVal nDesInt As Double) As Integer
        Return mDb.ActualizaProvisionM(cCodcta, nIntAct, nDesInt)
    End Function
    Public Sub GenerarBackup(ByVal dfecha As Date)
        mDb.GenerarBackup(dfecha)
    End Sub
    Public Function TrasladaDatos(ByVal aEntidad As entidadBase) As Integer
        Return mDb.TrasladaDatos(aEntidad)
    End Function
    Public Function Actualiza_Numero_Partida(ByVal ccodigo As String, ByVal cmetodo As String, ByVal cCodofi As String, ByVal cnumcom As String) As DataSet
        Return mDb.Actualiza_Numero_Partida(ccodigo, cmetodo, cCodofi, cnumcom)
    End Function

    Public Function InteresMoratorio(ByVal cCodcta As String) As Double
        Return mDb.InteresMoratorio(cCodcta)
    End Function

    Public Function DestinoCredito(ByVal cCodcta As String) As String
        Return mDb.DestinoCredito(cCodcta)
    End Function

    Public Function FormadePago(ByVal cCodcta As String) As String
        Return mDb.FormadePago(cCodcta)
    End Function

    Public Function Extrae_Datos_Arhivo_Dispersion(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                   ByVal lldispersa As Integer) As DataSet
        Return mDb.Extrae_Datos_Arhivo_Dispersion(pdfecini, pdfecfin, lldispersa)
    End Function

    Public Function Extrae_Datos_Arhivo_Dispersion_Garantias(ByVal pdfecini As Date, ByVal pdfecfin As Date, _
                                                            ByVal lldispersa As Integer) As DataSet
        Return mDb.Extrae_Datos_Arhivo_Dispersion_Garantias(pdfecini, pdfecfin, lldispersa)
    End Function

    Public Function Extrae_Datos_Grupo_Solidario(ByVal ccodigo As String) As DataSet
        Return mDb.Extrae_Datos_Grupo_Solidario(ccodigo)
    End Function

    Public Function Extrae_Datos_Grupo_Solidario_Impresion(ByVal ccodigo As String) As DataSet
        Return mDb.Extrae_Datos_Grupo_Solidario_Impresion(ccodigo)
    End Function

    Public Function Actualiza_Bandera_Digitalización(ByVal ccodcta As String) As Integer
        Return mDb.Actualiza_Bandera_Digitalización(ccodcta)
    End Function
    'Select a tabla de comprobantes 
    Public Function select_datosComprobante(ByVal ccodcli As String, ByVal ccodcligar As String) As Integer
        Return mDb.select_datosComprobante(ccodcli, ccodcligar)
    End Function
    'Inserta datos en tabla de comprobantes
    Public Function inserta_datos_ComprobantesGarantias(ByVal ccodcli As String, ByVal inserccodgar_gar As String, ByVal ccodcligar As String) As Integer
        Return mDb.inserta_datos_ComprobantesGarantias(ccodcli, inserccodgar_gar, ccodcligar)
    End Function

    'Valida carga de foto si retorna 1 Envia
    Public Function Actualiza_banderas_Comprobante(ByVal codigo As String, ByVal inserccodgar_gar As String, ByVal ccodcligar As String, ByVal firma As String) As Integer
        Return mDb.Actualiza_banderas_Comprobante(codigo, inserccodgar_gar, ccodcligar, firma)
    End Function

    Public Function Actualiza_Usuario_Nivel_Comite(ByVal Comite As String, ByVal idusuario As Integer, _
                                                   ByVal pcCodcta As String) As Integer
        Return mDb.Actualiza_Usuario_Nivel_Comite(Comite, idusuario, pcCodcta)
    End Function

    Public Function Valida_Creditos_Vigentes_porCliente(ByVal cCodcli As String) As Boolean
        Return mDb.Valida_Creditos_Vigentes_porCliente(cCodcli)
    End Function

    Public Function Realiza_Cambio_Estado_Credito(ByVal pcCodcta As String, ByVal pcEstado As String) As Integer
        Return mDb.Realiza_Cambio_Estado_Credito(pcCodcta, pcEstado)
    End Function

    Public Function Realiza_Cambio_Estado_Credito_Sol(ByVal dt_grupo As DataTable, ByVal pcEstado As String) As Integer
        Return mDb.Realiza_Cambio_Estado_Credito_Sol(dt_grupo, pcEstado)
    End Function

    Public Function Eliminar_Credito(ByVal pcCodcta As String) As Integer
        Return mDb.Eliminar_Credito(pcCodcta)
    End Function

    Public Function Cartera_Promociones(ByVal cCodofi As String, ByVal ndias As Integer, _
                                    ByVal pdfecha As Date) As DataSet
        Return mDb.Cartera_Promociones(cCodofi, ndias, pdfecha)
    End Function

    Public Function Cartera_Promociones_Detalle(ByVal cCodofi As String, ByVal ndias As Integer, _
                                                ByVal pdfecha As Date) As DataSet
        Return mDb.Cartera_Promociones_Detalle(cCodofi, ndias, pdfecha)
    End Function

    Public Function Valida_Porcentaje_Refina(ByVal cCodcli As String, ByVal pnPorcenLim As Integer) As Boolean
        Return mDb.Valida_Porcentaje_Refina(cCodcli, pnPorcenLim)
    End Function

    Public Function Actualizar_Oficina_Credito(ByVal pcCodcta As String, ByVal pcCodofi As String) As Integer
        Return mDb.Actualizar_Oficina_Credito(pcCodcta, pcCodofi)
    End Function
End Class

