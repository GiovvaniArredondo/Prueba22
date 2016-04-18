

Partial Class WbCreditosClientes
    Inherits ucWBase

    Private _URLCuenta As String
    Private _CreditoSeleccionado As String
    'Public Event Seleccionado(ByVal codigoCredito As String)



#Region " Propiedades "
    Public Property URLCuenta() As String
        Get
            Return _URLCuenta
        End Get
        Set(ByVal Value As String)
            _URLCuenta = Value
        End Set
    End Property

    Public Property CreditoSeleccionado() As String
        Get
            Return _CreditoSeleccionado
        End Get
        Set(ByVal Value As String)
            _CreditoSeleccionado = Value
            If ViewState("CreditoSeleccionado") Is Nothing Then
                ViewState.Add("CreditoSeleccionado", Value)
            Else
                ViewState("CreditoSeleccionado") = Value
            End If
        End Set
    End Property
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        'Me._CreditoSeleccionado = Me.ViewState("CreditoSeleccionado")

    End Sub

    Public Sub CargarCreditos(ByVal codigoCliente As String)
        Dim nCanti As Integer
        Dim lnparametro1_R As String
        Dim lnparametro2_R As String
        Dim lnparametro3_R As String
        Dim lnparametro4_R As String
        Dim lnparametro5_R As String
        Dim lnparametro6_R As String
        Dim lbsim As New SIM.BL.ClsMantenimiento
        Dim lbsim1 As New SIM.bl.class1
        Dim Transacc As String
        Dim ds As DataSet

        lnparametro1_R = "ccodcta as Cuenta,dfecvig,ncapdes,cestado,"
        lnparametro4_R = "Cremcre"
        lnparametro5_R = "S"
        lnparametro6_R = "where ccodcli =" & "'" & codigoCliente & "'"

        Transacc = lbsim.Transac(lnparametro1_R, " ", " ", lnparametro4_R, lnparametro5_R, lnparametro6_R)
        ds = lbsim.ResulSelect(Transacc)

        Me.dgCreditosCLiente.DataSource = ds.Tables("Resultado")
        Me.dgCreditosCLiente.DataBind()

    End Sub



    'Private Sub dgClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCreditosCLiente.SelectedIndexChanged
    '    'RaiseEvent Seleccionado(CType(Me.dgClientes.SelectedItem.DataItem.DataItem, DataRowView).Row.ItemArray(0).ToString())
    '    CreditoSeleccionado = CType(Me.dgCreditosCLiente.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
    '    RaiseEvent Seleccionado(CreditoSeleccionado)
    'End Sub



    Private Sub dgCreditosCLiente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCreditosCLiente.SelectedIndexChanged

    End Sub
End Class


