

Imports System.Environment
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System

Partial Class CuwTrasladosCas
    Inherits ucWBase
    Private ds As New DataSet

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub
    Public Sub CargarDatosPorCuenta(ByVal codcta As String)
        Limpiar()
        Me.txtccodcta.Text = codcta

        Dim ecreditos As New ccreditos
        Dim dscre As New DataSet
        dscre = ecreditos.CreTraslado(codcta)
        If dscre.Tables(0).Rows.Count = 0 Then
            Me.cbxtraslado.Enabled = False
            Return
        Else
            Me.cbxtraslado.Enabled = True
            Dim ncanti As Integer = 0
            Dim pnsalcap As Double = 0
            Dim pnsalint As Double = 0
            Dim pnsalmor As Double = 0
            Dim pndiaatr As Integer = 0
            Dim fila As DataRow
            For Each fila In dscre.Tables(0).Rows
                Me.txtccodcli.Text = dscre.Tables(0).Rows(ncanti)("ccodcli")
                Me.txtcnomcli.Text = dscre.Tables(0).Rows(ncanti)("cnomcli")
                Me.txtcnomana.Text = dscre.Tables(0).Rows(ncanti)("cnomusu")
                Me.txtccondic.Text = dscre.Tables(0).Rows(ncanti)("condicion")
                
                Me.txtcondicion.Text = dscre.Tables(0).Rows(ncanti)("ccondic")
                Me.txtcestado.Text = dscre.Tables(0).Rows(ncanti)("cestado")
                Me.txtccodlin.Text = dscre.Tables(0).Rows(ncanti)("ccodlin")
                ncanti = ncanti + 1
            Next

            Procesar()
        End If
    End Sub
    Sub CargarDatos()
        Dim etabttab As New cTabttab
        ds = etabttab.ObtenerCondicionadoscFlag("046")
        If ds.Tables(0).Rows.Count <= 0 Then
            MsgBox("No existen Operaciones", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Me.cbxtraslado.DataTextField = "cdescri"
        Me.cbxtraslado.DataValueField = "cCodigo"
        Me.cbxtraslado.DataSource = ds.Tables(0)
        Me.cbxtraslado.DataBind()
        Me.TXTFECPRO.Text = Session("gdfecsis")
        Limpiar()

        Dim mlistatabttab As New listatabttab
        mlistatabttab = etabttab.ObtenerLista("159", "1")

        Me.cmbAbogado.DataTextField = "cdescri"
        Me.cmbAbogado.DataValueField = "ccodigo"
        Me.cmbAbogado.DataSource = mlistatabttab
        Me.cmbAbogado.DataBind()

        UpdatePanel1.Visible = False
        UpdatePanel2.Visible = False

        cbxtraslado.SelectedValue = "S"
        cbxtraslado.Enabled = False
        GridView1.Visible = False
        btnaplicar.Enabled = False
    End Sub
    Private Sub Limpiar()
        Me.lblmensaje.Text = ""

        Me.txtccodcli.Text = ""
        Me.txtcnomcli.Text = ""
        Me.txtcnomana.Text = ""
        Me.txtccondic.Text = ""
        Me.txtnsalcap.Text = 0
        Me.txtnsalint.Text = 0
        Me.txtnsalmor.Text = 0
        Me.txtndiaatr.Text = 0
        Me.txtntotal.Text = 0
        Me.txtcondicion.Text = ""
        Me.txtcestado.Text = ""
        Me.txtccodcta.Text = ""


        txtjuzgado.Text = ""
        txtjuicio.Text = ""
        txtfechademanda.Text = Session("gdfecsis")
        txtsituacion.Text = ""
        txtvalord.Text = 0
        txtfechaDes.Text = Session("gdfecsis")
        txtvalormen.Text = 0
    End Sub
    Private Sub btnaplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaplicar.Click
        'Barrer el Grid
        Dim lccodcta As String
        Dim lccondic As String
        Dim chkCptoAsig As CheckBox
        Dim lopcion As Boolean
        Dim lnsalcap As Decimal = 0
        Dim lnsalint As Decimal = 0
        Dim lnsalmor As Decimal = 0
        Dim lcoficina As String = ""
        HiddenField1.Value = "1"

        If GridView1.Rows.Count = 0 Then
            Response.Write("<script language='javascript'>alert('Cargar Archivo')</script>")
            Return
        End If
        Try
            For Each row As GridViewRow In GridView1.Rows
                chkCptoAsig = CType(row.FindControl("CheckBox1"), CheckBox)
                lopcion = chkCptoAsig.Checked
                If lopcion = True Then
                Else
                    lccodcta = row.Cells(0).Text
                    lcoficina = row.Cells(3).Text
                    lccondic = row.Cells(4).Text
                    lnsalcap = Double.Parse(row.Cells(5).Text.Replace("Q", ""))
                    lnsalint = Double.Parse(row.Cells(6).Text.Replace("Q", ""))
                    lnsalmor = Double.Parse(row.Cells(7).Text.Replace("Q", ""))
                    Trasladar(lccodcta, lccondic, lcoficina, lnsalcap, lnsalint, lnsalmor)
                End If

            Next
            btnaplicar.Enabled = False
            Response.Write("<script language='javascript'>alert('Traslados Efectuados - Partida Nº  " & HiddenField2.Value.Trim & " ')</script>")
            ' Response.Write("<script language='javascript'>alert('')</script>")

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Verificar Traslados, Ocurrio Problema')</script>")
        End Try
      

    End Sub
    Sub Partida()
        'cremcre
        Dim lcnorref As String
        Dim lccodfue As String
        Dim entidad1 As New SIM.EL.cremcre
        Dim ecreditos As New SIM.BL.cCremcre
        entidad1.ccodcta = Me.txtccodcta.Text.Trim
        ecreditos.ObtenerCremcre(entidad1)

        lcnorref = entidad1.cnorref
        lccodfue = entidad1.ccodfue


        Dim clsctb As New ClsAdPart
        clsctb._pccodcta = Me.txtccodcta.Text.Trim
        clsctb._pdfecsis = Session("gdfecsis")
        clsctb._nSalTra = Me.txtnsalcap.Text
        clsctb._pccodfue = lccodfue
        clsctb._pcnorref = lcnorref
        clsctb._pccondic = Me.txtcondicion.Text.Trim
        clsctb._pcnuming = ""
        clsctb._pccodlin = Me.txtccodlin.Text
        clsctb._pccodusu = Session("gccodusu")
        clsctb.PartidaTraslado()
    End Sub

    Public Sub ReclasificacionCartera(ByVal cCondic As String, ByVal cGlosa As String, ByVal pccodcta As String, ByVal lcoficina As String, ByVal lnsalcap As Decimal, ByVal lnsalint As Decimal, ByVal lnsalmor As Decimal)
        Dim clase As New class1
        Dim cClsAdP As New ClsAdPart
        Dim clsdes As New clsDesembolsa
        Dim entidadtabtmak As New SIM.EL.tabtmak
        Dim etabtmak As New SIM.BL.cTabtmak
        Dim clsppal As New class1
        Dim lcaux As String

        Dim lcnrolin As String = ""
        'Dim lcoficina As String = ""
        Dim lcmascara As String = ""
        Dim lccondicv As String = ""

        Dim entidadcremcre As New cremcre
        Dim ecremcre As New cCremcre

        entidadcremcre.ccodcta = pccodcta
        ecremcre.ObtenerCremcre(entidadcremcre)

        lcnrolin = entidadcremcre.cnrolin
        lccondicv = entidadcremcre.ccondic
        lcaux = entidadcremcre.ctipgar '
        If lcaux.Trim = "" Then
            lcaux = clsppal.ObtenerCodigoGarantia(pccodcta)
        End If
        'lcoficina = entidadcremcre.coficina

        Dim oki As String = ""
        Dim ldfecha As Date = Session("gdfecsis")
        Dim ds As New DataSet

        Dim etabttab As New cTabttab
        Dim busquedaplantilla As String = ""
        Dim lcctactb As String = ""
        Dim cplanti As String = ""
        Dim lccodlin As String = ""
        Dim lccodcta As String = ""
        Dim lccodigo As String
        Dim lcmetodo As String

        'Actualiza Status del credito
        Dim k As Integer = 0

        k = ecremcre.ActualizaCondicion(pccodcta, cCondic)
      

        'cCondic = "J"

        Dim entidadCretlin As New SIM.EL.cretlin
        Dim eCretlin As New SIM.BL.cCretlin
        entidadCretlin.cnrolin = lcnrolin
        eCretlin.ObtenerCretlinPorllave(entidadCretlin)
        lccodlin = entidadCretlin.ccodlin

        lcmetodo = lccodlin.Substring(4, 2)
        lccodigo = lccodlin.Substring(2, 2)

        'Graba Partida contable
        cClsAdP._dfecmod = Session("gdfecsis")
        cClsAdP._ccodusu = Session("gcCodusu")
        cClsAdP._ccodofi = lcoficina
        cClsAdP._ffondos = clsdes.ConvertidorFondos(lccodigo.Trim)
        cClsAdP._cconcepto = "PARTIDA DIARIA DE RECLASIFICACION " + cGlosa.Trim
        cClsAdP._dfeccnt = ldfecha
        cClsAdP._cpoliza = " "
        cClsAdP._nCuenta = Integer.Parse(HiddenField1.Value)  '1
        cClsAdP._cnumdoc = "R"
        cClsAdP._llbandera = True
        cClsAdP._ccodpres = pccodcta
        If cClsAdP._nCuenta = 1 Then
        Else
            cClsAdP._cNumpar = HiddenField2.Value.Trim
        End If
        Dim lndebe As Double = 0
        Dim lnhaber As Double = 0
        Dim lccondic As String
        'Carga la cuenta de traslado

        Dim lnsaldos As Double = 0

        lnsaldos = Math.Round(lnsalcap + lnsalint + lnsalmor, 2)


        lndebe = lnsaldos
        lnhaber = 0
        If cCondic = "S" Then 'Traslado a Cartera Castigada
            If lnsalcap > 0 Then
                lndebe = lnsalcap
                lnhaber = 0
                lcmascara = "CEECI"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                'Carga--------
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    ' Exit Sub
                End If
                cClsAdP._nCuenta += 1

                'Abona--------
                'Abona la cuenta de la condicion Anterior
                lndebe = 0
                lnhaber = lnsalcap

                lccondic = cCondic
                lcctactb = clase.CuentaContable(lcmetodo, lccondicv, lcaux)


                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta

                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    'Exit Sub
                End If
                cClsAdP._nCuenta += 1

                lndebe = lnsalcap
                lnhaber = 0
                lcmascara = "CKPXS"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                'Carga--------
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    ' Exit Sub
                End If
                cClsAdP._nCuenta += 1
            End If
            If lnsalint > 0 Then
                lndebe = lnsalint
                lnhaber = 0
                lcmascara = "CINFN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                'Carga--------
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    ' Exit Sub
                End If
                cClsAdP._nCuenta += 1

                'Abona--------
                'Abona la cuenta de la condicion Anterior
                lndebe = 0
                lnhaber = lnsalint
                lcmascara = "CINNN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta

                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    'Exit Sub
                End If
                cClsAdP._nCuenta += 1

                lndebe = lnsalint
                lnhaber = 0
                lcmascara = "CINXS"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                'Carga--------
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    ' Exit Sub
                End If
                cClsAdP._nCuenta += 1

            End If
            If lnsalmor > 0 Then
                lndebe = lnsalmor
                lnhaber = 0
                lcmascara = "CMOFN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                'Carga--------
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    ' Exit Sub
                End If
                cClsAdP._nCuenta += 1

                'Abona--------
                'Abona la cuenta de la condicion Anterior
                lndebe = 0
                lnhaber = lnsalmor
                lcmascara = "CMONN"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta

                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    'Exit Sub
                End If
                cClsAdP._nCuenta += 1

                lndebe = lnsalmor
                lnhaber = 0
                lcmascara = "CMOXS"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                'Carga--------
                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta
                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    ' Exit Sub
                End If
                cClsAdP._nCuenta += 1
            End If

            If lnsaldos > 0 Then
                lndebe = 0
                lnhaber = lnsaldos
                lcmascara = "CCJXS"
                If lcmascara <> Nothing Then
                    entidadtabtmak.ccodigo = lcmascara
                    busquedaplantilla = etabtmak.ObtenerTabtmak(entidadtabtmak)
                    If busquedaplantilla = 0 Then
                        lcctactb = "*"
                    Else
                        cplanti = entidadtabtmak.cplanti.Trim
                        lcctactb = cplanti.Trim
                    End If
                End If

                cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
                cClsAdP._ccodcta = lcctactb
                cClsAdP._ndebe = lndebe
                cClsAdP._nhaber = lnhaber
                cClsAdP._cclase = Left(lcctactb, 1)
                cClsAdP._cpoliza = "AR"
                cClsAdP._ccodpres = pccodcta

                oki = cClsAdP.AdPartida()

                If oki = "0" Then 'Ocurrio un Error
                    'Exit Sub
                End If
                cClsAdP._nCuenta += 1
            End If
        Else
            lndebe = lnsalcap
            lnhaber = 0
            lcctactb = clase.CuentaContable(lcmetodo, cCondic, lcaux)
            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
            cClsAdP._ccodcta = lcctactb
            cClsAdP._ndebe = lndebe
            cClsAdP._nhaber = 0
            cClsAdP._cclase = Left(lcctactb, 1)
            cClsAdP._cpoliza = "AR"
            cClsAdP._ccodpres = pccodcta
            oki = cClsAdP.AdPartida()

            If oki = "0" Then 'Ocurrio un Error
                Exit Sub
            End If
            cClsAdP._nCuenta += 1

            'Abona la cuenta de la condicion Anterior

            lccondic = Me.txtcondicion.Text.Trim
            lcctactb = clase.CuentaContable(lcmetodo, lccondic, lcaux)


            cClsAdP._cnumlin = cClsAdP._nCuenta.ToString
            cClsAdP._ccodcta = lcctactb
            cClsAdP._ndebe = 0
            cClsAdP._nhaber = lndebe
            cClsAdP._cclase = Left(lcctactb, 1)
            cClsAdP._cpoliza = "AR"
            cClsAdP._ccodpres = pccodcta

            oki = cClsAdP.AdPartida()

            If oki = "0" Then 'Ocurrio un Error
                Exit Sub
            End If
            cClsAdP._nCuenta += 1
        End If
        HiddenField2.Value = oki
        HiddenField1.Value = cClsAdP._nCuenta.ToString




    End Sub

    Private Sub Procesar()
        Dim ecreditos As New ccreditos
        Dim lnsaldo As Double = 0
        Dim lccodcta As String
        Dim ldfecval As Date
        
        Dim ok As Integer
        
        Dim clsaplica As New SIM.BL.payment

        
        Try
            lccodcta = Me.txtccodcta.Text.Trim
            If Me.txtccodcta.Text.Trim = Nothing Then
                Response.Write("<script language='javascript'>alert('Cuenta vacía')</script>")
                Return
            End If
            ldfecval = Session("gdfecsis")
            clsaplica.pccodcta = lccodcta
            clsaplica.pdfecval = ldfecval
            clsaplica.gdfecsis = Session("gdfecsis")
            clsaplica.gnperbas = Session("gnperbas")
            clsaplica.gdultpag = #2/1/1970#
            clsaplica.pcestado = "F"
            Dim clsppal As New class1
            Dim lncuota As Double
            clsppal.gnperbas = Session("gnperbas")
            clsppal.pnComtra = Session("gnComTra")
            clsppal.pnSegVm = Session("gnSegVm")

            lncuota = clsppal.ValorCuota(lccodcta)

            ok = clsaplica.omcalcinterest("T", ldfecval)
            If ok = 9 Then
                Response.Write("<script language='javascript'>alert('Crédito Cancelado')</script>")
                Exit Try
            End If
            If ok = 1 Then
                Me.txtnsalint.Text = utilNumeros.Redondear(clsaplica.pnsalint, 2)
                Me.txtnsalmor.Text = utilNumeros.Redondear(clsaplica.pnsalmor, 2)
                Me.txtnsalcap.Text = utilNumeros.Redondear(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                lnsaldo = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2).ToString()
                'Me.txtdultpag.Text = clsaplica.pdultpag
                Me.txtndiaatr.Text = utilNumeros.Redondear(clsaplica.pndiaatr, 0).ToString
                '                Me.txtmoncuo.Text = utilNumeros.Redondear(clsaplica.pnmoncuo, 2).ToString
                'Me.txtdeucap.Text = utilNumeros.Redondear(clsaplica.pndeucap, 2).ToString
                Me.txtntotal.Text = (lnsaldo + utilNumeros.Redondear(clsaplica.pnsalint, 2) + utilNumeros.Redondear(clsaplica.pnsalmor, 2))

                'Calcula comisiones y seguro
                'Calculo de la comision por tramite ----------------->>>>
                Dim ecretlin As New cretlin
                Dim mcretlin As New cCretlin
                Dim lcnrolin As String


                Dim lncomision, lncapdes, lnsegdeu, lngasadm, lntotcom As Double
                Dim ldfecvig As Date
                Dim lccodlin As String
                Dim lndias As Integer
                Dim lsegdeu As Boolean

                lncapdes = clsaplica.pncapdes
                ldfecvig = clsaplica.pdfecvig

                lcnrolin = clsaplica.cnrolin
                ecretlin.cnrolin = lcnrolin
                mcretlin.ObtenerCretlin(ecretlin)
                lsegdeu = ecretlin.lsegdeu
                lccodlin = ecretlin.ccodlin

                Dim ecredkar As New cCredkar
                Dim ldultfecha As Date
                ldultfecha = ecredkar.UltimafechaProceso(lccodcta.Trim, ldfecval)
                lndias = ldfecval.ToOADate - ldultfecha.ToOADate

                If lccodlin.Substring(8, 2) = "06" Then
                    lncomision = 0
                Else
                    If ldfecvig > #11/1/2005# Then
                        lncomision = utilNumeros.Redondear((lncapdes * (Session("gncomtra") / 100) * lndias) / Session("gnperbas"), 2)
                    Else
                        lncomision = 0
                    End If

                End If
                If lsegdeu = True Then
                    lnsegdeu = (lncapdes * Session("gnSegVm") / 31) * lndias
                Else
                    lnsegdeu = 0
                End If
                lnsegdeu = utilNumeros.Redondear(lnsegdeu, 2)

                lntotcom = lncomision + lnsegdeu
                'Me.txtnseguro.Text = lnsegdeu
                'Me.txtcomisiones.Text = lncomision
                '--------------------------------------------------------->>>>

                'lntotal = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                'Me.txttotal.Text = utilNumeros.Redondear(Double.Parse(Me.txtcapita.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                'Me.txttotal.Text = lntotal
                'Dim lntotalaldia As Double
                'lntotalaldia = utilNumeros.Redondear(Double.Parse(Me.txtdeucap.Text) + Double.Parse(Me.txtinteres.Text) + Double.Parse(Me.txtmora.Text) + Double.Parse(Me.txtcomisiones.Text) + Double.Parse(Me.txtnseguro.Text), 2).ToString
                'Me.txtaldia.Text = lntotalaldia
                Dim lccondic As String = ""
                Dim lcstatus As String = ""
                Dim ecremcre As New cremcre
                Dim mcremcre As New cCremcre
                ecremcre.ccodcta = lccodcta
                mcremcre.ObtenerCremcre(ecremcre)

                lccondic = IIf(IsDBNull(ecremcre.ccondic), "", ecremcre.ccondic)
                lcstatus = mcremcre.StatusCredito(lccondic)
                lblmensaje.Text = "Estado del Credito Actual: " & lcstatus.Trim
                'If cbxtraslado.SelectedValue.Trim = "J" Then
                '    UpdatePanel1.Visible = True
                'Else
                UpdatePanel1.Visible = False
                UpdatePanel2.Visible = False
                'End If


            Else
                Response.Write("<script language='javascript'>alert('Cuenta no tiene movimientos')</script>")
            End If
        Catch
            Response.Write("<script language='javascript'>alert('Problemas con cadena de conexión')</script>")
        End Try

    End Sub


    Protected Sub cbxtralado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxtraslado.SelectedIndexChanged
        'If cbxtraslado.SelectedValue.Trim = "J" Then
        '    UpdatePanel1.Visible = True
        'Else
        '    UpdatePanel1.Visible = False
        'End If
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Dim lcnombar As String
        Dim input As String
        Dim clsaplica As New SIM.BL.payment

        lcnombar = txtnombar.Text.Trim

        'lee un archivo de texto
        Dim FILE_NAME As String = "c:/txt/" & lcnombar

        If Not File.Exists(FILE_NAME) Then
            Response.Write("<script language='javascript'>alert('Archivo No Encontrado')</script>")
            Return
        End If
        Dim sr As StreamReader = File.OpenText(FILE_NAME)

        Input = sr.ReadLine()
        Dim lcampos1 As String
        Dim ltipos1 As String
        Dim lcTras As DataTable
        Dim clsprin As New class1

        lcampos1 = "ccodcta,ccodcli,cnomcli,coficina,ccondic,ndiaatr,nmorcap,nsalcap,nsalint,nsalmor,"
        ltipos1 = "S,S,S,S,S,I,D,D,D,D,"
        lcTras = clsprin.creadatasetdesconec(lcampos1, ltipos1, "CASTIGO")

        Dim lnnumlin As Integer = 0
        Dim dsclientes As New DataSet
        Dim mcreditos As New ccreditos
        Dim drfila As DataRow
        Dim lccodcli As String = ""
        Dim lcnomcli As String = ""
        Dim lcoficina As String = ""
        Dim lccondic As String = ""
        Dim ldfecval As Date = Session("gdfecsis")
        Dim ok As Integer = 0
        While Not input Is Nothing
            'input = sr.ReadLine()
            If input = Nothing Then
                Exit While
            End If
            lnnumlin += 1
            If input.Length = 18 Then
                Dim lclinea As String
                Dim longlinea As Integer
                Dim lccadena As String = ""
                Dim lccadind As String
               
                Dim lccodcta As String = ""
                Dim contador As Integer = 1

                lclinea = input.Trim
                longlinea = lclinea.Length - 1
                For i = 0 To longlinea
                    lccadind = lclinea.Substring(i, 1)
                    lccadena = lccadena & lclinea.Substring(i, 1)
                Next

                lccodcta = lccadena

                dsclientes = mcreditos.ObtenerDataSetPorcredito11(lccodcta)
                
                If dsclientes.Tables(0).Rows.Count = 1 Then
                    If dsclientes.Tables(0).Rows(0)("cestado") = "F" Then
                        lccodcli = dsclientes.Tables(0).Rows(0)("ccodcli")
                        lcnomcli = dsclientes.Tables(0).Rows(0)("cnomcli")
                        lcoficina = dsclientes.Tables(0).Rows(0)("coficina")
                        lccondic = dsclientes.Tables(0).Rows(0)("ccondic")

                        ldfecval = Session("gdfecsis")
                        clsaplica.pccodcta = lccodcta
                        clsaplica.pdfecval = ldfecval
                        clsaplica.gdfecsis = Session("gdfecsis")
                        clsaplica.gnperbas = Session("gnperbas")
                        clsaplica.gdultpag = #2/1/1970#
                        clsaplica.pcestado = "F"
                        Dim clsppal As New class1
                        Dim lncuota As Double
                        clsppal.gnperbas = Session("gnperbas")
                        clsppal.pnComtra = Session("gnComTra")
                        clsppal.pnSegVm = Session("gnSegVm")

                        lncuota = clsppal.ValorCuota(lccodcta)

                        ok = clsaplica.omcalcinterest("T", ldfecval)
                        If ok = 1 And lccondic <> "S" Then
                            drfila = lcTras.NewRow()
                            drfila("ccodcta") = lccodcta
                            drfila("ccodcli") = lccodcli
                            drfila("cnomcli") = lcnomcli
                            drfila("coficina") = lcoficina
                            drfila("ccondic") = lccondic
                            drfila("ndiaatr") = clsaplica.pndiaatr
                            drfila("nmorcap") = clsaplica.pndeucap
                            drfila("nsalcap") = Math.Round(clsaplica.pncapdes - clsaplica.pncappag, 2)
                            drfila("nsalint") = Math.Round(clsaplica.pnsalint, 2)
                            drfila("nsalmor") = Math.Round(clsaplica.pnsalmor, 2)
                            lcTras.Rows.Add(drfila)
                        End If
                      
                    End If
                End If
            End If
            input = sr.ReadLine()
        End While
        sr.Close()
        Dim dstmp As New DataSet
        dstmp.Tables.Add(lcTras)
        If dstmp.Tables(0).Rows.Count = 0 Then
        Else
            GridView1.Visible = True
            GridView1.DataSource = dstmp.Tables(0)
            GridView1.DataBind()
            btnaplicar.Enabled = True
        End If
    End Sub
    Private Sub Trasladar(ByVal pccodcta As String, ByVal pccondic As String, ByVal lcoficina As String, ByVal lnsalcap As Decimal, ByVal lnsalint As Decimal, ByVal lnsalmor As Decimal)
        Dim pcnewcondic As String
        Dim lcglosa As String = ""

        Dim lnGrabar As Integer = 0
        Dim lnPartida As Integer = 0
        Me.lblmensaje.Text = ""
        ' pccondic = Me.txtcondicion.Text.Trim
        pcnewcondic = Me.cbxtraslado.SelectedValue.Trim
        'If Me.txtcestado.Text.Trim <> "F" Then
        '    Me.lblmensaje.Text = "Crédito No esta Vigente"
        '    lnGrabar = 0
        '    Return
        'End If

        If pccondic = "N" And pcnewcondic = "N" Then  'De Normal a Normal
            Me.lblmensaje.Text = "Crédito No puede ser Trasladado"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "P" And pcnewcondic = "P" Then 'De Prejud a Prejud
            Me.lblmensaje.Text = "Crédito esta en Cobranza Pre-Judicial"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "J" And pcnewcondic = "J" Then 'De Judicial a Judicial
            Me.lblmensaje.Text = "Crédito esta en Cobranza Judicial"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "P" And pcnewcondic = "N" Then   'OK De Normal a Prejudicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        ElseIf pccondic = "N" And pcnewcondic = "P" Then   'OK De PreJudicial  a Normal
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0
        ElseIf pccondic = "S" And pcnewcondic = "S" Then  'De Saneado a Saneado
            Me.lblmensaje.Text = "Crédito esta en Cartera Saneada"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "V" And pcnewcondic = "S" Then  'OK De vencido a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
            lcglosa = "SANEADO"
        ElseIf pccondic = "M" And pcnewcondic = "S" Then  'OK De vencido a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
            lcglosa = "SANEADO"
        ElseIf pccondic = "S" And (pcnewcondic = "N" Or pcnewcondic = "P" Or pcnewcondic = "J") Then  'De Saneado a Otros
            Me.lblmensaje.Text = "Crédito esta en Cartera Saneada"
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "N" And pcnewcondic = "J" Then   'OK De Normal a judicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0 '1
            lcglosa = "COBRO JUDICIAL"
        ElseIf pccondic = "V" And pcnewcondic = "J" Then   'OK De Vencido a judicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0 '1
            lcglosa = "COBRO JUDICIAL"
        ElseIf pccondic = "M" And pcnewcondic = "J" Then   'OK De Mora a judicial
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 0 '1
            lcglosa = "COBRO JUDICIAL"
        ElseIf pccondic = "N" And pcnewcondic = "S" Then   'De Normal a Saneado
            'Me.lblmensaje.Text = "Crédito no esta Vencido"
            lnGrabar = 1
            lnPartida = 1
            lcglosa = "SANEADO"
        ElseIf pccondic = "P" And pcnewcondic = "S" Then   'De Pre judicial a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
            lcglosa = "SANEADO"
        ElseIf pccondic = "J" And pcnewcondic = "S" Then   'De judicial a Saneado
            Me.lblmensaje.Text = ""
            lnGrabar = 1
            lnPartida = 1
            lcglosa = "SANEADO"
        ElseIf pccondic = "J" And pcnewcondic = "P" Then   'OK De judicial a prejudicial
            Me.lblmensaje.Text = ""
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "J" And pcnewcondic = "N" Then   'OK De judicial a normal
            Me.lblmensaje.Text = ""
            lnGrabar = 0
            lnPartida = 0
        ElseIf pccondic = "N" And pcnewcondic = "K" Then
            lnPartida = 0
            lnGrabar = 1
        ElseIf pccondic = "P" And pcnewcondic = "K" Then
            lnPartida = 0
            lnGrabar = 1
        ElseIf pccondic = "J" And pcnewcondic = "K" Then
            lnPartida = 0
            lnGrabar = 1
        ElseIf pccondic = "V" And pcnewcondic = "K" Then
            lnPartida = 0
            lnGrabar = 1
        ElseIf pccondic = "M" And pcnewcondic = "K" Then
            lnPartida = 0
            lnGrabar = 1
        Else
            lnGrabar = 0
            lnPartida = 0
        End If
        If lnPartida = 1 Then
            '   Partida()

            ReclasificacionCartera(Me.cbxtraslado.SelectedValue.Trim, lcglosa.Trim, pccodcta, lcoficina, lnsalcap, lnsalint, lnsalmor)
        End If

        If lnGrabar = 1 Then
            Dim lnvalida As Integer
            Dim entidadCreditos As New creditos
            Dim eCreditos As New SIM.BL.ccreditos

            Dim i As Integer
            Dim ecremcre As New cCremcre
            entidadCreditos.ccondic = pcnewcondic
            entidadCreditos.ccontra = pcnewcondic
            entidadCreditos.dfectra = Me.TXTFECPRO.Text
            entidadCreditos.ccodcta = pccodcta
            lnvalida = eCreditos.Trasladar(entidadCreditos)


            If pcnewcondic = "J" Or pcnewcondic = "S" Then
                i = ecremcre.ActualizaSuspensiondeCredito(pccodcta, Session("gdfecsis"), "G", "99999")
                'Graba Datos Adicionales
                If pcnewcondic = "J" Then
                    Dim entidadCremcre As New cremcre
                    entidadCremcre.ccodcta = pccodcta
                    entidadCremcre.cjuzgado = txtjuzgado.Text.Trim
                    entidadCremcre.cnumjuicio = txtjuicio.Text.Trim
                    entidadCremcre.cabogado = cmbAbogado.SelectedValue.Trim
                    entidadCremcre.dfecdemanda = Date.Parse(txtfechademanda.Text)
                    entidadCremcre.csitactual = txtsituacion.Text.Trim
                    entidadCremcre.nvaldemanda = Double.Parse(txtvalord.Text)
                    entidadCremcre.dfecdes = Date.Parse(txtfechaDes.Text)
                    entidadCremcre.nvalordesc = Decimal.Parse(txtvalormen.Text)
                    entidadCremcre.ccodusu = Session("gccodusu")
                    entidadCremcre.dfecmod = Session("gdfecsis")

                    i = ecremcre.TrasladaDatos(entidadCremcre)
                End If

            End If

            If lnvalida = 1 Then

                '  Response.Write("<script language='javascript'>alert('Traslado Correcto')</script>")
            Else
                ' Response.Write("<script language='javascript'>alert('Traslado no se realizo')</script>")
            End If
            'Me.CargarDatos()
        End If
    End Sub
End Class


