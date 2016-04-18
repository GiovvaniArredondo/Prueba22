Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.IO
Imports Ionic.Zip
Imports System.Net.Mail


Public Class uccamfec
    Inherits System.Web.UI.UserControl

#Region "Privadas"
    Private codigoJs As String
    Private cClsAdP As New SIM.BL.ClsAdPart
    Private clsdes As New clsDesembolsa
    Private funciones As New crefunc
    Private clsppal As New class1
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargar()
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "IN", 31)
        End If
    End Sub

    Sub cargar()
        Dim FechaSys As Date = Today()
        Dim ldfecha As Date
        Dim ldfecvig As Date
        Dim lnfecha As Integer
        Dim lndia As String
        Dim lnmes As String
        Dim lnano As String
        Dim llObvSab As Integer
        Dim llObvDom As Integer
        Dim etabtfer As New cTabtfer
        Dim i As Integer = 0

        FechaSys = Session("gdFecSis")
        ldfecha = Session("gdfecsis")
        Me.txtfecant.Text = Left(ldfecha.ToString, 10)
        FechaSys = ldfecha.AddDays(1)

        Dim ecremcre As New cCremcre
        llObvSab = IIf(ecremcre.Sabado() = False, 0, 1)
        llObvDom = IIf(ecremcre.Domingo() = False, 0, 1)

        Dim lnflag As Integer = 0
        If Weekday(FechaSys) = 7 And llObvSab = 1 Then
            FechaSys = ldfecha.AddDays(2)
            ldfecha = FechaSys
            lnflag = 1
        End If

        If Weekday(FechaSys) = 1 And llObvDom = 1 Then
            If lnflag = 1 Then
                FechaSys = ldfecha.AddDays(1)
            Else
                FechaSys = ldfecha.AddDays(2)
            End If
        End If

        ldfecvig = FechaSys 'Date.Parse(lndia & "/" & lnmes & "/" & lnano)
        For k = 1 To 365
            i = etabtfer.ValidaFeriado(ldfecvig)
            If i = 0 Then
                Exit For
            Else
                ldfecha = ldfecvig
                ldfecvig = ldfecha.AddDays(1)
            End If
        Next




        Me.txtfecvig.Text = Left(ldfecvig.Date.ToString, 10)
    End Sub


    Public Sub CalculoProvision(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ndias As Integer, ByVal ds As DataSet)
        Dim clsppal As New class1
        Dim M1 As New ccreditos
        M1.pnporseg = Session("gnporseg")
        M1.pnpordan = Session("gnsegdan")
        M1.pnporres = Session("gnporres")
        M1.pnportal = Session("gntalona")
        M1.pncosind = Session("gncosind")
        M1.pnopcion = 0
        'Dim mclass As New creditos
        M1.pncomtra = Session("gncomtra")
        M1.pnperbas = Session("gnperbas")
        M1.pnsegvm = Session("gnSegVm")
        M1.pnsegvm1 = Session("gnSegVm1")

        Dim ldfecant As Date = Date.Parse(txtfecant.Text)
        Dim ecremcre As New cCremcre
        'Dim ds As New DataSet
        M1.cartera = "*"
        M1.tipo = "*"

        'ds = M1.CarteraCalculadaaProvisionar(dfecha1, dfecha2, "*", "*", "*", "*", False, "*", "0", "P")
        clsppal.gnperbas = Session("gnperbas")

        '-------------Se ajustara las cartera - contabilidad -----------------

        clsppal.AjusteContableProvision(ds, ldfecant, Session("gccodusu"))
        clsppal.AjusteContableProvisionCastigada(ds, ldfecant, Session("gccodusu"))

        '-----------------------------------------------------------------------------
        clsppal.ProvisionDiaria(dfecha1, dfecha2, ds, ndias)


    End Sub
    Public Sub AbreMes()
        Dim ecremcre As New cCremcre
        Dim i As Integer
        i = ecremcre.RegistraProvisionMensual1(Session("gdfecsis"))
        i = ecremcre.InicializaMes()

    End Sub
    Public Sub CierreMes()

        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak

        Dim ldfecha As Date = Date.Parse(Me.txtfecvig.Text)
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim etabttab As New cTabttab
        Dim dsfondos As New DataSet
        Dim dsmetodo As New DataSet
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim cplanti As String = ""
        dsfondos = etabttab.ObtenerDataSetPorID("033", "1")
        Dim dsoficina As New DataSet
        Dim lccodofi As String = ""
        dsoficina = ecremcre.OficinaAsientos()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lccodigo As String
        Dim clasefunc As New crefunc
        For Each fila00 As DataRow In dsoficina.Tables(0).Rows
            lccodofi = Trim(fila00("ccodofi"))

            For Each fila In dsfondos.Tables(0).Rows
                lccodigo = Trim(fila("ccodigo"))

                dsmetodo = etabttab.ObtenerDataSetPorID("046", "1")


                'Graba Partida contable
                cClsAdP._dfecmod = Session("gdfecsis")
                cClsAdP._ccodusu = Session("gcCodusu")
                cClsAdP._ccodofi = lccodofi
                cClsAdP._ffondos = clsdes.ConvertidorFondos(lccodigo.Trim)
                cClsAdP._cconcepto = "PARTIDA DIARIA DE PROVISION DE INTERESES DIA: " & Left(ldfecha.ToString, 10)
                cClsAdP._dfeccnt = ldfecha
                cClsAdP._cpoliza = "PI"
                cClsAdP._nCuenta = 1
                cClsAdP._cnumdoc = "F"
                cClsAdP._llbandera = True
                cClsAdP._ccodpres = ""

                Dim fila1 As DataRow
                Dim y As Integer = 0
                Dim lcmetodo As String = ""
                Dim lccc As String = "01"
                For Each fila1 In dsmetodo.Tables(0).Rows
                    lcmetodo = fila1("cCodigo")
                    lccc = clasefunc.CodigoCondicion(lcmetodo)

                    Dim oki As String = ""
                    Dim lnprovis As Double = 0
                    Dim lnprovismor As Double = 0
                    lnprovis = ecremcre.RecuperarProvisionAcumulada(lccodigo.Trim, lcmetodo.Trim, lccodofi)
                    lnprovismor = ecremcre.RecuperarProvisionAcumuladaMora(lccodigo.Trim, lcmetodo.Trim, lccodofi)
                    If lnprovis > 0 Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Cargo
                        Dim lcmascara As String = "CINNN"
                        If lcmascara <> Nothing Then
                            entidadtabtmak.ccodigo = lcmascara
                            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                            If busquedaplantilla = 0 Then
                                lcctactb = "*"
                            Else
                                cplanti = entidadtabtmak.cplanti.Trim
                                lcctactb = cplanti.Replace("CC", lccc)
                            End If
                        End If

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = lnprovis
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = "1"


                        oki = cClsAdP.AdPartida()

                        If oki = "0" Then 'Ocurrio un Error
                            Exit Sub
                        End If
                        cClsAdP._nCuenta += 1

                        'Abono
                        lcmascara = "CINFN"
                        If lcmascara <> Nothing Then
                            entidadtabtmak.ccodigo = lcmascara
                            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                            If busquedaplantilla = 0 Then
                                lcctactb = "*"
                            Else
                                cplanti = entidadtabtmak.cplanti.Trim
                                lcctactb = cplanti.Replace("CC", lccc)
                            End If
                        End If

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = lnprovis
                        cClsAdP._cclase = "6"


                        oki = cClsAdP.AdPartida()

                        If oki = "0" Then 'Ocurrio un Error
                            Exit Sub
                        End If
                        cClsAdP._nCuenta += 1
                        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                    End If
                    '------Provision de intereses moratorios
                    If lnprovismor > 0 Then
                        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        'Cargo
                        Dim lcmascara As String = "CMONN"
                        If lcmascara <> Nothing Then
                            entidadtabtmak.ccodigo = lcmascara
                            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                            If busquedaplantilla = 0 Then
                                lcctactb = "*"
                            Else
                                cplanti = entidadtabtmak.cplanti.Trim
                                lcctactb = cplanti.Replace("CC", lccc)
                            End If
                        End If

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = lnprovismor
                        cClsAdP._nhaber = 0
                        cClsAdP._cclase = "1"


                        oki = cClsAdP.AdPartida()

                        If oki = "0" Then 'Ocurrio un Error
                            Exit Sub
                        End If
                        cClsAdP._nCuenta += 1

                        'Abono
                        lcmascara = "CMOFN"
                        If lcmascara <> Nothing Then
                            entidadtabtmak.ccodigo = lcmascara
                            busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                            If busquedaplantilla = 0 Then
                                lcctactb = "*"
                            Else
                                cplanti = entidadtabtmak.cplanti.Trim
                                lcctactb = cplanti.Replace("CC", lccc)
                            End If
                        End If

                        cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                        cClsAdP._ccodcta = lcctactb
                        cClsAdP._ndebe = 0
                        cClsAdP._nhaber = lnprovismor
                        cClsAdP._cclase = "6"


                        oki = cClsAdP.AdPartida()

                        If oki = "0" Then 'Ocurrio un Error
                            Exit Sub
                        End If
                        cClsAdP._nCuenta += 1
                        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                    End If


                    y += 1
                Next




                i += 1
            Next

        Next

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        'graba datos
        Dim mtabtvar As New cTabtvar
        Dim etabtvar As New tabtvar
        Dim lnRetorno As Integer = 0

        Try


            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "Gr", 31)
            'Verifica cambio de mes
            Dim ldfecant As Date = Date.Parse(Me.txtfecant.Text)
            Dim ldfecvig As Date = Date.Parse(Me.txtfecvig.Text)
            Dim ecremcre As New cCremcre

            Dim lcdia, lcmes, lcano, lcnombre As String
            lcdia = IIf(Len(Day(ldfecant).ToString.Trim) = 1, ("0" & Day(ldfecant).ToString.Trim), Day(ldfecant).ToString.Trim)
            lcmes = IIf(Len(Month(ldfecant).ToString.Trim) = 1, ("0" & Month(ldfecant).ToString.Trim), Month(ldfecant).ToString.Trim)
            lcano = Year(ldfecant).ToString.Trim
            lcnombre = lcdia & lcmes & lcano


            'Dim PathZip As String = "C:\txt\cierre\"
            'Dim objZip As New ZipFile
            'Dim archivoZip As String = "C:\txt\mine" & lcnombre & ".zip"


            '---------------------------------------------------
            'verifica que las cajas esten cerradas en todas las agencias

            'Dim valor As Integer
            'valor = ValidaCajasCerradasTodasOficinas()
            'If valor <> 0 Then
            '    Response.Write("<script language='javascript'>alert('agencias no han cerrado cajas, verifique')</script>")
            '    Return
            'End If

            ''elimina los archivos de la carpeta
            'Try
            '    For Each archivo As String In Directory.GetFiles(PathZip)
            '        File.Delete(archivo)
            '    Next
            'Catch ex As Exception

            'End Try


            ''-------------------------Dias a provisionar
            Dim lndias As Integer = 0
            lndias = DateDiff(DateInterval.Day, ldfecant, ldfecvig)




            'Actualiza Bloqueo
            etabtvar.ccodapl = "CRE"
            etabtvar.cnomvar = "gcEstado"
            mtabtvar.ObtenerTabtvar(etabtvar)
            etabtvar.cconvar = "0"
            etabtvar.lcarini = True
            etabtvar.cflag = " "
            mtabtvar.ActualizarTabtvar(etabtvar)


            Dim ldfecha As String
            ldfecha = Me.txtfecvig.Text
            Me.ImageButton1.Enabled = False
            'antes de cambiar la fecha llamara una rutina para
            'actualizar los numeros de partidas lcnumcom = Mid(gccodofi, 2, 2) & "999997" en la cntamov
            'Try

            Dim clscambiapart As New clspagos
            clscambiapart.gccodofi = Session("GCCODOFI")
            clscambiapart.crea_partidas_pagos(ldfecant)

            'Actualiza Calificacion
            'Dim clsppal As New class1
            'Dim entidadcremcre As New cremcre
            'Dim ecremcre As New cCremcre



            etabtvar.ccodapl = "CRE"
            etabtvar.cnomvar = "GDFECSIS"
            mtabtvar.ObtenerTabtvar(etabtvar)
            etabtvar.cconvar = ldfecha
            etabtvar.lcarini = True
            etabtvar.cflag = " "
            mtabtvar.ActualizarTabtvar(etabtvar)

            Dim etabtofi As New cTabtofi
            Dim i As Integer = 0
            Try
                i = etabtofi.ReseteaValidador()
            Catch ex As Exception
            End Try


            '
            ' ReclasificacionCartera(Session("gdfecsis"), Session("gdfecsis"), lndias)
            'ReclasificacionCartera(ldfecvig, ldfecvig, lndias, ldfecant)

            ReclasificacionCartera_Mexico(ldfecvig, ldfecvig, lndias, ldfecant)

            'CalculoProvision(Session("gdfecsis"), Session("gdfecsis"), lndias)

            'Comentariado no se usa Mexico
            'Estos procesos se haran diarios
            'Me.CierreMes()
            'Me.AbreMes()

            If Month(ldfecant) <> Month(ldfecvig) Then
                'Ejecuta Partida Contable y Genera Reporte
                '    CalculoProvision(ldfecha, ldfecha)
                '    Estimacion()
                Backup(ldfecant)
            End If


            'Realiza Historico Diario
            lnRetorno = mtabtvar.Genera_Tabla_Historica(Date.Parse(Me.txtfecant.Text))

            If lnRetorno = 1 Then
                Response.Write("<script language='javascript'>alert('Ocurrio un Error en la generación de Archivos, Advertencia SIM.NET')</script>")

            End If


            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "OUT", 31)
            'Response.Write("<script language='javascript'>alert('Cierre Completado')</script>")



            ''BORRA EL ARCHIVO ZIP SI EXISTE
            'Try
            '    If File.Exists(archivoZip) Then
            '        File.Delete(archivoZip)
            '    End If
            'Catch ex As Exception

            'End Try
            ''GENERA EL ARCHIVO ZIP PARA ENVIARLO LUEGO POR EMAIL
            'objZip.AddDirectory(PathZip)
            'objZip.Save(archivoZip)

            'ENVIA POR CORREO ELECTRONICO EL ARCHIVO
            'EnviarEmail(archivoZip, ldfecant)

        Catch ex As Exception
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error en el cierre Diario, " & _
                     "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End Try

        'Actualiza Bloqueo
        etabtvar.ccodapl = "CRE"
        etabtvar.cnomvar = "gcEstado"
        mtabtvar.ObtenerTabtvar(etabtvar)
        etabtvar.cconvar = "1"
        etabtvar.lcarini = True
        etabtvar.cflag = " "
        mtabtvar.ActualizarTabtvar(etabtvar)


        CerrarSesion()

        'Me.ImprimirReclasificacion()
    End Sub
    Private Sub CerrarSesion()
        'Auditoria'
        Dim ip As Net.Dns

        Dim nombre_Host As String = ip.GetHostName

        Dim este_Host As Net.IPHostEntry = ip.GetHostByName(nombre_Host)

        Dim direccion_Ip As String = este_Host.AddressList(0).ToString

        Dim entidadusuarios As New usuarios
        Dim milogin As New cLogin
        Dim eusuarios As New cusuarios


        entidadusuarios.cip = direccion_Ip
        entidadusuarios.dfecha = Today
        entidadusuarios.chora = TimeOfDay.ToString.Substring(11, 12)
        entidadusuarios.idUsuario = milogin.IdUsuario(Session("gcCodusu"))
        entidadusuarios.gdfecsis = Session("gdfecsis")
        entidadusuarios.ctrs = "OUT"
        Try
            eusuarios.RegistraAuditoria(entidadusuarios)
        Catch ex As Exception

        End Try


        Session.Abandon()
        Response.Redirect("wflogin.aspx")

    End Sub

    Public Sub ReclasificacionCartera(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ndias As Integer, ByVal dfecant As Date)
        Dim clsppal As New class1
        Dim M1 As New ccreditos
        M1.pnporseg = Session("gnporseg")
        M1.pnpordan = Session("gnsegdan")
        M1.pnporres = Session("gnporres")
        M1.pnportal = Session("gntalona")
        M1.pncosind = Session("gncosind")
        M1.pnopcion = 0
        'Dim mclass As New creditos
        M1.pncomtra = Session("gncomtra")
        M1.pnperbas = Session("gnperbas")
        M1.pnsegvm = Session("gnSegVm")
        M1.pnsegvm1 = Session("gnSegVm1")


        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        M1.cartera = "*"
        M1.tipo = "*"
        ds = M1.CarteraCalculadaaProvisionar(dfecha1, dfecha2, "*", "*", "*", "*", False, "*", "0", "R", dfecant)

        Dim i As Integer = 0
        i = clsppal.ReclasificacionDiaria(dfecha1, dfecha2, ds)

        Me.Reclasificacion()
        Me.GeneraArchivoMINEAnt(ds)
        Me.GeneraArchivoMINE(ds)


        CalculoProvision(Session("gdfecsis"), Session("gdfecsis"), ndias, ds)

    End Sub


    Public Sub ReclasificacionCartera_Mexico(ByVal dfecha1 As Date, ByVal dfecha2 As Date, ByVal ndias As Integer, ByVal dfecant As Date)
        Dim clsppal As New class1
        Dim M1 As New ccreditos
        M1.pnporseg = Session("gnporseg")
        M1.pnpordan = Session("gnsegdan")
        M1.pnporres = Session("gnporres")
        M1.pnportal = Session("gntalona")
        M1.pncosind = Session("gncosind")
        M1.pnopcion = 0
        'Dim mclass As New creditos
        M1.pncomtra = Session("gncomtra")
        M1.pnperbas = Session("gnperbas")
        M1.pnsegvm = Session("gnSegVm")
        M1.pnsegvm1 = Session("gnSegVm1")


        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        M1.cartera = "*"
        M1.tipo = "*"
        ds = M1.CarteraCalculadaaProvisionar(dfecha1, dfecha2, "*", "*", "*", "*", False, "*", "0", "R", dfecant)

        Dim i As Integer = 0
        i = clsppal.ReclasificacionDiaria(dfecha1, dfecha2, ds)

        'Me.Reclasificacion()
        'Me.GeneraArchivoMINEAnt(ds)
        'Me.GeneraArchivoMINE(ds)


        'CalculoProvision(Session("gdfecsis"), Session("gdfecsis"), ndias, ds)

    End Sub
    Private Sub ImprimirReclasificacion()
        Dim ecremcre As New cCremcre
        Dim ds As New DataSet
        Dim ldfecha As Date = Date.Parse(Me.txtfecant.Text)
        ds = ecremcre.RecuperaCreditosReclasificados(Session("gccodofi"))

        'Imprime
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte

            crRpt.Load(Server.MapPath("reportes") + "\crReclasifica.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRpt.SetDataSource(ds.Tables(0))
        crRpt.Refresh()


        crRpt.SetParameterValue("dfecha", ldfecha)


        Dim reportes As String
        reportes = "crReclasifica.pdf"

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

    End Sub


    Public Sub Reclasificacion()

        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak

        Dim oki As String = "0"
        Dim ldfecha As Date = Date.Parse(Me.txtfecvig.Text)
        Dim ds As New DataSet
        Dim ecremcre As New cCremcre
        Dim etabttab As New cTabttab
        Dim dsfondos As New DataSet
        Dim dsmetodo As New DataSet
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim cplanti As String = ""
        Dim lccodlin As String = ""
        Dim lccodcta As String = ""

        Dim dsoficina As New DataSet
        Dim fila00 As DataRow
        Dim i00 As Integer = 0
        Dim lccodofi As String = ""
        dsoficina = ecremcre.OficinaAsientos()

        For Each fila00 In dsoficina.Tables(0).Rows
            lccodofi = Trim(dsoficina.Tables(0).Rows(i00)("ccodofi"))

            'Graba Partida contable
            cClsAdP._dfecmod = Session("gdfecsis")
            cClsAdP._ccodusu = Session("gcCodusu")
            cClsAdP._ccodofi = lccodofi 'Session("gcCodofi")
            cClsAdP._cconcepto = "PARTIDA DIARIA DE RECLASIFICACION "
            cClsAdP._dfeccnt = ldfecha
            cClsAdP._cpoliza = " "
            cClsAdP._nCuenta = 1
            cClsAdP._cnumdoc = "R"
            cClsAdP._llbandera = True
            cClsAdP._ccodpres = ""

            dsfondos = etabttab.ObtenerDataSetPorID("033", "1")

            Dim fila As DataRow
            Dim i As Integer = 0
            Dim lccodigo As String
            For Each fila In dsfondos.Tables(0).Rows
                lccodigo = Trim(dsfondos.Tables(0).Rows(i)("ccodigo"))
                dsmetodo = etabttab.ObtenerDataSetPorID("125", "1")
                cClsAdP._ffondos = clsdes.ConvertidorFondos(lccodigo.Trim)

                Dim fila1 As DataRow
                Dim y As Integer = 0
                Dim lcmetodo As String = ""
                For Each fila1 In dsmetodo.Tables(0).Rows
                    lcmetodo = dsmetodo.Tables(0).Rows(y)("cCodigo")

                    Dim fila2 As DataRow
                    Dim z As Integer = 0
                    Dim lndebe As Double = 0
                    Dim lnhaber As Double = 0

                    Dim lndebet As Double = 0
                    Dim lnhabert As Double = 0

                    Dim lccuentad As String = ""
                    Dim lccuentah As String = ""
                    Dim dsasiento As New DataSet
                    dsasiento = ecremcre.RecuperarAsiento(lccodigo, lcmetodo, lccodofi)

                    For Each fila2 In dsasiento.Tables(0).Rows
                        lndebe = fila2("ndebe")
                        lnhaber = fila2("nhaber")
                        lcctactb = fila2("cCodcta")
                        If lndebe > 0 Then
                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = lcctactb
                            cClsAdP._ndebe = lndebe
                            cClsAdP._nhaber = 0
                            cClsAdP._cclase = Left(lcctactb, 1)
                            cClsAdP._cpoliza = "AR"
                            oki = cClsAdP.AdPartida()


                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            cClsAdP._nCuenta += 1
                            'Actualiza partida generada en auxiliar de asientos
                            ecremcre.Actualiza_Numero_Partida(lccodigo, lcmetodo, lccodofi, oki)
                        End If
                        If lnhaber > 0 Then

                            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                            cClsAdP._ccodcta = lcctactb
                            cClsAdP._ndebe = 0
                            cClsAdP._nhaber = lnhaber
                            cClsAdP._cclase = Left(lcctactb, 1)
                            cClsAdP._cpoliza = "AR"

                            oki = cClsAdP.AdPartida()

                            If oki = "0" Then 'Ocurrio un Error
                                Exit Sub
                            End If
                            cClsAdP._nCuenta += 1
                            'Actualiza partida generada en auxiliar de asientos
                            ecremcre.Actualiza_Numero_Partida(lccodigo, lcmetodo, lccodofi, oki)

                        End If
                        z += 1
                    Next

                    y += 1
                Next
                i += 1
            Next
            i00 += 1
        Next

    End Sub
    Private Sub Backup(ByVal dfecha As Date)
        Dim lcfecha As String
        lcfecha = dfecha.ToString
        Dim lcbase As String
        lcbase = "BK" + lcfecha.Substring(3, 2) + lcfecha.Substring(6, 4)

        Dim ecremcre As New cCremcre
        ecremcre.CrearBasedeDatos(lcbase)
        ecremcre.InsertaFechaBackup(dfecha, lcbase)

    End Sub


    Private Sub Estimacion()
        'Genera insumo de estimacion

        Dim ldfecant As Date = Date.Parse(Me.txtfecant.Text)
        Dim clsppal As New class1
        clsppal.pcCodUsu = Session("gccodusu")
        clsppal.RotorActualizador(ldfecant, ldfecant)

        clsppal.pcCodUsu = Session("gccodusu")
        clsppal.GeneraEstimacionContable(ldfecant)




    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        Dim ecreditos As New ccreditos
        ds = ecreditos.Carteratotal
        Dim clsppal As New class1
        Dim lctipgar As String
        For Each fila As DataRow In ds.Tables(0).Rows
            lctipgar = clsppal.ObtenerCodigoGarantia(fila("ccodcta"))
            'Actualiza campo ctipgar
            ecreditos.ActualizaTipoGarantia(fila("ccodcta"), lctipgar)
        Next
    End Sub
    Private Sub GeneraArchivoMINE(ByVal ds As DataSet)
        'Variables para abrir el archivo en modo de escritura

        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            Dim lcnombre As String
            Dim lcdia1 As String
            Dim lcdia As String
            Dim clsppal As New class1

            Dim lcmes1 As String
            Dim lcmes As String

            Dim lcaño As String

            lcdia1 = Date.Parse(Me.txtfecvig.Text).Day.ToString
            lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

            lcmes1 = Date.Parse(Me.txtfecvig.Text).Month.ToString
            lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

            lcaño = Date.Parse(Me.txtfecvig.Text).Year.ToString.Trim

            lcnombre = "MINE_" & lcdia & lcmes & lcaño & "I.txt"


            Dim FilePath As String = "c:/txt/cierre/" & lcnombre

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)

            'Se traen los datos que necesitamos para el archivo
            'TraerDatosArchivo retorna un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto


            Dim dr As DataRow

            Dim pccadena As String
            Dim pNo, pRegion, pAgencia, pCredito, pCliente, pNombre, pCedula, Pdireccion As String
            Dim pActividad, pMonto, pSaldo, pCuota, pCapital_Mora, pIntereses_Corrientes, pIntereses_Moratorios As String
            Dim pCuotas_Mora, pGarantia, pTasa_Interes, pFecha_Otorgado, pFecha_Vence, pCiclo, pDias_Atraso, pMenosde1 As String
            Dim pMenosde2, pMenosde3, pMenosde4, pMenosde6, pMayor180 As String
            Dim pSexo, pMetodologia, pPrograma, pProducto, pSector, pEstado, pTipo_Cartera As String
            Dim pDestino, pMunicipio, pFecha_Nac, pDepartamento, pFondos, pAsesor_Otorgo, pAsesor_Administra As String
            Dim pPago_Capital, pPago_Interes, pPago_Mora, pTipoInteres, ptasmor, ptipgar As String
            For Each dr In ds.Tables(0).Rows
                'Obtenemos los datos del dataset
                pNo = dr("No")
                pRegion = dr("region")
                pAgencia = dr("agencia")
                pCredito = dr("credito")
                pCredito = pCredito.Replace("'", "")
                pCliente = dr("cliente")
                pCliente = pCliente.Replace("'", "")
                pNombre = dr("Nombre")
                pCedula = dr("Cedula")
                Pdireccion = dr("Direccion")
                pActividad = dr("actividad")
                pMonto = CStr(Math.Round(dr("monto"), 2))
                pSaldo = CStr(Math.Round(dr("Saldo"), 2))
                pCuota = CStr(Math.Round(dr("cuota"), 2))
                pCapital_Mora = CStr(Math.Round(dr("capital_mora"), 2))
                pIntereses_Corrientes = CStr(Math.Round(dr("Intereses_Corrientes"), 2))
                pIntereses_Moratorios = CStr(Math.Round(dr("Intereses_Moratorios"), 2))
                pCuotas_Mora = CStr(Math.Round(dr("cuotas_mora"), 2))
                pgarantia = dr("garantia")
                pTasa_Interes = CStr(Math.Round(dr("tasa_interes"), 2))
                pFecha_Otorgado = Left(dr("fecha_otorgado").ToString, 10)
                pFecha_Vence = Left(dr("fecha_vence").ToString, 10)
                pCiclo = CStr(dr("ciclo"))
                pDias_Atraso = CStr(dr("dias_atraso"))
                pMenosde1 = CStr(Math.Round(dr("menosde1"), 2))
                pMenosde2 = CStr(Math.Round(dr("menosde2"), 2))
                pMenosde3 = CStr(Math.Round(dr("menosde3"), 2))
                pMenosde4 = CStr(Math.Round(dr("menosde4"), 2))
                pMenosde6 = CStr(Math.Round(dr("menosde6"), 2))
                pMayor180 = CStr(Math.Round(dr("mayor180"), 2))
                pSexo = dr("sexo")
                pMetodologia = dr("metodologia")
                pPrograma = dr("programa")
                pProducto = dr("producto")
                pSector = dr("sector")
                pEstado = dr("estado")
                pTipo_Cartera = dr("tipo_cartera")
                pDestino = dr("destino")
                pMunicipio = dr("municipio")
                pFecha_Nac = Left(dr("fecha_nac").ToString, 10)
                pDepartamento = dr("departamento")
                pFondos = dr("fondos")
                pAsesor_Otorgo = dr("asesor_otorgo")
                pAsesor_Administra = dr("asesor_administra")

                pPago_Capital = CStr(Math.Round(dr("pago_capital"), 2))
                pPago_Interes = CStr(Math.Round(dr("pago_interes"), 2))
                pPago_Mora = CStr(Math.Round(dr("pago_mora"), 2))
                pTipoInteres = dr("TipoInteres")
                ptasmor = CStr(Math.Round(dr("ntasmor"), 2))
                ptipgar = dr("ctipgar")

                pccadena = pNo.Trim & "|" & pRegion.Trim & "|" & pAgencia & "|" & pCredito.Trim & "|" & pCliente.Trim & "|" & pNombre & "|" & pCedula & "|" & Pdireccion & "|" & _
                pActividad & "|" & pMonto & "|" & pSaldo & "|" & pCuota & "|" & pCapital_Mora & "|" & pIntereses_Corrientes & "|" & pIntereses_Moratorios & "|" & _
                pCuotas_Mora & "|" & pGarantia & "|" & pTasa_Interes & "|" & pFecha_Otorgado & "|" & pFecha_Vence & "|" & pCiclo & "|" & pDias_Atraso & "|" & pMenosde1 & "|" & _
                pMenosde2 & "|" & pMenosde3 & "|" & pMenosde4 & "|" & pMenosde6 & "|" & pMayor180 & "|" & pSexo & "|" & pMetodologia & "|" & pPrograma & "|" & _
                pProducto & "|" & pSector & "|" & pEstado & "|" & pTipo_Cartera & "|" & pDestino & "|" & pMunicipio & "|" & pFecha_Nac & "|" & _
                pDepartamento & "|" & pFondos & "|" & pAsesor_Otorgo & "|" & pAsesor_Administra & "|" & pPago_Capital & "|" & pPago_Interes & "|" & _
                pPago_Mora & "|" & pTipoInteres & "|" & ptasmor & "|" & ptipgar



                strStreamWriter.WriteLine(pccadena)



            Next

            strStreamWriter.Close()

            'Dim FilePath As String = "c:/txt/" & lcnombre.Trim & ".txt"

            '            Me.DownloadFile(FilePath, lcnombre.Trim)
            'Response.Write("<script language='javascript'>alert('El archivo se generó con éxito')</script>")


        Catch ex As Exception
            strStreamWriter.Close()
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Function EnviarEmail(ByVal archivo As String, ByVal fecha As String) As Integer
        Dim objMail As New MailMessage
        Dim objSmtp As New SmtpClient
        Dim adjunto As Attachment

        adjunto = New Attachment(archivo)

        Dim from As String = ConfigurationManager.AppSettings.Item("user").ToString

        Dim host As String = ConfigurationManager.AppSettings.Item("host").ToString
        Dim emailTo As String = ConfigurationManager.AppSettings.Item("emailTo").ToString
        Dim port As String = ConfigurationManager.AppSettings.Item("port").ToString
        Dim user As String = ConfigurationManager.AppSettings.Item("user").ToString
        Dim userPass As String = ConfigurationManager.AppSettings.Item("userPass").ToString
        Dim args() As String
        args = Split(emailTo, ";")



        Try

            For Each correos As String In args
                objMail.To.Add(correos)
            Next

            objSmtp.Credentials = New Net.NetworkCredential(user, userPass)
            objSmtp.Host = host
            objSmtp.Port = port

            objMail.From = New MailAddress(from)
            'objMail.To.Add(emailTo)            
            objMail.Subject = "archivos de cierre MINE:"
            objMail.Body = "archivos generados por cierre automatico con fecha: " + fecha
            objMail.Attachments.Add(adjunto)
            objSmtp.Send(objMail)

        Catch ex As Exception

        End Try
    End Function

    Private Sub GeneraArchivoMINEAnt(ByVal ds As DataSet)
        'Variables para abrir el archivo en modo de escritura

        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter
        Try
            Dim lcnombre As String
            Dim lcdia1 As String
            Dim lcdia As String
            Dim clsppal As New class1

            Dim lcmes1 As String
            Dim lcmes As String

            Dim lcaño As String
            Dim ldfecant As Date = Date.Parse(Me.txtfecant.Text)
            lcdia1 = Date.Parse(Me.txtfecant.Text).Day.ToString
            lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

            lcmes1 = Date.Parse(Me.txtfecant.Text).Month.ToString
            lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

            lcaño = Date.Parse(Me.txtfecant.Text).Year.ToString.Trim

            lcnombre = "MINE_" & lcdia & lcmes & lcaño & "C.txt"


            Dim FilePath As String = "c:/txt/cierre/" & lcnombre

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)

            'Se traen los datos que necesitamos para el archivo
            'TraerDatosArchivo retorna un dataset pero perfectamente
            'podria ser cualquier otro tipo de objeto


            Dim dr As DataRow

            Dim pccadena As String
            Dim pNo, pRegion, pAgencia, pCredito, pCliente, pNombre, pCedula, Pdireccion As String
            Dim pActividad, pMonto, pSaldo, pCuota, pCapital_Mora, pIntereses_Corrientes, pIntereses_Moratorios As String
            Dim pCuotas_Mora, pGarantia, pTasa_Interes, pFecha_Otorgado, pFecha_Vence, pCiclo, pDias_Atraso, pMenosde1 As String
            Dim pMenosde2, pMenosde3, pMenosde4, pMenosde6, pMayor180 As String
            Dim pSexo, pMetodologia, pPrograma, pProducto, pSector, pEstado, pTipo_Cartera As String
            Dim pDestino, pMunicipio, pFecha_Nac, pDepartamento, pFondos, pAsesor_Otorgo, pAsesor_Administra As String
            Dim pPago_Capital, pPago_Interes, pPago_Mora, pTipoInteres, ptasmor, ptipgar As String
            Dim lncuotasmor As Integer = 0
            Dim lccondic As String
            Dim ecremcre As New cCremcre
            For Each dr In ds.Tables(0).Rows
                'Obtenemos los datos del dataset
                pNo = dr("No")
                pRegion = dr("region")
                pAgencia = dr("agencia")
                pCredito = dr("credito")
                pCredito = pCredito.Replace("'", "")
                pCliente = dr("cliente")
                pCliente = pCliente.Replace("'", "")
                pNombre = dr("Nombre")
                pCedula = dr("Cedula")
                Pdireccion = dr("Direccion")
                pActividad = dr("actividad")
                pMonto = CStr(Math.Round(dr("monto"), 2))
                pSaldo = CStr(Math.Round(dr("Saldo"), 2))
                pCuota = CStr(Math.Round(dr("cuota"), 2))
                ptipgar = dr("ctipgar")
                If dr("cestado") = "F" Then 'Vigente
                    pCapital_Mora = CStr(Math.Round(dr("ncapmoraant"), 2)) 'CStr(Math.Round(dr("capital_mora"), 2))
                    pIntereses_Corrientes = CStr(Math.Round(dr("nsalintant"), 2)) 'CStr(Math.Round(dr("Intereses_Corrientes"), 2))
                    pIntereses_Moratorios = CStr(Math.Round(dr("nsalmorant"), 2)) 'CStr(Math.Round(dr("Intereses_Moratorios"), 2))
                    'Cuotas Atrasadas
                    If dr("ndiaatrAnt") > 0 And dr("ncuotakp") > 0 Then
                        lncuotasmor = Math.Ceiling(Math.Round(dr("ncapmoraant"), 2) / dr("ncuotakp"))
                    Else
                        lncuotasmor = 0
                    End If
                    pCuotas_Mora = CStr(Math.Round(lncuotasmor, 2)) 'CStr(Math.Round(dr("cuotas_mora"), 2))
                    pDias_Atraso = CStr(dr("ndiaatrAnt")) 'CStr(dr("dias_atraso"))

                    pMenosde1 = CStr(Math.Round(0, 2))
                    pMenosde2 = CStr(Math.Round(0, 2))
                    pMenosde3 = CStr(Math.Round(0, 2))
                    pMenosde4 = CStr(Math.Round(0, 2))
                    pMenosde6 = CStr(Math.Round(0, 2))
                    pMayor180 = CStr(Math.Round(0, 2))

                    If dr("ndiaatrAnt") <= 30 Then
                        pMenosde1 = CStr(Math.Round(dr("ncapmoraAnt"), 2))
                    ElseIf dr("ndiaatrAnt") > 30 And dr("ndiaatrAnt") <= 60 Then
                        pMenosde2 = CStr(Math.Round(dr("ncapmoraAnt"), 2))
                    ElseIf dr("ndiaatrAnt") > 60 And dr("ndiaatrAnt") <= 90 Then
                        pMenosde3 = CStr(Math.Round(dr("ncapmoraAnt"), 2))
                    ElseIf dr("ndiaatrAnt") > 90 And dr("ndiaatrAnt") <= 120 Then
                        pMenosde4 = CStr(Math.Round(dr("ncapmoraAnt"), 2))
                    ElseIf dr("ndiaatrAnt") > 120 And dr("ndiaatrAnt") <= 180 Then
                        pMenosde6 = CStr(Math.Round(dr("ncapmoraAnt"), 2))
                    Else
                        pMayor180 = CStr(Math.Round(dr("ncapmoraAnt"), 2))
                    End If
                    lccondic = dr("ccondic")
                    If lccondic = "J" Or lccondic = "P" Or lccondic = "R" Then
                    Else
                        If lccondic = "S" Then
                        Else
                            'Asigna estado Actual
                            If ldfecant > dr("fecha_vence") Or dr("ndiaatrAnt") >= 90 Then 'Credito ya esta vencido
                                lccondic = "V"
                            ElseIf dr("ndiaatrAnt") <= 0 Then 'vigentes al día
                                lccondic = "N"
                            ElseIf dr("ndiaatrAnt") > 0 And dr("ndiaatrAnt") < 90 Then 'vigentes en mora
                                lccondic = "M"
                            End If
                        End If

                    End If
                    pEstado = ecremcre.StatusCredito(lccondic)
                Else 'Cancelado
                    pCapital_Mora = CStr(Math.Round(0, 2)) 'CStr(Math.Round(dr("capital_mora"), 2))
                    pIntereses_Corrientes = CStr(Math.Round(0, 2)) 'CStr(Math.Round(dr("Intereses_Corrientes"), 2))
                    pIntereses_Moratorios = CStr(Math.Round(0, 2)) 'CStr(Math.Round(dr("Intereses_Moratorios"), 2))

                    'Cuotas Atrasadas
                    If dr("ndiaatrAnt") > 0 And dr("ncuotakp") > 0 Then
                        lncuotasmor = 0
                    Else
                        lncuotasmor = 0
                    End If
                    pCuotas_Mora = CStr(Math.Round(lncuotasmor, 2)) 'CStr(Math.Round(dr("cuotas_mora"), 2))
                    pDias_Atraso = CStr(0) 'CStr(dr("dias_atraso"))
                    pMenosde1 = CStr(Math.Round(0, 2))
                    pMenosde2 = CStr(Math.Round(0, 2))
                    pMenosde3 = CStr(Math.Round(0, 2))
                    pMenosde4 = CStr(Math.Round(0, 2))
                    pMenosde6 = CStr(Math.Round(0, 2))
                    pMayor180 = CStr(Math.Round(0, 2))

                    pEstado = dr("estado")
                End If

                pGarantia = dr("garantia")
                pTasa_Interes = CStr(Math.Round(dr("tasa_interes"), 2))
                pFecha_Otorgado = Left(dr("fecha_otorgado").ToString, 10)
                pFecha_Vence = Left(dr("fecha_vence").ToString, 10)
                pCiclo = CStr(dr("ciclo"))

                pSexo = dr("sexo")
                pMetodologia = dr("metodologia")
                pPrograma = dr("programa")
                pProducto = dr("producto")
                pSector = dr("sector")
                pTipo_Cartera = dr("tipo_cartera")
                pDestino = dr("destino")
                pMunicipio = dr("municipio")
                pFecha_Nac = Left(dr("fecha_nac").ToString, 10)
                pDepartamento = dr("departamento")
                pFondos = dr("fondos")
                pAsesor_Otorgo = dr("asesor_otorgo")
                pAsesor_Administra = dr("asesor_administra")

                pPago_Capital = CStr(Math.Round(dr("pago_capital"), 2))
                pPago_Interes = CStr(Math.Round(dr("pago_interes"), 2))
                pPago_Mora = CStr(Math.Round(dr("pago_mora"), 2))
                pTipoInteres = dr("TipoInteres")
                ptasmor = CStr(Math.Round(dr("ntasmor"), 2))

                pccadena = pNo.Trim & "|" & pRegion.Trim & "|" & pAgencia & "|" & pCredito.Trim & "|" & pCliente.Trim & "|" & pNombre & "|" & pCedula & "|" & Pdireccion & "|" & _
                pActividad & "|" & pMonto & "|" & pSaldo & "|" & pCuota & "|" & pCapital_Mora & "|" & pIntereses_Corrientes & "|" & pIntereses_Moratorios & "|" & _
                pCuotas_Mora & "|" & pGarantia & "|" & pTasa_Interes & "|" & pFecha_Otorgado & "|" & pFecha_Vence & "|" & pCiclo & "|" & pDias_Atraso & "|" & pMenosde1 & "|" & _
                pMenosde2 & "|" & pMenosde3 & "|" & pMenosde4 & "|" & pMenosde6 & "|" & pMayor180 & "|" & pSexo & "|" & pMetodologia & "|" & pPrograma & "|" & _
                pProducto & "|" & pSector & "|" & pEstado & "|" & pTipo_Cartera & "|" & pDestino & "|" & pMunicipio & "|" & pFecha_Nac & "|" & _
                pDepartamento & "|" & pFondos & "|" & pAsesor_Otorgo & "|" & pAsesor_Administra & "|" & pPago_Capital & "|" & pPago_Interes & "|" & _
                pPago_Mora & "|" & pTipoInteres & "|" & ptasmor & "|" & ptipgar

                strStreamWriter.WriteLine(pccadena)

            Next
            strStreamWriter.Close()
        Catch ex As Exception
            strStreamWriter.Close()

        End Try
    End Sub
    Private Sub GeneraDatosContaExp()
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter

        Try

            Dim dsconta As New DataSet
            Dim ecntamov As New cCntamov



            Dim lcnombre As String
            Dim lcdia1 As String
            Dim lcdia As String
            Dim clsppal As New class1

            Dim lcmes1 As String
            Dim lcmes As String

            Dim lcaño As String
            Dim ldfecant As Date = Date.Parse(Me.txtfecant.Text)
            lcdia1 = Date.Parse(Me.txtfecant.Text).Day.ToString
            lcdia = IIf(lcdia1.Trim.Length = 1, ("0" & lcdia1), lcdia1)

            lcmes1 = Date.Parse(Me.txtfecant.Text).Month.ToString
            lcmes = IIf(lcmes1.Trim.Length = 1, ("0" & lcmes1), lcmes1)

            lcaño = Date.Parse(Me.txtfecant.Text).Year.ToString.Trim

            lcnombre = "CTB_" & lcdia & lcmes & lcaño & "C.txt"

            dsconta = ecntamov.GeneraDatosConta(ldfecant)

            Dim FilePath As String = "c:/txt/cierre/" & lcnombre

            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, _
                                System.Text.Encoding.UTF8)


            Dim ppartida, pglosa, pccodofi, pfondo, pccodcta, pDebe, phaber, pccodpres, pccodsec, pfecha As String
            Dim pccadena As String

            pccadena = "N_Partida" & "|" & "Concepto" & "|" & "Oficina" & "|" & "Fondo" & "|" & "Cuenta_Contable" & "|" & "Debe" & "|" & "Haber" & _
                        "|" & "N_Prestamo" & "|" & "Ope" & "|" & "Fecha"
            strStreamWriter.WriteLine(pccadena)
            For Each fila As DataRow In dsconta.Tables(0).Rows
                ppartida = fila("cnumcom")
                pglosa = fila("cglosa")
                pccodofi = fila("ccodofi")
                pfondo = fila("ffondos")
                pccodcta = fila("ccodcta")

                pDebe = CStr(Math.Round(fila("ndebe"), 2))
                phaber = CStr(Math.Round(fila("nhaber"), 2))
                pccodpres = IIf(IsDBNull(fila("ccodpres")), "", fila("ccodpres"))
                pccodsec = IIf(IsDBNull(fila("ccodsec")), "", fila("ccodsec"))
                pfecha = Left(fila("dfeccnt").ToString, 10)
                pccadena = ppartida.Trim & "|" & pglosa.Trim & "|" & pccodofi.Trim & "|" & pfondo.Trim & "|" & pccodcta.Trim & "|" & pDebe.Trim & "|" & phaber.Trim & _
                        "|" & pccodpres.Trim & "|" & pccodsec.Trim & "|" & pfecha.Trim
                strStreamWriter.WriteLine(pccadena)

            Next
        Catch ex As Exception
        Finally
            strStreamWriter.Close()
        End Try

    End Sub
End Class