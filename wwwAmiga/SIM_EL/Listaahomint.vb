<Serializable()> Public Class listaahomint
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listaahomint )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As ahomint)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As ahomint
        Get
            Return CType((List(index)), ahomint)
        End Get
        Set(ByVal Value As ahomint)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As ahomint) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomint = CType(List(i), ahomint)
            If s.ccodcrt = value.ccodcrt _
            And s.dfecpro = value.dfecpro _
            And s.nnum = value.nnum Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcrt As String, _
        ByVal dfecpro As DateTime, _
        ByVal nnum As Decimal) As ahomint
        Dim i As Integer = 0
        While i < List.Count
            Dim s As ahomint = CType(List(i), ahomint)
            If s.ccodcrt = ccodcrt _
            And s.dfecpro = dfecpro _
            And s.nnum = nnum Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As ahomintEnumerator
        Return New ahomintEnumerator(Me)
    End Function

    Public Class ahomintEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaahomint)
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
