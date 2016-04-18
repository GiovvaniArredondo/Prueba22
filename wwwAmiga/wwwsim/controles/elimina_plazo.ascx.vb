Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections

Public Class elimina_plazo
    Inherits System.Web.UI.UserControl
    Private Shared asociado As String
    Private Shared certificado As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            asociado_TextBox.Focus()
            If Session("gcbuscli") Is Nothing Then
                Session("gcbuscli") = ""
            End If
        End If
    End Sub

    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscar_Button.Click
        Session("gcbuscli") = asociado_TextBox.Text.Trim
        foto_image.Visible = False
        mensaje.Visible = False
        plazos_GridView.Visible = False
        eliminar_Button.Visible = False
        nombre_Label.Visible = False
        monto_Label.Visible = False
        plazo_Label.Visible = False
        tasa_Label.Visible = False
        fec_apertura_Label.Visible = False
        cta_ahorro_Label.Visible = False

        nombre_TextBox.Visible = False
        monto_TextBox.Visible = False
        plazo_TextBox.Visible = False
        tasa_TextBox.Visible = False
        fec_apertura_TextBox.Visible = False
        cta_ahorro_TextBox.Visible = False

        Dim ds As DataSet
        Dim miclase As New clase_especial
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.buscar_asociado(con, asociado_TextBox.Text.Trim.ToUpper)
        con.Close()

        asociados_GridView.DataSource = ds
        asociados_GridView.DataBind()
        asociados_GridView.Visible = True

        If asociados_GridView.Rows.Count = 0 Then
            mensaje.Text = "No existen concordancias!!!"
            mensaje.Visible = True
        End If

    End Sub
    Private Sub CargarGrid2()
        asociado = asociados_GridView.SelectedRow.Cells(1).Text.ToString 'asociado

        Dim miclase As New clase_especial
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "select ccodcrt, nombre, nsaldoaho, nplazo, ntasint, dfecapr, dfecven, ccodaho from ahomcrt " & _
                         "where cnudotr = '" & asociado & "' and cliq <> 'S' and nmonapr = 0 order by ccodcrt"

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        plazos_GridView.DataSource = ds
        plazos_GridView.DataBind()
        plazos_GridView.Visible = True

        foto_firma(asociado)

    End Sub
    Protected Sub asociados_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociados_GridView.SelectedIndexChanged
        CargarGrid2()
    End Sub

    Protected Sub plazos_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plazos_GridView.SelectedIndexChanged

        plazos_GridView.Visible = True
        eliminar_Button.Visible = True
        nombre_Label.Visible = True
        monto_Label.Visible = True
        plazo_Label.Visible = True
        tasa_Label.Visible = True
        fec_apertura_Label.Visible = True
        cta_ahorro_Label.Visible = True

        nombre_TextBox.Visible = True
        monto_TextBox.Visible = True
        plazo_TextBox.Visible = True
        tasa_TextBox.Visible = True
        fec_apertura_TextBox.Visible = True
        cta_ahorro_TextBox.Visible = True

        certificado = plazos_GridView.SelectedRow.Cells(1).Text
        nombre_TextBox.Text = plazos_GridView.SelectedRow.Cells(2).Text
        monto_TextBox.Text = plazos_GridView.SelectedRow.Cells(3).Text
        plazo_TextBox.Text = plazos_GridView.SelectedRow.Cells(4).Text
        tasa_TextBox.Text = plazos_GridView.SelectedRow.Cells(5).Text
        fec_apertura_TextBox.Text = Left(plazos_GridView.SelectedRow.Cells(6).Text.ToString, 10)
        cta_ahorro_TextBox.Text = plazos_GridView.SelectedRow.Cells(8).Text

        eliminar_Button.Visible = True


        nombre_TextBox.Focus()


    End Sub


    Protected Sub eliminar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles eliminar_Button.Click
        Dim ccodusu As String = Session("gccodusu")
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones()
        Dim error100 As Integer = 0
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim nmonapr As Decimal = Decimal.Parse(monto_TextBox.Text)
        Dim nombre As String = nombre_TextBox.Text.ToUpper
        Dim plazo As Decimal = Integer.Parse(plazo_TextBox.Text)
        Dim tasa As Decimal = Decimal.Parse(tasa_TextBox.Text)
        Dim fec1 As Date = Date.Parse(fec_apertura_TextBox.Text)
        Dim fec2 As Date = DateAdd(DateInterval.Day, plazo, fec1)
        Dim fec10 As String = fec1
        Dim fec11 As String = fec2
        Dim ccodaho As String = cta_ahorro_TextBox.Text.Trim
        Dim str_select As String = ""
        con.ConnectionString = stringconnection
        con.Open()

        str_select = "SET LANGUAGE spanish; begin tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no eliminado"
            mensaje.Visible = True
            eliminar_Button.Visible = False
            con.Close()
            Return
        End If
        str_select = "insert into anulados " & _
                     "(ccodcrt,cnrolin,nombre,cnudotr,ccodaho,nmonapr,nplazo,nintere,dfecapr," & _
                     "dfecven, dfecprv,dfecori,dfecliq,ndiagra,ccalint," & _
                     "cprvint,ccodbco,cctacte,ccapita,cpignor,ccodcta,dfecmod," & _
                     "ccodusu,cprovis,cliq,nsaldoaho,dfeccap,ccodcli,cestado,producto) values " & _
                     "('" & certificado & "',' ','" & nombre & "', '" & asociado & "',' '," & nmonapr & ",0,0,'" & fec10 & "'," & _
                     "'" & fec11 & "', '01/01/2011', '01/01/2011', '01/01/2011', 0, ' '," & _
                     "' ',' ',' ',' ',' ',' ','01/01/2011'," & _
                     "'" & ccodusu & "',' ',' ',0,'01/01/2011',' ',' ',' ')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no eliminado"
            mensaje.Visible = True
            eliminar_Button.Visible = False
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        str_select = "delete ahomcrt where ccodcrt = '" & certificado & "'"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no eliminado"
            mensaje.Visible = True
            eliminar_Button.Visible = False
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If
        str_select = "commit tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no eliminado"
            mensaje.Visible = True
            eliminar_Button.Visible = False
            str_select = "rollback tran"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        con.Close()
        'mensaje.Text = "Certificado Anulado..."
        Response.Write(miclase1.mensaje("Certificado Anulado..."))
        'mensaje.Visible = True
        eliminar_Button.Visible = False
        CargarGrid2()
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
    Protected Sub repetir_ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles repetir_ImageButton.Click
        asociado_TextBox.Text = Session("gcbuscli").ToString.Trim
        buscar_Button_Click(sender, e)
    End Sub

End Class
