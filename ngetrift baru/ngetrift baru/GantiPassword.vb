Imports System.Data.Odbc
Public Class GantiPassword
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
    Private Sub GantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
    End Sub
    Sub kondisiawal()
        Form1.Username.Text = ""
        Form1.Password.Text = ""
    End Sub

    Private Sub GantiPassword_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.MediumSlateBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("select * from tbl_admin where kodeadmin = '" & HalamanUtama.Label13.Text & "' and passwordadmin= '" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox1.Enabled = False
            Else
                MsgBox("Password lama salah!")
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or TextBox3.Text = " " Then
            MsgBox("Password baru harus diisi!")
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password baru dan konfirmasi harus sama!")
            Else
                Call Koneksi()
                Dim Editdata As String = "Update tbl_admin Set passwordadmin='" & TextBox3.Text & "' where kodeadmin='" & HalamanUtama.Label13.Text & "'"
                Cmd = New OdbcCommand(Editdata, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Update Password!")
                Form1.Show()
                HalamanUtama.Hide()
                Me.Close()
                kondisiawal()
            End If
        End If
    End Sub
End Class