<Serializable()> Public Class listatabtfer
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtfer )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtfer)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtfer
        Get
            Return CType((List(index)), tabtfer)
        End Get
        Set(ByVal Value As tabtfer)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtfer) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtfer = CType(List(i), tabtfer)
            If s.dferiad = value.dferiad Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal dferiad As DateTime) As tabtfer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtfer = CType(List(i), tabtfer)
            If s.dferiad = dferiad Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtferEnumerator
        Return New tabtferEnumerator(Me)
    End Function

    Public Class tabtferEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtfer)
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
