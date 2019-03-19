<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoalSelectionModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoalSelectionModule))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LoseWeightGoal = New System.Windows.Forms.RadioButton()
        Me.GainMuscleGoal = New System.Windows.Forms.RadioButton()
        Me.OlympicEnduranceGoal = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(878, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 401)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(443, 143)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(429, 401)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 143)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(429, 401)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'LoseWeightGoal
        '
        Me.LoseWeightGoal.Appearance = System.Windows.Forms.Appearance.Button
        Me.LoseWeightGoal.AutoCheck = False
        Me.LoseWeightGoal.BackColor = System.Drawing.Color.Gold
        Me.LoseWeightGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoseWeightGoal.ForeColor = System.Drawing.Color.Blue
        Me.LoseWeightGoal.Location = New System.Drawing.Point(167, 550)
        Me.LoseWeightGoal.Name = "LoseWeightGoal"
        Me.LoseWeightGoal.Size = New System.Drawing.Size(131, 72)
        Me.LoseWeightGoal.TabIndex = 3
        Me.LoseWeightGoal.TabStop = True
        Me.LoseWeightGoal.Text = "Lose Weight"
        Me.LoseWeightGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LoseWeightGoal.UseVisualStyleBackColor = False
        '
        'GainMuscleGoal
        '
        Me.GainMuscleGoal.Appearance = System.Windows.Forms.Appearance.Button
        Me.GainMuscleGoal.AutoCheck = False
        Me.GainMuscleGoal.BackColor = System.Drawing.Color.Gold
        Me.GainMuscleGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GainMuscleGoal.ForeColor = System.Drawing.Color.Blue
        Me.GainMuscleGoal.Location = New System.Drawing.Point(606, 550)
        Me.GainMuscleGoal.Name = "GainMuscleGoal"
        Me.GainMuscleGoal.Size = New System.Drawing.Size(130, 72)
        Me.GainMuscleGoal.TabIndex = 4
        Me.GainMuscleGoal.TabStop = True
        Me.GainMuscleGoal.Text = "Gain Muscle"
        Me.GainMuscleGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GainMuscleGoal.UseVisualStyleBackColor = False
        '
        'OlympicEnduranceGoal
        '
        Me.OlympicEnduranceGoal.Appearance = System.Windows.Forms.Appearance.Button
        Me.OlympicEnduranceGoal.AutoCheck = False
        Me.OlympicEnduranceGoal.BackColor = System.Drawing.Color.Gold
        Me.OlympicEnduranceGoal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OlympicEnduranceGoal.ForeColor = System.Drawing.Color.Blue
        Me.OlympicEnduranceGoal.Location = New System.Drawing.Point(1035, 550)
        Me.OlympicEnduranceGoal.Name = "OlympicEnduranceGoal"
        Me.OlympicEnduranceGoal.Size = New System.Drawing.Size(179, 72)
        Me.OlympicEnduranceGoal.TabIndex = 5
        Me.OlympicEnduranceGoal.TabStop = True
        Me.OlympicEnduranceGoal.Text = "Olympic Endurance"
        Me.OlympicEnduranceGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OlympicEnduranceGoal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(707, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "What is your fitness goal? Select one of the following three: "
        '
        'GoalSelectionModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1314, 630)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OlympicEnduranceGoal)
        Me.Controls.Add(Me.GainMuscleGoal)
        Me.Controls.Add(Me.LoseWeightGoal)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "GoalSelectionModule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Personal Health and Training Advisor! - Goal Selection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LoseWeightGoal As RadioButton
    Friend WithEvents GainMuscleGoal As RadioButton
    Friend WithEvents OlympicEnduranceGoal As RadioButton
    Friend WithEvents Label1 As Label
End Class
