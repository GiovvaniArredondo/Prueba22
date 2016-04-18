<Serializable()> Public Class listanotas
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listanotas )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As notas)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As notas
        Get
            Return CType((List(index)), notas)
        End Get
        Set(ByVal Value As notas)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As notas) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As notas = CType(List(i), notas)
            If s.ccodcta = value.ccodcta _
            And s.fecha = value.fecha Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String, _
        ByVal fecha As DateTime) As notas
        Dim i As Integer = 0
        While i < List.Count
            Dim s As notas = CType(List(i), notas)
            If s.ccodcta = ccodcta _
            And s.fecha = fecha Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As notasEnumerator
        Return New notasEnumerator(Me)
    End Function

    Public Class notasEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listanotas)
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
