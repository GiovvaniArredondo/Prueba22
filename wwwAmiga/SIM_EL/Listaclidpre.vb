<Serializable()> Public Class listaclidpre
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaclidpre )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As clidpre)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As clidpre
        Get
            Return CType((List(index)), clidpre)
        End Get
        Set(ByVal Value As clidpre)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As clidpre) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidpre = CType(List(i), clidpre)
            If s.ccodcli = value.ccodcli Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String) As clidpre
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidpre = CType(List(i), clidpre)
            If s.ccodcli = ccodcli Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As clidpreEnumerator
        Return New clidpreEnumerator(Me)
    End Function

    Public Class clidpreEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaclidpre)
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
