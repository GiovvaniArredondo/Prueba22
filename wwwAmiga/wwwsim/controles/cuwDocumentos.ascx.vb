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

Public Class cuwDocumentos


    Inherits System.Web.UI.UserControl
    Dim ecremsol As New cCremsol
    Dim ecremcre As New cCremcre
    Dim etabtprf As New tabtprf
    Dim mtabtprf As New cTabtprf
    Dim etabtzon As New tabtzon
    Dim mtabtzon As New cTabtzon
    Dim entidadCretlin As New SIM.EL.cretlin
    Dim eCretlin As New SIM.BL.cCretlin
    Dim clsppal As New class1
    Dim ecredtpl As New cCredtpl

    Private cls1 As New SIM.BL.ClsMantenimiento
#Region "Variables"
    'Variable de la clase Mantenimiento
    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private Transacc As String
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
            Me.txtdfecha.Text = Session("gdfecsis")
            lista()
        End If

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtcCodsol.Text = codigoCliente.Trim

        Dim lcnomgru As String
        lcnomgru = ecremsol.ObtenerNombre(codigoCliente.Trim)
        Me.txtcnomgru.Text = lcnomgru.Trim

    End Sub
    Public Sub lista()
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        mListaTabttab = clstabttab.ObtenerLista("145", "1")

        Me.ddlexportar.DataTextField = "cdescri"
        Me.ddlexportar.DataValueField = "ccodigo"
        Me.ddlexportar.DataSource = mListaTabttab
        Me.ddlexportar.DataBind()


        '>>>>>>>>>>>>>>>>>>>>>>>>
        Dim ds As New DataSet

        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0771' and left(ccodigo,1) = 'B'"
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
        ds.Tables(0).Clear()
        '<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub
    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        Dim ds As New DataSet
        Dim clase As New class1
        Dim lctipper As String
        Dim lncuosug As Integer
        Dim lndiasug As Integer
        Dim lcforma As String
        Dim ecredtpl As New cCredtpl
        Dim lncuotag As Double
        ds = ecremsol.DataSetDoc1(Me.txtcCodsol.Text.Trim)
        If ds.Tables(0).Rows.Count = 0 Then
        Else
            lncuotag = ecredtpl.CapitalInteresGrupal(Me.txtcCodsol.Text.Trim)


            lctipper = IIf(IsDBNull(ds.Tables(0).Rows(0)("ctipper")), "0", ds.Tables(0).Rows(0)("ctipper"))
            lncuosug = IIf(IsDBNull(ds.Tables(0).Rows(0)("ncuosug")), 0, ds.Tables(0).Rows(0)("ncuosug"))
            lndiasug = IIf(IsDBNull(ds.Tables(0).Rows(0)("ndiasug")), 0, ds.Tables(0).Rows(0)("ndiasug"))

            lcforma = clase.formapago(lctipper, lndiasug, lncuosug) + " DE $ " + lncuotag.ToString + " QUETZALES C/U."

            ds.Tables(0).Rows(0)("cforma") = lcforma


            imprimir(ds, "crComgru.rpt")

        End If
    End Sub

    Private Sub btnCancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.ServerClick
        Dim ds As New DataSet
        ds = procesoset()
        imprimir(ds, "crSolgru.rpt")
    End Sub
    Private Function procesoset() As DataSet
        Dim ds As New DataSet
        Dim dsgas As New DataSet

        Dim clase As New class1
        Dim ecremcre As New cCremcre
        Dim etabtzon As New cTabtzon
        Dim ldfecant As Date
        Dim lncomodin As Integer = 0
        ldfecant = ecremcre.PresGrAnt(Me.txtcCodsol.Text.Trim)

        ds = ecremsol.DataSetDoc2(Me.txtcCodsol.Text.Trim)
        Dim fila As DataRow
        Dim fila1 As DataRow

        Dim i As Integer = 0

        Dim lccodcta As String
        Dim lccodact As String
        Dim lccodzon As String
        Dim lccodcli As String
        Dim ecredgas As New cCredgas
        Dim etabtciu As New cTabtciu
        Dim ecretlin As New cCretlin
        Dim lcpresidenta As String
        Dim lnmonapr As Double = 0
        Dim lntotal As Double = 0
        Dim lcfuente As String = ""
        For Each fila In ds.Tables(0).Rows
            lccodcta = ds.Tables(0).Rows(i)("cCodcta")
            lccodact = ds.Tables(0).Rows(i)("cCodact")
            lccodzon = IIf(IsDBNull(ds.Tables(0).Rows(i)("cCodzon")), "020100", ds.Tables(0).Rows(i)("cCodzon"))
            lccodcli = ds.Tables(0).Rows(i)("cCodcli")
            lncomodin = ecremcre.AntSocio(lccodcli, Me.txtcCodsol.Text.Trim, ldfecant)
            lcpresidenta = ecremcre.ObtenerPresidenta(Me.txtcCodsol.Text.Trim, ds.Tables(0).Rows(i)("dfecvig"))
            lcfuente = ecretlin.ObtenerFuentedeFondos(ds.Tables(0).Rows(i)("cnrolin"))
            lnmonapr = ds.Tables(0).Rows(i)("nmonapr")
            dsgas = ecredgas.ObtenerDataSetPorID2(lccodcta, "D")

            Dim lndescuento As Double = 0
            Dim lngasto As Double = 0
            Dim y As Integer = 0
            For Each fila1 In dsgas.Tables(0).Rows
                lngasto = dsgas.Tables(0).Rows(y)("nmongas")
                lndescuento = lndescuento + lngasto
                y += 1
            Next
            ds.Tables(0).Rows(i)("nDescuento") = lndescuento
            ds.Tables(0).Rows(i)("cActividad") = etabtciu.CIIU(lccodact)
            ds.Tables(0).Rows(i)("npresant") = ecremcre.PresAnt(lccodcta)
            If IsDBNull(lccodzon) Or lccodzon = Nothing Then
                ds.Tables(0).Rows(i)("cdepto") = ""
                ds.Tables(0).Rows(i)("cmuni") = ""
            Else
                ds.Tables(0).Rows(i)("cdepto") = etabtzon.Zona(lccodzon.Trim.Substring(0, 2))
                ds.Tables(0).Rows(i)("cmuni") = etabtzon.Zona(lccodzon.Trim.Substring(0, 4))
            End If
            ds.Tables(0).Rows(i)("cdepto") = etabtzon.Zona(lccodzon.Trim.Substring(0, 2))
            ds.Tables(0).Rows(i)("cmuni") = etabtzon.Zona(lccodzon.Trim.Substring(0, 4))
            ds.Tables(0).Rows(i)("cpresidenta") = lcpresidenta
            ds.Tables(0).Rows(i)("cfuente") = lcfuente
            If lncomodin = 0 Then
                ds.Tables(0).Rows(i)("nsocnue") = 1
                ds.Tables(0).Rows(i)("nsocant") = 0
                ds.Tables(0).Rows(i)("nsocret") = 0
            ElseIf lncomodin = 1 Then
                ds.Tables(0).Rows(i)("nsocnue") = 0
                ds.Tables(0).Rows(i)("nsocant") = 1
                ds.Tables(0).Rows(i)("nsocret") = 0
            Else
                ds.Tables(0).Rows(i)("nsocret") = 1
                ds.Tables(0).Rows(i)("nsocnue") = 0
                ds.Tables(0).Rows(i)("nsocant") = 0
            End If
            lntotal = lntotal + (lnmonapr - lndescuento)
            i += 1
        Next

        Dim clsConvert As New SIM.BL.ConversionLetras

        Dim lcletras As String
        Dim lndecimal As Double
        lcletras = clsConvert.ConversionEnteros(lntotal)
        lndecimal = clsConvert.ExtraeDecimales(lntotal)
        If lndecimal >= 10 Then
            lcletras = lcletras.Trim & " " & lndecimal.ToString & "/100" & " QUETZALES"
        Else
            lcletras = lcletras.Trim & " 0" & lndecimal.ToString & "/100" & " QUETZALES"
        End If
        Me.txtmontolet.Text = lcletras
        Return ds
    End Function


    Sub imprimir(ByVal ds As DataSet, ByVal reportes As String)
        '
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String

        Dim dsbase As New DataSet
        dsbase = ds
        lcexportar = Me.ddlexportar.SelectedValue.Trim
        ldfecha2 = Date.Parse(Me.txtdfecha.Text)
        lcexportar = lcexportar.Trim



        Try
            If dsbase Is Nothing Then
                '        Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    '           Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            '  Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "FONDESOL"

        Dim a As String
        a = dsbase.Tables(0).TableName


        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("dfecha1", Session("gdfecsis"))
        crRpt.SetParameterValue("cNomOfi", lcNomofi)
        If reportes.Trim = "crSolchq.rpt" Then
            crRpt.SetParameterValue("cmonlet", Me.txtmontolet.Text.Trim)
        End If


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
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()
        'Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        Dim ds As New DataSet
        ds = procesoset()
        imprimir(ds, "crSolefe.rpt")
    End Sub
    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick
        Dim ds As New DataSet
        ds = procesoset()
        imprimir(ds, "crSolchq.rpt")
    End Sub
    Sub imprimir2(ByVal reportes As String)
        'Verifica si existe planilla con esa fecha
        'Verifica si existe tabla
        Dim lcnombre As String
        Dim lcdia As String
        Dim lcmes As String
        Dim lcaño As String
        Dim lnverifica As Integer
        Dim eempleados As New cEmpleados


        lcdia = Me.txtdfecha.Text.Trim.Substring(0, 2)
        lcmes = Me.txtdfecha.Text.Trim.Substring(3, 2)
        lcaño = Me.txtdfecha.Text.Trim.Substring(6, 4)
        lcnombre = "Emp" & lcdia & lcmes & lcaño

        lnverifica = eempleados.VerificaHistorico(lcnombre)
        If lnverifica = 0 Then
            Response.Write("<script language='javascript'>alert('Planilla No esta Guardada')</script>")
            Exit Sub
        End If
        '
        Dim ldfecha2 As Date
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String

        Dim dsbase As New DataSet
        dsbase = eempleados.Planilla(lcnombre)
        lcexportar = Me.ddlexportar.SelectedValue.Trim
        ldfecha2 = Date.Parse(Me.txtdfecha.Text)
        lcexportar = lcexportar.Trim



        Try
            If dsbase Is Nothing Then
                '        Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsbase.Tables(0).Rows.Count = 0 Then
                    '           Me.AsignarMensaje("No se encontro información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            '  Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim fila1 As DataRow
        Dim j As Integer = 0
        Dim lccoddepto As String
        Dim lccod As String
        Dim conta As Integer = 0
        lccoddepto = dsbase.Tables(0).Rows(0)("cdepto")
        Dim lccuenta As String
        For Each fila1 In dsbase.Tables(0).Rows
            lccod = dsbase.Tables(0).Rows(j)("cdepto")
            lccuenta = dsbase.Tables(0).Rows(j)("ccuenta")
            If lccuenta.Trim = "" Then
                dsbase.Tables(0).Rows(j).Delete()
                dsbase.Tables(0).GetChanges(DataRowState.Deleted)
            Else
                If lccoddepto.Trim <> lccod.Trim Then
                    conta = 0
                End If
                conta = conta + 1
                lccoddepto = dsbase.Tables(0).Rows(j)("cdepto")
                dsbase.Tables(0).Rows(j)("ID") = conta.ToString
            End If

            j += 1
        Next
        dsbase.Tables(0).AcceptChanges()

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\" & reportes, OpenReportMethod.OpenReportByDefault)

        Catch ex As Exception
            Return
        End Try

        'Nombre de la Institución
        Dim lcNomofi As String = "FONDESOL"

        Dim a As String
        a = dsbase.Tables(0).TableName


        crRpt.SetDataSource(dsbase.Tables(a))
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("dfecha1", Session("gdfecsis"))
        crRpt.SetParameterValue("cNomOfi", lcNomofi)


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
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)

        Response.BinaryWrite(rptStream.ToArray())
        Response.Flush()
        Response.Close()
        'Response.End()

        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub



    Sub contratos(ByVal contrato As String, ByVal tipocontrato As String)
        Dim input As String
        Dim lcnomcli As String
        Dim lcnombar As String
        Dim lcnombre As String
        Dim lcnomgru As String = ""

        'escribir
        lcnombre = contrato & Me.txtcnomgru.Text.Trim & ".doc"
        Const fsoLectura = 1
        Const fsoescritura = 2

        Dim objFSO
        'Instanciación del objeto FSO
        objFSO = Server.CreateObject("Scripting.FileSystemObject")

        'Abrir el archivo de texto
        Dim objTextStream
        objTextStream = objFSO.OpenTextFile("C:\wwwasa\contratos2\" & lcnombre, fsoescritura, True)
        Dim nombrecontrato As String
        nombrecontrato = "mutuog"

        lcnombar = nombrecontrato & ".txt"
        lcnombre = Me.txtcnomgru.Text.Trim
        lcnomgru = Me.txtcnomgru.Text.Trim
        Dim lcnomcen As String = ""
        lcnomcen = ecremsol.ObtenerNombreCentro2(Me.txtcCodsol.Text.Trim)
        lcnomcen = lcnomcen.Trim
        'lee un archivo de texto
        Dim FILE_NAME As String = "c:/wwwasa/contratos/" & lcnombar
        If Not File.Exists(FILE_NAME) Then
            Return
        End If

        Dim sr As StreamReader = File.OpenText(FILE_NAME)

        input = sr.ReadLine()
        lcnomcli = Me.txtcnomgru.Text.Trim

        'Obtiene datos de miembros del grupo
        Dim ds As New DataSet
        ds = ecremsol.DataSetDoclegal(Me.txtcCodsol.Text.Trim)
        Dim lcparrafo1 As String = ""
        Dim lcparrafo2 As String = ""
        Dim lcparrafo3 As String = ""

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodpro As String = ""
        Dim lcprofesion As String = ""
        Dim lccodzon As String = ""
        Dim lnmonapr As Double = 0
        Dim lnmonto As Double = 0
        Dim lcnrolin As String = ""
        Dim lnsemanas As Double = 0
        Dim lcsemanas As String = ""
        Dim ldvencimiento As Date = Session("gdfecsis")
        Dim lncuoapr As Double
        Dim lctipper As String = ""
        Dim lndiaapr As Integer
        Dim llfirma As Boolean
        Dim lcfirma As String = ""
        Dim ldfecvig As Date
        Dim k As Integer = 0
        Dim l As Integer = 0
        Dim ldnacimi As Date
        Dim lnedad As Integer
        Dim lcedad As String
        Dim ldfecha1 As Date = Session("gdfecsis")
        Dim lcdui As String
        Dim lcduilet As String
        Dim lcdiareu As String = ""

        l = ds.Tables(0).Rows.Count

        For Each fila In ds.Tables(0).Rows
            lccodpro = ds.Tables(0).Rows(i)("ccodpro")
            lcnomcli = ds.Tables(0).Rows(i)("cnomcli")
            lccodzon = IIf(IsDBNull(ds.Tables(0).Rows(i)("ccodzon")), "020100", ds.Tables(0).Rows(i)("ccodzon"))
            lnmonapr = ds.Tables(0).Rows(i)("nmonapr")
            lcnrolin = ds.Tables(0).Rows(i)("cnrolin")
            lnsemanas = ds.Tables(0).Rows(i)("semanas")
            lncuoapr = ds.Tables(0).Rows(i)("ncuoapr")
            ldvencimiento = ds.Tables(0).Rows(i)("dfecven")
            lctipper = ds.Tables(0).Rows(i)("ctipper")
            lndiaapr = ds.Tables(0).Rows(i)("ndiasug")
            llfirma = ds.Tables(0).Rows(i)("cfirma")
            ldfecvig = ds.Tables(0).Rows(i)("dfecvig")
            ldnacimi = ds.Tables(0).Rows(i)("dnacimi")
            lnedad = Int(DateDiff(DateInterval.Day, ldnacimi, ldfecha1) / 365)
            lcedad = Num2Text(lnedad)
            lcdui = ds.Tables(0).Rows(i)("cnudoci")
            lcdui = lcdui.Replace("-", "")
            lcduilet = Me.Duiletras(lcdui)
            lcdiareu = IIf(IsDBNull(ds.Tables(0).Rows(i)("cdiareu")), "", ds.Tables(0).Rows(i)("cdiareu"))
            If llfirma = False Then
                k += 1
                If i = (l - 1) Then
                    lcfirma = lcfirma & "y " & Num2Text(k)
                Else
                    If k > 1 Then
                        lcfirma = lcfirma & "," & Num2Text(k)
                    Else
                        lcfirma = lcfirma & Num2Text(k)
                    End If
                End If

            End If
            lnmonto = lnmonto + lnmonapr
            etabtprf.ccodigo = lccodpro
            mtabtprf.ObtenerTabtprf(etabtprf)
            lcprofesion = etabtprf.cdescri.Trim  ' profesion
            lcparrafo1 = lcparrafo1 + (lcnomcli.Trim + ", " + lcprofesion + "; ")
            lcparrafo2 = lcparrafo2 + (lcnomcli.Trim + ", " + " de  " + lcedad + " años de edad, " + lcprofesion + "; ")
            lcparrafo3 = lcparrafo3 + lcduilet.Trim + "; "
            i += 1
        Next

        'obtiene municipio y departamento
        Dim lcmunicipio As String = ""
        Dim lcdepartamento As String = ""

        etabtzon.ccodzon = lccodzon.Substring(0, 4)
        etabtzon.ctipzon = "3"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcmunicipio = etabtzon.cdeszon.Trim
        lcmunicipio = lcmunicipio.ToLower
        'departamento
        etabtzon.ccodzon = lccodzon.Substring(0, 2)
        etabtzon.ctipzon = "1"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcdepartamento = etabtzon.cdeszon.Trim
        lcdepartamento = lcdepartamento.ToLower
        '------
        Dim lnentero As Double = 0
        Dim lndeci As Double = 0
        Dim lcmonto As String = 0

        lnentero = Decimal.Floor(lnmonto)
        lndeci = Math.Round((lnmonto - lnentero) * 100)
        If lndeci > 0 Then
            lcmonto = Num2Text(lnentero) & " CON " & Num2Text(lndeci) & " CENTAVOS" & " QUETZALES DE LOS ESTADOS UNIDOS DE NORTEAMERICA "
        Else
            lcmonto = Num2Text(lnentero) & " QUETZALES DE LOS ESTADOS UNIDOS DE NORTEAMERICA"
        End If
        '------
        Dim lntasa As Double
        entidadCretlin.cnrolin = lcnrolin.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        lntasa = Math.Round(entidadCretlin.ntasint / 12, 2)
        Dim lctasalet As String = ""
        lctasalet = Num2Text(lntasa.ToString) + " POR CIENTO MENSUAL"
        '-----
        lcsemanas = Num2Text(lnsemanas.ToString)
        '-----
        'obtiene fecha de vencimiento
        Dim lnmes As Integer
        Dim lndia As Integer
        Dim lnano As Integer
        Dim lcmes As String
        Dim lcvencimiento As String
        lnmes = ldvencimiento.Month
        lndia = ldvencimiento.Day
        lnano = ldvencimiento.Year
        lcmes = MonthName(lnmes)
        lcvencimiento = Num2Text(lndia) & " DEL MES DE " & lcmes & " DE " & Num2Text(lnano)
        lcvencimiento = lcvencimiento.ToLower
        '-----
        Dim lccuoapr As String
        Dim lcforma As String
        lccuoapr = Num2Text(lncuoapr) & " " 'cuotas en letras
        lcforma = clsppal.formapago2(lctipper, lndiaapr)

        '-----
        Dim lncuota As Double
        Dim lccuotavalor As String
        lncuota = ecredtpl.CapitalInteresGrupal(Me.txtcCodsol.Text.Trim)

        Dim lnentero1 As Double = 0
        Dim lndeci1 As Double = 0
        Dim lccuota As String

        lnentero1 = Decimal.Floor(lncuota)
        lndeci1 = Math.Round((lncuota - lnentero1) * 100)
        If lndeci1 > 0 Then
            lccuota = Num2Text(lnentero1) & " CON " & Num2Text(lndeci1) & " CENTAVOS" & " QUETZALES DE LOS ESTADOS UNIDOS DE NORTEAMERICA "
        Else
            lccuota = Num2Text(lnentero1) & " QUETZALES DE LOS ESTADOS UNIDOS DE NORTEAMERICA"
        End If
        lccuotavalor = lncuota.ToString
        '--------
        Dim lcpresidenta As String
        lcpresidenta = ecremcre.ObtenerPresidenta(Me.txtcCodsol.Text.Trim, ldfecvig)
        '--------
        'fecha desembolso
        Dim ldfecha As Date
        ldfecha = Date.Parse(Me.txtdfecha.Text.Trim)
        Dim lcfecha As String

        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcmes = MonthName(lnmes)
        lcfecha = Num2Text(lndia) & " DIAS DEL MES DE " & lcmes & " DE " & Num2Text(lnano)
        lcfecha = lcfecha.ToLower


        While Not input Is Nothing
            input = sr.ReadLine()
            If input = "**" Then
                Exit While
            End If

            input = input.Replace("/*nombre/", lcparrafo1)
            input = input.Replace("/*domicilio/", lcmunicipio)
            input = input.Replace("/*depto/", lcdepartamento)
            input = input.Replace("/*nomgru/", lcnomgru)
            input = input.Replace("/*nomcen/", lcnomcen)

            input = input.Replace("/*montolet/", lcmonto)
            input = input.Replace("/*montovalor/", ("$" & lnmonto.ToString))
            input = input.Replace("/*interes/", lctasalet)
            input = input.Replace("/*semanas/", lcsemanas)
            input = input.Replace("/*fechavencimiento/", lcvencimiento)
            input = input.Replace("/*cuotaslet/", lccuoapr)
            input = input.Replace("/*forma/", lcforma)
            input = input.Replace("/*cuota/", lccuota)
            input = input.Replace("/*cuotavalor/", ("$" & lccuotavalor))
            input = input.Replace("/*firmano/", lcfirma)
            input = input.Replace("/*aruego/", lcpresidenta)
            input = input.Replace("/*fechacontrato/", lcfecha)
            input = input.Replace("/*nombre1/", lcparrafo2)
            input = input.Replace("/*duilet/", lcparrafo3)
            input = input.Replace("/*diareu/", lcdiareu)
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

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        contratos("MUTUOG ", "B")
    End Sub
End Class
