
Partial Class controles_wbAutoFirmas
    Inherits System.Web.UI.UserControl
    Dim entidadahomfir As New Ahomfir
    Dim eahomfir As New cAhomfir



    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        If TextBox43.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Cuenta de Ahorro Vacía')</script>")
            Exit Sub

        End If

        If TextBox7.Text.Trim = "" And TextBox8.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Autorizaciones Vacías')</script>")
            Exit Sub
        End If

        'Verificamos si existe registro de firmas


        entidadahomfir.ccodaho = TextBox43.Text.Trim
        eahomfir.EliminarAhomfir(TextBox43.Text.Trim)


        entidadahomfir.cnomgfir = TextBox7.Text.Trim
        entidadahomfir.cnomgfir2 = TextBox8.Text.Trim

        If TextBox38.Text.Trim = "" Then
            entidadahomfir.dnacgfir = Now
        Else
            entidadahomfir.dnacgfir = Date.Parse(TextBox38.Text)
        End If

        If TextBox39.Text.Trim = "" Then
            entidadahomfir.dnacgfir2 = Now
        Else
            entidadahomfir.dnacgfir2 = Date.Parse(TextBox39.Text)
        End If

        entidadahomfir.cdui1 = TextBox41.Text.Trim
        entidadahomfir.cdui2 = TextBox42.Text.Trim

        entidadahomfir.cdui3 = ""
        entidadahomfir.cnomgfir3 = ""
        entidadahomfir.dnacgfir3 = Now
        entidadahomfir.nlibreta = 0
        entidadahomfir.nmanco = 0
        entidadahomfir.cnomau = ""

        Try
            eahomfir.Agregar(entidadahomfir)
            Response.Write("<script language='javascript'>alert('Grabado')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Error al Grabar')</script>")
        End Try

    End Sub
    Private Sub Aplicar()
        entidadahomfir.ccodaho = TextBox43.Text.Trim
        eahomfir.ObtenerAhomfir(entidadahomfir)

        If entidadahomfir.cnomgfir.Trim = "" Then
        Else
            TextBox7.Text = entidadahomfir.cnomgfir
            TextBox38.Text = entidadahomfir.dnacgfir
            TextBox41.Text = entidadahomfir.cdui1
        End If

        If entidadahomfir.cnomgfir2.Trim = "" Then
        Else
            TextBox8.Text = entidadahomfir.cnomgfir2
            TextBox39.Text = entidadahomfir.dnacgfir2
            TextBox42.Text = entidadahomfir.cdui2
        End If

    End Sub

    Public Sub CargarPorcuentahorro(ByVal ccodaho As String)
        Me.TextBox43.Text = ccodaho
        'Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub


End Class
