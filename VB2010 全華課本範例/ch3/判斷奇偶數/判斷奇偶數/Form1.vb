Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Val(TextBox1.Text) Mod 2 = 0) Then
            TextBox2.Text = TextBox1.Text & "為偶數"
        Else
            TextBox2.Text = TextBox1.Text & "為奇數"
        End If
    End Sub
End Class
