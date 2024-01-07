Imports System.Data.Odbc
Public Class EditMakanan
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
        kodeBarang.Text = ""
        namaBarang.Text = ""
        hargaJual.Text = ""
        stockBarang.Text = ""
        cariBarang.Text = ""
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
        Da = New OdbcDataAdapter("Select kodebarang, namabarang, hargajual, stok From tbl_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_barang")
        DataGridView1.DataSource = Ds.Tables("tbl_barang")
        DataGridView1.ReadOnly = True
    End Sub

    Sub SiapIsi()
        kodeBarang.Enabled = True
        namaBarang.Enabled = True
        hargaJual.Enabled = True
        stockBarang.Enabled = True
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
        (Me.ClientRectangle, Color.SpringGreen, Color.MediumSlateBlue, Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(i, Me.ClientRectangle)
    End Sub

    Private Sub EditMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tanggal.Text = Today
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""
        Call KondisiAwal()
    End Sub
    Private Sub EditMakanan_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
            Call Koneksi()
            cmd = New OdbcCommand("Select * from tbl_barang where kodebarang in(select max(kodebarang) from tbl_barang)", Conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                UrutanKode = "BRG" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
                UrutanKode = "BRG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            kodeBarang.Text = UrutanKode
            namaBarang.Focus()
        Else
            Call Koneksi()
            Dim SimpanData As String = "Insert into tbl_barang values ('" & kodeBarang.Text & "', '" & namaBarang.Text & "', '" & hargaJual.Text & "', '" & stockBarang.Text & "')"
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
            btnUbah.Text = "Simpan"
            ' lalu btnInput dan btnHapus tidak aktif dan btnTutup kita ubah menjadi tulisan "batal"
            btnInsert.Enabled = False
            btnDelete.Enabled = False
            Call SiapIsi()
        Else
            If kodeBarang.Text = "" Or namaBarang.Text = "" Or hargaJual.Text = "" Or stockBarang.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Call Koneksi()
                Da = New OdbcDataAdapter("update tbl_barang set namabarang='" & namaBarang.Text & "', hargajual='" & hargaJual.Text & "', stok='" & stockBarang.Text & "' where kodebarang='" & kodeBarang.Text & "'", Conn)
                Da.Fill(Ds, "tbl_barang")
                MsgBox("data berhasil diubah")
                Ds.Clear()
                Da = New OdbcDataAdapter("select kodebarang, namabarang, hargajual, stok from tbl_barang", Conn)
                Da.Fill(Ds, "tbl_barang")
                DataGridView1.DataSource = Ds.Tables("tbl_barang").DefaultView
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub kodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            cmd = New OdbcCommand("Select * from tbl_barang where kodebarang='" & kodeBarang.Text & "'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                namaBarang.Text = Rd.Item("namabarang")
                hargaJual.Text = Rd.Item("hargajual")
                stockBarang.Text = Rd.Item("stok")
            Else
                MsgBox("Kode Admin Tidak ada!")
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
            If kodeBarang.Text = "" Or namaBarang.Text = "" Or hargaJual.Text = "" Or stockBarang.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "Delete from tbl_barang where kodebarang = '" & kodeBarang.Text & "'"
                cmd = New OdbcCommand(HapusData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Data berhasil")
                Call KondisiAwal()
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
            kodeBarang.Enabled = False
            namaBarang.Enabled = False
            stockBarang.Enabled = False
            hargaJual.Enabled = False
        Else
            If cariBarang.Text = "" Then
                MsgBox("Pastikan field terisi!")
            Else
                Call KondisiAwal()
                Call SiapIsi()
            End If
        End If
    End Sub

    Private Sub cariPengguna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cariBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OdbcCommand("select * from tbl_barang where namabarang Like '%" & cariBarang.Text & "%'", Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_barang where namabarang Like '%" & cariBarang.Text & "%'", Conn)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Pembeli.Show()
        Me.Hide()
        Pembeli.STLabel2.Text = HalamanUtama.Label13.Text
        Pembeli.STLabel4.Text = HalamanUtama.Label5.Text
        Pembeli.STLabel6.Text = HalamanUtama.Label6.Text
    End Sub
    Private Sub Close_MouseClick(sender As Object, e As MouseEventArgs) Handles Close.MouseClick
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Call Terbuka()
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