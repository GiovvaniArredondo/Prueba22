Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

'
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings






Partial Class ucreportesaho
    Inherits ucWBase


#Region " Variables "
    Private clsreportes As New SIM.BL.ClsAdRpt
    Private _dfecha1 As DateTime
    Private _dfecha2 As DateTime
    Private ds As New DataSet
#End Region


#Region "Propiedades"
    Public Property dfecha1() As DateTime
        Get
            Return _dfecha1
        End Get
        Set(ByVal Value As DateTime)
            _dfecha1 = Value
        End Set
    End Property
    Public Property dfecha2() As DateTime
        Get
            Return _dfecha2
        End Get
        Set(ByVal Value As DateTime)
            _dfecha2 = Value
        End Set
    End Property
#End Region


#Region " Metodos "

    Public Sub Inicio()
        Dim gdfecsis As DateTime
        gdfecsis = Session("gdfecsis")

        Me.txtfecha1.Text = gdfecsis
        Me.txtfecha2.Text = gdfecsis

    End Sub

    Public Sub Listas()
        '---------------------------
        ' tipos de ahorros
        '---------------------------
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("186", "1")

        Me.listtipaho.DataTextField = "cdescri"
        Me.listtipaho.DataValueField = "ccodigo"

        Me.listtipaho.DataSource = mListaTabttab
        Me.listtipaho.DataBind()

        '---------------------------
        'profesion
        '---------------------------
        Dim clsprofe As New SIM.BL.cTabtprf
        Dim listaprf As New listatabtprf

        listaprf = clsprofe.ObtenerLista()

        Me.Listprofesion.DataTextField = "cdescri"
        Me.Listprofesion.DataValueField = "ccodigo"
        Me.Listprofesion.DataSource = listaprf
        Me.Listprofesion.DataBind()

        '---------------------------
        'Genero
        '---------------------------
        mListaTabttab = clstabttab.ObtenerLista("003", "1")

        Me.ListSexo.DataTextField = "cdescri"
        Me.ListSexo.DataValueField = "ccodigo"
        Me.ListSexo.DataSource = mListaTabttab
        Me.ListSexo.DataBind()

        '---------------------------
        'Tipo de Cartera
        '---------------------------

        mListaTabttab = clstabttab.ObtenerLista("109", "1")

        Me.Listcartera.DataTextField = "cdescri"
        Me.Listcartera.DataValueField = "ccodigo"
        Me.Listcartera.DataSource = mListaTabttab
        Me.Listcartera.DataBind()

        'tasas
        Dim mahotlin As New cAhotlin
        Dim eahotlin As New ahotlin
        Dim listatasas As New listaahotlin
        listatasas = mahotlin.ObtenerLista()

        Me.Listtasa1.DataTextField = "ntasint"
        Me.Listtasa1.DataValueField = "ntasint"
        Me.Listtasa1.DataSource = listatasas
        Me.Listtasa1.DataBind()

    End Sub



    Public Sub Imprime(ByVal reportes As String, ByVal ds_R As DataSet)

        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim nCanti As Integer
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds_R.Tables(0))

        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub


