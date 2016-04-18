Imports System.Text
Public Class dbCancela
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cancela
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodpre = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodpre = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cancela ")
        strSQL.Append(" SET ccodcta = @ccodcta, ")
        strSQL.Append(" cnomcli = @cnomcli, ")
        strSQL.Append(" nsalcap = @nsalcap, ")
        strSQL.Append(" ctabco = @ctabco, ")
        strSQL.Append(" cnumchq = @cnumchq, ")
        strSQL.Append(" ntotal = @ntotal, ")
        strSQL.Append(" ccodcli = @ccodcli, ")
        strSQL.Append(" nsalint = @nsalint, ")
        strSQL.Append(" nsalmor = @nsalmor, ")
        strSQL.Append(" nmanejo = @nmanejo, ")
        strSQL.Append(" nseguro = @nseguro ")
        strSQL.Append(" ccodlin = @ccodlin, ")
        strSQL.Append(" ccodpre = @ccodpre, ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomcli
        args(2) = New SqlParameter("@nsalcap", SqlDbType.VarChar)
        args(2).Value = lEntidad.nsalcap
        args(3) = New SqlParameter("@ctabco", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctabco
        args(4) = New SqlParameter("@cnumchq", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumchq
        args(5) = New SqlParameter("@ntotal", SqlDbType.VarChar)
        args(5).Value = lEntidad.ntotal
        args(6) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodcli
        args(7) = New SqlParameter("@nsalint", SqlDbType.VarChar)
        args(7).Value = lEntidad.nsalint
        args(8) = New SqlParameter("@nsalmor", SqlDbType.VarChar)
        args(8).Value = lEntidad.nsalmor
        args(9) = New SqlParameter("@nmanejo", SqlDbType.VarChar)
        args(9).Value = lEntidad.nmanejo
        args(10) = New SqlParameter("@nseguro", SqlDbType.VarChar)
        args(10).Value = lEntidad.nseguro
        args(11) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodlin
        args(12) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodpre

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cancela
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cancela ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" nsalcap, ") 
        strSQL.Append(" ctabco, ") 
        strSQL.Append(" cnumchq, ") 
        strSQL.Append(" ntotal, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" nsalint, ") 
        strSQL.Append(" nsalmor, ") 
        strSQL.Append(" nmanejo, ") 
        strSQL.Append(" nseguro, ")
        strSQL.Append(" ccodlin, ") 
        strSQL.Append(" ccodpre, niva) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @cnomcli, ") 
        strSQL.Append(" @nsalcap, ") 
        strSQL.Append(" @ctabco, ") 
        strSQL.Append(" @cnumchq, ") 
        strSQL.Append(" @ntotal, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @nsalint, ") 
        strSQL.Append(" @nsalmor, ") 
        strSQL.Append(" @nmanejo, ") 
        strSQL.Append(" @nseguro, ")
        strSQL.Append(" @ccodlin, ") 
        strSQL.Append(" @ccodpre, @niva) ")

        Dim args(13) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomcli
        args(2) = New SqlParameter("@nsalcap", SqlDbType.Decimal)
        args(2).Value = lEntidad.nsalcap
        args(3) = New SqlParameter("@ctabco", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctabco
        args(4) = New SqlParameter("@cnumchq", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumchq
        args(5) = New SqlParameter("@ntotal", SqlDbType.Decimal)
        args(5).Value = lEntidad.ntotal
        args(6) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodcli
        args(7) = New SqlParameter("@nsalint", SqlDbType.Decimal)
        args(7).Value = lEntidad.nsalint
        args(8) = New SqlParameter("@nsalmor", SqlDbType.Decimal)
        args(8).Value = lEntidad.nsalmor
        args(9) = New SqlParameter("@nmanejo", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmanejo
        args(10) = New SqlParameter("@nseguro", SqlDbType.Decimal)
        args(10).Value = lEntidad.nseguro
        args(11) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodlin
        args(12) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodpre
        args(13) = New SqlParameter("@niva", SqlDbType.Decimal)
        args(13).Value = lEntidad.niva


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cancela
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cancela ")
        strSQL.Append(" WHERE cCodpre = @cCodPre and ccodcta = @ccodref")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodpre

        args(1) = New SqlParameter("@ccodref", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodref

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function Eliminartodo(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cancela
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cancela ")
        strSQL.Append(" WHERE cCodpre = @cCodPre ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodpre


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cancela
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE cCodpre = @cCodPre")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodpre

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.nsalcap = IIf(.Item("nsalcap") Is DBNull.Value, Nothing, .Item("nsalcap"))
                lEntidad.ctabco = IIf(.Item("ctabco") Is DBNull.Value, Nothing, .Item("ctabco"))
                lEntidad.cnumchq = IIf(.Item("cnumchq") Is DBNull.Value, Nothing, .Item("cnumchq"))
                lEntidad.ntotal = IIf(.Item("ntotal") Is DBNull.Value, Nothing, .Item("ntotal"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.nsalint = IIf(.Item("nsalint") Is DBNull.Value, Nothing, .Item("nsalint"))
                lEntidad.nsalmor = IIf(.Item("nsalmor") Is DBNull.Value, Nothing, .Item("nsalmor"))
                lEntidad.nmanejo = IIf(.Item("nmanejo") Is DBNull.Value, Nothing, .Item("nmanejo"))
                lEntidad.nseguro = IIf(.Item("nseguro") Is DBNull.Value, Nothing, .Item("nseguro"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.ccodpre = IIf(.Item("ccodpre") Is DBNull.Value, Nothing, .Item("ccodpre"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cancela
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(),0) + 1 ")
        strSQL.Append(" FROM cancela ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacancela

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacancela

        Try
            Do While dr.Read()
                Dim mEntidad As New cancela
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.nsalcap = IIf(dr("nsalcap") Is DBNull.Value, Nothing, dr("nsalcap"))
                mEntidad.ctabco = IIf(dr("ctabco") Is DBNull.Value, Nothing, dr("ctabco"))
                mEntidad.cnumchq = IIf(dr("cnumchq") Is DBNull.Value, Nothing, dr("cnumchq"))
                mEntidad.ntotal = IIf(dr("ntotal") Is DBNull.Value, Nothing, dr("ntotal"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.nsalint = IIf(dr("nsalint") Is DBNull.Value, Nothing, dr("nsalint"))
                mEntidad.nsalmor = IIf(dr("nsalmor") Is DBNull.Value, Nothing, dr("nsalmor"))
                mEntidad.nmanejo = IIf(dr("nmanejo") Is DBNull.Value, Nothing, dr("nmanejo"))
                mEntidad.nseguro = IIf(dr("nseguro") Is DBNull.Value, Nothing, dr("nseguro"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.ccodpre = IIf(dr("ccodpre") Is DBNull.Value, Nothing, dr("ccodpre"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("cancela")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" nsalcap, ")
        strSQL.Append(" ctabco, ")
        strSQL.Append(" cnumchq, ")
        strSQL.Append(" ntotal, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" nsalint, ")
        strSQL.Append(" nsalmor, ")
        strSQL.Append(" nmanejo, ")
        strSQL.Append(" nseguro, ")
        strSQL.Append(" ccodlin, ")
        strSQL.Append(" ccodpre ")
        strSQL.Append(" FROM cancela ")

    End Sub

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodpre = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetPorCuenta(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodcta, nsalcap, nsalint, nsalmor, ")
        strSQL.Append(" nmanejo, nseguro, niva from cancela where ccodpre = @ccodcta order by ccodcta")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
End Class
