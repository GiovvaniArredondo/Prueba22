
Partial Class controles_Creditos_WbUCUsuNivelApr
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
        Me.CbxComites1.Recuperar()
        Me.CbxComites2.Recuperar()
        Me.CbxUsuarios1.Recuperar()
        Buscar()
    End Sub


    Private Sub Limpieza()
        'Me.CbxFondos1.SelectedValue = "00"
        'Me.CbxEstado.SelectedValue = "00"
    End Sub


    Private Sub Habilita(ByVal llbandera As Boolean)
        '        Me.CbxFondos1.Enabled = llbandera
        
        '       Me.CbxEstado.Enabled = llbandera        
        'CbxOficinas2.Enabled = llbandera
        'cbxestado.Enabled = llbandera
        'Me.Txtdfecini.Enabled = llbandera
        'Me.Txtdfecfin.Enabled = llbandera

    End Sub


    Private Sub Buscar()

        vDetalle = occlass.Extrae_Usuarios_Niveles_Aprobacion(Me.CbxComites2.SelectedValue.Trim)

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

        If vDetalle.Tables(0).Rows.Count = 0 Then
            GridNiveles.Visible = False
        Else
            GridNiveles.Visible = True
        End If

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


        array_d.Add(Me.CbxComites1.SelectedValue.Trim)               'Codigo Nivel de Comite
        array_d.Add(Me.CbxUsuarios1.SelectedValue.Trim)              'Codigo usuario del sistema Asignado        
        array_d.Add(Me.CbxUsuarios1.SelectedItem.Text.Trim)          'Usuario del sistema Asignado        
        array_d.Add(Left(Me.CbxUsuarios1.SelectedItem.Text.Trim, 4)) 'Iniciales Usuario
        array_d.Add(Session("gccodusu"))                             'Usuario que modifica
        array_d.Add(Session("gdfecsis"))                             'Fecha de asignacion


        lnRetorno = occlass.Mantenimiento_Usuarios_Niveles_Aprobacion(array_d)


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

    Protected Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Buscar()
    End Sub
End Class
