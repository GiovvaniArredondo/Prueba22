<Serializable()> Public Class listacentros
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacentros )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As centros)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As centros
        Get
            Return CType((List(index)), centros)
        End Get
        Set(ByVal Value As centros)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As centros) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As centros = CType(List(i), centros)
            If s.cCodsol = value.cCodsol Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cCodsol As String) As centros
        Dim i As Integer = 0
        While i < List.Count
            Dim s As centros = CType(List(i), centros)
            If s.cCodsol = cCodsol Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As centrosEnumerator
        Return New centrosEnumerator(Me)
    End Function

    Public Class centrosEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacentros)
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
