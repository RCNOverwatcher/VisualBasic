Public Class Form1
    Private Sub clearButton_Click() Handles ClearButton.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub backgroundButton_Click() Handles BackgroundButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub closeButton_Click() Handles CloseButton.Click
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged() Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub

    Private Sub PictureButton_Click(sender As Object, e As EventArgs) Handles PictureButton.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            PictureBox1.Load(OpenFileDialog1.FileName)

        End If
    End Sub
End Class
