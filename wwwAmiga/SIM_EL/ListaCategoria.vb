<Serializable()> Public Class listaCategoria
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCategoria )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As Categoria)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As Categoria
        Get
            Return CType((List(index)), Categoria)
        End Get
        Set(ByVal Value As Categoria)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As Categoria) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As Categoria = CType(List(i), Categoria)
            If s.cCatego = value.cCatego Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cCatego As String) As Categoria
        Dim i As Integer = 0
        While i < List.Count
            Dim s As Categoria = CType(List(i), Categoria)
            If s.cCatego = cCatego Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CategoriaEnumerator
        Return New CategoriaEnumerator(Me)
    End Function

    Public Class CategoriaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCategoria)
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
