Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class cuwReApertura
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
            ds = eusuarios.ObtenerCajeros()


            Me.cmbcajeros.DataTextField = "nombre"
            Me.cmbcajeros.DataValueField = "usuario"
            Me.cmbcajeros.DataSource = ds
            Me.cmbcajeros.DataBind()



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
        lprocede = ecredkar.VerificaProcedeReapertura(cmbcajeros.SelectedValue.Trim, "A", Date.Parse(Txtdfecha.Text))
        Dim eusuarios As New cusuarios
        If lprocede = True Then
            Try
                'Verifica si ya abrio caja en el dia
                lprocede = ecredkar.VerificaAperturaCaja(cmbcajeros.SelectedValue.Trim, Date.Parse(Txtdfecha.Text))
                If lprocede = False Then 'no se aperturo caja de ese dia
                    Response.Write("<script language='javascript'>alert('Caja No se ha Cerrado ')</script>")
                    Exit Sub
                End If
                '----------------------------------------------------------------------------------------------------------------------------------------
                ecredkar.ReaperturaCaja(cmbcajeros.SelectedValue.Trim, Date.Parse(Txtdfecha.Text))
                'Actualiza cajero
                eusuarios.ActualizaCajero(cmbcajeros.SelectedValue.Trim, 1)
                Response.Write("<script language='javascript'>alert('Se ReAperturo Caja para Usuario')</script>")
            Catch ex As Exception
                Response.Write("<script language='javascript'>alert('Error al Aperturar')</script>")
            End Try

        Else
            Response.Write("<script language='javascript'>alert('No ha Cerrado Caja')</script>")
        End If

        
    End Sub
End Class


