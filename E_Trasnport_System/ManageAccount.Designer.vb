<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RB_Last = New System.Windows.Forms.RadioButton()
        Me.RB_First = New System.Windows.Forms.RadioButton()
        Me.RB_Num = New System.Windows.Forms.RadioButton()
        Me.TXT_Search = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_Dri = New System.Windows.Forms.Button()
        Me.BTN_Pas = New System.Windows.Forms.Button()
        Me.BTN_View = New System.Windows.Forms.Button()
        Me.LBL_Read = New System.Windows.Forms.Label()
        Me.LBL_Identfier = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(721, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Search by:"
        '
        'RB_Last
        '
        Me.RB_Last.AutoSize = True
        Me.RB_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Last.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Last.Location = New System.Drawing.Point(997, 98)
        Me.RB_Last.Name = "RB_Last"
        Me.RB_Last.Size = New System.Drawing.Size(84, 22)
        Me.RB_Last.TabIndex = 110
        Me.RB_Last.TabStop = True
        Me.RB_Last.Text = "Lastname"
        Me.RB_Last.UseVisualStyleBackColor = True
        '
        'RB_First
        '
        Me.RB_First.AutoSize = True
        Me.RB_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_First.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_First.Location = New System.Drawing.Point(905, 98)
        Me.RB_First.Name = "RB_First"
        Me.RB_First.Size = New System.Drawing.Size(86, 22)
        Me.RB_First.TabIndex = 109
        Me.RB_First.TabStop = True
        Me.RB_First.Text = "Firstname"
        Me.RB_First.UseVisualStyleBackColor = True
        '
        'RB_Num
        '
        Me.RB_Num.AutoSize = True
        Me.RB_Num.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_Num.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Num.Location = New System.Drawing.Point(797, 98)
        Me.RB_Num.Name = "RB_Num"
        Me.RB_Num.Size = New System.Drawing.Size(92, 22)
        Me.RB_Num.TabIndex = 108
        Me.RB_Num.TabStop = True
        Me.RB_Num.Text = "ID Number"
        Me.RB_Num.UseVisualStyleBackColor = True
        '
        'TXT_Search
        '
        Me.TXT_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Search.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Search.Location = New System.Drawing.Point(730, 70)
        Me.TXT_Search.MaxLength = 10
        Me.TXT_Search.Name = "TXT_Search"
        Me.TXT_Search.Size = New System.Drawing.Size(352, 22)
        Me.TXT_Search.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(664, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 22)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1064, 604)
        Me.DataGridView1.TabIndex = 105
        '
        'BTN_Dri
        '
        Me.BTN_Dri.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_Dri.FlatAppearance.BorderSize = 0
        Me.BTN_Dri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Dri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Dri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Dri.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Dri.ForeColor = System.Drawing.Color.White
        Me.BTN_Dri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Dri.Location = New System.Drawing.Point(183, 93)
        Me.BTN_Dri.Name = "BTN_Dri"
        Me.BTN_Dri.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Dri.TabIndex = 104
        Me.BTN_Dri.Text = "Driver"
        Me.BTN_Dri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Dri.UseVisualStyleBackColor = False
        '
        'BTN_Pas
        '
        Me.BTN_Pas.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Pas.FlatAppearance.BorderSize = 0
        Me.BTN_Pas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_Pas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_Pas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Pas.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Pas.ForeColor = System.Drawing.Color.White
        Me.BTN_Pas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Pas.Location = New System.Drawing.Point(18, 93)
        Me.BTN_Pas.Name = "BTN_Pas"
        Me.BTN_Pas.Size = New System.Drawing.Size(163, 39)
        Me.BTN_Pas.TabIndex = 103
        Me.BTN_Pas.Text = "Passenger"
        Me.BTN_Pas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Pas.UseVisualStyleBackColor = False
        '
        'BTN_View
        '
        Me.BTN_View.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BTN_View.FlatAppearance.BorderSize = 0
        Me.BTN_View.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BTN_View.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_View.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_View.ForeColor = System.Drawing.Color.White
        Me.BTN_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_View.Location = New System.Drawing.Point(919, 757)
        Me.BTN_View.Name = "BTN_View"
        Me.BTN_View.Size = New System.Drawing.Size(163, 39)
        Me.BTN_View.TabIndex = 114
        Me.BTN_View.Text = "View"
        Me.BTN_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_View.UseVisualStyleBackColor = False
        '
        'LBL_Read
        '
        Me.LBL_Read.AutoSize = True
        Me.LBL_Read.Location = New System.Drawing.Point(422, 108)
        Me.LBL_Read.Name = "LBL_Read"
        Me.LBL_Read.Size = New System.Drawing.Size(13, 13)
        Me.LBL_Read.TabIndex = 116
        Me.LBL_Read.Text = "0"
        Me.LBL_Read.Visible = False
        '
        'LBL_Identfier
        '
        Me.LBL_Identfier.AutoSize = True
        Me.LBL_Identfier.Location = New System.Drawing.Point(422, 70)
        Me.LBL_Identfier.Name = "LBL_Identfier"
        Me.LBL_Identfier.Size = New System.Drawing.Size(13, 13)
        Me.LBL_Identfier.TabIndex = 115
        Me.LBL_Identfier.Text = "0"
        Me.LBL_Identfier.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(18, 139)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1064, 604)
        Me.DataGridView2.TabIndex = 117
        Me.DataGridView2.Visible = False
        '
        'ManageAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 811)
        Me.Controls.Add(Me.LBL_Read)
        Me.Controls.Add(Me.LBL_Identfier)
        Me.Controls.Add(Me.BTN_View)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RB_Last)
        Me.Controls.Add(Me.RB_First)
        Me.Controls.Add(Me.RB_Num)
        Me.Controls.Add(Me.TXT_Search)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BTN_Dri)
        Me.Controls.Add(Me.BTN_Pas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAccount"
        Me.Text = "ManageAccountFrame"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RB_Last As RadioButton
    Friend WithEvents RB_First As RadioButton
    Friend WithEvents RB_Num As RadioButton
    Friend WithEvents TXT_Search As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_Dri As Button
    Friend WithEvents BTN_Pas As Button
    Friend WithEvents BTN_View As Button
    Friend WithEvents LBL_Read As Label
    Friend WithEvents LBL_Identfier As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
