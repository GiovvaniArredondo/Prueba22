Public Class cClimgar
 
#Region " Privadas "
    Private mDb as New dbClimgar()
    Private mEntidad as Climgar
#End Region
 
    Public Function ObtenerLista(ByVal ccodcli As String) As listaclimgar
        Return mDb.ObtenerListaPorID(ccodcli)
    End Function

    Public Function ObtenerClimgar(ByRef mEntidad As climgar) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
    Public Function EliminarClimgar(ByVal ccodcli As String, ByVal ccodgar As String) As Integer
        Dim mEntidad As New climgar
        mEntidad.ccodcli = ccodcli
        mEntidad.ccodgar = ccodgar

        Return mDb.Eliminar(mEntidad)
    End Function
    'Public Function EliminarClimgar(ByVal aEntidad As climgar) As Integer
    '    Return mDb.Eliminar(mEntidad)
    'End Function

    Public Function ActualizarClimgar(ByVal aEntidad As climgar) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function ObtenerDataSetEspc(ByVal cCodigo As String) As DataSet
        Return mDb.ObtenerDataSetEspc(cCodigo)
    End Function
    Public Function ObtenerDataSetRepo(ByVal cCodcli As String) As DataSet
        Return mDb.ObtenerDataSetRepo(cCodcli)
    End Function
    Public Function ObtenerDataSetporcCodgar(ByVal cCodigo As String, ByVal cCodgar As String) As DataSet
        Return mDb.ObtenerDataSetporcCodgar(cCodigo, cCodgar)
    End Function
    'Cambio 29 07 2015 --
    Public Function Obtener_estatus(ByVal ccodcli As String, ByVal ccodgar As String) As String
        Return mDb.Obtener_estatus(ccodcli, ccodgar)
    End Function
  Public Function ObtenercCodgar(ByVal cCodcli As String) As String
        Return mDb.ObtenercCodgar(cCodcli)
    End Function
    Public Function Agregar(ByVal aEntidad As climgar) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    'Fran Eric
    Public Function ObtenerDataSetEspc1(ByVal cCodcli As String) As DataSet
        Return mDb.ObtenerDataSetEspc1(cCodcli)
    End Function
    Public Function Actualizar1(ByVal aEntidad As climgar) As Integer
        Return mDb.Actualizar1(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetPorID(ccodcli)
    End Function
    Public Function ObtenerDataSetPor_Garantia_Cliente(ByVal cCodigo As String, ByVal ctipgar As String) As DataSet
        Return mDb.ObtenerDataSetPor_Garantia_Cliente(cCodigo, ctipgar)
    End Function
    Public Function ObtenerDataSetPor_Garantia_Prendaria(ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerDataSetPor_Garantia_Prendaria(ccodigo)
    End Function
    Public Function Fiadores(ByVal ccodcli As String) As DataSet
        Return mDb.Fiadores(ccodcli)
    End Function
    Public Function GarantiaTipo(ByVal ccodcli As String) As String
        Return mDb.GarantiaTipo(ccodcli)
    End Function
    Public Function ValorGarantia(ByVal ccodcli As String) As Double
        Return mDb.ValorGarantia(ccodcli)
    End Function
    Public Function ClimHip(ByVal ccodcli) As DataSet
        Return mDb.ClimHip(ccodcli)
    End Function
    Public Function ActualizarHipo(ByVal aEntidad As climgar) As Integer
        Return mDb.ActualizarHipo(aEntidad)
    End Function
    Public Function RepgHip(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfec As String, ByVal cestados As String, ByVal copcion As Integer)
        Return mDb.RepgHip(dfecini, dfecfin, cfec, cestados, copcion)
    End Function
    Public Function DatosFiador(ByVal pcCodcta As String) As String
        Return mDb.DatosFiador(pcCodcta)
    End Function
    Public Function ValidaGarantiaPref(ByVal pccodcli As String) As Integer
        Return mDb.ValidaGarantiaPref(pccodcli)
    End Function
    Public Function CreditosdeCodeudor(ByVal ccodcli As String) As String
        Return mDb.CreditosdeCodeudor(ccodcli)
    End Function
    Public Function ObtenerDataSetEspc12(ByVal ccodcli As String, ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetEspc12(ccodcli, ccodcta)
    End Function
    Public Function ObtenerDataSetEspcGrupal(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetEspcGrupal(ccodcli)
    End Function
    'Nuevo llenado de garantia
    Public Function Proce_LlenadoGrid(ByVal ccodcli As String) As DataSet

        Return mDb.Proce_LlenadoGrid(ccodcli)
    End Function
    Public Function ObtenerDataSetEspcGrupal2(ByVal ccodcli As String) As DataSet
        Return mDb.ObtenerDataSetEspcGrupal2(ccodcli)
    End Function
    Public Function ObtenerDataSetporcCodgarGrupal(ByVal ccodigo As String, ByVal cCodgar As String) As DataSet
        Return mDb.ObtenerDataSetporcCodgarGrupal(ccodigo, cCodgar)
    End Function
    Public Function obtnerCreditos(ByVal ccodcli As String) As String
        Return mDb.obtnerCreditos(ccodcli)
    End Function
    Public Function Buscarmonto(ByVal cnrolin As String) As Integer
        Return mDb.Buscarmonto(cnrolin)
    End Function
    Public Function obtenerSeguro(ByVal ccodcli As String) As String
        Return mDb.obtenerSeguro(ccodcli)
    End Function
    Public Function obtenerSeguros(ByVal ccodcta As String) As Integer
        Return mDb.obtenerSeguros(ccodcta)
    End Function
    Public Function ObtenerDataSetGravamen(ByVal ccodcli As String, ByVal ccodcta As String) As DataSet
        Return mDb.ObtenerDataSetGravamen(ccodcli, ccodcta)
    End Function
    Public Function Datos_Fiadores(ByVal pcCodcta As String) As DataSet
        Return mDb.Datos_Fiadores(pcCodcta)
    End Function

    Public Function Extrae_Garantia_Liquida(ByVal pcCodcli As String) As DataSet
        Return mDb.Extrae_Garantia_Liquida(pcCodcli)
    End Function

    Public Function Actualiza_Garantias_Activas(ByVal pcCodcli As String, ByVal pcCodgar As String, _
                                            ByVal pcEstado As String) As Integer
        Return mDb.Actualiza_Garantias_Activas(pcCodcli, pcCodgar, pcEstado)
    End Function

    Public Function Valida_Existencia_Garantia_Liquida_Activa(ByVal pcCodcli As String) As Boolean
        Return mDb.Valida_Existencia_Garantia_Liquida_Activa(pcCodcli)
    End Function

    Public Function Extrae_Garantia_Pendiente(ByVal pcCodcli As String) As DataSet
        Return mDb.Extrae_Garantia_Pendiente(pcCodcli)
    End Function

    Public Function Actualiza_Auxiliar_Otros_Ing(ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                            ByVal pcTipIng As String, ByVal pdfecpag As Date, _
                                            ByVal pccodusu As String, ByVal pcnomcli As String) As Integer
        Return mDb.Actualiza_Auxiliar_Otros_Ing(pcCodcta, pnmonto, pcTipIng, pdfecpag, pccodusu, pcnomcli)
    End Function

    Public Function Valida_Existencia_Tipo_Ingreso(ByVal pcCodcta As String, ByVal pctiping As String, ByVal fecha_sistema As DateTime) As Boolean
        Return mDb.Valida_Existencia_Tipo_Ingreso(pcCodcta, pctiping, fecha_sistema)
    End Function
    Public Function Extrae_Datos_Otros_Ingresos(ByVal pcCodcta As String) As DataSet
        Return mDb.Extrae_Datos_Otros_Ingresos(pcCodcta)
    End Function

    Public Function Mantenimiento_Otros_Ingresos(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                                 ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
                                                 ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
                                                 ByVal pcEstado As String, ByVal id_identity As Integer) As String
        Return mDb.Mantenimiento_Otros_Ingresos(Encabeza_Part, pcCodcta, pnmonto, pcTipIng, pdfecpag, pccodusu, _
                                                 pcnomcli, pccodcli, pcCodgar, pcEstado, id_identity)
    End Function


    Public Function Entrega_Garantia_Liquida(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                                 ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
                                                 ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
                                                 ByVal pcEstado As String) As String
        Return mDb.Entrega_Garantia_Liquida(Encabeza_Part, pcCodcta, pnmonto, pcTipIng, pdfecpag, pccodusu, _
                                                 pcnomcli, pccodcli, pcCodgar, pcEstado)
    End Function
    Public Function BuscarCredito_(ByVal credito As String) As String

        Return mDb.BuscarCredito_(credito)
    End Function

    Public Function ObtenerDatosCliente(ByVal cocdigoCli As String, ByVal cogar As String) As DataSet


        Return mDb.ObtenerDatosCliente(cocdigoCli, cogar)
    End Function

    Public Function ObtenerDatosCliente_(ByVal cocdigoCli As String, ByVal cogar As String) As DataSet


        Return mDb.ObtenerDatosCliente_(cocdigoCli, cogar)
    End Function

    Public Function Obtener_identiy_climgar(ByVal codigoClie As String, ByVal codigoGar As String) As Integer

        Return mDb.Obtener_identiy_climgar(codigoClie, codigoGar)

    End Function
    'Actualiza ,elimina y  modifica Cuentas Contables ----- con codigo y id de garantias 
    'Public Function Elimina_Garantias(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
    '                                           ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
    '                                           ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
    '                                           ByVal pcEstado As String, ByVal id_identity As Integer) As String
    '    Return mDb.Elimina_Garantias(Encabeza_Part, pcCodcta, pnmonto, pcTipIng, pdfecpag, pccodusu, _
    '                                             pcnomcli, pccodcli, pcCodgar, pcEstado, id_identity)
    'End Function

    Public Function EliminarGarantias(ByVal Encabeza_Part() As String, ByVal pcCodcta As String, ByVal pnmonto As Double, _
                                                 ByVal pcTipIng As String, ByVal pdfecpag As Date, ByVal pccodusu As String, _
                                                 ByVal pcnomcli As String, ByVal pccodcli As String, ByVal pcCodgar As String, _
                                                 ByVal pcEstado As String, ByVal obtiene_idClimgar As String) As String
        Return mDb.EliminarGarantias(Encabeza_Part, pcCodcta, pnmonto, pcTipIng, pdfecpag, pccodusu, _
                                                 pcnomcli, pccodcli, pcCodgar, pcEstado, obtiene_idClimgar)
    End Function
End Class
