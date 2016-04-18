Imports System.Text
Public Class dbTabttab
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabttab
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodigo =  "" _
            Or lEntidad.ccodigo = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodigo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabttab ")
        strSQL.Append(" SET corden = @corden, ") 
        strSQL.Append(" cdescri = @cdescri, ") 
        strSQL.Append(" llogtab = @llogtab, ") 
        strSQL.Append(" dfectab = @dfectab, ") 
        strSQL.Append(" cstrtab = @cstrtab, ") 
        strSQL.Append(" nnumtab = @nnumtab, ") 
        strSQL.Append(" maditab = @maditab, ") 
        strSQL.Append(" lmodifi = @lmodifi, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" nflag = @nflag, ") 
        strSQL.Append(" coordinado = @coordinado, ") 
        strSQL.Append(" ccodcta = @ccodcta ") 
        strSQL.Append(" ccodana = @ccodana, ") 
        strSQL.Append(" IdCodigo = @IdCodigo, ") 
        strSQL.Append(" WHERE ccodtab = @ccodtab ") 
        strSQL.Append(" AND ctipreg = @ctipreg ") 
        strSQL.Append(" AND ccodigo = @ccodigo ") 

        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@corden", SqlDbType.VarChar)
        args(0).Value = lEntidad.corden
        args(1) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdescri
        args(2) = New SqlParameter("@llogtab", SqlDbType.Bit)
        args(2).Value = lEntidad.llogtab
        args(3) = New SqlParameter("@dfectab", SqlDbType.Datetime)
        args(3).Value = lEntidad.dfectab
        args(4) = New SqlParameter("@cstrtab", SqlDbType.VarChar)
        args(4).Value = lEntidad.cstrtab
        args(5) = New SqlParameter("@nnumtab", SqlDbType.VarChar)
        args(5).Value = lEntidad.nnumtab
        args(6) = New SqlParameter("@maditab", SqlDbType.VarChar)
        args(6).Value = lEntidad.maditab
        args(7) = New SqlParameter("@lmodifi", SqlDbType.Bit)
        args(7).Value = lEntidad.lmodifi
        args(8) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodusu
        args(9) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecmod
        args(10) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(10).Value = lEntidad.cflag
        args(11) = New SqlParameter("@nflag", SqlDbType.VarChar)
        args(11).Value = lEntidad.nflag
        args(12) = New SqlParameter("@coordinado", SqlDbType.VarChar)
        args(12).Value = lEntidad.coordinado
        args(13) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodcta
        args(14) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodana
        args(15) = New SqlParameter("@IdCodigo", SqlDbType.VarChar)
        args(15).Value = lEntidad.IdCodigo
        args(16) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(16).Value = IIf(lEntidad.ccodtab = Nothing, DBNull.Value,lEntidad.ccodtab)
        args(17) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(17).Value = IIf(lEntidad.ctipreg = Nothing, DBNull.Value,lEntidad.ctipreg)
        args(18) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(18).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value,lEntidad.ccodigo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabttab
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabttab ")
        strSQL.Append(" ( corden, ") 
        strSQL.Append(" ccodtab, ") 
        strSQL.Append(" ctipreg, ") 
        strSQL.Append(" ccodigo, ") 
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" llogtab, ") 
        strSQL.Append(" dfectab, ") 
        strSQL.Append(" cstrtab, ") 
        strSQL.Append(" nnumtab, ") 
        strSQL.Append(" maditab, ") 
        strSQL.Append(" lmodifi, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" nflag, ") 
        strSQL.Append(" coordinado, ") 
        strSQL.Append(" ccodcta) ") 
        strSQL.Append(" ccodana, ") 
        strSQL.Append(" IdCodigo, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @corden, ") 
        strSQL.Append(" @ccodtab, ") 
        strSQL.Append(" @ctipreg, ") 
        strSQL.Append(" @ccodigo, ") 
        strSQL.Append(" @cdescri, ") 
        strSQL.Append(" @llogtab, ") 
        strSQL.Append(" @dfectab, ") 
        strSQL.Append(" @cstrtab, ") 
        strSQL.Append(" @nnumtab, ") 
        strSQL.Append(" @maditab, ") 
        strSQL.Append(" @lmodifi, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @nflag, ") 
        strSQL.Append(" @coordinado, ") 
        strSQL.Append(" @ccodcta) ") 
        strSQL.Append(" @ccodana, ") 
        strSQL.Append(" @IdCodigo, ") 

        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@corden", SqlDbType.VarChar)
        args(0).Value = lEntidad.corden
        args(1) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodtab = Nothing, DBNull.Value, lEntidad.ccodtab)
        args(2) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ctipreg = Nothing, DBNull.Value, lEntidad.ctipreg)
        args(3) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value, lEntidad.ccodigo)
        args(4) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdescri
        args(5) = New SqlParameter("@llogtab", SqlDbType.Bit)
        args(5).Value = lEntidad.llogtab
        args(6) = New SqlParameter("@dfectab", SqlDbType.Datetime)
        args(6).Value = lEntidad.dfectab
        args(7) = New SqlParameter("@cstrtab", SqlDbType.VarChar)
        args(7).Value = lEntidad.cstrtab
        args(8) = New SqlParameter("@nnumtab", SqlDbType.VarChar)
        args(8).Value = lEntidad.nnumtab
        args(9) = New SqlParameter("@maditab", SqlDbType.VarChar)
        args(9).Value = lEntidad.maditab
        args(10) = New SqlParameter("@lmodifi", SqlDbType.Bit)
        args(10).Value = lEntidad.lmodifi
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu
        args(12) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(12).Value = lEntidad.dfecmod
        args(13) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(13).Value = lEntidad.cflag
        args(14) = New SqlParameter("@nflag", SqlDbType.VarChar)
        args(14).Value = lEntidad.nflag
        args(15) = New SqlParameter("@coordinado", SqlDbType.VarChar)
        args(15).Value = lEntidad.coordinado
        args(16) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(16).Value = lEntidad.ccodcta
        args(17) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(17).Value = lEntidad.ccodana
        args(18) = New SqlParameter("@IdCodigo", SqlDbType.VarChar)
        args(18).Value = lEntidad.IdCodigo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabttab
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabttab ")
        strSQL.Append(" WHERE ccodtab = @ccodtab ") 
        strSQL.Append(" AND ctipreg = @ctipreg ") 
        strSQL.Append(" AND ccodigo = @ccodigo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodtab
        args(1) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipreg
        args(2) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodigo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabttab
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ") 
        strSQL.Append(" AND ctipreg = @ctipreg ") 
        strSQL.Append(" AND ccodigo = @ccodigo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodtab
        args(1) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipreg
        args(2) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodigo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.corden = IIf(.Item("corden") Is DBNull.Value, Nothing, .Item("corden"))
                lEntidad.cdescri = IIf(.Item("cdescri") Is DBNull.Value, Nothing, .Item("cdescri"))
                lEntidad.llogtab = IIf(.Item("llogtab") Is DBNull.Value, Nothing, .Item("llogtab"))
                lEntidad.dfectab = IIf(.Item("dfectab") Is DBNull.Value, Nothing, .Item("dfectab"))
                lEntidad.cstrtab = IIf(.Item("cstrtab") Is DBNull.Value, Nothing, .Item("cstrtab"))
                lEntidad.nnumtab = IIf(.Item("nnumtab") Is DBNull.Value, Nothing, .Item("nnumtab"))
                lEntidad.maditab = IIf(.Item("maditab") Is DBNull.Value, Nothing, .Item("maditab"))
                lEntidad.lmodifi = IIf(.Item("lmodifi") Is DBNull.Value, Nothing, .Item("lmodifi"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.nflag = IIf(.Item("nflag") Is DBNull.Value, Nothing, .Item("nflag"))
                lEntidad.coordinado = IIf(.Item("coordinado") Is DBNull.Value, Nothing, .Item("coordinado"))
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.ccodana = IIf(.Item("ccodana") Is DBNull.Value, Nothing, .Item("ccodana"))
                lEntidad.IdCodigo = IIf(.Item("IdCodigo") Is DBNull.Value, Nothing, .Item("IdCodigo"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabttab
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodigo),0) + 1 ")
        strSQL.Append(" FROM tabttab ")
        strSQL.Append(" WHERE ccodtab = @ccodtab ") 
        strSQL.Append(" AND ctipreg = @ctipreg ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodtab
        args(1) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipreg

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetPorID2(ByVal ccodtab As String, ByVal ctipreg As String, ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")
        strSQL.Append(" and cCodigo = @ccodigo")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)
        args(2) = New SqlParameter("@ccodigo", cCodigo)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    Public Function ObtenerListaPorID(ByVal ccodtab As String, ByVal ctipreg As String) As listatabttab

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg  and cflag <>'*'")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(0).Value = ccodtab
        args(1) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(1).Value = ctipreg

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabttab

        Try
            Do While dr.Read()
                Dim mEntidad As New tabttab
                mEntidad.corden = IIf(dr("corden") Is DBNull.Value, Nothing, dr("corden"))
                mEntidad.ccodtab = ccodtab
                mEntidad.ctipreg = ctipreg
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.cdescri_ = IIf(dr("cdescri_") Is DBNull.Value, Nothing, dr("cdescri_"))
                mEntidad.llogtab = IIf(dr("llogtab") Is DBNull.Value, Nothing, dr("llogtab"))
                mEntidad.dfectab = IIf(dr("dfectab") Is DBNull.Value, Nothing, dr("dfectab"))
                mEntidad.cstrtab = IIf(dr("cstrtab") Is DBNull.Value, Nothing, dr("cstrtab"))
                mEntidad.nnumtab = IIf(dr("nnumtab") Is DBNull.Value, Nothing, dr("nnumtab"))
                mEntidad.maditab = IIf(dr("maditab") Is DBNull.Value, Nothing, dr("maditab"))
                mEntidad.lmodifi = IIf(dr("lmodifi") Is DBNull.Value, Nothing, dr("lmodifi"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.nflag = IIf(dr("nflag") Is DBNull.Value, Nothing, dr("nflag"))
                mEntidad.coordinado = IIf(dr("coordinado") Is DBNull.Value, Nothing, dr("coordinado"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.IdCodigo = IIf(dr("IdCodigo") Is DBNull.Value, Nothing, dr("IdCodigo"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodtab As String, ByVal ctipreg As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim tables(0) As String
        tables(0) = New String("tabttab")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT corden, ")
        strSQL.Append(" ccodtab, ")
        strSQL.Append(" ctipreg, ")
        strSQL.Append(" rtrim(ltrim(ccodigo)) as ccodigo, ")
        strSQL.Append(" (ccodigo + '|' + cdescri) as cdescri_, ")
        strSQL.Append(" cdescri, ")
        strSQL.Append(" llogtab, ")
        strSQL.Append(" dfectab, ")
        strSQL.Append(" cstrtab, ")
        strSQL.Append(" nnumtab, ")
        strSQL.Append(" maditab, ")
        strSQL.Append(" lmodifi, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" nflag, ")
        strSQL.Append(" coordinado, ")
        strSQL.Append(" ccodcta, ")
        strSQL.Append(" ccodana, ")
        strSQL.Append(" IdCodigo, ")
        strSQL.Append(" 0000000000.00 AS  ncapdes, ")
        strSQL.Append(" 0000000000.00 AS  nsalcap, ")
        strSQL.Append(" 0000000000.00 AS  nmora, ")
        strSQL.Append(" 0000000000.00 AS  nsalint, ")
        strSQL.Append(" 0000000000.00 AS  nsalmor, ")
        strSQL.Append(" 0000000000.00 AS  nporc1, ")
        strSQL.Append(" 0000000000.00 AS  nporc2 ")
        strSQL.Append(" FROM tabttab ")

    End Sub
    Public Function Describe(ByVal lccodigo As String, ByVal lctabla As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cdescri from tabttab ")
        strSQL.Append("WHERE rtrim(ltrim(cCodigo)) = @lcCodigo")
        strSQL.Append(" and ccodtab = @lctabla and ctipreg = '1'")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo
        args(1) = New SqlParameter("@lctabla", SqlDbType.Char)
        args(1).Value = lctabla
        Dim lcestciv As String
        Dim dstab As DataSet
        dstab = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dstab.Tables(0).Rows.Count = 0 Then
            lcestciv = "NO INDICADO"
        Else
            lcestciv = dstab.Tables(0).Rows(0)("cdescri")
        End If
        Return lcestciv.Trim
    End Function
    Public Function TablasTab(ByVal lctabla As String, ByVal lccodigo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ltrim(rtrim(cdescri)) as cdescri, ltrim(rtrim(ccodigo)) as ccodigo from tabttab ")
        strSQL.Append("WHERE cCodigo <> @lccodigo")
        strSQL.Append(" and ccodtab = @lctabla and ctipreg = '1' order by corden")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo
        args(1) = New SqlParameter("@lctabla", SqlDbType.Char)
        args(1).Value = lctabla

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function ObtenerListaPorIDxcodigo(ByVal ccodtab As String, ByVal ctipreg As String, ByVal ccodigo As String) As listatabttab

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")
        ' strSQL.Append(" AND left(ccodigo,2) = left(@ccodigo,2)")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(0).Value = ccodtab
        args(1) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(1).Value = ctipreg
        'args(2) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        'args(2).Value = ccodigo

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabttab

        Try
            Do While dr.Read()
                Dim mEntidad As New tabttab
                mEntidad.corden = IIf(dr("corden") Is DBNull.Value, Nothing, dr("corden"))
                mEntidad.ccodtab = ccodtab
                mEntidad.ctipreg = ctipreg
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.llogtab = IIf(dr("llogtab") Is DBNull.Value, Nothing, dr("llogtab"))
                mEntidad.dfectab = IIf(dr("dfectab") Is DBNull.Value, Nothing, dr("dfectab"))
                mEntidad.cstrtab = IIf(dr("cstrtab") Is DBNull.Value, Nothing, dr("cstrtab"))
                mEntidad.nnumtab = IIf(dr("nnumtab") Is DBNull.Value, Nothing, dr("nnumtab"))
                mEntidad.maditab = IIf(dr("maditab") Is DBNull.Value, Nothing, dr("maditab"))
                mEntidad.lmodifi = IIf(dr("lmodifi") Is DBNull.Value, Nothing, dr("lmodifi"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.nflag = IIf(dr("nflag") Is DBNull.Value, Nothing, dr("nflag"))
                mEntidad.coordinado = IIf(dr("coordinado") Is DBNull.Value, Nothing, dr("coordinado"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.IdCodigo = IIf(dr("IdCodigo") Is DBNull.Value, Nothing, dr("IdCodigo"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = '146' ")
        strSQL.Append(" AND ctipreg = '1'  and cflag <>'*' order by cdescri desc")

        Dim tables(0) As String
        tables(0) = New String("tabttab")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function
    Public Function ObtenerFrecuencia(ByVal cfrecuencia As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cdescri, ltrim(rtrim(ccodigo)) as ccodigo from tabttab ")
        strSQL.Append(" WHERE ccodtab = '060' ")
        strSQL.Append(" AND ctipreg = '1' ")

        If cfrecuencia.Trim = "A" Then
            strSQL.Append("and (left(ccodigo,1) = 'A' ")
            strSQL.Append("or left(ccodigo,1) = 'M') ")
        ElseIf cfrecuencia.Trim = "D" Then
            strSQL.Append("and left(ccodigo,1) = 'D' ")
        ElseIf cfrecuencia.Trim = "S" Then
            strSQL.Append("and (left(ccodigo,1) = 'S') ")
        ElseIf cfrecuencia.Trim = "Q" Then
            strSQL.Append("and (left(ccodigo,1) = 'Q') ")
        ElseIf cfrecuencia.Trim = "B" Then

            strSQL.Append("and (left(ccodigo,1) = 'B') ")
        ElseIf cfrecuencia.Trim = "M" Then

            strSQL.Append("and (left(ccodigo,1) = 'M') ")
        ElseIf cfrecuencia.Trim = "I" Then

            strSQL.Append("and (left(ccodigo,1) = 'M' ")
            strSQL.Append("or left(ccodigo,1) = 'I') ")
        ElseIf cfrecuencia.Trim = "T" Then

            strSQL.Append("and (left(ccodigo,1) = 'M' ")

            strSQL.Append("or left(ccodigo,1) = 'T') ")
        ElseIf cfrecuencia.Trim = "C" Then
            strSQL.Append("and (left(ccodigo,1) = 'M' ")
            strSQL.Append("or left(ccodigo,1) = 'C') ")

        ElseIf cfrecuencia.Trim = "E" Then
            strSQL.Append("and (left(ccodigo,1) = 'M' ")
            strSQL.Append("or left(ccodigo,1) = 'E') ")
        ElseIf cfrecuencia.Trim = "N" Then

            strSQL.Append("and (left(ccodigo,1) = 'M' ")
            strSQL.Append("or left(ccodigo,1) = 'N') ")
        ElseIf cfrecuencia.Trim = "X" Then
            strSQL.Append("and left(ccodigo,1) = 'X' ")
        End If

        
        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerTipodePago(ByVal nnivel As Integer) As listatabttab

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = '146' ")
        strSQL.Append(" AND ctipreg = '1'  and cflag <>'*'")
        If nnivel < 7 Then
            strSQL.Append(" and rtrim(ltrim(ccodigo)) <> 'I' ")
        End If


        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@nnivel", SqlDbType.Int)
        args(0).Value = nnivel
        
        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabttab

        Try
            Do While dr.Read()
                Dim mEntidad As New tabttab
                mEntidad.corden = IIf(dr("corden") Is DBNull.Value, Nothing, dr("corden"))
                mEntidad.ccodtab = "146"
                mEntidad.ctipreg = "1"
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.llogtab = IIf(dr("llogtab") Is DBNull.Value, Nothing, dr("llogtab"))
                mEntidad.dfectab = IIf(dr("dfectab") Is DBNull.Value, Nothing, dr("dfectab"))
                mEntidad.cstrtab = IIf(dr("cstrtab") Is DBNull.Value, Nothing, dr("cstrtab"))
                mEntidad.nnumtab = IIf(dr("nnumtab") Is DBNull.Value, Nothing, dr("nnumtab"))
                mEntidad.maditab = IIf(dr("maditab") Is DBNull.Value, Nothing, dr("maditab"))
                mEntidad.lmodifi = IIf(dr("lmodifi") Is DBNull.Value, Nothing, dr("lmodifi"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.nflag = IIf(dr("nflag") Is DBNull.Value, Nothing, dr("nflag"))
                mEntidad.coordinado = IIf(dr("coordinado") Is DBNull.Value, Nothing, dr("coordinado"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.IdCodigo = IIf(dr("IdCodigo") Is DBNull.Value, Nothing, dr("IdCodigo"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerDataSetPorIDx(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("select ccodigo, cdescri, 0 as lmodifi, cstrtab, cflag, 000 as ncontados from tabttab ")
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")
        strSQL.Append(" order by ccodigo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function VerificaUsuarioCajero(ByVal ccodigo As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodana FROM TABTTAB ")
        strSQL.Append("WHERE ccodtab = '187' and ccodana = @ccodigo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lverifica As Boolean = False

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodana")) Then
            Else
                lverifica = True
            End If
        End If

        Return lverifica
    End Function
    Public Function ObtieneCodigoCajero(ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select left(cCodigo,2) as cCodigo FROM TABTTAB ")
        strSQL.Append("WHERE ccodtab = '187' and ccodana = @ccodigo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodigo As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodigo")) Then
            Else
                lccodigo = ds.Tables(0).Rows(0)("ccodigo")
            End If
        End If

        Return lccodigo
    End Function

    Public Function ObtieneTipoCajero(ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cstrtab FROM tabttab ")
        strSQL.Append("Where ccodtab = '187' and ccodigo = @ccodigo ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcstrtab As String = ""

        Dim lccajero As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cstrtab")) Then
            Else
                lcstrtab = ds.Tables(0).Rows(0)("cstrtab")
                If lcstrtab.Trim = "" Then
                    lccajero = "P"
                Else
                    lccajero = "E"
                End If
            End If
        End If

        Return lccajero
    End Function
    Public Function ObtieneContabledelCajero(ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodcta FROM tabttab ")
        strSQL.Append("WHERE ccodtab = '187' and ctipreg = '1' and  cCodigo = @cCodigo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodcta As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodcta")) Then
            Else
                lccodcta = ds.Tables(0).Rows(0)("ccodcta")
            End If
        End If

        Return lccodcta
    End Function
    Public Function ObtieneContabledelCajero2(ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodana FROM tabttab ")
        strSQL.Append("WHERE ccodtab = '187' and ctipreg = '1' and  cCodigo = @cCodigo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodcta As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodana")) Then
            Else
                lccodcta = ds.Tables(0).Rows(0)("ccodana")
            End If
        End If

        Return lccodcta.Trim
    End Function
    Public Function DescribeAux(ByVal lccodigo As String, ByVal lctabla As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cstrtab from tabttab ")
        strSQL.Append("WHERE cCodigo = @lcCodigo")
        strSQL.Append(" and ccodtab = @lctabla and ctipreg = '1'")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo
        args(1) = New SqlParameter("@lctabla", SqlDbType.Char)
        args(1).Value = lctabla
        Dim lcestciv As String
        Dim dstab As DataSet
        dstab = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dstab.Tables(0).Rows.Count = 0 Then
            lcestciv = "NO INDICADO"
        Else
            lcestciv = dstab.Tables(0).Rows(0)("cstrtab")
        End If
        Return lcestciv
    End Function
    Public Function CargaListadoChkGastos() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodigo, cdescri ,'1' as  llogtab, 000000.00 as nmongas, 000000.00 as ngasori, 000000.00 as nmonto, tabttab.nflag FROM TABTTAB ")
        strSQL.Append("WHERE ccodtab ='008' and ctipreg ='1'  ")
        strSQL.Append(" and llogtab ='1'  ")
        strSQL.Append("order by ccodigo ")
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function
    Public Function ObtenerDataSetCamposAdicionales(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cdescri, ccodigo, ")
        strSQL.Append("000000.00 as npromediod, 000000.00 as npromediom, ")
        strSQL.Append("0 as llu, 0 as lma, 0 as lmi, 0 as lju, 0 as lvi, 0 as lsa, 0 as ldo, ")
        strSQL.Append("0 as lene, 0 as lfeb, 0 as lmar, 0 as labr, 0 as lmay, 0 as ljun, ")
        strSQL.Append("0 as ljul, 0 as lago, 0 as lsep, 0 as loct, 0 as lnov, 0 as ldic ")
        strSQL.Append("FROM TABTTAB WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerListaPorIDOrdenado(ByVal ccodtab As String, ByVal ctipreg As String) As listatabttab

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg  and cflag <>'*'")
        strSQL.Append(" order by ccodigo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", SqlDbType.VarChar)
        args(0).Value = ccodtab
        args(1) = New SqlParameter("@ctipreg", SqlDbType.VarChar)
        args(1).Value = ctipreg

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabttab

        Try
            Do While dr.Read()
                Dim mEntidad As New tabttab
                mEntidad.corden = IIf(dr("corden") Is DBNull.Value, Nothing, dr("corden"))
                mEntidad.ccodtab = ccodtab
                mEntidad.ctipreg = ctipreg
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.llogtab = IIf(dr("llogtab") Is DBNull.Value, Nothing, dr("llogtab"))
                mEntidad.dfectab = IIf(dr("dfectab") Is DBNull.Value, Nothing, dr("dfectab"))
                mEntidad.cstrtab = IIf(dr("cstrtab") Is DBNull.Value, Nothing, dr("cstrtab"))
                mEntidad.nnumtab = IIf(dr("nnumtab") Is DBNull.Value, Nothing, dr("nnumtab"))
                mEntidad.maditab = IIf(dr("maditab") Is DBNull.Value, Nothing, dr("maditab"))
                mEntidad.lmodifi = IIf(dr("lmodifi") Is DBNull.Value, Nothing, dr("lmodifi"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.nflag = IIf(dr("nflag") Is DBNull.Value, Nothing, dr("nflag"))
                mEntidad.coordinado = IIf(dr("coordinado") Is DBNull.Value, Nothing, dr("coordinado"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.IdCodigo = IIf(dr("IdCodigo") Is DBNull.Value, Nothing, dr("IdCodigo"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtieneCodigoxCampoAuxiliar(ByVal lccodigo As String, ByVal lctabla As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodigo from tabttab ")
        strSQL.Append("WHERE cstrtab = @lcCodigo")
        strSQL.Append(" and ccodtab = @lctabla and ctipreg = '1'")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo
        args(1) = New SqlParameter("@lctabla", SqlDbType.Char)
        args(1).Value = lctabla
        Dim lcestciv As String
        Dim dstab As DataSet
        dstab = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dstab.Tables(0).Rows.Count = 0 Then
            lcestciv = "01"
        Else
            lcestciv = Trim(dstab.Tables(0).Rows(0)("ccodigo"))
        End If
        Return lcestciv
    End Function
    Public Function ObtenerDatasetTabla(ByVal lctabla As String, ByVal ccodins As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ltrim(rtrim(cdescri)) as cdescri, ltrim(rtrim(ccodigo)) as ccodigo from tabttab ")
        strSQL.Append("WHERE ")
        strSQL.Append(" ccodtab = @lctabla and ctipreg = '1'  ")
        If ccodins.Trim = "001" Then
        Else
            strSQL.Append(" and ccodigo = @ccodins  ")
        End If
        strSQL.Append(" order by cdescri ")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lctabla", SqlDbType.Char)
        args(0).Value = lctabla
        args(1) = New SqlParameter("@ccodins", SqlDbType.Char)
        args(1).Value = ccodins

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function ObtenerDataSetCondicionado(ByVal ccodtab As String, ByVal ctipreg As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("select ccodigo, cdescri, cstrtab from tabttab ")
        strSQL.Append(" WHERE ccodtab = @ccodtab ")
        strSQL.Append(" AND ctipreg = @ctipreg  and llogtab ='1' ")
        strSQL.Append(" order by ccodigo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ctipreg", ctipreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function ObtenerCuentadeOperacionesCaja(ByVal ccodtab As String, ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select ccodcta from tabttab ")
        strSQL.Append("where ccodtab = @ccodtab and ctipreg ='1' and ccodigo = @ccodigo ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcstrtab As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodcta")) Then
            Else
                lcstrtab = ds.Tables(0).Rows(0)("ccodcta")
            End If
        End If
        Return lcstrtab
    End Function
    Public Function ObtenerTipodeOperacionesCaja(ByVal ccodtab As String, ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select cstrtab from tabttab ")
        strSQL.Append("where ccodtab = @ccodtab and ctipreg ='1' and ccodigo = @ccodigo ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcstrtab As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cstrtab")) Then
            Else
                lcstrtab = ds.Tables(0).Rows(0)("cstrtab")
            End If
        End If
        Return lcstrtab
    End Function
    Public Function ObtenerCondicionadoscFlag(ByVal lctabla As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" Select ltrim(rtrim(cdescri)) as cdescri, ltrim(rtrim(ccodigo)) as ccodigo, nnumtab from tabttab ")
        strSQL.Append(" WHERE cflag = '*'")
        strSQL.Append(" and ccodtab = @lctabla and ctipreg = '1' order by corden")

        Dim a As String
        a = strSQL.ToString

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@lctabla", SqlDbType.Char)
        args(0).Value = lctabla

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function GrabarTabttabNumerico(ByVal ccodtab As String, ByVal ccodigo As String, ByVal nnumtab As Integer) As Integer
        Dim command As New SqlCommand
        Dim lnretorno As Integer = 0

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "update tabttab set nnumtab ='" & nnumtab & "' where ccodigo ='" & ccodigo & "' and ccodtab ='" & ccodtab & "'"
                command.ExecuteNonQuery()
                lnretorno = 1
            Catch ex As Exception
                lnretorno = 0
            Finally
                conneccion.Close()
            End Try

        End Using
        Return lnretorno

    End Function
    Public Function ObtenerFactor(ByVal ccodtab As String, ByVal ccodigo As String) As Decimal
        Dim command As New SqlCommand
        Dim ds As New DataSet
        Dim lnretorno As Decimal = 0
        Dim myadapter As New SqlDataAdapter
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select nnumtab from tabttab  where ccodigo ='" & ccodigo & "' and ccodtab ='" & ccodtab & "'"
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Factor")
                For Each fila As DataRow In ds.Tables("Factor").Rows
                    lnretorno = fila("nnumtab")
                Next

            Catch ex As Exception
                lnretorno = 0
            Finally
                conneccion.Close()
            End Try

        End Using
        Return lnretorno

    End Function


    Public Function ObtenerDescripcion(ByVal ccodtab As String, ByVal ccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select cdescri from tabttab ")
        strSQL.Append("where ccodtab = @ccodtab and ctipreg ='1' and ccodigo = @ccodigo ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodtab", ccodtab)
        args(1) = New SqlParameter("@ccodigo", ccodigo)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcdescri As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cdescri")) Then
            Else
                lcdescri = ds.Tables(0).Rows(0)("cdescri")
            End If
        End If
        Return lcdescri
    End Function


    Public Function Mantenimiento_Niveles_Aprobacion(ByVal Detalle_Cta As ArrayList) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcDesOfi As String = ""
        Dim ds As New DataSet
        Dim lID As String = ""

        'Detalle_Cta.Item(0)        'ID
        'Detalle_Cta.Item(1)        'Descripcion
        'Detalle_Cta.Item(2)        'Limite Inferior
        'Detalle_Cta.Item(3)        'Limite Inferior
        'Detalle_Cta.Item(4)        'Observaciones
        'Detalle_Cta.Item(5)        'Usuario
        'Detalle_Cta.Item(6)        'Fecha de asignacion



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try



                If Detalle_Cta.Item(0).ToString.Trim = "0" Then

                    'Extrae Correlativo de Partida
                    command.CommandText = _
                                            " Select isnull(max(CODIGO_NIVEL_APROBACION),0)+1 as Id From niveles_aprobacion "

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds, "niveles_aprobacion")

                    For Each fila As DataRow In ds.Tables("niveles_aprobacion").Rows
                        lID = fila("Id").ToString.Trim
                    Next

                    i = Double.Parse(lID)


                    lID = occlass.fxStrZero(i, 4)



                    command.CommandText = _
                                            " Insert Into niveles_aprobacion (CODIGO_NIVEL_APROBACION, DESCRIPCION, CODIGO_MONEDA, LIMITE_INFERIOR, LIMITE_SUPERIOR," & _
                                            " OBSERVACIONES, ADICIONADO_POR, FECHA_ADICION, MODIFICADO_POR, FECHA_MODIFICACION, CCODUSU, DFECMOD)" & _
                                            " Values ('" & lID & "','" & Detalle_Cta(1) & "','1'," & Detalle_Cta(2) & "," & Detalle_Cta(3) & ",'" & _
                                            Detalle_Cta(4) & "','" & Detalle_Cta(5) & "','" & Detalle_Cta(6) & "','" & Detalle_Cta(5) & "', getdate(),'" & _
                                            Detalle_Cta.Item(5) & "',getdate())"

                    command.ExecuteNonQuery()

                Else                        'Modificacion de cuenta  
                    command.CommandText = _
                                            " Update niveles_aprobacion Set LIMITE_INFERIOR =" & Detalle_Cta(2) & ", LIMITE_SUPERIOR =" & Detalle_Cta(3) & "," & _
                                            " DESCRIPCION='" & Detalle_Cta.Item(1) & "', OBSERVACIONES ='" & Detalle_Cta.Item(4) & "'," & _
                                            " FECHA_MODIFICACION = GETDATE() , MODIFICADO_POR ='" & Detalle_Cta.Item(5) & "'," & _
                                            " dfecmod = GETDATE(), ccodusu ='" & Detalle_Cta.Item(5) & "'" & _
                                            " Where CODIGO_NIVEL_APROBACION ='" & Detalle_Cta.Item(0) & "'"

                    command.ExecuteNonQuery()

                End If



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


    Public Function Mantenimiento_Usuarios_Niveles_Aprobacion(ByVal Detalle_Cta As ArrayList) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcDesOfi As String = ""
        Dim ds As New DataSet
        Dim lID As String = ""

        'Detalle_Cta.Item(0)        'Codigo Nivel de Comite
        'Detalle_Cta.Item(1)        'Codigo usuario del sistema Asignado        
        'Detalle_Cta.Item(2)        'Usuario del sistema Asignado        
        'Detalle_Cta.Item(3)        'Iniciales Usuario
        'Detalle_Cta.Item(4)        'Usuario que modifica
        'Detalle_Cta.Item(5)        'Fecha de asignacion


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try

                'Verifica si es Modificación
                command.CommandText = _
                                        " Select * From usuarios_nivel_aprobacion Where idusuario =" & Detalle_Cta(1)

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Usuarios_nivel_aprobacion")


                'Nuevo
                If ds.Tables(0).Rows.Count = 0 Then




                    'Detalle_Cta.Item(0)        'Codigo Nivel de Comite
                    'Detalle_Cta.Item(1)        'Codigo usuario del sistema Asignado        
                    'Detalle_Cta.Item(2)        'Usuario del sistema Asignado        
                    'Detalle_Cta.Item(3)        'Iniciales Usuario
                    'Detalle_Cta.Item(4)        'Usuario que modifica
                    'Detalle_Cta.Item(5)        'Fecha de asignacion


                    command.CommandText = _
                                            " Insert Into usuarios_nivel_aprobacion (idusuario, codigo_usuario, codigo_nivel_aprobacion,	nombre_usuario,	dfecmod, ccodusu )" & _
                                            " Values (" & Detalle_Cta(1) & ",'" & Detalle_Cta(3) & "','" & Detalle_Cta(0) & "','" & Detalle_Cta(2) & "',getdate(),'" & _
                                            Detalle_Cta(4) & "')"


                    command.ExecuteNonQuery()

                Else                        'Modificacion de cuenta  

                    command.CommandText = _
                                            " Delete from usuarios_nivel_aprobacion " & _
                                            " Where idusuario =" & Detalle_Cta.Item(1)

                    command.ExecuteNonQuery()


                    command.CommandText = _
                                            " Insert Into usuarios_nivel_aprobacion (idusuario, codigo_usuario, codigo_nivel_aprobacion,	nombre_usuario,	dfecmod, ccodusu )" & _
                                            " Values (" & Detalle_Cta(1) & ",'" & Detalle_Cta(3) & "','" & Detalle_Cta(0) & "','" & Detalle_Cta(2) & "',getdate(),'" & _
                                            Detalle_Cta(4) & "')"


                    command.ExecuteNonQuery()

                End If



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


    Public Function Extrae_Usuarios_Niveles_Aprobacion(ByVal codigo_nivel_aprobacion As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim sql_ As String

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection



                sql_ = _
                         " Select * From usuarios_nivel_aprobacion Where codigo_nivel_aprobacion ='" & codigo_nivel_aprobacion & "'"


                command.CommandText = sql_

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "niveles_aprobacion")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Extrae_Niveles_Aprobacion() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim sql_ As String

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection



                sql_ = _
                         " Select CODIGO_NIVEL_APROBACION, DESCRIPCION, LIMITE_INFERIOR, LIMITE_SUPERIOR," & _
                         " OBSERVACIONES " & _
                         " From niveles_aprobacion "


                command.CommandText = sql_

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "niveles_aprobacion")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Lista_Niveles_Aprobacion() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select CODIGO_NIVEL_APROBACION, (ltrim(rtrim(CODIGO_NIVEL_APROBACION)) + ' |' + ltrim(rtrim(DESCRIPCION))) as CDESCRI	" & _
                                        " From niveles_aprobacion "


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "niveles_aprobacion")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Extrae_Comite_Usuario(ByVal idsuario As Integer) As DataSet

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcDesOfi As String = ""
        Dim ds As New DataSet
        Dim lID As String = ""



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()


            command.Connection = connection


            Try

                'Verifica si es Modificación
                command.CommandText = _
                                        " Select a.codigo_nivel_aprobacion, b.codigo_usuario, " & _
                                        " b.nombre_usuario, a.descripcion " & _
                                        " From niveles_aprobacion a " & _
                                        " inner join usuarios_nivel_aprobacion b " & _
                                        " on a.codigo_nivel_aprobacion = b.codigo_nivel_aprobacion " & _
                                        " Where b.idusuario =" & idsuario


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Comite_Usuario")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds

    End Function


    Public Function Datos_Niveles_Aprobacion(ByVal pcCodigo As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select * From niveles_aprobacion " & _
                                        " Where codigo_nivel_aprobacion ='" & pcCodigo & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "niveles_aprobacion")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    
    'Verifica que los niveles de comite esten cubiertos       
    Public Function Valida_Niveles_Aprobacion(ByVal lnmonapr As Double, ByVal pcCodcta As String) As Boolean


        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim sql_ As String
        Dim lnnivel_comite As Integer = 0
        Dim nliminf As Double = 0
        Dim nlimsup As Double = 0
        Dim firma_comite As New ArrayList
        Dim lnivel_comite As Integer
        Dim llvalida_comite As Boolean

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select CODIGO_NIVEL_APROBACION, DESCRIPCION, LIMITE_INFERIOR, LIMITE_SUPERIOR," & _
                                        " OBSERVACIONES " & _
                                        " From niveles_aprobacion "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Niveles_Aprobacion")


                For Each Linea As DataRow In ds_Trab.Tables(0).Rows
                    nliminf = Linea("limite_inferior")
                    nlimsup = Linea("limite_superior")
                    If lnmonapr >= nliminf And lnmonapr <= nlimsup Then
                        lnivel_comite = Integer.Parse(Linea("codigo_nivel_aprobacion"))
                        Exit For
                    End If
                Next

          
                'Verifica si estan cubiertos todos los niveles de verificación
                sql_ = _
                         " Select isnull(usuario_comite_1,0) as usuario_comite_1, isnull(usuario_comite_2,0) as usuario_comite_2, " & _
                         " isnull(usuario_comite_3,0) as usuario_comite_3, isnull(usuario_comite_4,0) as usuario_comite_4, " & _
                         " isnull(usuario_comite_5,0) as usuario_comite_5 " & _
                         " From cremcre " & _
                         " Where cCodcta ='" & pcCodcta & "'"


                command.CommandText = sql_

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Comites_Aprobados")


                For Each fila As DataRow In ds_Trab.Tables("Comites_Aprobados").Rows
                    firma_comite.Add(fila("usuario_comite_1"))
                    firma_comite.Add(fila("usuario_comite_2"))
                    firma_comite.Add(fila("usuario_comite_3"))
                    firma_comite.Add(fila("usuario_comite_4"))
                    firma_comite.Add(fila("usuario_comite_5"))
                Next

                'Evalua si tiene las firmas correctas
                Select Case lnivel_comite
                    Case 1  'Nivel de Comite No 1   
                        If firma_comite.Item(0) > 0 Then 'Cumple
                            llvalida_comite = 1
                        Else                             'No Cumple
                            llvalida_comite = 0
                        End If
                    Case 2 'Nivel de Comite No 2
                        If firma_comite.Item(0) > 0 And firma_comite.Item(1) > 0 Then 'Cumple
                            llvalida_comite = 1
                        Else                             'No Cumple
                            llvalida_comite = 0
                        End If
                    Case 3 'Nivel de Comite No 3
                        If firma_comite.Item(0) > 0 And firma_comite.Item(1) > 0 And firma_comite.Item(2) > 0 Then 'Cumple
                            llvalida_comite = 1
                        Else                             'No Cumple
                            llvalida_comite = 0
                        End If
                    Case 4 'Nivel de Comite No 4
                        If firma_comite.Item(0) > 0 And firma_comite.Item(1) > 0 And firma_comite.Item(2) > 0 And _
                            firma_comite.Item(3) > 0 Then 'Cumple
                            llvalida_comite = 1
                        Else                             'No Cumple
                            llvalida_comite = 0
                        End If
                    Case 5 'Nivel de Comite No 5
                        If firma_comite.Item(0) > 0 And firma_comite.Item(1) > 0 And firma_comite.Item(2) > 0 And _
                            firma_comite.Item(3) > 0 And firma_comite.Item(4) > 0 Then 'Cumple
                            llvalida_comite = 1
                        Else                             'No Cumple
                            llvalida_comite = 0
                        End If
                    Case Else
                        llvalida_comite = 0
                End Select


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return llvalida_comite

    End Function


    Public Function Extraer_Comite_Usuario_(ByVal idsuario As Integer) As String

        Dim lnRetorno As Integer = 0
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim i As Integer = 0
        Dim Mytransaccion As SqlTransaction
        Dim ds As New DataSet
        Dim lcComite As String

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            command.Connection = connection


            Try

                'Verifica si es Modificación
                command.CommandText = _
                                        " Select a.codigo_nivel_aprobacion, b.codigo_usuario, " & _
                                        " b.nombre_usuario, a.descripcion " & _
                                        " From niveles_aprobacion a " & _
                                        " inner join usuarios_nivel_aprobacion b " & _
                                        " on a.codigo_nivel_aprobacion = b.codigo_nivel_aprobacion " & _
                                        " Where b.idusuario =" & idsuario


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Comite_Usuario")

                For Each fila As DataRow In ds.Tables("Comite_Usuario").Rows
                    lcComite = fila("descripcion")
                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return lcComite

    End Function


    'Obtiene Cuenta Contable de Cajero
    Public Function Extrae_Cuenta_CTB_Cajero(ByVal pcCodana As String) As String

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lcCodcta_Ctb As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select * from tabttab where ccodtab = '187' " & _
                                        " and ctipreg = '1' and ccodana = UPPER('" & pcCodana & "')"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_Cta_Contable")

                For Each fila As DataRow In ds_Trab.Tables("Detalle_Cta_Contable").Rows
                    lcCodcta_Ctb = fila("ccodcta")
                Next

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lcCodcta_Ctb

    End Function

    Public Function Extrae_Datos_Libretas(ByVal pcCodofi As String, ByVal pctodas As String) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim sql_ As String

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                If pctodas.Trim = "*" Then  'Todas las Oficinas
                    sql_ = _
                             " Select *, CASE cestado " & _
                             " WHEN '01' THEN 'ACTIVO'" & _
                             " WHEN '02' THEN 'INACTIVO'" & _
                             " Else 'OTRO'" & _
                             " END AS cestado1 from Libretas_Agencia Order by cCodofi "

                Else                        'Por Oficina
                    sql_ = _
                              " Select *, CASE cestado " & _
                              " WHEN '01' THEN 'ACTIVO'" & _
                              " WHEN '02' THEN 'INACTIVO'" & _
                              " Else 'OTRO'" & _
                              " END AS cestado1 from Libretas_Agencia " & _
                              " Where cCodOfi ='" & pcCodofi & "'" & _
                              " Order by cCodofi "

                End If


                command.CommandText = sql_

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Detalle_Libretas_Agencia")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Mantenimiento_Oficinas_Libretas(ByVal Detalle_Cta As ArrayList) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Ofi As New DataSet
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lcDesOfi As String = ""


        'Detalle_Cta.Item(0)        'Oficina        
        'Detalle_Cta.Item(1)        'Desde
        'Detalle_Cta.Item(2)        'hasta
        'Detalle_Cta.Item(3)        'No Actual
        'Detalle_Cta.Item(4)        'Estado
        'Detalle_Cta.Item(5)        'Fecha de asignacion
        'Detalle_Cta.Item(6)        'Usuario


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try


                command.CommandText = _
                                        " Select * from Libretas_Agencia  " & _
                                        " Where ccodofi ='" & Detalle_Cta.Item(0) & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Ofi, "Oficina_Libreta")

                'Extrae Nombre de la Oficina
                command.CommandText = _
                                        " Select * from TabtOfi  " & _
                                        " Where ccodofi ='" & Detalle_Cta.Item(0) & "'"


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Ofi, "Oficinas_descrip")

                For Each fila As DataRow In ds_Ofi.Tables("Oficinas_descrip").Rows
                    lcDesOfi = fila("cnomOfi").ToString.Trim
                Next


                If ds_Ofi.Tables("Oficina_Libreta").Rows.Count = 0 Then
                    command.CommandText = _
                                            " Insert Into Libretas_Agencia (ccodofi, cnomofi, ndesde, nhasta, nlibreta, cestado, dfecasi, dfecmod, ccodusu)" & _
                                            " Values ('" & Detalle_Cta(0) & "','" & lcDesOfi & "'," & Detalle_Cta(1) & "," & Detalle_Cta(2) & "," & Detalle_Cta(3) & ",'" & _
                                            Detalle_Cta(4) & "','" & Detalle_Cta(5) & "',GETDATE(),'" & Detalle_Cta(6) & "')"

                    command.ExecuteNonQuery()

                Else                        'Modificacion de cuenta  
                    command.CommandText = _
                                            " Update Libretas_Agencia  Set ndesde =" & Detalle_Cta(1) & ", nhasta =" & Detalle_Cta(2) & "," & _
                                            " nlibreta=" & Detalle_Cta.Item(3) & ", cestado ='" & Detalle_Cta.Item(4) & "'," & _
                                            " dfecmod = GETDATE() , ccodusu ='" & Detalle_Cta.Item(6) & "'" & _
                                            " Where ccodofi ='" & Detalle_Cta.Item(0) & "' and dfecasi= '" & Detalle_Cta.Item(5) & "'"
                    command.ExecuteNonQuery()

                End If



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


    Public Function Extrae_Bancos_Oficinas() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter
        Dim lcCodcta_Ctb As String = ""

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " SELECT b.ccodbco, a.cnombco, c.cnomofi, b.cctacte, " & _
                                        " (rtrim(ltrim(a.cnombco))+' | '+rtrim(ltrim(c.cnomofi))+' | '+rtrim(ltrim(b.cctacte))) as cdesbco FROM bancos a " & _
                                        " inner join TABTBCO b " & _
                                        " on b.idccodbco = a.Idccodbco " & _
                                        " INNER JOIN TABTOFI c " & _
                                        " on b.ccodofi = c.ccodofi " & _
                                        " where uso = 1 " & _
                                        " Order by a.idccodbco "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Bancos")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function
End Class
