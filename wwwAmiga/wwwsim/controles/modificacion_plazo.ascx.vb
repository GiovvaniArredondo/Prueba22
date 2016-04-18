'Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class modificacion_plazo
    Inherits System.Web.UI.UserControl
    Private Shared asociado As String
    Private Shared certificado As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            asociado_TextBox.Focus()
            If Session("gcbuscli") Is Nothing Then
                Session("gcbuscli") = ""
            End If
        End If
    End Sub

    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscar_Button.Click
        Session("gcbuscli") = asociado_TextBox.Text.Trim
        foto_Image.Visible = False
        mensaje.Visible = False
        plazos_GridView.Visible = False
        actualizar_Button.Visible = False
        nombre_Label.Visible = False
        monto_Label.Visible = False
        plazo_Label.Visible = False
        tasa_Label.Visible = False
        fec_apertura_Label.Visible = False
        cta_ahorro_Label.Visible = False

        nombre_TextBox.Visible = False
        monto_TextBox.Visible = False
        plazo_TextBox.Visible = False
        tasa_TextBox.Visible = False
        fec_apertura_TextBox.Visible = False
        cta_ahorro_TextBox.Visible = False
        cta_ahorro_DropDownList.Visible = False

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
    Private Sub cargagrid2()
        asociado = asociados_GridView.SelectedRow.Cells(1).Text.ToString 'asociado
        txtccodcli.Text = asociado.Trim
        Dim miclase As New clase_especial()
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "select ccodcrt, nombre, nsaldoaho, nplazo, ntasint, dfecapr, dfecven, ccodaho from ahomcrt " & _
                         "where cnudotr = '" & asociado & "' and cliq <> 'S' and nmonapr > 0 order by ccodcrt"

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        plazos_GridView.DataSource = ds
        plazos_GridView.DataBind()
        plazos_GridView.Visible = True

        foto_firma(asociado)

    End Sub
    Protected Sub asociados_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociados_GridView.SelectedIndexChanged
        cargagrid2()
    End Sub

    Protected Sub plazos_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plazos_GridView.SelectedIndexChanged

        plazos_GridView.Visible = True
        actualizar_Button.Visible = True
        nombre_Label.Visible = True
        monto_Label.Visible = True
        plazo_Label.Visible = True
        tasa_Label.Visible = True
        fec_apertura_Label.Visible = True
        cta_ahorro_Label.Visible = True

        nombre_TextBox.Visible = True
        monto_TextBox.Visible = True
        plazo_TextBox.Visible = True
        tasa_TextBox.Visible = True
        fec_apertura_TextBox.Visible = True
        cta_ahorro_TextBox.Visible = True
        cta_ahorro_DropDownList.Visible = True

        certificado = plazos_GridView.SelectedRow.Cells(1).Text
        nombre_TextBox.Text = plazos_GridView.SelectedRow.Cells(2).Text
        monto_TextBox.Text = plazos_GridView.SelectedRow.Cells(3).Text
        plazo_TextBox.Text = plazos_GridView.SelectedRow.Cells(4).Text
        tasa_TextBox.Text = plazos_GridView.SelectedRow.Cells(5).Text
        fec_apertura_TextBox.Text = Left(plazos_GridView.SelectedRow.Cells(6).Text.ToString, 10)
        cta_ahorro_TextBox.Text = plazos_GridView.SelectedRow.Cells(8).Text

        actualizar_Button.Visible = True

        Dim miclase As New clase_especial()
        Dim ds As DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "select ccodaho from ahomcta where cnudotr = '" & asociado & "' order by ccodaho"

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        dt = ds.Tables("tabla")
        
        For Each fila In dt.Rows
            cta_ahorro_DropDownList.Items.Add(fila("ccodaho"))
        Next

        nombre_TextBox.Focus()


    End Sub

    Protected Sub cta_ahorro_DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cta_ahorro_DropDownList.SelectedIndexChanged
        cta_ahorro_TextBox.Text = cta_ahorro_DropDownList.SelectedValue
    End Sub

    Protected Sub actualizar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles actualizar_Button.Click
        Dim miclase As New clase_especial()
        Dim miclase1 As New clase_funciones()
        Dim error100 As Integer = 0
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim nombre As String = nombre_TextBox.Text.ToUpper
        Dim plazo As Decimal = Integer.Parse(plazo_TextBox.Text)
        Dim tasa As Decimal = Decimal.Parse(tasa_TextBox.Text)
        Dim fec1 As Date = Date.Parse(fec_apertura_TextBox.Text)
        Dim fec2 As Date = DateAdd(DateInterval.Day, plazo, fec1)
        Dim fec10 As String = fec1
        Dim fec11 As String = fec2
        Dim ccodaho As String = cta_ahorro_TextBox.Text.Trim
        Dim str_select = "SET LANGUAGE spanish; update ahomcrt " & _
                         "set nombre='" & nombre & "', nplazo=" & plazo & ", ntasint=" & tasa & ", dfecapr='" & fec10 & "', " & _
                         "dfecven='" & fec11 & "', ccodaho='" & ccodaho & "' where ccodcrt = '" & certificado & "'"

        con.ConnectionString = stringconnection
        con.Open()

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no actualizado"
            mensaje.Visible = True
            actualizar_Button.Visible = False
            con.Close()
            Return
        End If
        con.Close()
        Response.Write(miclase1.mensaje("Certificado Actualizado..."))
        'mensaje.Text = "Certificado Actualizado..."
        'mensaje.Visible = True
        actualizar_Button.Visible = False

        cargagrid2()
        ''----------------------------------

        'Dim lndepositos As Decimal = 0
        'txtdepositos.Text = ObtenerDepositos()

        'lndepositos = Double.Parse(txtdepositos.Text)

        'lndepositos = lndepositos + Double.Parse(monto_TextBox.Text)

        'If (Double.Parse(monto_TextBox.Text) >= 5000.0 And Double.Parse(monto_TextBox.Text) <= 57000) Or _
        '(lndepositos > 57000) Then
        '    MsgBox("Los Depositos Realizados a 30 días Superan el Limite de LAVADO " + Chr(13) + "DE DINERO Permitido, Esta Advertencia Debe de ser Trasladada  " + Chr(13) + "al Jefe de Mercadeo ,para que LLene el Formulario Correspondiante y sea Enviado a LA FISCALIA DE LA REPUBLICA ", MsgBoxStyle.Information)
        '    'Response.Write("<script language='javascript'>alert('Los Depositos Realizados a 30 días Superan el Limite de LAVADO ' + CHR(13) + 'DE DINERO Permitido, Esta Advertencia Debe de ser Trasladada al Jefe de Mercadeo ' + CHR(13) + 'Para que LLene el Formulario Correspondiante y sea Enviado a LA FISCALIA DE LA REPUBLICA ')</script>")
        '    lavado()

        'End If
        ''----------------------------------
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
    Private Sub lavado()
        '        Try

        Dim origen As String
        Dim Destino As String
        Dim lcnomcli As String = ""
        Dim ldnacimi As Date = Session("gdfecsis")
        Dim lcsexo As String = ""
        Dim lcdui As String = ""
        Dim lcteldom As String = ""
        Dim lccelular As String = ""
        Dim lccodpro As String = ""
        Dim lcprofesion As String = ""
        Dim lcestciv As String = ""
        Dim lccivil As String = ""
        Dim lcdirdom As String = ""
        Dim etabtprf As New cTabtprf
        Dim entidadtabtprf As New tabtprf
        Dim eclimide As New cClimide
        Dim entidadclimide As New climide
        Dim etabttab As New cTabttab
        Dim ds As New DataSet


        ds = eclimide.ObtenerDatosClimide(txtccodcli.Text.Trim)

        origen = InputBox("Digite Origen ", "Digite Origen")
        Destino = InputBox("Digite Destino ", "Digite Destino")


        entidadclimide.ccodcli = txtccodcli.Text.Trim
        eclimide.ObtenerClimide(entidadclimide)

        lcnomcli = entidadclimide.cnomcli.Trim
        ldnacimi = entidadclimide.dnacimi
        lcsexo = entidadclimide.csexo
        lcdui = entidadclimide.cnudoci
        lcteldom = entidadclimide.cteldom
        lccelular = entidadclimide.cTelFam
        lccodpro = entidadclimide.ccodpro
        lcestciv = entidadclimide.cestciv
        lccivil = etabttab.Describe(lcestciv, "012")
        lcdirdom = entidadclimide.cdirdom

        entidadtabtprf.ccodigo = lccodpro
        etabtprf.ObtenerTabtprf(entidadtabtprf)

        lcprofesion = entidadtabtprf.cdescri


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream


        Try
            'Cargar Definicion del Reporte
            If Double.Parse(monto_TextBox.Text) >= 5000 And Double.Parse(monto_TextBox.Text) <= 57000 Then
                crRpt.Load(Server.MapPath("reportes") + "\CrLavado.rpt", OpenReportMethod.OpenReportByDefault)
            Else
                crRpt.Load(Server.MapPath("reportes") + "\CrLavado2.rpt", OpenReportMethod.OpenReportByDefault)
            End If

        Catch ex As Exception
            ' Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("pcorigen", origen)
        crRpt.SetParameterValue("pcdestino", Destino)

        crRpt.SetParameterValue("id1", "")
        crRpt.SetParameterValue("id2", "")
        crRpt.SetParameterValue("id3", "")
        crRpt.SetParameterValue("id4", "")
        crRpt.SetParameterValue("id5", "")
        crRpt.SetParameterValue("id6", "X")
        crRpt.SetParameterValue("id7", "")

        crRpt.SetParameterValue("nmonto1", 0)
        crRpt.SetParameterValue("nmonto2", 0)
        crRpt.SetParameterValue("nmonto3", 0)
        crRpt.SetParameterValue("nmonto4", 0)
        crRpt.SetParameterValue("nmonto5", 0)
        crRpt.SetParameterValue("nmonto6", Double.Parse(monto_TextBox.Text))
        crRpt.SetParameterValue("nmonto7", 0)

        crRpt.SetParameterValue("pccodcli", txtccodcli.Text.Trim)
        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pdnacimi", ldnacimi)
        crRpt.SetParameterValue("pcsexo", lcsexo)
        crRpt.SetParameterValue("pcdui", lcdui)
        crRpt.SetParameterValue("pcteldom", (lcteldom + " " + lccelular))
        crRpt.SetParameterValue("pcprofesion", lcprofesion)
        crRpt.SetParameterValue("pccivil", lccivil)
        crRpt.SetParameterValue("pcdirdom", lcdirdom)

        Dim reportes As String

        reportes = "Lavado.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

        '       Catch ex As Exception

        '      End Try

    End Sub
    Private Function ObtenerDepositos() As Decimal
        Dim clsppal As New class1
        Dim ldfecini As Date
        Dim lccodaho As String = ""
        Dim eahomcta As New cAhomcta
        Dim ds As New DataSet
        Dim lndepositos As Decimal = 0
        ldfecini = DateAdd(DateInterval.Day, -30, Session("gdfecsis"))
        'Obtiene codigo de cuenta de ahorro
        lndepositos = clsppal.ObtenerSumadeDepositos(txtccodcli.Text.Trim, ldfecini)


        Return lndepositos
    End Function

    Protected Sub repetir_ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles repetir_ImageButton.Click
        asociado_TextBox.Text = Session("gcbuscli").ToString.Trim
        buscar_Button_Click(sender, e)
    End Sub


End Class
