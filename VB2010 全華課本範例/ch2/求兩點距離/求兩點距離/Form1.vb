Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim distX As Single
        Dim distY As Single
        Dim dist As Single
        distX = Val(TextBox3.Text) - Val(TextBox1.Text)
        distY = Val(TextBox4.Text) - Val(TextBox2.Text)
        dist = (distX ^ 2 + distY ^ 2) ^ (1 / 2)
        TextBox5.Text = dist
    End Sub
End Class
