Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Drawing.Printing

Public Class rpt_historial_ahorros
    Inherits ucWBase


#Region "Privadas"
    Private Shared cuenta As String
    Private Shared asociado As String
    Private codigoJs As String
#End Region

#Region "Metodos"
    Private Sub Invisible(ByVal bandera As Boolean)

        llBandera.Visible = bandera
        lblUsuario78.Visible = bandera
        lblUsuario79.Visible = bandera
        Txtdfecini.Visible = bandera
        Image_btn2.Visible = bandera

        lblUsuario96.Visible = bandera
        lblUsuario81.Visible = bandera
        Txtdfecfin.Visible = bandera
        Image_btn3.Visible = bandera

        btnHistori.Visible = bandera
    End Sub

    Private Sub Buscar()
        foto_image.Visible = False
        If asociado_TextBox.Text.Length = 0 Then
            Return
        End If
        mensaje.Visible = False
        generar_Button.Visible = False

        Session("gcbuscli") = Me.asociado_TextBox.Text.Trim

        'Dim ds As DataSet
        'Dim miclase As New clase_jaime
        'Dim miclase1 As New clase_funciones
        'Dim con As New SqlConnection
        'Dim stringconnection As String = miclase.conexion()

        'con.ConnectionString = stringconnection
        'con.Open()

        'ds = miclase.buscar_asociado1(con, asociado_TextBox.Text.Trim.ToUpper)
        'con.Close()

        'GridViewDatos.DataSource = ds
        'GridViewDatos.DataBind()
        'GridViewDatos.Visible = True


        Dim asociado As String = asociado_TextBox.Text.Trim
        Dim ds_find As New DataSet
        Dim occlass_cli As New cClimide
        Dim lntipo As Integer = 1

        Dim letra As Char = Left(asociado, 1)

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            lntipo = 3
        End If


        ds_find = occlass_cli.Extraer_Datos_Socio(lntipo, asociado)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        GridViewDatos.DataSource = ds_find
        GridViewDatos.DataBind()

        If GridViewDatos.Rows.Count = 0 Then
            mensaje.Text = "No existen concordancias!!!"
            mensaje.Visible = True
        End If

    End Sub

