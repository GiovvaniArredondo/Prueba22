<Serializable()> Public Class listaopcionesUsuario
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaopcionesUsuario )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As opcionesUsuario)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As opcionesUsuario
        Get
            Return CType((List(index)), opcionesUsuario)
        End Get
        Set(ByVal Value As opcionesUsuario)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As opcionesUsuario) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As opcionesUsuario = CType(List(i), opcionesUsuario)
            If s.idOpcion = value.idOpcion _
            And s.idUsuario = value.idUsuario Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal idOpcion As Int32, _
        ByVal idUsuario As Int32) As opcionesUsuario
        Dim i As Integer = 0
        While i < List.Count
            Dim s As opcionesUsuario = CType(List(i), opcionesUsuario)
            If s.idOpcion = idOpcion _
            And s.idUsuario = idUsuario Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As opcionesUsuarioEnumerator
        Return New opcionesUsuarioEnumerator(Me)
    End Function

    Public Class opcionesUsuarioEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaopcionesUsuario)
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
