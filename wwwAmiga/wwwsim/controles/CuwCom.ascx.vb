Public Class CuwCom
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
        Me.txtccodcta.Text = codigoCliente.Trim
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = codigoCliente.Trim
        Dim ds As New DataSet
        ds = DataSetCheques(Me.txtccodcta.Text.Trim)
        Dim lnche As Integer = 0
        lnche = ds.Tables(0).Rows.Count
        Me.TextBox1.Text = lnche
        'ecreditos.Obtenercreditos(entidad3)
        'Me.txtcCodcli.Text = entidad3.ccodcli
        CargarDatos()
    End Sub
    Public Sub CargarDatos()
        '>>><
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela

        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim e As Double
        Dim deuda As Double
        Dim deuda1 As Double
        Dim dscancela As New DataSet
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim pcref1 As String
        Dim pcref As String
        dscancela = ecancela.ObtenerDataSetPorCuenta(Me.txtccodcta.Text.Trim)

        If dscancela.Tables(0).Rows.Count = 0 Then
            deuda = 0

        Else
            For Each fila In dscancela.Tables(0).Rows
                a = dscancela.Tables(0).Rows(nelem)("nsalcap")
                b = dscancela.Tables(0).Rows(nelem)("nsalint")
                c = dscancela.Tables(0).Rows(nelem)("nsalmor")
                d = dscancela.Tables(0).Rows(nelem)("nmanejo")
                e = dscancela.Tables(0).Rows(nelem)("nseguro")
                deuda1 = a + b + c + d + e
                deuda = deuda + deuda1
                nelem += 1
            Next
        End If
        Me.txtDeuda.Text = deuda
        '<<<<<<

        Me.txtcNomchq.Text = Session("gcNomChq")
        Me.Cargar_Gastos()
        'Verificar en Credchq
        Dim entidadCredchq As New cCredchq
        Dim lnverifica As Integer
        lnverifica = entidadCredchq.VerificarPorID(Me.txtccodcta.Text.Trim)
        If lnverifica = 0 Then
            clase.cNomChq = Me.txtcNomchq.Text
            clase.pcCodUsu = Session("gcCodUsu")
            clase.pcCodCre = Me.txtccodcta.Text.Trim
            clase.Actualizar_Credchq()
        End If
    End Sub
    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
        'Dim c As String
        'c = Session("CodigoCre")
        Cargar_Gastos()
    End Sub
    Private Sub Cargar_Gastos()
        Dim ecredgas As New cCredgas
        Dim ds As New DataSet
        ds = ecredgas.CargaListadoChkGastosCredito(txtccodcta.Text.Trim)
        If ds.Tables(0).Rows.Count = 0 Then
            Me.CargaGrid()
            Return
        End If
        Me.dgdetalle0.DataSource = ds.Tables(0)
        Me.dgdetalle0.DataBind()
        HabilitaEdiciondeCampos()
        'Me.dgGastos.Columns(4).Visible = False
        'Me.dgdetalle0.DataSource = ds.Tables(0)
        'Me.dgdetalle0.DataBind()
        ActualizaComision()

    End Sub
    Private Sub ActualizaComision()
        Dim mcreditos As New ccreditos
        Dim ecredgas As New cCredgas
        Dim lncomision As Double = 0
        Dim lnmonapr As Decimal = 0

        Dim ecremcre As New cCremcre
        Dim entidad1 As New cremcre
        entidad1.ccodcta = txtccodcta.Text.Trim
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
        ecredgas.EliminarporcuentaDes(txtccodcta.Text.Trim)
        ecredgas.EliminarporcuentaPropuestaDes(txtccodcta.Text.Trim, Session("gccodusu"))

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
            entidadcredgas.ccodcta = txtccodcta.Text.Trim
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
            entidadcredgas.cnrocuo = ekardex.obtenercnrodoc(txtccodcta.Text.Trim)
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
        'Me.Dgdetalle.DataSource = ds.Tables(0)
        'Me.Dgdetalle.DataBind()
        'Me.dgGastos.Columns(4).Visible = False
        'Me.dgGastos.Columns(3).Visible = False
    End Sub

    Private Sub Cargar_Gastosx()


        'Dim ecremcre As New cCremcre
        'Dim entidad1 As New cremcre
        'entidad1.ccodcta = txtccodcta.Text.Trim
        'ecremcre.ObtenerCremcre(entidad1)
        'Dim lccodlin As String
        'Dim lcnrolin As String
        'lcnrolin = entidad1.cnrolin

        'Dim entidadcretlin As New cretlin
        'Dim ecretlin As New cCretlin

        'entidadcretlin.cnrolin = lcnrolin
        'ecretlin.ObtenerCretlin(entidadcretlin)
        'lccodlin = entidadcretlin.ccodlin

        'Dim ecredgas As New cCredgas
        'Dim entidad3 As New credgas
        'Dim dt As New DataTable
        'Dim mcreditos As New ccreditos
        'dt = mcreditos.Comisiones(entidad1.nmonapr, lccodlin.Substring(8, 2), entidad1.lsegvid)
        'Dim lndes As Double = 0

        'ecredgas.Eliminarporcuenta(Me.txtccodcta.Text)

        'Dim fila As DataRow
        'For Each fila In dt.Rows
        '    lndes = lndes + fila("nmongas")
        '    'grabar los gastos
        '    entidad3.ccodcta = txtccodcta.Text.Trim
        '    entidad3.ccodusu = Session("gccodusu")
        '    entidad3.cdescob = "D"
        '    entidad3.cestado = ""
        '    entidad3.cflag = ""
        '    entidad3.cnrocuo = "001"
        '    entidad3.ctipgas = fila("ccodigo")
        '    entidad3.cusugen = Session("gccodusu")
        '    entidad3.dfecmod = Now
        '    entidad3.nmongas = fila("nmongas")
        '    entidad3.dfecgen = Session("gdfecsis")
        '    entidad3.dfecpag = Session("gdfecsis")


        '    ecredgas.Agregar(entidad3)


        'Next

        ''        dt = ecredgas.CargaComisiones(Me.txtccodcta.Text.Trim, "D")
        'Datagrid1.DataSource = dt
        'Datagrid1.DataBind()

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.txtcNomchq.Enabled = True
        Else
            Me.txtcNomchq.Enabled = False
        End If
    End Sub

    Private Sub txtcNomchq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcNomchq.TextChanged
        clase.cNomChq = Me.txtcNomchq.Text
        clase.pcCodUsu = Session("gcCodUsu")
        clase.pcCodCre = Me.txtccodcta.Text.Trim
        clase.Actualizar_Credchq()
    End Sub

  

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Verifica Que monto equivalen al total
        If Me.txtccodcta.Text.Trim = "" Then
            Exit Sub
        End If

        Dim ecredchq As New cCredchq
        Dim xy As Integer
        xy = 0
        Dim nmonto As TextBox
        Dim cnomchq As TextBox

        Dim lnmonto As Double = 0
        Dim lcnomchq As String = ""
        Dim lcnrodoc As String = ""
        Dim lntotal As Double = 0
        For xy = 0 To Me.Dgdetalle.Items.Count - 1
            nmonto = CType(Me.Dgdetalle.Items(xy).FindControl("Textbox2"), TextBox)
            lnmonto = Double.Parse(nmonto.Text)
            If lnmonto = 0 Then
                Response.Write("<script language='javascript'>alert('No pueden ir montos con cero')</script>")
                Exit Sub
            End If
            lntotal = lntotal + lnmonto
        Next
        Dim lnmonsug As Double = 0
        lnmonsug = Session("gnMonto")

        If Math.Round(lnmonsug, 2) <> Math.Round(lntotal, 2) Then
            Response.Write("<script language='javascript'>alert('Inconsistencia en Montos')</script>")
            Exit Sub
        End If


        xy = 0
        For xy = 0 To Me.Dgdetalle.Items.Count - 1
            nmonto = CType(Me.Dgdetalle.Items(xy).FindControl("Textbox2"), TextBox)
            cnomchq = CType(Me.Dgdetalle.Items(xy).FindControl("Textbox3"), TextBox)

            lnmonto = Double.Parse(nmonto.Text)
            lcnomchq = cnomchq.Text.ToString

            lcnrodoc = Me.Dgdetalle.Items(xy).Cells(0).Text
            'Actualiza cada registro
            ecredchq.ActualizaRegistro(Me.txtccodcta.Text.Trim, lcnrodoc, lcnomchq, lnmonto)
        Next

        ''Actualiza Gastos Notariales
        'clase.pcCodCre = Me.txtccodcta.Text.Trim
        'clase.cTipGas = "04"
        'clase.cNrocuo = "001"
        'clase.cDesCob = "D"
        'clase.nMonGas = Double.Parse(Me.txtCom2.Text)
        'clase.pcCodUsu = Session("gcCodUsu")
        'clase.dFecsis = Session("gdFecSis")
        'clase.Actualiza_Credgas_GastosNotariales()


        Response.Write("<script language='javascript'>alert('Información Grabada')</script>")

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Verifica si ya existen cheques
        If Me.txtccodcta.Text.Trim = "" Then
            Exit Sub
        End If
        Dim ecredchq As New cCredchq
        Dim clsppal As New class1
        Dim ds As New DataSet
        Dim lnactual As Integer = 0
        ds = DataSetCheques(Me.txtccodcta.Text.Trim)
        lnactual = ds.Tables(0).Rows.Count
        Dim lnche As Integer = Integer.Parse(Me.TextBox1.Text)
        Dim lndifer As Integer = 0

        If lnche >= lnactual Then
            'Agregamos registro
            lndifer = lnche - lnactual
            Dim c As Integer = 0
            Dim lcnrodoc As String
            Dim tamano As Integer = 0
            For c = 1 To lndifer
                lcnrodoc = clsppal.zeros((lnactual + c), 4)
                tamano = lcnrodoc.Trim.Length
                For i = 1 To 4 - tamano
                    lcnrodoc = "0" & lcnrodoc
                Next
                ecredchq.AgregaRegistro(Me.txtccodcta.Text.Trim, lcnrodoc, Session("gcNomChq"), 0)
            Next
        Else
            'Quitamos el ultimo para llevar el correlativo
            'Obtenemos el maximo
            Dim lcnrodoc As String = ""
            lcnrodoc = ecredchq.MaximoCheque(Me.txtccodcta.Text.Trim)
            ecredchq.QuitarUltimoCheque(Me.txtccodcta.Text.Trim, lcnrodoc)

        End If

        ds = DataSetCheques(Me.txtccodcta.Text.Trim)
        Response.Write("<script language='javascript'>alert('Se actualizaron Número de Cheques , Complete datos')</script>")

    End Sub

    Private Function DataSetCheques(ByVal cCodcta As String) As DataSet
        Dim ds As New DataSet
        Dim ecredchq As New cCredchq
        ds = ecredchq.ObtieneCheques(Me.txtccodcta.Text.Trim)
        Me.Dgdetalle.DataSource = ds
        Me.Dgdetalle.DataBind()
        Me.Dgdetalle.Columns(3).Visible = False

        Return ds
    End Function

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
End Class