#End Region



    Protected Sub cuentas_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cuentas_GridView.SelectedIndexChanged
        'cuenta = cuentas_GridView.SelectedRow.Cells(1).Text.ToString 'cuenta de ahorro
        'Try
        '    cargarhistorial()
        'Catch ex As Exception

        'End Try

        'generar_Button.Visible = True
        Invisible(True)
        btnHistori.Enabled = True
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Text = Session("gcbuscli")
        If Page.IsPostBack = False Then
            asociado_TextBox.Focus()
            Txtdfecini.Text = Session("gdfecsis")
            Txtdfecfin.Text = Session("gdfecsis")
        End If
    End Sub

    
    Protected Sub foto_firma(ByVal asociado As String)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, 1)
        If huella1 <> "basura" Then
            foto_image.Height = 75
            foto_image.Width = 100
            foto_image.ImageUrl = huella1
            foto_image.Visible = True
        End If

    End Sub

    Private Sub cargarhistorial()
        Dim miclase1 As New clase_funciones
        Dim asoc As String = miclase1.ToString(asociado)
        Dim cta As String = miclase1.ToString(cuenta)
        Dim str_select As String
        'set language spanish;
        str_select = " select cli.ccodcli, cli.cnomcli, aho.ccodaho, aho.notas, aho.nlibreta, aho.nsaldoaho, trs.cnomtrs, " & _
                          "mov.dfecope, mov.ccodusu, mov.nnum, mov.ctipope, mov.cnumdoc, mov.clinea, " & _
                          "mov.cnrochq, mov.nmonto, mov.nsaldoaho as saldo " & _
                          "from climide as cli, ahomcta as aho, ahommov as mov, ahomtrs as trs " & _
                          "where aho.ccodaho = " & cta & " and aho.cnudotr = cli.ccodcli and " & _
                          "aho.ccodaho = mov.ccodaho And substring(aho.ccodaho, 7, 2) = trs.ccodtrs " & _
                          "order by mov.dfecope, mov.nnum "
        '"order by mov.dfecope, mov.ncorrel "

        Session("str_select") = str_select

        'Response.Redirect("~/reporte_contenedor.aspx?parametro=" & "rpt_historial_ahorros")

        Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_historial_ahorros")
    End Sub

    Private Sub cargarhistorial_Filtro_Fechas(ByVal pdfecini As Date, ByVal pdfecfin As Date)
        Dim miclase1 As New clase_funciones
        Dim asoc As String = miclase1.ToString(asociado)
        Dim cta As String = miclase1.ToString(cuenta)
        Dim str_select As String
        str_select = "set language spanish; select cli.ccodcli, cli.cnomcli, aho.ccodaho, aho.notas, aho.nlibreta, aho.nsaldoaho, trs.cnomtrs, " & _
                          "mov.dfecope, mov.ccodusu, mov.nnum, mov.ctipope, mov.cnumdoc, mov.clinea, " & _
                          "mov.cnrochq, mov.nmonto, mov.nsaldoaho as saldo " & _
                          "from climide as cli, ahomcta as aho, ahommov as mov, ahomtrs as trs " & _
                          "where aho.ccodaho = " & cta & " and aho.cnudotr = cli.ccodcli and " & _
                          "aho.ccodaho = mov.ccodaho And substring(aho.ccodaho, 7, 2) = trs.ccodtrs " & _
                          "and mov.dfecope >= '" & pdfecini & "' and mov.dfecope <= '" & pdfecfin & "'" & _
                          "order by mov.dfecope, mov.nnum "
        '"order by mov.dfecope, mov.ncorrel "

        Session("str_select") = str_select


        Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_historial_ahorros")
    End Sub

    Protected Sub generar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles generar_Button.Click
        cargarhistorial()
    End Sub

    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles buscar_Button.Click
        'Buscar()

        Dim asociado As String = asociado_TextBox.Text.Trim
        Dim ds_find As New DataSet
        Dim occlass_cli As New cClimide
        Dim lntipo As Integer = 1

        Dim letra As Char = Left(asociado, 1)

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            lntipo = 3
        End If


        ds_find = occlass_cli.Extraer_Datos_Socio(lntipo, asociado)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        GridViewDatos.DataSource = ds_find
        GridViewDatos.DataBind()

        Invisible(False)
        cuentas_GridView.Visible = False
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        asociado_TextBox.Text = TextBox1.Text.Trim
        buscar_Button_Click(sender, e)
    End Sub


    Protected Sub GridViewDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridViewDatos.PageIndexChanging
        GridViewDatos.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridViewDatos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridViewDatos.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridViewDatos.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridViewDatos.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridViewDatos.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridViewDatos.PageIndex + 1
        End If
    End Sub


    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
                GridViewDatos.PageIndex = iNumPag - 1
            Else
                GridViewDatos.PageIndex = 0
            End If
        End If
        Call Buscar()
    End Sub

    Protected Sub GridViewDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewDatos.SelectedIndexChanged
        'asociado = asociados_GridView.SelectedRow.Cells(1).Text.ToString 'asociado
        asociado = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado
        Dim miclase As New clase_jaime()
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim fila As DataRow
        Dim tot_ahorros As Decimal = 0


        con.ConnectionString = stringconnection
        con.Open()
        ds = miclase.buscar_ctas_ahorro(con, asociado.ToString, 1)
        con.Close()

        For Each fila In ds.Tables(0).Rows
            tot_ahorros = tot_ahorros + fila("saldo")
        Next

        total_ahorros_TextBox.Text = Format(tot_ahorros, "#,###,###.##")
        total_ahorros_Label.Visible = True
        total_ahorros_TextBox.Visible = True

        cuentas_GridView.DataSource = ds
        cuentas_GridView.DataBind()
        cuentas_GridView.Visible = True

        foto_firma(asociado)

    End Sub


    Protected Sub btnHistori_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHistori.Click
        'cuenta = cuentas_GridView.SelectedRow.Cells(1).Text.ToString 'cuenta de ahorro
        cuenta = cuentas_GridView.SelectedRow.Cells(1).Text.ToString
        Try

            If llBandera.Checked = True Then
                cargarhistorial_Filtro_Fechas(Date.Parse(Me.Txtdfecini.Text), Date.Parse(Me.Txtdfecfin.Text))
            Else
                cargarhistorial()
            End If

        Catch ex As Exception

        End Try
    End Sub

    
    Protected Sub llBandera_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles llBandera.CheckedChanged
        If llBandera.Checked = True Then
            Me.Txtdfecini.Enabled = True
            Me.Txtdfecfin.Enabled = True
        Else
            Me.Txtdfecini.Enabled = False
            Me.Txtdfecfin.Enabled = False
        End If
    End Sub
End Class
