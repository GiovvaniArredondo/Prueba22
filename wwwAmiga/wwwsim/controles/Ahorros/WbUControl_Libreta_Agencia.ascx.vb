
Partial Class controles_Ahorros_WbUControl_Libreta_Agencia
    Inherits ucWBase

#Region "Privadas"
    Private vDetalle As New DataSet
    Private codigoJs As String = ""
    Dim occlass As New cTabttab
#End Region

#Region "Metodos"

    Public Sub Cargar_Datos()


        Me.CbxOficinas1.Recuperar()
        Me.CbxOficinas2.Recuperar()
        'Me.CbxFondos1.Recuperar()
        'If Me.CbxBancos3.Items.Count > 1 Then
        '    Me.CbxBancos3.Items.Clear()
        'End If

        'Dim ListaItem As New ListItem

        'ListaItem.Value = "00"
        'ListaItem.Text = "Selecccione una Cta. Bancaria"
        CbxOficinas1.SelectedValue = Session("GCCODOFI")
        CbxOficinas2.SelectedValue = Session("GCCODOFI")
        Buscar()
    End Sub


    Private Sub Limpieza()
        'Me.CbxFondos1.SelectedValue = "00"
        'Me.CbxEstado.SelectedValue = "00"
        Me.TxtnDesde.Text = "0"
        Me.TxtnHasta.Text = "0"
        Me.Txtnactual.Text = "0"
        Me.Txtdfecasi.Text = Session("GDFECSIS")
        CbxOficinas2.SelectedValue = Session("GCCODOFI")
        cbxestado.SelectedValue = "00"
    End Sub


    Private Sub Habilita(ByVal llbandera As Boolean)
        '        Me.CbxFondos1.Enabled = llbandera
        Me.TxtnDesde.Enabled = llbandera
        Me.TxtnHasta.Enabled = llbandera
        '       Me.CbxEstado.Enabled = llbandera
        Me.Txtnactual.Enabled = llbandera
        Me.Txtdfecasi.Enabled = llbandera
        CbxOficinas2.Enabled = llbandera
        cbxestado.Enabled = llbandera
        'Me.Txtdfecini.Enabled = llbandera
        'Me.Txtdfecfin.Enabled = llbandera

    End Sub


    Private Sub Buscar()

        vDetalle = occlass.Extrae_Datos_Libretas(Me.CbxOficinas1.SelectedValue.Trim, "*")

        If vDetalle.Tables(0).Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnCancel.Enabled = False
            'btnnew.Enabled = True
            Btnprint.Enabled = False
        Else
            btnEdit.Enabled = True
            btnCancel.Enabled = True
            'btnnew.Enabled = False
            Btnprint.Enabled = True
        End If

        GridOfi.DataSource = vDetalle.Tables(0)
        GridOfi.DataBind()


    End Sub


