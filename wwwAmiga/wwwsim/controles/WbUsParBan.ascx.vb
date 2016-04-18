Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Public Class WbUsParBan
    Inherits System.Web.UI.UserControl
    Dim clsbancos As New SIM.BL.cTabtbco
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
    Private cClsAdP As New SIM.BL.ClsAdPart
    Private clsConvert As New SIM.BL.ConversionLetras
    Private vDetalle As New DataSet
    Private _nNumlin As Integer
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
#End Region

#Region " Propiedades "

    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property
    Public Property nNumlin() As Integer
        Get
            Return _nNumlin
        End Get
        Set(ByVal Value As Integer)
            _nNumlin = Value
        End Set
    End Property
#End Region

#Region " Metodos "

    Public Sub Habilita()
        Me.TxtDate.Enabled = True
        Me.cmbOficina.Enabled = True
        Me.cmbFondos.Enabled = True
        Me.cmbBancos.Enabled = True
        TxtNumdoc.Enabled = True
        Me.Txtccodcta.Enabled = True
        Me.TxtnDebe.Enabled = True
        Me.cmbFondos.Enabled = True
        Me.TxtnHaber.Enabled = True
        Me.btnProcesa.Disabled = False
        Me.TxtMonChq.Enabled = True
        Me.TxtGlosa.Enabled = True
        Me.TxtDate.Text = Session("gdfecsis")
        Me.Dgdetalle.Enabled = True
    End Sub

    Public Sub HabilitaMod()
        Me.TxtDate.Enabled = True
        Me.cmbOficina.Enabled = True
        Me.cmbFondos.Enabled = True
        Me.cmbBancos.Enabled = True
        '        Me.cmbCuentas.Enabled = True
        '        Me.TxtNoChq.Enabled = True
        '       Me.TxtNomUsu.Enabled = True
    End Sub

    Public Sub deshabilita()
        vDetalle.Tables.Clear()

        Me.Dgdetalle.DataSource = vDetalle.Tables("Partidas")
        Me.Dgdetalle.DataBind()

        Me.TxtDate.Enabled = False
        Me.cmbOficina.Enabled = False
        Me.cmbFondos.Enabled = False
        Me.cmbBancos.Enabled = False
        '        Me.cmbCuentas.Enabled = False
        '      Me.TxtNoChq.Enabled = False
        '     Me.TxtNomUsu.Enabled = False
        '    Me.TxtLetras.Enabled = False
        Me.Txtccodcta.Enabled = False
        Me.TxtnDebe.Enabled = False
        Me.TxtnHaber.Enabled = False
        cmbFondos.Enabled = False
        Me.btnProcesa.Disabled = True

        Me.TxtnDebe.Text = 0.0
        Me.TxtnHaber.Text = 0.0
        Me.TxtTotDebe.Text = 0.0
        Me.TxtTotHaber.Text = 0.0

        Me.TxtNumpar.Text = " "
        Me.TxtDate.Text = " "

        Me.CheckBox1.Checked = False
        Me.TxtGlosa.Text = ""
        Me.TxtComodin.Text = ""
        Me.TxtBandera.Text = ""
        Me.TxtMonChq.Text = ""
        TxtNumdoc.Text = ""
        '        Me.TxtNomUsu.Text = ""
        '       Me.TxtLetras.Text = ""
        '      Me.TxtNoChq.Text = ""
        Me.Dgdetalle.Enabled = False
    End Sub

    Public Sub Combos()

        'Fuente de Fondos
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        Dim lcfondos As String
        lcfondos = Session("gcfondo")

        mListaTabttab = clstabttab.ObtenerListaPorIDxcodigo("033", "1", lcfondos)

        Me.cmbFondos.DataTextField = "cdescri"
        Me.cmbFondos.DataValueField = "ccodigo"
        Me.cmbFondos.DataSource = mListaTabttab
        Me.cmbFondos.DataBind()


        'oficinas
        Dim clstabtofi As New SIM.BL.cTabtofi
        Dim mListaTabtofi As New listatabtofi

        mListaTabtofi = clstabtofi.ObtenerLista()

        Me.cmbOficina.DataTextField = "cnomofi"
        Me.cmbOficina.DataValueField = "ccodofi"
        Me.cmbOficina.DataSource = mListaTabtofi
        Me.cmbOficina.DataBind()

        'Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        Dim dsc As New DataSet


        'Informacion del Combo
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "*")

        'Me.cmbCuentas.DataTextField = "cCtacte"
        'Me.cmbCuentas.DataValueField = "cCtacte"
        'Me.cmbCuentas.DataSource = dsb.Tables(0)
        'Me.cmbCuentas.DataBind()

        Me.cmbBancos.DataTextField = "cnombco"
        Me.cmbBancos.DataValueField = "ccodbco"
        Me.cmbBancos.DataSource = dsb.Tables(0)
        Me.cmbBancos.DataBind()

        'Me.TxtNoChq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)

        Me.btnnew.Disabled = False

        Dim ectbmcta As New cCtbmcta
        Dim dscatalago As New DataSet
        dscatalago = ectbmcta.CatalagoCombo()
        Me.cmbCatalago.DataTextField = "cDescri"
        Me.cmbCatalago.DataValueField = "ccodcta"
        Me.cmbCatalago.DataSource = dscatalago.Tables(0)
        Me.cmbCatalago.DataBind()

        Me.Dgdetalle.Columns(6).Visible = False
        Me.Dgdetalle.Columns(7).Visible = False

        Me.btnedit.Disabled = True
        Me.btncancel.Disabled = True

        TxtMonChq.Text = 0
    End Sub

    Public Sub CargarNoPartida(ByVal codigoPartida As String)
        Dim Fila As DataRow
        Dim ds As New DataSet
        Dim x As Integer
        Dim dr As DataRow
        Dim i As Integer
        Dim lcbanco As String
        Dim lcctacte As String

        Dim clssconta As New clsConta
        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig.Trim, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        Me.TxtNumpar.Text = codigoPartida
        vDetalle = cClsAdP.BuscaPartidaDesChq(Me.TxtNumpar.Text.Trim)
        If vDetalle.Tables(0).Rows.Count = 0 Then
            Me.TxtDate.Text = Today()
            Me.TxtGlosa.Text = ""
            '   Me.TxtNomUsu.Text = ""
            Me.TxtMonChq.Text = ""
            '  Me.TxtLetras.Text = ""
            ' Me.TxtNoChq.Text = ""
            lcbanco = ""
            lcctacte = ""
        Else
            Me.TxtDate.Text = vDetalle.Tables(0).Rows(0)("dfeccnt")
            Me.TxtGlosa.Text = vDetalle.Tables(0).Rows(0)("cGlosa")
            'Me.cmbFondos.SelectedValue = vDetalle.Tables(0).Rows(0)("ffondos")
            'Me.cmbOficina.SelectedValue = vDetalle.Tables(0).Rows(0)("ccodofi")

            'Me.TxtNomUsu.Text = vDetalle.Tables(0).Rows(0)("cnomChq")
            Me.TxtMonChq.Text = vDetalle.Tables(0).Rows(0)("cmonchq")

            lcbanco = vDetalle.Tables(0).Rows(0)("ccodbco")
            lcbanco = lcbanco.Trim

            Me.cmbBancos.SelectedValue = lcbanco

            'lcctacte = vDetalle.Tables(0).Rows(0)("cctacte")
            'lcctacte = lcctacte.Trim
            'Me.cmbCuentas.SelectedValue = lcctacte

            'Me.TxtLetras.Text = IIf(IsDBNull(vDetalle.Tables(0).Rows(0)("cmonlet")), " ", vDetalle.Tables(0).Rows(0)("cmonlet"))
            'Me.TxtNoChq.Text = vDetalle.Tables(0).Rows(0)("cnrochq")

        End If

   



        vDetalle.Tables(0).Clear()

        'Aqui va el detalle de la Partida 
        vDetalle = cClsAdP.BuscaPartidaDet(Me.TxtNumpar.Text.Trim, Session("gcfondo"), lccadena)

        Me.Dgdetalle.DataSource = vDetalle.Tables(0)
        Me.Dgdetalle.DataBind()

        Me.Dgdetalle.Enabled = False

        'Me.btnedit.Disabled = False


        '----------------------------------------------
        'Sumando el Debe y el Haber para totalizar
        '----------------------------------------------

        i = 0
        Me.TxtTotDebe.Text = 0
        Me.TxtTotHaber.Text = 0

        For Each dr In vDetalle.Tables(0).Rows
            Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + vDetalle.Tables(0).Rows(i)("ndebe")
            Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + vDetalle.Tables(0).Rows(i)("nhaber")
            i += 1
        Next

        vDetalle.Tables(0).Clear()
        Me.btnsave.Disabled = True
        Me.btnprint.Disabled = False
        'Me.btncancel.Disabled = False


        'Verifica si es cheque a cliente o cheque a proveedor

        Dim lverchq As Boolean
        Dim ecntamov As New cCntamov
        lverchq = ecntamov.VerificaChequeProveedor(codigoPartida)

        btnrevertir.Enabled = lverchq
        '----------------------------------------------------
    End Sub

    Public Sub CargarPartida()
        Dim dr As DataRow
        Dim i As Integer


        vDetalle = viewstate("Dataset")

        i = vDetalle.Tables("Partidas").Rows.Count()

        i += 1


        dr = vDetalle.Tables("Partidas").NewRow


        dr("IdCuenta") = i

        dr("cCodcta") = Me.Txtccodcta.Text.Trim
        dr("cdescri") = Me.Txtcdescri.Text.Trim

        If Me.TxtnDebe.Text.Trim = "" Or Me.TxtnDebe.Text.Trim = Nothing Then
            dr("nDebe") = 0.0
        Else
            dr("nDebe") = Double.Parse(Me.TxtnDebe.Text.Trim)
        End If

        If Me.TxtnHaber.Text.Trim = "" Or Me.TxtnHaber.Text.Trim = Nothing Then
            dr("nHaber") = 0.0
        Else
            dr("nHaber") = Double.Parse(Me.TxtnHaber.Text.Trim)
        End If

        dr("cConcepto") = Me.Txtcconcepto.Text.Trim
        dr("ffondos") = Me.cmbFondos.SelectedValue.Trim
        vDetalle.Tables("Partidas").Rows.Add(dr)



        Me.Dgdetalle.DataSource = vDetalle.Tables("Partidas")

        Me.Dgdetalle.DataBind()
        '----------------------------------------------
        'Sumando el Debe y el Haber para totalizar
        '----------------------------------------------

        i = 0
        Me.TxtTotDebe.Text = 0
        Me.TxtTotHaber.Text = 0
        Me.Txtdiferencia.Text = 0
        For Each dr In vDetalle.Tables("Partidas").Rows
            Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + vDetalle.Tables(0).Rows(i)("ndebe")
            Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + vDetalle.Tables(0).Rows(i)("nhaber")
            i += 1
        Next
        Me.Txtdiferencia.Text = Double.Parse(Me.TxtTotDebe.Text) - Double.Parse(Me.TxtTotHaber.Text)

    End Sub

    Public Sub CargarCuenta(ByVal codigoCliente As String)
        'Dim gdfecsis As Date

        'Me.Txtccodcta.Text = codigoCliente

        'gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar
        Dim gdfecsis As Date

        Me.Txtccodcta.Text = codigoCliente
        Dim ectbmcta As New cCtbmcta
        Dim ds As New DataSet
        ds = ectbmcta.ObtenerDescripcionPorCuenta(codigoCliente.Trim, Session("gcfondo"))
        If ds.Tables(0).Rows.Count = 0 Then
            Me.Txtcdescri.Text = ""
        Else
            Me.Txtcdescri.Text = ds.Tables(0).Rows(0)("cdescrip")

        End If
        gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar


    End Sub

    Public Sub Imprime()
        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\RptPartida.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim nCanti As Integer

        Dim clssconta As New clsConta
        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig.Trim, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        'Crear aqui el dataset

        dsDes = cClsAdP.ReportePartida(Me.TxtNumpar.Text.Trim, Session("gcfondo"), lccadena)

        nCanti = dsDes.Tables(0).Rows.Count

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        'Response.Clear()
        'Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim reportes As String
        reportes = "RptPartida.pdf"

        Dim lcfondos As String = ""
        Dim lcusuario As String = ""
        Dim etabttab As New cTabttab
        Dim etabtusu As New cTabtusu
        If dsDes.Tables(0).Rows.Count = 0 Then
            lcfondos = ""
        Else
            If IsDBNull(dsDes.Tables(0).Rows(0)("ffondos")) Then

            Else
                lcfondos = etabttab.Describe(Trim(dsDes.Tables(0).Rows(0)("ffondos")), "033")
                lcusuario = etabtusu.usuario(Trim(dsDes.Tables(0).Rows(0)("ccodusu")))
            End If

        End If

        Dim lcpoliza As String
        lcpoliza = Me.cmbtippar.SelectedItem.Text

        crRpt.SetParameterValue("cfondos", lcfondos.Trim)
        crRpt.SetParameterValue("cpoliza", lcpoliza.Trim)
        crRpt.SetParameterValue("usuario", lcusuario.Trim)

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Combos()
        End If
    End Sub

    
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.TxtGlosa.Enabled = True
        Else
            Me.TxtGlosa.Enabled = False
        End If
    End Sub



  

  

    Private Sub Dgdetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgdetalle.SelectedIndexChanged
        'ClienteSeleccionado = CType(Me.Dgdetalle.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        'Dim x As Integer
        'Dim Fila As DataRow
        'Dim Linea As Integer

        'Linea = ClienteSeleccionado
        'vDetalle = viewstate("Dataset")
        'x = 0

        'Me.nNumlin = Linea
        'Me.TxtComodin.Text = Linea

        'For Each Fila In vDetalle.Tables("Partidas").Rows
        '    If Linea = Trim(vDetalle.Tables(0).Rows(x)("IdCuenta")) Then
        '        Me.Txtccodcta.Text = vDetalle.Tables(0).Rows(x)("cCodcta")
        '        Me.TxtnDebe.Text = vDetalle.Tables(0).Rows(x)("nDebe")
        '        Me.TxtnHaber.Text = vDetalle.Tables(0).Rows(x)("nHaber")
        '        Exit For
        '    End If
        '    x += 1
        'Next
        ClienteSeleccionado = CType(Me.Dgdetalle.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        Dim x As Integer
        Dim Fila As DataRow
        Dim Linea As Integer

        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig.Trim, 4)

        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))


        Linea = ClienteSeleccionado

        'Dim dspartida As New DataSet
        'dspartida = cClsAdP.BuscaPartidaDet(Me.TxtNumpar.Text.Trim, Session("gcfondo"), lccadena)

        x = 0

        Me.nNumlin = Linea
        Me.TxtComodin.Text = Linea


        For x = 0 To Me.Dgdetalle.Items.Count - 1
            If Linea = Me.Dgdetalle.Items(x).Cells(7).Text Then
                Me.Txtccodcta.Text = Me.Dgdetalle.Items(x).Cells(2).Text
                Me.TxtnDebe.Text = Me.Dgdetalle.Items(x).Cells(4).Text.Replace("Q", "").Replace(",", "")
                Me.TxtnHaber.Text = Me.Dgdetalle.Items(x).Cells(5).Text.Replace("Q", "").Replace(",", "")

                Me.Txtcconcepto.Text = Me.Dgdetalle.Items(x).Cells(6).Text.Replace("&nbsp;", "")

                Me.cmbCatalago.SelectedValue = Me.Txtccodcta.Text.Trim
            End If

        Next



        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<
    End Sub

    Private Sub btnProcesa_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesa.ServerClick
        'Dim lnvalida As Integer
        'lnvalida = Me.validador
        'If lnvalida = 0 Then
        '    Me.Label2.Text = "Cuenta No Existe"
        '    Exit Sub
        'Else
        '    Me.Label2.Text = " "
        'End If
        ''Valida que no vallan datos en el debe y el Haber
        'If Not (Me.TxtnDebe.Text.Trim = " " Or Me.TxtnDebe.Text.Trim = Nothing Or Me.TxtnDebe.Text.Trim = "0") Then
        '    If Not (Me.TxtnHaber.Text.Trim = " " Or Me.TxtnHaber.Text.Trim = Nothing Or Me.TxtnHaber.Text.Trim = "0") Then
        '        Response.Write("<script language='javascript'>alert('Imposible procesar')</script>")
        '        Exit Sub
        '    End If
        'End If

        ''valida que no valla vacia la cuenta
        'If Me.Txtccodcta.Text.Trim = " " Or Me.Txtccodcta.Text.Trim = Nothing Then
        '    Response.Write("<script language='javascript'>alert('Imposible procesar, No hay cuenta')</script>")
        '    Exit Sub
        'End If

        ''Valida que no valla solo uno vacion en el Debe o Haber
        'If (Me.TxtnDebe.Text.Trim = " " Or Me.TxtnDebe.Text.Trim = Nothing) And Me.TxtnDebe.Text.Trim <> "0" Then
        '    If (Me.TxtnHaber.Text.Trim = " " Or Me.TxtnHaber.Text.Trim = Nothing) And Me.TxtnHaber.Text.Trim <> "0" Then
        '        Response.Write("<script language='javascript'>alert('Imposible procesar, No hay datos')</script>")
        '        Exit Sub
        '    End If
        'End If

        ''----------------------------------------------------------    
        ''Valida si es modificacion o Nueva Linea
        ''----------------------------------------------------------

        'If Not (Me.TxtComodin.Text = "" Or Me.TxtComodin.Text = Nothing) Then

        '    vDetalle = viewstate("Dataset")

        '    'Remueve en el indice espesificado
        '    vDetalle.Tables("Partidas").Rows.RemoveAt(Integer.Parse(Me.TxtComodin.Text) - 1)

        '    'Esta linea inserta en la posicion indicada
        '    Dim dr As DataRow

        '    dr = vDetalle.Tables("Partidas").NewRow


        '    dr("IdCuenta") = Integer.Parse(Me.TxtComodin.Text)

        '    dr("cCodcta") = Me.Txtccodcta.Text.Trim

        '    If Me.TxtnDebe.Text.Trim = "" Or Me.TxtnDebe.Text.Trim = Nothing Then
        '        dr("nDebe") = 0.0
        '    Else
        '        dr("nDebe") = Double.Parse(Me.TxtnDebe.Text.Trim)
        '    End If

        '    If Me.TxtnHaber.Text.Trim = "" Or Me.TxtnHaber.Text.Trim = Nothing Then
        '        dr("nHaber") = 0.0
        '    Else
        '        dr("nHaber") = Double.Parse(Me.TxtnHaber.Text.Trim)
        '    End If

        '    vDetalle.Tables("Partidas").Rows.InsertAt(dr, (Integer.Parse(Me.TxtComodin.Text) - 1))

        '    Me.Dgdetalle.DataSource = vDetalle.Tables("Partidas")

        '    Me.Dgdetalle.DataBind()

        '    '----------------------------------------------
        '    'Sumando el Debe y el Haber para totalizar
        '    '----------------------------------------------

        '    Dim i As Integer = 0
        '    Me.TxtTotDebe.Text = 0
        '    Me.TxtTotHaber.Text = 0

        '    For Each dr In vDetalle.Tables("Partidas").Rows
        '        Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + vDetalle.Tables(0).Rows(i)("ndebe")
        '        Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + vDetalle.Tables(0).Rows(i)("nhaber")
        '        i += 1
        '    Next

        'Else
        '    'Cargar detalle de la partida
        '    Me.CargarPartida()
        'End If



        'Me.Txtccodcta.Text = ""
        'Me.TxtnDebe.Text = 0.0
        'Me.TxtnHaber.Text = 0.0
        '>>>>>>>>>>>>>>>>>>>
        'Valida que no vallan datos en el debe y el Haber
        Dim lnvalida As Integer
        lnvalida = Me.validador
        If lnvalida = 0 Then
            Me.Label2.Text = "Cuenta No Existe"
            Exit Sub
        Else
            Me.Label2.Text = " "
        End If

        If Double.Parse(Me.TxtnDebe.Text) <= 0 And Double.Parse(Me.TxtnHaber.Text) <= 0 Then
            Response.Write("<script language='javascript'>alert('Imposible procesar')</script>")
            Exit Sub
        End If

        If Not (Me.TxtnDebe.Text.Trim = " " Or Me.TxtnDebe.Text.Trim = Nothing Or Me.TxtnDebe.Text.Trim = "0" Or Me.TxtnDebe.Text.Trim = "0.00") Then
            If Not (Me.TxtnHaber.Text.Trim = " " Or Me.TxtnHaber.Text.Trim = Nothing Or Me.TxtnHaber.Text.Trim = "0" Or Me.TxtnHaber.Text.Trim = "0.00") Then
                Response.Write("<script language='javascript'>alert('Imposible procesar')</script>")
                Exit Sub
            End If
        End If

        'valida que no valla vacia la cuenta
        If Me.Txtccodcta.Text.Trim = " " Or Me.Txtccodcta.Text.Trim = Nothing Then
            Response.Write("<script language='javascript'>alert('Imposible procesar, No hay cuenta')</script>")
            Exit Sub
        End If

        'Valida que no valla solo uno vacion en el Debe o Haber
        If (Me.TxtnDebe.Text.Trim = " " Or Me.TxtnDebe.Text.Trim = Nothing) And Me.TxtnDebe.Text.Trim <> "0" And Me.TxtnDebe.Text.Trim <> "0.00" Then
            If (Me.TxtnHaber.Text.Trim = " " Or Me.TxtnHaber.Text.Trim = Nothing) And Me.TxtnHaber.Text.Trim <> "0" And Me.TxtnHaber.Text.Trim <> "0.00" Then
                Response.Write("<script language='javascript'>alert('Imposible procesar, No hay datos')</script>")
                Exit Sub
            End If
        End If

        '----------------------------------------------------------    
        'Valida si es modificacion o Nueva Linea
        '----------------------------------------------------------

        If Not (Me.TxtComodin.Text = "" Or Me.TxtComodin.Text = Nothing) Then
            Dim xy As Integer
            xy = 0
            Me.TxtTotDebe.Text = 0
            Me.TxtTotHaber.Text = 0
            Dim y As Integer = 0
            For xy = 0 To Me.Dgdetalle.Items.Count - 1
                y += 1
                If (Integer.Parse(Me.TxtComodin.Text) - 1) = xy Then
                    'Modifica fila
                    Me.Dgdetalle.Items(xy).Cells(2).Text = Me.Txtccodcta.Text
                    Me.CargarCuenta(Me.Txtccodcta.Text.Trim)
                    Me.Dgdetalle.Items(xy).Cells(3).Text = Me.Txtcdescri.Text
                    Me.Dgdetalle.Items(xy).Cells(4).Text = Me.TxtnDebe.Text
                    Me.Dgdetalle.Items(xy).Cells(5).Text = Me.TxtnHaber.Text
                    Me.Dgdetalle.Items(xy).Cells(6).Text = Me.Txtcconcepto.Text
                    Me.Dgdetalle.Items(xy).Cells(8).Text = Me.cmbFondos.SelectedValue.Trim
                End If
                Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + Me.Dgdetalle.Items(xy).Cells(4).Text.Replace("Q", "")
                Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + Me.Dgdetalle.Items(xy).Cells(5).Text.Replace("Q", "")

            Next
            Me.Txtdiferencia.Text = Double.Parse(Me.TxtTotDebe.Text) - Double.Parse(Me.TxtTotHaber.Text)
            Me.TxtComodin.Text = ""

            'Crea nuevo Dataset

            vDetalle = cClsAdP.CargaPartida()
            ViewState.Add("Dataset", vDetalle)
            xy = 0
            Dim dr As DataRow
            Dim i As Integer


            vDetalle = ViewState("Dataset")

            i = 0



            For xy = 0 To Me.Dgdetalle.Items.Count - 1
                i += 1
                dr = vDetalle.Tables("Partidas").NewRow


                dr("IdCuenta") = i

                dr("cCodcta") = Me.Dgdetalle.Items(xy).Cells(2).Text
                dr("cdescri") = Me.Dgdetalle.Items(xy).Cells(3).Text
                dr("nDebe") = Me.Dgdetalle.Items(xy).Cells(4).Text.Replace("Q", "")
                dr("nHaber") = Me.Dgdetalle.Items(xy).Cells(5).Text.Replace("Q", "")
                dr("cConcepto") = Me.Dgdetalle.Items(xy).Cells(6).Text
                dr("ffondos") = Me.Dgdetalle.Items(xy).Cells(8).Text
                vDetalle.Tables("Partidas").Rows.Add(dr)

            Next
            Me.Dgdetalle.DataSource = vDetalle.Tables("Partidas")

            Me.Dgdetalle.DataBind()

            '----------------------------------------------
            'Sumando el Debe y el Haber para totalizar
            '----------------------------------------------

            i = 0
            Me.TxtTotDebe.Text = 0
            Me.TxtTotHaber.Text = 0
            Me.Txtdiferencia.Text = 0
            For Each dr In vDetalle.Tables("Partidas").Rows
                Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + vDetalle.Tables(0).Rows(i)("ndebe")
                Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + vDetalle.Tables(0).Rows(i)("nhaber")
                i += 1
            Next
            Me.Txtdiferencia.Text = Double.Parse(Me.TxtTotDebe.Text) - Double.Parse(Me.TxtTotHaber.Text)


        Else
            'Cargar detalle de la partida
            Me.CargarPartida()
        End If



        Me.Txtccodcta.Text = ""
        Me.TxtnDebe.Text = 0.0
        Me.TxtnHaber.Text = 0.0
        Me.Txtcconcepto.Text = ""
        Me.Txtcdescri.Text = ""
    End Sub

    Private Sub btnnew_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.ServerClick
        Me.Dgdetalle.DataBind()
        vDetalle = cClsAdP.CargaPartida()
        viewstate.Add("Dataset", vDetalle)
        Me.btnnew.Disabled = True
        Me.TxtNumpar.Text = "99999999"
        Me.TxtnDebe.Text = 0.0
        Me.TxtnHaber.Text = 0.0
        Me.TxtTotDebe.Text = 0.0
        Me.TxtTotHaber.Text = 0.0
        TxtMonChq.Text = 0.0
        Me.Habilita()
        Me.btnsave.Disabled = False
        'Me.btncancel.Disabled = False
        Me.Dgdetalle.Enabled = True
        'Me.btnedit.Disabled = True
        Me.TxtBandera.Text = 1
        cargabancos()
    End Sub

    Private Sub btnsave_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.ServerClick
        Dim clsppal As New class1
        'If clsppal.valida_mes(Date.Parse(TxtDate.Text), Session("gdfecsis")) = False Then
        '    Me.btnsave.Disabled = False
        '    Response.Write("<script language='javascript'>alert('Mes Ya Cerrado o Fecha Adelantada al Mes Actual')</script>")
        '    Exit Sub
        'End If

        Dim Fila As DataRow
        Dim x As Integer
        Dim ok As Integer
        Dim oki As String

        'Valida que el lleve nombre el cheque y que el concepto no este vacio
        If Me.TxtGlosa.Text.Trim = "" Or Me.TxtGlosa.Text.Trim = Nothing Then
            Response.Write("<script language='javascript'>alert('Se dejan espacios vacios, Revise')</script>")
            Exit Sub
        End If

        'Valida que el monto y el numero de cheque no este vacio
        If Me.TxtMonChq.Text.Trim = Nothing Or _
                Me.TxtMonChq.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Se dejan espacios vacios, Revise')</script>")
            Exit Sub
        End If

        'Valida que el Monto del Cheque sea igual al Detalle
        'If Double.Parse(Me.TxtMonChq.Text.Trim) <> Double.Parse(Me.TxtTotDebe.Text.Trim) Then
        'Response.Write("<script language='javascript'>alert('El monto no cuadra con el Detalle, Revise')</script>")
        'Exit Sub
        'End If
        Dim etabtbco As New cTabtbco
        Dim lcctacte As String
        lcctacte = etabtbco.CuentadeBanco1(Me.cmbBancos.SelectedValue.Trim)


        'Grabara la partida del Cheque
        cClsAdP._dfecmod = Session("gdfecsis")
        cClsAdP._ccodusu = Session("gcCodusu")
        cClsAdP._ccodofi = Me.cmbOficina.SelectedValue.Trim
        cClsAdP._ffondos = Me.cmbFondos.SelectedValue.Trim
        cClsAdP._cconcepto = Me.TxtGlosa.Text.Trim
        cClsAdP._dfeccnt = Date.Parse(Me.TxtDate.Text.Trim)
        cClsAdP._cpoliza = cmbtippar.SelectedValue.Trim
        cClsAdP._nCuenta = 1
        cClsAdP._cnumdoc = Me.TxtNumdoc.Text.Trim
        cClsAdP._cnomchq = "" 'Me.TxtNomUsu.Text.Trim
        cClsAdP._cmonletras = "" 'Me.TxtLetras.Text.Trim
        cClsAdP._cBanco = Me.cmbBancos.SelectedValue.Trim
        cClsAdP._cCuenta = lcctacte.Trim 'Me.cmbCuentas.SelectedValue.Trim
        cClsAdP._nMonchq = Double.Parse(Me.TxtMonChq.Text.Trim)
        cClsAdP._ccodpres = ""

        If Me.TxtBandera.Text.Trim = "0" Then   'Modifica
            cClsAdP._cnumcom = Me.TxtNumpar.Text.Trim
            cClsAdP._llbandera = False

            'ok = cClsAdP.ModChqs()
            oki = cClsAdP.AdPartidaDetalle()

            If ok = 0 Then 'Ocurrio un Error
                Exit Sub
            End If

        Else         'Agrega


            '------------------------------------------
            'Valida que el Debe y el Haber cuadre
            '------------------------------------------
            If Double.Parse(Me.TxtTotDebe.Text) <> Double.Parse(Me.TxtTotHaber.Text) Then
                Response.Write("<script language='javascript'>alert('Debe y Haber no cuadra')</script>")
                Exit Sub
            End If

            If Double.Parse(Me.TxtTotDebe.Text) = 0 And Double.Parse(Me.TxtTotHaber.Text) = 0 Then
                Response.Write("<script language='javascript'>alert('Imposible Procesar')</script>")
                Exit Sub
            End If


            vDetalle = viewstate("Dataset")
            x = vDetalle.Tables("Partidas").Rows.Count()
            x = 0

            cClsAdP._llbandera = True



            For Each Fila In vDetalle.Tables("Partidas").Rows
                cClsAdP._cnumlin = vDetalle.Tables(0).Rows(x)("IdCuenta")
                cClsAdP._ccodcta = vDetalle.Tables(0).Rows(x)("cCodcta")
                cClsAdP._ndebe = vDetalle.Tables(0).Rows(x)("nDebe")
                cClsAdP._nhaber = vDetalle.Tables(0).Rows(x)("nHaber")
                cClsAdP._cclase = Mid(vDetalle.Tables(0).Rows(x)("cCodcta"), 1, 1)
                cClsAdP._ffondos = Me.cmbFondos.SelectedValue.Trim 'vDetalle.Tables(0).Rows(x)("ffondos")

                'oki = cClsAdP.AdChqs()
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    Exit Sub
                End If

                x += 1
                cClsAdP._nCuenta += 1

            Next
        End If
        'clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.TxtNoChq.Text.Trim)

        Me.deshabilita()
        Me.btnsave.Disabled = True
        Me.btnnew.Disabled = False
        'Me.btncancel.Disabled = True
        Me.CargarNoPartida(oki)
        'Me.Imprime()
    End Sub

    Private Sub btncancel_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.ServerClick
        Me.deshabilita()
        Me.btnsave.Disabled = True
        Me.btnnew.Disabled = False
        'Me.btncancel.Disabled = True
    End Sub

    Private Sub btnedit_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.ServerClick
        Me.HabilitaMod()
        Me.Dgdetalle.Enabled = False
        'Me.btnedit.Disabled = True
        Me.btnsave.Disabled = False
        Me.btnnew.Disabled = False
        Me.btnnew.Disabled = True
        Me.TxtBandera.Text = "0"
    End Sub

    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick
        Try
            Me.Imprime()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Txtccodcta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtccodcta.TextChanged
        Me.CargarCuenta(Me.Txtccodcta.Text.Trim)
    End Sub
    Private Function validador()
        Dim ectbmcta As New cCtbmcta
        Dim lnvalida As Integer
        lnvalida = ectbmcta.ValidarCuenta(Me.Txtccodcta.Text.Trim)
        Return lnvalida
    End Function
    Private Function valida() As Boolean
        Dim clsvalida As New clsversion1
        Dim lnvalida As Integer
        clsvalida.dFecpar = Date.Parse(Me.TxtDate.Text)
        lnvalida = clsvalida.validaMes(Session("gcfondo"))
        If lnvalida = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TxtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDate.TextChanged
        'Dim llvalida As Boolean
        'llvalida = Me.valida()
        'If llvalida = False Then
        '    Me.btnsave.Disabled = True
        '    Response.Write("<script language='javascript'>alert('Fecha Invalida, Periodo Cerrado')</script>")
        'Else
        '    Me.btnsave.Disabled = False
        'End If
        Dim llvalida As Boolean
        llvalida = Me.valida()
        If llvalida = False Then
            Me.btnsave.Disabled = True
            Response.Write("<script language='javascript'>alert('Fecha Invalida, Periodo Cerrado')</script>")
        Else
            'verifica mes cerrado
            Dim clasconta As New clsConta
            Dim lvalida As Boolean
            lvalida = clasconta.ValidaMesCierre(Date.Parse(TxtDate.Text))
            If lvalida = False Then
                Me.btnsave.Disabled = True
                Response.Write("<script language='javascript'>alert('Fecha Invalida, Periodo Cerrado')</script>")
            Else
                Me.btnsave.Disabled = False
            End If

        End If
    End Sub
    Private Sub cargabancos()

        Me.Txtccodcta.Text = clsbancos.CuentadeBancoContable(cmbBancos.SelectedValue)
        If cmbtippar.SelectedValue.Trim = "ND" Then
            TxtnHaber.Text = TxtMonChq.Text
            TxtnDebe.Text = 0
        Else
            TxtnDebe.Text = TxtMonChq.Text
            TxtnHaber.Text = 0
        End If


        Me.CargarCuenta(Me.Txtccodcta.Text.Trim)
    End Sub
    Protected Sub cmbBancos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedIndexChanged
        cargabancos()
    End Sub

    Protected Sub btnrevertir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnrevertir.Click
        Dim lcnumpar As String = Me.TxtNumpar.Text.Trim
        Dim lcfondo As String = Me.cmbFondos.SelectedValue
        Dim lccadena As String = ""


        'Verifica si cheque no ha sido anulado
        Dim ediario As New cDiario
        Dim lverifica As Boolean
        lverifica = ediario.VerificasiprocedeAnulacion(lcnumpar)
        If lverifica = False Then
            Response.Write("<script language='javascript'>alert('Partida ya fue Anulada/Reversion de otra partida ')</script>")
            Exit Sub
        End If


        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim oki As String = "0"

        Dim ecntamov As New cCntamov
        Dim ectbdchq As New cCtbdchq
        'Anular en ctbdchq

        ediario.BanderaAnulada(lcnumpar)
        ectbdchq.AnulaAuxiliar(lcnumpar)
        ectbdchq.AnulaCheque(lcnumpar)

        'Agrega Contra Partida
        ds1 = ediario.ObtenerCabezaPartida(lcnumpar)
        ds2 = ecntamov.ObtenerCuerpoPartida(lcnumpar)

        Dim fila1 As DataRow
        Dim fila2 As DataRow

        If ds1.Tables(0).Rows.Count <> 0 And ds2.Tables(0).Rows.Count <> 0 Then 'Existen movimientos
            'Grabara la partida

            For Each fila1 In ds1.Tables(0).Rows

                cClsAdP._dfecmod = Session("gdfecsis")
                cClsAdP._ccodusu = Session("gcCodusu")
                cClsAdP._ccodofi = fila1("ccodofi")
                cClsAdP._ffondos = fila1("ffondos")
                cClsAdP._cconcepto = "PARTIDA ANULACION -" & fila1("cglosa")
                cClsAdP._dfeccnt = Session("gdfecsis")
                cClsAdP._cpoliza = "AR"
                cClsAdP._nCuenta = 1
                cClsAdP._cnumdoc = fila1("cnumdoc")
                cClsAdP._ccodpres = ""

                cClsAdP._llbandera = True
            Next

            For Each fila2 In ds2.Tables(0).Rows
                cClsAdP._cnumlin = fila2("cnumlin")
                cClsAdP._ccodcta = fila2("ccodcta")
                cClsAdP._ndebe = fila2("nhaber")
                cClsAdP._nhaber = fila2("ndebe")
                cClsAdP._cclase = fila2("cclase")
                cClsAdP._cconceptopar = "PARTIDA ANULACION -" & fila2("cconcepto")
                cClsAdP._ffondos = fila2("ffondos")
                cClsAdP._ccodofi = fila2("ccodofi")
                cClsAdP._ccodpres = fila2("ccodpres")

                oki = cClsAdP.AdPartida()


                If oki = "0" Then 'Ocurrio un Error
                    Exit Sub
                End If


                cClsAdP._nCuenta += 1

            Next

            'ok-<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            ediario.BanderaAnulada2(oki)
            ediario.ActualizaPartidaRevertida(lcnumpar, oki)
            ediario.ActualizaPartidaRevertida(oki, lcnumpar)
            Response.Write("<script language='javascript'>alert('Partida Revertida en Partida Nº:  " & oki & " ')</script>")

            CargarNoPartida(lcnumpar)
        End If
    End Sub

    Protected Sub TxtMonChq_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMonChq.TextChanged
        If cmbtippar.SelectedValue.Trim = "ND" Then
            TxtnHaber.Text = TxtMonChq.Text
            TxtnDebe.Text = 0
        Else
            TxtnDebe.Text = TxtMonChq.Text
            TxtnHaber.Text = 0
        End If

    End Sub

    
    Protected Sub cmbtippar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtippar.SelectedIndexChanged
        If cmbtippar.SelectedValue.Trim = "ND" Then
            TxtnHaber.Text = TxtMonChq.Text
            TxtnDebe.Text = 0
        Else
            TxtnDebe.Text = TxtMonChq.Text
            TxtnHaber.Text = 0
        End If
    End Sub

    Private Sub Dgdetalle_DeletedIndexChanged(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles Dgdetalle.DeleteCommand
        Dim index As Integer
        index = e.Item.ItemIndex
        ' Add code to delete data from data source.
        'Crea nuevo Dataset
        Dim xy As Integer
        vDetalle = cClsAdP.CargaPartida()
        ViewState.Add("Dataset", vDetalle)
        xy = 0
        Dim dr As DataRow
        Dim i As Integer
        vDetalle = ViewState("Dataset")
        i = 0

        index += 1

        For xy = 0 To Me.Dgdetalle.Items.Count - 1
            i += 1
            If index = i Then
            Else
                dr = vDetalle.Tables("Partidas").NewRow

                dr("IdCuenta") = i

                dr("cCodcta") = Me.Dgdetalle.Items(xy).Cells(2).Text
                dr("cdescri") = Me.Dgdetalle.Items(xy).Cells(3).Text
                dr("nDebe") = Me.Dgdetalle.Items(xy).Cells(4).Text.Replace("Q", "")
                dr("nHaber") = Me.Dgdetalle.Items(xy).Cells(5).Text.Replace("Q", "")
                dr("cConcepto") = Me.Dgdetalle.Items(xy).Cells(6).Text
                dr("ffondos") = Me.Dgdetalle.Items(xy).Cells(8).Text
                vDetalle.Tables("Partidas").Rows.Add(dr)

            End If

        Next
        Me.Dgdetalle.DataSource = vDetalle.Tables("Partidas")

        Me.Dgdetalle.DataBind()

        '----------------------------------------------
        'Sumando el Debe y el Haber para totalizar
        '----------------------------------------------

        i = 0
        Me.TxtTotDebe.Text = 0
        Me.TxtTotHaber.Text = 0
        Me.Txtdiferencia.Text = 0
        For Each dr In vDetalle.Tables("Partidas").Rows
            Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + vDetalle.Tables(0).Rows(i)("ndebe")
            Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + vDetalle.Tables(0).Rows(i)("nhaber")
            i += 1
        Next
        Me.Txtdiferencia.Text = Double.Parse(Me.TxtTotDebe.Text) - Double.Parse(Me.TxtTotHaber.Text)



    End Sub

End Class
