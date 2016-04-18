Imports System.Text
Public Class dbTabtzon
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtzon
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodzon =  "" _
            Or lEntidad.ccodzon = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodzon = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtzon ")
        strSQL.Append(" SET cdeszon = @cdeszon ") 
        strSQL.Append(" ctipzon = @ctipzon, ") 
        strSQL.Append(" cnivreg = @cnivreg, ") 
        strSQL.Append(" WHERE ccodzon = @ccodzon ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cdeszon", SqlDbType.VarChar)
        args(0).Value = lEntidad.cdeszon
        args(1) = New SqlParameter("@ctipzon", SqlDbType.VarChar)
        args(1).Value = lEntidad.ctipzon
        args(2) = New SqlParameter("@cnivreg", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnivreg
        args(3) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodzon = Nothing, DBNull.Value,lEntidad.ccodzon)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtzon
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtzon ")
        strSQL.Append(" ( ccodzon, ") 
        strSQL.Append(" cdeszon) ") 
        strSQL.Append(" ctipzon, ") 
        strSQL.Append(" cnivreg, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodzon, ") 
        strSQL.Append(" @cdeszon) ") 
        strSQL.Append(" @ctipzon, ") 
        strSQL.Append(" @cnivreg, ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodzon = Nothing, DBNull.Value, lEntidad.ccodzon)
        args(1) = New SqlParameter("@cdeszon", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdeszon
        args(2) = New SqlParameter("@ctipzon", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipzon
        args(3) = New SqlParameter("@cnivreg", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnivreg

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtzon
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtzon ")
        strSQL.Append(" WHERE ccodzon = @ccodzon ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodzon

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtzon
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodzon = @ccodzon ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodzon", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodzon

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cdeszon = IIf(.Item("cdeszon") Is DBNull.Value, Nothing, .Item("cdeszon"))
                lEntidad.ctipzon = IIf(.Item("ctipzon") Is DBNull.Value, Nothing, .Item("ctipzon"))
                lEntidad.cnivreg = IIf(.Item("cnivreg") Is DBNull.Value, Nothing, .Item("cnivreg"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtzon
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodzon),0) + 1 ")
        strSQL.Append(" FROM tabtzon ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID(ByVal cTipzon As String) As listatabtzon

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cTipzon = @cTipzon order by cdeszon ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cTipzon", cTipzon)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabtzon

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtzon
                mEntidad.ccodzon = IIf(dr("ccodzon") Is DBNull.Value, Nothing, dr("ccodzon"))
                mEntidad.cdeszon = IIf(dr("cdeszon") Is DBNull.Value, Nothing, dr("cdeszon"))
                mEntidad.ctipzon = IIf(dr("ctipzon") Is DBNull.Value, Nothing, dr("ctipzon"))
                mEntidad.cnivreg = IIf(dr("cnivreg") Is DBNull.Value, Nothing, dr("cnivreg"))
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
        tables(0) = New String("tabtzon")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT rtrim(ltrim(ccodzon)) as ccodzon, ")
        strSQL.Append(" cdeszon, ")
        strSQL.Append(" ctipzon, ")
        strSQL.Append(" cnivreg ")
        strSQL.Append(" FROM tabtzon ")

    End Sub

    Public Function ObtenerListaPorID1(ByVal cCodzon As String, ByVal cTipzon As String) As listatabtzon

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        'strSQL.Append("where cCodzon like" & "'" & cCodzon & "%" & "'")
        strSQL.Append("where ")
        If cTipzon.Trim = "1" Then
            strSQL.Append("cCodzon = @cCodzon ")
        ElseIf cTipzon.Trim = "2" Then
            strSQL.Append("left(cCodzon,2) = @cCodzon ")
        Else
            strSQL.Append("left(cCodzon,5) = @cCodzon ")
        End If

        strSQL.Append(" And cTipzon = @cTipzon ")
        strSQL.Append(" Order by cDeszon ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cTipzon", cTipzon)
        args(1) = New SqlParameter("@ccodzon", cCodzon)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabtzon

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtzon
                mEntidad.ccodzon = IIf(dr("ccodzon") Is DBNull.Value, Nothing, dr("ccodzon"))
                mEntidad.cdeszon = IIf(dr("cdeszon") Is DBNull.Value, Nothing, dr("cdeszon"))
                mEntidad.ctipzon = IIf(dr("ctipzon") Is DBNull.Value, Nothing, dr("ctipzon"))
                mEntidad.cnivreg = IIf(dr("cnivreg") Is DBNull.Value, Nothing, dr("cnivreg"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function Zona(ByVal lccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cdeszon from tabtzon ")
        strSQL.Append("WHERE cCodzon = @lcCodigo")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo
        
        Dim lczona As String
        Dim dszon As DataSet
        dszon = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dszon.Tables(0).Rows.Count = 0 Then
            lczona = "NO INDICADO"
        Else
            lczona = dszon.Tables(0).Rows(0)("cdeszon")
        End If
        Return lczona.Trim
    End Function
    Public Function ObtieneNumerodeOrden(ByVal lccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select corden from tabtzon ")
        strSQL.Append("WHERE cCodzon = @lcCodigo")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo

        Dim lczona As String
        Dim dszon As DataSet
        dszon = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dszon.Tables(0).Rows.Count = 0 Then
            lczona = ""
        Else
            lczona = dszon.Tables(0).Rows(0)("corden")
        End If
        Return lczona.Trim
    End Function
    Public Function ObtieneCodigoDepto(ByVal lccodigo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select left(ccodzon,2) as ccodzon from tabtzon ")
        strSQL.Append("WHERE corden = @lcCodigo and ctipzon ='1'")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodigo", SqlDbType.Char)
        args(0).Value = lccodigo

        Dim lczona As String
        Dim dszon As DataSet
        dszon = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If dszon.Tables(0).Rows.Count = 0 Then
            lczona = "01"
        Else
            lczona = dszon.Tables(0).Rows(0)("ccodzon")
        End If
        Return lczona.Trim
    End Function

    Public Function Extraer_Datos_Zona(ByVal pcCodzon As String) As ArrayList


        Dim array_d As New ArrayList
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim Mytransaccion As SqlTransaction
        Dim ds As New DataSet

        array_d.Add("")  'Tipo de Region
        array_d.Add("")  'Codigo Postal

        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            command.Connection = connection

            Try



                _sql = _
                        " Select * From Tabtzon" & _
                        " Where cCodzon = '" & pcCodzon & "' and ctipzon = '3'"



                command.CommandText = _sql

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Zonas")


                For Each fila As DataRow In ds.Tables(0).Rows
                    array_d.Item(0) = fila("cnivreg")            'Tipo de Region
                    array_d.Item(1) = fila("id_codigo_postal")   'Codigo Postal
                Next


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
                Mytransaccion.Rollback()
            Finally
                connection.Close()
            End Try

        End Using


        Return array_d

    End Function


End Class
