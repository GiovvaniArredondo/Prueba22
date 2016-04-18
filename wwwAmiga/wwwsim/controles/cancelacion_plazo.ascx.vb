Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Drawing.Printing

Public Class cancelacion_plazo
    Inherits System.Web.UI.UserControl
    Private Shared plazo As Integer
    Private Shared partida As String
    Private Shared nombre As String
    Private Shared asociado As String
    Private Shared certificado As String
    Private Shared certificado_monto As Decimal
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
        foto_Image.Visible = False
        mensaje.Visible = False
        plazos_GridView.Visible = False
        cancelar_Button.Visible = False
        imprimir_Button.Visible = False
        cta_ahorro_Label.Visible = False
        nueva_cta_ahorro_Label.Visible = False

        cta_ahorro_TextBox.Visible = False
        cta_ahorro_DropDownList.Visible = False

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
    Private Sub CargaGrid2()
        asociado = asociados_GridView.SelectedRow.Cells(1).Text.ToString 'asociado

        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "select ccodcrt, nombre, nsaldoaho, nplazo, ntasint, dfecapr, dfecven, ccodaho from ahomcrt " & _
                         "where cnudotr = '" & asociado & "' and cliq <> 'S' and cpignor <> 'S' and nsaldoaho > 0 order by ccodcrt"

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        plazos_GridView.DataSource = ds
        plazos_GridView.DataBind()
        plazos_GridView.Visible = True
        foto_firma(asociado)

        If ds.Tables(0).Rows.Count = 0 Then
            Response.Write(miclase1.mensaje("Posiblemente Certificado Pignorado"))
        End If

    End Sub
    Protected Sub asociados_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociados_GridView.SelectedIndexChanged
        CargaGrid2()
    End Sub

    Protected Sub plazos_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plazos_GridView.SelectedIndexChanged
        Dim miclase1 As New clase_funciones
        Dim fec100 As Date = Date.Parse(plazos_GridView.SelectedRow.Cells(7).Text) 'fecha de vencimiento
        Dim dias As Integer = DateDiff(DateInterval.Day, Session("gdfecsis"), fec100)

        If fec100 > Session("gdfecsis") Then
            Response.Write(miclase1.mensaje("Advertencia!!!!Es una Cancelacion Anticipada que Supera los 3 Dias de Gracia, Pasarlo al Cajero Contable 2 en Informática"))
        End If

        ''para que solo se de en informatica o se pueda pagar en caja
        'If dias >= 0 And dias <= 3 Then ' 3 dias son el max. de gracia para poderlo cancelar

        'Else
        '    If fec100 > Session("gdfecsis") And Session("gccodusu").ToString.ToUpper <> "BASA" Then
        '        Response.Write(miclase1.mensaje("Es una Cancelacion Anticipada que Supera los 3 Dias de Gracia, Pasarlo al Cajero Contable 2 en Informática"))
        '        Exit Sub
        '    End If
        'End If
        plazos_GridView.Visible = True
        cancelar_Button.Visible = True
        cta_ahorro_Label.Visible = True
        nueva_cta_ahorro_Label.Visible = True

        cta_ahorro_TextBox.Visible = True
        cta_ahorro_DropDownList.Visible = True

        certificado = plazos_GridView.SelectedRow.Cells(1).Text
        nombre = plazos_GridView.SelectedRow.Cells(2).Text
        certificado_monto = plazos_GridView.SelectedRow.Cells(3).Text
        plazo = Int32.Parse(plazos_GridView.SelectedRow.Cells(4).Text)
        cta_ahorro_TextBox.Text = plazos_GridView.SelectedRow.Cells(8).Text


        Dim miclase As New clase_especial
        Dim ds As DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim str_select = "select ccodaho from ahomcta where cnudotr = '" & asociado & "' order by ccodaho"

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)
        con.Close()

        dt = ds.Tables("tabla")

        For Each fila In dt.Rows
            cta_ahorro_DropDownList.Items.Add(fila("ccodaho"))
        Next

        cta_ahorro_DropDownList.Focus()

    End Sub

    Protected Sub cta_ahorro_DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cta_ahorro_DropDownList.SelectedIndexChanged
        cta_ahorro_TextBox.Text = cta_ahorro_DropDownList.SelectedValue
    End Sub

    Protected Sub cancelar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelar_Button.Click
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim error100 As Integer = 0
        Dim nmonto As Decimal = 0
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim cuenta_ahorro As String = cta_ahorro_TextBox.Text.Trim
        Dim str_select As String = "", interes As Decimal = 0
        Dim nnum As Integer = 0, saldo As Decimal = 0, cnumcom As String, num As Integer = 0
        Dim no_recibo As String, cta_contable_ahorro As String, cta_cajero As String, cta_contable_cajero As String
        Dim ccodusu As String = Session("gccodusu"), gdfecsis As String, fec_hoy As Date = Session("gdfecsis"), tipo_cta As String
        Dim concepto As String = "", cclase As String, nhaber As Decimal, ndebe As Decimal

        gdfecsis = Session("gdfecsis")

        con.ConnectionString = stringconnection
        con.Open()
        'saber el saldo de ahorro
        str_select = "select nnum, nsaldoaho from ahomcta where ccodaho = '" & cuenta_ahorro & "'"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            nnum = fila("nnum")
            saldo = fila("nsaldoaho")
        Next
        'para saber cta contable de cta de ahorro
        cta_contable_ahorro = miclase1.cuenta_contable_ahorro(cuenta_ahorro)
        cta_contable_cajero = miclase1.cuenta_contable_cajero(ccodusu)

        'saca el interes, la provision
        str_select = "select sum(nintere) as suma  from ahomint where ccodcrt = '" & certificado & "' and cflag <> 'X'"
        interes = miclase.devolver_scalar1(con, str_select)

        str_select = "SET LANGUAGE spanish; begin tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            con.Close()
            Return
        End If

        'actualiza la ahomcrt
        str_select = "update ahomcrt set cliq='S' where ccodcrt = '" & certificado & "'"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        'actualiza la ahomint, la provision
        str_select = "update ahomint set cflag='X' where ccodcrt = '" & certificado & "' and cflag <> 'X'"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        nnum = nnum + 1
        If nnum > 65 Then
            nnum = 1
        End If

        nmonto = certificado_monto
        saldo = saldo + nmonto
        no_recibo = "C/" & Left(certificado.Trim, 6)

        'inserta el movimiento en en la cta de ahorro
        tipo_cta = cuenta_ahorro.Substring(6, 2)
        str_select = "insert into ahommov " & _
                     "(ccodaho, dfecope, ctipope, cnumdoc, ctipdoc, crazon, nlibreta, cnrochq, ctipchq, dfecomp, dfecefe, npartida, nmonto, interes, clinea, " & _
                     "ncorrel, dfecmod, ccodusu, nnum, tip, nsaldoaho, nsaldnind, cconcep, ctipaho, producto, ncompen, ccodtra, notromon) values " & _
                     "('" & cuenta_ahorro & "', '" & gdfecsis & "', 'D', '" & no_recibo.ToString & "', 'E', 'CANCELACION/PLAZO', 0, ' ', ' ', " & _
                     "'" & gdfecsis & " ', '" & gdfecsis & "', 0, '" & nmonto & "', 0, 'N', " & _
                     nnum & ", '" & gdfecsis & "', '" & ccodusu & "', " & nnum & ", ' ', " & saldo & ", " & saldo & ", 'TR', " & _
                     "'" & tipo_cta & "', ' ', 0, ' ', 0)"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        'actualiza la cabecera de ahorros
        str_select = "update ahomcta set nsaldoaho=" & saldo & ", nsaldnind=" & saldo & _
              ", nnum=" & nnum & ", dfecmod='" & gdfecsis & "', dfecult = '" & gdfecsis & "' where ccodaho ='" & cuenta_ahorro & "'"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        concepto = "PART.PARA CONTAB. CANCELACION DE CERTIFICADO A PLAZO # " & certificado & " TRASLADAR A CTA " & cuenta_ahorro
        'primera partida
        'partida de diario
        cnumcom = miclase1.fxStevo(gdfecsis)
        partida = cnumcom
        str_select = "insert into diario " & _
                     "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
                     "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
                     "('" & cnumcom & "', " & miclase1.ToString(Session("gccodofi")) & ", '012', '1', '" & concepto & "', '" & no_recibo.ToString.Trim & "', ' ', ' ', '" & gdfecsis & "', '" & gdfecsis & "', '" & gdfecsis & "', '" & ccodusu & "', 0, " & _
                     "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If
        num = 1


        cta_contable_ahorro = ""
        'cta contable dep a plazo es capital
        If plazo <= 30 Then
            cta_contable_ahorro = "2111020101"
        End If
        If plazo >= 31 And plazo <= 60 Then
            cta_contable_ahorro = "2111030101"
        End If
        If plazo >= 61 And plazo <= 90 Then
            cta_contable_ahorro = "2111040101"
        End If
        If plazo >= 91 And plazo <= 120 Then
            cta_contable_ahorro = "2111050101"
        End If
        If plazo >= 121 And plazo <= 150 Then
            cta_contable_ahorro = "2111060101"
        End If
        If plazo >= 151 And plazo <= 180 Then
            cta_contable_ahorro = "2111070101"
        End If
        If plazo >= 181 And plazo <= 355 Then
            cta_contable_ahorro = "2111080101"
        End If
        If plazo = 360 Then
            cta_contable_ahorro = "2111090101"
        End If
        If plazo >= 361 Then
            cta_contable_ahorro = "2112010101"
        End If


        'cta_contable_ahorro = miclase1.cuenta_contable_ahorro("00100107101012") ' para saber la cta contable de dep a plazo
        cclase = Left(cta_contable_ahorro, 1)
        ndebe = nmonto
        nhaber = 0.0
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If


        'cta contable de cta de cajero
        num = num + 1
        cta_cajero = miclase1.cuenta_contable_cajero(ccodusu) ' para saber la cta contable del cajero
        cclase = Left(cta_cajero, 1)
        ndebe = 0.0
        nhaber = nmonto
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', '12', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        'cta contable de cta de cajero
        num = num + 1
        cta_cajero = miclase1.cuenta_contable_cajero(ccodusu) ' para saber la cta contable del cajero
        cclase = Left(cta_cajero, 1)
        ndebe = nmonto
        nhaber = 0.0
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If
        num = num + 1
        'cta contable de cta ahorro donde se depositara
        cta_contable_ahorro = miclase1.cuenta_contable_ahorro(cuenta_ahorro) ' para saber la cta contable de cta de ahorro donde se depsositara
        cclase = Left(cta_contable_ahorro, 1)
        ndebe = 0.0
        nhaber = nmonto
        str_select = "insert into cntamov " & _
                    "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                    "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                    "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                    "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                    "' ', ' ', 0, 0, '" & gdfecsis & "')"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            str_select = "rollback"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            con.Close()
            Return
        End If

        'contabiliza solamente si hay intereses una partida de reversion de la provision
        If interes > 0 Then

            concepto = "REVERSION DE PARTIDA DE PROVISION DE INTERESES POR CANCELACION ANTICIPADA DE CERTIFI. A PLAZO # " & certificado & " " & nombre.Trim
            'segunda partida
            'partida de diario
            cnumcom = miclase1.fxStevo(gdfecsis)
            no_recibo = "REV/PROV"
            str_select = "insert into diario " & _
                         "(cnumcom, ccodofi, ctipasi, ctipmon, cglosa, cnumdoc, ccodruc, ccodemp, dfecdoc, dfeccnt, dfecmod, ccodusu, nccompra, " & _
                         "ncventa, ntcfijo, cfv, cestado, nfln, cnrodoc, boleta, cnombre) values " & _
                         "('" & cnumcom & "', " & miclase1.ToString(Session("gccodofi")) & ", '012', '1', '" & concepto & "', '" & no_recibo.ToString.Trim & "', ' ', ' ', '" & gdfecsis & "', '" & gdfecsis & "', '" & gdfecsis & "', '" & ccodusu & "', 0, " & _
                         "0, 0, ' ', ' ', 0, ' ', ' ', ' ') "

            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                mensaje.Text = "Ocurrio un error... certificado no cancelado"
                mensaje.Visible = True
                cancelar_Button.Visible = False
                imprimir_Button.Visible = False
                str_select = "rollback"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return
            End If
            'cta contable de reversion
            num = 1

            cta_contable_ahorro = ""
            'cta de provision
            If plazo <= 30 Then
                cta_contable_ahorro = "2111029501"
            End If
            If plazo >= 31 And plazo <= 60 Then
                cta_contable_ahorro = "2111039501"
            End If
            If plazo >= 61 And plazo <= 90 Then
                cta_contable_ahorro = "2111049501"
            End If
            If plazo >= 91 And plazo <= 120 Then
                cta_contable_ahorro = "2111059501"
            End If
            If plazo >= 121 And plazo <= 150 Then
                cta_contable_ahorro = "2111069501"
            End If
            If plazo >= 151 And plazo <= 180 Then
                cta_contable_ahorro = "2111079501"
            End If
            If plazo >= 181 And plazo <= 355 Then
                cta_contable_ahorro = "2111089501"
            End If
            If plazo = 360 Then
                cta_contable_ahorro = "2111099501"
            End If
            If plazo >= 361 Then
                cta_contable_ahorro = "21120199501"
            End If

            'cta_contable_ahorro = "2111019501"
            cclase = Left(cta_contable_ahorro, 1)
            ndebe = interes
            nhaber = 0.0
            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                        "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                        "' ', ' ', 0, 0, '" & gdfecsis & "')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                mensaje.Text = "Ocurrio un error... certificado no cancelado"
                mensaje.Visible = True
                cancelar_Button.Visible = False
                imprimir_Button.Visible = False
                str_select = "rollback"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return
            End If
            'cta contable de cta de cajero
            num = num + 1
            cta_cajero = miclase1.cuenta_contable_cajero(ccodusu) ' para saber la cta contable del cajero
            cclase = Left(cta_cajero, 1)
            ndebe = 0.0
            nhaber = interes
            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                        "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                        "' ', ' ', 0, 0, '" & gdfecsis & "')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                mensaje.Text = "Ocurrio un error... certificado no cancelado"
                mensaje.Visible = True
                cancelar_Button.Visible = False
                imprimir_Button.Visible = False
                str_select = "rollback"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return
            End If

            'cta contable de cta orden
            num = num + 1
            cta_contable_ahorro = "5110010201"
            cclase = Left(cta_contable_ahorro, 1)
            ndebe = 0.0
            nhaber = interes
            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_contable_ahorro & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                        "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                        "' ', ' ', 0, 0, '" & gdfecsis & "')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                mensaje.Text = "Ocurrio un error... certificado no cancelado"
                mensaje.Visible = True
                cancelar_Button.Visible = False
                imprimir_Button.Visible = False
                str_select = "rollback"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return
            End If
            'cta contable de cta de cajero
            num = num + 1
            cta_cajero = miclase1.cuenta_contable_cajero(ccodusu) ' para saber la cta contable del cajero
            cclase = Left(cta_cajero, 1)
            ndebe = interes
            nhaber = 0.0
            str_select = "insert into cntamov " & _
                        "(ccodsec, ffondos, cnumcom, cnumlin, ccodcta, cclase, ndebe, nhaber, cflc, nfln, cnumdoc, dfeccnt, ccodpres, cconcepto, cpoliza, ccodofi, " & _
                        "cnumpol, ccodreg, ccodcli, ccodusu1, casocia, corden, nsaldob, depositos, dfecbco) values " & _
                        "(' ', '01', '" & cnumcom & "', '" & num & "', '" & cta_cajero & "', '" & cclase & "', " & ndebe & ", " & nhaber & ", ' ', 0, '" & no_recibo.ToString.Trim & "', " & _
                        "'" & gdfecsis & "', '" & cuenta_ahorro & "', ' ', 'RT', " & miclase1.ToString(Session("gccodofi")) & ", ' ', ' ', '" & asociado & "', '" & ccodusu & "', " & _
                        "' ', ' ', 0, 0, '" & gdfecsis & "')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                mensaje.Text = "Ocurrio un error... certificado no cancelado"
                mensaje.Visible = True
                cancelar_Button.Visible = False
                imprimir_Button.Visible = False
                str_select = "rollback"
                error100 = miclase.nonquery_sin_parametros(con, str_select)
                con.Close()
                Return
            End If


        End If


        str_select = "commit tran"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            mensaje.Text = "Ocurrio un error... certificado no cancelado"
            mensaje.Visible = True
            cancelar_Button.Visible = False
            imprimir_Button.Visible = False
            con.Close()
            Return
        End If

        con.Close()
        'mensaje.Text = "Certificado Cancelado..."
        'mensaje.Visible = True
        Response.Write("<script language='javascript'>alert('Certificado Cancelado...')</script>")
        cancelar_Button.Visible = False
        imprimir_Button.Visible = True
        CargaGrid2()

    End Sub

    'esta es la rutina que llama   
    Private Sub print_PrintPage_libreta(ByVal sender As Object, _
                               ByVal e As PrintPageEventArgs)

        '' La fuente a usar
        Dim prtFont As New Font("Arial", 9, FontStyle.Regular)

        Dim lineHeight As Single
        Dim yPos As Single = 30
        Dim leftMargin As Single = 1
        Dim printFont As System.Drawing.Font
        ' Asignar el tipo de letra
        printFont = prtFont
        lineHeight = printFont.GetHeight(e.Graphics) * 2

        ' imprimir cada una de las líneas de esta página
        Dim vacia As String = " "
        'esta es parte de margen de arriba

        vacia = "FECHA:" & Session("gdfecsis").ToString & "                                    SIHUACOOP DE R.L."
        yPos += lineHeight
        e.Graphics.DrawString(vacia, printFont, Brushes.Black, leftMargin, yPos)

        vacia = "                                                                    CANCELACION DE CERTIFICADO A PLAZO"
        yPos += lineHeight
        e.Graphics.DrawString(vacia, printFont, Brushes.Black, leftMargin, yPos)

        vacia = " "
        yPos += lineHeight
        e.Graphics.DrawString(vacia, printFont, Brushes.Black, leftMargin, yPos)

        vacia = "========================================================================================================"
        yPos += lineHeight
        e.Graphics.DrawString(vacia, printFont, Brushes.Black, leftMargin, yPos)

        yPos += lineHeight
        e.Graphics.DrawString("No. PARTIDA..........", printFont, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(partida, printFont, Brushes.Black, 200, yPos)

        yPos += lineHeight
        e.Graphics.DrawString("ASOCIADO.............", printFont, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(asociado.Trim & "  -  " & nombre.Trim, printFont, Brushes.Black, 200, yPos)

        yPos += lineHeight
        e.Graphics.DrawString("CERTIFICADO..........", printFont, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(certificado, printFont, Brushes.Black, 200, yPos)

        yPos += lineHeight
        e.Graphics.DrawString("MONTO................", printFont, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(certificado_monto.ToString("###,###.##"), printFont, Brushes.Black, 200, yPos)

        yPos += lineHeight
        e.Graphics.DrawString("DEPOSITADO EN CTA....", printFont, Brushes.Black, leftMargin, yPos)
        e.Graphics.DrawString(cta_ahorro_TextBox.Text.Trim, printFont, Brushes.Black, 200, yPos)

        vacia = "========================================================================================================"
        yPos += lineHeight
        e.Graphics.DrawString(vacia, printFont, Brushes.Black, leftMargin, yPos)


    End Sub

    Protected Sub imprimir_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles imprimir_Button.Click

        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones


        Dim str_select As String
        str_select = "select dia.cnumcom, dia.cglosa, mov.ccodcta, cat.cdescrip, mov.dfeccnt, mov.ndebe, mov.nhaber, mov.ccodusu1 " & _
                     "from diario as dia, cntamov as mov, ctbmcta as cat " & _
                     "where dia.cnumcom = " & miclase1.ToString(partida) & " and dia.cnumcom = mov.cnumcom and mov.ccodcta = cat.ccodcta"

        Session("str_select") = str_select
        Response.Redirect("~/reporte_contenedor.aspx?parametro=" & "partida")


        Exit Sub


        ' esta parte queda anulada

        'este es boton 
        Dim printDoc As New PrintDocument
        ' asignamos el método de evento para cada página a imprimir
        AddHandler printDoc.PrintPage, AddressOf print_PrintPage_libreta
        ' indicamos que queremos imprimir
        printDoc.Print()
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
