
Partial Class controles_Creditos_WbConFotos
    Inherits ucWBase

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtccodcli.Text = codigoCliente
        'Nombre del Cliente
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos

        entidad3.ccodcta = codigoCliente.Trim
        ecreditos.Obtenercreditos(entidad3)

        Me.txtcnomcli.Text = entidad3.cnomcli.Trim
        'ViewState.Add("eCreditos", entidad3)

        lblStatus.Text = txtccodcli.Text.Trim + "-" + Me.cbxTipFoto.SelectedItem.Text.Trim + "-" + txtcnomcli.Text.Trim.ToUpper + ".jpg"
        lblStatus.ForeColor = Color.FromArgb(0, 102, 255)

    End Sub

    Protected Sub btnGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGen.Click

        Try


            Dim FilePath As String = "C:\Fotos\"
            'Dim lcnombre As String = filename
            Dim Archivo As String = ""
            lblStatus.Text = txtccodcli.Text.Trim + "-" + Me.cbxTipFoto.SelectedItem.Text.Trim + "-" + txtcnomcli.Text.Trim.ToUpper + ".jpg"

            Dim filename As String = lblStatus.Text

            filename = "C:\Fotos\" + filename

            If System.IO.File.Exists(filename) Then  'Si Existe el Archivo Pasa

                Archivo = Server.MapPath(".\uploads\" + lblStatus.Text)

                If filename <> "" Then
                    Dim path As String = filename
                    Dim file As New System.IO.FileInfo(path)

                    'Copia el archivo a un lugar que se pueda visualizar, primero verifica si existe para borrarlo
                    If System.IO.File.Exists(Archivo) Then
                        System.IO.File.Delete(Archivo)
                    End If

                    System.IO.File.Copy(filename, Archivo)

                    If file.Exists Then  'Si Existe el Archivo lo Descarga
                        lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                        ImageFoto.Visible = True
                        Me.ImageFoto.ImageUrl = "~/uploads/" & lblStatus.Text
                    Else
                        '        Response.Write("Expediente no Encontrado... No se ha Digitalizado")
                        lblStatus.Text = "Fotos Digitales no Encontradas... "
                        lblStatus.ForeColor = Color.Red
                        ImageFoto.Visible = False
                    End If
                End If
            Else
                lblStatus.Text = "Fotos Digitales no Encontradas... "
                lblStatus.ForeColor = Color.Red
                ImageFoto.Visible = False
            End If

            

        Catch ex As Exception
            ImageFoto.Visible = False
        End Try


    End Sub
End Class
