Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Imports System.Environment
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System

Public Class CUWSugInd
    Inherits System.Web.UI.UserControl
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private cls_Sim As New SIM.bl.ClsSolicitud
    Private pcCodCta As String
    Private pcCodPre As String
    Private lnmoncuo As Double = 0

    
#Region "Variables"
    Private _URLCodigo As String
    'Private pcCodCta As String
    'Private lNuevo As Boolean
    Private vCnn As Boolean
    Private Transacc As String
    Private ds As New DataSet
    Private ds_R As New DataSet
    Private lnindice_R As Integer
    Private lnindice_R1 As Integer
    Private lncodigo_R As String
    Private lnVal_R As String
    Private llBan_R As Boolean = False
    Private x As Integer
    Private y As Integer
    Private lnusu_R As String
    Private lnapl_R As String
    Private clsConvert As New SIM.BL.ConversionLetras


    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String

    '--------------------------------  
    Private pcTipCre As String
    Private pcNrolin As String
    Private gcCodUsu As String = "FRAN"
    Private pnCiclo As Integer
    Private pcTipGar As String
    Private valor As Integer
    Protected WithEvents Button3 As System.Web.UI.HtmlControls.HtmlInputButton
    Private ValorS As String

    Private cClsDes As New SIM.BL.clsDesembolsa

    Private vDetalle As New DataSet
