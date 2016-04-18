<Serializable()> Public Class listacredchq
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacredchq )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As credchq)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As credchq
        Get
            Return CType((List(index)), credchq)
        End Get
        Set(ByVal Value As credchq)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As credchq) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credchq = CType(List(i), credchq)
            If s.ccodcta = value.ccodcta Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String) As credchq
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credchq = CType(List(i), credchq)
            If s.ccodcta = ccodcta Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As credchqEnumerator
        Return New credchqEnumerator(Me)
    End Function

    Public Class credchqEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacredchq)
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
