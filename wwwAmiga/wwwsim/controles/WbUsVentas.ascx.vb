Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class WbUsVentas
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
        ok = mclidbal.ObtenerDataSetPorID(codigoCliente, Me.txtfuente.Text, ldfecha, ds)

        If ok = 1 Then
            If ds.Tables(0).Rows.Count > 0 Then

                Me.txtene.Text = ds.Tables(0).Rows(0)("nene")
                Me.txtfeb.Text = ds.Tables(0).Rows(0)("nfeb")
                Me.txtmar.Text = ds.Tables(0).Rows(0)("nmar")
                Me.txtabr.Text = ds.Tables(0).Rows(0)("nabr")
                Me.txtmay.Text = ds.Tables(0).Rows(0)("nmay")
                Me.txtjun.Text = ds.Tables(0).Rows(0)("njun")

                Me.txtjul.Text = ds.Tables(0).Rows(0)("njul")
                Me.txtago.Text = ds.Tables(0).Rows(0)("nago")
                Me.txtsep.Text = ds.Tables(0).Rows(0)("nsep")
                Me.txtoct.Text = ds.Tables(0).Rows(0)("noct")
                Me.txtnov.Text = ds.Tables(0).Rows(0)("nnov")
                Me.txtdic.Text = ds.Tables(0).Rows(0)("ndic")
            Else
                'Validaciones de los campos
                If Me.txtene.Text.Trim = "" Or Me.txtene.Text.Trim = Nothing Then
                    Me.txtene.Text = 0
                End If
                If Me.txtfeb.Text.Trim = "" Or Me.txtfeb.Text.Trim = Nothing Then
                    Me.txtfeb.Text = 0
                End If
                If Me.txtmar.Text.Trim = "" Or Me.txtmar.Text.Trim = Nothing Then
                    Me.txtmar.Text = 0
                End If
                If Me.txtabr.Text.Trim = "" Or Me.txtabr.Text.Trim = Nothing Then
                    Me.txtabr.Text = 0
                End If
                If Me.txtmay.Text.Trim = "" Or Me.txtmay.Text.Trim = Nothing Then
                    Me.txtmay.Text = 0
                End If
                If Me.txtjun.Text.Trim = "" Or Me.txtjun.Text.Trim = Nothing Then
                    Me.txtjun.Text = 0
                End If
                If Me.txtjul.Text.Trim = "" Or Me.txtjul.Text.Trim = Nothing Then
                    Me.txtjul.Text = 0
                End If
                If Me.txtago.Text.Trim = "" Or Me.txtago.Text.Trim = Nothing Then
                    Me.txtago.Text = 0
                End If
                If Me.txtsep.Text.Trim = "" Or Me.txtsep.Text.Trim = Nothing Then
                    Me.txtsep.Text = 0
                End If
                If Me.txtoct.Text.Trim = "" Or Me.txtoct.Text.Trim = Nothing Then
                    Me.txtoct.Text = 0
                End If
                If Me.txtnov.Text.Trim = "" Or Me.txtnov.Text.Trim = Nothing Then
                    Me.txtnov.Text = 0
                End If
                If Me.txtdic.Text.Trim = "" Or Me.txtdic.Text.Trim = Nothing Then
                    Me.txtdic.Text = 0
                End If

            End If

            txtpromedio.Text = Math.Round((Double.Parse(txtene.Text) + Double.Parse(txtfeb.Text) + Double.Parse(txtmar.Text) + Double.Parse(txtabr.Text) + Double.Parse(txtmay.Text) + Double.Parse(txtjun.Text) + _
        Double.Parse(txtjul.Text) + Double.Parse(txtago.Text) + Double.Parse(txtsep.Text) + Double.Parse(txtoct.Text) + Double.Parse(txtnov.Text) + Double.Parse(txtdic.Text)) / 12, 2)

        End If

        Me.Habilitar()
        Me.btgrabar.Enabled = True


    End Sub
    Private Sub buscar_balance(ByVal lccodcli As String, ByVal lcfuente As String)
        Dim eclidbal As New clidfin
        Dim mclidbal As New cCLIDFLUJO
        eclidbal.ccodcli = lccodcli
        Dim ds As New DataSet
        ds = mclidbal.ObtenerDataSetPorcliente(lccodcli, lcfuente)

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
            Me.TxtdFecha.Text = Session("gdfecsis")

            Dim eclimide As New climide
            Dim mclimide As New cClimide
            eclimide.ccodcli = Me.txtcodcli.Text.Trim
            mclimide.ObtenerClimide(eclimide)

            Me.txtnomcli.Text = eclimide.cnomcli.Trim

            CargaGridInicial()
            Inicial()
            Deshabilitar()
            buscar_balance(Me.txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)

        End If


    End Sub
    Private Sub Habilitar()
        txtene.Enabled = True
        txtfeb.Enabled = True
        txtmar.Enabled = True
        txtabr.Enabled = True
        txtmay.Enabled = True
        txtjun.Enabled = True
        txtjul.Enabled = True
        txtago.Enabled = True
        txtsep.Enabled = True
        txtoct.Enabled = True
        txtnov.Enabled = True
        txtdic.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        txtene.Enabled = False
        txtfeb.Enabled = False
        txtmar.Enabled = False
        txtabr.Enabled = False
        txtmay.Enabled = False
        txtjun.Enabled = False
        txtjul.Enabled = False
        txtago.Enabled = False
        txtsep.Enabled = False
        txtoct.Enabled = False
        txtnov.Enabled = False
        txtdic.Enabled = False
    End Sub
    Private Sub Inicial()
        txtene.Text = 0
        txtfeb.Text = 0
        txtmar.Text = 0
        txtabr.Text = 0
        txtmay.Text = 0
        txtjun.Text = 0
        txtjul.Text = 0
        txtago.Text = 0
        txtsep.Text = 0
        txtoct.Text = 0
        txtnov.Text = 0
        txtdic.Text = 0
        txtpromedio.Text = 0
        btgrabar.Enabled = False
        btimprimir.Enabled = False
        btnuevo.Enabled = True
        Me.TxtdFecha.Text = Session("gdfecha")
    End Sub
    Private Sub CargaGridInicial()
        'Dim ds As New DataSet
        'Dim etabttab As New cTabttab
        'ds = etabttab.ObtenerDataSetCamposAdicionales("093", "1")
        Dim entidadclidflujo As New CLIDFLUJO
        Dim eclidflujo As New cCLIDFLUJO

        entidadclidflujo.ccodcli = txtcodcli.Text.Trim
        entidadclidflujo.ccodfue = Me.txtfuente.Text.Trim
        entidadclidflujo.devalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        entidadclidflujo.dflujo = Date.Parse(Me.TxtdFecha.Text.Trim)

        eclidflujo.ObtenerCLIDFLUJO(entidadclidflujo)

        txtene.Text = entidadclidflujo.nene
        txtfeb.Text = entidadclidflujo.nfeb
        txtmar.Text = entidadclidflujo.nmar
        txtabr.Text = entidadclidflujo.nabr
        txtmay.Text = entidadclidflujo.nmay
        txtjun.Text = entidadclidflujo.njun
        txtjul.Text = entidadclidflujo.njul
        txtago.Text = entidadclidflujo.nago
        txtsep.Text = entidadclidflujo.nsep
        txtoct.Text = entidadclidflujo.noct
        txtnov.Text = entidadclidflujo.nnov
        txtdic.Text = entidadclidflujo.ndic
        txtpromedio.Text = entidadclidflujo.npromm
    End Sub
    
    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        Inicial()
        Habilitar()
        btgrabar.Enabled = True
    End Sub

    Protected Sub btini_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btini.Click
        Inicial()
    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        Dim eclidflujo As New cCLIDFLUJO
        Dim entidadclidflujo As New CLIDFLUJO


        entidadclidflujo.ccodcli = txtcodcli.Text.Trim
        entidadclidflujo.ccodfue = Me.txtfuente.Text.Trim
        entidadclidflujo.devalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        entidadclidflujo.dflujo = Date.Parse(Me.TxtdFecha.Text.Trim)

        'Elimina si ya existe
        eclidflujo.EliminarCLIDFLUJO(entidadclidflujo)



        'Agrega
        entidadclidflujo.nene = Double.Parse(txtene.Text)
        entidadclidflujo.nfeb = Double.Parse(txtfeb.Text)
        entidadclidflujo.nmar = Double.Parse(txtmar.Text)
        entidadclidflujo.nabr = Double.Parse(txtabr.Text)
        entidadclidflujo.nmay = Double.Parse(txtmay.Text)
        entidadclidflujo.njun = Double.Parse(txtjun.Text)
        entidadclidflujo.njul = Double.Parse(txtjul.Text)
        entidadclidflujo.nago = Double.Parse(txtago.Text)
        entidadclidflujo.nsep = Double.Parse(txtsep.Text)
        entidadclidflujo.noct = Double.Parse(txtoct.Text)
        entidadclidflujo.nnov = Double.Parse(txtnov.Text)
        entidadclidflujo.ndic = Double.Parse(txtdic.Text)
        entidadclidflujo.npromm = Math.Round((Double.Parse(txtene.Text) + Double.Parse(txtfeb.Text) + Double.Parse(txtmar.Text) + Double.Parse(txtabr.Text) + Double.Parse(txtmay.Text) + Double.Parse(txtjun.Text) + _
        Double.Parse(txtjul.Text) + Double.Parse(txtago.Text) + Double.Parse(txtsep.Text) + Double.Parse(txtoct.Text) + Double.Parse(txtnov.Text) + Double.Parse(txtdic.Text)) / 12, 2)
        txtpromedio.Text = entidadclidflujo.npromm
        eclidflujo.Agregar(entidadclidflujo)



        buscar_balance(Me.txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)

        Response.Write("<script language='javascript'>alert('Grabado')</script>")

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
End Class


