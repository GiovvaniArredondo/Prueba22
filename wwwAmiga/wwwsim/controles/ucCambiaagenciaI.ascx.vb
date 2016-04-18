Imports System.Data.SqlClient

Partial Class ucCambiaagenciaI
    Inherits System.Web.UI.UserControl
    Dim entidadtabtmak As New tabtmak
    Dim etabtmak As New cTabtmak
    Dim entidadtabtofi As New tabtofi
    Dim etabtofi As New cTabtofi
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
    Private cClsDes As New SIM.BL.clsDesembolsa
    Private cls1 As New SIM.BL.ClsMantenimiento
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
        '---------------------------
        'oficinas
        '---------------------------
        Dim clstabtofi As New cTabtofi
        Dim mtabtofi As New tabtofi
        Dim listaofi As New listatabtofi

        listaofi = clstabtofi.ObtenerLista()

        Me.cmbAgencia.DataTextField = "cnomofi"
        Me.cmbAgencia.DataValueField = "cCodofi"
        Me.cmbAgencia.DataSource = listaofi
        Me.cmbAgencia.DataBind()



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
        Dim lccodagencia As String = Me.TextBox2.Text
        Dim lccodagencia1 As String = Me.cmbAgencia.SelectedValue
        Dim ecreditos As New ccreditos

        'Dim lcnrolin As String = DropDownLinea2.SelectedValue.Trim
        'Dim lcnrolin1 As String = DropDownLinea1.SelectedValue.Trim

        If lccodagencia.Trim = lccodagencia1.Trim Then
            Response.Write("<script language='javascript'>alert('Es la misma Agencia, Verifique')</script>")
            Exit Sub
        End If

        Dim ecremcre As New cCremcre
        Dim eclimide As New cClimide
        Dim dsclientes As New DataSet
        Dim m1 As New ccreditos
        Dim ds As New DataSet
        Dim lnsaldo As Double = 0
        Dim ecretlin As New cCretlin
        Dim lccodagennuevo As String = ""
        Dim lccodagenviejo As String = ""
        Dim lccodlinviejo As String = ""
        Dim lccodofi As String = Session("gcCodofi")
        Dim lccondic As String = ""
        Dim lccodfue As String = ""
        Dim lccodpres As String = ""
        Dim lccodcli As String = ""
        Dim lcnrolin As String = ""

        Dim oki As String = ""
        Dim entidadcremcre As New cremcre

        entidadcremcre.ccodcta = txtcCodsol.Text.Trim
        ecremcre.ObtenerCremcre(entidadcremcre)

        lccondic = entidadcremcre.ccondic
        lccodofi = entidadcremcre.coficina


        'ds = m1.HistoricoGrupal(txtcCodsol.Text.Trim, cbxFechas.SelectedValue)

        lccodagennuevo = lccodagencia1.Trim
        lccodagenviejo = lccodagencia.Trim

        'lccodlinnuevo = ecretlin.ObtieneCodigoLinea(lcnrolin)

        lcnrolin = ecretlin.ObtieneNroLineaCredito(txtcCodsol.Text.Trim)
        lccodlinviejo = ecretlin.ObtieneCodigoLinea(lcnrolin)
        'lccodfue = lccodlinnuevo.Substring(2, 2)

        'lccodlinnuevo = ecretlin.ObtieneCodigoLinea(lcnrolin)
        'lccodlinviejo = ecretlin.ObtieneCodigoLinea(lcnrolin1)
        'lccodfue = lccodlinnuevo.Substring(2, 2)

        Dim i As Integer = 0
        Dim i2 As Integer = 0

        Try

            'Realiza Patida Contable

            dsclientes = ecreditos.SaldoxCuenta2(Me.txtcCodsol.Text.Trim, Session("gdfecsis"))
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
                    lccodcli = fila1("ccodcli")
                    'lnsaldo += lnsalcap

                    'Realiza movimiento contable-----------------------------------
                    'Cargo

                    Dim lcmascara As String = "CKPNN"
                    lcmetodo = lccodlinviejo.Substring(4, 2)
                    lcc = clasefunc.CodigoCondicion(lccondic)
                    If lccondic.Trim <> "S" Then
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

                        i = ecremcre.ActualizaAgencia2FC(txtcCodsol.Text.Trim, lccodagennuevo)
                        i2 = eclimide.ActualizaClimideI(lccodcli.Trim, lccodagennuevo)

                        If lcctactb.Trim = lcctactb1.Trim And lccodagennuevo.Trim = lccodagenviejo.Trim Then
                            Response.Write("<script language='javascript'>alert('Cuenta Contable ni agencia  varía, , no habra afectacion Contable')</script>")
                        Else
                            'Graba Partida contable
                            cClsAdP._dfecmod = Session("gdfecsis")
                            cClsAdP._ccodusu = Session("gcCodusu")
                            'cClsAdP._ccodofi = lccodofi
                            cClsAdP._cconcepto = "PARTIDA RECLASIFICACION DE AGENCIA "
                            cClsAdP._dfeccnt = Session("gdfecsis")
                            cClsAdP._cpoliza = "AR"
                            cClsAdP._cnumdoc = "R"
                            cClsAdP._llbandera = True
                            cClsAdP._ccodpres = ""

                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = lcctactb
                            cClsAdP._ndebe = lnsaldo
                            cClsAdP._nhaber = 0
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ccodofi = lccodagennuevo.Trim
                            cClsAdP._ffondos = lccodlinviejo.Substring(2, 2)


                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If

                            ' parte de cuenta fija debe

                            cClsAdP._nCuenta += 1
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = "10411"
                            cClsAdP._ndebe = 0
                            cClsAdP._nhaber = lnsaldo
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ccodofi = lccodagennuevo.Trim
                            cClsAdP._ffondos = lccodlinviejo.Substring(2, 2)
                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            'cClsAdP._nCuenta += 1

                            'parte del haber

                            cClsAdP._nCuenta += 1
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = lcctactb1
                            cClsAdP._ndebe = 0
                            cClsAdP._nhaber = lnsaldo
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ccodofi = lccodagenviejo.Trim
                            cClsAdP._ffondos = lccodlinviejo.Substring(2, 2)
                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            cClsAdP._nCuenta += 1
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = "10411"
                            cClsAdP._ndebe = lnsaldo
                            cClsAdP._nhaber = 0
                            cClsAdP._cclase = "1"
                            cClsAdP._ccodpres = lccodpres
                            cClsAdP._ccodofi = lccodagenviejo.Trim
                            cClsAdP._ffondos = lccodlinviejo.Substring(2, 2)
                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            cClsAdP._nCuenta += 1

                            '-----------Fin de Afectación Contable

                        End If
                        'Else
                        '    lcctactb = "104101100410"

                        '    'Abono
                        '    lcmetodo1 = lccodlinviejo.Substring(4, 2)
                        '    lcctactb1 = "104101100410"
                        '    i = ecremcre.ActualizaAgencia2FC(txtcCodsol.Text.Trim, lccodagennuevo)
                        '    i2 = eclimide.ActualizaClimideI(lccodcli.Trim, lccodagennuevo)

                        '    If lcctactb.Trim = lcctactb1.Trim And lccodagennuevo.Trim = lccodagenviejo.Trim Then
                        '        '    Response.Write("<script language='javascript'>alert('Cuenta Contable ni Fondo  varía, , no habra afectacion Contable')</script>")
                        '    Else
                        '        'Graba Partida contable
                        '        cClsAdP._dfecmod = Session("gdfecsis")
                        '        cClsAdP._ccodusu = Session("gcCodusu")
                        '        'cClsAdP._ccodofi = lccodofi
                        '        cClsAdP._cconcepto = "PARTIDA RECLASIFICACION DE AGENCIA "
                        '        cClsAdP._dfeccnt = Session("gdfecsis")
                        '        cClsAdP._cpoliza = "AR"
                        '        cClsAdP._cnumdoc = "R"
                        '        cClsAdP._llbandera = True
                        '        ' cClsAdP._ccodpres = ""

                        '        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        '        cClsAdP._ccodcta = lcctactb
                        '        cClsAdP._ndebe = 0
                        '        cClsAdP._nhaber = lnsaldo
                        '        cClsAdP._cclase = "1"
                        '        cClsAdP._ccodpres = lccodpres
                        '        cClsAdP._ccodofi = lccodagennuevo.Trim
                        '        cClsAdP._ffondos = cClsDes.ConvertidorFondos(lccodlinviejo.Substring(2, 2).Trim)


                        '        oki = cClsAdP.AdPartida()

                        '        If oki = "0" Then 'Ocurrio un Error
                        '            Exit Sub
                        '        End If

                        '        cClsAdP._nCuenta += 1
                        '        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        '        cClsAdP._ccodcta = lcctactb1
                        '        cClsAdP._ndebe = lnsaldo
                        '        cClsAdP._nhaber = 0
                        '        cClsAdP._cclase = "1"
                        '        cClsAdP._ccodpres = lccodpres
                        '        cClsAdP._ccodofi = lccodagenviejo.Trim
                        '        cClsAdP._ffondos = cClsDes.ConvertidorFondos(lccodlinviejo.Substring(2, 2).Trim)
                        '        oki = cClsAdP.AdPartida()

                        '        If oki = "0" Then 'Ocurrio un Error
                        '            Exit Sub
                        '        End If
                        '        cClsAdP._nCuenta += 1

                        '        '-----------Fin de Afectación Contable
                        '    End If
                    End If
                Next
            End If




            Response.Write("<script language='javascript'>alert('Oficina Cambiada')</script>")
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('No se efectuo el Cambio')</script>")
        End Try

        Button1.Enabled = True

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
        Dim lccodagencia As String


        entidadcremcre.ccodcta = lccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)

        lccodagencia = entidadcremcre.coficina
        'lcnrolin = entidadcremcre.cnrolin
        'lccodfue = ecretlin.ObtieneCodigoLinea(lcnrolin).Trim.Substring(2, 2)


        'lccodfue = entidadcremcre.ccodfue
        If IsDBNull(lccodagencia) Then
        Else
            CargaAgencia(lccodagencia)
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


        ObtenerAgencia(lccodagencia)
        'DropDownLinea1.SelectedValue = lcnrolin
        cmbAgencia.SelectedValue = lccodagencia
        'DropDownLinea2.SelectedValue = lcnrolin
        'Buscar un credito para buscar la linea de credito actual
    End Sub

    Private Sub CargaAgencia(ByVal cCodofi As String)
        ' Me.cbxLineas.Items.Clear()

        Dim dst As New DataSet
        Dim ds As New DataSet

        Dim clscretlin As New cCretlin


        Dim clstabofi As New cTabtofi



        ds = clstabofi.CargaAgenciaChk()


        'ds = clscretlin.RecuperarporFuente(cCodfue, "01")
        'dst = clscretlin.RecuperarporFuenteTodos(cCodfue, "01")


        'If dst.Tables(0).Rows.Count = 0 Then
        '    Me.DropDownLinea1.Enabled = False
        '    Me.DropDownLinea2.Enabled = False

        '    Return
        'Else
        '    '    Me.DropDownLinea1.Enabled = True
        '    Me.DropDownLinea2.Enabled = True
        'End If


        'DropDownLinea1.DataTextField = "cdeslin"
        'DropDownLinea1.DataValueField = "cNrolin"
        'DropDownLinea1.DataSource = dst
        'DropDownLinea1.DataBind()

        'DropDownLinea2.DataTextField = "cdeslin"
        'DropDownLinea2.DataValueField = "cNrolin"
        'DropDownLinea2.DataSource = ds
        'DropDownLinea2.DataBind()

        cmbAgencia.SelectedValue = cCodofi.Trim

    End Sub

    'Protected Sub DropDownLinea2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownLinea2.SelectedIndexChanged
    '    ObtenerFondo()
    'End Sub
    Private Sub ObtenerAgencia(ByVal lccodagencia As String)
        'Dim ecretlin As New cCretlin
        'Dim etabttab As New cTabttab
        'Dim lcfondo As String = ""
        Dim etabtofi As New cTabtofi

        '-----------------------------------------------------'
        Dim lccodlin1 As String = ""
        Dim lccodlin2 As String = ""
        Try

            TextBox1.Text = etabtofi.NombreAgencia(lccodagencia)
            TextBox2.Text = lccodagencia


        Catch ex As Exception

        End Try
        '------------------------------------------------------



    End Sub
    Private Sub CargaLineasxFondosnueva(ByVal cCodfue As String)
        '' Me.cbxLineas.Items.Clear()

        'Dim ds As New DataSet
        'Dim clscretlin As New cCretlin

        'ds = clscretlin.RecuperarporFuente(cCodfue, Me.txtcCodsol.Text.Trim.Substring(6, 2))

        'If ds.Tables(0).Rows.Count = 0 Then
        '    Me.DropDownLinea2.Enabled = False
        '    Me.Button1.Enabled = False
        '    Return
        'Else
        '    Me.DropDownLinea2.Enabled = True
        '    Me.Button1.Enabled = True
        'End If


        'Me.DropDownLinea2.DataTextField = "cdeslin"
        'Me.DropDownLinea2.DataValueField = "cNrolin"
        'Me.DropDownLinea2.DataSource = ds
        'Me.DropDownLinea2.DataBind()

    End Sub
    Protected Sub cmbFondo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAgencia.SelectedIndexChanged
        CargaLineasxFondosnueva(Me.cmbAgencia.SelectedValue.Trim)
    End Sub

    
End Class
