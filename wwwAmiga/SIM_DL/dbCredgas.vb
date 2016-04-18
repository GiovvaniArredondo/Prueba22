Imports System.Text
Public Class dbCredgas
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credgas
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cdescob =  "" _
            Or lEntidad.cdescob = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cdescob = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE credgas ")
        strSQL.Append(" SET cusugen = @cusugen, ") 
        strSQL.Append(" dfecgen = @dfecgen, ") 
        strSQL.Append(" dfecpag = @dfecpag, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" nmongas = @nmongas, ") 
        strSQL.Append(" nmonpag = @nmonpag, ") 
        strSQL.Append(" ccodusu = @ccodusu ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cflag = @cflag ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 
        strSQL.Append(" AND cdescob = @cdescob ") 

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@cusugen", SqlDbType.VarChar)
        args(0).Value = lEntidad.cusugen
        args(1) = New SqlParameter("@dfecgen", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecgen
        args(2) = New SqlParameter("@dfecpag", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecpag
        args(3) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(3).Value = lEntidad.cestado
        args(4) = New SqlParameter("@nmongas", SqlDbType.VarChar)
        args(4).Value = lEntidad.nmongas
        args(5) = New SqlParameter("@nmonpag", SqlDbType.VarChar)
        args(5).Value = lEntidad.nmonpag
        args(6) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodusu
        args(7) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(7).Value = lEntidad.dfecmod
        args(8) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(8).Value = lEntidad.cflag
        args(9) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value,lEntidad.ccodcta)
        args(10) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ctipgas = Nothing, DBNull.Value,lEntidad.ctipgas)
        args(11) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value,lEntidad.cnrocuo)
        args(12) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(12).Value = IIf(lEntidad.cdescob = Nothing, DBNull.Value,lEntidad.cdescob)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO credgas ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" cusugen, ") 
        strSQL.Append(" dfecgen, ") 
        strSQL.Append(" dfecpag, ") 
        strSQL.Append(" ctipgas, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" nmongas, ") 
        strSQL.Append(" nmonpag, ") 
        strSQL.Append(" cnrocuo, ") 
        strSQL.Append(" cdescob, ") 
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag, ngasori) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @cusugen, ") 
        strSQL.Append(" @dfecgen, ") 
        strSQL.Append(" @dfecpag, ") 
        strSQL.Append(" @ctipgas, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @nmongas, ") 
        strSQL.Append(" @nmonpag, ") 
        strSQL.Append(" @cnrocuo, ") 
        strSQL.Append(" @cdescob, ") 
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cflag, @ngasori) ")

        Dim args(13) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@cusugen", SqlDbType.VarChar)
        args(1).Value = lEntidad.cusugen
        args(2) = New SqlParameter("@dfecgen", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecgen
        args(3) = New SqlParameter("@dfecpag", SqlDbType.Datetime)
        args(3).Value = lEntidad.dfecpag
        args(4) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.ctipgas = Nothing, DBNull.Value, lEntidad.ctipgas)
        args(5) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(5).Value = lEntidad.cestado
        args(6) = New SqlParameter("@nmongas", SqlDbType.Decimal)
        args(6).Value = lEntidad.nmongas
        args(7) = New SqlParameter("@nmonpag", SqlDbType.Decimal)
        args(7).Value = lEntidad.nmonpag
        args(8) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value, lEntidad.cnrocuo)
        args(9) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.cdescob = Nothing, DBNull.Value, lEntidad.cdescob)
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodusu
        args(11) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(11).Value = lEntidad.dfecmod
        args(12) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(12).Value = lEntidad.cflag
        args(13) = New SqlParameter("@ngasori", SqlDbType.Decimal)
        args(13).Value = lEntidad.ngasori
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 
        strSQL.Append(" AND cdescob = @cdescob ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipgas
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdescob

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 
        strSQL.Append(" AND cdescob = @cdescob ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipgas
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo
        args(3) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdescob

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cusugen = IIf(.Item("cusugen") Is DBNull.Value, Nothing, .Item("cusugen"))
                lEntidad.dfecgen = IIf(.Item("dfecgen") Is DBNull.Value, Nothing, .Item("dfecgen"))
                lEntidad.dfecpag = IIf(.Item("dfecpag") Is DBNull.Value, Nothing, .Item("dfecpag"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.nmongas = IIf(.Item("nmongas") Is DBNull.Value, Nothing, .Item("nmongas"))
                lEntidad.nmonpag = IIf(.Item("nmonpag") Is DBNull.Value, Nothing, .Item("nmonpag"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As credgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cdescob),0) + 1 ")
        strSQL.Append(" FROM credgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipgas
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnrocuo

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcta As String, ctipgas As String, cnrocuo As String) As listacredgas

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(1).Value = ctipgas
        args(2) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(2).Value = cnrocuo

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listacredgas

        Try
            Do While dr.Read()
                Dim mEntidad As New credgas
                mEntidad.ccodcta = ccodcta
                mEntidad.cusugen = IIf(dr("cusugen") Is DBNull.Value, Nothing, dr("cusugen"))
                mEntidad.dfecgen = IIf(dr("dfecgen") Is DBNull.Value, Nothing, dr("dfecgen"))
                mEntidad.dfecpag = IIf(dr("dfecpag") Is DBNull.Value, Nothing, dr("dfecpag"))
                mEntidad.ctipgas = ctipgas
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.nmongas = IIf(dr("nmongas") Is DBNull.Value, Nothing, dr("nmongas"))
                mEntidad.nmonpag = IIf(dr("nmonpag") Is DBNull.Value, Nothing, dr("nmonpag"))
                mEntidad.cnrocuo = cnrocuo
                mEntidad.cdescob = IIf(dr("cdescob") Is DBNull.Value, Nothing, dr("cdescob"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String, ctipgas As String, cnrocuo As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ctipgas = @ctipgas ") 
        strSQL.Append(" AND cnrocuo = @cnrocuo ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipgas", ctipgas)
        args(2) = New SqlParameter("@cnrocuo", cnrocuo)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByVal ccodcta As String, ByVal ctipgas As String, ByVal cnrocuo As String, ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ctipgas = @ctipgas ")
        strSQL.Append(" AND cnrocuo = @cnrocuo ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipgas", ctipgas)
        args(2) = New SqlParameter("@cnrocuo", cnrocuo)

        Dim tables(0) As String
        tables(0) = New String("credgas")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" cusugen, ")
        strSQL.Append(" dfecgen, ")
        strSQL.Append(" dfecpag, ")
        strSQL.Append(" ctipgas, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" nmongas, ")
        strSQL.Append(" nmonpag, ")
        strSQL.Append(" cnrocuo, ")
        strSQL.Append(" cdescob, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag ")
        strSQL.Append(" FROM credgas ")

    End Sub

    Public Function EliminaGastos(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function Eliminarporcuenta(ByVal ccodcta As String)

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function EliminarporcuentaDes(ByVal ccodcta As String)

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM credgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cdescob ='D' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerDataSetPorID2(ByVal ccodcta As String, ByVal cdescob As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND cdescob = @cdescob ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cdescob", cdescob)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function CargaComisiones(ByVal ccodcta As String, ByVal cdescob As String) As DataTable
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT left(tabttab.ccodigo,2) as ccodigo,   tabttab.cdescri , credgas.nmongas  FROM credgas, tabttab where LEFT(tabttab.ccodigo,2) = credgas.ctipgas ")
        strSQL.Append("and tabttab.ccodtab ='008' and credgas.ccodcta = @ccodcta and credgas.cdescob = @cdescob ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cdescob", cdescob)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds.Tables(0)

    End Function
   

    Public Function Extrae__cadenas(ByVal cadenaseleccion As String) As String
        Dim retorna As String = ""


        Dim strSQL As New StringBuilder
        strSQL.Append("select top 1 isnull(link_foto,0) as link_foto from climgar  where ccodcli=@ccodcli and cestado='A' order by ccodgar desc")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", cadenaseleccion)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        

        For Each rows As DataRow In ds.Tables(0).Rows
            retorna = rows("link_foto")

        Next

        Return retorna

    End Function

    Public Function CargaComisionesGrupal(ByVal ccodcta As String, ByVal cdescob As String) As DataTable
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT left(tabttab.ccodigo,2) as ccodigo,   tabttab.cdescri , sum(credgas.nmongas) as nmongas  FROM cremcre, credgas, tabttab where LEFT(tabttab.ccodigo,2) = credgas.ctipgas ")
        strSQL.Append("and tabttab.ccodtab ='008' and cremcre.ccodcta = credgas.ccodcta and  cremcre.ccodsol = @ccodcta and credgas.cdescob = @cdescob ")
        strSQL.Append("group by tabttab.ccodigo, tabttab.cdescri ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cdescob", cdescob)


        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds.Tables(0)

    End Function
    Public Function CargaListadoChkGastosCredito(ByVal ccodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select credgas.ctipgas as  ccodigo, tabttab.cdescri ,case when credgas.cflag ='1' then 1 else 0 end  as  llogtab,credgas.nmongas as nmonto, credgas.nmongas, credgas.ngasori as ngasori, tabttab.nflag FROM TABTTAB, CREDGAS ")
        strSQL.Append("WHERE credgas.ccodcta = @ccodcta and  left(tabttab.ccodigo,2) = left(credgas.ctipgas,2) and ")
        strSQL.Append(" tabttab.ccodtab ='008' and tabttab.ctipreg ='1' and credgas.cdescob ='D' order by ccodigo")
        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function AplicaEdiciondeCampo(ByVal ccodigo As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("select  nflag from tabttab where ccodtab ='008' and ctipreg ='1' and ccodigo = @ccodigo ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", ccodigo)
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lvalida As Boolean = False
        Dim lnbandera As Integer = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nflag")) Then
            Else
                lnbandera = ds.Tables(0).Rows(0)("nflag")
                If lnbandera = 1 Then
                    lvalida = True
                End If
            End If
        End If
        Return lvalida
    End Function
    Public Function EliminarporcuentaPropuesta(ByVal ccodcta As String, ByVal cusugen As String)

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM Propgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cusugen =  @cusugen ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cusugen", cusugen)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function EliminarporcuentaPropuestaDes(ByVal ccodcta As String, ByVal cusugen As String)

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM Propgas ")
        strSQL.Append(" WHERE ccodcta = @ccodcta and cusugen =  @cusugen and cdescob ='D' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cusugen", cusugen)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function


    Public Function AgregarPropuesta(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As credgas
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Propgas ")
        strSQL.Append(" ( ccodcta, ")
        strSQL.Append(" cusugen, ")
        strSQL.Append(" dfecgen, ")
        strSQL.Append(" dfecpag, ")
        strSQL.Append(" ctipgas, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" nmongas, ")
        strSQL.Append(" nmonpag, ")
        strSQL.Append(" cnrocuo, ")
        strSQL.Append(" cdescob, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cflag, ngasori) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ")
        strSQL.Append(" @cusugen, ")
        strSQL.Append(" @dfecgen, ")
        strSQL.Append(" @dfecpag, ")
        strSQL.Append(" @ctipgas, ")
        strSQL.Append(" @cestado, ")
        strSQL.Append(" @nmongas, ")
        strSQL.Append(" @nmonpag, ")
        strSQL.Append(" @cnrocuo, ")
        strSQL.Append(" @cdescob, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @cflag, @ngasori) ")

        Dim args(13) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@cusugen", SqlDbType.VarChar)
        args(1).Value = lEntidad.cusugen
        args(2) = New SqlParameter("@dfecgen", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecgen
        args(3) = New SqlParameter("@dfecpag", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfecpag
        args(4) = New SqlParameter("@ctipgas", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.ctipgas = Nothing, DBNull.Value, lEntidad.ctipgas)
        args(5) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(5).Value = lEntidad.cestado
        args(6) = New SqlParameter("@nmongas", SqlDbType.Decimal)
        args(6).Value = lEntidad.nmongas
        args(7) = New SqlParameter("@nmonpag", SqlDbType.Decimal)
        args(7).Value = lEntidad.nmonpag
        args(8) = New SqlParameter("@cnrocuo", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.cnrocuo = Nothing, DBNull.Value, lEntidad.cnrocuo)
        args(9) = New SqlParameter("@cdescob", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.cdescob = Nothing, DBNull.Value, lEntidad.cdescob)
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodusu
        args(11) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(11).Value = lEntidad.dfecmod
        args(12) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(12).Value = lEntidad.cflag
        args(13) = New SqlParameter("@ngasori", SqlDbType.Decimal)
        args(13).Value = lEntidad.ngasori
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function CargaGastos(ByVal ccodcta As String, ByVal cdescob As String, ByVal cnrocuo As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select credgas.ctipgas, rtrim(ltrim(tabttab.cdescri)) as cdescri, credgas.nmongas, tabttab.cflag  from credgas, tabttab ")
        strSQL.Append("where tabttab.ccodtab ='008' and tabttab.ctipreg ='1' and ")
        strSQL.Append("left(tabttab.ccodigo,2) = left(credgas.ctipgas,2) and  credgas.ccodcta =@ccodcta and credgas.cnrocuo =@cnrocuo  and credgas.cdescob = @cdescob ")
        strSQL.Append("order by credgas.ctipgas ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cdescob", cdescob)
        args(2) = New SqlParameter("@cnrocuo", cnrocuo)

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ObtenerGastohastafecha(ByVal ctipgas As String, ByVal ccodcta As String, ByVal cnrocuo As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SUM(nmongas) as nmongas FROM CREDGAS ")
        strSQL.Append("WHERE ctipgas = @ctipgas and cdescob = 'C' and ccodcta = @ccodcta and cnrocuo <= @cnrocuo ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipgas", ctipgas)
        args(2) = New SqlParameter("@cnrocuo", cnrocuo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lngasto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmongas")) Then
            Else
                lngasto = ds.Tables(0).Rows(0)("nmongas")
            End If
        End If
        Return lngasto
    End Function
    Public Function ObtenerGastodeCuota(ByVal ctipgas As String, ByVal ccodcta As String, ByVal cnrocuo As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT  nmongas FROM CREDGAS ")
        strSQL.Append("WHERE ctipgas = @ctipgas and cdescob = 'C' and ccodcta = @ccodcta and cnrocuo <= @cnrocuo order by cnrocuo desc ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipgas", ctipgas)
        args(2) = New SqlParameter("@cnrocuo", cnrocuo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lngasto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmongas")) Then
            Else
                lngasto = ds.Tables(0).Rows(0)("nmongas")
            End If
        End If
        Return lngasto
    End Function



    Public Function Extrae_Gastos(ByVal pcCodcta As String, ByVal pcTipo As String) As DataSet



        Dim lcCodOfi As String = ""
        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter



        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " SELECT b.ctipgas, a.cdescri, b.nmongas from tabttab a " & _
                                        " inner join credgas b " & _
                                        " on a.ccodigo = b.ctipgas " & _
                                        " where b.ccodcta = '" & pcCodcta & "' and b.cdescob = '" & pcTipo & "'" & _
                                        " and a.ccodtab + a.ctipreg = '0081' order by a.ccodigo "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Gastos")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function ObtenerGastoAsignadaaCuota(ByVal ccodcta As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT  sum(nmongas) as nmongas FROM CREDGAS ")
        strSQL.Append("WHERE  cdescob = 'C' and ccodcta = @ccodcta and cnrocuo =  '001'  ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lngasto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmongas")) Then
            Else
                lngasto = ds.Tables(0).Rows(0)("nmongas")
            End If
        End If
        Return lngasto
    End Function
    Public Function ObtenerGastoDesembolso(ByVal ccodcta As String, ByVal cnrocuo As String) As Decimal
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SUM(nmongas) as nmongas FROM CREDGAS ")
        strSQL.Append("WHERE  cdescob = 'D' and ccodcta = @ccodcta and cnrocuo = @cnrocuo and cestado =' ' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@cnrocuo", cnrocuo)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lngasto As Decimal = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("nmongas")) Then
            Else
                lngasto = ds.Tables(0).Rows(0)("nmongas")
            End If
        End If
        Return lngasto
    End Function





End Class
