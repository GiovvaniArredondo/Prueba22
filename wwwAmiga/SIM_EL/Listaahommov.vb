<Serializable()> Public Class listaahommov
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahommov )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahommov)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahommov
        Get
            Return CType((List(index)), ahommov)
        End Get
        Set(ByVal Value As ahommov)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahommov) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahommov = CType(List(i), ahommov)
            If s.ccodaho = value.ccodaho _
            And s.clinea = value.clinea Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodaho As String, _
        ByVal clinea As String) As ahommov
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahommov = CType(List(i), ahommov)
            If s.ccodaho = ccodaho _
            And s.clinea = clinea Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahommovEnumerator
        Return New ahommovEnumerator(Me)
    End Function

    Public Class ahommovEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahommov)
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
