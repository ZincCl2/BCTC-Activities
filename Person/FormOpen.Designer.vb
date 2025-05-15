<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpen
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
        Me.lbxNames = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxWeight = New System.Windows.Forms.TextBox()
        Me.tbxPayRate = New System.Windows.Forms.TextBox()
        Me.tbxSavings = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblPayRate = New System.Windows.Forms.Label()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbxInsurance = New System.Windows.Forms.GroupBox()
        Me.cbxDental = New System.Windows.Forms.CheckBox()
        Me.cbxVision = New System.Windows.Forms.CheckBox()
        Me.cbxMedical = New System.Windows.Forms.CheckBox()
        Me.gbxInsurance.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxNames
        '
        Me.lbxNames.FormattingEnabled = True
        Me.lbxNames.Location = New System.Drawing.Point(177, 12)
        Me.lbxNames.Name = "lbxNames"
        Me.lbxNames.Size = New System.Drawing.Size(125, 238)
        Me.lbxNames.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(70, 222)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(70, 12)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(100, 20)
        Me.tbxName.TabIndex = 2
        '
        'tbxWeight
        '
        Me.tbxWeight.Location = New System.Drawing.Point(70, 39)
        Me.tbxWeight.Name = "tbxWeight"
        Me.tbxWeight.Size = New System.Drawing.Size(100, 20)
        Me.tbxWeight.TabIndex = 3
        '
        'tbxPayRate
        '
        Me.tbxPayRate.Location = New System.Drawing.Point(70, 66)
        Me.tbxPayRate.Name = "tbxPayRate"
        Me.tbxPayRate.Size = New System.Drawing.Size(100, 20)
        Me.tbxPayRate.TabIndex = 4
        '
        'tbxSavings
        '
        Me.tbxSavings.Location = New System.Drawing.Point(70, 93)
        Me.tbxSavings.Name = "tbxSavings"
        Me.tbxSavings.Size = New System.Drawing.Size(100, 20)
        Me.tbxSavings.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(29, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(23, 42)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 7
        Me.lblWeight.Text = "Weight:"
        '
        'lblPayRate
        '
        Me.lblPayRate.AutoSize = True
        Me.lblPayRate.Location = New System.Drawing.Point(13, 69)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(54, 13)
        Me.lblPayRate.TabIndex = 8
        Me.lblPayRate.Text = "Pay Rate:"
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Location = New System.Drawing.Point(19, 93)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(48, 13)
        Me.lblSavings.TabIndex = 9
        Me.lblSavings.Text = "Savings:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(13, 222)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbxInsurance
        '
        Me.gbxInsurance.Controls.Add(Me.cbxDental)
        Me.gbxInsurance.Controls.Add(Me.cbxVision)
        Me.gbxInsurance.Controls.Add(Me.cbxMedical)
        Me.gbxInsurance.Location = New System.Drawing.Point(12, 119)
        Me.gbxInsurance.Name = "gbxInsurance"
        Me.gbxInsurance.Size = New System.Drawing.Size(158, 97)
        Me.gbxInsurance.TabIndex = 11
        Me.gbxInsurance.TabStop = False
        Me.gbxInsurance.Text = "Insurance"
        '
        'cbxDental
        '
        Me.cbxDental.AutoSize = True
        Me.cbxDental.Location = New System.Drawing.Point(7, 68)
        Me.cbxDental.Name = "cbxDental"
        Me.cbxDental.Size = New System.Drawing.Size(86, 17)
        Me.cbxDental.TabIndex = 2
        Me.cbxDental.Text = "Dental: .33%"
        Me.cbxDental.UseVisualStyleBackColor = True
        '
        'cbxVision
        '
        Me.cbxVision.AutoSize = True
        Me.cbxVision.Location = New System.Drawing.Point(7, 44)
        Me.cbxVision.Name = "cbxVision"
        Me.cbxVision.Size = New System.Drawing.Size(83, 17)
        Me.cbxVision.TabIndex = 1
        Me.cbxVision.Text = "Vision: .10%"
        Me.cbxVision.UseVisualStyleBackColor = True
        '
        'cbxMedical
        '
        Me.cbxMedical.AutoSize = True
        Me.cbxMedical.Location = New System.Drawing.Point(7, 20)
        Me.cbxMedical.Name = "cbxMedical"
        Me.cbxMedical.Size = New System.Drawing.Size(89, 17)
        Me.cbxMedical.TabIndex = 0
        Me.cbxMedical.Text = "Medical: 11%"
        Me.cbxMedical.UseVisualStyleBackColor = True
        '
        'frmOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 257)
        Me.Controls.Add(Me.gbxInsurance)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.lblPayRate)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tbxSavings)
        Me.Controls.Add(Me.tbxPayRate)
        Me.Controls.Add(Me.tbxWeight)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbxNames)
        Me.Name = "frmOpen"
        Me.Text = "frmOpen"
        Me.gbxInsurance.ResumeLayout(False)
        Me.gbxInsurance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbxNames As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxWeight As TextBox
    Friend WithEvents tbxPayRate As TextBox
    Friend WithEvents tbxSavings As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblPayRate As Label
    Friend WithEvents lblSavings As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents gbxInsurance As GroupBox
    Friend WithEvents cbxDental As CheckBox
    Friend WithEvents cbxVision As CheckBox
    Friend WithEvents cbxMedical As CheckBox
End Class
