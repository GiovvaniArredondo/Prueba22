<Serializable()> Public Class listaActivoF
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaActivoF )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ActivoF)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ActivoF
        Get
            Return CType((List(index)), ActivoF)
        End Get
        Set(ByVal Value As ActivoF)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ActivoF) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ActivoF = CType(List(i), ActivoF)
                Return i

            i += 1
        End While
        Return -1
    End Function

    

    Public Shadows Function GetEnumerator() As ActivoFEnumerator
        Return New ActivoFEnumerator(Me)
    End Function

    Public Class ActivoFEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaActivoF)
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
