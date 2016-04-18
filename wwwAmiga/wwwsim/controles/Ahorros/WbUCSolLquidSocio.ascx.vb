Imports Microsoft.VisualBasic
Imports System.Data.Common
Imports System.Text
Imports System.Configuration.ConfigurationSettings
Imports System
Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports System.Collections
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web



Partial Class controles_Ahorros_WbUCSolLquidSocio
    Inherits ucWBase


#Region "Privadas"
    Private clsConvert As New SIM.BL.ConversionLetras
    Private Shared cuenta As String, direccion As String, fecha As Date = Date.Today
    Private Shared asociado As String, nombre As String, dui As String, telefonos As String
    Private Shared aportaciones As Decimal, noaportaciones As Decimal, certificados As Decimal, creditos As Decimal, tot_aporta As Decimal
    Private Shared cta_apotacion As String, aporta_extra As Decimal, global_cnumcom As String, deudores_varios As Decimal
    Private Shared control1 As Integer = 0
    Private Shared hay_creditos = 0
    Private cls1 As New SIM.BL.pagdesver
    Private clsppal As New SIM.BL.class1
    Private clsaplica As New SIM.BL.payment
    Private dsimprimepagos As New DataSet
    Private etabtofi As New cTabtofi
    Private entidadcremcre As New cremcre
    Private ecremcre As New cCremcre
    Private eahomcta As New cAhomcta
    Private claseaditivo As New cClsAditivos
    Private clsbancos As New cTabtbco
    Private codigoJs As String
    Private lcCodbco As String = ""
#End Region

#Region "Metodos"
    Private Sub Buscar()
        Dim ds As DataSet
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()

        ds = miclase.buscar_asociado(con, asociado_TextBox.Text.Trim.ToUpper)
        con.Close()

        GridViewDatos.DataSource = ds
        GridViewDatos.DataBind()
        GridViewDatos.Visible = True

        If GridViewDatos.Rows.Count = 0 Then
            'Response.Write(miclase1.mensaje("No existe ninguna concordancia"))
            codigoJs = "<script language='javascript'>alert('No Existen Datos, " & _
                         "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
        End If

    End Sub

    Public Sub Carga_Inicial()



    End Sub

