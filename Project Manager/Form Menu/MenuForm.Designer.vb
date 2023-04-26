<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.ProjectsBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pickerDate = New System.Windows.Forms.DateTimePicker()
        Me.formDescrption = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddJobOrder = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.formProjectID = New System.Windows.Forms.ComboBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.printBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectsBtn
        '
        Me.ProjectsBtn.BackgroundImage = Global.Project_Manager.My.Resources.Resources.ButtonGradientBgJPG
        Me.ProjectsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProjectsBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta
        Me.ProjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProjectsBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProjectsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProjectsBtn.Location = New System.Drawing.Point(21, 87)
        Me.ProjectsBtn.Name = "ProjectsBtn"
        Me.ProjectsBtn.Size = New System.Drawing.Size(311, 45)
        Me.ProjectsBtn.TabIndex = 0
        Me.ProjectsBtn.Text = "Projects                                      💼"
        Me.ProjectsBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Project_Manager.My.Resources.Resources.ButtonGradientBgJPG
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(338, 87)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Customers                👥"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Project_Manager.My.Resources.Resources.ButtonGradientBgJPG
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(523, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Employee                ✏️"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(21, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(681, 560)
        Me.DataGridView1.TabIndex = 4
        '
        'pickerDate
        '
        Me.pickerDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.pickerDate.Location = New System.Drawing.Point(738, 190)
        Me.pickerDate.Name = "pickerDate"
        Me.pickerDate.Size = New System.Drawing.Size(303, 27)
        Me.pickerDate.TabIndex = 11
        '
        'formDescrption
        '
        Me.formDescrption.BackColor = System.Drawing.SystemColors.HighlightText
        Me.formDescrption.Location = New System.Drawing.Point(738, 244)
        Me.formDescrption.Name = "formDescrption"
        Me.formDescrption.Size = New System.Drawing.Size(303, 83)
        Me.formDescrption.TabIndex = 12
        Me.formDescrption.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(738, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Select Project"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(738, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Date and Time of Order"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(738, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Project Description"
        '
        'btnAddJobOrder
        '
        Me.btnAddJobOrder.BackgroundImage = Global.Project_Manager.My.Resources.Resources.ButtonGradientBgJPG
        Me.btnAddJobOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddJobOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta
        Me.btnAddJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddJobOrder.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddJobOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddJobOrder.Location = New System.Drawing.Point(738, 345)
        Me.btnAddJobOrder.Name = "btnAddJobOrder"
        Me.btnAddJobOrder.Size = New System.Drawing.Size(303, 33)
        Me.btnAddJobOrder.TabIndex = 17
        Me.btnAddJobOrder.Text = "Add + "
        Me.btnAddJobOrder.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(210, 155)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(162, 20)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "See finished Job orders"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumOrchid
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(738, 684)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(312, 57)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "BACK-UP DATABASE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'formProjectID
        '
        Me.formProjectID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.formProjectID.FormattingEnabled = True
        Me.formProjectID.Location = New System.Drawing.Point(738, 124)
        Me.formProjectID.Name = "formProjectID"
        Me.formProjectID.Size = New System.Drawing.Size(303, 28)
        Me.formProjectID.TabIndex = 10
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Showcard Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(648, 9)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(54, 53)
        Me.LinkLabel3.TabIndex = 62
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "↻"
        '
        'printBtn
        '
        Me.printBtn.BackgroundImage = Global.Project_Manager.My.Resources.Resources.ButtonGradientBgJPG
        Me.printBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.printBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta
        Me.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtn.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.printBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.printBtn.Location = New System.Drawing.Point(523, 138)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(179, 37)
        Me.printBtn.TabIndex = 63
        Me.printBtn.Text = "Print"
        Me.printBtn.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1062, 753)
        Me.Controls.Add(Me.printBtn)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnAddJobOrder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.formDescrption)
        Me.Controls.Add(Me.pickerDate)
        Me.Controls.Add(Me.formProjectID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProjectsBtn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1080, 800)
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1080, 800)
        Me.Name = "MenuForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Manager - menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectsBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pickerDate As DateTimePicker
    Friend WithEvents formDescrption As RichTextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents btnAddJobOrder As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button4 As Button
    Friend WithEvents formProjectID As ComboBox
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents printBtn As Button
End Class
