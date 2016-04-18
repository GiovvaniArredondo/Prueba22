<Serializable()> Public Class listacancela
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacancela )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cancela)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cancela
        Get
            Return CType((List(index)), cancela)
        End Get
        Set(ByVal Value As cancela)
            List(index) = Value
        End Set
    End Property

    

    Public Shadows Function GetEnumerator() As cancelaEnumerator
        Return New cancelaEnumerator(Me)
    End Function

    Public Class cancelaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacancela)
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
