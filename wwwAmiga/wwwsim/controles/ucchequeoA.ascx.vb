
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports System.Environment
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System

Partial Class ucchequeoA
    Inherits ucWBase
   
#Region " Variables "
    Dim cls1 As New SIM.BL.pagdesver
    Private cls2 As New SIM.BL.ClsMantenimiento
    Private clsConvert As New SIM.BL.ConversionLetras
    Dim clsaplica As New SIM.BL.payment
    Dim etabtofi As New cTabtofi
    Dim pncomper As Double = 0
    Dim pnsegdeu As Double = 0
    Dim dsnopagos As New DataSet
    Dim ecremsol As New cCremsol

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
    Dim dsimprimepagos As New DataSet

#End Region
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
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Carga Preguntas
            Me.CargaGrid()
        End If

    End Sub
   
    Private Sub CargaGrid()
        Dim etabtofi As New cTabtofi()
        Dim ds As New DataSet
        ds = etabtofi.CargaAgenciaChk()
        
        Me.GridView1.DataSource = ds.Tables(0)
        Me.GridView1.DataBind()

        'Me.datagrid1.Columns(4).Visible = False
        'Me.datagrid1.Columns(3).Visible = False
    End Sub
    Private Sub CargaGridCredito(ByVal cCodcta As String)

    End Sub
    Private Sub comprobante()


    End Sub
    Private Sub Deshabilitar()

    End Sub
    Private Sub cargarcombos()


    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        'Me.TextBox2.Text = codigoCliente.Trim
        'Dim ecremsol As New cCremsol

        'Me.txtnomgru.Text = ecremsol.ObtenerNombre(codigoCliente)
        'Me.txtccodcta.Text = codigoCliente.Trim

        'Me.CargaGridCredito(Me.TextBox2.Text.Trim)
        'Me.datagrid1.Columns(4).Visible = False

        'If codigoCliente.Trim.Substring(6, 2) = "02" Then
        '    Label1.Text = "Banco Comunal:"
        '    Label3.Text = "CHEQUEO DE CONTROL DE EXPEDIENTES DE PRESTAMOS COMUNALES"
        'Else
        '    Label1.Text = "Grupo Solidario:"
        '    Label3.Text = "CHEQUEO DE CONTROL DE EXPEDIENTES DE PRESTAMOS SOLIDARIOS"
        'End If

    End Sub
  

    <System.Web.Services.WebMethodAttribute()> <System.Web.Script.Services.ScriptMethodAttribute()> Public Shared Function GetDynamicContent(ByVal contextKey As System.String) As System.String

    End Function

    Private Function Datos() As DataSet
        Dim ds As New DataSet
        Dim etabtofi As New cTabtofi
        Dim fila As DataRow
        Dim i As Integer = 0
        ds = etabtofi.CargaAgenciaChk()
        Return ds
    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim xy As Integer = 0
        'Dim lccodchk As String
        'For xy = 0 To Me.datagrid1.Items.Count - 1
        '    lccodchk = Me.datagrid1.Items(xy).Cells(4).Text
        '    If Me.txtccomodin.Text.Trim = lccodchk.Trim Then
        '        Me.datagrid1.Items(xy).Cells(3).Text = Me.CheckBox1.Checked
        '    End If
        'Next

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.CargaGrid()
    End Sub

    Protected Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'Dim xy As Integer = 0
        'Dim lccodchk As String
        'For xy = 0 To Me.datagrid1.Items.Count - 1
        '    Me.datagrid1.Items(xy).Cells(3).Text = True
        'Next

    End Sub

    
    Protected Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim tot As Label = DirectCast(e.Row.FindControl("Label1"), Label)

            Dim status As String = tot.Text 'texto.Text.Trim 
            If status = "Cerrada" Then
                e.Row.BackColor = Color.FromName("#33CC33")
            Else
                e.Row.BackColor = Color.FromName("#FF0000")
            End If
        End If
    End Sub

End Class


