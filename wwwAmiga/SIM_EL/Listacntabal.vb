<Serializable()> Public Class listacntabal
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacntabal )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cntabal)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cntabal
        Get
            Return CType((List(index)), cntabal)
        End Get
        Set(ByVal Value As cntabal)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cntabal) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntabal = CType(List(i), cntabal)
            If s.cfecmes = value.cfecmes Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function
    Public Function buscarporid(ByVal cfecmes As String) As cntabal
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntabal = CType(List(i), cntabal)
            If s.cfecmes = cfecmes Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cntabalEnumerator
        Return New cntabalEnumerator(Me)
    End Function

    Public Class cntabalEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacntabal)
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
