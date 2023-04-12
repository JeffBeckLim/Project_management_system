Imports MySql.Data.MySqlClient

Public Class CustomerProjectViewForm

    Private Sub CustomerProjectViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim QryStr = "SELECT * FROM project_management_system.customer_project_details;"
            Dim Search As New MySqlDataAdapter(QryStr, myconn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "customer_project_details")
            DataGridView1.DataSource = ds.Tables("customer_project_details")
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

End Class