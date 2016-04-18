

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



Imports System.Data.OleDb


Partial Class ucleerxml
    Inherits ucWBase

    Dim cls1 As New SIM.BL.pagdesver
    Private clsConvert As New SIM.BL.ConversionLetras
    Dim clsaplica As New SIM.bl.payment
    Dim pncomper As Double = 0
    Dim pnsegdeu As Double = 0
    Dim dsnopagos As New DataSet

    Private _dsdatos As New DataSet
    Private Property dsdatos() As DataSet
        Get
            Return _dsdatos
        End Get
        Set(ByVal value As DataSet)
            _dsdatos = value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim ldfecsis As Date
            ldfecsis = Session("gdfecsis")
            Me.txtfecbar.Text = ldfecsis
            Me.txtdesde.Text = Session("gdfecsis")
            Me.txthasta.Text = Session("gdfecsis")

            '            Me.archivodetexto.Attributes.Add("onclick", "funcionclick")
            CargaCombo()
        End If

    End Sub
    Private Sub CargaCombo()
        Dim clsbancos As New SIM.BL.cTabtbco
        Dim dsb As New DataSet
        clsbancos.ObtenerBancosenUso(dsb, Session("gcCodofi"))
        Me.cmbbanco.DataTextField = "cnombco"
        Me.cmbbanco.DataValueField = "ccodbco"
        Me.cmbbanco.DataSource = dsb.Tables(0)
        Me.cmbbanco.DataBind()
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





    Private Function LeerArchivo(ByVal file As String) As DataSet
        Dim m_sConn1 As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                 "Data Source=" & file & ";" & _
                                 "Extended Properties=" & "'" & "Excel 8.0;HDR=YES" & "'"

        'Microsoft.ACE.OLEDB.12.0  "Excel 12.0
        Dim conn2 As New OleDb.OleDbConnection(m_sConn1)
        Dim consulta As String
        consulta = "Select * From [Hoja1$] order by fecha, docto"
        Dim da As New OleDb.OleDbDataAdapter(consulta, conn2)

        Dim dsxls As New DataSet



        da.Fill(dsxls)
        da.Dispose()
        conn2.Close()


        'Me.dsdatos = ds
        Return dsxls

    End Function

    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GridView1.PageIndex = 0
        CargaGrid()
    End Sub

    Private Sub CargaGrid()
        Dim lcnombar As String

        lcnombar = Me.txtnombar.Text.Trim & ".xls"

        'lee un archivo de Excel
        Dim FILE_NAME As String = "c:/txt/" & lcnombar

        If Not File.Exists(FILE_NAME) Then
            Me.AsignarMensaje("No existe archivo: " + lcnombar, True)
            Return
        End If


        Dim ds As New DataSet

        ds = LeerArchivo(FILE_NAME)
        Me.GridView1.DataSource = ds
        Me.GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView1.PageIndexChanging

        If Me.IsPostBack Then

            Me.GridView1.PageIndex = 0

            Me.GridView1.PageIndex = e.NewPageIndex

            Me.CargaGrid()

        End If

    End Sub

  
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim lcnombar As String

        lcnombar = Me.txtnombar.Text.Trim & ".xls"

        'lee un archivo de Excel
        Dim FILE_NAME As String = "c:/txt/" & lcnombar

        If Not File.Exists(FILE_NAME) Then
            Me.AsignarMensaje("No existe archivo: " + lcnombar, True)
            Return
        Else
            Me.AsignarMensaje("", True)
        End If

        Dim dsbanco As New DataSet

        dsbanco = LeerArchivo(FILE_NAME)

        If RadioButton1.Checked = True Then
            opcion1(dsbanco)
        ElseIf RadioButton2.Checked = True Then
            opcion2(dsbanco)
        End If

        
    End Sub
    Private Sub opcion1(ByVal dsbanco As DataSet)
        'Obtenemos el dataset de los movimientos registrados en el sistemas


        Dim ldfecini As Date = Date.Parse(Me.txtdesde.Text)
        Dim ldfecfin As Date = Date.Parse(Me.txthasta.Text)
        Dim lccodcta As String
        Dim etabtbco As New cTabtbco
        Dim lcpoliza As String = ""
        
        lcpoliza = "EG"
        lccodcta = etabtbco.CuentadeBancoContable(Me.cmbbanco.SelectedValue.Trim)


        Dim ecntamov As New cCntamov
        Dim ds As New DataSet
        ds = ecntamov.DataConciliar(ldfecini, ldfecfin, lcpoliza, lccodcta.Trim)




        Dim fila As DataRow
        Dim i As Integer = 0

        Dim lnvalor As Double = 0
        Dim lcnumdoc As String = ""
        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0
        Dim ldfecha As Date

        Dim lnvalortot As Double = 0
        For Each fila In ds.Tables(0).Rows
            lcnumdoc = ds.Tables(0).Rows(i)("cnumdoc")
            ldfecha = ds.Tables(0).Rows(i)("dfeccnt")
            lndebe = ds.Tables(0).Rows(i)("ndebe")
            lnhaber = ds.Tables(0).Rows(i)("nhaber")

            If Month(Date.Parse(txthasta.Text)) = ldfecha.Month Then
                ds.Tables(0).Rows(i)("cmes") = Str(ldfecha.Month)
            Else
                ds.Tables(0).Rows(i)("cmes") = "00"
            End If



            If lndebe > 0 Then
                lnvalor = lndebe
            Else
                lnvalor = lnhaber
            End If

            ds.Tables(0).Rows(i)("nvalor") = lnvalor
            'Busca en movimientos de banco
            Dim fila1 As DataRow
            Dim y As Integer = 0
            Dim ldfechab As Date
            Dim lnvalorb As Double = 0
            Dim lcnumdocb As String = ""

            Dim lncreditosb As Double = 0
            Dim lndebitosb As Double = 0

            For Each fila1 In dsbanco.Tables(0).Rows
                ldfechab = dsbanco.Tables(0).Rows(y)("fecha")
                lncreditosb = dsbanco.Tables(0).Rows(y)("creditos")
                lndebitosb = dsbanco.Tables(0).Rows(y)("debitos")
                lcnumdocb = dsbanco.Tables(0).Rows(y)("Docto")
                If lncreditosb > 0 Then
                    lnvalorb = lncreditosb
                Else
                    lnvalorb = lndebitosb
                End If

                'Lo encuentra si
                'And ldfecha = ldfechab
                If Math.Round(lnvalor, 2) = Math.Round(lnvalorb, 2) And _
                   lcnumdoc.Trim = lcnumdocb.Trim Then
                    ds.Tables(0).Rows(i)("cflag") = "X"
                    fila.Delete()
                    ds.Tables(0).GetChanges(DataRowState.Deleted)
                    Exit For
                End If

                y += 1
            Next

            i += 1
        Next
        ds.Tables(0).AcceptChanges()

        Imprimir(ds)
    End Sub
    Private Sub opcion2(ByVal dsbanco As DataSet)


        Dim clsppal As New class1
        Dim dsbank As New DataSet
        'creamos dataset
        Dim DR As DataRow
        Dim DC As DataColumn
        Dim DT As DataTable


        DT = clsppal.CreateDataConciliar()



        'Obtenemos el dataset de los movimientos registrados en el sistemas
        Dim ldfecini As Date = Date.Parse(Me.txtdesde.Text)
        Dim ldfecfin As Date = Date.Parse(Me.txthasta.Text)
        Dim lccodcta As String
        Dim etabtbco As New cTabtbco
        Dim lcpoliza As String = ""
        lcpoliza = "EG"
        lccodcta = etabtbco.CuentadeBancoContable(Me.cmbbanco.SelectedValue.Trim)


        Dim ecntamov As New cCntamov
        Dim ds As New DataSet
        ds = ecntamov.DataConciliar(ldfecini, ldfecfin, lcpoliza, lccodcta.Trim)


        Dim fila As DataRow
        Dim i As Integer = 0

        Dim lnvalor As Double = 0
        Dim lcnumdoc As String = ""
        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0
        Dim ldfecha As Date

        Dim lnvalortot As Double = 0

        Dim ldfechab As Date
        Dim lnvalorb As Double = 0
        Dim lcnumdocb As String = ""

        Dim lncreditosb As Double = 0
        Dim lndebitosb As Double = 0
        Dim lcconceptob As String = ""

        Dim lcflag As String = ""
        Dim lcmes As String = "00"
        For Each fila In dsbanco.Tables(0).Rows
            ldfechab = dsbanco.Tables(0).Rows(i)("fecha")
            lncreditosb = dsbanco.Tables(0).Rows(i)("creditos")
            lndebitosb = dsbanco.Tables(0).Rows(i)("debitos")
            lcnumdocb = dsbanco.Tables(0).Rows(i)("Docto")
            lcconceptob = dsbanco.Tables(0).Rows(i)("concepto")
            lcflag = ""
            If lncreditosb > 0 Then
                lnvalorb = lncreditosb
            Else
                lnvalorb = lndebitosb
            End If

            If Month(Date.Parse(txthasta.Text)) = ldfechab.Month Then
                lcmes = Str(ldfechab.Month)
            Else
                lcmes = "00"
            End If

            'Busca en movimientos de banco
            Dim fila1 As DataRow
            Dim y As Integer = 0

            For Each fila1 In ds.Tables(0).Rows
                lcnumdoc = ds.Tables(0).Rows(y)("cnumdoc")
                ldfecha = ds.Tables(0).Rows(y)("dfeccnt")
                lndebe = ds.Tables(0).Rows(y)("ndebe")
                lnhaber = ds.Tables(0).Rows(y)("nhaber")


                If lndebe > 0 Then
                    lnvalor = lndebe
                Else
                    lnvalor = lnhaber
                End If

                ds.Tables(0).Rows(y)("nvalor") = lnvalor


                'Lo encuentra si
                'And ldfecha = ldfechab
                If Math.Round(lnvalor, 2) = Math.Round(lnvalorb, 2) And _
                   lcnumdoc.Trim = lcnumdocb.Trim Then
                    'ds.Tables(0).Rows(i)("cflag") = "X"
                    lcflag = "X"
                    'fila.Delete()
                    'dsbanco.Tables(0).GetChanges(DataRowState.Deleted)
                    Exit For
                End If

                y += 1
            Next
            If lcflag.Trim = "" Then
                DR = DT.NewRow
                DR("dfeccnt") = ldfechab
                DR("cnumdoc") = lcnumdocb
                DR("nvalor") = lnvalorb
                DR("cconcepto") = lcconceptob
                DR("cmes") = lcmes
                DR("cflag") = ""
                DT.Rows.Add(DR)
            End If

            i += 1
        Next
        dsbank.Tables.Add(DT)

        'dsbanco.Tables(0).AcceptChanges()


        Imprimir(dsbank)

    End Sub

    Private Sub Imprimir(ByVal ds As DataSet)
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream
        Dim reportes As String
        Dim etabtbco As New cTabtbco

        Dim lcnombco As String = etabtbco.NombredeBanco(Me.cmbbanco.SelectedValue.Trim)
        Dim lccodcta As String = etabtbco.CuentadeBancoContable(Me.cmbbanco.SelectedValue.Trim)
        Dim lcctacte As String = etabtbco.CuentadeBanco(Me.cmbbanco.SelectedValue.Trim)
        Dim ldfecfin As Date = Date.Parse(Me.txthasta.Text)

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\Rptconciliar.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()

        crRpt.SetParameterValue("cnomofi", Session("gcnomins"))
        crRpt.SetParameterValue("cnombco", lcnombco)
        crRpt.SetParameterValue("ccuentactb", lccodcta)
        crRpt.SetParameterValue("cctacte", lcctacte)
        crRpt.SetParameterValue("dfecfin", ldfecfin)

        reportes = "Rptconciliar.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        'Response.End()

    End Sub
   

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not FileUpload1.HasFile = Nothing Then


            Dim filename As String = FileUpload1.FileName


            'save the file to the server
            FileUpload1.SaveAs("c:\txt\" & filename)
            lblStatus.Text = "Enviado Correctamente"

        End If
    End Sub
End Class


