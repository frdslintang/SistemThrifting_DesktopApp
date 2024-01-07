<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.showpassword = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Close)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 73)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(459, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sistem Informasi Thrifting"
        '
        'Close
        '
        Me.Close.BackColor = System.Drawing.Color.Transparent
        Me.Close.BackgroundImage = Global.ngetrift_baru.My.Resources.Resources.remove
        Me.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Close.Location = New System.Drawing.Point(838, 11)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(48, 44)
        Me.Close.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close.png")
        Me.ImageList1.Images.SetKeyName(1, "cross.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-menu-rounded-30.png")
        Me.ImageList1.Images.SetKeyName(3, "Login-icon.png")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.showpassword)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.btncancel)
        Me.Panel4.Controls.Add(Me.btnLogin)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Password)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Username)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(-1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(357, 590)
        Me.Panel4.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label7.Location = New System.Drawing.Point(57, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 28)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Username"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.DarkCyan
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.ImageIndex = 3
        Me.btncancel.Location = New System.Drawing.Point(185, 480)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(154, 47)
        Me.btncancel.TabIndex = 13
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.ImageIndex = 3
        Me.btnLogin.Location = New System.Drawing.Point(25, 480)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(154, 47)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label8.Location = New System.Drawing.Point(57, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 28)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Futura Md BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label9.Location = New System.Drawing.Point(58, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(251, 32)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Penjualan barang second branded" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(61, 408)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(228, 22)
        Me.Password.TabIndex = 11
        Me.Password.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Old English Text MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label10.Location = New System.Drawing.Point(49, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(270, 71)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Welcome!"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(61, 348)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(228, 22)
        Me.Username.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.ngetrift_baru.My.Resources.Resources.LOGO_THRIFT
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(13, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 206)
        Me.Panel2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 49)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "COMANDAN.CO"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.ngetrift_baru.My.Resources.Resources.istockphoto_881096270_612x6122
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(240, -13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(843, 691)
        Me.Panel3.TabIndex = 2
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.Font = New System.Drawing.Font("Adobe Gothic Std B", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.showpassword.ForeColor = System.Drawing.Color.DarkCyan
        Me.showpassword.Location = New System.Drawing.Point(61, 439)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(130, 22)
        Me.showpassword.TabIndex = 34
        Me.showpassword.Text = "Show Password"
        Me.showpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showpassword.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(904, 589)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Close As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents showpassword As CheckBox
End Class
