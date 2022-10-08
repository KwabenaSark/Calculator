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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdSubtract = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(129, 40)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(123, 20)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(129, 79)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(123, 20)
        Me.txtNum2.TabIndex = 1
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(186, 217)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(100, 40)
        Me.cmdMultiply.TabIndex = 2
        Me.cmdMultiply.Text = "Multiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(71, 217)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(100, 40)
        Me.cmdAdd.TabIndex = 3
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSubtract
        '
        Me.cmdSubtract.Location = New System.Drawing.Point(71, 285)
        Me.cmdSubtract.Name = "cmdSubtract"
        Me.cmdSubtract.Size = New System.Drawing.Size(100, 40)
        Me.cmdSubtract.TabIndex = 4
        Me.cmdSubtract.Text = "Subtract"
        Me.cmdSubtract.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(186, 285)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(100, 40)
        Me.cmdDivide.TabIndex = 5
        Me.cmdDivide.Text = "Divide"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(23, 46)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(71, 13)
        Me.label.TabIndex = 6
        Me.label.Text = "Number one :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number two :"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(26, 125)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(145, 13)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "Answer will be displayed here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 353)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.cmdDivide)
        Me.Controls.Add(Me.cmdSubtract)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdMultiply)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdSubtract As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAnswer As Label
End Class
