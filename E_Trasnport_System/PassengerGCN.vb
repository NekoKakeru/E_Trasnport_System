Public Class PassengerGCN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        If TXT_GCN.Text = Nothing Then
            MsgBox("Please tap the card first.", vbOKOnly + vbExclamation, "System Information")
        Else
            If LBL_Identfier.Text = "Save_Pas" Then
                PassengerRegistration.LBL_PCN.Text = TXT_GCN.Text
                TXT_GCN.Text = ""
                PassengerRegistration.BTN_GCN.Enabled = False
                Me.Dispose()
            ElseIf LBL_Identfier.Text = "Edit_Pas" Then
                Dim row As DataGridViewRow = ManageAccount.DataGridView1.CurrentRow
                If row.Cells(0).Value = TXT_GCN.Text Then
                    MsgBox("Can't Save. Hava a same Card Number. Please pick other number.", vbOKOnly + vbExclamation, "System Error")
                Else
                    PassengerView.LBL_PCN1.Text = TXT_GCN.Text
                    TXT_GCN.Text = ""
                    PassengerView.BTN_GCN.Enabled = False
                    Me.Dispose()
                End If
            ElseIf LBL_Identfier.Text = "USER" Then
                CreateUserAccount.LBL_IDNum.Text = TXT_GCN.Text
                TXT_GCN.Text = ""
                CreateUserAccount.BTN_GIDNum.Enabled = False
                Me.Dispose()
            End If
        End If

    End Sub

    Private Sub PassengerGCN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PassengerGCN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub PassengerGCN_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TXT_GCN.Text = ""
        PassengerView.LBL_PCN1.Visible = False
        PassengerView.LBL_PCN.Visible = True
        Me.Close()
    End Sub
End Class