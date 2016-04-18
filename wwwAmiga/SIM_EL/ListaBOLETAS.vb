<Serializable()> Public Class listaBOLETAS
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaBOLETAS )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As BOLETAS)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As BOLETAS
        Get
            Return CType((List(index)), BOLETAS)
        End Get
        Set(ByVal Value As BOLETAS)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As BOLETAS) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BOLETAS = CType(List(i), BOLETAS)
            If s.cbanco = value.cbanco _
            And s.cnuming = value.cnuming _
            And s.cestado = value.cestado Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cbanco As String, _
        ByVal cnuming As String, _
        ByVal cestado As String) As BOLETAS
        Dim i As Integer = 0
        While i < List.Count
            Dim s As BOLETAS = CType(List(i), BOLETAS)
            If s.cbanco = cbanco _
            And s.cnuming = cnuming _
            And s.cestado = cestado Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As BOLETASEnumerator
        Return New BOLETASEnumerator(Me)
    End Function

    Public Class BOLETASEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBOLETAS)
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
