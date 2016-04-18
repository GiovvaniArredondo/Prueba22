Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class controles_WbContratoAho
    Inherits System.Web.UI.UserControl
    Dim clsppal As New class1

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox43.Text.Trim = "" Then
            Exit Sub
        End If
        If RadioButton11.Checked = True Then
            Contratoalavista1(TextBox43.Text.Trim)
        Else
            contratoalavista2(TextBox43.Text.Trim)
        End If
    End Sub
    Private Sub Contratoalavista1(ByVal ccodaho As String)
        Dim clsppal As New class1
        Dim eahomcta As New cAhomcta
        Dim lctipoahorro As String
        Dim etabttab As New cTabttab
        Dim lccodcli As String = ""


        lctipoahorro = etabttab.Describe(ccodaho.Substring(6, 2), "143")
        Dim ds As New DataSet
        Dim lntasint As Double = 0
        ds = eahomcta.ObtieneCuentaAhorro(ccodaho)
        If ds.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('Cuenta de Ahorro a la Vista NO Creada')</script>")
            Exit Sub

        Else
            lntasint = ds.Tables(0).Rows(0)("ntasint")
            lccodcli = ds.Tables(0).Rows(0)("cnudotr")

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

        entidadclimide.ccodcli = lccodcli
        eclimide.ObtenerClimide(entidadclimide)

        Dim lccoddom As String
        lccoddom = entidadclimide.ccoddom.Trim


        Dim lcmunidom As String
        Dim entidadtabtzon As New tabtzon
        Dim etabtzon As New cTabtzon


        entidadtabtzon.ctipzon = "2"
        entidadtabtzon.ccodzon = lccoddom.Trim.Substring(0, 4)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcmunidom = entidadtabtzon.cdeszon.Trim

        Dim ldnacimi As Date
        ldnacimi = entidadclimide.dnacimi

        Dim lnedad As Integer
        Dim lcedad As String = ""

        lnedad = clsppal.CalculaEdad(ldnacimi)
        lcedad = clsppal.Num2Text(lnedad)

        Dim lcnombres As String = entidadclimide.cnombres

        'Agregado para que muestre el nombre completo del socio en el contrato - Alex 18/01/2012
        Dim nombre_completo As String = entidadclimide.cnomcli

        Dim lcapellidos As String = entidadclimide.capellidos
        Dim lcdui As String = entidadclimide.cnudoci
        'convierte edad en letras

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String = "crContrato.pdf"
        crRpt.Load(Server.MapPath("reportes") + "\crContrato.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt.Refresh()

        crRpt.SetParameterValue("cnomins", (Trim(Session("gcnomins")) + " -AFILIADA A FEDECACES DE R.L."))

        crRpt.SetParameterValue("cnombre", nombre_completo.Trim)
        crRpt.SetParameterValue("cmunidom", lcmunidom)
        crRpt.SetParameterValue("cedad", lcedad)
        crRpt.SetParameterValue("cdui", lcdui.Trim)
        crRpt.SetParameterValue("cfecing", Left(Session("gdfecsis").ToString, 10))
        crRpt.SetParameterValue("ctasa", lctasa)
        crRpt.SetParameterValue("ctasaint", lntasint.ToString)
        crRpt.SetParameterValue("ctipoahorro", lctipoahorro.Trim)
        crRpt.SetParameterValue("ccodaho", ccodaho)
        crRpt.SetParameterValue("ccodcli", lccodcli)

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

    Private Sub contratoalavista2(ByVal ccodaho As String)
        Dim entidadahomfir As New Ahomfir
        Dim eahomfir As New cAhomfir
        Dim l As Integer = 0

        entidadahomfir.ccodaho = ccodaho
        l = eahomfir.ObtenerAhomfir(entidadahomfir)

        If l = 0 Then
            entidadahomfir.cnomgfir = ""
            entidadahomfir.cnomgfir2 = ""
            entidadahomfir.cnomgfir3 = ""
        End If

        Dim ds As New DataSet
        Dim eahomcta As New cAhomcta
        Dim lccodcli As String = ""
        ds = eahomcta.ObtieneCuentaAhorro(ccodaho)
        If ds.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('Cuenta de Ahorro a la Vista NO Creada')</script>")
            Exit Sub
        Else
            lccodcli = ds.Tables(0).Rows(0)("cnudotr")
        End If


        Dim eparent As New cParent
        Dim entidadparent As New parent
        Dim lcparent, lcparent1, lcparent2, lcparent3, lcparent4 As String
        lcparent = ""
        lcparent1 = ""
        lcparent2 = ""
        lcparent3 = ""
        lcparent4 = ""

        Dim lcnombreben1, lcnombreben2, lcnombreben3, lcnombreben4, lcnombreben5 As String
        lcnombreben1 = ""
        lcnombreben2 = ""
        lcnombreben3 = ""
        lcnombreben4 = ""
        lcnombreben5 = ""


        Dim lcfecnac1, lcfecnac2, lcfecnac3, lcfecnac4, lcfecnac5 As String
        lcfecnac1 = ""
        lcfecnac2 = ""
        lcfecnac3 = ""
        lcfecnac4 = ""
        lcfecnac5 = ""

        Dim lnporcen1, lnporcen2, lnporcen3, lnporcen4, lnporcen5 As Double
        lnporcen1 = 0
        lnporcen2 = 0
        lnporcen3 = 0
        lnporcen4 = 0
        lnporcen5 = 0

        Dim lcdirben1, lcdirben2, lcdirben3, lcdirben4, lcdirben5 As String
        lcdirben1 = ""
        lcdirben2 = ""
        lcdirben3 = ""
        lcdirben4 = ""
        lcdirben5 = ""

        'Obtener beneficiarios de AHOMBEN
        Dim dsb As New DataSet
        Dim eahomben As New cAHOMBEN
        dsb = eahomben.ObtenerBeneficiarios(ccodaho)

        Dim lnbene As Integer = dsb.Tables(0).Rows.Count

        Dim fila As DataRow
        Dim i As Integer = 0

        Dim lcparentesco As String = "01"
        Dim lcparentesco1 As String = "01"
        Dim lcparentesco2 As String = "01"
        Dim lcparentesco3 As String = "01"
        Dim lcparentesco4 As String = "01"

        For Each fila In dsb.Tables(0).Rows
            If i = 0 Then
                lcparentesco = dsb.Tables(0).Rows(i)("cparent")
                entidadparent.cparent = lcparentesco.Trim
                eparent.ObtenerParent(entidadparent)
                lcparent = entidadparent.cdescri.Trim
                lcnombreben1 = dsb.Tables(0).Rows(i)("cnomben")
                lcfecnac1 = Left(dsb.Tables(0).Rows(i)("dfecnac").ToString, 10)
                lnporcen1 = dsb.Tables(0).Rows(i)("nporcen")
                lcdirben1 = dsb.Tables(0).Rows(i)("cdirben")

            ElseIf i = 1 Then
                lcparentesco1 = dsb.Tables(0).Rows(i)("cparent")
                entidadparent.cparent = lcparentesco1.Trim
                eparent.ObtenerParent(entidadparent)
                lcparent1 = entidadparent.cdescri.Trim
                lcnombreben2 = dsb.Tables(0).Rows(i)("cnomben")
                lcfecnac2 = Left(dsb.Tables(0).Rows(i)("dfecnac").ToString, 10)
                lnporcen2 = dsb.Tables(0).Rows(i)("nporcen")
                lcdirben2 = dsb.Tables(0).Rows(i)("cdirben")

            ElseIf i = 2 Then
                lcparentesco2 = dsb.Tables(0).Rows(i)("cparent")
                entidadparent.cparent = lcparentesco2.Trim
                eparent.ObtenerParent(entidadparent)
                lcparent2 = entidadparent.cdescri.Trim
                lcnombreben3 = dsb.Tables(0).Rows(i)("cnomben")
                lcfecnac3 = Left(dsb.Tables(0).Rows(i)("dfecnac").ToString, 10)
                lnporcen3 = dsb.Tables(0).Rows(i)("nporcen")
                lcdirben3 = dsb.Tables(0).Rows(i)("cdirben")

            ElseIf i = 3 Then
                lcparentesco3 = dsb.Tables(0).Rows(i)("cparent")
                entidadparent.cparent = lcparentesco3.Trim
                eparent.ObtenerParent(entidadparent)
                lcparent3 = entidadparent.cdescri.Trim
                lcnombreben4 = dsb.Tables(0).Rows(i)("cnomben")
                lcfecnac4 = Left(dsb.Tables(0).Rows(i)("dfecnac").ToString, 10)
                lnporcen4 = dsb.Tables(0).Rows(i)("nporcen")
                lcdirben4 = dsb.Tables(0).Rows(i)("cdirben")

            ElseIf i = 4 Then
                lcparentesco4 = dsb.Tables(0).Rows(i)("cparent")
                entidadparent.cparent = lcparentesco4.Trim
                eparent.ObtenerParent(entidadparent)
                lcparent4 = entidadparent.cdescri.Trim
                lcnombreben5 = dsb.Tables(0).Rows(i)("cnomben")
                lcfecnac5 = Left(dsb.Tables(0).Rows(i)("dfecnac").ToString, 10)
                lnporcen5 = dsb.Tables(0).Rows(i)("nporcen")
                lcdirben5 = dsb.Tables(0).Rows(i)("cdirben")

            End If
            i += 1
        Next


        Dim entidadclimide As New climide
        Dim eclimide As New cClimide
        entidadclimide.ccodcli = lccodcli

        eclimide.ObtenerClimide(entidadclimide)

        Dim lccoddom As String = entidadclimide.ccoddom


        Dim lczonlab As String = entidadclimide.czonlab
        Dim lcnombres As String = entidadclimide.cnombres

        'Agregado para que muestre el nombre completo del socio en el contrato - Alex 18/01/2012
        Dim nombre_completo As String = entidadclimide.cnomcli

        Dim lcapellidos As String = entidadclimide.capellidos
        Dim lcdirdom As String = entidadclimide.cdirdom

        Dim etabtzon As New cTabtzon
        Dim entidadtabtzon As New tabtzon
        Dim lcdepadom, lcdepatra, lcmunidom, lcmunitra As String
        Dim etabttab As New cTabttab
        Dim lcestciv As String
        lcestciv = etabttab.Describe(entidadclimide.cestciv, "012")

        entidadtabtzon.ctipzon = "1"

        entidadtabtzon.ccodzon = lccoddom.Trim.Substring(0, 2)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcdepadom = entidadtabtzon.cdeszon.Trim

        entidadtabtzon.ccodzon = lczonlab.Trim.Substring(0, 2)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcdepatra = entidadtabtzon.cdeszon.Trim


        entidadtabtzon.ctipzon = "2"

        entidadtabtzon.ccodzon = lccoddom.Trim.Substring(0, 4)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcmunidom = entidadtabtzon.cdeszon.Trim

        entidadtabtzon.ccodzon = lczonlab.Trim.Substring(0, 4)
        etabtzon.ObtenerTabtzon(entidadtabtzon)
        lcmunitra = entidadtabtzon.cdeszon.Trim

        Dim ldnacimi As Date = entidadclimide.dnacimi
        Dim lcteldom As String = entidadclimide.cteldom
        Dim lnedad As Integer = 0
        lnedad = clsppal.CalculaEdad(ldnacimi)

        Dim lcdirectr As String = entidadclimide.cdomtra
        Dim lcteltr As String = entidadclimide.cteltralab

        Dim lcpersona1 As String = entidadahomfir.cnomgfir
        Dim lcpersona2 As String = entidadahomfir.cnomgfir2
        Dim lcpersona3 As String = entidadahomfir.cnomgfir3

        Dim lcpersonanac1 As String = ""
        Dim lcpersonanac2 As String = ""
        Dim lcpersonanac3 As String = ""

        Dim lcpersonadui1 As String = ""
        Dim lcpersonadui2 As String = ""
        Dim lcpersonadui3 As String = ""


        If lcpersona1.Trim = "" Then
        Else
            lcpersonanac1 = entidadahomfir.dnacgfir
            lcpersonadui1 = entidadahomfir.cdui1
        End If

        If lcpersona2.Trim = "" Then
        Else
            lcpersonanac2 = entidadahomfir.dnacgfir2
            lcpersonadui2 = entidadahomfir.cdui2
        End If

        If lcpersona3.Trim = "" Then
        Else
            lcpersonanac3 = entidadahomfir.dnacgfir3
            lcpersonadui3 = entidadahomfir.cdui3
        End If


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String = "crContrato.pdf"
        crRpt.Load(Server.MapPath("reportes") + "\crContrato1.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt.Refresh()

        crRpt.SetParameterValue("dfecing", Session("gdfecsis"))

        crRpt.SetParameterValue("cnombre", (nombre_completo.Trim))
        crRpt.SetParameterValue("cdireccion", (lcdirdom.Trim + " " + lcdepadom + ", " + lcmunidom))

        crRpt.SetParameterValue("dfecnac", ldnacimi)
        crRpt.SetParameterValue("cestciv", lcestciv)
        crRpt.SetParameterValue("ctelefono", lcteldom.Trim)
        crRpt.SetParameterValue("nedad", lnedad)

        crRpt.SetParameterValue("cdirectr", (lcdirectr.Trim + " " + lcdepatra + ", " + lcmunitra))
        crRpt.SetParameterValue("cteltr", lcteltr.Trim)

        'Persona autorizadas
        crRpt.SetParameterValue("cpersona1", lcpersona1.Trim)
        crRpt.SetParameterValue("cpersona2", lcpersona2.Trim)
        crRpt.SetParameterValue("cpersona3", lcpersona3.Trim)

        crRpt.SetParameterValue("cpersonanac1", lcpersonanac1)
        crRpt.SetParameterValue("cpersonanac2", lcpersonanac2)
        crRpt.SetParameterValue("cpersonanac3", lcpersonanac3)

        crRpt.SetParameterValue("cpersonadui1", lcpersonadui1)
        crRpt.SetParameterValue("cpersonadui2", lcpersonadui2)
        crRpt.SetParameterValue("cpersonadui3", lcpersonadui3)

        'beneficiarios
        crRpt.SetParameterValue("nombreben1", lcnombreben1.Trim)
        crRpt.SetParameterValue("nombreben2", lcnombreben2.Trim)
        crRpt.SetParameterValue("nombreben3", lcnombreben3.Trim)
        crRpt.SetParameterValue("nombreben4", lcnombreben4.Trim)
        crRpt.SetParameterValue("nombreben5", lcnombreben5.Trim)

        crRpt.SetParameterValue("cparent1", lcparent.Trim)
        crRpt.SetParameterValue("cparent2", lcparent1.Trim)
        crRpt.SetParameterValue("cparent3", lcparent2.Trim)
        crRpt.SetParameterValue("cparent4", lcparent3.Trim)
        crRpt.SetParameterValue("cparent5", lcparent4.Trim)

        crRpt.SetParameterValue("dfecnac1", lcfecnac1)
        crRpt.SetParameterValue("dfecnac2", lcfecnac2)
        crRpt.SetParameterValue("dfecnac3", lcfecnac3)
        crRpt.SetParameterValue("dfecnac4", lcfecnac4)
        crRpt.SetParameterValue("dfecnac5", lcfecnac5)

        crRpt.SetParameterValue("nporcen1", lnporcen1)
        crRpt.SetParameterValue("nporcen2", lnporcen2)
        crRpt.SetParameterValue("nporcen3", lnporcen3)
        crRpt.SetParameterValue("nporcen4", lnporcen4)
        crRpt.SetParameterValue("nporcen5", lnporcen5)

        crRpt.SetParameterValue("cdomicilio1", lcdirben1)
        crRpt.SetParameterValue("cdomicilio2", lcdirben2)
        crRpt.SetParameterValue("cdomicilio3", lcdirben3)
        crRpt.SetParameterValue("cdomicilio4", lcdirben4)
        crRpt.SetParameterValue("cdomicilio5", lcdirben5)



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

    Public Sub CargarPorcuentahorro(ByVal ccodaho As String)
        Me.TextBox43.Text = ccodaho
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        If RadioButton9.Checked = True Then
            libroregistro(TextBox43.Text.Trim)
        Else
            libroregistro1()
        End If
    End Sub

    Private Sub libroregistro(ByVal cCodaho As String)
        Dim ds1 As New DataSet
        Dim eahomcta As New cAhomcta
        Dim lccodcli As String = ""

        ds1 = eahomcta.ObtieneCuentaAhorro(cCodaho)
        If ds1.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('Cuenta de Ahorro a la Vista NO Creada')</script>")
            Exit Sub

        Else
            lccodcli = ds1.Tables(0).Rows(0)("cnudotr")
        End If



        Dim ds As New DataSet
        ds = eahomcta.ObtieneBeneficiarios2(cCodaho)

        If ds.Tables(0).Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('Falta Adicionar Beneficiarios')</script>")
            Exit Sub
        End If


        Dim lchoraini As String = (Now.Hour.ToString.Trim + ":" + Now.Minute.ToString.Trim + ":" + Now.Second.ToString.Trim)
        Dim lchorafin As String = (Now.Hour.ToString.Trim + ":" + Now.Minute.ToString.Trim + ":" + Now.Second.ToString.Trim)
        Dim lcdepanac, lcmuninac As String
        Dim lcdepadom, lcmunidom As String
        Dim lcdepatra, lcmunitra As String
        Dim lclugarexp As String
        Dim lcdepatrcony, lcmunitrcony As String

        Dim eclimide As New cClimide
        Dim entidadclimide As New climide
        entidadclimide.ccodcli = lccodcli
        eclimide.ObtenerClimide(entidadclimide)

        Dim lccodzon As String
        Dim lczoncony As String
        Dim lccoddom As String
        Dim lczonlab As String
        Dim lczonexp As String

        lccodzon = entidadclimide.ccodnac
        lczoncony = entidadclimide.ccodcon
        lccoddom = entidadclimide.ccoddom
        lczonlab = entidadclimide.czonlab
        lczonexp = entidadclimide.cLugExp

        Dim etabtzon As New cTabtzon
        Dim entidadtabtzon As New tabtzon

        If lccodzon.Trim = "" Then
            lcdepanac = ""
        Else
            entidadtabtzon.ccodzon = lccodzon.Substring(0, 2) 'DropDownDeptos0.SelectedValue.Trim
            entidadtabtzon.ctipzon = "1"
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcdepanac = entidadtabtzon.cdeszon.Trim

        End If

        If lczoncony.Trim = "" Then
            lcdepatrcony = ""
        Else
            entidadtabtzon.ccodzon = lczoncony.Substring(0, 2) 'DropDownDeptos1.SelectedValue.Trim
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcdepatrcony = entidadtabtzon.cdeszon.Trim

        End If

        If lccoddom.Trim = "" Then
            lcdepadom = ""
        Else
            entidadtabtzon.ccodzon = lccoddom.Substring(0, 2) 'DropDownDeptos.SelectedValue.Trim
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcdepadom = entidadtabtzon.cdeszon.Trim

        End If

        If lczonlab.Trim = "" Then
            lcdepatra = ""
        Else
            entidadtabtzon.ccodzon = lczonlab.Substring(0, 2) 'DropDownDeptos2.SelectedValue.Trim
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcdepatra = entidadtabtzon.cdeszon.Trim
        End If

        If lczonexp.Trim = "" Then
            lclugarexp = ""
        Else
            entidadtabtzon.ccodzon = lczonexp.Substring(0, 2)
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lclugarexp = entidadtabtzon.cdeszon.Trim
        End If

        If lccodzon.Trim = "" Then
            lcmuninac = ""
        Else
            entidadtabtzon.ccodzon = lccodzon.Substring(0, 4)
            entidadtabtzon.ctipzon = "2"
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcmuninac = entidadtabtzon.cdeszon.Trim

        End If

        If lccoddom.Trim = "" Then
            lcmunidom = ""
        Else
            entidadtabtzon.ccodzon = lccoddom.Substring(0, 4)
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcmunidom = entidadtabtzon.cdeszon.Trim
        End If

        If lczoncony.Trim = "" Then
            lcmunitrcony = ""
        Else
            entidadtabtzon.ccodzon = lczoncony.Substring(0, 4)
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcmunitrcony = entidadtabtzon.cdeszon.Trim
        End If

        If lczonlab.Trim = "" Then
            lcmunitra = ""
        Else
            entidadtabtzon.ccodzon = lczonlab.Substring(0, 4)
            etabtzon.ObtenerTabtzon(entidadtabtzon)
            lcmunitra = entidadtabtzon.cdeszon.Trim
        End If


        Dim lcprofdui, lcprof As String
        Dim etabtprf As New cTabtprf
        Dim entidadprf As New tabtprf
        If entidadclimide.ccodprodui.Trim = "" Then
            lcprofdui = ""

        Else
            entidadprf.ccodigo = entidadclimide.ccodprodui
            etabtprf.ObtenerTabtprf(entidadprf)
            lcprofdui = entidadprf.cdescri.Trim

        End If

        entidadprf.ccodigo = entidadclimide.ccodpro 'Me.cmbProfCli.SelectedValue.Trim
        etabtprf.ObtenerTabtprf(entidadprf)
        lcprof = entidadprf.cdescri.Trim

        Dim lccondviv As String
        Dim etabttab As New cTabttab
        lccondviv = etabttab.Describe(entidadclimide.cconviv, "017")

        Dim lcestciv As String
        lcestciv = etabttab.Describe(entidadclimide.cestciv, "012")

        Dim lcnombres, lcapellidos As String
        lcnombres = entidadclimide.cnombres
        lcapellidos = entidadclimide.capellidos
        Dim lcdui As String = entidadclimide.cnudoci
        Dim ldfechaexp As Date
        ldfechaexp = entidadclimide.dfchExp
        Dim lcnit As String = entidadclimide.cnudotr
        Dim ldfecnaci As Date = entidadclimide.dnacimi
        Dim lnedad As Integer
        lnedad = clsppal.CalculaEdad(ldfecnaci)
        Dim lcdirdom As String = entidadclimide.cdirdom.Trim
        Dim lcteldom As String = entidadclimide.cteldom.Trim
        Dim lclugartr As String = entidadclimide.cdirfue
        Dim lcdomtra As String = entidadclimide.cdomtra
        Dim lcteltralab As String = entidadclimide.cteltralab
        Dim lctiempo As String = entidadclimide.ctiempo
        Dim lccargo As String = entidadclimide.ccargo
        Dim lndismen As String = entidadclimide.ndismen
        Dim lnpercar As Integer = entidadclimide.npercar
        Dim lcNomCony As String = entidadclimide.cNomcon
        Dim lcdomtray As String = entidadclimide.cdomtray
        Dim lcteltray As String = entidadclimide.cteltray


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String = "crLibReg.pdf"
        crRpt.Load(Server.MapPath("reportes") + "\crLibReg.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt.Refresh()

        crRpt.SetDataSource(ds.Tables(0))

        crRpt.SetParameterValue("cnomins", Session("gcnomins"))

        crRpt.SetParameterValue("cnombre", (lcnombres.Trim + " " + lcapellidos.Trim))
        crRpt.SetParameterValue("cdui", lcdui.Trim)
        crRpt.SetParameterValue("clugarexp", (lclugarexp))
        crRpt.SetParameterValue("cfechaexp", ldfechaexp.ToString)
        crRpt.SetParameterValue("cnit", lcnit.Trim)
        crRpt.SetParameterValue("clugarnac", (lcdepanac + ", " + lcmuninac + " " + ldfecnaci.ToString.Substring(0, 10)))

        crRpt.SetParameterValue("nedad", lnedad)

        crRpt.SetParameterValue("cestciv", lcestciv.Trim)
        crRpt.SetParameterValue("cdireccion", (lcdirdom + " " + lcdepadom + ", " + lcmunidom))
        crRpt.SetParameterValue("ctelefono", lcteldom)
        'crRpt.SetParameterValue("cdepadom", lcdepadom)
        'crRpt.SetParameterValue("cmunidom", lcmunidom)
        crRpt.SetParameterValue("cprofdui", lcprofdui)
        crRpt.SetParameterValue("cprof", lcprof)
        crRpt.SetParameterValue("clugartr", (lclugartr.Trim + " " + (lcdomtra.Trim + " " + lcdepatra + ", " + lcmunitra)))
        crRpt.SetParameterValue("cteltr", lcteltralab.Trim)
        crRpt.SetParameterValue("ctiempotr", lctiempo.Trim)
        crRpt.SetParameterValue("ccargo", lccargo.Trim)
        crRpt.SetParameterValue("ningresos", lndismen)
        crRpt.SetParameterValue("ldfecing", Session("gdfecsis"))
        crRpt.SetParameterValue("suledocony", entidadclimide.nsuetray)
        crRpt.SetParameterValue("nacionalidad", "SALVADOREÑO(A)")

        If lcestciv.Trim = "2" Or lcestciv.Trim = "6" Then
            crRpt.SetParameterValue("cnombrecony", lcNomCony.Trim)
            crRpt.SetParameterValue("cdirtracony", (lcdomtray.Trim + " " + lcdepatrcony + ", " + lcmunitrcony))
            crRpt.SetParameterValue("cteltracony", lcteltray.Trim)
        Else
            crRpt.SetParameterValue("cnombrecony", "")
            crRpt.SetParameterValue("cdirtracony", "")
            crRpt.SetParameterValue("cteltracony", "")
        End If
        crRpt.SetParameterValue("ndependen", lnpercar)
        crRpt.SetParameterValue("ccodcli", lccodcli)

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

    Private Sub libroregistro1()
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String = "crLibReg1.pdf"
        crRpt.Load(Server.MapPath("reportes") + "\crLibReg1.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt.Refresh()
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
