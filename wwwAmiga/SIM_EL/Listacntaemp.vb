<Serializable()> Public Class listacntaemp
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacntaemp )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cntaemp)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cntaemp
        Get
            Return CType((List(index)), cntaemp)
        End Get
        Set(ByVal Value As cntaemp)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cntaemp) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntaemp = CType(List(i), cntaemp)
            If s.ccodemp = value.ccodemp Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodemp As String) As cntaemp
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cntaemp = CType(List(i), cntaemp)
            If s.ccodemp = ccodemp Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cntaempEnumerator
        Return New cntaempEnumerator(Me)
    End Function

    Public Class cntaempEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacntaemp)
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
