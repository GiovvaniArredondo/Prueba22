Imports System.Text
Public Class dbGestion
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

        Dim lEntidad As gestion
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodcta =  "" _
            Or lEntidad.ccodcta = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodcta = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE gestion ")
        strSQL.Append(" SET time_out = @time_out, ") 
        strSQL.Append(" dfecpag = @dfecpag, ") 
        strSQL.Append(" gestion = @gestion, ") 
        strSQL.Append(" resultados = @resultados, ") 
        strSQL.Append(" observa = @observa, ") 
        strSQL.Append(" cflag = @cflag, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" ccodana = @ccodana, ") 
        strSQL.Append(" dias_mora = @dias_mora, cfrecpag = @cfrecpag, nmonconv = @nmonconv ")
        strSQL.Append(" WHERE idgestion = @idgestion ")
        strSQL.Append(" AND ccodcta = @ccodcta ")

        Dim args(15) As SqlParameter
        args(0) = New SqlParameter("@time_out", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.time_out = Nothing, DBNull.Value, lEntidad.time_out)
        args(1) = New SqlParameter("@dfecpag", SqlDbType.Datetime)
        args(1).Value = IIf(lEntidad.dfecpag = Nothing, DBNull.Value, lEntidad.dfecpag)
        args(2) = New SqlParameter("@gestion", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.gestion = Nothing, DBNull.Value, lEntidad.gestion)
        args(3) = New SqlParameter("@resultados", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.resultados = Nothing, DBNull.Value, lEntidad.resultados)
        args(4) = New SqlParameter("@observa", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.observa = Nothing, DBNull.Value, lEntidad.observa)
        args(5) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(6) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.cflag = Nothing, DBNull.Value, lEntidad.cflag)
        args(7) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.ccodusu = Nothing, DBNull.Value, lEntidad.ccodusu)
        args(8) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.ccodana = Nothing, DBNull.Value, lEntidad.ccodana)
        args(9) = New SqlParameter("@dias_mora", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.dias_mora = Nothing, DBNull.Value, lEntidad.dias_mora)
        args(10) = New SqlParameter("@dfecges", SqlDbType.Datetime)
        args(10).Value = IIf(lEntidad.dfecges = Nothing, DBNull.Value,lEntidad.dfecges)
        args(11) = New SqlParameter("@time_in", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.time_in = Nothing, DBNull.Value,lEntidad.time_in)
        args(12) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(12).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value,lEntidad.ccodcta)
        args(13) = New SqlParameter("@idgestion", SqlDbType.VarChar)
        args(13).Value = IIf(lEntidad.idgestion = Nothing, DBNull.Value, lEntidad.idgestion)
        args(14) = New SqlParameter("@cfrecpag", SqlDbType.VarChar)
        args(14).Value = lEntidad.cfrecpag
        args(15) = New SqlParameter("@nmonconv", SqlDbType.Decimal)
        args(15).Value = lEntidad.nmonconv

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As gestion
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO gestion ")
        strSQL.Append(" ( dfecges, ") 
        strSQL.Append(" time_in, ") 
        strSQL.Append(" time_out, ") 
        strSQL.Append(" dfecpag, ") 
        strSQL.Append(" gestion, ") 
        strSQL.Append(" resultados, ") 
        strSQL.Append(" observa, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" ccodana, ") 
        strSQL.Append(" dias_mora, idgestion, cestado, cfrecpag, nmonconv) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @dfecges, ") 
        strSQL.Append(" @time_in, ") 
        strSQL.Append(" @time_out, ") 
        strSQL.Append(" @dfecpag, ") 
        strSQL.Append(" @gestion, ") 
        strSQL.Append(" @resultados, ") 
        strSQL.Append(" @observa, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @ccodcta, ") 
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @ccodana, ") 
        strSQL.Append(" @dias_mora, @idgestion, @cestado, @cfrecpag, @nmonconv) ")

        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@dfecges", SqlDbType.Datetime)
        args(0).Value = IIf(lEntidad.dfecges = Nothing, DBNull.Value, lEntidad.dfecges)
        args(1) = New SqlParameter("@time_in", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.time_in = Nothing, DBNull.Value, lEntidad.time_in)
        args(2) = New SqlParameter("@time_out", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.time_out = Nothing, DBNull.Value, lEntidad.time_out)
        args(3) = New SqlParameter("@dfecpag", SqlDbType.Datetime)
        args(3).Value = IIf(lEntidad.dfecpag = Nothing, DBNull.Value, lEntidad.dfecpag)
        args(4) = New SqlParameter("@gestion", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.gestion = Nothing, "", lEntidad.gestion)
        args(5) = New SqlParameter("@resultados", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.resultados = Nothing, "", lEntidad.resultados)
        args(6) = New SqlParameter("@observa", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.observa = Nothing, "", lEntidad.observa)
        args(7) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.ccodcli = Nothing, "", lEntidad.ccodcli)
        args(8) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(9) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.cflag = Nothing, "", lEntidad.cflag)
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ccodusu = Nothing, DBNull.Value, lEntidad.ccodusu)
        args(11) = New SqlParameter("@ccodana", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.ccodana = Nothing, "", lEntidad.ccodana)
        args(12) = New SqlParameter("@dias_mora", SqlDbType.VarChar)
        args(12).Value = IIf(lEntidad.dias_mora = Nothing, 0, lEntidad.dias_mora)
        args(13) = New SqlParameter("@idgestion", SqlDbType.VarChar)
        args(13).Value = IIf(lEntidad.idgestion = Nothing, "", lEntidad.idgestion)
        args(14) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(14).Value = " "
        args(15) = New SqlParameter("@cfrecpag", SqlDbType.VarChar)
        args(15).Value = lEntidad.cfrecpag
        args(16) = New SqlParameter("@nmonconv", SqlDbType.Decimal)
        args(16).Value = lEntidad.nmonconv

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As gestion
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM gestion ")
        strSQL.Append(" WHERE dfecges = @dfecges ") 
        strSQL.Append(" AND time_in = @time_in ") 
        strSQL.Append(" AND ccodcta = @ccodcta ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecges", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecges
        args(1) = New SqlParameter("@time_in", SqlDbType.VarChar)
        args(1).Value = lEntidad.time_in
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As gestion
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfecges = @dfecges ") 
        strSQL.Append(" AND time_in = @time_in ") 
        strSQL.Append(" AND ccodcta = @ccodcta ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@dfecges", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecges
        args(1) = New SqlParameter("@time_in", SqlDbType.VarChar)
        args(1).Value = lEntidad.time_in
        args(2) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodcta

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.time_out = IIf(.Item("time_out") Is DBNull.Value, Nothing, .Item("time_out"))
                lEntidad.dfecpag = IIf(.Item("dfecpag") Is DBNull.Value, Nothing, .Item("dfecpag"))
                lEntidad.gestion = IIf(.Item("gestion") Is DBNull.Value, Nothing, .Item("gestion"))
                lEntidad.resultados = IIf(.Item("resultados") Is DBNull.Value, Nothing, .Item("resultados"))
                lEntidad.observa = IIf(.Item("observa") Is DBNull.Value, Nothing, .Item("observa"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.ccodana = IIf(.Item("ccodana") Is DBNull.Value, Nothing, .Item("ccodana"))
                lEntidad.dias_mora = IIf(.Item("dias_mora") Is DBNull.Value, Nothing, .Item("dias_mora"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As gestion
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodcta),0) + 1 ")
        strSQL.Append(" FROM gestion ")
        strSQL.Append(" WHERE dfecges = @dfecges ") 
        strSQL.Append(" AND time_in = @time_in ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecges", SqlDbType.Datetime)
        args(0).Value = lEntidad.dfecges
        args(1) = New SqlParameter("@time_in", SqlDbType.VarChar)
        args(1).Value = lEntidad.time_in

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(dfecges As DateTime, time_in As String) As listagestion

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfecges = @dfecges ") 
        strSQL.Append(" AND time_in = @time_in ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecges", SqlDbType.Datetime)
        args(0).Value = dfecges
        args(1) = New SqlParameter("@time_in", SqlDbType.VarChar)
        args(1).Value = time_in

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listagestion

        Try
            Do While dr.Read()
                Dim mEntidad As New gestion
                mEntidad.dfecges = dfecges
                mEntidad.time_in = time_in
                mEntidad.time_out = IIf(dr("time_out") Is DBNull.Value, Nothing, dr("time_out"))
                mEntidad.dfecpag = IIf(dr("dfecpag") Is DBNull.Value, Nothing, dr("dfecpag"))
                mEntidad.gestion = IIf(dr("gestion") Is DBNull.Value, Nothing, dr("gestion"))
                mEntidad.resultados = IIf(dr("resultados") Is DBNull.Value, Nothing, dr("resultados"))
                mEntidad.observa = IIf(dr("observa") Is DBNull.Value, Nothing, dr("observa"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.ccodana = IIf(dr("ccodana") Is DBNull.Value, Nothing, dr("ccodana"))
                mEntidad.dias_mora = IIf(dr("dias_mora") Is DBNull.Value, Nothing, dr("dias_mora"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(dfecges As DateTime, time_in As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfecges = @dfecges ") 
        strSQL.Append(" AND time_in = @time_in ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecges", dfecges)
        args(1) = New SqlParameter("@time_in", time_in)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(dfecges As DateTime, time_in As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE dfecges = @dfecges ") 
        strSQL.Append(" AND time_in = @time_in ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@dfecges", dfecges)
        args(1) = New SqlParameter("@time_in", time_in)

        Dim tables(0) As String
        tables(0) = New String("gestion")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT dfecges, ") 
        strSQL.Append(" time_in, ") 
        strSQL.Append(" time_out, ") 
        strSQL.Append(" dfecpag, ") 
        strSQL.Append(" gestion, ") 
        strSQL.Append(" resultados, ") 
        strSQL.Append(" observa, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" ccodcta, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" ccodana, ") 
        strSQL.Append(" dias_mora ") 
        strSQL.Append(" FROM gestion ")

    End Sub

    Public Function Obtenergestion(ByVal cCodcta As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM GESTION ")
        strSQL.Append("WHERE ccodcta = @ccodcta and cestado = ' ' order by dfecges desc, idgestion ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = cCodcta

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds


    End Function
    Public Function ObtenerCodigoGestion(ByVal ccodcta As String) As String

        Dim strSQL As New StringBuilder
        Dim lccodgar As String
        Dim i As Integer
        Dim tamano As Integer
        '*******
        strSQL.Append("SELECT max(idgestion)+1 as idgestion")
        strSQL.Append(" FROM Gestion ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        Dim ds As DataSet

        ds = ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        If ds.Tables(0).Rows.Count > 0 Then
            If IsDBNull(ds.Tables(0).Rows(0)("idgestion")) Then
                lccodgar = "001"
            Else
                lccodgar = ds.Tables(0).Rows(0)("idgestion")

                lccodgar.Trim()
                tamano = lccodgar.Trim.Length
                For i = 1 To 3 - tamano
                    lccodgar = "0" & lccodgar
                Next
            End If
        Else
            lccodgar = Nothing
        End If


        Return lccodgar

    End Function

    Public Function ObtenerGestiones() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from gestion order by ccodcli, ccodcta ")

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function
    Public Function ActualizacCodigoGestion(ByVal idgestion As String, ByVal id As Integer) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE GESTION set idgestion = @idgestion WHERE id = @id ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idgestion", idgestion)
        args(1) = New SqlParameter("@id", id)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ActualizaEstadoGestion(ByVal idgestion As String, ByVal ccodcta As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE GESTION set cestado = 'X' WHERE idgestion = @idgestion and ccodcta  = @ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@idgestion", idgestion)
        args(1) = New SqlParameter("@ccodcta", ccodcta)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function Moranogestionada(ByVal ccodana As String, ByVal ndiadesde As Integer, ByVal ndiahasta As Integer) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT cli.ccodcli as asociado, cre.ccodcta as cuenta, cli.cnomcli as nombre, cre.nmonapr as desembolso, ")
        strSQL.Append("	 cre.ncappag as cap_pag, cre.nmonapr - cre.ncappag as saldo_cap, cre.ndiaatr as atraso, ")
        strSQL.Append("	 usu.cnomusu as analista, SPACE(4) as gestion, 'NO' as gestionado, SPACE(3) as cuantas  ")
        strSQL.Append(" 	FROM climide as cli, cremcre as cre, tabtusu as usu ")
        strSQL.Append("	WHERE cre.ccodana= usu.ccodusu and  cre.cestado = 'F' AND cre.ndiaatr > @ndiadesde AND cre.ndiaatr <= @ndiahasta  ")
        strSQL.Append("	AND cre.ccodana = @ccodana and cre.ccodcli = cli.ccodcli ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodana", ccodana)
        args(1) = New SqlParameter("@ndiadesde", ndiadesde)
        args(2) = New SqlParameter("@ndiahasta", ndiahasta)

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function VerificaGestion(ByVal ccodcta As String, ByVal dfec1 As Date, ByVal dfec2 As Date) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select  ccodusu from gestion ")
        strSQL.Append("where ccodcta = @ccodcta AND dfecges >= @dfec1 AND dfecges <= @dfec2 ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@dfec1", dfec1)
        args(2) = New SqlParameter("@dfec2", dfec2)

      


        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function Gestiones(ByVal ccodusu As String, ByVal dfec1 As Date, ByVal dfec2 As Date, ByVal cflag As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select * from gestion ")
        strSQL.Append("where dfecges >= @dfec1 AND dfecges <= @dfec2 ")
        If ccodusu.Trim = "" Then
        Else
            strSQL.Append(" AND ccodusu = @ccodusu ")
        End If

        If cflag.Trim = "" Then
        Else
            strSQL.Append(" AND cflag = @cflag ")
        End If
        strSQL.Append("ORDER BY dfecges, ccodana ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", ccodusu)
        args(1) = New SqlParameter("@dfec1", dfec1)
        args(2) = New SqlParameter("@dfec2", dfec2)
        args(3) = New SqlParameter("@cflag", cflag)

        Return sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function ObtieneGestiones(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodins As String, _
                                     ByVal ccodofi As String, ByVal ccodana As String) As DataSet

        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim _sql As String = ""
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                _sql = "select gestion.*, 0 as lvalida, climide.cnomcli from gestion, climide, cremcre " & _
                       "where cremcre.ccodcli = climide.ccodcli and gestion.ccodcta =cremcre.ccodcta and " & _
                       "dfecpag>='" & dfecha1 & "' and dfecpag<='" & dfecha2 & "' "

                If ccodins = "*" Then
                Else
                    _sql = _sql & " and cremcre.coficina in (select ccodofi from tabtofi where ccodins='" & ccodins & "') "

                    If ccodofi = "*" Then
                    Else
                        _sql = _sql & " and cremcre.coficina= '" & ccodofi & "'"
                    End If
                End If

                If ccodana <> "*" Then
                    _sql = _sql & " and cremcre.ccodana= '" & ccodana & "'"
                End If


                command.CommandText = _sql
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "gestion")
                Dim lvalida As Integer = 0
                For Each fila As DataRow In ds.Tables("gestion").Rows
                    lvalida = ValidaConvenio(fila("ccodcta"), fila("nmonconv"), fila("dfecpag"), fila("dfecges"))
                    fila("lvalida") = lvalida
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using
        Return ds
    End Function
    Public Function ValidaConvenio(ByVal ccodcta As String, ByVal nmonto As Decimal, ByVal dfecha As Date, ByVal dfeccon As Date) As Integer
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim _sql As String = ""
        Dim lverifica As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                _sql = "select nmonto, dfecsis, dfecpro, cnuming, cnumrec, ccodofi from credkar " & _
                       "where cconcep ='CJ' and cdescob ='C' and cestado =' ' and " & _
                       " ccodcta ='" & ccodcta & "' and nmonto>='" & nmonto & "' " & _
                       "and dfecpro<='" & Left(dfecha.ToString, 10) & "'"

                command.CommandText = _sql
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Pagos")
                For Each fila As DataRow In ds.Tables("Pagos").Rows
                    'verifica si fecha es despues de convenio 
                    If fila("dfecpro") > dfeccon Then 'cumplio
                        lverifica = 1
                        Exit For
                    Else
                        lverifica = 0
                    End If
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using
        Return lverifica
    End Function
    Public Function ObtieneConveniosPagados(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ccodins As String, _
                                            ByVal ccodofi As String, ByVal ccodana As String) As DataSet

        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim _sql As String = ""
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                _sql = "select gestion.*, 0 as lvalida, climide.cnomcli, space(60) as cagencia,space(10) as cfecpago, " & _
                       "space(30) as cnuming, 000000000.00 as npago, cremcre.ndiaatr from gestion, climide, cremcre " & _
                       "where cremcre.ccodcli = climide.ccodcli and gestion.ccodcta =cremcre.ccodcta and " & _
                       " dfecpag>='" & dfecha1 & "' and dfecpag<='" & dfecha2 & "' "


                If ccodins = "*" Then
                Else
                    _sql = _sql & " and cremcre.coficina in (select ccodofi from tabtofi where ccodins='" & ccodins & "') "

                    If ccodofi = "*" Then
                    Else
                        _sql = _sql & " and cremcre.coficina= '" & ccodofi & "'"
                    End If
                End If

                If ccodana <> "*" Then
                    _sql = _sql & " and cremcre.ccodana= '" & ccodana & "'"
                End If

                command.CommandText = _sql
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "gestion")

                Dim lvalida As Integer = 0
                Dim dspago As New DataSet

                Dim lcagencia As String = ""
                Dim lcfecpago As String = ""
                Dim lcnuming As String = ""
                Dim lnpago As Decimal = 0
                Dim etabtofi As New dbTabtofi
                For Each fila As DataRow In ds.Tables("gestion").Rows
                    dspago = PagoConvenio(fila("ccodcta"), fila("nmonconv"), fila("dfecpag"), fila("dfecges"))
                    For Each filap As DataRow In dspago.Tables(0).Rows
                        If filap("dfecpro") > fila("dfecges") Then 'cumplio
                            lcagencia = etabtofi.NombreAgencia(filap("ccodofi"))
                            lcfecpago = Left(filap("dfecpro").ToString, 10)
                            lcnuming = filap("cnuming")
                            lnpago = filap("nmonto")
                            lvalida = 1
                            Exit For
                        Else
                            lcagencia = ""
                            lcfecpago = ""
                            lcnuming = ""
                            lnpago = 0
                            lvalida = 0
                        End If
                    Next
                    fila("cagencia") = lcagencia
                    fila("cfecpago") = lcfecpago
                    fila("cnuming") = lcnuming
                    fila("npago") = lnpago
                    fila("lvalida") = lvalida
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using
        Return ds
    End Function
    Public Function PagoConvenio(ByVal ccodcta As String, ByVal nmonto As Decimal, ByVal dfecha As Date, ByVal dfeccon As Date) As DataSet
        Dim ds As New DataSet
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim _sql As String = ""
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                _sql = "select nmonto, dfecsis, dfecpro, cnuming, cnumrec, ccodofi, ndiaatr from credkar " & _
                       "where cconcep ='CJ' and cdescob ='C' and cestado =' ' and " & _
                       " ccodcta ='" & ccodcta & "' and nmonto>='" & nmonto & "' " & _
                       "and dfecpro<='" & Left(dfecha.ToString, 10) & "'"

                command.CommandText = _sql
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Pagos")


            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try

        End Using
        Return ds
    End Function
End Class
