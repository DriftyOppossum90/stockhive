<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.ProductEdit = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
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
        Me.ListView = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StockListView = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.StockList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ProductEdit.SuspendLayout()
        Me.ListView.SuspendLayout()
        Me.StockListView.SuspendLayout()
        CType(Me.StockList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'ProductEdit
        '
        Me.ProductEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductEdit.Controls.Add(Me.btnCancel)
        Me.ProductEdit.Controls.Add(Me.btnEdit)
        Me.ProductEdit.Controls.Add(Me.btnDelete)
        Me.ProductEdit.Controls.Add(Me.btnSave)
        Me.ProductEdit.Controls.Add(Me.btnAdd)
        Me.ProductEdit.Controls.Add(Me.lblQuantity)
        Me.ProductEdit.Controls.Add(Me.lblPrice)
        Me.ProductEdit.Controls.Add(Me.lblDesc)
        Me.ProductEdit.Controls.Add(Me.lblName)
        Me.ProductEdit.Controls.Add(Me.lblProductID)
        Me.ProductEdit.Controls.Add(Me.QuantityTxt)
        Me.ProductEdit.Controls.Add(Me.PriceTxt)
        Me.ProductEdit.Controls.Add(Me.DescTxt)
        Me.ProductEdit.Controls.Add(Me.NameTxt)
        Me.ProductEdit.Controls.Add(Me.IDTxt)
        Me.ProductEdit.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductEdit.FillColor = System.Drawing.Color.Black
        Me.ProductEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProductEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ProductEdit.Location = New System.Drawing.Point(12, 12)
        Me.ProductEdit.Name = "ProductEdit"
        Me.ProductEdit.ShadowDecoration.Parent = Me.ProductEdit
        Me.ProductEdit.Size = New System.Drawing.Size(760, 458)
        Me.ProductEdit.TabIndex = 0
        Me.ProductEdit.Text = "Product Information"
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AutoRoundedCorners = True
        Me.btnEdit.BorderColor = System.Drawing.Color.White
        Me.btnEdit.BorderRadius = 21
        Me.btnEdit.BorderThickness = 2
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.Transparent
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(509, 157)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(180, 45)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "EDIT"
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.AutoRoundedCorners = True
        Me.btnDelete.BorderColor = System.Drawing.Color.White
        Me.btnDelete.BorderRadius = 21
        Me.btnDelete.BorderThickness = 2
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.FillColor = System.Drawing.Color.Transparent
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.Location = New System.Drawing.Point(509, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(180, 45)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "DELETE"
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
        Me.btnSave.Location = New System.Drawing.Point(509, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "SAVE"
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.AutoRoundedCorners = True
        Me.btnAdd.BorderColor = System.Drawing.Color.White
        Me.btnAdd.BorderRadius = 21
        Me.btnAdd.BorderThickness = 2
        Me.btnAdd.CheckedState.Parent = Me.btnAdd
        Me.btnAdd.CustomImages.Parent = Me.btnAdd
        Me.btnAdd.FillColor = System.Drawing.Color.Transparent
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.Parent = Me.btnAdd
        Me.btnAdd.Location = New System.Drawing.Point(509, 99)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.Parent = Me.btnAdd
        Me.btnAdd.Size = New System.Drawing.Size(180, 45)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(32, 345)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(85, 23)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(32, 285)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(54, 23)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(32, 226)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(107, 23)
        Me.lblDesc.TabIndex = 7
        Me.lblDesc.Text = "Description:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(32, 166)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 23)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(32, 108)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(96, 23)
        Me.lblProductID.TabIndex = 5
        Me.lblProductID.Text = "ProductID:"
        '
        'QuantityTxt
        '
        Me.QuantityTxt.AutoRoundedCorners = True
        Me.QuantityTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.QuantityTxt.BorderRadius = 17
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
        Me.QuantityTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTxt.ForeColor = System.Drawing.Color.White
        Me.QuantityTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityTxt.HoverState.Parent = Me.QuantityTxt
        Me.QuantityTxt.Location = New System.Drawing.Point(177, 336)
        Me.QuantityTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityTxt.PlaceholderText = ""
        Me.QuantityTxt.SelectedText = ""
        Me.QuantityTxt.ShadowDecoration.Parent = Me.QuantityTxt
        Me.QuantityTxt.Size = New System.Drawing.Size(200, 36)
        Me.QuantityTxt.TabIndex = 4
        '
        'PriceTxt
        '
        Me.PriceTxt.Animated = True
        Me.PriceTxt.AutoRoundedCorners = True
        Me.PriceTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PriceTxt.BorderRadius = 17
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
        Me.PriceTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTxt.ForeColor = System.Drawing.Color.White
        Me.PriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceTxt.HoverState.Parent = Me.PriceTxt
        Me.PriceTxt.Location = New System.Drawing.Point(177, 276)
        Me.PriceTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceTxt.PlaceholderText = ""
        Me.PriceTxt.SelectedText = ""
        Me.PriceTxt.ShadowDecoration.Parent = Me.PriceTxt
        Me.PriceTxt.Size = New System.Drawing.Size(200, 36)
        Me.PriceTxt.TabIndex = 3
        '
        'DescTxt
        '
        Me.DescTxt.Animated = True
        Me.DescTxt.AutoRoundedCorners = True
        Me.DescTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DescTxt.BorderRadius = 17
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
        Me.DescTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescTxt.ForeColor = System.Drawing.Color.White
        Me.DescTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescTxt.HoverState.Parent = Me.DescTxt
        Me.DescTxt.Location = New System.Drawing.Point(177, 217)
        Me.DescTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescTxt.PlaceholderText = ""
        Me.DescTxt.SelectedText = ""
        Me.DescTxt.ShadowDecoration.Parent = Me.DescTxt
        Me.DescTxt.Size = New System.Drawing.Size(200, 36)
        Me.DescTxt.TabIndex = 2
        '
        'NameTxt
        '
        Me.NameTxt.Animated = True
        Me.NameTxt.AutoRoundedCorners = True
        Me.NameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NameTxt.BorderRadius = 17
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
        Me.NameTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.ForeColor = System.Drawing.Color.White
        Me.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.HoverState.Parent = Me.NameTxt
        Me.NameTxt.Location = New System.Drawing.Point(177, 157)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTxt.PlaceholderText = ""
        Me.NameTxt.SelectedText = ""
        Me.NameTxt.ShadowDecoration.Parent = Me.NameTxt
        Me.NameTxt.Size = New System.Drawing.Size(200, 36)
        Me.NameTxt.TabIndex = 1
        '
        'IDTxt
        '
        Me.IDTxt.Animated = True
        Me.IDTxt.AutoRoundedCorners = True
        Me.IDTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IDTxt.BorderRadius = 17
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
        Me.IDTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTxt.ForeColor = System.Drawing.Color.White
        Me.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDTxt.HoverState.Parent = Me.IDTxt
        Me.IDTxt.Location = New System.Drawing.Point(177, 99)
        Me.IDTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDTxt.Name = "IDTxt"
        Me.IDTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDTxt.PlaceholderText = ""
        Me.IDTxt.SelectedText = ""
        Me.IDTxt.ShadowDecoration.Parent = Me.IDTxt
        Me.IDTxt.Size = New System.Drawing.Size(200, 36)
        Me.IDTxt.TabIndex = 0
        '
        'ListView
        '
        Me.ListView.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ListView.Controls.Add(Me.ListView1)
        Me.ListView.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ListView.FillColor = System.Drawing.Color.Black
        Me.ListView.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ListView.Location = New System.Drawing.Point(12, 476)
        Me.ListView.Name = "ListView"
        Me.ListView.ShadowDecoration.Parent = Me.ListView
        Me.ListView.Size = New System.Drawing.Size(760, 510)
        Me.ListView.TabIndex = 1
        Me.ListView.Text = "Confirm Data"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductName, Me.ProductDesc, Me.Price, Me.Quantity})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Gainsboro
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 43)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(760, 467)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "ProductID"
        Me.ProductID.Width = 100
        '
        'ProductName
        '
        Me.ProductName.Text = "Name"
        Me.ProductName.Width = 270
        '
        'ProductDesc
        '
        Me.ProductDesc.Text = "Description"
        Me.ProductDesc.Width = 117
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 168
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 100
        '
        'StockListView
        '
        Me.StockListView.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.StockListView.Controls.Add(Me.StockList)
        Me.StockListView.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.StockListView.FillColor = System.Drawing.Color.Black
        Me.StockListView.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StockListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.StockListView.Location = New System.Drawing.Point(778, 12)
        Me.StockListView.Name = "StockListView"
        Me.StockListView.ShadowDecoration.Parent = Me.StockListView
        Me.StockListView.Size = New System.Drawing.Size(834, 974)
        Me.StockListView.TabIndex = 2
        Me.StockListView.Text = "View Data"
        '
        'StockList
        '
        Me.StockList.AllowUserToAddRows = False
        Me.StockList.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.StockList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StockList.BackgroundColor = System.Drawing.Color.Black
        Me.StockList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StockList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StockList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StockList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StockList.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StockList.DefaultCellStyle = DataGridViewCellStyle3
        Me.StockList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StockList.EnableHeadersVisualStyles = False
        Me.StockList.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.StockList.Location = New System.Drawing.Point(0, 42)
        Me.StockList.Name = "StockList"
        Me.StockList.ReadOnly = True
        Me.StockList.RowHeadersVisible = False
        Me.StockList.RowHeadersWidth = 51
        Me.StockList.RowTemplate.Height = 24
        Me.StockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StockList.Size = New System.Drawing.Size(834, 932)
        Me.StockList.TabIndex = 0
        Me.StockList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.StockList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.StockList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StockList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StockList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StockList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StockList.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.StockList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.StockList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.StockList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StockList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StockList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.StockList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StockList.ThemeStyle.HeaderStyle.Height = 40
        Me.StockList.ThemeStyle.ReadOnly = True
        Me.StockList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.StockList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StockList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StockList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.StockList.ThemeStyle.RowsStyle.Height = 24
        Me.StockList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.StockList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.btnCancel.Location = New System.Drawing.Point(509, 348)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(180, 45)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.Visible = False
        '
        'FormManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(1624, 998)
        Me.Controls.Add(Me.StockListView)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.ProductEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManage"
        Me.Text = "FormManage"
        Me.ProductEdit.ResumeLayout(False)
        Me.ProductEdit.PerformLayout()
        Me.ListView.ResumeLayout(False)
        Me.StockListView.ResumeLayout(False)
        CType(Me.StockList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents ProductEdit As Guna.UI2.WinForms.Guna2GroupBox
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
    Friend WithEvents StockListView As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents StockList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ListView As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents ProductDesc As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
