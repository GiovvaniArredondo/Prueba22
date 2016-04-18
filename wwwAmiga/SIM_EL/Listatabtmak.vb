<Serializable()> Public Class listatabtmak
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtmak )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtmak)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtmak
        Get
            Return CType((List(index)), tabtmak)
        End Get
        Set(ByVal Value As tabtmak)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtmak) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtmak = CType(List(i), tabtmak)
            If s.ccodigo = value.ccodigo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodigo As String) As tabtmak
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtmak = CType(List(i), tabtmak)
            If s.ccodigo = ccodigo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtmakEnumerator
        Return New tabtmakEnumerator(Me)
    End Function

    Public Class tabtmakEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtmak)
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
