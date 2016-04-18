Imports System.Text
Public Class dbAhomint
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomint
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.nnum =  0 _
            Or lEntidad.nnum = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.nnum = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomint ")
        strSQL.Append(" SET cnrolin = @cnrolin, ") 
        strSQL.Append(" nombre = @nombre, ") 
        strSQL.Append(" cnudotr = @cnudotr, ") 
        strSQL.Append(" ccodaho = @ccodaho, ") 
        strSQL.Append(" nmonapr = @nmonapr, ") 
        strSQL.Append(" nplazo = @nplazo, ") 
        strSQL.Append(" nintere = @nintere, ") 
        strSQL.Append(" dfecapr = @dfecapr, ") 
        strSQL.Append(" dfecven = @dfecven, ") 
        strSQL.Append(" dfecprv = @dfecprv, ") 
        strSQL.Append(" dfecori = @dfecori, ") 
        strSQL.Append(" dfecliq = @dfecliq, ") 
        strSQL.Append(" ndiagra = @ndiagra, ") 
        strSQL.Append(" ccalint = @ccalint, ") 
        strSQL.Append(" cprvint = @cprvint, ") 
        strSQL.Append(" ccodbco = @ccodbco, ") 
        strSQL.Append(" cctacte = @cctacte, ") 
        strSQL.Append(" ccapita = @ccapita, ") 
        strSQL.Append(" cpignor = @cpignor, ") 
        strSQL.Append(" ccodcta = @ccodcta, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" cprovis = @cprovis, ") 
        strSQL.Append(" cliq = @cliq, ") 
        strSQL.Append(" nsaldoaho = @nsaldoaho, ") 
        strSQL.Append(" nmonotr = @nmonotr, ") 
        strSQL.Append(" dfeccap = @dfeccap, ") 
        strSQL.Append(" ccodcli = @ccodcli, ") 
        strSQL.Append(" cpig = @cpig, ") 
        strSQL.Append(" producto = @producto, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" dfecmod2 = @dfecmod2, ") 
        strSQL.Append(" ntasint = @ntasint, ") 
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ") 
        strSQL.Append(" AND dfecpro = @dfecpro ") 
        strSQL.Append(" AND nnum = @nnum ") 

        Dim args(36) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(2) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnudotr
        args(3) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodaho
        args(4) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmonapr
        args(5) = New SqlParameter("@nplazo", SqlDbType.Decimal)
        args(5).Value = lEntidad.nplazo
        args(6) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(6).Value = lEntidad.nintere
        args(7) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(7).Value = lEntidad.dfecapr
        args(8) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfecven
        args(9) = New SqlParameter("@dfecprv", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecprv
        args(10) = New SqlParameter("@dfecori", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecori
        args(11) = New SqlParameter("@dfecliq", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecliq
        args(12) = New SqlParameter("@ndiagra", SqlDbType.Decimal)
        args(12).Value = lEntidad.ndiagra
        args(13) = New SqlParameter("@ccalint", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccalint
        args(14) = New SqlParameter("@cprvint", SqlDbType.VarChar)
        args(14).Value = lEntidad.cprvint
        args(15) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccodbco
        args(16) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(16).Value = lEntidad.cctacte
        args(17) = New SqlParameter("@ccapita", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccapita
        args(18) = New SqlParameter("@cpignor", SqlDbType.VarChar)
        args(18).Value = lEntidad.cpignor
        args(19) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodcta
        args(20) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(20).Value = lEntidad.dfecmod
        args(21) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccodusu
        args(22) = New SqlParameter("@cprovis", SqlDbType.VarChar)
        args(22).Value = lEntidad.cprovis
        args(23) = New SqlParameter("@cliq", SqlDbType.VarChar)
        args(23).Value = lEntidad.cliq
        args(24) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(24).Value = lEntidad.nsaldoaho
        args(25) = New SqlParameter("@nmonotr", SqlDbType.Decimal)
        args(25).Value = lEntidad.nmonotr
        args(26) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(26).Value = lEntidad.dfeccap
        args(27) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(27).Value = lEntidad.ccodcli
        args(28) = New SqlParameter("@cpig", SqlDbType.VarChar)
        args(28).Value = lEntidad.cpig
        args(29) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(29).Value = lEntidad.producto
        args(30) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(30).Value = lEntidad.cestado
        args(31) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(31).Value = lEntidad.cflag
        args(32) = New SqlParameter("@dfecmod2", SqlDbType.Datetime)
        args(32).Value = lEntidad.dfecmod2
        args(33) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(33).Value = lEntidad.ntasint
        args(34) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(34).Value = IIf(lEntidad.ccodcrt = Nothing, DBNull.Value,lEntidad.ccodcrt)
        args(35) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(35).Value = IIf(lEntidad.dfecpro = Nothing, DBNull.Value,lEntidad.dfecpro)
        args(36) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(36).Value = IIf(lEntidad.nnum = Nothing, DBNull.Value,lEntidad.nnum)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomint
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomint ")
        strSQL.Append(" ( ccodcrt, ") 
        strSQL.Append(" cnrolin, ") 
        strSQL.Append(" nombre, ") 
        strSQL.Append(" cnudotr, ") 
        strSQL.Append(" ccodaho, ") 
        strSQL.Append(" nmonapr, ") 
        strSQL.Append(" nplazo, ") 
        strSQL.Append(" nintere, ") 
        strSQL.Append(" dfecapr, ") 
        strSQL.Append(" dfecven, ") 
        strSQL.Append(" dfecprv, ") 
        strSQL.Append(" dfecori, ") 
        strSQL.Append(" dfecliq, ") 
        strSQL.Append(" ndiagra, ") 
        strSQL.Append(" ccalint, ") 
        strSQL.Append(" cprvint, ") 
        strSQL.Append(" ccodbco, ") 
        strSQL.Append(" cctacte, ") 
        strSQL.Append(" ccapita, ") 
        strSQL.Append(" cpignor, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" cprovis, ") 
        strSQL.Append(" cliq, ") 
        strSQL.Append(" nsaldoaho, ") 
        strSQL.Append(" nmonotr, ") 
        strSQL.Append(" dfeccap, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" cpig, ") 
        strSQL.Append(" producto, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" dfecpro, ") 
        strSQL.Append(" dfecmod2, ")
        strSQL.Append(" ntasint, ") 
        strSQL.Append(" nnum) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcrt, ") 
        strSQL.Append(" @cnrolin, ") 
        strSQL.Append(" @nombre, ") 
        strSQL.Append(" @cnudotr, ") 
        strSQL.Append(" @ccodaho, ") 
        strSQL.Append(" @nmonapr, ") 
        strSQL.Append(" @nplazo, ") 
        strSQL.Append(" @nintere, ") 
        strSQL.Append(" @dfecapr, ") 
        strSQL.Append(" @dfecven, ") 
        strSQL.Append(" @dfecprv, ") 
        strSQL.Append(" @dfecori, ") 
        strSQL.Append(" @dfecliq, ") 
        strSQL.Append(" @ndiagra, ") 
        strSQL.Append(" @ccalint, ") 
        strSQL.Append(" @cprvint, ") 
        strSQL.Append(" @ccodbco, ") 
        strSQL.Append(" @cctacte, ") 
        strSQL.Append(" @ccapita, ") 
        strSQL.Append(" @cpignor, ") 
        strSQL.Append(" @ccodcta, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @cprovis, ") 
        strSQL.Append(" @cliq, ") 
        strSQL.Append(" @nsaldoaho, ") 
        strSQL.Append(" @nmonotr, ") 
        strSQL.Append(" @dfeccap, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @cpig, ") 
        strSQL.Append(" @producto, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @dfecpro, ") 
        strSQL.Append(" @dfecmod2, ")
        strSQL.Append(" @ntasint, ") 
        strSQL.Append(" @nnum) ")

        Dim args(36) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcrt = Nothing, DBNull.Value, lEntidad.ccodcrt)
        args(1) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrolin
        args(2) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(3) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnudotr
        args(4) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodaho
        args(5) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(5).Value = lEntidad.nmonapr
        args(6) = New SqlParameter("@nplazo", SqlDbType.Decimal)
        args(6).Value = lEntidad.nplazo
        args(7) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(7).Value = lEntidad.nintere
        args(8) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfecapr
        args(9) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecven
        args(10) = New SqlParameter("@dfecprv", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecprv
        args(11) = New SqlParameter("@dfecori", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecori
        args(12) = New SqlParameter("@dfecliq", SqlDbType.Datetime)
        args(12).Value = lEntidad.dfecliq
        args(13) = New SqlParameter("@ndiagra", SqlDbType.Decimal)
        args(13).Value = lEntidad.ndiagra
        args(14) = New SqlParameter("@ccalint", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccalint
        args(15) = New SqlParameter("@cprvint", SqlDbType.VarChar)
        args(15).Value = lEntidad.cprvint
        args(16) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(16).Value = lEntidad.ccodbco
        args(17) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(17).Value = lEntidad.cctacte
        args(18) = New SqlParameter("@ccapita", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccapita
        args(19) = New SqlParameter("@cpignor", SqlDbType.VarChar)
        args(19).Value = lEntidad.cpignor
        args(20) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(20).Value = lEntidad.ccodcta
        args(21) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(21).Value = lEntidad.dfecmod
        args(22) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(22).Value = lEntidad.ccodusu
        args(23) = New SqlParameter("@cprovis", SqlDbType.VarChar)
        args(23).Value = lEntidad.cprovis
        args(24) = New SqlParameter("@cliq", SqlDbType.VarChar)
        args(24).Value = lEntidad.cliq
        args(25) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(25).Value = lEntidad.nsaldoaho
        args(26) = New SqlParameter("@nmonotr", SqlDbType.Decimal)
        args(26).Value = lEntidad.nmonotr
        args(27) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(27).Value = lEntidad.dfeccap
        args(28) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(28).Value = lEntidad.ccodcli
        args(29) = New SqlParameter("@cpig", SqlDbType.VarChar)
        args(29).Value = lEntidad.cpig
        args(30) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(30).Value = lEntidad.producto
        args(31) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(31).Value = lEntidad.cestado
        args(32) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(32).Value = lEntidad.cflag
        args(33) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(33).Value = IIf(lEntidad.dfecpro = Nothing, DBNull.Value, lEntidad.dfecpro)
        args(34) = New SqlParameter("@dfecmod2", SqlDbType.Datetime)
        args(34).Value = lEntidad.dfecmod2
        args(35) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(35).Value = lEntidad.ntasint
        args(36) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(36).Value = IIf(lEntidad.nnum = Nothing, DBNull.Value, lEntidad.nnum)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomint
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomint ")
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ") 
        strSQL.Append(" AND dfecpro = @dfecpro ") 
        strSQL.Append(" AND nnum = @nnum ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcrt
        args(1) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecpro
        args(2) = New SqlParameter("@nnum", SqlDbType.VarChar)
        args(2).Value = lEntidad.nnum

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomint
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ") 
        strSQL.Append(" AND dfecpro = @dfecpro ") 
        strSQL.Append(" AND nnum = @nnum ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcrt
        args(1) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecpro
        args(2) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(2).Value = lEntidad.nnum

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnrolin = IIf(.Item("cnrolin") Is DBNull.Value, Nothing, .Item("cnrolin"))
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.cnudotr = IIf(.Item("cnudotr") Is DBNull.Value, Nothing, .Item("cnudotr"))
                lEntidad.ccodaho = IIf(.Item("ccodaho") Is DBNull.Value, Nothing, .Item("ccodaho"))
                lEntidad.nmonapr = IIf(.Item("nmonapr") Is DBNull.Value, Nothing, .Item("nmonapr"))
                lEntidad.nplazo = IIf(.Item("nplazo") Is DBNull.Value, Nothing, .Item("nplazo"))
                lEntidad.nintere = IIf(.Item("nintere") Is DBNull.Value, Nothing, .Item("nintere"))
                lEntidad.dfecapr = IIf(.Item("dfecapr") Is DBNull.Value, Nothing, .Item("dfecapr"))
                lEntidad.dfecven = IIf(.Item("dfecven") Is DBNull.Value, Nothing, .Item("dfecven"))
                lEntidad.dfecprv = IIf(.Item("dfecprv") Is DBNull.Value, Nothing, .Item("dfecprv"))
                lEntidad.dfecori = IIf(.Item("dfecori") Is DBNull.Value, Nothing, .Item("dfecori"))
                lEntidad.dfecliq = IIf(.Item("dfecliq") Is DBNull.Value, Nothing, .Item("dfecliq"))
                lEntidad.ndiagra = IIf(.Item("ndiagra") Is DBNull.Value, Nothing, .Item("ndiagra"))
                lEntidad.ccalint = IIf(.Item("ccalint") Is DBNull.Value, Nothing, .Item("ccalint"))
                lEntidad.cprvint = IIf(.Item("cprvint") Is DBNull.Value, Nothing, .Item("cprvint"))
                lEntidad.ccodbco = IIf(.Item("ccodbco") Is DBNull.Value, Nothing, .Item("ccodbco"))
                lEntidad.cctacte = IIf(.Item("cctacte") Is DBNull.Value, Nothing, .Item("cctacte"))
                lEntidad.ccapita = IIf(.Item("ccapita") Is DBNull.Value, Nothing, .Item("ccapita"))
                lEntidad.cpignor = IIf(.Item("cpignor") Is DBNull.Value, Nothing, .Item("cpignor"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.cprovis = IIf(.Item("cprovis") Is DBNull.Value, Nothing, .Item("cprovis"))
                lEntidad.cliq = IIf(.Item("cliq") Is DBNull.Value, Nothing, .Item("cliq"))
                lEntidad.nsaldoaho = IIf(.Item("nsaldoaho") Is DBNull.Value, Nothing, .Item("nsaldoaho"))
                lEntidad.nmonotr = IIf(.Item("nmonotr") Is DBNull.Value, Nothing, .Item("nmonotr"))
                lEntidad.dfeccap = IIf(.Item("dfeccap") Is DBNull.Value, Nothing, .Item("dfeccap"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.cpig = IIf(.Item("cpig") Is DBNull.Value, Nothing, .Item("cpig"))
                lEntidad.producto = IIf(.Item("producto") Is DBNull.Value, Nothing, .Item("producto"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.dfecmod2 = IIf(.Item("dfecmod2") Is DBNull.Value, Nothing, .Item("dfecmod2"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomint
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(nnum),0) + 1 ")
        strSQL.Append(" FROM ahomint ")
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ") 
        strSQL.Append(" AND dfecpro = @dfecpro ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcrt
        args(1) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecpro

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Function ObtenerListaPorID(ByVal ccodcrt As String, ByVal dfecpro As DateTime) As listaahomint

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ")
        strSQL.Append(" AND dfecpro = @dfecpro ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = ccodcrt
        args(1) = New SqlParameter("@dfecpro", SqlDbType.DateTime)
        args(1).Value = dfecpro

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaahomint

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomint
                mEntidad.ccodcrt = ccodcrt
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.ccodaho = IIf(dr("ccodaho") Is DBNull.Value, Nothing, dr("ccodaho"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nplazo = IIf(dr("nplazo") Is DBNull.Value, Nothing, dr("nplazo"))
                mEntidad.nintere = IIf(dr("nintere") Is DBNull.Value, Nothing, dr("nintere"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.dfecprv = IIf(dr("dfecprv") Is DBNull.Value, Nothing, dr("dfecprv"))
                mEntidad.dfecori = IIf(dr("dfecori") Is DBNull.Value, Nothing, dr("dfecori"))
                mEntidad.dfecliq = IIf(dr("dfecliq") Is DBNull.Value, Nothing, dr("dfecliq"))
                mEntidad.ndiagra = IIf(dr("ndiagra") Is DBNull.Value, Nothing, dr("ndiagra"))
                mEntidad.ccalint = IIf(dr("ccalint") Is DBNull.Value, Nothing, dr("ccalint"))
                mEntidad.cprvint = IIf(dr("cprvint") Is DBNull.Value, Nothing, dr("cprvint"))
                mEntidad.ccodbco = IIf(dr("ccodbco") Is DBNull.Value, Nothing, dr("ccodbco"))
                mEntidad.cctacte = IIf(dr("cctacte") Is DBNull.Value, Nothing, dr("cctacte"))
                mEntidad.ccapita = IIf(dr("ccapita") Is DBNull.Value, Nothing, dr("ccapita"))
                mEntidad.cpignor = IIf(dr("cpignor") Is DBNull.Value, Nothing, dr("cpignor"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cprovis = IIf(dr("cprovis") Is DBNull.Value, Nothing, dr("cprovis"))
                mEntidad.cliq = IIf(dr("cliq") Is DBNull.Value, Nothing, dr("cliq"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.nmonotr = IIf(dr("nmonotr") Is DBNull.Value, Nothing, dr("nmonotr"))
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.cpig = IIf(dr("cpig") Is DBNull.Value, Nothing, dr("cpig"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.dfecpro = dfecpro
                mEntidad.dfecmod2 = IIf(dr("dfecmod2") Is DBNull.Value, Nothing, dr("dfecmod2"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.nnum = IIf(dr("nnum") Is DBNull.Value, Nothing, dr("nnum"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function






    Public Function ObtenerDataSetPorID(ByVal ccodcrt As String, ByVal dfecpro As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ")
        strSQL.Append(" AND dfecpro = @dfecpro ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", ccodcrt)
        args(1) = New SqlParameter("@dfecpro", dfecpro)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function



    Public Function ObtenerDataSetPorfecha(ByVal dfecpro As DateTime) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfecpro = @dfecpro ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@dfecpro", dfecpro)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    Public Function ObtenerDataSetPorID(ByVal ccodcrt As String, ByVal dfecpro As DateTime, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ")
        strSQL.Append(" AND dfecpro = @dfecpro ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", ccodcrt)
        args(1) = New SqlParameter("@dfecpro", dfecpro)

        Dim tables(0) As String
        tables(0) = New String("ahomint")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcrt, ")
        strSQL.Append(" cnrolin, ")
        strSQL.Append(" nombre, ")
        strSQL.Append(" cnudotr, ")
        strSQL.Append(" ccodaho, ")
        strSQL.Append(" nmonapr, ")
        strSQL.Append(" nplazo, ")
        strSQL.Append(" nintere, ")
        strSQL.Append(" dfecapr, ")
        strSQL.Append(" dfecven, ")
        strSQL.Append(" dfecprv, ")
        strSQL.Append(" dfecori, ")
        strSQL.Append(" dfecliq, ")
        strSQL.Append(" ndiagra, ")
        strSQL.Append(" ccalint, ")
        strSQL.Append(" cprvint, ")
        strSQL.Append(" ccodbco, ")
        strSQL.Append(" cctacte, ")
        strSQL.Append(" ccapita, ")
        strSQL.Append(" cpignor, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" cprovis, ")
        strSQL.Append(" cliq, ")
        strSQL.Append(" nsaldoaho, ")
        strSQL.Append(" nmonotr, ")
        strSQL.Append(" dfeccap, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" cpig, ")
        strSQL.Append(" producto, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" dfecpro, ")
        strSQL.Append(" dfecmod2, ")
        strSQL.Append(" ntasint, ")
        strSQL.Append(" nnum ")
        strSQL.Append(" FROM ahomint ")

    End Sub

End Class
