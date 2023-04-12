<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogInForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim LogInBtn As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInForm))
        Me.usernameTxtBx = New System.Windows.Forms.TextBox()
        Me.passwordTxtBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        LogInBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogInBtn
        '
        LogInBtn.BackColor = System.Drawing.Color.White
        LogInBtn.BackgroundImage = CType(resources.GetObject("LogInBtn.BackgroundImage"), System.Drawing.Image)
        LogInBtn.Cursor = System.Windows.Forms.Cursors.Hand
        LogInBtn.FlatAppearance.BorderSize = 0
        LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        LogInBtn.Font = New System.Drawing.Font("Segoe UI Historic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        LogInBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        LogInBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        LogInBtn.Location = New System.Drawing.Point(443, 272)
        LogInBtn.Name = "LogInBtn"
        LogInBtn.Size = New System.Drawing.Size(285, 31)
        LogInBtn.TabIndex = 2
        LogInBtn.Text = "Log in "
        LogInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        LogInBtn.UseVisualStyleBackColor = False
        AddHandler LogInBtn.Click, AddressOf Me.Button1_Click
        '
        'usernameTxtBx
        '
        Me.usernameTxtBx.BackColor = System.Drawing.SystemColors.HighlightText
        Me.usernameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernameTxtBx.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.usernameTxtBx.Location = New System.Drawing.Point(443, 178)
        Me.usernameTxtBx.Name = "usernameTxtBx"
        Me.usernameTxtBx.Size = New System.Drawing.Size(285, 20)
        Me.usernameTxtBx.TabIndex = 0
        '
        'passwordTxtBx
        '
        Me.passwordTxtBx.BackColor = System.Drawing.SystemColors.HighlightText
        Me.passwordTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordTxtBx.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.passwordTxtBx.Location = New System.Drawing.Point(443, 225)
        Me.passwordTxtBx.Name = "passwordTxtBx"
        Me.passwordTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.passwordTxtBx.Size = New System.Drawing.Size(285, 20)
        Me.passwordTxtBx.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(443, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(443, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(LogInBtn)
        Me.Controls.Add(Me.usernameTxtBx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passwordTxtBx)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "LogInForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameTxtBx As TextBox
    Friend WithEvents passwordTxtBx As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
