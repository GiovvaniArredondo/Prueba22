Imports System.Text
Public Class dbAhotlin
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahotlin
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.cnrolin =  "" _
            Or lEntidad.cnrolin = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.cnrolin = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ahotlin ")
        strSQL.Append(" SET ccodlin = @ccodlin, ") 
        strSQL.Append(" dfecvig = @dfecvig, ") 
        strSQL.Append(" cdeslin = @cdeslin, ") 
        strSQL.Append(" ntasint = @ntasint, ") 
        strSQL.Append(" ctipcal = @ctipcal, ") 
        strSQL.Append(" ntasmor = @ntasmor, ") 
        strSQL.Append(" nliminf = @nliminf, ") 
        strSQL.Append(" nlimsup = @nlimsup, ") 
        strSQL.Append(" lactiva = @lactiva, ") 
        strSQL.Append(" cnropar = @cnropar, ") 
        strSQL.Append(" nmonmin = @nmonmin, ") 
        strSQL.Append(" ctipdes = @ctipdes, ") 
        strSQL.Append(" ndesuso = @ndesuso, ") 
        strSQL.Append(" ccodusu = @ccodusu, ") 
        strSQL.Append(" nplainf = @nplainf, ") 
        strSQL.Append(" nplasup = @nplasup, ") 
        strSQL.Append(" lnegoc = @lnegoc, ")
        strSQL.Append(" cflag = @cflag, ") 
        strSQL.Append(" dfecmod = @dfecmod, ") 
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(19) As SqlParameter
        args(0) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodlin
        args(1) = New SqlParameter("@dfecvig", SqlDbType.Datetime)
        args(1).Value = lEntidad.dfecvig
        args(2) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(2).Value = lEntidad.cdeslin
        args(3) = New SqlParameter("@ntasint", SqlDbType.VarChar)
        args(3).Value = lEntidad.ntasint
        args(4) = New SqlParameter("@ctipcal", SqlDbType.VarChar)
        args(4).Value = lEntidad.ctipcal
        args(5) = New SqlParameter("@ntasmor", SqlDbType.VarChar)
        args(5).Value = lEntidad.ntasmor
        args(6) = New SqlParameter("@nliminf", SqlDbType.VarChar)
        args(6).Value = lEntidad.nliminf
        args(7) = New SqlParameter("@nlimsup", SqlDbType.VarChar)
        args(7).Value = lEntidad.nlimsup
        args(8) = New SqlParameter("@lactiva", SqlDbType.Bit)
        args(8).Value = IIf(lEntidad.lactiva = Nothing, DBNull.Value, lEntidad.lactiva)
        args(9) = New SqlParameter("@cnropar", SqlDbType.VarChar)
        args(9).Value = lEntidad.cnropar
        args(10) = New SqlParameter("@nmonmin", SqlDbType.VarChar)
        args(10).Value = lEntidad.nmonmin
        args(11) = New SqlParameter("@ctipdes", SqlDbType.VarChar)
        args(11).Value = lEntidad.ctipdes
        args(12) = New SqlParameter("@ndesuso", SqlDbType.VarChar)
        args(12).Value = lEntidad.ndesuso
        args(13) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(13).Value = lEntidad.ccodusu
        args(14) = New SqlParameter("@nplainf", SqlDbType.VarChar)
        args(14).Value = lEntidad.nplainf
        args(15) = New SqlParameter("@nplasup", SqlDbType.VarChar)
        args(15).Value = lEntidad.nplasup
        args(16) = New SqlParameter("@lnegoc", SqlDbType.Bit)
        args(16).Value = IIf(lEntidad.lnegoc = Nothing, DBNull.Value, lEntidad.lnegoc)
        args(17) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(17).Value = lEntidad.cflag
        args(18) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(18).Value = lEntidad.dfecmod
        args(19) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(19).Value = IIf(lEntidad.cnrolin = Nothing, DBNull.Value,lEntidad.cnrolin)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahotlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO ahotlin ")
        strSQL.Append(" ( cnrolin, ") 
        strSQL.Append(" ccodlin, ") 
        strSQL.Append(" dfecvig, ") 
        strSQL.Append(" cdeslin, ") 
        strSQL.Append(" ntasint, ") 
        strSQL.Append(" ctipcal, ") 
        strSQL.Append(" ntasmor, ") 
        strSQL.Append(" nliminf, ") 
        strSQL.Append(" nlimsup, ") 
        strSQL.Append(" lactiva, ") 
        strSQL.Append(" cnropar, ") 
        strSQL.Append(" nmonmin, ") 
        strSQL.Append(" ctipdes, ") 
        strSQL.Append(" ndesuso, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" nplainf, ") 
        strSQL.Append(" nplasup, ") 
        strSQL.Append(" lnegoc, ")
        strSQL.Append(" cflag, ") 
        strSQL.Append(" dfecmod) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @cnrolin, ") 
        strSQL.Append(" @ccodlin, ") 
        strSQL.Append(" @dfecvig, ") 
        strSQL.Append(" @cdeslin, ") 
        strSQL.Append(" @ntasint, ") 
        strSQL.Append(" @ctipcal, ") 
        strSQL.Append(" @ntasmor, ") 
        strSQL.Append(" @nliminf, ") 
        strSQL.Append(" @nlimsup, ") 
        strSQL.Append(" @lactiva, ") 
        strSQL.Append(" @cnropar, ") 
        strSQL.Append(" @nmonmin, ") 
        strSQL.Append(" @ctipdes, ") 
        strSQL.Append(" @ndesuso, ") 
        strSQL.Append(" @ccodusu, ") 
        strSQL.Append(" @nplainf, ") 
        strSQL.Append(" @nplasup, ") 
        strSQL.Append(" @lnegoc, ")
        strSQL.Append(" @cflag, ") 
        strSQL.Append(" @dfecmod) ")

        Dim args(19) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.cnrolin = Nothing, DBNull.Value, lEntidad.cnrolin)
        args(1) = New SqlParameter("@ccodlin", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodlin
        args(2) = New SqlParameter("@dfecvig", SqlDbType.Datetime)
        args(2).Value = lEntidad.dfecvig
        args(3) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(3).Value = lEntidad.cdeslin
        args(4) = New SqlParameter("@ntasint", SqlDbType.Decimal)
        args(4).Value = lEntidad.ntasint
        args(5) = New SqlParameter("@ctipcal", SqlDbType.VarChar)
        args(5).Value = lEntidad.ctipcal
        args(6) = New SqlParameter("@ntasmor", SqlDbType.Decimal)
        args(6).Value = lEntidad.ntasmor
        args(7) = New SqlParameter("@nliminf", SqlDbType.Decimal)
        args(7).Value = lEntidad.nliminf
        args(8) = New SqlParameter("@nlimsup", SqlDbType.Decimal)
        args(8).Value = lEntidad.nlimsup
        args(9) = New SqlParameter("@lactiva", SqlDbType.Bit)
        args(9).Value = IIf(lEntidad.lactiva = Nothing, DBNull.Value, lEntidad.lactiva)
        args(10) = New SqlParameter("@cnropar", SqlDbType.VarChar)
        args(10).Value = lEntidad.cnropar
        args(11) = New SqlParameter("@nmonmin", SqlDbType.Decimal)
        args(11).Value = lEntidad.nmonmin
        args(12) = New SqlParameter("@ctipdes", SqlDbType.VarChar)
        args(12).Value = lEntidad.ctipdes
        args(13) = New SqlParameter("@ndesuso", SqlDbType.Decimal)
        args(13).Value = lEntidad.ndesuso
        args(14) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(14).Value = lEntidad.ccodusu
        args(15) = New SqlParameter("@nplainf", SqlDbType.Decimal)
        args(15).Value = lEntidad.nplainf
        args(16) = New SqlParameter("@nplasup", SqlDbType.Decimal)
        args(16).Value = lEntidad.nplasup
        args(17) = New SqlParameter("@lnegoc", SqlDbType.Bit)
        args(17).Value = IIf(lEntidad.lnegoc = Nothing, DBNull.Value, lEntidad.lnegoc)
        args(18) = New SqlParameter("@cflag", SqlDbType.VarChar)
        args(18).Value = lEntidad.cflag
        args(19) = New SqlParameter("@dfecmod", SqlDbType.Datetime)
        args(19).Value = lEntidad.dfecmod

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahotlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM ahotlin ")
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As ahotlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cnrolin = @cnrolin ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnrolin", SqlDbType.VarChar)
        args(0).Value = lEntidad.cnrolin

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodlin = IIf(.Item("ccodlin") Is DBNull.Value, Nothing, .Item("ccodlin"))
                lEntidad.dfecvig = IIf(.Item("dfecvig") Is DBNull.Value, Nothing, .Item("dfecvig"))
                lEntidad.cdeslin = IIf(.Item("cdeslin") Is DBNull.Value, Nothing, .Item("cdeslin"))
                lEntidad.ntasint = IIf(.Item("ntasint") Is DBNull.Value, Nothing, .Item("ntasint"))
                lEntidad.ctipcal = IIf(.Item("ctipcal") Is DBNull.Value, Nothing, .Item("ctipcal"))
                lEntidad.ntasmor = IIf(.Item("ntasmor") Is DBNull.Value, Nothing, .Item("ntasmor"))
                lEntidad.nliminf = IIf(.Item("nliminf") Is DBNull.Value, Nothing, .Item("nliminf"))
                lEntidad.nlimsup = IIf(.Item("nlimsup") Is DBNull.Value, Nothing, .Item("nlimsup"))
                lEntidad.lactiva = IIf(.Item("lactiva") Is DBNull.Value, Nothing, .Item("lactiva"))
                lEntidad.cnropar = IIf(.Item("cnropar") Is DBNull.Value, Nothing, .Item("cnropar"))
                lEntidad.nmonmin = IIf(.Item("nmonmin") Is DBNull.Value, Nothing, .Item("nmonmin"))
                lEntidad.ctipdes = IIf(.Item("ctipdes") Is DBNull.Value, Nothing, .Item("ctipdes"))
                lEntidad.ndesuso = IIf(.Item("ndesuso") Is DBNull.Value, Nothing, .Item("ndesuso"))
                lEntidad.ccodusu = IIf(.Item("ccodusu") Is DBNull.Value, Nothing, .Item("ccodusu"))
                lEntidad.nplainf = IIf(.Item("nplainf") Is DBNull.Value, Nothing, .Item("nplainf"))
                lEntidad.nplasup = IIf(.Item("nplasup") Is DBNull.Value, Nothing, .Item("nplasup"))
                lEntidad.lnegoc = IIf(.Item("lnegoc") Is DBNull.Value, Nothing, .Item("lnegoc"))
                lEntidad.cflag = IIf(.Item("cflag") Is DBNull.Value, Nothing, .Item("cflag"))
                lEntidad.dfecmod = IIf(.Item("dfecmod") Is DBNull.Value, Nothing, .Item("dfecmod"))
                lEntidad.ntasmax = IIf(.Item("ntasmax") Is DBNull.Value, Nothing, .Item("ntasmax"))
                lEntidad.ntasmin = IIf(.Item("ntasmin") Is DBNull.Value, Nothing, .Item("ntasmin"))

            End With
        Catch ex As Exception 
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As ahotlin
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(cnrolin),0) + 1 ")
        strSQL.Append(" FROM ahotlin ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listaahotlin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listaahotlin

        Try
            Do While dr.Read()
                Dim mEntidad As New ahotlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmonmin = IIf(dr("nmonmin") Is DBNull.Value, Nothing, dr("nmonmin"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nplainf = IIf(dr("nplainf") Is DBNull.Value, Nothing, dr("nplainf"))
                mEntidad.nplasup = IIf(dr("nplasup") Is DBNull.Value, Nothing, dr("nplasup"))
                mEntidad.lnegoc = IIf(dr("lnegoc") Is DBNull.Value, Nothing, dr("lnegoc"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaPorID_() As listaahotlin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" Where substring(ccodlin,4,2)  = '07' and lactiva = 1")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaahotlin

        Try
            Do While dr.Read()
                Dim mEntidad As New ahotlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmonmin = IIf(dr("nmonmin") Is DBNull.Value, Nothing, dr("nmonmin"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nplainf = IIf(dr("nplainf") Is DBNull.Value, Nothing, dr("nplainf"))
                mEntidad.nplasup = IIf(dr("nplasup") Is DBNull.Value, Nothing, dr("nplasup"))
                mEntidad.lnegoc = IIf(dr("lnegoc") Is DBNull.Value, Nothing, dr("lnegoc"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function ObtenerListaTodos() As listaahotlin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" Where substring(ccodlin,4,2)  = '07' ")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaahotlin

        Try
            Do While dr.Read()
                Dim mEntidad As New ahotlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmonmin = IIf(dr("nmonmin") Is DBNull.Value, Nothing, dr("nmonmin"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nplainf = IIf(dr("nplainf") Is DBNull.Value, Nothing, dr("nplainf"))
                mEntidad.nplasup = IIf(dr("nplasup") Is DBNull.Value, Nothing, dr("nplasup"))
                mEntidad.lnegoc = IIf(dr("lnegoc") Is DBNull.Value, Nothing, dr("lnegoc"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
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
        tables(0) = New String("ahotlin")

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.Append(" SELECT cnrolin, ") 
        strSQL.Append(" ccodlin, ") 
        strSQL.Append(" dfecvig, ") 
        strSQL.Append(" cdeslin, ") 
        strSQL.Append(" ntasint, ") 
        strSQL.Append(" ctipcal, ") 
        strSQL.Append(" ntasmor, ") 
        strSQL.Append(" nliminf, ") 
        strSQL.Append(" nlimsup, ") 
        strSQL.Append(" lactiva, ") 
        strSQL.Append(" cnropar, ") 
        strSQL.Append(" nmonmin, ") 
        strSQL.Append(" ctipdes, ") 
        strSQL.Append(" ndesuso, ") 
        strSQL.Append(" ccodusu, ") 
        strSQL.Append(" nplainf, ") 
        strSQL.Append(" nplasup, ") 
        strSQL.Append(" lnegoc, ") 
        strSQL.Append(" cflag, ") 
        strSQL.Append(" dfecmod, ntasmax, ntasmin ")
        strSQL.Append(" FROM ahotlin ")



    End Sub

    Public Function ObtieneLineaAhorro(ByVal ctipo As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cnrolin FROM AHOTLIN ")
        strSQL.Append("WHERE substring(ahotlin.ccodlin,4,2) = @ctipo ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ctipo", SqlDbType.VarChar)
        args(0).Value = ctipo

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lcnrolin As String = ""

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("cnrolin")) Then
            Else
                lcnrolin = ds.Tables(0).Rows(0)("cnrolin")
            End If
        End If
        Return lcnrolin
    End Function


    Public Function ObtieneLineaAhorro_ID(ByVal cdeslin As String) As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT cnrolin FROM AHOTLIN ")
        strSQL.Append("WHERE cdescri like %" & cdeslin & "%")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cdeslin", SqlDbType.VarChar)
        args(0).Value = cdeslin

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    Public Function ObtenerLista_PorTipo(ByVal ctipAho As String) As listaahotlin

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" Where substring(ccodlin,4,2) ='" & ctipAho & "'")

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaahotlin

        Try
            Do While dr.Read()
                Dim mEntidad As New ahotlin
                mEntidad.cnrolin = IIf(dr("cnrolin") Is DBNull.Value, Nothing, dr("cnrolin"))
                mEntidad.ccodlin = IIf(dr("ccodlin") Is DBNull.Value, Nothing, dr("ccodlin"))
                mEntidad.dfecvig = IIf(dr("dfecvig") Is DBNull.Value, Nothing, dr("dfecvig"))
                mEntidad.cdeslin = IIf(dr("cdeslin") Is DBNull.Value, Nothing, dr("cdeslin"))
                mEntidad.ntasint = IIf(dr("ntasint") Is DBNull.Value, Nothing, dr("ntasint"))
                mEntidad.ctipcal = IIf(dr("ctipcal") Is DBNull.Value, Nothing, dr("ctipcal"))
                mEntidad.ntasmor = IIf(dr("ntasmor") Is DBNull.Value, Nothing, dr("ntasmor"))
                mEntidad.nliminf = IIf(dr("nliminf") Is DBNull.Value, Nothing, dr("nliminf"))
                mEntidad.nlimsup = IIf(dr("nlimsup") Is DBNull.Value, Nothing, dr("nlimsup"))
                mEntidad.lactiva = IIf(dr("lactiva") Is DBNull.Value, Nothing, dr("lactiva"))
                mEntidad.cnropar = IIf(dr("cnropar") Is DBNull.Value, Nothing, dr("cnropar"))
                mEntidad.nmonmin = IIf(dr("nmonmin") Is DBNull.Value, Nothing, dr("nmonmin"))
                mEntidad.ctipdes = IIf(dr("ctipdes") Is DBNull.Value, Nothing, dr("ctipdes"))
                mEntidad.ndesuso = IIf(dr("ndesuso") Is DBNull.Value, Nothing, dr("ndesuso"))
                mEntidad.ccodusu = IIf(dr("ccodusu") Is DBNull.Value, Nothing, dr("ccodusu"))
                mEntidad.nplainf = IIf(dr("nplainf") Is DBNull.Value, Nothing, dr("nplainf"))
                mEntidad.nplasup = IIf(dr("nplasup") Is DBNull.Value, Nothing, dr("nplasup"))
                mEntidad.lnegoc = IIf(dr("lnegoc") Is DBNull.Value, Nothing, dr("lnegoc"))
                mEntidad.cflag = IIf(dr("cflag") Is DBNull.Value, Nothing, dr("cflag"))
                mEntidad.dfecmod = IIf(dr("dfecmod") Is DBNull.Value, Nothing, dr("dfecmod"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function


    Public Function Extraer_Lineas_Producto(ByVal producto As String) As DataSet

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Lin As New DataSet


        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            command.Connection = connection


            Try



                command.CommandText = _
                                        " Select * from ahotlin Where SUBSTRING(ccodlin,4,2) = '" & producto & "'" & _
                                        " and lactiva = 1 "

                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Lin, "Lineas")




            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try

        End Using


        Return ds_Lin



    End Function


    Public Function Mantenimiento_Lineas(ByVal array_d As ArrayList) As Integer

        Dim lnRetorno As Integer = 0
        Dim _sql As String = ""
        Dim MyAdapter As New SqlDataAdapter
        Dim command As New SqlCommand
        Dim ds_Lin As New DataSet
        Dim Mytransaccion As SqlTransaction
        Dim pcnrolin As String = ""
        Dim pnrolin As Integer

        'array_d.Item(0)  ' No Linea
        'array_d.Item(1)  ' Codigo de Linea
        'array_d.Item(2)  ' Fecha de Linea
        'array_d.Item(3)  ' Tasa Minima
        'array_d.item(4)  ' Tasa Maxima
        'array_d.item(5)  ' Monto Minimo
        'array_d.item(6)  ' Monto Maximo
        'array_d.item(7)  ' Plazo Minimo
        'array_d.item(8)  ' Plazo Maximo
        'array_d.item(9)  ' Estado de Linea
        'array_d.item(10) ' Descripción de Linea
        'array_d.item(11) ' Fecha de Modificación
        'array_d.item(12) ' Usuario
        'array_d.item(13) ' Tasa fija para ahorro distinto a plazo




        Using connection As New SqlConnection(Me.cnnStr)
            connection.Open()
            Mytransaccion = connection.BeginTransaction("Mytransaccion")

            command.Connection = connection
            command.Transaction = Mytransaccion

            Try


                If array_d.Item(0).trim = "" Then  'Nueva Linea


                    command.CommandText = _
                                            " Select isnull(max(cnrolin),1) as cnrolin from ahotlin "

                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Lin, "Codigo_Linea")

                    For Each fila As DataRow In ds_Lin.Tables("Codigo_Linea").Rows
                        pcnrolin = fila("cnrolin").ToString
                        pnrolin = Integer.Parse(pcnrolin) + 100
                        pcnrolin = pnrolin.ToString
                        pcnrolin = pcnrolin.PadLeft(10, "0")
                        pcnrolin = Right(pcnrolin, 7)
                    Next


                    'Verifica si el codigo de linea no Existe
                    command.CommandText = _
                                           " Select * from ahotlin " & _
                                           " Where cCodlin ='" & array_d.Item(1) & "' and " & _
                                           " ntasmin =" & array_d.Item(3) & " and ntasmax =" & array_d.Item(4) & " and " & _
                                           " nliminf =" & array_d.Item(5) & " and nlimsup =" & array_d.Item(6) & " and " & _
                                           " nplainf =" & array_d.Item(7) & " and nplasup = " & array_d.Item(8)


                    command.CommandType = CommandType.Text

                    MyAdapter.SelectCommand = command

                    MyAdapter.Fill(ds_Lin, "Lineas")

                    If ds_Lin.Tables("Lineas").Rows.Count > 0 Then
                        lnRetorno = 2
                    Else

                        array_d.Item(0) = pcnrolin

                        command.CommandText = _
                                                " insert into ahotlin (cnrolin, ccodlin, dfecvig, cdeslin, ntasint, ntasmin, ntasmax, ctipcal, " & _
                                                " ntasmor, nliminf, nlimsup, lactiva, cnropar, nmonmin, ctipdes, ndesuso, " & _
                                                " nplainf, nplasup, lnegoc, cflag, ccodusu, dfecmod) " & _
                                                " Values('" & array_d.Item(0) & "','" & array_d.Item(1) & "','" & array_d.Item(2) & "','" & _
                                                array_d.Item(10) & "'," & array_d.Item(13) & "," & array_d.Item(3) & "," & array_d.Item(4) & ",'',0," & array_d.Item(5) & "," & _
                                                array_d.Item(6) & "," & array_d.Item(9) & ",'',0,'',0," & array_d.Item(7) & "," & array_d.Item(8) & _
                                                ",0,'','" & array_d.Item(12) & "','" & array_d.Item(11) & "')"

                        command.ExecuteNonQuery()

                        lnRetorno = 1

                    End If

                Else                                      'Modificación

                    command.CommandText = _
                                             " Update ahotlin set ccodlin ='" & array_d.Item(1) & "', cdeslin ='" & array_d.Item(10) & "'," & _
                                             " ntasmin =" & array_d.Item(3) & ", ntasmax =" & array_d.Item(4) & ", nliminf =" & array_d.Item(5) & "," & _
                                             " nlimsup =" & array_d.Item(6) & ", lactiva =" & array_d.Item(9) & " , nplainf =" & array_d.Item(7) & "," & _
                                             " nplasup =" & array_d.Item(8) & ", dfecmod ='" & array_d.Item(11) & "', ccodusu ='" & array_d.Item(12) & "'," & _
                                             " ntasint =" & array_d.Item(13) & _
                                             " Where cnrolin ='" & array_d.Item(0) & "'"


                    command.ExecuteNonQuery()

                    lnRetorno = 1

                End If


                Mytransaccion.Commit()

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
                Mytransaccion.Rollback()
            Finally
                connection.Close()
            End Try

        End Using


        Return lnRetorno



    End Function
End Class
