Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports CrystalDecisions.Shared
Imports System.Math
Imports System.IO
Public Class rpt_captacion_aportaciones_creditos
    Inherits ucWBase


#Region "Metodos"
    Private Sub Imprimir(ByVal ds_Print As DataSet, ByVal mi_rptEmp As Object, ByVal tipo As String)


        Dim parameters(1, 1) As String

        'Armando Matriz de variables
        parameters(0, 0) = ("empresa")
        parameters(0, 1) = ("AMIGA")

        parameters(1, 0) = ("pcnomOfi")            'Oficina
        parameters(1, 1) = (ViewState("Oficinas"))


        Me.GenerarReporte_New(ds_Print, Server.MapPath("reportes"), mi_rptEmp, tipo, parameters)


    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            desde_TextBox.Text = Date.Now.Date
            hasta_TextBox.Text = Date.Now.Date
            CargaCombo()
            Listas()
            'If Session("gccodofi") <> "001" Then
            '    ddlOficinas.SelectedItem.Text = "METAPAN"
            '    ddlOficinas.Enabled = False
            '    ckbTodas.Checked = False
            '    ckbTodas.Enabled = False
            'End If
            permisos()

            Session.Add("pcNomOfi", "")
        End If

    End Sub

    'Agregado para cargar el combo de Tipos y oficina -- Alex 29/11/2011
    Public Sub Listas()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        '---------------------------
        'oficinas
        '---------------------------
        Dim clstabtofi As New cTabtofi
        Dim mtabtofi As New tabtofi
        Dim listaofi As New listatabtofi

        listaofi = clstabtofi.ObtenerListaporNivel2(Session("gnNivel"), Session("gcCodOfi"))
        Me.ddlOficinas.DataTextField = "cnomofi"
        Me.ddlOficinas.DataValueField = "ccodofi"
        Me.ddlOficinas.DataSource = listaofi
        Me.ddlOficinas.DataBind()

       
        '---------------------------
        'Exportar a
        '---------------------------


        mListaTabttab = clstabttab.ObtenerLista("145", "1")

        Me.ddlexportar.DataTextField = "cdescri"
        Me.ddlexportar.DataValueField = "ccodigo"
        Me.ddlexportar.DataSource = mListaTabttab
        Me.ddlexportar.DataBind()
        Me.ddlexportar.SelectedValue = "PDF"
        Me.CbxTipAho1.Recuperar()
    End Sub


    Public Sub permisos()
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim lngrupo As Integer
        Dim ds As New DataSet
        lngrupo = eusuariogrupo.RetornaGrupo(Session("gccodusu"))
        ds = eusuariogrupo.DataSetReportes(lngrupo)

        Dim fila As DataRow
        Dim i As Integer
        Dim lcopcion As String
        For Each fila In ds.Tables(0).Rows
            lcopcion = ds.Tables(0).Rows(i)("idopcion")
            Select Case lcopcion
                Case "200"
                    RadioButton1.Enabled = True
                Case "201"
                    RadioButton11.Enabled = True
                Case "202"
                    RadioButton12.Enabled = True
                Case "203"
                    RadioButton13.Enabled = True
                Case "204"
                    RadioButton14.Enabled = True
                Case "205"
                    RadioButton15.Enabled = True
                Case "206"
                    RadioButton16.Enabled = True
                Case "207"
                    RadioButton17.Enabled = True
                Case "208"
                    RadioButton25.Enabled = True
                Case "209"
                    RadioButton26.Enabled = True
                Case "210"
                    RadioButton28.Enabled = True
                Case "211"
                    RadioButton29.Enabled = True
                Case "212"
                    RadioButton30.Enabled = True
                Case "213"
                    RadioButton31.Enabled = True
                Case "214"
                    RadioButton32.Enabled = True
                Case "215"
                    RadioButton33.Enabled = True
                Case "216"
                    RadioButton34.Enabled = True
                Case "217"
                    RadioButton2.Enabled = True
                Case "218"
                    RadioButton3.Enabled = True
                Case "219"
                    RadioButton4.Enabled = True
                Case "220"
                    RadioButton5.Enabled = True
                Case "221"
                    RadioButton19.Enabled = True
                Case "222"
                    RadioButton24.Enabled = True
                Case "223"
                    RadioButton27.Enabled = True
                Case "224"
                    RadioButton35.Enabled = True
                Case "225"
                    RadioButton36.Enabled = True
                Case "226"
                    RadioButton6.Enabled = True
                Case "227"
                    RadioButton8.Enabled = True
                Case "228"
                    RadioButton7.Enabled = True
                Case "229"
                    RadioButton23.Enabled = True
                Case "230"
                    RadioButton9.Enabled = True
                Case "231"
                    RadioButton10.Enabled = True
                Case "232"
                    RadioButton20.Enabled = True
                Case "233"
                    RadioButton21.Enabled = True
                Case "234"
                    RadioButton22.Enabled = True
                Case "235"
                    RadioButton37.Enabled = True
                Case "236"
                    RadioButton18.Enabled = True
                Case "237"
                    RadioButton38.Enabled = True
                Case "238"
                    RadioButton39.Enabled = True
                Case "239"
                    RadioButton40.Enabled = True
                Case "240"
                    RadioButton41.Enabled = True
                Case "241"
                    RadioButton42.Enabled = True
                Case "242"
                    RadioButton43.Enabled = True
                Case "243"
                    RadioButton44.Enabled = True
                Case "244"
                    RadioButton45.Enabled = True
                Case "245"
                    RadioButton46.Enabled = True
                Case "246"
                    RadioButton47.Enabled = True
                Case "247"
                    RadioButton48.Enabled = True
            End Select

            i += 1
        Next

    End Sub
    Private Sub CargaCombo()
        Dim str_select As String

        Dim ds As DataSet
        Dim ds1 As DataSet
        Dim ds2 As DataSet
        Dim fila As DataRow
        Dim miclase As New clase_jaime
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        str_select = "select  nombre, nombre as nombre1 from ahomcrt where cliq <> 'S' group by nombre order by nombre"
        ds = miclase.devolver_dataset(con, str_select)
        str_select = "select  ntasint, ntasint as ntasint1 from ahomcrt where cliq <> 'S' group by ntasint order by ntasint"
        ds1 = miclase.devolver_dataset(con, str_select)
        str_select = "select  nplazo, nplazo as nplazo1 from ahomcrt where cliq <> 'S' group by nplazo order by nplazo"
        ds2 = miclase.devolver_dataset(con, str_select)

        con.Close()

        Me.nombres_DropDownList.DataTextField = "nombre1"
        Me.nombres_DropDownList.DataValueField = "nombre"
        Me.nombres_DropDownList.DataSource = ds
        Me.nombres_DropDownList.DataBind()

        Me.tasa_DropDownList.DataTextField = "ntasint1"
        Me.tasa_DropDownList.DataValueField = "ntasint"
        Me.tasa_DropDownList.DataSource = ds1
        Me.tasa_DropDownList.DataBind()

        Me.plazo_DropDownList.DataTextField = "nplazo1"
        Me.plazo_DropDownList.DataValueField = "nplazo"
        Me.plazo_DropDownList.DataSource = ds2
        Me.plazo_DropDownList.DataBind()


        'For Each fila In ds.Tables(0).Rows
        '    nombres_DropDownList.Items.Add(fila("nombre"))
        'Next

        'For Each fila In ds1.Tables(0).Rows
        '    tasa_DropDownList.Items.Add(fila("ntasint"))
        'Next
        'For Each fila In ds2.Tables(0).Rows
        '    plazo_DropDownList.Items.Add(fila("nplazo"))
        'Next

        monto1_TextBox.Text = 0
        monto2_TextBox.Text = 0
    End Sub
    Protected Sub ejecutar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ejecutar_Button.Click
        Dim miclase1 As New clase_funciones
        Dim str_select As String = ""
        Dim fec1 As String = miclase1.ToString(desde_TextBox.Text).ToString
        Dim fec2 As String = miclase1.ToString(hasta_TextBox.Text).ToString
        Dim ano As Integer = Integer.Parse(fec2.Substring(7, 4))
        Dim lcCodofi As String = ddlOficinas.SelectedValue.Trim
        Dim lcNomOfi As String = "OFICINA: " & ddlOficinas.SelectedItem.Text.Trim

        'Antes de publicar cambiar el nombre de la base de produccion - Alex
        Dim base_produccion As String = "MFAMIGA"

        Dim f1 As String, f2 As String
        f1 = desde_TextBox.Text
        f2 = hasta_TextBox.Text
        Dim tit As String

        Dim todas As String = "NO"
        If ckbTodas.Checked = True Then
            todas = "SI"
        End If

        'Agregado para enviar el tipo de exportación del reporte al contenedor -- Alex 29/11/2011
        Session("tipoexportar") = Me.ddlexportar.SelectedValue.Trim

        If RadioButton1.Checked = True Then
            tit = miclase1.ToString("CAPTACION DE APORTACIONES POR PAGO DE CREDITOS DEL " & f1 & " AL " & f2)
            If ckbTodas.Checked Then
                str_select = "set language spanish; select " & tit & " as titulo, cre.ccodcta, cre.ccodcli, " & _
                             "cli.cnomcli, cre.nmonapr, kar.dfecsis, kar.nmonto " & _
                             "from cremcre as cre, credkar as kar, climide as cli " & _
                             "where kar.cconcep = '01' and kar.cdescob = 'D' and " & _
                             "kar.cestado <> 'X' and kar.dfecsis >= " & fec1 & " and " & _
                             "kar.dfecsis <= " & fec2 & " and kar.ccodcta = cre.ccodcta and " & _
                             "cre.ccodcli = cli.ccodcli order by kar.dfecsis "
            ElseIf ddlOficinas.SelectedValue.Trim = "001" Then
                'tit &= "- OFICINA CENTRAL"
                str_select = "set language spanish; select " & tit & " as titulo, cre.ccodcta, cre.ccodcli, " & _
                             "cli.cnomcli, cre.nmonapr, kar.dfecsis, kar.nmonto " & _
                             "from cremcre as cre, credkar as kar, climide as cli " & _
                             "where kar.cconcep = '01' and kar.cdescob = 'D' and " & _
                             "kar.cestado <> 'X' and kar.dfecsis >= " & fec1 & " and " & _
                             "kar.dfecsis <= " & fec2 & " and kar.ccodcta = cre.ccodcta and " & _
                             "cre.ccodcli = cli.ccodcli and cli.ccodofi='001' order by kar.dfecsis "
            Else
                'tit &= "- AGENCIA METAPAN"
                str_select = "set language spanish; select " & tit & " as titulo, cre.ccodcta, cre.ccodcli, " & _
                             "cli.cnomcli, cre.nmonapr, kar.dfecsis, kar.nmonto " & _
                             "from cremcre as cre, credkar as kar, climide as cli " & _
                             "where kar.cconcep = '01' and kar.cdescob = 'D' and " & _
                             "kar.cestado <> 'X' and kar.dfecsis >= " & fec1 & " and " & _
                             "kar.dfecsis <= " & fec2 & " and kar.ccodcta = cre.ccodcta and " & _
                             "cre.ccodcli = cli.ccodcli and cli.ccodofi='002' order by kar.dfecsis "

            End If

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_captacion_aportaciones_creditos")
        ElseIf RadioButton2.Checked = True Then
            If ckbTodas.Checked Then
                str_select = "select  'CTAS. DE AHORRO BLOQUEADAS' as titulo, aho.cnudotr as asociado, " & _
                             "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nsaldoaho as saldo " & _
                             "from ahomcta as aho, climide as cli where aho.cbloqueo = 'SI' and aho.cnudotr = cli.ccodcli order by cli.cnomcli"
            ElseIf ddlOficinas.SelectedValue.Trim = "001" Then
                str_select = "select  'CTAS. DE AHORRO BLOQUEADAS - CENTRAL' as titulo, aho.cnudotr as asociado, " & _
                             "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nsaldoaho as saldo " & _
                             "from ahomcta as aho, climide as cli where aho.cbloqueo = 'SI' and aho.cnudotr = cli.ccodcli and cli.ccodofi='001' order by cli.cnomcli"
            Else
                str_select = "select  'CTAS. DE AHORRO BLOQUEADAS - METAPAN' as titulo, aho.cnudotr as asociado, " & _
                             "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nsaldoaho as saldo " & _
                             "from ahomcta as aho, climide as cli where aho.cbloqueo = 'SI' and aho.cnudotr = cli.ccodcli and cli.ccodofi='002' order by cli.cnomcli"
            End If
            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "Bloqueados")
        ElseIf RadioButton3.Checked = True Then
            If ckbTodas.Checked Then
                str_select = "select  'CTAS. DE AHORRO CHEQUES EN COMPENSACION' as titulo, aho.cnudotr as asociado, " & _
                 "aho.ccodaho as cuenta, cli.cnomcli as nombre, mov.dfecope as fecha, mov.dfecope+10 as fecha1, mov.nmonto as saldo " & _
                 "from ahommov as mov, ahomcta as aho, climide as cli where mov.ncompen = 1 and " & _
                 "mov.ccodaho = aho.ccodaho and aho.cnudotr = cli.ccodcli order by cli.cnomcli"
            ElseIf ddlOficinas.SelectedValue.Trim = "001" Then
                str_select = "select  'CTAS. DE AHORRO CHEQUES EN COMPENSACION - CENTRAL' as titulo, aho.cnudotr as asociado, " & _
                 "aho.ccodaho as cuenta, cli.cnomcli as nombre, mov.dfecope as fecha, mov.dfecope+10 as fecha1, mov.nmonto as saldo " & _
                 "from ahommov as mov, ahomcta as aho, climide as cli where mov.ncompen = 1 and " & _
                 "mov.ccodaho = aho.ccodaho and aho.cnudotr = cli.ccodcli and cli.ccodofi='001' order by cli.cnomcli"
            Else
                str_select = "select  'CTAS. DE AHORRO CHEQUES EN COMPENSACION - METAPAN' as titulo, aho.cnudotr as asociado, " & _
                 "aho.ccodaho as cuenta, cli.cnomcli as nombre, mov.dfecope as fecha, mov.dfecope+10 as fecha1, mov.nmonto as saldo " & _
                 "from ahommov as mov, ahomcta as aho, climide as cli where mov.ncompen = 1 and " & _
                 "mov.ccodaho = aho.ccodaho and aho.cnudotr = cli.ccodcli and cli.ccodofi='002' order by cli.cnomcli"
            End If
            
            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "Bloqueados")


        ElseIf RadioButton4.Checked = True Then
            If ckbTodas.Checked Then
                str_select = "select  'CTAS. DE AHORRO BLOQUEDAS X DESEMBOLSO' as titulo, aho.cnudotr as asociado, " & _
                "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nsaldoaho as saldo " & _
                "from ahomcta as aho, climide as cli where aho.llave = 'DESEMBOLSO' and aho.cnudotr = cli.ccodcli order by cli.cnomcli"
            ElseIf ddlOficinas.SelectedValue.Trim = "001" Then
                str_select = "select  'CTAS. DE AHORRO BLOQUEDAS X DESEMBOLSO - CENTRAL' as titulo, aho.cnudotr as asociado, " & _
                "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nsaldoaho as saldo " & _
                "from ahomcta as aho, climide as cli where aho.llave = 'DESEMBOLSO' " & _
                "and aho.cnudotr = cli.ccodcli and ccodofi='001' order by cli.cnomcli"
            Else
                str_select = "select  'CTAS. DE AHORRO BLOQUEDAS X DESEMBOLSO - METAPAN' as titulo, aho.cnudotr as asociado, " & _
                "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nsaldoaho as saldo " & _
                "from ahomcta as aho, climide as cli where aho.llave = 'DESEMBOLSO' " & _
                "and aho.cnudotr = cli.ccodcli and ccodofi='002' order by cli.cnomcli"
            End If

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "Bloqueados")

        ElseIf RadioButton5.Checked = True Then
            If ckbTodas.Checked Then
                str_select = "select  'CTAS. DE AHORRO MONTOS RESTRINGIDOS' as titulo, aho.cnudotr as asociado, " & _
                 "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nmonres as saldo " & _
                 "from ahomcta as aho, climide as cli where aho.nmonres > 0 and aho.cnudotr = cli.ccodcli order by cli.cnomcli"
            ElseIf ddlOficinas.SelectedValue.Trim = "001" Then
                str_select = "select  'CTAS. DE AHORRO MONTOS RESTRINGIDOS - CENTRAL' as titulo, aho.cnudotr as asociado, " & _
                 "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nmonres as saldo " & _
                 "from ahomcta as aho, climide as cli where aho.nmonres > 0 and aho.cnudotr = cli.ccodcli and ccodofi='001' order by cli.cnomcli"
            Else
                str_select = "select  'CTAS. DE AHORRO MONTOS RESTRINGIDOS - METAPAN' as titulo, aho.cnudotr as asociado, " & _
                 "aho.ccodaho as cuenta, cli.cnomcli as nombre, aho.dfecapr as fecha, aho.nmonres as saldo " & _
                 "from ahomcta as aho, climide as cli where aho.nmonres > 0 and aho.cnudotr = cli.ccodcli and ccodofi='002' order by cli.cnomcli"
            End If
            
            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "Bloqueados")
        ElseIf RadioButton6.Checked = True Then
            tit = miclase1.ToString("ASOCIADOS ACTIVOS INGRESADOS DEL " & f1 & " AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim
            If todas = "SI" Then
                str_select = "set language spanish; select distinct " & tit & " as titulo, cli.ccodcli, cli.cnomcli, cli.cdirdom, cli.cteldom, cli.ccodcon, " & _
                                 "cli.cnudoci, cli.cnudotr, cli.cbenef2, prf.cdescri as profesion, year(getdate()) - year(cli.dnacimi) as edad, " & _
                                 "cli.csexo, aho.ccodaho, aho.nsaldoaho, cli.dregist as dfecope " & _
                                 "from climide as cli, ahomcta as aho, tabtprf as prf " & _
                                 "where cli.lactivado = 1 and cli.ccodpro = prf.ccodigo and " & _
                                 "cli.ccodcli = aho.cnudotr and substring(aho.ccodaho,7,2) = '06' and " & _
                                 "cli.dregist >= " & fec1 & " and cli.dregist <= " & fec2 & _
                                 " order by profesion, cli.ccodcli "
            Else
                str_select = "set language spanish; select distinct " & tit & " as titulo, cli.ccodcli, cli.cnomcli, cli.cdirdom, cli.cteldom, cli.ccodcon, " & _
                                 "cli.cnudoci, cli.cnudotr, cli.cbenef2, prf.cdescri as profesion, year(getdate()) - year(cli.dnacimi) as edad, " & _
                                 "cli.csexo, aho.ccodaho, aho.nsaldoaho, cli.dregist as dfecope " & _
                                 "from climide as cli, ahomcta as aho, tabtprf as prf " & _
                                 "where cli.lactivado = 1 and cli.ccodpro = prf.ccodigo and cli.ccodofi = " & miclase1.ToString(ofice) & " and " & _
                                 "cli.ccodcli = aho.cnudotr and substring(aho.ccodaho,7,2) = '06' and " & _
                                 "cli.dregist >= " & fec1 & " and cli.dregist <= " & fec2 & _
                                 " order by profesion, cli.ccodcli "

            End If
            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_asociados_categoria")

            ElseIf RadioButton7.Checked = True Then
            tit = miclase1.ToString("ASOCIADOS INACTIVOS CON MAS DE 365 DIAS")

            Dim ofice As String = ddlOficinas.SelectedValue.Trim
            If todas = "SI" Then
                str_select = "set language spanish; select distinct " & tit & " as titulo, cli.ccodcli, cli.cnomcli, cli.cdirdom, cli.cteldom, cli.ccodcon, " & _
                                 "cli.cnudoci, cli.cnudotr, cli.cbenef2, prf.cdescri as profesion, year(getdate()) - year(cli.dnacimi) as edad, " & _
                                 "cli.csexo, aho.ccodaho, aho.nsaldoaho, aho.dfechault as dfecope " & _
                                 "from climide as cli, ahomcta as aho, tabtprf as prf " & _
                                 "where cli.lactivado = 1 and cli.ccodpro = prf.ccodigo and " & _
                                 "cli.ccodcli = aho.cnudotr and substring(aho.ccodaho,7,2) = '06' and " & _
                                 "datediff(day,aho.dfechault,getdate()) > 365" & _
                                 " order by profesion, cli.ccodcli"
            Else
                str_select = "set language spanish; select distinct " & tit & " as titulo, cli.ccodcli, cli.cnomcli, cli.cdirdom, cli.cteldom, cli.ccodcon, " & _
                                 "cli.cnudoci, cli.cnudotr, cli.cbenef2, prf.cdescri as profesion, year(getdate()) - year(cli.dnacimi) as edad, " & _
                                 "cli.csexo, aho.ccodaho, aho.nsaldoaho, aho.dfechault as dfecope " & _
                                 "from climide as cli, ahomcta as aho, tabtprf as prf " & _
                                 "where cli.lactivado = 1 and cli.ccodpro = prf.ccodigo and cli.ccodofi = " & miclase1.ToString(ofice) & " and " & _
                                 "cli.ccodcli = aho.cnudotr and substring(aho.ccodaho,7,2) = '06' and " & _
                                 "datediff(day,aho.dfechault,getdate()) > 365" & _
                                 " order by profesion, cli.ccodcli"

            End If
            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_asociados_categoria")

            ElseIf RadioButton8.Checked = True Then
            tit = miclase1.ToString("ASOCIADOS RETIRADOS DEL " & f1 & " AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "SELECT " & tit & " as titulo,cli.ccodcli, cli.cnomcli, cli.cdirdom, cli.cteldom, cli.ccodcon, " & _
                    "cli.cnudoci, cli.cnudotr, cli.cbenef2, prf.cdescri as profesion, " & _
                    "year(getdate()) - year(cli.dnacimi) as edad, cli.csexo, " & _
                    "mov.ccodaho, mov.nmonto as nsaldoaho, mov.dfecope " & _
                    "from ahommov as mov, ahomcta as cta, climide as cli, tabtprf as prf " & _
                    "WHERE SUBSTRing(mov.ccodaho,7,2) = '06' and " & _
                    "mov.dfecope >= " & fec1 & " AND mov.dfecope <= " & fec2 & _
                    " AND mov.nsaldoaho = 0 AND mov.ccodaho = cta.ccodaho " & _
                    "AND cta.cnudotr = cli.ccodcli AND lactivado = 0 and prf.ccodigo =cli.ccodpro " & _
                    "order by profesion,cli.ccodcli"
            Else
                str_select = "SELECT " & tit & " as titulo,cli.ccodcli, cli.cnomcli, cli.cdirdom, cli.cteldom, cli.ccodcon, " & _
                    "cli.cnudoci, cli.cnudotr, cli.cbenef2, prf.cdescri as profesion, " & _
                    "year(getdate()) - year(cli.dnacimi) as edad, cli.csexo, " & _
                    "mov.ccodaho, mov.nmonto as saldoaho, mov.dfecope " & _
                    "from ahommov as mov, ahomcta as cta, climide as cli, tabtprf as prf " & _
                    "WHERE SUBSTRing(mov.ccodaho,7,2) = '06' and " & _
                    "mov.dfecope >= " & fec1 & " AND mov.dfecope <= " & fec2 & _
                    " AND mov.nsaldoaho = 0 AND mov.ccodaho = cta.ccodaho " & _
                    "AND cta.cnudotr = cli.ccodcli AND lactivado = 0 and cli.ccodofi = " & miclase1.ToString(ofice) & " and prf.ccodigo =cli.ccodpro " & _
                    "order by profesion,cli.ccodcli"

            End If

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_asociados_categoria")

            ElseIf RadioButton9.Checked = True Then

            tit = miclase1.ToString("CAPITALIZACION TRIMESTRAL DE CARTERA DE AHORRO AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish; select " & tit & " as titulo, trs.cnomtrs,  cta.cnudotr, cli.cnomcli as nombre, " & _
                                     "mov.dfecope, mov.nmonto as interes, mov.nsaldoaho - mov.nmonto as saldo_ant, mov.nsaldoaho as saldo_act " & _
                                     "from ahomcta as cta, ahommov as mov, ahomtrs as trs, climide as cli " & _
                                     "where mov.dfecope = " & fec2 & " and mov.cnumdoc = 'CAPITALI' and mov.ccodaho = cta.ccodaho and " & _
                                     "substring (cta.ccodaho,7,2) = trs.ccodtrs and cta.cnudotr = cli.ccodcli " & _
                                     "order by trs.cnomtrs, cta.nombre"
            Else
                str_select = "set language spanish; select " & tit & " as titulo, trs.cnomtrs,  cta.cnudotr, cli.cnomcli as nombre, " & _
                     "mov.dfecope, mov.nmonto as interes, mov.nsaldoaho - mov.nmonto as saldo_ant, mov.nsaldoaho as saldo_act " & _
                     "from ahomcta as cta, ahommov as mov, ahomtrs as trs, climide as cli " & _
                     "where mov.dfecope = " & fec2 & " and mov.cnumdoc = 'CAPITALI' and mov.ccodaho = cta.ccodaho and " & _
                     "substring (cta.ccodaho,7,2) = trs.ccodtrs and cta.cnudotr = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & " " & _
                     "order by trs.cnomtrs, cta.nombre"

            End If

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_capitalizacion")

            ElseIf RadioButton10.Checked = True Then
            tit = miclase1.ToString("CAPITALIZACION TRIMESTRAL DE CARTERA DE AHORRO AL " & f2)
            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish; select " & tit & " as titulo, trs.cnomtrs, count(*) as cuentas, sum(nmonto) as interes, " & _
            "sum( mov.nsaldoaho - mov.nmonto) as saldo_ant, sum(mov.nsaldoaho) as saldo_act " & _
            "from ahomcta as cta, ahommov as mov, ahomtrs as trs " & _
            "where mov.dfecope = " & fec2 & " and mov.cnumdoc = 'CAPITALI' and mov.ccodaho = cta.ccodaho and " & _
            "substring (cta.ccodaho,7,2) = trs.ccodtrs  " & _
            "group by trs.cnomtrs " & _
            "order by trs.cnomtrs "
            Else
                str_select = "set language spanish; select " & tit & " as titulo, trs.cnomtrs, count(*) as cuentas, sum(nmonto) as interes, " & _
            "sum( mov.nsaldoaho - mov.nmonto) as saldo_ant, sum(mov.nsaldoaho) as saldo_act " & _
            "from ahomcta as cta, ahommov as mov, ahomtrs as trs, climide as cli " & _
            "where mov.dfecope = " & fec2 & " and mov.cnumdoc = 'CAPITALI' and mov.ccodaho = cta.ccodaho and cta.cnudotr = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & " and " & _
            "substring (cta.ccodaho,7,2) = trs.ccodtrs  " & _
            "group by trs.cnomtrs " & _
            "order by trs.cnomtrs "

            End If

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_capitalizacion_resumida")
        ElseIf RadioButton11.Checked = True Then
            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            tit = miclase1.ToString("CERTIFICADOS RENOVADOS DEL " & f1 & " AL " & f2)

            Session("pcNomOfi") = lcNomOfi

            If todas = "SI" Then

                lcNomOfi = "Todas las Oficinas"

                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                "from ahomcrt as crt " & _
                "where crt.cestado = 'R' and crt.dmenpro >=" & fec1 & " and crt.dmenpro <= " & fec2
            Else
                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                "from ahomcrt as crt, climide as cli " & _
                "where crt.cestado = 'R' and crt.dmenpro >=" & fec1 & " and crt.dmenpro <= " & fec2 & " and crt.cnudotr = cli.ccodcli " & _
                "and cli.ccodofi = " & miclase1.ToString(ofice)

            End If




            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")

        ElseIf RadioButton12.Checked = True Then

            tit = miclase1.ToString("CERTIFICADOS ANULADOS DEL " & f1 & " AL " & f2)
            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            Session("pcNomOfi") = lcNomOfi

            If todas = "SI" Then
                lcNomOfi = "Todas las Oficinas"

                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & tit & " as titulo, anu.cnudotr, anu.ccodcrt, anu.nombre, anu.dfecapr, " & _
                "anu.dfecven, anu.dfecapr as dfecori, anu.dfecprv as dultpro, anu.nmonapr, anu.nplazo, 000 as ntasint, anu.ccodaho as creditos " & _
                "from anulados as anu " & _
                "where anu.dfecapr >= " & fec1 & " and anu.dfecapr <= " & fec2 & _
                " order by anu.ccodcrt"
            Else
                str_select = "set language spanish; select " & tit & " as titulo, anu.cnudotr, anu.ccodcrt, anu.nombre, anu.dfecapr, " & _
                "anu.dfecven, anu.dfecapr as dfecori, anu.dfecprv as dultpro, anu.nmonapr, anu.nplazo, 000 as ntasint, anu.ccodaho as creditos " & _
                "from anulados as anu, climide as cli " & _
                " where anu.dfecapr >= " & fec1 & " and anu.dfecapr <= " & fec2 & " and anu.cnudotr = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & _
                " order by anu.ccodcrt"

            End If


            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")

        ElseIf RadioButton13.Checked = True Then

            tit = miclase1.ToString("CERTIFICADOS CANCELADOS DEL " & f1 & " AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim
            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"

                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                "from ahomcrt as crt " & _
                "where crt.cliq = 'S' and crt.cestado = 'C' and crt.dultpro >= " & fec1 & " and crt.dultpro <= " & fec2 & _
                " order by crt.ccodcrt"
            Else
                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                "from ahomcrt as crt, climide as cli  " & _
                "where crt.cliq = 'S' and crt.cestado = 'C' and crt.dultpro >= " & fec1 & " and crt.dultpro <= " & fec2 & _
                " and crt.cnudotr = cli.ccodcli and crt.ccodofi = " & miclase1.ToString(ofice) & _
                " order by crt.ccodcrt"

            End If

            Session("pcNomOfi") = lcNomOfi

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")

        ElseIf RadioButton14.Checked = True Then
            tit = miclase1.ToString("CERTIFICADOS APERTURADOS DEL " & f1 & " AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim


            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas

                lcNomOfi = "Todas las Oficinas"

                'str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                '            "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                '            "from ahomcrt as crt " & _
                '            "where crt.cliq <> 'S' and crt.nmonapr > 0 and crt.dfecori >= " & fec1 & " and crt.dfecori <= " & fec2 & _
                '            " order by crt.ccodcrt"
                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecori as dfecapr, " & _
                            "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                            "from ahomcrt as crt " & _
                            "where crt.cestado in('A','R','C','P') and crt.nmonapr > 0 and crt.dfecori >= " & fec1 & " and crt.dfecori <= " & fec2 & _
                            " order by crt.ccodcrt"
            Else
                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecori as dfecapr, " & _
                            "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                            "from ahomcrt as crt, climide as cli " & _
                            "where crt.cestado in('A','R','C','P') and crt.nmonapr > 0 and crt.dfecori >= " & fec1 & " and crt.dfecori <= " & fec2 & _
                            " and crt.cnudotr = cli.ccodcli and crt.ccodofi = " & miclase1.ToString(ofice) & _
                            " order by crt.ccodcrt"

            End If

            Session("pcNomOfi") = lcNomOfi

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")

        ElseIf RadioButton15.Checked = True Then
            'str_select = "basura"
            tit = miclase1.ToString("CERTIFICADOS PIGNORADOS DEL " & f1 & " AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            Session("pcNomOfi") = lcNomOfi

            If todas = "SI" Then
                lcNomOfi = "Todas las Oficinas"

                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                "from ahomcrt as crt " & _
                "where crt.cliq = 'S' and crt.nmonapr > 0 and crt.dfecori >= " & fec1 & " and crt.dfecori <= " & fec2 & _
                " order by crt.ccodcrt"
            Else
                str_select = "set language spanish; select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
                "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, crt.ccodaho as creditos " & _
                "from ahomcrt as crt, climide as cli " & _
                "where crt.cliq = 'S' and crt.nmonapr > 0 and crt.dfecori >= " & fec1 & " and crt.dfecori <= " & fec2 & _
                " and crt.cnudotr = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & _
                " order by crt.ccodcrt"

            End If


            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pignorados")
            '  Exit Sub

        ElseIf RadioButton16.Checked = True Then
            Dim nombre As String = nombres_DropDownList.SelectedValue.ToString.Trim
            Dim part As Double = 0
            Dim cuantos As Decimal = 0
            Dim cuantos1 As Decimal = 0
            Dim miclase As New clase_jaime
            Dim con As New SqlConnection
            Dim stringconnection As String = miclase.conexion()



            con.ConnectionString = stringconnection
            con.Open()

            str_select = "select count(*) as cuantos from ahomcrt where cliq <> 'S' "

            cuantos = miclase.devolver_scalar1(con, str_select)


            str_select = "select count(*) as cuantos1 from ahomcrt where cliq <> 'S' and nombre = " & miclase1.ToString(nombre)
            cuantos1 = miclase.devolver_scalar1(con, str_select)

            part = cuantos1 / cuantos * 100
            part = Math.Round(part, 2)
            con.Close()


            tit = "PARTICIPACION EN CARTERA " & part.ToString & "%"

            tit = miclase1.ToString(tit)

            str_select = "select " & tit & " as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
           "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, ccodaho as creditos " & _
           "from ahomcrt as crt   where crt.cliq <> 'S' and crt.nmonapr > 0 and  nombre = " & miclase1.ToString(nombre)

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")

        ElseIf RadioButton17.Checked = True Then

            str_select = "select 'CERTIFICADOS POR TASA' as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
            "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, space(160) as creditos " & _
            "from ahomcrt as crt   where crt.cliq <> 'S' and crt.nmonapr > 0 and  ntasint = " & tasa_DropDownList.SelectedValue & " order by nombre"

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")


        ElseIf RadioButton18.Checked = True Then

            str_select = "select 'CERTIFICADOS POR PLAZOS' as titulo, crt.cnudotr, crt.ccodcrt, crt.nombre, crt.dfecapr, " & _
            "crt.dfecven, crt.dfecori, crt.dultpro, crt.nmonapr, crt.nplazo, crt.ntasint, space(160) as creditos " & _
            "from ahomcrt as crt   where crt.cliq <> 'S' and crt.nmonapr > 0 and  nplazo = " & plazo_DropDownList.SelectedValue & " order by nombre"

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "certificados")

        ElseIf RadioButton19.Checked = True Then
            tit = miclase1.ToString("INACTIVIDAD DE CUENTAS DE AHORRO > 365 DIAS")

            str_select = "set language spanish; select  " & tit & " as titulo,  cli.ccodcli, cli.cnomcli as cnomcli, cta.ccodaho,  " & _
                             "cta.dfecult, cta.nlibreta, cta.nsaldoaho, trs.cnomtrs " & _
                             "from climide as cli, ahomcta as cta, ahomtrs as trs " & _
                             "where DATEDIFF(day ,cta.dfecult,getdate()) > 365 and " & _
                             "cta.cnudotr = cli.ccodcli and " & _
                             "substring(cta.ccodaho, 7, 2) = trs.ccodtrs and cta.nsaldoaho > 0" & _
                             "order by trs.cnomtrs, cta.dfecult"

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_inactividad_cuentas_ahorros")

        ElseIf RadioButton20.Checked = True Then

            tit = miclase1.ToString("DIVIDENDOS PAGADOS EN EL AÑO " & ano.ToString)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish; select " & tit & " as titulo, mov.cnumcom, mov.ndebe, mov.dfeccnt, " & _
                                  "dia.cglosa  " & _
                                  "from cntamov as mov, diario as dia " & _
                                  "where mov.cnumcom = dia.cnumcom and " & _
                                  "year(mov.dfeccnt) = " & ano & " and " & _
                                  "mov.ccodcta = '2211040101'  and " & _
                                  "mov.cflc = ' ' and mov.cnumdoc <> 'F' and ndebe > 0.00  order by dia.cglosa "
            Else
                str_select = "set language spanish; select " & tit & " as titulo, mov.cnumcom, mov.ndebe, mov.dfeccnt, " & _
                                  "dia.cglosa  " & _
                                  "from cntamov as mov, diario as dia " & _
                                  "where mov.cnumcom = dia.cnumcom and dia.ccodofi = " & miclase1.ToString(ofice) & " and " & _
                                  "year(mov.dfeccnt) = " & ano & " and " & _
                                  "mov.ccodcta = '2211040101'  and " & _
                                  "mov.cflc = ' ' and mov.cnumdoc <> 'F' and ndebe > 0.00  order by dia.cglosa "

            End If

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_dividendos_pagados")

        ElseIf RadioButton21.Checked = True Then
            tit = miclase1.ToString("DIVIDENDOS CALCULADOS EN EL AÑO " & ano.ToString)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish; select " & tit & " as titulo, ccodcli, crazon, nmonto, " & _
                                 "ncomple, nmonto + ncomple as total, nsaldoaho, nsaldnind " & _
                                 "from ahompro  order by crazon "
            Else
                str_select = "set language spanish; select " & tit & " as titulo, pro.ccodcli, pro.crazon, pro.nmonto, " & _
                     "pro.ncomple, pro.nmonto + pro.ncomple as total, pro.nsaldoaho, pro.nsaldnind " & _
                     "from ahompro as pro, climide as cli  where  pro.ccodcli = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & " order by pro.crazon "

            End If

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_dividendos_calculados")

        ElseIf RadioButton22.Checked = True Then
            tit = miclase1.ToString("DIVIDENDOS PENDIENTES EN EL AÑO " & ano.ToString)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish; select " & tit & " as titulo, ccodcli, crazon, nmonto, " & _
                                 "ncomple, nmonto + ncomple as total, nsaldoaho, nsaldnind " & _
                                 "from ahompro where  cestado <> 'X'  order by crazon "
            Else
                str_select = "set language spanish; select " & tit & " as titulo, pro.ccodcli, pro.crazon, pro.nmonto, " & _
                                 "pro.ncomple, pro.nmonto + pro.ncomple as total, pro.nsaldoaho, pro.nsaldnind " & _
                                 "from ahompro as pro, climide as cli where  pro.cestado <> 'X' and  " & _
                                 "pro.ccodcli = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & " order by pro.crazon "

            End If

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_dividendos_pendientes")
        ElseIf RadioButton23.Checked = True Then
            tit = miclase1.ToString("ASOCIADOS CUBIERTOS POR FONDO DE DEFUNCION DEL " & f1 & " AL " & f2)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish; select " & tit & " as titulo, cat.ccodcta, dia.cglosa, dia.cnumcom, dia.dfeccnt, " & _
                                 "mov.nhaber, mov.ccodusu1, mov.casocia, mov.ccodcli " & _
                                 "from ctbmcta as cat, diario as dia, cntamov as mov " & _
                                 "where cat.ccodcta = '2212041301' and cat.ccodcta = mov.ccodcta and " & _
                                 "mov.cnumcom = dia.cnumcom and mov.nhaber > 0 and " & _
                                 "mov.dfeccnt >= " & fec1 & " and mov.dfeccnt <= " & fec2 & _
                                 " order by dia.cglosa, mov.dfeccnt"
            Else
                str_select = "set language spanish; select " & tit & " as titulo, cat.ccodcta, dia.cglosa, dia.cnumcom, dia.dfeccnt, " & _
                                 "mov.nhaber, mov.ccodusu1, mov.casocia, mov.ccodcli " & _
                                 "from ctbmcta as cat, diario as dia, cntamov as mov " & _
                                 "where cat.ccodcta = '2212041301' and cat.ccodcta = mov.ccodcta and " & _
                                 "mov.cnumcom = dia.cnumcom and mov.nhaber > 0 and " & _
                                 "mov.dfeccnt >= " & fec1 & " and mov.dfeccnt <= " & fec2 & _
                                 " and mov.ccodofi = " & miclase1.ToString(ofice) & _
                                 " order by dia.cglosa, mov.dfeccnt"

            End If

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "fondo_cubiertos")

        ElseIf RadioButton24.Checked = True Then
            tit = miclase1.ToString("PROVISION DIARIA DE CARTERA DE AHORROS DEL " & f1 & " AL " & f2)

            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"


                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish;  select " & tit & " as titulo, trs.cnomtrs, dia.fecha, dia.ccodcli, " & _
                             "dia.ccodaho, dia.nombre, sum(saldo) as saldo, sum(interes) as interes " & _
                             "from interes_diario as dia, ahomtrs as trs " & _
                             "where dia.fecha >= " & fec1 & " and dia.fecha <= " & fec2 & " and " & _
                             "substring(dia.ccodaho,7,2) = trs.ccodtrs and interes > 0 " & _
                             "group by trs.cnomtrs, dia.fecha, dia.ccodaho,dia.ccodcli,dia.nombre " & _
                             "order by trs.cnomtrs, dia.fecha, dia.nombre "
            Else
                str_select = "set language spanish;  select " & tit & " as titulo, trs.cnomtrs, dia.fecha, dia.ccodcli, " & _
                             "dia.ccodaho, dia.nombre, sum(saldo) as saldo, sum(interes) as interes " & _
                             "from interes_diario as dia, ahomtrs as trs " & _
                             "where dia.fecha >= " & fec1 & " and dia.fecha <= " & fec2 & " and " & _
                             "substring(dia.ccodaho,7,2) = trs.ccodtrs and interes > 0 " & _
                             " and substring(dia.ccodaho,4,3) = '" & lcCodofi & "' " & _
                             "group by trs.cnomtrs, dia.fecha, dia.ccodaho,dia.ccodcli,dia.nombre " & _
                             "order by trs.cnomtrs, dia.fecha, dia.nombre "
            End If


            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_provision_diaria")


        ElseIf RadioButton25.Checked = True Then
            Dim monto1 As Decimal = Decimal.Parse(monto1_TextBox.Text)
            Dim monto2 As Decimal = Decimal.Parse(monto2_TextBox.Text)


            str_select = "set language spanish; select 'CONCENTRACION DE DEPOSITOS A PLAZO POR MONTO APERTURADO' as titulo, " & _
            "crt.cnudotr, max(crt.ccodcrt) as ccodcrt, crt.nombre, max(crt.dfecapr) as dfecapr, " & _
            "max(crt.dfecven) as dfecven, max(crt.dfecori) as dfecori, sum(crt.nmonapr) as nmonapr,  " & _
            "max(crt.nplazo) as nplazo, max(crt.ntasint) as ntasint, space(160) as creditos  " & _
            "from ahomcrt as crt  " & _
            "where crt.cliq <> 'S'  " & _
            "group by crt.cnudotr, crt.nombre " & _
            "having sum(crt.nmonapr) >= " & monto1 & " and sum(crt.nmonapr) <= " & monto2 & _
            "order by sum(crt.nmonapr) desc, crt.nombre "

            Session("str_select") = str_select

            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_mayor_concentracion")

        ElseIf RadioButton26.Checked = True Then
            Dim titulo As String = miclase1.ToString("CERTIFICADOS A PLAZO VENCIDOS Y PAGO DE INTERESES " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)
            str_select = "set language spanish; select " & titulo & " as titulo, " & _
                  "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, ven.nintere,  " & _
                  "crt.dfecori, crt.dfecapr, crt.dfecven, ven.dfecpro " & _
                 "from vencidos as ven, ahomcrt as crt " & _
                 "where ven.dfecpro >= " & fec1 & " and ven.dfecpro <= " & fec2 & " and ven.nintere >  0 " & _
                 "and ven.ccodcrt = crt.ccodcrt and crt.nmonapr > 0 " & _
                 "order by ven.dfecpro, crt.ccodcrt "

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses")

        ElseIf RadioButton27.Checked = True Then
            tit = miclase1.ToString("RESUMEN PROVISION DIARIA DE CARTERA DE AHORROS DEL " & f1 & " AL " & f2)


            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"

                Session("pcNomOfi") = lcNomOfi
                str_select = "set language spanish;  select " & tit & " as titulo, trs.cnomtrs,  " & _
                             "count(*) as cuantos, sum(saldo) as saldo, sum(interes) as interes " & _
                             "from interes_diario as dia, ahomtrs as trs " & _
                             "where dia.fecha between " & fec1 & " and " & fec2 & " and " & _
                             "substring(dia.ccodaho, 7, 2) = trs.ccodtrs " & _
                             "group by trs.cnomtrs order by trs.cnomtrs "
            Else
                str_select = "set language spanish;  select " & tit & " as titulo, trs.cnomtrs,  " & _
                             "count(*) as cuantos, sum(saldo) as saldo, sum(interes) as interes " & _
                             "from interes_diario as dia, ahomtrs as trs " & _
                             "where dia.fecha between " & fec1 & " and " & fec2 & " and " & _
                             "substring(dia.ccodaho, 7, 2) = trs.ccodtrs " & _
                             " and substring(dia.ccodaho,4,3) = '" & lcCodofi & "' " & _
                             "group by trs.cnomtrs order by trs.cnomtrs "

            End If


            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "resumen_provision_ahorros")




        ElseIf RadioButton28.Checked = True Then

            Dim titulo As String = miclase1.ToString("PROVISION DIARIA DE INTERESES " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"


                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                              "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, int.nintere,  " & _
                              "crt.dfecori, crt.dfecapr, crt.dfecven, int.dfecpro " & _
                              "from ahomint as int, ahomcrt as crt " & _
                              "where int.dfecpro >= " & fec1 & " and int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                              "and int.ccodcrt = crt.ccodcrt " & _
                              "order by int.dfecpro, crt.ccodcrt "
            Else
                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                             "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, int.nintere,  " & _
                             "crt.dfecori, crt.dfecapr, crt.dfecven, int.dfecpro " & _
                             "from ahomint as int, ahomcrt as crt " & _
                             "where int.dfecpro >= " & fec1 & " and int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                             "and int.ccodcrt = crt.ccodcrt " & _
                             " and int.ccodofi = '" & lcCodofi & "' " & _
                             "order by int.dfecpro, crt.ccodcrt "

            End If

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses")


        ElseIf RadioButton29.Checked = True Then
            Dim titulo As String = miclase1.ToString("PROVISION DIARIA ACUMULADA DE INTERESES " & " AL " & hasta_TextBox.Text)

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"


                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                              "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, sum(int.nintere) as nintere,  " & _
                              "crt.dfecori, crt.dfecapr, crt.dfecven " & _
                              "from ahomint as int, ahomcrt as crt " & _
                              "where int.dfecpro >= " & fec1 & " and int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                              "and int.ccodcrt = crt.ccodcrt " & _
                              "group by crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.dfecori, crt.dfecapr, crt.dfecven " & _
                              "order by crt.ccodcrt "
            Else
                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                             "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, sum(int.nintere) as nintere,  " & _
                             "crt.dfecori, crt.dfecapr, crt.dfecven " & _
                             "from ahomint as int, ahomcrt as crt " & _
                             "where int.dfecpro >= " & fec1 & " and int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                             "and int.ccodcrt = crt.ccodcrt " & _
                             " and int.ccodofi = '" & lcCodofi & "' " & _
                             "group by crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.dfecori, crt.dfecapr, crt.dfecven " & _
                             "order by crt.ccodcrt "
            End If


            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses_acumulado")

        ElseIf RadioButton30.Checked = True Then
            Dim titulo As String = miclase1.ToString("INTEERES PENDIENTE PAGO " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"

                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                              "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, int.nintere,  " & _
                              "crt.dfecori, crt.dfecapr, crt.dfecven, int.dfecpro " & _
                             "from ahomint as int, ahomcrt as crt " & _
                             "where int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                             "and int.cflag = ' ' and int.ccodcrt = crt.ccodcrt " & _
                             "order by int.dfecpro, crt.ccodcrt "

            Else
                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                              "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, int.nintere,  " & _
                              "crt.dfecori, crt.dfecapr, crt.dfecven, int.dfecpro " & _
                             "from ahomint as int, ahomcrt as crt " & _
                             "where int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                             "and int.cflag = ' ' and int.ccodcrt = crt.ccodcrt " & _
                             "and crt.ccodofi = '" & lcCodofi & "' " & _
                             "order by int.dfecpro, crt.ccodcrt "
            End If

            

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses")


        ElseIf RadioButton31.Checked = True Then
            Dim titulo As String = miclase1.ToString("INTEERES PENDIENTE PAGO ACUMULADA " & " AL " & hasta_TextBox.Text)

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            Session("pcNomOfi") = lcNomOfi

            If ckbTodas.Checked = True Then   'Todas las Oficinas
                lcNomOfi = "Todas las Oficinas"

                Session("pcNomOfi") = lcNomOfi

                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                             "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, sum(int.nintere) as nintere,  " & _
                             "crt.dfecori, crt.dfecapr, crt.dfecven " & _
                             "from ahomint as int, ahomcrt as crt " & _
                             "where  int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                             "and int.cflag = ' ' and int.ccodcrt = crt.ccodcrt " & _
                             "group by crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.dfecori, crt.dfecapr, crt.dfecven " & _
                             "order by crt.ccodcrt "
            Else
                str_select = "set language spanish; select " & titulo & " as titulo, " & _
                             "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, sum(int.nintere) as nintere,  " & _
                             "crt.dfecori, crt.dfecapr, crt.dfecven " & _
                             "from ahomint as int, ahomcrt as crt " & _
                             "where  int.dfecpro <= " & fec2 & " and int.nintere >  0 " & _
                             "and int.cflag = ' ' and int.ccodcrt = crt.ccodcrt " & _
                             "and crt.ccodofi = '" & lcCodofi & "' " & _
                             "group by crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.dfecori, crt.dfecapr, crt.dfecven " & _
                             "order by crt.ccodcrt "

            End If


            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses_acumulado")

            ElseIf RadioButton32.Checked = True Then
                Dim miclase As New clase_jaime

                Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
                Dim backup_ahomcrt As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.ahomcrt"
                Dim backup_climide As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.climide"

            Dim resultado As Integer = 0
            Dim ldfecha As Date = Date.Parse(Me.hasta_TextBox.Text)

                Dim con As New SqlConnection
                Dim stringconnection As String = miclase.conexion()
                con.ConnectionString = stringconnection
                con.Open()

                'Para saber si la base de backup existe, sino se va a la base en vivo
                str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                             backup.ToString & "')"
                resultado = miclase.devolver_scalar1(con, str_select)

                con.Close()
                Dim ofice As String = ddlOficinas.SelectedValue.Trim

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim


            Session("pcNomOfi") = lcNomOfi

                If resultado > 0 Then
                    'Irá al backup a consultar
                If ckbTodas.Checked = True Then

                    lcNomOfi = "Todas las Oficinas"


                    Session("pcNomOfi") = lcNomOfi

                    str_select = "set language spanish; select 'SALDO DE CARTERA ' as titulo, " & _
                                "crt.ccodcrt, crt.cnudotr, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, " & _
                                "(select sum(nintere) from ahomint where ccodcrt = crt.ccodcrt and cestado <> 'X') as nintere, " & _
                                "crt.dfecori, crt.dfecapr, crt.dfecven, '" & ldfecha & "'" & " as dfecpro " & _
                                "from " & backup_ahomcrt & " as crt " & _
                                "where cestado in('A','R','P')  and nmonapr > 0 " & _
                                "order by crt.cnudotr "
                Else
                    str_select = "set language spanish; select 'SALDO DE CARTERA ' as titulo, " & _
                                "crt.ccodcrt, crt.cnudotr, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, " & _
                                "(select sum(nintere) from ahomint where ccodcrt = crt.ccodcrt and cestado <> 'X') as nintere, " & _
                                "crt.dfecori, crt.dfecapr, crt.dfecven, '" & ldfecha & "'" & " as dfecpro " & _
                                "from " & backup_ahomcrt & " as crt, " & backup_climide & " as cli " & _
                                "where cestado in('A','R','P') and nmonapr > 0 and crt.cnudotr = cli.ccodcli and " & _
                                " crt.ccodofi = " & miclase1.ToString(ofice) & _
                                " order by crt.cnudotr "

                End If

                Else
                    'Irá a la base en vivo a consultar
                If ckbTodas.Checked = True Then
                    lcNomOfi = "Todas las Oficinas"

                    Session("pcNomOfi") = lcNomOfi

                    str_select = "set language spanish; select 'SALDO DE CARTERA ' as titulo, " & _
                                "crt.ccodcrt, crt.cnudotr, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, " & _
                                "(select sum(nintere) from ahomint where ccodcrt = crt.ccodcrt and cestado <> 'X') as nintere, " & _
                                "crt.dfecori, crt.dfecapr, crt.dfecven, getdate() as dfecpro " & _
                                "from ahomcrt as crt " & _
                                "where cestado in('A','R','P') and nmonapr > 0 " & _
                                "order by crt.cnudotr "
                Else
                    str_select = "set language spanish; select 'SALDO DE CARTERA ' as titulo, " & _
                                "crt.ccodcrt, crt.cnudotr, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, " & _
                                "(select sum(nintere) from ahomint where ccodcrt = crt.ccodcrt and cestado <> 'X') as nintere, " & _
                                "crt.dfecori, crt.dfecapr, crt.dfecven, getdate() as dfecpro " & _
                                "from ahomcrt as crt, climide as cli " & _
                                "where cestado in('A','R','P') and nmonapr > 0  and crt.cnudotr = cli.ccodcli and crt.ccodofi = " & miclase1.ToString(ofice) & _
                                " order by crt.cnudotr "
                    'cliq <> 'S'
                End If
                End If

                'cvs
                If CheckBox2.Checked = True Then
                    Dim ds As DataSet
                    Dim fila As DataRow
                    ds = miclase.devolver_dataset(con, str_select)

                    Dim sw As StreamWriter = Nothing
                    sw = New StreamWriter("C:\txt\cartera_certificados.txt", False)

                    sw.Write("Certificado;")
                    sw.Write("Nombre;")
                    sw.Write("Cuenta;")
                    sw.Write("Tasa;")
                    sw.Write("Plazo;")
                    sw.Write("Monto;")
                    sw.Write("Interes_Provisionado;")
                    sw.Write("Origen;")
                    sw.Write("Vigente;")
                    sw.WriteLine("Vence")

                    For Each fila In ds.Tables(0).Rows
                        sw.Write(fila("ccodcrt") & ";")
                        sw.Write(fila("nombre") & ";")
                        sw.Write(fila("ccodaho") & ";")
                        sw.Write(fila("ntasint") & ";")
                        sw.Write(fila("nplazo") & ";")
                        sw.Write(fila("nmonapr") & ";")
                        sw.Write(fila("nintere") & ";")
                        sw.Write(fila("dfecori") & ";")
                        sw.Write(fila("dfecapr") & ";")
                        sw.WriteLine(fila("dfecven"))
                    Next


                    sw.Close()
                    sw.Dispose()


                    '**** Descargar el archivo a la PC cliente - Alex 10/12/2011 *******

                    Dim archivo As String = "cartera_certificados"
                    Dim Path As String = "c:/txt/" & archivo


                    Me.DownloadFile(Path + ".txt", archivo + ".txt")


                    '**** Fin modificacion - Alex 10/12/2011 *******

                    Exit Sub

                End If

                con.Close()
                Session("str_select") = str_select

                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses")

            ElseIf RadioButton33.Checked = True Then
                Dim miclase As New clase_jaime
                Dim titulo As String = miclase1.ToString("LIQUIDEZ DIARIA " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)

                Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
                Dim backup_ahomcrt As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.ahomcrt"

                Dim resultado As Integer = 0

                Dim con As New SqlConnection
                Dim stringconnection As String = miclase.conexion()
                con.ConnectionString = stringconnection
                con.Open()

                'Para saber si la base de backup existe, sino se va a la base en vivo
                str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                             backup.ToString & "')"
                resultado = miclase.devolver_scalar1(con, str_select)

                con.Close()

            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim


            Session("pcNomOfi") = lcNomOfi

            If resultado > 0 Then
                'Utilizará el backup de la base
                If ckbTodas.Checked = True Then
                    lcNomOfi = "Todas las Oficinas"
                    Session("pcNomOfi") = lcNomOfi


                    str_select = "set language spanish; select " & titulo & " as titulo, " & _
                                "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.nmonapr * crt.ntasint / 100 * 30 / 365 as nintere,  " & _
                                "crt.dfecori, crt.dfecapr, crt.dfecven, dfecven as dfecpro " & _
                                "from ahomcrt as crt " & _
                                "where crt.dfecven >= " & fec1 & " and crt.dfecven <= " & fec2 & " and crt.cliq <> 'S'  " & _
                                "order by crt.ccodcrt "
                Else
                    str_select = "set language spanish; select " & titulo & " as titulo, " & _
                                "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.nmonapr * crt.ntasint / 100 * 30 / 365 as nintere,  " & _
                                "crt.dfecori, crt.dfecapr, crt.dfecven, dfecven as dfecpro " & _
                                "from ahomcrt as crt " & _
                                "where crt.dfecven >= " & fec1 & " and crt.dfecven <= " & fec2 & " and crt.cliq <> 'S'  " & _
                                " and crt.ccodofi = '" & lcCodofi & "'" & _
                                "order by crt.ccodcrt "
                End If

            Else
                'Ira a la base en vivo
                If ckbTodas.Checked = True Then
                    lcNomOfi = "Todas las Oficinas"
                    Session("pcNomOfi") = lcNomOfi

                    str_select = "set language spanish; select " & titulo & " as titulo, " & _
                            "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.nmonapr * crt.ntasint / 100 * 30 / 365 as nintere,  " & _
                            "crt.dfecori, crt.dfecapr, crt.dfecven, dfecven as dfecpro " & _
                            "from ahomcrt as crt " & _
                            "where crt.dfecven >= " & fec1 & " and crt.dfecven <= " & fec2 & " and crt.cliq <> 'S'  " & _
                            "order by crt.ccodcrt "

                Else
                    str_select = "set language spanish; select " & titulo & " as titulo, " & _
                            "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, crt.nmonapr * crt.ntasint / 100 * 30 / 365 as nintere,  " & _
                            "crt.dfecori, crt.dfecapr, crt.dfecven, dfecven as dfecpro " & _
                            "from ahomcrt as crt " & _
                            "where crt.dfecven >= " & fec1 & " and crt.dfecven <= " & fec2 & " and crt.cliq <> 'S'  " & _
                            " and crt.ccodofi = '" & lcCodofi & "'" & _
                            "order by crt.ccodcrt "
                End If
                
            End If

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses")

            ElseIf RadioButton34.Checked = True Then

                tit = miclase1.ToString("MOVIMIENTOS DIARIOS DE CTAS DE AHORRO " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)

                Session("pcNomOfi") = lcNomOfi

                If ckbTodas.Checked = True Then   'Todas las Oficinas
                    lcNomOfi = "Todas las Oficinas"


                    Session("pcNomOfi") = lcNomOfi

                'str_select = "set language spanish; select " & tit & " as titulo, cli.ccodcli, cli.cnomcli as cnomcli, mov.ccodaho, mov.cnumdoc, " & _
                '             "mov.dFecOpe, mov.nMonto, mov.cTipOpe, trs.cnomtrs, mov.ccodusu " & _
                '             "from climide as cli, ahomcta as cta, ahommov as mov, ahomtrs as trs " & _
                '             "where (cta.ccodaho = mov.ccodaho And cli.ccodcli = cta.cnudotr) " & _
                '             "and (mov.dfecope >= " & fec1 & " and mov.dfecope <= " & fec2 & ") and " & _
                '             "substring(mov.ccodaho, 7, 2) = trs.ccodtrs " & _
                '             "order by trs.cnomtrs, mov.dFecOpe"
                str_select = " set language spanish; select " & tit & " as titulo, cli.ccodcli, cli.cnomcli as cnomcli, mov.ccodaho, mov.cnumdoc, " & _
                             " mov.dFecOpe, " & _
                             " ndeposito = " & _
                             " Case cTipOpe " & _
                             " when 'D' then nMonto " & _
                             " else 0 " & _
                             " end, " & _
                             " nRetiro = " & _
                             " Case cTipOpe " & _
                             " when 'R' then nMonto " & _
                             " else 0 " & _
                             " end, mov.nMonto, mov.cTipOpe, trs.cnomtrs, mov.ccodusu " & _
                             " from climide cli " & _
                             " inner join ahomcta cta " & _
                             " on cli.ccodcli = cta.cnudotr " & _
                             " inner join ahommov mov  " & _
                             " on cta.ccodaho = mov.ccodaho " & _
                             " inner join ahomtrs trs " & _
                             " on substring(mov.ccodaho, 7, 2) = trs.ccodtrs " & _
                             " where (mov.dfecope >= " & fec1 & " and mov.dfecope <= " & fec2 & ") " & _
                             " and substring(mov.ccodaho, 7, 2) = trs.ccodtrs  " & _
                             " order by trs.cnomtrs, mov.dFecOpe "

            Else
                'str_select = "set language spanish; select " & tit & " as titulo, cli.ccodcli, cli.cnomcli as cnomcli, mov.ccodaho, mov.cnumdoc, " & _
                '             "mov.dFecOpe, mov.nMonto, mov.cTipOpe, trs.cnomtrs, mov.ccodusu " & _
                '             "from climide as cli, ahomcta as cta, ahommov as mov, ahomtrs as trs " & _
                '             "where (cta.ccodaho = mov.ccodaho And cli.ccodcli = cta.cnudotr) " & _
                '             "and (mov.dfecope >= " & fec1 & " and mov.dfecope <= " & fec2 & ") and " & _
                '             "substring(mov.ccodaho, 7, 2) = trs.ccodtrs " & _
                '             " and substring(mov.ccodaho,4,3) = '" & lcCodofi & "' " & _
                '             "order by trs.cnomtrs, mov.dFecOpe"
                str_select = " set language spanish; select " & tit & " as titulo, cli.ccodcli, cli.cnomcli as cnomcli, mov.ccodaho, mov.cnumdoc, " & _
                             " mov.dFecOpe, " & _
                             " ndeposito = " & _
                             " Case cTipOpe " & _
                             " when 'D' then nMonto " & _
                             " else 0 " & _
                             " end, " & _
                             " nRetiro = " & _
                             " Case cTipOpe " & _
                             " when 'R' then nMonto " & _
                             " else 0 " & _
                             " end, mov.nMonto, mov.cTipOpe, trs.cnomtrs, mov.ccodusu " & _
                             " from climide cli " & _
                             " inner join ahomcta cta " & _
                             " on cli.ccodcli = cta.cnudotr " & _
                             " inner join ahommov mov  " & _
                             " on cta.ccodaho = mov.ccodaho " & _
                             " inner join ahomtrs trs " & _
                             " on substring(mov.ccodaho, 7, 2) = trs.ccodtrs " & _
                             " where (mov.dfecope >= " & fec1 & " and mov.dfecope <= " & fec2 & ") " & _
                             " and substring(mov.ccodaho, 7, 2) = trs.ccodtrs  " & _
                             " and substring(mov.ccodaho,4,3) = '" & lcCodofi & "' " & _
                             " order by trs.cnomtrs, mov.dFecOpe "
            End If


                Session("str_select") = str_select

                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_movimientos_diarios_ahorros")
            ElseIf RadioButton35.Checked = True Then
                tit = miclase1.ToString("SUMARIO DE CARTERA DE AHORRO AL " & hasta_TextBox.Text)
                str_select = "set language spanish; select " & tit & " as titulo, casos, cdescri, saldo, " & _
                "tipo_plazo = case plazo when 'C' then 'CORTO PLAZO' else 'LARGO PLAZO' end " & _
                                 "from sumario where grupo = 'B' and dfecoper = " & fec2 & " order by tipo_plazo "
                Session("str_select") = str_select

                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_sumario_ahorros")

            ElseIf RadioButton36.Checked = True Then
                tit = miclase1.ToString("SUMARIO DE CARTERA DE CREDITOS AL " & hasta_TextBox.Text)

                str_select = "set language spanish;  select " & tit & " as titulo, casos, plazo, cdescri, saldo, " & _
                             "tipo_plazo = case plazo when 'C' then 'CORTO PLAZO' else 'LARGO PLAZO' end " & _
                             "from sumario where grupo = 'A' and dfecoper = " & fec2 & " order by tipo_plazo "

                Session("str_select") = str_select
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_sumario_ahorros")

            ElseIf RadioButton37.Checked = True Then
                ' crea el archivo texto
                Dim miclase As New clase_jaime
                Dim sw As StreamWriter
                sw = New StreamWriter("c:\\txt\\ingreso_asociados.prn", False)

                Dim ds As New DataSet
                Dim dt As New DataTable
                Dim fila As DataRow
                Dim con As New SqlConnection
                Dim stringconnection As String = miclase.conexion()
                con.ConnectionString = stringconnection

                str_select = "set language spanish; select ccodcli as ASOCIADO, cnomcli as NOMBRE, dregist as INGRESO, cdirdom as DOMICILIO, " & _
                     "cteldom as TELEFONO1,  ccodcon as TELEFONO2, cbenef2 as EMAIL, cdirfue as TRABAJO, cteltralab as TEL_TRABAJO " & _
                     "from climide where dregist >= " & _
                     fec1 & " and dregist <= " & fec2 & " order by dregist"
                con.Open()
                ds = miclase.devolver_dataset(con, str_select)
                dt = ds.Tables("tabla")
                con.Close()

                For Each fila In dt.Rows
                    sw.Write(fila("asociado") & ";")
                    sw.Write(fila("nombre").ToString.Trim & ";")
                    sw.Write(fila("ingreso") & ";")
                    sw.Write(fila("domicilio").ToString.Trim & ";")
                    sw.Write(fila("telefono1") & ";")
                    sw.Write(fila("telefono2") & ";")
                    sw.WriteLine(fila("email"))
                Next

                sw.Close()
                sw.Dispose()

                '**** Descargar el archivo a la PC cliente - Alex 10/12/2011 *******

                Dim archivo As String = "ingreso_asociados"
                Dim Path As String = "c:/txt/" & archivo


                Me.DownloadFile(Path + ".prn", archivo + ".prn")


                '**** Fin modificacion - Alex 10/12/2011 *******

            ElseIf RadioButton38.Checked = True Then

            Dim miclase As New clase_jaime
            Dim omclassAho As New cAhomcta
            Dim ds As New DataSet
            Dim lcOFicina As String = ""
            Dim lcTipAho As String = ""
            Dim mi_rptEmp As Object = "rpt_cartera_ahorros.rpt"

            ViewState.Add("Oficinas", "")

            tit = miclase1.ToString("CARTERAS DE AHORRO AL " & hasta_TextBox.Text)
            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            If Me.ckbTodas.Checked Then
                lcOFicina = "*"
                ViewState("Oficinas") = "Todas las Oficinas"
            Else
                lcOFicina = Me.ddlOficinas.SelectedValue.Trim
                ViewState("Oficinas") = "Oficina: " & Me.ddlOficinas.SelectedItem.Text.Trim
            End If

            If Me.llahorros.Checked = True Then
                lcTipAho = "*"
            Else
                lcTipAho = Me.CbxTipAho1.SelectedValue.Trim
            End If


            ds = omclassAho.Genera_Saldo_Ahorro_Dinamico(lcTipAho, Date.Parse(Me.hasta_TextBox.Text), tit, lcOFicina)


            Imprimir(ds, mi_rptEmp, Me.ddlexportar.SelectedValue.Trim)

            'Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
            'Dim backup_ahomcta As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.ahomcta"
            'Dim backup_climide As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.climide"
            'Dim backup_ahomtrs As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.ahomtrs"
            'Dim resultado As Integer = 0

            'Dim con As New SqlConnection
            'Dim stringconnection As String = miclase.conexion()
            'con.ConnectionString = stringconnection
            'con.Open()



            ''Para saber si la base de backup existe, sino se va a la base en vivo
            'str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
            '             backup.ToString & "')"
            'resultado = miclase.devolver_scalar1(con, str_select)

            ''Dim ofice As String = ddlOficinas.SelectedValue.Trim

            'Session("pcNomOfi") = lcNomOfi


            'If resultado > 0 Then
            '    If ckbTodas.Checked = True Then   'Todas las Oficinas
            '        lcNomOfi = "Todas las Oficinas"

            '        Session("pcNomOfi") = lcNomOfi

            '        str_select = "set language spanish; select " & tit & " as titulo,  cta.ccodaho, " & _
            '                     "cta.producto, trs.cnomtrs, cta.cnudotr as ccodcli, cli.cdirdom, cli.cnomcli, " & _
            '                     "cta.dfecini, cta.dfecmod, cta.cmotivo, cta.nsaldoaho " & _
            '                     "from " & backup_ahomcta & " as cta, " & backup_climide & " as cli, " & base_produccion & ".dbo.ahomtrs as trs " & _
            '                     "where  substring(cta.ccodaho,7,2) = trs.ccodtrs and cta.cnudotr = cli.ccodcli and cta.nsaldoaho > 0 " & _
            '                     "order by trs.cnomtrs, cta.cnudotr, cta.ccodaho"
            '    Else
            '        str_select = "set language spanish; select " & tit & " as titulo,  cta.ccodaho, " & _
            '                     "cta.producto, trs.cnomtrs, cta.cnudotr as ccodcli, cli.cdirdom, cli.cnomcli, " & _
            '                     "cta.dfecini, cta.dfecmod, cta.cmotivo, cta.nsaldoaho " & _
            '                     "from " & backup_ahomcta & " as cta, " & backup_climide & " as cli, " & base_produccion & ".dbo.ahomtrs as trs " & _
            '                     "where  substring(cta.ccodaho,7,2) = trs.ccodtrs and cta.cnudotr = cli.ccodcli " & _
            '                     " and substring(cta.ccodaho,4,3) = '" & lcCodofi & "' " & _
            '                     " and cta.nsaldoaho > 0 " & _
            '                     "order by trs.cnomtrs, cta.cnudotr, cta.ccodaho"
            '        '" cli.ccodofi = " & miclase1.ToString(ofice) & _
            '    End If

            'Else
            '    If ckbTodas.Checked = True Then   'Todas las Oficinas
            '        lcNomOfi = "Todas las Oficinas"

            '        Session("pcNomOfi") = lcNomOfi

            '        str_select = "set language spanish; select " & tit & " as titulo,  cta.ccodaho, " & _
            '                     "cta.producto,  trs.cnomtrs, cta.cnudotr as ccodcli, cli.cdirdom, cli.cnomcli, " & _
            '                     "cta.dfecini, cta.dfecmod, cta.cmotivo, cta.nsaldoaho " & _
            '                     "from ahomcta as cta, climide as cli, ahomtrs as trs " & _
            '                     "where  substring(cta.ccodaho,7,2) = trs.ccodtrs and cta.cnudotr = cli.ccodcli  and cta.nsaldoaho > 0 " & _
            '                     "order by trs.cnomtrs, cta.cnudotr, cta.ccodaho "
            '    Else
            '        str_select = "set language spanish; select " & tit & " as titulo,  cta.ccodaho, " & _
            '                     "cta.producto,  trs.cnomtrs, cta.cnudotr as ccodcli, cli.cdirdom, cli.cnomcli, " & _
            '                     "cta.dfecini, cta.dfecmod, cta.cmotivo, cta.nsaldoaho " & _
            '                     "from ahomcta as cta, climide as cli, ahomtrs as trs " & _
            '                     "where  substring(cta.ccodaho,7,2) = trs.ccodtrs and cta.cnudotr = cli.ccodcli " & _
            '                     "and substring(cta.ccodaho,4,3) = '" & lcCodofi & "' " & _
            '                     "and cta.nsaldoaho > 0 " & _
            '                     "order by trs.cnomtrs, cta.cnudotr, cta.ccodaho "
            '        '"cli.ccodofi = " & miclase1.ToString(ofice) & 
            '    End If

            'End If

            'If CheckBox1.Checked = True Then
            '    Dim ds As DataSet
            '    Dim fila As DataRow
            '    ds = miclase.devolver_dataset(con, str_select)

            '    Dim sw As StreamWriter = Nothing
            '    sw = New StreamWriter("C:\txt\cartera_ahorros.txt", False)

            '    sw.Write("Cuenta;")
            '    sw.Write("Producto;")
            '    sw.Write("Tipo;")
            '    sw.Write("Asociado;")
            '    sw.Write("Nombre;")
            '    sw.Write("Domicilio;")
            '    sw.Write("Inicio;")
            '    sw.Write("Modificado;")
            '    sw.WriteLine("Saldo")

            '    For Each fila In ds.Tables(0).Rows
            '        sw.Write(fila("ccodaho") & ";")
            '        sw.Write(fila("producto") & ";")
            '        sw.Write(fila("cnomtrs") & ";")
            '        sw.Write(fila("ccodcli") & ";")
            '        sw.Write(fila("cnomcli") & ";")
            '        sw.Write(fila("dfecini") & ";")
            '        sw.Write(fila("dfecmod") & ";")
            '        sw.WriteLine(fila("nsaldoaho"))
            '    Next


            '    sw.Close()
            '    sw.Dispose()


            '    '**** Descargar el archivo a la PC cliente - Alex 10/12/2011 *******

            '    Dim archivo As String = "cartera_ahorros"
            '    Dim Path As String = "c:/txt/" & archivo


            '    Me.DownloadFile(Path + ".txt", archivo + ".txt")


            ''**** Fin modificacioZn - Alex 10/12/2011 *******

            '    Exit Sub
            'End If

            'con.Close()
            'Session("str_select") = str_select

            'Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "rpt_cartera_ahorros")

        ElseIf RadioButton39.Checked = True Then

            Dim miclase As New clase_jaime

            tit = miclase1.ToString("CARTERAS DE CREDITOS AL " & hasta_TextBox.Text)

            Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
            Dim backup_cremcre As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.cremcre"
            Dim backup_climide As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.climide"
            Dim backup_cretlin As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.cretlin"
            Dim resultado As Integer = 0

            Dim con As New SqlConnection
            Dim stringconnection As String = miclase.conexion()
            con.ConnectionString = stringconnection
            con.Open()

            'Para saber si la base de backup existe, sino se va a la base en vivo
            str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                         backup.ToString & "')"
            resultado = miclase.devolver_scalar1(con, str_select)

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If resultado > 0 Then

                If todas = "SI" Then

                    str_select = "SELECT  'Sucursal' = " & _
                        "case cre.coficina " & _
                        "when '001' then 'Santa Ana' " & _
                        "when '002' then 'Metapan' " & _
                        "when '003' then 'San Salvador' " & _
                        "else 'No Definido' " & _
                        "end, " & _
                        "'Tipo_Plazo' = case when  ncuoapr < 12 then 'Corto Plazo' else 'Largo Plazo' end, " & _
                        "cre.ccodcli as Asociado, cre.ccodcta as Cuenta, cre.cnrolin as No_Linea, lin.cdeslin as Linea, " & _
                        "'Producto' = case  LEFT(cre.cproducto,1) " & _
                        "when 'B' then 'Comercio' " & _
                        "when 'C' then 'Consumo' " & _
                        "when 'E' then 'Vivienda' " & _
                        "when 'F' then 'Fonavipo' " & _
                        "when 'J' then 'Depurada' " & _
                        "when 'K' then 'Embargo' " & _
                        "when 'L' then 'Embargo Depurado' " & _
                        "else 'No Definida' end, " & _
                        "tab.cdescri as Garantia, cli.cnomcli as Nombre, cli.cdirdom as Direccion,  cre.ccalif as Calificacion, " & _
                        "'Dias_Mora' = case " & _
                        "when cre.ndiaant <= 0 then 0 " & _
                        "else cre.ndiaatr " & _
                        "end, " & _
                        "cre.ccodana as Analista, cre.centre as Asignado, " & _
                        "cre.ndiaapr as Dia_Cuota, " & _
                        "'Tipo_Credito' = " & _
                        "case cre.ctipcre " & _
                        "when 'N' then 'Nuevo' " & _
                        "when 'R' then 'Recurrente' " & _
                        "end, " & _
                        "datediff(day, cre.dfecvig, getdate()) as 'Dias_Colocacion', " & _
                        "'Tipo_Pago' = " & _
                        "case cre.npagadu " & _
                        "when 1 then 'Pagaduria' " & _
                        "else  'Caja' " & _
                        "end, " & _
                        "cre.dfecvig as Vigencia, cre.dfecven as Vencimiento, " & _
                        "'Fecha_Ampliacion' = " & _
                        "case cre.nmonres " & _
                        "when 0 then '' " & _
                        "else cre.dultres " & _
                        "end, " & _
                        "cre.nmonres as Monto_Ampliado, " & _
                        "cre.nmoncuo as Cuota, cre.ncuoapr as 'Meses_Plazo', cre.ntasint as Tasa, cre.ncapdes as Desembolso, " & _
                        "cre.ncappag as Capital_Pagado, (cre.ncapdes - cre.ncappag) as saldo_Capital, " & _
                        "cre.nintcal - (cre.nintpag + cre.nintpen) as Int_Normal, cre.nintmor - (cre.nmorpag + cre.npagcta) as Int_Moratorio, " & _
                        "dultpag as Cubre_Int_Normal, dultpag as Cubre_Capital " & _
                        "from " & backup_cremcre & " as cre, " & backup_cretlin & " as lin, MFAMIGA.dbo.tabttab as tab, " & backup_climide & " as cli " & _
                        "WHERE cre.cestado = 'F' AND cre.ccodcli = cli.ccodcli AND cre.cnrolin = lin.cnrolin AND (cre.ctipgar = tab.ccodigo AND tab.ccodtab = '037') " & _
                        "order by cre.ccodana, producto, dias_mora, cre.ccodcli, cre.ccodcta "
                Else
                    str_select = "SELECT  'Sucursal' = " & _
    "case cre.coficina " & _
    "when '001' then 'Santa Ana' " & _
    "when '002' then 'Metapan' " & _
    "when '003' then 'San Salvador' " & _
    "else 'No Definido' " & _
    "end, " & _
    "'Tipo_Plazo' = case when  ncuoapr < 12 then 'Corto Plazo' else 'Largo Plazo' end, " & _
    "cre.ccodcli as Asociado, cre.ccodcta as Cuenta, cre.cnrolin as No_Linea, lin.cdeslin as Linea, " & _
    "'Producto' = case  LEFT(cre.cproducto,1) " & _
    "when 'B' then 'Comercio' " & _
    "when 'C' then 'Consumo' " & _
    "when 'E' then 'Vivienda' " & _
    "when 'F' then 'Fonavipo' " & _
    "when 'J' then 'Depurada' " & _
    "when 'K' then 'Embargo' " & _
    "when 'L' then 'Embargo Depurado' " & _
    "else 'No Definida' end, " & _
    "tab.cdescri as Garantia, cli.cnomcli as Nombre, cli.cdirdom as Direccion,  cre.ccalif as Calificacion, " & _
    "'Dias_Mora' = case " & _
    "when cre.ndiaant <= 0 then 0 " & _
    "else cre.ndiaatr " & _
    "end, " & _
    "cre.ccodana as Analista, cre.centre as Asignado, " & _
    "cre.ndiaapr as Dia_Cuota, " & _
    "'Tipo_Credito' = " & _
    "case cre.ctipcre " & _
    "when 'N' then 'Nuevo' " & _
    "when 'R' then 'Recurrente' " & _
    "end, " & _
    "datediff(day, cre.dfecvig, getdate()) as 'Dias_Colocacion', " & _
    "'Tipo_Pago' = " & _
    "case cre.npagadu " & _
    "when 1 then 'Pagaduria' " & _
    "else  'Caja' " & _
    "end, " & _
    "cre.dfecvig as Vigencia, cre.dfecven as Vencimiento, " & _
    "'Fecha_Ampliacion' = " & _
    "case cre.nmonres " & _
    "when 0 then '' " & _
    "else cre.dultres " & _
    "end, " & _
    "cre.nmonres as Monto_Ampliado, " & _
    "cre.nmoncuo as Cuota, cre.ncuoapr as 'Meses_Plazo', cre.ntasint as Tasa, cre.ncapdes as Desembolso, " & _
    "cre.ncappag as Capital_Pagado, (cre.ncapdes - cre.ncappag) as saldo_Capital, " & _
    "cre.nintcal - (cre.nintpag + cre.nintpen) as Int_Normal, cre.nintmor - (cre.nmorpag + cre.npagcta) as Int_Moratorio, " & _
    "dultpag as Cubre_Int_Normal, dultpag as Cubre_Capital " & _
    "from " & backup_cremcre & " as cre, " & backup_cretlin & " as lin, MFAMIGA.dbo.tabttab as tab, " & backup_climide & " as cli " & _
    "WHERE cre.cestado = 'F' AND cre.ccodcli = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & " and cre.cnrolin = lin.cnrolin AND (cre.ctipgar = tab.ccodigo AND tab.ccodtab = '037') " & _
    "order by cre.ccodana, producto, dias_mora, cre.ccodcli, cre.ccodcta "

                End If
            Else

                If todas = "SI" Then
                    str_select = "SELECT  'Sucursal' = " & _
                                  "case cre.coficina " & _
                            "when '001' then 'Santa Ana' " & _
                            "when '002' then 'Metapan' " & _
                            "when '003' then 'San Salvador' " & _
                            "else 'No Definido' " & _
                                  "end, " & _
                             "'Tipo_Plazo' = case when  ncuoapr < 12 then 'Corto Plazo' else 'Largo Plazo' end, " & _
                                "cre.ccodcli as Asociado, cre.ccodcta as Cuenta, cre.cnrolin as No_Linea, lin.cdeslin as Linea, " & _
                                     "'Producto' = case  LEFT(cre.cproducto,1) " & _
                                   "when 'B' then 'Comercio' " & _
                                   "when 'C' then 'Consumo' " & _
                                   "when 'E' then 'Vivienda' " & _
                                   "when 'F' then 'Fonavipo' " & _
                                   "when 'J' then 'Depurada' " & _
                                   "when 'K' then 'Embargo' " & _
                                   "when 'L' then 'Embargo Depurado' " & _
                                   "else 'No Definida' end, " & _
                                "tab.cdescri as Garantia, cli.cnomcli as Nombre, cli.cdirdom as Direccion,  cre.ccalif as Calificacion, " & _
                                     "'Dias_Mora' = case " & _
                               "when cre.ndiaant <= 0 then 0 " & _
                               "else cre.ndiaatr " & _
                               "end, " & _
                               "cre.ccodana as Analista, cre.centre as Asignado, " & _
                               "cre.ndiaapr as Dia_Cuota, " & _
                                     "'Tipo_Credito' = " & _
                               "case cre.ctipcre " & _
                            "when 'N' then 'Nuevo' " & _
                            "when 'R' then 'Recurrente' " & _
                               "end, " & _
                               "datediff(day, cre.dfecvig, getdate()) as 'Dias_Colocacion', " & _
                                     "'Tipo_Pago' = " & _
                               "case cre.npagadu " & _
                            "when 1 then 'Pagaduria' " & _
                            "else  'Caja' " & _
                               "end, " & _
                               "cre.dfecvig as Vigencia, cre.dfecven as Vencimiento, " & _
                                     "'Fecha_Ampliacion' = " & _
                               "case cre.nmonres " & _
                            "when 0 then '' " & _
                            "else cre.dultres " & _
                               "end, " & _
                               "cre.nmonres as Monto_Ampliado, " & _
                               "cre.nmoncuo as Cuota, cre.ncuoapr as 'Meses_Plazo', cre.ntasint as Tasa, cre.ncapdes as Desembolso, " & _
                               "cre.ncappag as Capital_Pagado, (cre.ncapdes - cre.ncappag) as saldo_Capital, " & _
                               "cre.nintcal - (cre.nintpag + cre.nintpen) as Int_Normal, cre.nintmor - (cre.nmorpag + cre.npagcta) as Int_Moratorio, " & _
                               "dultpag as Cubre_Int_Normal, dultpag as Cubre_Capital " & _
                                     "from cremcre as cre, cretlin as lin, tabttab as tab, climide as cli " & _
                                     "WHERE cre.cestado = 'F' AND cre.ccodcli = cli.ccodcli AND cre.cnrolin = lin.cnrolin AND (cre.ctipgar = tab.ccodigo AND tab.ccodtab = '037') " & _
                                     "order by cre.ccodana, producto, dias_mora, cre.ccodcli, cre.ccodcta "
                Else
                    str_select = "SELECT  'Sucursal' = " & _
              "case cre.coficina " & _
        "when '001' then 'Santa Ana' " & _
        "when '002' then 'Metapan' " & _
        "when '003' then 'San Salvador' " & _
        "else 'No Definido' " & _
              "end, " & _
         "'Tipo_Plazo' = case when  ncuoapr < 12 then 'Corto Plazo' else 'Largo Plazo' end, " & _
            "cre.ccodcli as Asociado, cre.ccodcta as Cuenta, cre.cnrolin as No_Linea, lin.cdeslin as Linea, " & _
                 "'Producto' = case  LEFT(cre.cproducto,1) " & _
               "when 'B' then 'Comercio' " & _
               "when 'C' then 'Consumo' " & _
               "when 'E' then 'Vivienda' " & _
               "when 'F' then 'Fonavipo' " & _
               "when 'J' then 'Depurada' " & _
               "when 'K' then 'Embargo' " & _
               "when 'L' then 'Embargo Depurado' " & _
               "else 'No Definida' end, " & _
            "tab.cdescri as Garantia, cli.cnomcli as Nombre, cli.cdirdom as Direccion,  cre.ccalif as Calificacion, " & _
                 "'Dias_Mora' = case " & _
           "when cre.ndiaant <= 0 then 0 " & _
           "else cre.ndiaatr " & _
           "end, " & _
           "cre.ccodana as Analista, cre.centre as Asignado, " & _
           "cre.ndiaapr as Dia_Cuota, " & _
                 "'Tipo_Credito' = " & _
           "case cre.ctipcre " & _
        "when 'N' then 'Nuevo' " & _
        "when 'R' then 'Recurrente' " & _
           "end, " & _
           "datediff(day, cre.dfecvig, getdate()) as 'Dias_Colocacion', " & _
                 "'Tipo_Pago' = " & _
           "case cre.npagadu " & _
        "when 1 then 'Pagaduria' " & _
        "else  'Caja' " & _
           "end, " & _
           "cre.dfecvig as Vigencia, cre.dfecven as Vencimiento, " & _
                 "'Fecha_Ampliacion' = " & _
           "case cre.nmonres " & _
        "when 0 then '' " & _
        "else cre.dultres " & _
           "end, " & _
           "cre.nmonres as Monto_Ampliado, " & _
           "cre.nmoncuo as Cuota, cre.ncuoapr as 'Meses_Plazo', cre.ntasint as Tasa, cre.ncapdes as Desembolso, " & _
           "cre.ncappag as Capital_Pagado, (cre.ncapdes - cre.ncappag) as saldo_Capital, " & _
           "cre.nintcal - (cre.nintpag + cre.nintpen) as Int_Normal, cre.nintmor - (cre.nmorpag + cre.npagcta) as Int_Moratorio, " & _
           "dultpag as Cubre_Int_Normal, dultpag as Cubre_Capital " & _
"from cremcre as cre, cretlin as lin, tabttab as tab, climide as cli " & _
"WHERE cre.cestado = 'F' AND cre.ccodcli = cli.ccodcli and cli.ccodofi = " & miclase1.ToString(ofice) & "AND cre.cnrolin = lin.cnrolin AND (cre.ctipgar = tab.ccodigo AND tab.ccodtab = '037') " & _
"order by cre.ccodana, producto, dias_mora, cre.ccodcli, cre.ccodcta "

                End If
                ' Falta saber a que reporte pertenece, buscame
                Session("str_select") = str_select

            End If


            If CheckBox3.Checked = True Then
                Dim ds As DataSet
                Dim fila As DataRow
                Dim conta1 As Integer = 0, conta2 As Integer = 0

                ds = miclase.devolver_dataset(con, str_select)

                For Each fila In ds.Tables(0).Rows
                    str_select = "select COUNT(*) from credkar where ccodcta = " & miclase1.ToString(fila("cuenta")) & " and cestado <> 'X' and " & _
                                 "cconcep = 'CJ' and cdescob = 'C' AND ccodusu = 'BASA' "
                    conta1 = miclase.devolver_scalar1(con, str_select)
                    str_select = "select COUNT(*) from credkar where ccodcta = " & miclase1.ToString(fila("cuenta")) & " and cestado <> 'X' and " & _
                                 "cconcep = 'CJ' and cdescob = 'C' AND ccodusu <> 'BASA' "
                    conta2 = miclase.devolver_scalar1(con, str_select)
                    If conta1 > 0 And conta2 > 0 Then
                        fila("tipo_pago") = "Mixto"
                    End If

                Next

                con.Close()



                Dim sw As StreamWriter = Nothing
                sw = New StreamWriter("C:\txt\cartera_creditos.txt", False)

                sw.Write("sucursal;")
                sw.Write("tipo_plazo;")
                sw.Write("asociado;")
                sw.Write("cuenta;")
                sw.Write("no_linea;")
                sw.Write("linea;")
                sw.Write("producto;")
                sw.Write("garantia;")
                sw.Write("nombre;")
                sw.Write("direccion;")
                sw.Write("calificacion;")
                sw.Write("dias_mora;")
                sw.Write("analista;")
                sw.Write("asignado;")
                sw.Write("dia_cuota;")
                sw.Write("tipo_credito;")
                sw.Write("dias_colocacion;")
                sw.Write("tipo_pago;")
                sw.Write("vigencia;")
                sw.Write("vencimiento;")
                sw.Write("fecha_ampliacion;")
                sw.Write("monto_ampliado;")
                sw.Write("cuota;")
                sw.Write("meses_plazo;")
                sw.Write("tasa;")
                sw.Write("desembolso;")
                sw.Write("capital_pagado;")
                sw.Write("saldo_capital;")
                sw.Write("int_normal;")
                sw.Write("int_moratorio;")
                sw.Write("cubre_int_normal;")
                sw.WriteLine("cubre_capital;")

                For Each fila In ds.Tables(0).Rows
                    sw.Write(fila("sucursal") & ";")
                    sw.Write(fila("tipo_plazo") & ";")
                    sw.Write(fila("asociado") & ";")
                    sw.Write(fila("cuenta") & ";")
                    sw.Write(fila("no_linea") & ";")
                    sw.Write(fila("linea") & ";")
                    sw.Write(fila("producto") & ";")
                    sw.Write(fila("garantia") & ";")
                    sw.Write(fila("nombre") & ";")
                    sw.Write(fila("direccion") & ";")
                    sw.Write(fila("calificacion") & ";")
                    sw.Write(fila("dias_mora") & ";")
                    sw.Write(fila("analista") & ";")
                    sw.Write(fila("asignado") & ";")
                    sw.Write(fila("dia_cuota") & ";")
                    sw.Write(fila("tipo_credito") & ";")
                    sw.Write(fila("dias_colocacion") & ";")
                    sw.Write(fila("tipo_pago") & ";")
                    sw.Write(fila("vigencia") & ";")
                    sw.Write(fila("vencimiento") & ";")
                    sw.Write(fila("fecha_ampliacion") & ";")
                    sw.Write(fila("monto_ampliado") & ";")
                    sw.Write(fila("cuota") & ";")
                    sw.Write(fila("meses_plazo") & ";")
                    sw.Write(fila("tasa") & ";")
                    sw.Write(fila("desembolso") & ";")
                    sw.Write(fila("capital_pagado") & ";")
                    sw.Write(fila("saldo_capital") & ";")
                    sw.Write(fila("int_normal") & ";")
                    sw.Write(fila("int_moratorio") & ";")
                    sw.Write(fila("cubre_int_normal") & ";")
                    sw.WriteLine(fila("cubre_capital"))

                Next

                sw.Close()
                sw.Dispose()


                '**** Descargar el archivo a la PC cliente - Alex 10/12/2011 *******

                Dim archivo As String = "cartera_creditos"
                Dim Path As String = "c:/txt/" & archivo


                Me.DownloadFile(Path + ".txt", archivo + ".txt")


                '**** Fin modificacion - Alex 10/12/2011 *******

            End If

        ElseIf RadioButton40.Checked = True Then
            Dim titulo As String = miclase1.ToString("PROVISION DIARIA DE INTERESES POR TASA " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)
            str_select = "set language spanish; select " & titulo & " as titulo, " & _
                              "crt.ntasint as tasa, count(*) as cuantos, sum(crt.nmonapr) as saldo, sum(int.nintere) as interes " & _
                              "from ahomint as int, ahomcrt as crt " & _
                              "where int.dfecpro between " & fec1 & " and " & fec2 & " and int.nintere >  0 " & _
                              "and int.ccodcrt = crt.ccodcrt group by crt.ntasint " & _
                              "order by crt.ntasint "
            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses_tasa")
        ElseIf RadioButton41.Checked = True Then
            Dim titulo As String = miclase1.ToString("HISTORIAL DE INTERESES PAGADOS DEL " & desde_TextBox.Text & " AL " & hasta_TextBox.Text)
            str_select = "set language spanish; select " & titulo & " as titulo, " & _
                              "crt.ccodcrt, crt.nombre, crt.ccodaho, crt.ntasint, crt.nplazo, crt.nmonapr, ven.nintere, " & _
                              "crt.dfecori, crt.dfecapr, crt.dfecven, ven.dfecpro, 00000.0000 as saldo " & _
                             "from vencidos as ven, ahomcrt as crt " & _
                             "where ven.dfecpro between " & fec1 & " and " & fec2 & " and ven.nintere >  0  " & _
                             "and ven.ccodcrt = crt.ccodcrt " & _
                             "order by crt.nombre, crt.ccodcrt, ven.dfecpro "

            Session("str_select") = str_select
            Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "pago_intereses_historial")
        ElseIf RadioButton42.Checked = True Then
            Dim titulo As String = miclase1.ToString("AMIGA - CARTERA DE CREDITOS AL " & hasta_TextBox.Text)
            str_select = "set language spanish;  select " & titulo & " as titulo, " & " casos, cdescri, saldo " & _
                 "from sumario where grupo = 'A' and dfecoper = " & fec2
            Session("str_select") = str_select
            If grafico_DropDownList.SelectedValue = "Pastel" Then
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica")
            Else
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica1")
            End If

        ElseIf RadioButton43.Checked = True Then
            Dim titulo As String = miclase1.ToString("AMIGA - CARTERA DE AHORROS AL " & hasta_TextBox.Text)
            str_select = "set language spanish;  select " & titulo & " as titulo, " & " casos, substring (cdescri,8,15) as cdescri, saldo " & _
                 "from sumario where grupo = 'B' and dfecoper = " & fec2 & " order by cdescri desc"
            Session("str_select") = str_select
            If grafico_DropDownList.SelectedValue = "Pastel" Then
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica")
            Else
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica1")
            End If

        ElseIf RadioButton44.Checked = True Then

            Dim miclase As New clase_jaime

            Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
            Dim backup_cremcre As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.cremcre "
            Dim resultado As Integer = 0

            Dim con As New SqlConnection
            Dim stringconnection As String = miclase.conexion()
            con.ConnectionString = stringconnection
            con.Open()

            'Para saber si la base de backup existe, sino se va a la base en vivo
            str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                         backup.ToString & "')"
            resultado = miclase.devolver_scalar1(con, str_select)

            con.Close()
            If resultado > 0 Then

            Else
                backup_cremcre = "cremcre"
            End If

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            Dim titulo As String = miclase1.ToString("AMIGA - CARTERA DE CREDITOS EN MORA POR EDAD AL " & hasta_TextBox.Text)
            If todas = "SI" Then
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, " & _
                             "cdescri = case " & _
                             "when ndiaatr <= 0 then 'A) 0 dias' " & _
                             "when ndiaatr >= 1 and ndiaatr <= 7 then 'B) 01-07 dias' " & _
                             "when ndiaatr >=8 and ndiaatr <= 30 then 'C) 08-30 dias' " & _
                             "when ndiaatr >=31 and ndiaatr <=60 then 'D) 31-60 dias' " & _
                             "when ndiaatr >=61 and ndiaatr <=90 then 'E) 61-90 dias' " & _
                             "when ndiaatr >=91 and ndiaatr <=120 then 'F) 91-120 dias' " & _
                             "when ndiaatr >=121 and ndiaatr <=360 then 'G) 121-360 dias' " & _
                             "when ndiaatr >360  then 'H) >361 dias' end, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from " & backup_cremcre & " where cestado = 'F'  and LEFT(cproducto,1) not in ('J','L') " & _
                             "group by case  " & _
                             "when ndiaatr <= 0 then 'A) 0 dias' " & _
                             "when ndiaatr >= 1 and ndiaatr <= 7 then 'B) 01-07 dias' " & _
                             "when ndiaatr >=8 and ndiaatr <= 30 then 'C) 08-30 dias' " & _
                             "when ndiaatr >=31 and ndiaatr <=60 then 'D) 31-60 dias' " & _
                             "when ndiaatr >=61 and ndiaatr <=90 then 'E) 61-90 dias' " & _
                             "when ndiaatr >=91 and ndiaatr <=120 then 'F) 91-120 dias' " & _
                             "when ndiaatr >=121 and ndiaatr <=360 then 'G) 121-360 dias' " & _
                             "when ndiaatr >360  then 'H) >361 dias' end " & _
                             "order by case  " & _
                             "when ndiaatr <= 0 then 'A) 0 dias' " & _
                             "when ndiaatr >= 1 and ndiaatr <= 7 then 'B) 01-07 dias' " & _
                             "when ndiaatr >=8 and ndiaatr <= 30 then 'C) 08-30 dias' " & _
                             "when ndiaatr >=31 and ndiaatr <=60 then 'D) 31-60 dias' " & _
                             "when ndiaatr >=61 and ndiaatr <=90 then 'E) 61-90 dias' " & _
                             "when ndiaatr >=91 and ndiaatr <=120 then 'F) 91-120 dias' " & _
                             "when ndiaatr >=121 and ndiaatr <=360 then 'G) 121-360 dias' " & _
                             "when ndiaatr >360  then 'H) >361 dias' end "
            Else
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, " & _
                             "cdescri = case " & _
                             "when ndiaatr <= 0 then 'A) 0 dias' " & _
                             "when ndiaatr >= 1 and ndiaatr <= 7 then 'B) 01-07 dias' " & _
                             "when ndiaatr >=8 and ndiaatr <= 30 then 'C) 08-30 dias' " & _
                             "when ndiaatr >=31 and ndiaatr <=60 then 'D) 31-60 dias' " & _
                             "when ndiaatr >=61 and ndiaatr <=90 then 'E) 61-90 dias' " & _
                             "when ndiaatr >=91 and ndiaatr <=120 then 'F) 91-120 dias' " & _
                             "when ndiaatr >=121 and ndiaatr <=360 then 'G) 121-360 dias' " & _
                             "when ndiaatr >360  then 'H) >361 dias' end, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from " & backup_cremcre & " where cestado = 'F'  and ccodofi = " & miclase1.ToString(ofice) & " and LEFT(cproducto,1) not in ('J','L') " & _
                             "group by case  " & _
                             "when ndiaatr <= 0 then 'A) 0 dias' " & _
                             "when ndiaatr >= 1 and ndiaatr <= 7 then 'B) 01-07 dias' " & _
                             "when ndiaatr >=8 and ndiaatr <= 30 then 'C) 08-30 dias' " & _
                             "when ndiaatr >=31 and ndiaatr <=60 then 'D) 31-60 dias' " & _
                             "when ndiaatr >=61 and ndiaatr <=90 then 'E) 61-90 dias' " & _
                             "when ndiaatr >=91 and ndiaatr <=120 then 'F) 91-120 dias' " & _
                             "when ndiaatr >=121 and ndiaatr <=360 then 'G) 121-360 dias' " & _
                             "when ndiaatr >360  then 'H) >361 dias' end " & _
                             "order by case  " & _
                             "when ndiaatr <= 0 then 'A) 0 dias' " & _
                             "when ndiaatr >= 1 and ndiaatr <= 7 then 'B) 01-07 dias' " & _
                             "when ndiaatr >=8 and ndiaatr <= 30 then 'C) 08-30 dias' " & _
                             "when ndiaatr >=31 and ndiaatr <=60 then 'D) 31-60 dias' " & _
                             "when ndiaatr >=61 and ndiaatr <=90 then 'E) 61-90 dias' " & _
                             "when ndiaatr >=91 and ndiaatr <=120 then 'F) 91-120 dias' " & _
                             "when ndiaatr >=121 and ndiaatr <=360 then 'G) 121-360 dias' " & _
                             "when ndiaatr >360  then 'H) >361 dias' end "

            End If

            Session("str_select") = str_select
            If grafico_DropDownList.SelectedValue = "Pastel" Then
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica")
            Else
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica1")
            End If

        ElseIf RadioButton45.Checked = True Then
            Dim miclase As New clase_jaime

            Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
            Dim backup_cremcre As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.cremcre as cre"
            Dim resultado As Integer = 0

            Dim con As New SqlConnection
            Dim stringconnection As String = miclase.conexion()
            con.ConnectionString = stringconnection
            con.Open()

            'Para saber si la base de backup existe, sino se va a la base en vivo
            str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                         backup.ToString & "')"
            resultado = miclase.devolver_scalar1(con, str_select)

            con.Close()
            If resultado > 0 Then

            Else
                backup_cremcre = "cremcre as cre"
            End If

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            Dim titulo As String = miclase1.ToString("AMIGA - SALDO DE CARTERA POR ANALISTA AL " & hasta_TextBox.Text)

            If todas = "SI" Then
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, usu.nombre as cdescri, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from " & backup_cremcre & "," & " MFAMIGA.dbo.usuarios as usu " & _
                             "where cre.cestado = 'F'   and  " & _
                             "cre.ccodana = usu.usuario  " & _
                             "group by usu.nombre "
            Else
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, usu.nombre as cdescri, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from " & backup_cremcre & "," & " MFAMIGA.dbo.usuarios as usu " & _
                             "where cre.cestado = 'F'   and cre.ccodofi = " & miclase1.ToString(ofice) & " and " & _
                             "cre.ccodana = usu.usuario  " & _
                             "group by usu.nombre "

            End If

            Session("str_select") = str_select
            If grafico_DropDownList.SelectedValue = "Pastel" Then
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica")
            Else
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica1")
            End If


        ElseIf RadioButton46.Checked = True Then
            Dim miclase As New clase_jaime

            Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
            Dim backup_cremcre As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.cremcre "
            Dim resultado As Integer = 0

            Dim con As New SqlConnection
            Dim stringconnection As String = miclase.conexion()
            con.ConnectionString = stringconnection
            con.Open()

            'Para saber si la base de backup existe, sino se va a la base en vivo
            str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                         backup.ToString & "')"
            resultado = miclase.devolver_scalar1(con, str_select)

            con.Close()
            If resultado > 0 Then

            Else
                backup_cremcre = "cremcre"
            End If

            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            Dim titulo As String = miclase1.ToString("AMIGA - CARTERA DE CREDITOS EN MORA POR PRODUCTO AL " & hasta_TextBox.Text)

            If todas = "SI" Then
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, cdescri = case LEFT(cproducto,1) " & _
                             "when 'B' then 'Comercio' " & _
                             "when 'C' then 'Consumo' " & _
                             "when 'E' then 'Vivienda'" & _
                             "when 'F' then 'Fonavipo' " & _
                             "when 'K' then 'Embargo'  end, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from cremcre where cestado = 'F'  and LEFT(cproducto,1) not in ('J','L') " & _
                             "group by case LEFT(cproducto,1) " & _
                             "when 'B' then 'Comercio' " & _
                             "when 'C' then 'Consumo' " & _
                             "when 'E' then 'Vivienda' " & _
                             "when 'F' then 'Fonavipo' " & _
                             "when 'K' then 'Embargo'  end "
            Else
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, cdescri = case LEFT(cproducto,1) " & _
                             "when 'B' then 'Comercio' " & _
                             "when 'C' then 'Consumo' " & _
                             "when 'E' then 'Vivienda'" & _
                             "when 'F' then 'Fonavipo' " & _
                             "when 'K' then 'Embargo'  end, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from cremcre where cestado = 'F' and ccodofi = " & miclase1.ToString(ofice) & " and LEFT(cproducto,1) not in ('J','L') " & _
                             "group by case LEFT(cproducto,1) " & _
                             "when 'B' then 'Comercio' " & _
                             "when 'C' then 'Consumo' " & _
                             "when 'E' then 'Vivienda' " & _
                             "when 'F' then 'Fonavipo' " & _
                             "when 'K' then 'Embargo'  end "

            End If


            Session("str_select") = str_select
            If grafico_DropDownList.SelectedValue = "Pastel" Then
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica")
            Else
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica1")
            End If

        ElseIf RadioButton47.Checked = True Then
            Dim miclase As New clase_jaime

            Dim backup As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4)
            Dim backup_cremcre As String = "BK" & f2.Substring(0, 2) & f2.Substring(3, 2) & f2.Substring(6, 4) & ".dbo.cremcre as cre"
            Dim resultado As Integer = 0

            Dim con As New SqlConnection
            Dim stringconnection As String = miclase.conexion()
            con.ConnectionString = stringconnection
            con.Open()

            'Para saber si la base de backup existe, sino se va a la base en vivo
            str_select = "SELECT COUNT(*) FROM master.dbo.sysdatabases WHERE ([name] = '" & _
                         backup.ToString & "')"
            resultado = miclase.devolver_scalar1(con, str_select)

            con.Close()
            If resultado > 0 Then

            Else
                backup_cremcre = "cremcre as cre"
            End If

            Dim titulo As String = miclase1.ToString("AMIGA - SALDO DE CARTERA EN MORA POR ANALISTA AL " & hasta_TextBox.Text)
            Dim ofice As String = ddlOficinas.SelectedValue.Trim

            If todas = "SI" Then
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, usu.nombre as cdescri, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from " & backup_cremcre & "," & " MFAMIGA.dbo.usuarios as usu " & _
                             "where cre.cestado = 'F'   and cre.ndiaatr > 0 and " & _
                             "cre.ccodana = usu.usuario  " & _
                             "group by usu.nombre "
            Else
                str_select = "set language spanish;  select " & titulo & " as titulo, " & " 00 as casos, usu.nombre as cdescri, " & _
                             "sum(ncapdes - ncappag) as saldo " & _
                             "from " & backup_cremcre & "," & " MFAMIGA.dbo.usuarios as usu " & _
                             "where cre.cestado = 'F' and cre.ccodofi = " & miclase1.ToString(ofice) & " and cre.ndiaatr > 0 and " & _
                             "cre.ccodana = usu.usuario  " & _
                             "group by usu.nombre "

            End If

            Session("str_select") = str_select
            If grafico_DropDownList.SelectedValue = "Pastel" Then
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica")
            Else
                Response.Redirect("~/Contenedor_Ahorros.aspx?parametro=" & "cartera_creditos_grafica1")
            End If

        ElseIf Me.RadioButton48.Checked = True Then


            Dim miclase As New clase_jaime
            Dim omclassAho As New cAhomcta
            Dim ds As New DataSet
            Dim lcOFicina As String = ""
            Dim lcTipAho As String = ""
            Dim mi_rptEmp As Object = ""

            ViewState.Add("Oficinas", "")

            tit = miclase1.ToString("CARTERAS DE AHORRO AL " & hasta_TextBox.Text)
            lcNomOfi = ddlOficinas.SelectedItem.Text.Trim

            If Me.ckbTodas.Checked Then
                lcOFicina = "*"
                ViewState("Oficinas") = "Todas las Oficinas"
            Else
                lcOFicina = Me.ddlOficinas.SelectedValue.Trim
                ViewState("Oficinas") = "Oficina: " & Me.ddlOficinas.SelectedItem.Text.Trim
            End If

            If Me.llahorros.Checked = True Then
                lcTipAho = "*"
            Else
                lcTipAho = Me.CbxTipAho1.SelectedValue.Trim
            End If


            ds = omclassAho.Genera_Saldo_Ahorro_Comparativo(lcTipAho, Date.Parse(Me.desde_TextBox.Text), _
                                                            Date.Parse(Me.hasta_TextBox.Text), tit, lcOFicina)

            If Me.ddlexportar.SelectedValue.Trim = "XLS" Then
                mi_rptEmp = "rpt_cartera_ahorros_Comp_XLS.rpt"
            Else
                mi_rptEmp = "rpt_cartera_ahorros_Comp.rpt"
            End If

            Imprimir(ds, mi_rptEmp, Me.ddlexportar.SelectedValue.Trim)
        End If
    End Sub

    Private Sub DownloadFile(ByVal filepath As String, ByVal name As String)

        Dim toDownload As New FileInfo(filepath)

        If (toDownload.Exists) Then
            Response.AppendHeader("content-disposition", _
            "attachment; filename=" + name)
            Response.ContentType = "text/plain"

            Response.Flush()
            Response.TransmitFile(filepath)
            Response.End()

        Else
            Response.Write("<script language='javascript'>alert('No Existe Archivo')</script>")
        End If
    End Sub
   
    Protected Sub ckbTodas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ckbTodas.CheckedChanged
        If ckbTodas.Checked = False Then
            Me.ddlOficinas.Enabled = True
        Else
            Me.ddlOficinas.Enabled = False
        End If
    End Sub

    Protected Sub llahorros_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles llahorros.CheckedChanged
        If llahorros.Checked = True Then
            Me.CbxTipAho1.Enabled = False
        Else
            Me.CbxTipAho1.Enabled = True
        End If
    End Sub
End Class


