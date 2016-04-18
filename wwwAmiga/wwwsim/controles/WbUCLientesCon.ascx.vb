Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO

Partial Class WbUCLientesCon
    Inherits ucWBase

    Private cClsAdCli As New SIM.BL.ClsCliente
    Dim clsTabtZon As New SIM.BL.cTabtzon
    Dim mTabtZon As New listatabtzon
#Region " Variables "
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
#End Region

#Region "Propiedades "
    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

    Public Property ClienteSeleccionado() As String
        Get
            Return _ClienteSeleccionado
        End Get
        Set(ByVal Value As String)
            _ClienteSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("ClienteSeleccionado", Value)
            Else
                ViewState("ClienteSeleccionado") = Value
            End If
        End Set
    End Property
#End Region

#Region " Metodos "

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Dim gdfecsis As Date = Session("gdfecsis")
        ImageFoto.Visible = False

        Me.TxtCodigo.Text = codigoCliente

        If Me.TxtCodigo.Text.Trim = "" _
            Or Me.TxtCodigo.Text.Trim = Nothing Then
            Exit Sub
        End If



        'Trae la Informacion del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.TxtCodigo.Text.Trim

        eClimide.ObtenerClimide(entidadClimide)
        Try


            Me.TxtNomcli.Text = entidadClimide.cprinom.Trim
            Me.TxtDfecnaci.Text = entidadClimide.dnacimi
            Me.TxtDirDom.Text = entidadClimide.cdirdom
            Me.TxtTelDom.Text = entidadClimide.cteldom

            If entidadClimide.ctidoci.Trim = "1" Then
                Dim lnlon As Integer
                lnlon = entidadClimide.cnudoci.Trim.Length
                If lnlon >= 4 Then
                    Me.TxtIdCivil.Text = Right(entidadClimide.cnudoci.Trim, (lnlon - 4))
                    Txtorden.Text = Left(entidadClimide.cnudoci, 4)
                End If
                Txtorden.Visible = True
            Else
                Txtorden.Visible = False
                Txtorden.Text = ""
                Me.TxtIdCivil.Text = entidadClimide.cnudoci.Trim
            End If

            cmbTipDoc.SelectedValue = entidadClimide.ctidoci.Trim


            Me.TxtIdTribu.Text = entidadClimide.cnudotr.Trim
            Me.TxtNomC.Text = IIf(IsDBNull(entidadClimide.cNomcon), "", entidadClimide.cNomcon.Trim)
            Me.TxtNacCony.Text = IIf(entidadClimide.dfCony = #12:00:00 AM#, Session("gdfecsis"), entidadClimide.dfCony)
            Me.TxtIdCony.Text = entidadClimide.cDuiCony.Trim
            Me.txtiva.Text = entidadClimide.mDatAdi
            Me.SeguroV.Checked = entidadClimide.lsegvida
            Me.Sfirmar.Checked = entidadClimide.cfirma

            Me.TxtEdad.Text = gdfecsis.Year - entidadClimide.dnacimi.Year
            Me.txtcelular.Text = entidadClimide.cTelFam

            Me.TxtEdadCony.Text = gdfecsis.Year - entidadClimide.dfCony.Year

            Me.txtdepen.Text = entidadClimide.npercar
            '-------------------------------------

            Me.DropDownDeptos.SelectedValue = entidadClimide.ccoddom.Substring(0, 2)
            Me.DropDownMuni.SelectedValue = entidadClimide.ccoddom.Substring(0, 4)
            Me.DropDownComu.SelectedValue = entidadClimide.ccoddom.Substring(0, 6)


            If IsDBNull(entidadClimide.cLugExp) Or entidadClimide.cLugExp = Nothing Or entidadClimide.cLugExp.Trim = "" Then
                'Obtener lugar de acuerdo a cedula
                Dim lccoddep As String
                If entidadClimide.ctidoci = "1" Then
                    lccoddep = clsTabtZon.ObtieneCodigoDepto(Txtorden.Text.Trim)
                    Me.DropDownDeptos0.SelectedValue = lccoddep
                    BuscaMunicipios0()
                End If
            Else
                Me.DropDownDeptos0.SelectedValue = entidadClimide.cLugExp.Trim.Substring(0, 2)
                Me.DropDownMuni0.SelectedValue = entidadClimide.cLugExp.Trim.Substring(0, 4)
            End If



            Me.cmbTipcli.SelectedValue = entidadClimide.cclaper.Trim
            Me.cmbOficina.SelectedValue = entidadClimide.ccodofi.Trim
            Me.cmbGenCli.SelectedValue = entidadClimide.csexo.Trim
            Me.cmbEstCli.SelectedValue = entidadClimide.cestciv.Trim

            Me.cmbProfCli.SelectedValue = entidadClimide.ccodpro.Trim
            If entidadClimide.cProfCon.Trim = Nothing Or IsDBNull(entidadClimide.cProfCon.Trim) Then
            Else
                Me.cmbProfCony.SelectedValue = entidadClimide.cProfCon.Trim
            End If
            If entidadClimide.cSexcon.Trim = Nothing Or IsDBNull(entidadClimide.cSexcon.Trim) Then

            Else
                Me.cmbGenCony.SelectedValue = entidadClimide.cSexcon.Trim
            End If

            Sleer.Checked = entidadClimide.nsabeesc
            cmbParent.SelectedValue = entidadClimide.ccodcon.Trim
            '-------------------------------------

            Me.Txtadicionales.Text = entidadClimide.cadicional
            Me.cmbEtnia.SelectedValue = entidadClimide.cetnia
            Me.cmbNivel.SelectedValue = entidadClimide.cnivel
            Me.cmbCondicion.SelectedValue = entidadClimide.cconviv

            Txtsegnom.Text = entidadClimide.csegnom
            Txtternom.Text = entidadClimide.cternom
            Txtpriape.Text = entidadClimide.cpriape
            Txtsegape.Text = entidadClimide.csegape

            Txtapecasada.Text = entidadClimide.capecasada.Replace("DE", "")

            cmbleer.SelectedValue = entidadClimide.cleer.Trim
            cmbescribir.SelectedValue = entidadClimide.cescribir.Trim
            cmbfirmar.SelectedValue = entidadClimide.cfirmar.Trim
            txtotrtel.Text = entidadClimide.cotrtel
            txtgrado.Text = entidadClimide.cgrado
            txthijos.Text = entidadClimide.nHijos
            cmblocalidad.SelectedValue = entidadClimide.clocalidad.Trim
            cmbgruetnico.SelectedValue = entidadClimide.cgruetnico.Trim


            Dim tronque As String = ""
            'cmbidiomas.SelectedValue = entidadClimide.cidiomas.Trim
            tronque = entidadClimide.cidiomas.Trim
            Dim nopciones As Integer = cmbidiomas.Items.Count - 1
            For i = 0 To nopciones
                If tronque.Substring(i, 1) = "1" Then
                    cmbidiomas.Items(i).Selected = True
                Else
                    cmbidiomas.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '--------

            tronque = entidadClimide.cservicios
            For i = 0 To 4
                If tronque.Substring(i, 1) = "1" Then
                    cmbservicios.Items(i).Selected = True
                Else
                    cmbservicios.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '--------

            tronque = entidadClimide.ctecho
            For i = 0 To 2
                If tronque.Substring(i, 1) = "1" Then
                    cmbtecho.Items(i).Selected = True
                Else
                    cmbtecho.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '--------
            tronque = entidadClimide.cpiso
            For i = 0 To 4
                If tronque.Substring(i, 1) = "1" Then
                    cmbpiso.Items(i).Selected = True
                Else
                    cmbpiso.Items(i).Selected = False
                End If
            Next
            tronque = ""
            '---------
            tronque = entidadClimide.cparedes
            For i = 0 To 4
                If tronque.Substring(i, 1) = "1" Then
                    cmbparedes.Items(i).Selected = True
                Else
                    cmbparedes.Items(i).Selected = False
                End If
            Next
            tronque = ""

            txtotracondicion.Text = entidadClimide.ctipocondic.Trim
            txtotracondicion0.Text = entidadClimide.cparedcondic.Trim
            txtotracondicion1.Text = entidadClimide.cpisocondic.Trim
            txtotracondicion2.Text = entidadClimide.ctechocondic.Trim
            txtotracondicion3.Text = entidadClimide.csercondic.Trim
            txtdueño.Text = entidadClimide.cNomDño.Trim
            txtvalor.Text = entidadClimide.nvalor
            txtrecidir.Text = entidadClimide.nanodom

            '-----------------------------------------------------------
            If entidadClimide.cgrusan.Trim = "" Then
            Else
                TxtId.Text = entidadClimide.cgrusan.Trim
                CargaFiador(TxtId.Text.Trim)
            End If


            hfIdEmpleado.Value = entidadClimide.ccodcli
            CargarImagenDeBaseDatos(entidadClimide.foto)
            Me.ImageFoto.ImageUrl = "../uploads/" + hfIdEmpleado.Value + ".jpg"
            ImageFoto.Visible = True

        Catch ex As Exception

        End Try
        Me.bteditar.Enabled = True
        Me.btreferencia.Enabled = True

        Session("codigocli") = codigoCliente
    End Sub


    Public Sub CargaCombos()
        'Oficina
        Dim etabtofi As New cTabtofi
        Dim ds As New DataSet
        ds = etabtofi.ObtenerDataSetPorNivel2(Session("gnNivel"), Session("gcCodOfi"))

        'Dim clsTabtOfi As New SIM.BL.cTabtofi
        'Dim mListaTabtOfi As New listatabtofi

        'mListaTabtOfi = clsTabtOfi.ObtenerLista()

        Me.cmbOficina.DataTextField = "cNomOfi"
        Me.cmbOficina.DataValueField = "ccodOfi"
        Me.cmbOficina.DataSource = ds
        Me.cmbOficina.DataBind()

        'Tipo de Cliente

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("002", "1")

        Me.cmbTipcli.DataTextField = "cdescri"
        Me.cmbTipcli.DataValueField = "ccodigo"
        Me.cmbTipcli.DataSource = mListaTabttab
        Me.cmbTipcli.DataBind()



        'Tipo de Documento
        mListaTabttab = clstabttab.ObtenerLista("010", "1")

        Me.cmbTipDoc.DataTextField = "cdescri"
        Me.cmbTipDoc.DataValueField = "ccodigo"
        Me.cmbTipDoc.DataSource = mListaTabttab
        Me.cmbTipDoc.DataBind()

        If cmbTipDoc.SelectedValue.Trim = "1" Then
            Txtorden.Visible = True
        Else
            Txtorden.Visible = False
        End If

        'Genero
        mListaTabttab = clstabttab.ObtenerLista("003", "1")

        Me.cmbGenCli.DataTextField = "cdescri"
        Me.cmbGenCli.DataValueField = "ccodigo"
        Me.cmbGenCli.DataSource = mListaTabttab
        Me.cmbGenCli.DataBind()

        'Conyuge Genero
        Me.cmbGenCony.DataTextField = "cdescri"
        Me.cmbGenCony.DataValueField = "ccodigo"
        Me.cmbGenCony.DataSource = mListaTabttab
        Me.cmbGenCony.DataBind()

        'Estado Civil
        mListaTabttab = clstabttab.ObtenerLista("012", "1")

        Me.cmbEstCli.DataTextField = "cdescri"
        Me.cmbEstCli.DataValueField = "ccodigo"
        Me.cmbEstCli.DataSource = mListaTabttab
        Me.cmbEstCli.DataBind()


        'Profesion
        Dim clsTabtprf As New SIM.BL.cTabtprf
        Dim mListaTabtprf As New listatabtprf

        mListaTabtprf = clsTabtprf.ObtenerLista()

        Me.cmbProfCli.DataTextField = "cDescri"
        Me.cmbProfCli.DataValueField = "ccodigo"
        Me.cmbProfCli.DataSource = mListaTabtprf
        Me.cmbProfCli.DataBind()

        Me.cmbProfCony.DataTextField = "cDescri"
        Me.cmbProfCony.DataValueField = "ccodigo"
        Me.cmbProfCony.DataSource = mListaTabtprf
        Me.cmbProfCony.DataBind()



        'Departamento
        mTabtZon = clsTabtZon.ObtenerLista("1")
        Me.DropDownDeptos.DataTextField = "cDesZon"
        Me.DropDownDeptos.DataValueField = "cCodzon"
        Me.DropDownDeptos.DataSource = mTabtZon
        Me.DropDownDeptos.DataBind()
        'Me.CargaDepartamentos()


        Me.DropDownDeptos0.DataTextField = "cDesZon"
        Me.DropDownDeptos0.DataValueField = "cCodzon"
        Me.DropDownDeptos0.DataSource = mTabtZon
        Me.DropDownDeptos0.DataBind()

        ''Municipio
        mTabtZon = clsTabtZon.ObtenerLista("2")
        Me.DropDownMuni.DataTextField = "cDesZon"
        Me.DropDownMuni.DataValueField = "cCodzon"
        Me.DropDownMuni.DataSource = mTabtZon
        Me.DropDownMuni.DataBind()

        Me.DropDownMuni0.DataTextField = "cDesZon"
        Me.DropDownMuni0.DataValueField = "cCodzon"
        Me.DropDownMuni0.DataSource = mTabtZon
        Me.DropDownMuni0.DataBind()


        ''Canton
        mTabtZon = clsTabtZon.ObtenerLista("3")
        Me.DropDownComu.DataTextField = "cDesZon"
        Me.DropDownComu.DataValueField = "cCodzon"
        Me.DropDownComu.DataSource = mTabtZon
        Me.DropDownComu.DataBind()


        Me.TxtNacCony.Text = Session("gdfecsis")

        'Etnia
        mListaTabttab = clstabttab.ObtenerLista("150", "1")

        Me.cmbEtnia.DataTextField = "cdescri"
        Me.cmbEtnia.DataValueField = "ccodigo"
        Me.cmbEtnia.DataSource = mListaTabttab
        Me.cmbEtnia.DataBind()

        'condicion de vivienda
        mListaTabttab = clstabttab.ObtenerLista("017", "1")

        Me.cmbCondicion.DataTextField = "cdescri"
        Me.cmbCondicion.DataValueField = "ccodigo"
        Me.cmbCondicion.DataSource = mListaTabttab
        Me.cmbCondicion.DataBind()

        'Nivel academico
        mListaTabttab = clstabttab.ObtenerLista("151", "1")

        Me.cmbNivel.DataTextField = "cdescri"
        Me.cmbNivel.DataValueField = "ccodigo"
        Me.cmbNivel.DataSource = mListaTabttab
        Me.cmbNivel.DataBind()


        If cmbTipDoc.SelectedValue.Trim = "1" Then
            Txtorden.Visible = True
            Txtorden.Text = clsTabtZon.ObtieneNumerodeOrden(DropDownDeptos0.SelectedValue.Trim)
            Label6.Text = ""
        Else
            Txtorden.Visible = False
            Txtorden.Text = ""
            Label6.Text = "(Con guiones Formato: 9999-99999-9999)"
        End If
        Me.TxtDfecnaci.Text = Session("gdfecsis")

        'si y no
        mListaTabttab = clstabttab.ObtenerLista("085", "1")

        Me.cmbleer.DataTextField = "cdescri"
        Me.cmbleer.DataValueField = "ccodigo"
        Me.cmbleer.DataSource = mListaTabttab
        Me.cmbleer.DataBind()

        Me.cmbescribir.DataTextField = "cdescri"
        Me.cmbescribir.DataValueField = "ccodigo"
        Me.cmbescribir.DataSource = mListaTabttab
        Me.cmbescribir.DataBind()

        Me.cmbfirmar.DataTextField = "cdescri"
        Me.cmbfirmar.DataValueField = "ccodigo"
        Me.cmbfirmar.DataSource = mListaTabttab
        Me.cmbfirmar.DataBind()

        'localidad
        mListaTabttab = clstabttab.ObtenerLista("086", "1")

        Me.cmblocalidad.DataTextField = "cdescri"
        Me.cmblocalidad.DataValueField = "ccodigo"
        Me.cmblocalidad.DataSource = mListaTabttab
        Me.cmblocalidad.DataBind()


        'grupo etnico
        mListaTabttab = clstabttab.ObtenerLista("087", "1")

        Me.cmbgruetnico.DataTextField = "cdescri"
        Me.cmbgruetnico.DataValueField = "ccodigo"
        Me.cmbgruetnico.DataSource = mListaTabttab
        Me.cmbgruetnico.DataBind()

        'idiomas
        mListaTabttab = clstabttab.ObtenerListaPorIDOrdenado("082", "1")

        Me.cmbidiomas.DataTextField = "cdescri"
        Me.cmbidiomas.DataValueField = "ccodigo"
        Me.cmbidiomas.DataSource = mListaTabttab
        Me.cmbidiomas.DataBind()


        mListaTabttab = clstabttab.ObtenerListaPorIDOrdenado("148", "1")

        Me.cmbParent.DataTextField = "cdescri"
        Me.cmbParent.DataValueField = "ccodigo"
        Me.cmbParent.DataSource = mListaTabttab
        Me.cmbParent.DataBind()

    End Sub

    Public Sub BuscaMunicipios()

        Me.DropDownMuni.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.DropDownDeptos.SelectedItem.Value.Trim, "2")
        Me.DropDownMuni.DataTextField = "cDesZon"
        Me.DropDownMuni.DataValueField = "cCodzon"
        Me.DropDownMuni.DataSource = mTabtZon
        Me.DropDownMuni.DataBind()


    End Sub

    Public Sub BuscaMunicipios0()

        Me.DropDownMuni0.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.DropDownDeptos0.SelectedItem.Value.Trim, "2")
        Me.DropDownMuni0.DataTextField = "cDesZon"
        Me.DropDownMuni0.DataValueField = "cCodzon"
        Me.DropDownMuni0.DataSource = mTabtZon
        Me.DropDownMuni0.DataBind()


    End Sub

    Public Sub BuscaCantones()

        Me.DropDownComu.Items.Clear()

        Dim clsTabtZon As New SIM.BL.cTabtzon
        Dim mTabtZon As New listatabtzon

        'Municipio
        mTabtZon = clsTabtZon.ObtenerLista1(Me.DropDownMuni.SelectedItem.Value.Trim, "3")
        Me.DropDownComu.DataTextField = "cDesZon"
        Me.DropDownComu.DataValueField = "cCodzon"
        Me.DropDownComu.DataSource = mTabtZon
        Me.DropDownComu.DataBind()

    End Sub

    Public Sub Habilita()
        Me.cmbEstCli.Enabled = True
        Me.cmbGenCli.Enabled = True
        Me.DropDownDeptos.Enabled = True
        Me.DropDownDeptos0.Enabled = True
        Me.DropDownMuni.Enabled = True
        Me.DropDownMuni0.Enabled = True
        Me.DropDownComu.Enabled = True
        Me.cmbProfCli.Enabled = True
        Me.cmbTipcli.Enabled = False
        Me.cmbTipDoc.Enabled = True
        Me.cmbEtnia.Enabled = True
        Me.cmbNivel.Enabled = True
        Me.cmbCondicion.Enabled = True
        Me.Txtadicionales.Enabled = True
        Me.TxtDfecnaci.Enabled = True
        Me.TxtNomcli.Enabled = True
        Me.TxtTelDom.Enabled = True
        Me.txtcelular.Enabled = True
        txtdepen.Enabled = True
        Me.txtiva.Enabled = True
        Me.SeguroV.Enabled = True
        Me.Sfirmar.Enabled = True

        Txtsegnom.Enabled = True
        Txtternom.Enabled = True
        Txtpriape.Enabled = True
        Txtsegape.Enabled = True
        Txtapecasada.Enabled = True
        cmbleer.Enabled = True
        cmbescribir.Enabled = True
        cmbfirmar.Enabled = True
        txtotrtel.Enabled = True
        txtgrado.Enabled = True
        txthijos.Enabled = True
        cmblocalidad.Enabled = True
        cmbgruetnico.Enabled = True
        cmbidiomas.Enabled = True
        cmbParent.Enabled = True

        Me.TxtDirDom.Enabled = True
        Me.TxtIdCivil.Enabled = True
        Me.TxtIdTribu.Enabled = True
        Me.cmbOficina.Enabled = True
        Me.btnuevo.Enabled = True
        Me.btgrabar.Enabled = True

        TxtNomC.Enabled = False
        TxtIdCony.Enabled = False
        cmbProfCony.Enabled = False
        TxtNacCony.Enabled = False
        cmbGenCony.Enabled = False
        Sleer.Enabled = False


        txtotracondicion.Enabled = True
        txtotracondicion0.Enabled = True
        txtotracondicion1.Enabled = True
        txtotracondicion2.Enabled = True
        txtotracondicion3.Enabled = True
        cmbparedes.Enabled = True
        cmbpiso.Enabled = True
        cmbtecho.Enabled = True
        cmbservicios.Enabled = True
        txtdueño.Enabled = True
        txtvalor.Enabled = True
        txtrecidir.Enabled = True
    End Sub

    Public Sub Limpia()
        lblStatus.Text = ""
        TxtCodigo.Text = ""
        Me.TxtDfecnaci.Text = Session("gdfecsis")
        Me.TxtNomcli.Text = ""
        Me.TxtTelDom.Text = ""
        Me.txtiva.Text = ""

        Me.txtcelular.Text = ""
        txtdepen.Text = 0
        Me.TxtDirDom.Text = ""
        Me.TxtIdCivil.Text = ""


        Me.TxtIdTribu.Text = ""
        Me.TxtNacCony.Text = Session("gdfecsis")
        Me.TxtNomC.Text = ""
        Me.TxtCodigo.Text = ""
        Me.TxtIdCony.Text = ""
        Me.TxtEdad.Text = ""
        Me.TxtEdadCony.Text = ""

        Me.Txtadicionales.Text = ""
        Me.btnuevo.Enabled = True
        Me.btgrabar.Enabled = False

        Me.SeguroV.Checked = False
        Me.Sfirmar.Checked = False
        '        TextBox.InputMask = "999,999,999.99"

        Txtsegnom.Text = ""
        Txtternom.Text = ""
        Txtpriape.Text = ""
        Txtsegape.Text = ""
        Txtapecasada.Text = ""
        txtotrtel.Text = ""
        txtgrado.Text = ""
        txthijos.Text = 0

        txtotracondicion.Text = ""
        txtotracondicion0.Text = ""
        txtotracondicion1.Text = ""
        txtotracondicion2.Text = ""
        txtotracondicion3.Text = ""
        txtdueño.Text = ""
        txtvalor.Text = 0
        txtrecidir.Text = Year(Session("gdfecsis"))
        TxtId.Text = ""
        cmbparedes.ClearSelection()
        cmbpiso.ClearSelection()
        cmbtecho.ClearSelection()
        cmbservicios.ClearSelection()
        cmbidiomas.ClearSelection()
    End Sub



    Public Sub Deshabilita()
        Me.cmbEstCli.Enabled = False
        Me.cmbGenCli.Enabled = False
        Me.DropDownDeptos.Enabled = False
        Me.DropDownDeptos0.Enabled = False
        Me.DropDownMuni.Enabled = False
        Me.DropDownMuni0.Enabled = False
        Me.DropDownComu.Enabled = False
        Me.cmbProfCli.Enabled = False
        Me.cmbTipcli.Enabled = False
        Me.cmbTipDoc.Enabled = False
        Me.cmbEtnia.Enabled = False
        Me.cmbNivel.Enabled = False
        Me.cmbCondicion.Enabled = False
        Me.Txtadicionales.Enabled = False
        Me.TxtDfecnaci.Enabled = False
        Me.TxtNomcli.Enabled = False
        Me.TxtTelDom.Enabled = False
        Me.txtcelular.Enabled = False
        txtdepen.Enabled = False
        Me.txtiva.Enabled = False

        Me.TxtDirDom.Enabled = False
        Me.TxtIdCivil.Enabled = False
        Me.TxtIdTribu.Enabled = False
        Me.TxtNacCony.Enabled = False
        Me.TxtNomC.Enabled = False
        Me.cmbProfCony.Enabled = False
        Me.cmbGenCony.Enabled = False
        Me.TxtIdCony.Enabled = False
        Sleer.Enabled = False
        Me.cmbOficina.Enabled = False
        Me.btgrabar.Enabled = False
        Me.bteditar.Enabled = False

        Me.SeguroV.Enabled = False
        Me.Sfirmar.Enabled = False

        Me.btreferencia.Enabled = False

        TxtNomC.Enabled = False
        TxtIdCony.Enabled = False
        cmbProfCony.Enabled = False
        TxtNacCony.Enabled = False
        cmbGenCony.Enabled = False

        Txtsegnom.Enabled = False
        Txtternom.Enabled = False
        Txtpriape.Enabled = False
        Txtsegape.Enabled = False
        Txtapecasada.Enabled = False
        cmbleer.Enabled = False
        cmbescribir.Enabled = False
        cmbfirmar.Enabled = False
        txtotrtel.Enabled = False
        txtgrado.Enabled = False
        txthijos.Enabled = False
        cmblocalidad.Enabled = False
        cmbgruetnico.Enabled = False
        cmbidiomas.Enabled = False
        cmbParent.Enabled = False

        txtotracondicion.Enabled = False
        txtotracondicion0.Enabled = False
        txtotracondicion1.Enabled = False
        txtotracondicion2.Enabled = False
        txtotracondicion3.Enabled = False
        cmbparedes.Enabled = False
        cmbpiso.Enabled = False
        cmbtecho.Enabled = False
        cmbservicios.Enabled = False
        txtdueño.Enabled = False
        txtvalor.Enabled = False
        txtrecidir.Enabled = False
    End Sub


