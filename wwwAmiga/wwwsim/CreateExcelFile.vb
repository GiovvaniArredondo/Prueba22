Imports System.Reflection
Imports System.Collections.Generic
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml

Public Class CreateExcelFile
    Public Shared Function CreateExcelDocument(Of T)(ByVal list As List(Of T), ByVal xlsxFilePath As String) As Boolean
        Dim ds As New DataSet()
        ds.Tables.Add(ListToDataTable(list))

        Return CreateExcelDocument(ds, xlsxFilePath)
    End Function


    ' This function is adapated from: http://www.codeguru.com/forum/showthread.php?t=450171
    ' My thanks to Carl Quirion, for making it "nullable-friendly".
    Public Shared Function ListToDataTable(Of T)(ByVal list As List(Of T)) As DataTable

        Dim dt As New DataTable
        Dim row As DataRow
        For Each info As System.Reflection.PropertyInfo In list.GetType().GetProperties()
            dt.Columns.Add(New DataColumn(info.Name, GetNullableType(info.PropertyType)))
        Next

        For Each tValue As T In list

            row = dt.NewRow()
            For Each info As System.Reflection.PropertyInfo In list.GetType().GetProperties()

                If Not IsNullableType(info.PropertyType) Then
                    row(info.Name) = info.GetValue(tValue, Nothing)
                Else
                    row(info.Name) = info.GetValue(tValue, Nothing)
                End If
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function


    Public Shared Function GetNullableType(ByVal t As Type) As Type

        Dim returnType As Type = t

        If (t.IsGenericType Or t.GetGenericTypeDefinition() Is GetType(Nullable(Of ))) Then
            returnType = Nullable.GetUnderlyingType(t)
        End If

        Return returnType

    End Function


    Public Shared Function IsNullableType(ByVal type As Type) As Boolean

        Return (type Is GetType(String) Or
                type.IsArray Or
                (type.IsGenericType And type.GetGenericTypeDefinition() Is GetType(Nullable(Of ))))
    End Function

    Public Shared Function CreateExcelDocument(ByVal dt As DataTable, ByVal xlsxFilePath As String) As Boolean

        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Return CreateExcelDocument(ds, xlsxFilePath)
    End Function

    Public Shared Function CreateExcelDocument(ByVal ds As DataSet, ByVal excelFilename As String) As Boolean
        Try
            Using document As SpreadsheetDocument = SpreadsheetDocument.Create(excelFilename, SpreadsheetDocumentType.Workbook)

                Dim workbook As WorkbookPart = document.AddWorkbookPart

                '                document.AddWorkbookPart()
                document.WorkbookPart.Workbook = New DocumentFormat.OpenXml.Spreadsheet.Workbook()

                '  My thanks to James Miera for the following line of code (which prevents crashes in Excel 2010)
                document.WorkbookPart.Workbook.Append(New BookViews(New WorkbookView()))

                '  If we don't add a "WorkbookStylesPart", OLEDB will refuse to connect to this .xlsx file !
                Dim workbookStylesPart As WorkbookStylesPart = document.WorkbookPart.AddNewPart(Of WorkbookStylesPart)("rIdStyles")

                Dim stylesheet As New Stylesheet
                workbookStylesPart.Stylesheet = stylesheet
                workbookStylesPart.Stylesheet.Save()

                '                Dim sp As WorkbookStylesPart = document.WorkbookPart.AddNewPart(Of WorkbookStylesPart)()

                CreateParts(ds, document)

            End Using
            Trace.WriteLine("Successfully created: " + excelFilename)
            Return True

        Catch ex As Exception
            Trace.WriteLine("Failed, exception thrown: " + ex.Message)
            Return False
        End Try

    End Function

    Private Shared Sub CreateParts(ByVal ds As DataSet, ByVal spreadsheet As SpreadsheetDocument)

        '  Loop through each of the DataTables in our DataSet, and create a new Excel Worksheet for each.
        Dim worksheetNumber As UInt64 = 1
        For Each dt As DataTable In ds.Tables
            '  For each worksheet you want to create
            Dim workSheetID As String = "rId" + worksheetNumber.ToString()
            Dim worksheetName As String = dt.TableName

            Dim newWorksheetPart As WorksheetPart = spreadsheet.WorkbookPart.AddNewPart(Of WorksheetPart)()
            newWorksheetPart.Worksheet = New DocumentFormat.OpenXml.Spreadsheet.Worksheet()

            '  If you want to define the Column Widths, you need to do this *before* appending the SheetData
            '  http://social.msdn.microsoft.com/Forums/en-US/oxmlsdk/thread/1d93eca8-2949-4d12-8dd9-15cc24128b10/
            '
            '  If you want to calculate the column width, it's not easy.  Have a read of this article:
            '  http://polymathprogrammer.com/2010/01/11/custom-column-widths-in-excel-open-xml/
            '

            Dim columnWidthSize As Int32 = 20     ' Replace the following line with your desired Column Width for column # col
            Dim columns As New Columns

            For colInx As Integer = 0 To dt.Columns.Count
                Dim column As Column = CustomColumnWidth(colInx, columnWidthSize)
                columns.Append(column)
            Next
            newWorksheetPart.Worksheet.Append(columns)

            ' create sheet data
            newWorksheetPart.Worksheet.AppendChild(New DocumentFormat.OpenXml.Spreadsheet.SheetData())

            ' save worksheet
            WriteDataTableToExcelWorksheet(dt, newWorksheetPart)
            newWorksheetPart.Worksheet.Save()

            ' create the worksheet to workbook relation
            If (worksheetNumber = 1) Then
                spreadsheet.WorkbookPart.Workbook.AppendChild(New DocumentFormat.OpenXml.Spreadsheet.Sheets())
            End If

            Dim sheet As DocumentFormat.OpenXml.Spreadsheet.Sheet = New DocumentFormat.OpenXml.Spreadsheet.Sheet
            sheet.Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart)
            sheet.SheetId = worksheetNumber
            sheet.Name = dt.TableName
            '            Sheets.Append(sheet)

            spreadsheet.WorkbookPart.Workbook.GetFirstChild(Of DocumentFormat.OpenXml.Spreadsheet.Sheets).Append(sheet)
            ' AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheet()
        Next
    End Sub

    Private Shared Sub WriteDataTableToExcelWorksheet(ByVal dt As DataTable, ByVal worksheetPart As WorksheetPart)

        Dim worksheet As Worksheet = worksheetPart.Worksheet
        Dim sheetData As SheetData = worksheet.GetFirstChild(Of SheetData)()

        Dim cellValue As String = ""

        '  Create a Header Row in our Excel file, containing one header for each Column of data in our DataTable.
        '
        '  We'll also create an array, showing which type each column of data is (Text or Numeric), so when we come to write the actual
        '  cells of data, we'll know if to write Text values or Numeric cell values.
        Dim numberOfColumns As Integer = dt.Columns.Count
        Dim IsNumericColumn(numberOfColumns) As Boolean

        Dim excelColumnNames([numberOfColumns]) As String

        For n As Integer = 0 To numberOfColumns
            excelColumnNames(numberOfColumns) = GetExcelColumnName(n)
        Next n

        '
        '  Create the Header row in our Excel Worksheet
        '
        Dim rowIndex As UInt32 = 1

        Dim headerRow As Row = New Row
        headerRow.RowIndex = rowIndex            ' add a row at the top of spreadsheet
        sheetData.Append(headerRow)

        For colInx As Integer = 0 To numberOfColumns - 1
            Dim col As DataColumn = dt.Columns(colInx)
            AppendTextCell(excelColumnNames(colInx) + "1", col.ColumnName, headerRow)
            IsNumericColumn(colInx) = (col.DataType.FullName = "System.Decimal") Or (col.DataType.FullName = "System.Int32")
        Next

        '
        '  Now, step through each row of data in our DataTable...
        '
        Dim cellNumericValue As Double = 0

        For Each dr As DataRow In dt.Rows
            ' ...create a new row, and append a set of this row's data to it.
            rowIndex = rowIndex + 1
            Dim newExcelRow As New Row
            newExcelRow.RowIndex = rowIndex         '  add a row at the top of spreadsheet
            sheetData.Append(newExcelRow)

            For colInx As Integer = 0 To numberOfColumns - 1
                cellValue = dr.ItemArray(colInx).ToString()

                ' Create cell with data
                If (IsNumericColumn(colInx)) Then
                    '  For numeric cells, make sure our input data IS a number, then write it out to the Excel file.
                    '  If this numeric value is NULL, then don't write anything to the Excel file.
                    cellNumericValue = 0
                    If (Double.TryParse(cellValue, cellNumericValue)) Then
                        cellValue = cellNumericValue.ToString()
                        AppendNumericCell(excelColumnNames(colInx) + rowIndex.ToString(), cellValue, newExcelRow)
                    End If
                Else
                    '  For text cells, just write the input data straight out to the Excel file.
                    AppendTextCell(excelColumnNames(colInx) + rowIndex.ToString(), cellValue, newExcelRow)
                End If
            Next

        Next

    End Sub

    Private Shared Function CustomColumnWidth(ByVal columnIndex As Integer, ByVal columnWidth As Double) As Column
        ' This creates a Column variable for a zero-based column-index (eg 0 = Excel Column A), with a particular column width.
        Dim column As New Column
        column.Min = columnIndex + 1
        column.Max = columnIndex + 1
        column.Width = columnWidth
        column.CustomWidth = True
        Return column
    End Function

    Public Shared Sub AppendTextCell(ByVal cellReference As String, ByVal cellStringValue As String, ByVal excelRow As Row)
        '/  Add a new Excel Cell to our Row 
        Dim cell As New Cell
        cell.CellReference = cellReference
        cell.DataType = CellValues.String

        Dim cellValue As New CellValue
        cellValue.Text = cellStringValue

        cell.Append(cellValue)

        excelRow.Append(cell)
    End Sub

    Public Shared Sub AppendNumericCell(ByVal cellReference As String, ByVal cellStringValue As String, ByVal excelRow As Row)
        '/  Add a new Excel Cell to our Row 
        Dim cell As New Cell
        cell.CellReference = cellReference
        cell.DataType = CellValues.Number

        Dim cellValue As New CellValue
        cellValue.Text = cellStringValue

        cell.Append(cellValue)

        excelRow.Append(cell)
    End Sub

    Public Shared Function GetExcelColumnName(ByVal columnIndex As Integer) As String
        If (columnIndex < 26) Then
            Return Chr(Asc("A") + columnIndex)
        End If

        Dim firstChar As Char,
            secondChar As Char

        firstChar = Chr(Asc("A") + (columnIndex \ 26) - 1)
        secondChar = Chr(Asc("A") + (columnIndex Mod 26))

        Return firstChar + secondChar
    End Function

End Class
