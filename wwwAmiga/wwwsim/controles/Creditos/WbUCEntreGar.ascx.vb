Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class controles_Creditos_WbUCEntreGar
    Inherits ucWBase


#Region "Privadas"
    Private codigoJs As String
    Private cls1 As New SIM.BL.pagdesver
    Private clsppal As New SIM.BL.class1
    Private cClsAdP As New SIM.BL.ClsAdPart
    Private clsConvert As New SIM.BL.ConversionLetras
#End Region


#Region "Metodos"
    Private Sub limpieza()
        txtcCodgar.Text = ""
        txtcNrogar.Text = ""
        txtaldia.Text = ""
        txtSaldoGar.Text = ""
        Me.txtccodcliente.Text = ""
        Grid_Garantia.Visible = False
    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            cargarcombos()
            Activa()
        End If
    End Sub
    Private Sub Activa()
        Me.Button1.Enabled = True
        Me.Button2.Enabled = False

    End Sub
    Private Sub Desactiva()
        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
    End Sub

    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnNivel"), Session("gcCodOfi"))

        Dim dsb As New DataSet
        clsbancos.ObtenerDataSetPorID_Oficina_Tipo(dsb, Session("gcCodofi"), "RE")
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()


        'carga instituciones

        'carga oficinas
        Me.ddlcodofi.DataTextField = "cnomofi"
        Me.ddlcodofi.DataValueField = "ccodofi"
        Me.ddlcodofi.DataSource = mlistaoficina
        Me.ddlcodofi.DataBind()
        '   Me.calfecval.SelectedDate = Session("gdfecsis")

        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("125", "1")

        Me.ddlproducto.DataTextField = "cdescri"
        Me.ddlproducto.DataValueField = "ccodigo"
        Me.ddlproducto.DataSource = mListaTabttab
        Me.ddlproducto.DataBind()
        ddlproducto.SelectedValue = "01"


        Me.TextBox2.Text = Session("gdfecsis")
        Me.txtaldia.Text = 0

        Me.btnprocesar.Disabled = False

    End Sub

    'Public Sub CargarPorCliente(ByVal codigoCliente As String)
    '    Me.txtcnrocta.Text = codigoCliente
    '    ViewState.Add("pccodcta", codigoCliente)
    '    '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    '    Dim entidadcremcre As New cremcre
    '    Dim ecremcre As New cCremcre
    '    Dim mclimgar As New cClimgar
    '    Dim ds_g As New DataSet

    '    entidadcremcre.ccodcta = codigoCliente
    '    ecremcre.ObtenerCremcre(entidadcremcre)
    '    Dim lcoficina As String
    '    lcoficina = entidadcremcre.coficina

    '    Me.TextBox1.Text = ""
    '    '        ddlcodofi.SelectedValue = lcoficina
    '    ddlcodofi.SelectedValue = Session("gccodofi")

    '    'Envia información al grid de las garantias para poder ser activadas
    '    ds_g = mclimgar.Extrae_Garantia_Pendiente(codigoCliente)

    '    Me.Grid_Garantia.DataSource = ds_g.Tables(0)
    '    Me.grid_Garantia.DataBind()
    '    Grid_Garantia.Visible = True
    '    Activa()
    '    Me.aplicar()
    'End Sub


    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        'Preserva el id del codigo de credito seleccionado en la busqueda
        ViewState.Add("pccodcta", codigoCliente)
        'Me.txtcnrocta.Text = codigoCliente
        Me.txtccodcli.Text = ViewState("pccodcta") 'Asigna el id del credito al campo del formulario

        'Me.btnaplicar_ServerClick(Me, New System.EventArgs)
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        Dim entidadclimide As New climide
        Dim eclimide As New cClimide
        Dim mclimgar As New cClimgar
        Dim ds_g As New DataSet
        Dim ds_Otr As New DataSet

        'entidadcremcre.ccodcta = codigoCliente
        entidadcremcre.ccodcta = ViewState("pccodcta") 'asigna el id del credito a la instancia del credito
        ecremcre.ObtenerCremcre(entidadcremcre) 'busca los datos completos del credito basado en el id del credito

        'ds_Otr = mclimgar.Extrae_Datos_Otros_Ingresos(Me.txtccodcli.Text.Trim)
      

        'condiciona el boton de guardar al estatus del credito
        If Not (entidadcremcre.cestado = "G") Then
            Button1.Enabled = False
            Exit Sub
        End If

        ds_Otr = mclimgar.Extrae_Garantia_Pendiente(entidadcremcre.ccodcli)

        Grid_Garantia.DataSource = ds_Otr.Tables(0)
        Grid_Garantia.DataBind()
        Grid_Garantia.Visible = True

        Me.txtccodcliente.Text = entidadcremcre.ccodcli 'asigna el codigo de cliente a campo en form
        Me.txtcnrocta.Text = entidadcremcre.ccodcta 'asigna el id del credito a campo en formulario

        entidadclimide.ccodcli = entidadcremcre.ccodcli 'busca los datos del cliente basados en el codigo del cliente
        eclimide.ObtenerClimide(entidadclimide)

        Me.txtnomcli.Text = entidadclimide.cnomcli 'asigna el nombre del cliente a campo en formulario

        Dim lnSaldoAho As Double = 0
        Dim omahomcta As New cAhomcta

        lnSaldoAho = omahomcta.Extraer_ctas_Ahorro_Socio_Saldo_Producto(entidadcremcre.ccodcli, "02")

        Me.txtSaldoGar.Text = lnSaldoAho

        Dim lcoficina As String
        lcoficina = entidadcremcre.coficina
        'ddlcodofi.SelectedValue = lcoficina
        ddlcodofi.SelectedValue = Session("gccodofi")
        'ViewState("pccodcta") = entidadcremcre.ccodcli 'asigna al view state ViewState("pccodcta") el codigo de cliente
        ViewState("pccodcli") = entidadcremcre.ccodcli 'asigna al view state ViewState("pccodcta") el codigo de cliente

       
        Activa()
        'Me.aplicar()
    End Sub

    Sub aplicar()
        'cremcre
        Dim entidad1 As New SIM.EL.climide
        Dim eclimide As New SIM.BL.cClimide
        entidad1.ccodcli = ViewState("pccodcta")

        eclimide.ObtenerClimide(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Me.txtccodcli.Text = entidad1.ccodcli

        'Procesar()
    End Sub
    Private Sub Button5_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Procesar()



    End Sub
    Private Sub btnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocesar.ServerClick
        Procesar()
    End Sub

    Private Sub Cancela()
        Me.txtcapita.Text = " "
        Me.txtinteres.Text = " "
        Me.txtmora.Text = " "
        Me.txttotal.Text = " "
        Me.txtccodcli.Text = " "
        Me.txtnomcli.Text = " "
        Me.txtmoncuo.Text = " "
        Me.txtdias.Text = " "
        Me.txtcomisiones.Text = " "
        Me.txtnseguro.Text = " "
        Me.txtdeucap.Text = " "

        Me.txtmon30.Text = " "
        Me.txtmon60.Text = " "
        Me.txtdultpag.Text = " "
        Me.txtaldia.Text = " "

        Me.btnprocesar.Disabled = False
        Me.txtcCodgar.Text = ""
    End Sub

    Private Sub Imprimir()
        '-----------------------------------------'
        Dim ldfecval As Date

        ldfecval = Session("gdfecsis")
        Dim ecreditos As New ccreditos
        Dim nciclo As Integer
        nciclo = ecreditos.ciclo(Me.txtccodcli.Text.Trim, ViewState("pccodcta"))

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crConsal.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.Refresh()

        crRpt.SetParameterValue("pcnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("pdfecval", ldfecval)
        crRpt.SetParameterValue("pccodcta", ViewState("pccodcta"))
        crRpt.SetParameterValue("pccodcli", Me.txtccodcli.Text.Trim)
        crRpt.SetParameterValue("pncuota", Double.Parse(Me.txtmoncuo.Text))
        crRpt.SetParameterValue("pndias", Integer.Parse(Me.txtdias.Text))

        crRpt.SetParameterValue("pnaldia", Double.Parse(Me.txtaldia.Text))
        crRpt.SetParameterValue("pncapita", Double.Parse(Me.txtdeucap.Text))

        crRpt.SetParameterValue("pn30dias", Double.Parse(Me.txtmon30.Text))
        crRpt.SetParameterValue("pn30cap", Double.Parse(Me.txt30.Text))

        crRpt.SetParameterValue("pn60dias", Double.Parse(Me.txtmon60.Text))
        crRpt.SetParameterValue("pn60cap", Double.Parse(Me.txt60.Text))

        crRpt.SetParameterValue("pninteres", Double.Parse(Me.txtinteres.Text))
        crRpt.SetParameterValue("pnintmor", Double.Parse(Me.txtmora.Text))

        crRpt.SetParameterValue("pnseguro", Double.Parse(Me.txtnseguro.Text))
        crRpt.SetParameterValue("pncomision", Double.Parse(Me.txtcomisiones.Text))

        crRpt.SetParameterValue("pnsalcap", Double.Parse(Me.txtcapita.Text))
        crRpt.SetParameterValue("pntotal", Double.Parse(Me.txttotal.Text))
        crRpt.SetParameterValue("pnciclo", nciclo)

        Dim reportes As String
        reportes = "crConsal.pdf"

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


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'verifica boleta de deposito
        Dim ds As New DataSet
        Dim ecredkar As New cCredkar
        Dim ecntamov As New cCntamov
        Dim etabtbco As New cTabtbco
        Dim lverifica As Boolean = False
        Dim lccodcta As String = ""
        Dim NumeroReversiones As Integer = 0
        Dim gniva As Double = Session("gniva")
        Dim lcRetorno As String = ""
        Dim mclimgar As New cClimgar

        lccodcta = etabtbco.CuentaContableBanco(Me.cmbbanco.SelectedValue.Trim)


        If Double.Parse(Me.txtaldia.Text) = 0 Then
            codigoJs = "<script language='javascript'>alert('El Monto a Entregar es incorrecto , " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Valida
        If Me.txtcCodgar.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('La Garantía no fue seleccionada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If



        If Double.Parse(Me.txtaldia.Text) <= 0 Then
            'Response.Write("<script language='javascript'>alert('Monto Inválido')</script>")
            codigoJs = "<script language='javascript'>alert('Monto Inválido, " & _
                                                            "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return

        End If


        'Valida que el monto a pagar no sea mayor que el Saldo de la cuenta de Garantia Liquida
        If Double.Parse(Me.txtaldia.Text) > Double.Parse(Me.txtSaldoGar.Text) Then
            codigoJs = "<script language='javascript'>alert('El Monto a Entregar, no puede ser mayor que el Saldo de la Cuenta Garantía Liquida, " & _
                                                            "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If



        Dim eclimide As New cClimide
        Dim entidadclimide As New climide
        Dim lccodofi As String = ""

        Dim oki As String = ""
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim etabttab As New cTabttab
        Dim lcconcepto As String
        Dim lcdescri As String
        lcdescri = "GARANTIA LIQUIDA"
        lcconcepto = "RETIRO DE " + lcdescri.Trim + " DEL DIA " + Date.Parse(Me.TextBox2.Text.Trim).ToString.Replace("12:00:00 a.m.", "") + " / " + txtBanco.Text

        Dim Datos_Cert() As String = {Session("GDFECSIS"), Session("gccodofi"), _
                            lcconcepto, "AR", Session("GDFECSIS"), _
                            Session("gcCodusu"), "", "", "", Double.Parse(Me.txtaldia.Text), _
                            "", 0, "01", "", Session("gccodofi"), "", "", "", 0, _
                            Double.Parse(Me.txtaldia.Text), "", "", Session("gccontra"), _
                            Me.txtccodcli.Text.Trim, lccodcta, Me.txtnomcli.Text.Trim}

        '/****** Fernando Abrego Object: txtcCodgar cambio a Me.txtcNrogar.Text.Trim  Script Date: 06/11/2015 17:22:01 ******/

        lcRetorno = mclimgar.Entrega_Garantia_Liquida(Datos_Cert, Me.txtccodcli.Text.Trim, Double.Parse(Me.txtaldia.Text), _
                                                          Me.ddlingreso.SelectedValue.Trim, Date.Parse(Me.TextBox2.Text), _
                                                          Session("gccodusu"), Me.txtnomcli.Text.Trim, Me.txtccodcliente.Text.Trim, _
                                                          Me.txtcNrogar.Text.Trim, "A")


        If lcRetorno = "0" Then
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        ElseIf lcRetorno = "2" Then
            codigoJs = "<script language='javascript'>alert('No se ha creado la cuenta de Garantia Liquida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If

        limpieza()
        Desactiva()
        '        Response.Write("<script language='javascript'>alert('Cobro Aplicado')</script>")
        codigoJs = "<script language='javascript'>alert('La Garantía fue Descargada Correctamente, " & _
                    "Aviso SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
    End Sub
    Private Sub Imprime()
        Dim ds As New DataSet
        Dim ldfecpro As Date
        Dim lccodcli As String = ViewState("pccodcta")
        Dim ecntamov As New cCntamov
        Dim lcnomcli As String = ""
        Dim lcnomofi As String = ""
        Dim etabtofi As New cTabtofi
        Dim lcoficina As String = ""
        Dim lcconcepto As String = ""
        Dim objClimide As New cClimide
        Dim lccnomgru As String = ""
        Dim lccnomusu As String = ""
        Dim objusuario As New cTabtusu

        ds = ecntamov.ObtieneOtrosIngresos(lccodcli, Me.TextBox1.Text.Trim)
        lccnomgru = objClimide.ObtenerDatosGrupo(lccodcli)
        lccnomusu = objusuario.usuario(Session("gcCodusu"))


        If ds.Tables(0).Rows.Count = 0 Then
            'Response.Write("<script language='javascript'>alert('No existen Datos')</script>")
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                                            "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        Dim lncaja As Double = 0
        lncaja = ds.Tables(0).Rows(0)("ndebe")
        lcoficina = ds.Tables(0).Rows(0)("cCodofi")
        lcconcepto = ds.Tables(0).Rows(0)("cconcepto")

        ldfecpro = Date.Parse(Me.TextBox2.Text)
        lcnomcli = txtnomcli.Text.Trim

        Dim lnDecimal As Double
        Dim pccantlet1 As String

        pccantlet1 = ConversionLetras.ConversionEnteros(lncaja)
        lnDecimal = clsConvert.ExtraeDecimales(lncaja)
        pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " PESOS"

        lcnomofi = etabtofi.NombreAgencia(lcoficina)
        '-----------------------------------------'
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\cEntregaGar.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        crRpt.SetParameterValue("pdfecpro", ldfecpro)
        crRpt.SetParameterValue("ncaja", lncaja)
        crRpt.SetParameterValue("cnomcli", lcnomcli)
        crRpt.SetParameterValue("pccantlet", pccantlet1)
        crRpt.SetParameterValue("ccodcli", lccodcli)
        crRpt.SetParameterValue("cnomofi", lcnomofi)
        crRpt.SetParameterValue("cconcepto", lcconcepto)
        crRpt.SetParameterValue("cnomgru", lccnomgru)
        crRpt.SetParameterValue("cnomusu", lccnomusu)

        Dim reportes As String

        reportes = "crpagos.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

    End Sub
    'Protected Sub check1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check1.CheckedChanged
    '    If check1.Checked = True Then
    '        Me.TextBox3.Text = "Pago de Referencias Crediticias"
    '    End If
    'End Sub
    'Protected Sub check2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check2.CheckedChanged
    '    If check2.Checked = True Then
    '        Me.TextBox3.Text = "Pago de Comisiones Crediticias"
    '    End If
    'End Sub
    'Protected Sub check4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check4.CheckedChanged
    '    If check4.Checked = True Then
    '        Me.TextBox3.Text = "Pago de Legalizacion y Otros por concepto de Crediticias"
    '    End If
    'End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Imprime()
    End Sub

    Protected Sub Grid_Garantia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Garantia.SelectedIndexChanged

        Me.txtcNrogar.Text = Grid_Garantia.SelectedRow.Cells(1).Text.ToString   'Nro Garantía
        Me.txtcCodgar.Text = Grid_Garantia.SelectedRow.Cells(2).Text.ToString   'Tipo de Garantía
        '-- =============================================
        '-- Author:         <FERNANDO ABREGO>
        '-- Create date: <SABDO 25/04/2015>
        '-- Description:  <USE REPLACE PARA QUITAR LA COMA DE LOS MILES POR QUE UNA VALIDACION NO LA POERMITIA>
        '-- Eventos:        <.....>
        '-- Fuciones:      <>
        '-- Procesos:      <.....>
        '-- =============================================
        Me.txtaldia.Text = Grid_Garantia.SelectedRow.Cells(6).Text.ToString.Replace(",", "")     'Monto de la Garantía
        'Me.txtaldia.Text = Me.txtaldia.Text

    End Sub

    Protected Sub txtaldia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaldia.TextChanged

    End Sub
End Class
