Imports System.Text
Public Class dbCtbmcta
    Inherits dbBase
    Public Overridable Function ExecuteDataSet(ByVal connectionString As String, _
                          ByVal commandType As CommandType, _
                          ByVal commandText As String, _
                          ByVal params As SqlParameter(), _
                          ByVal commandTimeout As Integer) As DataSet
        Dim adapter As New SqlDataAdapter(commandText, connectionString)

        With adapter.SelectCommand
            .CommandType = commandType
            .CommandTimeout = commandTimeout
            .Parameters.AddRange(params)
        End With

        Dim data As New DataSet

        adapter.Fill(data)
        adapter.SelectCommand.Dispose()

        Return data
    End Function


    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbmcta
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta = "" _
            Or lEntidad.ccodcta = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbmcta ")
        strSQL.Append(" SET ctipmon = @ctipmon, ")
        strSQL.Append(" ctipcta = @ctipcta, ")
        strSQL.Append(" cnivel = @cnivel, ")
        strSQL.Append(" cclase = @cclase, ")
        strSQL.Append(" cdescrip = @cdescrip, ")
        strSQL.Append(" nsalini = @nsalini, ")
        strSQL.Append(" ndebeac = @ndebeac, ")
        strSQL.Append(" nhaberac = @nhaberac, ")
        strSQL.Append(" ccodto = @ccodto, ")
        strSQL.Append(" dfecreg = @dfecreg, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cmovida = @cmovida, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" cflc = @cflc, ")
        strSQL.Append(" nfln = @nfln, ")
        strSQL.Append(" oin = @oin, ")
        strSQL.Append(" nfuefon = @nfuefon, ")
        strSQL.Append(" nver = @nver, ")
        strSQL.Append(" cauxcta = @cauxcta, ")
        strSQL.Append(" cgu = @cgu, ")
        strSQL.Append(" cfuente = @cfuente, ")
        strSQL.Append(" cctasup = @cctasup ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(24) As SqlParameter
        args(0) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(0).Value = lEntidad.ctipmon
        args(1) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipcta
        args(2) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnivel
        args(3) = New SqlParameter("@cclase", SqlDbType.VarChar)
        args(3).Value = lEntidad.cclase
        args(4) = New SqlParameter("@cdescrip", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdescrip
        args(5) = New SqlParameter("@nsalini", SqlDbType.VarChar)
        args(5).Value = lEntidad.nsalini
        args(6) = New SqlParameter("@ndebeac", SqlDbType.VarChar)
        args(6).Value = lEntidad.ndebeac
        args(7) = New SqlParameter("@nhaberac", SqlDbType.VarChar)
        args(7).Value = lEntidad.nhaberac
        args(8) = New SqlParameter("@ccodto", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodto
        args(9) = New SqlParameter("@dfecreg", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecreg
        args(10) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@cmovida", SqlDbType.VarChar)
        args(11).Value = lEntidad.cmovida
        args(12) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodusu
        args(13) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(13).Value = lEntidad.cflc
        args(14) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(14).Value = lEntidad.nfln
        args(15) = New SqlParameter("@oin", SqlDbType.VarChar)
        args(15).Value = lEntidad.oin
        args(16) = New SqlParameter("@nfuefon", SqlDbType.VarChar)
        args(16).Value = lEntidad.nfuefon
        args(17) = New SqlParameter("@nver", SqlDbType.VarChar)
        args(17).Value = lEntidad.nver
        args(18) = New SqlParameter("@cauxcta", SqlDbType.VarChar)
        args(18).Value = lEntidad.cauxcta
        args(19) = New SqlParameter("@cgu", SqlDbType.VarChar)
        args(19).Value = lEntidad.cgu
        args(20) = New SqlParameter("@cfuente", SqlDbType.VarChar)
        args(20).Value = lEntidad.cfuente
        args(21) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(21).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(22) = New SqlParameter("@cctasup", SqlDbType.VarChar)
        args(22).Value = lEntidad.cCtaSup

        If lEntidad.cfuente = "99" Then
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbmcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ctbmcta ")
        strSQL.Append(" ( ccodcta, ")
        strSQL.Append(" ctipmon, ")
        strSQL.Append(" ctipcta, ")
        strSQL.Append(" cnivel, ")
        strSQL.Append(" cclase, ")
        strSQL.Append(" cdescrip, ")
        strSQL.Append(" nsalini, ")
        strSQL.Append(" ndebeac, ")
        strSQL.Append(" nhaberac, ")
        strSQL.Append(" ccodto, ")
        strSQL.Append(" dfecreg, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cmovida, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" oin, ")
        strSQL.Append(" nfuefon, ")
        strSQL.Append(" nver, ")
        strSQL.Append(" cauxcta, ")
        strSQL.Append(" cgu, ")
        strSQL.Append(" cCtaSup, ")
        strSQL.Append(" cfuente) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ")
        strSQL.Append(" @ctipmon, ")
        strSQL.Append(" @ctipcta, ")
        strSQL.Append(" @cnivel, ")
        strSQL.Append(" @cclase, ")
        strSQL.Append(" @cdescrip, ")
        strSQL.Append(" @nsalini, ")
        strSQL.Append(" @ndebeac, ")
        strSQL.Append(" @nhaberac, ")
        strSQL.Append(" @ccodto, ")
        strSQL.Append(" @dfecreg, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @cmovida, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @cflc, ")
        strSQL.Append(" @nfln, ")
        strSQL.Append(" @oin, ")
        strSQL.Append(" @nfuefon, ")
        strSQL.Append(" @nver, ")
        strSQL.Append(" @cauxcta, ")
        strSQL.Append(" @cgu, ")
        strSQL.Append(" @cCtaSup, ")
        strSQL.Append(" @cfuente) ")

        Dim args(22) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipmon
        args(2) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipcta
        args(3) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnivel
        args(4) = New SqlParameter("@cclase", SqlDbType.VarChar)
        args(4).Value = lEntidad.cclase
        args(5) = New SqlParameter("@cdescrip", SqlDbType.VarChar)
        args(5).Value = lEntidad.cdescrip
        args(6) = New SqlParameter("@nsalini", SqlDbType.VarChar)
        args(6).Value = lEntidad.nsalini
        args(7) = New SqlParameter("@ndebeac", SqlDbType.VarChar)
        args(7).Value = lEntidad.ndebeac
        args(8) = New SqlParameter("@nhaberac", SqlDbType.VarChar)
        args(8).Value = lEntidad.nhaberac
        args(9) = New SqlParameter("@ccodto", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodto
        args(10) = New SqlParameter("@dfecreg", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecreg
        args(11) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecmod
        args(12) = New SqlParameter("@cmovida", SqlDbType.VarChar)
        args(12).Value = lEntidad.cmovida
        args(13) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodusu
        args(14) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(14).Value = lEntidad.cflc
        args(15) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(15).Value = lEntidad.nfln
        args(16) = New SqlParameter("@oin", SqlDbType.VarChar)
        args(16).Value = lEntidad.oin
        args(17) = New SqlParameter("@nfuefon", SqlDbType.VarChar)
        args(17).Value = lEntidad.nfuefon
        args(18) = New SqlParameter("@nver", SqlDbType.VarChar)
        args(18).Value = lEntidad.nver
        args(19) = New SqlParameter("@cauxcta", SqlDbType.VarChar)
        args(19).Value = lEntidad.cauxcta
        args(20) = New SqlParameter("@cgu", SqlDbType.VarChar)
        args(20).Value = lEntidad.cgu
        args(21) = New SqlParameter("@cCtaSup", SqlDbType.VarChar)
        args(21).Value = lEntidad.cCtaSup
        args(22) = New SqlParameter("@cfuente", SqlDbType.VarChar)
        args(22).Value = lEntidad.cfuente
        If lEntidad.cfuente = "99" Then
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteNonQuery(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbmcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ctbmcta ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbmcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ctipmon = IIf(.Item("ctipmon") Is DBNull.Value, Nothing, .Item("ctipmon"))
                lEntidad.ctipcta = IIf(.Item("ctipcta") Is DBNull.Value, Nothing, .Item("ctipcta"))
                lEntidad.cnivel = IIf(.Item("cnivel") Is DBNull.Value, Nothing, .Item("cnivel"))
                lEntidad.cclase = IIf(.Item("cclase") Is DBNull.Value, Nothing, .Item("cclase"))
                lEntidad.cdescrip = IIf(.Item("cdescrip") Is DBNull.Value, Nothing, .Item("cdescrip"))
                lEntidad.nsalini = IIf(.Item("nsalini") Is DBNull.Value, Nothing, .Item("nsalini"))
                lEntidad.ndebeac = IIf(.Item("ndebeac") Is DBNull.Value, Nothing, .Item("ndebeac"))
                lEntidad.nhaberac = IIf(.Item("nhaberac") Is DBNull.Value, Nothing, .Item("nhaberac"))
                lEntidad.ccodto = IIf(.Item("ccodto") Is DBNull.Value, Nothing, .Item("ccodto"))
                lEntidad.dfecreg = IIf(.Item("dfecreg") Is DBNull.Value, Nothing, .Item("dfecreg"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cmovida = IIf(.Item("cmovida") Is DBNull.Value, Nothing, .Item("cmovida"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
                lEntidad.oin = IIf(.Item("oin") Is DBNull.Value, Nothing, .Item("oin"))
                lEntidad.nfuefon = IIf(.Item("nfuefon") Is DBNull.Value, Nothing, .Item("nfuefon"))
                lEntidad.nver = IIf(.Item("nver") Is DBNull.Value, Nothing, .Item("nver"))
                lEntidad.cauxcta = IIf(.Item("cauxcta") Is DBNull.Value, Nothing, .Item("cauxcta"))
                lEntidad.cgu = IIf(.Item("cgu") Is DBNull.Value, Nothing, .Item("cgu"))
                lEntidad.cfuente = IIf(.Item("cfuente") Is DBNull.Value, Nothing, .Item("cfuente"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ctbmcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcta),0) + 1 ")
        strSQL.Append(" FROM ctbmcta ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID(ByVal cCodigo As String, ByVal ccadena As String) As listactbmcta

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        'strSQL.Append(" order by ccodcta")


        Dim dr As SqlDataReader

        If cCodigo.Trim = "99" Then
            If ccadena.Trim = "" Then
                dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
            Else
                dr = sql.ExecuteReader(ccadena, CommandType.Text, strSQL.ToString())
            End If

        Else
            If ccadena.Trim = "" Then
                dr = sql.ExecuteReader(Me.gcnnString, CommandType.Text, strSQL.ToString())
            Else
                dr = sql.ExecuteReader(ccadena, CommandType.Text, strSQL.ToString())
            End If

        End If


        Dim lista As New listactbmcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ctbmcta
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.dfecreg = IIf(dr("dfecreg") Is DBNull.Value, Nothing, dr("dfecreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                '    mEntidad.cmovida = IIf(dr("cmovida") Is DBNull.Value, Nothing, dr("cmovida"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                '   mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                '  mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                ' mEntidad.oin = IIf(dr("oin") Is DBNull.Value, Nothing, dr("oin"))
                'mEntidad.nfuefon = IIf(dr("nfuefon") Is DBNull.Value, Nothing, dr("nfuefon"))
                'mEntidad.nver = IIf(dr("nver") Is DBNull.Value, Nothing, dr("nver"))
                'mEntidad.cauxcta = IIf(dr("cauxcta") Is DBNull.Value, Nothing, dr("cauxcta"))
                mEntidad.cgu = IIf(dr("cgu") Is DBNull.Value, Nothing, dr("cgu"))
                'mEntidad.cfuente = IIf(dr("cfuente") Is DBNull.Value, Nothing, dr("cfuente"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorID1(ByVal cCodigo As String) As listactbmcta

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE left(ccodcta,1) = '4' or left(ccodcta,1) = '5' ")

        Dim dr As SqlDataReader

        If cCodigo.Trim = "99" Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listactbmcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ctbmcta
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.dfecreg = IIf(dr("dfecreg") Is DBNull.Value, Nothing, dr("dfecreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmovida = IIf(dr("cmovida") Is DBNull.Value, Nothing, dr("cmovida"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.oin = IIf(dr("oin") Is DBNull.Value, Nothing, dr("oin"))
                mEntidad.nfuefon = IIf(dr("nfuefon") Is DBNull.Value, Nothing, dr("nfuefon"))
                mEntidad.nver = IIf(dr("nver") Is DBNull.Value, Nothing, dr("nver"))
                mEntidad.cauxcta = IIf(dr("cauxcta") Is DBNull.Value, Nothing, dr("cauxcta"))
                mEntidad.cgu = IIf(dr("cgu") Is DBNull.Value, Nothing, dr("cgu"))
                mEntidad.cfuente = IIf(dr("cfuente") Is DBNull.Value, Nothing, dr("cfuente"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorID2() As listactbmcta

        Dim strSQL As New StringBuilder
        Dim lwhere As String = "WHERE cCodTo <>" & "'" & "D" & "'"


        SelectTabla(strSQL)
        strSQL.Append(lwhere)
        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listactbmcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ctbmcta
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.dfecreg = IIf(dr("dfecreg") Is DBNull.Value, Nothing, dr("dfecreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmovida = IIf(dr("cmovida") Is DBNull.Value, Nothing, dr("cmovida"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.oin = IIf(dr("oin") Is DBNull.Value, Nothing, dr("oin"))
                mEntidad.nfuefon = IIf(dr("nfuefon") Is DBNull.Value, Nothing, dr("nfuefon"))
                mEntidad.nver = IIf(dr("nver") Is DBNull.Value, Nothing, dr("nver"))
                mEntidad.cauxcta = IIf(dr("cauxcta") Is DBNull.Value, Nothing, dr("cauxcta"))
                mEntidad.cgu = IIf(dr("cgu") Is DBNull.Value, Nothing, dr("cgu"))
                mEntidad.cfuente = IIf(dr("cfuente") Is DBNull.Value, Nothing, dr("cfuente"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorID2a(ByVal ccodigo As String) As listactbmcta

        Dim strSQL As New StringBuilder
        Dim lwhere As String = "WHERE cCodTo <>" & "'" & "D" & "'"


        SelectTabla1(strSQL)
        strSQL.Append(lwhere)
        Dim dr As SqlDataReader

        If ccodigo.Trim = "99" Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listactbmcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ctbmcta
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.dfecreg = IIf(dr("dfecreg") Is DBNull.Value, Nothing, dr("dfecreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmovida = IIf(dr("cmovida") Is DBNull.Value, Nothing, dr("cmovida"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.oin = IIf(dr("oin") Is DBNull.Value, Nothing, dr("oin"))
                mEntidad.nfuefon = IIf(dr("nfuefon") Is DBNull.Value, Nothing, dr("nfuefon"))
                mEntidad.nver = IIf(dr("nver") Is DBNull.Value, Nothing, dr("nver"))
                mEntidad.cauxcta = IIf(dr("cauxcta") Is DBNull.Value, Nothing, dr("cauxcta"))
                mEntidad.cgu = IIf(dr("cgu") Is DBNull.Value, Nothing, dr("cgu"))
                mEntidad.cfuente = IIf(dr("cfuente") Is DBNull.Value, Nothing, dr("cfuente"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" ORDER BY cCodcta")

        Dim ds As DataSet
        If ccodigo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("ctbmcta")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" ctipmon, ")
        strSQL.Append(" ctipcta, ")
        strSQL.Append(" cnivel, ")
        strSQL.Append(" cclase, ")
        strSQL.Append(" cdescrip , ")
        strSQL.Append(" nsalini, ")
        strSQL.Append(" ndebeac, ")
        strSQL.Append(" nhaberac, ")
        strSQL.Append(" ccodto, ")
        strSQL.Append(" dfecreg, ")
        strSQL.Append(" dfecmod, ")
        'strSQL.Append(" cmovida, ")
        strSQL.Append(" ccodusu, ")
        'strSQL.Append(" cflc, ")
        'strSQL.Append(" nfln, ")
        'strSQL.Append(" oin, ")
        'strSQL.Append(" nfuefon, ")
        'strSQL.Append(" nver, ")
        'strSQL.Append(" cauxcta, ")
        strSQL.Append(" cgu, ")
        'strSQL.Append(" cfuente, ")
        strSQL.Append(" cCtaSup, ")
        strSQL.Append(" 00000000.00 as nCargos, ")
        strSQL.Append(" 00000000.00 as nAbonos, ")
        strSQL.Append(" 00000000.00 as nSalAct ")
        strSQL.Append(" FROM ctbmcta ")

    End Sub
    Private Sub SelectTabla1(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" ctipmon, ")
        strSQL.Append(" ctipcta, ")
        strSQL.Append(" cnivel, ")
        strSQL.Append(" cclase, ")
        strSQL.Append(" (ccodcta + '     ' + cdescrip) as cdescrip , ")
        strSQL.Append(" nsalini, ")
        strSQL.Append(" ndebeac, ")
        strSQL.Append(" nhaberac, ")
        strSQL.Append(" ccodto, ")
        strSQL.Append(" dfecreg, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cmovida, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" nfln, ")
        strSQL.Append(" oin, ")
        strSQL.Append(" nfuefon, ")
        strSQL.Append(" nver, ")
        strSQL.Append(" cauxcta, ")
        strSQL.Append(" cgu, ")
        strSQL.Append(" cfuente, ")
        strSQL.Append(" cCtaSup, ")
        strSQL.Append(" 00000000.00 as nCargos, ")
        strSQL.Append(" 00000000.00 as nAbonos, ")
        strSQL.Append(" 00000000.00 as nSalAct ")
        strSQL.Append(" FROM ctbmcta ")

    End Sub

    'fran
    Public Function ObtenerDataSetPorCuenta(ByVal cCodCta As String, ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodCta = @ccodCta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodCta", cCodCta)

        Dim ds As DataSet
        If ccodigo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


        Return ds

    End Function
    Public Function ObtenerDataSetPorIDDet() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCodto =" & "'" & "D" & "'")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function ObtenerDataSetPorID2() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCodto <> " & "'" & "D" & "'")
        strSQL.Append(" ORDER BY cCodCta DESC")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function ObtenerDataSetPorID3(ByVal pcCodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCtaSup = @pcCodCta")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodCta", pcCodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetEsp(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta , cDescrip as cDescri  ")
        strSQL.Append(" FROM ctbmcta ")
        strSQL.Append(" where ccodto='D' and  cDescrip like" & "'" & "%" & cCodigo & "%" & "'")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp1(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta , cDescrip as cDescri  ")
        strSQL.Append(" FROM ctbmcta ")
        strSQL.Append(" WHERE cCodto = 'D' and ")
        strSQL.Append(" cCodcta like" & "'" & "%" & cCodigo & "%" & "'")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp2(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta , cDescrip as cDescri  ")
        strSQL.Append(" FROM ctbmcta ")
        strSQL.Append(" WHERE cCodto = 'D' ")

        Dim ds As DataSet

        Try
            If cCodigo.Trim = "99" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
            Else
                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    'Public Function ObtenerDataSetEsp3(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet

    '    Dim strSQL As New StringBuilder
    '    strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt , sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
    '    strSQL.Append(" FROM cntamov INNER JOIN Diario ")
    '    strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
    '    strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
    '    strSQL.Append(" cntamov.cNumcom ='" & cCodigo.Trim & "' ")
    '    If ccodofi.Trim = "001" Then
    '    Else
    '        strSQL.Append(" and cntamov.ccodofi =@cCodofi")
    '    End If
    '    If cpoliza = "*" Then
    '    Else
    '        strSQL.Append(" and cntamov.cpoliza =@cpoliza")
    '    End If

    '    strSQL.Append(" group by cntamov.cnumcom,Diario.cGlosa, cntamov.dfeccnt ")

    '    Dim args(1) As SqlParameter
    '    args(0) = New SqlParameter("@cCodofi", ccodofi)
    '    args(1) = New SqlParameter("@cpoliza", cpoliza)

    '    Dim ds As DataSet

    '    Try
    '        If cfondo = "99" Then
    '            If ccadena.Trim = "" Then
    '                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    '            Else
    '                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
    '            End If


    '        Else
    '            If ccadena.Trim = "" Then
    '                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
    '            Else
    '                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
    '            End If

    '        End If

    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    '    Return ds

    'End Function
    Public Function ObtenerDataSetEsp3(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt , sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
        strSQL.Append(" FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom like" & "'" & "%" & cCodigo & "%" & "'")
        If ccodofi.Trim = "001" Then
        Else
            strSQL.Append(" and cntamov.ccodofi =@cCodofi")
        End If

        strSQL.Append(" group by cntamov.cnumcom,Diario.cGlosa, cntamov.dfeccnt ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", ccodofi)

        Dim ds As DataSet

        Try
            'If cfondo = "99" Then
            If ccadena.Trim = "" Then
                ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)
            Else
                ds = ExecuteDataSet(ccadena, CommandType.Text, strSQL.ToString(), args, 0)
            End If


            'Else
            'If ccadena.Trim = "" Then
            '    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
            'Else
            '    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
            'End If

            'End If

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    'Public Function ObtenerDataSetEsp4(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet

    '    Dim strSQL As New StringBuilder
    '    strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt , sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
    '    strSQL.Append(" FROM cntamov INNER JOIN Diario ")
    '    strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
    '    strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
    '    strSQL.Append(" Diario.cGlosa like " & "'%" & cCodigo.Trim & "%' ")
    '    If ccodofi.Trim = "001" Then
    '    Else
    '        strSQL.Append(" and cntamov.ccodofi =@cCodofi")
    '    End If
    '    If cpoliza = "*" Then
    '    Else
    '        strSQL.Append(" and cntamov.cpoliza =@cpoliza")
    '    End If

    '    strSQL.Append(" group by cntamov.cnumcom,Diario.cGlosa, cntamov.dfeccnt order by cntamov.cnumcom ")

    '    Dim args(2) As SqlParameter
    '    args(0) = New SqlParameter("@ccodigo", cCodigo)
    '    args(1) = New SqlParameter("@ccodofi", ccodofi)
    '    args(2) = New SqlParameter("@cpoliza", cpoliza)

    '    Dim ds As DataSet

    '    Try
    '        If cfondo = "99" Then
    '            If ccadena.Trim = "" Then
    '                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    '            Else
    '                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
    '            End If


    '        Else
    '            If ccadena.Trim = "" Then
    '                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
    '            Else
    '                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
    '            End If

    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    '    Return ds

    'End Function
    Public Function ObtenerDataSetEsp4(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt , sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
        strSQL.Append(" FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" Diario.cGlosa like " & "'%" & cCodigo.Trim & "%' ")
        If ccodofi.Trim = "001" Then
        Else
            strSQL.Append(" and cntamov.ccodofi =@cCodofi")
        End If

        strSQL.Append(" group by cntamov.cnumcom,Diario.cGlosa, cntamov.dfeccnt order by cntamov.cnumcom ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", cCodigo)
        args(1) = New SqlParameter("@ccodofi", ccodofi)

        Dim ds As DataSet

        Try
            'If cfondo = "99" Then
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
            End If


            'Else
            'If ccadena.Trim = "" Then
            '    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
            'Else
            '    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
            'End If

            'End If
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp5(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt, diario.dfecdoc, ")
        strSQL.Append(" cntamov.ffondos, cntamov.ccodofi, cntamov.cpoliza, Diario.cnumdoc FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom = " & "'" & cCodigo & "'")

        Dim ds As DataSet

        Try
            If cfondo = "99" Then
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
                End If


            Else
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp6(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cntamov.cnumcom, cntamov.cnumlin as Idcuenta, cntamov.cCodcta , cntamov.nDebe, cntamov.nHaber, CNTAMOV.CCONCEPTO, ")
        strSQL.Append(" Diario.dfecdoc, Diario.cglosa, CTbmcta.cdescrip as cdescri, cntamov.ffondos, cntamov.ccodofi ")
        strSQL.Append(" FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" inner join ctbmcta on cntamov.ccodcta = ctbmcta.ccodcta ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom = " & "'" & cCodigo & "'")
        strSQL.Append(" ORDER BY cntamov.cnumlin ")

        Dim ds As DataSet

        Try
            If cfondo = "99" Then
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
                End If


            Else
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp7(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt, ")
        strSQL.Append(" cntamov.ffondos, cntamov.ccodofi, ctbdchq.cnomchq, ctbdchq.cmonchq, ")
        strSQL.Append(" ctbdchq.ccodbco, ctbdchq.cctacte, ctbdchq.cmonlet, ctbdchq.cnrochq,")
        strSQL.Append(" cntamov.ffondos, cntamov.ccodofi FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" INNER JOIN Ctbdchq  ON Diario.cnumcom = Ctbdchq.cnumcom ")
        strSQL.Append(" WHERE ctbdchq.cflc = ' ' and ")
        strSQL.Append(" cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom = " & "'" & cCodigo & "'")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp8(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cntamov.cNumcom, Diario.cGlosa, cntamov.dfeccnt, cntamov.ffondos, cntamov.ccodofi,DIARIO.ccodusu,")
        strSQL.Append(" ctbdchq.cnomchq, ctbmcta.ccodcta, ctbmcta.cdescrip, cntamov.ndebe, cntamov.nhaber, ctbdchq.cmonchq, ctbdchq.ccodbco,")
        strSQL.Append(" ctbdchq.cctacte, ctbdchq.cmonlet, ctbdchq.cnrochq, cntamov.ffondos, Tabtbco.cnombco,")
        strSQL.Append(" cntamov.ccodofi FROM ctbmcta INNER JOIN cntamov ON ctbmcta.ccodcta = cntamov.ccodcta INNER JOIN Diario")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom INNER JOIN CTBDCHQ ON Diario.cnumcom = Ctbdchq.cnumcom")
        strSQL.Append(" INNER JOIN TABTBCO ON Tabtbco.cCodbco = ctbdchq.cCodbco")
        strSQL.Append(" WHERE ctbdchq.cflc = ' ' and ")
        strSQL.Append(" cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom = " & "'" & cCodigo & "'")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds


    End Function

    Public Function ObtenerDataSetEsp9(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccadena As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cntamov.cnumcom, cntamov.cnumlin as Idcuenta, ctbmcta.cdescrip, cntamov.cCodcta , cntamov.nDebe, cntamov.nHaber, ")
        strSQL.Append(" Diario.cnumdoc, Diario.dfecdoc, Diario.cglosa, cntamov.ffondos, cntamov.ccodusu1 as ccodusu, cntamov.ccodofi, Diario.dfecmod, diario.ccodofi as coficina, tabtofi.cnomofi ")
        strSQL.Append(" FROM ctbmcta INNER JOIN cntamov ")
        strSQL.Append(" ON ctbmcta.ccodcta = cntamov.ccodcta INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" inner join tabtofi on diario.ccodofi = tabtofi.ccodofi ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom = " & "'" & cCodigo & "'")
        strSQL.Append(" ORDER BY cntamov.cnumlin ")

        Dim ds As DataSet

        Try
            If cfondo = "99" Then
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
                End If


            Else
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
                End If

            End If


        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ValidarCuenta(ByVal cCodCta As String) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodCta = @ccodCta and cCodto ='D' ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodCta", cCodCta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If

    End Function
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    Public Function ObtenerDataSetEstado(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" select nsalini, ltrim(rtrim(cdescrip)) as cdescrip , rtrim(ltrim(cCodcta)) as cCodcta, ltrim(cnivel) as cnivel, ")
        strSQL.Append(" 000000000000.00 as Acumulado, ")
        strSQL.Append(" 000000000000.00 as Enero, ")
        strSQL.Append(" 000000000000.00 as Febrero, ")
        strSQL.Append(" 000000000000.00 as Marzo, ")
        strSQL.Append(" 000000000000.00 as Abril, ")
        strSQL.Append(" 000000000000.00 as Mayo, ")
        strSQL.Append(" 000000000000.00 as Junio, ")
        strSQL.Append(" 000000000000.00 as Julio, ")
        strSQL.Append(" 000000000000.00 as Agosto, ")
        strSQL.Append(" 000000000000.00 as Septiembre, ")
        strSQL.Append(" 000000000000.00 as Octubre, ")
        strSQL.Append(" 000000000000.00 as Noviembre, ")
        strSQL.Append(" 000000000000.00 as Diciembre, ")
        strSQL.Append(" 000000000000.00 as nsalini ")
        strSQL.Append(" FROM CTBMCTA ")
        strSQL.Append(" WHERE left(cCodcta,1) = '4' or left(cCodcta,1) = '5'")
        strSQL.Append(" ORDER BY cCodcta ")

        Dim ds As DataSet

        If cCodigo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Return ds

    End Function

    Public Function ObtenerDataSetCuentas(ByVal cCodigo1 As String, ByVal cCodigo2 As String, ByVal cCodigo As String) As DataSet
        Dim lnnivel1 As Integer = 0
        Dim lnnivel2 As Integer = 0
        lnnivel1 = cCodigo1.Trim.Length
        lnnivel2 = cCodigo2.Trim.Length


        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta , nsalini, cDescrip as cDescri  ")
        strSQL.Append(" FROM ctbmcta ")
        strSQL.Append(" WHERE  ")
        'strSQL.Append(" cCodcta >=" & "'" & cCodigo1 & "'" & " and cCodcta<=" & "'" & cCodigo2 & "'")
        strSQL.Append("left(ccodcta, @nnivel1) = left(@ccodigo1, @nnivel1)  ")
        strSQL.Append(" and left(ccodcta, @nnivel2) = left(@ccodigo2, @nnivel2)  ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodigo1", SqlDbType.VarChar)
        args(0).Value = cCodigo1
        args(1) = New SqlParameter("@ccodigo2", SqlDbType.VarChar)
        args(1).Value = cCodigo2
        args(2) = New SqlParameter("@nnivel1", SqlDbType.VarChar)
        args(2).Value = lnnivel1
        args(3) = New SqlParameter("@nnivel2", SqlDbType.VarChar)
        args(3).Value = lnnivel2

        Dim ds As DataSet

        Try
            If cCodigo.Trim = "99" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function ObtenerDescripcionPorCuenta(ByVal cCodCta As String, ByVal ccodigo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cdescrip, ccodto FROM CTBMCTA ")
        strSQL.Append(" WHERE ccodCta = @ccodCta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodCta", cCodCta)

        Dim ds As DataSet
        If ccodigo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If

        Return ds
    End Function
    'Saldo Inicial
    Public Function saldoinicial(ByVal ccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ctbmcta.nsalini from ctbmcta ")
        strSQL.Append(" WHERE ccodCta = @ccodCta ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodCta", ccodcta)

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("nSalini")
        End If

    End Function


    Public Function ActualizarSaldos(ByVal ccodcta As String, ByVal nsalini As Double, ByVal cfondo As String) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbmcta ")
        strSQL.Append(" SET nsalini = @nsalini ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@nsalini", SqlDbType.Decimal)
        args(1).Value = nsalini
        If cfondo.Trim = "99" Then
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteNonQuery(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function
    Public Function EntradaCatalogo(ByVal cCodigo As String) As Integer

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Try
            Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
            Dim oCommand As SqlClient.SqlCommand = _
               New SqlClient.SqlCommand("CatalogoIN", oConexion)

            Dim oParameter As SqlClient.SqlParameter

            oParameter = oCommand.Parameters.Add("@cCodigo", SqlDbType.VarChar)
            oParameter.Value = cCodigo

            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New DataSet
            oDa.Fill(oDs)

            oDs.Dispose()
            oDa.Dispose()
            oCommand.Dispose()
            oConexion.Close()
            oConexion.Dispose()
            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function SalidaCatalogo(ByVal cCodigo As String) As Integer

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet
        Try
            Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
            Dim oCommand As SqlClient.SqlCommand = _
               New SqlClient.SqlCommand("CatalogoON", oConexion)

            Dim oParameter As SqlClient.SqlParameter

            oParameter = oCommand.Parameters.Add("@cCodigo", SqlDbType.VarChar)
            oParameter.Value = cCodigo

            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New DataSet
            oDa.Fill(oDs)

            oDs.Dispose()
            oDa.Dispose()
            oCommand.Dispose()
            oConexion.Close()
            oConexion.Dispose()
            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function


    Public Function ObtenerListaPorID45(ByVal cCodigo As String) As listactbmcta

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE left(ccodcta,1) = '4' or left(ccodcta,1) = '5' ")
        'strSQL.Append(" order by ccodcta")


        Dim dr As SqlDataReader

        If cCodigo.Trim = "99" Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listactbmcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ctbmcta
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ctipmon = IIf(dr("ctipmon") Is DBNull.Value, Nothing, dr("ctipmon"))
                mEntidad.ctipcta = IIf(dr("ctipcta") Is DBNull.Value, Nothing, dr("ctipcta"))
                mEntidad.cnivel = IIf(dr("cnivel") Is DBNull.Value, Nothing, dr("cnivel"))
                mEntidad.cclase = IIf(dr("cclase") Is DBNull.Value, Nothing, dr("cclase"))
                mEntidad.cdescrip = IIf(dr("cdescrip") Is DBNull.Value, Nothing, dr("cdescrip"))
                mEntidad.nsalini = IIf(dr("nsalini") Is DBNull.Value, Nothing, dr("nsalini"))
                mEntidad.ndebeac = IIf(dr("ndebeac") Is DBNull.Value, Nothing, dr("ndebeac"))
                mEntidad.nhaberac = IIf(dr("nhaberac") Is DBNull.Value, Nothing, dr("nhaberac"))
                mEntidad.ccodto = IIf(dr("ccodto") Is DBNull.Value, Nothing, dr("ccodto"))
                mEntidad.dfecreg = IIf(dr("dfecreg") Is DBNull.Value, Nothing, dr("dfecreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cmovida = IIf(dr("cmovida") Is DBNull.Value, Nothing, dr("cmovida"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                mEntidad.oin = IIf(dr("oin") Is DBNull.Value, Nothing, dr("oin"))
                mEntidad.nfuefon = IIf(dr("nfuefon") Is DBNull.Value, Nothing, dr("nfuefon"))
                mEntidad.nver = IIf(dr("nver") Is DBNull.Value, Nothing, dr("nver"))
                mEntidad.cauxcta = IIf(dr("cauxcta") Is DBNull.Value, Nothing, dr("cauxcta"))
                mEntidad.cgu = IIf(dr("cgu") Is DBNull.Value, Nothing, dr("cgu"))
                mEntidad.cfuente = IIf(dr("cfuente") Is DBNull.Value, Nothing, dr("cfuente"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    
    
    Public Function Plantilla1(ByVal ccodtab As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodigo, casiento, 0000000.00 as nDebe, 0000000.00 as nHaber, ccode ")
        strSQL.Append(" FROM CTBPLAN WHERE cCodtab = @ccodtab and ctipreg = '1' order by corden ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function PlantillaDataSet(ByVal cCodigo As String, ByVal cnivel As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ccodcta, cdescrip, nsaldo, cnivel, ccodigo, cflag, ccodigoa, nsaldoa, cflaga   ")
        strSQL.Append(" FROM Plantillas ")
        strSQL.Append(" WHERE  ")
        strSQL.Append(" ccodpla = @ccodigo  ")
        If cnivel = "00" Then
        Else
            strSQL.Append(" and cnivel <= @cnivel")
        End If
        strSQL.Append(" order by cast(ccodigo as numeric) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = cCodigo
        args(1) = New SqlParameter("@cnivel", SqlDbType.VarChar)
        args(1).Value = cnivel


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function PlantillaAux(ByVal ccodpla As String, ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ccodcta, csigno   ")
        strSQL.Append(" FROM PlantillasAux ")
        strSQL.Append(" WHERE  ")
        strSQL.Append(" ccodpla = @ccodpla ")
        strSQL.Append(" and ccodigo = @ccodigo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodpla", SqlDbType.VarChar)
        args(0).Value = ccodpla
        args(1) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(1).Value = cCodigo

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function CatalagoCombo() As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT rtrim(ltrim(cCodcta)) as cCodcta , (left(ccodcta,15) + '-' + cDescrip) as cDescri  ")
        strSQL.Append(" FROM ctbmcta ")
        strSQL.Append(" WHERE cCodto = 'D' order by cCodcta ")

        Dim ds As DataSet

        Try

            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())

        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function ObtieneNiveles() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select cnivel, cnivel as nivel from ctbmcta group by cnivel order by cnivel  ")
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds
    End Function
    'Public Function ObtenerDataSetEsp4a(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String, ByVal cpoliza As String) As DataSet

    '    Dim strSQL As New StringBuilder
    '    strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt, sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
    '    strSQL.Append(" FROM cntamov INNER JOIN Diario ")
    '    strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
    '    strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
    '    strSQL.Append(" cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin ")

    '    If ccodofi.Trim = "001" Then
    '    Else
    '        strSQL.Append(" and cntamov.ccodofi =@cCodofi")
    '    End If
    '    If cpoliza = "*" Then
    '    Else
    '        strSQL.Append(" and cntamov.cpoliza =@cpoliza")
    '    End If


    '    strSQL.Append(" group by cntamov.dfeccnt,cntamov.cnumcom,Diario.cGlosa  order by cntamov.cnumcom ")

    '    Dim args(3) As SqlParameter
    '    args(0) = New SqlParameter("@dfecini", SqlDbType.DateTime)
    '    args(0).Value = dfecini
    '    args(1) = New SqlParameter("@dfecfin", SqlDbType.DateTime)
    '    args(1).Value = dfecfin
    '    args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
    '    args(2).Value = ccodofi
    '    args(3) = New SqlParameter("@cpoliza", SqlDbType.VarChar)
    '    args(3).Value = cpoliza

    '    Dim ds As DataSet


    '    Try
    '        If cfondo = "01" Then
    '            If ccadena.Trim = "" Then
    '                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    '            Else
    '                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
    '            End If


    '        Else
    '            If ccadena.Trim = "" Then
    '                ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
    '            Else
    '                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
    '            End If

    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    '    Return ds

    'End Function
    Public Function ObtenerDataSetEsp4a(ByVal dfecini As Date, ByVal dfecfin As Date, ByVal cfondo As String, ByVal ccadena As String, ByVal ccodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt, sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
        strSQL.Append(" FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin ")

        If ccodofi.Trim = "001" Then
        Else
            strSQL.Append(" and cntamov.ccodofi =@cCodofi")
        End If

        strSQL.Append(" group by cntamov.cnumcom,Diario.cGlosa, cntamov.dfeccnt order by cntamov.cnumcom ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecini", SqlDbType.DateTime)
        args(0).Value = dfecini
        args(1) = New SqlParameter("@dfecfin", SqlDbType.DateTime)
        args(1).Value = dfecfin
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi

        Dim ds As DataSet


        Try
            '  If cfondo = "01" Then
            If ccadena.Trim = "" Then
                ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            Else
                ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
            End If


            'Else
            'If ccadena.Trim = "" Then
            '    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
            'Else
            '    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
            'End If

            'End If
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function Modificar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ctbmcta
        Dim lID As Long
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbmcta ")
        strSQL.Append(" SET ctipmon = @ctipmon, ")
        strSQL.Append(" ctipcta = @ctipcta, ")
        strSQL.Append(" cdescrip = @cdescrip, ")
        strSQL.Append(" ccodto = @ccodto, ")
        strSQL.Append(" dfecreg = @dfecreg, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" ccodusu = @ccodusu ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@ctipmon", SqlDbType.VarChar)
        args(0).Value = lEntidad.ctipmon
        args(1) = New SqlParameter("@ctipcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipcta
        args(2) = New SqlParameter("@cdescrip", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdescrip
        args(3) = New SqlParameter("@ccodto", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodto
        args(4) = New SqlParameter("@dfecreg", SqlDbType.DateTime)
        args(4).Value = lEntidad.dfecreg
        args(5) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(5).Value = lEntidad.dfecmod
        args(6) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodusu
        args(7) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)



    End Function
   
    Public Function ObtenerBusquedaCheque(ByVal cfondo As String, ByVal ccadena As String, ByVal cbanco As String, ByVal cnrochq As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal opcion As Integer, ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt , sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
        strSQL.Append(" FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" inner join CTBDCHQ on cntamov.cnumcom = ctbdchq.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' ")

        If opcion = 1 Then
            strSQL.Append(" and cntamov.cNumcom like" & "'" & "%" & cCodigo & "%" & "'")
        ElseIf opcion = 2 Then
            strSQL.Append(" and Diario.cGlosa like " & "'%" & cCodigo.Trim & "%' ")
        Else
            If cbanco = "00" Then
            Else
                strSQL.Append(" and ctbdchq.ccodbco = @cbanco ")
            End If
            If cnrochq = "00" Then
            Else
                strSQL.Append(" and ctbdchq.cnrochq = @cnrochq ")
            End If

        End If
        strSQL.Append(" and ctbdchq.dfeccnt2 >= @dfecini and ctbdchq.dfeccnt2 <= @dfecfin ")
        strSQL.Append(" group by cntamov.cnumcom,Diario.cGlosa, cntamov.dfeccnt order by cntamov.cnumcom ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cbanco", cbanco)
        args(1) = New SqlParameter("@cnrochq", cnrochq)
        args(2) = New SqlParameter("@dfecini", dfecini)
        args(3) = New SqlParameter("@dfecfin", dfecfin)

        Dim ds As DataSet

        Try
            If cfondo = "99" Then
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
                End If


            Else
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function ObtenerBusquedaPartidaBancaria(ByVal cfondo As String, ByVal ccadena As String, ByVal cbanco As String, ByVal cnrochq As String, ByVal dfecini As Date, ByVal dfecfin As Date, ByVal opcion As Integer, ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cntamov.cNumcom , Diario.cGlosa, cntamov.dfeccnt , sum(cntamov.ndebe) as ncargo, sum(cntamov.nhaber) as nabono, 00000.00 as ndifer ")
        strSQL.Append(" FROM cntamov INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' ")

        If opcion = 1 Then
            strSQL.Append(" and cntamov.cNumcom like" & "'" & "%" & ccodigo & "%" & "'")
        ElseIf opcion = 2 Then
            strSQL.Append(" and Diario.cGlosa like " & "'%" & ccodigo.Trim & "%' ")
        Else
            If cbanco = "00" Then
            Else
                strSQL.Append(" and cntamov.ccodcta = @cbanco ")
            End If

        End If
        strSQL.Append(" and cntamov.dfeccnt >= @dfecini and cntamov.dfeccnt <= @dfecfin ")
        strSQL.Append(" group by cntamov.dfeccnt, cntamov.cnumcom,Diario.cGlosa  order by cntamov.cnumcom ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cbanco", cbanco)
        args(1) = New SqlParameter("@cnrochq", cnrochq)
        args(2) = New SqlParameter("@dfecini", dfecini)
        args(3) = New SqlParameter("@dfecfin", dfecfin)

        Dim ds As DataSet

        Try
            If cfondo = "99" Then
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
                End If


            Else
                If ccadena.Trim = "" Then
                    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
                Else
                    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString(), args)
                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function
    Public Function PartidaFiltrada(ByVal cCodigo As String, ByVal cfondo As String, ByVal ccodofi As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cntamov.cnumcom,cntamov.dfecmod, cntamov.cnumlin as Idcuenta, ctbmcta.cdescrip, cntamov.cCodcta , cntamov.nDebe, cntamov.nHaber, ")
        strSQL.Append(" cntamov.cpoliza, Diario.cnumdoc, Diario.dfecdoc, Diario.cglosa, cntamov.ffondos, cntamov.ccodusu1 as ccodusu, cntamov.ccodofi ")
        strSQL.Append(" FROM ctbmcta INNER JOIN cntamov ")
        strSQL.Append(" ON ctbmcta.ccodcta = cntamov.ccodcta INNER JOIN Diario ")
        strSQL.Append(" ON Cntamov.cnumcom = Diario.cnumcom ")
        strSQL.Append(" WHERE cntamov.cflc = ' ' and ")
        strSQL.Append(" cntamov.cNumcom = " & "'" & cCodigo & "'")
        If cfondo = "00" Then

        Else
            strSQL.Append(" and cntamov.ffondos = " & "'" & cfondo & "'")
        End If

        If ccodofi = "000" Then
        Else
            strSQL.Append(" and cntamov.ccodofi = " & "'" & ccodofi & "'")
        End If

        strSQL.Append(" ORDER BY cntamov.cnumlin ")

        Dim ds As DataSet

        Try


            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Catch ex As Exception

        End Try

        Return ds

    End Function
    Public Function ObtieneCuentaCajaChica() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select rtrim(ltrim(ccodcta)) as ccodcta, rtrim(ltrim(ccodcta))+' - '+  rtrim(ltrim(cdescrip)) as cdescrip from ctbmcta ")
        strSQL.Append("where ctbmcta.cflc = 'CC'  ")
        'strSQL.Append("where left(ctbmcta.cflc,1 ) = 'K' and left(ccodcta,8)<> '10110104' ")


        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds

    End Function


    Public Function ObtieneCuentaCajaChica2(ByVal ccodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodcta, cdescrip from ctbmcta ")
        strSQL.Append("where left(ctbmcta.cflc,1 ) = 'K' and left(ccodcta,8) = '10110104' ")


        If ccodofi = "001" Then
        Else
            ccodofi = ccodofi.Substring(1, 2)
            strSQL.Append(" and substring(ccodcta,11,2)='" + ccodofi + "'")
        End If

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds

    End Function

    Public Function ObtieneAuxCta(ByVal ccodcta As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cauxcta from ctbmcta ")
        strSQL.Append("where ccodcta = @ccodcta ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcauxcta As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cauxcta")) Then
            Else
                lcauxcta = ds.Tables(0).Rows(0)("cauxcta")
            End If
        End If

        Return lcauxcta
    End Function

    Public Function Extraer_Ctas_Ctb() As DataSet

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim ccadena_ As String

        ccadena_ = Me.cnnStr


        Using connection As New SqlConnection(ccadena_)
            connection.Open()

            command.Connection = connection

            Try

                command.CommandText = _
                                        " Select LTRIM(RTRIM(ccodcta)) as ccodcta, (ltrim(rtrim(ccodcta)) + ' | ' + upper(cdescrip)) as cdescrip from ctbmcta " & _
                                        " where ccodto = 'D'" & _
                                        " order by ccodcta "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_Ctas_CTB")

            Catch ex As Exception
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using

        Return ds


    End Function
   
End Class
