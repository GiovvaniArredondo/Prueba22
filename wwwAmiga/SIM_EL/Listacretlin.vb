<Serializable()> Public Class listacretlin
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacretlin )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cretlin)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cretlin
        Get
            Return CType((List(index)), cretlin)
        End Get
        Set(ByVal Value As cretlin)
            List(index) = Value
        End Set
    End Property

    'Public Function IndiceDe(ByVal value As cretlin) As Integer
    '    Dim i As Integer = 0
    '    While i < List.Count
    '        Dim s As cretlin = CType(List(i), cretlin)
    '            Return i
    '        End If
    '        i += 1
    '    End While
    '    Return -1
    'End Function

    '    Dim i As Integer = 0
    '    While i < List.Count
    '        Dim s As cretlin = CType(List(i), cretlin)
    '            Return s
    '        End If
    '        i += 1
    '    End While
    '    Return Nothing
    'End Function

    Public Shadows Function GetEnumerator() As cretlinEnumerator
        Return New cretlinEnumerator(Me)
    End Function

    Public Class cretlinEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacretlin)
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
