Imports System.Text
Public Class dbCLIDFLUJO
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFLUJO
        Dim lID As Long
        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CLIDFLUJO ")
        strSQL.Append(" SET dflujo = @dflujo, ") 
        strSQL.Append(" npromm = @npromm, ")
        strSQL.Append(" nene = @nene, ")
        strSQL.Append(" nfeb = @nfeb, ")
        strSQL.Append(" nmar = @nmar, ")
        strSQL.Append(" nabr = @nabr, ")
        strSQL.Append(" nmay = @nmay, ")
        strSQL.Append(" njun = @njun, ")
        strSQL.Append(" njul = @njul, ")
        strSQL.Append(" nago = @nago, ")
        strSQL.Append(" nsep = @nsep, ")
        strSQL.Append(" noct = @noct ")
        strSQL.Append(" nnov = @nnov, ")
        strSQL.Append(" ndic = @ndic, ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@dflujo", SqlDbType.Datetime)
        args(0).Value = lEntidad.dflujo
        args(1) = New SqlParameter("@npromm", SqlDbType.VarChar)
        args(1).Value = lEntidad.npromm
        args(2) = New SqlParameter("@nene", SqlDbType.Decimal)
        args(2).Value = lEntidad.nene
        args(3) = New SqlParameter("@nfeb", SqlDbType.Decimal)
        args(3).Value = lEntidad.nfeb
        args(4) = New SqlParameter("@nmar", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmar
        args(5) = New SqlParameter("@nabr", SqlDbType.Decimal)
        args(5).Value = lEntidad.nabr
        args(6) = New SqlParameter("@nmay", SqlDbType.Decimal)
        args(6).Value = lEntidad.nmay
        args(7) = New SqlParameter("@njun", SqlDbType.Decimal)
        args(7).Value = lEntidad.njun
        args(8) = New SqlParameter("@njul", SqlDbType.Decimal)
        args(8).Value = lEntidad.njul
        args(9) = New SqlParameter("@nago", SqlDbType.Decimal)
        args(9).Value = lEntidad.nago
        args(10) = New SqlParameter("@nsep", SqlDbType.Decimal)
        args(10).Value = lEntidad.nsep
        args(11) = New SqlParameter("@noct", SqlDbType.Decimal)
        args(11).Value = lEntidad.noct
        args(12) = New SqlParameter("@nnov", SqlDbType.Decimal)
        args(12).Value = lEntidad.nnov
        args(13) = New SqlParameter("@ndic", SqlDbType.Decimal)
        args(13).Value = lEntidad.ndic
        args(14) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(14).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(15) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(15).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value, lEntidad.ccodfue)
        args(16) = New SqlParameter("@devalua", SqlDbType.DateTime)
        args(16).Value = IIf(lEntidad.devalua = Nothing, DBNull.Value, lEntidad.devalua)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFLUJO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO CLIDFLUJO ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodfue, ") 
        strSQL.Append(" devalua, ") 
        strSQL.Append(" dflujo, ") 
        strSQL.Append(" npromm, ")
        strSQL.Append(" nene, ")
        strSQL.Append(" nfeb, ")
        strSQL.Append(" nmar, ")
        strSQL.Append(" nabr, ")
        strSQL.Append(" nmay, ")
        strSQL.Append(" njun, ")
        strSQL.Append(" njul, ")
        strSQL.Append(" nago, ")
        strSQL.Append(" nsep, ")
        strSQL.Append(" noct, ")
        strSQL.Append(" nnov, ")
        strSQL.Append(" ndic) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodfue, ") 
        strSQL.Append(" @devalua, ") 
        strSQL.Append(" @dflujo, ") 
        strSQL.Append(" @npromm, ")
        strSQL.Append(" @nene, ")
        strSQL.Append(" @nfeb, ")
        strSQL.Append(" @nmar, ")
        strSQL.Append(" @nabr, ")
        strSQL.Append(" @nmay, ")
        strSQL.Append(" @njun, ")
        strSQL.Append(" @njul, ")
        strSQL.Append(" @nago, ")
        strSQL.Append(" @nsep, ")
        strSQL.Append(" @noct, ")
        strSQL.Append(" @nnov, ")
        strSQL.Append(" @ndic) ")

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value, lEntidad.ccodfue)
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = IIf(lEntidad.devalua = Nothing, DBNull.Value, lEntidad.devalua)
        args(3) = New SqlParameter("@dflujo", SqlDbType.Datetime)
        args(3).Value = lEntidad.dflujo
        args(4) = New SqlParameter("@npromm", SqlDbType.Decimal)
        args(4).Value = lEntidad.npromm
        args(5) = New SqlParameter("@nene", SqlDbType.Decimal)
        args(5).Value = lEntidad.nene
        args(6) = New SqlParameter("@nfeb", SqlDbType.Decimal)
        args(6).Value = lEntidad.nfeb
        args(7) = New SqlParameter("@nmar", SqlDbType.Decimal)
        args(7).Value = lEntidad.nmar
        args(8) = New SqlParameter("@nabr", SqlDbType.Decimal)
        args(8).Value = lEntidad.nabr
        args(9) = New SqlParameter("@nmay", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmay
        args(10) = New SqlParameter("@njun", SqlDbType.Decimal)
        args(10).Value = lEntidad.njun
        args(11) = New SqlParameter("@njul", SqlDbType.Decimal)
        args(11).Value = lEntidad.njul
        args(12) = New SqlParameter("@nago", SqlDbType.Decimal)
        args(12).Value = lEntidad.nago
        args(13) = New SqlParameter("@nsep", SqlDbType.Decimal)
        args(13).Value = lEntidad.nsep
        args(14) = New SqlParameter("@noct", SqlDbType.Decimal)
        args(14).Value = lEntidad.noct
        args(15) = New SqlParameter("@nnov", SqlDbType.Decimal)
        args(15).Value = lEntidad.nnov
        args(16) = New SqlParameter("@ndic", SqlDbType.Decimal)
        args(16).Value = lEntidad.ndic

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFLUJO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CLIDFLUJO ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = lEntidad.devalua

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFLUJO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = lEntidad.devalua

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.dflujo = IIf(.Item("dflujo") Is DBNull.Value, Nothing, .Item("dflujo"))
                lEntidad.npromm = IIf(.Item("npromm") Is DBNull.Value, Nothing, .Item("npromm"))
                lEntidad.nene = IIf(.Item("nene") Is DBNull.Value, 0, .Item("nene"))
                lEntidad.nfeb = IIf(.Item("nfeb") Is DBNull.Value, 0, .Item("nfeb"))
                lEntidad.nmar = IIf(.Item("nmar") Is DBNull.Value, 0, .Item("nmar"))
                lEntidad.nabr = IIf(.Item("nabr") Is DBNull.Value, 0, .Item("nabr"))
                lEntidad.nmay = IIf(.Item("nmay") Is DBNull.Value, 0, .Item("nmay"))
                lEntidad.njun = IIf(.Item("njun") Is DBNull.Value, 0, .Item("njun"))
                lEntidad.njul = IIf(.Item("njul") Is DBNull.Value, 0, .Item("njul"))
                lEntidad.nago = IIf(.Item("nago") Is DBNull.Value, 0, .Item("nago"))
                lEntidad.nsep = IIf(.Item("nsep") Is DBNull.Value, 0, .Item("nsep"))
                lEntidad.noct = IIf(.Item("noct") Is DBNull.Value, 0, .Item("noct"))
                lEntidad.nnov = IIf(.Item("nnov") Is DBNull.Value, 0, .Item("nnov"))
                lEntidad.ndic = IIf(.Item("ndic") Is DBNull.Value, 0, .Item("ndic"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As CLIDFLUJO
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(devalua),0) + 1 ")
        strSQL.Append(" FROM CLIDFLUJO ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcli As String, ccodfue As String) As listaCLIDFLUJO

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = ccodfue

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaCLIDFLUJO

        Try
            Do While dr.Read()
                Dim mEntidad As New CLIDFLUJO
                mEntidad.ccodcli = ccodcli
                mEntidad.ccodfue = ccodfue
                mEntidad.devalua = IIf(dr("devalua") Is DBNull.Value, Nothing, dr("devalua"))
                mEntidad.dflujo = IIf(dr("dflujo") Is DBNull.Value, Nothing, dr("dflujo"))
                mEntidad.npromm = IIf(dr("npromm") Is DBNull.Value, Nothing, dr("npromm"))
                mEntidad.nene = IIf(dr("nene") Is DBNull.Value, Nothing, dr("nene"))
                mEntidad.nfeb = IIf(dr("nfeb") Is DBNull.Value, Nothing, dr("nfeb"))
                mEntidad.nmar = IIf(dr("nmar") Is DBNull.Value, Nothing, dr("nmar"))
                mEntidad.nabr = IIf(dr("nabr") Is DBNull.Value, Nothing, dr("nabr"))
                mEntidad.nmay = IIf(dr("nmay") Is DBNull.Value, Nothing, dr("nmay"))
                mEntidad.njun = IIf(dr("njun") Is DBNull.Value, Nothing, dr("njun"))
                mEntidad.njul = IIf(dr("njul") Is DBNull.Value, Nothing, dr("njul"))
                mEntidad.nago = IIf(dr("nago") Is DBNull.Value, Nothing, dr("nago"))
                mEntidad.nsep = IIf(dr("nsep") Is DBNull.Value, Nothing, dr("nsep"))
                mEntidad.noct = IIf(dr("noct") Is DBNull.Value, Nothing, dr("noct"))
                mEntidad.nnov = IIf(dr("nnov") Is DBNull.Value, Nothing, dr("nnov"))
                mEntidad.ndic = IIf(dr("ndic") Is DBNull.Value, Nothing, dr("ndic"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, ccodfue As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, ccodfue As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)

        Dim tables(0) As String
        tables(0) = New String("CLIDFLUJO")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcli, ") 
        strSQL.Append(" ccodfue, ") 
        strSQL.Append(" devalua, ") 
        strSQL.Append(" dflujo, ") 
        strSQL.Append(" npromm, ")
        strSQL.Append(" nene, ")
        strSQL.Append(" nfeb, ")
        strSQL.Append(" nmar, ")
        strSQL.Append(" nabr, ")
        strSQL.Append(" nmay, ")
        strSQL.Append(" njun, ")
        strSQL.Append(" njul, ")
        strSQL.Append(" nago, ")
        strSQL.Append(" nsep, ")
        strSQL.Append(" noct, ")
        strSQL.Append(" nnov, ")
        strSQL.Append(" ndic ")
        strSQL.Append(" FROM CLIDFLUJO ")

    End Sub
    Public Function ObtenerDataSetPorcliente(ByVal ccodcli As String, ByVal ccodfue As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" and ccodfue = @ccodfue ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodfue = @ccodfue ")
        strSQL.Append(" AND devalua = @devalua ")

        Try

            Dim args(2) As SqlParameter
            args(0) = New SqlParameter("@ccodcli", ccodcli)
            args(1) = New SqlParameter("@ccodfue", ccodfue)
            args(2) = New SqlParameter("@devalua", devalua)

            Dim tables(0) As String
            tables(0) = New String("clidbal")

            sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

            Return 1

        Catch ex As Exception

            Return 0

        End Try

    End Function
    Public Function ObtenerPromedio(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date) As Decimal
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodfue = @ccodfue ")
        strSQL.Append(" AND devalua = @devalua ")

        Dim lnpromedio As Decimal = 0
        Try

            Dim args(2) As SqlParameter
            args(0) = New SqlParameter("@ccodcli", ccodcli)
            args(1) = New SqlParameter("@ccodfue", ccodfue)
            args(2) = New SqlParameter("@devalua", devalua)

            Dim ds As New DataSet
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

            If ds.Tables(0).Rows.Count = 0 Then
            Else
                If IsDBNull(ds.Tables(0).Rows(0)("npromm")) Then
                Else
                    lnpromedio = ds.Tables(0).Rows(0)("npromm")
                End If
            End If



        Catch ex As Exception

            Return 0

        End Try

        Return lnpromedio
    End Function
End Class
