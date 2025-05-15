<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.cbxConvertible = New System.Windows.Forms.CheckBox()
        Me.tbxNumber = New System.Windows.Forms.TextBox()
        Me.tbxMake = New System.Windows.Forms.TextBox()
        Me.tbxModel = New System.Windows.Forms.TextBox()
        Me.tbxYear = New System.Windows.Forms.TextBox()
        Me.tbxMileage = New System.Windows.Forms.TextBox()
        Me.tbxStandardPrice = New System.Windows.Forms.TextBox()
        Me.lblStickerPrice = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMileage = New System.Windows.Forms.Label()
        Me.lblStandardPrice = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCurrentInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboColor
        '
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Items.AddRange(New Object() {"White", "Black", "Dark Gray", "Silver", "Red", "Blue", "Orange", "Green", "Brown", "Yellow", "Gold", "Beige", "Purple", "Magenta", "Pink", "Teal", "Ruby"})
        Me.cboColor.Location = New System.Drawing.Point(267, 198)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(100, 21)
        Me.cboColor.TabIndex = 0
        Me.cboColor.Text = "White"
        '
        'cbxConvertible
        '
        Me.cbxConvertible.AutoSize = True
        Me.cbxConvertible.Location = New System.Drawing.Point(96, 172)
        Me.cbxConvertible.Name = "cbxConvertible"
        Me.cbxConvertible.Size = New System.Drawing.Size(79, 17)
        Me.cbxConvertible.TabIndex = 1
        Me.cbxConvertible.Text = "Convertible"
        Me.cbxConvertible.UseVisualStyleBackColor = True
        '
        'tbxNumber
        '
        Me.tbxNumber.Location = New System.Drawing.Point(192, 66)
        Me.tbxNumber.Name = "tbxNumber"
        Me.tbxNumber.Size = New System.Drawing.Size(129, 20)
        Me.tbxNumber.TabIndex = 2
        '
        'tbxMake
        '
        Me.tbxMake.Location = New System.Drawing.Point(96, 106)
        Me.tbxMake.Name = "tbxMake"
        Me.tbxMake.Size = New System.Drawing.Size(100, 20)
        Me.tbxMake.TabIndex = 3
        '
        'tbxModel
        '
        Me.tbxModel.Location = New System.Drawing.Point(267, 106)
        Me.tbxModel.Name = "tbxModel"
        Me.tbxModel.Size = New System.Drawing.Size(100, 20)
        Me.tbxModel.TabIndex = 4
        '
        'tbxYear
        '
        Me.tbxYear.Location = New System.Drawing.Point(96, 144)
        Me.tbxYear.Name = "tbxYear"
        Me.tbxYear.Size = New System.Drawing.Size(100, 20)
        Me.tbxYear.TabIndex = 5
        '
        'tbxMileage
        '
        Me.tbxMileage.Location = New System.Drawing.Point(267, 144)
        Me.tbxMileage.Name = "tbxMileage"
        Me.tbxMileage.Size = New System.Drawing.Size(100, 20)
        Me.tbxMileage.TabIndex = 6
        '
        'tbxStandardPrice
        '
        Me.tbxStandardPrice.Location = New System.Drawing.Point(96, 198)
        Me.tbxStandardPrice.Name = "tbxStandardPrice"
        Me.tbxStandardPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbxStandardPrice.TabIndex = 7
        '
        'lblStickerPrice
        '
        Me.lblStickerPrice.AutoSize = True
        Me.lblStickerPrice.Location = New System.Drawing.Point(20, 235)
        Me.lblStickerPrice.Name = "lblStickerPrice"
        Me.lblStickerPrice.Size = New System.Drawing.Size(70, 13)
        Me.lblStickerPrice.TabIndex = 8
        Me.lblStickerPrice.Text = "Sticker Price:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(147, 266)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add To Inventory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(108, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(170, 22)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Used Car Inventory"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(101, 69)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(85, 13)
        Me.lblNumber.TabIndex = 12
        Me.lblNumber.Text = "Vehicle Number:"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(53, 109)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(37, 13)
        Me.lblMake.TabIndex = 13
        Me.lblMake.Text = "Make:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(222, 109)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 14
        Me.lblModel.Text = "Model:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(58, 147)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 15
        Me.lblYear.Text = "Year:"
        '
        'lblMileage
        '
        Me.lblMileage.AutoSize = True
        Me.lblMileage.Location = New System.Drawing.Point(214, 147)
        Me.lblMileage.Name = "lblMileage"
        Me.lblMileage.Size = New System.Drawing.Size(47, 13)
        Me.lblMileage.TabIndex = 16
        Me.lblMileage.Text = "Mileage:"
        '
        'lblStandardPrice
        '
        Me.lblStandardPrice.AutoSize = True
        Me.lblStandardPrice.Location = New System.Drawing.Point(10, 201)
        Me.lblStandardPrice.Name = "lblStandardPrice"
        Me.lblStandardPrice.Size = New System.Drawing.Size(80, 13)
        Me.lblStandardPrice.TabIndex = 17
        Me.lblStandardPrice.Text = "Standard Price:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(227, 201)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 18
        Me.lblColor.Text = "Color:"
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.Location = New System.Drawing.Point(253, 235)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(114, 82)
        Me.lstInventory.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(389, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayCurrentInventoryToolStripMenuItem, Me.CloseFormToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisplayCurrentInventoryToolStripMenuItem
        '
        Me.DisplayCurrentInventoryToolStripMenuItem.Name = "DisplayCurrentInventoryToolStripMenuItem"
        Me.DisplayCurrentInventoryToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.DisplayCurrentInventoryToolStripMenuItem.Text = "Display Current Inventory"
        '
        'CloseFormToolStripMenuItem
        '
        Me.CloseFormToolStripMenuItem.Name = "CloseFormToolStripMenuItem"
        Me.CloseFormToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CloseFormToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 334)
        Me.Controls.Add(Me.lstInventory)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblStandardPrice)
        Me.Controls.Add(Me.lblMileage)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblStickerPrice)
        Me.Controls.Add(Me.tbxStandardPrice)
        Me.Controls.Add(Me.tbxMileage)
        Me.Controls.Add(Me.tbxYear)
        Me.Controls.Add(Me.tbxModel)
        Me.Controls.Add(Me.tbxMake)
        Me.Controls.Add(Me.tbxNumber)
        Me.Controls.Add(Me.cbxConvertible)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Used Car Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboColor As ComboBox
    Friend WithEvents cbxConvertible As CheckBox
    Friend WithEvents tbxNumber As TextBox
    Friend WithEvents tbxMake As TextBox
    Friend WithEvents tbxModel As TextBox
    Friend WithEvents tbxYear As TextBox
    Friend WithEvents tbxMileage As TextBox
    Friend WithEvents tbxStandardPrice As TextBox
    Friend WithEvents lblStickerPrice As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMileage As Label
    Friend WithEvents lblStandardPrice As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lstInventory As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayCurrentInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseFormToolStripMenuItem As ToolStripMenuItem
End Class
