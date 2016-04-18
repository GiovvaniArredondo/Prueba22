<Serializable()> Public Class listacredgas
    Inherits listaBase

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As listacredgas )
        Me.AgregarRango(value)
    End Sub

    Public Sub New(ByVal value() As credgas)
        Me.AgregarRango(value)
    End Sub

    Default Public Property Blubber(ByVal index As Integer) As credgas
        Get
            Return CType((List(index)), credgas)
        End Get
        Set(ByVal Value As credgas)
            List(index) = Value
        End Set
    End Property

    Public Function IndiceDe(ByVal value As credgas) As Integer
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credgas = CType(List(i), credgas)
            If s.ccodcta = value.ccodcta _
            And s.ctipgas = value.ctipgas _
            And s.cnrocuo = value.cnrocuo _
            And s.cdescob = value.cdescob Then
                Return i
            End If
            i += 1
        End While
        Return -1
    End Function

    Public Function BuscarPorId(ByVal ccodcta As String, _
        ByVal ctipgas As String, _
        ByVal cnrocuo As String, _
        ByVal cdescob As String) As credgas
        Dim i As Integer = 0
        While i < List.Count
            Dim s As credgas = CType(List(i), credgas)
            If s.ccodcta = ccodcta _
            And s.ctipgas = ctipgas _
            And s.cnrocuo = cnrocuo _
            And s.cdescob = cdescob Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function

    Public Shadows Function GetEnumerator() As credgasEnumerator
        Return New credgasEnumerator(Me)
    End Function

    Public Class credgasEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listacredgas)
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
