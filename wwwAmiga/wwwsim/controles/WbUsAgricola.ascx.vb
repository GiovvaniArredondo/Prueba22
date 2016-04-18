Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class WbUsAgricola
    Inherits ucWBase

#Region "Metodos"
    
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Dim gdfecsis As Date = Session("gdfecsis")
        Dim ldfecha As Date

        Me.Txtcomodin.Text = codigoCliente
        Me.txtcodcli.Text = codigoCliente
        Me.txtfuente.Text = Me.txtfuente.Text.Trim
        ldfecha = Date.Parse(Me.TxtdFecha.Text)


        '********** carga datos para modificarlos **************

        Dim mclidbal As New cCLIDFLUJO
        Dim eclidbal As New CLIDFLUJO
        Dim ds As New DataSet
        Dim ok As Integer

        If Me.txtfuente.Text = "" Or Me.txtfuente.Text = Nothing Then
            Me.txtfuente.Text = "01"
        End If

        eclidbal.ccodcli = codigoCliente
        eclidbal.ccodfue = Me.txtfuente.Text
        'ok = mclidbal.ObtenerDataSetPorID(codigoCliente, Me.txtfuente.Text, ldfecha, ds)
        RefrescaGrid()

        Me.Habilitar()
        Me.btgrabar.Enabled = True


    End Sub
    Private Sub buscar_balance(ByVal lccodcli As String, ByVal lcfuente As String)
        Dim eclidbal As New CLIDAGRO
        Dim mclidbal As New cCLIDAGRO
        eclidbal.ccodcli = lccodcli
        Dim ds As New DataSet
        mclidbal.ObtenerDataSet(lccodcli, lcfuente, ds)

        Me.ddlbalance.DataTextField = "devalua"
        Me.ddlbalance.DataValueField = "devalua"
        Me.ddlbalance.DataSource = ds.Tables(0)
        Me.ddlbalance.DataBind()
        ds.Tables(0).Clear()

    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.txtcodcli.Text = Session("codigo")
            Me.txtfuente.Text = Session("fuente")
            Me.TxtdFecha.Text = Session("gdfecha") 'Session("gdfecsis")

            Dim eclimide As New climide
            Dim mclimide As New cClimide
            eclimide.ccodcli = Me.txtcodcli.Text.Trim
            mclimide.ObtenerClimide(eclimide)

            Me.txtnomcli.Text = eclimide.cnomcli.Trim

            CargarCultivos()
            RadioButton1.Checked = True
            RadioButton2.Checked = False
            'CargaGridInicial()
            Inicial()
            'Deshabilitar()
            buscar_balance(Me.txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)
        End If

    End Sub
    Private Sub Habilitar()
        txtcosto.Enabled = True
        txtingreso.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        txtcosto.Enabled = False
        txtingreso.Enabled = False
    End Sub
    Private Sub Inicial()
        txtcosto.Text = 0
        txtingreso.Text = 0
        txtRendimiento.Text = 0
        btgrabar.Enabled = False
        btimprimir.Enabled = False
        btnuevo.Enabled = True
    End Sub
    Private Sub CargaGridInicial()
        'Dim entidadclidflujo As New CLIDFLUJO
        'Dim eclidflujo As New cCLIDFLUJO

        'entidadclidflujo.ccodcli = txtcodcli.Text.Trim
        'entidadclidflujo.ccodfue = Me.txtfuente.Text.Trim
        'entidadclidflujo.devalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        'entidadclidflujo.dflujo = Date.Parse(Me.TxtdFecha.Text.Trim)

        'eclidflujo.ObtenerCLIDFLUJO(entidadclidflujo)

    End Sub
    
    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        Inicial()
        Habilitar()
        btgrabar.Enabled = True
    End Sub

    Protected Sub btini_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btini.Click
        Inicial()
        Habilitar()
        btgrabar.Enabled = True

    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        'Dim eclidflujo As New cCLIDFLUJO
        'Dim entidadclidflujo As New CLIDFLUJO


        'entidadclidflujo.ccodcli = txtcodcli.Text.Trim
        'entidadclidflujo.ccodfue = Me.txtfuente.Text.Trim
        'entidadclidflujo.devalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        'entidadclidflujo.dflujo = Date.Parse(Me.TxtdFecha.Text.Trim)

        ''Elimina si ya existe
        'eclidflujo.EliminarCLIDFLUJO(entidadclidflujo)



        ''Agrega
        'entidadclidflujo.nene = Double.Parse(txtene.Text)
        'entidadclidflujo.nfeb = Double.Parse(txtfeb.Text)
        'entidadclidflujo.nmar = Double.Parse(txtmar.Text)
        'entidadclidflujo.nabr = Double.Parse(txtabr.Text)
        'entidadclidflujo.nmay = Double.Parse(txtmay.Text)
        'entidadclidflujo.njun = Double.Parse(txtjun.Text)
        'entidadclidflujo.njul = Double.Parse(txtjul.Text)
        'entidadclidflujo.nago = Double.Parse(txtago.Text)
        'entidadclidflujo.nsep = Double.Parse(txtsep.Text)
        'entidadclidflujo.noct = Double.Parse(txtoct.Text)
        'entidadclidflujo.nnov = Double.Parse(txtnov.Text)
        'entidadclidflujo.ndic = Double.Parse(txtdic.Text)
        'entidadclidflujo.npromm = Math.Round((Double.Parse(txtene.Text) + Double.Parse(txtfeb.Text) + Double.Parse(txtmar.Text) + Double.Parse(txtabr.Text) + Double.Parse(txtmay.Text) + Double.Parse(txtjun.Text) + _
        'Double.Parse(txtjul.Text) + Double.Parse(txtago.Text) + Double.Parse(txtsep.Text) + Double.Parse(txtoct.Text) + Double.Parse(txtnov.Text) + Double.Parse(txtdic.Text)) / 12, 2)
        'txtpromedio.Text = entidadclidflujo.npromm
        'eclidflujo.Agregar(entidadclidflujo)



        'buscar_balance(Me.txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)

        'Response.Write("<script language='javascript'>alert('Grabado')</script>")

    End Sub

    Protected Sub btbusca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btbusca.Click
        Dim lnindice As Integer
        Dim ldfecha As Date
        If Me.ddlbalance.SelectedValue = Nothing Or Me.ddlbalance.SelectedValue = "" Then
            ldfecha = Date.Now
        Else
            ldfecha = Date.Parse(Me.ddlbalance.SelectedValue)
        End If
        Me.TxtdFecha.Text = Left(ldfecha.ToString, 10)
        CargarPorCliente(Me.txtcodcli.Text.Trim)
    End Sub

    Private Sub CargarCultivos()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("099", "1")

        Me.cmbelegir.DataTextField = "cdescri"
        Me.cmbelegir.DataValueField = "ccodigo"
        Me.cmbelegir.DataSource = mListaTabttab
        Me.cmbelegir.DataBind()

    End Sub
    Private Sub CargarCrianza()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("109", "1")

        Me.cmbelegir.DataTextField = "cdescri"
        Me.cmbelegir.DataValueField = "ccodigo"
        Me.cmbelegir.DataSource = mListaTabttab
        Me.cmbelegir.DataBind()
    End Sub

    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            CargarCultivos()
        Else
            CargarCrianza()
        End If
    End Sub

    Protected Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            CargarCultivos()
        Else
            CargarCrianza()
        End If
    End Sub

    Protected Sub btnagregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If Double.Parse(txtingreso.Text) = 0 And Double.Parse(txtcosto.Text) = 0 Then
            Exit Sub
        End If
        'Verifica si ya existe eleccion
        Dim cclidagro As New cCLIDAGRO
        Dim entidadclidagro As New CLIDAGRO

        entidadclidagro.ccodcli = txtcodcli.Text.Trim
        entidadclidagro.ccodfue = txtfuente.Text.Trim
        entidadclidagro.devalua = Date.Parse(TxtdFecha.Text)
        entidadclidagro.ccodigo = cmbelegir.SelectedValue.Trim
        entidadclidagro.ctipo = IIf(RadioButton1.Checked = True, "1", "2")

        Dim i As Integer = 0
        i = cclidagro.ObtenerCLIDAGRO(entidadclidagro)

        entidadclidagro.ccodusu = Session("gccodusu")
        entidadclidagro.dfecmod = Now
        entidadclidagro.cflag = ""
        entidadclidagro.ningreso = Double.Parse(txtingreso.Text)
        entidadclidagro.ncosto = Double.Parse(txtcosto.Text)
        entidadclidagro.nrendimiento = Math.Round(entidadclidagro.ningreso - entidadclidagro.ncosto, 2)

        Try
            If i = 0 Then 'Nuevo
                cclidagro.Agregar(entidadclidagro)
            Else 'Modificacion
                cclidagro.ActualizarCLIDAGRO(entidadclidagro)
            End If
            txtcosto.Text = 0
            txtingreso.Text = 0
            txtRendimiento.Text = 0

            RefrescaGrid()

            buscar_balance(txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)

        Catch ex As Exception

        End Try

    End Sub
    Public Sub RefrescaGrid()

        'Trae las Garantias del Cliente
        Dim entidadClidagro As New SIM.EL.CLIDAGRO
        Dim eClidagro As New SIM.BL.cCLIDAGRO
        Dim ds As New DataSet
        Dim ncanti As Integer


        eClidagro.ObtenerDataSetPorID(txtcodcli.Text.Trim, txtfuente.Text.Trim, Date.Parse(TxtdFecha.Text), ds)

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Me.Datagrid1.DataSource = ""
            Me.Datagrid1.DataBind()
            Me.Datagrid1.Visible = False
            Exit Sub
        End If
        Me.Datagrid1.Visible = True
        Dim fila As DataRow
        Dim etabttab As New cTabttab
        For Each fila In ds.Tables(0).Rows
            If fila("ctipo") = "1" Then
                fila("descripcion") = etabttab.Describe(Right(fila("ccodigo"), 3), "099")
            Else
                fila("descripcion") = etabttab.Describe(Right(fila("ccodigo"), 3), "109")
            End If


        Next


        Me.Datagrid1.DataSource = ds
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
        CalculaTotales()
        ds.Tables.Clear()
    End Sub

    Protected Sub Datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        Dim llave As String = Datagrid1.SelectedRow.Cells(1).Text.ToString 'asociado

        Dim ccodigo As String = Right(llave.Trim, 3)
        Dim ctipo As String = Left(llave.Trim, 1)

        Dim entidadClidagro As New SIM.EL.CLIDAGRO
        Dim eClidagro As New SIM.BL.cCLIDAGRO

        entidadClidagro.ccodcli = txtcodcli.Text.Trim
        entidadClidagro.ccodfue = txtfuente.Text.Trim
        entidadClidagro.devalua = Date.Parse(TxtdFecha.Text)
        entidadClidagro.ccodigo = ccodigo
        entidadClidagro.ctipo = ctipo

        eClidagro.EliminarCLIDAGRO(entidadClidagro)
        RefrescaGrid()

    End Sub
    Private Sub CalculaTotales()
        Dim ds As New DataSet
        Dim eclidagro As New cCLIDAGRO
        ds = eclidagro.ObtenerTotal(txtcodcli.Text, txtfuente.Text.Trim, Date.Parse(TxtdFecha.Text))


        For Each fila As DataRow In ds.Tables(0).Rows
            If fila("ctipo") = "1" Then
                txtotaling1.Text = fila("ningreso")
                txtotalcos1.Text = fila("ncosto")
                '                txtotalren1.Text = fila("nrendimiento")
                'If fila("ncosto") = 0 Then
                'Else
                txtotalren1.Text = Math.Round(fila("ningreso") - fila("ncosto"), 2)
                'End If
            Else
                txtotaling2.Text = fila("ningreso")
                txtotalcos2.Text = fila("ncosto")
                '               txtotalren2.Text = fila("nrendimiento")
                'If fila("ncosto") = 0 Then
                'Else
                txtotalren2.Text = Math.Round(fila("ningreso") - fila("ncosto"), 2)
                'End If

            End If

        Next


    End Sub

    Protected Sub btimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btimprimir.Click

    End Sub
End Class


