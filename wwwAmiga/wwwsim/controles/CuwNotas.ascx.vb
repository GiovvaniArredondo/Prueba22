Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Public Class CuwNotas
    Inherits System.Web.UI.UserControl


#Region "Privadas"
    Private Shared cuenta As String

    Private Transacc As String
    Private _URLCodigo As String
    Private _lineaSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)
    Private clsCli As New SIM.BL.ClsFindCli

    Private _ClienteSeleccionado As String
    Private codigoJs As String
#End Region
    


    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property


    Public Property lineaSeleccionado() As String
        Get
            Return _lineaSeleccionado
        End Get
        Set(ByVal Value As String)
            _lineaSeleccionado = Value
            If ViewState("codaho") Is Nothing Then
                ViewState.Add("codaho", Value)
            Else
                ViewState("codaho") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.txtccodcta.Text = Session("codigo")
            Me.txtccodcli.Text = Session("fuente")
            txtndias.Text = 1
            CargarNota()
        End If

    End Sub

    Private Sub initvar()
        Txtnota.Text = ""
        Txtndias.Text = 1
    End Sub
    Protected Sub btnnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        initvar()
        btngrabar.Enabled = True
    End Sub
    Private Sub CargarNota()
        Dim enotas As New cNotas
        Dim entidadnotas As New notas
        Dim i As Integer = 0

        Dim ldfecven As Date
        ldfecven = DateAdd(DateInterval.Day, Integer.Parse(txtndias.Text), Session("gdfecsis"))

        'verfica si ya existe nota para credito
        entidadnotas.ccodcta = txtccodcta.Text.Trim

        entidadnotas.fecha = ldfecven
        i = enotas.ObtenerNotas(entidadnotas)

        If i = 0 Then 'no exite
            initvar()

            btngrabar.Enabled = True
            btnmodificar.Enabled = False
        Else
            Txtnota.Text = entidadnotas.nota
            Txtndias.Text = entidadnotas.dias

            btnmodificar.Enabled = True
            btnnuevo.Enabled = True
        End If


    End Sub

    Protected Sub btngrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        'verifica si ya fecha de vencimiento, de nota es mayor a alguna que ya tenga
        If Txtndias.Text.Trim = "" Or Txtndias.Text.Trim = 0 Then
            Exit Sub
        End If

        Dim ldfecven As Date
        ldfecven = DateAdd(DateInterval.Day, Integer.Parse(Txtndias.Text), Session("gdfecsis"))

        Dim entidadnotas As New notas
        Dim enotas As New cNotas
        Dim lverifica As Boolean
        lverifica = enotas.Verficasiprocedenota(ldfecven, txtccodcta.Text.Trim)

        If lverifica = True Then 'procede
            entidadnotas.ccodcta = txtccodcta.Text.Trim
            entidadnotas.ccodcli = txtccodcli.Text.Trim
            entidadnotas.dias = Integer.Parse(Txtndias.Text)
            entidadnotas.fecha = ldfecven
            entidadnotas.nota = Txtnota.Text.Trim

            Try
                enotas.Agregar(entidadnotas)
                'Response.Write("<script language='javascript'>alert('Nota Grabada')</script>")

                codigoJs = "<script language='javascript'>alert('Nota Grabada, " & _
                           "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Catch ex As Exception
                'Response.Write("<script language='javascript'>alert('Ocurrio un Error')</script>")
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                            "Advertencia SIM.NET ')</script>"

                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            End Try


        Else 'no procede
            CargarNota()
            'Response.Write("<script language='javascript'>alert('Tiene una nota vigente')</script>")
            codigoJs = "<script language='javascript'>alert('Tiene una nota vigente, " & _
                                     "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

    End Sub

    Protected Sub btnmodificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim entidadnotas As New notas
        Dim enotas As New cNotas

        Dim ldfecven As Date
        ldfecven = DateAdd(DateInterval.Day, Integer.Parse(Txtndias.Text), Session("gdfecsis"))

        entidadnotas.ccodcta = txtccodcta.Text.Trim
        entidadnotas.ccodcli = txtccodcli.Text.Trim
        entidadnotas.dias = Integer.Parse(Txtndias.Text)
        entidadnotas.fecha = ldfecven
        entidadnotas.nota = Txtnota.Text.Trim
        Try
            enotas.ActualizarNotas(entidadnotas)
            codigoJs = "<script language='javascript'>alert('Nota Grabada, " & _
                           "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)

        Catch ex As Exception
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                                   "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
        End Try

    End Sub
End Class
