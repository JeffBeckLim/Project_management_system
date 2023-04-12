Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient

Public Class LogInForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from employees where username = '" _
                & .usernameTxtBx.Text & "' and employee_password = md5('" _
                & .passwordTxtBx.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                myreader.Close()
                MenuForm.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub usernameTxtBx_TextChanged(sender As Object, e As EventArgs) Handles usernameTxtBx.TextChanged

    End Sub

    Private Sub passwordTxtBx_TextChanged(sender As Object, e As EventArgs) Handles passwordTxtBx.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

End Class
