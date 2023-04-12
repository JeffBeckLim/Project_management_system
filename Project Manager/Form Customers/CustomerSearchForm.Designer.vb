<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerSrch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labelName = New System.Windows.Forms.Label()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.labelPhonenumber = New System.Windows.Forms.Label()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.formName = New System.Windows.Forms.TextBox()
        Me.formEmail = New System.Windows.Forms.TextBox()
        Me.fromPhonenumber = New System.Windows.Forms.TextBox()
        Me.formAddress = New System.Windows.Forms.TextBox()
        Me.formSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(21, 205)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(49, 20)
        Me.labelName.TabIndex = 0
        Me.labelName.Text = "Name"
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(21, 245)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(46, 20)
        Me.labelEmail.TabIndex = 2
        Me.labelEmail.Text = "Email"
        '
        'labelPhonenumber
        '
        Me.labelPhonenumber.AutoSize = True
        Me.labelPhonenumber.Location = New System.Drawing.Point(21, 288)
        Me.labelPhonenumber.Name = "labelPhonenumber"
        Me.labelPhonenumber.Size = New System.Drawing.Size(105, 20)
        Me.labelPhonenumber.TabIndex = 3
        Me.labelPhonenumber.Text = "Phone number"
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Location = New System.Drawing.Point(21, 321)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(62, 20)
        Me.labelAddress.TabIndex = 4
        Me.labelAddress.Text = "Address"
        '
        'formName
        '
        Me.formName.Location = New System.Drawing.Point(126, 198)
        Me.formName.Name = "formName"
        Me.formName.Size = New System.Drawing.Size(468, 27)
        Me.formName.TabIndex = 6
        '
        'formEmail
        '
        Me.formEmail.Location = New System.Drawing.Point(126, 238)
        Me.formEmail.Name = "formEmail"
        Me.formEmail.Size = New System.Drawing.Size(468, 27)
        Me.formEmail.TabIndex = 7
        '
        'fromPhonenumber
        '
        Me.fromPhonenumber.Location = New System.Drawing.Point(126, 281)
        Me.fromPhonenumber.Name = "fromPhonenumber"
        Me.fromPhonenumber.Size = New System.Drawing.Size(468, 27)
        Me.fromPhonenumber.TabIndex = 8
        '
        'formAddress
        '
        Me.formAddress.Location = New System.Drawing.Point(126, 314)
        Me.formAddress.Name = "formAddress"
        Me.formAddress.Size = New System.Drawing.Size(468, 27)
        Me.formAddress.TabIndex = 9
        '
        'formSearch
        '
        Me.formSearch.Location = New System.Drawing.Point(126, 98)
        Me.formSearch.Name = "formSearch"
        Me.formSearch.Size = New System.Drawing.Size(468, 27)
        Me.formSearch.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Search ID"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Location = New System.Drawing.Point(126, 140)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(468, 29)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.Project_Manager.My.Resources.Resources.ButtonGradientBgJPG
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Snow
        Me.btnUpdate.Location = New System.Drawing.Point(126, 356)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(468, 29)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(209, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 38)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "EDIT CUSTOMER"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(515, 418)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 20)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Go Back"
        '
        'FormCustomerSrch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 473)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.formSearch)
        Me.Controls.Add(Me.formAddress)
        Me.Controls.Add(Me.fromPhonenumber)
        Me.Controls.Add(Me.formEmail)
        Me.Controls.Add(Me.formName)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.labelPhonenumber)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.labelName)
        Me.Name = "FormCustomerSrch"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelName As Windows.Forms.Label
    Friend WithEvents labelEmail As Windows.Forms.Label
    Friend WithEvents labelPhonenumber As Windows.Forms.Label
    Friend WithEvents labelAddress As Windows.Forms.Label
    Friend WithEvents formName As TextBox
    Friend WithEvents formEmail As TextBox
    Friend WithEvents fromPhonenumber As TextBox
    Friend WithEvents formAddress As TextBox
    Friend WithEvents formSearch As TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
