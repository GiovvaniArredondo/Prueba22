
Partial Class controles_wucDownLoadExp
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtccodcli.Text = codigoCliente
        'Nombre del Cliente
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos

        entidad3.ccodcta = codigoCliente.Trim
        ecreditos.Obtenercreditos(entidad3)

        Me.txtcnomcli.Text = entidad3.cnomcli.Trim
        'ViewState.Add("eCreditos", entidad3)

        lblStatus.Text = txtccodcli.Text.Trim + "-" + txtcnomcli.Text.Trim.ToUpper + ".pdf"
        lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
        
    End Sub

    Protected Sub btnGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGen.Click
        Try


            Dim filename As String = lblStatus.Text

            filename = "C:\Expedientes\" + filename
            If filename <> "" Then
                Dim path As String = filename
                Dim file As New System.IO.FileInfo(path)

                If file.Exists Then
                    Response.Clear()
                    Response.Buffer = True
                    Response.ContentType = "application/pdf"
                    Response.AddHeader("Content-disposition", "attachment; filename=C:\Expedientes\" & lblStatus.Text)
                    Response.WriteFile("C:\Expedientes\" + lblStatus.Text)
                    Response.Flush()
                    Response.Close()
                Else
                    '        Response.Write("Expediente no Encontrado... No se ha Digitalizado")
                    lblStatus.Text = "Expediente no Encontrado... No se ha Digitalizado"
                    lblStatus.ForeColor = Color.Red
                End If
            End If


        Catch ex As Exception

        End Try
       
    End Sub
End Class
