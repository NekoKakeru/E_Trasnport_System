Imports System.ComponentModel
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class CameraFrame

    Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
    Dim Camera As VideoCaptureDevice
    Dim BMP As Bitmap
    Private Sub CameraFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cameras.ControlBox = False
        cameras.Text = "Open Camera System"
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = cameras.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            Camera.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Captured(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub BTN_GCN_Click(sender As Object, e As EventArgs) Handles BTN_GCN.Click
        LBL_PIC.Text = "1"
        PictureBox2.Image = PictureBox1.Image
        'Camera.Stop()
    End Sub

    Private Sub CameraFrame_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Me.Dispose()
        Camera.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As String = MsgBox("Are sure you want to save the picture?", vbYesNo + vbQuestion, "System Information")
        If LBL_PIC.Text = "0" Then
            MsgBox("Please taka a picture first.", vbOKOnly + vbExclamation, "System Information")
        Else

            If LBL_Identfier.Text = "PAS" Then

                If ans = vbYes Then
                    PassengerRegistration.PictureBox1.Image = PictureBox2.Image
                    LBL_PIC.Text = "0"
                    PassengerRegistration.LBL_PIC.Text = "1"
                    Camera.Stop()
                    cameras.Dispose()
                    Me.Dispose()
                End If

            ElseIf LBL_Identfier.Text = "DRI" Then

                If ans = vbYes Then
                    DriverRegistration.PictureBox1.Image = PictureBox2.Image
                    LBL_PIC.Text = "0"
                    DriverRegistration.LBL_PIC.Text = "1"
                    Camera.Stop()
                    cameras.Dispose()
                    Me.Dispose()
                End If

            ElseIf LBL_Identfier.Text = "EDIT_PAS" Then

                If ans = vbYes Then
                    PassengerView.PictureBox1.Image = PictureBox2.Image
                    LBL_PIC.Text = "0"
                    PassengerView.LBL_PIC.Text = "1"
                    Camera.Stop()
                    cameras.Dispose()
                    Me.Dispose()
                End If

            ElseIf LBL_Identfier.Text = "EDIT_DRI" Then

                If ans = vbYes Then
                    DriverView.PictureBox1.Image = PictureBox2.Image
                    LBL_PIC.Text = "0"
                    DriverView.LBL_PIC.Text = "1"
                    Camera.Stop()
                    cameras.Dispose()
                    Me.Dispose()
                End If

            ElseIf LBL_Identfier.Text = "USER" Then

                If ans = vbYes Then
                    CreateUserAccount.PictureBox1.Image = PictureBox2.Image
                    LBL_PIC.Text = "0"
                    CreateUserAccount.LBL_PIC.Text = "1"
                    Camera.Stop()
                    cameras.Dispose()
                    Me.Dispose()
                End If

            End If
        End If


    End Sub
End Class