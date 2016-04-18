Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.Data.SqlClient
Imports System.IO

Partial Class WUsGarant
    Inherits ucWBase

#Region " Variables "
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Private codigoJs As String
#End Region

#Region "Propiedades "
    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property
   
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
#End Region

#Region " Metodos "
    Public Sub CargarCombos()

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        'Tipo de Garantia
        mListaTabttab = clstabttab.ObtenerLista("037", "1")
        Me.cmbTipGar.DataTextField = "cdescri"
        Me.cmbTipGar.DataValueField = "ccodigo"
        Me.cmbTipGar.DataSource = mListaTabttab
        Me.cmbTipGar.DataBind()

        'Tipo de Descriptor
        mListaTabttab = clstabttab.ObtenerLista("044", "1")
        Me.cmbTipDes.DataTextField = "cdescri"
        Me.cmbTipDes.DataValueField = "ccodigo"
        Me.cmbTipDes.DataSource = mListaTabttab
        Me.cmbTipDes.DataBind()

        'Moneda
        mListaTabttab = clstabttab.ObtenerLista("007", "1")
        Me.cmbmoneda.DataTextField = "cdescri"
        Me.cmbmoneda.DataValueField = "ccodigo"
        Me.cmbmoneda.DataSource = mListaTabttab
        Me.cmbmoneda.DataBind()
        'Me.btnprint.Enabled = False

        TxtId.Text = "-"

        If cmbTipGar.SelectedValue.Trim = "03" Then
            'UpdatePanel1.Visible = True
        Else
            'UpdatePanel1.Visible = False
        End If
        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Departamento
        mTabtZon = clsTabtZon.ObtenerLista("1")
        Me.cmbDep.DataTextField = "cDesZon"
        Me.cmbDep.DataValueField = "cCodzon"
        Me.cmbDep.DataSource = mTabtZon
        Me.cmbDep.DataBind()

        'Municipio
        BuscaMunicipios()
        BuscaCantones()
        
        'TOPOGRAFIA
        mListaTabttab = clstabttab.ObtenerLista("126", "1")
        Me.cmbTopo.DataTextField = "cdescri"
        Me.cmbTopo.DataValueField = "ccodigo"
        Me.cmbTopo.DataSource = mListaTabttab
        Me.cmbTopo.DataBind()

        'uso del inmueble
        mListaTabttab = clstabttab.ObtenerLista("113", "1")
        Me.cmbuso.DataTextField = "cdescri"
        Me.cmbuso.DataValueField = "ccodigo"
        Me.cmbuso.DataSource = mListaTabttab
        Me.cmbuso.DataBind()

        'localidad demografica
        mListaTabttab = clstabttab.ObtenerLista("086", "1")
        Me.cmblocalidad.DataTextField = "cdescri"
        Me.cmblocalidad.DataValueField = "ccodigo"
        Me.cmblocalidad.DataSource = mListaTabttab
        Me.cmblocalidad.DataBind()

        'acceso
        mListaTabttab = clstabttab.ObtenerLista("118", "1")
        Me.cmbacceso.DataTextField = "cdescri"
        Me.cmbacceso.DataValueField = "ccodigo"
        Me.cmbacceso.DataSource = mListaTabttab
        Me.cmbacceso.DataBind()
        'Lista para cargar combo de BANCOS

        Dim clsbancos As New SIM.BL.cTabtbco
        Dim clstabtofi As New SIM.BL.cTabtofi

        Dim mlistainstitu As New listatabttab
        Dim mlistaoficina As New listatabtofi

        mlistainstitu = clstabttab.ObtenerLista("054", "1")
        mlistaoficina = clstabtofi.ObtenerListaporNivel(Session("gnNivel"), Session("gcCodOfi"))

        Dim dsb As New DataSet
        clsbancos.ObtenerDataSetPorID_Oficina_Tipo(dsb, Session("gcCodofi"), "RE")
        Me.DplBancos.DataTextField = "cnombco"
        Me.DplBancos.DataValueField = "ccodbco"
        Me.DplBancos.DataSource = dsb.Tables(0)
        Me.DplBancos.DataBind()

    End Sub

    Public Sub Imprime()
        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrGarant.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim eClimgar As New SIM.BL.cClimgar
        Dim nCanti As Integer
        Dim reportes As String
        reportes = "Garantias.pdf"
        'Crear aqui el dataset

        dsDes = eClimgar.ObtenerDataSetRepo(Me.TxtCodigo.Text.Trim) 'Me.TxtDocumento.Text.Trim

        nCanti = dsDes.Tables(0).Rows.Count

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Public Sub CargaFiador(ByVal codigoFiador As String)

        Me.TxtId.Text = codigoFiador

        If Me.TxtId.Text.Trim = "" _
            Or Me.TxtId.Text.Trim = Nothing Then
            Exit Sub
        End If
        'Evalua si la garantia es fiador para continuar
        If cmbTipGar.selectedvalue <> "01" Then
            codigoJs = "<script language='javascript'>alert('Debe Elegir el tipo de Garantía AVAL, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Me.TxtId.Text = ""
            Return
        End If

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.TxtId.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)

        Me.TxtDescri.Text = entidadClimide.cnomcli.Trim
        Me.TxtDescri.Enabled = False
        Me.TxtId.Enabled = False
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Dim gdfecsis As Date = Session("gdfecsis")

        Me.TxtCodigo.Text = codigoCliente

        If Me.TxtCodigo.Text.Trim = "" _
            Or Me.TxtCodigo.Text.Trim = Nothing Then
            Exit Sub
        End If

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.TxtCodigo.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)

        Me.txtNomcli.Text = entidadClimide.cnomcli.Trim

        Me.RefrescaGrid()

        Me.btngraba.Disabled = True
        Me.btnElimina.Disabled = True

    End Sub

    Public Sub RefrescaGrid()

        'Trae las Garantias del Cliente
        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar
        Dim ds As New DataSet
        Dim ncanti As Integer


        ds = eClimgar.ObtenerDataSetEspc(Me.TxtCodigo.Text.Trim)

        'Valida que no haya garantias pendientes que sean tipo 4 en climgar

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Me.grid_Garantia.DataSource = ds
            Me.grid_Garantia.DataBind()
            Me.grid_Garantia.Enabled = False

            Exit Sub
        End If
        
        Me.Grid_Garantia.DataSource = ds
        Me.Grid_Garantia.DataBind()
        
       
        Me.Grid_Garantia.Enabled = True 'desabilita el boton 
        Me.btnprint.Disabled = False



        ds.Tables.Clear()
    End Sub

    Public Sub DesHabilita()
        Me.cmbmoneda.Enabled = False
        Me.cmbTipDes.Enabled = False
        Me.cmbTipGar.Enabled = False
        Me.TxtDescri.Enabled = False
        Me.TxtId.Enabled = False
        Me.TxtMongas.Enabled = False
        Me.Txtmongrav.Enabled = False
        Me.TxtMontas.Enabled = False
        Me.btngraba.Disabled = True

        Me.txtnotario.Enabled = False
        Me.txtnumeropr.Enabled = False
        Me.txtfechaes.Enabled = False
        Me.txtlugares.Enabled = False

        'campos adicionales
        txtpropietario.Enabled = False
        txtprofinca.Enabled = False
        txtprofolio.Enabled = False
        txtprolibro.Enabled = False
        txtprode.Enabled = False
        txtprofecha.Enabled = False
        txtmunfinca.Enabled = False
        txtmunfolio.Enabled = False
        txtmunlibro.Enabled = False
        txtmunde.Enabled = False
        txtmunfecha.Enabled = False

        txtdireccion.Enabled = False
        txtespdir.Enabled = False
        txtespuso.Enabled = False
        txtniveles.Enabled = False
        txtespser.Enabled = False
        txtespamb.Enabled = False
        txtesptecho.Enabled = False
        txtesppiso.Enabled = False
        txtesppared.Enabled = False
        txtNmedida.Enabled = False
        txtNcolin.Enabled = False
        txtSmedida.Enabled = False
        txtScolin.Enabled = False
        txtEmedida.Enabled = False
        txtEcolin.Enabled = False
        txtOmedida.Enabled = False
        txtOcolin.Enabled = False
        txtlongitud.Enabled = False
        txtlatitud.Enabled = False
        txtfecavaluo.Enabled = False

        cmbDep.Enabled = False
        cmbMun.Enabled = False
        cmbcant.Enabled = False
        cmbTopo.Enabled = False
        cmbuso.Enabled = False
        cmblocalidad.Enabled = False
        cmbacceso.Enabled = False
        cmbservicios.Enabled = False
        cmbambientes.Enabled = False
        cmbtecho.Enabled = False
        cmbpiso.Enabled = False
        cmbparedes.Enabled = False

    End Sub

    Public Sub Limpiar()
        Me.TxtDescri.Text = " "
        Me.TxtId.Text = "-"
        Me.TxtMongas.Text = 0
        Me.Txtmongrav.Text = 0
        Me.TxtMontas.Text = 0
        Me.TxtComodin.Text = " "

        Me.txtnotario.Text = ""
        Me.txtnumeropr.Text = ""
        Me.txtfechaes.Text = Session("gdfecsis")
        Me.txtlugares.Text = ""

        'campos adicionales
        txtpropietario.Text = ""
        txtprofinca.Text = ""
        txtprofolio.Text = ""
        txtprolibro.Text = ""
        txtprode.Text = ""
        txtprofecha.Text = Session("gdfecsis")
        txtmunfinca.Text = ""
        txtmunfolio.Text = ""
        txtmunlibro.Text = ""
        txtmunde.Text = ""
        txtmunfecha.Text = Session("gdfecsis")

        txtdireccion.Text = ""
        txtespdir.Text = ""
        txtespuso.Text = ""
        txtniveles.Text = 1
        txtespser.Text = ""
        txtespamb.Text = ""
        txtesptecho.Text = ""
        txtesppiso.Text = ""
        txtesppared.Text = ""
        txtNmedida.Text = 0
        txtNcolin.Text = ""
        txtSmedida.Text = 0
        txtScolin.Text = ""
        txtEmedida.Text = 0
        txtEcolin.Text = ""
        txtOmedida.Text = 0
        txtOcolin.Text = ""
        txtlongitud.Text = 0
        txtlatitud.Text = 0
        txtfecavaluo.Text = Session("gdfecsis")
    End Sub

    Public Sub Habilita()
        Me.cmbmoneda.Enabled = True
        Me.cmbTipDes.Enabled = True
        Me.cmbTipGar.Enabled = True
        Me.TxtDescri.Enabled = True
        Me.TxtId.Enabled = False
        Me.TxtMongas.Enabled = True
        Me.TxtMontas.Enabled = True


        Me.txtnotario.Enabled = True
        Me.txtnumeropr.Enabled = True
        Me.txtfechaes.Enabled = True
        Me.txtlugares.Enabled = True

    

        'campos adicionales
        txtpropietario.Enabled = True
        txtprofinca.Enabled = True
        txtprofolio.Enabled = True
        txtprolibro.Enabled = True
        txtprode.Enabled = True
        txtprofecha.Enabled = True
        txtmunfinca.Enabled = True
        txtmunfolio.Enabled = True
        txtmunlibro.Enabled = True
        txtmunde.Enabled = True
        txtmunfecha.Enabled = True

        txtdireccion.Enabled = True
        txtespdir.Enabled = True
        txtespuso.Enabled = True
        txtniveles.Enabled = True
        txtespser.Enabled = True
        txtespamb.Enabled = True
        txtesptecho.Enabled = True
        txtesppiso.Enabled = True
        txtesppared.Enabled = True
        txtNmedida.Enabled = True
        txtNcolin.Enabled = True
        txtSmedida.Enabled = True
        txtScolin.Enabled = True
        txtEmedida.Enabled = True
        txtEcolin.Enabled = True
        txtOmedida.Enabled = True
        txtOcolin.Enabled = True
        txtlongitud.Enabled = True
        txtlatitud.Enabled = True
        txtfecavaluo.Enabled = True

        cmbDep.Enabled = True
        cmbMun.Enabled = True
        cmbcant.Enabled = True
        cmbTopo.Enabled = True
        cmbuso.Enabled = True
        cmblocalidad.Enabled = True
        cmbacceso.Enabled = True
        cmbservicios.Enabled = True
        cmbambientes.Enabled = True
        cmbtecho.Enabled = True
        cmbpiso.Enabled = True
        cmbparedes.Enabled = True

    End Sub

    Public Function BuscaGarantia(ByVal cCodigo As String, ByVal cCodgar As String) As DataSet
        Dim ds As New DataSet

        'Nombre del Cliente
        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar

        ds = eClimgar.ObtenerDataSetporcCodgar(cCodigo, cCodgar)

        Return ds
    End Function


