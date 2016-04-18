<Serializable()> Public Class listaclidbal
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaclidbal )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As clidbal)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As clidbal
        Get
            Return CType((List(index)), clidbal)
        End Get
        Set(ByVal Value As clidbal)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As clidbal) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidbal = CType(List(i), clidbal)
            If s.ccodcli = value.ccodcli _
            And s.ccodfue = value.ccodfue _
            And s.devalua = value.devalua Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String, _
        ByVal ccodfue As String, _
        ByVal devalua As DateTime) As clidbal
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidbal = CType(List(i), clidbal)
            If s.ccodcli = ccodcli _
            And s.ccodfue = ccodfue _
            And s.devalua = devalua Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As clidbalEnumerator
        Return New clidbalEnumerator(Me)
    End Function

    Public Class clidbalEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaclidbal)
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
