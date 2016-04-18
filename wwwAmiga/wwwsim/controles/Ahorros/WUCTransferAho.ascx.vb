Imports System.Data
Imports System.Data.SqlClient

Partial Class controles_Ahorros_WUCTransferAho
    Inherits ucWBase

#Region "Privadas"
    Private ds_find As New DataSet
    Dim occlass_aho As New cAhomcta
    Private codigoJs As String
#End Region

#Region "Metodos"
    Private Sub Buscar_Origen()

        ds_find = occlass_aho.Extraer_Datos_Ctas_Aho(1, Me.asociado_TextBox.Text.Trim)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        Me.Gridfind.Visible = True
        Me.Gridfind.DataSource = ds_find.Tables(0)
        Me.Gridfind.DataBind()
    End Sub

    Private Sub Buscar_Destino()

        ds_find = occlass_aho.Extraer_Datos_Ctas_Aho(1, Me.asociado_TextBox1.Text.Trim)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If

        Me.Gridfind_destino.Visible = True
        Me.Gridfind_destino.DataSource = ds_find.Tables(0)
        Me.Gridfind_destino.DataBind()
    End Sub


    Private Sub Habilita(ByVal llbandera As Boolean)
        Me.btnproc.Enabled = llbandera
        Me.TxtnMonto.Enabled = llbandera
        Me.Txtcglosa.Enabled = llbandera
    End Sub


    Public Sub Limpieza()
        Me.TxtnMonto.Text = "0.00"
        Me.Txtcglosa.Text = ""
        Me.TxtcCodaho_Origen.Text = ""
        Me.TxtcCodaho_Origen.Text = ""
        Me.Txtcnomcli_Origen.Text = ""
        Me.TxtnSaldo.Text = ""
        Me.TxtcCodaho_Destino.Text = ""
        Me.TxtcCodaho_Destino.Text = ""
        Me.Txtcnomcli_Destino.Text = ""
        UpdatePanel8.Visible = False
        UpdatePanel9.Visible = False
    End Sub

