<Serializable()> Public Class listausuarios
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listausuarios )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As usuarios)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As usuarios
        Get
            Return CType((List(index)), usuarios)
        End Get
        Set(ByVal Value As usuarios)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As usuarios) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As usuarios = CType(List(i), usuarios)
            If s.idUsuario = value.idUsuario Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal idUsuario As Int32) As usuarios
        Dim i As Integer = 0
        While i < List.Count
            Dim s As usuarios = CType(List(i), usuarios)
            If s.idUsuario = idUsuario Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As usuariosEnumerator
        Return New usuariosEnumerator(Me)
    End Function

    Public Class usuariosEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listausuarios)
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
