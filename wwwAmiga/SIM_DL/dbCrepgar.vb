Imports System.Text
Public Class dbCrepgar
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

        Dim lEntidad As crepgar
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodgar =  "" _
            Or lEntidad.ccodgar = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodgar = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE crepgar ")
        strSQL.Append(" SET cmoneda = @cmoneda, ") 
        strSQL.Append(" nmongra = @nmongra, ") 
        strSQL.Append(" cestado = @cestado, ") 
        strSQL.Append(" cnumins = @cnumins, ") 
        strSQL.Append(" dfecval = @dfecval, ") 
        strSQL.Append(" ccodusu = @ccodusu ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodgar = @ccodgar ") 

        Dim args(8) As SqlParameter
        args(0) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(0).Value = lEntidad.cmoneda
        args(1) = New SqlParameter("@nmongra", SqlDbType.VarChar)
        args(1).Value = lEntidad.nmongra
        args(2) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(2).Value = lEntidad.cestado
        args(3) = New SqlParameter("@cnumins", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnumins
        args(4) = New SqlParameter("@dfecval", SqlDbType.Datetime)
        args(4).Value = lEntidad.dfecval
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(6).Value = lEntidad.dfecmod
        args(7) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(7).Value = lEntidad.cflag
        args(8) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(8).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value,lEntidad.ccodcta)
        args(9) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(9).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value,lEntidad.ccodcli)
        args(10) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value,lEntidad.ccodgar)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As crepgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO crepgar ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" ccodgar, ") 
        strSQL.Append(" cmoneda, ") 
        strSQL.Append(" nmongra, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" cnumins, ") 
        strSQL.Append(" dfecval, ") 
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ctipgar, ")
        strSQL.Append(" cflag) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @ccodgar, ") 
        strSQL.Append(" @cmoneda, ") 
        strSQL.Append(" @nmongra, ") 
        strSQL.Append(" @cestado, ") 
        strSQL.Append(" @cnumins, ") 
        strSQL.Append(" @dfecval, ") 
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @ctipgar, ")
        strSQL.Append(" @cflag)")

        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(2) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value, lEntidad.ccodgar)
        args(3) = New SqlParameter("@cmoneda", SqlDbType.VarChar)
        args(3).Value = lEntidad.cmoneda
        args(4) = New SqlParameter("@nmongra", SqlDbType.Decimal)
        args(4).Value = lEntidad.nmongra
        args(5) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(5).Value = lEntidad.cestado
        args(6) = New SqlParameter("@cnumins", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnumins
        args(7) = New SqlParameter("@dfecval", SqlDbType.Datetime)
        args(7).Value = lEntidad.dfecval
        args(8) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodusu
        args(9) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(9).Value = lEntidad.dfecmod
        args(10) = New SqlParameter("@ctipgar", SqlDbType.VarChar)
        args(10).Value = lEntidad.ctipgar
        args(11) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(11).Value = lEntidad.cflag

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As crepgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM crepgar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodgar = @ccodgar ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcli
        args(2) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodgar

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As crepgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodgar = @ccodgar ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcli
        args(2) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodgar

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cmoneda = IIf(.Item("cmoneda") Is DBNull.Value, Nothing, .Item("cmoneda"))
                lEntidad.nmongra = IIf(.Item("nmongra") Is DBNull.Value, Nothing, .Item("nmongra"))
                lEntidad.cestado = IIf(.Item("cestado") Is DBNull.Value, Nothing, .Item("cestado"))
                lEntidad.cnumins = IIf(.Item("cnumins") Is DBNull.Value, Nothing, .Item("cnumins"))
                lEntidad.dfecval = IIf(.Item("dfecval") Is DBNull.Value, Nothing, .Item("dfecval"))
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

        Dim lEntidad As crepgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodgar),0) + 1 ")
        strSQL.Append(" FROM crepgar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodcli

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcta As String, ccodcli As String) As listacrepgar

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta
        args(1) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(1).Value = ccodcli

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listacrepgar

        Try
            Do While dr.Read()
                Dim mEntidad As New crepgar
                mEntidad.ccodcta = ccodcta
                mEntidad.ccodcli = ccodcli
                mEntidad.ccodgar = IIf(dr("ccodgar") Is DBNull.Value, Nothing, dr("ccodgar"))
                mEntidad.cmoneda = IIf(dr("cmoneda") Is DBNull.Value, Nothing, dr("cmoneda"))
                mEntidad.nmongra = IIf(dr("nmongra") Is DBNull.Value, Nothing, dr("nmongra"))
                mEntidad.cestado = IIf(dr("cestado") Is DBNull.Value, Nothing, dr("cestado"))
                mEntidad.cnumins = IIf(dr("cnumins") Is DBNull.Value, Nothing, dr("cnumins"))
                mEntidad.dfecval = IIf(dr("dfecval") Is DBNull.Value, Nothing, dr("dfecval"))
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

    Public Function ObtenerDataSetPorID(ccodcta As String, ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcta As String, ccodcli As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcta = @ccodcta ") 
        strSQL.Append(" AND ccodcli = @ccodcli ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ccodcli", ccodcli)

        Dim tables(0) As String
        tables(0) = New String("crepgar")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcta, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" ccodgar, ") 
        strSQL.Append(" cmoneda, ") 
        strSQL.Append(" nmongra, ") 
        strSQL.Append(" cestado, ") 
        strSQL.Append(" cnumins, ") 
        strSQL.Append(" dfecval, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" cflag ") 
        strSQL.Append(" FROM crepgar ")

    End Sub
    Public Function Actualizar1(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As crepgar
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodgar = "" _
            Or lEntidad.ccodgar = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodgar = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE crepgar ")
        strSQL.Append(" SET nmongra = @nmongra, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" dfecmod = @dfecmod ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")
        strSQL.Append(" AND ccodcli = @ccodcli ")
        strSQL.Append(" AND ccodgar = @ccodgar ")

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@nmongra", SqlDbType.Decimal)
        args(0).Value = lEntidad.nmongra
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodusu
        args(2) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecmod
        args(3) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodcta = Nothing, DBNull.Value, lEntidad.ccodcta)
        args(4) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(5) = New SqlParameter("@ccodgar", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodgar = Nothing, DBNull.Value, lEntidad.ccodgar)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    'Determina si Existen Garantias Hipotecarias
    Public Function ObtenerGarHipo(ByVal ccodcta As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("select climgar.ccodgar, climgar.ctipgar, tabttab.nnumtab from climgar, crepgar, tabttab ")
        strSQL.Append(" WHERE crepgar.ccodcli = climgar.ccodcli and climgar.ccodgar = crepgar.ccodgar ")
        strSQL.Append(" and crepgar.ccodcta = @ccodcta and (climgar.ctipgar='03' or climgar.ctipgar='06') ")
        strSQL.Append(" and tabttab.ccodtab + tabttab.ctipreg = '0741' and left(tabttab.ccodigo,2) = left(climgar.ctipgar,2) ")
        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds


    End Function
    Public Function ObtenerDataSetPorGravamen(ByVal ccodcta As String, ByVal ccodcli As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select climgar.* from climgar, crepgar where  ")
        strSQL.Append("climgar.ccodcli = crepgar.ccodcli ")
        strSQL.Append("and climgar.ccodgar = crepgar.ccodgar ")
        strSQL.Append("and climgar.ctipgar = crepgar.ctipgar ")
        strSQL.Append("and crepgar.ccodcta = @ccodcta ")
        strSQL.Append("and climgar.ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerGarantiaPorGravamen(ByVal ccodcta As String, ByVal ccodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select climgar.* from climgar, crepgar where  ")
        strSQL.Append("climgar.ccodcli = crepgar.ccodcli ")
        strSQL.Append("and climgar.ccodgar = crepgar.ccodgar ")
        strSQL.Append("and climgar.ctipgar = crepgar.ctipgar ")
        strSQL.Append("and crepgar.ccodcta = @ccodcta ")
        strSQL.Append("and climgar.ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        Dim lcgarantia As String = ""
        Dim fila As DataRow
        Dim lcdescri As String = ""
        For Each fila In ds.Tables(0).Rows
            lcdescri = fila("cdescri")
            lcgarantia = lcgarantia & " " & lcdescri.Trim

        Next

        Return lcgarantia

    End Function
    Public Function ObtenerGarantiaFiadoresPorGravamen(ByVal ccodcta As String, ByVal ccodcli As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select climide.cnomcli, climide.ccodcli, climide.cdirdom, climide.cteldom, '' as cteltralab, climide.ctelcon,")
        strSQL.Append(" '' as clugartray, climide.cdirfue, climide.ccodcon ")
        strSQL.Append(" from climide,  climgar, crepgar where  ")
        strSQL.Append(" climide.ccodcli = climgar.ccoduni and  climgar.ccodcli = crepgar.ccodcli ")
        strSQL.Append("and climgar.ccodgar = crepgar.ccodgar ")
        strSQL.Append("and climgar.ctipgar = crepgar.ctipgar ")
        strSQL.Append("and crepgar.ccodcta = @ccodcta ")
        strSQL.Append("and climgar.ccodcli = @ccodcli ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ccodcli", ccodcli)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        Dim lcgarantia As String = ""
        Dim fila As DataRow
        Dim lcdescri As String = ""
        For Each fila In ds.Tables(0).Rows
            lcdescri = Trim(fila("ccodcli")) & " " & Trim(fila("cdirdom")) & " " & Trim(fila("cteldom")) '& " " & Trim(fila("cteltralab")) & " " & Trim(fila("ctelcon")) & " " & Trim(fila("ccodcon")) & " " & Trim(fila("clugartray")) & " "
            lcgarantia = lcgarantia & " " & lcdescri.Trim

        Next

        Return lcgarantia

    End Function

    Public Function ObtenerGarantiasdeuntipoRegistrada(ByVal ccodcta As String, ByVal ctipgar As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Select count(crepgar.ccodgar) as ncontados from climgar, crepgar ")
        strSQL.Append("where climgar.ccodcli = crepgar.ccodcli and climgar.ccodgar = crepgar.ccodgar and crepgar.ccodcta = @ccodcta ")
        strSQL.Append("and climgar.ctipgar  = @ctipgar and crepgar.nmongra > 0  group by crepgar.ccodcta ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", ccodcta)
        args(1) = New SqlParameter("@ctipgar", ctipgar)

        Dim ds As New DataSet

        ds = ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args, 0)

        Dim lncontados As Integer = 0
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ncontados")) Then
            Else
                lncontados = ds.Tables(0).Rows(0)("ncontados")
            End If

        End If

        Return lncontados
    End Function

    Public Function EliminarCrepgar2(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As crepgar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM crepgar ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function ValorGarantia(ByVal lccodcta As String) As Double
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT SUM(Crepgar.nMongra) as nMonGra from crepgar")
        strSQL.Append(" WHERE Crepgar.ccodcta = @lcCodcta group by crepgar.ccodcta")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodcta", SqlDbType.Char)
        args(0).Value = lccodcta

        Dim dsgar As DataSet
        Dim lcvalorgar As Double
        dsgar = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dsgar.Tables(0).Rows.Count = 0 Then
            lcvalorgar = 0
        Else
            lcvalorgar = dsgar.Tables(0).Rows(0)("nmongra")
        End If
        Return lcvalorgar
    End Function

    Public Function ObtenerGarantiaComprometida(ByVal cCodcta As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ISNULL(cdescri,'') AS cdescri FROM CREPGAR ")
        strSQL.Append("WHERE cCodcta = @cCodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", cCodcta)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcdescri As String = ""
        Dim lccadena As String = ""

        Dim fila As DataRow
        Dim i As Integer = 0

        For Each fila In ds.Tables(0).Rows
            lcdescri = ds.Tables(0).Rows(i)("cdescri")
            lccadena = lccadena + lcdescri.Trim + " - "
            i += 1
        Next

        Return lccadena
    End Function
End Class
