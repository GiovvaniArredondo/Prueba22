

Partial Class WbUsFueFam
    Inherits ucWBase


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

#Region "Metodos"
    Public Sub CargarPorCliente(ByVal codigoCliente As String)

        Dim gdfecsis As Date = Session("gdfecsis")

        Me.TxtComodin.Text = codigoCliente

        'Nombre del Cliente
        Dim entidadClimide As New SIM.EL.climide
        Dim eClimide As New SIM.BL.cClimide

        entidadClimide.ccodcli = Me.TxtComodin.Text.Trim
        eClimide.ObtenerClimide(entidadClimide)
        Me.txtcnomcli.Text = entidadClimide.cnomcli.Trim
        carganuevo()
    End Sub
    Private Sub carganuevo()
        Me.Inicializa()
        Me.Habilita()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True

    End Sub
    Public Sub FuentesFamiliares(ByVal codigocliente As String)
       
        Dim entidadClidfami As New SIM.EL.CLIDFAMI
        Dim eClidfami As New SIM.BL.cCLIDFAMI
        Dim ds As New DataSet
        Dim ncanti As Integer
        'Dim lndate As Date

        ds = eClidfami.ObtenerDataSetEspc(Me.TxtComodin.Text.Trim)

        ncanti = ds.Tables(0).Rows.Count()


        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If

        Me.Datagrid1.DataSource = ds
        Me.Datagrid1.DataBind()
        Me.Datagrid1.Enabled = True
    End Sub

    Public Sub Habilita()
        Me.txtIngrCony.Enabled = True
        Me.Txtcuotas.Enabled = True
        Me.TxtRemesa.Enabled = True
        Me.TxtOtros.Enabled = True
        Me.Txtviv.Enabled = True
        Me.TxtAlim.Enabled = True
        Me.TxtTel.Enabled = True
        Me.TxtTrans.Enabled = True
        Me.TxtEdu.Enabled = True
        Me.TxtSalud.Enabled = True
        Me.TxtVest.Enabled = True
        Me.txtPers.Enabled = True
        Me.txtdFecha.Enabled = True
        Me.btgrabar.Enabled = False
    End Sub

    Sub Inicializa()
        Me.txtIngrCony.Text = 0
        Me.Txtcuotas.Text = 0
        Me.TxtRemesa.Text = 0
        Me.TxtOtros.Text = 0
        Me.Txtviv.Text = 0
        Me.TxtAlim.Text = 0
        Me.TxtTel.Text = 0
        Me.TxtTrans.Text = 0
        Me.TxtEdu.Text = 0
        Me.TxtSalud.Text = 0
        Me.TxtVest.Text = 0
        Me.txtPers.Text = 0
        Me.TxtTIngr.Text = 0
        Me.TxtTEgr.Text = 0
        Me.txtdFecha.Text = Session("gdFecSis")
    End Sub

    Sub Deshabilita()
        Me.txtIngrCony.Enabled = False
        Me.Txtcuotas.Enabled = False
        Me.TxtRemesa.Enabled = False
        Me.TxtOtros.Enabled = False
        Me.Txtviv.Enabled = False
        Me.TxtAlim.Enabled = False
        Me.TxtTel.Enabled = False
        Me.TxtTrans.Enabled = False
        Me.TxtEdu.Enabled = False
        Me.TxtSalud.Enabled = False
        Me.TxtVest.Enabled = False
        Me.txtPers.Enabled = False
        Me.txtdFecha.Enabled = False
    End Sub

    Sub Limpieza()
        Me.txtIngrCony.Text = 0
        Me.Txtcuotas.Text = 0
        Me.TxtRemesa.Text = 0
        Me.TxtOtros.Text = 0
        Me.Txtviv.Text = 0
        Me.TxtAlim.Text = 0
        Me.TxtTel.Text = 0
        Me.TxtTrans.Text = 0
        Me.TxtEdu.Text = 0
        Me.TxtSalud.Text = 0
        Me.TxtVest.Text = 0
        Me.txtPers.Text = 0
        Me.TxtTIngr.Text = 0
        Me.TxtTEgr.Text = 0
        Me.txtdFecha.Text = Session("gdFecSis")
        Me.TxtBandera.Text = " "
    End Sub

    Public Sub TotalizaIngreso()
        Me.TxtTIngr.Text = Val(Me.txtIngrCony.Text.Trim) + Val(Me.Txtcuotas.Text.Trim) + Val(Me.TxtRemesa.Text.Trim) + Val(Me.TxtOtros.Text.Trim)
    End Sub

    Public Sub TotalizaEgreso()
        Me.TxtTEgr.Text = (Val(Me.Txtviv.Text.Trim) + Val(Me.TxtAlim.Text.Trim) + Val(Me.TxtTel.Text.Trim) + Double.Parse(Me.TxtTrans.Text.Trim) + Val(Me.TxtEdu.Text.Trim) + Val(Me.TxtSalud.Text.Trim) + Val(Me.TxtVest.Text.Trim) + Val(Me.txtPers.Text.Trim))
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load 'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "INF", 3)

            UpdatePanel1.Visible = False
        Else
            If Session("gdfecha") = #1/1/1980# Then
            Else
                txtdFecha.Text = Session("gdfecha")
            End If
        End If
    End Sub

    Private Sub TxtTIngr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTIngr.TextChanged

    End Sub


    Private Sub Datagrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid1.SelectedIndexChanged
        ClienteSeleccionado = CType(Me.Datagrid1.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text



        Dim entidadclidfami As New SIM.El.CLIDFAMI
        Dim eClidfami As New SIM.BL.cCLIDFAMI


        entidadclidfami.ccodcli = Me.TxtComodin.Text.Trim
        entidadclidfami.cCodUni = ClienteSeleccionado

        eClidfami.ObtenerCLIDFAMI(entidadclidfami)

        Me.txtIngrCony.Text = entidadclidfami.nIngCony
        Me.Txtcuotas.Text = entidadclidfami.nIngFami
        Me.TxtRemesa.Text = entidadclidfami.nIngReme
        Me.TxtOtros.Text = entidadclidfami.nIngSSPC

        Me.Txtviv.Text = entidadclidfami.nGasCasa
        Me.TxtAlim.Text = entidadclidfami.nGasAlim
        Me.TxtTel.Text = entidadclidfami.nGasAlte
        Me.TxtTrans.Text = entidadclidfami.ngasTran
        Me.TxtEdu.Text = entidadclidfami.nGasEduc
        Me.TxtSalud.Text = entidadclidfami.nGasSalu
        Me.TxtVest.Text = entidadclidfami.nGasRopa
        Me.txtPers.Text = entidadclidfami.nGasPres
        Me.txtdFecha.Text = entidadclidfami.dEvalua.ToShortDateString


        Me.TxtBandera.Text = ClienteSeleccionado

        Me.TotalizaIngreso()
        Me.TotalizaEgreso()

        Me.Habilita()
        Me.btgrabar.Enabled = True
        Me.bteliminar.Enabled = True
        Me.btnuevo.Enabled = False
    End Sub






    
    Protected Sub btnuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnuevo.Click
        '  Me.txtdFecha.Text = Session("gdfecsis")
        Me.Inicializa()
        Me.Habilita()
        Me.btnuevo.Enabled = False
        Me.btgrabar.Enabled = True

    End Sub

    Protected Sub btgrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btgrabar.Click
        Dim cls As New SIM.BL.ClsFuentes
        Dim centinela As Integer

        If Me.txtdFecha.Text.Trim = "" Then
            Exit Sub
        End If

        Try

            cls._ccodcli = Me.TxtComodin.Text.Trim
            cls._dEvalua = CDate(Me.txtdFecha.Text.Trim)
            cls._dfecmod = Session("gdfecsis")
            cls._cCodusu = Session("gcCodusu")

            ' Valida que no vayan valores en blanco
            If Me.txtIngrCony.Text.Trim = "" Or Me.txtIngrCony.Text.Trim = Nothing Then
                Me.txtIngrCony.Text = 0
            End If
            If Me.Txtcuotas.Text.Trim = "" Or Me.Txtcuotas.Text.Trim = Nothing Then
                Me.Txtcuotas.Text = 0
            End If
            If Me.TxtRemesa.Text.Trim = "" Or Me.TxtRemesa.Text.Trim = Nothing Then
                Me.TxtRemesa.Text = 0
            End If
            If Me.txtIngrCony.Text.Trim = "" Or Me.txtIngrCony.Text.Trim = Nothing Then
                Me.txtIngrCony.Text = 0
            End If
            If Me.TxtOtros.Text.Trim = "" Or Me.TxtOtros.Text.Trim = Nothing Then
                Me.TxtOtros.Text = 0
            End If
            If Me.Txtviv.Text.Trim = "" Or Me.Txtviv.Text.Trim = Nothing Then
                Me.Txtviv.Text = 0
            End If
            If Me.TxtAlim.Text.Trim = "" Or Me.TxtAlim.Text.Trim = Nothing Then
                Me.TxtAlim.Text = 0
            End If
            If Me.TxtTel.Text.Trim = "" Or Me.TxtTel.Text.Trim = Nothing Then
                Me.TxtTel.Text = 0
            End If
            If Me.TxtTrans.Text.Trim = "" Or Me.TxtTrans.Text.Trim = Nothing Then
                Me.TxtTrans.Text = 0
            End If
            If Me.TxtEdu.Text.Trim = "" Or Me.TxtEdu.Text.Trim = Nothing Then
                Me.TxtEdu.Text = 0
            End If
            If Me.TxtSalud.Text.Trim = "" Or Me.TxtSalud.Text.Trim = Nothing Then
                Me.TxtSalud.Text = 0
            End If
            If Me.TxtVest.Text.Trim = "" Or Me.TxtVest.Text.Trim = Nothing Then
                Me.TxtVest.Text = 0
            End If
            If Me.txtPers.Text.Trim = "" Or Me.txtPers.Text.Trim = Nothing Then
                Me.txtPers.Text = 0
            End If
            calculo()

            cls._nIngCony = Double.Parse(Me.txtIngrCony.Text.Trim)
            cls._nIngFami = Double.Parse(Me.Txtcuotas.Text.Trim)
            cls._nIngReme = Double.Parse(Me.TxtRemesa.Text.Trim)
            cls._nIngSSPC = Double.Parse(Me.TxtOtros.Text.Trim)

            cls._nGasCasa = Double.Parse(Me.Txtviv.Text.Trim)
            cls._nGasAlim = Double.Parse(Me.TxtAlim.Text.Trim)
            cls._nGasAlte = Double.Parse(Me.TxtTel.Text.Trim)
            cls._ngasTran = Double.Parse(Me.TxtTrans.Text.Trim)
            cls._nGasEduc = Double.Parse(Me.TxtEdu.Text.Trim)
            cls._nGasSalu = Double.Parse(Me.TxtSalud.Text.Trim)
            cls._nGasRopa = Double.Parse(Me.TxtVest.Text.Trim)
            cls._nGasPres = Double.Parse(Me.txtPers.Text.Trim)



            If Me.TxtBandera.Text.Trim = "" Or _
                Me.TxtBandera.Text.Trim = Nothing Then   'Modificacion

                Dim entidadclidfami As New SIM.EL.CLIDFAMI
                Dim eClidfami As New SIM.BL.cCLIDFAMI

                cls._ccoduni = eClidfami.ObtenercCoduni(Me.TxtComodin.Text.Trim)

                cls._llBandera = True

            Else                                 'Nuevo
                cls._ccoduni = Me.TxtBandera.Text.Trim
                cls._llBandera = False
            End If


            centinela = cls.ActualizaClidFami()

            If Me.TxtBandera.Text.Trim = "" Then
                Me.FuentesFamiliares(Me.TxtComodin.Text.Trim)
            End If

            Me.FuentesFamiliares(Me.TxtComodin.Text)

            Dim clsppal As New class1
            clsppal.Auditoria(Session("gccodusu"), Session("gdfecsis"), "GrF", 3)

            If centinela = 0 Then 'Genero Error
                Exit Sub
            End If

            Me.Deshabilita()
            Me.btgrabar.Enabled = False
            Me.bteliminar.Enabled = False
            Me.TotalizaIngreso()
            Me.TotalizaEgreso()
            Me.TxtBandera.Text = " "

        Catch ex As Exception

        End Try


    End Sub

    Protected Sub btini_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btini.Click
        Me.btnuevo.Enabled = True
        Me.Limpieza()
        Me.Deshabilita()
        Me.btgrabar.Enabled = False
        Me.bteliminar.Enabled = False

    End Sub

    Protected Sub bteliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bteliminar.Click
        Dim cls As New SIM.BL.ClsFuentes
        Dim centinela As Integer

        If Me.txtdFecha.Text.Trim = "" Then
            Exit Sub
        End If

        cls._ccodcli = Me.TxtComodin.Text.Trim
        cls._ccoduni = Me.TxtBandera.Text.Trim


        centinela = cls.ElminaClidFami()



        Me.FuentesFamiliares(Me.TxtComodin.Text)

        If centinela = 0 Then 'Genero Erro
            Exit Sub
        End If

        Me.Deshabilita()
        Me.btgrabar.Enabled = False
        Me.bteliminar.Enabled = False
        Me.TxtBandera.Text = " "

    End Sub

   
  
    Protected Sub btncalcular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        calculo()
    End Sub
    Private Sub calculo()
        Try
            TxtTIngr.Text = Double.Parse(txtIngrCony.Text)
            TxtTEgr.Text = Math.Round(Double.Parse(Txtviv.Text) + Double.Parse(TxtAlim.Text) + Double.Parse(TxtTel.Text) + Double.Parse(TxtTrans.Text) + Double.Parse(TxtEdu.Text) + Double.Parse(TxtSalud.Text) + Double.Parse(TxtVest.Text) + Double.Parse(txtPers.Text), 2)
        Catch ex As Exception

        End Try
    End Sub

   
End Class


