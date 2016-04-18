<Serializable()> Public Class listaclidfin
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaclidfin )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As clidfin)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As clidfin
        Get
            Return CType((List(index)), clidfin)
        End Get
        Set(ByVal Value As clidfin)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As clidfin) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidfin = CType(List(i), clidfin)
            If s.ccodcli = value.ccodcli _
            And s.ctiprel = value.ctiprel _
            And s.ccodfue = value.ccodfue Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String, _
        ByVal ctiprel As String, _
        ByVal ccodfue As String) As clidfin
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clidfin = CType(List(i), clidfin)
            If s.ccodcli = ccodcli _
            And s.ctiprel = ctiprel _
            And s.ccodfue = ccodfue Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As clidfinEnumerator
        Return New clidfinEnumerator(Me)
    End Function

    Public Class clidfinEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaclidfin)
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
