<Serializable()> Public Class listatabtzon
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtzon )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtzon)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtzon
        Get
            Return CType((List(index)), tabtzon)
        End Get
        Set(ByVal Value As tabtzon)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtzon) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtzon = CType(List(i), tabtzon)
            If s.ccodzon = value.ccodzon Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodzon As String) As tabtzon
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtzon = CType(List(i), tabtzon)
            If s.ccodzon = ccodzon Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtzonEnumerator
        Return New tabtzonEnumerator(Me)
    End Function

    Public Class tabtzonEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtzon)
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
