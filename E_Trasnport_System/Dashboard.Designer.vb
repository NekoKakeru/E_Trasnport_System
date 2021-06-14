<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_OnTrip = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBL_TotalDriver = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBL_TotalPassenger = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LBL_OffTrip = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LBL_LogID = New System.Windows.Forms.Label()
        Me.LBL_IDNum = New System.Windows.Forms.Label()
        Me.LBL_Type = New System.Windows.Forms.Label()
        Me.LBL_Name = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.LBL_Time = New System.Windows.Forms.Label()
        Me.LBL_Date = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBL_OnTrip)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(553, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 100)
        Me.Panel1.TabIndex = 0
        '
        'LBL_OnTrip
        '
        Me.LBL_OnTrip.AutoSize = True
        Me.LBL_OnTrip.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OnTrip.Location = New System.Drawing.Point(360, 19)
        Me.LBL_OnTrip.Name = "LBL_OnTrip"
        Me.LBL_OnTrip.Size = New System.Drawing.Size(38, 47)
        Me.LBL_OnTrip.TabIndex = 9
        Me.LBL_OnTrip.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "On-Trip Tricycle:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.E_Trasnport_System.My.Resources.Resources._on
        Me.PictureBox3.Location = New System.Drawing.Point(21, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LBL_TotalDriver)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(51, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 192)
        Me.Panel2.TabIndex = 1
        '
        'LBL_TotalDriver
        '
        Me.LBL_TotalDriver.AutoSize = True
        Me.LBL_TotalDriver.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TotalDriver.Location = New System.Drawing.Point(276, 39)
        Me.LBL_TotalDriver.Name = "LBL_TotalDriver"
        Me.LBL_TotalDriver.Size = New System.Drawing.Size(38, 47)
        Me.LBL_TotalDriver.TabIndex = 6
        Me.LBL_TotalDriver.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Driver Registered"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.E_Trasnport_System.My.Resources.Resources.driver
        Me.PictureBox2.Location = New System.Drawing.Point(37, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LBL_TotalPassenger)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(588, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(468, 192)
        Me.Panel3.TabIndex = 1
        '
        'LBL_TotalPassenger
        '
        Me.LBL_TotalPassenger.AutoSize = True
        Me.LBL_TotalPassenger.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TotalPassenger.Location = New System.Drawing.Point(288, 39)
        Me.LBL_TotalPassenger.Name = "LBL_TotalPassenger"
        Me.LBL_TotalPassenger.Size = New System.Drawing.Size(38, 47)
        Me.LBL_TotalPassenger.TabIndex = 7
        Me.LBL_TotalPassenger.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Total Passenger Registered"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.E_Trasnport_System.My.Resources.Resources.seat_belt
        Me.PictureBox1.Location = New System.Drawing.Point(37, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LBL_OffTrip)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(51, 341)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(503, 100)
        Me.Panel4.TabIndex = 1
        '
        'LBL_OffTrip
        '
        Me.LBL_OffTrip.AutoSize = True
        Me.LBL_OffTrip.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_OffTrip.Location = New System.Drawing.Point(360, 23)
        Me.LBL_OffTrip.Name = "LBL_OffTrip"
        Me.LBL_OffTrip.Size = New System.Drawing.Size(38, 47)
        Me.LBL_OffTrip.TabIndex = 8
        Me.LBL_OffTrip.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Off-Trip Tricycle:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.E_Trasnport_System.My.Resources.Resources.off
        Me.PictureBox4.Location = New System.Drawing.Point(21, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(66, 63)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.LBL_LogID)
        Me.Panel5.Controls.Add(Me.LBL_IDNum)
        Me.Panel5.Controls.Add(Me.LBL_Type)
        Me.Panel5.Controls.Add(Me.LBL_Name)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.PictureBox7)
        Me.Panel5.Controls.Add(Me.LBL_Time)
        Me.Panel5.Controls.Add(Me.LBL_Date)
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Location = New System.Drawing.Point(51, 477)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1005, 259)
        Me.Panel5.TabIndex = 2
        '
        'LBL_LogID
        '
        Me.LBL_LogID.BackColor = System.Drawing.Color.Silver
        Me.LBL_LogID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_LogID.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LogID.Location = New System.Drawing.Point(580, 218)
        Me.LBL_LogID.Name = "LBL_LogID"
        Me.LBL_LogID.Size = New System.Drawing.Size(341, 26)
        Me.LBL_LogID.TabIndex = 16
        Me.LBL_LogID.Visible = False
        '
        'LBL_IDNum
        '
        Me.LBL_IDNum.BackColor = System.Drawing.Color.Silver
        Me.LBL_IDNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_IDNum.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDNum.Location = New System.Drawing.Point(580, 183)
        Me.LBL_IDNum.Name = "LBL_IDNum"
        Me.LBL_IDNum.Size = New System.Drawing.Size(341, 26)
        Me.LBL_IDNum.TabIndex = 15
        Me.LBL_IDNum.Visible = False
        '
        'LBL_Type
        '
        Me.LBL_Type.BackColor = System.Drawing.Color.Silver
        Me.LBL_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Type.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Type.Location = New System.Drawing.Point(662, 133)
        Me.LBL_Type.Name = "LBL_Type"
        Me.LBL_Type.Size = New System.Drawing.Size(307, 26)
        Me.LBL_Type.TabIndex = 14
        '
        'LBL_Name
        '
        Me.LBL_Name.BackColor = System.Drawing.Color.Silver
        Me.LBL_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Name.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Name.Location = New System.Drawing.Point(628, 91)
        Me.LBL_Name.Name = "LBL_Name"
        Me.LBL_Name.Size = New System.Drawing.Size(341, 26)
        Me.LBL_Name.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(551, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "User Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(551, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Name:"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.E_Trasnport_System.My.Resources.Resources.user1
        Me.PictureBox7.Location = New System.Drawing.Point(449, 79)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(96, 94)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'LBL_Time
        '
        Me.LBL_Time.BackColor = System.Drawing.Color.Silver
        Me.LBL_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Time.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Time.Location = New System.Drawing.Point(108, 154)
        Me.LBL_Time.Name = "LBL_Time"
        Me.LBL_Time.Size = New System.Drawing.Size(224, 26)
        Me.LBL_Time.TabIndex = 11
        '
        'LBL_Date
        '
        Me.LBL_Date.BackColor = System.Drawing.Color.Silver
        Me.LBL_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Date.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Date.Location = New System.Drawing.Point(108, 81)
        Me.LBL_Date.Name = "LBL_Date"
        Me.LBL_Date.Size = New System.Drawing.Size(224, 26)
        Me.LBL_Date.TabIndex = 7
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.E_Trasnport_System.My.Resources.Resources.clock
        Me.PictureBox6.Location = New System.Drawing.Point(21, 140)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.E_Trasnport_System.My.Resources.Resources.calendar
        Me.PictureBox5.Location = New System.Drawing.Point(21, 69)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Timer1
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1114, 811)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_OnTrip As Label
    Friend WithEvents LBL_TotalDriver As Label
    Friend WithEvents LBL_TotalPassenger As Label
    Friend WithEvents LBL_OffTrip As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LBL_Time As Label
    Friend WithEvents LBL_Date As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_Type As Label
    Friend WithEvents LBL_Name As Label
    Friend WithEvents LBL_IDNum As Label
    Friend WithEvents LBL_LogID As Label
End Class
