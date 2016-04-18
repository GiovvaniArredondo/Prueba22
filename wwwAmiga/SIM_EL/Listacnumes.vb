<Serializable()> Public Class listacnumes
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacnumes )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cnumes)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cnumes
        Get
            Return CType((List(index)), cnumes)
        End Get
        Set(ByVal Value As cnumes)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cnumes) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cnumes = CType(List(i), cnumes)
            If s.numes = value.numes Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal numes As String) As cnumes
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cnumes = CType(List(i), cnumes)
            If s.numes = numes Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cnumesEnumerator
        Return New cnumesEnumerator(Me)
    End Function

    Public Class cnumesEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacnumes)
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
