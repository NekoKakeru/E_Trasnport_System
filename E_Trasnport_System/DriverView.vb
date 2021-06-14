Imports MySql.Data.MySqlClient
Imports System.IO
Public Class DriverView

    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
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

    Public Sub Enabled_F()
        TXT_PlateNo.Enabled = False
        TXT_First.Enabled = False
        TXT_Middle.Enabled = False
        TXT_Last.Enabled = False
        TXT_ContactNo.Enabled = False
        TXT_BirthPlace.Enabled = False
        TXT_Age.Enabled = False
        TXT_Address.Enabled = False
        BTN_Take.Enabled = False
        BTN_Upload.Enabled = False
        BTN_Select.Enabled = False
        BTN_Save.Visible = False
        BTN_GTN.Visible = False
        CB_Gender.Enabled = False
        DateTimePicker1.Visible = False
    End Sub

    Public Sub Enabled_T()
        TXT_PlateNo.Enabled = True
        TXT_First.Enabled = True
        TXT_Middle.Enabled = True
        TXT_Last.Enabled = True
        TXT_ContactNo.Enabled = True
        TXT_BirthPlace.Enabled = True
        TXT_Age.Enabled = True
        TXT_Address.Enabled = True
        BTN_Take.Enabled = True
        BTN_Upload.Enabled = True
        BTN_Select.Enabled = True
        BTN_Save.Visible = True
        BTN_GTN.Visible = True
        CB_Gender.Enabled = True
        DateTimePicker1.Visible = True
    End Sub

    Private Sub DriverView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enabled_F()
        BTN_Delete.Text = "Delete"
        BTN_Edit.Visible = True
        BTN_GTN.Enabled = True
        LBL_TN1.Visible = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Value = Date.Today
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
        CameraFrame.LBL_Identfier.Text = "EDIT_DRI"
        CameraFrame.ShowDialog()
    End Sub

    Private Sub BTN_GTN_Click(sender As Object, e As EventArgs) Handles BTN_GTN.Click
        LBL_TN1.Visible = True
        Dim RandomNum As New Random

        Dim DelayLoad As Long = 1
        For DelayLoad = 1 To 1000000
            Cursor = Cursors.WaitCursor()
            DelayLoad = DelayLoad + 1
        Next

        LBL_TN1.Text = "TD - " & RandomNum.Next(10000, 90000)
        MsgBox("Done generating Tryicle Number!" & vbNewLine & "Tricyle Number have been changed.", vbOKOnly + vbInformation, "System Information")
        Cursor = Cursors.Default()
        BTN_GTN.Enabled = False
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Connection()
        If BTN_Delete.Text = "Delete" Then
            Try
                If (MsgBox(“Are you sure you want to delete the Account?”, vbYesNo + vbQuestion, "Delete Account") = MsgBoxResult.Yes) Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = “DELETE FROM etransportdb.tbl_tricycle_driver WHERE TricycleNo = '" & LBL_TN.Text & "'”
                    SqlCmd.ExecuteNonQuery()
                    MsgBox(“Account Deleted!”, vbOKOnly + vbInformation, "System Information")


                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_tricycle_driver"
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    ManageAccount.DataGridView2.DataSource = sqlDT
                    ManageAccount.HideColumnP()
                    ManageAccount.DataGridView2.DefaultCellStyle.Font = New Font("Palatino Linotype", 12)
                    ManageAccount.DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Palatino Linotype", 12, FontStyle.Bold)

                    If (sqlDT.Rows.Count = 0) Then
                        MsgBox("No Data Left. Please Registered a Driver Profile." & vbNewLine & "Thank you!", vbOKOnly + vbInformation, "System Information")
                        ManageAccount.LBL_Read.Text = "0"
                        Me.Close()
                        ManageAccount.BTN_View.Enabled = False
                    Else
                        Me.Close()
                        ManageAccount.LBL_Read.Text = "0"
                        ManageAccount.BTN_View.Enabled = False
                    End If
                    SqlCon.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "System Critical")
            Finally
                SqlCon.Dispose()
            End Try
        ElseIf BTN_Delete.Text = "Cancel" Then
            LBL_Birthdate.Visible = True
            ' LBL_PCN.Visible = True
            BTN_Delete.Text = "Delete"
            Dim row As DataGridViewRow = ManageAccount.DataGridView2.CurrentRow

            LBL_TN.Text = row.Cells(0).Value.ToString
            TXT_PlateNo.Text = row.Cells(1).Value.ToString
            TXT_First.Text = row.Cells(2).Value.ToString
            TXT_Middle.Text = row.Cells(3).Value.ToString
            TXT_Last.Text = row.Cells(4).Value.ToString
            TXT_Age.Text = row.Cells(5).Value.ToString
            CB_Gender.Text = row.Cells(6).Value.ToString
            TXT_Address.Text = row.Cells(7).Value.ToString
            TXT_ContactNo.Text = row.Cells(8).Value.ToString
            LBL_Birthdate.Text = row.Cells(9).Value.ToString
            TXT_BirthPlace.Text = row.Cells(10).Value.ToString
            LBL_Route.Text = row.Cells(11).Value.ToString

            Dim img() As Byte
            img = row.Cells(13).Value
            Dim MS As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(MS)

            BTN_GTN.Enabled = True
            BTN_Edit.Visible = True
            LBL_TN1.Text = row.Cells(0).Value.ToString

            LBL_TN1.Visible = False
            Enabled_F()
            SqlCon.Close()
        End If
    End Sub

    Private Sub BTN_Edit_Click(sender As Object, e As EventArgs) Handles BTN_Edit.Click
        Enabled_T()
        BTN_Save.Visible = True
        BTN_Edit.Visible = False
        BTN_GTN.Visible = True
        BTN_Select.Visible = True
        BTN_Delete.Text = "Cancel"
        'LBL_TN1.Visible = True
        LBL_Birthdate.Visible = False
    End Sub

    Public Sub RunSql(ByRef sql As String)
        Dim cmd As New MySqlCommand
        Connection()
        Try
            cmd.Connection = SqlCon
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@Picture", ArrImage)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Account has been Updated!!!", vbOKOnly + vbInformation, "System Information")

            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Error")
        End Try
    End Sub
    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Try
            If MsgBox("Are you sure you want to edit the profile?", vbYesNo + vbQuestion, "System Question") = vbYes Then

                Dim Msstream As New System.IO.MemoryStream
                PictureBox1.Image.Save(Msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                ArrImage = Msstream.GetBuffer()
                Dim File_Size As UInt32
                File_Size = Msstream.Length
                Msstream.Close()

                Dim sqlQuery As String

                sqlQuery = "UPDATE etransportdb.tbl_tricycle_driver SET TricycleNo ='" & LBL_TN1.Text & "', TricyclePlateNo ='" & TXT_PlateNo.Text & "', Firstname ='" & TXT_First.Text & "', Middlename ='" & TXT_Middle.Text & "', 
                    Lastname ='" & TXT_Last.Text & "', Age ='" & TXT_Age.Text & "', Gender ='" & CB_Gender.Text & "', Address ='" & TXT_Address.Text & "', ContactNo ='" & TXT_ContactNo.Text & "', Birthday= '" & DateTimePicker1.Text & "',
                    BirthPlace ='" & TXT_BirthPlace.Text & "', Picture=@Picture WHERE TricycleNo = '" & LBL_TN.Text & "' "

                RunSql(sqlQuery)

                Enabled_F()
                ManageAccount.LBL_Read.Text = "0"
                BTN_Delete.Text = "Delete"
                LBL_Birthdate.Visible = True
                BTN_Edit.Visible = True
                ManageAccount.DriverTable()
                Dim row As DataGridViewRow = ManageAccount.DataGridView2.CurrentRow
                LBL_TN1.Text = row.Cells(0).Value.ToString
                BTN_GTN.Enabled = True
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Critical")
        Finally
            SqlCon.Dispose()
        End Try
    End Sub

    Private Sub DriverView_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub BTN_Select_Click(sender As Object, e As EventArgs) Handles BTN_Select.Click
        RouteEditSelection.ShowDialog()
    End Sub
End Class