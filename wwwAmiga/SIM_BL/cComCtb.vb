Public Class cComCtb
#Region " Privadas "
    Private mDb As New dbConCtb
    Private mEntidad As ComCtb
#End Region

    Public Function ObtenerConsulta1(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal nOpcion As Integer, ByVal cBuscar As String) As DataSet
        Return mDb.ObtenerConsulta1(dfecini, dfecfin, nOpcion, cBuscar)
    End Function
    Public Function ObtenerConsulta2(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal nOpcion As Integer, ByVal cBuscar As String) As DataSet
        Return mDb.ObtenerConsulta2(dfecini, dfecfin, nOpcion, cBuscar)
    End Function
    Public Function ObtenerConsulta3(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal nOpcion As Integer, ByVal cBuscar As String) As DataSet
        Return mDb.ObtenerConsulta3(dfecini, dfecfin, nOpcion, cBuscar)
    End Function
    Public Function Total_Por_Partida(ByVal cNumcom As String) As DataSet
        Return mDb.Total_Por_Partida(cNumcom)
    End Function
    Public Function ObtenerDataSetPorID(ByVal dFecIni As Date, ByVal dFecFin As Date) As DataSet
        Return mDb.ObtenerDataSetPorID(dFecIni, dFecFin)
    End Function
End Class
