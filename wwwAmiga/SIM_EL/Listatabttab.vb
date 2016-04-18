<Serializable()> Public Class listatabttab
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabttab )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabttab)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabttab
        Get
            Return CType((List(index)), tabttab)
        End Get
        Set(ByVal Value As tabttab)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabttab) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabttab = CType(List(i), tabttab)
            If s.ccodtab = value.ccodtab _
            And s.ctipreg = value.ctipreg _
            And s.ccodigo = value.ccodigo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodtab As String, _
        ByVal ctipreg As String, _
        ByVal ccodigo As String) As tabttab
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabttab = CType(List(i), tabttab)
            If s.ccodtab = ccodtab _
            And s.ctipreg = ctipreg _
            And s.ccodigo = ccodigo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabttabEnumerator
        Return New tabttabEnumerator(Me)
    End Function

    Public Class tabttabEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabttab)
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
