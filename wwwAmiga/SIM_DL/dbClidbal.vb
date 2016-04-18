Imports System.Text
Public Class dbClidbal
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidbal
        Dim lID As Long
        lEntidad = aEntidad

        'If lEntidad.devalua =  0 _
        '    Or lEntidad.devalua = Nothing Then 

        '    lID = Me.ObtenerID(lEntidad)

        '    If lID = -1 Then Return -1

        '    lEntidad.devalua = lID

        '    Return Agregar(lEntidad)

        'End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE clidbal ")
        strSQL.Append(" SET dbalanc = @dbalanc, ") 
        strSQL.Append(" nactdis = @nactdis, ") 
        strSQL.Append(" nctacob = @nctacob, ") 
        strSQL.Append(" ninvent = @ninvent, ") 
        strSQL.Append(" nactfij = @nactfij, ") 
        strSQL.Append(" nprovee = @nprovee, ") 
        strSQL.Append(" notrpre = @notrpre, ") 
        strSQL.Append(" ncreins = @ncreins, ") 
        strSQL.Append(" nventas = @nventas, ") 
        strSQL.Append(" nrecupe = @nrecupe, ") 
        strSQL.Append(" nmercad = @nmercad, ") 
        strSQL.Append(" notregr = @notregr, ") 
        strSQL.Append(" nemplea = @nemplea, ") 
        strSQL.Append(" nsueldo = @nsueldo, ") 
        strSQL.Append(" npagpres = @npagpres, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" notring = @notring, ") 
        strSQL.Append(" nimpues = @nimpues, ")
        strSQL.Append(" nimprev = @nimprev, ") 
        strSQL.Append(" notract = @notract, ")
        strSQL.Append(" nmarseg = @nmarseg ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 
        strSQL.Append(" AND devalua = @devalua ") 

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@dbalanc", SqlDbType.Datetime)
        args(0).Value = lEntidad.dbalanc
        args(1) = New SqlParameter("@nactdis", SqlDbType.Decimal)
        args(1).Value = lEntidad.nactdis
        args(2) = New SqlParameter("@nctacob", SqlDbType.Decimal)
        args(2).Value = lEntidad.nctacob
        args(3) = New SqlParameter("@ninvent", SqlDbType.Decimal)
        args(3).Value = lEntidad.ninvent
        args(4) = New SqlParameter("@nactfij", SqlDbType.Decimal)
        args(4).Value = lEntidad.nactfij
        args(5) = New SqlParameter("@nprovee", SqlDbType.Decimal)
        args(5).Value = lEntidad.nprovee
        args(6) = New SqlParameter("@notrpre", SqlDbType.Decimal)
        args(6).Value = lEntidad.notrpre
        args(7) = New SqlParameter("@ncreins", SqlDbType.Decimal)
        args(7).Value = lEntidad.ncreins
        args(8) = New SqlParameter("@nventas", SqlDbType.Decimal)
        args(8).Value = lEntidad.nventas
        args(9) = New SqlParameter("@nrecupe", SqlDbType.Decimal)
        args(9).Value = lEntidad.nrecupe
        args(10) = New SqlParameter("@nmercad", SqlDbType.Decimal)
        args(10).Value = lEntidad.nmercad
        args(11) = New SqlParameter("@notregr", SqlDbType.Decimal)
        args(11).Value = lEntidad.notregr
        args(12) = New SqlParameter("@nemplea", SqlDbType.Decimal)
        args(12).Value = lEntidad.nemplea
        args(13) = New SqlParameter("@nsueldo", SqlDbType.Decimal)
        args(13).Value = lEntidad.nsueldo
        args(14) = New SqlParameter("@npagpres", SqlDbType.Decimal)
        args(14).Value = lEntidad.npagpres
        args(15) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodusu
        args(16) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(16).Value = lEntidad.dfecmod
        args(17) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(17).Value = lEntidad.cflag
        args(18) = New SqlParameter("@notring", SqlDbType.Decimal)
        args(18).Value = lEntidad.notring
        args(19) = New SqlParameter("@nimpues", SqlDbType.Decimal)
        args(19).Value = lEntidad.nimpues
        args(20) = New SqlParameter("@nimprev", SqlDbType.Decimal)
        args(20).Value = lEntidad.nimprev
        args(21) = New SqlParameter("@notract", SqlDbType.Decimal)
        args(21).Value = lEntidad.notract
        args(22) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(22).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value,lEntidad.ccodcli)
        args(23) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(23).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value,lEntidad.ccodfue)
        args(24) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(24).Value = IIf(lEntidad.devalua = Nothing, DBNull.Value,lEntidad.devalua)
        args(25) = New SqlParameter("@nmarseg", SqlDbType.Decimal)
        args(25).Value = IIf(lEntidad.nmarseg = Nothing, DBNull.Value, lEntidad.nmarseg)
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidbal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO clidbal ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodfue, ") 
        strSQL.Append(" devalua, ") 
        strSQL.Append(" dbalanc, ") 
        strSQL.Append(" nactdis, ") 
        strSQL.Append(" nctacob, ") 
        strSQL.Append(" ninvent, ") 
        strSQL.Append(" nactfij, ") 
        strSQL.Append(" nprovee, ") 
        strSQL.Append(" notrpre, ") 
        strSQL.Append(" ncreins, ") 
        strSQL.Append(" nventas, ") 
        strSQL.Append(" nrecupe, ") 
        strSQL.Append(" nmercad, ") 
        strSQL.Append(" notregr, ") 
        strSQL.Append(" nemplea, ") 
        strSQL.Append(" nsueldo, ") 
        strSQL.Append(" npagpres, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" notring, ") 
        strSQL.Append(" nimpues, ")
        strSQL.Append(" nimprev, ") 
        strSQL.Append(" notract , ")
        strSQL.Append(" nmarseg ) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodfue, ") 
        strSQL.Append(" @devalua, ") 
        strSQL.Append(" @dbalanc, ") 
        strSQL.Append(" @nactdis, ") 
        strSQL.Append(" @nctacob, ") 
        strSQL.Append(" @ninvent, ") 
        strSQL.Append(" @nactfij, ") 
        strSQL.Append(" @nprovee, ") 
        strSQL.Append(" @notrpre, ") 
        strSQL.Append(" @ncreins, ") 
        strSQL.Append(" @nventas, ") 
        strSQL.Append(" @nrecupe, ") 
        strSQL.Append(" @nmercad, ") 
        strSQL.Append(" @notregr, ") 
        strSQL.Append(" @nemplea, ") 
        strSQL.Append(" @nsueldo, ") 
        strSQL.Append(" @npagpres, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @notring, ") 
        strSQL.Append(" @nimpues, ")
        strSQL.Append(" @nimprev, ") 
        strSQL.Append(" @notract, ")
        strSQL.Append(" @nmarseg) ")

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodfue = Nothing, DBNull.Value, lEntidad.ccodfue)
        args(2) = New SqlParameter("@devalua", SqlDbType.Datetime)
        args(2).Value = IIf(lEntidad.devalua = Nothing, DBNull.Value, lEntidad.devalua)
        args(3) = New SqlParameter("@dbalanc", SqlDbType.Datetime)
        args(3).Value = lEntidad.dbalanc
        args(4) = New SqlParameter("@nactdis", SqlDbType.Decimal)
        args(4).Value = lEntidad.nactdis
        args(5) = New SqlParameter("@nctacob", SqlDbType.Decimal)
        args(5).Value = lEntidad.nctacob
        args(6) = New SqlParameter("@ninvent", SqlDbType.Decimal)
        args(6).Value = lEntidad.ninvent
        args(7) = New SqlParameter("@nactfij", SqlDbType.Decimal)
        args(7).Value = lEntidad.nactfij
        args(8) = New SqlParameter("@nprovee", SqlDbType.Decimal)
        args(8).Value = lEntidad.nprovee
        args(9) = New SqlParameter("@notrpre", SqlDbType.Decimal)
        args(9).Value = lEntidad.notrpre
        args(10) = New SqlParameter("@ncreins", SqlDbType.Decimal)
        args(10).Value = lEntidad.ncreins
        args(11) = New SqlParameter("@nventas", SqlDbType.Decimal)
        args(11).Value = lEntidad.nventas
        args(12) = New SqlParameter("@nrecupe", SqlDbType.Decimal)
        args(12).Value = lEntidad.nrecupe
        args(13) = New SqlParameter("@nmercad", SqlDbType.Decimal)
        args(13).Value = lEntidad.nmercad
        args(14) = New SqlParameter("@notregr", SqlDbType.Decimal)
        args(14).Value = lEntidad.notregr
        args(15) = New SqlParameter("@nemplea", SqlDbType.Decimal)
        args(15).Value = lEntidad.nemplea
        args(16) = New SqlParameter("@nsueldo", SqlDbType.Decimal)
        args(16).Value = lEntidad.nsueldo
        args(17) = New SqlParameter("@npagpres", SqlDbType.Decimal)
        args(17).Value = lEntidad.npagpres
        args(18) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodusu
        args(19) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(19).Value = lEntidad.dfecmod
        args(20) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(20).Value = lEntidad.cflag
        args(21) = New SqlParameter("@notring", SqlDbType.Decimal)
        args(21).Value = lEntidad.notring
        args(22) = New SqlParameter("@nimpues", SqlDbType.Decimal)
        args(22).Value = lEntidad.nimpues
        args(23) = New SqlParameter("@nimprev", SqlDbType.Decimal)
        args(23).Value = lEntidad.nimprev
        args(24) = New SqlParameter("@notract", SqlDbType.Decimal)
        args(24).Value = lEntidad.notract
        args(25) = New SqlParameter("@nmarseg", SqlDbType.Decimal)
        args(25).Value = lEntidad.nmarseg

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As clidbal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM clidbal ")
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

        Dim lEntidad As clidbal
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
                lEntidad.dbalanc = IIf(.Item("dbalanc") Is DBNull.Value, Nothing, .Item("dbalanc"))
                lEntidad.nactdis = IIf(.Item("nactdis") Is DBNull.Value, Nothing, .Item("nactdis"))
                lEntidad.nctacob = IIf(.Item("nctacob") Is DBNull.Value, Nothing, .Item("nctacob"))
                lEntidad.ninvent = IIf(.Item("ninvent") Is DBNull.Value, Nothing, .Item("ninvent"))
                lEntidad.nactfij = IIf(.Item("nactfij") Is DBNull.Value, Nothing, .Item("nactfij"))
                lEntidad.nprovee = IIf(.Item("nprovee") Is DBNull.Value, Nothing, .Item("nprovee"))
                lEntidad.notrpre = IIf(.Item("notrpre") Is DBNull.Value, Nothing, .Item("notrpre"))
                lEntidad.ncreins = IIf(.Item("ncreins") Is DBNull.Value, Nothing, .Item("ncreins"))
                lEntidad.nventas = IIf(.Item("nventas") Is DBNull.Value, Nothing, .Item("nventas"))
                lEntidad.nrecupe = IIf(.Item("nrecupe") Is DBNull.Value, Nothing, .Item("nrecupe"))
                lEntidad.nmercad = IIf(.Item("nmercad") Is DBNull.Value, Nothing, .Item("nmercad"))
                lEntidad.notregr = IIf(.Item("notregr") Is DBNull.Value, Nothing, .Item("notregr"))
                lEntidad.nemplea = IIf(.Item("nemplea") Is DBNull.Value, Nothing, .Item("nemplea"))
                lEntidad.nsueldo = IIf(.Item("nsueldo") Is DBNull.Value, Nothing, .Item("nsueldo"))
                lEntidad.npagpres = IIf(.Item("npagpres") Is DBNull.Value, Nothing, .Item("npagpres"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.notring = IIf(.Item("notring") Is DBNull.Value, Nothing, .Item("notring"))
                lEntidad.nimpues = IIf(.Item("nimpues") Is DBNull.Value, Nothing, .Item("nimpues"))
                lEntidad.nimprev = IIf(.Item("nimprev") Is DBNull.Value, Nothing, .Item("nimprev"))
                lEntidad.notract = IIf(.Item("notract") Is DBNull.Value, Nothing, .Item("notract"))
                lEntidad.nmarseg = IIf(.Item("nmarseg") Is DBNull.Value, Nothing, .Item("nmarseg"))

            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As clidbal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(devalua),0) + 1 ")
        strSQL.Append(" FROM clidbal ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodfue = @ccodfue ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodfue

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    'Public Function ObtenerListaPorID(ccodcli As String, ccodfue As String) As listaclidbal

    '    Dim strSQL As New StringBuilder
    '    SelectTabla(strSQL)
    '    strSQL.Append(" WHERE ccodcli = @ccodcli ") 
    '    strSQL.Append(" AND ccodfue = @ccodfue ") 

    '    Dim args(1) As SqlParameter
    '    args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
    '    args(0).Value = ccodcli
    '    args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
    '    args(1).Value = ccodfue

    '    Dim dr As SqlDataReader

    '    dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    '    Dim lista As New Listaclidbal

    '    Try
    '        Do While dr.Read()
    '            Dim mEntidad As New clidbal
    '            mEntidad.ccodcli = ccodcli
    '            mEntidad.ccodfue = ccodfue
    '            mEntidad.devalua = IIf(dr("devalua") Is DBNull.Value, Nothing, dr("devalua"))
    '            mEntidad.dbalanc = IIf(dr("dbalanc") Is DBNull.Value, Nothing, dr("dbalanc"))
    '            mEntidad.nactdis = IIf(dr("nactdis") Is DBNull.Value, Nothing, dr("nactdis"))
    '            mEntidad.nctacob = IIf(dr("nctacob") Is DBNull.Value, Nothing, dr("nctacob"))
    '            mEntidad.ninvent = IIf(dr("ninvent") Is DBNull.Value, Nothing, dr("ninvent"))
    '            mEntidad.nactfij = IIf(dr("nactfij") Is DBNull.Value, Nothing, dr("nactfij"))
    '            mEntidad.nprovee = IIf(dr("nprovee") Is DBNull.Value, Nothing, dr("nprovee"))
    '            mEntidad.notrpre = IIf(dr("notrpre") Is DBNull.Value, Nothing, dr("notrpre"))
    '            mEntidad.ncreins = IIf(dr("ncreins") Is DBNull.Value, Nothing, dr("ncreins"))
    '            mEntidad.nventas = IIf(dr("nventas") Is DBNull.Value, Nothing, dr("nventas"))
    '            mEntidad.nrecupe = IIf(dr("nrecupe") Is DBNull.Value, Nothing, dr("nrecupe"))
    '            mEntidad.nmercad = IIf(dr("nmercad") Is DBNull.Value, Nothing, dr("nmercad"))
    '            mEntidad.notregr = IIf(dr("notregr") Is DBNull.Value, Nothing, dr("notregr"))
    '            mEntidad.nemplea = IIf(dr("nemplea") Is DBNull.Value, Nothing, dr("nemplea"))
    '            mEntidad.nsueldo = IIf(dr("nsueldo") Is DBNull.Value, Nothing, dr("nsueldo"))
    '            mEntidad.npagpres = IIf(dr("npagpres") Is DBNull.Value, Nothing, dr("npagpres"))
    '            mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
    '            mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
    '            mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
    '            mEntidad.notring = IIf(dr("notring") Is DBNull.Value, Nothing, dr("notring"))
    '            mEntidad.nimpues = IIf(dr("nimpues") Is DBNull.Value, Nothing, dr("nimpues"))
    '            mEntidad.nimprev = IIf(dr("nimprev") Is DBNull.Value, Nothing, dr("nimprev"))
    '            mEntidad.notract = IIf(dr("notract") Is DBNull.Value, Nothing, dr("notract"))
    '            mEntidad.nmarseg = IIf(dr("nmarseg") Is DBNull.Value, Nothing, dr("nmarseg"))
    '            lista.Add(mEntidad)
    '        Loop
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        dr.Close()
    '    End Try

    '    Return lista

    'End Function
    Public Function ObtenerListaPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal devalua As Date) As listaclidbal

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodfue = @ccodfue ")
        strSQL.Append(" AND devalua = @devalua ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(1).Value = ccodfue
        args(2) = New SqlParameter("@devalua", SqlDbType.DateTime)
        args(2).Value = devalua

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaclidbal

        Try
            Do While dr.Read()
                Dim mEntidad As New clidbal
                mEntidad.ccodcli = ccodcli
                mEntidad.ccodfue = ccodfue
                mEntidad.devalua = devalua
                mEntidad.dbalanc = IIf(dr("dbalanc") Is DBNull.Value, Nothing, dr("dbalanc"))
                mEntidad.nactdis = IIf(dr("nactdis") Is DBNull.Value, 0, dr("nactdis"))
                mEntidad.nctacob = IIf(dr("nctacob") Is DBNull.Value, 0, dr("nctacob"))
                mEntidad.ninvent = IIf(dr("ninvent") Is DBNull.Value, 0, dr("ninvent"))
                mEntidad.nactfij = IIf(dr("nactfij") Is DBNull.Value, 0, dr("nactfij"))
                mEntidad.nprovee = IIf(dr("nprovee") Is DBNull.Value, 0, dr("nprovee"))
                mEntidad.notrpre = IIf(dr("notrpre") Is DBNull.Value, 0, dr("notrpre"))
                mEntidad.ncreins = IIf(dr("ncreins") Is DBNull.Value, 0, dr("ncreins"))
                mEntidad.nventas = IIf(dr("nventas") Is DBNull.Value, 0, dr("nventas"))
                mEntidad.nrecupe = IIf(dr("nrecupe") Is DBNull.Value, 0, dr("nrecupe"))
                mEntidad.nmercad = IIf(dr("nmercad") Is DBNull.Value, 0, dr("nmercad"))
                mEntidad.notregr = IIf(dr("notregr") Is DBNull.Value, 0, dr("notregr"))
                mEntidad.nemplea = IIf(dr("nemplea") Is DBNull.Value, 0, dr("nemplea"))
                mEntidad.nsueldo = IIf(dr("nsueldo") Is DBNull.Value, 0, dr("nsueldo"))
                mEntidad.npagpres = IIf(dr("npagpres") Is DBNull.Value, 0, dr("npagpres"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.notring = IIf(dr("notring") Is DBNull.Value, 0, dr("notring"))
                mEntidad.nimpues = IIf(dr("nimpues") Is DBNull.Value, 0, dr("nimpues"))
                mEntidad.nimprev = IIf(dr("nimprev") Is DBNull.Value, 0, dr("nimprev"))
                mEntidad.notract = IIf(dr("notract") Is DBNull.Value, 0, dr("notract"))
                mEntidad.nmarseg = IIf(dr("nmarseg") Is DBNull.Value, 0, dr("nmarseg"))
                mEntidad.ndinefe = IIf(dr("ndinefe") Is DBNull.Value, 0, dr("ndinefe"))
                mEntidad.ndinban = IIf(dr("ndinban") Is DBNull.Value, 0, dr("ndinban"))
                mEntidad.nbienesinm = IIf(dr("nbienesinm") Is DBNull.Value, 0, dr("nbienesinm"))
                mEntidad.nbienesens = IIf(dr("nbienesens") Is DBNull.Value, 0, dr("nbienesens"))
                mEntidad.nvehiculos = IIf(dr("nvehiculos") Is DBNull.Value, 0, dr("nvehiculos"))
                mEntidad.nganado = IIf(dr("nganado") Is DBNull.Value, 0, dr("nganado"))
                mEntidad.notrosbienes = IIf(dr("notrosbienes") Is DBNull.Value, 0, dr("notrosbienes"))
                mEntidad.noblbancos = IIf(dr("noblbancos") Is DBNull.Value, 0, dr("noblbancos"))
                mEntidad.noblens = IIf(dr("noblens") Is DBNull.Value, 0, dr("noblens"))
                mEntidad.ntienyalm = IIf(dr("ntienyalm") Is DBNull.Value, 0, dr("ntienyalm"))
                mEntidad.noblgasfam = IIf(dr("noblgasfam") Is DBNull.Value, 0, dr("noblgasfam"))
                mEntidad.notrosObl = IIf(dr("notrosobl") Is DBNull.Value, 0, dr("notrosobl"))
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

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        'strSQL.Append(" SELECT ccodcli, ")
        'strSQL.Append(" ccodfue, ")
        'strSQL.Append(" devalua, ")
        'strSQL.Append(" dbalanc, ")
        'strSQL.Append(" nactdis, ")
        'strSQL.Append(" nctacob, ")
        'strSQL.Append(" ninvent, ")
        'strSQL.Append(" nactfij, ")
        'strSQL.Append(" nprovee, ")
        'strSQL.Append(" notrpre, ")
        'strSQL.Append(" ncreins, ")
        'strSQL.Append(" nventas, ")
        'strSQL.Append(" nrecupe, ")
        'strSQL.Append(" nmercad, ")
        'strSQL.Append(" notregr, ")
        'strSQL.Append(" nemplea, ")
        'strSQL.Append(" nsueldo, ")
        'strSQL.Append(" npagpres, ")
        'strSQL.Append(" ccodusu, ")
        'strSQL.Append(" dfecmod, ")
        'strSQL.Append(" cflag, ")
        'strSQL.Append(" notring, ")
        'strSQL.Append(" nimpues, ")
        'strSQL.Append(" nimprev, ")
        'strSQL.Append(" notract, ")
        'strSQL.Append(" ntotact, ")
        'strSQL.Append(" (nactdis+nctacob+ninvent) as nactcir, ")
        'strSQL.Append(" ntotpas, ")
        'strSQL.Append(" npatri, ")
        'strSQL.Append(" ngasfam, ")
        'strSQL.Append(" ningfam, ")
        'strSQL.Append(" ntoting, ")
        'strSQL.Append(" ntotegre, ")
        'strSQL.Append(" nrotinv, ")
        'strSQL.Append(" ninddeu, ")
        'strSQL.Append(" nmarbru, ")
        'strSQL.Append(" ventas, ")
        'strSQL.Append(" ncaptra, ")
        'strSQL.Append(" nliquid, ")
        'strSQL.Append(" nrenneg, ")
        'strSQL.Append(" nrotcic, ")
        'strSQL.Append(" ncicope, ")
        'strSQL.Append(" npunequ, ")
        'strSQL.Append(" nmarseg, ")
        'strSQL.Append(" ndisfam, ndinefe ")
        strSQL.Append("select  *  FROM clidbal ")

    End Sub


    Public Function ObtenercCodFue(ByVal ccodcli As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(ccodfue)+1 as ccodfue")
        strSQL.Append(" FROM Clidbal ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("ccodfue")) Then
                lccodgar = "01"
            Else
                lccodgar = ds.Tables(0).Rows(0)("ccodfue")
                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 2 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = "01"
        End If



        Return lccodgar

    End Function
    ' este dataset lo ocupa el balance de situacion fiananciera que sale en datos sugeridos
    Public Function ObtenerDataSetPorID(ByVal ccodcli As String, ByVal ccodfue As String, ByVal lningfam As Double, ByVal lngasfam As Double, ByVal devalua As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodfue = @ccodfue ")
        strSQL.Append(" AND devalua = @devalua ")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)
        args(2) = New SqlParameter("@devalua", devalua)

        Dim ds As DataSet

        Dim lccodcli As String
        Dim lccodfue As String
        Dim ldevalua As Date

        Dim lnvalor As Double
        Dim lntotal As Double

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        'calcula el balance

        If ds.Tables(0).Rows.Count > 0 Then

            ldevalua = ds.Tables(0).Rows(0)("devalua")
            'calculos
            ds.Tables(0).Rows(0)("ntotact") = ds.Tables(0).Rows(0)("nactdis") + ds.Tables(0).Rows(0)("nctacob") + ds.Tables(0).Rows(0)("ninvent") + ds.Tables(0).Rows(0)("nactfij") + ds.Tables(0).Rows(0)("notract")
            ds.Tables(0).Rows(0)("nactcir") = ds.Tables(0).Rows(0)("nactdis") + ds.Tables(0).Rows(0)("nctacob")
            ds.Tables(0).Rows(0)("ntotpas") = ds.Tables(0).Rows(0)("nprovee") + ds.Tables(0).Rows(0)("notrpre") + ds.Tables(0).Rows(0)("ncreins")
            'patrimonio
            ds.Tables(0).Rows(0)("npatri") = ds.Tables(0).Rows(0)("ntotact") - ds.Tables(0).Rows(0)("ntotpas")
            'obtiene de la clidifa los ingresos familiares
            ds.Tables(0).Rows(0)("ngasfam") = lngasfam
            ds.Tables(0).Rows(0)("ningfam") = lningfam


            ds.Tables(0).Rows(0)("ntoting") = ds.Tables(0).Rows(0)("ningfam") + ds.Tables(0).Rows(0)("nventas") + ds.Tables(0).Rows(0)("nrecupe") + ds.Tables(0).Rows(0)("notring")
            ds.Tables(0).Rows(0)("ntotegre") = ds.Tables(0).Rows(0)("ngasfam") + ds.Tables(0).Rows(0)("nmercad") + ds.Tables(0).Rows(0)("notregr") + ds.Tables(0).Rows(0)("npagpres") + ds.Tables(0).Rows(0)("nimpues")


            If ds.Tables(0).Rows(0)("nventas") > 0 Then
                ds.Tables(0).Rows(0)("nrotinv") = ds.Tables(0).Rows(0)("nmercad") / ds.Tables(0).Rows(0)("nventas")
            Else
                ds.Tables(0).Rows(0)("nrotinv") = 0
            End If
            If ds.Tables(0).Rows(0)("ntotact") - ds.Tables(0).Rows(0)("notract") > 0 Then
                ds.Tables(0).Rows(0)("ninddeu") = ds.Tables(0).Rows(0)("ntotpas") / ((ds.Tables(0).Rows(0)("ntotact") - ds.Tables(0).Rows(0)("notract")))
            Else
                ds.Tables(0).Rows(0)("ninddeu") = 0
            End If
            If (ds.Tables(0).Rows(0)("nventas") + ds.Tables(0).Rows(0)("nrecupe")) > 0 Then
                ds.Tables(0).Rows(0)("nmarbru") = ((ds.Tables(0).Rows(0)("nventas") + ds.Tables(0).Rows(0)("nrecupe")) - ds.Tables(0).Rows(0)("nmercad")) / (ds.Tables(0).Rows(0)("nventas") + ds.Tables(0).Rows(0)("nrecupe"))
            Else
                ds.Tables(0).Rows(0)("nmarbru") = 0
            End If
            ds.Tables(0).Rows(0)("ncaptra") = (ds.Tables(0).Rows(0)("nactdis") + ds.Tables(0).Rows(0)("nctacob") + ds.Tables(0).Rows(0)("ninvent")) - (ds.Tables(0).Rows(0)("nprovee") + ds.Tables(0).Rows(0)("notrpre"))

            lnvalor = (ds.Tables(0).Rows(0)("nprovee") + ds.Tables(0).Rows(0)("notrpre"))
            If lnvalor = 0 Then
                ds.Tables(0).Rows(0)("nliquid") = 0
            Else
                ds.Tables(0).Rows(0)("nliquid") = (ds.Tables(0).Rows(0)("nactdis") + ds.Tables(0).Rows(0)("nctacob") + ds.Tables(0).Rows(0)("ninvent")) / lnvalor
            End If

            lnvalor = ds.Tables(0).Rows(0)("nventas")
            If lnvalor = 0 Then
                ds.Tables(0).Rows(0)("nrenneg") = 0
            Else
                ds.Tables(0).Rows(0)("nrenneg") = ds.Tables(0).Rows(0)("notregr") / ds.Tables(0).Rows(0)("nventas")
            End If
            'rotacion de ciclo
            If (ds.Tables(0).Rows(0)("nprovee") + ds.Tables(0).Rows(0)("notrpre")) > 0 Then
                lnvalor = (ds.Tables(0).Rows(0)("nventas"))
                If lnvalor = 0 Then
                    lntotal = 0
                Else
                    lntotal = ds.Tables(0).Rows(0)("nctacob") / lnvalor
                End If
                ds.Tables(0).Rows(0)("nrotcic") = ((lntotal) * (ds.Tables(0).Rows(0)("nactdis") + ds.Tables(0).Rows(0)("nctacob") + ds.Tables(0).Rows(0)("ninvent"))) / (ds.Tables(0).Rows(0)("nprovee") + ds.Tables(0).Rows(0)("notrpre"))
            Else
                ds.Tables(0).Rows(0)("nrotcic") = 0
            End If

            If ds.Tables(0).Rows(0)("nventas") > 0 Then
                lnvalor = (ds.Tables(0).Rows(0)("nctacob") / ds.Tables(0).Rows(0)("nventas"))
            Else
                lnvalor = 0
            End If

            If ds.Tables(0).Rows(0)("ninvent") > 0 Then
                lntotal = (ds.Tables(0).Rows(0)("nmercad") / ds.Tables(0).Rows(0)("ninvent"))
            Else
                lntotal = 0
            End If

            'calcula ciclo operacional
            Dim lncobven As Double
            Dim lndispoctas As Double
            Dim lnproveecost1 As Double
            Dim lnproveecost2 As Double
            If ds.Tables(0).Rows(0)("nventas") = 0 Then
                lncobven = 0
            Else
                lncobven = ds.Tables(0).Rows(0)("nctacob") / ds.Tables(0).Rows(0)("nventas")
            End If

            lndispoctas = ds.Tables(0).Rows(0)("nactdis") + ds.Tables(0).Rows(0)("nctacob") + ds.Tables(0).Rows(0)("ninvent")
            If ds.Tables(0).Rows(0)("ninvent") > 0 Then
                lnproveecost2 = ds.Tables(0).Rows(0)("nmercad") / ds.Tables(0).Rows(0)("ninvent")
            Else
                lnproveecost2 = 0
            End If
            lnproveecost1 = (ds.Tables(0).Rows(0)("nprovee") + ds.Tables(0).Rows(0)("notrpre")) + (lnproveecost2)

            ds.Tables(0).Rows(0)("ncicope") = lnproveecost1

            If ds.Tables(0).Rows(0)("nventas") > 0 Then
                lnvalor = ((ds.Tables(0).Rows(0)("nventas") - ds.Tables(0).Rows(0)("nmercad")) / ds.Tables(0).Rows(0)("nventas"))
            Else
                lnvalor = 0
            End If
            ds.Tables(0).Rows(0)("npunequ") = (ds.Tables(0).Rows(0)("notregr") + ds.Tables(0).Rows(0)("npagpres") + ds.Tables(0).Rows(0)("ngasfam") + lnvalor)

            'calcula el margen de seguridad
            Dim lnpaotrpag As Double
            Dim lnactdis As Double
            Dim lnventascost As Double

            lnactdis = ds.Tables(0).Rows(0)("nactdis")
            lnpaotrpag = ds.Tables(0).Rows(0)("notregr") + ds.Tables(0).Rows(0)("npagpres") + ds.Tables(0).Rows(0)("ngasfam")
            If ds.Tables(0).Rows(0)("nventas") > 0 Then
                lnventascost = ((ds.Tables(0).Rows(0)("nventas") - ds.Tables(0).Rows(0)("nmercad")) / ds.Tables(0).Rows(0)("nventas")) * 100
            Else
                lnventascost = 0
            End If

            ds.Tables(0).Rows(0)("nmarseg") = 0

            If lnventascost > 0 And lnactdis > 0 Then
                ds.Tables(0).Rows(0)("nmarseg") = ((lnactdis - ((lnpaotrpag / lnventascost))) / lnactdis) * 100
            Else
                If lnactdis <= 0 Then
                    ds.Tables(0).Rows(0)("nmarseg") = 0
                Else
                    If lnventascost <= 0 Then
                        ds.Tables(0).Rows(0)("nmarseg") = ((lnactdis) / lnactdis) * 100
                    End If
                End If

            End If

            'disponibilidad familiar
            ds.Tables(0).Rows(0)("ndisfam") = ds.Tables(0).Rows(0)("ntoting") - ds.Tables(0).Rows(0)("ntotegre")
            If ds.Tables(0).Rows(0)("ndisfam") < 0 Then
                ds.Tables(0).Rows(0)("ndisfam") = 0
            End If


            ' ds.Tables(0).Rows(0)("nmarseg") = ((ds.Tables(0).Rows(0)("nactdis") - ((ds.Tables(0).Rows(0)("notregr") + ds.Tables(0).Rows(0)("npagpres") + ds.Tables(0).Rows(0)("ngasfam")) / (ds.Tables(0).Rows(0)("nventas") - ds.Tables(0).Rows(0)("nmercad")) / ds.Tables(0).Rows(0)("nventas")) * 100)) * 100

        Else


        End If


        'fin calculo del balance



        Return ds

    End Function

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
    Public Function ObtenerDataSetPorIDMultiple(ByVal ccodcli As String, ByVal ccodfue As String, ByVal lningfam As Double, ByVal lngasfam As Double, ByVal devalua As Date) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodfue = @ccodfue ")

        strSQL.Append(" order by devalua desc ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodfue", ccodfue)
        args(2) = New SqlParameter("@devalua", devalua)

        Dim ds As New DataSet

        Dim lccodcli As String
        Dim lccodfue As String
        Dim ldevalua As Date

        Dim lnvalor As Double
        Dim lntotal As Double
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        'calcula el balance
        'calcula ciclo operacional
        Dim lncobven As Double
        Dim lndispoctas As Double
        Dim lnproveecost1 As Double
        Dim lnproveecost2 As Double

        'calcula el margen de seguridad
        Dim lnpaotrpag As Double
        Dim lnactdis As Double
        Dim lnventascost As Double

        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim i As Integer
            For Each fila In ds.Tables(0).Rows
                ldevalua = ds.Tables(0).Rows(i)("devalua")
                If IsDBNull(fila("notract")) Then
                    fila("notract") = 0
                End If
                If IsDBNull(fila("nactdis")) Then
                    fila("nactdis") = 0
                End If
                If IsDBNull(fila("nctacob")) Then
                    fila("nctacob") = 0
                End If
                If IsDBNull(fila("ninvent")) Then
                    fila("ninvent") = 0
                End If
                If IsDBNull(fila("nactfij")) Then
                    fila("nactfij") = 0
                End If
                If IsDBNull(fila("nventas")) Then
                    fila("nventas") = 0
                End If
                If IsDBNull(fila("nrecupe")) Then
                    fila("nrecupe") = 0
                End If
                If IsDBNull(fila("notring")) Then
                    fila("notring") = 0
                End If
                If IsDBNull(fila("nmercad")) Then
                    fila("nmercad") = 0
                End If
                If IsDBNull(fila("notregr")) Then
                    fila("notregr") = 0
                End If
                If IsDBNull(fila("npagpres")) Then
                    fila("npagpres") = 0
                End If
                If IsDBNull(fila("npagpres")) Then
                    fila("npagpres") = 0
                End If
                If IsDBNull(fila("nimpues")) Then
                    fila("nimpues") = 0
                End If
                'calculos
                ds.Tables(0).Rows(i)("ntotact") = ds.Tables(0).Rows(i)("nactdis") + ds.Tables(0).Rows(i)("nctacob") + ds.Tables(0).Rows(i)("ninvent") + ds.Tables(0).Rows(i)("nactfij") + ds.Tables(0).Rows(i)("notract")
                ds.Tables(0).Rows(i)("nactcir") = ds.Tables(0).Rows(i)("nactdis") + ds.Tables(0).Rows(i)("nctacob") + ds.Tables(0).Rows(i)("ninvent")
                ds.Tables(0).Rows(i)("ntotpas") = ds.Tables(0).Rows(i)("nprovee") + ds.Tables(0).Rows(i)("notrpre") + ds.Tables(0).Rows(i)("ncreins")
                'patrimonio
                ds.Tables(0).Rows(i)("npatri") = ds.Tables(0).Rows(i)("ntotact") - ds.Tables(0).Rows(i)("ntotpas")
                'obtiene de la clidifa los ingresos familiares
                ds.Tables(0).Rows(i)("ngasfam") = lngasfam
                ds.Tables(0).Rows(i)("ningfam") = lningfam
                ds.Tables(0).Rows(i)("ntoting") = ds.Tables(0).Rows(i)("ningfam") + ds.Tables(0).Rows(i)("nventas") + ds.Tables(0).Rows(i)("nrecupe") + ds.Tables(0).Rows(i)("notring")
                ds.Tables(0).Rows(i)("ntotegre") = ds.Tables(0).Rows(i)("ngasfam") + ds.Tables(0).Rows(i)("nmercad") + ds.Tables(0).Rows(i)("notregr") + ds.Tables(0).Rows(i)("npagpres") + ds.Tables(0).Rows(i)("nimpues")
                If ds.Tables(0).Rows(i)("nventas") > 0 Then
                    ds.Tables(0).Rows(i)("nrotinv") = ds.Tables(0).Rows(i)("nmercad") / ds.Tables(0).Rows(i)("nventas")
                Else
                    ds.Tables(0).Rows(i)("nrotinv") = 0
                End If
                If ds.Tables(0).Rows(i)("ntotact") - ds.Tables(0).Rows(i)("notract") > 0 Then
                    ds.Tables(0).Rows(i)("ninddeu") = ds.Tables(0).Rows(i)("ntotpas") / ((ds.Tables(0).Rows(i)("ntotact") - ds.Tables(0).Rows(i)("notract")))
                Else
                    ds.Tables(0).Rows(i)("ninddeu") = 0
                End If
                If (ds.Tables(0).Rows(i)("nventas") + ds.Tables(0).Rows(i)("nrecupe")) > 0 Then
                    ds.Tables(0).Rows(i)("nmarbru") = ((ds.Tables(0).Rows(i)("nventas") + ds.Tables(0).Rows(i)("nrecupe")) - ds.Tables(0).Rows(i)("nmercad")) / (ds.Tables(0).Rows(i)("nventas") + ds.Tables(0).Rows(i)("nrecupe"))
                Else
                    ds.Tables(0).Rows(i)("nmarbru") = 0
                End If
                ds.Tables(0).Rows(i)("ncaptra") = (ds.Tables(0).Rows(i)("nactdis") + ds.Tables(0).Rows(i)("nctacob") + ds.Tables(0).Rows(i)("ninvent")) - (ds.Tables(0).Rows(i)("nprovee") + ds.Tables(0).Rows(i)("notrpre"))

                lnvalor = (ds.Tables(0).Rows(i)("nprovee") + ds.Tables(0).Rows(i)("notrpre"))
                If lnvalor = 0 Then
                    ds.Tables(0).Rows(i)("nliquid") = 0
                Else
                    ds.Tables(0).Rows(i)("nliquid") = (ds.Tables(0).Rows(i)("nactdis") + ds.Tables(0).Rows(i)("nctacob") + ds.Tables(0).Rows(i)("ninvent")) / lnvalor
                End If
                lnvalor = ds.Tables(0).Rows(i)("nventas")
                If lnvalor = 0 Then
                    ds.Tables(0).Rows(i)("nrenneg") = 0
                Else
                    ds.Tables(0).Rows(i)("nrenneg") = ds.Tables(0).Rows(i)("notregr") / ds.Tables(0).Rows(i)("nventas")
                End If
                'rotacion de ciclo
                If (ds.Tables(0).Rows(i)("nprovee") + ds.Tables(0).Rows(i)("notrpre")) > 0 Then
                    lnvalor = (ds.Tables(0).Rows(i)("nventas"))
                    If lnvalor = 0 Then
                        lntotal = 0
                    Else
                        lntotal = ds.Tables(0).Rows(i)("nctacob") / lnvalor
                    End If

                    ds.Tables(0).Rows(i)("nrotcic") = ((lntotal) * (ds.Tables(0).Rows(i)("nactdis") + ds.Tables(0).Rows(i)("nctacob") + ds.Tables(0).Rows(i)("ninvent"))) / (ds.Tables(0).Rows(i)("nprovee") + ds.Tables(0).Rows(i)("notrpre"))
                Else
                    ds.Tables(0).Rows(i)("nrotcic") = 0
                End If

                If ds.Tables(0).Rows(i)("nventas") > 0 Then
                    lnvalor = (ds.Tables(0).Rows(i)("nctacob") / ds.Tables(0).Rows(i)("nventas"))
                Else
                    lnvalor = 0
                End If

                If ds.Tables(0).Rows(i)("ninvent") > 0 Then
                    lntotal = (ds.Tables(0).Rows(i)("nmercad") / ds.Tables(0).Rows(i)("ninvent"))
                Else
                    lntotal = 0
                End If

                If ds.Tables(0).Rows(i)("nventas") = 0 Then
                    lncobven = 0
                Else
                    lncobven = ds.Tables(0).Rows(i)("nctacob") / ds.Tables(0).Rows(i)("nventas")
                End If

                lndispoctas = ds.Tables(0).Rows(i)("nactdis") + ds.Tables(0).Rows(i)("nctacob") + ds.Tables(0).Rows(i)("ninvent")
                If ds.Tables(0).Rows(i)("ninvent") > 0 Then
                    lnproveecost2 = ds.Tables(0).Rows(i)("nmercad") / ds.Tables(0).Rows(i)("ninvent")
                Else
                    lnproveecost2 = 0
                End If
                lnproveecost1 = (ds.Tables(0).Rows(i)("nprovee") + ds.Tables(0).Rows(i)("notrpre")) + (lnproveecost2)

                ds.Tables(0).Rows(i)("ncicope") = lnproveecost1

                If ds.Tables(0).Rows(i)("nventas") > 0 Then
                    lnvalor = ((ds.Tables(0).Rows(i)("nventas") - ds.Tables(0).Rows(i)("nmercad")) / ds.Tables(0).Rows(i)("nventas"))
                Else
                    lnvalor = 0
                End If
                ds.Tables(0).Rows(i)("npunequ") = (ds.Tables(0).Rows(i)("notregr") + ds.Tables(0).Rows(i)("npagpres") + ds.Tables(0).Rows(i)("ngasfam") + lnvalor)

                lnactdis = ds.Tables(0).Rows(i)("nactdis")
                lnpaotrpag = ds.Tables(0).Rows(i)("notregr") + ds.Tables(0).Rows(i)("npagpres") + ds.Tables(0).Rows(i)("ngasfam")
                If ds.Tables(0).Rows(i)("nventas") > 0 Then
                    lnventascost = ((ds.Tables(0).Rows(i)("nventas") - ds.Tables(0).Rows(i)("nmercad")) / ds.Tables(0).Rows(i)("nventas")) * 100
                Else
                    lnventascost = 0
                End If

                ds.Tables(0).Rows(i)("nmarseg") = 0

                If lnventascost > 0 And lnactdis > 0 Then
                    ds.Tables(0).Rows(i)("nmarseg") = ((lnactdis - ((lnpaotrpag / lnventascost))) / lnactdis) * 100
                Else
                    If lnactdis <= 0 Then
                        ds.Tables(0).Rows(i)("nmarseg") = 0
                    Else
                        If lnventascost <= 0 Then
                            ds.Tables(0).Rows(i)("nmarseg") = ((lnactdis) / lnactdis) * 100
                        End If
                    End If

                End If
                'disponibilidad familiar
                ds.Tables(0).Rows(i)("ndisfam") = ds.Tables(0).Rows(i)("ntoting") - ds.Tables(0).Rows(i)("ntotegre")
                If ds.Tables(0).Rows(i)("ndisfam") < 0 Then
                    ds.Tables(0).Rows(i)("ndisfam") = 0
                End If

                i += 1
            Next
        Else
        End If
        'fin calculo del balance
        Return ds

    End Function

End Class
