
Partial Class controles_Creditos_WbUCDispersaGar
    Inherits ucWBase


#Region "Privadas"
    Private omcredkar As New cCredkar
    Private codigoJs As String
#End Region

#Region "Metodos"
    Public Sub limpieza()
        Me.TxtDfecvig.Text = Session("gdfecsis")
    End Sub

#End Region

    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim array_d As New ArrayList


        array_d = omcredkar.Extrae_Archivo_Dispersador_Garantias(Date.Parse(Me.TxtDfecvig.Text), Date.Parse(Me.TxtDfecvig.Text), Session("GCNOMINS"), _
                                                                Session("GCCTABCO"))


        If array_d.Item(0) = 0 Then
            codigoJs = "<script language='javascript'>alert('Ocurrio en la Dispersión, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        ElseIf array_d.Item(3) = 0 Then
            codigoJs = "<script language='javascript'>alert('No Existe nada que dispersar, " & _
                       "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        Me.DownloadFile(array_d.Item(1), array_d.Item(2))

    End Sub


    Protected Sub btnReport_1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReport_1.Click
        Dim ds_Print As New DataSet
        Dim parameters(1, 1) As String
        Dim i As Integer = 1

        Dim mcremcre As New cCremcre

        ds_Print = mcremcre.Extrae_Datos_Arhivo_Dispersion_Garantias(Date.Parse(Me.TxtDfecvig.Text), Date.Parse(Me.TxtDfecvig.Text), 1)

        If ds_Print.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No Existen Datos, " & _
                        "Advertencia Sim.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        'Armando Matriz de variables
        parameters(0, 0) = ("GCNOMINST")
        parameters(0, 1) = (Session("GCNOMINS"))

        parameters(1, 0) = ("GCTITULO")
        parameters(1, 1) = ("DISPERSIONES DE GARANTIAS PENDIENTE")

        Me.GenerarReporte(ds_Print, Server.MapPath("reportes"), "rptDispersa.rpt", "PDF", parameters)

    End Sub

    Protected Sub btnReport_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReport_2.Click
        Dim ds_Print As New DataSet
        Dim parameters(1, 1) As String
        Dim i As Integer = 1

        Dim mcremcre As New cCremcre

        ds_Print = mcremcre.Extrae_Datos_Arhivo_Dispersion_Garantias(Date.Parse(Me.TxtDfecvig.Text), Date.Parse(Me.TxtDfecvig.Text), 0)

        If ds_Print.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No Existen Datos, " & _
                        "Advertencia Sim.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        'Armando Matriz de variables
        parameters(0, 0) = ("GCNOMINST")
        parameters(0, 1) = (Session("GCNOMINS"))

        parameters(1, 0) = ("GCTITULO")
        parameters(1, 1) = ("DISPERSIONES DE GARANTIAS REALIZAS")

        Me.GenerarReporte(ds_Print, Server.MapPath("reportes"), "rptDispersa.rpt", "PDF", parameters)
    End Sub

End Class
