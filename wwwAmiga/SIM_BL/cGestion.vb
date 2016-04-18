Public Class cGestion
 
#Region " Privadas "
    Private mDb as New dbGestion()
    Private mEntidad as Gestion
#End Region
 
    'Public Function ObtenerLista() As listaGestion
    '    Return mDb.ObtenerListaPorID()
    'End Function
 
    Public Function ObtenerGestion(ByRef mEntidad As Gestion) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarGestion(ByVal dfecges As DateTime) As Integer
        Dim mEntidad As New Gestion
        mEntidad.dfecges = dfecges
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarGestion(ByVal aEntidad As Gestion) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function Obtenergestion(ByVal cCodcta As String) As DataSet
        Return mDb.Obtenergestion(cCodcta)
    End Function
    Public Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Agregar(aEntidad)
    End Function
    Public Function ObtenerCodigoGestion(ByVal ccodcta As String) As String
        Return mDb.ObtenerCodigoGestion(ccodcta)
    End Function
    Public Function ObtenerGestiones() As DataSet
        Return mDb.ObtenerGestiones()
    End Function
    Public Function ActualizacCodigoGestion(ByVal idgestion As String, ByVal id As Integer) As Integer
        Return mDb.ActualizacCodigoGestion(idgestion, id)
    End Function
    Public Function ActualizaEstadoGestion(ByVal idgestion As String, ByVal ccodcta As String) As Integer
        Return mDb.ActualizaEstadoGestion(idgestion, ccodcta)
    End Function
    Public Function Moranogestionada(ByVal ccodana As String, ByVal ndiadesde As Integer, ByVal ndiahasta As Integer) As DataSet
        Return mDb.Moranogestionada(ccodana, ndiadesde, ndiahasta)
    End Function
    Public Function VerificaGestion(ByVal ccodcta As String, ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Return mDb.VerificaGestion(ccodcta, dfec1, dfec2)
    End Function
    Public Function Gestiones(ByVal ccodusu As String, ByVal dfec1 As Date, ByVal dfec2 As Date, ByVal cflag As String) As DataSet
        Return mDb.Gestiones(ccodusu, dfec1, dfec2, cflag)
    End Function
    Public Function ObtieneGestiones(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodins As String, _
                                     ByVal ccodofi As String, ByVal ccodana As String) As DataSet
        Return mDb.ObtieneGestiones(dfecha1, dfecha2, ccodins, ccodofi, ccodana)
    End Function
    Public Function ObtieneConveniosPagados(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodins As String, _
                                            ByVal ccodofi As String, ByVal ccodana As String) As DataSet
        Return mDb.ObtieneConveniosPagados(dfecha1, dfecha2, ccodins, ccodofi, ccodana)
    End Function
End Class
