Imports MySql.Data.MySqlClient

Public Class ChangePass
    Dim SqlCon As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim sqlQuery As String

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

            MsgBox("Password Change Successfully!!!", vbOKOnly + vbInformation, "System Information")

            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "System Error")
        Finally
            SqlCon.Dispose()
        End Try
    End Sub
    Private Sub BTNCreate_Click(sender As Object, e As EventArgs) Handles BTNCreate.Click
        If TXTPassword.Text = "" Or TXTConfirmPassword.Text = "" Then
            MsgBox("Please enter a password!!!", vbOKOnly + vbInformation, "System Information")
        Else
            If TXTPassword.Text <> TXTConfirmPassword.Text Or TXTConfirmPassword.Text = "" Then
                LBL_Comment1.Visible = True
            Else
                sqlQuery = "UPDATE etransportdb.tbl_admin SET Password ='" & TXTPassword.Text & "'  WHERE UserID = '" & UserProfile.LBL_IDNum.Text & "' "

                RunSql(sqlQuery)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TXTConfirmPassword.PasswordChar = ""
        Else
            TXTConfirmPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TXTPassword.PasswordChar = ""
        Else
            TXTPassword.PasswordChar = "*"
        End If
    End Sub
End Class