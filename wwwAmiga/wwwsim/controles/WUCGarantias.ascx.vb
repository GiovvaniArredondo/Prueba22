

Partial Class WUCGarantias
    Inherits ucWBase
    Dim vpcCodCli As String
    Private clase As New SIM.bl.class1

#Region " Variables "
    Private _URLCodigo As String
    Private _CodigoSeleccionado As String
    Private codigoJs As String
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

    Public Property CodigoSeleccionado() As String
        Get
            Return _CodigoSeleccionado
        End Get
        Set(ByVal Value As String)
            _CodigoSeleccionado = Value
            If ViewState("ClienteSeleccionado") Is Nothing Then
                ViewState.Add("CodigoSeleccionado", Value)
            Else
                ViewState("CodigoSeleccionado") = Value
            End If
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            InitVar()
            Me.CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()
        vpcCodCli = Me.txtcCodcli.Text.Trim    '"001000000001"      'Session("pcCodcli") 'entidadg.ccodcli
        'Me.txtcCodcli.Text = vpcCodCli

        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar
        Dim ds As New DataSet
        Dim ncanti As Integer

        ds = eClimgar.ObtenerDataSetEspc1(Me.txtcCodcli.Text.Trim)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            'Exit Sub
            'Buscar si ya esta en la crepgar
            ds = eClimgar.ObtenerDataSetEspc12(Me.txtcCodcli.Text.Trim, Me.txtccodcta.Text.Trim)
            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

        End If

        Dim fila As DataRow
        Dim nelem As Integer
        Dim lnDisponible As Double = 0
        Dim lnDispo As Double = 0
        For Each fila In ds.Tables(0).Rows
            'fila("nmongra") = Math.Round(IIf(IsDBNull(fila("nmontas")), 0, fila("nmontas")), 2) '* Session("gnCobertura") / 100
            If IsDBNull(ds.Tables(0).Rows(nelem)("Disponible")) Then
                lnDispo = 0
            Else
                lnDispo = Math.Round(fila("nmontas"), 2) - fila("nmongra") 'ds.Tables(0).Rows(nelem)("Disponible") '* Session("gncobertura") / 100
            End If
            fila("disponible") = lnDispo

            lnDisponible = lnDisponible + lnDispo
            nelem = nelem + 1
        Next
        Me.txtDisponible.Text = lnDisponible
        Me.Grid_Garantias.DataSource = ds
        Me.Grid_Garantias.DataBind()

    End Sub
    Public Sub CargarPorCliente(ByVal codigoCliente As String)
        Me.txtccodcta.Text = codigoCliente.Trim
        Dim entidad3 As New SIM.EL.creditos
        Dim ecreditos As New SIM.BL.ccreditos
        entidad3.ccodcta = codigoCliente.Trim
        ecreditos.Obtenercreditos(entidad3)
        Me.txtcCodcli.Text = entidad3.ccodcli
        CargarDatos()
    End Sub
    Public Function BuscaGarantia(ByVal cCodigo As String, ByVal cCodgar As String) As DataSet
        Dim ds As New DataSet

        'Nombre del Cliente
        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar

        ds = eClimgar.ObtenerDataSetporcCodgar(cCodigo, cCodgar)

        Return ds
    End Function

    ' Public Sub CargarPorCliente1(ByVal codigoCliente As String)

    '    CargarDatos()
    ' End Sub


    Private Sub InitVar()
        Me.Label4.Text = ""
        Me.Label4.Visible = False
        Me.txtGravamen.Text = 0
        Me.txtDisponible.Text = 0
        Me.txtDescri.Text = ""
    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        Dim lcCodgar As String
        Dim cls As New SIM.BL.ClsGarant
        'Dim clase As New SIM.EL.crepgar
        Dim lncentinela As Integer
        Dim lncentinela1 As Integer
        '-----------------------------
        ' Validaciones
        '-----------------------------

        If Me.txtGravamen.Text.Trim = "" Or Me.txtGravamen.Text.Trim = Nothing Then
            Me.Label4.Text = "Corrija Gravamen"
            Me.Label4.Visible = True
            Exit Sub
        Else
            Me.Label4.Text = " "
            Me.Label4.Visible = False
        End If

        If Double.Parse(Me.txtGravamen.Text.Trim) > Double.Parse(Me.txttasacion.Text.Trim) Then
            Me.Label4.Text = "El monto de gravamen no puede ser mayor "
            Me.Label4.Visible = True
            Exit Sub
        Else
            Me.Label4.Text = " "
            Me.Label4.Visible = False
        End If



        '-------------------------------
        'Fin
        '-------------------------------
        Dim entidadCrepgar As New SIM.EL.crepgar
        Dim eCrepgar As New SIM.BL.cCrepgar
        Dim lnreturn As Integer
        entidadCrepgar.ccodcli = Me.txtcCodcli.Text.Trim
        entidadCrepgar.ccodgar = Me.TextBox2.Text.Trim
        entidadCrepgar.ccodcta = Me.txtccodcta.Text.Trim
        lnreturn = eCrepgar.ObtenerCrepgar(entidadCrepgar)


        cls._ccodgar = Me.TextBox2.Text.Trim
        cls._ccodcli = Me.txtcCodcli.Text.Trim
        cls._nmongra = Double.Parse(Me.txtGravamen.Text.Trim)



        Dim entidadcrepgarg As New SIM.El.crepgar
        Dim eCrepgarg As New SIM.BL.cCrepgar
        entidadcrepgarg.ccodcta = Me.txtccodcta.Text.Trim
        entidadcrepgarg.ccodcli = Me.txtcCodcli.Text.Trim
        entidadcrepgarg.ccodgar = Me.TextBox2.Text.Trim
        entidadcrepgarg.cmoneda = Me.txtcmoneda.Text.Trim
        entidadcrepgarg.nmongra = Double.Parse(Me.txtGravamen.Text.Trim)
        entidadcrepgarg.cestado = ""
        entidadcrepgarg.cnumins = ""
        entidadcrepgarg.dfecval = Session("gdfecsis")
        entidadcrepgarg.ccodusu = Session("gcCodusu")
        entidadcrepgarg.dfecmod = Today()
        entidadcrepgarg.cflag = ""
        entidadcrepgarg.ctipgar = Left(Me.txtctipgar.Text.Trim, 2)


        If lnreturn = 0 Then 'Inserta
            lncentinela1 = eCrepgarg.AgregarCrepgar(entidadcrepgarg)
        Else 'Actualiza
            lncentinela1 = eCrepgar.Actualizar1(entidadcrepgarg)
        End If
        If lncentinela1 = 1 Then 'Proceso Correcto

        Else                    'Genero Error
            Me.Label4.Text = "A ocurrido un error, contactar al proveedor"
            Me.Label4.Visible = True
            Exit Sub
        End If

        lncentinela = cls.GrabaGarantiaGravamen()

        If lncentinela = 1 Then 'Proceso Correcto
            InitVar()
            Me.CargarDatos()
            'Me.Label4.Text = "Proceso generado con exito"
            'Me.Label4.Visible = True
            Dim lnGrav As Double = 0
            lnGrav = clase.Gravamen(Me.txtccodcta.Text.Trim, Me.txtcCodcli.Text.Trim)
            Session("nGrav") = lnGrav

            '            Response.Write("<script language='javascript'>alert('Gravamen Guardado')</script>")
            codigoJs = "<script language='javascript'>alert('Gravamen Guardado, " & _
                                                    "Advertencia SIM.NET ')</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
        Else                    'Genero Error
            Me.Label4.Text = "A ocurrido un error, contactar al proveedor"
            Me.Label4.Visible = True
            Exit Sub
        End If

    End Sub

    Protected Sub Grid_Garantias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Garantias.SelectedIndexChanged
        Dim dsg As New DataSet
        '        CodigoSeleccionado = CType(Me.dgGarantias.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        CodigoSeleccionado = Grid_Garantias.SelectedRow.Cells(1).Text.ToString
        Me.TextBox2.Text = Me.CodigoSeleccionado

        '-----------------------------------------------------
        'Trae toda la informacion de la Garantia
        '-----------------------------------------------------
        dsg = Me.BuscaGarantia(Me.txtcCodcli.Text.Trim, Me.TextBox2.Text.Trim)

        Dim ncanti As Integer

        ncanti = dsg.Tables(0).Rows.Count()

        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub        'Hubo un error Depurar
        End If
        Me.txtGravamen.Text = dsg.Tables(0).Rows(0)("nMongra")
        Me.txtDescri.Text = dsg.Tables(0).Rows(0)("Descripcion")
        Me.txttasacion.Text = IIf(IsDBNull(dsg.Tables(0).Rows(0)("nmontas")), 0, dsg.Tables(0).Rows(0)("nmontas"))
        Me.txtcmoneda.Text = dsg.Tables(0).Rows(0)("cmoneda")
        Me.txtctipgar.Text = dsg.Tables(0).Rows(0)("ctipgar")

        Dim lncobertura As Double = 0
        lncobertura = Math.Round(Double.Parse(Me.txttasacion.Text.Trim), 2) '* Session("gnCobertura") 

        txtGravamen.Text = lncobertura

    End Sub
End Class


