

Partial Class wucDatRef
    Inherits ucWBase

    Dim entidadClimide As New climide
    Dim eClimide As New cClimide
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarCombo()
            Me.TxtCodigo.Text = Session("codigocli")
            Me.cargaDatos()
            Restri(True)
            If Session("codigo") = "0" Then
                Deshabilitar()
            End If
        End If
    End Sub

    Public Sub Restri(ByVal flag As Boolean)
        rqv1.Enabled = flag
        rqv2.Enabled = flag
        rqv3.Enabled = flag
        rqv4.Enabled = flag
        rqv5.Enabled = flag
        rqv6.Enabled = flag
        rqv7.Enabled = flag
        rqv8.Enabled = flag
    End Sub

    Private Sub Deshabilitar()
        btnGrabar.Disabled = True
        btnGrabar.Visible = False
        txtcref1.Enabled = False
        txtcref2.Enabled = False
        txtcref3.Enabled = False
        txtcref4.Enabled = False
        txtcref5.Enabled = False
        txtcref6.Enabled = False

        txtcdomicilio1.Enabled = False
        txtcdomicilio2.Enabled = False
        txtcdomicilio3.Enabled = False
        txtcdomicilio4.Enabled = False
        txtcdomicilio5.Enabled = False
        txtcdomicilio6.Enabled = False

        txtctel1.Enabled = False
        txtctel2.Enabled = False
        txtctel3.Enabled = False
        txtctel4.Enabled = False
        txtctel5.Enabled = False
        txtctel6.Enabled = False

        cmbTipref1.Enabled = False
        cmbTipref2.Enabled = False
        cmbTipref3.Enabled = False
        cmbTipref4.Enabled = False
        cmbTipref5.Enabled = False
        cmbTipref6.Enabled = False
        CbxParentesco1.Enabled = False
        CbxParentesco2.Enabled = False
    End Sub
    Public Sub CargarCombo()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("089", "1")

        Me.cmbTipref1.DataTextField = "cdescri"
        Me.cmbTipref1.DataValueField = "ccodigo"
        Me.cmbTipref1.DataSource = mListaTabttab
        Me.cmbTipref1.DataBind()

        Me.cmbTipref2.DataTextField = "cdescri"
        Me.cmbTipref2.DataValueField = "ccodigo"
        Me.cmbTipref2.DataSource = mListaTabttab
        Me.cmbTipref2.DataBind()

        Me.cmbTipref3.DataTextField = "cdescri"
        Me.cmbTipref3.DataValueField = "ccodigo"
        Me.cmbTipref3.DataSource = mListaTabttab
        Me.cmbTipref3.DataBind()

        Me.cmbTipref4.DataTextField = "cdescri"
        Me.cmbTipref4.DataValueField = "ccodigo"
        Me.cmbTipref4.DataSource = mListaTabttab
        Me.cmbTipref4.DataBind()

        Me.cmbTipref5.DataTextField = "cdescri"
        Me.cmbTipref5.DataValueField = "ccodigo"
        Me.cmbTipref5.DataSource = mListaTabttab
        Me.cmbTipref5.DataBind()

        Me.cmbTipref6.DataTextField = "cdescri"
        Me.cmbTipref6.DataValueField = "ccodigo"
        Me.cmbTipref6.DataSource = mListaTabttab
        Me.cmbTipref6.DataBind()
        Me.CbxParentesco1.Recuperar()
        Me.CbxParentesco2.Recuperar()


        'Me.cmbparen2.DataTextField = "cdescri"
        'Me.cmbparen2.DataValueField = "ccodigo"
        'Me.cmbparen2.DataSource = mListaTabttab
        'Me.cmbparen2.DataBind()

        'Me.cmbparen3.DataTextField = "cdescri"
        'Me.cmbparen3.DataValueField = "ccodigo"
        'Me.cmbparen3.DataSource = mListaTabttab
        'Me.cmbparen3.DataBind()

    End Sub
    Public Sub cargaDatos()

        entidadClimide.ccodcli = Me.TxtCodigo.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.TxtNomcli.Text = entidadClimide.cnomcli 'ds.Tables(0).Rows(0)("cnomcli")

        Dim ds As New DataSet
        ds = eClimide.ObtenerReferencias(TxtCodigo.Text.Trim)
        'eClimide.ObtenerClimide(entidadClimide)
        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If



        Me.txtcref1.Text = ds.Tables(0).Rows(0)("cnomrefper1")
        Me.txtcdomicilio1.Text = ds.Tables(0).Rows(0)("cdirrefper1")
        cmbTipref1.SelectedValue = Trim(ds.Tables(0).Rows(0)("ctiprefper1"))
        Me.txtctel1.Text = ds.Tables(0).Rows(0)("ctelrefper1")

        Me.txtcref2.Text = ds.Tables(0).Rows(0)("cnomrefper2")
        Me.txtcdomicilio2.Text = ds.Tables(0).Rows(0)("cdirrefper2")
        Me.txtctel2.Text = ds.Tables(0).Rows(0)("ctelrefper2")
        cmbTipref2.SelectedValue = Trim(ds.Tables(0).Rows(0)("ctiprefper2"))

        Me.txtcref3.Text = ds.Tables(0).Rows(0)("cnomrefper3")
        Me.txtcdomicilio3.Text = ds.Tables(0).Rows(0)("cdirrefper3")
        Me.txtctel3.Text = ds.Tables(0).Rows(0)("ctelrefper3")
        cmbTipref3.SelectedValue = Trim(ds.Tables(0).Rows(0)("ctiprefper3"))

        Me.txtcref4.Text = ds.Tables(0).Rows(0)("cnomrefcom1")
        Me.txtcdomicilio4.Text = ds.Tables(0).Rows(0)("cdirrefcom1")
        cmbTipref4.SelectedValue = Trim(ds.Tables(0).Rows(0)("ctiprefcom1"))
        Me.txtctel4.Text = ds.Tables(0).Rows(0)("ctelrefcom1")

        Me.txtcref5.Text = ds.Tables(0).Rows(0)("cnomrefcom2")
        Me.txtcdomicilio5.Text = ds.Tables(0).Rows(0)("cdirrefcom2")
        cmbTipref5.SelectedValue = Trim(ds.Tables(0).Rows(0)("ctiprefcom2"))
        Me.txtctel5.Text = ds.Tables(0).Rows(0)("ctelrefcom2")

        Me.txtcref6.Text = ds.Tables(0).Rows(0)("cnomrefcom3")
        Me.txtcdomicilio6.Text = ds.Tables(0).Rows(0)("cdirrefcom3")
        cmbTipref6.SelectedValue = Trim(ds.Tables(0).Rows(0)("ctiprefcom3"))
        Me.txtctel6.Text = ds.Tables(0).Rows(0)("ctelrefcom3")

    End Sub

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
        Dim lccodcli As String
        lccodcli = Me.TxtCodigo.Text.Trim
        'Grabar Referencias
        Dim lcnomref1, lcnomref2, lcnomref3 As String
        Dim lcnomref4, lcnomref5, lcnomref6 As String

        Dim lcparref1, lcparref2, lcparref3 As String
        Dim lcdomref1, lcdomref2, lcdomref3 As String
        Dim lcdomref4, lcdomref5, lcdomref6 As String

        Dim lctelref1, lctelref2, lctelref3 As String
        Dim lctelref4, lctelref5, lctelref6 As String
        Dim lctraref1, lctraref2, lctraref3 As String
        Dim lcteltraref1, lcteltraref2, lcteltraref3 As String

        lcnomref1 = Me.txtcref1.Text.Trim
        'lcparref1 = Me.cmbparen1.SelectedValue
        lcdomref1 = Me.txtcdomicilio1.Text.Trim
        lctelref1 = Me.txtctel1.Text.Trim
        'lctraref1 = Me.txtclugtra1.Text.Trim
        'lcteltraref1 = Me.txtctel1a.Text.Trim

        lcnomref2 = Me.txtcref2.Text.Trim
        'lcparref2 = Me.cmbparen2.SelectedValue
        lcdomref2 = Me.txtcdomicilio2.Text.Trim
        lctelref2 = Me.txtctel2.Text.Trim
        'lctraref2 = Me.txtclugtra2.Text.Trim
        'lcteltraref2 = Me.txtctel2a.Text.Trim

        lcnomref3 = Me.txtcref3.Text.Trim
        'lcparref3 = Me.cmbparen3.SelectedValue
        lcdomref3 = Me.txtcdomicilio3.Text.Trim
        lctelref3 = Me.txtctel3.Text.Trim
        'lctraref3 = Me.txtclugtra3.Text.Trim
        'lcteltraref3 = Me.txtctel3a.Text.Trim

        lcnomref4 = Me.txtcref4.Text.Trim
        lcdomref4 = Me.txtcdomicilio4.Text.Trim
        lctelref4 = Me.txtctel4.Text.Trim

        lcnomref5 = Me.txtcref5.Text.Trim
        lcdomref5 = Me.txtcdomicilio5.Text.Trim
        lctelref5 = Me.txtctel5.Text.Trim

        lcnomref6 = Me.txtcref6.Text.Trim
        lcdomref6 = Me.txtcdomicilio6.Text.Trim
        lctelref6 = Me.txtctel6.Text.Trim


        'Validaciones Previas
        If Me.txtcref1.Text.Trim.Length = 0 Then
            Response.Write("<script language='javascript'>alert('Nombre de Referencias Vacia, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.txtcref2.Text.Trim.Length = 0 Then
            Response.Write("<script language='javascript'>alert('Nombre de Referencias Vacia, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.txtcdomicilio1.Text.Trim.Length = 0 Then
            Response.Write("<script language='javascript'>alert('Domicilio de Referencias Vacia, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.txtcdomicilio2.Text.Trim.Length = 0 Then
            Response.Write("<script language='javascript'>alert('Domicilio de Referencias Vacia, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Me.txtctel1.Text.Trim.Length < 10 Then
            Response.Write("<script language='javascript'>alert('Número de Telefono Incorrecto, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.txtctel2.Text.Trim.Length < 10 Then
            Response.Write("<script language='javascript'>alert('Número de Telefono Incorrecto, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.txtcelular1.Text.Trim.Length < 10 Then
            Response.Write("<script language='javascript'>alert('Número de Telefono Incorrecto, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.txtcelular2.Text.Trim.Length < 10 Then
            Response.Write("<script language='javascript'>alert('Número de Telefono Incorrecto, Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        Dim lnvalida As Integer

        entidadClimide.ccodcli = Me.TxtCodigo.Text.Trim

        entidadClimide.cNomInv = lcnomref1
        entidadClimide.cDomInv = lcdomref1
        entidadClimide.cPrefe1 = "01"
        entidadClimide.cTelInv = lctelref1
        entidadClimide.cLugInv = ""
        entidadClimide.cTelLugInv = ""

        entidadClimide.cNomFam = lcnomref2
        entidadClimide.cDomFam = lcdomref2
        entidadClimide.cPrefe2 = "01"
        entidadClimide.cTelDño = lctelref2
        entidadClimide.cLugFam = ""
        entidadClimide.cTelLugFam = ""

        entidadClimide.cNomVec = lcnomref3
        entidadClimide.cDomVec = lcdomref3
        entidadClimide.cPrefe3 = "01"
        entidadClimide.cTelVec = lctelref3
        entidadClimide.clugVec = ""
        entidadClimide.cTelLugVec = ""

        entidadClimide.cnomrefcom1 = lcnomref4
        entidadClimide.cnomrefcom2 = lcnomref5
        entidadClimide.cnomrefcom3 = lcnomref6

        entidadClimide.ctelrefcom1 = lctelref4
        entidadClimide.ctelrefcom2 = lctelref5
        entidadClimide.ctelrefcom3 = lctelref6

        entidadClimide.cdirrefcom1 = lcdomref4
        entidadClimide.cdirrefcom2 = lcdomref5
        entidadClimide.cdirrefcom3 = lcdomref6


        entidadClimide.ctiprefper1 = cmbTipref1.SelectedValue.Trim
        entidadClimide.ctiprefper2 = cmbTipref2.SelectedValue.Trim
        entidadClimide.ctiprefper3 = cmbTipref3.SelectedValue.Trim
        entidadClimide.ctiprefcom1 = cmbTipref4.SelectedValue.Trim
        entidadClimide.ctiprefcom2 = cmbTipref5.SelectedValue.Trim
        entidadClimide.ctiprefcom3 = cmbTipref6.SelectedValue.Trim
        entidadClimide.cparentesco = Me.CbxParentesco1.SelectedValue.Trim
        entidadClimide.ctelcelular = Me.txtcelular1.Text.Trim
        entidadClimide.cparentesco1 = Me.CbxParentesco2.SelectedValue.Trim
        entidadClimide.ctelcelular1 = Me.txtcelular2.Text.Trim
        entidadClimide.ccodusu = Session("gccodusu")
        entidadClimide.dfecmod = Session("gdfecsis")

        'lnvalida = eClimide.ActualizaReferencia(entidadClimide)
        lnvalida = eClimide.EliminarReferencias(Me.TxtCodigo.Text.Trim)
        'If lnvalida = 0 Then
        '    Return
        'End If
        'Agrega Referencias
        eClimide.AgregarReferencias(entidadClimide)

        Dim clsppal As New class1
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "GrR", 2)
        '------------------------------------------------------------------
        Response.Write("<script language='javascript'>alert('Referencias Grabadas, OK ')</script>")
        Response.Write("<script>window.close('wbreferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=950,height=550')</script>")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Write("<script>window.close('wbreferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=950,height=550')</script>")
    End Sub

    Protected Sub txtcref2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcref2.TextChanged

    End Sub
End Class


