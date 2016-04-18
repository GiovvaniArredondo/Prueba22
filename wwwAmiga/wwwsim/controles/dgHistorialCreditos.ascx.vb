
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web





Partial Class dgHistorialCreditos
    Inherits ucWBase

    Public Event SeleccionarCuenta(ByVal codcta As String)
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
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

        Dim ldfecdes As Date = Session("gdfecsis")
        Dim ldfecpri As Date = Session("gdfecsis")
        Dim lcmes As Integer = 0
        Dim lcnota As String = ""
        Dim lnsegdeu As Decimal = 0
        Dim lnmanejo As Decimal = 0



        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = Me.txtcuenta.Text.Trim
        ecreditos.Obtenercreditos(entidad3)


        '--------------------<<<<<>>>>>----------------
        Dim lcnomana As String = ""
        Dim lccodcta As String = ""
        Dim lcoficina As String = ""

        lcnomana = entidad3.cNomUsu
        lccodcta = entidad3.ccodcta
        lcoficina = entidad3.coficina

        Dim etabtofi As New cTabtofi
        Dim lcnomofi As String
        lcnomofi = etabtofi.NombreAgencia(lcoficina)

        Dim lcnrolin As String = ""
        Dim lcdeslin As String = ""
        lcnrolin = entidad3.cnrolin

        Dim entidadcretlin As New cretlin
        Dim ecretlin As New cCretlin

        entidadcretlin.cnrolin = lcnrolin
        ecretlin.ObtenerCretlin(entidadcretlin)

        lcdeslin = entidadcretlin.cdeslin


        '--------------------<<<<<>>>>>-----------------

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim fila As DataRow
        Dim nelem As Integer
        Dim lnSaldo As Double = 0
        Dim lctipope As String
        Dim lnsalint As Double = 0
        For Each fila In dsplan1.Tables(0).Rows
            If dsplan1.Tables(0).Rows(nelem)("ctipope") = "D" Then
                dsplan1.Tables(0).Rows(nelem)("ncapita") = 0
                dsplan1.Tables(0).Rows(nelem)("nintere") = 0
                ldfecdes = dsplan1.Tables(0).Rows(nelem)("dfecven")
            Else

                If dsplan1.Tables(0).Rows(nelem)("cnrocuo") = "001" Then
                    ldfecpri = dsplan1.Tables(0).Rows(nelem)("dfecven")
                    lnsegdeu = dsplan1.Tables(0).Rows(nelem)("nsegdeu")
                    lnmanejo = dsplan1.Tables(0).Rows(nelem)("ngastos")
                End If

            End If
            dsplan1.Tables(0).Rows(nelem)("saldo") = dsplan1.Tables(0).Rows(nelem)("nsaldo")
            nelem = nelem + 1
        Next
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim lntotal As Decimal = 0

        lcmes = DateDiff(DateInterval.Month, ldfecdes, ldfecpri)

        lcmes = lcmes - 1
        If lcmes < 0 Then
            lcmes = 0
        End If
        lntotal = Math.Round((lnsegdeu + lnmanejo) * lcmes, 2)
        If lcmes > 0 Then
            'lcnota = "Para el pago de la primera cuota, traer adicional al valor de esta " & lntotal.ToString.Trim & " en concepto de Seguro de Deuda y Manejo de Cuenta  "
            lcnota = ""
        End If


        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\plandepagos.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Me.AsignarMensaje("Error: Al cargar el archivo. " + ex.Message.ToString, True)
            Return
        End Try
        Dim reportes As String
        reportes = "Planpagos.pdf"

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsplan1.Tables(0))
        crRpt.Refresh()
        crRpt.SetParameterValue("pcnomcli", Me.txtnomcli.Text.Trim)
        crRpt.SetParameterValue("pcnota", lcnota)

        crRpt.SetParameterValue("cnomana", ("Asesor: " & lcnomana))
        crRpt.SetParameterValue("ccodcta", ("Crédito Nº: " & lccodcta))
        crRpt.SetParameterValue("cdeslin", ("Linea: " & lcdeslin))
        crRpt.SetParameterValue("cnomofi", ("Oficina: " & lcnomofi))

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStreamIA.ToArray())
        'Response.End()
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
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
        Dim clsprincipal As New class1

        Dim ecremcre As New cCremcre
        Dim lntasa As Double = 0
        lntasa = ecremcre.TasaCredito(codcta)

        'carga dataset para imprimir
        dsplan1 = mControl.ObtenerDataSetPorID2(codcta)

        'carga lista
        mov.ccodcta = codcta
        mcreditos.Obtenercreditos(mov)

        If Not (mov.cestado = "F" Or mov.cestado = "G") Then
            btnimprimir.Disabled = True
            Exit Sub
        End If

        btnimprimir.Disabled = False

        Dim pniva As Double
        Dim lliva As Boolean
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin

        entidadCretlin.cnrolin = mov.cnrolin

        eCretlin.ObtenerCretlinPorllave(entidadCretlin)

        pniva = Session("gnIVA")
        lliva = entidadCretlin.lliva


        'Valida si la Linea de Credito Incluye Iva
        If lliva Then
            For Each Fila In dsplan1.Tables(0).Rows
                If Fila("cTipOpe") = "N" Then
                    Fila("nGastos") = Fila("nintere") - (Fila("nintere") / pniva)
                    Fila("nGastos") = Math.Round(Fila("nGastos"), 2)
                    Fila("nintere") = Fila("nintere") - Fila("nGastos")
                Else
                    Fila("nintere") = 0
                End If
            Next
        End If

        mLista = mControl.ObtenerListaPorCuenta(codcta)
        mLista(0).nmoncuo = 0

        '----------------------------------------------
        clsprincipal.cNrolin = mov.cnrolin
        clsprincipal.nMonDes = mov.ncapdes
        clsprincipal.cCodFor = mov.ctipper
        clsprincipal.nPerDia = mov.ndiasug
        clsprincipal.gnperbas = Session("gnperbas")
        clsprincipal.pnComtra = Session("gnComTra")

        If mov.dfecvig >= #7/11/2008# Then
            clsprincipal.pnSegVm = Session("gnSegVm1")
        Else
            clsprincipal.pnSegVm = Session("gnSegVm")
        End If

        clsprincipal.OtrosGastos()




        '----------------------------------------------
        Dim lncapita, lnintere, lngastos, lnsegdeu As Decimal
        'lnsegdeu = utilNumeros.Redondear(clsprincipal.pnSegDeu, 2)
        'lngastos = utilNumeros.Redondear(clsprincipal.pnComPer, 2)

        dsplan1.Tables(0).Rows(0)("nmoncuo") = 0
        dsplan1.Tables(0).Rows(0)("ncapita") = 0
        'obtiene el saldo de la lista
        lncuenta = mLista.Count - 1
        lnsaldo = mLista(0).ncapita

        Dim lntasaiva As Double = Session("gnIVA")
        Dim lniva As Double = 0

        'For i = 0 To lncuenta
        '    If mLista(i).ctipope = "D" Then
        '        mLista(i).nsaldo = lnsaldo
        '        dsplan1.Tables(0).Rows(0)("nsaldo") = lnsaldo
        '    Else

        '        mLista(i).nsaldo = lnsaldo - mLista(i).ncapita
        '        dsplan1.Tables(0).Rows(i)("nsaldo") = lnsaldo - mLista(i).ncapita
        '        lnsaldo = lnsaldo - mLista(i).ncapita
        '        lncapita = mLista(i).ncapita

        '        lnintere = mLista(i).nintere
        '        lngastos = mLista(i).ngastos
        '        lnsegdeu = mLista(i).nsegdeu

        '        lniva = Math.Round(lngastos * lntasaiva / 100, 2)
        '        dsplan1.Tables(0).Rows(i)("ntasint") = Math.Round(lntasa / 12 / 100, 2)
        '        dsplan1.Tables(0).Rows(i)("nmoncuo") = lncapita + lnintere + lngastos + lnsegdeu + lniva
        '        dsplan1.Tables(0).Rows(i)("nsegdeu") = lnsegdeu
        '        dsplan1.Tables(0).Rows(i)("ngastos") = (lngastos + lniva) 'comision por manejo
        '        mLista(i).ngastos = (lngastos + lniva)
        '        mLista(i).nmoncuo = lncapita + lnintere + lngastos + lnsegdeu + lniva

        '    End If
        'Next
        viewstate.Add("plan", dsplan1)
        Me.txtcuenta.Text = codcta
        Me.txtnomcli.Text = mov.cnomcli
        'Me.BindGrid(mLista)
        Me.datagrid2.DataSource = dsplan1.Tables(0)
        Me.datagrid2.DataBind()
    End Sub

    Private Sub BindGrid(ByVal aLista As listacredppg)
        Me.datagrid2.DataSource = aLista
        Me.datagrid2.DataBind()
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


