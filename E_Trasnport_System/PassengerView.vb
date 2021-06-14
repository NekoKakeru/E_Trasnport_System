Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.IO
Public Class PassengerView

    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim Result As Integer
    Dim ImgPath As String
    Dim ArrImage() As Byte
    Dim PersonType As String
    Dim Con As String = "server=localhost;userid=root;password=nekokakeru;database=etransportdb"

    Public Sub Connection()
        SqlCon.ConnectionString = Con
        If SqlCon.State = ConnectionState.Open Then
            SqlCon.Close()
        End If
        SqlCon.Open()
    End Sub

    Private Sub PassengerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enabled_F()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.Value = Date.Today
    End Sub

    Public Sub Enabled_F()
        TXT_First.Enabled = False
        TXT_Middle.Enabled = False
        TXT_Last.Enabled = False
        CB_Gender.Enabled = False
        TXT_Age.Enabled = False
        TXT_ContactNo.Enabled = False
        TXT_BirthPlace.Enabled = False
        TXT_Address.Enabled = False
        RB_PWD.Enabled = False
        RB_Reg.Enabled = False
        RB_Senior.Enabled = False
        RB_Student.Enabled = False
        TXT_eFirst.Enabled = False
        TXT_eMiddle.Enabled = False
        TXT_eLast.Enabled = False
        TXT_eRelationship.Enabled = False
        TXT_eContactNo.Enabled = False
        TXT_eAddress.Enabled = False
        BTN_Upload.Enabled = False
        BTN_Take.Enabled = False
        DateTimePicker1.Visible = False
        BTN_Save.Visible = False
        LBL_PCN1.Visible = False
        BTN_GCN.Visible = False
    End Sub
    Public Sub Enabled_T()
        TXT_First.Enabled = True
        TXT_Middle.Enabled = True
        TXT_Last.Enabled = True
        CB_Gender.Enabled = True
        TXT_Age.Enabled = True
        TXT_ContactNo.Enabled = True
        TXT_BirthPlace.Enabled = True
        TXT_Address.Enabled = True
        RB_PWD.Enabled = True
        RB_Reg.Enabled = True
        RB_Senior.Enabled = True
        RB_Student.Enabled = True
        TXT_eFirst.Enabled = True
        TXT_eMiddle.Enabled = True
        TXT_eLast.Enabled = True
        TXT_eRelationship.Enabled = True
        TXT_eContactNo.Enabled = True
        TXT_eAddress.Enabled = True
        BTN_Upload.Enabled = True
        BTN_Take.Enabled = True
        DateTimePicker1.Visible = True
        BTN_Save.Visible = True
        LBL_PCN1.Visible = True
        BTN_GCN.Visible = True
    End Sub

    Private Sub BTN_Edit_Click(sender As Object, e As EventArgs) Handles BTN_Edit.Click
        Enabled_T()
        LBL_PCN1.Visible = False
        LBL_Birthdate.Visible = False
        LBL_PCN.Visible = True

        BTN_Delete.Text = "Cancel"
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Connection()
        If BTN_Delete.Text = "Delete" Then
            Try
                If (MsgBox(“Are you sure you want to delete the Account?”, vbYesNo + vbQuestion, "Delete Account") = MsgBoxResult.Yes) Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = “DELETE FROM etransportdb.tbl_passenger WHERE PassengerCardNum = '" & LBL_PCN.Text & "'”
                    SqlCmd.ExecuteNonQuery()
                    MsgBox(“Account Deleted!”, vbOKOnly + vbInformation, "System Information")
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_passenger"
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    ManageAccount.DataGridView1.DataSource = sqlDT
                    ManageAccount.HideColumnP()
                    ManageAccount.DataGridView1.DefaultCellStyle.Font = New Font("Palatino Linotype", 12)
                    ManageAccount.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Palatino Linotype", 12, FontStyle.Bold)
                    If (sqlDT.Rows.Count = 0) Then
                        MsgBox("No Data Left. Please Registered a Passenger Profile." & vbNewLine & "Thank you!", vbOKOnly + vbInformation, "System Information")
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
            LBL_PCN.Visible = True
            BTN_Delete.Text = "Delete"
            Dim row As DataGridViewRow = ManageAccount.DataGridView1.CurrentRow
            LBL_PCN.Text = row.Cells(0).Value.ToString
            TXT_First.Text = row.Cells(1).Value.ToString
            TXT_Middle.Text = row.Cells(2).Value.ToString
            TXT_Last.Text = row.Cells(3).Value.ToString
            CB_Gender.Text = row.Cells(4).Value.ToString
            TXT_Age.Text = row.Cells(5).Value.ToString
            TXT_ContactNo.Text = row.Cells(7).Value.ToString
            TXT_Address.Text = row.Cells(6).Value.ToString
            LBL_Birthdate.Text = row.Cells(8).Value.ToString
            TXT_BirthPlace.Text = row.Cells(9).Value.ToString

            If row.Cells(10).Value.ToString = "Student" Then
                RB_Student.Checked = True
            ElseIf row.Cells(10).Value.ToString = "PWD" Then
                RB_PWD.Checked = True
            ElseIf row.Cells(10).Value.ToString = "Senior Citizen" Then
                RB_Senior.Checked = True
            ElseIf row.Cells(10).Value.ToString = "Regular" Then
                RB_Reg.Checked = True
            End If

            TXT_eFirst.Text = row.Cells(11).Value.ToString
            TXT_eMiddle.Text = row.Cells(12).Value.ToString
            TXT_eLast.Text = row.Cells(13).Value.ToString
            TXT_eRelationship.Text = row.Cells(14).Value.ToString
            TXT_eContactNo.Text = row.Cells(15).Value.ToString
            TXT_eAddress.Text = row.Cells(16).Value.ToString

            Dim img() As Byte
            img = row.Cells(18).Value
            Dim MS As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(MS)
            Enabled_F()

            LBL_PCN1.Text = row.Cells(0).Value.ToString
            LBL_PCN.Visible = True
            LBL_PCN1.Visible = False
            BTN_GCN.Enabled = True
            DateTimePicker1.Format = DateTimePickerFormat.Custom
            DateTimePicker1.CustomFormat = "MM/dd/yyyy"
            DateTimePicker1.Value = Date.Today
            SqlCon.Close()
        End If
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
        CameraFrame.LBL_Identfier.Text = "EDIT_PAS"
        CameraFrame.ShowDialog()
    End Sub

    Private Sub BTN_GCN_Click(sender As Object, e As EventArgs) Handles BTN_GCN.Click
        PassengerGCN.LBL_Identfier.Text = "Edit_Pas"
        LBL_PCN1.Visible = True
        PassengerGCN.ShowDialog()

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

                sqlQuery = "UPDATE etransportdb.tbl_passenger SET PassengerCardNum ='" & LBL_PCN1.Text & "', Firstname ='" & TXT_First.Text & "', Middlename ='" & TXT_Middle.Text & "', Lastname ='" & TXT_Last.Text & "',
                Gender ='" & CB_Gender.Text & "', Age ='" & TXT_Age.Text & "', Address ='" & TXT_Address.Text & "', ContactNo ='" & TXT_ContactNo.Text & "', Birthday='" & DateTimePicker1.Text & "', BirthPlace= '" & TXT_BirthPlace.Text & "', PersonType ='" & PersonType & "',
                CPIE_Firstname ='" & TXT_eFirst.Text & "', CPIE_Middlename ='" & TXT_eMiddle.Text & "', CPIE_Lastname ='" & TXT_eLast.Text & "', Relationship ='" & TXT_eRelationship.Text & "',
                CPIE_ContactNo ='" & TXT_eContactNo.Text & "', CPIE_Address ='" & TXT_eAddress.Text & "', Picture =@Picture  WHERE PassengerCardNum = '" & LBL_PCN.Text & "' "

                RunSql(sqlQuery)
                BTN_GCN.Enabled = True
                LBL_Birthdate.Visible = True
                'LBL_Birthdate.Text = DateTimePicker1.Text
                BTN_Delete.Text = "Delete"
                LBL_PCN.Visible = True
                LBL_PCN.Text = LBL_PCN1.Text
                Dim row As DataGridViewRow = ManageAccount.DataGridView1.CurrentRow
                LBL_PCN.Text = row.Cells(0).Value.ToString
                Enabled_F()
                ManageAccount.LBL_Read.Text = "0"
                ManageAccount.PassengerTable()
                Me.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Critical")
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