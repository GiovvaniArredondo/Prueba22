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


Public Class consulta_plazo
    Inherits System.Web.UI.UserControl
    Private Shared asociado As String, cuenta As String, fecha As Date, dui As String
    Private Shared certificado As String, nombre As String, plazo As String, tasa As String, monto As Decimal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            If Session("gccodusu") = Nothing Then
                Session("gccodusu") = "EMLA"
            End If
            asociado_TextBox.Focus()
        End If
        If Session("gcbuscli") Is Nothing Then
            Session("gcbuscli") = ""
        End If
    End Sub

    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscar_Button.Click
        Session("gcbuscli") = asociado_TextBox.Text.Trim
        foto_Image.Visible = False
        mensaje.Visible = False
        plazos_GridView.Visible = False
        imprimir_Button.Visible = False
        imprimir1_Button.Visible = False


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
        nombre = asociados_GridView.SelectedRow.Cells(2).Text.ToString 'nombre
        dui = asociados_GridView.SelectedRow.Cells(3).Text.ToString 'dui

        Dim miclase As New clase_especial
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "select ccodcrt, nmonapr as nsaldoaho, nplazo, ntasint, dfecori, dfecapr, " & _
                         "dfecven, ccodaho, cpignor, cestado, ccodusu from ahomcrt " & _
                         "where cnudotr = '" & asociado & "' and cliq <> 'S'  order by ccodcrt"

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


    Protected Sub imprimirButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles imprimir_Button.Click

        Dim miclase1 As New clase_funciones
        Dim str_select As String
        Dim letras As String = miclase1.ToString(miclase1.ConversionEnteros(monto))
        Dim vence As String = fecha
        Dim dia As Integer = Day(Session("gdfecsis"))
        Dim mes As String = miclase1.meses_letras(Session("gdfecsis"))
        Dim ano As Integer = Year(Session("gdfecsis"))

        str_select = "select " & miclase1.ToString(nombre) & " as nombre," & miclase1.ToString(asociado) & " as asociado," & miclase1.ToString(dui) & " as dui," & _
                     miclase1.ToString(certificado) & " as certificado," & letras & " as letras," & miclase1.ToString(plazo.ToString & " DIAS") & " as plazo," & _
                     miclase1.ToString(tasa.ToString) & " as tasa," & miclase1.ToString(vence) & " as vence, " & dia & " as dia," & _
                     miclase1.ToString(mes) & " as mes," & ano & " as ano"

        Session("str_select") = str_select

        Response.Redirect("~/reporte_contenedor.aspx?parametro=" & "resguardo")

        'Exit Sub


        ''este es boton 
        'Dim printDoc As New PrintDocument
        '' asignamos el método de evento para cada página a imprimir
        'AddHandler printDoc.PrintPage, AddressOf print_resguardo
        '' indicamos que queremos imprimir
        'printDoc.Print()

    End Sub

    Protected Sub print_resguardo(ByVal sender As Object, _
                               ByVal e As PrintPageEventArgs)

        Dim miclase1 As New clase_funciones
        Dim letras As String = miclase1.ConversionEnteros(monto)
        Dim mes As String = miclase1.meses_letras(fecha)
        '' La fuente a usar
        Dim prtFont As New Font("Arial", 12, FontStyle.Regular)

        Dim lineHeight As Single
        Dim yPos As Single = 30
        Dim leftMargin As Single = 1
        Dim printFont As System.Drawing.Font
        ' Asignar el tipo de letra
        printFont = prtFont
        lineHeight = printFont.GetHeight(e.Graphics)

        'esta es parte de margen de arriba
        For m = 1 To 12
            yPos += lineHeight
            e.Graphics.DrawString("", printFont, Brushes.Black, leftMargin, yPos)
        Next

        yPos += lineHeight
        e.Graphics.DrawString(nombre, printFont, Brushes.Black, 15, yPos)
        yPos += lineHeight
        e.Graphics.DrawString(asociado, printFont, Brushes.Black, 60, yPos)
        yPos += lineHeight
        yPos += lineHeight
        e.Graphics.DrawString(dui, printFont, Brushes.Black, 1, yPos)
        e.Graphics.DrawString(certificado, printFont, Brushes.Black, 475, yPos)
        yPos += lineHeight
        e.Graphics.DrawString(letras.Trim, printFont, Brushes.Black, 150, yPos)

        yPos += lineHeight
        e.Graphics.DrawString(plazo.ToString.Trim & " DIAS", printFont, Brushes.Black, 150, yPos)
        yPos += lineHeight
        yPos += lineHeight
        e.Graphics.DrawString(tasa.ToString.Trim & " %", printFont, Brushes.Black, 70, yPos)
        e.Graphics.DrawString(Left(fecha.ToString, 10), printFont, Brushes.Black, 485, yPos)
        yPos += lineHeight * 4
        e.Graphics.DrawString(Left(fecha.ToString, 2), printFont, Brushes.Black, 220, yPos)
        e.Graphics.DrawString(mes, printFont, Brushes.Black, 310, yPos)
        e.Graphics.DrawString(Left(fecha.ToString, 4), printFont, Brushes.Black, 485, yPos)


    End Sub

    Protected Sub plazos_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plazos_GridView.SelectedIndexChanged
        certificado = plazos_GridView.SelectedRow.Cells(1).Text
        monto = plazos_GridView.SelectedRow.Cells(2).Text
        plazo = plazos_GridView.SelectedRow.Cells(3).Text
        tasa = plazos_GridView.SelectedRow.Cells(4).Text
        fecha = Date.Parse(Left(plazos_GridView.SelectedRow.Cells(5).Text, 10))
        cuenta = plazos_GridView.SelectedRow.Cells(8).Text

        imprimir_Button.Visible = True
        imprimir1_Button.Visible = True
        imprimir_Button.Focus()

    End Sub
    Protected Sub repetir_ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles repetir_ImageButton.Click
        asociado_TextBox.Text = Session("gcbuscli").ToString.Trim
        buscar_Button_Click(sender, e)
    End Sub

    Protected Sub imprimir1_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles imprimir1_Button.Click

        Dim miclase1 As New clase_funciones
        Dim titulo As String
        titulo = miclase1.ToString("CERTIFICADOS A PLAZO VIGENTES POR ASOCIADO")
        Dim str_select = "select " & titulo & " as titulo, cnudotr, ccodcrt, nombre, dfecapr, " & _
                         "dfecven, dfecori, nmonapr, nplazo, ntasint, space(160) as creditos from ahomcrt " & _
                         "where cnudotr = '" & asociado & "' and cliq <> 'S' and nmonapr > 0 order by ccodcrt"

        Session("str_select") = str_select
        Response.Redirect("~/reporte_contenedor.aspx?parametro=" & "certificados")

    End Sub
End Class
