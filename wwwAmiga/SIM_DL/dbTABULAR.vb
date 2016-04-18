Imports System.Text
Public Class dbTABULAR
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As TABULAR
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodres =  "" _
            Or lEntidad.ccodres = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodres = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE TABULAR ")
        strSQL.Append(" SET ccodusu = @ccodusu, ") 
        strSQL.Append(" dfecha = @dfecha, ") 
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 
        strSQL.Append(" AND ccodres = @ccodres ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodusu
        args(1) = New SqlParameter("@dfecha", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecha
        args(2) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value,lEntidad.ccodcli)
        args(3) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodenc = Nothing, DBNull.Value,lEntidad.ccodenc)
        args(4) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.ccodpreg = Nothing, DBNull.Value,lEntidad.ccodpreg)
        args(5) = New SqlParameter("@ccodres", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.ccodres = Nothing, DBNull.Value,lEntidad.ccodres)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As TABULAR
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO TABULAR ")
        strSQL.Append(" ( ccodcli, ") 
        strSQL.Append(" ccodenc, ") 
        strSQL.Append(" ccodpreg, ") 
        strSQL.Append(" ccodres, ")
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecha, nvalor) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodcli, ") 
        strSQL.Append(" @ccodenc, ") 
        strSQL.Append(" @ccodpreg, ") 
        strSQL.Append(" @ccodres, ")
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @dfecha, @nvalor) ")

        Dim args(6) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodcli = Nothing, DBNull.Value, lEntidad.ccodcli)
        args(1) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodenc = Nothing, DBNull.Value, lEntidad.ccodenc)
        args(2) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.ccodpreg = Nothing, DBNull.Value, lEntidad.ccodpreg)
        args(3) = New SqlParameter("@ccodres", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.ccodres = Nothing, " ", lEntidad.ccodres)
        args(4) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccodusu
        args(5) = New SqlParameter("@dfecha", SqlDbType.Datetime)
        args(5).Value = lEntidad.dfecha
        args(6) = New SqlParameter("@nvalor", SqlDbType.Decimal)
        args(6).Value = lEntidad.nvalor

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As TABULAR
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM TABULAR ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        'strSQL.Append(" AND ccodpreg = @ccodpreg ") 
        'strSQL.Append(" AND ccodres = @ccodres ") 

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodenc
        'args(2) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        'args(2).Value = lEntidad.ccodpreg
        'args(3) = New SqlParameter("@ccodres", SqlDbType.VarChar)
        'args(3).Value = lEntidad.ccodres

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As TABULAR
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 
        strSQL.Append(" AND ccodres = @ccodres ") 

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodenc
        args(2) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodpreg
        args(3) = New SqlParameter("@ccodres", SqlDbType.VarChar)
        args(3).Value = lEntidad.ccodres

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.dfecha = IIf(.Item("dfecha") Is DBNull.Value, Nothing, .Item("dfecha"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As TABULAR
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodres),0) + 1 ")
        strSQL.Append(" FROM TABULAR ")
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodcli
        args(1) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodenc
        args(2) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodpreg

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function ObtenerListaPorID(ccodcli As String, ccodenc As String, ccodpreg As String) As listaTABULAR

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", SqlDbType.VarChar)
        args(0).Value = ccodcli
        args(1) = New SqlParameter("@ccodenc", SqlDbType.VarChar)
        args(1).Value = ccodenc
        args(2) = New SqlParameter("@ccodpreg", SqlDbType.VarChar)
        args(2).Value = ccodpreg

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New ListaTABULAR

        Try
            Do While dr.Read()
                Dim mEntidad As New TABULAR
                mEntidad.ccodcli = ccodcli
                mEntidad.ccodenc = ccodenc
                mEntidad.ccodpreg = ccodpreg
                mEntidad.ccodres = IIf(dr("ccodres") Is DBNull.Value, Nothing, dr("ccodres"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.dfecha = IIf(dr("dfecha") Is DBNull.Value, Nothing, dr("dfecha"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, ccodenc As String, ccodpreg As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodenc", ccodenc)
        args(2) = New SqlParameter("@ccodpreg", ccodpreg)

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ccodcli As String, ccodenc As String, ccodpreg As String, ByRef ds as DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodcli = @ccodcli ") 
        strSQL.Append(" AND ccodenc = @ccodenc ") 
        strSQL.Append(" AND ccodpreg = @ccodpreg ") 

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodcli", ccodcli)
        args(1) = New SqlParameter("@ccodenc", ccodenc)
        args(2) = New SqlParameter("@ccodpreg", ccodpreg)

        Dim tables(0) As String
        tables(0) = New String("TABULAR")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT ccodcli, ") 
        strSQL.Append(" ccodenc, ") 
        strSQL.Append(" ccodpreg, ") 
        strSQL.Append(" ccodres, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" dfecha ") 
        strSQL.Append(" FROM TABULAR ")

    End Sub
    Public Function ObtenerDatosTabular() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select climide.cnomcli, ")
        strSQL.Append("cdepa = (select tabtzon.cdeszon from tabtzon where left(climide.ccoddom,2) = left(tabtzon.ccodzon,2) and tabtzon.ctipzon = '1'), ")
        strSQL.Append("cmuni = (select tabtzon.cdeszon from tabtzon where left(climide.ccoddom,4) = left(tabtzon.ccodzon,4) and tabtzon.ctipzon = '2'), ")
        strSQL.Append("ccomu = (select tabtzon.cdeszon from tabtzon where left(climide.ccoddom,6) = left(tabtzon.ccodzon,6) and tabtzon.ctipzon = '3'), ")
        strSQL.Append("cnivreg = (select case tabtzon.cnivreg when 'U' then 'URBANO' else 'RURAL' end from tabtzon where left(climide.ccoddom,6) = left(tabtzon.ccodzon,6) and tabtzon.ctipzon = '3'), ")
        strSQL.Append("climide.dnacimi, 000 as nedad, climide.csexo, ")
        strSQL.Append("tipo    = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg >= '003' and tabular.ccodpreg <= '007'), ")
        strSQL.Append("paredes = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg >= '011' and tabular.ccodpreg <= '014'), ")
        strSQL.Append("pisos   = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg >= '016' and tabular.ccodpreg <= '018'), ")
        strSQL.Append("Techos  = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg >= '020' and tabular.ccodpreg <= '022'), ")
        strSQL.Append("Hacnum = (select cast(tabular.ccodres as int) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '024'), ")
        strSQL.Append("Hacden = (select cast(tabular.ccodres as int) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '025'), ")
        strSQL.Append("000 as Hacinamiento, ")
        strSQL.Append("agua = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '028'), ")
        strSQL.Append("desague = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '029'), ")
        strSQL.Append("escolar31 = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '031'), ")
        strSQL.Append("escolar32 = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '032'), ")
        strSQL.Append("0 as educativo, ")
        strSQL.Append("nivelducativo = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '035'), ")
        strSQL.Append("depe37 = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '037'), ")
        strSQL.Append("depe39 = (select sum(cast(tabular.ccodres as int)) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='002' and tabular.ccodpreg = '039'), ")
        strSQL.Append("0 as dependencia, ")
        strSQL.Append("res002 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '002'), ")
        strSQL.Append("res003 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '003'), ")
        strSQL.Append("res005 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '005'), ")
        strSQL.Append("res006 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '006'), ")
        strSQL.Append("res007 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '007'), ")
        strSQL.Append("res008 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '008'), ")
        strSQL.Append("res009 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '009'), ")
        strSQL.Append("res010 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '010'), ")
        strSQL.Append("res011 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '011'), ")
        strSQL.Append("res012 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '012'), ")
        strSQL.Append("res013 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '013'), ")
        strSQL.Append("res014 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '014'), ")
        strSQL.Append("res015 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '015'), ")
        strSQL.Append("res016 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '016'), ")
        strSQL.Append("res017 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '017'), ")
        strSQL.Append("res018 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '018'), ")
        strSQL.Append("res021 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '021'), ")
        strSQL.Append("res022 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '022'), ")
        strSQL.Append("res023 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '023'), ")
        strSQL.Append("res024 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '024'), ")
        strSQL.Append("res025 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '025'), ")
        strSQL.Append("res026 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '026'), ")
        strSQL.Append("res027 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '027'), ")
        strSQL.Append("res028 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '028'), ")
        strSQL.Append("res029 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '029'), ")
        strSQL.Append("res030 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '030'), ")
        strSQL.Append("res031 = (select sum(tabular.nvalor) from tabular where climide.ccodcli = tabular.ccodcli and tabular.ccodenc ='003' and tabular.ccodpreg = '031') ")
        strSQL.Append("FROM climide where climide.ccodcli in (select tabular.ccodcli from tabular) ")

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
End Class
