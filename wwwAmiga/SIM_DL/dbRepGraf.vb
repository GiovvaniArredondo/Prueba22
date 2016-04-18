Imports System
Imports System.Text
Public Class dbRepGraf
    Inherits dbBase
    ' Mayo 2006 FERN
    Public Function ObtenerDataSetEstadistico(ByVal pnLimite As Integer, ByVal pnlimite2 As Integer) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select COUNT(cCodCta) As nNumCre, SUM(nCapDes - nCapPag) As nSalCre")
        strSQL.Append(" FROM CREMCRE WHERE cEstado = 'F' and nDiaAtr > @pnLimite and nDiaAtr <= @pnLimite2 GROUP BY cEstado ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@pnLimite", pnLimite)
        args(1) = New SqlParameter("@pnLimite2", pnlimite2)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function

    Public Function ObtenerDataSetPorGenero(ByVal pcGenero As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select COUNT(CLIMIDE.cCodCli) As nNumCli, SUM(CREMCRE.nCapDes - CREMCRE.nCapPag) As nSalCre")
        strSQL.Append(" FROM CREMCRE, CLIMIDE WHERE CREMCRE.cCodCli = CLIMIDE.cCodCli and CREMCRE.cEstado = 'F' ")
        strSQL.Append(" and CLIMIDE.cSexo = @pcGenero")
        strSQL.Append(" GROUP BY CREMCRE.cEstado")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcGenero", pcGenero)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function

    Public Function ObtenerDataSetPorIDTab(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodigo As Codigo, cDesCri As Descripcion, 000000 As nNumCli, 000000 As nNumCre, 000000000.00 As nSalCre FROM TABTTAB")
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetOficina() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodIns As Region, cCodOfi as Codigo, cNomOfi As Oficina, 000000 As nNumCli, 000000 As nNumCre, 000000000.00 As nSalCre ")
        strSQL.Append(" FROM TABTOFI ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds
    End Function
    Public Function ObtenerDataSetPorOficina(ByVal pcCodIns As String, ByVal pcCodOfi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select COUNT(CLIMIDE.cCodCli) As nNumCli, SUM(CREMCRE.nCapDes - CREMCRE.nCapPag) As nSalCre")
        strSQL.Append(" FROM CREMCRE, CLIMIDE WHERE CREMCRE.cCodCli = CLIMIDE.cCodCli and CREMCRE.cEstado = 'F' ")
        strSQL.Append(" and SUBSTRING(CREMCRE.cCodCta,4,3) = @pcCodOFi")
        strSQL.Append(" GROUP BY CREMCRE.cEstado")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcCodOfi", pcCodOfi)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function ObtenerDataSetDestino(ByVal cCodTab As String, ByVal cTipReg As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodigo As Codigo, cDesCri As Descripcion, 000000 As nNumCli, 000000 As nNumCre, 000000000.00 As nSalCre FROM TABTTAB")
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function ObtenerDataSetPorDestino(ByVal pcDestino As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select COUNT(CLIMIDE.cCodCli) As nNumCli, SUM(CREMCRE.nCapDes - CREMCRE.nCapPag) As nSalCre")
        strSQL.Append(" FROM CREMCRE, CLIMIDE WHERE CREMCRE.cCodCli = CLIMIDE.cCodCli and CREMCRE.cEstado = 'F' ")
        strSQL.Append(" and CREMCRE.cDesCre) = @pcDestino")
        strSQL.Append(" GROUP BY CREMCRE.cEstado")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pcDestino", pcDestino)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function

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
End Class
