Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.IO
Imports Ionic.Zip
Imports System.Net.Mail


Public Class ReportesGestion
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Listas()
        End If
    End Sub
    Public Sub Listas()
        Dim lccodins As String
        Dim etabtofi As New cTabtofi
        lccodins = etabtofi.ObtenerRegiondeUsuario(Session("gccodusu"))
        '----------------------------
        'Llenando Institucion
        '----------------------------
        Dim etabttab As New cTabttab
        Dim ds As New DataSet
        ds = etabttab.ObtenerDatasetTabla("054", lccodins)


        Me.ddlregion.DataTextField = "cDescri"
        Me.ddlregion.DataValueField = "cCodigo"
        Me.ddlregion.DataSource = ds.Tables(0)
        Me.ddlregion.DataBind()

        ds.Tables(0).Clear()

        CargarOficina()
        Me.CbxAnalistas1.Recuperar()

        TxtDate1.Text = Session("gdfecsis")
        TxtDate2.Text = Session("gdfecsis")
    End Sub
    Private Sub CargarOficina()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        Dim ds As New DataSet
        ds = etabtofi.ObtenerOficinasdeRegion(ddlregion.SelectedValue.Trim, Session("gccodofi"), Session("gnNivel"))
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            btnimprimir.Enabled = False
            Exit Sub
        Else
            btnimprimir.Enabled = True
        End If


        Me.ddloficinas.DataTextField = "cNomOfi"
        Me.ddloficinas.DataValueField = "cCodOfi"
        Me.ddloficinas.DataSource = ds.Tables(0)
        Me.ddloficinas.DataBind()


        ds.Tables(0).Clear()
    End Sub
  
    Protected Sub ddlregion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlregion.SelectedIndexChanged
        CargarOficina()
    End Sub

    Protected Sub btnimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim egestion As New cGestion
        Dim ds As New DataSet
        Dim lccodreg As String
        Dim lccodofi As String
        Dim lccodana As String
        Dim clsppal As New class1

        If chqregiones.Checked = True Then
            lccodreg = "*"
        Else
            lccodreg = ddlregion.SelectedValue.Trim
        End If
        If chqoficinas.Checked = True Then
            lccodofi = "*"
        Else
            lccodofi = ddloficinas.SelectedValue.Trim
        End If
        If chqgestores.Checked = True Then
            lccodana = "*"
        Else
            lccodana = Me.CbxAnalistas1.SelectedValue.Trim
        End If



        Dim dsdatos As New DataSet

        If cbxopciones.SelectedValue = 1 Then
            ds = egestion.ObtieneGestiones(Date.Parse(TxtDate1.Text), Date.Parse(TxtDate2.Text), lccodreg, lccodofi, lccodana)
            dsdatos = clsppal.Filtrar(ds.Tables(0), "lvalida='0'")
            If dsdatos.Tables(0).Rows.Count = 0 Then
                Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
                Exit Sub
            Else
                imprimir("RepGestion1.rpt", dsdatos)
            End If
        ElseIf cbxopciones.SelectedValue = 2 Then
            ds = egestion.ObtieneConveniosPagados(Date.Parse(TxtDate1.Text), Date.Parse(TxtDate2.Text), lccodreg, lccodofi, lccodana)
            dsdatos = clsppal.Filtrar(ds.Tables(0), "lvalida='1'")
            If dsdatos.Tables(0).Rows.Count = 0 Then
                Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
                Exit Sub
            Else
                imprimir("RepGestion2.rpt", dsdatos)
            End If
        ElseIf cbxopciones.SelectedValue = 3 Then
            ds = egestion.ObtieneGestiones(Date.Parse(TxtDate1.Text), Date.Parse(TxtDate2.Text), lccodreg, lccodofi, lccodana)

            If ds.Tables(0).Rows.Count = 0 Then
                Response.Write("<script language='javascript'>alert('No Existe Información ')</script>")
                Exit Sub
            Else
                imprimir("RepGestion3.rpt", ds)
            End If
        End If
    End Sub

    Protected Sub chqregiones_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chqregiones.CheckedChanged
        If chqregiones.Checked = True Then
            chqoficinas.Checked = True
            chqoficinas.Enabled = True
        Else
            chqoficinas.Checked = False
            chqoficinas.Enabled = False
        End If
    End Sub
    Private Sub imprimir(ByVal reportes As String, ByVal ds As DataSet)
        Dim lcgestor As String = ""
        Dim lccodusu As String = ""
        Dim lccodreg As String
        Dim lccodofi As String
        Dim clsppal As New class1
        If chqregiones.Checked = True Then
            lccodreg = "TODAS LAS REGIONES "
        Else
            lccodreg = "REGIÓN: " & ddlregion.SelectedItem.Text.Trim
        End If
        If chqoficinas.Checked = True Then
            lccodofi = "TODAS LAS AGENCIAS"
        Else
            lccodofi = "AGENCIA: " & ddloficinas.SelectedItem.Text.Trim
        End If

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        crRpt.SetDataSource(ds.Tables(0))
        '  crRpt.SetParameterValue("gestor", "")
        crRpt.SetParameterValue("region", lccodreg)
        crRpt.SetParameterValue("agencia", lccodofi)

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
End Class
