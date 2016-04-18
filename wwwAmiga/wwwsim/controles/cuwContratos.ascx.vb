Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
'Imports Microsoft.Office.Interop.Word
Imports System.IO
Imports System.Environment
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System

Public Class cuwContratos
    Inherits System.Web.UI.UserControl

    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1

    'Private crDatos As New ReportDocument
    Private crDatos As New crContratos
    Private nombreReporte As String = "Reporte"
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
        'Dim ds As New dscontratos

        ''Es importante utilizar el System.Data.MissingSchemaAction.Ignore, 
        ''para que nos evite errores y haga el merge correctamente
        'ds.Merge(ReturnDataSet, False, System.Data.MissingSchemaAction.Ignore)

        'crDatos.SetDataSource(ds)
        'Me.crvPrueba.ReportSource = crDatos
        'Me.crvPrueba.Visible = False
        If Not IsPostBack Then
            Me.cargardatos()
        End If
    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtccodcli.Text = codigoCliente
        'Nombre del Cliente
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos

        entidad3.ccodcta = codigoCliente.Trim
        ecreditos.Obtenercreditos(entidad3)

        Me.txtcnomcli.Text = entidad3.cnomcli.Trim

        

        
        'Me.btnAplica_ServerClick(Me, New System.EventArgs)
    End Sub
    Private Sub cargardatos()
        lnparametro1_R = "cDescri , rtrim(ltrim(cCodigo)) as cCodigo, "
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

        txtnombre.Text = ""
        txtdepartamento.Text = ""
        txtmunicipio.Text = ""
        txtdocumento.Text = ""
        ds.Clear()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        'Se crea el documento de lectura y escritura
        Dim rptStream As New System.IO.MemoryStream
        'se envia el reporte el stram y le indicamos el metodo de escritura o tipo de documento
        rptStream = CType(crDatos.ExportToStream(CInt(ddlTipos.SelectedValue)), System.IO.MemoryStream)

        'Limpiamos la memoria
        Response.Clear()
        Response.Buffer = True

        'Le indicamos el tipo de documento que vamos a exportar
        Response.ContentType = FormatoDocumento()

        'Automaticamente se descarga el archivo
        Response.AddHeader("Content-Disposition", "attachment;filename=" + Me.nombreReporte)

        'Se escribe el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
    End Sub
    'Indicamos el Tipo de archivo que vamos a exportar,
    'tambien le indicamos la extension
    Private Function FormatoDocumento() As String
        Dim tipo As String
        Select Case Integer.Parse(ddlTipos.SelectedValue)
            Case ExportFormatType.Excel
                tipo = "application/vnd.ms-excel"
                nombreReporte &= ".xls"
            Case ExportFormatType.RichText
                tipo = "application/rtf"
                nombreReporte &= ".rtf"
            Case ExportFormatType.WordForWindows
                tipo = "application/msword"
                nombreReporte &= ".doc"
            Case Else
                tipo = "application/pdf"
                nombreReporte &= ".pdf"
        End Select
        Return tipo
    End Function

    Private Sub btnaplicar2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar2.ServerClick
        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre
        Dim lccodsol As String = ""
        ecremcre.ccodcta = Me.txtccodcli.Text.Trim
        mcremcre.ObtenerCremcre(ecremcre)
        lccodsol = ecremcre.ccodsol

        If cbxContrato.SelectedValue = "A" And lccodsol = "001001000000" Then
            'contratosword("PAGARE", cbxContrato.SelectedValue.Trim) 
            contratos("crContratos.rpt")

        ElseIf cbxContrato.SelectedValue = "A" And lccodsol <> "001001000000" Then
            contratos("crContratos3.rpt")

        ElseIf cbxContrato.SelectedValue = "B" Then
            'contratosword("CONTRATO1", cbxContrato.SelectedValue.Trim) 
            contratos("crContratos2.rpt")
        ElseIf cbxContrato.SelectedValue = "C" Then
            'contratosword("CONTRATO2", cbxContrato.SelectedValue.Trim) 'contratos("crContratos3.rpt")
        ElseIf cbxContrato.SelectedValue = "D" Then
            ' contratosword("CONTRATO3", cbxContrato.SelectedValue.Trim) 'contratos("crContratos4.rpt")
        ElseIf cbxContrato.SelectedValue = "E" Then
            'contratosword("CONTRATO4", cbxContrato.SelectedValue.Trim) 'contratos("crContratos5.rpt")
        End If

    End Sub
    Private Sub contratos(ByVal nombreReporte As String)

        Dim input As String
        Dim lcnomcli As String
        Dim lcnombar As String
        Dim lcnombre As String


        lcnombre = Me.txtcnomcli.Text.Trim
        'lee un archivo de texto


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

        Dim ecretlin As New cCretlin
        Dim entidadcretlin As New cretlin

        ecremcre.ccodcta = Me.txtccodcli.Text.Trim
        mcremcre.ObtenerCremcre(ecremcre)


        Dim lccodofi As String
        Dim lcdiapago As String = ""
        Dim lcnrolin As String

        lctiper = ecremcre.ctipper
        lccodofi = ecremcre.coficina

        lndia1 = ecremcre.ndiasug
        lnnumcuo = ecremcre.ncuosug
        lcforma = clase.formapago2(lctiper, lndia1)
        lcnrolin = ecremcre.cnrolin


        lcdiapago = Num2Text(lndia1)


        Dim lcdepaofi As String
        Dim lcmuniofi As String
        Dim etabtofi As New cTabtofi

        lcdepaofi = etabtofi.NombreDepartamento(lccodofi)
        lcmuniofi = etabtofi.NombreMunicipio(lccodofi)


        'Dim lctasalet As String = ""
        'lctasalet = Num2Text(ViewState("pctasa")) + " POR CIENTO ANUAL"
        '<<<<<<<<<<<<<<<<<<<<<<<
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon
        Dim lcmunicipio As String
        Dim lcdepartamento As String
        Dim lcplazo As String
        Dim lcdias As String
        Dim lccredito As String
        Dim lclugexp As String = ""


        eclimide.ccodcli = ecremcre.ccodcli
        Dim lnmeses As Integer
        Dim lcmeses As String
        Dim lcfrecint As String
        Dim lcfrecuencia As String
        Dim ldfecvig As Date
        Dim lccodsol As String = ""
        '-----------------------------condiciones del credito-------------------------------------------
        lcnomcli = Me.txtcnomcli.Text.Trim
        lccodcli = Me.txtccodcli.Text.Trim
        lnmonsug = ecremcre.nmonapr
        lncuosug = ecremcre.ncuosug
        lcmonpre = ecremcre.nmonapr
        lcfrecint = ecremcre.cfrecint
        ldfecvig = ecremcre.dfecvig
        lccodsol = ecremcre.ccodsol

        lnmeses = clase.PlazoMeses(ecremcre.dfecvig, ecremcre.dfecven)
        lcmeses = Num2Text(lnmeses)

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

        lcfrecuencia = mtabttab.Describe(lcfrecint, "060")
        '---------------------------linea de credito-----------------------------------------------
        entidadcretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadcretlin)

        Dim lntasint As Double = 0
        Dim lntasmor As Double = 0

        lntasint = Math.Round(ecremcre.ntasint / 12, 2)
        lntasmor = Math.Round(entidadcretlin.ntasmor / 12, 2)

        Dim lctasa As String
        Dim lctasmor As String

        lnentero = Decimal.Floor(lntasint)
        lndeci = Math.Round((lntasint - lnentero) * 100)
        If lndeci > 0 Then
            lctasa = clase.Num2Text(lnentero).ToLower & " " & " con " & clase.Num2Text(lndeci).ToLower & " por ciento"
        Else
            lctasa = clase.Num2Text(lnentero).ToLower & " por ciento "
        End If

        lnentero = Decimal.Floor(lntasmor)
        lndeci = Math.Round((lntasmor - lnentero) * 100)
        If lndeci > 0 Then
            lctasmor = clase.Num2Text(lnentero).ToLower & " " & " con " & clase.Num2Text(lndeci).ToLower & " por ciento"
        Else
            lctasmor = clase.Num2Text(lnentero).ToLower & " por ciento "
        End If


        '----------------------------------------------------------------------------------------------
        lccodcli = ecremcre.ccodcli
        lccredito = Me.txtccodcli.Text.Trim

        etabttab.ccodtab = "005"
        etabttab.ctipreg = "1"
        etabttab.ccodigo = ecremcre.cdescre.Trim
        i = mtabttab.ObtenerTabttab(etabttab)
        If i = 0 Then
            lcdestino = ""
        Else
            lcdestino = etabttab.cdescri.Trim  'destino del credito
        End If


        ecredtpl.ccodcta = Me.txtccodcli.Text.Trim
        ecredtpl.ctipope = "N"
        ecredtpl.cnrocuo = "001"
        mcredtpl.ObtenerCredtpl(ecredtpl)
        clase.gnperbas = Session("gnperbas")
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        Dim ldpricuo As Date
        Dim lcmespri As String = ""
        Dim lcañocuopri As String = ""
        ldpricuo = ecredtpl.dfecven
        lcmespri = MonthName(ldpricuo.Month)
        lcañocuopri = ldpricuo.Year.ToString.Trim

        lncuota = ecremcre.nmoncuo

        lnentero = Decimal.Floor(lncuota)
        lndeci = Math.Round((lncuota - lnentero) * 100)
        If lndeci > 0 Then
            lccuota = Num2Text(lnentero) & " CON " & Num2Text(lndeci) & " CENTAVOS" 'monto en letras
        Else
            lccuota = Num2Text(lnentero) 'monto en letras
        End If

        'fecha desembolso
        ldfecha = Date.Parse(ecremcre.dfecapr)
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcmes = MonthName(lnmes)
        lcfecha = Num2Text(lndia) & " dias del mes de " & lcmes & " del año " & Num2Text(lnano)
        'lcfecha = lcfecha.ToUpper
        lcdias = Num2Text(lndia)

        ''obtiene fecha de vencimiento
        'ldvencimiento = Date.Parse(ecremcre.dfecven)
        'lnmes = ldvencimiento.Month
        'lndia = ldvencimiento.Day
        'lnano = ldvencimiento.Year
        'lcmes = MonthName(lnmes)
        'lcvencimiento = Num2Text(lndia) & " DEL MES DE " & lcmes & " DE " & Num2Text(lnano)
        'lcvencimiento = lcvencimiento.ToLower

        '----------------------------Datos del cliente--------------------------------------------------
        Dim lcestciv As String
        'obtiene datos del cliente
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)


        lcestciv = eclimide.cestciv
        lcdirdom = eclimide.cdirdom
        lcdui = eclimide.cnudoci.Trim
        lclugexp = eclimide.cLugExp.Trim
        'lcdui = lcdui.Replace("-", "")
        lcnit = eclimide.cnudotr.Trim
        lccoddom = eclimide.ccoddom.Trim

        lccodpro = eclimide.ccodpro

        Dim lvalida As Boolean
        Dim lcdocumento As String = ""
        Dim lcdoc As String
        lcdoc = eclimide.cnudoci
        Dim lcdpifia1 As String = ""
        Dim lcdpifia2 As String = ""
        lvalida = clase.ValidaCaracter(Left(lcdoc.Trim, 1))
        If lvalida = True Then 'Cedula
            lcdocumento = clase.LecturaCedula(lcdoc)

        Else 'DPI
            lcdocumento = clase.LecturaDPI(lcdoc)

        End If

        '-------------------------------Obtiene descripcion de codigo-----------------------------------------
        Dim lcdesestciv As String = ""
        lcdesestciv = mtabttab.Describe(lcestciv, "012").Trim


        'obtiene municipio y departamento expedicion
        Dim lcmuniexp As String = ""
        Dim lcdepaexp As String = ""

        Dim lclugexp1 As String = ""
        Dim lclugexp2 As String = ""

        Dim lcmuniexp1 As String = ""
        Dim lcmuniexp2 As String = ""

        Dim lcdepaexp1 As String = ""
        Dim lcdepaexp2 As String = ""

        'etabtzon.ccodzon = lclugexp
        'etabtzon.ctipzon = "2"
        'mtabtzon.ObtenerTabtzon(etabtzon)
        'lcmuniexp = etabtzon.cdeszon.Trim
        'lcmuniexp = lcmuniexp.ToUpper
        ''departamento
        'etabtzon.ccodzon = lclugexp.Substring(0, 2)
        'etabtzon.ctipzon = "1"
        'mtabtzon.ObtenerTabtzon(etabtzon)
        'lcdepaexp = etabtzon.cdeszon.Trim
        'lcdepaexp = lcdepaexp.ToUpper



        etabtprf.ccodigo = lccodpro
        mtabtprf.ObtenerTabtprf(etabtprf)
        lcprofesion = etabtprf.cdescri.Trim  ' profesion
        If eclimide.dnacimi <> Nothing Then
            lcedad = clase.EdadLetras(eclimide.dnacimi) 'Num2Text(Math.Round(Date.Now.Year - eclimide.dnacimi.Year))
            lcedad = lcedad.ToLower
        End If

        'detalla el dui en letras
        'lcdesdui = Me.Duiletras(lcdui)


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
        lcmunicipio = lcmunicipio.ToUpper
        'departamento
        etabtzon.ccodzon = lccoddom.Substring(0, 2)
        etabtzon.ctipzon = "1"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcdepartamento = etabtzon.cdeszon.Trim
        lcdepartamento = lcdepartamento.ToUpper

        '**************************obtiene datos del fiador******************
        Dim lcdocumento1 As String = ""
        Dim lcdoc1 As String = ""

        Dim lcdocumento2 As String = ""
        Dim lcdoc2 As String = ""


        Dim lcdesestciv1 As String = ""
        Dim lcdesestciv2 As String = ""

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

        Dim lcdirdom1 As String = ""
        Dim lcdirdom2 As String = ""

        Dim lnfia As Integer = 0

        lccoduni = "**"
        eclimgar.ccodcli = lccodcli
        Dim lnv As Integer = 0

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
                    lnv = mclimide.ObtenerClimide(eclimide)
                    If lnv = 0 Then 'no existen datos

                    Else


                        lcnombre1 = eclimide.cnomcli.Trim
                        lcnit1 = eclimide.cnudotr.Trim
                        lcdui1 = eclimide.cnudoci.Trim
                        lcdoc1 = eclimide.cnudoci
                        lvalida = clase.ValidaCaracter(Left(lcdoc1.Trim, 1))
                        If lvalida = True Then 'Cedula
                            lcdocumento1 = clase.LecturaCedula(lcdoc1)
                        Else 'DPI
                            lcdocumento1 = clase.LecturaDPI(lcdoc1)
                            lcdpifia1 = "DPI Nº " & lcdoc1
                        End If

                        'lcdui1 = lcdui1.Replace("-", "")
                        lccodpro1 = eclimide.ccodpro.Trim
                        ldnacimi1 = eclimide.dnacimi
                        lccoddom1 = eclimide.ccoddom.Trim
                        lcdirdom1 = eclimide.cdirdom.Trim

                        lcdesestciv1 = mtabttab.Describe(eclimide.cestciv, "012").Trim

                        lclugexp1 = eclimide.cLugExp.Trim
                        etabtzon.ccodzon = lclugexp1
                        etabtzon.ctipzon = "2"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcmuniexp1 = etabtzon.cdeszon.Trim
                        lcmuniexp1 = lcmuniexp1.ToUpper
                        'departamento
                        If lclugexp1.Trim = "" Then
                            lcdepaexp1 = ""
                        Else
                            etabtzon.ccodzon = lclugexp1.Substring(0, 2)
                            etabtzon.ctipzon = "1"
                            mtabtzon.ObtenerTabtzon(etabtzon)
                            lcdepaexp1 = etabtzon.cdeszon.Trim
                            lcdepaexp1 = lcdepaexp1.ToUpper
                        End If

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


                        lcdesduif1 = "" 'Me.Duiletras(lcdui1)


                        'obtiene profesion
                        etabtprf.ccodigo = lccodpro1
                        mtabtprf.ObtenerTabtprf(etabtprf)
                        lcprofesion1 = etabtprf.cdescri.Trim
                        lcprofesion1 = lcprofesion1.ToLower

                        'obtiene edad
                        ' Try
                        lnedad1 = Date.Now.Year - ldnacimi1.Year
                        lcedad1 = clase.EdadLetras(ldnacimi1) 'Num2Text(lnedad1)
                        lcedad1 = lcedad1.ToLower

                        'Catch ex As Exception
                        '    lcedad1 = ""
                        'End Try

                        'domicilio
                        'obtiene municipio y departamento

                        etabtzon.ccodzon = lccoddom1.Substring(0, 4)
                        etabtzon.ctipzon = "2"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcmunicipio1 = etabtzon.cdeszon.Trim
                        lcmunicipio1 = lcmunicipio1.ToUpper

                        'departamento
                        etabtzon.ccodzon = lccoddom1.Substring(0, 2)
                        etabtzon.ctipzon = "1"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcdepartamento1 = etabtzon.cdeszon.Trim
                        lcdepartamento1 = lcdepartamento1.ToUpper
                    End If
                End If
                'Segundo fiador >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If lnfia = 2 Then
                    lccoduni = ds.Tables(0).Rows(ele)("ccoduni")
                    eclimide.ccodcli = lccoduni
                    lnv = mclimide.ObtenerClimide(eclimide)
                    If lnv = 0 Then
                    Else


                        lcnombre2 = eclimide.cnomcli.Trim
                        lcnit2 = eclimide.cnudotr.Trim
                        lcdui2 = eclimide.cnudoci.Trim

                        lcdoc2 = eclimide.cnudoci
                        lvalida = clase.ValidaCaracter(Left(lcdoc2.Trim, 1))
                        If lvalida = True Then 'Cedula
                            lcdocumento2 = clase.LecturaCedula(lcdoc2)
                        Else 'DPI
                            lcdocumento2 = clase.LecturaDPI(lcdoc2)
                            lcdpifia2 = "DPI Nº " & lcdoc2
                        End If


                        'lcdui2 = lcdui2.Replace("-", "")
                        lccodpro2 = eclimide.ccodpro.Trim
                        ldnacimi2 = eclimide.dnacimi
                        lccoddom2 = eclimide.ccoddom.Trim
                        lcdirdom2 = eclimide.cdirdom.Trim
                        lcdesestciv2 = mtabttab.Describe(eclimide.cestciv, "012").Trim

                        lclugexp2 = eclimide.cLugExp.Trim
                        etabtzon.ccodzon = lclugexp2
                        etabtzon.ctipzon = "2"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcmuniexp2 = etabtzon.cdeszon.Trim
                        lcmuniexp2 = lcmuniexp2.ToUpper
                        'departamento
                        etabtzon.ccodzon = lclugexp2.Substring(0, 2)
                        etabtzon.ctipzon = "1"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcdepaexp2 = etabtzon.cdeszon.Trim
                        lcdepaexp2 = lcdepaexp2.ToUpper

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


                        lcdesduif2 = "" 'Me.Duiletras(lcdui2)



                        'obtiene profesion
                        etabtprf.ccodigo = lccodpro2
                        mtabtprf.ObtenerTabtprf(etabtprf)
                        lcprofesion2 = etabtprf.cdescri.Trim
                        lcprofesion2 = lcprofesion1.ToLower

                        'obtiene edad
                        '    Try
                        lnedad1 = Date.Now.Year - ldnacimi2.Year
                        lcedad2 = clase.EdadLetras(ldnacimi2)  'Num2Text(lnedad1)
                        lcedad2 = lcedad2.ToLower
                        'Catch ex As Exception
                        '    lcedad2 = ""
                        'End Try


                        'domicilio
                        'obtiene municipio y departamento

                        etabtzon.ccodzon = lccoddom2.Substring(0, 4)
                        etabtzon.ctipzon = "2"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcmunicipio2 = etabtzon.cdeszon.Trim
                        lcmunicipio2 = lcmunicipio2.ToUpper

                        'departamento
                        etabtzon.ccodzon = lccoddom2.Substring(0, 2)
                        etabtzon.ctipzon = "1"
                        mtabtzon.ObtenerTabtzon(etabtzon)
                        lcdepartamento2 = etabtzon.cdeszon.Trim
                        lcdepartamento2 = lcdepartamento2.ToUpper
                    End If
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
        '--------------------------------------------------------------------------------------
        'Garantia Hipotecaria
        Dim ds2 As New DataSet
        ds2 = mclimgar.ObtenerDataSetPor_Garantia_Cliente(lccodcli, "03")
        Dim fila2 As DataRow
        Dim lcgarah As String = ""
        Dim lcgarah1 As String = ""
        Dim ldfec1 As Date
        Dim lclug1 As String = ""
        Dim lcfec1 As String = ""
        Dim lcdesc1 As String = ""
        Dim lcnotario1 As String = ""
        Dim lcnumeropr1 As String = ""
        For Each fila2 In ds2.Tables(0).Rows
            lcdesc1 = Trim(fila2("cdescri"))
            ldfec1 = fila2("dfechaes")
            lclug1 = fila2("clugares")
            lcnotario1 = fila2("cnotario")
            lcnumeropr1 = fila2("nnumeropr")
            lcfec1 = " de fecha " & Num2Text(ldfec1.Day) & " de " & MonthName(ldfec1.Month) & " del año " & Num2Text(ldfec1.Year)

            lcgarah1 = lcdesc1.Trim & " " & lcfec1 & " autorizada en la ciudad de " & lclug1 & " por el notario " & lcnotario1 & "; "
            lcgarah = lcgarah + lcgarah1
        Next
        If ds2.Tables(0).Rows.Count = 0 Then
            ds2 = mclimgar.ObtenerDataSetPor_Garantia_Cliente(lccodcli, "02")

            For Each fila2 In ds2.Tables(0).Rows
                lcdesc1 = Trim(fila2("cdescri"))
                ldfec1 = fila2("dfechaes")
                lclug1 = fila2("clugares")
                lcnotario1 = fila2("cnotario")
                lcnumeropr1 = fila2("nnumeropr")
                lcfec1 = " de fecha " & Num2Text(ldfec1.Day) & " de " & MonthName(ldfec1.Month) & " del año " & Num2Text(ldfec1.Year)

                lcgarah1 = lcdesc1.Trim & " " & lcfec1 & " autorizada en la ciudad de " & lclug1 & " por el notario " & lcnotario1 & "; "
                lcgarah = lcgarah + lcgarah1
            Next

        End If

        '--------------------------------------------------------------------------------------
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        'Dim nombreReporte As String = "crContratos.rpt"

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & nombreReporte, OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        ' Setear los registros recuperados, diciendole el Table respectivo

        Dim tipo As String
        'Select Case Integer.Parse(ddlTipos.SelectedValue)
        '    Case ExportFormatType.Excel
        '        tipo = "application/vnd.ms-excel"
        '        nombreReporte &= ".xls"
        '    Case ExportFormatType.RichText
        'tipo = "application/rtf"
        'nombreReporte &= ".rtf"
        '    Case ExportFormatType.WordForWindows
        'tipo = "application/msword"
        'nombreReporte &= ".doc"
        '    Case Else
        tipo = "application/pdf"
        nombreReporte = "Documento.pdf"
        'End Select

        Dim dstmp As New DataSet
        dstmp = mcredtpl.ObtenerDataSetPorID(Me.txtccodcli.Text.Trim)

        If dstmp.Tables(0).Rows.Count = 0 Then 'Buscara en la credtpl
            Dim ecredppg As New cCredppg
            dstmp = ecredppg.ObtenerDataSetPorID2(txtccodcli.Text.Trim)

        End If
        Dim tabla As New DataTable

        tabla = FiltraTablaInteresesVencidos(dstmp.Tables(0), "ctipope <> 'D'")

        Dim dsr As New DataSet
        dsr.Tables.Add(tabla)



        Dim lccontexto As String = ""
        Dim lccontexto1 As String = ""

        lccontexto = "Bajo las condiciones siguientes:" & _
        " a)Plazo: será de " & lcmeses.Trim & " (" & lnmeses.ToString.Trim & ") " & "meses computables a partir de la fecha de emisión del presente pagaré, sin embargo y sin prejuicio de lo anterior, la falta de pago de una cuota de capital y/o intereses, así como el incumplimiento de cualesquiera otra obligación que me imponga la ley o el contenido del presente documento dará derecho a la entidad acreedora a dar por vencido anticipadamente el plazo estipulado y exigir el pago del saldo adeudado, por ende, la obligación será de plazo vencido y el saldo de la deuda se reputará por líquido y exigible;" & _
        " b)Interés: la suma adeudada devengará una tasa de interés variable la cual podrá ser modificada por decisión unilateral de la parte acreedora conforme a las condiciones de mercado. La tasa de interes inicial es del " & lntasint.ToString.Trim & " % mensual, interés que va calculado e incluido en la cuota antes indicada, conforme el artículo un mil novecientos cuarenta y ocho del Código Civil, la tasa del interés es pactada libremente por el deudor;" & _
        " c)Por incumplimiento de pago de cada una de las cuotas, se pagará un recargo del  " & lctasmor & " (" & lntasmor.ToString.Trim & "%) mensual, cuyo porcentaje  podrá ser variable por decisión unilateral de la acreedora. Todos los  gastos que directa o indirectamente ocasione esta negociación, son por mi cuenta, incluyendo los de cobranza judicial y/o extra-judicial, honorarios de abogados si fuere necesario." & _
        " d)En caso de juicio, ni el tenedor de este pagaré ni los auxiliares que proponga deberán prestar garantía.  En caso de remate servirá de base al avalúo o monto del adeudo la primera postura a opción del tenedor de este pagaré. El presente pagaré se emite libre de protesto, libre de formalidades de presentación, cobro o requerimiento " & _
        "CONDICIONES ESPECIALES: Garantizo la presente obligación con todos mis bienes presentes y futuros especialmente con los derechos de posesión que ostento  sobre el bien inmueble, de conformidad con la Escritura pública número " & lcnumeropr1.Trim & " autorizada en " & lclug1 & "  " & lcfec1 & " por el Notario " & lcnotario1.Trim & ". Acepto que en caso incumpla mis obligaciones de pago en los términos declarados se proceda al embargo judicial de mis bienes, especialmente el descrito. Expresamente dejo constancia que todos y cada uno de los datos que he proporcionado a la acreedora en los documentos de solicitud de crédito y estado patrimonial son verídicos y exactos, y que la inexactitud o falta de veracidad de los mismos que la acreedora determine deberá tenerse como una acción dolosa de mi parte generadora de perjuicios al patrimonio de la acreedora y susceptible del ejercicio de acción penal que en derecho corresponda a ésta última." & _
        " CESION: los derechos que incorpora el presente título, así como el propio título, podrán ser endosados, cedidos o negociados en cualquier forma sin necesidad de previa o anterior notificación al emisor. " & _
        "PACTO DE SUMISION: Por incumplimiento de mis obligaciones para con la acreedora, expresamente el librador y los avalistas renuncian  al fuero de sus domicilios y se someten a los tribunales que el tenedor de este pagaré elija. Señalo como lugar para recibir citaciones y/o notificaciones el de mi actual residencia aceptando como buenas y válidas las que allí se me hagan.  Desde ya acepto como buenas, exactas, liquidas, exigibles y de plazo vencido las cuentas que por la presente obligación se me reclamen y como titulo ejecutivo el presente documento, cuyo contenido declaro conocer y entender. " & _
        "En testimonio de lo anterior se libra el presente pagaré, en " & lcmuniofi.Trim & " , departamento de  " & lcdepaofi.Trim & "; a los  " & lcfecha & "."

        'dsr = mcredtpl.ObtenerDataSetPorID(Me.txtccodcli.Text.Trim)

        'Verifica si es grupal-------------
        Dim lcraja As String = ""
        Dim lcraja1 As String = ""
        Dim lcrajam1 As String = ""

        Dim lcespacios As String = New String(" ", 225)

        Dim im As Integer = 0
        Dim lcdocm As String = ""
        Dim lcdpim As String = ""


        If Me.txtccodcli.Text.Trim.Substring(6, 2) <> "01" And lccodsol <> "001001000000" Then
            Dim lnmonaprg As Decimal = lnmonsug
            Dim dsm As New DataSet
            dsm = ObtieneMiembros(txtccodcli.Text.Trim)
            For Each filam As DataRow In dsm.Tables(0).Rows
                lnmonaprg = lnmonaprg + filam("nmonapr")
                im += 1

                lcdocm = filam("cnudoci")

                lvalida = clase.ValidaCaracter(Left(lcdocm.Trim, 1))
                If lvalida = True Then 'Cedula
                    lcdpim = "Cedula Nº " & lcdocm
                Else 'DPI
                    lcdpim = "DPI Nº " & lcdocm
                End If
                lcraja1 = lcraja1 & RellenarEspacios(filam("cnomcli"))
                lcrajam1 = lcrajam1 & RellenarEspacios(lcdpim)

                If im = 3 Then
                    lcraja = lcraja & lcraja1 + vbCr
                    lcraja = lcraja & lcrajam1

                    lcraja = lcraja & lcespacios
                    lcraja = lcraja & lcespacios
                    lcraja = lcraja & lcespacios
                    lcraja = lcraja & lcespacios
                    lcraja1 = ""
                    lcrajam1 = ""

                    im += 0
                End If

            Next
            If im < 3 Then
                lcraja = lcraja & lcraja1 + vbCr
                lcraja = lcraja & lcrajam1
                lcraja = lcraja & lcespacios
                lcraja = lcraja & lcespacios
                lcraja = lcraja & lcespacios
                lcraja = lcraja & lcespacios
                lcraja1 = ""
                lcrajam1 = ""
            End If


            Dim dsp As New DataSet

            dsp = mcredtpl.PlanGrupalTeorico(lccodsol, ldfecvig)


            If dsp.Tables(0).Rows.Count() = 0 Then  'En caso que no devuelva nada se sale
                Dim ecredppg As New cCredppg
                dsp = ecredppg.PlanGrupalTeorico(lccodsol, ldfecvig)
                'nElem = dsp.Tables(0).Rows.Count()
                If dsp.Tables(0).Rows.Count() = 0 Then
                Else
                    'dsr = dsp
                End If
            Else
                'dsr = dsp
            End If
            tabla = FiltraTablaInteresesVencidos(dsp.Tables(0), "ctipope <> 'D'")
            Dim dsrg As New DataSet
            dsrg.Tables.Add(tabla)
            dsr = dsrg

            lnentero = Decimal.Floor(lnmonaprg)
            lndeci = Math.Round((lnmonaprg - lnentero) * 100)
            If lndeci > 0 Then
                lcmonto = Num2Text(lnentero) & " QUETZALES " & " CON " & Num2Text(lndeci) & " CENTAVOS" 'monto en letras
            Else
                lcmonto = Num2Text(lnentero) & " QUETZALES " 'monto en letras
            End If
        End If

        '----------------------------------

        'Dim etabtusu As New cTabtusu
        'dsr = etabtusu.ObtenerDataSetPorID()
        crRpt.SetDataSource(dsr.Tables(0))

        Dim lcdialet As String
        Dim lcanolet As String
        lcdialet = Num2Text(lndia)
        lcanolet = Num2Text(lnano)
        '-------------------------------------------------------------------------------------
        crRpt.SetParameterValue("pcnomcli", txtcnomcli.Text.Trim)
        crRpt.SetParameterValue("pcsumade", lcmonto.Trim)
        crRpt.SetParameterValue("pcmonsug", clase.Cominola(lnmonsug.ToString.Trim))
        crRpt.SetParameterValue("pccuotas", lcplazo1.Trim)
        crRpt.SetParameterValue("pcmoncuo", lccuota.Trim)
        crRpt.SetParameterValue("pccuota", clase.Cominola(lncuota.ToString.Trim))
        crRpt.SetParameterValue("pcmespri", lcmespri.Trim.ToUpper)
        crRpt.SetParameterValue("pcañocuopri", lcañocuopri.Trim)
        crRpt.SetParameterValue("pcdirdom", lcdirdom.Trim)
        crRpt.SetParameterValue("pcdia", lcdialet.Trim)
        crRpt.SetParameterValue("pcmes", lcmes.Trim.ToUpper)
        crRpt.SetParameterValue("pcano", lcanolet.Trim)

        crRpt.SetParameterValue("pcmunicipio", lcmunicipio.Trim)
        crRpt.SetParameterValue("pcdepartamento", lcdepartamento.Trim)
        crRpt.SetParameterValue("pcdui", lcdui.Trim)

        crRpt.SetParameterValue("pcmuniexp", lcmuniexp.Trim)
        crRpt.SetParameterValue("pcdepaexp", lcdepaexp.Trim)


        'fiador 1
        crRpt.SetParameterValue("pcnomfia1", lcnombre1.Trim)
        crRpt.SetParameterValue("pcdirdom1", lcdirdom1.Trim)
        crRpt.SetParameterValue("pcdepartamento1", lcdepartamento1)
        crRpt.SetParameterValue("pcmunicipio1", lcmunicipio1)
        crRpt.SetParameterValue("pcdui1", lcdui1.Trim)

        'fiador 1
        crRpt.SetParameterValue("pcnomfia2", lcnombre2.Trim)
        crRpt.SetParameterValue("pcdirdom2", lcdirdom2.Trim)
        crRpt.SetParameterValue("pcdepartamento2", lcdepartamento2)
        crRpt.SetParameterValue("pcmunicipio2", lcmunicipio2)
        crRpt.SetParameterValue("pcdui2", lcdui2.Trim)

        crRpt.SetParameterValue("pcmuniexp1", lcmuniexp1.Trim)
        crRpt.SetParameterValue("pcdepaexp1", lcdepaexp1.Trim)
        crRpt.SetParameterValue("pcmuniexp2", lcmuniexp2.Trim)
        crRpt.SetParameterValue("pcdepaexp2", lcdepaexp2.Trim)

        '------------------------------------------------------------
        crRpt.SetParameterValue("pcedad", lcedad)
        crRpt.SetParameterValue("pcdesestciv", lcdesestciv)
        crRpt.SetParameterValue("pcprofesion", lcprofesion)
        crRpt.SetParameterValue("pcmeses", lnmeses.ToString)
        crRpt.SetParameterValue("pcmeslet", lcmeses)
        crRpt.SetParameterValue("pctasint", lntasint.ToString.Trim)
        crRpt.SetParameterValue("pctasa", lctasa)
        crRpt.SetParameterValue("pcfrecuencia", lcfrecuencia)
        crRpt.SetParameterValue("pcfecha", lcfecha)
        crRpt.SetParameterValue("pcdocumento", lcdocumento)
        crRpt.SetParameterValue("pcdocumento1", lcdocumento1)
        crRpt.SetParameterValue("pcdocumento2", lcdocumento2)
        '------------------------------------------------------------
        'aplicara para contratos 4 y 5
        If cbxContrato.SelectedValue.Trim = "D" Or cbxContrato.SelectedValue.Trim = "E" Then
            crRpt.SetParameterValue("pcedad1", lcedad1)
            crRpt.SetParameterValue("pcedad2", lcedad2)
            crRpt.SetParameterValue("pcdesestciv1", lcdesestciv1)
            crRpt.SetParameterValue("pcdesestciv2", lcdesestciv2)
            crRpt.SetParameterValue("pcdestino", lcdestino)
            crRpt.SetParameterValue("pcprofesion1", lcprofesion1)
        End If
        crRpt.SetParameterValue("cgarah", lcgarah)

        crRpt.SetParameterValue("contexto", lccontexto.Trim)
        crRpt.SetParameterValue("pcdepofi", lcdepaofi.Trim)
        crRpt.SetParameterValue("pcmuniofi", lcmuniofi.Trim)

        crRpt.SetParameterValue("pccodcta", txtccodcli.Text.Trim)
        crRpt.SetParameterValue("pnmonpre", lnmonsug)
        crRpt.SetParameterValue("pdfecvig", ldfecvig)

        If cbxContrato.SelectedValue.Trim = "B" Or cbxContrato.SelectedValue.Trim = "A" Then
            crRpt.SetParameterValue("pcdpifia1", lcdpifia1)
            crRpt.SetParameterValue("pcdpifia2", lcdpifia2)
        End If


        '------------------------------------------------------------
        'firma a ruego
        Dim lcnomaruego As String = ""
        Dim lcdocaruego As String = ""
        Dim lcdepaaruego As String = ""
        Dim lcmuniaruego As String = ""
        Dim lcdocaruegolet As String = ""


        If chkaRuego.Checked = True Then
            lcnomaruego = txtnombre.Text.Trim
            lcdepaaruego = txtdepartamento.Text.Trim
            lcmuniaruego = txtmunicipio.Text.Trim
            lcdoc = txtdocumento.Text.Trim
            Try
                If RadioButton1.Checked = True Then 'DPI
                    lcdocaruego = "DPI Nº " & lcdoc.Trim '
                    lcdocaruegolet = clase.LecturaDPI(lcdoc)
                Else 'Cedula
                    lcdocaruego = clase.LecturaCedula(lcdoc)
                End If
            Catch ex As Exception
                lcdocaruego = ""
            End Try

        End If
        crRpt.SetParameterValue("pcnomaruego", lcnomaruego.Trim)
        crRpt.SetParameterValue("pcdocaruego", lcdocaruego.Trim)
        crRpt.SetParameterValue("pcdepaaruego", lcdepaaruego.Trim)
        crRpt.SetParameterValue("pcmuniaruego", lcmuniaruego.Trim)
        crRpt.SetParameterValue("pcdocaruegolet", lcdocaruegolet.Trim)
        '------------------------------------------------------------

        If Me.txtccodcli.Text.Trim.Substring(6, 2) <> "01" And cbxContrato.SelectedValue.Trim = "A" And lccodsol <> "001001000000" Then
            crRpt.SetParameterValue("pcraja", lcraja)
        End If

        '------------------------------------------------------------
        Dim reportes As String
        'reportes = "Pagare.rtf"
        reportes = "Pagare.pdf"

        'rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.ContentType = "application/msword"

        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

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
    Public Function Duiletras(ByVal Duivalue As String) As String
        'Dim lntam As Integer = 0
        Dim lcduilet1 As String = ""
        'Dim lcduilet2 As String = ""
        'Dim lcultimo As String = ""
        'Dim lcceros As String = ""
        'Duivalue = Duivalue.Replace("-", "")
        'lntam = Duivalue.Length
        'If lntam = 0 Then
        '    lcduilet1 = ""
        '    lcduilet2 = ""
        '    lcultimo = ""
        'Else

        '    Dim lnrot As Integer = 0
        '    Dim lcflag As String
        '    Dim lnflag As Integer = 0
        '    For lnrot = 0 To (lntam - 1)
        '        lcflag = Duivalue.Substring(lnrot, 1)
        '        If lcflag = "0" Then
        '            lnflag += 1
        '        Else
        '            Exit For
        '        End If
        '    Next
        '    If lnflag = 1 Then
        '        lcceros = "CERO "
        '    ElseIf lnflag = 2 Then
        '        lcceros = "CERO CERO "
        '    ElseIf lnflag = 3 Then
        '        lcceros = "CERO CERO CERO "
        '    ElseIf lnflag = 4 Then
        '        lcceros = "CERO CERO CERO CERO "
        '    ElseIf lnflag = 5 Then
        '        lcceros = "CERO CERO CERO CERO CERO "
        '    Else
        '        lcceros = " "
        '    End If
        '    lcduilet2 = Duivalue.Substring(0, lntam - 1)
        '    lcduilet1 = Num2Text(Integer.Parse(lcduilet2))
        '    If Integer.Parse(Duivalue.Substring(lntam - 1, 1)) = 1 Then
        '        lcultimo = "UNO"
        '    Else
        '        lcultimo = Num2Text(Integer.Parse(Duivalue.Substring(lntam - 1, 1)))
        '    End If

        '    lcduilet1 = lcduilet1 & " - " & lcultimo

        '    lcduilet1 = lcceros & lcduilet1
        '    lcduilet1 = lcduilet1.ToLower

        'End If

        Return lcduilet1
    End Function


    'Private Function ReturnDataSet() As DataSet
    'Dim dt As New DataTable
    'Dim dr As DataRow
    'Dim ds As New dscontratos

    'dt.Columns.Add(New DataColumn("mcondoc", GetType(String)))

    'dr = dt.NewRow()
    'dr("mcondoc") = "Generar Contrato"
    'dt.Rows.Add(dr)

    'ds.Tables.Add(dt)
    'ds.Tables(0).TableName = "Contratos"

    'Return ds

    'End Function
    Private Sub contratosword(ByVal contrato As String, ByVal tipocontrato As String)
        Dim input As String
        Dim lcnomcli As String
        Dim lcnombar As String
        Dim lcnombre As String
        Dim lcnomgru As String = ""

        'escribir
        lcnombre = contrato & "_" & Me.txtcnomcli.Text.Trim & ".doc"
        Const fsoLectura = 1
        Const fsoescritura = 2

        Dim objFSO
        'Instanciación del objeto FSO
        objFSO = Server.CreateObject("Scripting.FileSystemObject")

        'Abrir el archivo de texto
        Dim objTextStream
        objTextStream = objFSO.OpenTextFile("C:\wwwsim\contratos2\" & lcnombre, fsoescritura, True)
        Dim nombrecontrato As String
        nombrecontrato = contrato

        lcnombar = nombrecontrato & ".txt"

        'lee un archivo de texto
        Dim FILE_NAME As String = "c:/wwwsim/contratos/" & lcnombar
        If Not File.Exists(FILE_NAME) Then
            Return
        End If
        Dim sr As StreamReader = File.OpenText(FILE_NAME)

        input = sr.ReadLine()


        '-------------------------------------------------------------------------


        lcnombre = Me.txtcnomcli.Text.Trim
        'lee un archivo de texto


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

        Dim ecretlin As New cCretlin
        Dim entidadcretlin As New cretlin

        ecremcre.ccodcta = Me.txtccodcli.Text.Trim
        mcremcre.ObtenerCremcre(ecremcre)


        Dim lcdiapago As String = ""
        Dim lcnrolin As String

        lctiper = ecremcre.ctipper

        lndia1 = ecremcre.ndiasug
        lnnumcuo = ecremcre.ncuosug
        lcforma = clase.formapago2(lctiper, lndia1)
        lcnrolin = ecremcre.cnrolin


        lcdiapago = Num2Text(lndia1)


        'Dim lctasalet As String = ""
        'lctasalet = Num2Text(ViewState("pctasa")) + " POR CIENTO ANUAL"
        '<<<<<<<<<<<<<<<<<<<<<<<
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon
        Dim lcmunicipio As String
        Dim lcdepartamento As String
        Dim lcplazo As String
        Dim lcdias As String
        Dim lccredito As String
        Dim lclugexp As String = ""


        eclimide.ccodcli = ecremcre.ccodcli
        Dim lnmeses As Integer
        Dim lcmeses As String
        Dim lcfrecint As String
        Dim lcfrecuencia As String
        '-----------------------------condiciones del credito-------------------------------------------
        lcnomcli = Me.txtcnomcli.Text.Trim
        lccodcli = Me.txtccodcli.Text.Trim
        lnmonsug = ecremcre.nmonapr
        lncuosug = ecremcre.ncuosug
        lcmonpre = ecremcre.nmonapr
        lcfrecint = ecremcre.cfrecint

        lnmeses = clase.PlazoMeses(ecremcre.dfecvig, ecremcre.dfecven)
        lcmeses = Num2Text(lnmeses)

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

        lcfrecuencia = mtabttab.Describe(lcfrecint, "060")
        '---------------------------linea de credito-----------------------------------------------
        entidadcretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadcretlin)

        Dim lntasint As Double = 0
        Dim lntasmor As Double = 0

        lntasint = entidadcretlin.ntasint
        lntasmor = entidadcretlin.ntasmor

        Dim lctasa As String

        lnentero = Decimal.Floor(lntasint)
        lndeci = Math.Round((lntasint - lnentero) * 100)
        If lndeci > 0 Then
            lctasa = clase.Num2Text(lnentero).ToLower & " " & " con " & clase.Num2Text(lndeci).ToLower & " por ciento"
        Else
            lctasa = clase.Num2Text(lnentero).ToLower & " por ciento "
        End If


        '----------------------------------------------------------------------------------------------
        lccodcli = ecremcre.ccodcli
        lccredito = Me.txtccodcli.Text.Trim

        etabttab.ccodtab = "005"
        etabttab.ctipreg = "1"
        etabttab.ccodigo = ecremcre.cdescre.Trim
        mtabttab.ObtenerTabttab(etabttab)

        lcdestino = etabttab.cdescri.Trim  'destino del credito

        ecredtpl.ccodcta = Me.txtccodcli.Text.Trim
        ecredtpl.ctipope = "N"
        ecredtpl.cnrocuo = "001"
        mcredtpl.ObtenerCredtpl(ecredtpl)
        clase.gnperbas = Session("gnperbas")
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        Dim ldpricuo As Date
        Dim lcmespri As String = ""
        Dim lcañocuopri As String = ""
        ldpricuo = ecredtpl.dfecven
        lcmespri = MonthName(ldpricuo.Month)
        lcañocuopri = ldpricuo.Year.ToString.Trim

        lncuota = ecremcre.nmoncuo

        lnentero = Decimal.Floor(lncuota)
        lndeci = Math.Round((lncuota - lnentero) * 100)
        If lndeci > 0 Then
            lccuota = Num2Text(lnentero) & " CON " & Num2Text(lndeci) & " CENTAVOS" 'monto en letras
        Else
            lccuota = Num2Text(lnentero) 'monto en letras
        End If

        'fecha desembolso
        ldfecha = Date.Parse(ecremcre.dfecapr)
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcmes = MonthName(lnmes)
        lcfecha = Num2Text(lndia) & " dias del mes de " & lcmes & " del año " & Num2Text(lnano)
        lcfecha = lcfecha.ToUpper
        lcdias = Num2Text(lndia)

        ''obtiene fecha de vencimiento
        'ldvencimiento = Date.Parse(ecremcre.dfecven)
        'lnmes = ldvencimiento.Month
        'lndia = ldvencimiento.Day
        'lnano = ldvencimiento.Year
        'lcmes = MonthName(lnmes)
        'lcvencimiento = Num2Text(lndia) & " DEL MES DE " & lcmes & " DE " & Num2Text(lnano)
        'lcvencimiento = lcvencimiento.ToLower

        '----------------------------Datos del cliente--------------------------------------------------
        Dim lcestciv As String
        'obtiene datos del cliente
        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)


        lcestciv = eclimide.cestciv
        lcdirdom = eclimide.cdirdom
        lcdui = eclimide.cnudoci.Trim
        lclugexp = eclimide.cLugExp.Trim
        'lcdui = lcdui.Replace("-", "")
        lcnit = eclimide.cnudotr.Trim
        lccoddom = eclimide.ccoddom.Trim

        lccodpro = eclimide.ccodpro

        Dim lvalida As Boolean
        Dim lcdocumento As String = ""
        Dim lcdoc As String
        lcdoc = eclimide.cnudoci

        lvalida = clase.ValidaCaracter(Left(lcdoc.Trim, 1))
        If lvalida = True Then 'Cedula
            lcdocumento = clase.LecturaCedula(lcdoc)
        Else 'DPI
            lcdocumento = clase.LecturaDPI(lcdoc)
        End If

        '-------------------------------Obtiene descripcion de codigo-----------------------------------------
        Dim lcdesestciv As String = ""
        lcdesestciv = mtabttab.Describe(lcestciv, "012").Trim


        'obtiene municipio y departamento expedicion
        Dim lcmuniexp As String = ""
        Dim lcdepaexp As String = ""

        Dim lclugexp1 As String = ""
        Dim lclugexp2 As String = ""

        Dim lcmuniexp1 As String = ""
        Dim lcmuniexp2 As String = ""

        Dim lcdepaexp1 As String = ""
        Dim lcdepaexp2 As String = ""

        'etabtzon.ccodzon = lclugexp
        'etabtzon.ctipzon = "2"
        'mtabtzon.ObtenerTabtzon(etabtzon)
        'lcmuniexp = etabtzon.cdeszon.Trim
        'lcmuniexp = lcmuniexp.ToUpper
        ''departamento
        'etabtzon.ccodzon = lclugexp.Substring(0, 2)
        'etabtzon.ctipzon = "1"
        'mtabtzon.ObtenerTabtzon(etabtzon)
        'lcdepaexp = etabtzon.cdeszon.Trim
        'lcdepaexp = lcdepaexp.ToUpper



        etabtprf.ccodigo = lccodpro
        mtabtprf.ObtenerTabtprf(etabtprf)
        lcprofesion = etabtprf.cdescri.Trim  ' profesion
        If eclimide.dnacimi <> Nothing Then
            lcedad = clase.EdadLetras(eclimide.dnacimi) 'Num2Text(Math.Round(Date.Now.Year - eclimide.dnacimi.Year))
            lcedad = lcedad.ToLower
        End If

        'detalla el dui en letras
        'lcdesdui = Me.Duiletras(lcdui)


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
        lcmunicipio = lcmunicipio.ToUpper
        'departamento
        etabtzon.ccodzon = lccoddom.Substring(0, 2)
        etabtzon.ctipzon = "1"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcdepartamento = etabtzon.cdeszon.Trim
        lcdepartamento = lcdepartamento.ToUpper

        '**************************obtiene datos del fiador******************
        Dim lcdocumento1 As String = ""
        Dim lcdoc1 As String = ""

        Dim lcdocumento2 As String = ""
        Dim lcdoc2 As String = ""


        Dim lcdesestciv1 As String = ""
        Dim lcdesestciv2 As String = ""

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

        Dim lcdirdom1 As String = ""
        Dim lcdirdom2 As String = ""

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
                    lcdoc1 = eclimide.cnudoci
                    lvalida = clase.ValidaCaracter(Left(lcdoc1.Trim, 1))
                    If lvalida = True Then 'Cedula
                        lcdocumento1 = clase.LecturaCedula(lcdoc1)
                    Else 'DPI
                        lcdocumento1 = clase.LecturaDPI(lcdoc1)
                    End If

                    'lcdui1 = lcdui1.Replace("-", "")
                    lccodpro1 = eclimide.ccodpro.Trim
                    ldnacimi1 = eclimide.dnacimi
                    lccoddom1 = eclimide.ccoddom.Trim
                    lcdirdom1 = eclimide.cdirdom.Trim

                    lcdesestciv1 = mtabttab.Describe(eclimide.cestciv, "012").Trim

                    lclugexp1 = eclimide.cLugExp.Trim
                    etabtzon.ccodzon = lclugexp1
                    etabtzon.ctipzon = "2"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcmuniexp1 = etabtzon.cdeszon.Trim
                    lcmuniexp1 = lcmuniexp1.ToUpper
                    'departamento
                    etabtzon.ccodzon = lclugexp1.Substring(0, 2)
                    etabtzon.ctipzon = "1"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcdepaexp1 = etabtzon.cdeszon.Trim
                    lcdepaexp1 = lcdepaexp1.ToUpper

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


                    lcdesduif1 = "" 'Me.Duiletras(lcdui1)


                    'obtiene profesion
                    etabtprf.ccodigo = lccodpro1
                    mtabtprf.ObtenerTabtprf(etabtprf)
                    lcprofesion1 = etabtprf.cdescri.Trim
                    lcprofesion1 = lcprofesion1.ToLower

                    'obtiene edad
                    lnedad1 = Date.Now.Year - ldnacimi1.Year
                    lcedad1 = clase.EdadLetras(ldnacimi1) 'Num2Text(lnedad1)
                    lcedad1 = lcedad1.ToLower

                    'domicilio
                    'obtiene municipio y departamento

                    etabtzon.ccodzon = lccoddom1.Substring(0, 4)
                    etabtzon.ctipzon = "2"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcmunicipio1 = etabtzon.cdeszon.Trim
                    lcmunicipio1 = lcmunicipio1.ToUpper

                    'departamento
                    etabtzon.ccodzon = lccoddom1.Substring(0, 2)
                    etabtzon.ctipzon = "1"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcdepartamento1 = etabtzon.cdeszon.Trim
                    lcdepartamento1 = lcdepartamento1.ToUpper
                End If
                'Segundo fiador >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                If lnfia = 2 Then
                    lccoduni = ds.Tables(0).Rows(ele)("ccoduni")
                    eclimide.ccodcli = lccoduni
                    mclimide.ObtenerClimide(eclimide)
                    lcnombre2 = eclimide.cnomcli.Trim
                    lcnit2 = eclimide.cnudotr.Trim
                    lcdui2 = eclimide.cnudoci.Trim

                    lcdoc2 = eclimide.cnudoci
                    lvalida = clase.ValidaCaracter(Left(lcdoc2.Trim, 1))
                    If lvalida = True Then 'Cedula
                        lcdocumento2 = clase.LecturaCedula(lcdoc2)
                    Else 'DPI
                        lcdocumento2 = clase.LecturaDPI(lcdoc2)
                    End If


                    'lcdui2 = lcdui2.Replace("-", "")
                    lccodpro2 = eclimide.ccodpro.Trim
                    ldnacimi2 = eclimide.dnacimi
                    lccoddom2 = eclimide.ccoddom.Trim
                    lcdirdom2 = eclimide.cdirdom.Trim
                    lcdesestciv2 = mtabttab.Describe(eclimide.cestciv, "012").Trim

                    lclugexp2 = eclimide.cLugExp.Trim
                    etabtzon.ccodzon = lclugexp2
                    etabtzon.ctipzon = "2"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcmuniexp2 = etabtzon.cdeszon.Trim
                    lcmuniexp2 = lcmuniexp2.ToUpper
                    'departamento
                    etabtzon.ccodzon = lclugexp2.Substring(0, 2)
                    etabtzon.ctipzon = "1"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcdepaexp2 = etabtzon.cdeszon.Trim
                    lcdepaexp2 = lcdepaexp2.ToUpper

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


                    lcdesduif2 = "" 'Me.Duiletras(lcdui2)



                    'obtiene profesion
                    etabtprf.ccodigo = lccodpro2
                    mtabtprf.ObtenerTabtprf(etabtprf)
                    lcprofesion2 = etabtprf.cdescri.Trim
                    lcprofesion2 = lcprofesion1.ToLower

                    'obtiene edad
                    lnedad1 = Date.Now.Year - ldnacimi2.Year
                    lcedad2 = clase.EdadLetras(ldnacimi2)  'Num2Text(lnedad1)
                    lcedad2 = lcedad2.ToLower

                    'domicilio
                    'obtiene municipio y departamento

                    etabtzon.ccodzon = lccoddom2.Substring(0, 4)
                    etabtzon.ctipzon = "2"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcmunicipio2 = etabtzon.cdeszon.Trim
                    lcmunicipio2 = lcmunicipio2.ToUpper

                    'departamento
                    etabtzon.ccodzon = lccoddom2.Substring(0, 2)
                    etabtzon.ctipzon = "1"
                    mtabtzon.ObtenerTabtzon(etabtzon)
                    lcdepartamento2 = etabtzon.cdeszon.Trim
                    lcdepartamento2 = lcdepartamento2.ToUpper
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
        '--------------------------------------------------------------------------------------
        'Garantia Hipotecaria
        Dim ds2 As New DataSet
        ds2 = mclimgar.ObtenerDataSetPor_Garantia_Cliente(lccodcli, "03")
        Dim fila2 As DataRow
        Dim lcgarah As String = ""
        Dim lcgarah1 As String = ""
        Dim ldfec1 As Date
        Dim lclug1 As String = ""
        Dim lcfec1 As String = ""
        Dim lcdesc1 As String = ""
        Dim lcnotario1 As String = ""
        For Each fila2 In ds2.Tables(0).Rows
            lcdesc1 = Trim(fila2("cdescri"))
            ldfec1 = fila2("dfechaes")
            lclug1 = fila2("clugares")
            lcnotario1 = fila2("cnotario")
            lcfec1 = Num2Text(ldfec1.Day) & " de " & MonthName(ldfec1.Month) & " del año " & Num2Text(ldfec1.Year)

            lcgarah1 = lcdesc1.Trim & " de fecha " & lcfec1 & " autorizada en la ciudad de " & lclug1 & " por el notario " & lcnotario1 & "; "
            lcgarah = lcgarah + lcgarah1
        Next




        Dim dsr As New DataSet
        Dim etabtusu As New cTabtusu
        dsr = etabtusu.ObtenerDataSetPorID()


        While Not input Is Nothing
            input = sr.ReadLine()
            If input = "**" Then
                Exit While
            End If

            '--
            input = input.Replace("/*pcnomcli/", txtcnomcli.Text.Trim)
            input = input.Replace("/*pcsumade/", lcmonto.Trim)
            input = input.Replace("/*pcmonsug/", clase.Cominola(lnmonsug.ToString.Trim))
            input = input.Replace("/*pccuotas/", lcplazo1.Trim)
            input = input.Replace("/*pcmoncuo/", lccuota.Trim)
            input = input.Replace("/*pccuota/", clase.Cominola(lncuota.ToString.Trim))
            input = input.Replace("/*pcmespri/", lcmespri.Trim.ToUpper)
            input = input.Replace("/*pcañocuopri/", lcañocuopri.Trim)
            input = input.Replace("/*pcdirdom/", lcdirdom.Trim)
            input = input.Replace("/*pcdia/", lndia.ToString.Trim)
            input = input.Replace("/*pcmes/", lcmes.Trim.ToUpper)
            input = input.Replace("/*pcano/", lnano.ToString.Trim)

            input = input.Replace("/*pcmunicipio/", lcmunicipio.Trim)
            input = input.Replace("/*pcdepartamento/", lcdepartamento.Trim)
            input = input.Replace("/*pcdui/", lcdui.Trim)

            input = input.Replace("/*pcmuniexp/", lcmuniexp.Trim)
            input = input.Replace("/*pcdepaexp/", lcdepaexp.Trim)


            'fiador 1
            input = input.Replace("/*pcnomfia1/", lcnombre1.Trim)
            input = input.Replace("/*pcdirdom1/", lcdirdom1.Trim)
            input = input.Replace("/*pcdepartamento1/", lcdepartamento1)
            input = input.Replace("/*pcmunicipio1/", lcmunicipio1)
            input = input.Replace("/*pcdui1/", lcdui1.Trim)

            'fiador 1
            input = input.Replace("/*pcnomfia2/", lcnombre2.Trim)
            input = input.Replace("/*pcdirdom2/", lcdirdom2.Trim)
            input = input.Replace("/*pcdepartamento2/", lcdepartamento2)
            input = input.Replace("/*pcmunicipio2/", lcmunicipio2)
            input = input.Replace("/*pcdui2/", lcdui2.Trim)

            input = input.Replace("/*pcmuniexp1/", lcmuniexp1.Trim)
            input = input.Replace("/*pcdepaexp1/", lcdepaexp1.Trim)
            input = input.Replace("/*pcmuniexp2/", lcmuniexp2.Trim)
            input = input.Replace("/*pcdepaexp2/", lcdepaexp2.Trim)

            '------------------------------------------------------------
            input = input.Replace("/*pcedad/", lcedad)
            input = input.Replace("/*pcdesestciv/", lcdesestciv)
            input = input.Replace("/*pcprofesion/", lcprofesion)
            input = input.Replace("/*pcmeses/", lnmeses.ToString)
            input = input.Replace("/*pcmeslet/", lcmeses)
            input = input.Replace("/*pctasint/", lntasint.ToString.Trim)
            input = input.Replace("/*pctasa/", lctasa)
            input = input.Replace("/*pcfrecuencia/", lcfrecuencia)
            input = input.Replace("/*pcfecha/", lcfecha)
            input = input.Replace("/*pcdocumento/", lcdocumento)
            input = input.Replace("/*pcdocumento1/", lcdocumento1)
            input = input.Replace("/*pcdocumento2/", lcdocumento2)
            '------------------------------------------------------------
            'aplicara para contratos 4 y 5
            If cbxContrato.SelectedValue.Trim = "D" Or cbxContrato.SelectedValue.Trim = "E" Then
                input = input.Replace("/*pcedad1/", lcedad1)
                input = input.Replace("/*pcedad2/", lcedad2)
                input = input.Replace("/*pcdesestciv1/", lcdesestciv1)
                input = input.Replace("/*pcdesestciv2/", lcdesestciv2)
                input = input.Replace("/*pcdestino/", lcdestino)
                input = input.Replace("/*pcprofesion1/", lcprofesion1)
            End If
            input = input.Replace("/*cgarah/", lcgarah)
            '------------------------------------------------------------

            'reemplaza las tildes
            input = input.Replace("?", "á")
            input = input.Replace(">", "é")
            input = input.Replace("!", "í")
            input = input.Replace("=", "ó")
            input = input.Replace("&", "ú")
            input = input.Replace("<", "ñ")
            input = input.Replace("#", "Ñ")

            'input = input.Replace("¿", "ú")





            'Visualiza en el navegador el contendido del archivo de texto
            objTextStream.WriteLine(input)


        End While


        sr.Close()
        objTextStream.Close()
        objTextStream = Nothing
        objFSO = Nothing

        Dim FilePath As String = "C:\wwwCDRO\contratos2\" & contrato & "_" & lcnombre.Trim & ".doc"

        Me.DownloadFile(FilePath, contrato & "_" & lcnombre.Trim & ".doc")

    End Sub
    Private Sub DownloadFile(ByVal filepath As String, ByVal name As String)

        Dim type As String = ""


        'If Not IsDBNull(ext) Then
        '    ext = LCase(ext)
        'End If

        'Select Case ext
        '    Case ".htm", ".html"
        '        type = "text/HTML"
        '    Case ".txt"
        '        type = "text/plain"
        '    Case ".doc", ".rtf"
        '        type = "Application/msword"
        '    Case ".csv", ".xls"
        '        type = "Application/x-msexcel"
        '    Case Else
        '        type = "text/plain"
        'End Select

        '        If (forceDownload) Then
        Response.AppendHeader("content-disposition", _
        "attachment; filename=" + name)
        'End If
        'If type <> "" Then
        Response.ContentType = "application/msword"
        '"Application/x-msexcel"
        'End If

        Response.WriteFile(filepath)
        Response.End()

    End Sub
    Private Function FiltraTablaInteresesVencidos(ByVal TablaTemporal As DataTable, ByVal Filtro As String) As DataTable

        Dim dvVista As New DataView

        dvVista = TablaTemporal.DefaultView

        dvVista.RowFilter = Filtro

        Return dvVista.ToTable

    End Function
    Private Function ObtieneMiembros(ByVal ccodcta As String) As DataSet
        Dim ds As New DataSet
        Dim ecreditos As New ccreditos
        Dim entidadcreditos As New creditos

        entidadcreditos.ccodcta = ccodcta
        ecreditos.Obtenercreditos(entidadcreditos)

        Dim lcestado As String
        Dim lccodsol As String
        lcestado = entidadcreditos.cestado
        lccodsol = entidadcreditos.ccodsol

        ds = ecreditos.ListadoCreditosParaContrato(lccodsol, lcestado, ccodcta)

        Return ds
    End Function
    Public Function RellenarEspacios(ByVal cadena As String) As String
        Dim tamano As Integer = 0
        tamano = cadena.Length
        For i = 1 To 60 - tamano
            cadena = cadena & " "
        Next
        Return cadena
    End Function
End Class
