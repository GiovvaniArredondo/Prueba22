Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class cuwCierreCaj
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim idusuario As Integer
            Dim eusuarios As New cusuarios
            Dim entidadusuarios As New usuarios
            Txtdfecha.Text = Session("gdfecsis")
            txtnsalini.Text = 0
            idusuario = eusuarios.IdUsuario(Session("gccodusu"))

            entidadusuarios.idUsuario = idusuario
            eusuarios.Obtenerusuarios(entidadusuarios)
            txtccajero.Text = entidadusuarios.nombre.Trim

            'Obtener Saldo segun Arqueo
            Dim ecredkar As New cCredkar
            Dim lnsaldo As Decimal = 0
            lnsaldo = ecredkar.ObtenerSaldoArqueo(Session("gccodusu"), Date.Parse(Txtdfecha.Text))
            txtnsalini.Text = Math.Round(lnsaldo, 2)
        End If
    End Sub

    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Verifica si tiene alguna apertura sin cierre 

        'Graba Aperturao
        Dim ecredkar As New cCredkar
        Dim lchora As String = TimeOfDay.ToString.Substring(11, 12).Replace(".", "").ToUpper
        Dim lcfecha As String
        Dim ldfecha As DateTime
        Dim lprocede As Boolean
        lcfecha = "#" & Txtdfecha.Text.Trim & " " & lchora & "#"

        ldfecha = DateTime.Parse(lcfecha)
        lprocede = ecredkar.VerificaProcedeCaja(Session("gccodusu"), "C")

        If lprocede = True Then
            Try
                ecredkar.AgregaraCaja(Session("gcCodusu"), Decimal.Parse(txtnsalini.Text), ldfecha, "C", "", "", Session("gccodusu"))
                'Actualiza cajero
                Dim eusuarios As New cusuarios
                eusuarios.ActualizaCajero(Session("gccodusu"), 0)
                Button1.Enabled = False
                Response.Write("<script language='javascript'>alert('Se Cerro Caja para Usuario')</script>")
            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('Error al Cerrar')</script>")
            End Try

        Else
            Response.Write("<script language='javascript'>alert('No se ha Abierto Caja')</script>")
        End If


    End Sub
End Class


