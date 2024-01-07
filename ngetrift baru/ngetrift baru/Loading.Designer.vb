<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLReportProgress = New System.Windows.Forms.Label()
        Me.LBLStatustext = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBLoading = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 75)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Develope and Design By : Kelompok 3"
        '
        'LBLReportProgress
        '
        Me.LBLReportProgress.Location = New System.Drawing.Point(534, 215)
        Me.LBLReportProgress.Name = "LBLReportProgress"
        Me.LBLReportProgress.Size = New System.Drawing.Size(101, 17)
        Me.LBLReportProgress.TabIndex = 9
        Me.LBLReportProgress.Text = "000%"
        Me.LBLReportProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLStatustext
        '
        Me.LBLStatustext.AutoSize = True
        Me.LBLStatustext.Location = New System.Drawing.Point(174, 215)
        Me.LBLStatustext.Name = "LBLStatustext"
        Me.LBLStatustext.Size = New System.Drawing.Size(182, 17)
        Me.LBLStatustext.TabIndex = 8
        Me.LBLStatustext.Text = "Launching the application..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 49)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Thrifting Management"
        '
        'PBLoading
        '
        Me.PBLoading.Location = New System.Drawing.Point(177, 174)
        Me.PBLoading.Name = "PBLoading"
        Me.PBLoading.Size = New System.Drawing.Size(458, 32)
        Me.PBLoading.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 80
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 277)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LBLReportProgress)
        Me.Controls.Add(Me.PBLoading)
        Me.Controls.Add(Me.LBLStatustext)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLReportProgress As Label
    Friend WithEvents LBLStatustext As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PBLoading As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
