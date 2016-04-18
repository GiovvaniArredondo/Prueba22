Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Drawing.Printing

Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class nuevo_plazo
    Inherits System.Web.UI.UserControl
    Private Shared plazo As Integer
    Private Shared asociado As String
    Private Shared nombre As String
    Private Shared dui As String
    Private Shared linea As String

    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscar_Button.Click
        escondido_TextBox.Text = 0
        Session("gcbuscli") = asociado_TextBox.Text.Trim
        UpdatePanel1.Visible = False
        UpdatePanel2.Visible = False
        UpdatePanel3.Visible = False

        foto_image.Visible = False
        If asociado_TextBox.Text.Length = 0 Then
            Return
        End If
        mensaje.Visible = False
        inicializar()

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

    Protected Sub asociados_GridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asociados_GridView.SelectedIndexChanged
        'btnprogra.Visible = False
        asociado = asociados_GridView.SelectedRow.Cells(1).Text
        nombre = asociados_GridView.SelectedRow.Cells(2).Text
        dui = asociados_GridView.SelectedRow.Cells(3).Text

        crear_Button.Visible = True
        imprimir_Button.Visible = True
        txtccodcli.Text = asociado.Trim

        UpdatePanel3.Visible = True
        foto_firma(asociado)



        Dim lccodofi As String
        Dim eclimide As New climide
        Dim mclimide As New cClimide

        eclimide.ccodcli = asociado
        mclimide.ObtenerClimide(eclimide)
        lccodofi = eclimide.ccodofi
        Dim lcnomofi As String = ""
        Dim etabtofi As New cTabtofi

        lcnomofi = etabtofi.NombreAgencia(lccodofi)
        Label16.Text = "Socio(a) Esta Registrado en: " + lcnomofi

        If asociado = "001000203653" Then
            Response.Write("<script type=text/javascript> alert ('Asociado se encuentra bajo investigación de fondos, solicitar autorización a Gerencia General para realizar transacción') </script>")
        End If

        cargar_tablas()

        linea_DropDownList_SelectedIndexChanged(sender, e)
        'cta_ahorro_DropDownList_SelectedIndexChanged(sender, e)
        asignado_DropDownList_SelectedIndexChanged(sender, e)


    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            If Session("gcbuscli") Is Nothing Then
                Session("gcbuscli") = ""
            End If
        End If
    End Sub
    Private Sub cargar_tablas()
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        'usuarios
        'str_select = "select cnomusu from tabtusu where cestado = 'A' order by cnomusu"
        str_select = "select nombre from usuarios where lactivo = 1 order by nombre"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            asignado_DropDownList.Items.Add(fila("nombre"))
        Next
        asignado_DropDownList.DataBind()
        ds.Clear()
        dt.Clear()
        'ctas de ahorro
        str_select = "select ccodaho from ahomcta where cnudotr = '" & asociado & "'"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        'For Each fila In dt.Rows
        '    cta_ahorro_DropDownList.Items.Add(fila("ccodaho"))
        'Next
        'cta_ahorro_DropDownList.DataBind()
        ds.Clear()
        dt.Clear()
        'ctas de parentesco
        str_select = "select cdescri from parent"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            parentesco1_DropDownList.Items.Add(fila("cdescri"))
            parentesco2_DropDownList.Items.Add(fila("cdescri"))
            parentesco3_DropDownList.Items.Add(fila("cdescri"))
            parentesco4_DropDownList.Items.Add(fila("cdescri"))
            parentesco5_DropDownList.Items.Add(fila("cdescri"))
        Next
        ds.Clear()
        dt.Clear()
        'lineas de ahorro a plazo
        str_select = "select cdeslin, ntasint, nplainf from ahotlin order by ntasint, nplainf"
        'where cnrolin > '0000600' 
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            linea_DropDownList.Items.Add(fila("cdeslin"))
        Next

        'DataBind()


        con.Close()
        'dt = ds.Tables("tabla")
    End Sub

    Private Sub inicializar()
        nombre1_TextBox.Text = ""
        nombre2_TextBox.Text = ""
        nombre3_TextBox.Text = ""
        nombre4_TextBox.Text = ""
        nombre5_TextBox.Text = ""
        '
        dir1_TextBox.Text = ""
        dir2_TextBox.Text = ""
        dir2_TextBox.Text = ""
        dir2_TextBox.Text = ""
        dir2_TextBox.Text = ""
        '
        fecha1_TextBox.Text = ""
        fecha2_TextBox.Text = ""
        fecha3_TextBox.Text = ""
        fecha4_TextBox.Text = ""
        fecha5_TextBox.Text = ""
        '
        porcentaje1_TextBox.Text = "0.00"
        porcentaje2_TextBox.Text = "0.00"
        porcentaje3_TextBox.Text = "0.00"
        porcentaje1_TextBox.Text = "0.00"
        porcentaje1_TextBox.Text = "0.00"
        '
        certificado_TextBox.Text = ""
        monto_TextBox.Text = "0.00"
        fecha_apertura_TextBox.Text = Session("gdfecsis")
        fecha_vence_TextBox.Text = Session("gdfecsis")
        tasa_TextBox.Text = "0.00"
        plazo_TextBox.Text = "0"
        asignado_codigo_TextBox.Text = ""
        cta_nombre_TextBox.Text = ""

    End Sub

    Private Function validar() As Boolean
        If Decimal.Parse(monto_TextBox.Text) = 0 Or Decimal.Parse(tasa_TextBox.Text) = 0 Or Decimal.Parse(plazo_TextBox.Text) = 0 Then
            Return False
        End If
        If cta_nombre_TextBox.Text.Length = 0 Or asignado_codigo_TextBox.Text.Length = 0 Or certificado_TextBox.Text.Length = 0 Then
            Return False
        End If

        Return True
    End Function

    Protected Sub asignado_DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles asignado_DropDownList.SelectedIndexChanged
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        Dim usu As String = asignado_DropDownList.SelectedValue.Trim
        'str_select = "select ccodusu from tabtusu where cnomusu = '" & usu & "'"
        str_select = "select usuario from usuarios where nombre = '" & usu & "'"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            asignado_codigo_TextBox.Text = fila("usuario")
        Next

    End Sub

    Protected Sub cta_ahorro_DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cta_ahorro_DropDownList.SelectedIndexChanged
        Dim miclase1 As New clase_funciones
        'cta_nombre_TextBox.Text = miclase1.tipo_cuenta_ahorro(cta_ahorro_DropDownList.SelectedValue)
    End Sub

    Protected Sub linea_DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles linea_DropDownList.SelectedIndexChanged
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim fila As DataRow
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        Dim linea_nombre As String = linea_DropDownList.SelectedValue.Trim
        str_select = "select cdeslin, cnrolin, ntasint, nplainf from ahotlin where cdeslin = '" & linea_nombre & "'"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        For Each fila In dt.Rows
            tasa_TextBox.Text = fila("ntasint")
            plazo_TextBox.Text = fila("nplainf")
            linea = fila("cnrolin")
        Next

        Dim fec As Date = Date.Parse(fecha_apertura_TextBox.Text)
        plazo = Integer.Parse(plazo_TextBox.Text)
        fecha_vence_TextBox.Text = DateAdd(DateInterval.Day, plazo, fec)


    End Sub

    Protected Sub certificado_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles certificado_TextBox.TextChanged
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim certificado As String = certificado_TextBox.Text.Trim
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        Dim linea As String = linea_DropDownList.SelectedValue.Trim
        str_select = "select ccodcrt from ahomcrt where ccodcrt = '" & certificado & "'"
        ds = miclase.devolver_dataset(con, str_select)
        dt = ds.Tables("tabla")
        con.Close()

        If dt.Rows.Count > 0 Then
            Response.Write(miclase1.mensaje("Certificado ya existe...!!!"))
            'mensaje.Text = "Certicado ya existe...!!!"
            'mensaje.Visible = True
            UpdatePanel1.Visible = False
            UpdatePanel2.Visible = False
            Return
        End If
        UpdatePanel1.Visible = True
        UpdatePanel2.Visible = True

        mensaje.Text = ""
        mensaje.Visible = False

    End Sub
    Protected Sub crear_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles crear_Button.Click


        Dim miclase1 As New clase_funciones
        If validar() = False Then
            Response.Write(miclase1.mensaje("Faltan datos a llenar, tasa, monto, plazo, linea...!!!"))
            'mensaje.Text = "Faltan datos que llenar...!!!"
            'mensaje.Visible = True
            UpdatePanel2.Visible = False
            certificado_TextBox.Text = ""
            certificado_TextBox.Focus()
            Exit Sub
        End If


        If escondido_TextBox.Text <> 0 Then
            Exit Sub
        End If

        escondido_TextBox.Text = 100

        Dim str_select As String = ""
        Dim error100 As Integer = 0
        Dim miclase As New clase_especial

        Dim ds As New DataSet
        Dim dt As New DataTable

        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()

        str_select = "begin tran"
        miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback"
            miclase.nonquery_sin_parametros(con, str_select)
            mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
            mensaje.Visible = True
            con.Close()
            crear_Button.Visible = False
            Return
        End If

        'linea, asociado, nombre, dui   ya vienen
        Dim certificado As String = "'" & certificado_TextBox.Text.ToString & "'"
        Dim tasa As Decimal = Decimal.Parse(tasa_TextBox.Text)
        plazo = Integer.Parse(plazo_TextBox.Text)
        Dim asignado As String = "'" & asignado_codigo_TextBox.Text.ToString & "'"
        Dim monto As Decimal = Decimal.Parse(monto_TextBox.Text)
        Dim fec1 As Date = Date.Parse(fecha_apertura_TextBox.Text)
        Dim fec2 As Date = Date.Parse(fecha_vence_TextBox.Text)
        Dim fec_aper As String = Left(fec1.ToString, 10) 'miclase1.ToString(fec1)
        Dim fec_ven As String = Left(fec2.ToString, 10) 'miclase1.ToString(fec2)
        Dim cta_ahorro As String = "" 'miclase1.ToString(cta_ahorro_DropDownList.SelectedValue.Trim)
        linea = linea.Trim
        nombre = nombre.Trim 'miclase1.ToString(nombre.Trim)

        Dim ccodusu As String = miclase1.ToString(Session("gccodusu").trim)
        'SET LANGUAGE spanish;
        'inserta el certificado a la tabla
        str_select = " insert into ahomcrt " & _
                     "(ccodcrt,cnrolin,nombre,cnudotr,ccodaho,nmonapr,ntasint,nplazo,nintere,dfecapr,dfecven,dfecprv,dfecori,dfecliq,ndiagra,ccalint," & _
                     "cprvint,ccodbco,cctacte,ccapita,cpignor,ccodcta,dfecmod,ccodusu,cprovis,cliq,nsaldoaho,dfeccap,ccodcli,cestado,producto,dmenpro," & _
                     "dultpro,producto2,nmonto2) values " & _
                     "(" & certificado & "," & miclase1.ToString(linea) & "," & "'" & nombre & "'" & "," & miclase1.ToString(asociado) & "," & cta_ahorro & ", 0, " & tasa & "," & plazo & ",0," & "'" & fec_aper & "'" & "," & "'" & fec_ven & "'" & "," & "'" & fec_ven & "'" & "," & "'" & fec_aper & "'" & "," & "'" & fec_aper & "'" & ",0,'M'," & _
                     "'1','1',' ',' ','N',' '," & "'" & fec_aper & "'" & "," & ccodusu & "," & "'N', 'N'," & monto & "," & "'" & fec_aper & "'" & ",' ',' ',' '," & "'" & fec_aper & "'" & "," & _
                     "'" & fec_aper & "'" & "," & asignado & ",0)"
        error100 = miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback"
            miclase.nonquery_sin_parametros(con, str_select)
            mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
            mensaje.Visible = True
            con.Close()
            crear_Button.Visible = False
            Return
        End If

        Dim nom1 As String = miclase1.ToString(nombre1_TextBox.Text.Trim)
        Dim nom2 As String = miclase1.ToString(nombre2_TextBox.Text.Trim)
        Dim nom3 As String = miclase1.ToString(nombre3_TextBox.Text.Trim)
        Dim nom4 As String = miclase1.ToString(nombre4_TextBox.Text.Trim)
        Dim nom5 As String = miclase1.ToString(nombre5_TextBox.Text.Trim)
        Dim f1 As String = ""
        Dim f2 As String = ""
        Dim f3 As String = ""
        Dim f4 As String = ""
        Dim f5 As String = ""
        Dim por1 As Decimal = Decimal.Parse(porcentaje1_TextBox.Text)
        Dim por2 As Decimal = Decimal.Parse(porcentaje2_TextBox.Text)
        Dim por3 As Decimal = Decimal.Parse(porcentaje3_TextBox.Text)
        Dim por4 As Decimal = Decimal.Parse(porcentaje4_TextBox.Text)
        Dim por5 As Decimal = Decimal.Parse(porcentaje5_TextBox.Text)
        Dim pariente1 As String = miclase1.ToString(miclase1.codigo_parentesco(parentesco1_DropDownList.SelectedValue.Trim))
        Dim pariente2 As String = miclase1.ToString(miclase1.codigo_parentesco(parentesco2_DropDownList.SelectedValue.Trim))
        Dim pariente3 As String = miclase1.ToString(miclase1.codigo_parentesco(parentesco3_DropDownList.SelectedValue.Trim))
        Dim pariente4 As String = miclase1.ToString(miclase1.codigo_parentesco(parentesco4_DropDownList.SelectedValue.Trim))
        Dim pariente5 As String = miclase1.ToString(miclase1.codigo_parentesco(parentesco5_DropDownList.SelectedValue.Trim))

        'parte de beneficiarios
        Dim benef As Integer = 0
        If nombre1_TextBox.Text.Length > 0 Then
            benef = benef + 1
            fec1 = Date.Parse(fecha1_TextBox.Text)
            f1 = miclase1.ToString(fec1)
        End If
        If nombre2_TextBox.Text.Length > 0 Then
            benef = benef + 1
            fec1 = Date.Parse(fecha2_TextBox.Text)
            f2 = miclase1.ToString(fec1)
        End If
        If nombre3_TextBox.Text.Length > 0 Then
            benef = benef + 1
            fec1 = Date.Parse(fecha3_TextBox.Text)
            f3 = miclase1.ToString(fec1)
        End If
        If nombre4_TextBox.Text.Length > 0 Then
            benef = benef + 1
            fec1 = Date.Parse(fecha4_TextBox.Text)
            f4 = miclase1.ToString(fec1)
        End If
        If nombre5_TextBox.Text.Length > 0 Then
            benef = benef + 1
            fec1 = Date.Parse(fecha5_TextBox.Text)
            f5 = miclase1.ToString(fec1)
        End If

        If benef >= 1 Then
            'inserta en la tabla de beneficiarios de depsoitos a plazo
            str_select = "insert into depmben " & _
                         "(ccodcrt,ncorrel,cnomben,cparent,dfecnac,nporcen,cflag) values " & _
                         "(" & certificado & ", 1," & nom1 & "," & pariente1 & "," & f1 & "," & por1 & ",' ')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback"
                miclase.nonquery_sin_parametros(con, str_select)
                mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
                mensaje.Visible = True
                con.Close()
                crear_Button.Visible = False
                Return
            End If

        End If
        If benef >= 2 Then
            'inserta en la tabla de beneficiarios de depsoitos a plazo
            str_select = "insert into depmben " & _
                         "(ccodcrt,ncorrel,cnomben,cparent,dfecnac,nporcen,cflag) values " & _
                         "(" & certificado & ", 2," & nom2 & "," & pariente2 & "," & f2 & "," & por2 & ",' ')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback"
                miclase.nonquery_sin_parametros(con, str_select)
                mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
                mensaje.Visible = True
                con.Close()
                crear_Button.Visible = False
                Return
            End If

        End If
        If benef >= 3 Then
            'inserta en la tabla de beneficiarios de depsoitos a plazo
            str_select = "insert into depmben " & _
                         "(ccodcrt,ncorrel,cnomben,cparent,dfecnac,nporcen,cflag) values " & _
                         "(" & certificado & ", 3," & nom3 & "," & pariente3 & "," & f3 & "," & por3 & ",' ')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback"
                miclase.nonquery_sin_parametros(con, str_select)
                mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
                mensaje.Visible = True
                con.Close()
                crear_Button.Visible = False
                Return
            End If

        End If
        If benef >= 4 Then
            'inserta en la tabla de beneficiarios de depsoitos a plazo
            str_select = "insert into depmben " & _
                         "(ccodcrt,ncorrel,cnomben,cparent,dfecnac,nporcen,cflag) values " & _
                         "(" & certificado & ", 4," & nom4 & "," & pariente4 & "," & f4 & "," & por4 & ",' ')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback"
                miclase.nonquery_sin_parametros(con, str_select)
                mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
                mensaje.Visible = True
                con.Close()
                crear_Button.Visible = False
                Return
            End If

        End If
        If benef = 5 Then
            'inserta en la tabla de beneficiarios de depsoitos a plazo
            str_select = "insert into depmben " & _
                         "(ccodcrt,ncorrel,cnomben,cparent,dfecnac,nporcen,cflag) values " & _
                         "(" & certificado & ", 5," & nom5 & "," & pariente5 & "," & f5 & "," & por5 & ",' ')"
            error100 = miclase.nonquery_sin_parametros(con, str_select)
            If error100 = -100 Then
                str_select = "rollback"
                miclase.nonquery_sin_parametros(con, str_select)
                mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
                mensaje.Visible = True
                con.Close()
                crear_Button.Visible = False
                Return
            End If

        End If

        str_select = "commit tran"
        miclase.nonquery_sin_parametros(con, str_select)
        If error100 = -100 Then
            str_select = "rollback"
            miclase.nonquery_sin_parametros(con, str_select)
            mensaje.Text = "Ha ocurrido un error, certificado no creado!!!"
            mensaje.Visible = True
            con.Close()
            crear_Button.Visible = False
            Return
        End If

        con.Close()

        Response.Write(miclase1.mensaje("Certificado Creado...!!!"))
        'mensaje.Text = "Certificado creado!!!"
        'mensaje.Visible = True



        '----------------------------------

        Dim lndepositos As Decimal = 0
        txtdepositos.Text = ObtenerDepositos()

        lndepositos = Double.Parse(txtdepositos.Text)

        lndepositos = lndepositos + Double.Parse(monto_TextBox.Text)

        'If (Double.Parse(monto_TextBox.Text) >= 5000.0 And Double.Parse(monto_TextBox.Text) <= 57000) Or _
        '(lndepositos > 57000) Then
        '    Session("fuente") = "Los Depositos Realizados a 30 días Superan el Limite de LAVADO " + Chr(13) + "DE DINERO Permitido, Esta Advertencia Debe de ser Trasladada  " + Chr(13) + "al Jefe de Mercadeo ,para que LLene el Formulario Correspondiante y sea Enviado a LA FISCALIA DE LA REPUBLICA"
        '    Response.Write("<script>window.open('Mensaje.aspx','cal', 'location=1, toolbar = no, status=1,width=550,height=230')</script>")
        '    btnprogra.Visible = True
        'Else
        '    btnprogra.Visible = False
        'End If
        '----------------------------------

        crear_Button.Visible = False

    End Sub
    Protected Sub imprimir_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles imprimir_Button.Click

        Dim miclase1 As New clase_funciones
        Dim miclase As New clase_especial
        Dim ds As DataSet

        Dim certificado As String = certificado_TextBox.Text.ToString
        Dim tasa As Decimal = Decimal.Parse(tasa_TextBox.Text)
        plazo = Integer.Parse(plazo_TextBox.Text)
        Dim asignado As String = asignado_codigo_TextBox.Text.ToString
        Dim monto As Decimal = Decimal.Parse(monto_TextBox.Text)
        Dim fec1 As Date = Date.Parse(fecha_apertura_TextBox.Text)
        Dim fec2 As Date = Date.Parse(fecha_vence_TextBox.Text)
        Dim cta_ahorro As String = "" 'cta_ahorro_DropDownList.SelectedValue.Trim
        Dim vence As String = fec2


        Dim nom1 As String = nombre1_TextBox.Text.Trim
        Dim nom2 As String = nombre2_TextBox.Text.Trim
        Dim nom3 As String = nombre3_TextBox.Text.Trim
        Dim nom4 As String = nombre4_TextBox.Text.Trim
        Dim nom5 As String = nombre5_TextBox.Text.Trim
        Dim f1 As String = fecha1_TextBox.Text
        Dim f2 As String = fecha2_TextBox.Text
        Dim f3 As String = fecha3_TextBox.Text
        Dim f4 As String = fecha4_TextBox.Text
        Dim f5 As String = fecha5_TextBox.Text
        Dim por1 As Decimal = Decimal.Parse(porcentaje1_TextBox.Text)
        Dim por2 As Decimal = Decimal.Parse(porcentaje2_TextBox.Text)
        Dim por3 As Decimal = Decimal.Parse(porcentaje3_TextBox.Text)
        Dim por4 As Decimal = Decimal.Parse(porcentaje4_TextBox.Text)
        Dim por5 As Decimal = Decimal.Parse(porcentaje5_TextBox.Text)
        Dim pariente1 As String = parentesco1_DropDownList.SelectedValue.Trim
        Dim pariente2 As String = parentesco2_DropDownList.SelectedValue.Trim
        Dim pariente3 As String = parentesco3_DropDownList.SelectedValue.Trim
        Dim pariente4 As String = parentesco4_DropDownList.SelectedValue.Trim
        Dim pariente5 As String = parentesco5_DropDownList.SelectedValue.Trim
        Dim dir1 As String = dir1_TextBox.Text
        Dim dir2 As String = dir2_TextBox.Text
        Dim dir3 As String = dir3_TextBox.Text
        Dim dir4 As String = dir4_TextBox.Text
        Dim dir5 As String = dir5_TextBox.Text

        Dim str_select As String
        str_select = "select " & miclase1.ToString(certificado) & " as certificado ," & miclase1.ToString(asociado) & " as cnudotr," & monto & " as monto," & miclase1.ToString(nombre) & " as nombre," & miclase1.ToString(dui) & " as dui," & _
                     miclase1.ToString(miclase1.ConversionEnteros(monto)) & " as letras," & miclase1.ToString(plazo.ToString & " DIAS") & " as plazo," & miclase1.ToString(tasa.ToString & " ANUAL") & _
                     " as tasa," & miclase1.ToString(vence) & " as fecha," & miclase1.ToString(cta_ahorro) & " as ahorro," & _
                     miclase1.ToString(nom1) & " as ben1," & miclase1.ToString(nom2) & " as ben2," & miclase1.ToString(nom3) & " as ben3," & miclase1.ToString(nom4) & " as ben4," & _
                     miclase1.ToString(nom5) & " as ben5," & miclase1.ToString(f1) & " as fec1," & miclase1.ToString(f2) & " as fec2," & miclase1.ToString(f3) & " as fec3," & _
                     miclase1.ToString(f4) & " as fec4," & miclase1.ToString(f5) & " as fec5," & miclase1.ToString(dir1) & " as dir1," & miclase1.ToString(dir2) & " as dir2," & _
                     miclase1.ToString(dir3) & " as dir3," & miclase1.ToString(dir4) & " as dir4," & miclase1.ToString(dir5) & " as dir5," & por1 & " as por1," & por2 & " as por2," & por3 & " as por3," & _
                     por4 & " as por4," & por5 & " as por5"


        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.devolver_dataset(con, str_select)

        con.Close()

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream


        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\certificado.rpt", OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            ' Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        Dim reportes As String

        reportes = "certificado.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()


        'Session("str_select") = str_select

        'Response.Redirect("~/reporte_contenedor.aspx?parametro=" & "certificado_nuevo")





    End Sub
    'esta es la rutina que llama   

    Protected Sub foto_firma(ByVal asociado As String)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, 1)
        If huella1 <> "basura" Then
            foto_image.Height = 75
            foto_image.Width = 100
            foto_image.ImageUrl = huella1
            foto_image.Visible = False
        End If

    End Sub


    Private Sub lavado()
        '        Try

        Dim origen As String
        Dim Destino As String
        Dim lcnomcli As String = ""
        Dim ldnacimi As Date = Session("gdfecsis")
        Dim lcsexo As String = ""
        Dim lcdui As String = ""
        Dim lcteldom As String = ""
        Dim lccelular As String = ""
        Dim lccodpro As String = ""
        Dim lcprofesion As String = ""
        Dim lcestciv As String = ""
        Dim lccivil As String = ""
        Dim lcdirdom As String = ""
        Dim etabtprf As New cTabtprf
        Dim entidadtabtprf As New tabtprf
        Dim eclimide As New cClimide
        Dim entidadclimide As New climide
        Dim etabttab As New cTabttab
        Dim ds As New DataSet


        ds = eclimide.ObtenerDatosClimide(txtccodcli.Text.Trim)
        origen = Session("codigo")
        Destino = Session("fuente")


        entidadclimide.ccodcli = txtccodcli.Text.Trim
        eclimide.ObtenerClimide(entidadclimide)

        lcnomcli = entidadclimide.cnomcli.Trim
        ldnacimi = entidadclimide.dnacimi
        lcsexo = entidadclimide.csexo
        lcdui = entidadclimide.cnudoci
        lcteldom = entidadclimide.cteldom
        lccelular = entidadclimide.cTelFam
        lccodpro = entidadclimide.ccodpro
        lcestciv = entidadclimide.cestciv
        lccivil = etabttab.Describe(lcestciv, "012")
        lcdirdom = entidadclimide.cdirdom

        entidadtabtprf.ccodigo = lccodpro
        etabtprf.ObtenerTabtprf(entidadtabtprf)

        lcprofesion = entidadtabtprf.cdescri


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream


        Try
            'Cargar Definicion del Reporte
            If Double.Parse(monto_TextBox.Text) >= 5000 And Double.Parse(monto_TextBox.Text) <= 57000 Then
                crRpt.Load(Server.MapPath("reportes") + "\CrLavado.rpt", OpenReportMethod.OpenReportByDefault)
            Else
                crRpt.Load(Server.MapPath("reportes") + "\CrLavado2.rpt", OpenReportMethod.OpenReportByDefault)
            End If

        Catch ex As Exception
            ' Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("pcorigen", origen)
        crRpt.SetParameterValue("pcdestino", Destino)

        crRpt.SetParameterValue("id1", "")
        crRpt.SetParameterValue("id2", "")
        crRpt.SetParameterValue("id3", "X")
        crRpt.SetParameterValue("id4", "")
        crRpt.SetParameterValue("id5", "")
        crRpt.SetParameterValue("id6", "")
        crRpt.SetParameterValue("id7", "")

        crRpt.SetParameterValue("nmonto1", 0)
        crRpt.SetParameterValue("nmonto2", 0)
        crRpt.SetParameterValue("nmonto3", Double.Parse(monto_TextBox.Text))
        crRpt.SetParameterValue("nmonto4", 0)
        crRpt.SetParameterValue("nmonto5", 0)
        crRpt.SetParameterValue("nmonto6", 0)
        crRpt.SetParameterValue("nmonto7", 0)

        crRpt.SetParameterValue("pccodcli", txtccodcli.Text.Trim)
        crRpt.SetParameterValue("pcnomcli", lcnomcli)
        crRpt.SetParameterValue("pdnacimi", ldnacimi)
        crRpt.SetParameterValue("pcsexo", lcsexo)
        crRpt.SetParameterValue("pcdui", lcdui)
        crRpt.SetParameterValue("pcteldom", (lcteldom + " " + lccelular))
        crRpt.SetParameterValue("pcprofesion", lcprofesion)
        crRpt.SetParameterValue("pccivil", lccivil)
        crRpt.SetParameterValue("pcdirdom", lcdirdom)

        Dim reportes As String

        reportes = "Lavado.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()

        '       Catch ex As Exception

        '      End Try

    End Sub
    Private Function ObtenerDepositos() As Decimal
        Dim clsppal As New class1
        Dim ldfecini As Date
        Dim lccodaho As String = ""
        Dim eahomcta As New cAhomcta
        Dim ds As New DataSet
        Dim lndepositos As Decimal = 0
        ldfecini = DateAdd(DateInterval.Day, -30, Session("gdfecsis"))
        'Obtiene codigo de cuenta de ahorro
        lndepositos = clsppal.ObtenerSumadeDepositos(txtccodcli.Text.Trim, ldfecini)


        Return lndepositos
    End Function

    Protected Sub repetir_ImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles repetir_ImageButton.Click
        asociado_TextBox.Text = Session("gcbuscli").ToString.Trim
        buscar_Button_Click(sender, e)
    End Sub



    'Protected Sub btnprogra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnprogra.Click
    '    lavado()
    'End Sub


    Protected Sub reimprimir_CheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles reimprimir_CheckBox.CheckedChanged
        Dim str_select As String = ""
        Dim miclase As New clase_especial
        Dim miclase1 As New clase_funciones
        Dim ds As New DataSet
        Dim fila As DataRow

        Dim cert As String = certificado_TextBox.Text.Trim
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        Dim linea As String = ""
        Dim par1 As String = ""
        Dim par2 As String = ""
        Dim par3 As String = ""
        Dim par4 As String = ""
        Dim par5 As String = ""

        If reimprimir_CheckBox.Checked = True Then

            con.Open()
            str_select = "select crt.ccodcrt,crt.cnudotr, crt.dfecven, crt.ccodaho,crt.cnrolin,crt.nombre, crt.ccodaho, crt.nmonapr,crt.ntasint,crt.nplazo, " & _
                         "lin.cdeslin, ben.cnomben, ben.cparent, ben.dfecnac, ben.nporcen, par.cdescri as parentesco " & _
                         "from ahomcrt as crt, ahotlin as lin, depmben as ben, parent as par " & _
                         "where crt.ccodcrt = " & miclase1.ToString(cert) & " and crt.cnrolin = lin.cnrolin and ben.cparent = par.cparent " & _
                         "and crt.ccodcrt = ben.ccodcrt "

            ds = miclase.devolver_dataset(con, str_select)

            con.Close()
            Dim c As Integer = 0
            For Each fila In ds.Tables(0).Rows
                c = c + 1
                If c = 1 Then
                    monto_TextBox.Text = fila("nmonapr")
                    tasa_TextBox.Text = fila("ntasint")
                    plazo_TextBox.Text = fila("nplazo")
                    fecha_vence_TextBox.Text = fila("dfecven")
                    linea_DropDownList.SelectedValue = fila("cdeslin")
                    'cta_ahorro_DropDownList.SelectedValue = fila("ccodaho")
                End If
                If c = 1 Then
                    nombre1_TextBox.Text = fila("cnomben")
                    fecha1_TextBox.Text = fila("dfecnac")
                    porcentaje1_TextBox.Text = fila("nporcen")
                    par1 = fila("parentesco")
                    parentesco1_DropDownList.SelectedValue = par1
                End If
                If c = 2 Then
                    nombre2_TextBox.Text = fila("cnomben")
                    fecha2_TextBox.Text = fila("dfecnac")
                    porcentaje2_TextBox.Text = fila("nporcen")
                    par2 = fila("parentesco")
                    parentesco2_DropDownList.SelectedValue = par2

                End If
                If c = 3 Then
                    nombre3_TextBox.Text = fila("cnomben")
                    fecha3_TextBox.Text = fila("dfecnac")
                    porcentaje3_TextBox.Text = fila("nporcen")
                    par3 = fila("parentesco")
                    parentesco3_DropDownList.SelectedValue = par3

                End If
                If c = 4 Then
                    nombre4_TextBox.Text = fila("cnomben")
                    fecha4_TextBox.Text = fila("dfecnac")
                    porcentaje4_TextBox.Text = fila("nporcen")
                    par4 = fila("parentesco")
                    parentesco4_DropDownList.SelectedValue = par4

                End If
                If c = 5 Then
                    nombre5_TextBox.Text = fila("cnomben")
                    fecha5_TextBox.Text = fila("dfecnac")
                    porcentaje5_TextBox.Text = fila("nporcen")
                    par5 = fila("parentesco")
                    parentesco5_DropDownList.SelectedValue = par5

                End If


            Next


            UpdatePanel1.Visible = True
            UpdatePanel2.Visible = True
            mensaje.Text = ""
            mensaje.Visible = False
            crear_Button.Visible = False

            'Session("fuente") = "Favor complemente la linea, direccion y parentesco "
            'Response.Write("<script>window.open('Mensaje.aspx','cal', 'location=1, toolbar = no, status=1,width=550,height=130')</script>")


        End If
    End Sub

   
End Class
