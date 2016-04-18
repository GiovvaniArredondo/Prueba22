Imports System.Text
Imports System.Data.SqlClient

Public Class cAhommov

#Region " Privadas "
    Private mDb As New dbAhommov()
    Private mEntidad As ahommov
#End Region

    Public Function ObtenerLista(ByVal ccodaho As String) As listaahommov
        Return mDb.ObtenerListaPorID(ccodaho)
    End Function

    Public Function ObtenerAhommov(ByRef mEntidad As ahommov) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarAhommov(ByVal ccodaho As String) As Integer
        Dim mEntidad As New ahommov
        mEntidad.ccodaho = ccodaho
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarAhommov(ByVal aEntidad As ahommov) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function

    Public Function agregar(ByVal aEntidad As ahommov) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    'funcion que obtiene ultimo saldo de la tabla de movimientos de ahorros

    Public Function obtiene_saldo_anterior_a_fecha_inicio(ByVal ccodaho, ByVal dfecha) As Double
        Return mDb.obtiene_saldo_anterior_a_fecha_inicio(ccodaho, dfecha)
    End Function

    Public Function movimientos_por_cuent_fecha(ByVal ccodaho As String, ByVal dfecha1 As Date, ByVal dfecha2 As Date) As listaahommov
        Return mDb.movimientos_por_cuent_fecha(ccodaho, dfecha1, dfecha2)
    End Function

    'fecha de ultimo movimiento, cuando esta es despued de la fecha en que inicia la provision
    Public Function obtiene_fecha_ultimo_movimiento(ByVal ccodaho As String, ByVal dfecha1 As Date) As Date
        Return mDb.obtiene_fecha_ultimo_movimiento(ccodaho, dfecha1)
    End Function
    Public Function ObtieneCorrelativo(ByVal cCodaho As String) As Integer
        Return mDb.ObtieneCorrelativo(cCodaho)
    End Function

    Public Function ObtenerMovimientoAhorro(ByVal ccodaho As String, ByVal cconcep As String, ByVal dfecope As Date, ByVal cnumdoc As String) As DataTable
        Return mDb.ObtenerMovimientoAhorro(ccodaho, cconcep, dfecope, cnumdoc)
    End Function
    Public Function ObtenerBusquedadeMonto(ByVal dfecha As Date, ByVal ccodusu As String, ByVal nmonto As Decimal) As DataTable
        Return mDb.ObtenerBusquedadeMonto(dfecha, ccodusu, nmonto)
    End Function
    Public Function ObtieneDepositosxcuenta(ByVal ccodaho As String, ByVal dfecha As Date) As Decimal
        Return mDb.ObtieneDepositosxcuenta(ccodaho, dfecha)
    End Function

    Public Function ObtieneLinea(ByVal cCodaho As String) As Integer
        Return mDb.ObtieneLinea(cCodaho)
    End Function

    Public Function ObtienePagina(ByVal cCodaho As String, ByVal nnum As Integer) As Integer
        Return mDb.ObtienePagina(cCodaho, nnum)
    End Function

    Public Function ObtienePaginaUltima(ByVal cCodaho As String, ByVal nnum As Integer) As Integer
        Return mDb.ObtienePaginaUltima(cCodaho, nnum)
    End Function

    Public Function ObtieneCorrelativo_(ByVal cCodaho As String, ByVal con As SqlConnection) As Integer
        Return mDb.ObtieneCorrelativo_(cCodaho, con)
    End Function

    Public Function ObtieneLinea_(ByVal cCodaho As String, ByVal con As SqlConnection) As Integer
        Return mDb.ObtieneLinea_(cCodaho, con)
    End Function
End Class
