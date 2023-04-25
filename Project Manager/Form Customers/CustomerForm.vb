Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class CustomerForm
    Private txtFilePath As Object

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Dim QryStr = "SELECT * FROM project_management_system.customer;"
            Dim Search As New MySqlDataAdapter(QryStr, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "customer")
            DataGridView1.DataSource = ds.Tables("customer")
            myconn.Close()

            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            DataGridView1.Columns(DataGridView1.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
            myconn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CustomerProjectViewForm.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Show the OpenFileDialog
        Dim openFileDialog1 As New OpenFileDialog()

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim filePath As String = openFileDialog1.FileName

            ' Move the file to the specified directory
            Dim fileName As String = Path.GetFileName(filePath)
            Dim destinationPath As String = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads\" & fileName
            File.Move(filePath, destinationPath)

            ' Display a success message
            MessageBox.Show("File moved successfully.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Show the OpenFileDialog
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "C:\ProgramData\MySQL\MySQL Server 8.0\Uploads"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Set up the OpenFileDialog
            Dim openFileDialog2 As New OpenFileDialog()
            openFileDialog2.Filter = "CSV Files (*.csv)|*.csv"
            openFileDialog2.Title = "Select a CSV File"

            ' Show the OpenFileDialog and get the result
            Dim result As DialogResult = openFileDialog2.ShowDialog()

            ' If the user selected a file, move it to the Uploads directory and import the data into the database
            If result = DialogResult.OK Then

                Dim filePath As String = openFileDialog2.FileName

                ' Move the file to the Uploads directory
                Dim uploadsPath As String = "C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/"
                Dim fileName As String = Path.GetFileName(filePath)
                File.Move(filePath, Path.Combine(uploadsPath, fileName))


                ' Set up the MySQL command
                Dim commandText As String = "LOAD DATA INFILE '" & Path.Combine(uploadsPath, fileName) & "' INTO TABLE customer FIELDS TERMINATED BY ',' LINES TERMINATED BY '\r\n' IGNORE 1 ROWS (customer_name,email,phone_number,address)"

                Dim cmd As MySqlCommand = New MySqlCommand(commandText)
                cmd.Connection = myconn
                myconn.Open()
                cmd.ExecuteNonQuery()


                ' Display a message box to indicate that the import is complete
                MessageBox.Show("Data import complete.")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim insertSql As String = "INSERT INTO `project_management_system`.`customer` (`customer_name`, `email`, `phone_number`, `address`) VALUES (@Name, @Email, @Number, @Address)"

            Using cmd As New MySqlCommand(insertSql, myconn)
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Email", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Number", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
                myconn.Open()
                cmd.ExecuteNonQuery()
                myconn.Close()
            End Using
            MessageBox.Show("Data inserted successfully.")
        Catch ex As MySqlException
            Select Case ex.Number
                Case 1062 ' Duplicate entry error
                    MessageBox.Show("Already exists.")
                Case Else ' Other errors
                    MessageBox.Show("Error: " & ex.Message)
            End Select
            myconn.Close()
        End Try
        CustomerForm_Load(sender, e)

        ' Clear the text boxes after inserting data
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'Get the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

        'Check if a row is selected
        If Not selectedRow Is Nothing Then
            'Get the ID of the selected row
            Dim id As Integer = selectedRow.Cells("id").Value

            'Prompt the user for confirmation before deleting
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Create the SQL DELETE statement
                Dim deleteSql As String = "DELETE FROM customer WHERE id = @Id"

                'Execute the SQL DELETE statement
                Using cmd As New MySqlCommand(deleteSql, myconn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    myconn.Open()
                    cmd.ExecuteNonQuery()
                    myconn.Close()
                End Using

                'Refresh the DataGridView to remove the deleted row
                CustomerForm_Load(sender, e)
                MessageBox.Show("Record deleted successfully.")
            End If
        Else
            MessageBox.Show("Please select a record to delete.")
        End If
    End Sub

    Private Sub editCustomer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles editCustomer.LinkClicked
        FormCustomerSrch.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        CustomerForm_Load(sender, e)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV file|*.csv"
        saveFileDialog1.Title = "Save an CSV File"
        saveFileDialog1.ShowDialog()


        If saveFileDialog1.FileName <> "" Then
            Dim cmd As New MySqlCommand("SELECT * FROM customer", myconn)
            Dim dataAdapter As New MySqlDataAdapter(cmd)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)

            Dim csv As New StringBuilder()

            For Each row As DataRow In dataTable.Rows
                Dim fields = row.ItemArray.Select(Function(field) field.ToString()).ToArray()
                csv.AppendLine(String.Join(",", fields))
            Next


            File.WriteAllText(saveFileDialog1.FileName, csv.ToString())

            MsgBox("Data exported to " & saveFileDialog1.FileName & " successfully!")
        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel("Customer List", Me.DataGridView1, "samplereport.xlsx")
    End Sub
End Class