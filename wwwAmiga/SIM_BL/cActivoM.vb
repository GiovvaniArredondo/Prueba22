Public Class cActivoM

#Region " Privadas "
    Private mDb As New dbActivoM()
    Private mEntidad As ActivoM
#End Region

    Public Function ObtenerActivoM(ByRef mEntidad As ActivoM) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function

    Public Function EliminarActivoM(ByVal ccodinv As String) As Integer

    End Function

    Public Function ActualizarActivoM(ByVal aEntidad As ActivoM) As Integer

    End Function
    Public Function Actualizar(ByVal aEntidad As ActivoM) As Integer
        Return (mDb.Actualizar(aEntidad))
    End Function

    Public Function Agregar(ByVal aEntidad As ActivoM) As Integer
        Return mDb.Agregar(aEntidad)
    End Function

    Public Function DatasetActivoM() As DataSet
        Return mDb.DatasetActivoM()
    End Function

    Public Function Trasladar(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String, ByVal dfectra As DateTime, ByVal cestado As String)
        Return mDb.Trasladar(ccodinv, ccodusu, ccodofi, dfectra, cestado)
    End Function

    Public Function DescargarActivo(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String, ByVal dfectra As DateTime, ByVal cestado As String)
        Return mDb.DescargarActivo(ccodinv, ccodusu, ccodofi, dfectra, cestado)
    End Function

    Public Function ActualizaActivoDescargado(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String)
        Return mDb.ActualizaActivoDescargado(ccodinv, ccodusu, ccodofi)
    End Function

    Public Function ConsultaActivoDescargado(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String, ByVal dfectra As DateTime, ByVal cestado As String, ByVal nserie As Integer) As DataSet
        Return mDb.ConsultaActivoDescargado(ccodinv, ccodusu, ccodofi, dfectra, cestado, nserie)
    End Function

    Public Function BuscaActivosEmpleado(ByVal ccodusu As String) As DataSet
        Return mDb.BuscaActivosEmpleado(ccodusu)
    End Function
End Class

