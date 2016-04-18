<Serializable()> Public Class listaCLIDFAMI
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaCLIDFAMI )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As CLIDFAMI)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As CLIDFAMI
        Get
            Return CType((List(index)), CLIDFAMI)
        End Get
        Set(ByVal Value As CLIDFAMI)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As CLIDFAMI) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CLIDFAMI = CType(List(i), CLIDFAMI)
            If s.ccodcli = value.ccodcli _
            And s.dEvalua = value.dEvalua Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String, _
        ByVal dEvalua As DateTime) As CLIDFAMI
        Dim i As Integer = 0
        While i < List.Count
            Dim s As CLIDFAMI = CType(List(i), CLIDFAMI)
            If s.ccodcli = ccodcli _
            And s.dEvalua = dEvalua Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As CLIDFAMIEnumerator
        Return New CLIDFAMIEnumerator(Me)
    End Function

    Public Class CLIDFAMIEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaCLIDFAMI)
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
