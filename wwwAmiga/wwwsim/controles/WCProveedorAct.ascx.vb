Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO



Partial Class WCProveedorAct

    Inherits ucWBase
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)
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

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarCombos()
            Deshabilitar()
            CargarGrid()
        End If
    End Sub
    Private Sub Deshabilitar()
        'ddlcuenta.Enabled = False
        'TextBox2.Enabled = False
        'TextBox3.Enabled = False
        'txtdfec.Enabled = False
        'Button1.Enabled = True
        'Button2.Enabled = False
        'Button5.Enabled = False

        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox1.Enabled = False
        TextBox9.Enabled = False

        TextBox6.Text = ""
        TextBox7.Text = 0
        TextBox8.Text = 0
        TextBox1.Text = ""
        TextBox9.Text = 0

        flag.Text = "0"
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub
    Private Sub Habilitar()
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox1.Enabled = True
        TextBox9.Enabled = True

        'ddlcuenta.Enabled = True
        'TextBox2.Enabled = True
        'TextBox3.Enabled = True
        'Button1.Enabled = True
        'Button2.Enabled = True
        'Button5.Enabled = False

        'TextBox2.Text = ""
        'TextBox3.Text = 0
        'txtdfec.Text = Session("gdfecsis")

        Button1.Enabled = True
        Button2.Enabled = True

        'txtdfec.Enabled = True
    End Sub




    Private Sub CargarCombos()
        'Dim clsctbmcta As New cCtbmcta
        'Dim ds As New DataSet
        'ds = clsctbmcta.CatalagoCombo()
        'Me.ddlcuenta.DataTextField = "cdescri"
        'Me.ddlcuenta.DataValueField = "ccodcta"
        'Me.ddlcuenta.DataSource = ds
        'Me.ddlcuenta.DataBind()



    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Habilitar()
        flag.Text = "0"

    End Sub


    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim = "" Or TextBox6.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Espacios Vacios')</script>")
            Return

        End If

        'Verifica si existe nit
        Dim entidadcntaemp As New cntaemp
        Dim ecntaemp As New cCntaemp

        Dim lprocede As Boolean
        lprocede = ecntaemp.Nuevo(TextBox6.Text.Trim)

        If lprocede = False And flag.Text = "0" Then
            Response.Write("<script language='javascript'>alert('NIT ya esta Registrado')</script>")
            Return

        End If

        entidadcntaemp.ccodemp = TextBox6.Text.Trim
        entidadcntaemp.dfecreg = Session("gdfecsis")
        entidadcntaemp.ccodusu = Session("gccodusu")
        entidadcntaemp.cdescri = TextBox1.Text.Trim
        entidadcntaemp.nporiva = Double.Parse(TextBox7.Text)
        entidadcntaemp.nporisrs = Double.Parse(TextBox8.Text)
        entidadcntaemp.nporisrb = Double.Parse(TextBox9.Text)
        entidadcntaemp.dfecmod = Now
        entidadcntaemp.cflc = ""
        entidadcntaemp.ccodruc = ""

        Try
            If flag.Text = "0" Then
                ecntaemp.Agregar(entidadcntaemp)
            Else
                ecntaemp.ActualizarCntaemp(entidadcntaemp)
            End If


            Response.Write("<script language='javascript'>alert('Grabado OK')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Ocurrio un Problema')</script>")
        End Try


        'actualiza grid
        CargarGrid()
        Deshabilitar()
    End Sub

    Private Sub CargarGrid()
        Dim ds As New DataSet
        Dim ecntaemp As New cCntaemp

        ds = ecntaemp.ObtenerProveedores()


        'Dim eregistrocaja As New cRegistroCaja
        'Dim ds As New DataSet
        'Dim xy As Integer = 0

        'Dim lnmonto As Double = 0
        'Dim nmonto As TextBox

        'ds = eregistrocaja.ObtenerIngresos(Date.Parse(txtdfecha.Text), ddlcajero.SelectedValue.Trim, "I")

        If ds.Tables(0).Rows.Count = 0 Then
        Else
            Datagrid1.DataSource = ds
            Datagrid1.DataBind()

            Me.Deshabilitar()
        End If

    End Sub


    Private Sub imprimir(ByVal reportes As String, ByVal ds As DataSet)

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        'crRpt.SetParameterValue("cnomins", Session("gcnomins"))
        'crRpt.SetParameterValue("lcnomusu", Me.ddlcajero.SelectedItem.Text.Trim)
        'crRpt.SetParameterValue("cnumpar", TextBox4.Text)
        'crRpt.SetParameterValue("titulo", "INGRESOS DE CAJA")

        reportes &= ".pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True

        Response.ContentType = "application/pdf"
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()

    End Sub

    Protected Sub Datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        flag.Text = "1"
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        CargaDatos(ClienteSeleccionado)
    End Sub

    Private Sub CargaDatos(ByVal ccodemp As String)
        Dim entidadcntaemp As New cntaemp
        Dim ecntaemp As New cCntaemp

        entidadcntaemp.ccodemp = ccodemp.Trim
        ecntaemp.ObtenerCntaemp(entidadcntaemp)

        TextBox6.Text = ccodemp
        TextBox7.Text = entidadcntaemp.nporiva
        TextBox8.Text = entidadcntaemp.nporisrs
        TextBox1.Text = entidadcntaemp.cdescri
        TextBox9.Text = entidadcntaemp.nporisrb
    End Sub

    Private Sub datagrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles Datagrid1.PageIndexChanged
        If Me.IsPostBack Then
            Me.Datagrid1.CurrentPageIndex = 0
            Me.Datagrid1.CurrentPageIndex = e.NewPageIndex
            Me.CargarGrid() 'este sería el procedimiento que se encarga de llenar tu datagrid.
        End If
    End Sub
End Class
