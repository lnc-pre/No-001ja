Imports System.Text

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
        Dim rand As New Random()
        Dim result As New StringBuilder()

        For i As Integer = 1 To 20
            result.Append(chars(rand.Next(0, chars.Length)))
        Next

        Me.Text = "订单号:(未购买将取消)" + result.ToString()
    End Sub
End Class