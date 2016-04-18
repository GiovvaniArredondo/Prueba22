<Serializable()> Public Class listaparent
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaparent )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As parent)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As parent
        Get
            Return CType((List(index)), parent)
        End Get
        Set(ByVal Value As parent)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As parent) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As parent = CType(List(i), parent)
            If s.cparent = value.cparent Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cparent As String) As parent
        Dim i As Integer = 0
        While i < List.Count
            Dim s As parent = CType(List(i), parent)
            If s.cparent = cparent Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As parentEnumerator
        Return New parentEnumerator(Me)
    End Function

    Public Class parentEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaparent)
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
