Public Class CbxUsuario_Comite
    Inherits System.Web.UI.WebControls.DropDownList
    Private _sError As Boolean
    Public Event ErrorEvent As EventHandler

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Private Sub RecuperarLista(ByVal idusuario As Integer)
        Dim miComponente As New cTabttab
        Dim ds As New DataSet

        ds = miComponente.Extrae_Comite_Usuario(idusuario)
        If ds.Tables(0).Rows.Count = 0 Then
            Return
        End If

        Me.DataTextField = "descripcion"
        Me.DataValueField = "codigo_nivel_aprobacion"
        Me.DataSource = ds.Tables(0)
        Me.DataBind()

    End Sub

    Public Sub Recuperar(ByVal idusuario As Integer)
        RecuperarLista(idusuario)
    End Sub

End Class
