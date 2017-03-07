Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum As Integer
        Dim average As Single
        sum = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)
        average = sum / 3
        TextBox4.Text = sum
        TextBox5.Text = average
    End Sub
End Class
