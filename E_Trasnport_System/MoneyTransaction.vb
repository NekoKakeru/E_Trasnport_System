Imports MySql.Data.MySqlClient
Public Class MoneyTransaction
    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand

    Dim Con As String = "server=localhost;userid=root;password=nekokakeru;database=etransportdb"

    Public Sub Connection()
        SqlCon.ConnectionString = Con
        If SqlCon.State = ConnectionState.Open Then
            SqlCon.Close()
        End If
        SqlCon.Open()
    End Sub

    Public Sub PassengerTable()
        DataGridView1.DataSource = Nothing
        Connection()

        SqlCmd = SqlCon.CreateCommand()
        SqlCmd.CommandType = CommandType.Text
        SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_passenger"
        SqlCmd.ExecuteNonQuery()

        Dim sqlDT As New DataTable
        Dim DtA As New MySqlDataAdapter(SqlCmd)

        DtA.Fill(sqlDT)
        DataGridView1.DataSource = sqlDT
        HideColumnP()

        DataGridView1.DefaultCellStyle.Font = New Font("Palatino Linotype", 12)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Palatino Linotype", 12, FontStyle.Bold)
        If (sqlDT.Rows.Count = 0) Then
            MsgBox("No Data Found. Please Registered a Passenger Profile" & vbNewLine & "Thank you!", vbOKOnly + vbInformation, "System Information")
            BTN_View.Enabled = False
        Else
            BTN_View.Enabled = True
        End If

        SqlCon.Close()
    End Sub

    Public Sub HideColumnP()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = True
        DataGridView1.Columns(7).Visible = True
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = True
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
        DataGridView1.Columns(15).Visible = False
        DataGridView1.Columns(16).Visible = False
        DataGridView1.Columns(17).Visible = True
        DataGridView1.Columns(18).Visible = False

        DataGridView1.Columns(1).Width = 130
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 130
        DataGridView1.Columns(4).Width = 90
        DataGridView1.Columns(6).Width = 220
        DataGridView1.Columns(7).Width = 113
        DataGridView1.Columns(10).Width = 130
        DataGridView1.Columns(17).Width = 80
    End Sub

    Public Sub HideColumnD()
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = True
        DataGridView1.Columns(3).Visible = True
        DataGridView1.Columns(4).Visible = True
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = True
        DataGridView1.Columns(7).Visible = True
        DataGridView1.Columns(8).Visible = True
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = True
        DataGridView1.Columns(13).Visible = False

        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 130
        DataGridView1.Columns(4).Width = 130
        DataGridView1.Columns(6).Width = 90
        DataGridView1.Columns(7).Width = 230
        DataGridView1.Columns(8).Width = 113
        DataGridView1.Columns(12).Width = 80

    End Sub
    Public Sub DriverTable()
        DataGridView1.DataSource = Nothing
        Connection()

        SqlCmd = SqlCon.CreateCommand()
        SqlCmd.CommandType = CommandType.Text
        SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_tricycle_driver"
        SqlCmd.ExecuteNonQuery()

        Dim sqlDT As New DataTable
        Dim DtA As New MySqlDataAdapter(SqlCmd)

        DtA.Fill(sqlDT)
        DataGridView1.DataSource = sqlDT
        HideColumnD()

        DataGridView1.DefaultCellStyle.Font = New Font("Palatino Linotype", 12)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Palatino Linotype", 12, FontStyle.Bold)
        If (sqlDT.Rows.Count = 0) Then
            MsgBox("No Data Found. Please Registered a Driver Profile." & vbNewLine & "Thank you!", vbOKOnly + vbInformation, "System Information")
            BTN_View.Enabled = False
        Else
            BTN_View.Enabled = True
        End If

        SqlCon.Close()
    End Sub

    Private Sub MoneyTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PassengerTable()
        LBL_Identfier.Text = "passenger"
        RB_Num.Checked = True
    End Sub

    Private Sub MoneyTransaction_Click(sender As Object, e As EventArgs) Handles Me.Click
        MainFrame.Hide_Panel()
    End Sub

    Private Sub BTN_Dri_Click(sender As Object, e As EventArgs) Handles BTN_Dri.Click
        DriverTable()
        BTN_Dri.BackColor = Color.FromArgb(39, 60, 117)
        BTN_Pas.BackColor = Color.FromArgb(72, 126, 176)
        LBL_Identfier.Text = "driver"
        LBL_Read.Text = "0"
    End Sub

    Private Sub BTN_Pas_Click(sender As Object, e As EventArgs) Handles BTN_Pas.Click
        PassengerTable()
        BTN_Pas.BackColor = Color.FromArgb(39, 60, 117)
        BTN_Dri.BackColor = Color.FromArgb(72, 126, 176)
        LBL_Identfier.Text = "passenger"
        LBL_Read.Text = "0"
    End Sub

    Private Sub TXT_Search_TextChanged(sender As Object, e As EventArgs) Handles TXT_Search.TextChanged
        Connection()
        Try
            If LBL_Identfier.Text = "passenger" Then
                If RB_Num.Checked = True Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_passenger where PassengerCardNum  like '%" & TXT_Search.Text & "%' "
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    DataGridView1.DataSource = sqlDT
                    SqlCon.Close()
                    HideColumnP()
                ElseIf RB_First.Checked = True Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_passenger where Firstname  like '%" & TXT_Search.Text & "%' "
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    DataGridView1.DataSource = sqlDT
                    SqlCon.Close()
                    HideColumnP()
                ElseIf RB_Last.Checked = True Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_passenger where Lastname  like '%" & TXT_Search.Text & "%' "
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    DataGridView1.DataSource = sqlDT
                    SqlCon.Close()
                    HideColumnP()
                End If
            ElseIf LBL_Identfier.Text = "driver" Then
                If RB_Num.Checked = True Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_tricycle_driver where TricycleNo  like '%" & TXT_Search.Text & "%' "
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    DataGridView1.DataSource = sqlDT
                    SqlCon.Close()
                    HideColumnD()
                ElseIf RB_First.Checked = True Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_tricycle_driver where Firstname  like '%" & TXT_Search.Text & "%' "
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    DataGridView1.DataSource = sqlDT
                    SqlCon.Close()
                    HideColumnD()
                ElseIf RB_Last.Checked = True Then
                    SqlCmd = SqlCon.CreateCommand()
                    SqlCmd.CommandType = CommandType.Text
                    SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_tricycle_driver where Lastname  like '%" & TXT_Search.Text & "%' "
                    SqlCmd.ExecuteNonQuery()
                    Dim sqlDT As New DataTable
                    Dim DtA As New MySqlDataAdapter(SqlCmd)
                    DtA.Fill(sqlDT)
                    DataGridView1.DataSource = sqlDT
                    SqlCon.Close()
                    HideColumnD()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occured while searching!", vbOKOnly + vbCritical, "System Error")
            HideColumnP()
        Finally
            SqlCon.Dispose()
        End Try

    End Sub


    Private Sub BTN_View_Click(sender As Object, e As EventArgs) Handles BTN_View.Click
        Try
            If LBL_Read.Text = "0" Then
                MsgBox("Please select data first. Thank you!", vbOKOnly + vbExclamation, "System Information")
            Else
                If LBL_Identfier.Text = "passenger" Then
                    Dim row As DataGridViewRow = DataGridView1.CurrentRow
                    MoneyCashIn_Out.LBL_Name.Text = row.Cells(1).Value.ToString() & " " & row.Cells(2).Value.ToString() & " " & row.Cells(3).Value.ToString()
                    MoneyCashIn_Out.LBL_Balance.Text = row.Cells(17).Value
                    MoneyCashIn_Out.LBL_Num.Text = row.Cells(0).Value.ToString()
                    MoneyCashIn_Out.BTN_CashIn.Visible = True
                    MoneyCashIn_Out.TXT_EnterAmount.Text = ""
                    MoneyCashIn_Out.ShowDialog()
                    HideColumnP()
                ElseIf LBL_Identfier.Text = "driver" Then
                    Dim row As DataGridViewRow = DataGridView1.CurrentRow
                    MoneyCashIn_Out.LBL_Name.Text = row.Cells(2).Value.ToString() & " " & row.Cells(3).Value.ToString() & " " & row.Cells(4).Value.ToString()
                    MoneyCashIn_Out.LBL_Balance.Text = row.Cells(12).Value
                    MoneyCashIn_Out.LBL_Num.Text = row.Cells(0).Value.ToString()
                    MoneyCashIn_Out.BTN_CashOut.Visible = True
                    MoneyCashIn_Out.TXT_EnterAmount.Text = ""
                    MoneyCashIn_Out.ShowDialog()
                    HideColumnD()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Critical")
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        LBL_Read.Text = "1"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub
End Class