<Serializable()> Public Class listactbdchq
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listactbdchq )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ctbdchq)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ctbdchq
        Get
            Return CType((List(index)), ctbdchq)
        End Get
        Set(ByVal Value As ctbdchq)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ctbdchq) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ctbdchq = CType(List(i), ctbdchq)
            If s.cnumcom = value.cnumcom Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cnumcom As String) As ctbdchq
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ctbdchq = CType(List(i), ctbdchq)
            If s.cnumcom = cnumcom Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ctbdchqEnumerator
        Return New ctbdchqEnumerator(Me)
    End Function

    Public Class ctbdchqEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listactbdchq)
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
