Imports System.Text
Public Class dbUsuarios
    Inherits dbBase

    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarios
        Dim lID As Long
        lEntidad = aEntidad

        If lEntidad.idUsuario =  0 _
            Or lEntidad.idUsuario = Nothing Then 

            lID = Me.ObtenerID(lEntidad)

            If lID = -1 Then Return -1

            lEntidad.idUsuario = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE usuarios ")
        strSQL.Append(" SET usuario = @usuario, ")
        strSQL.Append(" password = @password, ")
        strSQL.Append(" direccion = @direccion, ")
        strSQL.Append(" telefono = @telefono, ")
        strSQL.Append(" cargo = @cargo, ")
        strSQL.Append(" nombre = @nombre, ")
        strSQL.Append(" ccodofi = @ccodofi ")
        strSQL.Append(" WHERE idUsuario = @idUsuario ")


        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = IIf(lEntidad.usuario = Nothing, DBNull.Value, lEntidad.usuario)
        args(1) = New SqlParameter("@password", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.password = Nothing, DBNull.Value, lEntidad.password)
        args(2) = New SqlParameter("@direccion", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.direccion = Nothing, DBNull.Value, lEntidad.direccion)
        args(3) = New SqlParameter("@telefono", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.telefono = Nothing, DBNull.Value, lEntidad.telefono)
        args(4) = New SqlParameter("@cargo", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.cargo = Nothing, DBNull.Value, lEntidad.cargo)
        args(5) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)
        args(6) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(6).Value = lEntidad.idUsuario
        args(7) = New SqlParameter("@ccodofi", SqlDbType.Int)
        args(7).Value = lEntidad.ccodofi

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarios
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder

        strSQL.Append("INSERT INTO usuarios ")
        strSQL.Append(" ( idUsuario, ") 
        strSQL.Append(" usuario, ") 
        strSQL.Append(" password, ")
        strSQL.Append(" direccion, ")
        strSQL.Append(" telefono, ")
        strSQL.Append(" cargo, ")
        strSQL.Append(" ccodofi, ")
        strSQL.Append(" nombre) ")
        strSQL.Append(" VALUES ")
        strSQL.Append(" ( @idUsuario, ") 
        strSQL.Append(" @usuario, ") 
        strSQL.Append(" @password, ")
        strSQL.Append(" @direccion, ")
        strSQL.Append(" @telefono, ")
        strSQL.Append(" @cargo, ")
        strSQL.Append(" @ccodofi, ")
        strSQL.Append(" @nombre) ")

        Dim args(7) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = IIf(lEntidad.idUsuario = Nothing, DBNull.Value, lEntidad.idUsuario)
        args(1) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(1).Value = IIf(lEntidad.usuario = Nothing, DBNull.Value, lEntidad.usuario)
        args(2) = New SqlParameter("@password", SqlDbType.VarChar)
        args(2).Value = IIf(lEntidad.password = Nothing, DBNull.Value, lEntidad.password)
        args(3) = New SqlParameter("@direccion", SqlDbType.VarChar)
        args(3).Value = IIf(lEntidad.direccion = Nothing, DBNull.Value, lEntidad.direccion)
        args(4) = New SqlParameter("@telefono", SqlDbType.VarChar)
        args(4).Value = IIf(lEntidad.telefono = Nothing, DBNull.Value, lEntidad.telefono)
        args(5) = New SqlParameter("@cargo", SqlDbType.VarChar)
        args(5).Value = IIf(lEntidad.cargo = Nothing, DBNull.Value, lEntidad.cargo)
        args(6) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(6).Value = IIf(lEntidad.ccodofi = Nothing, DBNull.Value, lEntidad.ccodofi)
        args(7) = New SqlParameter("@nombre", SqlDbType.VarChar)
        args(7).Value = IIf(lEntidad.nombre = Nothing, DBNull.Value, lEntidad.nombre)

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarios
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("DELETE FROM usuarios ")
        strSQL.Append(" WHERE idUsuario = @idUsuario ") 

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = lEntidad.idUsuario

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim lEntidad As usuarios
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE idUsuario = @idUsuario ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@idUsuario", SqlDbType.Int)
        args(0).Value = lEntidad.idUsuario

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.idUsuario = IIf(.Item("idusuario") Is DBNull.Value, Nothing, .Item("idusuario"))
                lEntidad.usuario = IIf(.Item("usuario") Is DBNull.Value, Nothing, .Item("usuario"))
                lEntidad.password = IIf(.Item("password") Is DBNull.Value, Nothing, .Item("password"))
                lEntidad.direccion = IIf(.Item("direccion") Is DBNull.Value, Nothing, .Item("direccion"))
                lEntidad.telefono = IIf(.Item("telefono") Is DBNull.Value, Nothing, .Item("telefono"))
                lEntidad.cargo = IIf(.Item("cargo") Is DBNull.Value, Nothing, .Item("cargo"))
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.lesapod = IIf(.Item("lesapod") Is DBNull.Value, 0, .Item("lesapod"))
                lEntidad.lescaje = IIf(.Item("lescaje") Is DBNull.Value, 0, .Item("lescaje"))
                lEntidad.xfirma = IIf(.Item("xfirma") Is DBNull.Value, Nothing, .Item("xfirma"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Long

        Dim lEntidad As usuarios
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT isnull(max(idUsuario),0) + 1 ")
        strSQL.Append(" FROM usuarios ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    Public Function ObtenerListaPorID() As listausuarios

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New Listausuarios

        Try
            Do While dr.Read()
                Dim mEntidad As New usuarios
                mEntidad.idUsuario = IIf(dr("idUsuario") Is DBNull.Value, Nothing, dr("idUsuario"))
                mEntidad.usuario = IIf(dr("usuario") Is DBNull.Value, Nothing, dr("usuario"))
                mEntidad.password = IIf(dr("password") Is DBNull.Value, Nothing, dr("password"))
                mEntidad.direccion = IIf(dr("direccion") Is DBNull.Value, Nothing, dr("direccion"))
                mEntidad.telefono = IIf(dr("telefono") Is DBNull.Value, Nothing, dr("telefono"))
                mEntidad.cargo = IIf(dr("cargo") Is DBNull.Value, Nothing, dr("cargo"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function
    Public Function ObtenerListaPorID2(ByVal cargo As String) As listausuarios

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE cargo = @cargo ")


        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@cargo", SqlDbType.VarChar)
        args(0).Value = cargo

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listausuarios

        Try
            Do While dr.Read()
                Dim mEntidad As New usuarios
                mEntidad.idUsuario = IIf(dr("idUsuario") Is DBNull.Value, Nothing, dr("idUsuario"))
                mEntidad.usuario = IIf(dr("usuario") Is DBNull.Value, Nothing, dr("usuario"))
                mEntidad.password = IIf(dr("password") Is DBNull.Value, Nothing, dr("password"))
                mEntidad.direccion = IIf(dr("direccion") Is DBNull.Value, Nothing, dr("direccion"))
                mEntidad.telefono = IIf(dr("telefono") Is DBNull.Value, Nothing, dr("telefono"))
                mEntidad.cargo = IIf(dr("cargo") Is DBNull.Value, Nothing, dr("cargo"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
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

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    Public Function ObtenerDataSetPorID(ByRef ds As DataSet) As Integer

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)

        Dim tables(0) As String
        tables(0) = New String("usuarios")

        sql.FillDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT idUsuario, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" password, ")
        strSQL.Append(" direccion, ")
        strSQL.Append(" telefono, ")
        strSQL.Append(" cargo, ")
        strSQL.Append(" nombre, lesapod, lescaje, xfirma ")
        strSQL.Append(" FROM usuarios ")

    End Sub

    Public Function ValidarUsuario(ByVal usuario As String, ByVal password As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append(" SELECT isnull(idUsuario,0) ")
        strSQL.Append(" FROM usuarios ")
        strSQL.Append(" WHERE usuario = @usuario ")
        strSQL.Append(" AND password = @password ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario
        args(1) = New SqlParameter("@password", SqlDbType.VarChar)
        args(1).Value = password

        Dim idUsuario As Integer
        idUsuario = sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If idUsuario > 0 Then
            EL.configuracion.idUsuario = idUsuario
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ObtenerListaPorusuario(ByVal usuario1 As String) As listausuarios
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE usuario like" & "'" & "%" & usuario1 & "%" & "'")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@usuario1", SqlDbType.VarChar)
        args(0).Value = usuario1

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listausuarios

        Try
            Do While dr.Read()
                Dim mEntidad As New usuarios
                mEntidad.idUsuario = IIf(dr("idUsuario") Is DBNull.Value, Nothing, dr("idUsuario"))
                mEntidad.usuario = IIf(dr("usuario") Is DBNull.Value, Nothing, dr("usuario"))
                mEntidad.password = IIf(dr("password") Is DBNull.Value, Nothing, dr("password"))
                mEntidad.direccion = IIf(dr("direccion") Is DBNull.Value, Nothing, dr("direccion"))
                mEntidad.telefono = IIf(dr("telefono") Is DBNull.Value, Nothing, dr("telefono"))
                mEntidad.cargo = IIf(dr("cargo") Is DBNull.Value, Nothing, dr("cargo"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                lista.Add(mEntidad)

            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function


    Public Function ObtenerListaPorcodigo(ByVal codigo1 As Integer) As listausuarios
        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append("WHERE idusuario = @codigo1")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@codigo1", SqlDbType.Int)
        args(0).Value = codigo1

        Dim dr As SqlDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listausuarios

        Try
            Do While dr.Read()
                Dim mEntidad As New usuarios
                mEntidad.idUsuario = IIf(dr("idUsuario") Is DBNull.Value, Nothing, dr("idUsuario"))
                mEntidad.usuario = IIf(dr("usuario") Is DBNull.Value, Nothing, dr("usuario"))
                mEntidad.password = IIf(dr("password") Is DBNull.Value, Nothing, dr("password"))
                mEntidad.direccion = IIf(dr("direccion") Is DBNull.Value, Nothing, dr("direccion"))
                mEntidad.telefono = IIf(dr("telefono") Is DBNull.Value, Nothing, dr("telefono"))
                mEntidad.cargo = IIf(dr("cargo") Is DBNull.Value, Nothing, dr("cargo"))
                mEntidad.nombre = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                lista.Add(mEntidad)

            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try
        Return lista
    End Function
    Public Function Nivel(ByVal usuario As String) As Integer
        Dim strSQL As New StringBuilder

        Dim ds As DataSet
        strSQL.Append(" SELECT  tabttab.nflag ")
        strSQL.Append(" FROM usuarios, tabttab ")
        strSQL.Append(" WHERE upper(usuarios.usuario) = upper(@usuario) ")
        strSQL.Append(" AND tabttab.ccodtab = '053' ")
        strSQL.Append(" AND tabttab.ctipreg = '1' ")
        strSQL.Append(" AND tabttab.ccodigo = usuarios.cargo ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("nflag")
        End If
    End Function
    Public Function Oficina(ByVal usuario As String) As String
        Dim strSQL As New StringBuilder

        Dim ds As DataSet
        strSQL.Append(" SELECT  usuarios.ccodofi ")
        strSQL.Append(" FROM usuarios ")
        strSQL.Append(" WHERE upper(usuarios.usuario) = upper(@usuario) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return "001"
        Else
            Return ds.Tables(0).Rows(0)("ccodofi")
        End If
    End Function

    Public Function zona(ByVal ccodofi As String) As String
        Dim strSQL As New StringBuilder

        Dim ds As DataSet
        strSQL.Append(" SELECT  left(czona,2) as cconvar ")
        strSQL.Append(" FROM tabtofi ")
        strSQL.Append(" WHERE ccodofi = @ccodofi ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        
        Return ds.Tables(0).Rows(0)("cconvar")

    End Function
    Public Function ObtenerNAnalistas() As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append("Select count(usuario) from usuarios where cargo='ANA' or usuario = 'MARD' group by usuario")

        Dim ds As DataSet
        Dim lnnumana As Integer
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        lnnumana = ds.Tables(0).Rows.Count
        Return lnnumana

    End Function
    Public Function Analistas() As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append("Select tabtusu.ccodusu as usuario,tabtusu.ccodofi,tabtusu.ccatego, tabtusu.cnomusu as nombre, 0000000 as nprenue, 0000000.00 as ncolnue, ")
        strSQL.Append(" 0000000 as nprerec, 0000000.00 as ncolrec, ")
        strSQL.Append(" 000000000.00 as nSaldo,  ")
        strSQL.Append(" 000000000.00 as nSaldoCon,  ")
        strSQL.Append(" 000000000.00 as nSaldoM,  ")
        strSQL.Append(" 000000000 as nCred, 000000000.00 as nPar30Sal, 00000000 as nindnue,00000000 as nindre, 00000000 as ngrunue, 00000000 as ngrure,    ")
        strSQL.Append(" 00000000000.00 as nsaldo, 00000000000.00 as nsaldoR, 00000000000.00 as nrecsan,00000000.00 as nsalconI, 0000000000 as nsalconG, ")
        strSQL.Append(" 00000000000.00 as nsalcas, ")
        strSQL.Append(" 00000000000.00 as incentivo1,00000000000.00 as incentivo2,00000000000.00 as incentivo3,00000000000.00 as incentivo4, ")
        strSQL.Append(" 00000000000.00 as incentivo5, 00000000000.00 as nsalcon, 00000000000.00 as penal1, 000000.00 as porcas, ")
        strSQL.Append(" 0000.00 as porsecre, 0000.00 as porsupreg ")
        strSQL.Append(" from tabtusu, tabtofi where tabtusu.ccatego='ANA'  and tabtusu.ccodofi = tabtofi.ccodofi ")
        strSQL.Append(" order by tabtofi.ccodins, tabtofi.ccodofi, tabtusu.cnomusu")

        Dim ds As DataSet
        Dim lnnumana As Integer
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds

    End Function
    Public Function VenClave(ByVal usuario As String) As Date
        Dim strSQL As New StringBuilder

        Dim ds As DataSet
        strSQL.Append(" SELECT  usuarios.dfecven ")
        strSQL.Append(" FROM usuarios ")
        strSQL.Append(" WHERE upper(usuarios.usuario) = upper(@usuario) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return Today
        Else
            Return ds.Tables(0).Rows(0)("dfecven")
        End If
    End Function

    Public Function ActualizaClave(ByVal usuario As String, ByVal clave As String, ByVal dfecven As Date) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Update usuarios set password = @clave, dfecven = @dfecven where usuario = @usuario ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario
        args(1) = New SqlParameter("@clave", SqlDbType.VarChar)
        args(1).Value = clave
        args(2) = New SqlParameter("@dfecven", SqlDbType.DateTime)
        args(2).Value = dfecven

        Try
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function ActualizaEstado(ByVal usuario As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Update usuarios set lactivo = '0' where usuario = @usuario ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario
        Try
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function GrabarIntentos(ByVal usuario As String, ByVal intentos As Integer) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Update usuarios set intentos = @intentos where usuario = @usuario ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario
        args(1) = New SqlParameter("@intentos", SqlDbType.Int)
        args(1).Value = intentos

        Try
            Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function RecuperarIntentos(ByVal usuario As String) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("Select intentos from usuarios where usuario = @usuario ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        Dim ds As New DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                Return 0
            Else
                Return ds.Tables(0).Rows(0)("intentos")
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function RecuperarEstatus(ByVal usuario As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("Select lactivo from usuarios where usuario = @usuario ")
        Dim args(2) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        Dim ds As New DataSet
        Try
            ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
            If ds.Tables(0).Rows.Count = 0 Then
                Return False
            Else
                Return ds.Tables(0).Rows(0)("lactivo")
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IdUsuario(ByVal usuario As String) As Integer
        Dim strSQL As New StringBuilder

        Dim ds As DataSet
        strSQL.Append(" SELECT  usuarios.Idusuario ")
        strSQL.Append(" FROM usuarios ")
        strSQL.Append(" WHERE upper(usuarios.usuario) = upper(@usuario) ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            Return 0
        Else
            Return ds.Tables(0).Rows(0)("idusuario")
        End If
    End Function
    Public Function RegistraAuditoria(ByVal aEntidad As usuarios) As Integer

        Dim lEntidad As usuarios
        lEntidad = aEntidad


        Dim strSQL As New StringBuilder
        strSQL.Append("INSERT INTO AUDITORIA(idusuario, ip, dfecha, chora, dfecsis, ctrs, idopcion) ")
        strSQL.Append("VALUES(@idusuario, @ip, @dfecha, @chora, @dfecsis, @ctrs,@idopcion)")
        Dim args(6) As SqlParameter

        args(0) = New SqlParameter("@idusuario", SqlDbType.VarChar)
        args(0).Value = lEntidad.idUsuario
        args(1) = New SqlParameter("@ip", SqlDbType.VarChar)
        args(1).Value = lEntidad.cip
        args(2) = New SqlParameter("@dfecha", SqlDbType.DateTime)
        args(2).Value = lEntidad.dfecha
        args(3) = New SqlParameter("@chora", SqlDbType.VarChar)
        args(3).Value = lEntidad.chora
        args(4) = New SqlParameter("@dfecsis", SqlDbType.DateTime)
        args(4).Value = lEntidad.gdfecsis
        args(5) = New SqlParameter("@ctrs", SqlDbType.VarChar)
        args(5).Value = lEntidad.ctrs
        args(6) = New SqlParameter("@idopcion", SqlDbType.Int)
        args(6).Value = lEntidad.idopcion


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)


    End Function

    Public Function VerificarAccesoGrupo(ByVal usuario As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append(" select grupos.codigogrupo from usuarios, grupos, usuarioGrupo ")
        strSQL.Append(" where usuarios.idUsuario = usuarioGrupo.idUsuario ")
        strSQL.Append(" and usuarioGrupo.idGrupo = grupos.idGrupo ")
        strSQL.Append(" and usuarios.usuario = @usuario ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Dim lvalida As Boolean
        Dim codigo As String
        If ds.Tables(0).Rows.Count = 0 Then
            lvalida = False
        Else
            codigo = IIf(IsDBNull(ds.Tables(0).Rows(0)("codigogrupo")), "", ds.Tables(0).Rows(0)("codigogrupo"))
            If codigo = "CTB" Or codigo = "AUX" Then
                lvalida = True
            Else
                lvalida = False
            End If
        End If

        Return lvalida
    End Function
    Public Function ObtieneUsuarios2() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select usuario, nombre")
        strSQL.Append(" From usuarios")
        strSQL.Append(" where lactivo='1' and nombre<>''")
        strSQL.Append(" order by nombre")

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString())
        Return ds
    End Function
    Public Function ObtenerNombreUsuario(ByVal cusuario As String) As String

        Dim strSQL As New StringBuilder
        strSQL.Append("Select nombre from usuarios where usuario=@cusuario")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cusuario", SqlDbType.Char)
        args(0).Value = cusuario

        Dim ds As DataSet
        Dim cnombre As String
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        If ds.Tables(0).Rows.Count = 0 Then
            cnombre = ""
        Else
            cnombre = ds.Tables(0).Rows(0)("nombre")
        End If
        Return cnombre
    End Function
    Public Function ValidaProcesaPagos(ByVal usuario As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("select lHabilitado from usuarios where usuario = @usuario ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario

        Dim ds As New DataSet
        Dim lprocede As Boolean = False
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("lHabilitado")) Then
            Else
                lprocede = IIf(ds.Tables(0).Rows(0)("lHabilitado") = 0, False, True)
            End If
        End If
        Return lprocede
    End Function

    Public Function ObtenerCajeros() As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from usuarios where lescaje ='1' order by nombre ")

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString)

        Return ds
    End Function
    Public Function ObtenerCajerosOficina(ByVal ccodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from usuarios where lescaje ='1' and ccodofi =@ccodofi order by nombre ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString, args)

        Return ds
    End Function
    Public Function ActualizaCajero(ByVal usuario As String, ByVal nvalor As Integer) As Integer
        Dim strSQL As New StringBuilder
        strSQL.Append("UPDATE usuarios SET lHabilitado = @nvalor WHERE usuario = @usuario ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@usuario", SqlDbType.VarChar)
        args(0).Value = usuario
        args(1) = New SqlParameter("@nvalor", SqlDbType.Int)
        args(1).Value = nvalor

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function
    Public Function ValidaCuentaCajero(ByVal ccodusu As String) As Boolean
        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT ctbmcta.ccodcta  FROM ctbmcta, usuarios ")
        strSQL.Append("WHERE ctbmcta.ccodcta = usuarios.cctabco and ctbmcta.ccodto ='D' ")
        strSQL.Append("and usuarios.usuario = @ccodusu ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(0).Value = ccodusu

        Dim ds As New DataSet
        Dim lprocede As Boolean = False
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            If IsDBNull(ds.Tables(0).Rows(0)("ccodcta")) Then
            Else
                lprocede = True
            End If
        End If
        Return lprocede
    End Function
    Public Function CuentaContableCajero(ByVal ccodusu As String) As String
        Dim strSQL As New StringBuilder
        strSQL.Append("Select cCtabco FROM usuarios Where usuario = @ccodusu ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodusu", ccodusu)
        Dim ds As New DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If ds.Tables(0).Rows.Count = 0 Then
            Return "*"
        Else
            Return IIf(IsDBNull(ds.Tables(0).Rows(0)("cctabco")), "*", ds.Tables(0).Rows(0)("cctabco"))
        End If


    End Function
    Public Function ValidaSesionUsuario(ByVal ccodusu As String) As Integer
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lnretorno As Integer = 0
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select usuario from usuarios where usuario='" & ccodusu & "'"
                command.CommandType = CommandType.Text

                myadapter.SelectCommand = command
                myadapter.Fill(ds, "Usuario")
                For Each fila As DataRow In ds.Tables("Usuario").Rows
                    If IsDBNull(fila("usuario")) Then
                    Else
                        lnretorno = 1
                    End If
                Next

            Catch ex As Exception

            Finally
                conneccion.Close()
            End Try

        End Using

        Return lnretorno
    End Function
    Public Function VerificaCargo(ByVal usuario As String, ByVal ccodofi As String, ByVal cargo As String) As Boolean
        Dim command As New SqlCommand
        Dim myadapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim lvalida As Boolean = False
        Using conneccion As New SqlConnection(Me.cnnStr)
            conneccion.Open()
            Try
                command.Connection = conneccion
                command.CommandText = "select usuario from usuarios " & _
                                      "where cargo ='" & cargo & "' and  lactivo ='1' and usuario='" & usuario.Trim & _
                                      "' and ccodofi='" & ccodofi & "' "
                command.CommandType = CommandType.Text
                myadapter.SelectCommand = command
                myadapter.Fill(ds, "usuario")

                For Each fila As DataRow In ds.Tables("usuario").Rows
                    lvalida = True
                Next

            Catch ex As Exception
            Finally
                conneccion.Close()
            End Try
        End Using
        Return lvalida
    End Function
    Public Function ObtenerCajerosAgencias(ByVal ccodofi As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("Select * from usuarios where lescaje ='1'  ")

        If ccodofi.Trim = "001" Then

        Else
            strSQL.Append(" and ccodofi =@ccodofi ")
        End If
        strSQL.Append("order by nombre ")
        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", ccodofi)
        
        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString, args)

        Return ds
    End Function
    Public Function ObtenerDataSetNombre(ByVal cnombre As String) As DataSet
        Dim strSQL As New StringBuilder

        SelectTabla(strSQL)
        strSQL.Append("WHERE nombre like" & "'" & "%" & cnombre & "%" & "'")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnombre", SqlDbType.VarChar)
        args(0).Value = cnombre

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function
    Public Function ObtenerDataSetNombreActivoFijo(ByVal cnombre As String) As DataSet
        Dim strSQL As New StringBuilder

        SelectTabla2(strSQL)
        strSQL.Append("WHERE nombre like" & "'" & "%" & cnombre & "%" & "'")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@cnombre", SqlDbType.VarChar)
        args(0).Value = cnombre

        Dim ds As DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds
    End Function

    Private Sub SelectTabla2(ByRef strSQL As StringBuilder)

        strSQL.Append(" SELECT idUsuario, ")
        strSQL.Append(" usuario, ")
        strSQL.Append(" password, ")
        strSQL.Append(" direccion, ")
        strSQL.Append(" telefono, ")
        strSQL.Append(" cargo, ")
        strSQL.Append(" nombre, ")
        strSQL.Append(" ccodofi ")
        strSQL.Append(" FROM usuarios ")

    End Sub
    Public Function ObtenerResponsableCC(ByVal ccodofi As String, ByVal ccodusu As String) As DataSet
        Dim strSQL As New StringBuilder
        strSQL.Append("select usuario, nombre from usuarios ")
        strSQL.Append("where lescaje=1 ")
        If ccodofi = "001" Then
        Else
            If ccodusu = "" Then
                strSQL.Append(" and ccodofi = @ccodofi ")
            Else
                strSQL.Append(" and ccodofi = @ccodofi and usuario=@ccodusu ")
            End If
        End If

        strSQL.Append("order by nombre ")

        Dim args(1) As SqlParameter
        args(0) = New SqlParameter("@ccodofi", SqlDbType.VarChar)
        args(0).Value = ccodofi
        args(1) = New SqlParameter("@ccodusu", SqlDbType.VarChar)
        args(1).Value = ccodusu

        Dim ds As New DataSet
        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
        Return ds
    End Function

    Public Function RecuperarUsuario(ByVal aEntidad As entidadBase) As String

        Dim lEntidad As usuarios
        lEntidad = aEntidad

        Dim strSQL As New StringBuilder
        SelectTabla(strSQL)
        strSQL.Append(" WHERE Usuario = @Usuario ")

        Dim args(0) As SqlParameter
        args(0) = New SqlParameter("@Usuario", SqlDbType.VarChar)
        args(0).Value = lEntidad.usuario

        Dim dsDatos As DataSet

        dsDatos = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dsDatos.Tables(0).Rows.Count = 0 Then Return 0

        Try
            With dsDatos.Tables(0).Rows(0)
                lEntidad.idUsuario = IIf(.Item("idusuario") Is DBNull.Value, Nothing, .Item("idusuario"))
                lEntidad.usuario = IIf(.Item("usuario") Is DBNull.Value, Nothing, .Item("usuario"))
                lEntidad.password = IIf(.Item("password") Is DBNull.Value, Nothing, .Item("password"))
                lEntidad.direccion = IIf(.Item("direccion") Is DBNull.Value, Nothing, .Item("direccion"))
                lEntidad.telefono = IIf(.Item("telefono") Is DBNull.Value, Nothing, .Item("telefono"))
                lEntidad.cargo = IIf(.Item("cargo") Is DBNull.Value, Nothing, .Item("cargo"))
                lEntidad.nombre = IIf(.Item("nombre") Is DBNull.Value, Nothing, .Item("nombre"))
                lEntidad.ccodofi = IIf(.Item("ccodofi") Is DBNull.Value, Nothing, .Item("ccodofi"))
            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return 1

    End Function

    Public Function NombreUsuario(ByVal ccodusu As String) As String
        Dim consulta As New StringBuilder
        Dim ds As New DataSet
        consulta.Append("Select RTRIM(LTRIM(NOMBRE)) as nombre FROM USUARIOS WHERE usuario = '" & ccodusu.Trim & "'")
        ds = sql.ExecuteDataset(cnnStr, CommandType.Text, consulta.ToString())

        If ds.Tables(0).Rows.Count > 0 Then
            Return ds.Tables(0).Rows(0)("nombre")
        Else
            Return " "
        End If
    End Function



    Public Function Extraer_Analistas() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select usuario, nombre from usuarios " & _
                                        " where lactivo = 1 and cargo = 'ANA'" & _
                                        " order by nombre "



                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

    Public Function Extrae_Usuarios_Activos() As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Select idUsuario, (ltrim(rtrim(usuario)) + ' |' + ltrim(rtrim(nombre))) as nombre from usuarios " & _
                                        " where lactivo = 1" & _
                                        " order by nombre "



                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function


    Public Function Actualizar_Firmas_Digitales(ByVal firma As Array, ByVal idusuario As Integer) As Integer


        Dim connection As New SqlConnection(Me.cnnStr)
        Dim lnRetorno As Integer = 0

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " Update Usuarios set xfirma= @firma" & _
                                        " Where idusuario =" & idusuario


                command.CommandType = CommandType.Text

                command.Parameters.Add("@firma", System.Data.SqlDbType.Image)

                command.Parameters("@firma").Value = firma


                command.ExecuteNonQuery()

                lnRetorno = 1

            Catch ex As Exception

                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return lnRetorno

    End Function


    Public Function Extrae_Datos_Usuario(ByVal Idusuario As Integer) As DataSet

        Dim ds_Trab As New DataSet
        Dim connection As New SqlConnection(Me.cnnStr)
        Dim MyAdapter As New SqlDataAdapter

        Using connection
            connection.Open()

            Try

                Dim command As New SqlCommand
                command.Connection = connection


                command.CommandText = _
                                        " select idUsuario, usuario, nombre, xfirma from usuarios " & _
                                        " where idUsuario =" & Idusuario


                command.CommandType = CommandType.Text

                MyAdapter.SelectCommand = command

                MyAdapter.Fill(ds_Trab, "Usuarios")


            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)
            Finally
                connection.Close()
            End Try


        End Using


        Return ds_Trab

    End Function

End Class
