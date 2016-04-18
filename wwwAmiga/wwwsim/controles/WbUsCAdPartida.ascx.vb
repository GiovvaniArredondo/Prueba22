Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports Microsoft.Office.Interop

Public Class WbUsCAdPartida
    Inherits System.Web.UI.UserControl

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

        Dim ectbmcta As New cCtbmcta
        Dim dscatalago As New DataSet
        dscatalago = ectbmcta.CatalagoCombo()
        Me.cmbCatalago.DataTextField = "cDescri"
        Me.cmbCatalago.DataValueField = "ccodcta"
        Me.cmbCatalago.DataSource = dscatalago.Tables(0)
        Me.cmbCatalago.DataBind()

        Dim mListaTabttab1 As New listatabttab

        mListaTabttab1 = clstabttab.ObtenerLista("098", "1")

        Me.cmbrubro.DataTextField = "cdescri"
        Me.cmbrubro.DataValueField = "ccodigo"
        Me.cmbrubro.DataSource = mListaTabttab1
        Me.cmbrubro.DataBind()

        Me.btnnew.Disabled = False
        Me.Dgdetalle.Columns(6).Visible = False
        Me.Dgdetalle.Columns(7).Visible = False
    End Sub

    Public Sub CargarCuenta(ByVal codigoCliente As String)
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

    Public Sub CargarNoPartida(ByVal codigoPartida As String, ByVal cfondo As String, ByVal ccadena As String)
        Dim Fila As DataRow
        Dim ds As New DataSet
        Dim x As Integer
        Dim dr As DataRow
        Dim i As Integer
        Dim clssconta As New clsConta
        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        lcmesvig = Session("gcyears")
        '   lcyears = Left(lcmesvig.Trim, 4)
        lcyears = Left(Trim(Session("gcmesvig")), 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        Me.TxtNumpar.Text = codigoPartida
        vDetalle = cClsAdP.BuscaPartidaDes(Me.TxtNumpar.Text.Trim, cfondo, lccadena)




        Me.TxtDate.Text = vDetalle.Tables(0).Rows(0)("dfeccnt")
        Me.TxtGlosa.Text = vDetalle.Tables(0).Rows(0)("cGlosa")


        Me.cmbrubro.SelectedValue = Trim(vDetalle.Tables(0).Rows(0)("cpoliza"))

        Me.TxtDco.Text = vDetalle.Tables(0).Rows(0)("dfecdoc")
        Me.TxtNumdoc.Text = vDetalle.Tables(0).Rows(0)("cnumdoc")

        'Me.cmbFondos.SelectedValue = vDetalle.Tables(0).Rows(0)("ffondos")
        'Me.cmbOficina.SelectedValue = vDetalle.Tables(0).Rows(0)("ccodofi")

        vDetalle.Tables(0).Clear()

        'Aqui va el detalle de la Partida 
        vDetalle = cClsAdP.BuscaPartidaDet(Me.TxtNumpar.Text.Trim, cfondo, lccadena)

        Me.Dgdetalle.DataSource = vDetalle.Tables(0)
        Me.Dgdetalle.DataBind()

        Me.Dgdetalle.Enabled = False

        Me.btnedit.Disabled = False


        '----------------------------------------------
        'Sumando el Debe y el Haber para totalizar
        '----------------------------------------------

        i = 0
        Me.TxtTotDebe.Text = 0
        Me.TxtTotHaber.Text = 0
        Me.Txtdiferencia.Text = 0
        For Each dr In vDetalle.Tables(0).Rows
            Me.TxtTotDebe.Text = Double.Parse(Me.TxtTotDebe.Text) + vDetalle.Tables(0).Rows(i)("ndebe")
            Me.TxtTotHaber.Text = Double.Parse(Me.TxtTotHaber.Text) + vDetalle.Tables(0).Rows(i)("nhaber")
            i += 1
        Next
        Me.Txtdiferencia.Text = Double.Parse(Me.TxtTotDebe.Text) - Double.Parse(Me.TxtTotHaber.Text)
        vDetalle.Tables(0).Clear()
        Me.btncancel.Disabled = False
        Me.btnprint.Disabled = False

        Me.btnsave.Disabled = True
    End Sub

    Public Sub CargarPartida()
        Dim dr As DataRow
        Dim i As Integer


        vDetalle = ViewState("Dataset")

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
        dr("ccodofi") = Me.cmbOficina.SelectedValue.Trim

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

    Public Sub Habilita()
        Me.TxtDate.Enabled = True
        Me.TxtNumdoc.Enabled = True
        Me.cmbOficina.Enabled = True
        'Me.cmbFondos.Enabled = True
        Me.cmbrubro.Enabled = True
        Me.Txtccodcta.Enabled = True
        cmbFondos.Enabled = True
        Me.cmbCatalago.Enabled = True
        Me.TxtnDebe.Enabled = True
        Me.Txtcconcepto.Enabled = True
        Me.TxtnHaber.Enabled = True
        Me.TxtGlosa.Enabled = True
        Me.btnProcesa.Disabled = False
        Me.TxtDate.Text = Session("gdfecsis")
        Me.TxtDco.Text = Session("gdfecsis")


    End Sub

    Public Sub deshabilita()
        vDetalle.Tables.Clear()

        Me.Dgdetalle.DataSource = vDetalle.Tables("Partidas")
        Me.Dgdetalle.DataBind()

        Me.TxtDate.Enabled = False
        Me.TxtNumdoc.Enabled = False
        Me.cmbOficina.Enabled = False
        Me.cmbFondos.Enabled = False
        Me.cmbrubro.Enabled = False
        Me.Txtccodcta.Enabled = False
        cmbFondos.Enabled = False
        Me.cmbCatalago.Enabled = False
        Me.TxtnDebe.Enabled = False
        Me.Txtcconcepto.Enabled = False
        Me.TxtnHaber.Enabled = False
        Me.btnProcesa.Disabled = True

        Me.Txtcconcepto.Text = ""
        Me.TxtnDebe.Text = 0.0
        Me.TxtnHaber.Text = 0.0
        Me.TxtTotDebe.Text = 0.0
        Me.TxtTotHaber.Text = 0.0
        Me.Txtdiferencia.Text = 0.0
        Me.TxtNumpar.Text = " "
        Me.TxtDate.Text = " "
        Me.TxtDco.Text = " "
        Me.TxtNumdoc.Text = " "

        Me.CheckBox1.Checked = False
        Me.TxtGlosa.Text = ""
        Me.TxtComodin.Text = ""
        Me.TxtBandera.Text = ""
        Me.Txtccodcta.Text = ""
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
        lcpoliza = Me.cmbrubro.SelectedItem.Text

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
            'Dim lId As String = Request.QueryString("id")
            'Me.txtcodcli.Value = lId
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
                dr("ccodofi") = Me.Dgdetalle.Items(xy).Cells(9).Text.Trim
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

    Private Sub Dgdetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgdetalle.SelectedIndexChanged

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
                cmbFondos.SelectedValue = Me.Dgdetalle.Items(x).Cells(8).Text.Trim
                Me.cmbOficina.SelectedValue = Me.Dgdetalle.Items(x).Cells(9).Text.Trim
            End If

        Next


    End Sub



    Private Sub btnProcesa_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesa.ServerClick
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
                    Me.Dgdetalle.Items(xy).Cells(9).Text = Me.cmbOficina.SelectedValue.Trim
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
                dr("ccodofi") = Me.Dgdetalle.Items(xy).Cells(9).Text
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
        ViewState.Add("Dataset", vDetalle)
        Me.btnnew.Disabled = True
        Me.TxtNumpar.Text = "99999999"
        Me.TxtNumdoc.Text = ""
        Me.TxtnDebe.Text = 0.0
        Me.Txtcconcepto.Text = ""
        Me.TxtnHaber.Text = 0.0
        Me.TxtTotDebe.Text = 0.0
        Me.TxtTotHaber.Text = 0.0
        Me.Txtdiferencia.Text = 0.0
        Me.TxtGlosa.Text = ""
        Me.CheckBox1.Checked = True
        Me.Habilita()
        Me.btnsave.Disabled = False
        Me.btncancel.Disabled = False
        Me.Dgdetalle.Enabled = True
        Me.btnedit.Disabled = True
        Me.TxtBandera.Text = 1
        'Me.CargarCuenta(Me.cmbCatalago.SelectedValue.Trim)
    End Sub
    Private Function valida() As Boolean
        Dim clsvalida As New clsversion1
        Dim lnvalida As Integer
        Try
            clsvalida.dFecpar = Date.Parse(Me.TxtDate.Text)
            lnvalida = clsvalida.validaMes(Session("gcfondo"))
            If lnvalida = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TxtDate.Text = Session("gdfecsis")
            Response.Write("<script language='javascript'>alert('Fecha Invalida')</script>")
            Exit Function
        End Try

    End Function

    Private Sub btnsave_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.ServerClick
        'Me.valida()
        Dim clsppal As New class1
        If clsppal.valida_mes(Date.Parse(TxtDate.Text), Session("gdfecsis")) = False Then
            Me.btnsave.Disabled = False
            Response.Write("<script language='javascript'>alert('Mes Ya Cerrado o Fecha Adelantada al Mes Actual')</script>")
            Exit Sub
        End If

        Dim Fila As DataRow
        Dim x As Integer
        Dim ok As Integer
        Dim oki As String

        'Grabara la partida

        cClsAdP._dfecmod = Session("gdfecsis")
        cClsAdP._ccodusu = Session("gcCodusu")
        cClsAdP._ccodofi = Me.cmbOficina.SelectedValue.Trim
        cClsAdP._ffondos = Me.cmbFondos.SelectedValue.Trim
        cClsAdP._cconcepto = Me.TxtGlosa.Text.Trim
        cClsAdP._dfeccnt = Date.Parse(Me.TxtDate.Text.Trim)
        cClsAdP._cpoliza = Me.cmbrubro.SelectedValue.Trim
        cClsAdP._nCuenta = 1
        cClsAdP._cnumdoc = Me.TxtNumdoc.Text.Trim
        cClsAdP._ccodpres = ""

        If Me.TxtBandera.Text.Trim = "0" Then   'Modifica
            cClsAdP._cNumpar = Me.TxtNumpar.Text.Trim
            cClsAdP._cnumcom = Me.TxtNumpar.Text.Trim
            cClsAdP._llbandera = False

            ok = cClsAdP.EliminarRegistro()

            'ok = cClsAdP.ModPartida()

            If ok = 0 Then 'Ocurrio un Error
                Exit Sub
            End If

        End If            'Agrega


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


        vDetalle = ViewState("Dataset")
        x = vDetalle.Tables("Partidas").Rows.Count()
        x = 0

        cClsAdP._llbandera = True

        For Each Fila In vDetalle.Tables("Partidas").Rows
            cClsAdP._cnumlin = vDetalle.Tables(0).Rows(x)("IdCuenta")
            cClsAdP._ccodcta = vDetalle.Tables(0).Rows(x)("cCodcta")
            cClsAdP._ndebe = vDetalle.Tables(0).Rows(x)("nDebe")
            cClsAdP._nhaber = vDetalle.Tables(0).Rows(x)("nHaber")
            cClsAdP._cclase = Mid(vDetalle.Tables(0).Rows(x)("cCodcta"), 1, 1)
            cClsAdP._cconceptopar = vDetalle.Tables(0).Rows(x)("cconcepto")
            cClsAdP._ffondos = vDetalle.Tables(0).Rows(x)("ffondos")
            cClsAdP._ccodofi = vDetalle.Tables(0).Rows(x)("ccodofi")

            If Me.TxtBandera.Text.Trim = "0" Then   'Modifica
                oki = cClsAdP.AdPartidaDetalle()
            Else
                oki = cClsAdP.AdPartida()
            End If


            If oki = "0" Then 'Ocurrio un Error
                Exit Sub
            End If

            x += 1
            cClsAdP._nCuenta += 1

        Next
        '  End If

        Me.deshabilita()
        Me.btnsave.Disabled = True
        Me.btnnew.Disabled = False
        Me.btncancel.Disabled = True

        Dim clssconta As New clsConta
        Dim lccadena As String
        Dim lcmesvig As String
        Dim lcyears As String
        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig.Trim, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        Me.CargarNoPartida(oki, Session("gcfondo"), lccadena)
        'Me.Imprime()
    End Sub

    Private Sub btncancel_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.ServerClick
        Me.deshabilita()
        Me.btnsave.Disabled = True
        Me.btnnew.Disabled = False
        Me.btncancel.Disabled = True
    End Sub

    Private Sub btnedit_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.ServerClick
        Me.btnedit.Disabled = True
        Me.btnsave.Disabled = False
        Me.btnnew.Disabled = True
        Me.btnProcesa.Disabled = True
        Me.TxtGlosa.Enabled = True
        Me.Habilita()
        Me.btnProcesa.Disabled = False
        Me.btncancel.Disabled = False
        Me.TxtBandera.Text = 0

        Me.Dgdetalle.Enabled = True
    End Sub

    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick
        Me.Imprime()
    End Sub
    Private Function validador() As Integer
        Dim ectbmcta As New cCtbmcta
        Dim lnvalida As Integer
        lnvalida = ectbmcta.ValidarCuenta(Me.Txtccodcta.Text.Trim)
        Return lnvalida
    End Function

    Private Sub TxtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDate.TextChanged
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

    Protected Sub cmbCatalago_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCatalago.SelectedIndexChanged

    End Sub

    Protected Sub Txtccodcta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtccodcta.TextChanged
        'Me.Txtccodcta.Text = Me.cmbCatalago.SelectedValue.Trim
        Me.CargarCuenta(Me.Txtccodcta.Text.Trim)
    End Sub
    Private Sub CargarArchivoExcel()
        Dim m_Excel As Microsoft.Office.Interop.Excel.Application
        Dim strRutaExcel As String
        strRutaExcel = "C:\txt\excel\archivo.xls"

        m_Excel = CreateObject("Excel.Application")
        m_Excel.Workbooks.Open(strRutaExcel)
        m_Excel.Visible = False 'Dejamos el libro oculto

        Dim filas As Integer
        filas = m_Excel.Worksheets(1).UsedRange.Rows.Count() - 1
        Dim lcleer As String
        'Mostramos el valor de la celda 1,1 del primer libre
        lcleer = m_Excel.Worksheets("Hoja1").Cells(1, 1).Value

        For i As Integer = 1 To filas

        Next


        ''Escribir en una celda
        'm_Excel.Worksheets("Hoja1").cells(3, 3).value = "prueba"

        'Guardamos los cambios del libro activo
        m_Excel.Application.ActiveWorkbook.Save()
        'Nota: Hay una instruccion como esta:
        m_Excel.Application.ActiveWorkbook.SaveAs()




        'Eliminamos la instancia de Excel de memoria
        If Not m_Excel Is Nothing Then
            m_Excel.Quit()
            m_Excel = Nothing
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        CargarArchivoExcel()
    End Sub
End Class
