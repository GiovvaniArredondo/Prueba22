

Partial Class wucSocioEco
    Inherits ucWBase
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String


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

    Dim entidadClimide As New climide
    Dim eClimide As New cClimide
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarCombo()
            Me.TxtCodigo.Text = Session("codigocli")
            'Me.cargaDatos()
        End If
    End Sub
    Public Sub CargaCliente()
        Me.TxtCodigo.Text = Session("codigocli")
    End Sub
    Public Sub CargarCombo()

        Dim clstabttab As New SIM.BL.cTabttab
        Dim mListaTabttab As New listatabttab

        'Nivel academico
        mListaTabttab = clstabttab.ObtenerLista("151", "1")

        Me.cmbgrado.DataTextField = "cdescri"
        Me.cmbgrado.DataValueField = "ccodigo"
        Me.cmbgrado.DataSource = mListaTabttab
        Me.cmbgrado.DataBind()

    End Sub
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
        Me.TxtNomcli.Text = entidadClimide.cnomcli.Trim
        Me.RefrescaGrid()

        'Carga Encuesta
        Me.CargaEncuesta()
    End Sub
    Private Sub CargaEncuesta()

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        Dim retorno As Integer
        entidadClimide.ccodcli = Me.TxtCodigo.Text.Trim
        retorno = eClimide.RecuperarEstudioSocio(entidadClimide)
        If retorno = 0 Then
            Exit Sub
        End If

        Me.txtobserv.Text = entidadClimide.cdejaesc.Trim
        Me.CheckBox2.Checked = IIf(entidadClimide.nprestamo = 1, True, False)

        Me.CheckBox2.Checked = IIf(entidadClimide.nprestamo = 1, True, False)

        Me.CheckBox6.Checked = IIf(entidadClimide.ninvertir1 = 1, True, False)
        Me.CheckBox7.Checked = IIf(entidadClimide.ninvertir2 = 1, True, False)
        Me.CheckBox8.Checked = IIf(entidadClimide.ninvertir3 = 1, True, False)
        Me.CheckBox9.Checked = IIf(entidadClimide.ninvertir4 = 1, True, False)
        Me.CheckBox10.Checked = IIf(entidadClimide.ninvertir5 = 1, True, False)
        Me.CheckBox11.Checked = IIf(entidadClimide.ninvertir6 = 1, True, False)

        Me.CheckBox12.Checked = IIf(entidadClimide.nuso1 = 1, True, False)
        Me.CheckBox13.Checked = IIf(entidadClimide.nuso2 = 1, True, False)
        Me.CheckBox14.Checked = IIf(entidadClimide.nuso3 = 1, True, False)
        Me.CheckBox15.Checked = IIf(entidadClimide.nuso4 = 1, True, False)
        Me.CheckBox16.Checked = IIf(entidadClimide.nuso5 = 1, True, False)

        Me.CheckBox17.Checked = IIf(entidadClimide.nhogar1 = 1, True, False)
        Me.CheckBox18.Checked = IIf(entidadClimide.nhogar2 = 1, True, False)
        Me.CheckBox19.Checked = IIf(entidadClimide.nhogar3 = 1, True, False)
        Me.CheckBox20.Checked = IIf(entidadClimide.nhogar4 = 1, True, False)
        Me.CheckBox21.Checked = IIf(entidadClimide.nhogar5 = 1, True, False)
        Me.CheckBox22.Checked = IIf(entidadClimide.nhogar6 = 1, True, False)

        Me.CheckBox23.Checked = IIf(entidadClimide.nhogarxq1 = 1, True, False)
        Me.CheckBox24.Checked = IIf(entidadClimide.nhogarxq2 = 1, True, False)
        Me.CheckBox25.Checked = IIf(entidadClimide.nhogarxq3 = 1, True, False)
        Me.CheckBox26.Checked = IIf(entidadClimide.nhogarxq4 = 1, True, False)
        Me.CheckBox27.Checked = IIf(entidadClimide.nhogarxq5 = 1, True, False)

        Me.CheckBox43.Checked = IIf(entidadClimide.nsiaumento1 = 1, True, False)
        Me.CheckBox44.Checked = IIf(entidadClimide.nsiaumento2 = 1, True, False)
        Me.CheckBox45.Checked = IIf(entidadClimide.nsiaumento3 = 1, True, False)
        Me.CheckBox46.Checked = IIf(entidadClimide.nsiaumento4 = 1, True, False)
        Me.CheckBox47.Checked = IIf(entidadClimide.nsiaumento5 = 1, True, False)

        Me.CheckBox3.Checked = IIf(entidadClimide.nenseres = 1, True, False)
        Me.CheckBox28.Checked = IIf(entidadClimide.nsicual1 = 1, True, False)
        Me.CheckBox29.Checked = IIf(entidadClimide.nsicual2 = 1, True, False)
        Me.CheckBox30.Checked = IIf(entidadClimide.nsicual3 = 1, True, False)
        Me.CheckBox31.Checked = IIf(entidadClimide.nsicual4 = 1, True, False)
        Me.CheckBox32.Checked = IIf(entidadClimide.nsicual5 = 1, True, False)
        Me.CheckBox33.Checked = IIf(entidadClimide.nsicual6 = 1, True, False)
        Me.CheckBox34.Checked = IIf(entidadClimide.nsicual7 = 1, True, False)

        Me.TextBox5.Text = entidadClimide.csicual

        Me.CheckBox4.Checked = IIf(entidadClimide.npropia = 1, True, False)
        Me.CheckBox5.Checked = IIf(entidadClimide.nmejoras = 1, True, False)

        Me.CheckBox35.Checked = IIf(entidadClimide.nsimejoras1 = 1, True, False)
        Me.CheckBox36.Checked = IIf(entidadClimide.nsimejoras2 = 1, True, False)
        Me.CheckBox37.Checked = IIf(entidadClimide.nsimejoras3 = 1, True, False)
        Me.CheckBox38.Checked = IIf(entidadClimide.nsimejoras4 = 1, True, False)
        Me.CheckBox39.Checked = IIf(entidadClimide.nsimejoras5 = 1, True, False)
        Me.CheckBox40.Checked = IIf(entidadClimide.nsimejoras6 = 1, True, False)
        Me.CheckBox41.Checked = IIf(entidadClimide.nsimejoras7 = 1, True, False)
        Me.CheckBox42.Checked = IIf(entidadClimide.nsimejoras8 = 1, True, False)

        Me.TextBox6.Text = entidadClimide.csimejoras


    End Sub
  

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lcCodhij As String
        Dim cls As New clsSocio
        Dim lncentinela As Integer

        If Me.TxtComodin.Text.Trim = "" _
                 Or Me.TxtComodin.Text.Trim = Nothing Then 'Nuevo Registro
            Dim eClimide As New cClimide
            lcCodhij = eClimide.ObtenercCodgar(Me.TxtCodigo.Text.Trim)
            cls._cnrohij = lcCodhij
            cls._llBandera = True
        Else
            cls._cnrohij = Me.TxtComodin.Text.Trim
            cls._llBandera = False
        End If

        cls._ccodcli = Me.TxtCodigo.Text.Trim
        cls._cnomhij = Me.TextBox1.Text.Trim
        cls._dfecnac = Date.Parse(Me.TextBox2.Text.Trim)
        cls._ccodgra = Me.cmbgrado.SelectedValue.Trim
        cls._lcarnet = Me.CheckBox1.Checked
        cls._ccodusu = Session("gccodusu")

        lncentinela = cls.GrabaHijos()

        If lncentinela = 1 Then 'Proceso Correcto
            Me.RefrescaGrid()
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = Today
            Me.CheckBox1.Checked = False
        Else                    'Genero Error

        End If
    End Sub
    Public Sub initvar()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.CheckBox1.Checked = False
        Me.txtobserv.Text = ""

        Me.TxtComodin.Text = ""

        Me.CheckBox6.Checked = False
        Me.CheckBox7.Checked = False
        Me.CheckBox8.Checked = False
        Me.CheckBox9.Checked = False
        Me.CheckBox10.Checked = False
        Me.CheckBox11.Checked = False

        Me.CheckBox12.Checked = False
        Me.CheckBox13.Checked = False
        Me.CheckBox14.Checked = False
        Me.CheckBox15.Checked = False
        Me.CheckBox16.Checked = False

        Me.CheckBox17.Checked = False
        Me.CheckBox18.Checked = False
        Me.CheckBox19.Checked = False
        Me.CheckBox20.Checked = False
        Me.CheckBox21.Checked = False
        Me.CheckBox22.Checked = False

        Me.CheckBox23.Checked = False
        Me.CheckBox24.Checked = False
        Me.CheckBox25.Checked = False
        Me.CheckBox26.Checked = False
        Me.CheckBox27.Checked = False

        Me.TextBox4.Text = ""

        Me.CheckBox3.Checked = False

        Me.CheckBox28.Checked = False
        Me.CheckBox29.Checked = False
        Me.CheckBox30.Checked = False
        Me.CheckBox31.Checked = False
        Me.CheckBox32.Checked = False
        Me.CheckBox33.Checked = False
        Me.CheckBox34.Checked = False

        Me.TextBox5.Text = ""

        Me.CheckBox4.Checked = False
        Me.CheckBox5.Checked = False

        Me.CheckBox35.Checked = False
        Me.CheckBox36.Checked = False
        Me.CheckBox37.Checked = False
        Me.CheckBox38.Checked = False
        Me.CheckBox39.Checked = False
        Me.CheckBox40.Checked = False
        Me.CheckBox41.Checked = False
        Me.CheckBox42.Checked = False

        Me.TextBox6.Text = ""

    End Sub

    Public Sub RefrescaGrid()

        'Trae las Garantias del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide
        Dim ds As New DataSet
        Dim ncanti As Integer


        ds = eClimide.ObtenerDataSetHijos(Me.TxtCodigo.Text.Trim)

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Me.Datagrid1.DataSource = ""
            Me.Datagrid1.DataBind()
            Exit Sub
        End If
        Dim fila As DataRow
        Dim i As Integer = 0
        Dim lnedad As Integer = 0
        Dim ldfecnac As Date
        Dim ldfecha As Date = Session("gdfecsis")
        For Each fila In ds.Tables(0).Rows
            ldfecnac = ds.Tables(0).Rows(i)("dfecnac")
            lnedad = DateDiff(DateInterval.Year, ldfecnac, ldfecha)
            ds.Tables(0).Rows(i)("nedad") = lnedad
            i += 1
        Next

        Me.Datagrid1.DataSource = ds
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
        ds.Tables.Clear()
    End Sub

    Protected Sub Datagrid1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        Dim ds As New DataSet
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        Me.TxtComodin.Text = Me.ClienteSeleccionado
        Dim eclimide As New cClimide
        ds = eclimide.ObtenerDataSetporHijo(Me.TxtCodigo.Text.Trim, Me.TxtComodin.Text.Trim)

        Dim ncanti As Integer

        ncanti = ds.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub        'Hubo un error Depurar
        End If

        Dim lccodgrad As String = ""
        Me.TextBox1.Text = ds.Tables(0).Rows(0)("cnomhij")
        Me.TextBox2.Text = ds.Tables(0).Rows(0)("dfecnac")
        Me.CheckBox1.Checked = IIf(ds.Tables(0).Rows(0)("lcarnet") = "1", True, False)
        lccodgrad = ds.Tables(0).Rows(0)("ccodgrad")
        Me.cmbgrado.SelectedValue = lccodgrad.Trim
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim eclimide As New cClimide
        If Me.TxtCodigo.Text.Trim = "" Or Me.TxtComodin.Text.Trim = "" Then
            Exit Sub
        Else
            eclimide.QuitarRegistroporHijo(Me.TxtCodigo.Text.Trim, Me.TxtComodin.Text.Trim)
        End If
        TxtComodin.Text = ""

        Me.RefrescaGrid()
    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        Dim cls As New clsSocio
        Dim lccodcli As String
        lccodcli = Me.TxtCodigo.Text.Trim
        'Verifica si ya existe Registro
        Dim lverifica As Boolean
        lverifica = eClimide.ExisteRegistroSocioEco(lccodcli)

        cls._llBandera = lverifica

        cls._ccodcli = Me.TxtCodigo.Text.Trim
        cls._cdejaesc = Me.txtobserv.Text.Trim
        cls._nprestamo = IIf(Me.CheckBox2.Checked = True, 1, 0)

        cls._ninvertir1 = IIf(Me.CheckBox6.Checked = True, 1, 0)
        cls._ninvertir2 = IIf(Me.CheckBox7.Checked = True, 1, 0)
        cls._ninvertir3 = IIf(Me.CheckBox8.Checked = True, 1, 0)
        cls._ninvertir4 = IIf(Me.CheckBox9.Checked = True, 1, 0)
        cls._ninvertir5 = IIf(Me.CheckBox10.Checked = True, 1, 0)
        cls._ninvertir6 = IIf(Me.CheckBox11.Checked = True, 1, 0)
        cls._cinvertir = Me.TextBox3.Text.Trim

        cls._nuso1 = IIf(Me.CheckBox12.Checked = True, 1, 0)
        cls._nuso2 = IIf(Me.CheckBox13.Checked = True, 1, 0)
        cls._nuso3 = IIf(Me.CheckBox14.Checked = True, 1, 0)
        cls._nuso4 = IIf(Me.CheckBox15.Checked = True, 1, 0)
        cls._nuso5 = IIf(Me.CheckBox16.Checked = True, 1, 0)

        cls._nhogar1 = IIf(Me.CheckBox17.Checked = True, 1, 0)
        cls._nhogar2 = IIf(Me.CheckBox18.Checked = True, 1, 0)
        cls._nhogar3 = IIf(Me.CheckBox19.Checked = True, 1, 0)
        cls._nhogar4 = IIf(Me.CheckBox20.Checked = True, 1, 0)
        cls._nhogar5 = IIf(Me.CheckBox21.Checked = True, 1, 0)
        cls._nhogar6 = IIf(Me.CheckBox22.Checked = True, 1, 0)

        cls._nhogarxq1 = IIf(Me.CheckBox23.Checked = True, 1, 0)
        cls._nhogarxq2 = IIf(Me.CheckBox24.Checked = True, 1, 0)
        cls._nhogarxq3 = IIf(Me.CheckBox25.Checked = True, 1, 0)
        cls._nhogarxq4 = IIf(Me.CheckBox26.Checked = True, 1, 0)
        cls._nhogarxq5 = IIf(Me.CheckBox27.Checked = True, 1, 0)

        cls._chogarxq = Me.TextBox4.Text.Trim

        cls._nsiaumento1 = IIf(Me.CheckBox43.Checked = True, 1, 0)
        cls._nsiaumento2 = IIf(Me.CheckBox44.Checked = True, 1, 0)
        cls._nsiaumento3 = IIf(Me.CheckBox45.Checked = True, 1, 0)
        cls._nsiaumento4 = IIf(Me.CheckBox46.Checked = True, 1, 0)
        cls._nsiaumento5 = IIf(Me.CheckBox47.Checked = True, 1, 0)

        cls._nenseres = IIf(Me.CheckBox3.Checked = True, 1, 0)
        cls._nsicual1 = IIf(Me.CheckBox28.Checked = True, 1, 0)
        cls._nsicual2 = IIf(Me.CheckBox29.Checked = True, 1, 0)
        cls._nsicual3 = IIf(Me.CheckBox30.Checked = True, 1, 0)
        cls._nsicual4 = IIf(Me.CheckBox31.Checked = True, 1, 0)
        cls._nsicual5 = IIf(Me.CheckBox32.Checked = True, 1, 0)
        cls._nsicual6 = IIf(Me.CheckBox33.Checked = True, 1, 0)
        cls._nsicual7 = IIf(Me.CheckBox34.Checked = True, 1, 0)

        cls._csicual = Me.TextBox5.Text.Trim

        cls._npropia = IIf(Me.CheckBox4.Checked = True, 1, 0)
        cls._nmejoras = IIf(Me.CheckBox5.Checked = True, 1, 0)

        cls._nsimejoras1 = IIf(Me.CheckBox35.Checked = True, 1, 0)
        cls._nsimejoras2 = IIf(Me.CheckBox36.Checked = True, 1, 0)
        cls._nsimejoras3 = IIf(Me.CheckBox37.Checked = True, 1, 0)
        cls._nsimejoras4 = IIf(Me.CheckBox38.Checked = True, 1, 0)
        cls._nsimejoras5 = IIf(Me.CheckBox39.Checked = True, 1, 0)
        cls._nsimejoras6 = IIf(Me.CheckBox40.Checked = True, 1, 0)
        cls._nsimejoras7 = IIf(Me.CheckBox41.Checked = True, 1, 0)
        cls._nsimejoras8 = IIf(Me.CheckBox42.Checked = True, 1, 0)

        cls._csimejoras = Me.TextBox6.Text.Trim
        Dim lncentinela As Integer

        lncentinela = cls.GrabaSocioEconomico()

        If lncentinela = 1 Then 'Proceso Correcto
            Response.Write("<script language='javascript'>alert('Registro Grabado,OK')</script>")
        Else                    'Genero Error

        End If

    End Sub
End Class


