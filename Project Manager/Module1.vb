
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Module Module1
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String
    Public strSQL As String



    Public currentDate As DateTime = DateTime.Now
    Public strpassword As String = "user"


    Public xlsPath As String = IO.Directory.GetCurrentDirectory & "\..\..\..\dataXls\template\"
    Public xlsFiles As String = IO.Directory.GetCurrentDirectory & "\..\..\..\dataXls\"


    'changed the directory to the exact directory since it has problems locating it. 
    'Public xlsPath As String = "C:\Users\limje\source\repos\project_management_system\Project Manager\dataXLS\Template\"
    'Public xlsFiles As String = "C:\Users\limje\source\repos\project_management_system\Project Manager\dataXLS\"

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=password;" _
                    & "database=Project_management_system"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.ConnectionString = myConnectionString
            myconn.Open()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub


    Public Sub importToExcel(ByVal heading As String, ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)
        'xlsCell = xlsSheet.Range("A1")
        'xlsSheet.Cells(3, 1) = strfilter
        xlsSheet.Cells(4, 1) = heading
        Dim x, y As Integer
        For i = 0 To mydg.ColumnCount - 1
            With xlsSheet.Cells(5, i + 1)

            End With
            xlsSheet.Cells(5, i + 1) = mydg.Columns(i).Name
        Next


        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                xlsSheet.Cells(x + 6, y + 1) = mydg.Rows(x).Cells(y).Value
            Next
        Next
        With xlsSheet.Range(convertToLetters(1) & 5, convertToLetters(mydg.ColumnCount) & x + 4)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        End With

        xlsSheet.Columns.AutoFit()

        'xlsSheet.Cells(1, 1) = "Mike"
        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("mm-dd-yy hh-mm-ss") & ".xlsx"
        MsgBox(myfilename)
        xlsSheet.Protect(strpassword)
        'xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)


        ' System.Diagnostics.Process.Start("excel.exe", """" & "C:\Users\limje\source\repos\project_management_system\Project Manager\dataXLS\" & myfilename & """")
        'System.Diagnostics.Process.Start("C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE", """" & "C:\Users\limje\source\repos\project_management_system\Project Manager\dataXLS\" & myfilename & """")
        Process.Start("EXCEL.EXE", """" + xlsFiles + myfilename + """")

    End Sub

    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub


End Module
