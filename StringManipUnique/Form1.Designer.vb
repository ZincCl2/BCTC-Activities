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
        Me.tbxWord = New System.Windows.Forms.TextBox()
        Me.lblCons = New System.Windows.Forms.Label()
        Me.lblVow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxWord
        '
        Me.tbxWord.Location = New System.Drawing.Point(15, 35)
        Me.tbxWord.Name = "tbxWord"
        Me.tbxWord.Size = New System.Drawing.Size(100, 20)
        Me.tbxWord.TabIndex = 0
        '
        'lblCons
        '
        Me.lblCons.AutoSize = True
        Me.lblCons.Location = New System.Drawing.Point(12, 100)
        Me.lblCons.Name = "lblCons"
        Me.lblCons.Size = New System.Drawing.Size(118, 13)
        Me.lblCons.TabIndex = 1
        Me.lblCons.Text = "Number of Consonants:"
        '
        'lblVow
        '
        Me.lblVow.AutoSize = True
        Me.lblVow.Location = New System.Drawing.Point(12, 126)
        Me.lblVow.Name = "lblVow"
        Me.lblVow.Size = New System.Drawing.Size(96, 13)
        Me.lblVow.TabIndex = 2
        Me.lblVow.Text = "Number of Vowels:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter A Word"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(15, 67)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(166, 159)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblVow)
        Me.Controls.Add(Me.lblCons)
        Me.Controls.Add(Me.tbxWord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxWord As TextBox
    Friend WithEvents lblCons As Label
    Friend WithEvents lblVow As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRun As Button
End Class
