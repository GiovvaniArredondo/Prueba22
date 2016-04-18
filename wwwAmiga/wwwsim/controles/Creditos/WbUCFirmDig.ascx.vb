
Imports System.IO
Imports System.Data.SqlClient

Partial Class controles_Creditos_WbUCFirmDig
    Inherits ucWBase

#Region "Privadas"
    Private codigoJs As String
    Private musuarios As New cusuarios
    Private firma() As Byte
    Private lnRetorno As Integer
#End Region

#Region "Metodos"

    Public Sub Carga_inicial()
        Me.CbxUsuarios1.Recuperar()
    End Sub

    Private Sub Carga_Firma_Digital()
        'hfIdEmpleado.Value = entidadClimide.ccodcli
        'CargarImagenDeBaseDatos(entidadClimide.foto)
        Me.ImageFoto.ImageUrl = "../firmas/" + hfIdEmpleado.Value + ".jpg"
        ImageFoto.Visible = True
    End Sub

    Private Function ValidaExtension(ByVal sExtension As String) As Boolean
        Select Case sExtension
            Case ".jpg", ".png"
                Return True
            Case Else
                Return False
        End Select
    End Function

    Protected Function CargaBufferImagen() As Array

        Dim imagestream As FileStream = New FileStream(hfPathArchivo.Value, FileMode.Open)
        Dim data() As Byte
        ReDim data(imagestream.Length - 1)

        imagestream.Read(data, 0, imagestream.Length)

        imagestream.Close()
        imagestream.Dispose()

        Return data

    End Function


    Private Sub CargarImagenDeBaseDatos(ByVal imagen() As Byte)
        Dim imageInBytes As Byte() = imagen
        Dim pathUploads As String
        Dim nombreArchivo As String

        Dim archivoLogico As StreamWriter

        nombreArchivo = hfIdEmpleado.Value + ".jpg" 'hfExtension.Value
        pathUploads = Server.MapPath(".\firmas\")
        File.WriteAllBytes(pathUploads + nombreArchivo, imagen)

    End Sub

    Private Sub Busca_Firma(ByVal idusuario As Integer)
        Dim entidadusuario As New usuarios
        Dim musuarios As New cusuarios
        Dim Archivo As String = ""

        entidadusuario.idUsuario = idusuario
        musuarios.Obtenerusuarios(entidadusuario)

        Try

            hfIdEmpleado.Value = entidadusuario.idUsuario
            Archivo = hfIdEmpleado.Value + ".jpg"


            CargarImagenDeBaseDatos(entidadusuario.xfirma)
            ImageFoto.Visible = True
            'Me.ImageFoto.ImageUrl = "../firmas/" + hfIdEmpleado.Value + ".jpg"
            Me.ImageFoto.ImageUrl = "~/firmas/" & Archivo

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "No Existe Firma Autorizada"
            Me.ImageFoto.Visible = False
        End Try

    End Sub






#End Region


    Protected Sub btnSubir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        Dim pathGrabar As String
        Try
            If Not fileUpEx Is Nothing Then
                Dim Archivo_ As String = fileUpEx.PostedFile.FileName
                Dim Archivo As String = Path.GetFileName(fileUpEx.PostedFile.FileName)
                'obtiene extension del archivo

                hfExtension.Value = System.IO.Path.GetExtension(fileUpEx.PostedFile.FileName)

                If ValidaExtension(hfExtension.Value.ToLower) Then
                    pathGrabar = Server.MapPath(".\firmas\" + Archivo)
                    fileUpEx.PostedFile.SaveAs(pathGrabar)
                    lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                    lblStatus.Text = "Archivo Subido con Exito, puede actualizar la firma"
                    'Image1.ImageUrl = "~/uploads/" + filepath
                    hfPathArchivo.Value = pathGrabar

                    ImageFoto.Visible = True
                    Me.ImageFoto.ImageUrl = "~/firmas/" & Archivo
                    Me.Btnsave.Enabled = True
                Else
                    lblStatus.ForeColor = Color.Red
                    lblStatus.Text = "Formato de Archivo Incorrecto"
                End If

                
            Else
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "No Existe Archivo a Subir"
                Me.Btnsave.Enabled = False
            End If

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Error al subir archivo"
            Me.Btnsave.Enabled = False
        End Try

    End Sub

    Protected Sub Btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnsave.Click

        Try


            'cClsAdCli.foto = CargaBufferImagen()

            firma = CargaBufferImagen()

            'Actualiza Firma Digital por Usuario
            lnRetorno = musuarios.Actualizar_Firmas_Digitales(firma, Me.CbxUsuarios1.SelectedValue.Trim)


            If lnRetorno = 0 Then
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error en la actualización de la firma digital, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End If

            lblStatus.Text = ""
            Me.ImageFoto.Visible = False
            Me.Btnsave.Enabled = False
            btnSubir.Enabled = False
        Catch ex As Exception

            codigoJs = "<script language='javascript'>alert('Verifique Firma, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        End Try
    End Sub

    Protected Sub Btnconsulta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnconsulta.Click
        Busca_Firma(Me.CbxUsuarios1.SelectedValue)
    End Sub
End Class
