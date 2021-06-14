Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class MoneyCashIn_Out

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

    Private Sub MoneyCashIn_Out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BTN_CashIn_Click(sender As Object, e As EventArgs) Handles BTN_CashIn.Click
        Dim ans As Integer
        If TXT_EnterAmount.Text = "" Then
            MsgBox("Please Enter amount before you cash in." & vbNewLine & "Thank you!!!", vbOKOnly + vbExclamation, "System Information")
        Else
            ans = MsgBox("Are you sure you want to Cash in?", vbYesNo + vbQuestion, "System Information")
            If ans = vbYes Then
                sqlQuery = "UPDATE etransportdb.tbl_passenger SET Cash ='" & LBL_NewBal.Text & "'  WHERE PassengerCardNum = '" & LBL_Num.Text & "' "
                RunSql(sqlQuery)
                MoneyTransaction.LBL_Read.Text = "0"
                TXT_EnterAmount.Text = ""
                MoneyTransaction.PassengerTable()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TXT_EnterAmount_TextChanged(sender As Object, e As EventArgs) Handles TXT_EnterAmount.TextChanged
        If MoneyTransaction.LBL_Identfier.Text = "passenger" Then
            If TXT_EnterAmount.Text <> "" Then
                LBL_NewBal.Text = Val(LBL_Balance.Text) + Val(TXT_EnterAmount.Text)
            Else
                LBL_NewBal.Text = ""
            End If
        ElseIf MoneyTransaction.LBL_Identfier.Text = "driver" Then
            If TXT_EnterAmount.Text <> "" Then
                LBL_NewBal.Text = Val(LBL_Balance.Text) - Val(TXT_EnterAmount.Text)
            Else
                LBL_NewBal.Text = ""
            End If
        End If

    End Sub

    Private Sub BTN_CashOut_Click(sender As Object, e As EventArgs) Handles BTN_CashOut.Click
        Dim ans As Integer
        If TXT_EnterAmount.Text = "" Then
            MsgBox("Please enter amount before you cash out." & vbNewLine & "Thank you!!!", vbOKOnly + vbExclamation, "System Information")
        Else
            ans = MsgBox("Are you sure you want to Cash Out?", vbYesNo + vbQuestion, "System Information")
            If ans = vbYes Then
                If Val(LBL_NewBal.Text) < 0 Then
                    MsgBox("You cannot cash out. Your balance is negative." & vbNewLine & "Thank you!!!", vbOKOnly + vbExclamation, "System Information")
                Else
                    sqlQuery = "UPDATE etransportdb.tbl_tricycle_driver SET Cash ='" & LBL_NewBal.Text & "'  WHERE TricycleNo = '" & LBL_Num.Text & "' "
                    RunSql(sqlQuery)
                    MoneyTransaction.LBL_Read.Text = "0"
                    TXT_EnterAmount.Text = ""
                    MoneyTransaction.DriverTable()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub MoneyCashIn_Out_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ans As String = MsgBox("You are about to exit. Your transaction will be cancelled." & vbNewLine & "Do you want to exit?", vbYesNo + vbQuestion, "System Information")
        If ans = vbYes Then
            LBL_Num.Text = "0"
            LBL_Name.Text = ""
            LBL_Balance.Text = ""
            ' MoneyTransaction.LBL_Read.Text = "0"
        Else
            e.Cancel = True
        End If

    End Sub

End Class