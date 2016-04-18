


Partial Class cwRecSol
    Inherits ucWBase

    Private _URLCodigo As String
    Private _CausaSeleccionada As String
    Dim lcCodRec As String = ""
    Public Event Seleccionado(ByVal codigoCausa As String)

    Public Property CausaSeleccionada() As String
        Get
            Return _CausaSeleccionada
        End Get
        Set(ByVal Value As String)
            _CausaSeleccionada = Value
            If ViewState("CausaSeleccionada") Is Nothing Then
                ViewState.Add("CausaSeleccionada", Value)
            Else
                ViewState("CausaSeleccionada") = Value
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.CargarDatos()
        End If

        Session.Add(lcCodRec, lcCodRec.ToString)
        Me._CausaSeleccionada = Me.ViewState("CausaSeleccionada")
    End Sub
    Private Sub CargarDatos()
        Dim dsp As New DataSet
        Dim nElem As Integer
        'Me.txtcCodCta.Text = CodigoCredito
        Dim entidadtabttab As New SIM.EL.tabttab
        Dim etabttab As New SIM.BL.cTabttab
        entidadtabttab.ccodtab = "042"
        dsp = etabttab.ObtenerDataSetPorID("042", "1")
        nElem = dsp.Tables(0).Rows.Count()
        If nElem = 0 Then  'En caso que no devuelva nada se sale
            Exit Sub
        End If
        Me.dgCausas.DataSource = dsp.Tables(0)
        Me.dgCausas.DataBind()
    End Sub

    Private Sub dgCausas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCausas.SelectedIndexChanged
        CausaSeleccionada = CType(Me.dgCausas.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text.Trim
        RaiseEvent Seleccionado(CausaSeleccionada)
        lcCodRec = CausaSeleccionada
        Response.Write("<script language='javascript'>alert('Crédito Rechazado')</script>")
        Response.Redirect("WbSugInd.aspx?id=0")
    End Sub

End Class


