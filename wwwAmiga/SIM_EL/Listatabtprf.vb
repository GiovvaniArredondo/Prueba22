<Serializable()> Public Class listatabtprf
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listatabtprf )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As tabtprf)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As tabtprf
        Get
            Return CType((List(index)), tabtprf)
        End Get
        Set(ByVal Value As tabtprf)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As tabtprf) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtprf = CType(List(i), tabtprf)
            If s.ccodigo = value.ccodigo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodigo As String) As tabtprf
        Dim i As Integer = 0
        While i < List.Count
            Dim s As tabtprf = CType(List(i), tabtprf)
            If s.ccodigo = ccodigo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As tabtprfEnumerator
        Return New tabtprfEnumerator(Me)
    End Function

    Public Class tabtprfEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listatabtprf)
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
