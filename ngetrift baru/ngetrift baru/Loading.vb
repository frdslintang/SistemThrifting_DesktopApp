Public Class Loading
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.MediumSlateBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LBLReportProgress.Text = PBLoading.Value & "%"

        PBLoading.Value += 1

        If PBLoading.Value > 10 Then
            LBLStatustext.Text = "Loading... Please wait"
        End If

        If PBLoading.Value > 25 Then
            LBLStatustext.Text = "Hai! we're from Kelompok 3"
        End If

        If PBLoading.Value > 45 Then
            LBLStatustext.Text = "And this is our project!"
        End If

        If PBLoading.Value > 65 Then
            LBLStatustext.Text = "Are you ready guys?"
        End If

        If PBLoading.Value > 95 Then
            LBLStatustext.Text = "Nice! Let's go"
        End If

        If PBLoading.Value = 100 Then
            LBLStatustext.Text = "Launching Application."
            Form1.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub

    Private Sub Loadingscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class