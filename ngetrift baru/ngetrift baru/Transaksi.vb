Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class Transaksi
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Public Conn As New OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Dim t_qty As Long
    Dim t_harga As Long
    Public Sub Koneksi()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=db_thrifting;server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Dim TglMySQL As String
    Sub KondisiAwal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = ""
        LBLAdmin.Text = HalamanUtama.Label5.Text
        LBLKembali.Text = ""
        TextBox1.Text = ""
        LBLNamaBarang.Text = ""
        LBLHargaBarang.Text = ""
        TextBox2.Text = ""
        TextBox2.Enabled = False
        LBLTotal.Text = 0
        LBLKembali.Text = ""
        LBLKembali.Text = 0
        Dibayar.Text = ""
        Form1.Username.Text = ""
        Form1.Password.Text = ""
        ComboBox1.Text = ""
        Diskon.Enabled = True
    End Sub
    Sub Terbuka()
        HalamanUtama.Button1.Enabled = True
        HalamanUtama.Button2.Enabled = True
        HalamanUtama.Button3.Enabled = True
        HalamanUtama.Button4.Enabled = True
        HalamanUtama.Button5.Enabled = True
        HalamanUtama.Button6.Enabled = True
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call MunculKodePelanggan()
        Call NomorOtomatis()
        Call BuatKolom()
    End Sub
    Sub MunculKodePelanggan()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan where kodepelanggan = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaPlg.Text = Rd!namapelanggan
            LBLAlamat.Text = Rd!alamatpelanggan
            LBLTelepon.Text = Rd!telppelanggan
        End If
    End Sub
    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("select * from tbl_jual where nojual in(select max(nojual) from tbl_jual) order by nojual DESC", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            LBLNoJual.Text = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(Rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                LBLNoJual.Text = Format(Now, "yyMMdd") + "0001"
            Else
                LBLNoJual.Text = Rd.Item("nojual") + 1
            End If
        End If
    End Sub
    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox1.Text = Rd.Item("kodebarang")
                LBLNamaBarang.Text = Rd.Item("namabarang")
                LBLHargaBarang.Text = Rd.Item("hargajual")
                TextBox2.Enabled = True
            Else
                MsgBox("Kode Barang Tidak ada!")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LBLNamaBarang.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan masukkan kode barang dan tekan ENTER!")
        Else
            Call BuatKolom()
            Dim hargasementara As Integer
            Dim hargadiskon As Integer
            Dim biayaakhir As Integer
            hargasementara = Val(LBLHargaBarang.Text) * Val(TextBox2.Text)
            hargadiskon = Val(hargasementara) * Val(Diskon.Text)
            biayaakhir = Val(hargasementara) - Val(hargadiskon)
            DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLNamaBarang.Text, LBLHargaBarang.Text, TextBox2.Text, biayaakhir})
            Call grand_total()
            TextBox1.Text = ""
            LBLNamaBarang.Text = ""
            LBLHargaBarang.Text = ""
            TextBox2.Text = ""
            Diskon.Text = ""
            Diskon.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub
    Sub grand_total()
        Dim hitung As Integer
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
        Next
        LBLTotal.Text = Format(hitung)
    End Sub

    Private Sub Dibayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(Dibayar.Text) < Val(LBLTotal.Text) Then
                MsgBox("Pembayaranmu Kurang!")
            ElseIf Val(Dibayar.Text) = Val(LBLTotal.Text) Then
                LBLKembali.Text = 0
            ElseIf Val(Dibayar.Text) > Val(LBLTotal.Text) Then
                LBLKembali.Text = Val(Dibayar.Text) - Val(LBLTotal.Text)
                btnSave.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Call KondisiAwal()
        Call NomorOtomatis()
        DataGridView1.Columns.Clear()
        Call Terbuka()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Dibayar.Text = "" Or LBLKembali.Text = "" Or LBLTotal.Text = "" Then
            MsgBox("Transaksi tidak ada, silahkan melakukan transaksi dulu!")
        Else
            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanJual As String = "Insert into tbl_jual values ('" & LBLNoJual.Text & "', '" & TglMySQL & "', '" & LBLJam.Text & "', '" & LBLTotal.Text & "', '" & Dibayar.Text & "', '" & LBLKembali.Text & "', '" & ComboBox1.Text & "', '" & HalamanUtama.Label13.Text & "')"
            Cmd = New OdbcCommand(SimpanJual, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLNoJual.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang  = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Dim KurangStock As String = "Update tbl_barang set stok = '" & Rd.Item("stok") - DataGridView1.Rows(Baris).Cells(3).Value & "' where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OdbcCommand(KurangStock, Conn)
                Cmd.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Berhasi!")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Dibayar.Text = "" Or LBLKembali.Text = "" Or LBLTotal.Text = "" Then
            MsgBox("Transaksi tidak ada, silahkan melakukan transaksi dulu!")
        Else
            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLNoJual.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang  = '" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Dim KurangStock As String = "Update tbl_barang set stok = '" & Rd.Item("stok") - DataGridView1.Rows(Baris).Cells(3).Value & "' where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OdbcCommand(KurangStock, Conn)
            Next
            Cmd.ExecuteNonQuery()
            PPD.Document = PD
            PPD.ShowDialog()
        End If
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 8, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 8, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        'kiri tidak dibuat karena defaultnya sudah kiri
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        Dim garis2 As String
        garis2 = "-----------------------"

        'membuat isinya

        e.Graphics.DrawString("COMANDAN.CO", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Rungkut Madya N0.2AC ", f10, Brushes.Black, centermargin, 26, tengah)
        e.Graphics.DrawString("Hp : 0821-3982-0980", f10, Brushes.Black, centermargin, 38, tengah)

        e.Graphics.DrawString("No Jual", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString(LBLNoJual.Text, f10, Brushes.Black, 75, 60)

        e.Graphics.DrawString("Kasir", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString(HalamanUtama.Label5.Text, f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString(LBLTanggal.Text, f10, Brushes.Black, 0, 90)
        e.Graphics.DrawString(LBLJam.Text, f10, Brushes.Black, rightmargin, 90, kanan) '120 ini marginnya

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        DataGridView1.AllowUserToAddRows = False

        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 25, 100 + tinggi)

            i = DataGridView1.Rows(baris).Cells(4).Value
            DataGridView1.Rows(baris).Cells(4).Value = Format(i)
            e.Graphics.DrawString(DataGridView1.Rows(baris).Cells(4).Value.ToString, f10, Brushes.Black, rightmargin, 100 + tinggi, kanan)

        Next
        tinggi = 100 + tinggi
        grand_total2()
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 10 + tinggi)
        e.Graphics.DrawString("Total  : " & Format(t_harga), f10b, Brushes.Black, rightmargin, 20 + tinggi, kanan)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 20 + tinggi)

        e.Graphics.DrawString(garis2, f10, Brushes.Black, 155, 30 + tinggi)

        If Val(Dibayar.Text) > Val(LBLTotal.Text) Then
            LBLKembali.Text = Val(Dibayar.Text) - Val(LBLTotal.Text)
            e.Graphics.DrawString("Kembalian : " & Format(LBLKembali.Text), f10b, Brushes.Black, rightmargin, 60 + tinggi, kanan)
        ElseIf Val(Dibayar.Text) = Val(LBLTotal.Text) Then
            LBLKembali.Text = 0
            e.Graphics.DrawString("Kembalian : " & Format(LBLKembali.Text), f10b, Brushes.Black, rightmargin, 60 + tinggi, kanan)
        End If

        e.Graphics.DrawString("Tunai : " & Format(Dibayar.Text), f10b, Brushes.Black, rightmargin, 40 + tinggi, kanan)
        e.Graphics.DrawString(garis2, f10, Brushes.Black, 155, 50 + tinggi)


        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString("Barang TIDAK DAPAT ditukar/dikembalikan", f10, Brushes.Black, centermargin, 260 + tinggi, tengah)
        e.Graphics.DrawString("dengan ALASAN APAPUN. Sebelum dibayar", f10, Brushes.Black, centermargin, 275 + tinggi, tengah)
        e.Graphics.DrawString("akan dicoba, kerusakan barang bukan", f10, Brushes.Black, centermargin, 290 + tinggi, tengah)
        e.Graphics.DrawString("tanggung jawab kami.", f10, Brushes.Black, centermargin, 305 + tinggi, tengah)

        'e.Graphics.DrawString("~ Terimakasih telah belanja ~", f10, Brushes.Black, centermargin, 200 + tinggi, tengah)
        'e.Graphics.DrawString("~ Di toko kami ~", f10, Brushes.Black, centermargin, 215 + tinggi, tengah)
    End Sub
    Sub grand_total2()
        Dim hitung As Long = 0
        For i As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
        Next
        t_harga = hitung

        Dim hitung2 As Long = 0
        For i As Long = 0 To DataGridView1.RowCount - 1
            hitung2 = hitung2 + DataGridView1.Rows(i).Cells(3).Value
        Next
        t_qty = hitung2
    End Sub
End Class