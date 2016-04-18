Public Class cCtbdchq
 
#Region " Privadas "
    Private mDb as New dbCtbdchq()
    Private mEntidad as Ctbdchq
#End Region
 
    Public Function ObtenerLista() As listaCtbdchq
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerCtbdchq(ByRef mEntidad As Ctbdchq) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarCtbdchq(ByVal cnumcom As String) As Integer
        Dim mEntidad As New Ctbdchq
        mEntidad.cnumcom = cnumcom
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarCtbdchq(ByVal aEntidad As Ctbdchq) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ActualizarCtbdchqRever(ByVal aEntidad As ctbdchq) As Integer
        Return mDb.ActualizarCtbdchq(aEntidad)
    End Function

    Public Function Agregar(ByVal aEntidad As ctbdchq) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function ObtenerDataSetEsp1(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet
        Return mDb.ObtenerDataSetEsp1(date1, date2)
    End Function
    Public Function ObtenerDataSetEsp3(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet
        Return mDb.ObtenerDataSetEsp3(date1, date2)
    End Function
    'obtiene detalle de cartera mlvg
    Public Function ObtenerDataSetcarteracreditos(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet
        Return mDb.ObtenerDataSetcarteracreditos(date1, date2)
    End Function

    'cartera en mora mlvg
    Public Function ObtenerDataSetcarteramora(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet
        Return mDb.ObtenerDataSetcarteramora(date1, date2)
    End Function

    Public Function ObtenerDataSetEsp2(ByVal cCodigo) As DataSet
        Return mDb.ObtenerDataSetEsp2(cCodigo)
    End Function
    Public Function ObtenerDataSetEsp4(ByVal date1 As DateTime, ByVal date2 As DateTime) As DataSet
        Return mDb.ObtenerDataSetEsp4(date1, date2)
    End Function
    Public Function ObtenerDataSetEsp5(ByVal cCodigo, ByVal cNuming) As DataSet
        Return mDb.ObtenerDataSetEsp5(cCodigo, cNuming)
    End Function
    Public Function Nchequexcnumcom(ByVal cNumcom As String, ByVal lccadena As String) As String
        Return mDb.Nchequexcnumcom(cNumcom, lccadena)
    End Function
    Public Function AgregarAuxiliar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.AgregarAuxiliar(aEntidad)
    End Function
    Public Function AnulaAuxiliar(ByVal cnumcom As String) As Integer
        Return mDb.AnulaAuxiliar(cnumcom)
    End Function
    Public Function NombreChequexcnumcom(ByVal pcNumcom As String, ByVal lccadena As String) As String
        Return mDb.NombreChequexcnumcom(pcNumcom, lccadena)
    End Function
    Public Function ClientePorCodigo(ByVal CodigoCliente As String) As String
        Return mDb.ClientePorCodigo(CodigoCliente)
    End Function
    Public Function AnulaCheque(ByVal cnumcom As String) As Integer
        Return mDb.AnulaCheque(cnumcom)
    End Function
    Public Function VerificasiprocedeAnulacion(ByVal cnumcom As String) As Boolean
        Return mDb.VerificasiprocedeAnulacion(cnumcom)
    End Function
    Public Function VerificarChequeExiste(ByVal ccodbco As String, ByVal cnrochq As String) As Boolean
        Return mDb.VerificarChequeExiste(ccodbco, cnrochq)
    End Function
End Class
