Imports System.Text
Public Class dbTabtvar
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtvar
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnomvar =  "" _
            Or lEntidad.cnomvar = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnomvar = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtvar ")
        strSQL.Append(" SET cconvar = @cconvar, ") 
        strSQL.Append(" cdesvar = @cdesvar, ") 
        strSQL.Append(" ctipvar = @ctipvar, ") 
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" lcarini = @lcarini, ") 
        strSQL.Append(" cflag = @cflag ")
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 
        strSQL.Append(" AND cnomvar = @cnomvar ") 

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@cconvar", SqlDbType.VarChar)
        args(0).Value = lEntidad.cconvar
        args(1) = New SqlParameter("@cdesvar", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdesvar
        args(2) = New SqlParameter("@ctipvar", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipvar
        args(3) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodusu
        args(4) = New SqlParameter("@lcarini", SqlDbType.Bit)
        args(4).Value = lEntidad.lcarini
        args(5) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(5).Value = lEntidad.cflag
        args(6) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodapl = Nothing, DBNull.Value,lEntidad.ccodapl)
        args(7) = New SqlParameter("@cnomvar", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.cnomvar = Nothing, DBNull.Value,lEntidad.cnomvar)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtvar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtvar ")
        strSQL.Append(" ( ccodapl, ") 
        strSQL.Append(" cnomvar, ") 
        strSQL.Append(" cconvar, ") 
        strSQL.Append(" cdesvar, ") 
        strSQL.Append(" ctipvar, ") 
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" lcarini, ") 
        strSQL.Append(" cflag) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodapl, ") 
        strSQL.Append(" @cnomvar, ") 
        strSQL.Append(" @cconvar, ") 
        strSQL.Append(" @cdesvar, ") 
        strSQL.Append(" @ctipvar, ") 
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @lcarini, ") 
        strSQL.Append(" @cflag) ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodapl = Nothing, DBNull.Value, lEntidad.ccodapl)
        args(1) = New SqlParameter("@cnomvar", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.cnomvar = Nothing, DBNull.Value, lEntidad.cnomvar)
        args(2) = New SqlParameter("@cconvar", SqlDbType.VarChar)
        args(2).Value = lEntidad.cconvar
        args(3) = New SqlParameter("@cdesvar", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdesvar
        args(4) = New SqlParameter("@ctipvar", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipvar
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@lcarini", SqlDbType.Bit)
        args(6).Value = lEntidad.lcarini
        args(7) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(7).Value = lEntidad.cflag

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtvar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtvar ")
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 
        strSQL.Append(" AND cnomvar = @cnomvar ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodapl
        args(1) = New SqlParameter("@cnomvar", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomvar

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtvar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 
        strSQL.Append(" AND cnomvar = @cnomvar ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodapl
        args(1) = New SqlParameter("@cnomvar", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomvar

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cconvar = IIf(.Item("cconvar") Is DBNull.Value, Nothing, .Item("cconvar"))
                lEntidad.cdesvar = IIf(.Item("cdesvar") Is DBNull.Value, Nothing, .Item("cdesvar"))
                lEntidad.ctipvar = IIf(.Item("ctipvar") Is DBNull.Value, Nothing, .Item("ctipvar"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.lcarini = IIf(.Item("lcarini") Is DBNull.Value, Nothing, .Item("lcarini"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtvar
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnomvar),0) + 1 ")
        strSQL.Append(" FROM tabtvar ")
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodapl

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodapl As String) As listatabtvar

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = ccodapl

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listatabtvar

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtvar
                mEntidad.ccodapl = ccodapl
                mEntidad.cnomvar = IIf(dr("cnomvar") Is DBNull.Value, Nothing, dr("cnomvar"))
                mEntidad.cconvar = IIf(dr("cconvar") Is DBNull.Value, Nothing, dr("cconvar"))
                mEntidad.cdesvar = IIf(dr("cdesvar") Is DBNull.Value, Nothing, dr("cdesvar"))
                mEntidad.ctipvar = IIf(dr("ctipvar") Is DBNull.Value, Nothing, dr("ctipvar"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.lcarini = IIf(dr("lcarini") Is DBNull.Value, Nothing, dr("lcarini"))
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

    Public Function ObtenerDataSetPorID(ccodapl As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", ccodapl)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodapl As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodapl = @ccodapl ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", ccodapl)

        Dim tables(0) As String
        tables(0) = New String("tabtvar")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodapl, ") 
        strSQL.Append(" cnomvar, ") 
        strSQL.Append(" cconvar, ") 
        strSQL.Append(" cdesvar, ") 
        strSQL.Append(" ctipvar, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" lcarini, ") 
        strSQL.Append(" cflag ") 
        strSQL.Append(" FROM tabtvar ")

    End Sub

    Public Function ObtenerDataSetPorID() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ValidaEstadoCierre() As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cConvar FROM TABTVAR ")
        strSQL.Append("WHERE cNomvar ='gcEstado' ")

        Dim ds As New DataSet
        Dim lvalida As Boolean
        Dim lcconvar As String = "1"
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cConvar")) Then
            Else
                lcconvar = Trim(ds.Tables(0).Rows(0)("cConvar"))
            End If
        End If
        If lcconvar.Trim = "1" Then 'Disponible
            lvalida = True
        Else 'Bloquear
            lvalida = False
        End If
        Return lvalida
    End Function

    Public Function Genera_Tabla_Historica(ByVal pdfecini As Date) As Integer

        Dim lnRetorno As Integer = 1
        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = "Cierre_Diario"

                MyParameters = _
                                MyCommand.Parameters.Add("@dfecpro", SqlDbType.DateTime)
                MyParameters.Value = pdfecini
                MyParameters.Direction = ParameterDirection.Input


                MyParameters = _
                                MyCommand.Parameters.Add("@pnError", SqlDbType.Int)
                MyParameters.Direction = ParameterDirection.ReturnValue

                MyCommand.CommandType = CommandType.StoredProcedure
                MyCommand.CommandTimeout = 0

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds)

                lnRetorno = CInt(MyCommand.Parameters("@pnError").Value)

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return lnRetorno

    End Function
End Class
