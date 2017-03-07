Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) >= 2000 Then
            TextBox2.Text = Val(TextBox1.Text) * 0.9
        Else
            TextBox2.Text = Val(TextBox1.Text)
        End If
    End Sub
End Class
