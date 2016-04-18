

Partial Class WUsRefCli
    Inherits ucWBase

#Region " Variables "
    Private clsCli As New SIM.BL.ClsFindCli
    Private _URLCodigo As String
    Private _ClienteSeleccionado As String
    Public Event Refinanciamiento(ByVal codigoCliente As String)
#End Region

#Region " Propiedades "
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

    Public Property URLCodigo() As String
        Get
            Return _URLCodigo
        End Get
        Set(ByVal Value As String)
            _URLCodigo = Value
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'Introducir aquí el código de usuario para inicializar la página
    End Sub


    Private Sub btnFind_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.ServerClick
        Dim i As Integer
        Dim ds As New DataSet

        ds = clsCli.BuscaCreditoActivo(Me.TxtNombre.Text.Trim, Session("gnNivel"), Session("gcCodOfi"))

        i = ds.Tables(0).Rows.Count()

        If i >= 1 Then
            'Me.dgClientes.DataSource = ds.Tables(0)
            'Me.dgClientes.DataBind()
            Me.Grid_Ref.DataSource = ds.Tables(0)
            Me.Grid_Ref.DataBind()
        Else
            Response.Write("<script language='javascript'>alert('EL Cliente no Existe')</script>")
        End If
    End Sub

    Protected Sub Grid_Ref_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Ref.SelectedIndexChanged
        ClienteSeleccionado = Grid_Ref.SelectedRow.Cells(1).Text.ToString
        RaiseEvent Refinanciamiento(ClienteSeleccionado)
    End Sub
End Class


