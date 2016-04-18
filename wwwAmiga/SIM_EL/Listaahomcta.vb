<Serializable()> Public Class listaahomcta
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahomcta )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahomcta)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahomcta
        Get
            Return CType((List(index)), ahomcta)
        End Get
        Set(ByVal Value As ahomcta)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahomcta) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomcta = CType(List(i), ahomcta)
            If s.ccodaho = value.ccodaho Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodaho As String) As ahomcta
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomcta = CType(List(i), ahomcta)
            If s.ccodaho = ccodaho Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahomctaEnumerator
        Return New ahomctaEnumerator(Me)
    End Function

    Public Class ahomctaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahomcta)
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
