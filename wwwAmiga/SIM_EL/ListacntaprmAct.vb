<Serializable()> Public Class listacntaprmAct
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacntaprmAct)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cntaprmAct)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cntaprmAct
        Get
            Return CType((List(index)), cntaprmAct)
        End Get
        Set(ByVal Value As cntaprmAct)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cntaprmAct) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntaprmAct = CType(List(i), cntaprmAct)
            If s.cmesvig = value.cmesvig Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cmesvig As String) As cntaprmAct
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntaprmAct = CType(List(i), cntaprmAct)
            If s.cmesvig = cmesvig Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cntaprmActEnumerator
        Return New cntaprmActEnumerator(Me)
    End Function

    Public Class cntaprmActEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacntaprmAct)
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
