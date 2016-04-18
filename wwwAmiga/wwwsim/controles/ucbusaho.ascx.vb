

Partial Class ucbusaho
    Inherits ucWBase

    Private Transacc As String
    Private _URLCodigo As String
    Private _lineaSeleccionado As String
    Public Event Seleccionado(ByVal codigoCliente As String)

    Public Property lineaSeleccionado() As String
        Get
            Return _lineaSeleccionado
        End Get
        Set(ByVal Value As String)
            _lineaSeleccionado = Value
            If ViewState("codaho") Is Nothing Then
                ViewState.Add("codaho", Value)
            Else
                ViewState("codaho") = Value
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
        If Not IsPostBack Then
            '  Me.Cargardatos()
        End If
        Me._lineaSeleccionado = Me.ViewState("codaho")
    End Sub

    'carga elementos necesarios para la linea
    Private Sub Cargardatos()
        Dim mControl As New cCretlin
        Dim mLista As New listacretlin
        Dim mEntidad As New cretlin
        mLista = mControl.ObtenerLista()
        Me.dgClientes.DataSource = mLista
        Me.dgClientes.DataBind()
        Me.txtcodigo1.Checked = False
        Me.txtnombre1.Checked = True
    End Sub

    Private Sub DtGriduser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("wblineas.aspx?id=0")
    End Sub

    Private Sub dgClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgClientes.SelectedIndexChanged
        '        RaiseEvent Seleccionado(CType(Me.dgClientes.SelectedItem.DataItem.DataItem, DataRowView).Row.ItemArray(0).ToString())
        lineaSeleccionado = CType(Me.dgClientes.SelectedItem.FindControl("Hyperlink1"), HyperLink).Text
        RaiseEvent Seleccionado(lineaSeleccionado)
    End Sub

    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("wblineas.aspx")
    End Sub

    Private Sub txtcodigo1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo1.CheckedChanged
        Me.txtcodigo1.Checked = True
        Me.txtnombre1.Checked = False

    End Sub

    Private Sub txtnombre1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre1.CheckedChanged
        Me.txtcodigo1.Checked = False
        Me.txtnombre1.Checked = True
    End Sub

    
    Private Sub Button1_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.ServerClick
        Dim mControl As New cAhomcta
        Dim ds As New DataSet
        Dim linea As String
        Dim i As Integer
        Dim lctipo As String
        Dim ltipbus As Boolean
        Dim filacre As DataRow
        If Me.txtcodigo1.Checked = True Then
            ltipbus = True
        Else
            ltipbus = False
        End If


        linea = Me.TxtNombre.Text.Trim
        ds = mControl.busquedactaahorro(linea, ltipbus)

        i = 0
        For Each filacre In ds.Tables(0).Rows
            lctipo = filacre("tipo")
            lctipo = Mid(lctipo, 7, 2)
            If lctipo = "02" Then
                ds.Tables(0).Rows(i)("tipo") = "Aho. vista"
            ElseIf lctipo = "01" Then
                ds.Tables(0).Rows(i)("tipo") = "Simultaneo"
            ElseIf lctipo = "06" Then
                ds.Tables(0).Rows(i)("tipo") = "Aportaciones"
            ElseIf lctipo = "04" Then
                ds.Tables(0).Rows(i)("tipo") = "Aho. Menores"
            Else
                ds.Tables(0).Rows(i)("tipo") = "Simultaneo"
            End If
            i = i + 1
        Next
        Me.dgClientes.DataSource = ds
        Me.dgClientes.DataBind()

    End Sub
End Class


