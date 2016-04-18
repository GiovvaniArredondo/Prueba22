<Serializable()> Public Class listatabtusu
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtusu )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtusu)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtusu
        Get
            Return CType((List(index)), tabtusu)
        End Get
        Set(ByVal Value As tabtusu)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtusu) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtusu = CType(List(i), tabtusu)
            If s.ccodusu = value.ccodusu Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodusu As String) As tabtusu
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtusu = CType(List(i), tabtusu)
            If s.ccodusu = ccodusu Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtusuEnumerator
        Return New tabtusuEnumerator(Me)
    End Function

    Public Class tabtusuEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtusu)
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
