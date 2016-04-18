

Partial Class WbCreditos
    Inherits ucWBase

    Private _URLCuenta As String


#Region " Propiedades "
    Public Property RCuenta() As String
        Get
            Return _URLCuenta
        End Get
        Set(ByVal Value As String)
            _URLCuenta = Value
        End Set
    End Property

#End Region


#Region " Metodos "
    Public Sub CargarPorCliente()


    End Sub
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub WbFind1_Seleccionado(ByVal codigoCliente As String) Handles WbFind1.Seleccionado
        wbcreditosclientes1.CargarCreditos(codigoCliente)
    End Sub
End Class


