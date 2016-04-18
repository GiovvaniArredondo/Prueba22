<Serializable()> Public Class listaahomtrs
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahomtrs )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahomtrs)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahomtrs
        Get
            Return CType((List(index)), ahomtrs)
        End Get
        Set(ByVal Value As ahomtrs)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahomtrs) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomtrs = CType(List(i), ahomtrs)
            If s.ccodtrs = value.ccodtrs Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodtrs As String) As ahomtrs
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomtrs = CType(List(i), ahomtrs)
            If s.ccodtrs = ccodtrs Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahomtrsEnumerator
        Return New ahomtrsEnumerator(Me)
    End Function

    Public Class ahomtrsEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahomtrs)
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
