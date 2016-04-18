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

Public Class CUWSugLote

    Inherits System.Web.UI.UserControl
    Private cls1 As New SIM.BL.ClsMantenimiento
    Private clase As New SIM.BL.class1
    Private cls_Sim As New SIM.BL.ClsSolicitud
    Private pcCodCta As String
    Private codigoJs As String
    'Variable toma codigo Grupo Pra filtrado entre el pcCodCta

#Region "Variables"
    Private clsConvert As New SIM.BL.ConversionLetras
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
    Private lndiasug As Integer
    Private lctipper As String
    Private lnmeses As Integer


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

#End Region

    'varibale a mandar
    Public Event caputurado(ByVal caputurado As String)

#Region " Metodos "
    Private Sub CargarDatos()
        '----------------------------
        'Llenando Oficinas
        '----------------------------
        Dim etabtofi As New cTabtofi
        ds = etabtofi.ObtenerDataSetPorNivel(Session("gnNivel"), Session("gcCodOfi"))

        'lnparametro1_R = "cNomOfi , cCodOfi, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTOFI"
        'lnparametro5_R = "S"
        'lnparametro6_R = " "
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        If ds.Tables(0).Rows.Count <= 0 Then
            'MsgBox("No existen Oficinas", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Oficinas, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
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


        'Me.cbxLineas.DataTextField = "cdeslin"
        'Me.cbxLineas.DataValueField = "cNrolin"
        'Me.cbxLineas.DataSource = mListacretlin
        'Me.cbxLineas.DataBind()


        'mListacretlin = clscretlin.ObtenerLista()
        ds = clscretlin.Recuperarpor_Metodo("03") ' Me.HiddenField1.Value.Trim

        '*****************************************
        '*****************************************
        'Fernando Abrego Rdz Validacion
        Dim fila As Data.DataRow
        fila = Me.ds.Tables("table").NewRow
        fila("cdeslin") = "Seleccione una linea.."
        'Me.ds.Tables("table").Rows.Add(fila)

        ds.Tables(0).Rows.InsertAt(fila, 0)


        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()

        '        ecretlin.ObtenerLista()

        'Me.cbxLineas.DataTextField = "cdeslin"
        'Me.cbxLineas.DataValueField = "cNrolin"
        'Me.cbxLineas.DataSource = mListacretlin
        'Me.cbxLineas.DataBind()


        Me.txtFecDes.Text = Today()
        Me.txtfecpri.Text = Today.AddMonths(1)
        Me.txtgarantias.Text = 0

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
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Me.cbxgrupos.DataTextField = "cNomgru"
        Me.cbxgrupos.DataValueField = "cCodsol"
        Me.cbxgrupos.DataSource = ds.Tables("Resultado")
        Me.cbxgrupos.DataBind()

        Me.cbxgrupos.Visible = False
        Me.Label13.Visible = False
        Me.cbxgrupos.Disabled = True

        ds.Tables("Resultado").Clear()

        '----------------------------
        'Causas de rechazo
        '----------------------------
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0421'   order by cdescri"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If


        Me.cbxrechazo.DataTextField = "cdescri"
        Me.cbxrechazo.DataValueField = "cCodigo"
        Me.cbxrechazo.DataSource = ds.Tables("Resultado")
        Me.cbxrechazo.DataBind()
        ds.Tables("Resultado").Clear()

        Label15.Visible = False
        cbxrechazo.Visible = False
        txtbandera.Text = "0"

        Me.btnGrabar.Disabled = True
        Me.Button1.Disabled = True


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
            '  MsgBox("No existen Datos a Eligir", MsgBoxStyle.Information, "Aviso")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        Me.cbxContrato.DataTextField = "cDescri"
        Me.cbxContrato.DataValueField = "cCodigo"
        Me.cbxContrato.DataSource = ds.Tables("Resultado")
        Me.cbxContrato.DataBind()

        ds.Tables("Resultado").Clear()



        '*************tipo de cartera*****************
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab  ='075' and cTipReg = '1' order by cdescri "
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'Response.Write("<script language='javascript'>alert('No existen operaciones')</script>")
            codigoJs = "<script language='javascript'>alert('No existen Operaciones, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Me.ddlcartera.DataTextField = "cDescri"
        Me.ddlcartera.DataValueField = "cCodigo"
        Me.ddlcartera.DataSource = ds.Tables("resultado")
        Me.ddlcartera.DataBind()

        ds.Tables("Resultado").Clear()

        CargaTasas(cbxLineas.SelectedValue.Trim)

        CargarFondos()
    End Sub

    Private Sub Valida_Linea_Credito()
        'Verifica si el producto es Flexible o Cerrado
        Dim entidadcretlin As New cretlin
        Dim mcretlin As New cCretlin
        Dim entidadtabttab As New tabttab
        Dim omtabttab As New cTabttab
        Dim ldfecpri As Date

        entidadcretlin.cnrolin = Me.cbxLineas.SelectedValue.Trim

        mcretlin.ObtenerCretlin(entidadcretlin)
        '*********************************************
        '
        '*********************************************+
        'Validacion de campos seleccion linea value =""
        If entidadcretlin.cnrolin = "" Then
            txttasa.Text = 0.0
            txtnmoncuo.Text = 0.0
            pnCuoSug.Text = 0.0
            'Sale proceso
            Exit Sub
        End If


        'entidadcretlin.ccodlin 
        If entidadcretlin.ccodlin.Substring(10, 1) = "1" Then 'Flexible
            Me.RadioButton1.Enabled = True
            Me.RadioButton5.Enabled = True
            Me.RadioButton4.Enabled = True
            Me.cbxCapital.Enabled = True
            Me.cbxInteres.Enabled = True
            Me.pnCuoSug.Enabled = True
            Me.txtnmoncuo.Text = "0.00"
            Me.txtfecpri.Enabled = True
        Else                                                  'Cerrado  
            Me.RadioButton1.Enabled = False
            Me.RadioButton5.Enabled = False
            Me.RadioButton4.Enabled = False
            Me.cbxCapital.Enabled = False
            Me.cbxInteres.Enabled = False
            Me.pnCuoSug.Enabled = False
            Me.txtfecpri.Enabled = False

            Me.RadioButton1.Checked = False 'Fija Nivelada   
            Me.RadioButton5.Checked = False 'Flat
            Me.RadioButton4.Checked = False 'Decreciente

            Me.cbxCapital.SelectedValue = entidadcretlin.ccodlin.Substring(12, 1)
            cargacombointeres()
            Me.cbxInteres.SelectedValue = entidadcretlin.ccodlin.Substring(12, 1)

            Select Case entidadcretlin.ccodlin.Substring(11, 1)
                Case 1
                    Me.RadioButton1.Checked = True 'Fija Nivelada   
                Case 2
                    Me.RadioButton5.Checked = True 'Flat
                Case 3
                    Me.RadioButton4.Checked = True 'Decreciente
            End Select


            entidadtabttab.ccodtab = "060"
            entidadtabttab.ctipreg = "1"
            entidadtabttab.ccodigo = Me.cbxCapital.SelectedValue.Trim

            omtabttab.ObtenerTabttab(entidadtabttab)

            ldfecpri = Date.Parse(Me.txtFecDes.Text)
            ldfecpri = ldfecpri.AddDays(entidadtabttab.nnumtab)

            txtfecpri.Text = ldfecpri

            Me.pnCuoSug.Text = entidadcretlin.nocuotas
            Me.txtnmoncuo.Text = entidadcretlin.nmoncuo
        End If

    End Sub


    Private Sub CargaGrid()
        CargarDatos()
        '**********************************'
        ''validacion informativa por estatus 
        LblCodigoGrupo.Text = pcCodCta
        '**********************************'
        Dim ecreditosEstatus As New ccreditos
        'Estatus Actual de Credito
        Dim dsEstatus As New DataSet


        dsEstatus = ecreditosEstatus.Estatus_grupal(pcCodCta)
        If dsEstatus.Tables("Table").Rows.Count() = 0 Then
            codigoJs = "<script language='javascript'>alert('El estatus del Grupo no es SOLICITUD O SUGERIDO " & _
                                   "Advertencia SIM.NET '); location.href='WBSUGLOTE.ASPX'; </script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub

        End If
        'Valida que un cliente no tega mas de un credito e estatus A ,E,E,F
        Dim codigoClientes As New DataSet
        Dim codigoCliente As String
        Dim conjuntodeCreditosporCliente As Integer = 0
        Dim totCreditosInvali As Integer = 0
        Dim clientes As String

        codigoClientes = ecreditosEstatus.buscaCodigosClientes(pcCodCta)

        'Modificacion de cesar torres para mejorar la validacion de los datos que se presentan
        '23/02/2016
        Dim ds As DataSet
        Dim dsRangos As DataSet
        Dim SolicitudesAbiertas As String
        Dim eClimide As New SIM.BL.cClimide

        SolicitudesAbiertas = ""

        For Each rows As DataRow In codigoClientes.Tables(0).Rows

            codigoCliente = rows("ccodcli")
            ds = eClimide.ObtenerSolicitudesAbiertas(codigoCliente)
            'conjuntodeCreditosporCliente = ecreditosEstatus.buscarCreditos(codigoCliente)
            'Si encontró mas de una vez al cliente
            If ds.Tables(0).Rows.Count > 1 Then
                For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    SolicitudesAbiertas += "\n " & Trim(ds.Tables(0).Rows(j)(0).ToString()) & Chr(9) & Trim(ds.Tables(0).Rows(j)(1).ToString()) & Chr(9) & Trim(ds.Tables(0).Rows(j)(2).ToString() & Chr(9) & Trim(ds.Tables(0).Rows(j)(3).ToString()) & Chr(9) & codigoCliente)
                    j = j + 1
                Next
            End If

           


            'Si es menor a cero hay un error si es mayor a 1 tiene mas de un credito a un vigente
            'If conjuntodeCreditosporCliente > 1 Then
            '    clientes = clientes & "\n" & codigoCliente & "\n"
            '    totCreditosInvali += 1 ' si existe cliente con mas de un credito damo 1 al contador 
            'End If
        Next

        If SolicitudesAbiertas <> "" Then

            codigoJs = "<script language='javascript'>alert('Clientes con solicitudes en proceso \n" & _
                                   "\nNecesita rechazar o eliminar las siguientes solicitudes. \n\" & _
                                   " GRUPO " & Chr(9) & " CODIGO GR" & _
                                   Chr(9) & " ESTATUS " & Chr(9) & _
                                   " FECHA SOLICITUD" & Chr(9) & "CODIGO CLI " & _
                                   "\n\n" & SolicitudesAbiertas & _
                                   "\n\nAdvertencia SIM.NET'); location.href='WBSUGLOTE.ASPX'; </script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Dim ecreditos As New ccreditos
        'Dim ds As New DataSet
        ds = ecreditos.ListadoCreditosxGrupoSugerencia(pcCodCta)

        For Each Linea As DataRow In ds.Tables(0).Rows
            If Not Linea("digitaliza_foto") Then
                codigoJs = "<script language='javascript'>alert('No se digitalizaron las fotos, " & _
                            "Advertencia SIM.NET '); location.href='wfDownphote.aspx';</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


                'Response.Write("<script language='javascript'>alert('No se digitalizaron las fotos, Advertencia SIM.NET')</script>")

                btnPlan.Disabled = True
                Button2.Disabled = True
                Exit Sub
            End If
        Next


        Datagrid1.DataSource = ds
        Datagrid1.DataBind()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnsumsol As Double = 0
        Dim lnmonsol As Double = 0
        Dim lnsumsug As Double = 0
        Dim lnmonsug As Double = 0
        Dim lcflat As String = ""


        'Analiza si existe comision en el Desembolso para aumentarla al monto sugerido,
        'Especial Mexico 02/09/2014

        Dim entidadcretgas As New cretgas
        Dim mcretgas As New cCretgas
        Dim lnMongas As Double

        lnMongas = mcretgas.ObtienevalordeGasto(Me.cbxLineas.SelectedValue.Trim, "01", "224")

        For Each fila In ds.Tables(0).Rows
            lnmonsol = ds.Tables(0).Rows(i)("nmonsol")
            lnsumsol = lnsumsol + lnmonsol
            lcflat = ds.Tables(0).Rows(i)("cflat")

            lnmonsug = ds.Tables(0).Rows(i)("nmonsug")

            If lnmonsug = 0 Then
                'ds.Tables(0).Rows(i)("nmonsug") = ds.Tables(0).Rows(i)("nmonsol")
                'lnmonsug = ds.Tables(0).Rows(i)("nmonsug")
                If lnMongas > 0 Then
                    fila("nmonsug") = Math.Round(fila("nmonsol") + (fila("nmonsol") * (lnMongas / 100)), 2)
                    fila("nmonsug") = Format(Double.Parse(fila("nmonsug")), "#########.00")
                Else
                    fila("nmonsug") = fila("nmonsol")
                End If
                lnmonsug = lnmonsug + fila("nmonsug")
            End If

            lnsumsug = lnsumsug + lnmonsug

            i += 1
        Next


        If lcflat = "F" Then
            RadioButton5.Checked = True
            RadioButton1.Checked = False
        Else
            RadioButton1.Checked = True
            RadioButton5.Checked = False
        End If
        Me.txtMonSol.Text = lnsumsol
        Me.txtmonSug.Text = lnsumsug
        Me.txtnMonApr.Text = lnsumsug
        btnPlan.Disabled = False
        Button2.Disabled = False

        Datagrid1.DataBind()

        If pcCodCta.Trim.Substring(6, 2) = "02" Then
            Label13.Text = "Banco Comunal"
        Else
            Label13.Text = "Grupo Solidario"
        End If
    End Sub
    ''' Revision ---carga codigo grupo
    Private Sub CargaGrid2(ByVal Codigogrupal As String)
        ''--CargarDatos()
        '**********************************'
        ''validacion informativa por estatus 
        '**********************************'
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        ds = ecreditos.ListadoCreditosxGrupoSugerencia(Codigogrupal)

        Datagrid1.DataSource = ds
        Datagrid1.DataBind()

        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnsumsol As Double = 0
        Dim lnmonsol As Double = 0
        Dim lnsumsug As Double = 0
        Dim lnmonsug As Double = 0
        Dim lcflat As String = ""


        'Analiza si existe comision en el Desembolso para aumentarla al monto sugerido,
        'Especial Mexico 02/09/2014

        Dim entidadcretgas As New cretgas
        Dim mcretgas As New cCretgas
        Dim lnMongas As Double

        lnMongas = mcretgas.ObtienevalordeGasto(Me.cbxLineas.SelectedValue.Trim, "01", "224")

        For Each fila In ds.Tables(0).Rows
            lnmonsol = ds.Tables(0).Rows(i)("nmonsol")
            lnsumsol = lnsumsol + lnmonsol
            lcflat = ds.Tables(0).Rows(i)("cflat")

            lnmonsug = ds.Tables(0).Rows(i)("nmonsug")

            If lnmonsug = 0 Then
                'ds.Tables(0).Rows(i)("nmonsug") = ds.Tables(0).Rows(i)("nmonsol")
                'lnmonsug = ds.Tables(0).Rows(i)("nmonsug")
                If lnMongas > 0 Then
                    fila("nmonsug") = Math.Round(fila("nmonsol") + (fila("nmonsol") * (lnMongas / 100)), 2)
                    fila("nmonsug") = Format(Double.Parse(fila("nmonsug")), "#########.00")
                Else
                    fila("nmonsug") = fila("nmonsol")
                End If
                lnmonsug = lnmonsug + fila("nmonsug")
            End If

            lnsumsug = lnsumsug + lnmonsug

            i += 1
        Next


        If lcflat = "F" Then
            RadioButton5.Checked = True
            RadioButton1.Checked = False
        Else
            RadioButton1.Checked = True
            RadioButton5.Checked = False
        End If
        Me.txtMonSol.Text = lnsumsol
        Me.txtmonSug.Text = lnsumsug
        Me.txtnMonApr.Text = lnsumsug
        btnPlan.Disabled = True
        Button2.Disabled = False

        Datagrid1.DataBind()

        If Codigogrupal.Trim.Substring(6, 2) = "02" Then
            Label13.Text = "Banco Comunal"
        Else
            Label13.Text = "Grupo Solidario"
        End If
    End Sub


    Private Sub CargarDatosCredito()
        'pccodcta <Codigo del grupo>

        Me.CargaGrid()


        If Me.Datagrid1.Items.Count = 0 Then
            Exit Sub
        End If

        pcCodCta = Me.Datagrid1.Items(0).Cells(0).Text
        Me.txtCredito.Text = pcCodCta
        Me.cbxcodofi.SelectedValue = pcCodCta.Trim.Substring(3, 3)


        'Label15.Visible = False
        'cbxrechazo.Visible = False

        'Dim pcCodAct As String
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = pcCodCta

        ecreditos.Obtenercreditos(entidad3)
        If entidad3.cestado <> "A" And entidad3.cestado <> "C" Then
            Me.btnGrabar.Disabled = True
            Me.Button1.Disabled = True
            Me.btnPlan.Disabled = True
            'Response.Write("<script language='javascript'>alert('Estado Errado')</script>")
            codigoJs = "<script language='javascript'>alert('Estado del Crédito Errado, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


            Return
        Else
            Me.btnPlan.Disabled = False
        End If
        If IsDBNull(entidad3.ccodfue) Then
            HiddenField1.Value = ""
        Else
            CargaLineasxFondos(entidad3.ccodfue)
            HiddenField1.Value = entidad3.ccodfue
        End If

        'Me.txtcCodCli.Text = entidad3.ccodcli
        'Me.txtcNomcli.Text = entidad3.cnomcli
        'Me.txtMonSol.Text = entidad3.nmonsol
        Me.txtNomAna.Text = entidad3.cNomUsu
        'Me.txtmonSug.Text = entidad3.nmonsug
        Me.pnCuoSug.Text = IIf(entidad3.ncuosug = 0 Or IsDBNull(entidad3.ncuosug), 6, entidad3.ncuosug)
        'Me.txtnMonApr.Text = entidad3.nmonsug
        Me.txtcTipPer.Text = entidad3.ctipper
        Me.txtcTipCuo.Text = entidad3.ctipcuo
        Me.txtnperdia.Text = entidad3.ndiasug
        Me.txtndiaGra.Text = entidad3.ndiagra
        '----------


        'Me.pnCuoSug.Text = entidad3.ncuosug
        Dim ecredtpl As New cCredtpl
        Me.txtfecpri.Text = ecredtpl.Obtenerprimeracuota(pcCodCta)
        Me.txtvencimiento.Text = ecredtpl.ObtenerUltimacuota(pcCodCta)
        txtdFecVen.Text = Me.txtvencimiento.Text


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
        ElseIf entidad3.ctipcuo = "4" Then
        ElseIf entidad3.ctipcuo = "5" Then
            Me.RadioButton5.Checked = True
        ElseIf entidad3.ctipcuo = "6" Then
            Me.RadioButton4.Checked = True
        End If


        Me.txtcontrato.Text = entidad3.ctipcon
        Me.txtcflat.Text = IIf(IsDBNull(entidad3.cflat), "", entidad3.cflat)

        'Me.txttipocuota.Text = IIf(txtcflat.Text.Trim = "F", "FLAT", "FIJA NIVELADA")

        Me.txtFecDes.Text = IIf(IsDBNull(entidad3.dfecvig), Session("gdfecsis"), entidad3.dfecvig)

        Dim entidadcredtpl As New cCredtpl
        Me.txtfecpri.Text = entidadcredtpl.Obtenerprimeracuota(pcCodCta)

        If IsDBNull(entidad3.cnrolin) Then
        Else
            Try

                Me.cbxLineas.SelectedValue = entidad3.cnrolin
                CargaTasas(entidad3.cnrolin)
                Valida_Linea_Credito()

                If entidad3.ntasint >= Decimal.Parse(HiddenField2.Value) And entidad3.ntasint <= Decimal.Parse(HiddenField3.Value) Then
                    txttasa.Text = entidad3.ntasint
                Else
                    txttasa.Text = Decimal.Parse(HiddenField4.Value)
                End If

                cbxprograma.SelectedValue = entidad3.ccodfue
            Catch ex As Exception

            End Try

        End If

        'If entidad3.ccodsol = "" Or entidad3.ccodsol.Trim = "" Then
        '    Me.cbxgrupos.Visible = False
        '    Me.Label13.Visible = False
        '    Me.txtccodsol.Text = ""
        'Else
        Me.cbxgrupos.Value = entidad3.ccodsol
        Me.cbxgrupos.Visible = True
        Me.Label13.Visible = True
        Me.txtccodsol.Text = entidad3.ccodsol
        'End If

        Me.txtcfreccap.Text = entidad3.cfreccap
        Me.txtcfrecint.Text = entidad3.cfrecint
        'txttasa.Text = entidad3.ntasint

        'Dim entidad4 As New SIM.EL.clidfin
        'Dim clsclidfin As New SIM.BL.cClidfin

        'Dim mListaclidfin As New listaclidfin
        'mListaclidfin = clsclidfin.ObtenerLista2(Me.txtcCodCli.Text.Trim)

        Dim ecretlin As New cCretlin
        Me.TextBox1.Text = ecretlin.ObtenerFuentedeFondos(entidad3.cnrolin)

        Dim lverificaPlan As Boolean
        lverificaPlan = clase.VerificaExistePlanTeorico(pcCodCta)
        If lverificaPlan = True Then
            btnPlan.Disabled = True
            btnGrabar.Disabled = False
        Else
            btnPlan.Disabled = False
            btnGrabar.Disabled = True
        End If
        'Iguala Valores del plan de pagos
        HiddenField5.Value = cbxLineas.SelectedValue.Trim
        HiddenField6.Value = Double.Parse(txttasa.Text)
        HiddenField7.Value = Integer.Parse(pnCuoSug.Text)
        HiddenField8.Value = Double.Parse(txtmonSug.Text)

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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Introducir aquí el código de usuario para inicializar la página

        If Not IsPostBack Then
            Me.CargaVariables()
            Me.CargarDatos()
            Me.Label11.Visible = False
            Me.Label11.Text = ""
        Else
            Me.txtgarantias.Text = Session("nGrav")
        End If


        'If cbxLineas.SelectedIndex <> 0 Then

        '    'btnAplicar.Disabled = False
        '    'btnGrabar.Disabled = False
        '    'btnPlan.Disabled = False
        '    Button2.Disabled = False
        '    'Button1.Disabled = False
        'Else
        '    'btnAplicar.Disabled = True
        '    'btnGrabar.Disabled = True
        '    'btnPlan.Disabled = True
        '    Button2.Disabled = True
        '    'Button1.Disabled = True


        'End If
    End Sub
    'Si falta montos en garantias entonces se ejecuta
    Public Sub Cambio_tap(ByVal evento As String)
    End Sub
    '--Fin
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
        Dim omTabttab As New cTabttab
        Dim ds As New DataSet
        Dim lcTipPer, lcFlat As String
        Dim lnTipCuo As Integer
        Dim lccodlin As Integer
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        'lnTasa = entidadCretlin.ntasint
        lnTasa = Double.Parse(txttasa.Text)
        ViewState("pctasmor") = entidadCretlin.ntasmor.ToString
        ViewState("pctasa") = txttasa.Text.Trim
        ViewState("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        ViewState("pnmonsug") = Me.txtmonSug.Text

        If Me.txtmonSug.Text <= 5000 Then
            ViewState("pccomite1") = "X"
            ViewState("pccomite2") = ""
        Else
            ViewState("pccomite2") = "X"
            ViewState("pccomite1") = ""
        End If
        '>>>>>>>>>>>>>>>>>>>>>>
        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.txtcCodCli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clase.lsegvid = eclimide.lsegvida

        Dim entidadcreditos As New creditos
        entidadcreditos.ccodcta = Me.txtCredito.Text.Trim
        eCremcre.Obtenercreditos(entidadcreditos)
        clase.nMeses = clase.PlazoMeses(IIf(IsDBNull(entidadcreditos.dfecvig), Session("gdfecsis"), entidadcreditos.dfecvig), _
                                        IIf(IsDBNull(entidadcreditos.dfecven), Session("gdfecsis"), entidadcreditos.dfecven))
        'localiza fuente de fondos en base a cCodlin
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        lccodlin = entidadCretlin.ccodlin
        Dim clstabttab As New cTabttab
        Dim ds033 As New DataSet
        Dim lcfondos As String
        Dim nelemf As Integer
        lcfondos = lccodlin.ToString.Substring(2, 2).Trim
        ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos)
        nelemf = ds033.Tables(0).Rows.Count
        If nelemf = 0 Then
            ViewState("pcfuente") = ""
        Else
            ViewState("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        ViewState("pcnomchq") = entidadCredchq.cnomchq
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState("pdfecha") = Date.Parse(Me.txtFecDes.Text)
        '        Me.txtfecpri.Text = Today.AddMonths(1)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)

        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = Me.txtnMonApr.Text 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        'clase.cCodFor = lnTipCuo
        ' clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        'clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        'clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = IIf(Me.RadioButton5.Checked = True, "F", "")  'Me.txtcflat.Text.Trim

        If txtbandera.Text.Trim = "1" Then
            clase.cCodRec = cbxrechazo.Value.Trim
        End If


        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = pcCodCta
        'clase.cCodFor = Me.txtcTipPer.Text
        'clase.cTipCuo = Me.txtcTipCuo.Text
        'clase.nPerDia = Me.txtnperdia.Text
        clase.nPerDia = clase.periodo(Me.cbxInteres.SelectedValue.Trim)

        clase.nDiaGra = Me.txtndiaGra.Text
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        If clase.cCodFor = "2" Then
            clase.nPerDia = Day(clase.dFecDes)
        End If

        'If Me.cbxCapital.SelectedValue.Trim = "Q" Or Me.cbxCapital.SelectedValue.Trim = "S" Then
        '    clase.cCodFor = 1
        '    clase.nPerDia = omTabttab.ObtenerFactor("060", Me.cbxCapital.SelectedValue.Trim)
        'Else
        '    clase.cCodFor = IIf(cbxCapital.SelectedValue.Trim = "X", 1, lnTipCuo)
        '    clase.nPerDia = IIf(cbxCapital.SelectedValue.Trim = "X", Integer.Parse(txtnperdia.Text), Integer.Parse(Me.txtPlazo.Text))
        'End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        ViewState("pcnomcli") = Me.txtcNomcli.Text
        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        ViewState("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        ViewState("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        ViewState("pccanlet") = clsConvert.ConversionEnteros(Double.Parse(Me.txtmonSug.Text.Trim))
        lnDecimal = clsConvert.ExtraeDecimales(Me.txtmonSug.Text.Trim)
        ViewState("pccanlet") = ViewState("pccanlet") & " " & lnDecimal.ToString & "/100" & " QUETZALES"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dstipo As New DataSet
        Dim nelemgar As Integer
        Dim mcrepgar As New cCrepgar
        'dstipo = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        dstipo = clase.Garantizados(Me.txtcCodCli.Text.Trim)
        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            ViewState("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            ViewState("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            ViewState("pctipo") = "MIXTA"
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
            ViewState("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            ViewState("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim ds077 As New DataSet
        Dim lcdocu As String
        Dim nelemf1 As Integer
        lcdocu = Me.txtcontrato.Text
        ds077 = clstabttab.ObtenerDataSetPorID2("077", "1", lcdocu)
        nelemf = ds077.Tables(0).Rows.Count
        If nelemf1 = 0 Then
            ViewState("pccontrato") = ""
        Else
            ViewState("pccontrato") = ds077.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Me.Cargar_Gastos()
        Me.Meses()
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)


        'Me.txtcnrocta.Text = codigoCliente.Substring(6, 12)
        'Me.txtCredito.Text = codigoCliente.Trim
        pcCodCta = codigoCliente
        'If pcCodCta.Substring(6, 2) = "02" Then

        CargaContratos(pcCodCta.Substring(6, 2))
        Me.cbxContrato.Visible = False

        'Else
        '    Me.cbxContrato.Visible = False
        'End If

        Me.btnAplicar_ServerClick(Me, New System.EventArgs)
    End Sub
    Public Sub CargarPlan(ByVal codigoCliente As String)
        Me.btnPlan_ServerClick(Me, New EventArgs)
    End Sub


    Private Sub btnBuscar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("WfBusLin.aspx")

        Me.txtMonSol.Text = ViewState("vnMonSol")
    End Sub

    Private Sub txtNomAna_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomAna.TextChanged

    End Sub

    Private Sub cbxLineas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLineas.SelectedIndexChanged
        Dim eCremcre As New SIM.BL.ccreditos
        Dim Codigogrupal As String = LblCodigoGrupo.Text
        eCremcre.IgualaCerosNmonsug(Codigogrupal)

        CargaTasas(cbxLineas.SelectedValue.Trim)
        Valida_Linea_Credito()


        LblCodigoGrupo.Visible = False


    
        eCremcre.actualizaCnrolin(cbxLineas.SelectedValue.Trim, Codigogrupal)

        CargaGrid2(Codigogrupal)

        'GENERANDO CAMBIOS REVISON
        'Vlidaciones de botnos si values 0 seleciones una linea
        'If cbxLineas.SelectedItem.Value = "" Then
        '    btnPlan.Disabled = True
        '    Button2.Disabled = True
        '    btnGrabar.Disabled = True
        '    btnAplicar.Disabled = True
        'End If


    End Sub
    Private Sub Imprimir()
        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\CRAprSol.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        Dim dsPlanPago As New DataSet
        Dim entidadCremcre As New SIM.EL.cremcre
        Dim eCremcre As New SIM.BL.cCremcre
        entidadCremcre.ccodcta = Me.txtCredito.Text.Trim
        dsPlanPago = eCremcre.ObtenerDataSetPorIDAC(Me.txtCredito.Text.Trim)
        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dsPlanPago.Tables(0))
        crRpt.Refresh()

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream.ToArray())
        Response.End()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    End Sub

    Private Sub btnAplicar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar.ServerClick
        CargarDatosCredito()

    End Sub

    Private Sub btnGrabar_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.ServerClick
        'Validacion javaScript---Linea no seleccioanda
        If cbxLineas.SelectedIndex = 0 Then
            'Response.Write("<script language='javascript'>alert('Fecha de Desembolso  no puede ser menor a fecha de sistema')</script>")
            codigoJs = "<script language='javascript'>alert('Debe seleccionar un Producto Valido, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        GrabaDatosMiembro()
        GrabaResumenParaComite()

    End Sub
    Private Function Condiciones(ByVal opcion As Integer) As Integer
        Dim xy As Integer = 0
        '       Dim lccodchk As String
        Dim lnmonto As Double = 0
        Dim lnmonsug As Double = 0
        Dim lvalida As Boolean
        Dim nmonto As TextBox
        Dim ecredppg As New cCredppg

        For xy = 0 To Me.Datagrid1.Items.Count - 1
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            lnmonto = Double.Parse(nmonto.Text)
            lnmonsug = lnmonsug + lnmonto
            'Valida Frecuencia de pagos
            If opcion = 1 Then
                lvalida = ecredppg.ValidaFrecuencia(Me.cbxCapital.SelectedValue.Trim, Me.cbxInteres.SelectedValue.Trim, Integer.Parse(Me.pnCuoSug.Text))
                If lvalida = False Then
                    Return 1
                End If
            End If

            If opcion = 2 Then
                Dim lcvalida As String
                lcvalida = clase.ValidaLinea(Me.cbxLineas.SelectedItem.Value.Trim, lnmonto, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtvencimiento.Text))
                If lcvalida = False Then
                    Return 2
                End If
            End If
            '            lccodchk = Me.Datagrid1.Items(xy).Cells(4).Text
            'Graba Listado
            '            ecremcre.InsertaListaxUsuario(Me.TextBox2.Text.Trim, Session("gcCodusu"), lopcion, lccodchk, Session("gdfecsis"))
        Next

        Me.txtnMonApr.Text = lnmonsug
        Return 0
    End Function

    Private Sub btnPlan_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.ServerClick

        'Me.CargarDatos()

        'RaiseEvent caputurado(txtccodsol.Text)

        If cbxLineas.SelectedIndex = 0 Then
            'Response.Write("<script language='javascript'>alert('Fecha de Desembolso  no puede ser menor a fecha de sistema')</script>")
            codigoJs = "<script language='javascript'>alert('Selecione un producto valido, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If Date.Parse(txtfecpri.Text) <= Date.Parse(txtFecDes.Text) Then
            'Response.Write("<script language='javascript'>alert('Fecha de Desembolso  no puede ser mayor o igual a Fecha de Primera Cuota')</script>")
            codigoJs = "<script language='javascript'>alert('Fecha de Desembolso  no puede ser mayor o igual a Fecha de Primera Cuota, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If Date.Parse(txtFecDes.Text) < Session("gdfecsis") Then
            'Response.Write("<script language='javascript'>alert('Fecha de Desembolso  no puede ser menor a fecha de sistema')</script>")
            codigoJs = "<script language='javascript'>alert('Fecha de Desembolso  no puede ser menor a fecha de sistema, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If


        Valida_Linea_Credito()

        Dim lnvalida As Integer
        lnvalida = Condiciones(1)
        If lnvalida = 1 Then
            'Response.Write("<script language='javascript'>alert('Verifique Condiciones de Forma de Pago')</script>")
            codigoJs = "<script language='javascript'>alert('Verifique Condiciones de Forma de Pago, " & _
                      "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0
        Dim lcmonsug As String
        Dim lcnomcli As String
        Dim nmonto As TextBox

        'Analiza si existe comision en el Desembolso para aumentarla al monto sugerido,
        'Especial Mexico 02/09/2014

        Dim entidadcretgas As New cretgas
        Dim mcretgas As New cCretgas
        Dim lnMongas As Double

        lnMongas = mcretgas.ObtienevalordeGasto(Me.cbxLineas.SelectedValue.Trim, "01", "224")

        'Final de Calculo Comisión Especial
        For xy = 0 To Me.Datagrid1.Items.Count - 1

            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcnomcli = Me.Datagrid1.Items(xy).Cells(1).Text
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            lnmonsug = Double.Parse(nmonto.Text)
            'lnmonsug = nmonto

            lcmonsug = Me.Datagrid1.Items(xy).Cells(3).Text

            Me.IgualaDatosaGrabar(lccodcta, lnmonsug)

            If GeneraPlandepagos(lccodcta, lnmonsug) = 0 Then
                codigoJs = "<script language='javascript'>alert('Producto Mal Generado, Capital Negativo, Verifique " & _
                            "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.btnGrabar.Disabled = True
                Exit Sub
            End If
        Next

        lnvalida = Condiciones(2)

        If lnvalida = 2 Then
            'Response.Write("<script language='javascript'>alert('Linea Iválida, Verificar Plazo y/o Monto')</script>")
            codigoJs = "<script language='javascript'>alert('Linea Inválida, Verificar Plazo y/o Monto, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        ViewState("pncuota") = utilNumeros.Redondear(clase.pnmonCuo, 2)
        Session.Item("CodigoCre") = pcCodCta
        Me.txtnMonApr.Enabled = False
        Me.txtFecDes.Enabled = False
        txttasa.Enabled = False
        txttasa.Enabled = False
        Me.txtfecpri.Enabled = False
        Me.btnGrabar.Disabled = False
        Me.Button1.Disabled = False
        Me.btnPlan.Disabled = True

        Me.pnCuoSug.Enabled = False
        Me.RadioButton1.Enabled = False
        Me.RadioButton5.Enabled = False
        Me.cbxCapital.Enabled = False
        Me.cbxInteres.Enabled = False
        Me.cbxLineas.Enabled = False
        cbxprograma.Enabled = False
        Me.Datagrid1.Enabled = False

        Me.FormaPago()

        RaiseEvent caputurado(txtccodsol.Text)

    End Sub

    Private Sub Button2_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.ServerClick

        'Validacion javaScript---Linea no seleccioanda
        If cbxLineas.SelectedIndex = 0 Then
            'Response.Write("<script language='javascript'>alert('Fecha de Desembolso  no puede ser menor a fecha de sistema')</script>")
            codigoJs = "<script language='javascript'>alert('Debe seleccionar un Producto Valido, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        
        '********************************************
        '20-07-2015 Realiza Update a la Cremcre y actualiza 
        Dim entidadcretlin As New cretlin
        Dim mcretlin As New cCretlin
        Dim nmonto As TextBox

        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0

        Dim lcnomcli As String
        Dim lcmonsug As String
        Dim dsCretlin As DataSet
        Dim cClimide As New cClimide
        Dim nliminf As Double
        Dim nlimsup As Double
        Dim lineaCredito As String

        lineaCredito = Me.cbxLineas.SelectedItem.Text.ToString()




        For xy = 0 To Me.Datagrid1.Items.Count - 1
            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcnomcli = Me.Datagrid1.Items(xy).Cells(1).Text
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            lnmonsug = Double.Parse(nmonto.Text) 'Double.Parse(lcmonsug.Replace("Q", ""))

            'Cesar Alejandro Torres 16/04/2016
            '*************Validar que los montos solicitados esten dentro del  rango del producto ****************
            dsCretlin = cClimide.ValidarRangoProducto(lccodcta, lnmonsug)
            nliminf = dsCretlin.Tables(0).Rows(0)("nliminf")
            nlimsup = dsCretlin.Tables(0).Rows(0)("nlimsup")

            If lnmonsug >= nliminf And lnmonsug <= nlimsup Then
                Me.update_cremcre(lccodcta, lnmonsug)
            Else
                codigoJs = "<script language='javascript'>alert('El monto solicitado para: " & lcnomcli & _
                           "\nEstá fuera del rango de la linea de crédito: " & lineaCredito & " \nMonto solicitado: " & lnmonsug & _
                           "\nRango: Entre " & nliminf & "  y  " & nlimsup & "')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Me.btnGrabar.Disabled = True
                Exit Sub
            End If

            '*************Validar que los montos solicitados esten dentro del  rango del producto ****************



        Next



        'update_cremcre(ccodcta, montos)

        entidadcretlin.cnrolin = Me.cbxLineas.SelectedValue.Trim
        mcretlin.ObtenerCretlin(entidadcretlin)

        'If entidadcretlin.ccodlin.Substring(10, 1) = "1" Then 'Flexible

        '    txttasa.Enabled = True
        '    Me.RadioButton1.Enabled = True
        '    Me.RadioButton5.Enabled = True
        '    Me.cbxCapital.Enabled = True
        '    Me.cbxInteres.Enabled = True
        '    Me.pnCuoSug.Enabled = True
        'End If

        Me.txtMonSol.Enabled = True
        Me.txtnMonApr.Enabled = True
        Me.txtFecDes.Enabled = True

        'Me.txtfecpri.Enabled = True

        Valida_Linea_Credito()

        cbxprograma.Enabled = True


        Me.Datagrid1.Enabled = True

        If Me.cbxgrupos.Value.Trim = "" Then
            'Cambior a false
            Me.btnPlan.Disabled = True
            Me.btnGrabar.Disabled = False
        Else
            Me.btnPlan.Disabled = False
            Me.btnGrabar.Disabled = True
        End If
        Dim ds As New DataSet
        Dim clscretlin As New cCretlin


        cbxLineas.Enabled = True
        'ds = clscretlin.RecuperarporFuente(cbxprograma.SelectedValue.Trim, Me.txtCredito.Text.Trim.Substring(6, 2))

        'If ds.Tables(0).Rows.Count = 0 Then
        '    Me.cbxLineas.Enabled = False
        '    Me.btnPlan.Disabled = True
        'Else
        '    Me.cbxLineas.Enabled = True
        '    Me.btnPlan.Disabled = False
        'End If
        '*******************************************
        '20072015
        'Envia dato para el refresh
        RaiseEvent caputurado(txtccodsol.Text)
        'Response.Redirect("WBSUGLOTE.ASPX")
    End Sub
    
    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        txtbandera.Text = "1"
        Label15.Visible = True
        cbxrechazo.Visible = True
    End Sub
    Private Sub CargaVariables()
        ViewState.Add("pcnomcli", "") 'nombre de cliente
        ViewState.Add("pcdestino", "") 'destino
        ViewState.Add("pcdeslin", "") 'nombre de linea
        ViewState.Add("pctippre", "") ' tipo de credito
        ViewState.Add("pcfuente", "") 'fuente de fondos
        ViewState.Add("pctasa", "") 'tasa de interes
        ViewState.Add("pcagencia", "") 'agencia
        ViewState.Add("pnmonsug", 0) 'monto sugerido
        ViewState.Add("pctasmor", "") ' tasa moratoria
        ViewState.Add("pcmeses", "") 'meses
        ViewState.Add("pcnomchq", "") ' Cheque a nombre de 
        ViewState.Add("pdfecha", Today()) ' fecha de desembolso
        ViewState.Add("pcgarantia", "") 'Garantias
        ViewState.Add("pccanLet", "") ' cantidad en letras
        ViewState.Add("pncuota", 0) 'cuota sugerida
        ViewState.Add("pctipo", "") 'tipo de garantia
        ViewState.Add("pcforpag", "") ' forma de pago
        ViewState.Add("pcnomana", "") ' nombre de analista
        ViewState.Add("pccontrato", "") 'tipo de contrato
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState.Add("pcComite1", "") 'comite de credito nivel 1
        ViewState.Add("pcComite2", "") 'comite de credito nivel 2
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ' comisiones '
        ViewState.Add("pncom1", 0)
        ViewState.Add("pccom1", "")

        ViewState.Add("pncom2", 0)
        ViewState.Add("pccom2", "")

        ViewState.Add("pncom3", 0)
        ViewState.Add("pccom3", "")

        ViewState.Add("pncom4", 0)
        ViewState.Add("pccom4", "")

        ViewState.Add("pncom5", 0)
        ViewState.Add("pccom5", "")

        ViewState.Add("pncom6", 0)
        ViewState.Add("pccom6", "")
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState.Add("pndeuda", 0) 'valor a refinanciar
        ViewState.Add("pccreref", "") 'credito a ser refinanciado
    End Sub
    Private Sub ImprimirIA()
        Dim dsgarantias As New DataSet
        Dim mclimgar As New cClimgar
        Try

            dsgarantias = mclimgar.ObtenerDataSetPorID(Me.txtcCodCli.Text.Trim)
        Catch ex As Exception

        End Try

        'Imprime Plan de Pagos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        Dim reportes As String
        reportes = "CrPreIA.pdf"

        Dim crRptIA As New ReportDocument
        Dim rptStreamIA As New System.IO.MemoryStream

        Try
            'Cargar Definicion del Reporte
            crRptIA.Load(Server.MapPath("reportes") + "\CrPreAprobado.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try
        crRptIA.SetDataSource(dsgarantias.Tables(0))
        crRptIA.Refresh()

        Dim pccodcta1 As String
        Dim pccodcli1 As String
        Dim pcnomana1 As String

        pccodcta1 = pcCodCta
        pccodcli1 = Me.txtcCodCli.Text.Trim
        pcnomana1 = Me.txtNomAna.Text.Trim

        crRptIA.SetParameterValue("lcnomcli", ViewState("pcnomcli"))
        crRptIA.SetParameterValue("lcdestino", ViewState("pcdestino"))
        crRptIA.SetParameterValue("lcdeslin", ViewState("pcdeslin"))
        crRptIA.SetParameterValue("lctippre", ViewState("pctippre"))
        crRptIA.SetParameterValue("lcfondos", ViewState("pcfuente"))
        crRptIA.SetParameterValue("lctasa", ViewState("pctasa"))
        crRptIA.SetParameterValue("lcagencia", ViewState("pcagencia"))
        crRptIA.SetParameterValue("lnmonsug", ViewState("pnmonsug"))
        crRptIA.SetParameterValue("lctasmor", ViewState("pctasmor"))
        crRptIA.SetParameterValue("lcmeses", lnmeses.ToString)
        crRptIA.SetParameterValue("lcnomchq", ViewState("pcnomchq"))
        crRptIA.SetParameterValue("ldfecha", ViewState("pdfecha"))
        crRptIA.SetParameterValue("lcgarantia", "") 'poner suma de garantias
        crRptIA.SetParameterValue("lccanlet", ViewState("pccanlet"))
        crRptIA.SetParameterValue("lncuosug", ViewState("pncuota"))
        crRptIA.SetParameterValue("lctipo", ViewState("pctipo"))
        crRptIA.SetParameterValue("lcforpag", ViewState("pcforpag"))
        crRptIA.SetParameterValue("lccodcta", pccodcta1)
        crRptIA.SetParameterValue("lccodcli", pccodcli1)
        crRptIA.SetParameterValue("lcnomana", pcnomana1)
        crRptIA.SetParameterValue("lccontrato", ViewState("pccontrato"))
        crRptIA.SetParameterValue("lccomite1", ViewState("pccomite1"))
        crRptIA.SetParameterValue("lccomite2", ViewState("pccomite2"))

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Comisiones
        crRptIA.SetParameterValue("lncom1", ViewState("pncom1"))
        crRptIA.SetParameterValue("lccom1", ViewState("pccom1"))

        crRptIA.SetParameterValue("lncom2", ViewState("pncom2"))
        crRptIA.SetParameterValue("lccom2", ViewState("pccom2"))

        crRptIA.SetParameterValue("lncom3", ViewState("pncom3"))
        crRptIA.SetParameterValue("lccom3", ViewState("pccom3"))

        crRptIA.SetParameterValue("lncom4", ViewState("pncom4"))
        crRptIA.SetParameterValue("lccom4", ViewState("pccom4"))

        crRptIA.SetParameterValue("lncom5", ViewState("pncom5"))
        crRptIA.SetParameterValue("lccom5", ViewState("pccom5"))

        crRptIA.SetParameterValue("lncom6", ViewState("pncom6"))
        crRptIA.SetParameterValue("lccom6", ViewState("pccom6"))

        crRptIA.SetParameterValue("lndeuda", ViewState("pndeuda"))
        crRptIA.SetParameterValue("lccreref", ViewState("pccreref"))

        rptStreamIA = CType(crRptIA.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)
        Response.Clear()
        Response.Buffer = True
        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Response.BinaryWrite(rptStreamIA.ToArray())
        'Response.End()
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStreamIA.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        Response.Flush()
        Response.Close()
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

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
                    ViewState("pncom1") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom1") = "X"
                ElseIf lctipgas = "03" And lngasto <> 0 Then
                    ViewState("pncom2") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom2") = "X"
                ElseIf lctipgas = "04" And lngasto <> 0 Then
                    ViewState("pncom3") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom3") = "X"
                ElseIf lctipgas = "PR" And lngasto <> 0 Then
                    ViewState("pncom4") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom4") = "X"
                ElseIf (lctipgas = "HI" Or lctipgas = "08") And lngasto <> 0 Then
                    ViewState("pncom5") = xydata.Tables(0).Rows(xy)("nmongas")
                    ViewState("pccom5") = "X"
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
            ViewState("pndeuda") = 0
            ViewState("pccreref") = ""
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
            ViewState("pndeuda") = deuda
            ViewState("pccreref") = pcref
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


    End Sub
    Private Sub FormaPago()
        Dim lcforma As String
        If lctipper = "2" Then  'Fecha Fija
            lcforma = "MENSUALES"
        Else 'Periodo Fijo
            If lndiasug = 1 Then
                lcforma = "DIARIAS"
            ElseIf lndiasug = 7 Or lndiasug = 8 Then
                lcforma = "SEMANALES"
            ElseIf lndiasug = 14 Or lndiasug = 15 Then
                lcforma = "QUINCENALES"
            ElseIf lndiasug >= 28 And lndiasug <= 31 Then
                lcforma = "MENSUALES"
            ElseIf lndiasug = 60 Then
                lcforma = "BIMENSUALES"
            ElseIf lndiasug = 90 Then
                lcforma = "TRIMESTRALES"
            ElseIf lndiasug = 120 Then
                lcforma = "CADA CUATRO MESES"
            ElseIf lndiasug = 180 Then
                lcforma = "SEMESTRALES"
            ElseIf lndiasug >= 360 And lndiasug <= 365 Then
                lcforma = "ANUALES"
            Else
                lcforma = "NO DEFINIDO"
            End If
        End If

        ViewState("pcforpag") = Me.pnCuoSug.Text.ToString & " CUOTAS " & lcforma & " de $" & clase.pnmonCuo.ToString & " c/u. que comprende capital, intereses , seguro de deuda y comisiones por administración"
        If lndiasug = 1 Then
            ViewState("pcforpag") = "una cuota al vencimientode $ " & clase.pnmonCuo.ToString & " c/u. que comprende capital, intereses , seguro de deuda y comisiones por administración"
        End If
    End Sub
    Private Sub Meses()
        If lctipper = "1" Then 'Periodo Fijo
            Select Case lndiasug
                Case lndiasug = 7
                    lnmeses = CInt(Me.pnCuoSug.Text / 4)
                Case lndiasug = 14
                    lnmeses = CInt(Me.pnCuoSug.Text / 2)
                Case lndiasug = 15
                    lnmeses = CInt(Me.pnCuoSug.Text / 2)
                Case lndiasug = 30
                    lnmeses = CInt(Me.pnCuoSug.Text)
                Case lndiasug = 31
                    lnmeses = CInt(Me.pnCuoSug.Text)
                Case lndiasug = 60
                    lnmeses = CInt(Me.pnCuoSug.Text * 2)
                Case lndiasug = 90
                    lnmeses = CInt(Me.pnCuoSug.Text * 3)
                Case lndiasug = 120
                    lnmeses = CInt(Me.pnCuoSug.Text * 4)
                Case lndiasug = 360
                    lnmeses = CInt(Me.pnCuoSug.Text * 12)
                Case lndiasug = 365
                    lnmeses = CInt(Me.pnCuoSug.Text * 12)
                Case Else
                    lnmeses = Me.pnCuoSug.Text
            End Select
        Else 'Fecha Fija
            lnmeses = Me.pnCuoSug.Text
        End If
    End Sub

    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Private Sub GrabaDatosMiembro()
        ''Verifica filtro de requisitos

        'Dim laprobar As Boolean
        'laprobar = clase.RequisitosChequeados(Me.txtCredito.Text.Trim.Substring(6, 2), Me.cbxgrupos.Value.Trim)
        'If laprobar = False Then
        '    Response.Write("<script language='javascript'>alert('Faltan Requisitos' )</script>")
        '    Exit Sub
        'End If



        Dim xy As Integer
        xy = 0
        Dim lccodcta As String
        Dim lnmonsug As Double = 0

        Dim lcnomcli As String
        Dim nmonto As TextBox
        Dim lcmonsug As String

        For xy = 0 To Me.Datagrid1.Items.Count - 1
            lccodcta = Me.Datagrid1.Items(xy).Cells(0).Text
            lcnomcli = Me.Datagrid1.Items(xy).Cells(1).Text
            nmonto = CType(Me.Datagrid1.Items(xy).FindControl("Textbox2"), TextBox)

            'lcmonsug = Me.Datagrid1.Items(xy).Cells(3).Text
            lnmonsug = Double.Parse(nmonto.Text) 'Double.Parse(lcmonsug.Replace("Q", ""))
            Me.IgualaDatosaGrabar(lccodcta, lnmonsug)
            'Me.GeneraPlandepagos(lccodcta, lnmonsug)
            GrabarClick()



        Next

        Dim tipo As String
        Dim nombre As String
        tipo = Me.cbxContrato.SelectedValue.Trim

        If Me.cbxContrato.Visible = True Then
            If tipo = "A" Then
                nombre = "bancocomunal"
                contratos(nombre, "A")
            End If
            If tipo = "F" Then
                nombre = "gruposolidario"
                contratos(nombre, "F")
            End If

        End If

        Me.btnGrabar.Disabled = True
        Me.btnPlan.Disabled = True

        'Response.Write("<script language='javascript'>alert('Sugerencia Grabada')</script>")
        codigoJs = "<script language='javascript'>alert('Linea Inválida, Verificar Plazo y/o Monto, " & _
                   "Advertencia SIM.NET ')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


    End Sub
    Private Sub IgualaDatosaGrabar(ByVal lccodcta As String, ByVal lnmonsug As Double)

        pcCodCta = lccodcta
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
        'lnTasa = entidadCretlin.ntasint
        lnTasa = Double.Parse(txttasa.Text)
        ViewState("pctasmor") = entidadCretlin.ntasmor.ToString
        ViewState("pctasa") = Math.Round(lnTasa, 2).ToString
        ViewState("pcagencia") = Me.cbxcodofi.SelectedItem.Text
        ViewState("pnmonsug") = lnmonsug
        clase.lliva = entidadCretlin.lliva

        If lnmonsug <= 5000 Then
            ViewState("pccomite1") = "X"
            ViewState("pccomite2") = ""
        Else
            ViewState("pccomite2") = "X"
            ViewState("pccomite1") = ""
        End If
        '>>>>>>>>>>>>>>>>>>>>>>
        Dim mclimide As New cClimide
        Dim eclimide As New climide

        eclimide.ccodcli = Me.txtcCodCli.Text.Trim
        mclimide.ObtenerClimide(eclimide)
        clase.lsegvid = eclimide.lsegvida

        Dim entidadcreditos As New creditos
        entidadcreditos.ccodcta = Me.txtCredito.Text.Trim
        eCremcre.Obtenercreditos(entidadcreditos)
        clase.nMeses = clase.PlazoMeses(IIf(IsDBNull(entidadcreditos.dfecvig), Session("gdfecsis"), entidadcreditos.dfecvig), _
                                        IIf(IsDBNull(entidadcreditos.dfecven), Session("gdfecsis"), entidadcreditos.dfecven))

        'clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)
        'localiza fuente de fondos en base a cCodlin
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        lccodlin = entidadCretlin.ccodlin
        Dim clstabttab As New cTabttab
        Dim ds033 As New DataSet
        Dim lcfondos As String
        Dim nelemf As Integer
        lcfondos = lccodlin.ToString.Substring(2, 2).Trim
        clase.cCodfue = lcfondos
        ds033 = clstabttab.ObtenerDataSetPorID2("033", "1", lcfondos)
        nelemf = ds033.Tables(0).Rows.Count
        If nelemf = 0 Then
            ViewState("pcfuente") = ""
        Else
            ViewState("pcfuente") = ds033.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        Dim entidadCredchq As New credchq
        Dim ecredchq As New cCredchq
        entidadCredchq.ccodcta = pcCodCta
        ecredchq.ObtenercredchqPorllave(entidadCredchq)
        ViewState("pcnomchq") = entidadCredchq.cnomchq
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        ViewState("pdfecha") = Date.Parse(Me.txtFecDes.Text)
        '        Me.txtfecpri.Text = Today.AddMonths(1)

        If Me.RadioButton1.Checked = True Then
            lcTipPer = "1"
            lcFlat = ""
        ElseIf Me.RadioButton5.Checked = True Then
            lcTipPer = "5"
            lcFlat = "F"
        ElseIf Me.RadioButton4.Checked = True Then
            lcTipPer = "6"
            lcFlat = ""
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        clase.dFecDes = Date.Parse(Me.txtFecDes.Text)
        clase.dfecpri = Date.Parse(Me.txtfecpri.Text)

        clase.gnperbas = Session("gnperbas")
        clase.nMonDes = lnmonsug 'Integer.Parse(Me.txtnMonApr.Text)
        clase.nTasInt = Double.Parse(lnTasa)
        'clase.cCodFor = lnTipCuo
        'clase.nPerDia = Integer.Parse(Me.pnDiaSug.Text)
        clase.nPerDia = clase.periodo(Me.cbxInteres.SelectedValue.Trim)

        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        'clase.cTipCuo = lcTipPer
        clase.cTipCuo = lcTipPer
        clase.cTipEst = "N"
        'clase.nDiaGra = Integer.Parse(Me.pnPerGra.Text)
        clase.nTipPer = 1
        clase.cTipCal = "F"
        clase.lFlat = False
        clase.lRedo = False
        clase.cFlat = lcFlat

        clase.ngastos1 = 0
        clase.nNroCuo0 = 0

        If txtbandera.Text.Trim = "1" Then
            clase.cCodRec = cbxrechazo.Value.Trim
        End If


        ' clase.nMeses = Integer.Parse(Me.txtnmeses.Text)
        clase.pcCodCre = pcCodCta

        If Me.cbxCapital.SelectedValue.Trim = "Q" Or Me.cbxCapital.SelectedValue.Trim = "S" Then
            clase.cCodFor = 1
        Else
            clase.cCodFor = IIf(cbxCapital.SelectedValue.Trim = "X", 1, lnTipCuo)
        End If


        'clase.cTipCuo = Me.txtcTipCuo.Text
        'clase.nPerDia = Me.txtnperdia.Text
        clase.nDiaGra = Me.txtndiaGra.Text
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        If clase.cCodFor = "2" Then
            clase.nPerDia = Day(clase.dFecDes)
        End If
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><
        ViewState("pcnomcli") = Me.txtcNomcli.Text
        'Dim ctabttab As New cTabttab
        'Dim ds005 As New DataSet
        'Dim nelemx As Integer
        'ds005 = ctabttab.ObtenerDataSetPorID("005", "1")
        'nelemx = ds005.Tables(0).Rows.Count
        'If nelemx = 0 Then
        ViewState("pcdestino") = lcdestino.Trim
        'Else
        '   viewstate("pcdestino") = ds005.Tables(0).Rows(0)("cdescri")
        'End If
        ViewState("pcdeslin") = Me.cbxLineas.SelectedItem.Text
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim lnDecimal As Double
        ViewState("pccanlet") = clsConvert.ConversionEnteros(lnmonsug)
        lnDecimal = clsConvert.ExtraeDecimales(lnmonsug)
        ViewState("pccanlet") = ViewState("pccanlet") & " " & lnDecimal.ToString & "/100" & " QUETZALES"
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        Dim dstipo As New DataSet
        Dim nelemgar As Integer
        Dim mcrepgar As New cCrepgar
        'dstipo = mcrepgar.ObtenerDataSetPorGravamen(Me.txtCredito.Text.Trim, Me.txtcCodCli.Text.Trim)
        dstipo = clase.Garantizados(Me.txtcCodCli.Text.Trim)
        nelemgar = dstipo.Tables(0).Rows.Count
        If nelemgar = 0 Then
            ViewState("pctipo") = ""
        ElseIf (nelemgar = 1) Then
            ViewState("pctipo") = dstipo.Tables(0).Rows(0)("cdescri")
        Else
            ViewState("pctipo") = "MIXTA"
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
            ViewState("pcgarantia") = ""
        Else
            Dim Fila As DataRow
            nelemg = 0
            For Each Fila In dsgar.Tables(0).Rows
                pcgar = dsgar.Tables(0).Rows(nelemg)("cdescri")
                garant = garant + " " + pcgar.Trim
                nelemg += 1
            Next
            ViewState("pcgarantia") = garant
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        Dim ds077 As New DataSet
        Dim lcdocu As String
        Dim nelemf1 As Integer
        lcdocu = Me.txtcontrato.Text
        ds077 = clstabttab.ObtenerDataSetPorID2("077", "1", lcdocu)
        nelemf = ds077.Tables(0).Rows.Count
        If nelemf1 = 0 Then
            ViewState("pccontrato") = ""
        Else
            ViewState("pccontrato") = ds077.Tables(0).Rows(0)("cdescri")
        End If
        '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        Me.Cargar_Gastos()
        Me.Meses()



    End Sub

    Private Sub GrabarClick()
        Dim eclimgar As New cClimgar
        Dim lnvalidapref As Integer
        lnvalidapref = eclimgar.ValidaGarantiaPref(Me.txtcCodCli.Text.Trim)

        Me.txtgarantias.Text = Session("nGrav") 'clase.Gravamen(pcCodCta, Me.txtcCodCli.Text.Trim)
        'Validaciones
        'If lnvalidapref = 1 Then

        'Else
        '    If Double.Parse(Me.txtnMonApr.Text) > Double.Parse(Me.txtgarantias.Text) And Me.txtccodsol.Text.Trim = "" Then
        '        Me.Label11.Visible = True
        '        Me.Label11.Text = "Monto Aprobado es mayor que garantía"
        '        Exit Sub
        '    Else
        '        Me.Label11.Visible = False
        '        Me.Label11.Text = ""
        '    End If
        'End If


        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)
        clase.dFecApr = Session("gdFecSis")
        clase.pcCodUsu = Session("gccodusu")
        clase.gnmoncuo = ViewState("pncuota")
        clase.nNroCuo = Integer.Parse(Me.pnCuoSug.Text)
        clase.cfreccap = Me.cbxCapital.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres.SelectedValue.Trim
        clase.cCodfue = Me.cbxprograma.SelectedValue.Trim

        clase.cCapacidad = ""
        clase.canalisis = ""
        clase.nNroCuo0 = 0

        'clase.Graba_Aprobacion("C")
        clase.Graba_Sugerencia()

        Label15.Visible = False
        cbxrechazo.Visible = False
        If txtbandera.Text.Trim = "1" Then
            'Response.Write("<script language='javascript'>alert('Solicitud Rechazada')</script>")
            codigoJs = "<script language='javascript'>alert('Solicitud Rechazada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        Else
            'ImprimirIA()
            'Response.Write("<script language='javascript'>alert('PRE-Aprobación Grabada')</script>")
        End If

    End Sub

    Private Function GeneraPlandepagos(ByVal p_ccodcta As String, ByVal p_nmonsug As Double) As Integer
        Dim dsplain As New DataSet
        Dim lnRetorno As Integer = 1
        IgualaDatosaGrabar(p_ccodcta, p_nmonsug)
        Dim entidad3 As New creditos
        Dim ecreditos As New ccreditos
        Dim i As Integer

        entidad3.ccodcta = p_ccodcta
        i = ecreditos.Obtenercreditos(entidad3)

        clase.pnComtra = Session("gnComTra")
        clase.pnSegVm = Session("gnSegVm1")

        clase.pcCodUsu = Session("gcCodUsu")
        clase.dFecsis = Session("gdFecSis")

        clase.cfreccap = Me.cbxCapital.SelectedValue.Trim
        clase.cfrecint = Me.cbxInteres.SelectedValue.Trim
        clase.pniva = Session("gnIVA")
        'clase.lliva = Me.lliva.Checked


        dsplain = clase.fxCreatePlain(-1, Double.Parse(Me.txtnmoncuo.Text))


        'Valida que el plan no venga negativo, si no se hizo un buen analisis de la cuota - monto - plazo - tasa, especial MEXICO
        If Double.Parse(Me.txtnmoncuo.Text) > 0 Then
            For Each fila As DataRow In dsplain.Tables(0).Rows
                If fila("nCapita") < 0 Then
                    lnRetorno = 0
                    Exit Function
                End If
            Next
        End If

        Dim nCanti3 As Integer
        nCanti3 = dsplain.Tables(0).Rows.Count()
        clase.PlanTeorico(dsplain.Tables(0), p_ccodcta)

        Me.txtdFecVen.Text = clase.dFecVen.ToString
        Me.txtvencimiento.Text = clase.dFecVen.ToString


        clase.pcTabGasx.Clear()
        clase.pcTabGasx.Tables.Clear()

        Dim lncuota As Decimal = 0
        lncuota = clase.ObtenerCuotaOficial(p_ccodcta)
        ViewState("pncuota") = lncuota

        clase.cCodRec = ""
        clase.cNrolin = Me.cbxLineas.SelectedItem.Value.Trim
        clase.dFecVen = Date.Parse(Me.txtdFecVen.Text.Trim)

        'Dim entidad_clidfin As New SIM.EL.clidfin
        'Dim eclidfin As New SIM.BL.cClidfin
        'entidad_clidfin.ccodcli = Me.cbxfueing.SelectedValue.Trim
        'eclidfin.ObtenerClidfinporCliente(entidad_clidfin) '(entidad_clidfin)
        clase.cCodfue = entidad3.ccodfue 'entidad_clidfin.ccodfue
        clase.cCodact = entidad3.ccodact

        If ViewState("causa") = "SI" Then
            clase.cCodRec = cbxrechazo.Value.Trim
        Else
            clase.cCodRec = ""
        End If
        clase.gnmoncuo = ViewState("pncuota")
        clase.lsegvid = False
        clase.cCapacidad = ""
        clase.canalisis = ""

        'Iguala Valores del plan de pagos
        'HiddenField5.Value = cbxLineas.SelectedValue.Trim
        'HiddenField6.Value = Double.Parse(txttasa.Text)
        'HiddenField7.Value = Integer.Parse(pnCuoSug.Text)
        'HiddenField8.Value = Double.Parse(txtmonSug.Text)
        '----------------------------------------------------------------
        clase.Graba_SugerenciaTmp()

        Session("cflag") = cbxCapital.SelectedValue.Trim


        Return lnRetorno

    End Function
    Private Sub CargaLineasxFondos(ByVal cCodfue As String)
        ' Me.cbxLineas.Items.Clear()

        Dim ds As New DataSet
        Dim clscretlin As New cCretlin
        '+++Revision
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++''
        ''***Se cambio de metodologia el dia 06-07-2015*****'''
        'If cbxLineas.SelectedIndex = 0 Then

        '    Exit Sub

        'End If
        ds = clscretlin.RecuperarporFuente(cCodfue, Me.txtCredito.Text.Trim.Substring(6, 2))
        'ds = clscretlin.Recuperarpor_Metodo("03") ' Me.HiddenField1.Value.Trim

        If ds.Tables(0).Rows.Count = 0 Then
            Me.cbxLineas.Enabled = False
            Me.btnPlan.Disabled = True
            btnGrabar.Disabled = True
            Return
        Else
            Me.cbxLineas.Enabled = True
            Me.btnPlan.Disabled = False
            btnGrabar.Disabled = True

        End If

        'If cbxLineas.SelectedIndex <> 0 Then

        '    btnAplicar.Disabled = False
        '    btnGrabar.Disabled = False
        '    btnPlan.Disabled = False
        '    Button2.Disabled = False
        '    Button1.Disabled = False
        'Else
        '    btnAplicar.Disabled = True
        '    btnGrabar.Disabled = True
        '    btnPlan.Disabled = True
        '    Button2.Disabled = True
        '    Button1.Disabled = True
        'End If

        Dim fila2 As Data.DataRow
        fila2 = ds.Tables("table").NewRow
        fila2("cdeslin") = "Seleccione una linea..."
        'Me.ds.Tables("table").Rows.Add(fila)
        ds.Tables(0).Rows.InsertAt(fila2, 0)

        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()

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


    Protected Sub cbxCapital_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxCapital.SelectedIndexChanged
        cargacombointeres()
    End Sub

    Sub contratos(ByVal contrato As String, ByVal tipocontrato As String)

        Dim input As String
        Dim lcnomcli As String
        Dim lcnombar As String
        Dim lcnombre As String
        Dim ecremsol As New cCremsol
        Me.txtcNomcli.Text = ecremsol.ObtenerNombre(Me.cbxgrupos.Value.Trim)
        'escribir
        lcnombre = Me.txtcNomcli.Text.Trim & ".doc"
        Const fsoLectura = 1
        Const fsoescritura = 2

        Dim objFSO
        'Instanciación del objeto FSO
        objFSO = Server.CreateObject("Scripting.FileSystemObject")

        'Abrir el archivo de texto
        Dim objTextStream
        objTextStream = objFSO.OpenTextFile("C:\wwwamiga\contratos2\" & lcnombre, fsoescritura, True)

        'determina que tipo de contrato elegir
        'segun modelos existentes
        Dim nombrecontrato As String
        If tipocontrato = "A" Then
            nombrecontrato = "bancocomunal"
        ElseIf tipocontrato = "F" Then
            nombrecontrato = "gruposolidario"
        End If

        'fin modelos de contratos

        'fin escribir
        lcnombar = nombrecontrato & ".txt"

        lcnombre = Me.txtcNomcli.Text.Trim
        'lee un archivo de texto
        Dim FILE_NAME As String = "c:/wwwamiga/contratos/" & lcnombar
        If Not File.Exists(FILE_NAME) Then
            Return
        End If

        Dim etabtofi As New cTabtofi
        Dim lcdepa As String = ""
        Dim lcmuni As String = ""
        Dim lcdireccion As String = ""
        lcdepa = etabtofi.NombreDepartamento(Session("gcCodofi"))
        lcmuni = etabtofi.NombreMunicipio(Session("gcCodofi"))
        lcdireccion = etabtofi.NombreDireccion(Session("gcCodofi"))

        Dim ldfecha As Date
        Dim lnmes As Integer
        Dim lndia As Integer
        Dim lnano As Integer
        Dim lcmes As String
        Dim lcfecha As String
        Dim lcano As String
        Dim lcdias As String
        Dim clsppal As New class1
        'fecha desembolso
        ldfecha = Date.Parse(Me.txtFecDes.Text)
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcmes = MonthName(lnmes)
        lcdias = clsppal.Num2Text(lndia).ToLower
        lcano = clsppal.Num2Text(lnano).ToLower

        Dim lndiav As Integer
        Dim lnmesv As Integer
        Dim lnanov As Integer
        Dim ldfecven As Date
        'fecha vencimiento
        ldfecven = Date.Parse(Me.txtdFecVen.Text)
        lndiav = ldfecven.Day
        lnmesv = ldfecven.Month
        lnanov = ldfecven.Year
        Dim lcdiasv As String
        Dim lcmesv As String
        Dim lcanov As String
        lcdiasv = clsppal.Num2Text(lndiav).ToLower
        lcanov = clsppal.Num2Text(lnanov).ToLower
        lcmesv = MonthName(lnmesv)

        Dim lcdoc As String = ""
        Dim lvalida As Boolean
        'Genera Bucle para capturar miembros del grupo
        Dim x As Integer = 0
        Dim lcdocumento As String = ""
        Dim lccodcta As String = ""
        Dim lccodcli As String = ""
        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre

        Dim entidadclimide As New climide
        Dim eclimide As New cClimide

        Dim etabtprf As New tabtprf
        Dim mtabtprf As New cTabtprf

        Dim lcedad As String = ""
        Dim lccodpro As String = ""
        Dim lcprofesion As String = ""


        Dim lcestciv As String = ""
        Dim lccivil As String = ""

        Dim etabttab As New cTabttab
        Dim lccadena As String = ""
        Dim lccadenacli As String = ""

        Dim lccodzona As String
        Dim entidadcremsol As New cremsol

        entidadcremsol.cCodsol = cbxgrupos.Value.Trim
        ecremsol.ObtenerCremsol(entidadcremsol)
        lccodzona = entidadcremsol.cCodzon

        Dim lcaldea As String = ""
        Dim lcmunic As String = ""
        Dim lcdepartamento As String = ""
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon

        etabtzon.ccodzon = lccodzona
        etabtzon.ctipzon = "3"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcaldea = etabtzon.cdeszon.Trim
        lcaldea = lcaldea.ToLower

        etabtzon.ccodzon = Left(lccodzona, 4)
        etabtzon.ctipzon = "2"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcmunic = etabtzon.cdeszon.Trim
        lcmunic = lcmunic.ToLower

        etabtzon.ccodzon = Left(lccodzona, 2)
        etabtzon.ctipzon = "1"
        mtabtzon.ObtenerTabtzon(etabtzon)
        lcdepartamento = etabtzon.cdeszon.Trim
        lcdepartamento = lcdepartamento.ToLower


        Dim lnmonto As Double = 0
        lnmonto = Double.Parse(Me.txtmonSug.Text)
        Dim lcmonto As String = ""
        Dim lcmontolet As String = ""
        Dim lcmontox As String = ""
        'Dim lnentero As Integer = 0
        'Dim lndeci As Integer = 0

        'lnentero = Decimal.Floor(lnmonto)
        'lndeci = Math.Round((lnmonto - lnentero) * 100)


        lcmontox = clsppal.Cominola(lnmonto.ToString.Trim)


        'Colocador de comas
        lcmonto = lnmonto.ToString.Trim
        lcmontolet = clsppal.Num2Text(lnmonto).Trim.ToLower

        Dim lccadenacli2 As String = ""
        Dim lccadena2 As String = ""
        Dim nmonto As TextBox
        Dim lnmonsug As Double = 0
        Dim lcmontoilet As String = ""
        Dim lnmeses As Integer = 0
        Dim lcmeses As String = ""

        lnmeses = DateDiff(DateInterval.Month, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))
        lcmeses = clsppal.Num2Text(lnmeses)

        Dim lcagencia As String
        lcagencia = etabtofi.NombreAgencia(Session("gcCodofi")).Trim.ToLower

        Dim lntasa As Double = 0
        Dim lctasa As String = ""
        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = Me.cbxLineas.SelectedItem.Value.Trim
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        'lntasa = entidadCretlin.ntasint
        lntasa = Double.Parse(txttasa.Text)
        Dim lnentero As Double = 0
        Dim lndeci As Double = 0
        lnentero = Decimal.Floor(lntasa)
        lndeci = Math.Round((lntasa - lnentero) * 100)
        If lndeci > 0 Then
            lctasa = clsppal.Num2Text(lnentero).ToLower & " " & " con " & clsppal.Num2Text(lndeci).ToLower & " por ciento"
        Else
            lctasa = clsppal.Num2Text(lnentero).ToLower & " por ciento "
        End If

        Dim lcbloque1 As String = ""
        Dim lcbloque2 As String = ""
        Dim lcbloque3 As String = ""
        Dim lcbloque4 As String = ""
        Dim lcbloque5 As String = ""
        Dim lcbloque6 As String = ""
        Dim lcbloque7 As String = ""
        Dim lcbloque8 As String = ""
        Dim lcbloque9 As String = ""
        Dim lcbloque10 As String = ""
        Dim lcbloque11 As String = ""
        Dim lcbloque12 As String = ""
        Dim lcbloque13 As String = ""
        Dim lcbloque14 As String = ""
        Dim lcbloque15 As String = ""
        Dim lcbloque16 As String = ""
        Dim lcbloque17 As String = ""
        Dim lcbloque18 As String = ""
        Dim lcbloque19 As String = ""
        Dim lcbloque20 As String = ""




        Dim lcbloque1a As String = ""
        Dim lcbloque2a As String = ""
        Dim lcbloque3a As String = ""
        Dim lcbloque4a As String = ""
        Dim lcbloque5a As String = ""
        Dim lcbloque6a As String = ""
        Dim lcbloque7a As String = ""
        Dim lcbloque8a As String = ""
        Dim lcbloque9a As String = ""
        Dim lcbloque10a As String = ""
        Dim lcbloque11a As String = ""
        Dim lcbloque12a As String = ""
        Dim lcbloque13a As String = ""
        Dim lcbloque14a As String = ""
        Dim lcbloque15a As String = ""
        Dim lcbloque16a As String = ""
        Dim lcbloque17a As String = ""
        Dim lcbloque18a As String = ""
        Dim lcbloque19a As String = ""
        Dim lcbloque20a As String = ""


        Dim co As Integer = 0

        For x = 0 To Me.Datagrid1.Items.Count - 1
            co += 1

            lcdoc = Me.Datagrid1.Items(x).Cells(2).Text
            lcnomcli = Me.Datagrid1.Items(x).Cells(1).Text
            lccodcta = Me.Datagrid1.Items(x).Cells(0).Text
            nmonto = CType(Me.Datagrid1.Items(x).FindControl("Textbox2"), TextBox)
            lnmonsug = Double.Parse(nmonto.Text)

            lcmontoilet = clsppal.Num2Text(lnmonsug).ToLower

            entidadcremcre.ccodcta = lccodcta.Trim
            ecremcre.ObtenerCremcre(entidadcremcre)
            lccodcli = entidadcremcre.ccodcli

            entidadclimide.ccodcli = lccodcli
            eclimide.ObtenerClimide(entidadclimide)

            lccodpro = entidadclimide.ccodpro
            lcestciv = entidadclimide.cestciv
            lccivil = etabttab.Describe(lcestciv, "012").Trim

            etabtprf.ccodigo = lccodpro
            mtabtprf.ObtenerTabtprf(etabtprf)
            lcprofesion = etabtprf.cdescri.Trim  ' profesion


            lcedad = clsppal.EdadLetras(entidadclimide.dnacimi).Trim


            lvalida = clsppal.ValidaCaracter(Left(lcdoc.Trim, 1))
            If lvalida = True Then 'Cedula
                lcdocumento = clsppal.LecturaCedula(lcdoc)
            Else 'DPI
                lcdocumento = clsppal.LecturaDPI(lcdoc)
            End If
            lccadenacli = lcnomcli.Trim & " " & lcedad & ", " & lccivil & ", " & lcprofesion & ", " & lcdocumento & ", "
            lccadenacli2 = lcnomcli.Trim & ", " & lcmontoilet & " quetzales (Q" & clsppal.Cominola(lnmonsug.ToString.Trim) & "); "
            lccadena = lccadena & lccadenacli
            lccadena2 = lccadena2 & lccadenacli2

            If co <= 2 Then
                lcbloque1 = lcbloque1 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque1a = lcbloque1a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 2 And co <= 4 Then
                lcbloque2 = lcbloque2 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque2a = lcbloque2a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 4 And co <= 6 Then
                lcbloque3 = lcbloque3 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque3a = lcbloque3a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 6 And co <= 8 Then
                lcbloque4 = lcbloque4 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque4a = lcbloque4a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 8 And co <= 10 Then
                lcbloque5 = lcbloque5 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque5a = lcbloque5a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 10 And co <= 12 Then
                lcbloque6 = lcbloque6 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque6a = lcbloque6a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 12 And co <= 14 Then
                lcbloque7 = lcbloque7 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque7a = lcbloque7a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 14 And co <= 16 Then
                lcbloque8 = lcbloque8 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque8a = lcbloque8a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 16 And co <= 18 Then
                lcbloque9 = lcbloque9 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque9a = lcbloque9a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 18 And co <= 20 Then
                lcbloque10 = lcbloque10 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque10a = lcbloque10a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 20 And co <= 22 Then
                lcbloque11 = lcbloque11 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque11a = lcbloque11a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 22 And co <= 24 Then
                lcbloque12 = lcbloque12 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque12a = lcbloque12a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 24 And co <= 26 Then
                lcbloque13 = lcbloque13 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque13a = lcbloque13a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 26 And co <= 28 Then
                lcbloque14 = lcbloque14 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque14a = lcbloque14a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 28 And co <= 30 Then
                lcbloque15 = lcbloque15 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque15a = lcbloque15a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 30 And co <= 32 Then
                lcbloque16 = lcbloque16 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque16a = lcbloque16a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 32 And co <= 34 Then
                lcbloque17 = lcbloque17 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque17a = lcbloque17a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 34 And co <= 36 Then
                lcbloque18 = lcbloque18 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque18a = lcbloque18a + clsppal.zeros(lcdoc, 40) + "     "
            ElseIf co > 36 And co <= 38 Then
                lcbloque19 = lcbloque19 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque19a = lcbloque19a + clsppal.zeros(lcdoc, 40) + "     "
            Else
                lcbloque20 = lcbloque20 + clsppal.zeros(lcnomcli, 40) + "     "
                lcbloque20a = lcbloque20a + clsppal.zeros(lcdoc, 40) + "     "
            End If
        Next


        Dim sr As StreamReader = File.OpenText(FILE_NAME)

        input = sr.ReadLine()


        While Not input Is Nothing
            input = sr.ReadLine()
            If input = "**" Then
                Exit While
            End If

            'Bienes 
            input = input.Replace("/*municipio/", lcmuni.Trim)
            input = input.Replace("/*departamento/", lcdepa.Trim)
            input = input.Replace("/*dias/", lcdias)
            input = input.Replace("/*mes/", lcmes)
            input = input.Replace("/*ano/", lcano)
            input = input.Replace("/*clientes/", lccadena)


            input = input.Replace("/*aldea/", lcaldea)
            input = input.Replace("/*munic/", lcmunic)
            input = input.Replace("/*departamento/", lcdepartamento)

            input = input.Replace("/*montolet/", lcmontolet)
            input = input.Replace("/*monto/", lcmontox)

            input = input.Replace("/*clientes2/", lccadena2)
            input = input.Replace("/*meses/", lcmeses)

            input = input.Replace("/*diasv/", lcdiasv)
            input = input.Replace("/*mesv/", lcmesv)
            input = input.Replace("/*anov/", lcanov)

            input = input.Replace("/*agencia/", lcagencia)
            input = input.Replace("/*direccion/", lcdireccion)
            input = input.Replace("/*tasalet/", lctasa)
            input = input.Replace("/*tasa/", lntasa.ToString.Trim)

            input = input.Replace("/*cbloque1/", lcbloque1)
            input = input.Replace("/*cbloque1a/", lcbloque1a)

            input = input.Replace("/*cbloque2/", lcbloque2)
            input = input.Replace("/*cbloque2a/", lcbloque2a)


            input = input.Replace("/*cbloque3/", lcbloque3)
            input = input.Replace("/*cbloque3a/", lcbloque3a)

            input = input.Replace("/*cbloque4/", lcbloque4)
            input = input.Replace("/*cbloque4a/", lcbloque4a)

            input = input.Replace("/*cbloque5/", lcbloque5)
            input = input.Replace("/*cbloque5a/", lcbloque5a)

            input = input.Replace("/*cbloque6/", lcbloque6)
            input = input.Replace("/*cbloque6a/", lcbloque6a)

            input = input.Replace("/*cbloque7/", lcbloque7)
            input = input.Replace("/*cbloque7a/", lcbloque7a)

            input = input.Replace("/*cbloque8/", lcbloque8)
            input = input.Replace("/*cbloque8a/", lcbloque8a)

            input = input.Replace("/*cbloque9/", lcbloque9)
            input = input.Replace("/*cbloque9a/", lcbloque9a)

            input = input.Replace("/*cbloque10/", lcbloque10)
            input = input.Replace("/*cbloque10a/", lcbloque10a)

            input = input.Replace("/*cbloque11/", lcbloque11)
            input = input.Replace("/*cbloque11a/", lcbloque11a)

            input = input.Replace("/*cbloque12/", lcbloque12)
            input = input.Replace("/*cbloque12a/", lcbloque12a)

            input = input.Replace("/*cbloque13/", lcbloque13)
            input = input.Replace("/*cbloque13a/", lcbloque13a)

            input = input.Replace("/*cbloque14/", lcbloque14)
            input = input.Replace("/*cbloque14a/", lcbloque14a)

            input = input.Replace("/*cbloque15/", lcbloque15)
            input = input.Replace("/*cbloque15a/", lcbloque15a)

            input = input.Replace("/*cbloque16/", lcbloque16)
            input = input.Replace("/*cbloque16a/", lcbloque16a)

            input = input.Replace("/*cbloque17/", lcbloque17)
            input = input.Replace("/*cbloque17a/", lcbloque17a)

            input = input.Replace("/*cbloque18/", lcbloque18)
            input = input.Replace("/*cbloque18a/", lcbloque18a)

            input = input.Replace("/*cbloque19/", lcbloque19)
            input = input.Replace("/*cbloque19a/", lcbloque19a)

            input = input.Replace("/*cbloque20/", lcbloque20)
            input = input.Replace("/*cbloque20a/", lcbloque20a)

            'A ruego
            'input = input.Replace("/*aruego/", "")

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

        Me.DownloadFile("C:\wwwFSOL\contratos2\" & lcnombre.Trim & ".doc", lcnombre.Trim & ".doc")

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
        Response.ContentType = "Application/msword" '"text/plain"
        '"Application/x-msexcel"
        'End If

        Response.WriteFile(filepath)
        Response.End()

    End Sub
    Private Sub CargaContratos(ByVal ctipo As String)
        'Variable de la clase Mantenimiento
        Dim lnparametro1_R As String
        Dim lnparametro2_R As String
        Dim lnparametro3_R As String
        Dim lnparametro4_R As String
        Dim lnparametro5_R As String
        Dim lnparametro6_R As String
        Dim ds As New DataSet

        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0771' and left(coordinado,2) = " & "'" & ctipo & "'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            'MsgBox("No existen Tipos de Contrato", MsgBoxStyle.Information, "Aviso")
            'Exit Sub
        End If
        Me.cbxContrato.DataTextField = "cDescri"
        Me.cbxContrato.DataValueField = "cCodigo"
        Me.cbxContrato.DataSource = ds.Tables("Resultado")
        Me.cbxContrato.DataBind()

        ds.Tables("Resultado").Clear()

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        Dim clscretlin As New cCretlin

        ds = clscretlin.RecuperarporCartera(ddlcartera.SelectedValue.Trim, "03", Me.HiddenField1.Value.Trim)

        Me.cbxLineas.DataTextField = "cdeslin"
        Me.cbxLineas.DataValueField = "cNrolin"
        Me.cbxLineas.DataSource = ds
        Me.cbxLineas.DataBind()


        CargaTasas(cbxLineas.SelectedValue.Trim)
    End Sub

    Private Sub Dictamen()
        Dim lccodcli As String = ""
        Dim lcnomcli As String = ""
        Dim lcdirdom As String = ""
        Dim lccapacidad As String = ""
        Dim lcanalisis As String = ""
        Dim lcdepartamento As String = ""
        Dim lcmunicipio As String = ""
        Dim etabtzon As New tabtzon
        Dim mtabtzon As New cTabtzon
        Dim lccoddom As String = ""
        Dim lcsexo As String = ""
        Dim lcsexo1 As String = ""
        Dim lcactividad As String = ""
        Dim lccodact As String = ""
        Dim lcsector As String = ""

        Dim i As Integer = 0
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab
        Dim reportes As String = ""
        Dim ecremsol As New cCremsol
        Dim lnmonsol As Double = 0

        Dim ds As New DataSet
        ds = ecreditos.ListadoCreditosxGrupoSugerencia(cbxgrupos.Value.Trim)

        Dim ds1 As New DataSet
        Dim lnmiembros As Integer = 0
        lnmiembros = ds.Tables(0).Rows.Count

        Dim lccodcta As String = ""
        Dim eclimgar As New cClimgar

        Dim lctipogar As String = ""
        Dim lnmontas As Double = 0
        Dim lnmongra As Double = 0


        Dim fila As DataRow
        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("ccodcta")
            lccodcli = fila("ccodcli")
            lnmonsol = lnmonsol + fila("nmonsug")

            'obtener garantias
            ds1 = eclimgar.ObtenerDataSetGravamen(lccodcli, lccodcta)
            If ds1.Tables(0).Rows.Count = 0 Then
            Else
                If IsDBNull(ds1.Tables(0).Rows(0)("ctipdes")) Then
                Else
                    fila("ctipogar") = etabttab.Describe(ds1.Tables(0).Rows(0)("ctipdes"), "044")
                End If
                fila("nmontas") = ds1.Tables(0).Rows(0)("nmontas")
                fila("nmongra") = ds1.Tables(0).Rows(0)("nmongra")
                fila("cnotario") = ds1.Tables(0).Rows(0)("cnotario")
            End If
        Next

        entidad3.ccodcta = lccodcta
        i = ecreditos.Obtenercreditos(entidad3)

        lccodcli = lccodcli
        lcnomcli = ecremsol.ObtenerNombre(Me.cbxgrupos.Value.Trim)



        lccapacidad = IIf(IsDBNull(entidad3.ccapacidad), "", entidad3.ccapacidad.Trim)
        lcanalisis = IIf(IsDBNull(entidad3.canalisis), "", entidad3.canalisis.Trim)
        lcsexo = IIf(entidad3.csexo.Trim = "M", "X", "")
        lcsexo1 = IIf(entidad3.csexo.Trim = "M", " ", "X")

        Dim entidadcremsol As New cremsol
        entidadcremsol.cCodsol = cbxgrupos.Value.Trim
        ecremsol.ObtenerCremsol(entidadcremsol)

        Dim eciiu As New cTabtciu
        Dim lcdestino As String

        lcsector = etabttab.Describe(entidad3.csececo, "021")
        If IsDBNull(entidad3.cdescre) Then
            entidad3.cdescre = ""
        End If
        lcdestino = etabttab.Describe(entidad3.cdescre, "005")
        lccodact = entidad3.ccodact
        lcactividad = eciiu.CIIU(lccodact)


        lccoddom = entidadcremsol.cCodzon
        lcdirdom = entidadcremsol.cdirdom.Trim




        'obtiene municipio y departamento
        If lccoddom.Trim = "" Then
        Else
            etabtzon.ccodzon = lccoddom.Substring(0, 4)
            etabtzon.ctipzon = "2"
            mtabtzon.ObtenerTabtzon(etabtzon)
            lcmunicipio = etabtzon.cdeszon.Trim
            lcmunicipio = lcmunicipio.ToUpper
            'departamento
            etabtzon.ccodzon = lccoddom.Substring(0, 2)
            etabtzon.ctipzon = "1"
            mtabtzon.ObtenerTabtzon(etabtzon)
            lcdepartamento = etabtzon.cdeszon.Trim
            lcdepartamento = lcdepartamento.ToUpper
        End If


        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If i = 0 Then
            Exit Sub


        End If
        reportes = "crDictameng.doc"
        crRpt1.Load(Server.MapPath("reportes") + "\crDictameng.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt1.SetDataSource(ds.Tables(0))

        crRpt1.Refresh()
        crRpt1.SetParameterValue("cnomcli", lcnomcli)
        crRpt1.SetParameterValue("cdirdom", lcdirdom)
        crRpt1.SetParameterValue("ccapacidad", lccapacidad)
        crRpt1.SetParameterValue("canalisis", lcanalisis)
        crRpt1.SetParameterValue("cdepartamento", lcdepartamento)
        crRpt1.SetParameterValue("cmunicipio", lcmunicipio)
        crRpt1.SetParameterValue("csexo", lcsexo)
        crRpt1.SetParameterValue("csexo1", lcsexo1)
        crRpt1.SetParameterValue("cactividad", lcsector.Trim & ", " & lcactividad)
        crRpt1.SetParameterValue("cdestino", lcdestino)
        crRpt1.SetParameterValue("cusuarios", lnmiembros)
        crRpt1.SetParameterValue("nmonsol", lnmonsol)

        rptStream1 = CType(crRpt1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True

        ' Establece el tipo de documento
        Response.ContentType = "application/msword"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub

    'Protected Sub btnpagina1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpagina1.Click
    '    Dictamen()
    'End Sub

    'Protected Sub btnpagina2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpagina2.Click
    '    Dictamen2()
    'End Sub
    Private Sub Dictamen2()
        Dim lccodcli As String = ""
        Dim lcnomcli As String = ""
        Dim lnmonsug As Double = 0
        Dim lcfreccap As String = ""
        Dim lcopcion1, lcopcion2, lcopcion3, lcopcion4 As String

        Dim i As Integer = 0
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        Dim etabttab As New cTabttab

        Dim ds As New DataSet
        ds = ecreditos.ListadoCreditosxGrupoSugerencia(cbxgrupos.Value.Trim)

        Dim lccodcta As String = ""
        Dim lnmonsol As Double = 0
        Dim fila As DataRow
        For Each fila In ds.Tables(0).Rows
            lccodcta = fila("ccodcta")
            lccodcli = fila("ccodcli")
            lnmonsol = lnmonsol + fila("nmonsug")

        Next

        Dim ldfecha As Date
        Dim lnmes As Integer
        Dim lcmes As String
        Dim lndia As Integer
        Dim lcdias As String
        Dim lnano As Integer
        Dim lcanio As String


        ldfecha = Session("gdfecsis")
        lnmes = ldfecha.Month
        lndia = ldfecha.Day
        lnano = ldfecha.Year
        lcanio = lnano.ToString.Trim
        lcmes = clase.MES(lnmes)
        lcdias = lndia.ToString.Trim

        Dim lnmeses As Integer

        Dim reportes As String = ""

        entidad3.ccodcta = lccodcta
        i = ecreditos.Obtenercreditos(entidad3)

        lccodcli = Me.txtcCodCli.Text.Trim
        lcnomcli = Me.txtcNomcli.Text.Trim
        lnmonsug = lnmonsol
        lcfreccap = entidad3.cfreccap.Trim
        lnmeses = entidad3.nmeses

        If lcfreccap = "M" Then 'mensual
            lcopcion1 = "X"
            lcopcion2 = ""
            lcopcion3 = ""
            lcopcion4 = ""
        ElseIf lcfreccap = "I" Then 'bimensual
            lcopcion1 = ""
            lcopcion2 = "X"
            lcopcion3 = ""
            lcopcion4 = ""

        ElseIf lcfreccap = "T" Then 'trimestral
            lcopcion1 = ""
            lcopcion2 = ""
            lcopcion3 = "X"
            lcopcion4 = ""
        Else
            lcopcion4 = "X"
            If lcfreccap = "C" Then
                lcopcion4 = "Cuatrimestral"
            ElseIf lcfreccap = "A" Then
                lcopcion4 = "Vencimiento"
            ElseIf lcfreccap = "E" Then
                lcopcion4 = "Semestral"
            End If
            lcopcion1 = ""
            lcopcion2 = ""
            lcopcion3 = ""

        End If

        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If i = 0 Then
            Exit Sub


        End If
        reportes = "crDictameng2.doc"
        crRpt1.Load(Server.MapPath("reportes") + "\crDictameng2.rpt", OpenReportMethod.OpenReportByDefault)
        'crRpt1.SetDataSource(dsh.Tables(0))

        crRpt1.Refresh()
        crRpt1.SetParameterValue("nmonsug", lnmonsug)
        crRpt1.SetParameterValue("cmeses", ((lnmeses).ToString.Trim & " meses"))
        crRpt1.SetParameterValue("pcopcion1", lcopcion1)
        crRpt1.SetParameterValue("pcopcion2", lcopcion2)
        crRpt1.SetParameterValue("pcopcion3", lcopcion3)
        crRpt1.SetParameterValue("pcopcion4", lcopcion4)
        crRpt1.SetParameterValue("ctasa", ViewState("pctasa"))


        crRpt1.SetParameterValue("cdia", lcdias)
        crRpt1.SetParameterValue("cmes", lcmes)
        crRpt1.SetParameterValue("canio", lcanio)

        crRpt1.SetParameterValue("cnomana", Me.txtNomAna.Text.Trim)

        rptStream1 = CType(crRpt1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.WordForWindows), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True

        ' Establece el tipo de documento
        Response.ContentType = "application/msword"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()
    End Sub
    Private Sub GrabaResumenParaComite()
        Dim reportes As String = "ComiteGrupal.pdf"
        Dim ecreditos As New ccreditos
        Dim ds As New DataSet
        Dim lnmeses As Integer = 0
        lnmeses = DateDiff(DateInterval.Month, Date.Parse(Me.txtFecDes.Text), Date.Parse(Me.txtdFecVen.Text))
        ds = ecreditos.ListadoCreditosxGrupoSugerencia(cbxgrupos.Value.Trim)

        Dim lnmiembros As Integer = 0
        lnmiembros = ds.Tables(0).Rows.Count

        Dim crRpt1 As New ReportDocument
        Dim rptStream1 As New System.IO.MemoryStream

        If ds.Tables(0).Rows.Count = 0 Then
            Exit Sub
        End If

        crRpt1.Load(Server.MapPath("reportes") + "\crComiteGrupal.rpt", OpenReportMethod.OpenReportByDefault)
        crRpt1.SetDataSource(ds.Tables(0))

        crRpt1.Refresh()
        crRpt1.SetParameterValue("pcmeses", lnmeses.ToString)
        crRpt1.SetParameterValue("pcfrecuencia", cbxCapital.SelectedItem.Text.Trim)
        crRpt1.SetParameterValue("pctasa", ViewState("pctasa"))
        rptStream1 = CType(crRpt1.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True

        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        Response.BinaryWrite(rptStream1.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

    End Sub
    Private Sub CargaTasas(ByVal cnrolin As String)
        Dim ecretlin As New cCretlin
        txttasa.Text = ecretlin.ObtenerTasaEstandar(cnrolin)
        HiddenField2.Value = ecretlin.ObtenerTasaMinima(cnrolin)
        HiddenField3.Value = ecretlin.ObtenerTasaMaxima(cnrolin)
        HiddenField4.Value = txttasa.Text
    End Sub
    'validnado
    Private Sub update_cremcre(ByVal ccodcta As String, ByVal nmonsug As Integer)
        Dim ecretlin As New cCretlin
        Dim retonro As Object


        retonro = ecretlin.UpdateCremcre(ccodcta, nmonsug)

    End Sub
    Private Sub CargarFondos()
        'Llenando Programa
        '----------------------------
        lnparametro1_R = "cDescri , left(cCodigo,2) as cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='0331'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        Me.cbxprograma.DataTextField = "cDescri"
        Me.cbxprograma.DataValueField = "cCodigo"
        Me.cbxprograma.DataSource = ds.Tables("Resultado")
        Me.cbxprograma.DataBind()
    End Sub

    Protected Sub cbxprograma_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxprograma.SelectedIndexChanged
        CargaLineasxFondos(cbxprograma.SelectedValue.Trim)
        ''CargarDatos()

        'validar tasa siempre que cambi de fondo se pone en cero y con la variable de seleccion
        txttasa.Text = 0.0
        txtnmoncuo.Text = 0.0
        pnCuoSug.Text = 0.0

        'HiddenField1.Value = cbxprograma.SelectedValue.Trim
    End Sub


End Class
