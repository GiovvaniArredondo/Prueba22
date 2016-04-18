<Serializable()> Public Class listaahompro2
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahompro2 )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahompro2)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahompro2
        Get
            Return CType((List(index)), ahompro2)
        End Get
        Set(ByVal Value As ahompro2)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahompro2) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahompro2 = CType(List(i), ahompro2)
            If s.dultpro = value.dultpro Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal dultpro As DateTime) As ahompro2
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahompro2 = CType(List(i), ahompro2)
            If s.dultpro = dultpro Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahompro2Enumerator
        Return New ahompro2Enumerator(Me)
    End Function

    Public Class ahompro2Enumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahompro2)
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
