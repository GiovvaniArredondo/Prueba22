Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO
Partial Class controles_WbActivoTraslados
    Inherits System.Web.UI.UserControl
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)

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

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cvariable As String
        Dim cvalor As Integer
        Dim dfecha As Date
        Dim ds As New DataSet
        Dim clsfind As New cActivoF
        Dim i As Integer

        If Me.rdbbusqueda.SelectedIndex = 0 Then
            'Buscqueda por descripcion
            cvalor = 1
        ElseIf Me.rdbbusqueda.SelectedIndex = 1 Then
            'Buscqueda por numero de inventario
            cvalor = 2
        ElseIf Me.rdbbusqueda.SelectedIndex = 2 Then
            'Buscqueda por numero de factura
            cvalor = 3
        ElseIf Me.rdbbusqueda.SelectedIndex = 3 Then
            'Buscqueda por fecha
            cvalor = 4
            dfecha = CDate(TxtNombre.Text.Trim)
        End If

        cvariable = TxtNombre.Text.Trim.ToUpper
        ds = clsfind.BuscaInventario(cvariable, cvalor, dfecha)

        i = ds.Tables(0).Rows.Count

        If i = 0 Then
            Response.Write("<script language='javascript'>alert('Consulta Vacía')</script>")
            Me.dgActivos.DataSource = ds
            Me.dgActivos.DataBind()
        Else
            Me.dgActivos.DataSource = ds
            Me.dgActivos.DataBind()
        End If
    End Sub

    Protected Sub dgActivos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgActivos.SelectedIndexChanged
        Dim xy As String
        xy = CType(Me.dgActivos.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text.Trim

        Dim entidadActivoF As New SIM.EL.ActivoF
        Dim eActivoF As New SIM.BL.cActivoF

        entidadActivoF.ccodinv = xy
        eActivoF.ObtenerActivoF(entidadActivoF)

        Me.txtInventario.Text = xy
        Me.txtFactura.Text = entidadActivoF.cnumdoc.Trim

        If entidadActivoF.nactdep = 1 Then
            Me.CheckBox1.Checked = True
        Else
            Me.CheckBox1.Checked = False
        End If
        Me.txtValorBien.Text = entidadActivoF.nvalcpa


        'Busca el activo en la tabla activomov 
        'y trae los datos de quien lo tiene cargado
        Dim entidadActivoM As New SIM.EL.ActivoM
        Dim eActivoM As New SIM.BL.cActivoM
        Dim i As Integer
        entidadActivoM.ccodinv = xy
        i = eActivoM.ObtenerActivoM(entidadActivoM)

        If i = 0 Then
            Return

        End If
        'Busca Nombre Oficina
        Dim entidadOficinas As New SIM.EL.tabtofi
        Dim eOficina As New SIM.BL.cTabtofi

        entidadOficinas.ccodofi = entidadActivoM.ccodofi
        eOficina.ObtenerTabtofi(entidadOficinas)
        txtCcodOfi.Text = entidadActivoM.ccodofi.Trim
        txtOficina.Text = entidadOficinas.cnomofi

        'Busca empleado
        Me.txtcodEmp.Text = entidadActivoM.ccodusu.Trim
        BuscaEmpleado()
        CargarDetalleActivoIT()
        ValidaPerfil()
        btnDescargar.Enabled = True
        btnTrasladar.Enabled = True
    End Sub

    Private Sub BuscaEmpleado()
        Dim entidadEmp As New SIM.EL.usuarios
        Dim eEmp As New SIM.BL.cusuarios

        'Dim ccodusu As String
        Dim cnombre As String
        cnombre = eEmp.ObtenerNombreUsuario(txtcodEmp.Text.Trim)
        txtIdUsuario.Text = entidadEmp.idUsuario
        Me.txtEmpleado1.Text = cnombre
    End Sub

    Private Sub CargarDetalleActivoIT()
        Dim entidadActivoIT As New SIM.EL.ActivoIT
        Dim eActivoIT As New SIM.BL.cActivoIT
        Dim ds As New DataSet
        Dim x, y As String
        entidadActivoIT.ccodinv = Me.txtInventario.Text.Trim
        eActivoIT.ObtenerActivoIT(entidadActivoIT)

        txtSeri.Text = entidadActivoIT.cnserie
        txtModelo.Text = entidadActivoIT.cmodelo
        txtDetalle.Text = entidadActivoIT.cdetall

        'Busca marca de equipo
        x = entidadActivoIT.ccodmar

        Dim entidadMarca As New SIM.EL.tabttab
        Dim eMarca As New SIM.BL.cTabttab

        entidadMarca.ccodtab = "228"
        entidadMarca.ctipreg = "1"
        entidadMarca.ccodigo = x
        eMarca.ObtenerTabttab(entidadMarca)

        txtMarca.Text = entidadMarca.cdescri

        'Busca linea del equipo
        y = entidadActivoIT.ccodlin
        Dim entidadLinea As New SIM.EL.tabttab
        Dim eLinea As New SIM.BL.cTabttab

        entidadLinea.ccodtab = "229"
        entidadLinea.ctipreg = "1"
        entidadLinea.ccodigo = y
        eLinea.ObtenerTabttab(entidadLinea)
        txtTipo.Text = entidadLinea.cdescri
    End Sub

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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargaUsuarios()
            CargarDatos()
        End If
    End Sub

    Private Sub ValidaPerfil()
        Dim eusuariogrupo As New cUsuarioGrupo
        Dim ds As New DataSet
        Dim lngrupos As String
        lngrupos = eusuariogrupo.RetornaGrupo(Session("gccodusu"))

        If lngrupos = "6" Or lngrupos = "4" Or lngrupos = "31" Or _
        lngrupos = "7" Then
            HabilitaCamposTraslado()
        End If
    End Sub

    Private Sub HabilitaCamposTraslado()
        cmbOficinas.Enabled = True
        cmbUsuarios.Enabled = True
    End Sub

    Private Sub DesHabilitaCamposTraslado()
        cmbOficinas.Enabled = False
        cmbUsuarios.Enabled = False
    End Sub

#Region " Metodos "
    Private Sub CargarDatos()
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
        Me.cmbOficinas.DataTextField = "cnomofi"
        Me.cmbOficinas.DataValueField = "cCodofi"
        Me.cmbOficinas.DataSource = ds.Tables("Resultado")
        Me.cmbOficinas.DataBind()
        ds.Tables("Resultado").Clear()
    End Sub
#End Region
#Region " Variables "
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clase As New SIM.BL.class1

    'Private lNuevo As Boolean
    Private Transacc As String
    Private ds As New DataSet

    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
#End Region

    Protected Sub btnTrasladar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTrasladar.Click
        btnDescargar.Enabled = False
        Traslado()
    End Sub

    Private Sub DescargarActivo()
        Dim ccodusu As String
        Dim ccodofi As String
        Dim ccodinv As String
        Dim dfectra As DateTime
        Dim cestado As String
        Dim ccargo As String
        Dim nserie As String


        'cesetado = 1 cargado
        'cestado = 2 descargado
        'cestado = 0 no cargado
        'cestado = 3 lo tuvo cargado

        Dim cEntidad As New SIM.BL.cActivoM
        Dim CActivoF As New SIM.BL.cActivoF

        ccodinv = txtInventario.Text.Trim
        ccodusu = txtcodEmp.Text.Trim
        ccodofi = txtCcodOfi.Text.Trim
        dfectra = Session("gdfecsis")
        cestado = "2" ' igual a descargado 

        'actualizar descargo registro de descargo movimientos
        CActivoF.DescargaActivoFijo("001", "DESC", ccodinv)  ' el descargo se lo carga a la central y usuario DESC  que significa descargado de la central.

        'Inserta registro de descargo movimientos
        cEntidad.DescargarActivo(ccodinv, ccodusu, ccodofi, dfectra, cestado)
        cEntidad.ActualizaActivoDescargado(ccodinv, ccodusu, ccodofi)


        btnTrasladar.Enabled = False
        btnBoleta.Enabled = True




        'Busca idGrupo
        Dim eUsuarioGrupo As New SIM.BL.cUsuarioGrupo
        Dim x As Integer
        btnDescargar.Enabled = False
        x = eUsuarioGrupo.RetornaGrupo(ccodusu)

        'Busca Grupo
        Dim entidadGrupos As New SIM.EL.grupos
        Dim eGrupos As New SIM.BL.cgrupos

        entidadGrupos.idGrupo = x
        eGrupos.Obtenergrupos(entidadGrupos)
        ccargo = entidadGrupos.codigoGrupo


        If txtSeri.Text.Trim = "" Then
            nserie = 0
        Else
            nserie = 1
        End If

        Dim dsbase1 As New DataSet
        dsbase1 = cEntidad.ConsultaActivoDescargado(ccodinv, ccodusu, ccodofi, dfectra, cestado, nserie)

        'Proceso de impresion de nota de descargo
        Dim lcexportar As String
        lcexportar = "PDF"
        Me.Imprime("crNotaDescargoActivo.rpt", dsbase1, lcexportar)


    End Sub
    Private Sub Traslado()
        Dim cActivoM As New SIM.BL.cActivoM
        Dim CActivoF As New SIM.BL.cActivoF
        Dim ccargo As String
        Dim nserie As String


        Dim ccodusu As String
        Dim ccodinv As String
        Dim ccodofi As String
        Dim dfectra As DateTime
        Dim cestado As String

        ccodinv = txtInventario.Text.Trim
        ccodusu = cmbUsuarios.SelectedValue
        ccodofi = cmbOficinas.SelectedValue
        dfectra = Session("gdfecsis")
        cestado = "1"  ' igual a traslado

        'actualizar descargo registro de descargo movimientos
        CActivoF.TrasladaActivoFijo(ccodofi, ccodusu, ccodinv)

        'Inserta registro de descargo movimientos
        cActivoM.Trasladar(ccodinv, ccodusu, ccodofi, dfectra, cestado)
        cActivoM.ActualizaActivoDescargado(ccodinv, ccodusu, ccodofi)

        btnTrasladar.Enabled = False
        btnBoleta.Enabled = True




        'Busca idGrupo
        Dim eUsuarioGrupo As New SIM.BL.cUsuarioGrupo
        Dim x As Integer
        btnDescargar.Enabled = False
        x = eUsuarioGrupo.RetornaGrupo(ccodusu)

        'Busca Grupo
        Dim entidadGrupos As New SIM.EL.grupos
        Dim eGrupos As New SIM.BL.cgrupos

        entidadGrupos.idGrupo = x
        eGrupos.Obtenergrupos(entidadGrupos)
        ccargo = entidadGrupos.codigoGrupo


        If txtSeri.Text.Trim = "" Then
            nserie = 0
        Else
            nserie = 1
        End If

        Dim dsbase1 As New DataSet
        dsbase1 = cActivoM.ConsultaActivoDescargado(ccodinv, ccodusu, ccodofi, dfectra, cestado, nserie)

        'Proceso de impresion de nota de descargo
        Dim lcexportar As String
        lcexportar = "PDF"
        Me.Imprime("crNotaEntregaActivo.rpt", dsbase1, lcexportar)


    End Sub

    Protected Sub btnDescargar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDescargar.Click
        Dim ccodusu As String
        Dim ccodofi As String
        Dim ccodinv As String
        Dim dfectra As DateTime
        Dim cestado As String
        Dim ccargo As String
        Dim nserie As String

        'cestado = 0 no cargado
        'cesetado = 1 cargado
        'cestado = 2 descargado
        'cestado = 3 lo tuvo cargado

        Dim cEntidad As New SIM.BL.cActivoM
        Dim CActivoF As New SIM.BL.cActivoF

        ccodinv = txtInventario.Text.Trim
        ccodusu = txtcodEmp.Text.Trim
        ccodofi = txtCcodOfi.Text.Trim
        dfectra = Session("gdfecsis")
        cestado = "2"  ' igual a descargado

        'actualizar descargo registro en la tabla de activos
        cActivoF.DescargaActivoFijo("001", "DESC", ccodinv)  ' el descargo se lo carga a la central y usuario DESC  que significa descargado de la central.

        'Inserta registro de descargo en los movimientos.
        cEntidad.DescargarActivo(ccodinv, ccodusu, ccodofi, dfectra, cestado)
        cEntidad.ActualizaActivoDescargado(ccodinv, ccodusu, ccodofi)

        'Busca idGrupo
        Dim eUsuarioGrupo As New SIM.BL.cUsuarioGrupo
        Dim x As Integer
        btnDescargar.Enabled = False
        x = eUsuarioGrupo.RetornaGrupo(ccodusu)

        'Busca Grupo
        Dim entidadGrupos As New SIM.EL.grupos
        Dim eGrupos As New SIM.BL.cgrupos

        entidadGrupos.idGrupo = x
        eGrupos.Obtenergrupos(entidadGrupos)
        ccargo = entidadGrupos.codigoGrupo


        If txtSeri.Text.Trim = "" Then
            nserie = 0
        Else
            nserie = 1
        End If

        Dim dsbase1 As New DataSet
        dsbase1 = cEntidad.ConsultaActivoDescargado(ccodinv, ccodusu, ccodofi, dfectra, cestado, nserie)

        'Proceso de impresion de nota de descargo
        Dim lcexportar As String
        lcexportar = "PDF"
        Me.Imprime("crNotaDescargoActivo.rpt", dsbase1, lcexportar)
    End Sub

    Public Sub Imprime(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ds As New DataSet
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim ldfecha1 As DateTime
        Dim lcexportar As String
        Dim tipo As String

        ldfecha1 = Session("GDFECSIS")

        Dim lndia As String = Day(ldfecha1)
        Dim lnmes As String = Month(ldfecha1)
        Dim lnano As String = Year(ldfecha1)

        Dim ldate As String = lndia + lnmes + lnano
        Dim lnombre As String = ldate.Trim


        Try
            If dsbase Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                Else
                    Me.AsignarMensaje("")
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        Dim a As String

        a = dsbase.Tables(0).TableName

        crRpt.SetDataSource(dsbase.Tables(a))
        'crRpt.SetParameterValue("dfechaini", ldfecha1)

        lcexportar = "PDF"

        If lcexportar = "XLS2" Then

        Else
            Select Case lcexportar
                Case "PDF"
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                    'tipo = "application/pdf"
                    'crRpt.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\txt\CheckListAgencias_" + lnombre + ".pdf")
                    'crRpt.Close()
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
            Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

            Response.BinaryWrite(rptStream.ToArray())
            Response.Flush()
            Response.Close()
            Response.End()
        End If

        dsbase.Tables(0).Clear()
        dsbase.Clear()
        btnDescargar.Enabled = False
    End Sub

    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub

    Protected Sub btnBoleta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBoleta.Click
        btnBoleta.Enabled = False
        Dim ccodusu As String
        Dim ccodofi As String
        Dim cestado As String
        Dim ccodinv As String
        Dim dfectra As DateTime
        Dim ccargo As String
        Dim nserie As String


        ccodinv = txtInventario.Text.Trim
        ccodusu = cmbUsuarios.SelectedValue.Trim
        ccodofi = cmbOficinas.SelectedValue.Trim
        dfectra = Session("gdfecsis")
        cestado = "1"

        Dim cEntidad As New SIM.BL.cActivoM

        'Inserta registro de descargo
        cEntidad.DescargarActivo(ccodinv, ccodusu, ccodofi, dfectra, cestado)
        cEntidad.ActualizaActivoDescargado(ccodinv, ccodusu, ccodofi)

        'Busca idGrupo
        Dim eUsuarioGrupo As New SIM.BL.cUsuarioGrupo
        Dim x As Integer

        btnDescargar.Enabled = False
        x = eUsuarioGrupo.RetornaGrupo(ccodusu)

        'Busca Grupo
        Dim entidadGrupos As New SIM.EL.grupos
        Dim eGrupos As New SIM.BL.cgrupos

        entidadGrupos.idGrupo = x
        eGrupos.Obtenergrupos(entidadGrupos)
        ccargo = entidadGrupos.codigoGrupo

        If txtSeri.Text.Trim = "" Then
            nserie = 0
        Else
            nserie = 1
        End If

        Dim dsbase1 As New DataSet
        dsbase1 = cEntidad.ConsultaActivoDescargado(ccodinv, ccodusu, ccodofi, dfectra, cestado, nserie)

        'Proceso de impresion de nota de descargo
        Dim lcexportar As String
        lcexportar = "PDF"
        Me.Imprime2("crNotaEntregaActivo.rpt", dsbase1, lcexportar)
    End Sub

    Public Sub Imprime2(ByVal reportes As String, ByVal dsbase As DataSet, ByVal pcexportar As String)
        Dim ds As New DataSet
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim ldfecha1 As DateTime
        Dim lcexportar As String
        Dim tipo As String

        ldfecha1 = Session("GDFECSIS")

        Dim lndia As String = Day(ldfecha1)
        Dim lnmes As String = Month(ldfecha1)
        Dim lnano As String = Year(ldfecha1)

        Dim ldate As String = lndia + lnmes + lnano
        Dim lnombre As String = ldate.Trim


        Try
            If dsbase Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                Else
                    Me.AsignarMensaje("")
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        Dim a As String

        a = dsbase.Tables(0).TableName

        crRpt.SetDataSource(dsbase.Tables(a))
        'crRpt.SetParameterValue("dfechaini", ldfecha1)

        lcexportar = "PDF"

        If lcexportar = "XLS2" Then

        Else
            Select Case lcexportar
                Case "PDF"
                    tipo = "application/pdf"
                    reportes &= ".pdf"
                    rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
                    Response.Clear()
                    Response.Buffer = True
                    'tipo = "application/pdf"
                    'crRpt.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\txt\CheckListAgencias_" + lnombre + ".pdf")
                    'crRpt.Close()
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
            Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

            Response.BinaryWrite(rptStream.ToArray())
            Response.Flush()
            Response.Close()
            Response.End()
        End If

        dsbase.Tables(0).Clear()
        dsbase.Clear()
        btnDescargar.Enabled = False
    End Sub
End Class
