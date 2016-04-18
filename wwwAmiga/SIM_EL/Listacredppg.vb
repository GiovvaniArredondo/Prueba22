<Serializable()> Public Class listacredppg
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacredppg )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As credppg)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As credppg
        Get
            Return CType((List(index)), credppg)
        End Get
        Set(ByVal Value As credppg)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As credppg) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credppg = CType(List(i), credppg)
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
        ByVal cnrocuo As String) As credppg
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credppg = CType(List(i), credppg)
            If s.ccodcta = ccodcta _
            And s.ctipope = ctipope _
            And s.cnrocuo = cnrocuo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As credppgEnumerator
        Return New credppgEnumerator(Me)
    End Function

    Public Class credppgEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacredppg)
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
