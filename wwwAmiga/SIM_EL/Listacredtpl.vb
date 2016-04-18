<Serializable()> Public Class listacredtpl
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacredtpl )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As credtpl)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As credtpl
        Get
            Return CType((List(index)), credtpl)
        End Get
        Set(ByVal Value As credtpl)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As credtpl) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credtpl = CType(List(i), credtpl)
            If s.ccodcta = value.ccodcta _
            And s.ctipope = value.ctipope _
            And s.cnrocuo = value.cnrocuo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String, _
        ByVal ctipope As String, _
        ByVal cnrocuo As String) As credtpl
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credtpl = CType(List(i), credtpl)
            If s.ccodcta = ccodcta _
            And s.ctipope = ctipope _
            And s.cnrocuo = cnrocuo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As credtplEnumerator
        Return New credtplEnumerator(Me)
    End Function

    Public Class credtplEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacredtpl)
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
