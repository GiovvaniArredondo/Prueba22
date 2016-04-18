Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO
Public Class cuwrepctb
    Inherits ucWBase

#Region "Variables"
    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private Transacc As String
    Private clsppal As New class1
    Private mcremcre As New cCremcre
    Private clsConvert As New ConversionLetras
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private codigoJs As String
#End Region

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()
        Dim entidadCntaprm As New SIM.EL.cntaprm
        Dim eCntaprm As New SIM.BL.cCntaprm
        Dim ds As New DataSet
        Dim ncanti As Integer
        Dim lcmesvig As String
        Dim lccadena As String
        Dim lcyears As String
        Dim clssconta As New clsConta

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        lccadena = clssconta.cadena(Session("gcfondo"), lcyears, Session("gcnomser"))

        ds = eCntaprm.ObtenerDataSetPorID(Session("gcfondo"), lccadena)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.txtdfecini.Text = ds.Tables(0).Rows(0)("dFecimes")
        Me.txtdfecfin.Text = ds.Tables(0).Rows(0)("dFecfmes")

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab1 As New listatabttab
        Dim lcfondos As String
        lcfondos = Session("gcfondo")

        mListaTabttab1 = clstabttab.ObtenerListaPorIDxcodigo("033", "1", lcfondos)
        'Fondos
        Me.cbxfondos.DataTextField = "cdescri"
        Me.cbxfondos.DataValueField = "ccodigo"
        Me.cbxfondos.DataSource = mListaTabttab1
        Me.cbxfondos.DataBind()

        Me.txtdesde.Text = ""
        Me.txthasta.Text = ""
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        lnparametro1_R = "cNomOfi , cCodOfi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = " "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If


        Me.CbxCodOFi.DataTextField = "cNomOfi"
        Me.CbxCodOFi.DataValueField = "cCodOfi"
        Me.CbxCodOFi.DataSource = ds.Tables("Resultado")
        Me.CbxCodOFi.DataBind()



        'Me.CbxCodOFi.DropDownWidth = 300
        ds.Tables("Resultado").Clear()

        '---------------------------
        'Exportar a
        '---------------------------
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("145", "1")

        Me.ddlexportar.DataTextField = "cdescri"
        Me.ddlexportar.DataValueField = "ccodigo"
        Me.ddlexportar.DataSource = mListaTabttab
        Me.ddlexportar.DataBind()

        'Niveles
        Dim ectbmcta As New cCtbmcta
        Dim dsnivel As New DataSet
        dsnivel = ectbmcta.ObtieneNiveles
        Me.CbxNivel.DataTextField = "cnivel"
        Me.CbxNivel.DataValueField = "nivel"
        Me.CbxNivel.DataSource = dsnivel
        Me.CbxNivel.DataBind()


        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        Me.Textbox5.Text = 0
        Me.Textbox6.Text = ""
        Me.Textbox7.Text = 0
        Me.Textbox8.Text = 0
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim ds1 As New DataSet
        Dim lcmesvigN As String
        ds1 = eCntaprm.ObtenerDataSetPorID2(Session("gcfondo"))
        lcmesvigN = ds1.Tables(0).Rows(0)("cmesvig")
        If lcmesvig.Trim = lcmesvigN.Trim Then
            Me.Antes.Visible = False
            Me.Despues.Visible = False
            Me.txtcierre.Text = "0"
        Else
            Me.Antes.Visible = True
            Me.Despues.Visible = True
            Me.txtcierre.Text = "1"
        End If

        Dim dsb As New DataSet
        Dim clsbancos As New cTabtbco
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "*")

        'Me.cmbCuentas.DataTextField = "cCtacte"
        'Me.cmbCuentas.DataValueField = "cCtacte"
        'Me.cmbCuentas.DataSource = dsb.Tables(0)
        'Me.cmbCuentas.DataBind()

        Me.cmbBancos.DataTextField = "cnombco"
        Me.cmbBancos.DataValueField = "ccodbco"
        Me.cmbBancos.DataSource = dsb.Tables(0)
        Me.cmbBancos.DataBind()

        cargayears()
        Activayear()

    End Sub


    Private Sub btnprocesar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocesar.ServerClick
        If Me.txtcierre.Text = "1" Then
            If Antes.Checked = True Then
                Me.txtcierre.Text = "1"
            End If
            If Despues.Checked = True Then
                Me.txtcierre.Text = "2"
            End If
        End If

        If Me.rbtn1.Checked = True Or rbtn11.Checked = True Then
            Me.balanceGeneral(IIf(Me.rbtn1.Checked = True, "0", "1"))
        ElseIf Me.rbtn2.Checked = True Then
            Me.LibroDiarioMayor2()
        ElseIf Me.RadioButton1.Checked = True Then
            Me.EstadoResultadosSuper()

        ElseIf Me.rbtn4.Checked = True Then
            Me.LibroDiarioDetallado()
        ElseIf Me.rbtn5.Checked = True Then
            Me.BalanceComprobacion("a")
        ElseIf Me.rbtn6.Checked = True Then
            Me.ConcentracionDiaria()
        ElseIf Me.rbtn7.Checked = True Then
            If Me.CheckBox3.Checked = True Then
                Me.lmAuxiliar()

            End If
        ElseIf Me.rbtn8.Checked Then     'Archivo .TXT Dispersador
            'Me.BalanceComprobacion("b")
            Genera_Dispersion(Date.Parse(Me.txtdfecini.Text), Date.Parse(Me.txtdfecfin.Text))

        ElseIf Me.rbtn9.Checked = True Then
            Me.MovimientoxCuenta("A")
        ElseIf Me.rbtn10.Checked = True Then
            Me.MovimientoxCuenta("B")
        ElseIf Me.rbtn12.Checked = True Then
            Me.PartidasContables(0)
        ElseIf rbtn13.Checked = True Then
            ImprimePartida()
        ElseIf rbtn14.Checked = True Then
            Dim mcredkar As New cCredkar
            Dim ds As New DataSet

            Dim lcnombre As String = ""
            Dim ldfecha2 As Date = Date.Parse(Me.txtdfecfin.Text)
            Dim lcmes As String = ldfecha2.Month.ToString
            Dim lcdia As String = IIf(ldfecha2.Day.ToString.Trim.Length = 1, "0" & ldfecha2.Day.ToString, ldfecha2.Day.ToString)
            Dim lcmes_ As String = IIf(ldfecha2.Month.ToString.Trim.Length = 1, "0" & ldfecha2.Month.ToString, ldfecha2.Month.ToString)
            Dim lcano As String = ldfecha2.Year.ToString.Trim
            Dim FilePath As String = ""

            lcnombre = "Exporta_Asiento_CTB_" & lcdia & lcmes_ & lcano & ".xls"

            FilePath = "c:\txt\" & lcnombre.Trim

            'Copia el archivo a un lugar que se pueda visualizar, primero verifica si existe para borrarlo
            If System.IO.File.Exists(FilePath) Then
                System.IO.File.Delete(FilePath)
            End If

            ds = mcredkar.Genera_rutina_Exporta_Asientos(Date.Parse(Me.txtdfecini.Text), Date.Parse(Me.txtdfecfin.Text), Session("gnIVA"))

            'ExcelLibrary.DataSetHelper.CreateWorkbook(FilePath, dsbase1)
            Me.ExportarAExcel(FilePath, ds)

            Me.Down_loadFile(FilePath, lcnombre)

        End If


    End Sub
    Private Sub balanceGeneral(ByVal tipo As String)
        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcexportar As String
        '
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)

        lcexportar = Me.ddlexportar.SelectedValue
        '
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim



        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")

        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        classconta.pcyears = Left(lcyears, 4)
        classconta.pccierre = lccierre.Trim

        Dim lcnivel As String
        If Me.Checknivel.Checked = True Then
            lcnivel = "99"
        Else
            lcnivel = Me.CbxNivel.Value.Trim
        End If


        'If rbtn1.Checked = True Then
        '    If Checkdeta0.Checked = True Then
        '        dsbalance = classconta.GenComprobacionNivelconAuxiliares(ldfecha1, ldfecha2, "bc", lcnivel)
        '    Else
        '        dsbalance = classconta.GenComprobacionNivel(ldfecha1, ldfecha2, "bc", lcnivel)
        '    End If

        'Else
        Dim dsres As New DataSet
        If Checkdeta0.Checked = True Then
            dsbalance = classconta.GenComprobacion(ldfecha1, ldfecha2, "bc")
            If dsbalance Is Nothing Then
                Return
            End If
            dsres = classconta.EstadoSuper(dsbalance, IIf(tipo = "0", "0002", "0002"), lcnivel)

            balanceGeneralDetallado("0")
        Else
            dsbalance = classconta.GenComprobacion(ldfecha1, ldfecha2, "bc")
            'End If

            If dsbalance Is Nothing Then
                Return
            End If




            dsres = classconta.EstadoSuper(dsbalance, IIf(tipo = "0", "0002", "0002"), lcnivel)

            If rbtn1.Checked = True Then
                If Checkdeta0.Checked = True Then
                    '---Se agregaran cuentas auxiliares a plantilla

                End If
            End If

            If tipo = "0" Then
                Me.imprime3("crestresup2.rpt", dsres, lcexportar)
            Else
                Me.imprime3("crestresup.rpt", dsres, lcexportar)
            End If

        End If

        

    End Sub
    Private Sub EstadoResultados()
        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue
        

        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")
        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim

        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)

        'dsbalance = classconta.estado_w resultados(ldfecha1, ldfecha2)
        dsbalance = classconta.estado_resultados2(ldfecha1, ldfecha2)
        If dsbalance Is Nothing Then
            Return
        End If
        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        Dim lctipo1 As String

        Me.imprime3("crestres2.rpt", dsbalance, lcexportar)

    End Sub
    Private Sub EstadoResultados1()
        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue

        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")
        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        dsbalance = classconta.estado_resultados1(ldfecha1, ldfecha2)

        If dsbalance Is Nothing Then
            Return
        End If
        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        Dim lctipo1 As String
        'If (classconta.pnutilidad > 0) Then
        'lctipo1 = "UTILIDAD DEL EJERCICIO"
        ' Else
        '    lctipo1 = "PERDIDA DEL EJERCICIO"
        ' End If

        'Me.Textbox5.Text = classconta.pnutilidad
        'Me.Textbox6.Text = lctipo1
        'Me.Textbox7.Text = classconta.pningresos
        'Me.Textbox8.Text = classconta.pngastos

        Me.imprime2("crestres.rpt", dsbalance, lcexportar)

    End Sub
    Private Sub BalanceComprobacion(ByVal opcion As String)
        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")
        Dim lcmesvig As String
        Dim lcyears As String

        Dim lcnivel As String
        If Me.Checknivel.Checked = True Then
            lcnivel = "99"
        Else
            lcnivel = Me.CbxNivel.Value.Trim
        End If


        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        If opcion = "a" Then
            If Checkdeta.Checked = True Then
                dsbalance = classconta.GenComprobacionNivelconAuxiliares(ldfecha1, ldfecha2, "bc", lcnivel)
            Else
                dsbalance = classconta.GenComprobacionNivel(ldfecha1, ldfecha2, "bc", lcnivel)
            End If


        Else
            dsbalance = classconta.GenComprobacion(ldfecha1, ldfecha2, "bc")
        End If

        Me.TextBox1.Text = classconta.pnsalini
        Me.TextBox2.Text = classconta.pnsalfin
        Me.TextBox3.Text = classconta.pndebe
        Me.TextBox4.Text = classconta.pnhaber



        If dsbalance Is Nothing Then
            Return
        End If
        If opcion = "a" Then
            Me.Imprime("crbalcom.rpt", dsbalance, lcexportar)
        Else
            Me.GeneraArchivo(dsbalance)
            'Dim lcnombre As String = "ArcXml"
            'Dim FilePath As String = "c:/txt/" & lcnombre
            'dsbalance.Tables(0).WriteXml(FilePath)

        End If


    End Sub
    Private Sub lmAuxiliar()

        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)

        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")

        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lcdesde As String
        Dim lchasta As String
        lcdesde = Me.txtdesde.Text.Trim
        lchasta = Me.txthasta.Text.Trim
        If lcdesde = "" Or lchasta = "" Then
            Return
        End If
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        dsbalance = classconta.lmAuxiliar(ldfecha1, ldfecha2, "C", lcdesde, lchasta, "A")
        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        If dsbalance Is Nothing Then
            Return
        End If
        Me.imprime3("crlmauxiliar.rpt", dsbalance, lcexportar)

    End Sub
    Private Sub LibroDiarioMayor()
        Dim mcntamov As New cCntamov
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcnomser As String
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue

        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        lcnomser = Session("gcnomser")
        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)

        dsbalance = mcntamov.Obtenerlistado_Partidas(ldfecha1, ldfecha2, lcnomser, lccodofi, lcfuente)

        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        If dsbalance Is Nothing Then
            Return
        End If

        Me.Imprime("crlispar.rpt", dsbalance, lcexportar)


    End Sub
    Private Sub LibroDiarioDetallado()
        Dim lcexportar As String
        Dim tipo As String
        Dim nomrepor As String = "crLibroDeta.rpt"
        lcexportar = Me.ddlexportar.SelectedValue

        Dim dsLMDet As New DataSet
        Dim classconta As New clsConta
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.dFecIni = Me.txtdfecini.Text
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        'dsLMDet = classconta.LibromayorDetallado()
        dsLMDet = classconta.Catalogo(Session("gcfondo"))

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & nomrepor, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        Dim lcnomofi As String
        If Session("gcfondo") = "99" Then
            lcnomofi = Session("GCNOMINS")
        Else
            lcnomofi = Session("GCNOMINS")
        End If

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsLMDet.Tables(0))
        crRpt.SetParameterValue("dfecini", Me.txtdfecini.Text)
        crRpt.SetParameterValue("dfecfin", Me.txtdfecfin.Text)
        crRpt.SetParameterValue("cnomofi", lcnomofi)
        Select Case lcexportar
            Case "PDF"
                tipo = "application/pdf"
                nomrepor &= ".pdf"
                rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True
            Case "WRD"
                tipo = "application/msword"
                nomrepor &= ".doc"
                rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True
            Case "XLS"
                tipo = "application/vnd.ms-excel"
                nomrepor &= ".xls"
                rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True

        End Select

        Response.ContentType = tipo

        'crRpt.Refresh()

        ' Establece el tipo de documento
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<     


    End Sub
    Private Sub ConcentracionDiaria()
        Dim lcexportar As String
        Dim tipo As String
        Dim nomrepor As String = "crConCta.rpt"
        Dim lccodofi As String
        Dim lcfuente As String
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        lcexportar = Me.ddlexportar.SelectedValue

        Dim classconta As New clsConta
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.dFecIni = Me.txtdfecini.Text
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)

        Dim dsctb As New DataSet
        dsctb = classconta.ConsMov()
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & nomrepor, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        Dim lcnomofi As String
        crRpt.SetDataSource(dsctb.Tables(0))
        If Session("gcfondo") = "99" Then
            lcnomofi = Session("GCNOMINS")
        Else
            lcnomofi = Session("GCNOMINS")
        End If

        ' Setear los registros recuperados, diciendole el Table respectivo
        
        crRpt.SetParameterValue("cnomofi", lcnomofi)

        Select Case lcexportar
            Case "PDF"
                tipo = "application/pdf"
                nomrepor &= ".pdf"
                rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True
            Case "WRD"
                tipo = "application/msword"
                nomrepor &= ".doc"
                rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True
            Case "XLS"
                tipo = "application/vnd.ms-excel"
                nomrepor &= ".xls"
                rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True

        End Select

        Response.ContentType = tipo

        'crRpt.Refresh()

        ' Establece el tipo de documento
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<     
    End Sub
    Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lncasos As Integer
        Dim lcexportar As String

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)

        Dim i As Integer
        Dim tipo As String

        lcexportar = pcexportar.Trim

        If dsbase Is Nothing Then
            Return
        End If


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String
        If Session("gcfondo") = "99" Then
            lcNomofi = Session("GCNOMINS")
        Else
            lcNomofi = Session("GCNOMINS")
        End If


        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        If Me.rbtn2.Checked = True Or Me.rbtn1.Checked = True Or rbtn12.Checked = True Then

        Else
            crRpt.SetParameterValue("lnsalini", Me.TextBox1.Text)
            crRpt.SetParameterValue("lnsalfin", Me.TextBox2.Text)
            crRpt.SetParameterValue("lndebe", Me.TextBox3.Text)
            crRpt.SetParameterValue("lnhaber", Me.TextBox4.Text)

        End If
        crRpt.SetParameterValue("ldfecha1", ldfecha1)
        crRpt.SetParameterValue("ldfecha2", ldfecha2)
        crRpt.SetParameterValue("cnomofi", lcNomofi.Trim)
        If rbtn5.Checked = True Or RadioButton1.Checked = True Or (rbtn1.Checked = True And Checkdeta0.Checked) Then
            Dim etabttab As New cTabttab
            Dim lcfondos As String = ""
            Dim lcagencia As String = ""
            Dim etabtofi As New cTabtofi

            If Me.CheckBox1.Checked = True Then
                lcagencia = ""
            Else
                lcagencia = etabtofi.NombreAgencia(Me.CbxCodOFi.Value.Trim)
            End If

            If Me.CheckBox2.Checked = True Then
                lcfondos = ""
            Else
                lcfondos = etabttab.Describe(Me.cbxfondos.Value, "033")
            End If


            crRpt.SetParameterValue("cfondos", lcfondos.Trim)
            crRpt.SetParameterValue("cagencia", lcagencia.Trim)
        End If
        If lcexportar = "XLS2" Then
            Me.ExportToExcel(dsbase.Tables(0))
        Else

            Select Case lcexportar
                Case "PDF"
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "WRD"
                    tipo = "application/msword"
                    reportes &= ".doc"
                    rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "XLS"
                    'tipo = "application/vnd.ms-excel"
                    tipo = "application/ms-excel"
                    reportes &= ".xls"
                    rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True

            End Select

            Response.ContentType = tipo


            Response.BinaryWrite(rptStream.ToArray())
            '        Response.End()
            Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
            'Response.Flush()
            'Response.Close()
            Response.End()
        End If
        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub
    Public Sub imprime2(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lncasos As Integer
        Dim lcexportar As String

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)

        Dim i As Integer
        Dim tipo As String

        lcexportar = pcexportar.Trim

        If dsbase Is Nothing Then
            Return
        End If


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = Session("GCNOMINS")

        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("ldfecha1", ldfecha1)
        crRpt.SetParameterValue("ldfecha2", ldfecha2)

        crRpt.SetParameterValue("lnutilidad", Me.Textbox5.Text)
        crRpt.SetParameterValue("lctipo", Me.Textbox6.Text.Trim)
        crRpt.SetParameterValue("lningresos", Me.Textbox7.Text)
        crRpt.SetParameterValue("lngastos", Me.Textbox8.Text)
        crRpt.SetParameterValue("cnomofi", lcNomofi.Trim)

        Select Case lcexportar
            Case "PDF"
                tipo = "application/pdf"
                reportes &= ".pdf"
                rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True
            Case "WRD"
                tipo = "application/msword"
                reportes &= ".doc"
                rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True
            Case "XLS"
                tipo = "application/vnd.ms-excel"
                reportes &= ".xls"
                rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                Response.Clear()
                Response.Buffer = True

        End Select

        Response.ContentType = tipo


        'Automaticamente se descarga el archivo
        ' Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub
    Public Sub imprime3(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lncasos As Integer
        Dim lcexportar As String

        Dim lcnomfue As String = ""
        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        Dim lcnomofi As String = ""
        Dim etabtofi As New cTabtofi
        Dim etabttab As New cTabttab

        If Me.CheckBox1.Checked = True Then
            lcNomofi = ""
        Else
            lcnomofi = etabtofi.NombreAgencia(Me.CbxCodOFi.Value.Trim)
        End If


        If Me.CheckBox2.Checked = True Then
            lcnomfue = ""
        Else
            lcnomfue = etabttab.Describe(Me.cbxfondos.Value, "033")
        End If

        Dim i As Integer
        Dim tipo As String

        lcexportar = pcexportar.Trim

        If dsbase Is Nothing Then
            Return
        End If

        Dim cnomrep As String

        'lcNomofi = "FONDESOL"
        If RadioButton1.Checked = True Then
            Dim entidadcntaprm As New cntaprm
            Dim ecntaprm As New cCntaprm
            entidadcntaprm.cmesvig = Session("gcyears")
            ecntaprm.ObtenerCntaprm(entidadcntaprm)
            ldfecha1 = entidadcntaprm.dfecimes
            
        End If
        
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución


        Dim a As String
        a = dsbase.Tables(0).TableName
        lncasos = dsbase.Tables(0).Rows.Count

        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("ldfecha1", ldfecha1)
        crRpt.SetParameterValue("ldfecha2", ldfecha2)
        crRpt.SetParameterValue("lcnomfue", lcnomfue)
        crRpt.SetParameterValue("cnomofi", lcNomofi.Trim)

        If Me.RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            If RadioButton1.Checked = True Then
                cnomrep = "ESTADO DE INGRESOS Y EGRESOS"
            Else
                cnomrep = "ESTADO DE INGRESOS Y EGRESOS MENSUAL"
            End If

            crRpt.SetParameterValue("lcnomrep", cnomrep.Trim)
        End If
        If Me.rbtn1.Checked = True Then
            crRpt.SetParameterValue("lcnomrep", "BALANCE GENERAL ")
        End If
        If rbtn11.Checked = True Then
            crRpt.SetParameterValue("lcnomrep", "BALANCE GENERAL CONSOLIDADO")
        End If

        If lcexportar = "XLS2" Then
            Me.ExportToExcel(dsbase.Tables(0))
        Else

            Select Case lcexportar
                Case "PDF"
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "WRD"
                    tipo = "application/msword"
                    reportes &= ".doc"
                    rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                Case "XLS"
                    tipo = "application/vnd.ms-excel"
                    reportes &= ".xls"
                    rptStream = CType(crRpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
            End Select
        End If
        Response.ContentType = tipo


        'Automaticamente se descarga el archivo

        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub
    Private Sub LibroDiarioMayor2()
        Dim mcntamov As New cCntamov
        Dim dsbalance As New DataSet
        Dim dsbal As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcnomser As String
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        Dim lccodcta, lccodcta1 As String
        Dim lnnivel As Integer
        Dim classconta As New clsConta

        lcexportar = Me.ddlexportar.SelectedValue

        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If
        If Me.CheckBox3.Checked = True Then
            lccodcta = Me.txtdesde.Text.Trim
            lccodcta1 = Me.txthasta.Text.Trim
            lnnivel = lccodcta.Length
        Else
            lccodcta = "*"
            lccodcta1 = "*"
            lnnivel = 0
        End If
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        lcnomser = Session("gcnomser")
        classconta.pcnomser = lcnomser
        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)

        dsbal = classconta.libro(ldfecha1, ldfecha2, lccodcta, lnnivel, lcnomser, lccodcta1, lcfuente, lccodofi)
        dsbalance = classconta.Depurador2(dsbal)

        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        If dsbalance Is Nothing Then
            Return
        End If

        Me.Imprime("crlibro.rpt", dsbalance, lcexportar)


    End Sub

    Private Sub GeneraArchivo(ByVal ds As DataSet)
        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            Dim lcnombre As String
            Dim lcdia1 As String
            Dim lcdia As String

            Dim lcmes1 As String
            Dim lcmes As String

            Dim lcaño As String

            lcdia1 = Date.Parse(Me.txtdfecfin.Text).Day.ToString
            lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

            lcmes1 = Date.Parse(Me.txtdfecfin.Text).Month.ToString
            lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

            lcaño = Date.Parse(Me.txtdfecfin.Text).Year.ToString
            Dim lcfondo As String
            lcfondo = Session("gcfondo")
            If lcfondo.Trim = "99" Then
                lcnombre = "T6150M" & lcdia & lcmes & lcaño & "00" & ".txt"
            Else
                lcnombre = "F" & lcfondo.Trim & "50M" & lcdia & lcmes & lcaño & "00" & ".txt"
            End If


            Dim FilePath As String = "c:/txt/" & lcnombre

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)

            'Se traen los datos que necesitamos para el archivo
            'TraerDatosArchivo retorna un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto


            Dim dr As DataRow
            Dim pccodcta As String = ""
            Dim pcdescrip As String = ""
            Dim pcsalini As String = ""
            Dim pcdebe As String = ""
            Dim pchaber As String = ""
            Dim pcsalfin As String = ""
            Dim codig_entid As String
            If lcfondo.Trim = "99" Then
                codig_entid = "T61"
            Else
                codig_entid = "F" + Session("gcfondo")
            End If

            Dim corre_envio As String = "00"
            Dim fecha_infor As String

            Dim ldfecha As Date
            ldfecha = Today
            Dim lcdia2 As String
            Dim lcdia2a As String

            Dim lcmes2 As String
            Dim lcmes2a As String

            Dim lcaño2 As String
            Dim fecha_envio As String

            lcdia2a = ldfecha.Day.ToString
            lcdia2 = IIf(lcdia2a.Trim.Length = 1, ("0" & lcdia2a), lcdia2a)

            lcmes2a = ldfecha.Month.ToString
            lcmes2 = IIf(lcmes2a.Trim.Length = 1, ("0" & lcmes2a), lcmes2a)

            lcaño2 = ldfecha.Year.ToString
            fecha_envio = lcaño2 & lcmes2 & lcdia2

            fecha_infor = lcaño & lcmes & lcdia
            strStreamWriter.WriteLine("CODIG_ENTID" & Chr(9) & "CORRE_ENVIO" & Chr(9) & "FECHA_INFOR" & Chr(9) & "FECHA_ENVIO" & _
                            Chr(9) & "CODIG_CUENT" & Chr(9) & "NOMBR_CUENT" & Chr(9) & _
                            "SALDO_ANTER" & Chr(9) & "CARGO" & Chr(9) & "ABONO" & Chr(9) & "SALDO_ACTUA")
            For Each dr In ds.Tables(0).Rows
                'Obtenemos los datos del dataset
                pccodcta = (dr("ccodcta"))
                pcdescrip = (dr("cdescrip"))
                pcsalini = CStr(Math.Abs(dr("nsalini")))
                pcdebe = CStr(Math.Abs(dr("ndebe")))
                pchaber = CStr(Math.Abs(dr("nhaber")))
                pcsalfin = CStr(Math.Abs(dr("nsalfin")))

                pccodcta = clsppal.zeros(pccodcta.Trim, 25)
                pcdescrip = clsppal.zeros(pcdescrip.Trim, 100)
                pcsalini = clsppal.zeros(pcsalini.Trim, 13)
                pcdebe = clsppal.zeros(pcdebe.Trim, 13)
                pchaber = clsppal.zeros(pchaber.Trim, 13)
                pcsalfin = clsppal.zeros(pcsalfin.Trim, 13)
                'Escribimos la línea en el achivo de texto
                strStreamWriter.WriteLine(codig_entid & Chr(9) & corre_envio & Chr(9) & fecha_infor & Chr(9) & fecha_envio & _
                Chr(9) & pccodcta & Chr(9) & pcdescrip & Chr(9) & _
                pcsalini & Chr(9) & pcdebe & Chr(9) & pchaber & Chr(9) & pcsalfin)

            Next

            strStreamWriter.Close()
            Response.Write("<script language='javascript'>alert('El archivo se generó con éxito')</script>")


        Catch ex As Exception
            strStreamWriter.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EstadoResultadosSuper()
        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue

        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")
        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        'dsbalance = classconta.estado_w resultados(ldfecha1, ldfecha2)
        'dsbalance = classconta.estado_resultados2(ldfecha1, ldfecha2)
        Dim lcnivel As String
        If Me.Checknivel.Checked = True Then
            lcnivel = "99"
        Else
            lcnivel = Me.CbxNivel.Value.Trim
        End If
        If Checkdeta1.Checked = False Then
            dsbalance = classconta.GenComprobacionNivel(ldfecha1, ldfecha2, "bc", lcnivel)
        Else
            dsbalance = classconta.GenComprobacionNivelconAuxiliares(ldfecha1, ldfecha2, "bc", lcnivel)
        End If


        If dsbalance Is Nothing Then
            Return
        End If
        Dim dsres As New DataSet
        classconta.nValacc = Session("gnvalacc")


        'Carga formato
        dsres = clsppal.DatosEstado(dsbalance)

        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0


        If Checknivel0.Checked = True Then
            Dim dsestado As New DataSet
            dsestado = classconta.NivelOfiEstado(dsres, 0)
            Me.Imprime("crestadoResul.rpt", dsestado, lcexportar)
        ElseIf Checkdeta1.Checked = True Then
            Dim dsestado As New DataSet
            dsestado = classconta.NivelOfiEstado(dsres, 1)
            Me.Imprime("crestadoResul.rpt", dsestado, lcexportar)

        Else
            'Dim lctipo1 As String
            Me.Imprime("crestadoResul.rpt", dsres, lcexportar)

        End If


       


    End Sub

    Private Sub rbtn2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn2.CheckedChanged

    End Sub

    Private Sub Antes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Antes.CheckedChanged
        Me.txtcierre.Text = "1"
    End Sub

    Private Sub Despues_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Despues.CheckedChanged
        Me.txtcierre.Text = "2"
    End Sub

    Private Sub MovimientoxCuenta(ByVal tipo As String)

        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)

        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")

        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lcdesde As String
        Dim lchasta As String

        Dim etabtbco As New cTabtbco

        If chkbanco.Checked = True And tipo = "B" Then


            lcdesde = etabtbco.CuentaContableBanco(cmbBancos.SelectedValue.Trim).Trim
            lchasta = etabtbco.CuentaContableBanco(cmbBancos.SelectedValue.Trim).Trim

        Else
            lcdesde = Me.txtdesde.Text.Trim
            lchasta = Me.txthasta.Text.Trim

        End If
        If lcdesde = "" Or lchasta = "" Then
            Return
        End If
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        dsbalance = classconta.lmAuxiliar(ldfecha1, ldfecha2, "C", lcdesde, lchasta, tipo)
        Me.TextBox1.Text = 0
        Me.TextBox2.Text = 0
        Me.TextBox3.Text = 0
        Me.TextBox4.Text = 0

        If dsbalance Is Nothing Then
            Return
        End If
        If tipo.Trim = "A" Then
            Me.imprime3("crMovxCta.rpt", dsbalance, lcexportar)
        Else
            If Me.CheckBox4.Checked = True Then
                Me.imprime3("crMovxBco2.rpt", dsbalance, lcexportar)
            Else
                Me.imprime3("crMovxBco.rpt", dsbalance, lcexportar)
            End If

        End If


    End Sub

    Private Sub PartidasContables(ByVal parametro As Integer)
        Dim lcexportar As String
        Dim tipo As String
        Dim nomrepor As String = "crAuxiliar.rpt"
        lcexportar = Me.ddlexportar.SelectedValue

        Dim lccodofi As String
        Dim lcfuente As String
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If


        Dim dsLMDet As New DataSet
        Dim classconta As New clsConta
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.dFecIni = Me.txtdfecini.Text
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
        'dsLMDet = classconta.LibromayorDetallado()
        Dim ecntamov As New cCntamov
        If parametro = 0 Then
            dsLMDet = ecntamov.listadodepartidasConsolidadas(Date.Parse(Me.txtdfecini.Text), Date.Parse(Me.txtdfecfin.Text), lccodofi, lcfuente)
            If Me.CheckBox4.Checked = True Then
                nomrepor = "crAuxiliar2.rpt"
            End If
            '
        Else
            dsLMDet = ecntamov.listadodepartidas(Date.Parse(Me.txtdfecini.Text), Date.Parse(Me.txtdfecfin.Text), lccodofi, lcfuente)
        End If

        Me.Imprime(nomrepor, dsLMDet, lcexportar)


    End Sub

    Private Sub ExportToExcel(ByVal dt As DataTable)
        Dim sb As New StringBuilder()
        Dim sw As New StringWriter(sb)
        Dim htw As New HtmlTextWriter(sw)
        Dim dg As New GridView

        dg.AllowPaging = False
        dg.PagerSettings.Visible = False
        dg.AutoGenerateColumns = True
        dg.RowStyle.HorizontalAlign = HorizontalAlign.Left

        Dim Page As New Page()
        Dim form As New HtmlForm()



        dg.DataSource = dt 'esta es una funcion que ya lo debes tener hecha, te tiene que retornar un datatabla para llenar tu grilla
        dg.DataBind()

        Page.EnableEventValidation = False

        Page.DesignerInitialize()

        Page.Controls.Add(form)
        form.Controls.Add(dg)

        Page.RenderControl(htw)

        Response.Clear()
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel"
        Response.AddHeader("Content-Disposition", "attachment;filename=Datos.xls")
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub
    Private Sub balanceGeneralDetallado(ByVal tipo As String)
        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lcexportar As String
        '
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcmesvig As String
        Dim lcyears As String

        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)

        lcexportar = Me.ddlexportar.SelectedValue
        '
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim



        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")

        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        classconta.pcyears = Left(lcyears, 4)
        classconta.pccierre = lccierre.Trim

        Dim lcnivel As String
        If Me.Checknivel.Checked = True Then
            lcnivel = "99"
        Else
            lcnivel = Me.CbxNivel.Value.Trim
        End If


        'If rbtn1.Checked = True Then
        '    If Checkdeta0.Checked = True Then
        dsbalance = classconta.GenComprobacionNivelconAuxiliares(ldfecha1, ldfecha2, "bc", lcnivel)

        '    Else
        '        dsbalance = classconta.GenComprobacionNivel(ldfecha1, ldfecha2, "bc", lcnivel)
        '    End If

        'Else
        'dsbalance = classconta.GenComprobacion(ldfecha1, ldfecha2, "bc")
        'End If

        If dsbalance Is Nothing Then
            Return
        End If
        Dim ds As New DataSet
        ds = classconta.AnexaAuxiliares(dsbalance)



        If Checknivel0.Checked = True Then
            Dim dsdatos As New DataSet
            dsdatos = classconta.NivelOfi(ds, 0)

            Me.Imprime("crbalancegeneral.rpt", dsdatos, lcexportar)
        Else
            If Checkdeta0.Checked = True Then
                Dim dsdatos As New DataSet
                dsdatos = classconta.NivelOfi(ds, 1)
                Me.Imprime("crbalancegeneral.rpt", dsdatos, lcexportar)

            Else
                Me.Imprime("crbalancegeneral.rpt", ds, lcexportar)
            End If

        End If





    End Sub
    Public Sub ImprimePartida()
        Dim cClsAdP As New SIM.BL.ClsAdPart
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
        Dim ectbmcta As New cCtbmcta

        dsDes = ectbmcta.PartidaFiltrada(Me.txtcnumpar.Text.Trim, IIf(CheckBox2.Checked = True, "00", cbxfondos.Value), IIf(CheckBox1.Checked = True, "000", CbxCodOFi.Value.Trim))

        nCanti = dsDes.Tables(0).Rows.Count

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()


        Dim reportes As String
        reportes = "RptPartida.pdf"

        Dim lcfondos As String = ""
        Dim lcusuario As String = ""
        Dim etabttab As New cTabttab
        Dim etabtusu As New cTabtusu
        Dim lcpoliza As String = ""
        If dsDes.Tables(0).Rows.Count = 0 Then
            lcfondos = ""
        Else
            If IsDBNull(dsDes.Tables(0).Rows(0)("ffondos")) Then

            Else
                lcfondos = etabttab.Describe(Trim(dsDes.Tables(0).Rows(0)("ffondos")), "033")
                lcusuario = etabtusu.usuario(Trim(dsDes.Tables(0).Rows(0)("ccodusu")))
                lcpoliza = dsDes.Tables(0).Rows(0)("cpoliza")
            End If

        End If




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
    Public Function BalanceEspecial()

        Dim classconta As New clsConta
        Dim dsbalance As New DataSet
        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        Dim lccodofi As String
        Dim lcfuente As String
        Dim lcexportar As String
        lcexportar = Me.ddlexportar.SelectedValue
        If Me.CheckBox1.Checked = True Then
            lccodofi = "000"
        Else
            lccodofi = Me.CbxCodOFi.Value
        End If
        If Me.CheckBox2.Checked = True Then
            lcfuente = "00"
        Else
            lcfuente = Me.cbxfondos.Value
        End If

        ldfecha1 = Date.Parse(Me.txtdfecini.Text.Trim)
        ldfecha2 = Date.Parse(Me.txtdfecfin.Text.Trim)
        classconta.dFecfin = Me.txtdfecfin.Text
        classconta.pcnomser = Session("gcnomser")
        Dim lcmesvig As String
        Dim lcyears As String

        Dim lcnivel As String
        If Me.Checknivel.Checked = True Then
            lcnivel = "99"
        Else
            lcnivel = Me.CbxNivel.Value.Trim
        End If


        lcmesvig = Session("gcyears")
        lcyears = Left(lcmesvig, 4)
        classconta.pcyears = Left(lcyears, 4)
        classconta.pcCodofi = lccodofi
        classconta.pcFuente = lcfuente
        Dim lccierre As String
        lccierre = Me.txtcierre.Text.Trim
        classconta.pccierre = lccierre.Trim
      
        dsbalance = classconta.GenComprobacionNivelconAuxiliares(ldfecha1, ldfecha2, "bc", lcnivel)
      

        Me.TextBox1.Text = classconta.pnsalini
        Me.TextBox2.Text = classconta.pnsalfin
        Me.TextBox3.Text = classconta.pndebe
        Me.TextBox4.Text = classconta.pnhaber



        '------------------------------------------------------------------------------
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        'Iniciar un nuevo libro en Excel. 
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add
        'Agregar datos a las celdas de la primera hoja de cálculo del libro nuevo. 
        oSheet = oBook.Worksheets(1)

        Dim lnsaldo As Decimal = 0
        Dim lnsaldo1 As Decimal = 0
        Dim lnsaldo2 As Decimal = 0
        Dim lnsaldo3 As Decimal = 0
        Dim lnsaldo4 As Decimal = 0
        Dim lnsaldo5 As Decimal = 0

        oSheet.Range("B5").Value = "ACTIVO"
        oSheet.Range("B6").Value = "DISPONIBILIDADES"
        oSheet.Range("H5").Value = "PASIVO"
        oSheet.Range("H6").Value = "CUENTAS POR PAGAR"


        oSheet.Range("B5:H6").Font.Bold = True

        lnsaldo3 = classconta.ObtenerSaldoFinal(dsbalance, "101101")
        oSheet.Range("B8").Value = "Caja"
        oSheet.Range("D8").Value = lnsaldo3


        oSheet.Range("B9").Value = "Bancos"
        oSheet.Range("B10").Value = "Cuentas en moneda nacional"
        lnsaldo1 = classconta.ObtenerSaldoFinal(dsbalance, "101103")
        oSheet.Range("C10").Value = lnsaldo1

        lnsaldo2 = classconta.ObtenerSaldoFinal(dsbalance, "1016")
        oSheet.Range("B11").Value = "Cuentas en moneda extranjera"
        oSheet.Range("C11").Value = lnsaldo2

        oSheet.Range("D11").Value = lnsaldo1 + lnsaldo2
        oSheet.Range("E11").Value = lnsaldo1 + lnsaldo2 + lnsaldo3

        '----------------------------------------------------------------
        lnsaldo = 0
        lnsaldo1 = 0
        lnsaldo2 = 0
        lnsaldo3 = 0
        lnsaldo4 = 0
        lnsaldo5 = 0

        oSheet.Range("B13").Value = "INVERSIONES CORTO PLAZO"
        oSheet.Range("B13").Font.Bold = True
        oSheet.Range("B14").Value = "Banco Industrial"
        lnsaldo1 = classconta.ObtenerSaldoFinal(dsbalance, "1026010204")
        oSheet.Range("D14").Value = lnsaldo1

        oSheet.Range("B15").Value = "Banco G&T Continental, S.A."
        lnsaldo2 = classconta.ObtenerSaldoFinal(dsbalance, "1026010201")
        oSheet.Range("D15").Value = lnsaldo2

        oSheet.Range("B16").Value = "Banco Reformador, S.A."
        lnsaldo3 = classconta.ObtenerSaldoFinal(dsbalance, "1026010203")
        oSheet.Range("D16").Value = lnsaldo3

        oSheet.Range("B17").Value = "Financiera de Occidente, S.A."
        lnsaldo4 = classconta.ObtenerSaldoFinal(dsbalance, "1026010207")
        oSheet.Range("D17").Value = lnsaldo4

        oSheet.Range("E17").Value = lnsaldo1 + lnsaldo2 + lnsaldo3 + lnsaldo4

        oSheet.Range("B19").Value = "INVERSIONES LARGO PLAZO"
        oSheet.Range("B19").Font.Bold = True

        oSheet.Range("B20").Value = "FADEVI"

        oSheet.Range("B22").Value = "CARTERA DE CRÉDITOS"
        oSheet.Range("B22").Font.Bold = True
        lnsaldo = 0
        lnsaldo1 = 0
        lnsaldo2 = 0
        lnsaldo3 = 0
        lnsaldo4 = 0
        lnsaldo5 = 0

        oSheet.Range("B23").Value = "Vigentes al Día (primer piso)"


        lnsaldo1 = classconta.ObtenerSaldoFinal(dsbalance, "1031010104")
        lnsaldo2 = classconta.ObtenerSaldoFinal(dsbalance, "103101")
        oSheet.Range("C23").Value = lnsaldo2 - lnsaldo1

        oSheet.Range("B24").Value = "Vigentes al Día (segundo piso)"
        oSheet.Range("C24").Value = lnsaldo1

        oSheet.Range("B25").Value = "Vigentes en Mora"
        lnsaldo3 = classconta.ObtenerSaldoFinal(dsbalance, "103102")
        oSheet.Range("D25").Value = lnsaldo3

        oSheet.Range("B26").Value = "Vencidos"
        lnsaldo4 = classconta.ObtenerSaldoFinal(dsbalance, "103103")
        oSheet.Range("D26").Value = lnsaldo4

        oSheet.Range("B27").Value = "Estimación Val. Cartera Créditos"

        lnsaldo = 0
        lnsaldo1 = 0
        lnsaldo2 = 0
        lnsaldo3 = 0
        lnsaldo4 = 0
        lnsaldo5 = 0

        oSheet.Range("B34").Value = "CUENTAS POR COBRAR"
        oSheet.Range("B34").Font.Bold = True

        oSheet.Range("B35").Value = "Deudores Varios"
        lnsaldo1 = classconta.ObtenerSaldoFinal(dsbalance, "104101")
        oSheet.Range("D35").Value = lnsaldo1

        oSheet.Range("B36").Value = "Productos Financieros por cobrar sobre Inversiones"

        oSheet.Range("B37").Value = "Productos Financieros por Cobrar"

        oSheet.Range("B40").Value = "ACTIVOS FIJOS"
        oSheet.Range("B40").Font.Bold = True

        oSheet.Range("B41").Value = "Inmuebles"
        oSheet.Range("B42").Value = "Dep. Acumulada"
        oSheet.Range("B43").Value = "Mobiliario, Equipo y Vehículos"
        oSheet.Range("B44").Value = "Dep. Acumulada"

        oSheet.Range("B47").Value = "OTROS ACTIVOS"
        oSheet.Range("B47").Font.Bold = True

        oSheet.Range("B48").Value = "Gastos Anticipados"
        oSheet.Range("B49").Value = "Activos Extraordinarios"
        oSheet.Range("B50").Value = "Gastos por Amortizar"

        oSheet.Range("B51").Value = "          Total Activo"
        oSheet.Range("B51").Font.Bold = True

        oSheet.Range("H7").Value = "Obligaciones Inmediatas"
        oSheet.Range("H8").Value = "Gastos Financieros por Pagar"
        oSheet.Range("H9").Value = "Ingresos por Aplicar"
        oSheet.Range("H10").Value = "Donaciones por Aplicar"

        oSheet.Range("H13").Value = "PRESTAMOS A CORTO PLAZO"
        oSheet.Range("H13").Font.Bold = True

        oSheet.Range("H15").Value = "Banco G&T Continental, S.A."
        oSheet.Range("H16").Value = "Banco Reformador, S.A"
        oSheet.Range("H17").Value = "Financiera de Occidente, S.A."

        oSheet.Range("H22").Value = "PRESTAMOS A LARGO PLAZO"
        oSheet.Range("H22").Font.Bold = True

        oSheet.Range("H23").Value = "Bank Im Bistum Essen"
        oSheet.Range("H24").Value = "Incofin"
        oSheet.Range("H25").Value = "Triple Jump"
        oSheet.Range("H26").Value = "Fideicomiso para el Desarrollo Local en Guatemala"

        oSheet.Range("H27").Value = "Banco Industrial, S.A."
        oSheet.Range("H28").Value = "Banco Reformador, S.A."
        oSheet.Range("H29").Value = "Banco G&T Continental, S.A."
        oSheet.Range("H30").Value = "Triodos Bank"
        oSheet.Range("H31").Value = "Fundación Adam´s"
        oSheet.Range("H32").Value = "Banco Interamericano de Desarrollo"
        'oSheet.Range("H33").Value = "Fideicomiso para el Desarrollo Local en Guatemala"
        oSheet.Range("H35").Value = "OTROS PASIVO"
        oSheet.Range("H35").Font.Bold = True

        oSheet.Range("H36").Value = "Prestaciones Laborales"
        oSheet.Range("H37").Value = "Prod. Financieros Devengados no Percibidos"

        oSheet.Range("H38").Value = "Total Pasivo"
        oSheet.Range("H38").Font.Bold = True

        oSheet.Range("H40").Value = "PATRIMONIO"
        oSheet.Range("H40").Font.Bold = True

        oSheet.Range("H41").Value = "APORTES INICIALES"
        oSheet.Range("H41").Font.Bold = True

        oSheet.Range("H44").Value = "RESULTADOS"
        oSheet.Range("H44").Font.Bold = True

        oSheet.Range("H45").Value = "Saldo de Ejercicios Anteriores"
        oSheet.Range("H46").Value = "Superávit por Revaluación de Activos "
        oSheet.Range("H47").Value = "Resultado del Ejercicio"

        oSheet.Range("H50").Value = "Total Patrimonio"
        oSheet.Range("H50").Font.Bold = True

        oSheet.Range("H51").Value = "          Suma Pasivo y Patrimonio"
        oSheet.Range("H51").Font.Bold = True

        'Guardar el libro y cerrar Excel. 
        oBook.SaveAs("C:\txt\" & "Balance_" & Session("gccodusu") & ".xls")
        oSheet = Nothing
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing
        GC.Collect()

        'Dim LibroTrabajo As Object
        'Dim Fichero As String

        'Fichero = "C:\txt\" & "Book1.xls" 'con el path correspondiente
        'LibroTrabajo = GetObject(Fichero)
        'LibroTrabajo.Application.Windows("Book1.xls").Visible = True

        Dim lcnombre As String

        lcnombre = "Balance_" & Session("gccodusu") & ".xls"

        Dim FilePath As String = "c:/txt/" & lcnombre.Trim
        Try
            Me.DownloadFile(FilePath, lcnombre.Trim)
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Problemas al Abrir Archivo, Podria estar Abierto')</script>")
        End Try

    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        BalanceEspecial()
    End Sub

    Private Sub cargayears()
        Dim clscntaprm As New SIM.BL.cCntaprm
        Dim mlistacntaprm As New listacntaprm


        clscntaprm.cfondo = "99"
        mlistacntaprm = clscntaprm.ObtenerListaPorIDyear()

        Me.cbxanos.DataTextField = "año"
        Me.cbxanos.DataValueField = "cmesvig"
        Me.cbxanos.DataSource = mlistacntaprm
        Me.cbxanos.DataBind()
    End Sub
    Private Sub Activayear()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim ds1 As New DataSet
        Dim lcmesvigN As String
        Dim lcmesvig As String
        lcmesvig = cbxanos.SelectedValue.Trim

        Dim ecntaprm As New cCntaprm
        ds1 = ecntaprm.ObtenerDataSetPorID2("99")
        lcmesvigN = ds1.Tables(0).Rows(0)("cmesvig")

        Session("gcyears") = Left(cbxanos.SelectedValue.Trim, 4)

        Dim clssconta As New clsConta
        Dim ncanti As Integer = 0

        Dim entidadcntaprm As New cntaprm

        entidadcntaprm.cmesvig = lcmesvig
        ecntaprm.ObtenerCntaprm(entidadcntaprm)


        Me.txtdfecini.Text = entidadcntaprm.dfecimes
        Me.txtdfecfin.Text = entidadcntaprm.dfecfmes

        If lcmesvig.Trim = lcmesvigN.Trim Then
            Me.Antes.Visible = False
            Me.Despues.Visible = False
            Me.txtcierre.Text = "0"
        Else

            Me.Antes.Visible = True
            Me.Despues.Visible = True
            Me.txtcierre.Text = "1"
        End If

    End Sub

    Protected Sub cbxanos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxanos.SelectedIndexChanged
        Activayear()
    End Sub




    Private Sub Genera_Dispersion(ByVal pdfechaini As Date, ByVal pdfechfin As Date)
        Dim ds As New DataSet
        Dim lnRetorno As Integer = 0
        Dim mcremcre As New cCremcre
        Dim mcredkar As New cCredkar

        ds = mcremcre.Extrae_Datos_Arhivo_Dispersion(pdfechaini, pdfechfin, 0)

        If ds.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No hay nada que dispersar, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        'Actualiza Dispersión, para que no la llame de nuevo
        lnRetorno = mcredkar.Actualiza_Dispersion(ds)

        If lnRetorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Error al Generar Archivo dispersador, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        Dispersion_Diaria(ds, pdfechfin)

    End Sub


    Private Sub Genera_Movimentos_Contables(ByVal pdfechaini As Date, ByVal pdfechfin As Date)
        Dim ds As New DataSet
        Dim lnRetorno As Integer = 0
        Dim mcredkar As New cCredkar

        ds = mcredkar.Genera_rutina_Exporta_Asientos(pdfechaini, pdfechfin, Session("gnIva"))

        If ds.Tables(0).Rows.Count = 0 Then
            codigoJs = "<script language='javascript'>alert('No hay nada que dispersar, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        'Actualiza Dispersión, para que no la llame de nuevo
        lnRetorno = mcredkar.Actualiza_Dispersion(ds)

        If lnRetorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Error al Generar Archivo dispersador, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

        Dispersion_Diaria(ds, pdfechfin)

    End Sub


    Private Sub Dispersion_Diaria(ByVal ds As DataSet, ByVal pdfecha As Date)
        'Variables para abrir el archivo en modo de escritura
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Dim ldfecha As Date = pdfecha
        Dim ldfecha_proceso As Date
        Dim lcdia_p As String = ""
        Dim lcmes_p As String = ""
        Dim lcano_p As String = ""

        Dim lcdia As String = IIf(ldfecha.Day.ToString.Trim.Length = 1, "0" & ldfecha.Day.ToString, ldfecha.Day.ToString)
        Dim lcmes As String = IIf(ldfecha.Month.ToString.Trim.Length = 1, "0" & ldfecha.Month.ToString, ldfecha.Month.ToString)
        Dim lcano As String = ldfecha.Year.ToString.Trim
        Dim lcnombre As String


        Try
            

            lcnombre = lcdia & lcmes & lcano & ".txt"

            Dim FilePath As String = "c:/txt/" & lcnombre


            'Verifica si existe el archivo en el server para Eliminarlo
            If System.IO.File.Exists(FilePath) Then
                System.IO.File.Delete(FilePath)
            End If

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.ASCII)


            'Analiza Fecha de Proceso para realizar la proyeccion
            Dim lndia_ As Integer = ldfecha.DayOfWeek

            Select Case lndia_
                Case 4    'Jueves
                    ldfecha_proceso = pdfecha.AddDays(4)
                Case 5    'Viernes  
                    ldfecha_proceso = pdfecha.AddDays(4)
                    'ldfecha_proceso = pdfecha.AddDays(5)
                Case Else  'Otro Dia
                    ldfecha_proceso = pdfecha.AddDays(2)
            End Select


            lcdia_p = IIf(ldfecha_proceso.Day.ToString.Trim.Length = 1, "0" & ldfecha_proceso.Day.ToString, _
                          ldfecha_proceso.Day.ToString)
            lcmes_p = IIf(ldfecha_proceso.Month.ToString.Trim.Length = 1, "0" & ldfecha_proceso.Month.ToString, _
                          ldfecha_proceso.Month.ToString)
            lcano_p = ldfecha_proceso.Year.ToString.Trim


            'Se traen los datos que necesitamos para el archivo
            'TraerDatosArchivo retorna un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto

            Dim dr As DataRow
            Dim ID_Empresa As String = "1000090541445"
            Dim secuencia As String = "0001"
            Dim nombre_Empresa As String = Session("GCNOMINS")
            Dim Descrip_Archivo As String
            Dim lcdecimal As String
            Dim lntamano As Integer



            Dim Tipo_Registro As String = "3"
            Dim Tipo_Operacion As String = "07"
            Dim Sucursal As String = "0870"
            Dim Emisor As String = "48"
            Dim Naturaleza As String = "09"
            Dim pcMonto As String = ""
            Dim Espacios As String = ""
            Dim Espacios_0 As String = ""
            Dim Espacios_1 As String = ""
            Dim Espacios_2 As String = ""
            Dim Espacios_3 As String = ""
            Dim Espacios_4 As String = ""
            Dim Espacios_5 As String = ""
            Dim Beneficiario As String = ""
            Dim Banco As String = "0002"
            Dim Moneda As String = "001"
            Dim pNoIFE As String = ""
            Dim Dato_Banamex_1 As String = "1"
            Dim Dato_Banamex_2 As String = "2"
            Dim fecha_infor As String = lcdia & lcmes & lcano
            Dim fecha_infor_proyec As String = lcdia_p & lcmes_p & lcano_p
            Dim Otros_Banco = "00000000000099"

            Dim Cierre_Banco = "0000"
            Dim pnMonto_Total As Double
            Dim pnRegistro_Total As Double
            Dim Linea_Final As String = "4001"
            Dim pcNoRegistro As String = ""
            Dim pcMonto_Total As String = ""
            Dim pcCargos As String = "000001"
            Dim pcCtaBanco As String = "5783795"
            Dim agencia As String = Session("GCCTABCO")
            Dim lnEntero As Integer
            Dim lndecimal As Integer




            Descrip_Archivo = "//MD" & fecha_infor
            Descrip_Archivo = clsppal.zeros(Descrip_Archivo.Trim, 20)
            nombre_Empresa = clsppal.zeros(nombre_Empresa.Trim, 36)

            'Cantidad de Registros
            If Not IsDBNull(ds.Tables(0).Compute("count(ccodcta)", "")) Then
                pnRegistro_Total = ds.Tables(0).Compute("count(ccodcta)", "")
            End If

            pcNoRegistro = pnRegistro_Total.ToString.Trim
            pcNoRegistro = clsppal.fxStrZero(pcNoRegistro.Trim, 6)


            'Suma el Monto Total a Dispersar
            If Not IsDBNull(ds.Tables(0).Compute("sum(ncapdes)", "")) Then
                pnMonto_Total = ds.Tables(0).Compute("sum(ncapdes)", "")
            End If

            lnEntero = Math.Truncate(pnMonto_Total)
            'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

            lndecimal = clsConvert.ExtraeDecimales(lnEntero.ToString.Trim)

            'Convertira a 2 digitos los decimales
            lcdecimal = lndecimal.ToString.Trim
            lntamano = lcdecimal.Length
            For n = 1 To 2 - lntamano
                lcdecimal = "0" + lcdecimal
            Next n

            pcMonto_Total = lnEntero.ToString.Trim + lcdecimal

            pcMonto_Total = clsppal.fxStrZero(pcMonto_Total.Trim, 18)
            pcCtaBanco = clsppal.fxStrZero(pcCtaBanco.Trim, 20)
            agencia = clsppal.fxStrZero(agencia.Trim, 4)
            pcCtaBanco = clsppal.fxStrZero(pcCtaBanco.Trim, 20)

            Espacios_0 = clsppal.zeros(Espacios_0.Trim, 40)
            Espacios_5 = clsppal.zeros(Espacios_5.Trim, 20)


            'Inserta Primera Linea
            'strStreamWriter.WriteLine(ID_Empresa.ToString.Trim & fecha_infor & secuencia & nombre_Empresa & Descrip_Archivo & _
            '                          Naturaleza & Espacios_0 & "B01")


            strStreamWriter.WriteLine("1000090541445" & fecha_infor & secuencia & nombre_Empresa & Descrip_Archivo & _
                                      Naturaleza & Espacios_0 & "B01")



            'Insertar Linea No 2
            strStreamWriter.WriteLine(Dato_Banamex_2 & Dato_Banamex_1 & Moneda & pcMonto_Total & "01" & agencia & _
                                      pcCtaBanco & Espacios_5)


            For Each dr In ds.Tables(0).Rows

                'Convirtiendo Longitud de Campos
                Emisor = clsppal.zeros(Emisor.Trim, 16)


                lnEntero = Math.Truncate(dr("ncapdes"))
                'pcMonto_Total = Format(Math.Round(pnMonto_Total, 2), "#########.00")

                lndecimal = clsConvert.ExtraeDecimales(lnEntero.ToString.Trim)

                'Convertira a 2 digitos los decimales
                lcdecimal = lndecimal.ToString.Trim
                lntamano = lcdecimal.Length
                For n = 1 To 2 - lntamano
                    lcdecimal = "0" + lcdecimal
                Next n

                pcMonto = lnEntero.ToString.Trim + "." + lcdecimal


                'pcMonto = Format(Math.Round(dr("ncapdes"), 2), "#########.00")
                pcMonto = clsppal.fxStrZero_Alfa(pcMonto.Trim, 20)
                Espacios = clsppal.zeros(Espacios.Trim, 34)
                dr("cnomcli") = dr("cnomcli").ToString.Replace("Ñ", "N")
                Beneficiario = clsppal.zeros(dr("cnomcli").ToString.Trim, 55)
                Espacios_1 = clsppal.zeros(Espacios_1.Trim, 40)
                Espacios_2 = clsppal.zeros(Espacios_2.Trim, 6)
                pNoIFE = clsppal.zeros_Derecha(dr("id_ife").ToString.Trim, 20)
                Dato_Banamex_1 = clsppal.zeros(Dato_Banamex_1, 10)
                Dato_Banamex_2 = clsppal.zeros(Dato_Banamex_2, 10)
                Espacios_3 = clsppal.zeros(Espacios_3.Trim, 13)
                Espacios_4 = clsppal.zeros(Espacios_4.Trim, 31)

                'Escribimos la línea en el achivo de texto
                strStreamWriter.WriteLine(Tipo_Registro & Tipo_Operacion & Sucursal & Emisor & pcMonto & Espacios & _
                                          Beneficiario & Espacios_1 & Banco & Espacios_2 & Moneda & "1" & pNoIFE & Dato_Banamex_1 & _
                                          Dato_Banamex_2 & fecha_infor_proyec & Espacios_3 & Otros_Banco & Espacios_4 & Cierre_Banco)

            Next


            'Agrega fila final
            strStreamWriter.WriteLine(Linea_Final & pcNoRegistro & pcMonto_Total & pcCargos & pcMonto_Total)

            strStreamWriter.Close()

            Me.DownloadFile(FilePath, lcnombre.Trim)

            'Response.Write("<script language='javascript'>alert('El archivo se generó con éxito')</script>")


        Catch ex As Exception
            strStreamWriter.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class
