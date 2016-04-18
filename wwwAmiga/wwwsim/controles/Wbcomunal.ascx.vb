Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class Wbcomunal
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

#Region " Variables "
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clase As New SIM.BL.class1
    Private cls_Sim As New SIM.BL.ClsSolicitud

    Private pcCodCta As String
    'Private lNuevo As Boolean
    Private vCnn As Boolean
    Private Transacc As String
    Private ds As New DataSet
    Private ds_R As New DataSet
    Private lnindice_R As Integer
    Private lnindice_R1 As Integer
    Private lncodigo_R As String
    Private lnVal_R As String
    Private llBan_R As Boolean = False
    Private x As Integer
    Private y As Integer
    Private lnusu_R As String
    Private lnapl_R As String


    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    '--------------------------------  
    Private pcTipCre As String
    Private pcNrolin As String
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String

    Private vDetalle As New DataSet

    Private cClsDes As New SIM.BL.clsDesembolsa

    Private _URLCodigo As String
    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Private _ClienteSeleccionado As String
    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.cargarcombos()
            Me.BuscaMunicipios()
            Me.BuscaCantones()
            Me.CargarDatos()
            Me.Deshabilitar()

            Me.Datagrid1.Columns(5).Visible = False
        End If

    End Sub

#Region " Metodos "
    Private Sub cargarcombos()
        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Departamento
        mTabtZon = clsTabtZon.ObtenerLista("1")
        Me.cmbDep.DataTextField = "cDesZon"
        Me.cmbDep.DataValueField = "cCodzon"
        Me.cmbDep.DataSource = mTabtZon
        Me.cmbDep.DataBind()

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista("2")
        Me.cmbMun.DataTextField = "cDesZon"
        Me.cmbMun.DataValueField = "cCodzon"
        Me.cmbMun.DataSource = mTabtZon
        Me.cmbMun.DataBind()

        'Canton
        mTabtZon = clsTabtZon.ObtenerLista("3")
        Me.cmbCant.DataTextField = "cDesZon"
        Me.cmbCant.DataValueField = "cCodzon"
        Me.cmbCant.DataSource = mTabtZon
        Me.cmbCant.DataBind()

        Dim clsceentros As New SIM.BL.ccentros
        Dim mcentros As New listacentros

        'Canton
        mcentros = clsceentros.ObtenerLista()
        Me.cmbCentro.DataTextField = "cnomgru"
        Me.cmbCentro.DataValueField = "cCodsol"
        Me.cmbCentro.DataSource = mcentros
        Me.cmbCentro.DataBind()

        Me.cmbDep.SelectedValue = "01"
        Me.cmbMun.SelectedValue = "0101"
        Me.cmbCant.SelectedValue = "010101"
    End Sub
    Private Sub CargarDatos()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        ds = etabtofi.ObtenerDataSetPorNivel2(Session("gnNivel"), Session("gcCodOfi"))

        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.CbxCodOFi.DataTextField = "cNomOfi"
        Me.CbxCodOFi.DataValueField = "cCodOfi"
        Me.CbxCodOFi.DataSource = ds.Tables(0)
        Me.CbxCodOFi.DataBind()

        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Institucion
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0541'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.cbxCodins.DataTextField = "cDescri"
        Me.cbxCodins.DataValueField = "cCodigo"
        Me.cbxCodins.DataSource = ds.Tables("Resultado")
        Me.cbxCodins.DataBind()


        ds.Tables("Resultado").Clear()
        Me.txtflag.Text = 0
        Me.txtflag.Visible = False




    End Sub
    Private Sub BuscaCredito()


    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Dim pccodsol As String
        Me.txtcodcli.Value = codigoCliente
        pccodsol = codigoCliente
        'Nombre del Cliente
        Dim entidadCremsol As New SIM.EL.cremsol
        Dim eCremsol As New SIM.BL.cCremsol
        Me.cargarcombos()

        entidadCremsol.cCodsol = Me.txtcodcli.Value.Trim
        eCremsol.ObtenerCremsol(entidadCremsol)
        Me.txtcnomcli.Text = entidadCremsol.cnomgru.Trim
        Me.Textbox1.Text = entidadCremsol.cnomgru.Trim
        Me.Textbox2.Text = entidadCremsol.cdiareu.Trim
        Me.Textbox3.Text = entidadCremsol.chora
        Me.Textbox4.Text = entidadCremsol.cdirdom.Trim
        Me.Textbox5.Text = entidadCremsol.cfrecreu.Trim
        Me.CheckBox1.Checked = entidadCremsol.lactivo
        If IsDBNull(entidadCremsol.cCodzon) Or entidadCremsol.cCodzon = Nothing Then
        Else
            Me.cmbDep.SelectedValue = entidadCremsol.cCodzon.Substring(0, 2)
            Me.cmbMun.SelectedValue = entidadCremsol.cCodzon.Substring(0, 4)
            Me.cmbCant.SelectedValue = entidadCremsol.cCodzon.Substring(0, 6)
        End If
        If IsDBNull(entidadCremsol.cCodcen) Or entidadCremsol.cCodcen = Nothing Then
        Else
            Me.cmbCentro.SelectedValue = entidadCremsol.cCodcen
        End If

        Me.lblMostrar.Text = "MODIFICACION"
        Me.txtNroCta.Value = pccodsol.Substring(6, 6)
        'Institución                        
        Me.cbxCodins.Value = pccodsol.Substring(0, 3)
        'Oficina                        
        Me.CbxCodOFi.Value = pccodsol.Substring(3, 3)

        Me.btnAplica.Disabled = False
        Me.btnGraba.Disabled = False

        Me.Textbox1.Enabled = True
        Me.Textbox2.Enabled = True
        Me.Textbox3.Enabled = True
        Me.Textbox4.Enabled = True
        Me.Textbox5.Enabled = True

        Me.cmbDep.Enabled = True
        Me.cmbMun.Enabled = True
        Me.cmbCant.Enabled = True
        Me.cmbCentro.Enabled = True
        'Me.btnAplica_ServerClick(Me, New System.EventArgs)

        Dim dslista As New DataSet
        dslista = eCremsol.ListaMiembros(pccodsol)
        Me.ViewState.Add("antal", dslista.Tables(0))

        Datagrid1.DataSource = dslista.Tables(0).DefaultView
        Datagrid1.DataBind()

    End Sub

    Private Sub Deshabilitar()
        Me.Textbox1.Enabled = False
        Me.Textbox2.Enabled = False
        Me.Textbox3.Enabled = False
        Me.Textbox4.Enabled = False
        Me.Textbox5.Enabled = False

        Me.cmbDep.Enabled = False
        Me.cmbMun.Enabled = False
        Me.cmbCant.Enabled = False
        Me.cmbCentro.Enabled = False


    End Sub

    Private Sub Habilita()
        Me.Textbox1.Enabled = True
        Me.Textbox2.Enabled = True
        Me.Textbox3.Enabled = True
        Me.Textbox4.Enabled = True
        Me.Textbox5.Enabled = True

        Me.Textbox1.Text = ""
        Me.Textbox2.Text = ""
        Me.Textbox3.Text = ""
        Me.Textbox4.Text = ""
        Me.Textbox5.Text = ""

        Me.Datagrid1.DataSource = ""
        Datagrid1.DataBind()
    End Sub
    Private Sub validacodigo()
        'Me.txtccodtmp.Text = Me.cbxCodins.Value.Trim & Me.CbxCodOFi.Value.Trim
    End Sub
