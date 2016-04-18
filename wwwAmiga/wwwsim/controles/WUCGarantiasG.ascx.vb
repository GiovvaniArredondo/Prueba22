

Partial Class WUCGarantiasG
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
    'Ejecuta raise Eevent en caso de tener cliente con falta de garantias 
    'y Mantiene en Tab trips
    Public Event cambiotabtrips(ByVal evento As String)
    '--Fin
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
            'Carga datos del grid
        End If
    End Sub
    '******* 20 - 07 - 2015
    'clase que refresca el Grid
    Public Sub CargarPorCliente2(ByVal caputurado As String)
        'recarga datos al inicializar
        'la varibale de cuenta no hace anda mas que rediriguir el envio al evento y asi ejecutarse el cargado de datos
        Me.TextBox3.Text = caputurado
        CargarDatos()
    End Sub
    Private Sub CargarDatos()
        vpcCodCli = Me.TextBox3.text   '"001000000001"      'Session("pcCodcli") 'entidadg.ccodcli
        'Me.txtcCodcli.Text = vpcCodCli

        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar
        Dim ds As New DataSet
        Dim ncanti As Integer
        'llenado de Grid Nuevo
        Dim ds_ As New DataSet

        ds_ = eClimgar.Proce_LlenadoGrid(vpcCodCli)


        ds = eClimgar.ObtenerDataSetEspcGrupal(vpcCodCli)
        ncanti = ds.Tables(0).Rows.Count()
        If ncanti = 0 Then  'En caso que no devuelva nada se sale
            'Exit Sub
            'Buscar si ya esta en la crepgar
            ds = eClimgar.ObtenerDataSetEspcGrupal2(vpcCodCli)
            If ds.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            Dim fila As DataRow
            Dim nelem As Integer
            Dim lnDisponible As Double = 0
            Dim lnDispo As Double = 0
            For Each fila In ds.Tables(0).Rows
                ' fila("nmongra") = Math.Round(IIf(IsDBNull(fila("nmontas")), 0, fila("nmontas")), 2) '* Session("gnCobertura") / 100
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
        Else
            Dim fila As DataRow
            Dim nelem As Integer
            Dim lnDisponible As Double = 0
            Dim lnDispo As Double = 0
            For Each fila In ds.Tables(0).Rows

                If IsDBNull(fila("Disponible")) Then
                    lnDispo = 0
                Else
                    lnDispo = fila("Disponible")
                End If

                lnDisponible = lnDisponible + lnDispo
                nelem = nelem + 1
            Next
            Me.txtDisponible.Text = lnDisponible

        End If
        'Parse para columna de faltante
        Dim Faltante As Double
        Dim montoSol As Decimal = 0
        Dim saldoLiquida As Decimal
        Dim NomCliente As String
        Dim exCliente As String
        Dim idcliente As Integer = 0
        Dim MontSol As Double
        Dim ComS As Double
        Dim porce As Decimal = 0
        Dim total As Double = 0

        'Agregados
        ds_.Tables(0).Columns.Add("Diferencia")
        ds_.Tables(0).Columns.Add("MontoSugerido")
        For Each fila In ds_.Tables(0).Rows
            porce = fila("porcentaje_Garantias")
            ComS = fila("nmonpor")
            NomCliente = fila("cnomcli")
            montoSol = fila("MontoSol") 'cantidad segun el porcentaje 
            saldoLiquida = fila("nsaldnind")
            porce = porce / 100
            MontSol = ValidaConFormula(ComS, montoSol)
            'MontSol / porce
            total = (MontSol * porce)

            Faltante = saldoLiquida - total

            If saldoLiquida < total Then
                exCliente = exCliente & "Cliente: " & NomCliente & "  Monto Faltante: " & FormatNumber(Faltante, 2) & "\n"
                idcliente = idcliente + 1
            End If

            fila("Diferencia") = FormatNumber(Faltante, 2)
            fila("MontoSugerido") = FormatNumber(total, 2)

        Next
        'Diferencia A los cliente
        If idcliente > 0 Then

            codigoJs = "<script language='javascript'>alert('ATENCION\n\n Revisar Garantias: \n\n" & exCliente & "\n\n  " & _
                     "Advertencia SIM.NET ');</script>"
            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)
            'Ejecuta Evento Si hay clientes con garantias Pendientes
            RaiseEvent cambiotabtrips(3)

        End If
        Me.dgGarantias.DataSource = ds_
        Me.dgGarantias.DataBind()
        ''Valida Grid Seleccionar
        Dim Dif As Double
        Dim icon As Integer = 0 'contador de filar || enre columns de ds
        Dim e As Object
        Dim NumeroFilas As Integer
        For Each row As DataRow In ds_.Tables(0).Rows
            'NumeroFilas = ds.Tables(0).Rows(icon)("Nro")
            Dif = ds_.Tables(0).Rows(icon)("Diferencia")
            NumeroFilas = icon
            If Dif >= 0 Then

                Me.dgGarantias.Items(NumeroFilas).Enabled = False
                'Me.dgGarantias.Items(NumeroFilas).BackColor = Color.Yellow
                'desabilita el boton 
            Else
                Me.dgGarantias.Items(NumeroFilas).Enabled = True
                'Me.dgGarantias.ItemStyle.BackColor = Color.Yellow
                Me.dgGarantias.Items(NumeroFilas).BackColor = Color.Yellow
            End If

            icon += 1
        Next

        'Funcion de revision de seguros

        'buscarSeguros(ds_)



    End Sub

    Private Function ValidaConFormula(ByVal com As Decimal, ByVal nmontSug As Decimal) As Decimal
        Dim resta As Decimal
        resta = (1 + (com / 100))
        nmontSug = nmontSug / resta
        Return nmontSug
    End Function
    'Public Sub CargarPorCliente(ByVal codigoCliente As String)
    '    'Me.txtccodcta.Text = codigoCliente.Trim
    '    'Dim entidad3 As New SIM.EL.creditos
    '    'Dim ecreditos As New SIM.BL.ccreditos
    '    'entidad3.ccodcta = codigoCliente.Trim
    '    'ecreditos.Obtenercreditos(entidad3)
    '    'Me.txtcCodcli.Text = codigoCliente 'entidad3.ccodcli
    '    CargarDatos()
    'End Sub
    '--Buscar seguros y validar
    'Public Sub buscarSeguros(ByVal ds_ As DataSet)
    '    Dim monto_prodcuto As Integer
    '    monto_prodcuto = buscaSeguroProducto(ds_)


    '    Dim eClimgar As New SIM.BL.cClimgar
    '    Dim buscarCreditos As String
    '    Dim obtieneSeguro As Integer = 0

    '    For Each rows As DataRow In ds_.Tables(0).Rows

    '        buscarCreditos = eClimgar.obtnerCreditos(rows("cnudotr"))

    '        obtieneSeguro = eClimgar.obtenerSeguros(buscarCreditos)

    '        If obtieneSeguro = monto_prodcuto Then


    '        Else

    '            codigoJs = "<script language='javascript'>alert('ATENCION\n\n Revisar Seguros " & _
    '                     "Advertencia SIM.NET ');</script>"
    '            ScriptManager.RegisterStartupScript(Me.Page(), Me.GetType(), "Ventana_Aviso", codigoJs, False)

    '            RaiseEvent cambiotabtrips(3)
    '        End If

    '    Next



    'End Sub

    'Public Function buscaSeguroProducto(ByVal ds As DataSet) As Integer
    '    Dim obtiene_cnrolin As String
    '    Dim obtieneseguro As Integer
    '    Dim eClimgar As New SIM.BL.cClimgar

    '    For Each rows As DataRow In ds.Tables(0).Rows

    '        obtiene_cnrolin = eClimgar.obtenerSeguro(rows("cnudotr"))
    '    Next

    '    obtieneseguro = eClimgar.Buscarmonto(obtiene_cnrolin)




    '    Return obtieneseguro
    'End Function


    Public Function BuscaGarantia(ByVal cCodigo As String, ByVal cCodgar As String) As DataSet
        Dim ds As New DataSet

        'Nombre del Cliente
        Dim entidadClimgar As New SIM.EL.climgar
        Dim eClimgar As New SIM.BL.cClimgar

        ds = eClimgar.ObtenerDataSetporcCodgarGrupal(cCodigo, cCodgar)

        Return ds
    End Function


    ' Public Sub CargarPorCliente1(ByVal codigoCliente As String)

    '    CargarDatos()
    ' End Sub

    Private Sub dgGarantias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGarantias.SelectedIndexChanged
        Dim dsg As New DataSet

        CodigoSeleccionado = dgGarantias.SelectedItem.Cells(2).Text.ToString()
        Me.TextBox2.Text = Me.CodigoSeleccionado
        'Envia datos a WBGARANT
        Dim valor = TextBox2.Text
        Response.Redirect("WbGarant.aspx?Valor=" + valor)


        'Ubi

        '-----------------------------------------------------
        'Trae toda la informacion de la Garantia
        '-----------------------------------------------------
        'dsg = Me.BuscaGarantia(Left(TextBox2.Text.Trim, 12), Right(TextBox2.Text.Trim, 3))

        'Dim ncanti As Integer

        'ncanti = dsg.Tables(0).Rows.Count()

        'If ncanti = 0 Then  'En caso que no devuelva nada se sale
        '    Exit Sub        'Hubo un error Depurar
        'End If
        'Me.txtGravamen.Text = dsg.Tables(0).Rows(0)("nMongra")
        'Me.txtDescri.Text = dsg.Tables(0).Rows(0)("Descripcion")
        'Me.txttasacion.Text = IIf(IsDBNull(dsg.Tables(0).Rows(0)("nmontas")), 0, dsg.Tables(0).Rows(0)("nmontas"))
        ''Me.txtGravamen.Text = IIf(IsDBNull(dsg.Tables(0).Rows(0)("nmongra")), 0, dsg.Tables(0).Rows(0)("nmongra"))

        'Me.txtcmoneda.Text = dsg.Tables(0).Rows(0)("cmoneda")
        'Me.txtctipgar.Text = dsg.Tables(0).Rows(0)("ctipgar")
        'txtccodcta.Text = dsg.Tables(0).Rows(0)("ccodcta")

        'Dim lncobertura As Double = 0
        'lncobertura = Math.Round(Double.Parse(Me.txttasacion.Text.Trim), 2) '* Session("gnCobertura") / 100

        'txtGravamen.Text = lncobertura

    End Sub

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

        If Me.txtGravamen.Text.Trim = "" Then
            Me.txtGravamen.Text = 0
        End If
        If Me.txttasacion.Text.Trim = "" Then
            Me.txttasacion.Text = 0
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
        entidadCrepgar.ccodcli = Left(Me.TextBox2.Text.Trim, 12)
        entidadCrepgar.ccodgar = Right(Me.TextBox2.Text.Trim, 3)
        entidadCrepgar.ccodcta = Me.txtccodcta.Text.Trim
        lnreturn = eCrepgar.ObtenerCrepgar(entidadCrepgar)


        cls._ccodgar = Right(Me.TextBox2.Text.Trim, 3)
        cls._ccodcli = Left(Me.TextBox2.Text.Trim, 12)
        cls._nmongra = Double.Parse(Me.txtGravamen.Text.Trim)



        Dim entidadcrepgarg As New SIM.EL.crepgar
        Dim eCrepgarg As New SIM.BL.cCrepgar
        entidadcrepgarg.ccodcta = Me.txtccodcta.Text.Trim
        entidadcrepgarg.ccodcli = Left(Me.TextBox2.Text.Trim, 12)
        entidadcrepgarg.ccodgar = Right(Me.TextBox2.Text.Trim, 3)
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
            lnGrav = clase.Gravamen(Me.txtccodcta.Text.Trim, Left(Me.TextBox2.Text.Trim, 12))
            Session("nGrav") = lnGrav

            Response.Write("<script language='javascript'>alert('Gravamen Guardado')</script>")
        Else                    'Genero Error
            Me.Label4.Text = "A ocurrido un error, contactar al proveedor"
            Me.Label4.Visible = True
            Exit Sub
        End If

    End Sub
End Class


