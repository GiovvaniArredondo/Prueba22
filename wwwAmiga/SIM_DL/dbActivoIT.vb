Imports System.Text
Public Class dbActivoIT
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As EL.entidadBase) As Integer
        Dim lEntidad As ActivoIT
        Dim strSql As New StringBuilder
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodinv = "" _
            Or lEntidad.ccodinv = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodinv = lID

            Return Agregar(lEntidad)
        End If

        lEntidad = aEntidad
        strSql.Append("Update ActivoIT ")
        strSql.Append(" set ccodinv=@ccodinv, ")
        strSql.Append(" cnserie=@cnserie, ")
        strSql.Append(" cmodelo=@cmodelo, ")
        strSql.Append(" ccodmar=@ccodmar, ")
        strSql.Append(" ccodlin=@ccodlin, ")
        strSql.Append(" cnlicen=@cnlicen, ")
        strSql.Append(" cusulog=@cusulog, ")
        strSql.Append(" cpaslog=@cpaslog, ")
        strSql.Append(" cpasint=@cpasint, ")
        strSql.Append(" cdetall=@cdetall, ")
        strSql.Append(" dfecmod=@dfecmod, ")
        strSql.Append(" ccodusu=@ccodusu ")
        strSql.Append(" Where ccodinv=@ccodinv ")


        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv
        args(1) = New SqlParameter("@cnserie", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnserie
        args(2) = New SqlParameter("@cmodelo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cmodelo
        args(3) = New SqlParameter("@ccodmar", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodmar
        args(4) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodlin
        args(5) = New SqlParameter("@cnlicen", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnlicen
        args(6) = New SqlParameter("@cusulog", SqlDbType.VarChar)
        args(6).Value = lEntidad.cusulog
        args(7) = New SqlParameter("@cpaslog", SqlDbType.VarChar)
        args(7).Value = lEntidad.cpaslog
        args(8) = New SqlParameter("@cpasint", SqlDbType.VarChar)
        args(8).Value = lEntidad.cpasint
        args(9) = New SqlParameter("@cdetall", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdetall
        args(10) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSql.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As EL.entidadBase) As Integer
        Dim lEntidad As ActivoIT
        Dim strSql As New StringBuilder

        lEntidad = aEntidad

        strSql.Append("INSERT INTO ActivoIT ")
        strSql.Append(" ( ccodinv, ")
        strSql.Append(" cnserie, ")
        strSql.Append(" cmodelo, ")
        strSql.Append(" ccodmar, ")
        strSql.Append(" ccodlin, ")
        strSql.Append(" cnlicen, ")
        strSql.Append(" cusulog, ")
        strSql.Append(" cpaslog, ")
        strSql.Append(" cpasint, ")
        strSql.Append(" cdetall, ")
        strSql.Append(" dfecmod, ")
        strSql.Append(" ccodusu) ")

        strSql.Append(" VALUES ")
        strSql.Append(" ( @ccodinv, ")
        strSql.Append(" @cnserie, ")
        strSql.Append(" @cmodelo, ")
        strSql.Append(" @ccodmar, ")
        strSql.Append(" @ccodlin, ")
        strSql.Append(" @cnlicen, ")
        strSql.Append(" @cusulog, ")
        strSql.Append(" @cpaslog, ")
        strSql.Append(" @cpasint, ")
        strSql.Append(" @cdetall, ")
        strSql.Append(" @dfecmod, ")
        strSql.Append(" @ccodusu) ")

        Dim args(11) As SqlParameter

        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv
        args(1) = New SqlParameter("@cnserie", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnserie
        args(2) = New SqlParameter("@cmodelo", SqlDbType.VarChar)
        args(2).Value = lEntidad.cmodelo
        args(3) = New SqlParameter("@ccodmar", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodmar
        args(4) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodlin
        args(5) = New SqlParameter("@cnlicen", SqlDbType.VarChar)
        args(5).Value = lEntidad.cnlicen
        args(6) = New SqlParameter("@cusulog", SqlDbType.VarChar)
        args(6).Value = lEntidad.cusulog
        args(7) = New SqlParameter("@cpaslog", SqlDbType.VarChar)
        args(7).Value = lEntidad.cpaslog
        args(8) = New SqlParameter("@cpasint", SqlDbType.VarChar)
        args(8).Value = lEntidad.cpasint
        args(9) = New SqlParameter("@cdetall", SqlDbType.VarChar)
        args(9).Value = lEntidad.cdetall
        args(10) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(10).Value = lEntidad.dfecmod
        args(11) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(11).Value = lEntidad.ccodusu

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSql.ToString(), args)
    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As EL.entidadBase) As Long

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As EL.entidadBase) As Integer
        Dim lEntidad As New ActivoIT
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        strSQL.Append(" WHERE ccodinv = @ccodinv ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv

        Dim dsDatos As New DataSet
        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodinv = IIf(.Item("ccodinv") Is DBNull.Value, Nothing, .Item("ccodinv"))
                lEntidad.cnserie = IIf(.Item("cnserie") Is DBNull.Value, Nothing, .Item("cnserie"))
                lEntidad.cmodelo = IIf(.Item("cmodelo") Is DBNull.Value, Nothing, .Item("cmodelo"))
                lEntidad.ccodmar = IIf(.Item("ccodmar") Is DBNull.Value, Nothing, .Item("ccodmar"))
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.cnlicen = IIf(.Item("cnlicen") Is DBNull.Value, Nothing, .Item("cnlicen"))
                lEntidad.cusulog = IIf(.Item("cusulog") Is DBNull.Value, Nothing, .Item("cusulog"))
                lEntidad.cpaslog = IIf(.Item("cpaslog") Is DBNull.Value, Nothing, .Item("cpaslog"))
                lEntidad.cpasint = IIf(.Item("cpasint") Is DBNull.Value, Nothing, .Item("cpasint"))
                lEntidad.cdetall = IIf(.Item("cdetall") Is DBNull.Value, Nothing, .Item("cdetall"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
            End With
        Catch ex As Exception
            Throw ex
        End Try
        Return 1
    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT * ")
        strSQL.Append(" FROM ActivoIT ")
    End Sub
End Class
