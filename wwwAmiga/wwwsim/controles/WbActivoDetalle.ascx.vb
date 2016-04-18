Imports System.IO
Public Class WbActivo1
    Inherits System.Web.UI.UserControl
    Dim varcomp As Integer
#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

#Region " Variables "
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clase As New SIM.BL.class1
    Private classActivo As New clsActivo
    Dim eactivof As New cActivoF

    Private pcCodCta As String
    'Private lNuevo As Boolean
    Private vCnn As Boolean
    Private Transacc As String
    Private ds As New DataSet
    Private ds_R As New DataSet
    Private lnindice_R As Integer
    Private lnindice_R1 As Integer
    Private lncodigo_R As String
    Private lnVal_R As String
    Private llBan_R As Boolean = False
    Private x As Integer
    Private y As Integer
    Private lnusu_R As String
    Private lnapl_R As String


    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    '--------------------------------  
    Private pcTipCre As String
    Private pcNrolin As String
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Private ValorS As String
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
            CargaMarcas()
            CargaLinea()
            'Me.CargaProveedores()
            Me.CargaUsuarios()
        End If
    End Sub

    Private Sub CargaMarcas()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaMarcas As New listatabttab

        mListaMarcas = clstabttab.ObtenerLista("228", "1")

        cmbMarca.DataValueField = "ccodigo"
        cmbMarca.DataTextField = "cdescri"
        cmbMarca.DataSource = mListaMarcas
        cmbMarca.DataBind()
    End Sub

    Private Sub CargaLinea()
        Dim clsLinea As New SIM.BL.cTabttab
        Dim mListaLinea As New listatabttab

        mListaLinea = clsLinea.ObtenerLista("229", "1")

        cmbLinea.DataValueField = "ccodigo"
        cmbLinea.DataTextField = "cdescri"
        cmbLinea.DataSource = mListaLinea
        cmbLinea.DataBind()
    End Sub

    'Private Sub CargaProveedores()
    '    'oficinas
    '    Dim clscntaemp As New SIM.BL.cCntaemp
    '    Dim mListacntaemp As New listacntaemp

    '    mListacntaemp = clscntaemp.ObtenerLista()

    '    Me.cmbProvee.DataTextField = "cdescri"
    '    Me.cmbProvee.DataValueField = "ccodemp"
    '    Me.cmbProvee.DataSource = mListacntaemp
    '    Me.cmbProvee.DataBind()
    'End Sub


    Private Sub CargaUsuarios()
        'usuarios
        Dim clsusu As New SIM.BL.cusuarios
        Dim mListaUsu As New DataSet
        mListaUsu = clsusu.ObtenerUsuarios2
        cmbUsuarios.DataTextField = "Nombre"
        cmbUsuarios.DataValueField = "Usuario"
        cmbUsuarios.DataSource = mListaUsu
        cmbUsuarios.DataBind()
    End Sub
#Region " Metodos "
    Private Sub CargarDatos()
        'Estado del Bien
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1561'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.DropDownList1.DataTextField = "cDescri"
        Me.DropDownList1.DataValueField = "cCodigo"
        Me.DropDownList1.DataSource = ds.Tables("Resultado")
        Me.DropDownList1.DataBind()
        ds.Tables("Resultado").Clear()


        'Fuente de Fondos
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        Dim lcfondos As String
        lcfondos = Session("gcfondo")

        mListaTabttab = clstabttab.ObtenerListaPorIDxcodigo("033", "1", lcfondos)

        'Me.cmbFondos.DataTextField = "cdescri"
        'Me.cmbFondos.DataValueField = "ccodigo"
        'Me.cmbFondos.DataSource = mListaTabttab
        'Me.cmbFondos.DataBind()

        'Origen de la Adquisicion
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1181'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.DropDownList2.DataTextField = "cDescri"
        Me.DropDownList2.DataValueField = "cCodigo"
        Me.DropDownList2.DataSource = ds.Tables("Resultado")
        Me.DropDownList2.DataBind()
        ds.Tables("Resultado").Clear()

        'Ubicacion Fisica
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1571'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.DropDownList3.DataTextField = "cDescri"
        Me.DropDownList3.DataValueField = "cCodigo"
        Me.DropDownList3.DataSource = ds.Tables("Resultado")
        Me.DropDownList3.DataBind()
        ds.Tables("Resultado").Clear()

        'Activo Fijo
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1131'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist4.DataTextField = "cDescri"
        Me.Dropdownlist4.DataValueField = "cCodigo"
        Me.Dropdownlist4.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist4.DataBind()
        ds.Tables("Resultado").Clear()

        'Clasificacion del activo Fijo
        lnparametro1_R = "cDescri , ctipact, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTACT"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodact = '10'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist5.DataTextField = "cDescri"
        Me.Dropdownlist5.DataValueField = "ctipact"
        Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist5.DataBind()
        ds.Tables("Resultado").Clear()

        'Oficina
        lnparametro1_R = "cnomofi , cCodofi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = ""
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist6.DataTextField = "cnomofi"
        Me.Dropdownlist6.DataValueField = "cCodofi"
        Me.Dropdownlist6.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist6.DataBind()
        ds.Tables("Resultado").Clear()

        'Unidad
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0871'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        'Me.Dropdownlist7.DataTextField = "cDescri"
        'Me.Dropdownlist7.DataValueField = "cCodigo"
        'Me.Dropdownlist7.DataSource = ds.Tables("Resultado")
        'Me.Dropdownlist7.DataBind()
        ds.Tables("Resultado").Clear()

        Me.limpiar()
    End Sub

