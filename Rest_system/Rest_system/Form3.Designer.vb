<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Image3d1 = New AntdUI.Image3D()
        Label1 = New Label()
        Button1 = New AntdUI.Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Image3d1
        ' 
        Image3d1.Image = My.Resources.Resources.屏幕截图_2025_10_04_192720
        Image3d1.Location = New Point(237, 12)
        Image3d1.Name = "Image3d1"
        Image3d1.Size = New Size(123, 103)
        Image3d1.TabIndex = 0
        Image3d1.Text = "Image3d1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(190, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 60)
        Label1.TabIndex = 1
        Label1.Text = "购买成功!"
        ' 
        ' Button1
        ' 
        Button1.ColorScheme = AntdUI.TAMode.Dark
        Button1.Location = New Point(190, 296)
        Button1.Name = "Button1"
        Button1.Radius = 2
        Button1.Size = New Size(228, 48)
        Button1.TabIndex = 2
        Button1.Text = "好的"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(118, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 39)
        Label2.TabIndex = 3
        Label2.Text = "您购买了:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label3.Location = New Point(328, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 39)
        Label3.TabIndex = 4
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(635, 356)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Image3d1)
        Name = "Form3"
        Text = "Sure! 您已购买成功,您的订单号:"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Image3d1 As AntdUI.Image3D
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As AntdUI.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
