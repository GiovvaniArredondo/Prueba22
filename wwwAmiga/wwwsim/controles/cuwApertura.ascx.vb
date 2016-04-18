Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web


Partial Class cuwApertura
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
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

            'Verifica si usuario es supervisor de cajero
            If IsDBNull(entidadusuarios.lesapod) Then
                Button1.Enabled = False
                Response.Write("<script language='javascript'>alert('Usuario no Puede Aperturar Caja')</script>")
            Else
                If entidadusuarios.lesapod = 0 Then
                    Button1.Enabled = False
                    Response.Write("<script language='javascript'>alert('Usuario no Puede Aperturar Caja')</script>")
                Else
                    Button1.Enabled = True
                End If
            End If

            'lista los cajeros
            Dim ds As New DataSet
            ds = eusuarios.ObtenerCajerosAgencias(Session("gccodofi"))


            Me.cmbcajeros.DataTextField = "nombre"
            Me.cmbcajeros.DataValueField = "usuario"
            Me.cmbcajeros.DataSource = ds
            Me.cmbcajeros.DataBind()


            CargaSaldoInicial()
        End If
    End Sub
    Private Sub CargaSaldoInicial()
        Dim ecredkar As New cCredkar
        Dim lnsaldo As Decimal = 0
        'Obtener Saldo segun Arqueo
        Dim ldfecha As Date
        ldfecha = ecredkar.ObtieneFechaCajaAnterior(cmbcajeros.SelectedValue.Trim, Date.Parse(Txtdfecha.Text))
        If ldfecha = Date.Parse(Txtdfecha.Text) Then
            txtnsalini.Text = 0
        Else
            lnsaldo = ecredkar.ObtenerSaldoArqueo(cmbcajeros.SelectedValue.Trim, ldfecha)
            txtnsalini.Text = Math.Round(lnsaldo, 2)

        End If

    End Sub
    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Verifica si ya esta validada la agencia
        Dim etabtofi As New cTabtofi
        Dim eusuarios As New cusuarios
        Dim lccodofi As String

        lccodofi = eusuarios.Oficina(cmbcajeros.SelectedValue.Trim)
        If etabtofi.VerificaValidacionAgencia(lccodofi) = True Then
            Response.Write("<script language='javascript'>alert('Agencia ya fue Validada ')</script>")
            Exit Sub
        End If


        'Graba Aperturao
        Dim ecredkar As New cCredkar
        Dim lchora As String = TimeOfDay.ToString.Substring(11, 12).Replace(".", "").ToUpper
        Dim lcfecha As String
        Dim ldfecha As DateTime
        Dim lprocede As Boolean
        lcfecha = "#" & Txtdfecha.Text.Trim & " " & lchora & "#"

        ldfecha = DateTime.Parse(lcfecha)
        lprocede = ecredkar.VerificaProcedeCaja(cmbcajeros.SelectedValue.Trim, "A")

        If lprocede = True Then
            Try
                'Verifica si ya abrio caja en el dia
                lprocede = ecredkar.VerificaAperturaCaja(cmbcajeros.SelectedValue.Trim, Date.Parse(Txtdfecha.Text))
                If lprocede = True Then 'ya se aperturo caja de ese dia
                    Response.Write("<script language='javascript'>alert('Caja ya se Aperturo una vez en el Día para Cajero ')</script>")
                    Exit Sub
                End If
                '----------------------------------------------------------------------------------------------------------------------------------------
                ecredkar.AgregaraCaja(cmbcajeros.SelectedValue.Trim, Decimal.Parse(txtnsalini.Text), ldfecha, "A", "", "", Session("gccodusu"))
                'Actualiza cajero
                eusuarios.ActualizaCajero(cmbcajeros.SelectedValue.Trim, 1)
                Response.Write("<script language='javascript'>alert('Se Aperturo Caja para Usuario')</script>")
            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('Error al Aperturar')</script>")
            End Try

        Else
            Response.Write("<script language='javascript'>alert('No ha Cerrado Caja')</script>")
        End If

        
    End Sub

   
    Protected Sub cmbcajeros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcajeros.SelectedIndexChanged
        CargaSaldoInicial()
    End Sub
End Class


