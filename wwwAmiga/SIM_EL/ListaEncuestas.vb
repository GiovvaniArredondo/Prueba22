<Serializable()> Public Class listaEncuestas
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaEncuestas )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As Encuestas)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As Encuestas
        Get
            Return CType((List(index)), Encuestas)
        End Get
        Set(ByVal Value As Encuestas)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As Encuestas) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As Encuestas = CType(List(i), Encuestas)
            If s.ccodenc = value.ccodenc _
            And s.ccodpreg = value.ccodpreg Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodenc As String, _
        ByVal ccodpreg As String) As Encuestas
        Dim i As Integer = 0
        While i < List.Count
            Dim s As Encuestas = CType(List(i), Encuestas)
            If s.ccodenc = ccodenc _
            And s.ccodpreg = ccodpreg Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As EncuestasEnumerator
        Return New EncuestasEnumerator(Me)
    End Function

    Public Class EncuestasEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaEncuestas)
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
