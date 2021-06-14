<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriverView))
        Me.LBL_LB = New System.Windows.Forms.Label()
        Me.LBL_PIC = New System.Windows.Forms.Label()
        Me.LBL_RT = New System.Windows.Forms.Label()
        Me.TXT_PlateNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
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
        Me.BTN_Take = New System.Windows.Forms.Button()
        Me.BTN_Upload = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBL_TN = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_GTN = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.BTN_Edit = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBL_Route = New System.Windows.Forms.Label()
        Me.BTN_Select = New System.Windows.Forms.Button()
        Me.LBL_Birthdate = New System.Windows.Forms.Label()
        Me.LBL_TN1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_LB
        '
        Me.LBL_LB.AutoSize = True
        Me.LBL_LB.Location = New System.Drawing.Point(25, 379)
        Me.LBL_LB.Name = "LBL_LB"
        Me.LBL_LB.Size = New System.Drawing.Size(18, 22)
        Me.LBL_LB.TabIndex = 27
        Me.LBL_LB.Text = "0"
        Me.LBL_LB.Visible = False
        '
        'LBL_PIC
        '
        Me.LBL_PIC.AutoSize = True
        Me.LBL_PIC.Location = New System.Drawing.Point(25, 338)
        Me.LBL_PIC.Name = "LBL_PIC"
        Me.LBL_PIC.Size = New System.Drawing.Size(18, 22)
        Me.LBL_PIC.TabIndex = 26
        Me.LBL_PIC.Text = "0"
        Me.LBL_PIC.Visible = False
        '
        'LBL_RT
        '
        Me.LBL_RT.AutoSize = True
        Me.LBL_RT.Location = New System.Drawing.Point(77, 743)
        Me.LBL_RT.Name = "LBL_RT"
        Me.LBL_RT.Size = New System.Drawing.Size(13, 13)
        Me.LBL_RT.TabIndex = 110
        Me.LBL_RT.Text = "0"
        Me.LBL_RT.Visible = False
        '
        'TXT_PlateNo
        '
        Me.TXT_PlateNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_PlateNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_PlateNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PlateNo.Location = New System.Drawing.Point(113, 83)
        Me.TXT_PlateNo.Name = "TXT_PlateNo"
        Me.TXT_PlateNo.Size = New System.Drawing.Size(218, 22)
        Me.TXT_PlateNo.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 26)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Plate No:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(290, 124)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(238, 28)
        Me.Label25.TabIndex = 124
        Me.Label25.Text = "- Personal Information -"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 322)
        Me.DateTimePicker1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1950, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 105
        Me.DateTimePicker1.Value = New Date(2021, 12, 25, 0, 0, 0, 0)
        '
        'TXT_BirthPlace
        '
        Me.TXT_BirthPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_BirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_BirthPlace.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BirthPlace.Location = New System.Drawing.Point(472, 325)
        Me.TXT_BirthPlace.Name = "TXT_BirthPlace"
        Me.TXT_BirthPlace.Size = New System.Drawing.Size(351, 22)
        Me.TXT_BirthPlace.TabIndex = 106
        '
        'TXT_Address
        '
        Me.TXT_Address.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Address.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Address.Location = New System.Drawing.Point(110, 372)
        Me.TXT_Address.Name = "TXT_Address"
        Me.TXT_Address.Size = New System.Drawing.Size(713, 22)
        Me.TXT_Address.TabIndex = 107
        '
        'TXT_ContactNo
        '
        Me.TXT_ContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_ContactNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ContactNo.Location = New System.Drawing.Point(138, 272)
        Me.TXT_ContactNo.MaxLength = 11
        Me.TXT_ContactNo.Name = "TXT_ContactNo"
        Me.TXT_ContactNo.Size = New System.Drawing.Size(193, 22)
        Me.TXT_ContactNo.TabIndex = 104
        '
        'TXT_Age
        '
        Me.TXT_Age.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Age.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Age.Location = New System.Drawing.Point(410, 228)
        Me.TXT_Age.MaxLength = 2
        Me.TXT_Age.Name = "TXT_Age"
        Me.TXT_Age.Size = New System.Drawing.Size(258, 22)
        Me.TXT_Age.TabIndex = 103
        '
        'CB_Gender
        '
        Me.CB_Gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CB_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Gender.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Gender.FormattingEnabled = True
        Me.CB_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CB_Gender.Location = New System.Drawing.Point(105, 221)
        Me.CB_Gender.Name = "CB_Gender"
        Me.CB_Gender.Size = New System.Drawing.Size(226, 30)
        Me.CB_Gender.TabIndex = 102
        '
        'TXT_Last
        '
        Me.TXT_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Last.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Last.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Last.Location = New System.Drawing.Point(583, 168)
        Me.TXT_Last.Name = "TXT_Last"
        Me.TXT_Last.Size = New System.Drawing.Size(240, 22)
        Me.TXT_Last.TabIndex = 101
        '
        'TXT_Middle
        '
        Me.TXT_Middle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Middle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Middle.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Middle.Location = New System.Drawing.Point(337, 168)
        Me.TXT_Middle.Name = "TXT_Middle"
        Me.TXT_Middle.Size = New System.Drawing.Size(240, 22)
        Me.TXT_Middle.TabIndex = 100
        '
        'TXT_First
        '
        Me.TXT_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_First.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_First.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_First.Location = New System.Drawing.Point(91, 168)
        Me.TXT_First.Name = "TXT_First"
        Me.TXT_First.Size = New System.Drawing.Size(240, 22)
        Me.TXT_First.TabIndex = 99
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(421, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "Middlename"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(668, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Lastname"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(158, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Firstname"
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
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(12, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(210, 210)
        Me.Label27.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(351, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 26)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Birth Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 26)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Birth Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 26)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Contact No:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 26)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(351, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 26)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 26)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Name:"
        '
        'LBL_TN
        '
        Me.LBL_TN.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TN.Location = New System.Drawing.Point(178, 30)
        Me.LBL_TN.Name = "LBL_TN"
        Me.LBL_TN.Size = New System.Drawing.Size(153, 36)
        Me.LBL_TN.TabIndex = 112
        Me.LBL_TN.Text = "0000000000"
        Me.LBL_TN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 26)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Trycicle Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_GTN)
        Me.GroupBox2.Controls.Add(Me.BTN_Delete)
        Me.GroupBox2.Controls.Add(Me.LBL_LB)
        Me.GroupBox2.Controls.Add(Me.LBL_PIC)
        Me.GroupBox2.Controls.Add(Me.BTN_Take)
        Me.GroupBox2.Controls.Add(Me.BTN_Upload)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.BTN_Save)
        Me.GroupBox2.Controls.Add(Me.BTN_Edit)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(846, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 541)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
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
        Me.BTN_GTN.Location = New System.Drawing.Point(38, 391)
        Me.BTN_GTN.Name = "BTN_GTN"
        Me.BTN_GTN.Size = New System.Drawing.Size(163, 39)
        Me.BTN_GTN.TabIndex = 28
        Me.BTN_GTN.Text = "GTN"
        Me.BTN_GTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GTN.UseVisualStyleBackColor = False
        '
        'BTN_Delete
        '
        Me.BTN_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Delete.FlatAppearance.BorderSize = 0
        Me.BTN_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Delete.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Delete.ForeColor = System.Drawing.Color.White
        Me.BTN_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Delete.Location = New System.Drawing.Point(38, 481)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Delete.TabIndex = 30
        Me.BTN_Delete.Text = "Delete"
        Me.BTN_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Delete.UseVisualStyleBackColor = False
        '
        'BTN_Save
        '
        Me.BTN_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Save.FlatAppearance.BorderSize = 0
        Me.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Save.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Save.ForeColor = System.Drawing.Color.White
        Me.BTN_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Save.Location = New System.Drawing.Point(38, 436)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Save.TabIndex = 31
        Me.BTN_Save.Text = "Save"
        Me.BTN_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Save.UseVisualStyleBackColor = False
        '
        'BTN_Edit
        '
        Me.BTN_Edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Edit.FlatAppearance.BorderSize = 0
        Me.BTN_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Edit.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Edit.ForeColor = System.Drawing.Color.White
        Me.BTN_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Edit.Location = New System.Drawing.Point(38, 436)
        Me.BTN_Edit.Name = "BTN_Edit"
        Me.BTN_Edit.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Edit.TabIndex = 29
        Me.BTN_Edit.Text = "Edit"
        Me.BTN_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Edit.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 418)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 26)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Route:"
        '
        'LBL_Route
        '
        Me.LBL_Route.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_Route.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Route.Location = New System.Drawing.Point(42, 459)
        Me.LBL_Route.Name = "LBL_Route"
        Me.LBL_Route.Size = New System.Drawing.Size(781, 32)
        Me.LBL_Route.TabIndex = 128
        Me.LBL_Route.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_Select
        '
        Me.BTN_Select.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Select.FlatAppearance.BorderSize = 0
        Me.BTN_Select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Select.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Select.ForeColor = System.Drawing.Color.White
        Me.BTN_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Select.Location = New System.Drawing.Point(660, 497)
        Me.BTN_Select.Name = "BTN_Select"
        Me.BTN_Select.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Select.TabIndex = 32
        Me.BTN_Select.Text = "Edit Route"
        Me.BTN_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Select.UseVisualStyleBackColor = False
        '
        'LBL_Birthdate
        '
        Me.LBL_Birthdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_Birthdate.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Birthdate.Location = New System.Drawing.Point(134, 321)
        Me.LBL_Birthdate.Name = "LBL_Birthdate"
        Me.LBL_Birthdate.Size = New System.Drawing.Size(197, 26)
        Me.LBL_Birthdate.TabIndex = 129
        Me.LBL_Birthdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_TN1
        '
        Me.LBL_TN1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TN1.Location = New System.Drawing.Point(178, 31)
        Me.LBL_TN1.Name = "LBL_TN1"
        Me.LBL_TN1.Size = New System.Drawing.Size(153, 36)
        Me.LBL_TN1.TabIndex = 130
        Me.LBL_TN1.Text = "0000000000"
        Me.LBL_TN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'DriverView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 572)
        Me.Controls.Add(Me.LBL_TN1)
        Me.Controls.Add(Me.LBL_Birthdate)
        Me.Controls.Add(Me.BTN_Select)
        Me.Controls.Add(Me.LBL_Route)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LBL_RT)
        Me.Controls.Add(Me.TXT_PlateNo)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.LBL_TN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DriverView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driver Profile"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_LB As Label
    Friend WithEvents LBL_PIC As Label
    Friend WithEvents LBL_RT As Label
    Friend WithEvents TXT_PlateNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
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
    Friend WithEvents BTN_Take As Button
    Friend WithEvents BTN_Upload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_TN As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_Save As Button
    Friend WithEvents BTN_GTN As Button
    Friend WithEvents BTN_Edit As Button
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents LBL_Route As Label
    Friend WithEvents BTN_Select As Button
    Friend WithEvents LBL_Birthdate As Label
    Friend WithEvents LBL_TN1 As Label
End Class
