<Serializable()> Public Class listaTABULAR
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaTABULAR )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As TABULAR)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As TABULAR
        Get
            Return CType((List(index)), TABULAR)
        End Get
        Set(ByVal Value As TABULAR)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As TABULAR) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TABULAR = CType(List(i), TABULAR)
            If s.ccodcli = value.ccodcli _
            And s.ccodenc = value.ccodenc _
            And s.ccodpreg = value.ccodpreg _
            And s.ccodres = value.ccodres Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String, _
        ByVal ccodenc As String, _
        ByVal ccodpreg As String, _
        ByVal ccodres As String) As TABULAR
        Dim i As Integer = 0
        While i < List.Count
            Dim s As TABULAR = CType(List(i), TABULAR)
            If s.ccodcli = ccodcli _
            And s.ccodenc = ccodenc _
            And s.ccodpreg = ccodpreg _
            And s.ccodres = ccodres Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As TABULAREnumerator
        Return New TABULAREnumerator(Me)
    End Function

    Public Class TABULAREnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaTABULAR)
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
