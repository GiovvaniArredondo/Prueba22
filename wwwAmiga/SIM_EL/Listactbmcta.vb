<Serializable()> Public Class listactbmcta
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listactbmcta )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ctbmcta)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ctbmcta
        Get
            Return CType((List(index)), ctbmcta)
        End Get
        Set(ByVal Value As ctbmcta)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ctbmcta) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ctbmcta = CType(List(i), ctbmcta)
            If s.ccodcta = value.ccodcta Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String) As ctbmcta
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ctbmcta = CType(List(i), ctbmcta)
            If s.ccodcta = ccodcta Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ctbmctaEnumerator
        Return New ctbmctaEnumerator(Me)
    End Function

    Public Class ctbmctaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listactbmcta)
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
