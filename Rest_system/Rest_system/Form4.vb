Imports System.Text

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.Text = "Google登录(内嵌页)"
        Me.MaterialTextBox22.PasswordChar = "*"
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyzsssssssssszzzzzz"
        Dim rand As New Random()
        Dim result As New StringBuilder()

        For i As Integer = 1 To 27
            result.Append(chars(rand.Next(0, chars.Length)))
        Next

        Q1.Text = Q1.Text + result.ToString()
    End Sub



    Private ReadOnly bannedWords As String() = {"<", ">", "/", "body", "h1", "h2", "h3", "html"} '''自主添加违禁词(q1_a)

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click


        If ContainsBannedWords(MaterialTextBox21.Text) OrElse ContainsBannedWords(MaterialTextBox22.Text) Then
            MaterialTextBox21.Clear()
            MaterialTextBox22.Clear()


            MessageBox.Show("未知的文本(Code:0x345a)", "WARNING",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            MessageBox.Show("联网检查成功,正在检查账号可用性...", "System_SQL_Server",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ContainsBannedWords(text As String) As Boolean
        If String.IsNullOrEmpty(text) Then Return False

        For Each word In bannedWords
            If text.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0 Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
