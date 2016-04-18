<Serializable()> Public Class listagestion
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listagestion )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As gestion)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As gestion
        Get
            Return CType((List(index)), gestion)
        End Get
        Set(ByVal Value As gestion)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As gestion) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As gestion = CType(List(i), gestion)
            If s.dfecges = value.dfecges _
            And s.time_in = value.time_in _
            And s.ccodcta = value.ccodcta Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal dfecges As DateTime, _
        ByVal time_in As String, _
        ByVal ccodcta As String) As gestion
        Dim i As Integer = 0
        While i < List.Count
            Dim s As gestion = CType(List(i), gestion)
            If s.dfecges = dfecges _
            And s.time_in = time_in _
            And s.ccodcta = ccodcta Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As gestionEnumerator
        Return New gestionEnumerator(Me)
    End Function

    Public Class gestionEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listagestion)
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
