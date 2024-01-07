<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLNamaPlg = New System.Windows.Forms.Label()
        Me.LBLNoJual = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.label90 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Dibayar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Diskon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBLJam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LBLAdmin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LBLTanggal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keterangan"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJam.Location = New System.Drawing.Point(119, 76)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(123, 27)
        Me.LBLJam.TabIndex = 17
        Me.LBLJam.Text = "LBLJam"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 27)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Kasir"
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAdmin.Location = New System.Drawing.Point(119, 21)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(123, 27)
        Me.LBLAdmin.TabIndex = 16
        Me.LBLAdmin.Text = "LBLAdmin"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tanggal"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggal.Location = New System.Drawing.Point(119, 49)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(123, 27)
        Me.LBLTanggal.TabIndex = 15
        Me.LBLTanggal.Text = "LBLTanggal"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 27)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Jam"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBLTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 110)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grand Total"
        '
        'LBLTotal
        '
        Me.LBLTotal.BackColor = System.Drawing.Color.Black
        Me.LBLTotal.Font = New System.Drawing.Font("DS-Digital", 55.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.ForeColor = System.Drawing.Color.OliveDrab
        Me.LBLTotal.Location = New System.Drawing.Point(0, 17)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(603, 93)
        Me.LBLTotal.TabIndex = 13
        Me.LBLTotal.Text = "0"
        Me.LBLTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.LBLTelepon)
        Me.GroupBox3.Controls.Add(Me.LBLAlamat)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.LBLNamaPlg)
        Me.GroupBox3.Controls.Add(Me.LBLNoJual)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(473, 180)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(191, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 33)
        Me.ComboBox1.TabIndex = 16
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelepon.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTelepon.Location = New System.Drawing.Point(191, 144)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(150, 27)
        Me.LBLTelepon.TabIndex = 15
        Me.LBLTelepon.Text = "LBLTelepon"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAlamat.Location = New System.Drawing.Point(191, 117)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(276, 27)
        Me.LBLAlamat.TabIndex = 14
        Me.LBLAlamat.Text = "LBLAlamat"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 27)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Telepon"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 27)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Alamat"
        '
        'LBLNamaPlg
        '
        Me.LBLNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaPlg.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaPlg.Location = New System.Drawing.Point(191, 90)
        Me.LBLNamaPlg.Name = "LBLNamaPlg"
        Me.LBLNamaPlg.Size = New System.Drawing.Size(276, 27)
        Me.LBLNamaPlg.TabIndex = 11
        Me.LBLNamaPlg.Text = "LBLNamaPlg"
        '
        'LBLNoJual
        '
        Me.LBLNoJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoJual.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNoJual.Location = New System.Drawing.Point(191, 27)
        Me.LBLNoJual.Name = "LBLNoJual"
        Me.LBLNoJual.Size = New System.Drawing.Size(150, 27)
        Me.LBLNoJual.TabIndex = 10
        Me.LBLNoJual.Text = "LBLNoJual"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 27)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nomor Jual"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 27)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nama"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 32)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Kode Pelanggan"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Apps-Lock-Ok-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "arrow-refresh-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "Box-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "cancel-icon.png")
        Me.ImageList1.Images.SetKeyName(4, "edit-icon.png")
        Me.ImageList1.Images.SetKeyName(5, "Folder-Settings-Tools-icon.png")
        Me.ImageList1.Images.SetKeyName(6, "Login-icon.png")
        Me.ImageList1.Images.SetKeyName(7, "Log-Out-icon.png")
        Me.ImageList1.Images.SetKeyName(8, "Manager-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "Person-Male-Dark-icon.png")
        Me.ImageList1.Images.SetKeyName(10, "Refresh-icon.png")
        Me.ImageList1.Images.SetKeyName(11, "Reports-icon.png")
        Me.ImageList1.Images.SetKeyName(12, "Save-icon.png")
        Me.ImageList1.Images.SetKeyName(13, "shop-cart-icon.png")
        Me.ImageList1.Images.SetKeyName(14, "Trash-Delete-icon.png")
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(573, 335)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(60, 27)
        Me.TextBox2.TabIndex = 43
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLHargaBarang.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHargaBarang.Location = New System.Drawing.Point(406, 336)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(97, 27)
        Me.LBLHargaBarang.TabIndex = 42
        Me.LBLHargaBarang.Text = "Harga"
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLNamaBarang.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaBarang.Location = New System.Drawing.Point(209, 336)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(129, 27)
        Me.LBLNamaBarang.TabIndex = 41
        Me.LBLNamaBarang.Text = "Nama"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(58, 335)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 27)
        Me.TextBox1.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(509, 335)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 27)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Jumlah"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(347, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 27)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Harga"
        '
        'label90
        '
        Me.label90.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label90.Location = New System.Drawing.Point(148, 336)
        Me.label90.Name = "label90"
        Me.label90.Size = New System.Drawing.Size(75, 27)
        Me.label90.TabIndex = 37
        Me.label90.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 27)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Kode"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 374)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(865, 183)
        Me.DataGridView1.TabIndex = 45
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCetak)
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 563)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(869, 117)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pembayaran"
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(771, 74)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(96, 46)
        Me.btnCetak.TabIndex = 20
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(669, 74)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 46)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(771, 27)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 46)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(669, 27)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 46)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LBLKembali)
        Me.GroupBox6.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.GroupBox6.Location = New System.Drawing.Point(336, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(327, 84)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Kembali"
        '
        'LBLKembali
        '
        Me.LBLKembali.BackColor = System.Drawing.Color.Black
        Me.LBLKembali.Font = New System.Drawing.Font("DS-Digital", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKembali.ForeColor = System.Drawing.Color.Yellow
        Me.LBLKembali.Location = New System.Drawing.Point(-6, 22)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(327, 61)
        Me.LBLKembali.TabIndex = 13
        Me.LBLKembali.Text = "0"
        Me.LBLKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Dibayar)
        Me.GroupBox5.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(324, 84)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Dibayar"
        '
        'Dibayar
        '
        Me.Dibayar.BackColor = System.Drawing.Color.Black
        Me.Dibayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dibayar.Font = New System.Drawing.Font("DS-Digital", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dibayar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Dibayar.Location = New System.Drawing.Point(6, 22)
        Me.Dibayar.Name = "Dibayar"
        Me.Dibayar.Size = New System.Drawing.Size(318, 60)
        Me.Dibayar.TabIndex = 0
        Me.Dibayar.Text = "0"
        Me.Dibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.ngetrift_baru.My.Resources.Resources.logo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(15, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 180)
        Me.Panel1.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.ImageKey = "Save-icon.png"
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(776, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 37)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = " Insert"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Diskon
        '
        Me.Diskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Diskon.Location = New System.Drawing.Point(701, 335)
        Me.Diskon.Name = "Diskon"
        Me.Diskon.Size = New System.Drawing.Size(60, 27)
        Me.Diskon.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(641, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 27)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Diskon"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 683)
        Me.Controls.Add(Me.Diskon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.label90)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBLJam As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLAdmin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBLTotal As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LBLTelepon As Label
    Friend WithEvents LBLAlamat As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLNamaPlg As Label
    Friend WithEvents LBLNoJual As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LBLHargaBarang As Label
    Friend WithEvents LBLNamaBarang As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents label90 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LBLKembali As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Dibayar As TextBox
    Friend WithEvents Diskon As TextBox
    Friend WithEvents Label4 As Label
End Class
