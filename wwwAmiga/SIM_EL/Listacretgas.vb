<Serializable()> Public Class listacretgas
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacretgas )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As cretgas)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As cretgas
        Get
            Return CType((List(index)), cretgas)
        End Get
        Set(ByVal Value As cretgas)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As cretgas) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cretgas = CType(List(i), cretgas)
            If s.cnrolin = value.cnrolin _
            And s.ctipgas = value.ctipgas Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal cnrolin As String, _
        ByVal ctipgas As String) As cretgas
        Dim i As Integer = 0
        While i < List.Count
            Dim s As cretgas = CType(List(i), cretgas)
            If s.cnrolin = cnrolin _
            And s.ctipgas = ctipgas Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As cretgasEnumerator
        Return New cretgasEnumerator(Me)
    End Function

    Public Class cretgasEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacretgas)
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
