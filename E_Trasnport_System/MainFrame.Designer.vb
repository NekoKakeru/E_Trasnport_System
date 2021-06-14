<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrame))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet1 = New System.Windows.Forms.Label()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Driverbtn = New System.Windows.Forms.Button()
        Me.Passengerbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Aboutbtn = New System.Windows.Forms.Button()
        Me.Logoutbtn = New System.Windows.Forms.Button()
        Me.Profilebtn = New System.Windows.Forms.Button()
        Me.Otherbtn = New System.Windows.Forms.Button()
        Me.Createbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnManageAccount = New System.Windows.Forms.Button()
        Me.btnMoneyTransaction = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(280, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 50)
        Me.Panel1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(8, 11)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(117, 28)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Dashboard"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblSet1)
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnManageAccount)
        Me.Panel2.Controls.Add(Me.btnMoneyTransaction)
        Me.Panel2.Controls.Add(Me.btnRegister)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 811)
        Me.Panel2.TabIndex = 1
        '
        'lblSet1
        '
        Me.lblSet1.AutoSize = True
        Me.lblSet1.Location = New System.Drawing.Point(40, 789)
        Me.lblSet1.Name = "lblSet1"
        Me.lblSet1.Size = New System.Drawing.Size(27, 13)
        Me.lblSet1.TabIndex = 10
        Me.lblSet1.Text = "hide"
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(7, 789)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(27, 13)
        Me.lblSet.TabIndex = 2
        Me.lblSet.Text = "hide"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(0, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 45)
        Me.Label4.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(0, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 45)
        Me.Label3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(0, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 45)
        Me.Label2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(0, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 45)
        Me.Label1.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(280, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1104, 811)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Driverbtn)
        Me.Panel5.Controls.Add(Me.Passengerbtn)
        Me.Panel5.Location = New System.Drawing.Point(1, 241)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(185, 90)
        Me.Panel5.TabIndex = 10
        '
        'Driverbtn
        '
        Me.Driverbtn.FlatAppearance.BorderSize = 0
        Me.Driverbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Driverbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Driverbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Driverbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driverbtn.ForeColor = System.Drawing.Color.White
        Me.Driverbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Driverbtn.Location = New System.Drawing.Point(4, 48)
        Me.Driverbtn.Name = "Driverbtn"
        Me.Driverbtn.Size = New System.Drawing.Size(174, 32)
        Me.Driverbtn.TabIndex = 8
        Me.Driverbtn.Text = "Driver"
        Me.Driverbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Driverbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Driverbtn.UseVisualStyleBackColor = True
        '
        'Passengerbtn
        '
        Me.Passengerbtn.FlatAppearance.BorderSize = 0
        Me.Passengerbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Passengerbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Passengerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Passengerbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passengerbtn.ForeColor = System.Drawing.Color.White
        Me.Passengerbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Passengerbtn.Location = New System.Drawing.Point(4, 8)
        Me.Passengerbtn.Name = "Passengerbtn"
        Me.Passengerbtn.Size = New System.Drawing.Size(174, 32)
        Me.Passengerbtn.TabIndex = 6
        Me.Passengerbtn.Text = "Passenger"
        Me.Passengerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Passengerbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Passengerbtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Aboutbtn)
        Me.Panel4.Controls.Add(Me.Logoutbtn)
        Me.Panel4.Controls.Add(Me.Profilebtn)
        Me.Panel4.Controls.Add(Me.Otherbtn)
        Me.Panel4.Controls.Add(Me.Createbtn)
        Me.Panel4.Location = New System.Drawing.Point(906, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 204)
        Me.Panel4.TabIndex = 0
        '
        'Aboutbtn
        '
        Me.Aboutbtn.FlatAppearance.BorderSize = 0
        Me.Aboutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Aboutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Aboutbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aboutbtn.ForeColor = System.Drawing.Color.White
        Me.Aboutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Aboutbtn.Location = New System.Drawing.Point(5, 123)
        Me.Aboutbtn.Name = "Aboutbtn"
        Me.Aboutbtn.Size = New System.Drawing.Size(174, 32)
        Me.Aboutbtn.TabIndex = 9
        Me.Aboutbtn.Text = "About Programmer"
        Me.Aboutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Aboutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Aboutbtn.UseVisualStyleBackColor = True
        '
        'Logoutbtn
        '
        Me.Logoutbtn.FlatAppearance.BorderSize = 0
        Me.Logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logoutbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logoutbtn.ForeColor = System.Drawing.Color.White
        Me.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logoutbtn.Location = New System.Drawing.Point(5, 162)
        Me.Logoutbtn.Name = "Logoutbtn"
        Me.Logoutbtn.Size = New System.Drawing.Size(174, 32)
        Me.Logoutbtn.TabIndex = 8
        Me.Logoutbtn.Text = "Log Out"
        Me.Logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logoutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logoutbtn.UseVisualStyleBackColor = True
        '
        'Profilebtn
        '
        Me.Profilebtn.FlatAppearance.BorderSize = 0
        Me.Profilebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Profilebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Profilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Profilebtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profilebtn.ForeColor = System.Drawing.Color.White
        Me.Profilebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Profilebtn.Location = New System.Drawing.Point(5, 47)
        Me.Profilebtn.Name = "Profilebtn"
        Me.Profilebtn.Size = New System.Drawing.Size(174, 32)
        Me.Profilebtn.TabIndex = 7
        Me.Profilebtn.Text = "User Profile"
        Me.Profilebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Profilebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Profilebtn.UseVisualStyleBackColor = True
        '
        'Otherbtn
        '
        Me.Otherbtn.FlatAppearance.BorderSize = 0
        Me.Otherbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Otherbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Otherbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Otherbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Otherbtn.ForeColor = System.Drawing.Color.White
        Me.Otherbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Otherbtn.Location = New System.Drawing.Point(5, 85)
        Me.Otherbtn.Name = "Otherbtn"
        Me.Otherbtn.Size = New System.Drawing.Size(174, 32)
        Me.Otherbtn.TabIndex = 6
        Me.Otherbtn.Text = "Administrator"
        Me.Otherbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Otherbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Otherbtn.UseVisualStyleBackColor = True
        '
        'Createbtn
        '
        Me.Createbtn.FlatAppearance.BorderSize = 0
        Me.Createbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Createbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Createbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Createbtn.ForeColor = System.Drawing.Color.White
        Me.Createbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Createbtn.Location = New System.Drawing.Point(5, 9)
        Me.Createbtn.Name = "Createbtn"
        Me.Createbtn.Size = New System.Drawing.Size(174, 32)
        Me.Createbtn.TabIndex = 5
        Me.Createbtn.Text = "Create User Account"
        Me.Createbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Createbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Createbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.E_Trasnport_System.My.Resources.Resources.user__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1061, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 39)
        Me.Button1.TabIndex = 11
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnManageAccount
        '
        Me.btnManageAccount.FlatAppearance.BorderSize = 0
        Me.btnManageAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnManageAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageAccount.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAccount.ForeColor = System.Drawing.Color.White
        Me.btnManageAccount.Image = Global.E_Trasnport_System.My.Resources.Resources.profile
        Me.btnManageAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageAccount.Location = New System.Drawing.Point(12, 331)
        Me.btnManageAccount.Name = "btnManageAccount"
        Me.btnManageAccount.Size = New System.Drawing.Size(268, 45)
        Me.btnManageAccount.TabIndex = 4
        Me.btnManageAccount.Text = "Manage Account"
        Me.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageAccount.UseVisualStyleBackColor = True
        '
        'btnMoneyTransaction
        '
        Me.btnMoneyTransaction.FlatAppearance.BorderSize = 0
        Me.btnMoneyTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMoneyTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMoneyTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoneyTransaction.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoneyTransaction.ForeColor = System.Drawing.Color.White
        Me.btnMoneyTransaction.Image = Global.E_Trasnport_System.My.Resources.Resources.transaction
        Me.btnMoneyTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoneyTransaction.Location = New System.Drawing.Point(12, 286)
        Me.btnMoneyTransaction.Name = "btnMoneyTransaction"
        Me.btnMoneyTransaction.Size = New System.Drawing.Size(268, 45)
        Me.btnMoneyTransaction.TabIndex = 3
        Me.btnMoneyTransaction.Text = "Money Transaction"
        Me.btnMoneyTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMoneyTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMoneyTransaction.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Image = Global.E_Trasnport_System.My.Resources.Resources.register
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(12, 241)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(268, 45)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.E_Trasnport_System.My.Resources.Resources.dashboard
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(12, 196)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(268, 45)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.E_Trasnport_System.My.Resources.Resources.Logo__light_
        Me.PictureBox1.Location = New System.Drawing.Point(10, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 811)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Payment System [Transportation] v1.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnManageAccount As Button
    Friend WithEvents btnMoneyTransaction As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Aboutbtn As Button
    Friend WithEvents Logoutbtn As Button
    Friend WithEvents Profilebtn As Button
    Friend WithEvents Otherbtn As Button
    Friend WithEvents Createbtn As Button
    Friend WithEvents lblSet As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Driverbtn As Button
    Friend WithEvents Passengerbtn As Button
    Friend WithEvents lblSet1 As Label
End Class
