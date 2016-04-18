Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Partial Class ucrepcierre
    Inherits ucWBase


#Region "Variables"
    Private codigoJs As String
    Private ecreditos As New ccreditos
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            cargar()
        End If
    End Sub

    Sub cargar()
        Dim FechaSys As Date = Today()
        Dim ldfecha As Date
    
        FechaSys = Session("gdFecSis")
        ldfecha = Session("gdfecsis")
        Me.txtfecant.Text = ldfecha.ToString
    
    End Sub

    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ds As New DataSet
        ds = ecreditos.ValidadorPlusCierre(Date.Parse(Me.txtfecant.Text), Session("gcCodofi"))
        'If ds.Tables(0).Rows.Count = 0 Then
        '    Response.Write("<script language='javascript'>alert('NO Existe información')</script>")
        '    Exit Sub
        'End If
        Me.Imprime("crRepCierre.rpt", ds)

    End Sub

    Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet)
        Dim lnsaldot As Double = 0
        Dim lnsaldoc As Double = 0
        Dim lcofi As String = ""
        If Session("gccodofi") = "001" Then
            lcofi = "*"
        Else
            lcofi = Session("gcCodofi")
        End If

        lnsaldot = ecreditos.SaldoTotalxAgencia(lcofi, Date.Parse(Me.txtfecant.Text))
        lnsaldoc = ecreditos.SaldoTotalxAgenciaConta(lcofi, Date.Parse(Me.txtfecant.Text))

        Dim ldfecha As Date
        Dim lncasos As Integer
        Dim tipo As String
        ldfecha = Date.Parse(Me.txtfecant.Text)

        Try
            If dsbase Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    'Me.AsignarMensaje("No se encontro información a ser desplegada")
                    'Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = Session("gcnomofi")
        Dim lcoficina As String = "OFICINA CENTRAL"
        Dim etabtofi As New cTabtofi

        If Session("gccodofi") = "001" Then

        Else
            lcoficina = "AGENCIA: " & etabtofi.NombreAgencia(Session("gcCodofi"))
        End If

        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("cnomofi", lcNomofi)
        crRpt.SetParameterValue("dfecha", ldfecha)
        crRpt.SetParameterValue("nsaldot", lnsaldot)
        crRpt.SetParameterValue("nsaldoc", lnsaldoc)

        crRpt.SetParameterValue("oficina", lcoficina)


        tipo = "application/pdf"
        reportes &= ".pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True

        Response.ContentType = tipo


        'Automaticamente se descarga el archivo
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        'Response.Flush()
        'Response.Close()
        Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        Dim ldfecha As Date = Date.Parse(Me.txtfecant.Text)
        ds = ecremcre.RecuperaCreditosReclasificados(Session("gcCodofi"))

        'Imprime
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crReclasifica.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        crRpt.SetParameterValue("dfecha", ldfecha)


        Dim reportes As String
        reportes = "crReclasifica.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()

        Response.End()
    End Sub

    Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim etabtofi As New cTabtofi
        Dim lvalida As Boolean
        lvalida = Me.CheckBox1.Checked


        'VALIDA SI LA AGENCIA CERRO SUS CAJAS 
        Dim valor As Integer
        Dim objCredkar As New cCredkar


        valor = objCredkar.ValidaCajasCerradas(Session("gcCodofi"), Session("gdfecsis"))
        If valor <> 0 Then
            Me.CheckBox1.Checked = False
            'Response.Write("<script language='javascript'>alert('Las cajas no estan cerradas, no se puede efectuar cierre')</script>")
            codigoJs = "<script language='javascript'>alert('Las cajas no estan cerradas, no se puede efectuar cierre, " & _
                   "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If


        Dim i As Integer
        i = etabtofi.ActualizaValidacion(Session("gcCodofi"), lvalida)
        'Response.Write("<script language='javascript'>alert('Validación Actualizada')</script>")
        codigoJs = "<script language='javascript'>alert('Validación Actualizada, " & _
                   "Advertencia SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        Me.salir()


    End Sub
    Sub salir()
        'Auditoria'
        Dim ip As Net.Dns

        Dim nombre_Host As String = ip.GetHostName

        Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)

        Dim direccion_Ip As String = este_Host.AddressList(0).ToString

        Dim entidadusuarios As New usuarios
        Dim milogin As New cLogin
        Dim eusuarios As New cusuarios


        entidadusuarios.cip = direccion_Ip
        entidadusuarios.dfecha = Today
        entidadusuarios.chora = TimeOfDay.ToString.Substring(11, 12)
        entidadusuarios.idUsuario = milogin.IdUsuario(Session("gcCodusu"))
        entidadusuarios.gdfecsis = Session("gdfecsis")
        entidadusuarios.ctrs = "OUT"
        entidadusuarios.idopcion = 0

        Try
            eusuarios.RegistraAuditoria(entidadusuarios)
        Catch ex As Exception

        End Try

        Session.Abandon()
        Response.Redirect("wflogin.aspx")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ecremcre As New cCremcre
        Dim dsprov As New DataSet
        dsprov = ecremcre.RecuperarProvision

        Me.Imprime2("crProvision.rpt", dsprov, "PDF", Date.Parse(txtfecant.Text), "RepPro")

    End Sub

    Public Sub Imprime2(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String, ByVal ldfecha11 As Date, ByVal nombre As String)

        Dim ldfecha As Date
        Dim lncasos As Integer
        ldfecha = Date.Parse(ldfecha11)

        Dim lndia As String = Day(ldfecha)
        Dim lnmes As String = Month(ldfecha)
        Dim lnano As String = Year(ldfecha)

        Dim ldate As String = lndia + IIf(lnmes.Trim.Length = 1, "0", "") + lnmes + lnano

        'evalua parametros a enviar a reporte para sus filtros
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String
        Dim lctipo As String = ""

        ldfecha1 = Date.Parse(ldfecha11)
        ldfecha2 = Date.Parse(ldfecha11)
        lcexportar = "PDF"

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = Session("gcnomins")
        Dim lctitulo As String = ""
        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("dfecha", ldfecha1)
        'crRpt.SetParameterValue("titulo", lctitulo)
        'crRpt.SetParameterValue("dfecha2", ldfecha2)
        'crRpt.SetParameterValue("cNomOfi", lcNomofi)


        reportes = "crProvision.pdf"

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

        dsbase.Tables(0).Clear()
        dsbase.Clear()
    End Sub

End Class


