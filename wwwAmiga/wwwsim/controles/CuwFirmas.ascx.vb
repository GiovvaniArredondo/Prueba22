Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Public Class CuwFirmas
    Inherits System.Web.UI.UserControl
    Private Shared cuenta As String

    Private Transacc As String
    Private _URLCodigo As String
    Private _lineaSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)
    Private clsCli As New SIM.BL.ClsFindCli

    Private _ClienteSeleccionado As String
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
            Me.txtcodcli.Text = Session("codigo")
            limpiar()
        End If

    End Sub
    Public Sub CargarPorcuentahorro(ByVal ccodaho As String)
        Me.txtcodcli.Text = Session("codigo")
        Dim lccodcli As String = ""
        lccodcli = Session("fuente")
        limpiar()

        Dim eahomfir As New cAhomfir
        Dim entidadahomfir As New Ahomfir
        Dim i As Integer = 0

        entidadahomfir.ccodaho = txtcodcli.Text.Trim
        i = eahomfir.ObtenerAhomfir(entidadahomfir)

        If i = 0 Then
            Exit Sub
        End If

        TextBox7.Text = entidadahomfir.cnomgfir2.Trim
        TextBox42.Text = entidadahomfir.cnomgfir3.Trim

        If TextBox7.Text.Trim = "" Then
        Else
            TextBox38.Text = entidadahomfir.dnacgfir2
            TextBox41.Text = entidadahomfir.cdui2
        End If
        If TextBox42.Text.Trim = "" Then
        Else
            TextBox43.Text = entidadahomfir.dnacgfir3
            TextBox44.Text = entidadahomfir.cdui3
        End If



    End Sub


    Private Sub limpiar()
        TextBox7.Text = ""
        TextBox38.Text = Session("gdfecsis")
        TextBox41.Text = ""

        TextBox42.Text = ""
        TextBox43.Text = Session("gdfecsis")
        TextBox44.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim entidadahomfir As New Ahomfir
        Dim eahomfir As New cAhomfir
        Dim lccodcli As String = ""
        Dim i As Integer = 0

        Dim eahomcta As New cAhomcta
        Dim entidadahomcta As New ahomcta

        entidadahomcta.ccodaho = Me.txtcodcli.Text.Trim
        eahomcta.ObtenerAhomcta(entidadahomcta)

        lccodcli = Session("fuente")

        Dim entidadclimide As New climide
        Dim eclimide As New cClimide

        entidadclimide.ccodcli = lccodcli.Trim
        eclimide.ObtenerClimide(entidadclimide)

        Me.TextBox45.Text = entidadclimide.cnomcli.Trim
        Me.TextBox46.Text = entidadclimide.dnacimi
        Me.TextBox47.Text = entidadclimide.cnudoci

        'Verifica si ya existe para reemplazar
        entidadahomfir.ccodaho = Me.txtcodcli.Text.Trim

        i = eahomfir.ObtenerAhomfir(entidadahomfir)

        entidadahomfir.nlibreta = 0
        entidadahomfir.nmanco = 0
        entidadahomfir.cnomau = ""

        entidadahomfir.cnomgfir = Me.TextBox45.Text.Trim
        entidadahomfir.cnomgfir2 = TextBox7.Text.Trim
        entidadahomfir.cnomgfir3 = TextBox42.Text.Trim
        entidadahomfir.dnacgfir = Date.Parse(TextBox46.Text)
        entidadahomfir.dnacgfir2 = Date.Parse(TextBox38.Text)
        entidadahomfir.dnacgfir3 = Date.Parse(TextBox43.Text)
        entidadahomfir.cdui1 = Me.TextBox47.Text.Trim
        entidadahomfir.cdui2 = Me.TextBox41.Text.Trim
        entidadahomfir.cdui3 = Me.TextBox44.Text.Trim

        Try
            If i = 0 Then ' Agregar
                eahomfir.Agregar(entidadahomfir)
            Else 'Actualizar
                eahomfir.ActualizarAhomfir(entidadahomfir)
            End If


            Response.Write("<script language='javascript'>alert('Firmas Guardadas')</script>")

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Ocurrio un problema')</script>")
        End Try

    End Sub
End Class