#End Region


    Protected Sub btnnew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.Habilita(True)
        Me.btnnew.Enabled = False
        Me.Btnsave.Enabled = True
        Me.btnCancel.Enabled = True
        Me.btnEdit.Enabled = False
        Me.Txtdfecasi.Text = Session("gdfecsis")
    End Sub

    Protected Sub CbxOficinas1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxOficinas1.SelectedIndexChanged
        Buscar()
    End Sub

    Protected Sub GridOfi_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridOfi.PageIndexChanging
        GridOfi.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridOfi_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridOfi.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridOfi.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridOfi.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridOfi.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridOfi.PageIndex + 1
        End If
    End Sub

    Protected Sub GridOfi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOfi.SelectedIndexChanged

        Me.CbxOficinas2.SelectedValue = GridOfi.SelectedRow.Cells(1).Text.ToString.Trim         'Oficina
        Me.TxtnDesde.Text = GridOfi.SelectedRow.Cells(3).Text.ToString.Trim                     'Desde
        Me.TxtnHasta.Text = GridOfi.SelectedRow.Cells(4).Text.ToString.Trim                     'Hasta
        Me.Txtnactual.Text = GridOfi.SelectedRow.Cells(5).Text.ToString.Trim                    'No Libreta Actual

        If GridOfi.SelectedRow.Cells(6).Text.ToString.Trim = "ACTIVO" Then 'Estado
            Me.cbxestado.SelectedValue = "01"
        Else
            Me.cbxestado.SelectedValue = "02"
        End If


        Me.Txtdfecasi.Text = GridOfi.SelectedRow.Cells(7).Text.ToString.Trim                    'Fecha de Asignación
        
        Me.btnEdit.Enabled = True

    End Sub

    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Habilita(True)
        Me.btnCancel.Enabled = True
        Me.Btnsave.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnnew.Enabled = False
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnnew.Enabled = True
        Me.Btnsave.Enabled = False
        Me.btnCancel.Enabled = False
        Me.btnEdit.Enabled = False
    End Sub

    Protected Sub Btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Dim lnRetorno As Integer
        Dim array_d As New ArrayList


        If Double.Parse(Me.TxtnDesde.Text) = 0 Then
            Response.Write("<script language='javascript'>alert('Rango Desde Invalido, no se puede continuar, " & _
                           "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Double.Parse(Me.TxtnHasta.Text) = 0 Then
            Response.Write("<script language='javascript'>alert('Rango Desde Invalido, no se puede continuar, " & _
                           "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        If Double.Parse(Me.TxtnDesde.Text) > Double.Parse(Me.TxtnHasta.Text) Then
            Response.Write("<script language='javascript'>alert('Intervalo Errado, no se puede continuar, " & _
                           "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Double.Parse(Me.Txtnactual.Text) > Double.Parse(Me.TxtnHasta.Text) Then
            Response.Write("<script language='javascript'>alert('Número actual Errado, no se puede continuar, " & _
                           "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        If Me.cbxestado.SelectedValue.Trim = "00" Then
            Response.Write("<script language='javascript'>alert('Seleccione un Estado correcto, " & _
                                     "Advertencia SIM.NET')</script>")
            Exit Sub
        End If

        array_d.Add(Me.CbxOficinas2.SelectedValue.Trim)       'Oficina        
        array_d.Add(Double.Parse(Me.TxtnDesde.Text))          'Desde
        array_d.Add(Double.Parse(Me.TxtnHasta.Text))          'hasta
        array_d.Add(Double.Parse(Me.Txtnactual.Text))         'No Actual
        array_d.Add(Me.cbxestado.SelectedValue.Trim)          'Estado
        array_d.Add(Date.Parse(Me.Txtdfecasi.Text))           'Fecha de asignacion
        array_d.Add(Session("gccodusu"))                      'Usuario



        lnRetorno = occlass.Mantenimiento_Oficinas_Libretas(array_d)


        If lnRetorno = 0 Then
            'codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
            '            "Advertencia SIM.NET ')</script>"
            'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Response.Write("<script language='javascript'>alert('Ocurrio un Error, " & _
                           "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        Buscar()

        Habilita(False)
        Limpieza()
        Me.Btnsave.Enabled = False
        Me.btnnew.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnCancel.Enabled = True
    End Sub

    Private Sub Imprimir(ByVal ds_Print As DataSet, ByVal mi_rptEmp As Object)

        Dim parameters(2, 1) As String

        'Armando Matriz de variables
        parameters(0, 0) = ("gcNominst")
        parameters(0, 1) = ("SOCIEDAD COOPERATIVA DE AHORRO Y CREDITO AMC DE R.L DE C.V.")
        parameters(1, 0) = ("pdfecha")
        'parameters(1, 1) = (Date.Parse(Me.Txtdfecini.Text))
        'parameters(2, 0) = ("pdfecha1")
        'parameters(2, 1) = (Date.Parse(Me.Txtdfecfin.Text))


        Me.GenerarReporte_New(ds_Print, Server.MapPath("reportes"), mi_rptEmp, "PDF", parameters)


    End Sub

    Protected Sub Btnprint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        'Dim mi_rptEmp As Object

        'vDetalle = occlass.Detalle_Solicitud_Fondos_Oficina(Me.CbxOficinas1.SelectedValue.Trim, Date.Parse(Me.Txtdfecini.Text), _
        '                                                    Date.Parse(Me.Txtdfecfin.Text), "")

        'mi_rptEmp = "RptSol_Fondos_Ofi.rpt"

        'Imprimir(vDetalle, mi_rptEmp)



    End Sub



    Protected Sub Btnfiltro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnfiltro.Click
        If lloficinas.Checked = False Then
            vDetalle = occlass.Extrae_Datos_Libretas(Me.CbxOficinas1.SelectedValue.Trim, "")
        Else
            vDetalle = occlass.Extrae_Datos_Libretas(Me.CbxOficinas1.SelectedValue.Trim, "*")
        End If


        If vDetalle.Tables(0).Rows.Count = 0 Then
            btnEdit.Enabled = False
            btnCancel.Enabled = False
            'btnnew.Enabled = True
            Btnprint.Enabled = False
        Else
            btnEdit.Enabled = True
            btnCancel.Enabled = True
            'btnnew.Enabled = False
            Btnprint.Enabled = True
        End If

        GridOfi.DataSource = vDetalle.Tables(0)
        GridOfi.DataBind()

    End Sub

    Protected Sub lloficinas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lloficinas.CheckedChanged
        If lloficinas.Checked = False Then
            Me.CbxOficinas1.Enabled = True
        Else
            Me.CbxOficinas1.Enabled = False
        End If
    End Sub
End Class
