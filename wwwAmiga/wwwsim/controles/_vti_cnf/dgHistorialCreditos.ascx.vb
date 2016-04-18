
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class dgHistorialCreditos
    Inherits System.Web.UI.UserControl

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtcuenta As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtnomcli As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents label_mensaje As System.Web.UI.WebControls.Label
    Protected WithEvents btnimprimir As System.Web.UI.HtmlControls.HtmlInputButton

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
    End Sub

#End Region

    Public Event SeleccionarCuenta(ByVal codcta As String)
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub AsignarMensaje(ByVal mensaje As String, Optional ByVal esError As Boolean = False)
        If esError Then
            label_mensaje.CssClass = "MensajeError"
        Else
            label_mensaje.CssClass = "MensajeInformativo"
        End If
        label_mensaje.Text = mensaje
    End Sub
    Private Sub imprime()
        Dim dsplan1 As New DataSet
        dsplan1 = viewstate("plan")
        Try
            If dsplan1 Is Nothing Then
                Me.AsignarMensaje("Error al obtener informacion del reporte", True)
                Return
            Else
                If dsplan1.Tables(0).Rows.Count = 0 Then
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

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\crplanpago.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsplan1.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()

    End Sub


    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        Dim lncuenta As Integer
        Dim mControl As New cCredppg
        Dim mLista As New listacredppg
        Dim mov As New creditos
        Dim mcreditos As New ccreditos
        Dim i As Integer
        Dim lnsaldo As Double
        Dim dsplan1 As New DataSet

        'carga dataset para imprimir
        dsplan1 = mControl.ObtenerDataSetPorID2(codcta)

        'carga lista
        mov.ccodcta = codcta
        mcreditos.Obtenercreditos(mov)
        mLista = mControl.ObtenerListaPorCuenta(codcta)
        mLista(0).nmoncuo = 0
        dsplan1.Tables(0).Rows(0)("nmoncuo") = 0
        dsplan1.Tables(0).Rows(0)("ncapita") = 0
        'obtiene el saldo de la lista
        lncuenta = mLista.Count - 1
        lnsaldo = mLista(0).ncapita
        Dim lncapita, lnintere, lngastos, lnsegdeu As Decimal
        For i = 0 To lncuenta
            If mLista(i).ctipope = "D" Then
                mLista(i).nsaldo = lnsaldo
                dsplan1.Tables(0).Rows(0)("nsaldo") = lnsaldo
            Else
                mLista(i).nsaldo = lnsaldo - mLista(i).ncapita
                dsplan1.Tables(0).Rows(i)("nsaldo") = lnsaldo - mLista(i).ncapita
                lnsaldo = lnsaldo - mLista(i).ncapita
                lncapita = mLista(i).ncapita
                lnintere = mLista(i).nintere
                lngastos = mLista(i).ngastos
                lnsegdeu = mLista(i).nsegdeu
                dsplan1.Tables(0).Rows(i)("nmoncuo") = lncapita + lnintere + lngastos + lnsegdeu
                mLista(i).nmoncuo = lncapita + lnintere + lngastos + lnsegdeu

            End If
        Next
        viewstate.Add("plan", dsplan1)
        Me.txtcuenta.Text = codcta
        Me.txtnomcli.Text = mov.cnomcli
        Me.BindGrid(mLista)
    End Sub

    Private Sub BindGrid(ByVal aLista As listacredppg)
        Me.DataGrid1.DataSource = aLista
        Me.DataGrid1.DataBind()
    End Sub

    Public Sub CargarDatosPorCliente(ByVal codcli As String)
        Dim mControl As New cCredppg
        Dim mLista As New listacredppg
        mLista = mControl.ObtenerListaPorCuenta(codcli)
        Me.BindGrid(mLista)
    End Sub

    Private Sub btnsalir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btncancela_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnimprimir_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.ServerClick
        imprime()
    End Sub
End Class
