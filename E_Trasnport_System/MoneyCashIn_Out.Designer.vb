<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoneyCashIn_Out
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoneyCashIn_Out))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBL_Name = New System.Windows.Forms.Label()
        Me.LBL_Balance = New System.Windows.Forms.Label()
        Me.LBL_NewBal = New System.Windows.Forms.Label()
        Me.TXT_EnterAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_CashIn = New System.Windows.Forms.Button()
        Me.BTN_CashOut = New System.Windows.Forms.Button()
        Me.LBL_Num = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Balance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter Cash amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "New Balance:"
        '
        'LBL_Name
        '
        Me.LBL_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_Name.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Name.Location = New System.Drawing.Point(89, 19)
        Me.LBL_Name.Name = "LBL_Name"
        Me.LBL_Name.Size = New System.Drawing.Size(427, 26)
        Me.LBL_Name.TabIndex = 11
        '
        'LBL_Balance
        '
        Me.LBL_Balance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_Balance.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Balance.Location = New System.Drawing.Point(128, 66)
        Me.LBL_Balance.Name = "LBL_Balance"
        Me.LBL_Balance.Size = New System.Drawing.Size(388, 26)
        Me.LBL_Balance.TabIndex = 12
        '
        'LBL_NewBal
        '
        Me.LBL_NewBal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LBL_NewBal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NewBal.Location = New System.Drawing.Point(175, 158)
        Me.LBL_NewBal.Name = "LBL_NewBal"
        Me.LBL_NewBal.Size = New System.Drawing.Size(341, 26)
        Me.LBL_NewBal.TabIndex = 13
        '
        'TXT_EnterAmount
        '
        Me.TXT_EnterAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_EnterAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_EnterAmount.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EnterAmount.Location = New System.Drawing.Point(232, 110)
        Me.TXT_EnterAmount.MaxLength = 100
        Me.TXT_EnterAmount.Name = "TXT_EnterAmount"
        Me.TXT_EnterAmount.Size = New System.Drawing.Size(284, 26)
        Me.TXT_EnterAmount.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 26)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "₱"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(208, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 26)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "₱"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(151, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 26)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "₱"
        '
        'BTN_CashIn
        '
        Me.BTN_CashIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_CashIn.FlatAppearance.BorderSize = 0
        Me.BTN_CashIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_CashIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_CashIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CashIn.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CashIn.ForeColor = System.Drawing.Color.White
        Me.BTN_CashIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CashIn.Location = New System.Drawing.Point(353, 199)
        Me.BTN_CashIn.Name = "BTN_CashIn"
        Me.BTN_CashIn.Size = New System.Drawing.Size(163, 39)
        Me.BTN_CashIn.TabIndex = 114
        Me.BTN_CashIn.Text = "Cash In"
        Me.BTN_CashIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CashIn.UseVisualStyleBackColor = False
        Me.BTN_CashIn.Visible = False
        '
        'BTN_CashOut
        '
        Me.BTN_CashOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_CashOut.FlatAppearance.BorderSize = 0
        Me.BTN_CashOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_CashOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_CashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CashOut.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CashOut.ForeColor = System.Drawing.Color.White
        Me.BTN_CashOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CashOut.Location = New System.Drawing.Point(353, 199)
        Me.BTN_CashOut.Name = "BTN_CashOut"
        Me.BTN_CashOut.Size = New System.Drawing.Size(163, 39)
        Me.BTN_CashOut.TabIndex = 115
        Me.BTN_CashOut.Text = "Cash Out"
        Me.BTN_CashOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CashOut.UseVisualStyleBackColor = False
        Me.BTN_CashOut.Visible = False
        '
        'LBL_Num
        '
        Me.LBL_Num.AutoSize = True
        Me.LBL_Num.Location = New System.Drawing.Point(14, 214)
        Me.LBL_Num.Name = "LBL_Num"
        Me.LBL_Num.Size = New System.Drawing.Size(13, 13)
        Me.LBL_Num.TabIndex = 116
        Me.LBL_Num.Text = "0"
        Me.LBL_Num.Visible = False
        '
        'MoneyCashIn_Out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 251)
        Me.Controls.Add(Me.LBL_Num)
        Me.Controls.Add(Me.BTN_CashOut)
        Me.Controls.Add(Me.BTN_CashIn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_EnterAmount)
        Me.Controls.Add(Me.LBL_NewBal)
        Me.Controls.Add(Me.LBL_Balance)
        Me.Controls.Add(Me.LBL_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MoneyCashIn_Out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBL_Name As Label
    Friend WithEvents LBL_Balance As Label
    Friend WithEvents LBL_NewBal As Label
    Friend WithEvents TXT_EnterAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BTN_CashIn As Button
    Friend WithEvents BTN_CashOut As Button
    Friend WithEvents LBL_Num As Label
End Class
