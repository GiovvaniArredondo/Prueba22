Imports System
Imports System.Data
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Public Class Utilidades

    'DT= DATATABLE
    'httpStream= SALIDA
    'WRITEHEADER= SI VA TENER ENCABEZADOS O NO
    ' ProduceCSV(dt, Response.Output, true);
    ' 
    'CLASE TOMADA Y MODIFICADA PARA QUE PRODUZCA UN ARCHIVO DELIMITADO POR COMAS.
    'SE LE CAMBIO EL INDICE A LOS ARREGLOS YA QUE ESTOS GRABABAN UNA COMA AL FINAL DE CADA LINEA
    'SE MODIFICO PARA QUITARLE LOS ESPACIOS EN BLANCO A LOS TEXTOS DONDE NO SE NECESITAN

    Public Shared Function CopiaDataTable(ByVal TablaOrigen As DataTable, ByVal Lista() As String) As DataTable

        Dim TablaDestino As New DataTable
        'TablaDestino = TablaOrigen.Copy
        TablaDestino = TablaOrigen.DefaultView.ToTable("tempTableName", False, Lista)
        Return TablaDestino

    End Function


    '   Public Shared Sub ProduceCSV(ByVal dt As DataTable, _
    'ByVal httpStream As System.IO.TextWriter, ByVal WriteHeader As Boolean)
    '       Dim i As Int32
    '       Dim j As Int32
    '       If WriteHeader Then

    '           Dim arr(dt.Columns.Count - 1) As String

    '           For i = 0 To dt.Columns.Count - 1
    '               arr(i) = dt.Columns(i).ColumnName
    '               arr(i) = GetWriteableValue(arr(i))
    '           Next
    '           httpStream.WriteLine(String.Join(",", arr))
    '       End If

    '       For j = 0 To dt.Rows.Count - 1
    '           Dim dataArr(dt.Columns.Count - 1) As String
    '           For i = 0 To dt.Columns.Count - 1
    '               Dim o As Object = dt.Rows(j)(i)
    '               dataArr(i) = GetWriteableValue(o)
    '           Next
    '           httpStream.WriteLine(String.Join(",", dataArr))
    '       Next

    '   End Sub

#Region "CSVProducer"
    Public Shared Sub ProduceCSV(ByVal dt As DataTable, _
 ByVal file As System.IO.StreamWriter, ByVal WriteHeader As Boolean)

        Dim i As Int32
        Dim j As Int32
        If (WriteHeader) Then
            Dim arr(dt.Columns.Count - 1) As String
            For i = 0 To dt.Columns.Count - 1
                arr(i) = dt.Columns(i).ColumnName
                arr(i) = GetWriteableValue(arr(i))
            Next
            file.WriteLine(String.Join(",", arr))
        End If

        For j = 0 To dt.Rows.Count - 1
            Dim dataArr(dt.Columns.Count - 1) As String
            For i = 0 To dt.Columns.Count - 1
                Dim o As Object = dt.Rows(j)(i)
                dataArr(i) = GetWriteableValue(o)
            Next
            file.WriteLine(String.Join(",", dataArr))
        Next
    End Sub

    Public Shared Function GetWriteableValue(ByVal o As Object) As String
        Try
            If o Is Nothing OrElse IsDBNull(o) Then
                Return ""
            ElseIf (o.ToString().IndexOf(",") = -1) Then
                Return o.ToString().Trim
            Else
                Return "\"" + o.ToString() + " \ ""
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Function FiltraTabla(ByVal TablaTemporal As DataTable, ByVal Filtro As String) As DataTable

        Dim dvVista As New DataView

        dvVista = TablaTemporal.DefaultView

        dvVista.RowFilter = Filtro

        Return dvVista.ToTable

    End Function
    Public Function CreaArchivo(ByVal nombreArchivo As String, ByVal destinoFisico As String) As StreamWriter

        Dim Archivo As StreamWriter

        Try
            Archivo = New StreamWriter(destinoFisico + nombreArchivo, True)
        Catch ex As Exception

        End Try

        Return Archivo

    End Function

    Public Sub AgregarLineaArchivo(ByVal archivoLogico As StreamWriter, ByVal linea As String)
        Try
            archivoLogico.WriteLine(linea)
        Catch ex As Exception

        End Try

    End Sub

    Public Function GeneraFirmaDigital(ByVal buffer As String) As String


        Dim mensaje As Byte()
        Dim codigoHash As Byte()
        Dim firmaDigital As String
        Dim objetoSha As SHA1
        Dim objetoDSA As DSA
        Dim firmaDigitalHash As Byte()

        objetoSha = SHA1.Create()
        objetoDSA = DSA.Create()


        'obtiene los bytes del mensaje
        mensaje = Encoding.Default.GetBytes(buffer)
        'genera el codigo hash del mensaje
        codigoHash = objetoSha.ComputeHash(mensaje)
        'crea la firma digital del codigo hash
        firmaDigitalHash = objetoDSA.CreateSignature(codigoHash)
        firmaDigital = Replace(BitConverter.ToString(firmaDigitalHash), "-", "")

        Return firmaDigital

    End Function
#End Region

End Class

