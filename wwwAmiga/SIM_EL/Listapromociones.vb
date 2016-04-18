<Serializable()> Public Class listapromociones
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listapromociones )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As promociones)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As promociones
        Get
            Return CType((List(index)), promociones)
        End Get
        Set(ByVal Value As promociones)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As promociones) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As promociones = CType(List(i), promociones)
            If s.codigo = value.codigo Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal codigo As Int32) As promociones
        Dim i As Integer = 0
        While i < List.Count
            Dim s As promociones = CType(List(i), promociones)
            If s.codigo = codigo Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As promocionesEnumerator
        Return New promocionesEnumerator(Me)
    End Function

    Public Class promocionesEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listapromociones)
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
