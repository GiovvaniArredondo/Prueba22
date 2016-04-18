Imports System.Text
Public Class dbActivoM
    Inherits dbBase
    Public Overrides Function Actualizar(ByVal aEntidad As EL.entidadBase) As Integer
        Dim lEntidad As ActivoM
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.ccodinv = "" _
            Or lEntidad.ccodinv = Nothing Then

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.ccodinv = lID

            Return Agregar(lEntidad)
        End If
        Dim strSQL As New StringBuilder
        strSQL.Append("update ActivoMov ")
        strSQL.Append(" set ccodinv=@ccodinv, ")
        strSQL.Append(" usuario=@ccodusu, ")
        strSQL.Append(" ccodofi=@ccodofi, ")
        strSQL.Append(" dfectra=@dfectra,  ")
        strSQL.Append(" cestado=@cestado ")
        strSQL.Append(" Where ccodinv=@ccodinv ")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodusu
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodofi
        args(3) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfectra
        args(4) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(4).Value = lEntidad.cestado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer
        Dim lEntidad As ActivoM
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ActivoMov ")
        strSQL.Append(" ( ccodinv, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" dfectra, ")
        strSQL.Append(" cestado ) ")


        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodinv, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @dfectra, ")
        strSQL.Append(" @cestado )")


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = lEntidad.ccodinv
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = lEntidad.ccodusu
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = lEntidad.ccodofi
        args(3) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(3).Value = lEntidad.dfectra
        args(4) = New SqlParameter("@cestado", SqlDbType.VarChar)
        args(4).Value = lEntidad.cestado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Overrides Function Eliminar(ByVal aEntidad As EL.entidadBase) As Integer

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As EL.entidadBase) As Long

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As EL.entidadBase) As Integer
        Dim lEntidad As New ActivoM

        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append(" Select ccodinv, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" ccodofi ")
        strSQL.Append(" From ActivoMov ")
        strSQL.Append(" Where ccodinv=@ccodinv ")
        strSQL.Append(" ORDER by dfectra desc ")

        'strSQL.Append(" Where ccodinv=@ccodinv And cestado = '1' ")

        Dim args(0) As SqlParameter

        args(0) = New SqlParameter("@ccodinv", SqlDbType.Char)
        args(0).Value = lEntidad.ccodinv

        Dim dsDatos As New DataSet
        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.ccodinv = IIf(.Item("ccodinv") Is DBNull.Value, Nothing, .Item("ccodinv"))
                lEntidad.ccodusu = IIf(.Item("usuario") Is DBNull.Value, Nothing, .Item("usuario"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
            End With
        Catch ex As Exception
            Throw ex
        End Try
        Return 1

    End Function

    Public Function DatasetActivoM() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT ccodinv, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" dfectra, ")
        strSQL.Append(" cestado  ")
        strSQL.Append(" FROM ActivoM ")
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function

    Public Function Trasladar(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String, ByVal dfectra As DateTime, ByVal cestado As String)
        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ActivoMov ")
        strSQL.Append(" ( ccodinv, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" dfectra, ")
        strSQL.Append(" cestado) ")

        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodinv, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @dfectra, ")
        strSQL.Append(" @cestado )")


        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = ccodinv
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi
        args(3) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(3).Value = dfectra
        args(4) = New SqlParameter("@cestado", SqlDbType.Char)
        args(4).Value = cestado
        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function DescargarActivo(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String, ByVal dfectra As DateTime, ByVal cestado As String)
        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO ActivoMov ")
        strSQL.Append(" ( ccodinv, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" dfectra, ")
        strSQL.Append(" cestado )")

        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @ccodinv, ")
        strSQL.Append(" @ccodusu, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @dfectra, ")
        strSQL.Append(" @cestado )")

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = ccodinv
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi
        args(3) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(3).Value = dfectra
        args(4) = New SqlParameter("@cestado", SqlDbType.Char)
        args(4).Value = cestado

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function ActualizaActivoDescargado(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String)
        'aqui actualiza el estado del activo que fue descargado y le pone un cestado de 4 para llevar 
        'un control de los activos del usuario

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE ActivoMov ")
        strSQL.Append(" Set ")
        strSQL.Append(" cestado = '3' ")

        strSQL.Append(" Where ")
        strSQL.Append(" ccodinv = @ccodinv And ")
        strSQL.Append(" usuario = @ccodusu And ")
        strSQL.Append(" ccodofi = @ccodofi And ")
        strSQL.Append(" cestado = '1' ")

        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = ccodinv.Trim
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu.Trim
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi.Trim

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function

    Public Function ConsultaActivoDescargado(ByVal ccodinv As String, ByVal ccodusu As String, ByVal ccodofi As String, ByVal dfectra As DateTime, ByVal cestado As String, ByVal nserie As Integer) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT ")
        strSQL.Append(" ACTIVOMOV.CCODINV, ")
        strSQL.Append(" ACTIVOMOV.DFECTRA, ")
        strSQL.Append(" ACTIVOF.CDESBIEN, ")
        strSQL.Append(" ACTIVOF.NVALCPA,")
        strSQL.Append(" TABTOFI.CNOMOFI, ")
        strSQL.Append(" USUARIOS.NOMBRE, ")
        strSQL.Append(" USUARIOS.IDUSUARIO, ")
        strSQL.Append(" USUARIOGRUPO.IDGRUPO,")
        strSQL.Append(" GRUPOS.GRUPO ")
        If nserie = 1 Then
            strSQL.Append(" , ACTIVOIT.CNSERIE ")
        End If

        strSQL.Append(" FROM ACTIVOMOV, ")
        strSQL.Append(" ACTIVOF, ")
        strSQL.Append(" TABTOFI, ")
        strSQL.Append(" USUARIOS, ")
        strSQL.Append(" USUARIOGRUPO, ")
        strSQL.Append(" GRUPOS ")

        If nserie = 1 Then
            strSQL.Append(" ,ACTIVOIT ")
        End If

        strSQL.Append(" WHERE ")
        strSQL.Append(" ACTIVOF.CCODINV=@CCODINV AND ")
        strSQL.Append(" TABTOFI.CCODOFI=ACTIVOMOV.CCODOFI AND ")
        strSQL.Append(" USUARIOS.USUARIO=ACTIVOMOV.USUARIO AND ")
        strSQL.Append(" ACTIVOMOV.CESTADO=@CESTADO AND  ")
        strSQL.Append(" ACTIVOMOV.USUARIO=@CCODUSU AND ")
        strSQL.Append(" ACTIVOMOV.DFECTRA=@DFECTRA AND ")
        strSQL.Append(" USUARIOGRUPO.IDUSUARIO=USUARIOS.IDUSUARIO  ")
        strSQL.Append(" AND GRUPOS.IDGRUPO=USUARIOGRUPO.IDGRUPO ")

        If nserie = 1 Then
            strSQL.Append(" AND ACTIVOIT.CCODINV=ACTIVOMOV.CCODINV ")
        End If

        Dim args(4) As SqlParameter
        args(0) = New SqlParameter("@ccodinv", SqlDbType.VarChar)
        args(0).Value = ccodinv
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu
        args(2) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(2).Value = ccodofi
        args(3) = New SqlParameter("@dfectra", SqlDbType.DateTime)
        args(3).Value = dfectra
        args(4) = New SqlParameter("@cestado", SqlDbType.Char)
        args(4).Value = cestado

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Public Function BuscaActivosEmpleado(ByVal ccodusu As String) As DataSet
        Dim strSQL As New StringBuilder

        strSQL.Append(" SELECT ")
        strSQL.Append(" ACTIVOF.CCODINV, ")
        strSQL.Append(" ACTIVOF.CDESBIEN, ")
        strSQL.Append(" ACTIVOF.FFONDOS, ")
        strSQL.Append(" ACTIVOF.DFECADQ, ")
        strSQL.Append(" ACTIVOF.NACTDEP, ")
        strSQL.Append(" ACTIVOF.NVALCPA, ")
        strSQL.Append(" ACTIVOF.NVIDUTI, ")
        strSQL.Append(" ACTIVOF.CCODACT, ")
        strSQL.Append(" ACTIVOF.CCODSEC, ")
        strSQL.Append(" ACTIVOF.DFECDEP, ")
        strSQL.Append(" ACTIVOF.NVALNO, ")
        strSQL.Append(" ACTIVOMOV.DFECTRA,")
        strSQL.Append(" ACTIVOMOV.CCODOFI, ")
        strSQL.Append(" TABTOFI.CNOMOFI, ")
        strSQL.Append(" USUARIOS.NOMBRE, ")
        strSQL.Append(" USUARIOS.IDUSUARIO, ")
        strSQL.Append(" ' ' as cnserie, ' ' as cmodelo,")
        strSQL.Append(" 000000.00 as depanual, ")
        strSQL.Append(" 000000.00 as depmen, ")
        strSQL.Append(" 000000.00 as depmenno, ")
        strSQL.Append(" 000000.00 as depacum, ")
        strSQL.Append(" 000000.00 as depmende, ")
        strSQL.Append(" space(1) as ctipo, USUARIOS.CARGO ")

        strSQL.Append(" FROM ")
        strSQL.Append(" ACTIVOF, ")
        strSQL.Append(" ACTIVOMOV, ")
        strSQL.Append(" TABTOFI, ")
        strSQL.Append(" USUARIOS ")
    

        strSQL.Append(" WHERE ")
        strSQL.Append(" ACTIVOMOV.CCODINV=ACTIVOF.CCODINV AND ")
        strSQL.Append(" ACTIVOF.CCODEMP=@CCODUSU AND ")
        strSQL.Append(" ACTIVOMOV.USUARIO=Activof.ccodusu  AND  ")
        strSQL.Append(" Activof.ccodemp=USUARIOS.USUARIO AND ")
        strSQL.Append(" ACTIVOMOV.CCODOFI=TABTOFI.CCODOFI  ")
 

        strSQL.Append(" UNION ")

        strSQL.Append(" SELECT ")
        strSQL.Append(" ACTIVOF.CCODINV, ")
        strSQL.Append(" ACTIVOF.CDESBIEN, ")
        strSQL.Append(" ACTIVOF.FFONDOS, ")
        strSQL.Append(" ACTIVOF.DFECADQ, ")
        strSQL.Append(" ACTIVOF.NACTDEP, ")
        strSQL.Append(" ACTIVOF.NVALCPA, ")
        strSQL.Append(" ACTIVOF.NVIDUTI, ")
        strSQL.Append(" ACTIVOF.CCODACT, ")
        strSQL.Append(" ACTIVOF.CCODSEC, ")
        strSQL.Append(" ACTIVOF.DFECDEP, ")
        strSQL.Append(" ACTIVOF.NVALNO, ")
        strSQL.Append(" ACTIVOMOV.DFECTRA,")
        strSQL.Append(" ACTIVOMOV.CCODOFI, ")
        strSQL.Append(" TABTOFI.CNOMOFI, ")
        strSQL.Append(" USUARIOS.NOMBRE, ")
        strSQL.Append(" USUARIOS.IDUSUARIO, ")
        strSQL.Append(" '' as CNSERIE, ")
        strSQL.Append(" '' as CMODELO, ")
        strSQL.Append(" 000000.00 as depanual, ")
        strSQL.Append(" 000000.00 as depmen, ")
        strSQL.Append(" 000000.00 as depmenno, ")
        strSQL.Append(" 000000.00 as depacum, ")
        strSQL.Append(" 000000.00 as depmende, ")
        strSQL.Append(" space(1) as ctipo, USUARIOS.CARGO ")

        strSQL.Append(" FROM ")
        strSQL.Append(" ACTIVOF, ")
        strSQL.Append(" ACTIVOMOV, ")
        strSQL.Append(" TABTOFI, ")
        strSQL.Append(" USUARIOS, ")
        strSQL.Append(" ACTIVOIT ")

        strSQL.Append(" WHERE ")
        strSQL.Append(" ACTIVOMOV.CCODINV NOT IN ")
        strSQL.Append(" (SELECT ACTIVOIT.CCODINV FROM ACTIVOIT) AND ")
        strSQL.Append(" ACTIVOMOV.CCODINV=ACTIVOF.CCODINV AND ")

        strSQL.Append(" ACTIVOF.CCODEMP=@CCODUSU AND ")
        strSQL.Append(" ACTIVOMOV.USUARIO=Activof.ccodusu  AND  ")
        strSQL.Append(" Activof.ccodemp=USUARIOS.USUARIO AND ")
        strSQL.Append(" ACTIVOMOV.CCODOFI=TABTOFI.CCODOFI  ")
    


        Dim args(0) As SqlParameter

        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu

        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
End Class
