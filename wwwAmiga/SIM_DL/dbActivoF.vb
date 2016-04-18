Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.Common
Public Class dbActivoF
    Inherits dbBase
    Private moDataset As DataSet
    Private moDataAdapter As SqlDataAdapter
    Private Const msTabla As String = "ActTemp"


    Public Function AsignarEmpleado(ByVal ccodinv As String, ByVal ccodusu As String, ByVal unidad As String, ByVal ubicacion As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Update ActivoF ")
        strSQL.Append(" Set ccodemp=@ccodusu,cunidad=@unidad,ccodubi=@ubicacion ")
        strSQL.Append(" Where ccodinv=@ccodinv ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu
        args(1) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(1).Value = ccodinv
        args(2) = New SqlParameter("@unidad", SqlDbType.VarChar)
        args(2).Value = unidad
        args(3) = New SqlParameter("@ubicacion", SqlDbType.VarChar)
        args(3).Value = ubicacion
        Return Sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As ActivoF
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodinv = "" _
            And lEntidad.cnumser = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnumser = lID

            Return Agregar(lEntidad)
        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ActivoF ")
        strSQL.Append(" SET ccodinv = @ccodinv, ")
        strSQL.Append(" ccodofi=@ccodofi, ")
        strSQL.Append(" ffondos=@ffondos, ")
        strSQL.Append(" cnrochq=@cnrochq, ")
        strSQL.Append(" cnumcom=@cnumcom, ")
        strSQL.Append(" ccodpro=@ccodpro, ")
        strSQL.Append(" cnumdoc=@cnumdoc, ")
        strSQL.Append(" dfecadq=@dfecadq, ")
        strSQL.Append(" dfecbja=@dfecbja, ")
        strSQL.Append(" ccodemp=@ccodemp, ")
        strSQL.Append(" ccodusu=@ccodusu, ")
        strSQL.Append(" nactdep=@nactdep, ")
        strSQL.Append(" ccodact=@ccodact, ")
        strSQL.Append(" ctipact=@ctipact, ")
        strSQL.Append(" cdesbien=@cdesbien, ")
        strSQL.Append(" nviduti=@nviduti, ")
        strSQL.Append(" nvalcpa=@nvalcpa, ")
        strSQL.Append(" nvalres=@nvalres, ")
        strSQL.Append(" nvalno=@nvalno, ")
        strSQL.Append(" ccodadq=@ccodadq, ")
        strSQL.Append(" cestbien=@cestbien, ")
        strSQL.Append(" ccodsec=@ccodsec, ")
        strSQL.Append(" ccodubi=@ccodubi, ")
        strSQL.Append(" cnumser=@cnumser, ")
        strSQL.Append(" cunidad=@cunidad ")
        strSQL.Append(" where ccodinv = @ccodinv")

        Dim args(24) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodofi
        args(2) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(2).Value = lEntidad.ffondos
        args(3) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnrochq
        args(4) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumcom
        args(5) = New SqlParameter("@ccodpro", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodpro
        args(6) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnumdoc
        args(7) = New SqlParameter("@dfecadq", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecadq
        args(8) = New SqlParameter("@dfecbja", SqlDbType.DateTime)
        args(8).Value = lEntidad.dfecbja
        args(9) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodemp
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodusu
        args(11) = New SqlParameter("@nactdep", SqlDbType.Int)
        args(11).Value = lEntidad.nactdep
        args(12) = New SqlParameter("@ccodact", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodact
        args(13) = New SqlParameter("@ctipact", SqlDbType.VarChar)
        args(13).Value = lEntidad.ctipact
        args(14) = New SqlParameter("@cdesbien", SqlDbType.VarChar)
        args(14).Value = lEntidad.cdesbien
        args(15) = New SqlParameter("@nviduti", SqlDbType.Int)
        args(15).Value = lEntidad.nviduti
        args(16) = New SqlParameter("@nvalcpa", SqlDbType.Decimal)
        args(16).Value = lEntidad.nvalcpa
        args(17) = New SqlParameter("@nvalres", SqlDbType.Decimal)
        args(17).Value = lEntidad.nvalres
        args(18) = New SqlParameter("@nvalno", SqlDbType.Decimal)
        args(18).Value = lEntidad.nvalno
        args(19) = New SqlParameter("@ccodadq", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodadq
        args(20) = New SqlParameter("@cestbien", SqlDbType.VarChar)
        args(20).Value = lEntidad.cestbien
        args(21) = New SqlParameter("@ccodsec", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccodsec
        args(22) = New SqlParameter("@ccodubi", SqlDbType.VarChar)
        args(22).Value = lEntidad.ccodubi
        args(23) = New SqlParameter("@cnumser", SqlDbType.VarChar)
        args(23).Value = lEntidad.cnumser
        args(24) = New SqlParameter("@cunidad", SqlDbType.VarChar)
        args(24).Value = lEntidad.cunidad
        Return Sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ActivoF
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ActivoF ")
        strSQL.Append(" ( ccodinv, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" cnrochq, ")
        strSQL.Append(" cnumcom, ")
        strSQL.Append(" ccodpro, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" dfecadq, ")
        strSQL.Append(" dfecbja, ")
        strSQL.Append(" ccodemp, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" nactdep, ")
        strSQL.Append(" ccodact, ")
        strSQL.Append(" ctipact, ")
        strSQL.Append(" cdesbien, ")
        strSQL.Append(" nviduti, ")
        strSQL.Append(" nvalcpa, ")
        strSQL.Append(" nvalres, ")
        strSQL.Append(" nvalno, ")
        strSQL.Append(" ccodadq, ")
        strSQL.Append(" cestbien, ")
        strSQL.Append(" ccodsec, ")
        strSQL.Append(" ccodubi, ")
        strSQL.Append(" cnumser, ")
        strSQL.Append(" cunidad, ")
        strSQL.Append(" dfecdep) ")

        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodinv, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @ffondos, ")
        strSQL.Append(" @cnrochq, ")
        strSQL.Append(" @cnumcom, ")
        strSQL.Append(" @ccodpro, ")
        strSQL.Append(" @cnumdoc, ")
        strSQL.Append(" @dfecadq, ")
        strSQL.Append(" @dfecbja, ")
        strSQL.Append(" @ccodemp, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @nactdep, ")
        strSQL.Append(" @ccodact, ")
        strSQL.Append(" @ctipact, ")
        strSQL.Append(" @cdesbien, ")
        strSQL.Append(" @nviduti, ")
        strSQL.Append(" @nvalcpa, ")
        strSQL.Append(" @nvalres, ")
        strSQL.Append(" @nvalno, ")
        strSQL.Append(" @ccodadq, ")
        strSQL.Append(" @cestbien, ")
        strSQL.Append(" @ccodsec, ")
        strSQL.Append(" @ccodubi, ")
        strSQL.Append(" @cnumser, ")
        strSQL.Append(" @cunidad, ")
        strSQL.Append(" @dfecdep) ")

        Dim args(25) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodofi
        args(2) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(2).Value = lEntidad.ffondos
        args(3) = New SqlParameter("@cnrochq", SqlDbType.VarChar)
        args(3).Value = lEntidad.cnrochq
        args(4) = New SqlParameter("@cnumcom", SqlDbType.VarChar)
        args(4).Value = lEntidad.cnumcom
        args(5) = New SqlParameter("@ccodpro", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccodpro
        args(6) = New SqlParameter("@cnumdoc", SqlDbType.VarChar)
        args(6).Value = lEntidad.cnumdoc
        args(7) = New SqlParameter("@dfecadq", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecadq
        args(8) = New SqlParameter("@dfecbja", SqlDbType.DateTime)
        args(8).Value = lEntidad.dfecbja
        args(9) = New SqlParameter("@ccodemp", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodemp
        args(10) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(10).Value = lEntidad.ccodusu
        args(11) = New SqlParameter("@nactdep", SqlDbType.Int)
        args(11).Value = lEntidad.nactdep
        args(12) = New SqlParameter("@ccodact", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccodact
        args(13) = New SqlParameter("@ctipact", SqlDbType.VarChar)
        args(13).Value = lEntidad.ctipact
        args(14) = New SqlParameter("@cdesbien", SqlDbType.VarChar)
        args(14).Value = lEntidad.cdesbien
        args(15) = New SqlParameter("@nviduti", SqlDbType.Int)
        args(15).Value = lEntidad.nviduti
        args(16) = New SqlParameter("@nvalcpa", SqlDbType.Decimal)
        args(16).Value = lEntidad.nvalcpa
        args(17) = New SqlParameter("@nvalres", SqlDbType.Decimal)
        args(17).Value = lEntidad.nvalres
        args(18) = New SqlParameter("@nvalno", SqlDbType.Decimal)
        args(18).Value = lEntidad.nvalno
        args(19) = New SqlParameter("@ccodadq", SqlDbType.VarChar)
        args(19).Value = lEntidad.ccodadq
        args(20) = New SqlParameter("@cestbien", SqlDbType.VarChar)
        args(20).Value = lEntidad.cestbien
        args(21) = New SqlParameter("@ccodsec", SqlDbType.VarChar)
        args(21).Value = lEntidad.ccodsec
        args(22) = New SqlParameter("@ccodubi", SqlDbType.VarChar)
        args(22).Value = lEntidad.ccodubi
        args(23) = New SqlParameter("@cnumser", SqlDbType.VarChar)
        args(23).Value = lEntidad.cnumser
        args(24) = New SqlParameter("@cunidad", SqlDbType.VarChar)
        args(24).Value = lEntidad.cunidad
        args(25) = New SqlParameter("@dfecdep", SqlDbType.DateTime)
        args(25).Value = lEntidad.dfecdep

        Return Sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As ActivoF
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ActivoF ")

        Dim args(-1) As SqlParameter

        Return Sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As ActivoF
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        strSQL.Append(" WHERE ccodinv = @ccodinv ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv

        Dim dsDatos As DataSet

        dsDatos = Sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodinv = IIf(.Item("ccodinv") Is DBNull.Value, Nothing, .Item("ccodinv"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
                lEntidad.ffondos = IIf(.Item("ffondos") Is DBNull.Value, Nothing, .Item("ffondos"))
                lEntidad.cnrochq = IIf(.Item("cnrochq") Is DBNull.Value, Nothing, .Item("cnrochq"))
                lEntidad.cnumcom = IIf(.Item("cnumcom") Is DBNull.Value, Nothing, .Item("cnumcom"))
                lEntidad.ccodpro = IIf(.Item("ccodpro") Is DBNull.Value, Nothing, .Item("ccodpro"))
                lEntidad.cnumdoc = IIf(.Item("cnumdoc") Is DBNull.Value, Nothing, .Item("cnumdoc"))
                lEntidad.dfecadq = IIf(.Item("dfecadq") Is DBNull.Value, Nothing, .Item("dfecadq"))
                lEntidad.dfecbja = IIf(.Item("dfecbja") Is DBNull.Value, Nothing, .Item("dfecbja"))
                lEntidad.ccodemp = IIf(.Item("ccodemp") Is DBNull.Value, Nothing, .Item("ccodemp"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.nactdep = IIf(.Item("nactdep") Is DBNull.Value, Nothing, .Item("nactdep"))
                lEntidad.ccodact = IIf(.Item("ccodact") Is DBNull.Value, Nothing, .Item("ccodact"))
                lEntidad.ctipact = IIf(.Item("ctipact") Is DBNull.Value, Nothing, .Item("ctipact"))
                lEntidad.cdesbien = IIf(.Item("cdesbien") Is DBNull.Value, Nothing, .Item("cdesbien"))
                lEntidad.nviduti = IIf(.Item("nviduti") Is DBNull.Value, Nothing, .Item("nviduti"))
                lEntidad.nvalcpa = IIf(.Item("nvalcpa") Is DBNull.Value, Nothing, .Item("nvalcpa"))
                lEntidad.nvalres = IIf(.Item("nvalres") Is DBNull.Value, Nothing, .Item("nvalres"))
                lEntidad.nvalno = IIf(.Item("nvalno") Is DBNull.Value, Nothing, .Item("nvalno"))
                lEntidad.ccodadq = IIf(.Item("ccodadq") Is DBNull.Value, Nothing, .Item("ccodadq"))
                lEntidad.cestbien = IIf(.Item("cestbien") Is DBNull.Value, Nothing, .Item("cestbien"))
                lEntidad.ccodsec = IIf(.Item("ccodsec") Is DBNull.Value, Nothing, .Item("ccodsec"))
                lEntidad.ccodubi = IIf(.Item("ccodubi") Is DBNull.Value, Nothing, .Item("ccodubi"))
                lEntidad.cnumser = IIf(.Item("cnumser") Is DBNull.Value, Nothing, .Item("cnumser"))
                lEntidad.cunidad = IIf(.Item("cunidad") Is DBNull.Value, Nothing, .Item("cunidad"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1
    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ActivoF
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(),0) + 1 ")
        strSQL.Append(" FROM ActivoF ")

        Return Sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function ObtenerListaPorID() As listaActivoF

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = Sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaActivoF

        Try
            Do While dr.Read()
                Dim mEntidad As New ActivoF
                mEntidad.ccodinv = IIf(dr("ccodinv") Is DBNull.Value, Nothing, dr("ccodinv"))
                mEntidad.cdesbien = IIf(dr("cdesbien") Is DBNull.Value, Nothing, dr("cdesbien"))
                mEntidad.nvalcpa = IIf(dr("nvalcpa") Is DBNull.Value, Nothing, dr("nvalcpa"))
                mEntidad.cestbien = IIf(dr("cestbien") Is DBNull.Value, Nothing, dr("cestbien"))
                mEntidad.dfecadq = IIf(dr("dfecadq") Is DBNull.Value, Nothing, dr("dfecadq"))
                mEntidad.nviduti = IIf(dr("nviduti") Is DBNull.Value, Nothing, dr("nviduti"))
                mEntidad.nvalres = IIf(dr("nvalres") Is DBNull.Value, Nothing, dr("nvalres"))
                mEntidad.ccodadq = IIf(dr("ccodadq") Is DBNull.Value, Nothing, dr("ccodadq"))
                mEntidad.ccodubi = IIf(dr("ccodubi") Is DBNull.Value, Nothing, dr("ccodubi"))
                mEntidad.cnumser = IIf(dr("cnumser") Is DBNull.Value, Nothing, dr("cnumser"))
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

        ds = Sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds
    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("ActivoF")

        Sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1
    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)
        strSQL.Append(" SELECT * ")
        strSQL.Append(" FROM ActivoF ")
    End Sub

    Public Function BuscaCodigo() As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT count(*) ")
        strSQL.Append(" FROM ActivoF ")
    
        Dim conteo As Integer
        Dim i As String
        Dim c As Integer

        conteo = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

        If conteo = 0 Then
            i = "00001"
        End If
        If conteo >= 1 And conteo <= 9 Then
            conteo = conteo + 1
            i = "0000" & conteo
        End If
        If conteo > 9 And conteo <= 99 Then
            conteo = conteo + 1
            i = "000" & conteo
        End If
        If conteo > 99 And conteo <= 999 Then
            conteo = conteo + 1
            i = "00" & conteo
        End If
        If conteo > 999 Then
            conteo = conteo + 1
            i = conteo
        End If
        Return i
    End Function

    Public Function DatasetActivoFijo(ByVal ccodofi As String, ByVal ffondos As String, ByVal ndepre As Integer, ByVal ccodadq As String, ByVal ccodact As String, ByVal dfecha As DateTime) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ccodinv, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" cdesbien, ")
        strSQL.Append(" nvalcpa, ")
        strSQL.Append(" cestbien, ")
        strSQL.Append(" dfecadq, ")
        strSQL.Append(" dfecbja,")
        strSQL.Append(" nactdep, ")
        strSQL.Append(" nviduti, ")
        strSQL.Append(" nvalres, ")
        strSQL.Append(" ccodadq, ")
        strSQL.Append(" ccodubi, ")
        strSQL.Append(" cnumser, ")
        strSQL.Append(" dfecdep, ")
        strSQL.Append(" nvalno, cCodAct, ")
        strSQL.Append("000000.00 as depanual, ")
        strSQL.Append("000000.00 as depmen, ")
        strSQL.Append("000000.00 as depmenno, ")
        strSQL.Append("000000.00 as depacum, ")
        strSQL.Append("000000.00 as depmende, ")
        strSQL.Append("000000.00 as totdepacum, ")
        strSQL.Append("000000.00 as diferencia, ")
        strSQL.Append(" space(1) as ctipo, ")
        strSQL.Append(" dateadd(yy,nviduti,((dateadd(m,1,dfecadq)-day(dfecadq)))) as dultfecdep, ")
        strSQL.Append(" datediff(m,(dateadd(m,1,dfecadq)-day(dateadd(m,1,dfecadq)))+1, @dfecha) as nmestotdep ")
        strSQL.Append(" FROM ActivoF ")
        'strSQL.Append(" Where dfecadq >= @dfecha And dfecadq <= @dfecha ")
        strSQL.Append(" Where dfecadq <= @dfecha ")

        If ccodofi <> "" Then
            strSQL.Append(" And ccodofi=@ccodofi ")
        End If

        If ffondos <> "" Then
            strSQL.Append(" And ffondos = @ffondos ")
        End If

        If ndepre = 1 Then
            strSQL.Append(" And nactdep = 1 ")
        ElseIf ndepre = 0 Then
            strSQL.Append(" And nactdep = 0 ")
        End If

        If ccodadq <> "" Then
            strSQL.Append(" And ccodadq = @ccodadq ")
        End If

        If ccodact <> "" Then
            strSQL.Append(" And ccodact = @ccodact ")
        End If

        Dim args(5) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@ffondos", SqlDbType.VarChar)
        args(1).Value = ffondos
        args(2) = New SqlParameter("@ndepre", SqlDbType.Int)
        args(2).Value = ndepre
        args(3) = New SqlParameter("@ccodadq", SqlDbType.Char)
        args(3).Value = ccodadq
        args(4) = New SqlParameter("@ccodact", SqlDbType.Char)
        args(4).Value = ccodact
        args(5) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(5).Value = dfecha

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function

    Public Function BuscaInventario(ByVal cvariable As String, ByVal cvalor As Integer, ByVal dfecha As Date) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" Select ccodinv, ")
        strSQL.Append(" cnumcom, ")
        strSQL.Append(" cnumdoc, ")
        strSQL.Append(" dfecadq, ")
        strSQL.Append(" cdesbien ")
        strSQL.Append(" From ActivoF ")

        If cvalor = 1 Then
            strSQL.Append(" Where cdesbien like" & "'" & "%" & cvariable & "%" & "'")
        ElseIf cvalor = 2 Then
            strSQL.Append(" Where ccodinv=@cvariable ")
        ElseIf cvalor = 3 Then
            strSQL.Append(" Where cnumdoc=@cvariable ")
        ElseIf cvalor = 4 Then
            strSQL.Append(" Where dfecadq=@dfecha ")
        End If

        Dim args(0) As SqlParameter
        If cvalor = 1 Or cvalor = 2 Or cvalor = 3 Then
            args(0) = New SqlParameter("@cvariable", SqlDbType.VarChar)
            args(0).Value = cvariable
        ElseIf cvalor = 4 Then
            args(0) = New SqlParameter("@dfecha", SqlDbType.DateTime)
            args(0).Value = dfecha
        End If
        Dim ds As New DataSet
        ds = Sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function

    Public Function DetalleActivo(ByVal ccodinv As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" Select Activof.ccodinv, ")
        strSQL.Append(" ActivoF.ccodofi, ")
        strSQL.Append(" ActivoF.ffondos, ")
        strSQL.Append(" ActivoF.cnrochq, ")
        strSQL.Append(" ActivoF.cnumcom, ")
        strSQL.Append(" ActivoF.ccodpro, ")
        strSQL.Append(" CntaEmp.cdescri, ")
        strSQL.Append(" ActivoF.cnumdoc, ")
        strSQL.Append(" ActivoF.dfecadq, ")
        strSQL.Append(" ActivoF.dfecbja, ")
        strSQL.Append(" ActivoF.nactdep, ")
        strSQL.Append(" ActivoF.ccodact, ")
        strSQL.Append(" ActivoF.ctipact, ")
        strSQL.Append(" ActivoF.cdesbien, ")
        strSQL.Append(" ActivoF.nviduti, ")
        strSQL.Append(" ActivoF.nvalcpa, ")
        strSQL.Append(" ActivoF.nvalres, ")
        strSQL.Append(" ActivoF.nvalno, ")
        strSQL.Append(" ActivoF.ccodadq, ")
        strSQL.Append(" ActivoF.cestbien, ")
        strSQL.Append(" ActivoF.ccodsec, ")
        strSQL.Append(" ActivoF.ccodubi ")
        strSQL.Append(" From ActivoF, CntaEmp  ")
        strSQL.Append(" Where ActivoF.ccodinv=@ccodinv And CntaEmp.ccodemp=ActivoF.ccodpro ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = ccodinv

        Dim ds As New DataSet
        ds = Sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function
    Public Function DatasetActivoFijoPartida() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ccodofi,  ")
        strSQL.Append(" ffondos, ")
        strSQL.Append(" cCodAct, ")
        strSQL.Append("cast(sum((nvalcpa)/nviduti/12) as decimal(16,2)) as depremensual ")
        strSQL.Append(" FROM ActivoF ")
        strSQL.Append(" where nactdep = 1 ")
        strSQL.Append(" group by ccodofi,ffondos,ccodact")
        strSQL.Append(" order by ccodofi")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function
    Public Function DescargaActivoFijo(ByVal ccodofi As String, ByVal ccodusu As String, ByVal ccodinv As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" update Activof set ccodofi=@ccodofi,ccodemp=@ccodusu  where ccodinv=@ccodinv")

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(2).Value = ccodinv

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function TrasladaActivoFijo(ByVal ccodofi As String, ByVal ccodusu As String, ByVal ccodinv As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append(" update Activof set ccodofi=@ccodofi,ccodemp=@ccodusu  where ccodinv=@ccodinv")

        Dim args(2) As SqlParameter

        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(2).Value = ccodinv

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

End Class
