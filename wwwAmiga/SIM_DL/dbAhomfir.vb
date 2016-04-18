Imports System.Text
Public Class dbAhomfir
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Ahomfir

        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE Ahomfir ")
        strSQL.Append(" SET nlibreta = @nlibreta, ")
        strSQL.Append(" nmanco = @nmanco, ")
        strSQL.Append(" cnomau = @cnomau, ")
        strSQL.Append(" cnomgfir = @cnomgfir, ")
        strSQL.Append(" cnomgfir2 = @cnomgfir2, ")
        strSQL.Append(" cnomgfir3 = @cnomgfir3, ")
        strSQL.Append(" dnacgfir = @dnacgfir, ")
        strSQL.Append(" dnacgfir2 = @dnacgfir2, ")
        strSQL.Append(" dnacgfir3 = @dnacgfir3, ")
        strSQL.Append(" cdui1 = @cdui1, ")
        strSQL.Append(" cdui2 = @cdui2, ")
        strSQL.Append(" cdui3 = @cdui3 ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ")

        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@nlibreta", SqlDbType.Int)
        args(0).Value = lEntidad.nlibreta
        args(1) = New SqlParameter("@nmanco", SqlDbType.Int)
        args(1).Value = lEntidad.nmanco
        args(2) = New SqlParameter("@cnomau", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomau
        args(3) = New SqlParameter("@cnomgfir", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomgfir
        args(4) = New SqlParameter("@cnomgfir2", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnomgfir2
        args(5) = New SqlParameter("@cnomgfir3", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnomgfir3
        args(6) = New SqlParameter("@dnacgfir", SqlDbType.DateTime)
        args(6).Value = lEntidad.dnacgfir
        args(7) = New SqlParameter("@dnacgfir2", SqlDbType.DateTime)
        args(7).Value = lEntidad.dnacgfir2
        args(8) = New SqlParameter("@dnacgfir3", SqlDbType.DateTime)
        args(8).Value = lEntidad.dnacgfir3
        args(9) = New SqlParameter("@cdui1", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdui1
        args(10) = New SqlParameter("@cdui2", SqlDbType.VarChar)
        args(10).Value = lEntidad.cdui2
        args(11) = New SqlParameter("@cdui3", SqlDbType.VarChar)
        args(11).Value = lEntidad.cdui3
        args(12) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(12).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Ahomfir
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Ahomfir ")
        strSQL.Append(" ( ccodaho, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" nmanco, ") 
        strSQL.Append(" cnomau, ") 
        strSQL.Append(" cnomgfir, ") 
        strSQL.Append(" cnomgfir2, ") 
        strSQL.Append(" cnomgfir3, ") 
        strSQL.Append(" dnacgfir, ") 
        strSQL.Append(" dnacgfir2, ") 
        strSQL.Append(" dnacgfir3, ") 
        strSQL.Append(" cdui1, ")
        strSQL.Append(" cdui2, ") 
        strSQL.Append(" cdui3) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodaho, ") 
        strSQL.Append(" @nlibreta, ") 
        strSQL.Append(" @nmanco, ") 
        strSQL.Append(" @cnomau, ") 
        strSQL.Append(" @cnomgfir, ") 
        strSQL.Append(" @cnomgfir2, ") 
        strSQL.Append(" @cnomgfir3, ") 
        strSQL.Append(" @dnacgfir, ") 
        strSQL.Append(" @dnacgfir2, ") 
        strSQL.Append(" @dnacgfir3, ") 
        strSQL.Append(" @cdui1, ")
        strSQL.Append(" @cdui2, ") 
        strSQL.Append(" @cdui3) ")

        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodaho = Nothing, DBNull.Value, lEntidad.ccodaho)
        args(1) = New SqlParameter("@nlibreta", SqlDbType.Int)
        args(1).Value = lEntidad.nlibreta
        args(2) = New SqlParameter("@nmanco", SqlDbType.Int)
        args(2).Value = lEntidad.nmanco
        args(3) = New SqlParameter("@cnomau", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnomau
        args(4) = New SqlParameter("@cnomgfir", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnomgfir
        args(5) = New SqlParameter("@cnomgfir2", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnomgfir2
        args(6) = New SqlParameter("@cnomgfir3", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnomgfir3
        args(7) = New SqlParameter("@dnacgfir", SqlDbType.Datetime)
        args(7).Value = lEntidad.dnacgfir
        args(8) = New SqlParameter("@dnacgfir2", SqlDbType.Datetime)
        args(8).Value = lEntidad.dnacgfir2
        args(9) = New SqlParameter("@dnacgfir3", SqlDbType.Datetime)
        args(9).Value = lEntidad.dnacgfir3
        args(10) = New SqlParameter("@cdui1", SqlDbType.VarChar)
        args(10).Value = lEntidad.cdui1
        args(11) = New SqlParameter("@cdui2", SqlDbType.VarChar)
        args(11).Value = lEntidad.cdui2
        args(12) = New SqlParameter("@cdui3", SqlDbType.VarChar)
        args(12).Value = lEntidad.cdui3

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Ahomfir
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM Ahomfir ")
        strSQL.Append(" WHERE ccodaho = @ccodaho ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodaho", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodaho

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Ahomfir
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
                lEntidad.nlibreta = IIf(.Item("nlibreta") Is DBNull.Value, Nothing, .Item("nlibreta"))
                lEntidad.nmanco = IIf(.Item("nmanco") Is DBNull.Value, Nothing, .Item("nmanco"))
                lEntidad.cnomau = IIf(.Item("cnomau") Is DBNull.Value, Nothing, .Item("cnomau"))
                lEntidad.cnomgfir = IIf(.Item("cnomgfir") Is DBNull.Value, "", .Item("cnomgfir"))
                lEntidad.cnomgfir2 = IIf(.Item("cnomgfir2") Is DBNull.Value, "", .Item("cnomgfir2"))
                lEntidad.cnomgfir3 = IIf(.Item("cnomgfir3") Is DBNull.Value, "", .Item("cnomgfir3"))
                lEntidad.dnacgfir = IIf(.Item("dnacgfir") Is DBNull.Value, Nothing, .Item("dnacgfir"))
                lEntidad.dnacgfir2 = IIf(.Item("dnacgfir2") Is DBNull.Value, Nothing, .Item("dnacgfir2"))
                lEntidad.dnacgfir3 = IIf(.Item("dnacgfir3") Is DBNull.Value, Nothing, .Item("dnacgfir3"))
                lEntidad.cdui1 = IIf(.Item("cdui1") Is DBNull.Value, "", .Item("cdui1"))
                lEntidad.cdui2 = IIf(.Item("cdui2") Is DBNull.Value, "", .Item("cdui2"))
                lEntidad.cdui3 = IIf(.Item("cdui3") Is DBNull.Value, "", .Item("cdui3"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As Ahomfir
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodaho),0) + 1 ")
        strSQL.Append(" FROM Ahomfir ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaAhomfir

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New ListaAhomfir

        Try
            Do While dr.Read()
                Dim mEntidad As New Ahomfir
                mEntidad.ccodaho = IIf(dr("ccodaho") Is DBNull.Value, Nothing, dr("ccodaho"))
                mEntidad.nlibreta = IIf(dr("nlibreta") Is DBNull.Value, Nothing, dr("nlibreta"))
                mEntidad.nmanco = IIf(dr("nmanco") Is DBNull.Value, Nothing, dr("nmanco"))
                mEntidad.cnomau = IIf(dr("cnomau") Is DBNull.Value, Nothing, dr("cnomau"))
                mEntidad.cnomgfir = IIf(dr("cnomgfir") Is DBNull.Value, Nothing, dr("cnomgfir"))
                mEntidad.cnomgfir2 = IIf(dr("cnomgfir2") Is DBNull.Value, Nothing, dr("cnomgfir2"))
                mEntidad.cnomgfir3 = IIf(dr("cnomgfir3") Is DBNull.Value, Nothing, dr("cnomgfir3"))
                mEntidad.dnacgfir = IIf(dr("dnacgfir") Is DBNull.Value, Nothing, dr("dnacgfir"))
                mEntidad.dnacgfir2 = IIf(dr("dnacgfir2") Is DBNull.Value, Nothing, dr("dnacgfir2"))
                mEntidad.dnacgfir3 = IIf(dr("dnacgfir3") Is DBNull.Value, Nothing, dr("dnacgfir3"))
                mEntidad.cdui1 = IIf(dr("cdui1") Is DBNull.Value, Nothing, dr("cdui1"))
                mEntidad.cdui2 = IIf(dr("cdui2") Is DBNull.Value, Nothing, dr("cdui2"))
                mEntidad.cdui3 = IIf(dr("cdui3") Is DBNull.Value, Nothing, dr("cdui3"))
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

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("Ahomfir")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodaho, ") 
        strSQL.Append(" nlibreta, ") 
        strSQL.Append(" nmanco, ") 
        strSQL.Append(" cnomau, ") 
        strSQL.Append(" cnomgfir, ") 
        strSQL.Append(" cnomgfir2, ") 
        strSQL.Append(" cnomgfir3, ") 
        strSQL.Append(" dnacgfir, ") 
        strSQL.Append(" dnacgfir2, ") 
        strSQL.Append(" dnacgfir3, ") 
        strSQL.Append(" cdui1, ") 
        strSQL.Append(" cdui2, ") 
        strSQL.Append(" cdui3 ") 
        strSQL.Append(" FROM Ahomfir ")

    End Sub

    Public Function CargaFirmas() As DataSet
        Dim rs As New DataSet, dr As DataRow
        Dim dat_AdBen As New DataTable("Firmas")

        Try

            dat_AdBen.Clear()
            dat_AdBen.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_AdBen.Columns.Add("cNomFir", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_AdBen.Columns.Add("cnudoci", Type.GetType("System.String"))

            rs.Tables.Add(dat_AdBen)

        Catch ex As Exception

        End Try

        Return rs

    End Function


    Public Function CargaFirmas_() As DataSet
        Dim dat_Firm As New DataTable("Firmas")
        Dim dat_AdBen As New DataTable("Beneficiarios")
        Dim rs As New DataSet

        Try

            dat_Firm.Clear()
            dat_Firm.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_Firm.Columns.Add("cNomFir", Type.GetType("System.String"))
            dat_Firm.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_Firm.Columns.Add("cnudoci", Type.GetType("System.String"))

            dat_AdBen.Clear()
            dat_AdBen.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_AdBen.Columns.Add("cNomBen", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_AdBen.Columns.Add("cParent", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("cDirecc", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("nPorcen", Type.GetType("System.Decimal"))


            rs.Tables.Add(dat_AdBen)
            rs.Tables.Add(dat_Firm)

        Catch ex As Exception

        End Try

        Return rs

    End Function


    Public Function Carga_Afiliacion() As DataSet
        Dim dat_Firm As New DataTable("Firmas")
        Dim dat_AdBen As New DataTable("Beneficiarios")
        Dim dat_AdBen_Ap As New DataTable("Beneficiarios_Aporta")
        Dim dat_Ref As New DataTable("Referencias")
        Dim rs As New DataSet


        Try

            dat_Firm.Clear()
            dat_Firm.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_Firm.Columns.Add("cNomFir", Type.GetType("System.String"))
            dat_Firm.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_Firm.Columns.Add("cnudoci", Type.GetType("System.String"))

            dat_AdBen.Clear()
            dat_AdBen.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_AdBen.Columns.Add("cNomBen", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_AdBen.Columns.Add("cParent", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("cDirecc", Type.GetType("System.String"))
            dat_AdBen.Columns.Add("nPorcen", Type.GetType("System.Decimal"))

            dat_AdBen_Ap.Clear()
            dat_AdBen_Ap.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_AdBen_Ap.Columns.Add("cNomBen", Type.GetType("System.String"))
            dat_AdBen_Ap.Columns.Add("dnacimi", Type.GetType("System.DateTime"))
            dat_AdBen_Ap.Columns.Add("cParent", Type.GetType("System.String"))
            dat_AdBen_Ap.Columns.Add("cDirecc", Type.GetType("System.String"))
            dat_AdBen_Ap.Columns.Add("nPorcen", Type.GetType("System.Decimal"))


            dat_Ref.Clear()
            dat_Ref.Columns.Add("IdCuenta", Type.GetType("System.Decimal"))
            dat_Ref.Columns.Add("cNomRef", Type.GetType("System.String"))
            dat_Ref.Columns.Add("cParent", Type.GetType("System.String"))
            dat_Ref.Columns.Add("cDirecc", Type.GetType("System.String"))
            dat_Ref.Columns.Add("ctelefono", Type.GetType("System.String"))


            rs.Tables.Add(dat_AdBen)
            rs.Tables.Add(dat_Firm)
            rs.Tables.Add(dat_AdBen_Ap)
            rs.Tables.Add(dat_Ref)

        Catch ex As Exception

        End Try

        Return rs

    End Function

    Public Function Buscar_Firmas_Autorizadas(ByVal pcCodaho As String) As DataSet


        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_fir As New DataSet
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction



        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try

                command.CommandText = _
                                        " Select ccodaho, cnomgfir as cnomfir, dnacgfir as dnacimi, cdui as cnudoci, " & _
                                        " ID as idcuenta From Ahomfir " & _
                                        " Where cCodaho  ='" & pcCodaho & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_fir, "Firmas")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
                Mytransaccion.Rollback()
            Finally
                connection.Close()
            End Try

        End Using


        Return ds_fir

    End Function

    Public Function Mantenimiento_Firmas_Autorizadas(ByVal Detalle_Cta As ArrayList, _
                                                     ByVal dt_fir As DataTable) As Integer


        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_ctas As New DataSet
        Dim i As Integer = 0
        Dim occlass As New dbCntamov
        Dim Mytransaccion As SqlTransaction
        Dim lnlibreta As Integer


        'Detalle_Cta.Item(0)   'No Cta Ahorro
        'Detalle_Cta.Item(1)   'Usuario que modifica


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try

                command.CommandText = _
                                        " Select * From Ahomcta" & _
                                        " Where cCodaho  ='" & Detalle_Cta.Item(0) & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_ctas, "Cta_Ahorros")


                For Each fila As DataRow In ds_ctas.Tables("Cta_Ahorros").Rows
                    lnlibreta = fila("nlibreta").ToString.Trim
                Next


                'Elimina todas las firmas que esten almacenadas
                command.CommandText = _
                                        " Delete from Ahomfir " & _
                                        " Where cCodaho ='" & Detalle_Cta.Item(0) & "'"

                command.ExecuteNonQuery()

                'Inserta Firmas Autorizadas
                For Each fila As DataRow In dt_fir.Rows
                    command.CommandText = _
                                            " Insert into Ahomfir (ccodaho, nlibreta, nmanco, cnomau, cnomgfir, dnacgfir, cdui, ccodusu, dfecmod, id) " & _
                                            " values('" & Detalle_Cta.Item(0) & "'," & lnlibreta & ",0,''" & _
                                            fila("cNomFir") & "','" & fila("dnacimi") & "','" & fila("cnudoci") & "','" & _
                                            Detalle_Cta.Item(1) & "',getdate(), '" & fila("IdCuenta") & "')"

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

End Class
