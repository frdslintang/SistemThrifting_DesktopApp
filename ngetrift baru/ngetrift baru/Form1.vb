Imports System.Data.Odbc
Public Class Form1
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
    Sub Terbuka()
        HalamanUtama.Button1.Enabled = True
        HalamanUtama.Button2.Enabled = True
        HalamanUtama.Button3.Enabled = True
        HalamanUtama.Button4.Enabled = True
        HalamanUtama.Button5.Enabled = True
        HalamanUtama.Button6.Enabled = True
    End Sub
    Sub SiapIsi()
        Username.Enabled = True
        Password.Enabled = True
    End Sub
    Sub KondisiAwal()
        Username.Text = ""
        Password.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.MediumSlateBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call SiapIsi()
    End Sub
    Private Sub Close_MouseClick(sender As Object, e As MouseEventArgs) Handles Close.MouseClick
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Username.Text = "" Or Password.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_admin where kodeadmin='" & Username.Text & "' and passwordadmin='" & Password.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                HalamanUtama.Show()
                Me.Hide()
                Call Terbuka()
                Transaksi.LBLAdmin.Text = HalamanUtama.Label5.Text
                HalamanUtama.Label5.Text = Rd!namaadmin
                HalamanUtama.Label6.Text = Rd!leveladmin
                HalamanUtama.Label13.Text = Rd!kodeadmin
                HalamanUtama.Label12.Text = Rd!passwordadmin
                If HalamanUtama.Label6.Text = "KASIR" Then
                    HalamanUtama.Button2.Enabled = False
                    HalamanUtama.Button3.Enabled = False
                    HalamanUtama.Button6.Enabled = False
                End If
            Else
                MsgBox("Username atau Password salah!")
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub cbshow_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        If showpassword.Checked = True Then
            Password.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True
        End If
    End Sub
End Class
