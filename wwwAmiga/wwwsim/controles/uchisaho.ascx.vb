Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web






Partial Class uchisaho
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
        End If
    End Sub
    Public Sub CargarDatosPorCuenta(ByVal cuenta As String)
        Me.txtcodcta.Text = cuenta
        APLICAR()
    End Sub

    Sub APLICAR()
        Dim lccodaho As String
        Dim mclimide As New cClimide
        Dim eclimide As New climide
        Dim mahomcta As New cAhomcta
        Dim eahomcta As New ahomcta
        Dim lccodcli As String
        Dim ldfecha As Date
        lccodaho = Me.txtcodcta.Text.Trim
        eahomcta.ccodaho = lccodaho
        mahomcta.ObtenerAhomcta(eahomcta)
        Me.txtcodcli.Text = eahomcta.cnudotr
        Me.txtsaldo.Text = eahomcta.nsaldoaho

        eclimide.ccodcli = Me.txtcodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        Me.txtnomcli.Text = eclimide.cnomcli

        ldfecha = Session("GDFECSIS")
        Me.txtfecha.Text = ldfecha.ToString

        'carga grid
        Dim mControl As New cAhommov
        Dim mLista As New listaahommov
        Dim mEntidad As New ahommov
        Dim lccodcta As String
        mLista = mControl.ObtenerLista(lccodaho)
        Me.datos.DataSource = mLista
        Me.datos.DataBind()

    End Sub

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub

    Private Sub imprime()
        Dim dsimprime As New DataSet
        Dim clsahomcta As New cAhomcta
        Dim lccodaho As String
        lccodaho = Me.txtcodcta.Text.Trim
        If lccodaho <> Nothing Then
            dsimprime = clsahomcta.Obtenerdatasetporcuenta(lccodaho)
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
                crRpt.Load(Server.MapPath("reportes") + "\crmovaho.rpt", OpenReportMethod.OpenReportByDefault)
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
        End If

    End Sub


    
    Private Sub btnsalir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.ServerClick
        Me.txtcodcli.Text = ""
        Me.txtcodcta.Text = ""
        Me.txtnomcli.Text = ""
        Me.txtfecha.Text = ""
        Me.txtsaldo.Text = ""
    End Sub

    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick
        imprime()
    End Sub
End Class


