Imports System.Data.Odbc
Public Class Pembeli
    Dim Conn As New OdbcConnection
    Dim Da As OdbcDataAdapter
    Dim Ds As DataSet
    Dim Rd As OdbcDataReader
    Dim cmd As OdbcCommand
    Dim MyDB As String
    Dim baca As OdbcDataReader
    Public Sub Koneksi()
        Conn.Close()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=db_thrifting;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        Conn.Open()
    End Sub
    Sub Terbuka()
        HalamanUtama.Button1.Enabled = True
        HalamanUtama.Button2.Enabled = True
        HalamanUtama.Button3.Enabled = True
        HalamanUtama.Button4.Enabled = True
        HalamanUtama.Button5.Enabled = True
        HalamanUtama.Button6.Enabled = True
    End Sub
    Sub KondisiAwal()
        ' Textbox1, textbox2, textbox3, dan textbox4 kita kosongkan pertama kali
        kodePelanggan.Text = ""
        Namapelanggan.Text = ""
        alamatPelanggan.Text = ""
        teleponPelanggan.Text = ""
        cariPelanggan.Text = ""
        Form1.Username.Text = ""
        Form1.Password.Text = ""
        ' btnInput, btnUbah, btnHapus, btnTutup kita aktifkan dengan menggunakan perintah true
        btnInsert.Enabled = True
        btnUbah.Enabled = True
        btnDelete.Enabled = True

        ' btnInput, btnUbah, btnHapus, btnTutup kita tambahkan text masing - masing yaitu input, ubah, hapus, tutup
        btnInsert.Text = "Insert"
        btnUbah.Text = "Edit"
        btnDelete.Text = "Hapus"

        ' Panggil koneksi yang sudah kita buat sub Koneksi()
        Call Koneksi()
        ' Memanggil table yang sudah kita buat 
        Da = New OdbcDataAdapter("Select kodepelanggan, namapelanggan, alamatPelanggan, telpPelanggan From tbl_pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pelanggan")
        DataGridView1.DataSource = Ds.Tables("tbl_pelanggan")
        DataGridView1.ReadOnly = True
    End Sub
    Sub Terkunci()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""
    End Sub
    Sub SiapIsi()
        kodePelanggan.Enabled = True
        Namapelanggan.Enabled = True
        alamatPelanggan.Enabled = True
        teleponPelanggan.Enabled = True
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.MediumSlateBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub Pembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tanggal.Text = Today
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""
        Call KondisiAwal()
    End Sub

    Private Sub Pembeli_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.CornflowerBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Jam.Text = TimeOfDay
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If btnInsert.Text = "Insert" Then
            btnInsert.Text = "Simpan"
            Call SiapIsi()
            Call Koneksi()
            cmd = New OdbcCommand("Select * from tbl_pelanggan where kodepelanggan in(select max(kodepelanggan) from tbl_pelanggan)", Conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                UrutanKode = "PLG" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
                UrutanKode = "PLG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            kodePelanggan.Text = UrutanKode
            Namapelanggan.Focus()
        Else
            Call Koneksi()
            Dim SimpanData As String = "Insert into tbl_pelanggan values ('" & kodePelanggan.Text & "', '" & Namapelanggan.Text & "', '" & alamatPelanggan.Text & "', '" & teleponPelanggan.Text & "')"
            cmd = New OdbcCommand(SimpanData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diinput!")
            Call KondisiAwal()
            btnInsert.Text = "Insert"
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ' if btnUbah.text yang textnya "UBAH" maka akan berubah menjadi button "UPDATE"
        If btnUbah.Text = "Edit" Then
            btnUbah.Text = "Update"
            ' lalu btnInput dan btnHapus tidak aktif dan btnTutup kita ubah menjadi tulisan "batal"
            btnInsert.Enabled = False
            btnDelete.Enabled = False
            Call SiapIsi()
        Else
            If Namapelanggan.Text = "" Or alamatPelanggan.Text = "" Or teleponPelanggan.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Call Koneksi()
                Da = New OdbcDataAdapter("update tbl_pelanggan set namapelanggan='" & Namapelanggan.Text & "', alamatpelanggan='" & alamatPelanggan.Text & "', telppelanggan='" & teleponPelanggan.Text & "' where kodepelanggan='" & kodePelanggan.Text & "'", Conn)
                Da.Fill(Ds, "tbl_pelanggan")
                MsgBox("data berhasil diubah")
                Ds.Clear()
                Da = New OdbcDataAdapter("select kodepelanggan, namapelanggan, alamatpelanggan, telppelanggan from tbl_pelanggan", Conn)
                Da.Fill(Ds, "tbl_pelanggan")
                DataGridView1.DataSource = Ds.Tables("tbl_pelanggan").DefaultView
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' if btnUbah.text yang textnya "UBAH" maka akan berubah menjadi button "UPDATE"
        If btnDelete.Text = "Hapus" Then
            btnDelete.Text = "Delete"
            ' lalu btnInput dan btnHapus tidak aktif dan btnTutup kita ubah menjadi tulisan "batal"
            btnInsert.Enabled = False
            btnUbah.Enabled = False
            Call SiapIsi()
        Else
            If kodePelanggan.Text = "" Or Namapelanggan.Text = "" Or alamatPelanggan.Text = "" Or teleponPelanggan.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tbl_pelanggan where kodepelanggan = '" & kodePelanggan.Text & "'"
                cmd = New OdbcCommand(HapusData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub kodePelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodePelanggan.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            cmd = New OdbcCommand("Select * from tbl_pelanggan where kodepelanggan='" & kodePelanggan.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Namapelanggan.Text = Rd.Item("namapelanggan")
                alamatPelanggan.Text = Rd.Item("alamatpelanggan")
                teleponPelanggan.Text = Rd.Item("telppelanggan")
            Else
                MsgBox("Kode Admin Tidak ada!")
            End If
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ' if btnUbah.text yang textnya "UBAH" maka akan berubah menjadi button "UPDATE"
        If btnCari.Text = "Cari" Then
            btnCari.Text = "Selesai"
            ' lalu btnInput dan btnHapus tidak aktif dan btnTutup kita ubah menjadi tulisan "batal"
            btnInsert.Enabled = False
            btnUbah.Enabled = False
            btnDelete.Enabled = False
            kodePelanggan.Enabled = False
            Namapelanggan.Enabled = False
            alamatPelanggan.Enabled = False
            teleponPelanggan.Enabled = False
        Else
            If cariPelanggan.Text = "" Then
                MsgBox("Pastikan field terisi!")
            Else
                Call KondisiAwal()
                Call SiapIsi()
            End If
        End If
    End Sub
    Private Sub cariPelanggan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cariPelanggan.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OdbcCommand("select * from tbl_pelanggan where namapelanggan Like '%" & cariPelanggan.Text & "%'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_pelanggan where namapelanggan Like '%" & cariPelanggan.Text & "%'", Conn)
                Ds = New DataSet
                Da.Fill(Ds, "KetemuData")
                DataGridView1.DataSource = Ds.Tables("KetemuData")
                DataGridView1.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EditUser.Show()
        Me.Hide()
        EditUser.STLabel2.Text = HalamanUtama.Label13.Text
        EditUser.STLabel4.Text = HalamanUtama.Label5.Text
        EditUser.STLabel6.Text = HalamanUtama.Label6.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditMakanan.Show()
        Me.Hide()
        EditMakanan.STLabel2.Text = HalamanUtama.Label13.Text
        EditMakanan.STLabel4.Text = HalamanUtama.Label5.Text
        EditMakanan.STLabel6.Text = HalamanUtama.Label6.Text
    End Sub
    Private Sub Close_MouseClick(sender As Object, e As MouseEventArgs) Handles Close.MouseClick
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call Terbuka()
        Form1.Show()
        Me.Hide()
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call KondisiAwal()
    End Sub
End Class