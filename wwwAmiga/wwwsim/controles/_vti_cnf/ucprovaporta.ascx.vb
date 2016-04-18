Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Public Class ucprovaporta
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents label_mensaje As System.Web.UI.WebControls.Label
    Protected WithEvents capitalizar As System.Web.UI.WebControls.CheckBox
    Protected WithEvents btngraba As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents txtprovi As System.Web.UI.WebControls.TextBox
    Protected WithEvents RangeValidator5 As System.Web.UI.WebControls.RangeValidator

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            cargar()
        End If

    End Sub
    Sub cargar()
        Dim ldfecha As Date
        ldfecha = Session("gdfecsis")
        Me.txtprovi.Text = ldfecha.ToString
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
        Dim dsprovision As New DataSet
        Dim clsprovi As New cAhomaho
        Dim ldfecha As Date

        ldfecha = Date.Parse(Me.txtprovi.Text)

        dsprovision = clsprovi.ObtenerDataSetPorfecha(ldfecha)
        Try
            If dsprovision Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsprovision.Tables(0).Rows.Count = 0 Then
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
            crRpt.Load(Server.MapPath("reportes") + "\crprovaho.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsprovision.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub

    
    
    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        Dim clsprovi As New cprovisionaho
        Dim ldfecpro As Date
        Dim lcfecha As Date
        Dim ldfecha As Date
        Dim lccodusu As String

        'evalua si la condicion de la fecha, es factible para la provision
        If ldfecpro.Day < 31 And (ldfecpro.Month = 1 Or ldfecpro.Month = 3 Or ldfecpro.Month = 5 Or ldfecpro.Month = 7 Or ldfecpro.Month = 8 Or ldfecpro.Month = 10 Or ldfecpro.Month = 12) Then
            Response.Write("<script language='javascript'>alert('La fecha deberá ser al final del mes')</script>")
        End If
        If ldfecpro.Day < 30 And (ldfecpro.Month = 4 Or ldfecpro.Month = 6 Or ldfecpro.Month = 9 Or ldfecpro.Month = 11) Then
            Response.Write("<script language='javascript'>alert('La fecha deberá ser al final del mes')</script>")
        End If
        If ldfecpro.Day < 28 And ldfecpro.Month = 2 Then
            Response.Write("<script language='javascript'>alert('La fecha deberá ser al final del mes')</script>")
        End If

        Try
            ldfecpro = Date.Parse(Me.txtprovi.Text)
            'si hay capitalizacion de intereses
            If ldfecpro.Month = 3 Or ldfecpro.Month = 6 Or ldfecpro.Month = 9 Or ldfecpro.Month = 12 Then
                Me.capitalizar.Checked = True
            Else
                Me.capitalizar.Checked = False
            End If


            lcfecha = "01" & "/" & ldfecpro.Month.ToString & "/" & ldfecpro.Year.ToString
            ldfecha = Date.Parse(lcfecha)
            lccodusu = Session("gccodusu")

            clsprovi.gdfecpro = ldfecpro
            clsprovi.gdfecini = ldfecha
            clsprovi.gccodusu = lccodusu
            clsprovi.gccodofi = Session("gccodofi")
            clsprovi.gccodfue = "01"
            clsprovi.provisiona_intereses_ahorro()
            Response.Write("<script language='javascript'>alert('OK')</script>")
            If ldfecpro.Month = 3 Or ldfecpro.Month = 6 Or ldfecpro.Month = 9 Or ldfecpro.Month = 12 Then
                clsprovi.capitalizar_intereses()
            End If
            imprime()

            'si hay capitalizacion de intereses
            If ldfecpro.Month = 3 Or ldfecpro.Month = 3 Or ldfecpro.Month = 9 Or ldfecpro.Month = 12 Then

            End If

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Fallo cálculo de provisión')</script>")
        End Try

    End Sub
End Class
