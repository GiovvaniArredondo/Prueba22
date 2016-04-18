
Partial Class controles_Creditos_WbUCamStatuSol
    Inherits ucWBase


#Region "Privadas"
    Private vdetalle As New DataSet
    Private ecreditos As New ccreditos
    Private codigoJs As String
#End Region

#Region "Metodos"
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.TxtcCodgru.Text = codigoCliente
        'Nombre del Cliente
       
        
        Dim entidadCremsol As New SIM.EL.cremsol
        Dim eCremsol As New SIM.BL.cCremsol

        entidadCremsol.cCodsol = codigoCliente
        eCremsol.ObtenerCremsol(entidadCremsol)

        Me.Txtcnomgru.Text = entidadCremsol.cnomgru.Trim


        vdetalle = ecreditos.Extrae_Datos_Grupo_Sugerido_Aprobado(Me.TxtcCodgru.Text.Trim)

        ViewState("Grupo") = vdetalle

        If vdetalle.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                          "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        btnGrabar.Enabled = True
        Grid_Grupo.Visible = True
        Grid_Grupo.DataSource = vdetalle
        Grid_Grupo.DataBind()
    End Sub

    Private Sub Limpieza()
        Grid_Grupo.Visible = False
        Me.Txtcnomgru.Text = ""
        Me.TxtcCodgru.Text = ""
        btnGrabar.Enabled = False
    End Sub


    Public Sub Carga_inicial()
        Limpieza()
        ViewState.Add("Grupo", vdetalle)
    End Sub
#End Region

    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try

            Dim lcCodcta As String = ""
            Dim FilePath As String = "C:\Fotos\"
            Dim Archivo_dig As String = "C:\Expedientes\"
            Dim filename_fot As String = ""
            Dim lblStatus As String = ""
            Dim sName As String = ""
            Dim omcremcre As New cCremcre
            Dim lnRetorno As Integer


            vdetalle = ViewState("Grupo")

            'Primero Limpia los Archivos y fotos digitales del grupo
            For Each row As GridViewRow In Grid_Grupo.Rows
                lcCodcta = row.Cells(1).Text.Trim

                filename_fot = "C:\Fotos\"
                ''''''''
                'Primero Borra las fotos, Barriendo los tres tipos parametrizados, DOMICILIO, NEGOCIO, GARANTIAS
                lblStatus = filename_fot + lcCodcta + "-" + "DOMICILIO" + "-" + row.Cells(2).Text.Trim.ToUpper + ".JPG"
                If System.IO.File.Exists(lblStatus) Then
                    System.IO.File.Delete(lblStatus)
                End If

                lblStatus = filename_fot + lcCodcta + "-" + "NEGOCIO" + "-" + row.Cells(2).Text.Trim.ToUpper + ".JPG"
                If System.IO.File.Exists(lblStatus) Then
                    System.IO.File.Delete(lblStatus)
                End If

                lblStatus = filename_fot + lcCodcta + "-" + "GARANTIAS" + "-" + row.Cells(2).Text.Trim.ToUpper + ".JPG"
                If System.IO.File.Exists(lblStatus) Then
                    System.IO.File.Delete(lblStatus)
                End If


                ''finaliza borrado de fotos

                '''''''
                'Ahora Borra el archivo digital
                sName = Archivo_dig + lcCodcta + "-" + row.Cells(2).Text.Trim.ToUpper + ".PDF"
                If System.IO.File.Exists(sName) Then
                    System.IO.File.Delete(sName)
                End If

            Next

            ''finaliza borrado de Expediente Digital

            'Actualiza estado del credito, Elimina de tablas principales 
            lnRetorno = omcremcre.Realiza_Cambio_Estado_Credito_Sol(vdetalle.Tables(0), "A")


            If lnRetorno = 0 Then
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

            Me.Limpieza()

        Catch ex As Exception
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                     "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End Try

    End Sub

End Class
