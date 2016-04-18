<Serializable()> Public Class listatabtofi
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtofi )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtofi)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtofi
        Get
            Return CType((List(index)), tabtofi)
        End Get
        Set(ByVal Value As tabtofi)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtofi) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtofi = CType(List(i), tabtofi)
            If s.ccodofi = value.ccodofi Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodofi As String) As tabtofi
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtofi = CType(List(i), tabtofi)
            If s.ccodofi = ccodofi Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtofiEnumerator
        Return New tabtofiEnumerator(Me)
    End Function

    Public Class tabtofiEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtofi)
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
