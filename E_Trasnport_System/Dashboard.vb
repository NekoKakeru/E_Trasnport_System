Imports MySql.Data.MySqlClient

Public Class Dashboard
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

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Me.Click
        MainFrame.Hide_Panel()
    End Sub

    Public Sub Total_Driver()
        Connection()
        Try
            SqlQuery = "Select count(*) from etransportdb.tbl_tricycle_driver"
            SqlCmd = New MySqlCommand(SqlQuery, SqlCon)
            Dim count1 = Convert.ToString(SqlCmd.ExecuteScalar)

            LBL_TotalDriver.Text = count1
            SqlCon.Close()
        Catch ex As Exception
            MsgBox("An error occured while registering the profile!", vbOKOnly + vbCritical, "System Error")
        Finally
            SqlCon.Dispose()
        End Try
    End Sub

    Public Sub OffLine_Trycicle()
        Try
            LBL_OffTrip.Text = LBL_TotalDriver.Text

        Catch ex As Exception
            MsgBox("An error occured while registering the profile!", vbOKOnly + vbCritical, "System Error")
        End Try
    End Sub

    Public Sub Total_Passenger()
        Connection()
        Try
            SqlQuery = "Select count(*) from etransportdb.tbl_passenger"
            SqlCmd = New MySqlCommand(SqlQuery, SqlCon)
            Dim count1 = Convert.ToString(SqlCmd.ExecuteScalar)

            LBL_TotalPassenger.Text = count1
            SqlCon.Close()
        Catch ex As Exception
            MsgBox("An error occured while registering the profile!", vbOKOnly + vbCritical, "System Error")
        Finally
            SqlCon.Dispose()
        End Try
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_LogID.Text = Val(LoginFrame.LBL_Count.Text) + 1

        Timer1.Enabled = True
        Timer1.Interval = 10

        Total_Driver()
        Total_Passenger()
        OffLine_Trycicle()

    End Sub

    Private Sub LBL_TotalDriver_TextChanged(sender As Object, e As EventArgs) Handles LBL_TotalDriver.TextChanged
        OffLine_Trycicle()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBL_Date.Text = Date.Now.ToString("MM/dd/yyyy")
        LBL_Time.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class