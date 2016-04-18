Imports System.Text
Public Class dbCntabal
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntabal
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cfecmes = "" _
            Or lEntidad.ffondos = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ffondos = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntabal ")
        strSQL.Append(" SET cfecmes = @cfecmes, ")
        strSQL.Append(" ccodcta = @ccodcta, ")
        strSQL.Append(" nsalini = @nsalini, ")
        strSQL.Append(" ndebe = @ndebe, ")
        strSQL.Append(" nhaber = @nhaber, ")
        strSQL.Append(" nsalfin = @nsalfin, ")
        strSQL.Append(" ndebeac = @ndebeac, ")
        strSQL.Append(" nhaberac = @nhaberac, ")
        strSQL.Append(" ctipmon = @ctipmon, ")
        strSQL.Append(" cnivel = @cnivel, ")
        strSQL.Append(" ctipcta = @ctipcta, ")
        strSQL.Append(" cclase = @cclase, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" ccodbal = @ccodbal, ")
        strSQL.Append(" cflc = @cflc, ")
        strSQL.Append(" nfln = @nfln, ")
        strSQL.Append(" bs = @bs, ")
        strSQL.Append(" ccodto = @ccodto ")
        strSQL.Append(" ccodofi = @ccodofi, ")
        strSQL.Append(" ffondos = @ffondos, ")

        Dim args(17) As SqlParameter
        args(0) = New SqlParameter("@cfecmes", SqlDbType.VarChar)
        args(0).Value = lEntidad.cfecmes
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta
        args(2) = New SqlParameter("@nsalini", SqlDbType.VarChar)
        args(2).Value = lEntidad.nsalini
        args(3) = New SqlParameter("@ndebe", SqlDbType.VarChar)
        args(3).Value = lEntidad.ndebe
        args(4) = New SqlParameter("@nhaber", SqlDbType.VarChar)
        args(4).Value = lEntidad.nhaber
        args(5) = New SqlParameter("@nsalfin", SqlDbType.VarChar)
        args(5).Value = lEntidad.nsalfin
        args(6) = New SqlParameter("@ndebeac", SqlDbType.VarChar)
        args(6).Value = lEntidad.ndebeac
        args(7) = New SqlParameter("@nhaberac", SqlDbType.VarChar)
        args(7).Value = lEntidad.nhaberac
        args(8) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctipmon
        args(9) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(9).Value = lEntidad.cnivel
        args(10) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctipcta
        args(11) = New SqlParameter("@cclase", SqlDbType.VarChar)
        args(11).Value = lEntidad.cclase
        args(12) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodusu
        args(13) = New SqlParameter("@ccodbal", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodbal
        args(14) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(14).Value = lEntidad.cflc
        args(15) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(15).Value = lEntidad.nfln
        args(16) = New SqlParameter("@bs", SqlDbType.VarChar)
        args(16).Value = lEntidad.bs
        args(17) = New SqlParameter("@ccodto", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodto
        args(18) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodofi
        args(19) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(19).Value = lEntidad.ffondos

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntabal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cntabal ")
        strSQL.Append(" ( cfecmes, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" nsalini, ") 
        strSQL.Append(" ndebe, ") 
        strSQL.Append(" nhaber, ") 
        strSQL.Append(" nsalfin, ") 
        strSQL.Append(" ndebeac, ") 
        strSQL.Append(" nhaberac, ") 
        strSQL.Append(" ctipmon, ") 
        strSQL.Append(" cnivel, ") 
        strSQL.Append(" ctipcta, ") 
        strSQL.Append(" cclase, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" ccodbal, ") 
        strSQL.Append(" cflc, ") 
        strSQL.Append(" nfln, ") 
        strSQL.Append(" bs, ") 
        strSQL.Append(" ccodto, ")
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" ffondos) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cfecmes, ") 
        strSQL.Append(" @ccodcta, ") 
        strSQL.Append(" @nsalini, ") 
        strSQL.Append(" @ndebe, ") 
        strSQL.Append(" @nhaber, ") 
        strSQL.Append(" @nsalfin, ") 
        strSQL.Append(" @ndebeac, ") 
        strSQL.Append(" @nhaberac, ") 
        strSQL.Append(" @ctipmon, ") 
        strSQL.Append(" @cnivel, ") 
        strSQL.Append(" @ctipcta, ") 
        strSQL.Append(" @cclase, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @ccodbal, ") 
        strSQL.Append(" @cflc, ") 
        strSQL.Append(" @nfln, ") 
        strSQL.Append(" @bs, ") 
        strSQL.Append(" @ccodto, ")
        strSQL.Append(" @ccodofi, ") 
        strSQL.Append(" @ffondos) ")

        Dim args(19) As SqlParameter
        args(0) = New SqlParameter("@cfecmes", SqlDbType.VarChar)
        args(0).Value = lEntidad.cfecmes.Trim
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta.Trim
        args(2) = New SqlParameter("@nsalini", SqlDbType.VarChar)
        args(2).Value = lEntidad.nsalini
        args(3) = New SqlParameter("@ndebe", SqlDbType.VarChar)
        args(3).Value = lEntidad.ndebe
        args(4) = New SqlParameter("@nhaber", SqlDbType.VarChar)
        args(4).Value = lEntidad.nhaber
        args(5) = New SqlParameter("@nsalfin", SqlDbType.VarChar)
        args(5).Value = lEntidad.nsalfin
        args(6) = New SqlParameter("@ndebeac", SqlDbType.VarChar)
        args(6).Value = lEntidad.ndebeac
        args(7) = New SqlParameter("@nhaberac", SqlDbType.VarChar)
        args(7).Value = lEntidad.nhaberac
        args(8) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctipmon.Trim
        args(9) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(9).Value = lEntidad.cnivel.Trim
        args(10) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctipcta.Trim
        args(11) = New SqlParameter("@cclase", SqlDbType.VarChar)
        args(11).Value = lEntidad.cclase.Trim
        args(12) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodusu.Trim
        args(13) = New SqlParameter("@ccodbal", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodbal.Trim
        args(14) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(14).Value = lEntidad.cflc.Trim
        args(15) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(15).Value = lEntidad.nfln
        args(16) = New SqlParameter("@bs", SqlDbType.VarChar)
        args(16).Value = lEntidad.bs.Trim
        args(17) = New SqlParameter("@ccodto", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodto.Trim
        args(18) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodofi.Trim
        args(19) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(19).Value = lEntidad.ffondos.Trim

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntabal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cntabal ")

        Dim args(-1) As SqlParameter

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntabal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cfecmes = IIf(.Item("cfecmes") Is DBNull.Value, Nothing, .Item("cfecmes"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.nsalini = IIf(.Item("nsalini") Is DBNull.Value, Nothing, .Item("nsalini"))
                lEntidad.ndebe = IIf(.Item("ndebe") Is DBNull.Value, Nothing, .Item("ndebe"))
                lEntidad.nhaber = IIf(.Item("nhaber") Is DBNull.Value, Nothing, .Item("nhaber"))
                lEntidad.nsalfin = IIf(.Item("nsalfin") Is DBNull.Value, Nothing, .Item("nsalfin"))
                lEntidad.ndebeac = IIf(.Item("ndebeac") Is DBNull.Value, Nothing, .Item("ndebeac"))
                lEntidad.nhaberac = IIf(.Item("nhaberac") Is DBNull.Value, Nothing, .Item("nhaberac"))
                lEntidad.ctipmon = IIf(.Item("ctipmon") Is DBNull.Value, Nothing, .Item("ctipmon"))
                lEntidad.cnivel = IIf(.Item("cnivel") Is DBNull.Value, Nothing, .Item("cnivel"))
                lEntidad.ctipcta = IIf(.Item("ctipcta") Is DBNull.Value, Nothing, .Item("ctipcta"))
                lEntidad.cclase = IIf(.Item("cclase") Is DBNull.Value, Nothing, .Item("cclase"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.ccodbal = IIf(.Item("ccodbal") Is DBNull.Value, Nothing, .Item("ccodbal"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
                lEntidad.bs = IIf(.Item("bs") Is DBNull.Value, Nothing, .Item("bs"))
                lEntidad.ccodto = IIf(.Item("ccodto") Is DBNull.Value, Nothing, .Item("ccodto"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.ffondos = IIf(.Item("ffondos") Is DBNull.Value, Nothing, .Item("ffondos"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cntabal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(),0) + 1 ")
        strSQL.Append(" FROM cntabal ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacntabal

        Dim strSQL As New StringBuilder
        SelectTabla1(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listacntabal

        Try
            Do While dr.Read()
                Dim mEntidad As New cntabal
                mEntidad.cfecmes = IIf(dr("cfecmes") Is DBNull.Value, Nothing, dr("cfecmes"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebe = IIf(dr("ndebe") Is DBNull.Value, Nothing, dr("ndebe"))
                mEntidad.nhaber = IIf(dr("nhaber") Is DBNull.Value, Nothing, dr("nhaber"))
                mEntidad.nsalfin = IIf(dr("nsalfin") Is DBNull.Value, Nothing, dr("nsalfin"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.ccodbal = IIf(dr("ccodbal") Is DBNull.Value, Nothing, dr("ccodbal"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.bs = IIf(dr("bs") Is DBNull.Value, Nothing, dr("bs"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ffondos = IIf(dr("ffondos") Is DBNull.Value, Nothing, dr("ffondos"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
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

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("cntabal")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT CNTABAL.cfecmes, ")
        strSQL.Append(" CNTABAL.ccodcta, ")
        strSQL.Append(" CNTABAL.nsalini, ")
        strSQL.Append(" CNTABAL.ndebe, ")
        strSQL.Append(" CNTABAL.nhaber, ")
        strSQL.Append(" CNTABAL.nsalfin, ")
        strSQL.Append(" CNTABAL.ndebeac, ")
        strSQL.Append(" CNTABAL.nhaberac, ")
        strSQL.Append(" CNTABAL.ctipmon, ")
        strSQL.Append(" CNTABAL.cnivel, ")
        strSQL.Append(" CNTABAL.ctipcta, ")
        strSQL.Append(" CNTABAL.cclase, ")
        strSQL.Append(" CNTABAL.ccodusu, ")
        strSQL.Append(" CNTABAL.ccodbal, ")
        strSQL.Append(" CNTABAL.cflc, ")
        strSQL.Append(" CNTABAL.nfln, ")
        strSQL.Append(" CNTABAL.bs, ")
        strSQL.Append(" CNTABAL.ccodto, ")
        strSQL.Append(" CNTABAL.ccodofi, ")
        strSQL.Append(" CNTABAL.ffondos ")
        strSQL.Append(" FROM cntabal")
    End Sub
    'fran
    Public Function Actualizar1(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntabal
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cfecmes = "" _
            Or lEntidad.ffondos = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ffondos = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntabal ")
        strSQL.Append(" SET cfecmes = @cfecmes, ")
        strSQL.Append(" ndebe = @ndebe, ")
        strSQL.Append(" nhaber = @nhaber, ")
        strSQL.Append(" nsalini = @nsalini, ")
        strSQL.Append(" nsalfin = @nsalfin, ")
        strSQL.Append(" ndebeac = @ndebeac, ")
        strSQL.Append(" nhaberac = @nhaberac ")
        strSQL.Append(" WHERE cCodCta = @cCodcta")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@cfecmes", SqlDbType.VarChar)
        args(0).Value = lEntidad.cfecmes
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta
        args(2) = New SqlParameter("@ndebe", SqlDbType.Decimal)
        args(2).Value = lEntidad.ndebe
        args(3) = New SqlParameter("@nhaber", SqlDbType.Decimal)
        args(3).Value = lEntidad.nhaber
        args(4) = New SqlParameter("@nsalini", SqlDbType.Decimal)
        args(4).Value = lEntidad.nsalini
        args(5) = New SqlParameter("@nsalfin", SqlDbType.Decimal)
        args(5).Value = lEntidad.nsalfin
        args(6) = New SqlParameter("@ndebeac", SqlDbType.Decimal)
        args(6).Value = lEntidad.ndebeac
        args(7) = New SqlParameter("@nhaberac", SqlDbType.Decimal)
        args(7).Value = lEntidad.nhaberac


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetPorIDH(ByVal pcCodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCodCta = @pccodCta")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodCta", pcCodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Private Sub SelectTabla1(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT CNTABAL.cfecmes, ")
        strSQL.Append(" CNTABAL.ccodcta, ")
        strSQL.Append(" CNTABAL.nsalini, ")
        strSQL.Append(" CNTABAL.ndebe, ")
        strSQL.Append(" CNTABAL.nhaber, ")
        strSQL.Append(" CNTABAL.nsalfin, ")
        strSQL.Append(" CNTABAL.ndebeac, ")
        strSQL.Append(" CNTABAL.nhaberac, ")
        strSQL.Append(" CNTABAL.ctipmon, ")
        strSQL.Append(" CNTABAL.cnivel, ")
        strSQL.Append(" CNTABAL.ctipcta, ")
        strSQL.Append(" CNTABAL.cclase, ")
        strSQL.Append(" CNTABAL.ccodusu, ")
        strSQL.Append(" CNTABAL.ccodbal, ")
        strSQL.Append(" CNTABAL.cflc, ")
        strSQL.Append(" CNTABAL.nfln, ")
        strSQL.Append(" CNTABAL.bs, ")
        strSQL.Append(" CNTABAL.ccodto, ")
        strSQL.Append(" CNTABAL.ccodofi, ")
        strSQL.Append(" CNTABAL.ffondos, ")
        strSQL.Append(" CTBMCTA.cDescrip ")
        strSQL.Append(" FROM cntabal, CTBMCTA ")
        strSQL.Append(" WHERE CTBMCTA.cCodcta = CNTABAL.cCodCta and CTBMCTA.cGu = " & "'" & "B" & "'")
    End Sub

    Private Sub SelectTabla2(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT CNTABAL.cfecmes, ")
        strSQL.Append(" CNTABAL.ccodcta, ")
        strSQL.Append(" CNTABAL.nsalini, ")
        strSQL.Append(" CNTABAL.ndebe, ")
        strSQL.Append(" CNTABAL.nhaber, ")
        strSQL.Append(" CNTABAL.nsalfin, ")
        strSQL.Append(" CNTABAL.ndebeac, ")
        strSQL.Append(" CNTABAL.nhaberac, ")
        strSQL.Append(" CNTABAL.ctipmon, ")
        strSQL.Append(" CNTABAL.cnivel, ")
        strSQL.Append(" CNTABAL.ctipcta, ")
        strSQL.Append(" CNTABAL.cclase, ")
        strSQL.Append(" CNTABAL.ccodusu, ")
        strSQL.Append(" CNTABAL.ccodbal, ")
        strSQL.Append(" CNTABAL.cflc, ")
        strSQL.Append(" CNTABAL.nfln, ")
        strSQL.Append(" CNTABAL.bs, ")
        strSQL.Append(" CNTABAL.ccodto, ")
        strSQL.Append(" CNTABAL.ccodofi, ")
        strSQL.Append(" CNTABAL.ffondos, ")
        strSQL.Append(" CTBMCTA.cDescrip ")
        strSQL.Append(" FROM cntabal, CTBMCTA ")
        strSQL.Append(" WHERE CTBMCTA.cCodcta = CNTABAL.cCodCta and CTBMCTA.cGu = " & "'" & "R" & "'")
    End Sub

    Public Function ObtenerListaPorIDRes() As listacntabal

        Dim strSQL As New StringBuilder
        SelectTabla2(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacntabal

        Try
            Do While dr.Read()
                Dim mEntidad As New cntabal
                mEntidad.cfecmes = IIf(dr("cfecmes") Is DBNull.Value, Nothing, dr("cfecmes"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebe = IIf(dr("ndebe") Is DBNull.Value, Nothing, dr("ndebe"))
                mEntidad.nhaber = IIf(dr("nhaber") Is DBNull.Value, Nothing, dr("nhaber"))
                mEntidad.nsalfin = IIf(dr("nsalfin") Is DBNull.Value, Nothing, dr("nsalfin"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.ccodbal = IIf(dr("ccodbal") Is DBNull.Value, Nothing, dr("ccodbal"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.bs = IIf(dr("bs") Is DBNull.Value, Nothing, dr("bs"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.ffondos = IIf(dr("ffondos") Is DBNull.Value, Nothing, dr("ffondos"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

End Class
