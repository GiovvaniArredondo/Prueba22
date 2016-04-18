<Serializable()> Public Class listacntamov
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacntamov )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cntamov)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cntamov
        Get
            Return CType((List(index)), cntamov)
        End Get
        Set(ByVal Value As cntamov)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cntamov) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntamov = CType(List(i), cntamov)
            If s.cnumcom = value.cnumcom _
            And s.cnumlin = value.cnumlin Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cnumcom As String, _
        ByVal cnumlin As Decimal) As cntamov
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntamov = CType(List(i), cntamov)
            If s.cnumcom = cnumcom _
            And s.cnumlin = cnumlin Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cntamovEnumerator
        Return New cntamovEnumerator(Me)
    End Function

    Public Class cntamovEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacntamov)
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
