<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassengerRegistration
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
        Me.LBL_PCN = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_First = New System.Windows.Forms.TextBox()
        Me.TXT_Middle = New System.Windows.Forms.TextBox()
        Me.TXT_Last = New System.Windows.Forms.TextBox()
        Me.CB_Gender = New System.Windows.Forms.ComboBox()
        Me.TXT_Age = New System.Windows.Forms.TextBox()
        Me.TXT_ContactNo = New System.Windows.Forms.TextBox()
        Me.RB_PWD = New System.Windows.Forms.RadioButton()
        Me.RB_Student = New System.Windows.Forms.RadioButton()
        Me.RB_Reg = New System.Windows.Forms.RadioButton()
        Me.RB_Senior = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_Address = New System.Windows.Forms.TextBox()
        Me.TXT_BirthPlace = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXT_eAddress = New System.Windows.Forms.TextBox()
        Me.TXT_eContactNo = New System.Windows.Forms.TextBox()
        Me.TXT_eLast = New System.Windows.Forms.TextBox()
        Me.TXT_eMiddle = New System.Windows.Forms.TextBox()
        Me.TXT_eFirst = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_PIC = New System.Windows.Forms.Label()
        Me.BTN_GCN = New System.Windows.Forms.Button()
        Me.BTN_Clear = New System.Windows.Forms.Button()
        Me.BTN_Reg = New System.Windows.Forms.Button()
        Me.BTN_Take = New System.Windows.Forms.Button()
        Me.BTN_Upload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_eRelationship = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_PCN
        '
        Me.LBL_PCN.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PCN.Location = New System.Drawing.Point(253, 69)
        Me.LBL_PCN.Name = "LBL_PCN"
        Me.LBL_PCN.Size = New System.Drawing.Size(153, 36)
        Me.LBL_PCN.TabIndex = 5
        Me.LBL_PCN.Text = "0000000000"
        Me.LBL_PCN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 26)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Contact No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 26)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Birth Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(349, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 26)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Birth Place:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(156, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Firstname"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(666, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Lastname"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(419, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Middlename"
        '
        'TXT_First
        '
        Me.TXT_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_First.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_First.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_First.Location = New System.Drawing.Point(89, 162)
        Me.TXT_First.Name = "TXT_First"
        Me.TXT_First.Size = New System.Drawing.Size(240, 22)
        Me.TXT_First.TabIndex = 1
        '
        'TXT_Middle
        '
        Me.TXT_Middle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Middle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Middle.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Middle.Location = New System.Drawing.Point(335, 162)
        Me.TXT_Middle.Name = "TXT_Middle"
        Me.TXT_Middle.Size = New System.Drawing.Size(240, 22)
        Me.TXT_Middle.TabIndex = 2
        '
        'TXT_Last
        '
        Me.TXT_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Last.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Last.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Last.Location = New System.Drawing.Point(581, 162)
        Me.TXT_Last.Name = "TXT_Last"
        Me.TXT_Last.Size = New System.Drawing.Size(240, 22)
        Me.TXT_Last.TabIndex = 3
        '
        'CB_Gender
        '
        Me.CB_Gender.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CB_Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Gender.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Gender.FormattingEnabled = True
        Me.CB_Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.CB_Gender.Location = New System.Drawing.Point(103, 215)
        Me.CB_Gender.Name = "CB_Gender"
        Me.CB_Gender.Size = New System.Drawing.Size(226, 30)
        Me.CB_Gender.TabIndex = 4
        '
        'TXT_Age
        '
        Me.TXT_Age.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Age.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Age.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Age.Location = New System.Drawing.Point(71, 271)
        Me.TXT_Age.MaxLength = 2
        Me.TXT_Age.Name = "TXT_Age"
        Me.TXT_Age.Size = New System.Drawing.Size(258, 22)
        Me.TXT_Age.TabIndex = 5
        '
        'TXT_ContactNo
        '
        Me.TXT_ContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_ContactNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ContactNo.Location = New System.Drawing.Point(136, 315)
        Me.TXT_ContactNo.MaxLength = 11
        Me.TXT_ContactNo.Name = "TXT_ContactNo"
        Me.TXT_ContactNo.Size = New System.Drawing.Size(193, 22)
        Me.TXT_ContactNo.TabIndex = 6
        '
        'RB_PWD
        '
        Me.RB_PWD.AutoSize = True
        Me.RB_PWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_PWD.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_PWD.Location = New System.Drawing.Point(106, 60)
        Me.RB_PWD.Name = "RB_PWD"
        Me.RB_PWD.Size = New System.Drawing.Size(65, 26)
        Me.RB_PWD.TabIndex = 13
        Me.RB_PWD.TabStop = True
        Me.RB_PWD.Text = "PWD"
        Me.RB_PWD.UseVisualStyleBackColor = True
        '
        'RB_Student
        '
        Me.RB_Student.AutoSize = True
        Me.RB_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Student.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Student.Location = New System.Drawing.Point(6, 60)
        Me.RB_Student.Name = "RB_Student"
        Me.RB_Student.Size = New System.Drawing.Size(80, 26)
        Me.RB_Student.TabIndex = 12
        Me.RB_Student.TabStop = True
        Me.RB_Student.Text = "Student"
        Me.RB_Student.UseVisualStyleBackColor = True
        '
        'RB_Reg
        '
        Me.RB_Reg.AutoSize = True
        Me.RB_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Reg.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Reg.Location = New System.Drawing.Point(6, 28)
        Me.RB_Reg.Name = "RB_Reg"
        Me.RB_Reg.Size = New System.Drawing.Size(80, 26)
        Me.RB_Reg.TabIndex = 10
        Me.RB_Reg.TabStop = True
        Me.RB_Reg.Text = "Regular"
        Me.RB_Reg.UseVisualStyleBackColor = True
        '
        'RB_Senior
        '
        Me.RB_Senior.AutoSize = True
        Me.RB_Senior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Senior.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Senior.Location = New System.Drawing.Point(106, 28)
        Me.RB_Senior.Name = "RB_Senior"
        Me.RB_Senior.Size = New System.Drawing.Size(122, 26)
        Me.RB_Senior.TabIndex = 11
        Me.RB_Senior.TabStop = True
        Me.RB_Senior.Text = "Senior Citizen"
        Me.RB_Senior.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RB_Reg)
        Me.GroupBox1.Controls.Add(Me.RB_PWD)
        Me.GroupBox1.Controls.Add(Me.RB_Senior)
        Me.GroupBox1.Controls.Add(Me.RB_Student)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(464, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 111)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Person Type"
        '
        'TXT_Address
        '
        Me.TXT_Address.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Address.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Address.Location = New System.Drawing.Point(108, 415)
        Me.TXT_Address.Name = "TXT_Address"
        Me.TXT_Address.Size = New System.Drawing.Size(713, 22)
        Me.TXT_Address.TabIndex = 9
        '
        'TXT_BirthPlace
        '
        Me.TXT_BirthPlace.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_BirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_BirthPlace.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BirthPlace.Location = New System.Drawing.Point(470, 368)
        Me.TXT_BirthPlace.Name = "TXT_BirthPlace"
        Me.TXT_BirthPlace.Size = New System.Drawing.Size(351, 22)
        Me.TXT_BirthPlace.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(129, 365)
        Me.DateTimePicker1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1950, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2021, 12, 25, 0, 0, 0, 0)
        '
        'TXT_eAddress
        '
        Me.TXT_eAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_eAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_eAddress.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_eAddress.Location = New System.Drawing.Point(108, 620)
        Me.TXT_eAddress.Name = "TXT_eAddress"
        Me.TXT_eAddress.Size = New System.Drawing.Size(713, 22)
        Me.TXT_eAddress.TabIndex = 19
        '
        'TXT_eContactNo
        '
        Me.TXT_eContactNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_eContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_eContactNo.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_eContactNo.Location = New System.Drawing.Point(136, 572)
        Me.TXT_eContactNo.MaxLength = 11
        Me.TXT_eContactNo.Name = "TXT_eContactNo"
        Me.TXT_eContactNo.Size = New System.Drawing.Size(193, 22)
        Me.TXT_eContactNo.TabIndex = 17
        '
        'TXT_eLast
        '
        Me.TXT_eLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_eLast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_eLast.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_eLast.Location = New System.Drawing.Point(581, 518)
        Me.TXT_eLast.Name = "TXT_eLast"
        Me.TXT_eLast.Size = New System.Drawing.Size(240, 22)
        Me.TXT_eLast.TabIndex = 16
        '
        'TXT_eMiddle
        '
        Me.TXT_eMiddle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_eMiddle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_eMiddle.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_eMiddle.Location = New System.Drawing.Point(335, 518)
        Me.TXT_eMiddle.Name = "TXT_eMiddle"
        Me.TXT_eMiddle.Size = New System.Drawing.Size(240, 22)
        Me.TXT_eMiddle.TabIndex = 15
        '
        'TXT_eFirst
        '
        Me.TXT_eFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_eFirst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_eFirst.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_eFirst.Location = New System.Drawing.Point(89, 518)
        Me.TXT_eFirst.Name = "TXT_eFirst"
        Me.TXT_eFirst.Size = New System.Drawing.Size(240, 22)
        Me.TXT_eFirst.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(419, 543)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 18)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Middlename"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(666, 543)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 18)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Lastname"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(156, 543)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 18)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Firstname"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 572)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 26)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Contact No:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 617)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 26)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Address:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 518)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 26)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Passenger Card Number:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(288, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(238, 28)
        Me.Label25.TabIndex = 52
        Me.Label25.Text = "- Personal Information -"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(211, 473)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(382, 28)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "- Contact Person in Case of Emergency -"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_PIC)
        Me.GroupBox2.Controls.Add(Me.BTN_GCN)
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
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'LBL_PIC
        '
        Me.LBL_PIC.AutoSize = True
        Me.LBL_PIC.Location = New System.Drawing.Point(97, 356)
        Me.LBL_PIC.Name = "LBL_PIC"
        Me.LBL_PIC.Size = New System.Drawing.Size(18, 22)
        Me.LBL_PIC.TabIndex = 25
        Me.LBL_PIC.Text = "0"
        Me.LBL_PIC.Visible = False
        '
        'BTN_GCN
        '
        Me.BTN_GCN.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_GCN.FlatAppearance.BorderSize = 0
        Me.BTN_GCN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_GCN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_GCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GCN.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GCN.ForeColor = System.Drawing.Color.White
        Me.BTN_GCN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_GCN.Location = New System.Drawing.Point(38, 569)
        Me.BTN_GCN.Name = "BTN_GCN"
        Me.BTN_GCN.Size = New System.Drawing.Size(163, 39)
        Me.BTN_GCN.TabIndex = 22
        Me.BTN_GCN.Text = "GCN"
        Me.BTN_GCN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GCN.UseVisualStyleBackColor = False
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
        Me.BTN_Clear.TabIndex = 23
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
        Me.BTN_Take.TabIndex = 21
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
        Me.BTN_Upload.TabIndex = 20
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 569)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 26)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Relationship:"
        '
        'TXT_eRelationship
        '
        Me.TXT_eRelationship.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_eRelationship.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_eRelationship.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_eRelationship.Location = New System.Drawing.Point(486, 572)
        Me.TXT_eRelationship.Name = "TXT_eRelationship"
        Me.TXT_eRelationship.Size = New System.Drawing.Size(335, 22)
        Me.TXT_eRelationship.TabIndex = 18
        '
        'PassengerRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 811)
        Me.Controls.Add(Me.TXT_eRelationship)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TXT_eAddress)
        Me.Controls.Add(Me.TXT_eContactNo)
        Me.Controls.Add(Me.TXT_eLast)
        Me.Controls.Add(Me.TXT_eMiddle)
        Me.Controls.Add(Me.TXT_eFirst)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXT_BirthPlace)
        Me.Controls.Add(Me.TXT_Address)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Name = "PassengerRegistration"
        Me.Text = "PassengerRegistrationFrame"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_PCN As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_First As TextBox
    Friend WithEvents TXT_Middle As TextBox
    Friend WithEvents TXT_Last As TextBox
    Friend WithEvents CB_Gender As ComboBox
    Friend WithEvents TXT_Age As TextBox
    Friend WithEvents TXT_ContactNo As TextBox
    Friend WithEvents RB_PWD As RadioButton
    Friend WithEvents RB_Student As RadioButton
    Friend WithEvents RB_Reg As RadioButton
    Friend WithEvents RB_Senior As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_Address As TextBox
    Friend WithEvents TXT_BirthPlace As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TXT_eAddress As TextBox
    Friend WithEvents TXT_eContactNo As TextBox
    Friend WithEvents TXT_eLast As TextBox
    Friend WithEvents TXT_eMiddle As TextBox
    Friend WithEvents TXT_eFirst As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_GCN As Button
    Friend WithEvents BTN_Clear As Button
    Friend WithEvents BTN_Reg As Button
    Friend WithEvents BTN_Take As Button
    Friend WithEvents BTN_Upload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_eRelationship As TextBox
    Friend WithEvents LBL_PIC As Label
End Class
