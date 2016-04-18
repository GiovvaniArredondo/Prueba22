
Partial Class Imgen_Ticket_Cl
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim valor As String = Request.QueryString("Valor")

        carga_imagen(valor)

    End Sub

    Public Sub carga_imagen(ByVal nombreImg As String)
      
        Try

            Dim FilePath As String = "C:\Comprobante\"
            'Dim lcnombre As String = filename
            Dim Archivo As String = ""
            Dim filename As String = nombreImg

            filename = "C:\Comprobante\" + filename

            If System.IO.File.Exists(filename) Then  'Si Existe el Archivo Pasa

                Archivo = Server.MapPath(".\uploads\" + nombreImg)

                If filename <> "" Then
                    Dim path As String = filename
                    Dim file As New System.IO.FileInfo(path)

                    'Copia el archivo a un lugar que se pueda visualizar, primero verifica si existe para borrarlo
                    If System.IO.File.Exists(Archivo) Then
                        System.IO.File.Delete(Archivo)
                    End If

                    System.IO.File.Copy(filename, Archivo)

                    If file.Exists Then  'Si Existe el Archivo lo Descarga
                        'lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                        Image1.Visible = True
                        Me.Image1.ImageUrl = "~/uploads/" & nombreImg
                    Else
                        ''        Response.Write("Expediente no Encontrado... No se ha Digitalizado")
                        'lblStatus.Text = "Fotos Digitales no Encontradas... "
                        'lblStatus.ForeColor = Color.Red
                        'ImageFoto.Visible = False
                    End If
                End If
            Else
                'lblStatus.Text = "Fotos Digitales no Encontradas... "
                'lblStatus.ForeColor = Color.Red
                'ImageFoto.Visible = False
            End If



        Catch ex As Exception
            Image1.Visible = False
        End Try


    End Sub

    
End Class
