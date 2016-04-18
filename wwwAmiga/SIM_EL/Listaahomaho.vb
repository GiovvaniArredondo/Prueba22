<Serializable()> Public Class listaahomaho
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahomaho )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahomaho)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahomaho
        Get
            Return CType((List(index)), ahomaho)
        End Get
        Set(ByVal Value As ahomaho)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahomaho) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomaho = CType(List(i), ahomaho)
            If s.ccodaho = value.ccodaho _
            And s.dfeccap = value.dfeccap Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodaho As String, _
        ByVal dfeccap As DateTime) As ahomaho
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomaho = CType(List(i), ahomaho)
            If s.ccodaho = ccodaho _
            And s.dfeccap = dfeccap Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahomahoEnumerator
        Return New ahomahoEnumerator(Me)
    End Function

    Public Class ahomahoEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahomaho)
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
