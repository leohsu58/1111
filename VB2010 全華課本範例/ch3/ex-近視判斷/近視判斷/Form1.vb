Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Val(TextBox1.Text) < 0.8) Then
            TextBox2.Text = "近視"
        Else
            TextBox2.Text = "視力正常"
        End If
    End Sub
End Class
