Public Class cAhomcrt
 
#Region " Privadas "
    Private mDb as New dbAhomcrt()
    Private mEntidad as Ahomcrt
#End Region
 
    Public Function ObtenerLista() As listaAhomcrt
        Return mDb.ObtenerListaPorID()
    End Function


    Public Function ObtenerLista2() As listaahomcrt
        Return mDb.ObtenerListaPorID2()
    End Function


    Public Function ObtenerAhomcrt(ByRef mEntidad As ahomcrt) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarAhomcrt(ByVal ccodcrt As String) As Integer
        Dim mEntidad As New ahomcrt
        mEntidad.ccodcrt = ccodcrt
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAhomcrt(ByVal aEntidad As ahomcrt) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function


    Public Function ObtenerDataSetporcertificado(ByVal cnombre As String) As DataSet
        Return mDb.ObtenerDataSetporcertificado(cnombre)
    End Function

    Public Function Agregar(ByRef mEntidad As ahomcrt) As Integer
        Return mDb.Agregar(mEntidad)
    End Function


    Public Function ObtenerDataSetporcodcertificado(ByVal ccodcrt As String) As DataSet
        Return mDb.ObtenerDataSetporcodcertificado(ccodcrt)
    End Function

    Public Function Certificadosaplazoxcliente(ByVal ccodcli As String) As DataSet
        Return mDb.Certificadosaplazoxcliente(ccodcli)
    End Function
    Public Function ObtieneTasaPromedioAhorroPlazo(ByVal ccodcta As String) As Decimal
        Return mDb.ObtieneTasaPromedioAhorroPlazo(ccodcta)
    End Function
    Public Function ObtenerCuentas(ByVal cCodcli As String, ByVal cliq As String) As DataSet
        Return mDb.ObtenerCuentas(cCodcli, cliq)
    End Function
    Public Function ObtenerCuentas_(ByVal cCodcli As String, ByVal cliq As String) As DataSet
        Return mDb.ObtenerCuentas_(cCodcli, cliq)
    End Function
    Public Function ObtieneCuentadeAhorrodeCertificado(ByVal cCodcrt As String) As String
        Return mDb.ObtieneCuentadeAhorrodeCertificado(cCodcrt)
    End Function
    Public Function ObtieneMontodeAhorrodeCertificado(ByVal cCodcrt As String) As Double
        Return mDb.ObtieneMontodeAhorrodeCertificado(cCodcrt)
    End Function
    Public Function ObtieneClientedeAhorrodeCertificado(ByVal cCodcrt As String) As String
        Return mDb.ObtieneClientedeAhorrodeCertificado(cCodcrt)
    End Function

    Public Function ActualizaPignoracion(ByVal cCodcrt As String, ByVal cestado As String) As Integer
        Return mDb.ActualizaPignoracion(cCodcrt, cestado)
    End Function
    Public Function ObtieneDepositosxcuenta(ByVal ccodcli As String, ByVal dfecha As Date) As Decimal
        Return mDb.ObtieneDepositosxcuenta(ccodcli, dfecha)
    End Function

    Public Function CargaBeneficiarios() As DataSet
        Return mDb.CargaBeneficiarios()
    End Function

    Public Function Carga_Desconectado_Proyeccion_cupones() As DataSet
        Return mDb.Carga_Desconectado_Proyeccion_cupones()
    End Function

    Public Function Mantenimiento_Deposito_Plazo(ByVal Detalle_Cta As ArrayList, ByVal dt_ben As DataTable, _
                                             ByVal dt_plan As DataTable) As Integer
        Return mDb.Mantenimiento_Deposito_Plazo(Detalle_Cta, dt_ben, dt_plan)
    End Function

    Public Function Elimina_Deposito_Plazo(ByVal Detalle_Cta As ArrayList) As Integer
        Return mDb.Elimina_Deposito_Plazo(Detalle_Cta)
    End Function

    Public Function Extrae_Listado_Depositos(ByVal pcnumcom As String, _
                                             ByVal Tipo As Integer, ByVal pdfecini As Date, _
                                             ByVal pdfecfin As Date, ByVal pnValor As Double, _
                                             ByVal pcCodofi As String) As DataSet
        Return mDb.Extrae_Listado_Depositos(pcnumcom, Tipo, pdfecini, pdfecfin, pnValor, pcCodofi)
    End Function

    Public Function Extrae_Datos_Depositos(ByVal pcCodcrt As String) As DataSet
        Return mDb.Extrae_Datos_Depositos(pcCodcrt)
    End Function

    Public Function Actualiza_Certificado_Diario(ByVal Encabeza_Part() As String) As String
        Return mDb.Actualiza_Certificado_Diario(Encabeza_Part)
    End Function

    Public Function Extraer_Datos_Declaracion(ByVal pcCodcrt As String) As DataSet
        Return mDb.Extraer_Datos_Declaracion(pcCodcrt)
    End Function

    Public Function Pago_Cupones_Depositos(ByVal Encabeza_Part() As String, ByVal ctipo As String) As String
        Return mDb.Pago_Cupones_Depositos(Encabeza_Part, ctipo)
    End Function

    Public Function Extraer_Depositos_Caja(ByVal pcCodCaja As String, ByVal pdfecsis As Date, _
                                           ByVal pctipo As String) As DataSet
        Return mDb.Extraer_Depositos_Caja(pcCodCaja, pdfecsis, pctipo)
    End Function

    Public Function Actualizar_Depositos_Caja(ByVal pcCodCaja As String, ByVal pdfecsis As Date, _
                                                ByVal pctipo As String, ByVal pnId As Integer) As Integer
        Return mDb.Actualizar_Depositos_Caja(pcCodCaja, pdfecsis, pctipo, pnId)
    End Function

    Public Function Pago_Depositos(ByVal Encabeza_Part() As String, ByVal ctipo As String) As String
        Return mDb.Pago_Depositos(Encabeza_Part, ctipo)
    End Function

    Public Function Verifica_Duplicidad_Certificado(ByVal pcCodCrt As String) As Boolean
        Return mDb.Verifica_Duplicidad_Certificado(pcCodCrt)
    End Function

    Public Function Extraer_Datos_Depositos(ByVal pcCodcrt As String) As DataSet
        Return mDb.Extrae_Datos_Depositos(pcCodcrt)
    End Function

    Public Function Extraer_Datos_Depositos_Reimpresion(ByVal pcCodcrt As String, ByVal pdfecha As Date) As DataSet
        Return mDb.Extraer_Datos_Depositos_Reimpresion(pcCodcrt, pdfecha)
    End Function
End Class
