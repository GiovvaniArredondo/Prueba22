<Serializable()> Public Class listaopciones
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaopciones )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As opciones)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As opciones
        Get
            Return CType((List(index)), opciones)
        End Get
        Set(ByVal Value As opciones)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As opciones) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As opciones = CType(List(i), opciones)
            If s.idOpcion = value.idOpcion Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal idOpcion As Int32) As opciones
        Dim i As Integer = 0
        While i < List.Count
            Dim s As opciones = CType(List(i), opciones)
            If s.idOpcion = idOpcion Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As opcionesEnumerator
        Return New opcionesEnumerator(Me)
    End Function

    Public Class opcionesEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaopciones)
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
