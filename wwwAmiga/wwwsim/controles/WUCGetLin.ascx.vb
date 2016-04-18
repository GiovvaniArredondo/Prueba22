

Partial Class WUCGetLin
    Inherits ucWBase

    Private lnparametro1_R As String
    Private lnparametro2_R As String
    Private lnparametro3_R As String
    Private lnparametro4_R As String
    Private lnparametro5_R As String
    Private lnparametro6_R As String
    Private ds As New System.Data.DataSet
    Private lbsim As New SIM.bl.ClsMantenimiento
    Private lbsim1 As New SIM.bl.class1
    Private Transacc As String
    Private _URLCodigo As String
    Private _LineaSeleccionada As String
    Public Event Seleccionado(ByVal codigoLinea As String)

    Public Property LineaSeleccionada() As String
        Get
            Return _LineaSeleccionada
        End Get
        Set(ByVal Value As String)
            _LineaSeleccionada = Value
            If Session("LineaSeleccionada") Is Nothing Then
                Session.Add("LineaSeleccionada", Value)
            Else
                'ViewState("LineaSeleccionada") = Value
                Session.Add("LineaSeleccionada", Value)
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
#Region "Metodos"
    Private Sub Cargardatos()
        lnparametro1_R = "cNroLin, cCodlin, cdeslin,"
        lnparametro4_R = "Cretlin"
        lnparametro5_R = "S"


        lnparametro6_R = " "

        Transacc = lbsim.Transac(lnparametro1_R, " ", " ", lnparametro4_R, lnparametro5_R, lnparametro6_R)

        ds = lbsim.ResulSelect(Transacc)

        Me.dgLinea.DataSource = ds.Tables("Resultado")
        Me.dgLinea.DataBind()
        ds.Tables.Clear()
    End Sub

#End Region
    Private Sub DtGriduser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("WbGetCli.aspx?id=0")
    End Sub
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Cargardatos()
        End If
        Me._LineaSeleccionada = Me.ViewState("LineaSeleccionada")
    End Sub

    Private Sub dgLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LineaSeleccionada = CType(Me.dglinea.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent Seleccionado(LineaSeleccionada)
    End Sub


    Private Sub btnElegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub dglinea_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles dglinea.ItemCommand
        LineaSeleccionada = CType(e.Item.FindControl("Hyperlink1"), HyperLink).Text
        'CType(Me.dglinea.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        '        Session.Add("Linea", LineaSeleccionada)
        RaiseEvent Seleccionado(LineaSeleccionada)
        Response.Redirect("WbSugInd.aspx")
    End Sub
End Class


