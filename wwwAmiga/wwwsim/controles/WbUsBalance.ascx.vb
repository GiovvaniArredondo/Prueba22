Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Partial Class WbUsBalance
    Inherits ucWBase

#Region "Metodos"
    Sub Disponible()
        Dim LNDISPO As Double
        Dim LNPOR As Double

        LNPOR = Me.TextBox16.Text.Trim
        LNDISPO = (Decimal.Parse(Me.TextBox1.Text) + Decimal.Parse(Me.TextBox4.Text) + Decimal.Parse(Me.TextBox31.Text)) - (Val(Me.TextBox12.Text) + Decimal.Parse(Me.TextBox13.Text) + Decimal.Parse(Me.TextBox14.Text) + Decimal.Parse(Me.TextBox15.Text) + Decimal.Parse(Me.TextBox17.Text))
        LNDISPO = (LNDISPO * LNPOR) / 100
        Me.TextBox27.Text = LNDISPO
        '   (Double.Parse(Me.TextBox1.Text) + Double.Parse(Me.TextBox4.Text) + Double.Parse(Me.TextBox31.Text)) - (Val(Me.TextBox12.Text) + Double.Parse(Me.TextBox13.Text) + Double.Parse(Me.TextBox14.Text) + Double.Parse(Me.TextBox15.Text) + Double.Parse(Me.TextBox17.Text))
    End Sub


    Private Sub Valida_Campos()
        'Validaciones de los campos
        If Me.TextBox8.Text.Trim = "" Or Me.TextBox8.Text.Trim = Nothing Then
            Me.TextBox8.Text = 0
        End If
        If Me.TextBox9.Text.Trim = "" Or Me.TextBox9.Text.Trim = Nothing Then
            Me.TextBox9.Text = 0
        End If
        If Me.TextBox10.Text.Trim = "" Or Me.TextBox10.Text.Trim = Nothing Then
            Me.TextBox10.Text = 0
        End If
        If Me.TextBox26.Text.Trim = "" Or Me.TextBox26.Text.Trim = Nothing Then
            Me.TextBox26.Text = 0
        End If
        If Me.TextBox19.Text.Trim = "" Or Me.TextBox19.Text.Trim = Nothing Then
            Me.TextBox19.Text = 0
        End If
        If Me.TextBox20.Text.Trim = "" Or Me.TextBox20.Text.Trim = Nothing Then
            Me.TextBox20.Text = 0
        End If
        If Me.TextBox21.Text.Trim = "" Or Me.TextBox21.Text.Trim = Nothing Then
            Me.TextBox21.Text = 0
        End If
        If Me.TextBox12.Text.Trim = "" Or Me.TextBox12.Text.Trim = Nothing Then
            Me.TextBox12.Text = 0
        End If
        If Me.TextBox13.Text.Trim = "" Or Me.TextBox13.Text.Trim = Nothing Then
            Me.TextBox13.Text = 0
        End If
        If Me.TextBox14.Text.Trim = "" Or Me.TextBox14.Text.Trim = Nothing Then
            Me.TextBox14.Text = 0
        End If

        If Me.TextBox1.Text.Trim = "" Or Me.TextBox1.Text.Trim = Nothing Then
            Me.TextBox1.Text = 0
        End If

        If Me.TextBox4.Text.Trim = "" Or Me.TextBox4.Text.Trim = Nothing Then
            Me.TextBox4.Text = 0
        End If

        If Me.TextBox11.Text.Trim = "" Or Me.TextBox11.Text.Trim = Nothing Then
            Me.TextBox11.Text = 0
        End If

        If Me.TextBox15.Text.Trim = "" Or Me.TextBox15.Text.Trim = Nothing Then
            Me.TextBox15.Text = 0
        End If

        If Me.TextBox16.Text.Trim = "" Or Me.TextBox16.Text.Trim = Nothing Then
            Me.TextBox16.Text = 0
        End If

        If Me.TextBox17.Text.Trim = "" Or Me.TextBox17.Text.Trim = Nothing Then
            Me.TextBox17.Text = 0
        End If

        If Me.TextBox31.Text.Trim = "" Or Me.TextBox31.Text.Trim = Nothing Then
            Me.TextBox31.Text = 0
        End If
    End Sub

    Sub Imprevistos()
        ' Me.TextBox17.Text =  (Double.Parse(Me.TextBox12.Text) + Double.Parse(Me.TextBox13.Text) + Double.Parse(Me.TextBox14.Text) + Double.Parse(Me.TextBox15.Text)) * ((100 - Double.Parse(Me.TextBox16.Text)) / 100)
    End Sub

    Sub ActCirculante()
        Me.TextBox25.Text = Double.Parse(Me.TextBox8.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox26.Text)
    End Sub

    Sub Activo()
        'Me.TextBox5.Text = Double.Parse(Me.TextBox25.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.TextBox11.Text)
        Me.TextBox5.Text = Double.Parse(Me.TextBox8.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox26.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.TextBox11.Text)

    End Sub

    Sub Pas_Patri()
        'Me.TextBox23.Text = Double.Parse(Me.TextBox5.Text)
        If Me.TextBox18.Text = "" Then
            Me.TextBox18.Text = 0.0
        End If


        Me.TextBox23.Text = Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Double.Parse(Me.TextBox19.Text) + Double.Parse(Me.TextBox18.Text)
    End Sub

    Sub Pasivo()
        Me.TextBox22.Text = Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Val(Me.TextBox19.Text)
    End Sub

    Sub Patrimonio()
        Me.TextBox5.Text = Double.Parse(Me.TextBox8.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox26.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.TextBox11.Text)

        Me.TextBox18.Text = Double.Parse(Me.TextBox5.Text) - (Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Double.Parse(Me.TextBox19.Text))
        Me.TextBox23.Text = Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Double.Parse(Me.TextBox19.Text) + Double.Parse(Me.TextBox18.Text)

    End Sub


    Sub Habilita()
        Me.TextBox1.Enabled = True
        Me.TextBox4.Enabled = True
        Me.TextBox31.Enabled = True
        Me.TextBox12.Enabled = True
        Me.TextBox15.Enabled = True
        Me.TextBox16.Enabled = True
        Me.TextBox17.Enabled = True
        Me.TextBox8.Enabled = True
        Me.TextBox9.Enabled = True
        Me.TextBox10.Enabled = True
        Me.TextBox11.Enabled = True
        Me.TextBox13.Enabled = True
        Me.TextBox14.Enabled = True
        Me.TextBox19.Enabled = True
        Me.TextBox20.Enabled = True
        Me.TextBox21.Enabled = True
        'Me.TextBox25.Enabled = True
        Me.TextBox26.Enabled = True
        'Me.btnnuevo.Disabled = True
        Me.TxtdFecha.Enabled = True

    End Sub

    Sub Deshabilita()
        Me.TextBox1.Enabled = False
        Me.TextBox4.Enabled = False
        Me.TextBox31.Enabled = False
        Me.TextBox12.Enabled = False
        Me.TextBox15.Enabled = False
        Me.TextBox16.Enabled = False
        Me.TextBox17.Enabled = False
        Me.TextBox8.Enabled = False
        Me.TextBox9.Enabled = False
        Me.TextBox10.Enabled = False
        Me.TextBox11.Enabled = False
        Me.TextBox19.Enabled = False
        Me.TextBox20.Enabled = False
        Me.TextBox21.Enabled = False
        Me.TextBox25.Enabled = False
        Me.TextBox26.Enabled = False
        Me.TextBox13.Enabled = False
        Me.TextBox14.Enabled = False
        Me.btnuevo.Enabled = True
        Me.btgrabar.Enabled = False
        Me.TxtdFecha.Enabled = False



    End Sub

    Sub limpia()

        'Limpiando

        Me.TextBox1.Text = 0
        Me.TextBox4.Text = 0
        Me.TextBox31.Text = 0
        Me.TextBox12.Text = 0
        Me.TextBox13.Text = 0
        Me.TextBox14.Text = 0
        Me.TextBox15.Text = 0
        Me.TextBox16.Text = 0
        Me.TextBox17.Text = 0
        Me.TextBox8.Text = 0
        Me.TextBox9.Text = 0
        Me.TextBox10.Text = 0
        Me.TextBox11.Text = 0
        Me.TextBox19.Text = 0
        Me.TextBox20.Text = 0
        Me.TextBox21.Text = 0
        Me.TextBox26.Text = 0
        Me.TextBox18.Text = 0
        Me.TextBox22.Text = 0
        Me.TextBox23.Text = 0
        Me.TextBox25.Text = 0
        Me.TextBox27.Text = 0
        Me.TextBox5.Text = 0
        ' Me.TxtdFecha.Text = Session("gdFecSis")
        Txtingresos.Text = 0
        Txtegresos.Text = 0
    End Sub

    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Dim gdfecsis As Date = Session("gdfecsis")
        Dim ldfecha As Date

        Me.Txtcomodin.Text = codigoCliente
        Me.txtcodcli.Text = codigoCliente
        Me.txtfuente.Text = Me.txtfuente.Text.Trim
        ldfecha = Date.Parse(Me.TxtdFecha.Text)


        '********** carga datos para modificarlos **************

        Dim mclidbal As New cClidbal
        Dim eclidbal As New clidbal
        Dim ds As New DataSet
        Dim ok As Integer

        If Me.txtfuente.Text = "" Or Me.txtfuente.Text = Nothing Then
            Me.txtfuente.Text = "01"
        End If

        eclidbal.ccodcli = codigoCliente
        eclidbal.ccodfue = Me.txtfuente.Text
        ok = mclidbal.ObtenerDataSetPorID(codigoCliente, Me.txtfuente.Text, ldfecha, ds)

        If ok = 1 Then
            If ds.Tables(0).Rows.Count > 0 Then

                'Me.TxtdFecha.Text = ds.Tables(0).Rows(0)("devalua")
                Me.TextBox1.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nventas")), 0, ds.Tables(0).Rows(0)("nventas"))
                Me.TextBox4.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nrecupe")), 0, ds.Tables(0).Rows(0)("nrecupe"))
                Me.TextBox31.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("notring")), 0, ds.Tables(0).Rows(0)("notring"))
                Me.TextBox8.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nactdis")), 0, ds.Tables(0).Rows(0)("nactdis"))
                Me.TextBox9.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nctacob")), 0, ds.Tables(0).Rows(0)("nctacob"))
                Me.TextBox26.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("ninvent")), 0, ds.Tables(0).Rows(0)("ninvent"))

                Me.TextBox12.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nmercad")), 0, ds.Tables(0).Rows(0)("nmercad"))
                Me.TextBox13.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("notregr")), 0, ds.Tables(0).Rows(0)("notregr"))

                Me.TextBox14.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("npagpres")), 0, ds.Tables(0).Rows(0)("npagpres"))
                Me.TextBox15.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nimpues")), 0, ds.Tables(0).Rows(0)("nimpues"))
                Me.TextBox17.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nimprev")), 0, ds.Tables(0).Rows(0)("nimprev"))
                Me.TextBox21.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nprovee")), 0, ds.Tables(0).Rows(0)("nprovee"))
                Me.TextBox19.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("ncreins")), 0, ds.Tables(0).Rows(0)("ncreins"))

                Me.TextBox10.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nactfij")), 0, ds.Tables(0).Rows(0)("nactfij"))

                Me.TextBox16.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("nmarseg")), 0, ds.Tables(0).Rows(0)("nmarseg"))

                TextBox11.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("notract")), 0, ds.Tables(0).Rows(0)("notract"))
                TextBox20.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("notrpre")), 0, ds.Tables(0).Rows(0)("notrpre"))
                'Validaciones de los campos
                If Me.TextBox8.Text.Trim = "" Or Me.TextBox8.Text.Trim = Nothing Then
                    Me.TextBox8.Text = 0
                End If
                If Me.TextBox9.Text.Trim = "" Or Me.TextBox9.Text.Trim = Nothing Then
                    Me.TextBox9.Text = 0
                End If
                If Me.TextBox10.Text.Trim = "" Or Me.TextBox10.Text.Trim = Nothing Then
                    Me.TextBox10.Text = 0
                End If
                If Me.TextBox26.Text.Trim = "" Or Me.TextBox26.Text.Trim = Nothing Then
                    Me.TextBox26.Text = 0
                End If
                If Me.TextBox19.Text.Trim = "" Or Me.TextBox19.Text.Trim = Nothing Then
                    Me.TextBox19.Text = 0
                End If
                If Me.TextBox20.Text.Trim = "" Or Me.TextBox20.Text.Trim = Nothing Then
                    Me.TextBox20.Text = 0
                End If
                If Me.TextBox21.Text.Trim = "" Or Me.TextBox21.Text.Trim = Nothing Then
                    Me.TextBox21.Text = 0
                End If
                If Me.TextBox12.Text.Trim = "" Or Me.TextBox12.Text.Trim = Nothing Then
                    Me.TextBox12.Text = 0
                End If
                If Me.TextBox13.Text.Trim = "" Or Me.TextBox13.Text.Trim = Nothing Then
                    Me.TextBox13.Text = 0
                End If
                If Me.TextBox14.Text.Trim = "" Or Me.TextBox14.Text.Trim = Nothing Then
                    Me.TextBox14.Text = 0
                End If
                If Me.TextBox1.Text.Trim = "" Or Me.TextBox1.Text.Trim = Nothing Then
                    Me.TextBox1.Text = 0
                End If
                If Me.TextBox4.Text.Trim = "" Or Me.TextBox4.Text.Trim = Nothing Then
                    Me.TextBox4.Text = 0
                End If
                If Me.TextBox11.Text.Trim = "" Or Me.TextBox11.Text.Trim = Nothing Then
                    Me.TextBox11.Text = 0
                End If
                If Me.TextBox15.Text.Trim = "" Or Me.TextBox15.Text.Trim = Nothing Then
                    Me.TextBox15.Text = 0
                End If
                If Me.TextBox16.Text.Trim = "" Or Me.TextBox16.Text.Trim = Nothing Then
                    Me.TextBox16.Text = 100
                End If
                If Me.TextBox17.Text.Trim = "" Or Me.TextBox17.Text.Trim = Nothing Then
                    Me.TextBox17.Text = 0
                End If
                If Me.TextBox31.Text.Trim = "" Or Me.TextBox31.Text.Trim = Nothing Then
                    Me.TextBox31.Text = 0
                End If

                'agregadas 5,25,10,11
                If Me.TextBox5.Text.Trim = "" Or Me.TextBox5.Text.Trim = Nothing Then
                    Me.TextBox5.Text = 0
                End If
                If Me.TextBox25.Text.Trim = "" Or Me.TextBox25.Text.Trim = Nothing Then
                    Me.TextBox25.Text = 0
                End If
                If Me.TextBox10.Text.Trim = "" Or Me.TextBox10.Text.Trim = Nothing Then
                    Me.TextBox10.Text = 0
                End If
                If Me.TextBox11.Text.Trim = "" Or Me.TextBox11.Text.Trim = Nothing Then
                    Me.TextBox11.Text = 0
                End If


                'Totalizando
                Me.Disponible()
                Me.Activo()
                Me.Imprevistos()
                Me.ActCirculante()
                Me.Pas_Patri()
                Me.Pasivo()
                Me.Patrimonio()


                If Me.TextBox27.Text < 0 Then
                    Me.TextBox27.Text = 0
                End If

            Else
                'Validaciones de los campos
                If Me.TextBox8.Text.Trim = "" Or Me.TextBox8.Text.Trim = Nothing Then
                    Me.TextBox8.Text = 0
                End If
                If Me.TextBox9.Text.Trim = "" Or Me.TextBox9.Text.Trim = Nothing Then
                    Me.TextBox9.Text = 0
                End If
                If Me.TextBox10.Text.Trim = "" Or Me.TextBox10.Text.Trim = Nothing Then
                    Me.TextBox10.Text = 0
                End If
                If Me.TextBox26.Text.Trim = "" Or Me.TextBox26.Text.Trim = Nothing Then
                    Me.TextBox26.Text = 0
                End If
                If Me.TextBox19.Text.Trim = "" Or Me.TextBox19.Text.Trim = Nothing Then
                    Me.TextBox19.Text = 0
                End If
                If Me.TextBox20.Text.Trim = "" Or Me.TextBox20.Text.Trim = Nothing Then
                    Me.TextBox20.Text = 0
                End If
                If Me.TextBox21.Text.Trim = "" Or Me.TextBox21.Text.Trim = Nothing Then
                    Me.TextBox21.Text = 0
                End If
                If Me.TextBox12.Text.Trim = "" Or Me.TextBox12.Text.Trim = Nothing Then
                    Me.TextBox12.Text = 0
                End If
                If Me.TextBox13.Text.Trim = "" Or Me.TextBox13.Text.Trim = Nothing Then
                    Me.TextBox13.Text = 0
                End If
                If Me.TextBox14.Text.Trim = "" Or Me.TextBox14.Text.Trim = Nothing Then
                    Me.TextBox14.Text = 0
                End If
                If Me.TextBox1.Text.Trim = "" Or Me.TextBox1.Text.Trim = Nothing Then
                    Me.TextBox1.Text = 0
                End If
                If Me.TextBox4.Text.Trim = "" Or Me.TextBox4.Text.Trim = Nothing Then
                    Me.TextBox4.Text = 0
                End If
                If Me.TextBox11.Text.Trim = "" Or Me.TextBox11.Text.Trim = Nothing Then
                    Me.TextBox11.Text = 0
                End If
                If Me.TextBox15.Text.Trim = "" Or Me.TextBox15.Text.Trim = Nothing Then
                    Me.TextBox15.Text = 0
                End If
                'If Me.TextBox16.Text.Trim = "" Or Me.TextBox16.Text.Trim = Nothing Then
                '    Me.TextBox16.Text = 0
                'End If
                If Me.TextBox17.Text.Trim = "" Or Me.TextBox17.Text.Trim = Nothing Then
                    Me.TextBox17.Text = 0
                End If
                If Me.TextBox31.Text.Trim = "" Or Me.TextBox31.Text.Trim = Nothing Then
                    Me.TextBox31.Text = 0
                End If

                'agregadas 5,25,10,11
                If Me.TextBox5.Text.Trim = "" Or Me.TextBox5.Text.Trim = Nothing Then
                    Me.TextBox5.Text = 0
                End If
                If Me.TextBox25.Text.Trim = "" Or Me.TextBox25.Text.Trim = Nothing Then
                    Me.TextBox25.Text = 0
                End If
                If Me.TextBox10.Text.Trim = "" Or Me.TextBox10.Text.Trim = Nothing Then
                    Me.TextBox10.Text = 0
                End If
                If Me.TextBox11.Text.Trim = "" Or Me.TextBox11.Text.Trim = Nothing Then
                    Me.TextBox11.Text = 0
                End If


            End If


        End If

        Calcula()
        Me.Habilita()
        Me.btgrabar.Enabled = True
        '        Me.TxtdFecha.Enabled = True


    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Ceros()

            Me.txtcodcli.Text = Session("codigo")
            Me.txtfuente.Text = Session("fuente")
            Me.TxtdFecha.Text = Session("gdfecsis")
            Session("gdfecha") = Date.Parse(TxtdFecha.Text)

            Dim eclimide As New climide
            Dim mclimide As New cClimide
            eclimide.ccodcli = Me.txtcodcli.Text.Trim
            mclimide.ObtenerClimide(eclimide)

            Me.txtnomcli.Text = eclimide.cnomcli.Trim

            buscar_balance(Me.txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)

            'Me.TextBox21.Text = "0.00"
            'Me.TextBox20.Text = "0.00"
            'Me.TextBox19.Text = "0.00"
            'Me.TextBox18.Text = "0.00"
            'Me.TextBox23.Text = "0.00"
        Else
            Dim lnventas As Decimal = 0
            Dim eclidflujo As New cCLIDFLUJO
            lnventas = eclidflujo.ObtenerPromedio(txtcodcli.Text.Trim, txtfuente.Text.Trim, Date.Parse(TxtdFecha.Text))
            TextBox1.Text = Math.Round(lnventas, 2)
        End If

    End Sub
    Private Sub Ceros()

        Me.TextBox8.Text = 0
        Me.TextBox9.Text = 0
        Me.TextBox10.Text = 0
        Me.TextBox26.Text = 0
        Me.TextBox19.Text = 0
        Me.TextBox20.Text = 0
        Me.TextBox21.Text = 0
        Me.TextBox12.Text = 0
        Me.TextBox13.Text = 0
        Me.TextBox14.Text = 0
        Me.TextBox1.Text = 0
        Me.TextBox4.Text = 0
        Me.TextBox11.Text = 0
        Me.TextBox15.Text = 0
        Me.TextBox16.Text = 0
        Me.TextBox17.Text = 0
        Me.TextBox31.Text = 0



    End Sub
    Private Sub buscar_balance(ByVal lccodcli As String, ByVal lcfuente As String)
        Dim eclidbal As New clidbal
        Dim mclidbal As New cClidbal
        eclidbal.ccodcli = lccodcli
        Dim ds As New DataSet
        ds = mclidbal.ObtenerDataSetPorcliente(lccodcli, lcfuente)

        Me.ddlbalance.DataTextField = "devalua"
        Me.ddlbalance.DataValueField = "devalua"
        Me.ddlbalance.DataSource = ds.Tables(0)
        Me.ddlbalance.DataBind()
        ds.Tables(0).Clear()

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Valida_Campos()
        totaliza()
    End Sub



    Private Sub ddlbalance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlbalance.SelectedIndexChanged
        Me.TxtdFecha.Text = ""
    End Sub

   

    Public Sub totaliza()
        Me.Txtingresos.Text = Double.Parse(Me.TextBox1.Text) + Double.Parse(Me.TextBox4.Text) + Double.Parse(Me.TextBox31.Text)
        Me.Txtegresos.Text = Double.Parse(Me.TextBox12.Text) + Double.Parse(Me.TextBox13.Text) + Double.Parse(Me.TextBox14.Text) + _
                             Double.Parse(Me.TextBox15.Text) + Double.Parse(Me.TextBox17.Text)
        Me.TextBox27.Text = Math.Round(Double.Parse(Me.Txtingresos.Text) - Double.Parse(Me.Txtegresos.Text), 2)
    End Sub
    Public Sub totaliza2()
        'Me.TextBox5.Text = Double.Parse(Me.TextBox8.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox26.Text) + Double.Parse(Me.TextBox10.Text) + Double.Parse(Me.TextBox11.Text)
        'Me.TextBox23.Text = Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Double.Parse(Me.TextBox19.Text) + Double.Parse(Me.TextBox18.Text)
        'Me.TextBox25.Text = Double.Parse(Me.TextBox8.Text) + Double.Parse(Me.TextBox9.Text) + Double.Parse(Me.TextBox26.Text)
        'Me.TextBox22.Text = Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Val(Me.TextBox19.Text)

        'Me.TextBox18.Text = Double.Parse(Me.TextBox5.Text) - (Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Double.Parse(Me.TextBox19.Text))
        'Me.TextBox23.Text = Double.Parse(Me.TextBox21.Text) + Double.Parse(Me.TextBox20.Text) + Double.Parse(Me.TextBox19.Text) + Double.Parse(Me.TextBox18.Text)

    End Sub

    Protected Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox31_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox31.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox14_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox15_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox17_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged
        Valida_Campos()
        totaliza()
    End Sub

    Protected Sub TextBox8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox26_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox26.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox11_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox10_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox21_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox20_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub TextBox19_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged
        Valida_Campos()
        totaliza2()
    End Sub

    Protected Sub btbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btbuscar.Click
        Dim lnindice As Integer
        Dim ldfecha As Date
        If Me.ddlbalance.SelectedValue = Nothing Or Me.ddlbalance.SelectedValue = "" Then
            ldfecha = Date.Now
        Else
            ldfecha = Date.Parse(Me.ddlbalance.SelectedValue)
        End If
        Me.TxtdFecha.Text = Left(ldfecha.ToString, 10)
        CargarPorCliente(Me.txtcodcli.Text.Trim)

    End Sub

    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        Me.Habilita()
        Me.limpia()
        Me.btgrabar.Enabled = True
        Me.TxtdFecha.Enabled = True

    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click

        Dim cls As New SIM.BL.ClsFuentes
        Dim eclidbal As New SIM.BL.cClidbal
        Dim lnretorno As Integer

        If Me.TxtdFecha.Text.Trim = " " _
            Or Me.TxtdFecha.Text.Trim = Nothing Then
            Exit Sub
        End If

       

        Try

            Valida_Campos()
            'Totalizando
            Me.Disponible()
            Me.Activo()
            Me.Imprevistos()
            Me.ActCirculante()
            Me.Pasivo()
            Me.Patrimonio()
            Me.Pas_Patri()

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Existen Valores no numericos')</script>")
            Exit Sub
        End Try
        


        cls._ccodcli = Me.Txtcomodin.Text.Trim
        cls._ccodcli = Me.txtcodcli.Text.Trim
        cls._cCodfue = Me.txtfuente.Text.Trim  'eclidbal.ObtenercCodFue(Me.Txtcomodin.Text.Trim)
        cls._dEvalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        cls._dBalanc = Date.Parse(Me.TxtdFecha.Text.Trim)
        cls._nActDis = Double.Parse(Me.TextBox8.Text)
        cls._nCtaCob = Double.Parse(Me.TextBox9.Text)
        cls._nInvent = Double.Parse(Me.TextBox26.Text)
        cls._nActFij = Double.Parse(Me.TextBox10.Text)
        cls._nProvee = Double.Parse(Me.TextBox21.Text)
        cls._nOtrPre = Double.Parse(Me.TextBox20.Text)
        cls._nCreIns = Double.Parse(Me.TextBox19.Text)
        cls._nVentas = Double.Parse(Me.TextBox1.Text)
        cls._nRecupe = Double.Parse(Me.TextBox4.Text)
        cls._nMercad = Double.Parse(Me.TextBox12.Text)
        cls._nOtrEgr = Double.Parse(Me.TextBox13.Text)
        cls._nPagPres = Double.Parse(Me.TextBox14.Text)
        cls._cCodusu = Session("gccodusu")
        cls._dfecmod = Session("gdfecsis")
        cls._nOtrIng = Double.Parse(Me.TextBox31.Text)
        cls._nImpues = Double.Parse(Me.TextBox15.Text)
        cls._nImprev = Double.Parse(Me.TextBox17.Text)
        cls._nOtrAct = Double.Parse(Me.TextBox11.Text)
        cls._nmarseg = Double.Parse(Me.TextBox16.Text)



        '** antes de grabar borrara el balance que esta para archivar nuevamente el que se ha modificado **********'
        Dim mclidbal As New cClidbal
        Dim eclidbal1 As New clidbal
        Dim lccodcli As String
        Dim lccodfue As String
        Dim ok As Integer

        lccodcli = Me.txtcodcli.Text.Trim
        lccodfue = Me.txtfuente.Text.Trim

        eclidbal1.ccodcli = lccodcli
        eclidbal1.ccodfue = lccodfue
        eclidbal1.dbalanc = Date.Parse(Me.TxtdFecha.Text)
        eclidbal1.devalua = Date.Parse(Me.TxtdFecha.Text)

        'mclidbal.EliminarClidbal(eclidbal1)
        'no borrara actualizara si es la misma fecha y agregara si es otra fecha
        ok = mclidbal.ObtenerClidbal(eclidbal1)
        If ok = 0 Then
            cls.ActualizaClidBal()
        Else
            'obtiene datos que no se capturan para no ser inicializados
            Dim mlistaclidbal As New listaclidbal
            mlistaclidbal = mclidbal.ObtenerLista(eclidbal1.ccodcli, eclidbal1.ccodfue, eclidbal1.devalua)
            cls._ndinefe = mlistaclidbal(0).ndinefe
            cls._ndinban = mlistaclidbal(0).ndinban
            cls._nbienesinm = mlistaclidbal(0).nbienesinm
            cls._nbienesens = mlistaclidbal(0).nbienesens
            cls._nvehiculos = mlistaclidbal(0).nvehiculos
            cls._nganado = mlistaclidbal(0).nganado
            cls._notrosbienes = mlistaclidbal(0).notrosbienes
            cls._noblbancos = mlistaclidbal(0).noblbancos
            cls._noblens = mlistaclidbal(0).noblens
            cls._ntienyalm = mlistaclidbal(0).ntienyalm
            cls._noblgasfam = mlistaclidbal(0).noblgasfam
            cls._notrosObl = mlistaclidbal(0).notrosObl

            cls.modificaClidBal()

        End If


        Me.Deshabilita()
        Me.btgrabar.Enabled = False

        buscar_balance(Me.txtcodcli.Text.Trim, Me.txtfuente.Text.Trim)

        Response.Write("<script language='javascript'>alert('Grabado')</script>")
    End Sub

    Protected Sub btini_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btini.Click
        Me.Deshabilita()
        Me.limpia()

    End Sub

    Protected Sub btimprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btimprimir.Click
        Historico()
    End Sub
    Private Sub Historico()

        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Dim dsbalance As New DataSet
        Dim eclidbal As New clidbal
        Dim mClidbal As New cClidbal
        Dim lccodcli As String
        Dim lccodfue As String
        Dim ldevalua As Date
        Dim lcnomcli As String

        lccodcli = Me.txtcodcli.Text.Trim
        lcnomcli = Me.txtnomcli.Text.Trim

        Dim lnvalor As Double
        Dim lntotal As Double

        Dim eclidifa As New CLIDFAMI
        Dim mclidifa As New cCLIDFAMI
        Dim indica As Integer

        Dim lningfam As Double
        Dim lngasfam As Double
        Dim lccodunimax As String

        Dim eclimide As New climide
        Dim mclimide As New cClimide

        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)
        lcnomcli = eclimide.cnomcli.Trim


        'CHEQUEO DE RELACIONES INTERNAS
        Dim lcotrocre As String
        Dim ds1 As New DataSet
        Dim lnmonto As Double
        Dim lcfiador As String
        Dim dr1 As DataRow

        lcotrocre = ""
        lnmonto = 0
        lcfiador = ""
        lcotrocre = ""
        lnmonto = 0

        ds1.Tables.Clear()



        lcfiador = ""


        ds1.Tables.Clear()


        'FINALIZA CHEQUEO DE RELACIONES INTERNAS


        ldevalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        lccodunimax = mclidifa.ObtenercCoduni2(lccodcli)
        eclidifa.ccodcli = lccodcli
        eclidifa.dEvalua = ldevalua
        eclidifa.cCodUni = lccodunimax

        indica = mclidifa.ObtenerCLIDFAMI(eclidifa)
        If indica = 0 Then
            lningfam = 0
            lngasfam = 0
        Else
            lngasfam = eclidifa.nGasCasa + eclidifa.nGasEduc + eclidifa.nGasRopa + eclidifa.nGasSalu + eclidifa.ngasTran + eclidifa.nGasAlim + eclidifa.nGasAlte + eclidifa.nGasPres  ' es clidfami
            lningfam = eclidifa.nIngCony + eclidifa.nIngFami + eclidifa.nIngReme + eclidifa.nIngSSPC + eclidifa.nIngVari
        End If


        lccodfue = Me.txtfuente.Text.Trim

        lccodcli = Me.txtcodcli.Text
        dsbalance = mClidbal.ObtenerDataSetPorIDMultiple(lccodcli, lccodfue, lningfam, lngasfam, ldevalua)
        Dim hisbal As Integer
        Dim ds As New DataSet
        Dim clsppal As New class1
        hisbal = dsbalance.Tables(0).Rows.Count
        ds = clsppal.TablaBalance()

        Dim fila As DataRow
        Dim i As Integer
        Dim k As Integer
        '---------------------
        Dim ldfechatmp As Date
        Dim lndatos As Double
        For k = 0 To 44
            i = 0
            For Each fila In dsbalance.Tables(0).Rows
                If k = 0 Then
                    ldfechatmp = dsbalance.Tables(0).Rows(i)("devalua")
                    Me.Enlace(ds, Left(ldfechatmp.ToString.Trim, 10), k, i, False)
                ElseIf k = 1 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ntotact")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 2 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nactcir")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 3 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nactdis")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 4 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nctacob")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 5 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ninvent")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 6 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nactfij")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 7 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("notract")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 8 Then

                    '--------------------------------------------------------
                ElseIf k = 9 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nprovee") + dsbalance.Tables(0).Rows(i)("notrpre"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)

                ElseIf k = 10 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nprovee")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 11 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("notrpre")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 12 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ncreins")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)

                ElseIf k = 13 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ncreins")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                    '--------------------------------------------------------
                ElseIf k = 14 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("npatri")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 15 Then
                    Me.Enlace(ds, "___________", k, i, False)
                ElseIf k = 16 Then

                ElseIf k = 17 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ntoting")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 18 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ningfam")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 19 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nventas")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 20 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nrecupe")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 21 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("notring")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 22 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ntotegre")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 23 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ngasfam")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 24 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nmercad")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 25 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("notregr")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 26 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("npagpres")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 27 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nimpues")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 28 Then
                    Me.Enlace(ds, "___________", k, i, False)
                ElseIf k = 29 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("ndisfam")
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 30 Then
                    Me.Enlace(ds, "___________", k, i, False)
                ElseIf k = 31 Then

                ElseIf k = 32 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nrotinv"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 33 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("ninddeu"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 34 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nmarbru"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 35 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("ncaptra"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 36 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nliquid"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 37 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nrenneg"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 38 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nrotcic"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 39 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("ncicope"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 40 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("npunequ"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 41 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nmarseg"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 42 Then
                ElseIf k = 43 Then
                    lndatos = Math.Round(dsbalance.Tables(0).Rows(i)("nventas") - dsbalance.Tables(0).Rows(i)("nmercad"), 2)
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                ElseIf k = 44 Then
                    lndatos = dsbalance.Tables(0).Rows(i)("nventas")
                    If lndatos = 0 Then
                    Else
                        lndatos = Math.Round((dsbalance.Tables(0).Rows(i)("nmercad") / dsbalance.Tables(0).Rows(i)("nventas")) * 100, 2)
                    End If
                    Me.Enlace(ds, lndatos.ToString, k, i, True)
                End If
                i += 1
                If i > 5 Then
                    Exit For
                End If
            Next
        Next
        '-------------------------------------------

        Try
            crRpt.Load(Server.MapPath("reportes") + "\crbalecomul.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try


        crRpt.SetDataSource(ds.Tables(0))

        crRpt.SetParameterValue("lcnomcli", lcnomcli.Trim)
        '----------------------------------------------------

        Dim reportes As String
        reportes = "crbalecomul.pdf"

        rptStream = CType(crRpt.ExportToStream(ExportFormatType.PortableDocFormat), System.IO.MemoryStream)

        Response.Clear()
        Response.Buffer = True


        ' Establece el tipo de documento
        Response.ContentType = "application/pdf"
        'Automaticamente se descarga el archivo
        Response.BinaryWrite(rptStream.ToArray())
        Response.AddHeader("Content-Disposition", "attachment;filename=" & reportes)
        'Response.Flush()
        'Response.Close()
        Response.End()

    End Sub
    Private Function Enlace(ByVal ds As DataSet, ByVal cvalor As String, ByVal z As Integer, ByVal campo As Integer, ByVal laplica As Boolean) As DataSet
        Dim clsppal As New class1
        If campo = 0 Then
            If laplica = True Then
                ds.Tables(0).Rows(z)("cfecha1") = clsppal.Cominola(cvalor)
            Else
                ds.Tables(0).Rows(z)("cfecha1") = cvalor
            End If

        ElseIf campo = 1 Then
            If laplica = True Then
                ds.Tables(0).Rows(z)("cfecha2") = clsppal.Cominola(cvalor)
            Else
                ds.Tables(0).Rows(z)("cfecha2") = cvalor
            End If

        ElseIf campo = 2 Then
            If laplica = True Then
                ds.Tables(0).Rows(z)("cfecha3") = clsppal.Cominola(cvalor)
            Else
                ds.Tables(0).Rows(z)("cfecha3") = cvalor
            End If

        ElseIf campo = 3 Then
            If laplica = True Then
                ds.Tables(0).Rows(z)("cfecha4") = clsppal.Cominola(cvalor)
            Else
                ds.Tables(0).Rows(z)("cfecha4") = cvalor
            End If

        ElseIf campo = 4 Then
            If laplica = True Then
                ds.Tables(0).Rows(z)("cfecha5") = clsppal.Cominola(cvalor)
            Else
                ds.Tables(0).Rows(z)("cfecha5") = cvalor
            End If

        End If
        Return ds
    End Function

    Private Sub imprimir()
        Dim ecremcre As New cremcre
        Dim mcremcre As New cCremcre

        Dim crRpt As New ReportDocument
        Dim rptStream As New System.IO.MemoryStream

        Dim dsbalance As New DataSet
        Dim eclidbal As New clidbal
        Dim mClidbal As New cClidbal
        Dim lccodcli As String
        Dim lccodfue As String
        Dim ldevalua As Date
        Dim lcnomcli As String

        lccodcli = Me.txtcodcli.Text.Trim
        lcnomcli = Me.txtnomcli.Text.Trim

        Dim lnvalor As Double
        Dim lntotal As Double

        Dim eclidifa As New CLIDFAMI
        Dim mclidifa As New cCLIDFAMI
        Dim indica As Integer

        Dim lningfam As Double
        Dim lngasfam As Double
        Dim lccodunimax As String

        Dim eclimide As New climide
        Dim mclimide As New cClimide

        eclimide.ccodcli = lccodcli
        mclimide.ObtenerClimide(eclimide)
        lcnomcli = eclimide.cnomcli.Trim


        'CHEQUEO DE RELACIONES INTERNAS
        Dim lcotrocre As String
        Dim ds1 As New DataSet
        Dim lnmonto As Double
        Dim lcfiador As String
        Dim dr1 As DataRow

        lcotrocre = ""
        lnmonto = 0
        lcfiador = ""
        lcotrocre = ""
        lnmonto = 0

        ds1.Tables.Clear()



        lcfiador = ""


        ds1.Tables.Clear()


        'FINALIZA CHEQUEO DE RELACIONES INTERNAS


        ldevalua = Date.Parse(Me.TxtdFecha.Text.Trim)
        lccodunimax = mclidifa.ObtenercCoduni2(lccodcli)
        eclidifa.ccodcli = lccodcli
        eclidifa.dEvalua = ldevalua
        eclidifa.cCodUni = lccodunimax

        indica = mclidifa.ObtenerCLIDFAMI(eclidifa)
        If indica = 0 Then
            lningfam = 0
            lngasfam = 0
        Else
            lngasfam = eclidifa.nGasCasa + eclidifa.nGasEduc + eclidifa.nGasRopa + eclidifa.nGasSalu + eclidifa.ngasTran + eclidifa.nGasAlim + eclidifa.nGasAlte + eclidifa.nGasPres  ' es clidfami
            lningfam = eclidifa.nIngCony + eclidifa.nIngFami + eclidifa.nIngReme + eclidifa.nIngSSPC + eclidifa.nIngVari
        End If

        '        ecremcre.ccodcta = Me.txtcodcli.Text.Trim
        '        mcremcre.ObtenerCremcre(ecremcre)
        '        lccodfue = ecremcre.ccodfue

        lccodfue = Me.txtfuente.Text.Trim

        lccodcli = Me.txtcodcli.Text
        dsbalance = mClidbal.ObtenerDataSetPorID(lccodcli, lccodfue, lningfam, lngasfam, ldevalua)

        Try
            crRpt.Load(Server.MapPath("reportes") + "\crbaleco.rpt", OpenReportMethod.OpenReportByDefault)
        Catch ex As Exception
            Return
        End Try


        crRpt.SetDataSource(dsbalance.Tables(0))

        crRpt.SetParameterValue("lcnomcli", lcnomcli.Trim)


        Dim reportes As String
        reportes = "crbaleco.pdf"

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


    End Sub
    Private Sub Calcula()
        'Dim Ventas, CxC, OtrosIngresos, CostoVenta, GastosGen, GastosFin, Impuestos, Imprevistos
        'Dim Ingresos, Egresos, Disponible
        'Dim Efectivo, CuentasCobrar, Inventario, Fijo, OtrosActivos, Circulante
        'Dim Activo, Pasivo
        'Dim CxPagar, OxPagar, Prestamos, Patrimonio, PasivoxPatrimonio
        'Try


        '    Ventas = Double.Parse(TextBox1.Text)
        '    CxC = Double.Parse(TextBox4.Text)
        '    OtrosIngresos = Double.Parse(TextBox31.Text)

        '    Ingresos = Math.Round(Ventas + CxC + OtrosIngresos, 2)
        '    Txtingresos.Text = Ingresos

        '    CostoVenta = Double.Parse(TextBox12.Text)
        '    GastosGen = Double.Parse(TextBox13.Text)
        '    GastosFin = Double.Parse(TextBox14.Text)
        '    Impuestos = Double.Parse(TextBox15.Text)
        '    Imprevistos = Double.Parse(TextBox17.Text)


        '    Egresos = Math.Round(CostoVenta + GastosGen + GastosFin + Impuestos + Imprevistos, 2)
        '    Txtegresos.Text = Egresos

        '    Disponible = Math.Round(Ingresos - Egresos, 2)
        '    TextBox27.Text = Disponible

        '    Efectivo = Double.Parse(TextBox8.Text)
        '    CuentasCobrar = Double.Parse(TextBox9.Text)
        '    Inventario = Double.Parse(TextBox26.Text)
        '    Fijo = Double.Parse(TextBox10.Text)
        '    OtrosActivos = Double.Parse(TextBox11.Text)
        '    Circulante = Efectivo + CuentasCobrar + Inventario
        '    Activo = Fijo + OtrosActivos + Circulante
        '    TextBox5.Text = Activo


        '    CxPagar = Double.Parse(TextBox21.Text)
        '    OxPagar = Double.Parse(TextBox20.Text)
        '    Prestamos = Double.Parse(TextBox19.Text)

        '    Pasivo = CxPagar + OxPagar + Prestamos
        '    TextBox22.Text = Pasivo
        '    Patrimonio = Activo - Pasivo

        '    TextBox18.Text = Patrimonio
        '    PasivoxPatrimonio = Pasivo + Patrimonio

        '    TextBox23.Text = PasivoxPatrimonio
        'Catch ex As Exception
        '    Response.Write("<script language='javascript'>alert('Existen Valores No numericos')</script>")

        'End Try
        'Validaciones de los campos
        If Me.TextBox8.Text.Trim = "" Or Me.TextBox8.Text.Trim = Nothing Then
            Me.TextBox8.Text = 0
        End If
        If Me.TextBox9.Text.Trim = "" Or Me.TextBox9.Text.Trim = Nothing Then
            Me.TextBox9.Text = 0
        End If
        If Me.TextBox10.Text.Trim = "" Or Me.TextBox10.Text.Trim = Nothing Then
            Me.TextBox10.Text = 0
        End If
        If Me.TextBox26.Text.Trim = "" Or Me.TextBox26.Text.Trim = Nothing Then
            Me.TextBox26.Text = 0
        End If
        If Me.TextBox19.Text.Trim = "" Or Me.TextBox19.Text.Trim = Nothing Then
            Me.TextBox19.Text = 0
        End If
        If Me.TextBox20.Text.Trim = "" Or Me.TextBox20.Text.Trim = Nothing Then
            Me.TextBox20.Text = 0
        End If
        If Me.TextBox21.Text.Trim = "" Or Me.TextBox21.Text.Trim = Nothing Then
            Me.TextBox21.Text = 0
        End If
        If Me.TextBox12.Text.Trim = "" Or Me.TextBox12.Text.Trim = Nothing Then
            Me.TextBox12.Text = 0
        End If
        If Me.TextBox13.Text.Trim = "" Or Me.TextBox13.Text.Trim = Nothing Then
            Me.TextBox13.Text = 0
        End If
        If Me.TextBox14.Text.Trim = "" Or Me.TextBox14.Text.Trim = Nothing Then
            Me.TextBox14.Text = 0
        End If

        If Me.TextBox1.Text.Trim = "" Or Me.TextBox1.Text.Trim = Nothing Then
            Me.TextBox1.Text = 0
        End If

        If Me.TextBox4.Text.Trim = "" Or Me.TextBox4.Text.Trim = Nothing Then
            Me.TextBox4.Text = 0
        End If

        If Me.TextBox11.Text.Trim = "" Or Me.TextBox11.Text.Trim = Nothing Then
            Me.TextBox11.Text = 0
        End If

        If Me.TextBox15.Text.Trim = "" Or Me.TextBox15.Text.Trim = Nothing Then
            Me.TextBox15.Text = 0
        End If

        If Me.TextBox16.Text.Trim = "" Or Me.TextBox16.Text.Trim = Nothing Then
            Me.TextBox16.Text = 0
        End If

        If Me.TextBox17.Text.Trim = "" Or Me.TextBox17.Text.Trim = Nothing Then
            Me.TextBox17.Text = 0
        End If

        If Me.TextBox31.Text.Trim = "" Or Me.TextBox31.Text.Trim = Nothing Then
            Me.TextBox31.Text = 0
        End If

        Try
            'Totalizando
            Me.Disponible()
            Me.Activo()
            Me.Imprevistos()
            Me.ActCirculante()
            Me.Pasivo()
            Me.Patrimonio()
            Me.Pas_Patri()

        Catch ex As Exception
            Response.Write("<script language='javascript'>alert('Existen Valores no numericos')</script>")
            Exit Sub
        End Try

    End Sub

    Protected Sub btncalcula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncalcula.Click
        Valida_Campos()
        Calcula()
    End Sub
    
    Protected Sub TxtdFecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtdFecha.TextChanged
        Session("gdfecha") = Date.Parse(TxtdFecha.Text)
    End Sub
End Class


