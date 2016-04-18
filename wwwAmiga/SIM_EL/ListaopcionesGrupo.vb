<Serializable()> Public Class listaopcionesGrupo
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaopcionesGrupo )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As opcionesGrupo)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As opcionesGrupo
        Get
            Return CType((List(index)), opcionesGrupo)
        End Get
        Set(ByVal Value As opcionesGrupo)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As opcionesGrupo) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As opcionesGrupo = CType(List(i), opcionesGrupo)
            If s.idOpcion = value.idOpcion _
            And s.idGrupo = value.idGrupo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal idOpcion As Int32, _
        ByVal idGrupo As Int32) As opcionesGrupo
        Dim i As Integer = 0
        While i < List.Count
            Dim s As opcionesGrupo = CType(List(i), opcionesGrupo)
            If s.idOpcion = idOpcion _
            And s.idGrupo = idGrupo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As opcionesGrupoEnumerator
        Return New opcionesGrupoEnumerator(Me)
    End Function

    Public Class opcionesGrupoEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaopcionesGrupo)
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
