Imports System.Data.Odbc
Public Class HalamanUtama
    Public Conn As New OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=db_thrifting;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub kondisiawal()
        Form1.Username.Text = ""
        Form1.Password.Text = ""
    End Sub
    Sub Terbuka()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button6.Enabled = True
        Button5.Enabled = True

    End Sub
    Sub Terkunci()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
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
        Call Terbuka()
    End Sub

    Private Sub HalamanUtama_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.CornflowerBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub
    Private Sub Close_MouseClick(sender As Object, e As MouseEventArgs) Handles Close.MouseClick
        End
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Pembeli.Show()
        Me.Hide()
        Pembeli.STLabel2.Text = Label13.Text
        Pembeli.STLabel4.Text = Label5.Text
        Pembeli.STLabel6.Text = Label6.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditMakanan.Show()
        Me.Hide()
        EditMakanan.STLabel2.Text = Label13.Text
        EditMakanan.STLabel4.Text = Label5.Text
        EditMakanan.STLabel6.Text = Label6.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EditUser.Show()
        Me.Hide()
        EditUser.STLabel2.Text = Label13.Text
        EditUser.STLabel4.Text = Label5.Text
        EditUser.STLabel6.Text = Label6.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Call Terbuka()
        Me.Hide()
        Call kondisiawal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_MouseClick(sender As Object, e As MouseEventArgs) Handles Label11.MouseClick
        GantiPassword.Show()
    End Sub
End Class