Imports MySql.Data.MySqlClient

Public Class PassengerRegistration

    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim PersonType As String

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


    Private Sub PassengerRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub PassengerRegistration_Click(sender As Object, e As EventArgs) Handles Me.Click
        MainFrame.Hide_Panel()
    End Sub

    Private Sub LBL_PCN_Click(sender As Object, e As EventArgs) Handles LBL_PCN.Click

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

    Private Sub BTN_Take_Click(sender As Object, e As EventArgs) Handles BTN_Take.Click
        CameraFrame.LBL_Identfier.Text = "PAS"
        CameraFrame.ShowDialog()
    End Sub


    Public Sub ClearFields()
        LBL_PCN.Text = "0000000000"
        TXT_First.Text = ""
        TXT_Middle.Text = ""
        TXT_Last.Text = ""
        CB_Gender.Text = ""
        TXT_Age.Text = ""
        TXT_ContactNo.Text = ""
        DateTimePicker1.Value = Date.Today
        TXT_BirthPlace.Text = ""
        TXT_Address.Text = ""
        RB_PWD.Checked = False
        RB_Reg.Checked = False
        RB_Senior.Checked = False
        RB_Student.Checked = False
        PictureBox1.Image = Nothing
        LBL_PIC.Text = "0"
        TXT_eFirst.Text = ""
        TXT_eMiddle.Text = ""
        TXT_eLast.Text = ""
        TXT_eRelationship.Text = ""
        TXT_eContactNo.Text = ""
        TXT_eAddress.Text = ""
        BTN_GCN.Enabled = True
    End Sub
    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        Dim ans As String = MsgBox("Are sure you want to clear the fields?", vbYesNo + vbQuestion, "System Information")
        If ans = vbYes Then
            ClearFields()
        End If
    End Sub

    Private Sub BTN_GCN_Click(sender As Object, e As EventArgs) Handles BTN_GCN.Click
        PassengerGCN.LBL_Identfier.Text = "Save_Pas"
        PassengerGCN.ShowDialog()
    End Sub

    Private Sub BTN_Reg_Click(sender As Object, e As EventArgs) Handles BTN_Reg.Click
        Connection()
        Try

            If LBL_PCN.Text = "0000000000" Or TXT_First.Text = "" Or TXT_Middle.Text = "" Or TXT_Last.Text = "" Or CB_Gender.Text = "" Or TXT_Age.Text = "" Or TXT_ContactNo.Text = "" Or DateTimePicker1.Value = Date.Today Or
                TXT_BirthPlace.Text = "" Or TXT_Address.Text = "" Or RB_PWD.Checked = False And RB_Reg.Checked = False And RB_Senior.Checked = False And RB_Student.Checked = False Or LBL_PIC.Text = "0" Or TXT_eFirst.Text = "" Or
                TXT_eMiddle.Text = "" Or TXT_eLast.Text = "" Or TXT_eRelationship.Text = "" Or TXT_eContactNo.Text = "" Or TXT_eAddress.Text = "" Then

                MsgBox("Please continue filling out the form to complete it!!!", vbOKOnly + vbInformation, "System Information")

            Else
                Dim Msstream As New System.IO.MemoryStream
                PictureBox1.Image.Save(Msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ArrImage = Msstream.GetBuffer()
                Dim File_Size As UInt32
                File_Size = Msstream.Length
                Msstream.Close()

                Dim cash As Double = 0

                Dim SqlQuery = "insert into etransportdb.tbl_passenger(PassengerCardNum,Firstname,Lastname,Middlename,Gender,Age,Address,ContactNo,Birthday,BirthPlace,PersonType,CPIE_Firstname,CPIE_Middlename,CPIE_Lastname,Relationship,CPIE_ContactNo, CPIE_Address,Cash,Picture)
                    values('" & LBL_PCN.Text & "','" & TXT_First.Text & "','" & TXT_Middle.Text & "','" & TXT_Last.Text & "','" & CB_Gender.Text & "','" & TXT_Age.Text & "','" & TXT_Address.Text & "', '" & TXT_ContactNo.Text & "',
                    '" & DateTimePicker1.Text & "','" & TXT_BirthPlace.Text & "','" & PersonType & "','" & TXT_eFirst.Text & "','" & TXT_eMiddle.Text & "','" & TXT_eLast.Text & "','" & TXT_eRelationship.Text & "',
                    '" & TXT_eContactNo.Text & "', '" & TXT_eAddress.Text & "','" & cash & "',@Picture)"


                SqlCmd.Connection = SqlCon
                SqlCmd.CommandText = SqlQuery
                SqlCmd.Parameters.AddWithValue("@Picture", ArrImage)

                SqlCmd.ExecuteNonQuery()
                SqlCmd.Parameters.Clear()

                MsgBox("New Passenger Record Added.", vbOKOnly + vbInformation, "System Information")

                ClearFields()
                SqlCon.Close()
            End If
        Catch ex As Exception
            MsgBox("An error occured while registering the profile!", vbOKOnly + vbCritical, "System Error")
            ClearFields()
        Finally
            SqlCon.Dispose()
        End Try

    End Sub

    Private Sub RB_Reg_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Reg.CheckedChanged
        PersonType = "Regular"
    End Sub

    Private Sub RB_Senior_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Senior.CheckedChanged
        PersonType = "Senior Citizen"
    End Sub

    Private Sub RB_Student_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Student.CheckedChanged
        PersonType = "Student"
    End Sub

    Private Sub RB_PWD_CheckedChanged(sender As Object, e As EventArgs) Handles RB_PWD.CheckedChanged
        PersonType = "PWD"
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class