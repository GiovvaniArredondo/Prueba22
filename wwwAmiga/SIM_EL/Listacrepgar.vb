<Serializable()> Public Class listacrepgar
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacrepgar )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As crepgar)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As crepgar
        Get
            Return CType((List(index)), crepgar)
        End Get
        Set(ByVal Value As crepgar)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As crepgar) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As crepgar = CType(List(i), crepgar)
            If s.ccodcta = value.ccodcta _
            And s.ccodcli = value.ccodcli _
            And s.ccodgar = value.ccodgar Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String, _
        ByVal ccodcli As String, _
        ByVal ccodgar As String) As crepgar
        Dim i As Integer = 0
        While i < List.Count
            Dim s As crepgar = CType(List(i), crepgar)
            If s.ccodcta = ccodcta _
            And s.ccodcli = ccodcli _
            And s.ccodgar = ccodgar Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As crepgarEnumerator
        Return New crepgarEnumerator(Me)
    End Function

    Public Class crepgarEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacrepgar)
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
