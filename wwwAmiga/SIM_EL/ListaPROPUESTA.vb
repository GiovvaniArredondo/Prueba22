<Serializable()> Public Class listaPROPUESTA
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaPROPUESTA )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As PROPUESTA)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As PROPUESTA
        Get
            Return CType((List(index)), PROPUESTA)
        End Get
        Set(ByVal Value As PROPUESTA)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As PROPUESTA) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROPUESTA = CType(List(i), PROPUESTA)
            If s.ccodcta = value.ccodcta _
            And s.ccodana = value.ccodana Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String, _
        ByVal ccodana As String) As PROPUESTA
        Dim i As Integer = 0
        While i < List.Count
            Dim s As PROPUESTA = CType(List(i), PROPUESTA)
            If s.ccodcta = ccodcta _
            And s.ccodana = ccodana Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As PROPUESTAEnumerator
        Return New PROPUESTAEnumerator(Me)
    End Function

    Public Class PROPUESTAEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaPROPUESTA)
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
