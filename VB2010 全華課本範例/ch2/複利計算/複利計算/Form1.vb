Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim money As Integer
        Dim interest As Single
        money = Val(TextBox1.Text)
        interest = Val(TextBox2.Text)
        Debug.Print("一年過後本利和為" & money * (1 + interest / 100))
        Debug.Print("兩年過後本利和為" & money * (1 + interest / 100) ^ 2)
        Debug.Print("三年過後本利和為" & money * (1 + interest / 100) ^ 3)
    End Sub
End Class
