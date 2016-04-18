Imports System.Text
Public Class dbConCtb
    Inherits dbBase
    Private Sub SelectTabla(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT CNTAMOV.dFecCnt, ")
        strSQL.Append("DIARIO.cCodOfi,")
        strSQL.Append("DIARIO.cTipAsi,")
        strSQL.Append("DIARIO.cTipMon,")
        strSQL.Append("DIARIO.cNumCom,")
        strSQL.Append("CNTAMOV.cCodCta,")
        strSQL.Append("CNTAMOV.nDebe,")
        strSQL.Append("CNTAMOV.nHaber,")
        strSQL.Append("CTBMCTA.cDescrip,")
        strSQL.Append("CTBMCTA.nSalIni,")
        strSQL.Append("CNTAMOV.cNumDoc,")
        strSQL.Append("DIARIO.cGlosa")
        strSQL.Append(" FROM CTBMCTA , DIARIO , CNTAMOV ")
    End Sub
    Private Sub SelectTabla1(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT CNTAMOV.dFecCnt, ")
        strSQL.Append("DIARIO.cCodOfi,")
        strSQL.Append("DIARIO.cTipAsi,")
        strSQL.Append("DIARIO.cTipMon,")
        strSQL.Append("DIARIO.cNumCom,")
        strSQL.Append("CNTAMOV.cCodCta,")
        strSQL.Append("CNTAMOV.nDebe,")
        strSQL.Append("CNTAMOV.nHaber,")
        strSQL.Append("CTBMCTA.cDescrip,")
        strSQL.Append("CTBMCTA.nSalIni,")
        strSQL.Append("CNTAMOV.cNumDoc,")
        strSQL.Append("DIARIO.cGlosa,")
        strSQL.Append("CTBDCHQ.cNomChq")
        strSQL.Append(" FROM CTBMCTA , DIARIO , CNTAMOV, CTBDCHQ ")
    End Sub
    Private Sub SelectTabla2(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT CNTAMOV.dFecCnt, ")
        strSQL.Append("DIARIO.cCodOfi,")
        strSQL.Append("DIARIO.cTipAsi,")
        strSQL.Append("DIARIO.cTipMon,")
        strSQL.Append("DIARIO.cNumCom,")
        strSQL.Append("CNTAMOV.cCodCta,")
        strSQL.Append("CNTAMOV.nDebe,")
        strSQL.Append("CNTAMOV.nHaber,")
        strSQL.Append("CTBMCTA.cDescrip,")
        strSQL.Append("CTBMCTA.nSalIni,")
        strSQL.Append("CNTAMOV.cNumDoc,")
        strSQL.Append("DIARIO.cGlosa,")
        strSQL.Append("CTBDCLI.cNomCli")
        strSQL.Append(" FROM CTBMCTA , DIARIO , CNTAMOV, CTBDCLI ")
    End Sub
    Private Sub SelectTabla3(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT cnumcom, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ctipasi, ")
        strSQL.Append(" ctipmon, ")
        strSQL.Append(" cglosa, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" ccodruc, ")
        strSQL.Append(" ccodemp, ")
        strSQL.Append(" dfecdoc, ")
        strSQL.Append(" dfeccnt, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" cnrodoc, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" 00000000.00 as nDebe, ")
        strSQL.Append(" 00000000.00 as nHaber ")
        strSQL.Append(" FROM diario ")
    End Sub

    Public Overrides Function Actualizar(ByVal aEntidad As EL.entidadBase) As Integer
    End Function

    Public Overrides Function Agregar(ByVal aEntidad As EL.entidadBase) As Integer
    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As EL.entidadBase) As Integer
    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As EL.entidadBase) As Long
    End Function
    Public Overrides Function Recuperar(ByVal aEntidad As EL.entidadBase) As Integer
    End Function

    Public Function ObtenerConsulta1(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal nOpcion As Integer, ByVal cBuscar As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE Diario.cEstado <>" & "'" & "X" & "'")
        strSQL.Append(" and Diario.dFecCnt>= @dfecini and Diario.dFecCnt <= @dFecFin ")
        strSQL.Append(" and Diario.cNumCom = CntaMov.cNumCom ")
        strSQL.Append(" and CntaMov.cCodCta = ctbmcta.cCodCta ")
        strSQL.Append(" and CntaMov.cflc = " & "'" & " " & "'")
        If nOpcion = 1 Then
            strSQL.Append(" and CntaMov.cCodcta = @cBuscar")
        ElseIf nOpcion = 2 Then
            strSQL.Append(" and Ctbmcta.cDescrip = @cBuscar")
        ElseIf nOpcion = 3 Then
            strSQL.Append(" and Cntamov.cNumcom = @cBuscar")
        ElseIf nOpcion = 4 Then
            strSQL.Append(" and (Cntamov.ndebe = @cBuscar")
            strSQL.Append(" or Cntamov.nHaber = @cBuscar)")
        Else
            strSQL.Append(" and Cntamov.dfecCnt = @cBuscar")
        End If
        strSQL.Append(" ORDER BY Cntamov.cCodCta, Diario.dFecCnt, Diario.cNumCom ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dFecIni", dfecini)
        args(1) = New SqlParameter("@dFecFin", dfecfin)
        args(2) = New SqlParameter("@nOpcion", nOpcion)
        args(3) = New SqlParameter("@cBuscar", cBuscar)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerConsulta2(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal nOpcion As Integer, ByVal cBuscar As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla1(strSQL)
        strSQL.Append(" WHERE Diario.cEstado <>" & "'" & "X" & "'")
        strSQL.Append(" and Diario.dFecCnt>= @dfecini and Diario.dFecCnt <= @dFecFin ")
        strSQL.Append(" and Diario.cNumCom = CntaMov.cNumCom ")
        strSQL.Append(" and CntaMov.cCodCta = ctbmcta.cCodCta ")
        strSQL.Append(" and Diario.cNumCom = Ctbdchq.cNumcom ")
        strSQL.Append(" and CntaMov.cflc = " & "'" & " " & "'")
        If nOpcion = 1 Then
            strSQL.Append(" and CntaMov.cCodcta = @cBuscar")
        ElseIf nOpcion = 2 Then
            strSQL.Append(" and Ctbmcta.cDescrip = @cBuscar")
        ElseIf nOpcion = 3 Then
            strSQL.Append(" and Cntamov.cNumcom = @cBuscar")
        ElseIf nOpcion = 4 Then
            strSQL.Append(" and (Cntamov.ndebe = @cBuscar")
            strSQL.Append(" or Cntamov.nHaber = @cBuscar)")
        Else
            strSQL.Append(" and Cntamov.dfecCnt = @cBuscar")
        End If
        strSQL.Append(" ORDER BY Cntamov.cCodCta")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dFecIni", dfecini)
        args(1) = New SqlParameter("@dFecFin", dfecfin)
        args(2) = New SqlParameter("@nOpcion", nOpcion)
        args(3) = New SqlParameter("@cBuscar", cBuscar)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerConsulta3(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal nOpcion As Integer, ByVal cBuscar As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla2(strSQL)
        strSQL.Append(" WHERE Diario.cEstado <>" & "'" & "X" & "'")
        strSQL.Append(" and Diario.dFecCnt>= @dfecini and Diario.dFecCnt <= @dFecFin ")
        strSQL.Append(" and Diario.cNumCom = CntaMov.cNumCom ")
        strSQL.Append(" and CntaMov.cCodCta = ctbmcta.cCodCta ")
        strSQL.Append(" and Diario.cNumCom = Ctbdcli.cNumcom ")
        strSQL.Append(" and CntaMov.cflc = " & "'" & " " & "'")
        If nOpcion = 1 Then
            strSQL.Append(" and CntaMov.cCodcta = @cBuscar")
        ElseIf nOpcion = 2 Then
            strSQL.Append(" and Ctbmcta.cDescrip = @cBuscar")
        ElseIf nOpcion = 3 Then
            strSQL.Append(" and Cntamov.cNumcom = @cBuscar")
        ElseIf nOpcion = 4 Then
            strSQL.Append(" and (Cntamov.ndebe = @cBuscar")
            strSQL.Append(" or Cntamov.nHaber = @cBuscar)")
        Else
            strSQL.Append(" and Cntamov.dfecCnt = @cBuscar")
        End If
        strSQL.Append(" ORDER BY Cntamov.cNumCom")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@dFecIni", dfecini)
        args(1) = New SqlParameter("@dFecFin", dfecfin)
        args(2) = New SqlParameter("@nOpcion", nOpcion)
        args(3) = New SqlParameter("@cBuscar", cBuscar)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function Total_Por_Partida(ByVal cNumcom As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select a.cNumcom, SUM(a.nDebe) as nDebe, SUM(a.nHaber) as nHaber ")
        strSQL.Append(" FROM CNTAMOV AS a ")
        strSQL.Append(" WHERE cNumCom = @cNumcom ")
        strSQL.Append(" GROUP BY a.cNumCom")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cNumCom", cNumcom)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function ObtenerDataSetPorID(ByVal dFecIni As Date, ByVal dFecFin As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla3(strSQL)
        strSQL.Append(" WHERE dFecCnt >= @dFecIni and dFecCnt <= @dFecFin ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dFecIni", dFecIni)
        args(1) = New SqlParameter("@dFecFin", dFecFin)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
End Class