#End Region

    '5 tablas
    Dim dttipaho As DataTable
    Dim dtprofesion As DataTable
    Dim dtsexo As DataTable
    Dim dtcartera As DataTable
    Dim dttasa As DataTable
    Dim dtsumario As DataTable
    Dim dsfiltro As New DataSet


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Listas()
            Me.Inicio()
        End If
    End Sub


    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Private Sub rbtmovaho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbtmovaho.Checked = True Then
            Me.rbtsumario.Checked = False
            Me.rbtcaraho.Checked = False
            Me.rbtprovpla.Checked = False
            Me.rbtintcert.Checked = False
            Me.rbtmovaho.Checked = True

            Me.listtipaho.Enabled = True
        End If
    End Sub

    Private Sub rbtsumario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbtsumario.Checked = True Then
            Me.rbtmovaho.Checked = False
            Me.rbtcaraho.Checked = False
            Me.rbtprovpla.Checked = False
            Me.rbtintcert.Checked = False
            Me.rbtsumario.Checked = True
            Me.listtipaho.Enabled = True

        End If

    End Sub

    Private Sub rbtcaraho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbtcaraho.Checked = True Then
            Me.rbtsumario.Checked = False
            Me.rbtmovaho.Checked = False
            Me.rbtprovpla.Checked = False
            Me.rbtintcert.Checked = False
            Me.rbtcaraho.Checked = True
            Me.listtipaho.Enabled = True

        End If

    End Sub

    Private Sub rbtprovpla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbtprovpla.Checked = True Then
            Me.rbtsumario.Checked = False
            Me.rbtmovaho.Checked = False
            Me.rbtcaraho.Checked = False
            Me.rbtintcert.Checked = False
            Me.rbtprovpla.Checked = True
            Me.listtipaho.Enabled = False

        End If

    End Sub

    Private Sub rbtintcert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.rbtintcert.Checked = True Then
            Me.rbtsumario.Checked = False
            Me.rbtmovaho.Checked = False
            Me.rbtcaraho.Checked = False
            Me.rbtprovpla.Checked = False
            Me.rbtintcert.Checked = True
            Me.listtipaho.Enabled = False

        End If

    End Sub


    Private Sub imprime_reportes()
        Try
            If dsfiltro Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsfiltro.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            'analiza los diferentes tipos de reportes
            If Me.rbtmovaho.Checked = True Then
                crRpt.Load(Server.MapPath("reportes") + "\crmovaho1.rpt", OpenReportMethod.OpenReportByDefault)
            ElseIf Me.rbtsumario.Checked = True Then
                crRpt.Load(Server.MapPath("reportes") + "\crintaho1.rpt", OpenReportMethod.OpenReportByDefault)
            ElseIf Me.rbtcaraho.Checked = True Then
                crRpt.Load(Server.MapPath("reportes") + "\crcaraho.rpt", OpenReportMethod.OpenReportByDefault)
            ElseIf Me.rbtprovpla.Checked = True Then
                crRpt.Load(Server.MapPath("reportes") + "\crcarpla1.rpt", OpenReportMethod.OpenReportByDefault)
            ElseIf Me.rbtintcert.Checked = True Then
                crRpt.Load(Server.MapPath("reportes") + "\crintcerp.rpt", OpenReportMethod.OpenReportByDefault)
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsfiltro.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub





    Private Sub chqtipaho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqtipaho.CheckedChanged
        'carga tabla de tipos de ahorros

        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.listtipaho.Items.Count

        Me.listtipaho.Enabled = True

        If Me.chqtipaho.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.listtipaho.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.listtipaho.Items(i).Selected = False
            Next
        End If

        '      Me.rbtmovaho.Checked = True

    End Sub

    Private Sub chqprofesion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqprofesion.CheckedChanged
        'carga tabla de tipos de ahorros

        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.Listprofesion.Items.Count

        Me.Listprofesion.Enabled = True

        If Me.chqprofesion.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.Listprofesion.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.Listprofesion.Items(i).Selected = False
            Next
        End If

    End Sub

    Private Sub chqsexo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqsexo.CheckedChanged
        'carga tabla de tipos de ahorros

        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.ListSexo.Items.Count

        Me.ListSexo.Enabled = True

        If Me.chqsexo.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.ListSexo.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.ListSexo.Items(i).Selected = False
            Next
        End If

    End Sub

    Private Sub chqcartera_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqcartera.CheckedChanged
        'carga tabla de tipos de ahorros

        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.Listcartera.Items.Count

        Me.Listcartera.Enabled = True

        If Me.chqcartera.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.Listcartera.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.Listcartera.Items(i).Selected = False
            Next
        End If



    End Sub

    Private Sub chqtasa1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chqtasa1.CheckedChanged
        'carga tabla de tipos de ahorros

        Dim lncuenta As Integer
        Dim i As Integer
        Dim lccodigo As String
        lncuenta = Me.Listtasa1.Items.Count

        Me.Listtasa1.Enabled = True

        If Me.chqtasa1.Checked = True Then
            For i = 0 To lncuenta - 1
                Me.Listtasa1.Items(i).Selected = True
            Next
        Else
            For i = 0 To lncuenta - 1
                Me.Listtasa1.Items(i).Selected = False
            Next
        End If

    End Sub

    Private Sub btnProcesa_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesa.ServerClick


        'crea dataset con filtros de cada tabla
        Dim dsunido As New DataSet
        Dim cls1 As New class1 'clsprincipal
        Dim AHO As New DataSet

        Dim lcampos As String
        Dim lctipos As String
        Dim lcnomtab As String

        Dim dr As DataRow

        'crea tablas desconectadas
        lcampos = "cdescri, ccodigo,"
        lctipos = "S,S,"
        lcnomtab = "tipaho"
        dttipaho = cls1.creadatasetdesconec(lcampos, lctipos, lcnomtab)
        lcnomtab = "profesion"
        dtprofesion = cls1.creadatasetdesconec(lcampos, lctipos, lcnomtab)
        lcnomtab = "sexo"
        dtsexo = cls1.creadatasetdesconec(lcampos, lctipos, lcnomtab)
        lcnomtab = "tasa"
        dttasa = cls1.creadatasetdesconec(lcampos, lctipos, lcnomtab)
        lcnomtab = "cartera"
        dtcartera = cls1.creadatasetdesconec(lcampos, lctipos, lcnomtab)

        'llama datos totales sin filtros
        Dim clsp As New class1
        Dim dsbase As New DataSet

        Dim ldfecha1 As Date
        Dim ldfecha2 As Date

        ldfecha1 = Date.Parse(Me.txtfecha1.Text)
        ldfecha2 = Date.Parse(Me.txtfecha2.Text)

        'elige el tipo de filtro para los reportes, por ejemplo si son carteras o movimientos

        If Me.rbtmovaho.Checked = True Then
            dsbase = clsp.reportesahorros_mov(ldfecha1, ldfecha2)
        ElseIf Me.rbtsumario.Checked = True Then
            dsbase = clsp.reportes_intereses_ahorros(ldfecha1, ldfecha2)
        ElseIf Me.rbtcaraho.Checked = True Then
            dsbase = clsp.reportesahorros()
        ElseIf Me.rbtprovpla.Checked = True Then
            dsbase = clsp.reportesahorros_pla()
        ElseIf Me.rbtintcert.Checked = True Then
            dsbase = clsp.reportes_intereses_ahorros_pla(ldfecha1, ldfecha2)
        End If


        'llena las tablas desconectadas con datos de captura
        Dim lncuenta As Integer
        Dim i As Integer
        Dim lcitem As String
        Dim indice As Integer
        Dim lcseleccion As String
        Dim lccodigo As String

        Dim dtfiltro As New DataTable
        Dim dtfiltro2 As New DataTable
        Dim dtfiltro3 As New DataTable
        Dim dtfiltro4 As New DataTable
        Dim dtfiltro5 As New DataTable

        Dim pcampos As String
        Dim ptipos As String
        Dim pnomtab As String
        Dim drfiltro As DataRow
        Dim sientro As Boolean
        Dim lncue As Integer


        pcampos = "cnomcli, ccodcli, ccodaho, nsaldoaho, producto, cdescri, cdeslin, ntasint, ccodpro, csexo, lactivo, nmonto, dfecope,"
        ptipos = "S,S,S,D,S,S,S,D,S,S,B,D,F,"
        pnomtab = "FILTRO"
        dtfiltro = clsp.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "FILTRO2"
        dtfiltro2 = clsp.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "FILTRO3"
        dtfiltro3 = clsp.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "FILTRO4"
        dtfiltro4 = clsp.creadatasetdesconec(pcampos, ptipos, pnomtab)

        pnomtab = "FILTRO5"
        dtfiltro5 = clsp.creadatasetdesconec(pcampos, ptipos, pnomtab)

        lncuenta = Me.listtipaho.Items.Count

        If Me.rbtprovpla.Checked = True Or rbtintcert.Checked = True Then

            'carga tabla de tipos de ahorro
            sientro = False
            lccodigo = "07"
            If dsbase.Tables(0).Rows.Count > 0 Then

                For Each drfiltro In dsbase.Tables(0).Rows
                    dr = dtfiltro.NewRow()
                    dr("cnomcli") = drfiltro("cnomcli")
                    dr("ccodcli") = drfiltro("ccodcli")
                    dr("ccodaho") = drfiltro("ccodaho")
                    dr("nsaldoaho") = drfiltro("nsaldoaho")
                    dr("producto") = drfiltro("producto")
                    dr("cdescri") = drfiltro("cdescri")
                    dr("cdeslin") = drfiltro("cdeslin")
                    dr("ntasint") = drfiltro("ntasint")
                    dr("ccodpro") = drfiltro("ccodpro")
                    dr("csexo") = drfiltro("csexo")
                    dr("lactivo") = drfiltro("lactivo")
                    dr("nmonto") = drfiltro("nmonto")
                    dr("dfecope") = drfiltro("dfecope")
                    sientro = True
                    dtfiltro.Rows.Add(dr)

                Next
            End If

        Else
            'carga tabla de tipos de ahorro
            sientro = False
            For i = 0 To lncuenta - 1
                If Me.listtipaho.Items(i).Selected Then
                    lccodigo = Me.listtipaho.Items.Item(i).Value.Trim
                    'incorpora datos filtrados a datasetdesconectado,ya que si se encuentran datos
                    For Each drfiltro In dsbase.Tables(0).Rows
                        If drfiltro("producto").trim = lccodigo Then
                            dr = dtfiltro.NewRow()
                            dr("cnomcli") = drfiltro("cnomcli")
                            dr("ccodcli") = drfiltro("ccodcli")
                            dr("ccodaho") = drfiltro("ccodaho")
                            dr("nsaldoaho") = drfiltro("nsaldoaho")
                            dr("producto") = drfiltro("producto")
                            dr("cdescri") = drfiltro("cdescri")
                            dr("cdeslin") = drfiltro("cdeslin")
                            dr("ntasint") = drfiltro("ntasint")
                            dr("ccodpro") = drfiltro("ccodpro")
                            dr("csexo") = drfiltro("csexo")
                            dr("lactivo") = drfiltro("lactivo")
                            dr("nmonto") = drfiltro("nmonto")
                            dr("dfecope") = drfiltro("dfecope")
                            dtfiltro.Rows.Add(dr)

                            '                            lnsuma = lnsuma + dr("nmonto")
                        End If
                    Next
                    'filtra la el tipo de reporte sumario, ya que es el unico concentrado

                End If
            Next

        End If



        'carga tabla de profesion
        lncuenta = Me.Listprofesion.Items.Count

        sientro = False
        For i = 0 To lncuenta - 1
            If Me.Listprofesion.Items(i).Selected Then
                lccodigo = Me.Listprofesion.Items.Item(i).Value.Trim
                For Each drfiltro In dtfiltro.Rows
                    If drfiltro("ccodpro").trim = lccodigo Then
                        dr = dtfiltro2.NewRow()
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("ccodaho") = drfiltro("ccodaho")
                        dr("nsaldoaho") = drfiltro("nsaldoaho")
                        dr("producto") = drfiltro("producto")
                        dr("cdescri") = drfiltro("cdescri")
                        dr("cdeslin") = drfiltro("cdeslin")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ccodpro") = drfiltro("ccodpro")
                        dr("csexo") = drfiltro("csexo")
                        dr("lactivo") = drfiltro("lactivo")
                        dr("nmonto") = drfiltro("nmonto")
                        dr("dfecope") = drfiltro("dfecope")

                        dtfiltro2.Rows.Add(dr)
                        lncue = dtfiltro2.Rows.Count

                    End If
                Next
            End If
        Next

        lncuenta = Me.ListSexo.Items.Count
        sientro = False


        'carga tabla de sexo
        For i = 0 To lncuenta - 1
            If Me.ListSexo.Items(i).Selected Then
                lccodigo = Me.ListSexo.Items.Item(i).Value.Trim
                lncue = dtfiltro2.Rows.Count
                For Each drfiltro In dtfiltro2.Rows
                    If drfiltro("csexo") = lccodigo Then
                        dr = dtfiltro3.NewRow()
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("ccodaho") = drfiltro("ccodaho")
                        dr("nsaldoaho") = drfiltro("nsaldoaho")
                        dr("producto") = drfiltro("producto")
                        dr("cdescri") = drfiltro("cdescri")
                        dr("cdeslin") = drfiltro("cdeslin")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ccodpro") = drfiltro("ccodpro")
                        dr("csexo") = drfiltro("csexo")
                        dr("lactivo") = drfiltro("lactivo")
                        dr("nmonto") = drfiltro("nmonto")
                        dr("dfecope") = drfiltro("dfecope")

                        dtfiltro3.Rows.Add(dr)
                    End If
                Next

            End If
        Next

        lncuenta = Me.Listcartera.Items.Count
        sientro = False
        Dim lcodigo As Boolean

        'carga tabla de cartera
        For i = 0 To lncuenta - 1
            If Me.Listcartera.Items(i).Selected Then
                lccodigo = Me.Listcartera.Items.Item(i).Value.Trim
                lcodigo = lccodigo

                For Each drfiltro In dtfiltro3.Rows
                    If drfiltro("lactivo") = lcodigo Then
                        dr = dtfiltro4.NewRow()
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("ccodaho") = drfiltro("ccodaho")
                        dr("nsaldoaho") = drfiltro("nsaldoaho")
                        dr("producto") = drfiltro("producto")
                        dr("cdescri") = drfiltro("cdescri")
                        dr("cdeslin") = drfiltro("cdeslin")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ccodpro") = drfiltro("ccodpro")
                        dr("csexo") = drfiltro("csexo")
                        dr("lactivo") = drfiltro("lactivo")
                        dr("nmonto") = drfiltro("nmonto")
                        dr("dfecope") = drfiltro("dfecope")

                        dtfiltro4.Rows.Add(dr)
                    End If
                Next

            End If
        Next


        lncuenta = Me.Listtasa1.Items.Count
        sientro = False

        'carga tabla tasas
        For i = 0 To lncuenta - 1
            If Me.Listtasa1.Items(i).Selected Then
                lccodigo = Me.Listtasa1.Items.Item(i).Value

                For Each drfiltro In dtfiltro4.Rows
                    If drfiltro("ntasint") = lccodigo Then
                        dr = dtfiltro5.NewRow()
                        dr("cnomcli") = drfiltro("cnomcli")
                        dr("ccodcli") = drfiltro("ccodcli")
                        dr("ccodaho") = drfiltro("ccodaho")
                        dr("nsaldoaho") = drfiltro("nsaldoaho")
                        dr("producto") = drfiltro("producto")
                        dr("cdescri") = drfiltro("cdescri")
                        dr("cdeslin") = drfiltro("cdeslin")
                        dr("ntasint") = drfiltro("ntasint")
                        dr("ccodpro") = drfiltro("ccodpro")
                        dr("csexo") = drfiltro("csexo")
                        dr("lactivo") = drfiltro("lactivo")
                        dr("nmonto") = drfiltro("nmonto")
                        dr("dfecope") = drfiltro("dfecope")

                        dtfiltro5.Rows.Add(dr)

                    End If
                Next
            End If
        Next

        dsfiltro.Tables.Add(dtfiltro5)
        imprime_reportes()


    End Sub
End Class


