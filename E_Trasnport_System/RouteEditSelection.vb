Imports MySql.Data.MySqlClient
Public Class RouteEditSelection
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

    Private Sub RouteEditSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListTable()
    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
        Try
            If LBL_RT.Text <> "0" Then
                LBL_RT.Text += LB_Route.GetItemText(LB_Route.SelectedItem) & "-"
            Else
                LBL_RT.Text = LB_Route.GetItemText(LB_Route.SelectedItem) & "-"
            End If

            LB_Selected.Items.Add(LB_Route.GetItemText(LB_Route.SelectedItem))

        Catch ex As Exception
            MsgBox("No item to be selected!!!", vbOKOnly + vbCritical, "System Critical")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LBL_RT.Text = LBL_RT.Text.Remove(LBL_RT.Text.Length - 1)
        DriverView.LBL_Route.Text = LBL_RT.Text
        Me.Close()
        LBL_RT.Text = ""
        LB_Selected.Items.Clear()
    End Sub
End Class