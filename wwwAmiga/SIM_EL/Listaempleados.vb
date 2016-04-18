<Serializable()> Public Class listaempleados
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaempleados )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As empleados)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As empleados
        Get
            Return CType((List(index)), empleados)
        End Get
        Set(ByVal Value As empleados)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As empleados) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As empleados = CType(List(i), empleados)
            If s.id = value.id Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal id As String) As empleados
        Dim i As Integer = 0
        While i < List.Count
            Dim s As empleados = CType(List(i), empleados)
            If s.id = id Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As empleadosEnumerator
        Return New empleadosEnumerator(Me)
    End Function

    Public Class empleadosEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaempleados)
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
