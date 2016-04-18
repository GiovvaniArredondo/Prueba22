Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.ApplicationBlocks.Data

Partial Class WbUCLientes
    Inherits ucWBase


#Region " Privadas "
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Private codigoJs As String
    Private clsclass As New class1
    Private cClscli As New cClimide
    Private cClsAdCli As New ClsCliente
    Private clsTabtZon As New cTabtzon
    Private mTabtZon As New listatabtzon
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


    Private Function Valida_CURP(ByVal pcApe1 As String, ByVal pcApe2 As String, ByVal pcNomb1 As String, ByVal pcNomb2 As String, _
                            ByVal pdfecsis As Date, ByVal pcNoCURP As String) As Boolean

        Dim lcAbrevia As String = ""
        Dim lcDia As String = pdfecsis.Day.ToString
        Dim lcMes As String = pdfecsis.Month.ToString
        Dim lcAno As String = pdfecsis.Month.ToString
        Dim lcCURP As String = Left(pcNoCURP, 10)
        Dim llretorno As Boolean = False

        'Concatena el nombre
        If pcApe2.Length > 0 Then
            lcAbrevia = Left(pcApe1, 1) + Left(pcApe2, 1) + Left(pcNomb1, 1) + Left(pcNomb2, 1)
        Else
            lcAbrevia = Left(pcApe1, 2) + Left(pcNomb1, 1) + Left(pcNomb2, 1)
        End If

        'Evalua las 2 posiciones del mes
        If lcMes.Trim.Length = 1 Then
            lcMes = "0" & lcMes
        End If

        lcAbrevia = lcAbrevia + lcAno + lcMes + lcDia

        'Realiza la comparacion de las 10 posiciones inicales
        If lcAbrevia.Trim = lcCURP.Trim Then
            llretorno = True
        End If


        Return llretorno

    End Function

    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Dim gdfecsis As Date = Session("gdfecsis")


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
            BuscaMunicipios()
            Me.DropDownMuni.SelectedValue = entidadClimide.ccoddom.Substring(0, 5)
            BuscaCantones()
            Me.DropDownComu.SelectedValue = entidadClimide.ccoddom.Substring(0, 9)


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
                BuscaMunicipios0()
                Me.DropDownMuni0.SelectedValue = entidadClimide.cLugExp.Trim.Substring(0, 5)
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
            'cmblocalidad.SelectedValue = entidadClimide.clocalidad.Trim
            'cmbgruetnico.SelectedValue = entidadClimide.cgruetnico.Trim
            Me.TxtIFE.Text = entidadClimide.id_ife

            Me.TxtcCodPostal.Text = entidadClimide.id_codigo_postal
            Me.TxtcCalle.Text = entidadClimide.cCalle
            Me.TxtcNoExt.Text = entidadClimide.cNoExt
            Me.TxtcNoInt.Text = entidadClimide.cNoInt
            Me.txtccorreo.Text = entidadClimide.ccorreo
            Me.txtcusuface.Text = entidadClimide.usuface

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


            Me.TxtLng.Text = entidadClimide.longitud
            Me.TxtLat.Text = entidadClimide.latitud

            Session("latitud") = entidadClimide.latitud
            Session("longitud") = entidadClimide.longitud
            Session("Zona") = entidadClimide.cdirdom

            '-----------------------------------------------------------
            If entidadClimide.cgrusan.Trim = "" Then
            Else
                TxtId.Text = entidadClimide.cgrusan.Trim
                CargaFiador(TxtId.Text.Trim)
            End If
            hfIdEmpleado.Value = entidadClimide.ccodcli
            'CargarImagenDeBaseDatos(entidadClimide.foto)
            'Me.ImageFoto.ImageUrl = "../uploads/" + hfIdEmpleado.Value + ".jpg"
            'ImageFoto.Visible = True

            'CargarImagenDeBaseDatos(entidadClimide.foto)
            'CargarImagen()
            'ImagenMuestra()
            'ImageFoto.Visible = True
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

        Me.cmbOficina.SelectedValue = Session("gccodofi")

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        mListaTabttab = clstabttab.ObtenerLista("002", "1")

        Me.cmbTipcli.DataTextField = "cdescri"
        Me.cmbTipcli.DataValueField = "ccodigo"
        Me.cmbTipcli.DataSource = mListaTabttab
        Me.cmbTipcli.DataBind()


        Me.cmbTipcli.selectedvalue = "1"

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

        If Not Session("gcZona") = Nothing Or Session("gcZona") = "" Then
            Me.DropDownDeptos.SelectedValue = Session("gcZona").ToString.Trim
            Me.DropDownDeptos0.SelectedValue = Session("gcZona").ToString.Trim
        End If


        Me.DropDownDeptos0.DataTextField = "cDesZon"
        Me.DropDownDeptos0.DataValueField = "cCodzon"
        Me.DropDownDeptos0.DataSource = mTabtZon
        Me.DropDownDeptos0.DataBind()

        ' ''Municipio
        'mTabtZon = clsTabtZon.ObtenerLista("2")
        'Me.DropDownMuni.DataTextField = "cDesZon"
        'Me.DropDownMuni.DataValueField = "cCodzon"
        'Me.DropDownMuni.DataSource = mTabtZon
        'Me.DropDownMuni.DataBind()

        'Me.DropDownMuni0.DataTextField = "cDesZon"
        'Me.DropDownMuni0.DataValueField = "cCodzon"
        'Me.DropDownMuni0.DataSource = mTabtZon
        'Me.DropDownMuni0.DataBind()


        ' ''Canton
        'mTabtZon = clsTabtZon.ObtenerLista("3")


        'Me.DropDownComu.DataTextField = "cDesZon"
        'Me.DropDownComu.DataValueField = "cCodzon"
        'Me.DropDownComu.DataSource = mTabtZon
        'Me.DropDownComu.DataBind()

        'La busqueda era muy pesada, corregido Rafa
        BuscaMunicipios()
        BuscaMunicipios0()
        BuscaCantones()


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

        Session.Add("latitud", 0)
        Session.Add("longitud", 0)
        Session.Add("Zona", "")

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
        Me.TxtIFE.Enabled = True
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
        Me.TxtLat.Enabled = True
        Me.TxtLng.Enabled = True


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
        Me.txtcusuface.Enabled = True
        Me.txtccorreo.Enabled = True

        Me.TxtIdCivil.Enabled = True
        Me.TxtIdTribu.Enabled = True
        'Me.cmbOficina.Enabled = True
        Me.btnuevo.Enabled = True
        Me.btgrabar.Enabled = True

        'TxtNomC.Enabled = False
        'TxtIdCony.Enabled = False
        'cmbProfCony.Enabled = False
        'TxtNacCony.Enabled = False
        'cmbGenCony.Enabled = False
        'Sleer.Enabled = False


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
        TxtNacCony.Enabled = True

        '
        Me.TxtNacCony.Enabled = True
        Me.TxtNomC.Enabled = True
        Me.cmbProfCony.Enabled = True
        Me.cmbGenCony.Enabled = True
        Me.TxtIdCony.Enabled = True

        Me.TxtcCalle.Enabled = True
        Me.TxtcCodPostal.Enabled = True
        Me.TxtcNoInt.Enabled = True
        Me.TxtcNoExt.Enabled = True
    End Sub

    Public Sub Limpia()
        ImageFoto.Visible = False
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
        Me.txtcusuface.Text = ""
        Me.txtccorreo.Text = ""

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
        Me.TxtcCalle.Text = ""
        Me.TxtcCodPostal.Text = ""
        Me.TxtcNoInt.Text = ""
        Me.TxtcNoExt.Text = ""
        Me.TxtIFE.TEXT = ""
        txtdueño.Text = ""
        txtvalor.Text = 0
        txtrecidir.Text = Year(Session("gdfecsis"))
        TxtId.Text = ""
        Me.TxtLat.Text = ""
        Me.TxtLng.Text = ""
        cmbparedes.ClearSelection()
        cmbpiso.ClearSelection()
        cmbtecho.ClearSelection()
        cmbservicios.ClearSelection()
        cmbidiomas.ClearSelection()
    End Sub



    Public Sub Deshabilita()
        Me.TxtIFE.Enabled = False
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
        Me.txtcusuface.Enabled = False
        Me.txtccorreo.Enabled = False

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

        Me.TxtcCalle.Enabled = False
        Me.TxtcCodPostal.Enabled = False
        Me.TxtcNoInt.Enabled = False
        Me.TxtcNoExt.Enabled = False
    End Sub

    Private Sub Extraer_Codigo_Postal()
        Dim mTabtZon As New cTabtzon
        Dim Array_Zona As New ArrayList

        Array_Zona = mTabtZon.Extraer_Datos_Zona(Me.DropDownComu.SelectedValue.Trim)
        'Me.TxtDirDom.Text = " C.P.: " & Array_Zona.Item(1)
        Me.TxtcCodPostal.Text = Array_Zona.Item(1)

    End Sub


    Public Sub Restri(ByVal flag As Boolean)
        rqv1.Enabled = flag
        rqv2.Enabled = flag
        'rqv3.Enabled = flag
        rqv4.Enabled = flag
        rqv5.Enabled = flag
        rqv6.Enabled = flag
        rqv7.Enabled = flag
        rqv8.Enabled = flag
        rqv9.Enabled = flag
        rqv10.Enabled = flag
        rqv11.Enabled = flag
        rqv12.Enabled = flag
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
            Me.TxtNacCony.Enabled = True
            Me.TxtNomC.Enabled = True
            Me.cmbProfCony.Enabled = True
            Me.cmbGenCony.Enabled = True
            Me.TxtIdCony.Enabled = True
            If Me.cmbGenCli.SelectedItem.Value.Trim = "F" Then
                cmbGenCony.SelectedItem.Value = "M"
            Else
                cmbGenCony.SelectedItem.Value = "F"
            End If
            Me.Sleer.Enabled = True
            cmbParent.SelectedValue = "06"
            cmbParent.Enabled = True
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
        Restri(True)
        Me.Limpia()
        Me.Habilita()
        'Me.BuscaMunicipios()
        'Me.BuscaCantones()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True
        Extraer_Codigo_Postal()
    End Sub
    Public Function validarLatLong(ByVal latlong As Double) As Boolean
        Dim valido As Boolean
        valido = False
        latlong = Trim(latlong)
        If Double.IsNaN(latlong) Then
            valido = False
        Else
            valido = True
        End If
        Return True

    End Function



    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click

        'Verifica Documento unico
        Dim eclimide As New cClimide
        Dim lverifica As Boolean
        Dim array_zona As New ArrayList
        Dim omzonas As New cTabtzon

        '    Me.TxtIdCivil.Text = Me.TxtIdCivil.Text.Trim.Replace(",", "")
        'Cesar Torres Campos
        'Validar que el valor de los campos de longitud sea correcto
        Dim strLongitud As Object
        Dim strLatitud As Object
        Dim longValida As Boolean
        Dim latValida As Boolean


        strLongitud = Me.TxtLng.Text.Trim
        strLatitud = Me.TxtLat.Text

        longValida = IsNumeric(strLongitud)
        latValida = IsNumeric(strLatitud)





        If latValida = False Then
            codigoJs = "<script language='javascript'>alert('Coordenadas :: Latitud no valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        If longValida = False Then
            codigoJs = "<script language='javascript'>alert('Coordenadas :: Longitud no valida, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If
        If Me.TxtLat.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Geolocalizacion no Realizada, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If

        If Me.TxtCodigo.Text.Trim = "" Then
            lverifica = eclimide.VerificaDocumento(Me.TxtIdCivil.Text.Trim)
            If lverifica = False Then
                'Response.Write("<script language='javascript'>alert('Documento de Identificación ya Registrado')</script>")

                codigoJs = "<script language='javascript'>alert('Documento de Identificación ya Registrado, " & _
                                                    "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If
        Else 'Modificacion de clientes
            'Verifica si Doc. Cambia 
            lverifica = eclimide.Documento_cliente_Existente(TxtIdCivil.Text.Trim, TxtCodigo.Text.Trim)
            If lverifica = False Then
                'Response.Write("<script language='javascript'>alert('Documento de Identificación ya Registrado')</script>")

                codigoJs = "<script language='javascript'>alert('Documento de Identificación ya Registrado, " & _
                                                    "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                'Return
                Exit Sub
            End If
        End If

        If TxtNomcli.Text.Trim = "" Or Txtpriape.Text.Trim = "" Then 'Valida espacios en blanco en campos principales
            '            Response.Write("<script language='javascript'>alert('Faltan Datos, de Nombre Verifique ')</script>")

            codigoJs = "<script language='javascript'>alert('Faltan Datos, de Nombre Verifique, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Calle
        If TxtcCalle.Text.Trim.Length = 0 Then 'Valida Calle
            'Response.Write("<script language='javascript'>alert('Dirección Vacia, Advertencia SIM.NET')</script>")
            codigoJs = "<script language='javascript'>alert('Calle Vacia, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Codigo Postal
        If Me.TxtcCodPostal.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Codigo Postal Vacio, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Número Interior/Exterior
        If Me.TxtcNoExt.Text.Trim.Length = 0 And Me.TxtcNoInt.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Número Interior o Exterior Vacio, " & _
                       "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If TxtDfecnaci.Text.Trim = "" Then 'Valida espacios en blanco en campos principales
            'Response.Write("<script language='javascript'>alert('Fecha de Nacimiento Vacia, Advertencia SIM.NET ')</script>")
            codigoJs = "<script language='javascript'>alert('Fecha de Nacimiento Vacia, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        If TxtIdCivil.Text.Trim = "" Then
            'Valida espacios en blanco en campos principales
            'Response.Write("<script language='javascript'>alert('Número de Identificación Vacio, Advertencia SIM.NET ')</script>")

            Exit Sub

            codigoJs = "<script language='javascript'>alert('Número de Identificación Vacio, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        End If

        'If cmbTipDoc.SelectedValue.Trim = "2" Then
        If TxtIdCivil.Text.Trim.Length = 18 Then
        Else
            'Response.Write("<script language='javascript'>alert('Longitud de CURP No Concuerda, Verifique')</script>")
            codigoJs = "<script language='javascript'>alert('Longitud de CURP No Concuerda, " & _
                                            "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If
        'End If


        If TxtIdTribu.Text.Trim.Length > 0 Then
        Else
            codigoJs = "<script language='javascript'>alert('No de RFC Incompleto, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        'Calle
        If TxtcCalle.Text.Trim.Length > 0 Then 'Valida Calle
            Me.TxtDirDom.Text = Me.TxtcCalle.Text.Trim
        End If

        'Número Interior/Exterior
        If Me.TxtcNoExt.Text.Trim.Length > 0 Then
            Me.TxtDirDom.Text = Me.TxtDirDom.Text & " No Exterior " & Me.TxtcNoExt.Text.Trim
        End If


        'Numero Interior
        If Me.TxtcNoInt.Text.Trim.Length > 0 Then
            Me.TxtDirDom.Text = Me.TxtDirDom.Text & " No Interior " & Me.TxtcNoInt.Text.Trim
        End If

        'Colonia
        Me.TxtDirDom.Text = Me.TxtDirDom.Text & " COLONIA " & Me.DropDownComu.SelectedItem.Text.Trim


        'Codigo Postal
        If Me.TxtcCodPostal.Text.Trim.Length > 0 Then
            Me.TxtDirDom.Text = Me.TxtDirDom.Text & " C.P. " & Me.TxtcCodPostal.Text.Trim
        End If

        'Municipio/Estado
        Me.TxtDirDom.Text = Me.TxtDirDom.Text & " " & Me.DropDownMuni.SelectedItem.Text.Trim & ", " & Me.DropDownDeptos.SelectedItem.Text.Trim


        If clsclass.ValidaEMail(Me.txtccorreo.Text) Then
        Else
            'Response.Write("<script language='javascript'>alert('Correo Inválido ')</script>")
            codigoJs = "<script language='javascript'>alert('Correo Inválido , " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Return
        End If

        Dim lcResul As String
        cClsAdCli._cTipcli = Me.cmbTipcli.SelectedItem.Value.Trim
        cClsAdCli._cCodOfi = Me.cmbOficina.SelectedItem.Value.Trim
        cClsAdCli._ccodigo = Me.TxtCodigo.Text.Trim
        cClsAdCli._cNomcli = Me.TxtNomcli.Text.Trim.ToUpper + IIf(Txtsegnom.Text.Trim = "", "", " ") + Txtsegnom.Text.Trim.ToUpper + IIf(Txtternom.Text.Trim = "", "", " ") + Txtternom.Text.Trim.ToUpper + IIf(Txtpriape.Text.Trim = "", "", " ") + _
        Txtpriape.Text.Trim.ToUpper + IIf(Txtsegape.Text.Trim = "", "", " ") + Txtsegape.Text.Trim.ToUpper + IIf(Txtapecasada.Text.Trim = "", "", " DE  ") + Txtapecasada.Text.Trim.ToUpper
        cClsAdCli._dFecnac = CDate(Me.TxtDfecnaci.Text)

        'If cmbTipDoc.SelectedValue.Trim = "1" Then
        '    cClsAdCli._cnudoci = (Me.Txtorden.Text.Trim + " " + Me.TxtIdCivil.Text.Trim)
        'Else
        cClsAdCli._cnudoci = Me.TxtIdCivil.Text.Trim.ToUpper
        'End If


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

        'If Me.TxtNomC.Text.Trim = "" Or Me.TxtIdCony.Text.Trim = "" Then
        '    Response.Write("<script language='javascript'>alert('Faltan Datos Conyuge/Familiar ')</script>")
        '    Exit Sub
        'End If
        cClsAdCli._cNomCony = Me.TxtNomC.Text.Trim.ToUpper
        cClsAdCli._dfNacCony = CDate(Me.TxtNacCony.Text)
        cClsAdCli._IdCivCony = Me.TxtIdCony.Text.Trim
        cClsAdCli._cGenCony = Me.cmbGenCony.SelectedItem.Value.Trim
        cClsAdCli._cProfCony = Me.cmbProfCony.SelectedItem.Value.Trim
        cClsAdCli._nsabeesc = IIf(Me.Sleer.Checked = True, 1, 0)
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

        'cClsAdCli._clocalidad = cmblocalidad.SelectedValue.Trim

        'Extrae tipo de Zona
        array_zona = omzonas.Extraer_Datos_Zona(Me.DropDownComu.SelectedValue.Trim)

        cClsAdCli._clocalidad = array_zona.Item(0)
        'cClsAdCli._id_codigo_postal = array_zona.Item(1)


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
        cClsAdCli._cCodusu = Session("gccodusu")

        'Nuevos Campos
        cClsAdCli._ife = TxtIFE.Text.Trim()
        cClsAdCli._id_codigo_postal = Me.TxtcCodPostal.Text.Trim
        cClsAdCli._cCalle = Me.TxtcCalle.Text.Trim
        cClsAdCli._cNoExt = Me.TxtcNoExt.Text.Trim
        cClsAdCli._cNoInt = Me.TxtcNoInt.Text.Trim
        cClsAdCli._ccorreo = Me.txtccorreo.Text.Trim
        cClsAdCli._usuface = Me.txtcusuface.Text.Trim

        cClsAdCli.Longitud = Me.TxtLng.Text.Trim
        cClsAdCli.Latitud = Me.TxtLat.Text.Trim


        ''Modificado no guarda la foto
        'If cClsAdCli._ccodigo.Trim = "" Then
        'End If
        Dim lnflag As Integer = 0
        'Try
        '    cClsAdCli.foto = CargaBufferImagen()
        '    lnflag = 1
        'Catch ex As Exception
        '    If cClsAdCli._ccodigo = "" Or cClsAdCli._ccodigo = " " Then 'Es para insertar
        '        'Response.Write("<script language='javascript'>alert('Verifique Foto')</script>")

        '        codigoJs = "<script language='javascript'>alert('Verifique Foto, " & _
        '                                            "Advertencia SIM.NET ')</script>"
        '        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        '        Exit Sub
        '    End If
        '    lnflag = 0
        'End Try



        'Nueva Forma de Grabado, Para Afectar cuenta concetradora y cuenta de Garantía Liquida


        Dim array_d As New ArrayList
        Dim dt_ben As New DataTable
        Dim dt_firm As New DataTable
        Dim dt_Ben_Aport As New DataTable
        Dim dt_Ref As New DataTable
        Dim lnRetorno As Integer = 0


        '* Datos Personales
        array_d.Add(TxtCodigo.Text.Trim)                        'Codigo Socio
        array_d.Add("")                                         'Codigo Socio Manual
        array_d.Add(Txtpriape.Text.Trim.ToUpper)                'Primer Apellido
        array_d.Add(Txtsegape.Text.Trim.ToUpper)                'Segundo Apellido
        array_d.Add(TxtNomcli.Text.Trim.ToUpper)                'Primer Nombre
        array_d.Add(Txtsegnom.Text.Trim.ToUpper)                'Primer Nombre        
        array_d.Add(TxtNomcli.Text.Trim.ToUpper + " " + Txtsegnom.Text.Trim.ToUpper + " " + Txtpriape.Text.Trim.ToUpper + " " + Txtsegape.Text.Trim.ToUpper)   'Nombre Completo
        array_d.Add(TxtNomcli.Text.Trim.ToUpper + " " + Txtsegnom.Text.Trim.ToUpper + " " + Txtpriape.Text.Trim.ToUpper + " " + Txtsegape.Text.Trim.ToUpper)   'Nombre Segun NIT
        array_d.Add(TxtDirDom.Text.Trim)                        'Direccion Asociado 
        array_d.Add(TxtTelDom.Text.Trim)                        'Telefono Domicilio
        array_d.Add(txtcelular.Text.Trim)                       'Numero de Celular
        array_d.Add(TxtDfecnaci.Text.Trim)                      'Fecha de Nacimiento
        array_d.Add(TxtIdCivil.Text.Trim)                       'Numero de CUPR
        array_d.Add(TxtIdTribu.Text.Trim)                       'Numero de RFC
        array_d.Add(cmbGenCli.SelectedValue.Trim)               'Genero
        array_d.Add(cmbProfCli.SelectedValue.Trim)              'Profesion
        array_d.Add(cmbEstCli.SelectedValue.Trim)               'Estado Civil
        array_d.Add(DropDownDeptos0.SelectedValue.Trim)         'Estado Nacimiento
        array_d.Add(DropDownDeptos.SelectedValue.Trim)          'Estado Domicilio
        array_d.Add(DropDownMuni.SelectedValue.Trim)            'Municipio Domicilio

        array_d.Add(TxtIFE.Text.Trim())                         'No IFE
        array_d.Add(Integer.Parse(txthijos.Text))               'No de Hijos
        array_d.Add(Integer.Parse(txtdepen.Text))               'No Dependientes

        'Nuevos Campos
        array_d.Add(Me.TxtcCodPostal.Text.Trim)                 'Codigo Postal
        array_d.Add(Me.TxtcCalle.Text.Trim)                     'Nombre de la Calle
        array_d.Add(Me.TxtcNoExt.Text.Trim)                     'No Exterior    
        array_d.Add(Me.TxtcNoInt.Text.Trim)                     'No Interior
        array_d.Add(Me.txtccorreo.Text.Trim)                    'Correo Electronico
        array_d.Add(Me.txtcusuface.Text.Trim)                   'Usuario Facebook
        array_d.Add(Me.TxtLng.Text.Trim)                        'Latitud
        array_d.Add(Me.TxtLat.Text.Trim)                        'Longitud

        array_d.Add(txtotrtel.Text.Trim)                        'Otro Telefono
        array_d.Add(cmbCondicion.Text.Trim)                     'Condicion de la vivienda
        array_d.Add(txtotracondicion.Text.Trim)                 'Otro
        array_d.Add(cClsAdCli._cpisocondic)                     'Paredes
        array_d.Add(cClsAdCli._cpiso)                           'Piso
        array_d.Add(cClsAdCli._ctecho)                          'Techo
        array_d.Add(cClsAdCli._csercondic)                      'Servicios

        array_d.Add(txtotracondicion0.Text.Trim)                'Otro1
        array_d.Add(txtotracondicion1.Text.Trim)                'Otro2
        array_d.Add(txtotracondicion2.Text.Trim)                'Otro3
        array_d.Add(txtotracondicion3.Text.Trim)                'Otro4
        array_d.Add(txtdueño.Text.Trim)                         'Dueño
        array_d.Add(Double.Parse(txtvalor.Text.Trim))           'Valor Aproximado
        array_d.Add(Integer.Parse(txtrecidir.Text.Trim))        'Años de residir

        array_d.Add(Session("GCCODOFI"))                        'Oficina
        array_d.Add(Session("GDFECSIS"))                        'Fecha de Modificación
        array_d.Add(Session("GCCODUSU"))                        'Usuario

        'Otros
        array_d.Add(cmbEtnia.SelectedValue.Trim)                'Etnia
        array_d.Add(cmbgruetnico.SelectedValue.Trim)            'Grupo Etnico
        array_d.Add(cmbidiomas.SelectedValue.Trim)              'idomas que domina
        array_d.Add(cmbNivel.SelectedValue.Trim)                'Escolaridad
        array_d.Add(txtgrado.Text.Trim)                         'Grado
        array_d.Add(cmbleer.SelectedValue.Trim)                 'Sabe Leer
        array_d.Add(cmbfirmar.SelectedValue.Trim)               'Sabe firmar
        array_d.Add(Txtadicionales.Text.Trim)                   'Adicionales
        array_d.Add(cmbescribir.SelectedValue.Trim)             'Sabe escribir

        'Datos del Conyuge
        array_d.Add(Me.TxtNomC.Text.Trim.ToUpper)               'Nombre del Coyuge   
        array_d.Add(CDate(Me.TxtNacCony.Text))                  'Fecha de Nacimiento Cinyuge
        array_d.Add(Me.TxtIdCony.Text.Trim)                     'no CURP conyuge 
        array_d.Add(Me.cmbGenCony.SelectedItem.Value.Trim)      'Genero Conyuge
        array_d.Add(Me.cmbProfCony.SelectedItem.Value.Trim)     'Profesion Conyuge
        array_d.Add(IIf(Me.Sleer.Checked = True, 1, 0))         'Sabe Leer y escribir
        array_d.Add(TxtId.Text.Trim)                            'Id Conyuge
        array_d.Add(cmbCondicion.SelectedValue.Trim)            'Condicion de la vivienda 
        array_d.Add(Txtapecasada.Text.Trim)                     'Apellido de Casada
        array_d.Add(array_zona.Item(0))                         'Tipo Zona
        array_d.Add(cmbParent.SelectedValue.Trim)               'Parentesco
        array_d.Add(DropDownComu.SelectedValue.Trim)            'Colonia
        array_d.Add(DropDownMuni0.SelectedValue.Trim)           'Municipio de nacimiento
        'Fin


        'Cliente nuevo
        If TxtCodigo.Text.Trim.Length = 0 Then
            lcResul = cClscli.Mantenimiento_Clientes(array_d, dt_ben, dt_firm, dt_Ben_Aport, dt_Ref)

            If lcResul.Trim.Length = 0 Then
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                           "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            Else
                codigoJs = "<script language='javascript'>alert('El Codigo Grabado es  " & lcResul & " , " & _
                           "Adviso SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)


                Session("codigocli") = lcResul
                TxtCodigo.Text = lcResul
            End If
        Else
            lcResul = cClsAdCli.AdCliente(lnflag)

            If lcResul = "0" Then
                codigoJs = "<script language='javascript'>alert('Ocurrio un Error, " & _
                                                "Advertencia SIM.NET ')</script>"
                ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
                Exit Sub
            End If

        End If







        'If lcResul = "0" Then
        '    Exit Sub
        'Else
        'If lcResul <> "" Then
        '    'Response.Write("<script language='javascript'>alert('El Codigo Grabado es  " & lcResul & " ')</script>")
        '    codigoJs = "<script language='javascript'>alert('El Codigo Grabado es  " & lcResul & " , " & _
        '                                        "Advertencia SIM.NET ')</script>"
        '    ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

        '    Session("codigocli") = lcResul
        '    TxtCodigo.Text = lcResul
        'End If
        'End If
        Dim clsppal As New class1
        clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "Gr", 2)

        'Me.Limpia()
        Me.Deshabilita()
        Me.btreferencia.Enabled = True
    End Sub

    Protected Sub bteditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bteditar.Click
        Me.Habilita()
        'Me.cmbEstCli_SelectedIndexChanged(sender, e)
        Me.bteditar.Enabled = False
        btreferencia.Enabled = True
    End Sub

    Protected Sub btCancela_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCancela.Click
        Restri(False)
        Me.Limpia()
        Me.Deshabilita()
    End Sub

    Protected Sub btreferencia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btreferencia.Click

        If Me.TxtCodigo.Text.Trim.Length = 0 Then
            codigoJs = "<script language='javascript'>alert('Primero Debe Grabar el Cliente, Antes de Introducir las Referencias Familiares, " & _
                                                "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            Exit Sub
        End If

        Session("codigocli") = Me.TxtCodigo.Text.Trim
        Session("codigo") = "1"
        'Response.Redirect("wbreferencia.aspx")

        'Response.Write("<script>window.open('wbreferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=950,height=550')</script>")

        codigoJs = "<script>window.open('wbreferencia.aspx','cal', 'location=1, toolbar = no, status=1,width=1150,height=300')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
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
                lblStatus.ForeColor = Color.FromArgb(0, 102, 255)
                lblStatus.Text = "Archivo Subido con Exito"
                'Image1.ImageUrl = "~/uploads/" + filepath
                hfPathArchivo.Value = pathGrabar

                ImageFoto.Visible = True
                Me.ImageFoto.ImageUrl = "~/uploads/" & Archivo
            Else
                lblStatus.ForeColor = Color.Red
                lblStatus.Text = "No Existe Archivo a Subir"
            End If

        Catch ex As Exception
            lblStatus.ForeColor = Color.Red
            lblStatus.Text = "Error al subir archivo"
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
    'Protected Function CargarImagenDeBaseDatos(ByVal imagen() As Byte) As String
    '    Dim imageInBytes As Byte() = imagen
    '    Dim pathUploads As String
    '    Dim nombreArchivo As String
    '    Dim archivoLogico As StreamWriter
    '    nombreArchivo = HiddenField1.Value + hfExtension.Value
    '    pathUploads = Server.MapPath(".\uploads\")

    '    File.WriteAllBytes(pathUploads + nombreArchivo, imagen)


    'End Function
    Private Sub ImagenMuestra()
        ImageFoto.ImageUrl = String.Format("displayImage.ashx?UserID={0}", TxtCodigo.Text.Trim)
        'ImageFoto.ImageUrl = "ImageVB.aspx?ImageID=" & "'" & TxtCodigo.Text.Trim & "'"
        ImageFoto.Visible = False
    End Sub
    Private Sub CargarImagen()
        Dim ecreditos As New ccreditos
        Dim conexion As New SqlConnection(ecreditos.CadenaActual)
        Dim consulta As New SqlDataAdapter("Select foto from climide where ccodcli=" & "'" & TxtCodigo.Text.Trim & "'", conexion)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(consulta)
        Dim ds As New DataSet()
        Try
            conexion.Open()
            consulta.Fill(ds, "Imagenes")
            Dim fila As DataRow
            fila = ds.Tables("Imagenes").Rows(0)
            Dim binario() As Byte
            binario = fila.Item(0)
            'Image1.ImageUrl = binario.ToString
            'Dim k As Long
            'k = UBound(binario)
            Response.Buffer = True
            Response.ContentType = "Image/JPEG"
            Response.BinaryWrite(binario)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Protected Function CargarImagenDeBaseDatos(ByVal imagen() As Byte) As String
        Dim imageInBytes As Byte() = imagen
        Dim pathUploads As String
        Dim nombreArchivo As String

        Dim archivoLogico As StreamWriter

        nombreArchivo = hfIdEmpleado.Value + ".jpg" 'hfExtension.Value
        pathUploads = Server.MapPath(".\uploads\")
        File.WriteAllBytes(pathUploads + nombreArchivo, imagen)

    End Function


    Protected Sub btnadd_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnadd.Click
        Restri(True)
        Me.Limpia()
        Me.Habilita()
        'Me.BuscaMunicipios()
        'Me.BuscaCantones()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True
    End Sub

    Protected Sub DropDownComu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownComu.SelectedIndexChanged
        Extraer_Codigo_Postal()
        Session("Zona") = DropDownDeptos.SelectedItem.Text.Trim + ", " + DropDownMuni.SelectedItem.Text.Trim + ", " + _
                          DropDownComu.SelectedItem.Text.Trim
    End Sub


    Protected Sub TxtNomcli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNomcli.TextChanged

    End Sub

    Protected Sub TxtcCalle_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtcCalle.TextChanged

    End Sub



    Protected Sub btnubicacion_2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnubicacion_2.Click
        codigoJs = "<script>window.open('Map/Geocoding.aspx','cal', 'location=1, toolbar = no, status=1,width=1100,height=650')</script>"
        ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

    End Sub



End Class


