Public Class Form1
    Dim intModule As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intLocal As Integer = 0
        intLocal = intLocal + 1
        intModule = intModule + 10
        TextBox1.Text = intLocal
        TextBox2.Text = intModule
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim intLocal As Integer = 0
        intLocal = intLocal + 2
        intModule = intModule + 20
        TextBox1.Text = intLocal
        TextBox2.Text = intModule
    End Sub
End Class