#End Region
#Region "Propiedades"
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

    Private Sub CargarDatos()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        ds = etabtofi.ObtenerDataSetPorNivel(Session("gnNivel"), Session("gcCodOfi"))

        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxcodofi.DataTextField = "cNomOfi"
        Me.cbxcodofi.DataValueField = "cCodOfi"
        Me.cbxcodofi.DataSource = ds.Tables(0)
        Me.cbxcodofi.DataBind()
        ds.Tables(0).Clear()
        '----------------------------
        'Llenando Institucion
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0541'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxCodIns.DataTextField = "cDescri"
        Me.cbxCodIns.DataValueField = "cCodigo"
        Me.cbxCodIns.DataSource = ds.Tables("Resultado")
        Me.cbxCodIns.DataBind()

        ds.Tables("Resultado").Clear()

        'cbxLineas
        Dim entidad2 As New SIM.EL.cretlin
        Dim clscretlin As New SIM.BL.cCretlin

        Dim mListacretlin As New listacretlin
        mListacretlin = clscretlin.ObtenerLista()
        '        ecretlin.ObtenerLista()

        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = mListacretlin
        Me.cbxLineas.DataBind()

        '>>>>>>>>>>>>>>>>>>>>>>>>
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0771'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Datos a Eligir", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxContrato.DataTextField = "cDescri"
        Me.cbxContrato.DataValueField = "cCodigo"
        Me.cbxContrato.DataSource = ds.Tables("Resultado")
        Me.cbxContrato.DataBind()

        '<<<<<<<<<<<<<<<<<<<<<<<<



        Me.txtfecpri.Text = Today.AddMonths(1)
        Me.TxtDescuento.Text = 0
        Me.TxtDesembolso.Text = 0
        Me.TxtCapita.Text = 0
        Me.TxtRefina.Text = 0

        Session.Add("flagref", 0)

        Me.btnQuitar.Visible = False

        '----------------------------
        'Llenando Grupos
        '----------------------------
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
        Me.Label6.Visible = False
        Me.cbxgrupos.Disabled = True

        ds.Tables("Resultado").Clear()

        Dim dst As New DataSet
        Dim ctabttab As New cTabttab
        dst = ctabttab.ObtenerDataSetPorID("060", "1")
        Me.cbxCapital.DataTextField = "cDescri"
        Me.cbxCapital.DataValueField = "cCodigo"
        Me.cbxCapital.DataSource = dst.Tables(0)
        Me.cbxCapital.DataBind()

        Dim etabttab As New cTabttab
        dst.Clear()
        dst = etabttab.ObtenerFrecuencia("A")

        Me.cbxInteres.DataTextField = "cDescri"
        Me.cbxInteres.DataValueField = "cCodigo"
        Me.cbxInteres.DataSource = dst.Tables(0)
        Me.cbxInteres.DataBind()

        ds.Tables("Resultado").Clear()

        '*************causas de rechazo*****************
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab  ='042' and cTipReg = '1' order by cdescri "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'Response.Write("<script language='javascript'>alert('No existen operaciones')</script>")
            Exit Sub
        End If

        Me.ddlcausa.DataTextField = "cDescri"
        Me.ddlcausa.DataValueField = "cCodigo"
        Me.ddlcausa.DataSource = ds.Tables("resultado")
        Me.ddlcausa.DataBind()

        ds.Tables("Resultado").Clear()
    End Sub
    Private Sub CargarDatosCredito()
        InitBtn()
        Dim lcestado As String = ""
        Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta
        ecreditos.Obtenercreditos(entidad3)
        Me.txtcCodCli.Text = entidad3.ccodcli
        If entidad3.cestado <> "A" And entidad3.cestado <> "C" Then
            Response.Write("<script language='javascript'>alert('Estado Errado')</script>")
            Return
        End If
        lcestado = entidad3.cestado.Trim

        Me.txtcNomcli.Text = entidad3.cnomcli
        Session.Add("gcNomChq", Me.txtcNomcli.Text.Trim)
        clase.cNomChq = entidad3.cnomcli


        Me.txtMonSol.Text = entidad3.nmonsol
        Me.txtNomAna.Text = entidad3.cNomUsu
        Me.txtmonSug.Text = IIf(entidad3.nmonsug = 0, entidad3.nmonsol, entidad3.nmonsug)


        Me.pnCuoSug.Text = IIf(entidad3.ncuosug = 0, 6, entidad3.ncuosug)
        Me.pnDiaSug.Text = IIf(entidad3.ndiasug = 0, Day(Today()), entidad3.ndiasug)
        Me.pnPerGra.Text = IIf(entidad3.ndiagra = 0, 0, entidad3.ndiagra)
        Me.txtnmeses.Text = IIf(entidad3.nmeses = 0, 6, entidad3.nmeses)
        Me.txtFecDes.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)



        Dim ecredtpl As New cCredtpl
        Me.txtfecpri.Text = ecredtpl.Obtenerprimeracuota(pcCodCta)

        If entidad3.cfreccap = Nothing Or IsDBNull(entidad3.cfreccap) Then

        Else
            Me.cbxCapital.SelectedValue = entidad3.cfreccap
        End If

        cargacombointeres()
        Me.cbxInteres.SelectedValue = IIf(IsDBNull(entidad3.cfrecint), "M", entidad3.cfrecint)

        'tipo de cuota
        If entidad3.cestado = "A" And (entidad3.ccodsol <> "" Or entidad3.ccodsol.Trim <> "") Then
            entidad3.ctipcuo = "5"
        End If
        If entidad3.ctipcuo = "1" Then
            Me.RadioButton1.Checked = True
        ElseIf entidad3.ctipcuo = "3" Then
            Me.RadioButton2.Checked = True
        ElseIf entidad3.ctipcuo = "4" Then
            Me.RadioButton3.Checked = True
        ElseIf entidad3.ctipcuo = "5" Then
            Me.RadioButton5.Checked = True
        ElseIf entidad3.ctipcuo = "6" Then
            Me.RadioButton4.Checked = True
        End If



        'verifica numero de creditos
        Dim lnciclo As Integer
        lnciclo = ecreditos.ciclo(Me.txtcCodCli.Text.Trim, pcCodCta)
        Dim lcletras As String
        lcletras = clsConvert.ConversionEnteros(lnciclo)
        If lnciclo > 1 Then
            ViewState("pctippre") = lcletras + " CREDITOS "
        Else
            ViewState("pctippre") = "NUEVO"
        End If
        '        viewstate("pctippre") = IIf(entidad3.ctipcre = "N", "NUEVO", "RECURRENTE")
        Me.TxtCapita.Text = Me.txtmonSug.Text


      
        If IsDBNull(entidad3.ccodfue) Then
        Else
            CargaLineasxFondos(entidad3.ccodfue)
        End If

        If IsDBNull(entidad3.cnrolin) Then
        Else
            Me.cbxLineas.SelectedValue = entidad3.cnrolin
        End If








        Me.cbxcodofi.SelectedValue = entidad3.ccodcta.Substring(3, 3)

        If entidad3.ccodsol = "" Or entidad3.ccodsol.Trim = "" Then
            Me.cbxgrupos.Visible = False
            Me.Label6.Visible = False

        Else
            Me.cbxgrupos.Value = entidad3.ccodsol
            Me.cbxgrupos.Visible = True
            Me.Label6.Visible = True
        End If



        pcCodAct = entidad3.ccodact
        Session.Add("pcCodcli", Me.txtcCodCli.Text)
        '
        Dim entidad4 As New SIM.EL.clidfin
        Dim clsclidfin As New SIM.BL.cClidfin

        Dim mListaclidfin As New listaclidfin
        mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)
        '        ecretlin.ObtenerLista()

        Me.cbxfueing.DataTextField = "cNomfue"
        Me.cbxfueing.DataValueField = "cCodcli"
        Me.cbxfueing.DataSource = mListaclidfin
        Me.cbxfueing.DataBind()

        Me.CargaActividad()

        Me.txtgarantias.Text = clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        Localiza_Ref()

        'Hace asignaciones
        If cbxgrupos.Value.Trim = Me.txtgrupo.Text.Trim Then
            If Me.txtfondo.Text.Trim <> "" Then
                CargaLineasxFondos(Me.txtfondo.Text.Trim)
                If Me.txtlinea.Text.Trim <> "" Then
                    Me.cbxLineas.SelectedValue = Me.txtlinea.Text.Trim
                End If
            End If
            If Me.txtcuotas.Text.Trim <> "" Then
                pnCuoSug.Text = Me.txtcuotas.Text
            End If


        End If
    End Sub
    Private Sub Meses()
        If Me.RadioButton6.Checked = True Then 'Periodo Fijo
            Select Case Me.pnDiaSug.Text
                Case Me.pnDiaSug.Text = 7
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text / 4)
                Case Me.pnDiaSug.Text = 14
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text / 2)
                Case Me.pnDiaSug.Text = 15
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text / 2)
                Case Me.pnDiaSug.Text = 30
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text)
                Case Me.pnDiaSug.Text = 31
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text)
                Case Me.pnDiaSug.Text = 60
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text * 2)
                Case Me.pnDiaSug.Text = 90
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text * 3)
                Case Me.pnDiaSug.Text = 120
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text * 4)
                Case Me.pnDiaSug.Text = 360
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text * 12)
                Case Me.pnDiaSug.Text = 365
                    Me.txtnmeses.Text = CInt(Me.pnCuoSug.Text * 12)
                Case Else
                    Me.txtnmeses.Text = Me.pnCuoSug.Text
            End Select
        Else 'Fecha Fija
            Me.txtnmeses.Text = Me.pnCuoSug.Text
        End If
        clase.nMeses = Me.txtnmeses.Text
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

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        vDetalle = cClsDes.CargaRefina()
        Dim i As Integer
        For i = 1 To lneleref
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
            clsaplica.pdfecval = Date.Parse(Me.txtFecDes.Text)
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "C"
            clsaplica.gnpergra = Session("gnpergra")
            clsaplica.omcalcinterest("T", Date.Parse(Me.txtFecDes.Text))

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

            Dim ecredkar As New cCredkar
            Dim ldfecult As Date
            ldfecult = ecredkar.UltimafechaProceso(lccodcta1, Date.Parse(Me.txtFecDes.Text))


            'lndias = DateDiff(DateInterval.Day, clsaplica.pdultpag, clsaplica.pdfecval)
            lndias = DateDiff(DateInterval.Day, ldfecult, clsaplica.pdfecval)
            If pccodlin.Substring(8, 2) = "06" Then
                lncomision = 0
            Else
                If clsaplica.pdfecvig > #11/1/2005# Then
                    lncomision = utilNumeros.Redondear((clsaplica.pncapdes * (Session("gncomtra") / 100) * lndias) / clsaplica.gnperbas, 2)
                Else
                    lncomision = 0
                End If

            End If
            If lsegdeu = True Then
                If clsaplica.pdfecvig >= #7/11/2008# Then
                    lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Session("gnSegVm1") / 31) * lndias, 2)
                Else
                    lnsegdeu = utilNumeros.Redondear((clsaplica.pncapdes * Session("gnSegVm") / 31) * lndias, 2)
                End If

            Else
                lnsegdeu = 0
            End If
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
            dr("nTota") = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2) + _
                          utilNumeros.Redondear(clsaplica.pnsalint, 2) + _
                          utilNumeros.Redondear(clsaplica.pnsalmor, 2) + _
                        utilNumeros.Redondear(clsaplica.pncomision, 2) + _
                            utilNumeros.Redondear(clsaplica.segdeu, 2)
            dr("nComision") = utilNumeros.Redondear(clsaplica.pncomision, 2)
            dr("nSegDeu") = utilNumeros.Redondear(clsaplica.segdeu, 2)
            'Acumula Descuento
            Me.TxtDescuento.Text = Double.Parse(Me.TxtDescuento.Text.Trim) + dr("nTota")
            Me.TxtDesembolso.Text = Double.Parse(Me.TxtCapita.Text.Trim) - _
                                    Double.Parse(Me.TxtDescuento.Text.Trim)

            vDetalle.Tables("Refina").Rows.Add(dr)

            Me.Datagrid1.DataSource = vDetalle.Tables("Refina")

            Me.Datagrid1.DataBind()

            viewstate.Add("Dataset", vDetalle)
            Session("flagref") = 1
            Me.TxtRefina.Text = "1"

            Graba_Refinanciados()
        Next
    End Sub
    Public Sub CargarCancela()
        Dim dsc As New DataSet
        Dim ecancela As New cCancela
        Dim filac As DataRow
        Dim elemc As Integer = 0
        dsc = ecancela.ObtenerDataSetPorID(pccodcta)
        If dsc.Tables(0).Rows.Count = 0 Then
        Else
            For Each filac In dsc.Tables(0).Rows
                Me.Refinaciamiento(dsc.Tables(0).Rows(elemc)("ccodcta"))
                elemc += 1
            Next
        End If
    End Sub
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
            Me.txtFecDes.Text = Today()
            Me.CargarDatos()
            CargaVariables()
        End If
    End Sub
    Private Sub CargaVariables()

        viewstate.Add("pcnomcli", "") 'nombre de cliente
        viewstate.Add("pcdestino", "") 'destino
        viewstate.Add("pcdeslin", "") 'nombre de linea
        viewstate.Add("pctippre", "") ' tipo de credito
        viewstate.Add("pcfuente", "") 'fuente de fondos
        viewstate.Add("pctasa", "") 'tasa de interes
        viewstate.Add("pcagencia", "") 'agencia
        viewstate.Add("pnmonsug", 0) 'monto sugerido
        viewstate.Add("pctasmor", "") ' tasa moratoria
        viewstate.Add("pcmeses", "") 'meses
        viewstate.Add("pcnomchq", "") ' Cheque a nombre de 
        viewstate.Add("pdfecha", Today()) ' fecha de desembolso
        viewstate.Add("pcgarantia", "") 'Garantias
        viewstate.Add("pccanLet", "") ' cantidad en letras
        'viewstate.Add("pncuota", 0) 'cuota sugerida
        viewstate.Add("pctipo", "") 'tipo de garantia
        viewstate.Add("pcforpag", "") ' forma de pago
        viewstate.Add("pcnomana", "") ' nombre de analista
        viewstate.Add("pccontrato", "") 'tipo de contrato
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate.Add("pcComite1", "") 'comite de credito nivel 1
        viewstate.Add("pcComite2", "") 'comite de credito nivel 2
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ' comisiones '
        viewstate.Add("pncom1", 0)
        viewstate.Add("pccom1", "")

        viewstate.Add("pncom2", 0)
        viewstate.Add("pccom2", "")

        viewstate.Add("pncom3", 0)
        viewstate.Add("pccom3", "")

        viewstate.Add("pncom4", 0)
        viewstate.Add("pccom4", "")

        viewstate.Add("pncom5", 0)
        viewstate.Add("pccom5", "")

        viewstate.Add("pncom6", 0)
        viewstate.Add("pccom6", "")
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate.Add("pndeuda", 0) 'valor a refinanciar
        viewstate.Add("pccreref", "") 'credito a ser refinanciado

        ViewState.Add("causa", "")
    End Sub

    Public Sub InitBtn()

        Me.btnAplicar.Disabled = False
        Me.btnGrabar.Disabled = True
        Me.btnPlan.Disabled = False
        Me.btnInicializar.Disabled = False

        Me.btnIA.Disabled = True
    End Sub
    Private Sub CargaActividad()
        'Carga Actividad
        Dim pcCodact1 As String
        Dim entidad_clidfin As New SIM.EL.clidfin
        Dim eclidfin As New SIM.BL.cClidfin
        entidad_clidfin.ccodcli = Me.cbxfueing.SelectedValue.Trim
        eclidfin.ObtenerClidfinporCliente(entidad_clidfin) '(entidad_clidfin)
        pcCodact1 = entidad_clidfin.ccodact

        Dim entidad_ciiu As New SIM.EL.tabtciu
        Dim etabtciu As New SIM.BL.cTabtciu
        entidad_ciiu.ccodigo = pcCodact1
        etabtciu.ObtenerTabtciu(entidad_ciiu)
        Me.txtActCre.Text = entidad_ciiu.cdescri
    End Sub



    Private Sub IgualaDatos()
        pcCodCta = Me.txtCredito.Text
        Dim dsCre As New DataSet
        Dim eCremcre As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab
        Dim lcdestino As String

        dsCre = eCremcre.Resumen(Me.txtCredito.Text.Trim)
        If dsCre.Tables(0).Rows.Count = 0 Then
            lcdestino = "CAPITAL DE TRABAJO"
        Else
            lcdestino = etabttab.Describe(dsCre.Tables(0).Rows(0)("cdescre"), "005")
        End If




        Dim lnTasa As Double
        Dim ds As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        Dim lccodlin As String
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin


        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        lnTasa = entidadCretlin.ntasint

        Me.txtnliminf.Text = entidadCretlin.nliminf
        Me.txtnlimsup.Text = entidadCretlin.nlimsup
        Me.txtcplazo.Text = entidadCretlin.ccodlin.Substring(1, 1)

        viewstate("pctasmor") = entidadCretlin.ntasmor.ToString
        ViewState("pctasa") = entidadCretlin.ntasint.ToString
        viewstate("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        viewstate("pnmonsug") = Me.txtmonSug.Text
        viewstate("pcmeses") = Me.txtnmeses.Text
        If Me.txtmonSug.Text <= 5000 Then
            viewstate("pccomite1") = "X"
            viewstate("pccomite2") = ""
        Else
            viewstate("pccomite2") = "X"
            viewstate("pccomite1") = ""
        End If
        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.txtcCodCli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clase.lsegvid = eclimide.lsegvida

        'localiza fuente de fondos en base a cCodlin
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        lccodlin = entidadCretlin.ccodlin

        Dim clstabttab As New cTabttab
        Dim ds033 As New DataSet
        Dim lcfondos As String
        Dim nelemf As Integer
        lcfondos = lccodlin.ToString.Substring(2, 2).Trim
        Me.txtfondo.Text = lcfondos.Trim
        ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos)
        nelemf = ds033.Tables(0).Rows.Count
        If nelemf = 0 Then
            viewstate("pcfuente") = ""
        Else
            viewstate("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        viewstate("pcnomchq") = entidadCredchq.cnomchq
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate("pdfecha") = Date.Parse(Me.txtFecDes.Text)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        If Me.RadioButton1.Checked = True Then
            lcTipPer = "1"
            lcFlat = ""
        ElseIf Me.RadioButton2.Checked = True Then
            lcTipPer = "3"
            lcFlat = ""
        ElseIf Me.RadioButton3.Checked = True Then
            lcTipPer = "4"
            lcFlat = ""
            Me.pnCuoSug.Text = 1
        ElseIf Me.RadioButton4.Checked = True Then
            lcTipPer = "6"
            lcFlat = ""
        ElseIf Me.RadioButton5.Checked = True Then
            lcTipPer = "5"
            lcFlat = "F"
        End If
        If Me.RadioButton6.Checked = True Then
            lnTipCuo = "1"
        Else
            lnTipCuo = "2"
        End If
        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)
        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtmonSug.Text 'Integer.Parse(Me.txtmonSug.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        clase.cCodFor = lnTipCuo
        clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = lcFlat
        clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.pcCodCre = pcCodCta
        clase.pcCodUsu = Session("gcCodUsu")
        clase.dFecsis = Session("gdFecSis")
        clase.pctipcon = Me.cbxContrato.SelectedItem.Value.Trim


        clase.cfreccap = Me.cbxCapital.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres.SelectedValue.Trim

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        viewstate("pccontrato") = Me.cbxContrato.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        viewstate("pcnomcli") = Me.txtcNomcli.Text

        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        viewstate("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        viewstate("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        viewstate("pccanlet") = clsConvert.ConversionEnteros(Double.Parse(Me.txtmonSug.Text.Trim))
        lnDecimal = clsConvert.ExtraeDecimales(Me.txtmonSug.Text.Trim)
        ViewState("pccanlet") = ViewState("pccanlet") & " " & lnDecimal.ToString & "/100" & " QUETZALES"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dstipo As New DataSet
        Dim mcrepgar As New cCrepgar
        Dim nelemgar As Integer
        'dstipo = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        dstipo = clase.Garantizados(Me.txtcCodCli.Text.Trim)

        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            viewstate("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            viewstate("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            If dstipo.Tables(0).Rows(0)("ctipgar") = "05" Then
                viewstate("pctipo") = "CREDITO PREFERENCIAL"
            Else
                viewstate("pctipo") = "MIXTA"
            End If
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim clsclimgar As New cClimgar
        Dim dsgar As New DataSet
        Dim nelemg As Integer = 0
        Dim pcgar As String = ""
        Dim garant As String = ""

        dsgar = clsclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        nelemg = dsgar.Tables(0).Rows.Count
        If nelemg = 0 Then
            viewstate("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            viewstate("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Me.txtgrupo.Text = Me.cbxgrupos.Value
        Me.txtlinea.Text = Me.cbxLineas.SelectedValue
        Me.txtcuotas.Text = Me.pnCuoSug.Text

        Cargar_Gastos()
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        Me.txtCredito.Text = codigoCliente.Trim
        pcCodCta = codigoCliente
        'Me.btnAplicar_Click(Me, New System.EventArgs)
        CargarDatosCredito()
    End Sub
    Public Sub CargarPlan(ByVal codigoCliente As String)
        ' Me.btnPlan_Click(Me, New EventArgs)
        IgualaDatos()
        ds = clase.fxCreatePlain(1, 0)
        Dim nCanti3 As Integer
        nCanti3 = ds.Tables(0).Rows.Count()
        clase.PlanTeorico(ds.Tables(0), pcCodCta)
        Me.txtdFecVen.Text = clase.dFecVen.ToString
        lnmoncuo = clase.pnmonCuo
        Session.Item("CodigoCre") = pcCodCta

        Me.btnGrabar.Disabled = False

        Me.pnCuoSug.Enabled = False
        Me.pnDiaSug.Enabled = False
        Me.pnPerGra.Enabled = False
        Me.txtnmeses.Enabled = False
        Me.txtmonSug.Enabled = False
        Me.txtFecDes.Enabled = False
    End Sub

    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("WfBusLin.aspx")
        Me.txtMonSol.Text = viewstate("vnMonSol")
    End Sub

    Private Sub txtNomAna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Imprimir()
        Dim lchequeo1 As String = ""
        Dim lchequeo2 As String = ""
        Dim lchequeo3 As String = ""
        Dim lchequeo4 As String = ""

        Dim ecreditos As New ccreditos
        ecreditos.Chequeointerno(Me.txtcCodCli.Text.Trim, Me.txtCredito.Text.Trim)
        lchequeo1 = ecreditos.chequeo1
        lchequeo2 = ecreditos.chequeo2
        lchequeo3 = ecreditos.chequeo3
        lchequeo4 = ecreditos.chequeo4

        Dim ldfecsis As Date
        ldfecsis = Session("gdfecsis")
        Dim lctiper As String
        Dim lndia As Integer
        Dim lnnumcuo As Integer
        Dim lcforma As String
        If Me.RadioButton6.Checked = False Then
            lctiper = "1"
        Else
            lctiper = "2"
        End If
        lndia = Me.pnDiaSug.Text
        lnnumcuo = Me.pnCuoSug.Text
        lcforma = clase.formapago(lctiper, lndia, lnnumcuo)
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crresumen.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsCre As New DataSet
        Dim eCremcre As New SIM.BL.ccreditos
        dsCre = eCremcre.Resumen(Me.txtCredito.Text.Trim)
        If dsCre.Tables(0).Rows.Count = 0 Then
            Return
        End If
        Dim ldnacimi As DateTime
        Dim lnedad As Integer
        Dim ldfecha As Date
        Dim lcestciv As String
        Dim lccivil As String
        Dim lcsector As String
        Dim lcactividad As String
        Dim lccodact As String
        Dim lcteldom As String

        lcestciv = dsCre.Tables(0).Rows(0)("cestciv")
        ldnacimi = dsCre.Tables(0).Rows(0)("dnacimi")
        lcteldom = dsCre.Tables(0).Rows(0)("cteldom")
        ldfecha = Session("gdfecsis")
        lnedad = ldfecha.Year - ldnacimi.Year
        ' Setear los registros recuperados, diciendole el Table respectivo
        Dim etabttab As New cTabttab
        Dim eciiu As New cTabtciu
        Dim lcdestino As String

        lccivil = etabttab.Describe(lcestciv, "012")
        lcsector = etabttab.Describe(dsCre.Tables(0).Rows(0)("csececo"), "021")
        If IsDBNull(dsCre.Tables(0).Rows(0)("cdescre")) Then
            dsCre.Tables(0).Rows(0)("cdescre") = ""
        End If
        lcdestino = etabttab.Describe(dsCre.Tables(0).Rows(0)("cdescre"), "005")
        lccodact = dsCre.Tables(0).Rows(0)("ccodact")
        lcactividad = eciiu.CIIU(lccodact)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'Fiadores
        Dim dsfia As New DataSet
        Dim eclimgar As New cClimgar
        dsfia = eclimgar.Fiadores(Me.txtcCodCli.Text.Trim)
        Dim fia1, fia2, fia3 As String
        Dim dui1, dui2, dui3 As String
        Dim dir1, dir2, dir3 As String
        Dim nit1, nit2, nit3 As String
        Dim prof1, prof2, prof3 As String
        Dim tel1, tel2, tel3 As String
        Dim lctipogar As String
        Dim lcvalorgar As Double
        lctipogar = eclimgar.GarantiaTipo(Me.txtcCodCli.Text.Trim)
        lcvalorgar = eclimgar.ValorGarantia(Me.txtcCodCli.Text.Trim)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        fia1 = ""
        fia2 = ""
        fia3 = ""
        '>>>>>>>>
        dui1 = ""
        dui2 = ""
        dui3 = ""
        '>>>>>>>>
        dir1 = ""
        dir2 = ""
        dir3 = ""
        '>>>>>>>>
        nit1 = ""
        nit2 = ""
        nit3 = ""
        '>>>>>>>>
        prof1 = ""
        prof2 = ""
        prof3 = ""
        '>>>>>>>>
        tel1 = ""
        tel2 = ""
        tel3 = ""
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'Verifica si es preferencial
        Dim lnverifica As Integer
        lnverifica = eclimgar.ValidaGarantiaPref(Me.txtcCodCli.Text.Trim)
        If lnverifica = 0 Then
            If dsfia.Tables(0).Rows.Count = 0 Then
            Else
                Dim nelem As Integer
                Dim Fila As DataRow
                Dim lcprofe As String
                nelem = 0
                For Each Fila In dsfia.Tables(0).Rows
                    If nelem = 0 Then
                        fia1 = dsfia.Tables(0).Rows(nelem)("cnomfia")
                        dui1 = dsfia.Tables(0).Rows(nelem)("cduifia")
                        dir1 = dsfia.Tables(0).Rows(nelem)("cdirfia")
                        nit1 = dsfia.Tables(0).Rows(nelem)("cnitfia")
                        prof1 = dsfia.Tables(0).Rows(nelem)("cproffia")
                        tel1 = dsfia.Tables(0).Rows(nelem)("ctelfia")
                    ElseIf nelem = 1 Then
                        fia2 = dsfia.Tables(0).Rows(nelem)("cnomfia")
                        dui2 = dsfia.Tables(0).Rows(nelem)("cduifia")
                        dir2 = dsfia.Tables(0).Rows(nelem)("cdirfia")
                        nit2 = dsfia.Tables(0).Rows(nelem)("cnitfia")
                        prof2 = dsfia.Tables(0).Rows(nelem)("cproffia")
                        tel2 = dsfia.Tables(0).Rows(nelem)("ctelfia")
                    ElseIf nelem = 2 Then
                        fia3 = dsfia.Tables(0).Rows(nelem)("cnomfia")
                        dui3 = dsfia.Tables(0).Rows(nelem)("cduifia")
                        dir3 = dsfia.Tables(0).Rows(nelem)("cdirfia")
                        nit3 = dsfia.Tables(0).Rows(nelem)("cnitfia")
                        prof3 = dsfia.Tables(0).Rows(nelem)("cproffia")
                        tel3 = dsfia.Tables(0).Rows(nelem)("ctelfia")
                    End If
                    nelem += 1
                Next
            End If
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim etabtprf As New cTabtprf
        Dim lcprofes As String
        Dim lcprofcon As String
        lcprofes = etabtprf.profesion(IIf(IsDBNull(dsCre.Tables(0).Rows(0)("ccodpro")), "137", dsCre.Tables(0).Rows(0)("ccodpro")))
        lcprofcon = etabtprf.profesion(IIf(IsDBNull(dsCre.Tables(0).Rows(0)("cprofcon")), "137", dsCre.Tables(0).Rows(0)("cprofcon")))
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim eclidfin As New cClidfin
        Dim dsneg As New DataSet
        dsneg = eclidfin.ObtenerDataSetPorCodigo(Me.txtcCodCli.Text.Trim)
        Dim lcnomfue As String
        Dim lcubifue As String
        Dim lcdirfue As String
        Dim lccodfue As String
        Dim lcsececo As String
        Dim lcanoubi As String

        If dsneg.Tables(0).Rows.Count = 0 Then
            lcnomfue = ""
            lcubifue = ""
            lcdirfue = ""
            lccodfue = ""
            lcsececo = ""
            lcanoubi = ""
        Else
            lcnomfue = dsneg.Tables(0).Rows(0)("cnomfue")
            lcubifue = dsneg.Tables(0).Rows(0)("cubifue")
            lcdirfue = dsneg.Tables(0).Rows(0)("cdirfue")
            lccodfue = dsneg.Tables(0).Rows(0)("ccodfue")
            lcsececo = dsneg.Tables(0).Rows(0)("csececo")
            lcanoubi = dsneg.Tables(0).Rows(0)("canoubi")
        End If
        Dim lczona As String
        Dim ezona As New cTabtzon
        lczona = ezona.Zona(lcubifue)
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        crRpt.SetDataSource(dsCre.Tables(0))

        'crRpt.Refresh()
        crRpt.SetParameterValue("pnedad", lnedad)
        crRpt.SetParameterValue("pccivil", lccivil)
        crRpt.SetParameterValue("pcsector", lcsector)
        crRpt.SetParameterValue("pcactividad", lcactividad)
        crRpt.SetParameterValue("pccodact", lccodact)
        crRpt.SetParameterValue("pcteldom", lcteldom)
        crRpt.SetParameterValue("pcdirfue", lcdirfue)
        crRpt.SetParameterValue("pcanoubi", lcanoubi)
        crRpt.SetParameterValue("pcprofes", lcprofes)
        crRpt.SetParameterValue("pcprofcon", lcprofcon)
        crRpt.SetParameterValue("pcnomana", Me.txtNomAna.Text.Trim)
        crRpt.SetParameterValue("pcdestino", lcdestino)
        crRpt.SetParameterValue("pctipogar", viewstate("pctipo")) 'lctipogar
        crRpt.SetParameterValue("pcvalorgar", lcvalorgar)
        crRpt.SetParameterValue("pncuosug", Double.Parse(Me.pnCuoSug.Text))
        crRpt.SetParameterValue("pcforma", lcforma)
        crRpt.SetParameterValue("pczona", lczona)
        crRpt.SetParameterValue("pdfecsis", ldfecsis)
        crRpt.SetParameterValue("pnmoncuo", viewstate("pncuota"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>fiadores
        crRpt.SetParameterValue("pcfia1", fia1)
        crRpt.SetParameterValue("pcfia2", fia2)
        crRpt.SetParameterValue("pcfia3", fia3)
        '****
        crRpt.SetParameterValue("pcdui1", dui1)
        crRpt.SetParameterValue("pcdui2", dui2)
        crRpt.SetParameterValue("pcdui3", dui3)
        '****
        crRpt.SetParameterValue("pcdir1", dir1)
        crRpt.SetParameterValue("pcdir2", dir2)
        crRpt.SetParameterValue("pcdir3", dir3)
        '****
        crRpt.SetParameterValue("pcnit1", nit1)
        crRpt.SetParameterValue("pcnit2", nit2)
        crRpt.SetParameterValue("pcnit3", nit3)
        '****
        crRpt.SetParameterValue("pcprof1", prof1)
        crRpt.SetParameterValue("pcprof2", prof2)
        crRpt.SetParameterValue("pcprof3", prof3)
        '****
        crRpt.SetParameterValue("pctel1", tel1)
        crRpt.SetParameterValue("pctel2", tel2)
        crRpt.SetParameterValue("pctel3", tel3)

        crRpt.SetParameterValue("pchequeo1", lchequeo1)
        crRpt.SetParameterValue("pchequeo2", lchequeo2)
        crRpt.SetParameterValue("pchequeo3", lchequeo3)
        crRpt.SetParameterValue("pchequeo4", lchequeo4)

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()
        Response.Clear()

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub
    Private Sub ImprimirIA()


        Dim dsgarantias As New DataSet
        Dim mclimgar As New cClimgar
        Dim mcrepgar As New cCrepgar
        Try

            'dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
            dsgarantias = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        Catch ex As Exception

        End Try

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream
        Dim reportes As String


        Try
            'Cargar Definicion del Reporte
            crRptIA.Load(Server.MapPath("reportes") + "\crIA.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRptIA.SetDataSource(dsgarantias.Tables(0))
        crRptIA.Refresh()

        Dim pccodcta1 As String
        Dim pccodcli1 As String
        Dim pcnomana1 As String

        pccodcta1 = Me.txtCredito.Text.Trim 'pcCodCta
        pccodcli1 = Me.txtcCodCli.Text.Trim
        pcnomana1 = Me.txtNomAna.Text.Trim

        crRptIA.SetParameterValue("lcnomcli", viewstate("pcnomcli"))
        crRptIA.SetParameterValue("lcdestino", viewstate("pcdestino"))
        crRptIA.SetParameterValue("lcdeslin", viewstate("pcdeslin"))
        crRptIA.SetParameterValue("lctippre", viewstate("pctippre"))
        crRptIA.SetParameterValue("lcfondos", viewstate("pcfuente"))
        crRptIA.SetParameterValue("lctasa", viewstate("pctasa"))
        crRptIA.SetParameterValue("lcagencia", viewstate("pcagencia"))
        crRptIA.SetParameterValue("lnmonsug", viewstate("pnmonsug"))
        crRptIA.SetParameterValue("lctasmor", viewstate("pctasmor"))
        crRptIA.SetParameterValue("lcmeses", viewstate("pcmeses"))
        crRptIA.SetParameterValue("lcnomchq", viewstate("pcnomchq"))
        crRptIA.SetParameterValue("ldfecha", viewstate("pdfecha"))
        crRptIA.SetParameterValue("lcgarantia", "")
        crRptIA.SetParameterValue("lccanlet", viewstate("pccanlet"))
        crRptIA.SetParameterValue("lncuosug", viewstate("pncuota"))
        crRptIA.SetParameterValue("lctipo", viewstate("pctipo"))
        crRptIA.SetParameterValue("lcforpag", viewstate("pcforpag"))
        crRptIA.SetParameterValue("lccodcta", pccodcta1)
        crRptIA.SetParameterValue("lccodcli", pccodcli1)
        crRptIA.SetParameterValue("lcnomana", pcnomana1)
        crRptIA.SetParameterValue("lccontrato", viewstate("pccontrato"))
        crRptIA.SetParameterValue("lccomite1", viewstate("pccomite1"))
        crRptIA.SetParameterValue("lccomite2", viewstate("pccomite2"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRptIA.SetParameterValue("lncom1", viewstate("pncom1"))
        crRptIA.SetParameterValue("lccom1", viewstate("pccom1"))

        crRptIA.SetParameterValue("lncom2", viewstate("pncom2"))
        crRptIA.SetParameterValue("lccom2", viewstate("pccom2"))

        crRptIA.SetParameterValue("lncom3", viewstate("pncom3"))
        crRptIA.SetParameterValue("lccom3", viewstate("pccom3"))

        crRptIA.SetParameterValue("lncom4", viewstate("pncom4"))
        crRptIA.SetParameterValue("lccom4", viewstate("pccom4"))

        crRptIA.SetParameterValue("lncom5", viewstate("pncom5"))
        crRptIA.SetParameterValue("lccom5", viewstate("pccom5"))

        crRptIA.SetParameterValue("lncom6", viewstate("pncom6"))
        crRptIA.SetParameterValue("lccom6", viewstate("pccom6"))

        crRptIA.SetParameterValue("lndeuda", viewstate("pndeuda"))
        crRptIA.SetParameterValue("lccreref", viewstate("pccreref"))

        reportes = "crIA.pdf"

        rptStreamIA = CType(crRptIA.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStreamIA.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        'Response.End()

        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    End Sub


    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        CargarDatosCredito()
    End Sub



    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick
        Dim ecredppg As New cCredppg
        Dim lvalida As Boolean


        Dim ldvenci As Date
        IgualaDatos()


        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        clase.cfreccap = Me.cbxCapital.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres.SelectedValue.Trim

        'Valida Frecuencia de pagos
        lvalida = ecredppg.ValidaFrecuencia(Me.cbxCapital.SelectedValue.Trim, Me.cbxInteres.SelectedValue.Trim, Integer.Parse(Me.pnCuoSug.Text))
        If lvalida = False Then
            Response.Write("<script language='javascript'>alert('Verifique Condiciones de Forma de Pago')</script>")
            Return
        End If


        ds = clase.fxCreatePlain(1, 0)

        'obtiene los gastos del desembolso
        Dim dr1 As DataRow
        For Each dr1 In ds.Tables(0).Rows
            If dr1("ctipope") = "D" Then
                Me.txtgastos.Text = dr1("ngastos")
            Else
                ldvenci = dr1("dFecPro")
            End If
        Next
        Me.txtvencimiento.Text = ldvenci.ToString

        Dim nCanti3 As Integer
        nCanti3 = ds.Tables(0).Rows.Count()
        clase.PlanTeorico(ds.Tables(0), pcCodCta)
        Me.txtdFecVen.Text = clase.dFecVen.ToString
        Session.Item("CodigoCre") = pcCodCta
        ViewState("pncuota") = clase.pnmonCuo

        Me.FormaPago()

        Dim lcvalida As String
        lcvalida = clase.ValidaLinea(Me.cbxLineas.SelectedItem.Value.Trim, Double.Parse(Me.txtmonSug.Text), Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtvencimiento.Text))
        If lcvalida = False Then
            Me.btnGrabar.Disabled = True
            Response.Write("<script language='javascript'>alert('Linea Iválida, Verificar Plazo y/o Monto')</script>")
            Return
        Else
            Me.btnGrabar.Disabled = False
        End If
        'plazo en meses
        Me.txtnmeses.Text = clase.PlazoMeses(Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))
        ViewState("pcmeses") = Me.txtnmeses.Text


        Me.pnCuoSug.Enabled = False
        Me.pnDiaSug.Enabled = False
        Me.pnPerGra.Enabled = False
        Me.txtnmeses.Enabled = False
        Me.txtmonSug.Enabled = False
        Me.txtFecDes.Enabled = False

    End Sub

    Private Sub btnInicializar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicializar.ServerClick
        Me.pnCuoSug.Enabled = True
        Me.pnDiaSug.Enabled = True
        Me.pnPerGra.Enabled = True
        Me.txtnmeses.Enabled = True
        Me.txtmonSug.Enabled = True
        Me.txtFecDes.Enabled = True
        'Me.InitBtn()
    End Sub

    

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick

        Dim nombre As String
        Dim tipo As String

        If Me.cbxContrato.SelectedValue.Trim = "A" Then
            tipo = "A"
        ElseIf Me.cbxContrato.SelectedValue.Trim = "B" Then
            tipo = "B"
        ElseIf Me.cbxContrato.SelectedValue.Trim = "C" Then
            tipo = "C"
        ElseIf Me.cbxContrato.SelectedValue.Trim = "D" Then
            tipo = "D"
        ElseIf Me.cbxContrato.SelectedValue.Trim = "E" Then
            tipo = "E"
        ElseIf Me.cbxContrato.SelectedValue.Trim = "O" Then
            tipo = "O"
        End If

        IgualaDatos()


        '        IgualaDatos()
        Meses()
        'clase.cCodRec = ""
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
    

        clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)
        'Carga Codigo de Fuente de ingreso
        Dim entidad_clidfin As New SIM.EL.clidfin
        Dim eclidfin As New SIM.BL.cClidfin
        entidad_clidfin.ccodcli = Me.cbxfueing.SelectedValue.Trim
        eclidfin.ObtenerClidfinporCliente(entidad_clidfin) '(entidad_clidfin)
        clase.cCodfue = entidad_clidfin.ccodfue
        clase.cCodact = entidad_clidfin.ccodact

        If ViewState("causa") = "SI" Then
            clase.cCodRec = Me.ddlcausa.SelectedItem.Value.Trim
        Else
            clase.cCodRec = ""
        End If
        clase.gnmoncuo = ViewState("pncuota")

        clase.Graba_Sugerencia()
        Graba_Refinanciados()

        Me.ddlcausa.Visible = False
        Me.Label27.Visible = False

        If ViewState("causa") = "SI" Then
            Response.Write("<script language='javascript'>alert('Solicitud Rechazada')</script>")
            Exit Sub

        End If
        'If tipo = "A" Then
        '    nombre = "PAGARE "
        '    contratos(nombre, "A")
        'ElseIf tipo = "B" Or tipo = "D" Then
        '    nombre = "MUTUOG "
        '    contratos(nombre, tipo)
        'Else
        '    nombre = "PRENDA "
        '    contratos(nombre, tipo)
        'End If

        Me.btnGrabar.Disabled = True
        Me.btnPlan.Disabled = True


        Me.btnIA.Disabled = False
        Me.btnGrabar.DataBind()

        

        'Me.btnResCom_ServerClick(sender, e)
        Response.Write("<script language='javascript'>alert('Datos Sugeridos Grabados, Imprima Reportes')</script>")
    End Sub

    Private Sub txtmonSug_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonSug.TextChanged
        Me.TxtCapita.Text = Me.txtmonSug.Text
        'Acumula Descuento
        Me.TxtDesembolso.Text = Double.Parse(Me.TxtCapita.Text.Trim) - _
                                Double.Parse(Me.TxtDescuento.Text.Trim)

    End Sub
    Public Sub Graba_Refinanciados()
        If Session("flagref") = 0 Then
            Me.Datagrid1.DataSource = ""
            Me.Datagrid1.DataBind()
            Me.btnQuitar.Visible = False
            Return
        End If
        If IsDBNull(viewstate("Dataset")) Then
            Me.btnQuitar.Visible = False
            Return
        End If


        'If viewstate("Dataset") = Nothing Then
        'Return
        'End If


        Dim xy As Integer
        Dim ok As Integer
        vDetalle = viewstate("Dataset")
        xy = vDetalle.Tables(0).Rows.Count()

        If xy = 0 Then  'En caso que no devuelva nada se sale
            Me.btnQuitar.Visible = False
            Exit Sub
        End If
        Dim Fila As DataRow

        'Primero Limpia, para luego Grabar
        'clase.pcCodCre = Me.txtCredito.Text
        'clase.Borra_Refinados()

        xy = 0
        For xy = 0 To Me.Datagrid1.Items.Count - 1
            clase.pcCodCre = Me.txtCredito.Text
            clase.pcCodRef = Me.Datagrid1.Items(xy).Cells(0).Text
            clase.Borra_Refinados() ' borra refinanciado antes de agregar

            clase.pnSalCap = Me.Datagrid1.Items(xy).Cells(1).Text
            clase.pnSalInt = Me.Datagrid1.Items(xy).Cells(2).Text
            clase.pnSalMor = Me.Datagrid1.Items(xy).Cells(3).Text
            clase.pnSegDeu = Me.Datagrid1.Items(xy).Cells(4).Text
            clase.pnComPer = Me.Datagrid1.Items(xy).Cells(5).Text
            ok = clase.Graba_Refinados()
            If ok = 0 Then 'Ocurrio un Error
                Exit Sub
            End If
        Next

      
        Me.btnQuitar.Visible = True
    End Sub
    Private Sub Localiza_Ref()
        Me.CargarCancela()
        ' Dim dsRef As New DataSet

        'Dim ecancela As New cCancela
        'dsRef = ecancela.ObtenerDataSetPorID(pcCodCta)
        'If dsRef.Tables(0).Rows.Count = 0 Then

        'Else
        '   pcCodPre = dsRef.Tables(0).Rows(0)("cCodcta")
        '  Me.Refinaciamiento(pcCodPre)
        'End If
    End Sub
    Private Sub FormaPago()
        Dim lcforma As String
        If Me.RadioButton6.Checked = False Then 'Fecha Fija
            lcforma = "MENSUALES"
        ElseIf Me.RadioButton6.Checked = True Then 'Periodo Fijo
            If Me.pnDiaSug.Text = 1 Then
                lcforma = "DIARIAS"
            ElseIf Me.pnDiaSug.Text = 7 Or Me.pnDiaSug.Text = 8 Then
                lcforma = "SEMANALES"
            ElseIf Me.pnDiaSug.Text = 14 Or Me.pnDiaSug.Text = 15 Then
                lcforma = "QUINCENALES"
            ElseIf Me.pnDiaSug.Text >= 28 And Me.pnDiaSug.Text <= 31 Then
                lcforma = "MENSUALES"
            ElseIf Me.pnDiaSug.Text = 60 Then
                lcforma = "BIMENSUALES"
            ElseIf Me.pnDiaSug.Text = 90 Then
                lcforma = "TRIMESTRALES"
            ElseIf Me.pnDiaSug.Text = 120 Then
                lcforma = "CADA CUATRO MESES"
            ElseIf Me.pnDiaSug.Text = 180 Then
                lcforma = "SEMESTRALES"
            ElseIf Me.pnDiaSug.Text >= 360 And Me.pnDiaSug.Text <= 365 Then
                lcforma = "ANUALES"
            Else
                lcforma = "NO DEFINIDO"
            End If
        End If

        ViewState("pcforpag") = Me.pnCuoSug.Text.ToString & " CUOTAS " & lcforma & " de Q" & clase.pnmonCuo.ToString & " c/u. que comprende capital e intereses."
        If Me.pnDiaSug.Text = 1 Then
            ViewState("pcforpag") = "una cuota al vencimientode Q " & clase.pnmonCuo.ToString & " c/u. que comprende capital e intereses"
        End If
    End Sub
    Private Sub Cargar_Gastos()
        Dim xy As Integer
        Dim xydata As New DataSet
        Dim clscredgas As New cCredgas
        Dim lctipgas As String
        Dim lngasto As Double
        xydata = clscredgas.ObtenerDataSetPorID2(pcCodCta, "D")
        xy = xydata.Tables(0).Rows.Count
        If xy = 0 Then

        Else
            xy = 0
            Dim Filaxy As DataRow
            For Each Filaxy In xydata.Tables(0).Rows
                lctipgas = xydata.Tables(0).Rows(xy)("ctipgas")
                lngasto = xydata.Tables(0).Rows(xy)("nmongas")
                If lctipgas = "01" And lngasto <> 0 Then
                    viewstate("pncom1") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom1") = "X"
                ElseIf lctipgas = "03" And lngasto <> 0 Then
                    viewstate("pncom2") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom2") = "X"
                ElseIf lctipgas = "04" And lngasto <> 0 Then
                    viewstate("pncom3") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom3") = "X"
                ElseIf lctipgas = "PR" And lngasto <> 0 Then
                    viewstate("pncom4") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom4") = "X"
                ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
                    viewstate("pncom5") = xydata.Tables(0).Rows(xy)("nmongas")
                    viewstate("pccom5") = "X"
                ElseIf lctipgas = "02" And lngasto <> 0 Then
                    ViewState("pncom6") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom6") = "X"
                End If
                xy += 1
            Next
        End If
        refina()
    End Sub
    Private Sub refina()
        Dim dscancela As New DataSet
        Dim entidad_cancela As New SIM.EL.cancela
        Dim ecancela As New SIM.BL.cCancela
        dscancela = ecancela.ObtenerDataSetPorCuenta(pcCodCta)

        'entidad_cancela.ccodpre = pcCodCta
        'ecancela.ObtenerCancela(entidad_cancela)
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim e As Double
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
                deuda1 = a + b + c + d + e
                deuda = deuda + deuda1
                pcref1 = dscancela.Tables(0).Rows(nelem)("ccodcta")
                pcref = pcref + IIf(nelem = 0, "", ", ") + pcref1
                nelem += 1
            Next

            viewstate("pndeuda") = deuda
            viewstate("pccreref") = pcref
        End If

    End Sub

    Sub contratos(ByVal contrato As String, ByVal tipocontrato As String)

        Dim input As String
        Dim lcnomcli As String
        Dim lcnombar As String
        Dim lcnombre As String

        'escribir
        lcnombre = contrato & Me.txtcNomcli.Text.Trim & ".doc"
        Const fsoLectura = 1
        Const fsoescritura = 2

        Dim objFSO
        'Instanciación del objeto FSO
        objFSO = Server.CreateObject("Scripting.FileSystemObject")

        'Abrir el archivo de texto
        Dim objTextStream
        objTextStream = objFSO.OpenTextFile("C:\wwwsim\contratos2\" & lcnombre, fsoescritura, True)

        'determina que tipo de contrato elegir
        'segun modelos existentes
        Dim nombrecontrato As String
        If tipocontrato = "A" Then
            nombrecontrato = "pagare"
        ElseIf tipocontrato = "B" Then
            nombrecontrato = "mutuog"
        ElseIf tipocontrato = "C" Then
            nombrecontrato = "fidufona"
        ElseIf tipocontrato = "D" Then
            nombrecontrato = "mixta"
        ElseIf tipocontrato = "E" Then
            nombrecontrato = "fiduci"
        End If

        'fin modelos de contratos

        'fin escribir
        lcnombar = nombrecontrato & ".txt"

        lcnombre = Me.txtcNomcli.Text.Trim
        'lee un archivo de texto
        Dim FILE_NAME As String = "c:/wwwsim/contratos/" & lcnombar
        If Not File.Exists(FILE_NAME) Then
            Return
        End If


        Dim lccodcli As String
        Dim lnmonsug As Double
        Dim lncuosug As Double
        Dim lcmonto As String
        Dim lnentero As Double
        Dim lndeci As Double
        Dim lccuosug As String
        Dim etabttab As New tabttab
        Dim mtabttab As New cTabttab
        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre
        Dim ecredtpl As New credtpl
        Dim mcredtpl As New cCredtpl

        Dim lcdestino As String
        Dim lncuota As Double
        Dim lccuota As String
        Dim lcfecha As String
        Dim ldfecha As Date

        Dim lnmes As Integer
        Dim lndia As Integer
        Dim lnano As Integer
        Dim lcmes As String
        Dim lccodpro As String

        Dim mclimide As New cClimide
        Dim eclimide As New climide
        Dim etabtprf As New tabtprf
        Dim mtabtprf As New cTabtprf
        Dim lcprofesion As String
        Dim lcdirdom As String
        Dim lcedad As String = ""
        Dim lcdui As String
        Dim lcdesdui As String
        Dim lntam As Integer
        Dim i As Integer
        Dim lcdesdui1 As String
        Dim lcdesdui2 As String
        Dim lcultimo As String
        Dim lcprimero As String
        Dim lcnit As String
        Dim lcdesnit As String
        Dim lcdesnit2 As String
        Dim ldvencimiento As Date
        Dim lcvencimiento As String
        Dim lcmonpre As String
        Dim lccoddom As String
        '>>>>>>>>>>>>>>>>>>>>>>>
        Dim lcplazo1 As String

        Dim lctiper As String
        Dim lndia1 As Integer
        Dim lnnumcuo As Integer
        Dim lcforma As String


        Dim lcdiapago As String = ""

        If Me.RadioButton6.Checked = False Then
            lctiper = "1"
        Else
            lctiper = "2"
        End If
        lndia1 = Me.pnDiaSug.Text
        lnnumcuo = Me.pnCuoSug.Text
        lcforma = clase.formapago2(lctiper, lndia1)

        lcdiapago = Num2Text(lndia1)


        Dim lctasalet As String = ""
        lctasalet = Num2Text(viewstate("pctasa")) + " POR CIENTO ANUAL"
        '<<<<<<<<<<<<<<<<<<<<<<<
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon
        Dim lcmunicipio As String
        Dim lcdepartamento As String
        Dim lcplazo As String
        Dim lcdias As String
        Dim lccredito As String

        eclimide.ccodcli = lccodcli

        lcnomcli = Me.txtcNomcli.Text.Trim
        lccodcli = Me.txtcCodCli.Text.Trim
        lnmonsug = Double.Parse(Me.txtmonSug.Text.Trim)
        lncuosug = Double.Parse(Me.pnCuoSug.Text.Trim)
        lcmonpre = Me.txtmonSug.Text.Trim

        lnentero = Decimal.Floor(lnmonsug)
        lndeci = Math.Round((lnmonsug - lnentero) * 100)
        If lndeci > 0 Then
            lcmonto = Num2Text(lnentero) & " QUETZALES " & " CON " & Num2Text(lndeci) & " CENTAVOS" 'monto en letras
        Else
            lcmonto = Num2Text(lnentero) & " QUETZALES " 'monto en letras
        End If

        lccuosug = Num2Text(lncuosug) & " CUOTAS " 'cuotas en letras
        lcplazo = Num2Text(lncuosug) ' " CUOTAS "
        lcplazo1 = Num2Text(lncuosug - 1)




        ecremcre.ccodcta = Me.txtCredito.Text.Trim
        mcremcre.ObtenerCremcre(ecremcre)
        lccodcli = ecremcre.ccodcli
        lccredito = Me.txtCredito.Text.Trim

        etabttab.ccodtab = "005"
        etabttab.ctipreg = "1"
        etabttab.ccodigo = ecremcre.cdescre.Trim
        mtabttab.ObtenerTabttab(etabttab)

        lcdestino = etabttab.cdescri.Trim  'destino del credito

        ecredtpl.ccodcta = Me.txtCredito.Text.Trim
        ecredtpl.ctipope = "N"
        ecredtpl.cnrocuo = "001"
        mcredtpl.ObtenerCredtpl(ecredtpl)
        clase.gnperbas = Session("gnperbas")
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        lncuota = clase.ValorCuotaCredtpl(Me.txtCredito.Text.Trim) 'ecredtpl.ncapita + ecredtpl.nintere + ecredtpl.ngastos

        lnentero = Decimal.Floor(lncuota)
        lndeci = Math.Round((lncuota - lnentero) * 100)
        If lndeci > 0 Then
            lccuota = Num2Text(lnentero) & " CON " & Num2Text(lndeci) & " CENTAVOS" 'monto en letras
        Else
            lccuota = Num2Text(lnentero) 'monto en letras
        End If

        'fecha desembolso
        ldfecha = Date.Parse(Me.txtFecDes.Text)
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcmes = MonthName(lnmes)
        lcfecha = Num2Text(lndia) & " DIAS DEL MES DE " & lcmes & " DE " & Num2Text(lnano)
        lcfecha = lcfecha.ToLower
        lcdias = Num2Text(lndia)

        'obtiene fecha de vencimiento
        ldvencimiento = Date.Parse(Me.txtvencimiento.Text)
        lnmes = ldvencimiento.Month
        lndia = ldvencimiento.Day
        lnano = ldvencimiento.Year
        lcmes = MonthName(lnmes)
        lcvencimiento = Num2Text(lndia) & " DEL MES DE " & lcmes & " DE " & Num2Text(lnano)
        lcvencimiento = lcvencimiento.ToLower


        'obtiene datos del cliente
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)
        lcdirdom = eclimide.cdirdom
        lcdui = eclimide.cnudoci.Trim
        lcdui = lcdui.Replace("-", "")
        lcnit = eclimide.cnudotr.Trim
        lccoddom = eclimide.ccoddom.Trim

        lccodpro = eclimide.ccodpro
        etabtprf.ccodigo = lccodpro
        mtabtprf.ObtenerTabtprf(etabtprf)
        lcprofesion = etabtprf.cdescri.Trim  ' profesion
        If eclimide.dnacimi <> Nothing Then
            lcedad = Num2Text(Math.Round(Date.Now.Year - eclimide.dnacimi.Year))
            lcedad = lcedad.ToLower
        End If
        'detalla el dui en letras


        lcdesdui = Me.Duiletras(lcdui)


        'detalla el nit
        lntam = lcnit.Length
        If lntam <> 17 Then
            lcdesnit = ""
            '            Response.Write("<script language='javascript'>alert('Nit del cliente no posee 17 caracteres')</script>")
        Else
            lcdesnit2 = lcnit.Substring(0, 4)
            lcdesnit = Num2Text(Integer.Parse(lcdesnit2))
            lcdesnit2 = lcnit.Substring(5, 6)
            lcdesnit = lcdesnit & " - " & Num2Text(Integer.Parse(lcdesnit2))
            lcdesnit2 = lcnit.Substring(12, 3)
            lcdesnit = lcdesnit & " - " & Num2Text(Integer.Parse(lcdesnit2))
            lcdesnit2 = lcnit.Substring(lntam - 1, 1)
            lcdesnit = lcdesnit & " - " & Num2Text(Integer.Parse(lcdesnit2))
            lcdesnit = lcdesnit.ToLower
        End If

        'obtiene municipio y departamento

        etabtzon.ccodzon = lccoddom
        etabtzon.ctipzon = "3"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcmunicipio = etabtzon.cdeszon.Trim
        lcmunicipio = lcmunicipio.ToLower
        'departamento
        etabtzon.ccodzon = lccoddom.Substring(0, 2)
        etabtzon.ctipzon = "1"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcdepartamento = etabtzon.cdeszon.Trim
        lcdepartamento = lcdepartamento.ToLower

        '**************************obtiene datos del fiador******************

        Dim eclimgar As New climgar
        Dim mclimgar As New cClimgar
        Dim lccoduni As String
        Dim lcnombre1 As String = ""
        Dim lcnit1 As String = ""
        Dim lcdui1 As String = ""
        Dim lccodpro1 As String = ""
        Dim ldnacimi1 As Date
        Dim lcdesnit2f As String = ""
        Dim lcdesnitf As String = ""
        Dim lcdesduif As String = ""
        Dim lcdesdui2f As String = ""
        Dim lcprofesion1 As String = ""
        Dim lcedad1 As String = ""
        Dim lnedad1 As Double = 0
        Dim lccoddom1 As String = ""
        Dim lcmunicipio1 As String = ""
        Dim lcdepartamento1 As String = ""
        Dim lcdesduif1 As String = ""
        'Para fiador 2
        Dim lcnombre2 As String = ""
        Dim lcedad2 As String = ""
        Dim lcprofesion2 As String = ""
        Dim lcmunicipio2 As String = ""
        Dim lcdepartamento2 As String = ""
        Dim lcdesduif2 As String = ""

        Dim lcnit2 As String = ""
        Dim lcdui2 As String = ""
        Dim lccodpro2 As String = ""
        Dim ldnacimi2 As Date
        Dim lccoddom2 As String
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim lnfia As Integer = 0

        lccoduni = "**"
        eclimgar.ccodcli = lccodcli

        Dim ds As New DataSet
        ds = mclimgar.ObtenerDataSetPor_Garantia_Cliente(lccodcli, "01")
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            Dim ele As Integer = 0
            For Each fila In ds.Tables(0).Rows
                lnfia += 1
                If lnfia = 1 Then
                    lccoduni = ds.Tables(0).Rows(ele)("ccoduni")
                    eclimide.ccodcli = lccoduni
                    mclimide.ObtenerClimide(eclimide)
                    lcnombre1 = eclimide.cnomcli.Trim
                    lcnit1 = eclimide.cnudotr.Trim
                    lcdui1 = eclimide.cnudoci.Trim
                    lcdui1 = lcdui1.Replace("-", "")
                    lccodpro1 = eclimide.ccodpro.Trim
                    ldnacimi1 = eclimide.dnacimi
                    lccoddom1 = eclimide.ccoddom.Trim


                    'detalla el nit
                    lntam = lcnit1.Length
                    If lntam <> 17 Then
                        lcdesnitf = ""
                        lcdesnit2f = ""
                        '                Response.Write("<script language='javascript'>alert('Nit del fiador no posee 17 caracteres')</script>")
                    Else

                        lcdesnit2f = lcnit1.Substring(0, 4)
                        lcdesnitf = Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnit2f = lcnit1.Substring(5, 6)
                        lcdesnitf = lcdesnitf & " - " & Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnit2f = lcnit1.Substring(12, 3)
                        lcdesnitf = lcdesnitf & " - " & Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnit2f = lcnit1.Substring(lntam - 1, 1)
                        lcdesnitf = lcdesnitf & " - " & Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnitf = lcdesnitf.ToLower
                    End If

                    'detalla el dui en letras


                    lcdesduif1 = Me.Duiletras(lcdui1)


                    'obtiene profesion
                    etabtprf.ccodigo = lccodpro1
                    mtabtprf.ObtenerTabtprf(etabtprf)
                    lcprofesion1 = etabtprf.cdescri.Trim
                    lcprofesion1 = lcprofesion1.ToLower

                    'obtiene edad
                    lnedad1 = Date.Now.Year - ldnacimi1.Year
                    lcedad1 = Num2Text(lnedad1)
                    lcedad1 = lcedad1.ToLower

                    'domicilio
                    'obtiene municipio y departamento

                    etabtzon.ccodzon = lccoddom1
                    etabtzon.ctipzon = "3"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcmunicipio1 = etabtzon.cdeszon.Trim
                    lcmunicipio1 = lcmunicipio1.ToLower

                    'departamento
                    etabtzon.ccodzon = lccoddom1.Substring(0, 2)
                    etabtzon.ctipzon = "1"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcdepartamento1 = etabtzon.cdeszon.Trim
                    lcdepartamento1 = lcdepartamento1.ToLower
                End If
                'Segundo fiador >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If lnfia = 2 Then
                    lccoduni = ds.Tables(0).Rows(ele)("ccoduni")
                    eclimide.ccodcli = lccoduni
                    mclimide.ObtenerClimide(eclimide)
                    lcnombre2 = eclimide.cnomcli.Trim
                    lcnit2 = eclimide.cnudotr.Trim
                    lcdui2 = eclimide.cnudoci.Trim
                    lcdui2 = lcdui2.Replace("-", "")
                    lccodpro2 = eclimide.ccodpro.Trim
                    ldnacimi2 = eclimide.dnacimi
                    lccoddom2 = eclimide.ccoddom.Trim


                    'detalla el nit
                    lntam = lcnit2.Length
                    If lntam <> 17 Then
                        lcdesnitf = ""
                        lcdesnit2f = ""

                    Else

                        lcdesnit2f = lcnit2.Substring(0, 4)
                        lcdesnitf = Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnit2f = lcnit2.Substring(5, 6)
                        lcdesnitf = lcdesnitf & " - " & Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnit2f = lcnit2.Substring(12, 3)
                        lcdesnitf = lcdesnitf & " - " & Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnit2f = lcnit2.Substring(lntam - 1, 1)
                        lcdesnitf = lcdesnitf & " - " & Num2Text(Integer.Parse(lcdesnit2f))
                        lcdesnitf = lcdesnitf.ToLower
                    End If

                    'detalla el dui en letras


                    lcdesduif2 = Me.Duiletras(lcdui2)



                    'obtiene profesion
                    etabtprf.ccodigo = lccodpro2
                    mtabtprf.ObtenerTabtprf(etabtprf)
                    lcprofesion2 = etabtprf.cdescri.Trim
                    lcprofesion2 = lcprofesion1.ToLower

                    'obtiene edad
                    lnedad1 = Date.Now.Year - ldnacimi2.Year
                    lcedad1 = Num2Text(lnedad1)
                    lcedad2 = lcedad2.ToLower

                    'domicilio
                    'obtiene municipio y departamento

                    etabtzon.ccodzon = lccoddom2
                    etabtzon.ctipzon = "3"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcmunicipio2 = etabtzon.cdeszon.Trim
                    lcmunicipio2 = lcmunicipio2.ToLower

                    'departamento
                    etabtzon.ccodzon = lccoddom2.Substring(0, 2)
                    etabtzon.ctipzon = "1"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcdepartamento2 = etabtzon.cdeszon.Trim
                    lcdepartamento2 = lcdepartamento2.ToLower
                End If
                ele += 1
            Next

        End If

        'Garantia Prendaria
        Dim ds1 As New DataSet
        Dim lngarpre As Integer = 0
        Dim lcinmueble1 As String = ""
        Dim lcdescri1 As String = ""
        ds1 = mclimgar.ObtenerDataSetPor_Garantia_Prendaria(lccodcli)
        If ds1.Tables(0).Rows.Count > 0 Then
            lngarpre = ds1.Tables(0).Rows.Count
            Dim fila1 As DataRow
            Dim ele1 As Integer = 0
            Dim lcdescri As String
            For Each fila1 In ds1.Tables(0).Rows
                lcdescri1 = ds1.Tables(0).Rows(ele1)("cdescri")
                lcinmueble1 = lcinmueble1 + lcdescri1.Trim

                ele1 += 1
                If lngarpre = ele1 Then
                    lcinmueble1 = lcinmueble1 + " "
                Else
                    lcinmueble1 = lcinmueble1 + ","
                End If
            Next
        End If


        Dim sr As StreamReader = File.OpenText(FILE_NAME)

        input = sr.ReadLine()


        While Not input Is Nothing
            input = sr.ReadLine()
            If input = "**" Then
                Exit While
            End If

            input = input.Replace("/*nombre/", lcnomcli)
            input = input.Replace("/*edad/", lcedad)
            input = input.Replace("/*profesion/", lcprofesion)
            input = input.Replace("/*domicilio/", lcmunicipio) 'Session("gcnomciu")
            input = input.Replace("/*dui/", lcdesdui)
            'input = input.Replace("/*dui/", lcdesdui)

            input = input.Replace("/*nit/", lcdesnit)

            input = input.Replace("/*montodolares/", lcmonto)
            'nuevas variables
            input = input.Replace("/*montovalor/", lnmonsug.ToString)
            input = input.Replace("/*destino/", viewstate("pcdestino"))

            '--------------------------------------------------------

            input = input.Replace("/*fechavencimiento/", lcvencimiento)
            input = input.Replace("/*fechacontrato/", lcfecha)
            input = input.Replace("/*montonumero/", lcmonpre)

            input = input.Replace("/*montocuotadolares/", lccuota)

            input = input.Replace("/*departamento/", lcdepartamento)
            input = input.Replace("/*domicilio/", lcmunicipio)
            input = input.Replace("/*plazo/", lcplazo)
            input = input.Replace("/*ccuotas/", lcplazo1)
            input = input.Replace("/*interes/", lctasalet)
            input = input.Replace("/*imora/", "VEINTICUATRO PORCIENTO ANUAL")
            input = input.Replace("/*ncuotas/", lcplazo & " " & lcforma)
            input = input.Replace("/*destinos/", lcdestino)
            input = input.Replace("/*montocuota/", lccuota)
            input = input.Replace("/*fechapago/", lcdias)
            input = input.Replace("/*credito/", lccredito)

            'fiador
            input = input.Replace("/*nombre1/", lcnombre1)
            input = input.Replace("/*edad1/", lcedad1)
            input = input.Replace("/*dui1/", lcdesduif1)
            input = input.Replace("/*nit1/", lcdesnitf)

            input = input.Replace("/*domicilio1/", lcmunicipio1)
            input = input.Replace("/*municipio1/", lcmunicipio1)
            input = input.Replace("/*departamento1/", lcdepartamento1)
            input = input.Replace("/*profesion1/", lcprofesion1)

            'Actualiza variables para fiador2
            input = input.Replace("/*nombre2/", lcnombre2)
            input = input.Replace("/*edad2/", lcedad2)
            input = input.Replace("/*dui2/", lcdesduif2)

            input = input.Replace("/*domicilio2/", lcmunicipio2)
            input = input.Replace("/*departamento2/", lcdepartamento2)
            input = input.Replace("/*profesion2/", lcprofesion2)

            input = input.Replace("/*cdiapago/", lcdiapago)
            'Bienes 
            input = input.Replace("/*inmueble1/", lcinmueble1)



            'A ruego
            input = input.Replace("/*aruego/", "")

            'reemplaza las tildes
            input = input.Replace("&", "ú")
            input = input.Replace("<", "ñ")
            input = input.Replace("#", "Ñ")
            input = input.Replace(">", "é")
            input = input.Replace("¿", "ú")
            input = input.Replace("?", "á")
            input = input.Replace("!", "í")
            input = input.Replace("=", "ó")


            'Visualiza en el navegador el contendido del archivo de texto
            objTextStream.WriteLine(input)


        End While


        sr.Close()
        objTextStream.Close()
        objTextStream = Nothing
        objFSO = Nothing

        '******** SINTAXIS QUE ABRE WORD ****************
        'Dim wordApp As New Word.Application
        'Dim doc1 As New Word.DocumentClass
        'Dim mrange As Word.Range
        'Dim mend As Word.Endnotes

        ' Crea instancia de winword
        'doc1 = wordApp.Documents.Open("C:\wwwsim\contratos2\" & lcnombre & ".doc")
        'doc1.Activate()
        'Shell("C:\wwwsim\contratos2\" & lcnombre & ".doc")
    End Sub

    Public Function Num2Text(ByVal value As Double) As String

        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select


    End Function


    Public Sub history()
        Dim mcreditos As New ccreditos
        Dim dsh As New DataSet
        Dim lccodcli As String
        Dim lcTipper As String
        Dim lndiaapr As Integer
        Dim nelem As Integer
        Dim fila As DataRow
        Dim lcnomcli As String
        Dim lnciclo As Integer
        Dim lccodcta As String
        Dim reportes As String

        Dim lcestado As String
        Dim lndiashis As Integer
        Dim lccalhis As String

        lccodcli = Me.txtcCodCli.Text.Trim
        lcnomcli = Me.txtcNomcli.Text.Trim

        dsh = mcreditos.Historial_cre1(lccodcli)
        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If dsh.Tables(0).Rows.Count = 0 Then
            'Try
            reportes = "crhiscre2.pdf"
            crRpt1.Load(Server.MapPath("reportes") + "\crhiscre2.rpt", OpenReportMethod.OpenReportByDefault)
        Else
            For Each fila In dsh.Tables(0).Rows
                lcTipper = dsh.Tables(0).Rows(nelem)("ctipper")
                lndiaapr = dsh.Tables(0).Rows(nelem)("ndiaapr")
                lcestado = dsh.Tables(0).Rows(nelem)("cestado")
                If lcestado = "G" Then
                    lndiashis = dsh.Tables(0).Rows(nelem)("ndiashis")
                    lccalhis = clase.Califica(lndiashis, fila("CFRECINT"))
                    dsh.Tables(0).Rows(nelem)("ccalif") = lccalhis
                End If

                lccodcta = dsh.Tables(0).Rows(nelem)("ccodcta")
                lnciclo = mcreditos.fxCiclo(lccodcli, lccodcta)
                dsh.Tables(0).Rows(nelem)("cformas") = clase.frecuencia(lcTipper, lndiaapr).Trim
                dsh.Tables(0).Rows(nelem)("nciclo") = lnciclo
                nelem += 1
            Next
            'Try
            reportes = "crhiscre.pdf"
            crRpt1.Load(Server.MapPath("reportes") + "\crhiscre.rpt", OpenReportMethod.OpenReportByDefault)
            crRpt1.SetDataSource(dsh.Tables(0))
        End If
        'Catch ex As Exception
        '   Return
        '  End Try

        crRpt1.Refresh()
        crRpt1.SetParameterValue("lcnomcli", lcnomcli)


        rptStream1 = CType(crRpt1.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
    End Sub

    Private Sub btnhistoria_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhistoria.ServerClick
        history()
    End Sub

    Private Sub btnResCom_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResCom.ServerClick
        Imprimir()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub btnIA_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIA.ServerClick
        ImprimirIA()
    End Sub
    'Private Function validalinea() As String
    '    Dim lndias As Integer
    '    Dim lnmontosug As Double
    '    Dim lcflag As String
    '    Dim lcflag1 As String
    '    lnmontosug = Me.txtmonSug.Text
    '    lndias = DateDiff(DateInterval.Day, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtvencimiento.Text))
    '    'Verifica monto
    '    If lnmontosug >= Double.Parse(Me.txtnliminf.Text) And lnmontosug <= Double.Parse(Me.txtnlimsup.Text) Then
    '        lcflag = "1"
    '    Else
    '        lcflag = "0"
    '    End If
    '    If Me.txtcplazo.Text = "1" Then
    '        If lndias <= 368 Then
    '            lcflag1 = "1"
    '        Else
    '            lcflag1 = "0"
    '        End If
    '    Else
    '        If lndias > 367 Then
    '            lcflag1 = "1"
    '        Else
    '            lcflag1 = "0"
    '        End If
    '    End If

    '    If lcflag = "1" And lcflag1 = "1" Then
    '        Return "1"
    '    Else
    '        Return "0"
    '    End If
    'End Function

    Private Sub btnQuitar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.ServerClick
        'Limpiar informacion
        Dim lneleref As Integer = 0
        Dim ia As Integer
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

        For ia = 1 To lneleref
            clase.pcCodCre = Me.txtCredito.Text
            If ia = 1 Then
                clase.pcCodRef = Me.txtcodref1.Text
            End If
            If ia = 2 Then
                clase.pcCodRef = Me.txtcodref2.Text
            End If
            If ia = 3 Then
                clase.pcCodRef = Me.txtcodref3.Text
            End If
            If ia = 4 Then
                clase.pcCodRef = Me.txtcodref4.Text
            End If
            clase.Borra_Refinados()
        Next

        Me.Datagrid1.DataSource = ""
        Me.Datagrid1.DataBind()

        Me.txtcodref1.Text = ""
        Me.txtcodref2.Text = ""
        Me.txtcodref3.Text = ""
        Me.txtcodref4.Text = ""

    End Sub

    Public Function Duiletras(ByVal Duivalue As String) As String
        Dim lntam As Integer = 0
        Dim lcduilet1 As String = ""
        Dim lcduilet2 As String = ""
        Dim lcultimo As String = ""
        Dim lcceros As String = ""
        Duivalue = Duivalue.Replace("-", "")
        lntam = Duivalue.Length
        If lntam = 0 Then
            lcduilet1 = ""
            lcduilet2 = ""
            lcultimo = ""
        Else

            Dim lnrot As Integer = 0
            Dim lcflag As String
            Dim lnflag As Integer = 0
            For lnrot = 0 To (lntam - 1)
                lcflag = Duivalue.Substring(lnrot, 1)
                If lcflag = "0" Then
                    lnflag += 1
                Else
                    Exit For
                End If
            Next
            If lnflag = 1 Then
                lcceros = "CERO "
            ElseIf lnflag = 2 Then
                lcceros = "CERO CERO "
            ElseIf lnflag = 3 Then
                lcceros = "CERO CERO CERO "
            ElseIf lnflag = 4 Then
                lcceros = "CERO CERO CERO CERO "
            ElseIf lnflag = 5 Then
                lcceros = "CERO CERO CERO CERO CERO "
            Else
                lcceros = " "
            End If
            lcduilet2 = Duivalue.Substring(0, lntam - 1)
            lcduilet1 = Num2Text(Integer.Parse(lcduilet2))
            If Integer.Parse(Duivalue.Substring(lntam - 1, 1)) = 1 Then
                lcultimo = "UNO"
            Else
                lcultimo = Num2Text(Integer.Parse(Duivalue.Substring(lntam - 1, 1)))
            End If

            lcduilet1 = lcduilet1 & " - " & lcultimo

            lcduilet1 = lcceros & lcduilet1
            lcduilet1 = lcduilet1.ToLower

        End If
        Return lcduilet1
    End Function

    Protected Sub cbxCapital_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCapital.SelectedIndexChanged
        cargacombointeres()
    End Sub

    Private Sub cargacombointeres()
        Dim lcfrecuencia As String
        lcfrecuencia = Me.cbxCapital.SelectedValue.Trim
        Dim ds As New DataSet
        Dim etabttab As New cTabttab
        ds = etabttab.ObtenerFrecuencia(lcfrecuencia)
        Me.cbxInteres.DataTextField = "cDescri"
        Me.cbxInteres.DataValueField = "cCodigo"
        Me.cbxInteres.DataSource = ds.Tables(0)
        Me.cbxInteres.DataBind()

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Me.Label27.Visible = True
        Me.ddlcausa.Visible = True
        ViewState("causa") = "SI"
    End Sub
    Private Sub CargaLineasxFondos(ByVal cCodfue As String)
        ' Me.cbxLineas.Items.Clear()

        Dim ds As New DataSet
        Dim clscretlin As New cCretlin

        ds = clscretlin.RecuperarporFuente(cCodfue, Me.txtCredito.Text.Trim.Substring(6, 2))

        If ds.Tables(0).Rows.Count = 0 Then
            Me.cbxLineas.Enabled = False
            Me.btnPlan.Disabled = True
            Return
        Else
            Me.cbxLineas.Enabled = True
            Me.btnPlan.Disabled = False
        End If


        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()

    End Sub
End Class
