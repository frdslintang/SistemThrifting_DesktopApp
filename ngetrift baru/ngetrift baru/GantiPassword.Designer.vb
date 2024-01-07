<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GantiPassword
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
        Me.buatpassword = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buatpassword
        '
        Me.buatpassword.BackColor = System.Drawing.Color.Transparent
        Me.buatpassword.Font = New System.Drawing.Font("Montserrat ExtraBold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buatpassword.ForeColor = System.Drawing.Color.White
        Me.buatpassword.Location = New System.Drawing.Point(159, 46)
        Me.buatpassword.Name = "buatpassword"
        Me.buatpassword.Size = New System.Drawing.Size(307, 40)
        Me.buatpassword.TabIndex = 16
        Me.buatpassword.Text = "Buat Password Baru"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(135, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(331, 71)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Password baru kamu harus berbeda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dari sebelumnya" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 40)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Password Lama"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(288, 175)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 22)
        Me.TextBox1.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(288, 217)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(232, 22)
        Me.TextBox2.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(68, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 40)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Password Baru"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(288, 263)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(232, 22)
        Me.TextBox3.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 40)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Konfirmasi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 47)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(371, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 47)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 433)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.buatpassword)
        Me.Name = "GantiPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GantiPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buatpassword As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
