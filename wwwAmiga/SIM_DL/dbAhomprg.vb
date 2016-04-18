Imports System.Text
Public Class dbAhomprg
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomprg
        Dim lID As String
        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahomprg ")
        strSQL.Append(" SET cnomcli = @cnomcli, ") 
        strSQL.Append(" fec_aplica = @fec_aplica, ") 
        strSQL.Append(" cantidad = @cantidad ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" estado = @estado, ") 
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 
        strSQL.Append(" AND fec_hoy = @fec_hoy ") 

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnomcli
        args(1) = New SqlParameter("@fec_aplica", SqlDbType.Datetime)
        args(1).Value = lEntidad.fec_aplica
        args(2) = New SqlParameter("@cantidad", SqlDbType.VarChar)
        args(2).Value = lEntidad.cantidad
        args(3) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodusu
        args(4) = New SqlParameter("@estado", SqlDbType.VarChar)
        args(4).Value = lEntidad.estado
        args(5) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value,lEntidad.ccodcli)
        args(6) = New SqlParameter("@cta_fuente", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.cta_fuente = Nothing, DBNull.Value,lEntidad.cta_fuente)
        args(7) = New SqlParameter("@cta_destin", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.cta_destin = Nothing, DBNull.Value,lEntidad.cta_destin)
        args(8) = New SqlParameter("@fec_hoy", SqlDbType.Datetime)
        args(8).Value = IIf(lEntidad.fec_hoy = Nothing, DBNull.Value,lEntidad.fec_hoy)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomprg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahomprg ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" cta_fuente, ") 
        strSQL.Append(" cta_destin, ") 
        strSQL.Append(" fec_hoy, ") 
        strSQL.Append(" fec_aplica, ") 
        strSQL.Append(" cantidad) ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" estado, ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @cnomcli, ") 
        strSQL.Append(" @cta_fuente, ") 
        strSQL.Append(" @cta_destin, ") 
        strSQL.Append(" @fec_hoy, ") 
        strSQL.Append(" @fec_aplica, ") 
        strSQL.Append(" @cantidad) ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @estado, ") 

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@cnomcli", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomcli
        args(2) = New SqlParameter("@cta_fuente", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.cta_fuente = Nothing, DBNull.Value, lEntidad.cta_fuente)
        args(3) = New SqlParameter("@cta_destin", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.cta_destin = Nothing, DBNull.Value, lEntidad.cta_destin)
        args(4) = New SqlParameter("@fec_hoy", SqlDbType.Datetime)
        args(4).Value = IIf(lEntidad.fec_hoy = Nothing, DBNull.Value, lEntidad.fec_hoy)
        args(5) = New SqlParameter("@fec_aplica", SqlDbType.Datetime)
        args(5).Value = lEntidad.fec_aplica
        args(6) = New SqlParameter("@cantidad", SqlDbType.VarChar)
        args(6).Value = lEntidad.cantidad
        args(7) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(7).Value = lEntidad.ccodusu
        args(8) = New SqlParameter("@estado", SqlDbType.VarChar)
        args(8).Value = lEntidad.estado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomprg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahomprg ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 
        strSQL.Append(" AND fec_hoy = @fec_hoy ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@cta_fuente", SqlDbType.VarChar)
        args(1).Value = lEntidad.cta_fuente
        args(2) = New SqlParameter("@cta_destin", SqlDbType.VarChar)
        args(2).Value = lEntidad.cta_destin
        args(3) = New SqlParameter("@fec_hoy", SqlDbType.Datetime)
        args(3).Value = lEntidad.fec_hoy

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahomprg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 
        strSQL.Append(" AND fec_hoy = @fec_hoy ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@cta_fuente", SqlDbType.VarChar)
        args(1).Value = lEntidad.cta_fuente
        args(2) = New SqlParameter("@cta_destin", SqlDbType.VarChar)
        args(2).Value = lEntidad.cta_destin
        args(3) = New SqlParameter("@fec_hoy", SqlDbType.Datetime)
        args(3).Value = lEntidad.fec_hoy

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.cnomcli = IIf(.Item("cnomcli") Is DBNull.Value, Nothing, .Item("cnomcli"))
                lEntidad.fec_aplica = IIf(.Item("fec_aplica") Is DBNull.Value, Nothing, .Item("fec_aplica"))
                lEntidad.cantidad = IIf(.Item("cantidad") Is DBNull.Value, Nothing, .Item("cantidad"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.estado = IIf(.Item("estado") Is DBNull.Value, Nothing, .Item("estado"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahomprg
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(fec_hoy),0) + 1 ")
        strSQL.Append(" FROM ahomprg ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@cta_fuente", SqlDbType.VarChar)
        args(1).Value = lEntidad.cta_fuente
        args(2) = New SqlParameter("@cta_destin", SqlDbType.VarChar)
        args(2).Value = lEntidad.cta_destin

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcli As String, cta_fuente As String, cta_destin As String) As listaahomprg

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@cta_fuente", SqlDbType.VarChar)
        args(1).Value = cta_fuente
        args(2) = New SqlParameter("@cta_destin", SqlDbType.VarChar)
        args(2).Value = cta_destin

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New Listaahomprg

        Try
            Do While dr.Read()
                Dim mEntidad As New ahomprg
                mEntidad.ccodcli = ccodcli
                mEntidad.cnomcli = IIf(dr("cnomcli") Is DBNull.Value, Nothing, dr("cnomcli"))
                mEntidad.cta_fuente = cta_fuente
                mEntidad.cta_destin = cta_destin
                mEntidad.fec_hoy = IIf(dr("fec_hoy") Is DBNull.Value, Nothing, dr("fec_hoy"))
                mEntidad.fec_aplica = IIf(dr("fec_aplica") Is DBNull.Value, Nothing, dr("fec_aplica"))
                mEntidad.cantidad = IIf(dr("cantidad") Is DBNull.Value, Nothing, dr("cantidad"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.estado = IIf(dr("estado") Is DBNull.Value, Nothing, dr("estado"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, cta_fuente As String, cta_destin As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@cta_fuente", cta_fuente)
        args(2) = New SqlParameter("@cta_destin", cta_destin)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, cta_fuente As String, cta_destin As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND cta_fuente = @cta_fuente ") 
        strSQL.Append(" AND cta_destin = @cta_destin ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@cta_fuente", cta_fuente)
        args(2) = New SqlParameter("@cta_destin", cta_destin)

        Dim tables(0) As String
        tables(0) = New String("ahomprg")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcli, ") 
        strSQL.Append(" cnomcli, ") 
        strSQL.Append(" cta_fuente, ") 
        strSQL.Append(" cta_destin, ") 
        strSQL.Append(" fec_hoy, ") 
        strSQL.Append(" fec_aplica, ") 
        strSQL.Append(" cantidad, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" estado ") 
        strSQL.Append(" FROM ahomprg ")

    End Sub

    Public Function ObtenerProgramados() As DataSet
        Dim sqlconnection1 As SqlConnection
        Dim sqldataadapter1 As SqlDataAdapter
        Dim ds As New DataSet
        Dim sqlselectcommand1 As SqlCommand

        sqlconnection1 = New SqlConnection
        sqldataadapter1 = New SqlDataAdapter

        ds = New DataSet
        sqlconnection1.ConnectionString = Me.cnnStr
        sqlselectcommand1 = New SqlCommand
        sqlselectcommand1.CommandText = "Select ccodcli, cnomcli, cta_fuente, cta_destin, fec_hoy, fec_aplica, cantidad, ccodusu, estado,  'xx' as aplica from ahomprg where estado = 'A' order by cnomcli"
        sqlselectcommand1.Connection = sqlconnection1
        sqldataadapter1.SelectCommand = sqlselectcommand1
        sqldataadapter1.Fill(ds, "Programado")

        Return ds

    End Function
    ''' <summary>
    ''' actualiza estado de aplicaciones programadas cuando el credito ya esta cancelado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ActualizaEstadodeAplicacion(ByVal ccodcta As String) As Integer
        Dim strSQL As New StringBuilder

        strSQL.Append("UPDATE AHOMPRG  SET  cestado =' ' WHERE cta_destin = @ccodcta ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodcta", SqlDbType.VarChar)
        args(0).Value = ccodcta


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
End Class
