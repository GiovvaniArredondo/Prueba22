<Serializable()> Public Class listausuarioGrupo
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listausuarioGrupo )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As usuarioGrupo)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As usuarioGrupo
        Get
            Return CType((List(index)), usuarioGrupo)
        End Get
        Set(ByVal Value As usuarioGrupo)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As usuarioGrupo) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As usuarioGrupo = CType(List(i), usuarioGrupo)
            If s.idUsuario = value.idUsuario _
            And s.idGrupo = value.idGrupo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal idUsuario As Int32, _
        ByVal idGrupo As Int32) As usuarioGrupo
        Dim i As Integer = 0
        While i < List.Count
            Dim s As usuarioGrupo = CType(List(i), usuarioGrupo)
            If s.idUsuario = idUsuario _
            And s.idGrupo = idGrupo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As usuarioGrupoEnumerator
        Return New usuarioGrupoEnumerator(Me)
    End Function

    Public Class usuarioGrupoEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listausuarioGrupo)
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
