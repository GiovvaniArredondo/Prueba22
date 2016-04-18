Public Class cAhomcta
 
#Region " Privadas "
    Private mDb as New dbAhomcta()
    Private mEntidad as Ahomcta
#End Region
 
    Public Function ObtenerLista() As listaAhomcta
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerAhomcta(ByRef mEntidad As Ahomcta) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function


    Public Function agregar(ByRef mEntidad As ahomcta) As Integer
        Return mDb.Agregar(mEntidad)
    End Function

    Public Function EliminarAhomcta(ByVal ccodaho As String) As Integer
        Dim mEntidad As New ahomcta
        mEntidad.ccodaho = ccodaho
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAhomcta(ByVal aEntidad As ahomcta) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function


    Public Function busquedactaahorro(ByVal cnombre As String, ByVal lctipbus As Boolean) As DataSet
        Return mDb.busquedactaahorro(cnombre, lctipbus)
    End Function

    'busqueda de dataset
    Public Function Obtenerdatasetporcuenta(ByVal ccodaho As String) As DataSet
        Return mDb.Obtenerdatasetporcuenta(ccodaho)
    End Function

    'busqueda de cuenta de ahorro por cliente y por tipo
    Public Function cuentaahorrotipo(ByVal ccodcli1 As String, ByVal ctipo As String) As String
        Return mDb.cuentaahorrotipo(ccodcli1, ctipo)
    End Function


    Public Function Obtenerdatasetporcliente(ByVal ccodcli As String) As DataSet
        Return mDb.Obtenerdatasetporcliente(ccodcli)
    End Function


    Public Function ObtenerListaahoporcliente(ByVal ccodcli As String) As listaahomcta
        Return mDb.ObtenerListaahoporcliente(ccodcli)
    End Function


    Public Function ObtenerID_tipo(ByVal tipo As String, ByVal lccodofi As String) As String
        Return mDb.ObtenerID_tipo(tipo, lccodofi)
    End Function
    Public Function ObtieneBeneficiarios(ByVal cCodcli As String) As DataSet
        Return mDb.ObtieneBeneficiarios(cCodcli)
    End Function
    Public Function ObtieneCuentaAhorro(ByVal ccodaho As String) As DataSet
        Return mDb.ObtieneCuentaAhorro(ccodaho)
    End Function
    Public Function Aportaciones(ByVal ccodcli As String) As Decimal
        Return mDb.Aportaciones(ccodcli)
    End Function
    Public Function AportacionesRestringidas(ByVal ccodcli As String) As Decimal
        Return mDb.AportacionesRestringidas(ccodcli)
    End Function
    Public Function ObtenerDataAportacion() As DataSet
        Return mDb.ObtenerDataAportacion()
    End Function
    Public Function ObtieneFechaIngreso(ByVal cCodcli As String, ByVal ctipo As String) As Date
        Return mDb.ObtieneFechaIngreso(cCodcli, ctipo)
    End Function
    Public Function condonacionAportaciones(ByVal ccodcli As String) As Decimal
        Return mDb.condonacionAportaciones(ccodcli)
    End Function
    Public Function ObtenerCuentasAhorro(ByVal ccodcli As String, ByVal ctipo As String) As DataSet
        Return mDb.ObtenerCuentasAhorro(ccodcli, ctipo)
    End Function
    Public Function VerificaExistenciadeCuentas(ByVal ccodcli As String, ByVal ctipo As String, ByVal cestado As String) As Boolean
        Return mDb.VerificaExistenciadeCuentas(ccodcli, ctipo, cestado)
    End Function
    Public Function ObtieneCodigodeCuentas(ByVal ccodcli As String, ByVal ctipo As String, ByVal cestado As String, ByVal ccodaho As String) As String
        Return mDb.ObtieneCodigodeCuentas(ccodcli, ctipo, cestado, ccodaho)
    End Function
    Public Function ObtieneSaldodeCuenta(ByVal ccodaho As String) As Double
        Return mDb.ObtieneSaldodeCuenta(ccodaho)
    End Function
    Public Function ActualizaSaldodeCuenta(ByVal ccodaho As String, ByVal nsaldo As Double, ByVal nnum As Integer) As Integer
        Return mDb.ActualizaSaldodeCuenta(ccodaho, nsaldo, nnum)
    End Function
    Public Function ActualizarenDesembolso(ByVal aEntidad As entidadBase) As Integer
        Return mDb.ActualizarenDesembolso(aEntidad)
    End Function
    Public Function ObtenerCuentas(ByVal cCodcli As String, ByVal ctipo As String, ByVal cahorro As String) As DataSet
        Return mDb.ObtenerCuentas(cCodcli, ctipo, cahorro)
    End Function
    Public Function ObtenerCuentas2(ByVal cCodcli As String, ByVal ctipo As String, ByVal cahorro As String) As DataSet
        Return mDb.ObtenerCuentas2(cCodcli, ctipo, cahorro)
    End Function
    Public Function ObtieneMontodeAhorro(ByVal cCodaho As String) As Double
        Return mDb.ObtieneMontodeAhorro(cCodaho)
    End Function

    Public Function ActualizaBloqueoCuenta(ByVal cCodaho As String, ByVal cbloqueo As String) As Integer
        Return mDb.ActualizaBloqueoCuenta(cCodaho, cbloqueo)
    End Function
    Public Function ObtieneBeneficiarios2(ByVal cCodaho As String) As DataSet
        Return mDb.ObtieneBeneficiarios2(cCodaho)
    End Function
    Public Function ObtieneSaldo(ByVal ccodcli As String, ByVal ctipo As String) As Decimal
        Return mDb.ObtieneSaldo(ccodcli, ctipo)
    End Function
    Public Function Haberes(ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodana As String) As DataSet
        Return mDb.Haberes(ndesde, nhasta, ccodana)
    End Function
    Public Function Haberes_Individual(ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodcta As String) As DataSet
        Return mDb.Haberes(ndesde, nhasta, ccodcta)
    End Function
    Public Function Haberesxcliente(ByVal ccodcli As String) As Decimal
        Return mDb.Haberesxcliente(ccodcli)
    End Function
    Public Function ObtieneCuentasxCliente(ByVal ccodcli As String) As DataSet
        Return mDb.ObtieneCuentasxCliente(ccodcli)
    End Function

    Public Function Extraer_Sumario_Ahorros() As DataSet
        Return mDb.Extraer_Sumario_Ahorros()
    End Function

    Public Function Mantenimiento_Cta_Ahorro(ByVal Detalle_Cta As ArrayList, ByVal dt_ben As DataTable, _
                                          ByVal dt_firm As DataTable) As Integer
        Return mDb.Mantenimiento_Cta_Ahorro(Detalle_Cta, dt_ben, dt_firm)
    End Function

    Public Function Extraer_Datos_Ctas_Aho(ByVal pntipo As Integer, ByVal pcdescri As String) As DataSet
        Return mDb.Extraer_Datos_Ctas_Aho(pntipo, pcdescri)
    End Function

    Public Function Extraer_Datos_Ctas_Detalle(ByVal pcCodaho As String) As DataSet
        Return mDb.Extraer_Datos_Ctas_Detalle(pcCodaho)
    End Function

    Public Function Extraer_Datos_cta_ahorros_contratos(ByVal ccodaho As String) As DataSet
        Return mDb.Extraer_Datos_cta_ahorros_contratos(ccodaho)
    End Function

    Public Function Tranferencias(ByVal Encabeza_Part() As String) As String
        Return mDb.Tranferencias(Encabeza_Part)
    End Function

    Public Function Extraer_ctas_Ahorro_Socio(ByVal cnudotr As String) As DataSet
        Return mDb.Extraer_ctas_Ahorro_Socio(cnudotr)
    End Function

    Public Function Extraer_Detalle_Cupones(ByVal cCodcrt As String) As DataSet
        Return mDb.Extraer_Detalle_Cupones(cCodcrt)
    End Function

    Public Function Extraer_Detalle_Intereses(ByVal cCodcrt As String) As Double
        Return mDb.Extraer_Detalle_Intereses(cCodcrt)
    End Function

    Public Function Extraer_Saldo_Cta_Ahorro(ByVal pcCodctaAho As String) As Double
        Return mDb.Extraer_Saldo_Cta_Ahorro(pcCodctaAho)
    End Function

    Public Function Extraer_Detalle_Intereses_Pend(ByVal cCodcrt As String, ByVal pdfecsis As Date) As Double
        Return mDb.Extraer_Detalle_Intereses_Pend(cCodcrt, pdfecsis)
    End Function

    Public Function Extraer_Movi_Dep_Cta_Ahorro_Desembolso(ByVal pcCodctaAho As String, _
                                                           ByVal pdfecsis As Date) As Double
        Return mDb.Extraer_Movi_Dep_Cta_Ahorro_Desembolso(pcCodctaAho, pdfecsis)
    End Function

    Public Function Bloqueo_cta_liquidacion(ByVal pcCodcli As String, ByVal pcCodusu As String) As Integer
        Return mDb.Bloqueo_cta_liquidacion(pcCodcli, pcCodusu)
    End Function

    Public Function BusquedaCtaAhorroPL(ByVal cnudoci As String) As DataSet
        Return mDb.BusquedaCtaAhorroPL(cnudoci)
    End Function

    Public Function BusquedaCtaAportacionPL(ByVal cnudoci As String) As String
        Return mDb.BusquedaCtaAportacionPL(cnudoci)
    End Function

    Public Function BusquedaCtaAhorro_porDUi(ByVal cnudoci As String) As DataSet
        Return mDb.BusquedaCtaAhorro_porDUi(cnudoci)
    End Function

    Public Function Extraer_ctas_Ahorro_Socio_(ByVal cnudotr As String) As DataSet
        Return mDb.Extraer_ctas_Ahorro_Socio_(cnudotr)
    End Function

    Public Function Valida_Cta_Aporta_Bloqueda(ByVal pcCodcli As String) As Boolean
        Return mDb.Valida_Cta_Aporta_Bloqueda(pcCodcli)
    End Function

    Public Function Genera_Saldo_Ahorro_Dinamico(ByVal pcTipaho As String, ByVal pdfecha As Date, _
                                                ByVal titulo As String, ByVal pcOficina As String) As DataSet
        Return mDb.Genera_Saldo_Ahorro_Dinamico(pcTipaho, pdfecha, titulo, pcOficina)
    End Function

    Public Function Genera_Saldo_Ahorro_Comparativo(ByVal pcTipaho As String, ByVal pdfechaini As Date, ByVal pdfechafin As Date, _
                                                    ByVal titulo As String, ByVal pcOficina As String) As DataSet
        Return mDb.Genera_Saldo_Ahorro_Dinamico_Comparativo(pcTipaho, pdfechaini, pdfechafin, titulo, pcOficina)
    End Function

    Public Function Extraer_ctas_Ahorro_Socio_Saldo(ByVal cnudotr As String) As ArrayList
        Return mDb.Extraer_ctas_Ahorro_Socio_Saldo(cnudotr)
    End Function

    Public Function Extraer_ctas_Ahorro_Socio_Saldo_Producto(ByVal cnudotr As String, ByVal Producto As String) As Double
        Return mDb.Extraer_ctas_Ahorro_Socio_Saldo_Producto(cnudotr, Producto)
    End Function
End Class
