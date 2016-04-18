Imports System.Data.SqlClient

Partial Class controles_ucCambiaFondoPartida
    Inherits System.Web.UI.UserControl

    'Dim cnConexion As SqlConnection
    Dim strCadena As String



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarDatos()
        End If
    End Sub

    Private Function LlenaComboFondo() As Integer
    End Function

    Private Sub CargarDatos()
        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm
        Dim ds As New DataSet
        Dim ncanti As Integer
        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If        

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab1 As New listatabttab
        mListaTabttab1 = clstabttab.ObtenerLista("033", "1")
        'Fondos
        Me.DropDownListFondos.DataTextField = "cdescri"
        Me.DropDownListFondos.DataValueField = "ccodigo"
        Me.DropDownListFondos.DataSource = mListaTabttab1
        Me.DropDownListFondos.DataBind()

    End Sub

    Protected Sub ButtonCambiarFondo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCambiarFondo.Click
        Dim sqlComando As New SqlCommand

        Try

            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("fondesolConnectionString2").ConnectionString)
                cnConexion.Open()

                strCadena = " update cntamov " & _
                " set ffondos='" + DropDownListFondos.SelectedValue + "'" & _
                " where cnumcom='" + TextBoxNumeroPartida.Text + "'"

                sqlComando.CommandText = strCadena
                sqlComando.Connection = cnConexion
                sqlComando.ExecuteNonQuery()

                strCadena = " update auxiliar " & _
                " set ffondos='" + DropDownListFondos.SelectedValue + "'" & _
                " where cnumcom='" + TextBoxNumeroPartida.Text + "'" 

                sqlComando.CommandText = strCadena
                sqlComando.Connection = cnConexion
                sqlComando.ExecuteNonQuery()

            End Using
            Response.Write("<script language='javascript'>alert('Fondo Cambiado')</script>")
        Catch sqlex As SqlException
            Response.Write("<script language='javascript'>alert('Fondo Cambiado')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('No se efectuo el Cambio')</script>")
        End Try
    End Sub
End Class
