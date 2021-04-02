<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        Me.EditData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.QuantityTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PriceTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DescTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IDTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.EditData.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'EditData
        '
        Me.EditData.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EditData.Controls.Add(Me.btnCancel)
        Me.EditData.Controls.Add(Me.btnSave)
        Me.EditData.Controls.Add(Me.lblQuantity)
        Me.EditData.Controls.Add(Me.lblPrice)
        Me.EditData.Controls.Add(Me.lblDesc)
        Me.EditData.Controls.Add(Me.lblName)
        Me.EditData.Controls.Add(Me.lblProductID)
        Me.EditData.Controls.Add(Me.QuantityTxt)
        Me.EditData.Controls.Add(Me.PriceTxt)
        Me.EditData.Controls.Add(Me.DescTxt)
        Me.EditData.Controls.Add(Me.NameTxt)
        Me.EditData.Controls.Add(Me.IDTxt)
        Me.EditData.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EditData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditData.FillColor = System.Drawing.Color.Black
        Me.EditData.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.EditData.Location = New System.Drawing.Point(0, 0)
        Me.EditData.Name = "EditData"
        Me.EditData.ShadowDecoration.Parent = Me.EditData
        Me.EditData.Size = New System.Drawing.Size(800, 450)
        Me.EditData.TabIndex = 0
        Me.EditData.Text = "Edit Data"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.AutoRoundedCorners = True
        Me.btnCancel.BorderColor = System.Drawing.Color.White
        Me.btnCancel.BorderRadius = 21
        Me.btnCancel.BorderThickness = 2
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.FillColor = System.Drawing.Color.Transparent
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(521, 393)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "CANCEL"
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.AutoRoundedCorners = True
        Me.btnSave.BorderColor = System.Drawing.Color.White
        Me.btnSave.BorderRadius = 21
        Me.btnSave.BorderThickness = 2
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(325, 393)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(105, 336)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(94, 25)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(105, 271)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(61, 25)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(105, 208)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(119, 25)
        Me.lblDesc.TabIndex = 7
        Me.lblDesc.Text = "Description:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(105, 144)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(69, 25)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(105, 79)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(109, 25)
        Me.lblProductID.TabIndex = 5
        Me.lblProductID.Text = "ProductID:"
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Animated = True
        Me.QuantityTxt.AutoRoundedCorners = True
        Me.QuantityTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QuantityTxt.BorderRadius = 19
        Me.QuantityTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityTxt.DefaultText = ""
        Me.QuantityTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTxt.DisabledState.Parent = Me.QuantityTxt
        Me.QuantityTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QuantityTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTxt.FocusedState.Parent = Me.QuantityTxt
        Me.QuantityTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTxt.ForeColor = System.Drawing.Color.White
        Me.QuantityTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTxt.HoverState.Parent = Me.QuantityTxt
        Me.QuantityTxt.Location = New System.Drawing.Point(351, 322)
        Me.QuantityTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTxt.PlaceholderText = ""
        Me.QuantityTxt.SelectedText = ""
        Me.QuantityTxt.ShadowDecoration.Parent = Me.QuantityTxt
        Me.QuantityTxt.Size = New System.Drawing.Size(302, 41)
        Me.QuantityTxt.TabIndex = 4
        '
        'PriceTxt
        '
        Me.PriceTxt.Animated = True
        Me.PriceTxt.AutoRoundedCorners = True
        Me.PriceTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTxt.BorderRadius = 19
        Me.PriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceTxt.DefaultText = ""
        Me.PriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTxt.DisabledState.Parent = Me.PriceTxt
        Me.PriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTxt.FocusedState.Parent = Me.PriceTxt
        Me.PriceTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTxt.ForeColor = System.Drawing.Color.White
        Me.PriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTxt.HoverState.Parent = Me.PriceTxt
        Me.PriceTxt.Location = New System.Drawing.Point(351, 257)
        Me.PriceTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceTxt.PlaceholderText = ""
        Me.PriceTxt.SelectedText = ""
        Me.PriceTxt.ShadowDecoration.Parent = Me.PriceTxt
        Me.PriceTxt.Size = New System.Drawing.Size(302, 41)
        Me.PriceTxt.TabIndex = 3
        '
        'DescTxt
        '
        Me.DescTxt.Animated = True
        Me.DescTxt.AutoRoundedCorners = True
        Me.DescTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DescTxt.BorderRadius = 19
        Me.DescTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescTxt.DefaultText = ""
        Me.DescTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescTxt.DisabledState.Parent = Me.DescTxt
        Me.DescTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DescTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescTxt.FocusedState.Parent = Me.DescTxt
        Me.DescTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescTxt.ForeColor = System.Drawing.Color.White
        Me.DescTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescTxt.HoverState.Parent = Me.DescTxt
        Me.DescTxt.Location = New System.Drawing.Point(351, 194)
        Me.DescTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescTxt.PlaceholderText = ""
        Me.DescTxt.SelectedText = ""
        Me.DescTxt.ShadowDecoration.Parent = Me.DescTxt
        Me.DescTxt.Size = New System.Drawing.Size(302, 41)
        Me.DescTxt.TabIndex = 2
        '
        'NameTxt
        '
        Me.NameTxt.Animated = True
        Me.NameTxt.AutoRoundedCorners = True
        Me.NameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameTxt.BorderRadius = 19
        Me.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTxt.DefaultText = ""
        Me.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxt.DisabledState.Parent = Me.NameTxt
        Me.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.FocusedState.Parent = Me.NameTxt
        Me.NameTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.ForeColor = System.Drawing.Color.White
        Me.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.HoverState.Parent = Me.NameTxt
        Me.NameTxt.Location = New System.Drawing.Point(351, 130)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTxt.PlaceholderText = ""
        Me.NameTxt.SelectedText = ""
        Me.NameTxt.ShadowDecoration.Parent = Me.NameTxt
        Me.NameTxt.Size = New System.Drawing.Size(302, 41)
        Me.NameTxt.TabIndex = 1
        '
        'IDTxt
        '
        Me.IDTxt.Animated = True
        Me.IDTxt.AutoRoundedCorners = True
        Me.IDTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IDTxt.BorderRadius = 19
        Me.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDTxt.DefaultText = ""
        Me.IDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDTxt.DisabledState.Parent = Me.IDTxt
        Me.IDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDTxt.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDTxt.FocusedState.Parent = Me.IDTxt
        Me.IDTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTxt.ForeColor = System.Drawing.Color.White
        Me.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDTxt.HoverState.Parent = Me.IDTxt
        Me.IDTxt.Location = New System.Drawing.Point(351, 65)
        Me.IDTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.IDTxt.Name = "IDTxt"
        Me.IDTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDTxt.PlaceholderText = ""
        Me.IDTxt.SelectedText = ""
        Me.IDTxt.ShadowDecoration.Parent = Me.IDTxt
        Me.IDTxt.Size = New System.Drawing.Size(302, 41)
        Me.IDTxt.TabIndex = 0
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EditData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEdit"
        Me.Text = "FormEdit"
        Me.EditData.ResumeLayout(False)
        Me.EditData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents EditData As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents QuantityTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PriceTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DescTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IDTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
