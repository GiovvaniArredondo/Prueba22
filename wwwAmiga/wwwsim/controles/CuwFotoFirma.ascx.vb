Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Public Class CuwFotoFirma
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
            foto(txtcodcli.Text.Trim, 1)
            firma(txtcodcli.Text.Trim, 2)

            Label1.Text = "Nº de Asociado " & Me.txtcodcli.Text.Trim


            Dim eclimide As New cClimide
            Dim entidadclimide As New climide
            entidadclimide.ccodcli = Me.txtcodcli.Text.Trim
            eclimide.ObtenerClimide(entidadclimide)
            Label2.Text = entidadclimide.cnomcli.Trim
            Label3.Text = "Nº de Dui " & entidadclimide.cnudoci

            Label4.Text = entidadclimide.cdirdom.Trim


        End If

    End Sub


    Protected Sub foto(ByVal asociado As String, ByVal cual As Integer)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, cual)
        If huella1 <> "basura" Then
            foto_Image.Height = 423
            foto_Image.Width = 360
            foto_Image.ImageUrl = huella1
            foto_Image.Visible = True
        End If

    End Sub

    Protected Sub firma(ByVal asociado As String, ByVal cual As Integer)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, cual)
        If huella1 <> "basura" Then
            firma_Image.Height = 138
            firma_Image.Width = 432
            firma_Image.ImageUrl = huella1
            firma_Image.Visible = True
        End If

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        titular()
    End Sub


    Private Sub titular()
        Dim eahomfir As New cAhomfir
        Dim entidadahomfir As New Ahomfir

        entidadahomfir.ccodaho = Trim(Session("fuente"))
        eahomfir.ObtenerAhomfir(entidadahomfir)

        If entidadahomfir.cnomgfir Is Nothing Then
            Exit Sub
        End If

        Label2.Text = IIf(IsDBNull(entidadahomfir.cnomgfir.Trim), "", entidadahomfir.cnomgfir.Trim)
        Label3.Text = "Nº de Dui " & IIf(IsDBNull(entidadahomfir.cdui1), "", entidadahomfir.cdui1)

        foto(txtcodcli.Text, 1)
        firma(txtcodcli.Text, 2)


    End Sub
    Private Sub segundo()
        Dim eahomfir As New cAhomfir
        Dim entidadahomfir As New Ahomfir

        entidadahomfir.ccodaho = Trim(Session("fuente"))
        eahomfir.ObtenerAhomfir(entidadahomfir)

        If entidadahomfir.cnomgfir2 Is Nothing Then
            Exit Sub
        End If
        Label2.Text = IIf(IsDBNull(entidadahomfir.cnomgfir2.Trim), "", entidadahomfir.cnomgfir2.Trim)
        Label3.Text = "Nº de Dui " & IIf(IsDBNull(entidadahomfir.cdui2), "", entidadahomfir.cdui2)

        foto(txtcodcli.Text & "-1", 1)
        firma(txtcodcli.Text & "-1", 2)


    End Sub

    Private Sub tercero()
        Dim eahomfir As New cAhomfir
        Dim entidadahomfir As New Ahomfir

        entidadahomfir.ccodaho = Trim(Session("fuente"))
        eahomfir.ObtenerAhomfir(entidadahomfir)
        If entidadahomfir.cnomgfir3 Is Nothing Then
            Exit Sub
        End If

        Label2.Text = IIf(IsDBNull(entidadahomfir.cnomgfir3.Trim), "", entidadahomfir.cnomgfir3.Trim)
        Label3.Text = "Nº de Dui " & IIf(IsDBNull(entidadahomfir.cdui3), "", entidadahomfir.cdui3)

        foto(txtcodcli.Text & "-2", 1)
        firma(txtcodcli.Text & "-2", 2)


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        segundo()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        tercero()
    End Sub
End Class
