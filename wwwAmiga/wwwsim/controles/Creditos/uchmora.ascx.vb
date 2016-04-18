Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO

Partial Class controles_uchmora
    Inherits ucWBase


#Region "Privadas"
    Private codigoJs As String = ""
#End Region

#Region "Metodos"
    Public Sub CargarDatos_Cuenta(ByVal codcta As String)

        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi

        Me.txtcCodcta.Text = codcta

        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        ecreditos.ccodcta = codcta

        mcreditos.Obtenercreditos(ecreditos)


        If ecreditos.cestado <> "F" Then
            codigoJs = "<script language='javascript'>alert('Estado del Crédito Errado, " & _
                              "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Limpieza()
            Exit Sub
        End If


        Me.txtcCodcli.Text = ecreditos.ccodcli
        Me.txtcNomcli.Text = ecreditos.cnomcli

    End Sub

    Private Sub Limpieza()
        Me.txtcCodcta.Text = ""
        Me.txtcCodcli.Text = ""
        Me.txtcNomcli.Text = ""
    End Sub

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtdfec1.Text = Session("gdfecsis")
            CargaCombo()
            Limpieza()
        End If
    End Sub
    Private Sub CargaCombo()
        Dim clsTabtusu As New SIM.BL.cTabtusu
        Dim mListaTabtUsu As New listatabtusu


        'mListaTabtUsu = clsTabtusu.ObtenerLista("ANA", Session("gccodofi"))

        'Me.ddlanalistas.DataTextField = "cNomusu"
        'Me.ddlanalistas.DataValueField = "cCodUsu"
        'Me.ddlanalistas.DataSource = mListaTabtUsu
        'Me.ddlanalistas.DataBind()

        Me.CbxAnalistas1.Recuperar()

        Txtndesde.Text = 1
        Txtnhasta.Text = 9999
    End Sub

    Private Sub imprimir(ByVal reportes As String, ByVal ds As DataSet)

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim lcdireccion As String = ""
        Dim etabtofi As New tabtofi
        Dim mtabtofi As New cTabtofi
        Dim lcFecha As String = ""

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        etabtofi.ccodofi = Session("gccodofi")
        mtabtofi.ObtenerTabtofi(etabtofi)

        lcdireccion = etabtofi.cdireccion.ToString.Trim + " Tel. " + etabtofi.ctelefono

        lcFecha = etabtofi.cmuni.ToString.ToLower.Trim + ", " + Date.Parse(txtdfec1.Text).Day.ToString.Trim + " de " + Meses(Date.Parse(txtdfec1.Text).Month) + " de " + _
                  Date.Parse(txtdfec1.Text).Year.ToString

        crRpt.SetDataSource(ds.Tables(0))
        crRpt.SetParameterValue("cnomins", Session("gcnomins"))
        crRpt.SetParameterValue("ndesde", Integer.Parse(Txtndesde.Text))
        crRpt.SetParameterValue("nhasta", Integer.Parse(Txtnhasta.Text))
        crRpt.SetParameterValue("analista", CbxAnalistas1.SelectedItem.Text.Trim)
        crRpt.SetParameterValue("dfecha", Date.Parse(txtdfec1.Text))
        crRpt.SetParameterValue("pcdireccion", lcdireccion)
        crRpt.SetParameterValue("pcfecha", lcFecha)


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

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        Dim ecreditos As New ccreditos

        ds = ecreditos.ListaCarteraxAnalista(Me.CbxAnalistas1.SelectedValue.Trim)
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

    Protected Sub btncartas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncartas.Click
        Dim lndiasdif As Integer = 0
        Dim lndesde As Integer = 0
        Dim lnhasta As Integer = 0
        Dim ds As New DataSet
        Dim dshaberes As New DataSet
        Dim ecreditos As New ccreditos
        Dim eahomcta As New cAhomcta


        If Date.Parse(txtdfec1.Text) < Session("gdfecsis") Then
            'Response.Write("<script language='javascript'>alert('La Fecha a Calcular no Puede ser Menor a la Fecha del Sistema ')</script>")
            codigoJs = "<script language='javascript'>alert('La Fecha a Calcular no Puede ser Menor a la Fecha del Sistema, " & _
                              "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = True Then
            CheckBox1.Checked = True
        End If

        If Date.Parse(txtdfec1.Text) = Session("gdfecsis") Then
            lndiasdif = 0
        Else
            lndiasdif = DateDiff(DateInterval.Day, Session("gdfecsis"), Date.Parse(txtdfec1.Text))
        End If
        'Obtiene creditos con rango de dias
        lndesde = Integer.Parse(Txtndesde.Text) - lndiasdif
        lnhasta = Integer.Parse(Txtnhasta.Text) - lndiasdif
        If lndesde < 0 Then
            lndesde = 0
        End If
        If lnhasta < 0 Then
            lnhasta = 0
        End If
        'ecreditos.pdfeclim = Session("gdfeclim")
        'ecreditos.pnsegmax = Session("gnsegmax")
        'ecreditos.pdfecseg1 = Session("gdfecseg1")
        'ecreditos.pdfecseg2 = Session("gdfecseg2")
        'ecreditos.pdfecsis = Session("gdfecsis")
        'ecreditos.pnmancta = Session("GNMANCTA")
        'ecreditos.pdfecefec6 = Session("gdfecefec6")
        'ecreditos.pnmancta6 = Session("gnmancta6")
        'ecreditos.pnmancta5 = Session("gnmancta5")
        'ecreditos.pcCostas = Session("gcCostas")
        'ecreditos.pcAnotacion = Session("gcAnotacion")
        'ecreditos.pcDeudores = Session("gcDeudores")
        'ecreditos.pcPorCob = Session("gcPorCob")
        'ecreditos.pnsegvid = Session("gnsegvid")
        ecreditos.pnperbas = Session("gnperbas")

        'If CheckBox1.Checked = True And CheckBox2.Checked = False Then
        '    dshaberes = eahomcta.Haberes(lndesde, lnhasta, ddlanalistas.SelectedValue.Trim)
        '    Me.imprimir("crHaberes.rpt", dshaberes)
        'ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
        '    ds = ecreditos.CalculaCarterayHaberes(Date.Parse(txtdfec1.Text), lndesde, lnhasta, Me.ddlanalistas.SelectedValue.Trim)
        '    imprimir("crHerMora2.rpt", ds)
        'Else
        '    ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), lndesde, lnhasta, Me.ddlanalistas.SelectedValue.Trim)
        '    imprimir("crHerMora.rpt", ds)
        'End If


        'Emision de cartas
        If CheckBox3.Checked = True Then

            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), -999999, 0, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), -999999, 0, Me.CbxAnalistas1.SelectedValue.Trim)
            End If


            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta1.rpt", ds)
        End If
        If CheckBox4.Checked = True Then
            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 1, 21, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 1, 21, Me.CbxAnalistas1.SelectedValue.Trim)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta2.rpt", ds)
        End If
        If CheckBox5.Checked = True Then

            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 22, 35, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 22, 35, Me.CbxAnalistas1.SelectedValue.Trim)
            End If


            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta3.rpt", ds)
        End If
        If CheckBox6.Checked = True Then
            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 36, 63, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 36, 63, Me.CbxAnalistas1.SelectedValue.Trim)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta4.rpt", ds)
        End If
        If CheckBox7.Checked = True Then
            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 64, 90, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 64, 90, Me.CbxAnalistas1.SelectedValue.Trim)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta5.rpt", ds)
        End If
        If CheckBox8.Checked = True Then
            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 91, 104, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 91, 104, Me.CbxAnalistas1.SelectedValue.Trim)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta6.rpt", ds)
        End If

        If CheckBox9.Checked = True Then
            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 105, 118, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 105, 118, Me.CbxAnalistas1.SelectedValue.Trim)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta7.rpt", ds)
        End If
        If CheckBox10.Checked = True Then
            If llBandera_Indiv.Checked = True Then
                ds = ecreditos.CalculaCartera_Individual(Date.Parse(txtdfec1.Text), 119, 9999, Me.txtcCodcta.Text.Trim)
            Else
                ds = ecreditos.CalculaCartera(Date.Parse(txtdfec1.Text), 119, 9999, Me.CbxAnalistas1.SelectedValue.Trim)
            End If

            If ds.Tables(0).Rows.Count = 0 Then
                codigoJs = "<script language='javascript'>alert('No Existen Datos para Mostrar, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
            Me.imprimir("CrCarta8.rpt", ds)
        End If
    End Sub

    Protected Sub Txtnhasta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtnhasta.TextChanged

    End Sub


    Private Function Meses(ByVal nMes As String) As String
        Dim lcMes As String = ""

        Select Case nMes
            Case 1
                lcMes = "Enero"
            Case 2
                lcMes = "Febrero"
            Case 3
                lcMes = "Marzo"
            Case 4
                lcMes = "Abril"
            Case 5
                lcMes = "Mayo"
            Case 6
                lcMes = "junio"
            Case 7
                lcMes = "Julio"
            Case 8
                lcMes = "Agosto"
            Case 9
                lcMes = "Septiembre"
            Case 10
                lcMes = "Octubre"
            Case 11
                lcMes = "Noviembre"
            Case 12
                lcMes = "Diciembre"
        End Select



        Return lcMes
    End Function

    Protected Sub llBandera_Indiv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles llBandera_Indiv.CheckedChanged
        If Me.llBandera_Indiv.Checked = False Then
            Limpieza()
        End If
    End Sub

   
End Class
