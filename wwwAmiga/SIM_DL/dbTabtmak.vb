Imports System.Text
Public Class dbTabtmak
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtmak
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodigo =  "" _
            Or lEntidad.ccodigo = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodigo = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtmak ")
        strSQL.Append(" SET ccodapl = @ccodapl, ") 
        strSQL.Append(" cdebhab = @cdebhab, ") 
        strSQL.Append(" cdescri = @cdescri, ") 
        strSQL.Append(" cplanti = @cplanti, ") 
        strSQL.Append(" cflag = @cflag ") 
        strSQL.Append(" WHERE ccodigo = @ccodigo ") 

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodapl
        args(1) = New SqlParameter("@cdebhab", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdebhab
        args(2) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdescri
        args(3) = New SqlParameter("@cplanti", SqlDbType.VarChar)
        args(3).Value = lEntidad.cplanti
        args(4) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(4).Value = lEntidad.cflag
        args(5) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value,lEntidad.ccodigo)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtmak
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtmak ")
        strSQL.Append(" ( ccodapl, ") 
        strSQL.Append(" ccodigo, ") 
        strSQL.Append(" cdebhab, ") 
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" cplanti, ") 
        strSQL.Append(" cflag) ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodapl, ") 
        strSQL.Append(" @ccodigo, ") 
        strSQL.Append(" @cdebhab, ") 
        strSQL.Append(" @cdescri, ") 
        strSQL.Append(" @cplanti, ") 
        strSQL.Append(" @cflag) ") 

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@ccodapl", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodapl
        args(1) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodigo = Nothing, DBNull.Value, lEntidad.ccodigo)
        args(2) = New SqlParameter("@cdebhab", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdebhab
        args(3) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdescri
        args(4) = New SqlParameter("@cplanti", SqlDbType.VarChar)
        args(4).Value = lEntidad.cplanti
        args(5) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(5).Value = lEntidad.cflag

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtmak
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtmak ")
        strSQL.Append(" WHERE ccodigo = @ccodigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodigo

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtmak
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodigo = @ccodigo ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodigo", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodigo

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodapl = IIf(.Item("ccodapl") Is DBNull.Value, Nothing, .Item("ccodapl"))
                lEntidad.cdebhab = IIf(.Item("cdebhab") Is DBNull.Value, Nothing, .Item("cdebhab"))
                lEntidad.cdescri = IIf(.Item("cdescri") Is DBNull.Value, Nothing, .Item("cdescri"))
                lEntidad.cplanti = IIf(.Item("cplanti") Is DBNull.Value, Nothing, .Item("cplanti"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtmak
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodigo),0) + 1 ")
        strSQL.Append(" FROM tabtmak ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listatabtmak

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listatabtmak

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtmak
                mEntidad.ccodapl = IIf(dr("ccodapl") Is DBNull.Value, Nothing, dr("ccodapl"))
                mEntidad.ccodigo = IIf(dr("ccodigo") Is DBNull.Value, Nothing, dr("ccodigo"))
                mEntidad.cdebhab = IIf(dr("cdebhab") Is DBNull.Value, Nothing, dr("cdebhab"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.cplanti = IIf(dr("cplanti") Is DBNull.Value, Nothing, dr("cplanti"))
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
        tables(0) = New String("tabtmak")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodapl, ") 
        strSQL.Append(" ccodigo, ") 
        strSQL.Append(" cdebhab, ") 
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" cplanti, ") 
        strSQL.Append(" cflag ") 
        strSQL.Append(" FROM tabtmak ")

    End Sub

End Class
