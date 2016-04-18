
Partial Class controles_Creditos_WbUCamstatus
    Inherits ucWBase

#Region "Privadas"
    Private codigoJs As String
    Private clsRev As New SIM.BL.ClsRevDesem
#End Region

#Region " Metodos "
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Dim lcuenta As String
        Dim gdfecsis As Date

        lcuenta = codigoCliente

        Me.TxtCuenta.Text = codigoCliente.Substring(6, 12)
        Me.TxtInst.Text = codigoCliente.Substring(0, 3)
        Me.TxtOficina.Text = codigoCliente.Substring(3, 3)
        Me.TxtCodigo.Text = lcuenta

        If lcuenta = Nothing Then
            Exit Sub
        End If

        gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar

        'VALIDA SI ES CAJERO Y SI TIENE SU CAJA ABIERTA PARA PODER OPERAR PAGOS CAJ=2
        Dim eusuario As New cusuarios
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim ecredkar As New cCredkar

        Me.Aplica()

        'Me.btnGrabar.Enabled = True


    End Sub

    Public Sub Limpieza()
        Me.TxtCodcli.Text = " "
        Me.TxtCodigo.Text = " "
        Me.TxtCuenta.Text = " "
        Me.TxtDfecvig.Text = " "
        Me.TxtInst.Text = " "
        Me.TxtNomcli.Text = " "
        Me.TxtOficina.Text = " "
        Me.btnGrabar.Enabled = False

    End Sub
    Public Sub Aplica()
        'Sacando los datos necesarios para el Desembolso
        Dim lcestado As String
        Dim lndescuento As Double
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre

        Try


            entidad1.ccodcta = Me.TxtCodigo.Text

            ecreditos.ObtenerCremcre(entidad1)

            lcestado = entidad1.cestado

            If Not (lcestado = "C" Or lcestado = "E") Then
                'Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Limpieza()
                Exit Sub
            End If

            Me.TxtDfecvig.Text = entidad1.dfecvig
            Me.TxtCodcli.Text = entidad1.ccodcli

            '     Me.Txtcnrodoc.Text = entidad1.cnrodes

            'Datos del Cliente
            Dim entidad2 As New SIM.EL.climide
            Dim eClimide As New SIM.BL.cClimide

            entidad2.ccodcli = Me.TxtCodcli.Text

            eClimide.ObtenerClimide(entidad2)

            Me.TxtNomcli.Text = entidad2.cnomcli
            Me.btnGrabar.Enabled = True


        Catch ex As Exception
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End Try

    End Sub


#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Limpieza()
        End If
    End Sub


    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        Try

            Dim lcCodcta As String = Me.TxtInst.Text.Trim + Me.TxtOficina.Text.Trim + Me.TxtCuenta.Text.Trim
            Dim FilePath As String = "C:\Fotos\"
            Dim Archivo_dig As String = "C:\Expedientes\"
            Dim filename_fot As String = ""
            Dim lblStatus As String = ""
            Dim sName As String = ""
            Dim omcremcre As New cCremcre
            Dim lnRetorno As Integer

            'Dim filename As String = lblStatus.Text

            filename_fot = "C:\Fotos\"

            ''''''''
            'Primero Borra las fotos, Barriendo los tres tipos parametrizados, DOMICILIO, NEGOCIO, GARANTIAS
            lblStatus = filename_fot + lcCodcta + "-" + "DOMICILIO" + "-" + TxtNomcli.Text.Trim.ToUpper + ".JPG"
            If System.IO.File.Exists(lblStatus) Then
                System.IO.File.Delete(lblStatus)
            End If

            lblStatus = filename_fot + lcCodcta + "-" + "NEGOCIO" + "-" + TxtNomcli.Text.Trim.ToUpper + ".JPG"
            If System.IO.File.Exists(lblStatus) Then
                System.IO.File.Delete(lblStatus)
            End If

            lblStatus = filename_fot + lcCodcta + "-" + "GARANTIAS" + "-" + TxtNomcli.Text.Trim.ToUpper + ".JPG"
            If System.IO.File.Exists(lblStatus) Then
                System.IO.File.Delete(lblStatus)
            End If


            ''finaliza borrado de fotos

            '''''''
            'Ahora Borra el archivo digital
            sName = Archivo_dig + lcCodcta + "-" + TxtNomcli.Text.Trim.ToUpper + ".PDF"
            If System.IO.File.Exists(sName) Then
                System.IO.File.Delete(sName)
            End If

            ''finaliza borrado de Expediente Digital

            'Actualiza estado del credito, Elimina de tablas principales 
            lnRetorno = omcremcre.Realiza_Cambio_Estado_Credito(lcCodcta, "A")

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
