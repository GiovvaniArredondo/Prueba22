
Imports System.EnterpriseServices
<Transaction(TransactionOption.RequiresNew)> _
Public Class cDiario

#Region " Privadas "
    Private mDb As New dbDiario
    Private mEntidad As diario
#End Region

    Public Function ObtenerLista() As listadiario
        Return mDb.ObtenerListaPorID()
    End Function

    Public Function ObtenerDiario(ByRef mEntidad As diario) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarDiario(ByVal cnumcom As String) As Integer
        Dim mEntidad As New diario
        mEntidad.cnumcom = cnumcom
        Return mDb.Eliminar(mEntidad)
    End Function

    Public Function ActualizarDiario(ByVal aEntidad As diario) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    <AutoComplete()> _
      Public Function agregarDiario(ByVal aEntidad As diario) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function siexistepartida(ByVal cnumcom1 As String) As Boolean
        Return mDb.siexistepartida(cnumcom1)
    End Function
    Public Function ObtieneNumerodePartidas(ByVal cglosa As String, ByVal dfecha As Date) As DataSet
        Return mDb.ObtieneNumerodePartidas(cglosa, dfecha)
    End Function
    Public Function VerificasiprocedeAnulacion(ByVal cnumcom As String) As Boolean
        Return mDb.VerificasiprocedeAnulacion(cnumcom)
    End Function
    Public Function BanderaAnulada(ByVal cnumcom As String) As Boolean
        Return mDb.BanderaAnulada(cnumcom)
    End Function
    Public Function BanderaAnulada2(ByVal cnumcom As String) As Boolean
        Return mDb.BanderaAnulada2(cnumcom)
    End Function

    Public Function ActualizaPartidaRevertida(ByVal cnumcom As String, ByVal cnumcom2 As String) As Boolean
        Return mDb.ActualizaPartidaRevertida(cnumcom, cnumcom2)
    End Function
    Public Function ObtenerCabezaPartida(ByVal cnumcom As String) As DataSet
        Return mDb.ObtenerCabezaPartida(cnumcom)
    End Function

End Class