#End Region

    Protected Sub btnfind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind.Click
        Buscar_Origen()
    End Sub

    Protected Sub btnfind0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfind0.Click
        Buscar_Destino()
    End Sub


    Protected Sub Gridfind_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Gridfind.PageIndexChanging
        Gridfind.PageIndex = e.NewPageIndex
        Call Buscar_Origen()
    End Sub

    Protected Sub Gridfind_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Gridfind.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not Gridfind.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = Gridfind.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(Gridfind.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = Gridfind.PageIndex + 1
        End If
    End Sub

    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Gridfind.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Gridfind.PageCount Then
                Gridfind.PageIndex = iNumPag - 1
            Else
                Gridfind.PageIndex = 0
            End If
        End If
        Call Buscar_Origen()
    End Sub



    Protected Sub Gridfind_destino_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Gridfind_destino.PageIndexChanging
        Gridfind_destino.PageIndex = e.NewPageIndex
        Call Buscar_Destino()
    End Sub

    Protected Sub Gridfind_destino_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Gridfind_destino.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not Gridfind_destino.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages0")
            _TotalPags.Text = Gridfind_destino.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList0")
            For i As Integer = 1 To CInt(Gridfind_destino.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = Gridfind_destino.PageIndex + 1
        End If
    End Sub

    Protected Sub paginasDropDownList0_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Gridfind_destino.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= Gridfind_destino.PageCount Then
                Gridfind_destino.PageIndex = iNumPag - 1
            Else
                Gridfind_destino.PageIndex = 0
            End If
        End If
        Call Buscar_Destino()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Protected Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Protected Sub Gridfind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gridfind.SelectedIndexChanged
        Dim bloqueo As String = Me.Gridfind.SelectedRow.Cells(8).Text
        Dim ctipo_cta As String = Me.Gridfind.SelectedRow.Cells(5).Text

        If bloqueo <> "ACTIVO" Then

            codigoJs = "<script language='javascript'>alert('Cta. no esta Activa, " & _
                                "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Habilita(False)
            Exit Sub
        End If

        If ctipo_cta = "APORTACIONES" Then

            codigoJs = "<script language='javascript'>alert('No se puede Transferir de la cta. de Aportaciones, " & _
                                "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Habilita(False)
            Exit Sub
        End If

        Me.TxtcCodcli_Origen.Text = Me.Gridfind.SelectedRow.Cells(1).Text
        Me.TxtcCodaho_Origen.Text = Me.Gridfind.SelectedRow.Cells(2).Text
        Me.Txtcnomcli_Origen.Text = Me.Gridfind.SelectedRow.Cells(3).Text + " " + Me.Gridfind.SelectedRow.Cells(4).Text
        Me.TxtnMonRes.Text = Me.Gridfind.SelectedRow.Cells(6).Text
        Me.TxtnSaldo.Text = Me.Gridfind.SelectedRow.Cells(7).Text
        Me.TxtnMonto.Text = Me.Gridfind.SelectedRow.Cells(7).Text
        Habilita(True)
        UpdatePanel8.Visible = True
    End Sub

    Protected Sub Gridfind_destino_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gridfind_destino.SelectedIndexChanged
        Dim bloqueo As String = Me.Gridfind_destino.SelectedRow.Cells(8).Text

        If bloqueo <> "ACTIVO" Then

            codigoJs = "<script language='javascript'>alert('Cta. no esta Activa, " & _
                                "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Habilita(False)
            Exit Sub
        End If

        Me.TxtcCodcli_Destino.Text = Me.Gridfind_destino.SelectedRow.Cells(1).Text
        Me.TxtcCodaho_Destino.Text = Me.Gridfind_destino.SelectedRow.Cells(2).Text
        Me.Txtcnomcli_Destino.Text = Me.Gridfind_destino.SelectedRow.Cells(3).Text + " " + Me.Gridfind_destino.SelectedRow.Cells(4).Text
        Habilita(True)
        UpdatePanel9.Visible = True
    End Sub

    Protected Sub CbxTipTran_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipTran.SelectedIndexChanged
        Select Case CbxTipTran.SelectedValue.Trim
            Case "01"
                Me.MtvPrinci.SetActiveView(ViewCtaAho)
            Case "02"
                Me.MtvPrinci.SetActiveView(ViewCreditos)
        End Select
    End Sub

    Protected Sub btnproc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnproc.Click

        Dim concepto As String = Me.Txtcglosa.Text.Trim
        Dim omclass_mov As New cAhomcta
        Dim lcnumcom As String
        Dim omclass_ana As New cTabttab
        Dim lcCodcta_ctb_ana As String = ""


        If Me.Txtcglosa.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Concepto Vacio, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        If Me.TxtcCodaho_Origen.Text.Trim = Me.TxtcCodaho_Destino.Text.Trim Then
            codigoJs = "<script language='javascript'>alert('No se permiten traslado entre las mismas Ctas., " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        ' Valida si existe monto Restringido
        If Double.Parse(Me.TxtnMonRes.Text) > 0 Then
            Dim lnDisponible As Double = Double.Parse(Me.TxtnSaldo.Text) - Double.Parse(Me.TxtnMonRes.Text)

            If Double.Parse(Me.TxtnMonto.Text) > lnDisponible Then
                codigoJs = "<script language='javascript'>alert('El Monto a Transferir no puede ser mayor al Disponible, " & _
                           "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
                Exit Sub
            End If

        End If


        If Double.Parse(Me.TxtnMonto.Text) > Double.Parse(Me.TxtnSaldo.Text) Then
            codigoJs = "<script language='javascript'>alert('El Monto a Transferir no puede ser mayor al Saldo, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        If Double.Parse(Me.TxtnMonto.Text) > Double.Parse(Me.TxtnSaldo.Text) Then
            codigoJs = "<script language='javascript'>alert('El Monto a Transferir no puede ser mayor al Saldo, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        If Double.Parse(Me.TxtnMonto.Text) <= 0 Then
            codigoJs = "<script language='javascript'>alert('El Monto a Transferir debe ser mayor a cero, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        ''Valida si el usuario es cajero para realizar la transacción
        lcCodcta_ctb_ana = "101001004"
        'lcCodcta_ctb_ana = omclass_ana.Extrae_Cuenta_CTB_Cajero(Session("gcCodusu"))


        'If lcCodcta_ctb_ana.Trim.Length = 0 Then
        '    codigoJs = "<script language='javascript'>alert('El Usuario no es cajero, No se puede realizar la Transferencia, " & _
        '               "Advertencia SIM.NET ')</script>"

        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
        '    Exit Sub
        'End If

        'Inicia el traslado de saldos entre cuentas
        Dim Datos_Trans() As String = {Session("GDFECSIS"), Session("gccodofi"), _
                                      concepto, "TR", Session("GDFECSIS"), _
                                      Session("gcCodusu"), Me.TxtcCodaho_Origen.Text.Trim, Me.TxtcCodaho_Destino.Text.Trim, _
                                      Me.TxtcCodcli_Origen.Text.Trim, Me.TxtcCodcli_Destino.Text.Trim, _
                                      Double.Parse(Me.TxtnMonto.Text), Me.Txtcnomcli_Origen.Text.Trim, _
                                      Me.Txtcnomcli_Destino.Text.Trim, lcCodcta_ctb_ana}


        lcnumcom = omclass_mov.Tranferencias(Datos_Trans)


        If lcnumcom = "0" Then
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If


        'Fin de Traslado

        'Arma datos para el informe
        ViewState.Add("pcCodcli_Origen", Me.TxtcCodcli_Origen.Text.Trim)     'Codigo Cliente Origen
        ViewState.Add("pcCodcli_Destino", Me.TxtcCodcli_Destino.Text.Trim)   'Codigo Cliente Destino
        ViewState.Add("pcCodcta_Origen", Me.TxtcCodaho_Origen.Text.Trim)     'Cta. Origen
        ViewState.Add("pcCodcta_Destino", Me.TxtcCodaho_Destino.Text.Trim)   'Cta. Destino
        ViewState.Add("pcNombre_Origen", Me.Txtcnomcli_Origen.Text.Trim)     'Nombre Origen
        ViewState.Add("pcNombre_Destino", Me.Txtcnomcli_Destino.Text.Trim)   'Nombre Destino
        ViewState.Add("pnMonto", Double.Parse(Me.TxtnMonto.Text))            'Monto Transferencia
        ViewState.Add("pcGlosa", Me.Txtcglosa.Text.Trim)                     'Concepto Transferencia
        ViewState.Add("pcNumcom", lcnumcom)                                  'Numero de Partida


        Habilita(False)
        Limpieza()
        asociado_TextBox.Text = ""
        asociado_TextBox1.Text = ""
        Gridfind.Visible = False
        Gridfind_destino.Visible = False
        btnprint.Enabled = True
    End Sub

    Protected Sub btnprint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim mi_rptEmp As Object
        Dim ds_print As New DataSet
        Dim cClsAdP As New cCntamov

        'Crear aqui el dataset
        ds_print = cClsAdP.Extrae_Partida_Diario(ViewState("pcNumcom"), "")

        mi_rptEmp = "Rpt_Transfer.rpt"


        Dim parameters(9, 1) As String

        'Armando Matriz de variables
        parameters(0, 0) = ("pcCodcli_Origen")                    'Codigo Cliente Origen 
        parameters(0, 1) = ViewState("pcCodcli_Origen")
        parameters(1, 0) = ("pcCodcli_Destino")                   'Codigo Cliente Destino
        parameters(1, 1) = ViewState("pcCodcli_Destino")
        parameters(2, 0) = ("pcCodcta_Origen")                    'Cta. Origen
        parameters(2, 1) = ViewState("pcCodcta_Origen")
        parameters(3, 0) = ("pcCodcta_Destino")                   'Cta. Destino
        parameters(3, 1) = ViewState("pcCodcta_Destino")
        parameters(4, 0) = ("pcNombre_Origen")                    'Nombre Origen
        parameters(4, 1) = ViewState("pcNombre_Origen")
        parameters(5, 0) = ("pcNombre_Destino")                   'Nombre Destino
        parameters(5, 1) = ViewState("pcNombre_Destino")
        parameters(6, 0) = ("pnMonto")                            'Monto Transferencia
        parameters(6, 1) = ViewState("pnMonto")
        parameters(7, 0) = ("pcGlosa")                            'Concepto Transferencia
        parameters(7, 1) = ViewState("pcGlosa")
        parameters(8, 0) = ("pcNumcom")                           'Numero de Partida
        parameters(8, 1) = ViewState("pcNumcom")
        parameters(9, 0) = ("pcCodusu")                           'Numero de Partida
        parameters(9, 1) = Session("gccodusu")
        

        Me.GenerarReporte_New(ds_Print, Server.MapPath("reportes"), mi_rptEmp, "PDF", parameters)


    End Sub
End Class
