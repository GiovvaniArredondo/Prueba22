<Serializable()> Public Class listacreditos
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacreditos)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As creditos)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As creditos
        Get
            Return CType((List(index)), creditos)
        End Get
        Set(ByVal Value As creditos)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As creditos) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As creditos = CType(List(i), creditos)
            If s.ccodcta = value.ccodcta Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String) As creditos
        Dim i As Integer = 0
        While i < List.Count
            Dim s As creditos = CType(List(i), creditos)
            If s.ccodcta = ccodcta Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As creditosEnumerator
        Return New creditosEnumerator(Me)
    End Function

    Public Class creditosEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacreditos)
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
