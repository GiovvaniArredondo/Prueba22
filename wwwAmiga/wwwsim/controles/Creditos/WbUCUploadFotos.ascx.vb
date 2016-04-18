Imports System.IO

Partial Class controles_Creditos_WbUCUploadFotos
    Inherits ucWBase

#Region "Privadas"
    Private codigoJs As String
    Private musuarios As New cusuarios
    Private firma() As Byte
    Private lnRetorno As Integer
#End Region

#Region "Metodos"

    Private Sub Carga_Firma_Digital()
        'hfIdEmpleado.Value = entidadClimide.ccodcli
        'CargarImagenDeBaseDatos(entidadClimide.foto)
        Me.ImageFoto.ImageUrl = "../uploads/" + hfIdEmpleado.Value + ".JPG"
        ImageFoto.Visible = True
    End Sub

    Private Function ValidaExtension(ByVal sExtension As String) As Boolean
        Select Case sExtension.ToUpper
            Case ".JPG"    ', ".png"
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

    Public Sub CargarPorCliente(ByVal CdgCliente As String)
        Dim EntCred As New SIM.EL.creditos
        Dim EntCCred As New SIM.BL.ccreditos

        EntCred.ccodcta = CdgCliente.Trim
        EntCCred.Obtenercreditos(EntCred)

        Me.TxtcCodcta.Text = CdgCliente.Trim
        Me.txtcnomcli.Text = EntCred.cnomcli.Trim

        If Not (EntCred.cestado = "A" Or EntCred.cestado = "C" Or EntCred.cestado = "E") Then
            Btnsave.Enabled = False
            btnSubir.Enabled = False
            fileUpEx.Enabled = False
            Response.Write("<script language='javascript'>alert('Estado del Crédito Diferente a Solicitado, Advertencia')</script>")
            Exit Sub
        End If

        Btnsave.Enabled = True
        btnSubir.Enabled = True
        fileUpEx.Enabled = True
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
                    pathGrabar = Server.MapPath(".\uploads\" + Archivo)
                    fileUpEx.PostedFile.SaveAs(pathGrabar)
                    lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                    'lblStatus.Text = "Archivo , puede actualizar la foto"
                    'Image1.ImageUrl = "~/uploads/" + filepath
                    hfPathArchivo.Value = pathGrabar

                    ImageFoto.Visible = True
                    Me.ImageFoto.ImageUrl = "~/uploads/" & Archivo
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
        Dim sExt As String = String.Empty
        Dim sName As String = String.Empty
        Dim lnRetorno As Integer = 0
        Dim mcremcre As New cCremcre

        lblStatus.ForeColor = Color.FromArgb(210, 0, 0)

        If TxtcCodcta.Text.Trim.Length > 0 Then
            If Not fileUpEx.HasFile = Nothing Then
                sName = TxtcCodcta.Text.Trim + "-" + Me.cbxTipFoto.SelectedItem.Text.Trim + "-" + TxtcNomcli.Text.Trim.ToUpper
                sExt = Path.GetExtension(fileUpEx.FileName)

                If ValidaExtension(sExt.ToLower) Then
                    fileUpEx.SaveAs("C:\Fotos\" & sName & sExt.ToUpper)

                    'Actualiza Estatus de la fotografia en la Maestra

                    lnRetorno = mcremcre.Actualiza_Bandera_Digitalización(Me.TxtcCodcta.Text.Trim)
                    If lnRetorno = 1 Then
                        lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                        lblStatus.Text = "Enviado Correctamente !!"
                    Else
                        lblStatus.ForeColor = Color.Red
                        lblStatus.Text = "Error al Enviar el Archivo !!"
                    End If
                    
                Else : lblStatus.Text = "Este tipo de archivo no esta permitido."
                End If
            Else : lblStatus.Text = "Seleccione el archivo que desea subir."
            End If
        Else : lblStatus.Text = "Debe buscar un cliente antes de subir el archivo."
        End If

    End Sub


End Class
