<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Q1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        GroupBox1 = New GroupBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Label2 = New Label()
        MaterialTextBox22 = New MaterialSkin.Controls.MaterialTextBox2()
        Label1 = New Label()
        MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Q1
        ' 
        Q1.AutoSize = True
        Q1.Depth = 0
        Q1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        Q1.Location = New Point(12, 414)
        Q1.MouseState = MaterialSkin.MouseState.HOVER
        Q1.Name = "Q1"
        Q1.Size = New Size(49, 19)
        Q1.TabIndex = 0
        Q1.Text = "token="
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(12, 395)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(134, 19)
        MaterialLabel1.TabIndex = 1
        MaterialLabel1.Text = "请勿分享你的Token"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MaterialLabel2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(MaterialTextBox22)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(MaterialTextBox21)
        GroupBox1.Controls.Add(MaterialButton1)
        GroupBox1.Location = New Point(9, 88)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 246)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Google register/login"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(152, 216)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(168, 19)
        MaterialLabel2.TabIndex = 6
        MaterialLabel2.Text = "Powered by Google Ltd."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 5
        Label2.Text = "密码:"
        ' 
        ' MaterialTextBox22
        ' 
        MaterialTextBox22.AnimateReadOnly = False
        MaterialTextBox22.BackgroundImageLayout = ImageLayout.None
        MaterialTextBox22.CharacterCasing = CharacterCasing.Normal
        MaterialTextBox22.Depth = 0
        MaterialTextBox22.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox22.HideSelection = True
        MaterialTextBox22.LeadingIcon = Nothing
        MaterialTextBox22.Location = New Point(75, 104)
        MaterialTextBox22.MaxLength = 32767
        MaterialTextBox22.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox22.Name = "MaterialTextBox22"
        MaterialTextBox22.PasswordChar = ChrW(0)
        MaterialTextBox22.PrefixSuffixText = Nothing
        MaterialTextBox22.ReadOnly = False
        MaterialTextBox22.RightToLeft = RightToLeft.No
        MaterialTextBox22.SelectedText = ""
        MaterialTextBox22.SelectionLength = 0
        MaterialTextBox22.SelectionStart = 0
        MaterialTextBox22.ShortcutsEnabled = True
        MaterialTextBox22.Size = New Size(204, 48)
        MaterialTextBox22.TabIndex = 4
        MaterialTextBox22.TabStop = False
        MaterialTextBox22.TextAlign = HorizontalAlignment.Left
        MaterialTextBox22.TrailingIcon = Nothing
        MaterialTextBox22.UseSystemPasswordChar = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 3
        Label1.Text = "账号:"
        ' 
        ' MaterialTextBox21
        ' 
        MaterialTextBox21.AnimateReadOnly = False
        MaterialTextBox21.BackgroundImageLayout = ImageLayout.None
        MaterialTextBox21.CharacterCasing = CharacterCasing.Normal
        MaterialTextBox21.Depth = 0
        MaterialTextBox21.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox21.HideSelection = True
        MaterialTextBox21.LeadingIcon = Nothing
        MaterialTextBox21.Location = New Point(75, 26)
        MaterialTextBox21.MaxLength = 32767
        MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox21.Name = "MaterialTextBox21"
        MaterialTextBox21.PasswordChar = ChrW(0)
        MaterialTextBox21.PrefixSuffixText = Nothing
        MaterialTextBox21.ReadOnly = False
        MaterialTextBox21.RightToLeft = RightToLeft.No
        MaterialTextBox21.SelectedText = ""
        MaterialTextBox21.SelectionLength = 0
        MaterialTextBox21.SelectionStart = 0
        MaterialTextBox21.ShortcutsEnabled = True
        MaterialTextBox21.Size = New Size(204, 48)
        MaterialTextBox21.TabIndex = 2
        MaterialTextBox21.TabStop = False
        MaterialTextBox21.TextAlign = HorizontalAlignment.Left
        MaterialTextBox21.TrailingIcon = Nothing
        MaterialTextBox21.UseSystemPasswordChar = False
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(75, 201)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(64, 36)
        MaterialButton1.TabIndex = 0
        MaterialButton1.Text = "登录"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label3.Location = New Point(17, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 39)
        Label3.TabIndex = 3
        Label3.Text = "Google Login"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 442)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(MaterialLabel1)
        Controls.Add(Q1)
        Name = "Form4"
        Text = "Form4"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Q1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialTextBox22 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
End Class
