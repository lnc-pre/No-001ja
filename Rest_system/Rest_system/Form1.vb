Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Text = "Tve_s 1.0.0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Task.Delay(10000)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz"
        Dim rand As New Random()
        Dim result As New StringBuilder()

        For i As Integer = 1 To 10
            result.Append(chars(rand.Next(0, chars.Length)))
        Next

        Me.Label3.Text = result.ToString()
        Label2.Text = "Test_1"
        Form3.Text = Form3.Text + "" + Me.Label3.Text
        Form3.Show()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Form4.Show()
    End Sub
End Class
