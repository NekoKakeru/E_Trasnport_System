Imports MySql.Data.MySqlClient

Public Class DriverRegistration
    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRD As MySqlDataReader
    Dim SqlDT As New DataTable
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

    Public Sub ListTable()
        Connection()

        SqlQuery = "SELECT * FROM etransportdb.tbl_lopezbrgy"
        SqlCmd.Connection = SqlCon
        SqlCmd.CommandText = SqlQuery
        SqlRD = SqlCmd.ExecuteReader

        SqlDT.Load(SqlRD)
        SqlRD.Close()

        LB_Route.DataSource = SqlDT
        LB_Route.DisplayMember = "Barangays"
        LB_Route.ValueMember = "ID"
        SqlCon.Close()
    End Sub

    Public Sub ClearFields()
        LBL_PCN.Text = "0000000000"
        BTN_GTN.Enabled = True
        TXT_PlateNo.Text = ""
        DateTimePicker1.Value = Date.Today
        TXT_First.Text = ""
        TXT_Middle.Text = ""
        TXT_Last.Text = ""
        LBL_PIC.Text = ""
        PictureBox1.Image = Nothing
        CB_Gender.Text = ""
        TXT_ContactNo.Text = ""
        TXT_BirthPlace.Text = ""
        TXT_Address.Text = ""
        TXT_Age.Text = ""
        LB_Selected.Items.Clear()
        LBL_PIC.Text = "0"
        LBL_RT.Text = "0"
        LBL_LB.Text = ""
    End Sub

    Private Sub DriverRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        ListTable()
    End Sub

    Private Sub DriverRegistration_Click(sender As Object, e As EventArgs) Handles Me.Click
        MainFrame.Hide_Panel()
    End Sub

    Private Sub BTN_Take_Click(sender As Object, e As EventArgs) Handles BTN_Take.Click
        CameraFrame.LBL_Identfier.Text = "DRI"
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

    Private Sub BTN_GTN_Click(sender As Object, e As EventArgs) Handles BTN_GTN.Click
        Dim RandomNum As New Random

        Dim DelayLoad As Long = 1
        For DelayLoad = 1 To 1000000
            Cursor = Cursors.WaitCursor()
            DelayLoad = DelayLoad + 1
        Next

        LBL_PCN.Text = "TD - " & RandomNum.Next(10000, 90000)
        MsgBox("Done generating Tryicle Number!", vbOKOnly + vbInformation, "System Information")
        Cursor = Cursors.Default()
        BTN_GTN.Enabled = False
    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        Dim ans As String = MsgBox("Are sure you want to clear the fields?", vbYesNo + vbQuestion, "System Information")
        If ans = vbYes Then
            ClearFields()
        End If
    End Sub

    Private Sub TXT_Search_TextChanged(sender As Object, e As EventArgs) Handles TXT_Search.TextChanged
        Connection()
        Try
            SqlCmd = SqlCon.CreateCommand()
            SqlCmd.CommandType = CommandType.Text
            SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_lopezbrgy where Barangays  like '%" & TXT_Search.Text & "%' "
            SqlCmd.ExecuteNonQuery()

            Dim sqlDT As New DataTable
            Dim DtA As New MySqlDataAdapter(SqlCmd)
            DtA.Fill(sqlDT)

            LB_Route.DataSource = sqlDT
            LB_Route.DisplayMember = "Barangays"
            LB_Route.ValueMember = "ID"

            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Critical")
        Finally
            SqlCon.Dispose()
        End Try

    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
        Try
            If LBL_RT.Text <> "0" Then
                LBL_RT.Text += LB_Route.GetItemText(LB_Route.SelectedItem) & "-"
            Else
                LBL_RT.Text = LB_Route.GetItemText(LB_Route.SelectedItem) & "-"
            End If
            LBL_LB.Text = "1"
            LB_Selected.Items.Add(LB_Route.GetItemText(LB_Route.SelectedItem))

        Catch ex As Exception
            MsgBox("No item to be selected!!!", vbOKOnly + vbCritical, "System Critical")
        End Try
    End Sub

    Private Sub BTN_Reg_Click(sender As Object, e As EventArgs) Handles BTN_Reg.Click
        Connection()
        Try
            If LBL_PCN.Text = "0000000000" Or TXT_PlateNo.Text = "" Or TXT_First.Text = "" Or TXT_Middle.Text = "" Or TXT_Last.Text = "" Or CB_Gender.Text = "" Or
                TXT_ContactNo.Text = "" Or TXT_Age.Text = "" Or TXT_Address.Text = "" Or LBL_PIC.Text = "0" Or LBL_LB.Text = "0" Or TXT_BirthPlace.Text = "" Or DateTimePicker1.Value = Date.Today Then

                MsgBox("Please continue filling out the form to complete it!!!", vbOKOnly + vbInformation, "System Information")

            Else
                LBL_RT.Text = LBL_RT.Text.Remove(LBL_RT.Text.Length - 1)
                Dim Msstream As New System.IO.MemoryStream
                PictureBox1.Image.Save(Msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ArrImage = Msstream.GetBuffer()
                Dim File_Size As UInt32
                File_Size = Msstream.Length
                Msstream.Close()

                Dim cash As Double = 0
                Dim SqlQuery = "insert into etransportdb.tbl_tricycle_driver(TricycleNo,TricyclePlateNo,Firstname,Middlename,Lastname,Age,Gender,Address,ContactNo,Birthday,BirthPlace,Route,Cash,Picture)
                values('" & LBL_PCN.Text & "','" & TXT_PlateNo.Text & "', '" & TXT_First.Text & "','" & TXT_Middle.Text & "','" & TXT_Last.Text & "', '" & TXT_Age.Text & "',
                '" & CB_Gender.Text & "','" & TXT_Address.Text & "', '" & TXT_ContactNo.Text & "', '" & DateTimePicker1.Text & "','" & TXT_BirthPlace.Text & "', '" & LBL_RT.Text & "', '" & cash & "', @Picture)"

                SqlCmd.Connection = SqlCon
                SqlCmd.CommandText = SqlQuery
                SqlCmd.Parameters.AddWithValue("@Picture", ArrImage)

                SqlCmd.ExecuteNonQuery()
                SqlCmd.Parameters.Clear()
                MsgBox("New Driver Record Added.", vbOKOnly + vbInformation, "System Information")

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
End Class