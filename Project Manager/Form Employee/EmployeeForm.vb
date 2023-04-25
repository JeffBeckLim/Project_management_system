Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class EmployeeForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QryStr = "SELECT * FROM project_management_system.employees;"
            Dim Search As New MySqlDataAdapter(QryStr, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "employees")
            DataGridView1.DataSource = ds.Tables("employees")
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'SQL INSERT statement 
            Dim insertSql As String = "INSERT INTO `project_management_system`.`employees` (`employee_name`, `hourly_wage`, `date_hired`, `username`, `employee_password`) VALUES (@Name, @Wage, @DateHired, @Username, md5(@Password));"

            Dim dateHired As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

            'Execute SQL INSERT statement
            Using cmd As New MySqlCommand(insertSql, myconn)
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Wage", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@DateHired", dateHired)
                cmd.Parameters.AddWithValue("@Username", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Password", TextBox3.Text)
                myconn.Open()
                cmd.ExecuteNonQuery()
                myconn.Close()
            End Using
            MessageBox.Show("Data inserted successfully.")
        Catch ex As MySqlException
            Select Case ex.Number
                Case 1062 ' Duplicate entry error
                    MessageBox.Show("Username already exists.")
                Case Else ' Other errors
                    MessageBox.Show("Error: " & ex.Message)
            End Select
            myconn.Close()
        End Try
        Form1_Load(sender, e)

        ' Clear the text boxes after inserting data
        TextBox1.Clear()
        NumericUpDown1.Value = 0
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow

        'Check if a row is selected
        If Not selectedRow Is Nothing Then
            'Get the ID of the selected row
            Dim id As Integer = selectedRow.Cells("id").Value

            'Prompt the user for confirmation before deleting
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Create the SQL DELETE statement
                Dim deleteSql As String = "DELETE FROM employees WHERE id = @Id"

                'Execute SQL DELETE statement
                Using cmd As New MySqlCommand(deleteSql, myconn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    myconn.Open()
                    cmd.ExecuteNonQuery()
                    myconn.Close()
                End Using

                'Refresh  DataGridView to remove the deleted row
                Form1_Load(sender, e)
                MessageBox.Show("Record deleted successfully.")
            End If
        Else
            MessageBox.Show("Please select a record to delete.")
        End If
    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV file|*.csv"
        saveFileDialog1.Title = "Save an CSV File"
        saveFileDialog1.ShowDialog()


        If saveFileDialog1.FileName <> "" Then
            Dim cmd As New MySqlCommand("SELECT * FROM employees", myconn)
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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call importToExcel("Employee List", Me.DataGridView1, "samplereportEmployee.xlsx")
    End Sub
End Class
