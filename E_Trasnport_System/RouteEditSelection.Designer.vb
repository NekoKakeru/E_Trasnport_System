<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RouteEditSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RouteEditSelection))
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.LB_Selected = New System.Windows.Forms.ListBox()
        Me.TXT_Search = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LB_Route = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBL_RT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.BTN_ADD.Location = New System.Drawing.Point(346, 119)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(134, 39)
        Me.BTN_ADD.TabIndex = 99
        Me.BTN_ADD.Text = "Add"
        Me.BTN_ADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD.UseVisualStyleBackColor = False
        '
        'LB_Selected
        '
        Me.LB_Selected.FormattingEnabled = True
        Me.LB_Selected.Location = New System.Drawing.Point(496, 43)
        Me.LB_Selected.Name = "LB_Selected"
        Me.LB_Selected.Size = New System.Drawing.Size(320, 238)
        Me.LB_Selected.TabIndex = 102
        '
        'TXT_Search
        '
        Me.TXT_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TXT_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_Search.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Search.Location = New System.Drawing.Point(74, 15)
        Me.TXT_Search.MaxLength = 100
        Me.TXT_Search.Name = "TXT_Search"
        Me.TXT_Search.Size = New System.Drawing.Size(258, 22)
        Me.TXT_Search.TabIndex = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 22)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Search"
        '
        'LB_Route
        '
        Me.LB_Route.FormattingEnabled = True
        Me.LB_Route.Location = New System.Drawing.Point(12, 43)
        Me.LB_Route.Name = "LB_Route"
        Me.LB_Route.Size = New System.Drawing.Size(320, 238)
        Me.LB_Route.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(682, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 39)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Save"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LBL_RT
        '
        Me.LBL_RT.AutoSize = True
        Me.LBL_RT.Location = New System.Drawing.Point(99, 315)
        Me.LBL_RT.Name = "LBL_RT"
        Me.LBL_RT.Size = New System.Drawing.Size(13, 13)
        Me.LBL_RT.TabIndex = 104
        Me.LBL_RT.Text = "0"
        Me.LBL_RT.Visible = False
        '
        'RouteEditSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(828, 355)
        Me.Controls.Add(Me.LBL_RT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_ADD)
        Me.Controls.Add(Me.LB_Selected)
        Me.Controls.Add(Me.TXT_Search)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LB_Route)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RouteEditSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select New Route"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_ADD As Button
    Friend WithEvents LB_Selected As ListBox
    Friend WithEvents TXT_Search As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LB_Route As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LBL_RT As Label
End Class
