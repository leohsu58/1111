Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Const PI As Double = 3.1415926
        TextBox2.Text = 2 * Val(TextBox1.Text) * PI
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox1.Text) * PI
    End Sub
End Class
