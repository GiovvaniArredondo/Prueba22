Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings

Public Class ClsMantenimiento

    Private ds As New DataSet
    Private myconnection As SqlConnection
    Private mycommand As SqlDataAdapter
    Private cmd As SqlCommand
    Private vCadena As String
    Private _cnnStr As New String(AppSettings("cnnString"))
    Private sql As String
    Private vCnn As String

#Region " Propiedades "
    Public Property Cnn() As String
        Get
            Return vCnn
        End Get
        Set(ByVal Value As String)
            vCnn = Value
        End Set
    End Property

    Protected Overridable Property cnnStr() As String
        Get
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property

#End Region

#Region " Metodos "

    'Esta funcion generara el transacc necesario para realizar los 
    'Mantenimientos basicos (selec,insert,update,delete)
    'Por el momento el where sera enviado como parametro

    'Primer parametro Campos
    'Segundo parametro Tipos
    'Tercero parametro Parametro
    'Cuarto parametro Nombre de la Tabla
    'Quinto Tipo de Transac
    'El sexto  seria el Where

    Public Function Transac(ByVal Parametro1 As String, ByVal Parametro2 As String, ByVal Parametro3 As String, ByVal Parametro4 As String, ByVal parametro5 As String, ByVal parametro6 As String) As String
        Dim x As Integer
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim campo6 As String

        i = 0

        '--------------------------------------------------------
        'Proceso que parte cada uno de los parametros enviados
        '--------------------------------------------------------

        'Halla numero de parametros

        For x = 0 To Parametro1.Length - 1
            If Parametro1.Substring(x, 1) = "," Then
                i += 1
            End If
        Next

        'Declara arreglo segun cantidad de parametros
        Dim campos(i) As String
        Dim TipoD(i) As String
        Dim Param(i) As String



        '----------------------------------
        'Sacando los campos
        '----------------------------------

        i = 0
        j = 0
        k = 1

        For x = 0 To Parametro1.Length - 1
            If Parametro1.Substring(x, 1) = "," Then
                campos(k) = Parametro1.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        campo1 = campos(1)
        campo2 = campos(2)
        '   campo3 = campos(3)

        '----------------------------------
        'Sacando los Tipos
        '----------------------------------
        i = 0
        j = 0
        k = 1

        For x = 0 To Parametro2.Length - 1
            If Parametro2.Substring(x, 1) = "," Then
                TipoD(k) = Parametro2.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        '  campo1 = TipoD(1)
        '  campo2 = TipoD(2)
        '  campo3 = TipoD(3)
        '----------------------------------
        'Sacando los parametros
        '----------------------------------
        i = 0
        j = 0
        k = 1

        For x = 0 To Parametro3.Length - 1
            If Parametro3.Substring(x, 1) = "," Then
                Param(k) = Parametro3.Substring(j, i)
                j = x + 1
                k += 1
                i = -1
            End If
            i += 1
        Next

        ' campo1 = Param(1)
        ' campo2 = Param(2)
        ' campo3 = Param(3)
        '--------------------------------------------------------
        'Fin
        '--------------------------------------------------------


        'Evalua el tipo de Transacc Insert, Update, Delete, Select
        Dim codTransac As String
        Dim Valores As String
        Dim Values As Object

        k = campos.Length - 1

        Select Case parametro5
            Case Is = "S"
                For i = 1 To campos.Length - 1
                    If i = k Then
                        codTransac = codTransac & campos(i)
                    Else
                        codTransac = codTransac & campos(i) & ","
                    End If
                Next
                codTransac = "SELECT" & " " & codTransac & " " & "FROM" & " " & Parametro4 & " " & parametro6
            Case Is = "I"
                For i = 1 To campos.Length - 1
                    If TipoD(i) = "I" Then
                        Param(i) = Integer.Parse(Param(i))
                    ElseIf TipoD(i) = "D" Then
                        Param(i) = Double.Parse(Param(i))
                    ElseIf TipoD(i) = "F" Then
                        '  Param(i) = CDate(Param(i).Substring(0, 8))
                        Param(i) = CDate(Param(i))
                    ElseIf TipoD(i) = "B" Then
                        Param(i) = Boolean.Parse(Param(i))
                    End If
                    If i = k Then
                        Valores = Valores & campos(i)
                        Values = Values & "'" & Param(i) & "'"
                    Else
                        Valores = Valores & campos(i) & ","
                        Values = Values & "'" & Param(i) & "'" & ","
                    End If
                Next
                codTransac = "INSERT INTO" & " " & Parametro4 & " " & "(" & Valores & ")" & " " & "Values" & " " & "(" & Values & ")"

            Case Is = "U"
                For i = 1 To campos.Length - 1
                    If TipoD(i) = "I" Then
                        Param(i) = Integer.Parse(Param(i))
                    ElseIf TipoD(i) = "D" Then
                        Param(i) = Double.Parse(Param(i))
                    ElseIf TipoD(i) = "F" Then
                        Param(i) = CDate(Param(i))
                    ElseIf TipoD(i) = "B" Then
                        Param(i) = Boolean.Parse(Param(i))
                    End If
                    If i = k Then
                        Valores = Valores & " " & campos(i) & "=" & "'" & Param(i) & "'"
                    Else
                        Valores = Valores & " " & campos(i) & "=" & "'" & Param(i) & "'" & ","
                    End If

                Next
                codTransac = "UPDATE" & " " & Parametro4 & " " & "SET" & " " & Valores & " " & parametro6
            Case Is = "D"
                codTransac = "DELETE" & " " & "From" & " " & Parametro4 & " " & parametro6
        End Select

        Return codTransac

    End Function

    '--------------------------------------------------------------------
    'Funcion que genera cualquier selec, solo se le envia el transac
    '--------------------------------------------------------------------


    Public Function ResulSelect(ByVal Parametro As String) As DataSet

        '    vCadena = "packet size=4096;integrated security=SSPI;" & _
        '           "initial catalog=Proyecto;persist security info=False"
        'vCadena = "server=THEFORCE; database=FUNDAMICRO;" & _
        '            "uid=sa; pwd=sa"

        Try
            myconnection = New SqlConnection(Me.cnnStr)

            'Dim value As Integer
            'value = (myconnection.ConnectionTimeout)



            sql = Parametro


            mycommand = New SqlDataAdapter(sql, myconnection)

            mycommand.Fill(ds, "Resultado")

            myconnection.Close()

        Catch SqlException As Exception
            MsgBox("Exception: " + SqlException.ToString(), MsgBoxStyle.Critical, "Advertencia")
        End Try

        Return ds

    End Function
    '--------------------------------------------------------------------
    'Funcion que genera cualquier Insert,Update,Delete de cualquier tabla, solo se le 
    'envia el transac
    '--------------------------------------------------------------------
    Dim lcerror As String


    Public Sub Insert(ByVal Parameter1 As String)



        Try
            myconnection = New SqlConnection(Me.cnnStr)

            sql = Parameter1

            cmd = New SqlCommand(sql, myconnection)
            myconnection.Open()
            cmd.ExecuteNonQuery()
            myconnection.Close()



        Catch SqlException As Exception

            '    lcerror = SqlException.ToString
            ' Throw New Exception("Error al insertar registro")
        End Try

    End Sub

#End Region


End Class
