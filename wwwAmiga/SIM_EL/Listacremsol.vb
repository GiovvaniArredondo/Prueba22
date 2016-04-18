<Serializable()> Public Class listacremsol
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacremsol )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cremsol)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cremsol
        Get
            Return CType((List(index)), cremsol)
        End Get
        Set(ByVal Value As cremsol)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cremsol) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cremsol = CType(List(i), cremsol)
            If s.cCodsol = value.cCodsol Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cCodsol As String) As cremsol
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cremsol = CType(List(i), cremsol)
            If s.cCodsol = cCodsol Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cremsolEnumerator
        Return New cremsolEnumerator(Me)
    End Function

    Public Class cremsolEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacremsol)
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
