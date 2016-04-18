Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web






Partial Class uchistorial
    Inherits ucWBase

    Public Event SeleccionarCuenta(ByVal codcta As String)
    Dim dsimprime As New DataSet

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Public Sub CargarDatosPorCliente(ByVal codcli As String)
        Dim mControl As New cCredkar
        Dim mLista As New listacredkar
        mLista = mControl.ObtenerListaPorCuenta(codcli)
        Me.BindGrid(mLista)
    End Sub

    'Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
    '    If esError Then
    '        label_mensaje.CssClass = "MensajeError"
    '    Else
    '        label_mensaje.CssClass = "MensajeInformativo"
    '    End If
    '    label_mensaje.Text = mensaje
    'End Sub

    Private Sub imprime_recibo()
        dsimprime = viewstate("estado")

        Try
            If dsimprime Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsimprime.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
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
            crRpt.Load(Server.MapPath("reportes") + "\crestcta.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsimprime.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub


    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        Dim lccodcli As String
        Dim mcremcre As New cCremcre
        Dim mentidad1 As New cremcre
        viewstate.Add("pccodcta", codcta)

        'temporalmente

        Dim lccodcta As String
        lccodcta = viewstate("pccodcta")
        Dim ds As New DataSet

        'temporalmente para probar
        Dim cls1 As New clspagos
        cls1.ccodcta1 = lccodcta
        'como es para una sola cuenta siempre sera 0
        Dim bunacuenta As Boolean
        bunacuenta = False
        ds = cls1.conviertepagos(bunacuenta)
        viewstate.Add("estado", ds)

        'fin temporal

        mentidad1.ccodcta = codcta
        mcremcre.ObtenerCremcre(mentidad1)
        Me.txtcodcli.Text = mentidad1.ccodcli
        lccodcli = mentidad1.ccodcli
        Me.txtcapdes.Text = utilNumeros.Redondear(mentidad1.ncapdes, 2).ToString
        Me.txtsalcap.Text = utilNumeros.Redondear(mentidad1.ncapdes - mentidad1.ncappag, 2).ToString
        Me.txtintmor.Text = utilNumeros.Redondear(mentidad1.nintmor - (mentidad1.nmorpag + mentidad1.npagcta), 2).ToString
        Me.txtintere.Text = utilNumeros.Redondear(mentidad1.nintcal - (mentidad1.nintpen + mentidad1.nintpag), 2).ToString
        Me.txtcuota.Text = utilNumeros.Redondear(mentidad1.nmoncuo, 2).ToString
        Me.txtdfecvig.Text = mentidad1.dfecvig
        Me.txtdfecven.Text = mentidad1.dfecven
        Me.txtmonpag.Text = utilNumeros.Redondear((mentidad1.nintmor - (mentidad1.nmorpag + mentidad1.npagcta)) + (mentidad1.nintcal - (mentidad1.nintpen + mentidad1.nintpag)), 2)

        Dim mclimide As New cClimide
        Dim mentidad2 As New climide
        mentidad2.ccodcli = lccodcli
        mclimide.ObtenerClimide(mentidad2)
        Me.txtnomcli.Text = mentidad2.cnomcli

        Me.DataGrid1.DataSource = ds
        Me.DataGrid1.DataBind()

    End Sub

    Private Sub BindGrid(ByVal aLista As listacredkar)
        ' Me.dgDatos.DataSource = aLista
        ' Me.dgDatos.DataBind()
    End Sub

    Private Sub dgCred_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
        If e.CommandName = "Select" Then
            RaiseEvent SeleccionarCuenta(e.Item.Cells(1).Text)
        End If
    End Sub

    Private Sub txtmongar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub dgDatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        Dim clskardex As New ckardex
        Dim lccodcta As String
        Dim lcestado As String
        lccodcta = viewstate("pccodcta")
        lcestado = " "

        Try
            '         dsimprime = viewstate("estado")
            'clskardex.ObtenerDataSetPorcuenta(lccodcta, lcestado)
            imprime_recibo()
            Response.Write("<script language='javascript'>alert('ok')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('No se completo proceso')</script>")
        End Try
    End Sub

End Class


