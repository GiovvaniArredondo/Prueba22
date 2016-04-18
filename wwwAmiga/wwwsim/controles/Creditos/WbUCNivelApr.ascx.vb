
Partial Class controles_creditos_WbUCNivelApr
    Inherits ucWBase

#Region "Privadas"
    Private vDetalle As New DataSet
    Private codigoJs As String = ""
    Dim occlass As New cTabttab
#End Region

#Region "Metodos"

    Public Sub Cargar_Datos()


        'Me.CbxOficinas1.Recuperar()
        'Me.CbxOficinas2.Recuperar()
        'Me.CbxFondos1.Recuperar()
        'If Me.CbxBancos3.Items.Count > 1 Then
        '    Me.CbxBancos3.Items.Clear()
        'End If

        'Dim ListaItem As New ListItem

        'ListaItem.Value = "00"
        'ListaItem.Text = "Selecccione una Cta. Bancaria"
        'CbxOficinas1.SelectedValue = Session("GCCODOFI")
        'CbxOficinas2.SelectedValue = Session("GCCODOFI")
        Buscar()
    End Sub


    Private Sub Limpieza()
        'Me.CbxFondos1.SelectedValue = "00"
        'Me.CbxEstado.SelectedValue = "00"
        Me.TxtnDesde.Text = "0"
        Me.TxtnHasta.Text = "0"
        Me.Txtcdescri.Text = ""
        Me.TxtcObserva.Text = ""
    End Sub


    Private Sub Habilita(ByVal llbandera As Boolean)
        '        Me.CbxFondos1.Enabled = llbandera
        Me.TxtnDesde.Enabled = llbandera
        Me.TxtnHasta.Enabled = llbandera
        '       Me.CbxEstado.Enabled = llbandera
        Me.Txtcdescri.Enabled = llbandera
        Me.TxtcObserva.Enabled = llbandera
        'CbxOficinas2.Enabled = llbandera
        'cbxestado.Enabled = llbandera
        'Me.Txtdfecini.Enabled = llbandera
        'Me.Txtdfecfin.Enabled = llbandera

    End Sub


    Private Sub Buscar()

        vDetalle = occlass.Extrae_Niveles_Aprobacion()

        'If vDetalle.Tables(0).Rows.Count = 0 Then
        '    btnEdit.Enabled = False
        '    btnCancel.Enabled = False
        '    'btnnew.Enabled = True
        '    Btnprint.Enabled = False
        'Else
        '    btnEdit.Enabled = True
        '    btnCancel.Enabled = True
        '    'btnnew.Enabled = False
        '    Btnprint.Enabled = True
        'End If

        GridNiveles.DataSource = vDetalle.Tables(0)
        GridNiveles.DataBind()


    End Sub


#End Region


    Protected Sub btnnew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnew.Click
        Me.Habilita(True)
        Me.btnnew.Enabled = False
        Me.Btnsave.Enabled = True
        Me.btnCancel.Enabled = True
        Me.btnEdit.Enabled = False
    End Sub

    Protected Sub GridNiveles_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridNiveles.PageIndexChanging
        GridNiveles.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridNiveles_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridNiveles.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridNiveles.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridNiveles.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridNiveles.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridNiveles.PageIndex + 1
        End If
    End Sub

    Protected Sub GridNiveles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridNiveles.SelectedIndexChanged

        Me.TxtId.Text = GridNiveles.SelectedRow.Cells(1).Text.ToString.Trim         'ID
        Me.Txtcdescri.Text = GridNiveles.SelectedRow.Cells(2).Text.ToString.Trim    'Descripción
        Me.TxtnDesde.Text = GridNiveles.SelectedRow.Cells(3).Text.ToString.Trim     'Limite Inferior
        Me.TxtnHasta.Text = GridNiveles.SelectedRow.Cells(4).Text.ToString.Trim     'Limite Superior
        Me.TxtcObserva.Text = GridNiveles.SelectedRow.Cells(5).Text.ToString.Trim   'Observaciones

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


        array_d.Add(Me.TxtId.Text.Trim)                       'ID
        array_d.Add(Me.Txtcdescri.Text.Trim.ToUpper)                  'Descripción
        array_d.Add(Double.Parse(Me.TxtnDesde.Text))          'Limite Inferior
        array_d.Add(Double.Parse(Me.TxtnHasta.Text))          'Limite Superior
        array_d.Add(Me.TxtcObserva.Text.Trim.ToUpper)                 'Observaciones
        array_d.Add(Session("gccodusu"))                      'Usuario
        array_d.Add(Session("gdfecsis"))                      'Fecha de asignacion


        lnRetorno = occlass.Mantenimiento_Niveles_Aprobacion(array_d)


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



End Class
