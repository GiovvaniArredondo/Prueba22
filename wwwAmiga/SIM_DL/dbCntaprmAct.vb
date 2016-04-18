Imports System.Text
Public Class dbcntaprmAct
    Inherits dbBase
    Private _cfondo As String
    Public Property cfondo() As String
        Get
            Return _cfondo
        End Get
        Set(ByVal Value As String)
            _cfondo = Value
        End Set
    End Property
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaprmAct
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cmesvig = "" _
            Or lEntidad.cmesvig = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cmesvig = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntaprmAct ")
        strSQL.Append(" SET nbasdia = @nbasdia, ")
        strSQL.Append(" ntasmin = @ntasmin, ")
        strSQL.Append(" ntasame = @ntasame, ")
        strSQL.Append(" ntasama = @ntasama, ")
        strSQL.Append(" ccierre = @ccierre, ")
        strSQL.Append(" dfecimes = @dfecimes, ")
        strSQL.Append(" dfecfmes = @dfecfmes, ")
        strSQL.Append(" dfecmod = @dfecmod, ")
        strSQL.Append(" ccodusu = @ccodusu, ")
        strSQL.Append(" cflc = @cflc, ")
        strSQL.Append(" nfln = @nfln ")
        strSQL.Append(" WHERE cmesvig = @cmesvig ")

        Dim args(12) As SqlParameter
        args(0) = New SqlParameter("@nbasdia", SqlDbType.VarChar)
        args(0).Value = lEntidad.nbasdia
        args(1) = New SqlParameter("@ntasmin", SqlDbType.VarChar)
        args(1).Value = lEntidad.ntasmin
        args(2) = New SqlParameter("@ntasame", SqlDbType.VarChar)
        args(2).Value = lEntidad.ntasame
        args(3) = New SqlParameter("@ntasama", SqlDbType.VarChar)
        args(3).Value = lEntidad.ntasama
        args(4) = New SqlParameter("@ccierre", SqlDbType.VarChar)
        args(4).Value = lEntidad.ccierre
        args(5) = New SqlParameter("@dfecimes", SqlDbType.DateTime)
        args(5).Value = lEntidad.dfecimes
        args(6) = New SqlParameter("@dfecfmes", SqlDbType.DateTime)
        args(6).Value = lEntidad.dfecfmes
        args(7) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecmod
        args(8) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(8).Value = lEntidad.ccodusu
        args(9) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(9).Value = lEntidad.cflc
        args(10) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(10).Value = lEntidad.nfln
        args(11) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(11).Value = IIf(lEntidad.cmesvig = Nothing, DBNull.Value, lEntidad.cmesvig)

        If lEntidad.cflc = "99" Then
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteNonQuery(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaprmAct
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO cntaprmAct ")
        strSQL.Append(" ( cmesvig, ")
        strSQL.Append(" nbasdia, ")
        strSQL.Append(" ntasmin, ")
        strSQL.Append(" ntasame, ")
        strSQL.Append(" ntasama, ")
        strSQL.Append(" ccierre, ")
        strSQL.Append(" dfecimes, ")
        strSQL.Append(" dfecfmes, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" nfln, ccierre2) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cmesvig, ")
        strSQL.Append(" @nbasdia, ")
        strSQL.Append(" @ntasmin, ")
        strSQL.Append(" @ntasame, ")
        strSQL.Append(" @ntasama, ")
        strSQL.Append(" @ccierre, ")
        strSQL.Append(" @dfecimes, ")
        strSQL.Append(" @dfecfmes, ")
        strSQL.Append(" @dfecmod, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @cflc, ")
        strSQL.Append(" @nfln, ")
        strSQL.Append(" @ccierre2) ")

        Dim args(13) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cmesvig = Nothing, DBNull.Value, lEntidad.cmesvig)
        args(1) = New SqlParameter("@nbasdia", SqlDbType.VarChar)
        args(1).Value = lEntidad.nbasdia
        args(2) = New SqlParameter("@ntasmin", SqlDbType.VarChar)
        args(2).Value = lEntidad.ntasmin
        args(3) = New SqlParameter("@ntasame", SqlDbType.VarChar)
        args(3).Value = lEntidad.ntasame
        args(4) = New SqlParameter("@ntasama", SqlDbType.VarChar)
        args(4).Value = lEntidad.ntasama
        args(5) = New SqlParameter("@ccierre", SqlDbType.VarChar)
        args(5).Value = lEntidad.ccierre
        args(6) = New SqlParameter("@dfecimes", SqlDbType.DateTime)
        args(6).Value = lEntidad.dfecimes
        args(7) = New SqlParameter("@dfecfmes", SqlDbType.DateTime)
        args(7).Value = lEntidad.dfecfmes
        args(8) = New SqlParameter("@dfecmod", SqlDbType.DateTime)
        args(8).Value = lEntidad.dfecmod
        args(9) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(9).Value = lEntidad.ccodusu
        args(10) = New SqlParameter("@cflc", SqlDbType.VarChar)
        args(10).Value = lEntidad.cflc
        args(11) = New SqlParameter("@nfln", SqlDbType.VarChar)
        args(11).Value = lEntidad.nfln
        args(12) = New SqlParameter("@ccierre2", SqlDbType.VarChar)
        args(12).Value = lEntidad.ccierre
        If lEntidad.cflc = "99" Then
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteNonQuery(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaprmAct
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM cntaprmAct ")
        strSQL.Append(" WHERE cmesvig = @cmesvig ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = lEntidad.cmesvig

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As cntaprmAct
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cmesvig = @cmesvig ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = lEntidad.cmesvig

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.nbasdia = IIf(.Item("nbasdia") Is DBNull.Value, Nothing, .Item("nbasdia"))
                lEntidad.ntasmin = IIf(.Item("ntasmin") Is DBNull.Value, Nothing, .Item("ntasmin"))
                lEntidad.ntasame = IIf(.Item("ntasame") Is DBNull.Value, Nothing, .Item("ntasame"))
                lEntidad.ntasama = IIf(.Item("ntasama") Is DBNull.Value, Nothing, .Item("ntasama"))
                lEntidad.ccierre = IIf(.Item("ccierre") Is DBNull.Value, Nothing, .Item("ccierre"))
                lEntidad.dfecimes = IIf(.Item("dfecimes") Is DBNull.Value, Nothing, .Item("dfecimes"))
                lEntidad.dfecfmes = IIf(.Item("dfecfmes") Is DBNull.Value, Nothing, .Item("dfecfmes"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.cflc = IIf(.Item("cflc") Is DBNull.Value, Nothing, .Item("cflc"))
                lEntidad.nfln = IIf(.Item("nfln") Is DBNull.Value, Nothing, .Item("nfln"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As cntaprmAct
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cmesvig),0) + 1 ")
        strSQL.Append(" FROM cntaprmAct ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listacntaprmAct

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listacntaprmAct

        Try
            Do While dr.Read()
                Dim mEntidad As New cntaprmAct
                mEntidad.cmesvig = IIf(dr("cmesvig") Is DBNull.Value, Nothing, dr("cmesvig"))
                mEntidad.nbasdia = IIf(dr("nbasdia") Is DBNull.Value, Nothing, dr("nbasdia"))
                mEntidad.ntasmin = IIf(dr("ntasmin") Is DBNull.Value, Nothing, dr("ntasmin"))
                mEntidad.ntasame = IIf(dr("ntasame") Is DBNull.Value, Nothing, dr("ntasame"))
                mEntidad.ntasama = IIf(dr("ntasama") Is DBNull.Value, Nothing, dr("ntasama"))
                mEntidad.ccierre = IIf(dr("ccierre") Is DBNull.Value, Nothing, dr("ccierre"))
                mEntidad.dfecimes = IIf(dr("dfecimes") Is DBNull.Value, Nothing, dr("dfecimes"))
                mEntidad.dfecfmes = IIf(dr("dfecfmes") Is DBNull.Value, Nothing, dr("dfecfmes"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.cflc = IIf(dr("cflc") Is DBNull.Value, Nothing, dr("cflc"))
                mEntidad.nfln = IIf(dr("nfln") Is DBNull.Value, Nothing, dr("nfln"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorIDyear() As listacntaprmAct

        Dim strSQL As New StringBuilder
        Dim lcfondo As String
        lcfondo = Me.cfondo

        strSQL.Append(" SELECT cmesvig, left(cmesvig,4) as año ")
        strSQL.Append(" FROM cntaprmAct order by cmesvig desc ")

        Dim dr As SqlDataReader
        If lcfondo = "99" Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            dr = sql.ExecuteReader(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Dim lista As New listacntaprmAct

        Try
            Do While dr.Read()
                Dim mEntidad As New cntaprmAct
                mEntidad.cmesvig = IIf(dr("cmesvig") Is DBNull.Value, Nothing, dr("cmesvig"))
                mEntidad.año = IIf(dr("año") Is DBNull.Value, Nothing, dr("año"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerDataSetPorID(ByVal ccodigo As String, ByVal ccadena As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCierre = " & "'" & "N" & "'")

        Dim ds As DataSet

        'If ccodigo.Trim = "99" Then
        '    If ccadena.Trim = "" Then
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        '    Else
        'ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
        '    End If
        'Else
        'If ccadena.Trim = "" Then
        '    ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
        'Else
        '    ds = sql.ExecuteDataset(ccadena, CommandType.Text, strSQL.ToString())
        'End If

        'End If


        Return ds

    End Function
    Public Function ObtenerDataSetPorID2(ByVal cfondo As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cCierre = " & "'" & "N" & "'")

        Dim ds As DataSet

        If cfondo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If

        Return ds

    End Function
    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("cntaprmAct")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT cmesvig, ")
        strSQL.Append(" nbasdia, ")
        strSQL.Append(" ntasmin, ")
        strSQL.Append(" ntasame, ")
        strSQL.Append(" ntasama, ")
        strSQL.Append(" ccierre, ")
        strSQL.Append(" dfecimes, ")
        strSQL.Append(" dfecfmes, ")
        strSQL.Append(" dfecmod, ")
        strSQL.Append(" ccodusu, ")
        strSQL.Append(" cflc, ")
        strSQL.Append(" nfln ")
        strSQL.Append(" FROM cntaprmAct ")

    End Sub

    Public Function ObtenerMestoClose(ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select dfecini, dfecfin, cmesvig FROM ctbCierre WHERE cCierre='N'")

        Dim ds As DataSet
        If ccodigo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If
        Return ds

    End Function

    Public Function CierreMes(ByVal pcmesvig As String, ByVal ccodigo As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ctbCierre set cCierre = 'S' WHERE cmesvig = @cmesvig ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = pcmesvig
        If ccodigo.Trim = "99" Then
            Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteScalar(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function


    Public Function AbreMes(ByVal pcmesvig As String, ByVal pdfecini As Date, ByVal pdfecfin As Date, ByVal pccodusu As String, ByVal ccodigo As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("insert into ctbCierre(cmesvig, ccierre, dfecini, dfecfin, dfecmod, ccodusu) ")
        strSQL.Append("values(@cmesvig, 'N', @dfecini, @dfecfin, getdate(), @ccodusu) ")

        Dim args(3) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = pcmesvig
        args(1) = New SqlParameter("@dfecini", SqlDbType.DateTime)
        args(1).Value = pdfecini
        args(2) = New SqlParameter("@dfecfin", SqlDbType.DateTime)
        args(2).Value = pdfecfin
        args(3) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(3).Value = pccodusu

        If ccodigo.Trim = "99" Then
            Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteScalar(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

    Public Function ObtenerfiscaltoClose(ByVal ccodigo As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select dfecimes, dfecfmes, cmesvig FROM cntaprmAct WHERE cCierre='N'")

        Dim ds As DataSet
        If ccodigo.Trim = "99" Then
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Else
            ds = sql.ExecuteDataset(Me.gcnnString, CommandType.Text, strSQL.ToString())
        End If


        Return ds

    End Function


    Public Function ObtenerDataSetPoryear(ByVal cyear As String) As DataSet

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE left(cmesvig,4) = @cyear ")

        Dim ds As New DataSet
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cyear", SqlDbType.VarChar)
        args(0).Value = cyear

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


        Return ds

    End Function
    Public Function CierreMesACt(ByVal pcmesvig As String, ByVal ccodigo As String, ByVal ccodusu As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE cntaprmAct set cCierre = 'S',cCierre2 ='S',ccodusu= @ccodusu,dfecmod = getdate() WHERE cmesvig = @cmesvig and cCierre = 'N'  ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = pcmesvig
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu



        If ccodigo.Trim = "99" Then
            Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteScalar(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function
    Public Function AbreMesAct(ByVal pcmesvig As String, ByVal ldfecini As Date, ByVal ldfecfin As Date, ByVal ccodusu As String, ByVal ccodigo As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("insert into cntaprmAct(cmesvig,nbasdia,ntasmin,ntasame,ntasama,ccierre,dfecimes,dfecfmes,dfecmod,ccodusu,cflc,nfln,ccierre2)  ")
        strSQL.Append("values(@cmesvig,0.00,0.00,0.00,0.00,'N',@ldfecini,@ldfecfin,getdate(),@ccodusu,' ' , 0.00 ,'N' ) ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@cmesvig", SqlDbType.VarChar)
        args(0).Value = pcmesvig
        args(1) = New SqlParameter("@ldfecini", SqlDbType.DateTime)
        args(1).Value = ldfecini
        args(2) = New SqlParameter("@ldfecfin", SqlDbType.DateTime)
        args(2).Value = ldfecfin
        args(3) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(3).Value = ccodusu

        If ccodigo.Trim = "99" Then
            Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Else
            Return sql.ExecuteScalar(Me.gcnnString, CommandType.Text, strSQL.ToString(), args)
        End If


    End Function

End Class
