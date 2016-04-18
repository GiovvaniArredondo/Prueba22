

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

Partial Class cuwEstadoC
    Inherits ucWBase
   
#Region " Variables "
    Dim cls1 As New SIM.BL.pagdesver
    Private cls2 As New SIM.BL.ClsMantenimiento
    Private clsConvert As New SIM.BL.ConversionLetras
    Dim clsaplica As New SIM.BL.payment
    Dim ecremcre As New cCremcre
    Dim pncomper As Double = 0
    Dim pnsegdeu As Double = 0
    Dim dsnopagos As New DataSet
    Dim ecremsol As New cCremsol

    Private clase As New SIM.BL.class1
    Private cls_Sim As New SIM.BL.ClsSolicitud

    Private pcCodCta As String
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
    Private ValorS As String

    Dim dsimprimepagos As New DataSet
#End Region
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
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then

            Dim ldfecsis As Date
            ldfecsis = Session("gdfecsis")
            Me.txtfecbar.Text = ldfecsis
            Me.Deshabilitar()

            '            Me.archivodetexto.Attributes.Add("onclick", "funcionclick")
        End If

    End Sub
   
    Private Sub Deshabilitar()
    

    End Sub
  
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Me.txtcCodsol.Text = codigoCliente.Trim
        Dim lcnomgru As String
        lcnomgru = ecremsol.ObtenerNombrecentro(codigoCliente.Trim)
        Me.txtcentro.Text = lcnomgru

        ecremcre.EliminaTablaPagos(Me.txtcCodsol.Text.Trim)

        Me.CargaSocias()
    End Sub
   
    Private Function Datos() As DataSet
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim ecredppg As New cCredppg
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lncuota As Double = 0
        ds = ecremcre.ObtenerSocia(Me.txtccomodin.Text.Trim)
        For Each fila In ds.Tables(0).Rows
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i)("codigo"))
            ds.Tables(0).Rows(i)("ncuota") = lncuota
            ds.Tables(0).Rows(i)("npago") = lncuota
            ds.Tables(0).Rows(i)("lsolidario") = False
            i += 1
        Next
        Return ds
    End Function
    Private Sub CargaSocias()
        Dim ecremcre As New cCremcre
        Dim ecredppg As New cCredppg

        Dim ds As New DataSet
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lncuota As Double = 0
        Dim lnaaplicar As Double = 0
        Dim lndeuda As Double = 0
        ds = ecremcre.ObtenerSociasporCentro(Me.txtcCodsol.Text.Trim)
        For Each fila In ds.Tables(0).Rows
            lncuota = ecredppg.CapitalInteres(ds.Tables(0).Rows(i)("codigo"))
            lndeuda = DeudaAldia(ds.Tables(0).Rows(i)("codigo"))
            ds.Tables(0).Rows(i)("ncuota") = lncuota
            ds.Tables(0).Rows(i)("npago") = lncuota
            ds.Tables(0).Rows(i)("lsolidario") = False
            ds.Tables(0).Rows(i)("ndeuda") = lndeuda
            lnaaplicar = lnaaplicar + lncuota
            ecremcre.InsertaTablaPagos(ds.Tables(0).Rows(i)("codigo"), ds.Tables(0).Rows(i)("cnomcli"), lncuota, lncuota, False, lndeuda, Me.txtcCodsol.Text.Trim)

            i += 1
        Next
      
    End Sub
    

  

    Private Sub imprime_recibo()
        Try
            If dsnopagos Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsnopagos.Tables(0).Rows.Count = 0 Then
                    Me.AsignarMensaje("El Cliente elegido no tiene información a ser desplegada")
                    Return
                End If
            End If
        Catch ex As Exception
            Me.AsignarMensaje("Error al obtener informacion del reporte.Error: " + ex.Message, True)
            Return
        End Try

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        crRpt.Load(Server.MapPath("reportes") + "\crnopagos.rpt", OpenReportMethod.OpenReportByDefault)

        crRpt.SetDataSource(dsnopagos.Tables(0))
        '        crRpt.SetParameterValue("parametroPrueba", "PRUEBA")

        Dim ldfecha1 As Date
        Dim ldfecha2 As Date
        ldfecha1 = Date.Parse(Me.txtfecbar.Text)
        ldfecha2 = Date.Parse(Me.txtfecbar.Text)

        crRpt.SetDataSource(dsnopagos.Tables(0))
        crRpt.SetParameterValue("oficina", "Todas las oficinas")
        crRpt.SetParameterValue("analista", "Todos los analistas")
        crRpt.SetParameterValue("estrato", "Todas las carteras")
        crRpt.SetParameterValue("linea", "Todas las líneas")
        crRpt.SetParameterValue("dfecha1", ldfecha1)
        crRpt.SetParameterValue("dfecha2", ldfecha2)
        crRpt.SetParameterValue("cnomofi", Session("gcnomofi"))
        Dim reportes As String
        reportes = "crnopagos.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        'Response.End()
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()


    End Sub


    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub


    Private Sub archivodetexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Function MontoCuota(ByVal ccodcta As String, ByVal dskar As DataSet, ByVal i As Integer) As Double
        Dim clase As New class1
        Dim pncuota As Double
        clase.cNrolin = dskar.Tables(0).Rows(i)("cnrolin")
        clase.nMonDes = dskar.Tables(0).Rows(i)("ncapdes")
        clase.cCodFor = dskar.Tables(0).Rows(i)("ctipper")
        clase.nPerDia = dskar.Tables(0).Rows(i)("ndiaapr")
        clase.gnperbas = Session("gnPerbas")
        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm")
        clase.OtrosGastos()
        pncomper = utilNumeros.Redondear(clase.pnComPer, 2)
        pnsegdeu = utilNumeros.Redondear(clase.pnSegDeu, 2)

        Dim entidadcredppg As New credppg
        Dim ecredppg As New cCredppg


        entidadcredppg.ccodcta = dskar.Tables(0).Rows(i)("ccodcta")
        entidadcredppg.ctipope = "N"
        entidadcredppg.cnrocuo = "001"

        ecredppg.Recuperar(entidadcredppg)
        Dim pncapita As Double = 0
        Dim pnintere As Double = 0
        pncapita = utilNumeros.Redondear(entidadcredppg.ncapita, 2)
        pnintere = utilNumeros.Redondear(entidadcredppg.nintere, 2)
        pncuota = pncapita + pnintere + pncomper + pnsegdeu
        Return pncuota
    End Function

   
    

    <System.Web.Services.WebMethodAttribute()> <System.Web.Script.Services.ScriptMethodAttribute()> Public Shared Function GetDynamicContent(ByVal contextKey As System.String) As System.String

    End Function

   

    Private Sub Imprime_Recibo_Grupal()
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        Dim ldfecha As Date = Date.Parse(Me.txtfecbar.Text)
        ds = ecreditos.CarteraCalculadaxCentro(ldfecha, Me.txtcCodsol.Text.Trim)

        '-----------------------------------------'
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crestcentro.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("dfecha2", ldfecha)
        
        Dim reportes As String
        'reportes = "crpagos.rpt"
        reportes = "crpagoscentros.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        '>>>>
        '<<<<
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" + reportes)
        Response.Flush()
        Response.Close()
        'Response.End()
    End Sub
    Private Sub btnrecibo_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecibo.ServerClick
        Me.Imprime_Recibo_Grupal()
    End Sub

    Private Function DeudaAldia(ByVal pccodcta As String) As Double
        Dim ldfecval As Date
        Dim ok As Integer
        Dim lndeuda As Double = 0
        Dim lndeucap As Double = 0
        Dim lnsalint As Double = 0
        Dim lnsalmor As Double = 0

        ldfecval = Date.Parse(Me.txtfecbar.Text.Trim)

        clsaplica.pccodcta = pccodcta
        clsaplica.pdfecval = ldfecval
        clsaplica.gdfecsis = ldfecval
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.gdultpag = #2/1/1970#
        clsaplica.gnperbas = Session("gnperbas")
        clsaplica.pcestado = "F"

        clsaplica.gnpergra = Session("gnpergra")
        ok = clsaplica.omcalcinterest("T", ldfecval)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        If ok = 9 Then
            ok = 9
        Else
            If ok = 1 Then
                lndeucap = Math.Round(clsaplica.pndeucap, 2)
                lnsalint = Math.Round(clsaplica.pnsalint, 2)
                lnsalmor = Math.Round(clsaplica.pnsalmor, 2)

            End If

        End If

        lndeuda = Math.Round(lndeucap + lnsalint + lnsalmor, 2)
        Return lndeuda

    End Function

End Class


