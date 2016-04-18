Imports System.Data.SqlClient

Partial Class ucCambiaLineaI
    Inherits System.Web.UI.UserControl
    Dim entidadtabtmak As New tabtmak
    Dim etabtmak As New cTabtmak
    Dim busquedaplantilla As String = ""
    Dim lcctactb As String = ""
    Dim lcctactb1 As String = ""
    Dim cplanti As String = ""
    Dim lcmetodo As String = ""
    Dim lcmetodo1 As String = ""
    'Dim cnConexion As SqlConnection
    Dim strCadena As String
    Private cClsAdP As New ClsAdPart
    Dim clasefunc As New crefunc
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private cClsDes As New SIM.BL.clsDesembolsa
    Private Transacc As String
    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarDatos()
        End If
    End Sub

    Private Function LlenaComboFondo() As Integer
    End Function

    'Private Function CargaFechas() As Boolean
    '    Dim ecreditos As New ccreditos
    '    Dim ds As New DataSet
    '    ds = ecreditos.CargaFechas(Me.txtcCodsol.Text.Trim)

    '    If ds.Tables(0).Rows.Count = 0 Then
    '        Me.cbxFechas.Enabled = False
    '        Me.Button1.Enabled = False
    '        Return False
    '    Else
    '        'Me.cbxFechas.Enabled = True
    '        Me.Button1.Enabled = True

    '    End If

    '    Me.cbxFechas.DataTextField = "dfecvig"
    '    Me.cbxFechas.DataValueField = "dfecvig"
    '    Me.cbxFechas.DataSource = ds.Tables(0)
    '    Me.cbxFechas.DataBind()
    '    Return True
    'End Function


    Private Sub CargarDatos()
        Dim ds As New DataSet
        '----------------------------
        'Llenando Programa
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0331'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.cmbFondo.DataTextField = "cDescri"
        Me.cmbFondo.DataValueField = "cCodigo"
        Me.cmbFondo.DataSource = ds.Tables("Resultado")
        Me.cmbFondo.DataBind()


        'Me.cbxprograma.DropDownWidth = 300
        ds.Tables("Resultado").Clear()


    End Sub


    'Dim sqlComando As New SqlCommand

    'Try

    '    Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("fondesolConnectionString2").ConnectionString)
    '        cnConexion.Open()

    '        strCadena = " update cntamov " & _
    '        " set ffondos='" + DropDownListFondos.SelectedValue + "'" & _
    '        " where cnumcom='" + TextBoxNumeroPartida.Text + "'"

    '        sqlComando.CommandText = strCadena
    '        sqlComando.Connection = cnConexion
    '        sqlComando.ExecuteNonQuery()

    '        strCadena = " update auxiliar " & _
    '        " set ffondos='" + DropDownListFondos.SelectedValue + "'" & _
    '        " where cnumcom='" + TextBoxNumeroPartida.Text + "'" 

    '        sqlComando.CommandText = strCadena
    '        sqlComando.Connection = cnConexion
    '        sqlComando.ExecuteNonQuery()

    '    End Using
    '    Response.Write("<script language='javascript'>alert('Fondo Cambiado')</script>")
    'Catch sqlex As SqlException
    '    Response.Write("<script language='javascript'>alert('Fondo Cambiado')</script>")
    'Catch ex As Exception
    '    Response.Write("<script language='javascript'>alert('No se efectuo el Cambio')</script>")
    'End Try


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Actualiza linea de creditos 
        Dim lcnrolin As String = DropDownLinea2.SelectedValue.Trim
        Dim lcnrolin1 As String = DropDownLinea1.SelectedValue.Trim
        Dim ecreditos As New ccreditos

        If lcnrolin.Trim = lcnrolin1.Trim Then
            Response.Write("<script language='javascript'>alert('Linea de Crédito es la misma, Verifique')</script>")
            Exit Sub
        End If
        Dim ecremcre As New cCremcre
        Dim dsclientes As New DataSet
        Dim m1 As New ccreditos
        Dim ds As New DataSet
        Dim lnsaldo As Double = 0
        Dim ecretlin As New cCretlin
        Dim lccodlinnuevo As String = ""
        Dim lccodlinviejo As String = ""
        Dim lccodofi As String = Session("gcCodofi")
        Dim lccondic As String = ""
        Dim lccodfue As String = ""
        Dim lccodpres As String = ""

        Dim oki As String = ""
        Dim entidadcremcre As New cremcre

        entidadcremcre.ccodcta = txtcCodsol.Text.Trim
        ecremcre.ObtenerCremcre(entidadcremcre)

        lccondic = entidadcremcre.ccondic
        lccodofi = entidadcremcre.coficina


        'ds = m1.HistoricoGrupal(txtcCodsol.Text.Trim, cbxFechas.SelectedValue)

        lccodlinnuevo = ecretlin.ObtieneCodigoLinea(lcnrolin)
        lccodlinviejo = ecretlin.ObtieneCodigoLinea(lcnrolin1)
        lccodfue = lccodlinnuevo.Substring(2, 2)

        Dim i As Integer = 0
        Try

            'Realiza Patida Contable

            dsclientes = ecreditos.SaldoxCuenta(Me.txtcCodsol.Text.Trim, Session("gdfecsis"))
            If dsclientes.Tables(0).Rows.Count = 0 Then
                Return
            Else
                Dim fila1 As DataRow
                Dim i1 As Integer = 0
                Dim lnsalcap As Double = 0
                Dim lcc As String = ""
                Dim lcc1 As String = ""
                cClsAdP._nCuenta = 1
                For Each fila1 In dsclientes.Tables(0).Rows
                    '            lccondic = fila1("ccondic")
                    '           lccodofi = fila1("coficina")
                    lnsaldo = Math.Round((fila1("ncapdes") - fila1("ncappag")), 2)
                    lccodpres = fila1("ccodcta")
                    'lnsaldo += lnsalcap

                    'Realiza movimiento contable-----------------------------------
                    'Cargo
                    If lccondic <> "S" Then
                        Dim lcmascara As String = "CKPNN"
                        lcmetodo = lccodlinnuevo.Substring(4, 2)
                        lcc = clasefunc.CodigoCondicion(lccondic)
                        If lcmascara <> Nothing Then
                            entidadtabtmak.ccodigo = lcmascara
                            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                            If busquedaplantilla = 0 Then
                                lcctactb = "*"
                            Else
                                lcctactb = entidadtabtmak.cplanti.Trim
                            End If
                        End If

                        'Abono
                        lcmetodo1 = lccodlinviejo.Substring(4, 2)
                        If lcmascara <> Nothing Then
                            entidadtabtmak.ccodigo = lcmascara
                            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                            If busquedaplantilla = 0 Then
                                lcctactb1 = "*"
                            Else
                                lcctactb1 = entidadtabtmak.cplanti.Trim
                            End If
                        End If
                        i = ecremcre.ActualizaNrodeLinea2FC(lcnrolin, lccodpres, lccodfue)

                        If lcctactb.Trim = lcctactb1.Trim And lccodlinnuevo.Substring(2, 2).Trim = lccodlinviejo.Substring(2, 2).Trim Then
                            Response.Write("<script language='javascript'>alert('Cuenta Contable ni Fondo  varía, , no habra afectacion Contable')</script>")
                        Else
                            'Graba Partida contable
                            cClsAdP._dfecmod = Session("gdfecsis")
                            cClsAdP._ccodusu = Session("gcCodusu")
                            cClsAdP._ccodofi = lccodofi
                            cClsAdP._cconcepto = "PARTIDA RECLASIFICACION DE LINEA DE CREDITO "
                            cClsAdP._dfeccnt = Session("gdfecsis")
                            cClsAdP._cpoliza = "AR"
                            cClsAdP._cnumdoc = "R"
                            cClsAdP._llbandera = True
                            cClsAdP._ccodpres = lccodpres

                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = lcctactb
                            cClsAdP._ndebe = lnsaldo
                            cClsAdP._nhaber = 0
                            cClsAdP._cclase = "1"
                            cClsAdP._ffondos = lccodlinnuevo.Substring(2, 2)

                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            ' parte de cuenta fija debe

                            cClsAdP._nCuenta += 1
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = "1140303"
                            cClsAdP._ndebe = 0
                            cClsAdP._nhaber = lnsaldo
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ccodofi = lccodofi
                            cClsAdP._ffondos = lccodlinnuevo.Substring(2, 2)
                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If

                            cClsAdP._nCuenta += 1
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = lcctactb1
                            cClsAdP._ndebe = 0
                            cClsAdP._nhaber = lnsaldo
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ffondos = lccodlinviejo.Substring(2, 2)

                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            cClsAdP._nCuenta += 1
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = "1140303"
                            cClsAdP._ndebe = lnsaldo
                            cClsAdP._nhaber = 0
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ccodofi = lccodofi
                            cClsAdP._ffondos = lccodlinviejo.Substring(2, 2)
                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If

                            cClsAdP._nCuenta += 1

                            '-----------Fin de Afectación Contable

                        End If
                    Else
                        Response.Write("<script language='javascript'>alert('Creditos Saneado no se puede cambiar de Fondo')</script>")
                        Exit Sub
                    End If

                Next
            End If




            Response.Write("<script language='javascript'>alert('Línea Cambiada')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('No se efectuo el Cambio')</script>")
        End Try

        Button1.Enabled = False

    End Sub

    Public Sub CargarDatosPorCuenta(ByVal codigogrupo As String)
        Dim eclimide As New cClimide
        Dim lcnomcli As String = ""
        Dim ecretlin As New cCretlin
        Dim lcnrolin As String = ""

        txtcCodsol.Text = codigogrupo.Trim


        Dim ecremcre As New cCremcre
        'Dim ds As New DataSet
        'ds = ecremcre.ObtenerSocias(Me.txtcCodsol.Text.Trim)
        'If ds.Tables(0).Rows.Count = 0 Then

        '    Exit Sub

        'End If

        Dim fila As DataRow
        Dim lccodcta As String = codigogrupo.Trim

        'For Each fila In ds.Tables(0).Rows
        '    lccodcta = fila("codigo")
        '    Exit For
        'Next

        Dim entidadcremcre As New cremcre
        Dim lccodfue As String
        Dim lccodfue2 As String


        entidadcremcre.ccodcta = lccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)

        lcnrolin = entidadcremcre.cnrolin
        lccodfue = ecretlin.ObtieneCodigoLinea(lcnrolin).Trim.Substring(2, 2)
        lccodfue2 = ecretlin.ObtieneCodigoLinea(lcnrolin).Trim

        'lccodfue = entidadcremcre.ccodfue
        If IsDBNull(lccodfue) Then
        Else
            CargaLineasxFondos(lccodfue, lccodfue2)
        End If



        lcnomcli = eclimide.RecuperarNombre(lccodcta)
        txtcnomgru.Text = lcnomcli.Trim

        'Dim ladelante As Boolean
        'ladelante = CargaFechas()

        'If ladelante = False Then
        '    Return
        'End If

        'Dim ldfecvig As Date
        'ldfecvig = cbxFechas.SelectedValue.Trim

        'lcnrolin = ecretlin.ObtieneNroLineaCredito(lccodcta.Trim)


        ObtenerFondo()
        DropDownLinea1.SelectedValue = lcnrolin
        cmbFondo.SelectedValue = lccodfue
        DropDownLinea2.SelectedValue = lcnrolin
        'Buscar un credito para buscar la linea de credito actual
    End Sub

    Private Sub CargaLineasxFondos(ByVal cCodfue As String, ByVal cCodfue2 As String)
        ' Me.cbxLineas.Items.Clear()

        Dim dst As New DataSet
        Dim ds As New DataSet
        Dim lctipo As String

        Dim clscretlin As New cCretlin

        lctipo = (cCodfue2.Substring(4, 2).Trim)
        ds = clscretlin.RecuperarporFuente(cCodfue, lctipo.Trim)
        dst = clscretlin.RecuperarporFuenteTodos(cCodfue, lctipo.Trim)


        If dst.Tables(0).Rows.Count = 0 Then
            Me.DropDownLinea1.Enabled = False
            Me.DropDownLinea2.Enabled = False

            Return
        Else
            '    Me.DropDownLinea1.Enabled = True
            Me.DropDownLinea2.Enabled = True
        End If


        DropDownLinea1.DataTextField = "cdeslin"
        DropDownLinea1.DataValueField = "cNrolin"
        DropDownLinea1.DataSource = dst
        DropDownLinea1.DataBind()

        DropDownLinea2.DataTextField = "cdeslin"
        DropDownLinea2.DataValueField = "cNrolin"
        DropDownLinea2.DataSource = ds
        DropDownLinea2.DataBind()

    End Sub

    Protected Sub DropDownLinea2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownLinea2.SelectedIndexChanged
        ObtenerFondo()
    End Sub
    Private Sub ObtenerFondo()
        Dim ecretlin As New cCretlin
        Dim etabttab As New cTabttab
        Dim lcfondo As String = ""

        '-----------------------------------------------------'
        Dim lccodlin1 As String = ""
        Dim lccodlin2 As String = ""
        Try

            lccodlin1 = ecretlin.ObtieneCodigoLinea(DropDownLinea1.SelectedValue.Trim)
            lccodlin2 = ecretlin.ObtieneCodigoLinea(DropDownLinea2.SelectedValue.Trim)

            TextBox1.Text = etabttab.Describe(lccodlin1.Trim.Substring(2, 2), "033")
            TextBox2.Text = etabttab.Describe(lccodlin2.Trim.Substring(2, 2), "033")

        Catch ex As Exception

        End Try
        '------------------------------------------------------



    End Sub
    Private Sub CargaLineasxFondosnueva(ByVal cCodfue As String)
        ' Me.cbxLineas.Items.Clear()

        Dim ds As New DataSet
        Dim clscretlin As New cCretlin

        ds = clscretlin.RecuperarporFuente(cCodfue, Me.txtcCodsol.Text.Trim.Substring(6, 2))

        If ds.Tables(0).Rows.Count = 0 Then
            Me.DropDownLinea2.Enabled = False
            Me.Button1.Enabled = False
            Return
        Else
            Me.DropDownLinea2.Enabled = True
            Me.Button1.Enabled = True
        End If


        Me.DropDownLinea2.DataTextField = "cdeslin"
        Me.DropDownLinea2.DataValueField = "cNrolin"
        Me.DropDownLinea2.DataSource = ds
        Me.DropDownLinea2.DataBind()

    End Sub
    Protected Sub cmbFondo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFondo.SelectedIndexChanged
        CargaLineasxFondosnueva(Me.cmbFondo.SelectedValue.Trim)
    End Sub

End Class
