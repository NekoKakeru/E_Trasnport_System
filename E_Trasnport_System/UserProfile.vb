Imports MySql.Data.MySqlClient
Public Class UserProfile

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
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLogs()
        'BTN_ChangePass.Enabled = False
    End Sub


    Public Sub UserLogs()
        DataGridView1.DataSource = Nothing
        Connection()

        SqlCmd = SqlCon.CreateCommand()
        SqlCmd.CommandType = CommandType.Text
        SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_logs where UserID ='" & LBL_IDNum.Text & "'"
        SqlCmd.ExecuteNonQuery()

        Dim sqlDT As New DataTable
        Dim DtA As New MySqlDataAdapter(SqlCmd)

        DtA.Fill(sqlDT)
        DataGridView1.DataSource = sqlDT

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False

        DataGridView1.Columns(2).Width = 210
        DataGridView1.Columns(3).Width = 210
        DataGridView1.Columns(4).Width = 201

        DataGridView1.DefaultCellStyle.Font = New Font("Palatino Linotype", 12)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Palatino Linotype", 12, FontStyle.Bold)

        SqlCon.Close()
    End Sub

    Private Sub BTN_ChangePass_Click(sender As Object, e As EventArgs) Handles BTN_ChangePass.Click
        ChangePass.ShowDialog()

    End Sub

    Private Sub LBL_IDNum_Click(sender As Object, e As EventArgs) Handles LBL_IDNum.Click

    End Sub

    Private Sub LBL_IDNum_TextChanged(sender As Object, e As EventArgs) Handles LBL_IDNum.TextChanged

    End Sub
End Class