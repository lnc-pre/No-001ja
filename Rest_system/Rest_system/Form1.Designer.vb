<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New AntdUI.Button()
        LabelTime1 = New AntdUI.LabelTime()
        Tag1 = New AntdUI.Tag()
        Label1 = New AntdUI.Label()
        Dropdown1 = New AntdUI.Dropdown()
        Button2 = New AntdUI.Button()
        Label2 = New Label()
        Label3 = New Label()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.ColorScheme = AntdUI.TAMode.Dark
        Button1.Location = New Point(17, 16)
        Button1.Name = "Button1"
        Button1.Radius = 2
        Button1.Size = New Size(162, 52)
        Button1.TabIndex = 0
        Button1.Text = "查看本设备"
        Button1.Type = AntdUI.TTypeMini.Info
        ' 
        ' LabelTime1
        ' 
        LabelTime1.Location = New Point(561, 388)
        LabelTime1.Name = "LabelTime1"
        LabelTime1.Size = New Size(227, 50)
        LabelTime1.TabIndex = 1
        LabelTime1.Text = "N1"
        ' 
        ' Tag1
        ' 
        Tag1.Location = New Point(12, 122)
        Tag1.Name = "Tag1"
        Tag1.Size = New Size(188, 187)
        Tag1.TabIndex = 2
        Tag1.Text = "SVIP 现价:3.99$" & vbCrLf & "SVIP可用于:" & vbCrLf & "1.点" & vbCrLf & "2.点" & vbCrLf & "3.点" & vbCrLf & "4.点" & vbCrLf & "5.点"
        Tag1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 34)
        Label1.TabIndex = 3
        Label1.Text = "特别优惠: -70%"
        ' 
        ' Dropdown1
        ' 
        Dropdown1.Location = New Point(657, 306)
        Dropdown1.Name = "Dropdown1"
        Dropdown1.Size = New Size(151, 65)
        Dropdown1.TabIndex = 5
        Dropdown1.Text = "Textbox1"
        Dropdown1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 306)
        Button2.Name = "Button2"
        Button2.Radius = 2
        Button2.Size = New Size(188, 55)
        Button2.TabIndex = 6
        Button2.Text = "立即购买(Free)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(731, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(731, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 8
        Label3.Text = "Label3"
        Label3.Visible = False
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(13, 402)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(110, 36)
        MaterialButton1.TabIndex = 9
        MaterialButton1.Text = "Google登录"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MaterialButton1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Dropdown1)
        Controls.Add(Label1)
        Controls.Add(Tag1)
        Controls.Add(LabelTime1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As AntdUI.Button
    Friend WithEvents LabelTime1 As AntdUI.LabelTime
    Friend WithEvents Tag1 As AntdUI.Tag
    Friend WithEvents Label1 As AntdUI.Label
    Friend WithEvents Dropdown1 As AntdUI.Dropdown
    Friend WithEvents Button2 As AntdUI.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton

End Class
