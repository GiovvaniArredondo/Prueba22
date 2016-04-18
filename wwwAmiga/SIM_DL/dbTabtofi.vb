Imports System.Text
Public Class dbTabtofi
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtofi
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodofi =  "" _
            Or lEntidad.ccodofi = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodofi = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtofi ")
        strSQL.Append(" SET ccodins = @ccodins, ") 
        strSQL.Append(" cnomofi = @cnomofi, ") 
        strSQL.Append(" ctipofi = @ctipofi, ") 
        strSQL.Append(" cofisup = @cofisup, ") 
        strSQL.Append(" cdrive = @cdrive, ") 
        strSQL.Append(" cserver = @cserver, ") 
        strSQL.Append(" cusuari = @cusuari, ") 
        strSQL.Append(" cclave = @cclave, ") 
        strSQL.Append(" ctipser = @ctipser, ") 
        strSQL.Append(" ninterco = @ninterco, ") 
        strSQL.Append(" cflag = @cflag ") 
        strSQL.Append(" WHERE ccodofi = @ccodofi ") 

        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodins = Nothing, DBNull.Value, lEntidad.ccodins)
        args(1) = New SqlParameter("@cnomofi", SqlDbType.VarChar)
        args(1).Value = lEntidad.cnomofi
        args(2) = New SqlParameter("@ctipofi", SqlDbType.VarChar)
        args(2).Value = lEntidad.ctipofi
        args(3) = New SqlParameter("@cofisup", SqlDbType.VarChar)
        args(3).Value = lEntidad.cofisup
        args(4) = New SqlParameter("@cdrive", SqlDbType.VarChar)
        args(4).Value = lEntidad.cdrive
        args(5) = New SqlParameter("@cserver", SqlDbType.VarChar)
        args(5).Value = lEntidad.cserver
        args(6) = New SqlParameter("@cusuari", SqlDbType.VarChar)
        args(6).Value = lEntidad.cusuari
        args(7) = New SqlParameter("@cclave", SqlDbType.VarChar)
        args(7).Value = lEntidad.cclave
        args(8) = New SqlParameter("@ctipser", SqlDbType.VarChar)
        args(8).Value = lEntidad.ctipser
        args(9) = New SqlParameter("@ninterco", SqlDbType.VarChar)
        args(9).Value = lEntidad.ninterco
        args(10) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(10).Value = lEntidad.cflag
        args(11) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.ccodofi = Nothing, DBNull.Value,lEntidad.ccodofi)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtofi
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO tabtofi ")
        strSQL.Append(" ( ccodins, ") 
        strSQL.Append(" ccodofi, ") 
        strSQL.Append(" cnomofi, ") 
        strSQL.Append(" ctipofi, ") 
        strSQL.Append(" cofisup, ") 
        strSQL.Append(" cdrive, ") 
        strSQL.Append(" cserver, ") 
        strSQL.Append(" cusuari, ") 
        strSQL.Append(" cclave, ") 
        strSQL.Append(" ctipser, ") 
        strSQL.Append(" ninterco, ") 
        strSQL.Append(" cflag) ") 
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodins, ") 
        strSQL.Append(" @ccodofi, ") 
        strSQL.Append(" @cnomofi, ") 
        strSQL.Append(" @ctipofi, ") 
        strSQL.Append(" @cofisup, ") 
        strSQL.Append(" @cdrive, ") 
        strSQL.Append(" @cserver, ") 
        strSQL.Append(" @cusuari, ") 
        strSQL.Append(" @cclave, ") 
        strSQL.Append(" @ctipser, ") 
        strSQL.Append(" @ninterco, ") 
        strSQL.Append(" @cflag) ") 

        Dim args(11) As SqlParameter
        args(0) = New SqlParameter("@ccodins", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.ccodins = Nothing, DBNull.Value, lEntidad.ccodins)
        args(1) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.ccodofi = Nothing, DBNull.Value, lEntidad.ccodofi)
        args(2) = New SqlParameter("@cnomofi", SqlDbType.VarChar)
        args(2).Value = lEntidad.cnomofi
        args(3) = New SqlParameter("@ctipofi", SqlDbType.VarChar)
        args(3).Value = lEntidad.ctipofi
        args(4) = New SqlParameter("@cofisup", SqlDbType.VarChar)
        args(4).Value = lEntidad.cofisup
        args(5) = New SqlParameter("@cdrive", SqlDbType.VarChar)
        args(5).Value = lEntidad.cdrive
        args(6) = New SqlParameter("@cserver", SqlDbType.VarChar)
        args(6).Value = lEntidad.cserver
        args(7) = New SqlParameter("@cusuari", SqlDbType.VarChar)
        args(7).Value = lEntidad.cusuari
        args(8) = New SqlParameter("@cclave", SqlDbType.VarChar)
        args(8).Value = lEntidad.cclave
        args(9) = New SqlParameter("@ctipser", SqlDbType.VarChar)
        args(9).Value = lEntidad.ctipser
        args(10) = New SqlParameter("@ninterco", SqlDbType.VarChar)
        args(10).Value = lEntidad.ninterco
        args(11) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(11).Value = lEntidad.cflag

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtofi
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM tabtofi ")
        strSQL.Append(" WHERE ccodofi = @ccodofi ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodofi

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As tabtofi
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ccodofi = @ccodofi ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodofi

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodins = IIf(.Item("ccodins") Is DBNull.Value, Nothing, .Item("ccodins"))
                lEntidad.cnomofi = IIf(.Item("cnomofi") Is DBNull.Value, Nothing, .Item("cnomofi"))
                lEntidad.ctipofi = IIf(.Item("ctipofi") Is DBNull.Value, Nothing, .Item("ctipofi"))
                lEntidad.cofisup = IIf(.Item("cofisup") Is DBNull.Value, Nothing, .Item("cofisup"))
                lEntidad.cdrive = IIf(.Item("cdrive") Is DBNull.Value, Nothing, .Item("cdrive"))
                lEntidad.cserver = IIf(.Item("cserver") Is DBNull.Value, Nothing, .Item("cserver"))
                lEntidad.cusuari = IIf(.Item("cusuari") Is DBNull.Value, Nothing, .Item("cusuari"))
                lEntidad.cclave = IIf(.Item("cclave") Is DBNull.Value, Nothing, .Item("cclave"))
                lEntidad.ctipser = IIf(.Item("ctipser") Is DBNull.Value, Nothing, .Item("ctipser"))
                lEntidad.ninterco = IIf(.Item("ninterco") Is DBNull.Value, Nothing, .Item("ninterco"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.cmuni = IIf(.Item("cmuni") Is DBNull.Value, Nothing, .Item("cmuni"))
                lEntidad.cdepa = IIf(.Item("cdepa") Is DBNull.Value, Nothing, .Item("cdepa"))
                lEntidad.cdireccion = IIf(.Item("cdireccion") Is DBNull.Value, Nothing, .Item("cdireccion"))
                lEntidad.ctelefono = IIf(.Item("ctelefono") Is DBNull.Value, Nothing, .Item("ctelefono"))
            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As tabtofi
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(ccodofi),0) + 1 ")
        strSQL.Append(" FROM tabtofi ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listatabtofi

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listatabtofi

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtofi
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cnomofi = IIf(dr("cnomofi") Is DBNull.Value, Nothing, dr("cnomofi"))
                mEntidad.ctipofi = IIf(dr("ctipofi") Is DBNull.Value, Nothing, dr("ctipofi"))
                mEntidad.cofisup = IIf(dr("cofisup") Is DBNull.Value, Nothing, dr("cofisup"))
                mEntidad.cdrive = IIf(dr("cdrive") Is DBNull.Value, Nothing, dr("cdrive"))
                mEntidad.cserver = IIf(dr("cserver") Is DBNull.Value, Nothing, dr("cserver"))
                mEntidad.cusuari = IIf(dr("cusuari") Is DBNull.Value, Nothing, dr("cusuari"))
                mEntidad.cclave = IIf(dr("cclave") Is DBNull.Value, Nothing, dr("cclave"))
                mEntidad.ctipser = IIf(dr("ctipser") Is DBNull.Value, Nothing, dr("ctipser"))
                mEntidad.ninterco = IIf(dr("ninterco") Is DBNull.Value, Nothing, dr("ninterco"))
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
    Public Function ObtenerlistaporNivel(ByVal nNivel As Integer, ByVal cOficina As String) As listatabtofi
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina


        'If nNivel < 9 Then
        '    strSQL.Append("WHERE cCodofi = @cOficina ")
        'End If

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabtofi

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtofi
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cnomofi = IIf(dr("cnomofi") Is DBNull.Value, Nothing, dr("cnomofi"))
                mEntidad.ctipofi = IIf(dr("ctipofi") Is DBNull.Value, Nothing, dr("ctipofi"))
                mEntidad.cofisup = IIf(dr("cofisup") Is DBNull.Value, Nothing, dr("cofisup"))
                mEntidad.cdrive = IIf(dr("cdrive") Is DBNull.Value, Nothing, dr("cdrive"))
                mEntidad.cserver = IIf(dr("cserver") Is DBNull.Value, Nothing, dr("cserver"))
                mEntidad.cusuari = IIf(dr("cusuari") Is DBNull.Value, Nothing, dr("cusuari"))
                mEntidad.cclave = IIf(dr("cclave") Is DBNull.Value, Nothing, dr("cclave"))
                mEntidad.ctipser = IIf(dr("ctipser") Is DBNull.Value, Nothing, dr("ctipser"))
                mEntidad.ninterco = IIf(dr("ninterco") Is DBNull.Value, Nothing, dr("ninterco"))
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
    Public Function ObtenerlistaporNivel2(ByVal nNivel As Integer, ByVal cOficina As String) As listatabtofi
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE ctipofi = '1' ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina


        If cOficina.Trim = "001" Then
        Else
            strSQL.Append("and cCodofi = @cOficina ")
        End If

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listatabtofi

        Try
            Do While dr.Read()
                Dim mEntidad As New tabtofi
                mEntidad.ccodins = IIf(dr("ccodins") Is DBNull.Value, Nothing, dr("ccodins"))
                mEntidad.ccodofi = IIf(dr("ccodofi") Is DBNull.Value, Nothing, dr("ccodofi"))
                mEntidad.cnomofi = IIf(dr("cnomofi") Is DBNull.Value, Nothing, dr("cnomofi"))
                mEntidad.ctipofi = IIf(dr("ctipofi") Is DBNull.Value, Nothing, dr("ctipofi"))
                mEntidad.cofisup = IIf(dr("cofisup") Is DBNull.Value, Nothing, dr("cofisup"))
                mEntidad.cdrive = IIf(dr("cdrive") Is DBNull.Value, Nothing, dr("cdrive"))
                mEntidad.cserver = IIf(dr("cserver") Is DBNull.Value, Nothing, dr("cserver"))
                mEntidad.cusuari = IIf(dr("cusuari") Is DBNull.Value, Nothing, dr("cusuari"))
                mEntidad.cclave = IIf(dr("cclave") Is DBNull.Value, Nothing, dr("cclave"))
                mEntidad.ctipser = IIf(dr("ctipser") Is DBNull.Value, Nothing, dr("ctipser"))
                mEntidad.ninterco = IIf(dr("ninterco") Is DBNull.Value, Nothing, dr("ninterco"))
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
    'Public Function ObtenerDataSetPorID() As DataSet

    '    Dim strSQL As New StringBuilder
    '    SelectTabla(strSQL)

    '    Dim ds As DataSet

    '    ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

    '    Return ds

    'End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("tabtofi")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT ccodins, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" cnomofi, ")
        strSQL.Append(" ctipofi, ")
        strSQL.Append(" cofisup, ")
        strSQL.Append(" cdrive, ")
        strSQL.Append(" cserver, ")
        strSQL.Append(" cusuari, ")
        strSQL.Append(" cclave, ")
        strSQL.Append(" ctipser, ")
        strSQL.Append(" ninterco, ")
        strSQL.Append(" cflag, ")
        strSQL.Append(" 0000000000.00 AS  ncapdes, ")
        strSQL.Append(" 0000000000.00 AS  nsalcap, ")
        strSQL.Append(" 0000000000.00 AS  nmora, ")
        strSQL.Append(" 0000000000.00 AS  nsalint, ")
        strSQL.Append(" 0000000000.00 AS  nsalmor, ")
        strSQL.Append(" 0000000000.00 AS  nporc1, ")
        strSQL.Append(" 0000000000.00 AS  nporc2, ")
        strSQL.Append(" cmuni, cdepa, cdireccion, ctelefono ")
        strSQL.Append(" FROM tabtofi ")

    End Sub

    Public Function ObtenerDataSetPorID() As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" order by tabtofi.ccodofi ")

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function
    Public Function ObtenerDataSetPorNivel(ByVal nNivel, ByVal cOficina) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select cNomOfi, cCodOfi From TABTOFI  ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina


        'If nNivel < 9 Then
        'strSQL.Append("WHERE cCodofi = @cOficina ")
        'End If

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function ObtenerDataSetPorNivel2(ByVal nNivel, ByVal cOficina) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select cNomOfi, cCodOfi From TABTOFI  ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@nNivel", SqlDbType.Int)
        args(0).Value = nNivel

        args(1) = New SqlParameter("@cOficina", SqlDbType.Char)
        args(1).Value = cOficina


        'If nNivel < 9 Then
        '    strSQL.Append("and cCodofi = @cOficina ")
        'End If
        If cOficina = "001" Then

        Else
            strSQL.Append("where cCodofi = @cOficina ")
        End If

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function
    Public Function OficinaCtb(ByVal lcCodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cUsuari FROM TABTOFI WHERE cCodofi = @lcCodofi")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodofi", SqlDbType.Char)
        args(0).Value = lcCodofi

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        '*******
        If ds.Tables(0).Rows.Count = 0 Then
            Return "01"
        End If
        Dim lcCodctb As String
        lcCodctb = ds.Tables(0).Rows(0)("cUsuari")
        lcCodctb = lcCodctb.Trim
        Return lcCodctb
    End Function

    Public Function NombreAgencia(ByVal ccodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cNomOfi From TABTOFI  ")
        strSQL.Append("where cCodofi = @ccodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = ccodofi



        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcnomofi As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnomofi")) Then
            Else
                lcnomofi = ds.Tables(0).Rows(0)("cnomofi")
            End If
        End If

        Return lcnomofi
    End Function

    Public Function ActualizaValidacion(ByVal cCodofi As String, ByVal lvalcie As Boolean) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE TABTOFI SET cvalcie = @lvalcie  WHERE cCodofi = @cCodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = cCodofi

        args(1) = New SqlParameter("@lvalcie", SqlDbType.Bit)
        args(1).Value = lvalcie


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Function CargaAgenciaChk() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCodofi, cNomOfi ,case when cvalcie = 0 then 'Pendiente' else 'Cerrada' end as estado FROM tabtofi where cflag <> 'X' order by cCodofi")
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function

    Public Function ReseteaValidador() As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtofi set cvalcie ='0' ")

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString())
    End Function

    Public Function NombreDepartamento(ByVal ccodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cDepa From TABTOFI  ")
        strSQL.Append("where cCodofi = @ccodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = ccodofi



        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcnomofi As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cdepa")) Then
            Else
                lcnomofi = ds.Tables(0).Rows(0)("cdepa")
            End If
        End If

        Return lcnomofi
    End Function

    Public Function NombreMunicipio(ByVal ccodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cMuni From TABTOFI  ")
        strSQL.Append("where cCodofi = @ccodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = ccodofi



        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcnomofi As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cmuni")) Then
            Else
                lcnomofi = ds.Tables(0).Rows(0)("cmuni")
            End If
        End If

        Return lcnomofi
    End Function


    Public Function NombreDireccion(ByVal ccodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cdireccion From TABTOFI  ")
        strSQL.Append("where cCodofi = @ccodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = ccodofi



        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lcnomofi As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cdireccion")) Then
            Else
                lcnomofi = ds.Tables(0).Rows(0)("cdireccion")
            End If
        End If

        Return lcnomofi
    End Function

    Public Function ObtieneCorrelativo(ByVal cCodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT  cConvar FROM TABTOFI ")
        strSQL.Append("WHERE ccodofi = @ccodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = cCodofi


        Dim ds As New DataSet
        Dim lcconvar As String = "1"

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cConvar")) Then
            Else
                lcconvar = ds.Tables(0).Rows(0)("cConvar")
            End If
        End If
        Return lcconvar
    End Function
    Public Function ActualizaCorrelativo(ByVal cCodofi As String, ByVal lcconvar As String) As Integer
        '   Dim lcconvar As String
        Dim lcnuevo As String
        Try
            lcnuevo = (Integer.Parse(lcconvar) + 1).ToString.Trim
        Catch ex As Exception
            lcnuevo = "1"
        End Try
        '   lcconvar = ObtieneCorrelativo(cCodofi)
     


        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE tabtofi SET cConvar = @lcnuevo WHERE cCodofi = @ccodofi ")

        Dim args(1) As SqlParameter

        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = cCodofi
        args(1) = New SqlParameter("@lcnuevo", SqlDbType.Char)
        args(1).Value = lcnuevo


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function
    Public Function OficinaAux(ByVal lcCodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cserver FROM TABTOFI WHERE cCodofi = @lcCodofi")

        Dim a As String
        a = strSQL.ToString

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@lcCodofi", SqlDbType.Char)
        args(0).Value = lcCodofi

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        '*******
        If ds.Tables(0).Rows.Count = 0 Then
            Return "1"
        End If
        Dim lcCodctb As String
        lcCodctb = ds.Tables(0).Rows(0)("cserver")
        lcCodctb = lcCodctb.Trim
        Return lcCodctb
    End Function

    Public Function VerificaValidacionAgencia(ByVal ccodofi As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cvalcie FROM tabtofi where ccodofi = @ccodofi ")

        Dim ds As New DataSet

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(0).Value = ccodofi


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lvalidada As Boolean

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cvalcie")) Then
            Else
                lvalidada = ds.Tables(0).Rows(0)("cvalcie")
            End If
        End If

        Return lvalidada
    End Function
    Public Function ObtenerOficinasdeRegion(ByVal ccodins As String, ByVal ccodofi As String, ByVal nnivel As Integer) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ccodofi, cnomofi  FROM tabtofi ")
        strSQL.Append("WHERE ccodins = @ccodins  ")

        If ccodofi = "001" Then
        Else
            strSQL.Append(" and cCodofi = @ccodofi ")
        End If
        strSQL.Append(" order by cnomofi ")

        Dim ds As New DataSet

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cCodins", SqlDbType.Char)
        args(0).Value = ccodins
        args(1) = New SqlParameter("@cCodofi", SqlDbType.Char)
        args(1).Value = ccodofi


        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function ObtenerRegiondeUsuario(ByVal ccodusu As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select tabtofi.ccodins from tabtofi , usuarios where tabtofi.ccodofi = usuarios.ccodofi ")
        strSQL.Append("and usuarios.usuario =@ccodusu group by ccodins ")

        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.Char)
        args(0).Value = ccodusu

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodins As String = "001"
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodins")) Then
            Else
                lccodins = ds.Tables(0).Rows(0)("ccodins")
            End If
        End If

        Return lccodins
    End Function
    Public Function ObtenerRegiondeOficina(ByVal ccodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("select tabtofi.ccodins from tabtofi  where tabtofi.ccodofi = @ccodofi ")

        Dim ds As New DataSet

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.Char)
        args(0).Value = ccodofi

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lccodins As String = "001"
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodins")) Then
            Else
                lccodins = ds.Tables(0).Rows(0)("ccodins")
            End If
        End If

        Return lccodins
    End Function
    Public Function ValidaEstadoAgencia(ByVal cCodofi As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cValCie,ccodofi FROM TABTOFI ")
        strSQL.Append("WHERE cCodofi = @ccodofi ")
        strSQL.Append(" and cValcie = '1'")

        Dim ds As New DataSet
        Dim lvalida2 As Boolean
        Dim lccValcie As String = "0"

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.Char)
        args(0).Value = cCodofi

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodofi")) Then
            Else
                lccValcie = Trim(ds.Tables(0).Rows(0)("ccodofi"))
            End If
        End If
        If lccValcie.Trim = "0" Then 'Disponible
            lvalida2 = True
        Else 'Bloquear
            lvalida2 = False
        End If
        Return lvalida2
    End Function
    Public Function ObtenerOficinaPrestamo(ByVal ccodcta As String) As String
        Dim lccodofi As String = "001"
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select coficina from cremcre where ccodcta ='" & ccodcta & "'"
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Oficina")
                For Each fila As DataRow In ds.Tables("Oficina").Rows
                    lccodofi = fila("coficina")
                Next
            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try
        End Using
        Return lccodofi
    End Function

    Public Function ObtenerNombreOficina(ByVal ccodofi As String) As String
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lcnomofi As String = ""

        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select coficina from cremcre where ccodofi ='" & ccodofi & "'"
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Oficina")
                For Each fila As DataRow In ds.Tables("Oficina").Rows
                    lcnomofi = fila("cnomofi")
                Next
            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try
        End Using
        Return lcnomofi
    End Function
End Class
