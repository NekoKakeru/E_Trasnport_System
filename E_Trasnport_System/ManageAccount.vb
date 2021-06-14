Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ManageAccount
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
            MsgBox("No Data Found. Please Registered a Passenger Profile." & vbNewLine & "Thank you!", vbOKOnly + vbInformation, "System Information")
            BTN_View.Enabled = False
        Else
            BTN_View.Enabled = True
        End If


        SqlCon.Close()
    End Sub

    Public Sub HideColumnP()
        DataGridView1.Columns(0).Visible = True
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
        DataGridView1.Columns(17).Visible = False
        DataGridView1.Columns(18).Visible = False

        DataGridView1.Columns(1).Width = 125
        DataGridView1.Columns(2).Width = 125
        DataGridView1.Columns(3).Width = 125
        DataGridView1.Columns(4).Width = 78
        DataGridView1.Columns(6).Width = 185
        DataGridView1.Columns(7).Width = 105
        DataGridView1.Columns(10).Width = 110
        DataGridView1.Columns(0).Width = 170
    End Sub

    Public Sub HideColumnD()
        DataGridView2.Columns(0).Visible = True
        DataGridView2.Columns(1).Visible = True
        DataGridView2.Columns(2).Visible = True
        DataGridView2.Columns(3).Visible = True
        DataGridView2.Columns(4).Visible = True
        DataGridView2.Columns(5).Visible = False
        DataGridView2.Columns(6).Visible = True
        DataGridView2.Columns(7).Visible = True
        DataGridView2.Columns(8).Visible = True
        DataGridView2.Columns(9).Visible = False
        DataGridView2.Columns(10).Visible = False
        DataGridView2.Columns(11).Visible = False
        DataGridView2.Columns(12).Visible = False
        DataGridView2.Columns(13).Visible = False

        DataGridView2.Columns(0).Width = 120
        DataGridView2.Columns(2).Width = 125
        DataGridView2.Columns(3).Width = 125
        DataGridView2.Columns(4).Width = 125
        DataGridView2.Columns(6).Width = 85
        DataGridView2.Columns(7).Width = 206
        DataGridView2.Columns(8).Width = 100
        DataGridView2.Columns(1).Width = 137

    End Sub
    Public Sub DriverTable()
        DataGridView2.DataSource = Nothing
        Connection()

        SqlCmd = SqlCon.CreateCommand()
        SqlCmd.CommandType = CommandType.Text
        SqlCmd.CommandText = " SELECT * FROM etransportdb.tbl_tricycle_driver"
        SqlCmd.ExecuteNonQuery()

        Dim sqlDT As New DataTable
        Dim DtA As New MySqlDataAdapter(SqlCmd)

        DtA.Fill(sqlDT)
        DataGridView2.DataSource = sqlDT
        HideColumnD()

        DataGridView2.DefaultCellStyle.Font = New Font("Palatino Linotype", 12)
        DataGridView2.ColumnHeadersDefaultCellStyle.Font = New Font("Palatino Linotype", 12, FontStyle.Bold)
        If (sqlDT.Rows.Count = 0) Then
            MsgBox("No Data Found. Please Registered a Driver Profile." & vbNewLine & "Thank you!", vbOKOnly + vbInformation, "System Information")
            BTN_View.Enabled = False
        Else
            BTN_View.Enabled = True
        End If

        SqlCon.Close()
    End Sub

    Private Sub ManageAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PassengerTable()
        LBL_Identfier.Text = "passenger"
        RB_Num.Checked = True

    End Sub

    Private Sub ManageAccount_Click(sender As Object, e As EventArgs) Handles Me.Click
        MainFrame.Hide_Panel()
    End Sub

    Private Sub BTN_Dri_Click(sender As Object, e As EventArgs) Handles BTN_Dri.Click
        DriverTable()
        DataGridView2.Visible = True
        DataGridView1.Visible = False
        BTN_Dri.BackColor = Color.FromArgb(39, 60, 117)
        BTN_Pas.BackColor = Color.FromArgb(72, 126, 176)
        LBL_Identfier.Text = "driver"
        LBL_Read.Text = "0"
    End Sub

    Private Sub BTN_Pas_Click(sender As Object, e As EventArgs) Handles BTN_Pas.Click
        PassengerTable()
        DataGridView1.Visible = True
        DataGridView2.Visible = False
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
                    DataGridView2.DataSource = sqlDT
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
                    DataGridView2.DataSource = sqlDT
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
                    DataGridView2.DataSource = sqlDT
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
                    PassengerView.LBL_PCN.Text = row.Cells(0).Value.ToString
                    PassengerView.LBL_PCN1.Text = row.Cells(0).Value.ToString
                    PassengerView.TXT_First.Text = row.Cells(1).Value.ToString
                    PassengerView.TXT_Middle.Text = row.Cells(2).Value.ToString
                    PassengerView.TXT_Last.Text = row.Cells(3).Value.ToString
                    PassengerView.CB_Gender.Text = row.Cells(4).Value.ToString
                    PassengerView.TXT_Age.Text = row.Cells(5).Value.ToString
                    PassengerView.TXT_ContactNo.Text = row.Cells(7).Value.ToString
                    PassengerView.TXT_Address.Text = row.Cells(6).Value.ToString
                    PassengerView.LBL_Birthdate.Text = row.Cells(8).Value.ToString
                    PassengerView.TXT_BirthPlace.Text = row.Cells(9).Value.ToString

                    If row.Cells(10).Value.ToString = "Student" Then
                        PassengerView.RB_Student.Checked = True
                    ElseIf row.Cells(10).Value.ToString = "PWD" Then
                        PassengerView.RB_PWD.Checked = True
                    ElseIf row.Cells(10).Value.ToString = "Senior Citizen" Then
                        PassengerView.RB_Senior.Checked = True
                    ElseIf row.Cells(10).Value.ToString = "Regular" Then
                        PassengerView.RB_Reg.Checked = True
                    End If

                    PassengerView.TXT_eFirst.Text = row.Cells(11).Value.ToString
                    PassengerView.TXT_eMiddle.Text = row.Cells(12).Value.ToString
                    PassengerView.TXT_eLast.Text = row.Cells(13).Value.ToString
                    PassengerView.TXT_eRelationship.Text = row.Cells(14).Value.ToString
                    PassengerView.TXT_eContactNo.Text = row.Cells(15).Value.ToString
                    PassengerView.TXT_eAddress.Text = row.Cells(16).Value.ToString

                    Dim img() As Byte
                    img = row.Cells(18).Value
                    Dim MS As New MemoryStream(img)
                    PassengerView.PictureBox1.Image = Image.FromStream(MS)


                    PassengerView.ShowDialog()
                    HideColumnP()
                ElseIf LBL_Identfier.Text = "driver" Then
                    Dim row As DataGridViewRow = DataGridView2.CurrentRow
                    DriverView.LBL_TN.Text = row.Cells(0).Value.ToString
                    DriverView.LBL_TN1.Text = row.Cells(0).Value.ToString
                    DriverView.TXT_PlateNo.Text = row.Cells(1).Value.ToString
                    DriverView.TXT_First.Text = row.Cells(2).Value.ToString
                    DriverView.TXT_Middle.Text = row.Cells(3).Value.ToString
                    DriverView.TXT_Last.Text = row.Cells(4).Value.ToString
                    DriverView.TXT_Age.Text = row.Cells(5).Value.ToString
                    DriverView.CB_Gender.Text = row.Cells(6).Value.ToString
                    DriverView.TXT_Address.Text = row.Cells(7).Value.ToString
                    DriverView.TXT_ContactNo.Text = row.Cells(8).Value.ToString
                    DriverView.LBL_Birthdate.Text = row.Cells(9).Value.ToString
                    DriverView.TXT_BirthPlace.Text = row.Cells(10).Value.ToString
                    DriverView.LBL_Route.Text = row.Cells(11).Value.ToString


                    Dim img() As Byte
                    img = row.Cells(13).Value
                    Dim MS As New MemoryStream(img)
                    DriverView.PictureBox1.Image = Image.FromStream(MS)

                    DriverView.ShowDialog()
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

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        LBL_Read.Text = "1"
    End Sub
End Class