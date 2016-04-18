<Serializable()> Public Class listatabtciu
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtciu )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtciu)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtciu
        Get
            Return CType((List(index)), tabtciu)
        End Get
        Set(ByVal Value As tabtciu)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtciu) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtciu = CType(List(i), tabtciu)
            If s.ccodigo = value.ccodigo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodigo As String) As tabtciu
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtciu = CType(List(i), tabtciu)
            If s.ccodigo = ccodigo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtciuEnumerator
        Return New tabtciuEnumerator(Me)
    End Function

    Public Class tabtciuEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtciu)
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
