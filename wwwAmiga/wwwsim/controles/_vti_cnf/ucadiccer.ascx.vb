
Public Class ucadiccer
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtccodcrt As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcodcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtnomcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtcodaho As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents txtmonto As System.Web.UI.WebControls.TextBox
    Protected WithEvents txttasa As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtplazo As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents txtfecape As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtfecven As System.Web.UI.WebControls.TextBox
    Protected WithEvents chqpignorar As System.Web.UI.WebControls.CheckBox
    Protected WithEvents Label11 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents btngrabar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents btnaplicar As System.Web.UI.HtmlControls.HtmlInputButton
    Protected WithEvents RangeValidator5 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator6 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator3 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents RangeValidator2 As System.Web.UI.WebControls.RangeValidator
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub

    Public Sub CargarPorcertificado(ByVal ccodcrt As String)
        Me.txtccodcrt.Text = ccodcrt
        Me.btnaplicar_ServerClick(Me, New System.EventArgs)

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcodcli.Text = codigoCliente.Trim

        Dim mclientes As New cClimide
        Dim eclientes As New climide
        eclientes.ccodcli = Me.txtcodcli.Text.Trim
        mclientes.ObtenerClimide(eclientes)
        Me.txtnomcli.Text = eclientes.cnomcli

    End Sub

    Public Sub CargarPorcuentaahorro(ByVal cuentahorro As String)
        Me.txtcodaho.Text = cuentahorro.Trim
    End Sub

    Private Sub LinkButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub txtnomcli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomcli.TextChanged

    End Sub

    
    
    Private Sub btngrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.ServerClick
        Dim eahomcrt As New ahomcrt
        Dim mahomcrt As New cAhomcrt
        Dim lccodcrt As String
        Dim lnmonto As Double
        Dim lntasa As Double
        Dim lnplazo As Double
        Dim ldfecapr As Date
        Dim ldfecven As Date
        Dim ds As New DataSet

        lccodcrt = Me.txtccodcrt.Text.Trim
        lnmonto = Double.Parse(Me.txtmonto.Text.Trim)
        lntasa = Double.Parse(Me.txttasa.Text.Trim)
        lnplazo = Double.Parse(Me.txtplazo.Text.Trim)
        ldfecapr = Date.Parse(Me.txtfecape.Text.Trim)
        ldfecven = Date.Parse(Me.txtfecven.Text.Trim)


        If Me.txtccodcrt.Text.Trim <> "0000" Then
            If Me.txtccodcrt.Text.Trim <> Nothing Then

                'verifica que no exista numero de certificado
                eahomcrt.ccodcrt = lccodcrt
                ds = mahomcrt.ObtenerDataSetporcodcertificado(lccodcrt)
                If ds.Tables(0).Rows.Count <= 0 Then
                    'no existe se crearea
                    eahomcrt.ccodcrt = lccodcrt
                    eahomcrt.ccodaho = Me.txtcodaho.Text.Trim
                    eahomcrt.ccodcli = Me.txtcodcli.Text.Trim
                    eahomcrt.cestado = " "
                    eahomcrt.nmonapr = lnmonto
                    eahomcrt.ntasint = lntasa
                    eahomcrt.nplazo = lnplazo
                    eahomcrt.nombre = Me.txtnomcli.Text.Trim
                    eahomcrt.cliq = "N"
                    eahomcrt.cnrolin = "0000100"
                    eahomcrt.dfecapr = ldfecapr
                    eahomcrt.dfecven = ldfecven
                    eahomcrt.dmenpro = ldfecapr
                    eahomcrt.dultpro = ldfecapr
                    eahomcrt.dfecori = ldfecapr
                    eahomcrt.dfecmod = ldfecapr
                    eahomcrt.dfecprv = ldfecven
                    eahomcrt.nsaldoaho = lnmonto
                    eahomcrt.dfeccap = ldfecapr
                    eahomcrt.nmonto2 = 0 'se llena hasta que pasa por caja
                    eahomcrt.nintere = 0
                    eahomcrt.ndiagra = 0
                    eahomcrt.producto = "Q"
                    eahomcrt.producto2 = "Q"
                    eahomcrt.dfecliq = ldfecven
                    If Me.chqpignorar.Checked = True Then
                        eahomcrt.cpignor = "S"
                    Else
                        eahomcrt.cpignor = "N"
                    End If
                    mahomcrt.Agregar(eahomcrt)
                    Response.Write("<script language='javascript'>alert('ok')</script>")

                Else
                    Response.Write("<script language='javascript'>alert('Certificado ya existe')</script>")
                End If
            Else
                Response.Write("<script language='javascript'>alert('Ingrese Numero de certificado')</script>")
            End If
        Else
            Response.Write("<script language='javascript'>alert('Ingrese Numero de certificado')</script>")
        End If
    End Sub

    
    Private Sub btnaplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.ServerClick
        Dim ldfecha As Date
        ldfecha = Session("gdfecsis")

        Me.txtmonto.Text = 0
        Me.txttasa.Text = 7
        Me.txtplazo.Text = 30
        If Me.txtccodcrt.Text.Trim = "0000" Then
            Me.txtmonto.Text = 0
            Me.txttasa.Text = 0
            Me.txtcodcli.Text = ""
            Me.txtnomcli.Text = ""
            Me.txtfecape.Text = ldfecha.ToString
            Me.txtfecven.Text = ldfecha.ToString
        End If
    End Sub
End Class
