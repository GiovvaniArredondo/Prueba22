<Serializable()> Public Class listaautopag
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaautopag )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As autopag)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As autopag
        Get
            Return CType((List(index)), autopag)
        End Get
        Set(ByVal Value As autopag)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As autopag) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As autopag = CType(List(i), autopag)
                Return i
            ' End If
            i += 1
        End While
        Return -1
    End Function

    '      Dim i As Integer = 0
    '     While i < List.Count
    '        Dim s As autopag = CType(List(i), autopag)
    '           Return s
    '           End If
    '        i += 1
    '    End While
    '    Return Nothing
    ' End Function

    Public Shadows Function GetEnumerator() As autopagEnumerator
        Return New autopagEnumerator(Me)
    End Function

    Public Class autopagEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaautopag)
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
