Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ((TextBox1.Text = "john") And (TextBox2.Text = "123")) Then
            MsgBox("登入成功")
        Else
            MsgBox("登入失敗")
        End If
    End Sub
End Class
