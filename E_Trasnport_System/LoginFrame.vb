Imports MySql.Data.MySqlClient
Imports System.IO

Public Class LoginFrame
    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlQuery As String
    Dim img() As Byte


    Dim SqlCon1 As New MySqlConnection
    Dim SqlCmd1 As New MySqlCommand
    Dim SqlQuery1 As String

    Dim Con As String = "server=localhost;userid=root;password=nekokakeru;database=etransportdb"

    Public Sub Connection()
        SqlCon.ConnectionString = Con
        If SqlCon.State = ConnectionState.Open Then
            SqlCon.Close()
        End If
        SqlCon.Open()

        SqlCon1.ConnectionString = Con
        If SqlCon1.State = ConnectionState.Open Then
            SqlCon1.Close()
        End If
        SqlCon1.Open()
    End Sub

    Public Sub Count_Logs()
        Connection()
        Try
            SqlQuery1 = "Select count(*) from etransportdb.tbl_logs"
            SqlCmd1 = New MySqlCommand(SqlQuery1, SqlCon1)
            Dim count1 = Convert.ToString(SqlCmd1.ExecuteScalar)

            LBL_Count.Text = count1
            SqlCon.Close()
            SqlCon1.Close()
        Catch ex As Exception
            MsgBox("An error occured while Logging in!!!", vbOKOnly + vbCritical, "System Error")
        Finally
            SqlCon.Dispose()
            SqlCon1.Dispose()
        End Try
    End Sub

    Private Sub LoginFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Count_Logs()
        TXT_Pass.PasswordChar = "*"
        ProgressBar1.Visible = False

        Label5.Width = 1
        Timer2.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TXT_Pass.PasswordChar = ""
        Else
            TXT_Pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        Dim index As Integer = 0
        While index < 1
            Connection()
            'Dim PassQuery As String = "SELECT * FROM etransportdb.tbl_admin where Password = '" & TXT_Pass.Text & "'"
            'Dim UserQuery As String = "SELECT * FROM etransportdb.tbl_admin where Username = '" & TXT_User.Text & "'"
            Try

                If TXT_Pass.Text = Nothing And TXT_User.Text = Nothing Then
                    MsgBox("Please input your Password and Username!!!", vbOKOnly + vbInformation, "System Login")
                ElseIf TXT_User.Text = Nothing Then
                    MsgBox("Please input your Username!!!", vbOKOnly + vbInformation, "System Login")
                ElseIf TXT_Pass.Text = Nothing Then
                    MsgBox("Please input your Password!!!", vbOKOnly + vbInformation, "System Login")
                Else
                    SqlQuery = "SELECT * FROM etransportdb.tbl_admin where Username = '" & TXT_User.Text & "' and Password = '" & TXT_Pass.Text & "'"

                    SqlCmd.Connection = SqlCon
                    SqlCmd.CommandText = SqlQuery

                    Dim SqlDA As MySqlDataAdapter = New MySqlDataAdapter(SqlCmd)
                    Dim DT As New DataTable

                    SqlDA.Fill(DT)

                    If (DT.Rows.Count > 0) Then
                        Using SqlRD As MySqlDataReader = SqlCmd.ExecuteReader()
                            SqlRD.Read()

                            LBL_IDNum.Text = SqlRD("UserID")
                            Dashboard.LBL_IDNum.Text = SqlRD("UserID")
                            Dashboard.LBL_Name.Text = SqlRD("Lastname").ToString & ", " & SqlRD("Firstname").ToString & " " & SqlRD("Middlename").ToString
                            Dashboard.LBL_Type.Text = SqlRD("Position").ToString

                            UserProfile.LBL_IDNum.Text = SqlRD("UserID")
                            UserProfile.LBL_Name.Text = SqlRD("Lastname").ToString & ", " & SqlRD("Firstname").ToString & " " & SqlRD("Middlename").ToString
                            UserProfile.LBL_Position.Text = SqlRD("Position").ToString
                            UserProfile.LBL_Gender.Text = SqlRD("Gender").ToString
                            UserProfile.LBL_Contact.Text = SqlRD("ContactNo").ToString

                            img = SqlRD("Picture")
                            Dim MS As New MemoryStream(img)
                            UserProfile.PictureBox1.Image = Image.FromStream(MS)
                        End Using

                        Timer1.Start()
                        index = 0
                    Else
                        MsgBox("Wrong Credenstials!!!", vbOKOnly + vbCritical, "System Login")
                        TXT_Pass.Text = ""
                        LBL_Count.Text = ""
                        index = 1
                    End If


                    Dim Time_Out As Integer = 0
                    Dim T_val As Integer = LBL_Count.Text

                    SqlQuery1 = "insert into etransportdb.tbl_logs(LogID,UserID,TimeIn,TimeOut,Date) 
                        values('" & T_val + 1 & "', '" & LBL_IDNum.Text & "', '" & LBL_Time.Text & "','" & Time_Out & "','" & LBL_Date.Text & "')"

                    SqlCmd1.Connection = SqlCon1
                    SqlCmd1.CommandText = SqlQuery1
                    SqlCmd1.ExecuteNonQuery()
                    SqlCmd1.Parameters.Clear()

                End If
                'Convert.ToInt32(LBL_Count.Text)
                SqlCon.Close()
                SqlCon1.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "System Error")
                TXT_Pass.Text = ""
                LBL_Count.Text = ""
            Finally
                SqlCon.Dispose()
                SqlCon1.Dispose()
            End Try
            index = 1
        End While

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Width = Label5.Width + 50

        ProgressBar1.Increment(10)
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            MainFrame.Show()

            TXT_Pass.Text = ""
            TXT_User.Text = ""
            Label5.Width = 1
            LBL_IDNum.Text = ""
            LBL_Count.Text = ""

            ProgressBar1.Value = 0
            'SqlCon.Dispose()
            ' SqlCon1.Dispose()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LBL_Date.Text = Date.Now.ToString("MM/dd/yyyy")
        LBL_Time.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class