Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strName As String
        strName = InputBox("What's your name?", "請問姓名", "John", 50, 50)
        MsgBox("Hello," & strName)
    End Sub
End Class