#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargaCombos()
            '            Session.Add("codigocli", "")
            Me.Deshabilita()
        End If
    End Sub


    Private Sub cmbEstCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstCli.SelectedIndexChanged
        If Me.cmbEstCli.SelectedItem.Value.Trim = "2" Or Me.cmbEstCli.SelectedItem.Value.Trim = "6" Then
            Me.TxtNacCony.Enabled = False
            Me.TxtNomC.Enabled = False
            Me.cmbProfCony.Enabled = False
            Me.cmbGenCony.Enabled = False
            Me.TxtIdCony.Enabled = False
            If Me.cmbGenCli.SelectedItem.Value.Trim = "F" Then
                cmbGenCony.SelectedItem.Value = "M"
            Else
                cmbGenCony.SelectedItem.Value = "F"
            End If
            Me.Sleer.Enabled = False
            cmbParent.SelectedValue = "06"
            cmbParent.Enabled = False
        Else
            Me.TxtNacCony.Enabled = False
            Me.TxtNomC.Enabled = False
            Me.cmbProfCony.Enabled = False
            Me.cmbGenCony.Enabled = False
            Me.TxtIdCony.Enabled = False
            Me.Sleer.Enabled = False
            cmbParent.Enabled = True
        End If


    End Sub

    Private Sub TxtDfecnaci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDfecnaci.TextChanged
        'Me.RangeValidator1.Validate()
        'If Me.RangeValidator1.IsValid = False Then
        '    Exit Sub
        'End If
        Dim clsppal As New class1
        Dim gdfecsis As Date = Session("gdfecsis")
        Me.TxtEdad.Text = clsppal.CalculaEdad(CDate(Me.TxtDfecnaci.Text)) 'gdfecsis.Year - CDate(Me.TxtDfecnaci.Text).Year
    End Sub

    Private Sub TxtNacCony_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNacCony.TextChanged
        Dim gdfecsis As Date = Session("gdfecsis")
        Me.TxtEdadCony.Text = gdfecsis.Year - CDate(Me.TxtNacCony.Text).Year

        ''
        '        Me.RangeValidator1.Validate()
        'If Me.RangeValidator1.IsValid = False Then
        'Exit Sub
        'End If
        'Dim gdfecsis As Date = Session("gdfecsis")
        ' Me.TxtEdad.Text = gdfecsis.Year - CDate(Me.TxtDfecnaci.Text).Year

    End Sub







    Private Sub cmbGenCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenCli.SelectedIndexChanged
        'If Me.cmbGenCli.SelectedItem.Value.Trim = "F" Then
        'cmbGenCony.SelectedItem.Value = "M"
        ' Else
        '     cmbGenCony.SelectedItem.Value = "F"
        ' End If
    End Sub



    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click

        Me.Habilita()
        'Me.BuscaMunicipios()
        'Me.BuscaCantones()
        Me.Limpia()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True

    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        'Verifica Documento unico
        Dim eclimide As New cClimide
        Dim lverifica As Boolean
        Me.TxtIdCivil.Text = Me.TxtIdCivil.Text.Trim.Replace(",", "")
        lverifica = eclimide.VerificaDocumento(Me.TxtIdCivil.Text.Trim)
        If Me.TxtCodigo.Text.Trim = "" Then
            If lverifica = False Then
                Response.Write("<script language='javascript'>alert('Documento de Identificación ya Registrado')</script>")
                Return
            End If

        End If

        If cmbTipDoc.SelectedValue.Trim = "2" Then
            If TxtIdCivil.Text.Trim.Length = 15 Then
            Else
                Response.Write("<script language='javascript'>alert('Longitud de DPI No Concuerda, Verifique')</script>")
                Return
            End If
        End If

        Dim lcResul As String
        cClsAdCli._cTipcli = Me.cmbTipcli.SelectedItem.Value.Trim
        cClsAdCli._cCodOfi = Me.cmbOficina.SelectedItem.Value.Trim
        cClsAdCli._ccodigo = Me.TxtCodigo.Text.Trim
        cClsAdCli._cNomcli = Me.TxtNomcli.Text.Trim.ToUpper + IIf(Txtsegnom.Text.Trim = "", "", " ") + Txtsegnom.Text.Trim.ToUpper + IIf(Txtternom.Text.Trim = "", "", " ") + Txtternom.Text.Trim.ToUpper + IIf(Txtpriape.Text.Trim = "", "", " ") + _
        Txtpriape.Text.Trim.ToUpper + IIf(Txtsegape.Text.Trim = "", "", " ") + Txtsegape.Text.Trim.ToUpper + IIf(Txtapecasada.Text.Trim = "", "", " DE  ") + Txtapecasada.Text.Trim.ToUpper
        cClsAdCli._dFecnac = CDate(Me.TxtDfecnaci.Text)
        If cmbTipDoc.SelectedValue.Trim = "1" Then
            cClsAdCli._cnudoci = (Me.Txtorden.Text.Trim + " " + Me.TxtIdCivil.Text.Trim)
        Else
            cClsAdCli._cnudoci = Me.TxtIdCivil.Text.Trim
        End If


        cClsAdCli._cnudotr = Me.TxtIdTribu.Text.Trim
        cClsAdCli._cGen = Me.cmbGenCli.SelectedItem.Value.Trim
        cClsAdCli._cEstciv = Me.cmbEstCli.SelectedItem.Value.Trim
        cClsAdCli._cProf = Me.cmbProfCli.SelectedItem.Value.Trim
        cClsAdCli._cCodDom = Me.DropDownComu.SelectedItem.Value.Trim
        cClsAdCli._cDirDom = Me.TxtDirDom.Text.Trim
        cClsAdCli._cTelDom = Me.TxtTelDom.Text.Trim
        cClsAdCli._celular = Me.txtcelular.Text.Trim
        cClsAdCli._ivacli = Me.txtiva.Text.Trim
        cClsAdCli._lsegvida = Me.SeguroV.Checked
        cClsAdCli._nfirma = Me.Sfirmar.Checked

        cClsAdCli._cetnia = Me.cmbEtnia.SelectedValue.Trim
        cClsAdCli._cnivel = Me.cmbNivel.SelectedValue.Trim
        cClsAdCli._cadicional = Me.Txtadicionales.Text.Trim
        cClsAdCli._cconviv = Me.cmbCondicion.SelectedValue.Trim
        cClsAdCli._npercar = Integer.Parse(txtdepen.Text)

        cClsAdCli._clugexp = Me.DropDownMuni0.SelectedItem.Value.Trim
        cClsAdCli._ctidoci = Me.cmbTipDoc.SelectedValue.Trim

        cClsAdCli._ccodcon = cmbParent.SelectedValue.Trim
        '        If Me.cmbEstCli.SelectedItem.Value.Trim = "2" Or Me.cmbEstCli.SelectedItem.Value.Trim = "6" Then

        If Me.TxtNomC.Text.Trim = "" Or Me.TxtIdCony.Text.Trim = "" Then
            Response.Write("<script language='javascript'>alert('Faltan Datos ')</script>")
            Exit Sub
        End If
        cClsAdCli._cNomCony = Me.TxtNomC.Text.Trim.ToUpper
        cClsAdCli._dfNacCony = CDate(Me.TxtNacCony.Text)
        cClsAdCli._IdCivCony = Me.TxtIdCony.Text.Trim
        cClsAdCli._cGenCony = Me.cmbGenCony.SelectedItem.Value.Trim
        cClsAdCli._cProfCony = Me.cmbProfCony.SelectedItem.Value.Trim
        cClsAdCli._nsabeesc = Me.Sleer.Checked
        cClsAdCli._cgrusan = TxtId.Text.Trim
        'Else
        'cClsAdCli._cNomCony = " "
        'cClsAdCli._dfNacCony = Session("gdfecsis")
        'cClsAdCli._IdCivCony = " "
        'cClsAdCli._cGenCony = " "
        'cClsAdCli._cProfCony = " "
        'cClsAdCli._nsabeesc = 0
        'cClsAdCli._cgrusan = ""
        'End If

        'Se agregaran campos nuevos
        cClsAdCli._cprinom = TxtNomcli.Text.Trim.ToUpper
        cClsAdCli._csegnom = Txtsegnom.Text.Trim.ToUpper
        cClsAdCli._cternom = Txtternom.Text.Trim.ToUpper
        cClsAdCli._cpriape = Txtpriape.Text.Trim.ToUpper
        cClsAdCli._csegape = Txtsegape.Text.Trim.ToUpper
        cClsAdCli._capecasada = Txtapecasada.Text.Trim.ToUpper

        cClsAdCli._cleer = cmbleer.SelectedValue.Trim
        cClsAdCli._cescribir = cmbescribir.SelectedValue.Trim
        cClsAdCli._cfirmar = cmbfirmar.SelectedValue.Trim

        cClsAdCli._cotrtel = txtotrtel.Text.Trim
        cClsAdCli._cgrado = txtgrado.Text.Trim
        cClsAdCli._nhijos = Integer.Parse(txthijos.Text)

        cClsAdCli._clocalidad = cmblocalidad.SelectedValue.Trim
        cClsAdCli._cgruetnico = cmbgruetnico.SelectedValue.Trim
        Dim tronque As String = ""
        '---
        Dim nopciones As Integer = cmbidiomas.Items.Count - 1
        For i = 0 To nopciones
            If cmbidiomas.Items(i).Selected = True Then
                tronque = tronque + "1"
            Else
                tronque = tronque + "0"
            End If
        Next


        cClsAdCli._cidiomas = tronque.Trim 'cmbidiomas.SelectedValue.Trim
        '----
        tronque = ""

        'Campos adicionales
        cClsAdCli._ctipocondic = txtotracondicion.Text.Trim


        For i = 0 To 4
            If cmbparedes.Items(i).Selected = True Then
                tronque = tronque + "1"
            Else
                tronque = tronque + "0"
            End If
        Next
        cClsAdCli._cparedes = tronque.Trim
        tronque = ""
        cClsAdCli._cparedcondic = txtotracondicion0.Text.Trim
        '------------------------------------------------------------

        For i = 0 To 4
            If cmbpiso.Items(i).Selected = True Then
                tronque = tronque + "1"
            Else
                tronque = tronque + "0"
            End If
        Next
        cClsAdCli._cpiso = tronque.Trim
        tronque = ""
        cClsAdCli._cpisocondic = txtotracondicion1.Text.Trim
        '-------------------------------------------------------------


        For i = 0 To 2
            If cmbtecho.Items(i).Selected = True Then
                tronque = tronque + "1"
            Else
                tronque = tronque + "0"
            End If
        Next
        cClsAdCli._ctecho = tronque.Trim
        tronque = ""
        cClsAdCli._ctechocondic = txtotracondicion2.Text.Trim
        '-------------------------------------------------------------


        For i = 0 To 4
            If cmbservicios.Items(i).Selected = True Then
                tronque = tronque + "1"
            Else
                tronque = tronque + "0"
            End If
        Next
        cClsAdCli._cservicios = tronque.Trim
        tronque = ""
        cClsAdCli._csercondic = txtotracondicion3.Text.Trim
        '---------------------------------------------------------------
        cClsAdCli._cnomdño = txtdueño.Text.Trim
        If txtvalor.Text.Trim = "" Or txtvalor.Text = Nothing Then
            txtvalor.Text = 0
        End If
        cClsAdCli._nvalor = Double.Parse(txtvalor.Text)
        cClsAdCli._nanodom = Integer.Parse(txtrecidir.Text)
        'cClsAdCli.foto = CargaBufferImagen()
        Dim lnflag As Integer = 0
        Try
            cClsAdCli.foto = CargaBufferImagen()
            lnflag = 1
        Catch ex As Exception
            If cClsAdCli._ccodigo = "" Or cClsAdCli._ccodigo = " " Then 'Es para insertar
                Response.Write("<script language='javascript'>alert('Verifique Foto')</script>")
                Exit Sub
            End If
            lnflag = 0
        End Try

        lcResul = cClsAdCli.AdCliente(lnflag)

        If lcResul = "0" Then
            Exit Sub
        Else
            If lcResul <> "" Then
                Response.Write("<script language='javascript'>alert('El Codigo Grabado es  " & lcResul & " ')</script>")
                Session("codigocli") = lcResul
                TxtCodigo.Text = lcResul
            End If
        End If

        'Me.Limpia()
        Me.Deshabilita()
        Me.btreferencia.Enabled = True
    End Sub

    Protected Sub bteditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bteditar.Click
        Me.Habilita()
        'Me.cmbEstCli_SelectedIndexChanged(sender, e)
        Me.bteditar.Enabled = False
    End Sub

    Protected Sub btCancela_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCancela.Click
        Me.Limpia()
        Me.Deshabilita()

    End Sub

    Protected Sub btreferencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btreferencia.Click

        Session("codigocli") = Me.TxtCodigo.Text.Trim
        Session("codigo") = "0"
        'Response.Redirect("wbreferencia.aspx")

        Response.Write("<script>window.open('wbreferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=950,height=550')</script>")
    End Sub

    Public Sub CargaDepartamentos()

        Dim sqlComando As New SqlCommand
        Dim drDataReader As SqlDataReader

        Using cnConexion As New SqlConnection(ConfigurationManager.ConnectionStrings("FondesolConnectionString2").ConnectionString)
            cnConexion.Open()
            sqlComando.CommandText = " select ccodzon,cdeszon from tabtzon where ctipzon=1 order by cdeszon "
            sqlComando.Connection = cnConexion
            drDataReader = sqlComando.ExecuteReader
            DropDownDeptos.DataSource = drDataReader
            DropDownDeptos.DataTextField = "cdeszon"
            DropDownDeptos.DataValueField = "ccodzon"
            DropDownDeptos.DataBind()

        End Using

    End Sub

    Protected Sub DropDownDeptos0_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownDeptos0.SelectedIndexChanged
        BuscaMunicipios0()
        If cmbTipDoc.SelectedValue.Trim = "1" Then
            Txtorden.Visible = True
            Txtorden.Text = clsTabtZon.ObtieneNumerodeOrden(DropDownDeptos0.SelectedValue.Trim)
            Label6.Text = ""
        Else
            Txtorden.Visible = False
            Txtorden.Text = ""
            Label6.Text = "(Con guiones Formato: 9999-99999-9999)"
        End If


    End Sub

    Protected Sub DropDownDeptos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownDeptos.SelectedIndexChanged
        BuscaMunicipios()
        BuscaCantones()
    End Sub

    Protected Sub DropDownMuni_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownMuni.SelectedIndexChanged
        BuscaCantones()
    End Sub

    Protected Sub cmbTipDoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipDoc.SelectedIndexChanged
        If cmbTipDoc.SelectedValue.Trim = "1" Then
            Txtorden.Visible = True
            Txtorden.Text = clsTabtZon.ObtieneNumerodeOrden(DropDownDeptos0.SelectedValue.Trim)
            Label6.Text = ""
        Else
            Txtorden.Visible = False
            Txtorden.Text = ""
            Label6.Text = "(Con guiones Formato: 9999-99999-9999)"
        End If

    End Sub
    Public Sub CargaFiador(ByVal codigoFiador As String)

        Me.TxtId.Text = codigoFiador

        If Me.TxtId.Text.Trim = "" _
            Or Me.TxtId.Text.Trim = Nothing Then
            Exit Sub
        End If

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.TxtId.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Dim clsppal As New class1

        Try
            TxtNomC.Text = entidadClimide.cnomcli
            TxtIdCony.Text = entidadClimide.cnudoci
            TxtNacCony.Text = entidadClimide.dnacimi
            cmbGenCony.SelectedValue = entidadClimide.csexo.Trim
            cmbProfCony.SelectedValue = entidadClimide.ccodpro.Trim

            TxtEdadCony.Text = clsppal.CalculaEdad(entidadClimide.dnacimi)

        Catch ex As Exception

        End Try


        'Me.TxtDescri.Text = entidadClimide.cnomcli.Trim
        'Me.TxtDescri.Enabled = False
        Me.TxtId.Enabled = False


    End Sub

    Protected Sub btnSubir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubir.Click
        Dim pathGrabar As String
        Try
            If Not fileUpEx Is Nothing Then
                Dim Archivo As String = Path.GetFileName(fileUpEx.PostedFile.FileName)
                'obtiene extension del archivo

                hfExtension.Value = System.IO.Path.GetExtension(fileUpEx.PostedFile.FileName)
                pathGrabar = Server.MapPath(".\uploads\" + Archivo)
                fileUpEx.PostedFile.SaveAs(pathGrabar)
                lblStatus.Text = "archivo subido con exito"
                'Image1.ImageUrl = "~/uploads/" + filepath
                hfPathArchivo.Value = pathGrabar

                ImageFoto.Visible = True
                Me.ImageFoto.ImageUrl = "~/uploads/" & Archivo

            End If

        Catch ex As Exception
            lblStatus.Text = "error al subir archivo"
        End Try

    End Sub
    Protected Function CargaBufferImagen() As Array

        Dim imagestream As FileStream = New FileStream(hfPathArchivo.Value, FileMode.Open)
        Dim data() As Byte
        ReDim data(imagestream.Length - 1)

        imagestream.Read(data, 0, imagestream.Length)

        imagestream.Close()
        imagestream.Dispose()

        Return data

    End Function

    Protected Function CargarImagenDeBaseDatos(ByVal imagen() As Byte) As String
        Dim imageInBytes As Byte() = imagen
        Dim pathUploads As String
        Dim nombreArchivo As String

        Dim archivoLogico As StreamWriter

        nombreArchivo = hfIdEmpleado.Value + ".jpg" 'hfExtension.Value
        pathUploads = Server.MapPath(".\uploads\")
        File.WriteAllBytes(pathUploads + nombreArchivo, imagen)

    End Function

End Class


