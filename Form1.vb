Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String

        Dim BirthYear As Integer
        YourMessage = "Happy bday! How old are you now"

        MsgBox(YourMessage)
        BirthYear = Val(InputBox("Enter Year Of Birth"))
        MsgBox("you are now " & 2024 - BirthYear & " years old")
    End Sub
End Class
