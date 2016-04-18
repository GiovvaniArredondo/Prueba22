Imports System.IO

Partial Class controles_wucUploadExp
    Inherits ucWBase

    Private codigoJs As String
    Public Sub CargarPorCliente(ByVal CdgCliente As String)
        Dim EntCred As New SIM.EL.creditos
        Dim EntCCred As New SIM.BL.ccreditos

        EntCred.ccodcta = CdgCliente.Trim
        EntCCred.Obtenercreditos(EntCred)

        Me.txtccodcli.Text = CdgCliente.Trim
        Me.txtcnomcli.Text = EntCred.cnomcli.Trim

        If Not (EntCred.cestado = "C" Or EntCred.cestado = "E") Then
            btnGen.Enabled = False
            FlUpExped.Enabled = False

            'Envia mensaje ----13-08-2015
            codigoJs = "<script language='javascript'>alert('El cliente debe ser sugerido o aprobado, " & _
                       "Advertencia SIM.NET '); location.href='wfSubeExpe.aspx'</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)




            'Response.Write("<script language='JavaScript'>alert('El Cliente debe estar en estatus de sugerencia o aprobado ');</script>");

            Exit Sub
        End If

        btnGen.Enabled = True
        FlUpExped.Enabled = True
    End Sub

    Protected Sub btnGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGen.Click
        Dim sExt As String = String.Empty
        Dim sName As String = String.Empty

        LblStatus.ForeColor = Color.FromArgb(210, 0, 0)
        Try 'Protege que no marque un error -- 13 -8 -2015

            If txtccodcli.Text.Trim.Length > 0 Then
                If Not FlUpExped.HasFile = Nothing Then
                    sName = txtccodcli.Text.Trim + "-" + txtcnomcli.Text.Trim.ToUpper
                    sExt = Path.GetExtension(FlUpExped.FileName)

                    If ValidaExtension(sExt.ToLower) Then
                        FlUpExped.SaveAs("C:\Expedientes\" & sName & sExt)
                        LblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                        LblStatus.Text = "Enviado Correctamente !!"
                    Else : LblStatus.Text = "Este tipo de archivo no esta permitido."
                    End If
                Else : LblStatus.Text = "Seleccione el archivo que desea subir."
                End If
            Else : LblStatus.Text = "Debe buscar un cliente antes de subir el archivo."

            End If

        Catch ex As Exception

            codigoJs = "<script language='javascript'>alert('El Expediente pesa mas de 5MB, " & _
                      "Advertencia SIM.NET ');</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            Exit Sub

        End Try


    End Sub

    Private Function ValidaExtension(ByVal sExtension As String) As Boolean
        Select Case sExtension
            Case ".pdf", ".doc", ".docx", ".zip", ".rar"
                Return True
            Case Else
                Return False
        End Select
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
