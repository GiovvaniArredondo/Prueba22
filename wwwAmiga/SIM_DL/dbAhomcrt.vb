Imports System.Text
Public Class dbAhomcrt
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcrt
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcrt =  "" _
            Or lEntidad.ccodcrt = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcrt = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomcrt ")
        strSQL.Append(" SET cnrolin = @cnrolin, ") 
        strSQL.Append(" nombre = @nombre, ") 
        strSQL.Append(" cnudotr = @cnudotr, ") 
        strSQL.Append(" ccodaho = @ccodaho, ") 
        strSQL.Append(" nmonapr = @nmonapr, ") 
        strSQL.Append(" ntasint = @ntasint, ") 
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
        strSQL.Append(" dfeccap = @dfeccap, ") 
        strSQL.Append(" ccodcli = @ccodcli, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" producto = @producto, ") 
        strSQL.Append(" dmenpro = @dmenpro, ") 
        strSQL.Append(" dultpro = @dultpro, ")
        strSQL.Append(" producto2 = @producto2, ") 
        strSQL.Append(" nmonto2 = @nmonto2 ")
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ") 

        Dim args(34) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(1).Value = lEntidad.nombre
        args(2) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnudotr
        args(3) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodaho
        args(4) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmonapr
        args(5) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(5).Value = lEntidad.ntasint
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
        args(26) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(26).Value = lEntidad.dfeccap
        args(27) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(27).Value = lEntidad.ccodcli
        args(28) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(28).Value = lEntidad.cestado
        args(29) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(29).Value = lEntidad.producto
        args(30) = New SqlParameter("@dmenpro", SqlDbType.Datetime)
        args(30).Value = lEntidad.dmenpro
        args(31) = New SqlParameter("@dultpro", SqlDbType.Datetime)
        args(31).Value = lEntidad.dultpro
        args(32) = New SqlParameter("@producto2", SqlDbType.VarChar)
        args(32).Value = lEntidad.producto2
        args(33) = New SqlParameter("@nmonto2", SqlDbType.Decimal)
        args(33).Value = lEntidad.nmonto2
        args(34) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(34).Value = IIf(lEntidad.ccodcrt = Nothing, DBNull.Value,lEntidad.ccodcrt)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcrt
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomcrt ")
        strSQL.Append(" ( ccodcrt, ") 
        strSQL.Append(" cnrolin, ") 
        strSQL.Append(" nombre, ") 
        strSQL.Append(" cnudotr, ") 
        strSQL.Append(" ccodaho, ") 
        strSQL.Append(" nmonapr, ") 
        strSQL.Append(" ntasint, ") 
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
        strSQL.Append(" dfeccap, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" producto, ") 
        strSQL.Append(" dmenpro, ") 
        strSQL.Append(" dultpro, ")
        strSQL.Append(" producto2, ") 
        strSQL.Append(" nmonto2) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcrt, ") 
        strSQL.Append(" @cnrolin, ") 
        strSQL.Append(" @nombre, ") 
        strSQL.Append(" @cnudotr, ") 
        strSQL.Append(" @ccodaho, ") 
        strSQL.Append(" @nmonapr, ") 
        strSQL.Append(" @ntasint, ") 
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
        strSQL.Append(" @dfeccap, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @producto, ") 
        strSQL.Append(" @dmenpro, ") 
        strSQL.Append(" @dultpro, ")
        strSQL.Append(" @producto2, ") 
        strSQL.Append(" @nmonto2) ")

        Dim args(34) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcrt = Nothing, DBNull.Value, lEntidad.ccodcrt)
        args(1) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrolin
        args(2) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(2).Value = lEntidad.nombre
        args(3) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnudotr
        args(4) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodaho
        args(5) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(5).Value = lEntidad.nmonapr
        args(6) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(6).Value = lEntidad.ntasint
        args(7) = New SqlParameter("@nplazo", SqlDbType.Decimal)
        args(7).Value = lEntidad.nplazo
        args(8) = New SqlParameter("@nintere", SqlDbType.Decimal)
        args(8).Value = lEntidad.nintere
        args(9) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecapr
        args(10) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecven
        args(11) = New SqlParameter("@dfecprv", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecprv
        args(12) = New SqlParameter("@dfecori", SqlDbType.Datetime)
        args(12).Value = lEntidad.dfecori
        args(13) = New SqlParameter("@dfecliq", SqlDbType.Datetime)
        args(13).Value = lEntidad.dfecliq
        args(14) = New SqlParameter("@ndiagra", SqlDbType.Decimal)
        args(14).Value = lEntidad.ndiagra
        args(15) = New SqlParameter("@ccalint", SqlDbType.VarChar)
        args(15).Value = lEntidad.ccalint
        args(16) = New SqlParameter("@cprvint", SqlDbType.VarChar)
        args(16).Value = lEntidad.cprvint
        args(17) = New SqlParameter("@ccodbco", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodbco
        args(18) = New SqlParameter("@cctacte", SqlDbType.VarChar)
        args(18).Value = lEntidad.cctacte
        args(19) = New SqlParameter("@ccapita", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccapita
        args(20) = New SqlParameter("@cpignor", SqlDbType.VarChar)
        args(20).Value = lEntidad.cpignor
        args(21) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccodcta
        args(22) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(22).Value = lEntidad.dfecmod
        args(23) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccodusu
        args(24) = New SqlParameter("@cprovis", SqlDbType.VarChar)
        args(24).Value = lEntidad.cprovis
        args(25) = New SqlParameter("@cliq", SqlDbType.VarChar)
        args(25).Value = lEntidad.cliq
        args(26) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(26).Value = lEntidad.nsaldoaho
        args(27) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(27).Value = lEntidad.dfeccap
        args(28) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(28).Value = lEntidad.ccodcli
        args(29) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(29).Value = lEntidad.cestado
        args(30) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(30).Value = lEntidad.producto
        args(31) = New SqlParameter("@dmenpro", SqlDbType.Datetime)
        args(31).Value = lEntidad.dmenpro
        args(32) = New SqlParameter("@dultpro", SqlDbType.Datetime)
        args(32).Value = lEntidad.dultpro
        args(33) = New SqlParameter("@producto2", SqlDbType.VarChar)
        args(33).Value = lEntidad.producto2
        args(34) = New SqlParameter("@nmonto2", SqlDbType.Decimal)
        args(34).Value = lEntidad.nmonto2

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcrt
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomcrt ")
        strSQL.Append(" WHERE ccodcrt = @ccodcrt ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcrt

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function


    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcrt
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE ahomcrt.ccodcli = CLIMIDE.ccodcli and ")
        strSQL.Append(" ahomcrt.ccodcrt = @ccodcrt ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcrt

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
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
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
                lEntidad.dfeccap = IIf(.Item("dfeccap") Is DBNull.Value, Nothing, .Item("dfeccap"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.producto = IIf(.Item("producto") Is DBNull.Value, Nothing, .Item("producto"))
                lEntidad.dmenpro = IIf(.Item("dmenpro") Is DBNull.Value, Nothing, .Item("dmenpro"))
                lEntidad.dultpro = IIf(.Item("dultpro") Is DBNull.Value, Nothing, .Item("dultpro"))
                lEntidad.producto2 = IIf(.Item("producto2") Is DBNull.Value, Nothing, .Item("producto2"))
                lEntidad.nmonto2 = IIf(.Item("nmonto2") Is DBNull.Value, Nothing, .Item("nmonto2"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomcrt
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcrt),0) + 1 ")
        strSQL.Append(" FROM ahomcrt ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function


    Public Function ObtenerListaPorID() As listaahomcrt

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaahomcrt

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomcrt
                mEntidad.ccodcrt = IIf(dr("ccodcrt") Is DBNull.Value, Nothing, dr("ccodcrt"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.ccodaho = IIf(dr("ccodaho") Is DBNull.Value, Nothing, dr("ccodaho"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
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
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.dmenpro = IIf(dr("dmenpro") Is DBNull.Value, Nothing, dr("dmenpro"))
                mEntidad.dultpro = IIf(dr("dultpro") Is DBNull.Value, Nothing, dr("dultpro"))
                mEntidad.producto2 = IIf(dr("producto2") Is DBNull.Value, Nothing, dr("producto2"))
                mEntidad.nmonto2 = IIf(dr("nmonto2") Is DBNull.Value, Nothing, dr("nmonto2"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorID2() As listaahomcrt

        Dim strSQL As New StringBuilder
        SelectTabla2(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaahomcrt

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomcrt
                mEntidad.ccodcrt = IIf(dr("ccodcrt") Is DBNull.Value, Nothing, dr("ccodcrt"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.ccodaho = IIf(dr("ccodaho") Is DBNull.Value, Nothing, dr("ccodaho"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
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
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.dmenpro = IIf(dr("dmenpro") Is DBNull.Value, Nothing, dr("dmenpro"))
                mEntidad.dultpro = IIf(dr("dultpro") Is DBNull.Value, Nothing, dr("dultpro"))
                mEntidad.producto2 = IIf(dr("producto2") Is DBNull.Value, Nothing, dr("producto2"))
                mEntidad.nmonto2 = IIf(dr("nmonto2") Is DBNull.Value, Nothing, dr("nmonto2"))
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
        tables(0) = New String("ahomcrt")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ahomcrt.ccodcrt, ")
        strSQL.Append(" ahomcrt.cnrolin, ")
        strSQL.Append(" climide.cnomcli as nombre, ")
        strSQL.Append(" ahomcrt.cnudotr, ")
        strSQL.Append(" ahomcrt.ccodaho, ")
        strSQL.Append(" ahomcrt.nmonapr, ")
        strSQL.Append(" ahomcrt.ntasint, ")
        strSQL.Append(" ahomcrt.nplazo, ")
        strSQL.Append(" ahomcrt.nintere, ")
        strSQL.Append(" ahomcrt.dfecapr, ")
        strSQL.Append(" ahomcrt.dfecven, ")
        strSQL.Append(" ahomcrt.dfecprv, ")
        strSQL.Append(" ahomcrt.dfecori, ")
        strSQL.Append(" ahomcrt.dfecliq, ")
        strSQL.Append(" ahomcrt.ndiagra, ")
        strSQL.Append(" ahomcrt.ccalint, ")
        strSQL.Append(" ahomcrt.cprvint, ")
        strSQL.Append(" ahomcrt.ccodbco, ")
        strSQL.Append(" ahomcrt.cctacte, ")
        strSQL.Append(" ahomcrt.ccapita, ")
        strSQL.Append(" ahomcrt.cpignor, ")
        strSQL.Append(" ahomcrt.ccodcta, ")
        strSQL.Append(" ahomcrt.dfecmod, ")
        strSQL.Append(" ahomcrt.ccodusu, ")
        strSQL.Append(" ahomcrt.cprovis, ")
        strSQL.Append(" ahomcrt.cliq, ")
        strSQL.Append(" ahomcrt.nsaldoaho, ")
        strSQL.Append(" ahomcrt.dfeccap, ")
        strSQL.Append(" ahomcrt.ccodcli, ")
        strSQL.Append(" ahomcrt.cestado, ")
        strSQL.Append(" ahomcrt.producto, ")
        strSQL.Append(" ahomcrt.dmenpro, ")
        strSQL.Append(" ahomcrt.dultpro, ")
        strSQL.Append(" ahomcrt.producto2, ")
        strSQL.Append(" ahomcrt.nmonto2 ")
        strSQL.Append(" FROM ahomcrt, climide ")

    End Sub


    Private Sub SelectTabla2(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ahomcrt.ccodcrt, ")
        strSQL.Append(" ahomcrt.cnrolin, ")
        strSQL.Append(" ahomcrt.nombre, ")
        strSQL.Append(" ahomcrt.cnudotr, ")
        strSQL.Append(" ahomcrt.ccodaho, ")
        strSQL.Append(" ahomcrt.nmonapr, ")
        strSQL.Append(" ahomcrt.ntasint, ")
        strSQL.Append(" ahomcrt.nplazo, ")
        strSQL.Append(" ahomcrt.nintere, ")
        strSQL.Append(" ahomcrt.dfecapr, ")
        strSQL.Append(" ahomcrt.dfecven, ")
        strSQL.Append(" ahomcrt.dfecprv, ")
        strSQL.Append(" ahomcrt.dfecori, ")
        strSQL.Append(" ahomcrt.dfecliq, ")
        strSQL.Append(" ahomcrt.ndiagra, ")
        strSQL.Append(" ahomcrt.ccalint, ")
        strSQL.Append(" ahomcrt.cprvint, ")
        strSQL.Append(" ahomcrt.ccodbco, ")
        strSQL.Append(" ahomcrt.cctacte, ")
        strSQL.Append(" ahomcrt.ccapita, ")
        strSQL.Append(" ahomcrt.cpignor, ")
        strSQL.Append(" ahomcrt.ccodcta, ")
        strSQL.Append(" ahomcrt.dfecmod, ")
        strSQL.Append(" ahomcrt.ccodusu, ")
        strSQL.Append(" ahomcrt.cprovis, ")
        strSQL.Append(" ahomcrt.cliq, ")
        strSQL.Append(" ahomcrt.nsaldoaho, ")
        strSQL.Append(" ahomcrt.dfeccap, ")
        strSQL.Append(" ahomcrt.ccodcli, ")
        strSQL.Append(" ahomcrt.cestado, ")
        strSQL.Append(" ahomcrt.producto, ")
        strSQL.Append(" ahomcrt.dmenpro, ")
        strSQL.Append(" ahomcrt.dultpro, ")
        strSQL.Append(" ahomcrt.producto2, ")
        strSQL.Append(" ahomcrt.nmonto2 ")
        strSQL.Append(" FROM ahomcrt")

    End Sub




    'obtiene certificados por certificado
    Public Function ObtenerDataSetporcertificado(ByVal cnombre As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ahomcrt.ccodcrt, climide.cnomcli, ahomcrt.nmonapr, ahomcrt.ntasint, ahomcrt.nplazo, ahomcrt.ccodcrt as codigo ")
        strSQL.Append(" FROM ahomcrt, climide ")
        strSQL.Append(" where ahomcrt.ccodcli = climide.ccodcli and cnomcli like" & "'" & "%" & cnombre & "%" & "'")

        Dim ds As DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnombre", SqlDbType.VarChar)
        args(0).Value = cnombre

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function




    Public Function ObtenerDataSetporcodcertificado(ByVal ccodcrt As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ahomcrt.ccodcrt, climide.cnomcli, ahomcrt.nmonapr, ahomcrt.ntasint, ahomcrt.nplazo, ahomcrt.ccodcrt as codigo ")
        strSQL.Append(" FROM ahomcrt, climide ")
        strSQL.Append(" where ahomcrt.ccodcli = climide.ccodcli and ahomcrt.ccodcrt = @ccodcrt ")

        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = ccodcrt

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function Certificadosaplazoxcliente(ByVal ccodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodcrt AS no_plazo,  nombre, nmonapr AS cien, ")
        strSQL.Append("case when cpignor ='N' then (nmonapr * 0.90) else 0 end as noventa, ")
        strSQL.Append("dfecapr AS vigente, ntasint AS tasa, nplazo AS plazo_dias, cpignor AS pignorado ")
        strSQL.Append("FROM AHOMCRT where cnudotr = @ccodcli ")
        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtieneTasaPromedioAhorroPlazo(ByVal ccodcta As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("select AVG(ahomcrt.ntasint) as ntasint from crepgar, ahomcrt ")
        strSQL.Append("where crepgar.ccodcrt = ahomcrt.ccodcrt ")
        strSQL.Append("and crepgar.ccodcta = @ccodcta ")
        strSQL.Append("and crepgar.ctipgar ='05' ")

        Dim ds As New DataSet
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Dim lntasint As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ntasint")) Then
            Else
                lntasint = ds.Tables(0).Rows(0)("ntasint")
            End If
        End If
        Return lntasint
    End Function

    Public Function ObtenerCuentas(ByVal cCodcli As String, ByVal cliq As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ('Garantía a Plazo: '+ ccodaho+'_'+ccodcrt + ' monto: '+str(nmonapr)+' plazo: '+str(nplazo) ) as ccodigo, ")
        strSQL.Append("nmonapr, nombre, ahomcrt.ccodcrt as ccodaho, ahomcrt.cpignor, ahomcrt.ccodaho as ccodaho1 ")
        strSQL.Append("FROM AHOMCRT ")
        strSQL.Append("WHERE cnudotr = @ccodcli ")

        If cliq.Trim = "" Then
        Else
            strSQL.Append(" and cliq = @cliq ")
        End If


        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        args(1) = New SqlParameter("@cliq", SqlDbType.VarChar)
        args(1).Value = cliq

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    Public Function ObtenerCuentas_(ByVal cCodcli As String, ByVal cliq As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ('Garantía a Plazo: '+ ccodaho+'_'+ccodcrt + ' monto: '+str(nmonapr)+' plazo: '+str(nplazo) ) as ccodigo, ")
        strSQL.Append("nmonapr, nombre, ahomcrt.ccodcrt as ccodaho, ahomcrt.cpignor, ahomcrt.ccodaho as ccodaho1 ")
        strSQL.Append("FROM AHOMCRT ")
        strSQL.Append("WHERE cnudotr = @ccodcli ")

        If cliq.Trim = "" Then
        Else
            strSQL.Append(" and cEstado = @cliq ")
        End If


        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        args(1) = New SqlParameter("@cliq", SqlDbType.VarChar)
        args(1).Value = cliq

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtieneCuentadeAhorrodeCertificado(ByVal cCodcrt As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodaho FROM AHOMCRT ")
        strSQL.Append("WHERE cCodcrt = @cCodcrt ")

        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = cCodcrt


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodaho As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodaho")) Then
            Else
                lccodaho = ds.Tables(0).Rows(0)("ccodaho")
            End If
        End If

        Return lccodaho
    End Function

    Public Function ObtieneMontodeAhorrodeCertificado(ByVal cCodcrt As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT nmonapr FROM AHOMCRT ")
        strSQL.Append("WHERE cCodcrt = @cCodcrt ")

        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = cCodcrt


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnmonapr As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonapr")) Then
            Else
                lnmonapr = ds.Tables(0).Rows(0)("nmonapr")
            End If
        End If

        Return lnmonapr
    End Function

    Public Function ObtieneClientedeAhorrodeCertificado(ByVal cCodcrt As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cnudotr FROM AHOMCRT ")
        strSQL.Append("WHERE cCodcrt = @cCodcrt ")

        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = cCodcrt


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodaho As String = ""
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnudotr")) Then
            Else
                lccodaho = ds.Tables(0).Rows(0)("cnudotr")
            End If
        End If

        Return lccodaho
    End Function

    Public Function ActualizaPignoracion(ByVal cCodcrt As String, ByVal cestado As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE AHOMCRT SET cpignor = @cestado WHERE cCodcrt = @cCodcrt ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@ccodcrt", SqlDbType.VarChar)
        args(0).Value = cCodcrt
        args(1) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(1).Value = cestado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function

    Public Function ObtieneDepositosxcuenta(ByVal ccodcli As String, ByVal dfecha As Date) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("select sum(nmonapr) as nmonto FROM AHOMCRT ")
        strSQL.Append("WHERE cnudotr = @ccodcli  and cliq <> 'S' group by ccodcli")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        args(1) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(1).Value = dfecha

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lnmonto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmonto")) Then
            Else
                lnmonto = ds.Tables(0).Rows(0)("nmonto")
            End If
        End If

        Return lnmonto
    End Function




    Public Function Carga_Desconectado_Proyeccion_cupones() As DataSet

        Try

            Dim rs As New DataSet, dr As DataRow
            Dim dat_AdCup As New DataTable("Cupones")
            dat_AdCup.Clear()
            dat_AdCup.Columns.Add("cnrocuo", Type.GetType("System.String"))
            dat_AdCup.Columns.Add("ndifdia", Type.GetType("System.Decimal"))
            dat_AdCup.Columns.Add("dfecven", Type.GetType("System.DateTime"))
            dat_AdCup.Columns.Add("cEstado", Type.GetType("System.String"))
            dat_AdCup.Columns.Add("cTipope", Type.GetType("System.String"))
            dat_AdCup.Columns.Add("nIntere", Type.GetType("System.Decimal"))
            dat_AdCup.Columns.Add("nIntereImp", Type.GetType("System.Decimal"))
            dat_AdCup.Columns.Add("nRenta", Type.GetType("System.Decimal"))
            dat_AdCup.Columns.Add("nTasaIn", Type.GetType("System.Decimal"))


            rs.Tables.Add(dat_AdCup)

            Return rs

        Catch ex As Exception

        End Try

    End Function


    Public Function CargaBeneficiarios() As DataSet

        Try

            Dim rs As New DataSet, dr As DataRow
            Dim dat_AdBen As New DataTable("Beneficiarios")
            dat_AdBen.Clear()
            dat_AdBen.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_AdBen.Columns.Add("cNomBen", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_AdBen.Columns.Add("cParent", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("cDirecc", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("nPorcen", Type.GetType("System.Decimal"))

            rs.Tables.Add(dat_AdBen)

            Return rs

        Catch ex As Exception

        End Try

    End Function

    Public Function Mantenimiento_Deposito_Plazo(ByVal Detalle_Cta As ArrayList, ByVal dt_ben As DataTable, _
                                                 ByVal dt_plan As DataTable) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Ofi As New DataSet
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcCtas_Plazo As String
        Dim ccrefun As New dbCntamov

        'Detalle_Cta.Item(0)   'Nombre del Titular
        'Detalle_Cta.Item(1)   'Codigo del Titular
        'Detalle_Cta.Item(2)   'Monto Certificado
        'Detalle_Cta.Item(3)   'Forma de Pago
        'Detalle_Cta.Item(4)   'Tasa pactada
        'Detalle_Cta.item(5)   'Frencuencia
        'Detalle_Cta.item(6)   'Plazo Días
        'Detalle_Cta.item(7)   'Plazo Meses
        'Detalle_Cta.item(8)   'Cta de Ahorro si Aplica 
        'Detalle_Cta.item(9)   'Total de Intereses al finalizar el plazo 
        'Detalle_Cta.item(10)  'Fecha de Emisión de Certificado  
        'Detalle_Cta.item(11)  'Fecha de vencimiento
        'Detalle_Cta.item(12)  'Procedencia de los fondos
        'Detalle_Cta.item(13)  'Ejecutivo
        'Detalle_Cta.item(14)  'Numero de Certificado
        'Detalle_Cta.item(15)  'Oficina
        'Detalle_Cta.item(16)  'Fecha de Modificación
        'Detalle_Cta.item(17)  'Usuario
        'Detalle_Cta.item(18)  'no linea de Ahorro
        'Detalle_Cta.item(19)  'Codigo de Cta Plazo



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try


                If Detalle_Cta.Item(19).ToString.Trim.Length = 0 Then 'Nuevo Certificado

                    command.CommandText = _
                                        " Select isnull(max(right(ccodcta_plazo,10))+1,1) as Contador From Ahomcrt " & _
                                        " Where cCodofi  ='" & Detalle_Cta.Item(15) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Ofi, "Ctas_Plazo")


                    For Each fila As DataRow In ds_Ofi.Tables("Ctas_Plazo").Rows
                        lcCtas_Plazo = fila("contador").ToString.Trim
                    Next

                    i = Double.Parse(lcCtas_Plazo)

                    lcCtas_Plazo = ccrefun.fxStrZero(i, 10)

                    lcCtas_Plazo = Detalle_Cta.Item(15) + "-" + lcCtas_Plazo


                    command.CommandText = _
                                            " Insert Into Ahomcrt (ccodcrt,cnrolin,nombre,cnudotr,ccodcta_plazo,ccodofi,ccodaho,nmonapr," & _
                                            " ntasint, nplazo, nintere, dfecapr, dfecven, dfecprv, dfecori, dfecliq, ndiagra, ccalint, " & _
                                            " cprvint,ccodbco,cctacte,ccapita,cpignor,ccodcta,dfecmod,ccodusu,cprovis,cliq,nsaldoaho,dfeccap," & _
                                            " ccodcli,cestado,producto,dmenpro,dultpro, producto2, nmonto2, cprocedencia, cformapag, cfrecuencia," & _
                                            " nmeses, ccodusu_prom)" & _
                                            " Values('" & Detalle_Cta.Item(14) & "','" & Detalle_Cta.Item(18) & "','" & Detalle_Cta.Item(0) & "','" & _
                                            Detalle_Cta.Item(1) & "','" & lcCtas_Plazo & "','" & Detalle_Cta.Item(15) & "','" & Detalle_Cta.Item(8) & "'," & _
                                            Detalle_Cta.Item(2) & "," & Detalle_Cta.Item(4) & "," & Detalle_Cta.Item(6) & "," & Detalle_Cta.Item(9) & ",'" & Detalle_Cta.Item(10) & "','" & _
                                            Detalle_Cta.Item(11) & "','" & Detalle_Cta.Item(10) & "','" & Detalle_Cta.Item(10) & "','" & Detalle_Cta.Item(11) & "'," & _
                                            "0,'','','','','','','','" & Detalle_Cta.Item(16) & "','" & Detalle_Cta.Item(17) & "','',''," & Detalle_Cta.Item(2) & ",'" & _
                                            Detalle_Cta.Item(11) & "','','I','07','" & Detalle_Cta.Item(10) & "','" & Detalle_Cta.Item(10) & "','',0,'" & _
                                            Detalle_Cta.Item(12) & "','" & Detalle_Cta.Item(3) & "','" & Detalle_Cta.Item(5) & "','" & _
                                            Detalle_Cta.Item(7) & "','" & Detalle_Cta.Item(13) & "')"


                    command.ExecuteNonQuery()

                Else                        'Actualiza Certificado

                    command.CommandText = _
                                            " Update Ahomcrt set cnrolin ='" & Detalle_Cta.Item(18) & "',nombre ='" & Detalle_Cta.Item(0) & "', cnudotr ='" & _
                                            Detalle_Cta.Item(1) & "', nmonapr =" & Detalle_Cta.Item(2) & ", ntasint =" & Detalle_Cta.Item(4) & ", nplazo =" & _
                                            Detalle_Cta.Item(6) & " , nintere =" & Detalle_Cta.Item(9) & " , dfecapr='" & Detalle_Cta.Item(10) & "', dfecven ='" & _
                                            Detalle_Cta.Item(11) & "', dfecprv ='" & Detalle_Cta.Item(10) & "', dfecori ='" & Detalle_Cta.Item(10) & "',dfecliq ='" & _
                                            Detalle_Cta.Item(11) & "', dfecmod ='" & Detalle_Cta.Item(16) & "', ccodusu='" & Detalle_Cta.Item(17) & "', nsaldoaho =" & _
                                            Detalle_Cta.Item(2) & ", dfeccap ='" & Detalle_Cta.Item(11) & "', dmenpro ='" & Detalle_Cta.Item(10) & "', dultpro='" & _
                                            Detalle_Cta.Item(10) & "', cprocedencia='" & Detalle_Cta.Item(10) & "', cformapag ='" & Detalle_Cta.Item(3) & "', cfrecuencia ='" & _
                                            Detalle_Cta.Item(5) & "', nmeses=" & Detalle_Cta.Item(7) & ", ccodusu_prom ='" & Detalle_Cta.Item(13) & "'" & _
                                            " Where ccodcrt ='" & Detalle_Cta.Item(14) & "'"

                    command.ExecuteNonQuery()
                End If


                'Comentariado no se usa en Copadeo
                ''Borra Cupones si Existen
                'command.CommandText = _
                '                         " Delete from Ahomppg " & _
                '                         " Where ccodcrt ='" & Detalle_Cta.Item(14) & "'"

                'command.ExecuteNonQuery()


                ''Inserta Cupones
                'For Each fila As DataRow In dt_plan.Rows

                '    command.CommandText = _
                '                            " Insert into Ahomppg (ccodcrt,dfecven,ndias,cestado,ctipope,cnrocuo,nmonto,nintere,nintere_imp," & _
                '                            " nimpuestos,ntasint,dfecmod,ccodusu) " & _
                '                            " Values('" & Detalle_Cta.Item(14) & "','" & fila("dfecven") & "'," & fila("ndifdia") & ",'" & _
                '                            fila("cEstado") & "','" & fila("cTipope") & "','" & fila("cnrocuo") & "'," & Detalle_Cta.Item(2) & "," & _
                '                            fila("nIntere") & "," & fila("nIntereImp") & "," & fila("nRenta") & "," & fila("nTasaIn") & ",'" & Detalle_Cta.Item(16) & "','" & _
                '                            Detalle_Cta.Item(17) & "')"

                '    command.ExecuteNonQuery()

                'Next


                'Borra Beneficiarios si Existen
                command.CommandText = _
                                        " Delete from Depmben " & _
                                        " Where ccodcrt ='" & Detalle_Cta.Item(14) & "'"

                command.ExecuteNonQuery()

                'Inserta Beneficiarios del Deposito
                For Each fila As DataRow In dt_ben.Rows
                    command.CommandText = _
                                            " Insert into Depmben (ccodcrt,ncorrel,cnomben,cparent,dfecnac,nporcen,cflag,dfecmod,ccodusu,cdirecc) " & _
                                            " values('" & Detalle_Cta.Item(14) & "'," & fila("IdCuenta") & ",'" & fila("cNomBen") & "','" & _
                                            fila("cParent") & "','" & fila("dnacimi") & "','" & fila("nPorcen") & "','','" & _
                                            Detalle_Cta.Item(16) & "','" & Detalle_Cta.Item(17) & "','" & fila("cdirecc") & "')"

                    command.ExecuteNonQuery()
                Next


                lnRetorno = 1
                Mytransaccion.Commit()

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
                Mytransaccion.Rollback()
            Finally
                connection.Close()
            End Try

        End Using


        Return lnRetorno

    End Function


    Public Function Elimina_Deposito_Plazo(ByVal Detalle_Cta As ArrayList) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Ofi As New DataSet
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcCtas_Plazo As String
        Dim ccrefun As New dbCntamov

        'Detalle_Cta.Item(0)   'Nombre del Titular
        'Detalle_Cta.Item(1)   'Codigo del Titular
        'Detalle_Cta.Item(2)   'Monto Certificado
        'Detalle_Cta.Item(3)   'Forma de Pago
        'Detalle_Cta.Item(4)   'Tasa pactada
        'Detalle_Cta.item(5)   'Frencuencia
        'Detalle_Cta.item(6)   'Plazo Días
        'Detalle_Cta.item(7)   'Plazo Meses
        'Detalle_Cta.item(8)   'Cta de Ahorro si Aplica 
        'Detalle_Cta.item(9)   'Total de Intereses al finalizar el plazo 
        'Detalle_Cta.item(10)  'Fecha de Emisión de Certificado  
        'Detalle_Cta.item(11)  'Fecha de vencimiento
        'Detalle_Cta.item(12)  'Procedencia de los fondos
        'Detalle_Cta.item(13)  'Ejecutivo
        'Detalle_Cta.item(14)  'Numero de Certificado
        'Detalle_Cta.item(15)  'Oficina
        'Detalle_Cta.item(16)  'Fecha de Modificación
        'Detalle_Cta.item(17)  'Usuario
        'Detalle_Cta.item(18)  'no linea de Ahorro
        'Detalle_Cta.item(19)  'Codigo de Cta Plazo



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try


                'Inserta Linea de Anulación
                command.CommandText = _
                                        " Insert into anulados (ccodcrt,cnrolin,nombre,cnudotr,ccodaho,nmonapr,nplazo,nintere,dfecapr," & _
                                        " dfecven, dfecprv,dfecori,dfecliq,ndiagra,ccalint,cprvint,ccodbco,cctacte,ccapita,cpignor,ccodcta," & _
                                        " dfecmod,ccodusu,cprovis,cliq,nsaldoaho,dfeccap,ccodcli,cestado,producto) " & _
                                        " Values('" & Detalle_Cta.Item(14) & "','" & Detalle_Cta.Item(18) & "','" & Detalle_Cta.Item(0) & "','" & _
                                        Detalle_Cta.Item(1) & "','" & Detalle_Cta.Item(8) & "'," & Detalle_Cta.Item(2) & "," & Detalle_Cta.Item(6) & ",0,'" & Detalle_Cta.Item(10) & "','" & _
                                        Detalle_Cta.Item(11) & "','" & Detalle_Cta.Item(10) & "','" & Detalle_Cta.Item(10) & "','" & Detalle_Cta.Item(10) & "',0,'','','','','','','','" & _
                                        Detalle_Cta.Item(16) & "','" & Detalle_Cta.Item(17) & "','','',0,'" & Detalle_Cta.Item(10) & "','','','07')"


                command.ExecuteNonQuery()



                'Borra Deposito de la Maestra
                command.CommandText = _
                                        " Delete from Ahomcrt " & _
                                        " Where ccodcrt ='" & Detalle_Cta.Item(14) & "'"

                command.ExecuteNonQuery()



                lnRetorno = 1
                Mytransaccion.Commit()

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
                Mytransaccion.Rollback()
            Finally
                connection.Close()
            End Try

        End Using


        Return lnRetorno

    End Function

    Public Function Extrae_Listado_Depositos(ByVal pcnumcom As String, _
                                             ByVal Tipo As Integer, ByVal pdfecini As Date, _
                                             ByVal pdfecfin As Date, ByVal pnValor As Double, _
                                             ByVal pcCodofi As String) As DataSet

        Dim ds As New DataSet
        Dim _sql As String = ""
        Dim lcfecini As String = pdfecini.ToString
        Dim lcfecfin As String = pdfecfin.ToString
        'Dim connection As Object = Conexion()
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        lcfecini = pdfecini
        lcfecfin = pdfecfin

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            command.Connection = connection

            Try



                _sql = _
                         " Select a.ccodcrt, ltrim(rtrim(b.cnomcli)) as cnomcli, a.nmonapr, a.dfecapr, a.dfecven, cEstado =" & _
                         " CASE cestado" & _
                         " WHEN 'A' THEN 'ACTIVO'" & _
                         " WHEN 'I' THEN 'INACTIVO'" & _
                         " WHEN 'P' THEN 'PIGNORADO'" & _
                         " WHEN 'C' THEN 'CANCELADO'" & _
                         " WHEN 'R' THEN 'RENOVADO'" & _
                         " ELSE 'OTROS'" & _
                         " End" & _
                         " From ahomcrt a" & _
                         " inner join climide b" & _
                         " on a.cnudotr = b.ccodcli "


                Select Case Tipo
                    Case 1      'Nombre del Socio

                        _sql = _sql + " where b.cnomcli like '%" & pcnumcom & "%'"

                    Case 2      'Filtrando Fechas

                        _sql = _sql + " Where a.dfecapr >= '" & lcfecini & "' and a.dfecapr <= '" & lcfecfin & "'"

                    Case 3      'Valor

                        _sql = _sql + " Where a.nmonapr =" & pnValor

                    Case 4      'No de Deposito

                        _sql = _sql + " where a.ccodcrt like '%" & pcnumcom & "%'"


                End Select


                '_sql = _sql + " and a.ccodofi = '" & pcCodofi & "'"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_Depo")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds

    End Function


    'Public Function Extrae_Datos_Depositos(ByVal pcCodcrt As String) As DataSet

    '    Dim ds As New DataSet
    '    Dim _sql As String = ""

    '    Dim MyAdapter As New SqlDataAdapter
    '    Dim command As New SqlCommand


    '    Using connection As New SqlConnection(Me.cnnStr)
    '        connection.Open()

    '        command.Connection = connection

    '        Try


    '            _sql = _
    '                     " Select c.ncorrel as IdCuenta, c.cNomBen, c.dfecnac as dnacimi, c.cParent, " & _
    '                     " isnull(c.cDirecc,'') as cDirecc, c.nporcen From ahomcrt a" & _
    '                     " inner join climide b" & _
    '                     " on a.cnudotr = b.ccodcli " & _
    '                     " inner join depmben c" & _
    '                     " on a.ccodcrt = c.ccodcrt" & _
    '                     " Where a.cCodcrt ='" & pcCodcrt & "'"


    '            command.CommandText = _sql

    '            command.CommandType = CommandType.Text

    '            MyAdapter.SelectCommand = command

    '            MyAdapter.Fill(ds, "List_Ben")


    '            _sql = _
    '                     " Select a.*, b.cnudoci, b.cclaper From ahomcrt a" & _
    '                     " inner join climide b" & _
    '                     " on a.cnudotr = b.ccodcli " & _
    '                     " Where cCodcrt ='" & pcCodcrt & "'"


    '            command.CommandText = _sql

    '            command.CommandType = CommandType.Text

    '            MyAdapter.SelectCommand = command

    '            MyAdapter.Fill(ds, "List_Depo")


    '            _sql = _
    '                     " Select c.* From ahomcrt a" & _
    '                     " inner join climide b" & _
    '                     " on a.cnudotr = b.ccodcli " & _
    '                     " inner join Ahomppg c" & _
    '                     " on a.ccodcrt = c.ccodcrt" & _
    '                     " Where a.cCodcrt ='" & pcCodcrt & "'"


    '            command.CommandText = _sql

    '            command.CommandType = CommandType.Text

    '            MyAdapter.SelectCommand = command

    '            MyAdapter.Fill(ds, "List_Cupo")


    '        Catch ex As Exception
    '            Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
    '            Console.WriteLine("  Message: {0}", ex.Message)
    '        Finally
    '            connection.Close()
    '        End Try

    '    End Using


    '    Return ds

    'End Function



    Public Function Actualiza_Certificado_Diario(ByVal Encabeza_Part() As String) As String


        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lcnumcom As String = "0"
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim occlass As New dbCntamov
        Dim lcCodcta_Aho As String = ""
        Dim lcCodcta_CJA As String = ""



        'Dim Datos_Cert() As String = {Date.Parse(Me.Txtdfeccnt.Text), Session("gccodofi"), _
        '                              concepto, "PA", Session("GDFECSIS"), _
        '                              Session("gcCodusu"), "", "", "", Double.Parse(Me.TxtnMonCert.Text), _
        '                              Me.TxtcCodcrt.Text.Trim, Me.Txtndias.Text.ToString, Me.TxtcCodPerson.Text.Trim}}



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try

                'Extrae Mascara de Ahorros
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '07'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho = fila("cCta1")
                Next

                'Extrae Plazo
                command.CommandText = _
                                        " Select ccodigo, cdescri from Tabttab " & _
                                        " Where ccodtab = '094' and ctipreg = '1'" & _
                                        " and nnumtab =" & Encabeza_Part(11)

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Plazo")

                ''2111PLCL01
                For Each fila As DataRow In ds.Tables("Plazo").Rows
                    lcCodcta_Aho = lcCodcta_Aho.Replace("PL", fila("ccodigo").ToString.Trim)

                    'Conviertiendo tipo de persona
                    lcCodcta_Aho = lcCodcta_Aho.Replace("CL", Encabeza_Part(12).ToString.Trim)
                    lcCodcta_Aho = lcCodcta_Aho.Trim
                Next


                'Extrae Cuenta Contable de Cajero
                command.CommandText = _
                                        " Select ccodcta from Tabttab " & _
                                        " Where ccodtab ='187' and ccodana='" & Encabeza_Part(5).ToUpper.Trim & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Caja")

                For Each fila As DataRow In ds.Tables("Caja").Rows
                    lcCodcta_CJA = fila("cCodcta").ToString.Trim
                Next


                If lcCodcta_CJA.Trim.Length = 0 Then
                    lcnumcom = "1"
                End If

                If lcCodcta_CJA.Trim.Length > 0 Then

                    'Extrae Correlativo de Partida
                    command.CommandText = _
                                            " Select * from cnumes " & _
                                            " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                    ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds, "List_No_Part")

                    For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                        lcnumcom = fila("cnumcom").ToString.Trim
                    Next

                    i = Double.Parse(Right(lcnumcom, 6)) + 1


                    'lcnumcom = lcmes + Clase.fxStrZero(lnTota, lnlong)
                    lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                               ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                               occlass.fxStrZero(i, 6)


                    'Inserta Asiento Contable, Primero lo hara en la Maestra
                    command.CommandText = _
                                            " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                            " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                            " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                            " Values('" & _
                                            lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                            Encabeza_Part(2) & "','',''," & _
                                            "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                            Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                    command.ExecuteNonQuery()

                    'Actualizara en la cNumes                           
                    command.CommandText = _
                                            " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                            " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                    command.ExecuteNonQuery()



                    i = 1

                    'Cargo
                    command.CommandText = _
                                             " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                             " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                             " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                             " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_CJA & "','" & _
                                             lcCodcta_CJA.ToString.Trim.Substring(0, 1) & "'," & Encabeza_Part(9) & _
                                             ",0,'',0,'','" & _
                                             Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                             Encabeza_Part(1) & "','','" & _
                                             Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()

                    i += 1

                    'Descargo
                    command.CommandText = _
                                             " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                             " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                             " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                             " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                             lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "',0" & _
                                             "," & Encabeza_Part(9) & ",'',0,'','" & _
                                             Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                             Encabeza_Part(1) & "','','" & _
                                             Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                    command.ExecuteNonQuery()


                    'Actualiza Certificado
                    command.CommandText = _
                                            " Update ahomcrt set nmonapr=" & Encabeza_Part(9) & ", nmonto2=" & Encabeza_Part(9) & ", cestado ='A'" & _
                                            " where ccodcrt = '" & Encabeza_Part(10) & "'"

                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    MyTransac.Commit()


                End If


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lcnumcom

    End Function


    Public Function Pago_Cupones_Depositos(ByVal Encabeza_Part() As String, ByVal ctipo As String) As String


        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lcnumcom As String = "0"
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim occlass As New dbCntamov
        Dim lcCodcta_ISR As String = ""
        Dim lcCodcta_Aho As String = ""
        Dim lcCodcta_CJA As String = ""
        Dim lcCodbco As String = ""
        Dim lcCtacte As String = ""
        Dim lnSaldoAho As Double = 0
        Dim lnLibreta As String = 0
        Dim lnlinea As Integer = 0
        Dim lnPagina As Integer = 0
        Dim lnpaginau As Integer = 0
        Dim eahommov As New dbAhommov
        Dim lcCodaho_dep As String = ""
        Dim lcCodaho_provis As String = ""
        Dim lntotal_p As Double = 0

        Dim lnDebe As Double = Math.Round((Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))), 2)

        'Dim Datos_Cert() As String = {Date.Parse(Me.Txtdfeccnt.Text), Session("gccodofi"), _
        '                              concepto, "PA", Session("GDFECSIS"), _
        '                              Session("gcCodusu"), "", "", "", Double.Parse(Me.TxtnMonCert.Text), _
        '                              Me.TxtcCodcrt.Text.Trim, Me.Txtndias.Text.ToString, Me.TxtcCodPerson.Text.Trim, _
        '                              CbxBancos1.SelectedValue.Trim, CbxCtasBanco1.SelectedValue.Trim, _
        '                              CbxCtasBanco1.SelectItem.text.trim, lcmonto_letras, _
        '                              Me.Txtcnrochq.Text.Trim, Me.Txtctitular.Text.Trim, Double.Parse(TxtnIntere.Text), _
        '                              Double.Parse(TxtnImpuestos.Text), CbxCtaAho1.SelectedItem.Text.Trim,
        '                              Me.CbxUsuarios1.SelectedValue.Trim, Session("gccontra")}




        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try

                'Extrae Mascara de Ahorros
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '07'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho = fila("cCta1").ToString.Trim
                Next

                'Extrae Plazo
                command.CommandText = _
                                        " Select ccodigo, cdescri from Tabttab " & _
                                        " Where ccodtab = '094' and ctipreg = '1'" & _
                                        " and nnumtab =" & Encabeza_Part(11)

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Plazo")

                ''2111PLCL01
                For Each fila As DataRow In ds.Tables("Plazo").Rows
                    lcCodcta_Aho = lcCodcta_Aho.Replace("PL", fila("ccodigo").ToString.Trim)

                    'Conviertiendo tipo de persona
                    lcCodcta_Aho = lcCodcta_Aho.Replace("CL", Encabeza_Part(12).ToString.Trim)
                    lcCodcta_Aho = lcCodcta_Aho.Trim
                Next


                'Extrae Cuenta Contable de Cajero
                command.CommandText = _
                                        " Select ccodcta from Tabttab " & _
                                        " Where ccodtab ='187' and ccodana='" & Encabeza_Part(5).ToUpper.Trim & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Caja")

                For Each fila As DataRow In ds.Tables("Caja").Rows
                    lcCodcta_CJA = fila("cCodcta").ToString.Trim
                Next


                If lcCodcta_CJA.Trim.Length = 0 Then
                    lcnumcom = "1"
                End If


                ' ctipo = "01" 'Efectivo
                ' ctipo = "03" 'Deposito a cta de Ahorro
                ' ctipo = "02" 'Cheque

                If lcCodcta_CJA.Trim.Length > 0 Then

                    'Extrae Correlativo de Partida
                    command.CommandText = _
                                            " Select * from cnumes " & _
                                            " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                    ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds, "List_No_Part")

                    For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                        lcnumcom = fila("cnumcom").ToString.Trim
                    Next

                    i = Double.Parse(Right(lcnumcom, 6)) + 1


                    lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                               ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                               occlass.fxStrZero(i, 6)


                    Select Case ctipo
                        Case Is = "01"  'Efectivo


                            'Inserta la linea en auxiliar de caja
                            command.CommandText = _
                                                 " Insert into transitorios_caja (ccodcta, cnomcli, cglosa, nmonto, dfeccnt, ccajero, dfecmod, ccodusu, ctipo, cestado)" & _
                                                 " Values('" & _
                                                 Encabeza_Part(22) & "','" & Encabeza_Part(17) & "','" & Encabeza_Part(2) & "'," & Encabeza_Part(18) & ",'" & _
                                                 Encabeza_Part(4) & "','" & Encabeza_Part(21) & "',getdate(),'" & Encabeza_Part(5) & "','E','')"


                            command.ExecuteNonQuery()


                            'Inserta Asiento Contable, Primero lo hara en la Maestra
                            command.CommandText = _
                                                    " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                                    " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                                    " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                                    " Values('" & _
                                                    lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                                    Encabeza_Part(2) & "','',''," & _
                                                    "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                                    Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                            command.ExecuteNonQuery()

                            'Actualizara en la cNumes                           
                            command.CommandText = _
                                                    " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                                    " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                        ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                            command.ExecuteNonQuery()



                            i = 1

                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                    lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & Encabeza_Part(22) & "','" & _
                                                    Encabeza_Part(22).ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & Encabeza_Part(18) & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            'Evalua si existen Impuestos
                            If Encabeza_Part(19) > 0 Then



                                'Extrae cta de Impuesto sobre la Renta
                                command.CommandText = _
                                                        " Select * from tabtmak " & _
                                                        " where ccodigo = 'CIANN'"


                                command.CommandType = CommandType.Text

                                MyAdapter.SelectCommand = command

                                MyAdapter.Fill(ds, "Mascara")

                                For Each fila As DataRow In ds.Tables("Mascara").Rows
                                    lcCodcta_ISR = fila("cplanti").ToString.Trim
                                Next

                                i += 1


                                'Descargo
                                command.CommandText = _
                                                         " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                         " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                         " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                         " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_ISR & "','" & _
                                                         lcCodcta_ISR.ToString.Trim.Substring(0, 1) & "',0" & _
                                                         "," & Encabeza_Part(19) & ",'',0,'','" & _
                                                         Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                         Encabeza_Part(1) & "','','" & _
                                                         Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                                command.ExecuteNonQuery()

                            End If

                            'gccontra

                        Case Is = "02"  'Cheque


                            'Inserta Asiento Contable, Primero lo hara en la Maestra
                            command.CommandText = _
                                                    " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                                    " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                                    " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                                    " Values('" & _
                                                    lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                                    Encabeza_Part(2) & "','',''," & _
                                                    "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                                    Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                            command.ExecuteNonQuery()

                            'Actualizara en la cNumes                           
                            command.CommandText = _
                                                    " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                                    " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                        ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                            command.ExecuteNonQuery()



                            i = 1


                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                    lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & Encabeza_Part(14) & "','" & _
                                                    Encabeza_Part(14).ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & Encabeza_Part(18) & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            'Evalua si existen Impuestos
                            If Encabeza_Part(19) > 0 Then



                                'Extrae cta de Impuesto sobre la Renta
                                command.CommandText = _
                                                        " Select * from tabtmak " & _
                                                        " where ccodigo = 'CIANN'"


                                command.CommandType = CommandType.Text

                                MyAdapter.SelectCommand = command

                                MyAdapter.Fill(ds, "Mascara")

                                For Each fila As DataRow In ds.Tables("Mascara").Rows
                                    lcCodcta_ISR = fila("cplanti").ToString.Trim
                                Next

                                i += 1


                                'Descargo
                                command.CommandText = _
                                                         " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                         " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                         " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                         " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_ISR & "','" & _
                                                         lcCodcta_ISR.ToString.Trim.Substring(0, 1) & "',0" & _
                                                         "," & Encabeza_Part(19) & ",'',0,'','" & _
                                                         Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                         Encabeza_Part(1) & "','','" & _
                                                         Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                                command.ExecuteNonQuery()

                            End If


                            'Extrae Banco
                            command.CommandText = _
                                                     " Select * from Tabtbco " & _
                                                     " Where cCodcta ='" & Encabeza_Part(14) & "'"

                            command.CommandType = CommandType.Text

                            MyAdapter.SelectCommand = command

                            MyAdapter.Fill(ds, "Banco")

                            For Each fila As DataRow In ds.Tables("Banco").Rows
                                lcCodbco = fila("ccodbco").ToString.Trim
                                lcCtacte = fila("cCtacte").ToString.Trim
                            Next


                            'Insert el Cheque
                            command.CommandText = _
                                                    " Insert Into Ctbdchq (cnumcom, ccodbco, cctacte, cnrochq, cnomchq, cmonchq, cflc, cnomcta, dfeccnt2," & _
                                                    " lprint, cmonlet) Values('" & lcnumcom & "','" & lcCodbco & "','','" & Encabeza_Part(16) & "','" & _
                                                     Encabeza_Part(17) & "'," & Encabeza_Part(18) & ",'','" & lcCtacte & "','" & ldfeccnt & "',0,'" & _
                                                     Encabeza_Part(15) & "')"

                            command.ExecuteNonQuery()


                        Case Else       'Deposito a cta de Ahorro


                            'Limpia datatable de Mascaras
                            ds.Tables("Mascaras").Rows.Clear()

                            'Extrae Mascara de Ahorros
                            command.CommandText = _
                                                    " Select ccta1, ccta2 from Ahomtrs " & _
                                                    " Where ccodtrs = '" & Encabeza_Part(20).Substring(6, 2).Trim & "'"

                            command.CommandType = CommandType.Text

                            MyAdapter.SelectCommand = command

                            MyAdapter.Fill(ds, "Mascaras")

                            For Each fila As DataRow In ds.Tables("Mascaras").Rows
                                lcCodcta_Aho = fila("cCta1")
                                lcCodaho_provis = fila("cCta2")


                                ''Conviertiendo tipo de persona
                                'lcCodaho_dep = lcCodaho_dep.Replace("CL", Encabeza_Part(12).ToString.Trim)
                                'lcCodaho_dep = lcCodaho_dep.Trim
                            Next

                            'Inserta Asiento Contable, Primero lo hara en la Maestra
                            command.CommandText = _
                                                    " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                                    " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                                    " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                                    " Values('" & _
                                                    lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                                    Encabeza_Part(2) & "','',''," & _
                                                    "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                                    Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                            command.ExecuteNonQuery()

                            'Actualizara en la cNumes                           
                            command.CommandText = _
                                                    " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                                    " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                        ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                            command.ExecuteNonQuery()



                            i = 1


                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodaho_provis & "','" & _
                                                    lcCodaho_provis.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                    lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & lnDebe & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()


                            'Evalua si existen Impuestos
                            If Encabeza_Part(19) > 0 Then


                                'Extrae cta de Impuesto sobre la Renta
                                command.CommandText = _
                                                        " Select * from tabtmak " & _
                                                        " where ccodigo = 'CIANN'"


                                command.CommandType = CommandType.Text

                                MyAdapter.SelectCommand = command

                                MyAdapter.Fill(ds, "Mascara")

                                For Each fila As DataRow In ds.Tables("Mascara").Rows
                                    lcCodcta_ISR = fila("cplanti").ToString.Trim
                                Next



                                i += 1


                                'Cargo
                                command.CommandText = _
                                                         " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                         " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                         " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                         " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                         lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "'," & Encabeza_Part(19) & _
                                                         ",0,'',0,'','" & _
                                                         Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                         Encabeza_Part(1) & "','','" & _
                                                         Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                                command.ExecuteNonQuery()

                                i += 1


                                'Descargo
                                command.CommandText = _
                                                         " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                         " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                         " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                         " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_ISR & "','" & _
                                                         lcCodcta_ISR.ToString.Trim.Substring(0, 1) & "',0" & _
                                                         "," & Encabeza_Part(19) & ",'',0,'','" & _
                                                         Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                         Encabeza_Part(1) & "','','" & _
                                                         Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                                command.ExecuteNonQuery()

                            End If



                            'Hara el Deposito a la Cta. de Ahorro
                            If Encabeza_Part(20).Trim.Length > 0 Then


                                'Extre Movimiento de Ahorro
                                command.CommandText = _
                                                        " Select * from Ahomcta " & _
                                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"


                                command.CommandType = CommandType.Text

                                MyAdapter.SelectCommand = command

                                MyAdapter.Fill(ds, "Ahorro")

                                For Each fila As DataRow In ds.Tables("Ahorro").Rows
                                    lnSaldoAho = fila("nsaldoaho") + (Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19)))
                                    lnSaldoAho = Math.Round(lnSaldoAho, 2)
                                    lnLibreta = fila("nlibreta")
                                    lnlinea = fila("nnum") + 1
                                Next

                                'lnlinea = eahommov.fxLinea(lnlinea)

                                If lnlinea > 65 Then
                                    lnlinea = 1
                                End If

                                'lnlinea = eahommov.ObtieneLinea(Encabeza_Part(20).Trim)
                                'lnPagina = eahommov.ObtienePagina(Encabeza_Part(20).Trim, lnlinea) 'obtiene pagina
                                'lnlinea = clsppal.fxLinea(lnlinea, lnPagina, Encabeza_Part(20).Trim)

                                'lnpaginau = eahommov.ObtienePaginaUltima(Encabeza_Part(20).Trim, lnlinea)
                                'If lnpaginau <= 3 Then
                                '    If lnlinea > 30 Then
                                '        lnlinea = 1
                                '    End If
                                'Else
                                '    If lnlinea > 15 Then
                                '        lnlinea = 1
                                '    End If
                                'End If


                                ' Inserta en la Maestra de Ahorros
                                command.CommandText = _
                                                        " Update ahomcta " & _
                                                        " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                                        " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres" & _
                                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"
                                command.ExecuteNonQuery()


                                lntotal_p = Double.Parse(Encabeza_Part(18)) + Double.Parse(Encabeza_Part(19))
                                lntotal_p = Math.Round(lntotal_p, 2)


                                ' Inserta en el Movimiento de Ahorros
                                command.CommandText = _
                                                        "insert into ahommov " & _
                                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina) values " & _
                                                        "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'D', 'TRAS/INT', 'E', 'DEPOSITO x PAGO INTERESES', " & lnLibreta & ", '', ''," & _
                                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & lntotal_p & ",0,'N'," & _
                                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                                        lnSaldoAho & ", " & lnSaldoAho & ", 'DP','07',' ',0,'',0," & lnPagina & ")"

                                command.ExecuteNonQuery()


                                ' Retiro por Reforma Fiscal si aplica
                                If Encabeza_Part(19) > 0 Then

                                    lnSaldoAho = lnSaldoAho - Encabeza_Part(19)
                                    lnlinea += 1

                                    command.CommandText = _
                                                        "insert into ahommov " & _
                                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina) values " & _
                                                        "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'R', 'FISCAL', 'E', 'RETIRO x REFORMA FISCAL', " & lnLibreta & ", '', ''," & _
                                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & Encabeza_Part(19) & ",0,'N'," & _
                                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                                        lnSaldoAho & ", " & lnSaldoAho & ", 'RT','07',' ',0,'',0," & lnPagina & ")"

                                    command.ExecuteNonQuery()



                                    'Actualizo la cabecera
                                    command.CommandText = _
                                                       " Update ahomcta " & _
                                                       " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                                       " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                                       " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres" & _
                                                       " where ccodaho= '" & Encabeza_Part(20).Trim & "'"
                                    command.ExecuteNonQuery()


                                    'Actualiza Maestra de Reforma Fiscal
                                    command.CommandText = _
                                                            " Insert Into reforma_fiscal " & _
                                                            "(ccodcli, fecha, cuenta, certifica, monto_prom, int_ganado, retenido) values " & _
                                                            "('" & Encabeza_Part(23) & "', '" & Encabeza_Part(0) & "', '', '" & Encabeza_Part(10) & "', " & lntotal_p & ", " & _
                                                            Encabeza_Part(18) & "," & Encabeza_Part(19) & ")"

                                    command.ExecuteNonQuery()

                                End If
                                

                            End If

                    End Select



                    'Actualiza Maestra de Certificados
                    command.CommandText = _
                                            " Update Ahomcrt set dmenpro ='" & ldfeccnt & "', dfeccap ='" & ldfeccnt & "'" & _
                                            " where ccodcrt = '" & Encabeza_Part(10) & "'"


                    command.ExecuteNonQuery()

                    'Actualiza Maestra de Provisión de Certificados
                    command.CommandText = _
                                            " Update ahomint set cflag ='X'" & _
                                            " where ccodcrt = '" & Encabeza_Part(10) & "' and dfecpro <='" & ldfeccnt & "'"


                    command.ExecuteNonQuery()

                    ' Attempt to commit the transaction.
                    MyTransac.Commit()


                End If


            Catch ex As Exception
                lcnumcom = "0"

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lcnumcom

    End Function

    Public Function Pago_Depositos(ByVal Encabeza_Part() As String, ByVal ctipo As String) As String


        Dim ds As New DataSet
        'Dim occlass As New dbcrefunc
        Dim lcnumcom As String = "0"
        Dim i As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ldfeccnt As Date = Encabeza_Part(0)
        Dim lccodtrans As String = Encabeza_Part(3) 'IIf(Detalle_Cheq.Length = 0, "PA", "CH")
        Dim occlass As New dbCntamov
        Dim lcCodcta_ISR As String = ""
        Dim lcCodcta_Aho As String = ""
        Dim lcCodcta_Int As String = ""
        Dim lcCodcta_CJA As String = ""
        Dim lcCodbco As String = ""
        Dim lcCtacte As String = ""
        Dim lnSaldoAho As Double = 0
        Dim lnLibreta As String = 0
        Dim lnlinea As Integer = 0
        Dim lnPagina As Integer = 0
        Dim lnpaginau As Integer = 0
        Dim eahommov As New dbAhommov
        Dim lcCodaho_dep As String = ""
        Dim lnDebe As Double = Math.Round(Double.Parse(Encabeza_Part(9)), 2)
        Dim lnIntere As Double = Math.Round(Double.Parse(Encabeza_Part(18)), 2)

        'Dim Datos_Cert() As String = {Date.Parse(Me.Txtdfeccnt.Text), Session("gccodofi"), _
        '                              concepto, "AR", Session("GDFECSIS"), _
        '                              Session("gcCodusu"), "", "", "", Double.Parse(Me.TxtnMonCert.Text), _
        '                              Me.TxtcCodcrt.Text.Trim, Me.Txtndias.Text.ToString, Me.TxtcCodPerson.Text.Trim, _
        '                              CbxBancos1.SelectedValue.Trim, CbxCtasBanco1.SelectedValue.Trim, _
        '                              CbxCtasBanco1.SelectItem.text.trim, lcmonto_letras, _
        '                              Me.Txtcnrochq.Text.Trim, Me.Txtctitular.Text.Trim, Double.Parse(TxtnIntere.Text), _
        '                              Double.Parse(TxtnImpuestos.Text), CbxCtaAho1.SelectedItem.Text.Trim,
        '                              Me.CbxUsuarios1.SelectedValue.Trim, Session("gccontra")}




        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try

                'Extrae Mascara de Ahorros
                command.CommandText = _
                                        " Select ccta1, ccta4 from Ahomtrs " & _
                                        " Where ccodtrs = '07'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho = fila("cCta1").ToString.Trim
                    lcCodcta_Int = fila("cCta4").ToString.Trim
                Next

                ''Extrae Plazo
                'command.CommandText = _
                '                        " Select ccodigo, cdescri from Tabttab " & _
                '                        " Where ccodtab = '094' and ctipreg = '1'" & _
                '                        " and nnumtab =" & Encabeza_Part(11)

                'command.CommandType = CommandType.Text

                'MyAdapter.SelectCommand = command

                'MyAdapter.Fill(ds, "Plazo")

                ' ''2111PLCL01
                'For Each fila As DataRow In ds.Tables("Plazo").Rows
                '    lcCodcta_Aho = lcCodcta_Aho.Replace("PL", fila("ccodigo").ToString.Trim)

                '    'Conviertiendo tipo de persona
                '    lcCodcta_Aho = lcCodcta_Aho.Replace("CL", Encabeza_Part(12).ToString.Trim)
                '    lcCodcta_Aho = lcCodcta_Aho.Trim
                'Next


                'Extrae Cuenta Contable de Cajero
                command.CommandText = _
                                        " Select ccodcta from Tabttab " & _
                                        " Where ccodtab ='187' and ccodana='" & Encabeza_Part(5).ToUpper.Trim & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Caja")

                For Each fila As DataRow In ds.Tables("Caja").Rows
                    lcCodcta_CJA = fila("cCodcta").ToString.Trim
                Next


                If lcCodcta_CJA.Trim.Length = 0 Then
                    lcnumcom = "1"
                End If


                ' ctipo = "01" 'Efectivo
                ' ctipo = "03" 'Deposito a cta de Ahorro
                ' ctipo = "02" 'Cheque

                If lcCodcta_CJA.Trim.Length > 0 Then

                    'Extrae Correlativo de Partida
                    command.CommandText = _
                                            " Select * from cnumes " & _
                                            " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                    ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds, "List_No_Part")

                    For Each fila As DataRow In ds.Tables("List_No_Part").Rows
                        lcnumcom = fila("cnumcom").ToString.Trim
                    Next

                    i = Double.Parse(Right(lcnumcom, 6)) + 1


                    lcnumcom = IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                               ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) + _
                               occlass.fxStrZero(i, 6)


                    Select Case ctipo
                        Case Is = "01"  'Efectivo


                            'Inserta la linea en auxiliar de caja
                            command.CommandText = _
                                                 " Insert into transitorios_caja (ccodcta, cnomcli, cglosa, nmonto, dfeccnt, ccajero, dfecmod, ccodusu, ctipo, cestado)" & _
                                                 " Values('" & _
                                                 Encabeza_Part(22) & "','" & Encabeza_Part(17) & "','" & Encabeza_Part(2) & "'," & Encabeza_Part(9) & ",'" & _
                                                 Encabeza_Part(4) & "','" & Encabeza_Part(21) & "',getdate(),'" & Encabeza_Part(5) & "','E','')"


                            command.ExecuteNonQuery()


                            'Inserta Asiento Contable, Primero lo hara en la Maestra
                            command.CommandText = _
                                                    " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                                    " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                                    " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                                    " Values('" & _
                                                    lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                                    Encabeza_Part(2) & "','',''," & _
                                                    "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                                    Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                            command.ExecuteNonQuery()

                            'Actualizara en la cNumes                           
                            command.CommandText = _
                                                    " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                                    " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                        ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                            command.ExecuteNonQuery()



                            i = 1

                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                    lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & Encabeza_Part(22) & "','" & _
                                                    Encabeza_Part(22).ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & Encabeza_Part(9) & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()





                        Case Is = "02"  'Cheque


                            'Inserta Asiento Contable, Primero lo hara en la Maestra
                            command.CommandText = _
                                                    " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                                    " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                                    " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                                    " Values('" & _
                                                    lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                                    Encabeza_Part(2) & "','',''," & _
                                                    "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                                    Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                            command.ExecuteNonQuery()

                            'Actualizara en la cNumes                           
                            command.CommandText = _
                                                    " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                                    " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                        ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                            command.ExecuteNonQuery()



                            i = 1


                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                    lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & Encabeza_Part(14) & "','" & _
                                                    Encabeza_Part(14).ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & Encabeza_Part(9) & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()


                            '----------------------------------------------------'
                            '   Hara movimiento contable sobre el Cajero
                            '----------------------------------------------------'

                            i += 1

                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_CJA & "','" & _
                                                    lcCodcta_CJA.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()


                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_CJA & "','" & _
                                                    lcCodcta_CJA.ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & lnDebe & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()

                            'Finaliza movimiento en el cajero

                            'Extrae Banco
                            command.CommandText = _
                                                     " Select * from Tabtbco " & _
                                                     " Where cCodcta ='" & Encabeza_Part(14) & "'"

                            command.CommandType = CommandType.Text

                            MyAdapter.SelectCommand = command

                            MyAdapter.Fill(ds, "Banco")

                            For Each fila As DataRow In ds.Tables("Banco").Rows
                                lcCodbco = fila("ccodbco").ToString.Trim
                                lcCtacte = fila("cCtacte").ToString.Trim
                            Next


                            'Insert el Cheque
                            command.CommandText = _
                                                    " Insert Into Ctbdchq (cnumcom, ccodbco, cctacte, cnrochq, cnomchq, cmonchq, cflc, cnomcta, dfeccnt2," & _
                                                    " lprint, cmonlet) Values('" & lcnumcom & "','" & lcCodbco & "','','" & Encabeza_Part(16) & "','" & _
                                                     Encabeza_Part(17) & "'," & Encabeza_Part(18) & ",'','" & lcCtacte & "','" & ldfeccnt & "',0,'" & _
                                                     Encabeza_Part(15) & "')"

                            command.ExecuteNonQuery()


                        Case Else       'Deposito a cta de Ahorro


                            'Limpia datatable de Mascaras
                            ds.Tables("Mascaras").Rows.Clear()

                            'Extrae Mascara de Ahorros
                            command.CommandText = _
                                                    " Select ccta1 from Ahomtrs " & _
                                                    " Where ccodtrs = '" & Encabeza_Part(20).Substring(6, 2).Trim & "'"

                            command.CommandType = CommandType.Text

                            MyAdapter.SelectCommand = command

                            MyAdapter.Fill(ds, "Mascaras")

                            For Each fila As DataRow In ds.Tables("Mascaras").Rows
                                lcCodaho_dep = fila("cCta1").ToString.Trim
                            Next

                            'Inserta Asiento Contable, Primero lo hara en la Maestra
                            command.CommandText = _
                                                    " Insert Into Diario (cnumcom,ccodofi,ctipasi,ctipmon,cglosa,cnumdoc," & _
                                                    " ccodruc,ccodemp,dfecdoc,dfeccnt,dfecmod,ccodusu,nccompra, ncventa," & _
                                                    " ntcfijo, cfv, cestado, nfln, cnrodoc, ffondos, ccodrev, ccodreg)" & _
                                                    " Values('" & _
                                                    lcnumcom & "','" & Encabeza_Part(1) & "','" & Encabeza_Part(3) & " ','1','" & _
                                                    Encabeza_Part(2) & "','',''," & _
                                                    "'','" & Encabeza_Part(4) & "','" & Encabeza_Part(0) & "','" & Encabeza_Part(4) & "','" & _
                                                    Encabeza_Part(5) & "',0,0,0,'','',0,'','','','')"

                            command.ExecuteNonQuery()

                            'Actualizara en la cNumes                           
                            command.CommandText = _
                                                    " Update cnumes Set cnumcom ='" & lcnumcom & "'" & _
                                                    " Where numes ='" & IIf(ldfeccnt.Month.ToString.Trim.Length = 1, "0" & _
                                                                        ldfeccnt.Month.ToString.Trim, ldfeccnt.Month.ToString.Trim) & "'"
                            command.ExecuteNonQuery()



                            i = 1


                            'Cargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho & "','" & _
                                                    lcCodcta_Aho.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                                    ",0,'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            i += 1

                            'Descargo
                            command.CommandText = _
                                                    " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                    " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                    " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                    " ','01','" & lcnumcom & "'," & i & ",'" & lcCodaho_dep & "','" & _
                                                    lcCodaho_dep.ToString.Trim.Substring(0, 1) & "',0" & _
                                                    "," & Encabeza_Part(9) & ",'',0,'','" & _
                                                    Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                    Encabeza_Part(1) & "','','" & _
                                                    Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            command.ExecuteNonQuery()



                            'Si existen intereses pendientes los contabilizara
                            If Encabeza_Part(18) > 0 Then

                                i += 1

                                'Cargo
                                command.CommandText = _
                                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Int & "','" & _
                                                        lcCodcta_Int.ToString.Trim.Substring(0, 1) & "'," & lnIntere & _
                                                        ",0,'',0,'','" & _
                                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                        Encabeza_Part(1) & "','','" & _
                                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                                command.ExecuteNonQuery()


                                i += 1

                                'Descargo
                                command.CommandText = _
                                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodaho_dep & "','" & _
                                                        lcCodaho_dep.ToString.Trim.Substring(0, 1) & "',0" & _
                                                        "," & lnIntere & ",'',0,'','" & _
                                                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                                                        Encabeza_Part(1) & "','','" & _
                                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                                command.ExecuteNonQuery()

                            End If

                            'Comentariado por el momento

                            ''----------------------------------------------------'
                            ''   Hara movimiento contable sobre el Cajero
                            ''----------------------------------------------------'

                            'i += 1

                            ''Cargo
                            'command.CommandText = _
                            '                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                            '                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                            '                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                            '                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_CJA & "','" & _
                            '                        lcCodcta_CJA.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                            '                        ",0,'',0,'','" & _
                            '                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                            '                        Encabeza_Part(1) & "','','" & _
                            '                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            'command.ExecuteNonQuery()


                            'i += 1

                            ''Descargo
                            'command.CommandText = _
                            '                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                            '                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                            '                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                            '                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_CJA & "','" & _
                            '                        lcCodcta_CJA.ToString.Trim.Substring(0, 1) & "',0" & _
                            '                        "," & lnDebe & ",'',0,'','" & _
                            '                        Encabeza_Part(0) & "','','','" & Encabeza_Part(3) & "','" & _
                            '                        Encabeza_Part(1) & "','','" & _
                            '                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','')"

                            'command.ExecuteNonQuery()

                            ''Finaliza movimiento en el cajero


                            'Hara el Deposito a la Cta. de Ahorro
                            If Encabeza_Part(20).Trim.Length > 0 Then


                                'Extre Movimiento de Ahorro
                                command.CommandText = _
                                                        " Select * from Ahomcta " & _
                                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"


                                command.CommandType = CommandType.Text

                                MyAdapter.SelectCommand = command

                                MyAdapter.Fill(ds, "Ahorro")

                                For Each fila As DataRow In ds.Tables("Ahorro").Rows
                                    lnSaldoAho = fila("nsaldoaho") + Encabeza_Part(9) + Encabeza_Part(18)
                                    lnLibreta = fila("nlibreta")
                                    lnlinea = fila("nnum") + 1
                                Next


                                ''Extrae Numero de Linea
                                'command.CommandText = _
                                '                        " Select isnull(MAX(nnum+1),1) as nnum FROM AHOMMOV " & _
                                '                        " Where ccodaho = '" & Encabeza_Part(20).Trim & "'"


                                'command.CommandType = CommandType.Text

                                'MyAdapter.SelectCommand = command

                                'MyAdapter.Fill(ds, "Linea1")

                                'For Each fila As DataRow In ds.Tables("Linea1").Rows
                                '    lnlinea = fila("nnum")
                                'Next


                                lnlinea = eahommov.fxLinea(lnlinea)


                                ' Inserta en la Maestra de Ahorros
                                command.CommandText = _
                                                        " Update ahomcta " & _
                                                        " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                                        " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & " ,nmonres=nmonres" & _
                                                        " where ccodaho= '" & Encabeza_Part(20).Trim & "'"
                                command.ExecuteNonQuery()


                                ' Inserta en el Movimiento de Ahorros de los Interese no Depositas en la cuenta
                                If Encabeza_Part(18) > 0 Then

                                    lnSaldoAho = lnSaldoAho - Encabeza_Part(9)

                                    command.CommandText = _
                                                      "insert into ahommov " & _
                                                      "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                                      "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina) values " & _
                                                      "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'D', '" & lcnumcom & "', 'E', 'DEPOSITO DE INTERESES POR CERTIFICADO A PLAZO', " & lnLibreta & ", '', ''," & _
                                                      "'" & ldfeccnt & "','" & ldfeccnt & "',0," & Encabeza_Part(18) & ",0,'N'," & _
                                                      lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                                      lnSaldoAho & ", " & lnSaldoAho & ", 'DP','07',' ',0,'',0," & lnPagina & ")"

                                    command.ExecuteNonQuery()

                                    'Actualiza saldo y numero de linea de libreta
                                    lnSaldoAho = lnSaldoAho + Encabeza_Part(9)

                                    lnlinea += 1

                                End If



                                ' Inserta en el Movimiento de Ahorros del Deposito
                                command.CommandText = _
                                                        "insert into ahommov " & _
                                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon, pagina) values " & _
                                                        "('" & Encabeza_Part(20) & "','" & ldfeccnt & "', 'D', '" & lcnumcom & "', 'E', 'DEPOSITO DE CERTIFICADO A PLAZO', " & lnLibreta & ", '', ''," & _
                                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & Encabeza_Part(9) & ",0,'N'," & _
                                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                                        lnSaldoAho & ", " & lnSaldoAho & ", 'DP','07',' ',0,'',0," & lnPagina & ")"

                                command.ExecuteNonQuery()

                                
                            End If

                    End Select


                    'Actualiza Cupones Pagados en Maestra de Cupones
                    'command.CommandText = _
                    '                        " Update ahomcrt set cestado ='C'" & _
                    '                        " where ccodcrt = '" & Encabeza_Part(10) & "'"

                    'command.ExecuteNonQuery()


                    command.CommandText = _
                                            " Update ahomcrt set cestado ='C', cliq = 'S', dultpro ='" & ldfeccnt & "'" & _
                                            " where ccodcrt = '" & Encabeza_Part(10) & "'"

                    command.ExecuteNonQuery()

                    'Pendiente de arreglar fecha 


                    'Actualiza Interes generados, colando bandera para no pagarlos de nuevo
                    command.CommandText = _
                                            " update ahomint set cflag='X'" & _
                                            " where ccodcrt = '" & Encabeza_Part(10) & "'"

                    command.ExecuteNonQuery()


                    ' Attempt to commit the transaction.
                    MyTransac.Commit()


                End If


            Catch ex As Exception
                lcnumcom = "0"

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    MyTransac.Rollback()

                Catch ex2 As Exception
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try

            Finally
                connection.Close()
            End Try

        End Using

        Return lcnumcom

    End Function


    Public Function Extraer_Datos_Declaracion(ByVal pcCodcrt As String) As DataSet


        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim lcCodDep As String = ""
        Dim lcCodMun As String = ""
        Dim lcDepzon As String = ""
        Dim lcMunzon As String = ""
        Dim lcCodprof As String = ""
        Dim lcDesProf As String = ""
        Dim lcAct_juri As String = ""
        Dim lcDesAct_juri As String = ""

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()


            command.Connection = connection


            Try

                'Extrae Datos para Declaración Jurada
                command.CommandText = _
                                        " Select case cclaper when '2' then a.cnomcli else '' end as nombre_sociedad, " & _
                                        "  case cclaper when '2' then a.cdirdom else '' end as direccion_sociedad, " & _
                                        " case cclaper when '2' then a.cnudotr else '' end as Nit_sociedad, " & _
                                        " case cclaper when '2' then a.cteldom else '' end as Tel_sociedad,	" & _
                                        " case cclaper when '2' then a.nocontrib else '' end as NoRegistro_sociedad, " & _
                                        " case cclaper when '2' then 'Salvadoreño(a)' else '' end as cnacionalidad_jur, " & _
                                        " isnull(a.GiroNegocio,'') as GiroNegocio, a.cCodDom, a.cnudoci," & _
                                        " space(20) as cActiEcono_Sociedad, " & _
                                        " space(20) as Depto_Sociedad, " & _
                                        " space(20) as Muni_Sociedad, a.cclaper, " & _
                                        " case cclaper when '1' then a.cnomcli else '' end as nombre_socio, " & _
                                        " case cclaper when '1' then a.cdirdom else '' end as direccion_socio, " & _
                                        " case cclaper when '1' then a.cnudotr else '' end as Nit_socio, " & _
                                        " case cclaper when '1' then a.cteldom else '' end as Tel_socio, " & _
                                        " case cclaper when '1' then 'Salvadoreño(a)' else '' end  as nacionalidad, " & _
                                        " case cclaper when '1' then a.dfecexpdui else '' end  as Exp_Dui, " & _
                                        " case cclaper when '1' then a.dnacimi else '' end  as Fecha_Nacimiento, " & _
                                        " case a.cestciv when '1' then 'Soltero(a)' " & _
                                        " when '2' then 'Casado(a)' " & _
                                        " when '3' then 'Acompañado(a)' " & _
                                        " when '4' then 'Viudo(a)' " & _
                                        " when '5' then 'Divorciado(a)' " & _
                                        " else 'No Aplica' " & _
                                        " end as Estado_Civil, " & _
                                        " a.ccodpro, " & _
                                        " space(20) as cActiEcono_Socio, " & _
                                        " space(20) as Muni_Socio, " & _
                                        " space(20) as Depto_Socio, " & _
                                        " DATEDIFF(year,a.dnacimi,getdate()) as nanos, " & _
                                        " ccorreo, " & _
                                        " b.*  	   " & _
                                        " From climide a " & _
                                        " inner join ahomcrt b " & _
                                        " on a.ccodcli = b.cnudotr  " & _
                                        " inner join ahotlin c " & _
                                        " on c.cnrolin = b.cnrolin " & _
                                        " Where b.cCodcrt ='" & pcCodcrt & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "BD_Declaracion")


                'Profesión
                command.CommandText = _
                                        " Select * from tabtprf "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Profesiones")



                'Zona
                command.CommandText = _
                                        " Select * from tabtzon where ctipzon >= '1' "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Zonas")


                command.CommandText = _
                                        " Select * from tabttab where ccodtab + ctipreg = '3001' "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Profesion_Jur")


                For Each fila As DataRow In ds.Tables("BD_Declaracion").Rows
                    lcCodDep = Left(fila("cCodDom"), 2)
                    lcCodMun = Left(fila("cCodDom"), 4)
                    lcCodprof = fila("cCodPro")
                    lcAct_juri = fila("GiroNegocio")

                    For Each Linea As DataRow In ds.Tables("Profesiones").Rows
                        If lcCodprof.Trim = Linea("cCodigo").trim Then
                            lcDesProf = Linea("cdescri")
                            Exit For
                        End If
                    Next

                    For Each Linea1 As DataRow In ds.Tables("Zonas").Rows
                        If lcCodDep.Trim = Linea1("cCodzon").trim Then
                            lcDepzon = Linea1("cDeszon")
                            Exit For
                        End If
                    Next

                    For Each Linea2 As DataRow In ds.Tables("Zonas").Rows
                        If lcCodMun.Trim = Linea2("cCodzon").trim Then
                            lcMunzon = Linea2("cDeszon")
                            Exit For
                        End If
                    Next


                    If fila("cclaper").trim = "2" Then 'Personas Juridicas
                        For Each Linea3 As DataRow In ds.Tables("Profesion_Jur").Rows
                            If lcAct_juri.Trim = Linea3("cCodigo").trim Then
                                lcDesAct_juri = Linea3("cDescri")
                                Exit For
                            End If
                        Next

                        fila("cActiEcono_Sociedad") = lcDesAct_juri
                        fila("Depto_Sociedad") = lcDepzon
                        fila("Muni_Sociedad") = lcMunzon
                    Else                               'Personas Natural
                        fila("cActiEcono_Socio") = lcDesProf
                        fila("Muni_Socio") = lcDepzon
                        fila("Depto_Socio") = lcMunzon
                    End If
                Next


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

            Finally
                connection.Close()
            End Try

        End Using

        Return ds

    End Function


    Public Function Extraer_Depositos_Caja(ByVal pcCodCaja As String, ByVal pdfecsis As Date, _
                                           ByVal pctipo As String) As DataSet


        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()


            command.Connection = connection


            Try


                command.CommandText = _
                                        " Select Id, ccodcta, cnomcli, nmonto, dfeccnt, cglosa from transitorios_caja" & _
                                        " where ccajero = '" & pcCodCaja.ToUpper.Trim & "' and dfeccnt = '" & pdfecsis & "' and cestado <> 'X'" & _
                                        " and ctipo = '" & pctipo & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Depositos_Caja")



            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

            Finally
                connection.Close()
            End Try

        End Using

        Return ds

    End Function


    Public Function Actualizar_Depositos_Caja(ByVal pcCodCaja As String, ByVal pdfecsis As Date, _
                                          ByVal pctipo As String, ByVal pnId As Integer) As Integer


        Dim ds As New DataSet
        Dim command As New SqlCommand
        'Dim MyAdapter As New SqlDataAdapter
        Dim lnRetorno As Integer = 0


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()


            command.Connection = connection


            Try


                command.CommandText = _
                                        " Update transitorios_caja set cestado = 'X'" & _
                                        " where ccajero = '" & pcCodCaja.ToUpper.Trim & "' and dfeccnt = '" & pdfecsis & "' and cestado <> 'X'" & _
                                        " and ctipo = '" & pctipo & "' and Id=" & pnId

                command.ExecuteNonQuery()


                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

            Finally
                connection.Close()
            End Try

        End Using

        Return lnRetorno

    End Function


    Public Function Verifica_Duplicidad_Certificado(ByVal pcCodCrt As String) As Boolean


        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = True


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()


            command.Connection = connection


            Try


                command.CommandText = _
                                        " Select * from Ahomcrt" & _
                                        " where ccodcrt = '" & pcCodCrt.Trim & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Depositos")


                For Each fila As DataRow In ds.Tables("Depositos").Rows
                    llvalida = False
                Next


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

            Finally
                connection.Close()
            End Try

        End Using

        Return llvalida

    End Function


    Public Function Extrae_Datos_Depositos(ByVal pcCodcrt As String) As DataSet

        Dim ds As New DataSet
        Dim _sql As String = ""

        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            command.Connection = connection

            Try


                _sql = _
                         " Select c.ncorrel as IdCuenta, c.cNomBen, c.dfecnac as dnacimi, c.cParent, " & _
                         " isnull(c.cDirecc,'') as cDirecc, c.nporcen From ahomcrt a" & _
                         " inner join climide b" & _
                         " on a.cnudotr = b.ccodcli " & _
                         " inner join depmben c" & _
                         " on a.ccodcrt = c.ccodcrt" & _
                         " Where a.cCodcrt ='" & pcCodcrt & "'"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_Ben")


                _sql = _
                         " Select a.*, b.cnudoci, b.cclaper From ahomcrt a" & _
                         " inner join climide b" & _
                         " on a.cnudotr = b.ccodcli " & _
                         " Where cCodcrt ='" & pcCodcrt & "'"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_Depo")


                _sql = _
                         " Select c.* From ahomcrt a" & _
                         " inner join climide b" & _
                         " on a.cnudotr = b.ccodcli " & _
                         " inner join Ahomppg c" & _
                         " on a.ccodcrt = c.ccodcrt" & _
                         " Where a.cCodcrt ='" & pcCodcrt & "'"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_Cupo")



                ' Extrae datos de la encuesta

                _sql = _
                         " Select ccodcrt, ctipotrans, ncorrel as IdCuenta, ccodpais, nmonto From Detalle_Encuesta_Dep " & _
                         " Where cCodcrt ='" & pcCodcrt & "'"


                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "List_Encuesta")

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds

    End Function


    Public Function Extraer_Datos_Depositos_Reimpresion(ByVal pcCodcrt As String, ByVal pdfecha As Date) As DataSet


        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()


            command.Connection = connection


            Try


                command.CommandText = _
                                        " Select cnumcom, sum(ndebe) as ndebe, sum(nhaber) as nhaber from cntamov " & _
                                        " Where cCodpres = '" & pcCodcrt & "' and cflc <> 'X' and dfeccnt = '" & pdfecha & "'" & _
                                        " and isnull(corden,'') = '' and cpoliza = 'PA' group by cnumcom "


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Asiento_Cupon")


                command.CommandText = _
                                         " Select cnumcom, sum(ndebe) as ndebe, sum(nhaber) as nhaber from cntamov " & _
                                         " Where cCodpres = '" & pcCodcrt & "' and cflc <> 'X' and dfeccnt = '" & pdfecha & "'" & _
                                         " and isnull(corden,'') = '' and cpoliza = 'PD' group by cnumcom "


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Pago_Deposito")


                command.CommandText = _
                                        " Select ccodcrt, dfecven, cestado, cnrocuo, nmonto, nintere, nintere_imp, nimpuestos " & _
                                        " From ahomppg where dfecpag = '" & pdfecha & "' and cCodcrt = '" & pcCodcrt & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Cupones_Pagados")


                command.CommandText = _
                                        " Select * From ahomcrt " & _
                                        " where cCodcrt = '" & pcCodcrt & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Detalle_Deposito")


                command.CommandText = _
                                        " Select ccodcrt, sum(nmonto) as nmonto, sum(nintere) as nintere, " & _
                                        " sum(nintere_imp) as nintere_imp, sum(nimpuestos) as nimpuestos  " & _
                                        " from ahomppg where dfecpag = '" & pdfecha & "' and cCodcrt = '" & pcCodcrt & "'" & _
                                        " and cestado = 'E' " & _
                                        " group by ccodcrt"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Total_Cup_Pagados")


            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

            Finally
                connection.Close()
            End Try

        End Using

        Return ds

    End Function
End Class
