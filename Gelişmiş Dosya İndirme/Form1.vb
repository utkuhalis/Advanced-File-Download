Imports System.Net
Public Class Form1
    Dim kayıtyeri As String

    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)

    Public Sub DownloadComplete(ByVal cancelled As Boolean)
        TextBox1.Enabled = True
        baslat.Enabled = True
        iptal.Enabled = False
        durdur.Enabled = False

        If cancelled Then
            MsgBox("İndirme İşlemi İptal Edildi.", MsgBoxStyle.Information)
        Else
            MsgBox("İndirme Tamamlandı.", MessageBoxIcon.Information, "Tamamlandı %100")
        End If

        ProgressBar1.Value = 0
        Label1.Text = "Dosya Adı: Dosya Yok" & vbNewLine & "Dosya Boyutu: 0 MB" & vbNewLine & "Kayıt Yeri: Kayıt Yeri Yok" & vbNewLine & "İndirme Hızı: 0 KB" & vbNewLine & "Hazır!"
    End Sub


    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
        Dim x As New Label
        Label1.Text = "Dosya Adı:" & TextBox1.Text.Split("/"c)(TextBox1.Text.Split("/"c).Length - 1) & vbNewLine & "Dosya Boyutu:" & Math.Round((length / 1024), 2) & " KB" & vbNewLine & "Kayıt Yeri:" & kayıtyeri & vbNewLine & "İndirme Hızı:" & Math.Round((speed / 1024), 2) & " KB/s" & vbNewLine & Math.Round((position / 1024), 2) & " KB/" & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBar1.Value & "%)"
        ProgressBar1.Maximum = Math.Round((length / 1024), 2)
        ProgressBar1.Minimum = 0
        x.Text = Math.Round((position / 1024), 2)
        ProgressBar1.Value = x.Text
        Me.Text = TextBox1.Text.Split("/"c)(TextBox1.Text.Split("/"c).Length - 1) & " - " & ProgressBar1.Value & "%"
    End Sub

    Private Sub baslat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baslat.Click
        If TextBox1.Text <> "" AndAlso TextBox1.Text.StartsWith("http://") Then


            Me.SaveFileDialog1.FileName = TextBox1.Text.Split("/"c)(TextBox1.Text.Split("/"c).Length - 1)

            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                kayıtyeri = Me.SaveFileDialog1.FileName

                Me.SaveFileDialog1.FileName = ""

                TextBox1.Enabled = False
                baslat.Enabled = False
                durdur.Enabled = True
                iptal.Enabled = True

                Me.BackgroundWorker1.RunWorkerAsync() 'İndirme Başlıyor

            End If

        Else
            'Bir Sorun Varsa Uyarıyor.
            MsgBox("Bir hata ile karşılaşıldı ve indirme iptal edildi.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try

            theRequest = WebRequest.Create(TextBox1.Text)
            theResponse = theRequest.GetResponse
        Catch ex As Exception

            MsgBox(ex.ToString) 'Sorun varsa Söylüyor

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0)

        Dim writeStream As New IO.FileStream(kayıtyeri, IO.FileMode.Create)

        Dim nRead As Integer

        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0

        Do

            If BackgroundWorker1.CancellationPending Then 'If user abort download
                Exit Do
            End If

            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = theResponse.GetResponseStream.Read(readBytes, 0, 4096)

            nRead += bytesread
            Dim percent As Short = (nRead * 0) / length

            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 5 Then
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If Me.BackgroundWorker1.CancellationPending Then

            IO.File.Delete(kayıtyeri)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub

        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

        Me.Invoke(completeDelegate, False)

    End Sub

    Private Sub durdur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles durdur.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub iptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iptal.Click
        End
    End Sub
End Class
