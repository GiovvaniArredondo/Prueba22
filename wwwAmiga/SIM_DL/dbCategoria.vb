Imports System.Text
Public Class dbCategoria
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Categoria
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cCatego =  "" _
            Or lEntidad.cCatego = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cCatego = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE Categoria ")
        strSQL.Append(" SET Limite = @Limite, ")
        strSQL.Append(" limite2 = @limite2, ")
        strSQL.Append(" nNumCre = @nNumCre, ") 
        strSQL.Append(" nSalCre = @nSalCre ") 
        strSQL.Append(" nCarAfe = @nCarAfe, ") 
        strSQL.Append(" nSalMora = @nSalMora, ") 
        strSQL.Append(" WHERE cCatego = @cCatego ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@Limite", SqlDbType.Int)
        args(0).Value = lEntidad.Limite
        args(1) = New SqlParameter("@Limite2", SqlDbType.Int)
        args(1).Value = lEntidad.Limite2
        args(2) = New SqlParameter("@nNumCre", SqlDbType.Int)
        args(2).Value = lEntidad.nNumCre
        args(3) = New SqlParameter("@nSalCre", SqlDbType.VarChar)
        args(3).Value = lEntidad.nSalCre
        args(4) = New SqlParameter("@nCarAfe", SqlDbType.VarChar)
        args(4).Value = lEntidad.nCarAfe
        args(5) = New SqlParameter("@nSalMora", SqlDbType.VarChar)
        args(5).Value = lEntidad.nSalMora
        args(6) = New SqlParameter("@cCatego", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.cCatego = Nothing, DBNull.Value, lEntidad.cCatego)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Categoria
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO Categoria ")
        strSQL.Append(" ( cCatego, ") 
        strSQL.Append(" Limite, ")
        strSQL.Append(" Limite2, ")
        strSQL.Append(" nNumCre, ") 
        strSQL.Append(" nSalCre) ") 
        strSQL.Append(" nCarAfe, ") 
        strSQL.Append(" nSalMora, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cCatego, ") 
        strSQL.Append(" @Limite, ") 
        strSQL.Append(" @nNumCre, ") 
        strSQL.Append(" @nSalCre) ") 
        strSQL.Append(" @nCarAfe, ") 
        strSQL.Append(" @nSalMora, ") 

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@cCatego", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cCatego = Nothing, DBNull.Value, lEntidad.cCatego)
        args(1) = New SqlParameter("@Limite", SqlDbType.Int)
        args(1).Value = lEntidad.Limite
        args(2) = New SqlParameter("@Limite2", SqlDbType.Int)
        args(2).Value = lEntidad.Limite2
        args(3) = New SqlParameter("@nNumCre", SqlDbType.Int)
        args(3).Value = lEntidad.nNumCre
        args(4) = New SqlParameter("@nSalCre", SqlDbType.VarChar)
        args(4).Value = lEntidad.nSalCre
        args(5) = New SqlParameter("@nCarAfe", SqlDbType.VarChar)
        args(5).Value = lEntidad.nCarAfe
        args(6) = New SqlParameter("@nSalMora", SqlDbType.VarChar)
        args(6).Value = lEntidad.nSalMora

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Categoria
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM Categoria ")
        strSQL.Append(" WHERE cCatego = @cCatego ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCatego", SqlDbType.VarChar)
        args(0).Value = lEntidad.cCatego

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As Categoria
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCatego = @cCatego ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cCatego", SqlDbType.VarChar)
        args(0).Value = lEntidad.cCatego

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.Limite = IIf(.Item("Limite") Is DBNull.Value, Nothing, .Item("Limite"))
                lEntidad.Limite2 = IIf(.Item("Limite2") Is DBNull.Value, Nothing, .Item("Limite2"))
                lEntidad.nNumCre = IIf(.Item("nNumCre") Is DBNull.Value, Nothing, .Item("nNumCre"))
                lEntidad.nSalCre = IIf(.Item("nSalCre") Is DBNull.Value, Nothing, .Item("nSalCre"))
                lEntidad.nCarAfe = IIf(.Item("nCarAfe") Is DBNull.Value, Nothing, .Item("nCarAfe"))
                lEntidad.nSalMora = IIf(.Item("nSalMora") Is DBNull.Value, Nothing, .Item("nSalMora"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As Categoria
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cCatego),0) + 1 ")
        strSQL.Append(" FROM Categoria ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaCategoria

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New ListaCategoria

        Try
            Do While dr.Read()
                Dim mEntidad As New Categoria
                mEntidad.cCatego = IIf(dr("cCatego") Is DBNull.Value, Nothing, dr("cCatego"))
                mEntidad.Limite = IIf(dr("Limite") Is DBNull.Value, Nothing, dr("Limite"))
                mEntidad.Limite2 = IIf(dr("Limite2") Is DBNull.Value, Nothing, dr("Limite2"))
                mEntidad.nNumCre = IIf(dr("nNumCre") Is DBNull.Value, Nothing, dr("nNumCre"))
                mEntidad.nSalCre = IIf(dr("nSalCre") Is DBNull.Value, Nothing, dr("nSalCre"))
                mEntidad.nCarAfe = IIf(dr("nCarAfe") Is DBNull.Value, Nothing, dr("nCarAfe"))
                mEntidad.nSalMora = IIf(dr("nSalMora") Is DBNull.Value, Nothing, dr("nSalMora"))
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
        tables(0) = New String("Categoria")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT cCatego, ") 
        strSQL.Append(" Limite, ")
        strSQL.Append(" Limite2, ")
        strSQL.Append(" nNumCre, ") 
        strSQL.Append(" nSalCre, ") 
        strSQL.Append(" nCarAfe, ") 
        strSQL.Append(" nSalMora ") 
        strSQL.Append(" FROM Categoria ")

    End Sub

End Class
