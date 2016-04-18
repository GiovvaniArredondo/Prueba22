Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Data.SqlClient

Partial Class ucctaaho
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            CargarCombos()
            ddloficina.SelectedValue = Session("gccodofi")

        End If
    End Sub
    Public Sub CargarPorcliente(ByVal ccodcli As String)
        Me.txtcodcli.Text = ccodcli
        Me.btnaplicar_Click(Me, New System.EventArgs)
        btngraba.Enabled = True
        btncontrato.Enabled = False
        btnfirmas.Enabled = False
        'foto_firma(ccodcli)
    End Sub

    Public Sub CargarCombos()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim clstabtofi As New SIM.BL.cTabtofi
        Dim clslineas As New cAhotlin

        Dim mListaTabttab As New listatabttab
        Dim mlistalineas As New listaahotlin
        Dim mlistaoficina As New listatabtofi

        mListaTabttab = clstabttab.ObtenerLista("143", "1")
        mlistaoficina = clstabtofi.ObtenerLista()
        mlistalineas = clslineas.ObtenerLista()

        Me.ddltipaho.DataTextField = "cdescri"
        Me.ddltipaho.DataValueField = "ccodigo"
        Me.ddltipaho.DataSource = mListaTabttab
        Me.ddltipaho.DataBind()

        'carga lineas de ahorros

        Me.ddllineas.DataTextField = "cdeslin"
        Me.ddllineas.DataValueField = "cnrolin"
        Me.ddllineas.DataSource = mlistalineas
        Me.ddllineas.DataBind()
        'carga oficinas
        Me.ddloficina.DataTextField = "cnomofi"
        Me.ddloficina.DataValueField = "ccodofi"
        Me.ddloficina.DataSource = mlistaoficina
        Me.ddloficina.DataBind()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub ddltipaho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


  
    Protected Sub btnaplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        Dim eclimide As New climide
        Dim mclimide As New cClimide
        Dim lccodcli As String
        Dim lccodofi As String

        lccodcli = Me.txtcodcli.Text.Trim
        eclimide.ccodcli = Me.txtcodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        Me.txtnomcli.Text = eclimide.cnomcli
        Me.txtfecha.Text = Session("gdfecsis")
        lccodofi = eclimide.ccodofi
        Dim lcnomofi As String = ""

        Dim etabtofi As New cTabtofi

        lcnomofi = etabtofi.NombreAgencia(lccodofi)
        Label16.Text = "Socio(a) Esta Registrado en: " + lcnomofi


        'Obtiene el numero sugerido de libreta
        Dim eahomlib As New cAhomlib
        Dim lnlibreta As Integer
        lnlibreta = eahomlib.ObtenerCorrelativoSugerido()

        Me.txtlibreta.Text = lnlibreta
        Me.txtcodaho.Visible = False
    End Sub

    Protected Sub btngraba_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngraba.Click
        Dim lccodcli As String
        Dim lccodaho As String
        Dim lctipo As String
        Dim lccodofi As String
        Dim linea1 As String
        Dim ldfecha As Date
        Dim eahomlib As New cAhomlib
        Dim entidadahomlib As New ahomlib

        If Me.txtcodaho.Text.Trim = Nothing Then
            'Verifica si existe numero de libreta
            'Dim lverifica As Boolean = False
            'lverifica = eahomlib.VerificaLibreta(Integer.Parse(txtlibreta.Text))

            'If lverifica = True Then
            '    Response.Write("<script language='javascript'>alert('Nº de Libreta Existe ')</script>")
            '    Exit Sub
            'End If

            lccodofi = Session("gccodofi")
            ldfecha = Session("gdfecsis")
            Dim eahomcta As New ahomcta
            Dim mahomcta As New cAhomcta
            lctipo = Me.ddltipaho.SelectedValue.Trim
            lccodaho = mahomcta.ObtenerID_tipo(lctipo, lccodofi).ToString
            Me.txtcodaho.Text = lccodaho
            Me.txtcodaho.Visible = True
            Try
                linea1 = Me.ddllineas.SelectedValue.Trim
                eahomcta.ccodaho = lccodaho
                eahomcta.ccodcli = Me.txtcodcli.Text.Trim
                eahomcta.ccodcta = ""
                eahomcta.ccodusu = Session("gccodusu")
                eahomcta.cestado = "A"
                eahomcta.cnrolin = linea1
                eahomcta.cnudotr = Me.txtcodcli.Text.Trim
                eahomcta.dfecapr = ldfecha
                eahomcta.dfeccap = ldfecha
                eahomcta.producto = lctipo
                eahomcta.nsaldoaho = 0
                eahomcta.nsaldnind = 0
                'No guardaba el número de libreta de ahorros -- Alex 30/11/2011
                'Agregue el if para verificar si el número de libreta esta vacía -- Alex 13/01/2012
                If txtlibreta.Text.Length <> 0 Then
                    eahomcta.nlibreta = Integer.Parse(txtlibreta.Text)
                Else
                    eahomcta.nlibreta = 0
                End If

                eahomcta.nmonapr = 0
                eahomcta.nmonini = 0
                eahomcta.nmonres = 0
                eahomcta.nombre = Me.txtnomcli.Text.Trim
                eahomcta.nmonini = 0
                eahomcta.dfecfin = ldfecha
                eahomcta.dfechault = ldfecha
                eahomcta.dfecmod = ldfecha
                eahomcta.dfecult = ldfecha
                eahomcta.dultmov = ldfecha
                eahomcta.dfecini = ldfecha
                eahomcta.cbloqueo = ""
                Try

                    mahomcta.agregar(eahomcta)
                    entidadahomlib.ccodaho = lccodaho
                    entidadahomlib.nlibreta = eahomcta.nlibreta
                    entidadahomlib.cestado = "A"
                    entidadahomlib.dfeccan = Session("gdfecsis")
                    'Enviaba valor a nulo a crazon y es obligatorio el campo -- Alex 30/11/2011
                    entidadahomlib.crazon = "1"
                    entidadahomlib.dfecapr = Session("gdfecsis")
                    entidadahomlib.dfecmod = Now
                    'No guardaba el código del usuario - Alex 30/11/2011
                    entidadahomlib.ccodusu = Session("gccodusu")


                    eahomlib.Agregar(entidadahomlib)

                    btngraba.Enabled = False
                    btncontrato.Enabled = False
                    btnfirmas.Enabled = False

                Catch ex As Exception

                End Try


                Response.Write("<script language='javascript'>alert('ok')</script>")

                Session("codigo") = lccodaho
                Session("fuente") = Me.txtcodcli.Text.Trim
                Response.Write("<script>window.open('wffirmas.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=550')</script>")


            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('Error de lectura de datos')</script>")

            End Try
        End If

    End Sub
    Protected Sub foto_firma(ByVal asociado As String)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, 1)
        If huella1 <> "basura" Then
            foto_Image.Height = 75
            foto_Image.Width = 100
            foto_Image.ImageUrl = huella1
            ' foto_Image.Visible = True
        End If

    End Sub

    Protected Sub btnfirmas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfirmas.Click
        Response.Write("<script>window.open('wffirmas.aspx','cal', 'location=1, toolbar = no, status=1,width=700,height=550')</script>")
    End Sub

    Protected Sub btncontrato_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncontrato.Click
        If RadioButton11.Checked = True Then
            Contratoalavista1(Me.txtcodaho.Text.Trim)
        Else
            contratoalavista2()
        End If
    End Sub
    Private Sub Contratoalavista1(ByVal ccodaho As String)
        Dim clsppal As New class1
        Dim eahomcta As New cAhomcta
        Dim lctipoahorro As String
        Dim etabttab As New cTabttab

        lctipoahorro = etabttab.Describe(Mid(txtcodaho.Text.Trim, 7, 2), "143")
        Dim ds As New DataSet
        Dim lntasint As Double = 0
        ds = eahomcta.ObtieneCuentaAhorro(ccodaho)
        If ds.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('Cuenta de Ahorro a la Vista NO Creada')</script>")
            Exit Sub
        Else
            lntasint = ds.Tables(0).Rows(0)("ntasint")
        End If
        Dim lnentero As Integer = 0
        Dim lndeci As Integer = 0
        Dim lcentero As String = ""
        Dim lcdeci As String = ""
        Dim lctasa As String = ""

        lnentero = Decimal.Floor(lntasint)
        lndeci = Math.Round((lntasint - lnentero) * 100)

        lcentero = clsppal.Num2Text(lnentero)

        If lndeci > 0 Then
            lcdeci = clsppal.Num2Text(lndeci)
            lctasa = lcentero.Trim + " PUNTO " + lcdeci.Trim
        Else
            lctasa = lcentero.Trim
        End If

        Dim eclimide As New cClimide
        Dim entidadclimide As New climide

        entidadclimide.ccodcli = txtcodcli.Text.Trim
        eclimide.ObtenerClimide(entidadclimide)



        Dim lcmunidom As String
        Dim entidadtabtzon As New tabtzon
        Dim etabtzon As New cTabtzon


        entidadtabtzon.ctipzon = "2"
        entidadtabtzon.ccodzon = Left(entidadclimide.ccoddom.Trim, 2)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcmunidom = entidadtabtzon.cdeszon.Trim

        Dim lnedad As Integer
        Dim lcedad As String = ""

        lnedad = clsppal.CalculaEdad(entidadclimide.dnacimi)

        lcedad = clsppal.Num2Text(lnedad)


        'convierte edad en letras

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String = "crContrato.pdf"
        crRpt.Load(Server.MapPath("reportes") + "\crContrato.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt.Refresh()

        crRpt.SetParameterValue("cnomins", (Trim(Session("gcnomins")) + " -AFILIADA A FEDECACES DE R.L."))

        crRpt.SetParameterValue("cnombre", (entidadclimide.cnombres.Trim + " " + entidadclimide.capellidos.Trim))
        crRpt.SetParameterValue("cmunidom", lcmunidom)
        crRpt.SetParameterValue("cedad", lcedad)
        crRpt.SetParameterValue("cdui", entidadclimide.cnudoci)
        crRpt.SetParameterValue("cfecing", Session("gdfecsis").ToString)
        crRpt.SetParameterValue("ctasa", lctasa)
        crRpt.SetParameterValue("ctasaint", lntasint.ToString)
        crRpt.SetParameterValue("ctipoahorro", lctipoahorro.Trim)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()

    End Sub

    Private Sub contratoalavista2()
        Dim eparent As New cParent
        Dim entidadparent As New parent
        Dim lcparent, lcparent1, lcparent2, lcparent3, lcparent4 As String

        Dim eahomben As New cAHOMBEN
        Dim entidadahomben As New AHOMBEN
        Dim i As Integer = 0
        Dim lcnom1 As String = "", lcnom2 As String = "", lcnom3 As String = "", lcnom4 As String = "", lcnom5 As String = ""

        Dim lcfec1 As String = "", lcfec2 As String = "", lcfec3 As String = "", lcfec4 As String = "", lcfec5 As String = ""
        Dim lnpor1 As Decimal = 0, lnpor2 As Decimal = 0, lnpor3 As Decimal = 0, lnpor4 As Decimal = 0, lnpor5 As Decimal = 0
        Dim lcdirben1 As String = "", lcdirben2 As String = "", lcdirben3 As String = "", lcdirben4 As String = "", lcdirben5 As String = ""

        entidadahomben.ccodaho = txtcodaho.Text.Trim
        entidadahomben.ncorrel = 1

        i = eahomben.ObtenerAHOMBEN(entidadahomben)
        If i = 0 Then
            lcparent = ""

        Else
            entidadparent.cparent = entidadahomben.cparent.Trim
            lcnom1 = entidadahomben.cnomben.Trim
            lcfec1 = entidadahomben.dfecnac.ToString
            lnpor1 = entidadahomben.nporcen
            lcdirben1 = entidadahomben.cdirben.Trim

            eparent.ObtenerParent(entidadparent)
            lcparent = entidadparent.cdescri.Trim

        End If

        entidadahomben.ncorrel = 2
        i = eahomben.ObtenerAHOMBEN(entidadahomben)
        If i = 0 Then
            lcparent1 = ""
        Else
            entidadparent.cparent = entidadahomben.cparent.Trim
            lcnom2 = entidadahomben.cnomben.Trim
            lcfec2 = entidadahomben.dfecnac.ToString
            lnpor2 = entidadahomben.nporcen
            lcdirben2 = entidadahomben.cdirben.Trim

            eparent.ObtenerParent(entidadparent)
            lcparent1 = entidadparent.cdescri.Trim

        End If

        entidadahomben.ncorrel = 3
        i = eahomben.ObtenerAHOMBEN(entidadahomben)
        If i = 0 Then
            lcparent2 = ""
        Else
            entidadparent.cparent = entidadahomben.cparent.Trim
            lcnom3 = entidadahomben.cnomben.Trim
            lcfec3 = entidadahomben.dfecnac.ToString
            lnpor3 = entidadahomben.nporcen
            lcdirben3 = entidadahomben.cdirben.Trim

            eparent.ObtenerParent(entidadparent)
            lcparent2 = entidadparent.cdescri.Trim
        End If

        entidadahomben.ncorrel = 4
        i = eahomben.ObtenerAHOMBEN(entidadahomben)
        If i = 0 Then
            lcparent3 = ""
        Else
            entidadparent.cparent = entidadahomben.cparent.Trim
            lcnom4 = entidadahomben.cnomben.Trim
            lcfec4 = entidadahomben.dfecnac.ToString
            lnpor4 = entidadahomben.nporcen
            lcdirben4 = entidadahomben.cdirben.Trim

            eparent.ObtenerParent(entidadparent)
            lcparent3 = entidadparent.cdescri.Trim

        End If

        entidadahomben.ncorrel = 5
        i = eahomben.ObtenerAHOMBEN(entidadahomben)
        If i = 0 Then
            lcparent4 = ""
        Else
            entidadparent.cparent = entidadahomben.cparent.Trim
            lcnom5 = entidadahomben.cnomben.Trim
            lcfec5 = entidadahomben.dfecnac.ToString
            lnpor5 = entidadahomben.nporcen
            lcdirben5 = entidadahomben.cdirben.Trim

            eparent.ObtenerParent(entidadparent)
            lcparent4 = entidadparent.cdescri.Trim

        End If

        Dim eclimide As New cClimide
        Dim entidadclimide As New climide

        entidadclimide.ccodcli = txtcodcli.Text.Trim
        eclimide.ObtenerClimide(entidadclimide)


        Dim etabtzon As New cTabtzon
        Dim entidadtabtzon As New tabtzon
        Dim lcdepadom, lcdepatra, lcmunidom, lcmunitra As String
        Dim etabttab As New cTabttab
        Dim lcestciv As String
        lcestciv = etabttab.Describe(entidadclimide.cestciv.Trim, "012")

        entidadtabtzon.ctipzon = "1"

        entidadtabtzon.ccodzon = Left(entidadclimide.ccoddom.Trim, 2)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcdepadom = entidadtabtzon.cdeszon.Trim

        entidadtabtzon.ccodzon = Left(entidadclimide.czonlab.Trim, 2)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcdepatra = entidadtabtzon.cdeszon.Trim



        entidadtabtzon.ctipzon = "2"

        entidadtabtzon.ccodzon = Left(entidadclimide.ccoddom.Trim, 4)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcmunidom = entidadtabtzon.cdeszon.Trim

        entidadtabtzon.ccodzon = Left(entidadclimide.czonlab.Trim, 4)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcmunitra = entidadtabtzon.cdeszon.Trim

        Dim lnedad As Integer
        Dim lcedad As String = ""
        Dim clsppal As New class1

        lnedad = clsppal.CalculaEdad(entidadclimide.dnacimi)

        lcedad = clsppal.Num2Text(lnedad)

        Dim efirmas As New cAhomfir
        Dim entidadfirmas As New Ahomfir
        entidadfirmas.ccodaho = Me.txtcodaho.Text.Trim


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String = "crContrato.pdf"
        crRpt.Load(Server.MapPath("reportes") + "\crContrato1.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt.Refresh()

        crRpt.SetParameterValue("dfecing", Session("gdfecsis"))

        crRpt.SetParameterValue("cnombre", (entidadclimide.cnombres.Trim + " " + entidadclimide.capellidos.Trim))
        crRpt.SetParameterValue("cdireccion", (entidadclimide.cdirdom.Trim + " " + lcdepadom + ", " + lcmunidom))

        crRpt.SetParameterValue("dfecnac", entidadclimide.dnacimi)
        crRpt.SetParameterValue("cestciv", lcestciv)
        crRpt.SetParameterValue("ctelefono", entidadclimide.cteldom)
        If lcedad.Trim = "" Then
            crRpt.SetParameterValue("nedad", 0)
        Else
            crRpt.SetParameterValue("nedad", lnedad)
        End If
        crRpt.SetParameterValue("cdirectr", (entidadclimide.cdomtra.Trim + " " + lcdepatra + ", " + lcmunitra))
        crRpt.SetParameterValue("cteltr", entidadclimide.cteltralab.Trim)

        'Persona autorizadas
        crRpt.SetParameterValue("cpersona1", entidadfirmas.cnomgfir.Trim)
        crRpt.SetParameterValue("cpersona2", entidadfirmas.cnomgfir2.Trim)
        crRpt.SetParameterValue("cpersona3", entidadfirmas.cnomgfir3.Trim)

        crRpt.SetParameterValue("cpersonanac1", entidadfirmas.dnacgfir)
        crRpt.SetParameterValue("cpersonanac2", IIf(entidadfirmas.cnomgfir2.Trim = "", "", entidadfirmas.dnacgfir2))
        crRpt.SetParameterValue("cpersonanac3", IIf(entidadfirmas.cnomgfir3.Trim = "", "", entidadfirmas.dnacgfir3))

        crRpt.SetParameterValue("cpersonadui1", entidadfirmas.cdui1.Trim)
        crRpt.SetParameterValue("cpersonadui2", entidadfirmas.cdui2.Trim)
        crRpt.SetParameterValue("cpersonadui3", entidadfirmas.cdui3.Trim)

        'beneficiarios
        crRpt.SetParameterValue("nombreben1", lcnom1)
        crRpt.SetParameterValue("nombreben2", lcnom2)
        crRpt.SetParameterValue("nombreben3", lcnom3)
        crRpt.SetParameterValue("nombreben4", lcnom4)
        crRpt.SetParameterValue("nombreben5", lcnom5)

        crRpt.SetParameterValue("cparent1", IIf(lcnom1.Trim = "", "", lcparent.Trim))
        crRpt.SetParameterValue("cparent2", IIf(lcnom2.Trim = "", "", lcparent1.Trim))
        crRpt.SetParameterValue("cparent3", IIf(lcnom3.Trim = "", "", lcparent2.Trim))
        crRpt.SetParameterValue("cparent4", IIf(lcnom4.Trim = "", "", lcparent3.Trim))
        crRpt.SetParameterValue("cparent5", IIf(lcnom5.Trim = "", "", lcparent4.Trim))

        crRpt.SetParameterValue("dfecnac1", IIf(lcnom1.Trim = "", "", lcfec1.Trim))
        crRpt.SetParameterValue("dfecnac2", IIf(lcnom2.Trim = "", "", lcfec2.Trim))
        crRpt.SetParameterValue("dfecnac3", IIf(lcnom3.Trim = "", "", lcfec3.Trim))
        crRpt.SetParameterValue("dfecnac4", IIf(lcnom4.Trim = "", "", lcfec4.Trim))
        crRpt.SetParameterValue("dfecnac5", IIf(lcnom5.Trim = "", "", lcfec5.Trim))

        crRpt.SetParameterValue("nporcen1", IIf(lcnom1.Trim = "", 0, lnpor1))
        crRpt.SetParameterValue("nporcen2", IIf(lcnom2.Trim = "", 0, lnpor2))
        crRpt.SetParameterValue("nporcen3", IIf(lcnom3.Trim = "", 0, lnpor3))
        crRpt.SetParameterValue("nporcen4", IIf(lcnom4.Trim = "", 0, lnpor4))
        crRpt.SetParameterValue("nporcen5", IIf(lcnom5.Trim = "", 0, lnpor5))

        crRpt.SetParameterValue("cdomicilio1", IIf(lcnom1.Trim = "", "", lcdirben1))
        crRpt.SetParameterValue("cdomicilio2", IIf(lcnom2.Trim = "", "", lcdirben2))
        crRpt.SetParameterValue("cdomicilio3", IIf(lcnom3.Trim = "", "", lcdirben3))
        crRpt.SetParameterValue("cdomicilio4", IIf(lcnom4.Trim = "", "", lcdirben4))
        crRpt.SetParameterValue("cdomicilio5", IIf(lcnom5.Trim = "", "", lcdirben5))



        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()

    End Sub

End Class


