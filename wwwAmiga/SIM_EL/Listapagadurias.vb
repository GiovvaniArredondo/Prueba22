<Serializable()> Public Class listapagadurias
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listapagadurias )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As pagadurias)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As pagadurias
        Get
            Return CType((List(index)), pagadurias)
        End Get
        Set(ByVal Value As pagadurias)
            List(index) = Value
        End Set
    End Property


    Public Shadows Function GetEnumerator() As pagaduriasEnumerator
        Return New pagaduriasEnumerator(Me)
    End Function

    Public Class pagaduriasEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listapagadurias)
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
