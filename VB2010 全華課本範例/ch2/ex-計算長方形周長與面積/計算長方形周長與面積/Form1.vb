Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = (Val(TextBox1.Text) + Val(TextBox2.Text)) * 2
        TextBox4.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub
End Class
