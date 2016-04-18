<Serializable()> Public Class listatabtbco
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtbco )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtbco)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtbco
        Get
            Return CType((List(index)), tabtbco)
        End Get
        Set(ByVal Value As tabtbco)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtbco) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtbco = CType(List(i), tabtbco)
            If s.ccodbco = value.ccodbco Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodbco As String) As tabtbco
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtbco = CType(List(i), tabtbco)
            If s.ccodbco = ccodbco Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtbcoEnumerator
        Return New tabtbcoEnumerator(Me)
    End Function

    Public Class tabtbcoEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtbco)
            Me.Local = Mappings
            Me.Base = Local.GetEnumerator()
        End Sub

        ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Return Base.Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Return Base.MoveNext()
        End Function

        Sub Reset() Implements IEnumerator.Reset
            Base.Reset()
        End Sub
    End Class
End Class
