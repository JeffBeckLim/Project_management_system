Imports MySql.Data.MySqlClient

Public Class MenuForm
    Dim projectList As New Dictionary(Of String, Integer)
    Dim employeeList As New Dictionary(Of String, Integer)
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QryStr = "SELECT * FROM project_management_system.job_orders;"
            Dim Search As New MySqlDataAdapter(QryStr, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "job_orders")
            DataGridView1.DataSource = ds.Tables("job_orders")
            myconn.Close()

            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            DataGridView1.Columns(DataGridView1.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message)
            myconn.Close()
        End Try

        Try
            myconn.Open()

            'Populate the Project Selector with Projects Table Data
            Dim projQryStr As String = "SELECT * FROM project_management_system.projects;"
            Dim projSearch As New MySqlCommand(projQryStr, myconn)
            Dim projReader As MySqlDataReader = projSearch.ExecuteReader()

            While projReader.Read()
                Dim projId As Integer = projReader("id")
                Dim projName As String = projReader("project_name")
                projectList.Add(projName, projId)
                formProjectID.Items.Add("ID: " & projId & " - " & projName)
            End While
            projReader.Close()
            pickerDate.Value = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
            myconn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        EmployeeForm.Show()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formProjectID.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles pickerDate.ValueChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles formDescrption.TextChanged

    End Sub

    Private Sub ProjectsBtn_Click(sender As Object, e As EventArgs) Handles ProjectsBtn.Click
        Me.Hide()
        ProjectsForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        CustomerForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FinishedJOForm.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        Dim result As DialogResult = backup.ShowDialog()

        If result = DialogResult.OK Then
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            myconn.Open()

            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)

            myconn.Close()

            MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
    End Sub

    Private Sub btnAddJobOrder_Click(sender As Object, e As EventArgs) Handles btnAddJobOrder.Click
        Try
            myconn.Open()
            'Insert data into job_orders table
            Dim jobQryStr As String = "INSERT INTO project_management_system.job_orders (Projects_id, order_date, description) VALUES (@projectId, @orderDate, @description);"
            Dim jobInsert As New MySqlCommand(jobQryStr, myconn)

            'Set parameter values
            jobInsert.Parameters.AddWithValue("@projectId", projectList(formProjectID.Text.Split("-")(1).Trim()))
            jobInsert.Parameters.AddWithValue("@orderDate", pickerDate.Value.ToString("yyyy-MM-dd"))
            jobInsert.Parameters.AddWithValue("@description", formDescrption.Text)

            'Execute the query
            jobInsert.ExecuteNonQuery()

            'Show success message
            MsgBox("Job Order Added Successfully!")
            myconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            myconn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MenuForm_Load(sender, e)
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        Call importToExcel("Job Orders", Me.DataGridView1, "samplereportJobOrder.xlsx")
    End Sub

    Private Sub MenuForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LogInForm.Close()

    End Sub
End Class