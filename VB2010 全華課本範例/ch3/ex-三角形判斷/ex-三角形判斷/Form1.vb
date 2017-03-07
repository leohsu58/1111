Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer = Val(TextBox1.Text)
        Dim b As Integer = Val(TextBox2.Text)
        Dim c As Integer = Val(TextBox3.Text)
        If (((a + b) > c) And ((b + c) > a) And ((a + c) > b)) Then
            TextBox4.Text = "可以構成三角形"
        Else
            TextBox4.Text = "無法構成三角形"
        End If
    End Sub
End Class
