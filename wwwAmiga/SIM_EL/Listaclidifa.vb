<Serializable()> Public Class listaclidifa
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaclidifa )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As clidifa)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As clidifa
        Get
            Return CType((List(index)), clidifa)
        End Get
        Set(ByVal Value As clidifa)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As clidifa) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidifa = CType(List(i), clidifa)
            If s.ccodcli = value.ccodcli _
            And s.devalua = value.devalua Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String, _
        ByVal devalua As DateTime) As clidifa
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidifa = CType(List(i), clidifa)
            If s.ccodcli = ccodcli _
            And s.devalua = devalua Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As clidifaEnumerator
        Return New clidifaEnumerator(Me)
    End Function

    Public Class clidifaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaclidifa)
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
