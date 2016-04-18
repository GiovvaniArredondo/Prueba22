

Partial Class uclincre
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarCombos()
        End If
    End Sub

    Sub habilitar()
        Me.txtnrolin.Enabled = True
        Me.txttasa.Enabled = True
        txttasamin.Enabled = True
        txttasamax.Enabled = True
        Me.txtlimsup.Enabled = True
        Me.txtliminf.Enabled = True
        Me.txtmora.Enabled = True
        Me.txtcodlin.Enabled = True
        Me.txtmora.Enabled = True
        Me.txtdeslin.Enabled = True
        txtplazomin.Enabled = True
        txtplazomax.Enabled = True
        'txtncuotas.Enabled = True
        'txtnmoncuo.Enabled = True
        '  Me.btnadiciona.Disabled = True
        Me.btngraba.Disabled = False

    End Sub

    Sub inhabilitar()
        Me.txtnrolin.Enabled = False
        Me.txttasa.Enabled = False
        txttasamin.Enabled = False
        txttasamax.Enabled = False
        Me.txtlimsup.Enabled = False
        Me.txtliminf.Enabled = False
        Me.txtmora.Enabled = False
        Me.txtcodlin.Enabled = False
        Me.txtmora.Enabled = False
        Me.txtdeslin.Enabled = False
        txtplazomin.Enabled = False
        txtncuotas.Enabled = False
        Me.txtnmoncuo.Enabled = False
        txtplazomax.Enabled = False
        ' Me.btnadiciona.Disabled = False
        Me.btngraba.Disabled = True

    End Sub

    Private Sub LIMPIEZA()
        Me.txtliminf.Text = "0.00"
        Me.txtlimsup.Text = "0.00"
        Me.txtmora.Text = 0
        Me.txttasa.Text = 0
        txttasamin.Text = 0
        txttasamax.Text = 0
        txtplazomin.Text = 1
        txtplazomax.Text = 36
        txtncuotas.Text = 0
        Me.txtnmoncuo.Text = "0.00"
    End Sub

    Public Sub CargarCombos()

        LIMPIEZA()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab1 As New listatabttab
        Dim mListaTabttab2 As New listatabttab
        Dim mListaTabttab3 As New listatabttab
        Dim mListaTabttab4 As New listatabttab
        Dim mListaTabttab5 As New listatabttab
        Dim mlistatabttab6 As New listatabttab

        mListaTabttab1 = clstabttab.ObtenerLista("024", "1")
        mListaTabttab2 = clstabttab.ObtenerLista("034", "1")
        mListaTabttab3 = clstabttab.ObtenerLista("033", "1")
        mListaTabttab5 = clstabttab.ObtenerLista("007", "1")
        mlistatabttab6 = clstabttab.ObtenerLista("125", "1")


        'moneda
        Me.ddlmoneda.DataTextField = "cdescri"
        Me.ddlmoneda.DataValueField = "ccodigo"
        Me.ddlmoneda.DataSource = mListaTabttab5
        Me.ddlmoneda.DataBind()

        'plazo
        Me.ddlplazo.DataTextField = "cdescri"
        Me.ddlplazo.DataValueField = "ccodigo"
        Me.ddlplazo.DataSource = mListaTabttab1
        Me.ddlplazo.DataBind()

        ' cartera
        Me.ddlcartera.DataTextField = "cdescri"
        Me.ddlcartera.DataValueField = "ccodigo"
        Me.ddlcartera.DataSource = mListaTabttab2
        Me.ddlcartera.DataBind()

        'fondos
        Me.ddlfondos.DataTextField = "cdescri"
        Me.ddlfondos.DataValueField = "ccodigo"
        Me.ddlfondos.DataSource = mListaTabttab3
        Me.ddlfondos.DataBind()

        'programas

        'Garante
        Me.ddlgarantia.DataTextField = "cdescri"
        Me.ddlgarantia.DataValueField = "ccodigo"
        Me.ddlgarantia.DataSource = mlistatabttab6
        Me.ddlgarantia.DataBind()

        CargaLineaAuxiliar()

        'Me.txtcodlin.Text = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
        'Me.ddlplazo.SelectedValue.Substring(0, 1) & _
        'Me.ddlfondos.SelectedValue.Substring(0, 2) & _
        'Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
        'Me.ddlcartera.SelectedValue.Substring(0, 2) & _
        'Me.ddlprogramas.SelectedValue.Substring(0, 2)
        Me.CbxTipCred1.Recuperar()
        Me.CbxTipCobInt1.Recuperar()
        Me.CbxFormaPago1.Recuperar()

        Descripcion()

        

        'Si es Producto Flexible hara el codigo Normal
        If Me.CbxTipCred1.SelectedValue.Trim = "1" Then
            Me.txtcodlin.Text = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
            Me.ddlprogramas.SelectedValue.Substring(0, 2) & "10M"
        Else
            Me.txtcodlin.Text = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
            Me.ddlprogramas.SelectedValue.Substring(0, 2) & _
            Me.CbxTipCred1.SelectedValue.Trim & _
            Me.CbxTipCobInt1.SelectedValue.Trim & _
            Me.CbxFormaPago1.SelectedValue.Trim
        End If

        
    End Sub


    Public Sub CodigoLinea()
        If ddlprogramas.Items.Count = 0 Then
            Response.Write("<script language='javascript'>alert('No Existe Producto Definido')</script>")
            Exit Sub
        End If

        'Si es Producto Flexible hara el codigo Normal
        If Me.CbxTipCred1.SelectedValue = "1" Then
            Me.txtcodlin.Text = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
            Me.ddlprogramas.SelectedValue.Substring(0, 2) & "10M"
        Else
            Me.txtcodlin.Text = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
            Me.ddlprogramas.SelectedValue.Substring(0, 2) & _
            Me.CbxTipCred1.SelectedValue.Trim & _
            Me.CbxTipCobInt1.SelectedValue.Trim & _
            Me.CbxFormaPago1.SelectedValue.Trim
        End If
        


        Me.txtcodlin.DataBind()
        Descripcion()
    End Sub

    Public Sub CargarPorlinea(ByVal cnrolin As String)
        Me.txtnrolin.Text = cnrolin
        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
    End Sub

  
    Private Sub ddlmoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlmoneda.SelectedIndexChanged
        CodigoLinea()
    End Sub

    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        Dim lcnrolin As String
        Dim lccodlin As String
        Dim lcplazo As String
        Dim lcmoneda As String
        Dim mcretlin As New cCretlin
        Dim ecretlin As New cretlin
        lcnrolin = Me.txtnrolin.Text.Trim
        If lcnrolin <> "0000000" And lcnrolin <> "" Then
            ecretlin.cnrolin = lcnrolin
            mcretlin.ObtenerCretlin(ecretlin)
            lccodlin = ecretlin.ccodlin.Trim
            lcplazo = lccodlin.Substring(0, 1)
            '    Me.ddlplazo.SelectedValue = lcplazo
            Me.txtdeslin.Text = ecretlin.cdeslin
            Me.txtliminf.Text = ecretlin.nliminf
            Me.txtlimsup.Text = ecretlin.nlimsup
            Me.txtmora.Text = ecretlin.ntasmor
            Me.txttasa.Text = ecretlin.ntasint
            Me.txtcodlin.Text = ecretlin.ccodlin
            txttasamin.Text = ecretlin.ntasintmin
            txttasamax.Text = ecretlin.ntasintmax

            txtplazomin.Text = ecretlin.nplazomin
            txtplazomax.Text = ecretlin.nplazomax
            txtncuotas.Text = ecretlin.nocuotas
            txtnmoncuo.Text = ecretlin.nmoncuo
            If ecretlin.lliva = True Then
                Me.lliva.Checked = True
            Else
                Me.lliva.Checked = False
            End If

            If ecretlin.lactiva = True Then
                Me.chqactivar.Checked = True
            Else
                Me.chqactivar.Checked = False
            End If
            If ecretlin.llinpre = True Then
                Me.chqRevolvente.Checked = True
            Else
                Me.chqRevolvente.Checked = False
            End If

            Try

                Me.ddlmoneda.SelectedValue = lccodlin.Substring(0, 1)
                Me.ddlplazo.SelectedValue = lccodlin.Substring(1, 1)
                Me.ddlfondos.SelectedValue = lccodlin.Substring(2, 2)
                Me.ddlgarantia.SelectedValue = lccodlin.Substring(4, 2)
                Me.ddlcartera.SelectedValue = lccodlin.Substring(6, 2)
                Me.ddlprogramas.SelectedValue = lccodlin.Substring(8, 2)


                Me.CbxTipCred1.SelectedValue = lccodlin.Substring(10, 1)
                Me.CbxTipCobInt1.SelectedValue = lccodlin.Substring(11, 1)
                Me.CbxFormaPago1.SelectedValue = lccodlin.Substring(12, 1)
                If Me.CbxTipCred1.SelectedValue = "1" Then
                    Me.CbxFormaPago1.Enabled = False
                    Me.CbxTipCobInt1.Enabled = False
                    Me.txtncuotas.Enabled = False
                Else
                    Me.CbxFormaPago1.Enabled = True
                    Me.CbxTipCobInt1.Enabled = True
                    Me.txtncuotas.Enabled = True
                End If

            Catch ex As Exception

            End Try

            
        Else
            lcplazo = Me.ddlplazo.SelectedValue.Substring(0, 1)
            lcmoneda = Me.ddlmoneda.SelectedValue.Substring(0, 1)
            '    lccodlin = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
            'Me.ddlplazo.SelectedValue.Substring(0, 1) & _
            'Me.ddlfondos.SelectedValue.Substring(0, 2) & _
            'Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
            'Me.ddlcartera.SelectedValue.Substring(0, 2) & _
            'Me.ddlprogramas.SelectedValue.Substring(0, 2)

            If Me.CbxTipCred1.SelectedValue.Trim = "1" Then
                lccodlin = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
                            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
                            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
                            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
                            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
                            Me.ddlprogramas.SelectedValue.Substring(0, 2) & "10M"
            Else
                lccodlin = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
                            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
                            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
                            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
                            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
                            Me.ddlprogramas.SelectedValue.Substring(0, 2) & _
                            Me.CbxTipCred1.SelectedValue.Trim & _
                            Me.CbxTipCobInt1.SelectedValue.Trim & _
                            Me.CbxFormaPago1.SelectedValue.Trim
            End If

            Me.txtcodlin.Text = lccodlin
            'Me.txtdeslin.Text = " "
            txttasamin.Text = 0
            txttasamax.Text = 0
            Me.txtmora.Text = 0
            Me.txttasa.Text = 0
            Me.txtliminf.Text = 0
            Me.txtlimsup.Text = 0
            txtplazomin.Text = 1
            txtplazomax.Text = 36
            Me.txtncuotas.Text = "0"
            Me.txtnmoncuo.Text = "0.00"
            Me.chqactivar.Checked = True
            Me.chqRevolvente.Checked = False
        End If
        Me.btnGraba.Disabled = False
        Me.btnCancela.Disabled = False
        habilitar()
    End Sub

    Private Sub btnGraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraba.ServerClick
        Dim lcnrolin As String
        Dim clslineas As New cCretlin
        Dim elineas As New cretlin
        Dim ldfecha As Date
        Dim lcplazo As String
        Dim lcmoneda As String
        Dim lccodlin As String
        Dim lcdeslin As String
        lcnrolin = Me.txtnrolin.Text.Trim
        ldfecha = Session("gdfecsis")

        If ddlprogramas.Items.Count = 0 Then
            Response.Write("<script language='javascript'>alert('No Existe Producto Definido')</script>")
            Exit Sub
        End If

        'Valida  rangos de tasas--------------------------------------------------
        If Double.Parse(txttasamin.Text) > Double.Parse(txttasamax.Text) Then
            Response.Write("<script language='javascript'>alert('Rango Incosistente')</script>")
            Exit Sub
        End If
        If Double.Parse(txttasa.Text) < Double.Parse(txttasamin.Text) Then
            Response.Write("<script language='javascript'>alert('Tasa Standard fuera de Rango')</script>")
            Exit Sub
        End If
        If Double.Parse(txttasa.Text) > Double.Parse(txttasamax.Text) Then
            Response.Write("<script language='javascript'>alert('Tasa Standard fuera de Rango')</script>")
            Exit Sub
        End If

        If Double.Parse(txtplazomin.Text) > Double.Parse(txtplazomax.Text) Then
            Response.Write("<script language='javascript'>alert('Plazo erroneos')</script>")
            Exit Sub
        End If

        If Me.CbxTipCred1.SelectedValue = "2" Then   'Tipo de Credito Cerrado, debe tener No de Cuotas
            If Integer.Parse(Me.txtncuotas.Text) = 0 Then
                Response.Write("<script language='javascript'>alert('El número de Cuotas no puede ser cero, Advertencia SIM.NET')</script>")
                Exit Sub
            End If
        End If

        '--------------------------------------------------------------------------------
        If lcnrolin Is String.Empty Or lcnrolin = "0000000" Then
            'obtendra nueva linea a grabar
            lcplazo = Me.ddlplazo.SelectedValue.Substring(0, 1)
            lcmoneda = Me.ddlmoneda.SelectedValue.Substring(0, 1)

            'lccodlin = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
            '           Me.ddlplazo.SelectedValue.Substring(0, 1) & _
            '           Me.ddlfondos.SelectedValue.Substring(0, 2) & _
            '           Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
            '           Me.ddlcartera.SelectedValue.Substring(0, 2) & _
            '           Me.ddlprogramas.SelectedValue.Substring(0, 2)

            If Me.CbxTipCred1.SelectedValue.Trim = "1" Then
                lccodlin = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
                            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
                            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
                            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
                            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
                            Me.ddlprogramas.SelectedValue.Substring(0, 2) & "10M"
            Else
                lccodlin = Me.ddlmoneda.SelectedValue.Substring(0, 1) & _
                            Me.ddlplazo.SelectedValue.Substring(0, 1) & _
                            Me.ddlfondos.SelectedValue.Substring(0, 2) & _
                            Me.ddlgarantia.SelectedValue.Substring(0, 2) & _
                            Me.ddlcartera.SelectedValue.Substring(0, 2) & _
                            Me.ddlprogramas.SelectedValue.Substring(0, 2) & _
                            Me.CbxTipCred1.SelectedValue.Trim & _
                            Me.CbxTipCobInt1.SelectedValue.Trim & _
                            Me.CbxFormaPago1.SelectedValue.Trim

            End If

            'lcmoneda & lcplazo & Me.ddlfondos.SelectedValue.Trim & Me.ddlcartera.SelectedValue.Trim & Me.ddlprogramas.SelectedValue.Trim

            If Me.chqactivar.Checked = True Then
                elineas.lactiva = 1
            Else
                elineas.lactiva = 0
            End If
            If Me.chqRevolvente.Checked = True Then
                elineas.llinpre = 1
            Else
                elineas.llinpre = 0
            End If

            lcnrolin = clslineas.Obtenernrolin()
            elineas.cnrolin = lcnrolin
            elineas.ctipcal = "F"
            elineas.ctipdes = " "
            elineas.ctiplin = " "
            elineas.cnropar = " "
            elineas.ctipo = " "
            elineas.cflag = " "
            elineas.cctacte = " "
            elineas.ccodbco = " "
            elineas.ccodrub = " "
            elineas.lredo = 1
            elineas.ndesuso = 0
            elineas.ctipo = " "
            elineas.ccodlin = Me.txtcodlin.Text.Trim
            elineas.ntasint = Double.Parse(Me.txttasa.Text)
            elineas.ntasintmin = Double.Parse(txttasamin.Text)
            elineas.ntasintmax = Double.Parse(txttasamax.Text)
            elineas.ntasmor = Double.Parse(Me.txtmora.Text)
            elineas.nliminf = Double.Parse(Me.txtliminf.Text)
            elineas.nlimsup = Double.Parse(Me.txtlimsup.Text)
            elineas.nplazomin = Integer.Parse(txtplazomin.Text)
            elineas.nplazomax = Integer.Parse(txtplazomax.Text)
            elineas.nocuotas = Integer.Parse(Me.txtncuotas.Text)
            elineas.nmoncuo = Double.Parse(Me.txtnmoncuo.Text)
            elineas.cdeslin = Me.txtdeslin.Text.Trim
            lcdeslin = Me.txtdeslin.Text.Trim
            If lcdeslin = Nothing Or lcdeslin = " " Then
                Response.Write("<script language='javascript'>alert('Linea sin nombre')</script>")
                Exit Sub
            End If

            elineas.dfecvig = ldfecha
            elineas.dfecmod = ldfecha
            elineas.lsegvida = 0
            elineas.lsegdeu = 0
            elineas.ndesuso = 0
            elineas.ladmon = 0
            'elineas.llinpre = 0
            elineas.llinusa = 1
            elineas.nmondes = 9999999.99
            elineas.ccodusu = Session("gcCodusu")
            elineas.lredo = 1
            elineas.cnropar = " "
            elineas.lliva = Me.lliva.Checked

            clslineas.AGREGAR(elineas)
            Response.Write("<script language='javascript'>alert('Linea creada correctamente, Aviso SIM.NET')</script>")
        Else
            'ACTUALIZA LINEA
            elineas.cnrolin = lcnrolin
            clslineas.ObtenerCretlin(elineas)

            If Me.chqactivar.Checked = True Then
                elineas.lactiva = 1
            Else
                elineas.lactiva = 0
            End If
            If Me.chqRevolvente.Checked = True Then
                elineas.llinpre = 1
            Else
                elineas.llinpre = 0
            End If
            elineas.cnrolin = lcnrolin
            elineas.ntasint = Double.Parse(Me.txttasa.Text)
            elineas.ntasintmin = Double.Parse(txttasamin.Text)
            elineas.ntasintmax = Double.Parse(txttasamax.Text)
            elineas.ntasmor = Double.Parse(Me.txtmora.Text)
            elineas.nliminf = Double.Parse(Me.txtliminf.Text)
            elineas.nlimsup = Double.Parse(Me.txtlimsup.Text)
            elineas.cdeslin = Me.txtdeslin.Text.Trim
            elineas.nplazomin = Integer.Parse(txtplazomin.Text)
            elineas.nplazomax = Integer.Parse(txtplazomax.Text)
            elineas.nocuotas = Integer.Parse(Me.txtncuotas.Text)
            elineas.nmoncuo = Double.Parse(Me.txtnmoncuo.Text)
            elineas.lliva = Me.lliva.Checked
            elineas.ccodusu = Session("gcCodusu")

            clslineas.ActualizarCretlin(elineas)
            Response.Write("<script language='javascript'>alert('Linea actualizada correctamente, Aviso SIM.NET')</script>")
        End If

        CargarCombos()
        inhabilitar()
    End Sub

    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Response.Write("<script language='javascript'>alert('No esta permitida esta opcion')</script>")
    End Sub

    Private Sub ddlgarantia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlgarantia.SelectedIndexChanged
        CodigoLinea()
    End Sub

    Private Sub ddlplazo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlplazo.SelectedIndexChanged
        CodigoLinea()
    End Sub

    Private Sub ddlfondos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlfondos.SelectedIndexChanged
        CodigoLinea()
    End Sub

    Private Sub ddlcartera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlcartera.SelectedIndexChanged
        CargaLineaAuxiliar()
        CodigoLinea()
    End Sub

    Private Sub ddlprogramas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlprogramas.SelectedIndexChanged
        CodigoLinea()
    End Sub
    Private Sub CargaLineaAuxiliar()
        Dim ds As New DataSet
        Dim ecretlin As New cCretlin
        ds = ecretlin.ObtenerProducto(ddlcartera.SelectedValue.Trim, ddlgarantia.selectedvalue.trim)


        Me.ddlprogramas.DataTextField = "cdescri"
        Me.ddlprogramas.DataValueField = "ccodigo"
        Me.ddlprogramas.DataSource = ds.Tables(0)
        Me.ddlprogramas.DataBind()

        If ddlprogramas.Items.Count = 0 Then
            Response.Write("<script language='javascript'>alert('No Existe Producto Definido')</script>")
            Exit Sub
        End If
    End Sub
    Private Sub Descripcion()

        If Me.CbxTipCred1.SelectedValue.Trim = "1" Then  'Flexible
            txtdeslin.Text = Me.CbxTipCred1.SelectedItem.Text.Trim & " | " & _
                             IIf(chqRevolvente.Checked = True, "L.Revolv. ", "") & _
                             Me.ddlgarantia.SelectedItem.Text.Trim & " " & _
                             Me.ddlfondos.SelectedItem.Text.Trim & " " & Me.ddlcartera.SelectedItem.Text.Trim & " " & _
                             ddlprogramas.SelectedItem.Text.Trim & " " & _
                             txttasamin.Text.Trim & "%  - " & txttasamax.Text.Trim & "% " & _
                             txtliminf.Text.Trim & " - " & txtlimsup.Text.Trim & " Pl. Min " & txtplazomin.Text.Trim & " Pl. Max  " & _
                             txtplazomax.Text.Trim 
        Else
            txtdeslin.Text = Me.CbxTipCred1.SelectedItem.Text.Trim & " | " & _
                             IIf(chqRevolvente.Checked = True, "L.Revolv. ", "") & _
                             Me.ddlgarantia.SelectedItem.Text.Trim & " " & _
                             Me.ddlfondos.SelectedItem.Text.Trim & " " & Me.ddlcartera.SelectedItem.Text.Trim & " " & _
                             ddlprogramas.SelectedItem.Text.Trim & " " & _
                             txttasamin.Text.Trim & "%  - " & txttasamax.Text.Trim & "% " & _
                             txtliminf.Text.Trim & " - " & txtlimsup.Text.Trim & " Pl. Min " & txtplazomin.Text.Trim & " Pl. Max  " & _
                             txtplazomax.Text.Trim & " | " & Me.CbxFormaPago1.SelectedItem.Text.Trim & " | " & _
                             Me.CbxTipCobInt1.SelectedItem.Text.Trim
            If Double.Parse(Me.txtnmoncuo.Text) > 0 Then
                txtdeslin.Text = txtdeslin.Text.Trim + " | " + " CUOTA FIJA $" & _
                                Format(Math.Round(Double.Parse(Me.txtnmoncuo.Text), 2), "#########.00")
            End If
        End If
        

        'IIf(ddlplazo.SelectedValue.Trim = "1", " ", IIf(ddlplazo.SelectedValue.Trim = "3", "", "L.P.")) &
        'Me.ddlmoneda.SelectedItem.Text.Trim & " " &          " " & _
    End Sub

    Protected Sub txttasamin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttasamin.TextChanged
        Descripcion()
    End Sub
    
    Protected Sub txttasamax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttasamax.TextChanged
        Descripcion()
    End Sub

    Protected Sub txtliminf_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtliminf.TextChanged
        Descripcion()
    End Sub

    Protected Sub txtlimsup_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlimsup.TextChanged
        Descripcion()
    End Sub

    Protected Sub txtplazomin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtplazomin.TextChanged
        Descripcion()
    End Sub

    Protected Sub txtplazomax_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtplazomax.TextChanged
        Descripcion()
    End Sub

    Protected Sub chqRevolvente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chqRevolvente.CheckedChanged
        Descripcion()
    End Sub

    Private Sub btnAdiciona_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdiciona.ServerClick
        CargarPorlinea("0000000")
    End Sub

    Protected Sub CbxTipCred1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipCred1.SelectedIndexChanged
        If Not Me.CbxTipCred1.SelectedValue.Trim = "1" Then
            Me.CbxFormaPago1.Enabled = True
            Me.CbxTipCobInt1.Enabled = True
            Me.txtncuotas.Enabled = True
            Me.txtnmoncuo.Enabled = True
        Else
            Me.CbxFormaPago1.Enabled = False
            Me.CbxTipCobInt1.Enabled = False
            Me.txtncuotas.Enabled = False
            Me.txtnmoncuo.Enabled = False
            Me.txtnmoncuo.Text = "0.00"
            Me.txtncuotas.Text = "0"
        End If
        CodigoLinea()
    End Sub

    Protected Sub CbxFormaPago1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxFormaPago1.SelectedIndexChanged
        CodigoLinea()
    End Sub

    Protected Sub CbxTipCobInt1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxTipCobInt1.SelectedIndexChanged
        CodigoLinea()
    End Sub

    Protected Sub txtnmoncuo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnmoncuo.TextChanged
        Descripcion()
    End Sub
End Class