#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarCombos()
            Me.DesHabilita()
        End If
    End Sub

    Private Sub TxtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.TextChanged

    End Sub

    Private Sub btnNew_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.ServerClick
        Me.Habilita()
        Me.btngraba.Disabled = False
        Me.btnNew.Disabled = True
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.Label1.Text = " "
        Me.Label2.Text = " "
        Limpiar()
        TxtId.Text = "-"

        Me.lblStatus.Text = ""

    End Sub
    'Cambios 29-07-2015
    'Valida Imagen que sea .jpg
    Private Function ValidaExtension(ByVal sExtension As String) As Boolean
        Select Case sExtension.ToUpper
            Case ".JPG"    ', ".png"
                Return True
            Case ".JPEG"
                Return True
            Case Else
                Return False
        End Select
    End Function
    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        'Evita que modifiquen garantias que ya fueron cargadas
        '-----------------------------------------------------
        Dim retorno As String
        Dim eClimgar2 As New SIM.BL.cClimgar
        retorno = eClimgar2.Obtener_estatus(Me.TxtCodigo.Text, Me.TxtComodin.Text)
        If retorno = "A" Or retorno = "P" Then
            codigoJs = "<script language='javascript'>alert('Esta Garantia no puede ser modificada \n" & _
                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        'fin -------------------------------------------------

        'Valida el tipo de garantia si es Liquida ocupara cargar la foto
        '-----------------------------------------------------
        Dim sExt As String
        If Me.cmbTipGar.SelectedValue.Trim = "04" Then
            If fileUpEx.HasFile Then
                sExt = Path.GetExtension(fileUpEx.FileName)
                If ValidaExtension(sExt.ToLower) = False Then
                    codigoJs = "<script language='javascript'>alert('Debe ser una foto con Extencion JPG " & _
                       "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    Exit Sub
                End If
            Else
                codigoJs = "<script language='javascript'>alert('Debe cargar la foto del Ticket o Comprobante, " & _
                       "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
        End If
        'Fin de validacion por tipo Garantia
        '---------------------------------------------------
        Dim lcCodgar As String = ""
        Dim cls As New SIM.BL.ClsGarant
        Dim lncentinela As Integer
        'pasa valor de ccodgar antes de liberar
        TxtCogar.Text = Me.TxtComodin.Text.Trim
        '-----------------------------
        ' Validaciones  Modificado 31 07 2015 Labels por JScripts
        '-----------------------------
        Try
            If Me.TxtId.Text.Trim = "" Or Me.TxtId.Text.Trim = Nothing _
           Or Me.TxtDescri.Text.Trim = "" Or Me.TxtDescri.Text.Trim = Nothing Then
                Me.Label1.Text = "Faltan Datos, Revise"
                Me.Label1.Visible = True
                Exit Sub
            Else
                Me.Label1.Text = " "
                Me.Label1.Visible = False
            End If

            If Me.TxtMongas.Text.Trim = "" Or Me.TxtMongas.Text.Trim = Nothing _
                Or Me.TxtMontas.Text.Trim = "" Or Me.TxtMontas.Text.Trim = Nothing Or Me.TxtMongas.Text <= 0 Or Me.TxtMontas.Text <= 0 Then

                codigoJs = "<script language='javascript'>alert('Faltan Datos, Revise, " & _
                      "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                'Me.Label1.Text = "Faltan Datos, Revise"
                'Me.Label1.Visible = True
                Exit Sub
            Else
                Me.Label1.Text = " "
                Me.Label1.Visible = False
            End If

            If Double.Parse(Me.TxtMontas.Text.Trim) > Double.Parse(Me.TxtMongas.Text.Trim) Then
                'Me.Label1.Text = "El monto de Tasacion no puede ser mayor "
                codigoJs = "<script language='javascript'>alert('El monto de Tasacion no puede ser mayor, " & _
                      "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                'Me.Label1.Visible = True
                Exit Sub
            Else
                Me.Label1.Text = " "
                Me.Label1.Visible = False
            End If

            If TxtCodigo.Text.Trim = TxtId.Text.Trim Then
                'Me.Label1.Text = "Cliente no puede ser Codeudor  El Mismo "
                'Me.Label1.Visible = True

                codigoJs = "<script language='javascript'>alert('Cliente no puede ser Codeudor  El Mismo, " & _
                      "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
                'Me.Label1.Text = " "
                Me.Label1.Visible = False
            End If
            '-------------------------------
            'Fin
            '-------------------------------
            'Valida garantia aval
            If Me.cmbTipGar.SelectedValue = "01" And Me.TxtId.Text.Trim.Length < 12 Then
                codigoJs = "<script language='javascript'>alert('Debe seleccionar un AVAl, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Return
            End If
            If Me.TxtComodin.Text.Trim = "" _
                       Or Me.TxtComodin.Text.Trim = Nothing Then 'Garantia Nueva
                Dim eClimgar As New SIM.BL.cClimgar
                lcCodgar = eClimgar.ObtenercCodgar(Me.TxtCodigo.Text.Trim)
                cls._ccodgar = lcCodgar
                cls._llBandera = True
            Else
                cls._ccodgar = Me.TxtComodin.Text.Trim
                cls._llBandera = False
            End If
            cls._ccodcli = Me.TxtCodigo.Text.Trim
            cls._ccoduni = Me.TxtId.Text.Trim
            cls._cmoneda = Me.cmbmoneda.SelectedValue.Trim
            cls._cdescri = Me.TxtDescri.Text.Trim
            cls._ctipdes = Me.cmbTipDes.SelectedValue.Trim
            cls._ctipgar = Me.cmbTipGar.SelectedValue.Trim
            cls._nmongar = Double.Parse(Me.TxtMongas.Text.Trim)
            cls._nmontas = Double.Parse(Me.TxtMontas.Text.Trim)
            cls._destado = Session("gdfecsis")
            cls._cCodusu = Session("gcCodusu")
            cls._nmongra = 0 'Math.Round(Double.Parse(Me.TxtMontas.Text.Trim) * Session("gnCobertura") / 100, 2)
            If Me.cmbTipGar.SelectedValue.Trim <> "01" Then
                cls._cnotario = Me.txtnotario.Text.ToUpper.Trim
                cls._nnumeropr = (txtnumeropr.Text.Trim)
                If txtfechaes.Text.Trim = "" Or txtfechaes.Text = Nothing Then
                    cls._dfechaes = #1/1/1980#
                Else
                    cls._dfechaes = Date.Parse(txtfechaes.Text)
                End If
                cls._clugares = txtlugares.Text.Trim
            Else
                cls._cnotario = ""
                cls._nnumeropr = ""
                cls._dfechaes = #1/1/1980#
                cls._clugares = ""
            End If
            'Campos adicionales
            cls._cpropietario = txtpropietario.Text.Trim
            cls._cprofinca = txtprofinca.Text.Trim
            cls._cprofolio = txtprofolio.Text.Trim
            cls._cprolibro = txtprolibro.Text.Trim
            cls._cprode = txtprode.Text.Trim
            If txtprofecha.Text.Trim = "" Or txtprofecha.Text = Nothing Then
                cls._dprofecha = #1/1/1980#
            Else
                cls._dprofecha = Date.Parse(txtprofecha.Text)
            End If
            cls._cmunfinca = txtmunfinca.Text.Trim
            cls._cmunfolio = txtmunfolio.Text.Trim
            cls._cmunlibro = txtmunlibro.Text.Trim
            cls._cmunde = txtmunde.Text.Trim
            If txtmunfecha.Text.Trim = "" Or txtmunfecha.Text = Nothing Then
                cls._dmunfecha = #1/1/1980#
            Else
                cls._dmunfecha = Date.Parse(txtmunfecha.Text)
            End If
            cls._cdireccion = txtdireccion.Text.Trim
            cls._cubica = cmbcant.SelectedValue.Trim
            cls._ctopo = cmbTopo.SelectedValue.Trim
            cls._cespdir = txtespdir.Text.Trim
            cls._cuso = cmbuso.SelectedValue.Trim
            cls._cespuso = txtespuso.Text.Trim
            cls._clocalidad = cmblocalidad.SelectedValue.Trim
            cls._nniveles = Integer.Parse(txtniveles.Text)
            cls._cacceso = cmbacceso.SelectedValue.Trim
            'Proceso especial para obtener items seleccionados
            Dim tronque As String = ""
            For i = 0 To 4
                If cmbservicios.Items(i).Selected = True Then
                    tronque = tronque + "1"
                Else
                    tronque = tronque + "0"
                End If
            Next
            cls._cservicios = tronque.Trim
            tronque = ""
            For i = 0 To 7
                If cmbambientes.Items(i).Selected = True Then
                    tronque = tronque + "1"
                Else
                    tronque = tronque + "0"
                End If
            Next
            cls._cambientes = tronque.Trim
            tronque = ""
            For i = 0 To 2
                If cmbtecho.Items(i).Selected = True Then
                    tronque = tronque + "1"
                Else
                    tronque = tronque + "0"
                End If
            Next
            cls._ctecho = tronque.Trim
            tronque = ""
            For i = 0 To 4
                If cmbpiso.Items(i).Selected = True Then
                    tronque = tronque + "1"
                Else
                    tronque = tronque + "0"
                End If
            Next
            cls._cpiso = tronque.Trim
            tronque = ""
            For i = 0 To 4
                If cmbparedes.Items(i).Selected = True Then
                    tronque = tronque + "1"
                Else
                    tronque = tronque + "0"
                End If
            Next
            cls._cparedes = tronque.Trim
            tronque = ""
            '-------------------------------------------------------------------
            cls._cespser = txtespser.Text.Trim
            cls._cespamb = txtespamb.Text.Trim
            cls._cesptecho = txtesptecho.Text.Trim
            cls._cesppiso = txtesppiso.Text.Trim
            cls._cesppared = txtesppared.Text.Trim
            cls._nnmedida = Decimal.Parse(txtNmedida.Text.Trim)
            cls._nncolin = (txtNcolin.Text.Trim)
            cls._nsmedida = Decimal.Parse(txtSmedida.Text.Trim)
            cls._nscolin = (txtScolin.Text.Trim)
            cls._nemedida = Decimal.Parse(txtEmedida.Text.Trim)
            cls._necolin = (txtEcolin.Text.Trim)
            cls._nomedida = Decimal.Parse(txtOmedida.Text.Trim)
            cls._nocolin = (txtOcolin.Text.Trim)
            cls._nlongitud = Double.Parse(txtlongitud.Text)
            cls._nlatitud = Double.Parse(txtlatitud.Text)
            cls._dfecval = Session("gdfecsis") 'Date.Parse(txtfecavaluo.Text)
            lncentinela = cls.GrabaGarantia()
            If lncentinela = 1 Then 'Proceso Correcto
                Me.RefrescaGrid()
                codigoJs = "<script language='javascript'>alert('Proceso generado con exito, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Dim clsppal As New class1
                clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "Gr", 4)
            Else                    'Genero Error

                codigoJs = "<script language='javascript'>alert('A ocurrido un error, contactar al proveedor, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                'Me.Label1.Text = "A ocurrido un error, contactar al proveedor"
                'Me.Label1.Visible = True
            End If
            Me.btngraba.Disabled = True
            Me.Limpiar()
            Me.DesHabilita()
            Me.btnNew.Disabled = False
        Catch ex As Exception
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error, Repita el Proceso, " & _
                   "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End Try
        'Modificado 14 07 2015 Fernando Abrego
        'Valida si usara los procesos de carga solo cuando es liquida
        '------------------------------------------------------------
        If Me.cmbTipGar.SelectedValue.Trim = "04" Then
            If lcCodgar Is Nothing Or lcCodgar = "" Then
                upload_Carga(TxtCogar.Text)
                cargarComprobante_Carp(TxtCogar.Text)
                'Inserta en cuentas Contables--- 29 07 2015
                'Busca id de garantia
                Dim id_identity_ As Integer
                'envia ccodgar y codigo cliente
                id_identity_ = eClimgar2.Obtener_identiy_climgar(Me.TxtCodigo.Text, Me.TxtCogar.Text)
                'Envia como dato el id de la garantia actual
                Inserta_CuentaMaestra(id_identity_) 'Insertando nuevo dato Id
                TxtCogar.Text = ""
            Else
                upload_Carga(lcCodgar)
                cargarComprobante_Carp(lcCodgar)
                'Inserta en cuentas Contables--- 29 07 2015
                Dim id_identity_ As Integer
                'envia ccodgar y codigo cliente
                id_identity_ = eClimgar2.Obtener_identiy_climgar(Me.TxtCodigo.Text, lcCodgar)
                Inserta_CuentaMaestra(id_identity_)
                TxtCogar.Text = ""
            End If
        End If
        'Fin ---------------------------------------------------------
        'Refresh al Grid de Garantias
        RefrescaGrid()
    End Sub
    'Carga Ticket a carpeta Upload
    '-- 29 07 2015 --Carga al Servidor
    Public Sub upload_Carga(ByVal ccodcgar As String)
        Dim pathGrabar As String
        Dim nombre_cli As String = txtNomcli.Text
        Dim sExt As String = String.Empty
        Dim sName As String = String.Empty
        sName = TxtCodigo.Text.Trim
        sExt = Path.GetExtension(fileUpEx.FileName)
        Try
            If Not fileUpEx Is Nothing Then
                Dim Archivo_ As String = fileUpEx.PostedFile.FileName
                sExt = Path.GetExtension(fileUpEx.FileName)
                'obtiene extension del archivo

                hfExtension.Value = System.IO.Path.GetExtension(fileUpEx.PostedFile.FileName)

                If ValidaExtension(hfExtension.Value.ToLower) Then
                    pathGrabar = Server.MapPath(".\uploads\" + nombre_cli & "-" & sName & "-" & ccodcgar & sExt.ToUpper)
                    fileUpEx.PostedFile.SaveAs(pathGrabar)
                    lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                    hfPathArchivo.Value = pathGrabar
                Else
                    codigoJs = "<script language='javascript'>alert('La fotografia no es extencion .JPG, " & _
                 "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                End If
            Else
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "No Existe Archivo a Subir"
            End If

        Catch ex As Exception
            codigoJs = "<script language='javascript'>alert('Error al Subir el Archivo, " & _
                 "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End Try
    End Sub
    'Registro en las Cuentas Contables  - 31 07 2015 - 
    'El id es de climgar -- inserta en  ahomcta, ahommov , cnumes,cntamov , Diario , aux ingresos
    Private Function Inserta_CuentaMaestra(ByVal id_identity As Integer) As String
        If id_identity = 0 Then

            codigoJs = "<script language='javascript'>alert('Ocurrio un error, no se regitro \n datos en las cuentas contables, " & _
                                          "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        Else
            'Bloque de variables -- Obtenemos datos para llenar variables
            Dim etabtbco As New cTabtbco
            Dim lcRetorno As String
            Dim eClimgar As New SIM.BL.cClimgar 'Clase utilizada para llegar a dbclimgar y usar propiedades de la Clase
            Dim buscar_Credito As String
            buscar_Credito = eClimgar.BuscarCredito_(TxtCodigo.Text.Trim) ' Busca un credito solo como referencia
            Dim busca_garantia As DataSet
            Dim garantia_Vacio As String = " "
            'busca datos de la garantia que fue registrada -- pendiente ""
            busca_garantia = eClimgar.ObtenerDatosCliente_(TxtCodigo.Text.Trim, garantia_Vacio)
            Dim ccodgar As String = ""
            Dim fecha_gar As Date
            Dim montos As String = ""
            Dim lccodcta As String = ""
            lccodcta = etabtbco.CuentaContableBanco(Me.DplBancos.SelectedValue.Trim)
            '-Define el tipo de cuenta ---
            Dim etabttab As New cTabttab
            Dim lcconcepto As String
            Dim lcdescri As String
            lcdescri = etabttab.Describe("Garantia Liquida", "117")
            lcconcepto = "POR COBRO DE " + "GARANTIA LIQUIDA" + " DEL DIA " + Date.Parse(fecha_gar).ToString.Replace("12:00:00 a.m.", "") + " / " + DplBancos.Text
            For Each row As DataRow In busca_garantia.Tables(0).Rows
                fecha_gar = (row("destado"))
                ccodgar = (row("ccodgar"))
                montos = (row("nmongar"))
            Next
            Dim Datos_Cert() As String = {Session("GDFECSIS"), Session("gccodofi"), _
                                        lcconcepto, "AR", Session("GDFECSIS"), _
                                        Session("gcCodusu"), "", "", "", Double.Parse(montos), _
                                        "", 0, "01", "", Session("gccodofi"), "", "", "", 0, _
                                        Double.Parse(montos), "", "", Session("gccontra"), _
                                        Me.TxtCodigo.Text.Trim, lccodcta}

            'fin ------------------------------------------------------
            'Inicia con la insercion y updates en las cuentas contables
            lcRetorno = eClimgar.Mantenimiento_Otros_Ingresos(Datos_Cert, buscar_Credito, Double.Parse(montos), _
                                                                        "04", Date.Parse(fecha_gar), _
                                                                        Session("gccodusu"), Me.txtNomcli.Text.Trim, Me.TxtCodigo.Text.Trim, _
                                                                        ccodgar, "A", id_identity)

            lcRetorno = lcRetorno

            If lcRetorno <> "" Then

                codigoJs = "<script language='javascript'>alert('Procesado con Exito, " & _
                                  "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Else
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                                             "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            End If
        End If

    End Function
    'Eliminar Garantia
    'Comentario: 
    'Hace diferencia entre las que son distintas a 04 Liquida , si son distintas solo elimina de climgar si es liquida realizar procesos de ajuste
    'en las cuentas contables ---
    Private Sub btnElimina_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.ServerClick
        'Validacion por fecha de eliminacion}
        Dim fechasistema As Date
        Dim FechaGarantia_ As Date
        Dim Dias_dif As Integer = 0
        Dim validaciondeUsuarios As Integer = 0
        Dim retiroEliminacionagarantia As Integer = 0

        FechaGarantia_ = FechaGarantia(TxtCodigo.Text, TxtComodin.Text)
        fechasistema = Revision_Fechas()


        Dias_dif = (FechaGarantia_ - fechasistema).Days

        Dias_dif = Dias_dif

        'QUE SEA MESA DE CONTROL 
        validaciondeUsuarios = ValidaUsauriosiaplicaFiveDays()

        retiroEliminacionagarantia = retirosCreditos(TxtCodigo.Text)

        '---------------------------------------------------------
        If validaciondeUsuarios = 0 Then '------------------------

            If retiroEliminacionagarantia = 1 Then

                codigoJs = "<script language='javascript'>alert('No puede eliminar garantias por que el cliente tiene un credito en \n Aprobado o Vigente, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub

            End If


            If Dias_dif <= -5 Then
                codigoJs = "<script language='javascript'>alert('No puede eliminar garantias con mas de 5 dias de antiguedad, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub

            End If

        End If '--------------------------------------------
        '-------------------------------------------

        Dim retorno_valP_entregada As String = ValidaGarantias(TxtCodigo.Text, TxtComodin.Text)

        If retorno_valP_entregada = "P" Then
            codigoJs = "<script language='javascript'>alert('No se puede eliminar una garantia con Estatus: Entregada, " & _
                                            "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        'Validacion inicial que exista la garantia a eliminar
        '-----------------------------------------------------
        Dim cls As New SIM.BL.ClsGarant
        Dim lncentinela As Integer
        TxtCogar.Text = TxtComodin.Text
        If Me.TxtComodin.Text.Trim = "" Or Me.TxtComodin.Text.Trim = Nothing Or TxtCogar.Text = "" Or TxtCogar.Text Is Nothing Then

            codigoJs = "<script language='javascript'>alert('Imposible Eliminar el registro, " & _
                  "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub

        Else
            Me.Label1.Text = " "
            Me.Label1.Visible = False
        End If
        'Fin -----------------------------------------------------
        'Validar tipo de garantia
        '---------------------------------------------------------
        If cmbTipGar.SelectedValue = "04" Then

            '''''Valida cantidad en garantias
            Dim cantidadsaldo As Decimal = SaldoCuenta(TxtCodigo.Text)
            Dim CantidadRetiro As Decimal = TxtMongas.Text


            If CantidadRetiro > cantidadsaldo Then
                codigoJs = "<script language='javascript'>alert('No puede eliminar esta garantia por que no tiene fondo suficiente, " & _
                                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub

            End If

            'Eliminacion cuando es tipo Liquida------Afecta en cuenta contables
            Dim Recibe_RespElim As String = ""
            Dim eClimgar_Elimina As New SIM.BL.cClimgar
            'Obtiene el Id para proceder la eliminacion de datos
            Dim obtiene_idClimgar As Integer
            'reusamos clase proceso enla clase  de retorno para el dato id climgar
            obtiene_idClimgar = eClimgar_Elimina.Obtener_identiy_climgar(Me.TxtCodigo.Text, Me.TxtCogar.Text)
            If obtiene_idClimgar = 0 Then

                codigoJs = "<script language='javascript'>alert('Ocurrio un error, \n Contacte al departamento de Sistemas, " & _
                                  "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
                'Entra a proceso de eliminacion -- LLenado de varibales--
                '---------------------------------------
                Dim ds As New DataSet
                Dim ecredkar As New cCredkar
                Dim ecntamov As New cCntamov
                Dim etabtbco As New cTabtbco
                Dim lverifica As Boolean = False
                Dim lccodcta As String = ""
                Dim NumeroReversiones As Integer = 0
                Dim gniva As Double = Session("gniva")
                Dim lcRetorno As String = ""
                Dim mclimgar As New cClimgar

                lccodcta = etabtbco.CuentaContableBanco(Me.DplBancos.SelectedValue.Trim)

                Dim fecha_Actual_Retiro As Date
                Dim eclimide As New cClimide
                Dim entidadclimide As New climide
                Dim lccodofi As String = ""
                Dim montos As String = TxtMongas.Text
                Dim oki As String = ""
                Dim entidadtabtmak As New SIM.EL.tabtmak
                Dim etabtmak As New SIM.BL.cTabtmak
                Dim etabttab As New cTabttab
                Dim lcconcepto As String
                Dim lcdescri As String
                lcdescri = "GARANTIA LIQUIDA"
                lcconcepto = "El usuario: " & Session("gcCodusu") & " ELIMINA LA " + lcdescri.Trim + " de " & "cliente: " & TxtCodigo.Text.Trim + " Con fecha del dia " + Date.Parse(fecha_Actual_Retiro).ToString.Replace("12:00:00 a.m.", "") + " Banco: " + DplBancos.Text & " -el monto de garantia es :" & montos
                Dim eClimgar As New SIM.BL.cClimgar
                Dim buscar_Credito As String
                buscar_Credito = eClimgar.BuscarCredito_(TxtCodigo.Text.Trim)
                Dim busca_garantia As DataSet
                ''filtramos parametros para obtener la fecha destado de climgar
                busca_garantia = eClimgar.ObtenerDatosCliente(TxtCodigo.Text.Trim, TxtComodin.Text)

                'Extrae fecha 
                For Each row As DataRow In busca_garantia.Tables(0).Rows

                    fecha_Actual_Retiro = (row("destado"))

                Next

                Dim Datos_Cert() As String = {Session("GDFECSIS"), Session("gccodofi"), _
                                    lcconcepto, "AR", Session("GDFECSIS"), _
                                    Session("gcCodusu"), "", "", "", Double.Parse(montos), _
                                    "", 0, "01", "", Session("gccodofi"), "", "", "", 0, _
                                    Double.Parse(montos), "", "", Session("gccontra"), _
                                    Me.TxtCodigo.Text.Trim, lccodcta, Me.txtNomcli.Text.Trim}



                '/****** Fernando Abrego Object: txtcCodgar cambio a Me.txtcNrogar.Text.Trim  Script Date: 06/11/2015 17:22:01 ******/
                Dim ccodgar As String = TxtComodin.Text
                lcRetorno = mclimgar.EliminarGarantias(Datos_Cert, buscar_Credito, Double.Parse(montos), _
                                                                  "04", Date.Parse(fecha_Actual_Retiro), _
                                                                  Session("gccodusu"), Me.txtNomcli.Text.Trim, Me.TxtCodigo.Text.Trim, _
                                                                  ccodgar, "A", obtiene_idClimgar)
                If lcRetorno = "0" Then
                    codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                               "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    Exit Sub
                ElseIf lcRetorno = "2" Then
                    codigoJs = "<script language='javascript'>alert('No se ha creado la cuenta de Garantia Liquida, " & _
                               "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                End If

                '        Response.Write("<script language='javascript'>alert('Cobro Aplicado')</script>")
                codigoJs = "<script language='javascript'>alert('La Garantía ha sido eliminada correctamente, " & _
                            "Aviso SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

            End If
        Else
            'Garantias diferente a liquida
            Eliminar_garantias_(TxtCodigo.Text, TxtComodin.Text)
        End If
        'solo actualiza
        Me.DesHabilita()
        Me.Limpiar()
        Me.btnElimina.Disabled = True
        Me.btngraba.Disabled = True
        Me.btnNew.Disabled = False
        RefrescaGrid()
    End Sub
    'Valida saldos
    Public Function SaldoCuenta(ByVal cuenta As String) As Decimal
        Dim sqlComando As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim lecture As Decimal
        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.Text
                sqlComando.CommandText = "Select nsaldnind from Ahomcta where producto='02' and cnudotr=@ccodcli"
                sqlComando.Parameters.Add(New SqlParameter("@ccodcli", cuenta))
                adapter.SelectCommand = sqlComando
                adapter.Fill(datos)
                For Each row As DataRow In datos.Tables(0).Rows

                    lecture = row("nsaldnind")
                Next
            End Using
        Catch ex As Exception
        End Try

        Return lecture
    End Function
    'Elimina Garantias si es meno  de 5 dias
    Public Function Revision_Fechas() As Date
        Dim sqlComando As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim lecture As Date


        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.Text
                sqlComando.CommandText = "select cconvar  from tabtvar where cdesvar='FECHA DEL SISTEMA' AND cnomvar='GDFECSIS' AND ctipvar ='F'"
                adapter.SelectCommand = sqlComando
                adapter.Fill(datos)
                For Each row As DataRow In datos.Tables(0).Rows

                    lecture = row("cconvar")
                Next
            End Using
        Catch ex As Exception
        End Try

        Return lecture
    End Function
    'Valida usuario que quiere eliminar garantias

    Public Function ValidaUsauriosiaplicaFiveDays() As Integer
        Dim sqlComando As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim lecture As Integer


        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.StoredProcedure
                sqlComando.CommandText = "PROC_ValidaPerfil_garantias"
                sqlComando.Parameters.Add(New SqlParameter("@Usuario", Session("gcCodusu")))
                adapter.SelectCommand = sqlComando
                adapter.Fill(datos)
                For Each row As DataRow In datos.Tables(0).Rows

                    lecture = row("column1")
                Next
            End Using
        Catch ex As Exception
        End Try

        Return lecture
    End Function
    ''Validando las eliminaciones de garantias si tiene un credito en E o F no puede
    Public Function retirosCreditos(ByVal ccodcli As String) As Integer
        Dim sqlComando As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim lecture As Integer


        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.StoredProcedure
                sqlComando.CommandText = "PROC_Valida_Retiros"
                sqlComando.Parameters.Add(New SqlParameter("@ccodcli", ccodcli))
                adapter.SelectCommand = sqlComando
                adapter.Fill(datos)
                For Each row As DataRow In datos.Tables(0).Rows

                    lecture = row("column1")
                Next
            End Using
        Catch ex As Exception
        End Try

        Return lecture
    End Function




    '''''''''''''''''''''''''''''''''''''''''''
    ''''Fecha de garantia
    ''''''''''''''''''''''''''''''''''''''''''''
    Public Function FechaGarantia(ByVal ccodccli As String, ByVal ccodgar As String) As Date
        Dim sqlComando As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim lecture As Date


        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.Text
                sqlComando.CommandText = "select destado from climgar where ccodcli=@ccodcli and ccodgar=@ccodgar"
                sqlComando.Parameters.Add(New SqlParameter("@ccodcli", ccodccli))
                sqlComando.Parameters.Add(New SqlParameter("@ccodgar", ccodgar))
                adapter.SelectCommand = sqlComando
                adapter.Fill(datos)
                For Each row As DataRow In datos.Tables(0).Rows

                    lecture = row("destado")
                Next
            End Using
        Catch ex As Exception
        End Try

        Return lecture

    End Function


    'Elimina Garantias_ climgar 31 07 2015
    Public Sub Eliminar_garantias_(ByVal codigo_Clien As String, ByVal ccodgar As String)
        Dim sqlComando As New SqlCommand
        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.Text
                sqlComando.CommandText = "Delete climgar where ccodcli=@ccodcli and ccodgar=@ccodgar"
                sqlComando.Parameters.Add(New SqlParameter("@ccodcli", codigo_Clien))
                sqlComando.Parameters.Add(New SqlParameter("@ccodgar", ccodgar))
                sqlComando.ExecuteNonQuery()

            End Using
        Catch ex As Exception
        End Try
    End Sub
    'Validacion si es entregada no elimina Garantia
    Public Function ValidaGarantias(ByVal ccodccli As String, ByVal ccodgar As String)as string
        Dim sqlComando As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim lecture As String = ""


        Try
            Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
                cnConexion.Open()
                sqlComando.Connection = cnConexion
                sqlComando.CommandType = CommandType.Text
                sqlComando.CommandText = "select cestado from climgar where ccodcli=@ccodcli and ccodgar=@ccodgar"
                sqlComando.Parameters.Add(New SqlParameter("@ccodcli", ccodccli))
                sqlComando.Parameters.Add(New SqlParameter("@ccodgar", ccodgar))
                adapter.SelectCommand = sqlComando
                adapter.Fill(datos)
                For Each row As DataRow In datos.Tables(0).Rows

                    lecture = row("cestado")
                Next
             End Using
        Catch ex As Exception
        End Try

        Return lecture

    End Function

    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick
        Me.Imprime()
    End Sub
    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Me.Limpiar()
        Me.DesHabilita()
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.Label1.Text = " "
        Me.Label2.Text = " "
        btnNew_ServerClick(sender, e)
    End Sub
    Private Sub cmbTipGar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipGar.SelectedIndexChanged
        If Me.cmbTipGar.SelectedValue.Trim <> "01" Then
            Me.TxtId.Text = "-"
        End If
        If cmbTipGar.SelectedValue.Trim = "03" Then
            'UpdatePanel1.Visible = True
        Else
            'UpdatePanel1.Visible = False
        End If
        'Validando file solo con liquida
        If cmbTipGar.SelectedValue.Trim = "04" Then
            fileUpEx.Enabled = True
        Else
            fileUpEx.Enabled = False
        End If
    End Sub

    Public Sub BuscaMunicipios()
        Dim sqlComando As New SqlCommand
        Dim drDataReader As SqlDataReader
        Dim lcdepa As String
        lcdepa = cmbDep.SelectedItem.Value.Trim
        Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
            cnConexion.Open()
            sqlComando.CommandText = " select left(ccodzon,4) as ccodzon,cdeszon from tabtzon where ctipzon=2 and left(cCodzon,2)=" & "'" & lcdepa & "'" & "  order by cdeszon "
            sqlComando.Connection = cnConexion
            drDataReader = sqlComando.ExecuteReader
            cmbMun.DataSource = drDataReader
            cmbMun.DataTextField = "cdeszon"
            cmbMun.DataValueField = "ccodzon"
            cmbMun.DataBind()
        End Using

    End Sub

    Public Sub BuscaCantones()
        Dim sqlComando As New SqlCommand
        Dim drDataReader As SqlDataReader
        Dim lcmuni As String
        lcmuni = cmbMun.SelectedItem.Value.Trim
        Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
            cnConexion.Open()
            sqlComando.CommandText = " select ccodzon,cdeszon from tabtzon where ctipzon=3 and left(cCodzon,4)=" & "'" & lcmuni & "'" & "  order by cdeszon "
            sqlComando.Connection = cnConexion
            drDataReader = sqlComando.ExecuteReader
            cmbcant.DataSource = drDataReader
            cmbcant.DataTextField = "cdeszon"
            cmbcant.DataValueField = "ccodzon"
            cmbcant.DataBind()
        End Using
    End Sub
    Protected Sub cmbDep_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDep.SelectedIndexChanged
        BuscaMunicipios()
        BuscaCantones()
        '        Garantias.TabIndex = 2
        Garantias.ActiveTabIndex = 2
    End Sub

    Protected Sub cmbMun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMun.SelectedIndexChanged
        BuscaCantones()
        '       Garantias.TabIndex = 2
        Garantias.ActiveTabIndex = 2
    End Sub

    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        Session("latitud") = Me.txtlatitud.Text
        Session("longitud") = Me.txtlongitud.Text
        Session("descripcion") = Me.txtdireccion.Text

        '        Response.Write("<script>window.open('WfGeoReferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=800,height=600')</script>")
        codigoJs = "<script>window.open('WfGeoReferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=800,height=600')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
    End Sub
    'Evento Identifica el boton de Ver garantia ---
    Protected Sub Grid_Garantia_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Grid_Garantia.RowCommand
        'si es igual al valor name de  "Ver" genera porceso de seleccion 
        If e.CommandName = "Ver" Then
            Dim valor As String = e.CommandArgument.ToString()
            valor = valor
            If valor = "" Then
                codigoJs = "<script language='javascript'>alert('Seleccione una garantia con Ticket, " & _
                  "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Else
                'trabajando  ---  -
                Response.Write("<script>window.open(" + "'Imgen_Ticket_Cl.aspx?Valor=" + valor + "','blank');</script>")
                ''Response.Redirect("Imgen_Ticket_Cl.aspx?Valor=" + valor)

                'trabajando  --- -
            End If
        End If
    End Sub
    Protected Sub grid_Garantia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Garantia.SelectedIndexChanged
        Dim ds As New DataSet
        ClienteSeleccionado = Grid_Garantia.SelectedRow.Cells(1).Text.ToString()
        Me.TxtComodin.Text = Me.ClienteSeleccionado

        '-----------------------------------------------------
        'Trae toda la informacion de la Garantia
        '-----------------------------------------------------
        ds = Me.BuscaGarantia(Me.TxtCodigo.Text.Trim, Me.TxtComodin.Text.Trim)

        Dim ncanti As Integer

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub        'Hubo un error Depurar
        End If

        Me.TxtDescri.Text = ds.Tables(0).Rows(0)("Descripcion")
        Me.TxtMongas.Text = ds.Tables(0).Rows(0)("nmongar")
        Me.TxtMontas.Text = ds.Tables(0).Rows(0)("nmontas")
        Me.TxtId.Text = ds.Tables(0).Rows(0)("ccoduni")
        Me.Txtmongrav.Text = 0
        If Me.TxtId.Text.Trim = "" Then
            Me.TxtId.Text = "-"
        End If
        Me.cmbTipDes.SelectedValue = ds.Tables(0).Rows(0)("ctipdes")
        Me.cmbTipGar.SelectedValue = ds.Tables(0).Rows(0)("ctipgar")

        txtpropietario.Text = ds.Tables(0).Rows(0)("cpropietario")
        txtprofinca.Text = ds.Tables(0).Rows(0)("cprofinca")
        txtprofolio.Text = ds.Tables(0).Rows(0)("cprofolio")
        txtprolibro.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("cprolibro")), "", ds.Tables(0).Rows(0)("cprolibro"))
        txtprode.Text = ds.Tables(0).Rows(0)("cprode")
        txtmunfinca.Text = ds.Tables(0).Rows(0)("cmunfinca")
        txtmunfolio.Text = ds.Tables(0).Rows(0)("cmunfolio")
        txtmunlibro.Text = ds.Tables(0).Rows(0)("cmunlibro")
        txtmunde.Text = ds.Tables(0).Rows(0)("cmunde")
        txtdireccion.Text = ds.Tables(0).Rows(0)("cdireccion")
        cmbTopo.SelectedValue = ds.Tables(0).Rows(0)("ctopo")
        txtespdir.Text = ds.Tables(0).Rows(0)("cespdir")
        cmbuso.SelectedValue = ds.Tables(0).Rows(0)("cuso")
        txtespuso.Text = ds.Tables(0).Rows(0)("cespuso")
        cmblocalidad.SelectedValue = ds.Tables(0).Rows(0)("clocalidad")
        txtniveles.Text = ds.Tables(0).Rows(0)("nniveles")
        cmbacceso.SelectedValue = ds.Tables(0).Rows(0)("cacceso")
        txtespser.Text = ds.Tables(0).Rows(0)("cespser")
        txtespamb.Text = ds.Tables(0).Rows(0)("cespamb")
        txtesptecho.Text = ds.Tables(0).Rows(0)("cesptecho")
        txtesppiso.Text = ds.Tables(0).Rows(0)("cesppiso")
        txtesppared.Text = ds.Tables(0).Rows(0)("cesppared")
        txtNmedida.Text = ds.Tables(0).Rows(0)("nnmedida")
        txtNcolin.Text = ds.Tables(0).Rows(0)("nncolin")
        txtSmedida.Text = ds.Tables(0).Rows(0)("nsmedida")
        txtScolin.Text = ds.Tables(0).Rows(0)("nscolin")
        txtEmedida.Text = ds.Tables(0).Rows(0)("nemedida")
        txtEcolin.Text = ds.Tables(0).Rows(0)("necolin")
        txtOmedida.Text = ds.Tables(0).Rows(0)("nomedida")
        txtOcolin.Text = ds.Tables(0).Rows(0)("nocolin")
        txtlongitud.Text = ds.Tables(0).Rows(0)("nlongitud")
        txtlatitud.Text = ds.Tables(0).Rows(0)("nlatitud")

        Me.txtnotario.Text = ds.Tables(0).Rows(0)("cnotario")
        txtnumeropr.Text = ds.Tables(0).Rows(0)("nnumeropr")

        If IsDBNull(ds.Tables(0).Rows(0)("dfechaes")) Then
            txtfechaes.Text = ""
        Else
            If ds.Tables(0).Rows(0)("dfechaes") = #1/1/1980# Then
                txtfechaes.Text = ""
            Else
                txtfechaes.Text = ds.Tables(0).Rows(0)("dfechaes")
            End If
        End If
        txtlugares.Text = ds.Tables(0).Rows(0)("clugares")
        Try

            If IsDBNull(ds.Tables(0).Rows(0)("dprofecha")) Then
                txtprofecha.Text = ""
            Else
                If ds.Tables(0).Rows(0)("dprofecha") = #1/1/1980# Then
                    txtprofecha.Text = ""
                Else
                    txtprofecha.Text = ds.Tables(0).Rows(0)("dprofecha")
                End If
            End If

            If IsDBNull(ds.Tables(0).Rows(0)("dmunfecha")) Then
                txtmunfecha.Text = ""
            Else
                If ds.Tables(0).Rows(0)("dmunfecha") = #1/1/1980# Then
                    txtmunfecha.Text = ""
                Else
                    txtmunfecha.Text = ds.Tables(0).Rows(0)("dmunfecha")
                End If
            End If
            cmbDep.SelectedValue = Left(ds.Tables(0).Rows(0)("cubica"), 2)
            BuscaMunicipios()
            cmbMun.SelectedValue = Left(ds.Tables(0).Rows(0)("cubica"), 5)
            BuscaCantones()
            cmbcant.SelectedValue = Left(ds.Tables(0).Rows(0)("cubica"), 9)

            Dim tronque As String = ""
            tronque = ds.Tables(0).Rows(0)("cservicios")
            For i = 0 To 4
                If tronque.Substring(i, 1) = "1" Then
                    cmbservicios.Items(i).Selected = True
                Else
                    cmbservicios.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '--------
            tronque = ds.Tables(0).Rows(0)("cambientes")
            For i = 0 To 7
                If tronque.Substring(i, 1) = "1" Then
                    cmbambientes.Items(i).Selected = True
                Else
                    cmbambientes.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '-------
            tronque = ds.Tables(0).Rows(0)("ctecho")
            For i = 0 To 2
                If tronque.Substring(i, 1) = "1" Then
                    cmbtecho.Items(i).Selected = True
                Else
                    cmbtecho.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '--------
            tronque = ds.Tables(0).Rows(0)("cpiso")
            For i = 0 To 4
                If tronque.Substring(i, 1) = "1" Then
                    cmbpiso.Items(i).Selected = True
                Else
                    cmbpiso.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '---------
            tronque = ds.Tables(0).Rows(0)("cparedes")
            For i = 0 To 4
                If tronque.Substring(i, 1) = "1" Then
                    cmbparedes.Items(i).Selected = True
                Else
                    cmbparedes.Items(i).Selected = False
                End If
            Next
            tronque = ""

            txtfecavaluo.Text = ds.Tables(0).Rows(0)("dfecval")
        Catch ex As Exception

        End Try

        Garantias.ActiveTabIndex = 0

        Me.btngraba.Disabled = False
        Me.btnNew.Disabled = True
        Me.btnElimina.Disabled = False
        Me.Habilita()
    End Sub
    'Se omite al final este paso -- Ignora --
    Private Sub Carga_Firma_Digital()
        'hfIdEmpleado.Value = entidadClimide.ccodcli
        'CargarImagenDeBaseDatos(entidadClimide.foto)
        Me.ImageFoto.ImageUrl = "../uploads/" + hfIdEmpleado.Value + ".JPG"
        ImageFoto.Visible = True
    End Sub
    'Fin---------
    'Graba datos de garantias a carpeta
    Private Sub cargarComprobante_Carp(ByVal ccodgar_gar As String)
        Dim sExt As String = String.Empty
        Dim sName As String = String.Empty
        Dim lnRetorno As Integer = 0
        Dim mcremcre As New cCremcre
        Dim ccodcligar As String = "" 'Nombre de la imagen 
        Dim InsRetorno2 As Integer = 0
        Dim SeleRetorno3 As Integer = 0
        Dim inserccodgar_gar As String = ccodgar_gar 'dato ingresado a la base de datos
        Dim nombre_cli As String = txtNomcli.Text

        lblStatus.ForeColor = Color.FromArgb(210, 0, 0)

        If TxtCodigo.Text.Trim.Length > 0 Then
            If Not fileUpEx.HasFile = Nothing Then
                sName = TxtCodigo.Text.Trim
                sExt = Path.GetExtension(fileUpEx.FileName)

                If ValidaExtension(sExt.ToLower) Then
                    fileUpEx.SaveAs("C:\Comprobante\" & nombre_cli & "-" & sName & "-" & ccodgar_gar & sExt.ToUpper)
                    ccodcligar = nombre_cli & "-" & sName & "-" & ccodgar_gar & sExt.ToUpper
                    'si existe una imagen valida
                    If ccodcligar <> "" Then
                        SeleRetorno3 = mcremcre.select_datosComprobante(Me.TxtCodigo.Text.Trim, ccodcligar)

                        lnRetorno = mcremcre.Actualiza_banderas_Comprobante(Me.TxtCodigo.Text.Trim, inserccodgar_gar, ccodcligar, "1")

                        'mensaje de validacion
                        If lnRetorno = 1 Then
                            lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                            lblStatus.Text = "Enviado Correctamente !!"
                            Me.RefrescaGrid()
                        Else
                            codigoJs = "<script language='javascript'>alert('Error al Enviar el archivo , " & _
                   "Advertencia SIM.NET ')</script>"
                            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                        End If

                    Else : codigoJs = "<script language='javascript'>alert('Este tipo de archivo no esta permitido., " & _
                   "Advertencia SIM.NET ')</script>"
                        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    End If
                Else : codigoJs = "<script language='javascript'>alert('Seleccione el archivo que desea subir., " & _
                   "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                End If
            Else : codigoJs = "<script language='javascript'>alert('Debe buscar un cliente antes de subir el archivo., " & _
                   "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            End If
        Else : codigoJs = "<script language='javascript'>alert('Debe seleccionar una foto, " & _
                        "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If 'Termina de if validador
    End Sub
    'Limpiar textbox de Garantias --- 29-07-2015
    Protected Sub TxtLimpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLimpiar.Click
        TxtDescri.Text = ""
        TxtCogar.Text = ""
        TxtMongas.Text = 0
        TxtComodin.Text = ""
        TxtMontas.Text = 0
        btnNew.Disabled = False
        Me.lblStatus.Text = ""
    End Sub
End Class


