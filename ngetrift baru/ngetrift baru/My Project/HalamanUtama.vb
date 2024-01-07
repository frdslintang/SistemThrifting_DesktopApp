Public Class HalamanUtama
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        EditUser.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        EditUser.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.MediumSlateBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay
    End Sub

    Private Sub HalamanUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tanggal.Text = Today
    End Sub

    Private Sub HalamanUtama_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.CornflowerBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub
    Private Sub Close_MouseClick(sender As Object, e As MouseEventArgs) Handles Close.MouseClick
        End
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class