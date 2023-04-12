Imports MySql.Data.MySqlClient

Public Class FormCustomerSrch
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim cstId As Integer = Integer.Parse(formSearch.Text)
        Call Connect_to_DB()

        Try
            ' Check if the connection is already open
            If myconn.State = ConnectionState.Closed Then
                ' Open the database connection
                myconn.Open()
            End If

            ' Define the SELECT query to retrieve the employee data
            Dim query As String = "SELECT customer_name, email, phone_number, address FROM customer WHERE id = @id"

            ' Create a new MySqlCommand object
            Dim cmd As New MySqlCommand(query, myconn)

            ' Add the employee ID parameter to the command object
            cmd.Parameters.AddWithValue("@id", cstId)

            ' Execute the query and get the result set
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' If the query returned a row, display the data in the form
            If reader.Read() Then
                formName.Text = reader.GetString("customer_name")
                formEmail.Text = reader.GetString("email")
                fromPhonenumber.Text = reader.GetString("phone_number")
                formAddress.Text = reader.GetString("address")
            Else
                ' If no row was returned, display an error message
                MessageBox.Show("No employee with ID " & cstId & " was found.")
            End If

            ' Close the data reader
            reader.Close()

        Catch ex As Exception
            ' If an exception occurred, display an error message
            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            ' Close the database connection
            myconn.Close()

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelName.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles formName.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles formEmail.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles fromPhonenumber.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles formAddress.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles labelEmail.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles labelPhonenumber.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles labelAddress.Click

    End Sub

    Private Sub formSearch_TextChanged(sender As Object, e As EventArgs) Handles formSearch.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Call Connect_to_DB()

        Try

            If myconn.State = ConnectionState.Closed Then

                myconn.Open()
            End If

            Dim query As String = "UPDATE customer SET customer_name = @name, email = @email, phone_number = @phone, address = @address WHERE id = @id"

            Dim cmd As New MySqlCommand(query, myconn)


            cmd.Parameters.AddWithValue("@name", formName.Text)
            cmd.Parameters.AddWithValue("@email", formEmail.Text)
            cmd.Parameters.AddWithValue("@phone", fromPhonenumber.Text)
            cmd.Parameters.AddWithValue("@address", formAddress.Text)
            cmd.Parameters.AddWithValue("@id", Integer.Parse(formSearch.Text))


            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected = 1 Then
                MessageBox.Show("Customer details updated successfully.")
            Else

                MessageBox.Show("Failed to update customer details.")
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            myconn.Close()
        End Try
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub
End Class