#End Region

    Private Structure pagos
        Public s_apo As Decimal
        Public s_sim As Decimal
        Public s_deu As Decimal
        Public s_dan As Decimal
        Public s_man As Decimal
        Public s_cap As Decimal
        Public s_int As Decimal
        Public s_mor As Decimal
        Public s_vid As Decimal
        Public s_cxc As Decimal
        Public s_cos As Decimal
        Public s_ano As Decimal
        Public s_dep As Decimal
    End Structure
    Private Shared pagos_aditivos(10) As pagos
    Private x As Integer = 0


    Protected Sub buscar_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscar_Button.Click
        control1 = 0
        Session("gcbuscli") = asociado_TextBox.Text.Trim
        mensaje.Visible = False
        cuentas_GridView.Visible = False
        plazos_GridView.Visible = False
        creditos_GridView.Visible = False
        deudores_GridView.Visible = False
        UpdatePanel5.Visible = False

        foto_Image.Visible = False
       

        cuentas_GridView.Visible = False

        mensaje.Visible = False
        Buscar()
        cuenta = Nothing
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("gccodusu") Is Nothing Then
                Session("gccodusu") = "9999"
                'Session("gdfecsis") = Date.Today()
            End If
            UpdatePanel5.Visible = False
            asociado_TextBox.Focus()
            'If Session("gcbuscli") Is Nothing Then
            '    Session("gcbuscli") = ""
            'End If
            'Dim miclase1 As New clase_funciones
            'Response.Write(miclase1.mensaje("Recuerde de Capitalizar las Ctas. Primero"))
        End If
    End Sub

    Protected Sub GridViewDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewDatos.SelectedIndexChanged

        hay_creditos = 0
        asociado = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado
        nombre = GridViewDatos.SelectedRow.Cells(3).Text.ToString 'nombre
        dui = GridViewDatos.SelectedRow.Cells(4).Text.ToString 'dui
        Dim miclase As New clase_jaime()
        Dim miclase1 As New clase_funciones
        Dim ds As DataSet
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()

        con.ConnectionString = stringconnection
        con.Open()
        ds = miclase.buscar_ctas_ahorro(con, asociado.ToString, 1)
        con.Close()

        foto_firma(asociado)

        tot_aporta = 0
        calcular(asociado)

        retiro_Button.Visible = True

        If verifica_es_fiador() = True Then
            'Response.Write(miclase1.mensaje("Asociado es Fiador"))
            codigoJs = "<script language='javascript'>alert('Asociado es Fiador, " & _
                         "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If

    End Sub

    Protected Sub foto_firma(ByVal asociado As String)
        Dim miclase1 As New clase_funciones

        Dim huella1 As String = miclase1.foto_firma(asociado, 1)
        If huella1 <> "basura" Then
            foto_Image.Height = 75
            foto_Image.Width = 100
            foto_Image.ImageUrl = huella1
            foto_Image.Visible = True
        End If

    End Sub

    Protected Sub calcular(ByVal socio As String)

        pagos_aditivos(0).s_deu = 0
        pagos_aditivos(0).s_dan = 0
        pagos_aditivos(0).s_man = 0
        pagos_aditivos(0).s_apo = 0
        pagos_aditivos(0).s_vid = 0
        pagos_aditivos(0).s_cos = 0
        pagos_aditivos(0).s_ano = 0
        pagos_aditivos(0).s_cxc = 0
        pagos_aditivos(0).s_dep = 0
        pagos_aditivos(0).s_int = 0
        pagos_aditivos(0).s_mor = 0
        pagos_aditivos(0).s_sim = 0
        pagos_aditivos(0).s_cap = 0


        aportaciones = 0
        noaportaciones = 0
        certificados = 0
        creditos = 0

        Dim abortar As Boolean = False

        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre
        Dim eahomcta As New cAhomcta
        Dim claseaditivo As New cClsAditivos
        Dim cls1 As New SIM.BL.pagdesver
        Dim clsppal As New SIM.BL.class1
        Dim clsaplica As New SIM.BL.payment


        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        Dim fila As DataRow
        Dim str_select As String
        Dim ds0 As New DataSet
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim ds3 As New DataSet
        Dim ds31 As New DataSet
        Dim ds4 As New DataSet
        Dim comi As Decimal = 0
        Dim tot_haberes As Decimal = 0, tot_deuda As Decimal = 0, disponible As Decimal = 0, comision As Decimal = 0
        Dim cta As String = "", last_fecha As Date, meses As Integer = 0, fecha_hoy As Date = Session("gdfecsis")
        con.ConnectionString = stringconnection
        con.Open()

        'asociados
        str_select = "select cdirdom, cteldom, ccodcon from climide where ccodcli = '" & socio & "'"
        ds0 = miclase.devolver_dataset(con, str_select)
        For Each fila In ds0.Tables(0).Rows
            direccion = fila("cdirdom")
            telefonos = fila("cteldom") & " " & fila("ccodcon")
        Next

        ds0.Clear()

        ''bancos
        'str_select = "select bco.ccodbco, cta.ccodcta, cta.cdescrip " & _
        '             "from ctbmcta as cta, tabtbco as bco " & _
        '             "where (cta.ccodcta >= '11100301010101' and cta.ccodcta <= '11100301010105')  " & _
        '             "and cta.ccodcta = bco.ccodcta " & _
        '             "order by cta.ccodcta "
        'ds0 = miclase.devolver_dataset(con, str_select)
        'For Each fila In ds0.Tables(0).Rows
        '    bancos_DropDownList.Items.Add(fila("ccodbco") & "-" & fila("ccodcta") & "-" & fila("cdescrip"))
        'Next
        'ds0.Clear()

        'ahorros
        str_select = "select aho.ccodaho, trs.cnomtrs as tipo, aho.nsaldoaho from ahomcta as aho, ahomtrs as trs " & _
                         "where aho.nsaldoaho > 0 and cnudotr = '" & socio & "' and substring(aho.ccodaho,7,2) = trs.ccodtrs order by aho.ccodaho"
        ds1 = miclase.devolver_dataset(con, str_select)
        For Each fila In ds1.Tables(0).Rows
            If fila("ccodaho").ToString.Substring(6, 2) = "06" Then
                comi = fila("nsaldoaho") 'para saber la aportacion
                aportaciones = aportaciones + fila("nsaldoaho") 'para saber la aportacion
                cta_apotacion = fila("ccodaho")
            Else
                noaportaciones = noaportaciones + fila("nsaldoaho") 'no aportaciones
            End If
            tot_haberes = tot_haberes + fila("nsaldoaho")
        Next

        Session("dsahorros") = ds1
        cuentas_GridView.DataSource = ds1
        cuentas_GridView.DataBind()

        'certificados
        str_select = "select ccodcrt, nmonapr from ahomcrt " & _
                 "where cliq  <> 'S' and nmonapr > 0 and cnudotr = '" & socio & "' order by ccodcrt"
        ds2 = miclase.devolver_dataset(con, str_select)

        For Each fila In ds2.Tables(0).Rows
            tot_haberes = tot_haberes + fila("nmonapr")
            certificados = certificados + fila("nmonapr")
            abortar = True
        Next

        Session("dscertificados") = ds2
        plazos_GridView.DataSource = ds2
        plazos_GridView.DataBind()


        Dim lncostas As Double = 0
        Dim lnanotacion As Double = 0
        Dim lndeudores As Double = 0
        Dim lndepurada As Double = 0

        'Seguro deuda
        Dim lnsegdeu As Decimal = 0
        'Manejo de Cuenta
        Dim lnmanejo As Decimal = 0
        'Aportaciones
        Dim lnaporta As Decimal = 0
        'Seguro de Daños
        Dim lnsegdan As Decimal = 0
        Dim lnsegvid As Double = 0
        Dim gastos As Decimal = 0
        Dim lninteres As Decimal = 0
        Dim lnmora As Decimal = 0
        Dim lnahosim As Decimal = 0
        Dim lnahorro As Decimal = 0
        Dim ok As Integer = 0
        Dim lncapita = 0
        Dim lnsaldo As Decimal = 0

        'creditos
        str_select = "select ccodcta, nmoncuo, dfecvig, dfecven, ncapdes, ncapdes - ncappag as saldo, 0000000.00 as deuda_total from cremcre " & _
         "where cestado = 'F' and ccodrec = ' ' and ccodcli = '" & socio & "'  order by ccodcta"
        ds3 = miclase.devolver_dataset(con, str_select)

        x = 0

        For Each fila In ds3.Tables(0).Rows

            clsaplica.pccodcta = fila("ccodcta")
            clsaplica.pdfecval = Session("gdfecsis")
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            'clsaplica.pcflat = ""
            clsaplica.gnpergra = Session("gnpergra")
            clsaplica.gnpergra = Session("gnpergra")
            ok = clsaplica.omcalcinterest("T", clsaplica.pdfecval)

            gastos = 0



            If ok = 1 Then

                clsppal.gnperbas = Session("gnperbas")
                clsppal.pnComtra = Session("gnComTra")
                clsppal.pnSegVm = Session("gnSegVm")

                'Aditivos-------------------------------------------------------------------------------
                claseaditivo.pccodcta = fila("ccodcta")
                claseaditivo.pdfecval = Session("gdfecsis")
                claseaditivo.pnsalcap = fila("saldo")

                claseaditivo.pdfeclim = Session("gdfeclim")
                claseaditivo.pnsegmax = Session("gnsegmax")
                claseaditivo.pdfecseg1 = Session("gdfecseg1")
                claseaditivo.pdfecseg2 = Session("gdfecseg2")
                claseaditivo.pdfecsis = Session("gdfecsis")
                claseaditivo.pnmancta = Session("GNMANCTA")
                claseaditivo.pdfecefec6 = Session("gdfecefec6")
                claseaditivo.pnmancta6 = Session("gnmancta6")
                claseaditivo.pnmancta5 = Session("gnmancta5")
                claseaditivo.pcCostas = Session("gcCostas")
                claseaditivo.pcAnotacion = Session("gcAnotacion")
                claseaditivo.pcDeudores = Session("gcDeudores")
                claseaditivo.pcPorCob = Session("gcPorCob")
                claseaditivo.pnsegvid = Session("gnsegvid")

                'Seguro deuda
                lnsegdeu = claseaditivo.SeguroDeuda()
                'Manejo de Cuenta
                lnmanejo = claseaditivo.ManejoCuenta()
                'Aportaciones
                lnaporta = claseaditivo.Aportaciones()
                tot_aporta = lnaporta  'lo hace para descontarlo de las aportaciones
                'Seguro de Daños
                lnsegdan = claseaditivo.SeguroDanos()
                '-----------------------------------------------------------------------------------------
                'Cuentas por Cobrar

                lncostas = claseaditivo.CostasProcesales()
                lnanotacion = claseaditivo.AnotacionPreventiva()
                lndeudores = claseaditivo.Deudores()
                lndepurada = claseaditivo.Depurada()

                '-----------------------------------------------------------------------------------------
                'Seguro de Vida Protege

                lnsegvid = claseaditivo.SeguroProtege()

                lncapita = utilNumeros.Redondear(clsaplica.pndeucap, 2)
                lninteres = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                lnmora = utilNumeros.Redondear(clsaplica.pnsalmor, 2)

                lnahorro = Session("GNAHORRO")
                lnahosim = utilNumeros.Redondear(clsaplica.ahosim, 2)

                If lnahosim > lnahorro Then
                    lnahosim = 0
                Else
                    lnahosim = lnahorro - lnahosim
                End If
                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)

                '-----------------------------------------------------------------------------------------
                gastos = lnsegdeu + lnmanejo + lnaporta + lnsegdan + lnsegvid + lncostas + lnanotacion _
                                          + lndeudores + lndepurada + lninteres + lnmora + lnahosim

                pagos_aditivos(x).s_deu = lnsegdeu
                pagos_aditivos(x).s_dan = lnsegdan
                pagos_aditivos(x).s_man = lnmanejo
                pagos_aditivos(x).s_apo = lnaporta
                pagos_aditivos(x).s_vid = lnsegvid
                pagos_aditivos(x).s_cos = lncostas
                pagos_aditivos(x).s_ano = lnanotacion
                pagos_aditivos(x).s_cxc = lndeudores
                pagos_aditivos(x).s_dep = lndepurada
                pagos_aditivos(x).s_int = lninteres
                pagos_aditivos(x).s_mor = lnmora
                pagos_aditivos(x).s_sim = lnahosim
                pagos_aditivos(x).s_cap = fila("saldo")

                x = x + 1

                ' este vector va a servir en boton liquiedar para saver cuanto es lo que debe pagar
                fila("saldo") = lnsaldo
                fila("deuda_total") = gastos + lnsaldo
            End If

            tot_deuda = tot_deuda + fila("saldo") + gastos
            creditos = creditos + fila("saldo") + gastos

        Next

        Session("dscreditos") = ds3
        creditos_GridView.DataSource = ds3
        creditos_GridView.DataBind()

        deudores_varios = 0

        ''deudores varios
        'str_select = "select ccodcta,  sum(ncargos) as cargos, sum(nabono) as abonos, sum(ncargos) - sum(nabono) as saldo from auxctas " & _
        ' "where ccodcta in ('1210990201', '1210990501', ' 9111010301') and ccodcli = '" & socio & "' group by ccodcta"
        'ds4 = miclase.devolver_dataset(con, str_select)
        'For Each fila In ds4.Tables(0).Rows
        '    'porque lo calculo antes
        '    deudores_varios = deudores_varios + fila("saldo")
        'Next

        'deudores_GridView.DataSource = ds4
        'deudores_GridView.DataBind()

        'comision segun aportaciones
        'If comi >= 0 And comi <= 12.0 Then
        '    comision = 3.23
        'End If
        'If comi >= 12.01 And comi <= 57.14 Then
        '    comision = 6.46
        'End If
        'If comi >= 57.15 And comi <= 114.28 Then
        '    comision = 9.69
        'End If
        'If comi >= 114.29 Then
        '    comision = 12.91
        'End If

        comision = 0

        haberes_TextBox.Text = tot_haberes
        deuda_TextBox.Text = tot_deuda + deudores_varios
        comision_TextBox.Text = comision
        disponible = tot_haberes - (tot_deuda + comision)
        disponible_TextBox.Text = disponible

        con.Close()

        cuentas_GridView.Visible = True
        plazos_GridView.Visible = True
        creditos_GridView.Visible = True
        deudores_GridView.Visible = True

        UpdatePanel5.Visible = True

        If disponible < 0 Then
            'Response.Write(miclase1.mensaje("La deuda es mayor que la disponibilidad!!!"))
            codigoJs = "<script language='javascript'>alert('La deuda es mayor que la disponibilidad!!!, " & _
                         "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
          
            Exit Sub
        End If
        If abortar = True Then
            'Response.Write(miclase1.mensaje("Debe de Cancelar el Certificado a Plazo Primero?!!!"))
            codigoJs = "<script language='javascript'>alert('Debe de Cancelar el Certificado a Plazo Primero?!!!, " & _
                         "Aviso SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
           
            Exit Sub
        End If


    End Sub

    

    Protected Sub GridViewDatos_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridViewDatos.PageIndexChanging
        GridViewDatos.PageIndex = e.NewPageIndex
        Call Buscar()
    End Sub

    Protected Sub GridViewDatos_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridViewDatos.RowDataBound
        If e.Row.RowType = DataControlRowType.Pager AndAlso Not GridViewDatos.DataSource Is Nothing Then
            'TRAE EL TOTAL DE PAGINAS
            Dim _TotalPags As Label = e.Row.FindControl("lblTotalNumberOfPages")
            _TotalPags.Text = GridViewDatos.PageCount.ToString

            'LLENA LA LISTA CON EL NUMERO DE PAGINAS
            Dim list As DropDownList = e.Row.FindControl("paginasDropDownList")
            For i As Integer = 1 To CInt(GridViewDatos.PageCount)
                list.Items.Add(i.ToString)
            Next
            list.SelectedValue = GridViewDatos.PageIndex + 1
        End If
    End Sub


    Protected Sub paginasDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim oIraPag As DropDownList = DirectCast(sender, DropDownList)
        Dim iNumPag As Integer = 0
        If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
            If Integer.TryParse(oIraPag.Text.Trim, iNumPag) AndAlso iNumPag > 0 AndAlso iNumPag <= GridViewDatos.PageCount Then
                GridViewDatos.PageIndex = iNumPag - 1
            Else
                GridViewDatos.PageIndex = 0
            End If
        End If
        Call Buscar()
    End Sub

    Protected Function verifica_es_fiador() As Boolean
        Dim miclase As New clase_jaime
        Dim miclase1 As New clase_funciones
        Dim con As New SqlConnection
        Dim stringconnection As String = miclase.conexion()
        con.ConnectionString = stringconnection
        Dim str_select As String
        Dim cuantos As Integer = 0
        str_select = "select count(*) as cuantos from crepgar where ccoduni = " & miclase1.ToString(asociado)

        con.Open()
        cuantos = miclase.devolver_scalar1(con, str_select)

        con.Close()

        If cuantos = 0 Then
            Return False
        Else
            Return True
        End If


    End Function
 
   
    Protected Sub retiro_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles retiro_Button.Click
        Dim usuario As String = Session("gccodusu")
        Dim nomusu As String = ""
        Dim ofi_usu As String = ""
        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Dim mUsuarios As New cusuarios
        Dim mTabtofi As New cTabtofi
        Dim eTabtofi As New tabtofi
        Dim cdirofi As String = ""

        asociado = GridViewDatos.SelectedRow.Cells(1).Text.ToString 'asociado
        nombre = GridViewDatos.SelectedRow.Cells(3).Text.ToString 'nombre

        nomusu = mUsuarios.NombreUsuario(usuario)
        ofi_usu = mUsuarios.Oficina(usuario)

        eTabtofi.ccodofi = ofi_usu
        mTabtofi.ObtenerTabtofi(eTabtofi)
        cdirofi = eTabtofi.cdireccion



        'Primero Bloqueara todas las cuentas
        Dim omclass As New cAhomcta
        Dim lnretorno As Integer = 0

        lnretorno = omclass.Bloqueo_cta_liquidacion(asociado, Session("gccodusu"))


        If lnretorno = 0 Then
            codigoJs = "<script language='javascript'>alert('Ocurrio un Error al Bloquear las cuentas del asociado, " & _
                         "Advertencia SIM.NET ')</script>"

            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "tempJS", codigoJs, False)
            Exit Sub
        End If


        ' Obtener los saldos financieros
        Dim dsAho As New DataSet
        Dim dsCerti As New DataSet
        Dim dsCre As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow

        dt.Columns.Add("ctipmov")
        dt.Columns.Add("cdescri")
        dt.Columns.Add("dfecvig")
        dt.Columns.Add("dfecven")
        dt.Columns.Add("dfecult")
        dt.Columns.Add("nmonto")
        dt.Columns.Add("saldo")
        dt.Columns.Add("cuota")

        dsAho = DirectCast(Session("dsahorros"), DataSet)
        dsCerti = DirectCast(Session("dscertificados"), DataSet)
        dsCre = DirectCast(Session("dscreditos"), DataSet)

        ' Datos de Ahorro
        Dim eAhomcta As New ahomcta
        Dim mAhomcta As New cAhomcta

        For Each fila As DataRow In dsAho.Tables(0).Rows
            eAhomcta.ccodaho = fila("ccodaho")
            mAhomcta.ObtenerAhomcta(eAhomcta)

            dr = dt.NewRow()
            dr("ctipmov") = "AHO"
            dr("cdescri") = fila("tipo")
            dr("dfecvig") = eAhomcta.dfecapr
            dr("dfecven") = "--"
            dr("dfecult") = eAhomcta.dfechault
            dr("nmonto") = "0.00"
            dr("saldo") = fila("nsaldoaho")
            dr("cuota") = "0.00"
            dt.Rows.Add(dr)
        Next

        ' Datos de Certificado
        Dim eAhomcrt As New ahomcrt
        Dim mAhomcrt As New cAhomcrt

        For Each fila As DataRow In dsCerti.Tables(0).Rows
            eAhomcrt.ccodcrt = fila("ccodcrt")
            mAhomcrt.ObtenerAhomcrt(eAhomcrt)

            dr = dt.NewRow()
            dr("ctipmov") = "CRT"
            dr("cdescri") = "DEPOSITOS A PLAZO"
            dr("dfecvig") = eAhomcrt.dfecapr
            dr("dfecven") = eAhomcrt.dfecven
            dr("dfecult") = eAhomcrt.dultpro
            dr("nmonto") = "0.00"
            dr("saldo") = fila("nmonapr")
            dr("cuota") = "0.00"
            dt.Rows.Add(dr)
        Next

        ' Datos del Crédito
        Dim eCremcre As New cremcre
        Dim mCremcre As New cCremcre

        For Each fila As DataRow In dsCre.Tables(0).Rows
            eCremcre.ccodcta = fila("ccodcta")
            mCremcre.ObtenerCremcre(eCremcre)

            dr = dt.NewRow()
            dr("ctipmov") = "CRE"
            dr("cdescri") = "PRESTAMO"
            dr("dfecvig") = fila("dfecvig")
            dr("dfecven") = fila("dfecven")
            dr("dfecult") = eCremcre.dultpag
            dr("nmonto") = "0.00"
            dr("saldo") = fila("saldo")
            dr("cuota") = fila("nmoncuo")
            dt.Rows.Add(dr)
        Next

        Try
            'Cargar Definicion del Reporte
            crRpt.Load(Server.MapPath("reportes") + "\solicitud_retiro.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try

        ' Setear los registros recuperados, diciendole el Table respectivo
        crRpt.SetDataSource(dt)
        crRpt.Refresh()

        Dim motivo = motivo_TextBox.Text.ToLower
        Dim tot_haberes As Decimal = aportaciones + noaportaciones + certificados + tot_aporta
        Dim diferencia As Decimal = tot_haberes - (creditos + Decimal.Parse(comision_TextBox.Text))


        crRpt.SetParameterValue("asociado", asociado)
        crRpt.SetParameterValue("nombre", nombre)
        crRpt.SetParameterValue("direccion", direccion)
        crRpt.SetParameterValue("dui", dui)
        crRpt.SetParameterValue("telefonos", telefonos)
        crRpt.SetParameterValue("motivo", motivo)
        crRpt.SetParameterValue("noaportaciones", noaportaciones)
        crRpt.SetParameterValue("aportaciones", aportaciones)
        crRpt.SetParameterValue("comision", Decimal.Parse(comision_TextBox.Text))
        crRpt.SetParameterValue("diferencia", diferencia)
        crRpt.SetParameterValue("creditos", creditos)
        crRpt.SetParameterValue("certificados", certificados)
        crRpt.SetParameterValue("tot_haberes", tot_haberes)
        crRpt.SetParameterValue("devolucion", tot_aporta)
        crRpt.SetParameterValue("otros", 0)
        crRpt.SetParameterValue("cnomusu", nomusu.ToUpper())
        crRpt.SetParameterValue("dfecsis", CDate(Session("gdfecsis")))
        crRpt.SetParameterValue("cdirofi", cdirofi.ToString())

        Dim reportes As String
        reportes = "solicitud_retiro.pdf"


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
End Class
