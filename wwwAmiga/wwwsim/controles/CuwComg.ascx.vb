Public Class CuwComg
    Inherits System.Web.UI.UserControl
    Dim clase As New SIM.BL.class1
    Private clasep As New SIM.bl.class1
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
    Public Event Cargar(ByVal codigoCliente As String)
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        HiddenField1.Value = codigoCliente.Trim
        Dim ds As New DataSet
        Dim ecreditos As New ccreditos
        ds = ecreditos.ListadoCreditosxGrupoenProceso(HiddenField1.Value.Trim)
        Me.ddlcartera.DataTextField = "cnomcli"
        Me.ddlcartera.DataValueField = "ccodcta"
        Me.ddlcartera.DataSource = ds.Tables(0)
        Me.ddlcartera.DataBind()
        ds.Tables(0).Clear()


        CargarDatos()
    End Sub
    Public Sub CargarDatos()

        Me.Cargar_Gastos()

    End Sub
    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
        'Dim c As String
        'c = Session("CodigoCre")
        Cargar_Gastos()
    End Sub

    Private Sub Cargar_Gastos()
        Dim ecredgas As New cCredgas
        Dim ds As New DataSet
        ds = ecredgas.CargaListadoChkGastosCredito(ddlcartera.SelectedValue.Trim)
        If ds.Tables(0).Rows.Count = 0 Then
            Me.CargaGrid()
            Return
        End If
        Me.dgdetalle0.DataSource = ds.Tables(0)
        Me.dgdetalle0.DataBind()
        HabilitaEdiciondeCampos()
        ActualizaComision()



        ''obtiene miembros del grupo
        ''--------------------------
        'Dim ecreditos As New ccreditos
        'Dim dsclientes As New DataSet
        'dsclientes = ecreditos.ClientesdeGrupoenProceso(HiddenField1.Value.Trim)

        'Dim ecredgas As New cCredgas
        'Dim ds As New DataSet
        'For Each fila As DataRow In dsclientes.Tables(0).Rows
        '    txtccodcta.Text = fila("ccodcta")
        '    ds = ecredgas.CargaListadoChkGastosCredito(txtccodcta.Text.Trim)
        '    If ds.Tables(0).Rows.Count = 0 Then
        '        Me.CargaGrid()
        '        Return
        '    End If
        '    Me.dgGastos.DataSource = ds.Tables(0)
        '    Me.dgGastos.DataBind()

        '    ActualizaComision()

        'Next




    End Sub

    Private Sub ActualizaComision()
        Dim mcreditos As New ccreditos
        Dim ecredgas As New cCredgas
        Dim lncomision As Double = 0
        Dim lnmonapr As Decimal = 0

        Dim ecremcre As New cCremcre
        Dim entidad1 As New cremcre
        entidad1.ccodcta = ddlcartera.SelectedValue.Trim
        ecremcre.ObtenerCremcre(entidad1)
        Dim lccodlin As String
        Dim lcnrolin As String
        lcnrolin = entidad1.cnrolin
        lnmonapr = entidad1.nmonapr

        Dim entidadcretlin As New cretlin
        Dim ecretlin As New cCretlin

        entidadcretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadcretlin)
        lccodlin = entidadcretlin.ccodlin

        '-------------------------------------------------------------------

        Dim entidadcredgas As New credgas
        ecredgas.EliminarporcuentaDes(ddlcartera.SelectedValue.Trim)
        ecredgas.EliminarporcuentaPropuestaDes(ddlcartera.SelectedValue.Trim, Session("gccodusu"))

        Dim chkCptoAsig As CheckBox
        Dim ekardex As New cCredkar
        Dim monto As TextBox
        Dim lopcion As Boolean
        Dim nElem As Integer = 0
        Dim lnmonto As Decimal = 0
        Dim lvalida As Boolean
        For xy = 0 To Me.dgdetalle0.Items.Count - 1
            chkCptoAsig = CType(Me.dgdetalle0.Items(xy).FindControl("CheckBox2"), CheckBox)

            monto = CType(Me.dgdetalle0.Items(xy).FindControl("TextBox6"), TextBox)
            lnmonto = Double.Parse(monto.Text)



            lopcion = chkCptoAsig.Checked
            'Pone bandera al gasto
            entidadcredgas.ccodcta = ddlcartera.SelectedValue.Trim
            entidadcredgas.ccodusu = Session("gccodusu")
            entidadcredgas.cdescob = "D"
            entidadcredgas.cestado = ""
            If lopcion = True Then
                entidadcredgas.cflag = "1"

                lvalida = ecredgas.AplicaEdiciondeCampo(Me.dgdetalle0.Items(xy).Cells(0).Text.Trim)
                If lvalida = True Then
                    lncomision = lnmonto
                Else
                    lncomision = Double.Parse(Me.dgdetalle0.Items(xy).Cells(4).Text)
                End If


                '         lncomision = Math.Round(lnmonto, 2)
                entidadcredgas.nmongas = lncomision
                'Me.dgdetalle0.Items(xy).Cells(3).Text = lncomision

            Else

                '   Me.dgdetalle0.Items(xy).Cells(3).Text = 0
                entidadcredgas.cflag = "0"
                entidadcredgas.nmongas = 0
            End If
            entidadcredgas.cnrocuo = ekardex.obtenercnrodoc(ddlcartera.SelectedValue.Trim)
            entidadcredgas.ctipgas = Me.dgdetalle0.Items(xy).Cells(0).Text
            entidadcredgas.cusugen = Session("gccodusu")
            entidadcredgas.dfecgen = Session("gdfecsis")
            entidadcredgas.dfecmod = Now
            entidadcredgas.dfecpag = Now
            entidadcredgas.nmonpag = 0
            entidadcredgas.ngasori = Double.Parse(Me.dgdetalle0.Items(xy).Cells(4).Text)

            ecredgas.Agregar(entidadcredgas)
            ecredgas.AgregarPropuesta(entidadcredgas)

            nElem = nElem + 1
        Next

    End Sub
    Private Sub CargaGrid()
        Dim etabttab As New cTabttab
        Dim ds As New DataSet
        ds = etabttab.CargaListadoChkGastos()
        Me.dgdetalle0.DataSource = ds.Tables(0)
        Me.dgdetalle0.DataBind()
        HabilitaEdiciondeCampos()
    End Sub



    Protected Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ActualizaComision()
    End Sub
    Private Sub HabilitaEdiciondeCampos()
        Dim monto As TextBox
        Dim lopcion As Boolean
        Dim nElem As Integer = 0
        Dim lnmonto As Decimal = 0
        Dim lctipgas As String
        Dim lvalida As Boolean
        Dim ecredgas As New cCredgas
        For xy = 0 To Me.dgdetalle0.Items.Count - 1
            lctipgas = Me.dgdetalle0.Items(xy).Cells(0).Text.Trim
            lvalida = ecredgas.AplicaEdiciondeCampo(lctipgas)

            monto = CType(Me.dgdetalle0.Items(xy).FindControl("TextBox6"), TextBox)
            If lvalida = True Then
                monto.Enabled = True
            Else
                monto.Enabled = False
            End If
            'lnmonto = Double.Parse(monto.Text)
            nElem = nElem + 1
        Next

    End Sub
    Protected Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ActualizaComision()
    End Sub

    Protected Sub ddlcartera_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlcartera.SelectedIndexChanged
        Cargar_Gastos()
    End Sub
End Class
