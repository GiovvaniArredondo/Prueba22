<Serializable()> Public Class listaahomlib
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahomlib )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahomlib)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahomlib
        Get
            Return CType((List(index)), ahomlib)
        End Get
        Set(ByVal Value As ahomlib)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahomlib) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomlib = CType(List(i), ahomlib)
            If s.ccodaho = value.ccodaho _
            And s.nlibreta = value.nlibreta Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodaho As String, _
        ByVal nlibreta As Decimal) As ahomlib
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomlib = CType(List(i), ahomlib)
            If s.ccodaho = ccodaho _
            And s.nlibreta = nlibreta Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahomlibEnumerator
        Return New ahomlibEnumerator(Me)
    End Function

    Public Class ahomlibEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahomlib)
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
