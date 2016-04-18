Imports System.Text
Public Class dbCLIDFAMI
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFAMI
        Dim lID As Long
        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CLIDFAMI ")
        strSQL.Append(" SET nIngCony = @nIngCony, ") 
        strSQL.Append(" nIngFami = @nIngFami, ") 
        strSQL.Append(" nIngSSPC = @nIngSSPC, ") 
        strSQL.Append(" nIngReme = @nIngReme, ")
        strSQL.Append(" nGasCasa = @nGasCasa, ") 
        strSQL.Append(" nGasAlim = @nGasAlim, ") 
        strSQL.Append(" nGasAlte = @nGasAlte, ") 
        strSQL.Append(" ngasTran = @ngasTran, ") 
        strSQL.Append(" nGasEduc = @nGasEduc, ") 
        strSQL.Append(" nGasSalu = @nGasSalu, ") 
        strSQL.Append(" nGasRopa = @nGasRopa, ") 
        strSQL.Append(" nGasPres = @nGasPres, ")
        strSQL.Append(" cCodusu =  @cCodusu, ")
        strSQL.Append(" IdUnico =  @cCodUni, ")
        strSQL.Append(" dFecMod =  @dFecMod  ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND Idunico = @cCodUni ")

        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@nIngCony", SqlDbType.Decimal)
        args(0).Value = lEntidad.nIngCony
        args(1) = New SqlParameter("@nIngFami", SqlDbType.Decimal)
        args(1).Value = lEntidad.nIngFami
        args(2) = New SqlParameter("@nIngSSPC", SqlDbType.Decimal)
        args(2).Value = lEntidad.nIngSSPC
        args(3) = New SqlParameter("@nIngReme", SqlDbType.Decimal)
        args(3).Value = lEntidad.nIngReme
        args(4) = New SqlParameter("@nGasCasa", SqlDbType.Decimal)
        args(4).Value = lEntidad.nGasCasa
        args(5) = New SqlParameter("@nGasAlim", SqlDbType.Decimal)
        args(5).Value = lEntidad.nGasAlim
        args(6) = New SqlParameter("@nGasAlte", SqlDbType.Decimal)
        args(6).Value = lEntidad.nGasAlte
        args(7) = New SqlParameter("@ngasTran", SqlDbType.Decimal)
        args(7).Value = lEntidad.ngasTran
        args(8) = New SqlParameter("@nGasEduc", SqlDbType.Decimal)
        args(8).Value = lEntidad.nGasEduc
        args(9) = New SqlParameter("@nGasSalu", SqlDbType.Decimal)
        args(9).Value = lEntidad.nGasSalu
        args(10) = New SqlParameter("@nGasRopa", SqlDbType.Decimal)
        args(10).Value = lEntidad.nGasRopa
        args(11) = New SqlParameter("@nGasPres", SqlDbType.Decimal)
        args(11).Value = lEntidad.nGasPres
        args(12) = New SqlParameter("@cCodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.cCodusu
        args(13) = New SqlParameter("@cCodUni", SqlDbType.VarChar)
        args(13).Value = lEntidad.cCodUni
        args(14) = New SqlParameter("@dFecMod", SqlDbType.DateTime)
        args(14).Value = lEntidad.dFecMod
        args(15) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(15).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(16) = New SqlParameter("@dEvalua", SqlDbType.DateTime)
        args(16).Value = IIf(lEntidad.dEvalua = Nothing, DBNull.Value, lEntidad.dEvalua)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFAMI
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO CLIDFAMI ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" dEvalua, ") 
        strSQL.Append(" nIngCony, ") 
        strSQL.Append(" nIngFami, ")
        strSQL.Append(" nIngSSPC, ")
        strSQL.Append(" nIngReme, ")
        strSQL.Append(" nGasCasa, ") 
        strSQL.Append(" nGasAlim, ") 
        strSQL.Append(" nGasAlte, ") 
        strSQL.Append(" ngasTran, ") 
        strSQL.Append(" nGasEduc, ") 
        strSQL.Append(" nGasSalu, ") 
        strSQL.Append(" nGasRopa, ") 
        strSQL.Append(" nGasPres, ")
        strSQL.Append(" cCodusu, ")
        strSQL.Append(" IdUnico, ")
        strSQL.Append(" dFecMod ) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @dEvalua, ") 
        strSQL.Append(" @nIngCony, ") 
        strSQL.Append(" @nIngFami, ") 
        strSQL.Append(" @nIngSSPC, ") 
        strSQL.Append(" @nIngReme, ")
        strSQL.Append(" @nGasCasa, ") 
        strSQL.Append(" @nGasAlim, ") 
        strSQL.Append(" @nGasAlte, ") 
        strSQL.Append(" @ngasTran, ") 
        strSQL.Append(" @nGasEduc, ") 
        strSQL.Append(" @nGasSalu, ") 
        strSQL.Append(" @nGasRopa, ") 
        strSQL.Append(" @nGasPres, ")
        strSQL.Append(" @cCodusu, ")
        strSQL.Append(" @cCodUni, ")
        strSQL.Append(" @dFecMod ) ")

        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@dEvalua", SqlDbType.Datetime)
        args(1).Value = IIf(lEntidad.dEvalua = Nothing, DBNull.Value, lEntidad.dEvalua)
        args(2) = New SqlParameter("@nIngCony", SqlDbType.Decimal)
        args(2).Value = lEntidad.nIngCony
        args(3) = New SqlParameter("@nIngFami", SqlDbType.Decimal)
        args(3).Value = lEntidad.nIngFami
        args(4) = New SqlParameter("@nIngSSPC", SqlDbType.Decimal)
        args(4).Value = lEntidad.nIngSSPC
        args(5) = New SqlParameter("@nIngReme", SqlDbType.Decimal)
        args(5).Value = lEntidad.nIngReme
        args(6) = New SqlParameter("@nGasCasa", SqlDbType.Decimal)
        args(6).Value = lEntidad.nGasCasa
        args(7) = New SqlParameter("@nGasAlim", SqlDbType.Decimal)
        args(7).Value = lEntidad.nGasAlim
        args(8) = New SqlParameter("@nGasAlte", SqlDbType.Decimal)
        args(8).Value = lEntidad.nGasAlte
        args(9) = New SqlParameter("@ngasTran", SqlDbType.Decimal)
        args(9).Value = lEntidad.ngasTran
        args(10) = New SqlParameter("@nGasEduc", SqlDbType.Decimal)
        args(10).Value = lEntidad.nGasEduc
        args(11) = New SqlParameter("@nGasSalu", SqlDbType.Decimal)
        args(11).Value = lEntidad.nGasSalu
        args(12) = New SqlParameter("@nGasRopa", SqlDbType.Decimal)
        args(12).Value = lEntidad.nGasRopa
        args(13) = New SqlParameter("@nGasPres", SqlDbType.Decimal)
        args(13).Value = lEntidad.nGasPres
        args(14) = New SqlParameter("@cCodusu", SqlDbType.VarChar)
        args(14).Value = lEntidad.cCodusu
        args(15) = New SqlParameter("@cCodUni", SqlDbType.VarChar)
        args(15).Value = lEntidad.cCodUni
        args(16) = New SqlParameter("@dFecMod", SqlDbType.DateTime)
        args(16).Value = lEntidad.dFecMod

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFAMI
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM CLIDFAMI ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND IdUnico = @cCodUni ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@cCodUni", SqlDbType.VarChar)
        args(1).Value = lEntidad.cCodUni

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CLIDFAMI
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND IdUnico = @cCodUni ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@cCodUni", SqlDbType.VarChar)
        args(1).Value = lEntidad.cCodUni

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.nIngCony = IIf(.Item("nIngCony") Is DBNull.Value, Nothing, .Item("nIngCony"))
                lEntidad.nIngFami = IIf(.Item("nIngFami") Is DBNull.Value, Nothing, .Item("nIngFami"))
                lEntidad.nIngSSPC = IIf(.Item("nIngSSPC") Is DBNull.Value, Nothing, .Item("nIngSSPC"))
                lEntidad.nIngReme = IIf(.Item("nIngReme") Is DBNull.Value, Nothing, .Item("nIngReme"))
                lEntidad.nIngVari = IIf(.Item("nIngVari") Is DBNull.Value, Nothing, .Item("nIngVari"))
                lEntidad.nGasCasa = IIf(.Item("nGasCasa") Is DBNull.Value, Nothing, .Item("nGasCasa"))
                lEntidad.nGasAlim = IIf(.Item("nGasAlim") Is DBNull.Value, Nothing, .Item("nGasAlim"))
                lEntidad.nGasAlte = IIf(.Item("nGasAlte") Is DBNull.Value, Nothing, .Item("nGasAlte"))
                lEntidad.ngasTran = IIf(.Item("ngasTran") Is DBNull.Value, Nothing, .Item("ngasTran"))
                lEntidad.nGasEduc = IIf(.Item("nGasEduc") Is DBNull.Value, Nothing, .Item("nGasEduc"))
                lEntidad.nGasSalu = IIf(.Item("nGasSalu") Is DBNull.Value, Nothing, .Item("nGasSalu"))
                lEntidad.nGasRopa = IIf(.Item("nGasRopa") Is DBNull.Value, Nothing, .Item("nGasRopa"))
                lEntidad.nGasPres = IIf(.Item("nGasPres") Is DBNull.Value, Nothing, .Item("nGasPres"))
                lEntidad.cCodusu = IIf(.Item("cCodusu") Is DBNull.Value, Nothing, .Item("cCodusu"))
                lEntidad.dFecMod = IIf(.Item("dFecMod") Is DBNull.Value, Nothing, .Item("dFecMod"))
                lEntidad.cCodUni = IIf(.Item("IdUnico") Is DBNull.Value, Nothing, .Item("IdUnico"))
                lEntidad.dEvalua = IIf(.Item("dEvalua") Is DBNull.Value, Nothing, .Item("dEvalua"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As CLIDFAMI
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(dEvalua),0) + 1 ")
        strSQL.Append(" FROM CLIDFAMI ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcli As String) As listaCLIDFAMI

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaCLIDFAMI

        Try
            Do While dr.Read()
                Dim mEntidad As New CLIDFAMI
                mEntidad.ccodcli = ccodcli
                mEntidad.dEvalua = IIf(dr("dEvalua") Is DBNull.Value, Nothing, dr("dEvalua"))
                mEntidad.nIngCony = IIf(dr("nIngCony") Is DBNull.Value, Nothing, dr("nIngCony"))
                mEntidad.nIngFami = IIf(dr("nIngFami") Is DBNull.Value, Nothing, dr("nIngFami"))
                mEntidad.nIngSSPC = IIf(dr("nIngSSPC") Is DBNull.Value, Nothing, dr("nIngSSPC"))
                mEntidad.nIngReme = IIf(dr("nIngReme") Is DBNull.Value, Nothing, dr("nIngReme"))
                mEntidad.nIngVari = IIf(dr("nIngVari") Is DBNull.Value, Nothing, dr("nIngVari"))
                mEntidad.nGasCasa = IIf(dr("nGasCasa") Is DBNull.Value, Nothing, dr("nGasCasa"))
                mEntidad.nGasAlim = IIf(dr("nGasAlim") Is DBNull.Value, Nothing, dr("nGasAlim"))
                mEntidad.nGasAlte = IIf(dr("nGasAlte") Is DBNull.Value, Nothing, dr("nGasAlte"))
                mEntidad.ngasTran = IIf(dr("ngasTran") Is DBNull.Value, Nothing, dr("ngasTran"))
                mEntidad.nGasEduc = IIf(dr("nGasEduc") Is DBNull.Value, Nothing, dr("nGasEduc"))
                mEntidad.nGasSalu = IIf(dr("nGasSalu") Is DBNull.Value, Nothing, dr("nGasSalu"))
                mEntidad.nGasRopa = IIf(dr("nGasRopa") Is DBNull.Value, Nothing, dr("nGasRopa"))
                mEntidad.nGasPres = IIf(dr("nGasPres") Is DBNull.Value, Nothing, dr("nGasPres"))
                mEntidad.cCodusu = IIf(dr("cCodusu") Is DBNull.Value, Nothing, dr("cCodusu"))
                mEntidad.dFecMod = IIf(dr("dFecMod") Is DBNull.Value, Nothing, dr("dFecMod"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetEspc(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT idunico as Nro, dEvalua as Fecha FROM ClidFami ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenercCoduni2(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(idunico) as idunico")
        strSQL.Append(" FROM Clidfami ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("idunico")) Then
                lccodgar = "001"
            Else
                lccodgar = ds.Tables(0).Rows(0)("idunico")
                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 3 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = "001"
        End If



        Return lccodgar

    End Function



    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)

        Dim tables(0) As String
        tables(0) = New String("CLIDFAMI")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcli, ")
        strSQL.Append(" dEvalua, ")
        strSQL.Append(" nIngCony, ")
        strSQL.Append(" nIngFami, ")
        strSQL.Append(" nIngSSPC, ")
        strSQL.Append(" nIngReme, ")
        strSQL.Append(" nIngVari, ")
        strSQL.Append(" nGasCasa, ")
        strSQL.Append(" nGasAlim, ")
        strSQL.Append(" nGasAlte, ")
        strSQL.Append(" ngasTran, ")
        strSQL.Append(" nGasEduc, ")
        strSQL.Append(" nGasSalu, ")
        strSQL.Append(" nGasRopa, ")
        strSQL.Append(" nGasPres, ")
        strSQL.Append(" cCodusu, ")
        strSQL.Append(" dFecMod, ")
        strSQL.Append(" IdUnico ")
        strSQL.Append(" FROM CLIDFAMI ")

    End Sub



    Public Function ObtenercCoduni(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(idunico)+1 as idunico")
        strSQL.Append(" FROM Clidfami ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("idunico")) Then
                lccodgar = "001"
            Else
                lccodgar = ds.Tables(0).Rows(0)("idunico")
                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 3 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = "001"
        End If



        Return lccodgar

    End Function

    Public Function ObtenerFechaUlt(ByVal ccodcli As String) As Date

        Dim strSQL As New StringBuilder
        Dim ldevalua As Date = #1/1/1980#
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(devalua)  as devalua ")
        strSQL.Append(" FROM Clidfami ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("devalua")) Then
            Else
                ldevalua = ds.Tables(0).Rows(0)("devalua")

            End If
        Else

        End If

        Return ldevalua

    End Function

End Class
