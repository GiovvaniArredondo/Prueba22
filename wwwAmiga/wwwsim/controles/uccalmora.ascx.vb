

Partial Class uccalmora
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        viewstate.Add("pccodcta", codigoCliente)
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerLista()

        'carga instituciones
        Me.ddlcodins.DataTextField = "cdescri"
        Me.ddlcodins.DataValueField = "ccodigo"
        Me.ddlcodins.DataSource = mlistainstitu
        Me.ddlcodins.DataBind()
        'carga oficinas
        Me.ddlcodofi.DataTextField = "cnomofi"
        Me.ddlcodofi.DataValueField = "ccodofi"
        Me.ddlcodofi.DataSource = mlistaoficina
        Me.ddlcodofi.DataBind()
        Me.txtfecval.Text = Session("gdfecsis")
        Me.txtcnrocta.Text = ""

    End Sub


    Sub calculomora()
        Dim clscalculo As New ccalculomora
        clscalculo.pdfecval = Date.Parse(Me.txtfecval.Text)
        clscalculo.pccodcta = viewstate("pccodcta")
        clscalculo.gnperbas = Session("gnperbas")

        clscalculo.omcalcinterest()

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        'cremcre
        Dim lccodcta As String
        lccodcta = viewstate("pccodcta")
        If Me.txtcnrocta.Text.Trim = "" Then
            lccodcta = ""
        End If
        Dim entidad1 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad1.ccodcta = lccodcta
        ecreditos.Obtenercreditos(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Try
            ecreditos.CalculoMora(Date.Parse(Me.txtfecval.Text))
            ecreditos.ReclasificacionCartera()
            Response.Write("<script language='javascript'>alert('ok')</script>")

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Problemas en Calculo de Mora')</script>")

        End Try
    End Sub

   
End Class


