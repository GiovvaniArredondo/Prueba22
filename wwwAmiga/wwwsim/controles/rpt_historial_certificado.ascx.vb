Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Drawing.Printing

Public Class rpt_historial_certificado
    Inherits System.Web.UI.UserControl
    Private Shared asociado As String
    Private Shared certificado As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            If Session("gccodusu") = Nothing Then
                Session("gccodusu") = "EMLA"
            End If
            If Session("gcbuscli") Is Nothing Then
                Session("gcbuscli") = ""
            End If

            asociado_TextBox.Focus()
        End If
    End Sub

    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscar_Button.Click
        Session("gcbuscli") = asociado_TextBox.Text.Trim
        foto_Image.Visible = False
        mensaje.Visible = False
        plazos_GridView.Visible = False

        Dim ds As DataSet
        Dim miclase As New clase_especial
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.buscar_asociado(con, asociado_TextBox.Text.Trim.ToUpper)
        con.Close()

        asociados_GridView.DataSource = ds
        asociados_GridView.DataBind()
        asociados_GridView.Visible = True

        If asociados_GridView.Rows.Count = 0 Then
            mensaje.Text = "No existen concordancias!!!"
            mensaje.Visible = True
        End If

    End Sub
    Protected Sub asociados_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociados_GridView.SelectedIndexChanged
        asociado = asociados_GridView.SelectedRow.Cells(1).Text.ToString 'asociado

        Dim miclase As New clase_especial
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "set language spanish; select ccodcrt, nsaldoaho, nplazo, ntasint, dfecori, dfecapr, " & _
                         "dfecven, ccodaho, cpignor, cestado, ccodusu from ahomcrt " & _
                         "where cnudotr = '" & asociado & "' and nmonapr > 0 order by dfecori"

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        plazos_GridView.DataSource = ds
        plazos_GridView.DataBind()
        plazos_GridView.Visible = True
        foto_firma(asociado)

    End Sub

    Protected Sub foto_firma(ByVal asociado As String)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, 1)
        If huella1 <> "basura" Then
            foto_Image.Height = 75
            foto_Image.Width = 100
            foto_Image.ImageUrl = huella1
            foto_Image.Visible = True
        End If

    End Sub

    Protected Sub plazos_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plazos_GridView.SelectedIndexChanged
        certificado = plazos_GridView.SelectedRow.Cells(1).Text
        imprimir_Button.Visible = True
        imprimir_Button.Focus()

    End Sub

    Protected Sub imprimir_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles imprimir_Button.Click
        Dim miclase1 As New clase_funciones
        Dim str_select As String
        str_select = "set language spanish;  select 'HISTORIAL DE DEPOSITOS A PLAZO' as titulo, ven.nintere," & _
                         " ven.dfecpro, crt.nmonapr, crt.nplazo, crt.nombre, crt.cnudotr, crt.ccodcrt," & _
                         "crt.cctacte, crt.ntasint, crt.cpignor, crt.cliq, crt.dfecapr," & _
                         "crt.dfecven, crt.dfecori from vencidos as ven, ahomcrt as crt " & _
                         "where crt.ccodcrt = " & miclase1.ToString(certificado) & " and crt.ccodcrt = ven.ccodcrt "

        Session("str_select") = str_select

        Response.Redirect("~/reporte_contenedor.aspx?parametro=" & "historial_certificado")

    End Sub

    Protected Sub repetir_ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles repetir_ImageButton.Click
        asociado_TextBox.Text = Session("gcbuscli").ToString.Trim
        buscar_Button_Click(sender, e)
    End Sub
End Class
