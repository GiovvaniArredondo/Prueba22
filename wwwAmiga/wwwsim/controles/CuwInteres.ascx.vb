

Partial Class CuwInteres
    Inherits ucWBase
    Private ds As New DataSet

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub
    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        Me.txtccodcta.Text = codcta
        Dim ecreditos As New ccreditos
        Dim dscre As New DataSet
        dscre = ecreditos.CreTraslado(codcta)
        If dscre.Tables(0).Rows.Count = 0 Then
            Me.cbxtraslado.Disabled = True
            Return
        Else
            Me.cbxtraslado.Disabled = False
            Dim ncanti As Integer = 0
            Dim pnsalcap As Double = 0
            Dim pnsalint As Double = 0
            Dim pnsalmor As Double = 0
            Dim pndiaatr As Integer = 0
            Dim fila As DataRow
            For Each fila In dscre.Tables(0).Rows
                Me.txtccodcli.Text = dscre.Tables(0).Rows(ncanti)("ccodcli")
                Me.txtcnomcli.Text = dscre.Tables(0).Rows(ncanti)("cnomcli")
                Me.txtcnomana.Text = dscre.Tables(0).Rows(ncanti)("cnomusu")
                Me.txtccondic.Text = dscre.Tables(0).Rows(ncanti)("condicion")
                Me.txtnsalcap.Text = dscre.Tables(0).Rows(ncanti)("nsalcap")
                pnsalcap = dscre.Tables(0).Rows(ncanti)("nsalcap")
                Me.txtnsalint.Text = dscre.Tables(0).Rows(ncanti)("nsalint")
                pnsalint = dscre.Tables(0).Rows(ncanti)("nsalint")
                Me.txtnsalmor.Text = dscre.Tables(0).Rows(ncanti)("nsalmor")
                pnsalmor = dscre.Tables(0).Rows(ncanti)("nsalmor")
                pndiaatr = dscre.Tables(0).Rows(ncanti)("ndiaatr")
                Me.txtndiaatr.Text = IIf(pndiaatr > 0, pndiaatr, 0)
                Me.txtntotal.Text = pnsalcap + pnsalint + pnsalmor
                Me.txtcondicion.Text = dscre.Tables(0).Rows(ncanti)("ccondic")
                Me.txtcestado.Text = dscre.Tables(0).Rows(ncanti)("cestado")
                Me.txtccodlin.Text = dscre.Tables(0).Rows(ncanti)("ccodlin")
                ncanti = ncanti + 1
            Next
        End If
    End Sub
    Sub CargarDatos()
        Dim etabttab As New cTabttab
        ds = etabttab.TablasTab("046", "V")
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxtraslado.DataTextField = "cdescri"
        Me.cbxtraslado.DataValueField = "cCodigo"
        Me.cbxtraslado.DataSource = ds.Tables(0)
        Me.cbxtraslado.DataBind()
        Me.TXTFECPRO.Text = Session("gdfecsis")
        Me.lblmensaje.Text = ""

        Me.txtccodcli.Text = ""
        Me.txtcnomcli.Text = ""
        Me.txtcnomana.Text = ""
        Me.txtccondic.Text = ""
        Me.txtnsalcap.Text = 0
        Me.txtnsalint.Text = 0
        Me.txtnsalmor.Text = 0
        Me.txtndiaatr.Text = 0
        Me.txtntotal.Text = 0
        Me.txtcondicion.Text = ""
        Me.txtcestado.Text = ""
        Me.txtccodcta.Text = ""
    End Sub

    Private Sub btnaplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        Dim pcnewcondic As String
        Dim pccondic As String
        Dim lnGrabar As Integer = 0
        Dim lnPartida As Integer = 0
        pccondic = Me.txtcondicion.Text.Trim
        pcnewcondic = Me.cbxtraslado.Value
        If Me.txtcestado.Text.Trim <> "F" Then
            Me.lblmensaje.Text = "Crédito No esta Vigente"
            lnGrabar = 0
            Return
        End If

        If pccondic = "N" And pcnewcondic = "N" Then  'De Normal a Normal
            Me.lblmensaje.Text = "Crédito No puede ser Trasladado"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "P" And pcnewcondic = "P" Then 'De Prejud a Prejud
            Me.lblmensaje.Text = "Crédito esta en Cobranza Pre-Judicial"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "J" And pcnewcondic = "J" Then 'De Judicial a Judicial
            Me.lblmensaje.Text = "Crédito esta en Cobranza Judicial"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "P" And pcnewcondic = "N" Then   'OK De Normal a Prejudicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        ElseIf pccondic = "N" And pcnewcondic = "P" Then   'OK De PreJudicial  a Normal
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        ElseIf pccondic = "S" And pcnewcondic = "S" Then  'De Saneado a Saneado
            Me.lblmensaje.Text = "Crédito esta en Cartera Saneada"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "V" And pcnewcondic = "S" Then  'OK De vencido a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
        ElseIf pccondic = "S" And (pcnewcondic = "N" Or pcnewcondic = "P" Or pcnewcondic = "J") Then  'De Saneado a Otros
            Me.lblmensaje.Text = "Crédito esta en Cartera Saneada"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "N" And pcnewcondic = "J" Then   'OK De Normal a judicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        ElseIf pccondic = "N" And pcnewcondic = "S" Then   'De Normal a Saneado
            Me.lblmensaje.Text = "Crédito no esta VEecido"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "P" And pcnewcondic = "S" Then   'De Pre judicial a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
        ElseIf pccondic = "J" And pcnewcondic = "S" Then   'De judicial a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
        ElseIf pccondic = "J" And pcnewcondic = "P" Then   'OK De judicial a prejudicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        ElseIf pccondic = "J" And pcnewcondic = "N" Then   'OK De judicial a normal
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        End If
        If lnPartida = 1 Then
            Partida()
        End If

        If lnGrabar = 1 Then
            Dim lnvalida As Integer
            Dim entidadCreditos As New creditos
            Dim eCreditos As New SIM.BL.ccreditos
            entidadCreditos.ccondic = pcnewcondic
            entidadCreditos.ccontra = pcnewcondic
            entidadCreditos.dfectra = Me.TXTFECPRO.Text
            entidadCreditos.ccodcta = Me.txtccodcta.Text.Trim
            lnvalida = eCreditos.Trasladar(entidadCreditos)
            If lnvalida = 1 Then
                Response.Write("<script language='javascript'>alert('Traslado Correcto')</script>")
            Else
                Response.Write("<script language='javascript'>alert('Traslado no se realizo')</script>")
            End If
            Me.CargarDatos()
        End If
       
    End Sub
    Sub Partida()
        'cremcre
        Dim lcnorref As String
        Dim lccodfue As String
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre
        entidad1.ccodcta = Me.txtccodcta.Text.Trim
        ecreditos.ObtenerCremcre(entidad1)

        lcnorref = entidad1.cnorref
        lccodfue = entidad1.ccodfue


        Dim clsctb As New ClsAdPart
        clsctb._pccodcta = Me.txtccodcta.Text.Trim
        clsctb._pdfecsis = Session("gdfecsis")
        clsctb._nSalTra = Me.txtnsalcap.Text
        clsctb._pccodfue = lccodfue
        clsctb._pcnorref = lcnorref
        clsctb._pccondic = Me.txtcondicion.Text.Trim
        clsctb._pcnuming = ""
        clsctb._pccodlin = Me.txtccodlin.Text
        clsctb._pccodusu = Session("gccodusu")
        clsctb.PartidaTraslado()
    End Sub
End Class


