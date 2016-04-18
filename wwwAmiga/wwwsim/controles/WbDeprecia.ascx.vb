Option Explicit On
Option Infer On
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports System.IO
Imports System
Imports System.Text
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Linq.Queryable
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Globalization



Public Class WbDeprecia
    Inherits System.Web.UI.UserControl
   
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

#Region " Variables "
    Private cls1 As New SIM.bl.ClsMantenimiento
    Private clase As New SIM.bl.class1
    Private classActivo As New clsActivo
    Dim eactivof As New cActivoF

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
#End Region


    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

#Region " Metodos "
    Private Sub CargarDatos()

        'Origen de la Adquisicion
        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1181'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddltipo.DataTextField = "cDescri"
        Me.ddltipo.DataValueField = "cCodigo"
        Me.ddltipo.DataSource = ds.Tables("Resultado")
        Me.ddltipo.DataBind()
        ds.Tables("Resultado").Clear()


        'Agregado Nuevo
        'Fuente de Fondos
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        Dim lcfondos As String
        lcfondos = Session("gcfondo")

        mListaTabttab = clstabttab.ObtenerListaPorIDxcodigo("033", "1", lcfondos)

        Me.ddlfondos.DataTextField = "cdescri"
        Me.ddlfondos.DataValueField = "ccodigo"
        Me.ddlfondos.DataSource = mListaTabttab
        Me.ddlfondos.DataBind()


        'Ubicacion Fisica
        'lnparametro1_R = "cDescri , cCodigo, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTTAB"
        'lnparametro5_R = "S"
        'lnparametro6_R = "Where cCodTab + cTipReg ='1201'"
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    Exit Sub
        'End If
        'Me.DropDownList3.DataTextField = "cDescri"
        'Me.DropDownList3.DataValueField = "cCodigo"
        'Me.DropDownList3.DataSource = ds.Tables("Resultado")
        'Me.DropDownList3.DataBind()
        'ds.Tables("Resultado").Clear()

        'Activo Fijo
        'lnparametro1_R = "cDescri , cCodigo, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTTAB"
        'lnparametro5_R = "S"
        'lnparametro6_R = "Where cCodTab + cTipReg ='1131'"
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    Exit Sub
        'End If
        'Me.Dropdownlist4.DataTextField = "cDescri"
        'Me.Dropdownlist4.DataValueField = "cCodigo"
        'Me.Dropdownlist4.DataSource = ds.Tables("Resultado")
        'Me.Dropdownlist4.DataBind()
        'ds.Tables("Resultado").Clear()

        'Clasificacion del activo Fijo
        'lnparametro1_R = "cDescri , ctipact, "
        'lnparametro2_R = "S,S, "
        'lnparametro3_R = " "
        'lnparametro4_R = "TABTACT"
        'lnparametro5_R = "S"
        'lnparametro6_R = "Where cCodact = '10'"
        'Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        'lnparametro4_R, lnparametro5_R, lnparametro6_R)
        'ds = cls1.ResulSelect(Transacc)
        'If ds.Tables("Resultado").Rows.Count <= 0 Then
        '    Exit Sub
        'End If
        'Me.Dropdownlist5.DataTextField = "cDescri"
        'Me.Dropdownlist5.DataValueField = "ctipact"
        'Me.Dropdownlist5.DataSource = ds.Tables("Resultado")
        'Me.Dropdownlist5.DataBind()
        'ds.Tables("Resultado").Clear()

        'Oficina
        lnparametro1_R = "cnomofi , cCodofi, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTOFI"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cdrive <> 'A'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddloficinas.DataTextField = "cnomofi"
        Me.ddloficinas.DataValueField = "cCodofi"
        Me.ddloficinas.DataSource = ds.Tables("Resultado")
        Me.ddloficinas.DataBind()
        ds.Tables("Resultado").Clear()


        lnparametro1_R = "cDescri , cCodigo, "
        lnparametro2_R = "S,S, "
        lnparametro3_R = " "
        lnparametro4_R = "TABTTAB"
        lnparametro5_R = "S"
        lnparametro6_R = "Where cCodTab + cTipReg ='1451'"
        Transacc = cls1.Transac(lnparametro1_R, lnparametro2_R, lnparametro3_R, _
        lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = cls1.ResulSelect(Transacc)
        If ds.Tables("Resultado").Rows.Count <= 0 Then
            Exit Sub
        End If
        Me.ddlexportar.DataTextField = "cDescri"
        Me.ddlexportar.DataValueField = "cCodigo"
        Me.ddlexportar.DataSource = ds.Tables("Resultado")
        Me.ddlexportar.DataBind()
        ds.Tables("Resultado").Clear()

        Me.TxtDate2.Text = Session("GDFECCTB")
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)

    End Sub
