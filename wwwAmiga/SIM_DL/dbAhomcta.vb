Imports System.Text
Public Class dbAhomcta
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcta
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodaho =  "" _
            Or lEntidad.ccodaho = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodaho = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomcta ")
        strSQL.Append(" SET cnrolin = @cnrolin, ") 
        strSQL.Append(" ccodcta = @ccodcta, ") 
        strSQL.Append(" nlibreta = @nlibreta, ")
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" cbloqueo = @cbloqueo, ") 
        strSQL.Append(" dfecini = @dfecini, ") 
        strSQL.Append(" dfecapr = @dfecapr, ") 
        strSQL.Append(" dfecult = @dfecult, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" dfecfin = @dfecfin, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" ncorrel = @ncorrel, ") 
        strSQL.Append(" nnum = @nnum, ") 
        strSQL.Append(" llave = @llave, ") 
        strSQL.Append(" nombre = @nombre, ") 
        strSQL.Append(" apellido = @apellido, ") 
        strSQL.Append(" nsaldoaho = @nsaldoaho, ") 
        strSQL.Append(" nmonini = @nmonini, ") 
        strSQL.Append(" nmonapr = @nmonapr, ") 
        strSQL.Append(" nsaldnind = @nsaldnind, ") 
        strSQL.Append(" nmonres = @nmonres, ") 
        strSQL.Append(" dfeccap = @dfeccap, ") 
        strSQL.Append(" ccodcli = @ccodcli, ") 
        strSQL.Append(" producto = @producto, ") 
        strSQL.Append(" cmotivo = @cmotivo, ") 
        strSQL.Append(" despro = @despro, ") 
        strSQL.Append(" sub_pro = @sub_pro, ") 
        strSQL.Append(" dultmov = @dultmov, ")
        strSQL.Append(" notas = @notas, ") 
        strSQL.Append(" dfechault = @dfechault ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(31) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta
        args(2) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnudotr
        args(3) = New SqlParameter("@nlibreta", SqlDbType.Decimal)
        args(3).Value = lEntidad.nlibreta
        args(4) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(4).Value = lEntidad.cestado
        args(5) = New SqlParameter("@cbloqueo", SqlDbType.VarChar)
        args(5).Value = lEntidad.cbloqueo
        args(6) = New SqlParameter("@dfecini", SqlDbType.Datetime)
        args(6).Value = lEntidad.dfecini
        args(7) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(7).Value = lEntidad.dfecapr
        args(8) = New SqlParameter("@dfecult", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfecult
        args(9) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecmod
        args(10) = New SqlParameter("@dfecfin", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecfin
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu
        args(12) = New SqlParameter("@ncorrel", SqlDbType.Decimal)
        args(12).Value = lEntidad.ncorrel
        args(13) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(13).Value = lEntidad.nnum
        args(14) = New SqlParameter("@llave", SqlDbType.VarChar)
        args(14).Value = lEntidad.llave
        args(15) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(15).Value = lEntidad.nombre
        args(16) = New SqlParameter("@apellido", SqlDbType.VarChar)
        args(16).Value = lEntidad.apellido
        args(17) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(17).Value = lEntidad.nsaldoaho
        args(18) = New SqlParameter("@nmonini", SqlDbType.Decimal)
        args(18).Value = lEntidad.nmonini
        args(19) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(19).Value = lEntidad.nmonapr
        args(20) = New SqlParameter("@nsaldnind", SqlDbType.Decimal)
        args(20).Value = lEntidad.nsaldnind
        args(21) = New SqlParameter("@nmonres", SqlDbType.Decimal)
        args(21).Value = lEntidad.nmonres
        args(22) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(22).Value = lEntidad.dfeccap
        args(23) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccodcli
        args(24) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(24).Value = lEntidad.producto
        args(25) = New SqlParameter("@cmotivo", SqlDbType.VarChar)
        args(25).Value = lEntidad.cmotivo
        args(26) = New SqlParameter("@despro", SqlDbType.VarChar)
        args(26).Value = lEntidad.despro
        args(27) = New SqlParameter("@sub_pro", SqlDbType.VarChar)
        args(27).Value = lEntidad.sub_pro
        args(28) = New SqlParameter("@dultmov", SqlDbType.Datetime)
        args(28).Value = lEntidad.dultmov
        args(29) = New SqlParameter("@notas", SqlDbType.VarChar)
        args(29).Value = lEntidad.notas
        args(30) = New SqlParameter("@dfechault", SqlDbType.Datetime)
        args(30).Value = lEntidad.dfechault
        args(31) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(31).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value,lEntidad.ccodaho)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomcta ")
        strSQL.Append(" ( ccodaho, ") 
        strSQL.Append(" cnrolin, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" cnudotr, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" cbloqueo, ") 
        strSQL.Append(" dfecini, ") 
        strSQL.Append(" dfecapr, ") 
        strSQL.Append(" dfecult, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" dfecfin, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" ncorrel, ") 
        strSQL.Append(" nnum, ") 
        strSQL.Append(" llave, ") 
        strSQL.Append(" nombre, ") 
        strSQL.Append(" apellido, ") 
        strSQL.Append(" nsaldoaho, ") 
        strSQL.Append(" nmonini, ") 
        strSQL.Append(" nmonapr, ") 
        strSQL.Append(" nsaldnind, ") 
        strSQL.Append(" nmonres, ") 
        strSQL.Append(" dfeccap, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" producto, ") 
        strSQL.Append(" cmotivo, ") 
        strSQL.Append(" despro, ") 
        strSQL.Append(" sub_pro, ") 
        strSQL.Append(" dultmov, ")
        strSQL.Append(" notas, ") 
        strSQL.Append(" dfechault) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodaho, ") 
        strSQL.Append(" @cnrolin, ") 
        strSQL.Append(" @ccodcta, ") 
        strSQL.Append(" @cnudotr, ") 
        strSQL.Append(" @nlibreta, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @cbloqueo, ") 
        strSQL.Append(" @dfecini, ") 
        strSQL.Append(" @dfecapr, ") 
        strSQL.Append(" @dfecult, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @dfecfin, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @ncorrel, ") 
        strSQL.Append(" @nnum, ") 
        strSQL.Append(" @llave, ") 
        strSQL.Append(" @nombre, ") 
        strSQL.Append(" @apellido, ") 
        strSQL.Append(" @nsaldoaho, ") 
        strSQL.Append(" @nmonini, ") 
        strSQL.Append(" @nmonapr, ") 
        strSQL.Append(" @nsaldnind, ") 
        strSQL.Append(" @nmonres, ") 
        strSQL.Append(" @dfeccap, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @producto, ") 
        strSQL.Append(" @cmotivo, ") 
        strSQL.Append(" @despro, ") 
        strSQL.Append(" @sub_pro, ") 
        strSQL.Append(" @dultmov, ")
        strSQL.Append(" @notas, ") 
        strSQL.Append(" @dfechault) ")

        Dim args(31) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(1) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnrolin
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodcta
        args(3) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnudotr
        args(4) = New SqlParameter("@nlibreta", SqlDbType.Decimal)
        args(4).Value = lEntidad.nlibreta
        args(5) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(5).Value = lEntidad.cestado
        args(6) = New SqlParameter("@cbloqueo", SqlDbType.VarChar)
        args(6).Value = lEntidad.cbloqueo
        args(7) = New SqlParameter("@dfecini", SqlDbType.Datetime)
        args(7).Value = lEntidad.dfecini
        args(8) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(8).Value = lEntidad.dfecapr
        args(9) = New SqlParameter("@dfecult", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecult
        args(10) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@dfecfin", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecfin
        args(12) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodusu
        args(13) = New SqlParameter("@ncorrel", SqlDbType.Decimal)
        args(13).Value = lEntidad.ncorrel
        args(14) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(14).Value = lEntidad.nnum
        args(15) = New SqlParameter("@llave", SqlDbType.VarChar)
        args(15).Value = lEntidad.llave
        args(16) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(16).Value = lEntidad.nombre
        args(17) = New SqlParameter("@apellido", SqlDbType.VarChar)
        args(17).Value = lEntidad.apellido
        args(18) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(18).Value = lEntidad.nsaldoaho
        args(19) = New SqlParameter("@nmonini", SqlDbType.Decimal)
        args(19).Value = lEntidad.nmonini
        args(20) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(20).Value = lEntidad.nmonapr
        args(21) = New SqlParameter("@nsaldnind", SqlDbType.Decimal)
        args(21).Value = lEntidad.nsaldnind
        args(22) = New SqlParameter("@nmonres", SqlDbType.Decimal)
        args(22).Value = lEntidad.nmonres
        args(23) = New SqlParameter("@dfeccap", SqlDbType.Datetime)
        args(23).Value = lEntidad.dfeccap
        args(24) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(24).Value = lEntidad.ccodcli
        args(25) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(25).Value = lEntidad.producto
        args(26) = New SqlParameter("@cmotivo", SqlDbType.VarChar)
        args(26).Value = lEntidad.cmotivo
        args(27) = New SqlParameter("@despro", SqlDbType.VarChar)
        args(27).Value = lEntidad.despro
        args(28) = New SqlParameter("@sub_pro", SqlDbType.VarChar)
        args(28).Value = lEntidad.sub_pro
        args(29) = New SqlParameter("@dultmov", SqlDbType.Datetime)
        args(29).Value = lEntidad.dultmov
        args(30) = New SqlParameter("@notas", SqlDbType.VarChar)
        args(30).Value = lEntidad.notas
        args(31) = New SqlParameter("@dfechault", SqlDbType.Datetime)
        args(31).Value = lEntidad.dfechault

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomcta ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnrolin = IIf(.Item("cnrolin") Is DBNull.Value, Nothing, .Item("cnrolin"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cnudotr = IIf(.Item("cnudotr") Is DBNull.Value, Nothing, .Item("cnudotr"))
                lEntidad.nlibreta = IIf(.Item("nlibreta") Is DBNull.Value, Nothing, .Item("nlibreta"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.cbloqueo = IIf(.Item("cbloqueo") Is DBNull.Value, Nothing, .Item("cbloqueo"))
                lEntidad.dfecini = IIf(.Item("dfecini") Is DBNull.Value, Nothing, .Item("dfecini"))
                lEntidad.dfecapr = IIf(.Item("dfecapr") Is DBNull.Value, Nothing, .Item("dfecapr"))
                lEntidad.dfecult = IIf(.Item("dfecult") Is DBNull.Value, Nothing, .Item("dfecult"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.dfecfin = IIf(.Item("dfecfin") Is DBNull.Value, Nothing, .Item("dfecfin"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.ncorrel = IIf(.Item("ncorrel") Is DBNull.Value, Nothing, .Item("ncorrel"))
                lEntidad.nnum = IIf(.Item("nnum") Is DBNull.Value, Nothing, .Item("nnum"))
                lEntidad.llave = IIf(.Item("llave") Is DBNull.Value, Nothing, .Item("llave"))
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.apellido = IIf(.Item("apellido") Is DBNull.Value, Nothing, .Item("apellido"))
                lEntidad.nsaldoaho = IIf(.Item("nsaldoaho") Is DBNull.Value, Nothing, .Item("nsaldoaho"))
                lEntidad.nmonini = IIf(.Item("nmonini") Is DBNull.Value, Nothing, .Item("nmonini"))
                lEntidad.nmonapr = IIf(.Item("nmonapr") Is DBNull.Value, Nothing, .Item("nmonapr"))
                lEntidad.nsaldnind = IIf(.Item("nsaldnind") Is DBNull.Value, Nothing, .Item("nsaldnind"))
                lEntidad.nmonres = IIf(.Item("nmonres") Is DBNull.Value, Nothing, .Item("nmonres"))
                lEntidad.dfeccap = IIf(.Item("dfeccap") Is DBNull.Value, Nothing, .Item("dfeccap"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.producto = IIf(.Item("producto") Is DBNull.Value, Nothing, .Item("producto"))
                lEntidad.cmotivo = IIf(.Item("cmotivo") Is DBNull.Value, Nothing, .Item("cmotivo"))
                lEntidad.despro = IIf(.Item("despro") Is DBNull.Value, Nothing, .Item("despro"))
                lEntidad.sub_pro = IIf(.Item("sub_pro") Is DBNull.Value, Nothing, .Item("sub_pro"))
                lEntidad.dultmov = IIf(.Item("dultmov") Is DBNull.Value, Nothing, .Item("dultmov"))
                lEntidad.notas = IIf(.Item("notas") Is DBNull.Value, Nothing, .Item("notas"))
                lEntidad.dfechault = IIf(.Item("dfechault") Is DBNull.Value, Nothing, .Item("dfechault"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomcta
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodaho),0) + 1 ")
        strSQL.Append(" FROM ahomcta ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerID_tipo(ByVal tipo As String, ByVal lccodofi As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT max(ccodaho) as codigo ")
        strSQL.Append(" FROM ahomcta")
        strSQL.Append(" WHERE substring(ahomcta.ccodaho,7,2) = @tipo and SUBSTRING(ahomcta.ccodaho,4,3) = @oficina")

        Dim ds As DataSet
        Dim lccodigo As String
        Dim lncodigo As Double

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@tipo", SqlDbType.VarChar)
        args(0).Value = tipo

        args(1) = New SqlParameter("@oficina", SqlDbType.VarChar)
        args(1).Value = lccodofi

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

            If ds.Tables(0).Rows.Count > 0 Then
                If IsDBNull(ds.Tables(0).Rows(0)("codigo")) Then
                    lccodigo = "001" + lccodofi + tipo + "000001"
                Else
                    lccodigo = ds.Tables(0).Rows(0)("codigo")
                    lncodigo = Double.Parse(lccodigo) + 1
                    lccodigo = "00" & lncodigo.ToString.Trim

                End If
            Else
                lccodigo = "001" + lccodofi + tipo + "000001"
            End If
        Catch ex As Exception
            Throw ex
        End Try
        ds.Clear()

        Return lccodigo

    End Function


    Public Function ObtenerListaPorID() As listaahomcta

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaahomcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomcta
                mEntidad.ccodaho = IIf(dr("ccodaho") Is DBNull.Value, Nothing, dr("ccodaho"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.nlibreta = IIf(dr("nlibreta") Is DBNull.Value, Nothing, dr("nlibreta"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.cbloqueo = IIf(dr("cbloqueo") Is DBNull.Value, Nothing, dr("cbloqueo"))
                mEntidad.dfecini = IIf(dr("dfecini") Is DBNull.Value, Nothing, dr("dfecini"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecult = IIf(dr("dfecult") Is DBNull.Value, Nothing, dr("dfecult"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.dfecfin = IIf(dr("dfecfin") Is DBNull.Value, Nothing, dr("dfecfin"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.ncorrel = IIf(dr("ncorrel") Is DBNull.Value, Nothing, dr("ncorrel"))
                mEntidad.nnum = IIf(dr("nnum") Is DBNull.Value, Nothing, dr("nnum"))
                mEntidad.llave = IIf(dr("llave") Is DBNull.Value, Nothing, dr("llave"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                mEntidad.apellido = IIf(dr("apellido") Is DBNull.Value, Nothing, dr("apellido"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.nmonini = IIf(dr("nmonini") Is DBNull.Value, Nothing, dr("nmonini"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nsaldnind = IIf(dr("nsaldnind") Is DBNull.Value, Nothing, dr("nsaldnind"))
                mEntidad.nmonres = IIf(dr("nmonres") Is DBNull.Value, Nothing, dr("nmonres"))
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.cmotivo = IIf(dr("cmotivo") Is DBNull.Value, Nothing, dr("cmotivo"))
                mEntidad.despro = IIf(dr("despro") Is DBNull.Value, Nothing, dr("despro"))
                mEntidad.sub_pro = IIf(dr("sub_pro") Is DBNull.Value, Nothing, dr("sub_pro"))
                mEntidad.dultmov = IIf(dr("dultmov") Is DBNull.Value, Nothing, dr("dultmov"))
                mEntidad.notas = IIf(dr("notas") Is DBNull.Value, Nothing, dr("notas"))
                mEntidad.dfechault = IIf(dr("dfechault") Is DBNull.Value, Nothing, dr("dfechault"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerListaahoporcliente(ByVal ccodcli As String) As listaahomcta
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE ccodcli = @ccodcli")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaahomcta

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomcta
                mEntidad.ccodaho = IIf(dr("ccodaho") Is DBNull.Value, Nothing, dr("ccodaho"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cnudotr = IIf(dr("cnudotr") Is DBNull.Value, Nothing, dr("cnudotr"))
                mEntidad.nlibreta = IIf(dr("nlibreta") Is DBNull.Value, Nothing, dr("nlibreta"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.cbloqueo = IIf(dr("cbloqueo") Is DBNull.Value, Nothing, dr("cbloqueo"))
                mEntidad.dfecini = IIf(dr("dfecini") Is DBNull.Value, Nothing, dr("dfecini"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecult = IIf(dr("dfecult") Is DBNull.Value, Nothing, dr("dfecult"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.dfecfin = IIf(dr("dfecfin") Is DBNull.Value, Nothing, dr("dfecfin"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.ncorrel = IIf(dr("ncorrel") Is DBNull.Value, Nothing, dr("ncorrel"))
                mEntidad.nnum = IIf(dr("nnum") Is DBNull.Value, Nothing, dr("nnum"))
                mEntidad.llave = IIf(dr("llave") Is DBNull.Value, Nothing, dr("llave"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                mEntidad.apellido = IIf(dr("apellido") Is DBNull.Value, Nothing, dr("apellido"))
                mEntidad.nsaldoaho = IIf(dr("nsaldoaho") Is DBNull.Value, Nothing, dr("nsaldoaho"))
                mEntidad.nmonini = IIf(dr("nmonini") Is DBNull.Value, Nothing, dr("nmonini"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nsaldnind = IIf(dr("nsaldnind") Is DBNull.Value, Nothing, dr("nsaldnind"))
                mEntidad.nmonres = IIf(dr("nmonres") Is DBNull.Value, Nothing, dr("nmonres"))
                mEntidad.dfeccap = IIf(dr("dfeccap") Is DBNull.Value, Nothing, dr("dfeccap"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.producto = IIf(dr("producto") Is DBNull.Value, Nothing, dr("producto"))
                mEntidad.cmotivo = IIf(dr("cmotivo") Is DBNull.Value, Nothing, dr("cmotivo"))
                mEntidad.despro = IIf(dr("despro") Is DBNull.Value, Nothing, dr("despro"))
                mEntidad.sub_pro = IIf(dr("sub_pro") Is DBNull.Value, Nothing, dr("sub_pro"))
                mEntidad.dultmov = IIf(dr("dultmov") Is DBNull.Value, Nothing, dr("dultmov"))
                mEntidad.notas = IIf(dr("notas") Is DBNull.Value, Nothing, dr("notas"))
                mEntidad.dfechault = IIf(dr("dfechault") Is DBNull.Value, Nothing, dr("dfechault"))
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
        tables(0) = New String("ahomcta")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodaho, ")
        strSQL.Append(" cnrolin, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" cnudotr, ")
        strSQL.Append(" nlibreta, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" cbloqueo, ")
        strSQL.Append(" dfecini, ")
        strSQL.Append(" dfecapr, ")
        strSQL.Append(" dfecult, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" dfecfin, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" ncorrel, ")
        strSQL.Append(" nnum, ")
        strSQL.Append(" llave, ")
        strSQL.Append(" nombre, ")
        strSQL.Append(" apellido, ")
        strSQL.Append(" nsaldoaho, ")
        strSQL.Append(" nmonini, ")
        strSQL.Append(" nmonapr, ")
        strSQL.Append(" nsaldnind, ")
        strSQL.Append(" nmonres, ")
        strSQL.Append(" dfeccap, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" producto, ")
        strSQL.Append(" cmotivo, ")
        strSQL.Append(" despro, ")
        strSQL.Append(" sub_pro, ")
        strSQL.Append(" dultmov, ")
        strSQL.Append(" notas, ")
        strSQL.Append(" dfechault ")
        strSQL.Append(" FROM ahomcta ")

    End Sub

    Public Function busquedactaahorro(ByVal cnombre As String, ByVal lctipbus As Boolean) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ahomcta.ccodaho as codigo, '                     ' as tipo, climide.cnomcli, ahomcta.nsaldoaho, ahomcta.producto ")
        strSQL.Append(" FROM ahomcta, climide")
        strSQL.Append(" WHERE ahomcta.ccodcli = climide.ccodcli and ")
        strSQL.Append("( CLIMIDE.ccodcli like " & "'" & "%" & cnombre & "%" & "' ")
        strSQL.Append(" or CLIMIDE.cnomcli like " & "'" & "%" & cnombre & "%" & "' )")



        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    'busqueda de cuenta de ahorro por cuenta y tipo de ahorro
    Public Function cuentaahorrotipo(ByVal ccodcli1 As String, ByVal ctipo As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ahomcta.ccodaho ")
        strSQL.Append(" FROM ahomcta")
        strSQL.Append(" WHERE ahomcta.cnudotr = @ccodcli1 ")
        strSQL.Append(" and substring(ccodaho,7,2) = @ctipo")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli1", SqlDbType.VarChar)
        args(0).Value = ccodcli1
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo

        Dim ds As DataSet
        Dim cuenta As String

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count >= 1 Then
                cuenta = ds.Tables(0).Rows(0)("ccodaho")
            Else
                cuenta = "*"
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return cuenta

    End Function


    Public Function Obtenerdatasetporcuenta(ByVal ccodaho As String) As DataSet

        'Dim lEntidad As ahomcta
        'lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ahomcta.ccodaho, ahomcta.ccodcli, ahomcta.nsaldoaho, ahommov.nmonto, ahommov.dfecope, ahommov.ctipope, ahommov.nsaldoaho as nsaldoaho1, climide.cnomcli ")
        strSQL.Append(" FROM ahomcta, ahommov, climide")
        strSQL.Append(" WHERE ahomcta.ccodaho = ahommov.ccodaho and ahomcta.ccodcli = climide.ccodcli ")
        strSQL.Append(" and ahomcta.ccodaho = @ccodaho")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    'obtiene ds para grid de liquidacion
    Public Function Obtenerdatasetporcliente(ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ahomcta.ccodaho, tabttab.cdescri as ctipo, ahomcta.nsaldoaho,ahomcta.ccodaho as codigo")
        strSQL.Append(" FROM ahomcta, climide, tabttab")
        strSQL.Append(" WHERE ahomcta.ccodcli = climide.ccodcli and ltrim(ahomcta.producto) = ltrim(tabttab.ccodigo) and ltrim(tabttab.ccodtab) = " & "189")
        strSQL.Append(" and climide.ccodcli = @ccodcli")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtieneBeneficiarios(ByVal cCodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT AHOMBEN.CNOMBEN, AHOMBEN.DFECNAC,AHOMBEN.NPORCEN, AHOMBEN.cdirben, PARENT.CDESCRI ")
        strSQL.Append(" FROM AHOMBEN,AHOMCTA,PARENT ")
        strSQL.Append(" WHERE AHOMCTA.CNUDOTR = @ccodcli AND substring(ahomcta.ccodaho,7,2) = '02' ")
        strSQL.Append(" AND AHOMCTA.CCODAHO = AHOMBEN.CCODAHO and AHOMBEN.CPARENT = PARENT.CPARENT ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtieneBeneficiarios2(ByVal cCodaho As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT AHOMBEN.CNOMBEN, AHOMBEN.DFECNAC,AHOMBEN.NPORCEN, AHOMBEN.cdirben, PARENT.CDESCRI ")
        strSQL.Append(" FROM AHOMBEN,AHOMCTA,PARENT ")
        strSQL.Append(" WHERE AHOMCTA.ccodaho = @ccodaho AND substring(ahomcta.ccodaho,7,2) = '02' ")
        strSQL.Append(" AND AHOMCTA.CCODAHO = AHOMBEN.CCODAHO and AHOMBEN.CPARENT = PARENT.CPARENT ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = cCodaho
        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function ObtieneCuentaAhorro(ByVal ccodaho As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT ahomcta.*, climide.cnomcli, ahotlin.ntasint, CLIMIDE.CCODDOM, climide.dnacimi, climide.ccodcli, ")
        strSQL.Append(" climide.cnudoci, climide.cdirdom, climide.cestciv, climide.cteldom, climide.cteltralab, climide.cdirfue ")
        strSQL.Append(" FROM ahomcta, climide, ahotlin ")
        strSQL.Append(" WHERE ahomcta.cnrolin = ahotlin.cnrolin and ")
        strSQL.Append(" ahomcta.cnudotr = climide.ccodcli and ")
        strSQL.Append(" ahomcta.ccodaho = @ccodaho ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho
        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function Aportaciones(ByVal ccodcli As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT nsaldoaho FROM AHOMCTA ")
        strSQL.Append("WHERE cnudotr = @ccodcli and substring(cCodaho, 7,2) = '06' ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        Dim lnaportacion As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nsaldoaho")) Then
            Else
                lnaportacion = ds.Tables(0).Rows(0)("nsaldoaho")
            End If

        End If
        Return Math.Round(lnaportacion, 2)
    End Function

    Public Function AportacionesRestringidas(ByVal ccodcli As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SUM(crepgar.nmongar) as gravados ")
        strSQL.Append("FROM cremcre, crepgar ")
        strSQL.Append("WHERE cremcre.ccodcta = crepgar.ccodcta and cremcre.cestado ='F' ")
        strSQL.Append("and cremcre.ccodcli = @ccodcli and cremcre.ctipgar in ('04','13', '14') ")
        strSQL.Append("group by cremcre.ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        Dim lnaportares As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            If IsDBNull(ds.Tables(0).Rows(0)("gravados")) Then
            Else
                lnaportares = ds.Tables(0).Rows(0)("gravados")
            End If

        End If
        Return Math.Round(lnaportares, 2)
    End Function

    Public Function ObtenerDataAportacion() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM APORTACION")
        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtieneFechaIngreso(ByVal cCodcli As String, ByVal ctipo As String) As Date
        Dim strSQL As New StringBuilder
        strSQL.Append("select min(ahommov.dfecope) as  fecha_ing from ahomcta, ahommov ")
        strSQL.Append("where ahomcta.cnudotr = @ccodcli and substring(ahomcta.ccodaho,7,2) = @ctipo ")
        strSQL.Append("and ahomcta.ccodaho = ahommov.ccodaho  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        Dim ldfecing As Date = Now

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("fecha_ing")) Then
            Else
                ldfecing = ds.Tables(0).Rows(0)("fecha_ing")
            End If
        End If

        Return ldfecing
    End Function

    Public Function condonacionAportaciones(ByVal ccodcli As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("Select mora FROM condonacion_mora WHERE ccodcli = @ccodcli ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        Dim lncondonar As Decimal = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("mora")) Then
            Else
                lncondonar = ds.Tables(0).Rows(0)("mora")
            End If
        End If

        Return lncondonar
    End Function


    Public Function ObtenerCuentasAhorro(ByVal ccodcli As String, ByVal ctipo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT (ahomcta.ccodaho+ ' ' + producto) as cuenta, ccodaho FROM AHOMCTA ")
        strSQL.Append("WHERE substring(ahomcta.ccodaho,7,2) = @ctipo and cnudotr = @ccodcli ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

    Public Function VerificaExistenciadeCuentas(ByVal ccodcli As String, ByVal ctipo As String, ByVal cestado As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodaho FROM AHOMCTA ")
        strSQL.Append("WHERE substring(ahomcta.ccodaho,7,2) = @ctipo and cnudotr = @ccodcli ")
        strSQL.Append("and cestado = @cestado")


        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = cestado


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Dim lverifica As Boolean = False

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodaho")) Then
            Else
                lverifica = True
            End If
        End If

        Return lverifica
    End Function
    '----------------------------------------------------------------------------------------
    Public Function ObtieneCodigodeCuentas(ByVal ccodcli As String, ByVal ctipo As String, ByVal cestado As String, ByVal ccodaho As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodaho FROM AHOMCTA ")
        strSQL.Append("WHERE ")

        If ccodaho.Trim = "" Then 'cuando el tipo de cuenta es unica para el cliente
            strSQL.Append("substring(ahomcta.ccodaho,7,2) = @ctipo and cnudotr = @ccodcli ")
            strSQL.Append("and cestado = @cestado ")
        Else 'Buscara la cuenta especifica
            strSQL.Append("ccodaho = @ccodaho ")
        End If

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = cestado
        args(3) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(3).Value = ccodaho


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

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


    Public Function ObtieneSaldodeCuenta(ByVal ccodaho As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nsaldoaho FROM AHOMCTA ")
        strSQL.Append("WHERE ")
        strSQL.Append("ccodaho = @ccodaho ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Dim lnsaldoaho As Double = 0

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nsaldoaho")) Then
            Else
                lnsaldoaho = ds.Tables(0).Rows(0)("nsaldoaho")
            End If
        End If


        Return lnsaldoaho
    End Function


    Public Function ActualizaSaldodeCuenta(ByVal ccodaho As String, ByVal nsaldo As Double, ByVal nnum As Integer) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE AHOMCTA SET nsaldoaho = @nsaldo, nnum = @nnum, ncorrel = @nnum ")
        strSQL.Append("WHERE ccodaho = @ccodaho ")



        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho
        args(1) = New SqlParameter("@nsaldo", SqlDbType.Decimal)
        args(1).Value = nsaldo
        args(2) = New SqlParameter("@nnum", SqlDbType.Int)
        args(2).Value = nnum

        Dim ds As New DataSet


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function

    '------------------------------------------------------------
    Public Function ActualizarenDesembolso(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomcta
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodaho = "" _
            Or lEntidad.ccodaho = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodaho = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomcta ")
        strSQL.Append(" SET cnrolin = @cnrolin, ")
        strSQL.Append(" ccodcta = @ccodcta, ")
        strSQL.Append(" cnudotr = @cnudotr, ")
        strSQL.Append(" dfecapr = @dfecapr, ")
        strSQL.Append(" dfechault = @dfechault, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" nnum = @nnum, ")
        strSQL.Append(" llave = @llave, ")
        strSQL.Append(" nombre = @nombre, ")
        strSQL.Append(" nsaldoaho = @nsaldoaho, ")
        strSQL.Append(" nmonapr = @nmonapr, ")
        strSQL.Append(" nsaldnind = @nsaldnind, ")
        strSQL.Append(" nmonres = @nmonres, ")
        strSQL.Append(" cmotivo = @cmotivo ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ")

        Dim args(31) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin
        args(1) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcta
        args(2) = New SqlParameter("@cnudotr", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnudotr
        args(3) = New SqlParameter("@nlibreta", SqlDbType.Decimal)
        args(3).Value = lEntidad.nlibreta
        args(4) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(4).Value = lEntidad.cestado
        args(5) = New SqlParameter("@cbloqueo", SqlDbType.VarChar)
        args(5).Value = lEntidad.cbloqueo
        args(6) = New SqlParameter("@dfecini", SqlDbType.DateTime)
        args(6).Value = lEntidad.dfecini
        args(7) = New SqlParameter("@dfecapr", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecapr
        args(8) = New SqlParameter("@dfecult", SqlDbType.DateTime)
        args(8).Value = lEntidad.dfecult
        args(9) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(9).Value = lEntidad.dfecmod
        args(10) = New SqlParameter("@dfecfin", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecfin
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu
        args(12) = New SqlParameter("@ncorrel", SqlDbType.Decimal)
        args(12).Value = lEntidad.ncorrel
        args(13) = New SqlParameter("@nnum", SqlDbType.Decimal)
        args(13).Value = lEntidad.nnum
        args(14) = New SqlParameter("@llave", SqlDbType.VarChar)
        args(14).Value = lEntidad.llave
        args(15) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(15).Value = lEntidad.nombre
        args(16) = New SqlParameter("@apellido", SqlDbType.VarChar)
        args(16).Value = lEntidad.apellido
        args(17) = New SqlParameter("@nsaldoaho", SqlDbType.Decimal)
        args(17).Value = lEntidad.nsaldoaho
        args(18) = New SqlParameter("@nmonini", SqlDbType.Decimal)
        args(18).Value = lEntidad.nmonini
        args(19) = New SqlParameter("@nmonapr", SqlDbType.Decimal)
        args(19).Value = lEntidad.nmonapr
        args(20) = New SqlParameter("@nsaldnind", SqlDbType.Decimal)
        args(20).Value = lEntidad.nsaldnind
        args(21) = New SqlParameter("@nmonres", SqlDbType.Decimal)
        args(21).Value = lEntidad.nmonres
        args(22) = New SqlParameter("@dfeccap", SqlDbType.DateTime)
        args(22).Value = lEntidad.dfeccap
        args(23) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(23).Value = lEntidad.ccodcli
        args(24) = New SqlParameter("@producto", SqlDbType.VarChar)
        args(24).Value = lEntidad.producto
        args(25) = New SqlParameter("@cmotivo", SqlDbType.VarChar)
        args(25).Value = lEntidad.cmotivo
        args(26) = New SqlParameter("@despro", SqlDbType.VarChar)
        args(26).Value = lEntidad.despro
        args(27) = New SqlParameter("@sub_pro", SqlDbType.VarChar)
        args(27).Value = lEntidad.sub_pro
        args(28) = New SqlParameter("@dultmov", SqlDbType.DateTime)
        args(28).Value = lEntidad.dultmov
        args(29) = New SqlParameter("@notas", SqlDbType.VarChar)
        args(29).Value = lEntidad.notas
        args(30) = New SqlParameter("@dfechault", SqlDbType.DateTime)
        args(30).Value = lEntidad.dfechault
        args(31) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(31).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerCuentas(ByVal cCodcli As String, ByVal ctipo As String, ByVal cahorro As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT (@cahorro + ' '+ccodaho+' '+nombre + ' ' + str(nsaldoaho)) as ccodigo , nsaldoaho, nombre,  ' ' as cpignor, AHOMCTA.CCODAHO ")
        strSQL.Append("FROM AHOMCTA ")
        strSQL.Append("WHERE cnudotr = @ccodcli ")
        strSQL.Append(" and substring(ahomcta.ccodaho,7,2) = @ctipo ")



        Dim ds As New DataSet
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo
        args(2) = New SqlParameter("@cahorro", SqlDbType.VarChar)
        args(2).Value = cahorro

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerCuentas2(ByVal cCodcli As String, ByVal ctipo As String, ByVal cahorro As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT (@cahorro + ' ' +nombre+ ' ' +  ccodaho+' '+str(nsaldoaho)) as ccodigo, nsaldoaho, nombre,  ' ' as cpignor, AHOMCTA.CCODAHO ")
        strSQL.Append("FROM AHOMCTA, AHOTLIN ")
        strSQL.Append("WHERE ahomcta.cnrolin = ahotlin.cnrolin and substring(ahotlin.ccodlin,4,2) = @ctipo and cnudotr = @ccodcli ")

        Dim ds As New DataSet
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = cCodcli
        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo
        args(2) = New SqlParameter("@cahorro", SqlDbType.VarChar)
        args(2).Value = cahorro

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds


    End Function

    Public Function ObtieneMontodeAhorro(ByVal cCodaho As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT nmonapr FROM AHOMCTA ")
        strSQL.Append("WHERE cCodaho = @cCodaho ")

        Dim ds As New DataSet
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = cCodaho


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


    Public Function ActualizaBloqueoCuenta(ByVal cCodaho As String, ByVal cbloqueo As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE AHOMCTA SET cbloqueo = @cbloqueo WHERE cCodaho = @cCodaho ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = cCodaho
        args(1) = New SqlParameter("@cbloqueo", SqlDbType.VarChar)
        args(1).Value = cbloqueo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function

    Public Function ObtieneSaldo(ByVal ccodcli As String, ByVal ctipo As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT sum(nsaldoaho) as nsaldoaho FROM AHOMCTA ")
        strSQL.Append("WHERE cnudotr = @ccodcli and substring(cCodaho, 7,2) = @ctipo group by cnudotr")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        args(1) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(1).Value = ctipo


        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        Dim lnsaldo As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nsaldoaho")) Then
            Else
                lnsaldo = ds.Tables(0).Rows(0)("nsaldoaho")
            End If

        End If
        Return Math.Round(lnsaldo, 2)
    End Function

    Public Function Haberes(ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodana As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select climide.ccodcli, climide.cnomcli,  ")
        strSQL.Append("case when (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) is null then 0 else (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) end as plazo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as simultaneo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as vista,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as navideño,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as educativo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as menores,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as aportaciones  ")
        strSQL.Append("from climide , cremcre  ")
        strSQL.Append("where cremcre.ccodcli = climide.ccodcli and cremcre.cestado ='F'  ")
        strSQL.Append("and cremcre.ccodana = @ccodana   ")
        strSQL.Append("and cremcre.ndiaatr >= @ndesde and cremcre.ndiaatr <= @nhasta ")
        strSQL.Append("group by climide.ccodcli, climide.cnomcli  ")
        strSQL.Append("having  (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0   ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("order by climide.cnomcli	  ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ndesde", SqlDbType.Int)
        args(0).Value = ndesde
        args(1) = New SqlParameter("@nhasta", SqlDbType.Int)
        args(1).Value = nhasta
        args(2) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(2).Value = ccodana

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function Haberes_Individual(ByVal ndesde As Integer, ByVal nhasta As Integer, ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select climide.ccodcli, climide.cnomcli,  ")
        strSQL.Append("case when (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) is null then 0 else (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) end as plazo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as simultaneo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as vista,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as navideño,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as educativo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as menores,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as aportaciones  ")
        strSQL.Append("from climide , cremcre  ")
        strSQL.Append("where cremcre.ccodcli = climide.ccodcli and cremcre.cestado ='F'  ")
        strSQL.Append("and cremcre.ccodcta = @ccodcta   ")
        strSQL.Append("and cremcre.ndiaatr >= @ndesde and cremcre.ndiaatr <= @nhasta ")
        strSQL.Append("group by climide.ccodcli, climide.cnomcli  ")
        strSQL.Append("having  (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0   ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("or (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) > 0  ")
        strSQL.Append("order by climide.cnomcli	  ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ndesde", SqlDbType.Int)
        args(0).Value = ndesde
        args(1) = New SqlParameter("@nhasta", SqlDbType.Int)
        args(1).Value = nhasta
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = ccodcta

        Dim ds As New DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function Haberesxcliente(ByVal ccodcli As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("select  ")
        strSQL.Append("case when (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) is null then 0 else (select SUM(ahomcrt.nmonapr) from ahomcrt where climide.ccodcli = ahomcrt.cnudotr and ahomcrt.cliq <> 'S' group by ahomcrt.cnudotr) end as plazo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '01' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as simultaneo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '02' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as vista,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '03' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as navideño,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '04' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as educativo,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '05' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as menores,  ")
        strSQL.Append("case when (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) is null then 0 else (select SUM(ahomcta.nsaldoaho) from ahomcta where climide.ccodcli = ahomcta.cnudotr and ahomcta.cestado = 'A' and SUBSTRING(ahomcta.ccodaho,7,2) = '06' and ahomcta.nsaldoaho > 0 group by ahomcta.cnudotr) end as aportaciones  ")
        strSQL.Append("from climide   ")
        strSQL.Append("where climide.ccodcli = @ccodcli  ")
        strSQL.Append("group by climide.ccodcli  ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As New DataSet
        Dim lnhaberes As Decimal = 0

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Throw ex
        End Try
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lnhaberes = ds.Tables(0).Rows(0)("plazo") + _
                        ds.Tables(0).Rows(0)("simultaneo") + _
                        ds.Tables(0).Rows(0)("vista") + _
                        ds.Tables(0).Rows(0)("navideño") + _
                        ds.Tables(0).Rows(0)("educativo") + _
                        ds.Tables(0).Rows(0)("menores") + _
                        ds.Tables(0).Rows(0)("aportaciones")
        End If

        Return lnhaberes
    End Function



    ''' <summary>
    ''' Obtiene Cuentas de Ahorro por cliente
    ''' </summary>
    ''' <param name="ccodcli"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtieneCuentasxCliente(ByVal ccodcli As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodaho from ahomcta ")
        strSQL.Append("where cnudotr = @ccodcli ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function


    Public Function Extraer_Sumario_Ahorros() As DataSet

        Dim command As New SqlCommand
        Dim MyAdapter As New SqlDataAdapter
        Dim ds_Aho As New DataSet

        Using conection As New SqlConnection(Me.cnnStr)
            conection.Open()
            command.Connection = conection

            Try

                command.CommandText = _
                                        " Select sum(cta.nsaldoaho) as saldo, count(cta.ccodaho) as casos, tab.cdescri, " & _
                                        " substring(lin.ccodlin,5,1) as linea from ahomcta as cta " & _
                                        " inner join ahotlin as lin " & _
                                        " on substring(cta.ccodaho,7,2) = substring(lin.cnrolin,4,2) " & _
                                        " inner join tabttab as tab " & _
                                        " on tab.ccodigo = substring(lin.ccodlin,4,2) " & _
                                        " where tab.ccodtab = '186' and  tab.ctipreg = '1' and cta.nsaldoaho > 0 AND  " & _
                                        " tab.ccodigo <> '07' group by tab.cdescri, substring(lin.ccodlin,5,1)"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Aho, "Sumario")

            Catch ex As Exception
                Console.WriteLine("Ocurrio un Error", ex.Message.ToString)
            Finally
                conection.Close()
            End Try


        End Using

        Return ds_Aho

    End Function



    Public Function Mantenimiento_Cta_Ahorro(ByVal Detalle_Cta As ArrayList, ByVal dt_ben As DataTable, _
                                             ByVal dt_firm As DataTable) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Ofi As New DataSet
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcCtas_Aho As String
        Dim ccrefun As New dbCntamov
        Dim lnlibreta As Integer = 0


        'Detalle_Cta.Item(0)        'Nombre del Titular
        'Detalle_Cta.Item(1)        'Codigo del Titular
        'Detalle_Cta.Item(2)        'No Cta de Ahorro
        'Detalle_Cta.Item(3)        'Fecha
        'Detalle_Cta.Item(4)        'No de Libreta
        'Detalle_Cta.Item(5)        'Tipo de Ahorro
        'Detalle_Cta.Item(6)        'Linea de Ahorro
        'Detalle_Cta.Item(7)        'Oficina
        'Detalle_Cta.Item(8)        'Fecha de Modificación
        'Detalle_Cta.Item(9)        'Usuario
        'Detalle_Cta.Item(10)       'Nombres
        'Detalle_Cta.Item(11)       'Apellidos


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try


                'Primero valida el numero de Libreta

                'If Detalle_Cta.Item(2).ToString.Trim.Length = 0 Then 'Nueva Cta. Ahorro

                '    '' Extrae numero de Libreta
                '    command.CommandText = _
                '                            " Select ccodofi, ndesde, nhasta, nlibreta from libretas_agencia " & _
                '                            " Where cestado = '01' and ccodofi = '" & Detalle_Cta.Item(7) & "'"


                '    command.CommandType = CommandType.Text

                '    MyAdapter.SelectCommand = command

                '    MyAdapter.Fill(ds_Ofi, "No_Libreta")


                '    If ds_Ofi.Tables("No_Libreta").Rows.Count = 0 Then
                '        lnRetorno = 2
                '    End If

                '    For Each fila As DataRow In ds_Ofi.Tables("No_Libreta").Rows
                '        lnlibreta = fila("nlibreta") + 1
                '        Detalle_Cta.Item(4) = lnlibreta

                '        If lnlibreta > fila("nhasta") Then
                '            lnRetorno = 2
                '        End If
                '    Next

                'End If


                'If lnRetorno = 2 And Detalle_Cta.Item(2).ToString.Trim.Length = 0 Then
                '    Return lnRetorno
                'End If

                If Detalle_Cta.Item(2).ToString.Trim.Length = 0 Then 'Nueva Cta. Ahorro

                    command.CommandText = _
                                            " Select isnull(max(RIGHT(CCODAHO,6))+1,1) as Contador From Ahomcta " & _
                                            " Where substring(ahomcta.ccodaho,7,2) = '" & Detalle_Cta.Item(5) & "'"

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Ofi, "Ctas_Ahorro")


                    For Each fila As DataRow In ds_Ofi.Tables("Ctas_Ahorro").Rows
                        lcCtas_Aho = fila("contador").ToString.Trim
                    Next

                    i = Double.Parse(lcCtas_Aho)

                    lcCtas_Aho = ccrefun.fxStrZero(i, 6)

                    lcCtas_Aho = "001" & Detalle_Cta.Item(7) & Detalle_Cta.Item(5) + lcCtas_Aho


                    command.CommandText = _
                                            " Insert Into Ahomcta (ccodaho, cnrolin, ccodcta, cnudotr, nlibreta, " & _
                                            " cestado, cbloqueo, dfecini, dfecapr, dfecult, dfecmod, ccodusu, ncorrel, " & _
                                            " nnum, llave, nombre, apellido, nsaldoaho, nmonini," & _
                                            " nmonapr, nsaldnind, nmonres, producto, dfeccap, dultmov, dfechault, dfecfin) " & _
                                            " Values('" & lcCtas_Aho & "','" & Detalle_Cta.Item(6) & "','','" & Detalle_Cta.Item(1) & "',1," & _
                                            " 'A','','" & Detalle_Cta.Item(3) & "','" & Detalle_Cta.Item(3) & "','" & Detalle_Cta.Item(3) & "',getdate(),'" & Detalle_Cta.Item(9) & "',0," & _
                                            " 0,0,'" & Detalle_Cta.Item(10) & "','" & Detalle_Cta.Item(11) & "',0,0," & _
                                            " 0,0,0,'" & Detalle_Cta.Item(5) & "','" & Detalle_Cta.Item(3) & "','" & Detalle_Cta.Item(3) & "','" & _
                                            Detalle_Cta.Item(3) & "','" & Detalle_Cta.Item(3) & "')"


                    command.ExecuteNonQuery()


                    Detalle_Cta.Item(2) = lcCtas_Aho


                    'Actualiza el numero de libreta
                    command.CommandText = _
                                            " Update libretas_agencia set nlibreta = nlibreta + 1, dfecmod =getdate(), ccodusu ='" & Detalle_Cta.Item(9) & "'" & _
                                            " Where cestado = '01' and ccodofi = '" & Detalle_Cta.Item(7) & "'"

                    command.ExecuteNonQuery()


                    'Inserta Correlativo de Libreta
                    command.CommandText = _
                                           " Insert into Ahomlib (ccodaho, nlibreta, cestado, dfeccan, crazon, dfecapr, dfecmod, ccodusu) " & _
                                           " values('" & Detalle_Cta.Item(2) & "'," & Detalle_Cta.Item(4) & ",'A','" & Detalle_Cta.Item(3) & "','1','" & _
                                           Detalle_Cta.Item(3) & "', getdate(),'" & Detalle_Cta.Item(9) & "')"

                    command.ExecuteNonQuery()

                Else                        'Actualiza Cta de Ahorros

                    'command.CommandText = _
                    '                        " Update Ahomcta set cnrolin ='" & Detalle_Cta.Item(18) & "',nombre ='" & Detalle_Cta.Item(0) & "', cnudotr ='" & _
                    '                        Detalle_Cta.Item(1) & "', nmonapr =" & Detalle_Cta.Item(2) & ", ntasint =" & Detalle_Cta.Item(4) & ", nplazo =" & _
                    '                        Detalle_Cta.Item(6) & " , nintere =" & Detalle_Cta.Item(9) & " , dfecapr='" & Detalle_Cta.Item(10) & "', dfecven ='" & _
                    '                        Detalle_Cta.Item(11) & "', dfecprv ='" & Detalle_Cta.Item(10) & "', dfecori ='" & Detalle_Cta.Item(10) & "',dfecliq ='" & _
                    '                        Detalle_Cta.Item(11) & "', dfecmod ='" & Detalle_Cta.Item(16) & "', ccodusu='" & Detalle_Cta.Item(17) & "', nsaldoaho =" & _
                    '                        Detalle_Cta.Item(2) & ", dfeccap ='" & Detalle_Cta.Item(11) & "', dmenpro ='" & Detalle_Cta.Item(10) & "', dultpro='" & _
                    '                        Detalle_Cta.Item(10) & "', cprocedencia='" & Detalle_Cta.Item(10) & "', cformapag ='" & Detalle_Cta.Item(3) & "', cfrecuencia ='" & _
                    '                        Detalle_Cta.Item(5) & "', nmeses=" & Detalle_Cta.Item(7) & ", ccodusu_prom ='" & Detalle_Cta.Item(13) & "'" & _
                    '                        " Where ccodcrt ='" & Detalle_Cta.Item(14) & "'"

                    'command.ExecuteNonQuery()

                    lcCtas_Aho = Detalle_Cta.Item(2)
                End If



                'Borra Firmas si Existen
                command.CommandText = _
                                         " Delete from Ahomfir " & _
                                         " Where ccodaho ='" & Detalle_Cta.Item(2) & "'"

                command.ExecuteNonQuery()

                'Inserta Firmas
                For Each fila As DataRow In dt_firm.Rows

                    command.CommandText = _
                                            " Insert into Ahomfir (ccodaho, nlibreta, nmanco, cnomau, cnomgfir, dnacgfir, cdui, ccodusu, dfecmod, id) " & _
                                            " values('" & Detalle_Cta.Item(2) & "',1,0,'','" & _
                                            fila("cNomFir").ToString.Trim & "','" & fila("dnacimi") & "','" & fila("cnudoci") & "','" & _
                                            Detalle_Cta.Item(9) & "',getdate()," & fila("IdCuenta") & ")"

                    command.ExecuteNonQuery()

                Next


                'Borra Beneficiarios si Existen
                command.CommandText = _
                                        " Delete from Ahomben " & _
                                        " Where ccodaho ='" & Detalle_Cta.Item(2) & "'"

                command.ExecuteNonQuery()

                'Inserta Beneficiarios de la Cuenta
                For Each fila As DataRow In dt_ben.Rows
                    command.CommandText = _
                                            " Insert into Ahomben (ccodaho,ncorrel,cnomben,cparent,dfecnac,nporcen,dfecmod,ccodusu,cdirben,ccodcli) " & _
                                            " values('" & Detalle_Cta.Item(2) & "'," & fila("IdCuenta") & ",'" & fila("cNomBen").ToString.Trim & "','" & _
                                            fila("cParent") & "','" & fila("dnacimi") & "'," & fila("nPorcen") & ",getdate(),'" & _
                                            Detalle_Cta.Item(9) & "','" & fila("cdirecc") & "','" & Detalle_Cta.Item(1) & "')"

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



    Public Function Extraer_Datos_Ctas_Aho(ByVal pntipo As Integer, ByVal pcdescri As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                _sql = _
                        " Select cli.ccodcli, aho.ccodaho, " & _
                        " tipo_cta= case substring(aho.ccodaho,7,2) " & _
                        " when '01' then 'CTA. CONCENTRADORA' " & _
                        " when '02' then 'CTA. GARANTIA LIQUIDA' " & _
                        " when '03' then 'NAVIDEÑO' " & _
                        " when '04' then 'SUPER-AHORRO'" & _
                        " when '05' then 'VISIONARIO' " & _
                        " when '06' then 'APORTACIONES'  end, " & _
                        " Case aho.cestado" & _
                        " WHEN 'A' THEN 'ACTIVO'" & _
                        " WHEN 'I' THEN 'INACTIVO'" & _
                        " WHEN 'P' THEN 'BLOQUEADA'" & _
                        " WHEN 'C' THEN 'CANCELADA'" & _
                        " WHEN 'E' THEN 'EMBARGADA'" & _
                        " WHEN 'U' THEN 'ANULADA'" & _
                        " ELSE 'OTROS' end as cestado," & _
                        " aho.nsaldoaho as saldo, isnull(aho.notas,'') as notas, aho.nlibreta, " & _
                        "(cpriape + SPACE(1) + csegape) as capellidos, (cprinom + space(1) + csegnom) as cnombres, " & _
                        " aho.nmonres, aho.cbloqueo, aho.llave, " & _
                        " aho.producto, cli.cnomcli " & _
                        " from climide  as cli " & _
                        " inner join ahomcta as aho " & _
                        " on cli.ccodcli = aho.cnudotr "

                Select Case pntipo
                    Case 1  'Nombre del Socio
                        _sql = _sql + " Where cli.cnomcli like '%" & pcdescri & "%'"
                    Case 2   'Número de DUI
                        _sql = _sql + " Where cli.cnudoci like '%" & pcdescri & "%'"
                    Case Else   'Número de Socio
                        _sql = _sql + " Where cli.ccodcli like '%" & pcdescri & "%'"
                End Select

                command.CommandText = _
                                        _sql


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Ctas_Ahor")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Extraer_Datos_Ctas_Detalle(ByVal pcCodaho As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim _sql As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select Id as IdCuenta, cnomgfir as cNomFir, dnacgfir as dnacimi, cdui as cnudoci from Ahomfir" & _
                                        " Where cCodaho ='" & pcCodaho & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Firmas")

                command.CommandText = _
                                        " Select ncorrel as IdCuenta,cNomBen,dfecnac as dnacimi,cParent,cdirben as cDirecc,nPorcen from Ahomben " & _
                                        " Where cCodaho ='" & pcCodaho & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Beneficiarios")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Extraer_Datos_cta_ahorros_contratos(ByVal ccodaho As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select a.cclaper,b.ccodaho, a.cnomcli, a.dnacimi, DATEDIFF(YEAR, a.dnacimi, GETDATE()) as canos,  " & _
                                        " a.ccodpro, d.cdescri ,c.ntasint, b.nsaldoaho,(a.PrimNombreRepLegal +' '+ a.SegNombreRepLegal +' '+ a.PrimApeRepLegal +' '+ a.SegApeRepLegal) as nombreplegal from climide a " & _
                                        " inner join ahomcta b " & _
                                        " on a.ccodcli = b.cnudotr " & _
                                        " inner join ahotlin c " & _
                                        " on b.cnrolin = c.cnrolin " & _
                                        " inner join tabtprf d " & _
                                        " on a.ccodpro = d.ccodigo " & _
                                        " Where b.ccodaho ='" & ccodaho & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_cta_Ahorro")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Extraer_ctas_Ahorro_Socio(ByVal cnudotr As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select (c.cnomtrs+'|'+a.ccodaho) as cdescri, a.* from ahomcta a " & _
                                        " inner join ahotlin b " & _
                                        " on a.cnrolin = b.cnrolin " & _
                                        " inner join ahomtrs c " & _
                                        " on c.ccodtrs = substring(b.ccodlin,4,2) " & _
                                        " where substring(b.ccodlin,4,2)  <> '06' " & _
                                        " and a.cbloqueo = '' and a.cestado = 'A' and a.cnudotr ='" & cnudotr & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_cta_Ahorro")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Extraer_ctas_Ahorro_Socio_(ByVal cnudotr As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select ltrim(rtrim(a.ccodaho)) as ccodaho, (c.cnomtrs+'|'+a.ccodaho) as cdescri from ahomcta a " & _
                                        " inner join ahotlin b " & _
                                        " on a.cnrolin = b.cnrolin " & _
                                        " inner join ahomtrs c " & _
                                        " on c.ccodtrs = substring(b.ccodlin,4,2) " & _
                                        " where substring(b.ccodlin,4,2)  <> '06' " & _
                                        " and a.cbloqueo = '' and a.cestado = 'A' and a.cnudotr ='" & cnudotr & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_cta_Ahorro")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Tranferencias(ByVal Encabeza_Part() As String) As String

        Dim lcnumcom As String = "0"
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim MyTransac As SqlTransaction
        Dim ds As New DataSet
        Dim i As Integer = 0
        Dim ldfeccnt As Date = Encabeza_Part(0)
        'Dim lcCodaho_dep As String = ""
        Dim lcCodcta_Aho_Orig As String = ""
        Dim lcCodcta_Aho_Dest As String = ""
        Dim lnSaldoAho As Double = 0
        Dim lnDebe As Double = Encabeza_Part(10)
        Dim lnHaber As Double = Encabeza_Part(10)
        Dim lnLibreta As Integer = 0
        Dim lnlinea As Integer = 0
        Dim eahommov As New dbAhommov
        Dim occlass As New dbCntamov


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            MyTransac = connection.BeginTransaction()
            command.Connection = connection
            command.Transaction = MyTransac

            Try


                'Dim Datos_Trans() As String = {Session("GDFECSIS"), Session("gccodofi"), _
                '                     concepto, "PA", Session("GDFECSIS"), _
                '                     Session("gcCodusu"), Me.TxtcCodaho_Origen.Text.Trim, Me.TxtcCodaho_Destino.Text.Trim, _
                '                     Me.TxtcCodcli_Origen.Text.Trim, Me.TxtcCodcli_Destino.Text.Trim, _
                '                     Double.Parse(Me.TxtnMonto.Text), Me.Txtcnomcli_Origen.Text.Trim, _
                '                     Me.Txtcnomcli_Destino.Text.Trim, lcCodcta_ctb_ana}


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



                'Extrae Mascara de Ahorros Origen
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '" & Encabeza_Part(6).Substring(6, 2).Trim & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras")

                For Each fila As DataRow In ds.Tables("Mascaras").Rows
                    lcCodcta_Aho_Orig = fila("cCta1").ToString.Trim
                Next



                'Extrae Mascara de Ahorros Destino
                command.CommandText = _
                                        " Select ccta1 from Ahomtrs " & _
                                        " Where ccodtrs = '" & Encabeza_Part(7).Substring(6, 2).Trim & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Mascaras1")

                For Each fila As DataRow In ds.Tables("Mascaras1").Rows
                    lcCodcta_Aho_Dest = fila("cCta1").ToString.Trim
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
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho_Orig & "','" & _
                                        lcCodcta_Aho_Orig.ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                        ",0,'',0,'','" & _
                                        Encabeza_Part(0) & "','" & Encabeza_Part(6) & "','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','" & Encabeza_Part(8) & "')"

                command.ExecuteNonQuery()



                i += 1

                'Descargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & lcCodcta_Aho_Dest & "','" & _
                                        lcCodcta_Aho_Dest.ToString.Trim.Substring(0, 1) & "',0" & _
                                        "," & lnHaber & ",'',0,'','" & _
                                        Encabeza_Part(0) & "','" & Encabeza_Part(7) & " ','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','" & Encabeza_Part(9) & "')"

                command.ExecuteNonQuery()


                '------------------------------------------'
                '       Hara movimiento en el cajero       '
                '------------------------------------------'

                i += 1

                'Cargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & Encabeza_Part(13) & "','" & _
                                        Encabeza_Part(13).ToString.Trim.Substring(0, 1) & "'," & lnDebe & _
                                        ",0,'',0,'','" & _
                                        Encabeza_Part(0) & "','" & Encabeza_Part(6) & "','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','" & Encabeza_Part(8) & "')"

                command.ExecuteNonQuery()



                i += 1

                'Descargo
                command.CommandText = _
                                        " Insert Into cntamov (ccodsec,ffondos,cnumcom,cnumlin,ccodcta,cclase," & _
                                        " ndebe,nhaber,cflc,nfln,cnumdoc,dfeccnt,ccodpres,cconcepto,cpoliza," & _
                                        " ccodofi, ccodreg, dfecmod, ccodusu1, ccodcli) Values('" & _
                                        " ','01','" & lcnumcom & "'," & i & ",'" & Encabeza_Part(13) & "','" & _
                                        Encabeza_Part(13).ToString.Trim.Substring(0, 1) & "',0" & _
                                        "," & lnHaber & ",'',0,'','" & _
                                        Encabeza_Part(0) & "','" & Encabeza_Part(7) & " ','','" & Encabeza_Part(3) & "','" & _
                                        Encabeza_Part(1) & "','','" & _
                                        Encabeza_Part(4) & "','" & Encabeza_Part(5) & "','" & Encabeza_Part(9) & "')"

                command.ExecuteNonQuery()



                '---------------------------------------------------------------------------------'
                '   Hara el Retiro de la Cuenta Origen y el Deposito a la Cta. de Ahorro Destino  '  
                '---------------------------------------------------------------------------------'

                'Primero hara el Retiro
                'Extre Movimiento de Ahorro
                command.CommandText = _
                                        " Select * from Ahomcta " & _
                                        " where ccodaho= '" & Encabeza_Part(6).Trim & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Ahorro")

                For Each fila As DataRow In ds.Tables("Ahorro").Rows
                    lnSaldoAho = fila("nsaldoaho") - Encabeza_Part(10)
                    lnLibreta = fila("nlibreta")
                    lnlinea = fila("nnum") + 1
                Next


                'command.CommandText = _
                '                       " Select isnull(MAX(nnum+1),1) as nnum FROM AHOMMOV " & _
                '                       " Where ccodaho = '" & Encabeza_Part(6).Trim & "'"


                'command.CommandType = CommandType.Text

                'MyAdapter.SelectCommand = command

                'MyAdapter.Fill(ds, "Linea")

                'For Each fila As DataRow In ds.Tables("Linea").Rows
                '    lnlinea = fila("nnum")
                'Next

                'lnlinea = eahommov.ObtieneLinea(Encabeza_Part(6).Trim)
                lnlinea = eahommov.fxLinea(lnlinea)


                ' Inserta en la Maestra de Ahorros
                command.CommandText = _
                                        " Update ahomcta " & _
                                        " Set ncorrel=" & lnlinea & ",nsaldoaho= " & lnSaldoAho & ",nsaldnind= " & lnSaldoAho & "," & _
                                        " dfechault='" & ldfeccnt & "', dfecult='" & ldfeccnt & "',dfecmod= getdate()," & _
                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres" & _
                                        " where ccodaho= '" & Encabeza_Part(6).Trim & "'"
                command.ExecuteNonQuery()


                ' Inserta en el Movimiento de Ahorros
                command.CommandText = _
                                        "insert into ahommov " & _
                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                                        "('" & Encabeza_Part(6) & "','" & ldfeccnt & "', 'R', '" & lcnumcom & "', 'E', 'RETIRO POR TRANSFERENCIA', " & lnLibreta & ", '', ''," & _
                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & Encabeza_Part(10) & ",0,'N'," & _
                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                        lnSaldoAho & ", " & lnSaldoAho & ", 'RT','" & Encabeza_Part(6).Substring(6, 2).Trim & "',' ',0,'',0)"

                command.ExecuteNonQuery()


                '----------------------------------------------------'
                '       Hara el Deposito en la cuenta Destino        '
                '----------------------------------------------------'
                'Extre Movimiento de Ahorro
                command.CommandText = _
                                         " Select * from Ahomcta " & _
                                         " where ccodaho= '" & Encabeza_Part(7).Trim & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Ahorro1")

                For Each fila As DataRow In ds.Tables("Ahorro1").Rows
                    lnSaldoAho = fila("nsaldoaho") + Encabeza_Part(10)
                    lnLibreta = fila("nlibreta")
                    lnlinea = fila("nnum") + 1
                Next


                'command.CommandText = _
                '                        " Select isnull(MAX(nnum+1),1) as nnum FROM AHOMMOV " & _
                '                        " Where ccodaho = '" & Encabeza_Part(7).Trim & "'"


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
                                        " dultmov='" & ldfeccnt & "',nnum=" & lnlinea & ",nmonres=nmonres" & _
                                        " where ccodaho= '" & Encabeza_Part(7).Trim & "'"
                command.ExecuteNonQuery()


                ' Inserta en el Movimiento de Ahorros
                command.CommandText = _
                                        "insert into ahommov " & _
                                        "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                                        "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                                        "('" & Encabeza_Part(7) & "','" & ldfeccnt & "', 'D', '" & lcnumcom & "', 'E', 'DEPOSITO POR TRANSFERENCIA', " & lnLibreta & ", '', ''," & _
                                        "'" & ldfeccnt & "','" & ldfeccnt & "',0," & Encabeza_Part(10) & ",0,'N'," & _
                                        lnlinea & ",'" & ldfeccnt & "', '" & Encabeza_Part(5) & "', " & lnlinea & ", '', " & _
                                        lnSaldoAho & ", " & lnSaldoAho & ", 'DP','" & Encabeza_Part(7).Substring(6, 2).Trim & "',' ',0,'',0)"

                command.ExecuteNonQuery()


                ' Attempt to commit the transaction.
                MyTransac.Commit()


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


    Public Function Extraer_Detalle_Cupones(ByVal cCodcrt As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select cnrocuo, dfecven, ndias, nintere, nimpuestos, nintere_imp,ntasint,case cestado When 'P' then 'PENDIENTE'  " & _
                                        " else 'CANCELADO' " & _
                                        " end	as cEstado " & _
                                        " From ahomppg " & _
                                        " where ccodcrt = '" & cCodcrt & "' and ctipope = 'N'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_Cupones")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function



    Public Function Extraer_Detalle_Intereses(ByVal cCodcrt As String) As Double

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lnInteres As Double = 0

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select isnull(sum(nintere),0) as suma  from ahomint  " & _
                                        " where ccodcrt = '" & cCodcrt & "' and cflag <> 'X'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_Intereses")


                For Each fila As DataRow In ds_Trab.Tables("Detalle_Intereses").Rows
                    lnInteres = fila("suma")
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return lnInteres

    End Function

    Public Function Extraer_Detalle_Intereses_Pend(ByVal cCodcrt As String, ByVal pdfecsis As Date) As Double

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lnInteres As Double = 0

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select isnull(sum(nintere),0) as suma  from ahomint  " & _
                                        " where ccodcrt = '" & cCodcrt & "' and cflag <> 'X' and dfecpro <= '" & pdfecsis & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_Intereses")


                For Each fila As DataRow In ds_Trab.Tables("Detalle_Intereses").Rows
                    lnInteres = fila("suma")
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return lnInteres

    End Function


    Public Function Extraer_Saldo_Cta_Ahorro(ByVal pcCodctaAho As String) As Double

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim pnSaldoAho As Double = 0

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " select b.ccodaho, a.cnomcli, b.nsaldoaho from climide a" & _
                                        " inner join ahomcta b " & _
                                        " on a.ccodcli = b.cnudotr " & _
                                        " where b.cCodaho = '" & pcCodctaAho & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Saldo_Cta_Aho")


                For Each fila As DataRow In ds_Trab.Tables("Saldo_Cta_Aho").Rows
                    pnSaldoAho = fila("nsaldoaho")
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return pnSaldoAho

    End Function



    Public Function Extraer_Movi_Dep_Cta_Ahorro_Desembolso(ByVal pcCodctaAho As String, _
                                                           ByVal pdfecsis As Date) As Double

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim pnSaldoAho As Double = 0

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select sum(b.nmonto) as nmonto from ahomcta a " & _
                                        " Inner join ahommov b " & _
                                        " on a.ccodaho = b.ccodaho " & _
                                        " Where a.ccodaho = '" & pcCodctaAho & "'" & _
                                        " and crazon = 'DEPOSITO DE APERTURA X CREDITO'" & _
                                        " and cnumdoc = '0001'" & _
                                        " and dfecope = '" & pdfecsis & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Saldo_Cta_Aho")


                For Each fila As DataRow In ds_Trab.Tables("Saldo_Cta_Aho").Rows
                    pnSaldoAho = fila("nmonto")
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return pnSaldoAho

    End Function


    'Bloquea todas las cuentas de Ahorros
    Public Function Bloqueo_cta_liquidacion(ByVal pcCodcli As String, ByVal pcCodusu As String) As Integer

        Dim lnRetorno As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim Mytransaccion As SqlTransaction



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try


                'Primero valida el numero de Libreta

                command.CommandText = _
                                        " Update ahomcta set cbloqueo = 'SI', cestado = 'P', ccodusu='" & pcCodusu & "', dfecmod =getdate() " & _
                                        " Where cnudotr ='" & pcCodcli & "'"

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



    Public Function BusquedaCtaAhorroPL(ByVal cnudoci As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT     ahomcta.ccodaho, ahomcta.cnrolin, climide.ccodcli, climide.cnomcli, climide.cnudoci, ")
        strSQL.Append(" LTRIM(RTRIM(ahomtrs.cnomtrs)) +' |'+ahomcta.ccodaho  as cnomtrs ")
        strSQL.Append(" FROM         ahomcta INNER JOIN ")
        strSQL.Append("                       climide ON ahomcta.cnudotr = climide.ccodcli INNER JOIN ")
        strSQL.Append("                       ahomtrs ON SUBSTRING(ahomcta.ccodaho,7,2) = ahomtrs.ccodtrs ")
        'strSQL.Append(" WHERE SUBSTRING(ahomcta.ccodaho,7,2) not in ('06') ")
        strSQL.Append(" WHERE SUBSTRING(ahomcta.ccodaho,7,2) = '02' ")
        strSQL.Append(" AND REPLACE(climide.cnudoci,'-','') = '" & cnudoci & "'")


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function


    Public Function BusquedaCtaAhorro_porDUi(ByVal cnudoci As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT     ahomcta.ccodaho, ahomcta.cnrolin, climide.ccodcli, climide.cnomcli, climide.cnudoci, ")
        strSQL.Append(" LTRIM(RTRIM(ahomtrs.cnomtrs)) +' |'+ahomcta.ccodaho  as cnomtrs ")
        strSQL.Append(" FROM         ahomcta INNER JOIN ")
        strSQL.Append("                       climide ON ahomcta.cnudotr = climide.ccodcli INNER JOIN ")
        strSQL.Append("                       ahomtrs ON SUBSTRING(ahomcta.ccodaho,7,2) = ahomtrs.ccodtrs ")
        strSQL.Append(" WHERE SUBSTRING(ahomcta.ccodaho,7,2) not in ('06') ")
        strSQL.Append(" AND REPLACE(climide.cnudoci,'-','') = '" & cnudoci & "'")


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function BusquedaCtaAportacionPL(ByVal cnudoci As String) As String
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT     ahomcta.ccodaho ")
        strSQL.Append(" FROM         ahomcta INNER JOIN ")
        strSQL.Append("                       climide ON ahomcta.cnudotr = climide.ccodcli ")
        strSQL.Append(" WHERE     (SUBSTRING(ahomcta.ccodaho, 7, 2) = '06') AND (REPLACE(climide.cnudoci,'-','') = @cnudoci) ")


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnudoci", cnudoci)
        args(0).Value = cnudoci

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim ccodaho As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodaho")) Then
            Else
                ccodaho = ds.Tables(0).Rows(0)("ccodaho")

            End If
        End If
        Return ccodaho

    End Function

    Public Function Valida_Cta_Aporta_Bloqueda(ByVal pcCodcli As String) As Boolean

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim llvalida As Boolean = False

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select isnull(count(ccodaho),0) as no FROM climide a " & _
                                        " inner join aHOMCTA b " & _
                                        " on a.ccodcli = b.cnudotr " & _
                                        " WHERE SUBSTRING(CCODAHO,7,2) = '06' " & _
                                        " AND CBLOQUEO = 'SI' AND CESTADO = 'P' " & _
                                        " and b.cnudotr  = '" & pcCodcli & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Aportaciones")


                For Each fila As DataRow In ds_Trab.Tables("Aportaciones").Rows
                    If fila("no") > 0 Then
                        llvalida = True
                    End If
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


    Public Function Genera_Saldo_Ahorro_Dinamico_Comparativo(ByVal pcTipaho As String, ByVal pdfechaini As Date, ByVal pdfechafin As Date, _
                                                            ByVal titulo As String, ByVal pcOficina As String) As DataSet


        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lnDepositos As Double = 0
        Dim lnRetiros As Double = 0
        Dim lnDepositos_M As Double = 0
        Dim lnRetiros_M As Double = 0
        Dim lnDepositos_Ant As Double = 0
        Dim lnRetiros_Ant As Double = 0

        Dim _sql As String

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                _sql = _
                        " Select " & titulo & " as titulo,  a.ccodaho, " & _
                        " a.producto, c.cnomtrs, a.cnudotr as ccodcli, b.cdirdom, b.cnomcli, " & _
                        " a.dfecini, a.dfecmod, a.cmotivo,  0000000.00 as nsaldo_ini, 0000000.00 as ndepositos_mes," & _
                        " 00000000.00 as nretiros_mes," & _
                        " 0000000.00 as ndepositos_total,   00000000.00 as nretiros_total,   a.nsaldoaho" & _
                        " from ahomcta a" & _
                        " inner join climide b" & _
                        " on a.cnudotr = b.ccodcli" & _
                        " inner join ahomtrs c " & _
                        " on substring(a.ccodaho,7,2) = c.ccodtrs" & _
                        " where  dfecini <= '" & pdfechafin & "'"


                If pcOficina <> "*" Then
                    _sql = _sql + " and substring(a.ccodaho,4,3) = '" & pcOficina & "'"
                End If

                If pcTipaho <> "*" Then
                    _sql = _sql + " and substring(a.ccodaho,7,2) = '" & pcTipaho & "'"
                End If

                _sql = _sql + " Order By c.cnomtrs, a.cnudotr, a.ccodaho"

                command.CommandText = _sql


                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Data_Ahorros")


                'Extrae todos los movimientos de los Ahorros
                If pcTipaho = "*" Then              'Todos los Ahorros
                    command.CommandText = _
                                            " Select b.* from ahomcta a" & _
                                            " inner join ahommov b " & _
                                            " on a.ccodaho = b.ccodaho " & _
                                            " Where b.nmonto > 0 " & _
                                            " and dfecope <= '" & pdfechafin & "'"

                Else
                    command.CommandText = _
                                            " Select b.* from ahomcta a" & _
                                            " inner join ahommov b " & _
                                            " on a.ccodaho = b.ccodaho " & _
                                            " Where b.nmonto > 0 " & _
                                            " and dfecope <= '" & pdfechafin & "'" & _
                                            " and substring(a.ccodaho,7,2) = '" & pcTipaho & "'"
                End If

                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Mov_Ahorros")


                For Each fila As DataRow In ds_Trab.Tables("Data_Ahorros").Rows
                    lnDepositos = 0
                    lnRetiros = 0
                    lnDepositos_Ant = 0
                    lnRetiros_Ant = 0
                    lnDepositos_M = 0
                    lnRetiros_M = 0


                    'Depositos
                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep IN('DP','CA','IN')")) Then
                        lnDepositos = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep IN('DP','CA','IN')")
                    End If

                    'Depositos
                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep = 'RT'")) Then
                        lnRetiros = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep = 'RT'")
                    End If


                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope >= '" & pdfechaini & "' and dfecope <= '" & pdfechafin & "' and cconcep IN('DP','CA','IN')")) Then
                        lnDepositos_M = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope >= '" & pdfechaini & "' and dfecope <= '" & pdfechafin & "' and cconcep IN('DP','CA','IN')")
                    End If

                    'Depositos
                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope >= '" & pdfechaini & "' and dfecope <= '" & pdfechafin & "' and cconcep = 'RT'")) Then
                        lnRetiros_M = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope >= '" & pdfechaini & "' and dfecope <= '" & pdfechafin & "' and cconcep = 'RT'")
                    End If

                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope < '" & pdfechaini & "' and cconcep IN('DP','CA','IN')")) Then
                        lnDepositos_Ant = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope < '" & pdfechaini & "' and cconcep IN('DP','CA','IN')")
                    End If

                    'Depositos
                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope < '" & pdfechaini & "' and cconcep = 'RT'")) Then
                        lnRetiros_Ant = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and dfecope < '" & pdfechaini & "' and cconcep = 'RT'")
                    End If


                    fila("ndepositos_mes") = lnDepositos_M
                    fila("nretiros_mes") = lnRetiros_M
                    fila("ndepositos_total") = lnDepositos
                    fila("nretiros_total") = lnRetiros
                    fila("nsaldo_ini") = lnDepositos_Ant - lnRetiros_Ant
                    fila("nsaldoaho") = lnDepositos - lnRetiros
                Next


                'Creara un Clon, para solo mostrar cuentas con saldo diferente a cero                
                Dim rows() As DataRow
                Dim sortOrder As String = "cCodaho ASC"
                'Dim expression As String = " nsaldoaho <> 0"
                Dim expression As String = " Not (nsaldoaho = 0 and nsaldo_ini = 0)"
                Dim dt As DataTable = ds_Trab.Tables("Data_Ahorros")
                ' copy table structure
                Dim dtNew As DataTable = dt.Clone()

                rows = dt.Select(expression, sortOrder)

                'Insertara el datarow filtrado en un el dataset
                For Each dr As DataRow In rows
                    dtNew.ImportRow(dr)
                Next

                'Quitando del Dataset tabla principal
                ds_Trab.Tables.Clear()

                'Incorporando el nuevo datable al dataset
                ds_Trab.Tables.Add(dtNew)


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds_Trab

    End Function


    Public Function Genera_Saldo_Ahorro_Dinamico(ByVal pcTipaho As String, ByVal pdfecha As Date, _
                                                ByVal titulo As String, ByVal pcOficina As String) As DataSet


        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lnDepositos As Double = 0
        Dim lnRetiros As Double = 0
        Dim _sql As String

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                _sql = _
                        " Select " & titulo & " as titulo,  a.ccodaho, " & _
                        " a.producto, c.cnomtrs, a.cnudotr as ccodcli, b.cdirdom, b.cnomcli, " & _
                        " a.dfecini, a.dfecmod, a.cmotivo,  0000000.00 as ndepositos_mes, 00000000.00 as nretiros_mes," & _
                        " 0000000.00 as ndepositos_total,   00000000.00 as nretiros_total,   a.nsaldoaho" & _
                        " from ahomcta a" & _
                        " inner join climide b" & _
                        " on a.cnudotr = b.ccodcli" & _
                        " inner join ahomtrs c " & _
                        " on substring(a.ccodaho,7,2) = c.ccodtrs" & _
                        " where  dfecini <= '" & pdfecha & "'"


                If pcOficina <> "*" Then
                    _sql = _sql + " and substring(a.ccodaho,4,3) = '" & pcOficina & "'"
                End If

                If pcTipaho <> "*" Then
                    _sql = _sql + " and substring(a.ccodaho,7,2) = '" & pcTipaho & "'"
                End If

                _sql = _sql + " Order By c.cnomtrs, a.cnudotr, a.ccodaho"

                command.CommandText = _sql


                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Data_Ahorros")


                'Extrae todos los movimientos de los Ahorros
                If pcTipaho = "*" Then              'Todos los Ahorros
                    command.CommandText = _
                                            " Select b.* from ahomcta a" & _
                                            " inner join ahommov b " & _
                                            " on a.ccodaho = b.ccodaho " & _
                                            " Where b.nmonto > 0 " & _
                                            " and dfecope <= '" & pdfecha & "'"

                Else
                    command.CommandText = _
                                            " Select b.* from ahomcta a" & _
                                            " inner join ahommov b " & _
                                            " on a.ccodaho = b.ccodaho " & _
                                            " Where b.nmonto > 0 " & _
                                            " and dfecope <= '" & pdfecha & "'" & _
                                            " and substring(a.ccodaho,7,2) = '" & pcTipaho & "'"
                End If

                command.CommandType = CommandType.Text
                command.CommandTimeout = 0

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Mov_Ahorros")


                For Each fila As DataRow In ds_Trab.Tables("Data_Ahorros").Rows
                    lnDepositos = 0
                    lnRetiros = 0

                    'Depositos
                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep IN('DP','CA','IN')")) Then
                        lnDepositos = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep IN('DP','CA','IN')")
                    End If

                    'Depositos
                    If Not IsDBNull(ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep = 'RT'")) Then
                        lnRetiros = ds_Trab.Tables("Mov_Ahorros").Compute("sum(nMonto)", " ccodaho ='" & fila("ccodaho").ToString.Trim() & "' and cconcep = 'RT'")
                    End If

                    fila("ndepositos_total") = lnDepositos
                    fila("nretiros_total") = lnRetiros
                    fila("nsaldoaho") = lnDepositos - lnRetiros
                Next


                'Creara un Clon, para solo mostrar cuentas con saldo diferente a cero                
                Dim rows() As DataRow
                Dim sortOrder As String = "cCodaho ASC"
                Dim expression As String = "nsaldoaho <> "
                Dim dt As DataTable = ds_Trab.Tables("Data_Ahorros")
                ' copy table structure
                Dim dtNew As DataTable = dt.Clone()

                rows = dt.Select(expression, sortOrder)

                'Insertara el datarow filtrado en un el dataset
                For Each dr As DataRow In rows
                    dtNew.ImportRow(dr)
                Next

                'Quitando del Dataset tabla principal
                ds_Trab.Tables.Clear()

                'Incorporando el nuevo datable al dataset
                ds_Trab.Tables.Add(dtNew)


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds_Trab

    End Function


    Public Function Extraer_ctas_Ahorro_Socio_Saldo(ByVal cnudotr As String) As ArrayList

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim array_d As New ArrayList

        array_d.Add("") 'Codigo de Cuenta
        array_d.Add(0)  'Saldo Cuenta

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select a.* from ahomcta a " & _
                                        " inner join ahotlin b " & _
                                        " on a.cnrolin = b.cnrolin " & _
                                        " inner join ahomtrs c " & _
                                        " on c.ccodtrs = substring(b.ccodlin,4,2) " & _
                                        " where substring(b.ccodlin,4,2)  = '01' " & _
                                        " and a.cbloqueo = '' and a.cestado = 'A' and a.cnudotr ='" & cnudotr & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_cta_Ahorro")


                For Each fila As DataRow In ds_Trab.Tables("Detalle_cta_Ahorro").Rows
                    array_d.Item(0) = fila("ccodaho")
                    array_d.Item(1) = fila("nsaldoaho")
                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return array_d

    End Function


    Public Function Extraer_ctas_Ahorro_Socio_Saldo_Producto(ByVal cnudotr As String, ByVal Producto As String) As Double

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim array_d As New ArrayList

        Dim lnSaldoAho As Double = 0

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection

                command.CommandText = _
                                        " Select a.* from ahomcta a " & _
                                        " inner join ahotlin b " & _
                                        " on a.cnrolin = b.cnrolin " & _
                                        " inner join ahomtrs c " & _
                                        " on c.ccodtrs = substring(b.ccodlin,4,2) " & _
                                        " where substring(b.ccodlin,4,2)  = '" & Producto & "' " & _
                                        " and a.cbloqueo = '' and a.cestado = 'A' and a.cnudotr ='" & cnudotr & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_cta_Ahorro")


                For Each fila As DataRow In ds_Trab.Tables("Detalle_cta_Ahorro").Rows
                    lnSaldoAho = fila("nsaldoaho")
                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnSaldoAho

    End Function

End Class
