Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = (Val(TextBox1.Text) * 12 + Val(TextBox2.Text)) * 2.54
    End Sub
End Class
