Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Imports System.Web.UI.WebControls
Imports System.Web


Public Class ucWBase
    Inherits System.Web.UI.UserControl

    Public Overridable Function Inicializar()

    End Function

    Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal EsError As Boolean = False, Optional ByVal MensajeJava As Boolean = False)
        Dim myLabel As Label

        myLabel = Page.FindControl("Encabezado1").FindControl("Label_Mensaje")

        If myLabel Is Nothing Then Return

        If EsError Then
            myLabel.CssClass = "MensajeError"
        Else
            myLabel.CssClass = "MensajeInformativo"
        End If

        myLabel.Text = asMensaje

        If MensajeJava Then
            If EsError Then
                Response.Write("<script language='javascript'>alert('" & asMensaje & " Por Favor contactar a Soporte Tecnico.')</script>")
            Else
                Response.Write("<script language='javascript'>alert('" & asMensaje & "')</script>")
            End If
        End If
    End Sub

    Public Function ObtenerUsuario() As String
        Return "usuario"
    End Function

    Public Sub LimpiarControles()
        Dim liCntrl As Integer
        Dim Cntrl As System.Web.UI.WebControls.TextBox
        Dim DDL As System.Web.UI.WebControls.DropDownList

        For liCntrl = 0 To Me.Controls.Count - 1
            Select Case Me.Controls(liCntrl).GetType().ToString
                Case "System.Web.UI.WebControls.TextBox"
                    Cntrl = CType(Me.Controls(liCntrl), TextBox)
                    If Cntrl.Visible Then Cntrl.Text = ""
                Case "System.Web.UI.WebControls.DropDownList"
                    Dim li As System.Web.UI.WebControls.ListItem
                    ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                    DDL = CType(Me.Controls(liCntrl), DropDownList)
                    li = DDL.Items.FindByValue("0")

                    If Not li Is Nothing Then DDL.SelectedValue = "0"
            End Select

            If InStr(Me.Controls(liCntrl).GetType().ToString, "ucDDL") > 0 Then
                Dim li As System.Web.UI.WebControls.ListItem
                ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                DDL = CType(Me.Controls(liCntrl), DropDownList)
                li = DDL.Items.FindByValue("0")

                If Not li Is Nothing Then DDL.SelectedValue = "0"
            End If
        Next
    End Sub

    Public Function ObtenerIdOng() As Double
        Return CDbl(HttpContext.Current.Items("idOng"))
    End Function

    Public Sub DownloadFile(ByVal filepath As String, ByVal name As String)

        Dim type As String = ""


        'If Not IsDBNull(ext) Then
        '    ext = LCase(ext)
        'End If

        'Select Case ext
        '    Case ".htm", ".html"
        '        type = "text/HTML"
        '    Case ".txt"
        '        type = "text/plain"
        '    Case ".doc", ".rtf"
        '        type = "Application/msword"
        '    Case ".csv", ".xls"
        '        type = "Application/x-msexcel"
        '    Case Else
        '        type = "text/plain"
        'End Select

        '        If (forceDownload) Then
        Response.AppendHeader("content-disposition", _
        "attachment; filename=" + name)
        'End If
        'If type <> "" Then
        'Response.ContentType = "Application/x-msexcel"
        Response.ContentType = "text/plain"
        '"Application/x-msexcel"
        'End If

        Response.WriteFile(filepath)
        Response.End()

    End Sub

    Public Overridable Sub GenerarReporte(ByVal dsReporte As DataSet, ByVal asRuta As String, _
                                          ByVal Reportes As String, Optional ByVal TipoReporte As String = "PDF", _
                                          Optional ByVal Parametros(,) As Object = Nothing)


        Dim crRpt As New ReportDocument
        Dim ds As New DataSet


        Try
            crRpt.Load(asRuta + "\" & Reportes, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo " + Reportes + ". " + ex.Message.ToString, True, True)
        End Try

        Dim a As String

        a = dsReporte.Tables(0).TableName

        crRpt.SetDataSource(dsReporte.Tables(a))

        If Not Parametros Is Nothing Then

            For i As Integer = 0 To Parametros.Length / 2 - 1
                crRpt.SetParameterValue(Parametros(i, 0), Parametros(i, 1))
            Next
        End If

        Select Case TipoReporte
            Case "PDF"
                crRpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, True, Reportes)

            Case "XLS"
                crRpt.ExportToHttpResponse(ExportFormatType.Excel, Response, True, Reportes)

            Case "HTML"
                crRpt.ExportToHttpResponse(ExportFormatType.HTML40, Response, True, Reportes)

            Case "RTF"
                crRpt.ExportToHttpResponse(ExportFormatType.RichText, Response, True, Reportes)

            Case "DOC"
                crRpt.ExportToHttpResponse(ExportFormatType.WordForWindows, Response, True, Reportes)

        End Select
    End Sub

    Public Overridable Sub ExportarAExcel(ByVal PathArchivo As String, ByVal ds As DataSet)
        ExcelLibrary.DataSetHelper.CreateWorkbook(PathArchivo, ds)
    End Sub

    Public Overridable Sub Down_loadFile(ByVal PathArchivo As String, ByVal name As String)

        Dim type As String = ""
        '        If (forceDownload) Then
        Response.AppendHeader("content-disposition", _
        "attachment; filename=" + name)
        'End If
        'If type <> "" Then
        Response.ContentType = "text/plain"
        '"Application/x-msexcel"
        'End If

        Response.WriteFile(PathArchivo)
        Response.End()

    End Sub


    Public Overridable Sub GenerarReporte_New(ByVal dsReporte As DataSet, ByVal asRuta As String, _
                                          ByVal Reportes As String, Optional ByVal TipoReporte As String = "DOC", _
                                          Optional ByVal Parametros(,) As Object = Nothing)


        Dim crRpt As New ReportDocument
        Dim ds As New DataSet


        Try
            crRpt.Load(asRuta + "\" & Reportes, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo " + Reportes + ". " + ex.Message.ToString, True, True)
        End Try

        Dim a As String

        a = dsReporte.Tables(0).TableName

        crRpt.SetDataSource(dsReporte.Tables(a))

        If Not Parametros Is Nothing Then

            For i As Integer = 0 To Parametros.Length / 2 - 1
                crRpt.SetParameterValue(Parametros(i, 0), Parametros(i, 1))
            Next
        End If

        Select Case TipoReporte
            Case "PDF"
                crRpt.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, True, Reportes)

            Case "XLS"
                crRpt.ExportToHttpResponse(ExportFormatType.Excel, Response, True, Reportes)

            Case "HTML"
                crRpt.ExportToHttpResponse(ExportFormatType.HTML40, Response, True, Reportes)

            Case "RTF"
                crRpt.ExportToHttpResponse(ExportFormatType.RichText, Response, True, Reportes)

            Case "DOC"
                crRpt.ExportToHttpResponse(ExportFormatType.WordForWindows, Response, True, Reportes)
        End Select



    End Sub

End Class


