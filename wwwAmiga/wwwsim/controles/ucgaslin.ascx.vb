

Partial Class ucgaslin
    Inherits ucWBase

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        If Not IsPostBack Then
            CargarCombos()
        End If
    End Sub

    Public Sub CargarCombos()
        viewstate.Add("tipo", " ")
        viewstate("tipo") = Nothing

        Me.txtmonto.Text = 0
        Me.txtporcen.Text = 0

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab1 As New listatabttab
        Dim mListaTabttab2 As New listatabttab
        Dim mListaTabttab3 As New listatabttab
        Dim mListaTabttab4 As New listatabttab
        Dim mListaTabttab5 As New listatabttab

        mListaTabttab1 = clstabttab.ObtenerLista("008", "1")
        mListaTabttab2 = clstabttab.ObtenerLista("190", "1")
        mListaTabttab3 = clstabttab.ObtenerLista("191", "1")

        'gasto
        Me.ddlgasto.DataTextField = "cdescri"
        Me.ddlgasto.DataValueField = "ccodigo"
        Me.ddlgasto.DataSource = mListaTabttab1
        Me.ddlgasto.DataBind()

        'cuota
        Me.ddlcuota.DataTextField = "cdescri"
        Me.ddlcuota.DataValueField = "ccodigo"
        Me.ddlcuota.DataSource = mListaTabttab2
        Me.ddlcuota.DataBind()

        ' afectar a
        Me.ddlafecta.DataTextField = "cdescri"
        Me.ddlafecta.DataValueField = "ccodigo"
        Me.ddlafecta.DataSource = mListaTabttab3
        Me.ddlafecta.DataBind()

    End Sub

    Public Sub CargarPorlinea(ByVal cnrolin As String)
        Me.txtnrolin.Text = cnrolin
        Me.aplicar()
        '        Me.btnaplicar_ServerClick(Me, New System.EventArgs)
    End Sub

    Sub aplicar()
        Dim lcnrolin As String
        Dim cls1 As New cCretgas
        Dim ds As New DataSet
        Dim lccuota As String
        Dim lnmonto1 As Double
        Dim lcafecta As String
        Dim lcmonto As String
        Dim lcafecta2 As String
        Dim lccuota2 As String
        Dim dr As DataRow
        Dim lccodope As String
        Dim i As Integer
        Me.txtmonto.Text = 0
        Me.txtporcen.Text = 0

        lcnrolin = Me.txtnrolin.Text.Trim
        ds = cls1.Obtenerdatasetgastos(lcnrolin)
        'agrega las condiciones restantes del dataset
        i = 0
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                lccodope = dr("ccodope")
                lccuota = lccodope.Substring(0, 1)
                lcafecta = lccodope.Substring(2, 1)
                lcmonto = lccodope.Substring(1, 1)
                If lccuota = "1" Then
                    lccuota2 = "Todas las Cuotas"
                Else
                    lccuota2 = "Desembolso"
                End If
                If lcafecta = "1" Then
                    lcafecta2 = "Capital"
                ElseIf lcafecta = "2" Then
                    lcafecta2 = "Total de Cuota"
                ElseIf lcafecta = "3" Then
                    lcafecta2 = "Interés"
                ElseIf lcafecta = "4" Then
                    lcafecta2 = "Total Aprobado"
                ElseIf lcafecta = "5" Then
                    lcafecta2 = "Sobre Saldo"
                ElseIf lcafecta = "6" Then
                    lcafecta2 = "Distribuido en Cuota"
                End If
                ds.Tables(0).Rows(i)("Cuota") = lccuota2
                ds.Tables(0).Rows(i)("Afecta") = lcafecta2
                lnmonto1 = ds.Tables(0).Rows(i)("monto")
                If lcmonto = "1" Then
                    ds.Tables(0).Rows(i)("monto") = lnmonto1
                    ds.Tables(0).Rows(i)("porcen") = 0

                Else
                    ds.Tables(0).Rows(i)("porcen") = lnmonto1
                    ds.Tables(0).Rows(i)("monto") = 0

                End If

                i = i + 1
            Next
        End If

        Me.dgClientes.DataSource = ds
        Me.dgClientes.DataBind()

    End Sub


    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub txtmonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonto.TextChanged

    End Sub


    Private Sub dgclientes_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dgClientes.ItemCommand
        Dim lctipgas1 As String
        If e.CommandName = "Select" Then
            lctipgas1 = e.Item.Cells(6).Text
            viewstate("tipo") = lctipgas1
        End If
    End Sub

    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        Dim lcnrolin As String
        Dim lnmonto As Double
        Dim lctipgas As String
        Dim lccuota As String
        Dim lcafecta As String
        Dim lccodope As String
        Dim lcmonto As String
        Dim lnmonto2 As Double

        If Me.txtmonto.Text.Trim = Nothing Then
            Me.txtmonto.Text = 0
        End If
        If Me.txtporcen.Text.Trim = Nothing Then
            Me.txtporcen.Text = 0
        End If

        lcnrolin = Me.txtnrolin.Text
        lnmonto = Double.Parse(Me.txtmonto.Text)
        lctipgas = Me.ddlgasto.SelectedValue.Substring(0, 2)
        lccuota = Me.ddlcuota.SelectedValue.Substring(0, 1)
        lcafecta = Me.ddlafecta.SelectedValue.Substring(0, 1)
        lnmonto2 = Double.Parse(Me.txtporcen.Text)
        If Double.Parse(Me.txtmonto.Text) > 0 Then
            lcmonto = "1"
        Else
            lcmonto = "2"
        End If
        'arma ccodope
        lccodope = lccuota & lcmonto & lcafecta


        If (Me.txtmonto.Text.Trim <> Nothing Or Me.txtporcen.Text.Trim <> Nothing) And (Me.txtmonto.Text.Trim > 0 Or Me.txtporcen.Text.Trim > 0) Then
            Dim mcretgas As New cCretgas
            Dim ecretgas As New cretgas
            Dim i As Integer = 0
            ecretgas.cnrolin = lcnrolin
            ecretgas.dfecmod = Session("gdfecsis")
            ecretgas.lafeiva = True
            'verifica que si existe linea y gasto
            ecretgas.ctipgas = lctipgas
            ecretgas.ccodope = lccodope
            i = mcretgas.ObtenerCretgas(ecretgas)
            If i = 1 Then
                Response.Write("<script language='javascript'>alert('Ya existe gasto. No podra crearlo')</script>")
                Exit Sub
            End If

            If Double.Parse(Me.txtmonto.Text) > 0 Then
                ecretgas.nmonpor = lnmonto
            Else
                ecretgas.nmonpor = lnmonto2
            End If
            ecretgas.nincost = 0
            ecretgas.ccodope = lccodope
            ecretgas.ctipgas = lctipgas
            mcretgas.agregar(ecretgas)
            aplicar()
        End If

    End Sub

    Private Sub btnElimina_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.ServerClick
        Dim lcnrolin As String
        Dim lnmonto As Double
        Dim lctipgas As String
        Dim lccuota As String
        Dim lcafecta As String
        Dim lccodope As String
        Dim lcmonto As String
        Dim lnmonto2 As Double
        Dim dc As DataGridItem
        Dim laar() As String

        lcnrolin = Me.txtnrolin.Text.Trim
        If viewstate("tipo") = Nothing Then
            Response.Write("<script language='javascript'>alert('No ha elegido gasto')</script>")
            Exit Sub
        Else
            lctipgas = viewstate("tipo")
        End If
        Try
            Dim mcretgas As New cCretgas
            Dim ecretgas As New cretgas
            ecretgas.cnrolin = lcnrolin
            ecretgas.ctipgas = lctipgas
            mcretgas.EliminarCretgas(ecretgas)
            viewstate("tipo") = Nothing
            aplicar()

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Se no logro completar operacion')</script>")
        End Try

    End Sub

End Class


