Public Class utilNumeros
    Public Shared Function Redondear(ByVal numero As Decimal, ByVal decimales As Integer) As Decimal
        Return Decimal.Round(numero, decimales)
    End Function
    Public Shared Function Redondear(ByVal numero As Double, ByVal decimales As Integer) As Decimal
        Return redondo(CDec(numero), decimales)
    End Function

    Public Shared Function Redondear(ByVal numero As Single, ByVal decimales As Integer) As Decimal
        Return redondo(CDec(numero), decimales)
    End Function

    Public Shared Function redondo(ByVal numero As Decimal, ByVal decimales As Integer) As Decimal
        Return Decimal.Round(numero, decimales)
    End Function
End Class
