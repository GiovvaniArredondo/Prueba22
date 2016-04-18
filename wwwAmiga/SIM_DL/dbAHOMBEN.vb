Imports System.Text
Public Class dbAHOMBEN
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As AHOMBEN
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ncorrel =  0 _
            Or lEntidad.ncorrel = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ncorrel = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE AHOMBEN ")
        strSQL.Append(" SET cnomben = @cnomben, ") 
        strSQL.Append(" cparent = @cparent, ") 
        strSQL.Append(" dfecnac = @dfecnac, ") 
        strSQL.Append(" nporcen = @nporcen, ")
        strSQL.Append(" cdirben = @cdirben, ") 
        strSQL.Append(" ccodcli = @ccodcli ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND ncorrel = @ncorrel ") 

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@cnomben", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomben
        args(1) = New SqlParameter("@cparent", SqlDbType.VarChar)
        args(1).Value = lEntidad.cparent
        args(2) = New SqlParameter("@dfecnac", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecnac
        args(3) = New SqlParameter("@nporcen", SqlDbType.Int)
        args(3).Value = lEntidad.nporcen
        args(4) = New SqlParameter("@cdirben", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdirben
        args(5) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodcli
        args(6) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value,lEntidad.ccodaho)
        args(7) = New SqlParameter("@ncorrel", SqlDbType.Int)
        args(7).Value = IIf(lEntidad.ncorrel = Nothing, DBNull.Value,lEntidad.ncorrel)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As AHOMBEN
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO AHOMBEN ")
        strSQL.Append(" ( ccodaho, ") 
        strSQL.Append(" ncorrel, ") 
        strSQL.Append(" cnomben, ") 
        strSQL.Append(" cparent, ") 
        strSQL.Append(" dfecnac, ") 
        strSQL.Append(" nporcen, ")
        strSQL.Append(" cdirben, ") 
        strSQL.Append(" ccodcli) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodaho, ") 
        strSQL.Append(" @ncorrel, ") 
        strSQL.Append(" @cnomben, ") 
        strSQL.Append(" @cparent, ") 
        strSQL.Append(" @dfecnac, ") 
        strSQL.Append(" @nporcen, ")
        strSQL.Append(" @cdirben, ") 
        strSQL.Append(" @ccodcli) ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(1) = New SqlParameter("@ncorrel", SqlDbType.Int)
        args(1).Value = IIf(lEntidad.ncorrel = Nothing, DBNull.Value, lEntidad.ncorrel)
        args(2) = New SqlParameter("@cnomben", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomben
        args(3) = New SqlParameter("@cparent", SqlDbType.VarChar)
        args(3).Value = lEntidad.cparent
        args(4) = New SqlParameter("@dfecnac", SqlDbType.Datetime)
        args(4).Value = lEntidad.dfecnac
        args(5) = New SqlParameter("@nporcen", SqlDbType.Int)
        args(5).Value = lEntidad.nporcen
        args(6) = New SqlParameter("@cdirben", SqlDbType.VarChar)
        args(6).Value = lEntidad.cdirben
        args(7) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodcli

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As AHOMBEN
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM AHOMBEN ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND ncorrel = @ncorrel ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@ncorrel", SqlDbType.Int)
        args(1).Value = lEntidad.ncorrel

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As AHOMBEN
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 
        strSQL.Append(" AND ncorrel = @ncorrel ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho
        args(1) = New SqlParameter("@ncorrel", SqlDbType.Int)
        args(1).Value = lEntidad.ncorrel

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomben = IIf(.Item("cnomben") Is DBNull.Value, Nothing, .Item("cnomben"))
                lEntidad.cparent = IIf(.Item("cparent") Is DBNull.Value, Nothing, .Item("cparent"))
                lEntidad.dfecnac = IIf(.Item("dfecnac") Is DBNull.Value, Nothing, .Item("dfecnac"))
                lEntidad.nporcen = IIf(.Item("nporcen") Is DBNull.Value, Nothing, .Item("nporcen"))
                lEntidad.cdirben = IIf(.Item("cdirben") Is DBNull.Value, Nothing, .Item("cdirben"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As AHOMBEN
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ncorrel),0) + 1 ")
        strSQL.Append(" FROM AHOMBEN ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodaho As String) As listaAHOMBEN

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = ccodaho

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaAHOMBEN

        Try
            Do While dr.Read()
                Dim mEntidad As New AHOMBEN
                mEntidad.ccodaho = ccodaho
                mEntidad.ncorrel = IIf(dr("ncorrel") Is DBNull.Value, Nothing, dr("ncorrel"))
                mEntidad.cnomben = IIf(dr("cnomben") Is DBNull.Value, Nothing, dr("cnomben"))
                mEntidad.cparent = IIf(dr("cparent") Is DBNull.Value, Nothing, dr("cparent"))
                mEntidad.dfecnac = IIf(dr("dfecnac") Is DBNull.Value, Nothing, dr("dfecnac"))
                mEntidad.nporcen = IIf(dr("nporcen") Is DBNull.Value, Nothing, dr("nporcen"))
                mEntidad.cdirben = IIf(dr("cdirben") Is DBNull.Value, Nothing, dr("cdirben"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodaho As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodaho As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim tables(0) As String
        tables(0) = New String("AHOMBEN")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodaho, ") 
        strSQL.Append(" ncorrel, ") 
        strSQL.Append(" cnomben, ") 
        strSQL.Append(" cparent, ") 
        strSQL.Append(" dfecnac, ") 
        strSQL.Append(" nporcen, ") 
        strSQL.Append(" cdirben, ") 
        strSQL.Append(" ccodcli ") 
        strSQL.Append(" FROM AHOMBEN ")

    End Sub

    Public Function ObtenerBeneficiarios(ByVal ccodaho As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT * FROM AHOMBEN ")
        strSQL.Append("WHERE ccodaho = @ccodaho ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", ccodaho)

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function


    Public Function Extrae_Beneficiarios_Ctas(ByVal pcCodcli As String, ByVal producto As String) As DataSet

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = _
                                         " Select * from Ahomben " & _
                                         " Where cCodcli ='" & pcCodcli & "' and substring(ccodaho,5,2) ='" & producto & "'"

                MyCommand.CommandType = CommandType.Text

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds, "BD_Beneficia")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return Ds

    End Function


    Public Function Extrae_Beneficiarios(ByVal pcCodcli As String) As DataSet

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = _
                                         " Select * from Ahomben " & _
                                         " Where cCodcli ='" & pcCodcli & "'"

                MyCommand.CommandType = CommandType.Text

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds, "BD_Beneficia")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return Ds

    End Function


    Public Function Extrae_Beneficiarios_Aporta_Corriente(ByVal pcCodcli As String) As DataSet

        Dim MyCommand As New SqlCommand
        Dim MyParameters As SqlParameter
        Dim MyAdapter As New SqlDataAdapter
        Dim Ds As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()

            Try

                MyCommand.Connection = connection
                MyCommand.CommandText = _
                                         " Select * from Ahomben " & _
                                         " Where cCodcli ='" & pcCodcli & "'" & _
                                         " and substring(ccodaho,7,2) = '02'"

                MyCommand.CommandType = CommandType.Text

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds, "BD_Beneficia_Corriente")



                MyCommand.Connection = connection
                MyCommand.CommandText = _
                                         " Select * from Ahomben " & _
                                         " Where cCodcli ='" & pcCodcli & "'" & _
                                         " and substring(ccodaho,7,2) = '06'"

                MyCommand.CommandType = CommandType.Text

                MyAdapter.SelectCommand = MyCommand
                MyAdapter.Fill(Ds, "BD_Beneficia_Aporta")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using

        Return Ds

    End Function

End Class