#End Region

    Private Sub btnprint_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.ServerClick
        Dim lcexportar As String
        Dim ldfecha As Date
        Dim cactivof As New SIM.BL.cActivoF
        Dim ccntaprmAct As New SIM.BL.cCntaprmAct
        Dim dsAct As New DataSet
        Dim ncanti As Integer = 0
        Dim ecntaprm As New cCntaprm
        Dim mes As String
        Dim mes1 As String
        Dim año As String
        Dim añoa As String
        Dim ldfecini As Date
        Dim ldfecfin As Date
        Dim mesvig As String
        Dim mesviga As String
        mes1 = Month(Date.Parse(Me.TxtDate2.Text.Trim).AddDays(1))
        año = Year(Date.Parse(Me.TxtDate2.Text.Trim).AddDays(1))
        If mes1 <= 9 Then
            mes1 = "0" + mes1
        End If
        mesvig = año + mes1

        Dim fecha1 As Date = DateAdd(DateInterval.Month, 1, Now.Date)
        ldfecini = (DateSerial(Date.Parse(Me.TxtDate2.Text.Trim).AddDays(1).Year, (Date.Parse(Me.TxtDate2.Text.Trim).AddDays(1)).Month, 1))
        'ldfecfin = (DateAdd(DateInterval.Day, 1, DateSerial(Date.Parse(Me.TxtDate2.Text.Trim).AddDays(1).Year, (Date.Parse(Me.TxtDate2.Text.Trim).AddDays(1)).Month, 1)))
        'ldfecfin = DateAdd(DateInterval.Month, 1, Date.Parse(Me.TxtDate2.Text.Trim).AddMonths(1))
        ldfecfin = Date.Parse(Me.TxtDate2.Text.Trim).AddMonths(1)

        ldfecha = Date.Parse(Me.TxtDate2.Text.Trim)
        'mes = (Me.TxtDate2.Text.Trim.Substring(3, 2))
        mes = Month(Date.Parse(Me.TxtDate2.Text.Trim))
        añoa = Year(Date.Parse(Me.TxtDate2.Text.Trim))
        If mes <= 9 Then
            mes = "0" + mes
        End If
        mesviga = añoa + mes
        dsAct = ccntaprmAct.ObtenerfiscaltoClose("99")


        If Right(dsAct.Tables(0).Rows(0)("cmesvig"), 2) = mes Then
            lcexportar = Me.ddlexportar.SelectedValue.Trim
            Dim eusuariogrupo As New cUsuarioGrupo
            Dim lngrupos As String
            lngrupos = eusuariogrupo.RetornaGrupo(Session("gccodusu"))
            Dim ds As New DataSet
            If lngrupos = "6" Then
                ds = cactivof.DatasetActivoFijoPartida()
                Me.GeneraPartidas(ds)
                ' cierra mes de activos
                ccntaprmAct.CierreMesAct(mesviga, "99", Session("gccodusu"))
                ' inserta nuevo mes activos.
                ccntaprmAct.AbreMesAct(mesvig, ldfecini, ldfecfin, Session("gccodusu"), "99")
            Else
                Response.Write("<script language='javascript'>alert('Solo el Contador General Puede Generar las Partidas de Depreciacion !!!!!')</script>")
                Exit Sub
            End If
        Else
            Response.Write("<script language='javascript'>alert('Mes ya Cerrado!!!!!')</script>")
            Exit Sub
        End If
            'Me.Imprime("Activof.rpt", ds, lcexportar)
    End Sub
    Private Sub GeneraPartidas(ByVal ds As DataSet)
        Dim lcpartidas As String = ""

        Try
            clase.dfecha = Session("GDFECCTB")
            'clase.cctabco = lcctabco.Trim
            'clase.cfactura = Me.txtRef.Text
            clase.pcCodUsu = Session("gccodusu")

            lcpartidas = clase.PartidasDepreciacion(ds, clase.dfecha)

            If lcpartidas = "0" Then
                Response.Write("<script language='javascript'>alert('no hay datos para depreciar ')</script>")
            Else
                Response.Write("<script language='javascript'>alert('Depreciacion Realizada, referencia partida no: " + lcpartidas + "')</script>")
            End If
        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('error: " + ex.Message.ToString + "')</script>")
        End Try
    End Sub
End Class
