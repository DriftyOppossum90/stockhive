<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Authentication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblShowPass = New System.Windows.Forms.Label()
        Me.ShowPass = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.PassTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.LoginBtn)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lblShowPass)
        Me.Guna2Panel1.Controls.Add(Me.ShowPass)
        Me.Guna2Panel1.Controls.Add(Me.PassTxt)
        Me.Guna2Panel1.Controls.Add(Me.UsernameTxt)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(350, 455)
        Me.Guna2Panel1.TabIndex = 0
        '
        'LoginBtn
        '
        Me.LoginBtn.Animated = True
        Me.LoginBtn.AutoRoundedCorners = True
        Me.LoginBtn.BorderRadius = 21
        Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
        Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
        Me.LoginBtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.HoverState.Parent = Me.LoginBtn
        Me.LoginBtn.Location = New System.Drawing.Point(85, 314)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.Size = New System.Drawing.Size(180, 45)
        Me.LoginBtn.TabIndex = 6
        Me.LoginBtn.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(91, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Incorrect ID or Password!"
        Me.Label2.Visible = False
        '
        'lblShowPass
        '
        Me.lblShowPass.AutoSize = True
        Me.lblShowPass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPass.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblShowPass.Location = New System.Drawing.Point(82, 249)
        Me.lblShowPass.Name = "lblShowPass"
        Me.lblShowPass.Size = New System.Drawing.Size(103, 17)
        Me.lblShowPass.TabIndex = 4
        Me.lblShowPass.Text = "Show Password"
        '
        'ShowPass
        '
        Me.ShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowPass.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPass.CheckedState.InnerColor = System.Drawing.Color.White
        Me.ShowPass.CheckedState.Parent = Me.ShowPass
        Me.ShowPass.Location = New System.Drawing.Point(45, 249)
        Me.ShowPass.Name = "ShowPass"
        Me.ShowPass.ShadowDecoration.Parent = Me.ShowPass
        Me.ShowPass.Size = New System.Drawing.Size(35, 20)
        Me.ShowPass.TabIndex = 3
        Me.ShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ShowPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ShowPass.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.ShowPass.UncheckedState.Parent = Me.ShowPass
        '
        'PassTxt
        '
        Me.PassTxt.Animated = True
        Me.PassTxt.AutoRoundedCorners = True
        Me.PassTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PassTxt.BorderRadius = 17
        Me.PassTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassTxt.DefaultText = ""
        Me.PassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PassTxt.DisabledState.Parent = Me.PassTxt
        Me.PassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PassTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PassTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PassTxt.FocusedState.Parent = Me.PassTxt
        Me.PassTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PassTxt.ForeColor = System.Drawing.Color.White
        Me.PassTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PassTxt.HoverState.Parent = Me.PassTxt
        Me.PassTxt.IconLeft = Global.StockHive.My.Resources.Resources.icons8_password_window_24
        Me.PassTxt.Location = New System.Drawing.Point(45, 200)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PassTxt.PlaceholderText = "Password"
        Me.PassTxt.SelectedText = ""
        Me.PassTxt.ShadowDecoration.Parent = Me.PassTxt
        Me.PassTxt.Size = New System.Drawing.Size(261, 36)
        Me.PassTxt.TabIndex = 2
        Me.PassTxt.UseSystemPasswordChar = True
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Animated = True
        Me.UsernameTxt.AutoRoundedCorners = True
        Me.UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameTxt.BorderRadius = 17
        Me.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTxt.DefaultText = ""
        Me.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxt.DisabledState.Parent = Me.UsernameTxt
        Me.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxt.FocusedState.Parent = Me.UsernameTxt
        Me.UsernameTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UsernameTxt.ForeColor = System.Drawing.Color.White
        Me.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxt.HoverState.Parent = Me.UsernameTxt
        Me.UsernameTxt.IconLeft = Global.StockHive.My.Resources.Resources.icons8_username_24
        Me.UsernameTxt.Location = New System.Drawing.Point(45, 147)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxt.PlaceholderText = "EmployeeID"
        Me.UsernameTxt.SelectedText = ""
        Me.UsernameTxt.ShadowDecoration.Parent = Me.UsernameTxt
        Me.UsernameTxt.Size = New System.Drawing.Size(261, 36)
        Me.UsernameTxt.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.Image = Global.StockHive.My.Resources.Resources._058112e7_88c6_4184_9733_3c600f338dac_200x200
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(350, 131)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(304, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.DarkRed
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 7
        '
        'Authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(350, 500)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Authentication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentication"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UsernameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PassTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblShowPass As Label
    Friend WithEvents ShowPass As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
