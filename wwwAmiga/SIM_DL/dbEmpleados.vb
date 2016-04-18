Imports System.Text
Public Class dbEmpleados
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As empleados
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.id =  "" _
            Or lEntidad.id = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.id = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE empleados ")
        strSQL.Append(" SET cnomemp = @cnomemp, ") 
        strSQL.Append(" cdui = @cdui, ") 
        strSQL.Append(" ccargo = @ccargo, ") 
        strSQL.Append(" cdepto = @cdepto ") 
        strSQL.Append(" cafp = @cafp, ") 
        strSQL.Append(" nsalario = @nsalario, ") 
        strSQL.Append(" WHERE id = @id ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@cnomemp", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomemp
        args(1) = New SqlParameter("@cdui", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdui
        args(2) = New SqlParameter("@ccargo", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccargo
        args(3) = New SqlParameter("@cdepto", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdepto
        args(4) = New SqlParameter("@cafp", SqlDbType.VarChar)
        args(4).Value = lEntidad.cafp
        args(5) = New SqlParameter("@nsalario", SqlDbType.VarChar)
        args(5).Value = lEntidad.nsalario
        args(6) = New SqlParameter("@id", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.id = Nothing, DBNull.Value,lEntidad.id)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As empleados
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO empleados ")
        strSQL.Append(" ( id, ") 
        strSQL.Append(" cnomemp, ") 
        strSQL.Append(" cdui, ") 
        strSQL.Append(" ccargo, ") 
        strSQL.Append(" cdepto) ") 
        strSQL.Append(" cafp, ") 
        strSQL.Append(" nsalario, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @id, ") 
        strSQL.Append(" @cnomemp, ") 
        strSQL.Append(" @cdui, ") 
        strSQL.Append(" @ccargo, ") 
        strSQL.Append(" @cdepto) ") 
        strSQL.Append(" @cafp, ") 
        strSQL.Append(" @nsalario, ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@id", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.id = Nothing, DBNull.Value, lEntidad.id)
        args(1) = New SqlParameter("@cnomemp", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomemp
        args(2) = New SqlParameter("@cdui", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdui
        args(3) = New SqlParameter("@ccargo", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccargo
        args(4) = New SqlParameter("@cdepto", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdepto
        args(5) = New SqlParameter("@cafp", SqlDbType.VarChar)
        args(5).Value = lEntidad.cafp
        args(6) = New SqlParameter("@nsalario", SqlDbType.VarChar)
        args(6).Value = lEntidad.nsalario

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As empleados
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM empleados ")
        strSQL.Append(" WHERE id = @id ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@id", SqlDbType.VarChar)
        args(0).Value = lEntidad.id

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As empleados
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE id = @id ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@id", SqlDbType.VarChar)
        args(0).Value = lEntidad.id

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomemp = IIf(.Item("cnomemp") Is DBNull.Value, Nothing, .Item("cnomemp"))
                lEntidad.cdui = IIf(.Item("cdui") Is DBNull.Value, Nothing, .Item("cdui"))
                lEntidad.ccargo = IIf(.Item("ccargo") Is DBNull.Value, Nothing, .Item("ccargo"))
                lEntidad.cdepto = IIf(.Item("cdepto") Is DBNull.Value, Nothing, .Item("cdepto"))
                lEntidad.cafp = IIf(.Item("cafp") Is DBNull.Value, Nothing, .Item("cafp"))
                lEntidad.nsalario = IIf(.Item("nsalario") Is DBNull.Value, Nothing, .Item("nsalario"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As empleados
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(id),0) + 1 ")
        strSQL.Append(" FROM empleados ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaempleados

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaempleados

        Try
            Do While dr.Read()
                Dim mEntidad As New empleados
                mEntidad.id = IIf(dr("id") Is DBNull.Value, Nothing, dr("id"))
                mEntidad.cnomemp = IIf(dr("cnomemp") Is DBNull.Value, Nothing, dr("cnomemp"))
                mEntidad.cdui = IIf(dr("cdui") Is DBNull.Value, Nothing, dr("cdui"))
                mEntidad.ccargo = IIf(dr("ccargo") Is DBNull.Value, Nothing, dr("ccargo"))
                mEntidad.cdepto = IIf(dr("cdepto") Is DBNull.Value, Nothing, dr("cdepto"))
                mEntidad.cafp = IIf(dr("cafp") Is DBNull.Value, Nothing, dr("cafp"))
                mEntidad.nsalario = IIf(dr("nsalario") Is DBNull.Value, Nothing, dr("nsalario"))
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
        tables(0) = New String("empleados")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT id, ") 
        strSQL.Append(" cnomemp, ") 
        strSQL.Append(" cdui, ") 
        strSQL.Append(" ccargo, ") 
        strSQL.Append(" cdepto, ") 
        strSQL.Append(" cafp, ") 
        strSQL.Append(" nsalario,  nComision, nboni, 000000.00 as  ntotal, notros, ncelular ")
        strSQL.Append(" FROM empleados ")

    End Sub

    Public Function ObtenerDataSetPorID1(ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE Id = @ccodigo")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = ccodigo

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function Actualizar1(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As empleados
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.id = "" _
            Or lEntidad.id = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.id = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE empleados ")
        strSQL.Append(" SET ncomision = @ncomision, notros = @notros, ncelular = @ncelular, nboni = @nbonificacion ")
        strSQL.Append(" WHERE id = @id ")

        Dim args(4) As SqlParameter

        args(0) = New SqlParameter("@ncomision", SqlDbType.Decimal)
        args(0).Value = lEntidad.ncomision
        args(1) = New SqlParameter("@id", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.id = Nothing, DBNull.Value, lEntidad.id)
        args(2) = New SqlParameter("@notros", SqlDbType.Decimal)
        args(2).Value = lEntidad.notros
        args(3) = New SqlParameter("@ncelular", SqlDbType.Decimal)
        args(3).Value = lEntidad.ncelular
        args(4) = New SqlParameter("@nbonificacion", SqlDbType.Decimal)
        args(4).Value = lEntidad.nbonificacion

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function VerificaHistorico(ByVal ccodigo As String) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("Select name from sysobjects WHERE name = @ccodigo and type = 'U'")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = ccodigo

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If

    End Function

    Public Function CreaTablaHistorica(ByVal ccodigo As String) As Integer

        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Try
            Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
            Dim oCommand As SqlClient.SqlCommand = _
                    New SqlClient.SqlCommand("GuardaPlanilla", oConexion)
            Dim oParameter As SqlClient.SqlParameter
            oParameter = oCommand.Parameters.Add("@nombretabla", SqlDbType.VarChar)
            oParameter.Value = ccodigo
            


            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New DataSet
            oDa.Fill(oDs)

            oDs.Dispose()
            oDa.Dispose()
            oCommand.Dispose()
            oConexion.Close()
            oConexion.Dispose()
            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function


    Public Function InsertaTablaHistorica(ByVal ccodigo As String, ByVal id As String, ByVal ncomision As Double, _
    ByVal nsueldo As Double, ByVal nisss As Double, ByVal nafp As Double, ByVal nisr As Double, _
    ByVal nissspat As Double, ByVal nafppat As Double, ByVal ntotal As Double, ByVal verifica As Integer, ByVal notros As Double, ByVal ncelular As Double, ByVal nboni As Double) As Integer
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Try
            Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)

            Dim oCommand As SqlClient.SqlCommand = _
                            New SqlClient.SqlCommand(IIf(verifica = 0, "InsertaPlanilla", "ModificaPlanilla"), oConexion)


            Dim oParameter As SqlClient.SqlParameter

            oParameter = oCommand.Parameters.Add("@nombretabla", SqlDbType.VarChar)
            oParameter.Value = ccodigo
            oParameter = oCommand.Parameters.Add("@id1", SqlDbType.VarChar)
            oParameter.Value = id
            oParameter = oCommand.Parameters.Add("@ncomision1", SqlDbType.Decimal)
            oParameter.Value = ncomision
            oParameter = oCommand.Parameters.Add("@nsueldo1", SqlDbType.Decimal)
            oParameter.Value = nsueldo
            oParameter = oCommand.Parameters.Add("@ntotal1", SqlDbType.Decimal)
            oParameter.Value = ntotal
            oParameter = oCommand.Parameters.Add("@nisss1", SqlDbType.Decimal)
            oParameter.Value = nisss
            oParameter = oCommand.Parameters.Add("@nafp1", SqlDbType.Decimal)
            oParameter.Value = nafp
            oParameter = oCommand.Parameters.Add("@nisr1", SqlDbType.Decimal)
            oParameter.Value = nisr
            oParameter = oCommand.Parameters.Add("@nissspat1", SqlDbType.Decimal)
            oParameter.Value = nissspat
            oParameter = oCommand.Parameters.Add("@nafppat1", SqlDbType.Decimal)
            oParameter.Value = nafppat
            oParameter = oCommand.Parameters.Add("@notros1", SqlDbType.Decimal)
            oParameter.Value = notros
            oParameter = oCommand.Parameters.Add("@ncelular1", SqlDbType.Decimal)
            oParameter.Value = ncelular
            oParameter = oCommand.Parameters.Add("@nboni1", SqlDbType.Decimal)
            oParameter.Value = nboni

            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New DataSet
            oDa.Fill(oDs)

            oDs.Dispose()
            oDa.Dispose()
            oCommand.Dispose()
            oConexion.Close()
            oConexion.Dispose()
            Return 1

        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function Planilla(ByVal ccodigo As String) As DataSet
        Dim oDa As SqlClient.SqlDataAdapter
        Dim oDs As System.Data.DataSet

        Try
            Dim oConexion As SqlClient.SqlConnection = New SqlConnection(Me.cnnStr)
            Dim oCommand As SqlClient.SqlCommand = _
                    New SqlClient.SqlCommand("SelectPlanilla", oConexion)
            Dim oParameter As SqlClient.SqlParameter
            oParameter = oCommand.Parameters.Add("@nombretabla", SqlDbType.VarChar)
            oParameter.Value = ccodigo



            oCommand.CommandType = CommandType.StoredProcedure
            oConexion.Open()
            oDa = New SqlClient.SqlDataAdapter(oCommand)
            oDs = New DataSet
            oDa.Fill(oDs)

            oDs.Dispose()
            oDa.Dispose()
            oCommand.Dispose()
            oConexion.Close()
            oConexion.Dispose()

            Return oDs

        Catch ex As Exception

        End Try

    End Function
    Public Function Ctrl_Planilla(ByVal dfeccnt As Date, ByVal ccodusu As String, ByVal dfecsis As Date, ByVal cestado As String) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ctrlplan(dfeccnt, ccodusu, dfecsis, cestado) values( ")
        strSQL.Append(" @dfeccnt, @ccodusu, @dfecsis, @cestado) ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfeccnt", SqlDbType.DateTime)
        args(0).Value = dfeccnt
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@dfecsis", SqlDbType.DateTime)
        args(2).Value = dfecsis
        args(3) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(3).Value = cestado


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function Ver_Planilla(ByVal dfeccnt As Date) As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("select dfeccnt from  ctrlplan where dfeccnt = @dfeccnt and cestado = ' '")


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@dfeccnt", SqlDbType.DateTime)
        args(0).Value = dfeccnt

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class
