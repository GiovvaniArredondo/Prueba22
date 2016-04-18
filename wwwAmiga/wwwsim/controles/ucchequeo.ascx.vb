

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

Partial Class ucchequeo
    Inherits ucWBase
   
#Region " Variables "
    Dim cls1 As New SIM.BL.pagdesver
    Private cls2 As New SIM.BL.ClsMantenimiento
    Private clsConvert As New SIM.BL.ConversionLetras
    Dim clsaplica As New SIM.BL.payment
    Dim ecremcre As New cCremcre
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
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aqu� el c�digo de usuario para inicializar la p�gina
        If Not IsPostBack Then
            'Carga Preguntas
            Me.CargaGrid()
        End If

    End Sub
    Private Sub CargaGrid()
        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        ds = ecremcre.CargaListadoChk()
        Me.datagrid1.DataSource = ds.Tables(0)
        Me.datagrid1.DataBind()
        'Me.datagrid1.Columns(4).Visible = False
        'Me.datagrid1.Columns(3).Visible = False
    End Sub
    Private Sub CargaGridCredito(ByVal cCodcta As String)
        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        ds = ecremcre.CargaListadoChkCliente(cCodcta, Session("gcCodusu"))
        If ds.Tables(0).Rows.Count = 0 Then
            Me.CargaGrid()
            Return
        End If
        Me.datagrid1.DataSource = ds.Tables(0)
        Me.datagrid1.DataBind()
        'Me.datagrid1.Columns(4).Visible = False

    End Sub
    Private Sub comprobante()
      

    End Sub
    Private Sub Deshabilitar()


    End Sub
    Private Sub cargarcombos()
   

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.TextBox2.Text = codigoCliente.Trim
        Dim entidadcreditos As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidadcreditos.ccodcta = Me.TextBox2.Text.Trim
        ecreditos.Obtenercreditos(entidadcreditos)
        Me.txtnomcli.Text = entidadcreditos.cnomcli
        Me.txtccodcta.Text = Me.TextBox2.Text.Trim

        Me.CargaGridCredito(Me.TextBox2.Text.Trim)
        'Me.datagrid1.Columns(4).Visible = False

    End Sub
  

    <System.Web.Services.WebMethodAttribute()> <System.Web.Script.Services.ScriptMethodAttribute()> Public Shared Function GetDynamicContent(ByVal contextKey As System.String) As System.String

    End Function

  
  
    'Protected Sub datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles datagrid1.SelectedIndexChanged
    '    Dim ds As New DataSet
    '    ClienteSeleccionado = CType(Me.datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
    '    Me.txtccomodin.Text = Me.ClienteSeleccionado
    '    ds = Datos()
    '    Me.Label4.Text = ds.Tables(0).Rows(0)("cnomchk")
    '    Me.CheckBox1.Checked = ds.Tables(0).Rows(0)("lopcion")


    'End Sub

    Private Function Datos() As DataSet
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim fila As DataRow
        Dim i As Integer = 0
        ds = ecremcre.CargaListadoChkxItem(Me.TextBox2.Text.Trim, Me.txtccomodin.Text.Trim, Session("gcCodusu"))
        Return ds
    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xy As Integer = 0
        Dim lccodchk As String
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            lccodchk = Me.datagrid1.Rows(xy).Cells(4).Text
            If Me.txtccomodin.Text.Trim = lccodchk.Trim Then
                Me.datagrid1.Rows(xy).Cells(3).Text = Me.CheckBox1.Checked
            End If
        Next
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim xy As Integer = 0
        Dim lccodchk As String
        Dim lopcion As Boolean
        Dim ecremcre As New cCremcre
        'elimina listado para grabarlo actualizado
        ecremcre.EliminaListaxUsuario(Me.TextBox2.Text.Trim, Session("gcCodusu"))
        Dim chkCptoAsig As CheckBox
        For xy = 0 To Me.datagrid1.Rows.Count - 1
            ' lopcion = Me.datagrid1.Items(xy).Cells(5).Text 'Me.datagrid1.Items(xy).Cells(3).Text
            chkCptoAsig = CType(Me.datagrid1.Rows(xy).FindControl("CheckBox2"), CheckBox)
            lopcion = chkCptoAsig.Checked

            lccodchk = Me.datagrid1.Rows(xy).Cells(0).Text
            'Graba Listado
            ecremcre.InsertaListaxUsuario(Me.TextBox2.Text.Trim, Session("gcCodusu"), lopcion, lccodchk, Session("gdfecsis"))
        Next
        Response.Write("<script language='javascript'>alert('Listado de Chequeo Grabado')</script>")
    End Sub
End Class

