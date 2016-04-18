Imports System.Text
Public Class dbCntaemp
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaemp
        Dim lID As Long
        lEntidad = aEntidad

        
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntaemp ")
        strSQL.Append(" SET cdescri = @cdescri, ") 
        strSQL.Append(" ccodruc = @ccodruc, ") 
        strSQL.Append(" dfecreg = @dfecreg, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" cflc = @cflc, ") 
        strSQL.Append(" nflc = @nflc, ") 
        strSQL.Append(" nporiva = @nporiva, ")
        strSQL.Append(" nporisrs = @nporisrs, ") 
        strSQL.Append(" nporisrb = @nporisrb ")
        strSQL.Append(" WHERE ccodemp = @ccodemp ") 

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(0).Value = lEntidad.cdescri
        args(1) = New SqlParameter("@ccodruc", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodruc
        args(2) = New SqlParameter("@dfecreg", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecreg
        args(3) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(3).Value = lEntidad.dfecmod
        args(4) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodusu
        args(5) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(5).Value = lEntidad.cflc
        args(6) = New SqlParameter("@nflc", SqlDbType.VarChar)
        args(6).Value = lEntidad.nflc
        args(7) = New SqlParameter("@nporiva", SqlDbType.VarChar)
        args(7).Value = lEntidad.nporiva
        args(8) = New SqlParameter("@nporisrs", SqlDbType.VarChar)
        args(8).Value = lEntidad.nporisrs
        args(9) = New SqlParameter("@nporisrb", SqlDbType.VarChar)
        args(9).Value = lEntidad.nporisrb
        args(10) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(10).Value = IIf(lEntidad.ccodemp = Nothing, DBNull.Value,lEntidad.ccodemp)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaemp
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cntaemp ")
        strSQL.Append(" ( ccodemp, ") 
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" ccodruc, ") 
        strSQL.Append(" dfecreg, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" cflc, ") 
        strSQL.Append(" nflc, ") 
        strSQL.Append(" nporiva, ")
        strSQL.Append(" nporisrs, ") 
        strSQL.Append(" nporisrb) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodemp, ") 
        strSQL.Append(" @cdescri, ") 
        strSQL.Append(" @ccodruc, ") 
        strSQL.Append(" @dfecreg, ") 
        strSQL.Append(" @dfecmod, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @cflc, ") 
        strSQL.Append(" @nflc, ") 
        strSQL.Append(" @nporiva, ")
        strSQL.Append(" @nporisrs, ") 
        strSQL.Append(" @nporisrb) ")

        Dim args(10) As SqlParameter
        args(0) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodemp = Nothing, DBNull.Value, lEntidad.ccodemp)
        args(1) = New SqlParameter("@cdescri", SqlDbType.VarChar)
        args(1).Value = lEntidad.cdescri
        args(2) = New SqlParameter("@ccodruc", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodruc
        args(3) = New SqlParameter("@dfecreg", SqlDbType.Datetime)
        args(3).Value = lEntidad.dfecreg
        args(4) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(4).Value = lEntidad.dfecmod
        args(5) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodusu
        args(6) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(6).Value = lEntidad.cflc
        args(7) = New SqlParameter("@nflc", SqlDbType.VarChar)
        args(7).Value = lEntidad.nflc
        args(8) = New SqlParameter("@nporiva", SqlDbType.VarChar)
        args(8).Value = lEntidad.nporiva
        args(9) = New SqlParameter("@nporisrs", SqlDbType.VarChar)
        args(9).Value = lEntidad.nporisrs
        args(10) = New SqlParameter("@nporisrb", SqlDbType.VarChar)
        args(10).Value = lEntidad.nporisrb

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaemp
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cntaemp ")
        strSQL.Append(" WHERE ccodemp = @ccodemp ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodemp

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaemp
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodemp = @ccodemp ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodemp

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cdescri = IIf(.Item("cdescri") Is DBNull.Value, "", .Item("cdescri"))
                lEntidad.ccodruc = IIf(.Item("ccodruc") Is DBNull.Value, "", .Item("ccodruc"))
                lEntidad.dfecreg = IIf(.Item("dfecreg") Is DBNull.Value, Nothing, .Item("dfecreg"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nflc = IIf(.Item("nflc") Is DBNull.Value, Nothing, .Item("nflc"))
                lEntidad.nporiva = IIf(.Item("nporiva") Is DBNull.Value, 0, .Item("nporiva"))
                lEntidad.nporisrs = IIf(.Item("nporisrs") Is DBNull.Value, 0, .Item("nporisrs"))
                lEntidad.nporisrb = IIf(.Item("nporisrb") Is DBNull.Value, 0, .Item("nporisrb"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cntaemp
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodemp),0) + 1 ")
        strSQL.Append(" FROM cntaemp ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacntaemp

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" order by cdescri ")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listacntaemp

        Try
            Do While dr.Read()
                Dim mEntidad As New cntaemp
                mEntidad.ccodemp = IIf(dr("ccodemp") Is DBNull.Value, Nothing, dr("ccodemp"))
                mEntidad.cdescri = IIf(dr("cdescri") Is DBNull.Value, Nothing, dr("cdescri"))
                mEntidad.ccodruc = IIf(dr("ccodruc") Is DBNull.Value, Nothing, dr("ccodruc"))
                mEntidad.dfecreg = IIf(dr("dfecreg") Is DBNull.Value, Nothing, dr("dfecreg"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nflc = IIf(dr("nflc") Is DBNull.Value, Nothing, dr("nflc"))
                mEntidad.nporiva = IIf(dr("nporiva") Is DBNull.Value, Nothing, dr("nporiva"))
                mEntidad.nporisrs = IIf(dr("nporisrs") Is DBNull.Value, Nothing, dr("nporisrs"))
                mEntidad.nporisrb = IIf(dr("nporisrb") Is DBNull.Value, Nothing, dr("nporisrb"))
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
        tables(0) = New String("cntaemp")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT rtrim(ltrim(ccodemp)) as ccodemp, ")
        strSQL.Append(" cdescri, ") 
        strSQL.Append(" ccodruc, ") 
        strSQL.Append(" dfecreg, ") 
        strSQL.Append(" dfecmod, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" cflc, ") 
        strSQL.Append(" nflc, ") 
        strSQL.Append(" nporiva, ") 
        strSQL.Append(" nporisrs, ") 
        strSQL.Append(" nporisrb ") 
        strSQL.Append(" FROM cntaemp ")

    End Sub

    Public Function Nuevo(ByVal ccodemp As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select ccodemp from cntaemp where ccodemp = @ccodemp ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodemp", ccodemp)

        Dim ds As DataSet
        Dim lprocede As Boolean = True

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then

        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodemp")) Then
            Else
                lprocede = False
            End If
        End If

        Return lprocede
    End Function

    Public Function ObtenerProveedores() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from cntaemp order by ccodemp ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function
    
End Class
