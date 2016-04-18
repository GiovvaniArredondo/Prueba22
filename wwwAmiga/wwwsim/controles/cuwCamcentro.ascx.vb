

Partial Class cuwCamcentro
    Inherits ucWBase
    Private pcCodCta As String
    Private pcCodPre As String
#Region "Variable"
    'Variable de la clase Mantenimiento
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private Transacc As String
    Private ds As New DataSet
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()
        Me.btnGraba.Disabled = True
        '----------------------------
        'Llenando Centros
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CENTROS"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1' order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxcentros.DataTextField = "cNomgru"
        Me.cbxcentros.DataValueField = "cCodsol"
        Me.cbxcentros.DataSource = ds.Tables("Resultado")
        Me.cbxcentros.DataBind()

        Me.cbxcentros.Visible = True
        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()



        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CENTROS"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1' order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxcentros.DataTextField = "cNomgru"
        Me.cbxcentros.DataValueField = "cCodsol"
        Me.cbxcentros.DataSource = ds.Tables("Resultado")
        Me.cbxcentros.DataBind()

        Me.cbxcentros.Visible = True
        'Me.cbxanacre.DropDownWidth = 300
        ds.Tables("Resultado").Clear()

        Me.btnGraba.Disabled = False

        cargaGrupos()
    End Sub
    Private Sub cargaGrupos()
        Dim lccodcen As String
        lccodcen = Me.cbxcentros.SelectedValue.Trim
        '----------------------------
        'Llenando Grupos
        '----------------------------
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = "Where lactivo ='1' and cCodcen = " & "'" & lccodcen & "'" & "  order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxgrupo.DataTextField = "cNomgru"
        Me.cbxgrupo.DataValueField = "cCodsol"
        Me.cbxgrupo.DataSource = ds.Tables("Resultado")
        Me.cbxgrupo.DataBind()

        ds.Tables("Resultado").Clear()
    End Sub

    Private Sub CargarDatosCredito()
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta
        ecreditos.Obtenercreditos(entidad3)
        Me.txtccodcli.Text = entidad3.ccodcli
        Me.txtccodcta.Text = pcCodCta
        Me.txtcnomcli.Text = entidad3.cnomcli
        Me.txtcnomgrupo.Text = entidad3.cNomUsu
        Dim ecremsol As New cCremsol
        Me.txtcnomcentro.Text = ecremsol.ObtenerNombreCentro2(entidad3.ccodsol)
        Me.txtcnomgrupo.Text = ecremsol.ObtenerNombre(entidad3.ccodsol)
    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        pcCodCta = codigoCliente
        CargarDatosCredito()
    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.Cancela()
    End Sub
    Private Sub Cancela()
        Me.txtcnomcli.Text = " "
        Me.txtccodcli.Text = " "
        Me.txtccodcta.Text = " "
        Me.txtcnomgrupo.Text = " "
        Me.btnGraba.Disabled = True
    End Sub

    Private Sub btnGraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraba.ServerClick
        Dim lccodsol As String
        lccodsol = Me.cbxgrupo.SelectedValue.Trim
        Dim cCremcre As New cremcre
        Dim eCremcre As New cCremcre

        cCremcre.ccodcta = Me.txtccodcta.Text.Trim
        cCremcre.ccodsol = lccodsol
        eCremcre.Actualizargrupo(cCremcre)
        Me.Cancela()
    End Sub

    Protected Sub cbxcentros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcentros.SelectedIndexChanged
        Me.cargaGrupos()
    End Sub
End Class