#End Region

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAplica_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplica.ServerClick
        Me.Habilita()
        Me.lblMostrar.Text = "NUEVO"
        Me.btnGraba.Disabled = False
        Me.btnAplica.Disabled = True

        Me.cbxCodins.Disabled = False
        Me.CbxCodOFi.Disabled = False
        Me.txtNroCta.Disabled = True

        Me.cmbDep.Enabled = True
        Me.cmbMun.Enabled = True
        Me.cmbCant.Enabled = True

        Me.cmbCentro.Enabled = True
        Me.txtcodcli.Value = ""
    End Sub

    Private Sub btnGraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraba.ServerClick
        'Valida datos para grabar
        If Textbox1.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Datos Vacíos ')</script>")
            Exit Sub
        End If

        'Verifica nombre del grupo
        Dim ecremsol As New cCremsol
        Dim lvalida As Boolean
        lvalida = ecremsol.ObtieneCodigoxNombre(Me.txtcodcli.Value, Me.Textbox1.Text.Trim, Me.CbxCodOFi.Value.Trim)
        If lvalida = False Then
            Response.Write("<script language='javascript'>alert('Nombre Reservado ')</script>")
            Exit Sub
        End If

        Dim Valor As String
        cls_Sim.Tipo = Me.lblMostrar.Text
        cls_Sim.Cuenta = Me.txtNroCta.Value.Trim
        cls_Sim._cnomgru = Me.Textbox1.Text.Trim
        cls_Sim._cdiareu = Me.Textbox2.Text.Trim
        cls_Sim._chora = Me.Textbox3.Text.Trim
        cls_Sim._cdirdom = Me.Textbox4.Text.Trim
        cls_Sim._cfrecreu = Me.Textbox5.Text.Trim
        cls_Sim._ccodofi = Me.CbxCodOFi.Value.Trim
        cls_Sim._ccodins = Me.cbxCodins.Value.Trim

        cls_Sim.Institucion = Me.cbxCodins.Value.Trim
        cls_Sim.Oficina = Me.CbxCodOFi.Value.Trim
        cls_Sim._ccodzon = Me.cmbCant.SelectedItem.Value.Trim
        cls_Sim._ccodcen = Me.cmbCentro.SelectedItem.Value.Trim


        cls_Sim._lactivo = Me.CheckBox1.Checked

        Valor = cls_Sim.Graba_Grupo("02")

        If Valor = "0" Then
            Exit Sub
        Else
            Dim lccodsol As String = cls_Sim._ccodsol
            'Resetea Miembros
            cls_Sim.Resetea_Miembros(lccodsol)
            'Agrega Miembros
            Dim xy As Integer = 0
            For xy = 0 To Me.Datagrid1.Items.Count - 1
                cls_Sim.Graba_Miembros(lccodsol, Me.Datagrid1.Items(xy).Cells(5).Text)
            Next


            If Valor <> "" Then
                Response.Write("<script language='javascript'>alert('Codigo de Grupo Generado es  " & Valor & " ')</script>")
            Else
                Response.Write("<script language='javascript'>alert('Proceso Correcto')</script>")
            End If
        End If


        Me.btnAplica.Disabled = False
        Me.btnGraba.Disabled = True
        Me.Deshabilitar()
    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.ServerClick
        Me.btnAplica.Disabled = False
        Me.btnGraba.Disabled = True
        Me.Deshabilitar()
    End Sub

    Public Sub BuscaMunicipios()

        Me.cmbMun.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.cmbDep.SelectedItem.Value.Trim, "2")
        Me.cmbMun.DataTextField = "cDesZon"
        Me.cmbMun.DataValueField = "cCodzon"
        Me.cmbMun.DataSource = mTabtZon
        Me.cmbMun.DataBind()


    End Sub

    Public Sub BuscaCantones()

        Me.cmbCant.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.cmbMun.SelectedItem.Value.Trim, "3")
        Me.cmbCant.DataTextField = "cDesZon"
        Me.cmbCant.DataValueField = "cCodzon"
        Me.cmbCant.DataSource = mTabtZon
        Me.cmbCant.DataBind()

    End Sub

    Protected Sub cmbDep_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDep.SelectedIndexChanged
        Me.BuscaMunicipios()
        Me.BuscaCantones()
    End Sub

    Protected Sub cmbMun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMun.SelectedIndexChanged
        Me.BuscaCantones()
    End Sub
    Public Sub MiembrosBanco(ByVal codigocliente As String)
        '
        Dim i As Integer = 0
        i = Verifica(codigocliente)
        If i = 1 Then
            Response.Write("<script language='javascript'>alert('Cliente Ya Existe')</script>")
            Exit Sub
        End If

        Dim ecremsol As New cCremsol
        Dim lverifica As Boolean
        lverifica = ecremsol.VerificaDuplicidad(codigocliente, Me.txtcodcli.Value.Trim)
        If lverifica = True Then
            Response.Write("<script language='javascript'>alert('Cliente Pertenece a otro Banco/Grupo')</script>")
            Exit Sub

        End If

        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = codigocliente.Trim.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Dim lcnomcli As String
        Dim lcnudoci As String
        Dim ldnacimi As Date


        lcnomcli = entidadClimide.cnomcli.Trim
        lcnudoci = entidadClimide.cnudoci.Trim
        ldnacimi = entidadClimide.dnacimi

        Dim dt As New DataTable
        Dim dr As DataRow
        Try
            If Me.ViewState("antal") Is Nothing Then
                dt.Columns.Add(New DataColumn("ccodcli", GetType(String)))
                dt.Columns.Add(New DataColumn("cnomcli", GetType(String)))
                dt.Columns.Add(New DataColumn("cnudoci", GetType(String)))
                dt.Columns.Add(New DataColumn("dfecnac", GetType(DateTime)))
            Else
                dt = Me.ViewState("antal")
            End If


            dr = dt.NewRow()
            dr("cCodcli") = codigocliente
            dr("cnomcli") = lcnomcli
            dr("cnudoci") = lcnudoci
            dr("dfecnac") = ldnacimi
            dt.Rows.Add(dr)
            Me.ViewState.Add("antal", dt)

            Datagrid1.DataSource = dt.DefaultView
            Datagrid1.DataBind()


        Catch ex As Exception

        End Try




    End Sub

    Protected Sub Datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        Me.txtflag.Text = Me.ClienteSeleccionado
        'Valida que cliente no tenga creditos vigentes para quitarlo ni este en estado de proceso
        'a excepcion que este rechazada la solicitud
        Dim ecremcre As New cCremcre
        Dim lvalida As Boolean
        lvalida = ecremcre.ValidaRetiroGrupo(ClienteSeleccionado)

        If lvalida = False Then
            Response.Write("<script language='javascript'>alert('Cliente tiene Credito Vigente')</script>")
            Exit Sub
        End If

        Dim dt As New DataTable
        Dim dr As DataRow
        Try
            'If Me.ViewState("antal") Is Nothing Then
            dt.Columns.Add(New DataColumn("ccodcli", GetType(String)))
            dt.Columns.Add(New DataColumn("cnomcli", GetType(String)))
            dt.Columns.Add(New DataColumn("cnudoci", GetType(String)))
            dt.Columns.Add(New DataColumn("dfecnac", GetType(DateTime)))
            'Else
            'dt = Me.ViewState("antal")
            'End If

            Dim xy As Integer
            xy = 0
            Dim lccodcli As String
            For xy = 0 To Me.Datagrid1.Items.Count - 1

                lccodcli = Me.Datagrid1.Items(xy).Cells(5).Text
                If lccodcli.Trim = Me.txtflag.Text.Trim Then

                Else
                    dr = dt.NewRow()
                    dr("cCodcli") = Me.Datagrid1.Items(xy).Cells(5).Text
                    dr("cnomcli") = Me.Datagrid1.Items(xy).Cells(2).Text
                    dr("cnudoci") = Me.Datagrid1.Items(xy).Cells(3).Text
                    dr("dfecnac") = Me.Datagrid1.Items(xy).Cells(4).Text
                    dt.Rows.Add(dr)

                End If
            Next


            Me.ViewState.Add("antal", dt)

            Datagrid1.DataSource = dt.DefaultView
            Datagrid1.DataBind()


        Catch ex As Exception

        End Try
    End Sub
    Public Function Verifica(ByVal cCodcli As String) As Integer
        Dim xy As Integer
        Dim lccodcli As String
        xy = 0
        For xy = 0 To Me.Datagrid1.Items.Count - 1
            lccodcli = Me.Datagrid1.Items(xy).Cells(5).Text
            If lccodcli.Trim = cCodcli.Trim Then
                Return 1
            End If
        Next
        Return 0
    End Function

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim ds As New DataSet
        Dim ecremsol As New cCremsol

        Dim lccodsol As String = ""
        Dim lcnomgru As String = ""
        lccodsol = Me.txtcodcli.Value.Trim
        lcnomgru = ecremsol.ObtenerNombre(lccodsol)

        Try
            ds = ecremsol.ListaMiembros(Me.txtcodcli.Value.Trim)

        Catch ex As Exception

        End Try

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim reportes As String
        reportes = "Listado.pdf"

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\Listado.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("cnomgru", lcnomgru)
        crRpt.SetParameterValue("cCodsol", lccodsol)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStreamIA.ToArray())
        'Response.End()
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


    End Sub
End Class
