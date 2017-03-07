Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) >= 60 Then MsgBox("很好，請繼續保持下去")
    End Sub
End Class
