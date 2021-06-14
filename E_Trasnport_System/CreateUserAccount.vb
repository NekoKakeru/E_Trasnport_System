Imports MySql.Data.MySqlClient

Public Class CreateUserAccount

    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim PersonType As String
    Dim SqlQuery As String

    Dim Result As Integer
    Dim ImgPath As String
    Dim ArrImage() As Byte

    Dim Con As String = "server=localhost;userid=root;password=nekokakeru;database=etransportdb"

    Public Sub Connection()
        SqlCon.ConnectionString = Con
        If SqlCon.State = ConnectionState.Open Then
            SqlCon.Close()
        End If
        SqlCon.Open()
    End Sub

    Private Sub BTN_GU_Click(sender As Object, e As EventArgs)
        If TXTLast.Text = "" Then
            MsgBox("Please fill the Lastname!!!", vbOKOnly + vbInformation, "System Information")
        ElseIf CBPosition.Text = "" Then
            MsgBox("Please fill the Position!!!", vbOKOnly + vbInformation, "System Information")
        Else
            LBLUsername.Text = CBPosition.Text & "-" & TXTLast.Text
        End If
    End Sub

    Private Sub LBLUsername_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CreateUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        Panel1.Visible = True

        LBL_Date.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub CreateUserAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MainFrame.lblSet1.Text = "show"
        'TXTFirst.Text = ""
        'TXTLast.Text = ""
        'TXTMiddle.Text = ""
        Me.Dispose()
    End Sub

    Private Sub BTN_Take_Click(sender As Object, e As EventArgs) Handles BTN_Take.Click
        CameraFrame.LBL_Identfier.Text = "USER"
        CameraFrame.ShowDialog()
    End Sub

    Private Sub BTN_Upload_Click(sender As Object, e As EventArgs) Handles BTN_Upload.Click
        Try
            Dim open As OpenFileDialog = New OpenFileDialog
            open.Filter = "Image Files (JPG) |*.jpg"
            open.Title = "Upload Picture"
            If open.ShowDialog = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(open.FileName)
                LBL_PIC.Text = "1"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Error")
        End Try
    End Sub

    Private Sub BTN_GIDNum_Click(sender As Object, e As EventArgs) Handles BTN_GIDNum.Click
        PassengerGCN.LBL_Identfier.Text = "USER"
        PassengerGCN.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBL_Count.Text = Val(LBL_Count.Text) + 5
        Cursor = Cursors.WaitCursor()

        If LBL_Count.Text = 100 Then
            Timer1.Stop()
            LBLUsername.Text = "@" & CBPosition.Text & "" & TXTLast.Text
            Panel2.Visible = True
            Panel1.Visible = False
            Cursor = Cursors.Default()
        End If

    End Sub

    Private Sub BTN_Next_Click(sender As Object, e As EventArgs) Handles BTN_Next.Click
        If LBL_Count.Text = "" Or TXTFirst.Text = "" Or TXTLast.Text = "" Or TXTMiddle.Text = "" Or CBGender.Text = "" Or CBPosition.Text = "" Or TXTAge.Text = "" Or TXTContactNo.Text = "" Or LBL_PIC.Text = "0" Then
            MsgBox("Please continue filling out the form to complete it!!!", vbOKOnly + vbInformation, "System Information")
        Else
            LBL_Comment.Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTNCreate_Click(sender As Object, e As EventArgs) Handles BTNCreate.Click
        Connection()
        Try
            If TXTPassword.Text = "" Then
                MsgBox("Please enter a password!!!", vbOKOnly + vbInformation, "System Information")
            Else
                If TXTPassword.Text <> TXTConfirmPassword.Text Or TXTConfirmPassword.Text = "" Then
                    LBL_Comment1.Visible = True
                Else
                    Dim Msstream As New System.IO.MemoryStream
                    PictureBox1.Image.Save(Msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    ArrImage = Msstream.GetBuffer()
                    Dim File_Size As UInt32
                    File_Size = Msstream.Length
                    Msstream.Close()

                    SqlQuery = "insert into etransportdb.tbl_admin(UserID,Username,Password,Firstname,Middlename,Lastname,ContactNo,Gender,Age,UserDateAdded,Position,Picture)
                        values('" & LBL_IDNum.Text & "','" & LBLUsername.Text & "','" & TXTPassword.Text & "','" & TXTFirst.Text & "','" & TXTMiddle.Text & "','" & TXTLast.Text & "',
                               '" & TXTContactNo.Text & "','" & CBGender.Text & "','" & TXTAge.Text & "','" & LBL_Date.Text & "','" & CBPosition.Text & "',@Picture)"

                    SqlCmd.Connection = SqlCon
                    SqlCmd.CommandText = SqlQuery
                    SqlCmd.Parameters.AddWithValue("@Picture", ArrImage)

                    SqlCmd.ExecuteNonQuery()
                    SqlCmd.Parameters.Clear()

                    MsgBox("User Added!!!", vbOKOnly + vbInformation, "System Information")
                    LBL_Comment1.Visible = False
                    Me.Dispose()
                End If
            End If
            SqlCon.Close()
        Catch ex As Exception
            MsgBox("An error occured while registering the profile!", vbOKOnly + vbCritical, "System Error")
        Finally
            SqlCon.Dispose()
        End Try

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TXTConfirmPassword.PasswordChar = ""
        Else
            TXTConfirmPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TXTPassword.PasswordChar = ""
        Else
            TXTPassword.PasswordChar = "*"
        End If
    End Sub
End Class