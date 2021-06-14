<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrame))
        Me.TXT_User = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_Pass = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BTN_Login = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_Time = New System.Windows.Forms.Label()
        Me.LBL_Date = New System.Windows.Forms.Label()
        Me.LBL_IDNum = New System.Windows.Forms.Label()
        Me.LBL_Count = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_User
        '
        Me.TXT_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.TXT_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_User.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_User.ForeColor = System.Drawing.Color.White
        Me.TXT_User.Location = New System.Drawing.Point(30, 251)
        Me.TXT_User.Name = "TXT_User"
        Me.TXT_User.Size = New System.Drawing.Size(234, 22)
        Me.TXT_User.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.E_Trasnport_System.My.Resources.Resources.Logo__light_
        Me.PictureBox1.Location = New System.Drawing.Point(30, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TXT_Pass
        '
        Me.TXT_Pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.TXT_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Pass.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Pass.ForeColor = System.Drawing.Color.White
        Me.TXT_Pass.Location = New System.Drawing.Point(30, 311)
        Me.TXT_Pass.Name = "TXT_Pass"
        Me.TXT_Pass.Size = New System.Drawing.Size(234, 22)
        Me.TXT_Pass.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(143, 339)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 22)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BTN_Login
        '
        Me.BTN_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BTN_Login.FlatAppearance.BorderSize = 0
        Me.BTN_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Login.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Login.ForeColor = System.Drawing.Color.White
        Me.BTN_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Login.Location = New System.Drawing.Point(69, 399)
        Me.BTN_Login.Name = "BTN_Login"
        Me.BTN_Login.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Login.TabIndex = 23
        Me.BTN_Login.Text = "Login"
        Me.BTN_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Login.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(26, 226)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(80, 22)
        Me.lblHeader.TabIndex = 25
        Me.lblHeader.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Password"
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(-12, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 10)
        Me.Label5.TabIndex = 31
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 481)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(300, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 30
        Me.ProgressBar1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(30, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 3)
        Me.Label2.TabIndex = 117
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(30, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 3)
        Me.Label3.TabIndex = 118
        '
        'Timer2
        '
        '
        'LBL_Time
        '
        Me.LBL_Time.BackColor = System.Drawing.Color.Silver
        Me.LBL_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Time.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Time.Location = New System.Drawing.Point(12, 440)
        Me.LBL_Time.Name = "LBL_Time"
        Me.LBL_Time.Size = New System.Drawing.Size(28, 26)
        Me.LBL_Time.TabIndex = 120
        Me.LBL_Time.Visible = False
        '
        'LBL_Date
        '
        Me.LBL_Date.BackColor = System.Drawing.Color.Silver
        Me.LBL_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Date.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Date.Location = New System.Drawing.Point(12, 367)
        Me.LBL_Date.Name = "LBL_Date"
        Me.LBL_Date.Size = New System.Drawing.Size(28, 26)
        Me.LBL_Date.TabIndex = 119
        Me.LBL_Date.Visible = False
        '
        'LBL_IDNum
        '
        Me.LBL_IDNum.BackColor = System.Drawing.Color.Silver
        Me.LBL_IDNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_IDNum.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDNum.Location = New System.Drawing.Point(78, 367)
        Me.LBL_IDNum.Name = "LBL_IDNum"
        Me.LBL_IDNum.Size = New System.Drawing.Size(105, 26)
        Me.LBL_IDNum.TabIndex = 121
        Me.LBL_IDNum.Visible = False
        '
        'LBL_Count
        '
        Me.LBL_Count.BackColor = System.Drawing.Color.Silver
        Me.LBL_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_Count.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Count.Location = New System.Drawing.Point(78, 441)
        Me.LBL_Count.Name = "LBL_Count"
        Me.LBL_Count.Size = New System.Drawing.Size(93, 26)
        Me.LBL_Count.TabIndex = 122
        Me.LBL_Count.Text = "0"
        Me.LBL_Count.Visible = False
        '
        'LoginFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(290, 506)
        Me.Controls.Add(Me.LBL_Count)
        Me.Controls.Add(Me.LBL_IDNum)
        Me.Controls.Add(Me.LBL_Time)
        Me.Controls.Add(Me.LBL_Date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTN_Login)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TXT_Pass)
        Me.Controls.Add(Me.TXT_User)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_User As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXT_Pass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BTN_Login As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LBL_Time As Label
    Friend WithEvents LBL_Date As Label
    Friend WithEvents LBL_IDNum As Label
    Friend WithEvents LBL_Count As Label
End Class
