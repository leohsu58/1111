Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = Val(TextBox1.Text) * 250 + Val(TextBox2.Text) * 300 + Val(TextBox3.Text) * 200
    End Sub
End Class
