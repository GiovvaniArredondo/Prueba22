Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Partial Class cuwDeposito
    Inherits ucWBase
    Private cClsAdP As New SIM.BL.ClsAdPart
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim idusuario As Integer
            Dim eusuarios As New cusuarios
            Dim entidadusuarios As New usuarios
            Txtdfecha.Text = Session("gdfecsis")
            txtnsalini.Text = 0
            idusuario = eusuarios.IdUsuario(Session("gccodusu"))

            entidadusuarios.idUsuario = idusuario
            eusuarios.Obtenerusuarios(entidadusuarios)
            txtccajero.Text = entidadusuarios.nombre.Trim
            CargaCombo()

            'verificando si esta habilitado para procesar pagos
            Dim lhabilitado As Boolean
            lhabilitado = eusuarios.ValidaProcesaPagos(Session("gcCodusu"))
            If lhabilitado = False Then
                Button1.Enabled = False
                Response.Write("<script language='javascript'>alert('Caja No Esta Aperturada')</script>")
                Return
            End If

        End If
    End Sub
    Private Sub CargaCombo()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "RE")

        Me.cmbBancos.DataTextField = "cnombco"
        Me.cmbBancos.DataValueField = "ccodbco"
        Me.cmbBancos.DataSource = dsb.Tables(0)
        Me.cmbBancos.DataBind()

        If cmbBancos.Items.Count = 0 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Verifica si ya esta validada la agencia
        Dim etabtofi As New cTabtofi
        Dim eusuarios As New cusuarios
        Dim lccodofi As String

        lccodofi = eusuarios.Oficina(Session("gccodusu"))
        If etabtofi.VerificaValidacionAgencia(lccodofi) = True Then
            Response.Write("<script language='javascript'>alert('Agencia ya fue Validada ')</script>")
            Exit Sub
        End If

        Dim eusuario As New cusuarios
        Dim lprocede As Boolean
        lprocede = eusuario.ValidaCuentaCajero(Session("gccodusu"))
        If lprocede = False Then
            Response.Write("<script language='javascript'>alert('Asignar Cuenta Contable al Cajero')</script>")
            Return
        End If

        Dim lcctactb As String = ""
        Dim etabtbco As New cTabtbco
        Dim ldfechactb As Date

        If Double.Parse(txtnsalini.Text) <= 0 Then
            Response.Write("<script language='javascript'>alert('Monto debe ser mayor a cero')</script>")
            Return
        End If
        If txtBoleta.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Boleta vacia')</script>")
            Return
        End If

        'Verificar si ya existe boleta para Banco
        Dim lexiste As Boolean
        Dim ecredkar As New cCredkar
        lexiste = ecredkar.ExisteBoletaBanco(txtBoleta.Text.Trim, cmbBancos.SelectedValue.Trim)
        If lexiste = True Then
            Response.Write("<script language='javascript'>alert('Boleta de Banco ya Existe ')</script>")
            Return
        End If


        Dim oki As Integer
        Dim lnmonto As Decimal = Decimal.Parse(txtnsalini.Text)
        ldfechactb = Date.Parse(Txtdfecha.Text)
        lcctactb = etabtbco.CuentaContableBanco(Me.cmbBancos.SelectedValue.Trim)


        Dim lccodcta As String
        lccodcta = eusuarios.CuentaContableCajero(Session("gccodusu"))
        Try
            'Verificamos apertura de caja
            Dim lhabilitado As Boolean
            lhabilitado = eusuarios.ValidaProcesaPagos(Session("gcCodusu"))
            If lhabilitado = False Then
                Response.Write("<script language='javascript'>alert('Caja No Esta Aperturada')</script>")
                Return
            End If

            'Obtener Fondo de Cuenta Bancaria
            Dim lcfondos As String
            lcfondos = etabtbco.FondodeCuentaBancaria(cmbBancos.SelectedValue.Trim)

            'Graba Partida contable
            cClsAdP._dfecmod = Session("gdfecsis")
            cClsAdP._ccodusu = Session("gcCodusu")
            cClsAdP._ccodofi = Session("gcCodofi")
            cClsAdP._cconcepto = "PARTIDA DEPOSITO DEL DIA " & Left(ldfechactb.ToString, 10)
            cClsAdP._dfeccnt = ldfechactb
            cClsAdP._cpoliza = " "
            cClsAdP._nCuenta = 1
            cClsAdP._cnumdoc = txtBoleta.Text.Trim
            cClsAdP._llbandera = True
            cClsAdP._ccodpres = ""
            cClsAdP._ffondos = lcfondos
            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
            cClsAdP._ccodcta = lcctactb
            cClsAdP._ndebe = lnmonto
            cClsAdP._nhaber = 0
            cClsAdP._cclase = Left(lcctactb, 1)
            cClsAdP._cpoliza = "AR"
            oki = cClsAdP.AdPartida()

            If oki = "0" Then 'Ocurrio un Error
                Exit Sub
            End If
            cClsAdP._nCuenta += 1

            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
            cClsAdP._ccodcta = lccodcta
            cClsAdP._ndebe = 0
            cClsAdP._nhaber = lnmonto
            cClsAdP._cclase = Left(lccodcta, 1)
            cClsAdP._cpoliza = "AR"

            oki = cClsAdP.AdPartida()

            If oki = "0" Then 'Ocurrio un Error
                Exit Sub
            End If
            cClsAdP._nCuenta += 1


            Dim lchora As String = TimeOfDay.ToString.Substring(11, 12).Replace(".", "").ToUpper
            Dim lcfecha As String
            Dim ldfecha As DateTime
            lcfecha = "#" & Txtdfecha.Text.Trim & " " & lchora & "#"

            ldfecha = DateTime.Parse(lcfecha)

            ecredkar.AgregaraCaja(Session("gccodusu"), Decimal.Parse(txtnsalini.Text), ldfecha, "D", cClsAdP._cNumpar, cmbBancos.SelectedValue.Trim, Session("gccodusu"))


            Response.Write("<script language='javascript'>alert('Grabado, OK')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Ocurrio un problema')</script>")
        End Try


        ''Verifica si tiene alguna apertura sin cierre 

        ''Graba Aperturao
        'Dim ecredkar As New cCredkar
        'Dim lchora As String = TimeOfDay.ToString.Substring(11, 12).Replace(".", "").ToUpper
        'Dim lcfecha As String
        'Dim ldfecha As DateTime
        'Dim lprocede As Boolean
        'lcfecha = "#" & Txtdfecha.Text.Trim & " " & lchora & "#"

        'ldfecha = DateTime.Parse(lcfecha)
        'lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "C")

        'If lprocede = True Then
        '    Try
        '        ecredkar.AgregaraCaja(Session("gcCodusu"), Decimal.Parse(txtnsalini.Text), ldfecha, "C")
        '        Response.Write("<script language='javascript'>alert('Se Cerro Caja para Usuario')</script>")
        '    Catch ex As Exception
        '        Response.Write("<script language='javascript'>alert('Error al Cerrar')</script>")
        '    End Try

        'Else
        '    Response.Write("<script language='javascript'>alert('No se ha Abierto Caja')</script>")
        'End If


    End Sub
End Class


