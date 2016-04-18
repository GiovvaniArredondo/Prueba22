<Serializable()> Public Class listacredkar
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacredkar )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As credkar)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As credkar
        Get
            Return CType((List(index)), credkar)
        End Get
        Set(ByVal Value As credkar)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As credkar) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credkar = CType(List(i), credkar)
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
        ByVal cnuming As String) As credkar
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credkar = CType(List(i), credkar)
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

    Public Shadows Function GetEnumerator() As credkarEnumerator
        Return New credkarEnumerator(Me)
    End Function

    Public Class credkarEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacredkar)
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
