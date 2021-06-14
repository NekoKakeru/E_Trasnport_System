<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriverRegistration
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
        Me.BTN_Take = New System.Windows.Forms.Button()
        Me.BTN_Upload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BTN_GTN = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Reg = New System.Windows.Forms.Button()
        Me.TXT_BirthPlace = New System.Windows.Forms.TextBox()
        Me.TXT_Address = New System.Windows.Forms.TextBox()
        Me.TXT_ContactNo = New System.Windows.Forms.TextBox()
        Me.TXT_Age = New System.Windows.Forms.TextBox()
        Me.CB_Gender = New System.Windows.Forms.ComboBox()
        Me.TXT_Last = New System.Windows.Forms.TextBox()
        Me.TXT_Middle = New System.Windows.Forms.TextBox()
        Me.TXT_First = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBL_PCN = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_PlateNo = New System.Windows.Forms.TextBox()
        Me.LB_Route = New System.Windows.Forms.ListBox()
        Me.TXT_Search = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LB_Selected = New System.Windows.Forms.ListBox()
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.LBL_PIC = New System.Windows.Forms.Label()
        Me.LBL_RT = New System.Windows.Forms.Label()
        Me.LBL_LB = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BTN_Take.Location = New System.Drawing.Point(38, 284)
        Me.BTN_Take.Name = "BTN_Take"
        Me.BTN_Take.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Take.TabIndex = 13
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
        Me.BTN_Upload.Location = New System.Drawing.Point(38, 239)
        Me.BTN_Upload.Name = "BTN_Upload"
        Me.BTN_Upload.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Upload.TabIndex = 12
        Me.BTN_Upload.Text = "Upload Picture"
        Me.BTN_Upload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Upload.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(17, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(12, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(210, 210)
        Me.Label27.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(303, 467)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(182, 28)
        Me.Label26.TabIndex = 91
        Me.Label26.Text = "- Route Selection -"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(288, 162)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(238, 28)
        Me.Label25.TabIndex = 90
        Me.Label25.Text = "- Personal Information -"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(129, 360)
        Me.DateTimePicker1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1950, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2021, 12, 25, 0, 0, 0, 0)
        '
        'BTN_GTN
        '
        Me.BTN_GTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_GTN.FlatAppearance.BorderSize = 0
        Me.BTN_GTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_GTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_GTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GTN.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GTN.ForeColor = System.Drawing.Color.White
        Me.BTN_GTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_GTN.Location = New System.Drawing.Point(38, 569)
        Me.BTN_GTN.Name = "BTN_GTN"
        Me.BTN_GTN.Size = New System.Drawing.Size(163, 39)
        Me.BTN_GTN.TabIndex = 14
        Me.BTN_GTN.Text = "GTN"
        Me.BTN_GTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GTN.UseVisualStyleBackColor = False
        '
        'BTN_Clear
        '
        Me.BTN_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Clear.FlatAppearance.BorderSize = 0
        Me.BTN_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Clear.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Clear.ForeColor = System.Drawing.Color.White
        Me.BTN_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Clear.Location = New System.Drawing.Point(38, 614)
        Me.BTN_Clear.Name = "BTN_Clear"
        Me.BTN_Clear.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Clear.TabIndex = 15
        Me.BTN_Clear.Text = "Clear Fields"
        Me.BTN_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Clear.UseVisualStyleBackColor = False
        '
        'BTN_Reg
        '
        Me.BTN_Reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Reg.FlatAppearance.BorderSize = 0
        Me.BTN_Reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Reg.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Reg.ForeColor = System.Drawing.Color.White
        Me.BTN_Reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Reg.Location = New System.Drawing.Point(38, 659)
        Me.BTN_Reg.Name = "BTN_Reg"
        Me.BTN_Reg.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Reg.TabIndex = 24
        Me.BTN_Reg.Text = "Register"
        Me.BTN_Reg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Reg.UseVisualStyleBackColor = False
        '
        'TXT_BirthPlace
        '
        Me.TXT_BirthPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_BirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_BirthPlace.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BirthPlace.Location = New System.Drawing.Point(470, 363)
        Me.TXT_BirthPlace.Name = "TXT_BirthPlace"
        Me.TXT_BirthPlace.Size = New System.Drawing.Size(351, 22)
        Me.TXT_BirthPlace.TabIndex = 8
        '
        'TXT_Address
        '
        Me.TXT_Address.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Address.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Address.Location = New System.Drawing.Point(108, 410)
        Me.TXT_Address.Name = "TXT_Address"
        Me.TXT_Address.Size = New System.Drawing.Size(713, 22)
        Me.TXT_Address.TabIndex = 9
        '
        'TXT_ContactNo
        '
        Me.TXT_ContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_ContactNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ContactNo.Location = New System.Drawing.Point(136, 310)
        Me.TXT_ContactNo.MaxLength = 11
        Me.TXT_ContactNo.Name = "TXT_ContactNo"
        Me.TXT_ContactNo.Size = New System.Drawing.Size(193, 22)
        Me.TXT_ContactNo.TabIndex = 6
        '
        'TXT_Age
        '
        Me.TXT_Age.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Age.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Age.Location = New System.Drawing.Point(408, 266)
        Me.TXT_Age.MaxLength = 2
        Me.TXT_Age.Name = "TXT_Age"
        Me.TXT_Age.Size = New System.Drawing.Size(258, 22)
        Me.TXT_Age.TabIndex = 6
        '
        'CB_Gender
        '
        Me.CB_Gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CB_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Gender.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Gender.FormattingEnabled = True
        Me.CB_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CB_Gender.Location = New System.Drawing.Point(103, 259)
        Me.CB_Gender.Name = "CB_Gender"
        Me.CB_Gender.Size = New System.Drawing.Size(226, 30)
        Me.CB_Gender.TabIndex = 5
        '
        'TXT_Last
        '
        Me.TXT_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Last.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Last.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Last.Location = New System.Drawing.Point(581, 206)
        Me.TXT_Last.Name = "TXT_Last"
        Me.TXT_Last.Size = New System.Drawing.Size(240, 22)
        Me.TXT_Last.TabIndex = 4
        '
        'TXT_Middle
        '
        Me.TXT_Middle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Middle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Middle.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Middle.Location = New System.Drawing.Point(335, 206)
        Me.TXT_Middle.Name = "TXT_Middle"
        Me.TXT_Middle.Size = New System.Drawing.Size(240, 22)
        Me.TXT_Middle.TabIndex = 3
        '
        'TXT_First
        '
        Me.TXT_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_First.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_First.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_First.Location = New System.Drawing.Point(89, 206)
        Me.TXT_First.Name = "TXT_First"
        Me.TXT_First.Size = New System.Drawing.Size(240, 22)
        Me.TXT_First.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(419, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Middlename"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(666, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Lastname"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(156, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Firstname"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 26)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Birth Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 26)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Birth Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 26)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Contact No:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 26)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 26)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 26)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Name:"
        '
        'LBL_PCN
        '
        Me.LBL_PCN.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PCN.Location = New System.Drawing.Point(176, 68)
        Me.LBL_PCN.Name = "LBL_PCN"
        Me.LBL_PCN.Size = New System.Drawing.Size(153, 36)
        Me.LBL_PCN.TabIndex = 60
        Me.LBL_PCN.Text = "0000000000"
        Me.LBL_PCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 26)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Trycicle Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_LB)
        Me.GroupBox2.Controls.Add(Me.LBL_PIC)
        Me.GroupBox2.Controls.Add(Me.BTN_GTN)
        Me.GroupBox2.Controls.Add(Me.BTN_Clear)
        Me.GroupBox2.Controls.Add(Me.BTN_Reg)
        Me.GroupBox2.Controls.Add(Me.BTN_Take)
        Me.GroupBox2.Controls.Add(Me.BTN_Upload)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(844, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 735)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 26)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Plate No:"
        '
        'TXT_PlateNo
        '
        Me.TXT_PlateNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_PlateNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_PlateNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PlateNo.Location = New System.Drawing.Point(111, 121)
        Me.TXT_PlateNo.Name = "TXT_PlateNo"
        Me.TXT_PlateNo.Size = New System.Drawing.Size(218, 22)
        Me.TXT_PlateNo.TabIndex = 1
        '
        'LB_Route
        '
        Me.LB_Route.FormattingEnabled = True
        Me.LB_Route.Location = New System.Drawing.Point(17, 540)
        Me.LB_Route.Name = "LB_Route"
        Me.LB_Route.Size = New System.Drawing.Size(320, 238)
        Me.LB_Route.TabIndex = 94
        '
        'TXT_Search
        '
        Me.TXT_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Search.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Search.Location = New System.Drawing.Point(79, 512)
        Me.TXT_Search.MaxLength = 100
        Me.TXT_Search.Name = "TXT_Search"
        Me.TXT_Search.Size = New System.Drawing.Size(258, 22)
        Me.TXT_Search.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 512)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 22)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Search"
        '
        'LB_Selected
        '
        Me.LB_Selected.FormattingEnabled = True
        Me.LB_Selected.Location = New System.Drawing.Point(501, 540)
        Me.LB_Selected.Name = "LB_Selected"
        Me.LB_Selected.Size = New System.Drawing.Size(320, 238)
        Me.LB_Selected.TabIndex = 97
        '
        'BTN_ADD
        '
        Me.BTN_ADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_ADD.FlatAppearance.BorderSize = 0
        Me.BTN_ADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADD.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD.ForeColor = System.Drawing.Color.White
        Me.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_ADD.Location = New System.Drawing.Point(351, 616)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(134, 39)
        Me.BTN_ADD.TabIndex = 11
        Me.BTN_ADD.Text = "Add"
        Me.BTN_ADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD.UseVisualStyleBackColor = False
        '
        'LBL_PIC
        '
        Me.LBL_PIC.AutoSize = True
        Me.LBL_PIC.Location = New System.Drawing.Point(109, 356)
        Me.LBL_PIC.Name = "LBL_PIC"
        Me.LBL_PIC.Size = New System.Drawing.Size(18, 22)
        Me.LBL_PIC.TabIndex = 26
        Me.LBL_PIC.Text = "0"
        Me.LBL_PIC.Visible = False
        '
        'LBL_RT
        '
        Me.LBL_RT.AutoSize = True
        Me.LBL_RT.Location = New System.Drawing.Point(75, 781)
        Me.LBL_RT.Name = "LBL_RT"
        Me.LBL_RT.Size = New System.Drawing.Size(13, 13)
        Me.LBL_RT.TabIndex = 27
        Me.LBL_RT.Text = "0"
        Me.LBL_RT.Visible = False
        '
        'LBL_LB
        '
        Me.LBL_LB.AutoSize = True
        Me.LBL_LB.Location = New System.Drawing.Point(123, 413)
        Me.LBL_LB.Name = "LBL_LB"
        Me.LBL_LB.Size = New System.Drawing.Size(18, 22)
        Me.LBL_LB.TabIndex = 27
        Me.LBL_LB.Text = "0"
        Me.LBL_LB.Visible = False
        '
        'DriverRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 811)
        Me.Controls.Add(Me.LBL_RT)
        Me.Controls.Add(Me.BTN_ADD)
        Me.Controls.Add(Me.LB_Selected)
        Me.Controls.Add(Me.TXT_Search)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LB_Route)
        Me.Controls.Add(Me.TXT_PlateNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXT_BirthPlace)
        Me.Controls.Add(Me.TXT_Address)
        Me.Controls.Add(Me.TXT_ContactNo)
        Me.Controls.Add(Me.TXT_Age)
        Me.Controls.Add(Me.CB_Gender)
        Me.Controls.Add(Me.TXT_Last)
        Me.Controls.Add(Me.TXT_Middle)
        Me.Controls.Add(Me.TXT_First)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBL_PCN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DriverRegistration"
        Me.Text = "DriverRegistrationFrame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Take As Button
    Friend WithEvents BTN_Upload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BTN_GTN As Button
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Reg As Button
    Friend WithEvents TXT_BirthPlace As TextBox
    Friend WithEvents TXT_Address As TextBox
    Friend WithEvents TXT_ContactNo As TextBox
    Friend WithEvents TXT_Age As TextBox
    Friend WithEvents CB_Gender As ComboBox
    Friend WithEvents TXT_Last As TextBox
    Friend WithEvents TXT_Middle As TextBox
    Friend WithEvents TXT_First As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_PCN As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_PlateNo As TextBox
    Friend WithEvents LB_Route As ListBox
    Friend WithEvents TXT_Search As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LB_Selected As ListBox
    Friend WithEvents BTN_ADD As Button
    Friend WithEvents LBL_RT As Label
    Friend WithEvents LBL_PIC As Label
    Friend WithEvents LBL_LB As Label
End Class
