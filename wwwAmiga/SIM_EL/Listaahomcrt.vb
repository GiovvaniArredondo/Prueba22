<Serializable()> Public Class listaahomcrt
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahomcrt )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahomcrt)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahomcrt
        Get
            Return CType((List(index)), ahomcrt)
        End Get
        Set(ByVal Value As ahomcrt)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahomcrt) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomcrt = CType(List(i), ahomcrt)
            If s.ccodcrt = value.ccodcrt Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcrt As String) As ahomcrt
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomcrt = CType(List(i), ahomcrt)
            If s.ccodcrt = ccodcrt Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahomcrtEnumerator
        Return New ahomcrtEnumerator(Me)
    End Function

    Public Class ahomcrtEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahomcrt)
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
