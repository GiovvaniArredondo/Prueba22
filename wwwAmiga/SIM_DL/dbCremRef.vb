Imports System.Text
Public Class dbCremRef
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CremRef
        Dim lID As Long
        lEntidad = aEntidad

        'If lEntidad. =  0 _
        '    Or lEntidad.dfecpro = Nothing Then 

        '    lID = Me.ObtenerID(lEntidad)

        '    If lID = -1 Then Return -1

        '    lEntidad.dfecpro = lID

        '    Return Agregar(lEntidad)

        'End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE CremRef ")
        strSQL.Append(" SET ccodcta = @ccodcta, ") 
        strSQL.Append(" cnomcli = @cnomcli, ") 
        strSQL.Append(" nsalcap = @nsalcap, ") 
        strSQL.Append(" ctabco = @ctabco, ") 
        strSQL.Append(" cnumchq = @cnumchq, ") 
        strSQL.Append(" ntotal = @ntotal, ") 
        strSQL.Append(" ccodcli = @ccodcli, ") 
        strSQL.Append(" nsalint = @nsalint, ") 
        strSQL.Append(" nsalmor = @nsalmor, ") 
        strSQL.Append(" nmanejo = @nmanejo, ") 
        strSQL.Append(" nseguro = @nseguro, ") 
        strSQL.Append(" ccodlin = @ccodlin, ") 
        strSQL.Append(" ccodpre = @ccodpre, ") 
        strSQL.Append(" ccodusu = @ccodusu ") 
        strSQL.Append(" dfecsis = @dfecsis, ") 
        strSQL.Append(" dfecpro = @dfecpro, ") 

        Dim args(15) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomcli
        args(2) = New SqlParameter("@nsalcap", SqlDbType.Decimal)
        args(2).Value = lEntidad.nsalcap
        args(3) = New SqlParameter("@ctabco", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctabco
        args(4) = New SqlParameter("@cnumchq", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumchq
        args(5) = New SqlParameter("@ntotal", SqlDbType.Decimal)
        args(5).Value = lEntidad.ntotal
        args(6) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodcli
        args(7) = New SqlParameter("@nsalint", SqlDbType.Decimal)
        args(7).Value = lEntidad.nsalint
        args(8) = New SqlParameter("@nsalmor", SqlDbType.Decimal)
        args(8).Value = lEntidad.nsalmor
        args(9) = New SqlParameter("@nmanejo", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmanejo
        args(10) = New SqlParameter("@nseguro", SqlDbType.Decimal)
        args(10).Value = lEntidad.nseguro
        args(11) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodlin
        args(12) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodpre
        args(13) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodusu
        args(14) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(14).Value = lEntidad.dfecsis
        args(15) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(15).Value = lEntidad.dfecpro

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CremRef
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO CremRef ")
        strSQL.Append(" ( ccodcta, ") 
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" nsalcap, ") 
        strSQL.Append(" ctabco, ") 
        strSQL.Append(" cnumchq, ") 
        strSQL.Append(" ntotal, ") 
        strSQL.Append(" ccodcli, ") 
        strSQL.Append(" nsalint, ") 
        strSQL.Append(" nsalmor, ") 
        strSQL.Append(" nmanejo, ") 
        strSQL.Append(" nseguro, ") 
        strSQL.Append(" ccodlin, ") 
        strSQL.Append(" ccodpre, ") 
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecsis, ") 
        strSQL.Append(" dfecpro, niva) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcta, ") 
        strSQL.Append(" @cnomcli, ") 
        strSQL.Append(" @nsalcap, ") 
        strSQL.Append(" @ctabco, ") 
        strSQL.Append(" @cnumchq, ") 
        strSQL.Append(" @ntotal, ") 
        strSQL.Append(" @ccodcli, ") 
        strSQL.Append(" @nsalint, ") 
        strSQL.Append(" @nsalmor, ") 
        strSQL.Append(" @nmanejo, ") 
        strSQL.Append(" @nseguro, ") 
        strSQL.Append(" @ccodlin, ") 
        strSQL.Append(" @ccodpre, ") 
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @dfecsis, ") 
        strSQL.Append(" @dfecpro, @niva) ")
       
        Dim args(16) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomcli
        args(2) = New SqlParameter("@nsalcap", SqlDbType.Decimal)
        args(2).Value = lEntidad.nsalcap
        args(3) = New SqlParameter("@ctabco", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctabco
        args(4) = New SqlParameter("@cnumchq", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumchq
        args(5) = New SqlParameter("@ntotal", SqlDbType.Decimal)
        args(5).Value = lEntidad.ntotal
        args(6) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(6).Value = lEntidad.ccodcli
        args(7) = New SqlParameter("@nsalint", SqlDbType.Decimal)
        args(7).Value = lEntidad.nsalint
        args(8) = New SqlParameter("@nsalmor", SqlDbType.Decimal)
        args(8).Value = lEntidad.nsalmor
        args(9) = New SqlParameter("@nmanejo", SqlDbType.Decimal)
        args(9).Value = lEntidad.nmanejo
        args(10) = New SqlParameter("@nseguro", SqlDbType.Decimal)
        args(10).Value = lEntidad.nseguro
        args(11) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodlin
        args(12) = New SqlParameter("@ccodpre", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodpre
        args(13) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodusu
        args(14) = New SqlParameter("@dfecsis", SqlDbType.Datetime)
        args(14).Value = lEntidad.dfecsis
        args(15) = New SqlParameter("@dfecpro", SqlDbType.Datetime)
        args(15).Value = lEntidad.dfecpro
        args(16) = New SqlParameter("@niva", SqlDbType.Decimal)
        args(16).Value = lEntidad.niva

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CremRef
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cremref ")
        strSQL.Append(" WHERE ccodcta = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcta

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As CremRef
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim args(-1) As SqlParameter

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodcta = IIf(.Item("ccodcta") Is DBNull.Value, Nothing, .Item("ccodcta"))
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.nsalcap = IIf(.Item("nsalcap") Is DBNull.Value, Nothing, .Item("nsalcap"))
                lEntidad.niva = IIf(.Item("niva") Is DBNull.Value, Nothing, .Item("niva"))
                lEntidad.ctabco = IIf(.Item("ctabco") Is DBNull.Value, Nothing, .Item("ctabco"))
                lEntidad.cnumchq = IIf(.Item("cnumchq") Is DBNull.Value, Nothing, .Item("cnumchq"))
                lEntidad.ntotal = IIf(.Item("ntotal") Is DBNull.Value, Nothing, .Item("ntotal"))
                lEntidad.ccodcli = IIf(.Item("ccodcli") Is DBNull.Value, Nothing, .Item("ccodcli"))
                lEntidad.nsalint = IIf(.Item("nsalint") Is DBNull.Value, Nothing, .Item("nsalint"))
                lEntidad.nsalmor = IIf(.Item("nsalmor") Is DBNull.Value, Nothing, .Item("nsalmor"))
                lEntidad.nmanejo = IIf(.Item("nmanejo") Is DBNull.Value, Nothing, .Item("nmanejo"))
                lEntidad.nseguro = IIf(.Item("nseguro") Is DBNull.Value, Nothing, .Item("nseguro"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.ccodpre = IIf(.Item("ccodpre") Is DBNull.Value, Nothing, .Item("ccodpre"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecsis = IIf(.Item("dfecsis") Is DBNull.Value, Nothing, .Item("dfecsis"))
                lEntidad.dfecpro = IIf(.Item("dfecpro") Is DBNull.Value, Nothing, .Item("dfecpro"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As CremRef
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(),0) + 1 ")
        strSQL.Append(" FROM CremRef ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaCremRef

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaCremRef

        Try
            Do While dr.Read()
                Dim mEntidad As New CremRef
                mEntidad.ccodcta = IIf(dr("ccodcta") Is DBNull.Value, Nothing, dr("ccodcta"))
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.nsalcap = IIf(dr("nsalcap") Is DBNull.Value, Nothing, dr("nsalcap"))
                mEntidad.ctabco = IIf(dr("ctabco") Is DBNull.Value, Nothing, dr("ctabco"))
                mEntidad.cnumchq = IIf(dr("cnumchq") Is DBNull.Value, Nothing, dr("cnumchq"))
                mEntidad.ntotal = IIf(dr("ntotal") Is DBNull.Value, Nothing, dr("ntotal"))
                mEntidad.ccodcli = IIf(dr("ccodcli") Is DBNull.Value, Nothing, dr("ccodcli"))
                mEntidad.nsalint = IIf(dr("nsalint") Is DBNull.Value, Nothing, dr("nsalint"))
                mEntidad.nsalmor = IIf(dr("nsalmor") Is DBNull.Value, Nothing, dr("nsalmor"))
                mEntidad.nmanejo = IIf(dr("nmanejo") Is DBNull.Value, Nothing, dr("nmanejo"))
                mEntidad.niva = IIf(dr("niva") Is DBNull.Value, Nothing, dr("niva"))
                mEntidad.nseguro = IIf(dr("nseguro") Is DBNull.Value, Nothing, dr("nseguro"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.ccodpre = IIf(dr("ccodpre") Is DBNull.Value, Nothing, dr("ccodpre"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecsis = IIf(dr("dfecsis") Is DBNull.Value, Nothing, dr("dfecsis"))
                mEntidad.dfecpro = IIf(dr("dfecpro") Is DBNull.Value, Nothing, dr("dfecpro"))
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
        tables(0) = New String("CremRef")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodcta, ")
        strSQL.Append(" cnomcli, ")
        strSQL.Append(" nsalcap, ")
        strSQL.Append(" ctabco, ")
        strSQL.Append(" cnumchq, ")
        strSQL.Append(" ntotal, ")
        strSQL.Append(" ccodcli, ")
        strSQL.Append(" nsalint, ")
        strSQL.Append(" nsalmor, ")
        strSQL.Append(" nmanejo, ")
        strSQL.Append(" nseguro, ")
        strSQL.Append(" ccodlin, ")
        strSQL.Append(" ccodpre, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" dfecsis, ")
        strSQL.Append(" dfecpro, niva ")
        strSQL.Append(" FROM CremRef ")

    End Sub

    Public Function ObtenerDataSetEsp1(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT Climide.ccodcli, Climide.cNomCli, Cretlin.cCodlin ")
        strSQL.Append(" FROM climide INNER JOIN Cremcre")
        strSQL.Append(" ON Climide.ccodcli = Cremcre.ccodcli")
        strSQL.Append(" INNER JOIN CRETLIN ")
        strSQL.Append(" ON Cremcre.cnrolin = cretlin.cnrolin")
        strSQL.Append(" where Cremcre.ccodcta =" & "'" & cCodigo & "'")

        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds

    End Function

    Public Function ObtenerDataSetEsp2(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta, cCodpre, cCodlin, nsalcap, nsalint, nsalmor, nmanejo, nseguro, niva ")
        strSQL.Append(" FROM cremref  ")
        strSQL.Append(" where ccodpre =" & "'" & cCodigo & "'")


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function
    Public Function ObtenerDataSetEsp3(ByVal cCodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cCodcta, cCodpre, cCodlin, nsalcap, nsalint, nsalmor, nmanejo, nseguro, niva ")
        strSQL.Append(" FROM cremref  ")
        strSQL.Append(" where ccodpre =" & "'" & cCodigo & "'")


        Dim ds As DataSet

        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function


    Public Function Extra_Detalle_Cancelaciones(ByVal pcCodcta As String, ByVal pdfecha As Date) As DataTable

        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim conexion As String = Me.cnnStr
        Dim ldfectran As String = pdfecha.ToString("yyyy/dd/MM")
        Dim ds As New DataSet


        Using connection As New SqlConnection(conexion)
            connection.Open()

            command.Connection = connection

            Try


                command.CommandText = _
                                        " Select B.cCodcta, B.nsalcap, b.nsalint, b.nsalmor, b.nseguro, b.ntotal FROM CREMCRE A " & _
                                        " Inner Join CREMREF B" & _
                                        " ON A.CCODCTA = B.CCODPRE " & _
                                        " Where B.CCODPRE = '" & pcCodcta & "' " & _
                                        " and DFECSIS = '" & ldfectran & "'"

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds, "Detalle_Cancela")



            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds.Tables("Detalle_Cancela")

    End Function
End Class
