Imports System.Text
Public Class dbTabtusu
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtusu
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodusu =  "" _
            Or lEntidad.ccodusu = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodusu = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtusu ")
        strSQL.Append(" SET cnomusu = @cnomusu, ") 
        strSQL.Append(" cclave = @cclave, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" ccatego = @ccatego, ") 
        strSQL.Append(" ccodofi = @ccodofi, ") 
        strSQL.Append(" dnacimi = @dnacimi, ") 
        strSQL.Append(" ctidoci = @ctidoci, ") 
        strSQL.Append(" cnudoci = @cnudoci, ") 
        strSQL.Append(" ccidoci = @ccidoci, ") 
        strSQL.Append(" cdirecc = @cdirecc, ") 
        strSQL.Append(" cprofes = @cprofes, ") 
        strSQL.Append(" cestciv = @cestciv, ") 
        strSQL.Append(" lescaje = @lescaje, ") 
        strSQL.Append(" lesapod = @lesapod, ") 
        strSQL.Append(" lhabcaj = @lhabcaj, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cnivusu = @cnivusu, ")
        strSQL.Append(" coordinado = @coordinado, ") 
        strSQL.Append(" ccodins = @ccodins ")
        strSQL.Append(" WHERE ccodusu = @ccodusu ") 

        Dim args(19) As SqlParameter
        args(0) = New SqlParameter("@cnomusu", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomusu
        args(1) = New SqlParameter("@cclave", SqlDbType.VarChar)
        args(1).Value = lEntidad.cclave
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = lEntidad.cestado
        args(3) = New SqlParameter("@ccatego", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccatego
        args(4) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodofi
        args(5) = New SqlParameter("@dnacimi", SqlDbType.Datetime)
        args(5).Value = lEntidad.dnacimi
        args(6) = New SqlParameter("@ctidoci", SqlDbType.VarChar)
        args(6).Value = lEntidad.ctidoci
        args(7) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(7).Value = lEntidad.cnudoci
        args(8) = New SqlParameter("@ccidoci", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccidoci
        args(9) = New SqlParameter("@cdirecc", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdirecc
        args(10) = New SqlParameter("@cprofes", SqlDbType.VarChar)
        args(10).Value = lEntidad.cprofes
        args(11) = New SqlParameter("@cestciv", SqlDbType.VarChar)
        args(11).Value = lEntidad.cestciv
        args(12) = New SqlParameter("@lescaje", SqlDbType.Bit)
        args(12).Value = IIf(lEntidad.lescaje = Nothing, DBNull.Value, lEntidad.lescaje)
        args(13) = New SqlParameter("@lesapod", SqlDbType.Bit)
        args(13).Value = IIf(lEntidad.lesapod = Nothing, DBNull.Value, lEntidad.lesapod)
        args(14) = New SqlParameter("@lhabcaj", SqlDbType.Bit)
        args(14).Value = IIf(lEntidad.lhabcaj = Nothing, DBNull.Value, lEntidad.lhabcaj)
        args(15) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(15).Value = lEntidad.dfecmod
        args(16) = New SqlParameter("@cnivusu", SqlDbType.VarChar)
        args(16).Value = lEntidad.cnivusu
        args(17) = New SqlParameter("@coordinado", SqlDbType.VarChar)
        args(17).Value = lEntidad.coordinado
        args(18) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(18).Value = lEntidad.ccodins
        args(19) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(19).Value = IIf(lEntidad.ccodusu = Nothing, DBNull.Value,lEntidad.ccodusu)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtusu
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtusu ")
        strSQL.Append(" ( ccodusu, ") 
        strSQL.Append(" cnomusu, ") 
        strSQL.Append(" cclave, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" ccatego, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" dnacimi, ") 
        strSQL.Append(" ctidoci, ") 
        strSQL.Append(" cnudoci, ") 
        strSQL.Append(" ccidoci, ") 
        strSQL.Append(" cdirecc, ") 
        strSQL.Append(" cprofes, ") 
        strSQL.Append(" cestciv, ") 
        strSQL.Append(" lescaje, ") 
        strSQL.Append(" lesapod, ") 
        strSQL.Append(" lhabcaj, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cnivusu, ")
        strSQL.Append(" coordinado, ") 
        strSQL.Append(" ccodins) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodusu, ") 
        strSQL.Append(" @cnomusu, ") 
        strSQL.Append(" @cclave, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @ccatego, ") 
        strSQL.Append(" @ccodofi, ") 
        strSQL.Append(" @dnacimi, ") 
        strSQL.Append(" @ctidoci, ") 
        strSQL.Append(" @cnudoci, ") 
        strSQL.Append(" @ccidoci, ") 
        strSQL.Append(" @cdirecc, ") 
        strSQL.Append(" @cprofes, ") 
        strSQL.Append(" @cestciv, ") 
        strSQL.Append(" @lescaje, ") 
        strSQL.Append(" @lesapod, ") 
        strSQL.Append(" @lhabcaj, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @cnivusu, ")
        strSQL.Append(" @coordinado, ") 
        strSQL.Append(" @ccodins) ")

        Dim args(19) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodusu = Nothing, DBNull.Value, lEntidad.ccodusu)
        args(1) = New SqlParameter("@cnomusu", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomusu
        args(2) = New SqlParameter("@cclave", SqlDbType.VarChar)
        args(2).Value = lEntidad.cclave
        args(3) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(3).Value = lEntidad.cestado
        args(4) = New SqlParameter("@ccatego", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccatego
        args(5) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodofi
        args(6) = New SqlParameter("@dnacimi", SqlDbType.Datetime)
        args(6).Value = lEntidad.dnacimi
        args(7) = New SqlParameter("@ctidoci", SqlDbType.VarChar)
        args(7).Value = lEntidad.ctidoci
        args(8) = New SqlParameter("@cnudoci", SqlDbType.VarChar)
        args(8).Value = lEntidad.cnudoci
        args(9) = New SqlParameter("@ccidoci", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccidoci
        args(10) = New SqlParameter("@cdirecc", SqlDbType.VarChar)
        args(10).Value = lEntidad.cdirecc
        args(11) = New SqlParameter("@cprofes", SqlDbType.VarChar)
        args(11).Value = lEntidad.cprofes
        args(12) = New SqlParameter("@cestciv", SqlDbType.VarChar)
        args(12).Value = lEntidad.cestciv
        args(13) = New SqlParameter("@lescaje", SqlDbType.Bit)
        args(13).Value = IIf(lEntidad.lescaje = Nothing, DBNull.Value, lEntidad.lescaje)
        args(14) = New SqlParameter("@lesapod", SqlDbType.Bit)
        args(14).Value = IIf(lEntidad.lesapod = Nothing, DBNull.Value, lEntidad.lesapod)
        args(15) = New SqlParameter("@lhabcaj", SqlDbType.Bit)
        args(15).Value = IIf(lEntidad.lhabcaj = Nothing, DBNull.Value, lEntidad.lhabcaj)
        args(16) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(16).Value = lEntidad.dfecmod
        args(17) = New SqlParameter("@cnivusu", SqlDbType.VarChar)
        args(17).Value = lEntidad.cnivusu
        args(18) = New SqlParameter("@coordinado", SqlDbType.VarChar)
        args(18).Value = lEntidad.coordinado
        args(19) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodins

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtusu
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtusu ")
        strSQL.Append(" WHERE ccodusu = @ccodusu ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtusu
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodusu = @ccodusu ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodusu

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomusu = IIf(.Item("cnomusu") Is DBNull.Value, Nothing, .Item("cnomusu"))
                lEntidad.cclave = IIf(.Item("cclave") Is DBNull.Value, Nothing, .Item("cclave"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.ccatego = IIf(.Item("ccatego") Is DBNull.Value, Nothing, .Item("ccatego"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.dnacimi = IIf(.Item("dnacimi") Is DBNull.Value, Nothing, .Item("dnacimi"))
                lEntidad.ctidoci = IIf(.Item("ctidoci") Is DBNull.Value, Nothing, .Item("ctidoci"))
                lEntidad.cnudoci = IIf(.Item("cnudoci") Is DBNull.Value, Nothing, .Item("cnudoci"))
                lEntidad.ccidoci = IIf(.Item("ccidoci") Is DBNull.Value, Nothing, .Item("ccidoci"))
                lEntidad.cdirecc = IIf(.Item("cdirecc") Is DBNull.Value, Nothing, .Item("cdirecc"))
                lEntidad.cprofes = IIf(.Item("cprofes") Is DBNull.Value, Nothing, .Item("cprofes"))
                lEntidad.cestciv = IIf(.Item("cestciv") Is DBNull.Value, Nothing, .Item("cestciv"))
                lEntidad.lescaje = IIf(.Item("lescaje") Is DBNull.Value, Nothing, .Item("lescaje"))
                lEntidad.lesapod = IIf(.Item("lesapod") Is DBNull.Value, Nothing, .Item("lesapod"))
                lEntidad.lhabcaj = IIf(.Item("lhabcaj") Is DBNull.Value, Nothing, .Item("lhabcaj"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.cnivusu = IIf(.Item("cnivusu") Is DBNull.Value, Nothing, .Item("cnivusu"))
                lEntidad.coordinado = IIf(.Item("coordinado") Is DBNull.Value, Nothing, .Item("coordinado"))
                lEntidad.ccodins = IIf(.Item("ccodins") Is DBNull.Value, Nothing, .Item("ccodins"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtusu
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodusu),0) + 1 ")
        strSQL.Append(" FROM tabtusu ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID(ByVal cCatego As String, ByVal ccodofi As String) As listatabtusu

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCatego = @cCatego and cEstado = 'A'  ")
        If ccodofi = "001" Then
        Else
            strSQL.Append(" and cCodofi = @ccodofi  ")
        End If

        'If nnivel < 9 Then
        '    strSQL.Append(" and ccodusu = @ccodusu ")
        'End If

        strSQL.Append(" order by cnomusu ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@cCatego", SqlDbType.VarChar)
        args(0).Value = cCatego
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = ccodofi

        'args(1) = New SqlParameter("@nNivel", SqlDbType.Int)
        'args(1).Value = nnivel
        'args(2) = New SqlParameter("@cCodusu", SqlDbType.VarChar)
        'args(2).Value = ccodusu



        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabtusu

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtusu
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cnomusu = IIf(dr("cnomusu") Is DBNull.Value, Nothing, dr("cnomusu"))
                mEntidad.cclave = IIf(dr("cclave") Is DBNull.Value, Nothing, dr("cclave"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ccatego = IIf(dr("ccatego") Is DBNull.Value, Nothing, dr("ccatego"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.dnacimi = IIf(dr("dnacimi") Is DBNull.Value, Nothing, dr("dnacimi"))
                mEntidad.ctidoci = IIf(dr("ctidoci") Is DBNull.Value, Nothing, dr("ctidoci"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.ccidoci = IIf(dr("ccidoci") Is DBNull.Value, Nothing, dr("ccidoci"))
                mEntidad.cdirecc = IIf(dr("cdirecc") Is DBNull.Value, Nothing, dr("cdirecc"))
                mEntidad.cprofes = IIf(dr("cprofes") Is DBNull.Value, Nothing, dr("cprofes"))
                mEntidad.cestciv = IIf(dr("cestciv") Is DBNull.Value, Nothing, dr("cestciv"))
                mEntidad.lescaje = IIf(dr("lescaje") Is DBNull.Value, Nothing, dr("lescaje"))
                mEntidad.lesapod = IIf(dr("lesapod") Is DBNull.Value, Nothing, dr("lesapod"))
                mEntidad.lhabcaj = IIf(dr("lhabcaj") Is DBNull.Value, Nothing, dr("lhabcaj"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cnivusu = IIf(dr("cnivusu") Is DBNull.Value, Nothing, dr("cnivusu"))
                mEntidad.coordinado = IIf(dr("coordinado") Is DBNull.Value, Nothing, dr("coordinado"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function



    'Public Function ObtenerDataSetPorID() As DataSet

    '    Dim strSQL As New StringBuilder
    '    SelectTabla(strSQL)

    '    Dim ds As DataSet

    '    ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

    '    Return ds

    'End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("tabtusu")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodusu, ")
        strSQL.Append(" cnomusu, ")
        strSQL.Append(" cclave, ")
        strSQL.Append(" cestado, ")
        strSQL.Append(" ccatego, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" dnacimi, ")
        strSQL.Append(" ctidoci, ")
        strSQL.Append(" cnudoci, ")
        strSQL.Append(" ccidoci, ")
        strSQL.Append(" cdirecc, ")
        strSQL.Append(" cprofes, ")
        strSQL.Append(" cestciv, ")
        strSQL.Append(" lescaje, ")
        strSQL.Append(" lesapod, ")
        strSQL.Append(" lhabcaj, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" cnivusu, ")
        strSQL.Append(" coordinado, ")
        strSQL.Append(" ccodins, ")
        strSQL.Append(" ccodusu as codigo, ")
        strSQL.Append(" 000000000.00 as ncapdes, ")
        strSQL.Append(" 000000000.00 as nsalcap, ")
        strSQL.Append(" 000000000.00 as nmora, ")
        strSQL.Append(" 000000000.00 as nsalint, ")
        strSQL.Append(" 000000000.00 as nsalmor, ")
        strSQL.Append(" 000000000.00 as nporc1, ")
        strSQL.Append(" 000000000.00 as nporc2, ")
        strSQL.Append(" 000000000.00 as nconta  ")
        strSQL.Append(" FROM tabtusu ")

    End Sub


    Public Function ObtenerListaPorusuario(ByVal usuario As String) As listatabtusu
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE cnomusu like" & "'" & "%" & usuario & "%" & "'")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabtusu

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtusu
                mEntidad.ccodusu = dr("ccodusu")
                mEntidad.cnomusu = dr("cnomusu")
                mEntidad.cclave = dr("cclave")
                mEntidad.cestado = dr("cestado")
                mEntidad.ccatego = dr("ccatego")
                mEntidad.ccodofi = dr("ccodofi")
                mEntidad.dnacimi = dr("dnacimi")
                mEntidad.ctidoci = dr("ctidoci")
                mEntidad.cnudoci = dr("cnudoci")
                mEntidad.ccidoci = dr("ccidoci")
                mEntidad.cdirecc = dr("cdirecc")
                mEntidad.cprofes = dr("cprofes")
                mEntidad.cestciv = dr("cestciv")
                mEntidad.lescaje = dr("lescaje")
                mEntidad.lesapod = dr("lesapod")
                mEntidad.lhabcaj = dr("lhabcaj")
                mEntidad.dfecmod = dr("dfecmod")
                mEntidad.cnivusu = dr("cnivusu")
                mEntidad.coordinado = dr("coordinado")
                mEntidad.ccodins = dr("ccodins")
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
        strSQL.Append(" WHERE ccatego = 'ANA' ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function usuario(ByVal pccodusu As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select nombre from usuarios where usuario=@pccodusu")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodusu", SqlDbType.Char)
        args(0).Value = pccodusu


        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = ""
        Else
            lcnomusu = ds.Tables(0).Rows(0)("nombre")
        End If
        Return lcnomusu
    End Function


    Public Function NombreUsuario(ByVal pccodusu As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cnomusu from tabtusu where cCodusu=@pccodusu")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodusu", SqlDbType.Char)
        args(0).Value = pccodusu


        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = ""
        Else
            lcnomusu = ds.Tables(0).Rows(0)("cnomusu")
        End If
        Return lcnomusu
    End Function
    Public Function ObtieneAnalistaGrupo(ByVal cCodsol As String, ByVal dfecvig As Date) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtusu.cnomusu from tabtusu, cremcre ")
        strSQL.Append("WHERE cremcre.cCodsol = @cCodsol and cremcre.dfecvig>=@dfecvig and cremcre.dfecvig<=@dfecvig ")
        strSQL.Append(" and cremcre.cCodana = tabtusu.cCodusu ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodsol", SqlDbType.Char)
        args(0).Value = cCodsol

        args(1) = New SqlParameter("@dfecvig", SqlDbType.DateTime)
        args(1).Value = dfecvig

        Dim ds As DataSet
        Dim lcnomusu As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lcnomusu = ""
        Else
            lcnomusu = ds.Tables(0).Rows(0)("cnomusu")
        End If
        Return lcnomusu


    End Function
    Public Function ObtenerListaPorID2() As listatabtusu

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cEstado = 'A'  ")

        strSQL.Append(" order by cnomusu ")


        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listatabtusu

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtusu
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cnomusu = IIf(dr("cnomusu") Is DBNull.Value, Nothing, dr("cnomusu"))
                mEntidad.cclave = IIf(dr("cclave") Is DBNull.Value, Nothing, dr("cclave"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.ccatego = IIf(dr("ccatego") Is DBNull.Value, Nothing, dr("ccatego"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.dnacimi = IIf(dr("dnacimi") Is DBNull.Value, Nothing, dr("dnacimi"))
                mEntidad.ctidoci = IIf(dr("ctidoci") Is DBNull.Value, Nothing, dr("ctidoci"))
                mEntidad.cnudoci = IIf(dr("cnudoci") Is DBNull.Value, Nothing, dr("cnudoci"))
                mEntidad.ccidoci = IIf(dr("ccidoci") Is DBNull.Value, Nothing, dr("ccidoci"))
                mEntidad.cdirecc = IIf(dr("cdirecc") Is DBNull.Value, Nothing, dr("cdirecc"))
                mEntidad.cprofes = IIf(dr("cprofes") Is DBNull.Value, Nothing, dr("cprofes"))
                mEntidad.cestciv = IIf(dr("cestciv") Is DBNull.Value, Nothing, dr("cestciv"))
                mEntidad.lescaje = IIf(dr("lescaje") Is DBNull.Value, Nothing, dr("lescaje"))
                mEntidad.lesapod = IIf(dr("lesapod") Is DBNull.Value, Nothing, dr("lesapod"))
                mEntidad.lhabcaj = IIf(dr("lhabcaj") Is DBNull.Value, Nothing, dr("lhabcaj"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.cnivusu = IIf(dr("cnivusu") Is DBNull.Value, Nothing, dr("cnivusu"))
                mEntidad.coordinado = IIf(dr("coordinado") Is DBNull.Value, Nothing, dr("coordinado"))
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function usuariooficina(ByVal pccodusu As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodofi from usuarios where usuario=@pccodusu")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@pccodusu", SqlDbType.Char)
        args(0).Value = pccodusu


        Dim ds As DataSet
        Dim lccodofi As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            lccodofi = ""
        Else
            lccodofi = ds.Tables(0).Rows(0)("ccodofi")
        End If
        Return lccodofi
    End Function
    Public Function ObtenerResponsableCaja(ByVal ccodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        'strSQL.Append("select cnomusu, ccodusu from tabtusu where lesapod ='1' and cestado ='A' ")
        strSQL.Append("select nombre, usuario from usuarios where lesapod ='1' ")
        If ccodofi = "001" Then
        Else
            strSQL.Append("and ccodofi = @ccodofi ")
        End If
        strSQL.Append(" order by nombre ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.Char)
        args(0).Value = ccodofi

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds

    End Function


End Class
