Public MustInherit Class listaBase
    Inherits CollectionBase

    Public Sub New()
    End Sub

    Public Function Add(ByVal value As entidadBase) As Integer
        Return List.Add(value)
    End Function

    Public Sub AgregarRango(ByVal value() As entidadBase)
        Dim counter As Integer = 0
        While (counter < value.Length)
            Me.Add(value(counter))
            counter += 1
        End While
    End Sub

    Public Sub AgregarRango(ByVal value As listaBase)
        Dim counter As Integer = 0
        While (counter < value.Count)
            Me.Add(value.List(counter))
            counter += 1
        End While
    End Sub

    Public Function Contiene(ByVal value As entidadBase) As Boolean
        Return List.Contains(value)
    End Function

    Public Sub CopiarHacia(ByVal array() As entidadBase, ByVal index As Integer)
        List.CopyTo(array, index)
    End Sub

    Public Sub Insertar(ByVal index As Integer, ByVal value As entidadBase)
        List.Insert(index, value)
    End Sub

    Public Sub Remover(ByVal value As entidadBase)
        List.Remove(value)
    End Sub

    Public Shadows Function GetEnumerator() As entidadBaseEnumerator
        Return New entidadBaseEnumerator(Me)
    End Function

    Public Class entidadBaseEnumerator
        Inherits Object
        Implements IEnumerator

        Private Base As IEnumerator
        Private Local As IEnumerable

        Public Sub New(ByVal Mappings As listaBase)
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
