Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Data
Imports System.Data.SqlClient


Partial Class wubPruebax
    Inherits ucWBase
    Private cls1 As New SIM.bl.ClsMantenimiento
    Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
    Private clsaplica As New payment

#Region " Variables "
    Public vDetalle As New DataSet
    Private dskardexC As New DataSet
    Private codigoJs As String
    Private omclass As New cCredkar
    Private dt As New DataTable
    Dim dt_ajustes As DataTable
#End Region
    

    Public Sub Carga_Inicia()
        Limpieza()
        Me.txtdesde.Text = Session("gdfecsis")
        Me.txthasta.Text = Session("gdfecsis")
        txtdfecval.Text = Session("gdfecsis")
        Me.CbxCatalogo1.Recuperar()
    End Sub

    Private Sub Limpieza()
        Me.txtdesde.Text = Session("gdfecsis")
        Me.txthasta.Text = Session("gdfecsis")
        txtdfecval.Text = Session("gdfecsis")
        Me.CbxCatalogo1.Recuperar()
        txtanterior1.Text = 0
        txtanterior2.Text = 0
        txtanterior3.Text = 0
        txtanterior4.Text = 0
        txtanterior5.Text = 0
        txtanterior6.Text = 0

        txtnmonpag.Text = 0
        txtncompag.Text = 0
        txtnprogapepag.Text = 0
        txtnotraspag.Text = 0

        txtpagado1.Text = 0
        txtpagado2.Text = 0
        txtpagado3.Text = 0
        txtpagado4.Text = 0
        txtpagado5.Text = 0
        txtpagado6.Text = 0

        txtajuste1.Text = 0
        txtajuste2.Text = 0
        txtajuste3.Text = 0
        txtajuste4.Text = 0
        txtajuste5.Text = 0
        txtajuste6.Text = 0
        txtbandera.Text = 0
        txtdfecvig.Text = ""
        txtcnuming.Text = ""
        Me.dgDetalle.Visible = False
    End Sub

    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        txtanterior1.Text = 0
        txtanterior2.Text = 0
        txtanterior3.Text = 0
        txtanterior4.Text = 0
        txtanterior5.Text = 0
        txtanterior6.Text = 0

        Me.txtccodcta.Text = codcta

        Dim ecreditos As New creditos
        Dim mcreditos As New ccreditos
        ecreditos.ccodcta = codcta

        mcreditos.Obtenercreditos(ecreditos)
        Me.txtcnomcli.Text = ecreditos.cnomcli
        Me.txtccodcli.Text = ecreditos.ccodcli

        'Evalua el tipo de crédito Flat o Sobresaldos
        If ecreditos.cflat = "F" Then
            tipo_credito.Text = "FLAT"
        Else
            tipo_credito.Text = "SOBRESALDOS"
        End If

        Me.txtdfecvig.Text = ecreditos.dfecvig

        'Vacia datos importados
        Dim dskardexD As New DataSet


        Dim ecredkar As New cCredkar

        dskardexD = ecredkar.KardexPruebaxDes(txtccodcta.Text)
        ViewState.Add("Dataset", dskardexD)

        ViewState.Add("Datatable", dt)

        vDetalle = dskardexD
        Me.dgDetalle.Visible = True
        Me.dgDetalle.DataSource = vDetalle.Tables(0)
        Me.dgDetalle.DataBind()


        'Importa Saldo de Pagos Realizados
        dskardexC = ecredkar.KardexPruebax(txtccodcta.Text, ecreditos.dfecvig, Session("gdfecsis"), "C")

        ActualizaPagado_Real(dskardexC)
        txtnmonpag.Enabled = True
        btngrabar.Enabled = True
        btnsave.Enabled = True
        btnaplicar.Enabled = True
        Button1.Enabled = True
        btnverifica.Enabled = True


        'Detalle de Ajustes
        dt_ajustes = ecredkar.Extrae_Auxiliar_Ajustes_Creditos(Me.txtccodcta.Text)

        ViewState.Add("Ajustes", dt_ajustes)

        dgAjustes.DataSource = dt_ajustes
        dgAjustes.DataBind()


    End Sub


    Private Sub Importa_Pagos_Automatico()

        Dim ecredkar As New cCredkar
        Dim ldfecha_pag As Date = Date.Parse(Me.txtdfecval.Text)

        dskardexC = ecredkar.KardexPruebax(txtccodcta.Text, Date.Parse(txtdfecvig.Text), ldfecha_pag.AddDays(-1), "C")


        'ViewState("Dataset") = dskardexC

        'ActualizaPagado(dskardexC)

        'Me.dgDetalle.DataSource = dskardexC.Tables(0)
        'Me.dgDetalle.DataBind()

        UneconDes(dskardexC)

        'Se agregan al desembolso

        'Calculo()
    End Sub


    Private Sub Importa_Pagos_Automatico_Filtro()

        Dim ecredkar As New cCredkar
        Dim ldfecha_pag As Date = Date.Parse(txtdfecvig.Text)

        dskardexC = ecredkar.KardexPruebax(txtccodcta.Text, Date.Parse(txtdfecvig.Text), ldfecha_pag.AddDays(-1), "C")


        'ViewState("Dataset") = dskardexC

        'ActualizaPagado(dskardexC)

        'Me.dgDetalle.DataSource = dskardexC.Tables(0)
        'Me.dgDetalle.DataBind()

        UneconDes(dskardexC)

        'Se agregan al desembolso

        'Calculo()
    End Sub

    Protected Sub btnaplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        aplicar(1)
    End Sub


    Private Sub aplicar_Automatico(ByVal pdfecpro As Date)
        Dim ok As Integer
        Dim ds As New DataSet
        Dim lnvalida As Integer = 0
        Dim ldfecha As Date = pdfecpro
        'ds = DegridaDataset()
        ds = DegridaDataset_()


        'Validar que no existe un Pago mas adelante para evitar un Error
        If Not IsDBNull(ds.Tables(0).Compute("count(ccodcta)", "dfecsis > '" & ldfecha & "'")) Then
            lnvalida = ds.Tables(0).Compute("count(ccodcta)", "dfecsis > '" & ldfecha & "'")
        End If

        If lnvalida > 0 Then
            'Response.Write("<script language='javascript'>alert('Error Cobranza, Existe un pago mas adelante, Revise')</script>")
            codigoJs = "<script language='javascript'>alert('Error Cobranza, Existe un pago mas adelante, " & _
                          "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If



        Try

            clsaplica.pccodcta = txtccodcta.Text.Trim
            clsaplica.pdfecval = pdfecpro
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            clsaplica.gnpergra = Session("gnpergra")


            'ok = clsaplica.omcalcinterestPruebax("T", ds.Tables(0))
            ok = clsaplica.omcalcinterestPruebax_Flat("T", pdfecpro, ds.Tables(0))
            If ok = 9 Then
                'Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                codigoJs = "<script language='javascript'>alert('Crédito Cancelado, " & _
                         "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End If

            If ok = 1 Then
                txtnsalcap.Text = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                txtnsalint.Text = Math.Round(clsaplica.pnsalint, 2)
                txtnsalmor.Text = Math.Round(clsaplica.pnsalmor, 2)
                txtndeucap.Text = Math.Round(clsaplica.pndeucap, 2)
            Else
                txtnsalcap.Text = "0.00"
                txtnsalint.Text = "0.00"
                txtnsalmor.Text = "0.00"
                txtndeucap.Text = "0.00"
            End If

            txtnmonpag.Enabled = True
            txtcnuming.Enabled = True
            txtncompag.Enabled = True
            txtnprogapepag.Enabled = True
            txtnotraspag.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub aplicar(ByVal tipo As String)
        Dim ok As Integer
        Dim ds As New DataSet
        Dim lnvalida As Integer = 0
        Dim ldfecha As Date = Date.Parse(txtdfecval.Text)
        'ds = DegridaDataset()
        ds = DegridaDataset_()


        'Validar que no existe un Pago mas adelante para evitar un Error
        If tipo = "1" Then
            If Not IsDBNull(ds.Tables(0).Compute("count(ccodcta)", "dfecsis >= '" & ldfecha & "'")) Then
                lnvalida = ds.Tables(0).Compute("count(ccodcta)", "dfecsis >= '" & ldfecha & "'")
            End If

            If lnvalida > 0 Then
                'Response.Write("<script language='javascript'>alert('Error Cobranza, Existe un pago mas adelante, Revise')</script>")
                codigoJs = "<script language='javascript'>alert('Error Cobranza, Existe un pago mas adelante, " & _
                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
        End If



        Try

            clsaplica.pccodcta = txtccodcta.Text.Trim
            clsaplica.pdfecval = Date.Parse(txtdfecval.Text)
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            clsaplica.gnpergra = Session("gnpergra")


            'ok = clsaplica.omcalcinterestPruebax("T", ds.Tables(0))
            ok = clsaplica.omcalcinterestPruebax_Flat("T", Date.Parse(txtdfecval.Text), ds.Tables(0))
            If ok = 9 Then
                'Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                codigoJs = "<script language='javascript'>alert('Crédito Cancelado, " & _
                         "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End If

            If ok = 1 Then
                txtnsalcap.Text = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                txtnsalint.Text = Math.Round(clsaplica.pnsalint, 2)
                txtnsalmor.Text = Math.Round(clsaplica.pnsalmor, 2)
                txtndeucap.Text = Math.Round(clsaplica.pndeucap, 2)

            End If

            txtnmonpag.Enabled = True
            txtncompag.Enabled = True
            txtnprogapepag.Enabled = True
            txtnotraspag.Enabled = True
            txtcnuming.Enabled = True
            'txtnmonpag.Text = 0
            'txtncompag.Text = 0
            'txtnprogapepag.Text = 0
            'txtnotraspag.Text = 0

            'btngrabar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub aplicar_Posterior(ByVal pdfecpro As Date)
        Dim ok As Integer
        Dim ds As New DataSet
        Dim lnvalida As Integer = 0
        Dim ldfecha As Date = pdfecpro
        ds = DegridaDataset_()

        'Limpia valores al inicio
        txtnsalcap.Text = "0.00"
        txtnsalint.Text = "0.00"
        txtnsalmor.Text = "0.00"
        txtndeucap.Text = "0.00"

        'Validar que no existe un Pago mas adelante para evitar un Error

        'If Not IsDBNull(ds.Tables(0).Compute("count(ccodcta)", "dfecsis > '" & ldfecha & "'")) Then
        '    lnvalida = ds.Tables(0).Compute("count(ccodcta)", "dfecsis > '" & ldfecha & "'")
        'End If

        'If lnvalida > 0 Then
        '    'Response.Write("<script language='javascript'>alert('Error Cobranza, Existe un pago mas adelante, Revise')</script>")
        '    codigoJs = "<script language='javascript'>alert('Error Cobranza, Existe un pago mas adelante, " & _
        '                  "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '    Exit Sub
        'End If


        Try

            clsaplica.pccodcta = txtccodcta.Text.Trim
            clsaplica.pdfecval = pdfecpro
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            clsaplica.gnpergra = Session("gnpergra")


            'ok = clsaplica.omcalcinterestPruebax("T", ds.Tables(0))
            ok = clsaplica.omcalcinterestPruebax_Flat("T", Date.Parse(txtdfecval.Text), ds.Tables(0))
            If ok = 9 Then
                'Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                codigoJs = "<script language='javascript'>alert('Crédito Cancelado, " & _
                         "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End If

            If ok = 1 Then
                txtnsalcap.Text = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                txtnsalint.Text = Math.Round(clsaplica.pnsalint, 2)
                txtnsalmor.Text = Math.Round(clsaplica.pnsalmor, 2)
                txtndeucap.Text = Math.Round(clsaplica.pndeucap, 2)

            End If

            txtnmonpag.Enabled = True
            txtncompag.Enabled = True
            txtnprogapepag.Enabled = True
            txtnotraspag.Enabled = True


        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim dskardexC As New DataSet

        Dim ecredkar As New cCredkar


        dskardexC = ecredkar.KardexPruebax(txtccodcta.Text, Date.Parse(txtdesde.Text), Date.Parse(txthasta.Text), "C")


        'ViewState("Dataset") = dskardexC

        'ActualizaPagado(dskardexC)

        'Me.dgDetalle.DataSource = dskardexC.Tables(0)
        'Me.dgDetalle.DataBind()

        UneconDes(dskardexC)

        'Se agregan al desembolso

        Calculo()
        btnAjuste.Enabled = True
        CbxCatalogo1.Enabled = True
        btngrabar.Enabled = True
        btnsave.Enabled = True
        txtnmonpag.Enabled = True
    End Sub
    Private Sub UneconDes(ByVal ds As DataSet)
        Dim ecredkar As New cCredkar
        Dim lnsaldo As Double = 0

        vDetalle = ecredkar.KardexPruebaxDes(txtccodcta.Text.Trim)

        Dim fila As DataRow
        Dim dr As DataRow
        Dim i As Integer = 0

        For Each fila In ds.Tables(0).Rows
            dr = vDetalle.Tables(0).NewRow
            dr("dfecsis") = fila("dfecsis")
            dr("dfecpro") = fila("dfecpro")
            dr("cdescob") = fila("cdescob")
            dr("cnrodoc") = fila("cnrodoc")
            dr("ndiaatr") = fila("ndiaatr")
            dr("npago") = fila("npago")
            dr("ncapita") = fila("ncapita")
            dr("nintere") = fila("nintere")
            dr("nmora") = fila("nmora")
            dr("notros") = fila("notros")
            dr("niva_int") = fila("niva_int")
            dr("niva_mora") = fila("niva_mora")
            dr("nexcedente") = fila("nexcedente")
            dr("nsaldo") = fila("nsaldo")

            vDetalle.Tables(0).Rows.Add(dr)

        Next


        'Coloca Saldo en los Pagos
        For Each Linea In vDetalle.Tables(0).Rows
            If Linea("cdescob") = "D" Then
                lnsaldo = lnsaldo + Linea("ncapdes")
                Linea("nsaldo") = lnsaldo
            Else
                lnsaldo = lnsaldo - Linea("ncapita")
                Linea("nsaldo") = lnsaldo
            End If
        Next

        ViewState.Add("Dataset", vDetalle)
        vDetalle = ViewState("Dataset")

        Me.dgDetalle.DataSource = vDetalle.Tables(0)
        Me.dgDetalle.DataBind()

        ActualizaPagado(vDetalle)
    End Sub

    Private Sub ActualizaPagado(ByVal ds As DataSet)
        Dim lncappag As Double = 0
        Dim lnintpag As Double = 0
        Dim lnmorpag As Double = 0
        Dim lniva_int As Double = 0
        Dim lniva_mora As Double = 0
        Dim lncomision As Double = 0
        Dim lnprogape As Double = 0
        Dim lnotras As Double = 0


        If Not IsDBNull(ds.Tables(0).Compute("sum(ncapita)", "cdescob = 'C'")) Then
            lncappag = ds.Tables(0).Compute("sum(ncapita)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(nintere)", "cdescob = 'C'")) Then
            lnintpag = ds.Tables(0).Compute("sum(nintere)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(nmora)", "cdescob = 'C'")) Then
            lnmorpag = ds.Tables(0).Compute("sum(nmora)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(notros)", "cdescob = 'C'")) Then
            lnotras = ds.Tables(0).Compute("sum(notros)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(niva_int)", "cdescob = 'C'")) Then
            lniva_int = ds.Tables(0).Compute("sum(niva_int)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(niva_mora)", "cdescob = 'C'")) Then
            lniva_mora = ds.Tables(0).Compute("sum(niva_mora)", "cdescob = 'C'")
        End If

        txtpagado1.Text = lncappag
        txtpagado2.Text = lnintpag + lniva_int
        txtpagado3.Text = lnmorpag + lniva_mora
        txtpagado4.Text = lncomision
        txtpagado5.Text = lnprogape
        txtpagado6.Text = 0 'lnotras
    End Sub

    Private Sub ActualizaPagado_Real(ByVal ds As DataSet)
        Dim lncappag As Double = 0
        Dim lnintpag As Double = 0
        Dim lnmorpag As Double = 0
        Dim lniva_int As Double = 0
        Dim lniva_mora As Double = 0
        Dim lncomision As Double = 0
        Dim lnprogape As Double = 0
        Dim lnotras As Double = 0


        If Not IsDBNull(ds.Tables(0).Compute("sum(ncapita)", "cdescob = 'C'")) Then
            lncappag = ds.Tables(0).Compute("sum(ncapita)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(nintere)", "cdescob = 'C'")) Then
            lnintpag = ds.Tables(0).Compute("sum(nintere)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(nmora)", "cdescob = 'C'")) Then
            lnmorpag = ds.Tables(0).Compute("sum(nmora)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(notros)", "cdescob = 'C'")) Then
            lnotras = ds.Tables(0).Compute("sum(notros)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(niva_int)", "cdescob = 'C'")) Then
            lniva_int = ds.Tables(0).Compute("sum(niva_int)", "cdescob = 'C'")
        End If
        If Not IsDBNull(ds.Tables(0).Compute("sum(niva_mora)", "cdescob = 'C'")) Then
            lniva_mora = ds.Tables(0).Compute("sum(niva_mora)", "cdescob = 'C'")
        End If

        txtanterior1.Text = lncappag
        txtanterior2.Text = lnintpag + lniva_int
        txtanterior3.Text = lnmorpag + lniva_mora
        txtanterior4.Text = lncomision
        txtanterior5.Text = lnprogape
        txtanterior6.Text = 0 'lnotras

    End Sub

    Public Function DegridaDataset() As DataSet
        Dim ecredkar As New cCredkar
        Dim ds As New DataSet
        Dim dskar As New DataSet
        dskar = ecredkar.KardexPruebaxDes(txtccodcta.Text.Trim)

        Dim dr As DataRow
        Dim i As Integer = 0

        For xy = 0 To Me.dgDetalle.Rows.Count - 1
            If Me.dgDetalle.Rows(xy).Cells(2).Text.Trim = "D" Then
            Else
                dr = dskar.Tables(0).NewRow
                dr("ccodcta") = Me.txtccodcta.Text.Trim
                dr("nmonto") = Double.Parse(Me.dgDetalle.Rows(xy).Cells(1).Text)
                dr("cdescob") = Me.dgDetalle.Rows(xy).Cells(2).Text
                dr("cconcep") = Me.dgDetalle.Rows(xy).Cells(3).Text
                dr("dfecsis") = Date.Parse(Me.dgDetalle.Rows(xy).Cells(4).Text)
                dr("dfecpro") = Date.Parse(Me.dgDetalle.Rows(xy).Cells(5).Text)
                dr("cestado") = " "
                dr("cclipag") = Me.dgDetalle.Rows(xy).Cells(7).Text
                dr("ctippag") = Me.dgDetalle.Rows(xy).Cells(8).Text
                dr("cnrodoc") = Me.dgDetalle.Rows(xy).Cells(9).Text

                dskar.Tables(0).Rows.Add(dr)
            End If
            HiddenField1.Value = Me.dgDetalle.Rows(xy).Cells(9).Text
        Next

        Return dskar

    End Function

    Public Function DegridaDataset_() As DataSet
        Dim ecredkar As New cCredkar
        Dim ds As New DataSet
        Dim dskar As New DataSet
        Dim ds_tmp As New DataSet
        Dim lnCapita As Double = 0
        Dim lnIntere As Double = 0
        Dim lnmora As Double = 0
        Dim lnOtros As Double = 0
        Dim lnPago As Double = 0
        Dim lncapdes As Double = 0

        ds_tmp = ViewState("Dataset")

        dskar = ecredkar.KardexPruebaxDes_(txtccodcta.Text.Trim)

        Dim dr As DataRow
        Dim i As Integer = 0


        For Each fila As DataRow In ds_tmp.Tables(0).Rows

            If fila("cdescob") = "D" Then
                lncapdes = fila("ncapdes")
            Else
                lncapdes = 0
                lnCapita = fila("ncapita")
                lnIntere = fila("nintere") + fila("niva_int")
                lnmora = fila("nmora") + fila("niva_mora")
                lnOtros = fila("nexcedente")
                lnPago = fila("npago")
            End If


            If lnPago > 0 Then  'Total Pago
                dr = dskar.Tables(0).NewRow
                dr("ccodcta") = Me.txtccodcta.Text.Trim
                dr("nmonto") = lnPago
                dr("cdescob") = "C"
                dr("cconcep") = "CJ"
                dr("dfecsis") = fila("dfecsis")
                dr("dfecpro") = fila("dfecpro")
                dr("cestado") = " "
                dr("cclipag") = ""
                dr("ctippag") = "C"
                dr("cnrodoc") = fila("cnrodoc")

                dskar.Tables(0).Rows.Add(dr)
            End If

            If lnCapita > 0 Then  'Capital
                dr = dskar.Tables(0).NewRow
                dr("ccodcta") = Me.txtccodcta.Text.Trim
                dr("nmonto") = lnCapita
                dr("cdescob") = "C"
                dr("cconcep") = "KP"
                dr("dfecsis") = fila("dfecsis")
                dr("dfecpro") = fila("dfecpro")
                dr("cestado") = " "
                dr("cclipag") = ""
                dr("ctippag") = "C"
                dr("cnrodoc") = fila("cnrodoc")

                dskar.Tables(0).Rows.Add(dr)
            End If

            If lnIntere > 0 Then  'Interes Normal+Iva
                dr = dskar.Tables(0).NewRow
                dr("ccodcta") = Me.txtccodcta.Text.Trim
                dr("nmonto") = lnIntere
                dr("cdescob") = "C"
                dr("cconcep") = "IN"
                dr("dfecsis") = fila("dfecsis")
                dr("dfecpro") = fila("dfecpro")
                dr("cestado") = " "
                dr("cclipag") = ""
                dr("ctippag") = "C"
                dr("cnrodoc") = fila("cnrodoc")

                dskar.Tables(0).Rows.Add(dr)
            End If

            If lnmora > 0 Then  'Interes Moratorio+Iva
                dr = dskar.Tables(0).NewRow
                dr("ccodcta") = Me.txtccodcta.Text.Trim
                dr("nmonto") = lnmora
                dr("cdescob") = "C"
                dr("cconcep") = "MO"
                dr("dfecsis") = fila("dfecsis")
                dr("dfecpro") = fila("dfecpro")
                dr("cestado") = " "
                dr("cclipag") = ""
                dr("ctippag") = "C"
                dr("cnrodoc") = fila("cnrodoc")

                dskar.Tables(0).Rows.Add(dr)
            End If

            If lnOtros > 0 Then  'Excedente
                dr = dskar.Tables(0).NewRow
                dr("ccodcta") = Me.txtccodcta.Text.Trim
                dr("nmonto") = lnOtros
                dr("cdescob") = "C"
                dr("cconcep") = "EX"
                dr("dfecsis") = fila("dfecsis")
                dr("dfecpro") = fila("dfecpro")
                dr("cestado") = " "
                dr("cclipag") = ""
                dr("ctippag") = "C"
                dr("cnrodoc") = fila("cnrodoc")

                dskar.Tables(0).Rows.Add(dr)
            End If
        Next


        Return dskar

    End Function

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click

        'Importara pagos anteriores en automaticos, siempre que se aplique el primer Abono
        If Not IsNumeric(txtnmonpag.Text) Then
            codigoJs = "<script language='javascript'>alert('Monto Incorrecto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If Me.txtbandera.Text = "0" Then
            Importa_Pagos_Automatico()
        End If

        aplicar(1)
        aplicarPago()


        ''Realiza Pagos de mas adelante en Automatico Prueba Rafa 07/05/2015
        'dt = omclass.Extrae_Detalle_Pagos(Date.Parse(Me.txtdfecval.Text), Me.txtccodcta.Text.Trim)

        'If dt.Rows.Count > 0 Then
        '    For Each fila As DataRow In dt.Rows
        '        aplicar_Posterior(fila("dfecpro"))
        '        aplicarPagos_Posteriores(fila("nmonto"), fila("dfecpro"))
        '    Next
        'End If

        ''''' Fin

        aplicar(2)
        ActualizaPagado(ViewState("Dataset"))


        'btngrabar.Enabled = False

        Calculo()
        btnAjuste.Enabled = True
        CbxCatalogo1.Enabled = True
        txtnmonpag.Text = ""
        Me.txtbandera.Text = "1"


        'Ejemplo de Ordenamiento
        'Dim dw As New DataView
        'dw = dt.DefaultView
        'dw.Sort = "dfecpro asc"

        ''ViewState("Datatable") = dw
        'ViewState("Datatable") = dt

    End Sub

    Private Sub aplicarPago()
        Dim dskar As New DataSet
        Dim ds As New DataSet
        'dskar = DegridaDataset_()

        dskar = ViewState("Dataset")

        'ds = DegridaDataset_()

        Dim dr As DataRow

        Dim lnmonpag As Double = 0
        Dim lnsaldo As Double = 0
        Dim lniva_mora As Double = 0
        Dim lniva_interes As Double = 0
        Dim gniva As Double = Session("gnIVA")

        lnmonpag = Double.Parse(txtnmonpag.Text) - (Double.Parse(txtncompag.Text) + Double.Parse(txtnprogapepag.Text) + Double.Parse(txtnotraspag.Text))


        Dim lnnumero As Integer = dskar.Tables(0).Rows.Count + 1  'Integer.Parse(HiddenField1.Value) + 1

        Dim lcnrodoc As String
        lcnrodoc = conviertecnrodoc(lnnumero)

        Dim lnintmor As Double = 0
        Dim lnintere As Double = 0
        Dim lncapita As Double = 0
        Dim lnsalInt As Double = 0
        Dim lnmontoint As Decimal = 0

        If Me.tipo_credito.Text = "FLAT" Then
            lnmontoint = Decimal.Parse(txtnmonpag.Text) - Double.Parse(txtnsalmor.Text)  'se le quita gastos en intereses moratorios
            lnmontoint = Math.Round(lnmontoint, 2)
            lnsalInt = clsaplica.InteresFlatCobrar_PruebaX(Me.txtccodcta.Text.Trim, lnmontoint, Date.Parse(txtdfecval.Text), dskar)
        Else
            lnsalInt = Double.Parse(txtnsalint.Text)
        End If

        'Interes Moratorio + Iva
        If Double.Parse(txtnsalmor.Text) > 0 And lnmonpag > 0 Then
            If lnmonpag > Double.Parse(txtnsalmor.Text) Then
                lnintmor = Double.Parse(txtnsalmor.Text)
                lnmonpag = lnmonpag - Double.Parse(txtnsalmor.Text)

                lniva_mora = lnintmor - (lnintmor / gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnintmor = Math.Round(lnintmor - lniva_mora, 2)

            Else
                lnintmor = lnmonpag
                lnmonpag = 0

                lniva_mora = lnintmor - (lnintmor / gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnintmor = Math.Round(lnintmor - lniva_mora, 2)
            End If

            'dr = dskar.Tables(0).NewRow
            'dr("ccodcta") = txtccodcta.Text.Trim
            'dr("nmonto") = lnintmor
            'dr("cdescob") = "C"
            'dr("cconcep") = "MO"
            'dr("dfecsis") = Date.Parse(txtdfecval.Text)
            'dr("dfecpro") = Date.Parse(txtdfecval.Text)
            'dr("cestado") = " "
            'dr("cclipag") = "0"
            'dr("ctippag") = "C"
            'dr("cnrodoc") = lcnrodoc
            'dskar.Tables(0).Rows.Add(dr)

        End If '---------------------------------------------------------------------------

        'Interes Normal + Iva
        If lnsalInt > 0 And lnmonpag > 0 Then

            If lnmonpag > lnsalInt Then
                lnintere = lnsalInt 'Double.Parse(txtnsalint.Text)

                lniva_interes = lnintere - (lnintere / gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)

                lnmonpag = lnmonpag - lnsalInt
            Else
                lnintere = lnmonpag
                lnmonpag = 0

                lniva_interes = lnintere - (lnintere / gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)
            End If


            'dr = dskar.Tables(0).NewRow
            'dr("ccodcta") = txtccodcta.Text.Trim
            'dr("nmonto") = lnintere
            'dr("cdescob") = "C"
            'dr("cconcep") = "IN"
            'dr("dfecsis") = Date.Parse(txtdfecval.Text)
            'dr("dfecpro") = Date.Parse(txtdfecval.Text)
            'dr("cestado") = " "
            'dr("cclipag") = "0"
            'dr("ctippag") = "C"
            'dr("cnrodoc") = lcnrodoc

            'dskar.Tables(0).Rows.Add(dr)
        End If '---------------------------------------------------------------------------


        'Monto Total
        If lnmonpag > 0 Then

            If lnmonpag > Double.Parse(txtnsalcap.Text) Then
                lncapita = Double.Parse(txtnsalcap.Text)
                lnmonpag = lncapita - Double.Parse(txtnsalcap.Text)
            Else
                lncapita = lnmonpag
                lnmonpag = 0
            End If

            'dr = dskar.Tables(0).NewRow
            'dr("ccodcta") = txtccodcta.Text.Trim
            'dr("nmonto") = lncapita
            'dr("cdescob") = "C"
            'dr("cconcep") = "KP"
            'dr("dfecsis") = Date.Parse(txtdfecval.Text)
            'dr("dfecpro") = Date.Parse(txtdfecval.Text)
            'dr("cestado") = " "
            'dr("cclipag") = "0"
            'dr("ctippag") = "C"
            'dr("cnrodoc") = lcnrodoc

            'dskar.Tables(0).Rows.Add(dr)
        End If '-----------------------------------------------------------------------------

        'Acumula El pago
        If (lnintmor + lnintere + lncapita + lniva_interes) > 0 Then
            dr = dskar.Tables(0).NewRow
            dr("dfecsis") = Date.Parse(txtdfecval.Text)
            dr("dfecpro") = Date.Parse(txtdfecval.Text)
            dr("cdescob") = "C"
            dr("cnrodoc") = lcnrodoc
            dr("ndiaatr") = 0
            dr("npago") = lnintmor + lnintere + lncapita + lniva_interes + lniva_mora
            dr("ncapita") = lncapita
            dr("nintere") = lnintere
            dr("nmora") = lnintmor
            dr("notros") = lniva_interes + lniva_mora
            dr("niva_int") = lniva_interes
            dr("niva_mora") = lniva_mora
            dr("nexcedente") = 0
            dr("nsaldo") = 0

            dskar.Tables(0).Rows.Add(dr)

        End If

        For Each Linea In dskar.Tables(0).Rows
            If Linea("cdescob") = "D" Then
                lnsaldo = lnsaldo + Linea("ncapdes")
                Linea("nsaldo") = lnsaldo
            Else
                lnsaldo = lnsaldo - Linea("ncapita")
                Linea("nsaldo") = lnsaldo
            End If
        Next

        ViewState("Dataset") = dskar
        Me.dgDetalle.DataSource = dskar.Tables(0)
        Me.dgDetalle.DataBind()
    End Sub

    Private Sub aplicarPago_Automatico(ByVal pdfecpro As Date, ByVal pnmonto As Double)
        Dim dskar As New DataSet
        Dim ds As New DataSet

        dskar = ViewState("Dataset")

        Dim dr As DataRow

        Dim lnmonpag As Double = 0
        Dim lnsaldo As Double = 0
        Dim lniva_mora As Double = 0
        Dim lniva_interes As Double = 0
        Dim gniva As Double = Session("gnIVA")

        lnmonpag = pnmonto - (Double.Parse(txtncompag.Text) + Double.Parse(txtnprogapepag.Text) + Double.Parse(txtnotraspag.Text))


        Dim lnnumero As Integer = dskar.Tables(0).Rows.Count + 1  'Integer.Parse(HiddenField1.Value) + 1

        Dim lcnrodoc As String
        lcnrodoc = conviertecnrodoc(lnnumero)

        Dim lnintmor As Double = 0
        Dim lnintere As Double = 0
        Dim lncapita As Double = 0
        Dim lnsalInt As Double = 0
        Dim lnmontoint As Decimal = 0

        If Me.tipo_credito.Text = "FLAT" Then
            lnmontoint = pnmonto - Double.Parse(txtnsalmor.Text)  'se le quita gastos en intereses moratorios
            lnmontoint = Math.Round(lnmontoint, 2)
            lnsalInt = clsaplica.InteresFlatCobrar_PruebaX(Me.txtccodcta.Text.Trim, lnmontoint, pdfecpro, dskar)
        Else
            lnsalInt = Double.Parse(txtnsalint.Text)
        End If

        'Interes Moratorio + Iva
        If Double.Parse(txtnsalmor.Text) > 0 And lnmonpag > 0 Then
            If lnmonpag > Double.Parse(txtnsalmor.Text) Then
                lnintmor = Double.Parse(txtnsalmor.Text)
                lnmonpag = lnmonpag - Double.Parse(txtnsalmor.Text)

                lniva_mora = lnintmor - (lnintmor / gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnintmor = Math.Round(lnintmor - lniva_mora, 2)

            Else
                lnintmor = lnmonpag
                lnmonpag = 0

                lniva_mora = lnintmor - (lnintmor / gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnintmor = Math.Round(lnintmor - lniva_mora, 2)
            End If

        End If '---------------------------------------------------------------------------

        'Interes Normal + Iva
        If lnsalInt > 0 And lnmonpag > 0 Then

            If lnmonpag > lnsalInt Then
                lnintere = lnsalInt 'Double.Parse(txtnsalint.Text)

                lniva_interes = lnintere - (lnintere / gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)

                lnmonpag = lnmonpag - lnsalInt
            Else
                lnintere = lnmonpag
                lnmonpag = 0

                lniva_interes = lnintere - (lnintere / gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)
            End If

        End If '---------------------------------------------------------------------------


        'Monto Total
        If lnmonpag > 0 Then

            If lnmonpag > Double.Parse(txtnsalcap.Text) Then
                lncapita = Double.Parse(txtnsalcap.Text)
                lnmonpag = lncapita - Double.Parse(txtnsalcap.Text)
            Else
                lncapita = lnmonpag
                lnmonpag = 0
            End If

        End If '-----------------------------------------------------------------------------

        'Acumula El pago
        If (lnintmor + lnintere + lncapita + lniva_interes) > 0 Then
            dr = dskar.Tables(0).NewRow
            dr("dfecsis") = pdfecpro
            dr("dfecpro") = pdfecpro
            dr("cdescob") = "C"
            dr("cnrodoc") = lcnrodoc
            dr("ndiaatr") = 0
            dr("npago") = lnintmor + lnintere + lncapita + lniva_interes + lniva_mora
            dr("ncapita") = lncapita
            dr("nintere") = lnintere
            dr("nmora") = lnintmor
            dr("notros") = lniva_interes + lniva_mora
            dr("niva_int") = lniva_interes
            dr("niva_mora") = lniva_mora
            dr("nexcedente") = 0
            dr("nsaldo") = 0

            dskar.Tables(0).Rows.Add(dr)

        End If

        For Each Linea In dskar.Tables(0).Rows
            If Linea("cdescob") = "D" Then
                lnsaldo = lnsaldo + Linea("ncapdes")
                Linea("nsaldo") = lnsaldo
            Else
                lnsaldo = lnsaldo - Linea("ncapita")
                Linea("nsaldo") = lnsaldo
            End If
        Next

        ViewState("Dataset") = dskar
        
    End Sub

    Private Sub aplicarPagos_Posteriores(ByVal pnMonto As Double, ByVal pdfecpro As Date)
        Dim dskar As New DataSet
        Dim ds As New DataSet
        'dskar = DegridaDataset_()

        dskar = ViewState("Dataset")

        'ds = DegridaDataset_()

        Dim dr As DataRow

        Dim lnmonpag As Double = 0
        Dim lnsaldo As Double = 0
        Dim lniva_mora As Double = 0
        Dim lniva_interes As Double = 0
        Dim gniva As Double = Session("gnIVA")

        lnmonpag = pnMonto - (Double.Parse(txtncompag.Text) + Double.Parse(txtnprogapepag.Text) + Double.Parse(txtnotraspag.Text))


        Dim lnnumero As Integer = dskar.Tables(0).Rows.Count + 1  'Integer.Parse(HiddenField1.Value) + 1

        Dim lcnrodoc As String
        lcnrodoc = conviertecnrodoc(lnnumero)

        Dim lnintmor As Double = 0
        Dim lnintere As Double = 0
        Dim lncapita As Double = 0
        Dim lnsalInt As Double = 0
        Dim lnmontoint As Decimal = 0

        If Me.tipo_credito.Text = "FLAT" Then
            lnmontoint = pnMonto - Double.Parse(txtnsalmor.Text)  'se le quita gastos en intereses moratorios
            lnmontoint = Math.Round(lnmontoint, 2)
            lnsalInt = clsaplica.InteresFlatCobrar_PruebaX(Me.txtccodcta.Text.Trim, lnmontoint, pdfecpro, dskar)
        Else
            lnsalInt = Double.Parse(txtnsalint.Text)
        End If

        'Interes Moratorio + Iva
        If Double.Parse(txtnsalmor.Text) > 0 And lnmonpag > 0 Then
            If lnmonpag > Double.Parse(txtnsalmor.Text) Then
                lnintmor = Double.Parse(txtnsalmor.Text)
                lnmonpag = lnmonpag - Double.Parse(txtnsalmor.Text)

                lniva_mora = lnintmor - (lnintmor / gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnintmor = Math.Round(lnintmor - lniva_mora, 2)

            Else
                lnintmor = lnmonpag
                lnmonpag = 0

                lniva_mora = lnintmor - (lnintmor / gniva)
                lniva_mora = Math.Round(lniva_mora, 2)
                lnintmor = Math.Round(lnintmor - lniva_mora, 2)
            End If

            'dr = dskar.Tables(0).NewRow
            'dr("ccodcta") = txtccodcta.Text.Trim
            'dr("nmonto") = lnintmor
            'dr("cdescob") = "C"
            'dr("cconcep") = "MO"
            'dr("dfecsis") = Date.Parse(txtdfecval.Text)
            'dr("dfecpro") = Date.Parse(txtdfecval.Text)
            'dr("cestado") = " "
            'dr("cclipag") = "0"
            'dr("ctippag") = "C"
            'dr("cnrodoc") = lcnrodoc
            'dskar.Tables(0).Rows.Add(dr)

        End If '---------------------------------------------------------------------------

        'Interes Normal + Iva
        If lnsalInt > 0 And lnmonpag > 0 Then

            If lnmonpag > lnsalInt Then
                lnintere = lnsalInt 'Double.Parse(txtnsalint.Text)

                lniva_interes = lnintere - (lnintere / gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)

                lnmonpag = lnmonpag - lnsalInt
            Else
                lnintere = lnmonpag
                lnmonpag = 0

                lniva_interes = lnintere - (lnintere / gniva)
                lniva_interes = Math.Round(lniva_interes, 2)
                lnintere = Math.Round(lnintere - lniva_interes, 2)
            End If


            'dr = dskar.Tables(0).NewRow
            'dr("ccodcta") = txtccodcta.Text.Trim
            'dr("nmonto") = lnintere
            'dr("cdescob") = "C"
            'dr("cconcep") = "IN"
            'dr("dfecsis") = Date.Parse(txtdfecval.Text)
            'dr("dfecpro") = Date.Parse(txtdfecval.Text)
            'dr("cestado") = " "
            'dr("cclipag") = "0"
            'dr("ctippag") = "C"
            'dr("cnrodoc") = lcnrodoc

            'dskar.Tables(0).Rows.Add(dr)
        End If '---------------------------------------------------------------------------


        'Monto Total
        If lnmonpag > 0 Then

            If lnmonpag > Double.Parse(txtnsalcap.Text) Then
                lncapita = Double.Parse(txtnsalcap.Text)
                lnmonpag = lncapita - Double.Parse(txtnsalcap.Text)
            Else
                lncapita = lnmonpag
                lnmonpag = 0
            End If

            'dr = dskar.Tables(0).NewRow
            'dr("ccodcta") = txtccodcta.Text.Trim
            'dr("nmonto") = lncapita
            'dr("cdescob") = "C"
            'dr("cconcep") = "KP"
            'dr("dfecsis") = Date.Parse(txtdfecval.Text)
            'dr("dfecpro") = Date.Parse(txtdfecval.Text)
            'dr("cestado") = " "
            'dr("cclipag") = "0"
            'dr("ctippag") = "C"
            'dr("cnrodoc") = lcnrodoc

            'dskar.Tables(0).Rows.Add(dr)
        End If '-----------------------------------------------------------------------------

        'Acumula El pago
        If (lnintmor + lnintere + lncapita + lniva_interes) > 0 Then
            dr = dskar.Tables(0).NewRow
            dr("dfecsis") = pdfecpro
            dr("dfecpro") = pdfecpro
            dr("cdescob") = "C"
            dr("cnrodoc") = lcnrodoc
            dr("ndiaatr") = 0
            dr("npago") = lnintmor + lnintere + lncapita + lniva_interes + lniva_mora
            dr("ncapita") = lncapita
            dr("nintere") = lnintere
            dr("nmora") = lnintmor
            dr("notros") = lniva_interes + lniva_mora
            dr("niva_int") = lniva_interes
            dr("niva_mora") = lniva_mora
            dr("nexcedente") = 0
            dr("nsaldo") = 0

            dskar.Tables(0).Rows.Add(dr)

        End If

        For Each Linea In dskar.Tables(0).Rows
            If Linea("cdescob") = "D" Then
                lnsaldo = lnsaldo + Linea("ncapdes")
                Linea("nsaldo") = lnsaldo
            Else
                lnsaldo = lnsaldo - Linea("ncapita")
                Linea("nsaldo") = lnsaldo
            End If
        Next

        ViewState("Dataset") = dskar
        Me.dgDetalle.DataSource = dskar.Tables(0)
        Me.dgDetalle.DataBind()
    End Sub

    Private Function conviertecnrodoc(ByVal numero As Integer) As String

        Dim lcnrodoc As String
        lcnrodoc = numero.ToString().Trim
        Dim tamano As Integer
        tamano = lcnrodoc.Trim.Length
        For i = 1 To 4 - tamano
            lcnrodoc = "0" & lcnrodoc
        Next

        Return lcnrodoc
    End Function

    Private Sub Calculo()
        If txtanterior1.Text.Trim = "" Or txtanterior1.Text = Nothing Then
            txtanterior1.Text = 0
        End If
        If txtanterior2.Text.Trim = "" Or txtanterior2.Text = Nothing Then
            txtanterior2.Text = 0
        End If
        If txtanterior3.Text.Trim = "" Or txtanterior3.Text = Nothing Then
            txtanterior3.Text = 0
        End If
        If txtanterior4.Text.Trim = "" Or txtanterior4.Text = Nothing Then
            txtanterior4.Text = 0
        End If
        If txtanterior5.Text.Trim = "" Or txtanterior5.Text = Nothing Then
            txtanterior5.Text = 0
        End If
        If txtanterior6.Text.Trim = "" Or txtanterior6.Text = Nothing Then
            txtanterior6.Text = 0
        End If


        txtajuste1.Text = Math.Round(Double.Parse(txtpagado1.Text) - Double.Parse(txtanterior1.Text), 2)
        txtajuste2.Text = Math.Round(Double.Parse(txtpagado2.Text) - Double.Parse(txtanterior2.Text), 2)
        txtajuste3.Text = Math.Round(Double.Parse(txtpagado3.Text) - Double.Parse(txtanterior3.Text), 2)
        txtajuste4.Text = Math.Round(Double.Parse(txtpagado4.Text) - Double.Parse(txtanterior4.Text), 2)
        txtajuste5.Text = Math.Round(Double.Parse(txtpagado5.Text) - Double.Parse(txtanterior5.Text), 2)
        txtajuste6.Text = Math.Round(Double.Parse(txtpagado6.Text) - Double.Parse(txtanterior6.Text), 2)
    End Sub

    Protected Sub txtanterior1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtanterior1.TextChanged
        Calculo()
    End Sub

    Protected Sub txtanterior2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtanterior2.TextChanged
        Calculo()
    End Sub

    Protected Sub txtanterior3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtanterior3.TextChanged
        Calculo()
    End Sub

    Protected Sub txtanterior4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtanterior4.TextChanged
        Calculo()
    End Sub

    Protected Sub txtanterior5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtanterior5.TextChanged
        Calculo()
    End Sub

    Protected Sub txtanterior6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtanterior6.TextChanged
        Calculo()
    End Sub

    Protected Sub dgDetalle_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles dgDetalle.RowDataBound
        Dim datt As New DataSet

        Dim nTotalPagado As Double
        Dim nTotalCapital As Double
        Dim nTotalInteres As Double
        Dim nTotalMora As Double
        Dim nTotalOtros As Double


        datt = ViewState("Dataset")


        nTotalPagado = 0
        nTotalCapital = 0
        nTotalInteres = 0
        nTotalMora = 0
        nTotalOtros = 0



        If e.Row.RowType = DataControlRowType.Footer Then
            If datt.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            For Each Fila As DataRow In datt.Tables(0).Rows

                If Fila("cdescob") = "C" Then
                    nTotalPagado = Double.Parse(IIf(nTotalPagado = Nothing, 0, nTotalPagado)) + _
                                Double.Parse(IIf(Fila.Item("npago") = Nothing, 0, Fila.Item("npago")))
                    nTotalCapital = Double.Parse(IIf(nTotalCapital = Nothing, 0, nTotalCapital)) + _
                                Double.Parse(IIf(Fila.Item("ncapita") = Nothing, 0, Fila.Item("ncapita")))
                    nTotalInteres = Double.Parse(IIf(nTotalInteres = Nothing, 0, nTotalInteres)) + _
                                Double.Parse(IIf(Fila.Item("nintere") = Nothing, 0, Fila.Item("nintere")))
                    nTotalMora = Double.Parse(IIf(nTotalMora = Nothing, 0, nTotalMora)) + _
                                Double.Parse(IIf(Fila.Item("nmora") = Nothing, 0, Fila.Item("nmora")))
                    nTotalOtros = Double.Parse(IIf(nTotalOtros = Nothing, 0, nTotalOtros)) + _
                                Double.Parse(IIf(Fila.Item("notros") = Nothing, 0, Fila.Item("notros")))


                End If

            Next

            e.Row.Cells(1).Text = "TOTALES"
            e.Row.Cells(1).Font.Bold = True

            e.Row.Cells(4).Text = nTotalPagado
            e.Row.Cells(4).Text = Format(Math.Round(Double.Parse(e.Row.Cells(4).Text), 2), "#########.00")
            e.Row.Cells(4).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(4).Font.Bold = True

            e.Row.Cells(5).Text = nTotalCapital
            e.Row.Cells(5).Text = Format(Math.Round(Double.Parse(e.Row.Cells(5).Text), 2), "#########.00")
            e.Row.Cells(5).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(5).Font.Bold = True

            e.Row.Cells(6).Text = nTotalInteres
            e.Row.Cells(6).Text = Format(Math.Round(Double.Parse(e.Row.Cells(6).Text), 2), "#########.00")
            e.Row.Cells(6).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(6).Font.Bold = True

            e.Row.Cells(7).Text = nTotalMora
            e.Row.Cells(7).Text = Format(Math.Round(Double.Parse(e.Row.Cells(7).Text), 2), "#########.00")
            e.Row.Cells(7).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(7).Font.Bold = True

            e.Row.Cells(8).Text = nTotalOtros
            e.Row.Cells(8).Text = Format(Math.Round(Double.Parse(e.Row.Cells(8).Text), 2), "#########.00")
            e.Row.Cells(8).HorizontalAlign = HorizontalAlign.Right
            e.Row.Cells(8).Font.Bold = True

        End If
    End Sub

    Protected Sub btnverifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnverifica.Click
        Calculo()
        btnAjuste.Enabled = True
        CbxCatalogo1.Enabled = True
    End Sub

    Protected Sub CbxCatalogo1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxCatalogo1.SelectedIndexChanged

    End Sub

    Protected Sub btnAjuste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAjuste.Click
        Dim omclass As New cCredkar
        Dim lnRetorno As Integer = 0
        Dim dskar As New DataSet
        Dim lnMonPag As Double = (Double.Parse(Me.txtajuste3.Text) + Double.Parse(Me.txtajuste2.Text) + Double.Parse(Me.txtajuste1.Text))
        Dim lcglosa As String = "Ajuste de Credito a nombre de: " & Me.txtcnomcli.Text.Trim & " # Ref. " & Me.txtccodcta.Text.Trim


        dskar = ViewState("Dataset")


        Dim lnnumero As Integer = dskar.Tables(0).Rows.Count 'Integer.Parse(HiddenField1.Value) + 1

        'Dim lcnrodoc As String
        'lcnrodoc = conviertecnrodoc(lnnumero)

        Dim Encabeza_Part() As String = {Session("GDFECSIS"), Session("GCCODOFI"), lcglosa, "", Session("GDFECSIS"), _
                                       Session("gcCodusu"), "", "", "", Me.txtccodcta.Text.Trim}


        Dim Detalle_Pago() As String = {Double.Parse(Me.txtajuste3.Text), Double.Parse(Me.txtajuste2.Text), Double.Parse(Me.txtajuste1.Text), _
                                        Math.Round(lnMonPag, 2), Session("gnIVA"), CbxCatalogo1.SelectedValue.Trim, "N", lnnumero}

        If Double.Parse(Me.txtajuste1.Text) = 0 And Double.Parse(Me.txtajuste2.Text) = 0 And Double.Parse(Me.txtajuste2.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('No Existen Datos para Ajustar, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If


        lnRetorno = omclass.Inserta_AjusteX(Encabeza_Part, Detalle_Pago)


        If lnRetorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error en el Ajuste, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Actualiza Boletas en Auxiliar de Ajustes
        dt = ViewState("Datatable")


        lnRetorno = omclass.Inserta_Auxiliar_AjusteX(Me.txtccodcta.Text.Trim, Me.txtccodcli.Text.Trim, dt, Session("gccodusu"))


        If lnRetorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error en el Ajuste, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Limpieza()
        btnAjuste.Enabled = False
        btnaplicar.Enabled = False
        btngrabar.Enabled = False
        Button1.Enabled = False
        btnverifica.Enabled = False

    End Sub

    Protected Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim dr As DataRow
        Dim dt As New DataTable


        If Not IsNumeric(txtnmonpag.Text) Then
            codigoJs = "<script language='javascript'>alert('Monto Incorrecto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If



        If Double.Parse(txtnmonpag.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('Monto Incorrecto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If Me.txtcnuming.Text.Trim = 0 Then
            codigoJs = "<script language='javascript'>alert('No de Boleta Invalida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If IsDate(Me.txtdfecval.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('Fecha Invalida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If


        'Valida que la Boleta no se haya almacenado previamiente
        dt_ajustes = ViewState("Ajustes")

        For Each fila As DataRow In dt_ajustes.Rows
            If fila("cnuming").ToString.Trim = Me.txtcnuming.Text.Trim And fila("nmonto") = Double.Parse(Me.txtnmonpag.Text) And _
                fila("dfecpro") = Date.Parse(Me.txtdfecval.Text) Then

                codigoJs = "<script language='javascript'>alert('La Boleta ya fue Digitada, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Exit Sub
            End If

        Next


        dt = ViewState("Datatable")

        If Me.txtbandera.Text = "0" Then
            dt = omclass.Extrae_Detalle_Pagos_Creditos(Me.txtccodcta.Text.Trim)
        End If

        If Double.Parse(Me.txtnmonpag.Text) > 0 Then
            dr = dt.NewRow
            dr("dfecsis") = Date.Parse(Me.txtdfecval.Text)
            dr("dfecpro") = Date.Parse(Me.txtdfecval.Text)
            dr("cnrodoc") = ""
            dr("nmonto") = Double.Parse(Me.txtnmonpag.Text)
            dr("cnuming") = Me.txtcnuming.Text.Trim
            dt.Rows.Add(dr)
        End If


        ViewState("Datatable") = dt

        'Genera un clon para ordenar los pagos
        Me.txtbandera.Text = "1"
        txtdfecval.Text = Session("gdfecsis")
        Me.txtnmonpag.Text = "0.00"
        Me.txtcnuming.Text = ""
        btnproc.Enabled = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnproc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnproc.Click
        dt = ViewState("Datatable")

        Dim ds As New DataSet
        Dim dskar_ As New DataSet
        Dim rows() As DataRow
        Dim sortOrder As String = "dfecpro asc"
        Dim expression As String = ""
        ' copy table structure
        Dim dtNew As DataTable = dt.Clone()

        rows = dt.Select(expression, sortOrder)

        'Insertara el datarow filtrado en un el dataset
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next

        Importa_Pagos_Automatico_Filtro()

        'Ahora Aplica los pagos nuevamente
        For Each linea In dtNew.Rows
            aplicar_Automatico(linea("dfecpro"))
            aplicarPago_Automatico(linea("dfecpro"), linea("nmonto"))
        Next

        ActualizaPagado(ViewState("Dataset"))
        Calculo()

        dskar_ = ViewState("Dataset")
        Me.dgDetalle.DataSource = dskar_.Tables(0)
        Me.dgDetalle.DataBind()
        btnAjuste.Enabled = True



    End Sub
End Class


