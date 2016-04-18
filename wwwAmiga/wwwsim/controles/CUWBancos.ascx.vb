Public Class CUWBancos
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            Me.Initbtn()
        End If
    End Sub
    Private Sub Initbtn()
        Me.txtcnombco.Visible = False
        Me.cmbbancos.Visible = True
        Me.cmbFondo.Visible = True
        Me.cmbAgencia.Visible = True

        Me.txtcnombco.Text = ""
        Me.txtccodbco.Text = ""
        Me.txtccodcta.Text = ""
        Me.txtcnrochq.Text = ""
        Me.txtcctacte.Text = ""

        Me.txtnsalant.Text = 0
        Me.txtncargos.Text = 0
        Me.txtnabonos.Text = 0
        Me.txtnsalact.Text = 0

        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm
        Dim ds As New DataSet
        Dim ncanti As Integer
        Dim lcyears As String
        Dim lcmesvig As String
        Dim lccadena As String
        Dim clssconta As New clsConta

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))
        ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.txtdfecha1.Text = ds.Tables(0).Rows(0)("dFecimes")
        Me.txtdfecha2.Text = ds.Tables(0).Rows(0)("dFecfmes")

        Me.ImageButton1.Enabled = True
        Me.btnnuevo.Disabled = False
        Me.btneditar.Disabled = True
        Me.btngrabar.Disabled = True
        Me.btnquitar.Disabled = True
        Me.btnundo.Disabled = False

        Me.txtdfecha1.Enabled = False
        Me.txtdfecha2.Enabled = False

        'Informacion del Combo Bancos
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        clsbancos.ObtenerBancosenUso(dsb, Session("gcCodofi"))
        Me.cmbbancos.DataTextField = "cnombco"
        Me.cmbbancos.DataValueField = "ccodbco"
        Me.cmbbancos.DataSource = dsb.Tables(0)
        Me.cmbbancos.DataBind()

        'Informacion de Fondo
        Dim clscretlin As New cCretlin
        Dim mcretlin As New tabtofi
        Dim listalineas As New listacretlin
        Dim mlistatabttab As New listatabttab
        Dim clstabttab As New cTabttab
        mListaTabttab = clstabttab.ObtenerLista("033", "1")

        listalineas = clscretlin.ObtenerLista
        'Dim ClsFondo As New SIM.BL.cTabttab
        'Dim dsb2 As New DataSet
        'dsb2 = ClsFondo.ObtenerLista("033", "1")

        'ClsFondo.ObtenerDataSetPorIDDs(dsb2, "033", "1")
        Me.cmbFondo.DataTextField = "cdescri"
        Me.cmbFondo.DataValueField = "ccodigo"
        Me.cmbFondo.DataSource = mlistatabttab 'dsb2.Tables(0)
        Me.cmbFondo.DataBind()

        'Informacion de Ageencia
        'Dim ClsAgencia As New SIM.BL.cTabtofi
        'Dim dsb1 As New DataSet
        Dim clstabtofi As New cTabtofi
        Dim mtabtofi As New tabtofi
        Dim listaofi As New listatabtofi

        listaofi = clstabtofi.ObtenerListaporNivel2(Session("gnNivel"), Session("gcCodOfi"))


        '        ClsAgencia.ObtenerDataSetPorIDDs(dsb1)
        Me.cmbAgencia.DataTextField = "cnomofi"
        Me.cmbAgencia.DataValueField = "ccodofi"
        Me.cmbAgencia.DataSource = listaofi 'dsb1.Tables(0)
        Me.cmbAgencia.DataBind()
        '' llemar combo tipo de cuenta
        Me.cmAplCuenta.Items.Add("Desembolso")
        Me.cmAplCuenta.Items.Add("Recuperaciones")
        Me.cmAplCuenta.Items.Add("Normal")
    End Sub

    Private Sub ImageButton1_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        cargadatos()
        botonesaplicar()
    End Sub
    Private Sub cargadatos()
        Dim lcbanco, lcagencia, lcfondo, lctipoApli As String
        Dim entidad As New tabtbco
        Dim ebanco As New cTabtbco
        Dim lcflag As Integer



        lcbanco = Me.cmbbancos.SelectedValue.Trim
        entidad.ccodbco = lcbanco


        lcflag = ebanco.ObtenerTabtbco(entidad)
        lcagencia = entidad.ccodofi.Trim
        lcfondo = entidad.cfondos.Trim
        lctipoApli = entidad.cgrupo.Trim
        ' actualiza combos basado en lo que esta en la base de datos
        cmbAgencia.SelectedValue = lcagencia
        cmbFondo.SelectedValue = lcfondo

        If lctipoApli = "DE" Then
            cmAplCuenta.SelectedValue = "Desembolso"
        Else
            If lctipoApli = "RE" Then
                cmAplCuenta.SelectedValue = "Recuperaciones"
            Else
                cmAplCuenta.SelectedValue = "Normal"
            End If
        End If


        If lcflag = 0 Then 'No encontro banco
            Me.txtvalida.Text = "1"
        Else
            Me.txtvalida.Text = "0"
            Me.txtcctacte.Text = entidad.cctacte.Trim
            Me.txtccodcta.Text = entidad.ccodcta.Trim
            Me.txtccodbco.Text = entidad.ccodbco.Trim
            Me.txtcnrochq.Text = entidad.cnocorr
            Me.txtcnombco.Text = entidad.cnombco.Trim

            If entidad.ctipcta.Trim = "A" Then
                Me.rbtn1.Checked = True
                Me.rbtn2.Checked = False
            Else
                Me.rbtn1.Checked = False
                Me.rbtn2.Checked = True
            End If

            If entidad.uso = "1" Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If

            'Busca los saldos a partir de saldo inicial, cargos y abonos
            Dim ecntamov As New cCntamov
            Dim ds As New DataSet
            ds = ecntamov.ObtenerSaldosIniporCuenta(Date.Parse(Me.txtdfecha1.Text), Date.Parse(Me.txtdfecha2.Text), Me.txtccodcta.Text.Trim)
            If ds.Tables(0).Rows.Count = 0 Then
                Me.txtnsalant.Text = 0
                Me.txtncargos.Text = 0
                Me.txtnabonos.Text = 0
                Me.txtnsalant.Text = 0
            Else
                Me.txtnsalant.Text = Math.Round(ds.Tables(0).Rows(0)("nsalini"), 2)
                Me.txtncargos.Text = Math.Round(ds.Tables(0).Rows(0)("nDebe"), 2)
                Me.txtnabonos.Text = Math.Round(ds.Tables(0).Rows(0)("nhaber"), 2)

                If Me.txtccodcta.Text.Trim.Substring(0, 1) = "1" Or _
                   Me.txtccodcta.Text.Trim.Substring(0, 1) = "5" Or _
                   Me.txtccodcta.Text.Trim.Substring(0, 1) = "7" Then
                    Me.txtnsalact.Text = Math.Round(Double.Parse(Me.txtnsalant.Text) + Double.Parse(Me.txtncargos.Text) - _
                                         Double.Parse(Me.txtnabonos.Text), 2)
                Else
                    Me.txtnsalact.Text = Math.Round(Double.Parse(Me.txtnsalant.Text) - Double.Parse(Me.txtncargos.Text) + _
                                         Double.Parse(Me.txtnabonos.Text), 2)

                End If

            End If
        End If



    End Sub

    Private Sub btnnuevo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.ServerClick
        Me.cmbbancos.Visible = False
        Me.txtcnombco.Visible = True
        Dim etabtbco As New cTabtbco
        Me.txtccodbco.Text = etabtbco.maxbanco.Trim
        Me.txtvalida.Text = "1"
        Me.Activar()

    End Sub
    Private Sub botonesinsert()
        Me.ImageButton1.Enabled = True
        Me.btnnuevo.Disabled = False
        Me.btneditar.Disabled = True
        Me.btngrabar.Disabled = False
        Me.btnquitar.Disabled = True
        Me.btnundo.Disabled = False
    End Sub
    Private Sub botonesaplicar()
        Me.ImageButton1.Enabled = True
        Me.btnnuevo.Disabled = False
        Me.btneditar.Disabled = False
        Me.btngrabar.Disabled = False
        Me.btnquitar.Disabled = True
        Me.btnundo.Disabled = False
    End Sub
    Private Sub Activar()
        Me.txtcnombco.Enabled = True
        Me.txtcnombco.Text = ""

        Me.txtcctacte.Enabled = True
        Me.txtcctacte.Text = ""

        Me.txtccodcta.Enabled = True
        Me.txtccodcta.Text = ""

        Me.txtcnrochq.Enabled = True
        Me.txtcnrochq.Text = ""

        Me.txtnsalant.Enabled = True
        Me.txtnsalant.Text = 0

        Me.txtncargos.Text = 0
        Me.txtnabonos.Text = 0
        Me.txtnsalact.Text = 0
        Me.botonesinsert()

    End Sub

    Private Sub btngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.ServerClick
        'Verifica si existe cuenta contable
        Dim lcbanco As String
        Dim lcAplCuenta As String
        Dim ectbmcta As New cCtbmcta
        Dim lcvalida As Integer
        lcvalida = ectbmcta.ValidarCuenta(Me.txtccodcta.Text.Trim)
        If lcvalida = "0" Then
            Exit Sub
        End If
        'valida informacion vacia
        If Me.txtcnombco.Text.Trim = "" Then
            Exit Sub
        End If
        If Me.txtcctacte.Text.Trim = "" Then
            Exit Sub
        End If

        If cmAplCuenta.SelectedValue = "Desembolso" Then
            lcAplCuenta = "DE"
        End If
        If cmAplCuenta.SelectedValue = "Recuperaciones" Then
            lcAplCuenta = "RE"
        End If
        If cmAplCuenta.SelectedValue = "Normal" Then
            lcAplCuenta = ""
        End If
      
        'lcAplCuenta = Me.cmAplCuenta.SelectedValue.Trim()



        Dim entidad As New tabtbco
        Dim ebanco As New cTabtbco
        Dim lcflag As Integer

        lcbanco = Me.txtccodbco.Text.Trim
        entidad.ccodbco = lcbanco
        entidad.cnombco = Me.txtcnombco.Text.Trim
        entidad.ctipcta = IIf(Me.rbtn1.Checked = True, "A", "C")
        'entidad.cgrupo = IIf(Me.rbtn3.Checked = True, "RE", "DE")
        entidad.cgrupo = lcAplCuenta
        entidad.cctacte = Me.txtcctacte.Text.Trim
        entidad.cserie = ""
        entidad.cnroini = ""
        entidad.cnrofin = ""
        entidad.ccodcta = Me.txtccodcta.Text.Trim
        entidad.cnocorr = Me.txtcnrochq.Text.Trim
        entidad.nmondeb = 0
        entidad.nmonhab = 0
        entidad.saldant = Double.Parse(Me.txtnsalant.Text)
        entidad.ncargos = Double.Parse(Me.txtncargos.Text)
        entidad.nabonos = Double.Parse(Me.txtnabonos.Text)
        entidad.saldact = Double.Parse(Me.txtnsalact.Text)
        entidad.uso = IIf(Me.CheckBox1.Checked, "1", "0")
        'entidad.cguberna = ""
        'entidad.cnomcta = ""
        entidad.cfondos = Me.cmbFondo.SelectedValue
        'entidad.ccodreg = ""
        'entidad.cflag = ""
        entidad.ccodofi = Me.cmbAgencia.SelectedValue
        If Me.txtvalida.Text = "1" Then 'Nuevo
            lcflag = ebanco.Agregar(entidad)
            If lcflag = 1 Then
                Response.Write("<script language='javascript'>alert('Banco Registrado')</script>")
            End If
        Else 'Modificar
            lcbanco = Me.cmbbancos.SelectedValue.Trim
            lcflag = ebanco.ActualizarTabtbco(entidad)
        End If

        'Me.Activar()
        Me.Initbtn()
    End Sub


    Private Sub btnundo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnundo.ServerClick
        Me.Activar()
    End Sub

    Private Sub btneditar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.ServerClick
        Me.txtvalida.Text = "0"
        Me.txtccodcta.Enabled = True
        Me.txtcctacte.Enabled = True

        Me.txtcnrochq.Enabled = True
        Me.cmbbancos.Visible = False
        Me.txtcnombco.Visible = True
        Me.txtcnombco.Enabled = True

        Me.botonesinsert()
    End Sub

   
End Class
