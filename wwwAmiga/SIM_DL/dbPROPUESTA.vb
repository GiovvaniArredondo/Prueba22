Imports System.Text
Public Class dbPROPUESTA
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As PROPUESTA
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodana =  "" _
            Or lEntidad.ccodana = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodana = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE PROPUESTA ")
        strSQL.Append(" SET cestado = @cestado, ") 
        strSQL.Append(" ccodcli = @ccodcli, ") 
        strSQL.Append(" ctipcuo = @ctipcuo, ") 
        strSQL.Append(" ctipper = @ctipper, ") 
        strSQL.Append(" dfecasi = @dfecasi, ") 
        strSQL.Append(" dfecsol = @dfecsol, ") 
        strSQL.Append(" nmonsol = @nmonsol, ") 
        strSQL.Append(" nmonsug = @nmonsug, ") 
        strSQL.Append(" ncuosug = @ncuosug, ") 
        strSQL.Append(" ndiasug = @ndiasug, ") 
        strSQL.Append(" ndiagra = @ndiagra, ") 
        strSQL.Append(" dfecapr = @dfecapr, ") 
        strSQL.Append(" dfecven = @dfecven, ") 
        strSQL.Append(" nmonapr = @nmonapr, ") 
        strSQL.Append(" nmoncuo = @nmoncuo, ") 
        strSQL.Append(" ncuoapr = @ncuoapr, ") 
        strSQL.Append(" ndiaapr = @ndiaapr, ") 
        strSQL.Append(" cnrolin = @cnrolin, ") 
        strSQL.Append(" ntasint = @ntasint, ") 
        strSQL.Append(" dfecvig = @dfecvig, ") 
        strSQL.Append(" ngastos = @ngastos, ") 
        strSQL.Append(" ncapdes = @ncapdes, ") 
        strSQL.Append(" nmeses = @nmeses, ") 
        strSQL.Append(" csececo = @csececo, ") 
        strSQL.Append(" nciclo = @nciclo, ") 
        strSQL.Append(" ccodsol = @ccodsol, ") 
        strSQL.Append(" ncapoto = @ncapoto, ") 
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" cflat = @cflat, ") 
        strSQL.Append(" coficina = @coficina, ") 
        strSQL.Append(" cfreccap = @cfreccap, ")
        strSQL.Append(" cfrecint = @cfrecint, ") 
        strSQL.Append(" cprograma = @cprograma ") 
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodusu = @ccodusu ")

        Dim args(36) As SqlParameter
        args(0) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(0).Value = lEntidad.cestado
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(2) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipcuo
        args(3) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipper
        args(4) = New SqlParameter("@dfecasi", SqlDbType.Datetime)
        args(4).Value = lEntidad.dfecasi
        args(5) = New SqlParameter("@dfecsol", SqlDbType.Datetime)
        args(5).Value = lEntidad.dfecsol
        args(6) = New SqlParameter("@nmonsol", SqlDbType.VarChar)
        args(6).Value = lEntidad.nmonsol
        args(7) = New SqlParameter("@nmonsug", SqlDbType.VarChar)
        args(7).Value = lEntidad.nmonsug
        args(8) = New SqlParameter("@ncuosug", SqlDbType.VarChar)
        args(8).Value = lEntidad.ncuosug
        args(9) = New SqlParameter("@ndiasug", SqlDbType.VarChar)
        args(9).Value = lEntidad.ndiasug
        args(10) = New SqlParameter("@ndiagra", SqlDbType.VarChar)
        args(10).Value = lEntidad.ndiagra
        args(11) = New SqlParameter("@dfecapr", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecapr
        args(12) = New SqlParameter("@dfecven", SqlDbType.Datetime)
        args(12).Value = lEntidad.dfecven
        args(13) = New SqlParameter("@nmonapr", SqlDbType.VarChar)
        args(13).Value = lEntidad.nmonapr
        args(14) = New SqlParameter("@nmoncuo", SqlDbType.VarChar)
        args(14).Value = lEntidad.nmoncuo
        args(15) = New SqlParameter("@ncuoapr", SqlDbType.VarChar)
        args(15).Value = lEntidad.ncuoapr
        args(16) = New SqlParameter("@ndiaapr", SqlDbType.VarChar)
        args(16).Value = lEntidad.ndiaapr
        args(17) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(17).Value = lEntidad.cnrolin
        args(18) = New SqlParameter("@ntasint", SqlDbType.VarChar)
        args(18).Value = lEntidad.ntasint
        args(19) = New SqlParameter("@dfecvig", SqlDbType.Datetime)
        args(19).Value = lEntidad.dfecvig
        args(20) = New SqlParameter("@ngastos", SqlDbType.VarChar)
        args(20).Value = lEntidad.ngastos
        args(21) = New SqlParameter("@ncapdes", SqlDbType.VarChar)
        args(21).Value = lEntidad.ncapdes
        args(22) = New SqlParameter("@nmeses", SqlDbType.VarChar)
        args(22).Value = lEntidad.nmeses
        args(23) = New SqlParameter("@csececo", SqlDbType.VarChar)
        args(23).Value = lEntidad.csececo
        args(24) = New SqlParameter("@nciclo", SqlDbType.VarChar)
        args(24).Value = lEntidad.nciclo
        args(25) = New SqlParameter("@ccodsol", SqlDbType.VarChar)
        args(25).Value = lEntidad.ccodsol
        args(26) = New SqlParameter("@ncapoto", SqlDbType.VarChar)
        args(26).Value = lEntidad.ncapoto
        args(27) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(27).Value = lEntidad.ccodusu
        args(28) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(28).Value = lEntidad.dfecmod
        args(29) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(29).Value = lEntidad.cflag
        args(30) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(30).Value = lEntidad.cflat
        args(31) = New SqlParameter("@coficina", SqlDbType.VarChar)
        args(31).Value = lEntidad.coficina
        args(32) = New SqlParameter("@cfreccap", SqlDbType.VarChar)
        args(32).Value = lEntidad.cfreccap
        args(33) = New SqlParameter("@cfrecint", SqlDbType.VarChar)
        args(33).Value = lEntidad.cfrecint
        args(34) = New SqlParameter("@cprograma", SqlDbType.VarChar)
        args(34).Value = lEntidad.cprograma
        args(35) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(35).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value,lEntidad.ccodcta)
        args(36) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(36).Value = IIf(lEntidad.ccodana = Nothing, DBNull.Value,lEntidad.ccodana)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As PROPUESTA
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO PROPUESTA ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" ctipcuo, ") 
        strSQL.Append(" ctipper, ") 
        strSQL.Append(" ccodana, ") 
        strSQL.Append(" nmonsug, ")
        strSQL.Append(" ncuosug, ") 
        strSQL.Append(" ndiasug, ") 
        strSQL.Append(" ndiagra, ") 
        strSQL.Append(" dfecapr, ") 
        strSQL.Append(" dfecven, ") 
        strSQL.Append(" nmonapr, ") 
        strSQL.Append(" nmoncuo, ") 
        strSQL.Append(" ncuoapr, ") 
        strSQL.Append(" ndiaapr, ") 
        strSQL.Append(" cnrolin, ") 
        strSQL.Append(" ntasint, ") 
        strSQL.Append(" dfecvig, ") 
        strSQL.Append(" ngastos, ") 
        strSQL.Append(" ncapdes, ") 
        strSQL.Append(" nmeses, ") 
        strSQL.Append(" csececo, ") 
        strSQL.Append(" nciclo, ") 
        strSQL.Append(" ncapoto, ")
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" cflat, ") 
        strSQL.Append(" cfreccap, ")
        strSQL.Append(" cfrecint, ") 
        strSQL.Append(" cprograma, cdescre, ccodfue) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @ctipcuo, ") 
        strSQL.Append(" @ctipper, ") 
        strSQL.Append(" @ccodana, ") 
        strSQL.Append(" @nmonsug, ")
        strSQL.Append(" @ncuosug, ") 
        strSQL.Append(" @ndiasug, ") 
        strSQL.Append(" @ndiagra, ") 
        strSQL.Append(" @dfecapr, ") 
        strSQL.Append(" @dfecven, ") 
        strSQL.Append(" @nmonapr, ") 
        strSQL.Append(" @nmoncuo, ") 
        strSQL.Append(" @ncuoapr, ") 
        strSQL.Append(" @ndiaapr, ") 
        strSQL.Append(" @cnrolin, ") 
        strSQL.Append(" @ntasint, ") 
        strSQL.Append(" @dfecvig, ") 
        strSQL.Append(" @ngastos, ") 
        strSQL.Append(" @ncapdes, ") 
        strSQL.Append(" @nmeses, ") 
        strSQL.Append(" @csececo, ") 
        strSQL.Append(" @nciclo, ") 
        strSQL.Append(" @ncapoto, ")
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @cflat, ") 
        strSQL.Append(" @cfreccap, ")
        strSQL.Append(" @cfrecint, ") 
        strSQL.Append(" @cprograma, @cdescre, @ccodfue) ")

        Dim args(38) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(1).Value = lEntidad.cestado
        args(2) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(3) = New SqlParameter("@ctipcuo", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipcuo
        args(4) = New SqlParameter("@ctipper", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipper
        args(5) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodana = Nothing, DBNull.Value, lEntidad.ccodana)
        args(6) = New SqlParameter("@nmonsug", SqlDbType.VarChar)
        args(6).Value = lEntidad.nmonsug
        args(7) = New SqlParameter("@ncuosug", SqlDbType.VarChar)
        args(7).Value = lEntidad.ncuosug
        args(8) = New SqlParameter("@ndiasug", SqlDbType.VarChar)
        args(8).Value = lEntidad.ndiasug
        args(9) = New SqlParameter("@ndiagra", SqlDbType.VarChar)
        args(9).Value = lEntidad.ndiagra
        args(10) = New SqlParameter("@dfecapr", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecapr
        args(11) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(11).Value = lEntidad.dfecven
        args(12) = New SqlParameter("@nmonapr", SqlDbType.VarChar)
        args(12).Value = lEntidad.nmonapr
        args(13) = New SqlParameter("@nmoncuo", SqlDbType.VarChar)
        args(13).Value = lEntidad.nmoncuo
        args(14) = New SqlParameter("@ncuoapr", SqlDbType.VarChar)
        args(14).Value = lEntidad.ncuoapr
        args(15) = New SqlParameter("@ndiaapr", SqlDbType.VarChar)
        args(15).Value = lEntidad.ndiaapr
        args(16) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(16).Value = lEntidad.cnrolin
        args(17) = New SqlParameter("@ntasint", SqlDbType.VarChar)
        args(17).Value = lEntidad.ntasint
        args(18) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(18).Value = lEntidad.dfecvig
        args(19) = New SqlParameter("@ngastos", SqlDbType.VarChar)
        args(19).Value = lEntidad.ngastos
        args(20) = New SqlParameter("@ncapdes", SqlDbType.VarChar)
        args(20).Value = lEntidad.ncapdes
        args(21) = New SqlParameter("@nmeses", SqlDbType.VarChar)
        args(21).Value = lEntidad.nmeses
        args(22) = New SqlParameter("@csececo", SqlDbType.VarChar)
        args(22).Value = lEntidad.csececo
        args(23) = New SqlParameter("@nciclo", SqlDbType.VarChar)
        args(23).Value = lEntidad.nciclo
        args(24) = New SqlParameter("@ncapoto", SqlDbType.VarChar)
        args(24).Value = lEntidad.ncapoto
        args(25) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(25).Value = lEntidad.ccodusu
        args(26) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(26).Value = lEntidad.dfecmod
        args(27) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(27).Value = lEntidad.cflag
        args(28) = New SqlParameter("@cflat", SqlDbType.VarChar)
        args(28).Value = lEntidad.cflat
        args(29) = New SqlParameter("@cfreccap", SqlDbType.VarChar)
        args(29).Value = lEntidad.cfreccap
        args(30) = New SqlParameter("@cfrecint", SqlDbType.VarChar)
        args(30).Value = lEntidad.cfrecint
        args(31) = New SqlParameter("@cprograma", SqlDbType.VarChar)
        args(31).Value = lEntidad.cprograma
        args(32) = New SqlParameter("@cdescre", SqlDbType.VarChar)
        args(32).Value = lEntidad.cdescre
        args(33) = New SqlParameter("@ccodfue", SqlDbType.VarChar)
        args(33).Value = lEntidad.ccodfue
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As PROPUESTA
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM PROPUESTA ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodusu = @ccodusu ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As PROPUESTA
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodana = @ccodana ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodana

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.ctipcuo = IIf(.Item("ctipcuo") Is DBNull.Value, Nothing, .Item("ctipcuo"))
                lEntidad.ctipper = IIf(.Item("ctipper") Is DBNull.Value, Nothing, .Item("ctipper"))
                lEntidad.dfecasi = IIf(.Item("dfecasi") Is DBNull.Value, Nothing, .Item("dfecasi"))
                lEntidad.dfecsol = IIf(.Item("dfecsol") Is DBNull.Value, Nothing, .Item("dfecsol"))
                lEntidad.nmonsol = IIf(.Item("nmonsol") Is DBNull.Value, Nothing, .Item("nmonsol"))
                lEntidad.nmonsug = IIf(.Item("nmonsug") Is DBNull.Value, Nothing, .Item("nmonsug"))
                lEntidad.ncuosug = IIf(.Item("ncuosug") Is DBNull.Value, Nothing, .Item("ncuosug"))
                lEntidad.ndiasug = IIf(.Item("ndiasug") Is DBNull.Value, Nothing, .Item("ndiasug"))
                lEntidad.ndiagra = IIf(.Item("ndiagra") Is DBNull.Value, Nothing, .Item("ndiagra"))
                lEntidad.dfecapr = IIf(.Item("dfecapr") Is DBNull.Value, Nothing, .Item("dfecapr"))
                lEntidad.dfecven = IIf(.Item("dfecven") Is DBNull.Value, Nothing, .Item("dfecven"))
                lEntidad.nmonapr = IIf(.Item("nmonapr") Is DBNull.Value, Nothing, .Item("nmonapr"))
                lEntidad.nmoncuo = IIf(.Item("nmoncuo") Is DBNull.Value, Nothing, .Item("nmoncuo"))
                lEntidad.ncuoapr = IIf(.Item("ncuoapr") Is DBNull.Value, Nothing, .Item("ncuoapr"))
                lEntidad.ndiaapr = IIf(.Item("ndiaapr") Is DBNull.Value, Nothing, .Item("ndiaapr"))
                lEntidad.cnrolin = IIf(.Item("cnrolin") Is DBNull.Value, Nothing, .Item("cnrolin"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.dfecvig = IIf(.Item("dfecvig") Is DBNull.Value, Nothing, .Item("dfecvig"))
                lEntidad.ngastos = IIf(.Item("ngastos") Is DBNull.Value, Nothing, .Item("ngastos"))
                lEntidad.ncapdes = IIf(.Item("ncapdes") Is DBNull.Value, Nothing, .Item("ncapdes"))
                lEntidad.nmeses = IIf(.Item("nmeses") Is DBNull.Value, Nothing, .Item("nmeses"))
                lEntidad.csececo = IIf(.Item("csececo") Is DBNull.Value, Nothing, .Item("csececo"))
                lEntidad.nciclo = IIf(.Item("nciclo") Is DBNull.Value, Nothing, .Item("nciclo"))
                lEntidad.ccodsol = IIf(.Item("ccodsol") Is DBNull.Value, Nothing, .Item("ccodsol"))
                lEntidad.ncapoto = IIf(.Item("ncapoto") Is DBNull.Value, Nothing, .Item("ncapoto"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cflat = IIf(.Item("cflat") Is DBNull.Value, Nothing, .Item("cflat"))
                lEntidad.coficina = IIf(.Item("coficina") Is DBNull.Value, Nothing, .Item("coficina"))
                lEntidad.cfreccap = IIf(.Item("cfreccap") Is DBNull.Value, Nothing, .Item("cfreccap"))
                lEntidad.cfrecint = IIf(.Item("cfrecint") Is DBNull.Value, Nothing, .Item("cfrecint"))
                lEntidad.cprograma = IIf(.Item("cprograma") Is DBNull.Value, Nothing, .Item("cprograma"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As PROPUESTA
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodana),0) + 1 ")
        strSQL.Append(" FROM PROPUESTA ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcta As String) As listaPROPUESTA

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaPROPUESTA

        Try
            Do While dr.Read()
                Dim mEntidad As New PROPUESTA
                mEntidad.ccodcta = ccodcta
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ctipcuo = IIf(dr("ctipcuo") Is DBNull.Value, Nothing, dr("ctipcuo"))
                mEntidad.ctipper = IIf(dr("ctipper") Is DBNull.Value, Nothing, dr("ctipper"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.dfecasi = IIf(dr("dfecasi") Is DBNull.Value, Nothing, dr("dfecasi"))
                mEntidad.dfecsol = IIf(dr("dfecsol") Is DBNull.Value, Nothing, dr("dfecsol"))
                mEntidad.nmonsol = IIf(dr("nmonsol") Is DBNull.Value, Nothing, dr("nmonsol"))
                mEntidad.nmonsug = IIf(dr("nmonsug") Is DBNull.Value, Nothing, dr("nmonsug"))
                mEntidad.ncuosug = IIf(dr("ncuosug") Is DBNull.Value, Nothing, dr("ncuosug"))
                mEntidad.ndiasug = IIf(dr("ndiasug") Is DBNull.Value, Nothing, dr("ndiasug"))
                mEntidad.ndiagra = IIf(dr("ndiagra") Is DBNull.Value, Nothing, dr("ndiagra"))
                mEntidad.dfecapr = IIf(dr("dfecapr") Is DBNull.Value, Nothing, dr("dfecapr"))
                mEntidad.dfecven = IIf(dr("dfecven") Is DBNull.Value, Nothing, dr("dfecven"))
                mEntidad.nmonapr = IIf(dr("nmonapr") Is DBNull.Value, Nothing, dr("nmonapr"))
                mEntidad.nmoncuo = IIf(dr("nmoncuo") Is DBNull.Value, Nothing, dr("nmoncuo"))
                mEntidad.ncuoapr = IIf(dr("ncuoapr") Is DBNull.Value, Nothing, dr("ncuoapr"))
                mEntidad.ndiaapr = IIf(dr("ndiaapr") Is DBNull.Value, Nothing, dr("ndiaapr"))
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.ngastos = IIf(dr("ngastos") Is DBNull.Value, Nothing, dr("ngastos"))
                mEntidad.ncapdes = IIf(dr("ncapdes") Is DBNull.Value, Nothing, dr("ncapdes"))
                mEntidad.nmeses = IIf(dr("nmeses") Is DBNull.Value, Nothing, dr("nmeses"))
                mEntidad.csececo = IIf(dr("csececo") Is DBNull.Value, Nothing, dr("csececo"))
                mEntidad.nciclo = IIf(dr("nciclo") Is DBNull.Value, Nothing, dr("nciclo"))
                mEntidad.ccodsol = IIf(dr("ccodsol") Is DBNull.Value, Nothing, dr("ccodsol"))
                mEntidad.ncapoto = IIf(dr("ncapoto") Is DBNull.Value, Nothing, dr("ncapoto"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.cflat = IIf(dr("cflat") Is DBNull.Value, Nothing, dr("cflat"))
                mEntidad.coficina = IIf(dr("coficina") Is DBNull.Value, Nothing, dr("coficina"))
                mEntidad.cfreccap = IIf(dr("cfreccap") Is DBNull.Value, Nothing, dr("cfreccap"))
                mEntidad.cfrecint = IIf(dr("cfrecint") Is DBNull.Value, Nothing, dr("cfrecint"))
                mEntidad.cprograma = IIf(dr("cprograma") Is DBNull.Value, Nothing, dr("cprograma"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim tables(0) As String
        tables(0) = New String("PROPUESTA")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcta, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" ctipcuo, ") 
        strSQL.Append(" ctipper, ") 
        strSQL.Append(" ccodana, ") 
        strSQL.Append(" dfecasi, ") 
        strSQL.Append(" dfecsol, ") 
        strSQL.Append(" nmonsol, ") 
        strSQL.Append(" nmonsug, ") 
        strSQL.Append(" ncuosug, ") 
        strSQL.Append(" ndiasug, ") 
        strSQL.Append(" ndiagra, ") 
        strSQL.Append(" dfecapr, ") 
        strSQL.Append(" dfecven, ") 
        strSQL.Append(" nmonapr, ") 
        strSQL.Append(" nmoncuo, ") 
        strSQL.Append(" ncuoapr, ") 
        strSQL.Append(" ndiaapr, ") 
        strSQL.Append(" cnrolin, ") 
        strSQL.Append(" ntasint, ") 
        strSQL.Append(" dfecvig, ") 
        strSQL.Append(" ngastos, ") 
        strSQL.Append(" ncapdes, ") 
        strSQL.Append(" nmeses, ") 
        strSQL.Append(" csececo, ") 
        strSQL.Append(" nciclo, ") 
        strSQL.Append(" ccodsol, ") 
        strSQL.Append(" ncapoto, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" cflat, ") 
        strSQL.Append(" coficina, ") 
        strSQL.Append(" cfreccap, ") 
        strSQL.Append(" cfrecint, ") 
        strSQL.Append(" cprograma ") 
        strSQL.Append(" FROM PROPUESTA ")

    End Sub
    Public Function ObtienePropuestas(ByVal cCodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select a.ccodcli, a.cnomcli, ")
        strSQL.Append("b.ccodcta, ")
        strSQL.Append("c.nmonsug, c.ncuosug, c.cfreccap, c.cfrecint, c.ntasint, c.nmoncuo, ")
        strSQL.Append("c.ccodusu, d.nombre,  ")
        strSQL.Append("c.ccodfue, c.cdescre, c.cprograma, c.nmeses,  c.csececo,  ")
        strSQL.Append("e.cdescri as fondos,  d.cargo,  f.cdescri as actividad, c.dfecapr,  ")
        strSQL.Append("space(120) as descargo, space(120) as frecuencia, space(120) as programa, space(120) as destino, space(120) as sector,  ")
        strSQL.Append(" ccodchk01 = case when  (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '01' and ccodusu = c.ccodusu ) is null then '0' else (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '01' and ccodusu = c.ccodusu ) end , ")
        strSQL.Append(" ccodchk02 = case when (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '02' and ccodusu = c.ccodusu ) is null then '0' else (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '02' and ccodusu = c.ccodusu ) end, ")
        strSQL.Append(" ccodchk03 = case when (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '03' and ccodusu = c.ccodusu ) is null then '0' else (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '03' and ccodusu = c.ccodusu ) end, ")
        strSQL.Append(" ccodchk04 = case when (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '04' and ccodusu = c.ccodusu ) is null then '0' else (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '04' and ccodusu = c.ccodusu ) end, ")
        strSQL.Append(" ccodchk05 = case when (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '05' and ccodusu = c.ccodusu ) is null then '0' else (select cremchk.lopcion  from cremchk where cremchk.ccodcta = @ccodcta and cremchk.ccodchk = '05' and ccodusu = c.ccodusu ) end, ")
        strSQL.Append(" ntipgas01 = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '01' and cusugen = c.ccodusu  and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '01' and cusugen = c.ccodusu and propgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas02 = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '02' and cusugen = c.ccodusu and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '02' and cusugen = c.ccodusu and propgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas03 = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '03' and cusugen = c.ccodusu and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '03' and cusugen = c.ccodusu and propgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas04 = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '04' and cusugen = c.ccodusu and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '04' and cusugen = c.ccodusu and propgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas05 = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '05' and cusugen = c.ccodusu and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '05' and cusugen = c.ccodusu and propgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas06 = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '06' and cusugen = c.ccodusu and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas = '06' and cusugen = c.ccodusu and propgas.cdescob ='D') end, ")
        strSQL.Append(" nOtros  = case when (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas <> '01' and propgas.ctipgas <> '02' and propgas.ctipgas <> '03' and propgas.ctipgas <> '04' and propgas.ctipgas <> '05' and propgas.ctipgas <> '06' and cusugen = c.ccodusu and propgas.cdescob ='D') is null then '0' else (select propgas.nmongas  from propgas where propgas.ccodcta = @ccodcta and propgas.ctipgas <> '01' and propgas.ctipgas <> '02' and propgas.ctipgas <> '03' and propgas.ctipgas <> '04' and propgas.ctipgas <> '05' and propgas.ctipgas <> '06' and cusugen = c.ccodusu and propgas.cdescob ='D') end ")
        strSQL.Append("FROM Climide a, Cremcre b, propuesta c, usuarios d, tabttab e,  tabtciu f  ")
        strSQL.Append("WHERE a.ccodcli = b.ccodcli and b.ccodcta = c.ccodcta and c.ccodusu = d.usuario ")
        strSQL.Append("and e.ccodigo = b.ccodfue and e.ctipreg ='1' and e.ccodtab ='033' and  f.ccodigo = b.ccodact  ")
        strSQL.Append("and b.ccodcta = @ccodcta ")
        
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim etabttab As New dbTabttab
        For Each fila As DataRow In ds.Tables(0).Rows
            fila("descargo") = etabttab.Describe(fila("cargo"), "053")
            fila("frecuencia") = etabttab.Describe(fila("cfreccap"), "060")
            fila("programa") = etabttab.Describe(fila("cprograma"), "100")
            fila("destino") = etabttab.Describe(fila("cdescre"), "005")
            fila("Sector") = etabttab.Describe(fila("csececo"), "021")



        Next

        Return ds
    End Function


    Public Function Extrae_Resolucion_Usuario(ByVal Idusuario As Integer, ByVal cCodcta As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim id_usuario_comite_1 As Integer
        Dim id_usuario_comite_2 As Integer
        Dim id_usuario_comite_3 As Integer
        Dim id_usuario_comite_4 As Integer
        Dim id_usuario_comite_5 As Integer

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                'Extrae Datos de la Resolución
                command.CommandText = _
                                        "Select a.ccodcli, a.cnomcli, " & _
                                        " b.ccodcta, " & _
                                        " b.nmonapr as nmonsug, b.ncuosug, b.cfreccap, b.cfrecint, b.ntasint, b.nmoncuo, " & _
                                        " b.ccodusu, d.nombre,  " & _
                                        " b.ccodfue, b.cdescre, b.cprograma, b.nmeses,  b.csececo,  " & _
                                        " e.cdescri as fondos,  d.cargo,  f.cdescri as actividad, b.dfecapr, d.xfirma, d.nombre, " & _
                                        " space(90) as Usuario_Comite," & _
                                        " d.xfirma, d.xfirma as xfirma1, d.xfirma as xfirma2, d.xfirma as xfirma3, d.xfirma as xfirma4, d.xfirma as xfirma5," & _
                                        " SPACE(90) as Usuario_Comite_Des_1, SPACE(90) as Usuario_Comite_Des_2, SPACE(90) as Usuario_Comite_Des_3," & _
                                        " SPACE(90) as Usuario_Comite_Des_4, SPACE(90) as Usuario_Comite_Des_5," & _
                                        " isnull(b.usuario_comite_1,0) as usuario_comite_1, isnull(b.usuario_comite_2,0) as usuario_comite_2, " & _
                                        " isnull(b.usuario_comite_3,0) as usuario_comite_3, isnull(b.usuario_comite_4,0) as usuario_comite_4, " & _
                                        " isnull(b.usuario_comite_5,0) as usuario_comite_5, " & _
                                        " space(90) as Nivel_Comite_1, space(90) as Nivel_Comite_2, space(90) as Nivel_Comite_3, " & _
                                        " space(90) as Nivel_Comite_4, space(90) as Nivel_Comite_5, " & _
                                        " space(120) as descargo, space(120) as frecuencia, space(120) as programa, space(120) as destino, space(120) as sector,  " & _
                                        " ccodchk01 = '' , " & _
                                        " ccodchk02 = '', " & _
                                        " ccodchk03 = '', " & _
                                        " ccodchk04 = '', " & _
                                        " ccodchk05 = '', " & _
                                        " ntipgas01 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '01' and credgas.cdescob ='D' ) is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '01' and credgas.cdescob ='D') end, " & _
                                        " ntipgas02 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '02'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '02'  and credgas.cdescob ='D') end, " & _
                                        " ntipgas03 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '03'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '03'  and credgas.cdescob ='D') end, " & _
                                        " ntipgas04 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '04'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '04' and credgas.cdescob ='D') end, " & _
                                        " ntipgas05 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '05'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '05'  and credgas.cdescob ='D') end, " & _
                                        " ntipgas06 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '06'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas = '06'  and credgas.cdescob ='D') end, " & _
                                        " nOtros  = case when (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas <> '01' and credgas.ctipgas <> '02' and credgas.ctipgas <> '03' and credgas.ctipgas <> '04' and credgas.ctipgas <> '05' and credgas.ctipgas <> '06'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = '" & cCodcta & "' and credgas.ctipgas <> '01' and credgas.ctipgas <> '02' and credgas.ctipgas <> '03' and credgas.ctipgas <> '04' and credgas.ctipgas <> '05' and credgas.ctipgas <> '06'  and credgas.cdescob ='D') end " & _
                                        " FROM Climide a, Cremcre b,  usuarios d, tabttab e,  tabtciu f  " & _
                                        " WHERE a.ccodcli = b.ccodcli  " & _
                                        " and e.ccodigo = b.ccodfue and e.ctipreg ='1' and e.ccodtab ='033' and  f.ccodigo = b.ccodact  " & _
                                        " and b.ccodana= d.usuario and b.ccodcta = '" & cCodcta & "'"



                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Resolucion")


                'Usuario Comodin
                command.CommandText = _
                                        " select idUsuario, usuario, nombre, xfirma from usuarios " & _
                                        " where idUsuario = 1"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios_Valida")


                'Barre la tabla para igual a un null
                For Each fila As DataRow In ds_Trab.Tables("Usuarios_Valida").Rows
                    For Each Linea As DataRow In ds_Trab.Tables("Resolucion").Rows
                        Linea("xfirma2") = fila("xfirma")
                        Linea("xfirma3") = fila("xfirma")
                        Linea("xfirma4") = fila("xfirma")
                        Linea("xfirma5") = fila("xfirma")
                    Next
                Next


                'Extrayendo Usuarios de Firmas

                For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                    id_usuario_comite_1 = fila("usuario_comite_1")
                    id_usuario_comite_2 = fila("usuario_comite_2")
                    id_usuario_comite_3 = fila("usuario_comite_3")
                    id_usuario_comite_4 = fila("usuario_comite_4")
                    id_usuario_comite_5 = fila("usuario_comite_5")
                Next



                'Extrae Usuarios
                command.CommandText = _
                                        " select idUsuario, usuario, nombre, xfirma from usuarios " & _
                                        " where idUsuario In(" & id_usuario_comite_1 & "," & id_usuario_comite_2 & "," & id_usuario_comite_3 & "," & _
                                        id_usuario_comite_4 & "," & id_usuario_comite_5 & ")"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios")

                'Extrae niveles de Comite
                Dim ds_niveles As New DataSet
                Dim miComponente As New dbTabttab
                Dim lcComite As String = ""


                For Each Linea As DataRow In ds_Trab.Tables("Usuarios").Rows
                    For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                        If fila("usuario_comite_1") = Linea("idUsuario") Then
                            fila("Nivel_Comite_1") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_2") = Linea("idUsuario") Then
                            fila("Nivel_Comite_2") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_3") = Linea("idUsuario") Then
                            fila("Nivel_Comite_3") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_4") = Linea("idUsuario") Then
                            fila("Nivel_Comite_4") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                        If fila("usuario_comite_5") = Linea("idUsuario") Then
                            fila("Nivel_Comite_5") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                        End If
                    Next
                Next


                For Each Linea As DataRow In ds_Trab.Tables("Usuarios").Rows
                    For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                        If fila("usuario_comite_1") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_1") = Linea("nombre")
                            fila("xfirma1") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_2") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_2") = Linea("nombre")
                            fila("xfirma2") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_3") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_3") = Linea("nombre")
                            fila("xfirma3") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_4") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_4") = Linea("nombre")
                            fila("xfirma4") = Linea("xfirma")
                        End If
                        If fila("usuario_comite_5") = Linea("idUsuario") Then
                            fila("Usuario_Comite_Des_5") = Linea("nombre")
                            fila("xfirma5") = Linea("xfirma")
                        End If
                    Next
                Next


                ''Extrayendo Usuarios de Firmas
                'For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                '    id_usuario_comite_1 = fila("usuario_comite_1")
                '    id_usuario_comite_2 = fila("usuario_comite_2")
                '    id_usuario_comite_3 = fila("usuario_comite_3")
                '    id_usuario_comite_4 = fila("usuario_comite_4")
                '    id_usuario_comite_5 = fila("usuario_comite_5")
                'Next



                ''Extrae Usuarios
                'command.CommandText = _
                '                        " select idUsuario, usuario, nombre, xfirma from usuarios " & _
                '                        " where idUsuario In(" & id_usuario_comite_1 & "," & id_usuario_comite_2 & "," & id_usuario_comite_3 & "," & _
                '                        id_usuario_comite_4 & "," & id_usuario_comite_5 & ")"


                'command.CommandType = CommandType.Text

                'MyAdapter.SelectCommand = command

                'MyAdapter.Fill(ds_Trab, "Usuarios")

                ''Extrae niveles de Comite
                'Dim ds_niveles As New DataSet
                'Dim miComponente As New dbTabttab
                'Dim lcComite As String = ""


                'For Each Linea As DataRow In ds_Trab.Tables("Usuarios").Rows
                '    For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                '        If fila("usuario_comite_1") = Linea("idUsuario") Then
                '            fila("Nivel_Comite_1") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                '        End If
                '        If fila("usuario_comite_2") = Linea("idUsuario") Then
                '            fila("Nivel_Comite_2") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                '        End If
                '        If fila("usuario_comite_3") = Linea("idUsuario") Then
                '            fila("Nivel_Comite_3") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                '        End If
                '        If fila("usuario_comite_4") = Linea("idUsuario") Then
                '            fila("Nivel_Comite_4") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                '        End If
                '        If fila("usuario_comite_5") = Linea("idUsuario") Then
                '            fila("Nivel_Comite_5") = miComponente.Extraer_Comite_Usuario_(Linea("idusuario"))
                '        End If
                '    Next
                'Next


                'For Each Linea As DataRow In ds_Trab.Tables("Usuarios").Rows
                '    For Each fila As DataRow In ds_Trab.Tables("Resolucion").Rows
                '        If fila("usuario_comite_1") = Linea("idUsuario") Then
                '            fila("Usuario_Comite_Des_1") = Linea("nombre")
                '            fila("xfirma1") = Linea("xfirma")
                '        End If
                '        If fila("usuario_comite_2") = Linea("idUsuario") Then
                '            fila("Usuario_Comite_Des_2") = Linea("nombre")
                '            fila("xfirma2") = Linea("xfirma")
                '        End If
                '        If fila("usuario_comite_3") = Linea("idUsuario") Then
                '            fila("Usuario_Comite_Des_3") = Linea("nombre")
                '            fila("xfirma3") = Linea("xfirma")
                '        End If
                '        If fila("usuario_comite_4") = Linea("idUsuario") Then
                '            fila("Usuario_Comite_Des_4") = Linea("nombre")
                '            fila("xfirma4") = Linea("xfirma")
                '        End If
                '        If fila("usuario_comite_5") = Linea("idUsuario") Then
                '            fila("Usuario_Comite_Des_5") = Linea("nombre")
                '            fila("xfirma5") = Linea("xfirma")
                '        End If
                '    Next
                'Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function ObtieneResolucion(ByVal cCodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select a.ccodcli, a.cnomcli, ")
        strSQL.Append("b.ccodcta, ")
        strSQL.Append("b.nmonapr as nmonsug, b.ncuosug, b.cfreccap, b.cfrecint, b.ntasint, b.nmoncuo, ")
        strSQL.Append("b.ccodusu, d.nombre,  ")
        strSQL.Append("b.ccodfue, b.cdescre, b.cprograma, b.nmeses,  b.csececo,  ")
        strSQL.Append("e.cdescri as fondos,  d.cargo,  f.cdescri as actividad, b.dfecapr,  ")
        strSQL.Append("space(120) as descargo, space(120) as frecuencia, space(120) as programa, space(120) as destino, space(120) as sector,  ")
        strSQL.Append(" ccodchk01 = '' , ")
        strSQL.Append(" ccodchk02 = '', ")
        strSQL.Append(" ccodchk03 = '', ")
        strSQL.Append(" ccodchk04 = '', ")
        strSQL.Append(" ccodchk05 = '', ")
        strSQL.Append(" ntipgas01 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '01' and credgas.cdescob ='D' ) is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '01' and credgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas02 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '02'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '02'  and credgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas03 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '03'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '03'  and credgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas04 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '04'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '04' and credgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas05 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '05'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '05'  and credgas.cdescob ='D') end, ")
        strSQL.Append(" ntipgas06 = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '06'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas = '06'  and credgas.cdescob ='D') end, ")
        strSQL.Append(" nOtros  = case when (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas <> '01' and credgas.ctipgas <> '02' and credgas.ctipgas <> '03' and credgas.ctipgas <> '04' and credgas.ctipgas <> '05' and credgas.ctipgas <> '06'  and credgas.cdescob ='D') is null then '0' else (select credgas.nmongas  from credgas where credgas.ccodcta = @ccodcta and credgas.ctipgas <> '01' and credgas.ctipgas <> '02' and credgas.ctipgas <> '03' and credgas.ctipgas <> '04' and credgas.ctipgas <> '05' and credgas.ctipgas <> '06'  and credgas.cdescob ='D') end ")
        strSQL.Append("FROM Climide a, Cremcre b,  usuarios d, tabttab e,  tabtciu f  ")
        strSQL.Append("WHERE a.ccodcli = b.ccodcli  ")
        strSQL.Append("and e.ccodigo = b.ccodfue and e.ctipreg ='1' and e.ccodtab ='033' and  f.ccodigo = b.ccodact  ")
        strSQL.Append("and b.ccodana= d.usuario and b.ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim etabttab As New dbTabttab
        For Each fila As DataRow In ds.Tables(0).Rows
            fila("descargo") = etabttab.Describe(fila("cargo"), "053")
            fila("frecuencia") = etabttab.Describe(fila("cfreccap"), "060")
            fila("programa") = etabttab.Describe(fila("cprograma"), "100")
            fila("destino") = etabttab.Describe(fila("cdescre"), "005")
            fila("Sector") = etabttab.Describe(fila("csececo"), "021")



        Next

        Return ds
    End Function
End Class
