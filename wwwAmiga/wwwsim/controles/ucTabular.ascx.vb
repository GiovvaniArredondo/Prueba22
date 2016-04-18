Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Public Class ucTabular
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then

        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim clsppal As New class1
        Dim ds As New DataSet
        ds = clsppal.TabularDatos()
        ExportToExcel(ds.Tables(0))
    End Sub
    Private Sub ExportToExcel(ByVal dt As DataTable)
        Dim sb As New StringBuilder()
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim dg As New GridView

        dg.AllowPaging = False
        dg.PagerSettings.Visible = False
        dg.AutoGenerateColumns = True
        dg.RowStyle.HorizontalAlign = HorizontalAlign.Left

        Dim Page As New Page()
        Dim form As New HtmlForm()



        dg.DataSource = dt 'esta es una funcion que ya lo debes tener hecha, te tiene que retornar un datatabla para llenar tu grilla
        dg.DataBind()

        Page.EnableEventValidation = False

        Page.DesignerInitialize()

        Page.Controls.Add(form)
        form.Controls.Add(dg)

        Page.RenderControl(htw)

        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=Datos.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub

End Class
