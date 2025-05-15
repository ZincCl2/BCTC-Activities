<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerson
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
        Me.btnEat = New System.Windows.Forms.Button()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.btnExercise = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnPromote = New System.Windows.Forms.Button()
        Me.lblPayCheck = New System.Windows.Forms.Label()
        Me.lblDefaultWeight = New System.Windows.Forms.Label()
        Me.lblPromotion = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbxInsurance = New System.Windows.Forms.GroupBox()
        Me.cbxDental = New System.Windows.Forms.CheckBox()
        Me.cbxVision = New System.Windows.Forms.CheckBox()
        Me.cbxMedical = New System.Windows.Forms.CheckBox()
        Me.gbxInsurance.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEat
        '
        Me.btnEat.Location = New System.Drawing.Point(13, 43)
        Me.btnEat.Name = "btnEat"
        Me.btnEat.Size = New System.Drawing.Size(75, 23)
        Me.btnEat.TabIndex = 0
        Me.btnEat.Text = "Eat"
        Me.btnEat.UseVisualStyleBackColor = True
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(10, 69)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(65, 13)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Weight: ___"
        '
        'btnExercise
        '
        Me.btnExercise.Location = New System.Drawing.Point(13, 85)
        Me.btnExercise.Name = "btnExercise"
        Me.btnExercise.Size = New System.Drawing.Size(75, 23)
        Me.btnExercise.TabIndex = 2
        Me.btnExercise.Text = "Exercise"
        Me.btnExercise.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(13, 114)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "PayMe"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnPromote
        '
        Me.btnPromote.Location = New System.Drawing.Point(13, 156)
        Me.btnPromote.Name = "btnPromote"
        Me.btnPromote.Size = New System.Drawing.Size(75, 23)
        Me.btnPromote.TabIndex = 4
        Me.btnPromote.Text = "PromoteMe"
        Me.btnPromote.UseVisualStyleBackColor = True
        '
        'lblPayCheck
        '
        Me.lblPayCheck.AutoSize = True
        Me.lblPayCheck.Location = New System.Drawing.Point(10, 140)
        Me.lblPayCheck.Name = "lblPayCheck"
        Me.lblPayCheck.Size = New System.Drawing.Size(86, 13)
        Me.lblPayCheck.TabIndex = 5
        Me.lblPayCheck.Text = "PayCheck: $___"
        '
        'lblDefaultWeight
        '
        Me.lblDefaultWeight.AutoSize = True
        Me.lblDefaultWeight.Location = New System.Drawing.Point(10, 27)
        Me.lblDefaultWeight.Name = "lblDefaultWeight"
        Me.lblDefaultWeight.Size = New System.Drawing.Size(81, 13)
        Me.lblDefaultWeight.TabIndex = 7
        Me.lblDefaultWeight.Text = "Current Weight:"
        '
        'lblPromotion
        '
        Me.lblPromotion.AutoSize = True
        Me.lblPromotion.Location = New System.Drawing.Point(10, 182)
        Me.lblPromotion.Name = "lblPromotion"
        Me.lblPromotion.Size = New System.Drawing.Size(78, 13)
        Me.lblPromotion.TabIndex = 8
        Me.lblPromotion.Text = "PayRate: $___"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(130, 156)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 39)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbxInsurance
        '
        Me.gbxInsurance.Controls.Add(Me.cbxDental)
        Me.gbxInsurance.Controls.Add(Me.cbxVision)
        Me.gbxInsurance.Controls.Add(Me.cbxMedical)
        Me.gbxInsurance.Location = New System.Drawing.Point(113, 48)
        Me.gbxInsurance.Name = "gbxInsurance"
        Me.gbxInsurance.Size = New System.Drawing.Size(107, 89)
        Me.gbxInsurance.TabIndex = 12
        Me.gbxInsurance.TabStop = False
        Me.gbxInsurance.Text = "Current Insurance"
        '
        'cbxDental
        '
        Me.cbxDental.AutoSize = True
        Me.cbxDental.Location = New System.Drawing.Point(7, 65)
        Me.cbxDental.Name = "cbxDental"
        Me.cbxDental.Size = New System.Drawing.Size(57, 17)
        Me.cbxDental.TabIndex = 2
        Me.cbxDental.Text = "Dental"
        Me.cbxDental.UseVisualStyleBackColor = True
        '
        'cbxVision
        '
        Me.cbxVision.AutoSize = True
        Me.cbxVision.Location = New System.Drawing.Point(7, 42)
        Me.cbxVision.Name = "cbxVision"
        Me.cbxVision.Size = New System.Drawing.Size(54, 17)
        Me.cbxVision.TabIndex = 1
        Me.cbxVision.Text = "Vision"
        Me.cbxVision.UseVisualStyleBackColor = True
        '
        'cbxMedical
        '
        Me.cbxMedical.AutoSize = True
        Me.cbxMedical.Location = New System.Drawing.Point(7, 20)
        Me.cbxMedical.Name = "cbxMedical"
        Me.cbxMedical.Size = New System.Drawing.Size(63, 17)
        Me.cbxMedical.TabIndex = 0
        Me.cbxMedical.Text = "Medical"
        Me.cbxMedical.UseVisualStyleBackColor = True
        '
        'frmPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 211)
        Me.Controls.Add(Me.gbxInsurance)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblPromotion)
        Me.Controls.Add(Me.lblDefaultWeight)
        Me.Controls.Add(Me.lblPayCheck)
        Me.Controls.Add(Me.btnPromote)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnExercise)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.btnEat)
        Me.Name = "frmPerson"
        Me.Text = "Person"
        Me.gbxInsurance.ResumeLayout(False)
        Me.gbxInsurance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEat As Button
    Friend WithEvents lblWeight As Label
    Friend WithEvents btnExercise As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnPromote As Button
    Friend WithEvents lblPayCheck As Label
    Friend WithEvents lblDefaultWeight As Label
    Friend WithEvents lblPromotion As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents gbxInsurance As GroupBox
    Friend WithEvents cbxDental As CheckBox
    Friend WithEvents cbxVision As CheckBox
    Friend WithEvents cbxMedical As CheckBox
End Class
