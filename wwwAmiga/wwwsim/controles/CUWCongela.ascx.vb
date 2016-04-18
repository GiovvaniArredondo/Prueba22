Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class CUWCongela
    Inherits ucWBase
    Dim cls1 As New SIM.BL.pagdesver
    Dim clsppal As New SIM.BL.class1

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub
    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnNivel"), Session("gcCodOfi"))

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
        '   Me.calfecval.SelectedDate = Session("gdfecsis")

        Me.btnprocesar.Disabled = False

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        ViewState.Add("pccodcta", codigoCliente)
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        entidadcremcre.ccodcta = codigoCliente
        ecremcre.ObtenerCremcre(entidadcremcre)
        Dim lcoficina As String
        lcoficina = entidadcremcre.coficina
        ddlcodofi.SelectedValue = lcoficina
        txtaldia.Text = 0
        txtaldia.Enabled = True
        Button1.Enabled = True
        Me.aplicar()
    End Sub

    Sub aplicar()
        'cremcre
        Dim entidad1 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad1.ccodcta = ViewState("pccodcta")
        ecreditos.Obtenercreditos(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Me.txtccodcli.Text = entidad1.ccodcli

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lccodcta As String = ViewState("pccodcta")
        Dim ecredppg As New cCredppg
        Dim ecremcre As New cCremcre
        Dim lcnrocuo As String
        Dim lnintcong As Double = 0
        Try

            lnintcong = Double.Parse(txtaldia.Text)
            Dim ldfecval As Date = Session("gdfecsis")
            lcnrocuo = ecredppg.ObtenerCuotaUltimaVencida(lccodcta, ldfecval)
            ecredppg.GrabaInteresCongelado(lccodcta, lcnrocuo, lnintcong)
            ecremcre.GrabaInteresCongelado(lccodcta, lnintcong)
            '---------------------------------------------------------


            Response.Write("<script language='javascript'>alert('Intereses Congelados')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Ocurrio un problema')</script>")
        End Try

        txtaldia.Enabled = False
        Button1.Enabled = False
    End Sub

End Class


