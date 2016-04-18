<Serializable()> Public Class listatabtvar
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtvar )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtvar)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtvar
        Get
            Return CType((List(index)), tabtvar)
        End Get
        Set(ByVal Value As tabtvar)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtvar) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtvar = CType(List(i), tabtvar)
            If s.ccodapl = value.ccodapl _
            And s.cnomvar = value.cnomvar Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodapl As String, _
        ByVal cnomvar As String) As tabtvar
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtvar = CType(List(i), tabtvar)
            If s.ccodapl = ccodapl _
            And s.cnomvar = cnomvar Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtvarEnumerator
        Return New tabtvarEnumerator(Me)
    End Function

    Public Class tabtvarEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtvar)
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
