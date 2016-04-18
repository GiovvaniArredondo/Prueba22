<Serializable()> Public Class listakardex
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listakardex)
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As kardex)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As kardex
        Get
            Return CType((List(index)), kardex)
        End Get
        Set(ByVal Value As kardex)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As kardex) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As kardex = CType(List(i), kardex)
            If s.ccodcta = value.ccodcta _
            And s.cnrodoc = value.cnrodoc _
            And s.cconcep = value.cconcep _
            And s.cdescob = value.cdescob _
            And s.cnuming = value.cnuming Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String, _
        ByVal cnrodoc As String, _
        ByVal cconcep As String, _
        ByVal cdescob As String, _
        ByVal cnuming As String) As kardex
        Dim i As Integer = 0
        While i < List.Count
            Dim s As kardex = CType(List(i), kardex)
            If s.ccodcta = ccodcta _
            And s.cnrodoc = cnrodoc _
            And s.cconcep = cconcep _
            And s.cdescob = cdescob _
            And s.cnuming = cnuming Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As kardexEnumerator
        Return New kardexEnumerator(Me)
    End Function

    Public Class kardexEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listakardex)
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
