<Serializable()> Public Class listaclipcta
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaclipcta )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As clipcta)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As clipcta
        Get
            Return CType((List(index)), clipcta)
        End Get
        Set(ByVal Value As clipcta)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As clipcta) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clipcta = CType(List(i), clipcta)
            If s.ccodcli = value.ccodcli _
            And s.ccodcta = value.ccodcta Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcli As String, _
        ByVal ccodcta As String) As clipcta
        Dim i As Integer = 0
        While i < List.Count
            Dim s As clipcta = CType(List(i), clipcta)
            If s.ccodcli = ccodcli _
            And s.ccodcta = ccodcta Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As clipctaEnumerator
        Return New clipctaEnumerator(Me)
    End Function

    Public Class clipctaEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaclipcta)
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
