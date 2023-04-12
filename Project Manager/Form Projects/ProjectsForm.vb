Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ProjectsForm

    Private Sub ProjectsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QryStr = "SELECT * FROM project_management_system.customer_projects;"
            Dim Search As New MySqlDataAdapter(QryStr, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "customer_projects")
            DataGridView1.DataSource = ds.Tables("customer_projects")
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV file|*.csv"
        saveFileDialog1.Title = "Save an CSV File"
        saveFileDialog1.ShowDialog()


        If saveFileDialog1.FileName <> "" Then
            Dim cmd As New MySqlCommand("SELECT * FROM projects", myconn)
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
End Class