Public Class cEmpleados
 
#Region " Privadas "
    Private mDb as New dbEmpleados()
    Private mEntidad as Empleados
#End Region
 
    Public Function ObtenerLista() As listaEmpleados
        Return mDb.ObtenerListaPorID()
    End Function
 
    Public Function ObtenerEmpleados(ByRef mEntidad As Empleados) As Integer
        Return mDb.Recuperar(mEntidad)
    End Function
 
    Public Function EliminarEmpleados(ByVal id As String) As Integer
        Dim mEntidad As New Empleados
        mEntidad.id = id
        Return mDb.Eliminar(mEntidad)
    End Function
 
    Public Function ActualizarEmpleados(ByVal aEntidad As Empleados) As Integer
        Return mDb.Actualizar(aEntidad)
    End Function
    Public Function ObtenerDataSetPorID() As DataSet
        Return mDb.ObtenerDataSetPorID()
    End Function

    Public Function ObtenerDataSetPorID1(ByVal ccodigo As String) As DataSet
        Return mDb.ObtenerDataSetPorID1(ccodigo)
    End Function

    Public Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return mDb.Actualizar1(aEntidad)
    End Function

    Public Function VerificaHistorico(ByVal ccodigo As String) As Integer
        Return mDb.VerificaHistorico(ccodigo)
    End Function

    Public Function CreaTablaHistorica(ByVal ccodigo) As Integer
        Return mDb.CreaTablaHistorica(ccodigo)
    End Function
    Public Function InsertaTablaHistorica(ByVal ccodigo As String, ByVal id As String, ByVal ncomision As Double, _
   ByVal nsueldo As Double, ByVal nisss As Double, ByVal nafp As Double, ByVal nisr As Double, _
   ByVal nissspat As Double, ByVal nafppat As Double, ByVal ntotal As Double, ByVal verifica As Integer, ByVal notros As Double, ByVal ncelular As Double, ByVal nboni As Double) As Integer
        Return mDb.InsertaTablaHistorica(ccodigo, id, ncomision, nsueldo, nisss, nafp, nisr, nissspat, nafppat, ntotal, verifica, notros, ncelular, nboni)
    End Function
    Public Function Planilla(ByVal ccodigo As String) As DataSet
        Return mDb.Planilla(ccodigo)
    End Function
    Public Function Ctrl_Planilla(ByVal dfeccnt As Date, ByVal ccodusu As String, ByVal dfecsis As Date, ByVal cestado As String) As Integer
        Return mDb.Ctrl_Planilla(dfeccnt, ccodusu, dfecsis, cestado)
    End Function
    Public Function Ver_Planilla(ByVal dfeccnt As Date) As Integer
        Return mDb.Ver_Planilla(dfeccnt)
    End Function
End Class
