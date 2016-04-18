<Serializable()> Public Class listagrupos
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listagrupos )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As grupos)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As grupos
        Get
            Return CType((List(index)), grupos)
        End Get
        Set(ByVal Value As grupos)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As grupos) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As grupos = CType(List(i), grupos)
            If s.idGrupo = value.idGrupo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal idGrupo As Int32) As grupos
        Dim i As Integer = 0
        While i < List.Count
            Dim s As grupos = CType(List(i), grupos)
            If s.idGrupo = idGrupo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As gruposEnumerator
        Return New gruposEnumerator(Me)
    End Function

    Public Class gruposEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listagrupos)
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
