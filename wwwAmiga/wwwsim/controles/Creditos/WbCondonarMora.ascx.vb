Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Data.SqlClient


Partial Class controles_Creditos_WbCondonarMora
    Inherits ucWBase


#Region "Privadas"
    Private codigoJs As String
    Private cls1 As New SIM.BL.pagdesver
    Private clsppal As New SIM.BL.class1
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            cargarcombos()
        End If
    End Sub
    Private Sub cargarcombos()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnNivel"), Session("gcCodOfi"))

        'carga instituciones
        Me.ddlcodins.DataTextField = "cdescri"
        Me.ddlcodins.DataValueField = "ccodigo"
        Me.ddlcodins.DataSource = mlistainstitu
        Me.ddlcodins.DataBind()
        'carga oficinas
        Me.ddlcodofi.DataTextField = "cnomofi"
        Me.ddlcodofi.DataValueField = "ccodofi"
        Me.ddlcodofi.DataSource = mlistaoficina
        Me.ddlcodofi.DataBind()
        '   Me.calfecval.SelectedDate = Session("gdfecsis")

        Me.btnprocesar.Disabled = False

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        ViewState.Add("pccodcta", codigoCliente)
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        entidadcremcre.ccodcta = codigoCliente
        ecremcre.ObtenerCremcre(entidadcremcre)
        Dim lcoficina As String
        lcoficina = entidadcremcre.coficina
        ddlcodofi.SelectedValue = lcoficina

        Me.aplicar()
    End Sub

    Sub aplicar()
        'cremcre
        Dim entidad1 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad1.ccodcta = ViewState("pccodcta")
        ecreditos.Obtenercreditos(entidad1)
        Me.txtnomcli.Text = entidad1.cnomcli
        Me.txtccodcli.Text = entidad1.ccodcli

        Procesar()
    End Sub



    Private Sub Button5_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Procesar()
        Dim ecreditos As New ccreditos
        Dim lnsaldo As Double = 0
        Dim lccodcta As String
        Dim ldfecval As Date
        Dim lntotal As Double
        Dim lndeuda As Double
        Dim ok As Integer
        Dim lccodins As String
        Dim lccodofi As String
        Dim clsaplica As New SIM.BL.payment

        Dim ldfec30 As Date
        Dim lncapdeu30, lntotal30 As Double
        Dim ldfec60 As Date
        Dim lncapdeu60, lntotal60 As Double

        Try
            lccodins = Me.ddlcodins.SelectedItem.Value.Trim
            lccodofi = Me.ddlcodofi.SelectedItem.Value.Trim
            lccodcta = ViewState("pccodcta")
            If Me.txtcnrocta.Text.Trim = Nothing Then
                Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
                Return
            End If
            ldfecval = Session("gdfecsis")
            clsaplica.pccodcta = lccodcta
            clsaplica.pdfecval = ldfecval
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            Dim clsppal As New class1
            Dim lncuota As Double
            clsppal.gnperbas = Session("gnperbas")
            clsppal.pnComtra = Session("gnComTra")
            clsppal.pnSegVm = Session("gnSegVm")

            lncuota = clsppal.ValorCuota(lccodcta)
            Me.txtmoncuo.Text = lncuota

            ok = clsaplica.omcalcinterest("T", ldfecval)
            If ok = 9 Then
                Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                Exit Try
            End If
            If ok = 1 Then
                Me.txtinteres.Text = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                Me.txtmora.Text = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
                Me.txtcapita.Text = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                Me.txtdultpag.Text = clsaplica.pdultpag
                Me.txtdias.Text = utilNumeros.Redondear(clsaplica.pndiaatr, 0).ToString
                '                Me.txtmoncuo.Text = utilNumeros.Redondear(clsaplica.pnmoncuo, 2).ToString
                Me.txtdeucap.Text = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString
                'Calcula comisiones y seguro
                'Calculo de la comision por tramite ----------------->>>>
                Dim ecretlin As New cretlin
                Dim mcretlin As New cCretlin
                Dim lcnrolin As String


                Dim lncomision, lncapdes, lnsegdeu, lngasadm, lntotcom As Double
                Dim ldfecvig As Date
                Dim lccodlin As String
                Dim lndias As Integer
                Dim lsegdeu As Boolean

                lncapdes = clsaplica.pncapdes
                ldfecvig = clsaplica.pdfecvig

                lcnrolin = clsaplica.cnrolin
                ecretlin.cnrolin = lcnrolin
                mcretlin.ObtenerCretlin(ecretlin)
                lsegdeu = ecretlin.lsegdeu
                lccodlin = ecretlin.ccodlin

                Dim ecredkar As New cCredkar
                Dim ldultfecha As Date
                ldultfecha = ecredkar.UltimafechaProceso(lccodcta.Trim, ldfecval)
                lndias = ldfecval.ToOADate - ldultfecha.ToOADate

                'If lccodlin.Substring(8, 2) = "06" Then
                '    lncomision = 0
                'Else
                '    If ldfecvig > #11/1/2005# Then
                '        lncomision = utilNumeros.Redondear((lncapdes * (Session("gncomtra") / 100) * lndias) / Session("gnperbas"), 2)
                '    Else
                lncomision = 0
                'End If

                '    End If
                'If lsegdeu = True Then
                '    lnsegdeu = (lncapdes * Session("gnSegVm") / 31) * lndias
                'Else
                lnsegdeu = 0
                'End If
                lnsegdeu = utilNumeros.Redondear(lnsegdeu, 2)

                lntotcom = lncomision + lnsegdeu
                Me.txtnseguro.Text = lnsegdeu
                Me.txtcomisiones.Text = lncomision
                '--------------------------------------------------------->>>>

                lntotal = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                Me.txttotal.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                Me.txttotal.Text = lntotal
                Dim lntotalaldia As Double
                lntotalaldia = utilNumeros.Redondear(Double.Parse(Me.txtmora.Text), 2).ToString
                Me.txtaldia.Text = lntotalaldia

                'Procede a Calculo de 1-30 dias
                Dim lnsalteo30 As Double = 0
                ldfec30 = ldfecval.AddDays(-30)
                'clsaplica.pdfecval = ldfec30
                'clsaplica.pcestado = "F"


                lnsalteo30 = ecreditos.DeudaProyectada(lccodcta, ldfec30)
                lncapdeu30 = IIf((lnsaldo - lnsalteo30) < 0, 0, (lnsaldo - lnsalteo30))

                '                ok = clsaplica.omcalcinterest
                '               If ok = 1 Then
                'lncapdeu30 = utilNumeros.Redondear(clsaplica.pndeucap, 2)

                lntotal30 = Math.Round(Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                Me.txt30.Text = lncapdeu30
                Me.txtmon30.Text = lntotal30 + lncapdeu30
                '          End If

                'Procede a Calculo de 31-60 dias
                Dim lnsalteo60 As Double = 0
                ldfec60 = ldfecval.AddDays(-60)
                'clsaplica.pdfecval = ldfec60
                lnsalteo60 = ecreditos.DeudaProyectada(lccodcta, ldfec60)
                lncapdeu60 = IIf((lnsaldo - lnsalteo60) < 0, 0, (lnsaldo - lnsalteo60))

                'ok = clsaplica.omcalcinterest
                'If ok = 1 Then
                '   lncapdeu60 = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                lntotal60 = Math.Round(Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                Me.txt60.Text = lncapdeu60
                Me.txtmon60.Text = lntotal60 + lncapdeu60
                'End If

            Else
                Response.Write("<script language='javascript'>alert('Cuenta no tiene movimientos')</script>")
            End If
        Catch
            Response.Write("<script language='javascript'>alert('Problemas con cadena de conexión')</script>")
        End Try



    End Sub
    Private Sub btnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocesar.ServerClick
        Procesar()
    End Sub

    Private Sub Cancela()
        Me.txtcapita.Text = " "
        Me.txtinteres.Text = " "
        Me.txtmora.Text = " "
        Me.txttotal.Text = " "
        Me.txtcnrocta.Text = " "
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
        Dim lntotgen As Double = 0
        lntotgen = Double.Parse(txtmora.Text)
        If lntotgen <= 0 Then
            Exit Sub
        End If
        cls1.pccodcta = ViewState("pccodcta")
        cls1.pncapita = 0
        cls1.pnsalint = Double.Parse(txtinteres.Text)
        cls1.pnsalmor = Double.Parse(txtmora.Text)
        cls1.pncomision = 0
        cls1.pnhonorarios = 0
        cls1.pngestion = 0
        cls1.pnmonpag = lntotgen
        cls1.pdfecval = Session("gdfecsis")
        cls1.pndeucap = Double.Parse(Me.txtdeucap.Text)
        cls1.pcbanco = ""
        cls1.pctippag = "I"
        cls1.pcnuming = "COND"
        cls1.pcnuming0 = ""

        cls1.gdfecsis = Session("gdfecsis")
        cls1.gccodusu = Session("gccodusu")
        cls1.ahosim = 0
        cls1.ahovis = 0
        cls1.aporta = 0
        cls1.segdeu = 0
        cls1.manejo = 0

        cls1.pnintpag = 0
        cls1.pnintpen = 0
        cls1.pnintcal = 0
        cls1.pnmorpag = 0
        cls1.pnpagcta = 0
        cls1.pnintmor = 0
        cls1.pdultpag = Date.Parse(Me.txtdultpag.Text)
        cls1.pncappag = 0
        cls1.pccodcli = Me.txtccodcli.Text
        cls1.pndiaatr = Me.txtdias.Text
        cls1.gniva = Session("gniva")

        cls1.lsolidario = False
        cls1.pcCodctaAho = ""

        Dim error100 As Integer
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select As String = ""
        con.ConnectionString = stringconnection

        con.Open()


        str_select = "SET LANGUAGE spanish; begin tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)

        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK')</script>")
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK, " & _
                             "Advertencia SIM.NET ')</script>"


            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If


        'cls1.mxdistribute()
        error100 = cls1.mxdistribute_Transac(con)


        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK')</script>")
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        str_select = "commit tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)

        If error100 = -100 Then
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            'Response.Write("<script language='javascript'>alert('Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK')</script>")
            codigoJs = "<script language='javascript'>alert(''Ocurrio un Error, Pago No Aplicado, se Aplicara un ROLLBACK " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        con.Close()

        Cancela()
        Me.Button1.Enabled = False
        'Procesar()
        'Response.Write("<script language='javascript'>alert('Condonación Aplicada')</script>")
        'codigoJs = "<script language='javascript'>alert('Condonación Aplicada, Aviso SIM.NET ')</script>"
        'ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
    End Sub
End Class
