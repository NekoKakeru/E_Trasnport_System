<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateUserAccount
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateUserAccount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_Comment = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBL_Count = New System.Windows.Forms.Label()
        Me.BTN_GIDNum = New System.Windows.Forms.Button()
        Me.LBL_IDNum = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBL_PIC = New System.Windows.Forms.Label()
        Me.BTN_Next = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBPosition = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_Take = New System.Windows.Forms.Button()
        Me.BTN_Upload = New System.Windows.Forms.Button()
        Me.TXTContactNo = New System.Windows.Forms.TextBox()
        Me.TXTAge = New System.Windows.Forms.TextBox()
        Me.CBGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TXTLast = New System.Windows.Forms.TextBox()
        Me.TXTFirst = New System.Windows.Forms.TextBox()
        Me.TXTMiddle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_Comment1 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LBLUsername = New System.Windows.Forms.Label()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.TXTConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBL_Date = New System.Windows.Forms.Label()
        Me.BTNCreate = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBL_Comment)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.LBL_Count)
        Me.Panel1.Controls.Add(Me.BTN_GIDNum)
        Me.Panel1.Controls.Add(Me.LBL_IDNum)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.LBL_PIC)
        Me.Panel1.Controls.Add(Me.BTN_Next)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBPosition)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTN_Take)
        Me.Panel1.Controls.Add(Me.BTN_Upload)
        Me.Panel1.Controls.Add(Me.TXTContactNo)
        Me.Panel1.Controls.Add(Me.TXTAge)
        Me.Panel1.Controls.Add(Me.CBGender)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.TXTLast)
        Me.Panel1.Controls.Add(Me.TXTFirst)
        Me.Panel1.Controls.Add(Me.TXTMiddle)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 374)
        Me.Panel1.TabIndex = 109
        '
        'LBL_Comment
        '
        Me.LBL_Comment.AutoSize = True
        Me.LBL_Comment.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Comment.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_Comment.Location = New System.Drawing.Point(8, 353)
        Me.LBL_Comment.Name = "LBL_Comment"
        Me.LBL_Comment.Size = New System.Drawing.Size(203, 20)
        Me.LBL_Comment.TabIndex = 126
        Me.LBL_Comment.Text = "The username is generating..."
        Me.LBL_Comment.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(250, 18)
        Me.Label14.TabIndex = 125
        Me.Label14.Text = "Note: The username is automatically generated."
        '
        'LBL_Count
        '
        Me.LBL_Count.AutoSize = True
        Me.LBL_Count.Location = New System.Drawing.Point(524, 280)
        Me.LBL_Count.Name = "LBL_Count"
        Me.LBL_Count.Size = New System.Drawing.Size(13, 13)
        Me.LBL_Count.TabIndex = 124
        Me.LBL_Count.Text = "0"
        Me.LBL_Count.Visible = False
        '
        'BTN_GIDNum
        '
        Me.BTN_GIDNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_GIDNum.FlatAppearance.BorderSize = 0
        Me.BTN_GIDNum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_GIDNum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_GIDNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GIDNum.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GIDNum.ForeColor = System.Drawing.Color.White
        Me.BTN_GIDNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_GIDNum.Location = New System.Drawing.Point(333, 334)
        Me.BTN_GIDNum.Name = "BTN_GIDNum"
        Me.BTN_GIDNum.Size = New System.Drawing.Size(207, 31)
        Me.BTN_GIDNum.TabIndex = 9
        Me.BTN_GIDNum.Text = "Generate ID Number"
        Me.BTN_GIDNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GIDNum.UseVisualStyleBackColor = False
        '
        'LBL_IDNum
        '
        Me.LBL_IDNum.AutoSize = True
        Me.LBL_IDNum.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDNum.Location = New System.Drawing.Point(149, 11)
        Me.LBL_IDNum.Name = "LBL_IDNum"
        Me.LBL_IDNum.Size = New System.Drawing.Size(112, 26)
        Me.LBL_IDNum.TabIndex = 122
        Me.LBL_IDNum.Text = "0000000000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 26)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "ID Number:"
        '
        'LBL_PIC
        '
        Me.LBL_PIC.AutoSize = True
        Me.LBL_PIC.Location = New System.Drawing.Point(527, 246)
        Me.LBL_PIC.Name = "LBL_PIC"
        Me.LBL_PIC.Size = New System.Drawing.Size(13, 13)
        Me.LBL_PIC.TabIndex = 111
        Me.LBL_PIC.Text = "0"
        Me.LBL_PIC.Visible = False
        '
        'BTN_Next
        '
        Me.BTN_Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Next.FlatAppearance.BorderSize = 0
        Me.BTN_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Next.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Next.ForeColor = System.Drawing.Color.White
        Me.BTN_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Next.Location = New System.Drawing.Point(551, 334)
        Me.BTN_Next.Name = "BTN_Next"
        Me.BTN_Next.Size = New System.Drawing.Size(207, 31)
        Me.BTN_Next.TabIndex = 10
        Me.BTN_Next.Text = "Next"
        Me.BTN_Next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Next.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(7, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 2)
        Me.Label1.TabIndex = 116
        '
        'CBPosition
        '
        Me.CBPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBPosition.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPosition.FormattingEnabled = True
        Me.CBPosition.Items.AddRange(New Object() {"Admin", "Non-Admin"})
        Me.CBPosition.Location = New System.Drawing.Point(113, 279)
        Me.CBPosition.Name = "CBPosition"
        Me.CBPosition.Size = New System.Drawing.Size(226, 30)
        Me.CBPosition.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 26)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Postion:"
        '
        'BTN_Take
        '
        Me.BTN_Take.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Take.FlatAppearance.BorderSize = 0
        Me.BTN_Take.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Take.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Take.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Take.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Take.ForeColor = System.Drawing.Color.White
        Me.BTN_Take.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Take.Location = New System.Drawing.Point(571, 266)
        Me.BTN_Take.Name = "BTN_Take"
        Me.BTN_Take.Size = New System.Drawing.Size(163, 31)
        Me.BTN_Take.TabIndex = 8
        Me.BTN_Take.Text = "Take Picture"
        Me.BTN_Take.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Take.UseVisualStyleBackColor = False
        '
        'BTN_Upload
        '
        Me.BTN_Upload.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Upload.FlatAppearance.BorderSize = 0
        Me.BTN_Upload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Upload.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Upload.ForeColor = System.Drawing.Color.White
        Me.BTN_Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Upload.Location = New System.Drawing.Point(571, 229)
        Me.BTN_Upload.Name = "BTN_Upload"
        Me.BTN_Upload.Size = New System.Drawing.Size(163, 31)
        Me.BTN_Upload.TabIndex = 7
        Me.BTN_Upload.Text = "Upload Picture"
        Me.BTN_Upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Upload.UseVisualStyleBackColor = False
        '
        'TXTContactNo
        '
        Me.TXTContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTContactNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTContactNo.Location = New System.Drawing.Point(146, 239)
        Me.TXTContactNo.MaxLength = 11
        Me.TXTContactNo.Name = "TXTContactNo"
        Me.TXTContactNo.Size = New System.Drawing.Size(193, 22)
        Me.TXTContactNo.TabIndex = 6
        '
        'TXTAge
        '
        Me.TXTAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTAge.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAge.Location = New System.Drawing.Point(81, 195)
        Me.TXTAge.MaxLength = 2
        Me.TXTAge.Name = "TXTAge"
        Me.TXTAge.Size = New System.Drawing.Size(258, 22)
        Me.TXTAge.TabIndex = 5
        '
        'CBGender
        '
        Me.CBGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBGender.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBGender.FormattingEnabled = True
        Me.CBGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CBGender.Location = New System.Drawing.Point(113, 139)
        Me.CBGender.Name = "CBGender"
        Me.CBGender.Size = New System.Drawing.Size(226, 30)
        Me.CBGender.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 26)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Contact No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 26)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 26)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Gender:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(553, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(548, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(210, 210)
        Me.Label27.TabIndex = 105
        '
        'TXTLast
        '
        Me.TXTLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTLast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTLast.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLast.Location = New System.Drawing.Point(371, 82)
        Me.TXTLast.Name = "TXTLast"
        Me.TXTLast.Size = New System.Drawing.Size(166, 22)
        Me.TXTLast.TabIndex = 3
        '
        'TXTFirst
        '
        Me.TXTFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTFirst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTFirst.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFirst.Location = New System.Drawing.Point(27, 82)
        Me.TXTFirst.Name = "TXTFirst"
        Me.TXTFirst.Size = New System.Drawing.Size(166, 22)
        Me.TXTFirst.TabIndex = 1
        '
        'TXTMiddle
        '
        Me.TXTMiddle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTMiddle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTMiddle.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMiddle.Location = New System.Drawing.Point(199, 82)
        Me.TXTMiddle.Name = "TXTMiddle"
        Me.TXTMiddle.Size = New System.Drawing.Size(166, 22)
        Me.TXTMiddle.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(240, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Middlename"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(415, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Lastname"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 26)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Personal Information"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.LBL_Date)
        Me.Panel2.Controls.Add(Me.BTNCreate)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(786, 374)
        Me.Panel2.TabIndex = 110
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_Comment1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.LBLUsername)
        Me.GroupBox1.Controls.Add(Me.TXTPassword)
        Me.GroupBox1.Controls.Add(Me.TXTConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(111, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 264)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        '
        'LBL_Comment1
        '
        Me.LBL_Comment1.AutoSize = True
        Me.LBL_Comment1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Comment1.ForeColor = System.Drawing.Color.Red
        Me.LBL_Comment1.Location = New System.Drawing.Point(327, 180)
        Me.LBL_Comment1.Name = "LBL_Comment1"
        Me.LBL_Comment1.Size = New System.Drawing.Size(169, 20)
        Me.LBL_Comment1.TabIndex = 136
        Me.LBL_Comment1.Text = "Password doesn't match"
        Me.LBL_Comment1.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(375, 158)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(121, 22)
        Me.CheckBox2.TabIndex = 135
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(375, 107)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 22)
        Me.CheckBox1.TabIndex = 134
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LBLUsername
        '
        Me.LBLUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBLUsername.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUsername.Location = New System.Drawing.Point(233, 37)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(263, 26)
        Me.LBLUsername.TabIndex = 133
        '
        'TXTPassword
        '
        Me.TXTPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPassword.Location = New System.Drawing.Point(233, 79)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPassword.Size = New System.Drawing.Size(263, 22)
        Me.TXTPassword.TabIndex = 132
        '
        'TXTConfirmPassword
        '
        Me.TXTConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXTConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTConfirmPassword.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTConfirmPassword.Location = New System.Drawing.Point(233, 134)
        Me.TXTConfirmPassword.Name = "TXTConfirmPassword"
        Me.TXTConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTConfirmPassword.Size = New System.Drawing.Size(263, 22)
        Me.TXTConfirmPassword.TabIndex = 131
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 26)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Confirm Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 26)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 26)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Username:"
        '
        'LBL_Date
        '
        Me.LBL_Date.AutoSize = True
        Me.LBL_Date.Location = New System.Drawing.Point(29, 340)
        Me.LBL_Date.Name = "LBL_Date"
        Me.LBL_Date.Size = New System.Drawing.Size(55, 13)
        Me.LBL_Date.TabIndex = 111
        Me.LBL_Date.Text = "LBL_Date"
        Me.LBL_Date.Visible = False
        '
        'BTNCreate
        '
        Me.BTNCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTNCreate.FlatAppearance.BorderSize = 0
        Me.BTNCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTNCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCreate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCreate.ForeColor = System.Drawing.Color.White
        Me.BTNCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCreate.Location = New System.Drawing.Point(263, 309)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(257, 31)
        Me.BTNCreate.TabIndex = 116
        Me.BTNCreate.Text = "Create Account"
        Me.BTNCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNCreate.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'CreateUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 380)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_Next As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBPosition As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Take As Button
    Friend WithEvents BTN_Upload As Button
    Friend WithEvents TXTContactNo As TextBox
    Friend WithEvents TXTAge As TextBox
    Friend WithEvents CBGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TXTLast As TextBox
    Friend WithEvents TXTFirst As TextBox
    Friend WithEvents TXTMiddle As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNCreate As Button
    Friend WithEvents LBL_PIC As Label
    Friend WithEvents LBL_IDNum As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BTN_GIDNum As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBL_Count As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBL_Comment As Label
    Friend WithEvents LBL_Date As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_Comment1 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LBLUsername As Label
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents TXTConfirmPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
