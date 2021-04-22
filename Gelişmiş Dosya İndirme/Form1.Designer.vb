<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.iptal = New System.Windows.Forms.Button()
        Me.durdur = New System.Windows.Forms.Button()
        Me.baslat = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'iptal
        '
        Me.iptal.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.iptal.Enabled = False
        Me.iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iptal.ForeColor = System.Drawing.Color.White
        Me.iptal.Location = New System.Drawing.Point(384, 175)
        Me.iptal.Name = "iptal"
        Me.iptal.Size = New System.Drawing.Size(124, 44)
        Me.iptal.TabIndex = 0
        Me.iptal.Text = "İptal Et"
        Me.iptal.UseVisualStyleBackColor = False
        '
        'durdur
        '
        Me.durdur.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.durdur.Enabled = False
        Me.durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.durdur.ForeColor = System.Drawing.Color.White
        Me.durdur.Location = New System.Drawing.Point(384, 125)
        Me.durdur.Name = "durdur"
        Me.durdur.Size = New System.Drawing.Size(124, 44)
        Me.durdur.TabIndex = 1
        Me.durdur.Text = "Durdur"
        Me.durdur.UseVisualStyleBackColor = False
        '
        'baslat
        '
        Me.baslat.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.baslat.ForeColor = System.Drawing.Color.White
        Me.baslat.Location = New System.Drawing.Point(384, 75)
        Me.baslat.Name = "baslat"
        Me.baslat.Size = New System.Drawing.Size(124, 44)
        Me.baslat.TabIndex = 2
        Me.baslat.Text = "Başlat"
        Me.baslat.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 196)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(366, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 118)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dosya Adı: Dosya Yok" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dosya Boyutu: 0 MB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kayıt Yeri: Kayıt Yeri Yok" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "İndirme Hız" & _
            "ı: 0 KB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hazır!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(496, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dosya Adresi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 39)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(488, 30)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "http://localhost/test.BNDL"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 226)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.baslat)
        Me.Controls.Add(Me.durdur)
        Me.Controls.Add(Me.iptal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gelişmiş Dosya İndirme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents iptal As System.Windows.Forms.Button
    Friend WithEvents durdur As System.Windows.Forms.Button
    Friend WithEvents baslat As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
