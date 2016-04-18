<Serializable()> Public Class listacntaprm
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacntaprm )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cntaprm)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cntaprm
        Get
            Return CType((List(index)), cntaprm)
        End Get
        Set(ByVal Value As cntaprm)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cntaprm) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntaprm = CType(List(i), cntaprm)
            If s.cmesvig = value.cmesvig Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cmesvig As String) As cntaprm
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntaprm = CType(List(i), cntaprm)
            If s.cmesvig = cmesvig Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cntaprmEnumerator
        Return New cntaprmEnumerator(Me)
    End Function

    Public Class cntaprmEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacntaprm)
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
