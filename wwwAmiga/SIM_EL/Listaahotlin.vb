<Serializable()> Public Class listaahotlin
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahotlin )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahotlin)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahotlin
        Get
            Return CType((List(index)), ahotlin)
        End Get
        Set(ByVal Value As ahotlin)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahotlin) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahotlin = CType(List(i), ahotlin)
            If s.cnrolin = value.cnrolin Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cnrolin As String) As ahotlin
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahotlin = CType(List(i), ahotlin)
            If s.cnrolin = cnrolin Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahotlinEnumerator
        Return New ahotlinEnumerator(Me)
    End Function

    Public Class ahotlinEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahotlin)
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
