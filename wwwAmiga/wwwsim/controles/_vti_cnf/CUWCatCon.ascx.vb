Public Class CUWCatCon
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents rbtipo1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtipo2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtipo3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents cbxPadre As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtctactb As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtdescta As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents cmbnatcta As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents btnnuevo As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents ibtnrevertir As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents ibtngrabar As System.Web.UI.HtmlControls.HtmlInputButton

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region
    Private cClsctb As New SIM.EL.ctbmcta
    Private clase As New SIM.bl.class1

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            CargarDatos()
        End If

    End Sub
    Private Sub CargarDatos()
        Dim clsCuentas As New SIM.BL.cCtbmcta
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListactbmcta As New listactbmcta

        mListactbmcta = clsCuentas.ObtenerLista2()

        Me.cbxPadre.DataTextField = "cdescrip"
        Me.cbxPadre.DataValueField = "ccodcta"
        Me.cbxPadre.DataSource = mListactbmcta
        Me.cbxPadre.DataBind()

        Dim mListaTabttab As New listatabttab
        mListaTabttab = clstabttab.ObtenerLista("192", "1")

        Me.cmbnatcta.DataTextField = "cdescri"
        Me.cmbnatcta.DataValueField = "ccodigo"
        Me.cmbnatcta.DataSource = mListaTabttab
        Me.cmbnatcta.DataBind()

        Initvar()
    End Sub
    Private Sub Initvar()
        Me.txtctactb.Enabled = False
        Me.txtdescta.Enabled = False

        Me.txtctactb.Text = ""
        Me.txtdescta.Text = ""
        Me.Label5.Visible = False
        Me.Label5.Text = ""

        Me.rbtipo1.Checked = True
        Me.Label4.Visible = False
        Me.cbxPadre.Visible = False

        Me.Label6.Visible = False
        Me.cmbnatcta.Visible = False

        Me.ibtnrevertir.Disabled = True
    End Sub
    
    

    Private Sub btnnuevo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.ServerClick
        Me.ibtnrevertir.Disabled = False
        If Me.rbtipo1.Checked = True Then
            Me.Label4.Visible = False
            Me.cbxPadre.Visible = False

            Me.Label6.Visible = True
            Me.cmbnatcta.Visible = True
        Else
            Me.Label4.Visible = True
            Me.cbxPadre.Visible = True

            Me.Label6.Visible = False
            Me.cmbnatcta.Visible = False

        End If
        Me.txtctactb.Enabled = True
        Me.txtdescta.Enabled = True
    End Sub

    Private Sub ibtnrevertir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ibtnrevertir.ServerClick
        Initvar()
    End Sub

    Private Sub ibtngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ibtngrabar.ServerClick
        If Me.txtctactb.Text.Trim = Nothing Or Me.txtdescta.Text.Trim = Nothing Then
            Me.Label5.Visible = True
            Me.Label5.Text = "Datos Vacíos, VERIFIQUE"
            Exit Sub
        End If

        Dim lverifica As Integer
        lverifica = clase.Verifica_Cuenta_Contable(Me.txtctactb.Text.Trim)
        If lverifica = 1 Then
            Me.Label5.Visible = True
            Me.Label5.Text = "Cuenta Contable ya Existe, VERIFIQUE"
            Exit Sub
        Else
            Me.Label5.Visible = False
            Me.Label5.Text = ""
        End If
        Dim lcnivel As String
        Dim lcNaturaleza As String


        Dim lretorno As Integer
        Dim lctipcta As String
        If Me.rbtipo1.Checked = True Then
            lctipcta = "P"
            lcNaturaleza = Me.cmbnatcta.SelectedItem.Value.Trim
        ElseIf Me.rbtipo2.Checked = True Then
            lctipcta = "M"
            lcNaturaleza = ""
        Else
            lctipcta = "D"
            lcNaturaleza = ""
        End If

        Dim entidadctbmcta As New SIM.El.ctbmcta
        Dim eCtbmcta As New SIM.BL.cCtbmcta

        entidadctbmcta.ccodcta = Me.txtctactb.Text.Trim
        entidadctbmcta.cdescrip = Me.txtdescta.Text.Trim
        entidadctbmcta.nsalini = 0
        entidadctbmcta.ndebeac = 0
        entidadctbmcta.nhaberac = 0
        entidadctbmcta.dfecmod = Today()
        entidadctbmcta.dfecreg = Today()
        entidadctbmcta.cflc = 0
        entidadctbmcta.nfln = 0
        entidadctbmcta.oin = " "
        entidadctbmcta.nfuefon = 0
        entidadctbmcta.nver = " "
        entidadctbmcta.cauxcta = 0
        entidadctbmcta.cfuente = " "
        entidadctbmcta.ctipmon = "1"
        entidadctbmcta.ccodto = lctipcta
        Dim lcCodcta1 As String
        lcCodcta1 = IIf(Me.cbxPadre.SelectedItem.Value.Trim = Nothing, " ", Me.cbxPadre.SelectedItem.Value.Trim)
        If Me.rbtipo1.Checked = True Then
            entidadctbmcta.cCtaSup = " "
        Else
            entidadctbmcta.cCtaSup = lcCodcta1
            'Verifica la naturaleza de cuenta padre
            If lctipcta <> "P" Then
                Dim lcNatSup As String
                Dim dsS As New DataSet
                Dim ncanti As Integer
                dsS = eCtbmcta.ObtenerDataSetPorCuenta(lcCodcta1.Trim)
                ncanti = dsS.Tables(0).Rows.Count()
                If ncanti = 0 Then  'En caso que no devuelva nada se sale
                    lcNaturaleza = ""
                Else
                    lcNaturaleza = dsS.Tables(0).Rows(0)("cgu")
                End If
            End If
        End If

        lcnivel = clase.fxStrZero(Me.txtctactb.Text.Trim.Length, 2).ToString
        entidadctbmcta.cgu = lcNaturaleza
        entidadctbmcta.ctipcta = ""
        entidadctbmcta.cnivel = lcnivel
        entidadctbmcta.cclase = ""
        entidadctbmcta.cmovida = ""
        entidadctbmcta.ccodusu = ""
        lretorno = eCtbmcta.Agregar(entidadctbmcta)

        Response.Write("<script language='javascript'>alert('Cuenta Contable Grabada')</script>")
        '        Initvar()
        CargarDatos()
    End Sub
End Class
