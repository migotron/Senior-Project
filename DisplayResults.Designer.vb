<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisplayResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayResults))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FATSb = New System.Windows.Forms.Button()
        Me.Carbsb = New System.Windows.Forms.Button()
        Me.PROTEINb = New System.Windows.Forms.Button()
        Me.DCIb = New System.Windows.Forms.Button()
        Me.BFPb = New System.Windows.Forms.Button()
        Me.LBMb = New System.Windows.Forms.Button()
        Me.BMRb = New System.Windows.Forms.Button()
        Me.IBWb = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WorkoutButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BMItext = New System.Windows.Forms.TextBox()
        Me.UserInfoMessage = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calculated = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkRed
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(3, 328)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(137, 32)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Select any you'd like:"
        '
        'FATSb
        '
        Me.FATSb.BackColor = System.Drawing.Color.Crimson
        Me.FATSb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FATSb.ForeColor = System.Drawing.Color.White
        Me.FATSb.Location = New System.Drawing.Point(1, 655)
        Me.FATSb.Name = "FATSb"
        Me.FATSb.Size = New System.Drawing.Size(139, 34)
        Me.FATSb.TabIndex = 13
        Me.FATSb.Text = "Fats"
        Me.FATSb.UseVisualStyleBackColor = False
        Me.FATSb.Visible = False
        '
        'Carbsb
        '
        Me.Carbsb.BackColor = System.Drawing.Color.Crimson
        Me.Carbsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carbsb.ForeColor = System.Drawing.Color.White
        Me.Carbsb.Location = New System.Drawing.Point(1, 577)
        Me.Carbsb.Name = "Carbsb"
        Me.Carbsb.Size = New System.Drawing.Size(139, 34)
        Me.Carbsb.TabIndex = 12
        Me.Carbsb.Text = "Carbs"
        Me.Carbsb.UseVisualStyleBackColor = False
        Me.Carbsb.Visible = False
        '
        'PROTEINb
        '
        Me.PROTEINb.BackColor = System.Drawing.Color.Crimson
        Me.PROTEINb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROTEINb.ForeColor = System.Drawing.Color.White
        Me.PROTEINb.Location = New System.Drawing.Point(1, 617)
        Me.PROTEINb.Name = "PROTEINb"
        Me.PROTEINb.Size = New System.Drawing.Size(139, 34)
        Me.PROTEINb.TabIndex = 11
        Me.PROTEINb.Text = "Protein"
        Me.PROTEINb.UseVisualStyleBackColor = False
        Me.PROTEINb.Visible = False
        '
        'DCIb
        '
        Me.DCIb.BackColor = System.Drawing.Color.Green
        Me.DCIb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DCIb.ForeColor = System.Drawing.Color.White
        Me.DCIb.Location = New System.Drawing.Point(1, 537)
        Me.DCIb.Name = "DCIb"
        Me.DCIb.Size = New System.Drawing.Size(139, 34)
        Me.DCIb.TabIndex = 10
        Me.DCIb.Text = "Daily Caloric Intake"
        Me.DCIb.UseVisualStyleBackColor = False
        '
        'BFPb
        '
        Me.BFPb.BackColor = System.Drawing.Color.DarkMagenta
        Me.BFPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFPb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BFPb.Location = New System.Drawing.Point(1, 497)
        Me.BFPb.Name = "BFPb"
        Me.BFPb.Size = New System.Drawing.Size(139, 34)
        Me.BFPb.TabIndex = 9
        Me.BFPb.Text = "Body Fat %"
        Me.BFPb.UseVisualStyleBackColor = False
        '
        'LBMb
        '
        Me.LBMb.BackColor = System.Drawing.Color.DarkMagenta
        Me.LBMb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBMb.Location = New System.Drawing.Point(1, 457)
        Me.LBMb.Name = "LBMb"
        Me.LBMb.Size = New System.Drawing.Size(139, 34)
        Me.LBMb.TabIndex = 8
        Me.LBMb.Text = "Lean Body Mass"
        Me.LBMb.UseVisualStyleBackColor = False
        '
        'BMRb
        '
        Me.BMRb.BackColor = System.Drawing.Color.DarkMagenta
        Me.BMRb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMRb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BMRb.Location = New System.Drawing.Point(1, 406)
        Me.BMRb.Name = "BMRb"
        Me.BMRb.Size = New System.Drawing.Size(139, 45)
        Me.BMRb.TabIndex = 7
        Me.BMRb.Text = "Basal Metabolic Rate"
        Me.BMRb.UseVisualStyleBackColor = False
        '
        'IBWb
        '
        Me.IBWb.BackColor = System.Drawing.Color.DarkMagenta
        Me.IBWb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBWb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IBWb.Location = New System.Drawing.Point(1, 366)
        Me.IBWb.Name = "IBWb"
        Me.IBWb.Size = New System.Drawing.Size(139, 34)
        Me.IBWb.TabIndex = 6
        Me.IBWb.Text = "Ideal Body Weight"
        Me.IBWb.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.Location = New System.Drawing.Point(731, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 82)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "View Charts To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Compare BMI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "And Body Fat %"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WorkoutButton
        '
        Me.WorkoutButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WorkoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkoutButton.ForeColor = System.Drawing.Color.Red
        Me.WorkoutButton.Location = New System.Drawing.Point(1207, 654)
        Me.WorkoutButton.Name = "WorkoutButton"
        Me.WorkoutButton.Size = New System.Drawing.Size(144, 40)
        Me.WorkoutButton.TabIndex = 5
        Me.WorkoutButton.Text = "View Workout"
        Me.WorkoutButton.UseVisualStyleBackColor = False
        Me.WorkoutButton.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(857, 300)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(493, 391)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'BMItext
        '
        Me.BMItext.BackColor = System.Drawing.Color.Blue
        Me.BMItext.ForeColor = System.Drawing.Color.Yellow
        Me.BMItext.Location = New System.Drawing.Point(731, 258)
        Me.BMItext.Multiline = True
        Me.BMItext.Name = "BMItext"
        Me.BMItext.ReadOnly = True
        Me.BMItext.Size = New System.Drawing.Size(620, 62)
        Me.BMItext.TabIndex = 2
        Me.BMItext.Visible = False
        '
        'UserInfoMessage
        '
        Me.UserInfoMessage.BackColor = System.Drawing.Color.Gold
        Me.UserInfoMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfoMessage.ForeColor = System.Drawing.Color.Blue
        Me.UserInfoMessage.Location = New System.Drawing.Point(10, 7)
        Me.UserInfoMessage.Margin = New System.Windows.Forms.Padding(4)
        Me.UserInfoMessage.Multiline = True
        Me.UserInfoMessage.Name = "UserInfoMessage"
        Me.UserInfoMessage.ReadOnly = True
        Me.UserInfoMessage.Size = New System.Drawing.Size(709, 311)
        Me.UserInfoMessage.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(731, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(619, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'calculated
        '
        Me.calculated.BackColor = System.Drawing.Color.Gold
        Me.calculated.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculated.ForeColor = System.Drawing.Color.Blue
        Me.calculated.Location = New System.Drawing.Point(145, 321)
        Me.calculated.Margin = New System.Windows.Forms.Padding(4)
        Me.calculated.Multiline = True
        Me.calculated.Name = "calculated"
        Me.calculated.ReadOnly = True
        Me.calculated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.calculated.Size = New System.Drawing.Size(711, 372)
        Me.calculated.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(857, 640)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 53)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Save Information"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DisplayResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1354, 695)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FATSb)
        Me.Controls.Add(Me.Carbsb)
        Me.Controls.Add(Me.PROTEINb)
        Me.Controls.Add(Me.DCIb)
        Me.Controls.Add(Me.BFPb)
        Me.Controls.Add(Me.LBMb)
        Me.Controls.Add(Me.BMRb)
        Me.Controls.Add(Me.IBWb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WorkoutButton)
        Me.Controls.Add(Me.calculated)
        Me.Controls.Add(Me.BMItext)
        Me.Controls.Add(Me.UserInfoMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DisplayResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Virtual Personal Health and Fitness Advisor! - Results Display"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FATSb As Button
    Friend WithEvents Carbsb As Button
    Friend WithEvents PROTEINb As Button
    Friend WithEvents DCIb As Button
    Friend WithEvents BFPb As Button
    Friend WithEvents LBMb As Button
    Friend WithEvents BMRb As Button
    Friend WithEvents IBWb As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents WorkoutButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BMItext As TextBox
    Friend WithEvents UserInfoMessage As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents calculated As TextBox
    Friend WithEvents Button2 As Button
End Class
