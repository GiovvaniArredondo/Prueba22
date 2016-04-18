Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Public Class WbDesemb1
    Inherits System.Web.UI.UserControl
    Private cls1 As New SIM.BL.ClsMantenimiento
    Dim clsbancos As New SIM.BL.cTabtbco
    Dim clsppal As New class1
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

    'Private cClase As New SIM.BL.crefunc


#Region " Variables "
    Private cClsDes As New SIM.BL.clsDesembolsa
    Private vDetalle As New DataSet
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Private clsConvert As New SIM.BL.ConversionLetras
    Public Event Refinanciamiento(ByVal codigoCliente As String)
    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private Transacc As String
    Private codigoJs As String

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

#End Region


#Region " Metodos "
    Public Sub CargarCancela(ByVal lccuenta As String)
        Dim dsc As New DataSet
        Dim ecancela As New cCancela
        Dim filac As DataRow
        Dim elemc As Integer = 0
        dsc = ecancela.ObtenerDataSetPorID(lccuenta)
        If dsc.Tables(0).Rows.Count = 0 Then
        Else
            For Each filac In dsc.Tables(0).Rows
                Me.Refinaciamiento(dsc.Tables(0).Rows(elemc)("ccodcta"))
                elemc += 1
            Next
        End If
    End Sub
    Public Sub Refinaciamiento(ByVal codigocliente As String)
        'Verifica codigo que no este repetido
        If Me.txtcodref1.Text.Trim = "" Then
            Me.txtcodref1.Text = codigocliente
        Else
            If Me.txtcodref1.Text.Trim = codigocliente Then
            Else
                If Me.txtcodref2.Text.Trim = codigocliente Then
                Else
                    If Me.txtcodref2.Text.Trim = "" Then
                        Me.txtcodref2.Text = codigocliente
                    Else
                        If Me.txtcodref3.Text.Trim = codigocliente Then
                        Else
                            If Me.txtcodref3.Text.Trim = "" Then
                                Me.txtcodref3.Text = codigocliente
                            Else
                                If Me.txtcodref4.Text.Trim = codigocliente Then
                                Else
                                    If Me.txtcodref4.Text.Trim = "" Then
                                        Me.txtcodref4.Text = codigocliente
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Dim lniva As Double = 0
        Dim lniva1 As Double = 0
        Dim lniva2 As Double = 0
        Dim lniva3 As Double = 0
        Dim clase As New class1

        Dim dr As DataRow
        Dim resulta As Double
        Dim clsaplica As New SIM.bl.payment
        Dim ok As Integer
        Dim lneleref As Integer = 0
        If Me.txtcodref1.Text.Trim <> "" Then
            lneleref += 1
        End If
        If Me.txtcodref2.Text.Trim <> "" Then
            lneleref += 1
        End If
        If Me.txtcodref3.Text.Trim <> "" Then
            lneleref += 1
        End If
        If Me.txtcodref4.Text.Trim <> "" Then
            lneleref += 1
        End If
        Dim ldfecdes As Date
        ldfecdes = Me.fechaproy()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        vDetalle = cClsDes.CargaRefina()
        Dim i As Integer
        For i = 1 To lneleref
            lniva = 0
            lniva1 = 0
            lniva2 = 0
            lniva3 = 0

            If i = 1 Then
                clsaplica.pccodcta = Me.txtcodref1.Text.Trim
            End If
            If i = 2 Then
                clsaplica.pccodcta = Me.txtcodref2.Text.Trim
            End If
            If i = 3 Then
                clsaplica.pccodcta = Me.txtcodref3.Text.Trim
            End If
            If i = 4 Then
                clsaplica.pccodcta = Me.txtcodref4.Text.Trim
            End If
            Dim lccodcta1 As String
            lccodcta1 = clsaplica.pccodcta

            '            clsaplica.pccodcta = codigocliente
            clsaplica.pdfecval = ldfecdes 'Session("gdfecsis")
            clsaplica.gdfecsis = ldfecdes 'Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            clsaplica.gnpergra = Session("gnpergra")
            clsaplica.omcalcinterest("T", ldfecdes)

            '            vDetalle = cClsDes.CargaRefina()
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'Calculo de la comision por tramite -----------------
            Dim lncomision As Double
            Dim pccodlin As String
            Dim lsegdeu As Boolean
            Dim lnsegdeu As Double
            Dim lndias As Integer
            Dim entidadcretlin As New cretlin
            Dim ecretlin As New cCretlin


            entidadcretlin.cnrolin = clsaplica.cnrolin
            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
            pccodlin = entidadcretlin.ccodlin
            lsegdeu = entidadcretlin.lsegdeu

            lndias = DateDiff(DateInterval.Day, clsaplica.pdultpag, clsaplica.pdfecval)
            'If pccodlin.Substring(8, 2) = "06" Then
            '    lncomision = 0
            'Else
            '    If clsaplica.pdfecvig > #11/1/2005# Then
            '        lncomision = (clsaplica.pncapdes * (Session("gncomtra") / 100) * lndias) / clsaplica.gnperbas
            '    Else
            '        lncomision = 0
            '    End If

            'End If
            'If lsegdeu = True Then
            '    If clsaplica.pdfecvig >= #7/11/2008# Then
            '        lnsegdeu = (clsaplica.pncapdes * Session("gnSegVm1") / 31) * lndias
            '    Else
            '        lnsegdeu = (clsaplica.pncapdes * Session("gnSegVm") / 31) * lndias
            '    End If

            'Else
            '        lnsegdeu = 0
            '    End If
            lncomision = 0

            lnsegdeu = clase.CalcularSeguroDeuda(lccodcta1, ldfecdes, Double.Parse(clsaplica.pncapdes), clsaplica.pdfecvig)
            lncomision = clase.CalcularManejo(lccodcta1, ldfecdes, clsaplica.pncapdes, False)
            lniva1 = clase.CalcularIVAManejo(Session("gnIVA"), lncomision)
            lniva2 = clase.CalcularIVAManejo(Session("gnIVA"), clsaplica.pnsalint)
            lniva3 = clase.CalcularIVAManejo(Session("gnIVA"), clsaplica.pnsalmor)
            lniva = lniva1 + lniva2 + lniva3

                '---------------------------------------------------------
                clsaplica.pncomision = lncomision
                clsaplica.segdeu = lnsegdeu
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                dr = vDetalle.Tables("Refina").NewRow

                dr("IdCuenta") = clsaplica.pccodcta 'codigocliente
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                resulta = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                dr("nCapita") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2)
                dr("nIntere") = utilNumeros.Redondear(clsaplica.pnsalint, 2)
            dr("nIntMor") = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
            dr("niva") = utilNumeros.Redondear(lniva, 2)
            dr("nTota") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2) + _
              utilNumeros.Redondear(clsaplica.pnsalint, 2) + _
              utilNumeros.Redondear(clsaplica.pnsalmor, 2) + _
            utilNumeros.Redondear(clsaplica.pncomision, 2) + _
                utilNumeros.Redondear(clsaplica.segdeu, 2) + utilNumeros.Redondear(lniva, 2)
                dr("nComision") = utilNumeros.Redondear(clsaplica.pncomision, 2)
                dr("nSegDeu") = utilNumeros.Redondear(clsaplica.segdeu, 2)
                'Acumula Descuento

                vDetalle.Tables("Refina").Rows.Add(dr)

            Me.Grid_Ref.DataSource = vDetalle.Tables("Refina")

            Me.Grid_Ref.DataBind()

                viewstate.Add("Dataset", vDetalle)
                Session("flagref") = 1
                Me.TxtRefina.Text = "1"

        Next
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
     
        
    End Sub
    Public Sub Cargar_Ref()
        Me.CargarCancela(Me.txtCodigo.Text.Trim)
        '>>><
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela

        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        Dim e As Double = 0
        Dim f As Double = 0
        Dim deuda As Double
        Dim deuda1 As Double
        Dim dscancela As New DataSet
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim pcref1 As String
        Dim pcref As String
        dscancela = ecancela.ObtenerDataSetPorCuenta(Me.txtCodigo.Text.Trim)

        If dscancela.Tables(0).Rows.Count = 0 Then
            deuda = 0

        Else
            For Each fila In dscancela.Tables(0).Rows
                a = dscancela.Tables(0).Rows(nelem)("nsalcap")
                b = dscancela.Tables(0).Rows(nelem)("nsalint")
                c = dscancela.Tables(0).Rows(nelem)("nsalmor")
                d = dscancela.Tables(0).Rows(nelem)("nmanejo")
                e = dscancela.Tables(0).Rows(nelem)("nseguro")
                f = dscancela.Tables(0).Rows(nelem)("niva")
                deuda1 = a + b + c + d + e + f
                deuda = deuda + deuda1
                nelem += 1
            Next
        End If
        Me.txtDeuda.Text = deuda
        Me.TxtDescuento.Text = Double.Parse(Me.TxtDescuento.Text.Trim) + deuda
        Me.TxtDesembolso.Text = Double.Parse(Me.TxtCapita.Text.Trim) - _
                                Double.Parse(Me.TxtDescuento.Text.Trim)

    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Dim lcuenta As String
        Dim gdfecsis As Date

        lcuenta = codigoCliente

        'verifica longitud de codigo
        Dim longcodigo As Integer
        longcodigo = Len(codigoCliente.Trim)
        If longcodigo = 12 Then 'Es desembolso Grupal
            Me.txtig.Text = "1"

            Me.txtCuenta.Text = codigoCliente.Trim
            Me.TxtInst.Text = codigoCliente.Substring(0, 3)
            Me.TxtOficina.Text = codigoCliente.Substring(3, 3)
            Me.txtCodigo.Text = lcuenta
            If lcuenta = Nothing Then
                Exit Sub
            End If
            Me.cbxgrupos.Visible = True
            Me.cbxgrupos.Value = codigoCliente.Trim
            Me.Label1.Visible = True

            Me.TxtNomcli.Visible = False
            Me.Label6.Visible = False

        Else
            Me.txtig.Text = "0"

            Me.cbxgrupos.Visible = False
            Me.Label1.Visible = False

            Me.TxtNomcli.Visible = True
            Me.Label6.Visible = True

            Me.txtCuenta.Text = codigoCliente.Substring(6, 12)
            Me.TxtInst.Text = codigoCliente.Substring(0, 3)
            Me.TxtOficina.Text = codigoCliente.Substring(3, 3)
            Me.txtCodigo.Text = lcuenta

            If lcuenta = Nothing Then
                Exit Sub
            End If

        End If



        Me.Aplica()

        Me.txtcnumcom.Text = ""
        Me.txtnumeros.Text = ""

        gdfecsis = Session("gdfecsis") 'Carga la fecha de sistema de la Tabtvar




    End Sub

    Public Sub Aplica()
        'Dim lcdescri As Exception
        Dim ds As New DataSet
        'Sacando los datos necesarios para el Desembolso
        Dim lcestado As String
        Dim lndescuento As Double
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre
        Dim mcreditos As New ccreditos
        'obtiene linea de credito
        Dim entidadcretlin As New cretlin
        Dim ecretlin As New cCretlin
        Dim lverifica As Boolean = False
        Dim lnsaldo As Decimal = 0
        Me.txtbandera.Text = 1
        Dim ldfecven As Date = Session("gdfecsis")
        Dim mclimgar As New cClimgar
        Dim comodin As DateTime

        Try


            If Me.txtig.Text.Trim = "1" Then
                'Busca codigos del grupo para desembolsar
                ds = ecreditos.CreditosxGrupo(Me.txtCodigo.Text.Trim)
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If ds.Tables(0).Rows.Count = 0 Then
                    btnGrabar.Disabled = True
                    '                    Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                    codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                                                    "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


                    Exit Sub
                Else
                    btnGrabar.Disabled = False
                    Me.txtCodigo.Text = ds.Tables(0).Rows(0)("cCodcta")
                End If
            End If


            

            Dim lcnrolin As String

            entidad1.ccodcta = Me.txtCodigo.Text

            ecreditos.ObtenerCremcre(entidad1)

            If Not mclimgar.Valida_Existencia_Garantia_Liquida_Activa(entidad1.ccodcli) Then
                'Response.Write("<script language='javascript'>alert('Las Garantías no se han registrado en Otros Ingresos')</script>")
                codigoJs = "<script language='javascript'>alert('Las Garantías no se han registrado en Otros Ingresos, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                btnGrabar.Disabled = True
                Exit Sub
            End If
            If Not mclimgar.Valida_Existencia_Tipo_Ingreso(Me.txtCodigo.Text.Trim, "03", comodin) Then
                codigoJs = "<script language='javascript'>alert('Los Seguros no se han registrado en Otros Ingresos, " & _
                              "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                btnGrabar.Disabled = True
                Exit Sub
            End If



            lcestado = entidad1.cestado
            lcnrolin = entidad1.cnrolin
            ldfecven = entidad1.dfecven

            Me.TextBox11.Text = entidad1.nmonapr
            Me.TextBox12.Text = entidad1.ncapdes
            Me.TextBox13.Text = entidad1.nmonapr - entidad1.ncapdes

            Dim lbandera As Boolean = False
            If lcestado <> "E" Then
                If lcestado = "F" And Math.Round(entidad1.nmonapr, 2) > Math.Round(entidad1.ncapdes, 2) Then
                    If entidad1.ncapdes > 0 Then
                        'ya hubo un desembolso
                        lbandera = True
                    End If
                    btnGrabar.Disabled = False

                    lverifica = ecretlin.Verifica_Linea_Revolvente(txtCodigo.Text.Trim)
                    If lverifica = True And ldfecven >= Session("gdfecsis") Then 'Aplica linea Revolvente
                        lnsaldo = mcreditos.Obtener_Saldo(txtCodigo.Text.Trim)
                        If Math.Round(lnsaldo, 2) > 0 Then
                            'ya hubo un desembolso
                            lbandera = True
                            Me.TextBox13.Text = Math.Round(entidad1.nmonapr - lnsaldo, 2)
                        Else
                            btnGrabar.Disabled = True
                            '                            Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                            codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                                                    "Advertencia SIM.NET ')</script>"
                            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                            Exit Sub
                        End If
                    End If
                Else
                    btnGrabar.Disabled = True
                    'Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                    codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                                                    "Advertencia SIM.NET ')</script>"
                    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                    Exit Sub
                End If
            End If



            Dim lccodlin As String

            entidadcretlin.cnrolin = entidad1.cnrolin
            ecretlin.ObtenerCretlinPorllave(entidadcretlin)
            lccodlin = entidadcretlin.ccodlin

            Me.txtnmoncuo.Text = entidadcretlin.nmoncuo

            'Genera nuevamente el plan de pagos
            GeneraPlanPagos(Me.txtCodigo.Text.Trim, entidad1.nmonapr)



            Txtfactura.Enabled = True
            txtflag.Text = lbandera
            Me.TxtCodcli.Text = entidad1.ccodcli
            If lverifica = True Then 'aplica Revolvente
                If lnsaldo > 0 Then
                    Me.TxtCapita.Text = utilNumeros.Redondear(entidad1.nmonapr - lnsaldo, 2)
                End If
            Else
                Me.TxtCapita.Text = utilNumeros.Redondear(entidad1.nmonapr - entidad1.ncapdes, 2)
            End If


            'Datos del Cliente
            Dim entidad2 As New SIM.EL.climide
            Dim eClimide As New SIM.BL.cClimide

            entidad2.ccodcli = Me.TxtCodcli.Text


            eClimide.ObtenerClimide(entidad2)

            Me.TxtNomcli.Text = entidad2.cnomcli

            'Numero de Documento para desembolso
            Dim entidadKardex As New SIM.EL.credkar
            Dim eKardex As New SIM.BL.cCredkar

            entidadKardex.ccodcta = Me.txtCodigo.Text.Trim

            Me.TxtDocumento.Text = eKardex.obtenercnrodoc(Me.txtCodigo.Text.Trim)



            '-------------------------------------
            'Sacando los gastos
            '-------------------------------------

            'Comision por Otorgamiento
            Dim entidad3 As New SIM.EL.credgas
            Dim ecredgas As New SIM.BL.cCredgas

            Dim dt As New DataTable
            Dim lndes As Double = 0
            If lbandera = True Then
            Else
                dt = ecredgas.CargaComisiones(Me.txtCodigo.Text.Trim, "D")
                ''dt = mcreditos.Comisiones(entidad1.nmonapr, lccodlin.Substring(8, 2), entidad1.lsegvid)
                Datagrid2.DataSource = dt
                Datagrid2.DataBind()

                'ecredgas.Eliminarporcuenta(Me.txtCodigo.Text)

                Dim fila As DataRow
                For Each fila In dt.Rows
                    lndes = lndes + fila("nmongas")


                Next

            End If

            'Moneda
            Me.TxtMoneda.Text = "PESOS"

            If lbandera = False Then
                Me.Cargar_Ref()

                'Me.txtDeuda.Text = (Me.TextBox5.Text + Me.TextBox6.Text + Me.TextBox7.Text + Me.TextBox9.Text + Me.TextBox10.Text)
                'Acumula total de Deuda a descontar

                'lndescuento = (Double.Parse(Me.TextBox5.Text) + Double.Parse(Me.TextBox6.Text) + Double.Parse(Me.TextBox7.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.txtDeuda.Text) + Double.Parse(Me.txtIVA.Text))
                lndescuento = (Double.Parse(Me.txtDeuda.Text) + lndes)

                Me.TxtDescuento.Text = utilNumeros.Redondear(lndescuento, 2)


            Else
                lndescuento = 0
                TxtDescuento.Text = 0
            End If

            'Total a Desembolsar
            Me.TxtDesembolso.Text = utilNumeros.Redondear((Double.Parse(Me.TxtCapita.Text) - lndescuento), 2)
            'Concepto          
            Me.cGlosa.Text = "DESEMB.CREDITO No: " & Me.txtCodigo.Text.Trim & "  " & Me.TxtNomcli.Text.Trim



        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargarCombos()

        
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        Dim dsc As New DataSet

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        'Tipo de Desembolso
        mListaTabttab = clstabttab.ObtenerLista("146", "1")

        Me.cmbtippag.DataTextField = "cdescri"
        Me.cmbtippag.DataValueField = "ccodigo"
        Me.cmbtippag.DataSource = mListaTabttab
        Me.cmbtippag.DataBind()
        Me.cmbtippag.SelectedValue = "D"

        'Informacion del Combo
        'Informacion del Combo
        clsbancos.ObtenerDatasetporidtodos(dsb, Session("gcCodofi"), "DE")

        Me.cmbBancos.DataTextField = "cnombco"
        Me.cmbBancos.DataValueField = "ccodbco"
        Me.cmbBancos.DataSource = dsb.Tables(0)
        Me.cmbBancos.DataBind()
        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)

        Me.btnGrabar.Disabled = False

      
        '----------------------------
        'Llenando Grupos
        '----------------------------
        Dim ds As New DataSet
        lnparametro1_R = "cNomgru , cCodsol, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "CREMSOL"
        lnparametro5_R = "S"
        lnparametro6_R = " order by CNOMgru "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxgrupos.DataTextField = "cNomgru"
        Me.cbxgrupos.DataValueField = "cCodsol"
        Me.cbxgrupos.DataSource = ds.Tables("Resultado")
        Me.cbxgrupos.DataBind()

        Me.cbxgrupos.Visible = False
        Me.Label1.Visible = False
        Me.cbxgrupos.Disabled = True
        Txtfactura.Enabled = False

        ds.Tables("Resultado").Clear()

        Me.txtcnumcom.Text = ""
        Me.txtnumeros.Text = ""
    End Sub

    Public Sub Limpiar()
        Me.txtcnumcom.Text = ""
        Me.txtnumeros.Text = ""

        Txtfactura.Text = ""
        Me.TxtCodcli.Text = " "
        Me.txtCodigo.Text = " "
        Me.txtCuenta.Text = " "
        Me.TxtInst.Text = " "
        Me.TxtOficina.Text = " "
        Me.TxtMoneda.Text = " "
        Me.TxtNomcli.Text = " "
        Me.TxtDocumento.Text = " "
        'Me.Txtnrochq.Text = " "
        Me.cGlosa.Text = " "
        Me.TxtCapita.Text = 0
        Me.TxtDescuento.Text = 0
        Me.txtnmoncuo.Text = "0.00"
        Me.TxtDesembolso.Text = 0
        Me.txtDeuda.Text = 0
        Me.TextBox5.Text = 0
        Me.txtIVA.Text = 0
        Me.TextBox6.Text = 0
        Me.TextBox7.Text = 0
        Me.TextBox9.Text = 0
        Me.TextBox10.Text = 0
        Me.TxtRefina.Text = " "
        Me.btnGrabar.Disabled = False

        Me.btnimprimir.Disabled = True
        Me.btnfactura.Disabled = True
    End Sub

    Public Sub Imprime()
        Dim lncapita As Double = 0
        lncapita = Double.Parse(TxtCapita.Text)
        Dim lbandera As Boolean = Boolean.Parse(txtflag.Text)

        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CrRptDesem.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim eKardex As New SIM.BL.ckardex
        Dim nCanti As Integer
        Dim ldfecha As Date = Session("gdfecsis")
        ldfecha = Date.Parse(Me.txtfecvig.Text.Trim)
        'Crear aqui el dataset
        If Me.txtig.Text.Trim = "0" Then
            dsDes = eKardex.ObtenerDataSetPorcuenta2(Me.txtCodigo.Text.Trim, "EG", Me.Txtnrochq.Text.Trim) 'Me.TxtDocumento.Text.Trim
        Else
            dsDes = eKardex.ObtenerDataSetPorcuenta3(Me.cbxgrupos.Value.Trim, ldfecha, Me.Txtnrochq.Text.Trim) 'Me.TxtDocumento.Text.Trim
        End If



        nCanti = dsDes.Tables(0).Rows.Count


        If nCanti = 0 Then
        Else
            If lbandera = True Then
                dsDes.Tables(0).Rows(0)("ngastos") = 0
            End If
            dsDes.Tables(0).Rows(0)("cnumcom") = Me.txtcnumcom.Text.Trim
            dsDes.Tables(0).Rows(0)("cnrochq") = Me.txtnumeros.Text.Trim
        End If

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRpt.SetParameterValue("lncom1", viewstate("pncom1"))
        crRpt.SetParameterValue("lncom2", viewstate("pncom2"))
        crRpt.SetParameterValue("lncom3", viewstate("pncom3"))
        crRpt.SetParameterValue("lncom4", viewstate("pncom4"))
        crRpt.SetParameterValue("lncom5", viewstate("pncom5"))
        crRpt.SetParameterValue("lncom6", ViewState("pncom6"))
        crRpt.SetParameterValue("lncom7", ViewState("pncom7"))
        crRpt.SetParameterValue("lndeuda", viewstate("pndeuda"))
        crRpt.SetParameterValue("lccreref", ViewState("pccreref"))
        crRpt.SetParameterValue("pncapita", lncapita)
        Dim reportes As String
        reportes = "CrRptDesem.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    
    Private Sub GeneraPlanPagos(ByVal pcCodcta As String, ByVal pnMonapr As Double)
        Dim ecredppg As New cCredppg
        Dim i As Integer = 0
        Dim omcretgas As New cCretgas
        Dim entidadcretgas As New cretgas
        Dim omcremcre As New cCremcre
        Dim entidadcremcre As New cremcre
        Dim ldfecpri As Date

        entidadcremcre.ccodcta = pcCodcta 'Me.txtCodigo.Text.Trim
        omcremcre.ObtenerCremcre(entidadcremcre)

        IgualaDatos(pcCodcta, pnMonapr)

        Dim entidadtabttab As New tabttab
        Dim omtabttab As New cTabttab

        entidadtabttab.ccodtab = "060"
        entidadtabttab.ctipreg = "1"
        entidadtabttab.ccodigo = entidadcremcre.cfrecint

        omtabttab.ObtenerTabttab(entidadtabttab)

        ldfecpri = Session("gdfecsis") 'Date.Parse(Me.txtFecDes.Text)
        ldfecpri = ldfecpri.AddDays(entidadtabttab.nnumtab)

        clsppal.dfecpri = ldfecpri

        clsppal.pnComtra = Session("gnComTra")
        clsppal.pnSegVm = Session("gnSegVm1")
        'clsppal.gniva = Session("gnIVA")
        clsppal.pniva = Session("gnIVA")

        'entidadcretgas.cnrolin = entidadcremcre.cnrolin
        'entidadcretgas.ctipgas = "03"

        'omcretgas.ObtenerCretgas(entidadcretgas)

        'clsppal.ntasseg = entidadcretgas.nmonpor


        Dim ds As New DataSet

        Try

            If ds.Tables.Count > 0 Then
                ds.Tables.Clear()
            End If


            ds = clsppal.fxCreatePlain(1, Double.Parse(Me.txtnmoncuo.Text))

            'Dim nCanti3 As Integer
            'nCanti3 = ds.Tables(0).Rows.Count()
            clsppal.PlanTeorico(ds.Tables(0), pcCodcta)

            'i = 1

            'Me.txtcuota.Text = clsppal.pnmonCuo
            'If CheckBox5.Checked = True Then
            '    Me.TextBox19.Text = clsppal.pnmonCuo
            'Else

            'End If


        Catch ex As Exception
            i = 0
        End Try

    End Sub

    Private Sub IgualaDatos(ByVal pcCodcta As String, ByVal pnMonapr As Double)
        Dim lccodcta As String = pcCodcta
        Dim mcretlin As New cCretlin
        Dim ecretlin As New cretlin
        Dim lcnrolin As String
        Dim lntasa As Double = 0

        Dim mcremcre As New cCremcre
        Dim ecremcre As New cremcre

        ecremcre.ccodcta = lccodcta
        mcremcre.ObtenerCremcre(ecremcre)

        lcnrolin = ecremcre.cnrolin


        ecretlin.cnrolin = lcnrolin
        mcretlin.ObtenerCretlin(ecretlin)
        lntasa = ecretlin.ntasint


        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.TxtCodcli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clsppal.lsegvid = eclimide.lsegvida

        clsppal.dFecDes = Session("gdfecSis")

        Dim entidadcredtpl As New cCredtpl
        'clsppal.dfecpri = entidadcredtpl.Obtenerprimeracuota(lccodcta)
        'clsppal.dfecpri0 = entidadcredtpl.ObtenerprimeracuotaCapital(lccodcta)


        clsppal.gnperbas = Session("gnperbas")
        clsppal.nMonDes = pnMonapr 'Double.Parse(TxtCapita.Text)
        'clsppal.nmons = Double.Parse(TxtCapita.Text)
        clsppal.nTasInt = Double.Parse(lntasa)
        clsppal.cCodFor = ecremcre.ctipper
        clsppal.nPerDia = ecremcre.ndiasug
        clsppal.nNroCuo = ecremcre.ncuoapr
        clsppal.cTipCuo = ecremcre.ctipcuo
        clsppal.cTipEst = "N"
        clsppal.nDiaGra = ecremcre.ndiagra
        clsppal.nTipPer = 1
        clsppal.cTipCal = "F"
        clsppal.lFlat = False
        clsppal.lRedo = False
        clsppal.cFlat = ecremcre.cflat
        clsppal.nMeses = ecremcre.nmeses
        clsppal.cNrolin = lcnrolin
        clsppal.pcCodCre = lccodcta
        clsppal.pcCodUsu = Session("gcCodUsu")
        clsppal.dFecsis = Session("gdFecSis")
        clsppal.pctipcon = ecremcre.ctipcon

        clsppal.gnmoncuo = ViewState("pncuota")

        clsppal.cfreccap = ecremcre.cfreccap
        clsppal.cfrecint = ecremcre.cfrecint

        clsppal.pcCodCre = pcCodcta

        clsppal.nPerDia = clsppal.periodo(ecremcre.cfrecint)


    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            'Dim lId As String = Request.QueryString("id")
            'Me.txtcodcli.Value = lId

            Me.CargarCombos()
            Me.Limpiar()

        End If
    End Sub

    

    Private Sub btnAplica_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplica.ServerClick
        Me.Aplica()
    End Sub

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
        If TxtCodcli.Text.Trim = "" Then
            Return
        End If

        'Verifica la conexión
        Dim lccodusu As String
        lccodusu = Session("gccodusu")
        Dim lnretorno As Integer = 0
        lnretorno = clsppal.VerificaConexion(lccodusu)
        If lnretorno = 0 Then
            'Response.Write("<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo')</script>")
            codigoJs = "<script language='javascript'>alert('Se perdio la Conexion, Ingrese de Nuevo', " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        If cmbBancos.Items.Count = 0 Then
            cmbBancos.Enabled = False
            btnGrabar.Disabled = True
            '            Response.Write("<script language='javascript'>alert('Necesita Asignar Bancos a Oficina')</script>")
            codigoJs = "<script language='javascript'>alert('Necesita Asignar Bancos a Oficina, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        Else
            btnGrabar.Disabled = False
            cmbBancos.Enabled = True
        End If


        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim lcnumpar As String
        Dim cClase As New SIM.BL.crefunc
        lcnumpar = cClase.fxStevo(Session("gdfecsis"))
        '        Me.Grabar(lcnumpar, "0")

        'Verifica si ya existio un Desembolso
        If Double.Parse(Me.TextBox12.Text) > 0 Then ' ya hubo un desembolso
            'Me.DesembolsoParcial(lcnumpar, "0")
            DesembolsoTotal(lcnumpar, "0")
        Else
            If CheckBox1.Checked = True Then 'Parcial
                Me.DesembolsoParcial(lcnumpar, "0")
            Else
                Me.Grabar("0")
            End If

        End If
        Txtfactura.Enabled = False


        '        Response.Write("<script language='javascript'>alert('Desembolso Generado, Imprima Comprobante')</script>")
        codigoJs = "<script language='javascript'>alert('Desembolso Generado, Imprima Comprobante, " & _
                                                    "Aviso SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)



    End Sub
    Private Sub Aplicar()
        'Dim lcdescri As Exception
        Dim ds As New DataSet
        'Sacando los datos necesarios para el Desembolso
        Dim lcestado As String
        Dim lndescuento As Double
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre

        Me.txtbandera.Text = 1

        Try

            entidad1.ccodcta = Me.txtCodigo.Text

            ecreditos.ObtenerCremcre(entidad1)

            lcestado = entidad1.cestado


            If lcestado <> "E" Then
                '                Response.Write("<script language='javascript'>alert('Estado de Credito Errado')</script>")
                codigoJs = "<script language='javascript'>alert('Estado de Credito Errado, " & _
                                                    "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

                Exit Sub
            End If

            Me.TxtCodcli.Text = entidad1.ccodcli
            Me.TxtCapita.Text = utilNumeros.Redondear(entidad1.nmonapr, 2)

            'Datos del Cliente
            Dim entidad2 As New SIM.EL.climide
            Dim eClimide As New SIM.BL.cClimide

            entidad2.ccodcli = Me.TxtCodcli.Text


            eClimide.ObtenerClimide(entidad2)

            Me.TxtNomcli.Text = entidad2.cnomcli

            'Numero de Documento para desembolso
            Dim entidadKardex As New SIM.EL.credkar
            Dim eKardex As New SIM.BL.cCredkar

            entidadKardex.ccodcta = Me.txtCodigo.Text.Trim

            Me.TxtDocumento.Text = eKardex.obtenercnrodoc(Me.txtCodigo.Text.Trim)


            '-------------------------------------
            'Sacando los gastos
            '-------------------------------------

            'Comision por Otorgamiento
            Dim entidad3 As New SIM.EL.credgas
            Dim ecredgas As New SIM.BL.cCredgas

            'entidad3.ccodcta = Me.txtCodigo.Text
            'entidad3.ctipgas = "01"
            'entidad3.cnrocuo = "001"
            'entidad3.cdescob = "D"

            'ecredgas.ObtenerCredgas(entidad3)

            'Me.TextBox5.Text = utilNumeros.Redondear(entidad3.nmongas, 2)

            ''Comision por Escrituracion
            'Dim entidad4 As New SIM.EL.credgas

            'entidad4.ccodcta = Me.txtCodigo.Text
            'entidad4.ctipgas = "04"
            'entidad4.cnrocuo = "001"
            'entidad4.cdescob = "D"

            'ecredgas.ObtenerCredgas(entidad4)

            'Me.TextBox6.Text = utilNumeros.Redondear(entidad4.nmongas, 2)

            ''Seguro de Deuda
            'Dim entidad5 As New SIM.EL.credgas

            'entidad5.ccodcta = Me.txtCodigo.Text
            'entidad5.ctipgas = "03"
            'entidad5.cnrocuo = "001"
            'entidad5.cdescob = "D"

            'ecredgas.ObtenerCredgas(entidad5)

            'Me.TextBox7.Text = utilNumeros.Redondear(entidad5.nmongas, 2)

            ''Honorarios por Servicios
            'Dim entidad6 As New SIM.EL.credgas

            'entidad6.ccodcta = Me.txtCodigo.Text
            'entidad6.ctipgas = "08"
            'entidad6.cnrocuo = "001"
            'entidad6.cdescob = "D"

            'ecredgas.ObtenerCredgas(entidad6)

            'Me.TextBox9.Text = utilNumeros.Redondear(entidad6.nmongas, 2)

            ''Derechos de Inscripcion
            'Dim entidad7 As New SIM.EL.credgas

            'entidad7.ccodcta = Me.txtCodigo.Text
            'entidad7.ctipgas = "09"
            'entidad7.cnrocuo = "001"
            'entidad7.cdescob = "D"

            'ecredgas.ObtenerCredgas(entidad7)

            'Me.TextBox10.Text = utilNumeros.Redondear(entidad7.nmongas, 2)

            ''IVA

            'entidad3.ccodcta = Me.txtCodigo.Text
            'entidad3.ctipgas = "02"
            'entidad3.cnrocuo = "001"
            'entidad3.cdescob = "D"

            'ecredgas.ObtenerCredgas(entidad3)

            'Me.txtIVA.Text = utilNumeros.Redondear(entidad3.nmongas, 2)

            'Moneda
            Me.TxtMoneda.Text = "QUETZALES"

            Me.Cargar_Ref()

            'Me.txtDeuda.Text = (Me.TextBox5.Text + Me.TextBox6.Text + Me.TextBox7.Text + Me.TextBox9.Text + Me.TextBox10.Text)
            'Acumula total de Deuda a descontar

            lndescuento = (Double.Parse(Me.TextBox5.Text) + Double.Parse(Me.TextBox6.Text) + Double.Parse(Me.TextBox7.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.txtDeuda.Text) + Double.Parse(Me.txtIVA.Text))

            Me.TxtDescuento.Text = utilNumeros.Redondear(lndescuento, 2)

            'Total a Desembolsar
            Me.TxtDesembolso.Text = utilNumeros.Redondear((Double.Parse(Me.TxtCapita.Text) - lndescuento), 2)

            'Concepto          
            Me.cGlosa.Text = "DESEMB.CREDITO No: " & Me.txtCodigo.Text.Trim & "  " & Me.TxtNomcli.Text.Trim

        Catch ex As Exception
            'Throw ex
        End Try

    End Sub
    Private Sub Grabar(ByVal ctipmet As String)
        Dim cnumpar As String
        Dim cClase As New SIM.BL.crefunc

        Dim filarefina As DataRow
        Me.txtbandera.Text = 0
        Dim nNum As Integer
        Dim x As Integer
        'Dim lcString As String
        Dim ok As Integer
        Dim ekardex As New cCredkar

        'Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)


        If Me.Txtnrochq.Text.Trim = "" _
            Or Me.Txtnrochq.Text.Trim = Nothing Then
            Exit Sub
        End If
        Dim etabtbco As New cTabtbco
        Dim lcctacte As String
        lcctacte = etabtbco.CuentadeBanco1(Me.cmbBancos.SelectedValue.Trim)

        '------------------------------------------------
        'Realizando el refinanciamiento si lo hubiese
        '------------------------------------------------
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date
        ldfecDes = Me.fechaproy()
        Me.txtfecvig.Text = ldfecDes

        '-----------------------------------------------
        cClsDes._gdfecsis = ldfecDes 'Session("gdfecsis")
        'Validar que Variable de Sesion de Usuario no vaya vacio

        Dim lccodusu As String
        lccodusu = Session("gccodusu")
        Dim lnretorno As Integer = 0
        lnretorno = clsppal.VerificaConexion(lccodusu)
        If lnretorno = 0 Then
            '            Response.Write("<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo')</script>")
            codigoJs = "<script language='javascript'>alert('Se perdio Conexion, Ingrese de Nuevo, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        cClsDes._gcCodUsu = lccodusu


        cClsDes._cOficina = Me.TxtOficina.Text.Trim
        cClsDes.cnumrec = Txtfactura.Text.Trim


        Dim lnValida As Integer
        'Obtiene Cheques
        Dim ecredchq As New cCredchq
        Dim dscheques As New DataSet
        dscheques = ecredchq.ObtieneCheques(Me.txtCodigo.Text.Trim)
        Dim fila1 As DataRow
        Dim i As Integer = 0
        Dim lndeuda As Double = 0

        'For Each fila1 In dscheques.Tables(0).Rows
        Dim lndescuento As Double = 0
        lndeuda = 0

        cnumpar = cClase.fxStevo(Session("gdfecsis"))
        Me.txtcnumcom.Text = Me.txtcnumcom.Text.Trim & " - " & cnumpar


        cClsDes._nflag = 1

        cClsDes._nCapita1 = Double.Parse(Me.TxtCapita.Text) 'fila1("nmonto")
        cClsDes._cNomcli = TxtNomcli.Text.Trim  'fila1("cnomchq")
        If i = 0 Then


            'lndescuento = (Double.Parse(Me.TextBox5.Text) + Double.Parse(Me.TextBox6.Text) + Double.Parse(Me.TextBox7.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.txtDeuda.Text) + Double.Parse(Me.txtIVA.Text))
            'Me.TxtDescuento.Text = utilNumeros.Redondear(lndescuento, 2)

            'Total a Desembolsar



            If Me.TxtRefina.Text = "1" Then

                vDetalle = ViewState("Dataset")


                x = vDetalle.Tables(0).Rows.Count()

                If x = 0 Then  'En caso que no devuelva nada se sale
                    Exit Sub
                End If


                Dim Fila As DataRow
                x = 0

                For Each Fila In vDetalle.Tables(0).Rows
                    cClsDes._cCuenta = vDetalle.Tables(0).Rows(x)("IdCuenta")
                    cClsDes._nCapita = vDetalle.Tables(0).Rows(x)("nCapita")
                    cClsDes._nIntere = vDetalle.Tables(0).Rows(x)("nIntere")
                    cClsDes._nIntMor = vDetalle.Tables(0).Rows(x)("nIntMor")
                    cClsDes._nseguro = vDetalle.Tables(0).Rows(x)("nSegdeu")
                    cClsDes._ncomision = vDetalle.Tables(0).Rows(x)("ncomision")
                    cClsDes._nIVA = vDetalle.Tables(0).Rows(x)("niva")



                    cClsDes._nTota = vDetalle.Tables(0).Rows(x)("nTota")
                    cClsDes._cCodcta = Me.txtCodigo.Text.Trim
                    cClsDes._ctrasctb = True

                    lndeuda = lndeuda + vDetalle.Tables(0).Rows(x)("nTota")

                    ok = cClsDes.RealizaRefina()

                    If ok = 0 Then 'Ocurrio un Error
                        Exit Sub
                    End If

                    x += 1
                Next
            End If


            'Asigna gastos a propiedades
            Dim ecredgas As New cCredgas
            Dim dt As New DataTable
            dt = ecredgas.CargaComisiones(Me.txtCodigo.Text.Trim, "D")

            For Each fila In dt.Rows
                lndescuento += fila("nmongas")
            Next
            lndescuento = lndescuento + lndeuda

            'Me.TxtDesembolso.Text = utilNumeros.Redondear((fila1("nmonto") - lndescuento), 2)
            Me.TxtDesembolso.Text = utilNumeros.Redondear(Double.Parse(Me.TxtCapita.Text) - lndescuento, 2)

            cClsDes._cCuenta = Me.txtCodigo.Text.Trim
            cClsDes._nCapita = Double.Parse(Me.TxtCapita.Text)
            'cClsDes._nCapita1 = Double.Parse(Me.TxtCapita.Text)
            cClsDes._nDescuento = Double.Parse(Me.TxtDescuento.Text)
            cClsDes._nDesembolso = Double.Parse(Me.TxtDesembolso.Text)
            cClsDes._nKP = Double.Parse(Me.TxtCapita.Text)
            cClsDes._nCJ = Double.Parse(Me.TxtDesembolso.Text)
            cClsDes._cTipdes = Me.cmbtippag.SelectedItem.Value.Trim
            cClsDes._cTippag = Me.cmbtippag.SelectedItem.Value.Trim
            cClsDes._cBanco = Me.cmbBancos.SelectedValue.Trim
            cClsDes._cCotacte = lcctacte.Trim
            cClsDes._cGlosa = Me.cGlosa.Text.Trim
            'cClsDes._cNomcli = Me.TxtNomcli.Text.Trim
            cClsDes._cNrochq = Me.Txtnrochq.Text.Trim
            cClsDes._cReg = Me.TxtInst.Text.Trim
            cClsDes._cNrodoc = Me.TxtDocumento.Text.Trim
            cClsDes.gniva = Session("gnIVA")
            'Me.TxtDocumento.Text = ekardex.obtenercnrodoc(Me.txtCodigo.Text.Trim)

            Dim lnValida1 As Integer


            lnValida1 = cClsDes.Desembolso(cnumpar, ctipmet, 0, 0)
            If lnValida1 = 0 Then   'Ocurrio un Error se va al Log de Errores
                Exit Sub
            End If

            If cmbtippag.SelectedValue.Trim <> "E" Then
                clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.Txtnrochq.Text.Trim)
            End If


        Else ' a partir de segundo desembolso
            Me.TxtDocumento.Text = ekardex.obtenercnrodoc(Me.txtCodigo.Text.Trim)
            cClsDes._nCapita = Double.Parse(Me.TxtCapita.Text) 'fila1("nmonto")
            cClsDes._nDescuento = 0
            cClsDes._nDesembolso = Double.Parse(Me.TxtDesembolso.Text) 'fila1("nmonto")
            cClsDes._nComOtorg = 0
            cClsDes._nIVA = 0
            cClsDes._nComEsc = 0
            cClsDes._nSegDeu = 0
            cClsDes._nHono = 0
            cClsDes._nDerIns = 0
            cClsDes._nKP = Double.Parse(Me.TxtCapita.Text)
            cClsDes._nCJ = Double.Parse(Me.TxtDesembolso.Text) 'fila1("nmonto")
            cClsDes._cNrodoc = Me.TxtDocumento.Text.Trim


            Me.Txtnrochq.Text = (Integer.Parse(Me.Txtnrochq.Text.Trim) + 1).ToString.Trim
            cClsDes._cNrochq = Me.Txtnrochq.Text.Trim

            lnValida = cClsDes.Desembolso(cnumpar, ctipmet, 0, i)
            If lnValida = 0 Then   'Ocurrio un Error se va al Log de Errores
                Exit Sub
            End If
            If cmbtippag.SelectedValue.Trim <> "E" Then
                clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.Txtnrochq.Text.Trim)
            End If


        End If
        txtnumeros.Text = txtnumeros.Text.Trim & "-" & Txtnrochq.Text.Trim

        i += 1

        'Next 'Fin Cheques
        Me.Cargar_Gastos()

        Me.btnGrabar.Disabled = True
        Me.btnimprimir.Disabled = False
        btnfactura.Disabled = False
    End Sub
    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Me.Limpiar()
    End Sub
    Private Sub Cargar_Gastos()
        Dim lbandera As Boolean = Boolean.Parse(txtflag.Text)
        Dim xy As Integer
        Dim xydata As New DataSet
        Dim clscredgas As New cCredgas
        Dim lctipgas As String
        Dim lngasto As Double
        ViewState("pncom1") = 0
        ViewState("pncom2") = 0
        ViewState("pncom3") = 0
        ViewState("pncom4") = 0
        ViewState("pncom5") = 0
        ViewState("pncom6") = 0
        ViewState("pncom7") = 0

        ViewState("pndeuda") = 0
        ViewState("pccreref") = ""

        If lbandera = False Then


            xydata = clscredgas.ObtenerDataSetPorID2(Me.txtCodigo.Text.Trim, "D")
            xy = xydata.Tables(0).Rows.Count
            If xy = 0 Then

            Else
                xy = 0
                Dim Filaxy As DataRow
                For Each Filaxy In xydata.Tables(0).Rows
                    lctipgas = xydata.Tables(0).Rows(xy)("ctipgas")
                    lngasto = xydata.Tables(0).Rows(xy)("nmongas")

                    If lctipgas = "01" And lngasto <> 0 Then
                        ViewState("pncom1") = ViewState("pncom1") + xydata.Tables(0).Rows(xy)("nmongas")
                    ElseIf lctipgas = "02" And lngasto <> 0 Then
                        ViewState("pncom2") = ViewState("pncom2") + xydata.Tables(0).Rows(xy)("nmongas")
                    ElseIf lctipgas = "03" And lngasto <> 0 Then
                        ViewState("pncom3") = ViewState("pncom3") + xydata.Tables(0).Rows(xy)("nmongas")
                    ElseIf lctipgas = "04" And lngasto <> 0 Then
                        ViewState("pncom4") = ViewState("pncom4") + xydata.Tables(0).Rows(xy)("nmongas")
                    ElseIf lctipgas = "05" And lngasto <> 0 Then
                        ViewState("pncom5") = ViewState("pncom5") + xydata.Tables(0).Rows(xy)("nmongas")
                    ElseIf lctipgas = "06" And lngasto <> 0 Then
                        ViewState("pncom6") = ViewState("pncom6") + xydata.Tables(0).Rows(xy)("nmongas")
                    Else
                        ViewState("pncom7") = ViewState("pncom7") + xydata.Tables(0).Rows(xy)("nmongas")
                    End If
                    xy += 1
                Next
            End If
            refina()
        Else
        End If
    End Sub
    Private Sub refina()
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dscancela As New DataSet
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela
        dscancela = ecancela.ObtenerDataSetPorCuenta(Me.txtCodigo.Text.Trim)

        Dim a As Double = 0
        Dim b As Double = 0
        Dim c As Double = 0
        Dim d As Double = 0
        Dim e As Double = 0
        Dim f As Double = 0
        Dim deuda As Double
        Dim deuda1 As Double
        Dim fila As DataRow
        Dim nelem As Integer = 0
        Dim pcref1 As String
        Dim pcref As String
        If dscancela.Tables(0).Rows.Count = 0 Then
            viewstate("pndeuda") = 0
            viewstate("pccreref") = ""
        Else
            For Each fila In dscancela.Tables(0).Rows
                a = dscancela.Tables(0).Rows(nelem)("nsalcap")
                b = dscancela.Tables(0).Rows(nelem)("nsalint")
                c = dscancela.Tables(0).Rows(nelem)("nsalmor")
                d = dscancela.Tables(0).Rows(nelem)("nmanejo")
                e = dscancela.Tables(0).Rows(nelem)("nseguro")
                f = dscancela.Tables(0).Rows(nelem)("niva")
                deuda1 = a + b + c + d + e + f
                deuda = deuda + deuda1
                pcref1 = dscancela.Tables(0).Rows(nelem)("ccodcta")
                pcref = pcref + IIf(nelem = 0, "", ", ") + pcref1
                nelem += 1
            Next
            viewstate("pndeuda") = deuda
            viewstate("pccreref") = pcref
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        Me.Imprime()
        Me.Limpiar()
    End Sub

    Private Sub btnfactura_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfactura.ServerClick

        'Imprime la Reversión >>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crfacturaDes.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsDes As New DataSet

        Dim eKardex As New SIM.BL.ckardex
        Dim nCanti As Integer
        Dim ldfecha As Date = Session("gdfecsis")
        ldfecha = Date.Parse(Me.txtfecvig.Text.Trim)
        'Crear aqui el dataset
        If Me.txtig.Text.Trim = "0" Then
            dsDes = eKardex.ObtenerDataSetPorcuenta2(Me.txtCodigo.Text.Trim, "EG", Me.Txtnrochq.Text.Trim) 'Me.TxtDocumento.Text.Trim
        Else
            dsDes = eKardex.ObtenerDataSetPorcuenta3(Me.cbxgrupos.Value.Trim, ldfecha, Me.Txtnrochq.Text.Trim) 'Me.TxtDocumento.Text.Trim
        End If

        Dim lnDecimal As Double
        Dim pccantlet1 As String

        Dim lnmonto As Double = 0
        lnmonto = ViewState("pncom1") + ViewState("pncom5")

        pccantlet1 = clsConvert.ConversionEnteros(lnmonto)
        lnDecimal = clsConvert.ExtraeDecimales(lnmonto)
        pccantlet1 = pccantlet1.Trim & " " & lnDecimal.ToString & "/100" & " QUETZALES"


        nCanti = dsDes.Tables(0).Rows.Count

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsDes.Tables(0))
        crRpt.Refresh()
        
        crRpt.SetParameterValue("pnop", lnmonto)
        crRpt.SetParameterValue("pdfecsis", Session("gdfecsis"))
        crRpt.SetParameterValue("pccantlet", pccantlet1)
        crRpt.SetParameterValue("pcnomcli", TxtNomcli.Text.Trim)
        crRpt.SetParameterValue("pcfactura", Txtfactura.Text.Trim)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        Dim reportes As String
        reportes = "factura.pdf"
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        'Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub
    Private Function fechaproy() As Date
        '------------------------------------------------
        'Realizando el refinanciamiento si lo hubiese
        '------------------------------------------------
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date = Session("gdfecsis")
        Dim entidadCredtpl As New SIM.EL.credtpl
        Dim eCredtpl As New SIM.BL.cCredtpl

        entidadCredtpl.ccodcta = Me.txtCodigo.Text.Trim
        entidadCredtpl.ctipope = "D"
        entidadCredtpl.cnrocuo = "001"
        eCredtpl.ObtenerCredtpl(entidadCredtpl)
        ldfecDes = entidadCredtpl.dfecven
        Return ldfecDes
    End Function

    
    Protected Sub cmbBancos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedIndexChanged
        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)
    End Sub

    Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If Double.Parse(TxtCapita.Text) > Double.Parse(TextBox13.Text) Then
                '                Response.Write("<script language='javascript'>alert('Monto Superior a Disponible')</script>")
                codigoJs = "<script language='javascript'>alert('Monto Superior a Disponible, " & _
                                                    "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.TxtCapita.Text = Double.Parse(Me.TextBox13.Text)
            End If
            TxtCapita.Enabled = True
        Else
            TxtCapita.Enabled = False
            Me.TxtCapita.Text = Double.Parse(Me.TextBox13.Text)
        End If
    End Sub

    Private Sub DesembolsoParcial(ByVal cnumpar As String, ByVal ctipmet As String) 'Aca entra cuando hay desembolsos parciales
        Dim filarefina As DataRow
        Me.txtbandera.Text = 0
        Dim nNum As Integer
        Dim x As Integer
        Dim lcString As String
        Dim ok As Integer

        Dim ekardex As New cCredkar
        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)


        If Me.Txtnrochq.Text.Trim = "" _
            Or Me.Txtnrochq.Text.Trim = Nothing Then
            Exit Sub
        End If
        Dim etabtbco As New cTabtbco
        Dim lcctacte As String
        lcctacte = etabtbco.CuentadeBanco1(Me.cmbBancos.SelectedValue.Trim)

        Me.txtcnumcom.Text = Me.txtcnumcom.Text.Trim & " - " & cnumpar
        txtnumeros.Text = txtnumeros.Text.Trim & "-" & Txtnrochq.Text.Trim
        '------------------------------------------------
        'Realizando el refinanciamiento si lo hubiese
        '------------------------------------------------
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date
        ldfecDes = Me.fechaproy()
        Me.txtfecvig.Text = ldfecDes
        cClsDes._nflag = cClsDes._nflag + 1
        '-----------------------------------------------
        cClsDes._gdfecsis = ldfecDes 'Session("gdfecsis")
        cClsDes._gcCodUsu = Session("gcCodusu")
        cClsDes._cOficina = Me.TxtOficina.Text.Trim

        'Dim lnValida As Integer
        Dim lndescuento As Double = 0
        Dim lndeuda As Double = 0

        If Me.TxtRefina.Text = "1" Then

            vDetalle = ViewState("Dataset")


            x = vDetalle.Tables(0).Rows.Count()

            If x = 0 Then  'En caso que no devuelva nada se sale
                Exit Sub
            End If


            Dim Fila As DataRow
            x = 0

            For Each Fila In vDetalle.Tables(0).Rows
                cClsDes._cCuenta = vDetalle.Tables(0).Rows(x)("IdCuenta")
                cClsDes._nCapita = vDetalle.Tables(0).Rows(x)("nCapita")
                cClsDes._nIntere = vDetalle.Tables(0).Rows(x)("nIntere")
                cClsDes._nIntMor = vDetalle.Tables(0).Rows(x)("nIntMor")
                cClsDes._nSeguro = vDetalle.Tables(0).Rows(x)("nSegdeu")
                cClsDes._ncomision = vDetalle.Tables(0).Rows(x)("ncomision")

                cClsDes._nTota = vDetalle.Tables(0).Rows(x)("nTota")
                cClsDes._cCodcta = Me.txtCodigo.Text.Trim
                cClsDes._ctrasctb = True
                lndeuda = lndeuda + vDetalle.Tables(0).Rows(x)("nTota")

                ok = cClsDes.RealizaRefina()

                If ok = 0 Then 'Ocurrio un Error
                    Exit Sub
                End If

                x += 1
            Next
        End If


        'Asigna gastos a propiedades
        Dim ecredgas As New cCredgas
        Dim dt As New DataTable
        dt = ecredgas.CargaComisiones(Me.txtCodigo.Text.Trim, "D")
        For Each fila In dt.Rows
            lndescuento += fila("nmongas")
        Next

        lndescuento = lndescuento + lndeuda
        Me.TxtDescuento.Text = utilNumeros.Redondear(lndescuento, 2) + Double.Parse(Me.txtDeuda.Text)

        'Total a Desembolsar
        Me.TxtDesembolso.Text = utilNumeros.Redondear((Double.Parse(Me.TxtCapita.Text) - lndescuento - Double.Parse(Me.txtDeuda.Text)), 2)



        cClsDes._cCuenta = Me.txtCodigo.Text.Trim
        cClsDes._nCapita = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCapita1 = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nDescuento = Double.Parse(Me.TxtDescuento.Text)
        cClsDes._nDesembolso = Double.Parse(Me.TxtDesembolso.Text)
        cClsDes._nKP = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCJ = Double.Parse(Me.TxtDesembolso.Text)
        cClsDes._cTipdes = Me.cmbtippag.SelectedItem.Value.Trim
        cClsDes._cTippag = Me.cmbtippag.SelectedItem.Value.Trim
        cClsDes._cBanco = Me.cmbBancos.SelectedValue.Trim
        cClsDes._cCotacte = lcctacte.Trim
        cClsDes._cGlosa = Me.cGlosa.Text.Trim
        cClsDes._cNomcli = Me.TxtNomcli.Text.Trim
        cClsDes._cNrochq = Me.Txtnrochq.Text.Trim
        cClsDes._cReg = Me.TxtInst.Text.Trim
        cClsDes._cNrodoc = Me.TxtDocumento.Text.Trim

        Dim lnValida As Integer


        lnValida = cClsDes.Desembolso(cnumpar, ctipmet, 0, 0)
        If lnValida = 0 Then   'Ocurrio un Error se va al Log de Errores
            Exit Sub
        End If
        clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.Txtnrochq.Text.Trim)

        Me.Cargar_Gastos()
        Me.btnGrabar.Disabled = True
        Me.btnimprimir.Disabled = False
        btnfactura.Disabled = False

    End Sub


    Protected Sub TxtCapita_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCapita.TextChanged
        If Double.Parse(TxtCapita.Text) > Double.Parse(TextBox13.Text) Then
            '            Response.Write("<script language='javascript'>alert('Monto Superior a Disponible')</script>")
            codigoJs = "<script language='javascript'>alert('Monto Superior a Disponible, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Me.TxtCapita.Text = Double.Parse(Me.TextBox13.Text)
        End If

        Me.TxtDesembolso.Text = Double.Parse(Me.TxtCapita.Text.Trim) - _
                                Double.Parse(Me.TxtDescuento.Text.Trim)

    End Sub

    Private Sub DesembolsoTotal(ByVal cnumpar As String, ByVal ctipmet As String)
        Dim lbandera As Boolean = Boolean.Parse(txtflag.Text)

        Dim filarefina As DataRow
        Me.txtbandera.Text = 0
        Dim nNum As Integer
        Dim x As Integer
        Dim lcString As String
        Dim ok As Integer
        Dim ekardex As New cCredkar

        Me.Txtnrochq.Text = clsbancos.RetornaCheque(Me.cmbBancos.SelectedValue)


        If Me.Txtnrochq.Text.Trim = "" _
            Or Me.Txtnrochq.Text.Trim = Nothing Then
            Exit Sub
        End If
        Dim etabtbco As New cTabtbco
        Dim lcctacte As String
        lcctacte = etabtbco.CuentadeBanco1(Me.cmbBancos.SelectedValue.Trim)

        Me.txtcnumcom.Text = Me.txtcnumcom.Text.Trim & " - " & cnumpar
        txtnumeros.Text = txtnumeros.Text.Trim & "-" & Txtnrochq.Text.Trim

        '------------------------------------------------
        'Realizando el refinanciamiento si lo hubiese
        '------------------------------------------------
        'busca fecha real de desembolso
        '>>>>>>>>Fecha Real  de Desembolso
        Dim ldfecDes As Date
        ldfecDes = Me.fechaproy()
        Me.txtfecvig.Text = ldfecDes
        cClsDes._nflag = cClsDes._nflag + 1
        '-----------------------------------------------
        cClsDes._gdfecsis = Session("gdfecsis") 'ldfecDes
        cClsDes._gcCodUsu = Session("gcCodusu")
        cClsDes._cOficina = Me.TxtOficina.Text.Trim

        If lbandera = False Then


            If Me.TxtRefina.Text = "1" Then

                vDetalle = ViewState("Dataset")


                x = vDetalle.Tables(0).Rows.Count()

                If x = 0 Then  'En caso que no devuelva nada se sale
                    Exit Sub
                End If


                Dim Fila As DataRow
                x = 0

                For Each Fila In vDetalle.Tables(0).Rows
                    cClsDes._cCuenta = vDetalle.Tables(0).Rows(x)("IdCuenta")
                    cClsDes._nCapita = vDetalle.Tables(0).Rows(x)("nCapita")
                    cClsDes._nIntere = vDetalle.Tables(0).Rows(x)("nIntere")
                    cClsDes._nIntMor = vDetalle.Tables(0).Rows(x)("nIntMor")
                    cClsDes._nSeguro = vDetalle.Tables(0).Rows(x)("nSegdeu")
                    cClsDes._ncomision = vDetalle.Tables(0).Rows(x)("ncomision")

                    cClsDes._nTota = vDetalle.Tables(0).Rows(x)("nTota")
                    cClsDes._cCodcta = Me.txtCodigo.Text.Trim
                    cClsDes._ctrasctb = True

                    ok = cClsDes.RealizaRefina()

                    If ok = 0 Then 'Ocurrio un Error
                        Exit Sub
                    End If

                    x += 1
                Next
            End If



            'Asigna gastos a propiedades
            Dim ecredgas As New cCredgas
            Dim dt As New DataTable
            dt = ecredgas.CargaComisiones(Me.txtCodigo.Text.Trim, "D")
            For Each fila In dt.Rows
                If fila("ccodigo") = "01" Then 'Comision por Otorgamiento
                    cClsDes._nComOtorg = fila("nmongas")
                ElseIf fila("ccodigo") = "02" Then ' Seguro de vida

                ElseIf fila("ccodigo") = "03" Then ' Seguro de deuda
                    cClsDes._nSegDeu = fila("nmongas")
                ElseIf fila("ccodigo") = "04" Then ' Gastos notariales
                    cClsDes._nHono = fila("nmongas")
                ElseIf fila("ccodigo") = "05" Then ' Manejo de cuenta
                    cClsDes._nComEsc = fila("nmongas")
                ElseIf fila("ccodigo") = "06" Then 'Supervision
                    cClsDes._nDerIns = fila("nmongas") 'Derechos de Inscripcion
                ElseIf fila("ccodigo") = "08" Then 'IVA
                    cClsDes._nIVA = fila("nmongas")
                End If


            Next

        Else
            cClsDes._nComOtorg = 0
            cClsDes._nSegDeu = 0
            cClsDes._nHono = 0
            cClsDes._nComEsc = 0
            cClsDes._nDerIns = 0
            cClsDes._nIVA = 0

        End If

        cClsDes._cCuenta = Me.txtCodigo.Text.Trim
        cClsDes._nCapita = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCapita1 = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nDescuento = 0 'Double.Parse(Me.TxtDescuento.Text)
        cClsDes._nDesembolso = Double.Parse(Me.TxtCapita.Text) 'Double.Parse(Me.TxtDesembolso.Text)
        cClsDes._nKP = Double.Parse(Me.TxtCapita.Text)
        cClsDes._nCJ = Double.Parse(Me.TxtCapita.Text) 'Double.Parse(Me.TxtDesembolso.Text)
        cClsDes._cTipdes = Me.cmbtippag.SelectedItem.Value.Trim
        cClsDes._cTippag = Me.cmbtippag.SelectedItem.Value.Trim
        cClsDes._cBanco = Me.cmbBancos.SelectedValue.Trim
        cClsDes._cCotacte = lcctacte.Trim
        cClsDes._cGlosa = Me.cGlosa.Text.Trim
        cClsDes._cNomcli = Me.TxtNomcli.Text.Trim
        cClsDes._cNrochq = Me.Txtnrochq.Text.Trim
        cClsDes._cReg = Me.TxtInst.Text.Trim

        Me.TxtDocumento.Text = ekardex.obtenercnrodoc(Me.txtCodigo.Text.Trim)
        cClsDes._cNrodoc = Me.TxtDocumento.Text.Trim

        Dim lnValida As Integer


        lnValida = cClsDes.Desembolso(cnumpar, ctipmet, 1, 0)
        If lnValida = 0 Then   'Ocurrio un Error se va al Log de Errores
            Exit Sub
        End If
        clsbancos.ActualizaCorrelativo(Me.cmbBancos.SelectedValue.Trim, Me.Txtnrochq.Text.Trim)

        Me.Cargar_Gastos()
        Me.btnGrabar.Disabled = True
        Me.btnimprimir.Disabled = False
        btnfactura.Disabled = False

    End Sub

    Protected Sub cmbtippag_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtippag.SelectedIndexChanged
        If Me.cmbtippag.SelectedValue.Trim = "D" Then
            '    Me.Label28.Visible = False
            '   Me.cmbBancos.Visible = False
            Me.Label29.Visible = False
            Me.Txtnrochq.Visible = False
            Me.Label31.Visible = False
            Me.Txtfactura.Visible = False
        ElseIf Me.cmbtippag.SelectedValue.Trim = "C" Then
            '  Me.Label28.Visible = True
            ' Me.cmbBancos.Visible = True
            Me.Label29.Visible = True
            Me.Txtnrochq.Visible = True
            Me.Label31.Visible = True
            Me.Txtfactura.Visible = True
        Else
            'Me.Label28.Visible = False
            'Me.cmbBancos.Visible = False
            Me.Label29.Visible = False
            Me.Txtnrochq.Visible = False
            Me.Label31.Visible = False
            Me.Txtfactura.Visible = False
        End If
    End Sub
End Class