#End Region

    Private Sub btnGraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraba.ServerClick
        'valida datos
        If Me.TextBox2.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Descripción del Bien Vacía')</script>")
            Exit Sub
            'ElseIf Me.TextBox3.Text.Trim = "" Or Integer.Parse(Me.TextBox3.Text.Trim) = 0 Then
            '    Response.Write("<script language='javascript'>alert('Valor de Compra del Bien Vacío')</script>")
            '    Exit Sub
            'ElseIf Me.TextBox5.Text.Trim = "" Or Integer.Parse(Me.TextBox5.Text.Trim) = 0 Then
            '    Response.Write("<script language='javascript'>alert('Vida Util vacía')</script>")
            '    Exit Sub
            'ElseIf Me.Textbox8.Text.Trim = "" Then
            '    Me.Textbox8.Text = 0
        End If

        Dim g As Integer
        'Genera codigo
        'Dim pccodigo As String
        Dim pre As String
        Dim corigen As String
        Dim ccodofi As String
        Dim etabttab As New cTabttab
        Dim etabtofi As New cTabtofi
        'Dim cunidad As String
        Dim ccodact As String
        Dim ctipact As String
        'Dim ccodinv As String

        pre = etabttab.DescribeAux(Me.DropDownList2.SelectedValue.Trim, "118").Trim
        corigen = Me.DropDownList2.SelectedValue.Trim
        ccodofi = etabtofi.OficinaAux(Me.Dropdownlist6.SelectedValue.Trim)
        ccodact = Me.Dropdownlist4.SelectedValue.Trim
        ctipact = Me.Dropdownlist5.SelectedValue.Trim

        'pccodigo = Me.CodigoGenerado(corigen, ccodofi, cunidad, ccodact, ctipact)
        'pccodigo = Me.CodigoGenerado(corigen, cunidad, ccodact, ctipact)
        'ccodinv = pre & Right(pccodigo.Trim, 11)
        'Me.TextBox1.Text = ccodinv

        'classActivo.cCodinv = pccodigo
        classActivo.cdesbien = Me.TextBox2.Text.Trim
        classActivo.cestbien = Me.DropDownList1.SelectedValue.Trim
        classActivo.dfecadq = Me.TextBox4.Text.Trim
        classActivo.ccodadq = Me.DropDownList2.SelectedValue.Trim
        classActivo.ccodubi = Me.DropDownList3.SelectedValue.Trim
        classActivo.cnumser = Me.TextBox7.Text.Trim
        classActivo.ccodact = Me.Dropdownlist4.SelectedValue.Trim
        classActivo.ctipact = Me.Dropdownlist5.SelectedValue.Trim
        classActivo.ccodofi = Me.Dropdownlist6.SelectedValue.Trim
        g = classActivo.GrabarActivo()

        'Response.Write("<script language='javascript'>alert('Codigo de Activo es  " & ccodinv & " ')</script>")
        'Desactivar campos
        Me.Desactivar()
    End Sub
    'Private Function CodigoGenerado(ByVal corigen As String, ByVal coficina As String, ByVal cunidad As String, _
    'ByVal ccodact As String, ByVal ctipact As String) As String
    '    Dim precod As String
    '    Dim ccodigo As String
    '    Dim i As String
    '    'precod = corigen.Trim & coficina.Trim & cunidad.Trim & ccodact.Trim & ctipact.Trim
    '    precod = corigen.Trim & cunidad.Trim & ccodact.Trim & ctipact.Trim

    '    'Busca codigo para asignar correlativo
    '    i = eactivof.BuscaCodigo(precod)
    '    ccodigo = precod & i
    '    Return ccodigo
    'End Function

    Private Function CodigoGenerado(ByVal corigen As String, ByVal cunidad As String, _
    ByVal ccodact As String, ByVal ctipact As String) As String
        Dim precod As String
        Dim ccodigo As String
        Dim i As String
        'precod = corigen.Trim & coficina.Trim & cunidad.Trim & ccodact.Trim & ctipact.Trim
        precod = corigen.Trim & cunidad.Trim & ccodact.Trim & ctipact.Trim

        'Busca codigo para asignar correlativo
        i = eactivof.BuscaCodigo(precod)
        ccodigo = precod & i
        Return ccodigo
    End Function

    Private Sub limpiar()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        'Me.TextBox3.Text = ""
        Me.TextBox4.Text = Session("gdfecsis")
        Me.TextBox13.Text = Session("gdfecsis")
        Me.txtOperador.Text = Session("gcCodusu")
        'Me.TextBox5.Text = ""
        'Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        'Me.Textbox8.Text = ""


        Me.TextBox2.Enabled = True
        'Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        'Me.TextBox5.Enabled = True
        'Me.TextBox6.Enabled = True
        Me.TextBox7.Enabled = True
        'Me.Textbox8.Enabled = True

        Me.DropDownList1.Enabled = True
        Me.DropDownList2.Enabled = True
        Me.DropDownList3.Enabled = True
        Me.Dropdownlist4.Enabled = True
        Me.Dropdownlist5.Enabled = True
        Me.Dropdownlist6.Enabled = True
        'Me.Dropdownlist7.Enabled = True

        Me.btnGraba.Disabled = False
        Me.btnNew.Disabled = True
    End Sub

    Private Sub Desactivar()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        'Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        'Me.TextBox5.Enabled = False
        'Me.TextBox6.Enabled = False
        Me.TextBox7.Enabled = False
        'Me.Textbox8.Enabled = False

        Me.DropDownList1.Enabled = False
        Me.DropDownList2.Enabled = False
        Me.DropDownList3.Enabled = False
        Me.Dropdownlist4.Enabled = False
        Me.Dropdownlist5.Enabled = False
        Me.Dropdownlist6.Enabled = False
        'Me.Dropdownlist7.Enabled = False

        Me.btnGraba.Disabled = True
        Me.btnNew.Disabled = False
    End Sub

    Private Sub btnNew_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.ServerClick
        limpiar()
    End Sub

    Private Sub ActivaControlesDescriCompu()
        Dim val As Boolean

        If varcomp = 1 Then
            val = True
        ElseIf varcomp = 2 Then
            val = False
        End If

        Me.txtSeri.Enabled = val
        Me.txtModelo.Enabled = val
        Me.cmbMarca.Enabled = val
        Me.cmbLinea.Enabled = val
        Me.txtDisco.Enabled = val
        Me.txtMemoria.Enabled = val
        Me.txtProcesador.Enabled = val
        Me.txtLicencia.Enabled = val
        Me.txtUsLog.Enabled = val
        Me.txtPassLog.Enabled = val
        Me.txtPassInter.Enabled = val
    End Sub

    Private Sub Dropdownlist4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dropdownlist4.SelectedIndexChanged
        'Verifica si el activo fijo es 
        'Equipo de computacion para activar
        'el grid e ingresar los detalles del mismo
        Dim xz As String
        xz = Dropdownlist4.SelectedValue.Trim

        If xz = "30" Then
            varcomp = 1     'si activa
            ActivaControlesDescriCompu()
        Else
            varcomp = 2     'desactiva
            ActivaControlesDescriCompu()
        End If

        'Clasificacion del activo Fijo
        Dim lcactfij As String
        lcactfij = Me.Dropdownlist4.SelectedValue.Trim
        lnparametro1_R = "cDescri , ctipact, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTACT"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodact = " + "'" + lcactfij + "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.Dropdownlist5.DataTextField = "cDescri"
        Me.Dropdownlist5.DataValueField = "ctipact"
        Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        Me.Dropdownlist5.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub

    'Protected Sub btnProvee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProvee.Click
    '    Response.Write("<script>window.open('wbProveeActi.aspx','cal', 'location=1, toolbar = no, status=1,width=650,height=650')</script>")
    'End Sub
End Class
