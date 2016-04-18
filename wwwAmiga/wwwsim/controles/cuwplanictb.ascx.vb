Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class cuwplanictb
    Inherits System.Web.UI.UserControl
    Private cClsAdP As New SIM.BL.ClsAdPart
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.txtdfecha.Text = Session("gdfecsis")
            lista()
        End If

    End Sub
    Public Sub lista()
        Me.TextBox1.Visible = False
        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab
        mListaTabttab = clstabttab.ObtenerLista("145", "1")

        Me.ddlexportar.DataTextField = "cdescri"
        Me.ddlexportar.DataValueField = "ccodigo"
        Me.ddlexportar.DataSource = mListaTabttab
        Me.ddlexportar.DataBind()

    End Sub
    Private Sub btngraba_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngraba.ServerClick
        imprimir("crplanilla.rpt")
    End Sub

    Sub partidacontable(ByVal ds As DataSet)
        Me.TextBox1.Visible = True
        Dim etabttab As New cTabttab
        Dim ectbmcta As New cCtbmcta
        Dim clsppal As New class1
        Dim dspartida As New DataSet

        Dim dsarea As New DataSet
        Dim dsplanti As New DataSet
        Dim fila As DataRow
        Dim fila1 As DataRow

        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim lccodigo As String
        Dim lccodofi As String
        Dim ldfecha As Date
        ldfecha = Date.Parse(Me.txtdfecha.Text.Trim)

        Dim lcmes As String
        Dim lcaño As String
        lcmes = clsppal.MES(ldfecha.Month)
        lcaño = ldfecha.Year.ToString

        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcfilplan As New DataTable
        Dim dr As DataRow
        lcampos1 = "ccodcta,nlinea,ndebe,nhaber,dfeccnt,ccodofi,"
        ltipos1 = "S,I,D,D,F,S,"

        Dim lccodito As String
        dsarea = etabttab.ObtenerDataSetPorID("083", "1")
        For Each fila In dsarea.Tables(0).Rows
            Dim lnc As Integer
            lnc = ds.Tables(0).Rows.Count
            lcfilplan = clsppal.creadatasetdesconec(lcampos1, ltipos1, "planilla")
            lccodigo = dsarea.Tables(0).Rows(i)("ccodigo")
            lccodofi = IIf(lccodigo = "001" Or lccodigo = "002", "004", "002")
            'Carga Plantilla
            dsplanti = ectbmcta.Plantilla1(lccodofi)
            Dim lccode As String
            Dim lnsalario As Double = 0
            Dim lnissslab As Double = 0
            Dim lnafplab As Double = 0
            Dim lnisr As Double = 0
            Dim lnissspat As Double = 0
            Dim lnafppat As Double = 0
            Dim lnisss As Double = 0
            Dim lnafp As Double = 0
            Dim lnbanco As Double = 0
            Dim lncelular As Double = 0
            Dim lccodcta As String
            Dim lcasiento As String
            Dim linea As Integer = 1
            Dim lndebe As Double = 0
            Dim lnhaber As Double = 0
            j = 0
            For Each fila1 In dsplanti.Tables(0).Rows
                lccode = dsplanti.Tables(0).Rows(j)("ccode")
                lccodcta = dsplanti.Tables(0).Rows(j)("ccodigo")
                lcasiento = dsplanti.Tables(0).Rows(j)("casiento")

                If lccode = "01" Then 'Banco
                    lnbanco = Me.banco(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnbanco, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnbanco)
                ElseIf lccode = "02" Then 'CELULARES
                    lncelular = Me.celulares(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lncelular, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lncelular)

                ElseIf lccode = "03" Then ' ISSS Laboral
                    lnissslab = Me.IsssLaboral(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnissslab, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnissslab)

                ElseIf lccode = "04" Then ' AFPS Laboral
                    lnafplab = Me.AfpsLaboral(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnafplab, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnafplab)

                ElseIf lccode = "05" Then ' ISR
                    lnisr = Me.ISR(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnisr, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnisr)

                ElseIf lccode = "06" Then ' ISSS Patronal
                    lnissspat = Me.IsssPatronal(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnissspat, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnissspat)

                ElseIf lccode = "07" Then 'AFP Patronal
                    lnafppat = Me.AfpPatronal(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnafppat, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnafppat)

                ElseIf lccode = "08" Then ' Salarios
                    lnsalario = Me.salarios(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnsalario, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnsalario)

                ElseIf lccode = "09" Then ' ISSS
                    lnisss = Me.ISSS(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnisss, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnisss)

                Else ' AFP/S
                    lnafp = Me.AFP(ds, lccodigo)
                    lndebe = IIf(lcasiento = "D", lnafp, 0)
                    lnhaber = IIf(lcasiento = "D", 0, lnafp)

                End If
                If lndebe = 0 And lnhaber = 0 Then
                Else
                    dr = lcfilplan.NewRow()
                    dr("ccodcta") = lccodcta
                    dr("dfeccnt") = Date.Parse(Me.txtdfecha.Text.Trim)
                    dr("nlinea") = linea
                    dr("ccodofi") = lccodofi
                    dr("ndebe") = lndebe
                    dr("nhaber") = lnhaber
                    lcfilplan.Rows.Add(dr)
                    linea = linea + 1
                End If
                

                j += 1
            Next
            'Agregas Cuentas con Auxiliar
            j = 0
            Dim lcctaaux As String
            Dim lnotros1 As Double = 0
            Dim lcdep As String
            For Each fila1 In ds.Tables(0).Rows
                lcctaaux = ds.Tables(0).Rows(j)("cctactb")
                lnotros1 = ds.Tables(0).Rows(j)("notros")
                lcdep = ds.Tables(0).Rows(j)("cdepto")
                If lnotros1 = 0 Then
                Else
                    If lcdep.Trim = lccodigo.Trim Then
                        dr = lcfilplan.NewRow()
                        dr("ccodcta") = lcctaaux
                        dr("dfeccnt") = Date.Parse(Me.txtdfecha.Text.Trim)
                        dr("nlinea") = linea
                        dr("ccodofi") = IIf(lccodigo = "001" Or lccodigo = "002", "004", "002")
                        dr("ndebe") = 0
                        dr("nhaber") = lnotros1
                        lcfilplan.Rows.Add(dr)
                        linea = linea + 1
                    End If
                End If
                j += 1
            Next
            dspartida.Tables.Add(lcfilplan)
            linea = 1


            'Graba Partida en tablas
            cClsAdP._dfecmod = Session("gdfecsis")
            cClsAdP._ccodusu = Session("gcCodusu")
            cClsAdP._ccodofi = lccodofi
            cClsAdP._ffondos = "01"
            cClsAdP._cconcepto = "PAGO DE SALARIO CORRESPONDIENTE A " + lcmes & " " & lcaño
            cClsAdP._dfeccnt = Date.Parse(Me.txtdfecha.Text.Trim)
            cClsAdP._cpoliza = " "
            cClsAdP._nCuenta = 1
            cClsAdP._cnumdoc = "F"
            cClsAdP._llbandera = True

            j = 0
            Dim oki As String
            For Each fila1 In dspartida.Tables(0).Rows
                cClsAdP._cnumlin = dspartida.Tables(0).Rows(j)("nlinea")
                cClsAdP._ccodcta = dspartida.Tables(0).Rows(j)("cCodcta")
                cClsAdP._ndebe = dspartida.Tables(0).Rows(j)("nDebe")
                cClsAdP._nhaber = dspartida.Tables(0).Rows(j)("nHaber")
                cClsAdP._cclase = Mid(dspartida.Tables(0).Rows(j)("cCodcta"), 1, 1)
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    Exit Sub
                End If

                j += 1
                cClsAdP._nCuenta += 1

            Next

            dspartida.Tables.Clear()
            dspartida.Clear()
            dspartida.Reset()


            dsplanti.Tables.Clear()
            dsplanti.Clear()
            dsplanti.Reset()

            Me.TextBox1.Text = Me.TextBox1.Text + oki + "-"
            oki = ""
            i += 1
        Next
        Me.TextBox1.Text = "Partidas Generadas Nº: " + Me.TextBox1.Text
    End Sub
    Private Function Cheque(ByVal ds As DataSet)
        Dim fila As DataRow
        Dim i As Integer

    End Function
    Private Function salarios(ByVal ds As DataSet, ByVal ccodigo As String) As Double '08
        Dim lnsalario As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        'Dim lctippago As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("ntotal")
            '    lctippago = ds.Tables(0).Rows(i)("ctippago")
            If lcdepto.Trim = ccodigo.Trim Then ' And lctippago.Trim = "T" 
                lnsalario = lnsalario + lntotal
            End If
            i += 1
        Next
        Return lnsalario

    End Function
    Private Function banco(ByVal ds As DataSet, ByVal ccodigo As String) As Double '01
        Dim lnbanco As Double = 0
        Dim lnissslaboral As Double = 0
        Dim lnafplaboral As Double = 0
        Dim lnisr As Double = 0
        Dim lnotros As Double = 0
        Dim lncelular As Double = 0
        Dim lnsalario As Double = 0


        lnsalario = Me.salarios(ds, ccodigo)
        lnissslaboral = Me.IsssLaboral(ds, ccodigo)
        lnafplaboral = Me.AfpsLaboral(ds, ccodigo)
        lnisr = Me.ISR(ds, ccodigo)
        lnotros = Me.Otros(ds, ccodigo)
        lncelular = Me.celulares(ds, ccodigo)

        lnbanco = lnsalario - (lnissslaboral + lnafplaboral + lnisr + lnotros + lncelular)
        Return lnbanco
    End Function
    Private Function celulares(ByVal ds As DataSet, ByVal ccodigo As String) As Double '02
        Dim lncelular As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("ncelular")
            If lcdepto.Trim = ccodigo.Trim Then
                lncelular = lncelular + lntotal
            End If
            i += 1
        Next
        Return lncelular
    End Function
    Private Function Otros(ByVal ds As DataSet, ByVal ccodigo As String) As Double '11
        Dim lnotros As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("notros")
            If lcdepto.Trim = ccodigo.Trim Then
                lnotros = lnotros + lntotal
            End If
            i += 1
        Next
        Return lnotros
    End Function
    Private Function IsssLaboral(ByVal ds As DataSet, ByVal ccodigo As String) As Double '03
        Dim lnissslaboral As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nisss")
            If lcdepto.Trim = ccodigo.Trim Then
                lnissslaboral = lnissslaboral + lntotal
            End If
            i += 1
        Next
        Return lnissslaboral
    End Function
    Private Function AfpsLaboral(ByVal ds As DataSet, ByVal ccodigo As String) As Double '04
        Dim lnafplaboral As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nafp")
            If lcdepto.Trim = ccodigo.Trim Then
                lnafplaboral = lnafplaboral + lntotal
            End If
            i += 1
        Next
        Return lnafplaboral
    End Function
    Private Function ISR(ByVal ds As DataSet, ByVal ccodigo As String) As Double '05
        Dim lnisr As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nisr")
            If lcdepto.Trim = ccodigo.Trim Then
                lnisr = lnisr + lntotal
            End If
            i += 1
        Next
        Return lnisr
    End Function
    Private Function IsssPatronal(ByVal ds As DataSet, ByVal ccodigo As String) As Double '06
        Dim lnissspat As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nissspat")
            If lcdepto.Trim = ccodigo.Trim Then
                lnissspat = lnissspat + lntotal
            End If
            i += 1
        Next
        Return lnissspat
    End Function
    Private Function AfpPatronal(ByVal ds As DataSet, ByVal ccodigo As String) As Double '07
        Dim lnafppat As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nafppat")
            If lcdepto.Trim = ccodigo.Trim Then
                lnafppat = lnafppat + lntotal
            End If
            i += 1
        Next
        Return lnafppat
    End Function
    Private Function ISSS(ByVal ds As DataSet, ByVal ccodigo As String) As Double '09
        Dim lnissspat As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nissspat")
            If lcdepto.Trim = ccodigo.Trim Then
                lnissspat = lnissspat + lntotal
            End If
            i += 1
        Next
        Return lnissspat
    End Function
    Private Function AFP(ByVal ds As DataSet, ByVal ccodigo As String) As Double '10
        Dim lnafppat As Double = 0
        Dim lntotal As Double = 0
        Dim lcdepto As String
        Dim fila As DataRow
        Dim i As Integer = 0
        For Each fila In ds.Tables(0).Rows
            lcdepto = ds.Tables(0).Rows(i)("cdepto")
            lntotal = ds.Tables(0).Rows(i)("nafppat")
            If lcdepto.Trim = ccodigo.Trim Then
                lnafppat = lnafppat + lntotal
            End If
            i += 1
        Next
        Return lnafppat
    End Function





    Sub imprimir(ByVal reportes As String)
        'Verifica si existe planilla con esa fecha
        'Verifica si existe tabla
        Dim lcnombre As String
        Dim lcdia As String
        Dim lcmes As String
        Dim lcaño As String
        Dim lnverifica As Integer
        Dim eempleados As New cEmpleados
        Dim ldfecha2 As Date
        ldfecha2 = Date.Parse(Me.txtdfecha.Text)
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
        Dim lnver As Integer
        lnver = eempleados.Ver_Planilla(ldfecha2)
        If lnver = 1 Then
            Response.Write("<script language='javascript'>alert('Partida ya fue Generada')</script>")
            Exit Sub
        End If
        Dim lcexportar As String
        Dim i As Integer
        Dim tipo As String
        Dim ldfecsis As Date
        Dim lccodusu As String
        ldfecsis = Session("gdfecsis")
        lccodusu = Session("gccodusu")
        Dim dsbase As New DataSet
        Dim dspartida As New DataSet
        dsbase = eempleados.Planilla(lcnombre)
        Try
            'borra los que llevan cheques

            Dim fila As DataRow
            Dim h As Integer = 0
            Dim lctipop As String
            For Each fila In dsbase.Tables(0).Rows
                lctipop = dsbase.Tables(0).Rows(h)("ctippago")
                If lctipop.Trim = "C" Then
                    dsbase.Tables(0).Rows(h).Delete()
                    dsbase.Tables(0).GetChanges(DataRowState.Deleted)
                End If
                h += 1
            Next
            dsbase.Tables(0).AcceptChanges()

            Me.partidacontable(dsbase)
            eempleados.Ctrl_Planilla(ldfecha2, lccodusu, ldfecsis, " ")
            'Graba control de generacion de partida

        Catch ex As Exception

        End Try


        Response.Write("<script language='javascript'>alert('Partidas Generadas ,OK')</script>")




        dsbase.Tables(0).Clear()
        dsbase.Clear()

    End Sub


End Class
