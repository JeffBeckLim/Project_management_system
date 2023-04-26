Imports MySql.Data.MySqlClient

Public Class FinishedJOForm
    Private Sub FinishedJOForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QryStr = "SELECT * FROM project_management_system.job_finished_details;"
            Dim Search As New MySqlDataAdapter(QryStr, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "job_finished_details")
            DataGridView1.DataSource = ds.Tables("job_finished_details")
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call importToExcel("Finished Job Orders", Me.DataGridView1, "samplereportJobOrderFinished.xlsx")
    End Sub
End Class