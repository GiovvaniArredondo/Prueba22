Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Public Class Cuwbusaho
    Inherits System.Web.UI.UserControl
    Private Shared cuenta As String

    Private Transacc As String
    Private _URLCodigo As String
    Private _lineaSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)
    Private clsCli As New SIM.BL.ClsFindCli
    Private codigoJs As String
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
        TextBox1.Text = Session("gcbuscli")
        If Page.IsPostBack = False Then
            asociado_TextBox.Focus()
        End If
    End Sub

    'Protected Sub asociados_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociados_GridView.SelectedIndexChanged
    '    Dim asociado As String = asociados_GridView.SelectedRow.Cells(1).Text.ToString 'asociado
    '    Session("fuente") = asociado
    '    Dim miclase As New clase_jaime()
    '    Dim ds As DataSet
    '    Dim con As New SqlConnection
    '    Dim stringconnection As String = miclase.conexion()

    '    con.ConnectionString = stringconnection
    '    con.Open()
    '    ds = miclase.buscar_ctas_ahorro(con, asociado.ToString, 1)
    '    con.Close()

    '    cuentas_GridView.DataSource = ds
    '    cuentas_GridView.DataBind()
    '    cuentas_GridView.Visible = True


    '    foto_firma(asociado)

    'End Sub

    Protected Sub cuentas_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cuentas_GridView.SelectedIndexChanged
        cuenta = cuentas_GridView.SelectedRow.Cells(1).Text.ToString 'cuenta de ahorro
        Session("codigo") = cuenta.Trim
        RaiseEvent Seleccionado(cuenta)

    End Sub

    Protected Sub foto_firma(ByVal asociado As String)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, 1)
        If huella1 <> "basura" Then
            foto_Image.Height = 75
            foto_Image.Width = 100
            foto_Image.ImageUrl = huella1
            foto_Image.Visible = True
        End If

    End Sub

    'Protected Sub asociado_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociado_TextBox.TextChanged
    '    Buscar()
    'End Sub

    Private Sub Buscar()
        foto_Image.Visible = False
        cuentas_GridView.Visible = False


        Label3.Visible = False
        'Dim ds As DataSet
        'Dim miclase As New clase_jaime
        'Dim con As New SqlConnection
        'Dim stringconnection As String = miclase.conexion()

        'con.ConnectionString = stringconnection
        'con.Open()

        'ds = miclase.buscar_asociado(con, asociado_TextBox.Text.Trim.ToUpper)
        'con.Close()

        ''asociados_GridView.DataSource = ds
        ''asociados_GridView.DataBind()
        ''asociados_GridView.Visible = True

        'GridViewDatos.DataSource = ds
        'GridViewDatos.DataBind()
        'GridViewDatos.Visible = True


        Dim asociado As String = asociado_TextBox.Text.Trim
        Dim ds_find As New DataSet
        Dim occlass_cli As New cClimide
        Dim lntipo As Integer = 1

        Dim letra As Char = Left(asociado, 1)

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            lntipo = 3
        End If


        ds_find = occlass_cli.Extraer_Datos_Socio(lntipo, asociado)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        GridViewDatos.DataSource = ds_find
        GridViewDatos.DataBind()

        If GridViewDatos.Rows.Count = 0 Then
            Label3.Visible = True
        End If
        cuenta = Nothing
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Session("gcbuscli") = Me.asociado_TextBox.Text.Trim
        Buscar()
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        asociado_TextBox.Text = TextBox1.Text.Trim
        ImageButton1_Click(sender, e)
    End Sub

    Protected Sub GridViewDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewDatos.SelectedIndexChanged
        Dim asociado As String = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado 
        'asociados_GridView.SelectedRow.Cells(1).Text.ToString() 'asociado
        Session("fuente") = asociado
        Dim miclase As New clase_jaime()
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        ds = miclase.buscar_ctas_ahorro(con, asociado.ToString, 1)
        con.Close()

        cuentas_GridView.DataSource = ds
        cuentas_GridView.DataBind()
        cuentas_GridView.Visible = True

        foto_firma(asociado)

    End Sub


    Protected Sub GridViewDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridViewDatos.PageIndexChanging
        GridViewDatos.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridViewDatos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridViewDatos.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridViewDatos.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridViewDatos.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridViewDatos.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridViewDatos.PageIndex + 1
        End If
    End Sub


    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
                GridViewDatos.PageIndex = iNumPag - 1
            Else
                GridViewDatos.PageIndex = 0
            End If
        End If
        Call Buscar()
    End Sub

    Protected Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Dim asociado As String = asociado_TextBox.Text.Trim
        Dim ds_find As New DataSet
        Dim occlass_cli As New cClimide
        Dim lntipo As Integer = 1

        Dim letra As Char = Left(asociado, 1)

        If letra = "1" Or letra = "2" Or letra = "3" Or letra = "4" Or letra = "5" Or letra = "6" Or letra = "7" Or letra = "8" Or letra = "9" Or letra = "0" Then
            lntipo = 3
        End If


        ds_find = occlass_cli.Extraer_Datos_Socio(lntipo, asociado)


        If ds_find.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No existen Datos, " & _
                                 "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Response.Write("<script language='javascript'>alert('No existen Datos, " & _
            '              "Advertencia SIM.NET ')</script>")
            Exit Sub
        End If


        GridViewDatos.DataSource = ds_find
        GridViewDatos.DataBind()

    End Sub
End Class
