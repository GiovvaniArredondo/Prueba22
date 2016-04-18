Imports System.Text
Public Class dbPersonal
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As personal
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.idempleado =  0 _
            Or lEntidad.idempleado = Nothing Then 

            'lID = Me.ObtenerID(lEntidad)

            'If lID = -1 Then Return -1

            'lEntidad.idempleado = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE personal ")
        strSQL.Append(" SET nombre = @nombre, ") 
        strSQL.Append(" email = @email, ") 
        strSQL.Append(" tel = @tel, ") 
        strSQL.Append(" cel = @cel, ") 
        strSQL.Append(" reglon = @reglon, ") 
        strSQL.Append(" contrato = @contrato, ") 
        strSQL.Append(" idPuestoNominal = @idPuestoNominal, ") 
        strSQL.Append(" idpuestoFuncional = @idpuestoFuncional, ") 
        strSQL.Append(" idprofesion = @idprofesion, ") 
        strSQL.Append(" idarea = @idarea, ") 
        strSQL.Append(" iddependencia = @iddependencia, ") 
        strSQL.Append(" idsede = @idsede, ") 
        strSQL.Append(" libre = @libre ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" foto = @foto, ") 
        strSQL.Append(" WHERE idempleado = @idempleado ") 

        Dim args(13) As SqlParameter
        args(0) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(0).Value = lEntidad.nombre
        args(1) = New SqlParameter("@email", SqlDbType.VarChar)
        args(1).Value = lEntidad.email
        args(2) = New SqlParameter("@tel", SqlDbType.VarChar)
        args(2).Value = lEntidad.tel
        args(3) = New SqlParameter("@cel", SqlDbType.VarChar)
        args(3).Value = lEntidad.cel
        args(4) = New SqlParameter("@reglon", SqlDbType.VarChar)
        args(4).Value = lEntidad.reglon
        args(5) = New SqlParameter("@contrato", SqlDbType.VarChar)
        args(5).Value = lEntidad.contrato
        args(6) = New SqlParameter("@idPuestoNominal", SqlDbType.Int)
        args(6).Value = IIf(lEntidad.idPuestoNominal = Nothing, DBNull.Value, lEntidad.idPuestoNominal)
        args(7) = New SqlParameter("@idpuestoFuncional", SqlDbType.Int)
        args(7).Value = IIf(lEntidad.idpuestoFuncional = Nothing, DBNull.Value, lEntidad.idpuestoFuncional)
        args(8) = New SqlParameter("@idprofesion", SqlDbType.Int)
        args(8).Value = IIf(lEntidad.idprofesion = Nothing, DBNull.Value, lEntidad.idprofesion)
        args(9) = New SqlParameter("@idarea", SqlDbType.Int)
        args(9).Value = IIf(lEntidad.idarea = Nothing, DBNull.Value, lEntidad.idarea)
        args(10) = New SqlParameter("@iddependencia", SqlDbType.Int)
        args(10).Value = IIf(lEntidad.iddependencia = Nothing, DBNull.Value, lEntidad.iddependencia)
        args(11) = New SqlParameter("@idsede", SqlDbType.Int)
        args(11).Value = IIf(lEntidad.idsede = Nothing, DBNull.Value, lEntidad.idsede)
        args(12) = New SqlParameter("@libre", SqlDbType.VarChar)
        args(12).Value = lEntidad.libre
        args(13) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(13).Value = IIf(lEntidad.dfecmod = Nothing, DBNull.Value, lEntidad.dfecmod)
        args(14) = New SqlParameter("@foto", SqlDbType.image)
        args(14).Value = lEntidad.foto
        args(15) = New SqlParameter("@idempleado", SqlDbType.Int)
        args(15).Value = IIf(lEntidad.idempleado = Nothing, DBNull.Value,lEntidad.idempleado)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As personal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO personal ")
        strSQL.Append(" ( ")
        strSQL.Append(" nombre, ") 
        strSQL.Append(" email, ") 
        strSQL.Append(" tel, ") 
        strSQL.Append(" cel, ") 
        strSQL.Append(" reglon, ") 
        strSQL.Append(" contrato, ") 
        strSQL.Append(" idPuestoNominal, ") 
        strSQL.Append(" idpuestoFuncional, ") 
        strSQL.Append(" idprofesion, ") 
        strSQL.Append(" idarea, ") 
        strSQL.Append(" iddependencia, ") 
        strSQL.Append(" idsede, ") 
        strSQL.Append(" foto) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( ")
        strSQL.Append(" @nombre, ") 
        strSQL.Append(" @email, ") 
        strSQL.Append(" @tel, ") 
        strSQL.Append(" @cel, ") 
        strSQL.Append(" @reglon, ") 
        strSQL.Append(" @contrato, ") 
        strSQL.Append(" @idPuestoNominal, ") 
        strSQL.Append(" @idpuestoFuncional, ") 
        strSQL.Append(" @idprofesion, ") 
        strSQL.Append(" @idarea, ") 
        strSQL.Append(" @iddependencia, ") 
        strSQL.Append(" @idsede, ") 
        strSQL.Append(" @foto) ")

        Dim args(15) As SqlParameter
        'args(0) = New SqlParameter("@idempleado", SqlDbType.Int)
        'args(0).Value = IIf(lEntidad.idempleado = Nothing, DBNull.Value, lEntidad.idempleado)
        args(1) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(1).Value = lEntidad.nombre
        args(2) = New SqlParameter("@email", SqlDbType.VarChar)
        args(2).Value = lEntidad.email
        args(3) = New SqlParameter("@tel", SqlDbType.VarChar)
        args(3).Value = lEntidad.tel
        args(4) = New SqlParameter("@cel", SqlDbType.VarChar)
        args(4).Value = lEntidad.cel
        args(5) = New SqlParameter("@reglon", SqlDbType.VarChar)
        args(5).Value = lEntidad.reglon
        args(6) = New SqlParameter("@contrato", SqlDbType.VarChar)
        args(6).Value = lEntidad.contrato
        args(7) = New SqlParameter("@idPuestoNominal", SqlDbType.Int)
        args(7).Value = IIf(lEntidad.idPuestoNominal = Nothing, DBNull.Value, lEntidad.idPuestoNominal)
        args(8) = New SqlParameter("@idpuestoFuncional", SqlDbType.Int)
        args(8).Value = IIf(lEntidad.idpuestoFuncional = Nothing, DBNull.Value, lEntidad.idpuestoFuncional)
        args(9) = New SqlParameter("@idprofesion", SqlDbType.Int)
        args(9).Value = IIf(lEntidad.idprofesion = Nothing, DBNull.Value, lEntidad.idprofesion)
        args(10) = New SqlParameter("@idarea", SqlDbType.Int)
        args(10).Value = IIf(lEntidad.idarea = Nothing, DBNull.Value, lEntidad.idarea)
        args(11) = New SqlParameter("@iddependencia", SqlDbType.Int)
        args(11).Value = IIf(lEntidad.iddependencia = Nothing, DBNull.Value, lEntidad.iddependencia)
        args(12) = New SqlParameter("@idsede", SqlDbType.Int)
        args(12).Value = IIf(lEntidad.idsede = Nothing, DBNull.Value, lEntidad.idsede)
        args(15) = New SqlParameter("@foto", SqlDbType.Image)
        args(15).Value = lEntidad.foto

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As personal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM personal ")
        strSQL.Append(" WHERE idempleado = @idempleado ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idempleado", SqlDbType.Int)
        args(0).Value = lEntidad.idempleado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As personal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idempleado = @idempleado ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idempleado", SqlDbType.Int)
        args(0).Value = lEntidad.idempleado

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.email = IIf(.Item("email") Is DBNull.Value, Nothing, .Item("email"))
                lEntidad.tel = IIf(.Item("tel") Is DBNull.Value, Nothing, .Item("tel"))
                lEntidad.cel = IIf(.Item("cel") Is DBNull.Value, Nothing, .Item("cel"))
                lEntidad.reglon = IIf(.Item("reglon") Is DBNull.Value, Nothing, .Item("reglon"))
                lEntidad.contrato = IIf(.Item("contrato") Is DBNull.Value, Nothing, .Item("contrato"))
                lEntidad.idPuestoNominal = IIf(.Item("idPuestoNominal") Is DBNull.Value, Nothing, .Item("idPuestoNominal"))
                lEntidad.idpuestoFuncional = IIf(.Item("idpuestoFuncional") Is DBNull.Value, Nothing, .Item("idpuestoFuncional"))
                lEntidad.idprofesion = IIf(.Item("idprofesion") Is DBNull.Value, Nothing, .Item("idprofesion"))
                lEntidad.idarea = IIf(.Item("idarea") Is DBNull.Value, Nothing, .Item("idarea"))
                lEntidad.iddependencia = IIf(.Item("iddependencia") Is DBNull.Value, Nothing, .Item("iddependencia"))
                lEntidad.idsede = IIf(.Item("idsede") Is DBNull.Value, Nothing, .Item("idsede"))
                lEntidad.libre = IIf(.Item("libre") Is DBNull.Value, Nothing, .Item("libre"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.foto = IIf(.Item("foto") Is DBNull.Value, Nothing, .Item("foto"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As personal
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idempleado),0) + 1 ")
        strSQL.Append(" FROM personal ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    'Public Function ObtenerListaPorID() As listapersonal

    '    Dim strSQL As New StringBuilder
    '    SelectTabla(strSQL)

    '    Dim dr As SqlDataReader

    '    dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

    '    Dim lista As New Listapersonal

    '    Try
    '        Do While dr.Read()
    '            Dim mEntidad As New personal
    '            mEntidad.idempleado = IIf(dr("idempleado") Is DBNull.Value, Nothing, dr("idempleado"))
    '            mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
    '            mEntidad.email = IIf(dr("email") Is DBNull.Value, Nothing, dr("email"))
    '            mEntidad.tel = IIf(dr("tel") Is DBNull.Value, Nothing, dr("tel"))
    '            mEntidad.cel = IIf(dr("cel") Is DBNull.Value, Nothing, dr("cel"))
    '            mEntidad.reglon = IIf(dr("reglon") Is DBNull.Value, Nothing, dr("reglon"))
    '            mEntidad.contrato = IIf(dr("contrato") Is DBNull.Value, Nothing, dr("contrato"))
    '            mEntidad.idPuestoNominal = IIf(dr("idPuestoNominal") Is DBNull.Value, Nothing, dr("idPuestoNominal"))
    '            mEntidad.idpuestoFuncional = IIf(dr("idpuestoFuncional") Is DBNull.Value, Nothing, dr("idpuestoFuncional"))
    '            mEntidad.idprofesion = IIf(dr("idprofesion") Is DBNull.Value, Nothing, dr("idprofesion"))
    '            mEntidad.idarea = IIf(dr("idarea") Is DBNull.Value, Nothing, dr("idarea"))
    '            mEntidad.iddependencia = IIf(dr("iddependencia") Is DBNull.Value, Nothing, dr("iddependencia"))
    '            mEntidad.idsede = IIf(dr("idsede") Is DBNull.Value, Nothing, dr("idsede"))
    '            mEntidad.libre = IIf(dr("libre") Is DBNull.Value, Nothing, dr("libre"))
    '            mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
    '            mEntidad.foto = IIf(dr("foto") Is DBNull.Value, Nothing, dr("foto"))
    '            lista.Add(mEntidad)
    '        Loop
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        dr.Close()
    '    End Try

    '    Return lista

    'End Function

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
        tables(0) = New String("personal")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT idempleado, ") 
        strSQL.Append(" nombre, ") 
        strSQL.Append(" email, ") 
        strSQL.Append(" tel, ") 
        strSQL.Append(" cel, ") 
        strSQL.Append(" reglon, ") 
        strSQL.Append(" contrato, ") 
        strSQL.Append(" idPuestoNominal, ") 
        strSQL.Append(" idpuestoFuncional, ") 
        strSQL.Append(" idprofesion, ") 
        strSQL.Append(" idarea, ") 
        strSQL.Append(" iddependencia, ") 
        strSQL.Append(" idsede, ") 
        strSQL.Append(" libre, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" foto ") 
        strSQL.Append(" FROM personal ")

    End Sub

End Class
