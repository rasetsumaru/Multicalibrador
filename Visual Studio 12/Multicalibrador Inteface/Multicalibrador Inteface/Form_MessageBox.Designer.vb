<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MessageBox
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
        Me.Button01 = New System.Windows.Forms.Button()
        Me.Button02 = New System.Windows.Forms.Button()
        Me.Button03 = New System.Windows.Forms.Button()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label0001 = New System.Windows.Forms.Label()
        Me.Label0000 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button01
        '
        Me.Button01.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.Button01.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button01.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button01.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button01.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button01.ForeColor = System.Drawing.SystemColors.Control
        Me.Button01.Location = New System.Drawing.Point(413, 26)
        Me.Button01.Name = "Button01"
        Me.Button01.Size = New System.Drawing.Size(90, 26)
        Me.Button01.TabIndex = 2
        Me.Button01.TabStop = False
        Me.Button01.Text = "Button01"
        Me.Button01.UseVisualStyleBackColor = True
        Me.Button01.Visible = False
        '
        'Button02
        '
        Me.Button02.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.Button02.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button02.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button02.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button02.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button02.ForeColor = System.Drawing.SystemColors.Control
        Me.Button02.Location = New System.Drawing.Point(317, 26)
        Me.Button02.Name = "Button02"
        Me.Button02.Size = New System.Drawing.Size(90, 26)
        Me.Button02.TabIndex = 1
        Me.Button02.TabStop = False
        Me.Button02.Text = "Button02"
        Me.Button02.UseVisualStyleBackColor = True
        Me.Button02.Visible = False
        '
        'Button03
        '
        Me.Button03.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.Button03.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button03.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button03.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Button03.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button03.ForeColor = System.Drawing.SystemColors.Control
        Me.Button03.Location = New System.Drawing.Point(221, 26)
        Me.Button03.Name = "Button03"
        Me.Button03.Size = New System.Drawing.Size(90, 26)
        Me.Button03.TabIndex = 0
        Me.Button03.TabStop = False
        Me.Button03.Text = "Button03"
        Me.Button03.UseVisualStyleBackColor = True
        Me.Button03.Visible = False
        '
        'LabelMessage
        '
        Me.LabelMessage.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelMessage.Location = New System.Drawing.Point(13, 119)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(414, 43)
        Me.LabelMessage.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button01)
        Me.Panel1.Controls.Add(Me.Button02)
        Me.Panel1.Controls.Add(Me.Button03)
        Me.Panel1.Location = New System.Drawing.Point(-2, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 83)
        Me.Panel1.TabIndex = 13
        '
        'Label0001
        '
        Me.Label0001.AutoSize = True
        Me.Label0001.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0001.ForeColor = System.Drawing.Color.White
        Me.Label0001.Location = New System.Drawing.Point(14, 48)
        Me.Label0001.Name = "Label0001"
        Me.Label0001.Size = New System.Drawing.Size(105, 21)
        Me.Label0001.TabIndex = 16
        Me.Label0001.Text = "Message box"
        '
        'Label0000
        '
        Me.Label0000.AutoSize = True
        Me.Label0000.Font = New System.Drawing.Font("Arial Unicode MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0000.ForeColor = System.Drawing.Color.White
        Me.Label0000.Location = New System.Drawing.Point(9, 9)
        Me.Label0000.Name = "Label0000"
        Me.Label0000.Size = New System.Drawing.Size(199, 39)
        Me.Label0000.TabIndex = 15
        Me.Label0000.Text = "SGS Interface"
        '
        'Form_MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(534, 248)
        Me.Controls.Add(Me.LabelMessage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label0001)
        Me.Controls.Add(Me.Label0000)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_MessageBox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_MessageBox"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button01 As System.Windows.Forms.Button
    Friend WithEvents Button02 As System.Windows.Forms.Button
    Friend WithEvents Button03 As System.Windows.Forms.Button
    Friend WithEvents LabelMessage As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label0001 As System.Windows.Forms.Label
    Friend WithEvents Label0000 As System.Windows.Forms.Label
End Class
