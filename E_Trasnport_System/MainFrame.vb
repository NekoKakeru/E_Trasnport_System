Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class MainFrame
    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlQuery As String
    Dim Con As String = "server=localhost;userid=root;password=nekokakeru;database=etransportdb"

    Public Sub Connection()
        SqlCon.ConnectionString = Con
        If SqlCon.State = ConnectionState.Open Then
            SqlCon.Close()
        End If
        SqlCon.Open()
    End Sub

    Public Sub RunSql(ByRef sql As String)
        Dim cmd As New MySqlCommand
        Connection()
        Try
            cmd.Connection = SqlCon
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Error")
        End Try
    End Sub


    Public Sub Hide_Panel()
        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
    End Sub

    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dashboard.TopLevel = False
        Dashboard.TopMost = True
        Dashboard.Location = New Point(0, 0)
        Me.Panel3.Controls.Add(Dashboard)
        Dashboard.Show()
        PassengerRegistration.Hide()
        DriverRegistration.Hide()
        MoneyTransaction.Hide()
        ManageAccount.Hide()

        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        Panel4.Visible = False
        Panel5.Visible = False
        lblSet.Text = "show"
        lblSet1.Text = "show"
        lblSet.Visible = False
        lblSet1.Visible = False
    End Sub

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.TopLevel = False
        Dashboard.TopMost = True
        Dashboard.Location = New Point(0, 0)
        Me.Panel3.Controls.Add(Dashboard)
        Dashboard.Show()
        PassengerRegistration.Hide()
        DriverRegistration.Hide()
        MoneyTransaction.Close()
        ManageAccount.Close()

        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False

        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"

        Passengerbtn.Enabled = True
        Driverbtn.Enabled = True

        lblHeader.Text = "Dashboard"
    End Sub

    Private Sub Money_Click(sender As Object, e As EventArgs) Handles btnMoneyTransaction.Click
        MoneyTransaction.TopLevel = False
        MoneyTransaction.TopMost = True
        MoneyTransaction.Location = New Point(0, 0)
        Me.Panel3.Controls.Add(MoneyTransaction)
        Dashboard.Hide()
        PassengerRegistration.Hide()
        DriverRegistration.Hide()
        MoneyTransaction.Show()
        ManageAccount.Close()

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True
        Label4.Visible = False

        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"

        Passengerbtn.Enabled = True
        Driverbtn.Enabled = True

        lblHeader.Text = "Money Transaction"
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False
        Label4.Visible = False

        Panel5.Visible = False
        lblSet1.Text = "show"

        If lblSet1.Text = "show" Then
            Panel5.Visible = True
            lblSet1.Text = "hide"
        ElseIf lblSet1.Text = "hide" Then
            Panel5.Visible = False
            lblSet1.Text = "show"
        End If
    End Sub

    Private Sub Manage_Click(sender As Object, e As EventArgs) Handles btnManageAccount.Click

        ManageAccount.TopLevel = False
        ManageAccount.TopMost = True
        ManageAccount.Location = New Point(0, 0)
        Me.Panel3.Controls.Add(ManageAccount)
        Dashboard.Hide()
        PassengerRegistration.Hide()
        DriverRegistration.Hide()
        MoneyTransaction.Close()
        ManageAccount.Show()

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True

        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"

        Passengerbtn.Enabled = True
        Driverbtn.Enabled = True

        lblHeader.Text = "Manage Account"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Panel5.Visible = False
        lblSet1.Text = "show"

        If lblSet1.Text = "show" Then
            Panel4.Visible = True
            lblSet.Text = "hide"
        ElseIf lblSet1.Text = "hide" Then
            Panel4.Visible = False
            lblSet.Text = "show"
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
    End Sub

    Private Sub MainFrame_Click(sender As Object, e As EventArgs) Handles Me.Click
        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
    End Sub

    Private Sub Driverbtn_Click(sender As Object, e As EventArgs) Handles Passengerbtn.Click
        lblHeader.Text = "Passenger Registration"

        PassengerRegistration.TopLevel = False
        PassengerRegistration.TopMost = True
        PassengerRegistration.Location = New Point(0, 0)
        Me.Panel3.Controls.Add(PassengerRegistration)
        Dashboard.Hide()
        PassengerRegistration.Show()
        DriverRegistration.Hide()
        MoneyTransaction.Close()
        ManageAccount.Close()

        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
        Passengerbtn.Enabled = False
        Driverbtn.Enabled = True
        'Passengerbtn.BackColor = Color.FromArgb(127, 143, 166)
        ' If lblHeader.Text = "Passenger Registration" Then
        ' MsgBox("You are already in Passenger Resgisttation Form.", vbOKOnly + vbInformation, "System Message")
        ' Else
        ' End If
    End Sub

    Private Sub Driverbtn_Click_1(sender As Object, e As EventArgs) Handles Driverbtn.Click
        lblHeader.Text = "Driver Registration"

        DriverRegistration.TopLevel = False
        DriverRegistration.TopMost = True
        DriverRegistration.Location = New Point(0, 0)
        Me.Panel3.Controls.Add(DriverRegistration)
        Dashboard.Hide()
        PassengerRegistration.Hide()
        DriverRegistration.Show()
        MoneyTransaction.Close()
        ManageAccount.Close()

        Panel4.Visible = False
        Panel5.Visible = False
        lblSet1.Text = "show"
        lblSet.Text = "show"
        Passengerbtn.Enabled = True
        Driverbtn.Enabled = False
    End Sub

    Private Sub Createbtn_Click(sender As Object, e As EventArgs) Handles Createbtn.Click
        Panel4.Visible = False
        CreateUserAccount.ShowDialog()
    End Sub

    Private Sub Profilebtn_Click(sender As Object, e As EventArgs) Handles Profilebtn.Click
        If UserProfile.LBL_IDNum.Text = "" Then
            UserProfile.BTN_ChangePass.Enabled = False
        Else
            UserProfile.BTN_ChangePass.Enabled = True
        End If
        Panel4.Visible = False
        UserProfile.ShowDialog()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click


        SqlQuery = "UPDATE etransportdb.tbl_logs SET TimeOut ='" & Dashboard.LBL_Time.Text & "' WHERE LogID = '" & Dashboard.LBL_LogID.Text & "' "

        RunSql(SqlQuery)
        Me.Dispose()
        LoginFrame.Count_Logs()
        LoginFrame.Show()


    End Sub

    Private Sub MainFrame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SqlQuery = "UPDATE etransportdb.tbl_logs SET TimeOut ='" & Dashboard.LBL_Time.Text & "' WHERE LogID = '" & Dashboard.LBL_LogID.Text & "' "
        RunSql(SqlQuery)
        LoginFrame.Dispose()
    End Sub

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles Aboutbtn.Click
        About.ShowDialog()
    End Sub
End Class
