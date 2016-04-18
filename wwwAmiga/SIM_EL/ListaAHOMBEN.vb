<Serializable()> Public Class listaAHOMBEN
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaAHOMBEN )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As AHOMBEN)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As AHOMBEN
        Get
            Return CType((List(index)), AHOMBEN)
        End Get
        Set(ByVal Value As AHOMBEN)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As AHOMBEN) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As AHOMBEN = CType(List(i), AHOMBEN)
            If s.ccodaho = value.ccodaho _
            And s.ncorrel = value.ncorrel Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodaho As String, _
        ByVal ncorrel As Int32) As AHOMBEN
        Dim i As Integer = 0
        While i < List.Count
            Dim s As AHOMBEN = CType(List(i), AHOMBEN)
            If s.ccodaho = ccodaho _
            And s.ncorrel = ncorrel Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As AHOMBENEnumerator
        Return New AHOMBENEnumerator(Me)
    End Function

    Public Class AHOMBENEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaAHOMBEN)
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
