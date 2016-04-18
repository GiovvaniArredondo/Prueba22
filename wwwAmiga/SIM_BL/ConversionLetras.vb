Public Class ConversionLetras

    Public Shared Function ConversionDecimales(ByVal nnumero As Double) As String


        Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
        Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
        Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                    "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
        Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
        Dim num2, letra, auxlinea, ls_decimal As String
        'string UNIDAD[10],DECENA[10],CENTENA[10],EXCEPCION[5]
        Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer

        If nnumero = 0 Then
            letra = "CERO "
            Return letra
        End If



        num2 = CStr(Math.Round(nnumero, 2))

        n100000000 = Int(nnumero / 100000000)
        nnumero = nnumero - n100000000 * 100000000
        n10000000 = Int(nnumero / 10000000)
        nnumero = nnumero - n10000000 * 10000000
        n1000000 = Int(nnumero / 1000000)
        nnumero = nnumero - n1000000 * 1000000
        n100000 = Int(nnumero / 100000)
        nnumero = nnumero - n100000 * 100000
        n10000 = Int(nnumero / 10000)
        nnumero = nnumero - n10000 * 10000
        n1000 = Int(nnumero / 1000)
        nnumero = nnumero - n1000 * 1000
        n100 = Int(nnumero / 100)
        nnumero = nnumero - n100 * 100
        n10 = Int(nnumero / 10)
        nnumero = nnumero - n10 * 10
        n = Int(nnumero)

        'real en pb???

        n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
        n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
        n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
        n100000 = CDbl(CStr(Math.Round(n100000, 2)))
        n10000 = CDbl(CStr(Math.Round(n10000, 2)))
        n1000 = CDbl(CStr(Math.Round(n1000, 2)))
        n100 = CDbl(CStr(Math.Round(n100, 2)))
        n10 = CDbl(CStr(Math.Round(n10, 2)))
        n = CDbl(CStr(Math.Round(n, 2)))

        num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))


        nnumero = CDbl(Right(num2, 2))
        '  MILLONES
        If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
            letra = "CIEN "
        Else
            If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
            Else
                letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                If n1000000 <> 0 And n10000000 <> 0 Then
                    letra = letra + "Y "
                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n1000000 + 1)
            End If
        End If
        If letra Is Nothing Or n1000000 <> 0 Then
            If n1000000 = 1 Then
                letra = letra + "MILLON "
            Else
                letra = letra + "MILLONES "
            End If
        End If

        'MILES
        If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
            letra = letra + "CIEN "
        Else
            If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
            Else
                letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                If n1000 <> 0 And n10000 <> 0 Then
                    letra = letra + "Y "
                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n1000 + 1)
            End If
        End If
        If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
            letra = letra + "MIL "
        End If
        If n100 = 1 And n10 = 0 And n = 0 Then
            letra = letra + "CIEN "
        Else
            If n10 = 1 And n > 0 And n <= 5 Then
                letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
            Else
                letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                If n <> 0 And n10 <> 0 Then
                    Select Case n10
                        Case 1
                            Select Case n
                                Case 6, 7, 8, 9
                                    letra = Left(letra, Len(letra) - 2)
                                    letra = letra + "CI"
                            End Select
                        Case 2
                            letra = Left(letra, Len(letra) - 2)
                            letra = letra + "I"
                        Case Else
                            letra = letra + "Y "
                    End Select

                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n + 1)
                If n = 1 And (n10 = 1 Or n10 = 2) Then
                    letra = Left(letra, Len(letra) - 1)
                    letra = letra
                End If

            End If
        End If


        ''''''
        If nnumero < 10 Then
            ls_decimal = "0" + CStr(nnumero)
        Else
            ls_decimal = CStr(nnumero)
        End If

        letra = letra + ls_decimal + "/100"
        'linea1 = letra
        'If Len(Trim(letra)) < 50 Then
        '    linea1 = linea1 + linea1.PadRight(50 - Len(Trim(letra)), "*")
        'Else
        '    linea1 = linea1 + ""
        'End If

        'linea2 = linea2.PadRight(22, "*")
        'If Len(linea1) > 65 Then
        '    auxlinea = Left(linea1, linea1.IndexOf("/") - 3)
        '    linea2 = Right(linea1, 6) + linea1.PadRight(16, "*")
        '    linea1 = auxlinea
        'End If




        Return letra
    End Function

    Public Shared Function ConversionEnteros(ByVal nnumero As Double) As String


        Dim UNIDAD() As String = {"", "", "UNO ", "DOS ", "TRES ", "CUATRO ", "CINCO ", "SEIS ", "SIETE ", "OCHO ", "NUEVE "}
        Dim DECENA() As String = {"", "", "DIEZ ", "VEINTE ", "TREINTA ", "CUARENTA ", "CINCUENTA ", "SESENTA ", "SETENTA ", "OCHENTA ", "NOVENTA "}
        Dim CENTENA() As String = {"", "", "CIENTO ", "DOSCIENTOS ", "TRESCIENTOS ", "CUATROCIENTOS ", "QUINIENTOS ", _
                                    "SEISCIENTOS ", "SETECIENTOS ", "OCHOCIENTOS ", "NOVECIENTOS "}
        Dim EXCEPCION() As String = {"", "ONCE ", "DOCE ", "TRECE ", "CATORCE ", "QUINCE "}
        Dim num2, letra, auxlinea, ls_decimal As String

        Dim n100000000, n10000000, n1000000, n100000, n10000, n1000, n100, n10, n As Integer

        If nnumero = 0 Then
            letra = "CERO "
            Return letra
        End If



        num2 = CStr(Math.Round(nnumero, 2))

        n100000000 = Int(nnumero / 100000000)
        nnumero = nnumero - n100000000 * 100000000
        n10000000 = Int(nnumero / 10000000)
        nnumero = nnumero - n10000000 * 10000000
        n1000000 = Int(nnumero / 1000000)
        nnumero = nnumero - n1000000 * 1000000
        n100000 = Int(nnumero / 100000)
        nnumero = nnumero - n100000 * 100000
        n10000 = Int(nnumero / 10000)
        nnumero = nnumero - n10000 * 10000
        n1000 = Int(nnumero / 1000)
        nnumero = nnumero - n1000 * 1000
        n100 = Int(nnumero / 100)
        nnumero = nnumero - n100 * 100
        n10 = Int(nnumero / 10)
        nnumero = nnumero - n10 * 10
        n = Int(nnumero)

        'real en pb???

        n100000000 = CDbl(CStr(Math.Round(n100000000, 2)))
        n10000000 = CDbl(CStr(Math.Round(n10000000, 2)))
        n1000000 = CDbl(CStr(Math.Round(n1000000, 2)))
        n100000 = CDbl(CStr(Math.Round(n100000, 2)))
        n10000 = CDbl(CStr(Math.Round(n10000, 2)))
        n1000 = CDbl(CStr(Math.Round(n1000, 2)))
        n100 = CDbl(CStr(Math.Round(n100, 2)))
        n10 = CDbl(CStr(Math.Round(n10, 2)))
        n = CDbl(CStr(Math.Round(n, 2)))

        num2 = CStr(Math.Round(CDbl(CStr(Math.Round(nnumero, 2))), 2))


        nnumero = CDbl(Right(num2, 2))
        '  MILLONES
        If n100000000 = 1 And n10000000 = 0 And n1000000 = 0 Then
            letra = "CIEN "
        Else
            If n10000000 = 1 And n1000000 > 0 And n1000000 <= 5 Then
                letra = CENTENA(n100000000 + 1) + EXCEPCION(n1000000)
            Else
                letra = CENTENA(n100000000 + 1) + DECENA(n10000000)
                If n1000000 <> 0 And n10000000 <> 0 Then
                    letra = letra + "Y "
                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n1000000 + 1)
            End If
        End If
        If letra Is Nothing Or n1000000 <> 0 Then
            If n1000000 = 1 Then
                letra = letra + "MILLON "
            Else
                letra = letra + "MILLONES "
            End If
        End If

        'MILES
        If n100000 = 1 And n10000 = 0 And n1000 = 0 Then
            letra = letra + "CIEN "
        Else
            If n10000 = 1 And n1000 > 0 And n1000 <= 5 Then
                letra = letra + CENTENA(n100000 + 1) + EXCEPCION(n1000)
            Else
                letra = letra + CENTENA(n100000 + 1) + DECENA(n10000 + 1)
                If n1000 <> 0 And n10000 <> 0 Then
                    letra = letra + "Y "
                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n1000 + 1)
            End If
        End If
        If n100000 <> 0 Or n10000 <> 0 Or n1000 <> 0 Then
            If letra.Trim = "UNO" Then
                letra = "UN MIL "
            Else
                letra = letra + "MIL "
            End If

        End If
        If n100 = 1 And n10 = 0 And n = 0 Then
            letra = letra + "CIEN "
        Else
            If n10 = 1 And n > 0 And n <= 5 Then
                letra = letra + CENTENA(n100 + 1) + EXCEPCION(n)
            Else
                letra = letra + CENTENA(n100 + 1) + DECENA(n10 + 1)
                If n <> 0 And n10 <> 0 Then
                    Select Case n10
                        Case 1
                            Select Case n
                                Case 6, 7, 8, 9
                                    letra = Left(letra, Len(letra) - 2)
                                    letra = letra + "CI"
                            End Select
                        Case 2
                            letra = Left(letra, Len(letra) - 2)
                            letra = letra + "I"
                        Case Else
                            letra = letra + "Y "
                    End Select

                Else
                    letra = letra + ""
                End If
                letra = letra + UNIDAD(n + 1)
                If n = 1 And (n10 = 1 Or n10 = 2) Then
                    letra = Left(letra, Len(letra) - 1)
                    letra = letra
                End If

            End If
        End If


        'If nnumero < 10 Then
        '    ls_decimal = CStr(nnumero)
        'Else
        '    ls_decimal = CStr(nnumero)
        'End If
        'letra = letra
        'linea1 = letra
        'If Len(Trim(letra)) < 50 Then
        '    linea1 = linea1 + linea1.PadRight(50 - Len(Trim(letra)), "*")
        'Else
        '    linea1 = linea1 + ""
        'End If

        'linea2 = linea2.PadRight(22, "*")
        'If Len(linea1) > 65 Then

        '    auxlinea = Left(linea1, linea1.IndexOf("/") - 3)
        '    linea2 = Right(linea1, 6) + linea1.PadRight(16, "*")
        '    linea1 = auxlinea
        'End If


        Return letra
    End Function

    'Esta funcion saca la parte decimal a parti de un string

    Public Function ExtraeDecimales(ByVal Parametro As String) As Double
        Dim x As Integer
        Dim Longit As Integer
        Dim i As Integer
        Dim lnResulta As Double

        Longit = Parametro.Length



        For x = 0 To Parametro.Length - 1
            If Parametro.Substring(x, 1) = "." Then
                x += 1
                Longit = Longit - x
                lnResulta = Double.Parse(Parametro.Substring(x, Longit))
                Exit For
            End If
        Next

        Return lnResulta

    End Function
End Class
